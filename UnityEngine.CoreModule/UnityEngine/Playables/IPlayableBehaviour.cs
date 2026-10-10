using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000438 RID: 1080
	public interface IPlayableBehaviour
	{
		// Token: 0x06002587 RID: 9607
		[RequiredByNativeCode]
		void OnGraphStart(Playable playable);

		// Token: 0x06002588 RID: 9608
		[RequiredByNativeCode]
		void OnGraphStop(Playable playable);

		// Token: 0x06002589 RID: 9609
		[RequiredByNativeCode]
		void OnPlayableCreate(Playable playable);

		// Token: 0x0600258A RID: 9610
		[RequiredByNativeCode]
		void OnPlayableDestroy(Playable playable);

		// Token: 0x0600258B RID: 9611
		[RequiredByNativeCode]
		void OnBehaviourPlay(Playable playable, FrameData info);

		// Token: 0x0600258C RID: 9612
		[RequiredByNativeCode]
		void OnBehaviourPause(Playable playable, FrameData info);

		// Token: 0x0600258D RID: 9613
		[RequiredByNativeCode]
		void PrepareFrame(Playable playable, FrameData info);

		// Token: 0x0600258E RID: 9614
		[RequiredByNativeCode]
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}
}
