using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200028B RID: 651
	public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
	{
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0005EC74 File Offset: 0x0005CE74
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0005EC9F File Offset: 0x0005CE9F
		public Length value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(Length);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0005ECB0 File Offset: 0x0005CEB0
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
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

		// Token: 0x06001575 RID: 5493 RVA: 0x0005ECD2 File Offset: 0x0005CED2
		public StyleLength(float v)
		{
			this = new StyleLength(new Length(v, LengthUnit.Pixel), StyleKeyword.Undefined);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0005ECE4 File Offset: 0x0005CEE4
		public StyleLength(Length v)
		{
			this = new StyleLength(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0005ECF0 File Offset: 0x0005CEF0
		public StyleLength(StyleKeyword keyword)
		{
			this = new StyleLength(default(Length), keyword);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0005ED10 File Offset: 0x0005CF10
		internal StyleLength(Length v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
			bool flag = v.IsAuto();
			if (flag)
			{
				this.m_Keyword = StyleKeyword.Auto;
			}
			else
			{
				bool flag2 = v.IsNone();
				if (flag2)
				{
					this.m_Keyword = StyleKeyword.None;
				}
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0005ED54 File Offset: 0x0005CF54
		public static bool operator ==(StyleLength lhs, StyleLength rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0005ED88 File Offset: 0x0005CF88
		public static bool operator !=(StyleLength lhs, StyleLength rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		public static implicit operator StyleLength(StyleKeyword keyword)
		{
			return new StyleLength(keyword);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0005EDBC File Offset: 0x0005CFBC
		public static implicit operator StyleLength(float v)
		{
			return new StyleLength(v);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0005EDD4 File Offset: 0x0005CFD4
		public static implicit operator StyleLength(Length v)
		{
			return new StyleLength(v);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0005EDEC File Offset: 0x0005CFEC
		public bool Equals(StyleLength other)
		{
			return other == this;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0005EE0C File Offset: 0x0005D00C
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleLength)
			{
				StyleLength other = (StyleLength)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0005EE38 File Offset: 0x0005D038
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0005EE6C File Offset: 0x0005D06C
		public override string ToString()
		{
			return this.DebugString<Length>();
		}

		// Token: 0x04000956 RID: 2390
		private Length m_Value;

		// Token: 0x04000957 RID: 2391
		private StyleKeyword m_Keyword;
	}
}
