using System;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200003D RID: 61
	public sealed class CoreRegistry
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002DBB File Offset: 0x00000FBB
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public static CoreRegistry Instance { get; internal set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002DCA File Offset: 0x00000FCA
		public string InstanceId { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002DD2 File Offset: 0x00000FD2
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002DDA File Offset: 0x00000FDA
		internal ServicesType Type { get; private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002DE3 File Offset: 0x00000FE3
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002DEB File Offset: 0x00000FEB
		internal InitializationOptions Options { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002DF4 File Offset: 0x00000FF4
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002DFC File Offset: 0x00000FFC
		[NotNull]
		internal IPackageRegistry PackageRegistry { get; private set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002E05 File Offset: 0x00001005
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002E0D File Offset: 0x0000100D
		[NotNull]
		internal IComponentRegistry ComponentRegistry { get; private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002E16 File Offset: 0x00001016
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002E1E File Offset: 0x0000101E
		[NotNull]
		internal IServiceRegistry ServiceRegistry { get; private set; }

		// Token: 0x0600010C RID: 268 RVA: 0x00002E27 File Offset: 0x00001027
		internal CoreRegistry()
		{
			this.Type = ServicesType.Default;
			this.InstanceId = null;
			this.PackageRegistry = new PackageRegistry(new DependencyTree());
			this.ComponentRegistry = new ComponentRegistry();
			this.ServiceRegistry = new ServiceRegistry();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002E63 File Offset: 0x00001063
		internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = ServicesType.Default, string instanceId = null)
		{
			this.Type = type;
			this.InstanceId = instanceId;
			this.PackageRegistry = packageRegistry;
			this.ComponentRegistry = new ComponentRegistry();
			this.ServiceRegistry = new ServiceRegistry();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002E96 File Offset: 0x00001096
		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return this.PackageRegistry.RegisterPackage<TPackage>(package);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002EA4 File Offset: 0x000010A4
		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent
		{
			this.ComponentRegistry.RegisterServiceComponent<TComponent>(component);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002EB2 File Offset: 0x000010B2
		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return this.ComponentRegistry.GetServiceComponent<TComponent>();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002EBF File Offset: 0x000010BF
		public bool TryGetServiceComponent<TComponent>(out TComponent component) where TComponent : IServiceComponent
		{
			return this.ComponentRegistry.TryGetServiceComponent<TComponent>(out component);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002ECD File Offset: 0x000010CD
		public void RegisterService<T>([NotNull] T service)
		{
			this.ServiceRegistry.RegisterService<T>(service);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002EDB File Offset: 0x000010DB
		public T GetService<T>()
		{
			return this.ServiceRegistry.GetService<T>();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002EE8 File Offset: 0x000010E8
		internal void LockComponentRegistration()
		{
			if (this.ComponentRegistry is LockedComponentRegistry)
			{
				return;
			}
			this.ComponentRegistry = new LockedComponentRegistry(this.ComponentRegistry);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002F09 File Offset: 0x00001109
		internal void LockServiceRegistration()
		{
			if (this.ServiceRegistry is LockedServiceRegistry)
			{
				return;
			}
			this.ServiceRegistry = new LockedServiceRegistry(this.ServiceRegistry);
		}
	}
}
