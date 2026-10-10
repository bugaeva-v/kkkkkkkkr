using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000287 RID: 647
	public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat>
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0005E540 File Offset: 0x0005C740
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x0005E567 File Offset: 0x0005C767
		public float value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : 0f;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0005E578 File Offset: 0x0005C778
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x0005E590 File Offset: 0x0005C790
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

		// Token: 0x06001532 RID: 5426 RVA: 0x0005E59A File Offset: 0x0005C79A
		public StyleFloat(float v)
		{
			this = new StyleFloat(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0005E5A6 File Offset: 0x0005C7A6
		public StyleFloat(StyleKeyword keyword)
		{
			this = new StyleFloat(0f, keyword);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0005E5B6 File Offset: 0x0005C7B6
		internal StyleFloat(float v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0005E5C8 File Offset: 0x0005C7C8
		public static bool operator ==(StyleFloat lhs, StyleFloat rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0005E5FC File Offset: 0x0005C7FC
		public static bool operator !=(StyleFloat lhs, StyleFloat rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0005E618 File Offset: 0x0005C818
		public static implicit operator StyleFloat(StyleKeyword keyword)
		{
			return new StyleFloat(keyword);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0005E630 File Offset: 0x0005C830
		public static implicit operator StyleFloat(float v)
		{
			return new StyleFloat(v);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0005E648 File Offset: 0x0005C848
		public bool Equals(StyleFloat other)
		{
			return other == this;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0005E668 File Offset: 0x0005C868
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleFloat)
			{
				StyleFloat other = (StyleFloat)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0005E694 File Offset: 0x0005C894
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0005E6C0 File Offset: 0x0005C8C0
		public override string ToString()
		{
			return this.DebugString<float>();
		}

		// Token: 0x0400094E RID: 2382
		private float m_Value;

		// Token: 0x0400094F RID: 2383
		private StyleKeyword m_Keyword;
	}
}
