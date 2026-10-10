using System;

namespace Steamworks
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00005673 File Offset: 0x00003873
		public bool CBJMMJCBDGN(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00005683 File Offset: 0x00003883
		public int DBKEOFDLFGA(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong CBMHIJAIMFN(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong BNJHAOICCOF(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000569E File Offset: 0x0000389E
		public static bool PALENFIECHL(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.ECBCJIBHMHH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000056AA File Offset: 0x000038AA
		public static bool ILEALMPICFM(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.MDMEOBPEGFH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t AMAFMNJBNKC(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00005673 File Offset: 0x00003873
		public bool IOOLOMHPIKF(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000056BE File Offset: 0x000038BE
		public static bool LIPONJEMBIJ(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.IJHDFAADJMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong ICIODPKFNBE(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t EMEEPNFJOCC(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00005673 File Offset: 0x00003873
		public static bool NLLAAFKMDGB(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00005683 File Offset: 0x00003883
		public int CJOBPCIFDDD(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000056CA File Offset: 0x000038CA
		public static bool AKCKCACICKH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.HBODEHLFDJH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00005673 File Offset: 0x00003873
		public static bool CBHLAPAEMOG(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t APEPNCPEJJA(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00005673 File Offset: 0x00003873
		public bool IPEAALJDPEH(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00005673 File Offset: 0x00003873
		public bool AICPFLKLHFE(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong LHKLDDEFGFE(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t MDHKPHFGMDC(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t APPGPDNMIDL(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong NNFBJDPEMAH(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000056D6 File Offset: 0x000038D6
		public static bool HCDPJCOFKKO(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.HBODEHLFDJH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00005683 File Offset: 0x00003883
		public int LGDFGIAHHME(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00005683 File Offset: 0x00003883
		public int FPLPEMNKGOK(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong BPFLDKEBKED(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t BCNFICECAMF(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t MPOEPCABICJ(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000056E2 File Offset: 0x000038E2
		public static bool DEFACHCDELC(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t PKJMBHJMNGD(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000056EE File Offset: 0x000038EE
		public static bool DFBOPLBLCLI(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.BPIJFACBBJF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00005673 File Offset: 0x00003873
		public static bool BPIJFACBBJF(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t LDPFIFCFHIE(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00005673 File Offset: 0x00003873
		public static bool EPDABHOJHKA(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong MJBDELEJHBJ(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t IGAJFACIMAH(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00005673 File Offset: 0x00003873
		public bool IKBKHIFDGKK(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000056FA File Offset: 0x000038FA
		public static bool KEDJFKAHBEO(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.IBOCKEKAMCM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00005683 File Offset: 0x00003883
		public int PCPOOFNGNMC(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong AIGHJLNLCOB(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00005673 File Offset: 0x00003873
		public bool KDCGAFIBBAO(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00005673 File Offset: 0x00003873
		public static bool ODNAAAAOKGH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong EOPHKNPBLNC(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00005673 File Offset: 0x00003873
		public bool Equals(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t CCADGDCAMNN(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00005706 File Offset: 0x00003906
		public static bool LDJPKACOFHP(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.MDMEOBPEGFH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t LIDCAILIGIK(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t JHKPJDENLLN(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00005712 File Offset: 0x00003912
		public static bool LAEKPOOEJDL(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.AKABDJCLIAP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00005673 File Offset: 0x00003873
		public static bool KJDLGEAOBCN(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00005673 File Offset: 0x00003873
		public static bool DDGCIIFCECG(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t MEIBALKJPLN(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t ECPDGDCBJOL(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000571E File Offset: 0x0000391E
		public SteamLeaderboardEntries_t(ulong AJLPALFJHCC)
		{
			this.m_SteamLeaderboardEntries = AJLPALFJHCC;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t DJDKDNCPEIO(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000056EE File Offset: 0x000038EE
		public static bool BLNCPPILENE(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.BPIJFACBBJF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong MPADGPAMIPK(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00005673 File Offset: 0x00003873
		public static bool MDMEOBPEGFH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong DCPDCODLHJN(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00005673 File Offset: 0x00003873
		public static bool ECBCJIBHMHH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong MFJNOKJHHEP(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t LIGOIMKDILD(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong LLOCKDHOJBG(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00005673 File Offset: 0x00003873
		public static bool DAGBNKEILMG(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00005727 File Offset: 0x00003927
		public static bool FHPJKFKOHNH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.DDGCIIFCECG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong PEAFCMBIENC(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00005733 File Offset: 0x00003933
		public static bool NEFGNGBGAJI(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00005673 File Offset: 0x00003873
		public bool BKJDCJCOOBJ(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00005673 File Offset: 0x00003873
		public bool NJCOGLFELNH(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00005673 File Offset: 0x00003873
		public bool JLLGDFFIGEI(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00005683 File Offset: 0x00003883
		public int BPABCNBMDAE(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t CNPAFOGFAIM(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong KOIGMCFBCII(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong IFFBKMDGBHG(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00005673 File Offset: 0x00003873
		public static bool IJHDFAADJMN(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00005673 File Offset: 0x00003873
		public bool OLIDABINOGH(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00005673 File Offset: 0x00003873
		public static bool MAHNGHKEFIC(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong CNACGJBNBDA(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00005683 File Offset: 0x00003883
		public int CBPPGLNEFED(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t NFKIKJLFHBG(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00005683 File Offset: 0x00003883
		public int GODFLIMIJAM(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00005727 File Offset: 0x00003927
		public static bool HCCJEBOKDIH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.DDGCIIFCECG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00005673 File Offset: 0x00003873
		public bool BADPMBMDPIP(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000573F File Offset: 0x0000393F
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is SteamLeaderboardEntries_t && SteamLeaderboardEntries_t.MKGNKAMFMPG(this, (SteamLeaderboardEntries_t)LNBMEILJKDH);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t IEMDOCBBBOP(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong HFKMNMAPPEF(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000575C File Offset: 0x0000395C
		public static bool PJHIIMAAMLH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.IFAFEAOIGFD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00005683 File Offset: 0x00003883
		public int CompareTo(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00005683 File Offset: 0x00003883
		public int MEDIKGILCOA(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t MDEEAEPDOPL(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t HLNFKNJGCDL(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t OOGENOMLAON(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong CJJJDNMOIIN(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t OAEJLIMPBLD(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong PHDAOLLLEOA(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00005673 File Offset: 0x00003873
		public bool MDCHFNJHJBF(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00005673 File Offset: 0x00003873
		public static bool CAGEBEMJDMJ(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong KGBGNMNLPKN(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong HEGMONHPLPF(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00005683 File Offset: 0x00003883
		public int GOOANKMJIMN(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00005683 File Offset: 0x00003883
		public int NAIBHAPJOKA(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00005683 File Offset: 0x00003883
		public int FLDAOGDJFIP(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00005768 File Offset: 0x00003968
		public override int GetHashCode()
		{
			return this.m_SteamLeaderboardEntries.GetHashCode();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00005673 File Offset: 0x00003873
		public bool GFPAGHPGHHG(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong POBKLPDBJGK(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00005683 File Offset: 0x00003883
		public int POKMMKCKGPO(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00005673 File Offset: 0x00003873
		public static bool IFAFEAOIGFD(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00005673 File Offset: 0x00003873
		public static bool IBOCKEKAMCM(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t NBDDOHGGLDM(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000575C File Offset: 0x0000395C
		public static bool DMGKEMPAGDP(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return !SteamLeaderboardEntries_t.IFAFEAOIGFD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00005775 File Offset: 0x00003975
		public override string ToString()
		{
			return this.m_SteamLeaderboardEntries.ToString();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00005683 File Offset: 0x00003883
		public int DIDNDFEIIPI(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00005683 File Offset: 0x00003883
		public int INBBOPIDLHP(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t EENFFODLOCF(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00005673 File Offset: 0x00003873
		public bool MKIJFNEMLLO(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00005673 File Offset: 0x00003873
		public static bool AKABDJCLIAP(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00005782 File Offset: 0x00003982
		public static bool FIKFEJGKJDK(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return SteamLeaderboardEntries_t.MKONPBCDPHI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t LOEIJPMCCPF(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00005673 File Offset: 0x00003873
		public static bool IAFCKGHALAJ(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00005683 File Offset: 0x00003883
		public int ECEGOEPHPDF(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries.CompareTo(LNBMEILJKDH.m_SteamLeaderboardEntries);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t FNGKLAHPAOB(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00005673 File Offset: 0x00003873
		public static bool HBODEHLFDJH(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong IENNODEKPII(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000056B6 File Offset: 0x000038B6
		public static SteamLeaderboardEntries_t JHGEMFPADIC(ulong AJLPALFJHCC)
		{
			return new SteamLeaderboardEntries_t(AJLPALFJHCC);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00005673 File Offset: 0x00003873
		public bool NDILAKAIKEC(SteamLeaderboardEntries_t LNBMEILJKDH)
		{
			return this.m_SteamLeaderboardEntries == LNBMEILJKDH.m_SteamLeaderboardEntries;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00005673 File Offset: 0x00003873
		public static bool MKONPBCDPHI(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00005696 File Offset: 0x00003896
		public static ulong BFKCGOCPDHP(SteamLeaderboardEntries_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamLeaderboardEntries;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00005673 File Offset: 0x00003873
		public static bool MKGNKAMFMPG(SteamLeaderboardEntries_t OBNBCGOIMKE, SteamLeaderboardEntries_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamLeaderboardEntries == DEJFBNMNMOK.m_SteamLeaderboardEntries;
		}

		// Token: 0x04000251 RID: 593
		public ulong m_SteamLeaderboardEntries;
	}
}
