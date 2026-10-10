using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000084 RID: 132
	public interface IGooglePlayStoreExtendedService : IStoreServiceExtension
	{
		// Token: 0x06000253 RID: 595
		void SetObfuscatedAccountId(string accountId);

		// Token: 0x06000254 RID: 596
		void SetObfuscatedProfileId(string profileId);

		// Token: 0x06000255 RID: 597
		void EndConnection();
	}
}
