using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000060 RID: 96
	public class UnexpectedArgumentMatcherException : SubstituteException
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00004EEF File Offset: 0x000030EF
		public UnexpectedArgumentMatcherException() : this(UnexpectedArgumentMatcherException.WhatProbablyWentWrong)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004EFC File Offset: 0x000030FC
		public UnexpectedArgumentMatcherException(string message) : base(message)
		{
		}

		// Token: 0x04000067 RID: 103
		public static readonly string WhatProbablyWentWrong = string.Concat(new string[]
		{
			"Argument matchers (Arg.Is, Arg.Any) should only be used in place of member arguments. Do not use in a Returns() statement or anywhere else outside of a member call.",
			Environment.NewLine,
			"Correct use:",
			Environment.NewLine,
			"  sub.MyMethod(Arg.Any<string>()).Returns(\"hi\")",
			Environment.NewLine,
			"Incorrect use:",
			Environment.NewLine,
			"  sub.MyMethod(\"hi\").Returns(Arg.Any<string>())"
		});
	}
}
