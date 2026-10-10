using System;

namespace SimpleJSON
{
	// Token: 0x0200009F RID: 159
	public enum JSONNodeType
	{
		// Token: 0x04000281 RID: 641
		Array = 1,
		// Token: 0x04000282 RID: 642
		Object,
		// Token: 0x04000283 RID: 643
		String,
		// Token: 0x04000284 RID: 644
		Number,
		// Token: 0x04000285 RID: 645
		NullValue,
		// Token: 0x04000286 RID: 646
		Boolean,
		// Token: 0x04000287 RID: 647
		None,
		// Token: 0x04000288 RID: 648
		Custom = 255
	}
}
