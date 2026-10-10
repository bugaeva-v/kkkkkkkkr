using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200003C RID: 60
	public readonly struct CoreRegistration
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00002D60 File Offset: 0x00000F60
		internal CoreRegistration(IPackageRegistry registry, int packageHash)
		{
			this.m_Registry = registry;
			this.m_PackageHash = packageHash;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002D70 File Offset: 0x00000F70
		public CoreRegistration DependsOn<T>() where T : IServiceComponent
		{
			this.m_Registry.RegisterDependency<T>(this.m_PackageHash);
			return this;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002D89 File Offset: 0x00000F89
		public CoreRegistration OptionallyDependsOn<T>() where T : IServiceComponent
		{
			this.m_Registry.RegisterOptionalDependency<T>(this.m_PackageHash);
			return this;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public CoreRegistration ProvidesComponent<T>() where T : IServiceComponent
		{
			this.m_Registry.RegisterProvision<T>(this.m_PackageHash);
			return this;
		}

		// Token: 0x0400003C RID: 60
		private readonly IPackageRegistry m_Registry;

		// Token: 0x0400003D RID: 61
		private readonly int m_PackageHash;
	}
}
