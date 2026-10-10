using System;
using System.Threading.Tasks;

namespace Firebase.Internal
{
	// Token: 0x0200001F RID: 31
	internal static class TaskCompletionSourceCompat<T>
	{
		// Token: 0x06000299 RID: 665 RVA: 0x000088C2 File Offset: 0x00006AC2
		private static void SetExceptionInternal(TaskCompletionSource<T> tcs, AggregateException exception)
		{
			tcs.SetException(exception);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000088D0 File Offset: 0x00006AD0
		public static void SetException(TaskCompletionSource<T> tcs, AggregateException exception)
		{
			try
			{
				TaskCompletionSourceCompat<T>.SetExceptionInternal(tcs, exception);
			}
			catch (Exception)
			{
				tcs.SetException(exception);
			}
		}
	}
}
