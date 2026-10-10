using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000032 RID: 50
	public class CompositionInvocationTypeGenerator : InvocationTypeGenerator
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x0000712C File Offset: 0x0000532C
		public CompositionInvocationTypeGenerator(Type target, MetaMethod method, MethodInfo callback, bool canChangeTarget, IInvocationCreationContributor contributor) : base(target, method, callback, canChangeTarget, contributor)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000713C File Offset: 0x0000533C
		protected override ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, ProxyGenerationOptions proxyGenerationOptions, out ConstructorInfo baseConstructor)
		{
			baseConstructor = InvocationMethods.CompositionInvocationConstructor;
			return new ArgumentReference[]
			{
				new ArgumentReference(targetFieldType),
				new ArgumentReference(typeof(object)),
				new ArgumentReference(typeof(IInterceptor[])),
				new ArgumentReference(typeof(MethodInfo)),
				new ArgumentReference(typeof(object[]))
			};
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000071A7 File Offset: 0x000053A7
		protected override Type GetBaseType()
		{
			return CompositionInvocationTypeGenerator.BaseType;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000071AE File Offset: 0x000053AE
		protected override FieldReference GetTargetReference()
		{
			return new FieldReference(InvocationMethods.CompositionInvocationTarget);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000071BA File Offset: 0x000053BA
		protected override void ImplementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, MethodEmitter invokeMethodOnTarget, Reference targetField)
		{
			invokeMethodOnTarget.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(SelfReference.Self, InvocationMethods.CompositionInvocationEnsureValidTarget, new Expression[0])));
			base.ImplementInvokeMethodOnTarget(invocation, parameters, invokeMethodOnTarget, targetField);
		}

		// Token: 0x04000071 RID: 113
		public static readonly Type BaseType = typeof(CompositionInvocation);
	}
}
