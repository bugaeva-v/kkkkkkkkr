using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000032 RID: 50
	public struct UintOptions : IPlugOptions
	{
		// Token: 0x0600020D RID: 525 RVA: 0x0000C28C File Offset: 0x0000A48C
		public void Reset()
		{
			this.isNegativeChangeValue = false;
		}

		// Token: 0x040000E2 RID: 226
		public bool isNegativeChangeValue;
	}
}
