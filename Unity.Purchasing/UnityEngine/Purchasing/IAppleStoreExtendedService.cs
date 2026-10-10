using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008A RID: 138
	public interface IAppleStoreExtendedService : IStoreServiceExtension
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000264 RID: 612
		bool canMakePayments { get; }

		// Token: 0x06000265 RID: 613
		void SetAppAccountToken(Guid appAccountToken);

		// Token: 0x06000266 RID: 614
		void ClearTransactionLog();
	}
}
