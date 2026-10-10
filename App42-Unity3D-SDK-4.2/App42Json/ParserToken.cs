using System;

namespace App42Json
{
	// Token: 0x0200007B RID: 123
	internal enum ParserToken
	{
		// Token: 0x04000214 RID: 532
		None = 65536,
		// Token: 0x04000215 RID: 533
		Number,
		// Token: 0x04000216 RID: 534
		True,
		// Token: 0x04000217 RID: 535
		False,
		// Token: 0x04000218 RID: 536
		Null,
		// Token: 0x04000219 RID: 537
		CharSeq,
		// Token: 0x0400021A RID: 538
		Char,
		// Token: 0x0400021B RID: 539
		Text,
		// Token: 0x0400021C RID: 540
		Object,
		// Token: 0x0400021D RID: 541
		ObjectPrime,
		// Token: 0x0400021E RID: 542
		Pair,
		// Token: 0x0400021F RID: 543
		PairRest,
		// Token: 0x04000220 RID: 544
		Array,
		// Token: 0x04000221 RID: 545
		ArrayPrime,
		// Token: 0x04000222 RID: 546
		Value,
		// Token: 0x04000223 RID: 547
		ValueRest,
		// Token: 0x04000224 RID: 548
		String,
		// Token: 0x04000225 RID: 549
		End,
		// Token: 0x04000226 RID: 550
		Epsilon
	}
}
