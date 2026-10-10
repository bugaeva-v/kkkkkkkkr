using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000008 RID: 8
	[AttributeUsage(AttributeTargets.Field)]
	public class CustomizableEnum : AnalyticsEventAttribute
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003C75 File Offset: 0x00001E75
		public CustomizableEnum(bool customizable)
		{
			this.Customizable = customizable;
		}

		// Token: 0x0400000D RID: 13
		public bool Customizable;
	}
}
