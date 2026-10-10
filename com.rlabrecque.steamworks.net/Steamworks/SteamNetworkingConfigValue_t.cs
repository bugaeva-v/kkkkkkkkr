using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public struct SteamNetworkingConfigValue_t
	{
		// Token: 0x04000150 RID: 336
		public JHEBPHGLLMK m_eValue;

		// Token: 0x04000151 RID: 337
		public AIGCOFEJAIF m_eDataType;

		// Token: 0x04000152 RID: 338
		public SteamNetworkingConfigValue_t.CNCGHEBNJGF m_val;

		// Token: 0x02000026 RID: 38
		[StructLayout(LayoutKind.Explicit)]
		public struct CNCGHEBNJGF
		{
			// Token: 0x04000153 RID: 339
			[FieldOffset(0)]
			public int NIDAKPAIFEL;

			// Token: 0x04000154 RID: 340
			[FieldOffset(0)]
			public long NMNAGEGOHOD;

			// Token: 0x04000155 RID: 341
			[FieldOffset(0)]
			public float ILDGKMBIFAI;

			// Token: 0x04000156 RID: 342
			[FieldOffset(0)]
			public IntPtr DGGGHLONDDC;

			// Token: 0x04000157 RID: 343
			[FieldOffset(0)]
			public IntPtr GMLEPEBPEEA;
		}
	}
}
