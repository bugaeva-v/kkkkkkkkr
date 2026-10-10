using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000029 RID: 41
	internal struct AsyncOperationAwaiter : IAsyncOperationAwaiter, ICriticalNotifyCompletion, INotifyCompletion
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002508 File Offset: 0x00000708
		public AsyncOperationAwaiter(IAsyncOperation asyncOperation)
		{
			this.m_Operation = asyncOperation;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002514 File Offset: 0x00000714
		public void OnCompleted(Action continuation)
		{
			this.m_Operation.Completed += delegate(IAsyncOperation operation)
			{
				continuation();
			};
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002548 File Offset: 0x00000748
		public void UnsafeOnCompleted(Action continuation)
		{
			this.m_Operation.Completed += delegate(IAsyncOperation operation)
			{
				continuation();
			};
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002579 File Offset: 0x00000779
		public bool IsCompleted
		{
			get
			{
				return this.m_Operation.IsDone;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002586 File Offset: 0x00000786
		public void GetResult()
		{
			if (this.m_Operation.Status == AsyncOperationStatus.Failed || this.m_Operation.Status == AsyncOperationStatus.Cancelled)
			{
				throw this.m_Operation.Exception;
			}
		}

		// Token: 0x04000025 RID: 37
		private IAsyncOperation m_Operation;
	}
}
