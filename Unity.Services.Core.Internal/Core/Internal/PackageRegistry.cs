using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200004D RID: 77
	internal class PackageRegistry : IPackageRegistry
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00003802 File Offset: 0x00001A02
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000380A File Offset: 0x00001A0A
		public DependencyTree Tree { get; set; }

		// Token: 0x0600014D RID: 333 RVA: 0x00003813 File Offset: 0x00001A13
		public PackageRegistry([CanBeNull] DependencyTree tree)
		{
			this.Tree = tree;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003824 File Offset: 0x00001A24
		public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
		{
			int hashCode = typeof(TPackage).GetHashCode();
			this.Tree.PackageTypeHashToInstance[hashCode] = package;
			this.Tree.PackageTypeHashToComponentTypeHashDependencies[hashCode] = new List<int>();
			return new CoreRegistration(this, hashCode);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003878 File Offset: 0x00001A78
		public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			Type typeFromHandle = typeof(TComponent);
			int hashCode = typeFromHandle.GetHashCode();
			this.Tree.ComponentTypeHashToInstance[hashCode] = new MissingComponent(typeFromHandle);
			this.AddComponentDependencyToPackage(hashCode, packageTypeHash);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000038B8 File Offset: 0x00001AB8
		public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			int hashCode = typeof(TComponent).GetHashCode();
			if (!this.Tree.ComponentTypeHashToInstance.ContainsKey(hashCode))
			{
				this.Tree.ComponentTypeHashToInstance[hashCode] = null;
			}
			this.AddComponentDependencyToPackage(hashCode, packageTypeHash);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003904 File Offset: 0x00001B04
		public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
			int hashCode = typeof(TComponent).GetHashCode();
			this.Tree.ComponentTypeHashToPackageTypeHash[hashCode] = packageTypeHash;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003934 File Offset: 0x00001B34
		private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash)
		{
			List<int> list = this.Tree.PackageTypeHashToComponentTypeHashDependencies[packageTypeHash];
			if (!list.Contains(componentTypeHash))
			{
				list.Add(componentTypeHash);
			}
		}
	}
}
