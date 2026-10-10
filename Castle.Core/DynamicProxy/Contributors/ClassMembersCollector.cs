using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200008F RID: 143
	public class ClassMembersCollector : MembersCollector
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0000CE15 File Offset: 0x0000B015
		public ClassMembersCollector(Type targetType) : base(targetType)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000CE20 File Offset: 0x0000B020
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (!ProxyUtil.IsAccessibleMethod(method))
			{
				return null;
			}
			bool flag = base.AcceptMethod(method, true, hook);
			if (!flag && !method.IsAbstract)
			{
				return null;
			}
			return new MetaMethod(method, method, isStandalone, flag, !method.IsAbstract);
		}
	}
}
