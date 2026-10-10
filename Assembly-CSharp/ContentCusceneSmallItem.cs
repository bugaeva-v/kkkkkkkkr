using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020002CC RID: 716
public class ContentCusceneSmallItem : MonoBehaviour
{
	// Token: 0x060058FA RID: 22778 RVA: 0x0028249C File Offset: 0x0028069C
	private void BMDFCDCGDNG()
	{
		this.addToFavButton.gameObject.SetActive(true);
		this.removeFromFavButton.gameObject.SetActive(false);
		this.ICKBPKHIFLM.a = this.OJAIPBGBOMB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.AEDICCFAKOM.HEEHBPKIIEP(this.EHCCKGCLNGI.IAGMLHAEOJI);
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().DKGLEKLAGCG();
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x00282513 File Offset: 0x00280713
	public BNFCLKNDBLO LKONDCNGEDO()
	{
		return this.EHCCKGCLNGI;
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x0028251C File Offset: 0x0028071C
	private void CBCJABBJFAN()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.itemButton.gameObject.SetActive(active);
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x00282564 File Offset: 0x00280764
	private void LGMEGGMOGDA()
	{
		this.addToFavButton.gameObject.SetActive(false);
		this.removeFromFavButton.gameObject.SetActive(true);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.AEDICCFAKOM.HKGOBAPMPFJ(this.EHCCKGCLNGI.IAGMLHAEOJI);
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060058FE RID: 22782 RVA: 0x00282513 File Offset: 0x00280713
	public BNFCLKNDBLO BMCOOGNFAEJ
	{
		get
		{
			return this.EHCCKGCLNGI;
		}
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x002825DC File Offset: 0x002807DC
	private void HJJNEACAIMF()
	{
		if (ContentCusceneSmallItem.LHFFFMJIFDM != 1295f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentCusceneSmallItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x0028264C File Offset: 0x0028084C
	public void HLKHLAIJCNF()
	{
		this.anthologyTitleText.SetText("ok" + this.EHCCKGCLNGI.PGEKNGNHANN + "avatarcollectionstitle", false);
		this.anthologyTitleText.text = "" + this.EHCCKGCLNGI.PGEKNGNHANN + "profilenametitleshort";
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x002826A4 File Offset: 0x002808A4
	public static void ResetSmallItemOpenState(BNFCLKNDBLO CIBKELALAHF)
	{
		foreach (ContentCusceneSmallItem contentCusceneSmallItem in UnityEngine.Object.FindObjectsOfType<ContentCusceneSmallItem>())
		{
			if (CIBKELALAHF.IAGMLHAEOJI == contentCusceneSmallItem.EHCCKGCLNGI.IAGMLHAEOJI)
			{
				if (!contentCusceneSmallItem.LLCFPDHKBJM)
				{
					contentCusceneSmallItem.LLCFPDHKBJM = true;
					contentCusceneSmallItem.itemButton.anchoredPosition = new Vector3(contentCusceneSmallItem.itemButton.anchoredPosition.x - 365f, contentCusceneSmallItem.itemButton.anchoredPosition.y);
					GameObject[] array2 = contentCusceneSmallItem.buttonsParent;
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].SetActive(true);
					}
				}
				else
				{
					contentCusceneSmallItem.LLCFPDHKBJM = false;
					contentCusceneSmallItem.itemButton.anchoredPosition = Vector3.zero;
					GameObject[] array2 = contentCusceneSmallItem.buttonsParent;
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].SetActive(false);
					}
				}
			}
			else
			{
				contentCusceneSmallItem.LLCFPDHKBJM = false;
				contentCusceneSmallItem.itemButton.anchoredPosition = Vector3.zero;
				GameObject[] array2 = contentCusceneSmallItem.buttonsParent;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].SetActive(false);
				}
			}
		}
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x002827DC File Offset: 0x002809DC
	public void FBIJBDOFENH()
	{
		this.addToFavButton.gameObject.SetActive(false);
		this.removeFromFavButton.gameObject.SetActive(false);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().MFCLLIDJFML();
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x00282840 File Offset: 0x00280A40
	private void JAIJMPGNHMK()
	{
		this.addToFavButton.gameObject.SetActive(true);
		this.removeFromFavButton.gameObject.SetActive(false);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.AEDICCFAKOM.HKGOBAPMPFJ(this.EHCCKGCLNGI.IAGMLHAEOJI);
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x002828B8 File Offset: 0x00280AB8
	public void SetContent(BNFCLKNDBLO CIBKELALAHF, GameObject BPIBOHLBKMC, PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, Vector2 ONKONHLJKPG)
	{
		ContentCusceneSmallItem.DHHNMJPALOA dhhnmjpaloa = new ContentCusceneSmallItem.DHHNMJPALOA();
		dhhnmjpaloa.renameCutscene = GAHOGJNENML;
		dhhnmjpaloa.<>4__this = this;
		dhhnmjpaloa.deleteCutscene = ENLEPAFDJDL;
		dhhnmjpaloa._cutscene = CIBKELALAHF;
		dhhnmjpaloa._mainCutsceneAnthology = BPIBOHLBKMC;
		dhhnmjpaloa.viewCutscene = CKCKIDJKOMK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FLPGNPNHJNK = dhhnmjpaloa._cutscene.KKEBIBCEIPL;
		this.IGJELOAEIAK = dhhnmjpaloa._mainCutsceneAnthology;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.EHCCKGCLNGI = dhhnmjpaloa._cutscene;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.CJEEKHDPLLI(this.FLPGNPNHJNK);
		this.anthologyTitleText.SetText("\"" + dhhnmjpaloa._cutscene.PGEKNGNHANN + "\"", true);
		this.anthologyTitleText.text = "\"" + dhhnmjpaloa._cutscene.PGEKNGNHANN + "\"";
		this.renameButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.FKHKHDCHMJH));
		this.deleteButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.LAGOMHGDENF));
		this.viewButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.LFHLCNMHPOJ));
		this.addToFavButton.onClick.AddListener(new UnityAction(this.NJBBPJKNPNA));
		this.removeFromFavButton.onClick.AddListener(new UnityAction(this.JAIJMPGNHMK));
		this.ICKBPKHIFLM = this.favImage.color;
		if (this.AEDICCFAKOM.IJDGJJCKHAH().Contains(dhhnmjpaloa._cutscene.IAGMLHAEOJI))
		{
			this.addToFavButton.gameObject.SetActive(false);
			this.removeFromFavButton.gameObject.SetActive(true);
			this.ICKBPKHIFLM.a = this.OJAIPBGBOMB;
			this.favImage.color = this.ICKBPKHIFLM;
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
		this.NDKJNKCLKGN();
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x00282AB0 File Offset: 0x00280CB0
	private void NPJIMHOPOGF()
	{
		if (ContentCusceneSmallItem.LHFFFMJIFDM != 668f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentCusceneSmallItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x00282B04 File Offset: 0x00280D04
	private void NDKJNKCLKGN()
	{
		if (ContentCusceneSmallItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentCusceneSmallItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x00282B58 File Offset: 0x00280D58
	private void Update()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.itemButton.gameObject.SetActive(active);
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x00282BA0 File Offset: 0x00280DA0
	public void LJHDHBIAHMO()
	{
		this.addToFavButton.gameObject.SetActive(false);
		this.removeFromFavButton.gameObject.SetActive(true);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().DFNHGNABONP();
	}

	// Token: 0x0600590A RID: 22794 RVA: 0x00282C04 File Offset: 0x00280E04
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentCusceneSmallItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentCusceneSmallItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x00282C5E File Offset: 0x00280E5E
	public void OpenOptions()
	{
		ContentCusceneSmallItem.ResetSmallItemOpenState(this.EHCCKGCLNGI);
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x00282C6C File Offset: 0x00280E6C
	private void NJBBPJKNPNA()
	{
		this.addToFavButton.gameObject.SetActive(false);
		this.removeFromFavButton.gameObject.SetActive(true);
		this.ICKBPKHIFLM.a = this.OJAIPBGBOMB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.AEDICCFAKOM.DCBPJJFIMOA(this.EHCCKGCLNGI.IAGMLHAEOJI);
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
	}

	// Token: 0x0600590D RID: 22797 RVA: 0x00282CE4 File Offset: 0x00280EE4
	public void ResetItem()
	{
		this.addToFavButton.gameObject.SetActive(true);
		this.removeFromFavButton.gameObject.SetActive(false);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().UpdateFavCutsceneCount();
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x00282D48 File Offset: 0x00280F48
	public void IHBLJEJDNDF()
	{
		this.addToFavButton.gameObject.SetActive(false);
		this.removeFromFavButton.gameObject.SetActive(true);
		this.ICKBPKHIFLM.a = this.AFHHKKOMAGB;
		this.favImage.color = this.ICKBPKHIFLM;
		this.IGJELOAEIAK.GetComponent<ContentCutsceneItem>().FCAMDFFPNCH();
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x00282DAC File Offset: 0x00280FAC
	public void RenameCutscene()
	{
		this.anthologyTitleText.SetText("\"" + this.EHCCKGCLNGI.PGEKNGNHANN + "\"", true);
		this.anthologyTitleText.text = "\"" + this.EHCCKGCLNGI.PGEKNGNHANN + "\"";
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x00282E04 File Offset: 0x00281004
	public void HBOBOKGLEGM(BNFCLKNDBLO CIBKELALAHF, GameObject BPIBOHLBKMC, PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, Vector2 ONKONHLJKPG)
	{
		ContentCusceneSmallItem.DHHNMJPALOA dhhnmjpaloa = new ContentCusceneSmallItem.DHHNMJPALOA();
		dhhnmjpaloa.renameCutscene = GAHOGJNENML;
		dhhnmjpaloa.<>4__this = this;
		dhhnmjpaloa.deleteCutscene = ENLEPAFDJDL;
		dhhnmjpaloa._cutscene = CIBKELALAHF;
		dhhnmjpaloa._mainCutsceneAnthology = BPIBOHLBKMC;
		dhhnmjpaloa.viewCutscene = CKCKIDJKOMK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FLPGNPNHJNK = dhhnmjpaloa._cutscene.KKEBIBCEIPL;
		this.IGJELOAEIAK = dhhnmjpaloa._mainCutsceneAnthology;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.EHCCKGCLNGI = dhhnmjpaloa._cutscene;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.CJEEKHDPLLI(this.FLPGNPNHJNK);
		this.anthologyTitleText.SetText("OnEmailUnsubscribeSuccess" + dhhnmjpaloa._cutscene.PGEKNGNHANN + "acli22", true);
		this.anthologyTitleText.text = "ok" + dhhnmjpaloa._cutscene.PGEKNGNHANN + "ok";
		this.renameButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.FKHKHDCHMJH));
		this.deleteButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.LAGOMHGDENF));
		this.viewButton.onClick.AddListener(new UnityAction(dhhnmjpaloa.LFHLCNMHPOJ));
		this.addToFavButton.onClick.AddListener(new UnityAction(this.BMDFCDCGDNG));
		this.removeFromFavButton.onClick.AddListener(new UnityAction(this.JAIJMPGNHMK));
		this.ICKBPKHIFLM = this.favImage.color;
		if (this.AEDICCFAKOM.KJOHJOADCGJ().Contains(dhhnmjpaloa._cutscene.IAGMLHAEOJI))
		{
			this.addToFavButton.gameObject.SetActive(true);
			this.removeFromFavButton.gameObject.SetActive(false);
			this.ICKBPKHIFLM.a = this.OJAIPBGBOMB;
			this.favImage.color = this.ICKBPKHIFLM;
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
		this.NPJIMHOPOGF();
	}

	// Token: 0x04001921 RID: 6433
	private static float LHFFFMJIFDM;

	// Token: 0x04001922 RID: 6434
	[SerializeField]
	private Image thumbImage;

	// Token: 0x04001923 RID: 6435
	[SerializeField]
	private TextMeshProUGUI anthologyTitleText;

	// Token: 0x04001924 RID: 6436
	[SerializeField]
	private RectTransform itemButton;

	// Token: 0x04001925 RID: 6437
	[SerializeField]
	private Button renameButton;

	// Token: 0x04001926 RID: 6438
	[SerializeField]
	private Button deleteButton;

	// Token: 0x04001927 RID: 6439
	[SerializeField]
	private Button viewButton;

	// Token: 0x04001928 RID: 6440
	[SerializeField]
	private Button addToFavButton;

	// Token: 0x04001929 RID: 6441
	[SerializeField]
	private Button removeFromFavButton;

	// Token: 0x0400192A RID: 6442
	[SerializeField]
	private Image favImage;

	// Token: 0x0400192B RID: 6443
	[SerializeField]
	private GameObject[] buttonsParent;

	// Token: 0x0400192C RID: 6444
	private string FLPGNPNHJNK;

	// Token: 0x0400192D RID: 6445
	private GameObject IGJELOAEIAK;

	// Token: 0x0400192E RID: 6446
	private PMEPALPCEAF AEDICCFAKOM;

	// Token: 0x0400192F RID: 6447
	private BNFCLKNDBLO EHCCKGCLNGI;

	// Token: 0x04001930 RID: 6448
	private bool LLCFPDHKBJM;

	// Token: 0x04001931 RID: 6449
	private Color ICKBPKHIFLM;

	// Token: 0x04001932 RID: 6450
	private readonly float OJAIPBGBOMB = 1f;

	// Token: 0x04001933 RID: 6451
	private readonly float AFHHKKOMAGB = 0.2f;

	// Token: 0x04001934 RID: 6452
	private Vector2 ONKONHLJKPG;

	// Token: 0x04001935 RID: 6453
	private int JFLPGONDKDB;

	// Token: 0x020002CD RID: 717
	[CompilerGenerated]
	private sealed class DHHNMJPALOA
	{
		// Token: 0x06005911 RID: 22801 RVA: 0x00282FFB File Offset: 0x002811FB
		internal void FKHKHDCHMJH()
		{
			this.renameCutscene(this.<>4__this.gameObject);
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x00283013 File Offset: 0x00281213
		internal void LAGOMHGDENF()
		{
			this.deleteCutscene(this._cutscene, this.<>4__this.gameObject, this._mainCutsceneAnthology);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00283037 File Offset: 0x00281237
		internal void LFHLCNMHPOJ()
		{
			this.viewCutscene(this._cutscene);
		}

		// Token: 0x04001936 RID: 6454
		public UnityAction<GameObject> renameCutscene;

		// Token: 0x04001937 RID: 6455
		public ContentCusceneSmallItem <>4__this;

		// Token: 0x04001938 RID: 6456
		public UnityAction<BNFCLKNDBLO, GameObject, GameObject> deleteCutscene;

		// Token: 0x04001939 RID: 6457
		public BNFCLKNDBLO _cutscene;

		// Token: 0x0400193A RID: 6458
		public GameObject _mainCutsceneAnthology;

		// Token: 0x0400193B RID: 6459
		public UnityAction<BNFCLKNDBLO> viewCutscene;
	}
}
