using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009D RID: 157
	public class InterfaceMembersCollector : MembersCollector
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0000E0B9 File Offset: 0x0000C2B9
		public InterfaceMembersCollector(Type @interface) : base(@interface)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (!ProxyUtil.IsAccessibleMethod(method))
			{
				return null;
			}
			bool proxyable = base.AcceptMethod(method, false, hook);
			return new MetaMethod(method, method, isStandalone, proxyable, false);
		}
	}
}
