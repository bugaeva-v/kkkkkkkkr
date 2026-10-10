using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200003A RID: 58
	internal class LockedComponentRegistry : IComponentRegistry
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[NotNull]
		internal IComponentRegistry Registry { get; }

		// Token: 0x060000EE RID: 238 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public LockedComponentRegistry([NotNull] IComponentRegistry registryToLock)
		{
			this.Registry = registryToLock;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002CB7 File Offset: 0x00000EB7
		public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
		{
			throw new InvalidOperationException("Component registration has been locked. Make sure to register service components before all packages have finished initializing.");
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002CC3 File Offset: 0x00000EC3
		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return this.Registry.GetServiceComponent<TComponent>();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public bool TryGetServiceComponent<TComponent>(out TComponent component) where TComponent : IServiceComponent
		{
			return this.Registry.TryGetServiceComponent<TComponent>(out component);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002CDE File Offset: 0x00000EDE
		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
			throw new InvalidOperationException("Component registration has been locked. Make sure to register service components before all packages have finished initializing.");
		}

		// Token: 0x04000038 RID: 56
		private const string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing.";
	}
}
