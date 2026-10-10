using System;
using System.Collections.Generic;
using System.Linq;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001D RID: 29
	internal class GooglePurchasesUpdatedListener : AndroidJavaProxy, IGooglePurchasesUpdatedListener
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600007F RID: 127 RVA: 0x00003960 File Offset: 0x00001B60
		// (remove) Token: 0x06000080 RID: 128 RVA: 0x00003998 File Offset: 0x00001B98
		public event Action<IGoogleBillingResult, List<IGooglePurchase>> OnPurchaseUpdated;

		// Token: 0x06000081 RID: 129 RVA: 0x000039CD File Offset: 0x00001BCD
		internal GooglePurchasesUpdatedListener(IGooglePurchaseBuilder purchaseBuilder, IUtil util) : base("com.android.billingclient.api.PurchasesUpdatedListener")
		{
			this.m_PurchaseBuilder = purchaseBuilder;
			this.m_Util = util;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000039E8 File Offset: 0x00001BE8
		[Preserve]
		public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.HandlePurchasesUpdated(billingResult, javaPurchasesList);
			});
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003A28 File Offset: 0x00001C28
		private void HandlePurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
			List<AndroidJavaObject> list = javaPurchasesList.Enumerate().ToList<AndroidJavaObject>();
			IGoogleBillingResult arg = new GoogleBillingResult(billingResult);
			List<IGooglePurchase> arg2 = this.m_PurchaseBuilder.BuildPurchases(list).ToList<IGooglePurchase>();
			Action<IGoogleBillingResult, List<IGooglePurchase>> onPurchaseUpdated = this.OnPurchaseUpdated;
			if (onPurchaseUpdated != null)
			{
				onPurchaseUpdated(arg, arg2);
			}
			foreach (AndroidJavaObject androidJavaObject in list)
			{
				if (androidJavaObject != null)
				{
					androidJavaObject.Dispose();
				}
			}
			billingResult.Dispose();
			if (javaPurchasesList != null)
			{
				javaPurchasesList.Dispose();
			}
		}

		// Token: 0x0400003C RID: 60
		private const string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";

		// Token: 0x0400003E RID: 62
		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		// Token: 0x0400003F RID: 63
		private readonly IUtil m_Util;
	}
}
