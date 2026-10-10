using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000090 RID: 144
	public class ClassProxyInstanceContributor : ProxyInstanceContributor
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0000CE60 File Offset: 0x0000B060
		public ClassProxyInstanceContributor(Type targetType, IList<MethodInfo> methodsToSkip, Type[] interfaces, string typeId) : base(targetType, interfaces, typeId)
		{
			if (targetType.IsSerializable)
			{
				this.implementISerializable = true;
				this.delegateToBaseGetObjectData = this.VerifyIfBaseImplementsGetObjectData(targetType, methodsToSkip);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000CE94 File Offset: 0x0000B094
		protected override Reference GetTargetReference(ClassEmitter emitter)
		{
			return SelfReference.Self;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public override void Generate(ClassEmitter @class, ProxyGenerationOptions options)
		{
			FieldReference field = @class.GetField("__interceptors");
			if (this.implementISerializable)
			{
				base.ImplementGetObjectData(@class);
				this.Constructor(@class);
			}
			base.ImplementProxyTargetAccessor(@class, field);
			foreach (CustomAttributeInfo customAttributeInfo in this.targetType.GetTypeInfo().GetNonInheritableAttributes())
			{
				@class.DefineCustomAttribute(customAttributeInfo.Builder);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000CF24 File Offset: 0x0000B124
		protected override void AddAddValueInvocation(ArgumentReference serializationInfo, MethodEmitter getObjectData, FieldReference field)
		{
			this.serializedFields.Add(field);
			base.AddAddValueInvocation(serializationInfo, getObjectData, field);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000CF3C File Offset: 0x0000B13C
		protected override void CustomizeGetObjectData(AbstractCodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter)
		{
			codebuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(serializationInfo, SerializationInfoMethods.AddValue_Bool, new Expression[]
			{
				new ConstReference("__delegateToBase").ToExpression(),
				new ConstReference(this.delegateToBaseGetObjectData).ToExpression()
			})));
			if (!this.delegateToBaseGetObjectData)
			{
				this.EmitCustomGetObjectData(codebuilder, serializationInfo);
				return;
			}
			this.EmitCallToBaseGetObjectData(codebuilder, serializationInfo, streamingContext);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		private void EmitCustomGetObjectData(AbstractCodeBuilder codebuilder, ArgumentReference serializationInfo)
		{
			LocalReference localReference = codebuilder.DeclareLocal(typeof(MemberInfo[]));
			LocalReference localReference2 = codebuilder.DeclareLocal(typeof(object[]));
			MethodInvocationExpression expression = new MethodInvocationExpression(null, FormatterServicesMethods.GetSerializableMembers, new Expression[]
			{
				new TypeTokenExpression(this.targetType)
			});
			codebuilder.AddStatement(new AssignStatement(localReference, expression));
			MethodInvocationExpression expression2 = new MethodInvocationExpression(null, TypeUtilMethods.Sort, new Expression[]
			{
				localReference.ToExpression()
			});
			codebuilder.AddStatement(new AssignStatement(localReference, expression2));
			MethodInvocationExpression expression3 = new MethodInvocationExpression(null, FormatterServicesMethods.GetObjectData, new Expression[]
			{
				SelfReference.Self.ToExpression(),
				localReference.ToExpression()
			});
			codebuilder.AddStatement(new AssignStatement(localReference2, expression3));
			MethodInvocationExpression expression4 = new MethodInvocationExpression(serializationInfo, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__data").ToExpression(),
				localReference2.ToExpression()
			});
			codebuilder.AddStatement(new ExpressionStatement(expression4));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		private void EmitCallToBaseGetObjectData(AbstractCodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext)
		{
			MethodInfo method = this.targetType.GetMethod("GetObjectData", new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			});
			codebuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(method, new Expression[]
			{
				serializationInfo.ToExpression(),
				streamingContext.ToExpression()
			})));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000D110 File Offset: 0x0000B310
		private void Constructor(ClassEmitter emitter)
		{
			if (!this.delegateToBaseGetObjectData)
			{
				return;
			}
			this.GenerateSerializationConstructor(emitter);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000D124 File Offset: 0x0000B324
		private void GenerateSerializationConstructor(ClassEmitter emitter)
		{
			ArgumentReference argumentReference = new ArgumentReference(typeof(SerializationInfo));
			ArgumentReference argumentReference2 = new ArgumentReference(typeof(StreamingContext));
			ConstructorEmitter constructorEmitter = emitter.CreateConstructor(new ArgumentReference[]
			{
				argumentReference,
				argumentReference2
			});
			constructorEmitter.CodeBuilder.AddStatement(new ConstructorInvocationStatement(this.serializationConstructor, new Expression[]
			{
				argumentReference.ToExpression(),
				argumentReference2.ToExpression()
			}));
			foreach (FieldReference fieldReference in this.serializedFields)
			{
				MethodInvocationExpression right = new MethodInvocationExpression(argumentReference, SerializationInfoMethods.GetValue, new Expression[]
				{
					new ConstReference(fieldReference.Reference.Name).ToExpression(),
					new TypeTokenExpression(fieldReference.Reference.FieldType)
				});
				constructorEmitter.CodeBuilder.AddStatement(new AssignStatement(fieldReference, new ConvertExpression(fieldReference.Reference.FieldType, typeof(object), right)));
			}
			constructorEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000D250 File Offset: 0x0000B450
		private bool VerifyIfBaseImplementsGetObjectData(Type baseType, IList<MethodInfo> methodsToSkip)
		{
			if (!typeof(ISerializable).IsAssignableFrom(baseType))
			{
				return false;
			}
			if (baseType.IsDelegateType())
			{
				return false;
			}
			MethodInfo methodInfo = baseType.GetInterfaceMap(typeof(ISerializable)).TargetMethods[0];
			if (methodInfo.IsPrivate)
			{
				return false;
			}
			if (!methodInfo.IsVirtual || methodInfo.IsFinal)
			{
				throw new ArgumentException(string.Format("The type {0} implements ISerializable, but GetObjectData is not marked as virtual. Dynamic Proxy needs types implementing ISerializable to mark GetObjectData as virtual to ensure correct serialization process.", baseType.FullName));
			}
			methodsToSkip.Add(methodInfo);
			this.serializationConstructor = baseType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (this.serializationConstructor == null)
			{
				throw new ArgumentException(string.Format("The type {0} implements ISerializable, but failed to provide a deserialization constructor", baseType.FullName));
			}
			return true;
		}

		// Token: 0x0400010A RID: 266
		private readonly bool delegateToBaseGetObjectData;

		// Token: 0x0400010B RID: 267
		private readonly bool implementISerializable;

		// Token: 0x0400010C RID: 268
		private ConstructorInfo serializationConstructor;

		// Token: 0x0400010D RID: 269
		private readonly IList<FieldReference> serializedFields = new List<FieldReference>();
	}
}
