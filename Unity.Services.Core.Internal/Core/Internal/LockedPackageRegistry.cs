using System;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200004C RID: 76
	internal class LockedPackageRegistry : IPackageRegistry
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000037A0 File Offset: 0x000019A0
		[NotNull]
		internal IPackageRegistry Registry { get; }

		// Token: 0x06000144 RID: 324 RVA: 0x000037A8 File Offset: 0x000019A8
		public LockedPackageRegistry([NotNull] IPackageRegistry registryToLock)
		{
			this.Registry = registryToLock;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000037B7 File Offset: 0x000019B7
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000037C4 File Offset: 0x000019C4
		public DependencyTree Tree
		{
			get
			{
				return this.Registry.Tree;
			}
			set
			{
				this.Registry.Tree = value;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000037D2 File Offset: 0x000019D2
		public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
		{
			throw new InvalidOperationException("Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000037DE File Offset: 0x000019DE
		public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			throw new InvalidOperationException("Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].");
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000037EA File Offset: 0x000019EA
		public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			throw new InvalidOperationException("Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000037F6 File Offset: 0x000019F6
		public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			throw new InvalidOperationException("Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].");
		}

		// Token: 0x04000052 RID: 82
		private const string k_ErrorMessage = "Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].";
	}
}
