using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001C RID: 28
	internal class InfiniteRuntimeClip : RuntimeElement
	{
		// Token: 0x060001EA RID: 490 RVA: 0x0000771A File Offset: 0x0000591A
		public InfiniteRuntimeClip(Playable playable)
		{
			this.m_Playable = playable;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00007729 File Offset: 0x00005929
		public override long intervalStart
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000772D File Offset: 0x0000592D
		public override long intervalEnd
		{
			get
			{
				return InfiniteRuntimeClip.kIntervalEnd;
			}
		}

		// Token: 0x1700008D RID: 141
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00007734 File Offset: 0x00005934
		public override bool enable
		{
			set
			{
				if (value)
				{
					this.m_Playable.Play<Playable>();
					return;
				}
				this.m_Playable.Pause<Playable>();
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007750 File Offset: 0x00005950
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
			this.m_Playable.SetTime(localTime);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000775E File Offset: 0x0000595E
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
		{
			this.m_Playable.SetTime(localTime);
			this.enable = false;
		}

		// Token: 0x040000AF RID: 175
		private Playable m_Playable;

		// Token: 0x040000B0 RID: 176
		private static readonly long kIntervalEnd = DiscreteTime.GetNearestTick(TimelineClip.kMaxTimeValue);
	}
}
