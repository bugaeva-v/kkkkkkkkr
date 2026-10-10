using System;
using System.Diagnostics;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001B0 RID: 432
	public static class Try
	{
		// Token: 0x06000D2D RID: 3373 RVA: 0x0001FD79 File Offset: 0x0001DF79
		[DebuggerHidden]
		public static bool Failure<T>(out T result)
		{
			result = default(T);
			return false;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0001FD83 File Offset: 0x0001DF83
		[DebuggerHidden]
		public static bool Success<T>(out T result, T value)
		{
			result = value;
			return true;
		}
	}
}
