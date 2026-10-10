using System;
using System.Collections.Generic;

// Token: 0x02000217 RID: 535
public class PFADAFAHNNJ : KGLBKJKNPFD
{
	// Token: 0x0600431C RID: 17180 RVA: 0x001D495C File Offset: 0x001D2B5C
	public PFADAFAHNNJ(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.chatMeta;
		this.APJLHOCPOEO = OFGJFNLDKGO;
		if (OFGJFNLDKGO.Contains("title"))
		{
			this.BPMFHNDCBOH = HLDNEMHDEDH.FOJFBLDNKDM(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "title(", ')', false), false);
		}
		if (OFGJFNLDKGO.Contains("speed"))
		{
			this.GINAOBOFOFC = StoryChatManager.StringToChatMessageInputSpeed(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "speed(", ')', true));
			if (this.GINAOBOFOFC != PAMDLEFCBDE.offscreen)
			{
				this.GINAOBOFOFC = PAMDLEFCBDE.fast;
			}
		}
		if (OFGJFNLDKGO.Contains("showtimestamps"))
		{
			this.IOCEDIDHFHP = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "showtimestamps(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("playericon"))
		{
			this.KOCJBOHLOFL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "playericon(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("systemicon"))
		{
			this.MAELLOMJANI = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "systemicon(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("shownames"))
		{
			this.GCMMCPMFJGB = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "shownames(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("isautomatic"))
		{
			this.EFBJNOAJGDA = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "isautomatic(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("sessionassets"))
		{
			this.GBCOOACIMIJ = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "sessionassets(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("isoffscreen"))
		{
			this.BPNGIDAMBEJ = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "isoffscreen(", ')', true) == 1);
		}
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x001D4B08 File Offset: 0x001D2D08
	public string HMBHMHHBNDK()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "ok";
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x001D4B6F File Offset: 0x001D2D6F
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x001D4B84 File Offset: 0x001D2D84
	public string LODHPDGOPNB()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "/";
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x001D4BEC File Offset: 0x001D2DEC
	public string IJKPGGOLOED()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return ";";
	}

	// Token: 0x06004321 RID: 17185 RVA: 0x001D4C54 File Offset: 0x001D2E54
	public string IADLDKKNMNF()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "ImageFrameAnimation - could not load HD sprite:";
	}

	// Token: 0x06004322 RID: 17186 RVA: 0x001D4CBC File Offset: 0x001D2EBC
	public string PIMDJFGNDFA()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "";
	}

	// Token: 0x06004323 RID: 17187 RVA: 0x001D4D24 File Offset: 0x001D2F24
	public string HDIOBBNKPLJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "MORPH_DISSOLVE";
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x001D4D8B File Offset: 0x001D2F8B
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (PFADAFAHNNJ.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x001D4D9C File Offset: 0x001D2F9C
	public string CJGEGNICDDN()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "abskt";
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x001D4E04 File Offset: 0x001D3004
	public string EGHGOIAPELO()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "StorySaveBody.DependsOnAvatarPackWardrobe(), unsupported wardrobe index:";
	}

	// Token: 0x06004327 RID: 17191 RVA: 0x001D4E6C File Offset: 0x001D306C
	public string FBGABIODNGJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "congratstitle";
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x001D4ED4 File Offset: 0x001D30D4
	public string NMKOHMMBFCL()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return "lck";
	}

	// Token: 0x06004329 RID: 17193 RVA: 0x001D4F3C File Offset: 0x001D313C
	public string GKGLFMMCBFP()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "areyousure";
	}

	// Token: 0x0600432A RID: 17194 RVA: 0x001D4FA4 File Offset: 0x001D31A4
	public string OJOMGCNHMLG()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "\"";
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x001D500C File Offset: 0x001D320C
	public string PMNBCJDOLIH()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return " has ";
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x001D5074 File Offset: 0x001D3274
	public string JADKBFALFCC()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "yes";
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x001D50DC File Offset: 0x001D32DC
	public string CEHIGEMEMHD()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "ffd496";
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x001D5144 File Offset: 0x001D3344
	public string MANLCGMDDNK()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return "XXX";
	}

	// Token: 0x0600432F RID: 17199 RVA: 0x001D51AC File Offset: 0x001D33AC
	public string MMLKDEBPODJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "energyhinttitle";
	}

	// Token: 0x06004330 RID: 17200 RVA: 0x001D5214 File Offset: 0x001D3414
	public string MNFFMGOOHLE()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return " (";
	}

	// Token: 0x06004331 RID: 17201 RVA: 0x001D527C File Offset: 0x001D347C
	public string PFLJLFGCIFB()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "string_not_found";
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x001D52E4 File Offset: 0x001D34E4
	public string GJPPCPBIOOO()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "_";
	}

	// Token: 0x06004333 RID: 17203 RVA: 0x001D534C File Offset: 0x001D354C
	public string KKEFGFAOKLK()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "{character}";
	}

	// Token: 0x06004334 RID: 17204 RVA: 0x001D53B4 File Offset: 0x001D35B4
	public string AONBMEECHOH()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return "w";
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x001D541C File Offset: 0x001D361C
	public string DBKGGCFHEGP()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return " ";
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x001D5484 File Offset: 0x001D3684
	public string CHACHFBKFJA()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "friendsoutofdatesuccess";
	}

	// Token: 0x06004337 RID: 17207 RVA: 0x001D54EC File Offset: 0x001D36EC
	public string PMBNPCCIHMN()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "AnthologySave.SetAvatarIndexAutoSuffix(), unsupported wardrobe index:";
	}

	// Token: 0x06004338 RID: 17208 RVA: 0x001D5554 File Offset: 0x001D3754
	public string AHDDFMHCDDJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return " npc(s) with a player-side dialog offset";
	}

	// Token: 0x06004339 RID: 17209 RVA: 0x001D55BC File Offset: 0x001D37BC
	public string HKNHDGCFIGJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return "Asset bundle assets destroyed:";
	}

	// Token: 0x0600433A RID: 17210 RVA: 0x001D5624 File Offset: 0x001D3824
	public string ALAGMBEKNLD()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "OnSettingsPopupClose";
	}

	// Token: 0x0600433B RID: 17211 RVA: 0x001D568C File Offset: 0x001D388C
	public string BKFLCAPHJCJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "StoriesSearchBalance: parse+build ";
	}

	// Token: 0x0600433C RID: 17212 RVA: 0x001D56F4 File Offset: 0x001D38F4
	public string GCMIJPHKHKI()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 1)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()])));
		}
		return "default";
	}

	// Token: 0x0600433D RID: 17213 RVA: 0x001D575C File Offset: 0x001D395C
	public string PLMNEAOCEEN()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()])));
		}
		return "p";
	}

	// Token: 0x0600433E RID: 17214 RVA: 0x001D57C4 File Offset: 0x001D39C4
	public string CPNCNBDEAOJ()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "ablpt";
	}

	// Token: 0x0600433F RID: 17215 RVA: 0x001D582C File Offset: 0x001D3A2C
	public string HMPNEBMJBBA()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.ONKDFADIANH(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "App42Manager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()";
	}

	// Token: 0x06004340 RID: 17216 RVA: 0x001D5894 File Offset: 0x001D3A94
	public string NCHAAAIEJMH()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "Error. PlayParticlesForEnvironmentLayer(), environmentLayer ";
	}

	// Token: 0x06004341 RID: 17217 RVA: 0x001D58FC File Offset: 0x001D3AFC
	public string HDNHFIPNDDC()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()].Length > 1)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.DCMOANEPFED(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()])));
		}
		return "doublerewardtut";
	}

	// Token: 0x06004342 RID: 17218 RVA: 0x001D5963 File Offset: 0x001D3B63
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == PFADAFAHNNJ.BMHGEBOHLHH.done;
	}

	// Token: 0x06004343 RID: 17219 RVA: 0x001D5970 File Offset: 0x001D3B70
	public string IKGENEOMJMP()
	{
		if (this.BPMFHNDCBOH != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()] != null && this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()].Length > 0)
		{
			return HLDNEMHDEDH.MMGPJMLJPNI(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(this.BPMFHNDCBOH[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()])));
		}
		return "loungeskinupdaterequired";
	}

	// Token: 0x06004344 RID: 17220 RVA: 0x001D59D7 File Offset: 0x001D3BD7
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06004345 RID: 17221 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x04001295 RID: 4757
	public PFADAFAHNNJ.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001296 RID: 4758
	public PAMDLEFCBDE GINAOBOFOFC = PAMDLEFCBDE.normal;

	// Token: 0x04001297 RID: 4759
	public bool IOCEDIDHFHP;

	// Token: 0x04001298 RID: 4760
	public string KOCJBOHLOFL = "";

	// Token: 0x04001299 RID: 4761
	public string MAELLOMJANI = "";

	// Token: 0x0400129A RID: 4762
	public bool GCMMCPMFJGB;

	// Token: 0x0400129B RID: 4763
	public bool EFBJNOAJGDA = true;

	// Token: 0x0400129C RID: 4764
	public bool BPNGIDAMBEJ;

	// Token: 0x0400129D RID: 4765
	public List<string> GBCOOACIMIJ = new List<string>();

	// Token: 0x0400129E RID: 4766
	public string APJLHOCPOEO = "";

	// Token: 0x0400129F RID: 4767
	private string[] BPMFHNDCBOH;

	// Token: 0x02000218 RID: 536
	public enum BMHGEBOHLHH
	{
		// Token: 0x040012A1 RID: 4769
		start,
		// Token: 0x040012A2 RID: 4770
		done
	}
}
