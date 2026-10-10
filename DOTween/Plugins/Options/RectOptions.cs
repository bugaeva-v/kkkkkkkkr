using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000037 RID: 55
	public struct RectOptions : IPlugOptions
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0000C2BE File Offset: 0x0000A4BE
		public void Reset()
		{
			this.snapping = false;
		}

		// Token: 0x040000E8 RID: 232
		public bool snapping;
	}
}
