using System;

namespace Steamworks
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		// Token: 0x0600166C RID: 5740 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short EFIDMFLMNJM(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short FCCBKBMCOGK(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t GDLOOPECAGA(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00010C1B File Offset: 0x0000EE1B
		public static bool JEGAPAODOEO(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.ODGOMOKAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00010C27 File Offset: 0x0000EE27
		public static bool KNKAMCBMCHG(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.FCJCLJODCNM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t NBKEGKHGGOH(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t BDDFEOKMDML(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t KDMCDHGNCBF(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t HAIGBPCLLHH(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00010C33 File Offset: 0x0000EE33
		public static bool BNMAJJGIPCB(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.EBAKFMGADFF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short OMOGNLKCNAE(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool IGDLLAKOACE(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool Equals(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool DDGCIIFCECG(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool NMOCADNHGKO(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool FCOIKLGNLFL(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00010C4F File Offset: 0x0000EE4F
		public static bool KIEPNGPPNPC(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.PCGMFCMHEDO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool BKJDCJCOOBJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int FEAMPHPBLDN(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool GDLLFNJOOMO(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool MHGMNCNIPBF(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00010C6E File Offset: 0x0000EE6E
		public override int GetHashCode()
		{
			return this.m_FriendsGroupID.GetHashCode();
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool GDNFPHPKIHC(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00010C7B File Offset: 0x0000EE7B
		public static bool FEBLNNBLGEA(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return FriendsGroupID_t.CBHLAPAEMOG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short ECPEBBPPHMN(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool KMGLKIINEPE(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool FKJDDCCINJK(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int IIGHANNBMEL(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool MFHMLODHJGH(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short PEAFCMBIENC(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int JHOEELHBEJJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool PCGMFCMHEDO(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool JAOEPHBONBJ(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short MDEEAEPDOPL(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t LHKLDDEFGFE(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t LIDCAILIGIK(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool DEJOOBGLHCH(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00010C87 File Offset: 0x0000EE87
		public static bool PLDCHLDNHFD(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.NMKJEOKFPAK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool BNKMHIALFMD(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool JJCFHGAJKDM(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool OAKKABIOMPN(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00010C93 File Offset: 0x0000EE93
		public static bool BDNKDLDIADM(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return FriendsGroupID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool ODGOMOKAIBF(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short DCPDCODLHJN(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int EAIONIMGOKH(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00010C27 File Offset: 0x0000EE27
		public static bool FGPBPPLPDJA(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.FCJCLJODCNM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int KLEEFPADJEE(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00010C27 File Offset: 0x0000EE27
		public static bool OINOBHGJEJK(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.FCJCLJODCNM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short ICIODPKFNBE(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool EBAKFMGADFF(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool NLLAAFKMDGB(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int PCBKMJJBDGL(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short LDPFIFCFHIE(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short MACEAPLGLIL(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t KGBGNMNLPKN(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool CBMMJFPJEMP(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int DNKBAHANKHA(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool LMJGCLHPCOL(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t LKNOJDPCCED(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00010C9F File Offset: 0x0000EE9F
		public static bool DFBOPLBLCLI(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return FriendsGroupID_t.DDGCIIFCECG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short BNJHAOICCOF(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short KKNDHDNGALN(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool GDCLCOGHFLJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t GDMEOLEOLGI(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short NHFENIAGPGH(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool DPNFHEACCEH(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00010CAB File Offset: 0x0000EEAB
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is FriendsGroupID_t && FriendsGroupID_t.MKGNKAMFMPG(this, (FriendsGroupID_t)LNBMEILJKDH);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short OFOPKGCKJMB(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int OEEAHJJOGHI(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool HJGFMONAIBF(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int CompareTo(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool NMKJEOKFPAK(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool COFGAMEDKMK(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int CPNDMGIBJAI(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t CJBHKNNBEKD(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t IGAJFACIMAH(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00010CD5 File Offset: 0x0000EED5
		public static bool BBLAEPJHKEE(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.POOPLDLDIEE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool CBHLAPAEMOG(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t OLDLOCJALFC(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00010CE1 File Offset: 0x0000EEE1
		public static bool GHLMENKNBCE(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return FriendsGroupID_t.IIHMLPBMEJB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short CNPAFOGFAIM(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int ECHAAFAAPPJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00010CED File Offset: 0x0000EEED
		public static bool MAMNJIDPNME(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.CBHLAPAEMOG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short EOLJJPADGDN(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t MPOEPCABICJ(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool PDEIGPLPAJC(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool CAGEBEMJDMJ(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool CDNPFFJOFOM(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool FCNDJIIPGEK(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t MFKKKOBBPNG(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool JNHLJCMDCNF(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int ABJCOGNCMEJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool GDCCHMCAOGA(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public static bool LPHKOLIFFNO(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short IILDEMMMPHE(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool MKIJFNEMLLO(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short JMOHKKGFEAB(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00010C1B File Offset: 0x0000EE1B
		public static bool OLLJJHFPAJP(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.ODGOMOKAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool POOPLDLDIEE(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00010C5B File Offset: 0x0000EE5B
		public int FJPFHEBNICF(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID.CompareTo(LNBMEILJKDH.m_FriendsGroupID);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short BFKCGOCPDHP(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool FCJCLJODCNM(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00010D05 File Offset: 0x0000EF05
		public static bool LCEMKOGDPMF(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.HJGFMONAIBF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool EOKAGCFACDP(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00010D11 File Offset: 0x0000EF11
		public override string ToString()
		{
			return this.m_FriendsGroupID.ToString();
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool IABGALDFLEJ(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short HEGMONHPLPF(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public bool NNLBEINPECL(FriendsGroupID_t LNBMEILJKDH)
		{
			return this.m_FriendsGroupID == LNBMEILJKDH.m_FriendsGroupID;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t PEAFCMBIENC(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00010CED File Offset: 0x0000EEED
		public static bool HCCJEBOKDIH(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.CBHLAPAEMOG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00010D1E File Offset: 0x0000EF1E
		public FriendsGroupID_t(short AJLPALFJHCC)
		{
			this.m_FriendsGroupID = AJLPALFJHCC;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool MKGNKAMFMPG(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static short FLOCHBNBGOI(FriendsGroupID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_FriendsGroupID;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00010D27 File Offset: 0x0000EF27
		public static bool NEFGNGBGAJI(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return !FriendsGroupID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static bool IIHMLPBMEJB(FriendsGroupID_t OBNBCGOIMKE, FriendsGroupID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_FriendsGroupID == DEJFBNMNMOK.m_FriendsGroupID;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00010C13 File Offset: 0x0000EE13
		public static FriendsGroupID_t LOEIJPMCCPF(short AJLPALFJHCC)
		{
			return new FriendsGroupID_t(AJLPALFJHCC);
		}

		// Token: 0x040006FF RID: 1791
		public static readonly FriendsGroupID_t Invalid = new FriendsGroupID_t(-1);

		// Token: 0x04000700 RID: 1792
		public short m_FriendsGroupID;
	}
}
