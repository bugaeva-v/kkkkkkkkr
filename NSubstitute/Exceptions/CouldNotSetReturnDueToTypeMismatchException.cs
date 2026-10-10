using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000057 RID: 87
	public class CouldNotSetReturnDueToTypeMismatchException : CouldNotSetReturnException
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00004BC9 File Offset: 0x00002DC9
		public CouldNotSetReturnDueToTypeMismatchException([Nullable(2)] Type returnType, MethodInfo member) : base(CouldNotSetReturnDueToTypeMismatchException.DescribeProblem(returnType, member))
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004BD8 File Offset: 0x00002DD8
		private static string DescribeProblem([Nullable(2)] Type typeOfReturnValue, MethodInfo member)
		{
			if (!(typeOfReturnValue == null))
			{
				return string.Format("Can not return value of type {0} for {1}.{2} (expected type {3}).", new object[]
				{
					typeOfReturnValue.Name,
					member.DeclaringType.Name,
					member.Name,
					member.ReturnType.Name
				});
			}
			return string.Format("Can not return null for {0}.{1} (expected type {2}).", member.DeclaringType.Name, member.Name, member.ReturnType.Name);
		}
	}
}
