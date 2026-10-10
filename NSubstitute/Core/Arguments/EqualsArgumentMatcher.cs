using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D4 RID: 212
	public class EqualsArgumentMatcher : IArgumentMatcher
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00009148 File Offset: 0x00007348
		[NullableContext(2)]
		public EqualsArgumentMatcher(object value)
		{
			this._value = value;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00009157 File Offset: 0x00007357
		public override string ToString()
		{
			return ArgumentFormatter.Default.Format(this._value, false);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000916A File Offset: 0x0000736A
		[NullableContext(2)]
		public bool IsSatisfiedBy(object argument)
		{
			return EqualityComparer<object>.Default.Equals(this._value, argument);
		}

		// Token: 0x04000104 RID: 260
		[Nullable(2)]
		private readonly object _value;
	}
}
