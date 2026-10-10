using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020004DA RID: 1242
public class PassesItem : MonoBehaviour
{
	// Token: 0x06009588 RID: 38280 RVA: 0x00419902 File Offset: 0x00417B02
	private void BHDHJLIBHCJ()
	{
		this.scrollRect.scrollSensitivity = 451f;
	}

	// Token: 0x06009589 RID: 38281 RVA: 0x00003E52 File Offset: 0x00002052
	private void NKIEJIHEADI()
	{
	}

	// Token: 0x0600958A RID: 38282 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x0600958B RID: 38283 RVA: 0x00419914 File Offset: 0x00417B14
	private void PIBDCOBGMKC()
	{
		this.scrollRect.scrollSensitivity = 1139f;
	}

	// Token: 0x0600958C RID: 38284 RVA: 0x00419926 File Offset: 0x00417B26
	private void Start()
	{
		this.scrollRect.scrollSensitivity = 100f;
	}

	// Token: 0x0600958D RID: 38285 RVA: 0x000AE02A File Offset: 0x000AC22A
	private void JCIECGLADOO()
	{
		AppManager.PCJEMMDDCIF().OHFDJEJCDLG(true, true);
	}

	// Token: 0x0600958E RID: 38286 RVA: 0x000AE38C File Offset: 0x000AC58C
	private void CCIDIKGIBDF()
	{
		AppManager.JMDJPKKOHNI().KKNKNOELPPO(false, false);
	}

	// Token: 0x0600958F RID: 38287 RVA: 0x00172562 File Offset: 0x00170762
	public void InstantClose()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009590 RID: 38288 RVA: 0x00419938 File Offset: 0x00417B38
	public void OnCloseClick()
	{
		PassesItem.reopenOnPurchasingScreenLeft = false;
		this.animatedPopupManager.Hide();
	}

	// Token: 0x06009591 RID: 38289 RVA: 0x0041994B File Offset: 0x00417B4B
	private void PABLFIJDFAD()
	{
		this.scrollRect.scrollSensitivity = 1692f;
	}

	// Token: 0x06009592 RID: 38290 RVA: 0x0041995D File Offset: 0x00417B5D
	public void OAKGJGMCBNH()
	{
		PassesItem.reopenOnPurchasingScreenLeft = false;
		this.animatedPopupManager.LHNKFOKBBCP();
	}

	// Token: 0x06009593 RID: 38291 RVA: 0x00419970 File Offset: 0x00417B70
	private void IMCHEPFNANC()
	{
		this.scrollRect.scrollSensitivity = 433f;
	}

	// Token: 0x06009594 RID: 38292 RVA: 0x000AE300 File Offset: 0x000AC500
	private void FKPLFIDCPLP()
	{
		AppManager.EHBBFMCILPC.RestartApp(false, false);
	}

	// Token: 0x06009595 RID: 38293 RVA: 0x00419984 File Offset: 0x00417B84
	private void JLCMPGICMDC()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("socialdonotdisturbtut0", new UnityAction(this.GOMOGNPJLIM));
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DIJMIMMCIKA(CLHDENLPOFP.gamePass);
		if (kioojmglclc != null && !kioojmglclc.ALFGPLALKCN() && !App42Manager.EHBBFMCILPC.IsBusy())
		{
			BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
			CommonUserInterface.EHBBFMCILPC.OJMOLBCCBEH(CCOJBMMKNAP.OBOOKJPGBJN().OBDCPLLLGBB("yes"), 62);
			BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnRewardsItemClose", "skinshopfilterowned", true);
		}
	}

	// Token: 0x06009596 RID: 38294 RVA: 0x00003E52 File Offset: 0x00002052
	private void DNANKPMNMIF()
	{
	}

	// Token: 0x06009597 RID: 38295 RVA: 0x00419A07 File Offset: 0x00417C07
	public void OnPassesItemClose()
	{
		this.OnCloseClick();
	}

	// Token: 0x06009598 RID: 38296 RVA: 0x00003E52 File Offset: 0x00002052
	private void APLBAENGMJH()
	{
	}

	// Token: 0x06009599 RID: 38297 RVA: 0x00419A0F File Offset: 0x00417C0F
	public void Show()
	{
		PassesItem.reopenOnPurchasingScreenLeft = false;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600959B RID: 38299 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void JLFBKNHEGAN()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600959C RID: 38300 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDLEEFPLPLN()
	{
	}

	// Token: 0x0600959D RID: 38301 RVA: 0x00419A23 File Offset: 0x00417C23
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPassesItemClose", new UnityAction(this.OnPassesItemClose));
	}

	// Token: 0x0600959E RID: 38302 RVA: 0x00419A40 File Offset: 0x00417C40
	public void BNEILILJDIK()
	{
		PassesItem.reopenOnPurchasingScreenLeft = false;
		this.animatedPopupManager.KCAPIILJKDN();
	}

	// Token: 0x0600959F RID: 38303 RVA: 0x00419A07 File Offset: 0x00417C07
	public void INFJKPAFPNG()
	{
		this.OnCloseClick();
	}

	// Token: 0x060095A0 RID: 38304 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x060095A1 RID: 38305 RVA: 0x00419A54 File Offset: 0x00417C54
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPassesItemClose", new UnityAction(this.OnPassesItemClose));
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		if (kioojmglclc != null && !kioojmglclc.ALFGPLALKCN() && !App42Manager.EHBBFMCILPC.IsBusy())
		{
			BackendOperationsManager.EHBBFMCILPC.ForceRefreshExpiredSubscriptions();
			CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimationTopWithHint(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("serversync"), 128);
			BackendOperationsManager.EHBBFMCILPC.RequestBasicSync("OnApplicationFocusBasicSyncSuccess", "OnApplicationFocusBasicSyncEcxeption", false);
		}
	}

	// Token: 0x060095A2 RID: 38306 RVA: 0x00419AD7 File Offset: 0x00417CD7
	public void GOMOGNPJLIM()
	{
		this.BNEILILJDIK();
	}

	// Token: 0x04002989 RID: 10633
	public static bool reopenOnPurchasingScreenLeft;

	// Token: 0x0400298A RID: 10634
	public const string onPassesItemClose = "OnPassesItemClose";

	// Token: 0x0400298B RID: 10635
	public AnimatedPopupManager animatedPopupManager;

	// Token: 0x0400298C RID: 10636
	public PassThumbnail premiumGamePass;

	// Token: 0x0400298D RID: 10637
	public PassThumbnail goldGamePass;

	// Token: 0x0400298E RID: 10638
	public ScrollRect scrollRect;
}
