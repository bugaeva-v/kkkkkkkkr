using System;
using System.Collections;
using System.Globalization;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200034B RID: 843
public class AppManager : MonoBehaviour
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06006363 RID: 25443 RVA: 0x002D7E38 File Offset: 0x002D6038
	public static AppManager EHBBFMCILPC
	{
		get
		{
			if (!AppManager.IKLAPGJDMNA)
			{
				AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
				if (!AppManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active AppManager script on a GameObject in your scene.");
				}
			}
			return AppManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06006364 RID: 25444 RVA: 0x002D7E85 File Offset: 0x002D6085
	public void OHFDJEJCDLG(bool NECIOJCNNBO, bool NJMJFPDAAEH)
	{
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("ant", 945f);
		AssetsManager.MJBDMHPHMID().ForceStopAllOperations();
		base.StartCoroutine(this.ELOMKGIFEHM(NECIOJCNNBO, NJMJFPDAAEH));
	}

	// Token: 0x06006365 RID: 25445 RVA: 0x002D7EB4 File Offset: 0x002D60B4
	public static AppManager AGANFKKBPFO()
	{
		if (!AppManager.IKLAPGJDMNA)
		{
			AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
			if (!AppManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("continue");
			}
		}
		return AppManager.IKLAPGJDMNA;
	}

	// Token: 0x06006366 RID: 25446 RVA: 0x002D7F01 File Offset: 0x002D6101
	public bool IsDevelopmentEnvironment()
	{
		return this.environmentSettings.appEnvironment == DIMDLMAMCED.Development;
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x002D7F11 File Offset: 0x002D6111
	public static bool CCDBEDIANDN()
	{
		if (!AppManager.IKLAPGJDMNA)
		{
			AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
			return AppManager.IKLAPGJDMNA || true;
		}
		return true;
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x002D7F4C File Offset: 0x002D614C
	public int GKJDNDOEBJP()
	{
		int num = this.environmentSettings.appVersion.LastIndexOf((char)-56);
		return Convert.ToInt32(this.environmentSettings.appVersion.Substring(num + 1));
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x002D7F84 File Offset: 0x002D6184
	private void HKHKMPLGKBO()
	{
		if (AppManager.IKLAPGJDMNA == this)
		{
			AppManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x002D7F99 File Offset: 0x002D6199
	public static bool IsInitialized()
	{
		if (!AppManager.IKLAPGJDMNA)
		{
			AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
			return AppManager.IKLAPGJDMNA;
		}
		return true;
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x002D7FD4 File Offset: 0x002D61D4
	public int BKBGOJLPPIM()
	{
		int num = this.environmentSettings.appVersion.LastIndexOf('\u001c');
		return Convert.ToInt32(this.environmentSettings.appVersion.Substring(num + 0));
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x002D800C File Offset: 0x002D620C
	private void KEFINAHEDNC(bool HGLNJBCALFD)
	{
		if (HGLNJBCALFD)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x002D801C File Offset: 0x002D621C
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		DOTween.Init(new bool?(false), new bool?(true), new LogBehaviour?(LogBehaviour.ErrorsOnly));
		try
		{
			CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		Screen.sleepTimeout = -1;
		AKLFPGMDKLA.EHBBFMCILPC.OJFKDIOBLIG();
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x002D8080 File Offset: 0x002D6280
	public bool IAKAINEBFBO(int KJAMBAABKLM)
	{
		return this.GetRevision() < KJAMBAABKLM;
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x002D808E File Offset: 0x002D628E
	public void KKNKNOELPPO(bool NECIOJCNNBO, bool NJMJFPDAAEH)
	{
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("avatarcollectionsuntitle", 1785f);
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		base.StartCoroutine(this.IANDANKLCNB(NECIOJCNNBO, NJMJFPDAAEH));
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x002D80BD File Offset: 0x002D62BD
	private void BKNGGJFCHIK()
	{
		ODLLAEHMFAA.NFFGMDALKCE();
		FADIGFEOCND.POOABKCOPAO();
		HPEFPHOKGLJ.CJJDKFEGFKE();
		AOBJLALDBAA.EHBBFMCILPC.CEIDMENJBNK();
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x002D8080 File Offset: 0x002D6280
	public bool UpdateAvailable(int KJAMBAABKLM)
	{
		return this.GetRevision() < KJAMBAABKLM;
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x002D8080 File Offset: 0x002D6280
	public bool UnsupportedRevision(int GGIJPOABBHM)
	{
		return this.GetRevision() < GGIJPOABBHM;
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x002D80D8 File Offset: 0x002D62D8
	private void OnApplicationQuit()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x002D80E4 File Offset: 0x002D62E4
	public bool GOJPLFBMCNJ(int GGIJPOABBHM)
	{
		return this.GKJDNDOEBJP() < GGIJPOABBHM;
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x002D800C File Offset: 0x002D620C
	private void OnApplicationPause(bool HGLNJBCALFD)
	{
		if (HGLNJBCALFD)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x002D800C File Offset: 0x002D620C
	private void LPFDLCGOPJE(bool HGLNJBCALFD)
	{
		if (HGLNJBCALFD)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x002D80F4 File Offset: 0x002D62F4
	public static AppManager PCJEMMDDCIF()
	{
		if (!AppManager.IKLAPGJDMNA)
		{
			AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
			if (!AppManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("rt");
			}
		}
		return AppManager.IKLAPGJDMNA;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x002D8141 File Offset: 0x002D6341
	private IEnumerator IANDANKLCNB(bool NECIOJCNNBO, bool NJMJFPDAAEH)
	{
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield return new WaitForEndOfFrame();
		if (NECIOJCNNBO)
		{
			NAHMBEODKJC.OBDBLLHBGLE();
			AssetsManager.EHBBFMCILPC.SetDirty();
		}
		if (NJMJFPDAAEH)
		{
			EEIBKLDNBAP.NHKGIOOFKHM();
			NAHMBEODKJC.OBDBLLHBGLE();
			AssetsManager.EHBBFMCILPC.SetCacheDirty();
		}
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.Disable();
		CommonUserInterface.EHBBFMCILPC.EnableRestartFade();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationRestart", 0f);
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SceneManager.LoadScene("SceneRestart");
		yield break;
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x002D800C File Offset: 0x002D620C
	private void FEMKLHIJGPA(bool HGLNJBCALFD)
	{
		if (HGLNJBCALFD)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x002D8158 File Offset: 0x002D6358
	public int GetRevision()
	{
		int num = this.environmentSettings.appVersion.LastIndexOf('.');
		return Convert.ToInt32(this.environmentSettings.appVersion.Substring(num + 1));
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x002D8190 File Offset: 0x002D6390
	public bool FPPCJOHDDDK(int GGIJPOABBHM)
	{
		return this.MDILOPMAKEK() >= GGIJPOABBHM;
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x002D8141 File Offset: 0x002D6341
	private IEnumerator ELOMKGIFEHM(bool NECIOJCNNBO, bool NJMJFPDAAEH)
	{
		yield return new WaitForEndOfFrame();
		while (AssetsManager.EHBBFMCILPC.IsBusy())
		{
			yield return new WaitForSeconds(0.05f);
		}
		yield return new WaitForEndOfFrame();
		if (NECIOJCNNBO)
		{
			NAHMBEODKJC.OBDBLLHBGLE();
			AssetsManager.EHBBFMCILPC.SetDirty();
		}
		if (NJMJFPDAAEH)
		{
			EEIBKLDNBAP.NHKGIOOFKHM();
			NAHMBEODKJC.OBDBLLHBGLE();
			AssetsManager.EHBBFMCILPC.SetCacheDirty();
		}
		CommonUserInterface.EHBBFMCILPC.Reset();
		CommonUserInterface.EHBBFMCILPC.Disable();
		CommonUserInterface.EHBBFMCILPC.EnableRestartFade();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationRestart", 0f);
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SceneManager.LoadScene("SceneRestart");
		yield break;
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x002D7F84 File Offset: 0x002D6184
	private void OnDestroy()
	{
		if (AppManager.IKLAPGJDMNA == this)
		{
			AppManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x002D819E File Offset: 0x002D639E
	public void RestartApp(bool NECIOJCNNBO, bool NJMJFPDAAEH)
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationBeforeRestart", 0f);
		AssetsManager.EHBBFMCILPC.ForceStopAllOperations();
		base.StartCoroutine(this.IANDANKLCNB(NECIOJCNNBO, NJMJFPDAAEH));
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x002D81D0 File Offset: 0x002D63D0
	public static AppManager JMDJPKKOHNI()
	{
		if (!AppManager.IKLAPGJDMNA)
		{
			AppManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AppManager)) as AppManager);
			if (!AppManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("apkshe2");
			}
		}
		return AppManager.IKLAPGJDMNA;
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x002D8220 File Offset: 0x002D6420
	public int MDILOPMAKEK()
	{
		int num = this.environmentSettings.appVersion.LastIndexOf('m');
		return Convert.ToInt32(this.environmentSettings.appVersion.Substring(num + 1));
	}

	// Token: 0x06006382 RID: 25474 RVA: 0x002D800C File Offset: 0x002D620C
	private void IIMENCHACLA(bool HGLNJBCALFD)
	{
		if (HGLNJBCALFD)
		{
			AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		}
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x002D8258 File Offset: 0x002D6458
	private void HIIFPFHIDEP()
	{
		ODLLAEHMFAA.GPHOBCEMEMN();
		FADIGFEOCND.GLKDEMNJKEF();
		HPEFPHOKGLJ.BKNGGJFCHIK();
		AOBJLALDBAA.KKPFOJMAONG().CPIBMIOJIJL();
	}

	// Token: 0x06006384 RID: 25476 RVA: 0x002D8273 File Offset: 0x002D6473
	private void Update()
	{
		ODLLAEHMFAA.IIPBKOPAGBK();
		FADIGFEOCND.IIPBKOPAGBK();
		HPEFPHOKGLJ.IIPBKOPAGBK();
		AOBJLALDBAA.EHBBFMCILPC.IIPBKOPAGBK();
	}

	// Token: 0x04001CE9 RID: 7401
	public const string onApplicationRestart = "OnApplicationRestart";

	// Token: 0x04001CEA RID: 7402
	public const string onApplicationBeforeRestart = "OnApplicationBeforeRestart";

	// Token: 0x04001CEB RID: 7403
	public static bool isQuitting;

	// Token: 0x04001CEC RID: 7404
	public EnvironmentSettings environmentSettings;

	// Token: 0x04001CED RID: 7405
	public DebugSettings debugSettings;

	// Token: 0x04001CEE RID: 7406
	private static AppManager IKLAPGJDMNA;
}
