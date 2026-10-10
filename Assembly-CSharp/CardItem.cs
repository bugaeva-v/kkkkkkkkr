using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000356 RID: 854
public class CardItem : MonoBehaviour
{
	// Token: 0x06006508 RID: 25864 RVA: 0x002F0AB9 File Offset: 0x002EECB9
	private void HBELNHOMGCI()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(45f, 564f, 261f, 1701f);
		}
	}

	// Token: 0x06006509 RID: 25865 RVA: 0x002F0AF4 File Offset: 0x002EECF4
	public void KKKHMFAINIH(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC, UnityAction BIJKHDNCKGM)
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(998f, 613f, 681f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.index = NBKNFJNIDKC.index;
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesFront[0];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		int num = 0;
		int num2 = 0;
		if (NBKNFJNIDKC.customLanguageLogoOffset != null)
		{
			for (int i = 0; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i += 0)
			{
				if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ().ToString()))
				{
					num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
					num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
					break;
				}
			}
		}
		this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
		this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
		if (this.FNJJIPNFCMK.CNCGCBFFFEM.Length == 0)
		{
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.openFocusButton.onClick.AddListener(new UnityAction(this.PPLLGINLOBG));
		}
		this.openPopUpButton.onClick.AddListener(new UnityAction(this.HPIAJKIMIDB));
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.onClick.AddListener(new UnityAction(this.IPBMEADOHCB));
		}
		this.JKDGPOALNDA();
		if (FNJJIPNFCMK.IACMODHPFKI.KDIFNBPNLPN() > 1187f)
		{
			if (null != this.liveEventLocked)
			{
				this.liveEventLocked.gameObject.SetActive(false);
				if (null != this.liveEventLockedTimerText)
				{
					this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.EBAFNCLPHKM()), true);
				}
				if (!this.FAGLGFFKCBK)
				{
					this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, 126);
					this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, 49);
					this.FAGLGFFKCBK = true;
				}
			}
			else
			{
				this.openPopUpButton.gameObject.SetActive(true);
			}
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.EKJIJLMOBIG()), false);
			return;
		}
		this.KDCFJNEBDDC = true;
		this.openFocusButton.gameObject.SetActive(true);
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = true;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600650A RID: 25866 RVA: 0x002F0ED0 File Offset: 0x002EF0D0
	private void DOLBMCHKFPM()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600650B RID: 25867 RVA: 0x002F0F0C File Offset: 0x002EF10C
	[CompilerGenerated]
	private void MLHCAOMNGMM()
	{
		this.LFELBKAGFDM();
	}

	// Token: 0x0600650C RID: 25868 RVA: 0x002F0F14 File Offset: 0x002EF114
	private void OPMJMNODKNK()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600650D RID: 25869 RVA: 0x002F0F50 File Offset: 0x002EF150
	private void HCKLMFNDKBC()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1786f, 295f, 1233f, 702f);
		}
	}

	// Token: 0x0600650E RID: 25870 RVA: 0x002F0F8C File Offset: 0x002EF18C
	public void IDFBHLAJAPB()
	{
		if (KHPGPLAMAIN.BHIJDBJNAMH() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 877f;
			}
			this.stroke.NFIPIOOJPEK(1237f, 1455f, 935f, Ease.Linear, null);
		}
	}

	// Token: 0x0600650F RID: 25871 RVA: 0x002F0FE4 File Offset: 0x002EF1E4
	private void HAFJONMIKFC()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.ODHBINFKIPL() < 211f)
				{
					this.FHGEBHKPBLO = false;
					this.tagTimerCurrentValue.gameObject.SetActive(true);
					this.tagTimerEnd.gameObject.SetActive(false);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG("energyhinttitle"), true);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.ONMADEIOOKN.LEAIEAIEBJK()), true);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1507f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 105f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL() >= 931f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FNJJIPNFCMK.IACMODHPFKI.EKJIJLMOBIG()), true);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = true;
			this.FKJCNEHPPCP();
		}
	}

	// Token: 0x06006510 RID: 25872 RVA: 0x002F1164 File Offset: 0x002EF364
	private void LFBPHHOPPBO()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.EKJIJLMOBIG() < 67f)
				{
					this.FHGEBHKPBLO = false;
					this.tagTimerCurrentValue.gameObject.SetActive(true);
					this.tagTimerEnd.gameObject.SetActive(true);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.BBGECIKOICE().HDIPNMFHIEJ("%</b>"), false);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.ONMADEIOOKN.EBAFNCLPHKM()), false);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1053f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1445f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL() >= 268f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.EBAFNCLPHKM()), true);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.GLAPKLGPCKE()), false);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = true;
			this.BPOAIOMHCCC();
		}
	}

	// Token: 0x06006511 RID: 25873 RVA: 0x002F12E2 File Offset: 0x002EF4E2
	private void FDIHLKMELNF()
	{
		this.GFGDNJIEAEN();
	}

	// Token: 0x06006512 RID: 25874 RVA: 0x002F12EA File Offset: 0x002EF4EA
	private void FAEHEDAHBCG()
	{
		this.NMPHBLNOOKM();
	}

	// Token: 0x06006513 RID: 25875 RVA: 0x002F12F4 File Offset: 0x002EF4F4
	private void GDCICHNOEKH()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.INKJIBDDMLL().OHLNGCKIACD("Asset bundle assets destroyed:"), CCOJBMMKNAP.CEGAOMEEFBE().BGELFMIOBCL("none"), CCOJBMMKNAP.EHBBFMCILPC.GGPHHLGPMPA("OnApplicationFocusBasicSyncSuccess"), (DFGILFBGPLN)(-4), 177f, 44);
	}

	// Token: 0x06006514 RID: 25876 RVA: 0x002F1344 File Offset: 0x002EF544
	public void CILBECNONAB()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(false);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("OnAvatarCollectionsGamePassSubscribePositive" + this.index.ToString(), "ociil", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("\n<alpha=#C0>..." + this.index.ToString(), ") + is present, creating anthology save for anthology ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
			this.messageV2.gameObject.SetActive(true);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("abpd4" + this.index.ToString(), "ProfileItem2._DownloadCardsPool(): downloading ", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("OnSaveSlotSelect" + this.index.ToString(), "oldvhs", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
			this.message.gameObject.SetActive(false);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.KNKGCDDMLDP().JCDFHKDNEDH("tm"), true);
		}
	}

	// Token: 0x06006515 RID: 25877 RVA: 0x002F12EA File Offset: 0x002EF4EA
	private void LFLBNCDECBF()
	{
		this.NMPHBLNOOKM();
	}

	// Token: 0x06006516 RID: 25878 RVA: 0x002F149F File Offset: 0x002EF69F
	private void DFEKIJDOHPJ()
	{
		this.OPMJMNODKNK();
	}

	// Token: 0x06006517 RID: 25879 RVA: 0x002F14A8 File Offset: 0x002EF6A8
	private void DFBCJJAOMGI()
	{
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.gameObject.SetActive(false);
			if (this.FAGLGFFKCBK)
			{
				this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, 70);
				this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, 70);
				this.FAGLGFFKCBK = false;
			}
		}
		this.openPopUpButton.gameObject.SetActive(false);
		this.openFocusButton.gameObject.SetActive(true);
		this.tagTimerCurrentValue.gameObject.SetActive(true);
	}

	// Token: 0x06006518 RID: 25880 RVA: 0x002F1541 File Offset: 0x002EF741
	private void DJPEJJKJFHK()
	{
		this.GDCICHNOEKH();
	}

	// Token: 0x06006519 RID: 25881 RVA: 0x002F154C File Offset: 0x002EF74C
	private void CJHFPCNEHGB()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.EBAFNCLPHKM() < 715f)
				{
					this.FHGEBHKPBLO = false;
					this.tagTimerCurrentValue.gameObject.SetActive(false);
					this.tagTimerEnd.gameObject.SetActive(false);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.KLAKLFCOMJC().JHNELLJFBGC("socialrequestwarnyou"), true);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FNJJIPNFCMK.ONMADEIOOKN.ODHBINFKIPL()), true);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1635f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1427f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL() >= 1039f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.LEAIEAIEBJK()), true);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = false;
			this.NPNKPALPNAK();
		}
	}

	// Token: 0x0600651A RID: 25882 RVA: 0x002F12EA File Offset: 0x002EF4EA
	private void IPBMEADOHCB()
	{
		this.NMPHBLNOOKM();
	}

	// Token: 0x0600651B RID: 25883 RVA: 0x002F16CC File Offset: 0x002EF8CC
	public void GLPBFPOKAMC(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.CIAFFHAENHD() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1429f;
		}
		this.stroke.NFIPIOOJPEK(667f, 784f, 933f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(999f, 1676f, LILDMOONHPB, (Ease)101, null);
	}

	// Token: 0x0600651C RID: 25884 RVA: 0x002F0F0C File Offset: 0x002EF10C
	[CompilerGenerated]
	private void NGCDOPIAKBN()
	{
		this.LFELBKAGFDM();
	}

	// Token: 0x0600651D RID: 25885 RVA: 0x002F1740 File Offset: 0x002EF940
	public void JKDGPOALNDA()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(true);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("wofcollectcarddone" + this.index.ToString(), "syncoll2", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("_web" + this.index.ToString(), "a", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
			this.messageV2.gameObject.SetActive(false);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("p" + this.index.ToString(), ") + is present, creating anthology save for anthology ", LanguageManager.EHBBFMCILPC.MLOLBFBODHD());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("," + this.index.ToString(), " secondary(pending)", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
			this.message.gameObject.SetActive(true);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.BIAEAOMHBMM().OBDCPLLLGBB("=== RU FIREWALL === geo endpoint "), false);
		}
	}

	// Token: 0x0600651E RID: 25886 RVA: 0x002F189C File Offset: 0x002EFA9C
	private void Update()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.ODHBINFKIPL() < 1f)
				{
					this.FHGEBHKPBLO = true;
					this.tagTimerCurrentValue.gameObject.SetActive(false);
					this.tagTimerEnd.gameObject.SetActive(true);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("eventended"), true);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.ONMADEIOOKN.ODHBINFKIPL()), true);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 0f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL() >= 1f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = true;
			this.DFBCJJAOMGI();
		}
	}

	// Token: 0x0600651F RID: 25887 RVA: 0x002F1A1C File Offset: 0x002EFC1C
	private void FKJCNEHPPCP()
	{
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.gameObject.SetActive(false);
			if (this.FAGLGFFKCBK)
			{
				this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -65);
				this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, -13);
				this.FAGLGFFKCBK = false;
			}
		}
		this.openPopUpButton.gameObject.SetActive(true);
		this.openFocusButton.gameObject.SetActive(true);
		this.tagTimerCurrentValue.gameObject.SetActive(true);
	}

	// Token: 0x06006520 RID: 25888 RVA: 0x002F1AB5 File Offset: 0x002EFCB5
	private void EMOBGJMNLJC()
	{
		this.JHICNNLAPEO();
	}

	// Token: 0x06006521 RID: 25889 RVA: 0x002F1AC0 File Offset: 0x002EFCC0
	public void FJHBGFCDNCE()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(false);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.index.ToString(), "acli20", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP(" (loaded via the " + this.index.ToString(), "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.messageV2.gameObject.SetActive(true);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("achiev" + this.index.ToString(), "veff", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("uid" + this.index.ToString(), "liveeventstitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
			this.message.gameObject.SetActive(false);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.KFAABHHGOPO().FIENAKIHNOM("Critical error, type not implemented in ProcessAssetBundleLoadAssetOperationRequest():"), false);
		}
	}

	// Token: 0x06006522 RID: 25890 RVA: 0x002F1C1C File Offset: 0x002EFE1C
	public void MNLIAIBNCHP(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1866f;
		}
		this.stroke.NFIPIOOJPEK(1383f, 1507f, 396f, Ease.Unset, null);
		this.flash.NFIPIOOJPEK(1270f, 280f, LILDMOONHPB, (Ease)54, null);
	}

	// Token: 0x06006523 RID: 25891 RVA: 0x002F1C90 File Offset: 0x002EFE90
	private void BODGLKJFBHM()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.ODBOJGMLKHA() < 798f)
				{
					this.FHGEBHKPBLO = true;
					this.tagTimerCurrentValue.gameObject.SetActive(false);
					this.tagTimerEnd.gameObject.SetActive(false);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.DLGLFACMHPG().BDGPNPNIAPA("default"), true);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.ONMADEIOOKN.LEAIEAIEBJK()), true);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1203f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1279f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.EKJIJLMOBIG() >= 1949f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.EKJIJLMOBIG()), false);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.ODBOJGMLKHA()), true);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = false;
			this.DFBCJJAOMGI();
		}
	}

	// Token: 0x06006524 RID: 25892 RVA: 0x002F1E0E File Offset: 0x002F000E
	private void GEIKOOEDBAF()
	{
		this.PEOBBPGFFNH();
	}

	// Token: 0x06006525 RID: 25893 RVA: 0x002F1E18 File Offset: 0x002F0018
	public void MMNHJINAENE(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC, UnityAction BIJKHDNCKGM)
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1389f, 1810f, 238f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.index = NBKNFJNIDKC.index;
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesFront[1];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		int num = 1;
		int num2 = 1;
		if (NBKNFJNIDKC.customLanguageLogoOffset != null)
		{
			for (int i = 0; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i += 0)
			{
				if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ().ToString()))
				{
					num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
					num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
					break;
				}
			}
		}
		this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
		this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
		if (this.FNJJIPNFCMK.CNCGCBFFFEM.Length == 0)
		{
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.openFocusButton.onClick.AddListener(new UnityAction(this.EMOBGJMNLJC));
		}
		this.openPopUpButton.onClick.AddListener(new UnityAction(this.GEIKOOEDBAF));
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.onClick.AddListener(new UnityAction(this.NGCDOPIAKBN));
		}
		this.GILDKKNGBEG();
		if (FNJJIPNFCMK.IACMODHPFKI.EBAFNCLPHKM() > 833f)
		{
			if (null != this.liveEventLocked)
			{
				this.liveEventLocked.gameObject.SetActive(true);
				if (null != this.liveEventLockedTimerText)
				{
					this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)FNJJIPNFCMK.IACMODHPFKI.LEAIEAIEBJK()), false);
				}
				if (!this.FAGLGFFKCBK)
				{
					this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -4);
					this.message.GetComponent<RectTransform>().AHLJBONHHKL(1, 57);
					this.FAGLGFFKCBK = false;
				}
			}
			else
			{
				this.openPopUpButton.gameObject.SetActive(true);
			}
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.ODBOJGMLKHA()), false);
			return;
		}
		this.KDCFJNEBDDC = false;
		this.openFocusButton.gameObject.SetActive(false);
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = true;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x06006526 RID: 25894 RVA: 0x002F21F2 File Offset: 0x002F03F2
	private void FCOKGLDPJJO()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(44f, 1319f, 1638f, 32f);
		}
	}

	// Token: 0x06006527 RID: 25895 RVA: 0x002F1541 File Offset: 0x002EF741
	private void LILPINEJKGN()
	{
		this.GDCICHNOEKH();
	}

	// Token: 0x06006528 RID: 25896 RVA: 0x002F222C File Offset: 0x002F042C
	private void DIJKLECFLPK()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006529 RID: 25897 RVA: 0x002F2268 File Offset: 0x002F0468
	public void SetEffectsOnSnap(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1f;
		}
		this.stroke.NFIPIOOJPEK(0f, 255f, 0.1f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(255f, 0f, LILDMOONHPB, Ease.Flash, null);
	}

	// Token: 0x0600652A RID: 25898 RVA: 0x002F22DC File Offset: 0x002F04DC
	private void IHMDAFMIHHH()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.LFLAIPLKINK() < 498f)
				{
					this.FHGEBHKPBLO = true;
					this.tagTimerCurrentValue.gameObject.SetActive(true);
					this.tagTimerEnd.gameObject.SetActive(true);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.ONCPHEEJLOP().GGPHHLGPMPA("blur"), false);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.FNJJIPNFCMK.ONMADEIOOKN.LEAIEAIEBJK()), false);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1219f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 871f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.KDIFNBPNLPN() >= 1039f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.ODBOJGMLKHA()), false);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.LFLAIPLKINK()), false);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = true;
			this.NPNKPALPNAK();
		}
	}

	// Token: 0x0600652B RID: 25899 RVA: 0x002F245C File Offset: 0x002F065C
	public void HHBAMGNJFLO(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC, UnityAction BIJKHDNCKGM)
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(605f, 117f, 584f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.index = NBKNFJNIDKC.index;
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesFront[1];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		int num = 0;
		int num2 = 1;
		if (NBKNFJNIDKC.customLanguageLogoOffset != null)
		{
			for (int i = 1; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i += 0)
			{
				if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ().ToString()))
				{
					num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
					num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
					break;
				}
			}
		}
		this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
		this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
		if (this.FNJJIPNFCMK.CNCGCBFFFEM.Length == 0)
		{
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.openFocusButton.onClick.AddListener(new UnityAction(this.HHPLKFDEHEF));
		}
		this.openPopUpButton.onClick.AddListener(new UnityAction(this.LILPINEJKGN));
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.onClick.AddListener(new UnityAction(this.DJPEJJKJFHK));
		}
		this.BEJJFDDCAJD();
		if (FNJJIPNFCMK.IACMODHPFKI.LEAIEAIEBJK() > 1316f)
		{
			if (null != this.liveEventLocked)
			{
				this.liveEventLocked.gameObject.SetActive(false);
				if (null != this.liveEventLockedTimerText)
				{
					this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)FNJJIPNFCMK.IACMODHPFKI.LEAIEAIEBJK()), false);
				}
				if (!this.FAGLGFFKCBK)
				{
					this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, 74);
					this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, 79);
					this.FAGLGFFKCBK = true;
				}
			}
			else
			{
				this.openPopUpButton.gameObject.SetActive(false);
			}
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)FNJJIPNFCMK.IACMODHPFKI.KDIFNBPNLPN()), true);
			return;
		}
		this.KDCFJNEBDDC = false;
		this.openFocusButton.gameObject.SetActive(false);
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = false;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600652C RID: 25900 RVA: 0x002F2838 File Offset: 0x002F0A38
	public void SetContent(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC, UnityAction BIJKHDNCKGM)
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.index = NBKNFJNIDKC.index;
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesFront[0];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		int num = 0;
		int num2 = 0;
		if (NBKNFJNIDKC.customLanguageLogoOffset != null)
		{
			for (int i = 0; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i++)
			{
				if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
				{
					num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
					num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
					break;
				}
			}
		}
		this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
		this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
		if (this.FNJJIPNFCMK.CNCGCBFFFEM.Length == 0)
		{
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.openFocusButton.onClick.AddListener(new UnityAction(this.OGMMGLPOGOH));
		}
		this.openPopUpButton.onClick.AddListener(new UnityAction(this.MLHCAOMNGMM));
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.onClick.AddListener(new UnityAction(this.NGCDOPIAKBN));
		}
		this.OnLanguageChange();
		if (FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL() > 0f)
		{
			if (null != this.liveEventLocked)
			{
				this.liveEventLocked.gameObject.SetActive(true);
				if (null != this.liveEventLockedTimerText)
				{
					this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
				}
				if (!this.FAGLGFFKCBK)
				{
					this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -70);
					this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, -70);
					this.FAGLGFFKCBK = true;
				}
			}
			else
			{
				this.openPopUpButton.gameObject.SetActive(true);
			}
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.ODHBINFKIPL()), true);
			return;
		}
		this.KDCFJNEBDDC = true;
		this.openFocusButton.gameObject.SetActive(true);
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = true;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600652D RID: 25901 RVA: 0x002F2C14 File Offset: 0x002F0E14
	private void BPOAIOMHCCC()
	{
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.gameObject.SetActive(true);
			if (this.FAGLGFFKCBK)
			{
				this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(1, 68);
				this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, 76);
				this.FAGLGFFKCBK = false;
			}
		}
		this.openPopUpButton.gameObject.SetActive(true);
		this.openFocusButton.gameObject.SetActive(false);
		this.tagTimerCurrentValue.gameObject.SetActive(false);
	}

	// Token: 0x0600652E RID: 25902 RVA: 0x002F2CB0 File Offset: 0x002F0EB0
	private void AFAIFFMCPGD()
	{
		if (this.KDCFJNEBDDC)
		{
			if (!this.HJBMNLBOEAL)
			{
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK.ONMADEIOOKN.EBAFNCLPHKM() < 1401f)
				{
					this.FHGEBHKPBLO = false;
					this.tagTimerCurrentValue.gameObject.SetActive(false);
					this.tagTimerEnd.gameObject.SetActive(false);
					this.tagTimerEndText.SetText(CCOJBMMKNAP.CPCOODCFDDP().PKNHKGMNCIP("Starting non-parallel download:"), false);
				}
				if (!this.FHGEBHKPBLO && this.FNJJIPNFCMK != null && this.FNJJIPNFCMK.ONMADEIOOKN != null)
				{
					this.tagTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.ONMADEIOOKN.ODBOJGMLKHA()), false);
					if (this.FNJJIPNFCMK.JIBDJFLGPIF)
					{
						this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 1149f;
						return;
					}
					this.tagTimerCurrentValue.GetComponent<CanvasGroup>().alpha = 974f;
					return;
				}
			}
		}
		else if (this.FNJJIPNFCMK.IACMODHPFKI.GLAPKLGPCKE() >= 1357f)
		{
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.LGMEIBNFMBB((int)this.FNJJIPNFCMK.IACMODHPFKI.LFLAIPLKINK()), true);
			if (null != this.liveEventLockedTimerText)
			{
				this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.FNJJIPNFCMK.IACMODHPFKI.GLAPKLGPCKE()), true);
				return;
			}
		}
		else
		{
			this.KDCFJNEBDDC = false;
			this.NPNKPALPNAK();
		}
	}

	// Token: 0x0600652F RID: 25903 RVA: 0x002F2E30 File Offset: 0x002F1030
	private void NMPHBLNOOKM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.AEELGGPEJCC().HDIPNMFHIEJ("〈"), CCOJBMMKNAP.HEDIEIICOOG().JLBEIFLLBLO(" "), CCOJBMMKNAP.PKEINLPIAEH().PGKBCNBAOJN("energyhinttitle"), (DFGILFBGPLN)(-125), 1669f, -33);
	}

	// Token: 0x06006530 RID: 25904 RVA: 0x002F2E80 File Offset: 0x002F1080
	public void LJJLCEDFLEF()
	{
		if (KHPGPLAMAIN.IBFFFCIPOJC() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1867f;
			}
			this.stroke.NFIPIOOJPEK(504f, 382f, 1372f, Ease.Unset, null);
		}
	}

	// Token: 0x06006531 RID: 25905 RVA: 0x002F2ED8 File Offset: 0x002F10D8
	public void KPDCHGGOJGN()
	{
		if (KHPGPLAMAIN.CIAFFHAENHD() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 698f;
			}
			this.stroke.NFIPIOOJPEK(1858f, 549f, 1662f, Ease.Linear, null);
		}
	}

	// Token: 0x06006532 RID: 25906 RVA: 0x002F149F File Offset: 0x002EF69F
	private void PPLLGINLOBG()
	{
		this.OPMJMNODKNK();
	}

	// Token: 0x06006533 RID: 25907 RVA: 0x002F2F30 File Offset: 0x002F1130
	private void LMIPMLGNIFA()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().PKNHKGMNCIP("Critical error, could not load asset bundle:"), CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("_"), CCOJBMMKNAP.COKDLDOAACJ().OHLNGCKIACD("frcnt"), (DFGILFBGPLN)(-75), 1441f, -35);
	}

	// Token: 0x06006534 RID: 25908 RVA: 0x002F2F80 File Offset: 0x002F1180
	public void LIOPMIFDFJF()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(true);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("" + this.index.ToString(), "{ ", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("header" + this.index.ToString(), "loungestoryfinished", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
			this.messageV2.gameObject.SetActive(false);
		}
		else
		{
			this.messageV2.gameObject.SetActive(false);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("npcpi" + this.index.ToString(), "@HD", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("tradewishcardoption2" + this.index.ToString(), "sfxtimeoutwarning", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), false);
			this.message.gameObject.SetActive(false);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().PGKBCNBAOJN("gpsasar"), false);
		}
	}

	// Token: 0x06006535 RID: 25909 RVA: 0x002F30DB File Offset: 0x002F12DB
	private void ALIKHOFAKKB()
	{
		this.FAGLGFFKCBK = false;
		if (KHPGPLAMAIN.DJFLMBEOBIB() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1484f;
		}
	}

	// Token: 0x06006536 RID: 25910 RVA: 0x002F12EA File Offset: 0x002EF4EA
	private void CNLELNKDNGJ()
	{
		this.NMPHBLNOOKM();
	}

	// Token: 0x06006537 RID: 25911 RVA: 0x002F3114 File Offset: 0x002F1314
	public void OnLanguageChange()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(true);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.index.ToString(), "liveeventstitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.index.ToString(), "liveeventstitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.messageV2.gameObject.SetActive(false);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.index.ToString(), "liveeventstitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("liveeventcontent" + this.index.ToString(), "liveeventstitles", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.message.gameObject.SetActive(false);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("eventended"), true);
		}
	}

	// Token: 0x06006538 RID: 25912 RVA: 0x002F3270 File Offset: 0x002F1470
	public void MPGJFEKCKCM()
	{
		if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 860f;
			}
			this.stroke.NFIPIOOJPEK(1316f, 864f, 722f, Ease.Linear, null);
		}
	}

	// Token: 0x06006539 RID: 25913 RVA: 0x002F32C8 File Offset: 0x002F14C8
	private void Awake()
	{
		this.FAGLGFFKCBK = false;
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 0f;
		}
	}

	// Token: 0x0600653A RID: 25914 RVA: 0x002F3300 File Offset: 0x002F1500
	private void EEMAGPMMKDA()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.HFAKOKBHCGH().FCOCLEHKLDJ("continue"), CCOJBMMKNAP.HFAKOKBHCGH().HHLECNIFHCO("rt"), CCOJBMMKNAP.HEDIEIICOOG().GGPHHLGPMPA("err"), DFGILFBGPLN.popupComingSoon, 298f, 29);
	}

	// Token: 0x0600653B RID: 25915 RVA: 0x002F3350 File Offset: 0x002F1550
	private void GFGDNJIEAEN()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(CCOJBMMKNAP.LMCCLMFGEBD().JLBEIFLLBLO("..."), CCOJBMMKNAP.PLJMLDOCPNM().PGKBCNBAOJN(""), CCOJBMMKNAP.JMNIGPHCAEJ().HPOAGPJFHPM("envlhp"), (DFGILFBGPLN)96, 653f, 19);
	}

	// Token: 0x0600653C RID: 25916 RVA: 0x002F33A0 File Offset: 0x002F15A0
	public void PEFKLJKDODM()
	{
		if (KHPGPLAMAIN.FCJHEFBIKID() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1595f;
			}
			this.stroke.NFIPIOOJPEK(613f, 739f, 1267f, Ease.Unset, null);
		}
	}

	// Token: 0x0600653D RID: 25917 RVA: 0x002F33F8 File Offset: 0x002F15F8
	private void LIJBMJHNDGL()
	{
		this.EEMAGPMMKDA();
	}

	// Token: 0x0600653E RID: 25918 RVA: 0x002F33F8 File Offset: 0x002F15F8
	private void LBBNMJGIJLP()
	{
		this.EEMAGPMMKDA();
	}

	// Token: 0x0600653F RID: 25919 RVA: 0x002F3400 File Offset: 0x002F1600
	public void GILDKKNGBEG()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(false);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("CLIENT.SCREEN.REWARD." + this.index.ToString(), "apb", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("errortitle" + this.index.ToString(), "$", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.messageV2.gameObject.SetActive(true);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("OnConsumeEnergyException" + this.index.ToString(), "", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("importanttitle" + this.index.ToString(), "OnPromoCodeConsumeSuccess", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
			this.message.gameObject.SetActive(true);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.DBFFFOMCLKM().GGPHHLGPMPA("″"), false);
		}
	}

	// Token: 0x06006540 RID: 25920 RVA: 0x002F355C File Offset: 0x002F175C
	private void LFELBKAGFDM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("eventsoon"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x06006541 RID: 25921 RVA: 0x002F35AA File Offset: 0x002F17AA
	private void CPLOOMDNFFD()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1406f, 1026f, 280f, 1371f);
		}
	}

	// Token: 0x06006542 RID: 25922 RVA: 0x002F35E4 File Offset: 0x002F17E4
	public void NJGJJCCKGFH(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.BHIJDBJNAMH() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 88f;
		}
		this.stroke.NFIPIOOJPEK(1196f, 1471f, 1822f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(1190f, 567f, LILDMOONHPB, (Ease)45, null);
	}

	// Token: 0x06006543 RID: 25923 RVA: 0x002F3658 File Offset: 0x002F1858
	public void OJDFNEFAGJE()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(true);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("onhiatustitle" + this.index.ToString(), "signinerror001", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("gpsasff" + this.index.ToString(), "+", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.messageV2.gameObject.SetActive(false);
		}
		else
		{
			this.messageV2.gameObject.SetActive(true);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("anthologycompletespecialepisode" + this.index.ToString(), "", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("energyhinttitle" + this.index.ToString(), "envpind", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
			this.message.gameObject.SetActive(true);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.FEEDGKCJBLE().JLBEIFLLBLO("id"), true);
		}
	}

	// Token: 0x06006544 RID: 25924 RVA: 0x002F37B4 File Offset: 0x002F19B4
	private void NPNKPALPNAK()
	{
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.gameObject.SetActive(true);
			if (this.FAGLGFFKCBK)
			{
				this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -73);
				this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, -100);
				this.FAGLGFFKCBK = true;
			}
		}
		this.openPopUpButton.gameObject.SetActive(true);
		this.openFocusButton.gameObject.SetActive(true);
		this.tagTimerCurrentValue.gameObject.SetActive(false);
	}

	// Token: 0x06006545 RID: 25925 RVA: 0x002F384D File Offset: 0x002F1A4D
	private void OnEnable()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
		}
	}

	// Token: 0x06006546 RID: 25926 RVA: 0x002F3888 File Offset: 0x002F1A88
	private void JHICNNLAPEO()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006547 RID: 25927 RVA: 0x002F38C4 File Offset: 0x002F1AC4
	public void BCNAGEEIGAB(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.BHIJDBJNAMH() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 586f;
		}
		this.stroke.NFIPIOOJPEK(31f, 124f, 1703f, Ease.Unset, null);
		this.flash.NFIPIOOJPEK(1641f, 1055f, LILDMOONHPB, (Ease)(-71), null);
	}

	// Token: 0x06006548 RID: 25928 RVA: 0x002F3935 File Offset: 0x002F1B35
	private void BNMJABILOKK()
	{
		this.FAGLGFFKCBK = true;
		if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1353f;
		}
	}

	// Token: 0x06006549 RID: 25929 RVA: 0x002F396D File Offset: 0x002F1B6D
	private void FBOHAGHNBMN()
	{
		this.LMIPMLGNIFA();
	}

	// Token: 0x0600654A RID: 25930 RVA: 0x002F0F0C File Offset: 0x002EF10C
	private void FAJOAEBKOBO()
	{
		this.LFELBKAGFDM();
	}

	// Token: 0x0600654B RID: 25931 RVA: 0x002F3978 File Offset: 0x002F1B78
	private void PEOBBPGFFNH()
	{
		CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(CCOJBMMKNAP.HFAKOKBHCGH().HDIPNMFHIEJ("OnBackendRequestSendGiftCardSuccess"), CCOJBMMKNAP.KFDLFGHBPLP().GGPHHLGPMPA("$USEENVMOVEV2"), CCOJBMMKNAP.JMDJPKKOHNI().OHLNGCKIACD(" "), DFGILFBGPLN.popupSkinShopInfo, 1315f, -81);
	}

	// Token: 0x0600654D RID: 25933 RVA: 0x002F39C8 File Offset: 0x002F1BC8
	public void MFHJBGBCAFA(OKAFAHMOFII FNJJIPNFCMK, AssetLiveEventContent NBKNFJNIDKC, UnityAction BIJKHDNCKGM)
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(1738f, 1351f, 1168f, NBKNFJNIDKC.innerShadowFrontAlpha);
		}
		this.index = NBKNFJNIDKC.index;
		this.FNJJIPNFCMK = FNJJIPNFCMK;
		this.thumbnail.sprite = NBKNFJNIDKC.thumbnailLargeFramesFront[0];
		if (this.thumbnail.gameObject.GetComponent<ImageFrameAnimation>() == null)
		{
			this.thumbnail.gameObject.AddComponent<ImageFrameAnimation>();
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		else
		{
			this.thumbnail.GetComponent<ImageFrameAnimation>().frameChangeInterval = NBKNFJNIDKC.frameChangeInterval;
			this.thumbnail.GetComponent<ImageFrameAnimation>().framesSD = NBKNFJNIDKC.thumbnailLargeFramesFront.ToArray();
		}
		this.logo.sprite = NBKNFJNIDKC.logo;
		this.logo.SetNativeSize();
		int num = 0;
		int num2 = 1;
		if (NBKNFJNIDKC.customLanguageLogoOffset != null)
		{
			for (int i = 1; i < NBKNFJNIDKC.customLanguageLogoOffset.Count; i++)
			{
				if (NBKNFJNIDKC.customLanguageLogoOffset[i].language.Equals(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
				{
					num = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetX;
					num2 = NBKNFJNIDKC.customLanguageLogoOffset[i].logoOffsetY;
					break;
				}
			}
		}
		this.logo.rectTransform.anchoredPosition = new Vector2((float)(NBKNFJNIDKC.logoOffsetX + num), (float)(NBKNFJNIDKC.logoOffsetY + num2));
		this.logo.rectTransform.localScale = this.logo.rectTransform.localScale * NBKNFJNIDKC.logoScaleFactor;
		if (this.FNJJIPNFCMK.CNCGCBFFFEM.Length == 0)
		{
			this.openFocusButton.onClick.AddListener(BIJKHDNCKGM);
		}
		else
		{
			this.openFocusButton.onClick.AddListener(new UnityAction(this.HHPLKFDEHEF));
		}
		this.openPopUpButton.onClick.AddListener(new UnityAction(this.MLHCAOMNGMM));
		if (null != this.liveEventLocked)
		{
			this.liveEventLocked.onClick.AddListener(new UnityAction(this.LFLBNCDECBF));
		}
		this.OnLanguageChange();
		if (FNJJIPNFCMK.IACMODHPFKI.GLAPKLGPCKE() > 467f)
		{
			if (null != this.liveEventLocked)
			{
				this.liveEventLocked.gameObject.SetActive(false);
				if (null != this.liveEventLockedTimerText)
				{
					this.liveEventLockedTimerText.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)FNJJIPNFCMK.IACMODHPFKI.ODBOJGMLKHA()), true);
				}
				if (!this.FAGLGFFKCBK)
				{
					this.liveEventLocked.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(0, -15);
					this.message.GetComponent<RectTransform>().AHLJBONHHKL(0, 36);
					this.FAGLGFFKCBK = true;
				}
			}
			else
			{
				this.openPopUpButton.gameObject.SetActive(false);
			}
			this.openPopUpTimerText.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)FNJJIPNFCMK.IACMODHPFKI.LFLAIPLKINK()), true);
			return;
		}
		this.KDCFJNEBDDC = false;
		this.openFocusButton.gameObject.SetActive(true);
		switch (FNJJIPNFCMK.KONDFFEKAND)
		{
		case EGMCEPOABBF.liveEventMessage:
			this.HJBMNLBOEAL = true;
			return;
		case EGMCEPOABBF.liveEventFreeTea:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeDiamonds:
			this.tagTimerCurrentValue.gameObject.SetActive(true);
			return;
		case EGMCEPOABBF.liveEventFreeStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventBonusStory:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		case EGMCEPOABBF.liveEventFreeAvatar:
			this.tagTimerCurrentValue.gameObject.SetActive(false);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600654E RID: 25934 RVA: 0x002F3DA2 File Offset: 0x002F1FA2
	private void AOOANKECKCJ()
	{
		this.FAGLGFFKCBK = true;
		if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 373f;
		}
	}

	// Token: 0x0600654F RID: 25935 RVA: 0x002F12E2 File Offset: 0x002EF4E2
	private void HPIAJKIMIDB()
	{
		this.GFGDNJIEAEN();
	}

	// Token: 0x06006550 RID: 25936 RVA: 0x002F3DDC File Offset: 0x002F1FDC
	private void JIHGCMLJFGD()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006551 RID: 25937 RVA: 0x002F3E18 File Offset: 0x002F2018
	private void GFJBNGMOBAC()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(781f, 122f, 282f, 1949f);
		}
	}

	// Token: 0x06006552 RID: 25938 RVA: 0x002F3E54 File Offset: 0x002F2054
	public void JOFDDDOCNHE()
	{
		if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 52f;
			}
			this.stroke.NFIPIOOJPEK(1555f, 668f, 1530f, Ease.Unset, null);
		}
	}

	// Token: 0x06006553 RID: 25939 RVA: 0x002F3EAC File Offset: 0x002F20AC
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
	}

	// Token: 0x06006554 RID: 25940 RVA: 0x002F3F04 File Offset: 0x002F2104
	private void EDANCCNNDMN()
	{
		if (null != this.innerShadow)
		{
			this.innerShadow.GetComponent<Image>().color = new Color(815f, 171f, 947f, 1547f);
		}
	}

	// Token: 0x06006555 RID: 25941 RVA: 0x002F3F40 File Offset: 0x002F2140
	private void EBDMOGAGPBD()
	{
		try
		{
			Application.OpenURL(DPGJIJGOCIC.LMCAODJLEGF(this.FNJJIPNFCMK.CNCGCBFFFEM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006556 RID: 25942 RVA: 0x002F0F0C File Offset: 0x002EF10C
	private void MOJCLFJDODP()
	{
		this.LFELBKAGFDM();
	}

	// Token: 0x06006557 RID: 25943 RVA: 0x002F3F7C File Offset: 0x002F217C
	public void BEJJFDDCAJD()
	{
		if (this.FNJJIPNFCMK.EFEMAKCKEBP == 0)
		{
			this.message.gameObject.SetActive(true);
			this.message.text = GKJPOGNFKNK.DNILNCLIHAP("tradewishcardoption0" + this.index.ToString(), "OnPopupOfferManagerContinueToPurchasingScreen", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.message.SetText(GKJPOGNFKNK.DNILNCLIHAP("YYY" + this.index.ToString(), "avatarstitle", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
			this.messageV2.gameObject.SetActive(false);
		}
		else
		{
			this.messageV2.gameObject.SetActive(false);
			this.messageV2.text = GKJPOGNFKNK.DNILNCLIHAP("<" + this.index.ToString(), "congratstitle", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			this.messageV2.SetText(GKJPOGNFKNK.DNILNCLIHAP("continue" + this.index.ToString(), "blur", LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
			this.message.gameObject.SetActive(false);
		}
		if (this.FHGEBHKPBLO)
		{
			this.tagTimerEndText.SetText(CCOJBMMKNAP.KMNBCEMEBBD().IKMNGFIDCLM("no"), true);
		}
	}

	// Token: 0x06006558 RID: 25944 RVA: 0x002F40D7 File Offset: 0x002F22D7
	[CompilerGenerated]
	private void OGMMGLPOGOH()
	{
		this.DOLBMCHKFPM();
	}

	// Token: 0x06006559 RID: 25945 RVA: 0x002F40DF File Offset: 0x002F22DF
	private void DHEBDHMNDFF()
	{
		this.EBDMOGAGPBD();
	}

	// Token: 0x0600655A RID: 25946 RVA: 0x002F40D7 File Offset: 0x002F22D7
	private void HHPLKFDEHEF()
	{
		this.DOLBMCHKFPM();
	}

	// Token: 0x0600655B RID: 25947 RVA: 0x002F40E7 File Offset: 0x002F22E7
	private void OPBNOGLBNDK()
	{
		this.FAGLGFFKCBK = true;
		if (KHPGPLAMAIN.AKJOFJPLONG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1443f;
		}
	}

	// Token: 0x0600655C RID: 25948 RVA: 0x002F4120 File Offset: 0x002F2320
	public void PLOCBKBONOL()
	{
		if (KHPGPLAMAIN.FCJHEFBIKID() != IIHCCPLGGHP.highEnd)
		{
			if (this.stroke.GetComponent<CanvasGroup>() != null)
			{
				this.stroke.GetComponent<CanvasGroup>().alpha = 1260f;
			}
			this.stroke.NFIPIOOJPEK(727f, 1841f, 484f, Ease.Unset, null);
		}
	}

	// Token: 0x0600655D RID: 25949 RVA: 0x002F4178 File Offset: 0x002F2378
	public void DCIDHANMBJH(Transform IPEADDNJLAO, float LILDMOONHPB)
	{
		if (KHPGPLAMAIN.AKJOFJPLONG() != IIHCCPLGGHP.highEnd && this.stroke.GetComponent<CanvasGroup>() != null)
		{
			this.stroke.GetComponent<CanvasGroup>().alpha = 1091f;
		}
		this.stroke.NFIPIOOJPEK(487f, 307f, 434f, Ease.Linear, null);
		this.flash.NFIPIOOJPEK(731f, 1404f, LILDMOONHPB, Ease.OutCirc, null);
	}

	// Token: 0x04001D3A RID: 7482
	[HideInInspector]
	public int index;

	// Token: 0x04001D3B RID: 7483
	public Image thumbnail;

	// Token: 0x04001D3C RID: 7484
	public Image logo;

	// Token: 0x04001D3D RID: 7485
	public Image stroke;

	// Token: 0x04001D3E RID: 7486
	public Image flash;

	// Token: 0x04001D3F RID: 7487
	public GameObject tagTimerCurrentValue;

	// Token: 0x04001D40 RID: 7488
	public TextMeshProUGUI tagTimerText;

	// Token: 0x04001D41 RID: 7489
	public GameObject tagTimerEnd;

	// Token: 0x04001D42 RID: 7490
	public TextMeshProUGUI tagTimerEndText;

	// Token: 0x04001D43 RID: 7491
	public TextMeshProUGUI itemTagText;

	// Token: 0x04001D44 RID: 7492
	public TextMeshProUGUI message;

	// Token: 0x04001D45 RID: 7493
	public TextMeshProUGUI messageV2;

	// Token: 0x04001D46 RID: 7494
	public Button openFocusButton;

	// Token: 0x04001D47 RID: 7495
	public Button openPopUpButton;

	// Token: 0x04001D48 RID: 7496
	public TextMeshProUGUI openPopUpTimerText;

	// Token: 0x04001D49 RID: 7497
	public GameObject innerShadow;

	// Token: 0x04001D4A RID: 7498
	public Button liveEventLocked;

	// Token: 0x04001D4B RID: 7499
	public TextMeshProUGUI liveEventLockedTimerText;

	// Token: 0x04001D4C RID: 7500
	private OKAFAHMOFII FNJJIPNFCMK;

	// Token: 0x04001D4D RID: 7501
	private bool FHGEBHKPBLO;

	// Token: 0x04001D4E RID: 7502
	private bool KDCFJNEBDDC;

	// Token: 0x04001D4F RID: 7503
	private bool HJBMNLBOEAL;

	// Token: 0x04001D50 RID: 7504
	private bool FAGLGFFKCBK;
}
