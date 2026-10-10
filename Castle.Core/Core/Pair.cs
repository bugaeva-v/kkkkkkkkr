using System;

namespace Castle.Core
{
	// Token: 0x020000B0 RID: 176
	public class Pair<TFirst, TSecond> : IEquatable<Pair<TFirst, TSecond>>
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x0000F761 File Offset: 0x0000D961
		public Pair(TFirst first, TSecond second)
		{
			this.first = first;
			this.second = second;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000F777 File Offset: 0x0000D977
		public TFirst First
		{
			get
			{
				return this.first;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0000F77F File Offset: 0x0000D97F
		public TSecond Second
		{
			get
			{
				return this.second;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000F787 File Offset: 0x0000D987
		public override string ToString()
		{
			return this.first + " " + this.second;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		public bool Equals(Pair<TFirst, TSecond> other)
		{
			return other != null && object.Equals(this.first, other.first) && object.Equals(this.second, other.second);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		public override bool Equals(object obj)
		{
			return this == obj || this.Equals(obj as Pair<TFirst, TSecond>);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000F80C File Offset: 0x0000DA0C
		public override int GetHashCode()
		{
			TFirst tfirst = this.first;
			int hashCode = tfirst.GetHashCode();
			int num = 29;
			TSecond tsecond = this.second;
			return hashCode + num * tsecond.GetHashCode();
		}

		// Token: 0x0400013A RID: 314
		private readonly TFirst first;

		// Token: 0x0400013B RID: 315
		private readonly TSecond second;
	}
}
