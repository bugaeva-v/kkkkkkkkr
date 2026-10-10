using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000404 RID: 1028
	public struct RasterState : IEquatable<RasterState>
	{
		// Token: 0x060022EB RID: 8939 RVA: 0x0003AD11 File Offset: 0x00038F11
		public RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0f, bool depthClip = true)
		{
			this.m_CullingMode = cullingMode;
			this.m_OffsetUnits = offsetUnits;
			this.m_OffsetFactor = offsetFactor;
			this.m_DepthClip = Convert.ToByte(depthClip);
			this.m_Conservative = Convert.ToByte(false);
			this.m_Padding1 = 0;
			this.m_Padding2 = 0;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0003AD50 File Offset: 0x00038F50
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0003AD68 File Offset: 0x00038F68
		public CullMode cullingMode
		{
			get
			{
				return this.m_CullingMode;
			}
			set
			{
				this.m_CullingMode = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0003AD74 File Offset: 0x00038F74
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x0003AD91 File Offset: 0x00038F91
		public bool depthClip
		{
			get
			{
				return Convert.ToBoolean(this.m_DepthClip);
			}
			set
			{
				this.m_DepthClip = Convert.ToByte(value);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x0003ADBD File Offset: 0x00038FBD
		public bool conservative
		{
			get
			{
				return Convert.ToBoolean(this.m_Conservative);
			}
			set
			{
				this.m_Conservative = Convert.ToByte(value);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0003ADCC File Offset: 0x00038FCC
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		public int offsetUnits
		{
			get
			{
				return this.m_OffsetUnits;
			}
			set
			{
				this.m_OffsetUnits = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x0003AE08 File Offset: 0x00039008
		public float offsetFactor
		{
			get
			{
				return this.m_OffsetFactor;
			}
			set
			{
				this.m_OffsetFactor = value;
			}
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0003AE14 File Offset: 0x00039014
		public bool Equals(RasterState other)
		{
			return this.m_CullingMode == other.m_CullingMode && this.m_OffsetUnits == other.m_OffsetUnits && this.m_OffsetFactor.Equals(other.m_OffsetFactor) && this.m_DepthClip == other.m_DepthClip && this.m_Conservative == other.m_Conservative;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0003AE74 File Offset: 0x00039074
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is RasterState && this.Equals((RasterState)obj);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0003AEAC File Offset: 0x000390AC
		public override int GetHashCode()
		{
			int num = (int)this.m_CullingMode;
			num = (num * 397 ^ this.m_OffsetUnits);
			num = (num * 397 ^ this.m_OffsetFactor.GetHashCode());
			num = (num * 397 ^ this.m_DepthClip.GetHashCode());
			return num * 397 ^ this.m_Conservative.GetHashCode();
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0003AF14 File Offset: 0x00039114
		public static bool operator ==(RasterState left, RasterState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0003AF30 File Offset: 0x00039130
		public static bool operator !=(RasterState left, RasterState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000CFF RID: 3327
		public static readonly RasterState defaultValue = new RasterState(CullMode.Back, 0, 0f, true);

		// Token: 0x04000D00 RID: 3328
		private CullMode m_CullingMode;

		// Token: 0x04000D01 RID: 3329
		private int m_OffsetUnits;

		// Token: 0x04000D02 RID: 3330
		private float m_OffsetFactor;

		// Token: 0x04000D03 RID: 3331
		private byte m_DepthClip;

		// Token: 0x04000D04 RID: 3332
		private byte m_Conservative;

		// Token: 0x04000D05 RID: 3333
		private byte m_Padding1;

		// Token: 0x04000D06 RID: 3334
		private byte m_Padding2;
	}
}
