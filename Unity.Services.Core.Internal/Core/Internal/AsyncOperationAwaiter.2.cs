using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200002A RID: 42
	internal struct AsyncOperationAwaiter<T> : IAsyncOperationAwaiter<T>, ICriticalNotifyCompletion, INotifyCompletion
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000025B0 File Offset: 0x000007B0
		public AsyncOperationAwaiter(IAsyncOperation<T> asyncOperation)
		{
			this.m_Operation = asyncOperation;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000025BC File Offset: 0x000007BC
		public void OnCompleted(Action continuation)
		{
			this.m_Operation.Completed += delegate(IAsyncOperation<T> obj)
			{
				continuation();
			};
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000025F0 File Offset: 0x000007F0
		public void UnsafeOnCompleted(Action continuation)
		{
			this.m_Operation.Completed += delegate(IAsyncOperation<T> obj)
			{
				continuation();
			};
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002621 File Offset: 0x00000821
		public bool IsCompleted
		{
			get
			{
				return this.m_Operation.IsDone;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000262E File Offset: 0x0000082E
		public T GetResult()
		{
			if (this.m_Operation.Status == AsyncOperationStatus.Failed || this.m_Operation.Status == AsyncOperationStatus.Cancelled)
			{
				throw this.m_Operation.Exception;
			}
			return this.m_Operation.Result;
		}

		// Token: 0x04000026 RID: 38
		private IAsyncOperation<T> m_Operation;
	}
}
