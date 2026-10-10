using System;
using System.Reflection;
using System.Runtime.Serialization;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Serialization;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000AB RID: 171
	public abstract class ProxyInstanceContributor : ITypeContributor
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x0000F17F File Offset: 0x0000D37F
		protected ProxyInstanceContributor(Type targetType, Type[] interfaces, string proxyTypeId)
		{
			this.targetType = targetType;
			this.proxyTypeId = proxyTypeId;
			this.interfaces = (interfaces ?? Type.EmptyTypes);
		}

		// Token: 0x06000424 RID: 1060
		protected abstract Reference GetTargetReference(ClassEmitter emitter);

		// Token: 0x06000425 RID: 1061 RVA: 0x0000F1A5 File Offset: 0x0000D3A5
		private Expression GetTargetReferenceExpression(ClassEmitter emitter)
		{
			return this.GetTargetReference(emitter).ToExpression();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		public virtual void Generate(ClassEmitter @class, ProxyGenerationOptions options)
		{
			FieldReference field = @class.GetField("__interceptors");
			this.ImplementGetObjectData(@class);
			this.ImplementProxyTargetAccessor(@class, field);
			foreach (CustomAttributeInfo customAttributeInfo in this.targetType.GetTypeInfo().GetNonInheritableAttributes())
			{
				@class.DefineCustomAttribute(customAttributeInfo.Builder);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000F22C File Offset: 0x0000D42C
		protected void ImplementProxyTargetAccessor(ClassEmitter emitter, FieldReference interceptorsField)
		{
			emitter.CreateMethod("DynProxyGetTarget", typeof(object), new Type[0]).CodeBuilder.AddStatement(new ReturnStatement(new ConvertExpression(typeof(object), this.targetType, this.GetTargetReferenceExpression(emitter))));
			MethodEmitter methodEmitter = emitter.CreateMethod("DynProxySetTarget", typeof(void), new Type[]
			{
				typeof(object)
			});
			FieldReference fieldReference = this.GetTargetReference(emitter) as FieldReference;
			if (fieldReference != null)
			{
				methodEmitter.CodeBuilder.AddStatement(new AssignStatement(fieldReference, new ConvertExpression(fieldReference.Fieldbuilder.FieldType, methodEmitter.Arguments[0].ToExpression())));
			}
			else
			{
				methodEmitter.CodeBuilder.AddStatement(new ThrowStatement(typeof(InvalidOperationException), "Cannot change the target of the class proxy."));
			}
			methodEmitter.CodeBuilder.AddStatement(new ReturnStatement());
			emitter.CreateMethod("GetInterceptors", typeof(IInterceptor[]), new Type[0]).CodeBuilder.AddStatement(new ReturnStatement(interceptorsField));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000F348 File Offset: 0x0000D548
		protected void ImplementGetObjectData(ClassEmitter emitter)
		{
			MethodEmitter methodEmitter = emitter.CreateMethod("GetObjectData", typeof(void), new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			});
			ArgumentReference argumentReference = methodEmitter.Arguments[0];
			LocalReference localReference = methodEmitter.CodeBuilder.DeclareLocal(typeof(Type));
			methodEmitter.CodeBuilder.AddStatement(new AssignStatement(localReference, new MethodInvocationExpression(null, TypeMethods.StaticGetType, new Expression[]
			{
				new ConstReference(typeof(ProxyObjectReference).AssemblyQualifiedName).ToExpression(),
				new ConstReference(1).ToExpression(),
				new ConstReference(0).ToExpression()
			})));
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(argumentReference, SerializationInfoMethods.SetType, new Expression[]
			{
				localReference.ToExpression()
			})));
			foreach (FieldReference fieldReference in emitter.GetAllFields())
			{
				if (!fieldReference.Reference.IsStatic && !fieldReference.Reference.IsNotSerialized)
				{
					this.AddAddValueInvocation(argumentReference, methodEmitter, fieldReference);
				}
			}
			LocalReference localReference2 = methodEmitter.CodeBuilder.DeclareLocal(typeof(string[]));
			methodEmitter.CodeBuilder.AddStatement(new AssignStatement(localReference2, new NewArrayExpression(this.interfaces.Length, typeof(string))));
			for (int i = 0; i < this.interfaces.Length; i++)
			{
				methodEmitter.CodeBuilder.AddStatement(new AssignArrayStatement(localReference2, i, new ConstReference(this.interfaces[i].AssemblyQualifiedName).ToExpression()));
			}
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(argumentReference, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__interfaces").ToExpression(),
				localReference2.ToExpression()
			})));
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(argumentReference, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__baseType").ToExpression(),
				new ConstReference(emitter.BaseType.AssemblyQualifiedName).ToExpression()
			})));
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(argumentReference, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__proxyGenerationOptions").ToExpression(),
				emitter.GetField("proxyGenerationOptions").ToExpression()
			})));
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(argumentReference, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__proxyTypeId").ToExpression(),
				new ConstReference(this.proxyTypeId).ToExpression()
			})));
			this.CustomizeGetObjectData(methodEmitter.CodeBuilder, argumentReference, methodEmitter.Arguments[1], emitter);
			methodEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000F660 File Offset: 0x0000D860
		protected virtual void AddAddValueInvocation(ArgumentReference serializationInfo, MethodEmitter getObjectData, FieldReference field)
		{
			getObjectData.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(serializationInfo, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference(field.Reference.Name).ToExpression(),
				field.ToExpression()
			})));
		}

		// Token: 0x0600042A RID: 1066
		protected abstract void CustomizeGetObjectData(AbstractCodeBuilder builder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter);

		// Token: 0x0600042B RID: 1067 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		public void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
		}

		// Token: 0x04000137 RID: 311
		protected readonly Type targetType;

		// Token: 0x04000138 RID: 312
		private readonly string proxyTypeId;

		// Token: 0x04000139 RID: 313
		private readonly Type[] interfaces;
	}
}
