using System;
using System.Collections.Generic;

namespace UnityEngine.Playables
{
	// Token: 0x0200043D RID: 1085
	public interface IPlayableAsset
	{
		// Token: 0x0600259A RID: 9626
		Playable CreatePlayable(PlayableGraph graph, GameObject owner);

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600259B RID: 9627
		double duration { get; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600259C RID: 9628
		IEnumerable<PlayableBinding> outputs { get; }
	}
}
