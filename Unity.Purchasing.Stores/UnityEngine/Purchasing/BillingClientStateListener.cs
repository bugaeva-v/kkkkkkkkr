using System;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000019 RID: 25
	internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003796 File Offset: 0x00001996
		internal BillingClientStateListener(IUtil util) : base("com.android.billingclient.api.BillingClientStateListener")
		{
			this.m_Util = util;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000037AA File Offset: 0x000019AA
		public void RegisterOnConnected(Action onConnected)
		{
			this.m_OnConnected = onConnected;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000037B3 File Offset: 0x000019B3
		public void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected)
		{
			this.m_Disconnect = onDisconnected;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000037BC File Offset: 0x000019BC
		[Preserve]
		public void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.HandleBillingSetupFinished(billingResult);
			});
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000037F4 File Offset: 0x000019F4
		private void HandleBillingSetupFinished(AndroidJavaObject billingResult)
		{
			IGoogleBillingResult googleBillingResult = new GoogleBillingResult(billingResult);
			if (googleBillingResult.responseCode == GoogleBillingResponseCode.Ok)
			{
				this.m_OnConnected();
			}
			else
			{
				this.m_Disconnect(googleBillingResult.responseCode);
			}
			billingResult.Dispose();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003834 File Offset: 0x00001A34
		[Preserve]
		public void onBillingServiceDisconnected()
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.m_Disconnect(GoogleBillingResponseCode.ServiceDisconnected);
			});
		}

		// Token: 0x0400002F RID: 47
		private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";

		// Token: 0x04000030 RID: 48
		private Action m_OnConnected;

		// Token: 0x04000031 RID: 49
		private Action<GoogleBillingResponseCode> m_Disconnect;

		// Token: 0x04000032 RID: 50
		private readonly IUtil m_Util;
	}
}
