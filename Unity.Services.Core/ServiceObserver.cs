using System;

namespace Unity.Services.Core
{
	// Token: 0x0200000D RID: 13
	public class ServiceObserver<T> : IDisposable
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000029 RID: 41 RVA: 0x00002260 File Offset: 0x00000460
		// (remove) Token: 0x0600002A RID: 42 RVA: 0x00002298 File Offset: 0x00000498
		public event Action<T> Initialized;

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000022CD File Offset: 0x000004CD
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000022D5 File Offset: 0x000004D5
		public T Service { get; private set; }

		// Token: 0x0600002D RID: 45 RVA: 0x000022DE File Offset: 0x000004DE
		public ServiceObserver() : this(UnityServices.Instance)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022EC File Offset: 0x000004EC
		public ServiceObserver(IUnityServices registry)
		{
			if (registry == null)
			{
				throw new ArgumentNullException("registry");
			}
			this.m_Registry = registry;
			if (this.m_Registry.State == ServicesInitializationState.Initialized)
			{
				this.AssignService();
				return;
			}
			this.m_Registry.Initialized -= this.AssignService;
			this.m_Registry.Initialized += this.AssignService;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002358 File Offset: 0x00000558
		private void AssignService()
		{
			this.Service = this.m_Registry.GetService<T>();
			if (this.Service != null)
			{
				Action<T> initialized = this.Initialized;
				if (initialized == null)
				{
					return;
				}
				initialized(this.Service);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000238E File Offset: 0x0000058E
		public void Dispose()
		{
			if (this.m_Registry == null)
			{
				return;
			}
			this.m_Registry.Initialized -= this.AssignService;
			this.m_Registry = null;
		}

		// Token: 0x0400001B RID: 27
		private IUnityServices m_Registry;
	}
}
