using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000053 RID: 83
	[NullableContext(2)]
	public interface IAppleOrderInfo
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000157 RID: 343
		string AppReceipt { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000158 RID: 344
		// (set) Token: 0x06000159 RID: 345
		string OriginalTransactionID { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600015A RID: 346
		// (set) Token: 0x0600015B RID: 347
		OwnershipType OwnershipType { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600015C RID: 348
		// (set) Token: 0x0600015D RID: 349
		[Nullable(1)]
		string StoreName { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600015E RID: 350
		// (set) Token: 0x0600015F RID: 351
		Guid? AppAccountToken { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000160 RID: 352
		// (set) Token: 0x06000161 RID: 353
		string jwsRepresentation { get; set; }
	}
}
