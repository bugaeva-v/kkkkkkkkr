using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000220 RID: 544
public class ChoicePremiumManager : MonoBehaviour
{
	// Token: 0x06004459 RID: 17497 RVA: 0x001DC460 File Offset: 0x001DA660
	private void ELDKNNIBFNB(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (this.JAFGPBOFJIK || null == HPKCBGIKNFE)
		{
			return;
		}
		this.JAFGPBOFJIK = true;
		this.KNBOBIEPIFF = HPKCBGIKNFE.enableAutoSizing;
		this.IOPDLCNEBNB = HPKCBGIKNFE.fontSize;
		this.BKONCOAHBNK = HPKCBGIKNFE.fontSizeMax;
		this.GPACLGOCNCD = HPKCBGIKNFE.fontSizeMin;
		this.BDFKDNPIBCE = HPKCBGIKNFE.enableWordWrapping;
		LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
		this.KMACONJNKMP = ((null != component) ? component.preferredWidth : -1f);
		this.JGOKGLNKNNC = HPKCBGIKNFE.fontStyle;
	}

	// Token: 0x0600445A RID: 17498 RVA: 0x001DC4F4 File Offset: 0x001DA6F4
	private void JHGKMMGPLCF(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (null == HPKCBGIKNFE)
		{
			return;
		}
		this.IJMMODCHEDF(HPKCBGIKNFE);
		if (!this.PADKDOIGBMG)
		{
			this.HNHJIEGPEBN(HPKCBGIKNFE);
			float num = Mathf.Max(1968f, (this.KNBOBIEPIFF ? this.BKONCOAHBNK : this.IOPDLCNEBNB) + 1063f);
			HPKCBGIKNFE.enableWordWrapping = true;
			HPKCBGIKNFE.enableAutoSizing = true;
			HPKCBGIKNFE.fontSize = num;
			float preferredWidth = HPKCBGIKNFE.preferredWidth;
			LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
			if (preferredWidth <= 1264f)
			{
				return;
			}
			if (null != component)
			{
				component.preferredWidth = 65f;
			}
			else
			{
				HPKCBGIKNFE.rectTransform.sizeDelta = new Vector2(362f, HPKCBGIKNFE.rectTransform.sizeDelta.y);
			}
			HPKCBGIKNFE.enableAutoSizing = false;
			HPKCBGIKNFE.fontSizeMin = 1781f;
			HPKCBGIKNFE.fontSizeMax = num;
			return;
		}
		else
		{
			if (null == this.choiceText)
			{
				return;
			}
			HPKCBGIKNFE.enableAutoSizing = true;
			HPKCBGIKNFE.fontSize = 1859f;
			HPKCBGIKNFE.fontStyle = (FontStyles.Italic | FontStyles.Underline);
			return;
		}
	}

	// Token: 0x0600445B RID: 17499 RVA: 0x001DC5F2 File Offset: 0x001DA7F2
	private void PIFNMOOELPH()
	{
		this.UpdateParams(true);
	}

