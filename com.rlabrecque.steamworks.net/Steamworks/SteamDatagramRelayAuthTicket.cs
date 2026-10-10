using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020001E4 RID: 484
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamDatagramRelayAuthTicket
	{
		// Token: 0x06002406 RID: 9222 RVA: 0x0000853E File Offset: 0x0000673E
		public void IJHHMHAEKKE()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0000853E File Offset: 0x0000673E
		public void CIJOPFKKMHP()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0000853E File Offset: 0x0000673E
		public void IDDJFIPGMLB()
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0000853E File Offset: 0x0000673E
		public void KBJIDKPCPEF()
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0000853E File Offset: 0x0000673E
		public void EFOJGIPBLNK()
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0000853E File Offset: 0x0000673E
		public void KBLOMGCDLNP()
		{
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0000853E File Offset: 0x0000673E
		public void APKPCLGNLGA()
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0000853E File Offset: 0x0000673E
		public void HNEKAIMOIAI()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0000853E File Offset: 0x0000673E
		public void GGJHLGMPIAB()
		{
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0000853E File Offset: 0x0000673E
		public void FHGPFMKDEME()
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0000853E File Offset: 0x0000673E
		public void PAIAKPNIBAP()
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0000853E File Offset: 0x0000673E
		public void PBMLMLGPPEL()
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0000853E File Offset: 0x0000673E
		public void CGAFKIFKFGK()
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0000853E File Offset: 0x0000673E
		public void KKMFNHIDHKA()
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0000853E File Offset: 0x0000673E
		public void BDFBJELNMEN()
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0000853E File Offset: 0x0000673E
		public void GGBEOMKPJFA()
		{
		}

		// Token: 0x04000ACA RID: 2762
		private SteamNetworkingIdentity m_identityGameserver;

		// Token: 0x04000ACB RID: 2763
		private SteamNetworkingIdentity m_identityAuthorizedClient;

		// Token: 0x04000ACC RID: 2764
		private uint m_unPublicIP;

		// Token: 0x04000ACD RID: 2765
		private RTime32 m_rtimeTicketExpiry;

		// Token: 0x04000ACE RID: 2766
		private SteamDatagramHostedAddress m_routing;

		// Token: 0x04000ACF RID: 2767
		private uint m_nAppID;

		// Token: 0x04000AD0 RID: 2768
		private int m_nRestrictToVirtualPort;

		// Token: 0x04000AD1 RID: 2769
		private const int k_nMaxExtraFields = 16;

		// Token: 0x04000AD2 RID: 2770
		private int m_nExtraFields;

		// Token: 0x04000AD3 RID: 2771
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		private SteamDatagramRelayAuthTicket.PHEDCKJEDNE[] m_vecExtraFields;

		// Token: 0x020001E5 RID: 485
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		private struct PHEDCKJEDNE
		{
			// Token: 0x04000AD4 RID: 2772
			private SteamDatagramRelayAuthTicket.PHEDCKJEDNE.FHCEFFGBDEA KPOGEGECAPD;

			// Token: 0x04000AD5 RID: 2773
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
			private byte[] KNIJGALGECC;

			// Token: 0x04000AD6 RID: 2774
			private SteamDatagramRelayAuthTicket.PHEDCKJEDNE.CNCGHEBNJGF GDIOAAMEDGH;

			// Token: 0x020001E6 RID: 486
			private enum FHCEFFGBDEA
			{
				// Token: 0x04000AD8 RID: 2776
				k_EType_String,
				// Token: 0x04000AD9 RID: 2777
				k_EType_Int,
				// Token: 0x04000ADA RID: 2778
				k_EType_Fixed64
			}

			// Token: 0x020001E7 RID: 487
			[StructLayout(LayoutKind.Explicit)]
			private struct CNCGHEBNJGF
			{
				// Token: 0x04000ADB RID: 2779
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
				private byte[] PGONHHPKCHG;

				// Token: 0x04000ADC RID: 2780
				[FieldOffset(0)]
				private long AIGAMELMPAO;

				// Token: 0x04000ADD RID: 2781
				[FieldOffset(0)]
				private ulong BINCOOJOJIB;
			}
		}
	}
}
