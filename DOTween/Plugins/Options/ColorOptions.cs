using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000035 RID: 53
	public struct ColorOptions : IPlugOptions
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		public void Reset()
		{
			this.alphaOnly = false;
		}

		// Token: 0x040000E6 RID: 230
		public bool alphaOnly;
	}
}
