using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200003F RID: 63
	internal class DependencyTree
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00002F83 File Offset: 0x00001183
		internal DependencyTree() : this(new Dictionary<int, IInitializablePackage>(), new Dictionary<int, int>(), new Dictionary<int, List<int>>(), new Dictionary<int, IServiceComponent>())
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002F9F File Offset: 0x0000119F
		internal DependencyTree(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance)
		{
			this.PackageTypeHashToInstance = packageToInstance;
			this.ComponentTypeHashToPackageTypeHash = componentToPackage;
			this.PackageTypeHashToComponentTypeHashDependencies = packageToComponentDependencies;
			this.ComponentTypeHashToInstance = componentToInstance;
		}

		// Token: 0x04000047 RID: 71
		public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance;

		// Token: 0x04000048 RID: 72
		public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash;

		// Token: 0x04000049 RID: 73
		public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies;

		// Token: 0x0400004A RID: 74
		public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance;
	}
}
