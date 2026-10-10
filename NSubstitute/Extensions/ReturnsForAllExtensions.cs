using System;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Extensions
{
	// Token: 0x02000048 RID: 72
	public static class ReturnsForAllExtensions
	{
		// Token: 0x06000106 RID: 262 RVA: 0x000047DD File Offset: 0x000029DD
		public static void ReturnsForAll<T>(this object substitute, T returnThis)
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			SubstitutionContext.Current.GetCallRouterFor(substitute).SetReturnForType(typeof(T), new ReturnValue(returnThis));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000480D File Offset: 0x00002A0D
		public static void ReturnsForAll<T>(this object substitute, Func<CallInfo, T> returnThis)
		{
			if (substitute == null)
			{
				throw new NullSubstituteReferenceException();
			}
			SubstitutionContext.Current.GetCallRouterFor(substitute).SetReturnForType(typeof(T), new ReturnValueFromFunc<T>(returnThis));
		}
	}
}
