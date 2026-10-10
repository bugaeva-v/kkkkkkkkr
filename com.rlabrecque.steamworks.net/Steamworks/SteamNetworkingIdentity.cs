using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020001A5 RID: 421
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
	{
		// Token: 0x06002144 RID: 8516 RVA: 0x0001668A File Offset: 0x0001488A
		public void LDIELJIIEMF(ulong EKCOJJGHNAN)
		{
			IPBEAECLPOJ.FMKJBCFAEFI(ref this, EKCOJJGHNAN);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00016694 File Offset: 0x00014894
		public bool GFILNEEIJDL(string OBJAIHPGOJN)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(OBJAIHPGOJN))
			{
				result = IPBEAECLPOJ.LOHCIIOIPPB(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000166D0 File Offset: 0x000148D0
		public void FHGPFMKDEME()
		{
			IPBEAECLPOJ.ALGGJPDHCFJ(ref this);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000166D8 File Offset: 0x000148D8
		public bool ONMNGMKMFPG(string MCOLDANPEJC)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(MCOLDANPEJC))
			{
				result = IPBEAECLPOJ.LMFDGOKPIIH(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00016714 File Offset: 0x00014914
		public bool FBBDPHDHNBN(byte[] GDAFFANBJED, uint DLPBEGLKBJL)
		{
			return IPBEAECLPOJ.ANBCNJLNGBB(ref this, GDAFFANBJED, DLPBEGLKBJL);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00016720 File Offset: 0x00014920
		public void MNGLNOFPAAH(out string CFHBIAJPGMC)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(-73);
			IPBEAECLPOJ.FBIAKMDLJLL(ref this, intPtr, 4294967204U);
			CFHBIAJPGMC = MBLFNIBGODG.IIHDLLEMLDA(intPtr);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00016752 File Offset: 0x00014952
		public void GDHMBAJBLAD()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0001675A File Offset: 0x0001495A
		public void BEIPKKHGGDF(uint KGLEJGCAGBD, ushort MLHPDILCKGP)
		{
			IPBEAECLPOJ.ICFOGIMLABN(ref this, KGLEJGCAGBD, MLHPDILCKGP);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00016752 File Offset: 0x00014952
		public void ECAHHGGAFDL()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00016714 File Offset: 0x00014914
		public bool JBEDMMLDDEE(byte[] GDAFFANBJED, uint DLPBEGLKBJL)
		{
			return IPBEAECLPOJ.ANBCNJLNGBB(ref this, GDAFFANBJED, DLPBEGLKBJL);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00016764 File Offset: 0x00014964
		public bool FJCLFOFKEIO()
		{
			return IPBEAECLPOJ.LPPFGPMNIHA(ref this);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0001676C File Offset: 0x0001496C
		public void IMBGFNEELHB(SteamNetworkingIPAddr KKFIELAEFFK)
		{
			IPBEAECLPOJ.AKKLLMAJAKF(ref this, ref KKFIELAEFFK);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00016778 File Offset: 0x00014978
		public void NKHFJMFHADI(out string CFHBIAJPGMC)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(131);
			IPBEAECLPOJ.FBIAKMDLJLL(ref this, intPtr, 4294967104U);
			CFHBIAJPGMC = MBLFNIBGODG.MBHIKEOMPOF(intPtr);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000167AA File Offset: 0x000149AA
		public bool PDEIGPLPAJC(SteamNetworkingIdentity OBNBCGOIMKE)
		{
			return IPBEAECLPOJ.OKOPENOKKJL(ref this, ref OBNBCGOIMKE);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000167B4 File Offset: 0x000149B4
		public HJNNPCJKHBP LCIHBOCPJNM()
		{
			return IPBEAECLPOJ.DADELMHCEBE(ref this);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00016752 File Offset: 0x00014952
		public void CHMEAKCGPHI()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0001668A File Offset: 0x0001488A
		public void HNGBABAKKFJ(ulong EKCOJJGHNAN)
		{
			IPBEAECLPOJ.FMKJBCFAEFI(ref this, EKCOJJGHNAN);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000167B4 File Offset: 0x000149B4
		public HJNNPCJKHBP HBNFEPFFGLH()
		{
			return IPBEAECLPOJ.DADELMHCEBE(ref this);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000167BC File Offset: 0x000149BC
		public bool PILONMANLPB()
		{
			return this.HBNFEPFFGLH() > HJNNPCJKHBP.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000167C8 File Offset: 0x000149C8
		public bool GEOBPEBIDFB(string OBJAIHPGOJN)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(OBJAIHPGOJN))
			{
				result = IPBEAECLPOJ.LOHCIIOIPPB(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00016804 File Offset: 0x00014A04
		public SteamNetworkingIPAddr KLIFHDODNPI()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000167AA File Offset: 0x000149AA
		public bool Equals(SteamNetworkingIdentity OBNBCGOIMKE)
		{
			return IPBEAECLPOJ.OKOPENOKKJL(ref this, ref OBNBCGOIMKE);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0001680C File Offset: 0x00014A0C
		public bool BKOKBHAIEDA(string MCOLDANPEJC)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(MCOLDANPEJC))
			{
				result = IPBEAECLPOJ.LMFDGOKPIIH(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00016848 File Offset: 0x00014A48
		public CSteamID HKFGPPOMEHB()
		{
			return CSteamID.PHDAOLLLEOA(IPBEAECLPOJ.KPEOFLFCICC(ref this));
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00016855 File Offset: 0x00014A55
		public bool IGHKAOCNNFL()
		{
			return this.HBNFEPFFGLH() > HJNNPCJKHBP.k_ESteamNetworkingFakeIPType_NotFake;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000166D0 File Offset: 0x000148D0
		public void IJHHMHAEKKE()
		{
			IPBEAECLPOJ.ALGGJPDHCFJ(ref this);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00016860 File Offset: 0x00014A60
		public bool OBBIJANEHNP()
		{
			return IPBEAECLPOJ.EKBIKMBBAJD(ref this);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00016804 File Offset: 0x00014A04
		public byte[] PCFJAILHBKF(out int DLPBEGLKBJL)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00016714 File Offset: 0x00014914
		public bool IOAJIDFKBNB(byte[] GDAFFANBJED, uint DLPBEGLKBJL)
		{
			return IPBEAECLPOJ.ANBCNJLNGBB(ref this, GDAFFANBJED, DLPBEGLKBJL);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00016860 File Offset: 0x00014A60
		public bool KGDANLJIKIC()
		{
			return IPBEAECLPOJ.EKBIKMBBAJD(ref this);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0001676C File Offset: 0x0001496C
		public void GOKAKCKFEMM(SteamNetworkingIPAddr KKFIELAEFFK)
		{
			IPBEAECLPOJ.AKKLLMAJAKF(ref this, ref KKFIELAEFFK);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00016764 File Offset: 0x00014964
		public bool HPEGMAOHEON()
		{
			return IPBEAECLPOJ.LPPFGPMNIHA(ref this);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00016868 File Offset: 0x00014A68
		public ulong FOCACGHMEHH()
		{
			return IPBEAECLPOJ.CODAIFMEECI(ref this);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00016764 File Offset: 0x00014964
		public bool ADDHDCKHLJP()
		{
			return IPBEAECLPOJ.LPPFGPMNIHA(ref this);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00016870 File Offset: 0x00014A70
		public string GIBJLJKFOOI()
		{
			return MBLFNIBGODG.EFIMHBHCPFM(IPBEAECLPOJ.LAABDAHFJPD(ref this));
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00016880 File Offset: 0x00014A80
		public bool HFCAHCEKHCM(string MCOLDANPEJC)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(MCOLDANPEJC))
			{
				result = IPBEAECLPOJ.LMFDGOKPIIH(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x000168BC File Offset: 0x00014ABC
		public bool LHOJNFDCENJ(string MCOLDANPEJC)
		{
			bool result;
			using (MBLFNIBGODG.LJANJDBDBJI ljanjdbdbji = new MBLFNIBGODG.LJANJDBDBJI(MCOLDANPEJC))
			{
				result = IPBEAECLPOJ.LMFDGOKPIIH(ref this, ljanjdbdbji);
			}
			return result;
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00016752 File Offset: 0x00014952
		public void PPFGMEKEMGP()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000168F8 File Offset: 0x00014AF8
		public CSteamID MBABIFOJGFK()
		{
			return CSteamID.PEAFCMBIENC(IPBEAECLPOJ.KPEOFLFCICC(ref this));
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00016905 File Offset: 0x00014B05
		public string NJPDLAIIIDL()
		{
			return MBLFNIBGODG.IIHDLLEMLDA(IPBEAECLPOJ.LAABDAHFJPD(ref this));
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00016752 File Offset: 0x00014952
		public void EGJKLMKOJLE()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00016804 File Offset: 0x00014A04
		public byte[] FKPJDFOFACB(out int DLPBEGLKBJL)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00016914 File Offset: 0x00014B14
		public void FFPLEFPLADA(out string CFHBIAJPGMC)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(128);
			IPBEAECLPOJ.FBIAKMDLJLL(ref this, intPtr, 128U);
			CFHBIAJPGMC = MBLFNIBGODG.EFIMHBHCPFM(intPtr);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000167B4 File Offset: 0x000149B4
		public HJNNPCJKHBP IEGDDMFFMMP()
		{
			return IPBEAECLPOJ.DADELMHCEBE(ref this);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00016870 File Offset: 0x00014A70
		public string NHEDEBDCNKJ()
		{
			return MBLFNIBGODG.EFIMHBHCPFM(IPBEAECLPOJ.LAABDAHFJPD(ref this));
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0001668A File Offset: 0x0001488A
		public void KIDGEOKEMMM(ulong EKCOJJGHNAN)
		{
			IPBEAECLPOJ.FMKJBCFAEFI(ref this, EKCOJJGHNAN);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00016946 File Offset: 0x00014B46
		public uint ACMGFGADPOP()
		{
			return IPBEAECLPOJ.MOCLAFKEJKM(ref this);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00016860 File Offset: 0x00014A60
		public bool PMKCBGLEDMK()
		{
			return IPBEAECLPOJ.EKBIKMBBAJD(ref this);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0001668A File Offset: 0x0001488A
		public void DHDKJGCNEJI(ulong EKCOJJGHNAN)
		{
			IPBEAECLPOJ.FMKJBCFAEFI(ref this, EKCOJJGHNAN);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0001694E File Offset: 0x00014B4E
		public void OMMFAFGMKKH(CSteamID EKCOJJGHNAN)
		{
			IPBEAECLPOJ.OILGMBGKOPD(ref this, CSteamID.PEAFCMBIENC(EKCOJJGHNAN));
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00016752 File Offset: 0x00014952
		public void OBKBODEDOIF()
		{
			IPBEAECLPOJ.JCBCFMCJOOK(ref this);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00016946 File Offset: 0x00014B46
		public uint JIAEJLKEHII()
		{
			return IPBEAECLPOJ.MOCLAFKEJKM(ref this);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0001695C File Offset: 0x00014B5C
		public CSteamID LCKCJDBOLLO()
		{
			return CSteamID.MFKKKOBBPNG(IPBEAECLPOJ.KPEOFLFCICC(ref this));
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00016764 File Offset: 0x00014964
		public bool KKONFPGLJAP()
		{
			return IPBEAECLPOJ.LPPFGPMNIHA(ref this);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00016804 File Offset: 0x00014A04
		public byte[] LHHIPPIOCNL(out int DLPBEGLKBJL)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000167B4 File Offset: 0x000149B4
		public HJNNPCJKHBP NPHFPHKODAK()
		{
			return IPBEAECLPOJ.DADELMHCEBE(ref this);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00016804 File Offset: 0x00014A04
		public byte[] HIHGINLCEDK(out int DLPBEGLKBJL)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000167B4 File Offset: 0x000149B4
		public HJNNPCJKHBP GKPOKIEGADB()
		{
			return IPBEAECLPOJ.DADELMHCEBE(ref this);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00016969 File Offset: 0x00014B69
		public bool KALIIHFDMAN()
		{
			return this.LCIHBOCPJNM() > HJNNPCJKHBP.k_ESteamNetworkingFakeIPType_NotFake;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0001675A File Offset: 0x0001495A
		public void EAEGOFKAMHK(uint KGLEJGCAGBD, ushort MLHPDILCKGP)
		{
			IPBEAECLPOJ.ICFOGIMLABN(ref this, KGLEJGCAGBD, MLHPDILCKGP);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0001675A File Offset: 0x0001495A
		public void FFFGFLFLADM(uint KGLEJGCAGBD, ushort MLHPDILCKGP)
		{
			IPBEAECLPOJ.ICFOGIMLABN(ref this, KGLEJGCAGBD, MLHPDILCKGP);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0001675A File Offset: 0x0001495A
		public void JKJLJIHPPIL(uint KGLEJGCAGBD, ushort MLHPDILCKGP)
		{
			IPBEAECLPOJ.ICFOGIMLABN(ref this, KGLEJGCAGBD, MLHPDILCKGP);
		}

		// Token: 0x040009B4 RID: 2484
		public FADJLMADGPK m_eType;

		// Token: 0x040009B5 RID: 2485
		private int m_cbSize;

		// Token: 0x040009B6 RID: 2486
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private uint[] m_reserved;

		// Token: 0x040009B7 RID: 2487
		public const int k_cchMaxString = 128;

		// Token: 0x040009B8 RID: 2488
		public const int k_cchMaxGenericString = 32;

		// Token: 0x040009B9 RID: 2489
		public const int k_cbMaxGenericBytes = 32;
	}
}
