using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000030 RID: 48
	[StandardEventName("store_opened", "Monetization", "Send this event when the player opens a store in game.")]
	public struct StoreOpened
	{
		// Token: 0x040000E9 RID: 233
		[RequiredParameter("type", "Set to StoreType.Premium if purchases use real-world money; otherwise, StoreType.Soft.", null)]
		public StoreType storeType;
	}
}
