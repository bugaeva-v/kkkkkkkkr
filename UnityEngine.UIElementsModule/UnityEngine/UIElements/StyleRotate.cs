using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200028D RID: 653
	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0005F103 File Offset: 0x0005D303
		public Rotate value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(Rotate);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0005F114 File Offset: 0x0005D314
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x0005F12C File Offset: 0x0005D32C
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

		// Token: 0x06001595 RID: 5525 RVA: 0x0005F136 File Offset: 0x0005D336
		public StyleRotate(Rotate v)
		{
			this = new StyleRotate(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0005F144 File Offset: 0x0005D344
		public StyleRotate(StyleKeyword keyword)
		{
			this = new StyleRotate(default(Rotate), keyword);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0005F163 File Offset: 0x0005D363
		internal StyleRotate(Rotate v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0005F174 File Offset: 0x0005D374
		public static bool operator ==(StyleRotate lhs, StyleRotate rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0005F1A8 File Offset: 0x0005D3A8
		public static bool operator !=(StyleRotate lhs, StyleRotate rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0005F1C4 File Offset: 0x0005D3C4
		public static implicit operator StyleRotate(StyleKeyword keyword)
		{
			return new StyleRotate(keyword);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0005F1DC File Offset: 0x0005D3DC
		public static implicit operator StyleRotate(Rotate v)
		{
			return new StyleRotate(v);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		public bool Equals(StyleRotate other)
		{
			return other == this;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0005F214 File Offset: 0x0005D414
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleRotate)
			{
				StyleRotate other = (StyleRotate)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0005F240 File Offset: 0x0005D440
		public override int GetHashCode()
		{
			return this.m_Value.GetHashCode() * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0005F274 File Offset: 0x0005D474
		public override string ToString()
		{
			return this.DebugString<Rotate>();
		}

		// Token: 0x0400095A RID: 2394
		private Rotate m_Value;

		// Token: 0x0400095B RID: 2395
		private StyleKeyword m_Keyword;
	}
}
