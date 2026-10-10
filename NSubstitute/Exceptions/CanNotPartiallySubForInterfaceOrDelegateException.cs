using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000050 RID: 80
	public class CanNotPartiallySubForInterfaceOrDelegateException : SubstituteException
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00004B36 File Offset: 0x00002D36
		public CanNotPartiallySubForInterfaceOrDelegateException(Type type) : base(CanNotPartiallySubForInterfaceOrDelegateException.DescribeProblem(type))
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004B44 File Offset: 0x00002D44
		private static string DescribeProblem(Type type)
		{
			return string.Format("Can only substitute for parts of classes, not interfaces or delegates. Try `Substitute.For<{0}> instead.", type.Name);
		}
	}
}
