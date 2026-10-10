using System;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001B RID: 27
	internal class GoogleConsumeResponseListener : AndroidJavaProxy
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000038B0 File Offset: 0x00001AB0
		internal GoogleConsumeResponseListener(Action<IGoogleBillingResult> onConsumeResponseAction, IUtil util) : base("com.android.billingclient.api.ConsumeResponseListener")
		{
			this.m_OnConsumeResponse = onConsumeResponseAction;
			this.m_Util = util;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000038CC File Offset: 0x00001ACC
		[Preserve]
		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.m_OnConsumeResponse(new GoogleBillingResult(billingResult));
				billingResult.Dispose();
			});
		}

		// Token: 0x04000036 RID: 54
		private const string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";

		// Token: 0x04000037 RID: 55
		private readonly Action<IGoogleBillingResult> m_OnConsumeResponse;

		// Token: 0x04000038 RID: 56
		private readonly IUtil m_Util;
	}
}
