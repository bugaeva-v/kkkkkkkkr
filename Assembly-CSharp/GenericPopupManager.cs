using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000518 RID: 1304
public class GenericPopupManager : MonoBehaviour
{
	// Token: 0x06009CDC RID: 40156 RVA: 0x0043D5A4 File Offset: 0x0043B7A4
	public GenericPopupManager HFCNMFIAIEF(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.MMEFCDCGBBE));
		}
		return this;
	}

	// Token: 0x06009CDD RID: 40157 RVA: 0x0043D5D8 File Offset: 0x0043B7D8
	private void ANFMGKPGBOL()
	{
		if (this.CPDFJCNPBNB != null)
		{
			this.CPDFJCNPBNB();
		}
	}

	// Token: 0x06009CDE RID: 40158 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void ABDAHENHPNA()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009CDF RID: 40159 RVA: 0x0043D602 File Offset: 0x0043B802
	public GenericPopupManager BFJJODCMEKN(UnityAction OMOOOGBDDDG)
	{
		this.ODDPLCPPDMI = OMOOOGBDDDG;
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.JFOLJKDKCBL));
		}
		return this;
	}

	// Token: 0x06009CE0 RID: 40160 RVA: 0x0043D636 File Offset: 0x0043B836
	private void JBCEHONENAL()
	{
		if (this.ODDPLCPPDMI != null)
		{
			this.ODDPLCPPDMI();
		}
	}

	// Token: 0x06009CE1 RID: 40161 RVA: 0x0043D64B File Offset: 0x0043B84B
	public GenericPopupManager FMCNJGOGFOJ(UnityAction OMOOOGBDDDG)
	{
		this.CPDFJCNPBNB = OMOOOGBDDDG;
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.EBCKHGEMJMB));
		}
		return this;
	}

	// Token: 0x06009CE2 RID: 40162 RVA: 0x0043D67F File Offset: 0x0043B87F
	public void ECMBPPOCLPP()
	{
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009CE3 RID: 40163 RVA: 0x0043D6A0 File Offset: 0x0043B8A0
	private void LFOJBMBCOFP()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.SetActive(true);
			this.imageDiamonds.transform.parent.gameObject.SetActive(false);
		}
		if (null != this.imageEnergy)
		{
			this.imageEnergy.SetActive(true);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(true);
		}
		if (null != this.textBody)
		{
			this.GNNJMPHGJKA = (int)this.textBody.fontSize;
		}
		if (null != this.avatarObject)
		{
			this.avatarObject.SetActive(false);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 1; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(true);
				}
			}
		}
		if (null != this.discountObjectButtonPositive)
		{
			this.discountObjectButtonPositive.SetActive(true);
		}
		if (null != this.discountObjectButtonNegative)
		{
			this.discountObjectButtonNegative.SetActive(true);
		}
	}

	// Token: 0x06009CE4 RID: 40164 RVA: 0x0043D82B File Offset: 0x0043BA2B
	private void NKEAELEKMOD()
	{
		if (this.ACLLHEAGKCB != null)
		{
			this.ACLLHEAGKCB();
		}
	}

	// Token: 0x06009CE5 RID: 40165 RVA: 0x0043D840 File Offset: 0x0043BA40
	public GenericPopupManager IJLBKILDAAO(UnityAction OMOOOGBDDDG)
	{
		this.CPDFJCNPBNB = OMOOOGBDDDG;
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.ANFMGKPGBOL));
		}
		return this;
	}

	// Token: 0x06009CE6 RID: 40166 RVA: 0x0043D874 File Offset: 0x0043BA74
	public GenericPopupManager AHIJBIKNMOC(UnityAction OMOOOGBDDDG)
	{
		this.MNOBHOPILHO = OMOOOGBDDDG;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.AddListener(new UnityAction(this.HAHIMBJMJDM));
		}
		return this;
	}

	// Token: 0x06009CE7 RID: 40167 RVA: 0x0043D8A8 File Offset: 0x0043BAA8
	private void PIICEDDMBJH()
	{
		if (this.CEOHNGJNBKD != null)
		{
			this.CEOHNGJNBKD();
		}
	}

	// Token: 0x06009CE8 RID: 40168 RVA: 0x0043D8C0 File Offset: 0x0043BAC0
	public GenericPopupManager ShowLiveAvatar(int HCHHHANKIIB)
	{
		if (null != this.avatarObject && null != this.avatarImageThumb && AssetsManager.EHBBFMCILPC.liveProfileThemesAssets.Count > 0 && null != GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB))
		{
			this.avatarObject.SetActive(true);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 0; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(true);
				}
			}
			if (this.avatarImageThumb.GetComponent<ImageFrameAnimation>() == null)
			{
				ImageFrameAnimation imageFrameAnimation = this.avatarImageThumb.gameObject.AddComponent<ImageFrameAnimation>();
				imageFrameAnimation.framesSD = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).frames.ToArray();
				imageFrameAnimation.pauseTime = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).pauseTime;
				imageFrameAnimation.pauseFrame = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).pauseFrame;
				imageFrameAnimation.frameChangeInterval = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).frameChangeInterval;
				imageFrameAnimation.reverseDirection = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).reverseDirection;
			}
			else
			{
				this.avatarImageThumb.GetComponent<ImageFrameAnimation>().framesSD = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).frames.ToArray();
				this.avatarImageThumb.GetComponent<ImageFrameAnimation>().pauseTime = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).pauseTime;
				this.avatarImageThumb.GetComponent<ImageFrameAnimation>().pauseFrame = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).pauseFrame;
				this.avatarImageThumb.GetComponent<ImageFrameAnimation>().frameChangeInterval = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).frameChangeInterval;
				this.avatarImageThumb.GetComponent<ImageFrameAnimation>().reverseDirection = GKJPOGNFKNK.NHBPDOOHKGD(HCHHHANKIIB).reverseDirection;
			}
		}
		return this;
	}

	// Token: 0x06009CE9 RID: 40169 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void HAHIMBJMJDM()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009CEA RID: 40170 RVA: 0x0043DA5F File Offset: 0x0043BC5F
	public GenericPopupManager CDFGIAGPBDJ(UnityAction OMOOOGBDDDG)
	{
		this.FLPDCPBAICE = OMOOOGBDDDG;
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.PPFIDELHMFH));
		}
		return this;
	}

	// Token: 0x06009CEB RID: 40171 RVA: 0x000022C3 File Offset: 0x000004C3
	private void MGGGJDMJPPK()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06009CEC RID: 40172 RVA: 0x0043DA93 File Offset: 0x0043BC93
	public GenericPopupManager MHMHGHCDHGE()
	{
		this.MDHECJDJIBK = true;
		return this;
	}

	// Token: 0x06009CED RID: 40173 RVA: 0x0043DA9D File Offset: 0x0043BC9D
	public void DHOLMNNGHAP()
	{
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(true);
		}
	}

	// Token: 0x06009CEE RID: 40174 RVA: 0x0043DABE File Offset: 0x0043BCBE
	public void ShowOneButton(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH)
	{
		base.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(CAGMDHNGAEH, true);
	}

	// Token: 0x06009CEF RID: 40175 RVA: 0x0043DAF4 File Offset: 0x0043BCF4
	public GenericPopupManager BLJNPPEBANE(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.EDDPKNELODD));
		}
		return this;
	}

	// Token: 0x06009CF0 RID: 40176 RVA: 0x0043D5A4 File Offset: 0x0043B7A4
	public GenericPopupManager BCCKLBLIKNK(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.MMEFCDCGBBE));
		}
		return this;
	}

	// Token: 0x06009CF1 RID: 40177 RVA: 0x0043DB60 File Offset: 0x0043BD60
	public void ShowNoButtons(string EEMPGLHPKJG, string DPJINBCGNGN)
	{
		base.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(false);
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009CF2 RID: 40178 RVA: 0x0043DBD1 File Offset: 0x0043BDD1
	private void BHMGFONNGDK()
	{
		if (this.FLPDCPBAICE != null)
		{
			this.FLPDCPBAICE();
		}
	}

	// Token: 0x06009CF3 RID: 40179 RVA: 0x0043D636 File Offset: 0x0043B836
	private void AMHCFFLAPDO()
	{
		if (this.ODDPLCPPDMI != null)
		{
			this.ODDPLCPPDMI();
		}
	}

	// Token: 0x06009CF4 RID: 40180 RVA: 0x0043DBE8 File Offset: 0x0043BDE8
	public GenericPopupManager SetOnClickListenerButtonNegativeAndClose(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		return this;
	}

	// Token: 0x06009CF5 RID: 40181 RVA: 0x0043DC51 File Offset: 0x0043BE51
	public GenericPopupManager AHPHFJANGLB(UnityAction OMOOOGBDDDG)
	{
		this.FLPDCPBAICE = OMOOOGBDDDG;
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.ALJNHBELKBO));
		}
		return this;
	}

	// Token: 0x06009CF6 RID: 40182 RVA: 0x0043DC88 File Offset: 0x0043BE88
	public void ILDNABGINLB(int ILNKINMLHOG)
	{
		this.FPELIMEJCLD = ILNKINMLHOG;
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.transform.parent.gameObject.SetActive(false);
			this.imageDiamonds.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
			if (ILNKINMLHOG > 0)
			{
				this.textDiamonds.SetText("" + ILNKINMLHOG.ToString(), true);
				return;
			}
			this.textDiamonds.SetText(ILNKINMLHOG.ToString(), true);
		}
	}

	// Token: 0x06009CF7 RID: 40183 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void DJEMNINICGH()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009CF8 RID: 40184 RVA: 0x0043DD28 File Offset: 0x0043BF28
	public GenericPopupManager MHAMHBFGMHG(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.PIICEDDMBJH));
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		return this;
	}

	// Token: 0x06009CF9 RID: 40185 RVA: 0x0043D5A4 File Offset: 0x0043B7A4
	public GenericPopupManager PCMIOHEOLBG(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.MMEFCDCGBBE));
		}
		return this;
	}

	// Token: 0x06009CFA RID: 40186 RVA: 0x00172562 File Offset: 0x00170762
	public void HideSilent()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009CFB RID: 40187 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void AGDCAJFIEAO()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009CFC RID: 40188 RVA: 0x0043D82B File Offset: 0x0043BA2B
	private void CEIAJBFEKPO()
	{
		if (this.ACLLHEAGKCB != null)
		{
			this.ACLLHEAGKCB();
		}
	}

	// Token: 0x06009CFD RID: 40189 RVA: 0x0043DD94 File Offset: 0x0043BF94
	public void FKDBLIPDBAP(string EEMPGLHPKJG, string DPJINBCGNGN)
	{
		base.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(false);
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009CFE RID: 40190 RVA: 0x0043DE05 File Offset: 0x0043C005
	public GenericPopupManager SetOnClickListenerButtonNegative(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		return this;
	}

	// Token: 0x06009CFF RID: 40191 RVA: 0x0043DE3C File Offset: 0x0043C03C
	private void OnEnable()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(false);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.SetActive(false);
			this.imageDiamonds.transform.parent.gameObject.SetActive(false);
		}
		if (null != this.imageEnergy)
		{
			this.imageEnergy.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(false);
		}
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(true);
			this.buttonPositive.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.gameObject.SetActive(false);
			this.buttonNegative.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.gameObject.SetActive(false);
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.gameObject.SetActive(false);
			this.buttonOptional2.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.gameObject.SetActive(false);
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(true);
			this.buttonClose.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.discountObjectButtonPositive)
		{
			this.discountObjectButtonPositive.SetActive(false);
		}
		if (null != this.discountObjectButtonNegative)
		{
			this.discountObjectButtonNegative.SetActive(false);
		}
		if (this.FPELIMEJCLD >= 0)
		{
			this.ShowDiamonds(this.FPELIMEJCLD);
		}
		if (this.DAEHADAKJAL >= 0)
		{
			this.ShowEnergy(this.DAEHADAKJAL);
		}
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x06009D00 RID: 40192 RVA: 0x0043E10C File Offset: 0x0043C30C
	public void ShowThreeButtons(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(true);
		this.buttonOptional2.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, true);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
	}

	// Token: 0x06009D01 RID: 40193 RVA: 0x0043E18A File Offset: 0x0043C38A
	public void BAKHIAFPBJJ(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH)
	{
		base.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(CAGMDHNGAEH, true);
	}

	// Token: 0x06009D02 RID: 40194 RVA: 0x0043E1C0 File Offset: 0x0043C3C0
	public GenericPopupManager SetDiscountValues(int ODFLBHNBHDA, int FCHINHEKNAJ)
	{
		this.JEMLEINMLEE = true;
		if (null != this.discountObjectButtonPositive && null != this.discountTextButtonPositive && ODFLBHNBHDA > 0)
		{
			this.discountTextButtonPositive.text = "-" + ODFLBHNBHDA.ToString() + "%";
			this.discountTextButtonPositive.SetText("-" + ODFLBHNBHDA.ToString() + "%", true);
		}
		if (null != this.discountObjectButtonNegative && null != this.discountTextButtonNegative && FCHINHEKNAJ > 0)
		{
			this.discountTextButtonNegative.text = "-" + FCHINHEKNAJ.ToString() + "%";
			this.discountTextButtonNegative.SetText("-" + FCHINHEKNAJ.ToString() + "%", true);
		}
		return this;
	}

	// Token: 0x06009D03 RID: 40195 RVA: 0x0043DA5F File Offset: 0x0043BC5F
	public GenericPopupManager SetOnClickListenerButtonOptional1(UnityAction OMOOOGBDDDG)
	{
		this.FLPDCPBAICE = OMOOOGBDDDG;
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.PPFIDELHMFH));
		}
		return this;
	}

	// Token: 0x06009D04 RID: 40196 RVA: 0x0043E29C File Offset: 0x0043C49C
	public void LGEKPJCJBME(int ILNKINMLHOG)
	{
		this.DAEHADAKJAL = ILNKINMLHOG;
		if (null != this.imageEnergy)
		{
			this.imageEnergy.transform.parent.gameObject.SetActive(false);
			this.imageEnergy.SetActive(true);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(true);
			if (ILNKINMLHOG > 0)
			{
				this.textEnergy.SetText("serversync" + ILNKINMLHOG.ToString(), false);
				return;
			}
			this.textEnergy.SetText(ILNKINMLHOG.ToString(), true);
		}
	}

	// Token: 0x06009D05 RID: 40197 RVA: 0x0043E33C File Offset: 0x0043C53C
	public void BIMCNGLLIOC()
	{
		if (base.gameObject.activeSelf)
		{
			if (this.MDHECJDJIBK)
			{
				this.MDHECJDJIBK = false;
				this.KJNANICCHJN();
			}
			if (this.JEMLEINMLEE)
			{
				this.JEMLEINMLEE = true;
				if (null != this.discountObjectButtonPositive)
				{
					this.discountObjectButtonPositive.SetActive(true);
				}
				if (null != this.discountObjectButtonNegative)
				{
					this.discountObjectButtonNegative.SetActive(false);
				}
			}
			if (this.FEHNOGLEANE)
			{
				this.FEHNOGLEANE = true;
				this.DHOLMNNGHAP();
			}
		}
	}

	// Token: 0x06009D06 RID: 40198 RVA: 0x0043DBD1 File Offset: 0x0043BDD1
	private void ALJNHBELKBO()
	{
		if (this.FLPDCPBAICE != null)
		{
			this.FLPDCPBAICE();
		}
	}

	// Token: 0x06009D07 RID: 40199 RVA: 0x0043E3C3 File Offset: 0x0043C5C3
	public GenericPopupManager AICHJLKOOEH(UnityAction OMOOOGBDDDG)
	{
		this.FLPDCPBAICE = OMOOOGBDDDG;
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.INMHIPIPKIG));
		}
		return this;
	}

	// Token: 0x06009D08 RID: 40200 RVA: 0x0043E3F8 File Offset: 0x0043C5F8
	private void CIKEMCBEBAK()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D09 RID: 40201 RVA: 0x0043E458 File Offset: 0x0043C658
	public void ShowDiamonds(int ILNKINMLHOG)
	{
		this.FPELIMEJCLD = ILNKINMLHOG;
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.transform.parent.gameObject.SetActive(true);
			this.imageDiamonds.SetActive(true);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(true);
			if (ILNKINMLHOG > 0)
			{
				this.textDiamonds.SetText("+" + ILNKINMLHOG.ToString(), true);
				return;
			}
			this.textDiamonds.SetText(ILNKINMLHOG.ToString(), true);
		}
	}

	// Token: 0x06009D0A RID: 40202 RVA: 0x000022C3 File Offset: 0x000004C3
	private void JPFMJFNICLG()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06009D0B RID: 40203 RVA: 0x0043E4F5 File Offset: 0x0043C6F5
	public GenericPopupManager SetOnClickListenerButtonOptional2(UnityAction OMOOOGBDDDG)
	{
		this.ACLLHEAGKCB = OMOOOGBDDDG;
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.AddListener(new UnityAction(this.CEIAJBFEKPO));
		}
		return this;
	}

	// Token: 0x06009D0C RID: 40204 RVA: 0x0043E52C File Offset: 0x0043C72C
	public void SetMaxButtonsTextsSize(int AJPNGBLHOEC)
	{
		this.AFMAOCPBLNC = AJPNGBLHOEC;
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonNegative.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
	}

	// Token: 0x06009D0D RID: 40205 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06009D0E RID: 40206 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void PBLGKKKKOFE()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009D0F RID: 40207 RVA: 0x0043E594 File Offset: 0x0043C794
	private void Awake()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(false);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.SetActive(false);
			this.imageDiamonds.transform.parent.gameObject.SetActive(false);
		}
		if (null != this.imageEnergy)
		{
			this.imageEnergy.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(false);
		}
		if (null != this.textBody)
		{
			this.GNNJMPHGJKA = (int)this.textBody.fontSize;
		}
		if (null != this.avatarObject)
		{
			this.avatarObject.SetActive(false);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 0; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(false);
				}
			}
		}
		if (null != this.discountObjectButtonPositive)
		{
			this.discountObjectButtonPositive.SetActive(false);
		}
		if (null != this.discountObjectButtonNegative)
		{
			this.discountObjectButtonNegative.SetActive(false);
		}
	}

	// Token: 0x06009D10 RID: 40208 RVA: 0x0043E720 File Offset: 0x0043C920
	private void MFFLJDMOMPD()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(true);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(false);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(true);
		}
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.SetActive(false);
			this.imageDiamonds.transform.parent.gameObject.SetActive(true);
		}
		if (null != this.imageEnergy)
		{
			this.imageEnergy.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(true);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(false);
		}
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(true);
			this.buttonPositive.onClick.AddListener(new UnityAction(this.DDPHFKOHDJB));
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.gameObject.SetActive(true);
			this.buttonNegative.onClick.AddListener(new UnityAction(this.JECNOPCOOCJ));
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.gameObject.SetActive(true);
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.Hide));
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.gameObject.SetActive(true);
			this.buttonOptional2.onClick.AddListener(new UnityAction(this.DDPHFKOHDJB));
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.gameObject.SetActive(true);
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.ADAJPNHIICL));
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
			this.buttonClose.onClick.AddListener(new UnityAction(this.JECNOPCOOCJ));
		}
		if (null != this.discountObjectButtonPositive)
		{
			this.discountObjectButtonPositive.SetActive(false);
		}
		if (null != this.discountObjectButtonNegative)
		{
			this.discountObjectButtonNegative.SetActive(true);
		}
		if (this.FPELIMEJCLD >= 1)
		{
			this.ECCFLOFCFNN(this.FPELIMEJCLD);
		}
		if (this.DAEHADAKJAL >= 0)
		{
			this.LGEKPJCJBME(this.DAEHADAKJAL);
		}
		AOBJLALDBAA.BIAEAOMHBMM().EFKNEJFLGED("p", new UnityAction(this.MGPHKHGMNMA));
	}

	// Token: 0x06009D11 RID: 40209 RVA: 0x0043E9EE File Offset: 0x0043CBEE
	public void JECNOPCOOCJ()
	{
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("wofbutton3", 947f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009D12 RID: 40210 RVA: 0x0043EA10 File Offset: 0x0043CC10
	public GenericPopupManager HPKCABEOKAE(UnityAction OMOOOGBDDDG)
	{
		this.ODDPLCPPDMI = OMOOOGBDDDG;
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.JBCEHONENAL));
		}
		return this;
	}

	// Token: 0x06009D13 RID: 40211 RVA: 0x0043DBD1 File Offset: 0x0043BDD1
	private void OFDLFLLLDJN()
	{
		if (this.FLPDCPBAICE != null)
		{
			this.FLPDCPBAICE();
		}
	}

	// Token: 0x06009D14 RID: 40212 RVA: 0x0043EA44 File Offset: 0x0043CC44
	private void OJIOGKJEBMM()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		if (null != this.avatarObject)
		{
			this.KDCIBIABJBK();
			this.avatarObject.SetActive(true);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 1; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(true);
				}
			}
		}
		this.FPELIMEJCLD = -1;
		this.DAEHADAKJAL = -1;
		this.MNOBHOPILHO = null;
		this.CEOHNGJNBKD = null;
		this.ODDPLCPPDMI = null;
		this.FLPDCPBAICE = null;
		this.ACLLHEAGKCB = null;
		this.CPDFJCNPBNB = null;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.RemoveAllListeners();
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.RemoveAllListeners();
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.RemoveAllListeners();
		}
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)this.GNNJMPHGJKA;
		}
		if (AppManager.isQuitting)
		{
			return;
		}
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonNegative.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		this.AFMAOCPBLNC = -1;
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("/", new UnityAction(this.MGPHKHGMNMA));
	}

	// Token: 0x06009D15 RID: 40213 RVA: 0x0043D82B File Offset: 0x0043BA2B
	private void PIPDMGMLKPO()
	{
		if (this.ACLLHEAGKCB != null)
		{
			this.ACLLHEAGKCB();
		}
	}

	// Token: 0x06009D16 RID: 40214 RVA: 0x0043EC30 File Offset: 0x0043CE30
	public void DFBMOKLDCJN(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(false);
		this.buttonOptional3.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, true);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, true);
	}

	// Token: 0x06009D17 RID: 40215 RVA: 0x0043ECD0 File Offset: 0x0043CED0
	private void KDCIBIABJBK()
	{
		if (null != this.avatarImageThumb)
		{
			this.avatarImageThumb.GetComponent<Image>().sprite = null;
			ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
			if (component != null)
			{
				UnityEngine.Object.Destroy(component);
			}
		}
	}

	// Token: 0x06009D18 RID: 40216 RVA: 0x0043ED18 File Offset: 0x0043CF18
	public void MJGMOLANPEG(int AJPNGBLHOEC)
	{
		this.AFMAOCPBLNC = AJPNGBLHOEC;
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonPositive.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonNegative.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
	}

	// Token: 0x06009D19 RID: 40217 RVA: 0x0043ED7E File Offset: 0x0043CF7E
	public void BAGMHMBFOLF(int NJPIKMAANJP)
	{
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)NJPIKMAANJP;
		}
	}

	// Token: 0x06009D1A RID: 40218 RVA: 0x0043ED9B File Offset: 0x0043CF9B
	public void ShowDiamondsAndEnergy(int HCPDCKEAIKK, int BMFFHLMALED)
	{
		this.FPELIMEJCLD = HCPDCKEAIKK;
		this.DAEHADAKJAL = BMFFHLMALED;
		this.ShowDiamonds(HCPDCKEAIKK);
		this.ShowEnergy(BMFFHLMALED);
	}

	// Token: 0x06009D1B RID: 40219 RVA: 0x0043EDB9 File Offset: 0x0043CFB9
	public void OHBKNAEFDBP(int HCPDCKEAIKK, int BMFFHLMALED)
	{
		this.FPELIMEJCLD = HCPDCKEAIKK;
		this.DAEHADAKJAL = BMFFHLMALED;
		this.ILDNABGINLB(HCPDCKEAIKK);
		this.LGEKPJCJBME(BMFFHLMALED);
	}

	// Token: 0x06009D1C RID: 40220 RVA: 0x0043D5D8 File Offset: 0x0043B7D8
	private void AGOLBIMHJFJ()
	{
		if (this.CPDFJCNPBNB != null)
		{
			this.CPDFJCNPBNB();
		}
	}

	// Token: 0x06009D1D RID: 40221 RVA: 0x00002296 File Offset: 0x00000496
	private void NNGMEPKMIIM()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06009D1E RID: 40222 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void DIEEEBEBAFL()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009D1F RID: 40223 RVA: 0x0043EDD8 File Offset: 0x0043CFD8
	public void AJIPBMGPDML(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA)
	{
		base.gameObject.SetActive(false);
		this.buttonNegative.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(FNEAAEFOOEJ, true);
		this.textButtonNegative.SetText(MCDCGPAADJA, false);
	}

	// Token: 0x06009D20 RID: 40224 RVA: 0x0043EE38 File Offset: 0x0043D038
	public void NCIKIGKIBOL(int AJPNGBLHOEC)
	{
		this.AFMAOCPBLNC = AJPNGBLHOEC;
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonPositive.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonNegative.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
	}

	// Token: 0x06009D21 RID: 40225 RVA: 0x0043EE9E File Offset: 0x0043D09E
	public GenericPopupManager CBCKHJAMJKC(UnityAction OMOOOGBDDDG)
	{
		this.MNOBHOPILHO = OMOOOGBDDDG;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.AddListener(new UnityAction(this.MODKKCIONOK));
		}
		return this;
	}

	// Token: 0x06009D22 RID: 40226 RVA: 0x0043EED4 File Offset: 0x0043D0D4
	private void BAPDLJCHCDI()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(true);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D23 RID: 40227 RVA: 0x0043D636 File Offset: 0x0043B836
	private void FIELFIIFGJF()
	{
		if (this.ODDPLCPPDMI != null)
		{
			this.ODDPLCPPDMI();
		}
	}

	// Token: 0x06009D24 RID: 40228 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void MLAFJMNPMJE()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009D25 RID: 40229 RVA: 0x0043D67F File Offset: 0x0043B87F
	public void _HideCloseButton()
	{
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D26 RID: 40230 RVA: 0x0043EF34 File Offset: 0x0043D134
	private void OnDisable()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		if (null != this.avatarObject)
		{
			this.KDCIBIABJBK();
			this.avatarObject.SetActive(false);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 0; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(false);
				}
			}
		}
		this.FPELIMEJCLD = -1;
		this.DAEHADAKJAL = -1;
		this.MNOBHOPILHO = null;
		this.CEOHNGJNBKD = null;
		this.ODDPLCPPDMI = null;
		this.FLPDCPBAICE = null;
		this.ACLLHEAGKCB = null;
		this.CPDFJCNPBNB = null;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.RemoveAllListeners();
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.RemoveAllListeners();
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.RemoveAllListeners();
		}
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)this.GNNJMPHGJKA;
		}
		if (AppManager.isQuitting)
		{
			return;
		}
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonNegative.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		this.AFMAOCPBLNC = -1;
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnSystemBackButton", new UnityAction(this.OnSystemBackButton));
	}

	// Token: 0x06009D27 RID: 40231 RVA: 0x0043F11F File Offset: 0x0043D31F
	public GenericPopupManager SetOnClickListenerButtonClose(UnityAction OMOOOGBDDDG)
	{
		this.ODDPLCPPDMI = OMOOOGBDDDG;
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.AMHCFFLAPDO));
		}
		return this;
	}

	// Token: 0x06009D28 RID: 40232 RVA: 0x0043F154 File Offset: 0x0043D354
	public void MDHJEDLMFOA()
	{
		if (base.gameObject.activeSelf)
		{
			if (this.MDHECJDJIBK)
			{
				this.MDHECJDJIBK = false;
				this.BAPDLJCHCDI();
			}
			if (this.JEMLEINMLEE)
			{
				this.JEMLEINMLEE = false;
				if (null != this.discountObjectButtonPositive)
				{
					this.discountObjectButtonPositive.SetActive(true);
				}
				if (null != this.discountObjectButtonNegative)
				{
					this.discountObjectButtonNegative.SetActive(true);
				}
			}
			if (this.FEHNOGLEANE)
			{
				this.FEHNOGLEANE = false;
				this._HideCloseButton();
			}
		}
	}

	// Token: 0x06009D29 RID: 40233 RVA: 0x0043D64B File Offset: 0x0043B84B
	public GenericPopupManager CKFAGDPNFJM(UnityAction OMOOOGBDDDG)
	{
		this.CPDFJCNPBNB = OMOOOGBDDDG;
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.EBCKHGEMJMB));
		}
		return this;
	}

	// Token: 0x06009D2A RID: 40234 RVA: 0x0043D82B File Offset: 0x0043BA2B
	private void NHENINMPFJK()
	{
		if (this.ACLLHEAGKCB != null)
		{
			this.ACLLHEAGKCB();
		}
	}

	// Token: 0x06009D2B RID: 40235 RVA: 0x0043F1DC File Offset: 0x0043D3DC
	public void EOLJFEBPGHF(string EEMPGLHPKJG, string DPJINBCGNGN)
	{
		base.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(false);
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D2C RID: 40236 RVA: 0x0043F24D File Offset: 0x0043D44D
	public void MGPHKHGMNMA()
	{
		this.KEGLFLIHIJC();
	}

	// Token: 0x06009D2D RID: 40237 RVA: 0x0043F255 File Offset: 0x0043D455
	public void NAFJFAGAAGA()
	{
		this.JECNOPCOOCJ();
	}

	// Token: 0x06009D2E RID: 40238 RVA: 0x0043F260 File Offset: 0x0043D460
	public void FGPJGMHOMBN(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(false);
		this.buttonOptional1.gameObject.SetActive(true);
		this.buttonOptional2.gameObject.SetActive(false);
		this.buttonOptional3.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, false);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, false);
	}

	// Token: 0x06009D2F RID: 40239 RVA: 0x0043F300 File Offset: 0x0043D500
	public void CLGNDECNBKI(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(true);
		this.buttonOptional3.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, false);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, false);
	}

	// Token: 0x06009D30 RID: 40240 RVA: 0x0043F39D File Offset: 0x0043D59D
	public void PNOJCLJKBPO(string EEMPGLHPKJG, string DPJINBCGNGN, string CAGMDHNGAEH)
	{
		base.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(CAGMDHNGAEH, false);
	}

	// Token: 0x06009D31 RID: 40241 RVA: 0x0043F3D4 File Offset: 0x0043D5D4
	public void HDONDKPLIGM(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(true);
		this.buttonOptional2.gameObject.SetActive(true);
		this.buttonOptional3.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, false);
	}

	// Token: 0x06009D32 RID: 40242 RVA: 0x0043F471 File Offset: 0x0043D671
	public void Hide()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnGenericPopupManagerHide", 0f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009D33 RID: 40243 RVA: 0x0043D636 File Offset: 0x0043B836
	private void JJGONBMEOLL()
	{
		if (this.ODDPLCPPDMI != null)
		{
			this.ODDPLCPPDMI();
		}
	}

	// Token: 0x06009D34 RID: 40244 RVA: 0x0043ED7E File Offset: 0x0043CF7E
	public void SetFontSize(int NJPIKMAANJP)
	{
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)NJPIKMAANJP;
		}
	}

	// Token: 0x06009D35 RID: 40245 RVA: 0x0043F493 File Offset: 0x0043D693
	public void IDCIFABCOML()
	{
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("OnBackendGetPublicProfileSuccess", 470f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009D36 RID: 40246 RVA: 0x0043D5ED File Offset: 0x0043B7ED
	private void MODKKCIONOK()
	{
		if (this.MNOBHOPILHO != null)
		{
			this.MNOBHOPILHO();
		}
	}

	// Token: 0x06009D37 RID: 40247 RVA: 0x0043F4B8 File Offset: 0x0043D6B8
	public void BMNFLANOIOA(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP)
	{
		base.gameObject.SetActive(false);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, false);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, false);
	}

	// Token: 0x06009D38 RID: 40248 RVA: 0x0043DA93 File Offset: 0x0043BC93
	public GenericPopupManager ShowStars()
	{
		this.MDHECJDJIBK = true;
		return this;
	}

	// Token: 0x06009D39 RID: 40249 RVA: 0x0043F536 File Offset: 0x0043D736
	public void JDBKBHAONAA()
	{
		this.ADAJPNHIICL();
	}

	// Token: 0x06009D3A RID: 40250 RVA: 0x0043F540 File Offset: 0x0043D740
	public void AEBBOBNOBIM(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(true);
		this.buttonOptional3.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, true);
		this.textButtonOptional1.SetText(NENGGAECHKF, false);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, false);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, false);
	}

	// Token: 0x06009D3B RID: 40251 RVA: 0x0043F5E0 File Offset: 0x0043D7E0
	public void IOEDDKCGKIJ(int ILNKINMLHOG)
	{
		this.FPELIMEJCLD = ILNKINMLHOG;
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.transform.parent.gameObject.SetActive(true);
			this.imageDiamonds.SetActive(true);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
			if (ILNKINMLHOG > 0)
			{
				this.textDiamonds.SetText("cardoptionsloadingthemefree" + ILNKINMLHOG.ToString(), true);
				return;
			}
			this.textDiamonds.SetText(ILNKINMLHOG.ToString(), false);
		}
	}

	// Token: 0x06009D3C RID: 40252 RVA: 0x0043F680 File Offset: 0x0043D880
	public void ECCFLOFCFNN(int ILNKINMLHOG)
	{
		this.FPELIMEJCLD = ILNKINMLHOG;
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.transform.parent.gameObject.SetActive(true);
			this.imageDiamonds.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(true);
			if (ILNKINMLHOG > 0)
			{
				this.textDiamonds.SetText(" from the recorded cache files" + ILNKINMLHOG.ToString(), true);
				return;
			}
			this.textDiamonds.SetText(ILNKINMLHOG.ToString(), false);
		}
	}

	// Token: 0x06009D3D RID: 40253 RVA: 0x0043F71D File Offset: 0x0043D91D
	public GenericPopupManager ELHFENKBFFK(UnityAction OMOOOGBDDDG)
	{
		this.MNOBHOPILHO = OMOOOGBDDDG;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.AddListener(new UnityAction(this.PBLGKKKKOFE));
		}
		return this;
	}

	// Token: 0x06009D3E RID: 40254 RVA: 0x0043F754 File Offset: 0x0043D954
	public void KMMALJNNNCA(int AJPNGBLHOEC)
	{
		this.AFMAOCPBLNC = AJPNGBLHOEC;
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonNegative.fontSizeMax = (float)this.AFMAOCPBLNC;
		}
	}

	// Token: 0x06009D3F RID: 40255 RVA: 0x0043F7BA File Offset: 0x0043D9BA
	private void DJIFHJDBBHN()
	{
		this.KDCIBIABJBK();
	}

	// Token: 0x06009D40 RID: 40256 RVA: 0x0043F7C2 File Offset: 0x0043D9C2
	public void DDPHFKOHDJB()
	{
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("timeoutwarning", 245f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009D41 RID: 40257 RVA: 0x0043D602 File Offset: 0x0043B802
	public GenericPopupManager KPLNIKJKPAE(UnityAction OMOOOGBDDDG)
	{
		this.ODDPLCPPDMI = OMOOOGBDDDG;
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.JFOLJKDKCBL));
		}
		return this;
	}

	// Token: 0x06009D42 RID: 40258 RVA: 0x0043F7E4 File Offset: 0x0043D9E4
	public void JCGFEMMIFDM(string EEMPGLHPKJG, string DPJINBCGNGN)
	{
		base.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		if (null != this.buttonPositive)
		{
			this.buttonPositive.gameObject.SetActive(true);
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D43 RID: 40259 RVA: 0x0043F855 File Offset: 0x0043DA55
	public void KEGLFLIHIJC()
	{
		AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("</i><align=\"left\"><alpha=#FF>\n\n", 170f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009D44 RID: 40260 RVA: 0x0043F878 File Offset: 0x0043DA78
	public void PMEFNHKLCEJ(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(true);
		this.buttonOptional3.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, false);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, false);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, false);
	}

	// Token: 0x06009D45 RID: 40261 RVA: 0x0043D602 File Offset: 0x0043B802
	public GenericPopupManager NOLKFOPIANN(UnityAction OMOOOGBDDDG)
	{
		this.ODDPLCPPDMI = OMOOOGBDDDG;
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.AddListener(new UnityAction(this.JFOLJKDKCBL));
		}
		return this;
	}

	// Token: 0x06009D46 RID: 40262 RVA: 0x0043F918 File Offset: 0x0043DB18
	public void ShowFourButtons(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP, string PODLGPEGNLJ)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(true);
		this.buttonOptional2.gameObject.SetActive(true);
		this.buttonOptional3.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, true);
		this.textButtonOptional1.SetText(NENGGAECHKF, true);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
		this.textButtonOptional3.SetText(PODLGPEGNLJ, true);
	}

	// Token: 0x06009D47 RID: 40263 RVA: 0x0043F7BA File Offset: 0x0043D9BA
	private void OnDestroy()
	{
		this.KDCIBIABJBK();
	}

	// Token: 0x06009D48 RID: 40264 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void DBAMBJPLNPG()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009D49 RID: 40265 RVA: 0x0043D636 File Offset: 0x0043B836
	private void JFOLJKDKCBL()
	{
		if (this.ODDPLCPPDMI != null)
		{
			this.ODDPLCPPDMI();
		}
	}

	// Token: 0x06009D4A RID: 40266 RVA: 0x0043F9B8 File Offset: 0x0043DBB8
	private void KDKPPDMCEBF()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		if (null != this.avatarObject)
		{
			this.KDCIBIABJBK();
			this.avatarObject.SetActive(true);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 0; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(false);
				}
			}
		}
		this.FPELIMEJCLD = -1;
		this.DAEHADAKJAL = -1;
		this.MNOBHOPILHO = null;
		this.CEOHNGJNBKD = null;
		this.ODDPLCPPDMI = null;
		this.FLPDCPBAICE = null;
		this.ACLLHEAGKCB = null;
		this.CPDFJCNPBNB = null;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.RemoveAllListeners();
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.RemoveAllListeners();
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.RemoveAllListeners();
		}
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)this.GNNJMPHGJKA;
		}
		if (AppManager.isQuitting)
		{
			return;
		}
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonNegative.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		this.AFMAOCPBLNC = -1;
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("OnFriendsPopupManagerAcceptClick", new UnityAction(this.MGPHKHGMNMA));
	}

	// Token: 0x06009D4B RID: 40267 RVA: 0x0043FBA4 File Offset: 0x0043DDA4
	public void Update()
	{
		if (base.gameObject.activeSelf)
		{
			if (this.MDHECJDJIBK)
			{
				this.MDHECJDJIBK = false;
				this.EKKIMJNGKJH();
			}
			if (this.JEMLEINMLEE)
			{
				this.JEMLEINMLEE = false;
				if (null != this.discountObjectButtonPositive)
				{
					this.discountObjectButtonPositive.SetActive(true);
				}
				if (null != this.discountObjectButtonNegative)
				{
					this.discountObjectButtonNegative.SetActive(true);
				}
			}
			if (this.FEHNOGLEANE)
			{
				this.FEHNOGLEANE = false;
				this._HideCloseButton();
			}
		}
	}

	// Token: 0x06009D4C RID: 40268 RVA: 0x0043FC2C File Offset: 0x0043DE2C
	public void ShowTwoButtons(string EEMPGLHPKJG, string DPJINBCGNGN, string FNEAAEFOOEJ, string MCDCGPAADJA)
	{
		base.gameObject.SetActive(true);
		this.buttonNegative.gameObject.SetActive(true);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, true);
		this.textButtonPositive.SetText(FNEAAEFOOEJ, true);
		this.textButtonNegative.SetText(MCDCGPAADJA, true);
	}

	// Token: 0x06009D4D RID: 40269 RVA: 0x0043D5D8 File Offset: 0x0043B7D8
	private void NFIDKMHDIPB()
	{
		if (this.CPDFJCNPBNB != null)
		{
			this.CPDFJCNPBNB();
		}
	}

	// Token: 0x06009D4E RID: 40270 RVA: 0x0043FC8C File Offset: 0x0043DE8C
	public void FIJDKGJEPGC()
	{
		if (base.gameObject.activeSelf)
		{
			if (this.MDHECJDJIBK)
			{
				this.MDHECJDJIBK = false;
				this.BAPDLJCHCDI();
			}
			if (this.JEMLEINMLEE)
			{
				this.JEMLEINMLEE = true;
				if (null != this.discountObjectButtonPositive)
				{
					this.discountObjectButtonPositive.SetActive(false);
				}
				if (null != this.discountObjectButtonNegative)
				{
					this.discountObjectButtonNegative.SetActive(true);
				}
			}
			if (this.FEHNOGLEANE)
			{
				this.FEHNOGLEANE = true;
				this.DHOLMNNGHAP();
			}
		}
	}

	// Token: 0x06009D4F RID: 40271 RVA: 0x0043F7BA File Offset: 0x0043D9BA
	private void HKHKMPLGKBO()
	{
		this.KDCIBIABJBK();
	}

	// Token: 0x06009D50 RID: 40272 RVA: 0x0043DA5F File Offset: 0x0043BC5F
	public GenericPopupManager IJMEPBEJHCK(UnityAction OMOOOGBDDDG)
	{
		this.FLPDCPBAICE = OMOOOGBDDDG;
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.AddListener(new UnityAction(this.PPFIDELHMFH));
		}
		return this;
	}

	// Token: 0x06009D51 RID: 40273 RVA: 0x0043D8A8 File Offset: 0x0043BAA8
	private void EDDPKNELODD()
	{
		if (this.CEOHNGJNBKD != null)
		{
			this.CEOHNGJNBKD();
		}
	}

	// Token: 0x06009D52 RID: 40274 RVA: 0x0043FD14 File Offset: 0x0043DF14
	public GenericPopupManager KKDHLLGKGAP(int ODFLBHNBHDA, int FCHINHEKNAJ)
	{
		this.JEMLEINMLEE = true;
		if (null != this.discountObjectButtonPositive && null != this.discountTextButtonPositive && ODFLBHNBHDA > 1)
		{
			this.discountTextButtonPositive.text = "prefixEnabled" + ODFLBHNBHDA.ToString() + "signinerror001";
			this.discountTextButtonPositive.SetText("CharacterTransitionManager - acknowledge shader unsupported, skipping accent:" + ODFLBHNBHDA.ToString() + "OnSketchThumbnailsCdnFailed", true);
		}
		if (null != this.discountObjectButtonNegative && null != this.discountTextButtonNegative && FCHINHEKNAJ > 0)
		{
			this.discountTextButtonNegative.text = "errortitle" + FCHINHEKNAJ.ToString() + ")";
			this.discountTextButtonNegative.SetText("OnGamePassExpire" + FCHINHEKNAJ.ToString() + "noisedigital", true);
		}
		return this;
	}

	// Token: 0x06009D53 RID: 40275 RVA: 0x0043D64B File Offset: 0x0043B84B
	public GenericPopupManager SetOnClickListenerButtonOptional3(UnityAction OMOOOGBDDDG)
	{
		this.CPDFJCNPBNB = OMOOOGBDDDG;
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.AddListener(new UnityAction(this.EBCKHGEMJMB));
		}
		return this;
	}

	// Token: 0x06009D54 RID: 40276 RVA: 0x0043FDF0 File Offset: 0x0043DFF0
	public void JHBKAGKAMAP()
	{
		if (base.gameObject.activeSelf)
		{
			if (this.MDHECJDJIBK)
			{
				this.MDHECJDJIBK = true;
				this.BAPDLJCHCDI();
			}
			if (this.JEMLEINMLEE)
			{
				this.JEMLEINMLEE = true;
				if (null != this.discountObjectButtonPositive)
				{
					this.discountObjectButtonPositive.SetActive(true);
				}
				if (null != this.discountObjectButtonNegative)
				{
					this.discountObjectButtonNegative.SetActive(false);
				}
			}
			if (this.FEHNOGLEANE)
			{
				this.FEHNOGLEANE = true;
				this.DHOLMNNGHAP();
			}
		}
	}

	// Token: 0x06009D55 RID: 40277 RVA: 0x0043FE78 File Offset: 0x0043E078
	public GenericPopupManager IEJBLNEHDFE(int ODFLBHNBHDA, int FCHINHEKNAJ)
	{
		this.JEMLEINMLEE = false;
		if (null != this.discountObjectButtonPositive && null != this.discountTextButtonPositive && ODFLBHNBHDA > 0)
		{
			this.discountTextButtonPositive.text = " not found." + ODFLBHNBHDA.ToString() + "Account.GetAvatarComponentsCount(), w == ";
			this.discountTextButtonPositive.SetText("CharacterRenderTexturePool" + ODFLBHNBHDA.ToString() + "@", true);
		}
		if (null != this.discountObjectButtonNegative && null != this.discountTextButtonNegative && FCHINHEKNAJ > 0)
		{
			this.discountTextButtonNegative.text = "BackendRequestType.basicSync, exception, failing safe:" + FCHINHEKNAJ.ToString() + "OnBackendRequestFriendRejectSuccess";
			this.discountTextButtonNegative.SetText("fruidres2" + FCHINHEKNAJ.ToString() + "abpd5", false);
		}
		return this;
	}

	// Token: 0x06009D56 RID: 40278 RVA: 0x0043FF53 File Offset: 0x0043E153
	public GenericPopupManager GKBLDKBINDI(UnityAction OMOOOGBDDDG)
	{
		this.ACLLHEAGKCB = OMOOOGBDDDG;
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.AddListener(new UnityAction(this.PIPDMGMLKPO));
		}
		return this;
	}

	// Token: 0x06009D57 RID: 40279 RVA: 0x0043F71D File Offset: 0x0043D91D
	public GenericPopupManager SetOnClickListenerButtonPositive(UnityAction OMOOOGBDDDG)
	{
		this.MNOBHOPILHO = OMOOOGBDDDG;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.AddListener(new UnityAction(this.PBLGKKKKOFE));
		}
		return this;
	}

	// Token: 0x06009D58 RID: 40280 RVA: 0x0043DE05 File Offset: 0x0043C005
	public GenericPopupManager MBMNKGCDIAP(UnityAction OMOOOGBDDDG)
	{
		this.CEOHNGJNBKD = OMOOOGBDDDG;
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.AddListener(new UnityAction(this.PONHBMNBHIA));
		}
		return this;
	}

	// Token: 0x06009D59 RID: 40281 RVA: 0x0043FF87 File Offset: 0x0043E187
	public void ADAJPNHIICL()
	{
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM("layervideo", 480f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009D5A RID: 40282 RVA: 0x0043FFA9 File Offset: 0x0043E1A9
	public void OCLHDGKFCEB()
	{
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("socialavatarmsg", 727f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009D5B RID: 40283 RVA: 0x0043FFCC File Offset: 0x0043E1CC
	public void ShowEnergy(int ILNKINMLHOG)
	{
		this.DAEHADAKJAL = ILNKINMLHOG;
		if (null != this.imageEnergy)
		{
			this.imageEnergy.transform.parent.gameObject.SetActive(true);
			this.imageEnergy.SetActive(true);
		}
		if (null != this.textEnergy)
		{
			this.textEnergy.gameObject.SetActive(true);
			if (ILNKINMLHOG > 0)
			{
				this.textEnergy.SetText("+" + ILNKINMLHOG.ToString(), true);
				return;
			}
			this.textEnergy.SetText(ILNKINMLHOG.ToString(), true);
		}
	}

	// Token: 0x06009D5C RID: 40284 RVA: 0x0044006C File Offset: 0x0043E26C
	public void OEKNPCBHPOK(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(true);
		this.buttonOptional2.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, true);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, false);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x004400EA File Offset: 0x0043E2EA
	public void HideCloseButton()
	{
		this.FEHNOGLEANE = true;
	}

	// Token: 0x06009D5E RID: 40286 RVA: 0x0043F7BA File Offset: 0x0043D9BA
	private void AKANLCOCAPH()
	{
		this.KDCIBIABJBK();
	}

	// Token: 0x06009D5F RID: 40287 RVA: 0x004400F4 File Offset: 0x0043E2F4
	public void JFGNJBKKIKD(int ILNKINMLHOG)
	{
		this.FPELIMEJCLD = ILNKINMLHOG;
		if (null != this.imageDiamonds)
		{
			this.imageDiamonds.transform.parent.gameObject.SetActive(false);
			this.imageDiamonds.SetActive(false);
		}
		if (null != this.textDiamonds)
		{
			this.textDiamonds.gameObject.SetActive(false);
			if (ILNKINMLHOG > 1)
			{
				this.textDiamonds.SetText("" + ILNKINMLHOG.ToString(), false);
				return;
			}
			this.textDiamonds.SetText(ILNKINMLHOG.ToString(), true);
		}
	}

	// Token: 0x06009D60 RID: 40288 RVA: 0x00440194 File Offset: 0x0043E394
	private void BHNDBCJDLEE()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(false);
		}
	}

	// Token: 0x06009D61 RID: 40289 RVA: 0x0043DBD1 File Offset: 0x0043BDD1
	private void INMHIPIPKIG()
	{
		if (this.FLPDCPBAICE != null)
		{
			this.FLPDCPBAICE();
		}
	}

	// Token: 0x06009D63 RID: 40291 RVA: 0x00440224 File Offset: 0x0043E424
	private void EKKIMJNGKJH()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(true);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(true);
		}
	}

	// Token: 0x06009D64 RID: 40292 RVA: 0x00440284 File Offset: 0x0043E484
	private void KJNANICCHJN()
	{
		if (null != this.imageStarsDecor)
		{
			this.imageStarsDecor.SetActive(false);
		}
		if (null != this.starsSpacing)
		{
			this.starsSpacing.SetActive(true);
		}
		if (null != this.stars)
		{
			this.stars.gameObject.SetActive(true);
		}
	}

	// Token: 0x06009D65 RID: 40293 RVA: 0x004402E4 File Offset: 0x0043E4E4
	public void JMAFGJAPPPG(string EEMPGLHPKJG, string DPJINBCGNGN, string DCBPPPGKHEJ, string NENGGAECHKF, string HDOAPHHFMAP)
	{
		base.gameObject.SetActive(true);
		this.buttonOptional1.gameObject.SetActive(false);
		this.buttonOptional2.gameObject.SetActive(false);
		this.textBody.SetText(DPJINBCGNGN, false);
		this.textTitle.SetText(EEMPGLHPKJG, false);
		this.textButtonPositive.SetText(DCBPPPGKHEJ, false);
		this.textButtonOptional1.SetText(NENGGAECHKF, false);
		this.textButtonOptional2.SetText(HDOAPHHFMAP, true);
	}

	// Token: 0x06009D66 RID: 40294 RVA: 0x00440362 File Offset: 0x0043E562
	public GenericPopupManager IDKFFHAFMBK()
	{
		this.MDHECJDJIBK = false;
		return this;
	}

	// Token: 0x06009D67 RID: 40295 RVA: 0x0044036C File Offset: 0x0043E56C
	public void OnSystemBackButton()
	{
		this.Hide();
	}

	// Token: 0x06009D68 RID: 40296 RVA: 0x0043D8A8 File Offset: 0x0043BAA8
	private void PONHBMNBHIA()
	{
		if (this.CEOHNGJNBKD != null)
		{
			this.CEOHNGJNBKD();
		}
	}

	// Token: 0x06009D69 RID: 40297 RVA: 0x00440374 File Offset: 0x0043E574
	private void BHAMDIHNJNA()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		if (null != this.avatarObject)
		{
			this.KDCIBIABJBK();
			this.avatarObject.SetActive(false);
			if (this.avatarImageSpacing != null)
			{
				for (int i = 0; i < this.avatarImageSpacing.Count; i++)
				{
					this.avatarImageSpacing[i].SetActive(true);
				}
			}
		}
		this.FPELIMEJCLD = -1;
		this.DAEHADAKJAL = -1;
		this.MNOBHOPILHO = null;
		this.CEOHNGJNBKD = null;
		this.ODDPLCPPDMI = null;
		this.FLPDCPBAICE = null;
		this.ACLLHEAGKCB = null;
		this.CPDFJCNPBNB = null;
		if (null != this.buttonPositive)
		{
			this.buttonPositive.onClick.RemoveAllListeners();
		}
		if (null != this.buttonNegative)
		{
			this.buttonNegative.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional1)
		{
			this.buttonOptional1.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional2)
		{
			this.buttonOptional2.onClick.RemoveAllListeners();
		}
		if (null != this.buttonOptional3)
		{
			this.buttonOptional3.onClick.RemoveAllListeners();
		}
		if (null != this.buttonClose)
		{
			this.buttonClose.onClick.RemoveAllListeners();
		}
		if (null != this.textBody)
		{
			this.textBody.fontSize = (float)this.GNNJMPHGJKA;
		}
		if (AppManager.isQuitting)
		{
			return;
		}
		if (null != this.textButtonPositive && this.AFMAOCPBLNC >= 0)
		{
			this.textButtonPositive.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		if (null != this.textButtonNegative && this.AFMAOCPBLNC >= 1)
		{
			this.textButtonNegative.fontSizeMax = (float)this.ONMGHEFBKPD;
		}
		this.AFMAOCPBLNC = -1;
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG(".json", new UnityAction(this.NAFJFAGAAGA));
	}

	// Token: 0x06009D6A RID: 40298 RVA: 0x0043D5D8 File Offset: 0x0043B7D8
	private void EBCKHGEMJMB()
	{
		if (this.CPDFJCNPBNB != null)
		{
			this.CPDFJCNPBNB();
		}
	}

	// Token: 0x06009D6B RID: 40299 RVA: 0x0044055F File Offset: 0x0043E75F
	public void OHHFFMMMMAC()
	{
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(".", 1165f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009D6C RID: 40300 RVA: 0x0043DBD1 File Offset: 0x0043BDD1
	private void PPFIDELHMFH()
	{
		if (this.FLPDCPBAICE != null)
		{
			this.FLPDCPBAICE();
		}
	}

	// Token: 0x06009D6D RID: 40301 RVA: 0x00440581 File Offset: 0x0043E781
	public void DEFIKLCMHOP(int HCPDCKEAIKK, int BMFFHLMALED)
	{
		this.FPELIMEJCLD = HCPDCKEAIKK;
		this.DAEHADAKJAL = BMFFHLMALED;
		this.JFGNJBKKIKD(HCPDCKEAIKK);
		this.LGEKPJCJBME(BMFFHLMALED);
	}

	// Token: 0x06009D6E RID: 40302 RVA: 0x0043D8A8 File Offset: 0x0043BAA8
	private void MMEFCDCGBBE()
	{
		if (this.CEOHNGJNBKD != null)
		{
			this.CEOHNGJNBKD();
		}
	}

	// Token: 0x04002B9C RID: 11164
	public const string onSystemBackButton = "OnSystemBackButton";

	// Token: 0x04002B9D RID: 11165
	public const string onGenericPopupManagerHide = "OnGenericPopupManagerHide";

	// Token: 0x04002B9E RID: 11166
	public Button buttonClose;

	// Token: 0x04002B9F RID: 11167
	public Button buttonNegative;

	// Token: 0x04002BA0 RID: 11168
	public Button buttonPositive;

	// Token: 0x04002BA1 RID: 11169
	public Button buttonOptional1;

	// Token: 0x04002BA2 RID: 11170
	public Button buttonOptional2;

	// Token: 0x04002BA3 RID: 11171
	public Button buttonOptional3;

	// Token: 0x04002BA4 RID: 11172
	public TextMeshProUGUI textBody;

	// Token: 0x04002BA5 RID: 11173
	public TextMeshProUGUI textTitle;

	// Token: 0x04002BA6 RID: 11174
	public TextMeshProUGUI textButtonPositive;

	// Token: 0x04002BA7 RID: 11175
	public TextMeshProUGUI textButtonNegative;

	// Token: 0x04002BA8 RID: 11176
	public TextMeshProUGUI textButtonOptional1;

	// Token: 0x04002BA9 RID: 11177
	public TextMeshProUGUI textButtonOptional2;

	// Token: 0x04002BAA RID: 11178
	public TextMeshProUGUI textButtonOptional3;

	// Token: 0x04002BAB RID: 11179
	public GameObject imageDiamonds;

	// Token: 0x04002BAC RID: 11180
	public TextMeshProUGUI textDiamonds;

	// Token: 0x04002BAD RID: 11181
	public GameObject imageEnergy;

	// Token: 0x04002BAE RID: 11182
	public TextMeshProUGUI textEnergy;

	// Token: 0x04002BAF RID: 11183
	public GameObject imageStarsDecor;

	// Token: 0x04002BB0 RID: 11184
	public StarRatingSelector stars;

	// Token: 0x04002BB1 RID: 11185
	public GameObject starsSpacing;

	// Token: 0x04002BB2 RID: 11186
	public GameObject avatarObject;

	// Token: 0x04002BB3 RID: 11187
	public Image avatarImageThumb;

	// Token: 0x04002BB4 RID: 11188
	public List<GameObject> avatarImageSpacing;

	// Token: 0x04002BB5 RID: 11189
	public GameObject discountObjectButtonPositive;

	// Token: 0x04002BB6 RID: 11190
	public GameObject discountObjectButtonNegative;

	// Token: 0x04002BB7 RID: 11191
	public TextMeshProUGUI discountTextButtonPositive;

	// Token: 0x04002BB8 RID: 11192
	public TextMeshProUGUI discountTextButtonNegative;

	// Token: 0x04002BB9 RID: 11193
	private UnityAction MNOBHOPILHO;

	// Token: 0x04002BBA RID: 11194
	private UnityAction CEOHNGJNBKD;

	// Token: 0x04002BBB RID: 11195
	private UnityAction ODDPLCPPDMI;

	// Token: 0x04002BBC RID: 11196
	private UnityAction FLPDCPBAICE;

	// Token: 0x04002BBD RID: 11197
	private UnityAction ACLLHEAGKCB;

	// Token: 0x04002BBE RID: 11198
	private UnityAction CPDFJCNPBNB;

	// Token: 0x04002BBF RID: 11199
	private int FPELIMEJCLD = -1;

	// Token: 0x04002BC0 RID: 11200
	private int DAEHADAKJAL = -1;

	// Token: 0x04002BC1 RID: 11201
	private int GNNJMPHGJKA = 28;

	// Token: 0x04002BC2 RID: 11202
	private bool MDHECJDJIBK;

	// Token: 0x04002BC3 RID: 11203
	private bool JEMLEINMLEE;

	// Token: 0x04002BC4 RID: 11204
	private bool FEHNOGLEANE;

	// Token: 0x04002BC5 RID: 11205
	private int ONMGHEFBKPD = 42;

	// Token: 0x04002BC6 RID: 11206
	private int AFMAOCPBLNC = -1;
}
