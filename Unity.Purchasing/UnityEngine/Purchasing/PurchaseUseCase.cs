using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000074 RID: 116
	internal class PurchaseUseCase : IPurchaseUseCase, IStorePurchaseCallback
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000061EB File Offset: 0x000043EB
		protected IStore m_Store { get; }

		// Token: 0x06000222 RID: 546 RVA: 0x000061F3 File Offset: 0x000043F3
		internal PurchaseUseCase(IStore storeResponsible)
		{
			this.m_Store = storeResponsible;
			this.m_Store.SetPurchaseCallback(this);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000620E File Offset: 0x0000440E
		public void Purchase(ICart cart)
		{
			this.m_Store.Purchase(cart);
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000224 RID: 548 RVA: 0x0000621C File Offset: 0x0000441C
		// (remove) Token: 0x06000225 RID: 549 RVA: 0x00006254 File Offset: 0x00004454
		public event Action<PendingOrder> OnPurchaseSuccess;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000226 RID: 550 RVA: 0x0000628C File Offset: 0x0000448C
		// (remove) Token: 0x06000227 RID: 551 RVA: 0x000062C4 File Offset: 0x000044C4
		public event Action<FailedOrder> OnPurchaseFail;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000228 RID: 552 RVA: 0x000062FC File Offset: 0x000044FC
		// (remove) Token: 0x06000229 RID: 553 RVA: 0x00006334 File Offset: 0x00004534
		public event Action<DeferredOrder> OnPurchaseDefer;

		// Token: 0x0600022A RID: 554 RVA: 0x00006369 File Offset: 0x00004569
		public void OnPurchaseSucceeded(PendingOrder order)
		{
			Action<PendingOrder> onPurchaseSuccess = this.OnPurchaseSuccess;
			if (onPurchaseSuccess == null)
			{
				return;
			}
			onPurchaseSuccess(order);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000637C File Offset: 0x0000457C
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
			Action<FailedOrder> onPurchaseFail = this.OnPurchaseFail;
			if (onPurchaseFail == null)
			{
				return;
			}
			onPurchaseFail(failedOrder);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000638F File Offset: 0x0000458F
		public void OnPurchaseDeferred(DeferredOrder deferredOrder)
		{
			Action<DeferredOrder> onPurchaseDefer = this.OnPurchaseDefer;
			if (onPurchaseDefer == null)
			{
				return;
			}
			onPurchaseDefer(deferredOrder);
		}
	}
}
