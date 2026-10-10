using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000036 RID: 54
	public struct FloatOptions : IPlugOptions
	{
		// Token: 0x06000211 RID: 529 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
		public void Reset()
		{
			this.snapping = false;
		}

		// Token: 0x040000E7 RID: 231
		public bool snapping;
	}
}
