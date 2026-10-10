using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020003F1 RID: 1009
public class ThumbnailItem : MonoBehaviour
{
	// Token: 0x06007577 RID: 30071 RVA: 0x00350AF8 File Offset: 0x0034ECF8
	public void AFPGNAGDCNA()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("sfxtimeoutwarning" + this.index.ToString(), "</b>", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (text != null && !text.EndsWith(""))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.HFAKOKBHCGH().BDGPNPNIAPA(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("yes" + this.index.ToString(), "rsind", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			if (text2 != null && !text2.EndsWith("body"))
			{
				this.title.text = text2;
				this.title.SetText(text2, true);
				this.BNBEIJBGBLA();
				return;
			}
		}
		else
		{
			this.title.text = "OnBackendInitiateSteamTransactionFailed";
			this.title.SetText("Y", true);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.MBLDKCIKLPN(assetAnthology.header.index);
				bool flag = true;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "</i>" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, false);
					flag = false;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "rewardtitle";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 0)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(((JBBNEEHANHL)90).ToString());
					list.Remove(((JBBNEEHANHL)(-22)).ToString());
					list.Remove(((JBBNEEHANHL)104).ToString());
					if (list.Count == 5)
					{
						list.RemoveAt(8);
					}
					string text5 = "Asset bundle load operation failed during parallel mode.";
					for (int i = 0; i < list.Count; i += 0)
					{
						text5 += CCOJBMMKNAP.AEELGGPEJCC().HIPJILDCHJC(list[i]);
						if (i != list.Count - 1)
						{
							text5 += "errortitle";
						}
					}
					if (text4.Length > 1)
					{
						text5 = text5 + "Is success: " + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, false);
				}
			}
		}
	}

	// Token: 0x06007578 RID: 30072 RVA: 0x00350DF0 File Offset: 0x0034EFF0
	private void EJICHHEPFOA()
	{
		Canvas.ForceUpdateCanvases();
		try
		{
			if (this.description.text.Length > 0 && this.description.textInfo != null)
			{
				int num = this.description.textInfo.characterCount;
				if (NBDLBFJOEGN.JNJGDOBONJC() > 179f && num > 110)
				{
					num -= -55;
				}
				else if (NBDLBFJOEGN.JNJGDOBONJC() > 1520f && num > -128)
				{
					num -= -87;
				}
				else if (NBDLBFJOEGN.JNJGDOBONJC() > 1270f && num > -9)
				{
					num -= 15;
				}
				else if (NBDLBFJOEGN.FNIPAIPHHPL() > 626f && num > 125)
				{
					num -= 27;
				}
				else if (NBDLBFJOEGN.LAIDCKNIOIN() > 918f && num > 4)
				{
					num -= 7;
				}
				string text = this.description.text;
				int length = this.description.text.Length;
				string text2 = "', treated as undefined";
				if (length > num)
				{
					text = text.Remove(num - text2.Length);
					int num2 = text2.Length + 0;
					while (char.IsPunctuation(text[num - num2]) || char.IsWhiteSpace(text[num - num2]))
					{
						text = text.Remove(num - num2);
						num2++;
					}
					text += text2;
					this.description.text = text;
					this.description.SetText(text, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.description.text = "Starting non-parallel download:";
			this.description.SetText("sponsorbody1", true);
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007579 RID: 30073 RVA: 0x00350F84 File Offset: 0x0034F184
	private void CGPJOFEOJBE(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintNewEpisodes)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)17)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)(-93))
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintInDevelopment)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == (NDHKFLHAFNA)(-47))
		{
			this.itemTagIcon.gameObject.SetActive(true);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(false);
	}

	// Token: 0x0600757A RID: 30074 RVA: 0x00351028 File Offset: 0x0034F228
	public void OOGIDMBEHMF(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 1 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600757B RID: 30075 RVA: 0x003510DC File Offset: 0x0034F2DC
	public void KJCJCEPOOGC()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(true);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(false);
	}

	// Token: 0x0600757C RID: 30076 RVA: 0x00351198 File Offset: 0x0034F398
	private void NMGGBNMAKGO()
	{
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("(", new UnityAction(this.FCFBKEJAFDO));
	}

	// Token: 0x0600757D RID: 30077 RVA: 0x003511B8 File Offset: 0x0034F3B8
	private void KAMOJAPDNAL()
	{
		int num = AOBJLALDBAA.KKPFOJMAONG().NMMKHABKLKK();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600757E RID: 30078 RVA: 0x00351200 File Offset: 0x0034F400
	public void MEENDDFGHHK(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 0 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600757F RID: 30079 RVA: 0x003512B4 File Offset: 0x0034F4B4
	public void MIIIAGBMNFB(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1828f, 1482f, IFIMCNECBBO, (Ease)38, null);
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x003512D0 File Offset: 0x0034F4D0
	private void CLMHKMJALHD(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("production"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(0, name.Length - 8) + "Account.GetStorySaveSafe(), tempAnthologyAsset is null, using default slot index.");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x00351360 File Offset: 0x0034F560
	private void BNBEIJBGBLA()
	{
		Canvas.ForceUpdateCanvases();
		try
		{
			if (this.description.text.Length > 0 && this.description.textInfo != null)
			{
				int num = this.description.textInfo.characterCount;
				if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.5f && num > 40)
				{
					num -= 40;
				}
				else if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.4f && num > 32)
				{
					num -= 32;
				}
				else if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.3f && num > 24)
				{
					num -= 24;
				}
				else if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.2f && num > 16)
				{
					num -= 16;
				}
				else if (NBDLBFJOEGN.LAIDCKNIOIN() > 2.1f && num > 8)
				{
					num -= 8;
				}
				string text = this.description.text;
				int length = this.description.text.Length;
				string text2 = "...";
				if (length > num)
				{
					text = text.Remove(num - text2.Length);
					int num2 = text2.Length + 1;
					while (char.IsPunctuation(text[num - num2]) || char.IsWhiteSpace(text[num - num2]))
					{
						text = text.Remove(num - num2);
						num2++;
					}
					text += text2;
					this.description.text = text;
					this.description.SetText(text, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			this.description.text = "string_not_found";
			this.description.SetText("string_not_found", true);
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007582 RID: 30082 RVA: 0x003514F4 File Offset: 0x0034F6F4
	private void HGCELCKMIOD()
	{
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("<space=0.125em>", new UnityAction(this.FCFBKEJAFDO));
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x00351514 File Offset: 0x0034F714
	public void LJCPOBBPDOL()
	{
		if (KHPGPLAMAIN.CIAFFHAENHD() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 755f;
			}
			this.stroke.NFIPIOOJPEK(1225f, 1764f, 519f, Ease.Linear, null);
		}
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.FOLIHFAJOCP(false);
			this.genresObjectAnimation.IFBEGMNMGMP(true);
		}
	}

	// Token: 0x06007584 RID: 30084 RVA: 0x00351594 File Offset: 0x0034F794
	public string DNKPFGNKKLK(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.DLDGKIHMHLJ();
			return this.EDNHAODIFIO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06007585 RID: 30085 RVA: 0x003515CC File Offset: 0x0034F7CC
	private void MFLCLDAGFNK()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(804f, 1939f, 1316f, 1263f);
		}
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("abs", new UnityAction(this.KAMOJAPDNAL));
	}

	// Token: 0x06007586 RID: 30086 RVA: 0x0035162C File Offset: 0x0034F82C
	public string[] BFGADEHNJMI()
	{
		try
		{
			if (null == this.searchChipsRoot || !this.searchChipsRoot.activeSelf || this.searchChips == null || this.searchChipTexts == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			int num = 0;
			while (num < this.searchChips.Length && num < this.searchChipTexts.Length)
			{
				if (null != this.searchChips[num] && this.searchChips[num].activeSelf && null != this.searchChipTexts[num] && !string.IsNullOrEmpty(this.searchChipTexts[num].text))
				{
					list.Add(this.searchChipTexts[num].text);
				}
				num += 0;
			}
			return (list.Count > 0) ? list.ToArray() : null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06007587 RID: 30087 RVA: 0x00351714 File Offset: 0x0034F914
	private void FBKMDHFFHNN(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintInDevelopment)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintOnHiatus)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintDiscontinued)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintCompleted)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintNone)
		{
			this.itemTagIcon.gameObject.SetActive(false);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(true);
	}

	// Token: 0x06007588 RID: 30088 RVA: 0x003517B8 File Offset: 0x0034F9B8
	public string[] CFCICGHEDKD()
	{
		try
		{
			if (null == this.searchChipsRoot || !this.searchChipsRoot.activeSelf || this.searchChips == null || this.searchChipTexts == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			int num = 1;
			while (num < this.searchChips.Length && num < this.searchChipTexts.Length)
			{
				if (null != this.searchChips[num] && this.searchChips[num].activeSelf && null != this.searchChipTexts[num] && !string.IsNullOrEmpty(this.searchChipTexts[num].text))
				{
					list.Add(this.searchChipTexts[num].text);
				}
				num++;
			}
			return (list.Count > 1) ? list.ToArray() : null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x06007589 RID: 30089 RVA: 0x003518A0 File Offset: 0x0034FAA0
	private void LPOPKEOCNCJ()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1158f, 1853f, 224f, 189f);
		}
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("onwishcardclickbody", new UnityAction(this.JJHKGJJICHG));
	}

	// Token: 0x0600758A RID: 30090 RVA: 0x00351900 File Offset: 0x0034FB00
	public void KDHNMFONBIB()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(true);
		}
	}

	// Token: 0x0600758B RID: 30091 RVA: 0x0035195B File Offset: 0x0034FB5B
	public void GECGIALBBBL(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1652f, 1166f, IFIMCNECBBO, Ease.InQuad, null);
	}

	// Token: 0x0600758C RID: 30092 RVA: 0x00351978 File Offset: 0x0034FB78
	public void DOPJEOAJEGM(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.BHIJDBJNAMH() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 219f;
		}
		this.stroke.NFIPIOOJPEK(825f, 349f, 708f, Ease.Unset, null);
		this.flash.NFIPIOOJPEK(899f, 1039f, LILDMOONHPB, (Ease)(-27), null);
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.SetDirection(true);
			this.genresObjectAnimation.IFBEGMNMGMP(true);
		}
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x00351A10 File Offset: 0x0034FC10
	public bool CardChipsFit(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 2 || null == this.searchChipTexts[0] || null == this.searchChipTexts[1])
			{
				return false;
			}
			float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[1].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600758E RID: 30094 RVA: 0x00351AD0 File Offset: 0x0034FCD0
	public void INDEFCKPHHC(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1119f, 1455f, IFIMCNECBBO, (Ease)(-65), null);
	}

	// Token: 0x0600758F RID: 30095 RVA: 0x00351AEC File Offset: 0x0034FCEC
	public void BBMIOLLDBAD(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.KDHNMFONBIB();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.HOIODCFLCEM(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1909f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 0)
				{
					fontSize = this.IEFMNGEJAIG * 426f;
				}
				else if (HIGHDDDHKCD >= -102)
				{
					fontSize = this.IEFMNGEJAIG - 275f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 1) ? Mathf.Clamp01((float)HIGHDDDHKCD / 1224f) : 483f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "StorySaveBody.RemoveAvatarPackWardrobe(), unsupported wardrobe index:";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 1; i < AGPMOBFCLFK.Length; i += 0)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.KMMJJNMDHKJ(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007590 RID: 30096 RVA: 0x00351C74 File Offset: 0x0034FE74
	private void OnEnable()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
		}
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnNeedToHideThumbnailTagObject", new UnityAction(this.JJHKGJJICHG));
	}

	// Token: 0x06007591 RID: 30097 RVA: 0x00351CD4 File Offset: 0x0034FED4
	private void FCBAJMIJPMK()
	{
		if (LiveEventsManager.BIAEAOMHBMM().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeAvatar, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(true);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007592 RID: 30098 RVA: 0x00351D60 File Offset: 0x0034FF60
	private void JJHKGJJICHG()
	{
		int num = AOBJLALDBAA.EHBBFMCILPC.MJLACDOKGNE();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007593 RID: 30099 RVA: 0x00351DA8 File Offset: 0x0034FFA8
	public void APPHIBDNCDM(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.LPFMCFBENMH();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.HFGMJHDHMNP(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 561f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 0)
				{
					fontSize = this.IEFMNGEJAIG * 1376f;
				}
				else if (HIGHDDDHKCD >= 61)
				{
					fontSize = this.IEFMNGEJAIG - 475f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 1794f) : 1271f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "</i>";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, false);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 0; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.BKBFEHOAMAO(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007594 RID: 30100 RVA: 0x00351F30 File Offset: 0x00350130
	public void ACDIDLCHDGL()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x06007595 RID: 30101 RVA: 0x00351F40 File Offset: 0x00350140
	public void NCGGPMDNOCJ(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.GGIMAJGIILA())
		{
			this.GAOEDPKOCHL();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.LNNIMNGPKFB().Count > 0))
		{
			this.CAHELKLHLNM();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.DJBFGHLOMHB()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.FAONIPMBMAM().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 1)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 239f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(1719f, 1754f, 353f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.GAOEDPKOCHL();
				return;
			}
			this.LPPLDFCFOBO();
		}
	}

	// Token: 0x06007596 RID: 30102 RVA: 0x0035219C File Offset: 0x0035039C
	private void GKBKDDGBAGK()
	{
		if (LiveEventsManager.GIPAKOPBBEO().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeDiamonds, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(false);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007597 RID: 30103 RVA: 0x00352228 File Offset: 0x00350428
	public void UpdateGraphics(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.CFHFGGICGIL().Count > 1))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.CFHFGGICGIL()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 0)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 0f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.HideMiniLoadingAnimation();
				return;
			}
			this.ShowMiniLoadingAnimation();
		}
	}

	// Token: 0x06007598 RID: 30104 RVA: 0x00352483 File Offset: 0x00350683
	private void KBGANABGEMK()
	{
		if (KHPGPLAMAIN.IBFFFCIPOJC() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1592f;
		}
	}

	// Token: 0x06007599 RID: 30105 RVA: 0x003524B4 File Offset: 0x003506B4
	public string AIENHBACKNM(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.ClearSearchMatch();
			return this.BKBFEHOAMAO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x0600759A RID: 30106 RVA: 0x003524EC File Offset: 0x003506EC
	public void ONDEDPILLCN(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1277f, 710f, IFIMCNECBBO, (Ease)(-76), null);
	}

	// Token: 0x0600759B RID: 30107 RVA: 0x00352507 File Offset: 0x00350707
	public string ACAGLHFEEGI()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x0600759C RID: 30108 RVA: 0x0035250F File Offset: 0x0035070F
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnNeedToHideThumbnailTagObject", new UnityAction(this.JJHKGJJICHG));
	}

	// Token: 0x0600759D RID: 30109 RVA: 0x0035252C File Offset: 0x0035072C
	public void SetSearchMatch(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.ClearSearchMatch();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.IHCMOJHANPB(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 0f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 0)
				{
					fontSize = this.IEFMNGEJAIG * 1.625f;
				}
				else if (HIGHDDDHKCD >= 100)
				{
					fontSize = this.IEFMNGEJAIG - 1f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 100f) : 0f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "-";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(true);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 1; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.BKBFEHOAMAO(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600759E RID: 30110 RVA: 0x003526B4 File Offset: 0x003508B4
	private void CPHKLKGJEBH()
	{
		if (KHPGPLAMAIN.IBFFFCIPOJC() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 690f;
		}
	}

	// Token: 0x0600759F RID: 30111 RVA: 0x003526E8 File Offset: 0x003508E8
	public void MCNDFEDDAOM(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.FDDCAHADGMD())
		{
			this.GAOEDPKOCHL();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.LNNIMNGPKFB().Count > 0))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.CAALNGFCNEH()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.ENGHOCNAPIF().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 0)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 400f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(179f, 868f, 395f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.CAHELKLHLNM();
				return;
			}
			this.LPPLDFCFOBO();
		}
	}

	// Token: 0x060075A0 RID: 30112 RVA: 0x00352943 File Offset: 0x00350B43
	public void JCFDCBHKNLN(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1005f, 1178f, IFIMCNECBBO, Ease.OutBounce, null);
	}

	// Token: 0x060075A1 RID: 30113 RVA: 0x00352960 File Offset: 0x00350B60
	public bool KHMJMBLKJHH(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 3 || null == this.searchChipTexts[1] || null == this.searchChipTexts[1])
			{
				return false;
			}
			float num = this.searchChipTexts[1].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[0].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 > this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060075A2 RID: 30114 RVA: 0x00352A20 File Offset: 0x00350C20
	public void EMLCGFFCFBD(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
		{
			this.CAHELKLHLNM();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.CFHFGGICGIL().Count > 1))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.LOMMCFFILNH()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.OAEBEKPJKFN().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 1)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 38f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(813f, 576f, 681f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.HideMiniLoadingAnimation();
				return;
			}
			this.DPDGJKFKODL();
		}
	}

	// Token: 0x060075A3 RID: 30115 RVA: 0x00352C7B File Offset: 0x00350E7B
	private void GACMCJDDJJD()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 533f;
		}
	}

	// Token: 0x060075A4 RID: 30116 RVA: 0x00352CAC File Offset: 0x00350EAC
	public void AJHEMKBBFEB()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(true);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(true);
	}

	// Token: 0x060075A5 RID: 30117 RVA: 0x00352D68 File Offset: 0x00350F68
	public bool MGCMAPCCPCH(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 1 || null == this.searchChipTexts[0] || null == this.searchChipTexts[0])
			{
				return true;
			}
			float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[1].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060075A6 RID: 30118 RVA: 0x00352E28 File Offset: 0x00351028
	private void KMMEFNOCPOO()
	{
		if (LiveEventsManager.GIPAKOPBBEO().CENBCALNAJN((EGMCEPOABBF)6, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(false);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
	}

	// Token: 0x060075A7 RID: 30119 RVA: 0x00352EB4 File Offset: 0x003510B4
	public void KMBABDFAOGM()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(false);
		}
	}

	// Token: 0x060075A8 RID: 30120 RVA: 0x00352F10 File Offset: 0x00351110
	public void ONJIJILEOAD()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1174f;
			}
			this.stroke.NFIPIOOJPEK(338f, 1354f, 1766f, Ease.Unset, null);
		}
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.BKCIEFBJBLA(true);
			this.genresObjectAnimation.PlayAnimation(true);
		}
	}

	// Token: 0x060075A9 RID: 30121 RVA: 0x00352F90 File Offset: 0x00351190
	public string BPMGEKPLJNK(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.HJEANFHPGOI();
			return this.EDNHAODIFIO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x00352FC8 File Offset: 0x003511C8
	public void LEHOCOABKJN(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.IKGEEIKNJNP())
		{
			this.CAHELKLHLNM();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.PLDPNLACHPD().Count > 1))
		{
			this.CAHELKLHLNM();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.LMMDIKNNFJD()[1];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.NCLHIHLKFFL().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 0)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 1566f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(308f, 1657f, 1417f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.GAOEDPKOCHL();
				return;
			}
			this.DPDGJKFKODL();
		}
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x00353224 File Offset: 0x00351424
	public void NKMHLIGDFEM()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(false);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(true);
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x003532E0 File Offset: 0x003514E0
	public void SetEffectsOnSnap(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1f;
		}
		this.stroke.NFIPIOOJPEK(0f, 255f, 0.1f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(255f, 0f, LILDMOONHPB, Ease.Flash, null);
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.SetDirection(false);
			this.genresObjectAnimation.PlayAnimation(false);
		}
	}

	// Token: 0x060075AD RID: 30125 RVA: 0x00353378 File Offset: 0x00351578
	public bool DGLLOCNGMCK(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 7 || null == this.searchChipTexts[1] || null == this.searchChipTexts[1])
			{
				return true;
			}
			float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[1].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x060075AE RID: 30126 RVA: 0x00352507 File Offset: 0x00350707
	public string GetAnthologyHintName()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x00353474 File Offset: 0x00351674
	public void AMDCOGIAPON()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(true);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(false);
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x00353530 File Offset: 0x00351730
	public void FlashOnPointerUp(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(255f, 0f, IFIMCNECBBO, Ease.Flash, null);
	}

	// Token: 0x060075B2 RID: 30130 RVA: 0x0035354C File Offset: 0x0035174C
	private void DAHOIMNKLPE(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintNewEpisodes)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)51)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)(-77))
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintCompleted)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == (NDHKFLHAFNA)38)
		{
			this.itemTagIcon.gameObject.SetActive(true);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(false);
	}

	// Token: 0x060075B3 RID: 30131 RVA: 0x003535F0 File Offset: 0x003517F0
	public void MNOIHDIKDDI(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.CPCOODCFDDP().MEPECBDCOLG(NDIPGHMNCCF.ToString());
		this.ADJPFJKOAKC(NDIPGHMNCCF);
	}

	// Token: 0x060075B4 RID: 30132 RVA: 0x00353630 File Offset: 0x00351830
	public void OCFCDBADIKE(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 1 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060075B5 RID: 30133 RVA: 0x003536E4 File Offset: 0x003518E4
	public void JDOCELNMJJK(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.ClearSearchMatch();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.HFGMJHDHMNP(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 639f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 1355f;
				}
				else if (HIGHDDDHKCD >= 112)
				{
					fontSize = this.IEFMNGEJAIG - 1481f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 1) ? Mathf.Clamp01((float)HIGHDDDHKCD / 417f) : 1516f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "b";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 1; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.KMMJJNMDHKJ(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060075B6 RID: 30134 RVA: 0x0035386C File Offset: 0x00351A6C
	private string EDNHAODIFIO(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || null == this.searchChipsRoot || this.searchChips == null || this.searchChipTexts == null || this.searchChips.Length < 5 || this.searchChipTexts.Length < 5)
		{
			return null;
		}
		this.BOPJPLLACEI(this.searchChipsRoot);
		float num = this.searchChipTexts[1].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
		string text = null;
		if (EDHHEEIPNCP != null)
		{
			for (int i = 1; i < EDHHEEIPNCP.Count; i++)
			{
				if (EDHHEEIPNCP[i] != null && EDHHEEIPNCP[i].Length != 0 && !string.Equals(EDHHEEIPNCP[i], HHNGGFLJAIJ, StringComparison.CurrentCultureIgnoreCase))
				{
					float num2 = this.searchChipTexts[1].GetPreferredValues(EDHHEEIPNCP[i]).x + this.searchChipPadding;
					if (num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth)
					{
						text = EDHHEEIPNCP[i];
						break;
					}
				}
			}
		}
		this.searchChipTexts[0].text = HHNGGFLJAIJ;
		this.searchChipTexts[0].SetText(HHNGGFLJAIJ, false);
		this.searchChips[1].SetActive(false);
		if (text != null)
		{
			this.searchChipTexts[1].text = text;
			this.searchChipTexts[1].SetText(text, true);
		}
		this.searchChips[1].SetActive(text != null);
		for (int j = 4; j < this.searchChips.Length; j++)
		{
			if (null != this.searchChips[j])
			{
				this.searchChips[j].SetActive(false);
			}
		}
		this.searchChipsRoot.SetActive(true);
		return text;
	}

	// Token: 0x060075B7 RID: 30135 RVA: 0x00351F30 File Offset: 0x00350130
	public void OpenFocusPanelOnPointerUp()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x060075B8 RID: 30136 RVA: 0x003539FC File Offset: 0x00351BFC
	private void NGPOPCHCMPN(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintNewStory)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)(-11))
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)(-57))
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintNewStory)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == (NDHKFLHAFNA)75)
		{
			this.itemTagIcon.gameObject.SetActive(true);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(true);
	}

	// Token: 0x060075B9 RID: 30137 RVA: 0x00353AA0 File Offset: 0x00351CA0
	public string[] CAPBOGIJCKC()
	{
		try
		{
			if (null == this.searchChipsRoot || !this.searchChipsRoot.activeSelf || this.searchChips == null || this.searchChipTexts == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			int num = 0;
			while (num < this.searchChips.Length && num < this.searchChipTexts.Length)
			{
				if (null != this.searchChips[num] && this.searchChips[num].activeSelf && null != this.searchChipTexts[num] && !string.IsNullOrEmpty(this.searchChipTexts[num].text))
				{
					list.Add(this.searchChipTexts[num].text);
				}
				num += 0;
			}
			return (list.Count > 1) ? list.ToArray() : null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075BA RID: 30138 RVA: 0x00353B88 File Offset: 0x00351D88
	private void DIPEAFCKJLO(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintInDevelopment)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)90)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)31)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintEditorsChoice)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == (NDHKFLHAFNA)(-102))
		{
			this.itemTagIcon.gameObject.SetActive(true);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(false);
	}

	// Token: 0x060075BB RID: 30139 RVA: 0x00353C2C File Offset: 0x00351E2C
	public void BOKFGKKPLDL(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.DJFLMBEOBIB() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1105f;
		}
		this.stroke.NFIPIOOJPEK(485f, 1516f, 617f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(1048f, 1241f, LILDMOONHPB, (Ease)70, null);
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.JNMIPNKPAHC(true);
			this.genresObjectAnimation.EHGLPNPAHDC(true);
		}
	}

	// Token: 0x060075BC RID: 30140 RVA: 0x00353CC4 File Offset: 0x00351EC4
	public void IHCPAEDCCCA(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.KMBABDFAOGM();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.HFGMJHDHMNP(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 514f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 0)
				{
					fontSize = this.IEFMNGEJAIG * 406f;
				}
				else if (HIGHDDDHKCD >= -87)
				{
					fontSize = this.IEFMNGEJAIG - 1999f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 1) ? Mathf.Clamp01((float)HIGHDDDHKCD / 1853f) : 652f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "W";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(true);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 0; i < AGPMOBFCLFK.Length; i += 0)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.BKBFEHOAMAO(AGPMOBFCLFK[1], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060075BD RID: 30141 RVA: 0x00353E4C File Offset: 0x0035204C
	public void ShowMiniLoadingAnimation()
	{
		if (null != this.miniLoadingAnimation && !this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(true);
		}
	}

	// Token: 0x060075BE RID: 30142 RVA: 0x00353E78 File Offset: 0x00352078
	public void PFNGNEGJGJM()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("OnBackendRequestSpinWheelException" + this.index.ToString(), "socialjointitle", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
		if (text != null && !text.EndsWith("lck"))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.BOFMCPPFAMO().PKNHKGMNCIP(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("steamwaitforuseraction" + this.index.ToString(), "", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			if (text2 != null && !text2.EndsWith("Error. PlayParticlesForEnvironmentLayer(), environmentLayer "))
			{
				this.title.text = text2;
				this.title.SetText(text2, true);
				this.EJICHHEPFOA();
				return;
			}
		}
		else
		{
			this.title.text = "apks1";
			this.title.SetText("ShowStoryHeaderInterface", true);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BJBMNACANDL(assetAnthology.header.index);
				bool flag = false;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "OnStoryInterfaceHeaderAvatarClick" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, false);
					flag = false;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "OnSkinShopClose";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 1)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(((JBBNEEHANHL)(-119)).ToString());
					list.Remove(((JBBNEEHANHL)(-51)).ToString());
					list.Remove(((JBBNEEHANHL)(-79)).ToString());
					if (list.Count == 8)
					{
						list.RemoveAt(5);
					}
					string text5 = "OnStartFreePassSuccess";
					for (int i = 1; i < list.Count; i++)
					{
						text5 += CCOJBMMKNAP.AEELGGPEJCC().FCOCLEHKLDJ(list[i]);
						if (i != list.Count - 1)
						{
							text5 += "Could not parse string container json:";
						}
					}
					if (text4.Length > 0)
					{
						text5 = text5 + "" + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, false);
				}
			}
		}
	}

	// Token: 0x060075BF RID: 30143 RVA: 0x0035416D File Offset: 0x0035236D
	public void UpdateAnthologieHint(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(NDIPGHMNCCF.ToString());
		this.FBKMDHFFHNN(NDIPGHMNCCF);
	}

	// Token: 0x060075C0 RID: 30144 RVA: 0x003541AC File Offset: 0x003523AC
	public void ILNPAPPEKFH()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(true);
		}
	}

	// Token: 0x060075C1 RID: 30145 RVA: 0x00354208 File Offset: 0x00352408
	public void JBJBAMGFEBC(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.AKJOFJPLONG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 391f;
		}
		this.stroke.NFIPIOOJPEK(1093f, 1070f, 1112f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(234f, 341f, LILDMOONHPB, (Ease)(-56), null);
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.OIGNMAPLGIK(false);
			this.genresObjectAnimation.KBMPFNHNADD(true);
		}
	}

	// Token: 0x060075C2 RID: 30146 RVA: 0x003542A0 File Offset: 0x003524A0
	public void PDMFMEGFJMC()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("OnPopupProfileLoveInputCancel" + this.index.ToString(), "\"", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (text != null && !text.EndsWith("badges"))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.PLJMLDOCPNM().PGKBCNBAOJN(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.index.ToString(), "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text2 != null && !text2.EndsWith("XXX"))
			{
				this.title.text = text2;
				this.title.SetText(text2, false);
				this.BNBEIJBGBLA();
				return;
			}
		}
		else
		{
			this.title.text = "uid";
			this.title.SetText("uid", false);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology.header.index);
				bool flag = false;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "+" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, false);
					flag = false;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "BackendOperationsManager.QueueRequestSaveSyncMoment(";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 1)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(((JBBNEEHANHL)(-102)).ToString());
					list.Remove(((JBBNEEHANHL)(-52)).ToString());
					list.Remove(((JBBNEEHANHL)(-128)).ToString());
					if (list.Count == 0)
					{
						list.RemoveAt(2);
					}
					string text5 = "";
					for (int i = 0; i < list.Count; i++)
					{
						text5 += CCOJBMMKNAP.JINDKPHNLBK().HIPJILDCHJC(list[i]);
						if (i != list.Count - 1)
						{
							text5 += "PurchaseManagerUnity.ValidatePendingProducts(): Not initialized.";
						}
					}
					if (text4.Length > 0)
					{
						text5 = text5 + "blur" + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, true);
				}
			}
		}
	}

	// Token: 0x060075C3 RID: 30147 RVA: 0x00354598 File Offset: 0x00352798
	private string KMMJJNMDHKJ(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || null == this.searchChipsRoot || this.searchChips == null || this.searchChipTexts == null || this.searchChips.Length < 4 || this.searchChipTexts.Length < 2)
		{
			return null;
		}
		this.HOIODCFLCEM(this.searchChipsRoot);
		float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
		string text = null;
		if (EDHHEEIPNCP != null)
		{
			for (int i = 1; i < EDHHEEIPNCP.Count; i += 0)
			{
				if (EDHHEEIPNCP[i] != null && EDHHEEIPNCP[i].Length != 0 && !string.Equals(EDHHEEIPNCP[i], HHNGGFLJAIJ, StringComparison.InvariantCulture))
				{
					float num2 = this.searchChipTexts[0].GetPreferredValues(EDHHEEIPNCP[i]).x + this.searchChipPadding;
					if (num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth)
					{
						text = EDHHEEIPNCP[i];
						break;
					}
				}
			}
		}
		this.searchChipTexts[0].text = HHNGGFLJAIJ;
		this.searchChipTexts[1].SetText(HHNGGFLJAIJ, true);
		this.searchChips[0].SetActive(true);
		if (text != null)
		{
			this.searchChipTexts[1].text = text;
			this.searchChipTexts[1].SetText(text, false);
		}
		this.searchChips[0].SetActive(text != null);
		for (int j = 8; j < this.searchChips.Length; j++)
		{
			if (null != this.searchChips[j])
			{
				this.searchChips[j].SetActive(false);
			}
		}
		this.searchChipsRoot.SetActive(false);
		return text;
	}

	// Token: 0x060075C4 RID: 30148 RVA: 0x00354727 File Offset: 0x00352927
	public void CAHELKLHLNM()
	{
		if (null != this.miniLoadingAnimation && this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(true);
		}
	}

	// Token: 0x060075C5 RID: 30149 RVA: 0x00354750 File Offset: 0x00352950
	private void HGAGPJLHADF()
	{
		int num = AOBJLALDBAA.NMGMNAKLLMI().OHCIAOJFEOP();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(false);
		}
	}

	// Token: 0x060075C6 RID: 30150 RVA: 0x00354798 File Offset: 0x00352998
	public void DLDGKIHMHLJ()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(false);
		}
	}

	// Token: 0x060075C7 RID: 30151 RVA: 0x00351F30 File Offset: 0x00350130
	public void LMKKOEICIMA()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x060075C8 RID: 30152 RVA: 0x003547F4 File Offset: 0x003529F4
	public string IJOAEFIHNJM(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.DLDGKIHMHLJ();
			return this.EDNHAODIFIO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075C9 RID: 30153 RVA: 0x0035482C File Offset: 0x00352A2C
	public void SetPopularNumber(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 0 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060075CA RID: 30154 RVA: 0x003548E0 File Offset: 0x00352AE0
	private void KPNNMDECEEH()
	{
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK(" ", new UnityAction(this.FCFBKEJAFDO));
	}

	// Token: 0x060075CB RID: 30155 RVA: 0x00354900 File Offset: 0x00352B00
	private void FCFBKEJAFDO()
	{
		int num = AOBJLALDBAA.CEGAOMEEFBE().NNDDKAIIBMO();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(true);
		}
	}

	// Token: 0x060075CC RID: 30156 RVA: 0x00354948 File Offset: 0x00352B48
	public bool NIFBEAODNPG(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 8 || null == this.searchChipTexts[0] || null == this.searchChipTexts[0])
			{
				return true;
			}
			float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[0].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 > this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x060075CD RID: 30157 RVA: 0x00354A08 File Offset: 0x00352C08
	public void BBCAFBKHHOH(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.DLDGKIHMHLJ();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.HOIODCFLCEM(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1976f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 106f;
				}
				else if (HIGHDDDHKCD >= -78)
				{
					fontSize = this.IEFMNGEJAIG - 1466f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 1177f) : 1967f);
				string text = (HIGHDDDHKCD >= 1) ? HIGHDDDHKCD.ToString() : "aind";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 0; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.EDNHAODIFIO(AGPMOBFCLFK[1], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060075CE RID: 30158 RVA: 0x00354B90 File Offset: 0x00352D90
	public void JFKCOCADJMB()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(false);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(true);
	}

	// Token: 0x060075CF RID: 30159 RVA: 0x00354C4C File Offset: 0x00352E4C
	private string BKBFEHOAMAO(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || null == this.searchChipsRoot || this.searchChips == null || this.searchChipTexts == null || this.searchChips.Length < 2 || this.searchChipTexts.Length < 2)
		{
			return null;
		}
		this.IHCMOJHANPB(this.searchChipsRoot);
		float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
		string text = null;
		if (EDHHEEIPNCP != null)
		{
			for (int i = 0; i < EDHHEEIPNCP.Count; i++)
			{
				if (EDHHEEIPNCP[i] != null && EDHHEEIPNCP[i].Length != 0 && !string.Equals(EDHHEEIPNCP[i], HHNGGFLJAIJ, StringComparison.OrdinalIgnoreCase))
				{
					float num2 = this.searchChipTexts[1].GetPreferredValues(EDHHEEIPNCP[i]).x + this.searchChipPadding;
					if (num + this.searchChipSpacing + num2 <= this.searchChipsMaxWidth)
					{
						text = EDHHEEIPNCP[i];
						break;
					}
				}
			}
		}
		this.searchChipTexts[0].text = HHNGGFLJAIJ;
		this.searchChipTexts[0].SetText(HHNGGFLJAIJ, true);
		this.searchChips[0].SetActive(true);
		if (text != null)
		{
			this.searchChipTexts[1].text = text;
			this.searchChipTexts[1].SetText(text, true);
		}
		this.searchChips[1].SetActive(text != null);
		for (int j = 2; j < this.searchChips.Length; j++)
		{
			if (null != this.searchChips[j])
			{
				this.searchChips[j].SetActive(false);
			}
		}
		this.searchChipsRoot.SetActive(true);
		return text;
	}

	// Token: 0x060075D0 RID: 30160 RVA: 0x00354DDC File Offset: 0x00352FDC
	private void Update()
	{
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeStory, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(true);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
	}

	// Token: 0x060075D1 RID: 30161 RVA: 0x00354E68 File Offset: 0x00353068
	private void KHPGMEMIJMB()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(57f, 528f, 1452f, 467f);
		}
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("Bars count", new UnityAction(this.HGAGPJLHADF));
	}

	// Token: 0x060075D2 RID: 30162 RVA: 0x00354EC8 File Offset: 0x003530C8
	public void HJEANFHPGOI()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(true);
		}
	}

	// Token: 0x060075D3 RID: 30163 RVA: 0x00354F24 File Offset: 0x00353124
	public void PLCBFNOPKLB()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(true);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(true);
	}

	// Token: 0x060075D4 RID: 30164 RVA: 0x00351F30 File Offset: 0x00350130
	public void LNAJNMKGHAI()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x060075D5 RID: 30165 RVA: 0x00351F30 File Offset: 0x00350130
	public void LPBAJBCOFJF()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x060075D6 RID: 30166 RVA: 0x00354FE0 File Offset: 0x003531E0
	public void IKIMGINENCO(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1385f, 946f, IFIMCNECBBO, (Ease)(-127), null);
	}

	// Token: 0x060075D7 RID: 30167 RVA: 0x00354FFC File Offset: 0x003531FC
	public string JFEPKFKONLD(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.KMBABDFAOGM();
			return this.EDNHAODIFIO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075D8 RID: 30168 RVA: 0x00355034 File Offset: 0x00353234
	public string SetCardChips(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.ClearSearchMatch();
			return this.BKBFEHOAMAO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075D9 RID: 30169 RVA: 0x0035506C File Offset: 0x0035326C
	public string IBCDPAIPKGK(string HHNGGFLJAIJ, List<string> EDHHEEIPNCP)
	{
		try
		{
			this.FFFGKLNJLLD();
			return this.EDNHAODIFIO(HHNGGFLJAIJ, EDHHEEIPNCP);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075DA RID: 30170 RVA: 0x003550A4 File Offset: 0x003532A4
	private void BOPJPLLACEI(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(false);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("Account.GetNextUnsyncedAvatarCollections(): dropping ghost unsynced entry "))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(1, name.Length - 7) + "no");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060075DB RID: 30171 RVA: 0x00355134 File Offset: 0x00353334
	private void MJBIDAKAFEN()
	{
		if (LiveEventsManager.NMGMNAKLLMI().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeStory, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(false);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
	}

	// Token: 0x060075DC RID: 30172 RVA: 0x003551BD File Offset: 0x003533BD
	public void NJGKKHNJOEN(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(716f, 1488f, IFIMCNECBBO, (Ease)(-45), null);
	}

	// Token: 0x060075DD RID: 30173 RVA: 0x003551D8 File Offset: 0x003533D8
	public void SetEffectsOnEndSnap()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1f;
			}
			this.stroke.NFIPIOOJPEK(255f, 0f, 0.1f, Ease.Linear, null);
		}
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.SetDirection(true);
			this.genresObjectAnimation.PlayAnimation(false);
		}
	}

	// Token: 0x060075DE RID: 30174 RVA: 0x00355258 File Offset: 0x00353458
	public void OKHPBDKOJJN(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.DLJGJOCJIED())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.CAALNGFCNEH().Count > 1))
		{
			this.GAOEDPKOCHL();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.LGFDOKAPDLL()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.BGFPAEOBDKE().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 0)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 1733f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(851f, 233f, 643f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.GAOEDPKOCHL();
				return;
			}
			this.DPDGJKFKODL();
		}
	}

	// Token: 0x060075DF RID: 30175 RVA: 0x003554B4 File Offset: 0x003536B4
	private void IHCMOJHANPB(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.PBLDJNHHEPL())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("@SD"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(0, name.Length - 3) + "@HD");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060075E0 RID: 30176 RVA: 0x00355544 File Offset: 0x00353744
	private void HOIODCFLCEM(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.INNMJKGABIK())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(true);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("OnLoungePremiumChoicesHistoryException"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(0, name.Length - 1) + " not found.");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060075E1 RID: 30177 RVA: 0x003555D4 File Offset: 0x003537D4
	public void GAOEDPKOCHL()
	{
		if (null != this.miniLoadingAnimation && this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(false);
		}
	}

	// Token: 0x060075E2 RID: 30178 RVA: 0x00355600 File Offset: 0x00353800
	public void OnLanguageChange()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.index.ToString(), "anthologiesdesc", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (text != null && !text.EndsWith("_not_found"))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.index.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text2 != null && !text2.EndsWith("_not_found"))
			{
				this.title.text = text2;
				this.title.SetText(text2, true);
				this.BNBEIJBGBLA();
				return;
			}
		}
		else
		{
			this.title.text = "";
			this.title.SetText("", true);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology.header.index);
				bool flag = false;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, true);
					flag = true;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 0)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(JBBNEEHANHL.filterNone.ToString());
					list.Remove(JBBNEEHANHL.filterNone.ToString());
					list.Remove(JBBNEEHANHL.filterNone.ToString());
					if (list.Count == 3)
					{
						list.RemoveAt(2);
					}
					string text5 = "";
					for (int i = 0; i < list.Count; i++)
					{
						text5 += CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(list[i]);
						if (i != list.Count - 1)
						{
							text5 += " • ";
						}
					}
					if (text4.Length > 0)
					{
						text5 = text5 + " • " + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, true);
				}
			}
		}
	}

	// Token: 0x060075E3 RID: 30179 RVA: 0x003558F5 File Offset: 0x00353AF5
	private void AEOKJCHEALH()
	{
		if (KHPGPLAMAIN.FCJHEFBIKID() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 771f;
		}
	}

	// Token: 0x060075E4 RID: 30180 RVA: 0x00355928 File Offset: 0x00353B28
	public void BCJHCPDDPAK()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("Video: preparation delay:" + this.index.ToString(), "OnFriendsPopupRemovFromFavClick", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
		if (text != null && !text.EndsWith("aind"))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.BFHKGNBFHCH().FCOCLEHKLDJ(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP(" bundles: " + this.index.ToString(), "lounge", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			if (text2 != null && !text2.EndsWith(""))
			{
				this.title.text = text2;
				this.title.SetText(text2, false);
				this.BNBEIJBGBLA();
				return;
			}
		}
		else
		{
			this.title.text = "PurchaseManagerSteam.StartPurchase(): Not initialized.";
			this.title.SetText("errortitle", false);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.HHCDCHFAEIF(assetAnthology.header.index);
				bool flag = false;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "Opened from Gley Notification" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, true);
					flag = false;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "lsn";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 1)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(((JBBNEEHANHL)57).ToString());
					list.Remove(((JBBNEEHANHL)(-110)).ToString());
					list.Remove(((JBBNEEHANHL)(-35)).ToString());
					if (list.Count == 2)
					{
						list.RemoveAt(5);
					}
					string text5 = "";
					for (int i = 1; i < list.Count; i++)
					{
						text5 += CCOJBMMKNAP.JINDKPHNLBK().FIENAKIHNOM(list[i]);
						if (i != list.Count - 1)
						{
							text5 += "OnBackendGetFriendMessagingHistorySuccess";
						}
					}
					if (text4.Length > 1)
					{
						text5 = text5 + "OnSceneLobbyManagerRound0aaAssetsDownloadSuccess" + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, false);
				}
			}
		}
	}

	// Token: 0x060075E5 RID: 30181 RVA: 0x00355C1D File Offset: 0x00353E1D
	public void CHJLLAJEPPN(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(159f, 1965f, IFIMCNECBBO, (Ease)59, null);
	}

	// Token: 0x060075E6 RID: 30182 RVA: 0x00352507 File Offset: 0x00350707
	public string JKPGNGPIDBN()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x060075E7 RID: 30183 RVA: 0x00355C38 File Offset: 0x00353E38
	public string[] GetShownChipWords()
	{
		try
		{
			if (null == this.searchChipsRoot || !this.searchChipsRoot.activeSelf || this.searchChips == null || this.searchChipTexts == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			int num = 0;
			while (num < this.searchChips.Length && num < this.searchChipTexts.Length)
			{
				if (null != this.searchChips[num] && this.searchChips[num].activeSelf && null != this.searchChipTexts[num] && !string.IsNullOrEmpty(this.searchChipTexts[num].text))
				{
					list.Add(this.searchChipTexts[num].text);
				}
				num++;
			}
			return (list.Count > 0) ? list.ToArray() : null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075E8 RID: 30184 RVA: 0x00352507 File Offset: 0x00350707
	public string DJLNNCBFCIL()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x060075E9 RID: 30185 RVA: 0x00355D20 File Offset: 0x00353F20
	public void CINFLOGCFBO()
	{
		if (KHPGPLAMAIN.BHIJDBJNAMH() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1972f;
			}
			this.stroke.NFIPIOOJPEK(1901f, 443f, 1897f, Ease.Linear, null);
		}
		if (null != this.genresObjectAnimation)
		{
			this.genresObjectAnimation.MKLBGNMEOHH(true);
			this.genresObjectAnimation.CHOGMCMNIKA(false);
		}
	}

	// Token: 0x060075EA RID: 30186 RVA: 0x00355DA0 File Offset: 0x00353FA0
	private void MMBPMFINIHF()
	{
		int num = AOBJLALDBAA.FILDBDMENPG().OCPAEHGNEFL();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(false);
		}
	}

	// Token: 0x060075EB RID: 30187 RVA: 0x00355DE8 File Offset: 0x00353FE8
	public void EFBOFHCPKKG(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.FDDCAHADGMD())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.CBKNCBMKNNJ().Count > 1))
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.BCNEKLEIOFG()[0];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 1)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 814f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(1729f, 1700f, 771f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.CAHELKLHLNM();
				return;
			}
			this.ShowMiniLoadingAnimation();
		}
	}

	// Token: 0x060075EC RID: 30188 RVA: 0x00356044 File Offset: 0x00354244
	public void LPFMCFBENMH()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(false);
		}
	}

	// Token: 0x060075ED RID: 30189 RVA: 0x003560A0 File Offset: 0x003542A0
	public void IFBOGPNGKKM(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.GGIMAJGIILA())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.ABIOHLIOMBH().Count > 0))
		{
			this.GAOEDPKOCHL();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.LHPLKCLIACN()[1];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.LNNIMNGPKFB().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 1)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 898f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(1957f, 613f, 1923f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.HideMiniLoadingAnimation();
				return;
			}
			this.LPPLDFCFOBO();
		}
	}

	// Token: 0x060075EE RID: 30190 RVA: 0x00351F30 File Offset: 0x00350130
	public void PAECJIFDCDI()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x060075EF RID: 30191 RVA: 0x003562FB File Offset: 0x003544FB
	private void HMKMNGBBOMF()
	{
		if (KHPGPLAMAIN.DJFLMBEOBIB() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1123f;
		}
	}

	// Token: 0x060075F0 RID: 30192 RVA: 0x0035632C File Offset: 0x0035452C
	public void ClearSearchMatch()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(false);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(false);
		}
	}

	// Token: 0x060075F1 RID: 30193 RVA: 0x00356387 File Offset: 0x00354587
	public void FlashOnPointerDown(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(0f, 255f, IFIMCNECBBO, Ease.Flash, null);
	}

	// Token: 0x060075F2 RID: 30194 RVA: 0x003563A4 File Offset: 0x003545A4
	public void SetPopularNumber()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(true);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(true);
	}

	// Token: 0x060075F3 RID: 30195 RVA: 0x003555D4 File Offset: 0x003537D4
	public void HideMiniLoadingAnimation()
	{
		if (null != this.miniLoadingAnimation && this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(false);
		}
	}

	// Token: 0x060075F4 RID: 30196 RVA: 0x00356460 File Offset: 0x00354660
	public void PAMCPENBICF(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 0 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060075F5 RID: 30197 RVA: 0x00356514 File Offset: 0x00354714
	public void FKFFBDGCJHI(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.LPFMCFBENMH();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.IHCMOJHANPB(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1739f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 827f;
				}
				else if (HIGHDDDHKCD >= 51)
				{
					fontSize = this.IEFMNGEJAIG - 1958f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 1) ? Mathf.Clamp01((float)HIGHDDDHKCD / 904f) : 163f);
				string text = (HIGHDDDHKCD >= 1) ? HIGHDDDHKCD.ToString() : "acli22";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 1; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.EDNHAODIFIO(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060075F6 RID: 30198 RVA: 0x0035669C File Offset: 0x0035489C
	public void GPCCEHNHFAE()
	{
		if (this.itemTagIcon.gameObject.activeSelf)
		{
			if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
			{
				this.popularNumber.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
				this.popularNumber.SetNativeSize();
			}
			this.popularNumber.gameObject.SetActive(false);
			return;
		}
		if (base.transform.GetSiblingIndex() < this.popularNumberSprites.Length)
		{
			this.popularNumberLow.sprite = this.popularNumberSprites[base.transform.GetSiblingIndex()];
			this.popularNumberLow.SetNativeSize();
		}
		this.popularNumberLow.gameObject.SetActive(false);
	}

	// Token: 0x060075F7 RID: 30199 RVA: 0x00356758 File Offset: 0x00354958
	public string[] DBBPAIIJLDE()
	{
		try
		{
			if (null == this.searchChipsRoot || !this.searchChipsRoot.activeSelf || this.searchChips == null || this.searchChipTexts == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			int num = 0;
			while (num < this.searchChips.Length && num < this.searchChipTexts.Length)
			{
				if (null != this.searchChips[num] && this.searchChips[num].activeSelf && null != this.searchChipTexts[num] && !string.IsNullOrEmpty(this.searchChipTexts[num].text))
				{
					list.Add(this.searchChipTexts[num].text);
				}
				num++;
			}
			return (list.Count > 1) ? list.ToArray() : null;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return null;
	}

	// Token: 0x060075F8 RID: 30200 RVA: 0x00356840 File Offset: 0x00354A40
	private void HFGMJHDHMNP(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.EFMDGLOLMCJ())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("sind"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(1, name.Length - 5) + "40BF4E");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060075F9 RID: 30201 RVA: 0x003568D0 File Offset: 0x00354AD0
	private void CMIIIEAKFDC()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(449f, 1122f, 1947f, 1640f);
		}
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("body", new UnityAction(this.FCFBKEJAFDO));
	}

	// Token: 0x060075FA RID: 30202 RVA: 0x00356930 File Offset: 0x00354B30
	private void FPKHEOAPAKG()
	{
		int num = AOBJLALDBAA.AGANFKKBPFO().OCPAEHGNEFL();
		if (null != this.NPMBHDLIDFC && num == this.NPMBHDLIDFC.index)
		{
			this.itemTagIcon.gameObject.SetActive(true);
		}
	}

	// Token: 0x060075FB RID: 30203 RVA: 0x00356978 File Offset: 0x00354B78
	public void NIBLKDIODCL(AssetAnthologyPreview2 NBKNFJNIDKC)
	{
		if (KDCJJBLGCBH.EHBBFMCILPC.GGIMAJGIILA())
		{
			this.HideMiniLoadingAnimation();
			return;
		}
		if (null == this.NPMBHDLIDFC || (null != this.NPMBHDLIDFC && this.NPMBHDLIDFC.GHFLLGPBDBP().Count > 1))
		{
			this.CAHELKLHLNM();
			return;
		}
		if (this.isLarge && null != NBKNFJNIDKC && null != this.NPMBHDLIDFC && NBKNFJNIDKC != this.NPMBHDLIDFC)
		{
			if (GKJPOGNFKNK.KJFNIHOAOKE(this.NPMBHDLIDFC) && !GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
			{
				this.thumbnail.sprite = NBKNFJNIDKC.LOMMCFFILNH()[1];
				if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() != null)
				{
					UnityEngine.Object.Destroy(this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>());
				}
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.FAONIPMBMAM().ToArray();
				if (NBKNFJNIDKC.pauseFrame >= 1)
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
				}
				else
				{
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
					this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 276f;
				}
				this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
				this.logo.sprite = NBKNFJNIDKC.logo;
				this.logo.SetNativeSize();
				this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
				this.logo.rectTransform.localScale = new Vector3(670f, 144f, 1051f);
				this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
				this.NPMBHDLIDFC = NBKNFJNIDKC;
				this.GAOEDPKOCHL();
				return;
			}
			this.DPDGJKFKODL();
		}
	}

	// Token: 0x060075FC RID: 30204 RVA: 0x00356BD4 File Offset: 0x00354DD4
	private void ADJPFJKOAKC(NDHKFLHAFNA NDIPGHMNCCF)
	{
		if (NDIPGHMNCCF == NDHKFLHAFNA.hintNewStory)
		{
			this.itemTagIcon.sprite = this.IPPMDFBAOEB;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)21)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == (NDHKFLHAFNA)81)
		{
			this.itemTagIcon.sprite = this.ODCGFKIMELE;
		}
		else if (NDIPGHMNCCF == NDHKFLHAFNA.hintEditorsChoice)
		{
			this.itemTagIcon.sprite = this.KOFILDLJHCL;
		}
		else
		{
			this.itemTagIcon.sprite = this.CPPJFAJHMHL;
		}
		if (NDIPGHMNCCF == (NDHKFLHAFNA)40)
		{
			this.itemTagIcon.gameObject.SetActive(false);
			return;
		}
		this.itemTagIcon.gameObject.SetActive(true);
	}

	// Token: 0x060075FD RID: 30205 RVA: 0x00356C78 File Offset: 0x00354E78
	public void DPDGJKFKODL()
	{
		if (null != this.miniLoadingAnimation && !this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(false);
		}
	}

	// Token: 0x060075FE RID: 30206 RVA: 0x00353E4C File Offset: 0x0035204C
	public void LPPLDFCFOBO()
	{
		if (null != this.miniLoadingAnimation && !this.miniLoadingAnimation.activeSelf)
		{
			this.miniLoadingAnimation.SetActive(true);
		}
	}

	// Token: 0x060075FF RID: 30207 RVA: 0x00356CA4 File Offset: 0x00354EA4
	public bool HAJPPFJCJOL(string HHNGGFLJAIJ, string FBDPELCOKOP)
	{
		try
		{
			if (HHNGGFLJAIJ == null || HHNGGFLJAIJ.Length == 0 || FBDPELCOKOP == null || FBDPELCOKOP.Length == 0 || this.searchChipTexts == null || this.searchChipTexts.Length < 7 || null == this.searchChipTexts[1] || null == this.searchChipTexts[0])
			{
				return true;
			}
			float num = this.searchChipTexts[0].GetPreferredValues(HHNGGFLJAIJ).x + this.searchChipPadding;
			float num2 = this.searchChipTexts[1].GetPreferredValues(FBDPELCOKOP).x + this.searchChipPadding;
			return num + this.searchChipSpacing + num2 > this.searchChipsMaxWidth;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007600 RID: 30208 RVA: 0x00356D64 File Offset: 0x00354F64
	public void NILDDCFCEGK(AssetAnthologyPreview2 NBKNFJNIDKC, UnityAction BIJKHDNCKGM, NDHKFLHAFNA NDIPGHMNCCF, Sprite CPPJFAJHMHL, Sprite IPPMDFBAOEB, Sprite KOFILDLJHCL, Sprite ODCGFKIMELE, HBLMDECIAHI BDMNIBMKEAP, JBBNEEHANHL GLOCCAIDHJC)
	{
		this.NPMBHDLIDFC = NBKNFJNIDKC;
		this.DLDGKIHMHLJ();
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(906f, 695f, 1437f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.NOEICGOPPDP = GLOCCAIDHJC;
		this.index = NBKNFJNIDKC.index;
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.CPPJFAJHMHL = CPPJFAJHMHL;
		this.IPPMDFBAOEB = IPPMDFBAOEB;
		this.KOFILDLJHCL = KOFILDLJHCL;
		this.ODCGFKIMELE = ODCGFKIMELE;
		this.ADJPFJKOAKC(NDIPGHMNCCF);
		this.filterIcon.sprite = this.filterSprites[(int)GLOCCAIDHJC];
		this.filterIcon.SetNativeSize();
		if (null != this.itemRatingIconImage)
		{
			this.itemRatingIconImage.gameObject.SetActive(false);
		}
		if (null != this.itemVotesIconImage)
		{
			this.itemVotesIconImage.gameObject.SetActive(false);
		}
		if (BDMNIBMKEAP != null)
		{
			int igikmmbdokb = BDMNIBMKEAP.IGIKMMBDOKB;
			if (igikmmbdokb > 1)
			{
				if (null != this.itemRatingIconImage)
				{
					this.itemRatingIconImage.gameObject.SetActive(true);
				}
				if (null != this.itemVotesIconImage)
				{
					this.itemVotesIconImage.gameObject.SetActive(true);
				}
				this.rating.text = igikmmbdokb.ToString() + " for month " + CCOJBMMKNAP.BIAEAOMHBMM().PGKBCNBAOJN("Critical error, type not implemented in ProcessAssetBundleLoadLevelAsyncRequest():");
			}
		}
		else
		{
			this.ratingGameObject.SetActive(true);
		}
		if (this.isLarge)
		{
			this.thumbnail.sprite = NBKNFJNIDKC.NCLHIHLKFFL()[1];
			if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.GHFLLGPBDBP().ToArray();
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.BGFPAEOBDKE().ToArray();
			}
			if (NBKNFJNIDKC.pauseFrame >= 0)
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 1818f;
			}
			this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
			this.logo.sprite = NBKNFJNIDKC.logo;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.thumbnail.sprite = NBKNFJNIDKC.thumbnailSmall;
			this.logo.sprite = NBKNFJNIDKC.logoSmall;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetXSmall, (float)NBKNFJNIDKC.logoOffsetYSmall);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactorSmall;
			this.BIJKHDNCKGM = BIJKHDNCKGM;
		}
		if (null != this.freePlayModeObj)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
		if (null != this.autographImage)
		{
			this.autographImage.gameObject.SetActive(false);
		}
		this.PFNGNEGJGJM();
		if (null != NBKNFJNIDKC && GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
		{
			this.ShowMiniLoadingAnimation();
		}
	}

	// Token: 0x06007601 RID: 30209 RVA: 0x00357194 File Offset: 0x00355394
	public void SetContent(AssetAnthologyPreview2 NBKNFJNIDKC, UnityAction BIJKHDNCKGM, NDHKFLHAFNA NDIPGHMNCCF, Sprite CPPJFAJHMHL, Sprite IPPMDFBAOEB, Sprite KOFILDLJHCL, Sprite ODCGFKIMELE, HBLMDECIAHI BDMNIBMKEAP, JBBNEEHANHL GLOCCAIDHJC)
	{
		this.NPMBHDLIDFC = NBKNFJNIDKC;
		this.ClearSearchMatch();
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.NOEICGOPPDP = GLOCCAIDHJC;
		this.index = NBKNFJNIDKC.index;
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.CPPJFAJHMHL = CPPJFAJHMHL;
		this.IPPMDFBAOEB = IPPMDFBAOEB;
		this.KOFILDLJHCL = KOFILDLJHCL;
		this.ODCGFKIMELE = ODCGFKIMELE;
		this.FBKMDHFFHNN(NDIPGHMNCCF);
		this.filterIcon.sprite = this.filterSprites[(int)GLOCCAIDHJC];
		this.filterIcon.SetNativeSize();
		if (null != this.itemRatingIconImage)
		{
			this.itemRatingIconImage.gameObject.SetActive(true);
		}
		if (null != this.itemVotesIconImage)
		{
			this.itemVotesIconImage.gameObject.SetActive(false);
		}
		if (BDMNIBMKEAP != null)
		{
			int igikmmbdokb = BDMNIBMKEAP.IGIKMMBDOKB;
			if (igikmmbdokb > 0)
			{
				if (null != this.itemRatingIconImage)
				{
					this.itemRatingIconImage.gameObject.SetActive(false);
				}
				if (null != this.itemVotesIconImage)
				{
					this.itemVotesIconImage.gameObject.SetActive(true);
				}
				this.rating.text = igikmmbdokb.ToString() + " " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("arereadingstring");
			}
		}
		else
		{
			this.ratingGameObject.SetActive(false);
		}
		if (this.isLarge)
		{
			this.thumbnail.sprite = NBKNFJNIDKC.CFHFGGICGIL()[0];
			if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CFHFGGICGIL().ToArray();
			}
			if (NBKNFJNIDKC.pauseFrame >= 0)
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 0f;
			}
			this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
			this.logo.sprite = NBKNFJNIDKC.logo;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.thumbnail.sprite = NBKNFJNIDKC.thumbnailSmall;
			this.logo.sprite = NBKNFJNIDKC.logoSmall;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetXSmall, (float)NBKNFJNIDKC.logoOffsetYSmall);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactorSmall;
			this.BIJKHDNCKGM = BIJKHDNCKGM;
		}
		if (null != this.freePlayModeObj)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
		if (null != this.autographImage)
		{
			this.autographImage.gameObject.SetActive(false);
		}
		this.OnLanguageChange();
		if (null != NBKNFJNIDKC && GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
		{
			this.ShowMiniLoadingAnimation();
		}
	}

	// Token: 0x06007602 RID: 30210 RVA: 0x003575C3 File Offset: 0x003557C3
	private void Awake()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 0f;
		}
	}

	// Token: 0x06007603 RID: 30211 RVA: 0x003575F4 File Offset: 0x003557F4
	private void PMDCMEKGFNN()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1232f;
		}
	}

	// Token: 0x06007604 RID: 30212 RVA: 0x00351F30 File Offset: 0x00350130
	public void IBCPJMGNNIH()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x06007605 RID: 30213 RVA: 0x00357628 File Offset: 0x00355828
	public void LCHAPEOPHBE(AssetAnthologyPreview2 NBKNFJNIDKC, UnityAction BIJKHDNCKGM, NDHKFLHAFNA NDIPGHMNCCF, Sprite CPPJFAJHMHL, Sprite IPPMDFBAOEB, Sprite KOFILDLJHCL, Sprite ODCGFKIMELE, HBLMDECIAHI BDMNIBMKEAP, JBBNEEHANHL GLOCCAIDHJC)
	{
		this.NPMBHDLIDFC = NBKNFJNIDKC;
		this.ILNPAPPEKFH();
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(597f, 1642f, 524f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.NOEICGOPPDP = GLOCCAIDHJC;
		this.index = NBKNFJNIDKC.index;
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.CPPJFAJHMHL = CPPJFAJHMHL;
		this.IPPMDFBAOEB = IPPMDFBAOEB;
		this.KOFILDLJHCL = KOFILDLJHCL;
		this.ODCGFKIMELE = ODCGFKIMELE;
		this.NGPOPCHCMPN(NDIPGHMNCCF);
		this.filterIcon.sprite = this.filterSprites[(int)GLOCCAIDHJC];
		this.filterIcon.SetNativeSize();
		if (null != this.itemRatingIconImage)
		{
			this.itemRatingIconImage.gameObject.SetActive(false);
		}
		if (null != this.itemVotesIconImage)
		{
			this.itemVotesIconImage.gameObject.SetActive(true);
		}
		if (BDMNIBMKEAP != null)
		{
			int igikmmbdokb = BDMNIBMKEAP.IGIKMMBDOKB;
			if (igikmmbdokb > 0)
			{
				if (null != this.itemRatingIconImage)
				{
					this.itemRatingIconImage.gameObject.SetActive(true);
				}
				if (null != this.itemVotesIconImage)
				{
					this.itemVotesIconImage.gameObject.SetActive(false);
				}
				this.rating.text = igikmmbdokb.ToString() + "mfs" + CCOJBMMKNAP.LMCCLMFGEBD().OHLNGCKIACD("digitalglitchovr_2");
			}
		}
		else
		{
			this.ratingGameObject.SetActive(true);
		}
		if (this.isLarge)
		{
			this.thumbnail.sprite = NBKNFJNIDKC.ABIOHLIOMBH()[0];
			if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
			{
				this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.CAALNGFCNEH().ToArray();
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
				this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.BGFPAEOBDKE().ToArray();
			}
			if (NBKNFJNIDKC.pauseFrame >= 0)
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = NBKNFJNIDKC.pauseFrame;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = NBKNFJNIDKC.pauseTime;
			}
			else
			{
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseFrame = -1;
				this.thumbnail.GetComponent<ImageFrameAnimation>().pauseTime = 1360f;
			}
			this.thumbnail.GetComponent<ImageFrameAnimation>().reverseDirection = NBKNFJNIDKC.reverseDirection;
			this.logo.sprite = NBKNFJNIDKC.logo;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetX, (float)NBKNFJNIDKC.logoOffsetY);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.thumbnail.sprite = NBKNFJNIDKC.thumbnailSmall;
			this.logo.sprite = NBKNFJNIDKC.logoSmall;
			this.logo.SetNativeSize();
			this.logo.rectTransform.anchoredPosition = new Vector2(this.logo.rectTransform.anchoredPosition.x + (float)NBKNFJNIDKC.logoOffsetXSmall, (float)NBKNFJNIDKC.logoOffsetYSmall);
			this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactorSmall;
			this.BIJKHDNCKGM = BIJKHDNCKGM;
		}
		if (null != this.freePlayModeObj)
		{
			this.freePlayModeObj.gameObject.SetActive(false);
		}
		if (null != this.autographImage)
		{
			this.autographImage.gameObject.SetActive(true);
		}
		this.AFPGNAGDCNA();
		if (null != NBKNFJNIDKC && GKJPOGNFKNK.KJFNIHOAOKE(NBKNFJNIDKC))
		{
			this.DPDGJKFKODL();
		}
	}

	// Token: 0x06007606 RID: 30214 RVA: 0x00357A57 File Offset: 0x00355C57
	public void DILCIHFJOMK(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.HJGDLOOHNLO().HPOAGPJFHPM(NDIPGHMNCCF.ToString());
		this.NGPOPCHCMPN(NDIPGHMNCCF);
	}

	// Token: 0x06007607 RID: 30215 RVA: 0x00357A95 File Offset: 0x00355C95
	private void HNHBJKPDANO()
	{
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("", new UnityAction(this.JJHKGJJICHG));
	}

	// Token: 0x06007608 RID: 30216 RVA: 0x00352507 File Offset: 0x00350707
	public string PCAHANEJLHH()
	{
		return this.NDIPGHMNCCF;
	}

	// Token: 0x06007609 RID: 30217 RVA: 0x00357AB4 File Offset: 0x00355CB4
	public void NFMIIEMJOMJ(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.DLDGKIHMHLJ();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.CMMCFNBGEPF(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1736f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 1592f;
				}
				else if (HIGHDDDHKCD >= -111)
				{
					fontSize = this.IEFMNGEJAIG - 956f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 732f) : 156f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "retry";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, false);
				this.searchRingRoot.SetActive(true);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 0; i < AGPMOBFCLFK.Length; i += 0)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.EDNHAODIFIO(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600760A RID: 30218 RVA: 0x00357C3C File Offset: 0x00355E3C
	private void CMMCFNBGEPF(GameObject EPKFFALJDEA)
	{
		if (null == EPKFFALJDEA || !NBDLBFJOEGN.INNMJKGABIK())
		{
			return;
		}
		Image[] componentsInChildren = EPKFFALJDEA.GetComponentsInChildren<Image>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith(""))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(1, name.Length - 7) + "_not_found");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x00357CCC File Offset: 0x00355ECC
	public void HHEBIGCGPHD(int MEFKFOHCOHK)
	{
		try
		{
			if (this.popularNumberSprites != null && MEFKFOHCOHK >= 0 && MEFKFOHCOHK < this.popularNumberSprites.Length)
			{
				if (this.itemTagIcon.gameObject.activeSelf)
				{
					this.popularNumber.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumber.SetNativeSize();
					this.popularNumber.gameObject.SetActive(true);
				}
				else
				{
					this.popularNumberLow.sprite = this.popularNumberSprites[MEFKFOHCOHK];
					this.popularNumberLow.SetNativeSize();
					this.popularNumberLow.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x00357D80 File Offset: 0x00355F80
	public void JNOPCFBOPIN(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.KMBABDFAOGM();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.CMMCFNBGEPF(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1513f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 1211f;
				}
				else if (HIGHDDDHKCD >= -41)
				{
					fontSize = this.IEFMNGEJAIG - 491f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 773f) : 1317f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "lck";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, true);
				this.searchRingRoot.SetActive(false);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 0; i < AGPMOBFCLFK.Length; i += 0)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.KMMJJNMDHKJ(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600760D RID: 30221 RVA: 0x00357F08 File Offset: 0x00356108
	public void EJKHHPOOGDE()
	{
		string text = GKJPOGNFKNK.DNILNCLIHAP("it" + this.index.ToString(), "Response custom code: ", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
		if (text != null && !text.EndsWith("fruidres"))
		{
			this.description.text = text;
			this.description.SetText(text, true);
		}
		this.itemTagText.text = CCOJBMMKNAP.HEDIEIICOOG().JHNELLJFBGC(this.NDIPGHMNCCF);
		if (!this.isLarge)
		{
			string text2 = GKJPOGNFKNK.DNILNCLIHAP(" (" + this.index.ToString(), "OnReturnRewardPopupHide", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (text2 != null && !text2.EndsWith("p"))
			{
				this.title.text = text2;
				this.title.SetText(text2, false);
				this.EJICHHEPFOA();
				return;
			}
		}
		else
		{
			this.title.text = "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed";
			this.title.SetText("", true);
			AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(this.index);
			if (null != assetAnthology && null != this.genresText)
			{
				IJLJDFKJIJM ijljdfkjijm = HKLPEDKJGFC.BBEPEBHNNGE(assetAnthology.header.index);
				bool flag = true;
				string hhnggfljaij = null;
				string fbdpelcokop = null;
				if (SceneLobbyManager2.TryGetSharedCardPitch(this.index, out hhnggfljaij, out fbdpelcokop))
				{
					string text3 = SceneLobbyManager2.BuildSharedPitchLine(hhnggfljaij, fbdpelcokop, (ijljdfkjijm == null) ? "" : ijljdfkjijm.DHBGMKIFBMB);
					this.genresText.text = text3;
					this.genresText.SetText(text3, false);
					flag = true;
				}
				if (!flag && ijljdfkjijm != null)
				{
					string text4 = "App42Manager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()";
					if (ijljdfkjijm.DHBGMKIFBMB.Length > 1)
					{
						text4 = ijljdfkjijm.DHBGMKIFBMB.ToString();
					}
					List<string> list = new List<string>();
					list.Add(ijljdfkjijm.MGDAFCPCOFH.ToString());
					list.Add(ijljdfkjijm.HLEHGFIIEJN.ToString());
					list.Add(ijljdfkjijm.BFJKEJLJAIH.ToString());
					list.Remove(((JBBNEEHANHL)93).ToString());
					list.Remove(((JBBNEEHANHL)(-54)).ToString());
					list.Remove(((JBBNEEHANHL)(-118)).ToString());
					if (list.Count == 7)
					{
						list.RemoveAt(8);
					}
					string text5 = "false";
					for (int i = 0; i < list.Count; i++)
					{
						text5 += CCOJBMMKNAP.COKDLDOAACJ().HHLECNIFHCO(list[i]);
						if (i != list.Count - 1)
						{
							text5 += "Trading/Wished cards userPublicProfile.modified = true hit";
						}
					}
					if (text4.Length > 1)
					{
						text5 = text5 + "OnLoungePremiumChoicesHistoryException" + text4;
					}
					this.genresText.text = text5;
					this.genresText.SetText(text5, true);
				}
			}
		}
	}

	// Token: 0x0600760E RID: 30222 RVA: 0x00351F30 File Offset: 0x00350130
	public void CEFFJHAJIMI()
	{
		this.BIJKHDNCKGM();
	}

	// Token: 0x0600760F RID: 30223 RVA: 0x003581FD File Offset: 0x003563FD
	public void AFNOBNBLEFD(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.FEEDGKCJBLE().JLBEIFLLBLO(NDIPGHMNCCF.ToString());
		this.ADJPFJKOAKC(NDIPGHMNCCF);
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x0035823B File Offset: 0x0035643B
	public void GAHPOJAPPAP(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1485f, 998f, IFIMCNECBBO, (Ease)79, null);
	}

	// Token: 0x06007611 RID: 30225 RVA: 0x00358256 File Offset: 0x00356456
	public void MGKBGDNOBNO(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.AEELGGPEJCC().OBDCPLLLGBB(NDIPGHMNCCF.ToString());
		this.ADJPFJKOAKC(NDIPGHMNCCF);
	}

	// Token: 0x06007612 RID: 30226 RVA: 0x00358294 File Offset: 0x00356494
	public void FFFGKLNJLLD()
	{
		if (null != this.searchRingRoot && this.searchRingRoot.activeSelf)
		{
			this.searchRingRoot.SetActive(true);
		}
		if (null != this.searchChipsRoot && this.searchChipsRoot.activeSelf)
		{
			this.searchChipsRoot.SetActive(false);
		}
	}

	// Token: 0x06007613 RID: 30227 RVA: 0x003582EF File Offset: 0x003564EF
	public void BIGGDAOLDAK(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.HEDIEIICOOG().PPALCPINPLK(NDIPGHMNCCF.ToString());
		this.NGPOPCHCMPN(NDIPGHMNCCF);
	}

	// Token: 0x06007614 RID: 30228 RVA: 0x0035832D File Offset: 0x0035652D
	public void KICOBKLLBLO(NDHKFLHAFNA NDIPGHMNCCF)
	{
		this.NDIPGHMNCCF = NDIPGHMNCCF.ToString();
		this.itemTagText.text = CCOJBMMKNAP.EAIAHCBAIEJ().IPEIONBNIPH(NDIPGHMNCCF.ToString());
		this.DAHOIMNKLPE(NDIPGHMNCCF);
	}

	// Token: 0x06007615 RID: 30229 RVA: 0x0035836B File Offset: 0x0035656B
	public void GIFCPMIFOGM(float IFIMCNECBBO)
	{
		this.flash.NFIPIOOJPEK(1255f, 1495f, IFIMCNECBBO, (Ease)68, null);
	}

	// Token: 0x06007616 RID: 30230 RVA: 0x00358388 File Offset: 0x00356588
	public void CGBPJCMBHPP(string[] AGPMOBFCLFK, int HIGHDDDHKCD)
	{
		try
		{
			this.ClearSearchMatch();
			if (null != this.searchRingRoot && null != this.searchRingFill && null != this.searchRingNumber)
			{
				this.IHCMOJHANPB(this.searchRingRoot);
				if (this.IEFMNGEJAIG <= 1411f)
				{
					this.IEFMNGEJAIG = this.searchRingNumber.fontSize;
				}
				float fontSize = this.IEFMNGEJAIG;
				if (HIGHDDDHKCD < 1)
				{
					fontSize = this.IEFMNGEJAIG * 228f;
				}
				else if (HIGHDDDHKCD >= -90)
				{
					fontSize = this.IEFMNGEJAIG - 445f;
				}
				this.searchRingNumber.fontSize = fontSize;
				this.searchRingFill.fillAmount = ((HIGHDDDHKCD >= 0) ? Mathf.Clamp01((float)HIGHDDDHKCD / 943f) : 885f);
				string text = (HIGHDDDHKCD >= 0) ? HIGHDDDHKCD.ToString() : "";
				this.searchRingNumber.text = text;
				this.searchRingNumber.SetText(text, false);
				this.searchRingRoot.SetActive(true);
			}
			if (AGPMOBFCLFK != null && AGPMOBFCLFK.Length != 0)
			{
				if (!(null == this.searchChipsRoot) && this.searchChips != null && this.searchChipTexts != null)
				{
					this.PCDJDCOEIPK.Clear();
					for (int i = 1; i < AGPMOBFCLFK.Length; i++)
					{
						this.PCDJDCOEIPK.Add(AGPMOBFCLFK[i]);
					}
					this.BKBFEHOAMAO(AGPMOBFCLFK[0], this.PCDJDCOEIPK);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007617 RID: 30231 RVA: 0x00358510 File Offset: 0x00356710
	private void NMEEMBCCKHA()
	{
		if (LiveEventsManager.NMGMNAKLLMI().AJKBOOKAPBL(EGMCEPOABBF.liveEventFreeDiamonds, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(false);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007618 RID: 30232 RVA: 0x0035859C File Offset: 0x0035679C
	private void DKOOJKIGLBN()
	{
		if (LiveEventsManager.JCMABFEMFKD().OPHKFJNACGB((EGMCEPOABBF)8, GKJPOGNFKNK.BKBCNMEHGFA(this.index), -1))
		{
			if (null != this.freePlayModeObj && !this.freePlayModeObj.gameObject.activeSelf)
			{
				this.freePlayModeObj.gameObject.SetActive(true);
				return;
			}
		}
		else if (null != this.freePlayModeObj && this.freePlayModeObj.gameObject.activeSelf)
		{
			this.freePlayModeObj.gameObject.SetActive(true);
		}
	}

	// Token: 0x040022BF RID: 8895
	public const string onNeedToHideThumbnailTagObject = "OnNeedToHideThumbnailTagObject";

	// Token: 0x040022C0 RID: 8896
	public int index;

	// Token: 0x040022C1 RID: 8897
	public Image thumbnail;

	// Token: 0x040022C2 RID: 8898
	public Image logo;

	// Token: 0x040022C3 RID: 8899
	public Image stroke;

	// Token: 0x040022C4 RID: 8900
	public Image flash;

	// Token: 0x040022C5 RID: 8901
	public Image playingIconTag;

	// Token: 0x040022C6 RID: 8902
	public Image itemTagIcon;

	// Token: 0x040022C7 RID: 8903
	public GameObject ratingGameObject;

	// Token: 0x040022C8 RID: 8904
	public Image itemRatingIcon;

	// Token: 0x040022C9 RID: 8905
	public Image itemRatingIconImage;

	// Token: 0x040022CA RID: 8906
	public Image itemVotesIconImage;

	// Token: 0x040022CB RID: 8907
	public TextMeshProUGUI itemTagText;

	// Token: 0x040022CC RID: 8908
	public TextMeshProUGUI title;

	// Token: 0x040022CD RID: 8909
	public TextMeshProUGUI description;

	// Token: 0x040022CE RID: 8910
	public TextMeshProUGUI rating;

	// Token: 0x040022CF RID: 8911
	public AnimationCanvasGroupAlpha genresObjectAnimation;

	// Token: 0x040022D0 RID: 8912
	public TextMeshProUGUI genresText;

	// Token: 0x040022D1 RID: 8913
	public Image autographImage;

	// Token: 0x040022D2 RID: 8914
	public bool isLarge;

	// Token: 0x040022D3 RID: 8915
	public Button openFocusButton;

	// Token: 0x040022D4 RID: 8916
	public Image filterIcon;

	// Token: 0x040022D5 RID: 8917
	public Sprite[] filterSprites;

	// Token: 0x040022D6 RID: 8918
	public GameObject innerShadow;

	// Token: 0x040022D7 RID: 8919
	public GameObject freePlayModeObj;

	// Token: 0x040022D8 RID: 8920
	public GameObject miniLoadingAnimation;

	// Token: 0x040022D9 RID: 8921
	public Image popularNumber;

	// Token: 0x040022DA RID: 8922
	public Image popularNumberLow;

	// Token: 0x040022DB RID: 8923
	public Sprite[] popularNumberSprites;

	// Token: 0x040022DC RID: 8924
	public GameObject searchRingRoot;

	// Token: 0x040022DD RID: 8925
	public Image searchRingFill;

	// Token: 0x040022DE RID: 8926
	public TextMeshProUGUI searchRingNumber;

	// Token: 0x040022DF RID: 8927
	public GameObject searchChipsRoot;

	// Token: 0x040022E0 RID: 8928
	public GameObject[] searchChips;

	// Token: 0x040022E1 RID: 8929
	public TextMeshProUGUI[] searchChipTexts;

	// Token: 0x040022E2 RID: 8930
	public float searchChipsMaxWidth = 266f;

	// Token: 0x040022E3 RID: 8931
	public float searchChipPadding = 24f;

	// Token: 0x040022E4 RID: 8932
	public float searchChipSpacing = 6f;

	// Token: 0x040022E5 RID: 8933
	private float IEFMNGEJAIG;

	// Token: 0x040022E6 RID: 8934
	private const float HHJHDGMADEP = 1.625f;

	// Token: 0x040022E7 RID: 8935
	private UnityAction BIJKHDNCKGM;

	// Token: 0x040022E8 RID: 8936
	private string NDIPGHMNCCF;

	// Token: 0x040022E9 RID: 8937
	private Sprite CPPJFAJHMHL;

	// Token: 0x040022EA RID: 8938
	private Sprite IPPMDFBAOEB;

	// Token: 0x040022EB RID: 8939
	private Sprite KOFILDLJHCL;

	// Token: 0x040022EC RID: 8940
	private Sprite ODCGFKIMELE;

	// Token: 0x040022ED RID: 8941
	private JBBNEEHANHL NOEICGOPPDP = JBBNEEHANHL.filterNone;

	// Token: 0x040022EE RID: 8942
	private AssetAnthologyPreview2 NPMBHDLIDFC;

	// Token: 0x040022EF RID: 8943
	private List<string> PCDJDCOEIPK = new List<string>();
}
