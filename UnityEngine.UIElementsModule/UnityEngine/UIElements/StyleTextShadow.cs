using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000290 RID: 656
	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0005F618 File Offset: 0x0005D818
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0005F643 File Offset: 0x0005D843
		public TextShadow value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(TextShadow);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0005F654 File Offset: 0x0005D854
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0005F66C File Offset: 0x0005D86C
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

		// Token: 0x060015C2 RID: 5570 RVA: 0x0005F676 File Offset: 0x0005D876
		public StyleTextShadow(TextShadow v)
		{
			this = new StyleTextShadow(v, StyleKeyword.Undefined);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0005F684 File Offset: 0x0005D884
		public StyleTextShadow(StyleKeyword keyword)
		{
			this = new StyleTextShadow(default(TextShadow), keyword);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0005F6A3 File Offset: 0x0005D8A3
		internal StyleTextShadow(TextShadow v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
		public static bool operator !=(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0005F704 File Offset: 0x0005D904
		public static implicit operator StyleTextShadow(StyleKeyword keyword)
		{
			return new StyleTextShadow(keyword);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0005F71C File Offset: 0x0005D91C
		public static implicit operator StyleTextShadow(TextShadow v)
		{
			return new StyleTextShadow(v);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0005F734 File Offset: 0x0005D934
		public bool Equals(StyleTextShadow other)
		{
			return other == this;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0005F754 File Offset: 0x0005D954
		public override bool Equals(object obj)
		{
			bool flag = !(obj is StyleTextShadow);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				StyleTextShadow lhs = (StyleTextShadow)obj;
				result = (lhs == this);
			}
			return result;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0005F790 File Offset: 0x0005D990
		public override int GetHashCode()
		{
			int num = 917506989;
			num = num * -1521134295 + this.m_Keyword.GetHashCode();
			return num * -1521134295 + this.m_Value.GetHashCode();
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
		public override string ToString()
		{
			return this.DebugString<TextShadow>();
		}

		// Token: 0x04000960 RID: 2400
		private StyleKeyword m_Keyword;

		// Token: 0x04000961 RID: 2401
		private TextShadow m_Value;
	}
}
