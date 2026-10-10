using System;

namespace Steamworks
{
	// Token: 0x0200019A RID: 410
	[Serializable]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x00015361 File Offset: 0x00013561
		public static bool JKKPNIFHJJO(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00015371 File Offset: 0x00013571
		public int FPGCPBNLBCL(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00015384 File Offset: 0x00013584
		public override string ToString()
		{
			return this.m_AccountID.ToString();
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t IEMDOCBBBOP(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00015371 File Offset: 0x00013571
		public int LKMBNGPKKFE(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00015361 File Offset: 0x00013561
		public bool KOLBOLBKHGO(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00015399 File Offset: 0x00013599
		public static bool IPHIKMKINFF(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000153A5 File Offset: 0x000135A5
		public AccountID_t(uint AJLPALFJHCC)
		{
			this.m_AccountID = AJLPALFJHCC;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t FNGKLAHPAOB(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000153AE File Offset: 0x000135AE
		public override int GetHashCode()
		{
			return this.m_AccountID.GetHashCode();
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00015361 File Offset: 0x00013561
		public static bool FDIFAFLDHPC(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00015361 File Offset: 0x00013561
		public bool MKIJFNEMLLO(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint MEIBALKJPLN(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00015361 File Offset: 0x00013561
		public bool MBGGHPHHCLB(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t FCCBKBMCOGK(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00015361 File Offset: 0x00013561
		public static bool IJHDFAADJMN(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00015361 File Offset: 0x00013561
		public static bool CNNMIMNJNHI(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00015361 File Offset: 0x00013561
		public bool ADACHEBJFAE(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint PEAFCMBIENC(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00015361 File Offset: 0x00013561
		public static bool MKGNKAMFMPG(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t PEAFCMBIENC(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000153C3 File Offset: 0x000135C3
		public static bool JLOCHIBFOOE(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint KKNDHDNGALN(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00015371 File Offset: 0x00013571
		public int DPGNKPICGOA(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00015361 File Offset: 0x00013561
		public static bool CDNPFFJOFOM(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00015361 File Offset: 0x00013561
		public static bool IHIIKPAAMOG(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00015361 File Offset: 0x00013561
		public bool EPBJEKJAJAM(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint MPOEPCABICJ(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t MDEEAEPDOPL(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00015361 File Offset: 0x00013561
		public bool MNIDPIHPEPF(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000153CF File Offset: 0x000135CF
		public static bool NFIGKNNMPKC(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.FDIFAFLDHPC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00015371 File Offset: 0x00013571
		public int FEAMPHPBLDN(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00015361 File Offset: 0x00013561
		public bool GDNFPHPKIHC(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00015361 File Offset: 0x00013561
		public bool IIMFAIFNACE(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00015361 File Offset: 0x00013561
		public static bool INFBAPFOEAG(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t CBEBKNJOAKC(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint MFJNOKJHHEP(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00015361 File Offset: 0x00013561
		public static bool HELPLOFAEII(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00015371 File Offset: 0x00013571
		public int BLNCOMNPMFG(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t DLCBJEFIHLI(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint BPFLDKEBKED(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint AMAFMNJBNKC(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00015361 File Offset: 0x00013561
		public bool JLLGDFFIGEI(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00015371 File Offset: 0x00013571
		public int BOKJBEEFMDM(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00015371 File Offset: 0x00013571
		public int AJJDJKLGEBH(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000153DB File Offset: 0x000135DB
		public static bool KOFDLJACFLM(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return AccountID_t.ODGOMOKAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00015371 File Offset: 0x00013571
		public int PKFDMPKMDEF(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint JHGEMFPADIC(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t PJCFLLGPNKB(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00015361 File Offset: 0x00013561
		public bool BECNDLCCJPK(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00015361 File Offset: 0x00013561
		public static bool POOPLDLDIEE(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t DJDKDNCPEIO(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000153E7 File Offset: 0x000135E7
		public static bool GPOEFLCFIHO(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.DNCINEIEPJG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint CNPAFOGFAIM(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000153F3 File Offset: 0x000135F3
		public static bool MGMPOHNOFMH(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return AccountID_t.HJGFMONAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint LFPIOHLDKCO(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00015361 File Offset: 0x00013561
		public bool KHPOOANHFNE(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00015371 File Offset: 0x00013571
		public int AIHEGOOFIHD(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00015361 File Offset: 0x00013561
		public static bool DNCINEIEPJG(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t MJBDELEJHBJ(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000153FF File Offset: 0x000135FF
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is AccountID_t && AccountID_t.MKGNKAMFMPG(this, (AccountID_t)LNBMEILJKDH);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00015399 File Offset: 0x00013599
		public static bool NEFGNGBGAJI(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00015371 File Offset: 0x00013571
		public int ONFAKPAAGEK(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00015361 File Offset: 0x00013561
		public static bool HJGFMONAIBF(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t APPGPDNMIDL(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00015361 File Offset: 0x00013561
		public static bool EMENMDKEEJI(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00015361 File Offset: 0x00013561
		public static bool GDLLFNJOOMO(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t NNJFABLFKDP(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0001541C File Offset: 0x0001361C
		public static bool AJEJKHILLCE(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.GDLLFNJOOMO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00015361 File Offset: 0x00013561
		public bool Equals(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t NHFENIAGPGH(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t GDLOOPECAGA(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint ICIODPKFNBE(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00015361 File Offset: 0x00013561
		public static bool DAPAOMINKAH(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00015361 File Offset: 0x00013561
		public bool BKGHOKKKGDI(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00015361 File Offset: 0x00013561
		public static bool ODNAAAAOKGH(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint OOGENOMLAON(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00015361 File Offset: 0x00013561
		public static bool MJCHIDHCCOI(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0001541C File Offset: 0x0001361C
		public static bool BOOIHFPDBNE(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.GDLLFNJOOMO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00015371 File Offset: 0x00013571
		public int MBDCDIAPPKN(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00015361 File Offset: 0x00013561
		public bool JNHLJCMDCNF(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00015371 File Offset: 0x00013571
		public int NJMCFOIAKMI(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00015428 File Offset: 0x00013628
		public static bool KEDJFKAHBEO(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.HJGFMONAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00015361 File Offset: 0x00013561
		public bool GAGENFLGMPL(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint EENFFODLOCF(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t GGOHAPLJANG(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t BFKCGOCPDHP(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00015371 File Offset: 0x00013571
		public int CompareTo(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t JAMBFIOAJNM(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint EOLJJPADGDN(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t ECBJFILBKEG(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00015361 File Offset: 0x00013561
		public bool OAKKABIOMPN(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00015371 File Offset: 0x00013571
		public int OEEAHJJOGHI(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00015434 File Offset: 0x00013634
		public static bool PALENFIECHL(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.EMENMDKEEJI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00015361 File Offset: 0x00013561
		public static bool MOCPHEKJAGK(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00015361 File Offset: 0x00013561
		public static bool FCJCLJODCNM(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t FLOCHBNBGOI(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00015361 File Offset: 0x00013561
		public static bool NFDGMMCNNMN(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00015440 File Offset: 0x00013640
		public static bool JOCBDEADFOO(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return AccountID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t CJBHKNNBEKD(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00015371 File Offset: 0x00013571
		public int LLALNDOBHAB(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000153BB File Offset: 0x000135BB
		public static uint MDHKPHFGMDC(AccountID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AccountID;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t PJLGPAOKAHP(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00015371 File Offset: 0x00013571
		public int EDIANBCBAPC(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00015361 File Offset: 0x00013561
		public bool CIAJOOGLMAG(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00015361 File Offset: 0x00013561
		public static bool FCNDJIIPGEK(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00015361 File Offset: 0x00013561
		public bool NBJIKEJCHCJ(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00015371 File Offset: 0x00013571
		public int EAIONIMGOKH(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t JPKEBFLFOIF(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t NNFBJDPEMAH(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00015361 File Offset: 0x00013561
		public bool APPOEIPKOAM(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00015361 File Offset: 0x00013561
		public static bool ODGOMOKAIBF(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00015371 File Offset: 0x00013571
		public int BJHBCAGHIEA(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0001544C File Offset: 0x0001364C
		public static bool OLLJJHFPAJP(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return !AccountID_t.ODNAAAAOKGH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00015361 File Offset: 0x00013561
		public static bool IKBEOPIFAFP(AccountID_t OBNBCGOIMKE, AccountID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AccountID == DEJFBNMNMOK.m_AccountID;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00015371 File Offset: 0x00013571
		public int IIGHANNBMEL(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00015391 File Offset: 0x00013591
		public static AccountID_t APHBNOFJKHH(uint AJLPALFJHCC)
		{
			return new AccountID_t(AJLPALFJHCC);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00015361 File Offset: 0x00013561
		public bool EFOBHPPGIGO(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00015361 File Offset: 0x00013561
		public bool IPEAALJDPEH(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID == LNBMEILJKDH.m_AccountID;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00015371 File Offset: 0x00013571
		public int ABMBPDLEJLL(AccountID_t LNBMEILJKDH)
		{
			return this.m_AccountID.CompareTo(LNBMEILJKDH.m_AccountID);
		}

		// Token: 0x0400098C RID: 2444
		public uint m_AccountID;
	}
}
