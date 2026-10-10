using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000291 RID: 657
	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
	{
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x0005F804 File Offset: 0x0005DA04
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x0005F82F File Offset: 0x0005DA2F
		public TransformOrigin value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(TransformOrigin);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0005F840 File Offset: 0x0005DA40
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0005F858 File Offset: 0x0005DA58
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

		// Token: 0x060015D1 RID: 5585 RVA: 0x0005F862 File Offset: 0x0005DA62
		public StyleTransformOrigin(TransformOrigin v)
		{
			this = new StyleTransformOrigin(v, StyleKeyword.Undefined);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0005F870 File Offset: 0x0005DA70
		public StyleTransformOrigin(StyleKeyword keyword)
		{
			this = new StyleTransformOrigin(default(TransformOrigin), keyword);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0005F88F File Offset: 0x0005DA8F
		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0005F8A0 File Offset: 0x0005DAA0
		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0005F8D4 File Offset: 0x0005DAD4
		public static bool operator !=(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
		public static implicit operator StyleTransformOrigin(StyleKeyword keyword)
		{
			return new StyleTransformOrigin(keyword);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0005F908 File Offset: 0x0005DB08
		public static implicit operator StyleTransformOrigin(TransformOrigin v)
		{
			return new StyleTransformOrigin(v);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0005F920 File Offset: 0x0005DB20
		public bool Equals(StyleTransformOrigin other)
		{
			return other == this;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0005F940 File Offset: 0x0005DB40
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleTransformOrigin)
			{
				StyleTransformOrigin other = (StyleTransformOrigin)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0005F96C File Offset: 0x0005DB6C
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0005F9A0 File Offset: 0x0005DBA0
		public override string ToString()
		{
			return this.DebugString<TransformOrigin>();
		}

		// Token: 0x04000962 RID: 2402
		private TransformOrigin m_Value;

		// Token: 0x04000963 RID: 2403
		private StyleKeyword m_Keyword;
	}
}
