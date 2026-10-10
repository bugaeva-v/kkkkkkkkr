using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

// Token: 0x020003B6 RID: 950
public class SaveCutsceneButtonManager : MonoBehaviour
{
	// Token: 0x06006F38 RID: 28472 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float GetVisibilityTime()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F39 RID: 28473 RVA: 0x003299C8 File Offset: 0x00327BC8
	public void NJPKPGNJELG()
	{
		base.StartCoroutine(this.EFIIOFMNIEF());
	}

	// Token: 0x06006F3A RID: 28474 RVA: 0x003299D7 File Offset: 0x00327BD7
	private IEnumerator ANHFAHBJPDC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
			this.PANMNKKODPC.DOFade(0f, 0.25f);
		}
		yield return new WaitForSeconds(0.25f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06006F3B RID: 28475 RVA: 0x003299E6 File Offset: 0x00327BE6
	public void AJGCLHKBLIH()
	{
		base.StartCoroutine(this.ANHFAHBJPDC());
	}

	// Token: 0x06006F3C RID: 28476 RVA: 0x003299F8 File Offset: 0x00327BF8
	private void AIHIIABBFKE()
	{
		this.DAPKGGAGHHC = 1228f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1614f;
			this.PANMNKKODPC.DOFade(539f, 1521f);
		}
	}

	// Token: 0x06006F3D RID: 28477 RVA: 0x00329A44 File Offset: 0x00327C44
	public bool IKJIHEAKAKM()
	{
		return DPGJIJGOCIC.IHMBBHAMOHP(base.gameObject);
	}

	// Token: 0x06006F3E RID: 28478 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool HPFKLPIEOKJ()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x06006F3F RID: 28479 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06006F40 RID: 28480 RVA: 0x00329A60 File Offset: 0x00327C60
	private void ILOPFODPJCL()
	{
		this.DAPKGGAGHHC = 199f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 357f;
			this.PANMNKKODPC.DOFade(721f, 1590f);
		}
	}

	// Token: 0x06006F41 RID: 28481 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void Update()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F42 RID: 28482 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void NMEEMBCCKHA()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F43 RID: 28483 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool IPAGLMGFNGE()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x06006F44 RID: 28484 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x06006F45 RID: 28485 RVA: 0x00329AC0 File Offset: 0x00327CC0
	public void PPPINLOLEFO()
	{
		base.StartCoroutine(this.APJGCKEHDGI());
	}

	// Token: 0x06006F46 RID: 28486 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void IAKKINHMFNA()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F47 RID: 28487 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float EHGFOKLMEOI()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F48 RID: 28488 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool BMMNBMJJIOM()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x06006F49 RID: 28489 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool FHLGIDDGGHK()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F4A RID: 28490 RVA: 0x00329AEF File Offset: 0x00327CEF
	private void MDLNNHHGIAB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06006F4B RID: 28491 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void DNCGCGGCJNE()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F4C RID: 28492 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06006F4D RID: 28493 RVA: 0x00329B0C File Offset: 0x00327D0C
	private IEnumerator APJGCKEHDGI()
	{
		SaveCutsceneButtonManager.EPBAHMDKFEB epbahmdkfeb = new SaveCutsceneButtonManager.EPBAHMDKFEB(1);
		epbahmdkfeb.<>4__this = this;
		return epbahmdkfeb;
	}

	// Token: 0x06006F4E RID: 28494 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float OOJCJCJNEME()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F4F RID: 28495 RVA: 0x00329B1C File Offset: 0x00327D1C
	private void MDFOBFFGDAB()
	{
		this.DAPKGGAGHHC = 148f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 104f;
			this.PANMNKKODPC.DOFade(1917f, 1713f);
		}
	}

	// Token: 0x06006F50 RID: 28496 RVA: 0x00329AEF File Offset: 0x00327CEF
	private void JPPBJKKNIED()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06006F51 RID: 28497 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06006F52 RID: 28498 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void APLBAENGMJH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F53 RID: 28499 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void MDNEOMGLGIN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F54 RID: 28500 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void CJHFPCNEHGB()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F55 RID: 28501 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool PNCBJLGHMFF()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F56 RID: 28502 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void KDNKCFGANFN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F57 RID: 28503 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x06006F58 RID: 28504 RVA: 0x00329AEF File Offset: 0x00327CEF
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06006F59 RID: 28505 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void OPBNOGLBNDK()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F5A RID: 28506 RVA: 0x00329B68 File Offset: 0x00327D68
	private void CPLOOMDNFFD()
	{
		this.DAPKGGAGHHC = 1784f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 105f;
			this.PANMNKKODPC.DOFade(1861f, 451f);
		}
	}

	// Token: 0x06006F5B RID: 28507 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool FOCJDDJAJLH()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F5C RID: 28508 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void LFBPHHOPPBO()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F5D RID: 28509 RVA: 0x00329BB4 File Offset: 0x00327DB4
	private void IJPIIOECDGL()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06006F5E RID: 28510 RVA: 0x00329BD1 File Offset: 0x00327DD1
	public void INJLJNCFPDI()
	{
		base.StartCoroutine(this.GJHNPOIKMEP());
	}

	// Token: 0x06006F5F RID: 28511 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06006F60 RID: 28512 RVA: 0x003299D7 File Offset: 0x00327BD7
	private IEnumerator OGDCJLCGLNE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
			this.PANMNKKODPC.DOFade(0f, 0.25f);
		}
		yield return new WaitForSeconds(0.25f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06006F61 RID: 28513 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F62 RID: 28514 RVA: 0x00329BE0 File Offset: 0x00327DE0
	private void OnEnable()
	{
		this.DAPKGGAGHHC = 0f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
			this.PANMNKKODPC.DOFade(1f, 0.5f);
		}
	}

	// Token: 0x06006F63 RID: 28515 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void LIBECOJEBKI()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F64 RID: 28516 RVA: 0x00329C2C File Offset: 0x00327E2C
	private void AFGGOFOIFLC()
	{
		this.DAPKGGAGHHC = 597f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1837f;
			this.PANMNKKODPC.DOFade(236f, 1207f);
		}
	}

	// Token: 0x06006F65 RID: 28517 RVA: 0x00329ACF File Offset: 0x00327CCF
	private void PMDCMEKGFNN()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
	}

	// Token: 0x06006F66 RID: 28518 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void MKMLEFGAEMM()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F67 RID: 28519 RVA: 0x00329C78 File Offset: 0x00327E78
	private void ELKCPJHOGBJ()
	{
		this.DAPKGGAGHHC = 1049f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1343f;
			this.PANMNKKODPC.DOFade(455f, 1038f);
		}
	}

	// Token: 0x06006F68 RID: 28520 RVA: 0x00329CC4 File Offset: 0x00327EC4
	private void LOACLFMGICF()
	{
		this.DAPKGGAGHHC = 259f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 853f;
			this.PANMNKKODPC.DOFade(1961f, 50f);
		}
	}

	// Token: 0x06006F6A RID: 28522 RVA: 0x00329D10 File Offset: 0x00327F10
	public void GGFBBELDLLI()
	{
		base.StartCoroutine(this.HKBOJKHJIGA());
	}

	// Token: 0x06006F6B RID: 28523 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool INGBDMHDNLG()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x06006F6C RID: 28524 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool DNJPNFJHMGO()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F6D RID: 28525 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float OEGBEGNMEKJ()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F6E RID: 28526 RVA: 0x00329D20 File Offset: 0x00327F20
	private void IODOFKJEIFD()
	{
		this.DAPKGGAGHHC = 1262f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 607f;
			this.PANMNKKODPC.DOFade(1995f, 1945f);
		}
	}

	// Token: 0x06006F6F RID: 28527 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x06006F70 RID: 28528 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool IsMousePointerOverObject()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F71 RID: 28529 RVA: 0x00329B0C File Offset: 0x00327D0C
	private IEnumerator EFIIOFMNIEF()
	{
		SaveCutsceneButtonManager.EPBAHMDKFEB epbahmdkfeb = new SaveCutsceneButtonManager.EPBAHMDKFEB(1);
		epbahmdkfeb.<>4__this = this;
		return epbahmdkfeb;
	}

	// Token: 0x06006F72 RID: 28530 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPCIIBNLBAL()
	{
	}

	// Token: 0x06006F73 RID: 28531 RVA: 0x00329D6C File Offset: 0x00327F6C
	private void ALOEGNGEFMM()
	{
		this.DAPKGGAGHHC = 1784f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 797f;
			this.PANMNKKODPC.DOFade(1402f, 1896f);
		}
	}

	// Token: 0x06006F74 RID: 28532 RVA: 0x00329AEF File Offset: 0x00327CEF
	private void FIIIEHFCHMH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
	}

	// Token: 0x06006F75 RID: 28533 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float PEKIGJAHDMM()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F76 RID: 28534 RVA: 0x003299D7 File Offset: 0x00327BD7
	private IEnumerator HKBOJKHJIGA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
			this.PANMNKKODPC.DOFade(0f, 0.25f);
		}
		yield return new WaitForSeconds(0.25f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06006F77 RID: 28535 RVA: 0x00329BD1 File Offset: 0x00327DD1
	public void GLPBPBMEIHF()
	{
		base.StartCoroutine(this.GJHNPOIKMEP());
	}

	// Token: 0x06006F78 RID: 28536 RVA: 0x003299C0 File Offset: 0x00327BC0
	public float ABIOGOGAHGD()
	{
		return this.DAPKGGAGHHC;
	}

	// Token: 0x06006F79 RID: 28537 RVA: 0x00329BB4 File Offset: 0x00327DB4
	private void NKIEJIHEADI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
	}

	// Token: 0x06006F7A RID: 28538 RVA: 0x00329DB8 File Offset: 0x00327FB8
	private void FMGJGMNOCMP()
	{
		this.DAPKGGAGHHC = 1669f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 356f;
			this.PANMNKKODPC.DOFade(424f, 1148f);
		}
	}

	// Token: 0x06006F7B RID: 28539 RVA: 0x00329E04 File Offset: 0x00328004
	public void Hide()
	{
		base.StartCoroutine(this.OGDCJLCGLNE());
	}

	// Token: 0x06006F7C RID: 28540 RVA: 0x00329A44 File Offset: 0x00327C44
	public bool NJIDKMGMNOP()
	{
		return DPGJIJGOCIC.IHMBBHAMOHP(base.gameObject);
	}

	// Token: 0x06006F7D RID: 28541 RVA: 0x00329E14 File Offset: 0x00328014
	private void AAGKOINJGOL()
	{
		this.DAPKGGAGHHC = 14f;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 26f;
			this.PANMNKKODPC.DOFade(601f, 45f);
		}
	}

	// Token: 0x06006F7E RID: 28542 RVA: 0x00329E04 File Offset: 0x00328004
	public void FGLJPHEEOBL()
	{
		base.StartCoroutine(this.OGDCJLCGLNE());
	}

	// Token: 0x06006F7F RID: 28543 RVA: 0x00329AE2 File Offset: 0x00327CE2
	public bool OCKFHMOMFLG()
	{
		return DPGJIJGOCIC.CCHPFOBNODH(base.gameObject);
	}

	// Token: 0x06006F80 RID: 28544 RVA: 0x00329AAC File Offset: 0x00327CAC
	private void CJJDKFEGFKE()
	{
		this.DAPKGGAGHHC += Time.deltaTime;
	}

	// Token: 0x06006F81 RID: 28545 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06006F82 RID: 28546 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool KEOKDKDMFPA()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x06006F83 RID: 28547 RVA: 0x003299D7 File Offset: 0x00327BD7
	private IEnumerator GJHNPOIKMEP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
			this.PANMNKKODPC.DOFade(0f, 0.25f);
		}
		yield return new WaitForSeconds(0.25f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06006F84 RID: 28548 RVA: 0x00003E52 File Offset: 0x00002052
	private void NDKAFCKLNBL()
	{
	}

	// Token: 0x06006F85 RID: 28549 RVA: 0x003299D7 File Offset: 0x00327BD7
	private IEnumerator IOOKDHOBOBI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
			this.PANMNKKODPC.DOFade(0f, 0.25f);
		}
		yield return new WaitForSeconds(0.25f);
		base.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06006F86 RID: 28550 RVA: 0x00329A51 File Offset: 0x00327C51
	public bool IsTouchPointerOverObject()
	{
		return DPGJIJGOCIC.NJEMJMKOKDN(base.gameObject);
	}

	// Token: 0x040020CB RID: 8395
	private const float KKMJEEJNKGK = 0.5f;

	// Token: 0x040020CC RID: 8396
	private const float DHGLJFHOLBF = 0.25f;

	// Token: 0x040020CD RID: 8397
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040020CE RID: 8398
	private float DAPKGGAGHHC;
}
