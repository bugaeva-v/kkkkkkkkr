using System;

namespace Steamworks
{
	// Token: 0x02000078 RID: 120
	internal static class FAIABBGHMEG
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x00009775 File Offset: 0x00007975
		internal static IntPtr IKCGBLEEBPM()
		{
			return FAIABBGHMEG.CHLOKBBAEHM;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000977C File Offset: 0x0000797C
		internal static IntPtr KOKJBCEEIHP()
		{
			return FAIABBGHMEG.MKLHEJEPPOL;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00009783 File Offset: 0x00007983
		internal static IntPtr EEFKKJONBFF()
		{
			return FAIABBGHMEG.IJAFCOGLEKE;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000978A File Offset: 0x0000798A
		internal static IntPtr BIJAMBEBGIF()
		{
			return FAIABBGHMEG.AFNFMEKICHD;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00009791 File Offset: 0x00007991
		internal static IntPtr PNNCGKIILKG()
		{
			return FAIABBGHMEG.NGFEOKDHFAC;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00009798 File Offset: 0x00007998
		internal static IntPtr BEAOFCFMDFM()
		{
			return FAIABBGHMEG.PHMKBJBOOMI;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0000979F File Offset: 0x0000799F
		internal static IntPtr GIMLBKCFKFF()
		{
			return FAIABBGHMEG.PMPIKJEHMII;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000097A6 File Offset: 0x000079A6
		internal static IntPtr GCMCMNFLNPA()
		{
			return FAIABBGHMEG.OGJPLCDNFLL;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000097AD File Offset: 0x000079AD
		internal static IntPtr HNIANGLAAAN()
		{
			return FAIABBGHMEG.MICHLAOLMPP;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000097B4 File Offset: 0x000079B4
		internal static IntPtr NEIJLAHKDNM()
		{
			return FAIABBGHMEG.MNDILEPOKMN;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000097BC File Offset: 0x000079BC
		internal static void IJHHMHAEKKE()
		{
			FAIABBGHMEG.MNDILEPOKMN = IntPtr.Zero;
			FAIABBGHMEG.CHLOKBBAEHM = IntPtr.Zero;
			FAIABBGHMEG.MICHLAOLMPP = IntPtr.Zero;
			FAIABBGHMEG.NGFEOKDHFAC = IntPtr.Zero;
			FAIABBGHMEG.MKLHEJEPPOL = IntPtr.Zero;
			FAIABBGHMEG.IJAFCOGLEKE = IntPtr.Zero;
			FAIABBGHMEG.HELLFJHGCBP = IntPtr.Zero;
			FAIABBGHMEG.OGJPLCDNFLL = IntPtr.Zero;
			FAIABBGHMEG.PHMKBJBOOMI = IntPtr.Zero;
			FAIABBGHMEG.PMPIKJEHMII = IntPtr.Zero;
			FAIABBGHMEG.AFNFMEKICHD = IntPtr.Zero;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00009837 File Offset: 0x00007A37
		internal static IntPtr CMNGOOGEDBM()
		{
			return FAIABBGHMEG.HELLFJHGCBP;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00009840 File Offset: 0x00007A40
		internal static bool GLFBHMMGHGL()
		{
			HSteamUser hsteamUser = IOCDIMGCAFH.FLEBHODMECH();
			HSteamPipe hsteamPipe = IOCDIMGCAFH.DBGFFILDPMH();
			if (HSteamPipe.MKGNKAMFMPG(hsteamPipe, HSteamPipe.PEAFCMBIENC(0)))
			{
				return false;
			}
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI("SteamClient020"))
			{
				FAIABBGHMEG.MNDILEPOKMN = IPBEAECLPOJ.NPHIMOLOODA(ljanjdbdbji);
			}
			if (FAIABBGHMEG.MNDILEPOKMN == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.CHLOKBBAEHM = AAJGGBGJOMA.BDDMPCMJKJN(hsteamUser, hsteamPipe, "SteamGameServer014");
			if (FAIABBGHMEG.CHLOKBBAEHM == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.MICHLAOLMPP = AAJGGBGJOMA.NECGBIGKOMO(hsteamPipe, "SteamUtils010");
			if (FAIABBGHMEG.MICHLAOLMPP == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.NGFEOKDHFAC = AAJGGBGJOMA.LJOLPNKFECB(hsteamUser, hsteamPipe, "SteamNetworking006");
			if (FAIABBGHMEG.NGFEOKDHFAC == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.MKLHEJEPPOL = AAJGGBGJOMA.OMIJLPMJOEO(hsteamUser, hsteamPipe, "SteamGameServerStats001");
			if (FAIABBGHMEG.MKLHEJEPPOL == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.IJAFCOGLEKE = AAJGGBGJOMA.CNKJGBMHIHG(hsteamUser, hsteamPipe, "STEAMHTTP_INTERFACE_VERSION003");
			if (FAIABBGHMEG.IJAFCOGLEKE == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.HELLFJHGCBP = AAJGGBGJOMA.DNBNOADCCIL(hsteamUser, hsteamPipe, "STEAMINVENTORY_INTERFACE_V003");
			if (FAIABBGHMEG.HELLFJHGCBP == IntPtr.Zero)
			{
				return false;
			}
			FAIABBGHMEG.OGJPLCDNFLL = AAJGGBGJOMA.NKNNIMJCDPD(hsteamUser, hsteamPipe, "STEAMUGC_INTERFACE_VERSION016");
			if (FAIABBGHMEG.OGJPLCDNFLL == IntPtr.Zero)
			{
				return false;
			}
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji2 = new MBLFNIBGODG.LJANJDBDBJI("SteamNetworkingUtils004"))
			{
				FAIABBGHMEG.PHMKBJBOOMI = ((IPBEAECLPOJ.NHMHKBOCGDI(hsteamUser, ljanjdbdbji2) != IntPtr.Zero) ? IPBEAECLPOJ.NHMHKBOCGDI(hsteamUser, ljanjdbdbji2) : IPBEAECLPOJ.CIOEELDKKDI(hsteamUser, ljanjdbdbji2));
			}
			if (FAIABBGHMEG.PHMKBJBOOMI == IntPtr.Zero)
			{
				return false;
			}
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji3 = new MBLFNIBGODG.LJANJDBDBJI("SteamNetworkingSockets012"))
			{
				FAIABBGHMEG.PMPIKJEHMII = IPBEAECLPOJ.CIOEELDKKDI(hsteamUser, ljanjdbdbji3);
			}
			if (FAIABBGHMEG.PMPIKJEHMII == IntPtr.Zero)
			{
				return false;
			}
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji4 = new MBLFNIBGODG.LJANJDBDBJI("SteamNetworkingMessages002"))
			{
				FAIABBGHMEG.AFNFMEKICHD = IPBEAECLPOJ.CIOEELDKKDI(hsteamUser, ljanjdbdbji4);
			}
			return !(FAIABBGHMEG.AFNFMEKICHD == IntPtr.Zero);
		}

		// Token: 0x0400033E RID: 830
		private static IntPtr MNDILEPOKMN;

		// Token: 0x0400033F RID: 831
		private static IntPtr CHLOKBBAEHM;

		// Token: 0x04000340 RID: 832
		private static IntPtr MICHLAOLMPP;

		// Token: 0x04000341 RID: 833
		private static IntPtr NGFEOKDHFAC;

		// Token: 0x04000342 RID: 834
		private static IntPtr MKLHEJEPPOL;

		// Token: 0x04000343 RID: 835
		private static IntPtr IJAFCOGLEKE;

		// Token: 0x04000344 RID: 836
		private static IntPtr HELLFJHGCBP;

		// Token: 0x04000345 RID: 837
		private static IntPtr OGJPLCDNFLL;

		// Token: 0x04000346 RID: 838
		private static IntPtr PHMKBJBOOMI;

		// Token: 0x04000347 RID: 839
		private static IntPtr PMPIKJEHMII;

		// Token: 0x04000348 RID: 840
		private static IntPtr AFNFMEKICHD;
	}
}
