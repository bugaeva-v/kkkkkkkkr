using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003F0 RID: 1008
	public struct BlendState : IEquatable<BlendState>
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000387A0 File Offset: 0x000369A0
		public static BlendState defaultValue
		{
			get
			{
				return new BlendState(false, false);
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000387BC File Offset: 0x000369BC
		public BlendState(bool separateMRTBlend = false, bool alphaToMask = false)
		{
			this.m_BlendState0 = RenderTargetBlendState.defaultValue;
			this.m_BlendState1 = RenderTargetBlendState.defaultValue;
			this.m_BlendState2 = RenderTargetBlendState.defaultValue;
			this.m_BlendState3 = RenderTargetBlendState.defaultValue;
			this.m_BlendState4 = RenderTargetBlendState.defaultValue;
			this.m_BlendState5 = RenderTargetBlendState.defaultValue;
			this.m_BlendState6 = RenderTargetBlendState.defaultValue;
			this.m_BlendState7 = RenderTargetBlendState.defaultValue;
			this.m_SeparateMRTBlendStates = Convert.ToByte(separateMRTBlend);
			this.m_AlphaToMask = Convert.ToByte(alphaToMask);
			this.m_Padding = 0;
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00038844 File Offset: 0x00036A44
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00038861 File Offset: 0x00036A61
		public bool separateMRTBlendStates
		{
			get
			{
				return Convert.ToBoolean(this.m_SeparateMRTBlendStates);
			}
			set
			{
				this.m_SeparateMRTBlendStates = Convert.ToByte(value);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00038870 File Offset: 0x00036A70
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x0003888D File Offset: 0x00036A8D
		public bool alphaToMask
		{
			get
			{
				return Convert.ToBoolean(this.m_AlphaToMask);
			}
			set
			{
				this.m_AlphaToMask = Convert.ToByte(value);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0003889C File Offset: 0x00036A9C
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x000388B4 File Offset: 0x00036AB4
		public RenderTargetBlendState blendState0
		{
			get
			{
				return this.m_BlendState0;
			}
			set
			{
				this.m_BlendState0 = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000388C0 File Offset: 0x00036AC0
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x000388D8 File Offset: 0x00036AD8
		public RenderTargetBlendState blendState1
		{
			get
			{
				return this.m_BlendState1;
			}
			set
			{
				this.m_BlendState1 = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000388E4 File Offset: 0x00036AE4
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x000388FC File Offset: 0x00036AFC
		public RenderTargetBlendState blendState2
		{
			get
			{
				return this.m_BlendState2;
			}
			set
			{
				this.m_BlendState2 = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00038908 File Offset: 0x00036B08
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00038920 File Offset: 0x00036B20
		public RenderTargetBlendState blendState3
		{
			get
			{
				return this.m_BlendState3;
			}
			set
			{
				this.m_BlendState3 = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0003892C File Offset: 0x00036B2C
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00038944 File Offset: 0x00036B44
		public RenderTargetBlendState blendState4
		{
			get
			{
				return this.m_BlendState4;
			}
			set
			{
				this.m_BlendState4 = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00038950 File Offset: 0x00036B50
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00038968 File Offset: 0x00036B68
		public RenderTargetBlendState blendState5
		{
			get
			{
				return this.m_BlendState5;
			}
			set
			{
				this.m_BlendState5 = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00038974 File Offset: 0x00036B74
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0003898C File Offset: 0x00036B8C
		public RenderTargetBlendState blendState6
		{
			get
			{
				return this.m_BlendState6;
			}
			set
			{
				this.m_BlendState6 = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00038998 File Offset: 0x00036B98
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x000389B0 File Offset: 0x00036BB0
		public RenderTargetBlendState blendState7
		{
			get
			{
				return this.m_BlendState7;
			}
			set
			{
				this.m_BlendState7 = value;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000389BC File Offset: 0x00036BBC
		public bool Equals(BlendState other)
		{
			return this.m_BlendState0.Equals(other.m_BlendState0) && this.m_BlendState1.Equals(other.m_BlendState1) && this.m_BlendState2.Equals(other.m_BlendState2) && this.m_BlendState3.Equals(other.m_BlendState3) && this.m_BlendState4.Equals(other.m_BlendState4) && this.m_BlendState5.Equals(other.m_BlendState5) && this.m_BlendState6.Equals(other.m_BlendState6) && this.m_BlendState7.Equals(other.m_BlendState7) && this.m_SeparateMRTBlendStates == other.m_SeparateMRTBlendStates && this.m_AlphaToMask == other.m_AlphaToMask;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00038A8C File Offset: 0x00036C8C
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is BlendState && this.Equals((BlendState)obj);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00038AC4 File Offset: 0x00036CC4
		public override int GetHashCode()
		{
			int num = this.m_BlendState0.GetHashCode();
			num = (num * 397 ^ this.m_BlendState1.GetHashCode());
			num = (num * 397 ^ this.m_BlendState2.GetHashCode());
			num = (num * 397 ^ this.m_BlendState3.GetHashCode());
			num = (num * 397 ^ this.m_BlendState4.GetHashCode());
			num = (num * 397 ^ this.m_BlendState5.GetHashCode());
			num = (num * 397 ^ this.m_BlendState6.GetHashCode());
			num = (num * 397 ^ this.m_BlendState7.GetHashCode());
			num = (num * 397 ^ this.m_SeparateMRTBlendStates.GetHashCode());
			return num * 397 ^ this.m_AlphaToMask.GetHashCode();
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00038BC8 File Offset: 0x00036DC8
		public static bool operator ==(BlendState left, BlendState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00038BE4 File Offset: 0x00036DE4
		public static bool operator !=(BlendState left, BlendState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000C70 RID: 3184
		private RenderTargetBlendState m_BlendState0;

		// Token: 0x04000C71 RID: 3185
		private RenderTargetBlendState m_BlendState1;

		// Token: 0x04000C72 RID: 3186
		private RenderTargetBlendState m_BlendState2;

		// Token: 0x04000C73 RID: 3187
		private RenderTargetBlendState m_BlendState3;

		// Token: 0x04000C74 RID: 3188
		private RenderTargetBlendState m_BlendState4;

		// Token: 0x04000C75 RID: 3189
		private RenderTargetBlendState m_BlendState5;

		// Token: 0x04000C76 RID: 3190
		private RenderTargetBlendState m_BlendState6;

		// Token: 0x04000C77 RID: 3191
		private RenderTargetBlendState m_BlendState7;

		// Token: 0x04000C78 RID: 3192
		private byte m_SeparateMRTBlendStates;

		// Token: 0x04000C79 RID: 3193
		private byte m_AlphaToMask;

		// Token: 0x04000C7A RID: 3194
		private short m_Padding;
	}
}
