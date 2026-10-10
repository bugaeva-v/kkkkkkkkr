using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000032 RID: 50
	[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
	[Serializable]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00008BE3 File Offset: 0x00006DE3
		public virtual double duration
		{
			get
			{
				return PlayableBinding.DefaultDuration;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00008BEA File Offset: 0x00006DEA
		public virtual IEnumerable<PlayableBinding> outputs
		{
			get
			{
				return PlayableBinding.None;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008BF1 File Offset: 0x00006DF1
		public virtual void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00008BF3 File Offset: 0x00006DF3
		public virtual void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008BF5 File Offset: 0x00006DF5
		public virtual void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008BF7 File Offset: 0x00006DF7
		public virtual void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008BF9 File Offset: 0x00006DF9
		public virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00008BFB File Offset: 0x00006DFB
		public virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00008BFD File Offset: 0x00006DFD
		public virtual void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00008BFF File Offset: 0x00006DFF
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008C01 File Offset: 0x00006E01
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return ScriptPlayable<BasicPlayableBehaviour>.Create(graph, this, 0);
		}
	}
}
