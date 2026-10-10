using System;

namespace NSubstitute.Core
{
	// Token: 0x020000A7 RID: 167
	public static class Maybe
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00006B97 File Offset: 0x00004D97
		public static Maybe<T> Just<T>(T value)
		{
			return new Maybe<T>(value);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public static Maybe<T> Nothing<T>()
		{
			return default(Maybe<T>);
		}
	}
}
