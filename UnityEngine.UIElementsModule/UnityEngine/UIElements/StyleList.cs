using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x0200028C RID: 652
	public struct StyleList<T> : IStyleValue<List<T>>, IEquatable<StyleList<T>>
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0005EE90 File Offset: 0x0005D090
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0005EEB3 File Offset: 0x0005D0B3
		public List<T> value
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0005EEDC File Offset: 0x0005D0DC
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

		// Token: 0x06001586 RID: 5510 RVA: 0x0005EEE6 File Offset: 0x0005D0E6
		public StyleList(List<T> v)
		{
			this = new StyleList<T>(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0005EEF2 File Offset: 0x0005D0F2
		public StyleList(StyleKeyword keyword)
		{
			this = new StyleList<T>(null, keyword);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0005EEFE File Offset: 0x0005D0FE
		internal StyleList(List<T> v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0005EF10 File Offset: 0x0005D110
		public static bool operator ==(StyleList<T> lhs, StyleList<T> rhs)
		{
			bool flag = lhs.m_Keyword != rhs.m_Keyword;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				List<T> value = lhs.m_Value;
				List<T> value2 = rhs.m_Value;
				bool flag2 = value == value2;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = value == null || value2 == null;
					result = (!flag3 && value.Count == value2.Count && value.SequenceEqual(value2));
				}
			}
			return result;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0005EF84 File Offset: 0x0005D184
		public static bool operator !=(StyleList<T> lhs, StyleList<T> rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0005EFA0 File Offset: 0x0005D1A0
		public static implicit operator StyleList<T>(StyleKeyword keyword)
		{
			return new StyleList<T>(keyword);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0005EFB8 File Offset: 0x0005D1B8
		public static implicit operator StyleList<T>(List<T> v)
		{
			return new StyleList<T>(v);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0005EFD0 File Offset: 0x0005D1D0
		public bool Equals(StyleList<T> other)
		{
			return other == this;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0005EFF0 File Offset: 0x0005D1F0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleList<T>)
			{
				StyleList<T> other = (StyleList<T>)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0005F01C File Offset: 0x0005D21C
		public override int GetHashCode()
		{
			int num = 0;
			bool flag = this.m_Value != null && this.m_Value.Count > 0;
			if (flag)
			{
				num = EqualityComparer<T>.Default.GetHashCode(this.m_Value[0]);
				for (int i = 1; i < this.m_Value.Count; i++)
				{
					num = (num * 397 ^ EqualityComparer<T>.Default.GetHashCode(this.m_Value[i]));
				}
			}
			return num * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		public override string ToString()
		{
			return this.DebugString<List<T>>();
		}

		// Token: 0x04000958 RID: 2392
		private StyleKeyword m_Keyword;

		// Token: 0x04000959 RID: 2393
		private List<T> m_Value;
	}
}
