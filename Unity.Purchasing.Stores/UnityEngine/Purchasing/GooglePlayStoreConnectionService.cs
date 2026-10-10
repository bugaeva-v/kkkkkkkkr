using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000028 RID: 40
	internal class GooglePlayStoreConnectionService : IGooglePlayStoreConnectionService
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000045EE File Offset: 0x000027EE
		[Preserve]
		public GooglePlayStoreConnectionService(IGoogleBillingClient billingClient, IBillingClientStateListener billingClientStateListener)
		{
			this.m_BillingClient = billingClient;
			this.m_BillingClientStateListener = billingClientStateListener;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004604 File Offset: 0x00002804
		public void Connect()
		{
			this.m_BillingClientStateListener.RegisterOnConnected(new Action(this.OnConnected));
			this.m_BillingClientStateListener.RegisterOnDisconnected(new Action<GoogleBillingResponseCode>(this.OnDisconnected));
			this.m_BillingClient.StartConnection(this.m_BillingClientStateListener);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004650 File Offset: 0x00002850
		public bool IsReady()
		{
			return this.m_BillingClient.IsReady();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000465D File Offset: 0x0000285D
		public GoogleBillingConnectionState CheckConnectionState()
		{
			return this.m_BillingClient.GetConnectionState();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000466A File Offset: 0x0000286A
		public void SetConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
			this.m_ConnectCallback = storeConnectCallback;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004673 File Offset: 0x00002873
		private void OnConnected()
		{
			this.m_ConnectCallback.OnStoreConnectionSucceeded();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004680 File Offset: 0x00002880
		private void OnDisconnected(GoogleBillingResponseCode responseCode)
		{
			this.m_ConnectCallback.OnStoreConnectionFailed(new StoreConnectionFailureDescription("GooglePlayStore connection failed", true));
		}

		// Token: 0x0400005C RID: 92
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x0400005D RID: 93
		private readonly IBillingClientStateListener m_BillingClientStateListener;

		// Token: 0x0400005E RID: 94
		private IStoreConnectCallback m_ConnectCallback;
	}
}
