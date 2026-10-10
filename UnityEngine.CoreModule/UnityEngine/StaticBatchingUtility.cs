using System;
using Unity.Profiling;

namespace UnityEngine
{
	// Token: 0x02000241 RID: 577
	public sealed class StaticBatchingUtility
	{
		// Token: 0x060018AE RID: 6318 RVA: 0x000282F4 File Offset: 0x000264F4
		public static void Combine(GameObject staticBatchRoot)
		{
			using (StaticBatchingUtility.s_CombineMarker.Auto())
			{
				InternalStaticBatchingUtility.CombineRoot(staticBatchRoot, null);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00028338 File Offset: 0x00026538
		public static void Combine(GameObject[] gos, GameObject staticBatchRoot)
		{
			using (StaticBatchingUtility.s_CombineMarker.Auto())
			{
				InternalStaticBatchingUtility.CombineGameObjects(gos, staticBatchRoot, false, null);
			}
		}

		// Token: 0x0400084E RID: 2126
		internal static ProfilerMarker s_CombineMarker = new ProfilerMarker("StaticBatching.Combine");

		// Token: 0x0400084F RID: 2127
		internal static ProfilerMarker s_SortMarker = new ProfilerMarker("StaticBatching.SortObjects");

		// Token: 0x04000850 RID: 2128
		internal static ProfilerMarker s_MakeBatchMarker = new ProfilerMarker("StaticBatching.MakeBatch");
	}
}
