using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000401 RID: 1025
[CreateAssetMenu(fileName = "assetStoryXHeader", menuName = "ROMANCE/Create assetStoryXHeader", order = 1)]
public class AssetStoryHeader : ScriptableObject
{
	// Token: 0x060079C5 RID: 31173 RVA: 0x00365B60 File Offset: 0x00363D60
	public bool NHBCLDPLKBF(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079C6 RID: 31174 RVA: 0x00365BAC File Offset: 0x00363DAC
	public int ICDLPKJOHCM(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 0].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -106;
		}
		return result;
	}

	// Token: 0x060079C7 RID: 31175 RVA: 0x00365C0C File Offset: 0x00363E0C
	public StoryInkRevision2 LFHIHHDHNAM(int BNNFKGBCEGK)
	{
		for (int i = 0; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079C8 RID: 31176 RVA: 0x00365C88 File Offset: 0x00363E88
	public bool BNAEILFAGNH(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079C9 RID: 31177 RVA: 0x00365CD3 File Offset: 0x00363ED3
	public bool BLJCOOCIJBE(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP >= this.availableChaptersCount && this.availableChaptersCount != this.totalChaptersCount;
	}

	// Token: 0x060079CA RID: 31178 RVA: 0x00365CEF File Offset: 0x00363EEF
	public bool OJIMPEINHOK(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP > this.totalChaptersCount - 1;
	}

	// Token: 0x060079CB RID: 31179 RVA: 0x00365D00 File Offset: 0x00363F00
	public StoryInkRevision2 LMIJEAFGPPN(int BNNFKGBCEGK)
	{
		for (int i = 0; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079CC RID: 31180 RVA: 0x00365D7C File Offset: 0x00363F7C
	public bool BLILEMBPHMN(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079CD RID: 31181 RVA: 0x00365DC8 File Offset: 0x00363FC8
	public bool LIHFIHPCBMG(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079CE RID: 31182 RVA: 0x00365E14 File Offset: 0x00364014
	public bool KCEEJAEGNJA(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079CF RID: 31183 RVA: 0x00365E5F File Offset: 0x0036405F
	public bool KHLFABAALCG(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 1 || true;
	}

	// Token: 0x060079D0 RID: 31184 RVA: 0x00365E70 File Offset: 0x00364070
	public bool MFNODJIFMON(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079D1 RID: 31185 RVA: 0x00365EBB File Offset: 0x003640BB
	public bool DHIPCIOEJPP(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP < this.availableChaptersCount || this.availableChaptersCount == this.totalChaptersCount || true;
	}

	// Token: 0x060079D2 RID: 31186 RVA: 0x00365ED8 File Offset: 0x003640D8
	public int DIBLLNJEPOM(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 0].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -103;
		}
		return result;
	}

	// Token: 0x060079D3 RID: 31187 RVA: 0x00365F38 File Offset: 0x00364138
	public int HEJNHAFGMPI(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 1].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -61;
		}
		return result;
	}

	// Token: 0x060079D4 RID: 31188 RVA: 0x00365F98 File Offset: 0x00364198
	public bool HCLHALPFGND(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079D5 RID: 31189 RVA: 0x00365FE3 File Offset: 0x003641E3
	public bool JHJPKMCPAPJ(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 0 || true;
	}

	// Token: 0x060079D6 RID: 31190 RVA: 0x00365FF4 File Offset: 0x003641F4
	public bool IJIKAALOJOK(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079D7 RID: 31191 RVA: 0x00366040 File Offset: 0x00364240
	public bool OLNBLEMFABD(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079D8 RID: 31192 RVA: 0x0036608B File Offset: 0x0036428B
	public bool MJMBJNBDALG(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP < this.availableChaptersCount || this.availableChaptersCount == this.totalChaptersCount;
	}

	// Token: 0x060079D9 RID: 31193 RVA: 0x00365E5F File Offset: 0x0036405F
	public bool IEAGDNKFBFD(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 1 || true;
	}

	// Token: 0x060079DA RID: 31194 RVA: 0x00365CEF File Offset: 0x00363EEF
	public bool MLGKEPJPICJ(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP > this.totalChaptersCount - 1;
	}

	// Token: 0x060079DB RID: 31195 RVA: 0x003660A8 File Offset: 0x003642A8
	public int FCBMDEBBGPB(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 1].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -22;
		}
		return result;
	}

	// Token: 0x060079DC RID: 31196 RVA: 0x00366108 File Offset: 0x00364308
	public bool KEGEPFCLMCK(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079DD RID: 31197 RVA: 0x00366154 File Offset: 0x00364354
	public StoryInkRevision2 NGHBLAOGOIF(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 1; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079DE RID: 31198 RVA: 0x003661D0 File Offset: 0x003643D0
	public bool IENMBMBGCLD(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079DF RID: 31199 RVA: 0x00365CD3 File Offset: 0x00363ED3
	public bool OAJGLLHCBAB(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP >= this.availableChaptersCount && this.availableChaptersCount != this.totalChaptersCount;
	}

	// Token: 0x060079E0 RID: 31200 RVA: 0x0036621C File Offset: 0x0036441C
	public bool INPBMNHOLOJ(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079E1 RID: 31201 RVA: 0x00366268 File Offset: 0x00364468
	public int MGLOJOMFIBK(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 0].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = 41;
		}
		return result;
	}

	// Token: 0x060079E2 RID: 31202 RVA: 0x003662C8 File Offset: 0x003644C8
	public int JDDBIFCPAAI(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 0].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 47;
		}
		return result;
	}

	// Token: 0x060079E3 RID: 31203 RVA: 0x00366328 File Offset: 0x00364528
	public StoryInkRevision2 OGELHDPHMAG(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079E4 RID: 31204 RVA: 0x003663A4 File Offset: 0x003645A4
	public StoryInkRevision2 IKDDDBMLCJB(int BNNFKGBCEGK)
	{
		for (int i = 0; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079E6 RID: 31206 RVA: 0x0036608B File Offset: 0x0036428B
	public bool HKHGBJLFNOO(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP < this.availableChaptersCount || this.availableChaptersCount == this.totalChaptersCount;
	}

	// Token: 0x060079E7 RID: 31207 RVA: 0x00366444 File Offset: 0x00364644
	public bool DGLBGCODMNH(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060079E8 RID: 31208 RVA: 0x00366490 File Offset: 0x00364690
	public bool MPPBNIGLIJP(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079E9 RID: 31209 RVA: 0x003664DC File Offset: 0x003646DC
	public int EJPLMFAOJIB(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 1].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 100;
		}
		return result;
	}

	// Token: 0x060079EA RID: 31210 RVA: 0x0036653C File Offset: 0x0036473C
	public bool PHCAGLECBFC(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079EB RID: 31211 RVA: 0x00366588 File Offset: 0x00364788
	public StoryInkRevision2 IHDFJIKKJPG(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 1; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079EC RID: 31212 RVA: 0x00366604 File Offset: 0x00364804
	public int GHJMCFNONIM(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 0].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = -21;
		}
		return result;
	}

	// Token: 0x060079ED RID: 31213 RVA: 0x00366664 File Offset: 0x00364864
	public bool CMAEHIJOIKG(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x003666B0 File Offset: 0x003648B0
	public bool CPHIFFFIKLP(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079EF RID: 31215 RVA: 0x003666FC File Offset: 0x003648FC
	public bool PPLKFMCHBHI(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079F0 RID: 31216 RVA: 0x00365E5F File Offset: 0x0036405F
	public bool OAOGNCNEIPE(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 1 || true;
	}

	// Token: 0x060079F1 RID: 31217 RVA: 0x00366748 File Offset: 0x00364948
	public bool LJLAICBFLJP(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060079F2 RID: 31218 RVA: 0x00366794 File Offset: 0x00364994
	public bool IKJGNMFHANI(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079F3 RID: 31219 RVA: 0x003667DF File Offset: 0x003649DF
	public bool NJBGKLBFIFH(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 1;
	}

	// Token: 0x060079F4 RID: 31220 RVA: 0x003667F0 File Offset: 0x003649F0
	public bool APMNKLEJFLA(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079F5 RID: 31221 RVA: 0x0036683C File Offset: 0x00364A3C
	public bool GHAEJDKHAFD(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079F6 RID: 31222 RVA: 0x00366888 File Offset: 0x00364A88
	public StoryInkRevision2 ECDNLLDDMEA(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079F7 RID: 31223 RVA: 0x00366904 File Offset: 0x00364B04
	public bool CLOFNEDKIDH(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060079F8 RID: 31224 RVA: 0x00365CD3 File Offset: 0x00363ED3
	public bool OAIJCIKMCBO(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP >= this.availableChaptersCount && this.availableChaptersCount != this.totalChaptersCount;
	}

	// Token: 0x060079F9 RID: 31225 RVA: 0x00366950 File Offset: 0x00364B50
	public StoryInkRevision2 LBDEALNNEBA(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 1; j < this.chapterAssetPacks[i].inkRevisions.Count; j += 0)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079FA RID: 31226 RVA: 0x003669CC File Offset: 0x00364BCC
	public StoryInkRevision2 MPEEECJPFLA(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i += 0)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079FB RID: 31227 RVA: 0x00366A48 File Offset: 0x00364C48
	public bool JBEHHEDLMIO(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060079FC RID: 31228 RVA: 0x00366A93 File Offset: 0x00364C93
	public bool LJPLFIMOGGC(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 0;
	}

	// Token: 0x060079FD RID: 31229 RVA: 0x00366AA4 File Offset: 0x00364CA4
	public StoryInkRevision2 MNHHMKFBHDH(int BNNFKGBCEGK)
	{
		for (int i = 0; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x060079FE RID: 31230 RVA: 0x00366B20 File Offset: 0x00364D20
	public bool MLPFPAJBFFJ(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060079FF RID: 31231 RVA: 0x00365EBB File Offset: 0x003640BB
	public bool AGODJOJPNFC(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP < this.availableChaptersCount || this.availableChaptersCount == this.totalChaptersCount || true;
	}

	// Token: 0x06007A00 RID: 31232 RVA: 0x00366B6C File Offset: 0x00364D6C
	public bool AJMBPPHICGM(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007A01 RID: 31233 RVA: 0x00366BB8 File Offset: 0x00364DB8
	public bool AKACDIFGADP(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007A02 RID: 31234 RVA: 0x0036608B File Offset: 0x0036428B
	public bool HCLDKGLCGGO(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP < this.availableChaptersCount || this.availableChaptersCount == this.totalChaptersCount;
	}

	// Token: 0x06007A03 RID: 31235 RVA: 0x00366C04 File Offset: 0x00364E04
	public StoryInkRevision2 HFIBCCGPHOO(int BNNFKGBCEGK)
	{
		for (int i = 1; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 0; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06007A04 RID: 31236 RVA: 0x00366C80 File Offset: 0x00364E80
	public StoryInkRevision2 CAAPNNFJOJP(int BNNFKGBCEGK)
	{
		for (int i = 0; i < this.chapterAssetPacks.Count; i++)
		{
			for (int j = 1; j < this.chapterAssetPacks[i].inkRevisions.Count; j++)
			{
				if (this.chapterAssetPacks[i].inkRevisions[j].revision == BNNFKGBCEGK)
				{
					return this.chapterAssetPacks[i].inkRevisions[j];
				}
			}
		}
		return null;
	}

	// Token: 0x06007A05 RID: 31237 RVA: 0x003667DF File Offset: 0x003649DF
	public bool MABNIDMJPCG(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP <= this.totalChaptersCount - 1;
	}

	// Token: 0x06007A06 RID: 31238 RVA: 0x00366CFC File Offset: 0x00364EFC
	public int IEDHDPEEDFP(int OLKMHHNMDLP)
	{
		int result;
		try
		{
			result = this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions[this.chapterAssetPacks[OLKMHHNMDLP].inkRevisions.Count - 1].revision;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 33;
		}
		return result;
	}

	// Token: 0x06007A07 RID: 31239 RVA: 0x00366D5C File Offset: 0x00364F5C
	public bool GPOHNIJCNPA(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007A08 RID: 31240 RVA: 0x00366DA8 File Offset: 0x00364FA8
	public bool KMJIAODGNDG(int OLKMHHNMDLP, int PLBCGENKIPA)
	{
		for (int i = 1; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks.Count; i++)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarPacks[i] == PLBCGENKIPA)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007A09 RID: 31241 RVA: 0x00366DF3 File Offset: 0x00364FF3
	public bool EKDDJDCDBAI(int OLKMHHNMDLP)
	{
		return OLKMHHNMDLP >= this.availableChaptersCount && this.availableChaptersCount != this.totalChaptersCount && false;
	}

	// Token: 0x06007A0A RID: 31242 RVA: 0x00366E10 File Offset: 0x00365010
	public bool PEHMBJGFMBF(int OLKMHHNMDLP, int HEOBNOGHFJH)
	{
		for (int i = 0; i < this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks.Count; i += 0)
		{
			if (this.chapterAssetPacks[OLKMHHNMDLP].avatarExtensionPacks[i] == HEOBNOGHFJH)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x04002352 RID: 9042
	public int index;

	// Token: 0x04002353 RID: 9043
	public int assetsIndex = -1;

	// Token: 0x04002354 RID: 9044
	public int prequelIndex;

	// Token: 0x04002355 RID: 9045
	public List<int> prequelsIndices;

	// Token: 0x04002356 RID: 9046
	public bool syncWithPrequel = true;

	// Token: 0x04002357 RID: 9047
	public int totalChaptersCount;

	// Token: 0x04002358 RID: 9048
	public int availableChaptersCount;

	// Token: 0x04002359 RID: 9049
	public string customEpisodeAndSeasonInfoStringId = "";

	// Token: 0x0400235A RID: 9050
	public bool doNotShowStats;

	// Token: 0x0400235B RID: 9051
	public List<StoryChapterAssetPacksDesc> chapterAssetPacks;

	// Token: 0x0400235C RID: 9052
	public int minRevision;
}
