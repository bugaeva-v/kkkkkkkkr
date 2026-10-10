using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000022 RID: 34
	[StandardEventName("item_spent", "Monetization", "Send this event when the player spends an item.")]
	public struct ItemSpent
	{
		// Token: 0x040000C7 RID: 199
		[RequiredParameter("currency_type", "Set to AcquisitionType.Premium if the item was purchased with real money; otherwise, AcqusitionType.Soft.", null)]
		public AcquisitionType currencyType;

		// Token: 0x040000C8 RID: 200
		[RequiredParameter("transaction_context", "In what context(store, gift, reward, crafting) was the item spent?", null)]
		public string transactionContext;

		// Token: 0x040000C9 RID: 201
		[RequiredParameter("amount", "The unit quantity of the item that was spent", null)]
		public float amount;

		// Token: 0x040000CA RID: 202
		[RequiredParameter("item_id", "A name or unique identifier for the spent item.", null)]
		public string itemId;

		// Token: 0x040000CB RID: 203
		[OptionalParameter("balance", "The balance of the spent item.")]
		public float balance;

		// Token: 0x040000CC RID: 204
		[OptionalParameter("item_type", "The category of the item that was spent.")]
		public string itemType;

		// Token: 0x040000CD RID: 205
		[OptionalParameter("level", "The name or id of the level where the item was spent.")]
		public string level;

		// Token: 0x040000CE RID: 206
		[OptionalParameter("transaction_id", "A unique identifier for the specific transaction that occurred. You can use this to group multiple events into a single transaction.")]
		public string transactionId;
	}
}
