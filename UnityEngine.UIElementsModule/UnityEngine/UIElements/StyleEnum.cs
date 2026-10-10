using System;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements
{
	// Token: 0x02000286 RID: 646
	public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> where T : struct, IConvertible
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005E388 File Offset: 0x0005C588
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0005E3B3 File Offset: 0x0005C5B3
		public T value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(T);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005E3C4 File Offset: 0x0005C5C4
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0005E3DC File Offset: 0x0005C5DC
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

		// Token: 0x06001523 RID: 5411 RVA: 0x0005E3E6 File Offset: 0x0005C5E6
		public StyleEnum(T v)
		{
			this = new StyleEnum<T>(v, StyleKeyword.Undefined);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0005E3F4 File Offset: 0x0005C5F4
		public StyleEnum(StyleKeyword keyword)
		{
			this = new StyleEnum<T>(default(T), keyword);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0005E413 File Offset: 0x0005C613
		internal StyleEnum(T v, StyleKeyword keyword)
		{
			this.m_Keyword = keyword;
			this.m_Value = v;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0005E424 File Offset: 0x0005C624
		public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && UnsafeUtility.EnumEquals<T>(lhs.m_Value, rhs.m_Value);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0005E458 File Offset: 0x0005C658
		public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0005E474 File Offset: 0x0005C674
		public static implicit operator StyleEnum<T>(StyleKeyword keyword)
		{
			return new StyleEnum<T>(keyword);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0005E48C File Offset: 0x0005C68C
		public static implicit operator StyleEnum<T>(T v)
		{
			return new StyleEnum<T>(v);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0005E4A4 File Offset: 0x0005C6A4
		public bool Equals(StyleEnum<T> other)
		{
			return other == this;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0005E4C4 File Offset: 0x0005C6C4
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is StyleEnum<T>)
			{
				StyleEnum<T> other = (StyleEnum<T>)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0005E4F0 File Offset: 0x0005C6F0
		public override int GetHashCode()
		{
			return UnsafeUtility.EnumToInt<T>(this.m_Value) * 397 ^ (int)this.m_Keyword;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0005E51C File Offset: 0x0005C71C
		public override string ToString()
		{
			return this.DebugString<T>();
		}

		// Token: 0x0400094C RID: 2380
		private T m_Value;

		// Token: 0x0400094D RID: 2381
		private StyleKeyword m_Keyword;
	}
}
