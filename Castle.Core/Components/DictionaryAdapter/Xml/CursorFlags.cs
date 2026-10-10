using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200016A RID: 362
	[Flags]
	public enum CursorFlags
	{
		// Token: 0x04000259 RID: 601
		None = 0,
		// Token: 0x0400025A RID: 602
		Elements = 1,
		// Token: 0x0400025B RID: 603
		Attributes = 2,
		// Token: 0x0400025C RID: 604
		Multiple = 4,
		// Token: 0x0400025D RID: 605
		Mutable = 8,
		// Token: 0x0400025E RID: 606
		AllNodes = 3
	}
}
