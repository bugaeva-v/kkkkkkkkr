using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	internal class MetricizedGooglePlayStoreService : GooglePlayStoreService
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00003B24 File Offset: 0x00001D24
		[Preserve]
		internal MetricizedGooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) : base(billingClient, connectionService, queryProductDetailsService, lastKnownProductService, purchaseService, finishTransactionUseCase, queryPurchasesUseCase, googleCheckEntitlementUseCase, telemetryDiagnostics)
		{
			this.m_TelemetryMetricsService = telemetryMetricsService;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003B50 File Offset: 0x00001D50
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__0(products, onProductsReceived, onFetchProductsFailed);
			}, TelemetryMetricDefinitions.fetchProductsName);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003B9C File Offset: 0x00001D9C
		public override void Purchase(ProductDefinition product, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__1(product, currentOrder, desiredReplacementMode);
			}, TelemetryMetricDefinitions.initPurchaseName);
		}

		// Token: 0x04000044 RID: 68
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;
	}
}
