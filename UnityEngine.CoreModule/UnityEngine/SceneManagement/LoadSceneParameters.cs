using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020002E9 RID: 745
	[Serializable]
	public struct LoadSceneParameters
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0003183C File Offset: 0x0002FA3C
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x00031854 File Offset: 0x0002FA54
		public LoadSceneMode loadSceneMode
		{
			get
			{
				return this.m_LoadSceneMode;
			}
			set
			{
				this.m_LoadSceneMode = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00031860 File Offset: 0x0002FA60
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00031878 File Offset: 0x0002FA78
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00031882 File Offset: 0x0002FA82
		public LoadSceneParameters(LoadSceneMode mode)
		{
			this.m_LoadSceneMode = mode;
			this.m_LocalPhysicsMode = LocalPhysicsMode.None;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00031893 File Offset: 0x0002FA93
		public LoadSceneParameters(LoadSceneMode mode, LocalPhysicsMode physicsMode)
		{
			this.m_LoadSceneMode = mode;
			this.m_LocalPhysicsMode = physicsMode;
		}

		// Token: 0x040009F3 RID: 2547
		[SerializeField]
		private LoadSceneMode m_LoadSceneMode;

		// Token: 0x040009F4 RID: 2548
		[SerializeField]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
