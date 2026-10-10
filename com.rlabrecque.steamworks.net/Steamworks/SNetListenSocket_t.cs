using System;

namespace Steamworks
{
	// Token: 0x02000121 RID: 289
	[Serializable]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00011E4A File Offset: 0x0001004A
		public static bool BOOIHFPDBNE(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.OMLOICDKIKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00011E56 File Offset: 0x00010056
		public static bool NEFGNGBGAJI(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00011E56 File Offset: 0x00010056
		public static bool JEOLIDMKGPM(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool IIHMLPBMEJB(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint LIGOIMKDILD(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool OMLOICDKIKC(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00011E62 File Offset: 0x00010062
		public bool HJMLEBEHMFA(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00011E7A File Offset: 0x0001007A
		public int NIBFBLHKBPP(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket.CompareTo(LNBMEILJKDH.m_SNetListenSocket);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00011E62 File Offset: 0x00010062
		public bool EKEPMIJHKEP(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00011E62 File Offset: 0x00010062
		public bool IIMFAIFNACE(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00011E62 File Offset: 0x00010062
		public bool MDJCEENBHCF(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool POOPLDLDIEE(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint HFKMNMAPPEF(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00011E62 File Offset: 0x00010062
		public bool PDEIGPLPAJC(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00011E8D File Offset: 0x0001008D
		public static bool HCCJEBOKDIH(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.MDMEOBPEGFH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00011E99 File Offset: 0x00010099
		public static bool IDHFJKJMFNO(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return SNetListenSocket_t.NLLAAFKMDGB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t MDEEAEPDOPL(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t PJCFLLGPNKB(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00011E7A File Offset: 0x0001007A
		public int MANGKJJCODN(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket.CompareTo(LNBMEILJKDH.m_SNetListenSocket);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00011EAD File Offset: 0x000100AD
		public override string ToString()
		{
			return this.m_SNetListenSocket.ToString();
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint HAIGBPCLLHH(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00011E62 File Offset: 0x00010062
		public bool IDPPEPEAHIC(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool CAGEBEMJDMJ(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00011EBA File Offset: 0x000100BA
		public override int GetHashCode()
		{
			return this.m_SNetListenSocket.GetHashCode();
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool MKGNKAMFMPG(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00011EC7 File Offset: 0x000100C7
		public static bool GEDIHMHFNMI(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.NMOCADNHGKO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00011ED3 File Offset: 0x000100D3
		public static bool OPFKIHFEGFN(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return SNetListenSocket_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t NBKEGKHGGOH(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint EFIDMFLMNJM(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint CCADGDCAMNN(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t BFKCGOCPDHP(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t BDDFEOKMDML(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00011EDF File Offset: 0x000100DF
		public static bool PLDCHLDNHFD(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return SNetListenSocket_t.NMOCADNHGKO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00011EEB File Offset: 0x000100EB
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is SNetListenSocket_t && SNetListenSocket_t.MKGNKAMFMPG(this, (SNetListenSocket_t)LNBMEILJKDH);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00011F08 File Offset: 0x00010108
		public SNetListenSocket_t(uint AJLPALFJHCC)
		{
			this.m_SNetListenSocket = AJLPALFJHCC;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00011E7A File Offset: 0x0001007A
		public int INBBOPIDLHP(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket.CompareTo(LNBMEILJKDH.m_SNetListenSocket);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00011E62 File Offset: 0x00010062
		public bool NCPDGCJHMGF(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00011E4A File Offset: 0x0001004A
		public static bool OCKKOOFJONC(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.OMLOICDKIKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00011E7A File Offset: 0x0001007A
		public int DLCBDAFFEIF(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket.CompareTo(LNBMEILJKDH.m_SNetListenSocket);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint GFMFFKFBOIA(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t JHKPJDENLLN(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint CNACGJBNBDA(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint FCCBKBMCOGK(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool NMOCADNHGKO(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool AKABDJCLIAP(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint AMAFMNJBNKC(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t IILDEMMMPHE(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00011E62 File Offset: 0x00010062
		public bool JLLGDFFIGEI(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00011E62 File Offset: 0x00010062
		public bool OLIDABINOGH(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00011E62 File Offset: 0x00010062
		public bool DMAEMGGDCCO(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint PEAFCMBIENC(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00011E62 File Offset: 0x00010062
		public bool Equals(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00011E4A File Offset: 0x0001004A
		public static bool LJBNKEBHLGE(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.OMLOICDKIKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00011F11 File Offset: 0x00010111
		public static bool PNPPOPMEIGG(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return SNetListenSocket_t.IIHMLPBMEJB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t OLDLOCJALFC(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint EHINDPIFDCP(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t PEAFCMBIENC(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool NLLAAFKMDGB(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00011E62 File Offset: 0x00010062
		public bool DBMDDNLKNNA(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket == LNBMEILJKDH.m_SNetListenSocket;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00011E62 File Offset: 0x00010062
		public static bool MDMEOBPEGFH(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SNetListenSocket == DEJFBNMNMOK.m_SNetListenSocket;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00011E7A File Offset: 0x0001007A
		public int CompareTo(SNetListenSocket_t LNBMEILJKDH)
		{
			return this.m_SNetListenSocket.CompareTo(LNBMEILJKDH.m_SNetListenSocket);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00011E72 File Offset: 0x00010072
		public static uint MEIBALKJPLN(SNetListenSocket_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SNetListenSocket;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00011F11 File Offset: 0x00010111
		public static bool AONOBDMGABM(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return SNetListenSocket_t.IIHMLPBMEJB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static SNetListenSocket_t ICIODPKFNBE(uint AJLPALFJHCC)
		{
			return new SNetListenSocket_t(AJLPALFJHCC);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00011F1D File Offset: 0x0001011D
		public static bool EGJOCGPNKFG(SNetListenSocket_t OBNBCGOIMKE, SNetListenSocket_t DEJFBNMNMOK)
		{
			return !SNetListenSocket_t.CAGEBEMJDMJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x04000790 RID: 1936
		public uint m_SNetListenSocket;
	}
}
