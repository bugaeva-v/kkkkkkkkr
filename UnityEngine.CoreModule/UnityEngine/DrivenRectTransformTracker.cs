using System;

namespace UnityEngine
{
	// Token: 0x0200025B RID: 603
	public struct DrivenRectTransformTracker
	{
		// Token: 0x06001A08 RID: 6664 RVA: 0x0002A228 File Offset: 0x00028428
		internal static bool CanRecordModifications()
		{
			return true;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00004563 File Offset: 0x00002763
		public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties)
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0002A23B File Offset: 0x0002843B
		[Obsolete("revertValues parameter is ignored. Please use Clear() instead.")]
		public void Clear(bool revertValues)
		{
			this.Clear();
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00004563 File Offset: 0x00002763
		public void Clear()
		{
		}
	}
}
