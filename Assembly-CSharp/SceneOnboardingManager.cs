using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200040C RID: 1036
public class SceneOnboardingManager : MonoBehaviour
{
	// Token: 0x06007BA9 RID: 31657 RVA: 0x000AD684 File Offset: 0x000AB884
	private void PJJKAAKBPAB()
	{
		AppManager.JMDJPKKOHNI().OHFDJEJCDLG(true, false);
	}

	// Token: 0x06007BAA RID: 31658 RVA: 0x00003E52 File Offset: 0x00002052
	private void IGDGHFKGEOL()
	{
	}

	// Token: 0x06007BAB RID: 31659 RVA: 0x003728E8 File Offset: 0x00370AE8
	private void CIBKGEHJKCC()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmLite.ToString(), BGHLMGPPCNN.gmLocOnb.ToString(), false, false);
		this.ECJLCGAGCJP();
	}

	// Token: 0x06007BAD RID: 31661 RVA: 0x00372942 File Offset: 0x00370B42
	public void HLNKHKGBPEM()
	{
		Application.OpenURL(KBOJLHAJPCP.ONLDLAGMAPC);
	}

	// Token: 0x06007BAE RID: 31662 RVA: 0x00372950 File Offset: 0x00370B50
	private void GMPHANBKGBK()
	{
		this.step0.SetActive(true);
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		this.step3.SetActive(false);
		if (SceneOnboardingManager.startAtStep == 0)
		{
			this.step0.SetActive(false);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 1)
		{
			this.step1.SetActive(true);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 0)
		{
			this.step2.SetActive(false);
			return;
		}
		this.step3.SetActive(false);
	}

	// Token: 0x06007BAF RID: 31663 RVA: 0x003729D7 File Offset: 0x00370BD7
	private void GGCIIEGMLGA()
	{
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeOut(1444f, null);
	}

	// Token: 0x06007BB0 RID: 31664 RVA: 0x00372A06 File Offset: 0x00370C06
	private void KPLFCBCDILO()
	{
		this.step0.SetActive(false);
		this.step1.SetActive(true);
		CommonUserInterface.IKNOFBFMPGA().GetFader().CJJMALOECOK(403f, null);
	}

	// Token: 0x06007BB1 RID: 31665 RVA: 0x00372A35 File Offset: 0x00370C35
	private JBBNEEHANHL OCHIDFBBIBB(int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK == 0)
		{
			return JBBNEEHANHL.filterNew;
		}
		if (MEFKFOHCOHK == 1)
		{
			return JBBNEEHANHL.filterContinuePlaying;
		}
		if (MEFKFOHCOHK == 2)
		{
			return JBBNEEHANHL.newFilterSizzling;
		}
		if (MEFKFOHCOHK == 7)
		{
			return JBBNEEHANHL.filterContinuePlaying;
		}
		if (MEFKFOHCOHK == 5)
		{
			return JBBNEEHANHL.newFilterLgbtq;
		}
		if (MEFKFOHCOHK == 4)
		{
			return (JBBNEEHANHL)(-64);
		}
		if (MEFKFOHCOHK == 6)
		{
			return (JBBNEEHANHL)(-57);
		}
		if (MEFKFOHCOHK == 8)
		{
			return (JBBNEEHANHL)(-120);
		}
		if (MEFKFOHCOHK == 0)
		{
			return (JBBNEEHANHL)124;
		}
		return JBBNEEHANHL.filterContinuePlaying;
	}

	// Token: 0x06007BB2 RID: 31666 RVA: 0x00372A71 File Offset: 0x00370C71
	private void MCDDOPEJLHE()
	{
		if (SceneLobbyManager2.NeedToReloadPreview2Assets())
		{
			DPGJIJGOCIC.PJCLICBPPDA("a");
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.ADLDHJPJIPO));
	}

	// Token: 0x06007BB3 RID: 31667 RVA: 0x000AE300 File Offset: 0x000AC500
	private void ADLDHJPJIPO()
	{
		AppManager.EHBBFMCILPC.RestartApp(false, false);
	}

	// Token: 0x06007BB4 RID: 31668 RVA: 0x00372AA0 File Offset: 0x00370CA0
	private void Awake()
	{
		this.step0.SetActive(false);
		this.step1.SetActive(false);
		this.step2.SetActive(false);
		this.step3.SetActive(false);
		if (SceneOnboardingManager.startAtStep == 0)
		{
			this.step0.SetActive(true);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 1)
		{
			this.step1.SetActive(true);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 2)
		{
			this.step2.SetActive(true);
			return;
		}
		this.step3.SetActive(true);
	}

	// Token: 0x06007BB5 RID: 31669 RVA: 0x00372B28 File Offset: 0x00370D28
	private void LKCKNKLEMLG()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.NLPEGEMCEIG())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.BIAEAOMHBMM().HDIPNMFHIEJ("OnPopupCardOptionsNextClickLobby"), CCOJBMMKNAP.MLFAGAAJJEM().BGELFMIOBCL("apks2"), CCOJBMMKNAP.EAIAHCBAIEJ().DNILNCLIHAP("CLIENT.POSTEFFECTS.BLUR"), new UnityAction(this.CMLJFIPHNKH), new UnityAction(this.JCIECGLADOO), DFGILFBGPLN.screenLobby, 1281f, 11);
			AudioManager.APGODIBBPOD().GHPGDCFPFCO();
		}
	}

	// Token: 0x06007BB6 RID: 31670 RVA: 0x00372BB0 File Offset: 0x00370DB0
	private void BGDIDHPNLDA()
	{
		this.step2.SetActive(false);
		this.step3.SetActive(true);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(0.6f, null);
	}

	// Token: 0x06007BB7 RID: 31671 RVA: 0x000AD70A File Offset: 0x000AB90A
	private void FKPLFIDCPLP()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x06007BB8 RID: 31672 RVA: 0x00372BDF File Offset: 0x00370DDF
	public void AJFEBLJPHHD()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().EHIHGKFIGFH(410f, new TweenCallback(this.AMCMDKAAHJP));
	}

	// Token: 0x06007BB9 RID: 31673 RVA: 0x00372C01 File Offset: 0x00370E01
	private void HHJEIILLDGI()
	{
		this.step0.SetActive(true);
		this.step1.SetActive(true);
		CommonUserInterface.IKNOFBFMPGA().GetFader().DDPJIEHHOLL(1839f, null);
	}

	// Token: 0x06007BBA RID: 31674 RVA: 0x00372C30 File Offset: 0x00370E30
	private void BGKIIOAMCDE()
	{
		this.step0.SetActive(false);
		this.step1.SetActive(true);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(0.6f, null);
	}

	// Token: 0x06007BBB RID: 31675 RVA: 0x000ADDEE File Offset: 0x000ABFEE
	private void CMLJFIPHNKH()
	{
		AppManager.EHBBFMCILPC.KKNKNOELPPO(false, true);
	}

	// Token: 0x06007BBC RID: 31676 RVA: 0x00372C5F File Offset: 0x00370E5F
	private void MCEPABEALLH()
	{
		this.step1.SetActive(true);
		this.step2.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().DDPJIEHHOLL(1166f, null);
	}

	// Token: 0x06007BBD RID: 31677 RVA: 0x00372C90 File Offset: 0x00370E90
	public void NBHBNDCJEJB()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.KNKGCDDMLDP().HPOAGPJFHPM("sfxsparklesbundles"), CCOJBMMKNAP.GIOAFDDKKHI().FCOCLEHKLDJ("lng"), CCOJBMMKNAP.ILACPHFEDEP().JLBEIFLLBLO("socialfriendevents"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), (DFGILFBGPLN)(-122), 1529f, 31);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HJGDLOOHNLO().BGELFMIOBCL("OnPopupStoryRestartManagerRestartStory0"), CCOJBMMKNAP.KNKGCDDMLDP().BDGPNPNIAPA("hintsaving"), CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP("assetbundlecollectablecard"), new UnityAction(this.MJICBMDOCNK), new UnityAction(this.NFNPMNDAHLP), (DFGILFBGPLN)(-79), 421f, -57);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.KIDGOPBAGHN();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < -56; i += 0)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.LLFDEBIPIHD(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(true, AGEHCPDNBFD.rqst.ToString(), "OnSaveSlotsItemSlotDuplicated" + jeeofmalmjm.ToString(), BGHLMGPPCNN.under50.ToString(), true, true);
			}
		}
	}

	// Token: 0x06007BBE RID: 31678 RVA: 0x00372E01 File Offset: 0x00371001
	private void CDJBALKBDGK()
	{
		if (SceneLobbyManager2.NeedToReloadPreview2Assets())
		{
			DPGJIJGOCIC.PJCLICBPPDA("assetbundlesketchesdata");
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.FPONILMKPMC));
	}

	// Token: 0x06007BBF RID: 31679 RVA: 0x00372E2F File Offset: 0x0037102F
	private JBBNEEHANHL LLFDEBIPIHD(int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK == 0)
		{
			return JBBNEEHANHL.newFilterSupernatural;
		}
		if (MEFKFOHCOHK == 1)
		{
			return JBBNEEHANHL.newFilterFantasy;
		}
		if (MEFKFOHCOHK == 2)
		{
			return JBBNEEHANHL.newFilterDrama;
		}
		if (MEFKFOHCOHK == 3)
		{
			return JBBNEEHANHL.newFilterSizzling;
		}
		if (MEFKFOHCOHK == 4)
		{
			return JBBNEEHANHL.newFilterContemporary;
		}
		if (MEFKFOHCOHK == 5)
		{
			return JBBNEEHANHL.newFilterSciFi;
		}
		if (MEFKFOHCOHK == 6)
		{
			return JBBNEEHANHL.newFilterAdventure;
		}
		if (MEFKFOHCOHK == 7)
		{
			return JBBNEEHANHL.newFilterHorror;
		}
		if (MEFKFOHCOHK == 8)
		{
			return JBBNEEHANHL.newFilterThriller;
		}
		return JBBNEEHANHL.newFilterLgbtq;
	}

	// Token: 0x06007BC0 RID: 31680 RVA: 0x00372E6B File Offset: 0x0037106B
	private void KMIEKEMPHBN()
	{
		this.step2.SetActive(false);
		this.step3.SetActive(false);
		CommonUserInterface.IKNOFBFMPGA().GetFader().CJJMALOECOK(913f, null);
	}

	// Token: 0x06007BC1 RID: 31681 RVA: 0x00003E52 File Offset: 0x00002052
	private void CBCJABBJFAN()
	{
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x00372E9C File Offset: 0x0037109C
	private void CDHHGBKGGDG()
	{
		this.step0.SetActive(true);
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		this.step3.SetActive(true);
		if (SceneOnboardingManager.startAtStep == 0)
		{
			this.step0.SetActive(false);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 0)
		{
			this.step1.SetActive(true);
			return;
		}
		if (SceneOnboardingManager.startAtStep == 1)
		{
			this.step2.SetActive(true);
			return;
		}
		this.step3.SetActive(true);
	}

	// Token: 0x06007BC3 RID: 31683 RVA: 0x00372F23 File Offset: 0x00371123
	public void NDMJAHKDMBJ()
	{
		CommonUserInterface.IKNOFBFMPGA().GetFader().JGBCFGBFLLH(1072f, new TweenCallback(this.HMDGNDFLNJJ));
	}

	// Token: 0x06007BC4 RID: 31684 RVA: 0x00372F45 File Offset: 0x00371145
	private void OCBAMAJBKKG()
	{
		this.NFNPMNDAHLP();
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x00372F4D File Offset: 0x0037114D
	private void IAIBPPJGKIF()
	{
		this.step1.SetActive(true);
		this.step2.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().HIOMIHLJBKF(1723f, null);
	}

	// Token: 0x06007BC6 RID: 31686 RVA: 0x00372F7C File Offset: 0x0037117C
	private void EMLONMGKCPI()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		FirebaseAnalyticsManager.COKDLDOAACJ().AAIABAKHLAH(true, AGEHCPDNBFD.cdnActiv.ToString(), ((FFPHBMFGCNN)(-9)).ToString(), ((BGHLMGPPCNN)103).ToString(), true, false);
		this.ECJLCGAGCJP();
	}

	// Token: 0x06007BC7 RID: 31687 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06007BC8 RID: 31688 RVA: 0x00372FD6 File Offset: 0x003711D6
	public void OKLFGLBHMEP()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().KGLNMHNFFIK(834f, new TweenCallback(this.BGKIIOAMCDE));
	}

	// Token: 0x06007BC9 RID: 31689 RVA: 0x00372FF8 File Offset: 0x003711F8
	private void MKOMCMPGIEC()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.MJBDMHPHMID().AHALCGLJBLB())
		{
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.PMABBOJDELF().OGKGHLHHAAI("StorySaveBody.HasAvatarComponent(), unsupported wardrobe index:"), CCOJBMMKNAP.BIAEAOMHBMM().FIENAKIHNOM("null"), CCOJBMMKNAP.AEELGGPEJCC().JHNELLJFBGC("halloffameoriginalpositioninfo"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), (DFGILFBGPLN)97, 1290f, 86);
			AudioManager.APGODIBBPOD().PAKBGDCONLC();
		}
	}

	// Token: 0x06007BCA RID: 31690 RVA: 0x00373080 File Offset: 0x00371280
	private void IONLCHFNLHE()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.MJBDMHPHMID().ELMHLBHEKDM())
		{
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.OBOOKJPGBJN().PPALCPINPLK("v"), CCOJBMMKNAP.HFAKOKBHCGH().IPEIONBNIPH("YYY"), CCOJBMMKNAP.DBFFFOMCLKM().PKNHKGMNCIP("AssetStoryNpcOffsetsHub.Populate() - "), new UnityAction(this.CCIDIKGIBDF), new UnityAction(this.CMLJFIPHNKH), DFGILFBGPLN.popupStoreUpdateAvailable, 1044f, -128);
			AudioManager.APGODIBBPOD().PAKBGDCONLC();
		}
	}

	// Token: 0x06007BCB RID: 31691 RVA: 0x00003E52 File Offset: 0x00002052
	private void DGFFPEKIFAP()
	{
	}

	// Token: 0x06007BCC RID: 31692 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDCAEGOCKOJ()
	{
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x00373108 File Offset: 0x00371308
	private void MMLCHPIKBBA()
	{
		this.step2.SetActive(true);
		this.step3.SetActive(false);
		CommonUserInterface.IKNOFBFMPGA().GetFader().CJJMALOECOK(1998f, null);
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x00373137 File Offset: 0x00371337
	public void MCOCKNGMGFN()
	{
		CommonUserInterface.IKNOFBFMPGA().GetFader().EHIHGKFIGFH(1602f, new TweenCallback(this.BGDIDHPNLDA));
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x00003E52 File Offset: 0x00002052
	private void JAKPGAKGFHA()
	{
	}

	// Token: 0x06007BD0 RID: 31696 RVA: 0x00373159 File Offset: 0x00371359
	private void AMCMDKAAHJP()
	{
		this.step2.SetActive(true);
		this.step3.SetActive(true);
		CommonUserInterface.IKNOFBFMPGA().GetFader().CJJMALOECOK(1302f, null);
	}

	// Token: 0x06007BD2 RID: 31698 RVA: 0x0037319A File Offset: 0x0037139A
	private void KPNLKBPCDAF()
	{
		AOBJLALDBAA.KKPFOJMAONG().NAMMLDPCHJO(" ", new UnityAction(this.LKCKNKLEMLG));
	}

	// Token: 0x06007BD3 RID: 31699 RVA: 0x003731B7 File Offset: 0x003713B7
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x003731D4 File Offset: 0x003713D4
	private void AONODCDDDOF()
	{
		AppManager.JMDJPKKOHNI().RestartApp(false, true);
	}

	// Token: 0x06007BD5 RID: 31701 RVA: 0x000AD70A File Offset: 0x000AB90A
	private void JCIECGLADOO()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x06007BD6 RID: 31702 RVA: 0x00003E52 File Offset: 0x00002052
	private void Update()
	{
	}

	// Token: 0x06007BD7 RID: 31703 RVA: 0x003731E2 File Offset: 0x003713E2
	public void OnStep0Continue()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(0.6f, new TweenCallback(this.BGKIIOAMCDE));
	}

	// Token: 0x06007BD8 RID: 31704 RVA: 0x00373204 File Offset: 0x00371404
	public void OnGenreClick(int MEFKFOHCOHK)
	{
		this.buttonPositiveParent.GetComponent<AnimationCanvasGroupAlpha>().enabled = false;
		if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, MEFKFOHCOHK))
		{
			DPGJIJGOCIC.NPGHNNBNECG(ref this.HPAIMNNHODB, MEFKFOHCOHK);
		}
		else
		{
			DPGJIJGOCIC.OEMEPBMFEEP(ref this.HPAIMNNHODB, MEFKFOHCOHK);
		}
		if (this.HPAIMNNHODB != 0)
		{
			for (int i = 0; i < this.animList.Count; i++)
			{
				this.animList[i].SetActive(false);
			}
		}
		else
		{
			for (int j = 0; j < this.animList.Count; j++)
			{
				this.animList[j].SetActive(true);
			}
		}
		int num = 0;
		for (int k = 0; k < 10; k++)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, k))
			{
				this.selectionList[k].SetActive(true);
				num++;
			}
			else
			{
				this.selectionList[k].SetActive(false);
			}
		}
		this.counterText.text = num.ToString() + " / " + 3.ToString();
		this.counterText.SetText(num.ToString() + " / " + 3.ToString(), true);
		if (num >= 1)
		{
			this.buttonPositiveParent.GetComponent<CanvasGroup>().alpha = 1f;
			this.buttonPositive.interactable = true;
		}
		else if (num == 0)
		{
			this.buttonPositiveParent.GetComponent<CanvasGroup>().alpha = 0.5f;
			this.buttonPositive.interactable = false;
		}
		if (num >= 3)
		{
			for (int l = 0; l < 10; l++)
			{
				if (!DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, l))
				{
					this.inactiveList[l].SetActive(true);
					this.activeList[l].SetActive(false);
				}
			}
			return;
		}
		for (int m = 0; m < 10; m++)
		{
			this.inactiveList[m].SetActive(false);
			this.activeList[m].SetActive(true);
		}
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x00373405 File Offset: 0x00371605
	public void OnStep1Continue()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(0.6f, new TweenCallback(this.ICDKBNEPGIM));
	}

	// Token: 0x06007BDA RID: 31706 RVA: 0x00373427 File Offset: 0x00371627
	private void HMDGNDFLNJJ()
	{
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		CommonUserInterface.EHBBFMCILPC.GetFader().CJJMALOECOK(749f, null);
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x00373458 File Offset: 0x00371658
	public void DJILHENKANK()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.IKNOFBFMPGA().JJPNFAAPFBI(CCOJBMMKNAP.INKJIBDDMLL().HIPJILDCHJC("analogglitchovr_1"), CCOJBMMKNAP.KFAABHHGOPO().JCDFHKDNEDH(""), CCOJBMMKNAP.BOFMCPPFAMO().PGKBCNBAOJN("OnStorySplashManagerAssetsDownloadFailed"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), DFGILFBGPLN.popupIncentAd2Failed, 1657f, 15);
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.ILACPHFEDEP().DNILNCLIHAP(""), CCOJBMMKNAP.PLJMLDOCPNM().HIPJILDCHJC(" "), CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("E"), new UnityAction(this.NFNPMNDAHLP), new UnityAction(this.CDJBALKBDGK), DFGILFBGPLN.popupBackendErrorSignIn, 1881f, 50);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.ABIJILPFEIM();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < 83; i += 0)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.OCHIDFBBIBB(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.ANCEKPONIFI().LogEvent(true, AGEHCPDNBFD.rqst.ToString(), "sfxtimeoutwarning" + jeeofmalmjm.ToString(), ((BGHLMGPPCNN)(-124)).ToString(), false, false);
			}
		}
	}

	// Token: 0x06007BDC RID: 31708 RVA: 0x003735C9 File Offset: 0x003717C9
	public void OnStep2Continue()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(0.6f, new TweenCallback(this.BGDIDHPNLDA));
	}

	// Token: 0x06007BDD RID: 31709 RVA: 0x003735EC File Offset: 0x003717EC
	private void LAJFIFNGKNL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(false, AGEHCPDNBFD.gnrSelect.ToString(), ((FFPHBMFGCNN)(-9)).ToString(), BGHLMGPPCNN.d1ChaptEnd.ToString(), false, false);
		this.ECJLCGAGCJP();
	}

	// Token: 0x06007BDE RID: 31710 RVA: 0x00373646 File Offset: 0x00371846
	private void PHGLHNPFBJG()
	{
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		CommonUserInterface.IKNOFBFMPGA().GetFader().EEACANAGFEJ(273f, null);
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x00373678 File Offset: 0x00371878
	private void HOJKLCFKFLL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gmSelect.ToString(), FFPHBMFGCNN.gmFull.ToString(), BGHLMGPPCNN.gmLocOnb.ToString(), false, false);
		this.ECJLCGAGCJP();
	}

	// Token: 0x06007BE0 RID: 31712 RVA: 0x003736D2 File Offset: 0x003718D2
	private void MJICBMDOCNK()
	{
		if (SceneLobbyManager2.NeedToReloadPreview2Assets())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("<i>");
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().PACBMBLIGNN(new TweenCallback(this.AONODCDDDOF));
	}

	// Token: 0x06007BE1 RID: 31713 RVA: 0x000DD388 File Offset: 0x000DB588
	private void POHGGJDHJLC()
	{
		AppManager.PCJEMMDDCIF().OHFDJEJCDLG(false, true);
	}

	// Token: 0x06007BE2 RID: 31714 RVA: 0x00373700 File Offset: 0x00371900
	private void OFEIHPLMKMM()
	{
		CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.NIOJNOFGIJO().GGPHHLGPMPA("skinshopfilterdefault"), CCOJBMMKNAP.EHBBFMCILPC.HDIPNMFHIEJ("yes"), CCOJBMMKNAP.LMCCLMFGEBD().JLBEIFLLBLO("ltwt"), new UnityAction(this.MJICBMDOCNK), new UnityAction(this.CDJBALKBDGK), (DFGILFBGPLN)92, 1282f, 70);
	}

	// Token: 0x06007BE3 RID: 31715 RVA: 0x00373768 File Offset: 0x00371968
	private void PEGNIAIMENO()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.lite);
		FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, AGEHCPDNBFD.d1Ret.ToString(), ((FFPHBMFGCNN)113).ToString(), ((BGHLMGPPCNN)(-6)).ToString(), true, true);
		this.OFEIHPLMKMM();
	}

	// Token: 0x06007BE4 RID: 31716 RVA: 0x003737C2 File Offset: 0x003719C2
	private void KCIHDOMDINL()
	{
		AOBJLALDBAA.EHBBFMCILPC.MHLNJIACIGO(" ", new UnityAction(this.LKCKNKLEMLG));
	}

	// Token: 0x06007BE5 RID: 31717 RVA: 0x003737DF File Offset: 0x003719DF
	private void ICDKBNEPGIM()
	{
		this.step1.SetActive(false);
		this.step2.SetActive(true);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(0.6f, null);
	}

	// Token: 0x06007BE6 RID: 31718 RVA: 0x0037380E File Offset: 0x00371A0E
	private void CEDPIGBOKGB()
	{
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed", new UnityAction(this.KCLCJADHJEH));
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x0037382C File Offset: 0x00371A2C
	public void COHJBGCJEJG()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.KFDLFGHBPLP().DNILNCLIHAP(""), CCOJBMMKNAP.FEEDGKCJBLE().JHNELLJFBGC("s"), CCOJBMMKNAP.MPCBJEIMACA().FCOCLEHKLDJ("p"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), (DFGILFBGPLN)(-19), 392f, 104);
		}
		else
		{
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.CPCOODCFDDP().FCOCLEHKLDJ("errortitle"), CCOJBMMKNAP.PMABBOJDELF().FCOCLEHKLDJ(""), CCOJBMMKNAP.AEELGGPEJCC().FCOCLEHKLDJ("cardoptionsloadingthemesubonly"), new UnityAction(this.MJICBMDOCNK), new UnityAction(this.CDJBALKBDGK), (DFGILFBGPLN)(-103), 1746f, 28);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.ABIJILPFEIM();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < 58; i += 0)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.OCHIDFBBIBB(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.COKDLDOAACJ().LKONPEEDKNF(false, AGEHCPDNBFD.gnrSelect.ToString(), "variant" + jeeofmalmjm.ToString(), ((BGHLMGPPCNN)(-123)).ToString(), false, false);
			}
		}
	}

	// Token: 0x06007BE8 RID: 31720 RVA: 0x003739A0 File Offset: 0x00371BA0
	private void CBEFMMLIHHE()
	{
		AKLFPGMDKLA.EHBBFMCILPC.HKOBEKCGGEI(JAMPPNPOJJG.full);
		FirebaseAnalyticsManager.COKDLDOAACJ().JIAAMJPKOCE(true, AGEHCPDNBFD.chpActiv.ToString(), ((FFPHBMFGCNN)(-61)).ToString(), ((BGHLMGPPCNN)(-30)).ToString(), true, false);
		this.ECJLCGAGCJP();
	}

	// Token: 0x06007BE9 RID: 31721 RVA: 0x003739FC File Offset: 0x00371BFC
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		this.counterText.text = "0 / " + 3.ToString();
		this.counterText.SetText("0 / " + 3.ToString(), true);
		if (false && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru)
		{
			for (int i = 0; i < this.lgbtqContent.Count; i++)
			{
				this.lgbtqContent[i].GetComponent<RectTransform>().AHLJBONHHKL(10000, 10000);
			}
		}
	}

	// Token: 0x06007BEA RID: 31722 RVA: 0x00373AA8 File Offset: 0x00371CA8
	public void OnStep3Continue()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoutitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoubody0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoutitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoubody1"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.NFNPMNDAHLP), new UnityAction(this.NFNPMNDAHLP), DFGILFBGPLN.popupTools, 0f, 28);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.KIDGOPBAGHN();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < 10; i++)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.LLFDEBIPIHD(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.gnrSelect.ToString(), "gnr" + jeeofmalmjm.ToString(), BGHLMGPPCNN.gmLocOnb.ToString(), false, false);
			}
		}
	}

	// Token: 0x06007BEB RID: 31723 RVA: 0x00373C1C File Offset: 0x00371E1C
	public void OKAFLIPEGDG()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.IKNOFBFMPGA().CEGLPJNLBHL(CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("GetStoriesSearchBalance(), headers pack has no storiesSearchBalance TextAsset, stories search disabled."), CCOJBMMKNAP.OEPENBHJAHO().FCOCLEHKLDJ("%"), CCOJBMMKNAP.GIOAFDDKKHI().OGKGHLHHAAI("ias"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), (DFGILFBGPLN)(-66), 229f, -4);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.CPCOODCFDDP().HPOAGPJFHPM("ok"), CCOJBMMKNAP.CPCOODCFDDP().OBDCPLLLGBB("ahash"), CCOJBMMKNAP.LMCCLMFGEBD().BDGPNPNIAPA("ZZZ"), new UnityAction(this.MJICBMDOCNK), new UnityAction(this.CDJBALKBDGK), (DFGILFBGPLN)87, 1031f, -20);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.ABIJILPFEIM();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < -76; i++)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.OCHIDFBBIBB(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.ANCEKPONIFI().JIAAMJPKOCE(false, AGEHCPDNBFD.d1Ret.ToString(), ":" + jeeofmalmjm.ToString(), BGHLMGPPCNN.cdnStyToRew.ToString(), true, true);
			}
		}
	}

	// Token: 0x06007BEC RID: 31724 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGJJLDJBEON()
	{
	}

	// Token: 0x06007BED RID: 31725 RVA: 0x00373D8D File Offset: 0x00371F8D
	public void KDFDBCCCMDB()
	{
		CommonUserInterface.IKNOFBFMPGA().GetFader().CIGAMBNBEPP(549f, new TweenCallback(this.BGKIIOAMCDE));
	}

	// Token: 0x06007BEE RID: 31726 RVA: 0x00373DB0 File Offset: 0x00371FB0
	public void OCLCFNPPBBL()
	{
		if (SceneOnboardingManager.startAtStep == 0)
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.AEELGGPEJCC().PKNHKGMNCIP("OnPopupOfferManagerContinueToPurchasingScreen"), CCOJBMMKNAP.KFDLFGHBPLP().HDIPNMFHIEJ("aind"), CCOJBMMKNAP.PKEINLPIAEH().GLEFEKBDHNK("default"), new UnityAction(this.OCBAMAJBKKG), new UnityAction(this.OCBAMAJBKKG), DFGILFBGPLN.screenOnboarding, 1155f, 35);
		}
		else
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.KFAABHHGOPO().IKMNGFIDCLM("clearwishedchardsbody"), CCOJBMMKNAP.HFAKOKBHCGH().GGPHHLGPMPA("npcpi"), CCOJBMMKNAP.HFAKOKBHCGH().PPALCPINPLK("$STOPVOICEOVER"), new UnityAction(this.MJICBMDOCNK), new UnityAction(this.CDJBALKBDGK), (DFGILFBGPLN)(-42), 411f, -6);
		}
		AKLFPGMDKLA.EHBBFMCILPC.HDCJELAIOCH();
		AKLFPGMDKLA.EHBBFMCILPC.ABIJILPFEIM();
		AKLFPGMDKLA.EHBBFMCILPC.GLKNOFHEBKN = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IEGJCPDCLMM = -1;
		AKLFPGMDKLA.EHBBFMCILPC.IPGKMKGCIBB();
		AKLFPGMDKLA.EHBBFMCILPC.IBGKLENMAND();
		for (int i = 0; i < 102; i += 0)
		{
			if (DPGJIJGOCIC.CCLEJFEFBJM(this.HPAIMNNHODB, i))
			{
				int jeeofmalmjm = (int)this.LLFDEBIPIHD(i);
				AKLFPGMDKLA.EHBBFMCILPC.LBJMNJKFJOJ(jeeofmalmjm);
				FirebaseAnalyticsManager.COKDLDOAACJ().LogEvent(false, AGEHCPDNBFD.mntActiv.ToString(), "" + jeeofmalmjm.ToString(), BGHLMGPPCNN.cens.ToString(), false, false);
			}
		}
	}

	// Token: 0x06007BEF RID: 31727 RVA: 0x00373F24 File Offset: 0x00372124
	private void PHFMMNMIGGE()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.MJBDMHPHMID().AHALCGLJBLB())
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.MPCBJEIMACA().JHNELLJFBGC("UpdateGameModeOnOffState"), CCOJBMMKNAP.PKEINLPIAEH().GGPHHLGPMPA("UIEnvironmentsFront"), CCOJBMMKNAP.EHBBFMCILPC.JCDFHKDNEDH(""), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.JCIECGLADOO), (DFGILFBGPLN)80, 1823f, -16);
			AudioManager.DBFLIEGGGNN().PAKBGDCONLC();
		}
	}

	// Token: 0x06007BF0 RID: 31728 RVA: 0x000AD5FE File Offset: 0x000AB7FE
	private void CCIDIKGIBDF()
	{
		AppManager.AGANFKKBPFO().OHFDJEJCDLG(true, false);
	}

	// Token: 0x06007BF1 RID: 31729 RVA: 0x00373FAC File Offset: 0x003721AC
	private void FPONILMKPMC()
	{
		AppManager.PCJEMMDDCIF().KKNKNOELPPO(true, true);
	}

	// Token: 0x06007BF2 RID: 31730 RVA: 0x00373FBA File Offset: 0x003721BA
	private void NFNPMNDAHLP()
	{
		if (SceneLobbyManager2.NeedToReloadPreview2Assets())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("High/low version preview 2 assets scheme will be re-loaded: recommended setup changed.");
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.ADLDHJPJIPO));
	}

	// Token: 0x06007BF3 RID: 31731 RVA: 0x00372942 File Offset: 0x00370B42
	public void LLDJFEBKAMN()
	{
		Application.OpenURL(KBOJLHAJPCP.ONLDLAGMAPC);
	}

	// Token: 0x06007BF4 RID: 31732 RVA: 0x00373FE8 File Offset: 0x003721E8
	private void KCLCJADHJEH()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.IsBusy())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			AudioManager.EHBBFMCILPC.ResetAudioSettings();
		}
	}

	// Token: 0x06007BF5 RID: 31733 RVA: 0x00374070 File Offset: 0x00372270
	private void LOACLFMGICF()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("Trading/Wished cards userPublicProfile.modified = true hit", new UnityAction(this.PHFMMNMIGGE));
		this.counterText.text = "Asset bundle assets destroyed:" + 7.ToString();
		this.counterText.SetText("Products fetched successfully for {0} products." + 4.ToString(), true);
		if (true && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en)
		{
			for (int i = 1; i < this.lgbtqContent.Count; i++)
			{
				this.lgbtqContent[i].GetComponent<RectTransform>().AHLJBONHHKL(135, -109);
			}
		}
	}

	// Token: 0x06007BF6 RID: 31734 RVA: 0x0037411B File Offset: 0x0037231B
	public void KNKNINHLCFG()
	{
		CommonUserInterface.EHBBFMCILPC.GetFader().JGBCFGBFLLH(815f, new TweenCallback(this.GGCIIEGMLGA));
	}

	// Token: 0x06007BF7 RID: 31735 RVA: 0x00374140 File Offset: 0x00372340
	private void ECJLCGAGCJP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("onboardingthankyoutitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("lightmodeoutrobody0"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.NFNPMNDAHLP), new UnityAction(this.NFNPMNDAHLP), DFGILFBGPLN.popupTools, 0.15f, 28);
	}

	// Token: 0x06007BF8 RID: 31736 RVA: 0x00372942 File Offset: 0x00370B42
	public void OnTermsClick()
	{
		Application.OpenURL(KBOJLHAJPCP.ONLDLAGMAPC);
	}

	// Token: 0x040023AE RID: 9134
	private const int NODBAKMPHPB = 3;

	// Token: 0x040023AF RID: 9135
	public static readonly string _obStep = "LG5cQc77y87I3kmM+CCo4o89+LjKjjlvJPAizLCRFafr49FtpDaiO9S7IaOZNQLSYuChl";

	// Token: 0x040023B0 RID: 9136
	public static int startAtStep = 0;

	// Token: 0x040023B1 RID: 9137
	public GameObject step0;

	// Token: 0x040023B2 RID: 9138
	public GameObject step1;

	// Token: 0x040023B3 RID: 9139
	public GameObject step2;

	// Token: 0x040023B4 RID: 9140
	public GameObject step3;

	// Token: 0x040023B5 RID: 9141
	public List<GameObject> animList;

	// Token: 0x040023B6 RID: 9142
	public List<GameObject> selectionList;

	// Token: 0x040023B7 RID: 9143
	public List<GameObject> activeList;

	// Token: 0x040023B8 RID: 9144
	public List<GameObject> inactiveList;

	// Token: 0x040023B9 RID: 9145
	public List<GameObject> lgbtqContent;

	// Token: 0x040023BA RID: 9146
	public TextMeshProUGUI counterText;

	// Token: 0x040023BB RID: 9147
	public GameObject buttonPositiveParent;

	// Token: 0x040023BC RID: 9148
	public Button buttonPositive;

	// Token: 0x040023BD RID: 9149
	private int HPAIMNNHODB;
}
