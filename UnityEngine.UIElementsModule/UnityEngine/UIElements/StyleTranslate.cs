using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200028F RID: 655
	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
	{
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0005F458 File Offset: 0x0005D658
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0005F483 File Offset: 0x0005D683
		public Translate value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(Translate);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0005F494 File Offset: 0x0005D694
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x0005F4AC File Offset: 0x0005D6AC
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

		// Token: 0x060015B3 RID: 5555 RVA: 0x0005F4B6 File Offset: 0x0005D6B6
		public StyleTranslate(Translate v)
		{
			this = new StyleTranslate(v, StyleKeyword.Undefined);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0005F4C4 File Offset: 0x0005D6C4
		public StyleTranslate(StyleKeyword keyword)
		{
			this = new StyleTranslate(default(Translate), keyword);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0005F4E3 File Offset: 0x0005D6E3
		internal StyleTranslate(Translate v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0005F528 File Offset: 0x0005D728
		public static bool operator !=(StyleTranslate lhs, StyleTranslate rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0005F544 File Offset: 0x0005D744
		public static implicit operator StyleTranslate(StyleKeyword keyword)
		{
			return new StyleTranslate(keyword);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0005F55C File Offset: 0x0005D75C
		public static implicit operator StyleTranslate(Translate v)
		{
			return new StyleTranslate(v);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0005F574 File Offset: 0x0005D774
		public bool Equals(StyleTranslate other)
		{
			return other == this;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0005F594 File Offset: 0x0005D794
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleTranslate)
			{
				StyleTranslate other = (StyleTranslate)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0005F5C0 File Offset: 0x0005D7C0
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0005F5F4 File Offset: 0x0005D7F4
		public override string ToString()
		{
			return this.DebugString<Translate>();
		}

		// Token: 0x0400095E RID: 2398
		private Translate m_Value;

		// Token: 0x0400095F RID: 2399
		private StyleKeyword m_Keyword;
	}
}