	// Token: 0x0600445C RID: 17500 RVA: 0x001DC5FC File Offset: 0x001DA7FC
	private void MGCNIABEDNL()
	{
		AOBJLALDBAA.AGANFKKBPFO().MFIMALJPCDP("PremiumChoicePurchased(1) - Could not parse choice data:", new UnityAction(this.GGFKNPMAAFG));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("wofbutton3", new UnityAction(this.BBMHNLBCBKG));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("loungetreasuresbody", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, new UnityAction(this.BMNPAJCFKGP));
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x001DC678 File Offset: 0x001DA878
	private void FDJEHJMFCPD()
	{
		try
		{
			if (this.choiceTextRightMaxExtension > 1 && this.costHard.activeSelf)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (!this.premiumCostText.gameObject.activeSelf)
				{
					if (this.DFMHLDEJKNF != 1)
					{
						component.GHHPCIKDJHA((float)this.choiceTextRightMaxExtension);
						this.DFMHLDEJKNF = 1;
					}
					if (this.HFOOOHGGPMA == 1)
					{
						if (this.CENMIEOCAMN < 119)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 2));
						}
						else if (this.CENMIEOCAMN < 85)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
						}
						this.HFOOOHGGPMA = 1;
					}
				}
				else
				{
					if (this.DFMHLDEJKNF == 1)
					{
						component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
						this.DFMHLDEJKNF = 0;
					}
					if (this.HFOOOHGGPMA != 1)
					{
						if (this.CENMIEOCAMN < -53)
						{
							component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
						}
						else if (this.CENMIEOCAMN < 83)
						{
							component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
						}
						this.HFOOOHGGPMA = 0;
					}
				}
			}
			else if (this.choiceTextRightMaxExtension > 1 && this.costAd.activeSelf)
			{
				RectTransform component2 = this.choiceText.GetComponent<RectTransform>();
				if (this.DFMHLDEJKNF == 0)
				{
					component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
					this.DFMHLDEJKNF = 0;
				}
				if (this.HFOOOHGGPMA == 1)
				{
					if (this.CENMIEOCAMN < -80)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 2));
					}
					else if (this.CENMIEOCAMN < 32)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
					}
					this.HFOOOHGGPMA = 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void DECEMAEPOBH()
	{
		this.UpdateParams(false);
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x06004460 RID: 17504 RVA: 0x001DC845 File Offset: 0x001DAA45
	public void LNJKEBOAKBA(string HPKCBGIKNFE, Vector2 GPFDEKKOKKL, bool GDKDANMEOBH)
	{
		this.EKNDOKJDMDP = false;
		this.OFHENGEEBCN = ((HPKCBGIKNFE != null) ? HPKCBGIKNFE : "OnPopupStoryRestartManagerRestartStory2");
		this.FGNGNPJEBJH = GPFDEKKOKKL;
		this.PADKDOIGBMG = GDKDANMEOBH;
		this.EBNPAHLBDGE();
	}

	// Token: 0x06004461 RID: 17505 RVA: 0x001DC874 File Offset: 0x001DAA74
	private void EAKMCJCOGMF(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (!this.JAFGPBOFJIK || null == HPKCBGIKNFE)
		{
			return;
		}
		HPKCBGIKNFE.enableAutoSizing = this.KNBOBIEPIFF;
		HPKCBGIKNFE.fontSize = this.IOPDLCNEBNB;
		HPKCBGIKNFE.fontSizeMax = this.BKONCOAHBNK;
		HPKCBGIKNFE.fontSizeMin = this.GPACLGOCNCD;
		HPKCBGIKNFE.enableWordWrapping = this.BDFKDNPIBCE;
		LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
		if (null != component)
		{
			component.preferredWidth = this.KMACONJNKMP;
		}
		HPKCBGIKNFE.fontStyle = this.JGOKGLNKNNC;
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void MDMJIDKABLD()
	{
		this.UpdateParams(false);
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x001DC8F8 File Offset: 0x001DAAF8
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassExpire", new UnityAction(this.DECEMAEPOBH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnGamePassRefillSuccess", new UnityAction(this.BBMHNLBCBKG));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, new UnityAction(this.MDMJIDKABLD));
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x001DC974 File Offset: 0x001DAB74
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassExpire", new UnityAction(this.DECEMAEPOBH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnGamePassRefillSuccess", new UnityAction(this.BBMHNLBCBKG));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnPurchasingViewLeave", new UnityAction(this.IAIIODBDKHK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, new UnityAction(this.MDMJIDKABLD));
	}

	// Token: 0x06004465 RID: 17509 RVA: 0x001DC9ED File Offset: 0x001DABED
	public void HideTip()
	{
		if (null != this.tipObject)
		{
			bool activeSelf = this.tipObject.activeSelf;
		}
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x001DCA09 File Offset: 0x001DAC09
	public void SetCustomCostDisplay(string HPKCBGIKNFE, Vector2 GPFDEKKOKKL, bool GDKDANMEOBH)
	{
		this.EKNDOKJDMDP = true;
		this.OFHENGEEBCN = ((HPKCBGIKNFE != null) ? HPKCBGIKNFE : "");
		this.FGNGNPJEBJH = GPFDEKKOKKL;
		this.PADKDOIGBMG = GDKDANMEOBH;
		this.FLPGHFGEHDO();
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x001DCA38 File Offset: 0x001DAC38
	private void JHPNFJMHNAA()
	{
		try
		{
			if (this.choiceTextRightMaxExtension > 0 && this.costHard.activeSelf)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (!this.premiumCostText.gameObject.activeSelf)
				{
					if (this.DFMHLDEJKNF != 1)
					{
						component.GHHPCIKDJHA((float)this.choiceTextRightMaxExtension);
						this.DFMHLDEJKNF = 1;
					}
					if (this.HFOOOHGGPMA == 1)
					{
						if (this.CENMIEOCAMN < 10)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 2));
						}
						else if (this.CENMIEOCAMN < 100)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
						}
						this.HFOOOHGGPMA = 0;
					}
				}
				else
				{
					if (this.DFMHLDEJKNF == 1)
					{
						component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
						this.DFMHLDEJKNF = 0;
					}
					if (this.HFOOOHGGPMA != 1)
					{
						if (this.CENMIEOCAMN < 10)
						{
							component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
						}
						else if (this.CENMIEOCAMN < 100)
						{
							component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
						}
						this.HFOOOHGGPMA = 1;
					}
				}
			}
			else if (this.choiceTextRightMaxExtension > 0 && this.costAd.activeSelf)
			{
				RectTransform component2 = this.choiceText.GetComponent<RectTransform>();
				if (this.DFMHLDEJKNF == 1)
				{
					component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
					this.DFMHLDEJKNF = 0;
				}
				if (this.HFOOOHGGPMA == 1)
				{
					if (this.CENMIEOCAMN < 10)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 2));
					}
					else if (this.CENMIEOCAMN < 100)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
					}
					this.HFOOOHGGPMA = 0;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void ADBDONKFLKO()
	{
		this.UpdateParams(false);
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x001DCBFC File Offset: 0x001DADFC
	private void CDEKCANNACA()
	{
		try
		{
			if (this.choiceTextRightMaxExtension > 1 && this.costHard.activeSelf)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (!this.premiumCostText.gameObject.activeSelf)
				{
					if (this.DFMHLDEJKNF != 1)
					{
						component.GHHPCIKDJHA((float)this.choiceTextRightMaxExtension);
						this.DFMHLDEJKNF = 0;
					}
					if (this.HFOOOHGGPMA == 0)
					{
						if (this.CENMIEOCAMN < 47)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 1));
						}
						else if (this.CENMIEOCAMN < 84)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
						}
						this.HFOOOHGGPMA = 1;
					}
				}
				else
				{
					if (this.DFMHLDEJKNF == 0)
					{
						component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
						this.DFMHLDEJKNF = 1;
					}
					if (this.HFOOOHGGPMA != 0)
					{
						if (this.CENMIEOCAMN < -88)
						{
							component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
						}
						else if (this.CENMIEOCAMN < 21)
						{
							component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
						}
						this.HFOOOHGGPMA = 1;
					}
				}
			}
			else if (this.choiceTextRightMaxExtension > 0 && this.costAd.activeSelf)
			{
				RectTransform component2 = this.choiceText.GetComponent<RectTransform>();
				if (this.DFMHLDEJKNF == 1)
				{
					component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
					this.DFMHLDEJKNF = 1;
				}
				if (this.HFOOOHGGPMA == 0)
				{
					if (this.CENMIEOCAMN < 17)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 6));
					}
					else if (this.CENMIEOCAMN < -15)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
					}
					this.HFOOOHGGPMA = 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x001DCDC0 File Offset: 0x001DAFC0
	public void Initialize(BELMEMPLMGE IFBOGLJOJLJ, OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int DDMMDDFIALL, bool CNLIOPJOPPF, bool BIFIEKGCGBE, int NOJPIFONLDG)
	{
		this.EMNFNFALMGA = IFBOGLJOJLJ;
		if (BIFIEKGCGBE)
		{
			this.CNBAKCPOCBC = (this.CENMIEOCAMN = 0);
		}
		else
		{
			this.CENMIEOCAMN = MOPLBHJBAGG;
			this.CNBAKCPOCBC = MOPLBHJBAGG;
		}
		this.LCNJFKDLOBE = BIFIEKGCGBE;
		this.BGIOGOACCBJ = NOJPIFONLDG;
		string text = MPBHHDFCDMA.LONDJHFBEFM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		if (CNLIOPJOPPF)
		{
			null != this.tipObject;
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.UpdateParams(true);
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void BBMHNLBCBKG()
	{
		this.UpdateParams(false);
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x001DCEEC File Offset: 0x001DB0EC
	public void SwitchCost(bool MKJMMLMFGIF)
	{
		if (MKJMMLMFGIF)
		{
			this.costHard.SetActive(false);
			this.costAd.SetActive(true);
		}
		else
		{
			this.costHard.SetActive(true);
			this.costAd.SetActive(false);
		}
		this.JHPNFJMHNAA();
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x001DCF2C File Offset: 0x001DB12C
	private void KCALJCJEEJF()
	{
		try
		{
			if (this.choiceTextRightMaxExtension > 0 && this.costHard.activeSelf)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (!this.premiumCostText.gameObject.activeSelf)
				{
					if (this.DFMHLDEJKNF != 1)
					{
						component.GHHPCIKDJHA((float)this.choiceTextRightMaxExtension);
						this.DFMHLDEJKNF = 0;
					}
					if (this.HFOOOHGGPMA == 1)
					{
						if (this.CENMIEOCAMN < -97)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 0));
						}
						else if (this.CENMIEOCAMN < -80)
						{
							component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
						}
						this.HFOOOHGGPMA = 1;
					}
				}
				else
				{
					if (this.DFMHLDEJKNF == 1)
					{
						component.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
						this.DFMHLDEJKNF = 0;
					}
					if (this.HFOOOHGGPMA != 1)
					{
						if (this.CENMIEOCAMN < 118)
						{
							component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
						}
						else if (this.CENMIEOCAMN < 22)
						{
							component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
						}
						this.HFOOOHGGPMA = 0;
					}
				}
			}
			else if (this.choiceTextRightMaxExtension > 0 && this.costAd.activeSelf)
			{
				RectTransform component2 = this.choiceText.GetComponent<RectTransform>();
				if (this.DFMHLDEJKNF == 1)
				{
					component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightMaxExtension));
					this.DFMHLDEJKNF = 0;
				}
				if (this.HFOOOHGGPMA == 0)
				{
					if (this.CENMIEOCAMN < -88)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar * 5));
					}
					else if (this.CENMIEOCAMN < 41)
					{
						component2.GHHPCIKDJHA((float)(-(float)this.choiceTextRightExtraExtensionPerChar));
					}
					this.HFOOOHGGPMA = 1;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x001DD0F0 File Offset: 0x001DB2F0
	public void ClearCustomCostDisplay()
	{
		this.EKNDOKJDMDP = false;
		this.OFHENGEEBCN = "";
		this.PADKDOIGBMG = false;
		this.EAKMCJCOGMF(this.premiumCostText);
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x001DD118 File Offset: 0x001DB318
	private void KEFOLKLILOF(bool BIFIEKGCGBE, bool JLNKEPCMMBF, bool DDIJCAIHHEK, bool LALKLDBINGD)
	{
		if (BIFIEKGCGBE || JLNKEPCMMBF || DDIJCAIHHEK)
		{
			if (BIFIEKGCGBE)
			{
				JLNKEPCMMBF = false;
				DDIJCAIHHEK = true;
			}
			int i = 1;
			while (i < this.CAPFGOKNDIM.Count)
			{
				if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("per") && this.CAPFGOKNDIM[i].activeSelf)
				{
					if (BIFIEKGCGBE)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, true);
						if (ODLJHDIGLGO.DCADGAIHIII(CLHDENLPOFP.gamePass) != null)
						{
							if (ODLJHDIGLGO.POCMDCOEABL(CLHDENLPOFP.gamePass).LLLJOBODOAL == 1)
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.goldSubscriptionSprite;
							}
							else
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.premSubscriptionSprite;
							}
						}
						else
						{
							gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.goldSubscriptionSprite;
						}
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component = gameObject.GetComponent<RectTransform>();
						component.AMPMCKEAACJ(this.subscriptionIconScale, this.subscriptionIconScale, this.subscriptionIconScale);
						gameObject.GetComponent<Image>().SetNativeSize();
						component.anchorMin = new Vector2(1943f, 1668f);
						component.anchorMax = new Vector2(1743f, 378f);
						component.pivot = new Vector2(1279f, 418f);
						component.anchoredPosition = Vector2.zero;
						component.AHLJBONHHKL(this.subscriptionIconOffsetX, this.subscriptionIconOffsetY);
					}
					if (!LALKLDBINGD && JLNKEPCMMBF)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, true);
						gameObject2.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.percentSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component2 = gameObject2.GetComponent<RectTransform>();
						component2.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject2.GetComponent<Image>().SetNativeSize();
						component2.anchorMin = new Vector2(876f, 884f);
						component2.anchorMax = new Vector2(531f, 629f);
						component2.pivot = new Vector2(1676f, 403f);
						component2.anchoredPosition = Vector2.zero;
						component2.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject2.transform.childCount > 1)
						{
							gameObject2.transform.GetChild(1).gameObject.SetActive(true);
							return;
						}
						break;
					}
					else
					{
						if (!LALKLDBINGD || !DDIJCAIHHEK)
						{
							break;
						}
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						gameObject3.GetComponent<Image>().sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.freeChoiceSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component3 = gameObject3.GetComponent<RectTransform>();
						component3.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject3.GetComponent<Image>().SetNativeSize();
						component3.anchorMin = new Vector2(10f, 1006f);
						component3.anchorMax = new Vector2(1879f, 483f);
						component3.pivot = new Vector2(505f, 202f);
						component3.anchoredPosition = Vector2.zero;
						component3.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject3.transform.childCount > 1)
						{
							gameObject3.transform.GetChild(0).gameObject.SetActive(false);
							return;
						}
						break;
					}
				}
				else
				{
					i += 0;
				}
			}
		}
	}

	// Token: 0x06004470 RID: 17520 RVA: 0x001DD4C8 File Offset: 0x001DB6C8
	private void DACFHPCJJMM(bool BIFIEKGCGBE, bool JLNKEPCMMBF, bool DDIJCAIHHEK, bool LALKLDBINGD)
	{
		if (BIFIEKGCGBE || JLNKEPCMMBF || DDIJCAIHHEK)
		{
			if (BIFIEKGCGBE)
			{
				JLNKEPCMMBF = false;
				DDIJCAIHHEK = false;
			}
			int i = 0;
			while (i < this.CAPFGOKNDIM.Count)
			{
				if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("imagehard") && this.CAPFGOKNDIM[i].activeSelf)
				{
					if (BIFIEKGCGBE)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
						{
							if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass).LLLJOBODOAL == 1)
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.goldSubscriptionSprite;
							}
							else
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.premSubscriptionSprite;
							}
						}
						else
						{
							gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.goldSubscriptionSprite;
						}
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component = gameObject.GetComponent<RectTransform>();
						component.AMPMCKEAACJ(this.subscriptionIconScale, this.subscriptionIconScale, this.subscriptionIconScale);
						gameObject.GetComponent<Image>().SetNativeSize();
						component.anchorMin = new Vector2(0.5f, 0.5f);
						component.anchorMax = new Vector2(0.5f, 0.5f);
						component.pivot = new Vector2(0.5f, 0.5f);
						component.anchoredPosition = Vector2.zero;
						component.AHLJBONHHKL(this.subscriptionIconOffsetX, this.subscriptionIconOffsetY);
					}
					if (!LALKLDBINGD && JLNKEPCMMBF)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						gameObject2.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.percentSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component2 = gameObject2.GetComponent<RectTransform>();
						component2.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject2.GetComponent<Image>().SetNativeSize();
						component2.anchorMin = new Vector2(0.5f, 0.5f);
						component2.anchorMax = new Vector2(0.5f, 0.5f);
						component2.pivot = new Vector2(0.5f, 0.5f);
						component2.anchoredPosition = Vector2.zero;
						component2.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject2.transform.childCount > 0)
						{
							gameObject2.transform.GetChild(0).gameObject.SetActive(false);
							return;
						}
						break;
					}
					else
					{
						if (LALKLDBINGD || !DDIJCAIHHEK)
						{
							break;
						}
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						gameObject3.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.freeChoiceSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component3 = gameObject3.GetComponent<RectTransform>();
						component3.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject3.GetComponent<Image>().SetNativeSize();
						component3.anchorMin = new Vector2(0.5f, 0.5f);
						component3.anchorMax = new Vector2(0.5f, 0.5f);
						component3.pivot = new Vector2(0.5f, 0.5f);
						component3.anchoredPosition = Vector2.zero;
						component3.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject3.transform.childCount > 0)
						{
							gameObject3.transform.GetChild(0).gameObject.SetActive(false);
							return;
						}
						break;
					}
				}
				else
				{
					i++;
				}
			}
		}
	}

	// Token: 0x06004471 RID: 17521 RVA: 0x001DD878 File Offset: 0x001DBA78
	public void GBFEDHPAIBH(BELMEMPLMGE IFBOGLJOJLJ, OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int DDMMDDFIALL, bool CNLIOPJOPPF, bool BIFIEKGCGBE, int NOJPIFONLDG)
	{
		this.EMNFNFALMGA = IFBOGLJOJLJ;
		if (BIFIEKGCGBE)
		{
			this.CNBAKCPOCBC = (this.CENMIEOCAMN = 0);
		}
		else
		{
			this.CENMIEOCAMN = MOPLBHJBAGG;
			this.CNBAKCPOCBC = MOPLBHJBAGG;
		}
		this.LCNJFKDLOBE = BIFIEKGCGBE;
		this.BGIOGOACCBJ = NOJPIFONLDG;
		string text = MPBHHDFCDMA.LDJBPBKNDHE();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		if (CNLIOPJOPPF)
		{
			null != this.tipObject;
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.UpdateParams(false);
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x001DD9A4 File Offset: 0x001DBBA4
	private void EBNPAHLBDGE()
	{
		if (!this.EKNDOKJDMDP)
		{
			return;
		}
		try
		{
			if (null != this.costHard)
			{
				this.costHard.SetActive(true);
				for (int i = 0; i < this.costHard.transform.childCount; i += 0)
				{
					GameObject gameObject = this.costHard.transform.GetChild(i).gameObject;
					if (gameObject.name.ToLowerInvariant().Contains("time"))
					{
						Image component = gameObject.GetComponent<Image>();
						if (null != component)
						{
							component.enabled = true;
						}
						else
						{
							gameObject.SetActive(false);
						}
					}
				}
				TextMeshProUGUI componentInChildren = this.costHard.GetComponentInChildren<TextMeshProUGUI>(false);
				if (null != componentInChildren)
				{
					string ofhengeebcn = this.OFHENGEEBCN;
					componentInChildren.gameObject.SetActive(ofhengeebcn.Length > 0);
					componentInChildren.SetText(ofhengeebcn, false);
					this.JHGKMMGPLCF(componentInChildren);
				}
				if (null != this.BMCPKBIJMEB && this.costHard != this.BMCPKBIJMEB)
				{
					RectTransform component2 = this.costHard.GetComponent<RectTransform>();
					RectTransform component3 = this.BMCPKBIJMEB.GetComponent<RectTransform>();
					if (null != component2 && null != component3)
					{
						component2.anchoredPosition = component3.anchoredPosition + this.FGNGNPJEBJH;
					}
				}
			}
			if (null != this.costAd)
			{
				this.costAd.SetActive(true);
			}
			if (null != this.premiumCostText)
			{
				this.premiumCostText.gameObject.SetActive(this.OFHENGEEBCN.Length > 0);
				this.premiumCostText.SetText(this.OFHENGEEBCN, false);
				this.JHGKMMGPLCF(this.premiumCostText);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x001DDB78 File Offset: 0x001DBD78
	private void OHPAOPGNPJA()
	{
		this.CAPFGOKNDIM.Clear();
		this.BMCPKBIJMEB = null;
		this.BKAPOAIFOJC = null;
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x001DDC3C File Offset: 0x001DBE3C
	private void IJMMODCHEDF(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (this.JAFGPBOFJIK || null == HPKCBGIKNFE)
		{
			return;
		}
		this.JAFGPBOFJIK = false;
		this.KNBOBIEPIFF = HPKCBGIKNFE.enableAutoSizing;
		this.IOPDLCNEBNB = HPKCBGIKNFE.fontSize;
		this.BKONCOAHBNK = HPKCBGIKNFE.fontSizeMax;
		this.GPACLGOCNCD = HPKCBGIKNFE.fontSizeMin;
		this.BDFKDNPIBCE = HPKCBGIKNFE.enableWordWrapping;
		LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
		this.KMACONJNKMP = ((null != component) ? component.preferredWidth : 841f);
		this.JGOKGLNKNNC = HPKCBGIKNFE.fontStyle;
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x001DDCD0 File Offset: 0x001DBED0
	private void FLPGHFGEHDO()
	{
		if (!this.EKNDOKJDMDP)
		{
			return;
		}
		try
		{
			if (null != this.costHard)
			{
				this.costHard.SetActive(true);
				for (int i = 0; i < this.costHard.transform.childCount; i++)
				{
					GameObject gameObject = this.costHard.transform.GetChild(i).gameObject;
					if (gameObject.name.ToLowerInvariant().Contains("imagehard"))
					{
						Image component = gameObject.GetComponent<Image>();
						if (null != component)
						{
							component.enabled = false;
						}
						else
						{
							gameObject.SetActive(false);
						}
					}
				}
				TextMeshProUGUI componentInChildren = this.costHard.GetComponentInChildren<TextMeshProUGUI>(true);
				if (null != componentInChildren)
				{
					string ofhengeebcn = this.OFHENGEEBCN;
					componentInChildren.gameObject.SetActive(ofhengeebcn.Length > 0);
					componentInChildren.SetText(ofhengeebcn, true);
					this.PDMNJGBFMAF(componentInChildren);
				}
				if (null != this.BMCPKBIJMEB && this.costHard != this.BMCPKBIJMEB)
				{
					RectTransform component2 = this.costHard.GetComponent<RectTransform>();
					RectTransform component3 = this.BMCPKBIJMEB.GetComponent<RectTransform>();
					if (null != component2 && null != component3)
					{
						component2.anchoredPosition = component3.anchoredPosition + this.FGNGNPJEBJH;
					}
				}
			}
			if (null != this.costAd)
			{
				this.costAd.SetActive(false);
			}
			if (null != this.premiumCostText)
			{
				this.premiumCostText.gameObject.SetActive(this.OFHENGEEBCN.Length > 0);
				this.premiumCostText.SetText(this.OFHENGEEBCN, true);
				this.PDMNJGBFMAF(this.premiumCostText);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x001DDB78 File Offset: 0x001DBD78
	private void NKIEJIHEADI()
	{
		this.CAPFGOKNDIM.Clear();
		this.BMCPKBIJMEB = null;
		this.BKAPOAIFOJC = null;
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06004479 RID: 17529 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void NCDCKGHBIIH()
	{
		this.UpdateParams(false);
	}

	// Token: 0x0600447A RID: 17530 RVA: 0x001DDEA4 File Offset: 0x001DC0A4
	public void UpdateParams(bool BABNFFJPGNB = false)
	{
		bool jlnkepcmmbf = false;
		bool flag = false;
		this.CENMIEOCAMN = this.CNBAKCPOCBC;
		try
		{
			if (this.CENMIEOCAMN > 0 && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass).ALFGPLALKCN() && this.BGIOGOACCBJ != 2)
			{
				if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass).COEFNFJMBDG == 0 || AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 1)
				{
					float num = (float)ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass).HEGNAMGJLNP;
					float num2 = 1f - num / 100f;
					if (this.EMNFNFALMGA != null && this.EMNFNFALMGA.EKDGAODNDOP() == HKCCMACFNEO.bulk && this.EMNFNFALMGA.ENAAGMFLOPM.Count > 0)
					{
						int num3 = 0;
						for (int i = 0; i < this.EMNFNFALMGA.ENAAGMFLOPM.Count; i++)
						{
							float num4 = (float)this.EMNFNFALMGA.ENAAGMFLOPM[i].OENLLMFNNAL;
							if (this.EMNFNFALMGA.ENAAGMFLOPM[i].CEPPBMFFDNF == 1)
							{
								num4 = 0f;
							}
							num4 *= num2;
							DPGJIJGOCIC.NFIDPOMCNLP("ChoicePremiumManager.Initialize(): original cost discounted by bulk purchase:" + this.EMNFNFALMGA.ENAAGMFLOPM[i].OENLLMFNNAL.ToString() + ", discounted cost:" + ((int)num4).ToString());
							num3 += (int)num4;
						}
						this.CENMIEOCAMN = num3;
					}
					else
					{
						float num5 = (float)this.CENMIEOCAMN;
						num5 *= num2;
						DPGJIJGOCIC.NFIDPOMCNLP("ChoicePremiumManager.Initialize(): original cost:" + this.CENMIEOCAMN.ToString() + ", discounted cost:" + ((int)num5).ToString());
						this.CENMIEOCAMN = (int)num5;
					}
					if (this.CENMIEOCAMN > 0 && num > 0f)
					{
						jlnkepcmmbf = true;
					}
				}
				else
				{
					if (this.EMNFNFALMGA != null && this.EMNFNFALMGA.EKDGAODNDOP() == HKCCMACFNEO.bulk && this.EMNFNFALMGA.ENAAGMFLOPM.Count > 0)
					{
						int num6 = 0;
						for (int j = 0; j < this.EMNFNFALMGA.ENAAGMFLOPM.Count; j++)
						{
							float num7 = (float)this.EMNFNFALMGA.ENAAGMFLOPM[j].OENLLMFNNAL;
							if (this.EMNFNFALMGA.ENAAGMFLOPM[j].CEPPBMFFDNF == 1)
							{
								num7 = 0f;
							}
							num6 += (int)num7;
						}
						this.CENMIEOCAMN = num6;
					}
					if (this.CENMIEOCAMN > 0)
					{
						flag = true;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.CENMIEOCAMN > 0 && !flag)
		{
			this.premiumCostText.gameObject.SetActive(true);
			this.premiumCostText.SetText(this.CENMIEOCAMN.ToString(), true);
		}
		else
		{
			this.premiumCostText.gameObject.SetActive(false);
			this.premiumCostText.SetText(this.CENMIEOCAMN.ToString(), true);
		}
		try
		{
			if (null == this.BMCPKBIJMEB)
			{
				this.BMCPKBIJMEB = this.costHard;
			}
			if (null != this.BMCPKBIJMEB)
			{
				bool activeSelf = this.costHard.activeSelf;
				if (this.costHard != this.BMCPKBIJMEB)
				{
					this.costHard.SetActive(false);
				}
				this.CAPFGOKNDIM.Clear();
				this.BMCPKBIJMEB.gameObject.SetActive(true);
				this.costHard = UnityEngine.Object.Instantiate<GameObject>(this.BMCPKBIJMEB, this.BMCPKBIJMEB.transform.parent.transform, false);
				this.BMCPKBIJMEB.gameObject.SetActive(false);
				this.FindAllObjectsInChildren(this.costHard);
				this.DACFHPCJJMM(this.LCNJFKDLOBE, jlnkepcmmbf, flag, false);
				if (!BABNFFJPGNB)
				{
					if (activeSelf)
					{
						this.costHard.SetActive(true);
					}
					else
					{
						this.costHard.SetActive(false);
					}
				}
			}
			if (null == this.BKAPOAIFOJC)
			{
				this.BKAPOAIFOJC = this.costAd;
			}
			if (null != this.BKAPOAIFOJC)
			{
				bool activeSelf2 = this.costAd.activeSelf;
				if (this.costAd != this.BKAPOAIFOJC)
				{
					this.costAd.SetActive(false);
				}
				this.CAPFGOKNDIM.Clear();
				this.BKAPOAIFOJC.gameObject.SetActive(true);
				this.costAd = UnityEngine.Object.Instantiate<GameObject>(this.BKAPOAIFOJC, this.BKAPOAIFOJC.transform.parent.transform, false);
				this.BKAPOAIFOJC.gameObject.SetActive(false);
				this.FindAllObjectsInChildren(this.costAd);
				this.DACFHPCJJMM(this.LCNJFKDLOBE, jlnkepcmmbf, flag, true);
				if (!BABNFFJPGNB)
				{
					if (activeSelf2)
					{
						this.costAd.SetActive(true);
					}
					else
					{
						this.costAd.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		if (BABNFFJPGNB)
		{
			this.SwitchCost(false);
		}
		else
		{
			this.JHPNFJMHNAA();
		}
		this.FLPGHFGEHDO();
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x001DE3A8 File Offset: 0x001DC5A8
	private void HNHJIEGPEBN(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (!this.JAFGPBOFJIK || null == HPKCBGIKNFE)
		{
			return;
		}
		HPKCBGIKNFE.enableAutoSizing = this.KNBOBIEPIFF;
		HPKCBGIKNFE.fontSize = this.IOPDLCNEBNB;
		HPKCBGIKNFE.fontSizeMax = this.BKONCOAHBNK;
		HPKCBGIKNFE.fontSizeMin = this.GPACLGOCNCD;
		HPKCBGIKNFE.enableWordWrapping = this.BDFKDNPIBCE;
		LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
		if (null != component)
		{
			component.preferredWidth = this.KMACONJNKMP;
		}
		HPKCBGIKNFE.fontStyle = this.JGOKGLNKNNC;
	}

	// Token: 0x0600447C RID: 17532 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x0600447D RID: 17533 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x0600447E RID: 17534 RVA: 0x001DE42C File Offset: 0x001DC62C
	public void FindAllObjectsInChildren(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x001DE47C File Offset: 0x001DC67C
	private void IMFLOJHCHLK(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (!this.JAFGPBOFJIK || null == HPKCBGIKNFE)
		{
			return;
		}
		HPKCBGIKNFE.enableAutoSizing = this.KNBOBIEPIFF;
		HPKCBGIKNFE.fontSize = this.IOPDLCNEBNB;
		HPKCBGIKNFE.fontSizeMax = this.BKONCOAHBNK;
		HPKCBGIKNFE.fontSizeMin = this.GPACLGOCNCD;
		HPKCBGIKNFE.enableWordWrapping = this.BDFKDNPIBCE;
		LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
		if (null != component)
		{
			component.preferredWidth = this.KMACONJNKMP;
		}
		HPKCBGIKNFE.fontStyle = this.JGOKGLNKNNC;
	}

	// Token: 0x06004480 RID: 17536 RVA: 0x001DE4FF File Offset: 0x001DC6FF
	public void IGHKPHJEJJC()
	{
		this.EKNDOKJDMDP = false;
		this.OFHENGEEBCN = "plht";
		this.PADKDOIGBMG = false;
		this.IMFLOJHCHLK(this.premiumCostText);
	}

	// Token: 0x06004481 RID: 17537 RVA: 0x001DDB78 File Offset: 0x001DBD78
	private void OnDestroy()
	{
		this.CAPFGOKNDIM.Clear();
		this.BMCPKBIJMEB = null;
		this.BKAPOAIFOJC = null;
	}

	// Token: 0x06004482 RID: 17538 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06004483 RID: 17539 RVA: 0x001DDB78 File Offset: 0x001DBD78
	private void HKHKMPLGKBO()
	{
		this.CAPFGOKNDIM.Clear();
		this.BMCPKBIJMEB = null;
		this.BKAPOAIFOJC = null;
	}

	// Token: 0x06004484 RID: 17540 RVA: 0x001DE528 File Offset: 0x001DC728
	private void PDMNJGBFMAF(TextMeshProUGUI HPKCBGIKNFE)
	{
		if (null == HPKCBGIKNFE)
		{
			return;
		}
		this.ELDKNNIBFNB(HPKCBGIKNFE);
		if (!this.PADKDOIGBMG)
		{
			this.EAKMCJCOGMF(HPKCBGIKNFE);
			float num = Mathf.Max(12f, (this.KNBOBIEPIFF ? this.BKONCOAHBNK : this.IOPDLCNEBNB) + -4f);
			HPKCBGIKNFE.enableWordWrapping = false;
			HPKCBGIKNFE.enableAutoSizing = false;
			HPKCBGIKNFE.fontSize = num;
			float preferredWidth = HPKCBGIKNFE.preferredWidth;
			LayoutElement component = HPKCBGIKNFE.GetComponent<LayoutElement>();
			if (preferredWidth <= 180f)
			{
				return;
			}
			if (null != component)
			{
				component.preferredWidth = 180f;
			}
			else
			{
				HPKCBGIKNFE.rectTransform.sizeDelta = new Vector2(180f, HPKCBGIKNFE.rectTransform.sizeDelta.y);
			}
			HPKCBGIKNFE.enableAutoSizing = true;
			HPKCBGIKNFE.fontSizeMin = 12f;
			HPKCBGIKNFE.fontSizeMax = num;
			return;
		}
		else
		{
			if (null == this.choiceText)
			{
				return;
			}
			HPKCBGIKNFE.enableAutoSizing = false;
			HPKCBGIKNFE.fontSize = 30f;
			HPKCBGIKNFE.fontStyle = (FontStyles.Bold | FontStyles.Italic);
			return;
		}
	}

	// Token: 0x06004485 RID: 17541 RVA: 0x001DC5F2 File Offset: 0x001DA7F2
	private void BMNPAJCFKGP()
	{
		this.UpdateParams(true);
	}

	// Token: 0x06004486 RID: 17542 RVA: 0x001DE628 File Offset: 0x001DC828
	private void GFOOFKDLPAC(bool BIFIEKGCGBE, bool JLNKEPCMMBF, bool DDIJCAIHHEK, bool LALKLDBINGD)
	{
		if (BIFIEKGCGBE || JLNKEPCMMBF || DDIJCAIHHEK)
		{
			if (BIFIEKGCGBE)
			{
				JLNKEPCMMBF = true;
				DDIJCAIHHEK = true;
			}
			int i = 1;
			while (i < this.CAPFGOKNDIM.Count)
			{
				if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") && this.CAPFGOKNDIM[i].activeSelf)
				{
					if (BIFIEKGCGBE)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass) != null)
						{
							if (ODLJHDIGLGO.JOACGOLGGNH(CLHDENLPOFP.gamePass).LLLJOBODOAL == 1)
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.goldSubscriptionSprite;
							}
							else
							{
								gameObject.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.premSubscriptionSprite;
							}
						}
						else
						{
							gameObject.GetComponent<Image>().sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.goldSubscriptionSprite;
						}
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component = gameObject.GetComponent<RectTransform>();
						component.AMPMCKEAACJ(this.subscriptionIconScale, this.subscriptionIconScale, this.subscriptionIconScale);
						gameObject.GetComponent<Image>().SetNativeSize();
						component.anchorMin = new Vector2(694f, 1144f);
						component.anchorMax = new Vector2(956f, 1897f);
						component.pivot = new Vector2(1670f, 322f);
						component.anchoredPosition = Vector2.zero;
						component.AHLJBONHHKL(this.subscriptionIconOffsetX, this.subscriptionIconOffsetY);
					}
					if (LALKLDBINGD && JLNKEPCMMBF)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, true);
						gameObject2.GetComponent<Image>().sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.percentSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component2 = gameObject2.GetComponent<RectTransform>();
						component2.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject2.GetComponent<Image>().SetNativeSize();
						component2.anchorMin = new Vector2(574f, 1645f);
						component2.anchorMax = new Vector2(1594f, 379f);
						component2.pivot = new Vector2(1719f, 1259f);
						component2.anchoredPosition = Vector2.zero;
						component2.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject2.transform.childCount > 0)
						{
							gameObject2.transform.GetChild(0).gameObject.SetActive(false);
							return;
						}
						break;
					}
					else
					{
						if (LALKLDBINGD || !DDIJCAIHHEK)
						{
							break;
						}
						GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.CAPFGOKNDIM[i], this.CAPFGOKNDIM[i].transform, false);
						gameObject3.GetComponent<Image>().sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.freeChoiceSubscriptionSprite;
						this.CAPFGOKNDIM[i].GetComponent<RectTransform>();
						RectTransform component3 = gameObject3.GetComponent<RectTransform>();
						component3.AMPMCKEAACJ(this.discPercentIconScale, this.discPercentIconScale, this.discPercentIconScale);
						gameObject3.GetComponent<Image>().SetNativeSize();
						component3.anchorMin = new Vector2(1666f, 1655f);
						component3.anchorMax = new Vector2(1923f, 713f);
						component3.pivot = new Vector2(853f, 840f);
						component3.anchoredPosition = Vector2.zero;
						component3.AHLJBONHHKL(this.discPercentIconOffsetX, this.discPercentIconOffsetY);
						if (gameObject3.transform.childCount > 1)
						{
							gameObject3.transform.GetChild(1).gameObject.SetActive(false);
							return;
						}
						break;
					}
				}
				else
				{
					i++;
				}
			}
		}
	}

	// Token: 0x06004487 RID: 17543 RVA: 0x001DC5F2 File Offset: 0x001DA7F2
	private void GGFKNPMAAFG()
	{
		this.UpdateParams(true);
	}

	// Token: 0x06004488 RID: 17544 RVA: 0x001DC83C File Offset: 0x001DAA3C
	private void IAIIODBDKHK()
	{
		this.UpdateParams(false);
	}

	// Token: 0x040012D0 RID: 4816
	public TextMeshProUGUI choiceText;

	// Token: 0x040012D1 RID: 4817
	public TextMeshProUGUI premiumCostText;

	// Token: 0x040012D2 RID: 4818
	public GameObject tipObject;

	// Token: 0x040012D3 RID: 4819
	public GameObject costHard;

	// Token: 0x040012D4 RID: 4820
	public GameObject costAd;

	// Token: 0x040012D5 RID: 4821
	public List<Image> hints;

	// Token: 0x040012D6 RID: 4822
	public float subscriptionIconScale = 0.55f;

	// Token: 0x040012D7 RID: 4823
	public float subscriptionIconOffsetX;

	// Token: 0x040012D8 RID: 4824
	public float subscriptionIconOffsetY = 5f;

	// Token: 0x040012D9 RID: 4825
	public float discPercentIconScale = 0.9f;

	// Token: 0x040012DA RID: 4826
	public float discPercentIconOffsetX = 22f;

	// Token: 0x040012DB RID: 4827
	public float discPercentIconOffsetY = -11f;

	// Token: 0x040012DC RID: 4828
	public int choiceTextRightMaxExtension;

	// Token: 0x040012DD RID: 4829
	public int choiceTextRightExtraExtensionPerChar = 16;

	// Token: 0x040012DE RID: 4830
	private int CENMIEOCAMN = 150;

	// Token: 0x040012DF RID: 4831
	private int CNBAKCPOCBC;

	// Token: 0x040012E0 RID: 4832
	private bool LCNJFKDLOBE;

	// Token: 0x040012E1 RID: 4833
	private int BGIOGOACCBJ = -1;

	// Token: 0x040012E2 RID: 4834
	private int DFMHLDEJKNF = -1;

	// Token: 0x040012E3 RID: 4835
	private int HFOOOHGGPMA = -1;

	// Token: 0x040012E4 RID: 4836
	private List<GameObject> CAPFGOKNDIM = new List<GameObject>();

	// Token: 0x040012E5 RID: 4837
	private GameObject BMCPKBIJMEB;

	// Token: 0x040012E6 RID: 4838
	private GameObject BKAPOAIFOJC;

	// Token: 0x040012E7 RID: 4839
	private BELMEMPLMGE EMNFNFALMGA;

	// Token: 0x040012E8 RID: 4840
	private bool EKNDOKJDMDP;

	// Token: 0x040012E9 RID: 4841
	private string OFHENGEEBCN = "";

	// Token: 0x040012EA RID: 4842
	private Vector2 FGNGNPJEBJH = Vector2.zero;

	// Token: 0x040012EB RID: 4843
	private bool PADKDOIGBMG;

	// Token: 0x040012EC RID: 4844
	private bool JAFGPBOFJIK;

	// Token: 0x040012ED RID: 4845
	private bool KNBOBIEPIFF;

	// Token: 0x040012EE RID: 4846
	private float IOPDLCNEBNB;

	// Token: 0x040012EF RID: 4847
	private float BKONCOAHBNK;

	// Token: 0x040012F0 RID: 4848
	private float GPACLGOCNCD;

	// Token: 0x040012F1 RID: 4849
	private bool BDFKDNPIBCE = true;

	// Token: 0x040012F2 RID: 4850
	private float KMACONJNKMP = -1f;

	// Token: 0x040012F3 RID: 4851
	private FontStyles JGOKGLNKNNC;

	// Token: 0x040012F4 RID: 4852
	private const float LEOOJBCONPL = 180f;

	// Token: 0x040012F5 RID: 4853
	private const float HJPEJGHDFFJ = 12f;

	// Token: 0x040012F6 RID: 4854
	private const float CIHEPCCKADF = -4f;
}
