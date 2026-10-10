using System;

namespace App42Json
{
	// Token: 0x0200006F RID: 111
	public enum JsonToken
	{
		// Token: 0x040001CC RID: 460
		None,
		// Token: 0x040001CD RID: 461
		ObjectStart,
		// Token: 0x040001CE RID: 462
		PropertyName,
		// Token: 0x040001CF RID: 463
		ObjectEnd,
		// Token: 0x040001D0 RID: 464
		ArrayStart,
		// Token: 0x040001D1 RID: 465
		ArrayEnd,
		// Token: 0x040001D2 RID: 466
		Int,
		// Token: 0x040001D3 RID: 467
		Long,
		// Token: 0x040001D4 RID: 468
		Double,
		// Token: 0x040001D5 RID: 469
		String,
		// Token: 0x040001D6 RID: 470
		Boolean,
		// Token: 0x040001D7 RID: 471
		Null
	}
}
