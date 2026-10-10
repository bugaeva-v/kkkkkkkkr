using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000020 RID: 32
	[StandardEventName("iap_transaction", "Monetization", "Send this event when the player spends real-world money to make an In-App Purchase.")]
	public struct IAPTransaction
	{
		// Token: 0x040000B9 RID: 185
		[RequiredParameter("transaction_context", "In what context (store, gift, reward) was the item acquired?", null)]
		public string transactionContext;

		// Token: 0x040000BA RID: 186
		[RequiredParameter("price", "How much did the item cost?", null)]
		public float price;

		// Token: 0x040000BB RID: 187
		[RequiredParameter("item_id", "A name or unique identifier for the acquired item.", null)]
		public string itemId;

		// Token: 0x040000BC RID: 188
		[OptionalParameter("item_type", "The category of the item that was acquired.")]
		public string itemType;

		// Token: 0x040000BD RID: 189
		[OptionalParameter("level", "The name or id of the level where the item was acquired.")]
		public string level;

		// Token: 0x040000BE RID: 190
		[OptionalParameter("transaction_id", "A unique identifier for the specific transaction that occurred. You can use this to group multiple events into a single transaction.")]
		public string transactionId;
	}
}
