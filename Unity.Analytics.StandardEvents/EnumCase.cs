using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000009 RID: 9
	public class EnumCase : AnalyticsEventAttribute
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00003C84 File Offset: 0x00001E84
		public EnumCase(EnumCase.Styles style)
		{
			this.Style = style;
		}

		// Token: 0x0400000E RID: 14
		public EnumCase.Styles Style;

		// Token: 0x0200000A RID: 10
		public enum Styles
		{
			// Token: 0x04000010 RID: 16
			None,
			// Token: 0x04000011 RID: 17
			Snake,
			// Token: 0x04000012 RID: 18
			Lower
		}
	}
}
