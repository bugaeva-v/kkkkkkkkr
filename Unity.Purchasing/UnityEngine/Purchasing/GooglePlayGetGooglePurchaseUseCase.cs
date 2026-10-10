using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayGetGooglePurchaseUseCase : IGooglePlayGetGooglePurchaseUseCase
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002EC6 File Offset: 0x000010C6
		[Preserve]
		public GooglePlayGetGooglePurchaseUseCase(IStore store)
		{
			this.m_Store = store;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002ED5 File Offset: 0x000010D5
		[return: Nullable(2)]
		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			IGooglePlayStore googlePlayStore = this.GooglePlayStore();
			if (googlePlayStore == null)
			{
				return null;
			}
			return googlePlayStore.GetGooglePurchase(purchaseToken);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002EE9 File Offset: 0x000010E9
		[NullableContext(2)]
		private IGooglePlayStore GooglePlayStore()
		{
			return this.m_Store as IGooglePlayStore;
		}

		// Token: 0x04000026 RID: 38
		private readonly IStore m_Store;
	}
}
