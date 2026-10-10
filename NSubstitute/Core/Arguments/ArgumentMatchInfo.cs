using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CD RID: 205
	public class ArgumentMatchInfo
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00008955 File Offset: 0x00006B55
		public ArgumentMatchInfo(int index, [Nullable(2)] object argument, IArgumentSpecification specification)
		{
			this.Index = index;
			this._argument = argument;
			this._specification = specification;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00008972 File Offset: 0x00006B72
		public int Index { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000897A File Offset: 0x00006B7A
		public bool IsMatch
		{
			get
			{
				return this._specification.IsSatisfiedBy(this._argument);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00008990 File Offset: 0x00006B90
		public string DescribeNonMatch()
		{
			string text = this._specification.DescribeNonMatch(this._argument);
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			string text2 = "arg[" + this.Index.ToString() + "]: ";
			return string.Format("{0}{1}", text2, text.Replace("\n", "\n".PadRight(text2.Length + 1)));
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00008A04 File Offset: 0x00006C04
		[NullableContext(2)]
		public bool Equals(ArgumentMatchInfo other)
		{
			return other != null && (this == other || (other.Index == this.Index && object.Equals(other._argument, this._argument) && object.Equals(other._specification, this._specification)));
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00008A50 File Offset: 0x00006C50
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(ArgumentMatchInfo)) && this.Equals((ArgumentMatchInfo)obj)));
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00008A82 File Offset: 0x00006C82
		public override int GetHashCode()
		{
			return (this.Index * 397 ^ ((this._argument != null) ? this._argument.GetHashCode() : 0)) * 397 ^ this._specification.GetHashCode();
		}

		// Token: 0x040000F8 RID: 248
		[Nullable(2)]
		private readonly object _argument;

		// Token: 0x040000F9 RID: 249
		private readonly IArgumentSpecification _specification;
	}
}
