using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml.Serialization;
using Castle.Core.Internal;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000049 RID: 73
	public class MethodWithInvocationGenerator : MethodGenerator
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000092B4 File Offset: 0x000074B4
		public MethodWithInvocationGenerator(MetaMethod method, Reference interceptors, Type invocation, GetTargetExpressionDelegate getTargetExpression, OverrideMethodDelegate createMethod, IInvocationCreationContributor contributor) : this(method, interceptors, invocation, getTargetExpression, null, createMethod, contributor)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000092C6 File Offset: 0x000074C6
		public MethodWithInvocationGenerator(MetaMethod method, Reference interceptors, Type invocation, GetTargetExpressionDelegate getTargetExpression, GetTargetExpressionDelegate getTargetTypeExpression, OverrideMethodDelegate createMethod, IInvocationCreationContributor contributor) : base(method, createMethod)
		{
			this.invocation = invocation;
			this.getTargetExpression = getTargetExpression;
			this.getTargetTypeExpression = getTargetTypeExpression;
			this.interceptors = interceptors;
			this.contributor = contributor;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000092F8 File Offset: 0x000074F8
		protected FieldReference BuildMethodInterceptorsField(ClassEmitter @class, MethodInfo method, INamingScope namingScope)
		{
			FieldReference fieldReference = @class.CreateField(namingScope.GetUniqueName(string.Format("interceptors_{0}", method.Name)), typeof(IInterceptor[]), false);
			@class.DefineCustomAttributeFor<XmlIgnoreAttribute>(fieldReference);
			return fieldReference;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009338 File Offset: 0x00007538
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			Type type = this.invocation;
			Trace.Assert(base.MethodToOverride.IsGenericMethod == type.GetTypeInfo().IsGenericTypeDefinition);
			Type[] typeArguments = Type.EmptyTypes;
			ConstructorInfo constructor = this.invocation.GetConstructors()[0];
			Expression proxiedMethodTokenExpression;
			if (base.MethodToOverride.IsGenericMethod)
			{
				typeArguments = emitter.MethodBuilder.GetGenericArguments();
				type = type.MakeGenericType(typeArguments);
				constructor = TypeBuilder.GetConstructor(type, constructor);
				proxiedMethodTokenExpression = new MethodTokenExpression(base.MethodToOverride.MakeGenericMethod(typeArguments));
			}
			else
			{
				FieldReference fieldReference = @class.CreateStaticField(namingScope.GetUniqueName("token_" + base.MethodToOverride.Name), typeof(MethodInfo));
				@class.ClassConstructor.CodeBuilder.AddStatement(new AssignStatement(fieldReference, new MethodTokenExpression(base.MethodToOverride)));
				proxiedMethodTokenExpression = fieldReference.ToExpression();
			}
			Expression methodInterceptors = this.SetMethodInterceptors(@class, namingScope, emitter, proxiedMethodTokenExpression);
			TypeReference[] arguments = emitter.Arguments;
			TypeReference[] dereferencedArguments = IndirectReference.WrapIfByRef(arguments);
			bool flag = this.HasByRefArguments(emitter.Arguments);
			Expression[] ctorArguments = this.GetCtorArguments(@class, proxiedMethodTokenExpression, dereferencedArguments, methodInterceptors);
			Expression[] args = this.ModifyArguments(@class, ctorArguments);
			LocalReference localReference = emitter.CodeBuilder.DeclareLocal(type);
			emitter.CodeBuilder.AddStatement(new AssignStatement(localReference, new NewInstanceExpression(constructor, args)));
			if (base.MethodToOverride.ContainsGenericParameters)
			{
				this.EmitLoadGenricMethodArguments(emitter, base.MethodToOverride.MakeGenericMethod(typeArguments), localReference);
			}
			if (flag)
			{
				emitter.CodeBuilder.AddStatement(new TryStatement());
			}
			ExpressionStatement stmt = new ExpressionStatement(new MethodInvocationExpression(localReference, InvocationMethods.Proceed, new Expression[0]));
			emitter.CodeBuilder.AddStatement(stmt);
			if (flag)
			{
				emitter.CodeBuilder.AddStatement(new FinallyStatement());
			}
			GeneratorUtil.CopyOutAndRefParameters(dereferencedArguments, localReference, base.MethodToOverride, emitter);
			if (flag)
			{
				emitter.CodeBuilder.AddStatement(new EndExceptionBlockStatement());
			}
			if (base.MethodToOverride.ReturnType != typeof(void))
			{
				MethodInvocationExpression methodInvocationExpression = new MethodInvocationExpression(localReference, InvocationMethods.GetReturnValue, new Expression[0]);
				if (emitter.ReturnType.GetTypeInfo().IsValueType && !emitter.ReturnType.IsNullableType())
				{
					LocalReference localReference2 = emitter.CodeBuilder.DeclareLocal(typeof(object));
					emitter.CodeBuilder.AddStatement(new AssignStatement(localReference2, methodInvocationExpression));
					emitter.CodeBuilder.AddExpression(new IfNullExpression(localReference2, new ThrowStatement(typeof(InvalidOperationException), "Interceptors failed to set a return value, or swallowed the exception thrown by the target"), null));
				}
				emitter.CodeBuilder.AddStatement(new ReturnStatement(new ConvertExpression(emitter.ReturnType, methodInvocationExpression)));
			}
			else
			{
				emitter.CodeBuilder.AddStatement(new ReturnStatement());
			}
			return emitter;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000095F4 File Offset: 0x000077F4
		private Expression SetMethodInterceptors(ClassEmitter @class, INamingScope namingScope, MethodEmitter emitter, Expression proxiedMethodTokenExpression)
		{
			FieldReference field = @class.GetField("__selector");
			if (field == null)
			{
				return null;
			}
			FieldReference fieldReference = this.BuildMethodInterceptorsField(@class, base.MethodToOverride, namingScope);
			Expression expression;
			if (this.getTargetTypeExpression != null)
			{
				expression = this.getTargetTypeExpression(@class, base.MethodToOverride);
			}
			else
			{
				expression = new MethodInvocationExpression(null, TypeUtilMethods.GetTypeOrNull, new Expression[]
				{
					this.getTargetExpression(@class, base.MethodToOverride)
				});
			}
			NewArrayExpression @default = new NewArrayExpression(0, typeof(IInterceptor));
			MethodInvocationExpression expression2 = new MethodInvocationExpression(field, InterceptorSelectorMethods.SelectInterceptors, new Expression[]
			{
				expression,
				proxiedMethodTokenExpression,
				this.interceptors.ToExpression()
			})
			{
				VirtualCall = true
			};
			emitter.CodeBuilder.AddExpression(new IfNullExpression(fieldReference, new AssignStatement(fieldReference, new NullCoalescingOperatorExpression(expression2, @default)), null));
			return fieldReference.ToExpression();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000096D0 File Offset: 0x000078D0
		private void EmitLoadGenricMethodArguments(MethodEmitter methodEmitter, MethodInfo method, Reference invocationLocal)
		{
			Type[] array = method.GetGenericArguments().FindAll((Type t) => t.GetTypeInfo().IsGenericParameter);
			LocalReference localReference = methodEmitter.CodeBuilder.DeclareLocal(typeof(Type[]));
			methodEmitter.CodeBuilder.AddStatement(new AssignStatement(localReference, new NewArrayExpression(array.Length, typeof(Type))));
			for (int i = 0; i < array.Length; i++)
			{
				methodEmitter.CodeBuilder.AddStatement(new AssignArrayStatement(localReference, i, new TypeTokenExpression(array[i])));
			}
			methodEmitter.CodeBuilder.AddExpression(new MethodInvocationExpression(invocationLocal, InvocationMethods.SetGenericMethodArguments, new Expression[]
			{
				new ReferenceExpression(localReference)
			}));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009794 File Offset: 0x00007994
		private Expression[] GetCtorArguments(ClassEmitter @class, Expression proxiedMethodTokenExpression, TypeReference[] dereferencedArguments, Expression methodInterceptors)
		{
			return new Expression[]
			{
				this.getTargetExpression(@class, base.MethodToOverride),
				SelfReference.Self.ToExpression(),
				methodInterceptors ?? this.interceptors.ToExpression(),
				proxiedMethodTokenExpression,
				new ReferencesToObjectArrayExpression(dereferencedArguments)
			};
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000097EA File Offset: 0x000079EA
		private Expression[] ModifyArguments(ClassEmitter @class, Expression[] arguments)
		{
			if (this.contributor == null)
			{
				return arguments;
			}
			return this.contributor.GetConstructorInvocationArguments(arguments, @class);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009804 File Offset: 0x00007A04
		private bool HasByRefArguments(ArgumentReference[] arguments)
		{
			for (int i = 0; i < arguments.Length; i++)
			{
				if (arguments[i].Type.GetTypeInfo().IsByRef)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000098 RID: 152
		private readonly IInvocationCreationContributor contributor;

		// Token: 0x04000099 RID: 153
		private readonly GetTargetExpressionDelegate getTargetExpression;

		// Token: 0x0400009A RID: 154
		private readonly GetTargetExpressionDelegate getTargetTypeExpression;

		// Token: 0x0400009B RID: 155
		private readonly Reference interceptors;

		// Token: 0x0400009C RID: 156
		private readonly Type invocation;
	}
}
