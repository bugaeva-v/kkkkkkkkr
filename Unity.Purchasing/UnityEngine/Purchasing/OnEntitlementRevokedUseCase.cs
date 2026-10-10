using System;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000073 RID: 115
	internal class OnEntitlementRevokedUseCase : IOnEntitlementRevokedUseCase, IOnEntitlementRevokedCallback
	{
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600021D RID: 541 RVA: 0x0000615C File Offset: 0x0000435C
		// (remove) Token: 0x0600021E RID: 542 RVA: 0x00006194 File Offset: 0x00004394
		public event Action<string> OnEntitlementRevoked;

		// Token: 0x0600021F RID: 543 RVA: 0x000061C9 File Offset: 0x000043C9
		[Preserve]
		internal OnEntitlementRevokedUseCase(IStore storeResponsible)
		{
			storeResponsible.SetOnRevokedEntitlementCallback(this);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000061D8 File Offset: 0x000043D8
		public void onEntitlementRevoked(string productId)
		{
			Action<string> onEntitlementRevoked = this.OnEntitlementRevoked;
			if (onEntitlementRevoked == null)
			{
				return;
			}
			onEntitlementRevoked(productId);
		}
	}
}
