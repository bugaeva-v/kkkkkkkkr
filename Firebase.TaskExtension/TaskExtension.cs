using System;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Platform;

namespace Firebase.Extensions
{
	// Token: 0x02000002 RID: 2
	public static class TaskExtension
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Task ContinueWithOnMainThread(this Task task, Action<Task> continuation)
		{
			return task.ContinueWith<Task<bool>>((Task t) => FirebaseHandler.RunOnMainThreadAsync<bool>(delegate
			{
				continuation(t);
				return true;
			})).Unwrap<bool>();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
		public static Task ContinueWithOnMainThread(this Task task, Action<Task> continuation, CancellationToken cancellationToken)
		{
			return task.ContinueWith<Task<bool>>((Task t) => FirebaseHandler.RunOnMainThreadAsync<bool>(delegate
			{
				continuation(t);
				return true;
			}), cancellationToken).Unwrap<bool>();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020C0 File Offset: 0x000002C0
		public static Task<TResult> ContinueWithOnMainThread<TResult>(this Task task, Func<Task, TResult> continuation)
		{
			return task.ContinueWith<Task<TResult>>((Task t) => FirebaseHandler.RunOnMainThreadAsync<TResult>(() => continuation(t))).Unwrap<TResult>();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020F8 File Offset: 0x000002F8
		public static Task<TResult> ContinueWithOnMainThread<TResult>(this Task task, Func<Task, TResult> continuation, CancellationToken cancellationToken)
		{
			return task.ContinueWith<Task<TResult>>((Task t) => FirebaseHandler.RunOnMainThreadAsync<TResult>(() => continuation(t)), cancellationToken).Unwrap<TResult>();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public static Task ContinueWithOnMainThread<T>(this Task<T> task, Action<Task<T>> continuation)
		{
			return task.ContinueWith<Task<bool>>((Task<T> t) => FirebaseHandler.RunOnMainThreadAsync<bool>(delegate
			{
				continuation(t);
				return true;
			})).Unwrap<bool>();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002168 File Offset: 0x00000368
		public static Task<TResult> ContinueWithOnMainThread<TResult, T>(this Task<T> task, Func<Task<T>, TResult> continuation)
		{
			return task.ContinueWith<Task<TResult>>((Task<T> t) => FirebaseHandler.RunOnMainThreadAsync<TResult>(() => continuation(t))).Unwrap<TResult>();
		}
	}
}
