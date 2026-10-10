using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002A53 File Offset: 0x00000C53
		public uint EBIFCMIHBCG()
		{
			return (uint)(this.m_SteamID >> 67 & 120UL);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002A66 File Offset: 0x00000C66
		public bool LGFDLEIFHLH()
		{
			return this.OHJFLDMPMJN() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002A71 File Offset: 0x00000C71
		public bool AIDGBGKNMGL()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeContentServer;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002A7C File Offset: 0x00000C7C
		public FPKHIMINDDO HGANGANKDOF()
		{
			return (FPKHIMINDDO)(this.m_SteamID >> 52 & 15UL);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002A8C File Offset: 0x00000C8C
		public void ONICNCABBPM(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18446744073709551566UL) | (ulong)((ulong)((long)LNBMEILJKDH & -8L) << 113));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002AB1 File Offset: 0x00000CB1
		public bool BOBGDBJBMKL()
		{
			return this.OHJFLDMPMJN() != FPKHIMINDDO.k_EAccountTypeMultiseat || (this.LCOKBIGKKAD() & 96U) > 0U;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002ACD File Offset: 0x00000CCD
		public bool BDAPMMECKCE()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeGameServer || this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002AE3 File Offset: 0x00000CE3
		public bool AELLLHEDPHB()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypePending;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002AEE File Offset: 0x00000CEE
		public void ICGLGLNEDKK(AccountID_t FBJBNIJOFGP, uint CMMBIMHPCBO, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.GIDGNKFJHCI(FBJBNIJOFGP);
			this.KMFBABOFLFM(FCOLMKJCEHB);
			this.MLEGKOMHIKB(OONLCOBCNHA);
			this.GIEKCLICIAE(CMMBIMHPCBO);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002B0D File Offset: 0x00000D0D
		public void PMGHIPDNAGP(AccountID_t FBJBNIJOFGP, uint CMMBIMHPCBO, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.JOMJBOMOCLA(FBJBNIJOFGP);
			this.KMFBABOFLFM(FCOLMKJCEHB);
			this.HKEIMDIECGP(OONLCOBCNHA);
			this.GIEKCLICIAE(CMMBIMHPCBO);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002B2C File Offset: 0x00000D2C
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is CSteamID && CSteamID.MKGNKAMFMPG(this, (CSteamID)LNBMEILJKDH);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002B49 File Offset: 0x00000D49
		public bool PEONGIAPEMK()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeChat && (this.HFMGKKJAFMF() & 262144U) > 0U;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002B65 File Offset: 0x00000D65
		public bool EJKPALEGCIK()
		{
			return this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002B70 File Offset: 0x00000D70
		public void CJPGBJFLBBJ(AccountID_t FBJBNIJOFGP, uint CMMBIMHPCBO, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.JOMJBOMOCLA(FBJBNIJOFGP);
			this.ONICNCABBPM(FCOLMKJCEHB);
			this.MLEGKOMHIKB(OONLCOBCNHA);
			this.IKAGGNECMCJ(CMMBIMHPCBO);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002B8F File Offset: 0x00000D8F
		public bool EAMHFGFKCIO()
		{
			return this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeMultiseat && (this.EOKFAEMFEPL() & 34U) > 0U;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002BAB File Offset: 0x00000DAB
		public bool GCGOCOLGPJI()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeContentServer;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002BB6 File Offset: 0x00000DB6
		public FPKHIMINDDO EAMOCJNIHDF()
		{
			return (FPKHIMINDDO)(this.m_SteamID >> 49 & 18446744073709551596UL);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public bool NJGILGGFHBD()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeChat;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public CSteamID(ulong IGEBIFCBDMH)
		{
			this.m_SteamID = IGEBIFCBDMH;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002BDA File Offset: 0x00000DDA
		public static bool NFDGMMCNNMN(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamID == DEJFBNMNMOK.m_SteamID;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002BEA File Offset: 0x00000DEA
		public bool ODPJMPAMJOD()
		{
			return !AccountID_t.JKKPNIFHJJO(this.FGIHJAOJCKB(), new AccountID_t(1U)) || !this.HILOFEPNBHO() || this.KJDDLPBMIFC() == 0U;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002C12 File Offset: 0x00000E12
		public CSteamID(AccountID_t FBJBNIJOFGP, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.m_SteamID = 0UL;
			this.BNEOPFCMJOK(FBJBNIJOFGP, FCOLMKJCEHB, OONLCOBCNHA);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002C25 File Offset: 0x00000E25
		public bool OJJLPOAFKIH()
		{
			return this.EAMOCJNIHDF() != FPKHIMINDDO.k_EAccountTypeAnonGameServer || (this.EOKFAEMFEPL() & 172U) > 1U;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002C44 File Offset: 0x00000E44
		public bool PAMEBCDBPAG()
		{
			return this.EJHJNKFCEJG() > FPKHIMINDDO.k_EAccountTypeInvalid && this.OHJFLDMPMJN() < (FPKHIMINDDO)(-46) && this.JIENIMKGBBL() > PLGPFJMBLEI.k_EUniversePublic && this.BCNIBPPCGAO() < PLGPFJMBLEI.k_EUniverseMax && (this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeIndividual || (!AccountID_t.ODNAAAAOKGH(this.AILJILODKKF(), new AccountID_t(1U)) && this.NJEEDHKANGH() <= 0U)) && ((this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeGameServer && (AccountID_t.CDNPFFJOFOM(this.BHOFADAOEAK(), new AccountID_t(0U)) || this.LCOKBIGKKAD() != 0U)) || this.EJHJNKFCEJG() != FPKHIMINDDO.k_EAccountTypePending || !AccountID_t.DAPAOMINKAH(this.AILJILODKKF(), new AccountID_t(1U)));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002AE3 File Offset: 0x00000CE3
		public bool AOJFMGLNOLK()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypePending;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong CBMHIJAIMFN(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002CEE File Offset: 0x00000EEE
		public void IJHHMHAEKKE()
		{
			this.m_SteamID = 0UL;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public void EEHJICJLDKA(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(1U));
			this.LBGHDOKBJCE(FCOLMKJCEHB);
			this.HKEIMDIECGP(FPKHIMINDDO.k_EAccountTypeInvalid);
			this.ALLJFHEMONL(1U);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002D1B File Offset: 0x00000F1B
		public void FHIACOLBGKE(FPKHIMINDDO LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 410UL) | (ulong)((ulong)((long)LNBMEILJKDH & -47L) << -103));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002D3D File Offset: 0x00000F3D
		public static bool IOALMFOPPJI(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.ODLFDLOIAGF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002D49 File Offset: 0x00000F49
		public bool GGFANGGCIEN()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeMultiseat;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002D54 File Offset: 0x00000F54
		public uint NJEEDHKANGH()
		{
			return (uint)(this.m_SteamID >> -81 & 18446744073709551456UL);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002D67 File Offset: 0x00000F67
		public static bool PALENFIECHL(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002D73 File Offset: 0x00000F73
		public void DMLPOKMJHNF(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(0U));
			this.ONICNCABBPM(FCOLMKJCEHB);
			this.MLEGKOMHIKB(FPKHIMINDDO.k_EAccountTypePending);
			this.GIEKCLICIAE(1U);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002D96 File Offset: 0x00000F96
		public bool MGJOHEJEHOC()
		{
			return this.EJHJNKFCEJG() == (FPKHIMINDDO)(-106);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public bool KCDEPIIDABI()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeConsoleUser;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002DAE File Offset: 0x00000FAE
		public void BNEOPFCMJOK(AccountID_t FBJBNIJOFGP, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.GIDGNKFJHCI(FBJBNIJOFGP);
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.HKEIMDIECGP(OONLCOBCNHA);
			if (OONLCOBCNHA == FPKHIMINDDO.k_EAccountTypeClan || OONLCOBCNHA == FPKHIMINDDO.k_EAccountTypeGameServer)
			{
				this.IKAGGNECMCJ(0U);
				return;
			}
			this.IKAGGNECMCJ(1U);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002D67 File Offset: 0x00000F67
		public static bool LOKGEPBONJG(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002DDC File Offset: 0x00000FDC
		public static bool DOELMPHIGAG(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.JKPIFELENIA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002B65 File Offset: 0x00000D65
		public bool HKGAFAGMFEI()
		{
			return this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public bool OFOIJNIKGLP()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeAnonUser;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public bool PBADFPDNLKI()
		{
			return this.OHJFLDMPMJN() <= FPKHIMINDDO.k_EAccountTypeInvalid || this.HGANGANKDOF() >= (FPKHIMINDDO)(-33) || (this.CFKLJPAPOJN() <= PLGPFJMBLEI.k_EUniversePublic || this.BCNIBPPCGAO() >= PLGPFJMBLEI.k_EUniverseInvalid) || (this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeInvalid && (AccountID_t.JKKPNIFHJJO(this.AILJILODKKF(), new AccountID_t(0U)) || this.NPGHJDGEOHF() > 0U)) || ((this.EJHJNKFCEJG() != FPKHIMINDDO.k_EAccountTypeInvalid || (!AccountID_t.FCJCLJODCNM(this.FGIHJAOJCKB(), new AccountID_t(0U)) && this.EOKFAEMFEPL() == 0U)) && (this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeMultiseat && AccountID_t.IJHDFAADJMN(this.BHOFADAOEAK(), new AccountID_t(1U))) && false);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002BDA File Offset: 0x00000DDA
		public bool Equals(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID == LNBMEILJKDH.m_SteamID;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002E96 File Offset: 0x00001096
		public void KCJGNEGJDJP(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(0U));
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.MAMAJNGPKCK((FPKHIMINDDO)(-125));
			this.ALLJFHEMONL(0U);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002EBA File Offset: 0x000010BA
		public static CSteamID MFKKKOBBPNG(ulong AJLPALFJHCC)
		{
			return new CSteamID(AJLPALFJHCC);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong LIGOIMKDILD(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002EC2 File Offset: 0x000010C2
		public bool ONKJIMJCKEL()
		{
			return this.HGANGANKDOF() != (FPKHIMINDDO)70 && this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong MDHKPHFGMDC(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002ED9 File Offset: 0x000010D9
		public bool PCCFPFFJNCI()
		{
			return !AccountID_t.CDNPFFJOFOM(this.BHOFADAOEAK(), new AccountID_t(1U)) || !this.IGDDACEODKL() || this.LCOKBIGKKAD() == 0U;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002F01 File Offset: 0x00001101
		public bool MHEBJEFDCFM()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeInvalid || this.OHJFLDMPMJN() == (FPKHIMINDDO)(-67);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002BDA File Offset: 0x00000DDA
		public static bool ODLFDLOIAGF(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamID == DEJFBNMNMOK.m_SteamID;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002D3D File Offset: 0x00000F3D
		public static bool GPOEFLCFIHO(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.ODLFDLOIAGF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002EBA File Offset: 0x000010BA
		public static CSteamID PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new CSteamID(AJLPALFJHCC);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002F18 File Offset: 0x00001118
		public void ILNMPDAIDDD(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(0U));
			this.LBGHDOKBJCE(FCOLMKJCEHB);
			this.MAMAJNGPKCK((FPKHIMINDDO)(-55));
			this.IKAGGNECMCJ(1U);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002F3C File Offset: 0x0000113C
		public bool IBCEDIMEHCE()
		{
			return this.OHJFLDMPMJN() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong PEAFCMBIENC(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong IKLLJLALECJ(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002F47 File Offset: 0x00001147
		public void FJCPDBOOBPL(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(1U));
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.HKEIMDIECGP((FPKHIMINDDO)104);
			this.ALLJFHEMONL(0U);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002F6B File Offset: 0x0000116B
		public bool OMDIPBKEOMC()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeClan;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002F76 File Offset: 0x00001176
		public void NHAONAKHHNL()
		{
			this.m_SteamID = 1UL;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002F80 File Offset: 0x00001180
		public bool MCPCOBIMPEB()
		{
			return this.OHJFLDMPMJN() == FPKHIMINDDO.k_EAccountTypeClan;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002F8B File Offset: 0x0000118B
		public bool GOIEMMNAGCG()
		{
			return this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeInvalid && this.EAMOCJNIHDF() == (FPKHIMINDDO)(-22);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002BDA File Offset: 0x00000DDA
		public static bool MKGNKAMFMPG(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamID == DEJFBNMNMOK.m_SteamID;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002F6B File Offset: 0x0000116B
		public bool LOCDDDCODIG()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeClan;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002FA2 File Offset: 0x000011A2
		public void FEGPBHLDLGA(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(0U));
			this.KMFBABOFLFM(FCOLMKJCEHB);
			this.FHIACOLBGKE((FPKHIMINDDO)(-80));
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002EBA File Offset: 0x000010BA
		public static CSteamID PHDAOLLLEOA(ulong AJLPALFJHCC)
		{
			return new CSteamID(AJLPALFJHCC);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002FC6 File Offset: 0x000011C6
		public void ELPJHODBDAO(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(0U));
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.HKEIMDIECGP(FPKHIMINDDO.k_EAccountTypeAnonUser);
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002FEC File Offset: 0x000011EC
		public bool GNPDGHKBCMJ()
		{
			return this.OHJFLDMPMJN() > FPKHIMINDDO.k_EAccountTypeInvalid && this.EAMOCJNIHDF() < (FPKHIMINDDO)94 && this.JIENIMKGBBL() > PLGPFJMBLEI.k_EUniversePublic && this.BCNIBPPCGAO() < PLGPFJMBLEI.k_EUniverseInvalid && (this.OHJFLDMPMJN() != FPKHIMINDDO.k_EAccountTypeInvalid || (!AccountID_t.NFDGMMCNNMN(this.BHOFADAOEAK(), new AccountID_t(1U)) && this.NPGHJDGEOHF() <= 1U)) && ((this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeContentServer && (AccountID_t.IJHDFAADJMN(this.BHOFADAOEAK(), new AccountID_t(0U)) || this.NPGHJDGEOHF() != 0U)) || (this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeContentServer && AccountID_t.IJHDFAADJMN(this.BHOFADAOEAK(), new AccountID_t(1U))));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000308E File Offset: 0x0000128E
		public bool GLPJMCLNMMG()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeChat;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002D67 File Offset: 0x00000F67
		public static bool IPHIKMKINFF(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002BDA File Offset: 0x00000DDA
		public bool MNIDPIHPEPF(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID == LNBMEILJKDH.m_SteamID;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003099 File Offset: 0x00001299
		public void OOCDACHPLJD(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 72057594037927935UL) | (ulong)((ulong)((long)LNBMEILJKDH & 255L) << 56));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000030BE File Offset: 0x000012BE
		public void MMBDOKPOMIB(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 143UL) | (ulong)((ulong)((long)LNBMEILJKDH & 99L) << 31));
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000030E3 File Offset: 0x000012E3
		public uint HPLCFLMCOPB()
		{
			return (uint)(this.m_SteamID >> 91 & 62UL);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000030F6 File Offset: 0x000012F6
		public override int GetHashCode()
		{
			return this.m_SteamID.GetHashCode();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003103 File Offset: 0x00001303
		public void ALLJFHEMONL(uint LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18446744073709550211UL) | ((ulong)LNBMEILJKDH & 90UL) << 32);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003128 File Offset: 0x00001328
		public uint LCOKBIGKKAD()
		{
			return (uint)(this.m_SteamID >> -54 & 18446744073709551539UL);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000313B File Offset: 0x0000133B
		public uint NPGHJDGEOHF()
		{
			return (uint)(this.m_SteamID >> 52 & 120UL);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000314E File Offset: 0x0000134E
		public bool OMBHCPKMIPC()
		{
			return this.OHJFLDMPMJN() == (FPKHIMINDDO)(-64);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000315A File Offset: 0x0000135A
		public bool LFOIPIDMNPF()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeIndividual && (this.LCOKBIGKKAD() & 180U) > 0U;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003176 File Offset: 0x00001376
		public override string ToString()
		{
			return this.m_SteamID.ToString();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003183 File Offset: 0x00001383
		public bool FOCNAEKJFBP()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeClan;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong MPADGPAMIPK(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000318E File Offset: 0x0000138E
		public void MLEGKOMHIKB(FPKHIMINDDO LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 596UL) | (ulong)((ulong)((long)LNBMEILJKDH & 54L) << 17));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000031B0 File Offset: 0x000013B0
		public PLGPFJMBLEI CFKLJPAPOJN()
		{
			return (PLGPFJMBLEI)(this.m_SteamID >> 56 & 255UL);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000031C3 File Offset: 0x000013C3
		public bool DIIAMBNEENE()
		{
			return this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeIndividual;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000031CE File Offset: 0x000013CE
		public FPKHIMINDDO EJHJNKFCEJG()
		{
			return (FPKHIMINDDO)(this.m_SteamID >> 12 & 78UL);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000031DE File Offset: 0x000013DE
		public void JPILICMOAMH(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(1U));
			this.MMBDOKPOMIB(FCOLMKJCEHB);
			this.HKEIMDIECGP((FPKHIMINDDO)(-74));
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002BDA File Offset: 0x00000DDA
		public bool LBFHFGGCAJP(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID == LNBMEILJKDH.m_SteamID;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003202 File Offset: 0x00001402
		public void KMFBABOFLFM(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 295UL) | (ulong)((ulong)((long)LNBMEILJKDH & 2L) << 12));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003227 File Offset: 0x00001427
		public void HKEIMDIECGP(FPKHIMINDDO LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18379190079298994175UL) | (ulong)((ulong)((long)LNBMEILJKDH & 15L) << 52));
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003249 File Offset: 0x00001449
		public bool FPBAMDEAOIM()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003254 File Offset: 0x00001454
		public bool EDKHKKOFOMM()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeIndividual || this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeConsoleUser;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000326B File Offset: 0x0000146B
		public AccountID_t FGIHJAOJCKB()
		{
			return new AccountID_t((uint)(this.m_SteamID & (ulong)-1));
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000327C File Offset: 0x0000147C
		public void MAMAJNGPKCK(FPKHIMINDDO LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 1936UL) | (ulong)((ulong)((long)LNBMEILJKDH & 109L) << 15));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000329E File Offset: 0x0000149E
		public bool JKKBBAJEHLI()
		{
			return this.OHJFLDMPMJN() == (FPKHIMINDDO)(-48);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000032AA File Offset: 0x000014AA
		public bool OCANHCCEHOF()
		{
			return this.HGANGANKDOF() == (FPKHIMINDDO)(-102);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000032B6 File Offset: 0x000014B6
		public int CompareTo(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID.CompareTo(LNBMEILJKDH.m_SteamID);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000326B File Offset: 0x0000146B
		public AccountID_t BHOFADAOEAK()
		{
			return new AccountID_t((uint)(this.m_SteamID & (ulong)-1));
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000032C9 File Offset: 0x000014C9
		public bool IGDDACEODKL()
		{
			return this.EAMOCJNIHDF() != (FPKHIMINDDO)(-75) && this.EAMOCJNIHDF() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000032E0 File Offset: 0x000014E0
		public void LBGHDOKBJCE(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 555UL) | (ulong)((ulong)((long)LNBMEILJKDH & -185L) << 97));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003305 File Offset: 0x00001505
		public bool OFLKEBJJFBK()
		{
			return this.OHJFLDMPMJN() == FPKHIMINDDO.k_EAccountTypeInvalid;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003310 File Offset: 0x00001510
		public void GIEKCLICIAE(uint LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 1034UL) | ((ulong)LNBMEILJKDH & 181UL) << 33);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003335 File Offset: 0x00001535
		public bool HILOFEPNBHO()
		{
			return this.OHJFLDMPMJN() == (FPKHIMINDDO)(-119) || this.OHJFLDMPMJN() == FPKHIMINDDO.k_EAccountTypeInvalid;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000334C File Offset: 0x0000154C
		public FPKHIMINDDO OHJFLDMPMJN()
		{
			return (FPKHIMINDDO)(this.m_SteamID >> -107 & 94UL);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000335C File Offset: 0x0000155C
		public uint HFMGKKJAFMF()
		{
			return (uint)(this.m_SteamID >> 32 & 1048575UL);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000336F File Offset: 0x0000156F
		public bool BPLFGMDKAAN()
		{
			return this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeInvalid;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002CEE File Offset: 0x00000EEE
		public void GGCAGDGMKEC()
		{
			this.m_SteamID = 0UL;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000337A File Offset: 0x0000157A
		public PLGPFJMBLEI JIENIMKGBBL()
		{
			return (PLGPFJMBLEI)(this.m_SteamID >> -92 & 43UL);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000338D File Offset: 0x0000158D
		public bool EDGABPCFNAP()
		{
			return AccountID_t.MKGNKAMFMPG(this.BHOFADAOEAK(), new AccountID_t(0U)) && this.LDEDJBFOGGJ() && this.HFMGKKJAFMF() == 0U;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002D67 File Offset: 0x00000F67
		public static bool NEFGNGBGAJI(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return !CSteamID.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000033B5 File Offset: 0x000015B5
		public bool LHLFKGDAGKG()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000033C0 File Offset: 0x000015C0
		public bool INEKFCLBCAB()
		{
			return this.HGANGANKDOF() > FPKHIMINDDO.k_EAccountTypeInvalid && this.HGANGANKDOF() < FPKHIMINDDO.k_EAccountTypeMax && this.CFKLJPAPOJN() > PLGPFJMBLEI.k_EUniverseInvalid && this.CFKLJPAPOJN() < PLGPFJMBLEI.k_EUniverseMax && (this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeIndividual || (!AccountID_t.MKGNKAMFMPG(this.BHOFADAOEAK(), new AccountID_t(0U)) && this.HFMGKKJAFMF() <= 1U)) && (this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeClan || (!AccountID_t.MKGNKAMFMPG(this.BHOFADAOEAK(), new AccountID_t(0U)) && this.HFMGKKJAFMF() == 0U)) && (this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeGameServer || !AccountID_t.MKGNKAMFMPG(this.BHOFADAOEAK(), new AccountID_t(0U)));
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003462 File Offset: 0x00001662
		public uint KJDDLPBMIFC()
		{
			return (uint)(this.m_SteamID >> 106 & 18446744073709551559UL);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003475 File Offset: 0x00001675
		public PLGPFJMBLEI EHLDFPEMCJG()
		{
			return (PLGPFJMBLEI)(this.m_SteamID >> 82 & 143UL);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002BDA File Offset: 0x00000DDA
		public static bool BGLONEMFOBG(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamID == DEJFBNMNMOK.m_SteamID;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003488 File Offset: 0x00001688
		public void JOMJBOMOCLA(AccountID_t LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 161UL) | ((ulong)AccountID_t.EOLJJPADGDN(LNBMEILJKDH) & (ulong)-1));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000034AB File Offset: 0x000016AB
		public CSteamID(AccountID_t FBJBNIJOFGP, uint GMOAABPLCLG, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.m_SteamID = 0UL;
			this.HOLNIKDIOOA(FBJBNIJOFGP, GMOAABPLCLG, FCOLMKJCEHB, OONLCOBCNHA);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000308E File Offset: 0x0000128E
		public bool HGCLBKJHELI()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeChat;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000034C0 File Offset: 0x000016C0
		public void FCIDGGIAIFP(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(0U));
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.HKEIMDIECGP(FPKHIMINDDO.k_EAccountTypeAnonGameServer);
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002BDA File Offset: 0x00000DDA
		public static bool JKPIFELENIA(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamID == DEJFBNMNMOK.m_SteamID;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002BAB File Offset: 0x00000DAB
		public bool KFFNLAMBPKD()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeContentServer;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000034E3 File Offset: 0x000016E3
		public void IAPJNEIBFCK(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(1U));
			this.MMBDOKPOMIB(FCOLMKJCEHB);
			this.FHIACOLBGKE(FPKHIMINDDO.k_EAccountTypeMultiseat);
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003506 File Offset: 0x00001706
		public bool DMJJIIMFELH()
		{
			return this.HGANGANKDOF() == (FPKHIMINDDO)(-98);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003512 File Offset: 0x00001712
		public bool OOJNFOCPMGC()
		{
			return this.EAMOCJNIHDF() == (FPKHIMINDDO)(-17);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000351E File Offset: 0x0000171E
		public bool DCLPOAGFJLK()
		{
			return !AccountID_t.FDIFAFLDHPC(this.FGIHJAOJCKB(), new AccountID_t(1U)) || !this.IGDDACEODKL() || this.EOKFAEMFEPL() == 1U;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000326B File Offset: 0x0000146B
		public AccountID_t AILJILODKKF()
		{
			return new AccountID_t((uint)(this.m_SteamID & (ulong)-1));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003546 File Offset: 0x00001746
		public bool MBNKKBBJMCN()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeMultiseat;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003551 File Offset: 0x00001751
		public void GIDGNKFJHCI(AccountID_t LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18446744069414584320UL) | ((ulong)AccountID_t.PEAFCMBIENC(LNBMEILJKDH) & (ulong)-1));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000032B6 File Offset: 0x000014B6
		public int DMHAPKJNPGH(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID.CompareTo(LNBMEILJKDH.m_SteamID);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public static ulong DBFCFFCHFLB(CSteamID MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamID;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003574 File Offset: 0x00001774
		public void BBAIEMPINAA(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(0U));
			this.IHOHDBANCGD(FCOLMKJCEHB);
			this.MLEGKOMHIKB(FPKHIMINDDO.k_EAccountTypeIndividual);
			this.ALLJFHEMONL(0U);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002F76 File Offset: 0x00001176
		public void MAJAFJCMCJL()
		{
			this.m_SteamID = 1UL;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003597 File Offset: 0x00001797
		public void NGGBKMOGHNN(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.GIDGNKFJHCI(new AccountID_t(0U));
			this.LBGHDOKBJCE(FCOLMKJCEHB);
			this.HKEIMDIECGP((FPKHIMINDDO)(-59));
			this.GIEKCLICIAE(1U);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000035BB File Offset: 0x000017BB
		public void IPEKJJLGACD(PLGPFJMBLEI FCOLMKJCEHB)
		{
			this.JOMJBOMOCLA(new AccountID_t(1U));
			this.MMBDOKPOMIB(FCOLMKJCEHB);
			this.HKEIMDIECGP(FPKHIMINDDO.k_EAccountTypeInvalid);
			this.IKAGGNECMCJ(0U);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000308E File Offset: 0x0000128E
		public bool MPPNNCAAGFB()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeChat;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000035DE File Offset: 0x000017DE
		public bool KGDHMLGDLNE()
		{
			return this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000035E9 File Offset: 0x000017E9
		public bool AJLGNLMKMBJ()
		{
			return this.OHJFLDMPMJN() == (FPKHIMINDDO)108 || this.EJHJNKFCEJG() == FPKHIMINDDO.k_EAccountTypeGameServer;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003183 File Offset: 0x00001383
		public bool MGEKLMGIAFE()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeClan;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003600 File Offset: 0x00001800
		public bool PNDHOIOLPJK()
		{
			return this.HGANGANKDOF() != FPKHIMINDDO.k_EAccountTypeIndividual && this.EJHJNKFCEJG() == (FPKHIMINDDO)95;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003617 File Offset: 0x00001817
		public PLGPFJMBLEI BCNIBPPCGAO()
		{
			return (PLGPFJMBLEI)(this.m_SteamID >> 117 & 99UL);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000308E File Offset: 0x0000128E
		public bool FDALIHJHJPM()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeChat;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000362A File Offset: 0x0000182A
		public void HOLNIKDIOOA(AccountID_t FBJBNIJOFGP, uint CMMBIMHPCBO, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.GIDGNKFJHCI(FBJBNIJOFGP);
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.HKEIMDIECGP(OONLCOBCNHA);
			this.IKAGGNECMCJ(CMMBIMHPCBO);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003649 File Offset: 0x00001849
		public void IKAGGNECMCJ(uint LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18442240478377148415UL) | ((ulong)LNBMEILJKDH & 1048575UL) << 32);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000366E File Offset: 0x0000186E
		public bool OMKBFNAGOCP()
		{
			return this.HGANGANKDOF() == (FPKHIMINDDO)(-54);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000367A File Offset: 0x0000187A
		public void IHOHDBANCGD(PLGPFJMBLEI LNBMEILJKDH)
		{
			this.m_SteamID = ((this.m_SteamID & 18446744073709550698UL) | (ulong)((ulong)((long)LNBMEILJKDH & -110L) << -88));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000369F File Offset: 0x0000189F
		public bool LDEDJBFOGGJ()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeAnonUser || this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeAnonGameServer;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000036B6 File Offset: 0x000018B6
		public uint EOKFAEMFEPL()
		{
			return (uint)(this.m_SteamID >> 87 & 18446744073709551443UL);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003730 File Offset: 0x00001930
		public bool LIFMNKGNNMK()
		{
			return this.HGANGANKDOF() == FPKHIMINDDO.k_EAccountTypeInvalid;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000373B File Offset: 0x0000193B
		public static bool PFAANKCPAKD(CSteamID OBNBCGOIMKE, CSteamID DEJFBNMNMOK)
		{
			return CSteamID.ODLFDLOIAGF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003747 File Offset: 0x00001947
		public void JJCDOHOEFML(AccountID_t FBJBNIJOFGP, uint CMMBIMHPCBO, PLGPFJMBLEI FCOLMKJCEHB, FPKHIMINDDO OONLCOBCNHA)
		{
			this.GIDGNKFJHCI(FBJBNIJOFGP);
			this.OOCDACHPLJD(FCOLMKJCEHB);
			this.MLEGKOMHIKB(OONLCOBCNHA);
			this.IKAGGNECMCJ(CMMBIMHPCBO);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000032B6 File Offset: 0x000014B6
		public int DPGNKPICGOA(CSteamID LNBMEILJKDH)
		{
			return this.m_SteamID.CompareTo(LNBMEILJKDH.m_SteamID);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003766 File Offset: 0x00001966
		public bool CDKNHHCDDLG()
		{
			return this.HGANGANKDOF() == (FPKHIMINDDO)53;
		}

		// Token: 0x0400005C RID: 92
		public static readonly CSteamID Nil = default(CSteamID);

		// Token: 0x0400005D RID: 93
		public static readonly CSteamID OutofDateGS = new CSteamID(new AccountID_t(0U), 0U, PLGPFJMBLEI.k_EUniverseInvalid, FPKHIMINDDO.k_EAccountTypeInvalid);

		// Token: 0x0400005E RID: 94
		public static readonly CSteamID LanModeGS = new CSteamID(new AccountID_t(0U), 0U, PLGPFJMBLEI.k_EUniversePublic, FPKHIMINDDO.k_EAccountTypeInvalid);

		// Token: 0x0400005F RID: 95
		public static readonly CSteamID NotInitYetGS = new CSteamID(new AccountID_t(1U), 0U, PLGPFJMBLEI.k_EUniverseInvalid, FPKHIMINDDO.k_EAccountTypeInvalid);

		// Token: 0x04000060 RID: 96
		public static readonly CSteamID NonSteamGS = new CSteamID(new AccountID_t(2U), 0U, PLGPFJMBLEI.k_EUniverseInvalid, FPKHIMINDDO.k_EAccountTypeInvalid);

		// Token: 0x04000061 RID: 97
		public ulong m_SteamID;
	}
}
