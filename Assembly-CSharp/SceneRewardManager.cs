using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020000D3 RID: 211
public class SceneRewardManager : MonoBehaviour
{
	// Token: 0x06001ED5 RID: 7893 RVA: 0x000DC6E7 File Offset: 0x000DA8E7
	private void FOBJPMABFAD()
	{
		SystemBackButtonManager.PIMLDOFILCO(false);
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000DC6F0 File Offset: 0x000DA8F0
	private void DJAKLIEKLEO()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.MJBDMHPHMID().NLPEGEMCEIG())
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HFAKOKBHCGH().FIENAKIHNOM(""), CCOJBMMKNAP.MLFAGAAJJEM().HPOAGPJFHPM("black"), CCOJBMMKNAP.HJGDLOOHNLO().BDGPNPNIAPA("Loaded asset bundle:"), new UnityAction(this.NHNDBFDFDBD), new UnityAction(this.FKPLFIDCPLP), (DFGILFBGPLN)(-38), 1448f, 88);
			AudioManager.DBFLIEGGGNN().GHPGDCFPFCO();
		}
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000DC778 File Offset: 0x000DA978
	private void JGHDKFGGGPM()
	{
		this.AAAADHFPIMG.Add(DOTween.To(new DOGetter<float>(this.ODFPDGNDAIM), new DOSetter<float>(this.NBCJJPGNPBK), this.maxBloomIntensity, 0.35f).SetEase(Ease.InQuad).OnComplete(new TweenCallback(this.KIJOLMCMOFG)));
		this.canvasGroupUI2.gameObject.SetActive(true);
		this.canvasGroupUI2.DOFade(1f, this.initialFadeTime);
		this.canvasGroupUI3.gameObject.SetActive(true);
		this.canvasGroupUI3.DOFade(1f, this.initialFadeTime);
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x000DC81F File Offset: 0x000DAA1F
	private float CINPDCGHMOE()
	{
		return this.imageEffectsUI2.MHLFPEHPKOD().bloomIntensity;
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000DC834 File Offset: 0x000DAA34
	public void EEJNBMBGHLE()
	{
		CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.CEGAOMEEFBE().FIENAKIHNOM("disc"), CCOJBMMKNAP.LMCCLMFGEBD().PPALCPINPLK("OnBackendRequestFriendRejectException"), CCOJBMMKNAP.OEPENBHJAHO().GGPHHLGPMPA("Queued asset bundle promoted to chapter lifetime:"), new UnityAction(this.DJGLGNMHELM), (DFGILFBGPLN)112, 1209f, 97);
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000DC890 File Offset: 0x000DAA90
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.canvasGroupUI2.alpha = 0f;
		this.canvasGroupUI3.alpha = 0f;
		this.imageEffectsUI2.GetBloomEffect().bloomIntensity = 0f;
		ImageFrameAnimation.SetAnimationSystemVersionOverride(-1);
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000DC8E0 File Offset: 0x000DAAE0
	private void FLOJMEGGKFE()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupOneOverride(CCOJBMMKNAP.BOFMCPPFAMO().FCOCLEHKLDJ(":"), CCOJBMMKNAP.KFDLFGHBPLP().HIPJILDCHJC("") + "fruidres2" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "", CCOJBMMKNAP.MLFAGAAJJEM().PGKBCNBAOJN("no"), new UnityAction(this.EPMHHCELECJ), (DFGILFBGPLN)(-82), 1426f, -82);
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x000DC95D File Offset: 0x000DAB5D
	private void OPGMICJPCHD()
	{
		this.FNHOOPFFEFA = false;
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000DC966 File Offset: 0x000DAB66
	private void LIHFPEJMCNN()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("UIEnvironmentsFront");
		this.GODGKMHAALE();
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000AE300 File Offset: 0x000AC500
	private void MKIHLNNNEME()
	{
		AppManager.EHBBFMCILPC.RestartApp(false, false);
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000DC978 File Offset: 0x000DAB78
	private void AHIDLAICHOM()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = true;
			try
			{
				if (BackendOperationsManager.NPDDBAONMJP().RequestSaveChapterSnapshots("RegisterCachedRequest():", "profilenamelevellong"))
				{
					DPGJIJGOCIC.PJCLICBPPDA("stat6long");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.GODGKMHAALE();
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000DC9D8 File Offset: 0x000DABD8
	private void AAKFMCPAIGL()
	{
		if (this.doubleRewardButton.gameObject.activeSelf)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN > 0)
			{
				this.doubleRewardTimerBlock.SetActive(true);
				this.textDoubleRewardTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.EHLPNHDDINN.ODHBINFKIPL()), true);
				if (this.EHLPNHDDINN.HACBALNLLPP())
				{
					AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN = 0;
					this.doubleRewardButton.interactable = true;
					return;
				}
			}
			else
			{
				this.doubleRewardButton.interactable = true;
				this.doubleRewardTimerBlock.SetActive(false);
			}
		}
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000DC95D File Offset: 0x000DAB5D
	private void NDMGEHJMEED()
	{
		this.FNHOOPFFEFA = false;
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x000DCA6A File Offset: 0x000DAC6A
	private void FHMOOMHLKIM(float OBNBCGOIMKE)
	{
		this.imageEffectsUI2.GetBloomEffect().bloomIntensity = OBNBCGOIMKE;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x000DCA80 File Offset: 0x000DAC80
	private void GODGKMHAALE()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AudioManager.APGODIBBPOD().KillMusic("", CommonUserInterface.IKNOFBFMPGA().GetFader().GKLEDGCKENH());
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundles("SceneLobbyManager2.BuildGroupedParent() - Resources prefab missing (GroupedParent / CoverCard), run ROMANCE/Debug/Lobby/Build cover card prefabs", "uid", false);
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.MKIHLNNNEME));
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000DCAEC File Offset: 0x000DACEC
	private void DDNDCPJPBHL()
	{
		CommonUserInterface.IKNOFBFMPGA().UpdateConnectionAnimationProgress(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().NIMPLFKMCDJ());
		this.DBOGEEPGOLC();
		if (this.FNHOOPFFEFA && null != this.candleEffectAlpha)
		{
			this.imageEffectsUI2.PAMKEEADLIE().bloomIntensity = this.maxBloomIntensity + this.candleEffectAlpha.GOAIPONECGK() * 1002f;
		}
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000AD70A File Offset: 0x000AB90A
	private void FKPLFIDCPLP()
	{
		AppManager.EHBBFMCILPC.RestartApp(true, false);
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000DCB58 File Offset: 0x000DAD58
	private void PALPOIPPLEM()
	{
		SystemBackButtonManager.PIMLDOFILCO(true);
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.DBFFFOMCLKM().PKNHKGMNCIP("msUntilRefill"), CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL("c"), CCOJBMMKNAP.JINDKPHNLBK().PGKBCNBAOJN(":"), new UnityAction(this.GJHFLAHGJHB), new UnityAction(this.GJHFLAHGJHB), DFGILFBGPLN.screenCutscene, 788f, -104).ILDNABGINLB(SceneRewardManager.incentAdResultAmount);
		this.doubleRewardButton.gameObject.SetActive(false);
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000DCBE8 File Offset: 0x000DADE8
	public void NKFGLKBIHLL()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.OBOOKJPGBJN().HHLECNIFHCO("msUntilExpireAuto"), CCOJBMMKNAP.HJGDLOOHNLO().BDGPNPNIAPA("<i>"), CCOJBMMKNAP.DLGLFACMHPG().BGELFMIOBCL("OnStoryInterfaceHeaderShown"), new UnityAction(this.DJGLGNMHELM), DFGILFBGPLN.screenReward, 582f, -122);
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000DCC44 File Offset: 0x000DAE44
	private void BGLIKNCMOFA()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SystemBackButtonManager.BGILMHDKGMK(true);
		if (AdsManagerLP.AEELGGPEJCC().IsReadyRewarded())
		{
			AdsManagerLP.JOPPNJGEBGC().JHKLKPBJAMB(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, SceneRewardManager.onRewardScreenAdsProviderAdFailed, SceneRewardManager.onRewardScreenAdsProviderAdFailed);
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI(SceneRewardManager.onRewardScreenAdsProviderAdFailed, 61f);
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000DCC9B File Offset: 0x000DAE9B
	public void EPMHHCELECJ()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(98);
		BackendOperationsManager.NPDDBAONMJP().DCMGIOKAKPP("OnTryToFireNoteshowTimer", "ishof");
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x000DCCC0 File Offset: 0x000DAEC0
	private int IOJFNKINDGP()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.GJKGHCCKDAM(CLHDENLPOFP.eventPass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.BOGONHCIPOJ())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)56, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num;
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000DCD18 File Offset: 0x000DAF18
	private void BIGFEMCMKDF()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.AHALCGLJBLB())
		{
			CommonUserInterface.EHBBFMCILPC.JJPNFAAPFBI(CCOJBMMKNAP.HEDIEIICOOG().OHLNGCKIACD("story"), CCOJBMMKNAP.KLAKLFCOMJC().PGKBCNBAOJN("assetbundlecustomeffects"), CCOJBMMKNAP.EHBBFMCILPC.HIPJILDCHJC("importanttitle"), new UnityAction(this.CFPJGKHKFDH), new UnityAction(this.EPJJIHNMAPN), (DFGILFBGPLN)113, 992f, 96);
			AudioManager.EHBBFMCILPC.PAKBGDCONLC();
		}
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000DCDA0 File Offset: 0x000DAFA0
	private int EKBGAABHFFP()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DCADGAIHIII(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.OFINCPJNPJC())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpStartDiscountHof, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num;
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x000DCDF8 File Offset: 0x000DAFF8
	private void NPEKGGOPGIB()
	{
		ODJKHCHFKNL.AEMHBPAPNOG();
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("cind", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("spectrum", new UnityAction(this.FBHIPAPJGIG));
		AOBJLALDBAA.FILDBDMENPG().POLEDPIKODD("BackendOperationsManager.RequestGetUserPublicProfile, exception while initializing RSACryptoServiceProvider:", new UnityAction(this.AJJKFIDCBPM));
		AOBJLALDBAA.EHBBFMCILPC.ECDBIBPNBCO("USD ", new UnityAction(this.KELLABBPHCO));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH(" <i>", new UnityAction(this.PALPOIPPLEM));
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("Error. Trying to use $IMPORTVARS without declaring a prequel story index.", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.NMGMNAKLLMI().PFAHGKEDFAE(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, new UnityAction(this.OCHAPAJCEEF));
		AOBJLALDBAA.CEGAOMEEFBE().PFAHGKEDFAE(SceneRewardManager.onRewardScreenAdsProviderAdFailed, new UnityAction(this.FJEAAHIJFKO));
		SceneRewardManager.storyHeader = null;
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x000DCEE8 File Offset: 0x000DB0E8
	private IEnumerator DIEBMGAILGM()
	{
		return new SceneRewardManager.JOIEPFBHAEJ(1);
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x000DCEF0 File Offset: 0x000DB0F0
	private void JDBJMNMBOMK()
	{
		this.EKNLABKCIJF();
		this.canvasGroupUI2.alpha = 1403f;
		this.canvasGroupUI3.alpha = 265f;
		this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity = 1949f;
		ImageFrameAnimation.NEODHMLNJDG(-1);
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x000DCF40 File Offset: 0x000DB140
	private void JIEPMODHKLH()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x000DCF80 File Offset: 0x000DB180
	private void FPNBNAAIDGK()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(true);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
	private void IJFMIAJIPDG()
	{
		this.FNHOOPFFEFA = true;
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x000DCFCC File Offset: 0x000DB1CC
	private void KMMEFNOCPOO()
	{
		CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().MBFDJHABENO());
		this.AAKFMCPAIGL();
		if (this.FNHOOPFFEFA && null != this.candleEffectAlpha)
		{
			this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity = this.maxBloomIntensity + this.candleEffectAlpha.FNDOIKNPCMC() * 453f;
		}
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x000DD036 File Offset: 0x000DB236
	private void CEPDNDMMOPD(float OBNBCGOIMKE)
	{
		this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity = OBNBCGOIMKE;
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x000DD04C File Offset: 0x000DB24C
	private void JIGAGPCPAAM()
	{
		this.AAAADHFPIMG.Add(DOTween.To(new DOGetter<float>(this.CLLMINEMGDM), new DOSetter<float>(this.NBCJJPGNPBK), this.maxBloomIntensity, 265f).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.OPGMICJPCHD)));
		this.canvasGroupUI2.gameObject.SetActive(false);
		this.canvasGroupUI2.DOFade(791f, this.initialFadeTime);
		this.canvasGroupUI3.gameObject.SetActive(true);
		this.canvasGroupUI3.DOFade(206f, this.initialFadeTime);
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000DD0F3 File Offset: 0x000DB2F3
	private IEnumerator NAEDKMMAANG()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (!AudioManager.EHBBFMCILPC.PlayMusic("musreward", true, -1f, false) && !AudioManager.EHBBFMCILPC.PlayMusic("musreward" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true, -1f, false))
		{
			AudioManager.EHBBFMCILPC.PlayMusic("reward", true, -1f, false);
		}
		yield break;
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x000DD0FC File Offset: 0x000DB2FC
	private void KGGMGCPEIHH()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x000DD13C File Offset: 0x000DB33C
	private void OnDestroy()
	{
		FADIGFEOCND.BGMALDJFMKE(this.EHLPNHDDINN);
		this.EHLPNHDDINN = null;
		this.JIEPMODHKLH();
		this.canvasGroupUI2.DOKill(false);
		this.canvasGroupUI3.DOKill(false);
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x000DD170 File Offset: 0x000DB370
	private void KEOPOMLKJAF()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AudioManager.DMAAFFFEJGA().NOOAHDNKAKA("errortitle", CommonUserInterface.IKNOFBFMPGA().GetFader().OCHGBJMDGHJ());
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.NPDDBAONMJP().RequestLoadDefaultBundles("OnUserpassLoginSuccess", "", false);
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.DIFHGGKNNOK));
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x000DCA6A File Offset: 0x000DAC6A
	[CompilerGenerated]
	private void NBCJJPGNPBK(float OBNBCGOIMKE)
	{
		this.imageEffectsUI2.GetBloomEffect().bloomIntensity = OBNBCGOIMKE;
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x000DD1DC File Offset: 0x000DB3DC
	private void FNJGPHPNNLP()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(true);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIABGHNABMK()
	{
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x000DD21C File Offset: 0x000DB41C
	private void BPFJJHDHJFJ()
	{
		FADIGFEOCND.BGMALDJFMKE(this.EHLPNHDDINN);
		this.EHLPNHDDINN = null;
		this.LEEHDKPBKEB();
		this.canvasGroupUI2.DOKill(false);
		this.canvasGroupUI3.DOKill(false);
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x000DD250 File Offset: 0x000DB450
	private void IDJIPAEKEGE()
	{
		SystemBackButtonManager.MDIKNFHPEHM(true);
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x000DD258 File Offset: 0x000DB458
	private void DNGJBAGIKFB()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = true;
			try
			{
				if (BackendOperationsManager.EHBBFMCILPC.RequestSaveChapterSnapshots("ok", ""))
				{
					DPGJIJGOCIC.PJCLICBPPDA("common");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		this.GODGKMHAALE();
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x000DD2E5 File Offset: 0x000DB4E5
	private void LBDOGJFKKAB()
	{
		FADIGFEOCND.BGMALDJFMKE(this.EHLPNHDDINN);
		this.EHLPNHDDINN = null;
		this.FNJGPHPNNLP();
		this.canvasGroupUI2.DOKill(false);
		this.canvasGroupUI3.DOKill(false);
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000DD31C File Offset: 0x000DB51C
	private void LOAPJKFPKAL()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		AudioManager.EHBBFMCILPC.KillMusic("", CommonUserInterface.EHBBFMCILPC.GetFader().GetFadeInDuration());
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.EHBBFMCILPC.RequestLoadDefaultBundles("OnBackendGetDefaultBundlesSuccess", "OnBackendGetDefaultBundlesException", true);
		}
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.MKIHLNNNEME));
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000DD388 File Offset: 0x000DB588
	private void EPJJIHNMAPN()
	{
		AppManager.PCJEMMDDCIF().OHFDJEJCDLG(false, true);
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000AE38C File Offset: 0x000AC58C
	private void NHNDBFDFDBD()
	{
		AppManager.JMDJPKKOHNI().KKNKNOELPPO(false, false);
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x000DD398 File Offset: 0x000DB598
	private void KBGANABGEMK()
	{
		this.EKNLABKCIJF();
		this.canvasGroupUI2.alpha = 746f;
		this.canvasGroupUI3.alpha = 1980f;
		this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity = 1225f;
		ImageFrameAnimation.FIBAPIONJOF(-1);
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000DD3E6 File Offset: 0x000DB5E6
	private void JICOHACEECL()
	{
		if (this.EHLPNHDDINN == null)
		{
			this.EHLPNHDDINN = FADIGFEOCND.MPPPABFFGKJ(1922f);
		}
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000DD400 File Offset: 0x000DB600
	private void OCHAPAJCEEF()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-123);
		BackendOperationsManager.EHBBFMCILPC.CLKIOPJKGFK(0, 1, "(", "YYY");
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x000DD424 File Offset: 0x000DB624
	private void JIALLKAKGDL()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = false;
			try
			{
				if (BackendOperationsManager.EHBBFMCILPC.RequestSaveChapterSnapshots("OnRequestSaveChapterSnapshotsDone", "OnRequestSaveChapterSnapshotsDone"))
				{
					DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === chapter end request 2: standalone snapshots save sent, the bundles request waits for it");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.LOAPJKFPKAL();
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x000DD484 File Offset: 0x000DB684
	private void BPFNEJDCJKK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-23);
		BackendOperationsManager.EHBBFMCILPC.RequestGetIncentAdReward(0, 1, "AssetProfileData.RegisterProfilePack(): _profilePackAsset is null", "<size=28px><align=\"center\"><i>");
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x000DD4A8 File Offset: 0x000DB6A8
	public void OnDoubleRewardsClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("doublereward"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("doublerewardbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("watchvideo"), new UnityAction(this.DJGLGNMHELM), DFGILFBGPLN.popupWatchAdDoubleReward, 0f, 28);
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000DD504 File Offset: 0x000DB704
	private void GMBKLEECFGP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.HJGDLOOHNLO().GGPHHLGPMPA(" "), CCOJBMMKNAP.MLFAGAAJJEM().HDIPNMFHIEJ("ver"), CCOJBMMKNAP.HFAKOKBHCGH().FIENAKIHNOM("SceneLobbyManager2.AppendGroupBatch() - "), (DFGILFBGPLN)(-42), 1820f, 105);
		base.Invoke("assetbundlesketchactors", 841f);
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x000DD562 File Offset: 0x000DB762
	private float CAHFFKDDGNM()
	{
		return this.imageEffectsUI2.PAMKEEADLIE().bloomIntensity;
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x000DD574 File Offset: 0x000DB774
	private void DIKMNJFLFAI()
	{
		SystemBackButtonManager.SetActiveGlobal(true);
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000DD57C File Offset: 0x000DB77C
	public void HMNALDJJHAB()
	{
		CommonUserInterface.IKNOFBFMPGA().PEBIFCENHAL(CCOJBMMKNAP.KLAKLFCOMJC().IKMNGFIDCLM(""), CCOJBMMKNAP.GIOAFDDKKHI().JCDFHKDNEDH(""), CCOJBMMKNAP.CEGAOMEEFBE().JLBEIFLLBLO("CLIENT.SCREEN.AVATAR."), new UnityAction(this.GOAPDFHHLGD), (DFGILFBGPLN)112, 1107f, 110);
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000DD5D8 File Offset: 0x000DB7D8
	private void JGPAHANOGHC()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.MJBDMHPHMID().ELMHLBHEKDM())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.OEPENBHJAHO().PKNHKGMNCIP("\\r"), CCOJBMMKNAP.DLGLFACMHPG().DNILNCLIHAP("$it"), CCOJBMMKNAP.HJGDLOOHNLO().OHLNGCKIACD("importanttitle"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.NHNDBFDFDBD), (DFGILFBGPLN)(-85), 194f, -78);
			AudioManager.EHBBFMCILPC.ResetAudioSettings();
		}
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x000DD660 File Offset: 0x000DB860
	private void JLCLHIMPHNA()
	{
		if (this.doubleRewardButton.gameObject.activeSelf)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN > 0)
			{
				this.doubleRewardTimerBlock.SetActive(true);
				this.textDoubleRewardTimer.SetText(DPGJIJGOCIC.ICCGLKHPFAJ((int)this.EHLPNHDDINN.ODBOJGMLKHA()), true);
				if (this.EHLPNHDDINN.CKCGKEHFOOK())
				{
					AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN = 1;
					this.doubleRewardButton.interactable = true;
					return;
				}
			}
			else
			{
				this.doubleRewardButton.interactable = false;
				this.doubleRewardTimerBlock.SetActive(true);
			}
		}
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x000DD6F4 File Offset: 0x000DB8F4
	private void JPJIJCNKFEA()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = true;
			try
			{
				if (BackendOperationsManager.NPDDBAONMJP().RequestSaveChapterSnapshots("actor", "time"))
				{
					DPGJIJGOCIC.PJCLICBPPDA(" <i>");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x000DD754 File Offset: 0x000DB954
	private void LEEHDKPBKEB()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000DD794 File Offset: 0x000DB994
	private void HNOBHKLOGHM()
	{
		SystemBackButtonManager.OLHAGLOJICE(true);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.BOFMCPPFAMO().BGELFMIOBCL(""), CCOJBMMKNAP.BIAEAOMHBMM().GGPHHLGPMPA("abpd3"), CCOJBMMKNAP.ILACPHFEDEP().GLEFEKBDHNK("ButtonAvatar"), new UnityAction(this.GJHFLAHGJHB), new UnityAction(this.EBDCINBGADJ), (DFGILFBGPLN)103, 1528f, -123).ECCFLOFCFNN(SceneRewardManager.incentAdResultAmount);
		this.doubleRewardButton.gameObject.SetActive(false);
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x000DD858 File Offset: 0x000DBA58
	public void HPLNOHCEDCM()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(14);
		BackendOperationsManager.NPDDBAONMJP().RequestCheckForUpdates("lck", " scrollView0Content children=");
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x000DD87C File Offset: 0x000DBA7C
	private void OKIHENOGDKD(string KHJMANDEDMA, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG = true)
	{
		bool flag = false;
		for (int i = 0; i < this.environmentLayers.Count; i++)
		{
			if (this.environmentLayers[i].gameObject.name.Equals(KHJMANDEDMA))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.environmentLayers[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, null, false);
				}
				else
				{
					this.environmentLayers[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideLayer(), environmentLayer " + KHJMANDEDMA + " not found.");
		}
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x000DD90C File Offset: 0x000DBB0C
	private void FIJDKGJEPGC()
	{
		CommonUserInterface.IKNOFBFMPGA().UpdateConnectionAnimationProgress(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().MBFDJHABENO());
		this.JLCLHIMPHNA();
		if (this.FNHOOPFFEFA && null != this.candleEffectAlpha)
		{
			this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity = this.maxBloomIntensity + this.candleEffectAlpha.DCJIFFKCLMD() * 1942f;
		}
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000DD978 File Offset: 0x000DBB78
	private void GJHFLAHGJHB()
	{
		int kidhbamjgdo;
		if (!this.FMIJEFAPLPN)
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.BPIMKFIFKDE(ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, false)) + this.HHPPEAGBLBL();
		}
		else
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO() + this.HHPPEAGBLBL();
		}
		this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().APNFNKGNELA(kidhbamjgdo, 1407f, 12f);
		this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().HPBAJBIOMOA(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.PONAPMOOLIN(), 1474f, 1544f);
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x000DDA00 File Offset: 0x000DBC00
	private void AOOANKECKCJ()
	{
		this.HIMIDPELEJB();
		this.canvasGroupUI2.alpha = 1592f;
		this.canvasGroupUI3.alpha = 523f;
		this.imageEffectsUI2.MHLFPEHPKOD().bloomIntensity = 517f;
		ImageFrameAnimation.FOENJDHAFGG(-1);
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
	private void OEAJJDLNEPK()
	{
		this.FNHOOPFFEFA = true;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000DDA50 File Offset: 0x000DBC50
	private void ILBNPEIJKJM()
	{
		SystemBackButtonManager.SetActiveGlobal(true);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("rewardtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("incentadthanks"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("collect"), new UnityAction(this.COEHIJOFIFP), new UnityAction(this.COEHIJOFIFP), DFGILFBGPLN.popupIncentAd1Success, 0f, 28).ShowDiamonds(SceneRewardManager.incentAdResultAmount);
		this.doubleRewardButton.gameObject.SetActive(false);
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x000DDAE0 File Offset: 0x000DBCE0
	private void FPIJMEGAAEH()
	{
		SystemBackButtonManager.LFKNPCEGKNE(false);
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x000DDAE8 File Offset: 0x000DBCE8
	private void GOAPDFHHLGD()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SystemBackButtonManager.DOFLHDPJAJH(true);
		if (AdsManagerLP.OHCOHPNEOEG().MMBBMDNBHJL())
		{
			AdsManagerLP.EHBBFMCILPC.AJDIHOLFGHB(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, SceneRewardManager.onRewardScreenAdsProviderAdFailed, SceneRewardManager.onRewardScreenAdsProviderAdFailed);
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().LPNCDPHNBJK(SceneRewardManager.onRewardScreenAdsProviderAdFailed, 1289f);
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x000DDB40 File Offset: 0x000DBD40
	private void CCNACDHBEKC()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = false;
			try
			{
				if (BackendOperationsManager.NPDDBAONMJP().RequestSaveChapterSnapshots("OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:", ""))
				{
					DPGJIJGOCIC.PJCLICBPPDA("errortitle");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x000DDBA0 File Offset: 0x000DBDA0
	private void KILEMIFIEDH()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = false;
			try
			{
				if (BackendOperationsManager.EHBBFMCILPC.RequestSaveChapterSnapshots("PopupCardOptions.PurchaseProductWeb(): productData or productBalanceData is null", "OnSceneLobbyManagerAssetsDownloadFailed"))
				{
					DPGJIJGOCIC.ADFCDFHBDAF("eventended");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x000DDC00 File Offset: 0x000DBE00
	private void FBHIPAPJGIG()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = true;
			try
			{
				if (BackendOperationsManager.EHBBFMCILPC.RequestSaveChapterSnapshots("hint", ";"))
				{
					DPGJIJGOCIC.PJCLICBPPDA("PlayerCharacterManager.SetFaceComponent() - input is null.");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000DDC60 File Offset: 0x000DBE60
	private void EJODJINPPHK()
	{
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		AudioManager.IFDLAMLHKIJ().KillMusic("PurchaseManagerUnity.OnPurchasePendingProcess(): Product - ", CommonUserInterface.IKNOFBFMPGA().GetFader().GKLEDGCKENH());
		if (!EEIBKLDNBAP.ALFGPLALKCN())
		{
			BackendOperationsManager.NPDDBAONMJP().RequestLoadDefaultBundles(", censored ", "fast", false);
		}
		CommonUserInterface.IKNOFBFMPGA().GetFader().FadeIn(new TweenCallback(this.MMLCCCGGBAI));
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000DDCCC File Offset: 0x000DBECC
	public void OnContinueClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestCheckForUpdates("OnRequestCheckForUpdatesSuccess", "OnRequestCheckForUpdatesException");
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x000DDCF0 File Offset: 0x000DBEF0
	private void CJDPKNCGBGF()
	{
		this.HIMIDPELEJB();
		this.canvasGroupUI2.alpha = 1510f;
		this.canvasGroupUI3.alpha = 497f;
		this.imageEffectsUI2.GetBloomEffect().bloomIntensity = 1323f;
		ImageFrameAnimation.FOENJDHAFGG(-1);
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x000DDD3E File Offset: 0x000DBF3E
	[CompilerGenerated]
	private float ODFPDGNDAIM()
	{
		return this.imageEffectsUI2.GetBloomEffect().bloomIntensity;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000DDD50 File Offset: 0x000DBF50
	private int KKEDNJIJECI()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), DAMCJCDKOJK.gpbpIncentAdMultiplier, 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(1) * num;
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000DDDA8 File Offset: 0x000DBFA8
	private float IHFODICCAAC()
	{
		return this.imageEffectsUI2.LKBJGDOGJEG().bloomIntensity;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x000DDDBC File Offset: 0x000DBFBC
	private void DGFCIHHIPBJ(string KHJMANDEDMA, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG = true)
	{
		bool flag = true;
		for (int i = 0; i < this.environmentLayers.Count; i += 0)
		{
			if (this.environmentLayers[i].gameObject.name.Equals(KHJMANDEDMA))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.environmentLayers[i].GOJJHALEGOD(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, null, true);
				}
				else
				{
					this.environmentLayers[i].JJFHHPIAANF(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("avatarcollectionstutor8title" + KHJMANDEDMA + "");
		}
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x000DDE4C File Offset: 0x000DC04C
	private void MJEHAKKGJEP()
	{
		SystemBackButtonManager.JLDEJECLGMH(false);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.BGJFCEEDGFJ(CCOJBMMKNAP.OBOOKJPGBJN().BGELFMIOBCL("saveslotstitleempty"), CCOJBMMKNAP.DBFFFOMCLKM().MEPECBDCOLG("ok") + "sketchFrames" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "noiseanalog", CCOJBMMKNAP.OBOOKJPGBJN().PKNHKGMNCIP("OnSceneLobbyManagerAssetsDownloadFailed"), new UnityAction(this.HKMLHJNGDEO), DFGILFBGPLN.popupComingSoon, 1540f, -97);
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x000DDECF File Offset: 0x000DC0CF
	public void JGPOIEGHPBB()
	{
		CommonUserInterface.IKNOFBFMPGA().ShowConnectingAnimation((byte)-10);
		BackendOperationsManager.NPDDBAONMJP().LCGFHNEDPCF("", "");
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x000DDEF1 File Offset: 0x000DC0F1
	private void DBILPFPKKGL()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("OnAppleLoginFailed");
		this.LOAPJKFPKAL();
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x000DCEE8 File Offset: 0x000DB0E8
	private IEnumerator ILKIMINCHPO()
	{
		return new SceneRewardManager.JOIEPFBHAEJ(1);
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x000DDF04 File Offset: 0x000DC104
	private void COEHIJOFIFP()
	{
		int kidhbamjgdo;
		if (!this.FMIJEFAPLPN)
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)) + this.KKEDNJIJECI();
		}
		else
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO() + this.KKEDNJIJECI();
		}
		this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().Set(kidhbamjgdo, 0.5f, 0f);
		this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), 0.5f, 0f);
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
	private void KIJOLMCMOFG()
	{
		this.FNHOOPFFEFA = true;
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x000DDF8C File Offset: 0x000DC18C
	private void DJGLGNMHELM()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SystemBackButtonManager.SetActiveGlobal(false);
		if (AdsManagerLP.EHBBFMCILPC.IsReadyRewarded())
		{
			AdsManagerLP.EHBBFMCILPC.ShowAdRewarded(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, SceneRewardManager.onRewardScreenAdsProviderAdFailed, SceneRewardManager.onRewardScreenAdsProviderAdFailed);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(SceneRewardManager.onRewardScreenAdsProviderAdFailed, 0.1f);
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000ADDEE File Offset: 0x000ABFEE
	private void DIFHGGKNNOK()
	{
		AppManager.EHBBFMCILPC.KKNKNOELPPO(false, true);
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000DDD3E File Offset: 0x000DBF3E
	private float CLLMINEMGDM()
	{
		return this.imageEffectsUI2.GetBloomEffect().bloomIntensity;
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000DDFE4 File Offset: 0x000DC1E4
	public void OPKOPOKIGNG()
	{
		CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.DBFFFOMCLKM().FCOCLEHKLDJ("layervideo"), CCOJBMMKNAP.PMABBOJDELF().HHLECNIFHCO("http://"), CCOJBMMKNAP.AEELGGPEJCC().PPALCPINPLK("<b>"), new UnityAction(this.BGLIKNCMOFA), DFGILFBGPLN.popupSponsoredAdNotification, 63f, -3);
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000DE040 File Offset: 0x000DC240
	private void GLFBPECGJAL()
	{
		AKLFPGMDKLA.EHBBFMCILPC.LPCBDEBKAIM();
		SystemBackButtonManager.GJICAEKNENK(false);
		if (AdsManagerLP.EHBBFMCILPC.FGBBEBGEBLK())
		{
			AdsManagerLP.EHBBFMCILPC.EEEIMGKEMKM(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, SceneRewardManager.onRewardScreenAdsProviderAdFailed, SceneRewardManager.onRewardScreenAdsProviderAdFailed);
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().FDKBIBKABCM(SceneRewardManager.onRewardScreenAdsProviderAdFailed, 273f);
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x000DE097 File Offset: 0x000DC297
	private void KELLABBPHCO()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("DialogPlayerCharacterManager.InputDataIsValid() - step is null.");
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x00003E52 File Offset: 0x00002052
	private void DKGLMCLKFHI()
	{
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x000DE0A9 File Offset: 0x000DC2A9
	private void LOCLCNMFJAL(float OBNBCGOIMKE)
	{
		this.imageEffectsUI2.MHLFPEHPKOD().bloomIntensity = OBNBCGOIMKE;
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x000DE0BC File Offset: 0x000DC2BC
	private void MDDGAPCMIIO()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.AHALCGLJBLB())
		{
			CommonUserInterface.EHBBFMCILPC.CEGLPJNLBHL(CCOJBMMKNAP.NIOJNOFGIJO().GGPHHLGPMPA("_Color"), CCOJBMMKNAP.AEELGGPEJCC().IKMNGFIDCLM("sfxsparklesbundles"), CCOJBMMKNAP.OBOOKJPGBJN().GLEFEKBDHNK("〉"), new UnityAction(this.PBLHAFHNPAN), new UnityAction(this.NHNDBFDFDBD), (DFGILFBGPLN)(-35), 169f, 0);
			AudioManager.BFCHJBOOJKE().ResetAudioSettings();
		}
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x000DE144 File Offset: 0x000DC344
	private void BDPFIEPLAGG()
	{
		SystemBackButtonManager.MDIKNFHPEHM(false);
		CommonUserInterface.IKNOFBFMPGA().MCJIGJMFBMI();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.BOFMCPPFAMO().PGKBCNBAOJN(""), CCOJBMMKNAP.COKDLDOAACJ().HPOAGPJFHPM("Ambigious asset bundle variant chosen because there was no matching active variant: "), CCOJBMMKNAP.EAIAHCBAIEJ().OBDCPLLLGBB("lsenvattempt"), new UnityAction(this.GJHFLAHGJHB), new UnityAction(this.COEHIJOFIFP), (DFGILFBGPLN)(-4), 1264f, 127).ILDNABGINLB(SceneRewardManager.incentAdResultAmount);
		this.doubleRewardButton.gameObject.SetActive(true);
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x000DE1D4 File Offset: 0x000DC3D4
	private void OnDisable()
	{
		ODJKHCHFKNL.GFEOFIABBKM();
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRequestCheckForUpdatesSuccess", new UnityAction(this.JIALLKAKGDL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRequestCheckForUpdatesException", new UnityAction(this.AJJKFIDCBPM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnRequestSaveChapterSnapshotsDone", new UnityAction(this.PMDGLMKMEBF));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetIncentRewardAdSuccess", new UnityAction(this.ILBNPEIJKJM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendGetIncentRewardAdException", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, new UnityAction(this.HKMLHJNGDEO));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH(SceneRewardManager.onRewardScreenAdsProviderAdFailed, new UnityAction(this.OCDHNMBNJBN));
		SceneRewardManager.storyHeader = null;
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x000ADC9A File Offset: 0x000ABE9A
	private void CFPJGKHKFDH()
	{
		AppManager.JMDJPKKOHNI().RestartApp(true, false);
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000DE2C4 File Offset: 0x000DC4C4
	private void AJJKFIDCBPM()
	{
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.OnContinueClick), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000AE300 File Offset: 0x000AC500
	private void MMLCCCGGBAI()
	{
		AppManager.EHBBFMCILPC.RestartApp(false, false);
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000DE344 File Offset: 0x000DC544
	private void LGEHFJOINIL()
	{
		SystemBackButtonManager.SetActiveGlobal(true);
		CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("app42error") + " (" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + ")", CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("retry"), new UnityAction(this.HKMLHJNGDEO), DFGILFBGPLN.popupBackendError, 0f, 28);
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x000DE3C8 File Offset: 0x000DC5C8
	private int NGIFONJOFNP()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DCADGAIHIII(CLHDENLPOFP.gamePass);
		int num = 0;
		if (kioojmglclc != null && kioojmglclc.OFINCPJNPJC())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)118, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num;
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x000DD562 File Offset: 0x000DB762
	private float CMOICDOKKLK()
	{
		return this.imageEffectsUI2.PAMKEEADLIE().bloomIntensity;
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x000DE420 File Offset: 0x000DC620
	private void EBDCINBGADJ()
	{
		int kidhbamjgdo;
		if (!this.FMIJEFAPLPN)
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.BPIMKFIFKDE(ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, true)) + this.KKEDNJIJECI();
		}
		else
		{
			kidhbamjgdo = KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO() + this.NGIFONJOFNP();
		}
		this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().BAAALGHOGFO(kidhbamjgdo, 1007f, 302f);
		this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().BIPPINKFIOL(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.PONAPMOOLIN(), 938f, 1141f);
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000DE4A8 File Offset: 0x000DC6A8
	private void ELPOMEKHCHA()
	{
		SystemBackButtonManager.OMGENNPKGBO(false);
		CommonUserInterface.IKNOFBFMPGA().HideConnectingAnimation();
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.BIAEAOMHBMM().OBDCPLLLGBB("ok"), CCOJBMMKNAP.BBGECIKOICE().OBDCPLLLGBB("Game Title") + "holdontitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "lang", CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL("teal_2"), new UnityAction(this.HKMLHJNGDEO), (DFGILFBGPLN)(-64), 1145f, 123);
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x000DE52C File Offset: 0x000DC72C
	private void NOFIAPHKHDJ()
	{
		if (this.GJMFMEOGGAA)
		{
			this.GJMFMEOGGAA = false;
			try
			{
				if (BackendOperationsManager.EHBBFMCILPC.RequestSaveChapterSnapshots("CLIENT.POSTEFFECTS.SPECTRUM.OVR", "OnSceneLobbyManagerExitSyncSuccess"))
				{
					DPGJIJGOCIC.PJCLICBPPDA("supportedLanguages");
					return;
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.KEOPOMLKJAF();
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x00003E52 File Offset: 0x00002052
	private void INJIOIHANOP()
	{
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x000DE58C File Offset: 0x000DC78C
	private void NLOGNOOCLIL()
	{
		SystemBackButtonManager.OLHAGLOJICE(true);
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x000DE594 File Offset: 0x000DC794
	private void OCDHNMBNJBN()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("errortitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("adserrorbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupIncentAd1Failed, 0f, 28);
		base.Invoke("DIKMNJFLFAI", 0.25f);
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x000DE5F2 File Offset: 0x000DC7F2
	public void EADGIIPACHK()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation((byte)-21);
		BackendOperationsManager.EHBBFMCILPC.MMINBDPFNBK("Starting parallel download:", "〃");
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x000DE614 File Offset: 0x000DC814
	private void EKNLABKCIJF()
	{
		if (this.EHLPNHDDINN == null)
		{
			this.EHLPNHDDINN = FADIGFEOCND.IMEFIJEKFGI(1000000f);
		}
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000DE630 File Offset: 0x000DC830
	private void IGKIJIMHDEC()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.ELMHLBHEKDM())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.JINDKPHNLBK().BDGPNPNIAPA("Collections/"), CCOJBMMKNAP.JINDKPHNLBK().HHLECNIFHCO("OnStorySplashManagerAssetBundleFolderInitializeSuccess"), CCOJBMMKNAP.MLFAGAAJJEM().GGPHHLGPMPA(" "), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.CFPJGKHKFDH), (DFGILFBGPLN)(-118), 697f, -12);
			AudioManager.EHBBFMCILPC.GHPGDCFPFCO();
		}
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000DE6B8 File Offset: 0x000DC8B8
	private void DBOGEEPGOLC()
	{
		if (this.doubleRewardButton.gameObject.activeSelf)
		{
			if (AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN > 1)
			{
				this.doubleRewardTimerBlock.SetActive(false);
				this.textDoubleRewardTimer.SetText(DPGJIJGOCIC.DMENNJGBMBH((int)this.EHLPNHDDINN.EKJIJLMOBIG()), true);
				if (this.EHLPNHDDINN.HACBALNLLPP())
				{
					AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN = 0;
					this.doubleRewardButton.interactable = false;
					return;
				}
			}
			else
			{
				this.doubleRewardButton.interactable = false;
				this.doubleRewardTimerBlock.SetActive(true);
			}
		}
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x000DE74C File Offset: 0x000DC94C
	private void OnEnable()
	{
		try
		{
			if (null != this.doubleRewardButton && null != this.doubleRewardButton.transform.parent && null != this.doubleRewardButton.transform.parent.gameObject && this.doubleRewardButton.transform.parent.gameObject.name.Equals("PivotButton"))
			{
				if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() > 10000)
				{
					this.doubleRewardButton.transform.parent.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-50f, 0f);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() > 1000)
				{
					this.doubleRewardButton.transform.parent.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-30f, 0f);
				}
				else if (AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK() > 100)
				{
					this.doubleRewardButton.transform.parent.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-15f, 0f);
				}
				if (NarrowScreenScaler.ScreenIsTooNarrow(887f))
				{
					float num = Mathf.Abs(1f - NarrowScreenScaler.CalculateNewScaleUtil(887f, IMBLFHMKMAD.aspectRatio216));
					num = Mathf.Clamp01(num);
					this.doubleRewardButton.transform.parent.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(-200f * num, 0f);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		LobbyTopMatchSelectorManager.updatePlayerPrefsWithAvatarDataOnAwake = true;
		AKLFPGMDKLA.EHBBFMCILPC.KBKOLEJEEGH();
		AKLFPGMDKLA.EHBBFMCILPC.KJBIJEMOHBM();
		this.EKNLABKCIJF();
		GKJPOGNFKNK.FHFKDGHIEPI();
		GKJPOGNFKNK.LHFAFEPHINM();
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyAvatar, -1);
		AssetsManager.EHBBFMCILPC.DestroyAssetBundleAssets(NMKDCBPMCKI.AssetBundleAnthologyLounge, -1);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(this.initialFadeTime, null);
		if (AKLFPGMDKLA.EHBBFMCILPC.HCEHBFCIIHN() < 1 && 1 == AKLFPGMDKLA.EHBBFMCILPC.MJPKIMHENNF)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(true, AGEHCPDNBFD.d1Ret.ToString(), FFPHBMFGCNN.d1Board.ToString(), BGHLMGPPCNN.d1Reward.ToString(), true, false);
		}
		this.JGHDKFGGGPM();
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnResolutionChanged", new UnityAction(this.KCLCJADHJEH));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRequestCheckForUpdatesSuccess", new UnityAction(this.JIALLKAKGDL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRequestCheckForUpdatesException", new UnityAction(this.AJJKFIDCBPM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnRequestSaveChapterSnapshotsDone", new UnityAction(this.PMDGLMKMEBF));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetIncentRewardAdSuccess", new UnityAction(this.ILBNPEIJKJM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendGetIncentRewardAdException", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, new UnityAction(this.HKMLHJNGDEO));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP(SceneRewardManager.onRewardScreenAdsProviderAdFailed, new UnityAction(this.OCDHNMBNJBN));
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenReward);
		if (null != SceneRewardManager.storyHeader)
		{
			AssetAnthology assetAnthology = GKJPOGNFKNK.GJAAHGIAPMH(SceneRewardManager.storyHeader.index);
			PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.JDCBFAPDJIM(SceneRewardManager.storyHeader.index, -1);
			EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index);
			if (SceneRewardManager.storyHeader.index % 5 == 0)
			{
				int num2 = plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1];
			}
			this.textDoubleReward.SetText("+" + this.KKEDNJIJECI().ToString(), true);
			if (null != this.doubleRewardTutorial)
			{
				if (!PlayerPrefs.HasKey("doublerewardtut"))
				{
					PlayerPrefs.SetInt("doublerewardtut", 1);
					PlayerPrefs.Save();
					this.doubleRewardTutorial.SetActive(true);
				}
				else
				{
					this.doubleRewardTutorial.SetActive(false);
				}
				this.doubleRewardTutorial.SetActive(false);
			}
			this.BJCEKGHIJAL = AKLFPGMDKLA.EHBBFMCILPC.DJFCLNBDPND(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI, plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1]);
			try
			{
				this.GJAJNDLDMEB = assetAnthology.header.MLGKEPJPICJ(eioplefllim.EGHHCFFLPCP(-1));
				if (SceneRewardManager.storyHeader.totalChaptersCount == 1 && SceneRewardManager.storyHeader.syncWithPrequel)
				{
					this.GJAJNDLDMEB = false;
				}
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			}
			if (assetAnthology.header.shortGemsNumberFormat)
			{
				this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().EnableShortNumberFormat();
			}
			this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Set(AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.GALKFKBPLCK(), -1f, 0f);
			if (!AKLFPGMDKLA.EHBBFMCILPC.OHDLHKCNBLE(plfdajjhmko.DHONIOBOLEL.GGICIBLJIKI, plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1]))
			{
				if (this.BJCEKGHIJAL)
				{
					this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Increment(KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG(), 0.5f, this.statAnimationDelay * 1.5f);
					this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().Set(KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG(), 0.5f, this.statAnimationDelay);
					AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.IIFIBJDPHFF(KDCJJBLGCBH.EHBBFMCILPC.PPKDBCLAGOG());
				}
				else if (this.GJAJNDLDMEB)
				{
					this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Increment(KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC(), 0.5f, this.statAnimationDelay * 1.5f);
					this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().Set(KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC(), 0.5f, this.statAnimationDelay);
					AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.IIFIBJDPHFF(KDCJJBLGCBH.EHBBFMCILPC.JIMOMNGLIMC());
				}
				else
				{
					this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Increment(KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)), 0.5f, this.statAnimationDelay * 1.5f);
					this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().Set(KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)), 0.5f, this.statAnimationDelay);
					AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.IIFIBJDPHFF(KDCJJBLGCBH.EHBBFMCILPC.PLOMCENKKFD(ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true)));
				}
				plfdajjhmko.DHONIOBOLEL.CPHAILHOBGP(plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1]);
				AKLFPGMDKLA.EHBBFMCILPC.LODJGIJMGAA++;
				if (KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyRewarded() && !this.BJCEKGHIJAL && !this.GJAJNDLDMEB)
				{
					if (AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN == 0)
					{
						this.doubleRewardButton.interactable = true;
					}
					else
					{
						this.EHLPNHDDINN.EPJKDCDOEMM((float)AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN);
						this.doubleRewardButton.interactable = false;
					}
				}
				else
				{
					this.doubleRewardButton.gameObject.SetActive(false);
				}
			}
			else
			{
				this.FMIJEFAPLPN = true;
				if (SceneRewardManager.storyHeader.index % 5 == 0 && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] == 0)
				{
					this.textHardCurrencyIncrement.SetText("", true);
					this.doubleRewardButton.gameObject.SetActive(false);
				}
				else
				{
					if (assetAnthology.header.shortGemsNumberFormat)
					{
						this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().EnableShortNumberFormat();
					}
					this.textHardCurrencyAmount.GetComponent<AnimationTextIncrement>().Increment(KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO(), 0.5f, this.statAnimationDelay * 1.5f);
					this.textHardCurrencyIncrement.GetComponent<AnimationTextIncrement>().Set(KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO(), 0.5f, this.statAnimationDelay);
					AKLFPGMDKLA.EHBBFMCILPC.ODMKLADKHMO.IIFIBJDPHFF(KDCJJBLGCBH.EHBBFMCILPC.HHCMJBBEAKO());
					if (KHPGPLAMAIN.NGPOHAPMMAI() && AdsManagerLP.EHBBFMCILPC.IsReadyRewarded())
					{
						if (AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN == 0)
						{
							this.doubleRewardButton.interactable = true;
						}
						else
						{
							this.EHLPNHDDINN.EPJKDCDOEMM((float)AKLFPGMDKLA.EHBBFMCILPC.PPIBBJPMJBN);
							this.doubleRewardButton.interactable = false;
						}
					}
					else
					{
						this.doubleRewardButton.gameObject.SetActive(false);
					}
				}
			}
			for (int i = 0; i < eioplefllim.OKJJPNPGLEL.Count; i++)
			{
				this.OKIHENOGDKD(eioplefllim.OKJJPNPGLEL[i], 1f, 1f, 0f, true);
			}
			for (int j = 0; j < eioplefllim.ONGBBOHGKLO.Count; j++)
			{
				this.OKIHENOGDKD(eioplefllim.ONGBBOHGKLO[j], 0f, 0f, 0f, false);
			}
			for (int k = 0; k < plfdajjhmko.NCAMFPGMCIG.OKJJPNPGLEL.Count; k++)
			{
				this.OKIHENOGDKD(plfdajjhmko.NCAMFPGMCIG.OKJJPNPGLEL[k], 1f, 1f, 0f, true);
			}
			for (int l = 0; l < plfdajjhmko.NCAMFPGMCIG.ONGBBOHGKLO.Count; l++)
			{
				this.OKIHENOGDKD(plfdajjhmko.NCAMFPGMCIG.ONGBBOHGKLO[l], 0f, 0f, 0f, false);
			}
			if (null != this.textStat0Increment && assetAnthology.header.inkStatVariables.Count > 0)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[0].GALKFKBPLCK() != 0)
				{
					this.textStat0Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[0].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat0Increment.SetText("", true);
				}
				this.textStat0Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[0] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[0].GALKFKBPLCK(), -1f, 0f);
				this.textStat0Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[0].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat0.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat0long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat0.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat0long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat0.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat0long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[0] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[0] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[0]))
				{
					this.textStat0Increment.gameObject.SetActive(false);
					this.textStat0Amount.gameObject.SetActive(false);
					this.textStat0.gameObject.SetActive(false);
					this.stat0icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat1Increment && assetAnthology.header.inkStatVariables.Count > 1)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[1].GALKFKBPLCK() != 0)
				{
					this.textStat1Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[1].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat1Increment.SetText("", true);
				}
				this.textStat1Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[1] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[1].GALKFKBPLCK(), -1f, 0f);
				this.textStat1Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[1].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat1.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat1long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat1.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat1long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat1.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat1long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[1] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[1] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[1]))
				{
					this.textStat1Increment.gameObject.SetActive(false);
					this.textStat1Amount.gameObject.SetActive(false);
					this.textStat1.gameObject.SetActive(false);
					this.stat1icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat2Increment && assetAnthology.header.inkStatVariables.Count > 2)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[2].GALKFKBPLCK() != 0)
				{
					this.textStat2Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[2].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat2Increment.SetText("", true);
				}
				this.textStat2Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[2] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[2].GALKFKBPLCK(), -1f, 0f);
				this.textStat2Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[2].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat2.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat2long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat2.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat2long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat2.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat2long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[2] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[2] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[2]))
				{
					this.textStat2Increment.gameObject.SetActive(false);
					this.textStat2Amount.gameObject.SetActive(false);
					this.textStat2.gameObject.SetActive(false);
					this.stat2icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat3Increment && assetAnthology.header.inkStatVariables.Count > 3)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[3].GALKFKBPLCK() != 0)
				{
					this.textStat3Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[3].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat3Increment.SetText("", true);
				}
				this.textStat3Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[3] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[3].GALKFKBPLCK(), -1f, 0f);
				this.textStat3Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[3].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat3.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat3long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat3.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat3long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat3.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat3long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[3] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[3] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[3]))
				{
					this.textStat3Increment.gameObject.SetActive(false);
					this.textStat3Amount.gameObject.SetActive(false);
					this.textStat3.gameObject.SetActive(false);
					this.stat3icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat4Increment && assetAnthology.header.inkStatVariables.Count > 4)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[4].GALKFKBPLCK() != 0)
				{
					this.textStat4Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[4].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat4Increment.SetText("", true);
				}
				this.textStat4Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[4] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[4].GALKFKBPLCK(), -1f, 0f);
				this.textStat4Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[4].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat4.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat4long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat4.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat4long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat4.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat4long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[4] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[4] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[4]))
				{
					this.textStat4Increment.gameObject.SetActive(false);
					this.textStat4Amount.gameObject.SetActive(false);
					this.textStat4.gameObject.SetActive(false);
					this.stat4icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat5Increment && assetAnthology.header.inkStatVariables.Count > 5)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[5].GALKFKBPLCK() != 0)
				{
					this.textStat5Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[5].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat5Increment.SetText("", true);
				}
				this.textStat5Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[5] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[5].GALKFKBPLCK(), -1f, 0f);
				this.textStat5Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[5].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat5.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat5long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat5.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat5long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat5.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat5long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[5] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[5] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[5]))
				{
					this.textStat5Increment.gameObject.SetActive(false);
					this.textStat5Amount.gameObject.SetActive(false);
					this.textStat5.gameObject.SetActive(false);
					this.stat5icon.gameObject.SetActive(false);
				}
			}
			if (null != this.textStat6Increment && assetAnthology.header.inkStatVariables.Count > 6)
			{
				if (plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[6].GALKFKBPLCK() != 0)
				{
					this.textStat6Increment.GetComponent<AnimationTextIncrement>().Set(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[6].GALKFKBPLCK(), 0.5f, this.statAnimationDelay);
				}
				else
				{
					this.textStat6Increment.SetText("", true);
				}
				this.textStat6Amount.GetComponent<AnimationTextIncrement>().Set(SceneRewardManager.stats[6] - plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[6].GALKFKBPLCK(), -1f, 0f);
				this.textStat6Amount.GetComponent<AnimationTextIncrement>().Increment(plfdajjhmko.NCAMFPGMCIG.IKBFIKELJLM[6].GALKFKBPLCK(), 0.5f, this.statAnimationDelay * 1.5f);
				if (assetAnthology.header.index < 28)
				{
					this.textStat6.SetText("  " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat6long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else if (assetAnthology.header.addSpaceBeforeStatTitle)
				{
					this.textStat6.SetText(" " + GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat6long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
				}
				else
				{
					this.textStat6.SetText(GKJPOGNFKNK.DNILNCLIHAP("anthology" + assetAnthology.header.CKACBBGHJGI().ToString() + "stat6long", "common", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) ?? "", true);
				}
				if (SceneRewardManager.storyHeader.index < assetAnthology.header.inkStatVariablesMinStory[6] || (SceneRewardManager.storyHeader.index == assetAnthology.header.inkStatVariablesMinStory[6] && plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1] < assetAnthology.header.inkStatVariablesMinChapter[6]))
				{
					this.textStat6Increment.gameObject.SetActive(false);
					this.textStat6Amount.gameObject.SetActive(false);
					this.textStat6.gameObject.SetActive(false);
					this.stat6icon.gameObject.SetActive(false);
				}
			}
			if (assetAnthology.header.index < 28)
			{
				this.textHardCurrency.SetText("  " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("incentadhard"), true);
			}
			else if (assetAnthology.header.addSpaceBeforeStatTitle)
			{
				this.textHardCurrency.SetText(" " + CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("incentadhard"), true);
			}
			else
			{
				this.textHardCurrency.SetText(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("incentadhard") ?? "", true);
			}
			if (StarRatingSelector.lastRating > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.PostponeRequestRateChapter(SceneRewardManager.storyHeader.index, plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1], StarRatingSelector.lastRating);
			}
			BackendOperationsManager.EHBBFMCILPC.PostponeRequestStoryChapterComplete(AKLFPGMDKLA.ACFJMCBMOFG(SceneRewardManager.storyHeader.index, AKLFPGMDKLA.EHBBFMCILPC.NCOCIAENGJF(SceneRewardManager.storyHeader.index)), plfdajjhmko.DHONIOBOLEL.LKIKEHFANBO[1]);
			this.GJMFMEOGGAA = GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (!this.GJMFMEOGGAA)
			{
				BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveChapterSnapshots();
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === chapter end: snapshots save deferred to a standalone second request, the storyChapterComplete envelope stays replay-cacheable");
			}
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveAvatarCollections();
			BackendOperationsManager.EHBBFMCILPC.QueueRequestSaveSync();
			if (AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index).EFPDNIBOAJG() != AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index).IBGDMBHJDIE && !KDCJJBLGCBH.EHBBFMCILPC.DJHCAFAEILH() && !KDCJJBLGCBH.EHBBFMCILPC.AECCPAKNHIO())
			{
				BackendOperationsManager.EHBBFMCILPC.QueueRequestGetSocialStatsAvatar(assetAnthology.header.index, AKLFPGMDKLA.EHBBFMCILPC.LMGMHHLLOFN(assetAnthology.header.index).EFPDNIBOAJG());
			}
			if (AKLFPGMDKLA.EHBBFMCILPC.GFDMIHHNFDA.Length > 0)
			{
				BackendOperationsManager.EHBBFMCILPC.QueueAchievementsSync();
			}
			plfdajjhmko.NCAMFPGMCIG.DKIDEPAIFED();
			if (SceneRewardManager.storyHeader.MLGKEPJPICJ(plfdajjhmko.DHONIOBOLEL.DDEDAHCFHJN()))
			{
				plfdajjhmko.EPJKDCDOEMM(false);
			}
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneRewardManager.OnEnable() - storyHeader is null.");
		}
		base.StartCoroutine(this.BDLHKLEKJNB());
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x000DD0F3 File Offset: 0x000DB2F3
	private IEnumerator BDLHKLEKJNB()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		if (!AudioManager.EHBBFMCILPC.PlayMusic("musreward", true, -1f, false) && !AudioManager.EHBBFMCILPC.PlayMusic("musreward" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true, -1f, false))
		{
			AudioManager.EHBBFMCILPC.PlayMusic("reward", true, -1f, false);
		}
		yield break;
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x000E0514 File Offset: 0x000DE714
	private void FJEAAHIJFKO()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.BIAEAOMHBMM().HIPJILDCHJC("errortitle"), CCOJBMMKNAP.BOFMCPPFAMO().BDGPNPNIAPA("OnBackendGetPublicProfileException"), CCOJBMMKNAP.KFDLFGHBPLP().PKNHKGMNCIP("v"), (DFGILFBGPLN)(-27), 146f, 66);
		base.Invoke("%", 1752f);
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000E0574 File Offset: 0x000DE774
	private int BNLJGJLMIDA()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.NEABBOKICBA(CLHDENLPOFP.gamePass);
		int num = 0;
		if (kioojmglclc != null && kioojmglclc.OFINCPJNPJC())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.ODDPKODCIBB(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)(-64), 1 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(0) * num;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000DCEE8 File Offset: 0x000DB0E8
	private IEnumerator OKNKOABFNJD()
	{
		return new SceneRewardManager.JOIEPFBHAEJ(1);
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000E05CC File Offset: 0x000DE7CC
	public void CEONFLJCJPC()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopupOneOverride(CCOJBMMKNAP.HEDIEIICOOG().JCDFHKDNEDH("acomp"), CCOJBMMKNAP.EAIAHCBAIEJ().FIENAKIHNOM("ink"), CCOJBMMKNAP.AEELGGPEJCC().FIENAKIHNOM(" ("), new UnityAction(this.GOAPDFHHLGD), DFGILFBGPLN.popupStoryLanguageSelect, 747f, -90);
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000E0628 File Offset: 0x000DE828
	private int HHPPEAGBLBL()
	{
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HCHCMMCEEKD(CLHDENLPOFP.gamePass);
		int num = 1;
		if (kioojmglclc != null && kioojmglclc.ALFGPLALKCN())
		{
			num = KDCJJBLGCBH.EHBBFMCILPC.AAGICPKFIKC(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(kioojmglclc.LLLJOBODOAL), (DAMCJCDKOJK)78, 0 == AKLFPGMDKLA.EHBBFMCILPC.DCIPLNCLIMF);
		}
		return KDCJJBLGCBH.EHBBFMCILPC.NEOIABIBJOI(1) * num;
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000E0680 File Offset: 0x000DE880
	private void HIMIDPELEJB()
	{
		if (this.EHLPNHDDINN == null)
		{
			this.EHLPNHDDINN = FADIGFEOCND.BJBLIEKKAPF(1610f);
		}
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000AE38C File Offset: 0x000AC58C
	private void CCIDIKGIBDF()
	{
		AppManager.JMDJPKKOHNI().KKNKNOELPPO(false, false);
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x000E069A File Offset: 0x000DE89A
	private void KHDLPPFFGCL()
	{
		DPGJIJGOCIC.PJCLICBPPDA("AssetBundleDependencyDeadLock(): missing dependency ");
		this.LOAPJKFPKAL();
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIEGIHOPDOL()
	{
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000E06AC File Offset: 0x000DE8AC
	private void HEPIOPGBGLE()
	{
		SystemBackButtonManager.GJICAEKNENK(false);
		CommonUserInterface.EHBBFMCILPC.MCJIGJMFBMI();
		CommonUserInterface.IKNOFBFMPGA().BGJFCEEDGFJ(CCOJBMMKNAP.LMCCLMFGEBD().DNILNCLIHAP("e1en"), CCOJBMMKNAP.BOFMCPPFAMO().PGKBCNBAOJN("assetBundleLoadOperationActiveCoroutines:") + "importanttitle" + AKLFPGMDKLA.EHBBFMCILPC.EEHGLPEIIHD + "", CCOJBMMKNAP.KMNBCEMEBBD().FIENAKIHNOM(""), new UnityAction(this.OCHAPAJCEEF), DFGILFBGPLN.screenLoading, 566f, 12);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000E0730 File Offset: 0x000DE930
	private void HGCELCKMIOD()
	{
		ODJKHCHFKNL.GDEEEOBCHPA();
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("w", new UnityAction(this.IGKIJIMHDEC));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("Content-Type", new UnityAction(this.NOFIAPHKHDJ));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("spld", new UnityAction(this.FLOJMEGGKFE));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("ok", new UnityAction(this.DBILPFPKKGL));
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("OnRewardScreenAssetsDownloadSuccess", new UnityAction(this.BDPFIEPLAGG));
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("StoryChatManager.ShowMessageCoroutine(), unsupported message type:", new UnityAction(this.LGEHFJOINIL));
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, new UnityAction(this.OCHAPAJCEEF));
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG(SceneRewardManager.onRewardScreenAdsProviderAdFailed, new UnityAction(this.FJEAAHIJFKO));
		SceneRewardManager.storyHeader = null;
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000E0820 File Offset: 0x000DEA20
	private void Update()
	{
		CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(AssetsManager.EHBBFMCILPC.GetLoadingProgressSnapshot().AHPMFHMACME());
		this.AAKFMCPAIGL();
		if (this.FNHOOPFFEFA && null != this.candleEffectAlpha)
		{
			this.imageEffectsUI2.GetBloomEffect().bloomIntensity = this.maxBloomIntensity + this.candleEffectAlpha.GetAlpha() * 1.5f;
		}
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000E088C File Offset: 0x000DEA8C
	private void BLIGKAPCPHA()
	{
		ODJKHCHFKNL.ANHLLBCBEKI();
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("layervideo", new UnityAction(this.DJAKLIEKLEO));
		AOBJLALDBAA.FILDBDMENPG().PFAHGKEDFAE("renewal", new UnityAction(this.FBHIPAPJGIG));
		AOBJLALDBAA.KKPFOJMAONG().ONIBLJOFFPG("uid", new UnityAction(this.FLOJMEGGKFE));
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("/", new UnityAction(this.PMDGLMKMEBF));
		AOBJLALDBAA.NMGMNAKLLMI().NAMMLDPCHJO("p", new UnityAction(this.HNOBHKLOGHM));
		AOBJLALDBAA.DBLAIDPICIG().MANLHALMCIH("x", new UnityAction(this.HEPIOPGBGLE));
		AOBJLALDBAA.FILDBDMENPG().ECDBIBPNBCO(SceneRewardManager.onRewardScreenAdsProviderAdSuccess, new UnityAction(this.HKMLHJNGDEO));
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO(SceneRewardManager.onRewardScreenAdsProviderAdFailed, new UnityAction(this.OCDHNMBNJBN));
		SceneRewardManager.storyHeader = null;
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000E097C File Offset: 0x000DEB7C
	private void KCLCJADHJEH()
	{
		if (!App42Manager.EHBBFMCILPC.IsBusy() && !AssetsManager.EHBBFMCILPC.IsBusy())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("needtorestartgeneric"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), new UnityAction(this.FKPLFIDCPLP), new UnityAction(this.FKPLFIDCPLP), DFGILFBGPLN.popupSignInSuccess, 0.2f, 28);
			AudioManager.EHBBFMCILPC.ResetAudioSettings();
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000AD5FE File Offset: 0x000AB7FE
	private void PBLHAFHNPAN()
	{
		AppManager.AGANFKKBPFO().OHFDJEJCDLG(true, false);
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000E0A04 File Offset: 0x000DEC04
	private void HKMLHJNGDEO()
	{
		CommonUserInterface.EHBBFMCILPC.ShowConnectingAnimation(96);
		BackendOperationsManager.EHBBFMCILPC.RequestGetIncentAdReward(1, 1, "OnBackendGetIncentRewardAdSuccess", "OnBackendGetIncentRewardAdException");
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000E0A28 File Offset: 0x000DEC28
	private void PMDGLMKMEBF()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("=== RU FIREWALL === chapter end request 2 returned, continuing to the bundles request");
		this.LOAPJKFPKAL();
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000DCEE8 File Offset: 0x000DB0E8
	private IEnumerator KHFOLCPJMOK()
	{
		return new SceneRewardManager.JOIEPFBHAEJ(1);
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000E0A3C File Offset: 0x000DEC3C
	private void MKMLEFGAEMM()
	{
		CommonUserInterface.EHBBFMCILPC.UpdateConnectionAnimationProgress(AssetsManager.MJBDMHPHMID().GetLoadingProgressSnapshot().NIMPLFKMCDJ());
		this.JLCLHIMPHNA();
		if (this.FNHOOPFFEFA && null != this.candleEffectAlpha)
		{
			this.imageEffectsUI2.MHLFPEHPKOD().bloomIntensity = this.maxBloomIntensity + this.candleEffectAlpha.NLHIKKAFBLL() * 1575f;
		}
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000E0AA8 File Offset: 0x000DECA8
	private void DPBLANNAOMF(string KHJMANDEDMA, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG = true)
	{
		bool flag = true;
		for (int i = 0; i < this.environmentLayers.Count; i += 0)
		{
			if (this.environmentLayers[i].gameObject.name.Equals(KHJMANDEDMA))
			{
				flag = false;
				if (CHOBEDPLLOG)
				{
					this.environmentLayers[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, null, true);
				}
				else
				{
					this.environmentLayers[i].OMKKOKEAGGE(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("nick" + KHJMANDEDMA + "Audio asset bundle loading skipped due forced option:");
		}
	}

	// Token: 0x040008BD RID: 2237
	public static int incentAdResultAmount = 0;

	// Token: 0x040008BE RID: 2238
	public static string onRewardScreenAdsProviderAdSuccess = "OnRewardScreenAdsProviderAdSuccess";

	// Token: 0x040008BF RID: 2239
	public static string onRewardScreenAdsProviderAdFailed = "OnRewardScreenAdsProviderAdFailed";

	// Token: 0x040008C0 RID: 2240
	public const string onBackendGetIncentRewardAdSuccess = "OnBackendGetIncentRewardAdSuccess";

	// Token: 0x040008C1 RID: 2241
	public const string onBackendGetIncentRewardAdException = "OnBackendGetIncentRewardAdException";

	// Token: 0x040008C2 RID: 2242
	public const string onRequestCheckForUpdatesSuccess = "OnRequestCheckForUpdatesSuccess";

	// Token: 0x040008C3 RID: 2243
	public const string onRequestCheckForUpdatesException = "OnRequestCheckForUpdatesException";

	// Token: 0x040008C4 RID: 2244
	public const string onRequestSaveChapterSnapshotsDone = "OnRequestSaveChapterSnapshotsDone";

	// Token: 0x040008C5 RID: 2245
	public static AssetStoryHeader storyHeader = null;

	// Token: 0x040008C6 RID: 2246
	public static int[] stats = new int[7];

	// Token: 0x040008C7 RID: 2247
	public CanvasGroup canvasGroupUI2;

	// Token: 0x040008C8 RID: 2248
	public CanvasGroup canvasGroupUI3;

	// Token: 0x040008C9 RID: 2249
	public GameObject stat0icon;

	// Token: 0x040008CA RID: 2250
	public GameObject stat1icon;

	// Token: 0x040008CB RID: 2251
	public GameObject stat2icon;

	// Token: 0x040008CC RID: 2252
	public GameObject stat3icon;

	// Token: 0x040008CD RID: 2253
	public GameObject stat4icon;

	// Token: 0x040008CE RID: 2254
	public GameObject stat5icon;

	// Token: 0x040008CF RID: 2255
	public GameObject stat6icon;

	// Token: 0x040008D0 RID: 2256
	public TextMeshProUGUI textStat0Amount;

	// Token: 0x040008D1 RID: 2257
	public TextMeshProUGUI textStat1Amount;

	// Token: 0x040008D2 RID: 2258
	public TextMeshProUGUI textStat2Amount;

	// Token: 0x040008D3 RID: 2259
	public TextMeshProUGUI textStat3Amount;

	// Token: 0x040008D4 RID: 2260
	public TextMeshProUGUI textStat4Amount;

	// Token: 0x040008D5 RID: 2261
	public TextMeshProUGUI textStat5Amount;

	// Token: 0x040008D6 RID: 2262
	public TextMeshProUGUI textStat6Amount;

	// Token: 0x040008D7 RID: 2263
	public TextMeshProUGUI textHardCurrencyAmount;

	// Token: 0x040008D8 RID: 2264
	public TextMeshProUGUI textStat0Increment;

	// Token: 0x040008D9 RID: 2265
	public TextMeshProUGUI textStat1Increment;

	// Token: 0x040008DA RID: 2266
	public TextMeshProUGUI textStat2Increment;

	// Token: 0x040008DB RID: 2267
	public TextMeshProUGUI textStat3Increment;

	// Token: 0x040008DC RID: 2268
	public TextMeshProUGUI textStat4Increment;

	// Token: 0x040008DD RID: 2269
	public TextMeshProUGUI textStat5Increment;

	// Token: 0x040008DE RID: 2270
	public TextMeshProUGUI textStat6Increment;

	// Token: 0x040008DF RID: 2271
	public TextMeshProUGUI textHardCurrencyIncrement;

	// Token: 0x040008E0 RID: 2272
	public TextMeshProUGUI textStat0;

	// Token: 0x040008E1 RID: 2273
	public TextMeshProUGUI textStat1;

	// Token: 0x040008E2 RID: 2274
	public TextMeshProUGUI textStat2;

	// Token: 0x040008E3 RID: 2275
	public TextMeshProUGUI textStat3;

	// Token: 0x040008E4 RID: 2276
	public TextMeshProUGUI textStat4;

	// Token: 0x040008E5 RID: 2277
	public TextMeshProUGUI textStat5;

	// Token: 0x040008E6 RID: 2278
	public TextMeshProUGUI textStat6;

	// Token: 0x040008E7 RID: 2279
	public TextMeshProUGUI textHardCurrency;

	// Token: 0x040008E8 RID: 2280
	public ImageEffectsSelector imageEffectsUI2;

	// Token: 0x040008E9 RID: 2281
	public AnimationCanvasGroupAlphaPreset candleEffectAlpha;

	// Token: 0x040008EA RID: 2282
	public Button doubleRewardButton;

	// Token: 0x040008EB RID: 2283
	public GameObject doubleRewardTimerBlock;

	// Token: 0x040008EC RID: 2284
	public TextMeshProUGUI textDoubleRewardTimer;

	// Token: 0x040008ED RID: 2285
	public TextMeshProUGUI textDoubleReward;

	// Token: 0x040008EE RID: 2286
	public GameObject doubleRewardTutorial;

	// Token: 0x040008EF RID: 2287
	public float initialFadeTime;

	// Token: 0x040008F0 RID: 2288
	public float statAnimationDelay = 1f;

	// Token: 0x040008F1 RID: 2289
	public List<StoryEnvironmentLayerManager> environmentLayers = new List<StoryEnvironmentLayerManager>();

	// Token: 0x040008F2 RID: 2290
	public float maxBloomIntensity = 1.5f;

	// Token: 0x040008F3 RID: 2291
	private FADIGFEOCND EHLPNHDDINN;

	// Token: 0x040008F4 RID: 2292
	private List<Tweener> AAAADHFPIMG = new List<Tweener>();

	// Token: 0x040008F5 RID: 2293
	private bool FNHOOPFFEFA;

	// Token: 0x040008F6 RID: 2294
	private bool GJMFMEOGGAA;

	// Token: 0x040008F7 RID: 2295
	private bool BJCEKGHIJAL;

	// Token: 0x040008F8 RID: 2296
	private bool GJAJNDLDMEB;

	// Token: 0x040008F9 RID: 2297
	private bool FMIJEFAPLPN;
}
