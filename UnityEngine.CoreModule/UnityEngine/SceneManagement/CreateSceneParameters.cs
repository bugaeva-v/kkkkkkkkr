using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020002EA RID: 746
	[Serializable]
	public struct CreateSceneParameters
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000318A4 File Offset: 0x0002FAA4
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x000318BC File Offset: 0x0002FABC
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

		// Token: 0x06001E86 RID: 7814 RVA: 0x000318BC File Offset: 0x0002FABC
		public CreateSceneParameters(LocalPhysicsMode physicsMode)
		{
			this.m_LocalPhysicsMode = physicsMode;
		}

		// Token: 0x040009F5 RID: 2549
		[SerializeField]
		private LocalPhysicsMode m_LocalPhysicsMode;
	}
}
