using System;
using System.Collections.Generic;
using System.Linq;

namespace NSubstitute.ReceivedExtensions
{
	// Token: 0x02000045 RID: 69
	public abstract class Quantity
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00004637 File Offset: 0x00002837
		public static Quantity Exactly(int number)
		{
			if (number != 0)
			{
				return new Quantity.ExactQuantity(number);
			}
			return Quantity.None();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004648 File Offset: 0x00002848
		public static Quantity AtLeastOne()
		{
			return new Quantity.AnyNonZeroQuantity();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000464F File Offset: 0x0000284F
		public static Quantity None()
		{
			return new Quantity.NoneQuantity();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004656 File Offset: 0x00002856
		public static Quantity Within(int minInclusive, int maxInclusive)
		{
			return new Quantity.RangeQuantity(minInclusive, maxInclusive);
		}

		// Token: 0x060000FB RID: 251
		public abstract bool Matches<T>(IEnumerable<T> items);

		// Token: 0x060000FC RID: 252
		public abstract bool RequiresMoreThan<T>(IEnumerable<T> items);

		// Token: 0x060000FD RID: 253
		public abstract string Describe(string singularNoun, string pluralNoun);

		// Token: 0x02000101 RID: 257
		private class ExactQuantity : Quantity
		{
			// Token: 0x06000409 RID: 1033 RVA: 0x000097F2 File Offset: 0x000079F2
			public ExactQuantity(int number)
			{
				this._number = number;
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00009801 File Offset: 0x00007A01
			public override bool Matches<T>(IEnumerable<T> items)
			{
				return this._number == items.Count<T>();
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00009811 File Offset: 0x00007A11
			public override bool RequiresMoreThan<T>(IEnumerable<T> items)
			{
				return this._number > items.Count<T>();
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00009821 File Offset: 0x00007A21
			public override string Describe(string singularNoun, string pluralNoun)
			{
				return string.Format("exactly {0} {1}", this._number, (this._number == 1) ? singularNoun : pluralNoun);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00009845 File Offset: 0x00007A45
			public bool Equals(Quantity.ExactQuantity other)
			{
				return other != null && (this == other || other._number == this._number);
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00009860 File Offset: 0x00007A60
			public override bool Equals(object obj)
			{
				return obj != null && (this == obj || (!(obj.GetType() != typeof(Quantity.ExactQuantity)) && this.Equals((Quantity.ExactQuantity)obj)));
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00009892 File Offset: 0x00007A92
			public override int GetHashCode()
			{
				return this._number;
			}

			// Token: 0x0400012E RID: 302
			private readonly int _number;
		}

		// Token: 0x02000102 RID: 258
		private class AnyNonZeroQuantity : Quantity
		{
			// Token: 0x06000410 RID: 1040 RVA: 0x0000989A File Offset: 0x00007A9A
			public override bool Matches<T>(IEnumerable<T> items)
			{
				return items.Any<T>();
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x000098A2 File Offset: 0x00007AA2
			public override bool RequiresMoreThan<T>(IEnumerable<T> items)
			{
				return !items.Any<T>();
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x000098AD File Offset: 0x00007AAD
			public override string Describe(string singularNoun, string pluralNoun)
			{
				return string.Format("a {0}", singularNoun);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x000098BA File Offset: 0x00007ABA
			public bool Equals(Quantity.AnyNonZeroQuantity other)
			{
				return other != null;
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000098C0 File Offset: 0x00007AC0
			public override bool Equals(object obj)
			{
				return obj != null && (this == obj || (!(obj.GetType() != typeof(Quantity.AnyNonZeroQuantity)) && this.Equals((Quantity.AnyNonZeroQuantity)obj)));
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x000098F2 File Offset: 0x00007AF2
			public override int GetHashCode()
			{
				return 0;
			}
		}

		// Token: 0x02000103 RID: 259
		private class NoneQuantity : Quantity
		{
			// Token: 0x06000417 RID: 1047 RVA: 0x000098FD File Offset: 0x00007AFD
			public override bool Matches<T>(IEnumerable<T> items)
			{
				return !items.Any<T>();
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x00009908 File Offset: 0x00007B08
			public override bool RequiresMoreThan<T>(IEnumerable<T> items)
			{
				return false;
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x0000990B File Offset: 0x00007B0B
			public override string Describe(string singularNoun, string pluralNoun)
			{
				return "no " + pluralNoun;
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00009918 File Offset: 0x00007B18
			public bool Equals(Quantity.NoneQuantity other)
			{
				return other != null;
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000991E File Offset: 0x00007B1E
			public override bool Equals(object obj)
			{
				return obj != null && (this == obj || (!(obj.GetType() != typeof(Quantity.NoneQuantity)) && this.Equals((Quantity.NoneQuantity)obj)));
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00009950 File Offset: 0x00007B50
			public override int GetHashCode()
			{
				return 0;
			}
		}

		// Token: 0x02000104 RID: 260
		private class RangeQuantity : Quantity
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x0000995C File Offset: 0x00007B5C
			public RangeQuantity(int minInclusive, int maxInclusive)
			{
				if (minInclusive < 0)
				{
					throw new ArgumentOutOfRangeException("minInclusive", string.Format("{0} must be >= 0, but was {1}.", "minInclusive", minInclusive));
				}
				if (maxInclusive <= minInclusive)
				{
					throw new ArgumentOutOfRangeException("maxInclusive", string.Format("{0} must be greater than {1} (was {2}, required > {3}).", new object[]
					{
						"maxInclusive",
						"minInclusive",
						maxInclusive,
						minInclusive
					}));
				}
				this.minInclusive = minInclusive;
				this.maxInclusive = maxInclusive;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x000099E2 File Offset: 0x00007BE2
			public override string Describe(string singularNoun, string pluralNoun)
			{
				return string.Format("between {0} and {1} (inclusive) {2}", this.minInclusive, this.maxInclusive, (this.maxInclusive == 1) ? singularNoun : pluralNoun);
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00009A14 File Offset: 0x00007C14
			public override bool Matches<T>(IEnumerable<T> items)
			{
				int num = items.Count<T>();
				return num >= this.minInclusive && num <= this.maxInclusive;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00009A3F File Offset: 0x00007C3F
			public override bool RequiresMoreThan<T>(IEnumerable<T> items)
			{
				return items.Count<T>() < this.minInclusive;
			}

			// Token: 0x0400012F RID: 303
			private readonly int minInclusive;

			// Token: 0x04000130 RID: 304
			private readonly int maxInclusive;
		}
	}
}
