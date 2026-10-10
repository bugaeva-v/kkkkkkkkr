using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A3 RID: 163
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreConnectUseCase : IStoreConnectUseCase, IStoreConnectCallback
	{
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060002B1 RID: 689 RVA: 0x00006BEC File Offset: 0x00004DEC
		// (remove) Token: 0x060002B2 RID: 690 RVA: 0x00006C24 File Offset: 0x00004E24
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<StoreConnectionFailureDescription> OnStoreDisconnection;

		// Token: 0x060002B3 RID: 691 RVA: 0x00006C59 File Offset: 0x00004E59
		internal StoreConnectUseCase(IStore store, IRetryService retryService, IRetryPolicy retryPolicyOnDisconnect)
		{
			this.m_RetryService = retryService;
			this.m_Store = store;
			this.m_Store.SetStoreConnectionCallback(this);
			this.m_RetryPolicyOnDisconnect = retryPolicyOnDisconnect;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006C84 File Offset: 0x00004E84
		public Task Connect()
		{
			Task result;
			try
			{
				IInternalStore internalStore = this.m_Store as IInternalStore;
				if (internalStore != null)
				{
					internalStore.SetStoreConnectionState(ConnectionState.Connecting);
				}
				if (this.m_CurrentConnectionCompletion == null || this.m_CurrentConnectionCompletion.Task.IsCompleted)
				{
					this.m_CurrentConnectionCompletion = new TaskCompletionSource<object>();
					this.InitializeRequest();
				}
				result = this.m_CurrentConnectionCompletion.Task;
			}
			catch (Exception ex)
			{
				Action<StoreConnectionFailureDescription> onStoreDisconnection = this.OnStoreDisconnection;
				if (onStoreDisconnection != null)
				{
					onStoreDisconnection(new StoreConnectionFailureDescription(ex.Message, false));
				}
				result = Task.CompletedTask;
			}
			return result;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00006D18 File Offset: 0x00004F18
		private void InitializeRequest()
		{
			this.m_CurrentRequest = this.m_RetryService.CreateRequest(new Action(this.m_Store.Connect), this.m_RetryPolicyOnDisconnect);
			this.m_CurrentRequest.Invoke();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00006D4F File Offset: 0x00004F4F
		public void OnStoreConnectionSucceeded()
		{
			IInternalStore internalStore = this.m_Store as IInternalStore;
			if (internalStore != null)
			{
				internalStore.SetStoreConnectionState(ConnectionState.Connected);
			}
			TaskCompletionSource<object> currentConnectionCompletion = this.m_CurrentConnectionCompletion;
			if (currentConnectionCompletion != null)
			{
				currentConnectionCompletion.TrySetResult(null);
			}
			this.m_CurrentRequest = null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00006D84 File Offset: 0x00004F84
		public void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription)
		{
			StoreConnectUseCase.<OnStoreConnectionFailed>d__12 <OnStoreConnectionFailed>d__;
			<OnStoreConnectionFailed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnStoreConnectionFailed>d__.<>4__this = this;
			<OnStoreConnectionFailed>d__.failureDescription = failureDescription;
			<OnStoreConnectionFailed>d__.<>1__state = -1;
			<OnStoreConnectionFailed>d__.<>t__builder.Start<StoreConnectUseCase.<OnStoreConnectionFailed>d__12>(ref <OnStoreConnectionFailed>d__);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00006DC3 File Offset: 0x00004FC3
		private void SendDisconnectionEvent(StoreConnectionFailureDescription connectionFailureDescription)
		{
			IInternalStore internalStore = this.m_Store as IInternalStore;
			if (internalStore != null)
			{
				internalStore.SetStoreConnectionState(ConnectionState.Disconnected);
			}
			Action<StoreConnectionFailureDescription> onStoreDisconnection = this.OnStoreDisconnection;
			if (onStoreDisconnection != null)
			{
				onStoreDisconnection(connectionFailureDescription);
			}
			TaskCompletionSource<object> currentConnectionCompletion = this.m_CurrentConnectionCompletion;
			if (currentConnectionCompletion == null)
			{
				return;
			}
			currentConnectionCompletion.TrySetResult(null);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00006E00 File Offset: 0x00005000
		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy)
		{
			this.m_RetryPolicyOnDisconnect = retryPolicy;
		}

		// Token: 0x040000DB RID: 219
		private readonly IStore m_Store;

		// Token: 0x040000DC RID: 220
		private readonly IRetryService m_RetryService;

		// Token: 0x040000DD RID: 221
		private IRetryPolicy m_RetryPolicyOnDisconnect;

		// Token: 0x040000DF RID: 223
		[Nullable(2)]
		private TaskCompletionSource<object> m_CurrentConnectionCompletion;

		// Token: 0x040000E0 RID: 224
		[Nullable(2)]
		private IRetryRequest m_CurrentRequest;
	}
}
