using System;

namespace Castle.DynamicProxy
{
	// Token: 0x02000016 RID: 22
	public class PersistentProxyBuilder : DefaultProxyBuilder
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00003964 File Offset: 0x00001B64
		public PersistentProxyBuilder() : base(new ModuleScope(true))
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003972 File Offset: 0x00001B72
		public string SaveAssembly()
		{
			return base.ModuleScope.SaveAssembly();
		}
	}
}
