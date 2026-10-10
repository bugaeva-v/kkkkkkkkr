using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200028A RID: 650
	public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt>
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0005EADC File Offset: 0x0005CCDC
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0005EAFF File Offset: 0x0005CCFF
		public int value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : 0;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0005EB10 File Offset: 0x0005CD10
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0005EB28 File Offset: 0x0005CD28
		public StyleKeyword keyword
		{
			get
			{
				return this.m_Keyword;
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0005EB32 File Offset: 0x0005CD32
		public StyleInt(int v)
		{
			this = new StyleInt(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0005EB3E File Offset: 0x0005CD3E
		public StyleInt(StyleKeyword keyword)
		{
			this = new StyleInt(0, keyword);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0005EB4A File Offset: 0x0005CD4A
		internal StyleInt(int v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0005EB5C File Offset: 0x0005CD5C
		public static bool operator ==(StyleInt lhs, StyleInt rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0005EB90 File Offset: 0x0005CD90
		public static bool operator !=(StyleInt lhs, StyleInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0005EBAC File Offset: 0x0005CDAC
		public static implicit operator StyleInt(StyleKeyword keyword)
		{
			return new StyleInt(keyword);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		public static implicit operator StyleInt(int v)
		{
			return new StyleInt(v);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0005EBDC File Offset: 0x0005CDDC
		public bool Equals(StyleInt other)
		{
			return other == this;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0005EBFC File Offset: 0x0005CDFC
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleInt)
			{
				StyleInt other = (StyleInt)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0005EC28 File Offset: 0x0005CE28
		public override int GetHashCode()
		{
			return this.m_Value * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0005EC50 File Offset: 0x0005CE50
		public override string ToString()
		{
			return this.DebugString<int>();
		}

		// Token: 0x04000954 RID: 2388
		private int m_Value;

		// Token: 0x04000955 RID: 2389
		private StyleKeyword m_Keyword;
	}
}
