using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000045 RID: 69
	internal interface IOnEntitlementRevokedUseCase
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600011A RID: 282
		// (remove) Token: 0x0600011B RID: 283
		event Action<string> OnEntitlementRevoked;
	}
}
