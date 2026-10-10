using System;

namespace UnityEngine.Playables
{
	// Token: 0x02000431 RID: 1073
	public struct FrameData
	{
		// Token: 0x06002563 RID: 9571 RVA: 0x0003F274 File Offset: 0x0003D474
		private bool HasFlags(FrameData.Flags flag)
		{
			return (this.m_Flags & flag) == flag;
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x0003F294 File Offset: 0x0003D494
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0003F2AC File Offset: 0x0003D4AC
		public float deltaTime
		{
			get
			{
				return (float)this.m_DeltaTime;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x0003F2F8 File Offset: 0x0003D4F8
		[Obsolete("effectiveParentDelay is obsolete; use a custom ScriptPlayable to implement this feature", false)]
		public double effectiveParentDelay
		{
			get
			{
				return this.m_EffectiveParentDelay;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0003F310 File Offset: 0x0003D510
		public float effectiveParentSpeed
		{
			get
			{
				return this.m_EffectiveParentSpeed;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x0003F328 File Offset: 0x0003D528
		public float effectiveSpeed
		{
			get
			{
				return this.m_EffectiveSpeed;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0003F340 File Offset: 0x0003D540
		public FrameData.EvaluationType evaluationType
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Evaluate) ? FrameData.EvaluationType.Evaluate : FrameData.EvaluationType.Playback;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x0003F360 File Offset: 0x0003D560
		public bool seekOccurred
		{
			get
			{
				return this.HasFlags(FrameData.Flags.SeekOccured);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0003F37C File Offset: 0x0003D57C
		public bool timeLooped
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Loop);
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x0003F398 File Offset: 0x0003D598
		public bool timeHeld
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Hold);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0003F3B4 File Offset: 0x0003D5B4
		public PlayableOutput output
		{
			get
			{
				return this.m_Output;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x0003F3CC File Offset: 0x0003D5CC
		public PlayState effectivePlayState
		{
			get
			{
				bool flag = this.HasFlags(FrameData.Flags.EffectivePlayStateDelayed);
				PlayState result;
				if (flag)
				{
					result = PlayState.Delayed;
				}
				else
				{
					bool flag2 = this.HasFlags(FrameData.Flags.EffectivePlayStatePlaying);
					if (flag2)
					{
						result = PlayState.Playing;
					}
					else
					{
						result = PlayState.Paused;
					}
				}
				return result;
			}
		}

		// Token: 0x04000DF0 RID: 3568
		internal ulong m_FrameID;

		// Token: 0x04000DF1 RID: 3569
		internal double m_DeltaTime;

		// Token: 0x04000DF2 RID: 3570
		internal float m_Weight;

		// Token: 0x04000DF3 RID: 3571
		internal float m_EffectiveWeight;

		// Token: 0x04000DF4 RID: 3572
		internal double m_EffectiveParentDelay;

		// Token: 0x04000DF5 RID: 3573
		internal float m_EffectiveParentSpeed;

		// Token: 0x04000DF6 RID: 3574
		internal float m_EffectiveSpeed;

		// Token: 0x04000DF7 RID: 3575
		internal FrameData.Flags m_Flags;

		// Token: 0x04000DF8 RID: 3576
		internal PlayableOutput m_Output;

		// Token: 0x02000432 RID: 1074
		[Flags]
		internal enum Flags
		{
			// Token: 0x04000DFA RID: 3578
			Evaluate = 1,
			// Token: 0x04000DFB RID: 3579
			SeekOccured = 2,
			// Token: 0x04000DFC RID: 3580
			Loop = 4,
			// Token: 0x04000DFD RID: 3581
			Hold = 8,
			// Token: 0x04000DFE RID: 3582
			EffectivePlayStateDelayed = 16,
			// Token: 0x04000DFF RID: 3583
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x02000433 RID: 1075
		public enum EvaluationType
		{
			// Token: 0x04000E01 RID: 3585
			Evaluate,
			// Token: 0x04000E02 RID: 3586
			Playback
		}
	}
}
