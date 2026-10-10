using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000416 RID: 1046
	public struct SortingLayerRange : IEquatable<SortingLayerRange>
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x0003CF12 File Offset: 0x0003B112
		public SortingLayerRange(short lowerBound, short upperBound)
		{
			this.m_LowerBound = lowerBound;
			this.m_UpperBound = upperBound;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x0003CF24 File Offset: 0x0003B124
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0003CF3C File Offset: 0x0003B13C
		public short lowerBound
		{
			get
			{
				return this.m_LowerBound;
			}
			set
			{
				this.m_LowerBound = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0003CF48 File Offset: 0x0003B148
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0003CF60 File Offset: 0x0003B160
		public short upperBound
		{
			get
			{
				return this.m_UpperBound;
			}
			set
			{
				this.m_UpperBound = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x0003CF6C File Offset: 0x0003B16C
		public static SortingLayerRange all
		{
			get
			{
				return new SortingLayerRange
				{
					m_LowerBound = short.MinValue,
					m_UpperBound = short.MaxValue
				};
			}
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0003CF9C File Offset: 0x0003B19C
		public bool Equals(SortingLayerRange other)
		{
			return this.m_LowerBound == other.m_LowerBound && this.m_UpperBound == other.m_UpperBound;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		public override bool Equals(object obj)
		{
			bool flag = !(obj is SortingLayerRange);
			return !flag && this.Equals((SortingLayerRange)obj);
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0003D004 File Offset: 0x0003B204
		public static bool operator !=(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0003D024 File Offset: 0x0003B224
		public static bool operator ==(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0003D040 File Offset: 0x0003B240
		public override int GetHashCode()
		{
			return (int)this.m_UpperBound << 16 | ((int)this.m_LowerBound & 65535);
		}

		// Token: 0x04000D54 RID: 3412
		private short m_LowerBound;

		// Token: 0x04000D55 RID: 3413
		private short m_UpperBound;
	}
}
