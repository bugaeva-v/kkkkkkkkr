using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000CF RID: 207
	public class ArgumentSpecificationCompatibilityTester : IArgumentSpecificationCompatibilityTester
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00008C87 File Offset: 0x00006E87
		public ArgumentSpecificationCompatibilityTester(IDefaultChecker defaultChecker)
		{
			this._defaultChecker = defaultChecker;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00008C98 File Offset: 0x00006E98
		public bool IsSpecificationCompatible(IArgumentSpecification specification, [Nullable(2)] object argumentValue, Type argumentType)
		{
			Type forType = specification.ForType;
			return this.AreTypesCompatible(argumentType, forType) && this.IsProvidedArgumentTheOneWeWouldGetUsingAnArgSpecForThisType(argumentValue, forType);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00008CC0 File Offset: 0x00006EC0
		private bool IsProvidedArgumentTheOneWeWouldGetUsingAnArgSpecForThisType([Nullable(2)] object argument, Type typeArgSpecIsFor)
		{
			return this._defaultChecker.IsDefault(argument, typeArgSpecIsFor);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00008CCF File Offset: 0x00006ECF
		private bool AreTypesCompatible(Type argumentType, Type typeArgSpecIsFor)
		{
			return argumentType.IsAssignableFrom(typeArgSpecIsFor) || (argumentType.IsByRef && !typeArgSpecIsFor.IsByRef && argumentType.IsAssignableFrom(typeArgSpecIsFor.MakeByRefType()));
		}

		// Token: 0x040000FF RID: 255
		private readonly IDefaultChecker _defaultChecker;
	}
}
