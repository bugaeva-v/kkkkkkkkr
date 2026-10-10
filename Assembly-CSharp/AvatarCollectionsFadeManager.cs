using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200052A RID: 1322
public class AvatarCollectionsFadeManager : MonoBehaviour
{
	// Token: 0x0600A118 RID: 41240 RVA: 0x0045CD5A File Offset: 0x0045AF5A
	private IEnumerator JDDBBLAOEKB()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x0600A119 RID: 41241 RVA: 0x0045CD69 File Offset: 0x0045AF69
	private void NPAKNEAFDKE()
	{
		this.IMADGDGPBOB();
	}

	// Token: 0x0600A11A RID: 41242 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void PKMPOFOOGFK()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600A11B RID: 41243 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void AOIJOKHACJL()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600A11C RID: 41244 RVA: 0x0045CD7C File Offset: 0x0045AF7C
	public void ECDNEHIKLIH()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.FBACPHFCHJK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1821f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.DABHPBEMGGA());
	}

	// Token: 0x0600A11D RID: 41245 RVA: 0x0045CE14 File Offset: 0x0045B014
	public void DLKNMGILIJP()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = true;
		this.JGMAHGPBEDI = false;
		this.FBACPHFCHJK();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1789f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A11E RID: 41246 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void JLCMPLIMAEI()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600A11F RID: 41247 RVA: 0x0045CEA1 File Offset: 0x0045B0A1
	private void MOBCJBDMNCO()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.HEIGNAPIDPF();
		}
	}

	// Token: 0x0600A120 RID: 41248 RVA: 0x0045CD69 File Offset: 0x0045AF69
	private void PIBDCOBGMKC()
	{
		this.IMADGDGPBOB();
	}

	// Token: 0x0600A121 RID: 41249 RVA: 0x0045CEB8 File Offset: 0x0045B0B8
	private void NGCNFNNMPKC()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1823f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A122 RID: 41250 RVA: 0x0045CF30 File Offset: 0x0045B130
	public void NAOMOJKIMCN()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.NLNAHILOFOM();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 518f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GAAJIKPEJGO());
	}

	// Token: 0x0600A123 RID: 41251 RVA: 0x0045CFC8 File Offset: 0x0045B1C8
	public void EMHHFFAPLIN()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = true;
		this.FFEDFDKAEHC();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 390f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A124 RID: 41252 RVA: 0x0045D055 File Offset: 0x0045B255
	private IEnumerator GAAJIKPEJGO()
	{
		float seconds = 0.1f;
		if (!this.JGMAHGPBEDI)
		{
			this.JGMAHGPBEDI = true;
			seconds = this.entryShowDelay;
		}
		yield return new WaitForSeconds(seconds);
		this.NOJPGANKFDP = null;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x0600A125 RID: 41253 RVA: 0x0045D064 File Offset: 0x0045B264
	private void OnEnable()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.Show();
		}
	}

	// Token: 0x0600A126 RID: 41254 RVA: 0x0045D07C File Offset: 0x0045B27C
	public void IOJBOJHEJEJ()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1345f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = false;
			}
			return;
		}
		this.FDNBMHHEBGC();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 485f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.JDDBBLAOEKB());
	}

	// Token: 0x0600A127 RID: 41255 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void MGECIGFEKGI()
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
	}

	// Token: 0x0600A128 RID: 41256 RVA: 0x0045D1A4 File Offset: 0x0045B3A4
	public void GLDKNNPIHCL()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.NLNAHILOFOM();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 244f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.DABHPBEMGGA());
	}

	// Token: 0x0600A129 RID: 41257 RVA: 0x0045D23C File Offset: 0x0045B43C
	public void KCHBNEPECOG()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = true;
		this.JGMAHGPBEDI = true;
		this.NLNAHILOFOM();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1847f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
	}

	// Token: 0x0600A12A RID: 41258 RVA: 0x0045D2CC File Offset: 0x0045B4CC
	public void JIKAHCPJLAG()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = false;
		this.FFILFBPCENC();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1103f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
	}

	// Token: 0x0600A12B RID: 41259 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void CEJFHEBCHGK()
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
	}

	// Token: 0x0600A12C RID: 41260 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void FEBECEEIHBP()
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
	}

	// Token: 0x0600A12D RID: 41261 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator NEJMCMMDFMN()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A12E RID: 41262 RVA: 0x0045D368 File Offset: 0x0045B568
	private void FBACPHFCHJK()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1953f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A12F RID: 41263 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator JPHAGFLHLHH()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A130 RID: 41264 RVA: 0x0045D3DD File Offset: 0x0045B5DD
	private IEnumerator KGBIHOENNOL()
	{
		AvatarCollectionsFadeManager.CACIBMNBOMP cacibmnbomp = new AvatarCollectionsFadeManager.CACIBMNBOMP(1);
		cacibmnbomp.<>4__this = this;
		return cacibmnbomp;
	}

	// Token: 0x0600A131 RID: 41265 RVA: 0x0045D3EC File Offset: 0x0045B5EC
	public void NOECMFDDALC()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 403f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.FFEDFDKAEHC();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1478f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.GLFAGPEMFHL());
	}

	// Token: 0x0600A132 RID: 41266 RVA: 0x0045D4DC File Offset: 0x0045B6DC
	public void DDEEJMCKLDH()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = true;
		this.IMADGDGPBOB();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1487f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A133 RID: 41267 RVA: 0x0045CD5A File Offset: 0x0045AF5A
	private IEnumerator MPCGAMEDJGB()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x0600A134 RID: 41268 RVA: 0x0045D56C File Offset: 0x0045B76C
	public void COLCGJJMJCD()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = false;
		this.BAMHPOCKBML();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1910f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
	}

	// Token: 0x0600A135 RID: 41269 RVA: 0x0045D055 File Offset: 0x0045B255
	private IEnumerator LKDMBODIOPA()
	{
		float seconds = 0.1f;
		if (!this.JGMAHGPBEDI)
		{
			this.JGMAHGPBEDI = true;
			seconds = this.entryShowDelay;
		}
		yield return new WaitForSeconds(seconds);
		this.NOJPGANKFDP = null;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x0600A136 RID: 41270 RVA: 0x0045D5FC File Offset: 0x0045B7FC
	public void JBBMOJLEPKF()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.FFEDFDKAEHC();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1187f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.LKDMBODIOPA());
	}

	// Token: 0x0600A137 RID: 41271 RVA: 0x0045D694 File Offset: 0x0045B894
	public void GDCBLDIMCLA()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.FBACPHFCHJK();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1021f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 665f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.JDDBBLAOEKB());
	}

	// Token: 0x0600A138 RID: 41272 RVA: 0x0045D784 File Offset: 0x0045B984
	public void KCOEPHGAGJD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.FDNBMHHEBGC();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 22f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GACBCOCNEPL());
	}

	// Token: 0x0600A139 RID: 41273 RVA: 0x0045D81C File Offset: 0x0045BA1C
	public void IEDNDIONFCM()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.NGCNFNNMPKC();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1129f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.LKDMBODIOPA());
	}

	// Token: 0x0600A13A RID: 41274 RVA: 0x0045D8B4 File Offset: 0x0045BAB4
	public void HGPCCNDPBGK()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.BAMHPOCKBML();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 526f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GAAJIKPEJGO());
	}

	// Token: 0x0600A13B RID: 41275 RVA: 0x0045D94C File Offset: 0x0045BB4C
	public void NODNHEJJIGM()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = true;
		this.FBACPHFCHJK();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1521f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A13C RID: 41276 RVA: 0x0045D064 File Offset: 0x0045B264
	private void IFBCKJLCCAK()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.Show();
		}
	}

	// Token: 0x0600A13D RID: 41277 RVA: 0x0045D9DC File Offset: 0x0045BBDC
	public void IDFHKHLILEE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.FBACPHFCHJK();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 384f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.GNMCJIDLKNA());
	}

	// Token: 0x0600A13E RID: 41278 RVA: 0x0045CD5A File Offset: 0x0045AF5A
	private IEnumerator OEEOHENCNBH()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x0600A13F RID: 41279 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator CCONBJCCPKM()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A140 RID: 41280 RVA: 0x0045DA74 File Offset: 0x0045BC74
	public void PHMKLOKCDFF()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = true;
		this.NLNAHILOFOM();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1782f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
	}

	// Token: 0x0600A141 RID: 41281 RVA: 0x0045D3DD File Offset: 0x0045B5DD
	private IEnumerator KJIDHGDDIDF()
	{
		AvatarCollectionsFadeManager.CACIBMNBOMP cacibmnbomp = new AvatarCollectionsFadeManager.CACIBMNBOMP(1);
		cacibmnbomp.<>4__this = this;
		return cacibmnbomp;
	}

	// Token: 0x0600A142 RID: 41282 RVA: 0x0045DB04 File Offset: 0x0045BD04
	private void FFEDFDKAEHC()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1370f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A143 RID: 41283 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator GNMCJIDLKNA()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A144 RID: 41284 RVA: 0x0045DB79 File Offset: 0x0045BD79
	private void DJEHHCPNPHC()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = true;
			this.GLDKNNPIHCL();
		}
	}

	// Token: 0x0600A145 RID: 41285 RVA: 0x0045DB90 File Offset: 0x0045BD90
	private void FDNBMHHEBGC()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1715f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A146 RID: 41286 RVA: 0x0045CD5A File Offset: 0x0045AF5A
	private IEnumerator GLFAGPEMFHL()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x0600A147 RID: 41287 RVA: 0x0045DC05 File Offset: 0x0045BE05
	private void FMBLLOMGEDG()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.HGPCCNDPBGK();
		}
	}

	// Token: 0x0600A148 RID: 41288 RVA: 0x0045DC1C File Offset: 0x0045BE1C
	public void HEIGNAPIDPF()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.FDNBMHHEBGC();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1419f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.CCONBJCCPKM());
	}

	// Token: 0x0600A149 RID: 41289 RVA: 0x0045DCB4 File Offset: 0x0045BEB4
	public void JECNOPCOOCJ()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 368f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = false;
			}
			return;
		}
		this.NLNAHILOFOM();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 930f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x0600A14A RID: 41290 RVA: 0x0045DDA4 File Offset: 0x0045BFA4
	public void KEGLFLIHIJC()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.FBACPHFCHJK();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 777f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 858f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.JDDBBLAOEKB());
	}

	// Token: 0x0600A14B RID: 41291 RVA: 0x0045DE94 File Offset: 0x0045C094
	public void Show()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			return;
		}
		this.ANJAMMEGCMC = false;
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

	// Token: 0x0600A14C RID: 41292 RVA: 0x0045DF2C File Offset: 0x0045C12C
	public void JAMBACMJJGP()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = false;
		this.FFEDFDKAEHC();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1652f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A14D RID: 41293 RVA: 0x0045CD5A File Offset: 0x0045AF5A
	private IEnumerator JAEONIGCBPL()
	{
		yield return new WaitForSeconds(0.1f);
		this.LFCIBEEKAPP = null;
		if (null != this.JNIDFGCGGMF && null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 0f)
		{
			this.JNIDFGCGGMF.SetDirection(true);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.NOJPGANKFDP = null;
		yield break;
	}

	// Token: 0x0600A14E RID: 41294 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void NGEFPBFMCBP()
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
	}

	// Token: 0x0600A14F RID: 41295 RVA: 0x0045DFBC File Offset: 0x0045C1BC
	public void Hide()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.BAMHPOCKBML();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 0f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = false;
			}
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
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x0600A150 RID: 41296 RVA: 0x0045E0AC File Offset: 0x0045C2AC
	private void FDOPMEKNMEA()
	{
		this.NLNAHILOFOM();
	}

	// Token: 0x0600A151 RID: 41297 RVA: 0x0045E0B4 File Offset: 0x0045C2B4
	public void OJNDEJNLMFE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.IMADGDGPBOB();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1845f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.BAMHPOCKBML();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 85f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x0600A152 RID: 41298 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void DHDEDOICCHC()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600A153 RID: 41299 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void HLKKMONAIMG()
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
	}

	// Token: 0x0600A154 RID: 41300 RVA: 0x0045E1A4 File Offset: 0x0045C3A4
	private void FEIFMJKGGBO()
	{
		this.NGCNFNNMPKC();
	}

	// Token: 0x0600A155 RID: 41301 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void GMNFLAHGEHF()
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
	}

	// Token: 0x0600A156 RID: 41302 RVA: 0x0045E1AC File Offset: 0x0045C3AC
	private void FFILFBPCENC()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1176f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A157 RID: 41303 RVA: 0x0045E224 File Offset: 0x0045C424
	public void DJKKGMHJFNG()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = false;
		this.BAMHPOCKBML();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 778f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.NEJMCMMDFMN());
	}

	// Token: 0x0600A158 RID: 41304 RVA: 0x0045E2B9 File Offset: 0x0045C4B9
	private void FDFMDEOMJBH()
	{
		this.FDNBMHHEBGC();
	}

	// Token: 0x0600A159 RID: 41305 RVA: 0x0045E2C4 File Offset: 0x0045C4C4
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
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A15A RID: 41306 RVA: 0x0045D16C File Offset: 0x0045B36C
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
	}

	// Token: 0x0600A15B RID: 41307 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void LFEEHGLHJDN()
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
	}

	// Token: 0x0600A15C RID: 41308 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void EHLOONNKOPB()
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
	}

	// Token: 0x0600A15D RID: 41309 RVA: 0x0045E33C File Offset: 0x0045C53C
	public void OOOIAJFCJEL()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = true;
		this.JGMAHGPBEDI = false;
		this.FBACPHFCHJK();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1482f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A15E RID: 41310 RVA: 0x0045D3DD File Offset: 0x0045B5DD
	private IEnumerator LHNADCMPELM()
	{
		AvatarCollectionsFadeManager.CACIBMNBOMP cacibmnbomp = new AvatarCollectionsFadeManager.CACIBMNBOMP(1);
		cacibmnbomp.<>4__this = this;
		return cacibmnbomp;
	}

	// Token: 0x0600A15F RID: 41311 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void DMGCMLIGFCG()
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
	}

	// Token: 0x0600A160 RID: 41312 RVA: 0x0045E3CC File Offset: 0x0045C5CC
	public void CEMMEKGFOIE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.IMADGDGPBOB();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 580f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.IMADGDGPBOB();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1496f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x0600A161 RID: 41313 RVA: 0x0045E4BC File Offset: 0x0045C6BC
	private void PABMEBKPBJO()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = true;
			this.IEDNDIONFCM();
		}
	}

	// Token: 0x0600A162 RID: 41314 RVA: 0x0045CD69 File Offset: 0x0045AF69
	private void FKFGKNNNAAB()
	{
		this.IMADGDGPBOB();
	}

	// Token: 0x0600A163 RID: 41315 RVA: 0x0045E4D4 File Offset: 0x0045C6D4
	public void KFOFMBADHFC()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = true;
		this.JGMAHGPBEDI = true;
		this.FFEDFDKAEHC();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1682f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A164 RID: 41316 RVA: 0x0045E564 File Offset: 0x0045C764
	public void HGMPBPABHKG()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.FDNBMHHEBGC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1738f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = false;
			}
			return;
		}
		this.NLNAHILOFOM();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 717f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.LHNADCMPELM());
	}

	// Token: 0x0600A165 RID: 41317 RVA: 0x0045D3DD File Offset: 0x0045B5DD
	private IEnumerator ANMNHJCGBJA()
	{
		AvatarCollectionsFadeManager.CACIBMNBOMP cacibmnbomp = new AvatarCollectionsFadeManager.CACIBMNBOMP(1);
		cacibmnbomp.<>4__this = this;
		return cacibmnbomp;
	}

	// Token: 0x0600A166 RID: 41318 RVA: 0x0045E654 File Offset: 0x0045C854
	public void EEOOEDKIBKA()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.FDNBMHHEBGC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 302f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.IMADGDGPBOB();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1691f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.OEEOHENCNBH());
	}

	// Token: 0x0600A167 RID: 41319 RVA: 0x0045E744 File Offset: 0x0045C944
	private void EHBJOHMNJFH()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.DJKKGMHJFNG();
		}
	}

	// Token: 0x0600A168 RID: 41320 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void Start()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600A169 RID: 41321 RVA: 0x0045E75C File Offset: 0x0045C95C
	public void DGNENMLOPMC()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = true;
		this.FFEDFDKAEHC();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 310f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A16A RID: 41322 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void LOLCNLFKJCC()
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
	}

	// Token: 0x0600A16B RID: 41323 RVA: 0x0045E7EC File Offset: 0x0045C9EC
	public void OOBBPADKJJP()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 469f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.IMADGDGPBOB();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1857f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.MPCGAMEDJGB());
	}

	// Token: 0x0600A16C RID: 41324 RVA: 0x0045E8DC File Offset: 0x0045CADC
	private void IMADGDGPBOB()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = false;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1469f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A16D RID: 41325 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator DABHPBEMGGA()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A16E RID: 41326 RVA: 0x0045D055 File Offset: 0x0045B255
	private IEnumerator GACBCOCNEPL()
	{
		float seconds = 0.1f;
		if (!this.JGMAHGPBEDI)
		{
			this.JGMAHGPBEDI = true;
			seconds = this.entryShowDelay;
		}
		yield return new WaitForSeconds(seconds);
		this.NOJPGANKFDP = null;
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		if (null != this.JNIDFGCGGMF)
		{
			this.JNIDFGCGGMF.SetDirection(false);
			this.JNIDFGCGGMF.PlayAnimation(false);
		}
		this.LFCIBEEKAPP = null;
		yield break;
	}

	// Token: 0x0600A16F RID: 41327 RVA: 0x0045E951 File Offset: 0x0045CB51
	private void KMBJJAFMBMN()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.ECDNEHIKLIH();
		}
	}

	// Token: 0x0600A171 RID: 41329 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void DLBAEDOFAKM()
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
	}

	// Token: 0x0600A172 RID: 41330 RVA: 0x0045E97C File Offset: 0x0045CB7C
	public void PAMPANGOMPE()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.IMADGDGPBOB();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 651f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.DABHPBEMGGA());
	}

	// Token: 0x0600A173 RID: 41331 RVA: 0x0045D359 File Offset: 0x0045B559
	private IEnumerator DNEMFKBHGMI()
	{
		AvatarCollectionsFadeManager.BPGKPCGBLMH bpgkpcgblmh = new AvatarCollectionsFadeManager.BPGKPCGBLMH(1);
		bpgkpcgblmh.<>4__this = this;
		return bpgkpcgblmh;
	}

	// Token: 0x0600A174 RID: 41332 RVA: 0x0045EA14 File Offset: 0x0045CC14
	public void EFMPDECLFAB()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 653f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.NGCNFNNMPKC();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 433f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.ANMNHJCGBJA());
	}

	// Token: 0x0600A175 RID: 41333 RVA: 0x0045E744 File Offset: 0x0045C944
	private void MOAHMBJJGOH()
	{
		if (this.ANJAMMEGCMC)
		{
			this.ANJAMMEGCMC = false;
			this.DJKKGMHJFNG();
		}
	}

	// Token: 0x0600A176 RID: 41334 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void IEKKNHMNBBK()
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
	}

	// Token: 0x0600A177 RID: 41335 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void LDPOIIIAIOA()
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
	}

	// Token: 0x0600A178 RID: 41336 RVA: 0x0045EB04 File Offset: 0x0045CD04
	private void NLNAHILOFOM()
	{
		if (this.JIEPCIDINEH)
		{
			return;
		}
		this.JIEPCIDINEH = true;
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 986f;
			this.PANMNKKODPC.interactable = true;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.JNIDFGCGGMF = base.gameObject.GetComponent<AnimationCanvasGroupAlpha>();
	}

	// Token: 0x0600A179 RID: 41337 RVA: 0x0045EB7C File Offset: 0x0045CD7C
	public void EDAEKFNAJAH()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.FFEDFDKAEHC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 213f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.FDNBMHHEBGC();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 896f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.KGBIHOENNOL());
	}

	// Token: 0x0600A17A RID: 41338 RVA: 0x0045EC6C File Offset: 0x0045CE6C
	private void NCLALOLOIGP()
	{
		this.FFILFBPCENC();
	}

	// Token: 0x0600A17B RID: 41339 RVA: 0x0045EC74 File Offset: 0x0045CE74
	public void AIEDCCDBJFD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			return;
		}
		this.ANJAMMEGCMC = true;
		this.IMADGDGPBOB();
		if (this.LFCIBEEKAPP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha > 1796f && this.NOJPGANKFDP == null)
		{
			return;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
		}
		this.LFCIBEEKAPP = base.StartCoroutine(this.NEJMCMMDFMN());
	}

	// Token: 0x0600A17C RID: 41340 RVA: 0x0045ED0C File Offset: 0x0045CF0C
	public void CBAGDMNJHOD()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = true;
			this.NGCNFNNMPKC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1818f;
				this.PANMNKKODPC.interactable = false;
				this.PANMNKKODPC.blocksRaycasts = true;
			}
			return;
		}
		this.FBACPHFCHJK();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 291f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.JAEONIGCBPL());
	}

	// Token: 0x0600A17D RID: 41341 RVA: 0x0045EDFC File Offset: 0x0045CFFC
	public void ResetForNewVisit()
	{
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
			this.LFCIBEEKAPP = null;
		}
		if (this.NOJPGANKFDP != null)
		{
			base.StopCoroutine(this.NOJPGANKFDP);
			this.NOJPGANKFDP = null;
		}
		this.ANJAMMEGCMC = false;
		this.JGMAHGPBEDI = false;
		this.BAMHPOCKBML();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = false;
		}
	}

	// Token: 0x0600A17E RID: 41342 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void LBPCHKHFKIK()
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
	}

	// Token: 0x0600A17F RID: 41343 RVA: 0x0045EE8C File Offset: 0x0045D08C
	public void NMEIFHJFNCN()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			this.ANJAMMEGCMC = false;
			this.FDNBMHHEBGC();
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.alpha = 1401f;
				this.PANMNKKODPC.interactable = true;
				this.PANMNKKODPC.blocksRaycasts = false;
			}
			return;
		}
		this.FBACPHFCHJK();
		if (this.NOJPGANKFDP != null)
		{
			return;
		}
		if (null != this.PANMNKKODPC && this.PANMNKKODPC.alpha < 1746f && this.LFCIBEEKAPP == null)
		{
			return;
		}
		if (this.LFCIBEEKAPP != null)
		{
			base.StopCoroutine(this.LFCIBEEKAPP);
		}
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.interactable = false;
			this.PANMNKKODPC.blocksRaycasts = true;
		}
		this.NOJPGANKFDP = base.StartCoroutine(this.KGBIHOENNOL());
	}

	// Token: 0x0600A180 RID: 41344 RVA: 0x0045D16C File Offset: 0x0045B36C
	private void LPMPMAJGALN()
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
	}

	// Token: 0x0600A181 RID: 41345 RVA: 0x0045CD71 File Offset: 0x0045AF71
	private void KGMBFKBNDPJ()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x04002C2D RID: 11309
	public float entryShowDelay = 0.75f;

	// Token: 0x04002C2E RID: 11310
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04002C2F RID: 11311
	private AnimationCanvasGroupAlpha JNIDFGCGGMF;

	// Token: 0x04002C30 RID: 11312
	private bool JIEPCIDINEH;

	// Token: 0x04002C31 RID: 11313
	private Coroutine LFCIBEEKAPP;

	// Token: 0x04002C32 RID: 11314
	private Coroutine NOJPGANKFDP;

	// Token: 0x04002C33 RID: 11315
	private bool ANJAMMEGCMC;

	// Token: 0x04002C34 RID: 11316
	private bool JGMAHGPBEDI;
}
