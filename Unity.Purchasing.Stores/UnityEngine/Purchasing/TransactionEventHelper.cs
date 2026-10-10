using System;
using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000D RID: 13
	internal class TransactionEventHelper
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002553 File Offset: 0x00000753
		internal TransactionEventHelper(IAnalyticsServiceWrapper analytics, ILogger logger)
		{
			this.m_Analytics = analytics;
			this.m_Logger = logger;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002569 File Offset: 0x00000769
		internal long CheckCurrencyCodeAndExtractRealCurrencyAmount(Product product)
		{
			if (product.metadata.isoCurrencyCode != null)
			{
				return this.ExtractRealCurrencyAmount(product);
			}
			this.m_Logger.LogIAPWarning("The isoCurrencyCode for product ID " + product.definition.id + " is null. Were you trying to purchase an unavailable product? The price will be recorded as 0.");
			return 0L;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025A8 File Offset: 0x000007A8
		private long ExtractRealCurrencyAmount(Product product)
		{
			long result;
			try
			{
				IAnalyticsService analyticsService = this.m_Analytics.AnalyticsServiceInstance();
				result = ((analyticsService != null) ? analyticsService.ConvertCurrencyToMinorUnits(product.metadata.isoCurrencyCode, (double)product.metadata.localizedPrice) : 0L);
			}
			catch (Exception)
			{
				this.m_Logger.LogIAPWarning("Could not convert real currency amount payable for product ID " + product.definition.id + ". The price will be recorded as 0.");
				result = 0L;
			}
			return result;
		}

		// Token: 0x04000011 RID: 17
		private readonly IAnalyticsServiceWrapper m_Analytics;

		// Token: 0x04000012 RID: 18
		private readonly ILogger m_Logger;
	}
}
