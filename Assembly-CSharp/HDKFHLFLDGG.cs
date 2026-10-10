using System;
using System.Collections.Generic;
using Ink.Runtime;

// Token: 0x020004EE RID: 1262
public class HDKFHLFLDGG : KGLBKJKNPFD
{
	// Token: 0x06009894 RID: 39060 RVA: 0x00427FE9 File Offset: 0x004261E9
	public string JJJJHGJHGJP()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x06009895 RID: 39061 RVA: 0x00427FFC File Offset: 0x004261FC
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (HDKFHLFLDGG.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06009896 RID: 39062 RVA: 0x0042800C File Offset: 0x0042620C
	public HDKFHLFLDGG(string OFGJFNLDKGO, List<string> GFNFGKJAILF, List<Choice> MJGEGLHLNNJ)
	{
		HLDNEMHDEDH.OODFOAELBEA = HLDNEMHDEDH.CJFFKMIHFJJ;
		if (GFNFGKJAILF.Contains("bubble"))
		{
			this.GJOCJINDEIF = true;
			GFNFGKJAILF.Remove("bubble");
		}
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		for (int i = 0; i < GFNFGKJAILF.Count; i++)
		{
			if (!GFNFGKJAILF[i].StartsWith("hint"))
			{
				list.Add(GFNFGKJAILF[i]);
			}
			else
			{
				list2.Add(GFNFGKJAILF[i]);
			}
		}
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.dialogPlayerCharacter;
		this.LECOLKOALNK = HLDNEMHDEDH.JLMFPJPBOKP(list).ToString();
		this.EMMOPBJCKGE = HLDNEMHDEDH.JLMFPJPBOKP(list).ToString();
		this.JLEAIJGBGHL = HLDNEMHDEDH.APCMLPBJHIJ(list);
		this.LPLILOPPNMN = HLDNEMHDEDH.LBIMDPEIOBD(list);
		this.COEFNFJMBDG = new List<OCCBADNHFHK>();
		for (int j = 0; j < MJGEGLHLNNJ.Count; j++)
		{
			OCCBADNHFHK occbadnhfhk = new OCCBADNHFHK();
			if (j == PGFFKNAEFDE.GEAOHJKJOOP)
			{
				occbadnhfhk.BEHENEHGPCP = true;
			}
			occbadnhfhk.OKFHBICNAPN = MJGEGLHLNNJ[j];
			occbadnhfhk.KIPCNAMEGPD = HLDNEMHDEDH.FOJFBLDNKDM(MJGEGLHLNNJ[j].text, false);
			occbadnhfhk.DBACMDJJPCL();
			try
			{
				if (1 == KGLBKJKNPFD.ALLDBPCKMLF && j < list2.Count)
				{
					occbadnhfhk.PDIBBBDINLE = HLDNEMHDEDH.CCNGBGGOBBF(list2[j]);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.COEFNFJMBDG.Add(occbadnhfhk);
		}
		PGFFKNAEFDE.GEAOHJKJOOP = -1;
		string[] array = HLDNEMHDEDH.FOJFBLDNKDM(OFGJFNLDKGO, true);
		this.KIPCNAMEGPD = new string[32];
		this.ODGNIFJGEHL = new string[32];
		for (int k = 0; k < 32; k++)
		{
			string[] array2 = HLDNEMHDEDH.BEOMDECMOJH(HLDNEMHDEDH.JENMHBDOLJB(HLDNEMHDEDH.AOJKJGJFCKB(HLDNEMHDEDH.GKECDIMMJEO(array[k]))));
			this.ODGNIFJGEHL[k] = array2[1];
			if (array2[0].Contains("\\\""))
			{
				this.KIPCNAMEGPD[k] = array2[0].Replace("\\\"", "\"");
			}
			else
			{
				this.KIPCNAMEGPD[k] = array2[0];
			}
		}
		for (int l = 0; l < 32; l++)
		{
			if (this.ODGNIFJGEHL[l].Length == 0 && this.KIPCNAMEGPD[l].Length != 0)
			{
				for (int m = 0; m < 32; m++)
				{
					if (this.ODGNIFJGEHL[m].Length != 0)
					{
						this.ODGNIFJGEHL[l] = this.ODGNIFJGEHL[m];
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009897 RID: 39063 RVA: 0x00428300 File Offset: 0x00426500
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == HDKFHLFLDGG.BMHGEBOHLHH.done;
	}

	// Token: 0x06009898 RID: 39064 RVA: 0x00427FE9 File Offset: 0x004261E9
	public string IKKEELKJAKE()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x06009899 RID: 39065 RVA: 0x0042830B File Offset: 0x0042650B
	public string GMAJGIMHNDH()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()];
	}

	// Token: 0x0600989A RID: 39066 RVA: 0x0042831E File Offset: 0x0042651E
	public void HHDOEDDHLBO(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnStorySplashManagerAssetBundleFolderInitializeSuccess");
		}
	}

	// Token: 0x0600989B RID: 39067 RVA: 0x00428356 File Offset: 0x00426556
	public string HEGHGFCLCFC()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x0600989C RID: 39068 RVA: 0x00428369 File Offset: 0x00426569
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600989D RID: 39069 RVA: 0x00428381 File Offset: 0x00426581
	public override bool PINCOCDOOGH()
	{
		return this.BOPJOMGIJIA == HDKFHLFLDGG.BMHGEBOHLHH.waitForInput;
	}

	// Token: 0x0600989E RID: 39070 RVA: 0x00428356 File Offset: 0x00426556
	public string DNLHIMDGNMC()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x0600989F RID: 39071 RVA: 0x0042838C File Offset: 0x0042658C
	public string KLBODOJGBIE()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x060098A0 RID: 39072 RVA: 0x0042839F File Offset: 0x0042659F
	public string JLFFLIGEPML()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x060098A1 RID: 39073 RVA: 0x004283B2 File Offset: 0x004265B2
	public void IDDJHHDLGHL(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("trsv");
		}
	}

	// Token: 0x060098A2 RID: 39074 RVA: 0x004283EA File Offset: 0x004265EA
	public string DGBGJOAKOCN()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098A3 RID: 39075 RVA: 0x0042838C File Offset: 0x0042658C
	public string PBDGCNGPCLO()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x060098A4 RID: 39076 RVA: 0x004283FD File Offset: 0x004265FD
	public void FCFEDPDDHGP(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ok");
		}
	}

	// Token: 0x060098A5 RID: 39077 RVA: 0x00428435 File Offset: 0x00426635
	public void KMIKMEMOMDM(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceAutoReaderStop");
		}
	}

	// Token: 0x060098A6 RID: 39078 RVA: 0x004283EA File Offset: 0x004265EA
	public string FHOBNLGIFLH()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098A7 RID: 39079 RVA: 0x00427FE9 File Offset: 0x004261E9
	public string GBHFGINNPPD()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098A8 RID: 39080 RVA: 0x004283EA File Offset: 0x004265EA
	public string NFKCEODACPH()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098A9 RID: 39081 RVA: 0x0042846D File Offset: 0x0042666D
	public string CKFCPOBEBCJ()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()];
	}

	// Token: 0x060098AA RID: 39082 RVA: 0x00428480 File Offset: 0x00426680
	public void ADHDBAMBEGC(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("copyuidbtn");
		}
	}

	// Token: 0x060098AB RID: 39083 RVA: 0x00428356 File Offset: 0x00426556
	public string KJPNLHDLEMB()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098AC RID: 39084 RVA: 0x0042839F File Offset: 0x0042659F
	public string EDANPBBELKO()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x060098AD RID: 39085 RVA: 0x0042838C File Offset: 0x0042658C
	public string DAHHKJKDHEF()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x060098AE RID: 39086 RVA: 0x00427FE9 File Offset: 0x004261E9
	public string MEFJJHPACAK()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098AF RID: 39087 RVA: 0x004284B8 File Offset: 0x004266B8
	public string ILOMFIAJHNC()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098B0 RID: 39088 RVA: 0x004284B8 File Offset: 0x004266B8
	public string GFJAMENKEKO()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098B1 RID: 39089 RVA: 0x004284CB File Offset: 0x004266CB
	public void IKNCHNAGLMK(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryStepDialogPlayerCharacter.RemoveChoiceAtEnd - _choicesToRemove is <= 0.");
		}
	}

	// Token: 0x060098B2 RID: 39090 RVA: 0x004284B8 File Offset: 0x004266B8
	public string MFGBFDAPKML()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098B3 RID: 39091 RVA: 0x00428503 File Offset: 0x00426703
	public void MJDNFOBAMAP(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("VideoGlitches.VideoGlitch");
		}
	}

	// Token: 0x060098B4 RID: 39092 RVA: 0x0042853B File Offset: 0x0042673B
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060098B5 RID: 39093 RVA: 0x0042854E File Offset: 0x0042674E
	public void AMDHAHBLDEB(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("npcpi");
		}
	}

	// Token: 0x060098B6 RID: 39094 RVA: 0x00428586 File Offset: 0x00426786
	public override void IABNDHFJHAF(int MEFKFOHCOHK)
	{
		this.BCDFDBNAIJF = MEFKFOHCOHK;
	}

	// Token: 0x060098B7 RID: 39095 RVA: 0x00428356 File Offset: 0x00426556
	public string JDFNPLALAOH()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098B8 RID: 39096 RVA: 0x00427FE9 File Offset: 0x004261E9
	public string FHGLJMKPBDH()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098B9 RID: 39097 RVA: 0x0042858F File Offset: 0x0042678F
	public void GKCBJHPMBDM(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnFullscreenCardOptionClick");
		}
	}

	// Token: 0x060098BA RID: 39098 RVA: 0x004285C7 File Offset: 0x004267C7
	public void BBMCKPDNNFM(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("...");
		}
	}

	// Token: 0x060098BB RID: 39099 RVA: 0x004284B8 File Offset: 0x004266B8
	public string NEANAPPJBAN()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098BC RID: 39100 RVA: 0x004285FF File Offset: 0x004267FF
	public void LNEAGMFNKJH(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnRewardReplayEpisodeClick");
		}
	}

	// Token: 0x060098BD RID: 39101 RVA: 0x00428637 File Offset: 0x00426837
	public void MPHEAGJJEHC(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("$RESTOREENVSNAPSHOT");
		}
	}

	// Token: 0x060098BE RID: 39102 RVA: 0x0042846D File Offset: 0x0042666D
	public string GCJGMDGJNLH()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()];
	}

	// Token: 0x060098BF RID: 39103 RVA: 0x0042866F File Offset: 0x0042686F
	public void JGHHHKKLEGE(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
	}

	// Token: 0x060098C0 RID: 39104 RVA: 0x0042866F File Offset: 0x0042686F
	public void FCJNEEOLMCK(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
	}

	// Token: 0x060098C1 RID: 39105 RVA: 0x004283EA File Offset: 0x004265EA
	public string DKEOPDAFLNO()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.GetSelectedLanguage()];
	}

	// Token: 0x060098C2 RID: 39106 RVA: 0x0042866F File Offset: 0x0042686F
	public void AHFILJIJHBA(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 0)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
		}
	}

	// Token: 0x060098C3 RID: 39107 RVA: 0x00428356 File Offset: 0x00426556
	public string PPGJBLLIHHO()
	{
		return this.ODGNIFJGEHL[(int)LanguageManager.EHBBFMCILPC.MLOLBFBODHD()];
	}

	// Token: 0x060098C4 RID: 39108 RVA: 0x004286A7 File Offset: 0x004268A7
	public void OKDAPLFFJAI(int JLCNMLEBLPE)
	{
		if (JLCNMLEBLPE > 1)
		{
			if (this.COEFNFJMBDG.Count > JLCNMLEBLPE)
			{
				this.COEFNFJMBDG.RemoveRange(this.COEFNFJMBDG.Count - JLCNMLEBLPE, JLCNMLEBLPE);
				return;
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneLobbyManager2.BuildGroupedParent() - Resources prefab missing (GroupedParent / CoverCard), run ROMANCE/Debug/Lobby/Build cover card prefabs");
		}
	}

	// Token: 0x060098C5 RID: 39109 RVA: 0x004286DF File Offset: 0x004268DF
	public override int EKOIFOBAHDM()
	{
		return this.BCDFDBNAIJF;
	}

	// Token: 0x060098C6 RID: 39110 RVA: 0x0042846D File Offset: 0x0042666D
	public string OJBEMAINAFK()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()];
	}

	// Token: 0x060098C7 RID: 39111 RVA: 0x0042839F File Offset: 0x0042659F
	public string PCNBFOOEPID()
	{
		return this.KIPCNAMEGPD[(int)LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()];
	}

	// Token: 0x04002A05 RID: 10757
	private string[] KIPCNAMEGPD;

	// Token: 0x04002A06 RID: 10758
	private string[] ODGNIFJGEHL;

	// Token: 0x04002A07 RID: 10759
	private int BCDFDBNAIJF = -1;

	// Token: 0x04002A08 RID: 10760
	public PMNHKIDIMLM JMNMOHIKHLB;

	// Token: 0x04002A09 RID: 10761
	public string LECOLKOALNK = FLNOFHCNJDM.neutral.ToString();

	// Token: 0x04002A0A RID: 10762
	public string EMMOPBJCKGE = FLNOFHCNJDM.neutral.ToString();

	// Token: 0x04002A0B RID: 10763
	public HDKFHLFLDGG.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04002A0C RID: 10764
	public List<OCCBADNHFHK> COEFNFJMBDG = new List<OCCBADNHFHK>();

	// Token: 0x04002A0D RID: 10765
	public string JLEAIJGBGHL = "";

	// Token: 0x04002A0E RID: 10766
	public string LPLILOPPNMN = "";

	// Token: 0x04002A0F RID: 10767
	public bool GJOCJINDEIF;

	// Token: 0x020004EF RID: 1263
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002A11 RID: 10769
		show,
		// Token: 0x04002A12 RID: 10770
		waitForEnvmove,
		// Token: 0x04002A13 RID: 10771
		showCharacter,
		// Token: 0x04002A14 RID: 10772
		waitForInput,
		// Token: 0x04002A15 RID: 10773
		executeChoice,
		// Token: 0x04002A16 RID: 10774
		hide,
		// Token: 0x04002A17 RID: 10775
		done
	}
}
