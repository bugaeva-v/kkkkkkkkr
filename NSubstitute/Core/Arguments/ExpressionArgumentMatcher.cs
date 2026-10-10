using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D5 RID: 213
	public class ExpressionArgumentMatcher<T> : IArgumentMatcher
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000917D File Offset: 0x0000737D
		public ExpressionArgumentMatcher([Nullable(new byte[]
		{
			0,
			0,
			2
		})] Expression<Predicate<T>> predicate)
		{
			this._predicate = predicate.Compile();
			this._predicateDescription = predicate.ToString();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000919D File Offset: 0x0000739D
		[NullableContext(2)]
		public bool IsSatisfiedBy(object argument)
		{
			return this._predicate((T)((object)argument));
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000091B0 File Offset: 0x000073B0
		public override string ToString()
		{
			return this._predicateDescription;
		}

		// Token: 0x04000105 RID: 261
		private readonly string _predicateDescription;

		// Token: 0x04000106 RID: 262
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private readonly Predicate<T> _predicate;
	}
}
