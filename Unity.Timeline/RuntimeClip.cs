using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000020 RID: 32
	internal class RuntimeClip : RuntimeClipBase
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00007DC8 File Offset: 0x00005FC8
		public override double start
		{
			get
			{
				return this.m_Clip.extrapolatedStart;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00007DD5 File Offset: 0x00005FD5
		public override double duration
		{
			get
			{
				return this.m_Clip.extrapolatedDuration;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007DE2 File Offset: 0x00005FE2
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
			this.Create(clip, clipPlayable, parentMixer);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00007DF3 File Offset: 0x00005FF3
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
			this.m_Clip = clip;
			this.m_Playable = clipPlayable;
			this.m_ParentMixer = parentMixer;
			clipPlayable.Pause<Playable>();
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00007E10 File Offset: 0x00006010
		public TimelineClip clip
		{
			get
			{
				return this.m_Clip;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00007E18 File Offset: 0x00006018
		public Playable mixer
		{
			get
			{
				return this.m_ParentMixer;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00007E20 File Offset: 0x00006020
		public Playable playable
		{
			get
			{
				return this.m_Playable;
			}
		}

		// Token: 0x17000096 RID: 150
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00007E28 File Offset: 0x00006028
		public override bool enable
		{
			set
			{
				if (value && this.m_Playable.GetPlayState<Playable>() != PlayState.Playing)
				{
					this.m_Playable.Play<Playable>();
					this.SetTime(this.m_Clip.clipIn);
					return;
				}
				if (!value && this.m_Playable.GetPlayState<Playable>() != PlayState.Paused)
				{
					this.m_Playable.Pause<Playable>();
					if (this.m_ParentMixer.IsValid<Playable>())
					{
						this.m_ParentMixer.SetInputWeight(this.m_Playable, 0f);
					}
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007EA1 File Offset: 0x000060A1
		public void SetTime(double time)
		{
			this.m_Playable.SetTime(time);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007EAF File Offset: 0x000060AF
		public void SetDuration(double duration)
		{
			this.m_Playable.SetDuration(duration);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007EC0 File Offset: 0x000060C0
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
			this.enable = true;
			if (frameData.timeLooped)
			{
				this.SetTime(this.clip.clipIn);
				this.SetTime(this.clip.clipIn);
			}
			float weight;
			if (this.clip.IsPreExtrapolatedTime(localTime))
			{
				weight = this.clip.EvaluateMixIn((double)((float)this.clip.start));
			}
			else if (this.clip.IsPostExtrapolatedTime(localTime))
			{
				weight = this.clip.EvaluateMixOut((double)((float)this.clip.end));
			}
			else
			{
				weight = this.clip.EvaluateMixIn(localTime) * this.clip.EvaluateMixOut(localTime);
			}
			if (this.mixer.IsValid<Playable>())
			{
				this.mixer.SetInputWeight(this.playable, weight);
			}
			double num = this.clip.ToLocalTime(localTime);
			if (num >= -DiscreteTime.tickValue / 2.0)
			{
				this.SetTime(num);
			}
			this.SetDuration(this.clip.extrapolatedDuration);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007FC8 File Offset: 0x000061C8
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
		{
			double num = Math.Min(localTime, (double)DiscreteTime.FromTicks(this.intervalEnd));
			if (frameData.timeLooped)
			{
				num = Math.Min(num, rootDuration);
			}
			double num2 = this.clip.ToLocalTime(num);
			if (num2 > -DiscreteTime.tickValue / 2.0)
			{
				this.SetTime(num2);
			}
			this.enable = false;
		}

		// Token: 0x040000BC RID: 188
		private TimelineClip m_Clip;

		// Token: 0x040000BD RID: 189
		private Playable m_Playable;

		// Token: 0x040000BE RID: 190
		private Playable m_ParentMixer;
	}
}
