using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	// Token: 0x02000153 RID: 339
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleStoreExtendedService : StoreService, IAppleStoreExtendedService, IStoreServiceExtension
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x0000C516 File Offset: 0x0000A716
		[Preserve]
		internal AppleStoreExtendedService(ICanMakePaymentsUseCase canMakePaymentsUseCase, IClearAppleTransactionLogsUseCase clearAppleTransactionLogsUseCase, ISetAppAccountTokenUseCase setAppAccountTokenUseCase, IStoreConnectUseCase connectUseCase) : base(connectUseCase)
		{
			this.m_CanMakePaymentsUseCase = canMakePaymentsUseCase;
			this.m_ClearAppleTransactionLogsUseCase = clearAppleTransactionLogsUseCase;
			this.m_SetAppAccountTokenUseCase = setAppAccountTokenUseCase;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0000C535 File Offset: 0x0000A735
		public bool canMakePayments
		{
			get
			{
				return this.m_CanMakePaymentsUseCase.CanMakePayments();
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000C542 File Offset: 0x0000A742
		public void SetAppAccountToken(Guid appAccountToken)
		{
			this.m_SetAppAccountTokenUseCase.SetAppAccountToken(appAccountToken);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000C550 File Offset: 0x0000A750
		public void ClearTransactionLog()
		{
		}

		// Token: 0x040002A8 RID: 680
		private readonly ICanMakePaymentsUseCase m_CanMakePaymentsUseCase;

		// Token: 0x040002A9 RID: 681
		private readonly IClearAppleTransactionLogsUseCase m_ClearAppleTransactionLogsUseCase;

		// Token: 0x040002AA RID: 682
		private readonly ISetAppAccountTokenUseCase m_SetAppAccountTokenUseCase;
	}
}
