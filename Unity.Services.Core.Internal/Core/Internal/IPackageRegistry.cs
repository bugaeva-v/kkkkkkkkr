using System;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200004B RID: 75
	internal interface IPackageRegistry
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013D RID: 317
		// (set) Token: 0x0600013E RID: 318
		[CanBeNull]
		DependencyTree Tree { get; set; }

		// Token: 0x0600013F RID: 319
		CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage;

		// Token: 0x06000140 RID: 320
		void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;

		// Token: 0x06000141 RID: 321
		void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;

		// Token: 0x06000142 RID: 322
		void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent;
	}
}
