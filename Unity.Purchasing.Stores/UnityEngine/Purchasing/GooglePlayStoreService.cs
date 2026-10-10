using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000014 RID: 20
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreService : IGooglePlayStoreService
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002A78 File Offset: 0x00000C78
		internal GooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics)
		{
			this.m_QueryProductDetailsService = queryProductDetailsService;
			this.m_GoogleLastKnownProductService = lastKnownProductService;
			this.m_GooglePurchaseService = purchaseService;
			this.m_GoogleFinishTransactionUseCase = finishTransactionUseCase;
			this.m_TelemetryDiagnostics = telemetryDiagnostics;
			this.m_GoogleQueryPurchasesUseCase = queryPurchasesUseCase;
			this.m_GoogleCheckEntitlementUseCase = googleCheckEntitlementUseCase;
			this.m_BillingClient = billingClient;
			this.m_GooglePlayStoreConnectionService = connectionService;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed)
		{
			GooglePlayStoreService.<FetchProducts>d__10 <FetchProducts>d__;
			<FetchProducts>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FetchProducts>d__.<>4__this = this;
			<FetchProducts>d__.products = products;
			<FetchProducts>d__.onProductsReceived = onProductsReceived;
			<FetchProducts>d__.onFetchProductsFailed = onFetchProductsFailed;
			<FetchProducts>d__.<>1__state = -1;
			<FetchProducts>d__.<>t__builder.Start<GooglePlayStoreService.<FetchProducts>d__10>(ref <FetchProducts>d__);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B20 File Offset: 0x00000D20
		public void Purchase(ProductDefinition product)
		{
			this.Purchase(product, null, null);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B40 File Offset: 0x00000D40
		public virtual void Purchase(ProductDefinition product, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			IGoogleLastKnownProductService googleLastKnownProductService = this.m_GoogleLastKnownProductService;
			string lastKnownOldProductId;
			if (currentOrder == null)
			{
				lastKnownOldProductId = null;
			}
			else
			{
				CartItem cartItem = currentOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
				lastKnownOldProductId = ((cartItem != null) ? cartItem.Product.definition.storeSpecificId : null);
			}
			googleLastKnownProductService.LastKnownOldProductId = lastKnownOldProductId;
			this.m_GoogleLastKnownProductService.LastKnownProductId = product.storeSpecificId;
			this.m_GoogleLastKnownProductService.LastKnownReplacementMode = desiredReplacementMode;
			this.m_GooglePurchaseService.Purchase(product, currentOrder, desiredReplacementMode);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public Task FinishTransaction([Nullable(2)] ProductDefinition product, [Nullable(2)] string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
			GooglePlayStoreService.<FinishTransaction>d__13 <FinishTransaction>d__;
			<FinishTransaction>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishTransaction>d__.<>4__this = this;
			<FinishTransaction>d__.product = product;
			<FinishTransaction>d__.purchaseToken = purchaseToken;
			<FinishTransaction>d__.onTransactionFinished = onTransactionFinished;
			<FinishTransaction>d__.<>1__state = -1;
			<FinishTransaction>d__.<>t__builder.Start<GooglePlayStoreService.<FinishTransaction>d__13>(ref <FinishTransaction>d__);
			return <FinishTransaction>d__.<>t__builder.Task;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002C0C File Offset: 0x00000E0C
		public void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, [Nullable(new byte[]
		{
			1,
			2
		})] Action<string> onQueryPurchaseFailed)
		{
			GooglePlayStoreService.<FetchPurchases>d__14 <FetchPurchases>d__;
			<FetchPurchases>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FetchPurchases>d__.<>4__this = this;
			<FetchPurchases>d__.onQueryPurchaseSucceed = onQueryPurchaseSucceed;
			<FetchPurchases>d__.onQueryPurchaseFailed = onQueryPurchaseFailed;
			<FetchPurchases>d__.<>1__state = -1;
			<FetchPurchases>d__.<>t__builder.Start<GooglePlayStoreService.<FetchPurchases>d__14>(ref <FetchPurchases>d__);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002C54 File Offset: 0x00000E54
		private Task TryFetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed)
		{
			GooglePlayStoreService.<TryFetchPurchases>d__15 <TryFetchPurchases>d__;
			<TryFetchPurchases>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<TryFetchPurchases>d__.<>4__this = this;
			<TryFetchPurchases>d__.onQueryPurchaseSucceed = onQueryPurchaseSucceed;
			<TryFetchPurchases>d__.<>1__state = -1;
			<TryFetchPurchases>d__.<>t__builder.Start<GooglePlayStoreService.<TryFetchPurchases>d__15>(ref <TryFetchPurchases>d__);
			return <TryFetchPurchases>d__.<>t__builder.Task;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002C9F File Offset: 0x00000E9F
		public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked)
		{
			this.m_GoogleCheckEntitlementUseCase.CheckEntitlement(product, onEntitlementChecked);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002CAE File Offset: 0x00000EAE
		public void SetObfuscatedAccountId(string obfuscatedAccountId)
		{
			this.m_BillingClient.SetObfuscationAccountId(obfuscatedAccountId);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002CBC File Offset: 0x00000EBC
		public void SetObfuscatedProfileId(string obfuscatedProfileId)
		{
			this.m_BillingClient.SetObfuscationProfileId(obfuscatedProfileId);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002CCA File Offset: 0x00000ECA
		public virtual bool IsConnectionReady()
		{
			return this.m_GooglePlayStoreConnectionService.IsReady();
		}

		// Token: 0x0400001A RID: 26
		private readonly IQueryProductDetailsService m_QueryProductDetailsService;

		// Token: 0x0400001B RID: 27
		private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService;

		// Token: 0x0400001C RID: 28
		private readonly IGooglePurchaseService m_GooglePurchaseService;

		// Token: 0x0400001D RID: 29
		private readonly IGoogleFinishTransactionUseCase m_GoogleFinishTransactionUseCase;

		// Token: 0x0400001E RID: 30
		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		// Token: 0x0400001F RID: 31
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		// Token: 0x04000020 RID: 32
		private readonly IGooglePlayCheckEntitlementUseCase m_GoogleCheckEntitlementUseCase;

		// Token: 0x04000021 RID: 33
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x04000022 RID: 34
		private readonly IGooglePlayStoreConnectionService m_GooglePlayStoreConnectionService;
	}
}
