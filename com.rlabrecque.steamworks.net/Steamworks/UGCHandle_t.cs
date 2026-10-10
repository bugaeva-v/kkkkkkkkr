using System;

namespace Steamworks
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		// Token: 0x0600225C RID: 8796 RVA: 0x000176BA File Offset: 0x000158BA
		public int PCPOOFNGNMC(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong MEIBALKJPLN(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool OLIDABINOGH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong OOGENOMLAON(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool JDDFHOOKAJM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t LHKLDDEFGFE(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool DEJOOBGLHCH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000176BA File Offset: 0x000158BA
		public int DMPFCJLPBOP(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000176ED File Offset: 0x000158ED
		public override int GetHashCode()
		{
			return this.m_UGCHandle.GetHashCode();
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000176BA File Offset: 0x000158BA
		public int CompareTo(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t OFOPKGCKJMB(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool DPNFHEACCEH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000176FA File Offset: 0x000158FA
		public static bool JEGAPAODOEO(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.FKJDDCCINJK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool NLLAAFKMDGB(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00017706 File Offset: 0x00015906
		public static bool MLELOPPFNAA(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return !UGCHandle_t.KPJNJOJCMJN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool OEHGPCPILFB(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool ODLFDLOIAGF(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool MHHKHKHDEMH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool KPJNJOJCMJN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool CILGCJDPFAJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t GADOGIBOENF(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000176BA File Offset: 0x000158BA
		public int PIKPOHMNPAJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool NEMCANGLGHM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong GDLOOPECAGA(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool MHGMNCNIPBF(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool HLAPMHHLDKO(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong NDKJBBBFHMJ(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong PEAFCMBIENC(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00017712 File Offset: 0x00015912
		public static bool KOFDLJACFLM(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return !UGCHandle_t.DIIIKJCFJOE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong CNACGJBNBDA(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool DIIIKJCFJOE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong EMEEPNFJOCC(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000176BA File Offset: 0x000158BA
		public int AJJDJKLGEBH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t CCADGDCAMNN(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t PJIOKAFGDJP(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0001771E File Offset: 0x0001591E
		public static bool KGLKDBIGMNP(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool DPKAIFGJNOM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool KCAPPOKNPBN(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong NBKEGKHGGOH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong OKLMOKIFIPH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool DNCINEIEPJG(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000176BA File Offset: 0x000158BA
		public int LPNCFFBPGNO(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong JHGEMFPADIC(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool ALFPOHOCKDE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00017738 File Offset: 0x00015938
		public static bool AAOFJCDKBJF(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.HLAPMHHLDKO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong PJLGPAOKAHP(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000176BA File Offset: 0x000158BA
		public int OPAKPCPFCLG(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool CDCAIFDHIFP(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong CJJJDNMOIIN(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong IGAJFACIMAH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong EOLJJPADGDN(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00017744 File Offset: 0x00015944
		public static bool MGOELGLNPLE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.ODLFDLOIAGF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00017750 File Offset: 0x00015950
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is UGCHandle_t && UGCHandle_t.MKGNKAMFMPG(this, (UGCHandle_t)LNBMEILJKDH);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong JAMBFIOAJNM(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong ICIODPKFNBE(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool CAGEBEMJDMJ(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t IENNODEKPII(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool ECBCJIBHMHH(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool Equals(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t MPOEPCABICJ(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool BFFHGMAIFEM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0001776D File Offset: 0x0001596D
		public static bool ICIDMEKGBJE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.ECBCJIBHMHH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t MFJNOKJHHEP(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000176BA File Offset: 0x000158BA
		public int MMGHPHDPLEF(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool IGDLLAKOACE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000176BA File Offset: 0x000158BA
		public int AMHIGIIOPHN(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool DBMDDNLKNNA(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool KPJKHCJLPGN(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t JLMEKJCNHMJ(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000176BA File Offset: 0x000158BA
		public int OFGNNJBGBBO(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong FEBMCHIABBI(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool JALNCEPAGBN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t JOJCDIDJOOL(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t IMFHLPBJMBA(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool JHDBIABDGLI(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000176BA File Offset: 0x000158BA
		public int OOOJMNPBGFC(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00017779 File Offset: 0x00015979
		public static bool LOEENBMBLHI(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return !UGCHandle_t.ALFPOHOCKDE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000176BA File Offset: 0x000158BA
		public int ENGDBAPNJIF(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool IJHDFAADJMN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool JOLOGNMCAOG(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong KDMCDHGNCBF(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t PCFJPKPGCKC(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool MKGNKAMFMPG(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00017785 File Offset: 0x00015985
		public static bool IJKBFPCKGPE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.IJHDFAADJMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong APHBNOFJKHH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong FEBLHIAKHFK(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t NHFENIAGPGH(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00017791 File Offset: 0x00015991
		public static bool DFDJEKOGCDC(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.MOCPHEKJAGK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool MHPHMEABPFJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong NNFBJDPEMAH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000176BA File Offset: 0x000158BA
		public int GOOANKMJIMN(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool LIHJCMEGGME(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t CJBHKNNBEKD(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool GLKOEPDDOHN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000176BA File Offset: 0x000158BA
		public int CJOBPCIFDDD(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0001779D File Offset: 0x0001599D
		public UGCHandle_t(ulong AJLPALFJHCC)
		{
			this.m_UGCHandle = AJLPALFJHCC;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000177A6 File Offset: 0x000159A6
		public static bool NEFGNGBGAJI(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return !UGCHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00017791 File Offset: 0x00015991
		public static bool KMBICGEOCLN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.MOCPHEKJAGK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong KJFNPDCLGPD(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000177B2 File Offset: 0x000159B2
		public override string ToString()
		{
			return this.m_UGCHandle.ToString();
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t FEJNJFAMEOE(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000177BF File Offset: 0x000159BF
		public static bool DEFACHCDELC(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.KEHBKFIDCJM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong FLOCHBNBGOI(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong HFKMNMAPPEF(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool DAGBNKEILMG(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool EFOBHPPGIGO(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool MILFKNIMNFJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t HEGMONHPLPF(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool COFGAMEDKMK(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000176BA File Offset: 0x000158BA
		public int POKMMKCKGPO(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong GGOHAPLJANG(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00017712 File Offset: 0x00015912
		public static bool MMOJMPFLJAN(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return !UGCHandle_t.DIIIKJCFJOE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000177CB File Offset: 0x000159CB
		public static bool AJEJKHILLCE(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.CAGEBEMJDMJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000177D7 File Offset: 0x000159D7
		public static bool DOELMPHIGAG(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return UGCHandle_t.DAGBNKEILMG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool ODLINHPHKIK(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000176BA File Offset: 0x000158BA
		public int PCBKMJJBDGL(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool DKNOFLLOLFM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000176BA File Offset: 0x000158BA
		public int NABEPALDKNI(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool CANDPPLLFMD(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000176BA File Offset: 0x000158BA
		public int GODFLIMIJAM(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t NFKIKJLFHBG(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool JDJCKJFAPJC(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t BFKCGOCPDHP(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x000176BA File Offset: 0x000158BA
		public int IHIDHLMNOOO(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool GDCLCOGHFLJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t KOIGMCFBCII(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x000176BA File Offset: 0x000158BA
		public int JHOEELHBEJJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong BMFJBGHGNHF(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000176BA File Offset: 0x000158BA
		public int FEAMPHPBLDN(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool MOCPHEKJAGK(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool IHLJDHFPIPE(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool FKJDDCCINJK(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000176BA File Offset: 0x000158BA
		public int KBBINNJLDJB(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong CJBLMHBFKIL(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t PJCFLLGPNKB(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool HGMLMCJIAFL(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool BNKMHIALFMD(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool NBJIKEJCHCJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x000176D5 File Offset: 0x000158D5
		public static bool KEHBKFIDCJM(UGCHandle_t OBNBCGOIMKE, UGCHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCHandle == DEJFBNMNMOK.m_UGCHandle;
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong CNPAFOGFAIM(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong HAIGBPCLLHH(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t MPADGPAMIPK(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x000176BA File Offset: 0x000158BA
		public int NJMCFOIAKMI(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x000176BA File Offset: 0x000158BA
		public int JEIAMDAHECB(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool KIFAFOOMNAH(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong JJBCKFJBGKE(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t CLCLLACDPIE(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000176BA File Offset: 0x000158BA
		public int KHKAFKHMPEI(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle.CompareTo(LNBMEILJKDH.m_UGCHandle);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000176D5 File Offset: 0x000158D5
		public bool BKJDCJCOOBJ(UGCHandle_t LNBMEILJKDH)
		{
			return this.m_UGCHandle == LNBMEILJKDH.m_UGCHandle;
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x000176E5 File Offset: 0x000158E5
		public static UGCHandle_t LNBGCHMJAGC(ulong AJLPALFJHCC)
		{
			return new UGCHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000176CD File Offset: 0x000158CD
		public static ulong EOPHKNPBLNC(UGCHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCHandle;
		}

		// Token: 0x04000A11 RID: 2577
		public static readonly UGCHandle_t Invalid = new UGCHandle_t(ulong.MaxValue);

		// Token: 0x04000A12 RID: 2578
		public ulong m_UGCHandle;
	}
}
