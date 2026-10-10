using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Scripting;

namespace Uniject
{
	// Token: 0x02000007 RID: 7
	[Preserve]
	internal class UnityThreadUtils : IThreadUtils
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000208E File Offset: 0x0000028E
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureUnityThreadInfo()
		{
			UnityThreadUtils.s_UnityThreadId = Thread.CurrentThread.ManagedThreadId;
			UnityThreadUtils.UnityThreadScheduler = TaskScheduler.FromCurrentSynchronizationContext();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000020A9 File Offset: 0x000002A9
		public bool IsRunningOnMainThread
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId == UnityThreadUtils.s_UnityThreadId;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		public Task PostAsync(Action action)
		{
			return Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None, UnityThreadUtils.UnityThreadScheduler);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020D4 File Offset: 0x000002D4
		public Task PostAsync(Action<object> action, object state)
		{
			return Task.Factory.StartNew(action, state, CancellationToken.None, TaskCreationOptions.None, UnityThreadUtils.UnityThreadScheduler);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020ED File Offset: 0x000002ED
		public Task<T> PostAsync<T>(Func<T> action)
		{
			return Task<T>.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None, UnityThreadUtils.UnityThreadScheduler);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002105 File Offset: 0x00000305
		public Task<T> PostAsync<T>(Func<object, T> action, object state)
		{
			return Task<T>.Factory.StartNew(action, state, CancellationToken.None, TaskCreationOptions.None, UnityThreadUtils.UnityThreadScheduler);
		}

		// Token: 0x04000003 RID: 3
		private static int s_UnityThreadId;

		// Token: 0x04000004 RID: 4
		private static TaskScheduler UnityThreadScheduler;
	}
}
