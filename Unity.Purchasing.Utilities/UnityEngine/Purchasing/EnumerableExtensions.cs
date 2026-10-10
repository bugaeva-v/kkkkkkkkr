using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000A RID: 10
	[NullableContext(1)]
	[Nullable(0)]
	internal static class EnumerableExtensions
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000216A File Offset: 0x0000036A
		public static IEnumerable<T> NonNull<[Nullable(2)] T>(this IEnumerable<T> enumerable)
		{
			return from obj in enumerable
			where obj != null
			select obj;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002191 File Offset: 0x00000391
		public static IEnumerable<T> IgnoreExceptions<[Nullable(2)] T, [Nullable(0)] TException>(this IEnumerable<T> enumerable, [Nullable(new byte[]
		{
			2,
			1
		})] Action<TException> onException = null) where TException : Exception
		{
			EnumerableExtensions.<IgnoreExceptions>d__1<T, TException> <IgnoreExceptions>d__ = new EnumerableExtensions.<IgnoreExceptions>d__1<T, TException>(-2);
			<IgnoreExceptions>d__.<>3__enumerable = enumerable;
			<IgnoreExceptions>d__.<>3__onException = onException;
			return <IgnoreExceptions>d__;
		}
	}
}
