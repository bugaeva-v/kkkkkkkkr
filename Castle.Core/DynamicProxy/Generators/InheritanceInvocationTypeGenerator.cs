using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003B RID: 59
	public class InheritanceInvocationTypeGenerator : InvocationTypeGenerator
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000765C File Offset: 0x0000585C
		public InheritanceInvocationTypeGenerator(Type targetType, MetaMethod method, MethodInfo callback, IInvocationCreationContributor contributor) : base(targetType, method, callback, false, contributor)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000766C File Offset: 0x0000586C
		protected override ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, ProxyGenerationOptions proxyGenerationOptions, out ConstructorInfo baseConstructor)
		{
			baseConstructor = InvocationMethods.InheritanceInvocationConstructor;
			return new ArgumentReference[]
			{
				new ArgumentReference(typeof(Type)),
				new ArgumentReference(typeof(object)),
				new ArgumentReference(typeof(IInterceptor[])),
				new ArgumentReference(typeof(MethodInfo)),
				new ArgumentReference(typeof(object[]))
			};
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000076E0 File Offset: 0x000058E0
		protected override Type GetBaseType()
		{
			return InheritanceInvocationTypeGenerator.BaseType;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000076E7 File Offset: 0x000058E7
		protected override FieldReference GetTargetReference()
		{
			return new FieldReference(InvocationMethods.ProxyObject);
		}

		// Token: 0x04000072 RID: 114
		public static readonly Type BaseType = typeof(InheritanceInvocation);
	}
}
