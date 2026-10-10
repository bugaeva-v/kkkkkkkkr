using System;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001A RID: 26
	internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000385B File Offset: 0x00001A5B
		internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction, IUtil util) : base("com.android.billingclient.api.AcknowledgePurchaseResponseListener")
		{
			this.m_OnAcknowledgePurchaseResponse = onAcknowledgePurchaseResponseAction;
			this.m_Util = util;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003878 File Offset: 0x00001A78
		[Preserve]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.m_OnAcknowledgePurchaseResponse(new GoogleBillingResult(billingResult));
				billingResult.Dispose();
			});
		}

		// Token: 0x04000033 RID: 51
		private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		// Token: 0x04000034 RID: 52
		private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

		// Token: 0x04000035 RID: 53
		private readonly IUtil m_Util;
	}
}
