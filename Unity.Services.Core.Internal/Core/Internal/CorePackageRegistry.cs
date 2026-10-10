using System;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200003B RID: 59
	public sealed class CorePackageRegistry
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002CEA File Offset: 0x00000EEA
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public static CorePackageRegistry Instance { get; internal set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002CF9 File Offset: 0x00000EF9
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002D01 File Offset: 0x00000F01
		internal IPackageRegistry Registry { get; set; }

		// Token: 0x060000F7 RID: 247 RVA: 0x00002D0A File Offset: 0x00000F0A
		internal CorePackageRegistry()
		{
			this.Registry = new PackageRegistry(new DependencyTree());
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002D22 File Offset: 0x00000F22
		internal CorePackageRegistry(IPackageRegistry registry)
		{
			this.Registry = registry;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002D31 File Offset: 0x00000F31
		public CoreRegistration Register<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return this.Registry.RegisterPackage<TPackage>(package);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002D3F File Offset: 0x00000F3F
		internal void Lock()
		{
			if (this.Registry is LockedPackageRegistry)
			{
				return;
			}
			this.Registry = new LockedPackageRegistry(this.Registry);
		}
	}
}
