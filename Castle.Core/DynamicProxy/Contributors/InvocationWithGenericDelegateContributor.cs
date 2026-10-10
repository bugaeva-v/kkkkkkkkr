using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A5 RID: 165
	public class InvocationWithGenericDelegateContributor : IInvocationCreationContributor
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x0000E747 File Offset: 0x0000C947
		public InvocationWithGenericDelegateContributor(Type delegateType, MetaMethod method, Reference targetReference)
		{
			this.delegateType = delegateType;
			this.method = method;
			this.targetReference = targetReference;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000E764 File Offset: 0x0000C964
		public ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation)
		{
			return invocation.CreateConstructor(baseCtorArguments);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000E76D File Offset: 0x0000C96D
		public MethodInfo GetCallbackMethod()
		{
			return this.delegateType.GetMethod("Invoke");
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000E77F File Offset: 0x0000C97F
		public MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, Expression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			return new MethodInvocationExpression(this.GetDelegate(invocation, invokeMethodOnTarget), this.GetCallbackMethod(), args);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000E796 File Offset: 0x0000C996
		public Expression[] GetConstructorInvocationArguments(Expression[] arguments, ClassEmitter proxy)
		{
			return arguments;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000E79C File Offset: 0x0000C99C
		private Reference GetDelegate(AbstractTypeEmitter invocation, MethodEmitter invokeMethodOnTarget)
		{
			Type[] typeArguments = invocation.GenericTypeParams.AsTypeArray();
			Type type = this.delegateType.MakeGenericType(typeArguments);
			LocalReference localReference = invokeMethodOnTarget.CodeBuilder.DeclareLocal(type);
			MethodInfo closedMethodOnTarget = this.method.MethodOnTarget.MakeGenericMethod(typeArguments);
			ReferenceExpression localTarget = new ReferenceExpression(this.targetReference);
			invokeMethodOnTarget.CodeBuilder.AddStatement(this.SetDelegate(localReference, localTarget, type, closedMethodOnTarget));
			return localReference;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000E808 File Offset: 0x0000CA08
		private AssignStatement SetDelegate(LocalReference localDelegate, ReferenceExpression localTarget, Type closedDelegateType, MethodInfo closedMethodOnTarget)
		{
			MethodInvocationExpression right = new MethodInvocationExpression(null, DelegateMethods.CreateDelegate, new Expression[]
			{
				new TypeTokenExpression(closedDelegateType),
				localTarget,
				new MethodTokenExpression(closedMethodOnTarget)
			});
			return new AssignStatement(localDelegate, new ConvertExpression(closedDelegateType, right));
		}

		// Token: 0x04000128 RID: 296
		private readonly Type delegateType;

		// Token: 0x04000129 RID: 297
		private readonly MetaMethod method;

		// Token: 0x0400012A RID: 298
		private readonly Reference targetReference;
	}
}
