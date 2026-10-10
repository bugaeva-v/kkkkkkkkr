using System;

namespace Steamworks
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x00010652 File Offset: 0x0000E852
		public static int CJJJDNMOIIN(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0001065A File Offset: 0x0000E85A
		public static bool JEOLIDMKGPM(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.HELPLOFAEII(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool IHIIKPAAMOG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00010666 File Offset: 0x0000E866
		public bool Equals(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool AKAEDFOCJGG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00010652 File Offset: 0x0000E852
		public static int PJCFLLGPNKB(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00010652 File Offset: 0x0000E852
		public static int KKCOMKGMJNK(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool ICHPJJCEOGJ(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool OIHAHBPNBNM(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool KKLFFJMPLGL(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00010676 File Offset: 0x0000E876
		public static bool NEFGNGBGAJI(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t NHFENIAGPGH(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0001068A File Offset: 0x0000E88A
		public SteamItemDef_t(int AJLPALFJHCC)
		{
			this.m_SteamItemDef = AJLPALFJHCC;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00010693 File Offset: 0x0000E893
		public int CompareTo(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000106A6 File Offset: 0x0000E8A6
		public static bool AKCKCACICKH(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.KKLFFJMPLGL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool OLKDMLMMJHH(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t ECPEBBPPHMN(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00010666 File Offset: 0x0000E866
		public bool MMCLBBLECBG(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000106A6 File Offset: 0x0000E8A6
		public static bool KMHCGFJNHHO(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.KKLFFJMPLGL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool CBMMJFPJEMP(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000106B2 File Offset: 0x0000E8B2
		public static bool JHINANEEJMD(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return SteamItemDef_t.INFBAPFOEAG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t MJBDELEJHBJ(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00010693 File Offset: 0x0000E893
		public int PMAHKAHHFFP(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00010652 File Offset: 0x0000E852
		public static int HLNFKNJGCDL(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x000106BE File Offset: 0x0000E8BE
		public static bool ECLPKLJCBLI(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.GMHDDJDOOAF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool CNNMIMNJNHI(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool CPGPENOAPNF(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00010652 File Offset: 0x0000E852
		public static int IGAJFACIMAH(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000106CA File Offset: 0x0000E8CA
		public static bool GHLMENKNBCE(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.MDMEOBPEGFH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00010652 File Offset: 0x0000E852
		public static int JGFNMAFFFIK(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool FKJDDCCINJK(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool EPDABHOJHKA(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool KJIGDINCECD(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00010652 File Offset: 0x0000E852
		public static int PEAFCMBIENC(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00010666 File Offset: 0x0000E866
		public bool KHMIJNJDDPF(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t OAEJLIMPBLD(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t EHINDPIFDCP(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t CCADGDCAMNN(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool BLGHOOFOAKL(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00010666 File Offset: 0x0000E866
		public bool LGNLNOEOIOB(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00010666 File Offset: 0x0000E866
		public bool HBHKGEILDFA(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00010652 File Offset: 0x0000E852
		public static int ECPDGDCBJOL(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00010652 File Offset: 0x0000E852
		public static int NDKJBBBFHMJ(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool INFBAPFOEAG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00010652 File Offset: 0x0000E852
		public static int BDDFEOKMDML(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00010693 File Offset: 0x0000E893
		public int KGEIINKILIN(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00010666 File Offset: 0x0000E866
		public bool GINOMLIPLPP(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00010666 File Offset: 0x0000E866
		public bool PDEIGPLPAJC(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t JHGEMFPADIC(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool GMHDDJDOOAF(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool MDMEOBPEGFH(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00010652 File Offset: 0x0000E852
		public static int PKJMBHJMNGD(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00010652 File Offset: 0x0000E852
		public static int GGOHAPLJANG(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00010652 File Offset: 0x0000E852
		public static int EMEEPNFJOCC(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool BACNLCCBLKB(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t OEFDMNAIJAE(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00010666 File Offset: 0x0000E866
		public bool JDDFHOOKAJM(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00010666 File Offset: 0x0000E866
		public bool IPEAALJDPEH(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t PJLGPAOKAHP(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00010666 File Offset: 0x0000E866
		public bool ECFLCEDBBKD(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool AKABDJCLIAP(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00010652 File Offset: 0x0000E852
		public static int JHKPJDENLLN(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t PEAFCMBIENC(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00010666 File Offset: 0x0000E866
		public bool IHMHHKNBKKJ(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000106D6 File Offset: 0x0000E8D6
		public static bool PCGLHFJOJLP(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.FKJDDCCINJK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00010666 File Offset: 0x0000E866
		public bool DBMDDNLKNNA(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t IKLLJLALECJ(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00010666 File Offset: 0x0000E866
		public bool FJMAMBGKJOB(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00010693 File Offset: 0x0000E893
		public int FOLBCOLPIJA(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool FCNDJIIPGEK(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t LKNOJDPCCED(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool JOLOGNMCAOG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00010693 File Offset: 0x0000E893
		public int PDKEBBKCEBJ(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00010666 File Offset: 0x0000E866
		public bool MDJCEENBHCF(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000106E2 File Offset: 0x0000E8E2
		public static bool LDJPKACOFHP(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return SteamItemDef_t.DNDOMECANNG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00010666 File Offset: 0x0000E866
		public bool EDDLPPEKMNK(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000106EE File Offset: 0x0000E8EE
		public static bool IMKCPLIMHAG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return SteamItemDef_t.KKLFFJMPLGL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000106FA File Offset: 0x0000E8FA
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is SteamItemDef_t && SteamItemDef_t.MKGNKAMFMPG(this, (SteamItemDef_t)LNBMEILJKDH);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool CBHLAPAEMOG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00010666 File Offset: 0x0000E866
		public bool MNIDPIHPEPF(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00010717 File Offset: 0x0000E917
		public static bool DBGIJLPDJMN(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return SteamItemDef_t.IHIIKPAAMOG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t JLMEKJCNHMJ(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00010652 File Offset: 0x0000E852
		public static int AMAFMNJBNKC(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool JKPIFELENIA(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00010652 File Offset: 0x0000E852
		public static int KGBGNMNLPKN(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00010723 File Offset: 0x0000E923
		public static bool HCDPJCOFKKO(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.IJHDFAADJMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t NBDDOHGGLDM(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00010693 File Offset: 0x0000E893
		public int CNOKIIGBKPK(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00010693 File Offset: 0x0000E893
		public int MANGKJJCODN(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00010652 File Offset: 0x0000E852
		public static int KIHGBMMGNNK(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00010666 File Offset: 0x0000E866
		public bool JADFDGCLPDG(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t HGIOFALCHCO(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool DNDOMECANNG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00010652 File Offset: 0x0000E852
		public static int IILDEMMMPHE(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00010693 File Offset: 0x0000E893
		public int BLNCOMNPMFG(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t KMKPAEHLFGD(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0001072F File Offset: 0x0000E92F
		public override string ToString()
		{
			return this.m_SteamItemDef.ToString();
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool AHFPKACACBA(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00010666 File Offset: 0x0000E866
		public bool OCOEJHFHGLJ(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00010652 File Offset: 0x0000E852
		public static int EFIDMFLMNJM(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00010693 File Offset: 0x0000E893
		public int FLDAOGDJFIP(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00010666 File Offset: 0x0000E866
		public bool OADDCIOCGKD(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0001065A File Offset: 0x0000E85A
		public static bool OODKONKMCBA(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return !SteamItemDef_t.HELPLOFAEII(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t FJECAGOHIKI(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00010693 File Offset: 0x0000E893
		public int FIIHLFOLBBH(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00010652 File Offset: 0x0000E852
		public static int KDPKCGOAAPD(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool KEHBKFIDCJM(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00010693 File Offset: 0x0000E893
		public int LKMBNGPKKFE(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00010666 File Offset: 0x0000E866
		public bool OHHEEHDNDGH(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00010666 File Offset: 0x0000E866
		public bool NPFAFEKOJEL(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00010693 File Offset: 0x0000E893
		public int CHAFIKIKKIO(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00010693 File Offset: 0x0000E893
		public int LHINNCDIGMO(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00010652 File Offset: 0x0000E852
		public static int NFKIKJLFHBG(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00010693 File Offset: 0x0000E893
		public int MBDCDIAPPKN(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00010693 File Offset: 0x0000E893
		public int OFGNNJBGBBO(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00010666 File Offset: 0x0000E866
		public bool KCAPPOKNPBN(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00010693 File Offset: 0x0000E893
		public int ADAEJLOJINC(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool MKGNKAMFMPG(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00010666 File Offset: 0x0000E866
		public bool IKBKHIFDGKK(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t EOPHKNPBLNC(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool MLKCDBHJOFC(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00010666 File Offset: 0x0000E866
		public bool PNKKPOCFHNF(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t LIEMLDPCANJ(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00010666 File Offset: 0x0000E866
		public bool IDPPEPEAHIC(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t BCNFICECAMF(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t MDEEAEPDOPL(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t BNJHAOICCOF(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t MPADGPAMIPK(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00010666 File Offset: 0x0000E866
		public bool NEMCANGLGHM(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00010666 File Offset: 0x0000E866
		public bool IFGFONGJMKL(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef == LNBMEILJKDH.m_SteamItemDef;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool HELPLOFAEII(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t IFFBKMDGBHG(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00010693 File Offset: 0x0000E893
		public int POKMMKCKGPO(SteamItemDef_t LNBMEILJKDH)
		{
			return this.m_SteamItemDef.CompareTo(LNBMEILJKDH.m_SteamItemDef);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00010652 File Offset: 0x0000E852
		public static int BOJOLDNPOAI(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00010652 File Offset: 0x0000E852
		public static int MOIADICFIOP(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool IJHDFAADJMN(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t LPPIBELHJKB(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x0001073C File Offset: 0x0000E93C
		public static bool IAPGDAMALBH(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return SteamItemDef_t.OIHAHBPNBNM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t JMOIKGMJBJD(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00010682 File Offset: 0x0000E882
		public static SteamItemDef_t MPOEPCABICJ(int AJLPALFJHCC)
		{
			return new SteamItemDef_t(AJLPALFJHCC);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00010652 File Offset: 0x0000E852
		public static int APHBNOFJKHH(SteamItemDef_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemDef;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00010666 File Offset: 0x0000E866
		public static bool HOPBDGPDMFI(SteamItemDef_t OBNBCGOIMKE, SteamItemDef_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemDef == DEJFBNMNMOK.m_SteamItemDef;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00010748 File Offset: 0x0000E948
		public override int GetHashCode()
		{
			return this.m_SteamItemDef.GetHashCode();
		}

		// Token: 0x040006E7 RID: 1767
		public int m_SteamItemDef;
	}
}
