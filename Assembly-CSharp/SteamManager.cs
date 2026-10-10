using System;
using System.Text;
using AOT;
using Steamworks;
using UnityEngine;

// Token: 0x020003D4 RID: 980
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	// Token: 0x0600717A RID: 29050 RVA: 0x003323CB File Offset: 0x003305CB
	public static bool DDNMDJMBMFB()
	{
		return SteamManager.PEBMGCKFNAO().OEFEMFFEKCJ;
	}

	// Token: 0x0600717B RID: 29051 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void FKOPCAFJEKE()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x0600717C RID: 29052 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void IJCGEFMHPBN()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x0600717D RID: 29053 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void CEFBBPMOADD()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x0600717E RID: 29054 RVA: 0x0033240B File Offset: 0x0033060B
	public static bool CIODMAKCBFK()
	{
		return SteamManager.AIMEBOBBHMC().OEFEMFFEKCJ;
	}

	// Token: 0x0600717F RID: 29055 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void PIHOFDGILPJ()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x06007180 RID: 29056 RVA: 0x00332417 File Offset: 0x00330617
	public static SteamManager BFHKGNBFHCH()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("time").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x06007181 RID: 29057 RVA: 0x0033243B File Offset: 0x0033063B
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
		SteamManager.ICLOCOCICJO = false;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x06007182 RID: 29058 RVA: 0x0033244C File Offset: 0x0033064C
	protected virtual void KLGLFKMIAPP()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("retry");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("endsInSeconds", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("SocialStatsUserPublicProfile.modified = false, OpenUserPublicProfile()", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(26U)))
			{
				Debug.Log("pm");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "no";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("-", this);
			return;
		}
		SteamManager.ICLOCOCICJO = true;
	}

	// Token: 0x06007183 RID: 29059 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void GABEMLNNOIF()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x06007184 RID: 29060 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x06007185 RID: 29061 RVA: 0x00332538 File Offset: 0x00330738
	protected virtual void LLGBJHCIIGA()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.JNPDPEKAJCO);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x06007186 RID: 29062 RVA: 0x00332586 File Offset: 0x00330786
	public static SteamManager LKMHNGJFMNE()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("aec").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x06007187 RID: 29063 RVA: 0x0033240B File Offset: 0x0033060B
	public static bool GODLNCADCJD()
	{
		return SteamManager.AIMEBOBBHMC().OEFEMFFEKCJ;
	}

	// Token: 0x06007188 RID: 29064 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void BKLLPIBAGGO()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x06007189 RID: 29065 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void KODGAJHJLLH()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x0600718A RID: 29066 RVA: 0x003325AC File Offset: 0x003307AC
	protected virtual void LIHMCECHLOI()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("vhspause_1");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("spectrumovr", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("abaep", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(22U)))
			{
				Debug.Log("OnFullscreenLiveOfferContinueToPurchasingScreen");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "p";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("suid", this);
			return;
		}
		SteamManager.ICLOCOCICJO = true;
	}

	// Token: 0x0600718B RID: 29067 RVA: 0x00332698 File Offset: 0x00330898
	protected virtual void LCCCCHNJEMB()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("OnVideoLayerAutoHide");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("importanttitle", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("eng", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967157U)))
			{
				Debug.Log("{0} is not a valid asset bundle.");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "XXX";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("There needs to be one active SteamSignInManager script on a GameObject in your scene.", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x0600718C RID: 29068 RVA: 0x00332784 File Offset: 0x00330984
	public static SteamManager CJBGOFHGBEM()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("p").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x0600718D RID: 29069 RVA: 0x003327A8 File Offset: 0x003309A8
	protected virtual void IODOFKJEIFD()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.KNEOPDAAOCA);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x0600718E RID: 29070 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void NGEFPBFMCBP()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x0600718F RID: 29071 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLAIJHABAKI()
	{
	}

	// Token: 0x06007190 RID: 29072 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void HGNPNNKGNLG()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x003323CB File Offset: 0x003305CB
	public static bool EABECBIBNKG()
	{
		return SteamManager.PEBMGCKFNAO().OEFEMFFEKCJ;
	}

	// Token: 0x06007193 RID: 29075 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06007194 RID: 29076 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void PNEBOIIJMDK()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x06007195 RID: 29077 RVA: 0x003327F6 File Offset: 0x003309F6
	public static bool MEDHKJGPAHJ()
	{
		return SteamManager.DEALKJPEMMH().OEFEMFFEKCJ;
	}

	// Token: 0x06007196 RID: 29078 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void JCEBDOJAHEI(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x06007197 RID: 29079 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06007198 RID: 29080 RVA: 0x0033280A File Offset: 0x00330A0A
	public static bool INNIOKCONIH()
	{
		return SteamManager.LKMHNGJFMNE().OEFEMFFEKCJ;
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06007199 RID: 29081 RVA: 0x00332816 File Offset: 0x00330A16
	public static SteamManager EHBBFMCILPC
	{
		get
		{
			if (SteamManager.FLJJFCBPNII == null)
			{
				return new GameObject("SteamManager").AddComponent<SteamManager>();
			}
			return SteamManager.FLJJFCBPNII;
		}
	}

	// Token: 0x0600719A RID: 29082 RVA: 0x0033283A File Offset: 0x00330A3A
	private static void NIOLFHBEADH()
	{
		SteamManager.ICLOCOCICJO = true;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x0600719B RID: 29083 RVA: 0x00332848 File Offset: 0x00330A48
	public static SteamManager AIMEBOBBHMC()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("onPopupCardOptionsCloseClick").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x0600719C RID: 29084 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void OOLNFCCAEDF(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x0600719D RID: 29085 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void HDCNGGPPGOP()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x0600719E RID: 29086 RVA: 0x00003E52 File Offset: 0x00002052
	private void CKKAKPFCPEG()
	{
	}

	// Token: 0x0600719F RID: 29087 RVA: 0x0033286C File Offset: 0x00330A6C
	protected virtual void AILHMCGEMOG()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.LDCFDMBNGMB);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071A0 RID: 29088 RVA: 0x003328BA File Offset: 0x00330ABA
	public static bool PFIOFAJGDAB()
	{
		return SteamManager.CJBGOFHGBEM().OEFEMFFEKCJ;
	}

	// Token: 0x060071A1 RID: 29089 RVA: 0x003328C8 File Offset: 0x00330AC8
	protected virtual void OnEnable()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.JNPDPEKAJCO);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071A2 RID: 29090 RVA: 0x00332916 File Offset: 0x00330B16
	public static SteamManager PEBMGCKFNAO()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("genre_lgbtq").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x060071A3 RID: 29091 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void IGNHKDONHED()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071A4 RID: 29092 RVA: 0x0033293C File Offset: 0x00330B3C
	protected virtual void KBGANABGEMK()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("prof");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("onAppOpenAttributionFailure", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("[FlagAnimator] Shader 'YourStory/FlagCloth' NOT FOUND. Check that FlagCloth.shader is imported in the project.", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967283U)))
			{
				Debug.Log("lsc");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "Vignette tube scale";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("p", this);
			return;
		}
		SteamManager.ICLOCOCICJO = true;
	}

	// Token: 0x060071A5 RID: 29093 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void LDPOIIIAIOA()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071A6 RID: 29094 RVA: 0x0033280A File Offset: 0x00330A0A
	public static bool GGCJHMIKCNO()
	{
		return SteamManager.LKMHNGJFMNE().OEFEMFFEKCJ;
	}

	// Token: 0x060071A7 RID: 29095 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void FCBAJMIJPMK()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071A8 RID: 29096 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void PCEFEFJKNCG(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x00003E52 File Offset: 0x00002052
	private void JCOIBJANCMG()
	{
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x00003E52 File Offset: 0x00002052
	private void KJFHBHJPFFI()
	{
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x00332A28 File Offset: 0x00330C28
	protected virtual void Awake()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(2433470U)))
			{
				Debug.Log("[Steamworks.NET] Shutting down because RestartAppIfNecessary returned true. Steam will restart the application.");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this);
			return;
		}
		SteamManager.ICLOCOCICJO = true;
	}

	// Token: 0x060071AC RID: 29100 RVA: 0x00332B14 File Offset: 0x00330D14
	protected virtual void GMPHANBKGBK()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("PurchaseManagerSteam.StartPurchase(): A purchase or validation is in progress. Aborting.");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("OnPopupStoryRestartManagerRestartStory2", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("stat3long", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967243U)))
			{
				Debug.Log("story");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "abce";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError(" ", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071AD RID: 29101 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060071AE RID: 29102 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void JBMBMNAIIHF()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071AF RID: 29103 RVA: 0x00332C00 File Offset: 0x00330E00
	public static bool KJFOJJLPLIG()
	{
		return SteamManager.BFHKGNBFHCH().OEFEMFFEKCJ;
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x00332C0C File Offset: 0x00330E0C
	public static SteamManager HJGDLOOHNLO()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("importanttitle").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x00332C30 File Offset: 0x00330E30
	public static bool DBILKJDELFK()
	{
		return SteamManager.HJGDLOOHNLO().OEFEMFFEKCJ;
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x0033243B File Offset: 0x0033063B
	private static void GECPAPEFMLA()
	{
		SteamManager.ICLOCOCICJO = false;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void EHDCMMHJMNO(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void OnDestroy()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void PJIOJHOMBCB()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071B6 RID: 29110 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void GKBKDDGBAGK()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void EKDOLKJEJFI(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void Update()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x00332C3C File Offset: 0x00330E3C
	protected virtual void HJMKOELKODM()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("Account.DuplicateAnthologySaveSlot(), a story save could not be copied, the target slot was cleared, anthology:");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("hintprocessing", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("anthology", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(46U)))
			{
				Debug.Log("signinsuccess");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError(":", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071BA RID: 29114 RVA: 0x00332D28 File Offset: 0x00330F28
	protected virtual void OHHHLCLEMGB()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.GNBCMBBODPD);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071BB RID: 29115 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void OLIACOCGJNA()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071BC RID: 29116 RVA: 0x00332C30 File Offset: 0x00330E30
	public static bool JJODFGPAPCG()
	{
		return SteamManager.HJGDLOOHNLO().OEFEMFFEKCJ;
	}

	// Token: 0x060071BD RID: 29117 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void KNBBPNKLFAA()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071BE RID: 29118 RVA: 0x00332D76 File Offset: 0x00330F76
	public static SteamManager DEALKJPEMMH()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("aindas1").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x060071BF RID: 29119 RVA: 0x00332D9A File Offset: 0x00330F9A
	public static SteamManager NLDDLLEKNFD()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("ok").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x060071C0 RID: 29120 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x060071C1 RID: 29121 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void LDCFDMBNGMB(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071C2 RID: 29122 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void ANLDAHFMHHB(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071C3 RID: 29123 RVA: 0x00332DC0 File Offset: 0x00330FC0
	protected virtual void JDBJMNMBOMK()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("Starting parallel download:");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("OnFriendsPopupManagerRejectClick", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(141U)))
			{
				Debug.Log("$e1es");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "_TVDots";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError(" held bundles", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071C4 RID: 29124 RVA: 0x0033283A File Offset: 0x00330A3A
	private static void KDDEJDBFFCI()
	{
		SteamManager.ICLOCOCICJO = true;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x060071C5 RID: 29125 RVA: 0x00332EAC File Offset: 0x003310AC
	protected virtual void CJDPKNCGBGF()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("p");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError(" is already loaded elsewhere", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967206U)))
			{
				Debug.Log(" ");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "OnStoryInterfaceHeaderAutoReadEnable";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071C6 RID: 29126 RVA: 0x0033280A File Offset: 0x00330A0A
	public static bool DNINKKFGGOO()
	{
		return SteamManager.LKMHNGJFMNE().OEFEMFFEKCJ;
	}

	// Token: 0x060071C7 RID: 29127 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void NGKAHOJOHEE()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071C9 RID: 29129 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void KLGMKIJJDFN()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071CA RID: 29130 RVA: 0x00332802 File Offset: 0x00330A02
	[MonoPInvokeCallback(typeof(NNMLFJGPMHE))]
	protected static void JNPDPEKAJCO(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071CB RID: 29131 RVA: 0x0033240B File Offset: 0x0033060B
	public static bool KCNGNIEJKGD()
	{
		return SteamManager.AIMEBOBBHMC().OEFEMFFEKCJ;
	}

	// Token: 0x060071CC RID: 29132 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void JAKPGAKGFHA()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071CD RID: 29133 RVA: 0x003328BA File Offset: 0x00330ABA
	public static bool EOKKKBJHIHK()
	{
		return SteamManager.CJBGOFHGBEM().OEFEMFFEKCJ;
	}

	// Token: 0x060071CE RID: 29134 RVA: 0x0033243B File Offset: 0x0033063B
	private static void KELGEOCPPKN()
	{
		SteamManager.ICLOCOCICJO = false;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x060071CF RID: 29135 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void GMNFLAHGEHF()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071D0 RID: 29136 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void KMMEFNOCPOO()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071D1 RID: 29137 RVA: 0x00332F98 File Offset: 0x00331198
	protected virtual void PFNILJEJILB()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("OnSaveSlotsItemSlotDeleted");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("AssetsManager.GetMaxNumberOfRunningLoadOperations():", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("mailto:", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967108U)))
			{
				Debug.Log("dsv");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = "OnSaveSlotsItemClose";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("pmterror100", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071D2 RID: 29138 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void NMEEMBCCKHA()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071D3 RID: 29139 RVA: 0x00333084 File Offset: 0x00331284
	public static bool KMKNFILFNMG()
	{
		return SteamManager.JOPPNJGEBGC().OEFEMFFEKCJ;
	}

	// Token: 0x060071D4 RID: 29140 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void KNEOPDAAOCA(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071D5 RID: 29141 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void PDONMFEHGLM(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071D6 RID: 29142 RVA: 0x00332C00 File Offset: 0x00330E00
	public static bool EODHHAHDHBK()
	{
		return SteamManager.BFHKGNBFHCH().OEFEMFFEKCJ;
	}

	// Token: 0x060071D7 RID: 29143 RVA: 0x00333090 File Offset: 0x00331290
	public static SteamManager JOPPNJGEBGC()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("continue").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x060071D8 RID: 29144 RVA: 0x003330B4 File Offset: 0x003312B4
	protected virtual void MOBCJBDMNCO()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.JNPDPEKAJCO);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071D9 RID: 29145 RVA: 0x00333104 File Offset: 0x00331304
	protected virtual void LDDEIAOCBGB()
	{
		if (SteamManager.FLJJFCBPNII != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.FLJJFCBPNII = this;
		if (SteamManager.ICLOCOCICJO)
		{
			throw new Exception("Frame containers are disabled by the balance (fdfrc), bundle skipped:");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!KMNOBHGMAON.NABJJPPMILN())
		{
			Debug.LogError("", this);
		}
		if (!DKDALKDMDLJ.NABJJPPMILN())
		{
			Debug.LogError("' has no category, skipped", this);
		}
		try
		{
			if (AAKDPBLEJHL.GADBBCGIKBP(AppId_t.PEAFCMBIENC(4294967201U)))
			{
				Debug.Log("ok");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			string str = " ";
			DllNotFoundException ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null), this);
			Application.Quit();
			return;
		}
		this.OEFEMFFEKCJ = AAKDPBLEJHL.GLFBHMMGHGL();
		if (!this.OEFEMFFEKCJ)
		{
			Debug.LogError("importanttitle", this);
			return;
		}
		SteamManager.ICLOCOCICJO = false;
	}

	// Token: 0x060071DA RID: 29146 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void CKNCEKFOLKD()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071DB RID: 29147 RVA: 0x0033283A File Offset: 0x00330A3A
	private static void NMGKLMJOHOG()
	{
		SteamManager.ICLOCOCICJO = true;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x060071DC RID: 29148 RVA: 0x0033283A File Offset: 0x00330A3A
	private static void OKFMMHLOELJ()
	{
		SteamManager.ICLOCOCICJO = true;
		SteamManager.FLJJFCBPNII = null;
	}

	// Token: 0x060071DD RID: 29149 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x060071DE RID: 29150 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void JMIEGJKLIJA()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071DF RID: 29151 RVA: 0x003331F0 File Offset: 0x003313F0
	protected virtual void FMGJGMNOCMP()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.GNBCMBBODPD);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071E0 RID: 29152 RVA: 0x0033323E File Offset: 0x0033143E
	public static SteamManager PLJMLDOCPNM()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			return new GameObject("OnApplicationFocusBasicSyncStart").AddComponent<SteamManager>();
		}
		return SteamManager.FLJJFCBPNII;
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x060071E1 RID: 29153 RVA: 0x00333262 File Offset: 0x00331462
	public static bool BCPOMPPLLPE
	{
		get
		{
			return SteamManager.EHBBFMCILPC.OEFEMFFEKCJ;
		}
	}

	// Token: 0x060071E2 RID: 29154 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void KNAPBDLJMMJ(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071E3 RID: 29155 RVA: 0x00332802 File Offset: 0x00330A02
	protected static void GNBCMBBODPD(int ANLOMPBNMNB, StringBuilder PKDLFHFNJBD)
	{
		Debug.LogWarning(PKDLFHFNJBD);
	}

	// Token: 0x060071E4 RID: 29156 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x060071E5 RID: 29157 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x060071E6 RID: 29158 RVA: 0x003323CB File Offset: 0x003305CB
	public static bool OOLIHFAAMJN()
	{
		return SteamManager.PEBMGCKFNAO().OEFEMFFEKCJ;
	}

	// Token: 0x060071E7 RID: 29159 RVA: 0x003323D7 File Offset: 0x003305D7
	protected virtual void ODCKJNCEGAH()
	{
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.CACBKDNDGJP();
	}

	// Token: 0x060071E8 RID: 29160 RVA: 0x00333270 File Offset: 0x00331470
	protected virtual void NDFHKDJKHPP()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.JNPDPEKAJCO);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x060071E9 RID: 29161 RVA: 0x00003E52 File Offset: 0x00002052
	private void NDKAFCKLNBL()
	{
	}

	// Token: 0x060071EA RID: 29162 RVA: 0x003323E7 File Offset: 0x003305E7
	protected virtual void ONJMBHKDOGD()
	{
		if (SteamManager.FLJJFCBPNII != this)
		{
			return;
		}
		SteamManager.FLJJFCBPNII = null;
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		AAKDPBLEJHL.FIDMCBAJBEB();
	}

	// Token: 0x060071EB RID: 29163 RVA: 0x003332C0 File Offset: 0x003314C0
	protected virtual void HDAHJCCAIAP()
	{
		if (SteamManager.FLJJFCBPNII == null)
		{
			SteamManager.FLJJFCBPNII = this;
		}
		if (!this.OEFEMFFEKCJ)
		{
			return;
		}
		if (this.DPJLDOKICJL == null)
		{
			this.DPJLDOKICJL = new NNMLFJGPMHE(SteamManager.KNEOPDAAOCA);
			KIICNLGIIAC.BGOKDOIBDHH(this.DPJLDOKICJL);
		}
	}

	// Token: 0x040021E6 RID: 8678
	protected static bool ICLOCOCICJO;

	// Token: 0x040021E7 RID: 8679
	protected static SteamManager FLJJFCBPNII;

	// Token: 0x040021E8 RID: 8680
	protected bool OEFEMFFEKCJ;

	// Token: 0x040021E9 RID: 8681
	protected NNMLFJGPMHE DPJLDOKICJL;
}
