using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000031 RID: 49
	public class ActivationControlPlayable : PlayableBehaviour
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlaybackState)
		{
			if (gameObject == null)
			{
				return ScriptPlayable<ActivationControlPlayable>.Null;
			}
			ScriptPlayable<ActivationControlPlayable> result = ScriptPlayable<ActivationControlPlayable>.Create(graph, 0);
			ActivationControlPlayable behaviour = result.GetBehaviour();
			behaviour.gameObject = gameObject;
			behaviour.postPlayback = postPlaybackState;
			return result;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00008AD9 File Offset: 0x00006CD9
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			if (this.gameObject == null)
			{
				return;
			}
			this.gameObject.SetActive(true);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00008AF6 File Offset: 0x00006CF6
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
			if (this.gameObject != null && info.effectivePlayState == PlayState.Paused)
			{
				this.gameObject.SetActive(false);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00008B1B File Offset: 0x00006D1B
		public override void ProcessFrame(Playable playable, FrameData info, object userData)
		{
			if (this.gameObject != null)
			{
				this.gameObject.SetActive(true);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008B37 File Offset: 0x00006D37
		public override void OnGraphStart(Playable playable)
		{
			if (this.gameObject != null && this.m_InitialState == ActivationControlPlayable.InitialState.Unset)
			{
				this.m_InitialState = (this.gameObject.activeSelf ? ActivationControlPlayable.InitialState.Active : ActivationControlPlayable.InitialState.Inactive);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00008B68 File Offset: 0x00006D68
		public override void OnPlayableDestroy(Playable playable)
		{
			if (this.gameObject == null || this.m_InitialState == ActivationControlPlayable.InitialState.Unset)
			{
				return;
			}
			switch (this.postPlayback)
			{
			case ActivationControlPlayable.PostPlaybackState.Active:
				this.gameObject.SetActive(true);
				return;
			case ActivationControlPlayable.PostPlaybackState.Inactive:
				this.gameObject.SetActive(false);
				return;
			case ActivationControlPlayable.PostPlaybackState.Revert:
				this.gameObject.SetActive(this.m_InitialState == ActivationControlPlayable.InitialState.Active);
				return;
			default:
				return;
			}
		}

		// Token: 0x040000D1 RID: 209
		public GameObject gameObject;

		// Token: 0x040000D2 RID: 210
		public ActivationControlPlayable.PostPlaybackState postPlayback = ActivationControlPlayable.PostPlaybackState.Revert;

		// Token: 0x040000D3 RID: 211
		private ActivationControlPlayable.InitialState m_InitialState;

		// Token: 0x02000071 RID: 113
		public enum PostPlaybackState
		{
			// Token: 0x04000169 RID: 361
			Active,
			// Token: 0x0400016A RID: 362
			Inactive,
			// Token: 0x0400016B RID: 363
			Revert
		}

		// Token: 0x02000072 RID: 114
		private enum InitialState
		{
			// Token: 0x0400016D RID: 365
			Unset,
			// Token: 0x0400016E RID: 366
			Active,
			// Token: 0x0400016F RID: 367
			Inactive
		}
	}
}
