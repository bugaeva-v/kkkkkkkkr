using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000021 RID: 33
	[StandardEventName("item_acquired", "Monetization", "Send this event when the player acquires an item within the game.")]
	public struct ItemAcquired
	{
		// Token: 0x040000BF RID: 191
		[RequiredParameter("currency_type", "Set to AcquisitionType.Premium if the item was purchased with real money; otherwise, AcqusitionType.Soft.", null)]
		public AcquisitionType currencyType;

		// Token: 0x040000C0 RID: 192
		[RequiredParameter("transaction_context", "In what context(store, gift, reward, crafting) was the item acquired?", null)]
		public string transactionContext;

		// Token: 0x040000C1 RID: 193
		[RequiredParameter("amount", "The unit quantity of the item that was acquired", null)]
		public float amount;

		// Token: 0x040000C2 RID: 194
		[RequiredParameter("item_id", "A name or unique identifier for the acquired item.", null)]
		public string itemId;

		// Token: 0x040000C3 RID: 195
		[OptionalParameter("balance", "The balance of the acquired item.")]
		public float balance;

		// Token: 0x040000C4 RID: 196
		[OptionalParameter("item_type", "The category of the item that was acquired.")]
		public string itemType;

		// Token: 0x040000C5 RID: 197
		[OptionalParameter("level", "The name or id of the level where the item was acquired.")]
		public string level;

		// Token: 0x040000C6 RID: 198
		[OptionalParameter("transaction_id", "A unique identifier for the specific transaction that occurred. You can use this to group multiple events into a single transaction.")]
		public string transactionId;
	}
}
