using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Firebase
{
	// Token: 0x02000003 RID: 3
	internal class Dispatcher
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002245 File Offset: 0x00000445
		public Dispatcher()
		{
			this.ownerThreadId = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000226C File Offset: 0x0000046C
		public TResult Run<TResult>(Func<TResult> callback)
		{
			bool flag = this.ManagesThisThread();
			TResult result2;
			if (flag)
			{
				result2 = callback();
			}
			else
			{
				EventWaitHandle waitHandle = new EventWaitHandle(false, EventResetMode.ManualReset);
				Dispatcher.CallbackStorage<TResult> result = new Dispatcher.CallbackStorage<TResult>();
				Queue<Action> obj = this.queue;
				lock (obj)
				{
					this.queue.Enqueue(delegate
					{
						try
						{
							result.Result = callback();
						}
						catch (Exception exception)
						{
							result.Exception = exception;
						}
						finally
						{
							waitHandle.Set();
						}
					});
				}
				waitHandle.WaitOne();
				bool flag3 = result.Exception != null;
				if (flag3)
				{
					throw result.Exception;
				}
				result2 = result.Result;
			}
			return result2;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002344 File Offset: 0x00000544
		public Task<TResult> RunAsync<TResult>(Func<TResult> callback)
		{
			bool flag = this.ManagesThisThread();
			Task<TResult> result;
			if (flag)
			{
				result = Dispatcher.RunAsyncNow<TResult>(callback);
			}
			else
			{
				TaskCompletionSource<TResult> tcs = new TaskCompletionSource<TResult>();
				Queue<Action> obj = this.queue;
				lock (obj)
				{
					this.queue.Enqueue(delegate
					{
						try
						{
							tcs.SetResult(callback());
						}
						catch (Exception exception)
						{
							tcs.SetException(exception);
						}
					});
				}
				result = tcs.Task;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023E0 File Offset: 0x000005E0
		internal static Task<TResult> RunAsyncNow<TResult>(Func<TResult> callback)
		{
			Task<TResult> result;
			try
			{
				result = Task.FromResult<TResult>(callback());
			}
			catch (Exception exception)
			{
				TaskCompletionSource<TResult> taskCompletionSource = new TaskCompletionSource<TResult>();
				taskCompletionSource.TrySetException(exception);
				result = taskCompletionSource.Task;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002430 File Offset: 0x00000630
		internal bool ManagesThisThread()
		{
			return Thread.CurrentThread.ManagedThreadId == this.ownerThreadId;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002454 File Offset: 0x00000654
		public void PollJobs()
		{
			for (;;)
			{
				Queue<Action> obj = this.queue;
				Action action;
				lock (obj)
				{
					bool flag2 = this.queue.Count > 0;
					if (!flag2)
					{
						break;
					}
					action = this.queue.Dequeue();
				}
				ExceptionAggregator.Wrap(action);
			}
		}

		// Token: 0x04000002 RID: 2
		private int ownerThreadId;

		// Token: 0x04000003 RID: 3
		private Queue<Action> queue = new Queue<Action>();

		// Token: 0x0200001A RID: 26
		private class CallbackStorage<TResult>
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003A7C File Offset: 0x00001C7C
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003A84 File Offset: 0x00001C84
			public TResult Result { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003A8D File Offset: 0x00001C8D
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x00003A95 File Offset: 0x00001C95
			public Exception Exception { get; set; }
		}
	}
}
