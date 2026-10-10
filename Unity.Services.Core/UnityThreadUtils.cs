using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core
{
	// Token: 0x02000010 RID: 16
	internal static class UnityThreadUtils
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000025BB File Offset: 0x000007BB
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000025C2 File Offset: 0x000007C2
		internal static TaskScheduler UnityThreadScheduler { get; private set; }

		// Token: 0x06000049 RID: 73 RVA: 0x000025CA File Offset: 0x000007CA
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureUnityThreadInfo()
		{
			UnityThreadUtils.s_UnityThreadId = Thread.CurrentThread.ManagedThreadId;
			UnityThreadUtils.UnityThreadScheduler = TaskScheduler.FromCurrentSynchronizationContext();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000025E5 File Offset: 0x000007E5
		public static bool IsRunningOnUnityThread
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId == UnityThreadUtils.s_UnityThreadId;
			}
		}

		// Token: 0x04000021 RID: 33
		private static int s_UnityThreadId;
	}
}
