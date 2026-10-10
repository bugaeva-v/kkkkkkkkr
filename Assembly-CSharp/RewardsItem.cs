using System;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200022B RID: 555
public class RewardsItem : MonoBehaviour
{
	// Token: 0x060045FE RID: 17918 RVA: 0x001E46FC File Offset: 0x001E28FC
	private void OOHAOIKBHDF()
	{
		AppManager.AGANFKKBPFO().RestartApp(false, true);
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x001E470A File Offset: 0x001E290A
	private void MJMPABJFGLI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count > 1)
		{
			this.rewardFirstEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardFirstEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004600 RID: 17920 RVA: 0x001E4744 File Offset: 0x001E2944
	private void GJMIHJNBPEB()
	{
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("socialcollectedcardopenv2", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("importanttitle", new UnityAction(this.HDPCAMJNDFB));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO("AVATAR.CLIENT.TRINKET", new UnityAction(this.PCPNGJABDCN));
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("sfxsparklesbundles", new UnityAction(this.KJMCPJHGOPN));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("ontradingcardclickbodymatch", new UnityAction(this.DDOCLBFAFOB));
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x000AD7FE File Offset: 0x000AB9FE
	private void NHNDBFDFDBD()
	{
		AppManager.PCJEMMDDCIF().RestartApp(false, false);
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x001E47D8 File Offset: 0x001E29D8
	private void HKGIDEGHOPK()
	{
		this.rewardFreePass.gameObject.SetActive(true);
		this.rewardFreePass.button.gameObject.SetActive(false);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
		this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			return;
		}
		if (LiveEventsManager.ONCPHEEJLOP().LiveEventActive(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			this.rewardFreePass.button.gameObject.SetActive(false);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
			this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x001E48D0 File Offset: 0x001E2AD0
	private void LKLABLGBLDC()
	{
		bool flag = LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(true);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x001E491C File Offset: 0x001E2B1C
	private void BEINBCNAJAM()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 1)
		{
			this.rewardReplayEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardReplayEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x001E4954 File Offset: 0x001E2B54
	private void JPAACMOPBIF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JKHJFMOIDNK(AssetsManager.MJBDMHPHMID().anthologyAssets).Count > 1)
		{
			this.rewardStoryComplete.gameObject.SetActive(true);
			return;
		}
		this.rewardStoryComplete.gameObject.SetActive(false);
	}

	// Token: 0x06004607 RID: 17927 RVA: 0x001E49A0 File Offset: 0x001E2BA0
	private void PKPANMAFAIL()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x001E49B3 File Offset: 0x001E2BB3
	private void LBLMBOMEPNI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count > 0)
		{
			this.rewardSubsequentEpisode.gameObject.SetActive(true);
			return;
		}
		this.rewardSubsequentEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x001E49EA File Offset: 0x001E2BEA
	private void NOPEMDIFHLO()
	{
		if (!KHPGPLAMAIN.IGKCLMLPLAC() || !AdsManagerLP.AININGBPKNC().MMBBMDNBHJL())
		{
			this.rewardFreeDiamonds.gameObject.SetActive(false);
			return;
		}
		this.rewardFreeDiamonds.gameObject.SetActive(false);
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x001E4A24 File Offset: 0x001E2C24
	private void OLCFIOBMEEM()
	{
		this.rewardOffer.gameObject.SetActive(true);
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && lmhhkdfckfc.DEJCCBNPFEC.Equals(this.rewardOffer.extraData))
		{
			this.rewardOffer.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x001E4A7C File Offset: 0x001E2C7C
	private void NOHLBJLHDKL()
	{
		bool flag = LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardNewsletterSubscribe.gameObject.SetActive(false);
			this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
			return;
		}
		this.rewardNewsletterUnsubscribe.gameObject.SetActive(true);
		this.rewardNewsletterSubscribe.gameObject.SetActive(false);
	}

	// Token: 0x0600460C RID: 17932 RVA: 0x001E4AEC File Offset: 0x001E2CEC
	private void FNEIJBCOEIG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() < 6)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(false);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(false);
	}

	// Token: 0x0600460D RID: 17933 RVA: 0x001E4B44 File Offset: 0x001E2D44
	private void JEPBEGCDBIK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.LPKLANAEIFF() < 0)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(false);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(false);
	}

	// Token: 0x0600460E RID: 17934 RVA: 0x001E4B9C File Offset: 0x001E2D9C
	private void GFLBCHMCDFA()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() < 3)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(true);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(false);
	}

	// Token: 0x0600460F RID: 17935 RVA: 0x001E4BF4 File Offset: 0x001E2DF4
	private void PACLPFDOHEI()
	{
		this.EKDCKDCCBNC();
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x001E4BFC File Offset: 0x001E2DFC
	private void NNFAJKHLLPI()
	{
		this.rewardFreePass.gameObject.SetActive(false);
		this.rewardFreePass.button.gameObject.SetActive(false);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
		this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(false);
			return;
		}
		if (LiveEventsManager.NMGMNAKLLMI().LiveEventActive(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			this.rewardFreePass.button.gameObject.SetActive(false);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(true);
			this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x001E4CF4 File Offset: 0x001E2EF4
	private void IFBCKJLCCAK()
	{
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("spr", new UnityAction(this.HIHEJJJFAMN));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("OnBackendGetPublicProfileProfileItemException", new UnityAction(this.ODFIJJHCPJC));
		AOBJLALDBAA.AGANFKKBPFO().EFKNEJFLGED("", new UnityAction(this.PCPNGJABDCN));
		AOBJLALDBAA.BIAEAOMHBMM().BADOPKAOCPE("myprreportdonebody", new UnityAction(this.KLKJIFBGMDK));
		AOBJLALDBAA.CEGAOMEEFBE().PEFKJOKLEDL("acli20", new UnityAction(this.FHIJEDNKIJP));
		this.CDBAINELEJK();
		this.HKGIDEGHOPK();
		this.JKEJMGJNCKB();
		this.PIDPHNADECC();
		this.LBLMBOMEPNI();
		this.JDOMMKPHEFJ();
		this.JPAACMOPBIF();
		this.AKFILMNLHOL();
		this.AOMENLAGALH();
		this.IAMBJGNKEBA();
		if (!this.rewardOffer.gameObject.activeSelf && !this.rewardNewsletterSubscribe.gameObject.activeSelf && !this.rewardNewsletterUnsubscribe.gameObject.activeSelf && !this.rewardFreePass.gameObject.activeSelf && !this.rewardPromoCodes.gameObject.activeSelf)
		{
			this.specialOffers.gameObject.SetActive(false);
			return;
		}
		this.specialOffers.gameObject.SetActive(false);
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x001E4E44 File Offset: 0x001E3044
	public void CBNDJKAGOCM()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 1995f;
		base.transform.parent.gameObject.SetActive(true);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x001E4E92 File Offset: 0x001E3092
	public void CIGJHFKGPLG()
	{
		ApplicationFocusManager.Restore();
		this.FEHKNOLIKIB();
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x001E4E9F File Offset: 0x001E309F
	private void BBCGDFALFHJ()
	{
		this.AEGHFFFLPMD();
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x001E4EA8 File Offset: 0x001E30A8
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailSubscribeSuccess", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnEmailUnsubscribeSuccess", new UnityAction(this.PACLPFDOHEI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStartFreePassSuccess", new UnityAction(this.HOCIDADENMH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStartFreePassException", new UnityAction(this.KLKJIFBGMDK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRewardsItemClose", new UnityAction(this.OnRewardsItemClose));
		this.EKDCKDCCBNC();
		this.POJKLCEOENC();
		this.JKEJMGJNCKB();
		this.DAGBBMDMIBK();
		this.LBLMBOMEPNI();
		this.JDOMMKPHEFJ();
		this.EFABNKKOAHF();
		this.GFLBCHMCDFA();
		this.BICLNKMHIGP();
		this.LKLABLGBLDC();
		if (!this.rewardOffer.gameObject.activeSelf && !this.rewardNewsletterSubscribe.gameObject.activeSelf && !this.rewardNewsletterUnsubscribe.gameObject.activeSelf && !this.rewardFreePass.gameObject.activeSelf && !this.rewardPromoCodes.gameObject.activeSelf)
		{
			this.specialOffers.gameObject.SetActive(false);
			return;
		}
		this.specialOffers.gameObject.SetActive(true);
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x001E4FF8 File Offset: 0x001E31F8
	private void ODMFLFFMHPB()
	{
		bool flag = LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardNewsletterSubscribe.gameObject.SetActive(false);
			this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
			return;
		}
		this.rewardNewsletterUnsubscribe.gameObject.SetActive(true);
		this.rewardNewsletterSubscribe.gameObject.SetActive(false);
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x001E5068 File Offset: 0x001E3268
	private void OHKBEIEOPOL()
	{
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("egss", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("", new UnityAction(this.BBCGDFALFHJ));
		AOBJLALDBAA.NMGMNAKLLMI().KDIFKFKMCOH("…", new UnityAction(this.OMFHLLHHFLG));
		AOBJLALDBAA.FILDBDMENPG().MHLNJIACIGO("timerIsHidden", new UnityAction(this.KJMCPJHGOPN));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE("no", new UnityAction(this.OLPHFABHPJF));
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x001E50FC File Offset: 0x001E32FC
	private void FMBNNLJDPDL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KAOAKBKCOGD(AssetsManager.MJBDMHPHMID().anthologyAssets).Count > 0)
		{
			this.rewardStoryComplete.gameObject.SetActive(false);
			return;
		}
		this.rewardStoryComplete.gameObject.SetActive(false);
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x001E4BF4 File Offset: 0x001E2DF4
	private void IOPEFJJGAFF()
	{
		this.EKDCKDCCBNC();
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x001E5148 File Offset: 0x001E3348
	private void EFABNKKOAHF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CEAOAFBKNAP(AssetsManager.EHBBFMCILPC.anthologyAssets).Count > 0)
		{
			this.rewardStoryComplete.gameObject.SetActive(true);
			return;
		}
		this.rewardStoryComplete.gameObject.SetActive(false);
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x001E5194 File Offset: 0x001E3394
	public void FEHKNOLIKIB()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 220f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x001E51E4 File Offset: 0x001E33E4
	private void LBNBBEDFCNC()
	{
		this.rewardOffer.gameObject.SetActive(false);
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && lmhhkdfckfc.DEJCCBNPFEC.Equals(this.rewardOffer.extraData))
		{
			this.rewardOffer.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x001E5239 File Offset: 0x001E3439
	public void AEJHOABFKBC()
	{
		ApplicationFocusManager.Restore();
		this.ANDEEHOKOAE();
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x001E5248 File Offset: 0x001E3448
	private void LDIMKIPOFMA()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.GALKFKBPLCK() < 4)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(true);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(true);
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x001E52A0 File Offset: 0x001E34A0
	private void JDOMMKPHEFJ()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 0)
		{
			this.rewardReplayEpisode.gameObject.SetActive(true);
			return;
		}
		this.rewardReplayEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x001E52D8 File Offset: 0x001E34D8
	public void ANDEEHOKOAE()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 400f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x000AD9BE File Offset: 0x000ABBBE
	private void CFPJGKHKFDH()
	{
		AppManager.EHBBFMCILPC.KKNKNOELPPO(true, false);
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x001E49A0 File Offset: 0x001E2BA0
	private void AMLICNPKJNO()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x001E5328 File Offset: 0x001E3528
	private void HOCIDADENMH()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = GKJPOGNFKNK.BKBCNMEHGFA(int.Parse(this.rewardFreePass.extraData));
		}
		catch (Exception aklgbjkdomm)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		SceneLobbyManager2.returnedFromCompletedStoryChapter = true;
		NAHMBEODKJC.OBDBLLHBGLE();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("freepasssuccess"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0f, 28);
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x001E53E8 File Offset: 0x001E35E8
	private void JKEJMGJNCKB()
	{
		this.rewardOffer.gameObject.SetActive(false);
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && lmhhkdfckfc.DEJCCBNPFEC.Equals(this.rewardOffer.extraData))
		{
			this.rewardOffer.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x001E543D File Offset: 0x001E363D
	private void BICLNKMHIGP()
	{
		if (!KHPGPLAMAIN.NGPOHAPMMAI() || !AdsManagerLP.EHBBFMCILPC.IsReadyRewarded())
		{
			this.rewardFreeDiamonds.gameObject.SetActive(false);
			return;
		}
		this.rewardFreeDiamonds.gameObject.SetActive(true);
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x001E5478 File Offset: 0x001E3678
	public void PreCloseFocus()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 0f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x001E54C8 File Offset: 0x001E36C8
	private void CDBAINELEJK()
	{
		bool flag = LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardNewsletterSubscribe.gameObject.SetActive(true);
			this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
			return;
		}
		this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
		this.rewardNewsletterSubscribe.gameObject.SetActive(false);
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x001E49A0 File Offset: 0x001E2BA0
	private void Start()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x001E5538 File Offset: 0x001E3738
	private void GEPMOBKFIMI()
	{
		AOBJLALDBAA.KKPFOJMAONG().POLEDPIKODD("?uid=", new UnityAction(this.HIHEJJJFAMN));
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("OnLiveProfileThumbnailsCdnSuccess", new UnityAction(this.BBCGDFALFHJ));
		AOBJLALDBAA.BIAEAOMHBMM().MHLNJIACIGO("sfxitemreceived", new UnityAction(this.BAKECOOIHNN));
		AOBJLALDBAA.AGANFKKBPFO().ECDBIBPNBCO("cid", new UnityAction(this.KJMCPJHGOPN));
		AOBJLALDBAA.BIAEAOMHBMM().NAMMLDPCHJO(" ", new UnityAction(this.FHIJEDNKIJP));
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x001E55CC File Offset: 0x001E37CC
	private void IAMBJGNKEBA()
	{
		bool flag = LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(false);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(true);
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x001E5618 File Offset: 0x001E3818
	public void OLPHFABHPJF()
	{
		this.AEJHOABFKBC();
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x001E470A File Offset: 0x001E290A
	private void PIDPHNADECC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count > 1)
		{
			this.rewardFirstEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardFirstEpisode.gameObject.SetActive(false);
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x001E49A0 File Offset: 0x001E2BA0
	private void EBBIFAMPCCI()
	{
		this.PFEEFOKHKMP = base.transform.localScale;
	}

	// Token: 0x0600462F RID: 17967 RVA: 0x001E5620 File Offset: 0x001E3820
	private void ADNBLADBPAN()
	{
		if (!KHPGPLAMAIN.JPFALCGBPBF() || !AdsManagerLP.OOGPALHPNGM().MMBBMDNBHJL())
		{
			this.rewardFreeDiamonds.gameObject.SetActive(true);
			return;
		}
		this.rewardFreeDiamonds.gameObject.SetActive(false);
	}

	// Token: 0x06004630 RID: 17968 RVA: 0x001E5658 File Offset: 0x001E3858
	private void PCPNGJABDCN()
	{
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = GKJPOGNFKNK.BKBCNMEHGFA(int.Parse(this.rewardFreePass.extraData));
		}
		catch (Exception aklgbjkdomm)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		SceneLobbyManager2.returnedFromCompletedStoryChapter = true;
		NAHMBEODKJC.OBDBLLHBGLE();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.BIAEAOMHBMM().IPEIONBNIPH("prefix"), CCOJBMMKNAP.ONCPHEEJLOP().OGKGHLHHAAI("socialbadge"), CCOJBMMKNAP.FEEDGKCJBLE().HDIPNMFHIEJ(""), new UnityAction(this.FDOKONHHAMG), new UnityAction(this.CFPJGKHKFDH), (DFGILFBGPLN)(-2), 944f, -80);
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x001E5718 File Offset: 0x001E3918
	private void CNEGBHKEMPL()
	{
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("Is success: ", new UnityAction(this.HIHEJJJFAMN));
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("p", new UnityAction(this.PACLPFDOHEI));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("-", new UnityAction(this.OKHODLFEGAJ));
		AOBJLALDBAA.EHBBFMCILPC.KDIFKFKMCOH("_", new UnityAction(this.KJMCPJHGOPN));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("cardoptionssendasgift", new UnityAction(this.OLPHFABHPJF));
	}

	// Token: 0x06004632 RID: 17970 RVA: 0x001E57AC File Offset: 0x001E39AC
	private void KFJAGBLGJNE()
	{
		this.rewardFreePass.gameObject.SetActive(true);
		this.rewardFreePass.button.gameObject.SetActive(false);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
		this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			return;
		}
		if (LiveEventsManager.PIPOLIAKGDM().EBIEOIIEMKI(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(false);
			this.rewardFreePass.button.gameObject.SetActive(true);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
			this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x001E58A4 File Offset: 0x001E3AA4
	private void DKIGINEPBKI()
	{
		bool flag = LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(true);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x06004634 RID: 17972 RVA: 0x001E58F0 File Offset: 0x001E3AF0
	private void BPLCBJNHIHI()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count > 1)
		{
			this.rewardSubsequentEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardSubsequentEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x001E5928 File Offset: 0x001E3B28
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailSubscribeSuccess", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnEmailUnsubscribeSuccess", new UnityAction(this.PACLPFDOHEI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStartFreePassSuccess", new UnityAction(this.HOCIDADENMH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStartFreePassException", new UnityAction(this.KLKJIFBGMDK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRewardsItemClose", new UnityAction(this.OnRewardsItemClose));
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x001E59BC File Offset: 0x001E3BBC
	private void MJLPKDHGLLO()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count > 1)
		{
			this.rewardFirstEpisode.gameObject.SetActive(true);
			return;
		}
		this.rewardFirstEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x001E59F4 File Offset: 0x001E3BF4
	private void LKBHEPOMCPD()
	{
		this.rewardFreePass.gameObject.SetActive(true);
		this.rewardFreePass.button.gameObject.SetActive(true);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
		this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(false);
			return;
		}
		if (LiveEventsManager.OOGPALHPNGM().ANFEMPBJKEI(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			this.rewardFreePass.button.gameObject.SetActive(true);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(true);
			this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x001E5AEC File Offset: 0x001E3CEC
	private void AKFILMNLHOL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.NPEOEAFOPJP() < 6)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(true);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(false);
	}

	// Token: 0x06004639 RID: 17977 RVA: 0x001E5B44 File Offset: 0x001E3D44
	private void OMFHLLHHFLG()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = GKJPOGNFKNK.BKBCNMEHGFA(int.Parse(this.rewardFreePass.extraData));
		}
		catch (Exception aklgbjkdomm)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
		NAHMBEODKJC.BMFPCBKNBGO();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.PMABBOJDELF().OBDCPLLLGBB("ok"), CCOJBMMKNAP.MPCBJEIMACA().OGKGHLHHAAI("NNN"), CCOJBMMKNAP.ONCPHEEJLOP().OHLNGCKIACD("BackendOperationsManager.RequestBreakCard, exception while initializing RSACryptoServiceProvider:"), new UnityAction(this.CFPJGKHKFDH), new UnityAction(this.FDOKONHHAMG), (DFGILFBGPLN)(-11), 917f, 123);
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x001E5C04 File Offset: 0x001E3E04
	private void BAKECOOIHNN()
	{
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = GKJPOGNFKNK.BKBCNMEHGFA(int.Parse(this.rewardFreePass.extraData));
		}
		catch (Exception aklgbjkdomm)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		SceneLobbyManager2.returnedFromCompletedStoryChapter = false;
		NAHMBEODKJC.LINLDPFEAJI();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.OBOOKJPGBJN().JHNELLJFBGC(""), CCOJBMMKNAP.AEELGGPEJCC().OHLNGCKIACD(">"), CCOJBMMKNAP.PKEINLPIAEH().HIPJILDCHJC("OnBackendGetPublicProfileException"), new UnityAction(this.FDOKONHHAMG), new UnityAction(this.FDOKONHHAMG), (DFGILFBGPLN)114, 1001f, -59);
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x001E5CC4 File Offset: 0x001E3EC4
	public void PKOKONILDFE()
	{
		ApplicationFocusManager.Restore();
		this.HCIDMOIBEPP();
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x001E5CD4 File Offset: 0x001E3ED4
	private void NDFHKDJKHPP()
	{
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP(")", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("storiesSearchStopwords", new UnityAction(this.BBCGDFALFHJ));
		AOBJLALDBAA.DBLAIDPICIG().PEFKJOKLEDL("", new UnityAction(this.BAKECOOIHNN));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("black", new UnityAction(this.KJMCPJHGOPN));
		AOBJLALDBAA.FILDBDMENPG().MFIMALJPCDP("", new UnityAction(this.DDOCLBFAFOB));
		this.ODMFLFFMHPB();
		this.KFJAGBLGJNE();
		this.JKEJMGJNCKB();
		this.MJMPABJFGLI();
		this.LCENHGOEENH();
		this.KJCLPDFKKLF();
		this.FMBNNLJDPDL();
		this.FNEIJBCOEIG();
		this.ADNBLADBPAN();
		this.IAMBJGNKEBA();
		if (!this.rewardOffer.gameObject.activeSelf && !this.rewardNewsletterSubscribe.gameObject.activeSelf && !this.rewardNewsletterUnsubscribe.gameObject.activeSelf && !this.rewardFreePass.gameObject.activeSelf && !this.rewardPromoCodes.gameObject.activeSelf)
		{
			this.specialOffers.gameObject.SetActive(false);
			return;
		}
		this.specialOffers.gameObject.SetActive(false);
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x001E5E24 File Offset: 0x001E4024
	private void AEGHFFFLPMD()
	{
		bool flag = LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardNewsletterSubscribe.gameObject.SetActive(false);
			this.rewardNewsletterUnsubscribe.gameObject.SetActive(true);
			return;
		}
		this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
		this.rewardNewsletterSubscribe.gameObject.SetActive(false);
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x001E5E94 File Offset: 0x001E4094
	private void HOEMPJNONAG()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JKHJFMOIDNK(AssetsManager.EHBBFMCILPC.anthologyAssets).Count > 0)
		{
			this.rewardStoryComplete.gameObject.SetActive(false);
			return;
		}
		this.rewardStoryComplete.gameObject.SetActive(false);
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x001E5EE0 File Offset: 0x001E40E0
	private void INCGDJIJDAP()
	{
		this.rewardOffer.gameObject.SetActive(false);
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && lmhhkdfckfc.DEJCCBNPFEC.Equals(this.rewardOffer.extraData))
		{
			this.rewardOffer.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x001E5F35 File Offset: 0x001E4135
	public void OnRewardsItemClose()
	{
		this.CloseFocus();
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x001E5F40 File Offset: 0x001E4140
	private void FOAANIHAGLF()
	{
		this.rewardFreePass.gameObject.SetActive(false);
		this.rewardFreePass.button.gameObject.SetActive(true);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(true);
		this.rewardFreePass.timerBlock.gameObject.SetActive(true);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(false);
			return;
		}
		if (LiveEventsManager.GIPAKOPBBEO().MAHDBPPECNN(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(false);
			this.rewardFreePass.button.gameObject.SetActive(true);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
			this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004642 RID: 17986 RVA: 0x001E6038 File Offset: 0x001E4238
	private void EMLHOIJHAFP()
	{
		bool flag = LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(true);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x001E6084 File Offset: 0x001E4284
	private void DAGBBMDMIBK()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.FKJEAIALJMC().Count > 0)
		{
			this.rewardFirstEpisode.gameObject.SetActive(true);
			return;
		}
		this.rewardFirstEpisode.gameObject.SetActive(false);
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x001E60BC File Offset: 0x001E42BC
	private void HBELNHOMGCI()
	{
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("season", new UnityAction(this.IOPEFJJGAFF));
		AOBJLALDBAA.EHBBFMCILPC.EFKNEJFLGED("Loaded asset bundle:", new UnityAction(this.ODFIJJHCPJC));
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("outdatedrev", new UnityAction(this.BAKECOOIHNN));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("anthology", new UnityAction(this.KLKJIFBGMDK));
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("apks", new UnityAction(this.OLPHFABHPJF));
		this.ODMFLFFMHPB();
		this.LKBHEPOMCPD();
		this.INCGDJIJDAP();
		this.MJMPABJFGLI();
		this.LCENHGOEENH();
		this.HLOMLBJKHAL();
		this.FIKDJEIEODC();
		this.FNEIJBCOEIG();
		this.NOPEMDIFHLO();
		this.IAMBJGNKEBA();
		if (!this.rewardOffer.gameObject.activeSelf && !this.rewardNewsletterSubscribe.gameObject.activeSelf && !this.rewardNewsletterUnsubscribe.gameObject.activeSelf && !this.rewardFreePass.gameObject.activeSelf && !this.rewardPromoCodes.gameObject.activeSelf)
		{
			this.specialOffers.gameObject.SetActive(true);
			return;
		}
		this.specialOffers.gameObject.SetActive(false);
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x001E6209 File Offset: 0x001E4409
	public void CloseFocus()
	{
		ApplicationFocusManager.Restore();
		this.PreCloseFocus();
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x001E6216 File Offset: 0x001E4416
	private void HDPCAMJNDFB()
	{
		this.CDBAINELEJK();
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x000633C0 File Offset: 0x000615C0
	private void KLKJIFBGMDK()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x001E5F35 File Offset: 0x001E4135
	public void JIKFGHLGILO()
	{
		this.CloseFocus();
	}

	// Token: 0x06004649 RID: 17993 RVA: 0x001E6220 File Offset: 0x001E4420
	private void FDGFKFEICPO()
	{
		this.rewardOffer.gameObject.SetActive(false);
		LMHHKDFCKFC lmhhkdfckfc = AKLFPGMDKLA.EHBBFMCILPC.PNLLCLPMIGA();
		if (lmhhkdfckfc != null && lmhhkdfckfc.DEJCCBNPFEC.Equals(this.rewardOffer.extraData))
		{
			this.rewardOffer.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600464A RID: 17994 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPIOAOOMPD()
	{
	}

	// Token: 0x0600464B RID: 17995 RVA: 0x001E6278 File Offset: 0x001E4478
	private void FIKDJEIEODC()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.CEAOAFBKNAP(AssetsManager.MJBDMHPHMID().anthologyAssets).Count > 0)
		{
			this.rewardStoryComplete.gameObject.SetActive(true);
			return;
		}
		this.rewardStoryComplete.gameObject.SetActive(false);
	}

	// Token: 0x0600464C RID: 17996 RVA: 0x001E62C4 File Offset: 0x001E44C4
	private void OOFIABCJMAG()
	{
		bool flag = LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(false);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x001E58F0 File Offset: 0x001E3AF0
	private void LCENHGOEENH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.IKHNDKEEECD().Count > 1)
		{
			this.rewardSubsequentEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardSubsequentEpisode.gameObject.SetActive(false);
	}

	// Token: 0x0600464E RID: 17998 RVA: 0x000633C0 File Offset: 0x000615C0
	private void KJMCPJHGOPN()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
	}

	// Token: 0x0600464F RID: 17999 RVA: 0x001E6310 File Offset: 0x001E4510
	private void OKHODLFEGAJ()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = GKJPOGNFKNK.BKBCNMEHGFA(int.Parse(this.rewardFreePass.extraData));
		}
		catch (Exception aklgbjkdomm)
		{
			AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		SceneLobbyManager2.returnedFromCompletedStoryChapter = true;
		NAHMBEODKJC.AJIAHAFBOLC();
		CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.JMNIGPHCAEJ().PKNHKGMNCIP("tradewishcardoption0"), CCOJBMMKNAP.PEBMGCKFNAO().MEPECBDCOLG(" cut "), CCOJBMMKNAP.HEDIEIICOOG().HDIPNMFHIEJ("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible."), new UnityAction(this.FDOKONHHAMG), new UnityAction(this.OOHAOIKBHDF), (DFGILFBGPLN)(-7), 994f, -112);
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x001E63D0 File Offset: 0x001E45D0
	public void MOHOLGFDPKB()
	{
		this.PKOKONILDFE();
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x001E63D8 File Offset: 0x001E45D8
	public void HCIDMOIBEPP()
	{
		base.transform.parent.GetComponent<CanvasGroup>().alpha = 799f;
		base.transform.parent.gameObject.SetActive(false);
		base.GetComponent<RectTransform>().localScale = this.PFEEFOKHKMP;
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x001E6428 File Offset: 0x001E4628
	private void POJKLCEOENC()
	{
		this.rewardFreePass.gameObject.SetActive(false);
		this.rewardFreePass.button.gameObject.SetActive(true);
		this.rewardFreePass.buttonSecondary.gameObject.SetActive(false);
		this.rewardFreePass.timerBlock.gameObject.SetActive(false);
		if (!AKLFPGMDKLA.EHBBFMCILPC.LAHPLEFAGLH.Contains(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			return;
		}
		if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(this.rewardFreePass.extraData))
		{
			this.rewardFreePass.gameObject.SetActive(true);
			this.rewardFreePass.button.gameObject.SetActive(false);
			this.rewardFreePass.buttonSecondary.gameObject.SetActive(true);
			this.rewardFreePass.timerBlock.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x001E6520 File Offset: 0x001E4720
	private void KJCLPDFKKLF()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 0)
		{
			this.rewardReplayEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardReplayEpisode.gameObject.SetActive(true);
	}

	// Token: 0x06004654 RID: 18004 RVA: 0x001E6558 File Offset: 0x001E4758
	private void DODIOMNKPDI()
	{
		bool flag = LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(true);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x001E65A4 File Offset: 0x001E47A4
	private void AOMENLAGALH()
	{
		if (!KHPGPLAMAIN.NGPOHAPMMAI() || !AdsManagerLP.OOGPALHPNGM().IsReadyRewarded())
		{
			this.rewardFreeDiamonds.gameObject.SetActive(false);
			return;
		}
		this.rewardFreeDiamonds.gameObject.SetActive(false);
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x001E6216 File Offset: 0x001E4416
	private void HIHEJJJFAMN()
	{
		this.CDBAINELEJK();
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x001E65DC File Offset: 0x001E47DC
	private void FCOKGLDPJJO()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("errortitle", new UnityAction(this.HIHEJJJFAMN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("af_currency", new UnityAction(this.HDPCAMJNDFB));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("Android", new UnityAction(this.PCPNGJABDCN));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("x", new UnityAction(this.KLKJIFBGMDK));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("\r", new UnityAction(this.DDOCLBFAFOB));
		this.NOHLBJLHDKL();
		this.NNFAJKHLLPI();
		this.LBNBBEDFCNC();
		this.MJMPABJFGLI();
		this.LBLMBOMEPNI();
		this.KJCLPDFKKLF();
		this.FMBNNLJDPDL();
		this.GFLBCHMCDFA();
		this.ADNBLADBPAN();
		this.EMNKODFHIJG();
		if (!this.rewardOffer.gameObject.activeSelf && !this.rewardNewsletterSubscribe.gameObject.activeSelf && !this.rewardNewsletterUnsubscribe.gameObject.activeSelf && !this.rewardFreePass.gameObject.activeSelf && !this.rewardPromoCodes.gameObject.activeSelf)
		{
			this.specialOffers.gameObject.SetActive(true);
			return;
		}
		this.specialOffers.gameObject.SetActive(true);
	}

	// Token: 0x06004658 RID: 18008 RVA: 0x001E5618 File Offset: 0x001E3818
	public void FHIJEDNKIJP()
	{
		this.AEJHOABFKBC();
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x001E672C File Offset: 0x001E492C
	private void EMNKODFHIJG()
	{
		bool flag = LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardPromoCodes.gameObject.SetActive(false);
			return;
		}
		this.rewardPromoCodes.gameObject.SetActive(false);
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x000AE37E File Offset: 0x000AC57E
	private void FDOKONHHAMG()
	{
		AppManager.JMDJPKKOHNI().KKNKNOELPPO(true, false);
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x001E491C File Offset: 0x001E2B1C
	private void HLOMLBJKHAL()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JBBAANGAFKO.Count > 1)
		{
			this.rewardReplayEpisode.gameObject.SetActive(false);
			return;
		}
		this.rewardReplayEpisode.gameObject.SetActive(false);
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x001E6778 File Offset: 0x001E4978
	private void EKDCKDCCBNC()
	{
		bool flag = LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru;
		if (KDCJJBLGCBH.EHBBFMCILPC.BGPJJBHFILP() || flag)
		{
			this.rewardNewsletterSubscribe.gameObject.SetActive(true);
			this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
			return;
		}
		this.rewardNewsletterUnsubscribe.gameObject.SetActive(false);
		this.rewardNewsletterSubscribe.gameObject.SetActive(false);
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x001E6216 File Offset: 0x001E4416
	private void ODFIJJHCPJC()
	{
		this.CDBAINELEJK();
	}

	// Token: 0x0600465E RID: 18014 RVA: 0x000AE300 File Offset: 0x000AC500
	private void FKPLFIDCPLP()
	{
		AppManager.EHBBFMCILPC.RestartApp(false, false);
	}

	// Token: 0x0600465F RID: 18015 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBMBMNAIIHF()
	{
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x001E63D0 File Offset: 0x001E45D0
	public void DDOCLBFAFOB()
	{
		this.PKOKONILDFE();
	}

	// Token: 0x06004661 RID: 18017 RVA: 0x001E67E8 File Offset: 0x001E49E8
	private void OIBLHONNJDH()
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.MPMKMCJFHOG.DPLHPBMJAPJ() < 6)
		{
			this.rewardFreeTea.gameObject.SetActive(true);
			this.rewardFreeTea.timerBlock.gameObject.SetActive(true);
			return;
		}
		this.rewardFreeTea.gameObject.SetActive(true);
	}

	// Token: 0x0400139C RID: 5020
	public const string onRewardsItemClose = "OnRewardsItemClose";

	// Token: 0x0400139D RID: 5021
	public RewardOption rewardFreeTea;

	// Token: 0x0400139E RID: 5022
	public RewardOption rewardFreeDiamonds;

	// Token: 0x0400139F RID: 5023
	public RewardOption rewardFreeSpins;

	// Token: 0x040013A0 RID: 5024
	public RewardOption rewardDailyLogin;

	// Token: 0x040013A1 RID: 5025
	public RewardOption rewardFirstEpisode;

	// Token: 0x040013A2 RID: 5026
	public RewardOption rewardSubsequentEpisode;

	// Token: 0x040013A3 RID: 5027
	public RewardOption rewardReplayEpisode;

	// Token: 0x040013A4 RID: 5028
	public RewardOption rewardStoryComplete;

	// Token: 0x040013A5 RID: 5029
	public RewardOption rewardAchievements;

	// Token: 0x040013A6 RID: 5030
	public RewardOption rewardDiamondRush;

	// Token: 0x040013A7 RID: 5031
	public RewardOption rewardShoppingDay;

	// Token: 0x040013A8 RID: 5032
	public RewardOption rewardTeaParty;

	// Token: 0x040013A9 RID: 5033
	public RewardOption rewardOffer;

	// Token: 0x040013AA RID: 5034
	public RewardOption rewardNewsletterSubscribe;

	// Token: 0x040013AB RID: 5035
	public RewardOption rewardNewsletterUnsubscribe;

	// Token: 0x040013AC RID: 5036
	public RewardOption rewardFreePass;

	// Token: 0x040013AD RID: 5037
	public RewardOption rewardPromoCodes;

	// Token: 0x040013AE RID: 5038
	public GameObject specialOffers;

	// Token: 0x040013AF RID: 5039
	private Vector3 PFEEFOKHKMP;
}
