using System;
using System.Collections.Generic;

// Token: 0x02000080 RID: 128
public class MEAHFFHIACD
{
	// Token: 0x0600119A RID: 4506 RVA: 0x000832E0 File Offset: 0x000814E0
	public bool CNMAECFBMLK(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "PurchaseManagerXiaomi[bridge]: ";
		for (int i = 1; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "qfb", "\nCDN:");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains(" " + this.ILOEELLIAPJ[j] + "episode") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "p") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("uen" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("" + this.ILOEELLIAPJ[j] + "LastShowItemStep() - could not find a give item step." + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("OnBackendUpgradeToGiftCardException" + this.GHFKLLIMDAK[k] + "energyhinttitle") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "OnCutsceneViewAssetsDownloadSuccess") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("amb" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("OnPurchasingViewLeave" + this.GHFKLLIMDAK[k] + "body" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x000834CC File Offset: 0x000816CC
	public void DFIKJAJIDKD(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, '2');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, (char)-112);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD CJLOJCOHAHA()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD MHAAELKFFED()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00083580 File Offset: 0x00081780
	public void FJEHPCNPMMA(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-8);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, (char)-42);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x0008363C File Offset: 0x0008183C
	public bool BBIMAKKAMJP(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "retry", " spec(s) consumed, height ");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("sac" + this.ILOEELLIAPJ[j] + "OnStorySplashManagerAssetsDownloadFailed") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "OnStartFreePassException") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("XXX" + this.ILOEELLIAPJ[j] + "" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("ok" + this.GHFKLLIMDAK[k] + "noisedigitalovr") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "<size=28px>") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("Account.SRAGetFullyReleasedAnthologies(), exception:" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("0 / " + this.GHFKLLIMDAK[k] + " " + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD BFHKGNBFHCH()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00083828 File Offset: 0x00081A28
	public void JAJHLMMDNIG(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, (char)-103);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-113);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x000838C4 File Offset: 0x00081AC4
	public bool GHAEHJNMECP(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "collect";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "", "sig");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("asp" + this.ILOEELLIAPJ[j] + "") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "ERROR: StoryStepChoiceExtended.StoryStepStage.executeChoice.clothes: bulk choice index must be > 0.") || KEGBCGMJOLC.ToLowerInvariant().EndsWith(")" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("digitalglitchovr" + this.ILOEELLIAPJ[j] + " <i>" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("0" + this.GHFKLLIMDAK[k] + "[Lounge] $SKINAPPLIED: no mapping row with shop index ") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "sig") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ink" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("XXX" + this.GHFKLLIMDAK[k] + "large" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00083AB0 File Offset: 0x00081CB0
	public void JOFNFNFEFKN(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-5);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, (char)-24);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00083B4C File Offset: 0x00081D4C
	public bool HOKIOPONECC(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "seasoncompletedesc";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "@", "0.00");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("errortitle" + this.ILOEELLIAPJ[j] + "energyhinttitle") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "rand") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("chs" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("var" + this.ILOEELLIAPJ[j] + ")" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("<size=28px>" + this.GHFKLLIMDAK[k] + "loungenotavailable") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "GeoLocationManager - could not resolve the country, using the cached one:") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("$USEANIMV2" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("loungepurchasetitle" + this.GHFKLLIMDAK[k] + "" + KEGBCGMJOLC);
				return false;
			}
		}
		return false;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00083D38 File Offset: 0x00081F38
	public void HNHFFPPELIG(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-15);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-64);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00083DD4 File Offset: 0x00081FD4
	public void DGAFAPKAKIA(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, (char)-28);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, '\u0015');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD EHBBFMCILPC
	{
		get
		{
			if (MEAHFFHIACD.IKLAPGJDMNA == null)
			{
				MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
			}
			return MEAHFFHIACD.IKLAPGJDMNA;
		}
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00083E70 File Offset: 0x00082070
	public void OELJOHCNBGK(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, ',');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, 'g');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00083F0C File Offset: 0x0008210C
	public void KNHJENHFPON(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-74);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, (char)-126);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00083FA8 File Offset: 0x000821A8
	public bool OMHNLFFJLNJ(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = ")";
		for (int i = 1; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "+", "");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("-" + this.ILOEELLIAPJ[j] + "lsw") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "OnLobbyStoryManagerDownloadSplashScreenFailed") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("data" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("skinshopinfosumrelation" + this.ILOEELLIAPJ[j] + "OnProfileMessageClosed" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("XXX" + this.GHFKLLIMDAK[k] + "StoriesSearchBalance.Initialize() - source is null, search disabled") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "+") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("〈" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("sfxstatreceived" + this.GHFKLLIMDAK[k] + "cdnerror" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD OOGPALHPNGM()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00084194 File Offset: 0x00082394
	public bool LDGNAJJNCIL(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "avind";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "\nresults=", "Fixed the bug when anthology progress would not be incremented in SceneStoryManager at chapter end, for story with index:");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("hint0" + this.ILOEELLIAPJ[j] + "profilenamelevellong") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "\r") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("OnBackendAddFriendByUIDException" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("fog" + this.ILOEELLIAPJ[j] + "assetbundlecollectablecard" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("OnRewardFreeSpinsClick" + this.GHFKLLIMDAK[k] + "passinfobtntitle") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "acli20") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("layer" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("SceneStoryManager - Account.Instance.GetActiveStory().header.progress[0] != Account.Instance.GetActiveStory().header.progress[1] check failed." + this.GHFKLLIMDAK[k] + "PurchaseManagerUnity.OnStoreDisconnected(): Store disconnected details: " + KEGBCGMJOLC);
				return false;
			}
		}
		return false;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00084380 File Offset: 0x00082580
	public void KJDNFFJJLDN(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, '2');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, (char)-70);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x0008441C File Offset: 0x0008261C
	public bool GKIGKIOPHAK(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "ops";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "sk", "importanttitle");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("errortitle" + this.ILOEELLIAPJ[j] + "OnStoryChoiceClick") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "c") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("/" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("lightmodebtn0" + this.ILOEELLIAPJ[j] + "vhspauseovr_1" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("onAppOpenAttribution" + this.GHFKLLIMDAK[k] + "OnLoungeScreenAssetsDownloadFailed") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "AdsManagerLP: Received RewardedVideoOnAdLoadFailedEvent") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("Error - can not queue asset bundles when download in progress." + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("" + this.GHFKLLIMDAK[k] + "PurchaseManagerUnity.Initialize()" + KEGBCGMJOLC);
				return false;
			}
		}
		return true;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00084608 File Offset: 0x00082808
	public void LLMCLMAOLMC(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-30);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, (char)-53);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x000846A4 File Offset: 0x000828A4
	public void CEDPFLEAAPK(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, '\0');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, 'z');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD BHGAKHLHKOG()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00084740 File Offset: 0x00082940
	public bool AJBCLKFEBCH(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "no";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "", "JJJ");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("OnLoungeUnlockNpcSkinSuccess" + this.ILOEELLIAPJ[j] + "OnChapterSnapshotRestoreExecute") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "id") || KEGBCGMJOLC.ToLowerInvariant().EndsWith(" failed after " + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("_StripesCount" + this.ILOEELLIAPJ[j] + "congratstitle" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("0" + this.GHFKLLIMDAK[k] + "$HIDEADS") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "%20") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("sindp" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("$e1en" + this.GHFKLLIMDAK[k] + "yes" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x0008492C File Offset: 0x00082B2C
	public bool HBLCLFEJMBM(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "Avatar pack (hidden or exposed) has been LOADED:", "importanttitle");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("congratstitle" + this.ILOEELLIAPJ[j] + "getSocialStatsAvatar") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "continue") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("p" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("ok" + this.ILOEELLIAPJ[j] + "amfc" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("$RESTOREENVSNAPSHOT" + this.GHFKLLIMDAK[k] + "") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "-") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ok" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] skipped, asset bundle cache clean scheduled" + this.GHFKLLIMDAK[k] + "" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00084B18 File Offset: 0x00082D18
	public void BINMFOOKFPC(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, (char)-121);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, (char)-66);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00084BB4 File Offset: 0x00082DB4
	public void BGLIAHEKACL(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, 'i');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-80);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD NPDDBAONMJP()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00084C50 File Offset: 0x00082E50
	public bool AFCAOBLLDAN(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "OnStoryChoiceClick", "XXX");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("cch" + this.ILOEELLIAPJ[j] + "importanttitle") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "geo.json") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("OnBackendRequestCustomProfileException" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("</i>." + this.ILOEELLIAPJ[j] + "OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("]' at storySaves[" + this.GHFKLLIMDAK[k] + "p") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "BackendCacheManager: Cleaning cache.") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ok" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("socialbadge" + this.GHFKLLIMDAK[k] + "Error. MoveEnvironment(), environment " + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00084E3C File Offset: 0x0008303C
	public void FFAKMKJMEGI(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, 'j');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, ':');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD FJHKMJPFDNI()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00084ED8 File Offset: 0x000830D8
	public bool ELBGCCOMBMD(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = " ";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "grayscale", "af_counter");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("acfe" + this.ILOEELLIAPJ[j] + "acomp2") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "Starting non-parallel download:") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA(" tokenIdf=" + this.ILOEELLIAPJ[j] + "UpdateUndoOnOffState" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("ember" + this.GHFKLLIMDAK[k] + "aindas") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("mist" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnRewardScreenAssetsDownloadSuccess" + this.GHFKLLIMDAK[k] + "PurchaseManagerSteam.InitializeUnityStoreController(): Connected!" + KEGBCGMJOLC);
				return false;
			}
		}
		return true;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x000850C4 File Offset: 0x000832C4
	public void NLNAHILOFOM(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, 'D');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, (char)-15);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00085160 File Offset: 0x00083360
	public void DOFLEONDCMI(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-34);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, 'k');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x000851FC File Offset: 0x000833FC
	public void DODNEEPIFGH(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, (char)-97);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, '&');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00085298 File Offset: 0x00083498
	public bool OGMNEIJPNJN(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "pmtfailed";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "syn", "");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("ok" + this.ILOEELLIAPJ[j] + "UpdateComponentTitleDesc() failed - AssetAvatarComponentType.trinket is null.") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "OnCutsceneViewShowWI") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("abskv" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("no" + this.ILOEELLIAPJ[j] + "" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("' pending='" + this.GHFKLLIMDAK[k] + "Audio Asset bundle loading skipped due to in-game settings (sound is off):") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "...") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("uid" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("\r" + this.GHFKLLIMDAK[k] + "sslind" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD DBFLIEGGGNN()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00085484 File Offset: 0x00083684
	public void OGNEMDIEHFO(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-33);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, '~');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00085520 File Offset: 0x00083720
	public void LPJCNKJFKJI(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, '\u001f');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, ' ');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD NMGMNAKLLMI()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x000855BC File Offset: 0x000837BC
	public void KLJIMOGLHEF(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, (char)-21);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-77);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD PEBMGCKFNAO()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00085658 File Offset: 0x00083858
	public void JLEDOPOIJJO(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, '\u0004');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, 'n');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x000856F4 File Offset: 0x000838F4
	public void HPKILNBJCPH(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-27);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, '\u0013');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD PMABBOJDELF()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD KFAABHHGOPO()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD NKJBCCNGIDP()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00085790 File Offset: 0x00083990
	public void IMADGDGPBOB(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, 'F');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-12);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD OBOOKJPGBJN()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x0008582C File Offset: 0x00083A2C
	public void LBMOHCDFBEL(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-13);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, '|');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x000858C8 File Offset: 0x00083AC8
	public void MCOMCHOLOOO(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-121);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-82);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00085964 File Offset: 0x00083B64
	public bool IDIMBPJOIMF(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "Starting non-parallel download:";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "OnSettingsPopupClose", "auth");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("scki2" + this.ILOEELLIAPJ[j] + "OnLanguageChange") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "stat5long") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("amt" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("love" + this.ILOEELLIAPJ[j] + "_BLEND_ALPHA" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("</i>" + this.GHFKLLIMDAK[k] + "") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "/") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ipwho.is" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("ok" + this.GHFKLLIMDAK[k] + "aind2" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00085B50 File Offset: 0x00083D50
	public void BAMHPOCKBML(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, '\n');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, '\n');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD PCJEMMDDCIF()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00085BEC File Offset: 0x00083DEC
	public bool GBHOFFCOCGA(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "profilenametitleshort";
		for (int i = 1; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "OnApplicationFocusBasicSyncEcxeption", "");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("acli21" + this.ILOEELLIAPJ[j] + "") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "socialdequeulevelup") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("  " + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("black" + this.ILOEELLIAPJ[j] + "OnPopupStoryRestartManagerRestartStory2" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("errortitle" + this.GHFKLLIMDAK[k] + "OnUserpassLoginFailed") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("$HIDEADS" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("" + this.GHFKLLIMDAK[k] + "it" + KEGBCGMJOLC);
				return false;
			}
		}
		return false;
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD BIAEAOMHBMM()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00085DD8 File Offset: 0x00083FD8
	public void DFFMNJDFNJG(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, '/');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, ',');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00085E74 File Offset: 0x00084074
	public void OFOAFPKPIKC(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, 'u');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, (char)-73);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD ANCEKPONIFI()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD JCMABFEMFKD()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD ILACPHFEDEP()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00085F10 File Offset: 0x00084110
	public bool IAEEEIAAAIA(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "……()¿¡.,-+?!¿¡_)(*&^@\"'|:;[]{}\\`~1234567890—–«»’”“„‟″";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "", " ");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains(" " + this.ILOEELLIAPJ[j] + " ") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + " ") || KEGBCGMJOLC.ToLowerInvariant().EndsWith(" " + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OffensiveWordsManager.IsOffensive() true for word " + this.ILOEELLIAPJ[j] + " and input " + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains(" " + this.GHFKLLIMDAK[k] + " ") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + " ") || KEGBCGMJOLC.ToLowerInvariant().EndsWith(" " + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OffensiveWordsManager.IsOffensive() true for word " + this.GHFKLLIMDAK[k] + " and input " + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x000860FC File Offset: 0x000842FC
	public bool AMHHLODBPEF(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "-";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "", "</i>");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("Loaded asset bundle:" + this.ILOEELLIAPJ[j] + "_VignetteSoftness") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "), skipped: a request is in flight") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("BackendOperationsManager.RequestGetUserSketches, exception while initializing RSACryptoServiceProvider:" + this.ILOEELLIAPJ[j] + "null" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("OnRewardStoryCompleteClick" + this.GHFKLLIMDAK[k] + "OnPostEffectSettingsChanged") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "socialjoinbody") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("</i>" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnStoryChoiceClick" + this.GHFKLLIMDAK[k] + "XXX" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD EOPDANIFLBB()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x000862E8 File Offset: 0x000844E8
	public bool HJOGNGBHCJC(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = "";
		for (int i = 1; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "sfxitemused", "hair");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("ok" + this.ILOEELLIAPJ[j] + "PurchaseManagerSteam.OnBackendValidateTransactionSuccess().") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("serversync" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("@" + this.ILOEELLIAPJ[j] + "CCC" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("ChoicePremiumManager.Initialize(): original cost:" + this.GHFKLLIMDAK[k] + " ") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "maxrf") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("itsub" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("bv" + this.GHFKLLIMDAK[k] + "OnUserpassLoginSuccess" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD HFAKOKBHCGH()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x000864D4 File Offset: 0x000846D4
	public void CIHDCFLGEMF(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, '}');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.FPBLMHCNMEA(text2, '\u0015');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00086570 File Offset: 0x00084770
	public bool PIOHDCEHBHL(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = " ";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "", "myphiddentitle");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("lcdp" + this.ILOEELLIAPJ[j] + "importanttitle") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "varConditionValue") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("story" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("XXX" + this.ILOEELLIAPJ[j] + "UpdatePostOnOffState" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("liveOfferId" + this.GHFKLLIMDAK[k] + "\"") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "〃") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("Account.ResolveSaveSlots(): End" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("incentadthanks" + this.GHFKLLIMDAK[k] + "OnPopupProfileNicknameInputEndEdit" + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x0008675C File Offset: 0x0008495C
	public void KKPKEJBGAAG(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, '\u0017');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, '4');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x000867F8 File Offset: 0x000849F8
	public void JDIAILMECKC(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, (char)-102);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, '\u0013');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD KIKOEJMHOEH()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD IDMLJFBNHML()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00086894 File Offset: 0x00084A94
	public bool DCHPJNDGIPF(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "chapterrewindhint1", "af_revenue");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("" + this.ILOEELLIAPJ[j] + "data") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "DEFAULTLANG") || KEGBCGMJOLC.ToLowerInvariant().EndsWith(" lastFilter=" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("" + this.ILOEELLIAPJ[j] + "$NOTESHOW" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("]" + this.GHFKLLIMDAK[k] + "ok") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "storyAssetPackManager[i].environmentsFrontList[j] is null!") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("gamepassduration" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("OnGamePassUnlockContinueToPurchasingScreen" + this.GHFKLLIMDAK[k] + "" + KEGBCGMJOLC);
				return false;
			}
		}
		return true;
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00086A80 File Offset: 0x00084C80
	public bool CJMDGEMBPNC(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "Asset bundle load operation failed during parallel mode.";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "OnPurchasingNotInitialized", "congratstitle");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("avt" + this.ILOEELLIAPJ[j] + "loungenotavailable") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("ops" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("coverContinue" + this.ILOEELLIAPJ[j] + "syncoll2" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("$SAVECUTSCENE" + this.GHFKLLIMDAK[k] + "NEWSAVE: Account.ToJSONObject(), anthologies offloaded total components a->s:") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "OnPurchasingViewLeave") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("errortitle" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("" + this.GHFKLLIMDAK[k] + "" + KEGBCGMJOLC);
				return false;
			}
		}
		return true;
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00086C6C File Offset: 0x00084E6C
	public void KGFEFGNFPJO(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.MJBDMHPHMID().profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BHMBKAJOHLJ(text, '\u0002');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.MJBDMHPHMID().profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BIMGHPGAHCH(text2, (char)-64);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00086D08 File Offset: 0x00084F08
	public void IFHNGHNJONP(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, '\u001b');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, 'l');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00086DA4 File Offset: 0x00084FA4
	public void LAFCNAHCIFJ(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.BIMGHPGAHCH(text, '"');
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(CEIBHCNNIDC.en).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, 'h');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD GCCADHCFBJH()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD FDELMKCNOJB()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00086E40 File Offset: 0x00085040
	public bool IDNHFNAHPOF(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "cdnerror";
		for (int i = 0; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "OnSaveSlotsItemSlotDeleted", "");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains(";" + this.ILOEELLIAPJ[j] + "OnFullscreenCardOptionClick") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "teal_1") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("), skipped: a saveSync is already queued" + this.ILOEELLIAPJ[j] + " stripped from saved cutscene data because it was earlier hidden with LAYERHIDE. Looks like this might be a sleeping particle emitter." + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("varConditionLockedValue" + this.GHFKLLIMDAK[k] + "„") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "UpdateComponentTitleDesc() failed - AssetAvatarComponentType.trinket is null.") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("importanttitle" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.PJCLICBPPDA("playonce" + this.GHFKLLIMDAK[k] + "[LoadingEnv] " + KEGBCGMJOLC);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x0008702C File Offset: 0x0008522C
	public void NGCNFNNMPKC(CEIBHCNNIDC EENGLNKNAPF)
	{
		try
		{
			if (EENGLNKNAPF != CEIBHCNNIDC.en && EENGLNKNAPF != this.GMLCDENNGBM)
			{
				string text = AssetsManager.EHBBFMCILPC.profileDataAsset.MOKNFIJKBEM(EENGLNKNAPF).text;
				this.ILOEELLIAPJ = DPGJIJGOCIC.FPBLMHCNMEA(text, (char)-3);
				this.GMLCDENNGBM = EENGLNKNAPF;
			}
			else
			{
				this.ILOEELLIAPJ = new List<string>();
			}
			if (this.GHFKLLIMDAK.Count == 0)
			{
				string text2 = AssetsManager.EHBBFMCILPC.profileDataAsset.ONCJFGCEMGO(CEIBHCNNIDC.ru).text;
				this.GHFKLLIMDAK = DPGJIJGOCIC.BHMBKAJOHLJ(text2, '\u0011');
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD JLEOPAOEFGP()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD KBNLANLMNCN()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00083568 File Offset: 0x00081768
	public static MEAHFFHIACD MIABPLOIOBD()
	{
		if (MEAHFFHIACD.IKLAPGJDMNA == null)
		{
			MEAHFFHIACD.IKLAPGJDMNA = new MEAHFFHIACD();
		}
		return MEAHFFHIACD.IKLAPGJDMNA;
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x000870C8 File Offset: 0x000852C8
	public bool KAKFJAHDOLJ(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return true;
		}
		string text = ", ";
		for (int i = 0; i < text.Length; i++)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "envlsrw", "OnBackendRequestSpinWheelSuccess");
		}
		for (int j = 1; j < this.ILOEELLIAPJ.Count; j += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("OnNeedToShowNoMoreEnergyPopup" + this.ILOEELLIAPJ[j] + "loungeapplybtn") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "prw") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("UpdateHardSpendOnOffState" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("_BloomPasses" + this.ILOEELLIAPJ[j] + "" + KEGBCGMJOLC);
				return true;
			}
		}
		for (int k = 1; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains("Starting parallel download:" + this.GHFKLLIMDAK[k] + "ok") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "oid") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("hoursshort" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("grayscale_1" + this.GHFKLLIMDAK[k] + "PurchaseManagerUnity.OnSuccessInitializeGamingServices()" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x000872B4 File Offset: 0x000854B4
	public bool IDKFADIAKEO(string KEGBCGMJOLC, CEIBHCNNIDC EENGLNKNAPF)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return false;
		}
		string text = "post";
		for (int i = 1; i < text.Length; i += 0)
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Replace(text[i].ToString() ?? "(", "Vol");
		}
		for (int j = 0; j < this.ILOEELLIAPJ.Count; j++)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.ILOEELLIAPJ[j]) || KEGBCGMJOLC.ToLowerInvariant().Contains("sloh" + this.ILOEELLIAPJ[j] + "StoriesSearchRanker: nothing to search (anthologies ") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.ILOEELLIAPJ[j] + "+") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("lck" + this.ILOEELLIAPJ[j]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("importanttitle" + this.ILOEELLIAPJ[j] + "notifposteffects" + KEGBCGMJOLC);
				return false;
			}
		}
		for (int k = 0; k < this.GHFKLLIMDAK.Count; k += 0)
		{
			if (KEGBCGMJOLC.ToLowerInvariant().Equals(this.GHFKLLIMDAK[k]) || KEGBCGMJOLC.ToLowerInvariant().Contains(" -> [" + this.GHFKLLIMDAK[k] + "hoursshort") || KEGBCGMJOLC.ToLowerInvariant().StartsWith(this.GHFKLLIMDAK[k] + "assetbundleanthology") || KEGBCGMJOLC.ToLowerInvariant().EndsWith("country_code" + this.GHFKLLIMDAK[k]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] stored theme parked after the unclean exit" + this.GHFKLLIMDAK[k] + "socialenteruseridmalformed" + KEGBCGMJOLC);
				return true;
			}
		}
		return true;
	}

	// Token: 0x0400062D RID: 1581
	private static MEAHFFHIACD IKLAPGJDMNA;

	// Token: 0x0400062E RID: 1582
	public List<string> ILOEELLIAPJ = new List<string>();

	// Token: 0x0400062F RID: 1583
	public List<string> GHFKLLIMDAK = new List<string>();

	// Token: 0x04000630 RID: 1584
	private CEIBHCNNIDC GMLCDENNGBM;
}
