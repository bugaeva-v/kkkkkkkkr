using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CA RID: 202
	public class AnyArgumentMatcher : IArgumentMatcher
	{
		// Token: 0x06000352 RID: 850 RVA: 0x000087B3 File Offset: 0x000069B3
		public AnyArgumentMatcher(Type typeArgMustBeCompatibleWith)
		{
			this._typeArgMustBeCompatibleWith = typeArgMustBeCompatibleWith;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000087C2 File Offset: 0x000069C2
		public override string ToString()
		{
			return "any " + this._typeArgMustBeCompatibleWith.GetNonMangledTypeName();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000087D9 File Offset: 0x000069D9
		[NullableContext(2)]
		public bool IsSatisfiedBy(object argument)
		{
			return argument.IsCompatibleWith(this._typeArgMustBeCompatibleWith);
		}

		// Token: 0x040000F6 RID: 246
		private readonly Type _typeArgMustBeCompatibleWith;
	}
}
