using System;
using System.Reflection;
using Castle.DynamicProxy.Contributors;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000033 RID: 51
	public class DelegateMembersCollector : MembersCollector
	{
		// Token: 0x060001AB RID: 427 RVA: 0x000071FE File Offset: 0x000053FE
		public DelegateMembersCollector(Type type) : base(type)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007207 File Offset: 0x00005407
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (!base.AcceptMethod(method, true, hook))
			{
				return null;
			}
			return new MetaMethod(method, method, isStandalone, true, !method.IsAbstract);
		}
	}
}
