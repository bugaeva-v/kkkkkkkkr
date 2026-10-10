using System;

namespace Steamworks
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong IHKCLEGDAEC(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t DBFCFFCHFLB(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t GDLOOPECAGA(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t OOGENOMLAON(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong EFIDMFLMNJM(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00014046 File Offset: 0x00012246
		public int FPLPEMNKGOK(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00014067 File Offset: 0x00012267
		public static bool IIHMLPBMEJB(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00014046 File Offset: 0x00012246
		public int BOKJBEEFMDM(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00014067 File Offset: 0x00012267
		public bool EPBJEKJAJAM(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00014046 File Offset: 0x00012246
		public int COBNKIJOMII(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00014077 File Offset: 0x00012277
		public override string ToString()
		{
			return this.m_SteamInventoryUpdateHandle.ToString();
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00014067 File Offset: 0x00012267
		public bool GAGENFLGMPL(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00014067 File Offset: 0x00012267
		public bool IKBKHIFDGKK(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00014084 File Offset: 0x00012284
		public static bool JFPFILAOJMM(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.OMLOICDKIKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00014090 File Offset: 0x00012290
		public static bool IPHIKMKINFF(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.HOPBDGPDMFI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00014067 File Offset: 0x00012267
		public bool DMAEMGGDCCO(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0001409C File Offset: 0x0001229C
		public static bool AKCGBMIACGD(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00014067 File Offset: 0x00012267
		public static bool JFAMHEAILKL(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00014067 File Offset: 0x00012267
		public bool DFMMFPLNFFK(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong MDEEAEPDOPL(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00014046 File Offset: 0x00012246
		public int MEDKBMJEJEK(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000140A8 File Offset: 0x000122A8
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is SteamInventoryUpdateHandle_t && SteamInventoryUpdateHandle_t.MKGNKAMFMPG(this, (SteamInventoryUpdateHandle_t)LNBMEILJKDH);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00014067 File Offset: 0x00012267
		public static bool MKGNKAMFMPG(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000140C5 File Offset: 0x000122C5
		public static bool KEDJFKAHBEO(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.JKPIFELENIA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00014046 File Offset: 0x00012246
		public int IKDJDCLHBGI(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00014067 File Offset: 0x00012267
		public static bool HOPBDGPDMFI(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000140D1 File Offset: 0x000122D1
		public static bool MLELOPPFNAA(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.IIHMLPBMEJB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong DJDKDNCPEIO(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t OMOGNLKCNAE(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00014084 File Offset: 0x00012284
		public static bool JHEELDCJJCN(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.OMLOICDKIKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00014046 File Offset: 0x00012246
		public int EENLKDHPBAM(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00014067 File Offset: 0x00012267
		public static bool PEGNGOCNKEH(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00014067 File Offset: 0x00012267
		public bool IDPPEPEAHIC(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t MJBDELEJHBJ(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000140DD File Offset: 0x000122DD
		public static bool JEGAPAODOEO(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.GLKOEPDDOHN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00014067 File Offset: 0x00012267
		public static bool ANMCAPADKNB(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00014067 File Offset: 0x00012267
		public bool DKNOFLLOLFM(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00014046 File Offset: 0x00012246
		public int IIGHANNBMEL(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong PEAFCMBIENC(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00014067 File Offset: 0x00012267
		public static bool OCHCFNHCCJB(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t IKLLJLALECJ(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t LIGOIMKDILD(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong PCFJPKPGCKC(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong IILDEMMMPHE(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t ECBJFILBKEG(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t LFPIOHLDKCO(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00014067 File Offset: 0x00012267
		public bool Equals(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t MPOEPCABICJ(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00014090 File Offset: 0x00012290
		public static bool EIPBBOHNKFK(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.HOPBDGPDMFI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00014067 File Offset: 0x00012267
		public static bool DNCINEIEPJG(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0001409C File Offset: 0x0001229C
		public static bool IOALMFOPPJI(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong AIGHJLNLCOB(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000140E9 File Offset: 0x000122E9
		public override int GetHashCode()
		{
			return this.m_SteamInventoryUpdateHandle.GetHashCode();
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000140F6 File Offset: 0x000122F6
		public static bool ACHMHFAOKEL(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.GMHDDJDOOAF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t PHDAOLLLEOA(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00014046 File Offset: 0x00012246
		public int CompareTo(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00014067 File Offset: 0x00012267
		public bool PHNJMELFJHE(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00014067 File Offset: 0x00012267
		public static bool GLKOEPDDOHN(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00014067 File Offset: 0x00012267
		public bool JDDFHOOKAJM(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00014102 File Offset: 0x00012302
		public static bool MDIDEFFOBBG(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.HOPBDGPDMFI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00014067 File Offset: 0x00012267
		public bool CIAJOOGLMAG(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t LOEIJPMCCPF(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00014067 File Offset: 0x00012267
		public bool CDCAIFDHIFP(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0001410E File Offset: 0x0001230E
		public static bool NEFGNGBGAJI(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0001411A File Offset: 0x0001231A
		public static bool LCDOKKNHFPK(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.MDKNEBICNLD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00014046 File Offset: 0x00012246
		public int OPAKPCPFCLG(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0001411A File Offset: 0x0001231A
		public static bool KHDLNKNPFLG(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return SteamInventoryUpdateHandle_t.MDKNEBICNLD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0001410E File Offset: 0x0001230E
		public static bool BOOIHFPDBNE(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return !SteamInventoryUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00014046 File Offset: 0x00012246
		public int EDIANBCBAPC(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong JLMEKJCNHMJ(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00014067 File Offset: 0x00012267
		public static bool JKPIFELENIA(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t BFKCGOCPDHP(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00014046 File Offset: 0x00012246
		public int OEEAHJJOGHI(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00014067 File Offset: 0x00012267
		public static bool OMLOICDKIKC(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00014067 File Offset: 0x00012267
		public static bool LJKJMNKEKMF(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t PJLGPAOKAHP(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0001403E File Offset: 0x0001223E
		public static SteamInventoryUpdateHandle_t HGIOFALCHCO(ulong AJLPALFJHCC)
		{
			return new SteamInventoryUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00014046 File Offset: 0x00012246
		public int PKFDMPKMDEF(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle.CompareTo(LNBMEILJKDH.m_SteamInventoryUpdateHandle);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00014067 File Offset: 0x00012267
		public bool EKEPMIJHKEP(SteamInventoryUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_SteamInventoryUpdateHandle == LNBMEILJKDH.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00014126 File Offset: 0x00012326
		public SteamInventoryUpdateHandle_t(ulong AJLPALFJHCC)
		{
			this.m_SteamInventoryUpdateHandle = AJLPALFJHCC;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00014067 File Offset: 0x00012267
		public static bool MDKNEBICNLD(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00014067 File Offset: 0x00012267
		public static bool GMHDDJDOOAF(SteamInventoryUpdateHandle_t OBNBCGOIMKE, SteamInventoryUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamInventoryUpdateHandle == DEJFBNMNMOK.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00014036 File Offset: 0x00012236
		public static ulong JHGEMFPADIC(SteamInventoryUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamInventoryUpdateHandle;
		}

		// Token: 0x040008CA RID: 2250
		public static readonly SteamInventoryUpdateHandle_t Invalid = new SteamInventoryUpdateHandle_t(ulong.MaxValue);

		// Token: 0x040008CB RID: 2251
		public ulong m_SteamInventoryUpdateHandle;
	}
}
