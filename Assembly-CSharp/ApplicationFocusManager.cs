using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020001DC RID: 476
public class ApplicationFocusManager : MonoBehaviour
{
	// Token: 0x06003B6B RID: 15211 RVA: 0x0018A84F File Offset: 0x00188A4F
	private IEnumerator NLGCNEFIGEP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
		yield return new WaitForSeconds(1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationFocusBasicSyncStart", 0f);
		BackendOperationsManager.EHBBFMCILPC.RequestBasicSyncAndSaveSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", SceneLobbyManager2.lobbyIsActive);
		yield break;
	}

	// Token: 0x06003B6C RID: 15212 RVA: 0x0018A857 File Offset: 0x00188A57
	public static void Restore()
	{
		if (ApplicationFocusManager.JDMBOOKDJNK == 0)
		{
			ApplicationFocusManager.FDLJLHBPHDB = false;
		}
		else if (ApplicationFocusManager.JDMBOOKDJNK == 1)
		{
			ApplicationFocusManager.FDLJLHBPHDB = true;
		}
		ApplicationFocusManager.JDMBOOKDJNK = -1;
	}

	// Token: 0x06003B6D RID: 15213 RVA: 0x0018A87C File Offset: 0x00188A7C
	private void GNMAFJKJJCF(bool IBELFEBCBMK)
	{
		float num = Time.realtimeSinceStartup - ApplicationFocusManager.FEEFKJKPMAG;
		if (IBELFEBCBMK && ApplicationFocusManager.FDLJLHBPHDB && num > 449f && !AssetsManager.MJBDMHPHMID().IsBusy() && !App42Manager.EHBBFMCILPC.IsBusy() && !CommonUserInterface.IKNOFBFMPGA().BPAKOKECKAK())
		{
			base.StartCoroutine(this.NLGCNEFIGEP());
		}
		ApplicationFocusManager.FEEFKJKPMAG = Time.realtimeSinceStartup;
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x0018A8E2 File Offset: 0x00188AE2
	private void KPNLKBPCDAF()
	{
		AOBJLALDBAA.KKPFOJMAONG().MANLHALMCIH("SceneLobbyManager2.AppendGroupBatch() - ", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.PFAHGKEDFAE("sfxtimeoutwarning", new UnityAction(this.PAPECGNMDCM));
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06003B6F RID: 15215 RVA: 0x0018A91C File Offset: 0x00188B1C
	public static ApplicationFocusManager EHBBFMCILPC
	{
		get
		{
			if (!ApplicationFocusManager.IKLAPGJDMNA)
			{
				ApplicationFocusManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(ApplicationFocusManager)) as ApplicationFocusManager);
				if (!ApplicationFocusManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active ApplicationFocusManager script on a GameObject in your scene.");
				}
			}
			return ApplicationFocusManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06003B70 RID: 15216 RVA: 0x0018A969 File Offset: 0x00188B69
	private IEnumerator ECJIOGAIDPC()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
		yield return new WaitForSeconds(1f);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationFocusBasicSyncStart", 0f);
		BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", SceneLobbyManager2.lobbyIsActive);
		yield break;
	}

	// Token: 0x06003B71 RID: 15217 RVA: 0x0018A974 File Offset: 0x00188B74
	private void OnApplicationFocus(bool IBELFEBCBMK)
	{
		float num = Time.realtimeSinceStartup - ApplicationFocusManager.FEEFKJKPMAG;
		if (IBELFEBCBMK && ApplicationFocusManager.FDLJLHBPHDB && num > 15f && !AssetsManager.EHBBFMCILPC.IsBusy() && !App42Manager.EHBBFMCILPC.IsBusy() && !CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
		{
			base.StartCoroutine(this.NLGCNEFIGEP());
		}
		ApplicationFocusManager.FEEFKJKPMAG = Time.realtimeSinceStartup;
	}

	// Token: 0x06003B72 RID: 15218 RVA: 0x0018A9DA File Offset: 0x00188BDA
	private void NCLALOLOIGP()
	{
		ApplicationFocusManager.FEEFKJKPMAG = Time.realtimeSinceStartup;
	}

	// Token: 0x06003B73 RID: 15219 RVA: 0x0018A9E6 File Offset: 0x00188BE6
	private void OnDestroy()
	{
		if (ApplicationFocusManager.IKLAPGJDMNA == this)
		{
			ApplicationFocusManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06003B75 RID: 15221 RVA: 0x0018AA13 File Offset: 0x00188C13
	public static void Deactivate()
	{
		if (ApplicationFocusManager.JDMBOOKDJNK < 0)
		{
			if (!ApplicationFocusManager.FDLJLHBPHDB)
			{
				ApplicationFocusManager.JDMBOOKDJNK = 0;
			}
			else
			{
				ApplicationFocusManager.JDMBOOKDJNK = 1;
			}
		}
		ApplicationFocusManager.FDLJLHBPHDB = false;
	}

	// Token: 0x06003B76 RID: 15222 RVA: 0x0018AA38 File Offset: 0x00188C38
	private void JLCMPGICMDC()
	{
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("socialpremgiftcollect", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("OnBackendRequestFriendRejectSuccess", new UnityAction(this.GFGHMONILCC));
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x0018AA70 File Offset: 0x00188C70
	public static void BNMKAAKCLEA()
	{
		if (ApplicationFocusManager.JDMBOOKDJNK < 0)
		{
			if (!ApplicationFocusManager.FDLJLHBPHDB)
			{
				ApplicationFocusManager.JDMBOOKDJNK = 1;
			}
			else
			{
				ApplicationFocusManager.JDMBOOKDJNK = 0;
			}
		}
		ApplicationFocusManager.FDLJLHBPHDB = true;
	}

	// Token: 0x06003B79 RID: 15225 RVA: 0x000633C0 File Offset: 0x000615C0
	private void GFGHMONILCC()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x0018AA98 File Offset: 0x00188C98
	private void OFFBAMLEFNH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		int num = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.hardCurrency);
		int num2 = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy);
		if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() && !CommonUserInterface.EHBBFMCILPC.delayedFullScreenBlock.activeSelf)
		{
			if (num > 0 || num2 > 0)
			{
				if (num > 0 && num2 > 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("youreceived"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamondsAndEnergy(num, num2);
					return;
				}
				if (num > 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("youreceived"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowDiamonds(num);
					return;
				}
				if (num2 > 0)
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("congratstitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("youreceived"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), DFGILFBGPLN.popupPurchaseSuccess, 0f, 28).ShowEnergy(num2);
					return;
				}
			}
		}
		else if (num > 0 || num2 > 0)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationFocusNeedToUpdateCurrency", 0f);
		}
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x0018AC40 File Offset: 0x00188E40
	public static ApplicationFocusManager AGANFKKBPFO()
	{
		if (!ApplicationFocusManager.IKLAPGJDMNA)
		{
			ApplicationFocusManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(ApplicationFocusManager)) as ApplicationFocusManager);
			if (!ApplicationFocusManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("afs");
			}
		}
		return ApplicationFocusManager.IKLAPGJDMNA;
	}

	// Token: 0x06003B7C RID: 15228 RVA: 0x0018AC90 File Offset: 0x00188E90
	public static ApplicationFocusManager INKJIBDDMLL()
	{
		if (!ApplicationFocusManager.IKLAPGJDMNA)
		{
			ApplicationFocusManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(ApplicationFocusManager)) as ApplicationFocusManager);
			if (!ApplicationFocusManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("continue");
			}
		}
		return ApplicationFocusManager.IKLAPGJDMNA;
	}

	// Token: 0x06003B7D RID: 15229 RVA: 0x0018ACE0 File Offset: 0x00188EE0
	private void HFHPIIGBNPH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		int num = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy);
		int num2 = AKLFPGMDKLA.EHBBFMCILPC.DHFJGFHBIOH(JFGBECHLPGI.energy);
		if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() && !CommonUserInterface.EHBBFMCILPC.delayedFullScreenBlock.activeSelf)
		{
			if (num > 1 || num2 > 1)
			{
				if (num > 1 && num2 > 1)
				{
					CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.NIOJNOFGIJO().FIENAKIHNOM("YYY"), CCOJBMMKNAP.DBFFFOMCLKM().IPEIONBNIPH("apks2"), CCOJBMMKNAP.HEDIEIICOOG().HIPJILDCHJC("importanttitle"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), (DFGILFBGPLN)(-10), 270f, -113).ShowDiamondsAndEnergy(num, num2);
					return;
				}
				if (num > 0)
				{
					CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.APGODIBBPOD().HPOAGPJFHPM(" "), CCOJBMMKNAP.PLJMLDOCPNM().OHLNGCKIACD("importanttitle"), CCOJBMMKNAP.KFAABHHGOPO().PKNHKGMNCIP("direction"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), DFGILFBGPLN.popupCdnUpdateAvailable, 47f, -114).IOEDDKCGKIJ(num);
					return;
				}
				if (num2 > 1)
				{
					CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.KNKGCDDMLDP().OGKGHLHHAAI("env"), CCOJBMMKNAP.EAIAHCBAIEJ().GLEFEKBDHNK("profilenametitleshort"), CCOJBMMKNAP.CEGAOMEEFBE().HIPJILDCHJC("x"), new UnityAction(this.BOKCKCDFGFE), new UnityAction(this.BOKCKCDFGFE), (DFGILFBGPLN)92, 1289f, -102).ShowEnergy(num2);
					return;
				}
			}
		}
		else if (num > 1 || num2 > 1)
		{
			AOBJLALDBAA.CEGAOMEEFBE().KGIKHEDLPND("uid", 86f);
		}
	}

	// Token: 0x06003B7E RID: 15230 RVA: 0x0018A9DA File Offset: 0x00188BDA
	private void Start()
	{
		ApplicationFocusManager.FEEFKJKPMAG = Time.realtimeSinceStartup;
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x0018AE87 File Offset: 0x00189087
	private void PAPECGNMDCM()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
	}

	// Token: 0x06003B80 RID: 15232 RVA: 0x000CCBCA File Offset: 0x000CADCA
	private void BOKCKCDFGFE()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnApplicationFocusNeedToUpdateCurrency", 0f);
	}

	// Token: 0x06003B81 RID: 15233 RVA: 0x0018AE93 File Offset: 0x00189093
	public static void Activate()
	{
		ApplicationFocusManager.JDMBOOKDJNK = -1;
		ApplicationFocusManager.FDLJLHBPHDB = true;
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x0018AEA1 File Offset: 0x001890A1
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationFocusBasicSyncEcxeption", new UnityAction(this.GFGHMONILCC));
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x0018AED9 File Offset: 0x001890D9
	public static void HIFHNIPJFNE()
	{
		if (ApplicationFocusManager.JDMBOOKDJNK < 1)
		{
			if (!ApplicationFocusManager.FDLJLHBPHDB)
			{
				ApplicationFocusManager.JDMBOOKDJNK = 1;
			}
			else
			{
				ApplicationFocusManager.JDMBOOKDJNK = 1;
			}
		}
		ApplicationFocusManager.FDLJLHBPHDB = false;
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x0018AEFE File Offset: 0x001890FE
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncSuccess", new UnityAction(this.OFFBAMLEFNH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationFocusBasicSyncEcxeption", new UnityAction(this.GFGHMONILCC));
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x0018AF36 File Offset: 0x00189136
	private IEnumerator ODNGFPBLCFJ()
	{
		return new ApplicationFocusManager.AJOHDHHDPPG(1);
	}

	// Token: 0x06003B87 RID: 15239 RVA: 0x0018AF3E File Offset: 0x0018913E
	public void ForceBasicSync()
	{
		if (!AssetsManager.EHBBFMCILPC.IsBusy() && !App42Manager.EHBBFMCILPC.IsBusy() && !CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled())
		{
			base.StartCoroutine(this.ECJIOGAIDPC());
		}
	}

	// Token: 0x04001134 RID: 4404
	public const string onApplicationFocusBasicSyncStart = "OnApplicationFocusBasicSyncStart";

	// Token: 0x04001135 RID: 4405
	public const string onApplicationFocusBasicSyncSuccess = "OnApplicationFocusBasicSyncSuccess";

	// Token: 0x04001136 RID: 4406
	public const string onApplicationFocusBasicSyncEcxeption = "OnApplicationFocusBasicSyncEcxeption";

	// Token: 0x04001137 RID: 4407
	public const string onApplicationFocusNeedToUpdateCurrency = "OnApplicationFocusNeedToUpdateCurrency";

	// Token: 0x04001138 RID: 4408
	private static bool FDLJLHBPHDB = false;

	// Token: 0x04001139 RID: 4409
	private static int JDMBOOKDJNK = -1;

	// Token: 0x0400113A RID: 4410
	private static float FEEFKJKPMAG = 0f;

	// Token: 0x0400113B RID: 4411
	private static ApplicationFocusManager IKLAPGJDMNA;
}
