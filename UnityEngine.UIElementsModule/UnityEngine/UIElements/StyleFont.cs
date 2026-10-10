using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000288 RID: 648
	public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0005E6E4 File Offset: 0x0005C8E4
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0005E707 File Offset: 0x0005C907
		public Font value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : null;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0005E718 File Offset: 0x0005C918
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0005E730 File Offset: 0x0005C930
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

		// Token: 0x06001541 RID: 5441 RVA: 0x0005E73A File Offset: 0x0005C93A
		public StyleFont(Font v)
		{
			this = new StyleFont(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0005E746 File Offset: 0x0005C946
		public StyleFont(StyleKeyword keyword)
		{
			this = new StyleFont(null, keyword);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0005E752 File Offset: 0x0005C952
		internal StyleFont(Font v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0005E764 File Offset: 0x0005C964
		public static bool operator ==(StyleFont lhs, StyleFont rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0005E798 File Offset: 0x0005C998
		public static bool operator !=(StyleFont lhs, StyleFont rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
		public static implicit operator StyleFont(StyleKeyword keyword)
		{
			return new StyleFont(keyword);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0005E7CC File Offset: 0x0005C9CC
		public static implicit operator StyleFont(Font v)
		{
			return new StyleFont(v);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0005E7E4 File Offset: 0x0005C9E4
		public bool Equals(StyleFont other)
		{
			return other == this;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0005E804 File Offset: 0x0005CA04
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleFont)
			{
				StyleFont other = (StyleFont)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0005E830 File Offset: 0x0005CA30
		public override int GetHashCode()
		{
			return ((this.m_Value != null) ? this.m_Value.GetHashCode() : 0) * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0005E86C File Offset: 0x0005CA6C
		public override string ToString()
		{
			return this.DebugString<Font>();
		}

		// Token: 0x04000950 RID: 2384
		private Font m_Value;

		// Token: 0x04000951 RID: 2385
		private StyleKeyword m_Keyword;
	}
}
