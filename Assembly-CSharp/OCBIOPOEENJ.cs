using System;
using System.Globalization;
using SimpleJSON;
using UnityEngine.Purchasing;

// Token: 0x020002C2 RID: 706
public class OCBIOPOEENJ
{
	// Token: 0x060058C0 RID: 22720 RVA: 0x002817D4 File Offset: 0x0027F9D4
	public string DOLEPIMNJLG()
	{
		return this.EGKFHHBNNLM + "";
	}

	// Token: 0x060058C1 RID: 22721 RVA: 0x002817E8 File Offset: 0x0027F9E8
	public bool KHBALPDBIAL()
	{
		float num;
		return float.TryParse(this.EGKFHHBNNLM, NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num) && num > 1130f;
	}

	// Token: 0x060058C2 RID: 22722 RVA: 0x00281818 File Offset: 0x0027FA18
	public string PKNNPAMOADM()
	{
		return this.EGKFHHBNNLM + " lastChildCards=";
	}

	// Token: 0x060058C3 RID: 22723 RVA: 0x0028182A File Offset: 0x0027FA2A
	public bool PJCIBAKAANH()
	{
		return this.OAOBICFCBDC() && OCBIOPOEENJ.MCLDCJGCHGN();
	}

	// Token: 0x060058C4 RID: 22724 RVA: 0x0028183B File Offset: 0x0027FA3B
	public static ProductType KBBHKHGHMKN(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 1)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 7)
		{
			return (ProductType)8;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:");
		return ProductType.Consumable;
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x00281859 File Offset: 0x0027FA59
	public static ProductType BCGBEFJJAHM(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 1)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 2)
		{
			return ProductType.Subscription;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("StringToProductType() unknown value.");
		return ProductType.Consumable;
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x00281877 File Offset: 0x0027FA77
	public static ProductType DJFNHNCNBJC(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 3)
		{
			return ProductType.Unknown;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("");
		return ProductType.NonConsumable;
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x00281895 File Offset: 0x0027FA95
	public string BHAIFFLKKMA()
	{
		if (this.HHALLBOKCJO())
		{
			return this.DOLEPIMNJLG();
		}
		return "gpautoreadsubrequired" + this.JKBLBOAHJDE;
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x002818B6 File Offset: 0x0027FAB6
	public bool IMKLGJBEMPH()
	{
		return !this.MPJJANHFCDJ() || OCBIOPOEENJ.MCLDCJGCHGN();
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x0028182A File Offset: 0x0027FA2A
	public bool OKGPIEEOKBM()
	{
		return this.OAOBICFCBDC() && OCBIOPOEENJ.MCLDCJGCHGN();
	}

	// Token: 0x060058CA RID: 22730 RVA: 0x002818C7 File Offset: 0x0027FAC7
	public static ProductType LAOKPANMKMP(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 7)
		{
			return (ProductType)7;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnResolutionChanged");
		return ProductType.NonConsumable;
	}

	// Token: 0x060058CB RID: 22731 RVA: 0x002818E8 File Offset: 0x0027FAE8
	public void FGJPKGLOGNC(JSONObject EIHOJFGALMF)
	{
		this.DEJCCBNPFEC = EIHOJFGALMF["pid"];
		this.OBKCKGHFMDN = OCBIOPOEENJ.BCGBEFJJAHM(EIHOJFGALMF["t"].AsInt);
		this.ODMKLADKHMO = new LDLLJFOJCDF(EIHOJFGALMF["h"].AsInt);
		this.MPMKMCJFHOG = new LDLLJFOJCDF(EIHOJFGALMF["e"].AsInt);
		this.ABGNIKKFFAC = new LDLLJFOJCDF(EIHOJFGALMF["w"].AsInt);
		this.MLNOFEEIBMI = new LDLLJFOJCDF(EIHOJFGALMF["s"].AsInt);
		this.OHCDIAFPNFK = new LDLLJFOJCDF(EIHOJFGALMF["o"].AsInt);
		this.PPACJFFFBFB = new LDLLJFOJCDF(EIHOJFGALMF["a"].AsInt);
		this.EMHNNCBKIMG = new LDLLJFOJCDF(EIHOJFGALMF["d"].AsInt);
		this.OICPKCHAENO = new LDLLJFOJCDF(EIHOJFGALMF["i"].AsInt);
		this.GGICIBLJIKI = new LDLLJFOJCDF(EIHOJFGALMF["ii"].AsInt);
		this.CHLMAJLPIGC = (this.KBOMNFNNOEH = EIHOJFGALMF["u"]);
		if (EIHOJFGALMF["uen"] != null)
		{
			this.KBOMNFNNOEH = EIHOJFGALMF["uen"];
		}
		this.JKBLBOAHJDE = EIHOJFGALMF["dp"];
		this.DMODNDCLGEJ = EIHOJFGALMF["dps"];
		this.EGKFHHBNNLM = EIHOJFGALMF["dpr"];
	}

	// Token: 0x060058CC RID: 22732 RVA: 0x00281AA3 File Offset: 0x0027FCA3
	public string NLCMBMOEIIB()
	{
		if (this.PJCIBAKAANH())
		{
			return this.ILAPDGNDFGC();
		}
		return "NotificationManager" + this.JKBLBOAHJDE;
	}

	// Token: 0x060058CD RID: 22733 RVA: 0x00281AC4 File Offset: 0x0027FCC4
	public string DJJCDNDMAGD()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			return this.CHLMAJLPIGC;
		}
		return this.KBOMNFNNOEH;
	}

	// Token: 0x060058CE RID: 22734 RVA: 0x00281AE0 File Offset: 0x0027FCE0
	public void PEJIMPECAEB(JSONObject EIHOJFGALMF)
	{
		this.DEJCCBNPFEC = EIHOJFGALMF["tmdp"];
		this.OBKCKGHFMDN = OCBIOPOEENJ.LAOKPANMKMP(EIHOJFGALMF["PurchaseManagerUnity.FetchPurchases(): Not initialized."].AsInt);
		this.ODMKLADKHMO = new LDLLJFOJCDF(EIHOJFGALMF["\n\n"].AsInt);
		this.MPMKMCJFHOG = new LDLLJFOJCDF(EIHOJFGALMF["OnStoryInterfaceHeaderAutoReadDisable"].AsInt);
		this.ABGNIKKFFAC = new LDLLJFOJCDF(EIHOJFGALMF["OnStorySplashManagerHideAndCleanCache"].AsInt);
		this.MLNOFEEIBMI = new LDLLJFOJCDF(EIHOJFGALMF["ok"].AsInt);
		this.OHCDIAFPNFK = new LDLLJFOJCDF(EIHOJFGALMF["USD "].AsInt);
		this.PPACJFFFBFB = new LDLLJFOJCDF(EIHOJFGALMF[":"].AsInt);
		this.EMHNNCBKIMG = new LDLLJFOJCDF(EIHOJFGALMF["..."].AsInt);
		this.OICPKCHAENO = new LDLLJFOJCDF(EIHOJFGALMF["p"].AsInt);
		this.GGICIBLJIKI = new LDLLJFOJCDF(EIHOJFGALMF["abcc"].AsInt);
		this.CHLMAJLPIGC = (this.KBOMNFNNOEH = EIHOJFGALMF["cutsceneoptionsbody"]);
		if (EIHOJFGALMF["OnSettingsPopupCloseAndNeedToRestartGame"] != null)
		{
			this.KBOMNFNNOEH = EIHOJFGALMF["c_web"];
		}
		this.JKBLBOAHJDE = EIHOJFGALMF["SceneLobbyManager2.ComputeStarterTabAvailable() - no starter concept has a name in the text pack explore tab (older text pack bundle?), tab hidden"];
		this.DMODNDCLGEJ = EIHOJFGALMF["abnap"];
		this.EGKFHHBNNLM = EIHOJFGALMF["p"];
	}

	// Token: 0x060058CF RID: 22735 RVA: 0x002818B6 File Offset: 0x0027FAB6
	public bool HHALLBOKCJO()
	{
		return !this.MPJJANHFCDJ() || OCBIOPOEENJ.MCLDCJGCHGN();
	}

	// Token: 0x060058D0 RID: 22736 RVA: 0x00281C9B File Offset: 0x0027FE9B
	public static ProductType OJHJLILANOE(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 1)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 4)
		{
			return ProductType.Subscription;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("abcc");
		return ProductType.NonConsumable;
	}

	// Token: 0x060058D1 RID: 22737 RVA: 0x00281CB9 File Offset: 0x0027FEB9
	public static ProductType FJFGMPMNHKP(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.NonConsumable;
		}
		if (MFFNNGPMIIA == 1)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 3)
		{
			return ProductType.NonConsumable;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("strtd");
		return ProductType.Consumable;
	}

	// Token: 0x060058D2 RID: 22738 RVA: 0x002817D4 File Offset: 0x0027F9D4
	public string ILAPDGNDFGC()
	{
		return this.EGKFHHBNNLM + "";
	}

	// Token: 0x060058D3 RID: 22739 RVA: 0x00281AC4 File Offset: 0x0027FCC4
	public string BIKJFCLHPBK()
	{
		if (LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru)
		{
			return this.CHLMAJLPIGC;
		}
		return this.KBOMNFNNOEH;
	}

	// Token: 0x060058D5 RID: 22741 RVA: 0x00281CD7 File Offset: 0x0027FED7
	public string MBLAIKOOCFH()
	{
		if (LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			return this.CHLMAJLPIGC;
		}
		return this.KBOMNFNNOEH;
	}

	// Token: 0x060058D6 RID: 22742 RVA: 0x00281CF3 File Offset: 0x0027FEF3
	public string FDMCFAHEELN()
	{
		if (LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en)
		{
			return this.CHLMAJLPIGC;
		}
		return this.KBOMNFNNOEH;
	}

	// Token: 0x060058D7 RID: 22743 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static bool MCLDCJGCHGN()
	{
		return false;
	}

	// Token: 0x060058D8 RID: 22744 RVA: 0x00281D10 File Offset: 0x0027FF10
	public void GEFEABEHHGP(JSONObject EIHOJFGALMF)
	{
		this.DEJCCBNPFEC = EIHOJFGALMF[""];
		this.OBKCKGHFMDN = OCBIOPOEENJ.OJHJLILANOE(EIHOJFGALMF[" • "].AsInt);
		this.ODMKLADKHMO = new LDLLJFOJCDF(EIHOJFGALMF["CoverCard"].AsInt);
		this.MPMKMCJFHOG = new LDLLJFOJCDF(EIHOJFGALMF["lobby"].AsInt);
		this.ABGNIKKFFAC = new LDLLJFOJCDF(EIHOJFGALMF["acomp1"].AsInt);
		this.MLNOFEEIBMI = new LDLLJFOJCDF(EIHOJFGALMF["passinfobtntitle"].AsInt);
		this.OHCDIAFPNFK = new LDLLJFOJCDF(EIHOJFGALMF["OnSettingsPopupCloseAndNeedToRestartGame"].AsInt);
		this.PPACJFFFBFB = new LDLLJFOJCDF(EIHOJFGALMF["\n\n"].AsInt);
		this.EMHNNCBKIMG = new LDLLJFOJCDF(EIHOJFGALMF[", "].AsInt);
		this.OICPKCHAENO = new LDLLJFOJCDF(EIHOJFGALMF["PageUp\nPageDown - Change effects."].AsInt);
		this.GGICIBLJIKI = new LDLLJFOJCDF(EIHOJFGALMF["%"].AsInt);
		this.CHLMAJLPIGC = (this.KBOMNFNNOEH = EIHOJFGALMF["@"]);
		if (EIHOJFGALMF["SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology indices list not available"] != null)
		{
			this.KBOMNFNNOEH = EIHOJFGALMF["wofcoic"];
		}
		this.JKBLBOAHJDE = EIHOJFGALMF["OnStoryManInTheMiddleAttackDetected"];
		this.DMODNDCLGEJ = EIHOJFGALMF["signincancel"];
		this.EGKFHHBNNLM = EIHOJFGALMF["app42error"];
	}

	// Token: 0x060058D9 RID: 22745 RVA: 0x00281ECC File Offset: 0x002800CC
	public void OEBNAGLBADG(JSONObject EIHOJFGALMF)
	{
		this.DEJCCBNPFEC = EIHOJFGALMF["c_web"];
		this.OBKCKGHFMDN = OCBIOPOEENJ.FJFGMPMNHKP(EIHOJFGALMF["StoryChatManager.ShowMessageCoroutine(), unsupported message type:"].AsInt);
		this.ODMKLADKHMO = new LDLLJFOJCDF(EIHOJFGALMF["hdr"].AsInt);
		this.MPMKMCJFHOG = new LDLLJFOJCDF(EIHOJFGALMF["OnSaveSyncAnyResult"].AsInt);
		this.ABGNIKKFFAC = new LDLLJFOJCDF(EIHOJFGALMF[""].AsInt);
		this.MLNOFEEIBMI = new LDLLJFOJCDF(EIHOJFGALMF["app42error"].AsInt);
		this.OHCDIAFPNFK = new LDLLJFOJCDF(EIHOJFGALMF["eventended"].AsInt);
		this.PPACJFFFBFB = new LDLLJFOJCDF(EIHOJFGALMF[""].AsInt);
		this.EMHNNCBKIMG = new LDLLJFOJCDF(EIHOJFGALMF["skinshopinfounlocknow"].AsInt);
		this.OICPKCHAENO = new LDLLJFOJCDF(EIHOJFGALMF["OnStoryInterfaceHeaderSettingsClick"].AsInt);
		this.GGICIBLJIKI = new LDLLJFOJCDF(EIHOJFGALMF["app42error"].AsInt);
		this.CHLMAJLPIGC = (this.KBOMNFNNOEH = EIHOJFGALMF["geo.json"]);
		if (EIHOJFGALMF["backmaintenance"] != null)
		{
			this.KBOMNFNNOEH = EIHOJFGALMF[", already present in top match list."];
		}
		this.JKBLBOAHJDE = EIHOJFGALMF["OnBackendRequestFriendRejectException"];
		this.DMODNDCLGEJ = EIHOJFGALMF["Avatar pack has been destroyed:"];
		this.EGKFHHBNNLM = EIHOJFGALMF[""];
	}

	// Token: 0x060058DA RID: 22746 RVA: 0x00282088 File Offset: 0x00280288
	public bool MPJJANHFCDJ()
	{
		float num;
		return float.TryParse(this.EGKFHHBNNLM, NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num) && num > 1769f;
	}

	// Token: 0x060058DB RID: 22747 RVA: 0x002820B8 File Offset: 0x002802B8
	public bool OAOBICFCBDC()
	{
		float num;
		return float.TryParse(this.EGKFHHBNNLM, NumberStyles.Float, CultureInfo.InvariantCulture, out num) && num > 0f;
	}

	// Token: 0x060058DC RID: 22748 RVA: 0x002820E8 File Offset: 0x002802E8
	public bool CFAKBCLCFNP()
	{
		float num;
		return !float.TryParse(this.EGKFHHBNNLM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num) || num > 1236f;
	}

	// Token: 0x060058DD RID: 22749 RVA: 0x00282118 File Offset: 0x00280318
	public string FNJCEPLEPBH()
	{
		return this.EGKFHHBNNLM + " Руб.";
	}

	// Token: 0x060058DE RID: 22750 RVA: 0x0028212A File Offset: 0x0028032A
	public string KFEFIEMNLEK()
	{
		if (this.OKGPIEEOKBM())
		{
			return this.DOLEPIMNJLG();
		}
		return "friendsmaxlimitdefault" + this.JKBLBOAHJDE;
	}

	// Token: 0x060058DF RID: 22751 RVA: 0x0028214B File Offset: 0x0028034B
	public bool KIOLJNPKOOL()
	{
		return !this.KHBALPDBIAL() || OCBIOPOEENJ.MCLDCJGCHGN();
	}

	// Token: 0x060058E0 RID: 22752 RVA: 0x0028215C File Offset: 0x0028035C
	public static ProductType GDAIPKDLHIN(int MFFNNGPMIIA)
	{
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 0)
		{
			return ProductType.Consumable;
		}
		if (MFFNNGPMIIA == 2)
		{
			return ProductType.Consumable;
		}
		DPGJIJGOCIC.ANOPFDLPKGC("collect");
		return ProductType.NonConsumable;
	}

	// Token: 0x060058E1 RID: 22753 RVA: 0x0028217A File Offset: 0x0028037A
	public string KDPELFOFPBC()
	{
		if (this.OKGPIEEOKBM())
		{
			return this.FNJCEPLEPBH();
		}
		return "USD " + this.JKBLBOAHJDE;
	}

	// Token: 0x040018EB RID: 6379
	public string DEJCCBNPFEC;

	// Token: 0x040018EC RID: 6380
	public ProductType OBKCKGHFMDN;

	// Token: 0x040018ED RID: 6381
	public LDLLJFOJCDF ODMKLADKHMO;

	// Token: 0x040018EE RID: 6382
	public LDLLJFOJCDF MPMKMCJFHOG;

	// Token: 0x040018EF RID: 6383
	public LDLLJFOJCDF ABGNIKKFFAC;

	// Token: 0x040018F0 RID: 6384
	public LDLLJFOJCDF MLNOFEEIBMI;

	// Token: 0x040018F1 RID: 6385
	public LDLLJFOJCDF OHCDIAFPNFK;

	// Token: 0x040018F2 RID: 6386
	public LDLLJFOJCDF PPACJFFFBFB;

	// Token: 0x040018F3 RID: 6387
	public LDLLJFOJCDF EMHNNCBKIMG;

	// Token: 0x040018F4 RID: 6388
	public LDLLJFOJCDF OICPKCHAENO;

	// Token: 0x040018F5 RID: 6389
	public LDLLJFOJCDF GGICIBLJIKI;

	// Token: 0x040018F6 RID: 6390
	private string CHLMAJLPIGC;

	// Token: 0x040018F7 RID: 6391
	private string KBOMNFNNOEH;

	// Token: 0x040018F8 RID: 6392
	public string JKBLBOAHJDE;

	// Token: 0x040018F9 RID: 6393
	public string DMODNDCLGEJ;

	// Token: 0x040018FA RID: 6394
	public string EGKFHHBNNLM;
}
