using System;
using System.Collections.Generic;
using System.Linq;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001C RID: 28
	internal class GooglePurchasesResponseListener : AndroidJavaProxy
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003904 File Offset: 0x00001B04
		internal GooglePurchasesResponseListener(Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse, IUtil util) : base("com.android.billingclient.api.PurchasesResponseListener")
		{
			this.m_OnQueryPurchasesResponse = onQueryPurchasesResponse;
			this.m_Util = util;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003920 File Offset: 0x00001B20
		[Preserve]
		public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				List<AndroidJavaObject> list = purchases.Enumerate().ToList<AndroidJavaObject>();
				this.m_OnQueryPurchasesResponse(new GoogleBillingResult(billingResult), list);
				foreach (AndroidJavaObject androidJavaObject in list)
				{
					if (androidJavaObject != null)
					{
						androidJavaObject.Dispose();
					}
				}
				billingResult.Dispose();
				AndroidJavaObject purchases2 = purchases;
				if (purchases2 == null)
				{
					return;
				}
				purchases2.Dispose();
			});
		}

		// Token: 0x04000039 RID: 57
		private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";

		// Token: 0x0400003A RID: 58
		private readonly Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> m_OnQueryPurchasesResponse;

		// Token: 0x0400003B RID: 59
		private readonly IUtil m_Util;
	}
}
