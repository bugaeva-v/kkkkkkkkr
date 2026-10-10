using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x02000095 RID: 149
	public struct EDELONALMAM
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0000A508 File Offset: 0x00008708
		private EDELONALMAM(string KCIFJJFFHAN, string BMJEPEJOKCC)
		{
			this.BKHAAEKJCIP = KCIFJJFFHAN;
			this.CPNPDHHGMNN = BMJEPEJOKCC;
		}

		// Token: 0x040003B0 RID: 944
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string BKHAAEKJCIP;

		// Token: 0x040003B1 RID: 945
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string CPNPDHHGMNN;
	}
}
