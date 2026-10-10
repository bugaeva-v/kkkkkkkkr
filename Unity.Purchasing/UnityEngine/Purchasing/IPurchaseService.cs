using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003D RID: 61
	[NullableContext(1)]
	public interface IPurchaseService
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000FA RID: 250
		[Nullable(2)]
		IAppleStoreExtendedPurchaseService Apple { [NullableContext(2)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000FB RID: 251
		[Nullable(2)]
		IGooglePlayStoreExtendedPurchaseService Google { [NullableContext(2)] get; }

		// Token: 0x060000FC RID: 252
		void PurchaseProduct(Product product);

		// Token: 0x060000FD RID: 253
		void Purchase(ICart cart);

		// Token: 0x060000FE RID: 254
		void ConfirmPurchase(PendingOrder order);

		// Token: 0x060000FF RID: 255
		void FetchPurchases();

		// Token: 0x06000100 RID: 256
		void CheckEntitlement(Product product);

		// Token: 0x06000101 RID: 257
		[NullableContext(2)]
		void RestoreTransactions(Action<bool, string> callback);

		// Token: 0x06000102 RID: 258
		ReadOnlyObservableCollection<Order> GetPurchases();

		// Token: 0x06000103 RID: 259
		void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess);

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000104 RID: 260
		// (remove) Token: 0x06000105 RID: 261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<PendingOrder> OnPurchasePending;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000106 RID: 262
		// (remove) Token: 0x06000107 RID: 263
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<Order> OnPurchaseConfirmed;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000108 RID: 264
		// (remove) Token: 0x06000109 RID: 265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<FailedOrder> OnPurchaseFailed;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600010A RID: 266
		// (remove) Token: 0x0600010B RID: 267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<DeferredOrder> OnPurchaseDeferred;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600010C RID: 268
		// (remove) Token: 0x0600010D RID: 269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<Orders> OnPurchasesFetched;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600010E RID: 270
		// (remove) Token: 0x0600010F RID: 271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000110 RID: 272
		// (remove) Token: 0x06000111 RID: 273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<Entitlement> OnCheckEntitlement;
	}
}
