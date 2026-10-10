using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[CreateAssetMenu(fileName = "assetStoryXCharY", menuName = "ROMANCE/Create assetStoryXCharY", order = 1)]
public class AssetStoryNpc : ScriptableObject
{
	// Token: 0x0600169D RID: 5789 RVA: 0x000ABDA4 File Offset: 0x000A9FA4
	public void PNFNHINDFND()
	{
		if (this.id != null && this.id.Contains("cnd"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("Asset bundle load operation failed during parallel mode."));
		}
		if (this.idAka != null && this.idAka.Contains("DialogPlayerCharacterManager.InputDataIsValid() - step is null."))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("%"));
		}
		if (this.property != null && this.property.Contains("chapter"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("StorySave.UpdateChapterSnapshotGuid(), chapterSnapshots/chapterSnapshotsGuids length unsync"));
		}
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void EHJMIGOEGMH(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x000ABE70 File Offset: 0x000AA070
	public void FADPNDCEMHC()
	{
		if (this.id != null && this.id.Contains("KKK"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("erd"));
		}
		if (this.idAka != null && this.idAka.Contains("OnCutsceneViewAssetsDownloadFailed"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("("));
		}
		if (this.property != null && this.property.Contains("sd"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf(""));
		}
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x000ABF34 File Offset: 0x000AA134
	public void PGFEFJDBIME()
	{
		if (this.id != null && this.id.Contains(" "))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(" "));
		}
		if (this.idAka != null && this.idAka.Contains(" "))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf(" "));
		}
		if (this.property != null && this.property.Contains(" "))
		{
			this.property = this.property.Substring(0, this.property.IndexOf(" "));
		}
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int PLNJAPCCBDC()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x000AC000 File Offset: 0x000AA200
	public void CCELADGKKNE()
	{
		if (this.id != null && this.id.Contains("anthologiestitle"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("LobbySearch dump: active="));
		}
		if (this.idAka != null && this.idAka.Contains(" ("))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("OnPostEffectSettingsChanged"));
		}
		if (this.property != null && this.property.Contains(" "))
		{
			this.property = this.property.Substring(1, this.property.IndexOf(""));
		}
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x000AC0C4 File Offset: 0x000AA2C4
	public void FPJEAGHCNKA()
	{
		if (this.id != null && this.id.Contains("savecorrupterr"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf(")"));
		}
		if (this.idAka != null && this.idAka.Contains(": "))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("OnStorySplashManagerAdsProviderAdSuccess"));
		}
		if (this.property != null && this.property.Contains("mctitle"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf(", "));
		}
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int LBPKNPEGJHM()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void NIMKEGDKHFH(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void PFEEGBMABBD(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x000AC188 File Offset: 0x000AA388
	public void CBCBCEDCADE()
	{
		if (this.id != null && this.id.Contains("WheelItem.IssueRewards() - cardDesc is null."))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(")"));
		}
		if (this.idAka != null && this.idAka.Contains("p"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("rsec"));
		}
		if (this.property != null && this.property.Contains("common"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("\n\n"));
		}
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int NAKBKDAMOCE()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x000AC24C File Offset: 0x000AA44C
	public void FMODAJODHHO()
	{
		if (this.id != null && this.id.Contains(""))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("Critical error, could not load asset bundle:"));
		}
		if (this.idAka != null && this.idAka.Contains("PlayerCharacterManager.SetClothesComponent() - input is null."))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("́ ́"));
		}
		if (this.property != null && this.property.Contains("_Saturation"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("abhp"));
		}
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int EHCHFECEFBO()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x000AC310 File Offset: 0x000AA510
	public void COFJBFIOELE()
	{
		if (this.id != null && this.id.Contains("..."))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(""));
		}
		if (this.idAka != null && this.idAka.Contains(""))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("rsind"));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("Custom effects bundle loaded but its asset is missing or mis-named:"));
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void DAKJOPEHHCL(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x000AC3D4 File Offset: 0x000AA5D4
	public void OJBKCOHDHGO()
	{
		if (this.id != null && this.id.Contains("love"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(""));
		}
		if (this.idAka != null && this.idAka.Contains("areyousure"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("trust-anchor load failed: "));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("XXX"));
		}
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x000AC498 File Offset: 0x000AA698
	public void BINIGJLMHAG()
	{
		if (this.id != null && this.id.Contains("[LoadingEnv] "))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("<i>"));
		}
		if (this.idAka != null && this.idAka.Contains(""))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("lck"));
		}
		if (this.property != null && this.property.Contains("OnStorySplashManagerAssetsDownloadFailed"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf(":"));
		}
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void OGPBLJDGOON(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void AOLFBDHBINF(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void HDKKCJBHFMO(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void DDMKPOHMDLE(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void EBHIMAOIAJE(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int DGNLDKMCPHI()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x000AC55C File Offset: 0x000AA75C
	public void NCHBPCFMHJJ()
	{
		if (this.id != null && this.id.Contains("mins"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for "));
		}
		if (this.idAka != null && this.idAka.Contains("geo.json"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("psk"));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(0, this.property.IndexOf(" "));
		}
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int CFKCMNHMICI()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x000AC620 File Offset: 0x000AA820
	public void LDLMECCNBEA()
	{
		if (this.id != null && this.id.Contains("fdmva"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("\n\n"));
		}
		if (this.idAka != null && this.idAka.Contains("OnLobbyStoryManagerDownloadSplashScreenSuccess"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("=== RU FIREWALL === chapter end: snapshots save deferred to a standalone second request, the storyChapterComplete envelope stays replay-cacheable"));
		}
		if (this.property != null && this.property.Contains("nastring"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("OnPopupAvatarCollectionsInputCancel"));
		}
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void OEDIABKJCFE(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void KGNHEEGIDOE(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int JJKLMOGGPLP()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int HDJBBNADGOI()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int IENHFCPBKBA()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void EKAIANEDPAN(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int JMIGFMHLJAM()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int FLCIPFGNBHP()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void JBGMFFIHNPD(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void JDDJBIEPACG(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int PEOPKMLDBAJ()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void ENLLIFAEFIM(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x000AC6E4 File Offset: 0x000AA8E4
	public void INJJECBFANC()
	{
		if (this.id != null && this.id.Contains("Low version preview2 assets loaded:"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("/"));
		}
		if (this.idAka != null && this.idAka.Contains("seasoncompletedescspecialepisode"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("OnSketchThumbnailPublish"));
		}
		if (this.property != null && this.property.Contains("friendsoutofdatetutor"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("CLIENT.AVATAR.OVERLAY"));
		}
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x000AC7A8 File Offset: 0x000AA9A8
	public void BIKJHMNMEDO()
	{
		if (this.id != null && this.id.Contains(" "))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("varConditionLockedValue"));
		}
		if (this.idAka != null && this.idAka.Contains("ishof"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("smpd"));
		}
		if (this.property != null && this.property.Contains("no"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf(")"));
		}
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x000AC86C File Offset: 0x000AAA6C
	public void FPMOMEMKMHB()
	{
		if (this.id != null && this.id.Contains(")"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(" - "));
		}
		if (this.idAka != null && this.idAka.Contains("chl"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("flip_down"));
		}
		if (this.property != null && this.property.Contains("statreceived"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("<b>"));
		}
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void GJFJBHNHELO(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x000AC930 File Offset: 0x000AAB30
	public void FMBAJJBEDAA()
	{
		if (this.id != null && this.id.Contains("YYY"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("PurchaseManagerUnity.OnStoreDisconnected(): Store disconnected details: "));
		}
		if (this.idAka != null && this.idAka.Contains("uid"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf(""));
		}
		if (this.property != null && this.property.Contains("OnSystemBackButton"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf(""));
		}
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void MEDOPFEBBGC(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int BCNOKDIPKNB()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int KDJPIMHABMH()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x000AC9F4 File Offset: 0x000AABF4
	public void JPBEEKEAIJN()
	{
		if (this.id != null && this.id.Contains("OnApplicationBeforeRestart"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf(" - false"));
		}
		if (this.idAka != null && this.idAka.Contains(""))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("lksuid"));
		}
		if (this.property != null && this.property.Contains("serversync"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("{skin}"));
		}
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void JJLJHAMGIOP(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int DPDEHMMMOAJ()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void EAOFLCLKDOA(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x000ACAB8 File Offset: 0x000AACB8
	public void DIAPFMGAEAH()
	{
		if (this.id != null && this.id.Contains("isp"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf(""));
		}
		if (this.idAka != null && this.idAka.Contains(""))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("OnPremiumChoiceExecutedHardBased"));
		}
		if (this.property != null && this.property.Contains("p"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("max"));
		}
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int HEDMHEDLLAI()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x000ACB7C File Offset: 0x000AAD7C
	public void CJGFHHGPPPH()
	{
		if (this.id != null && this.id.Contains("dev"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("1"));
		}
		if (this.idAka != null && this.idAka.Contains("congratstitle"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("NEWSAVE: Error: firstAnthologyStoryIndexCache.Instance.GetData() returned null. Retrieving persistent save data is impossible."));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("skinshopinfosumlireq"));
		}
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x000ACC40 File Offset: 0x000AAE40
	public void HBGENHLPEIL()
	{
		if (this.id != null && this.id.Contains("OnPopupAvatarCollectionsInputCancel"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("' is missing"));
		}
		if (this.idAka != null && this.idAka.Contains("-"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("AssetsManager.TryPingDepotDefaultUrls(): urlPingManager.StartPing()"));
		}
		if (this.property != null && this.property.Contains("OnAvatarCollectionsGamePassSubscribePositive"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("assetbundlecollectablecard"));
		}
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x000ACD04 File Offset: 0x000AAF04
	public void OBJEEDGBJIJ()
	{
		if (this.id != null && this.id.Contains("ablpt"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("lang"));
		}
		if (this.idAka != null && this.idAka.Contains("$LAYERSHOW"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("cz"));
		}
		if (this.property != null && this.property.Contains("OnSystemBackButton"))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("OnFullscreenLiveOfferContinueToPurchasingScreen"));
		}
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x000ACDC8 File Offset: 0x000AAFC8
	public void MANGHBJIGAO()
	{
		if (this.id != null && this.id.Contains("per"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("+"));
		}
		if (this.idAka != null && this.idAka.Contains("errortitle"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("USD "));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("sslt"));
		}
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int BCODLALMNLJ()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void NOGIIEFKHEL(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void PMALOCMFDIG(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int LEABBNNGENA()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void OJNAHHOEIEN(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
	public void IKFHBLPAGIP()
	{
		if (this.id != null && this.id.Contains("usynsnap2"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("Speed"));
		}
		if (this.idAka != null && this.idAka.Contains("title"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("ok"));
		}
		if (this.property != null && this.property.Contains("errortitle"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("OnSketchThumbnailPublish"));
		}
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void GFFPDIBOIIK(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x000ACF74 File Offset: 0x000AB174
	public void PGNFCDMJIGN()
	{
		if (this.id != null && this.id.Contains("anthology"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf(" "));
		}
		if (this.idAka != null && this.idAka.Contains("importanttitle"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("AdsManagerLP: Received RewardedVideoOnAdLoadFailedEvent"));
		}
		if (this.property != null && this.property.Contains("Account.FixCompletedChaptersIssue() forwards, setting bit to 1 for 'completedChapters["))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("loungelockedtitle"));
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void KAJMCHKLDOH(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void NNIBHMPJDHP(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x000AD038 File Offset: 0x000AB238
	public void OACGHBLJLAD()
	{
		if (this.id != null && this.id.Contains("LoadingEnvironmentManager"))
		{
			this.id = this.id.Substring(1, this.id.IndexOf("varConditionLocked"));
		}
		if (this.idAka != null && this.idAka.Contains("skpcut"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf(""));
		}
		if (this.property != null && this.property.Contains("owned"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("cid"));
		}
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int CHKNJPAHMJH()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void OGJAAECFENB(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x000AD0FC File Offset: 0x000AB2FC
	public void GJAFCNJLBNN()
	{
		if (this.id != null && this.id.Contains(""))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("yes"));
		}
		if (this.idAka != null && this.idAka.Contains("productId"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("application/json"));
		}
		if (this.property != null && this.property.Contains(" could not be loaded from the cache"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf(")"));
		}
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x000AD1C0 File Offset: 0x000AB3C0
	public void ANIFLCAPHJB()
	{
		if (this.id != null && this.id.Contains("]:"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("sparkles"));
		}
		if (this.idAka != null && this.idAka.Contains("..."))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf("veff"));
		}
		if (this.property != null && this.property.Contains("$e1nl"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("Request type: INAPP_EVENT_REQUEST"));
		}
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void GHBPANFHFFL(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x000AD284 File Offset: 0x000AB484
	public void CMAKGOODMGJ()
	{
		if (this.id != null && this.id.Contains("body"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(""));
		}
		if (this.idAka != null && this.idAka.Contains("OnBackendUndoPremiumChoiceException"))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("[AssetBundleManager] "));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("OnMissingPreview2CdnSuccess"));
		}
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int NBCAAHBLOCM()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int PMMMPHEAKIO()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int CMMEAEMJLAG()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x000AD348 File Offset: 0x000AB548
	public void GHGEPINJKFI()
	{
		if (this.id != null && this.id.Contains(""))
		{
			this.id = this.id.Substring(0, this.id.IndexOf(""));
		}
		if (this.idAka != null && this.idAka.Contains("p"))
		{
			this.idAka = this.idAka.Substring(1, this.idAka.IndexOf(")"));
		}
		if (this.property != null && this.property.Contains("ok"))
		{
			this.property = this.property.Substring(0, this.property.IndexOf("achievtutorial"));
		}
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int DFIEHBJNNNC()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x000AD40C File Offset: 0x000AB60C
	public void HGNBDIGDFDP()
	{
		if (this.id != null && this.id.Contains("spld"))
		{
			this.id = this.id.Substring(0, this.id.IndexOf("[SkinShop] IAP look without a resolvable store price (shop "));
		}
		if (this.idAka != null && this.idAka.Contains(" "))
		{
			this.idAka = this.idAka.Substring(0, this.idAka.IndexOf("acomp2"));
		}
		if (this.property != null && this.property.Contains(""))
		{
			this.property = this.property.Substring(1, this.property.IndexOf("total while iterations:"));
		}
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x000ABE65 File Offset: 0x000AA065
	public void EDBGHPOBCHI(int MEFKFOHCOHK)
	{
		this.onDemandResourcesCheckpointIndex = MEFKFOHCOHK;
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int LPGBMDJLHHP()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int KBDAEIHELPE()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x000ABFF5 File Offset: 0x000AA1F5
	public int CANLLPMHHHE()
	{
		return this.onDemandResourcesCheckpointIndex;
	}

	// Token: 0x040006E5 RID: 1765
	private int onDemandResourcesCheckpointIndex = -1;

	// Token: 0x040006E6 RID: 1766
	public string id;

	// Token: 0x040006E7 RID: 1767
	public string idAka;

	// Token: 0x040006E8 RID: 1768
	public List<string> mappings;

	// Token: 0x040006E9 RID: 1769
	public string property;

	// Token: 0x040006EA RID: 1770
	public Sprite bodySprite;

	// Token: 0x040006EB RID: 1771
	public int bodyOffsetX;

	// Token: 0x040006EC RID: 1772
	public int bodyOffsetY;

	// Token: 0x040006ED RID: 1773
	public Sprite bodySpriteEtc1Alpha;

	// Token: 0x040006EE RID: 1774
	public bool bodySpriteEtc1AlphaApplyToDefSD;

	// Token: 0x040006EF RID: 1775
	public bool bodySpriteEtc1AlphaApplyToDefHD;

	// Token: 0x040006F0 RID: 1776
	public int bodySpriteEtc1AlphaOriginalWidth;

	// Token: 0x040006F1 RID: 1777
	public int bodySpriteEtc1AlphaOriginalHeight;

	// Token: 0x040006F2 RID: 1778
	public List<AssetStoryNpcEmotionDesc> emotions;

	// Token: 0x040006F3 RID: 1779
	public int faceOffsetX;

	// Token: 0x040006F4 RID: 1780
	public int faceOffsetY;

	// Token: 0x040006F5 RID: 1781
	public Sprite overlaySprite;

	// Token: 0x040006F6 RID: 1782
	public int overlayOffsetX;

	// Token: 0x040006F7 RID: 1783
	public int overlayOffsetY;

	// Token: 0x040006F8 RID: 1784
	public StoryNpcOverlayComponentHierarchyPosition hierarchyPosition = StoryNpcOverlayComponentHierarchyPosition.unchanged;

	// Token: 0x040006F9 RID: 1785
	public int dialogOffsetY;

	// Token: 0x040006FA RID: 1786
	public bool dialogOffsetAppliesToNpcSide = true;

	// Token: 0x040006FB RID: 1787
	public bool dialogOffsetAppliesToPlayerSide = true;

	// Token: 0x040006FC RID: 1788
	public bool isMissingBody;

	// Token: 0x040006FD RID: 1789
	public bool disableEmotionFade;

	// Token: 0x040006FE RID: 1790
	public bool applyOffsetsOnCenterAppearScenario;

	// Token: 0x040006FF RID: 1791
	public int offsetWhenCenteredX;

	// Token: 0x04000700 RID: 1792
	public int offsetWhenCenteredY;
}
