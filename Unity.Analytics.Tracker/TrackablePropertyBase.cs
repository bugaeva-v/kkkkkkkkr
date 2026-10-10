using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public abstract class TrackablePropertyBase
	{
		// Token: 0x04000014 RID: 20
		[SerializeField]
		protected Object m_Target;

		// Token: 0x04000015 RID: 21
		[SerializeField]
		protected string m_Path;
	}
}
