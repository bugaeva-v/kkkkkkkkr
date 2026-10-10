using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000281 RID: 641
	public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0005A90F File Offset: 0x00058B0F
		public Color value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : Color.clear;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0005A920 File Offset: 0x00058B20
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0005A938 File Offset: 0x00058B38
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

		// Token: 0x060014DB RID: 5339 RVA: 0x0005A942 File Offset: 0x00058B42
		public StyleColor(Color v)
		{
			this = new StyleColor(v, StyleKeyword.Undefined);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0005A94E File Offset: 0x00058B4E
		public StyleColor(StyleKeyword keyword)
		{
			this = new StyleColor(Color.clear, keyword);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0005A95E File Offset: 0x00058B5E
		internal StyleColor(Color v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0005A970 File Offset: 0x00058B70
		public static bool operator ==(StyleColor lhs, StyleColor rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0005A9A4 File Offset: 0x00058BA4
		public static bool operator !=(StyleColor lhs, StyleColor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0005A9C0 File Offset: 0x00058BC0
		public static bool operator ==(StyleColor lhs, Color rhs)
		{
			StyleColor rhs2 = new StyleColor(rhs);
			return lhs == rhs2;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005A9E4 File Offset: 0x00058BE4
		public static bool operator !=(StyleColor lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005AA00 File Offset: 0x00058C00
		public static implicit operator StyleColor(StyleKeyword keyword)
		{
			return new StyleColor(keyword);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0005AA18 File Offset: 0x00058C18
		public static implicit operator StyleColor(Color v)
		{
			return new StyleColor(v);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005AA30 File Offset: 0x00058C30
		public bool Equals(StyleColor other)
		{
			return other == this;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005AA50 File Offset: 0x00058C50
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleColor)
			{
				StyleColor other = (StyleColor)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0005AA7C File Offset: 0x00058C7C
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		public override string ToString()
		{
			return this.DebugString<Color>();
		}

		// Token: 0x0400093F RID: 2367
		private Color m_Value;

		// Token: 0x04000940 RID: 2368
		private StyleKeyword m_Keyword;
	}
}
