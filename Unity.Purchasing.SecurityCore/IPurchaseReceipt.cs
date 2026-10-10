using System;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000008 RID: 8
	public interface IPurchaseReceipt
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56
		string transactionID { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000039 RID: 57
		string productID { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58
		DateTime purchaseDate { get; }
	}
}
