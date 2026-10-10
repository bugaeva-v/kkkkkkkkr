using System;
using System.Threading.Tasks;

namespace Firebase.Messaging
{
	// Token: 0x02000003 RID: 3
	public static class FirebaseMessaging
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000225C File Offset: 0x0000045C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002273 File Offset: 0x00000473
		public static bool TokenRegistrationOnInitEnabled
		{
			get
			{
				return FirebaseMessagingInternal.IsTokenRegistrationOnInitEnabled();
			}
			set
			{
				FirebaseMessagingInternal.SetTokenRegistrationOnInitEnabled(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002297 File Offset: 0x00000497
		public static bool DeliveryMetricsExportedToBigQueryEnabled
		{
			get
			{
				return FirebaseMessagingInternal.DeliveryMetricsExportToBigQueryEnabled();
			}
			set
			{
				FirebaseMessagingInternal.SetDeliveryMetricsExportToBigQuery(value);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022A4 File Offset: 0x000004A4
		public static Task<string> GetTokenAsync()
		{
			return FirebaseMessagingInternal.GetTokenAsync();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000022BC File Offset: 0x000004BC
		public static Task DeleteTokenAsync()
		{
			return FirebaseMessagingInternal.DeleteTokenAsync();
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000027 RID: 39 RVA: 0x000022D3 File Offset: 0x000004D3
		// (remove) Token: 0x06000028 RID: 40 RVA: 0x000022DD File Offset: 0x000004DD
		public static event EventHandler<MessageReceivedEventArgs> MessageReceived
		{
			add
			{
				FirebaseMessagingInternal.MessageReceived += value;
			}
			remove
			{
				FirebaseMessagingInternal.MessageReceived -= value;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000029 RID: 41 RVA: 0x000022E7 File Offset: 0x000004E7
		// (remove) Token: 0x0600002A RID: 42 RVA: 0x000022F1 File Offset: 0x000004F1
		public static event EventHandler<TokenReceivedEventArgs> TokenReceived
		{
			add
			{
				FirebaseMessagingInternal.TokenReceived += value;
			}
			remove
			{
				FirebaseMessagingInternal.TokenReceived -= value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000022FC File Offset: 0x000004FC
		public static Task RequestPermissionAsync()
		{
			return FirebaseMessagingInternal.RequestPermissionAsync();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002314 File Offset: 0x00000514
		public static Task SubscribeAsync(string topic)
		{
			return FirebaseMessagingInternal.SubscribeAsync(topic);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000232C File Offset: 0x0000052C
		public static Task UnsubscribeAsync(string topic)
		{
			return FirebaseMessagingInternal.UnsubscribeAsync(topic);
		}
	}
}
