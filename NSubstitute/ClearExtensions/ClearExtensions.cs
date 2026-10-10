using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.ClearExtensions
{
	// Token: 0x02000049 RID: 73
	public static class ClearExtensions
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00004838 File Offset: 0x00002A38
		public static void ClearSubstitute<T>(this T substitute, ClearOptions options = ClearOptions.All) where T : class
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			SubstitutionContext.Current.GetCallRouterFor(substitute).Clear(options);
		}
	}
}
