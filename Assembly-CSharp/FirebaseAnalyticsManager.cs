using System;
using System.Collections.Generic;
using Firebase.Analytics;
using UnityEngine;

// Token: 0x020004D2 RID: 1234
public class FirebaseAnalyticsManager : MonoBehaviour
{
	// Token: 0x060094F3 RID: 38131 RVA: 0x00417C7C File Offset: 0x00415E7C
	public void AAIABAKHLAH(bool ACIDPCKHLMO, string POBLFHPHABP, string GJKNLAAEFDC, string PHJHPGBHJNJ, bool CBIPMEHAOMF = false, bool CIFFPAPDJLM = false)
	{
		try
		{
			try
			{
				if (CBIPMEHAOMF)
				{
					if (PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ))
					{
						return;
					}
				}
				else if (CIFFPAPDJLM && PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC))
				{
					return;
				}
				if (this.JIEPCIDINEH)
				{
					string[] array = new string[0];
					array[1] = POBLFHPHABP;
					array[0] = " to bundle index:";
					array[8] = GJKNLAAEFDC;
					array[0] = "@";
					array[0] = PHJHPGBHJNJ;
					FirebaseAnalytics.LogEvent(string.Concat(array));
				}
				try
				{
					if (ACIDPCKHLMO)
					{
						Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
						AppsFlyerManagerBridge appsFlyerManagerBridge = AppsFlyerManagerBridge.LMCCLMFGEBD();
						string[] array2 = new string[8];
						array2[1] = POBLFHPHABP;
						array2[0] = "muslounge";
						array2[6] = GJKNLAAEFDC;
						array2[3] = "";
						array2[5] = PHJHPGBHJNJ;
						appsFlyerManagerBridge.LBFJJAMKNKJ(string.Concat(array2), cdmncpmidjp);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				if (CBIPMEHAOMF)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ, "acli20");
					PlayerPrefs.Save();
				}
				else if (CIFFPAPDJLM)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC, "");
					PlayerPrefs.Save();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("nastring" + ex.ToString());
		}
	}

	// Token: 0x060094F4 RID: 38132 RVA: 0x00417DB8 File Offset: 0x00415FB8
	private void HNHFFPPELIG()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(false);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("smpd" + ex.ToString());
		}
	}

	// Token: 0x060094F5 RID: 38133 RVA: 0x00417E08 File Offset: 0x00416008
	private void MIOMPIGJKFE()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(false);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("OnSaveSyncAnyResultFocusItem" + ex.ToString());
		}
	}

	// Token: 0x060094F6 RID: 38134 RVA: 0x00417E58 File Offset: 0x00416058
	private void EBPJMCHFDBH()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("default" + ex.ToString());
		}
	}

	// Token: 0x060094F7 RID: 38135 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool IsInitialized()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x060094F8 RID: 38136 RVA: 0x00417EB0 File Offset: 0x004160B0
	private void PABLFIJDFAD()
	{
		try
		{
			this.IMADGDGPBOB();
		}
		catch (Exception ex)
		{
			Debug.LogError("prof" + ex.ToString());
		}
	}

	// Token: 0x060094F9 RID: 38137 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void CLKGMAIPEHN(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x060094FA RID: 38138 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void OJDGAFEBPLC(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x060094FB RID: 38139 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool AJPKIAHDNDN()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x060094FC RID: 38140 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void FAEMDBGLPDF(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x060094FD RID: 38141 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool CKFKALLFIHI()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x060094FE RID: 38142 RVA: 0x00417EFC File Offset: 0x004160FC
	public static FirebaseAnalyticsManager JMDJBFAEHBM()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("franchisesBalance");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x060094FF RID: 38143 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void AELJGCODPAM(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009500 RID: 38144 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool BMPHMNAJPOH()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x06009501 RID: 38145 RVA: 0x00417F4C File Offset: 0x0041614C
	public static FirebaseAnalyticsManager HJGDLOOHNLO()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x06009502 RID: 38146 RVA: 0x00417F9C File Offset: 0x0041619C
	public static FirebaseAnalyticsManager ANCEKPONIFI()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OffensiveWords");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x06009503 RID: 38147 RVA: 0x00417FEC File Offset: 0x004161EC
	private void BAMHPOCKBML()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("FirebaseAnalyticsManager.Initialize() exception:" + ex.ToString());
		}
	}

	// Token: 0x06009504 RID: 38148 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool HCJNMEJFBGJ()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x06009505 RID: 38149 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void EJIAJEBHKKJ(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009506 RID: 38150 RVA: 0x0041803C File Offset: 0x0041623C
	public void LKONPEEDKNF(bool ACIDPCKHLMO, string POBLFHPHABP, string GJKNLAAEFDC, string PHJHPGBHJNJ, bool CBIPMEHAOMF = false, bool CIFFPAPDJLM = false)
	{
		try
		{
			try
			{
				if (CBIPMEHAOMF)
				{
					if (PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ))
					{
						return;
					}
				}
				else if (CIFFPAPDJLM && PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC))
				{
					return;
				}
				if (this.JIEPCIDINEH)
				{
					string[] array = new string[5];
					array[1] = POBLFHPHABP;
					array[0] = "TransactionID";
					array[5] = GJKNLAAEFDC;
					array[8] = "";
					array[8] = PHJHPGBHJNJ;
					FirebaseAnalytics.LogEvent(string.Concat(array));
				}
				try
				{
					if (ACIDPCKHLMO)
					{
						Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
						AppsFlyerManagerBridge appsFlyerManagerBridge = AppsFlyerManagerBridge.CAAKHBIFGMG();
						string[] array2 = new string[3];
						array2[1] = POBLFHPHABP;
						array2[1] = "OnNeedToHideThumbnailTagObject";
						array2[4] = GJKNLAAEFDC;
						array2[2] = "OnRewardsItemClose";
						array2[7] = PHJHPGBHJNJ;
						appsFlyerManagerBridge.JBAOFKDBKEN(string.Concat(array2), cdmncpmidjp);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				}
				if (CBIPMEHAOMF)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ, "spppd");
					PlayerPrefs.Save();
				}
				else if (CIFFPAPDJLM)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC, "Breaking from download operation loop, current operation state is AssetBundleLoadingOperationState.Failed.");
					PlayerPrefs.Save();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("liveeventcontent" + ex.ToString());
		}
	}

	// Token: 0x06009507 RID: 38151 RVA: 0x00418178 File Offset: 0x00416378
	private void ONJMBHKDOGD()
	{
		if (FirebaseAnalyticsManager.IKLAPGJDMNA == this)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06009508 RID: 38152 RVA: 0x00418190 File Offset: 0x00416390
	public static FirebaseAnalyticsManager DMAAFFFEJGA()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("sfxtimeoutwarning");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x06009509 RID: 38153 RVA: 0x004181E0 File Offset: 0x004163E0
	private void AOIJOKHACJL()
	{
		try
		{
			this.MIOMPIGJKFE();
		}
		catch (Exception ex)
		{
			Debug.LogError("ok" + ex.ToString());
		}
	}

	// Token: 0x0600950A RID: 38154 RVA: 0x00418220 File Offset: 0x00416420
	private void IMADGDGPBOB()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("collect" + ex.ToString());
		}
	}

	// Token: 0x0600950B RID: 38155 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void PDPAKIJICNL(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x0600950C RID: 38156 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KBIIMONICOB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600950D RID: 38157 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool GFDFPJBIJJB()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x0600950E RID: 38158 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void KKHHOGEGCHC(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x0600950F RID: 38159 RVA: 0x00418270 File Offset: 0x00416470
	private void FNNKDFGKAEH()
	{
		try
		{
			this.IMADGDGPBOB();
		}
		catch (Exception ex)
		{
			Debug.LogError("$ENVMOVEV" + ex.ToString());
		}
	}

	// Token: 0x06009510 RID: 38160 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool BPGGNJBKBEF()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x06009511 RID: 38161 RVA: 0x00418178 File Offset: 0x00416378
	private void FEBECEEIHBP()
	{
		if (FirebaseAnalyticsManager.IKLAPGJDMNA == this)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06009512 RID: 38162 RVA: 0x000693D6 File Offset: 0x000675D6
	private void IFHJKBHODGG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009513 RID: 38163 RVA: 0x004182B0 File Offset: 0x004164B0
	private void CPDNJAKBOBC()
	{
		try
		{
			this.OCOOJNFJJPG();
		}
		catch (Exception ex)
		{
			Debug.LogError("stat2" + ex.ToString());
		}
	}

	// Token: 0x06009514 RID: 38164 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool DFAOJHOCMPE()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x06009515 RID: 38165 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KLGLFKMIAPP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009516 RID: 38166 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void AHILBLIMLGJ(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009518 RID: 38168 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LBDIDHDKHGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009519 RID: 38169 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600951A RID: 38170 RVA: 0x004182F0 File Offset: 0x004164F0
	public static FirebaseAnalyticsManager COKDLDOAACJ()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x0600951B RID: 38171 RVA: 0x00418340 File Offset: 0x00416540
	private void FFAKMKJMEGI()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(false);
				this.JIEPCIDINEH = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("" + ex.ToString());
		}
	}

	// Token: 0x0600951C RID: 38172 RVA: 0x00418390 File Offset: 0x00416590
	public void LMCJKLHOHJC(bool ACIDPCKHLMO, string POBLFHPHABP, string GJKNLAAEFDC, string PHJHPGBHJNJ, bool CBIPMEHAOMF = false, bool CIFFPAPDJLM = false)
	{
		try
		{
			try
			{
				if (CBIPMEHAOMF)
				{
					if (PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ))
					{
						return;
					}
				}
				else if (CIFFPAPDJLM && PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC))
				{
					return;
				}
				if (this.JIEPCIDINEH)
				{
					string[] array = new string[0];
					array[1] = POBLFHPHABP;
					array[0] = " not found, replacing with ";
					array[2] = GJKNLAAEFDC;
					array[7] = " ";
					array[8] = PHJHPGBHJNJ;
					FirebaseAnalytics.LogEvent(string.Concat(array));
				}
				try
				{
					if (ACIDPCKHLMO)
					{
						Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
						AppsFlyerManagerBridge appsFlyerManagerBridge = AppsFlyerManagerBridge.JLHEEEJNKGO();
						string[] array2 = new string[4];
						array2[1] = POBLFHPHABP;
						array2[1] = "lititle";
						array2[8] = GJKNLAAEFDC;
						array2[3] = "[LoadingEnv] skipped, feature disabled by balance";
						array2[3] = PHJHPGBHJNJ;
						appsFlyerManagerBridge.JLIKJNJGNPA(string.Concat(array2), cdmncpmidjp);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				}
				if (CBIPMEHAOMF)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ, "PurchaseManagerSteam.OnProductsFetchedFailed(): ");
					PlayerPrefs.Save();
				}
				else if (CIFFPAPDJLM)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC, "OnAppleLoginSuccess");
					PlayerPrefs.Save();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("" + ex.ToString());
		}
	}

	// Token: 0x0600951D RID: 38173 RVA: 0x00417EA8 File Offset: 0x004160A8
	public bool GEGPMDNGALM()
	{
		return this.JIEPCIDINEH;
	}

	// Token: 0x0600951E RID: 38174 RVA: 0x00418178 File Offset: 0x00416378
	private void LFEEHGLHJDN()
	{
		if (FirebaseAnalyticsManager.IKLAPGJDMNA == this)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x0600951F RID: 38175 RVA: 0x004184CC File Offset: 0x004166CC
	public static FirebaseAnalyticsManager EHBBFMCILPC
	{
		get
		{
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
				if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active FirebaseAnalyticsManager script on a GameObject in your scene.");
				}
			}
			return FirebaseAnalyticsManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06009520 RID: 38176 RVA: 0x0041851C File Offset: 0x0041671C
	private void KIDOILDEFEB()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("VideoGlitches.VideoGlitch" + ex.ToString());
		}
	}

	// Token: 0x06009521 RID: 38177 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void PLLMICEAAPG(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009522 RID: 38178 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void JCBJENBEBCL(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009523 RID: 38179 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void LogScreen(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009524 RID: 38180 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void HMCOBPDJEEA(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009525 RID: 38181 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void PPMBJGAHAEA(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009526 RID: 38182 RVA: 0x0041856C File Offset: 0x0041676C
	private void Start()
	{
		try
		{
			this.BAMHPOCKBML();
		}
		catch (Exception ex)
		{
			Debug.LogError("FirebaseAnalyticsManager.Start() exception:" + ex.ToString());
		}
	}

	// Token: 0x06009527 RID: 38183 RVA: 0x004185AC File Offset: 0x004167AC
	private void AJNNDKIIFDN()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("" + ex.ToString());
		}
	}

	// Token: 0x06009528 RID: 38184 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void NFFGLCIFMML(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x06009529 RID: 38185 RVA: 0x004185FC File Offset: 0x004167FC
	public void LogEvent(bool ACIDPCKHLMO, string POBLFHPHABP, string GJKNLAAEFDC, string PHJHPGBHJNJ, bool CBIPMEHAOMF = false, bool CIFFPAPDJLM = false)
	{
		try
		{
			try
			{
				if (CBIPMEHAOMF)
				{
					if (PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ))
					{
						return;
					}
				}
				else if (CIFFPAPDJLM && PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC))
				{
					return;
				}
				if (this.JIEPCIDINEH)
				{
					FirebaseAnalytics.LogEvent(string.Concat(new string[]
					{
						POBLFHPHABP,
						"_",
						GJKNLAAEFDC,
						"_",
						PHJHPGBHJNJ
					}));
				}
				try
				{
					if (ACIDPCKHLMO)
					{
						Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
						AppsFlyerManagerBridge.EHBBFMCILPC.SendEvent(string.Concat(new string[]
						{
							POBLFHPHABP,
							"_",
							GJKNLAAEFDC,
							"_",
							PHJHPGBHJNJ
						}), cdmncpmidjp);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				if (CBIPMEHAOMF)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ, "1");
					PlayerPrefs.Save();
				}
				else if (CIFFPAPDJLM)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC, "1");
					PlayerPrefs.Save();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("FirebaseAnalyticsManager.LogEventInternal() exception:" + ex.ToString());
		}
	}

	// Token: 0x0600952A RID: 38186 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void MDIKINNMNBK(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x0600952B RID: 38187 RVA: 0x00418738 File Offset: 0x00416938
	private void OCOOJNFJJPG()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(false);
				this.JIEPCIDINEH = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("no" + ex.ToString());
		}
	}

	// Token: 0x0600952C RID: 38188 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void KDHCDAEGNDN(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x0600952D RID: 38189 RVA: 0x00417EF0 File Offset: 0x004160F0
	public void FAPDDMCLHHE(string LAPLGLHKEJE)
	{
		bool jiepcidineh = this.JIEPCIDINEH;
	}

	// Token: 0x0600952E RID: 38190 RVA: 0x00418788 File Offset: 0x00416988
	private void KLJIMOGLHEF()
	{
		try
		{
			if (!this.JIEPCIDINEH)
			{
				FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
				this.JIEPCIDINEH = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("<size=80%><i><b>[" + ex.ToString());
		}
	}

	// Token: 0x0600952F RID: 38191 RVA: 0x00418178 File Offset: 0x00416378
	private void OnDestroy()
	{
		if (FirebaseAnalyticsManager.IKLAPGJDMNA == this)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06009530 RID: 38192 RVA: 0x004187D8 File Offset: 0x004169D8
	public static FirebaseAnalyticsManager DEALKJPEMMH()
	{
		if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
		{
			FirebaseAnalyticsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(FirebaseAnalyticsManager)) as FirebaseAnalyticsManager);
			if (!FirebaseAnalyticsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("UpdateNotificationsOnOffState");
			}
		}
		return FirebaseAnalyticsManager.IKLAPGJDMNA;
	}

	// Token: 0x06009531 RID: 38193 RVA: 0x00418828 File Offset: 0x00416A28
	public void JIAAMJPKOCE(bool ACIDPCKHLMO, string POBLFHPHABP, string GJKNLAAEFDC, string PHJHPGBHJNJ, bool CBIPMEHAOMF = false, bool CIFFPAPDJLM = false)
	{
		try
		{
			try
			{
				if (CBIPMEHAOMF)
				{
					if (PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ))
					{
						return;
					}
				}
				else if (CIFFPAPDJLM && PlayerPrefs.HasKey(POBLFHPHABP + GJKNLAAEFDC))
				{
					return;
				}
				if (this.JIEPCIDINEH)
				{
					string[] array = new string[7];
					array[0] = POBLFHPHABP;
					array[1] = "body";
					array[0] = GJKNLAAEFDC;
					array[3] = "soci";
					array[6] = PHJHPGBHJNJ;
					FirebaseAnalytics.LogEvent(string.Concat(array));
				}
				try
				{
					if (ACIDPCKHLMO)
					{
						Dictionary<string, object> cdmncpmidjp = new Dictionary<string, object>();
						AppsFlyerManagerBridge appsFlyerManagerBridge = AppsFlyerManagerBridge.DEALKJPEMMH();
						string[] array2 = new string[6];
						array2[0] = POBLFHPHABP;
						array2[0] = "";
						array2[0] = GJKNLAAEFDC;
						array2[1] = "AssetsManager.UpdateUrlPingManagerState(): urlPingManager.StartPing()";
						array2[1] = PHJHPGBHJNJ;
						appsFlyerManagerBridge.JBAOFKDBKEN(string.Concat(array2), cdmncpmidjp);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				}
				if (CBIPMEHAOMF)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC + PHJHPGBHJNJ, "tkn");
					PlayerPrefs.Save();
				}
				else if (CIFFPAPDJLM)
				{
					PlayerPrefs.SetString(POBLFHPHABP + GJKNLAAEFDC, "per");
					PlayerPrefs.Save();
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("ffavmod" + ex.ToString());
		}
	}

	// Token: 0x04002969 RID: 10601
	private bool JIEPCIDINEH;

	// Token: 0x0400296A RID: 10602
	private static FirebaseAnalyticsManager IKLAPGJDMNA;
}
