using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000038 RID: 56
	public class TimeControlPlayable : PlayableBehaviour
	{
		// Token: 0x06000299 RID: 665 RVA: 0x000094A8 File Offset: 0x000076A8
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl)
		{
			if (timeControl == null)
			{
				return ScriptPlayable<TimeControlPlayable>.Null;
			}
			ScriptPlayable<TimeControlPlayable> result = ScriptPlayable<TimeControlPlayable>.Create(graph, 0);
			result.GetBehaviour().Initialize(timeControl);
			return result;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000094D4 File Offset: 0x000076D4
		public void Initialize(ITimeControl timeControl)
		{
			this.m_timeControl = timeControl;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000094DD File Offset: 0x000076DD
		public override void PrepareFrame(Playable playable, FrameData info)
		{
			if (this.m_timeControl != null)
			{
				this.m_timeControl.SetTime(playable.GetTime<Playable>());
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000094F8 File Offset: 0x000076F8
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			if (this.m_timeControl == null)
			{
				return;
			}
			if (!this.m_started)
			{
				this.m_timeControl.OnControlTimeStart();
				this.m_started = true;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000951D File Offset: 0x0000771D
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
			if (this.m_timeControl == null)
			{
				return;
			}
			if (this.m_started)
			{
				this.m_timeControl.OnControlTimeStop();
				this.m_started = false;
			}
		}

		// Token: 0x040000E1 RID: 225
		private ITimeControl m_timeControl;

		// Token: 0x040000E2 RID: 226
		private bool m_started;
	}
}
