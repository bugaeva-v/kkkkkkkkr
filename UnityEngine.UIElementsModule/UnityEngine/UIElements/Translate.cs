using System;
using System.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x02000298 RID: 664
	public struct Translate : IEquatable<Translate>
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x0005FFCB File Offset: 0x0005E1CB
		public Translate(Length x, Length y, float z)
		{
			this.m_X = x;
			this.m_Y = y;
			this.m_Z = z;
			this.m_isNone = false;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0005FFEA File Offset: 0x0005E1EA
		public Translate(Length x, Length y)
		{
			this = new Translate(x, y, 0f);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0005FFFC File Offset: 0x0005E1FC
		public static Translate None()
		{
			return new Translate
			{
				m_isNone = true
			};
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0006001F File Offset: 0x0005E21F
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x00060027 File Offset: 0x0005E227
		public Length x
		{
			get
			{
				return this.m_X;
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00060030 File Offset: 0x0005E230
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x00060038 File Offset: 0x0005E238
		public Length y
		{
			get
			{
				return this.m_Y;
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00060041 File Offset: 0x0005E241
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00060049 File Offset: 0x0005E249
		public float z
		{
			get
			{
				return this.m_Z;
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00060052 File Offset: 0x0005E252
		internal bool IsNone()
		{
			return this.m_isNone;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0006005C File Offset: 0x0005E25C
		public static bool operator ==(Translate lhs, Translate rhs)
		{
			return lhs.m_X == rhs.m_X && lhs.m_Y == rhs.m_Y && lhs.m_Z == rhs.m_Z && lhs.m_isNone == rhs.m_isNone;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000600B4 File Offset: 0x0005E2B4
		public static bool operator !=(Translate lhs, Translate rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000600D0 File Offset: 0x0005E2D0
		public bool Equals(Translate other)
		{
			return other == this;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000600F0 File Offset: 0x0005E2F0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is Translate)
			{
				Translate other = (Translate)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0006011C File Offset: 0x0005E31C
		public override int GetHashCode()
		{
			return this.m_X.GetHashCode() * 793 ^ this.m_Y.GetHashCode() * 791 ^ this.m_Z.GetHashCode() * 571;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00060170 File Offset: 0x0005E370
		public override string ToString()
		{
			string text = this.m_Z.ToString(CultureInfo.InvariantCulture.NumberFormat);
			return string.Concat(new string[]
			{
				this.m_X.ToString(),
				" ",
				this.m_Y.ToString(),
				" ",
				text
			});
		}

		// Token: 0x04000972 RID: 2418
		private Length m_X;

		// Token: 0x04000973 RID: 2419
		private Length m_Y;

		// Token: 0x04000974 RID: 2420
		private float m_Z;

		// Token: 0x04000975 RID: 2421
		private bool m_isNone;
	}
}
