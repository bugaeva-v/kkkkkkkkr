using System;

namespace Steamworks
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t MEIBALKJPLN(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00004530 File Offset: 0x00002730
		public static bool MMOJMPFLJAN(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool BGGAEBOCGJG(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000453C File Offset: 0x0000273C
		public bool GFPAGHPGHHG(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t DBFCFFCHFLB(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000453C File Offset: 0x0000273C
		public bool MNIDPIHPEPF(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool HOPBDGPDMFI(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000454C File Offset: 0x0000274C
		public int IKDJDCLHBGI(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000454C File Offset: 0x0000274C
		public int PDKEBBKCEBJ(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000454C File Offset: 0x0000274C
		public int CHAFIKIKKIO(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t MPADGPAMIPK(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000454C File Offset: 0x0000274C
		public int COBNKIJOMII(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t KDMCDHGNCBF(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000454C File Offset: 0x0000274C
		public int EENLKDHPBAM(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong IHKCLEGDAEC(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000454C File Offset: 0x0000274C
		public int EONLEBOEBJO(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000454C File Offset: 0x0000274C
		public int NIBFBLHKBPP(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t JMOIKGMJBJD(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t LDPFIFCFHIE(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000454C File Offset: 0x0000274C
		public int OLLLNIOKCDC(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00004567 File Offset: 0x00002767
		public static bool DEFACHCDELC(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.JFAMHEAILKL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000453C File Offset: 0x0000273C
		public bool MHPHMEABPFJ(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000454C File Offset: 0x0000274C
		public int GOOANKMJIMN(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00004573 File Offset: 0x00002773
		public static bool NICMIFHHDJF(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.LDMNACBGBPK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000457F File Offset: 0x0000277F
		public static bool OLLJJHFPAJP(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.MDMEOBPEGFH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000458B File Offset: 0x0000278B
		public override string ToString()
		{
			return this.m_SteamItemInstanceID.ToString();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00004598 File Offset: 0x00002798
		public static bool JOLEJMOJGMD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.BGGAEBOCGJG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t HEGMONHPLPF(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t JAMBFIOAJNM(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t CLCLLACDPIE(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t MDHKPHFGMDC(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000454C File Offset: 0x0000274C
		public int DLCBDAFFEIF(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000045A4 File Offset: 0x000027A4
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is SteamItemInstanceID_t && SteamItemInstanceID_t.MKGNKAMFMPG(this, (SteamItemInstanceID_t)LNBMEILJKDH);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool KJIGDINCECD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong NDKJBBBFHMJ(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000453C File Offset: 0x0000273C
		public bool Equals(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000045C1 File Offset: 0x000027C1
		public static bool NEFGNGBGAJI(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000453C File Offset: 0x0000273C
		public bool IKBKHIFDGKK(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000454C File Offset: 0x0000274C
		public int HIBAMBEBGFE(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000045CD File Offset: 0x000027CD
		public static bool BOOIHFPDBNE(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.CBMMJFPJEMP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000045D9 File Offset: 0x000027D9
		public static bool ACHMHFAOKEL(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.NCFJDOJPMLJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000045CD File Offset: 0x000027CD
		public static bool PFAANKCPAKD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.CBMMJFPJEMP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000045E5 File Offset: 0x000027E5
		public static bool ILNGPECJMGD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.HOPBDGPDMFI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t NNFBJDPEMAH(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000045F1 File Offset: 0x000027F1
		public static bool IMGNFFLCCIG(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.AFJCFLMANOK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t LIDCAILIGIK(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t GFMFFKFBOIA(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000453C File Offset: 0x0000273C
		public bool EMNFLNOILHJ(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000453C File Offset: 0x0000273C
		public bool KCAPPOKNPBN(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000454C File Offset: 0x0000274C
		public int MFKJDJPNECL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000454C File Offset: 0x0000274C
		public int OOOJMNPBGFC(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool AFJCFLMANOK(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong PJCFLLGPNKB(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool IGDLLAKOACE(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000454C File Offset: 0x0000274C
		public int GENCLGDMCPM(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000454C File Offset: 0x0000274C
		public int FIIHLFOLBBH(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000045FD File Offset: 0x000027FD
		public static bool AKCGBMIACGD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.CBMMJFPJEMP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00004609 File Offset: 0x00002809
		public static bool JHINANEEJMD(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.NCFJDOJPMLJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000454C File Offset: 0x0000274C
		public int MBDCDIAPPKN(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t BCNFICECAMF(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000453C File Offset: 0x0000273C
		public bool MMCLBBLECBG(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00004615 File Offset: 0x00002815
		public override int GetHashCode()
		{
			return this.m_SteamItemInstanceID.GetHashCode();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t LIGOIMKDILD(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000454C File Offset: 0x0000274C
		public int DBKEOFDLFGA(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t KGBGNMNLPKN(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t BNJHAOICCOF(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00004622 File Offset: 0x00002822
		public static bool JFPFILAOJMM(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.BGGAEBOCGJG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong CJBLMHBFKIL(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool CDNPFFJOFOM(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong PEAFCMBIENC(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool MKGNKAMFMPG(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool ICNKGHFFMFL(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000454C File Offset: 0x0000274C
		public int ICKNPJBLOOM(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool CBMMJFPJEMP(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000453C File Offset: 0x0000273C
		public bool BECNDLCCJPK(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000453C File Offset: 0x0000273C
		public bool BPPMMPGDDEM(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool LDMNACBGBPK(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool MDMEOBPEGFH(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong IGAJFACIMAH(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000454C File Offset: 0x0000274C
		public int CompareTo(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000462E File Offset: 0x0000282E
		public static bool GHLMENKNBCE(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.LDMNACBGBPK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool AHFPKACACBA(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000453C File Offset: 0x0000273C
		public bool NPFAFEKOJEL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool FOPAIHBJEFL(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t JGFNMAFFFIK(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t CNPAFOGFAIM(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000045D9 File Offset: 0x000027D9
		public static bool MGOELGLNPLE(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.NCFJDOJPMLJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t EFIDMFLMNJM(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000453C File Offset: 0x0000273C
		public bool JMABBCFMLKL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong KKNDHDNGALN(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000045CD File Offset: 0x000027CD
		public static bool DMGKEMPAGDP(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.CBMMJFPJEMP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong AIGHJLNLCOB(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong DJDKDNCPEIO(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool JFAMHEAILKL(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong LOEIJPMCCPF(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t PHDAOLLLEOA(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000045D9 File Offset: 0x000027D9
		public static bool AJEJKHILLCE(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.NCFJDOJPMLJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t DCPDCODLHJN(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t GADOGIBOENF(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00004648 File Offset: 0x00002848
		public static bool KFCFNBMJNEF(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.FOPAIHBJEFL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00004654 File Offset: 0x00002854
		public static bool PNPPOPMEIGG(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.JFAMHEAILKL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t NNJFABLFKDP(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00004528 File Offset: 0x00002728
		public static SteamItemInstanceID_t GGOHAPLJANG(ulong AJLPALFJHCC)
		{
			return new SteamItemInstanceID_t(AJLPALFJHCC);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004660 File Offset: 0x00002860
		public static bool LHHACIKDPOL(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.ICNKGHFFMFL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong MFJNOKJHHEP(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000466C File Offset: 0x0000286C
		public SteamItemInstanceID_t(ulong AJLPALFJHCC)
		{
			this.m_SteamItemInstanceID = AJLPALFJHCC;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000454C File Offset: 0x0000274C
		public int DIDNDFEIIPI(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000454C File Offset: 0x0000274C
		public int ABMBPDLEJLL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong ICIODPKFNBE(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000453C File Offset: 0x0000273C
		public static bool NCFJDOJPMLJ(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_SteamItemInstanceID == DEJFBNMNMOK.m_SteamItemInstanceID;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000455F File Offset: 0x0000275F
		public static ulong CCADGDCAMNN(SteamItemInstanceID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_SteamItemInstanceID;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000453C File Offset: 0x0000273C
		public bool LMJGCLHPCOL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000453C File Offset: 0x0000273C
		public bool GMLHOMEJKDG(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID == LNBMEILJKDH.m_SteamItemInstanceID;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000454C File Offset: 0x0000274C
		public int IIGHANNBMEL(SteamItemInstanceID_t LNBMEILJKDH)
		{
			return this.m_SteamItemInstanceID.CompareTo(LNBMEILJKDH.m_SteamItemInstanceID);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00004609 File Offset: 0x00002809
		public static bool AKCKCACICKH(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.NCFJDOJPMLJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00004675 File Offset: 0x00002875
		public static bool FGPBPPLPDJA(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return SteamItemInstanceID_t.AFJCFLMANOK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000045C1 File Offset: 0x000027C1
		public static bool DFDJEKOGCDC(SteamItemInstanceID_t OBNBCGOIMKE, SteamItemInstanceID_t DEJFBNMNMOK)
		{
			return !SteamItemInstanceID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x04000200 RID: 512
		public static readonly SteamItemInstanceID_t Invalid = new SteamItemInstanceID_t(ulong.MaxValue);

		// Token: 0x04000201 RID: 513
		public ulong m_SteamItemInstanceID;
	}
}
