using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Uniject;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000037 RID: 55
	[NullableContext(1)]
	[Nullable(0)]
	internal class MetricizedAppleStoreImpl : AppleStoreImpl
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00005C0E File Offset: 0x00003E0E
		[Preserve]
		internal MetricizedAppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) : base(cartValidator, fetchProductsService, transactionLog, util, logger, telemetryDiagnostics)
		{
			this.m_TelemetryMetricsService = telemetryMetricsService;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005C28 File Offset: 0x00003E28
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__0(products);
			}, TelemetryMetricDefinitions.fetchProductsName);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005C68 File Offset: 0x00003E68
		public override void Purchase(ICart cart)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__1(cart);
			}, TelemetryMetricDefinitions.initPurchaseName);
		}

		// Token: 0x04000085 RID: 133
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;
	}
}
