using System;

namespace Steamworks
{
	// Token: 0x0200011A RID: 282
	[Serializable]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		// Token: 0x06001733 RID: 5939 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public CGameID(AppId_t MINMIFBPLGA, uint PGOAGOPNEKA)
		{
			this.m_GameID = 0UL;
			this.GOEGMEDMGGG(MINMIFBPLGA);
			this.GMEPENFCEFJ(CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod);
			this.OMKKADBLPMK(PGOAGOPNEKA);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000113FF File Offset: 0x0000F5FF
		public CGameID(AppId_t MINMIFBPLGA)
		{
			this.m_GameID = 0UL;
			this.GOEGMEDMGGG(MINMIFBPLGA);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00011410 File Offset: 0x0000F610
		public bool LNEJDCOLNLE()
		{
			return this.MCLLMGBKCJK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0001141B File Offset: 0x0000F61B
		public AppId_t HIHFBBELAAN()
		{
			return new AppId_t((uint)(this.m_GameID & 16777215UL));
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00011430 File Offset: 0x0000F630
		public bool HJMLEBEHMFA(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong JMOHKKGFEAB(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00011448 File Offset: 0x0000F648
		public uint FFBOCNNFPJN()
		{
			return (uint)(this.m_GameID >> 86 & (ulong)-1);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00011457 File Offset: 0x0000F657
		public void IBGLFMNHBLB()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00011461 File Offset: 0x0000F661
		public uint FMOKNFFIKAP()
		{
			return (uint)(this.m_GameID >> -117 & (ulong)-1);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID GADOGIBOENF(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00011478 File Offset: 0x0000F678
		public AppId_t PGPNMJBKFFJ()
		{
			return new AppId_t((uint)(this.m_GameID & 18446744073709551523UL));
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0001148D File Offset: 0x0000F68D
		public CGameID.DLDFPDCAKDL KBALGHNOAGG()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> -82 & 57UL);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00011457 File Offset: 0x0000F657
		public void HFFIMPKFHLK()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000114A0 File Offset: 0x0000F6A0
		private void ALHLKBEENJN(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 115UL) | ((ulong)AppId_t.JHKPJDENLLN(LNBMEILJKDH) & 46UL));
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000114C4 File Offset: 0x0000F6C4
		public bool PEPMFKHMOEB()
		{
			return this.MBLPAEDBHPK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00011457 File Offset: 0x0000F657
		public void OILOGLFPFNH()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void HOKNKJMPLHM(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00011430 File Offset: 0x0000F630
		public bool Equals(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000114D8 File Offset: 0x0000F6D8
		private void EJCPCPNMNGP(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << -43);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x000114F2 File Offset: 0x0000F6F2
		public bool JMNFFPBPKJN()
		{
			return this.KBALGHNOAGG() == (CGameID.DLDFPDCAKDL)6;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void LBACEBGDNKI(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00011457 File Offset: 0x0000F657
		public void LIHDKIEDMNL()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000114FD File Offset: 0x0000F6FD
		public CGameID.DLDFPDCAKDL HOBDLIANOBD()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> -54 & 179UL);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool MKGNKAMFMPG(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00011510 File Offset: 0x0000F710
		public bool KCOAJAELGHE()
		{
			return this.KBALGHNOAGG() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0001151B File Offset: 0x0000F71B
		public bool DABOBHAOILK()
		{
			return this.KCHAEHIAICF() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00011526 File Offset: 0x0000F726
		private void LMGIHJIJDCH(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << -82);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00011430 File Offset: 0x0000F630
		public bool PNKKPOCFHNF(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00011540 File Offset: 0x0000F740
		public void MIENOBNHGAL()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0001154A File Offset: 0x0000F74A
		private void KDGNDJNHBBP(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709549791UL) | (ulong)((ulong)((long)LNBMEILJKDH & -71L) << -68));
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0001156F File Offset: 0x0000F76F
		public uint CMLENDMJPMI()
		{
			return (uint)(this.m_GameID >> 32 & (ulong)-1);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0001157E File Offset: 0x0000F77E
		public AppId_t PLCNIBGJAJC()
		{
			return new AppId_t((uint)(this.m_GameID & 19UL));
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool JHDBIABDGLI(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00011540 File Offset: 0x0000F740
		public void OCNGKIHJKNE()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00011430 File Offset: 0x0000F630
		public bool IJMIHAGGAJM(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00011593 File Offset: 0x0000F793
		private void GMEPENFCEFJ(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744069431361535UL) | (ulong)((ulong)((long)LNBMEILJKDH & 255L) << 24));
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000115B8 File Offset: 0x0000F7B8
		public AppId_t LAAFAOOBLJK()
		{
			return new AppId_t((uint)(this.m_GameID & 18446744073709551598UL));
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000115CD File Offset: 0x0000F7CD
		public bool PAAFMAPILHB()
		{
			return this.EIFCNHFBAFL() == CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public CGameID.DLDFPDCAKDL EIFCNHFBAFL()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> 24 & 255UL);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00011457 File Offset: 0x0000F657
		public void KJFHKKJKOAF()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00011430 File Offset: 0x0000F630
		public bool JNNNFNFJBGE(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00011540 File Offset: 0x0000F740
		public void EHMFPHPKMFI()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000115EB File Offset: 0x0000F7EB
		private void PNMEAKLCJIN(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709551458UL) | ((ulong)AppId_t.ECPEBBPPHMN(LNBMEILJKDH) & 5UL));
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0001160F File Offset: 0x0000F80F
		private void PMJCDJNAINF(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 1538UL) | (ulong)((ulong)((long)LNBMEILJKDH & 54L) << 32));
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00011634 File Offset: 0x0000F834
		public int AIHEGOOFIHD(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00011648 File Offset: 0x0000F848
		public bool KJEICJDKCKP()
		{
			switch (this.HOBDLIANOBD())
			{
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeApp:
				return AppId_t.NEFGNGBGAJI(this.EILDPPFDJMD(), AppId_t.Invalid);
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod:
				return !AppId_t.NEFGNGBGAJI(this.PGPNMJBKFFJ(), AppId_t.Invalid) || (this.FFBOCNNFPJN() & 139U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut:
				return (this.FFBOCNNFPJN() & 4294967223U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P:
				return AppId_t.KJIGDINCECD(this.EILDPPFDJMD(), AppId_t.Invalid) && (this.PIKEINBHGAN() & 7U) > 0U;
			default:
				return true;
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000116DE File Offset: 0x0000F8DE
		public bool OGKKHBENGNI()
		{
			return this.GDCENLHPHEK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000114CF File Offset: 0x0000F6CF
		public CGameID(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00011634 File Offset: 0x0000F834
		public int HAOIPBENBID(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000116E9 File Offset: 0x0000F8E9
		private void BHLHELLFFNE(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << -127);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong FLOCHBNBGOI(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000114C4 File Offset: 0x0000F6C4
		public bool ABGJBLELGBJ()
		{
			return this.MBLPAEDBHPK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00011634 File Offset: 0x0000F834
		public int FPGCPBNLBCL(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00011703 File Offset: 0x0000F903
		public uint NJBLILLLCJA()
		{
			return (uint)(this.m_GameID >> 63 & (ulong)-1);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00011712 File Offset: 0x0000F912
		private void GDPNPLICICC(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << 4);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID CJBLMHBFKIL(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool DDGCIIFCECG(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00011634 File Offset: 0x0000F834
		public int PMAHKAHHFFP(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000114F2 File Offset: 0x0000F6F2
		public bool HKIAFCHDLOE()
		{
			return this.KBALGHNOAGG() == (CGameID.DLDFPDCAKDL)6;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void KCPCDHOCOOE(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00011540 File Offset: 0x0000F740
		public void FKOAOJDFGPN()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0001172C File Offset: 0x0000F92C
		public static bool KOFDLJACFLM(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return CGameID.PEKPHJBBIGP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00011738 File Offset: 0x0000F938
		public static bool NEFGNGBGAJI(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return !CGameID.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00011744 File Offset: 0x0000F944
		public CGameID.DLDFPDCAKDL GDCENLHPHEK()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> 29 & 66UL);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00011757 File Offset: 0x0000F957
		public uint DOLAFNEHEMC()
		{
			return (uint)(this.m_GameID >> 117 & (ulong)-1);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00011766 File Offset: 0x0000F966
		public AppId_t AJAGPAOOPAF()
		{
			return new AppId_t((uint)(this.m_GameID & 97UL));
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0001177B File Offset: 0x0000F97B
		private void HACEAOAPAPI(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709551564UL) | ((ulong)AppId_t.JHKPJDENLLN(LNBMEILJKDH) & 18446744073709551486UL));
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0001179F File Offset: 0x0000F99F
		public CGameID.DLDFPDCAKDL MBLPAEDBHPK()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> 49 & 113UL);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000117B2 File Offset: 0x0000F9B2
		public bool IIAFMDOJNCH()
		{
			return this.EIFCNHFBAFL() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000117BD File Offset: 0x0000F9BD
		public bool NJHPILBHPME()
		{
			return this.EIFCNHFBAFL() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00011540 File Offset: 0x0000F740
		public void HFGHNGHKDOC()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000117C8 File Offset: 0x0000F9C8
		private void GOEGMEDMGGG(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073692774400UL) | ((ulong)AppId_t.PEAFCMBIENC(LNBMEILJKDH) & 16777215UL));
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00011430 File Offset: 0x0000F630
		public bool NEMCANGLGHM(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void ANOMOFIGODE(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000117EC File Offset: 0x0000F9EC
		public bool GOJKDEOMMII()
		{
			return this.KCHAEHIAICF() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void MCEIKFLGMNA(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void OMAHCDIJCFL(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000117F7 File Offset: 0x0000F9F7
		public bool BJODKNLEMJI()
		{
			return this.HOBDLIANOBD() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void EOCGGJFALCA(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong DJDKDNCPEIO(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00011430 File Offset: 0x0000F630
		public bool GMJHPNJJBLH(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00011802 File Offset: 0x0000FA02
		public bool PFNDGHBDKKN()
		{
			return this.HOBDLIANOBD() == CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0001180D File Offset: 0x0000FA0D
		public bool BJEGIIBAGAO()
		{
			return this.MBLPAEDBHPK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00011818 File Offset: 0x0000FA18
		public bool NOEBGLGGENH()
		{
			return this.JAKPPMINILO() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00011823 File Offset: 0x0000FA23
		public uint GLIOLNAEKOP()
		{
			return (uint)(this.m_GameID >> -121 & (ulong)-1);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00011832 File Offset: 0x0000FA32
		public bool LJKFLPBKJGE()
		{
			return this.HOBDLIANOBD() == CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00011634 File Offset: 0x0000F834
		public int CompareTo(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00011430 File Offset: 0x0000F630
		public bool BECNDLCCJPK(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000117EC File Offset: 0x0000F9EC
		public bool DGMCJEFAPDF()
		{
			return this.KCHAEHIAICF() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00011634 File Offset: 0x0000F834
		public int PKFDMPKMDEF(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong BNJHAOICCOF(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0001183D File Offset: 0x0000FA3D
		private void DNCLJOFDKCF(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709550399UL) | (ulong)((ulong)((long)LNBMEILJKDH & -90L) << 59));
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong PEAFCMBIENC(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00011862 File Offset: 0x0000FA62
		public override int GetHashCode()
		{
			return this.m_GameID.GetHashCode();
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0001186F File Offset: 0x0000FA6F
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is CGameID && CGameID.MKGNKAMFMPG(this, (CGameID)LNBMEILJKDH);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0001188C File Offset: 0x0000FA8C
		public uint PIKEINBHGAN()
		{
			return (uint)(this.m_GameID >> 14 & (ulong)-1);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00011430 File Offset: 0x0000F630
		public bool HABKJAINMKE(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0001189B File Offset: 0x0000FA9B
		public CGameID.DLDFPDCAKDL JAKPPMINILO()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> 83 & 182UL);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00011430 File Offset: 0x0000F630
		public bool MHGMNCNIPBF(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00011540 File Offset: 0x0000F740
		public void EPJKDCDOEMM()
		{
			this.m_GameID = 0UL;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000118B0 File Offset: 0x0000FAB0
		public bool JPLJBDLEPAL()
		{
			switch (this.GDCENLHPHEK())
			{
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeApp:
				return AppId_t.NPEKIIDAPNG(this.LAAFAOOBLJK(), AppId_t.Invalid);
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod:
				return AppId_t.IPHIKMKINFF(this.EILDPPFDJMD(), AppId_t.Invalid) && (this.NJBLILLLCJA() & 4294967109U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut:
				return (this.GLIOLNAEKOP() & 4294967174U) > 0U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P:
				return AppId_t.PEKPHJBBIGP(this.HIHFBBELAAN(), AppId_t.Invalid) && (this.NJBLILLLCJA() & 4294967132U) > 1U;
			default:
				return true;
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00011946 File Offset: 0x0000FB46
		public AppId_t EILDPPFDJMD()
		{
			return new AppId_t((uint)(this.m_GameID & 168UL));
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void BHGMEGKKFBI(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0001195B File Offset: 0x0000FB5B
		public uint BHKFILNHCJA()
		{
			return (uint)(this.m_GameID >> -44 & (ulong)-1);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0001196A File Offset: 0x0000FB6A
		private void HBFNHEJMMKO(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << 2);
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00011984 File Offset: 0x0000FB84
		public AppId_t PLOCENCEEKO()
		{
			return new AppId_t((uint)(this.m_GameID & 18446744073709551545UL));
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00011999 File Offset: 0x0000FB99
		private void LBMEOGFMAFD(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << 106);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void KAOHKLHGNHK(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool KJIGDINCECD(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000119B3 File Offset: 0x0000FBB3
		private void KNJPHLHCPAM(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 990UL) | (ulong)((ulong)((long)LNBMEILJKDH & 33L) << -25));
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool BAEHHPLAADE(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000119D8 File Offset: 0x0000FBD8
		public bool FFMLFGJNCIA()
		{
			switch (this.JAKPPMINILO())
			{
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeApp:
				return AppId_t.OINOBHGJEJK(this.HIHFBBELAAN(), AppId_t.Invalid);
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod:
				return AppId_t.IMGNFFLCCIG(this.PGPNMJBKFFJ(), AppId_t.Invalid) && (this.DOLAFNEHEMC() & 13U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut:
				return (this.FFBOCNNFPJN() & 4294967127U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P:
				return !AppId_t.POOPLDLDIEE(this.PLOCENCEEKO(), AppId_t.Invalid) || (this.BHKFILNHCJA() & 151U) > 1U;
			default:
				return false;
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00011430 File Offset: 0x0000F630
		public bool GFPAGHPGHHG(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00011457 File Offset: 0x0000F657
		public void JDPKNGACIJL()
		{
			this.m_GameID = 1UL;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00011A6E File Offset: 0x0000FC6E
		public bool FNCMNCPBJGE()
		{
			return this.EIFCNHFBAFL() == (CGameID.DLDFPDCAKDL)6;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00011A79 File Offset: 0x0000FC79
		private void BPEEPPEAMBG(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << -78);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00011A93 File Offset: 0x0000FC93
		private void ADJBPMIOKGD(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709551471UL) | ((ulong)AppId_t.BDDFEOKMDML(LNBMEILJKDH) & 50UL));
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00011AB7 File Offset: 0x0000FCB7
		public bool ILHGCLOEGFF()
		{
			return this.KBALGHNOAGG() == (CGameID.DLDFPDCAKDL)8;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00011AC2 File Offset: 0x0000FCC2
		private void KNPLGJJDDMC(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709551544UL) | ((ulong)AppId_t.MEIBALKJPLN(LNBMEILJKDH) & 18446744073709551605UL));
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool PEKPHJBBIGP(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public static bool FHPJKFKOHNH(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return !CGameID.OCHCFNHCCJB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00011AF2 File Offset: 0x0000FCF2
		private void KNBIJDAJODN(AppId_t LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709551556UL) | ((ulong)AppId_t.JHKPJDENLLN(LNBMEILJKDH) & 18446744073709551555UL));
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00011634 File Offset: 0x0000F834
		public int HKEHBKBHHJN(CGameID LNBMEILJKDH)
		{
			return this.m_GameID.CompareTo(LNBMEILJKDH.m_GameID);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00011B16 File Offset: 0x0000FD16
		public CGameID.DLDFPDCAKDL KCHAEHIAICF()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> -86 & 19UL);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00011B29 File Offset: 0x0000FD29
		public CGameID.DLDFPDCAKDL FFMAFPIEKGI()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> -20 & 183UL);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00011B3C File Offset: 0x0000FD3C
		public CGameID.DLDFPDCAKDL MCLLMGBKCJK()
		{
			return (CGameID.DLDFPDCAKDL)(this.m_GameID >> -38 & 198UL);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00011B4F File Offset: 0x0000FD4F
		public bool ACJCBBFPHOO()
		{
			return this.GDCENLHPHEK() == (CGameID.DLDFPDCAKDL)5;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool OCHCFNHCCJB(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00011B5A File Offset: 0x0000FD5A
		private void OMKKADBLPMK(uint LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & (ulong)-1) | ((ulong)LNBMEILJKDH & (ulong)-1) << 32);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00011B74 File Offset: 0x0000FD74
		public bool OGCKGIHOBMM()
		{
			return this.KCHAEHIAICF() == (CGameID.DLDFPDCAKDL)4;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00011B7F File Offset: 0x0000FD7F
		public static bool ACHMHFAOKEL(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return !CGameID.KJIGDINCECD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID LLOCKDHOJBG(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID PJCFLLGPNKB(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00011430 File Offset: 0x0000F630
		public bool MFHMLODHJGH(CGameID LNBMEILJKDH)
		{
			return this.m_GameID == LNBMEILJKDH.m_GameID;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00011470 File Offset: 0x0000F670
		public static CGameID PHMJDDKEANM(ulong AJLPALFJHCC)
		{
			return new CGameID(AJLPALFJHCC);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00011B8B File Offset: 0x0000FD8B
		public AppId_t MJFEKPKFBKD()
		{
			return new AppId_t((uint)(this.m_GameID & 18446744073709551600UL));
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void GKNIOCJPLOK(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		public bool ICDAKGIGDIF()
		{
			return this.FFMAFPIEKGI() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong HGIOFALCHCO(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00011BAB File Offset: 0x0000FDAB
		private void DIBOPCIONKI(CGameID.DLDFPDCAKDL LNBMEILJKDH)
		{
			this.m_GameID = ((this.m_GameID & 18446744073709549750UL) | (ulong)((ulong)((long)LNBMEILJKDH & 129L) << -106));
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		public bool FDGKBHMGDFP()
		{
			return this.JAKPPMINILO() == (CGameID.DLDFPDCAKDL)4;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000114CF File Offset: 0x0000F6CF
		public void BNEOPFCMJOK(ulong MNCIDFKGFFH)
		{
			this.m_GameID = MNCIDFKGFFH;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00011BDB File Offset: 0x0000FDDB
		public bool CPPFHKNMJJM()
		{
			return this.EIFCNHFBAFL() == CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public bool MICFMAKOJLO()
		{
			switch (this.MCLLMGBKCJK())
			{
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeApp:
				return AppId_t.IPHIKMKINFF(this.AJAGPAOOPAF(), AppId_t.Invalid);
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod:
				return AppId_t.NPEKIIDAPNG(this.EILDPPFDJMD(), AppId_t.Invalid) && (this.PIKEINBHGAN() & 79U) > 0U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut:
				return (this.PIKEINBHGAN() & 0U) > 1U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P:
				return AppId_t.NFDGMMCNNMN(this.PLCNIBGJAJC(), AppId_t.Invalid) && (this.BHKFILNHCJA() & 18U) > 0U;
			default:
				return false;
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00011C7E File Offset: 0x0000FE7E
		public override string ToString()
		{
			return this.m_GameID.ToString();
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00011C8C File Offset: 0x0000FE8C
		public bool INEKFCLBCAB()
		{
			switch (this.EIFCNHFBAFL())
			{
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeApp:
				return AppId_t.NEFGNGBGAJI(this.HIHFBBELAAN(), AppId_t.Invalid);
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeGameMod:
				return AppId_t.NEFGNGBGAJI(this.HIHFBBELAAN(), AppId_t.Invalid) && (this.CMLENDMJPMI() & 2147483648U) > 0U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeShortcut:
				return (this.CMLENDMJPMI() & 2147483648U) > 0U;
			case CGameID.DLDFPDCAKDL.k_EGameIDTypeP2P:
				return AppId_t.MKGNKAMFMPG(this.HIHFBBELAAN(), AppId_t.Invalid) && (this.CMLENDMJPMI() & 2147483648U) > 0U;
			default:
				return false;
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool INFBAPFOEAG(CGameID OBNBCGOIMKE, CGameID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_GameID == DEJFBNMNMOK.m_GameID;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00011D22 File Offset: 0x0000FF22
		public bool JFDGKOIMLGO()
		{
			return this.GDCENLHPHEK() == CGameID.DLDFPDCAKDL.k_EGameIDTypeApp;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00011440 File Offset: 0x0000F640
		public static ulong DLCBJEFIHLI(CGameID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_GameID;
		}

		// Token: 0x04000772 RID: 1906
		public ulong m_GameID;

		// Token: 0x0200011B RID: 283
		public enum DLDFPDCAKDL
		{
			// Token: 0x04000774 RID: 1908
			k_EGameIDTypeApp,
			// Token: 0x04000775 RID: 1909
			k_EGameIDTypeGameMod,
			// Token: 0x04000776 RID: 1910
			k_EGameIDTypeShortcut,
			// Token: 0x04000777 RID: 1911
			k_EGameIDTypeP2P
		}
	}
}
