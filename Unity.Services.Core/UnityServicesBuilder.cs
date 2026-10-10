using System;

namespace Unity.Services.Core
{
	// Token: 0x0200000F RID: 15
	internal static class UnityServicesBuilder
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000258D File Offset: 0x0000078D
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002594 File Offset: 0x00000794
		internal static UnityServicesBuilder.CreationDelegate InstanceCreationDelegate { get; set; }

		// Token: 0x06000046 RID: 70 RVA: 0x0000259C File Offset: 0x0000079C
		public static IUnityServices Create(string servicesId)
		{
			if (UnityServicesBuilder.InstanceCreationDelegate == null)
			{
				throw new ServicesCreationException("Error creating services. The creation delegate has not been initialized.");
			}
			return UnityServicesBuilder.InstanceCreationDelegate(servicesId);
		}

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600004E RID: 78
		internal delegate IUnityServices CreationDelegate(string servicesId);
	}
}
