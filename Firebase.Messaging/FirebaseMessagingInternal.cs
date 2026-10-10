using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Firebase.Messaging
{
	// Token: 0x0200000F RID: 15
	internal sealed class FirebaseMessagingInternal
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000032C9 File Offset: 0x000014C9
		public static void ExportFix()
		{
			FirebaseMessagingInternalPINVOKE.ExportFix();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000D1 RID: 209 RVA: 0x000032D4 File Offset: 0x000014D4
		// (remove) Token: 0x060000D2 RID: 210 RVA: 0x00003308 File Offset: 0x00001508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal static event EventHandler<MessageReceivedEventArgs> MessageReceivedInternal;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000D3 RID: 211 RVA: 0x0000333C File Offset: 0x0000153C
		// (remove) Token: 0x060000D4 RID: 212 RVA: 0x00003370 File Offset: 0x00001570
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal static event EventHandler<TokenReceivedEventArgs> TokenReceivedInternal;

		// Token: 0x060000D5 RID: 213 RVA: 0x000033A4 File Offset: 0x000015A4
		internal static void CreateOrDestroyListener()
		{
			Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
			lock (typeFromHandle)
			{
				bool flag2 = FirebaseMessagingInternal.MessageReceivedInternal != null;
				bool flag3 = FirebaseMessagingInternal.TokenReceivedInternal != null;
				bool flag4 = flag2 || flag3;
				if (flag4)
				{
					FirebaseMessagingInternal.Listener.Create();
				}
				else
				{
					FirebaseMessagingInternal.Listener.Destroy();
				}
				FirebaseMessagingInternal.SetListenerCallbacksEnabled(flag2, flag3);
				bool flag5 = flag2 || flag3;
				if (flag5)
				{
					FirebaseMessagingInternal.SendPendingEvents();
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003440 File Offset: 0x00001640
		private static FirebaseApp App
		{
			get
			{
				return FirebaseMessagingInternal.Listener.App;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000D8 RID: 216 RVA: 0x00003458 File Offset: 0x00001658
		// (remove) Token: 0x060000D9 RID: 217 RVA: 0x000034A8 File Offset: 0x000016A8
		public static event EventHandler<MessageReceivedEventArgs> MessageReceived
		{
			add
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					FirebaseMessagingInternal.MessageReceivedInternal += value;
					FirebaseMessagingInternal.CreateOrDestroyListener();
				}
			}
			remove
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					FirebaseMessagingInternal.MessageReceivedInternal -= value;
					FirebaseMessagingInternal.CreateOrDestroyListener();
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000DA RID: 218 RVA: 0x000034F8 File Offset: 0x000016F8
		// (remove) Token: 0x060000DB RID: 219 RVA: 0x00003548 File Offset: 0x00001748
		public static event EventHandler<TokenReceivedEventArgs> TokenReceived
		{
			add
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					FirebaseMessagingInternal.TokenReceivedInternal += value;
					FirebaseMessagingInternal.CreateOrDestroyListener();
				}
			}
			remove
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					FirebaseMessagingInternal.TokenReceivedInternal -= value;
					FirebaseMessagingInternal.CreateOrDestroyListener();
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003598 File Offset: 0x00001798
		public static bool IsTokenRegistrationOnInitEnabled()
		{
			bool result = FirebaseMessagingInternalPINVOKE.IsTokenRegistrationOnInitEnabled();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000035C0 File Offset: 0x000017C0
		public static void SetTokenRegistrationOnInitEnabled(bool enable)
		{
			FirebaseMessagingInternalPINVOKE.SetTokenRegistrationOnInitEnabled(enable);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000035E4 File Offset: 0x000017E4
		public static Task RequestPermissionAsync()
		{
			return FutureVoid.GetTask(new FutureVoid(FirebaseMessagingInternalPINVOKE.RequestPermission(), true));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003608 File Offset: 0x00001808
		public static Task SubscribeAsync(string topic)
		{
			return FutureVoid.GetTask(new FutureVoid(FirebaseMessagingInternalPINVOKE.Subscribe(topic), true));
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003630 File Offset: 0x00001830
		public static Task UnsubscribeAsync(string topic)
		{
			return FutureVoid.GetTask(new FutureVoid(FirebaseMessagingInternalPINVOKE.Unsubscribe(topic), true));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003658 File Offset: 0x00001858
		public static bool DeliveryMetricsExportToBigQueryEnabled()
		{
			bool result = FirebaseMessagingInternalPINVOKE.DeliveryMetricsExportToBigQueryEnabled();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003680 File Offset: 0x00001880
		public static void SetDeliveryMetricsExportToBigQuery(bool enable)
		{
			FirebaseMessagingInternalPINVOKE.SetDeliveryMetricsExportToBigQuery(enable);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000036A4 File Offset: 0x000018A4
		public static Task<string> GetTokenAsync()
		{
			IntPtr token = FirebaseMessagingInternalPINVOKE.GetToken();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return FutureString.GetTask(new FutureString(token, true));
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000036D8 File Offset: 0x000018D8
		public static Task DeleteTokenAsync()
		{
			return FutureVoid.GetTask(new FutureVoid(FirebaseMessagingInternalPINVOKE.DeleteToken(), true));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000036FC File Offset: 0x000018FC
		private static void SetListenerCallbacks(FirebaseMessagingInternal.Listener.MessageReceivedDelegate messageCallback, FirebaseMessagingInternal.Listener.TokenReceivedDelegate tokenCallback)
		{
			FirebaseMessagingInternalPINVOKE.SetListenerCallbacks(messageCallback, tokenCallback);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003724 File Offset: 0x00001924
		private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled)
		{
			FirebaseMessagingInternalPINVOKE.SetListenerCallbacksEnabled(message_callback_enabled, token_callback_enabled);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000374C File Offset: 0x0000194C
		private static void SendPendingEvents()
		{
			FirebaseMessagingInternalPINVOKE.SendPendingEvents();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x04000032 RID: 50
		private static FirebaseMessagingInternal.Listener listener = FirebaseMessagingInternal.Listener.Create();

		// Token: 0x02000013 RID: 19
		internal class Listener : IDisposable
		{
			// Token: 0x06000104 RID: 260 RVA: 0x00003BA8 File Offset: 0x00001DA8
			internal static FirebaseMessagingInternal.Listener Create()
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				FirebaseMessagingInternal.Listener result;
				lock (typeFromHandle)
				{
					bool flag2 = FirebaseMessagingInternal.Listener.listener != null;
					if (flag2)
					{
						result = FirebaseMessagingInternal.Listener.listener;
					}
					else
					{
						FirebaseMessagingInternal.Listener.listener = new FirebaseMessagingInternal.Listener();
						result = FirebaseMessagingInternal.Listener.listener;
					}
				}
				return result;
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00003C10 File Offset: 0x00001E10
			internal static void Destroy()
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					bool flag2 = FirebaseMessagingInternal.Listener.listener == null;
					if (!flag2)
					{
						FirebaseMessagingInternal.Listener.listener.Dispose();
					}
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000106 RID: 262 RVA: 0x00003C6C File Offset: 0x00001E6C
			internal static FirebaseApp App
			{
				get
				{
					Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
					FirebaseApp result;
					lock (typeFromHandle)
					{
						result = ((FirebaseMessagingInternal.Listener.listener != null) ? FirebaseMessagingInternal.Listener.listener.app : null);
					}
					return result;
				}
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00003CC4 File Offset: 0x00001EC4
			private Listener()
			{
				FirebaseMessagingInternal.SetListenerCallbacks(this.messageReceivedDelegate, this.tokenReceivedDelegate);
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00003D1C File Offset: 0x00001F1C
			~Listener()
			{
				this.Dispose();
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00003D4C File Offset: 0x00001F4C
			public void Dispose()
			{
				Type typeFromHandle = typeof(FirebaseMessagingInternal.Listener);
				lock (typeFromHandle)
				{
					bool flag2 = FirebaseMessagingInternal.Listener.listener == this;
					if (flag2)
					{
						FirebaseMessagingInternal.SetListenerCallbacks(null, null);
						FirebaseMessagingInternal.Listener.listener = null;
						this.app = null;
					}
				}
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00003DB4 File Offset: 0x00001FB4
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternal.Listener.MessageReceivedDelegate))]
			private static bool MessageReceivedDelegateMethod(IntPtr message)
			{
				bool tookOwnership = false;
				return ExceptionAggregator.Wrap<bool>(delegate()
				{
					EventHandler<MessageReceivedEventArgs> messageReceivedInternal = FirebaseMessagingInternal.MessageReceivedInternal;
					bool flag = messageReceivedInternal != null;
					bool result;
					if (flag)
					{
						FirebaseMessageInternal firebaseMessageInternal = new FirebaseMessageInternal(message, true);
						tookOwnership = true;
						messageReceivedInternal(null, new MessageReceivedEventArgs(FirebaseMessage.FromInternal(firebaseMessageInternal)));
						firebaseMessageInternal.Dispose();
						result = true;
					}
					else
					{
						result = false;
					}
					return result;
				}, tookOwnership);
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00003DF4 File Offset: 0x00001FF4
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternal.Listener.TokenReceivedDelegate))]
			private static void TokenReceivedDelegateMethod(string token)
			{
				ExceptionAggregator.Wrap(delegate()
				{
					EventHandler<TokenReceivedEventArgs> tokenReceivedInternal = FirebaseMessagingInternal.TokenReceivedInternal;
					bool flag = tokenReceivedInternal != null;
					if (flag)
					{
						tokenReceivedInternal(null, new TokenReceivedEventArgs(token));
					}
				});
			}

			// Token: 0x04000045 RID: 69
			private FirebaseMessagingInternal.Listener.MessageReceivedDelegate messageReceivedDelegate = new FirebaseMessagingInternal.Listener.MessageReceivedDelegate(FirebaseMessagingInternal.Listener.MessageReceivedDelegateMethod);

			// Token: 0x04000046 RID: 70
			private FirebaseMessagingInternal.Listener.TokenReceivedDelegate tokenReceivedDelegate = new FirebaseMessagingInternal.Listener.TokenReceivedDelegate(FirebaseMessagingInternal.Listener.TokenReceivedDelegateMethod);

			// Token: 0x04000047 RID: 71
			private FirebaseApp app = FirebaseApp.DefaultInstance;

			// Token: 0x04000048 RID: 72
			private static FirebaseMessagingInternal.Listener listener;

			// Token: 0x02000017 RID: 23
			// (Invoke) Token: 0x06000119 RID: 281
			internal delegate bool MessageReceivedDelegate(IntPtr message);

			// Token: 0x02000018 RID: 24
			// (Invoke) Token: 0x0600011D RID: 285
			internal delegate void TokenReceivedDelegate(string token);
		}
	}
}
