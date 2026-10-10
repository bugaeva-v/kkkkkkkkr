using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	// Token: 0x02000152 RID: 338
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleStoreExtendedPurchaseService : PurchaseService, IAppleStoreExtendedPurchaseService, IPurchaseServiceExtension
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x0000C31C File Offset: 0x0000A51C
		[Preserve]
		internal AppleStoreExtendedPurchaseService(IAppReceiptUseCase appReceiptUseCase, IContinuePromotionalPurchasesUseCase continuePromotionalPurchasesUseCase, IPresentCodeRedemptionSheetUseCase presentCodeRedemptionSheetUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, ISetPromotionalPurchaseInterceptorCallbackUseCase setPromotionalPurchaseInterceptorCallbackUseCase, ISimulateAskToBuyUseCase simulateAskToBuyUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IOnEntitlementRevokedUseCase onEntitlementRevokedUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient, IRefreshAppReceiptUseCase refreshAppReceiptUseCase) : base(fetchPurchasesUseCase, purchaseUseCase, confirmOrderUseCase, checkEntitlementUseCase, storeWrapper, analyticsClient)
		{
			this.m_AppReceiptUseCase = appReceiptUseCase;
			this.m_ContinuePromotionalPurchasesUseCase = continuePromotionalPurchasesUseCase;
			this.m_PresentCodeRedemptionSheetUseCase = presentCodeRedemptionSheetUseCase;
			this.m_RestoreTransactionsUseCase = restoreTransactionsUseCase;
			this.m_SetPromotionalPurchaseInterceptorCallbackUseCase = setPromotionalPurchaseInterceptorCallbackUseCase;
			this.m_SimulateAskToBuyUseCase = simulateAskToBuyUseCase;
			this.m_OnEntitlementRevokedUseCase = onEntitlementRevokedUseCase;
			this.m_OnEntitlementRevokedUseCase.OnEntitlementRevoked += this.OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked;
			this.m_RefreshAppReceiptUseCase = refreshAppReceiptUseCase;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000C390 File Offset: 0x0000A590
		private void OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked(string productId)
		{
			List<Order> list = new List<Order>();
			foreach (Order order in base.GetPurchases())
			{
				if (AppleStoreExtendedPurchaseService.DoesOrderContainAnyRevokedProductIds(productId, order))
				{
					list.Add(order);
				}
			}
			foreach (Order item in list)
			{
				this.m_Purchases.Remove(item);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000C434 File Offset: 0x0000A634
		private static bool DoesOrderContainAnyRevokedProductIds(string productId, Order order)
		{
			return order.CartOrdered.Items().Any((CartItem cartItem) => productId.Contains(cartItem.Product.definition.storeSpecificId));
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0000C46A File Offset: 0x0000A66A
		[Nullable(2)]
		public string appReceipt
		{
			[NullableContext(2)]
			get
			{
				return this.m_AppReceiptUseCase.AppReceipt();
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060005C5 RID: 1477 RVA: 0x0000C477 File Offset: 0x0000A677
		// (remove) Token: 0x060005C6 RID: 1478 RVA: 0x0000C485 File Offset: 0x0000A685
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<string> OnEntitlementRevoked
		{
			add
			{
				this.m_OnEntitlementRevokedUseCase.OnEntitlementRevoked += value;
			}
			remove
			{
				this.m_OnEntitlementRevokedUseCase.OnEntitlementRevoked -= value;
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000C493 File Offset: 0x0000A693
		public void PresentCodeRedemptionSheet()
		{
			base.IsStoreConnected();
			this.m_PresentCodeRedemptionSheetUseCase.PresentCodeRedemptionSheet();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000C4A7 File Offset: 0x0000A6A7
		[NullableContext(2)]
		protected override void RestoreTransactionsInternal(Action<bool, string> callback)
		{
			this.m_RestoreTransactionsUseCase.RestoreTransactions(callback);
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060005C9 RID: 1481 RVA: 0x0000C4B5 File Offset: 0x0000A6B5
		// (remove) Token: 0x060005CA RID: 1482 RVA: 0x0000C4C3 File Offset: 0x0000A6C3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Product> OnPromotionalPurchaseIntercepted
		{
			add
			{
				this.m_SetPromotionalPurchaseInterceptorCallbackUseCase.OnPromotionalPurchaseIntercepted += value;
			}
			remove
			{
				this.m_SetPromotionalPurchaseInterceptorCallbackUseCase.OnPromotionalPurchaseIntercepted -= value;
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000C4D1 File Offset: 0x0000A6D1
		public void ContinuePromotionalPurchases()
		{
			this.m_ContinuePromotionalPurchasesUseCase.ContinuePromotionalPurchases();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0000C4DE File Offset: 0x0000A6DE
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0000C4EB File Offset: 0x0000A6EB
		public bool simulateAskToBuy
		{
			get
			{
				return this.m_SimulateAskToBuyUseCase.SimulateAskToBuy();
			}
			set
			{
				this.m_SimulateAskToBuyUseCase.SetSimulateAskToBuy(value);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000C4F9 File Offset: 0x0000A6F9
		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
			this.m_RefreshAppReceiptUseCase.RefreshAppReceipt(successCallback, errorCallback);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000C508 File Offset: 0x0000A708
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
			this.m_RefreshAppReceiptUseCase.SetRefreshAppReceipt(refreshAppReceipt);
		}

		// Token: 0x040002A0 RID: 672
		private readonly IAppReceiptUseCase m_AppReceiptUseCase;

		// Token: 0x040002A1 RID: 673
		private readonly IContinuePromotionalPurchasesUseCase m_ContinuePromotionalPurchasesUseCase;

		// Token: 0x040002A2 RID: 674
		private readonly IPresentCodeRedemptionSheetUseCase m_PresentCodeRedemptionSheetUseCase;

		// Token: 0x040002A3 RID: 675
		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;

		// Token: 0x040002A4 RID: 676
		private readonly ISetPromotionalPurchaseInterceptorCallbackUseCase m_SetPromotionalPurchaseInterceptorCallbackUseCase;

		// Token: 0x040002A5 RID: 677
		private readonly ISimulateAskToBuyUseCase m_SimulateAskToBuyUseCase;

		// Token: 0x040002A6 RID: 678
		private readonly IOnEntitlementRevokedUseCase m_OnEntitlementRevokedUseCase;

		// Token: 0x040002A7 RID: 679
		private readonly IRefreshAppReceiptUseCase m_RefreshAppReceiptUseCase;
	}
}
