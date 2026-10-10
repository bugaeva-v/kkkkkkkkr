using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000059 RID: 89
public class ContentCardItem : MonoBehaviour
{
	// Token: 0x06000C6B RID: 3179 RVA: 0x00058EDC File Offset: 0x000570DC
	public void IEMAALPOKEM()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00058F18 File Offset: 0x00057118
	public bool OPOCIEEFCFM(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.GPJFGPAPAAD(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IGJAMEGBDBG().MLGLKDJKMIC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.KMNBCEMEBBD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "geoc");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NJDLPEAMLDB();
		return true;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x000590B4 File Offset: 0x000572B4
	public void GOHFGNDHDMF(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NANJJIAKLJM(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0005912C File Offset: 0x0005732C
	private void JIJNNDHINGK()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00059190 File Offset: 0x00057390
	private void OnDestroy()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00058EDC File Offset: 0x000570DC
	public void MMNKAACEFDE()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x000591F4 File Offset: 0x000573F4
	public bool IPLLLKMPAHE(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.CPEIACLBMDO(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IIMIJHGEGBJ().FPLLNEBKBJI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.IKNOFBFMPGA().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "OnBackendGetPublicProfileHallOfFameMoreSuccess");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.IIMIJHGEGBJ().MAPKDKPEMJI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.CheckElementHeight();
		return true;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00059390 File Offset: 0x00057590
	public bool IJAEGNCEELA(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.KMKGLFOIDLH(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.BFCHJBOOJKE().NGFAKFCKPND(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.IKNOFBFMPGA().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "ext");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().GOCKPKIAGBL(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.IDMGKLJBLHE();
		return true;
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0005952C File Offset: 0x0005772C
	private void AKANLCOCAPH()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00059590 File Offset: 0x00057790
	private void OLOGCFJNDGF()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x000595F4 File Offset: 0x000577F4
	private void MOHLNGBBIOB()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00059658 File Offset: 0x00057858
	private void JNKPKECPLCB()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x000596BC File Offset: 0x000578BC
	public bool CHHCPMCHNEH(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.MKJDCEEMHFJ(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().FPLLNEBKBJI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.IKNOFBFMPGA().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "w");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.BFCHJBOOJKE().CHAHIKPDPPC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.LHCFBNNIBIO();
		return false;
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00059858 File Offset: 0x00057A58
	public bool HDLEBKHCGEJ(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.EMKECGJCHBA(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.EHBBFMCILPC.AJOBCOEGFNI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.IKNOFBFMPGA().NLNFCPEMPMP(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "OnBackendRequestShareHardSuccess");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().GOCKPKIAGBL(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.KCOLLDMJLMA();
		return true;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void HAJLECEKDJP()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00059A30 File Offset: 0x00057C30
	public void FJEHODNDEOK(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x00059AA8 File Offset: 0x00057CA8
	private void GNNPHHGDPLN()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00058EDC File Offset: 0x000570DC
	public void CLEHNPPAEME()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00058EDC File Offset: 0x000570DC
	public void APIGLDMEHIM()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void ONKABGHEHAN()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00059B0C File Offset: 0x00057D0C
	public void EJDMFLBJIKB(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void PFMLCNPFDOD()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00059B84 File Offset: 0x00057D84
	private void BPFJJHDHJFJ()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00059BE8 File Offset: 0x00057DE8
	public void NIHKMCNLHDJ(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00059C60 File Offset: 0x00057E60
	public bool NLIKDFIMLNP(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.MKJDCEEMHFJ(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().MLGLKDJKMIC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "\u2003");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().CHAHIKPDPPC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NOKJKJMKFPF();
		return true;
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x00058EDC File Offset: 0x000570DC
	public void FHMIGLINAJD()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00059DFC File Offset: 0x00057FFC
	public bool NLAEDEAFAGL(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.BNINPCBAIED(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AEELGGPEJCC().AJOBCOEGFNI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "ok");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.IIMIJHGEGBJ().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NAALMJLKJKB();
		return true;
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00059F98 File Offset: 0x00058198
	public bool AKEEGPFCOGM(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.CNCJEBNOBGH(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().KHPJHFNCBCI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.IKNOFBFMPGA().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "acliffbw21");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().BJONDKFLBMI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.FBGJJEDMDDM();
		return true;
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0005A134 File Offset: 0x00058334
	public bool MHJMGGPKNBE(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.OAACDENJBEP(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.EHBBFMCILPC.LKNCGPCLEAL(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.KMNBCEMEBBD().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "*");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NPJMKNFIDPI();
		return true;
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0005A2D0 File Offset: 0x000584D0
	public bool EOFDLFCFAHB(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.FEDOJBIODEH(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().LKNCGPCLEAL(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.NMGMNAKLLMI().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "digitalglitch");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().GOCKPKIAGBL(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.HENNGOBIFAG();
		return true;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0005A46C File Offset: 0x0005866C
	private void IGNHKDONHED()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0005A4D0 File Offset: 0x000586D0
	public void GOGGFKMPLOP(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void FCDKFGJHJNL()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0005A548 File Offset: 0x00058748
	public bool GGNPLGJNJBA(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.MPDCKNMKANI(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().LKNCGPCLEAL(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NMGMNAKLLMI().PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "wshcdshc");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().GOCKPKIAGBL(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.DCJKIDEJOAB(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.KCOLLDMJLMA();
		return false;
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0005A6E4 File Offset: 0x000588E4
	private void LOLPCOLPHLJ()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00058EDC File Offset: 0x000570DC
	public void ResetItem()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0005A758 File Offset: 0x00058958
	public bool SetContent(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.GLOKBBFKHBD(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.CheckElementHeight();
		return true;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0005A8F4 File Offset: 0x00058AF4
	public bool CANDMGDHGGC(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.GMHNMMNNLEG(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IGJAMEGBDBG().FPLLNEBKBJI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "OnCutsceneViewAssetsDownloadFailed");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AEELGGPEJCC().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.LHCFBNNIBIO();
		return true;
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0005AA90 File Offset: 0x00058C90
	private void DJIFHJDBBHN()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void FBIJBDOFENH()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00058EDC File Offset: 0x000570DC
	public void FDDMNAJPDIB()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00058EDC File Offset: 0x000570DC
	public void AMHMHKOMAHE()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void OPCALFLELBD()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0005AAF4 File Offset: 0x00058CF4
	public void NHBAKLHDDGL(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00058EDC File Offset: 0x000570DC
	public void PFIICHHLGBI()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0005AB6C File Offset: 0x00058D6C
	private void JLCJJONEBIB()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00058EDC File Offset: 0x000570DC
	public void BBGLAGCDLCI()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0005ABD0 File Offset: 0x00058DD0
	public void CJOBPGGPGAO(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00058EDC File Offset: 0x000570DC
	public void JPJKGPONBEB()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0005AC48 File Offset: 0x00058E48
	public void NHALGDJOMBD(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NANJJIAKLJM(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0005ACC0 File Offset: 0x00058EC0
	public bool GINANAIPOPG(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.FFLIOKACDCF(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AKFNLMBNELK().AJOBCOEGFNI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NMGMNAKLLMI().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "per");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().CHAHIKPDPPC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.FOGLGMFEBKP();
		return true;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0005AE5C File Offset: 0x0005905C
	public void GELJFPIGGHE(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0005AED4 File Offset: 0x000590D4
	public void OGCOIHPFLJN(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NANJJIAKLJM(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0005AF4C File Offset: 0x0005914C
	public bool OAACGALMOEG(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.OAACDENJBEP(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.EHBBFMCILPC.KHPJHFNCBCI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? " scale");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().OLEKDAJGKKC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.KCOLLDMJLMA();
		return true;
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0005B0E8 File Offset: 0x000592E8
	private void FIIIEHFCHMH()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00058EDC File Offset: 0x000570DC
	public void AFIEOLMAMCC()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void KJDADJAODNA()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void MPGDDLJPICG()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00058EDC File Offset: 0x000570DC
	public void PBEIEFDPMBK()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x0005B14C File Offset: 0x0005934C
	public void BMLJNJPMDKG(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NANJJIAKLJM(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00058EDC File Offset: 0x000570DC
	public void FHNEIHCJPLM()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x0005B1C4 File Offset: 0x000593C4
	private void CFHFGNOIPEC()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void EEMCFMJLBHK()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0005B228 File Offset: 0x00059428
	public bool IODPCDICGIO(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.BAIJNAICOHB(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IGJAMEGBDBG().AJOBCOEGFNI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.EHBBFMCILPC.IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? " parentCards=");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().MAPKDKPEMJI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.DMEEIPBHABJ();
		return false;
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0005B3C4 File Offset: 0x000595C4
	public void OnItemSelectPress(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x0005B43C File Offset: 0x0005963C
	private void MAHJANFJIMG()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x0005B4A0 File Offset: 0x000596A0
	public bool POCEBECBIAD(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.OAACDENJBEP(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().NGFAKFCKPND(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "tbits");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().BJONDKFLBMI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NEHMFMJBBIP();
		return true;
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00058EDC File Offset: 0x000570DC
	public void EHGNFAJMIGJ()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x0005B63C File Offset: 0x0005983C
	public bool HGGFKAJMJHC(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.IIHJEMOFLCO(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AEELGGPEJCC().KHPJHFNCBCI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.NLDDLLEKNFD().NLNFCPEMPMP(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "mfs");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().BJONDKFLBMI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.FIHOFBIMDIK();
		return false;
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x0005B7D8 File Offset: 0x000599D8
	public bool EALKNNJJOJJ(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.OPCKDFKLNJB(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AKFNLMBNELK().NKPFPJGEFBC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(true);
		}
		int lmcedchdiib = GDJPPKAMIFL.IIMIJHGEGBJ().OLEKDAJGKKC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NJDLPEAMLDB();
		return false;
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x0005B974 File Offset: 0x00059B74
	public bool BDFPDONCCBM(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.MKJDCEEMHFJ(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.NKJBCCNGIDP().DKHIPEPOEFF(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.KMNBCEMEBBD().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.NLNFCPEMPMP(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "AdsManagerLP: ShowAdRewarded() called");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().BJONDKFLBMI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NPJMKNFIDPI();
		return true;
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void GOABOGNFCFH()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x0005BB10 File Offset: 0x00059D10
	private void CPLFHCNHAOK()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00058EDC File Offset: 0x000570DC
	public void GLKLNMEDDHH()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x0005BB74 File Offset: 0x00059D74
	private void NGEFPBFMCBP()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x0005BBD8 File Offset: 0x00059DD8
	public void NJGHEFDCHGH(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.DAFPKEKPIDH(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void SelectItem()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00058EDC File Offset: 0x000570DC
	public void FHPBMCLGGGP()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x0005BC50 File Offset: 0x00059E50
	public void JDFOKPMBHML(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x0005BCC8 File Offset: 0x00059EC8
	private void DLBAEDOFAKM()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void ADEIIKEBBIM()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x0005BD2C File Offset: 0x00059F2C
	public void FCDMLJDCLDL(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x0005BDA4 File Offset: 0x00059FA4
	public bool FHCPOJJPAKF(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.JLNKBIDOLCJ(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IGJAMEGBDBG().MLGLKDJKMIC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.NKJBCCNGIDP().MAPKDKPEMJI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.EJCGGHJAGDD();
		return true;
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0005BF40 File Offset: 0x0005A140
	public bool PKFCOOFBMGI(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.LMJJBAIIMJD(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.IIMIJHGEGBJ().DKHIPEPOEFF(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.IKNOFBFMPGA().PMPOHILDCPD(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.NMGMNAKLLMI().PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "+");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NAALMJLKJKB();
		return true;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x0005C0DC File Offset: 0x0005A2DC
	public bool GIONKOFHDED(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset2.KMKGLFOIDLH(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AKFNLMBNELK().NKPFPJGEFBC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.IKNOFBFMPGA().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "loungegempassbody");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.EMJJHFFALGN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.FBNODOKNCFM();
		return false;
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0005C278 File Offset: 0x0005A478
	private void CODLJCAKBLI()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x0005C2DC File Offset: 0x0005A4DC
	private void KLGMKIJJDFN()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0005C340 File Offset: 0x0005A540
	private void FEBECEEIHBP()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x0005C3A4 File Offset: 0x0005A5A4
	private void GGKLFBOIKMF()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x0005C408 File Offset: 0x0005A608
	private void MFINONMBMLM()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void CABMLHIIJFN()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void IIIBFFFBILH()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void ILODCFEBLIK()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void OGHDNEJCDFM()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0005C46C File Offset: 0x0005A66C
	public bool GLFPBCIMPOF(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.FBIAFOCMCOH(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AKFNLMBNELK().LKNCGPCLEAL(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.NLNFCPEMPMP(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "strtd");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.EHBBFMCILPC.GOCKPKIAGBL(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.INMHGDMNBIC();
		return false;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0005C608 File Offset: 0x0005A808
	public void MOFNAIHOKFN(int DBHMNECMIAB)
	{
		this.isSelected = !this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEMMEPMLPHJ(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x0005C680 File Offset: 0x0005A880
	public bool NHABDDCIEJG(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.BICOCFIOBOO(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AEELGGPEJCC().MLGLKDJKMIC(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().NLNFCPEMPMP(ljalnkfbkaa.id).HFLPLGMJNOI > 0)
			{
				this.giftText.text = (LJNMIPMNOKF.KMNBCEMEBBD().GHDJEAHFBNE(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "OnLobbyWheelDataCdnSuccess");
				this.giftContainer.SetActive(false);
			}
			else
			{
				this.giftContainer.SetActive(false);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.BFCHJBOOJKE().OLEKDAJGKKC(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.AABFALENMEN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.FNGPHGJMIFG();
		return true;
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x0005C81C File Offset: 0x0005AA1C
	public void OHBIOHOOFNM(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEMMEPMLPHJ(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0005C894 File Offset: 0x0005AA94
	private void FPFFGFPEPIG()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
	public bool KDDLHGMIPBF(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.IIHJEMOFLCO(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AEELGGPEJCC().LKNCGPCLEAL(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(true);
				this.giftContainer.SetActive(false);
			}
			else if (LJNMIPMNOKF.NMGMNAKLLMI().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.EHBBFMCILPC.PKNBMDKLJJK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "igeh");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(false);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.AKFNLMBNELK().BFNABELHMLB(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.DHDDLCPEBIF();
		return true;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void KFOMBNCINHD()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0005CA94 File Offset: 0x0005AC94
	private void PDHDJMJECJA()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
	private void CKNCEKFOLKD()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0005CB5C File Offset: 0x0005AD5C
	public void ELGJKLHHKPG(int DBHMNECMIAB)
	{
		this.isSelected = this.isSelected;
		if (this.isSelected)
		{
			AKLFPGMDKLA.EHBBFMCILPC.MEIFPLJPACP(DBHMNECMIAB);
		}
		else
		{
			AKLFPGMDKLA.EHBBFMCILPC.NIBNLDPFEFG(DBHMNECMIAB);
		}
		AKLFPGMDKLA.EHBBFMCILPC.CIPCINKGILF = false;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x0005CBD4 File Offset: 0x0005ADD4
	private void OHNEKLLPBDN()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void HPMNCMDBCOB()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void GFLMBJMJKJO()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0005CC38 File Offset: 0x0005AE38
	private void LEEEOAHDCJD()
	{
		try
		{
			if (null != this.tradingFrameAnimation)
			{
				if (null != this.tradingFrameAnimation.GetComponent<Image>())
				{
					this.tradingFrameAnimation.GetComponent<Image>().sprite = null;
				}
				this.tradingFrameAnimation.framesSD = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x000599F3 File Offset: 0x00057BF3
	public void CGFMKIBAOJI()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(this.isSelected);
		this.selectedBorder.transform.parent.gameObject.SetActive(this.isSelected);
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x0005CC9C File Offset: 0x0005AE9C
	public bool CBGIDNBIBAP(int DBHMNECMIAB, bool GIFPFPOPEJN, Vector2 ONKONHLJKPG, bool FNMALDADBPO = false, bool DEOILFBCNCM = false)
	{
		ContentCardItem.LJALNKFBKAA ljalnkfbkaa = new ContentCardItem.LJALNKFBKAA();
		ljalnkfbkaa.<>4__this = this;
		ljalnkfbkaa.id = DBHMNECMIAB;
		this.cardId = ljalnkfbkaa.id;
		this.cardThumb.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset2.MPDCKNMKANI(ljalnkfbkaa.id);
		if (!FNMALDADBPO)
		{
			this.volumeText.text = GDJPPKAMIFL.AKFNLMBNELK().FPLLNEBKBJI(ljalnkfbkaa.id);
			if (GIFPFPOPEJN)
			{
				this.volumeContainer.SetActive(false);
				this.giftContainer.SetActive(true);
			}
			else if (LJNMIPMNOKF.NLDDLLEKNFD().KMDBNEFCPOH(ljalnkfbkaa.id).HFLPLGMJNOI > 1)
			{
				this.giftText.text = (LJNMIPMNOKF.NMGMNAKLLMI().IDDLPADHANK(ljalnkfbkaa.id).HFLPLGMJNOI.ToString() ?? "23819D");
				this.giftContainer.SetActive(true);
			}
			else
			{
				this.giftContainer.SetActive(true);
			}
		}
		else
		{
			this.volumeContainer.SetActive(true);
			this.giftContainer.SetActive(false);
		}
		int lmcedchdiib = GDJPPKAMIFL.IGJAMEGBDBG().MAPKDKPEMJI(ljalnkfbkaa.id);
		this.rarityGemImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.HKMDCMOJOIN(lmcedchdiib);
		if (FNMALDADBPO)
		{
			this.isSelected = DEOILFBCNCM;
			this.selectedBorder.SetActive(DEOILFBCNCM);
			this.selectedBorder.transform.parent.gameObject.SetActive(DEOILFBCNCM);
			this.onCardPressButton.onClick.AddListener(new UnityAction(ljalnkfbkaa.FKHKHDCHMJH));
		}
		this.itemHider.upDownMargin = ONKONHLJKPG;
		this.itemHider.NJDLPEAMLDB();
		return false;
	}

	// Token: 0x040003ED RID: 1005
	public Button onCardPressButton;

	// Token: 0x040003EE RID: 1006
	public ImageFrameAnimation tradingFrameAnimation;

	// Token: 0x040003EF RID: 1007
	public CanvasGroup canvasGroup;

	// Token: 0x040003F0 RID: 1008
	[HideInInspector]
	public bool isSelected;

	// Token: 0x040003F1 RID: 1009
	[NonSerialized]
	public int cardId = -1;

	// Token: 0x040003F2 RID: 1010
	[SerializeField]
	private ItemHider itemHider;

	// Token: 0x040003F3 RID: 1011
	[SerializeField]
	private Image cardThumb;

	// Token: 0x040003F4 RID: 1012
	[SerializeField]
	private Image rarityGemImage;

	// Token: 0x040003F5 RID: 1013
	[SerializeField]
	private TextMeshProUGUI volumeText;

	// Token: 0x040003F6 RID: 1014
	[SerializeField]
	private TextMeshProUGUI giftText;

	// Token: 0x040003F7 RID: 1015
	[SerializeField]
	private GameObject volumeContainer;

	// Token: 0x040003F8 RID: 1016
	[SerializeField]
	private GameObject giftContainer;

	// Token: 0x040003F9 RID: 1017
	[SerializeField]
	private GameObject selectedBorder;

	// Token: 0x0200005A RID: 90
	[CompilerGenerated]
	private sealed class LJALNKFBKAA
	{
		// Token: 0x06000CDA RID: 3290 RVA: 0x0005CE37 File Offset: 0x0005B037
		internal void FKHKHDCHMJH()
		{
			this.<>4__this.OnItemSelectPress(this.id);
		}

		// Token: 0x040003FA RID: 1018
		public ContentCardItem <>4__this;

		// Token: 0x040003FB RID: 1019
		public int id;
	}
}
