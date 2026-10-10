using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200002F RID: 47
	[StandardEventName("store_item_click", "Monetization", "Send this event when the player clicks on an item in the store.")]
	public struct StoreItemClick
	{
		// Token: 0x040000E6 RID: 230
		[RequiredParameter("type", "Set to StoreType.Premium if purchases use real-world money; otherwise, StoreType.Soft.", null)]
		public StoreType storeType;

		// Token: 0x040000E7 RID: 231
		[RequiredParameter("item_id", "A unique identifier for the item.", null)]
		public string itemId;

		// Token: 0x040000E8 RID: 232
		[OptionalParameter("item_name", "The item's name.")]
		public string itemName;
	}
}
