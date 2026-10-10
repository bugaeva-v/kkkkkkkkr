using System;
using System.Collections.Generic;
using System.Linq;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200005D RID: 93
	public class RedundantArgumentMatcherException : SubstituteException
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00004C98 File Offset: 0x00002E98
		public RedundantArgumentMatcherException(IEnumerable<IArgumentSpecification> remainingSpecifications, IEnumerable<IArgumentSpecification> allSpecifications) : this(RedundantArgumentMatcherException.FormatErrorMessage(remainingSpecifications, allSpecifications))
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public RedundantArgumentMatcherException(string message) : base(message)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004CB0 File Offset: 0x00002EB0
		private static string FormatErrorMessage(IEnumerable<IArgumentSpecification> remainingSpecifications, IEnumerable<IArgumentSpecification> allSpecifications)
		{
			return string.Concat(new string[]
			{
				"Some argument specifications (e.g. Arg.Is, Arg.Any) were left over after the last call.",
				Environment.NewLine,
				Environment.NewLine,
				"This is often caused by using an argument spec with a call to a member NSubstitute does not handle (such as a non-virtual member or a call to an instance which is not a substitute), or for a purpose other than specifying a call (such as using an arg spec as a return value). For example:",
				Environment.NewLine,
				Environment.NewLine,
				"    var sub = Substitute.For<SomeClass>();",
				Environment.NewLine,
				"    var realType = new MyRealType(sub);",
				Environment.NewLine,
				"    // INCORRECT, arg spec used on realType, not a substitute:",
				Environment.NewLine,
				"    realType.SomeMethod(Arg.Any<int>()).Returns(2);",
				Environment.NewLine,
				"    // INCORRECT, arg spec used as a return value, not to specify a call:",
				Environment.NewLine,
				"    sub.VirtualMethod(2).Returns(Arg.Any<int>());",
				Environment.NewLine,
				"    // INCORRECT, arg spec used with a non-virtual method:",
				Environment.NewLine,
				"    sub.NonVirtualMethod(Arg.Any<int>()).Returns(2);",
				Environment.NewLine,
				"    // CORRECT, arg spec used to specify virtual call on a substitute:",
				Environment.NewLine,
				"    sub.VirtualMethod(Arg.Any<int>()).Returns(2);",
				Environment.NewLine,
				Environment.NewLine,
				"To fix this make sure you only use argument specifications with calls to substitutes. If your substitute is a class, make sure the member is virtual.",
				Environment.NewLine,
				Environment.NewLine,
				"Another possible cause is that the argument spec type does not match the actual argument type, but code compiles due to an implicit cast. For example, Arg.Any<int>() was used, but Arg.Any<double>() was required.",
				Environment.NewLine,
				Environment.NewLine,
				"NOTE: the cause of this exception can be in a previously executed test. Use the diagnostics below to see the types of any redundant arg specs, then work out where they are being created.",
				Environment.NewLine,
				Environment.NewLine,
				"Diagnostic information:",
				Environment.NewLine,
				Environment.NewLine,
				"Remaining (non-bound) argument specifications:",
				Environment.NewLine,
				RedundantArgumentMatcherException.FormatSpecifications(remainingSpecifications),
				Environment.NewLine,
				Environment.NewLine,
				"All argument specifications:",
				Environment.NewLine,
				RedundantArgumentMatcherException.FormatSpecifications(allSpecifications),
				Environment.NewLine
			});
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004E72 File Offset: 0x00003072
		private static string FormatSpecifications(IEnumerable<IArgumentSpecification> specifications)
		{
			return string.Join(Environment.NewLine, from spec in specifications
			select "    " + spec.ToString());
		}
	}
}
