using System;

namespace Steamworks
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x0001310E File Offset: 0x0001130E
		public static bool ICJDJJABLCH(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.KJIGDINCECD(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0001311A File Offset: 0x0001131A
		public int NOEOIFCMOJA(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint GDLOOPECAGA(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint PEAFCMBIENC(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00013135 File Offset: 0x00011335
		public override int GetHashCode()
		{
			return this.m_AppId.GetHashCode();
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint ECPEBBPPHMN(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00013142 File Offset: 0x00011342
		public static bool JHEELDCJJCN(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return AppId_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0001314E File Offset: 0x0001134E
		public bool IIMFAIFNACE(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0001311A File Offset: 0x0001131A
		public int ENGDBAPNJIF(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0001315E File Offset: 0x0001135E
		public static bool IPHIKMKINFF(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0001314E File Offset: 0x0001134E
		public bool OAKKABIOMPN(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t KKNDHDNGALN(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint JHKPJDENLLN(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0001311A File Offset: 0x0001131A
		public int FOLBCOLPIJA(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00013172 File Offset: 0x00011372
		public static bool OPFKIHFEGFN(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return AppId_t.ALFPOHOCKDE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0001314E File Offset: 0x0001134E
		public bool DDKIFFMKCOK(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t GFMFFKFBOIA(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t CNPAFOGFAIM(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0001311A File Offset: 0x0001131A
		public int COBNKIJOMII(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0001314E File Offset: 0x0001134E
		public bool NNNJNIOCEPA(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool IGDLLAKOACE(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0001317E File Offset: 0x0001137E
		public static bool MJILGIMAPCM(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.CNNMIMNJNHI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t PEAFCMBIENC(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0001318A File Offset: 0x0001138A
		public static bool IMGNFFLCCIG(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool LJKJMNKEKMF(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0001311A File Offset: 0x0001131A
		public int MCKJNGNNJMK(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0001311A File Offset: 0x0001131A
		public int FLDAOGDJFIP(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0001311A File Offset: 0x0001131A
		public int FJPFHEBNICF(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t CJBHKNNBEKD(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t LPPIBELHJKB(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool ALFPOHOCKDE(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t PKJMBHJMNGD(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0001314E File Offset: 0x0001134E
		public bool MBGGHPHHCLB(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0001311A File Offset: 0x0001131A
		public int BLNCOMNPMFG(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0001314E File Offset: 0x0001134E
		public bool EKEPMIJHKEP(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0001314E File Offset: 0x0001134E
		public bool DMAEMGGDCCO(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool KJIGDINCECD(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0001314E File Offset: 0x0001134E
		public bool NBJIKEJCHCJ(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint BDDFEOKMDML(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0001311A File Offset: 0x0001131A
		public int INBBOPIDLHP(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00013196 File Offset: 0x00011396
		public AppId_t(uint AJLPALFJHCC)
		{
			this.m_AppId = AJLPALFJHCC;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0001319F File Offset: 0x0001139F
		public static bool PJAPLIAIDCM(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.ALFPOHOCKDE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool CNNMIMNJNHI(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0001311A File Offset: 0x0001131A
		public int LLALNDOBHAB(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool PEKPHJBBIGP(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t MDHKPHFGMDC(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000131AB File Offset: 0x000113AB
		public override string ToString()
		{
			return this.m_AppId.ToString();
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0001314E File Offset: 0x0001134E
		public bool BNKMHIALFMD(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool NFDGMMCNNMN(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0001314E File Offset: 0x0001134E
		public bool IDPPEPEAHIC(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0001311A File Offset: 0x0001131A
		public int HFEKCDNFIEB(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000131B8 File Offset: 0x000113B8
		public static bool NEFGNGBGAJI(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0001311A File Offset: 0x0001131A
		public int CompareTo(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t HAIGBPCLLHH(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint EFIDMFLMNJM(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0001311A File Offset: 0x0001131A
		public int OLNHGLBEMHJ(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool POOPLDLDIEE(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0001314E File Offset: 0x0001134E
		public bool Equals(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0001314E File Offset: 0x0001134E
		public bool IJMIHAGGAJM(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000131C4 File Offset: 0x000113C4
		public static bool OINOBHGJEJK(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.POOPLDLDIEE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool MDMEOBPEGFH(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0001314E File Offset: 0x0001134E
		public bool HJMLEBEHMFA(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId == LNBMEILJKDH.m_AppId;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0001311A File Offset: 0x0001131A
		public int FPGCPBNLBCL(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t CJBLMHBFKIL(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool MKGNKAMFMPG(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_AppId == DEJFBNMNMOK.m_AppId;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t MDEEAEPDOPL(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0001311A File Offset: 0x0001131A
		public int IIGHANNBMEL(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0001312D File Offset: 0x0001132D
		public static uint MEIBALKJPLN(AppId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_AppId;
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0001316A File Offset: 0x0001136A
		public static AppId_t LOEIJPMCCPF(uint AJLPALFJHCC)
		{
			return new AppId_t(AJLPALFJHCC);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000131D0 File Offset: 0x000113D0
		public static bool NPEKIIDAPNG(AppId_t OBNBCGOIMKE, AppId_t DEJFBNMNMOK)
		{
			return !AppId_t.LJKJMNKEKMF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0001311A File Offset: 0x0001131A
		public int KGEIINKILIN(AppId_t LNBMEILJKDH)
		{
			return this.m_AppId.CompareTo(LNBMEILJKDH.m_AppId);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000131DC File Offset: 0x000113DC
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is AppId_t && AppId_t.MKGNKAMFMPG(this, (AppId_t)LNBMEILJKDH);
		}

		// Token: 0x04000829 RID: 2089
		public static readonly AppId_t Invalid = new AppId_t(0U);

		// Token: 0x0400082A RID: 2090
		public uint m_AppId;
	}
}
