using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000250 RID: 592
	[VisibleToOtherModules]
	internal class SystemClock
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00029908 File Offset: 0x00027B08
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00029920 File Offset: 0x00027B20
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00029950 File Offset: 0x00027B50
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x04000878 RID: 2168
		private static readonly DateTime s_Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}
