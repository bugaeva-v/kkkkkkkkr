using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001E RID: 30
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductDetailsResponseListener : AndroidJavaProxy
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00003AC0 File Offset: 0x00001CC0
		internal ProductDetailsResponseListener(Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) : base("com.android.billingclient.api.ProductDetailsResponseListener")
		{
			this.m_OnProductDetailsResponse = onProductDetailsResponseAction;
			this.m_Util = util;
			this.m_TelemetryDiagnostics = telemetryDiagnostics;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003AE4 File Offset: 0x00001CE4
		[Preserve]
		public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject queryProductDetailsResult)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				try
				{
					using (AndroidJavaObject androidJavaObject = queryProductDetailsResult.Call<AndroidJavaObject>("getProductDetailsList", Array.Empty<object>()))
					{
						List<AndroidJavaObject> arg = androidJavaObject.Enumerate<AndroidJavaObject>().ToList<AndroidJavaObject>();
						this.m_OnProductDetailsResponse(new GoogleBillingResult(billingResult), arg);
					}
				}
				catch (Exception e)
				{
					this.m_TelemetryDiagnostics.SendDiagnostic("sku_details_response_error", e);
				}
				billingResult.Dispose();
				queryProductDetailsResult.Dispose();
			});
		}

		// Token: 0x04000040 RID: 64
		private const string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";

		// Token: 0x04000041 RID: 65
		private readonly Action<IGoogleBillingResult, List<AndroidJavaObject>> m_OnProductDetailsResponse;

		// Token: 0x04000042 RID: 66
		private readonly IUtil m_Util;

		// Token: 0x04000043 RID: 67
		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;
	}
}
