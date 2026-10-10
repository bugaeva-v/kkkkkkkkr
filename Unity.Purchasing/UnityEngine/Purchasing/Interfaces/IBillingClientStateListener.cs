using System;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000123 RID: 291
	internal interface IBillingClientStateListener
	{
		// Token: 0x06000518 RID: 1304
		void RegisterOnConnected(Action onConnected);

		// Token: 0x06000519 RID: 1305
		void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected);
	}
}
