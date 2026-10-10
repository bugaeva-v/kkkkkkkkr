using System;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A3 RID: 163
	public class InterfaceProxyWithTargetInterfaceTargetContributor : InterfaceProxyTargetContributor
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0000E546 File Offset: 0x0000C746
		public InterfaceProxyWithTargetInterfaceTargetContributor(Type proxyTargetType, bool allowChangeTarget, INamingScope namingScope) : base(proxyTargetType, allowChangeTarget, namingScope)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000E551 File Offset: 0x0000C751
		protected override MembersCollector GetCollectorForInterface(Type @interface)
		{
			return new InterfaceMembersCollector(@interface);
		}
	}
}
