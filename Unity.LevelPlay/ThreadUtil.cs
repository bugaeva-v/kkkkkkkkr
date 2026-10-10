using System;
using System.Threading;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000026 RID: 38
	internal static class ThreadUtil
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x000054ED File Offset: 0x000036ED
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Init()
		{
			ThreadUtil.UnitySynchronizationContext = SynchronizationContext.Current;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000054F9 File Offset: 0x000036F9
		public static void Post(SendOrPostCallback d, object state = null)
		{
			ThreadUtil.UnitySynchronizationContext.Post(d, state);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00005507 File Offset: 0x00003707
		public static void Send(SendOrPostCallback d, object state = null)
		{
			ThreadUtil.UnitySynchronizationContext.Send(d, state);
		}

		// Token: 0x040000A9 RID: 169
		internal static SynchronizationContext UnitySynchronizationContext;
	}
}
