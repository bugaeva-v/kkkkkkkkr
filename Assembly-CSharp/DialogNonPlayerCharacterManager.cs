using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001ED RID: 493
public class DialogNonPlayerCharacterManager : MonoBehaviour
{
	// Token: 0x06003CF4 RID: 15604 RVA: 0x0019356C File Offset: 0x0019176C
	public void KMDKBPNAKOG(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.MAOBPEFDPBK())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Page;
		this.textTitle.fontSizeMin = 1401f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "did" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003CF5 RID: 15605 RVA: 0x00193639 File Offset: 0x00191839
	public int NAFJCBJAEEL()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00193641 File Offset: 0x00191841
	private bool NCAJIBBKGLJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC(") + is present, creating anthology save for anthology ");
			return true;
		}
		return true;
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x00193658 File Offset: 0x00191858
	public static float GetDisappearAnimationLength()
	{
		return 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x0019366A File Offset: 0x0019186A
	private void HCKLMFNDKBC()
	{
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("sparkles", new UnityAction(this.FELNAMJOMMK));
	}

	// Token: 0x06003CF9 RID: 15609 RVA: 0x00193687 File Offset: 0x00191887
	private void NPEKGGOPGIB()
	{
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("stat3long", new UnityAction(this.AAEANOPPNPC));
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x001936A4 File Offset: 0x001918A4
	public void Initialize(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Truncate;
		this.textTitle.fontSizeMin = 12f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + ": " + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x00193771 File Offset: 0x00191971
	public static float LCECOJGFGCL()
	{
		return 13f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x00193783 File Offset: 0x00191983
	private bool MAOBPEFDPBK()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("</i>");
			return false;
		}
		return false;
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x0019379C File Offset: 0x0019199C
	public void EIEEBNIFFHH(FEMKDIHKJCM JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.LCKCKFDDDLC(this.IMPAHLIGELE.MNIHPPOHKHP());
			this.GKKCHJLKFBL = ONEHEBIHPFB.LCKCKFDDDLC(this.IMPAHLIGELE.GLPJJLMMHIP());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00193804 File Offset: 0x00191A04
	public void KOPJJFNHEJO(FEMKDIHKJCM JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.NCAMNNEOGKG(this.IMPAHLIGELE.JAPHIPIDHKG());
			this.GKKCHJLKFBL = ONEHEBIHPFB.LCKCKFDDDLC(this.IMPAHLIGELE.FCOEJIJOPJF());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x0019386C File Offset: 0x00191A6C
	public void ACGGMOACIHN(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Ellipsis;
		this.textTitle.fontSizeMin = 261f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "SceneLobbyManager2.OnLiveProfileThemesLoaderStop(): aborting the in-flight live profile themes " + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x00193939 File Offset: 0x00191B39
	private bool BMPOEBFLJHJ()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete");
			return true;
		}
		return false;
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x00193950 File Offset: 0x00191B50
	private bool NLDKEIIJLAI()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error.");
			return true;
		}
		return true;
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00193968 File Offset: 0x00191B68
	public void DisappearAnimation(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == FJOIFOINENC.animationDisappearCached)
		{
			this.PANMNKKODPC.DOFade(0f, 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(0.5f, 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(200f, -40f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InQuad);
		}
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x00193A00 File Offset: 0x00191C00
	private void JDMOENJPHOE()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1213f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1889f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x00193A6C File Offset: 0x00191C6C
	public void LPJCNKJFKJI(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.CAKAMPNELIM())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Linked;
		this.textTitle.fontSizeMin = 1358f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "ok" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x00193B3C File Offset: 0x00191D3C
	public void DGAFAPKAKIA(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.MAOBPEFDPBK())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Ellipsis;
		this.textTitle.fontSizeMin = 1640f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "minRevision" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().GLIFGDPDMNC(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x00193C09 File Offset: 0x00191E09
	private void GLLAHKDDKEB()
	{
		this.FFEDFDKAEHC(this.IMPAHLIGELE);
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x00193C17 File Offset: 0x00191E17
	private void ILBAMCJFAAP()
	{
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("+", new UnityAction(this.GLLAHKDDKEB));
	}

	// Token: 0x06003D0A RID: 15626 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x00193C34 File Offset: 0x00191E34
	private bool JMLENGALDPG()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return true;
		}
		return true;
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x00193C4B File Offset: 0x00191E4B
	private IEnumerator IPFNHGCEAOD()
	{
		yield return new WaitForSeconds(0.5f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x00193639 File Offset: 0x00191839
	public int ONNHPACPOHB()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06003D0E RID: 15630 RVA: 0x00193C5A File Offset: 0x00191E5A
	public static float MFEGDGJAAHJ()
	{
		return 1699f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x00193C6C File Offset: 0x00191E6C
	public void JHIFJCKNBHP(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (FJOIFOINENC)7)
		{
			this.PANMNKKODPC.DOFade(1103f, 1691f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(878f, 1753f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(280f, 1929f), 1059f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Unset);
		}
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x00193D04 File Offset: 0x00191F04
	private void DOMKOCMIFHE()
	{
		this.ACGGMOACIHN(this.IMPAHLIGELE);
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLCMPLIMAEI()
	{
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x00193D14 File Offset: 0x00191F14
	public void JOFNFNFEFKN(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.JMLENGALDPG())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = TextOverflowModes.Overflow;
		this.textTitle.fontSizeMin = 862f;
		this.textTitle.SetText(this.NLKIPHPICLJ, true);
		this.textBody.SetText(this.GKKCHJLKFBL, true);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "frcnt" + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().HDAHPNAHNJC(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00193DE1 File Offset: 0x00191FE1
	private void COMPLLBGJPB()
	{
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("OnBackendGetDropChancesSuccess2", new UnityAction(this.GLLAHKDDKEB));
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00193E00 File Offset: 0x00192000
	public void AppearAnimation(FJOIFOINENC GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(50, 25);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(-50f, -25f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InSine).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(1f, 0.35f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.OutQuad).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.PADHGAOKECA() < 1f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 0f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(60, -20);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(-60f, 20f), 0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.OutQuad).SetDelay(0.25f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x00193FE5 File Offset: 0x001921E5
	private void LOCANABKJEE()
	{
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(true);
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x00194001 File Offset: 0x00192201
	private void LLMPAPDBHEL()
	{
		this.Initialize(this.IMPAHLIGELE);
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x00194010 File Offset: 0x00192210
	public void DCIHHJLDOKA(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (FJOIFOINENC)8)
		{
			this.PANMNKKODPC.DOFade(1979f, 392f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(1002f, 142f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(846f, 63f), 438f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Linear);
		}
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x001940A8 File Offset: 0x001922A8
	private IEnumerator AKAKHPHGDJH()
	{
		DialogNonPlayerCharacterManager.OCJGOPCMALE ocjgopcmale = new DialogNonPlayerCharacterManager.OCJGOPCMALE(1);
		ocjgopcmale.<>4__this = this;
		return ocjgopcmale;
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x00193639 File Offset: 0x00191839
	public int GetLocalizedTextLength()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06003D1A RID: 15642 RVA: 0x001940B7 File Offset: 0x001922B7
	private void HKFKOMMEMCN()
	{
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06003D1B RID: 15643 RVA: 0x001940D3 File Offset: 0x001922D3
	private void JCOBBJJNHIJ()
	{
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("h", new UnityAction(this.ELNNCIJNNGK));
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x001940F0 File Offset: 0x001922F0
	public void OJHJKHAEMCP(FJOIFOINENC GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1308f, 66f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(756f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(395f, 324f, 422f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 1585f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1485f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-21, -60);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(349f, 32f), 858f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InSine).SetDelay(633f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(971f, 1139f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InQuad).SetDelay(1171f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.GIOKAPOLHDO() < 675f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.GIOKAPOLHDO(), 862f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-109, 121);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1564f, 926f), 834f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.Linear).SetDelay(1135f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06003D1D RID: 15645 RVA: 0x001942D5 File Offset: 0x001924D5
	public static float CNJAAJFGFLJ()
	{
		return 76f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x001942E7 File Offset: 0x001924E7
	private void FCOKGLDPJJO()
	{
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("youreceived", new UnityAction(this.AAEANOPPNPC));
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x00194304 File Offset: 0x00192504
	public void LPAMBCIBGLL(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1969f, 1991f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(756f, 1352f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1936f, 987f), 1790f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InQuad);
		}
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x00193639 File Offset: 0x00191839
	public int JBEGOAMMALC()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06003D21 RID: 15649 RVA: 0x00194001 File Offset: 0x00192201
	private void JKDGPOALNDA()
	{
		this.Initialize(this.IMPAHLIGELE);
	}

	// Token: 0x06003D22 RID: 15650 RVA: 0x0019439C File Offset: 0x0019259C
	public static float IHKCLPAFKLE()
	{
		return 972f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D23 RID: 15651 RVA: 0x001943AE File Offset: 0x001925AE
	public static float LAOJIPNOMEH()
	{
		return 1087f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x001943C0 File Offset: 0x001925C0
	public void ALDKGAPGGNN(FJOIFOINENC GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.AKAKHPHGDJH());
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(340f, 1433f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1011f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(365f, 186f, 1590f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 1144f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1049f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(-74, 113);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1416f, 542f), 408f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), false).SetEase(Ease.InOutSine).SetDelay(1839f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppearCached)
		{
			this.PANMNKKODPC.DOFade(1294f, 724f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InCubic).SetDelay(48f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.HOMIGPGAGHG() < 1589f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 1200f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-9, -41);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1198f, 86f), 1182f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.Unset).SetDelay(470f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06003D25 RID: 15653 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06003D26 RID: 15654 RVA: 0x001945A5 File Offset: 0x001927A5
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x001945C2 File Offset: 0x001927C2
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("DialogNonPlayerCharacterManager.InputDataIsValid() - step is null.");
			return false;
		}
		return true;
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x001945D9 File Offset: 0x001927D9
	private void ELNNCIJNNGK()
	{
		this.LPJCNKJFKJI(this.IMPAHLIGELE);
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x001945E8 File Offset: 0x001927E8
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 0f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 0f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x00194654 File Offset: 0x00192854
	public void LHJDNCJHDPB(FEMKDIHKJCM JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.LCKCKFDDDLC(this.IMPAHLIGELE.HGPEPBNNHMG());
			this.GKKCHJLKFBL = ONEHEBIHPFB.NCAMNNEOGKG(this.IMPAHLIGELE.DMPDDMLHPCA());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x0019470C File Offset: 0x0019290C
	private bool CAKAMPNELIM()
	{
		if (this.IMPAHLIGELE == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("<i>");
			return true;
		}
		return false;
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x00193C09 File Offset: 0x00191E09
	private void FELNAMJOMMK()
	{
		this.FFEDFDKAEHC(this.IMPAHLIGELE);
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x00194723 File Offset: 0x00192923
	public static float BGHFCBINKPB()
	{
		return 866f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x00193C4B File Offset: 0x00191E4B
	private IEnumerator JLDEJMKFKML()
	{
		yield return new WaitForSeconds(0.5f * KDCJJBLGCBH.EHBBFMCILPC.LIKMBLFBEIA());
		this.textBodyTypeAnimation.GetComponent<AnimationTextType>().PlayAnimation();
		yield break;
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x00194738 File Offset: 0x00192938
	public void EINCGCELPML(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(764f, 7f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(1218f, 527f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1953f, 482f), 1394f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InSine);
		}
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x001947D0 File Offset: 0x001929D0
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnLanguageChange", new UnityAction(this.LLMPAPDBHEL));
	}

	// Token: 0x06003D32 RID: 15666 RVA: 0x001947ED File Offset: 0x001929ED
	private void CEDPIGBOKGB()
	{
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("OnReturnRewardPopupHide", new UnityAction(this.LLMPAPDBHEL));
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x0019480A File Offset: 0x00192A0A
	private void PADHAHCNFNM()
	{
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("OnBackendPremiumChoiceSuccess", new UnityAction(this.FELNAMJOMMK));
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x00194827 File Offset: 0x00192A27
	public static float DEIIIOCDEGA()
	{
		return 1844f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x0019483C File Offset: 0x00192A3C
	public void ENDNBFNDACJ(FJOIFOINENC GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.JLDEJMKFKML());
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(286f, 819f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1674f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1925f, 523f, 373f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.JACCDKKPFPF(), 664f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1307f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(116, -50);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1711f, 367f), 1759f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InCubic).SetDelay(587f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(661f, 1753f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InOutSine).SetDelay(90f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.GIOKAPOLHDO() < 161f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 420f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(56, -127);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(644f, 1249f), 1722f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.OutSine).SetDelay(553f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06003D36 RID: 15670 RVA: 0x00194A24 File Offset: 0x00192C24
	public void FFEDFDKAEHC(FEMKDIHKJCM JIKFCLOHJNN)
	{
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.CAKAMPNELIM())
		{
			return;
		}
		if (JIKFCLOHJNN.GJOCJINDEIF && null != this.bubbleSprite)
		{
			Image component = base.gameObject.GetComponent<Image>();
			if (null != component)
			{
				component.sprite = this.bubbleSprite;
			}
		}
		this.textTitle.overflowMode = (TextOverflowModes)7;
		this.textTitle.fontSizeMin = 276f;
		this.textTitle.SetText(this.NLKIPHPICLJ, false);
		this.textBody.SetText(this.GKKCHJLKFBL, false);
		SceneStoryManager.localizedLine = this.NLKIPHPICLJ + "Error. ShowEnvironment(), environment " + this.GKKCHJLKFBL;
		if (this.textTypeAnimation)
		{
			this.textBodyTypeAnimation.GetComponent<AnimationTextType>().Initialize(this.GKKCHJLKFBL);
		}
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x00194AF4 File Offset: 0x00192CF4
	private void HGEODIPIBPG()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 1939f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1915f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(true);
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x001940B7 File Offset: 0x001922B7
	private void OnDestroy()
	{
		this.PANMNKKODPC.DOKill(true);
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x00193639 File Offset: 0x00191839
	public int CPAEFMOBFAD()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x06003D3A RID: 15674 RVA: 0x00194B60 File Offset: 0x00192D60
	public void NKOHIHPMNDO(FEMKDIHKJCM JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.NCAMNNEOGKG(this.IMPAHLIGELE.HDGCANJIPGD());
			this.GKKCHJLKFBL = ONEHEBIHPFB.FOMGCOENOKO(this.IMPAHLIGELE.MEFJJHPACAK());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x00194BC8 File Offset: 0x00192DC8
	public void DPDMOAAELHF(FJOIFOINENC GMLIEKDKEAG)
	{
		if (GMLIEKDKEAG == (FJOIFOINENC)7)
		{
			this.PANMNKKODPC.DOFade(1970f, 805f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOScale(1428f, 674f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1772f, 1821f), 770f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InSine);
		}
	}

	// Token: 0x06003D3C RID: 15676 RVA: 0x00194C60 File Offset: 0x00192E60
	public void CBPNPBHKDPF(FJOIFOINENC GMLIEKDKEAG)
	{
		if (this.textTypeAnimation)
		{
			base.StartCoroutine(this.AKAKHPHGDJH());
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(241f, 577f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1947f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.localScale = new Vector3(1340f, 1723f, 1400f);
			this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.PADHGAOKECA(), 927f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetDelay(1175f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			this.DGAAFGDHHHJ.AHLJBONHHKL(48, -35);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(501f, 638f), 277f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InCubic).SetDelay(10f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			return;
		}
		if (GMLIEKDKEAG == FJOIFOINENC.animationAppear)
		{
			this.PANMNKKODPC.DOFade(1010f, 1135f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE()).SetEase(Ease.InOutSine).SetDelay(1709f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
			if (NBDLBFJOEGN.HOMIGPGAGHG() < 189f)
			{
				this.DGAAFGDHHHJ.DOScale(NBDLBFJOEGN.HOMIGPGAGHG(), 146f);
			}
			this.DGAAFGDHHHJ.AHLJBONHHKL(-21, -44);
			this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1402f, 257f), 1481f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE(), true).SetEase(Ease.InOutQuad).SetDelay(345f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE());
		}
	}

	// Token: 0x06003D3D RID: 15677 RVA: 0x00194E45 File Offset: 0x00193045
	private void MOHLNGBBIOB()
	{
		this.PANMNKKODPC.DOKill(false);
		this.DGAAFGDHHHJ.DOKill(false);
	}

	// Token: 0x06003D3E RID: 15678 RVA: 0x00194E61 File Offset: 0x00193061
	private void AAEANOPPNPC()
	{
		this.JOFNFNFEFKN(this.IMPAHLIGELE);
	}

	// Token: 0x06003D3F RID: 15679 RVA: 0x00194E70 File Offset: 0x00193070
	public void PreInitialize(FEMKDIHKJCM JIKFCLOHJNN)
	{
		if (JIKFCLOHJNN != null)
		{
			this.IMPAHLIGELE = JIKFCLOHJNN;
			this.NLKIPHPICLJ = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.NEANAPPJBAN());
			this.GKKCHJLKFBL = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.DKEOPDAFLNO());
			this.GKKCHJLKFBL = DPGJIJGOCIC.AKIAKADKBFK(this.GKKCHJLKFBL);
			this.AOKIMHCAAHB = this.GKKCHJLKFBL.Length;
		}
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x00194ED8 File Offset: 0x001930D8
	private void PMDCMEKGFNN()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		this.PANMNKKODPC.alpha = 233f;
		if (this.textTypeAnimation)
		{
			this.textBody.alpha = 1378f;
			return;
		}
		this.textBodyTypeAnimation.gameObject.SetActive(false);
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x00194F41 File Offset: 0x00193141
	public static float JLLMCLEFCDI()
	{
		return 1846f * KDCJJBLGCBH.EHBBFMCILPC.OIABNIJLJBE();
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x00193639 File Offset: 0x00191839
	public int AFNLOFAJGKK()
	{
		return this.AOKIMHCAAHB;
	}

	// Token: 0x0400116A RID: 4458
	public bool enableMaxCriticalAspectRatioOffsetOverride;

	// Token: 0x0400116B RID: 4459
	public Vector2 maxCriticalAspectRatioOffsetOverride = new Vector2(60f, 0f);

	// Token: 0x0400116C RID: 4460
	public TextMeshProUGUI textTitle;

	// Token: 0x0400116D RID: 4461
	public TextMeshProUGUI textBody;

	// Token: 0x0400116E RID: 4462
	public TextMeshProUGUI textBodyTypeAnimation;

	// Token: 0x0400116F RID: 4463
	public bool textTypeAnimation = true;

	// Token: 0x04001170 RID: 4464
	public int maxTitleCharactersCount = 128;

	// Token: 0x04001171 RID: 4465
	public int dialogOffsetY;

	// Token: 0x04001172 RID: 4466
	public bool isSmallFont;

	// Token: 0x04001173 RID: 4467
	public Sprite bubbleSprite;

	// Token: 0x04001174 RID: 4468
	private const float KKMJEEJNKGK = 0.5f;

	// Token: 0x04001175 RID: 4469
	private const float DHGLJFHOLBF = 0.75f;

	// Token: 0x04001176 RID: 4470
	private const float MPFBEFBJDCK = 1f;

	// Token: 0x04001177 RID: 4471
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001178 RID: 4472
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04001179 RID: 4473
	private int AOKIMHCAAHB;

	// Token: 0x0400117A RID: 4474
	private string NLKIPHPICLJ = "";

	// Token: 0x0400117B RID: 4475
	private string GKKCHJLKFBL = "";

	// Token: 0x0400117C RID: 4476
	private FEMKDIHKJCM IMPAHLIGELE;
}
