using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000293 RID: 659
public class ContentCutsceneItem : MonoBehaviour
{
	// Token: 0x06005270 RID: 21104 RVA: 0x002427DC File Offset: 0x002409DC
	public void KDBLMMCCFII()
	{
		this.CGGGKLHAGLP(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x06005271 RID: 21105 RVA: 0x002427F0 File Offset: 0x002409F0
	public void EDEKOBDNGFO(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.LCKBNMPIEIF(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("preview" + this.LMOCIAEMCPK.Item1.ToString(), "OnSkinShopClose", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.anthologyTitleText.text.Length >= -121)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 25) + "{q}";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "YYY";
		this.NCFEEALEPGO(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.MHANOCPMADM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x06005272 RID: 21106 RVA: 0x0024298C File Offset: 0x00240B8C
	private void JJMEJAJNEID(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.PEGCNCPFHME();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005273 RID: 21107 RVA: 0x00242A70 File Offset: 0x00240C70
	private void PGBEKLPKFFE(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.IJDGJJCKHAH();
		this.AIIIBLMBJKB = 0;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB += 0;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005274 RID: 21108 RVA: 0x00242B54 File Offset: 0x00240D54
	private Vector2 DEOEGENMDOK(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[0];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06005275 RID: 21109 RVA: 0x00242B90 File Offset: 0x00240D90
	private void OMEEGBBKEEM(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.DIDLOFOLAOD(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005276 RID: 21110 RVA: 0x00242C00 File Offset: 0x00240E00
	public void HLFCDEHHFJH()
	{
		this.JJMEJAJNEID(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x00242C14 File Offset: 0x00240E14
	private bool MOPPINLBIGE(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.MJBDMHPHMID().lobbyDataAsset.CFAPFALEPHO(list[i].KKEBIBCEIPL, false))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x00242C74 File Offset: 0x00240E74
	public void IFNLFEJKFOB(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.HCHHGNOPFBJ(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("NEWSAVE: Warning: Missing anthology save data, yet story save data (" + this.LMOCIAEMCPK.Item1.ToString(), "yes", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.anthologyTitleText.text.Length >= 19)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 14) + "sbdg";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "no";
		this.PGBEKLPKFFE(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.GMGFICMEKGG(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x06005279 RID: 21113 RVA: 0x00242E10 File Offset: 0x00241010
	private bool LJEMIHJIEMJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.MJBDMHPHMID().lobbyDataAsset.IOPCDFPIDIJ(list[i].KKEBIBCEIPL, true))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600527A RID: 21114 RVA: 0x00242E70 File Offset: 0x00241070
	private void NBKBMFAKCAP(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.DIDBCOPAICH();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB += 0;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x0600527B RID: 21115 RVA: 0x00242F54 File Offset: 0x00241154
	public void FCAMDFFPNCH()
	{
		this.NBKBMFAKCAP(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x0600527C RID: 21116 RVA: 0x00242F67 File Offset: 0x00241167
	public void AMFFLOAMKEG()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 1;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x0600527D RID: 21117 RVA: 0x00242FA4 File Offset: 0x002411A4
	public void CJCAIJFFNBE(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.GFKMKEGDBJL(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("sind" + this.LMOCIAEMCPK.Item1.ToString(), "OnStoryInterfaceFastForwardActivate", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= 17)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 17) + "";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "Avatar pack has been kept:";
		this.EJGAHGDKBKH(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.EJPDIHDFHHC(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600527E RID: 21118 RVA: 0x00243140 File Offset: 0x00241340
	public void NLAEDEAFAGL(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.KBANHCHIBNN(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("OnSettingsPopupClose" + this.LMOCIAEMCPK.Item1.ToString(), "Starting parallel download:", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (this.anthologyTitleText.text.Length >= 1)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 121) + "nomorediamonds";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "OnAvatarCollectionSelect";
		this.GBAAFBIHAOF(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.DOCPNCJDKEB(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x002427DC File Offset: 0x002409DC
	public void DFNHGNABONP()
	{
		this.CGGGKLHAGLP(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x06005280 RID: 21120 RVA: 0x002432D9 File Offset: 0x002414D9
	public void OEGHKHMNFCD()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005281 RID: 21121 RVA: 0x00243318 File Offset: 0x00241518
	public void ILACLBOOCKI()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = true;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.EDPLNMNKMFJ(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x06005282 RID: 21122 RVA: 0x00243474 File Offset: 0x00241674
	private void MBPLKGAIMLE(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.CAFGDHHBHAD(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005283 RID: 21123 RVA: 0x002434E4 File Offset: 0x002416E4
	private void BPFLBCLNGHM(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.CKPHLKDOFDM(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).SetContent(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005284 RID: 21124 RVA: 0x00243554 File Offset: 0x00241754
	private void JHLKMHLAJOP(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.BBCDPILAIAD(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005285 RID: 21125 RVA: 0x002435C4 File Offset: 0x002417C4
	public void UpdateFavCutsceneCount()
	{
		this.MKBKJLKEJJC(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x06005286 RID: 21126 RVA: 0x002435D8 File Offset: 0x002417D8
	private void FHJMICOAJLF(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.KJOHJOADCGJ();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB += 0;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x002436BC File Offset: 0x002418BC
	private void EDPLNMNKMFJ(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.BNAAOLIBIDO(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).SetContent(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x0024372C File Offset: 0x0024192C
	public void MHLFBCOMCGJ(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.LANOMOPFLDB(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("_" + this.LMOCIAEMCPK.Item1.ToString(), "default", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= -10)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, -44) + "Error deserializing JSON. Unknown tag: ";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "passrequiredtoplay";
		this.PGBEKLPKFFE(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.MHANOCPMADM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x06005289 RID: 21129 RVA: 0x002438C8 File Offset: 0x00241AC8
	private bool AMGEEMDBKJD(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.IOPCDFPIDIJ(list[i].KKEBIBCEIPL, false))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x002432D9 File Offset: 0x002414D9
	public void IADCDCCDILH()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x00243928 File Offset: 0x00241B28
	private Vector2 EHDCINDBHKN(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[3];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x00243962 File Offset: 0x00241B62
	public void KIOLCPFEPDP()
	{
		this.FHJMICOAJLF(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x00243978 File Offset: 0x00241B78
	public void GFLPMKNPFFC()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.JHLKMHLAJOP(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x002432D9 File Offset: 0x002414D9
	public void KPLPPFHKHCB()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x0600528F RID: 21135 RVA: 0x00243AD4 File Offset: 0x00241CD4
	private void GMGFICMEKGG(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.EDCMKDLKKMC(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x06005290 RID: 21136 RVA: 0x00243B44 File Offset: 0x00241D44
	private Vector2 DFEGHGOBKJJ(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[8];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06005291 RID: 21137 RVA: 0x00243B80 File Offset: 0x00241D80
	public void NLIKDFIMLNP(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.EOFBCMLFOPL(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.LMOCIAEMCPK.Item1.ToString(), "skinshoptutorbody", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.anthologyTitleText.text.Length >= -90)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 73) + "OnAppleLoginSuccess";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "OnFullscreenCardOptionClick";
		this.CGGGKLHAGLP(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.BPFLBCLNGHM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x06005292 RID: 21138 RVA: 0x00242F67 File Offset: 0x00241167
	public void IGMPDOBALJH()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 1;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005293 RID: 21139 RVA: 0x00243D1C File Offset: 0x00241F1C
	private void EJGAHGDKBKH(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.DIDBCOPAICH();
		this.AIIIBLMBJKB = 0;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005294 RID: 21140 RVA: 0x00243962 File Offset: 0x00241B62
	public void NHIGPIJIMHA()
	{
		this.FHJMICOAJLF(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x06005295 RID: 21141 RVA: 0x00243E00 File Offset: 0x00242000
	private void IIFGFACHFNE(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.IJDGJJCKHAH();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB += 0;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x06005296 RID: 21142 RVA: 0x00243EE4 File Offset: 0x002420E4
	private bool CEICHLCDEKF(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.CFAPFALEPHO(list[i].KKEBIBCEIPL, false))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005297 RID: 21143 RVA: 0x00243F44 File Offset: 0x00242144
	private bool KLDLPEGJJNF(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.NCIBCBNAOGH(list[i].KKEBIBCEIPL, false))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005298 RID: 21144 RVA: 0x00243FA4 File Offset: 0x002421A4
	private bool GCPFKCIDFJL(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005299 RID: 21145 RVA: 0x00244004 File Offset: 0x00242204
	public void HFKMAIPDBOC()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.ELIPDEKGOJL(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600529A RID: 21146 RVA: 0x00244160 File Offset: 0x00242360
	public void ADHGJKDEFGK()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.OMEEGBBKEEM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600529B RID: 21147 RVA: 0x002442BC File Offset: 0x002424BC
	private Vector2 CKPHLKDOFDM(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[6];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x0600529C RID: 21148 RVA: 0x002442F8 File Offset: 0x002424F8
	private bool LPDILIHDEGD(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, false))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600529D RID: 21149 RVA: 0x00244358 File Offset: 0x00242558
	public void DCFKJCDMGEO()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x0600529E RID: 21150 RVA: 0x00242F54 File Offset: 0x00241154
	public void BMNPIBPBKEM()
	{
		this.NBKBMFAKCAP(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x0600529F RID: 21151 RVA: 0x002444B4 File Offset: 0x002426B4
	private void NCFEEALEPGO(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.KJOHJOADCGJ();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052A0 RID: 21152 RVA: 0x002432D9 File Offset: 0x002414D9
	public void KJGCANOFLEH()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052A1 RID: 21153 RVA: 0x00244598 File Offset: 0x00242798
	private bool KEPJKMDMDOD(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.NCIBCBNAOGH(list[i].KKEBIBCEIPL, true))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060052A2 RID: 21154 RVA: 0x002445F8 File Offset: 0x002427F8
	private bool KDDAICAEKPM(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.CFAPFALEPHO(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052A3 RID: 21155 RVA: 0x00244658 File Offset: 0x00242858
	private Vector2 EDCMKDLKKMC(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[8];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x060052A4 RID: 21156 RVA: 0x00244694 File Offset: 0x00242894
	private bool PJMJKBBIALK(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.MJBDMHPHMID().lobbyDataAsset.KHKCIBJMLCH(list[i].KKEBIBCEIPL, false))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060052A5 RID: 21157 RVA: 0x002446F4 File Offset: 0x002428F4
	private bool GEODCJMPIBC(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052A6 RID: 21158 RVA: 0x00244754 File Offset: 0x00242954
	public void KGLKJPKHGEJ(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.AJGOPDBGCNI(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("assetbundlecustomfader" + this.LMOCIAEMCPK.Item1.ToString(), ", maxAind ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= 64)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 10) + "importanttitle";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "watchvideo";
		this.MKBKJLKEJJC(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052A7 RID: 21159 RVA: 0x002448F0 File Offset: 0x00242AF0
	public void LEACCCDBLBD(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.DNLEKMGKLIO(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.LMOCIAEMCPK.Item1.ToString(), "Asset bundle assets destroyed:", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.anthologyTitleText.text.Length >= -34)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 97) + "ok";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "aind";
		this.NCFEEALEPGO(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.JHLKMHLAJOP(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052A8 RID: 21160 RVA: 0x00244A8C File Offset: 0x00242C8C
	public void SetContent([TupleElementNames(new string[]
	{
		"anthologyIndex",
		"cutsceneCount",
		"profile",
		"renameCutscene",
		"deleteCutscene",
		"viewCutscene",
		"updateContentCutscenesHeaderStatus",
		"viewport",
		"isFolded",
		null,
		null
	})] ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.LCKBNMPIEIF(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.LMOCIAEMCPK.Item1.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (this.anthologyTitleText.text.Length >= 18)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 15) + "...";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += ":";
		this.MKBKJLKEJJC(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.KLIHGIKLBJE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052A9 RID: 21161 RVA: 0x00244C28 File Offset: 0x00242E28
	public void POCEBECBIAD(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.EOFBCMLFOPL(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("varConditionNot" + this.LMOCIAEMCPK.Item1.ToString(), "+", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= -113)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 23) + ", rid:";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "achievtitle";
		this.BHBNMMNLGKH(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.GMGFICMEKGG(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052AA RID: 21162 RVA: 0x00244DC4 File Offset: 0x00242FC4
	private void BHBNMMNLGKH(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.KJOHJOADCGJ();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB += 0;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052AB RID: 21163 RVA: 0x00242C00 File Offset: 0x00240E00
	public void CAINPJPAGHN()
	{
		this.JJMEJAJNEID(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x060052AC RID: 21164 RVA: 0x00244EA8 File Offset: 0x002430A8
	private bool EJOBGDGEFJP(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, false))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052AD RID: 21165 RVA: 0x00244F08 File Offset: 0x00243108
	private Vector2 BBCDPILAIAD(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[5];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x060052AE RID: 21166 RVA: 0x00242F67 File Offset: 0x00241167
	public void UpdateCutsceneCountOnRemove()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 1;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052AF RID: 21167 RVA: 0x00244F44 File Offset: 0x00243144
	private bool CEBMLAALMMG(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.KHKCIBJMLCH(list[i].KKEBIBCEIPL, true))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060052B0 RID: 21168 RVA: 0x00244FA4 File Offset: 0x002431A4
	private bool JHFOHIOJFCH(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.KHKCIBJMLCH(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060052B1 RID: 21169 RVA: 0x002432D9 File Offset: 0x002414D9
	public void AHBDBKHHNBG()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052B2 RID: 21170 RVA: 0x00245004 File Offset: 0x00243204
	public void NJGFKADDHCD()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.DOCPNCJDKEB(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052B3 RID: 21171 RVA: 0x00245160 File Offset: 0x00243360
	private void MKBKJLKEJJC(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.IJDGJJCKHAH();
		this.AIIIBLMBJKB = 0;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052B4 RID: 21172 RVA: 0x00245244 File Offset: 0x00243444
	private bool FIAFNMIKABH(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, false))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060052B5 RID: 21173 RVA: 0x002452A4 File Offset: 0x002434A4
	private bool EMAPIOOFJGL(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.MJBDMHPHMID().lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052B6 RID: 21174 RVA: 0x00242F67 File Offset: 0x00241167
	public void KJHMGDJGPEP()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 1;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052B7 RID: 21175 RVA: 0x00245304 File Offset: 0x00243504
	private Vector2 BNAAOLIBIDO(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[7];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x060052B8 RID: 21176 RVA: 0x00245340 File Offset: 0x00243540
	private bool GLEDNENHADJ(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.IOPCDFPIDIJ(list[i].KKEBIBCEIPL, false))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052B9 RID: 21177 RVA: 0x002453A0 File Offset: 0x002435A0
	public void DDPDILFBHOL(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.OAIANNBALHF(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.LMOCIAEMCPK.Item1.ToString(), "_", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.anthologyTitleText.text.Length >= -93)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 58) + "Critical error, could not load asset bundle:";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "";
		this.JJMEJAJNEID(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.JHLKMHLAJOP(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052BA RID: 21178 RVA: 0x0024553C File Offset: 0x0024373C
	private Vector2 FDODAFCBCAB(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[3];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x060052BB RID: 21179 RVA: 0x00245578 File Offset: 0x00243778
	private Vector2 DIDLOFOLAOD(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[7];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x060052BC RID: 21180 RVA: 0x002455B4 File Offset: 0x002437B4
	public void MKFMHMDOBOE(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.EKDPMHMKOEA(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("0.000" + this.LMOCIAEMCPK.Item1.ToString(), "<i>", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (this.anthologyTitleText.text.Length >= -65)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, -122) + "socialsendgiftprembody";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "assetbundleavatarextensionpack";
		this.PGBEKLPKFFE(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052BD RID: 21181 RVA: 0x00245750 File Offset: 0x00243950
	public void KNFKJOGGNIC(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.MJBDMHPHMID().profileDataLocalizedAsset.IOIINCPJKKL(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("lireq" + this.LMOCIAEMCPK.Item1.ToString(), "SceneLobbyManager2.AppendGroupBatch() - ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.anthologyTitleText.text.Length >= 89)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 110) + " (";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "emailcollecheader";
		this.EJGAHGDKBKH(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.MBPLKGAIMLE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052BE RID: 21182 RVA: 0x002458EC File Offset: 0x00243AEC
	private void KLIHGIKLBJE(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.EAAKKEEIION(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).SetContent(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052BF RID: 21183 RVA: 0x00242F67 File Offset: 0x00241167
	public void JAEHJCEGFGO()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 1;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052C0 RID: 21184 RVA: 0x0024595C File Offset: 0x00243B5C
	public void DIIHHBCFMFH()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = true;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x002432D9 File Offset: 0x002414D9
	public void HIIDKIMEGDF()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052C2 RID: 21186 RVA: 0x00245AB8 File Offset: 0x00243CB8
	public void DIOIMFOKAII()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = true;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.MHANOCPMADM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052C3 RID: 21187 RVA: 0x00245C14 File Offset: 0x00243E14
	private bool FLINMPPLOLB(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.KHKCIBJMLCH(list[i].KKEBIBCEIPL, true))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060052C4 RID: 21188 RVA: 0x00245C73 File Offset: 0x00243E73
	public void OJAGGAPOAIM()
	{
		this.EJGAHGDKBKH(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x060052C5 RID: 21189 RVA: 0x00245C88 File Offset: 0x00243E88
	private void IFBHHJJOBNK(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.EHDCINDBHKN(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052C6 RID: 21190 RVA: 0x00245CF8 File Offset: 0x00243EF8
	public void IMAHJMFLBBI()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.BLHNACHKCNE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052C7 RID: 21191 RVA: 0x00245E54 File Offset: 0x00244054
	private bool LJBPCDLMCCC(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.IOPCDFPIDIJ(list[i].KKEBIBCEIPL, false))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060052C8 RID: 21192 RVA: 0x00245EB4 File Offset: 0x002440B4
	public void GOMDOMNMHDF()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.EJPDIHDFHHC(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052C9 RID: 21193 RVA: 0x00246010 File Offset: 0x00244210
	private void ELIPDEKGOJL(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.BNAAOLIBIDO(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x002432D9 File Offset: 0x002414D9
	public void AGLEALKPANC()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x00246080 File Offset: 0x00244280
	public void OMNHNGBOEAJ()
	{
		this.BHBNMMNLGKH(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x060052CC RID: 21196 RVA: 0x00246094 File Offset: 0x00244294
	public void OKMLFLPMHCM(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.JPJAEFNMIDG(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.LMOCIAEMCPK.Item1.ToString(), "envlhrw", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.anthologyTitleText.text.Length >= -119)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 21) + "Error: SceneLobbyManager2.RestartChapterSilent() hit. Send this message to Vlad.";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "onThemeChange";
		this.FHJMICOAJLF(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.BLHNACHKCNE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x00246230 File Offset: 0x00244430
	private void EJPDIHDFHHC(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.EHDCINDBHKN(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).SetContent(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052CE RID: 21198 RVA: 0x002462A0 File Offset: 0x002444A0
	public void HBOBOKGLEGM(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.LJCBOHCBOJN(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("$" + this.LMOCIAEMCPK.Item1.ToString(), "OnSketchThumbnailsCdnSuccess", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (this.anthologyTitleText.text.Length >= 1)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(1, 13) + "later";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "bits";
		this.NCFEEALEPGO(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.EJPDIHDFHHC(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x0024643C File Offset: 0x0024463C
	private void DOCPNCJDKEB(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.DFEGHGOBKJJ(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052D0 RID: 21200 RVA: 0x002464AC File Offset: 0x002446AC
	public void FMENJBFAFDF()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.ELIPDEKGOJL(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x00246608 File Offset: 0x00244808
	private bool LELFPGJPOEB(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.NCIBCBNAOGH(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060052D2 RID: 21202 RVA: 0x00246668 File Offset: 0x00244868
	public void IJLHNKAAOLJ()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.MBPLKGAIMLE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052D3 RID: 21203 RVA: 0x002432D9 File Offset: 0x002414D9
	public void GHLCCLCMCKC()
	{
		this.LMOCIAEMCPK.Item2 = this.LMOCIAEMCPK.Item2 - 0;
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x002467C4 File Offset: 0x002449C4
	private void CGGGKLHAGLP(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.KJOHJOADCGJ();
		this.AIIIBLMBJKB = 1;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x002468A8 File Offset: 0x00244AA8
	private void MHANOCPMADM(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.EHDCINDBHKN(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).HBOBOKGLEGM(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x00246918 File Offset: 0x00244B18
	public void KBJKMJAHNNE()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = true;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = false;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052D7 RID: 21207 RVA: 0x00246A74 File Offset: 0x00244C74
	private Vector2 EAAKKEEIION(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[4];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x00246AB0 File Offset: 0x00244CB0
	public void FoldToogleCutscenes()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.KLIHGIKLBJE(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052D9 RID: 21209 RVA: 0x00246C0C File Offset: 0x00244E0C
	private Vector2 CAFGDHHBHAD(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[3];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x060052DA RID: 21210 RVA: 0x00246C46 File Offset: 0x00244E46
	public void DKGLEKLAGCG()
	{
		this.NCFEEALEPGO(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x060052DB RID: 21211 RVA: 0x00246C5C File Offset: 0x00244E5C
	public void JAMOICINGJO()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(true);
				this.GMGFICMEKGG(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[1];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052DC RID: 21212 RVA: 0x00246DB8 File Offset: 0x00244FB8
	public void PLOMHJBDHME(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.JMAGBGIEGEA(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("DontDestroyOnLoad" + this.LMOCIAEMCPK.Item1.ToString(), "envlsrw", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= 44)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, -124) + "OnStoryInterfaceHeaderHideComplete";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += "\"";
		this.FHJMICOAJLF(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(true);
			this.ELIPDEKGOJL(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052DD RID: 21213 RVA: 0x00246F54 File Offset: 0x00245154
	public void KGMDDHJIFBE()
	{
		if (this.NALODLCPIMO)
		{
			this.NALODLCPIMO = false;
			if (this.cutsceneSmallItems.childCount == 0)
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.MHANOCPMADM(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
			else
			{
				this.dropButtonImage.sprite = this.dropSprites[0];
				this.cutsceneSmallItems.gameObject.SetActive(false);
				this.LMOCIAEMCPK.Item3.LDKBOMCJIPL(this.LMOCIAEMCPK.Item1);
			}
		}
		else
		{
			this.NALODLCPIMO = true;
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.LMOCIAEMCPK.Item3.HMEJIGIOIOE(this.LMOCIAEMCPK.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052DE RID: 21214 RVA: 0x00242F54 File Offset: 0x00241154
	public void MFCLLIDJFML()
	{
		this.NBKBMFAKCAP(this.LMOCIAEMCPK.Item3);
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x002470B0 File Offset: 0x002452B0
	private void GBAAFBIHAOF(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		List<string> list2 = FOKFGMIEEDB.IJDGJJCKHAH();
		this.AIIIBLMBJKB = 0;
		foreach (BNFCLKNDBLO bnfclkndblo in list)
		{
			if (bnfclkndblo.AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				using (List<string>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == bnfclkndblo.IAGMLHAEOJI)
						{
							this.AIIIBLMBJKB++;
						}
					}
				}
			}
		}
		this.favCutsceneCountText.text = this.AIIIBLMBJKB.ToString();
		this.LMOCIAEMCPK.Item7();
	}

	// Token: 0x060052E0 RID: 21216 RVA: 0x00247194 File Offset: 0x00245394
	private bool LGIDFFEPJIE(PMEPALPCEAF FOKFGMIEEDB)
	{
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1 && !AssetsManager.MJBDMHPHMID().lobbyDataAsset.FIDCFFPHNAP(list[i].KKEBIBCEIPL, true))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x002471F4 File Offset: 0x002453F4
	public void ONFFCCAMHGK(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.NJMGOHKHEOL(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("stat2" + this.LMOCIAEMCPK.Item1.ToString(), "length", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (this.anthologyTitleText.text.Length >= -58)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, -83) + "lf2";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += ", ";
		this.FHJMICOAJLF(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[0];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.DOCPNCJDKEB(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x060052E3 RID: 21219 RVA: 0x00247390 File Offset: 0x00245590
	private void BLHNACHKCNE(PMEPALPCEAF FOKFGMIEEDB, UnityAction<GameObject> GAHOGJNENML, UnityAction<BNFCLKNDBLO, GameObject, GameObject> ENLEPAFDJDL, UnityAction<BNFCLKNDBLO> CKCKIDJKOMK, RectTransform GAONCDGIHPJ)
	{
		Vector2 onkonhljkpg = this.CAFGDHHBHAD(GAONCDGIHPJ);
		List<BNFCLKNDBLO> list = FOKFGMIEEDB.IPILOAEGBMD();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].AMKCLHLIIMN == this.LMOCIAEMCPK.Item1)
			{
				UnityEngine.Object.Instantiate<ContentCusceneSmallItem>(this.cutsceneSmallItemPrefab, this.cutsceneSmallItems).SetContent(list[i], base.gameObject, FOKFGMIEEDB, GAHOGJNENML, ENLEPAFDJDL, CKCKIDJKOMK, onkonhljkpg);
			}
		}
	}

	// Token: 0x060052E4 RID: 21220 RVA: 0x00247400 File Offset: 0x00245600
	private Vector2 JBJHAGEABIF(RectTransform GAONCDGIHPJ)
	{
		Vector3[] array = new Vector3[8];
		GAONCDGIHPJ.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x060052E5 RID: 21221 RVA: 0x0024743C File Offset: 0x0024563C
	public void OAACGALMOEG(ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> BHCIIFICHDN)
	{
		this.LMOCIAEMCPK = BHCIIFICHDN;
		this.thumbImage.sprite = AssetsManager.EHBBFMCILPC.profileDataLocalizedAsset.LJCBOHCBOJN(this.LMOCIAEMCPK.Item1);
		this.cutsceneCountText.text = this.LMOCIAEMCPK.Item2.ToString();
		this.anthologyTitleText.text = GKJPOGNFKNK.DNILNCLIHAP("nastring" + this.LMOCIAEMCPK.Item1.ToString(), " failed after ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
		if (this.anthologyTitleText.text.Length >= 72)
		{
			this.anthologyTitleText.text = this.anthologyTitleText.text.Substring(0, 105) + "assetbundlelobbydata";
		}
		TextMeshProUGUI textMeshProUGUI = this.favCutsceneText;
		textMeshProUGUI.text += " ";
		this.PGBEKLPKFFE(this.LMOCIAEMCPK.Item3);
		this.NALODLCPIMO = this.LMOCIAEMCPK.Rest.Item2;
		if (!this.NALODLCPIMO)
		{
			this.dropButtonImage.sprite = this.dropSprites[1];
			this.cutsceneSmallItems.gameObject.SetActive(false);
			this.IFBHHJJOBNK(this.LMOCIAEMCPK.Item3, this.LMOCIAEMCPK.Item4, this.LMOCIAEMCPK.Item5, this.LMOCIAEMCPK.Item6, this.LMOCIAEMCPK.Rest.Item1);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.cutsceneSmallItems.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.GetComponent<RectTransform>());
	}

	// Token: 0x04001726 RID: 5926
	[SerializeField]
	private Image thumbImage;

	// Token: 0x04001727 RID: 5927
	[SerializeField]
	private TextMeshProUGUI cutsceneCountText;

	// Token: 0x04001728 RID: 5928
	[SerializeField]
	private TextMeshProUGUI anthologyTitleText;

	// Token: 0x04001729 RID: 5929
	[SerializeField]
	private TextMeshProUGUI favCutsceneCountText;

	// Token: 0x0400172A RID: 5930
	[SerializeField]
	private TextMeshProUGUI favCutsceneText;

	// Token: 0x0400172B RID: 5931
	[SerializeField]
	private Transform cutsceneSmallItems;

	// Token: 0x0400172C RID: 5932
	[SerializeField]
	private ContentCusceneSmallItem cutsceneSmallItemPrefab;

	// Token: 0x0400172D RID: 5933
	[SerializeField]
	private Image dropButtonImage;

	// Token: 0x0400172E RID: 5934
	[SerializeField]
	private Sprite[] dropSprites;

	// Token: 0x0400172F RID: 5935
	private bool NALODLCPIMO;

	// Token: 0x04001730 RID: 5936
	private int AIIIBLMBJKB;

	// Token: 0x04001731 RID: 5937
	[TupleElementNames(new string[]
	{
		"anthologyIndex",
		"cutsceneCount",
		"profile",
		"renameCutscene",
		"deleteCutscene",
		"viewCutscene",
		"updateContentCutscenesHeaderStatus",
		"viewport",
		"isFolded",
		null,
		null
	})]
	private ValueTuple<int, int, PMEPALPCEAF, UnityAction<GameObject>, UnityAction<BNFCLKNDBLO, GameObject, GameObject>, UnityAction<BNFCLKNDBLO>, UnityAction, ValueTuple<RectTransform, bool>> LMOCIAEMCPK;
}
