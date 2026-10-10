using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000214 RID: 532
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[RequiredByNativeCode]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x000258BC File Offset: 0x00023ABC
		public RuntimeInitializeOnLoadMethodAttribute()
		{
			this.loadType = RuntimeInitializeLoadType.AfterSceneLoad;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000258CE File Offset: 0x00023ACE
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			this.loadType = loadType;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000258E0 File Offset: 0x00023AE0
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x000258F8 File Offset: 0x00023AF8
		public RuntimeInitializeLoadType loadType
		{
			get
			{
				return this.m_LoadType;
			}
			private set
			{
				this.m_LoadType = value;
			}
		}

		// Token: 0x04000805 RID: 2053
		private RuntimeInitializeLoadType m_LoadType;
	}
}
