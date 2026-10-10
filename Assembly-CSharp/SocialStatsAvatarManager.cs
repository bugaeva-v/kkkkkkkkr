using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B2 RID: 178
public class SocialStatsAvatarManager : MonoBehaviour
{
	// Token: 0x06001883 RID: 6275 RVA: 0x000B0ADC File Offset: 0x000AECDC
	private void GLIFGDPDMNC()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1013f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x000B0B3C File Offset: 0x000AED3C
	public static SocialStatsAvatarManager KMNBCEMEBBD()
	{
		if (!SocialStatsAvatarManager.IKLAPGJDMNA)
		{
			SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SocialStatsAvatarManager.IKLAPGJDMNA;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x000B0B89 File Offset: 0x000AED89
	public bool DKCNNGKLGHM()
	{
		return !(null != this.PANMNKKODPC) || (double)this.PANMNKKODPC.alpha > 232.0;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x000B0BB4 File Offset: 0x000AEDB4
	public void GMOCKFBDHFC(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "loungeplayfirstprogress", true);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "response object is null";
		this.levelImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KLFPIGJMOMI(this.IGKKPJDGFCB);
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x000B0C2C File Offset: 0x000AEE2C
	public void EDAPIMKMAIJ()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.MHHLOIKMJGD();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1724f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.KEPLKOMOJMG());
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x000B0CA8 File Offset: 0x000AEEA8
	public void MCHLOADLAJC()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.CJFKKHMDKKK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 525f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.BKBICJGNGHO());
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x000B0D24 File Offset: 0x000AEF24
	public void KBIFIFJFCFH(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "offscreen", false);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for ";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.IFLOIHAFADN(this.IGKKPJDGFCB);
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x000B0D9C File Offset: 0x000AEF9C
	public static SocialStatsAvatarManager DLGLFACMHPG()
	{
		if (!SocialStatsAvatarManager.IKLAPGJDMNA)
		{
			SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SocialStatsAvatarManager.IKLAPGJDMNA;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x000B0DE9 File Offset: 0x000AEFE9
	private IEnumerator GACBCOCNEPL()
	{
		yield return new WaitForSeconds(0.1f);
		this.NOJPGANKFDP = null;
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(120f);
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x000B0DF8 File Offset: 0x000AEFF8
	private void IFHNGHNJONP()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 153f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x000B0E58 File Offset: 0x000AF058
	public void HHDLACJKDON()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 386f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.OEEOHENCNBH());
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x000B0ED4 File Offset: 0x000AF0D4
	public void DBNINKAMBAK()
	{
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha <= 588f)
		{
			return;
		}
		string text = CCOJBMMKNAP.KFDLFGHBPLP().DNILNCLIHAP("0");
		text = text.Replace("OnPopupStoryRestartManagerRestartStory2", this.IGKKPJDGFCB.ToString() + "SceneRestart");
		string eempglhpkjg = CCOJBMMKNAP.KNKGCDDMLDP().OHLNGCKIACD("TV lines opacity" + FHAJAGIMLLJ.BDAALMNGNJN(this.IGKKPJDGFCB).ToString());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.JMNIGPHCAEJ().GGPHHLGPMPA("importanttitle"), DFGILFBGPLN.popupNotEnoughStats, 238f, 41);
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x000B0DE9 File Offset: 0x000AEFE9
	private IEnumerator GAAJIKPEJGO()
	{
		yield return new WaitForSeconds(0.1f);
		this.NOJPGANKFDP = null;
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(120f);
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x000B0F80 File Offset: 0x000AF180
	public void FIFJEBKFNCK()
	{
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha <= 1361f)
		{
			return;
		}
		string text = CCOJBMMKNAP.EAIAHCBAIEJ().JHNELLJFBGC("*");
		text = text.Replace("loungetreasurestitle", this.IGKKPJDGFCB.ToString() + "aind1");
		string eempglhpkjg = CCOJBMMKNAP.PLJMLDOCPNM().GGPHHLGPMPA("" + FHAJAGIMLLJ.GPDDMBHCNHE(this.IGKKPJDGFCB).ToString());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.BIAEAOMHBMM().PPALCPINPLK(""), DFGILFBGPLN.popupNotEnoughStats, 1364f, 43);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x000B102C File Offset: 0x000AF22C
	private IEnumerator OCLLGJMCOAG()
	{
		SocialStatsAvatarManager.BPGBHCHOOEC bpgbhchooec = new SocialStatsAvatarManager.BPGBHCHOOEC(1);
		bpgbhchooec.<>4__this = this;
		return bpgbhchooec;
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x000B103C File Offset: 0x000AF23C
	private void HNHBHBEPLHC()
	{
		this.MHHLOIKMJGD();
		if (NarrowScreenScaler.ScreenIsTooNarrow(882f))
		{
			float num = Mathf.Abs(1827f - NarrowScreenScaler.CalculateNewScaleUtil(1367f, (IMBLFHMKMAD)193));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1569f * num, 1187f * num);
		}
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x000B109C File Offset: 0x000AF29C
	private void KMDKBPNAKOG()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 957f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x000B10FC File Offset: 0x000AF2FC
	public void ECNAJMHIJOB(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "", false);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AGEBGGFDKDO(this.IGKKPJDGFCB);
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x000B1171 File Offset: 0x000AF371
	public static bool InstanceInitialized()
	{
		return SocialStatsAvatarManager.EHBBFMCILPC != null;
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x000B1180 File Offset: 0x000AF380
	public void INLIIIEBHAM()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.MHHLOIKMJGD();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 691f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.BKBICJGNGHO());
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x000B11FC File Offset: 0x000AF3FC
	public void GLDKNNPIHCL()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.IMADGDGPBOB();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 717f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.KEPLKOMOJMG());
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x000B1278 File Offset: 0x000AF478
	private void BAMHPOCKBML()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x000B12D8 File Offset: 0x000AF4D8
	private void PKPANMAFAIL()
	{
		this.CEDPFLEAAPK();
		if (NarrowScreenScaler.ScreenIsTooNarrow(254f))
		{
			float num = Mathf.Abs(900f - NarrowScreenScaler.PFHKBMALNJF(1577f, (IMBLFHMKMAD)(-96)));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(831f * num, 317f * num);
		}
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x000B1338 File Offset: 0x000AF538
	public void FALAIGCFMKJ()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.CEDPFLEAAPK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1943f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.BKBICJGNGHO());
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x000B13B1 File Offset: 0x000AF5B1
	public bool CanInteract()
	{
		return null != this.PANMNKKODPC && (double)this.PANMNKKODPC.alpha > 0.9;
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x000B13DC File Offset: 0x000AF5DC
	public void JBMJLIDKPFP()
	{
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha <= 1963f)
		{
			return;
		}
		string text = CCOJBMMKNAP.EAIAHCBAIEJ().FIENAKIHNOM("");
		text = text.Replace("OnSaveSlotsUnlockContinueToPurchasingScreen", this.IGKKPJDGFCB.ToString() + "");
		string eempglhpkjg = CCOJBMMKNAP.MPCBJEIMACA().FIENAKIHNOM("ok" + FHAJAGIMLLJ.IDGHHFJBPMK(this.IGKKPJDGFCB).ToString());
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(eempglhpkjg, text, CCOJBMMKNAP.ILACPHFEDEP().OHLNGCKIACD("avtssnap1"), (DFGILFBGPLN)(-99), 1901f, -111);
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x000B1488 File Offset: 0x000AF688
	public static bool LDHNPGCIBND()
	{
		return SocialStatsAvatarManager.DBFLIEGGGNN() != null;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x000B1498 File Offset: 0x000AF698
	public void CMFKPKPKLBP(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "OnStoryCurrencyInfoClick", true);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "Critical error, AssetsManager not initialized.";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.KLFPIGJMOMI(this.IGKKPJDGFCB);
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x000B1510 File Offset: 0x000AF710
	public void Show()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.BAMHPOCKBML();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0.01f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GACBCOCNEPL());
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x000B1589 File Offset: 0x000AF789
	private IEnumerator HCHGMIPEDGG()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(1f);
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x000B1598 File Offset: 0x000AF798
	public void AIEDCCDBJFD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.CJFKKHMDKKK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 736f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GAAJIKPEJGO());
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x000B1611 File Offset: 0x000AF811
	private void HKFKOMMEMCN()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		SocialStatsAvatarManager.IKLAPGJDMNA = null;
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x000B1650 File Offset: 0x000AF850
	private void Start()
	{
		this.BAMHPOCKBML();
		if (NarrowScreenScaler.ScreenIsTooNarrow(850f))
		{
			float num = Mathf.Abs(1f - NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-150f * num, -200f * num);
		}
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x000B16B0 File Offset: 0x000AF8B0
	private void BHDHJLIBHCJ()
	{
		this.FJEHPCNPMMA();
		if (NarrowScreenScaler.ScreenIsTooNarrow(151f))
		{
			float num = Mathf.Abs(1774f - NarrowScreenScaler.HNPNANKGAOD(1934f, (IMBLFHMKMAD)(-177)));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(163f * num, 612f * num);
		}
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x000B170F File Offset: 0x000AF90F
	private IEnumerator KEPLKOMOJMG()
	{
		SocialStatsAvatarManager.NEKDDEDOGNK nekddedognk = new SocialStatsAvatarManager.NEKDDEDOGNK(1);
		nekddedognk.<>4__this = this;
		return nekddedognk;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x000B1720 File Offset: 0x000AF920
	private void CJFKKHMDKKK()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 188f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x000B1780 File Offset: 0x000AF980
	public void ENJBBHJCJEL()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.GLIFGDPDMNC();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1483f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.KEPLKOMOJMG());
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x000B17FC File Offset: 0x000AF9FC
	public void NBDMOONDIHO()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.CEDPFLEAAPK();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 359f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.OEEOHENCNBH());
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x000B1878 File Offset: 0x000AFA78
	private void JCOIBJANCMG()
	{
		this.CJFKKHMDKKK();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1891f))
		{
			float num = Mathf.Abs(1951f - NarrowScreenScaler.CalculateNewScaleUtil(1991f, (IMBLFHMKMAD)(-58)));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1724f * num, 1423f * num);
		}
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x000B1589 File Offset: 0x000AF789
	private IEnumerator OEEOHENCNBH()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(1f);
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x000B18D7 File Offset: 0x000AFAD7
	public bool AHILIIMIKJE()
	{
		return !(null != this.PANMNKKODPC) || (double)this.PANMNKKODPC.alpha > 1751.0;
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x000B170F File Offset: 0x000AF90F
	private IEnumerator BKBICJGNGHO()
	{
		SocialStatsAvatarManager.NEKDDEDOGNK nekddedognk = new SocialStatsAvatarManager.NEKDDEDOGNK(1);
		nekddedognk.<>4__this = this;
		return nekddedognk;
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x000B1900 File Offset: 0x000AFB00
	public void KMDENBMGDFH()
	{
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha <= 580f)
		{
			return;
		}
		string text = CCOJBMMKNAP.OBOOKJPGBJN().DNILNCLIHAP("p");
		text = text.Replace("x", this.IGKKPJDGFCB.ToString() + "v");
		string eempglhpkjg = CCOJBMMKNAP.PEBMGCKFNAO().HDIPNMFHIEJ("\n" + FHAJAGIMLLJ.BFHJGDJEMLH(this.IGKKPJDGFCB).ToString());
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.CPCOODCFDDP().JCDFHKDNEDH("[LoadingEnv] request failed for "), (DFGILFBGPLN)(-96), 1615f, 96);
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x000B19AC File Offset: 0x000AFBAC
	public void HGPCCNDPBGK()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.FJEHPCNPMMA();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 502f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GACBCOCNEPL());
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x000B1A28 File Offset: 0x000AFC28
	public void MDODDAMIEMH(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "@", true);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "XXX";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.IFLOIHAFADN(this.IGKKPJDGFCB);
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x000B102C File Offset: 0x000AF22C
	private IEnumerator HGGKKBOIKEN()
	{
		SocialStatsAvatarManager.BPGBHCHOOEC bpgbhchooec = new SocialStatsAvatarManager.BPGBHCHOOEC(1);
		bpgbhchooec.<>4__this = this;
		return bpgbhchooec;
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x000B1589 File Offset: 0x000AF789
	private IEnumerator FJPKAGHAAIB()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(1f);
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x000B1AA0 File Offset: 0x000AFCA0
	private void OKBABBBHMIP()
	{
		this.KMDKBPNAKOG();
		if (NarrowScreenScaler.ScreenIsTooNarrow(664f))
		{
			float num = Mathf.Abs(76f - NarrowScreenScaler.HNPNANKGAOD(1281f, (IMBLFHMKMAD)135));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1046f * num, 1676f * num);
		}
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x000B1B00 File Offset: 0x000AFD00
	public void ShowInfoPopup()
	{
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha <= 0.001f)
		{
			return;
		}
		string text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialavatarmsg");
		text = text.Replace("XXX", this.IGKKPJDGFCB.ToString() + "%");
		string eempglhpkjg = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("socialachievtitletype" + FHAJAGIMLLJ.LHOOFBGJKOL(this.IGKKPJDGFCB).ToString());
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(eempglhpkjg, text, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x000B1611 File Offset: 0x000AF811
	private void MAHJANFJIMG()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		SocialStatsAvatarManager.IKLAPGJDMNA = null;
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x000B102C File Offset: 0x000AF22C
	private IEnumerator PHPENLMKJEH()
	{
		SocialStatsAvatarManager.BPGBHCHOOEC bpgbhchooec = new SocialStatsAvatarManager.BPGBHCHOOEC(1);
		bpgbhchooec.<>4__this = this;
		return bpgbhchooec;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x000B1BAC File Offset: 0x000AFDAC
	public void EOJKOOGOLCI()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.BAMHPOCKBML();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1391f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.KEPLKOMOJMG());
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x000B1C28 File Offset: 0x000AFE28
	public void Hide()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 0.01f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x000B1611 File Offset: 0x000AF811
	private void OnDestroy()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		SocialStatsAvatarManager.IKLAPGJDMNA = null;
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x000B102C File Offset: 0x000AF22C
	private IEnumerator JOPONLABPEF()
	{
		SocialStatsAvatarManager.BPGBHCHOOEC bpgbhchooec = new SocialStatsAvatarManager.BPGBHCHOOEC(1);
		bpgbhchooec.<>4__this = this;
		return bpgbhchooec;
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x000B1611 File Offset: 0x000AF811
	private void HGNPNNKGNLG()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		SocialStatsAvatarManager.IKLAPGJDMNA = null;
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x000B1CA4 File Offset: 0x000AFEA4
	public void IDCIFABCOML()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.IFHNGHNJONP();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1060f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.OCLLGJMCOAG());
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x000B1D20 File Offset: 0x000AFF20
	public void KIHIOJPNDLF(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "OnPostEffectSettingsChanged", false);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + ">";
		this.levelImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.IFLOIHAFADN(this.IGKKPJDGFCB);
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x000B1611 File Offset: 0x000AF811
	private void JLCJJONEBIB()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = null;
		this.NOJPGANKFDP = null;
		SocialStatsAvatarManager.IKLAPGJDMNA = null;
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x000B1D98 File Offset: 0x000AFF98
	private void MHHLOIKMJGD()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1221f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x000B1DF5 File Offset: 0x000AFFF5
	public static bool ACCMJOKPKJA()
	{
		return SocialStatsAvatarManager.JLHEEEJNKGO() != null;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x000B1E04 File Offset: 0x000B0004
	public void FGLJPHEEOBL()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.IMADGDGPBOB();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 794f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.JOPONLABPEF());
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x000B1E80 File Offset: 0x000B0080
	private void MAIBLFFBJAA()
	{
		this.GLIFGDPDMNC();
		if (NarrowScreenScaler.ScreenIsTooNarrow(1770f))
		{
			float num = Mathf.Abs(1779f - NarrowScreenScaler.HNPNANKGAOD(594f, (IMBLFHMKMAD)(-73)));
			num = Mathf.Clamp01(num);
			base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1430f * num, 1406f * num);
		}
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x000B1EE0 File Offset: 0x000B00E0
	public static SocialStatsAvatarManager AGANFKKBPFO()
	{
		if (!SocialStatsAvatarManager.IKLAPGJDMNA)
		{
			SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("hintsigning");
			}
		}
		return SocialStatsAvatarManager.IKLAPGJDMNA;
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000B1F30 File Offset: 0x000B0130
	public static SocialStatsAvatarManager EHBBFMCILPC
	{
		get
		{
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
				if (!SocialStatsAvatarManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active SocialStatsAvatarManager script on a GameObject in your scene.");
				}
			}
			return SocialStatsAvatarManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x000B1F80 File Offset: 0x000B0180
	public static SocialStatsAvatarManager DBFLIEGGGNN()
	{
		if (!SocialStatsAvatarManager.IKLAPGJDMNA)
		{
			SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			}
		}
		return SocialStatsAvatarManager.IKLAPGJDMNA;
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x000B1FD0 File Offset: 0x000B01D0
	private void CEDPFLEAAPK()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1924f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x000B2030 File Offset: 0x000B0230
	public void GOJJHALEGOD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		this.CEDPFLEAAPK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1698f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.KEPLKOMOJMG());
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x000B1DF5 File Offset: 0x000AFFF5
	public static bool HJGIEPIGBHI()
	{
		return SocialStatsAvatarManager.JLHEEEJNKGO() != null;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x000B1171 File Offset: 0x000AF371
	public static bool BOIHHBOMLIH()
	{
		return SocialStatsAvatarManager.EHBBFMCILPC != null;
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x000B20AC File Offset: 0x000B02AC
	private void IMADGDGPBOB()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1512f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x000B210C File Offset: 0x000B030C
	public static SocialStatsAvatarManager JLHEEEJNKGO()
	{
		if (!SocialStatsAvatarManager.IKLAPGJDMNA)
		{
			SocialStatsAvatarManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(SocialStatsAvatarManager)) as SocialStatsAvatarManager);
			if (!SocialStatsAvatarManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		return SocialStatsAvatarManager.IKLAPGJDMNA;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00003E52 File Offset: 0x00002052
	private void OLEAIHHFBGB()
	{
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x000B1589 File Offset: 0x000AF789
	private IEnumerator MPCGAMEDJGB()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		yield return new WaitForSeconds(1f);
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x000B2159 File Offset: 0x000B0359
	public static bool HHKKIEJJHHO()
	{
		return SocialStatsAvatarManager.AGANFKKBPFO() != null;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x000B2168 File Offset: 0x000B0368
	public void GNONOEIFMOA(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "ok", false);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "OpenPasses";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.IFLOIHAFADN(this.IGKKPJDGFCB);
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x000B21E0 File Offset: 0x000B03E0
	public void OLNHPKDLCLK(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + " not found, replacing with ", true);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "OnDialogReadInputEndEdit";
		this.levelImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AGEBGGFDKDO(this.IGKKPJDGFCB);
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x000B102C File Offset: 0x000AF22C
	private IEnumerator IHHLCEJHJLP()
	{
		SocialStatsAvatarManager.BPGBHCHOOEC bpgbhchooec = new SocialStatsAvatarManager.BPGBHCHOOEC(1);
		bpgbhchooec.<>4__this = this;
		return bpgbhchooec;
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x000B2258 File Offset: 0x000B0458
	private void FJEHPCNPMMA()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1327f;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x000B22B8 File Offset: 0x000B04B8
	public void InitializeSocialStats(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "%", true);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "%";
		this.levelImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.KLFPIGJMOMI(this.IGKKPJDGFCB);
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x000B2330 File Offset: 0x000B0530
	public void PKHHNHOCPGM(int JEDLACEDKPJ)
	{
		this.IGKKPJDGFCB = JEDLACEDKPJ;
		this.percentText.SetText(this.IGKKPJDGFCB.ToString() + "xx", false);
		this.percentText.text = this.IGKKPJDGFCB.ToString() + "liveeventcontent";
		this.levelImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.KLFPIGJMOMI(this.IGKKPJDGFCB);
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x00003E52 File Offset: 0x00002052
	private void ECDLFGCLAGG()
	{
	}

	// Token: 0x04000723 RID: 1827
	public static bool dataIsReady;

	// Token: 0x04000724 RID: 1828
	public TextMeshProUGUI percentText;

	// Token: 0x04000725 RID: 1829
	public Image levelImage;

	// Token: 0x04000726 RID: 1830
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000727 RID: 1831
	private AnimationCanvasGroupAlpha JNIDFGCGGMF;

	// Token: 0x04000728 RID: 1832
	private bool JIEPCIDINEH;

	// Token: 0x04000729 RID: 1833
	private Coroutine LFCIBEEKAPP;

	// Token: 0x0400072A RID: 1834
	private Coroutine NOJPGANKFDP;

	// Token: 0x0400072B RID: 1835
	private static SocialStatsAvatarManager IKLAPGJDMNA;

	// Token: 0x0400072C RID: 1836
	private int IGKKPJDGFCB;
}
