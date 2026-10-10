using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A4 RID: 164
	public class InvocationWithDelegateContributor : IInvocationCreationContributor
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x0000E559 File Offset: 0x0000C759
		public InvocationWithDelegateContributor(Type delegateType, Type targetType, MetaMethod method, INamingScope namingScope)
		{
			this.delegateType = delegateType;
			this.targetType = targetType;
			this.method = method;
			this.namingScope = namingScope;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000E580 File Offset: 0x0000C780
		public ConstructorEmitter CreateConstructor(ArgumentReference[] baseCtorArguments, AbstractTypeEmitter invocation)
		{
			ArgumentReference[] arguments = this.GetArguments(baseCtorArguments);
			ConstructorEmitter constructorEmitter = invocation.CreateConstructor(arguments);
			FieldReference target = invocation.CreateField("delegate", this.delegateType);
			constructorEmitter.CodeBuilder.AddStatement(new AssignStatement(target, new ReferenceExpression(arguments[0])));
			return constructorEmitter;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		public MethodInfo GetCallbackMethod()
		{
			return this.delegateType.GetMethod("Invoke");
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, Expression[] args, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			Expression[] allArgs = this.GetAllArgs(args, targetField);
			return new MethodInvocationExpression(invocation.GetField("delegate"), this.GetCallbackMethod(), allArgs);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000E60C File Offset: 0x0000C80C
		public Expression[] GetConstructorInvocationArguments(Expression[] arguments, ClassEmitter proxy)
		{
			Expression[] array = new Expression[arguments.Length + 1];
			array[0] = new ReferenceExpression(this.BuildDelegateToken(proxy));
			Array.Copy(arguments, 0, array, 1, arguments.Length);
			return array;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000E640 File Offset: 0x0000C840
		private FieldReference BuildDelegateToken(ClassEmitter proxy)
		{
			FieldReference fieldReference = proxy.CreateStaticField(this.namingScope.GetUniqueName("callback_" + this.method.Method.Name), this.delegateType);
			MethodInvocationExpression right = new MethodInvocationExpression(null, DelegateMethods.CreateDelegate, new Expression[]
			{
				new TypeTokenExpression(this.delegateType),
				NullExpression.Instance,
				new MethodTokenExpression(this.method.MethodOnTarget)
			});
			AssignStatement stmt = new AssignStatement(fieldReference, new ConvertExpression(this.delegateType, right));
			proxy.ClassConstructor.CodeBuilder.AddStatement(stmt);
			return fieldReference;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		private Expression[] GetAllArgs(Expression[] args, Reference targetField)
		{
			Expression[] array = new Expression[args.Length + 1];
			args.CopyTo(array, 1);
			array[0] = new ConvertExpression(this.targetType, targetField.ToExpression());
			return array;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000E718 File Offset: 0x0000C918
		private ArgumentReference[] GetArguments(ArgumentReference[] baseCtorArguments)
		{
			ArgumentReference[] array = new ArgumentReference[baseCtorArguments.Length + 1];
			array[0] = new ArgumentReference(this.delegateType);
			baseCtorArguments.CopyTo(array, 1);
			return array;
		}

		// Token: 0x04000124 RID: 292
		private readonly Type delegateType;

		// Token: 0x04000125 RID: 293
		private readonly MetaMethod method;

		// Token: 0x04000126 RID: 294
		private readonly INamingScope namingScope;

		// Token: 0x04000127 RID: 295
		private readonly Type targetType;
	}
}
