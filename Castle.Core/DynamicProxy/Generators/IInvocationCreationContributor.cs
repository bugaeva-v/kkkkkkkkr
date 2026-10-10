using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000039 RID: 57
	public interface IInvocationCreationContributor
	{
		// Token: 0x060001C3 RID: 451
		ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation);

		// Token: 0x060001C4 RID: 452
		MethodInfo GetCallbackMethod();

		// Token: 0x060001C5 RID: 453
		MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, Expression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget);

		// Token: 0x060001C6 RID: 454
		Expression[] GetConstructorInvocationArguments(Expression[] arguments, ClassEmitter proxy);
	}
}
