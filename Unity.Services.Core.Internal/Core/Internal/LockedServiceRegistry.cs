using System;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200004F RID: 79
	internal class LockedServiceRegistry : IServiceRegistry
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00003963 File Offset: 0x00001B63
		[NotNull]
		internal IServiceRegistry Registry { get; }

		// Token: 0x06000156 RID: 342 RVA: 0x0000396B File Offset: 0x00001B6B
		public LockedServiceRegistry([NotNull] IServiceRegistry registryToLock)
		{
			this.Registry = registryToLock;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000397A File Offset: 0x00001B7A
		public void RegisterService<T>(T service)
		{
			throw new InvalidOperationException("Service registration has been locked. Make sure to register service services before all packages have finished initializing.");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003986 File Offset: 0x00001B86
		public T GetService<T>()
		{
			return this.Registry.GetService<T>();
		}

		// Token: 0x04000055 RID: 85
		private const string k_ErrorMessage = "Service registration has been locked. Make sure to register service services before all packages have finished initializing.";
	}
}
