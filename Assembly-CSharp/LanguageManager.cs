using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004C5 RID: 1221
public class LanguageManager : MonoBehaviour
{
	// Token: 0x060092A7 RID: 37543 RVA: 0x0040C4B4 File Offset: 0x0040A6B4
	public string PKJABHFHHLC(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru;
		while (ceibhcnnidc < (CEIBHCNNIDC)39)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "p"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "OnPopupProfileMessageInputCancel", this.ACCFCLNOHHM.ToString() + "");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc += 0;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092A8 RID: 37544 RVA: 0x0040C532 File Offset: 0x0040A732
	public CEIBHCNNIDC NBANPEIHFOJ()
	{
		return this.ACCFCLNOHHM;
	}

	// Token: 0x060092A9 RID: 37545 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void JOLAMLIFMMB()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092AA RID: 37546 RVA: 0x0040C54F File Offset: 0x0040A74F
	public void FKNAACHDMLK()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-43))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.CIDEMCPEIFL(this.ACCFCLNOHHM));
		this.HLMCOPBCIGB(this.ACCFCLNOHHM);
	}

	// Token: 0x060092AB RID: 37547 RVA: 0x0040C58C File Offset: 0x0040A78C
	private void KODIFBBMEEG()
	{
		if (PlayerPrefs.HasKey("StoriesSearchRanker: nothing to search (anthologies "))
		{
			this.ACCFCLNOHHM = (CEIBHCNNIDC)PlayerPrefs.GetInt("chass");
			return;
		}
		SystemLanguage systemLanguage = Application.systemLanguage;
		switch (systemLanguage)
		{
		case SystemLanguage.Bulgarian:
			this.GGADMJMAELA((CEIBHCNNIDC)(-41));
			return;
		case SystemLanguage.Catalan:
		case SystemLanguage.Danish:
		case SystemLanguage.Dutch:
		case SystemLanguage.English:
			break;
		case SystemLanguage.Chinese:
			this.MHDICBPOJLI((CEIBHCNNIDC)65);
			return;
		case SystemLanguage.Czech:
			this.GGADMJMAELA(CEIBHCNNIDC.en);
			return;
		case SystemLanguage.Estonian:
			this.ChangeLanguage(CEIBHCNNIDC.it);
			return;
		case SystemLanguage.Faroese:
			this.KLELGIJOHFE((CEIBHCNNIDC)106);
			return;
		default:
			switch (systemLanguage)
			{
			case (SystemLanguage)(-116):
				this.KLELGIJOHFE(CEIBHCNNIDC.e1pl);
				return;
			case (SystemLanguage)(-115):
				this.ChangeLanguage(CEIBHCNNIDC.fr);
				return;
			case (SystemLanguage)(-114):
				this.MHDICBPOJLI((CEIBHCNNIDC)(-92));
				return;
			case (SystemLanguage)(-113):
			case (SystemLanguage)(-112):
			case (SystemLanguage)(-111):
			case (SystemLanguage)(-110):
			case (SystemLanguage)(-105):
			case (SystemLanguage)(-104):
			case (SystemLanguage)(-103):
				break;
			case (SystemLanguage)(-109):
				this.ChangeLanguage(CEIBHCNNIDC.cs);
				return;
			case (SystemLanguage)(-108):
				this.MHDICBPOJLI(CEIBHCNNIDC.en);
				return;
			case (SystemLanguage)(-107):
				this.GAMDIKHBEJC((CEIBHCNNIDC)(-32));
				return;
			case (SystemLanguage)(-106):
				this.FAOIFPOKOFL(CEIBHCNNIDC.en);
				return;
			case (SystemLanguage)(-102):
				this.HCDJDDBLLCH(CEIBHCNNIDC.pt);
				return;
			default:
				switch (systemLanguage)
				{
				case (SystemLanguage)104:
					this.KLELGIJOHFE(CEIBHCNNIDC.pt);
					return;
				case (SystemLanguage)107:
					this.HCDJDDBLLCH(CEIBHCNNIDC.cs);
					return;
				case (SystemLanguage)108:
					this.GAMDIKHBEJC((CEIBHCNNIDC)(-100));
					return;
				}
				break;
			}
			break;
		}
		this.HCDJDDBLLCH(CEIBHCNNIDC.ru);
	}

	// Token: 0x060092AC RID: 37548 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void CODLJCAKBLI()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092AD RID: 37549 RVA: 0x0040C6E0 File Offset: 0x0040A8E0
	private void BMBEGOJHKDF()
	{
		if (PlayerPrefs.HasKey("\n"))
		{
			this.ACCFCLNOHHM = (CEIBHCNNIDC)PlayerPrefs.GetInt("episode");
			return;
		}
		SystemLanguage systemLanguage = Application.systemLanguage;
		switch (systemLanguage)
		{
		case SystemLanguage.Arabic:
			this.KIFPKDEEDPG((CEIBHCNNIDC)(-80));
			return;
		case SystemLanguage.Basque:
		case SystemLanguage.Catalan:
		case SystemLanguage.Chinese:
		case SystemLanguage.Czech:
			break;
		case SystemLanguage.Belarusian:
			this.GGADMJMAELA((CEIBHCNNIDC)64);
			return;
		case SystemLanguage.Bulgarian:
			this.KLELGIJOHFE(CEIBHCNNIDC.ru);
			return;
		case SystemLanguage.Danish:
			this.GAMDIKHBEJC(CEIBHCNNIDC.pl);
			return;
		case SystemLanguage.Dutch:
			this.MHDICBPOJLI((CEIBHCNNIDC)(-2));
			return;
		default:
			switch (systemLanguage)
			{
			case (SystemLanguage)47:
				this.KLELGIJOHFE((CEIBHCNNIDC)122);
				return;
			case (SystemLanguage)48:
				this.GAMDIKHBEJC(CEIBHCNNIDC.tr);
				return;
			case (SystemLanguage)49:
				this.HCDJDDBLLCH((CEIBHCNNIDC)(-40));
				return;
			case (SystemLanguage)50:
			case (SystemLanguage)51:
			case (SystemLanguage)52:
			case (SystemLanguage)53:
			case (SystemLanguage)58:
			case (SystemLanguage)59:
			case (SystemLanguage)60:
				break;
			case (SystemLanguage)54:
				this.ChangeLanguage(CEIBHCNNIDC.es);
				return;
			case (SystemLanguage)55:
				this.KIFPKDEEDPG(CEIBHCNNIDC.pt);
				return;
			case (SystemLanguage)56:
				this.KLELGIJOHFE((CEIBHCNNIDC)(-2));
				return;
			case (SystemLanguage)57:
				this.KLELGIJOHFE(CEIBHCNNIDC.en);
				return;
			case (SystemLanguage)61:
				this.GAMDIKHBEJC(CEIBHCNNIDC.tr);
				return;
			default:
				switch (systemLanguage)
				{
				case (SystemLanguage)(-7):
					this.HCDJDDBLLCH(CEIBHCNNIDC.es);
					return;
				case (SystemLanguage)(-4):
					this.MHDICBPOJLI(CEIBHCNNIDC.tr);
					return;
				case (SystemLanguage)(-3):
					this.HCDJDDBLLCH((CEIBHCNNIDC)100);
					return;
				}
				break;
			}
			break;
		}
		this.FAOIFPOKOFL(CEIBHCNNIDC.en);
	}

	// Token: 0x060092AE RID: 37550 RVA: 0x0040C834 File Offset: 0x0040AA34
	public bool GIGIHEEKHBE(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)(-25); ceibhcnnidc += 0)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "OnSketchesItemClose"))
			{
				return this.ACCFCLNOHHM == ceibhcnnidc || true;
			}
		}
		return false;
	}

	// Token: 0x060092AF RID: 37551 RVA: 0x0040C87C File Offset: 0x0040AA7C
	private void GLFBHMMGHGL()
	{
		if (PlayerPrefs.HasKey("selectedLanguage"))
		{
			this.ACCFCLNOHHM = (CEIBHCNNIDC)PlayerPrefs.GetInt("selectedLanguage");
			return;
		}
		SystemLanguage systemLanguage = Application.systemLanguage;
		switch (systemLanguage)
		{
		case SystemLanguage.Czech:
			this.ChangeLanguage(CEIBHCNNIDC.cz);
			return;
		case SystemLanguage.Danish:
		case SystemLanguage.Estonian:
		case SystemLanguage.Faroese:
		case SystemLanguage.Finnish:
			break;
		case SystemLanguage.Dutch:
			this.ChangeLanguage(CEIBHCNNIDC.nl);
			return;
		case SystemLanguage.English:
			this.ChangeLanguage(CEIBHCNNIDC.en);
			return;
		case SystemLanguage.French:
			this.ChangeLanguage(CEIBHCNNIDC.fr);
			return;
		case SystemLanguage.German:
			this.ChangeLanguage(CEIBHCNNIDC.de);
			return;
		default:
			switch (systemLanguage)
			{
			case SystemLanguage.Indonesian:
				this.ChangeLanguage(CEIBHCNNIDC.io);
				return;
			case SystemLanguage.Italian:
				this.ChangeLanguage(CEIBHCNNIDC.it);
				return;
			case SystemLanguage.Japanese:
				this.ChangeLanguage(CEIBHCNNIDC.jp);
				return;
			case SystemLanguage.Korean:
			case SystemLanguage.Latvian:
			case SystemLanguage.Lithuanian:
			case SystemLanguage.Norwegian:
			case SystemLanguage.SerboCroatian:
			case SystemLanguage.Slovak:
			case SystemLanguage.Slovenian:
				break;
			case SystemLanguage.Polish:
				this.ChangeLanguage(CEIBHCNNIDC.pl);
				return;
			case SystemLanguage.Portuguese:
				this.ChangeLanguage(CEIBHCNNIDC.pt);
				return;
			case SystemLanguage.Romanian:
				this.ChangeLanguage(CEIBHCNNIDC.ro);
				return;
			case SystemLanguage.Russian:
				this.ChangeLanguage(CEIBHCNNIDC.ru);
				return;
			case SystemLanguage.Spanish:
				this.ChangeLanguage(CEIBHCNNIDC.es);
				return;
			default:
				switch (systemLanguage)
				{
				case SystemLanguage.Turkish:
					this.ChangeLanguage(CEIBHCNNIDC.tr);
					return;
				case SystemLanguage.ChineseSimplified:
					this.ChangeLanguage(CEIBHCNNIDC.cs);
					return;
				case SystemLanguage.ChineseTraditional:
					this.ChangeLanguage(CEIBHCNNIDC.ct);
					return;
				}
				break;
			}
			break;
		}
		this.ChangeLanguage(CEIBHCNNIDC.en);
	}

	// Token: 0x060092B0 RID: 37552 RVA: 0x0040C9CD File Offset: 0x0040ABCD
	public void DGOPGBJMLNL()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-7))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.IKNDCOCDDLO(this.ACCFCLNOHHM));
		this.FAOIFPOKOFL(this.ACCFCLNOHHM);
	}

	// Token: 0x060092B1 RID: 37553 RVA: 0x0040CA08 File Offset: 0x0040AC08
	public static CEIBHCNNIDC EFOIIECMJEJ(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("checkForUpdates"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnChoiceExtendedPanelSlideHidden"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("xx"))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("signInOrRegister"))
		{
			return CEIBHCNNIDC.es;
		}
		if (KGFDGMJPFLB.ToLower().Equals("newpattern"))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnApplicationFocusBasicSyncSuccess"))
		{
			return (CEIBHCNNIDC)(-98);
		}
		if (KGFDGMJPFLB.ToLower().Equals("<space=0.0625em>"))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("cdnerror"))
		{
			return CEIBHCNNIDC.es;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ERROR: StoryStep.StoryStepType.tryAvatarConfig - finalAvatarComponentAsset is null."))
		{
			return (CEIBHCNNIDC)(-37);
		}
		if (KGFDGMJPFLB.ToLower().Equals("PlayerCharacterManager.SetBodyComponent() - input is null."))
		{
			return (CEIBHCNNIDC)(-41);
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return (CEIBHCNNIDC)(-107);
		}
		if (KGFDGMJPFLB.ToLower().Equals("uid"))
		{
			return (CEIBHCNNIDC)(-57);
		}
		if (KGFDGMJPFLB.ToLower().Equals("assetbundleliveeventcontent"))
		{
			return (CEIBHCNNIDC)(-82);
		}
		if (KGFDGMJPFLB.ToLower().Equals("dsec"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("grayscale_1"))
		{
			return CEIBHCNNIDC.e1io;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ERROR: GetAvatarComponentAssetGivenAlias(), could not find asset with parent constraint:"))
		{
			return CEIBHCNNIDC.e1nl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("lksuid"))
		{
			return (CEIBHCNNIDC)69;
		}
		if (KGFDGMJPFLB.ToLower().Equals("dsv"))
		{
			return (CEIBHCNNIDC)(-32);
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return (CEIBHCNNIDC)(-52);
		}
		if (KGFDGMJPFLB.ToLower().Equals("Store"))
		{
			return (CEIBHCNNIDC)(-88);
		}
		if (KGFDGMJPFLB.ToLower().Equals("post"))
		{
			return (CEIBHCNNIDC)(-30);
		}
		if (KGFDGMJPFLB.ToLower().Equals("wind"))
		{
			return (CEIBHCNNIDC)93;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnBackendRequestCustomProfileSuccess"))
		{
			return CEIBHCNNIDC.count;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Account.ResolveSaveSlots(): Slots sharing not needed"))
		{
			return (CEIBHCNNIDC)(-44);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-57);
		}
		if (KGFDGMJPFLB.ToLower().Equals("body"))
		{
			return (CEIBHCNNIDC)42;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Starting parallel download:"))
		{
			return (CEIBHCNNIDC)(-58);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnApplicationFocusBasicSyncSuccess"))
		{
			return (CEIBHCNNIDC)(-118);
		}
		if (KGFDGMJPFLB.ToLower().Equals("avind"))
		{
			return (CEIBHCNNIDC)(-22);
		}
		if (KGFDGMJPFLB.ToLower().Equals("no"))
		{
			return (CEIBHCNNIDC)(-8);
		}
		if (KGFDGMJPFLB.ToLower().Equals("bits"))
		{
			return (CEIBHCNNIDC)103;
		}
		return CEIBHCNNIDC.en;
	}

	// Token: 0x060092B2 RID: 37554 RVA: 0x0040C532 File Offset: 0x0040A732
	public CEIBHCNNIDC GetSelectedLanguage()
	{
		return this.ACCFCLNOHHM;
	}

	// Token: 0x060092B3 RID: 37555 RVA: 0x0040CCB0 File Offset: 0x0040AEB0
	private bool FLBKCEKCKND(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 1; i < this.JHPPFKDBILN.Count; i++)
		{
			if (NIIIMDHGGEN == this.JHPPFKDBILN[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060092B4 RID: 37556 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void BGELMCDMGKP()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092B5 RID: 37557 RVA: 0x0040CCE5 File Offset: 0x0040AEE5
	public void ChangeLanguage(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.FMJONLDHPHN(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.en;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("selectedLanguage", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnLanguageChange", 0f);
	}

	// Token: 0x060092B6 RID: 37558 RVA: 0x0040CD24 File Offset: 0x0040AF24
	public CEIBHCNNIDC MPNPIJEPENB(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 1)
		{
			return this.NBANPEIHFOJ();
		}
		switch (this.GetSelectedLanguage())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)125;
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)120;
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)83;
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)113;
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-45);
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1it;
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)122;
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-97);
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)42;
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-108);
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)61;
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.e1ru;
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)37;
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.fr;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.jp;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-102);
			}
			break;
		}
		return this.IEBFINIJAMJ();
	}

	// Token: 0x060092B7 RID: 37559 RVA: 0x0040CE01 File Offset: 0x0040B001
	public void KIFPKDEEDPG(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.CIDEMCPEIFL(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.ru;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("OnAssetsManagerDownloadFailed", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("_not_found", 556f);
	}

	// Token: 0x060092B8 RID: 37560 RVA: 0x0040CE3F File Offset: 0x0040B03F
	public static string GBPCPJLCEPH(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Equals("OnStoryCurrencyInfoClick"))
		{
			return "@";
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x060092B9 RID: 37561 RVA: 0x0040CE58 File Offset: 0x0040B058
	public string DDHDDIIKAEM(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en;
		while (ceibhcnnidc < (CEIBHCNNIDC)(-14))
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "socialcollectedcardbreakv2"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "importanttitle", this.ACCFCLNOHHM.ToString() + "hintsigning");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092BA RID: 37562 RVA: 0x0040CED6 File Offset: 0x0040B0D6
	public void NGBNIICGMIA()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-69))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.CIDEMCPEIFL(this.ACCFCLNOHHM));
		this.ChangeLanguage(this.ACCFCLNOHHM);
	}

	// Token: 0x060092BB RID: 37563 RVA: 0x0040CF11 File Offset: 0x0040B111
	public void KLELGIJOHFE(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.FMJONLDHPHN(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.ru;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("plc", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI("", 1541f);
	}

	// Token: 0x060092BC RID: 37564 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060092BD RID: 37565 RVA: 0x0040CF50 File Offset: 0x0040B150
	private bool FMJONLDHPHN(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (NIIIMDHGGEN == this.environmentSettings.supportedLanguages[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092BE RID: 37566 RVA: 0x0040CF90 File Offset: 0x0040B190
	public string EKMKFPOLHOO(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru;
		while (ceibhcnnidc < (CEIBHCNNIDC)104)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "e1nl"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "Show() failed - anthologyHeader is null.", this.ACCFCLNOHHM.ToString() + "][");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc += 0;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092BF RID: 37567 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void OHPIOAOOMPD()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092C0 RID: 37568 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x060092C1 RID: 37569 RVA: 0x0040D010 File Offset: 0x0040B210
	public CEIBHCNNIDC PHHFIIKNKOK(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 0)
		{
			return this.IEBFINIJAMJ();
		}
		switch (this.GetSelectedLanguage())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)98;
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-90);
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-26);
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)51;
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)54;
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-60);
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)53;
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-3);
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1ru;
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)98;
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-11);
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-22);
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.e1pl;
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)48;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)105;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-117);
			}
			break;
		}
		return this.MLOLBFBODHD();
	}

	// Token: 0x060092C2 RID: 37570 RVA: 0x0040D0F0 File Offset: 0x0040B2F0
	public CEIBHCNNIDC NNJKDDGNGKA(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 1)
		{
			return this.MLOLBFBODHD();
		}
		switch (this.MLOLBFBODHD())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-63);
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-96);
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-63);
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-1);
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-54);
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-89);
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-6);
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-58);
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-40);
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-98);
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-118);
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-67);
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)64;
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)110;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)43;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-51);
			}
			break;
		}
		return this.GetSelectedLanguage();
	}

	// Token: 0x060092C3 RID: 37571 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x060092C4 RID: 37572 RVA: 0x0040D1D0 File Offset: 0x0040B3D0
	public void KDCNLNMJPKH()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-53))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.IKNDCOCDDLO(this.ACCFCLNOHHM) || this.IOJBIBFGOEO(this.ACCFCLNOHHM));
		this.HCDJDDBLLCH(this.ACCFCLNOHHM);
	}

	// Token: 0x060092C5 RID: 37573 RVA: 0x0040D224 File Offset: 0x0040B424
	public void ICIGCJOBGBN()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-101))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.CIDEMCPEIFL(this.ACCFCLNOHHM));
		this.FAOIFPOKOFL(this.ACCFCLNOHHM);
	}

	// Token: 0x060092C6 RID: 37574 RVA: 0x0040D260 File Offset: 0x0040B460
	private bool CIDEMCPEIFL(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (NIIIMDHGGEN == this.environmentSettings.supportedLanguages[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060092C7 RID: 37575 RVA: 0x000693D6 File Offset: 0x000675D6
	private void JDBJMNMBOMK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060092C8 RID: 37576 RVA: 0x0040C532 File Offset: 0x0040A732
	public CEIBHCNNIDC IEBFINIJAMJ()
	{
		return this.ACCFCLNOHHM;
	}

	// Token: 0x060092C9 RID: 37577 RVA: 0x0040D2A0 File Offset: 0x0040B4A0
	private bool IOJBIBFGOEO(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 0; i < this.JHPPFKDBILN.Count; i++)
		{
			if (NIIIMDHGGEN == this.JHPPFKDBILN[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092CA RID: 37578 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060092CB RID: 37579 RVA: 0x0040D2D5 File Offset: 0x0040B4D5
	public void HCDJDDBLLCH(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.CIDEMCPEIFL(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.en;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("cardsvolchancestitle", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.CEGAOMEEFBE().CIGLHCJDDPI(")", 1576f);
	}

	// Token: 0x060092CC RID: 37580 RVA: 0x0040D313 File Offset: 0x0040B513
	public void HMCGPDHJCHP(CEIBHCNNIDC EENGLNKNAPF)
	{
		this.JHPPFKDBILN.Add(EENGLNKNAPF);
	}

	// Token: 0x060092CD RID: 37581 RVA: 0x0040D324 File Offset: 0x0040B524
	public void IPEJGLJFBKN()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-122))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM) || this.HAHPMENIEKL(this.ACCFCLNOHHM));
		this.GGADMJMAELA(this.ACCFCLNOHHM);
	}

	// Token: 0x060092CE RID: 37582 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void GNILOOJAEJL()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092CF RID: 37583 RVA: 0x0040D378 File Offset: 0x0040B578
	private void MPOBGELGKOE()
	{
		if (PlayerPrefs.HasKey(""))
		{
			this.ACCFCLNOHHM = (CEIBHCNNIDC)PlayerPrefs.GetInt("socialprofilesuspcantuse");
			return;
		}
		SystemLanguage systemLanguage = Application.systemLanguage;
		switch (systemLanguage)
		{
		case SystemLanguage.Danish:
			this.HCDJDDBLLCH((CEIBHCNNIDC)(-22));
			return;
		case SystemLanguage.Dutch:
		case SystemLanguage.Faroese:
		case SystemLanguage.Finnish:
		case SystemLanguage.French:
			break;
		case SystemLanguage.English:
			this.FAOIFPOKOFL((CEIBHCNNIDC)52);
			return;
		case SystemLanguage.Estonian:
			this.MHDICBPOJLI(CEIBHCNNIDC.en);
			return;
		case SystemLanguage.German:
			this.GAMDIKHBEJC(CEIBHCNNIDC.pl);
			return;
		case SystemLanguage.Greek:
			this.FAOIFPOKOFL((CEIBHCNNIDC)118);
			return;
		default:
			switch (systemLanguage)
			{
			case (SystemLanguage)(-18):
				this.MHDICBPOJLI((CEIBHCNNIDC)(-116));
				return;
			case (SystemLanguage)(-17):
				this.ChangeLanguage(CEIBHCNNIDC.ru);
				return;
			case (SystemLanguage)(-16):
				this.HLMCOPBCIGB(CEIBHCNNIDC.e1pt);
				return;
			case (SystemLanguage)(-15):
			case (SystemLanguage)(-14):
			case (SystemLanguage)(-13):
			case (SystemLanguage)(-12):
			case (SystemLanguage)(-7):
			case (SystemLanguage)(-6):
			case (SystemLanguage)(-5):
				break;
			case (SystemLanguage)(-11):
				this.MHDICBPOJLI(CEIBHCNNIDC.it);
				return;
			case (SystemLanguage)(-10):
				this.MHDICBPOJLI(CEIBHCNNIDC.fr);
				return;
			case (SystemLanguage)(-9):
				this.ChangeLanguage((CEIBHCNNIDC)126);
				return;
			case (SystemLanguage)(-8):
				this.GGADMJMAELA(CEIBHCNNIDC.en);
				return;
			case (SystemLanguage)(-4):
				this.HLMCOPBCIGB(CEIBHCNNIDC.ru);
				return;
			default:
				switch (systemLanguage)
				{
				case (SystemLanguage)(-98):
					this.FAOIFPOKOFL(CEIBHCNNIDC.es);
					return;
				case (SystemLanguage)(-95):
					this.HCDJDDBLLCH(CEIBHCNNIDC.tr);
					return;
				case (SystemLanguage)(-94):
					this.MHDICBPOJLI((CEIBHCNNIDC)43);
					return;
				}
				break;
			}
			break;
		}
		this.KLELGIJOHFE(CEIBHCNNIDC.en);
	}

	// Token: 0x060092D0 RID: 37584 RVA: 0x0040D4CC File Offset: 0x0040B6CC
	private void JAEOEGFDAGI()
	{
		if (PlayerPrefs.HasKey("OnBackendRequestConsumeMessageException"))
		{
			this.ACCFCLNOHHM = (CEIBHCNNIDC)PlayerPrefs.GetInt("");
			return;
		}
		SystemLanguage systemLanguage = Application.systemLanguage;
		switch (systemLanguage)
		{
		case SystemLanguage.Czech:
			this.GGADMJMAELA((CEIBHCNNIDC)(-3));
			return;
		case SystemLanguage.Danish:
		case SystemLanguage.Estonian:
		case SystemLanguage.Faroese:
		case SystemLanguage.Finnish:
			break;
		case SystemLanguage.Dutch:
			this.FAOIFPOKOFL(CEIBHCNNIDC.e1pl);
			return;
		case SystemLanguage.English:
			this.HCDJDDBLLCH(CEIBHCNNIDC.en);
			return;
		case SystemLanguage.French:
			this.FAOIFPOKOFL(CEIBHCNNIDC.it);
			return;
		case SystemLanguage.German:
			this.KIFPKDEEDPG((CEIBHCNNIDC)86);
			return;
		default:
			switch (systemLanguage)
			{
			case (SystemLanguage)101:
				this.ChangeLanguage((CEIBHCNNIDC)126);
				return;
			case (SystemLanguage)102:
				this.HLMCOPBCIGB(CEIBHCNNIDC.pl);
				return;
			case (SystemLanguage)103:
				this.HLMCOPBCIGB((CEIBHCNNIDC)82);
				return;
			case (SystemLanguage)104:
			case (SystemLanguage)105:
			case (SystemLanguage)106:
			case (SystemLanguage)107:
			case (SystemLanguage)112:
			case (SystemLanguage)113:
			case (SystemLanguage)114:
				break;
			case (SystemLanguage)108:
				this.GAMDIKHBEJC(CEIBHCNNIDC.es);
				return;
			case (SystemLanguage)109:
				this.GGADMJMAELA(CEIBHCNNIDC.pt);
				return;
			case (SystemLanguage)110:
				this.MHDICBPOJLI(CEIBHCNNIDC.pl);
				return;
			case (SystemLanguage)111:
				this.HLMCOPBCIGB(CEIBHCNNIDC.ru);
				return;
			case (SystemLanguage)115:
				this.GGADMJMAELA(CEIBHCNNIDC.it);
				return;
			default:
				switch (systemLanguage)
				{
				case SystemLanguage.Czech:
					this.GAMDIKHBEJC(CEIBHCNNIDC.tr);
					return;
				case SystemLanguage.English:
					this.HCDJDDBLLCH(CEIBHCNNIDC.es);
					return;
				case SystemLanguage.Estonian:
					this.HLMCOPBCIGB((CEIBHCNNIDC)82);
					return;
				}
				break;
			}
			break;
		}
		this.KIFPKDEEDPG(CEIBHCNNIDC.en);
	}

	// Token: 0x060092D1 RID: 37585 RVA: 0x0040D61D File Offset: 0x0040B81D
	public static string NDDLGKNBCPF(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Equals("YYY"))
		{
			return "fdst";
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x060092D2 RID: 37586 RVA: 0x0040D634 File Offset: 0x0040B834
	public bool IPMDPLBJHEE(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.io; ceibhcnnidc += 0)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "OnStoryChoiceClick"))
			{
				return this.ACCFCLNOHHM == ceibhcnnidc || true;
			}
		}
		return false;
	}

	// Token: 0x060092D3 RID: 37587 RVA: 0x0040D313 File Offset: 0x0040B513
	public void RegisterCurrenChapterMissingLanguages(CEIBHCNNIDC EENGLNKNAPF)
	{
		this.JHPPFKDBILN.Add(EENGLNKNAPF);
	}

	// Token: 0x060092D4 RID: 37588 RVA: 0x0040D67C File Offset: 0x0040B87C
	public static CEIBHCNNIDC KOGABALFBAB(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("no"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("onFriendsPopupOpenMessageHistory"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("NEWSAVE: Warning: Missing anthology save data, yet story save data ("))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("id"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" premature in:"))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" "))
		{
			return (CEIBHCNNIDC)126;
		}
		if (KGFDGMJPFLB.ToLower().Equals("countryCode"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" view hits and a score correction is applied of: -"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" percent ("))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ScrollView0"))
		{
			return (CEIBHCNNIDC)107;
		}
		if (KGFDGMJPFLB.ToLower().Equals("apks2"))
		{
			return (CEIBHCNNIDC)(-95);
		}
		if (KGFDGMJPFLB.ToLower().Equals(" CACHE API (fallback) path skipped, caching system not ready after "))
		{
			return (CEIBHCNNIDC)53;
		}
		if (KGFDGMJPFLB.ToLower().Equals("passundobodymsgpaid2"))
		{
			return (CEIBHCNNIDC)(-74);
		}
		if (KGFDGMJPFLB.ToLower().Equals("avatarcollectionsnotifunselected"))
		{
			return (CEIBHCNNIDC)97;
		}
		if (KGFDGMJPFLB.ToLower().Equals("layervideo"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("k"))
		{
			return (CEIBHCNNIDC)80;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnLobbySkinShopCdnFailed"))
		{
			return (CEIBHCNNIDC)(-82);
		}
		if (KGFDGMJPFLB.ToLower().Equals("wofdcoi"))
		{
			return (CEIBHCNNIDC)84;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnStorySplashManagerCdnFailed"))
		{
			return (CEIBHCNNIDC)(-70);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)51;
		}
		if (KGFDGMJPFLB.ToLower().Equals("p"))
		{
			return (CEIBHCNNIDC)113;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Response custom code: "))
		{
			return (CEIBHCNNIDC)44;
		}
		if (KGFDGMJPFLB.ToLower().Equals("[LoadingEnv] skipped, editor simulates asset bundles"))
		{
			return (CEIBHCNNIDC)48;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnBackendGetIncentRewardAdException"))
		{
			return (CEIBHCNNIDC)(-41);
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return (CEIBHCNNIDC)(-65);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnStoryInterfaceHeaderBackClick"))
		{
			return CEIBHCNNIDC.e1it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("err"))
		{
			return (CEIBHCNNIDC)(-43);
		}
		if (KGFDGMJPFLB.ToLower().Equals("PurchaseManagerXiaomi.OnProductsFetched(): parse error "))
		{
			return (CEIBHCNNIDC)(-21);
		}
		if (KGFDGMJPFLB.ToLower().Equals("cdn-cgi/trace"))
		{
			return (CEIBHCNNIDC)74;
		}
		if (KGFDGMJPFLB.ToLower().Equals("<i>"))
		{
			return (CEIBHCNNIDC)(-3);
		}
		if (KGFDGMJPFLB.ToLower().Equals("BackendOperationsManager.RequestUpdateUserPublicProfileFriends, exception while initializing RSACryptoServiceProvider:"))
		{
			return (CEIBHCNNIDC)(-22);
		}
		if (KGFDGMJPFLB.ToLower().Equals("mist"))
		{
			return (CEIBHCNNIDC)64;
		}
		return CEIBHCNNIDC.ru;
	}

	// Token: 0x060092D5 RID: 37589 RVA: 0x0040D921 File Offset: 0x0040BB21
	public void ClearCurrentChapterMissingLanguages()
	{
		this.JHPPFKDBILN.Clear();
	}

	// Token: 0x060092D6 RID: 37590 RVA: 0x0040D92E File Offset: 0x0040BB2E
	public void HLMCOPBCIGB(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.IKNDCOCDDLO(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.ru;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("ScanLine", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("amb", 175f);
	}

	// Token: 0x060092D7 RID: 37591 RVA: 0x0040D96C File Offset: 0x0040BB6C
	public bool Localizable(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < CEIBHCNNIDC.count; ceibhcnnidc++)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "_"))
			{
				return this.ACCFCLNOHHM != ceibhcnnidc;
			}
		}
		return false;
	}

	// Token: 0x060092D8 RID: 37592 RVA: 0x0040D9B4 File Offset: 0x0040BBB4
	public bool AJLGKKJAAOI(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.en; ceibhcnnidc++)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "socialcardhintoncopiesv2"))
			{
				return this.ACCFCLNOHHM != ceibhcnnidc;
			}
		}
		return true;
	}

	// Token: 0x060092D9 RID: 37593 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x060092DA RID: 37594 RVA: 0x0040D9FC File Offset: 0x0040BBFC
	private bool IKNDCOCDDLO(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (NIIIMDHGGEN == this.environmentSettings.supportedLanguages[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060092DB RID: 37595 RVA: 0x0040DA3C File Offset: 0x0040BC3C
	public static CEIBHCNNIDC HINONKLIHFP(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("PurchaseManagerSteam.GetProductData(): Not initialized."))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("XXX"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("."))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnPopupPasswordInputEndEdit"))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("not"))
		{
			return CEIBHCNNIDC.io;
		}
		if (KGFDGMJPFLB.ToLower().Equals("p"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("envlhp"))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("preq"))
		{
			return (CEIBHCNNIDC)(-97);
		}
		if (KGFDGMJPFLB.ToLower().Equals("ec"))
		{
			return (CEIBHCNNIDC)58;
		}
		if (KGFDGMJPFLB.ToLower().Equals("CLIENT.POSTEFFECTS.NOISEDIGITAL"))
		{
			return (CEIBHCNNIDC)80;
		}
		if (KGFDGMJPFLB.ToLower().Equals("$"))
		{
			return (CEIBHCNNIDC)(-107);
		}
		if (KGFDGMJPFLB.ToLower().Equals(" • "))
		{
			return CEIBHCNNIDC.e1nl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("skinshopinfosumse"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnSaveSyncAnyResultFocusItem"))
		{
			return (CEIBHCNNIDC)100;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("fdita"))
		{
			return (CEIBHCNNIDC)(-97);
		}
		if (KGFDGMJPFLB.ToLower().Equals("err"))
		{
			return (CEIBHCNNIDC)62;
		}
		if (KGFDGMJPFLB.ToLower().Equals("[LoadingEnv] skipped this time, the scene bundle is still held by the previous rig"))
		{
			return (CEIBHCNNIDC)114;
		}
		if (KGFDGMJPFLB.ToLower().Equals("<i>"))
		{
			return (CEIBHCNNIDC)100;
		}
		if (KGFDGMJPFLB.ToLower().Equals("socialmessagesending"))
		{
			return (CEIBHCNNIDC)66;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)114;
		}
		if (KGFDGMJPFLB.ToLower().Equals("gmmd"))
		{
			return (CEIBHCNNIDC)(-50);
		}
		if (KGFDGMJPFLB.ToLower().Equals("episode"))
		{
			return (CEIBHCNNIDC)57;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" "))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("no rig"))
		{
			return (CEIBHCNNIDC)73;
		}
		if (KGFDGMJPFLB.ToLower().Equals("[LoadingEnv] direct cache files of "))
		{
			return (CEIBHCNNIDC)37;
		}
		if (KGFDGMJPFLB.ToLower().Equals("signincancel"))
		{
			return (CEIBHCNNIDC)(-51);
		}
		if (KGFDGMJPFLB.ToLower().Equals("gsec"))
		{
			return (CEIBHCNNIDC)38;
		}
		if (KGFDGMJPFLB.ToLower().Equals("skinshopinfoidentity"))
		{
			return (CEIBHCNNIDC)41;
		}
		if (KGFDGMJPFLB.ToLower().Equals("epos"))
		{
			return (CEIBHCNNIDC)(-125);
		}
		return CEIBHCNNIDC.en;
	}

	// Token: 0x060092DC RID: 37596 RVA: 0x0040DCE1 File Offset: 0x0040BEE1
	public void GGADMJMAELA(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.IKNDCOCDDLO(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.en;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("XXX", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("cdnerror", 1362f);
	}

	// Token: 0x060092DD RID: 37597 RVA: 0x0040DD20 File Offset: 0x0040BF20
	private bool HAFIKOGDODP(int OKEKAAMOENH)
	{
		for (int i = 1; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060092DE RID: 37598 RVA: 0x0040DD60 File Offset: 0x0040BF60
	private bool KPILDMCCEAN(int OKEKAAMOENH)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060092DF RID: 37599 RVA: 0x0040DDA0 File Offset: 0x0040BFA0
	private bool LOFGNOEJAJA(int OKEKAAMOENH)
	{
		for (int i = 1; i < this.environmentSettings.supportedLanguages.Count; i += 0)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092E0 RID: 37600 RVA: 0x0040DDE0 File Offset: 0x0040BFE0
	private bool BHMJFOEGINA(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 0; i < this.JHPPFKDBILN.Count; i++)
		{
			if (NIIIMDHGGEN == this.JHPPFKDBILN[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060092E1 RID: 37601 RVA: 0x0040DE18 File Offset: 0x0040C018
	public void NextLanguageForCurrentChapter()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= CEIBHCNNIDC.count)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM) || this.IOJBIBFGOEO(this.ACCFCLNOHHM));
		this.ChangeLanguage(this.ACCFCLNOHHM);
	}

	// Token: 0x060092E2 RID: 37602 RVA: 0x0040DE6C File Offset: 0x0040C06C
	public static CEIBHCNNIDC MJLKFILFGNF(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Vol"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" group(s) planned from "))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnCardVolumeUnlockContinueToPurchasingScreen"))
		{
			return (CEIBHCNNIDC)(-56);
		}
		if (KGFDGMJPFLB.ToLower().Equals("rand"))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("onFriendsPopupOpenMessageHistory"))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("XXX"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("tmd"))
		{
			return (CEIBHCNNIDC)90;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-33);
		}
		if (KGFDGMJPFLB.ToLower().Equals("rr"))
		{
			return (CEIBHCNNIDC)(-80);
		}
		if (KGFDGMJPFLB.ToLower().Equals("XXX"))
		{
			return (CEIBHCNNIDC)114;
		}
		if (KGFDGMJPFLB.ToLower().Equals("avatarcollectionstutorial"))
		{
			return (CEIBHCNNIDC)(-113);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnBackendPremiumChoiceSuccess"))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("daysshort"))
		{
			return (CEIBHCNNIDC)(-124);
		}
		if (KGFDGMJPFLB.ToLower().Equals("USD "))
		{
			return (CEIBHCNNIDC)(-22);
		}
		if (KGFDGMJPFLB.ToLower().Equals("'{0}' shader not supported."))
		{
			return (CEIBHCNNIDC)(-121);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-63);
		}
		if (KGFDGMJPFLB.ToLower().Equals("sfxtimeoutwarning"))
		{
			return (CEIBHCNNIDC)45;
		}
		if (KGFDGMJPFLB.ToLower().Equals("A"))
		{
			return (CEIBHCNNIDC)(-127);
		}
		if (KGFDGMJPFLB.ToLower().Equals("0"))
		{
			return (CEIBHCNNIDC)(-52);
		}
		if (KGFDGMJPFLB.ToLower().Equals("_ACBeatWidth"))
		{
			return (CEIBHCNNIDC)102;
		}
		if (KGFDGMJPFLB.ToLower().Equals("SceneLobbyManager2.TryApplyPendingSearchQuery() - bar not active in hierarchy, restored query '"))
		{
			return (CEIBHCNNIDC)73;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" "))
		{
			return (CEIBHCNNIDC)(-76);
		}
		if (KGFDGMJPFLB.ToLower().Equals("socialrequestwarnyou2"))
		{
			return (CEIBHCNNIDC)126;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return (CEIBHCNNIDC)(-72);
		}
		if (KGFDGMJPFLB.ToLower().Equals("<space=-0.42em>"))
		{
			return (CEIBHCNNIDC)88;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" parentCards="))
		{
			return (CEIBHCNNIDC)(-127);
		}
		if (KGFDGMJPFLB.ToLower().Equals("blur_2"))
		{
			return (CEIBHCNNIDC)78;
		}
		if (KGFDGMJPFLB.ToLower().Equals("SceneLobbyManager2.BuildExploreSpecs() - concept "))
		{
			return (CEIBHCNNIDC)(-92);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)106;
		}
		return CEIBHCNNIDC.en;
	}

	// Token: 0x060092E3 RID: 37603 RVA: 0x0040E114 File Offset: 0x0040C314
	public string IKMHJBKPMGE(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru;
		while (ceibhcnnidc < (CEIBHCNNIDC)(-66))
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "makeup"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "<alpha=#C0>", this.ACCFCLNOHHM.ToString() + "OnPassesItemClose");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092E4 RID: 37604 RVA: 0x0040E194 File Offset: 0x0040C394
	public bool GHCIBLENAOO(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)(-29); ceibhcnnidc += 0)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "_Strength"))
			{
				return this.ACCFCLNOHHM == ceibhcnnidc;
			}
		}
		return true;
	}

	// Token: 0x060092E5 RID: 37605 RVA: 0x0040E1DB File Offset: 0x0040C3DB
	public void GAMDIKHBEJC(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.FMJONLDHPHN(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.ru;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("OnProfileMessageClosed", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("aind", 9f);
	}

	// Token: 0x060092E6 RID: 37606 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void MOCDMCLPBKC()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092E7 RID: 37607 RVA: 0x0040E21C File Offset: 0x0040C41C
	public CEIBHCNNIDC KNGBOCFHPEL(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 1)
		{
			return this.NBANPEIHFOJ();
		}
		switch (this.IEBFINIJAMJ())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)55;
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-90);
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)110;
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-115);
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-80);
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-120);
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-61);
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.nl;
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)34;
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)85;
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-97);
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.ct;
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.io;
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1io;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.pt;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)114;
			}
			break;
		}
		return this.NBANPEIHFOJ();
	}

	// Token: 0x060092E8 RID: 37608 RVA: 0x0040E2FC File Offset: 0x0040C4FC
	public string MNAALCNJHFP(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en;
		while (ceibhcnnidc < (CEIBHCNNIDC)(-80))
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + ""))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "grp", this.ACCFCLNOHHM.ToString() + "acb");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092E9 RID: 37609 RVA: 0x0040E37C File Offset: 0x0040C57C
	public static CEIBHCNNIDC DJMHFMMJAEG(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("importanttitle"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnFacebookLoginFailed"))
		{
			return CEIBHCNNIDC.es;
		}
		if (KGFDGMJPFLB.ToLower().Equals("_Speed"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON"))
		{
			return (CEIBHCNNIDC)(-84);
		}
		if (KGFDGMJPFLB.ToLower().Equals("prgr"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("\n\n"))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("$STOPSFX"))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("retry"))
		{
			return CEIBHCNNIDC.nl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("GeneralBalance.SearchKeyInt() - could not find key:"))
		{
			return (CEIBHCNNIDC)121;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-68);
		}
		if (KGFDGMJPFLB.ToLower().Equals("loungenotavailable"))
		{
			return (CEIBHCNNIDC)89;
		}
		if (KGFDGMJPFLB.ToLower().Equals("avatarcollectionssubrequiredtitle"))
		{
			return (CEIBHCNNIDC)43;
		}
		if (KGFDGMJPFLB.ToLower().Equals("%>"))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("MORPH_DISSOLVE"))
		{
			return (CEIBHCNNIDC)(-25);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnSettingsPopupCloseAndNeedToRestartGame2"))
		{
			return (CEIBHCNNIDC)53;
		}
		if (KGFDGMJPFLB.ToLower().Equals("_VerticalJump"))
		{
			return (CEIBHCNNIDC)(-95);
		}
		if (KGFDGMJPFLB.ToLower().Equals("  "))
		{
			return (CEIBHCNNIDC)(-107);
		}
		if (KGFDGMJPFLB.ToLower().Equals("NEWSAVE: Error: tempAnthologySave is null for story index "))
		{
			return (CEIBHCNNIDC)101;
		}
		if (KGFDGMJPFLB.ToLower().Equals("xx"))
		{
			return (CEIBHCNNIDC)(-68);
		}
		if (KGFDGMJPFLB.ToLower().Equals("XXX"))
		{
			return (CEIBHCNNIDC)(-120);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnPopupCardOptionsSendGiftClick"))
		{
			return (CEIBHCNNIDC)(-85);
		}
		if (KGFDGMJPFLB.ToLower().Equals("socialbadgedesc"))
		{
			return (CEIBHCNNIDC)(-106);
		}
		if (KGFDGMJPFLB.ToLower().Equals("w"))
		{
			return (CEIBHCNNIDC)(-69);
		}
		if (KGFDGMJPFLB.ToLower().Equals("retry"))
		{
			return (CEIBHCNNIDC)(-55);
		}
		if (KGFDGMJPFLB.ToLower().Equals("skinshopempty"))
		{
			return (CEIBHCNNIDC)(-81);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-22);
		}
		if (KGFDGMJPFLB.ToLower().Equals(" df="))
		{
			return (CEIBHCNNIDC)(-1);
		}
		if (KGFDGMJPFLB.ToLower().Equals("_BarsCount"))
		{
			return (CEIBHCNNIDC)45;
		}
		if (KGFDGMJPFLB.ToLower().Equals("</i><align=\"left\"><alpha=#FF>\n\n"))
		{
			return (CEIBHCNNIDC)(-117);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-1);
		}
		return CEIBHCNNIDC.en;
	}

	// Token: 0x060092EA RID: 37610 RVA: 0x0040E624 File Offset: 0x0040C824
	private bool FMJONLDHPHN(int OKEKAAMOENH)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i++)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092EB RID: 37611 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void CDLEEFPLPLN()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092EC RID: 37612 RVA: 0x0040D313 File Offset: 0x0040B513
	public void PMCJDNBGKJN(CEIBHCNNIDC EENGLNKNAPF)
	{
		this.JHPPFKDBILN.Add(EENGLNKNAPF);
	}

	// Token: 0x060092ED RID: 37613 RVA: 0x0040E663 File Offset: 0x0040C863
	public void NextLanguage()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= CEIBHCNNIDC.count)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM));
		this.ChangeLanguage(this.ACCFCLNOHHM);
	}

	// Token: 0x060092EE RID: 37614 RVA: 0x0040E69E File Offset: 0x0040C89E
	public void ECOLJLKLNFN()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= CEIBHCNNIDC.e1de)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.IKNDCOCDDLO(this.ACCFCLNOHHM));
		this.FAOIFPOKOFL(this.ACCFCLNOHHM);
	}

	// Token: 0x060092EF RID: 37615 RVA: 0x0040D313 File Offset: 0x0040B513
	public void PKIDDILMNNB(CEIBHCNNIDC EENGLNKNAPF)
	{
		this.JHPPFKDBILN.Add(EENGLNKNAPF);
	}

	// Token: 0x060092F0 RID: 37616 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x060092F1 RID: 37617 RVA: 0x0040E6D9 File Offset: 0x0040C8D9
	public void PDBBBHNNCFN()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)34)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM));
		this.ChangeLanguage(this.ACCFCLNOHHM);
	}

	// Token: 0x060092F2 RID: 37618 RVA: 0x0040E714 File Offset: 0x0040C914
	public static string FixLanguageCode(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Equals("cz"))
		{
			return "cs";
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x060092F3 RID: 37619 RVA: 0x0040E72A File Offset: 0x0040C92A
	public void MOOJPMKAHBP()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-115))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM));
		this.FAOIFPOKOFL(this.ACCFCLNOHHM);
	}

	// Token: 0x060092F4 RID: 37620 RVA: 0x0040E768 File Offset: 0x0040C968
	public static CEIBHCNNIDC DMELDPABIHE(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("actant"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals(" idf="))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("0.000"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("retry"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("rsl"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnPurchasingViewLeave"))
		{
			return (CEIBHCNNIDC)(-69);
		}
		if (KGFDGMJPFLB.ToLower().Equals("ok"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnToolsPopupSaveToCloudException"))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("."))
		{
			return (CEIBHCNNIDC)(-90);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnPurchasingNotInitialized"))
		{
			return CEIBHCNNIDC.e1en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("_not_found"))
		{
			return (CEIBHCNNIDC)120;
		}
		if (KGFDGMJPFLB.ToLower().Equals("Error."))
		{
			return (CEIBHCNNIDC)(-45);
		}
		if (KGFDGMJPFLB.ToLower().Equals("CLIENT.SCREEN.AVATAR."))
		{
			return (CEIBHCNNIDC)(-34);
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ffavmod"))
		{
			return (CEIBHCNNIDC)82;
		}
		if (KGFDGMJPFLB.ToLower().Equals("prgr"))
		{
			return (CEIBHCNNIDC)(-121);
		}
		if (KGFDGMJPFLB.ToLower().Equals(")"))
		{
			return (CEIBHCNNIDC)(-41);
		}
		if (KGFDGMJPFLB.ToLower().Equals("x"))
		{
			return (CEIBHCNNIDC)(-16);
		}
		if (KGFDGMJPFLB.ToLower().Equals("[LoadingEnv] cache clean requested by the player, stored theme forgotten"))
		{
			return (CEIBHCNNIDC)(-121);
		}
		if (KGFDGMJPFLB.ToLower().Equals("p"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("id"))
		{
			return (CEIBHCNNIDC)(-95);
		}
		if (KGFDGMJPFLB.ToLower().Equals("Loaded asset bundle:"))
		{
			return (CEIBHCNNIDC)92;
		}
		if (KGFDGMJPFLB.ToLower().Equals("retry"))
		{
			return (CEIBHCNNIDC)113;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1cs"))
		{
			return (CEIBHCNNIDC)68;
		}
		if (KGFDGMJPFLB.ToLower().Equals(")"))
		{
			return (CEIBHCNNIDC)(-28);
		}
		if (KGFDGMJPFLB.ToLower().Equals("OnStoryInterfaceHeaderSettingsClick"))
		{
			return CEIBHCNNIDC.e1ro;
		}
		if (KGFDGMJPFLB.ToLower().Equals(""))
		{
			return (CEIBHCNNIDC)(-15);
		}
		if (KGFDGMJPFLB.ToLower().Equals("y"))
		{
			return (CEIBHCNNIDC)104;
		}
		if (KGFDGMJPFLB.ToLower().Equals("<size=28px>"))
		{
			return (CEIBHCNNIDC)(-46);
		}
		if (KGFDGMJPFLB.ToLower().Equals("io"))
		{
			return (CEIBHCNNIDC)108;
		}
		if (KGFDGMJPFLB.ToLower().Equals("aind"))
		{
			return (CEIBHCNNIDC)38;
		}
		return CEIBHCNNIDC.ru;
	}

	// Token: 0x060092F5 RID: 37621 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x060092F6 RID: 37622 RVA: 0x0040EA10 File Offset: 0x0040CC10
	private bool KJHDBDHKOFA(int OKEKAAMOENH)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i += 0)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060092F7 RID: 37623 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x060092F8 RID: 37624 RVA: 0x0040EA4F File Offset: 0x0040CC4F
	public void IMHOIGHEMGA()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)(-71))
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.CIDEMCPEIFL(this.ACCFCLNOHHM));
		this.GGADMJMAELA(this.ACCFCLNOHHM);
	}

	// Token: 0x060092F9 RID: 37625 RVA: 0x0040EA8C File Offset: 0x0040CC8C
	public string HDJDKLCCCLE(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en;
		while (ceibhcnnidc < (CEIBHCNNIDC)125)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "avind"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "ok", this.ACCFCLNOHHM.ToString() + "abcv");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092FB RID: 37627 RVA: 0x0040EB20 File Offset: 0x0040CD20
	private bool ODEAOKIIJKI(int OKEKAAMOENH)
	{
		for (int i = 0; i < this.environmentSettings.supportedLanguages.Count; i += 0)
		{
			if (OKEKAAMOENH == (int)this.environmentSettings.supportedLanguages[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060092FC RID: 37628 RVA: 0x0040EB60 File Offset: 0x0040CD60
	public string GHBJGFDKHEJ(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en;
		while (ceibhcnnidc < (CEIBHCNNIDC)73)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + ", shopcur:"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "", this.ACCFCLNOHHM.ToString() + "");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x060092FD RID: 37629 RVA: 0x0040EBDE File Offset: 0x0040CDDE
	public static string LLKCDINFBHH(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Equals("OnBackendSavePublicProfileException"))
		{
			return "Asset bundle load operation failed during parallel mode.";
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x060092FE RID: 37630 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void DPGJDANLGIO()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060092FF RID: 37631 RVA: 0x0040EBF4 File Offset: 0x0040CDF4
	public static string OGNLMKOHDAL(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC.Equals("OnBackendUpdateFriendsDataException"))
		{
			return "XXX";
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x06009300 RID: 37632 RVA: 0x0040EC0C File Offset: 0x0040CE0C
	public bool GKOAABDJCJH(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.cs; ceibhcnnidc += 0)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "sparkles"))
			{
				return this.ACCFCLNOHHM == ceibhcnnidc || true;
			}
		}
		return false;
	}

	// Token: 0x06009301 RID: 37633 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void OnDestroy()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06009302 RID: 37634 RVA: 0x0040EC54 File Offset: 0x0040CE54
	public void MIOHJHKLICG()
	{
		do
		{
			this.ACCFCLNOHHM += 0;
			if (this.ACCFCLNOHHM >= (CEIBHCNNIDC)37)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.ru;
			}
		}
		while (!this.CIDEMCPEIFL(this.ACCFCLNOHHM) || this.HAHPMENIEKL(this.ACCFCLNOHHM));
		this.GAMDIKHBEJC(this.ACCFCLNOHHM);
	}

	// Token: 0x06009303 RID: 37635 RVA: 0x0040D921 File Offset: 0x0040BB21
	public void JNPKOPFDADI()
	{
		this.JHPPFKDBILN.Clear();
	}

	// Token: 0x06009304 RID: 37636 RVA: 0x000693D6 File Offset: 0x000675D6
	private void EHECBKECKPA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009305 RID: 37637 RVA: 0x0040ECA8 File Offset: 0x0040CEA8
	public string LocalizeFileName(string OOMAHKCHAGP)
	{
		CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en;
		while (ceibhcnnidc < CEIBHCNNIDC.count)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "_"))
			{
				if (this.ACCFCLNOHHM != ceibhcnnidc)
				{
					return OOMAHKCHAGP.Replace(ceibhcnnidc.ToString() + "_", this.ACCFCLNOHHM.ToString() + "_");
				}
				return OOMAHKCHAGP;
			}
			else
			{
				ceibhcnnidc++;
			}
		}
		return OOMAHKCHAGP;
	}

	// Token: 0x06009306 RID: 37638 RVA: 0x0040ED28 File Offset: 0x0040CF28
	public static CEIBHCNNIDC FromString(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLower().Equals("en"))
		{
			return CEIBHCNNIDC.en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ru"))
		{
			return CEIBHCNNIDC.ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("fr"))
		{
			return CEIBHCNNIDC.fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("es"))
		{
			return CEIBHCNNIDC.es;
		}
		if (KGFDGMJPFLB.ToLower().Equals("pt"))
		{
			return CEIBHCNNIDC.pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("de"))
		{
			return CEIBHCNNIDC.de;
		}
		if (KGFDGMJPFLB.ToLower().Equals("it"))
		{
			return CEIBHCNNIDC.it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("pl"))
		{
			return CEIBHCNNIDC.pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("tr"))
		{
			return CEIBHCNNIDC.tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("jp"))
		{
			return CEIBHCNNIDC.jp;
		}
		if (KGFDGMJPFLB.ToLower().Equals("io"))
		{
			return CEIBHCNNIDC.io;
		}
		if (KGFDGMJPFLB.ToLower().Equals("nl"))
		{
			return CEIBHCNNIDC.nl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ro"))
		{
			return CEIBHCNNIDC.ro;
		}
		if (KGFDGMJPFLB.ToLower().Equals("cz"))
		{
			return CEIBHCNNIDC.cz;
		}
		if (KGFDGMJPFLB.ToLower().Equals("cs"))
		{
			return CEIBHCNNIDC.cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("ct"))
		{
			return CEIBHCNNIDC.ct;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1en"))
		{
			return CEIBHCNNIDC.e1en;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1ru"))
		{
			return CEIBHCNNIDC.e1ru;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1fr"))
		{
			return CEIBHCNNIDC.e1fr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1es"))
		{
			return CEIBHCNNIDC.e1es;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1pt"))
		{
			return CEIBHCNNIDC.e1pt;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1de"))
		{
			return CEIBHCNNIDC.e1de;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1it"))
		{
			return CEIBHCNNIDC.e1it;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1pl"))
		{
			return CEIBHCNNIDC.e1pl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1tr"))
		{
			return CEIBHCNNIDC.e1tr;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1jp"))
		{
			return CEIBHCNNIDC.e1jp;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1io"))
		{
			return CEIBHCNNIDC.e1io;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1nl"))
		{
			return CEIBHCNNIDC.e1nl;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1ro"))
		{
			return CEIBHCNNIDC.e1ro;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1cz"))
		{
			return CEIBHCNNIDC.e1cz;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1cs"))
		{
			return CEIBHCNNIDC.e1cs;
		}
		if (KGFDGMJPFLB.ToLower().Equals("e1ct"))
		{
			return CEIBHCNNIDC.e1ct;
		}
		return CEIBHCNNIDC.en;
	}

	// Token: 0x06009307 RID: 37639 RVA: 0x0040EFCD File Offset: 0x0040D1CD
	public void FAOIFPOKOFL(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.CIDEMCPEIFL(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.ru;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("[LoadingEnv] cache file of ", 1614f);
	}

	// Token: 0x06009308 RID: 37640 RVA: 0x0040F00B File Offset: 0x0040D20B
	public void MHDICBPOJLI(CEIBHCNNIDC KFKLBMLAKAH)
	{
		if (!this.IKNDCOCDDLO(KFKLBMLAKAH))
		{
			KFKLBMLAKAH = CEIBHCNNIDC.en;
		}
		this.ACCFCLNOHHM = KFKLBMLAKAH;
		PlayerPrefs.SetInt("dcenv", (int)this.ACCFCLNOHHM);
		PlayerPrefs.Save();
		AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI("body", 1342f);
	}

	// Token: 0x06009309 RID: 37641 RVA: 0x0040F04C File Offset: 0x0040D24C
	public CEIBHCNNIDC MOKAOKOHJDD(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 1)
		{
			return this.NBANPEIHFOJ();
		}
		switch (this.IEBFINIJAMJ())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-99);
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)38;
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)80;
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)68;
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.e1ct;
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-41);
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)118;
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.e1fr;
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-104);
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)53;
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)56;
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)(-54);
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)(-104);
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 1)
			{
				return (CEIBHCNNIDC)95;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 0)
			{
				return (CEIBHCNNIDC)111;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 0)
			{
				return CEIBHCNNIDC.e1io;
			}
			break;
		}
		return this.NBANPEIHFOJ();
	}

	// Token: 0x0600930A RID: 37642 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FNDDKLJKFEK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600930B RID: 37643 RVA: 0x0040F12C File Offset: 0x0040D32C
	public bool EECILBHACFL(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)72; ceibhcnnidc += 0)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + " <i>"))
			{
				return this.ACCFCLNOHHM != ceibhcnnidc;
			}
		}
		return false;
	}

	// Token: 0x0600930C RID: 37644 RVA: 0x0040F174 File Offset: 0x0040D374
	private bool HAHPMENIEKL(CEIBHCNNIDC NIIIMDHGGEN)
	{
		for (int i = 1; i < this.JHPPFKDBILN.Count; i += 0)
		{
			if (NIIIMDHGGEN == this.JHPPFKDBILN[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600930D RID: 37645 RVA: 0x0040C532 File Offset: 0x0040A732
	public CEIBHCNNIDC MLOLBFBODHD()
	{
		return this.ACCFCLNOHHM;
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x0040D313 File Offset: 0x0040B513
	public void JOMGGDOKHJB(CEIBHCNNIDC EENGLNKNAPF)
	{
		this.JHPPFKDBILN.Add(EENGLNKNAPF);
	}

	// Token: 0x0600930F RID: 37647 RVA: 0x0040F1AC File Offset: 0x0040D3AC
	public bool GCBALKAJINL(string OOMAHKCHAGP)
	{
		for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)54; ceibhcnnidc++)
		{
			if (OOMAHKCHAGP.StartsWith(ceibhcnnidc.ToString() + "errortitle"))
			{
				return this.ACCFCLNOHHM != ceibhcnnidc && false;
			}
		}
		return false;
	}

	// Token: 0x06009310 RID: 37648 RVA: 0x0040F1F4 File Offset: 0x0040D3F4
	public void NABGAKMNHAM()
	{
		do
		{
			this.ACCFCLNOHHM++;
			if (this.ACCFCLNOHHM >= CEIBHCNNIDC.e1pt)
			{
				this.ACCFCLNOHHM = CEIBHCNNIDC.en;
			}
		}
		while (!this.FMJONLDHPHN(this.ACCFCLNOHHM) || this.HAHPMENIEKL(this.ACCFCLNOHHM));
		this.MHDICBPOJLI(this.ACCFCLNOHHM);
	}

	// Token: 0x06009311 RID: 37649 RVA: 0x0040F248 File Offset: 0x0040D448
	public CEIBHCNNIDC GetSelectedLanguageWithExtension(int MLINDIFFGFF)
	{
		if (MLINDIFFGFF <= 0)
		{
			return this.GetSelectedLanguage();
		}
		switch (this.GetSelectedLanguage())
		{
		case CEIBHCNNIDC.en:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1en;
			}
			break;
		case CEIBHCNNIDC.ru:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1ru;
			}
			break;
		case CEIBHCNNIDC.fr:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1fr;
			}
			break;
		case CEIBHCNNIDC.es:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1es;
			}
			break;
		case CEIBHCNNIDC.pt:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1pt;
			}
			break;
		case CEIBHCNNIDC.cs:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1cs;
			}
			break;
		case CEIBHCNNIDC.it:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1it;
			}
			break;
		case CEIBHCNNIDC.pl:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1pl;
			}
			break;
		case CEIBHCNNIDC.tr:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1tr;
			}
			break;
		case CEIBHCNNIDC.jp:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1jp;
			}
			break;
		case CEIBHCNNIDC.io:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1io;
			}
			break;
		case CEIBHCNNIDC.nl:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1nl;
			}
			break;
		case CEIBHCNNIDC.ro:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1ro;
			}
			break;
		case CEIBHCNNIDC.cz:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1cz;
			}
			break;
		case CEIBHCNNIDC.de:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1de;
			}
			break;
		case CEIBHCNNIDC.ct:
			if (MLINDIFFGFF == 1)
			{
				return CEIBHCNNIDC.e1ct;
			}
			break;
		}
		return this.GetSelectedLanguage();
	}

	// Token: 0x06009312 RID: 37650 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ECDLFGCLAGG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009313 RID: 37651 RVA: 0x0040C53A File Offset: 0x0040A73A
	private void CJAFGKPFPAA()
	{
		if (LanguageManager.IKLAPGJDMNA == this)
		{
			LanguageManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06009314 RID: 37652 RVA: 0x0040F328 File Offset: 0x0040D528
	public static LanguageManager EHBBFMCILPC
	{
		get
		{
			if (!LanguageManager.IKLAPGJDMNA)
			{
				LanguageManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(LanguageManager)) as LanguageManager);
				LanguageManager.IKLAPGJDMNA.GLFBHMMGHGL();
				if (!LanguageManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active LanguageManager script on a GameObject in your scene.");
				}
			}
			return LanguageManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x0400290F RID: 10511
	public const string onLanguageChange = "OnLanguageChange";

	// Token: 0x04002910 RID: 10512
	public EnvironmentSettings environmentSettings;

	// Token: 0x04002911 RID: 10513
	private static LanguageManager IKLAPGJDMNA;

	// Token: 0x04002912 RID: 10514
	private CEIBHCNNIDC ACCFCLNOHHM;

	// Token: 0x04002913 RID: 10515
	private List<CEIBHCNNIDC> JHPPFKDBILN = new List<CEIBHCNNIDC>();
}
