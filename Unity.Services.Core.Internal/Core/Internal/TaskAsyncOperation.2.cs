using System;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000034 RID: 52
	internal class TaskAsyncOperation<T> : AsyncOperationBase<T>
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002938 File Offset: 0x00000B38
		public override bool IsCompleted
		{
			get
			{
				return this.m_Task.IsCompleted;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002945 File Offset: 0x00000B45
		public override T Result
		{
			get
			{
				return this.m_Task.Result;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002954 File Offset: 0x00000B54
		public override T GetResult()
		{
			return this.m_Task.GetAwaiter().GetResult();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002974 File Offset: 0x00000B74
		public override AsyncOperationBase<T> GetAwaiter()
		{
			return this;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002977 File Offset: 0x00000B77
		public override AsyncOperationStatus Status
		{
			get
			{
				if (this.m_Task == null)
				{
					return AsyncOperationStatus.None;
				}
				if (!this.m_Task.IsCompleted)
				{
					return AsyncOperationStatus.InProgress;
				}
				if (this.m_Task.IsCanceled)
				{
					return AsyncOperationStatus.Cancelled;
				}
				if (this.m_Task.IsFaulted)
				{
					return AsyncOperationStatus.Failed;
				}
				return AsyncOperationStatus.Succeeded;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000029B1 File Offset: 0x00000BB1
		public override Exception Exception
		{
			get
			{
				Task<T> task = this.m_Task;
				if (task == null)
				{
					return null;
				}
				return task.Exception;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000029C4 File Offset: 0x00000BC4
		public TaskAsyncOperation(Task<T> task)
		{
			if (TaskAsyncOperation.Scheduler == null)
			{
				TaskAsyncOperation.SetScheduler();
			}
			this.m_Task = task;
			task.ContinueWith(delegate(Task<T> t, object state)
			{
				((TaskAsyncOperation<T>)state).DidComplete();
			}, this, CancellationToken.None, TaskContinuationOptions.None, TaskAsyncOperation.Scheduler);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002A1C File Offset: 0x00000C1C
		public static TaskAsyncOperation<T> Run(Func<T> func)
		{
			Task<T> task = new Task<T>(func);
			TaskAsyncOperation<T> result = new TaskAsyncOperation<T>(task);
			task.Start();
			return result;
		}

		// Token: 0x04000031 RID: 49
		private Task<T> m_Task;
	}
}
