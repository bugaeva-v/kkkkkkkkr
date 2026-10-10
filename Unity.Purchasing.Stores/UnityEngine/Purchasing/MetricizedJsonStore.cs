using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003B RID: 59
	internal class MetricizedJsonStore : JsonStore
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00006250 File Offset: 0x00004450
		internal MetricizedJsonStore(ICartValidator cartValidator, ILogger logger, string storeName, ITelemetryMetricsService telemetryMetricsService) : base(cartValidator, logger, storeName)
		{
			this.m_TelemetryMetricsService = telemetryMetricsService;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00006264 File Offset: 0x00004464
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__0(products);
			}, TelemetryMetricDefinitions.fetchProductsName);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000062A4 File Offset: 0x000044A4
		public override void Purchase(ICart cart)
		{
			this.m_TelemetryMetricsService.ExecuteTimedAction(delegate
			{
				this.<>n__1(cart);
			}, TelemetryMetricDefinitions.initPurchaseName);
		}

		// Token: 0x0400008F RID: 143
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;
	}
}
