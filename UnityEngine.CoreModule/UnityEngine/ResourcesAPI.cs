using System;

namespace UnityEngine
{
	// Token: 0x020001EB RID: 491
	public class ResourcesAPI
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x000237FD File Offset: 0x000219FD
		internal static ResourcesAPI ActiveAPI
		{
			get
			{
				return ResourcesAPI.overrideAPI ?? ResourcesAPI.s_DefaultAPI;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0002380D File Offset: 0x00021A0D
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00023814 File Offset: 0x00021A14
		public static ResourcesAPI overrideAPI { get; set; }

		// Token: 0x0600162B RID: 5675 RVA: 0x00008CE3 File Offset: 0x00006EE3
		protected internal ResourcesAPI()
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0002381C File Offset: 0x00021A1C
		protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance)
		{
			return ResourcesAPIInternal.FindObjectsOfTypeAll(systemTypeInstance);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00023824 File Offset: 0x00021A24
		protected internal virtual Shader FindShaderByName(string name)
		{
			return ResourcesAPIInternal.FindShaderByName(name);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0002382C File Offset: 0x00021A2C
		protected internal virtual Object Load(string path, Type systemTypeInstance)
		{
			return ResourcesAPIInternal.Load(path, systemTypeInstance);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00023835 File Offset: 0x00021A35
		protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			return ResourcesAPIInternal.LoadAll(path, systemTypeInstance);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00023840 File Offset: 0x00021A40
		protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			ResourceRequest resourceRequest = ResourcesAPIInternal.LoadAsyncInternal(path, systemTypeInstance);
			resourceRequest.m_Path = path;
			resourceRequest.m_Type = systemTypeInstance;
			return resourceRequest;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00023869 File Offset: 0x00021A69
		protected internal virtual void UnloadAsset(Object assetToUnload)
		{
			ResourcesAPIInternal.UnloadAsset(assetToUnload);
		}

		// Token: 0x040007CC RID: 1996
		private static ResourcesAPI s_DefaultAPI = new ResourcesAPI();
	}
}
