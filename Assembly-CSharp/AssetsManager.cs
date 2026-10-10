using System;
using System.Collections;
using System.Collections.Generic;
using AssetBundles;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Token: 0x02000326 RID: 806
public class AssetsManager : MonoBehaviour
{
	// Token: 0x0600605D RID: 24669 RVA: 0x002BC678 File Offset: 0x002BA878
	public void OONBOAAELHG(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				return;
			}
		}
		this.storyAssets.Add(AJEAEPFPACP);
	}

	// Token: 0x0600605E RID: 24670 RVA: 0x002BC6BC File Offset: 0x002BA8BC
	public static AssetsManager MJBDMHPHMID()
	{
		if (!AssetsManager.IKLAPGJDMNA)
		{
			AssetsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AssetsManager)) as AssetsManager);
			if (!AssetsManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnReturnRewardPopupHide");
			}
		}
		return AssetsManager.IKLAPGJDMNA;
	}

	// Token: 0x0600605F RID: 24671 RVA: 0x002BC70C File Offset: 0x002BA90C
	public void IDLOHHANHPL(AssetAnthologyHeader HCLEPODFDFB)
	{
		try
		{
			if (!(null == HCLEPODFDFB) && HCLEPODFDFB.customEffectsLoad != null)
			{
				if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.KDICJGFFHKD())
				{
					if (!KHPGPLAMAIN.BOIFOPEAIBN())
					{
						if (KHPGPLAMAIN.AKJOFJPLONG() != IIHCCPLGGHP.highEnd)
						{
							for (int i = 1; i < HCLEPODFDFB.customEffectsLoad.Count; i++)
							{
								if (HCLEPODFDFB.customEffectsLoad[i] < 1)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("sckv2" + HCLEPODFDFB.customEffectsLoad[i].ToString());
								}
								else
								{
									this.QueueAssetBundleDownload((NMKDCBPMCKI)(-96), HCLEPODFDFB.customEffectsLoad[i], -1, FLDBFOADFLH.finishDownloadAndProceed, true, false, false, null, -1, true, "aind", false, true);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006060 RID: 24672 RVA: 0x002BC7E4 File Offset: 0x002BA9E4
	public void CleanseAssetBundleAssets()
	{
		bool flag = false;
		while (!flag)
		{
			flag = true;
			for (int i = 0; i < this.anthologyPreview2Assets.Count; i++)
			{
				if (this.anthologyPreview2Assets[i] == null)
				{
					this.anthologyPreview2Assets.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int j = 0; j < this.anthologyPreview2AssetsMini.Count; j++)
			{
				if (this.anthologyPreview2AssetsMini[j] == null)
				{
					this.anthologyPreview2AssetsMini.RemoveAt(j);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int k = 0; k < this.iconsPackAssets.Count; k++)
			{
				if (this.iconsPackAssets[k] == null)
				{
					this.iconsPackAssets.RemoveAt(k);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int l = 0; l < this.profilePackAssets.Count; l++)
			{
				if (this.profilePackAssets[l] == null)
				{
					this.profilePackAssets.RemoveAt(l);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int m = 0; m < this.liveEventContentAssets.Count; m++)
			{
				if (this.liveEventContentAssets[m] == null)
				{
					this.liveEventContentAssets.RemoveAt(m);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int n = 0; n < this.collectableCardAssets.Count; n++)
			{
				if (this.collectableCardAssets[n] == null)
				{
					this.collectableCardAssets.RemoveAt(n);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num = 0; num < this.liveOfferContentAssets.Count; num++)
			{
				if (this.liveOfferContentAssets[num] == null)
				{
					this.liveOfferContentAssets.RemoveAt(num);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num2 = 0; num2 < this.sketchThumbnailAssets.Count; num2++)
			{
				if (this.sketchThumbnailAssets[num2] == null)
				{
					this.sketchThumbnailAssets.RemoveAt(num2);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num3 = 0; num3 < this.sketchActorsAssets.Count; num3++)
			{
				if (this.sketchActorsAssets[num3] == null)
				{
					this.sketchActorsAssets.RemoveAt(num3);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num4 = 0; num4 < this.frameContainerAssets.Count; num4++)
			{
				if (this.frameContainerAssets[num4] == null)
				{
					this.frameContainerAssets.RemoveAt(num4);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num5 = 0; num5 < this.liveProfileThemesAssets.Count; num5++)
			{
				if (this.liveProfileThemesAssets[num5] == null)
				{
					this.liveProfileThemesAssets.RemoveAt(num5);
					this.liveProfileThemesVersion++;
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num6 = 0; num6 < this.customFaderAssets.Count; num6++)
			{
				if (this.customFaderAssets[num6] == null)
				{
					this.customFaderAssets.RemoveAt(num6);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num7 = 0; num7 < this.storyHeaderAssets.Count; num7++)
			{
				if (this.storyHeaderAssets[num7] == null)
				{
					this.storyHeaderAssets.RemoveAt(num7);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num8 = 0; num8 < this.anthologyAssets.Count; num8++)
			{
				if (this.anthologyAssets[num8] == null)
				{
					this.anthologyAssets.RemoveAt(num8);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num9 = 0; num9 < this.keepAlivePackAssets.Count; num9++)
			{
				if (this.keepAlivePackAssets[num9] == null)
				{
					this.keepAlivePackAssets.RemoveAt(num9);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num10 = 0; num10 < this.avatarPackAssets.Count; num10++)
			{
				if (this.avatarPackAssets[num10] == null)
				{
					this.avatarPackAssets.RemoveAt(num10);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num11 = 0; num11 < this.avatarExtensionPackAssets.Count; num11++)
			{
				if (this.avatarExtensionPackAssets[num11] == null)
				{
					this.avatarExtensionPackAssets.RemoveAt(num11);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num12 = 0; num12 < this.storySplashManagers.Count; num12++)
			{
				if (this.storySplashManagers[num12] == null)
				{
					this.storySplashManagers.RemoveAt(num12);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num13 = 0; num13 < this.sceneAvatarManagers.Count; num13++)
			{
				if (this.sceneAvatarManagers[num13] == null)
				{
					this.sceneAvatarManagers.RemoveAt(num13);
					flag = false;
					break;
				}
			}
		}
		flag = false;
		while (!flag)
		{
			flag = true;
			for (int num14 = 0; num14 < this.sceneLoungeManagers.Count; num14++)
			{
				if (this.sceneLoungeManagers[num14] == null)
				{
					this.sceneLoungeManagers.RemoveAt(num14);
					flag = false;
					break;
				}
			}
		}
	}

	// Token: 0x06006061 RID: 24673 RVA: 0x002BCDA4 File Offset: 0x002BAFA4
	public void QueueItemAnimationBundles(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP)
	{
		try
		{
			if (!(null == JFCABBGNNKJ) && JFCABBGNNKJ.chapterAssetPacks != null && OLKMHHNMDLP >= 0 && OLKMHHNMDLP < JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.JLNEAJBNHAK())
					{
						if (!KHPGPLAMAIN.EJCNHEBIOJF())
						{
							if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
							{
								for (int i = 0; i < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks.Count; i++)
								{
									if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i] < 1)
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Invalid item animation bundle index in story header, skipped:" + JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i].ToString());
									}
									else
									{
										this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleItemAnimationPack, JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006062 RID: 24674 RVA: 0x002BCEE4 File Offset: 0x002BB0E4
	private void BGLNEPMBPBE()
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i++)
		{
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
			{
				AssetBundleManager.UnloadAssetBundle(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1), this.MFPCGBNKHCC[i].AMJBNEILEKN);
			}
		}
	}

	// Token: 0x06006063 RID: 24675 RVA: 0x002BCF5A File Offset: 0x002BB15A
	public bool LobbyAssetsLoaded()
	{
		return this.anthologyPreview2Assets.Count > 0;
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06006064 RID: 24676 RVA: 0x002BCF6C File Offset: 0x002BB16C
	public static AssetsManager EHBBFMCILPC
	{
		get
		{
			if (!AssetsManager.IKLAPGJDMNA)
			{
				AssetsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AssetsManager)) as AssetsManager);
				if (!AssetsManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active AssetsManager script on a GameObject in your scene.");
				}
			}
			return AssetsManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06006065 RID: 24677 RVA: 0x002BCFB9 File Offset: 0x002BB1B9
	public bool ELMHLBHEKDM()
	{
		return this.DLFNGJILCEH != JLINKDNLADM.Progress && !AssetBundleManager.IsBusy() && this.KAHJMAHGDFI == KGDFLLFLIPM.Idle;
	}

	// Token: 0x06006066 RID: 24678 RVA: 0x002BCFD8 File Offset: 0x002BB1D8
	public void KDBDKJFNCHM(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, int AFENNOBCLFN, FLDBFOADFLH NLIDEHHMLLP, bool AOGDLLHFJHH, bool NOJLAFNCGHF, bool LHGBCGJNFJK, GameObject BFGBPKIGAJI, int NGMOBELPFII, string DDPMFNOGJIE, bool BNLEIHNDMOI = false, bool MLMDHOHNOPM = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		OPMGJPHENFJ opmgjphenfj = new OPMGJPHENFJ();
		opmgjphenfj.PCNJLOJEAJI = BFGBPKIGAJI;
		opmgjphenfj.GGICIBLJIKI = MEFKFOHCOHK;
		opmgjphenfj.MHGBNAFGKCE = AFENNOBCLFN;
		opmgjphenfj.OPDHIOLLADO = NLIDEHHMLLP;
		opmgjphenfj.OBKCKGHFMDN = PBKAAIONJOB;
		opmgjphenfj.MOKINGPDAFE = true;
		opmgjphenfj.KKJNKAFMANA = AOGDLLHFJHH;
		opmgjphenfj.AEPMNLGJBOI = LHGBCGJNFJK;
		opmgjphenfj.AOPIMPMDEHO = NGMOBELPFII;
		opmgjphenfj.IFKICNLMPPD = DDPMFNOGJIE;
		opmgjphenfj.MIACKIKIFJJ = BNLEIHNDMOI;
		opmgjphenfj.IPDGGPBONDP = false;
		opmgjphenfj.AMJBNEILEKN = MLMDHOHNOPM;
		if (!this.FKHJIMFBFGK(opmgjphenfj))
		{
			this.MFPCGBNKHCC.Add(opmgjphenfj);
		}
	}

	// Token: 0x06006067 RID: 24679 RVA: 0x002BD077 File Offset: 0x002BB277
	public static void UncacheAssetBundle(string LBGGLHDOICL)
	{
		AssetBundleManager.UncacheAssetBundle(LBGGLHDOICL);
	}

	// Token: 0x06006068 RID: 24680 RVA: 0x002BD07F File Offset: 0x002BB27F
	public bool NLPEGEMCEIG()
	{
		return this.DLFNGJILCEH != JLINKDNLADM.Progress && !AssetBundleManager.IsBusy() && this.KAHJMAHGDFI == KGDFLLFLIPM.Busy;
	}

	// Token: 0x06006069 RID: 24681 RVA: 0x002BD09C File Offset: 0x002BB29C
	private IEnumerator OFBKLJILINA()
	{
		AssetsManager.MBBODFDMLDD mbbodfdmldd = new AssetsManager.MBBODFDMLDD(1);
		mbbodfdmldd.<>4__this = this;
		return mbbodfdmldd;
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x002BD0AC File Offset: 0x002BB2AC
	public void DownloadQueuedAssetBundles(string JEOKFNAFILA = null, string IOPJPDKHMDG = null, bool EAGAMDIOMEB = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error - can not queue asset bundles when download in progress.");
			return;
		}
		this.KAHJMAHGDFI = KGDFLLFLIPM.Busy;
		this.CFEJAMGNPAC("pipeline start");
		this.MPEGJMEEIFA = JEOKFNAFILA;
		this.IDHIPDNNLIN = IOPJPDKHMDG;
		NPOILPKELOJ.DAEOMOJFKDN = false;
		this.EGLPBAJMOHJ = false;
		this.IOOFABBLGKE = EAGAMDIOMEB;
		this.ODDNKAMKHDA = DPGJIJGOCIC.MKJLJPMEPCC();
		base.StartCoroutine(this.IMBNBDMAEIP());
	}

	// Token: 0x0600606B RID: 24683 RVA: 0x002BD119 File Offset: 0x002BB319
	public void ActivatePendingScenes()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x0600606C RID: 24684 RVA: 0x002BD120 File Offset: 0x002BB320
	public void QueueCustomEffectsBundles(AssetAnthologyHeader HCLEPODFDFB)
	{
		try
		{
			if (!(null == HCLEPODFDFB) && HCLEPODFDFB.customEffectsLoad != null)
			{
				if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.CFGMABEDPIJ())
				{
					if (!KHPGPLAMAIN.EJCNHEBIOJF())
					{
						if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
						{
							for (int i = 0; i < HCLEPODFDFB.customEffectsLoad.Count; i++)
							{
								if (HCLEPODFDFB.customEffectsLoad[i] < 1)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("Invalid custom effects bundle index in anthology header, skipped:" + HCLEPODFDFB.customEffectsLoad[i].ToString());
								}
								else
								{
									this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleCustomEffects, HCLEPODFDFB.customEffectsLoad[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600606D RID: 24685 RVA: 0x002BD1F8 File Offset: 0x002BB3F8
	public void LDIHJFGPKNG(string LBGGLHDOICL)
	{
		for (int i = 1; i < this.IEADNMABIID.Count; i++)
		{
			if (this.IEADNMABIID[i].Equals(LBGGLHDOICL))
			{
				AssetBundleManager.JKPCFOKPMOJ(this.IEADNMABIID[i], true);
				this.IEADNMABIID.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x002BD250 File Offset: 0x002BB450
	public void NLHHPEJFBBA(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, int AFENNOBCLFN)
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i += 0)
		{
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == PBKAAIONJOB && this.MFPCGBNKHCC[i].GGICIBLJIKI == MEFKFOHCOHK && this.MFPCGBNKHCC[i].MHGBNAFGKCE == AFENNOBCLFN && this.MFPCGBNKHCC[i].AOPIMPMDEHO >= 1)
			{
				this.MFPCGBNKHCC[i].AOPIMPMDEHO = -1;
				DPGJIJGOCIC.ADFCDFHBDAF("continue" + MEFKFOHCOHK.ToString() + "OnEmailUnsubscribeException" + AFENNOBCLFN.ToString());
			}
		}
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x002BD300 File Offset: 0x002BB500
	private void CFEJAMGNPAC(string AMGIHFDKDPM)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.MFPCGBNKHCC.Count; i++)
			{
				list.Add(string.Concat(new string[]
				{
					this.MFPCGBNKHCC[i].OBKCKGHFMDN.ToString(),
					"/",
					this.MFPCGBNKHCC[i].GGICIBLJIKI.ToString(),
					"/",
					this.MFPCGBNKHCC[i].MHGBNAFGKCE.ToString()
				}));
			}
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"[LoadingEnv] [t=",
				Time.realtimeSinceStartup.ToString("0.00"),
				"s] ",
				AMGIHFDKDPM,
				" | Caching.ready=",
				Caching.ready.ToString(),
				" | queue: [",
				string.Join(", ", list.ToArray()),
				"] | ",
				LoadingEnvironmentManager.DescribeHeldBundles()
			}));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x002BD444 File Offset: 0x002BB644
	public void IFNKDAJELFP()
	{
		this.OOKEOHFPOKN = true;
	}

	// Token: 0x06006071 RID: 24689 RVA: 0x002BD44D File Offset: 0x002BB64D
	public bool NFDDDOBCCGG()
	{
		return this.anthologyPreview2Assets.Count > 1;
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x002BD45D File Offset: 0x002BB65D
	public int CDHAFEAGLLD()
	{
		return this.JNDGOONNLIA;
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x002BD468 File Offset: 0x002BB668
	public string GetCdnUrlAbbrevation()
	{
		try
		{
			string text = this.OKMBMHIKIBC;
			if (text.Length > 0)
			{
				text = text.Replace("https://", "").Replace("http://", "");
				if (text.Contains("/"))
				{
					text = text.Substring(0, text.IndexOf("/"));
				}
				if (text.Length > 0 && text.Contains("."))
				{
					text = text.Substring(0, text.LastIndexOf("."));
				}
				return text.Replace(".", "").Replace("-", "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x002BD534 File Offset: 0x002BB734
	public void ForceQueuedAssetBundleChapterLifetime(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, int AFENNOBCLFN)
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i++)
		{
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == PBKAAIONJOB && this.MFPCGBNKHCC[i].GGICIBLJIKI == MEFKFOHCOHK && this.MFPCGBNKHCC[i].MHGBNAFGKCE == AFENNOBCLFN && this.MFPCGBNKHCC[i].AOPIMPMDEHO >= 0)
			{
				this.MFPCGBNKHCC[i].AOPIMPMDEHO = -1;
				DPGJIJGOCIC.ADFCDFHBDAF("Queued asset bundle promoted to chapter lifetime:" + MEFKFOHCOHK.ToString() + "_" + AFENNOBCLFN.ToString());
			}
		}
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x002BD5E1 File Offset: 0x002BB7E1
	private IEnumerator IMBNBDMAEIP()
	{
		NPOILPKELOJ.LKNKIODCMFJ();
		yield return base.StartCoroutine(this.LGCDNFCMEHN());
		while (this.NJGOLBEFEPJ > 0 || AssetBundleManager.IsBusy())
		{
			yield return null;
		}
		if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
		{
			this.BGLNEPMBPBE();
		}
		this.CFEJAMGNPAC("download run " + this.DLFNGJILCEH.ToString() + ", cleaning failed cache entries: " + AssetBundleManager.DescribeDownloadingErrors());
		AssetBundleManager.CleanFailedAssetBundleCache();
		this.NJGOLBEFEPJ = 0;
		this.CleanupDownloadQueue();
		if (this.DLFNGJILCEH == JLINKDNLADM.Success)
		{
			base.StartCoroutine(this.MFCEPBHJMGP());
		}
		else
		{
			if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
			{
				this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
				this.BLHLMFJOCFP();
			}
			if (this.AKCDHJCIJCG && !this.IOOFABBLGKE)
			{
				if (!this.GPKCJNEIHBH)
				{
					FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnForceOne.ToString(), "", false, false);
				}
				this.GPKCJNEIHBH = true;
			}
			AssetBundleManager.CleanPendingRequests();
			base.StartCoroutine(this.FLBEJLKJHML());
		}
		yield break;
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x002BD5F0 File Offset: 0x002BB7F0
	private IEnumerator HONFMKOGDJP(OPMGJPHENFJ OMFEFBJKHJG, NPOILPKELOJ JLDHNMKCIGH, string LBGGLHDOICL)
	{
		this.NJGOLBEFEPJ++;
		DPGJIJGOCIC.NFIDPOMCNLP("assetBundleLoadOperationActiveCoroutines:" + this.NJGOLBEFEPJ.ToString());
		if (JLDHNMKCIGH != null)
		{
			yield return base.StartCoroutine(JLDHNMKCIGH);
		}
		if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(4);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.NJGOLBEFEPJ--;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, type not implemented in ProcessAssetBundlePreloadOperationRequest():" + OMFEFBJKHJG.OBKCKGHFMDN.ToString());
			this.NJGOLBEFEPJ--;
		}
		yield break;
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x002BD614 File Offset: 0x002BB814
	public void MPPDBIMBFEM(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i += 0)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				this.storyAssets.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x002BD658 File Offset: 0x002BB858
	public string CDNAPLEBPML()
	{
		return this.OKMBMHIKIBC;
	}

	// Token: 0x06006079 RID: 24697 RVA: 0x002BD658 File Offset: 0x002BB858
	public string GetDepot()
	{
		return this.OKMBMHIKIBC;
	}

	// Token: 0x0600607A RID: 24698 RVA: 0x002BD660 File Offset: 0x002BB860
	public SceneLoungeManager IHPFHEJOBPB(int MEFKFOHCOHK)
	{
		if (this.sceneLoungeManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneLoungeManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x002BCFB9 File Offset: 0x002BB1B9
	public bool AHALCGLJBLB()
	{
		return this.DLFNGJILCEH != JLINKDNLADM.Progress && !AssetBundleManager.IsBusy() && this.KAHJMAHGDFI == KGDFLLFLIPM.Idle;
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x002BD67E File Offset: 0x002BB87E
	public void PEBIGAFFHMI(LNDOOJOFFOM ODGGFGGKPIG, string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		this.GOBDKBEIPMC = ODGGFGGKPIG;
		AssetBundleManager.SetFolderIndexHint((int)this.GOBDKBEIPMC);
		base.StartCoroutine(this.AFPOIEJOBIH(PLDNHKIKDIB, KLCOCBODJAF));
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x002BD6A4 File Offset: 0x002BB8A4
	public void NMOAABDAILN(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 1; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				this.storyAssets.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x002BD6E8 File Offset: 0x002BB8E8
	private void Update()
	{
		this.FPKDPDLNDKH.HBEPAFKIIEH();
	}

	// Token: 0x0600607F RID: 24703 RVA: 0x002BD6F5 File Offset: 0x002BB8F5
	public void ALPHMPNHLAP()
	{
		this.GPKCJNEIHBH = false;
	}

	// Token: 0x06006080 RID: 24704 RVA: 0x002BD700 File Offset: 0x002BB900
	public void SetDepot(string MNOCEFGMBHK, JSONArray FDILGIMHNBJ)
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			if (DPGJIJGOCIC.DLEEHLGNCOD(MNOCEFGMBHK, this.DGAICDDKDGJ) && (this.LEOFIDDNKAF.PingableUrlInUse() || (this.LEOFIDDNKAF.IsReady() && !this.LEOFIDDNKAF.IsPingableUrl(MNOCEFGMBHK))))
			{
				MNOCEFGMBHK = this.LEOFIDDNKAF.GetPingableUrl(this.DGAICDDKDGJ) + this.KDPNMFNIKFO(MNOCEFGMBHK) + "/";
				DPGJIJGOCIC.NFIDPOMCNLP("AssetsManager.SetDepot(): urlPingManager.GetPingableUrl():" + MNOCEFGMBHK);
			}
			this.BLHLMFJOCFP();
		}
		if (!this.OKMBMHIKIBC.Equals(MNOCEFGMBHK) || !this.CLBECEDIAAB.ToString().Equals(FDILGIMHNBJ.ToString()))
		{
			this.JNDGOONNLIA++;
			this.POOGGCLFKMI = true;
			if (this.OKMBMHIKIBC.Length > 0)
			{
				this.SetDirty();
			}
			DPGJIJGOCIC.NFIDPOMCNLP("SetDepot(), cdnDepot:" + MNOCEFGMBHK);
			DPGJIJGOCIC.NFIDPOMCNLP("SubDepots(), cdnSubDepots:" + FDILGIMHNBJ.ToString());
		}
		this.OKMBMHIKIBC = MNOCEFGMBHK;
		try
		{
			AssetsManager.cdnDepotForAnalytics = this.OKMBMHIKIBC;
			if (AssetsManager.cdnDepotForAnalytics.Length > 0 && AssetsManager.cdnDepotForAnalytics.Contains("."))
			{
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Substring(0, AssetsManager.cdnDepotForAnalytics.LastIndexOf("."));
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("www", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("/", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace(".", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("-", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("_", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace(":", "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CLBECEDIAAB = FDILGIMHNBJ;
		PopupSettingsManager.cdnDepot = MNOCEFGMBHK;
		if (PopupSettingsManager.cdnDepot.EndsWith("/"))
		{
			PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(0, PopupSettingsManager.cdnDepot.Length - 1);
			if (PopupSettingsManager.cdnDepot.Contains("/"))
			{
				PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(PopupSettingsManager.cdnDepot.LastIndexOf("/") + 1);
			}
		}
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x002BD974 File Offset: 0x002BBB74
	public void UnloadPersistentAssetBundles()
	{
		for (int i = 0; i < this.IEADNMABIID.Count; i++)
		{
			AssetBundleManager.UnloadAssetBundle(this.IEADNMABIID[i], false);
		}
		this.IEADNMABIID.Clear();
		for (int j = 0; j < this.EIJMNBNOKBC.Count; j++)
		{
			AssetBundleManager.UnloadAssetBundle(this.EIJMNBNOKBC[j], true);
		}
		this.EIJMNBNOKBC.Clear();
		AssetBundleManager.LogLoadedAssetBundlesCount();
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x002BD9EC File Offset: 0x002BBBEC
	public void EGDFMHCEIGE(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 1; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				this.storyAssets.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x002BDA30 File Offset: 0x002BBC30
	private void FLPNKMMJJDH()
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i += 0)
		{
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI._deprecated1)
			{
				AssetBundleManager.KIKMOCFICEA(OMIMIKMIMFE.FDBKCIHEHIM(NMKDCBPMCKI._deprecated1, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1), this.MFPCGBNKHCC[i].AMJBNEILEKN);
			}
		}
	}

	// Token: 0x06006084 RID: 24708 RVA: 0x002BDAA8 File Offset: 0x002BBCA8
	private bool HBMCLGPPCOA(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, bool NOGJCGPAECH = false)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStory)
		{
			for (int i = 0; i < this.avatarPackAssets.Count; i += 0)
			{
				if (this.avatarPackAssets[i].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-22))
		{
			for (int j = 1; j < this.keepAlivePackAssets.Count; j += 0)
			{
				if (this.keepAlivePackAssets[j].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-39))
		{
			for (int k = 1; k < this.iconsPackAssets.Count; k++)
			{
				if (this.iconsPackAssets[k].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-86))
		{
			for (int l = 1; l < this.profilePackAssets.Count; l += 0)
			{
				if (this.profilePackAssets[l].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-59))
		{
			for (int m = 0; m < this.avatarExtensionPackAssets.Count; m++)
			{
				if (this.avatarExtensionPackAssets[m].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)71)
		{
			if (!NOGJCGPAECH)
			{
				for (int n = 1; n < this.anthologyPreview2Assets.Count; n++)
				{
					if (this.anthologyPreview2Assets[n].index == MEFKFOHCOHK)
					{
						return false;
					}
				}
			}
			else
			{
				for (int num = 0; num < this.anthologyPreview2AssetsMini.Count; num++)
				{
					if (this.anthologyPreview2AssetsMini[num].index == MEFKFOHCOHK)
					{
						return false;
					}
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated0)
		{
			for (int num2 = 1; num2 < this.liveEventContentAssets.Count; num2++)
			{
				if (this.liveEventContentAssets[num2].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-8))
		{
			for (int num3 = 0; num3 < this.collectableCardAssets.Count; num3 += 0)
			{
				if (this.collectableCardAssets[num3].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-37))
		{
			for (int num4 = 1; num4 < this.liveOfferContentAssets.Count; num4++)
			{
				if (this.liveOfferContentAssets[num4].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			for (int num5 = 1; num5 < this.sketchThumbnailAssets.Count; num5 += 0)
			{
				if (this.sketchThumbnailAssets[num5].sketchId == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)125)
		{
			for (int num6 = 1; num6 < this.sketchActorsAssets.Count; num6 += 0)
			{
				if (this.sketchActorsAssets[num6].sketchId == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-102))
		{
			for (int num7 = 0; num7 < this.frameContainerAssets.Count; num7 += 0)
			{
				if (null != this.frameContainerAssets[num7] && this.frameContainerAssets[num7].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated5)
		{
			for (int num8 = 0; num8 < this.liveProfileThemesAssets.Count; num8++)
			{
				if (null != this.liveProfileThemesAssets[num8] && this.liveProfileThemesAssets[num8].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-49))
		{
			for (int num9 = 0; num9 < this.customFaderAssets.Count; num9 += 0)
			{
				if (this.customFaderAssets[num9].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-12))
		{
			for (int num10 = 0; num10 < this.customEffectsAssets.Count; num10++)
			{
				if (null != this.customEffectsAssets[num10] && this.customEffectsAssets[num10].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-118))
		{
			for (int num11 = 0; num11 < this.storyNpcAnimationAssets.Count; num11++)
			{
				if (null != this.storyNpcAnimationAssets[num11] && this.storyNpcAnimationAssets[num11].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-17))
		{
			for (int num12 = 0; num12 < this.storyItemAnimationAssets.Count; num12 += 0)
			{
				if (null != this.storyItemAnimationAssets[num12] && this.storyItemAnimationAssets[num12].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated0)
		{
			for (int num13 = 1; num13 < this.storySplashManagers.Count; num13++)
			{
				if (this.storySplashManagers[num13].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)51)
		{
			for (int num14 = 1; num14 < this.sceneAvatarManagers.Count; num14++)
			{
				if (this.sceneAvatarManagers[num14].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-2))
		{
			for (int num15 = 1; num15 < this.sceneLoungeManagers.Count; num15++)
			{
				if (this.sceneLoungeManagers[num15].loungeAnthologyIndex == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else
		{
			if (PBKAAIONJOB == (NMKDCBPMCKI)121 && null != this.lobbyDataAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)90 && null != this.lobbyDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-76) && null != this.sketchesDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-9) && null != this.profileDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)70 && null != this.profileDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarExtensionPack && null != this.profileDataAsset3)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-124) && null != this.profileDataAsset4)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)76 && null != this.profileDataAsset5)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-35) && null != this.profileDataAsset6)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)124 && null != this.profileDataLocalizedAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)79 && null != this.headersPackAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-33) && null != this.headersPackAsset2)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI._deprecated0 && null != this.textPackAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack && null != this.purchasingViewManager)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarExtensionPack && null != this.cutsceneViewManager)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.Count && null != this.sketchViewManager)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x002BE140 File Offset: 0x002BC340
	public UrlPingManager GetUrlPingManager()
	{
		return this.LEOFIDDNKAF;
	}

	// Token: 0x06006086 RID: 24710 RVA: 0x002BD444 File Offset: 0x002BB644
	public void PACHCEAEPOB()
	{
		this.OOKEOHFPOKN = true;
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x002BE148 File Offset: 0x002BC348
	public void AGIPAABAHDM()
	{
		this.MFPCGBNKHCC.Clear();
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x002BE155 File Offset: 0x002BC355
	private void KLGMKIJJDFN()
	{
		if (AssetsManager.IKLAPGJDMNA == this)
		{
			AssetsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x002BE16C File Offset: 0x002BC36C
	public void OHKMEBKBKML(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				this.storyAssets.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600608A RID: 24714 RVA: 0x002BE1B0 File Offset: 0x002BC3B0
	public SceneAvatarManager NNJPKCECEED(int MEFKFOHCOHK)
	{
		if (this.sceneAvatarManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneAvatarManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x0600608B RID: 24715 RVA: 0x002BE1D0 File Offset: 0x002BC3D0
	public void QueueAssetBundleDownload(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, int AFENNOBCLFN, FLDBFOADFLH NLIDEHHMLLP, bool AOGDLLHFJHH, bool NOJLAFNCGHF, bool LHGBCGJNFJK, GameObject BFGBPKIGAJI, int NGMOBELPFII, bool GDCIJAMKAGE, string DDPMFNOGJIE, bool BNLEIHNDMOI = false, bool GDFCMGNGGNK = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH() && AOGDLLHFJHH)
		{
			PopupSettingsManager.forceHideSoundOption = true;
			DPGJIJGOCIC.ADFCDFHBDAF("Audio asset bundle loading skipped due to low end device specs:" + MEFKFOHCOHK.ToString() + "_" + AFENNOBCLFN.ToString());
			return;
		}
		if (GDCIJAMKAGE && AOGDLLHFJHH)
		{
			PopupSettingsManager.forceHideSoundOption = true;
			DPGJIJGOCIC.ADFCDFHBDAF("Audio asset bundle loading skipped due forced option:" + MEFKFOHCOHK.ToString() + "_" + AFENNOBCLFN.ToString());
			return;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() && AOGDLLHFJHH)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("Audio Asset bundle loading skipped due to in-game settings (sound is off):" + MEFKFOHCOHK.ToString() + "_" + AFENNOBCLFN.ToString());
			return;
		}
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error - can not queue asset bundles when download in progress.");
			return;
		}
		OPMGJPHENFJ opmgjphenfj = new OPMGJPHENFJ();
		opmgjphenfj.PCNJLOJEAJI = BFGBPKIGAJI;
		opmgjphenfj.GGICIBLJIKI = MEFKFOHCOHK;
		opmgjphenfj.MHGBNAFGKCE = AFENNOBCLFN;
		opmgjphenfj.OPDHIOLLADO = NLIDEHHMLLP;
		opmgjphenfj.OBKCKGHFMDN = PBKAAIONJOB;
		opmgjphenfj.MOKINGPDAFE = false;
		opmgjphenfj.KKJNKAFMANA = AOGDLLHFJHH;
		opmgjphenfj.AEPMNLGJBOI = LHGBCGJNFJK;
		opmgjphenfj.AOPIMPMDEHO = NGMOBELPFII;
		opmgjphenfj.IFKICNLMPPD = DDPMFNOGJIE;
		opmgjphenfj.MIACKIKIFJJ = BNLEIHNDMOI;
		opmgjphenfj.IPDGGPBONDP = GDFCMGNGGNK;
		opmgjphenfj.AMJBNEILEKN = false;
		if (!this.FKHJIMFBFGK(opmgjphenfj))
		{
			this.MFPCGBNKHCC.Add(opmgjphenfj);
		}
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x002BE307 File Offset: 0x002BC507
	private IEnumerator MJGCKOIFLNK()
	{
		AssetsManager.CNBODGAHJMP cnbodgahjmp = new AssetsManager.CNBODGAHJMP(1);
		cnbodgahjmp.<>4__this = this;
		return cnbodgahjmp;
	}

	// Token: 0x0600608D RID: 24717 RVA: 0x002BE316 File Offset: 0x002BC516
	public JLINKDNLADM GCCDEJENDFN()
	{
		return this.DLFNGJILCEH;
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x002BE320 File Offset: 0x002BC520
	private bool MKKJAHFKPBB(OPMGJPHENFJ BBHLOECBJJN)
	{
		for (int i = 1; i < this.MFPCGBNKHCC.Count; i += 0)
		{
			if (this.MFPCGBNKHCC[i].ODLINHPHKIK(BBHLOECBJJN))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600608F RID: 24719 RVA: 0x002BE35C File Offset: 0x002BC55C
	private void FCBHOEFELNF(string AMGIHFDKDPM)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.MFPCGBNKHCC.Count; i++)
			{
				List<string> list2 = list;
				string[] array = new string[1];
				array[1] = this.MFPCGBNKHCC[i].OBKCKGHFMDN.ToString();
				array[0] = "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n";
				array[8] = this.MFPCGBNKHCC[i].GGICIBLJIKI.ToString();
				array[1] = "$nl";
				array[5] = this.MFPCGBNKHCC[i].MHGBNAFGKCE.ToString();
				list2.Add(string.Concat(array));
			}
			string[] array2 = new string[-5];
			array2[0] = "sid";
			array2[1] = Time.realtimeSinceStartup.ToString("free");
			array2[7] = "fdem";
			array2[2] = AMGIHFDKDPM;
			array2[5] = "Vol";
			array2[1] = Caching.ready.ToString();
			array2[3] = "actant";
			array2[5] = string.Join("per", list.ToArray());
			array2[1] = "ok";
			array2[34] = LoadingEnvironmentManager.DescribeHeldBundles();
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array2));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06006090 RID: 24720 RVA: 0x002BE4A0 File Offset: 0x002BC6A0
	public void NADFIDNMKFK()
	{
		for (int i = 0; i < this.IEADNMABIID.Count; i += 0)
		{
			AssetBundleManager.KIKMOCFICEA(this.IEADNMABIID[i], true);
		}
		this.IEADNMABIID.Clear();
		for (int j = 0; j < this.EIJMNBNOKBC.Count; j++)
		{
			AssetBundleManager.IOKDHECGLON(this.EIJMNBNOKBC[j], true);
		}
		this.EIJMNBNOKBC.Clear();
		AssetBundleManager.LogLoadedAssetBundlesCount();
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x002BE518 File Offset: 0x002BC718
	public void CONJMNANDPM()
	{
		NPOILPKELOJ.MOKPIOFAFPE();
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x002BE51F File Offset: 0x002BC71F
	private IEnumerator FLBEJLKJHML()
	{
		yield return new WaitForEndOfFrame();
		if (this.IOOFABBLGKE || NPOILPKELOJ.DAEOMOJFKDN)
		{
			this.EGLPBAJMOHJ = true;
			if (NPOILPKELOJ.DAEOMOJFKDN)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.bugRep.ToString(), FFPHBMFGCNN.handBfix.ToString(), BGHLMGPPCNN.bugCdnDdlck.ToString(), false, false);
				NPOILPKELOJ.DAEOMOJFKDN = false;
			}
		}
		this.MGHGEJLBBIH();
		if (this.IDHIPDNNLIN == null)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAssetsManagerDownloadFailed", 0f);
		}
		else
		{
			string idhipdnnlin = this.IDHIPDNNLIN;
			this.IDHIPDNNLIN = null;
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(idhipdnnlin, 0f);
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		yield break;
	}

	// Token: 0x06006093 RID: 24723 RVA: 0x002BE52E File Offset: 0x002BC72E
	private IEnumerator HLMLJKGKKPD(string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		NPOILPKELOJ.LKNKIODCMFJ();
		this.DLFNGJILCEH = JLINKDNLADM.Progress;
		if (!AssetBundleManager.ManifestInitialized((int)this.GOBDKBEIPMC))
		{
			IEnumerator enumerator = AssetBundleManager.Initialize(this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC);
			if (enumerator != null)
			{
				yield return base.StartCoroutine(enumerator);
			}
			PLOGDOACBMK assetBundleLoadManifestOperation = AssetBundleManager.GetAssetBundleLoadManifestOperation();
			bool requestSucceeded = false;
			requestSucceeded = (assetBundleLoadManifestOperation != null && !assetBundleLoadManifestOperation.HJOPIMGMGML());
			AssetBundleManager.ResetAssetBundleLoadManifestOperation();
			yield return new WaitForEndOfFrame();
			this.CFEJAMGNPAC("folder init done, cleaning failed cache entries: " + AssetBundleManager.DescribeDownloadingErrors());
			AssetBundleManager.CleanFailedAssetBundleCache();
			if (!requestSucceeded)
			{
				if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
					this.BLHLMFJOCFP();
				}
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.MGHGEJLBBIH();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(KLCOCBODJAF, 0f);
			}
			else
			{
				this.DLFNGJILCEH = JLINKDNLADM.Success;
				this.MGHGEJLBBIH();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(PLDNHKIKDIB, 0f);
			}
		}
		else
		{
			yield return new WaitForEndOfFrame();
			this.DLFNGJILCEH = JLINKDNLADM.Success;
			this.MGHGEJLBBIH();
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(PLDNHKIKDIB, 0f);
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		yield break;
	}

	// Token: 0x06006094 RID: 24724 RVA: 0x002BE54B File Offset: 0x002BC74B
	private void FKOPCAFJEKE()
	{
		this.FPKDPDLNDKH.ABJCALOEBGJ();
	}

	// Token: 0x06006095 RID: 24725 RVA: 0x002BE558 File Offset: 0x002BC758
	private bool KEAKJFDABEF(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, bool NOGJCGPAECH = false)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStory)
		{
			for (int i = 1; i < this.avatarPackAssets.Count; i++)
			{
				if (this.avatarPackAssets[i].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-32))
		{
			for (int j = 1; j < this.keepAlivePackAssets.Count; j += 0)
			{
				if (this.keepAlivePackAssets[j].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)76)
		{
			for (int k = 0; k < this.iconsPackAssets.Count; k += 0)
			{
				if (this.iconsPackAssets[k].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-79))
		{
			for (int l = 1; l < this.profilePackAssets.Count; l += 0)
			{
				if (this.profilePackAssets[l].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)64)
		{
			for (int m = 1; m < this.avatarExtensionPackAssets.Count; m++)
			{
				if (this.avatarExtensionPackAssets[m].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-67))
		{
			if (!NOGJCGPAECH)
			{
				for (int n = 1; n < this.anthologyPreview2Assets.Count; n += 0)
				{
					if (this.anthologyPreview2Assets[n].index == MEFKFOHCOHK)
					{
						return false;
					}
				}
			}
			else
			{
				for (int num = 1; num < this.anthologyPreview2AssetsMini.Count; num += 0)
				{
					if (this.anthologyPreview2AssetsMini[num].index == MEFKFOHCOHK)
					{
						return false;
					}
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCollectableCard)
		{
			for (int num2 = 1; num2 < this.liveEventContentAssets.Count; num2++)
			{
				if (this.liveEventContentAssets[num2].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)120)
		{
			for (int num3 = 1; num3 < this.collectableCardAssets.Count; num3 += 0)
			{
				if (this.collectableCardAssets[num3].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)57)
		{
			for (int num4 = 1; num4 < this.liveOfferContentAssets.Count; num4++)
			{
				if (this.liveOfferContentAssets[num4].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-63))
		{
			for (int num5 = 0; num5 < this.sketchThumbnailAssets.Count; num5 += 0)
			{
				if (this.sketchThumbnailAssets[num5].sketchId == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-96))
		{
			for (int num6 = 1; num6 < this.sketchActorsAssets.Count; num6++)
			{
				if (this.sketchActorsAssets[num6].sketchId == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)125)
		{
			for (int num7 = 0; num7 < this.frameContainerAssets.Count; num7 += 0)
			{
				if (null != this.frameContainerAssets[num7] && this.frameContainerAssets[num7].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchesData)
		{
			for (int num8 = 1; num8 < this.liveProfileThemesAssets.Count; num8++)
			{
				if (null != this.liveProfileThemesAssets[num8] && this.liveProfileThemesAssets[num8].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			for (int num9 = 1; num9 < this.customFaderAssets.Count; num9 += 0)
			{
				if (this.customFaderAssets[num9].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)92)
		{
			for (int num10 = 0; num10 < this.customEffectsAssets.Count; num10++)
			{
				if (null != this.customEffectsAssets[num10] && this.customEffectsAssets[num10].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)117)
		{
			for (int num11 = 1; num11 < this.storyNpcAnimationAssets.Count; num11++)
			{
				if (null != this.storyNpcAnimationAssets[num11] && this.storyNpcAnimationAssets[num11].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)88)
		{
			for (int num12 = 0; num12 < this.storyItemAnimationAssets.Count; num12 += 0)
			{
				if (null != this.storyItemAnimationAssets[num12] && this.storyItemAnimationAssets[num12].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			for (int num13 = 1; num13 < this.storySplashManagers.Count; num13++)
			{
				if (this.storySplashManagers[num13].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-98))
		{
			for (int num14 = 1; num14 < this.sceneAvatarManagers.Count; num14++)
			{
				if (this.sceneAvatarManagers[num14].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)93)
		{
			for (int num15 = 1; num15 < this.sceneLoungeManagers.Count; num15 += 0)
			{
				if (this.sceneLoungeManagers[num15].loungeAnthologyIndex == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else
		{
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-1) && null != this.lobbyDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-28) && null != this.lobbyDataAsset2)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)109 && null != this.sketchesDataAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-113) && null != this.profileDataAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCustomFader && null != this.profileDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileDataLocalized && null != this.profileDataAsset3)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-62) && null != this.profileDataAsset4)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)57 && null != this.profileDataAsset5)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-16) && null != this.profileDataAsset6)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-89) && null != this.profileDataLocalizedAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)61 && null != this.headersPackAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-12) && null != this.headersPackAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStorySplash && null != this.textPackAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI._deprecated2 && null != this.purchasingViewManager)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)116 && null != this.cutsceneViewManager)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-83) && null != this.sketchViewManager)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006096 RID: 24726 RVA: 0x002BD45D File Offset: 0x002BB65D
	public int GetSetDepotsCount()
	{
		return this.JNDGOONNLIA;
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x002BEBF0 File Offset: 0x002BCDF0
	public PurchasingViewManager JGDHEBKIECH()
	{
		return this.purchasingViewManager;
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x002BD44D File Offset: 0x002BB64D
	public bool LBMDNEAFNCJ()
	{
		return this.anthologyPreview2Assets.Count > 1;
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x002BEBF8 File Offset: 0x002BCDF8
	public SketchViewManager GetSketchViewManager()
	{
		return this.sketchViewManager;
	}

	// Token: 0x0600609A RID: 24730 RVA: 0x002BEC00 File Offset: 0x002BCE00
	public static bool NLPIGKKDDCM()
	{
		if (null == AssetsManager.IKLAPGJDMNA)
		{
			AssetsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AssetsManager)) as AssetsManager);
		}
		return AssetsManager.IKLAPGJDMNA != null;
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x002BEC34 File Offset: 0x002BCE34
	public void DNKOJKMJJEP()
	{
		this.QueueAssetBundleDownload((NMKDCBPMCKI)(-86), 1, -1, FLDBFOADFLH.finishDownloadAndProceed, true, true, true, null, -1, false, "", false, false);
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x002BEC59 File Offset: 0x002BCE59
	public bool DepotsUrlsHaveBeenPinged()
	{
		return !this.LEOFIDDNKAF.IsBusyBatch();
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x002BEC6C File Offset: 0x002BCE6C
	private int GGBJNCPDJEN()
	{
		if (this.GPKCJNEIHBH)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("AssetsManager.GetMaxNumberOfRunningLoadOperations(): forcing to 1");
			return 1;
		}
		int num;
		if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.highEnd)
		{
			num = this.CAACJIOPDOO;
		}
		else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.midEnd)
		{
			num = this.CAACJIOPDOO / 2;
		}
		else
		{
			num = this.CAACJIOPDOO / 4;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			num /= (int)NPOILPKELOJ.IKDKDPNCJBO;
		}
		if (num < 1)
		{
			num = 1;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("AssetsManager.GetMaxNumberOfRunningLoadOperations() adjust by connection signal (" + NPOILPKELOJ.IKDKDPNCJBO.ToString() + "):" + num.ToString());
		}
		else
		{
			DPGJIJGOCIC.ADFCDFHBDAF("AssetsManager.GetMaxNumberOfRunningLoadOperations():" + num.ToString());
		}
		return num;
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x002BED1C File Offset: 0x002BCF1C
	private void NONGBOJEOAK(AssetStoryHeader CMFNIGDJFKP)
	{
		if (null == CMFNIGDJFKP)
		{
			return;
		}
		if (AppManager.EHBBFMCILPC.UnsupportedRevision(CMFNIGDJFKP.minRevision))
		{
			return;
		}
		for (int i = 0; i < this.storyHeaderAssets.Count; i++)
		{
			if (null != this.storyHeaderAssets[i] && this.storyHeaderAssets[i].index == CMFNIGDJFKP.index)
			{
				return;
			}
		}
		this.storyHeaderAssets.Add(CMFNIGDJFKP);
	}

	// Token: 0x0600609F RID: 24735 RVA: 0x002BED98 File Offset: 0x002BCF98
	public void MCHHMOEJIPM(string MNOCEFGMBHK, JSONArray FDILGIMHNBJ)
	{
		if (GeoLocationManager.GDLOJPBIPBC(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
		{
			if (DPGJIJGOCIC.OABIDECDDJP(MNOCEFGMBHK, this.DGAICDDKDGJ) && (this.LEOFIDDNKAF.PingableUrlInUse() || (this.LEOFIDDNKAF.FILKPAJMLCG() && !this.LEOFIDDNKAF.DCIKPGFCEND(MNOCEFGMBHK))))
			{
				MNOCEFGMBHK = this.LEOFIDDNKAF.LMGPKDHAEOK(this.DGAICDDKDGJ) + this.EHEEAGOLJAJ(MNOCEFGMBHK) + "loungetreasuresyouhave";
				DPGJIJGOCIC.NFIDPOMCNLP("loungestoryfinished" + MNOCEFGMBHK);
			}
			this.BLHLMFJOCFP();
		}
		if (!this.OKMBMHIKIBC.Equals(MNOCEFGMBHK) || !this.CLBECEDIAAB.ToString().Equals(FDILGIMHNBJ.ToString()))
		{
			this.JNDGOONNLIA++;
			this.POOGGCLFKMI = true;
			if (this.OKMBMHIKIBC.Length > 0)
			{
				this.SetDirty();
			}
			DPGJIJGOCIC.CMGOAFDBAOH("topMatch:" + MNOCEFGMBHK);
			DPGJIJGOCIC.NFIDPOMCNLP("acliffbw20" + FDILGIMHNBJ.ToString());
		}
		this.OKMBMHIKIBC = MNOCEFGMBHK;
		try
		{
			AssetsManager.cdnDepotForAnalytics = this.OKMBMHIKIBC;
			if (AssetsManager.cdnDepotForAnalytics.Length > 0 && AssetsManager.cdnDepotForAnalytics.Contains("SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident="))
			{
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Substring(0, AssetsManager.cdnDepotForAnalytics.LastIndexOf("Skiped loading duplicate story save with index "));
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("%", "ratePopupResult");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("coll2", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("yes", "spld");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("OnStoryChoiceClick", "Starting non-parallel download:");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("", "ok");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("tutortitle", "");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CLBECEDIAAB = FDILGIMHNBJ;
		PopupSettingsManager.cdnDepot = MNOCEFGMBHK;
		if (PopupSettingsManager.cdnDepot.EndsWith("No camera found."))
		{
			PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(1, PopupSettingsManager.cdnDepot.Length - 0);
			if (PopupSettingsManager.cdnDepot.Contains("Error. OnChoiceExtendedEnvironmentChangePart2(), environment not found:"))
			{
				PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(PopupSettingsManager.cdnDepot.LastIndexOf("accountSuspended") + 0);
			}
		}
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x002BE155 File Offset: 0x002BC355
	private void GNILOOJAEJL()
	{
		if (AssetsManager.IKLAPGJDMNA == this)
		{
			AssetsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x002BF00C File Offset: 0x002BD20C
	public void NJEPIEPCCOF(NMKDCBPMCKI PBKAAIONJOB, int OIGJAFGFIGP = -1)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			for (int i = 0; i < this.anthologyPreview2Assets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.anthologyPreview2Assets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("jp" + PBKAAIONJOB.ToString() + "wshcdshc" + this.anthologyPreview2Assets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.anthologyPreview2Assets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.anthologyPreview2Assets.Clear();
			}
			for (int i = 0; i < this.anthologyPreview2AssetsMini.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.anthologyPreview2AssetsMini[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString() + " " + this.anthologyPreview2AssetsMini[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.anthologyPreview2AssetsMini.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.anthologyPreview2AssetsMini.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-98))
		{
			for (int i = 0; i < this.iconsPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.iconsPackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("XXX" + PBKAAIONJOB.ToString() + "nick" + this.iconsPackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.iconsPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.iconsPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)105)
		{
			for (int i = 1; i < this.profilePackAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 0 && this.profilePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("sid" + PBKAAIONJOB.ToString() + "onwishcardclickbody" + this.profilePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.profilePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.profilePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)66)
		{
			for (int i = 0; i < this.liveEventContentAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.liveEventContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("noiseanalog_2" + PBKAAIONJOB.ToString() + "OnStorySplashManagerHideAndCleanCache" + this.liveEventContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.liveEventContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveEventContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
		{
			for (int i = 1; i < this.collectableCardAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.collectableCardAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("env" + PBKAAIONJOB.ToString() + "newrewardsdailywaiting" + this.collectableCardAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.collectableCardAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.collectableCardAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-101))
		{
			for (int i = 1; i < this.liveOfferContentAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.liveOfferContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnStoryChoiceClickConfimed" + PBKAAIONJOB.ToString() + "OnPassesItemClose" + this.liveOfferContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveOfferContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveOfferContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)69)
		{
			for (int i = 0; i < this.sketchThumbnailAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.sketchThumbnailAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH(" not recorded: no cache folder for " + PBKAAIONJOB.ToString() + "p" + this.sketchThumbnailAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sketchThumbnailAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sketchThumbnailAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			for (int i = 1; i < this.sketchActorsAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.sketchActorsAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("pmterror002" + PBKAAIONJOB.ToString() + ", " + this.sketchActorsAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sketchActorsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sketchActorsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)79)
		{
			for (int i = 0; i < this.frameContainerAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && null != this.frameContainerAssets[i] && this.frameContainerAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("OnPromoCodeConsumeSuccess" + PBKAAIONJOB.ToString() + "StorySaveBody.HasAvatarComponentWardrobe(), unsupported wardrobe index:" + ((null != this.frameContainerAssets[i]) ? this.frameContainerAssets[i].index : -1).ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.frameContainerAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.frameContainerAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)83)
		{
			for (int i = 1; i < this.liveProfileThemesAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.liveProfileThemesAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("$EMLOOPSTART" + PBKAAIONJOB.ToString() + "" + this.liveProfileThemesAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveProfileThemesAssets.RemoveAt(i);
						this.liveProfileThemesVersion += 0;
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.liveProfileThemesAssets.Clear();
				this.liveProfileThemesVersion += 0;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStoryAssetPack)
		{
			for (int i = 0; i < this.customEffectsAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.customEffectsAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("Error. GetActiveStory(), activeStory is negative." + PBKAAIONJOB.ToString() + "" + this.customEffectsAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.customEffectsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.customEffectsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)92)
		{
			for (int i = 1; i < this.storyNpcAnimationAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 0 && this.storyNpcAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("_BLEND_ADDITIVE" + PBKAAIONJOB.ToString() + "DontDestroyOnLoad" + this.storyNpcAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.storyNpcAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.storyNpcAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-47))
		{
			for (int i = 1; i < this.storyItemAnimationAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.storyItemAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("sd" + PBKAAIONJOB.ToString() + "" + this.storyItemAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.storyItemAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.storyItemAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-93))
		{
			for (int i = 0; i < this.customFaderAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.customFaderAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("restartseason" + PBKAAIONJOB.ToString() + "" + this.customFaderAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.customFaderAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.customFaderAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			null != this.lobbyDataAsset;
			DPGJIJGOCIC.CMGOAFDBAOH("yes" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStoryAssetPack)
		{
			DPGJIJGOCIC.CMGOAFDBAOH("oid" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset2 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-71))
		{
			null != this.sketchesDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("ffd496" + PBKAAIONJOB.ToString());
			this.sketchesDataAsset = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-86))
		{
			null != this.profileDataAsset3;
			DPGJIJGOCIC.NFIDPOMCNLP("importanttitle" + PBKAAIONJOB.ToString());
			this.profileDataAsset3 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-8))
		{
			null != this.profileDataAsset4;
			DPGJIJGOCIC.CMGOAFDBAOH("saveslotstitle" + PBKAAIONJOB.ToString());
			this.profileDataAsset4 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-27))
		{
			null != this.profileDataAsset5;
			DPGJIJGOCIC.CMGOAFDBAOH("" + PBKAAIONJOB.ToString());
			this.profileDataAsset5 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData2)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString());
			this.profileDataAsset6 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-102))
		{
			null != this.profileDataAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("OnChapterSnapshotsBackendFetchSuccess" + PBKAAIONJOB.ToString());
			this.profileDataAsset2 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-3))
		{
			null != this.profileDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("per" + PBKAAIONJOB.ToString());
			this.profileDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyLounge)
		{
			null != this.profileDataLocalizedAsset;
			DPGJIJGOCIC.CMGOAFDBAOH("per" + PBKAAIONJOB.ToString());
			this.profileDataLocalizedAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCommonPack)
		{
			null != this.headersPackAsset;
			DPGJIJGOCIC.CMGOAFDBAOH("youreceived" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			null != this.headersPackAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("skduplicatecant0" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			for (int i = 0; i < this.avatarPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.avatarPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("BackendOperationsManager.RequestSpinWheel, exception while initializing RSACryptoServiceProvider:" + PBKAAIONJOB.ToString() + "skinshopowned" + this.avatarPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.avatarPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.avatarPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-99))
		{
			for (int i = 1; i < this.keepAlivePackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.keepAlivePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess" + PBKAAIONJOB.ToString() + "<b>" + this.keepAlivePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.keepAlivePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.keepAlivePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-103))
		{
			for (int i = 1; i < this.avatarExtensionPackAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 0 && this.avatarExtensionPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString() + "saveslotsdeletepos" + this.avatarExtensionPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.avatarExtensionPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.avatarExtensionPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			null != this.textPackAsset;
			DPGJIJGOCIC.CMGOAFDBAOH("body" + PBKAAIONJOB.ToString());
			this.textPackAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated1)
		{
			if (null != this.purchasingViewManager)
			{
				this.purchasingViewManager.JBALNAJGKCC(null);
				UnityEngine.Object.Destroy(this.purchasingViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + PBKAAIONJOB.ToString());
				this.purchasingViewManager = null;
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-65))
		{
			if (null != this.cutsceneViewManager)
			{
				this.cutsceneViewManager.EOCNAELDFDN(null);
				UnityEngine.Object.Destroy(this.cutsceneViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("_TVDots" + PBKAAIONJOB.ToString());
				this.cutsceneViewManager = null;
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)60)
		{
			if (null != this.sketchViewManager)
			{
				this.sketchViewManager.SetParent(null);
				UnityEngine.Object.Destroy(this.sketchViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("OnLobbyManInTheMiddleAttackDetected" + PBKAAIONJOB.ToString());
				this.sketchViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleTextPack)
		{
			for (int i = 1; i < this.storySplashManagers.Count; i += 0)
			{
				if (null != this.storySplashManagers[i])
				{
					this.storySplashManagers[i].PABCHDMFOBE(null);
					UnityEngine.Object.Destroy(this.storySplashManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString() + "F1" + i.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.storySplashManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.storySplashManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)83)
		{
			for (int i = 0; i < this.sceneAvatarManagers.Count; i += 0)
			{
				if (null != this.sceneAvatarManagers[i])
				{
					this.sceneAvatarManagers[i].PEHJPPDPLKC(null);
					UnityEngine.Object.Destroy(this.sceneAvatarManagers[i].gameObject);
					DPGJIJGOCIC.CMGOAFDBAOH(", " + PBKAAIONJOB.ToString() + "application/json" + i.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sceneAvatarManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sceneAvatarManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-113))
		{
			for (int i = 0; i < this.sceneLoungeManagers.Count; i++)
			{
				if (null != this.sceneLoungeManagers[i])
				{
					this.sceneLoungeManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.sceneLoungeManagers[i].gameObject);
					DPGJIJGOCIC.CMGOAFDBAOH("errortitle" + PBKAAIONJOB.ToString() + "no" + i.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sceneLoungeManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sceneLoungeManagers.Clear();
			}
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x002BE518 File Offset: 0x002BC718
	public void ForceStopAllOperations()
	{
		NPOILPKELOJ.MOKPIOFAFPE();
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x002C0164 File Offset: 0x002BE364
	private int JCMJOKICOJO()
	{
		if (this.GPKCJNEIHBH)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("abpdl");
			return 0;
		}
		int num;
		if (KHPGPLAMAIN.IBFFFCIPOJC() == IIHCCPLGGHP.highEnd)
		{
			num = this.CAACJIOPDOO;
		}
		else if (KHPGPLAMAIN.AKJOFJPLONG() == IIHCCPLGGHP.midEnd)
		{
			num = this.CAACJIOPDOO / 0;
		}
		else
		{
			num = this.CAACJIOPDOO / 4;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			num /= (int)NPOILPKELOJ.IKDKDPNCJBO;
		}
		if (num < 0)
		{
			num = 1;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			DPGJIJGOCIC.PJCLICBPPDA("mvs" + NPOILPKELOJ.IKDKDPNCJBO.ToString() + "bdgsspr" + num.ToString());
		}
		else
		{
			DPGJIJGOCIC.ADFCDFHBDAF("https://ysi-api.shephertz.com/cloud/" + num.ToString());
		}
		return num;
	}

	// Token: 0x060060A4 RID: 24740 RVA: 0x002C0214 File Offset: 0x002BE414
	private int NAHGADMHGEI()
	{
		if (this.GPKCJNEIHBH)
		{
			DPGJIJGOCIC.PJCLICBPPDA("mypofflinebody");
			return 0;
		}
		int num;
		if (KHPGPLAMAIN.AKJOFJPLONG() == IIHCCPLGGHP.highEnd)
		{
			num = this.CAACJIOPDOO;
		}
		else if (KHPGPLAMAIN.BHIJDBJNAMH() == IIHCCPLGGHP.midEnd)
		{
			num = this.CAACJIOPDOO / 5;
		}
		else
		{
			num = this.CAACJIOPDOO / 6;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			num /= (int)NPOILPKELOJ.IKDKDPNCJBO;
		}
		if (num < 1)
		{
			num = 0;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			DPGJIJGOCIC.PJCLICBPPDA("off" + NPOILPKELOJ.IKDKDPNCJBO.ToString() + "OnApplicationFocusNeedToUpdateCurrency" + num.ToString());
		}
		else
		{
			DPGJIJGOCIC.ADFCDFHBDAF("congratstitle" + num.ToString());
		}
		return num;
	}

	// Token: 0x060060A5 RID: 24741 RVA: 0x002C02C3 File Offset: 0x002BE4C3
	private IEnumerator ADDHENBKOEK(OPMGJPHENFJ OMFEFBJKHJG, NPOILPKELOJ JLDHNMKCIGH, string LBGGLHDOICL, string CEAADJNPKKA)
	{
		this.NJGOLBEFEPJ++;
		DPGJIJGOCIC.NFIDPOMCNLP("assetBundleLoadOperationActiveCoroutines:" + this.NJGOLBEFEPJ.ToString());
		if (JLDHNMKCIGH != null)
		{
			yield return base.StartCoroutine(JLDHNMKCIGH);
		}
		if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.purchasingViewManager = UnityEngine.Object.FindObjectOfType<PurchasingViewManager>();
			this.purchasingViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.purchasingViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.purchasingViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCutsceneView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.cutsceneViewManager = UnityEngine.Object.FindObjectOfType<CutsceneViewManager>();
			this.cutsceneViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.cutsceneViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.cutsceneViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.sketchViewManager = UnityEngine.Object.FindObjectOfType<SketchViewManager>();
			this.sketchViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.sketchViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.sketchViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyReward)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.IEADNMABIID.Add(LBGGLHDOICL);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			StorySplashManager storySplashManager = UnityEngine.Object.FindObjectOfType<StorySplashManager>();
			storySplashManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				storySplashManager.DontDestroyOnLoad();
			}
			this.storySplashManagers.Add(storySplashManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				storySplashManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyAvatar)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			SceneAvatarManager sceneAvatarManager = UnityEngine.Object.FindObjectOfType<SceneAvatarManager>();
			sceneAvatarManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				sceneAvatarManager.DontDestroyOnLoad();
			}
			this.sceneAvatarManagers.Add(sceneAvatarManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				sceneAvatarManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyLounge)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			SceneLoungeManager sceneLoungeManager = UnityEngine.Object.FindObjectOfType<SceneLoungeManager>();
			sceneLoungeManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				sceneLoungeManager.DontDestroyOnLoad();
			}
			this.sceneLoungeManagers.Add(sceneLoungeManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				sceneLoungeManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, type not implemented in ProcessAssetBundleLoadLevelAsyncRequest():" + OMFEFBJKHJG.OBKCKGHFMDN.ToString());
			this.NJGOLBEFEPJ--;
		}
		yield break;
	}

	// Token: 0x060060A6 RID: 24742 RVA: 0x002C02F0 File Offset: 0x002BE4F0
	public void IBMPFCLJINB(string JEOKFNAFILA = null, string IOPJPDKHMDG = null, bool EAGAMDIOMEB = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("rewardtitle");
			return;
		}
		this.KAHJMAHGDFI = KGDFLLFLIPM.Busy;
		this.FCBHOEFELNF("importanttitle");
		this.MPEGJMEEIFA = JEOKFNAFILA;
		this.IDHIPDNNLIN = IOPJPDKHMDG;
		NPOILPKELOJ.DAEOMOJFKDN = true;
		this.EGLPBAJMOHJ = false;
		this.IOOFABBLGKE = EAGAMDIOMEB;
		this.ODDNKAMKHDA = DPGJIJGOCIC.MKJLJPMEPCC();
		base.StartCoroutine(this.IMBNBDMAEIP());
	}

	// Token: 0x060060A7 RID: 24743 RVA: 0x002C0360 File Offset: 0x002BE560
	private void IKFBOPOAJNL()
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i += 0)
		{
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI._deprecated2)
			{
				AssetBundleManager.IOKDHECGLON(OMIMIKMIMFE.BMKNIIPEBKO(NMKDCBPMCKI.AssetBundleStory, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1), this.MFPCGBNKHCC[i].AMJBNEILEKN);
			}
		}
	}

	// Token: 0x060060A8 RID: 24744 RVA: 0x002BD119 File Offset: 0x002BB319
	public void OEIDIFFMKJB()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060A9 RID: 24745 RVA: 0x002BE52E File Offset: 0x002BC72E
	private IEnumerator AFPOIEJOBIH(string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		NPOILPKELOJ.LKNKIODCMFJ();
		this.DLFNGJILCEH = JLINKDNLADM.Progress;
		if (!AssetBundleManager.ManifestInitialized((int)this.GOBDKBEIPMC))
		{
			IEnumerator enumerator = AssetBundleManager.Initialize(this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC);
			if (enumerator != null)
			{
				yield return base.StartCoroutine(enumerator);
			}
			PLOGDOACBMK assetBundleLoadManifestOperation = AssetBundleManager.GetAssetBundleLoadManifestOperation();
			requestSucceeded = false;
			requestSucceeded = (assetBundleLoadManifestOperation != null && !assetBundleLoadManifestOperation.HJOPIMGMGML());
			AssetBundleManager.ResetAssetBundleLoadManifestOperation();
			yield return new WaitForEndOfFrame();
			this.CFEJAMGNPAC("folder init done, cleaning failed cache entries: " + AssetBundleManager.DescribeDownloadingErrors());
			AssetBundleManager.CleanFailedAssetBundleCache();
			if (!requestSucceeded)
			{
				if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
					this.BLHLMFJOCFP();
				}
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.MGHGEJLBBIH();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(KLCOCBODJAF, 0f);
			}
			else
			{
				this.DLFNGJILCEH = JLINKDNLADM.Success;
				this.MGHGEJLBBIH();
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(PLDNHKIKDIB, 0f);
			}
		}
		else
		{
			yield return new WaitForEndOfFrame();
			this.DLFNGJILCEH = JLINKDNLADM.Success;
			this.MGHGEJLBBIH();
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(PLDNHKIKDIB, 0f);
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		yield break;
	}

	// Token: 0x060060AA RID: 24746 RVA: 0x002C03D6 File Offset: 0x002BE5D6
	private IEnumerator ACPBBNOKOGK()
	{
		if (!this.AKCDHJCIJCG)
		{
			NPOILPKELOJ.LKNKIODCMFJ();
			this.POOGGCLFKMI = true;
			for (int i = 0; i < 50; i++)
			{
				this.DestroyAssetBundleAssets((NMKDCBPMCKI)i, -1);
			}
			this.UnloadPersistentAssetBundles();
			AssetBundleManager.UnloadAllAssetBundles();
			if (this.OOKEOHFPOKN)
			{
				AssetBundle.UnloadAllAssetBundles(true);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancachebody"), DFGILFBGPLN.popupTools, 0f, 28);
				yield return new WaitForSeconds(1f);
				Caching.ClearCache();
				yield return new WaitForSeconds(1f);
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				this.OOKEOHFPOKN = false;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.GMADGCBOAJF), new UnityAction(this.GMADGCBOAJF), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				yield return new WaitForSeconds(31536000f);
			}
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		this.BKKBJOOOEBO = true;
		if (this.OKMBMHIKIBC.Length != 0)
		{
			AssetBundleManager.SetSourceAssetBundleURL(this.OKMBMHIKIBC, DPGJIJGOCIC.POHBFGLLKFD(this.CLBECEDIAAB));
			if (NPOILPKELOJ.MMANKOLKKMG)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeout.ToString(), "", false, false);
				NPOILPKELOJ.MMANKOLKKMG = false;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeoutRetry.ToString(), NPOILPKELOJ.BGPKAOFOHHB.ToString() ?? "", false, false);
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("commonbundlehint"), DFGILFBGPLN.popupTools, 0f, 28);
				}
			}
			IEnumerator enumerator = AssetBundleManager.Initialize(LNDOOJOFFOM.Common.ToString(), 0);
			if (enumerator != null)
			{
				yield return base.StartCoroutine(enumerator);
			}
			PLOGDOACBMK assetBundleLoadManifestOperation = AssetBundleManager.GetAssetBundleLoadManifestOperation();
			if (assetBundleLoadManifestOperation == null || assetBundleLoadManifestOperation.HJOPIMGMGML())
			{
				this.AKCDHJCIJCG = false;
				if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
					this.BLHLMFJOCFP();
				}
			}
			else
			{
				this.AKCDHJCIJCG = true;
			}
			AssetBundleManager.ResetAssetBundleLoadManifestOperation();
			this.BKKBJOOOEBO = false;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			yield break;
		}
		this.AKCDHJCIJCG = false;
		this.BKKBJOOOEBO = false;
		yield break;
	}

	// Token: 0x060060AB RID: 24747 RVA: 0x002C03E8 File Offset: 0x002BE5E8
	private void BLHLMFJOCFP()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
		{
			if (this.LEOFIDDNKAF.IsBusy())
			{
				if (!this.LEOFIDDNKAF.IsBusyBatch() && !this.LEOFIDDNKAF.IsReady())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("AssetsManager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()");
					this.LEOFIDDNKAF.ContinuePing(KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB);
					return;
				}
			}
			else if (!this.LEOFIDDNKAF.IsReady())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("AssetsManager.UpdateUrlPingManagerState(): urlPingManager.StartPing()");
				this.LEOFIDDNKAF.StartPing(this.DGAICDDKDGJ, KBOJLHAJPCP.FDLNHBCAABL, KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB, KBOJLHAJPCP.COLJLNNOMGL);
			}
		}
	}

	// Token: 0x060060AC RID: 24748 RVA: 0x002C0498 File Offset: 0x002BE698
	public void QueueLobbyData2Bundle()
	{
		this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleLobbyData2, 0, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
	}

	// Token: 0x060060AD RID: 24749 RVA: 0x002C04C0 File Offset: 0x002BE6C0
	private bool FKHJIMFBFGK(OPMGJPHENFJ BBHLOECBJJN)
	{
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i++)
		{
			if (this.MFPCGBNKHCC[i].HOOEDAAGDGJ(BBHLOECBJJN))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060060AE RID: 24750 RVA: 0x002BE316 File Offset: 0x002BC516
	public JLINKDNLADM OGIEGBICMPH()
	{
		return this.DLFNGJILCEH;
	}

	// Token: 0x060060AF RID: 24751 RVA: 0x002C04FA File Offset: 0x002BE6FA
	public bool AssetBundleManagerHasBeenReset()
	{
		return this.POOGGCLFKMI;
	}

	// Token: 0x060060B0 RID: 24752 RVA: 0x002C0502 File Offset: 0x002BE702
	public void SetDirty()
	{
		this.AKCDHJCIJCG = false;
		this.POOGGCLFKMI = true;
	}

	// Token: 0x060060B1 RID: 24753 RVA: 0x002C0514 File Offset: 0x002BE714
	private bool AOGGAGNIOFF(OPMGJPHENFJ BBHLOECBJJN)
	{
		for (int i = 1; i < this.MFPCGBNKHCC.Count; i++)
		{
			if (this.MFPCGBNKHCC[i].MDCHFNJHJBF(BBHLOECBJJN))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060060B2 RID: 24754 RVA: 0x002C0550 File Offset: 0x002BE750
	private void HJNNIBFBAEF()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()))
		{
			if (this.LEOFIDDNKAF.BGBEOKALKPC())
			{
				if (!this.LEOFIDDNKAF.HDFGOLFJDMJ() && !this.LEOFIDDNKAF.IsReady())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("ironsource");
					this.LEOFIDDNKAF.ContinuePing(KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB);
					return;
				}
			}
			else if (!this.LEOFIDDNKAF.JKBBNHLFFLP())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("OnBackendValidateTransactionFailed");
				this.LEOFIDDNKAF.ICDLHBIBHII(this.DGAICDDKDGJ, KBOJLHAJPCP.FDLNHBCAABL, KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB, KBOJLHAJPCP.COLJLNNOMGL);
			}
		}
	}

	// Token: 0x060060B3 RID: 24755 RVA: 0x002BD444 File Offset: 0x002BB644
	public void SetCacheDirty()
	{
		this.OOKEOHFPOKN = true;
	}

	// Token: 0x060060B4 RID: 24756 RVA: 0x002C0600 File Offset: 0x002BE800
	public void EOCDHCDCNAA(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP)
	{
		try
		{
			if (!(null == JFCABBGNNKJ) && JFCABBGNNKJ.chapterAssetPacks != null && OLKMHHNMDLP >= 1 && OLKMHHNMDLP < JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.JLNEAJBNHAK())
					{
						if (!KHPGPLAMAIN.EJCNHEBIOJF())
						{
							if (KHPGPLAMAIN.AKJOFJPLONG() != IIHCCPLGGHP.lowEnd)
							{
								for (int i = 1; i < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks.Count; i += 0)
								{
									if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i] < 0)
									{
										DPGJIJGOCIC.ADFCDFHBDAF("body" + JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i].ToString());
									}
									else
									{
										this.QueueAssetBundleDownload((NMKDCBPMCKI)(-43), JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].itemAnimationPacks[i], -1, FLDBFOADFLH.finishDownloadAndProceed, false, true, true, null, -1, true, "acliffbw22", true, true);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060060B5 RID: 24757 RVA: 0x002C0740 File Offset: 0x002BE940
	private string KDPNMFNIKFO(string MNOCEFGMBHK)
	{
		try
		{
			int num = 0;
			for (int i = MNOCEFGMBHK.Length - 1; i >= 0; i--)
			{
				if (MNOCEFGMBHK[i] == '/')
				{
					num++;
				}
				if (num == 2)
				{
					return MNOCEFGMBHK.Substring(i).Replace("/", "");
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return "";
	}

	// Token: 0x060060B6 RID: 24758 RVA: 0x002C07B0 File Offset: 0x002BE9B0
	public static void EOOKOALKDCA(string LBGGLHDOICL)
	{
		AssetBundleManager.KPFHEEBNOED(LBGGLHDOICL);
	}

	// Token: 0x060060B7 RID: 24759 RVA: 0x002C07B8 File Offset: 0x002BE9B8
	public void SetMaxNumberOfParallelDownloads(int CMBCNMLGPPC)
	{
		this.CAACJIOPDOO = CMBCNMLGPPC;
	}

	// Token: 0x060060B8 RID: 24760 RVA: 0x002C07C1 File Offset: 0x002BE9C1
	private IEnumerator JHBLEEJPJIF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.LEOFIDDNKAF = base.GetComponent<UrlPingManager>();
		yield return base.StartCoroutine(this.KNPIMINGDEA());
		yield break;
	}

	// Token: 0x060060B9 RID: 24761 RVA: 0x002BD67E File Offset: 0x002BB87E
	public void AMBKFIKBAHP(LNDOOJOFFOM ODGGFGGKPIG, string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		this.GOBDKBEIPMC = ODGGFGGKPIG;
		AssetBundleManager.SetFolderIndexHint((int)this.GOBDKBEIPMC);
		base.StartCoroutine(this.AFPOIEJOBIH(PLDNHKIKDIB, KLCOCBODJAF));
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x002C07D0 File Offset: 0x002BE9D0
	public StorySplashManager GetStorySplashManager(int MEFKFOHCOHK)
	{
		if (this.storySplashManagers.Count > MEFKFOHCOHK)
		{
			return this.storySplashManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x002C07EE File Offset: 0x002BE9EE
	private IEnumerator NCIDHBJFIBB(OPMGJPHENFJ OMFEFBJKHJG, DAJHCGFBHMO JLDHNMKCIGH, string LBGGLHDOICL)
	{
		AssetsManager.PPFBFNCFILN ppfbfncfiln = new AssetsManager.PPFBFNCFILN(1);
		ppfbfncfiln.<>4__this = this;
		ppfbfncfiln._operation = OMFEFBJKHJG;
		ppfbfncfiln._request = JLDHNMKCIGH;
		ppfbfncfiln._assetBundleName = LBGGLHDOICL;
		return ppfbfncfiln;
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x002C0814 File Offset: 0x002BEA14
	public void NCKOHOBCLIE(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP)
	{
		try
		{
			if (!(null == JFCABBGNNKJ) && JFCABBGNNKJ.chapterAssetPacks != null && OLKMHHNMDLP >= 0 && OLKMHHNMDLP < JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.FNMKCHCBLLF())
					{
						if (!KHPGPLAMAIN.KPIFAEEPHPH())
						{
							if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.lowEnd)
							{
								for (int i = 0; i < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks.Count; i += 0)
								{
									if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i] < 0)
									{
										DPGJIJGOCIC.PJCLICBPPDA("acliffbw20" + JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i].ToString());
									}
									else
									{
										this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleSketchesData, JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i], -1, FLDBFOADFLH.finishDownloadAndProceed, true, false, false, null, -1, false, "", false, false);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x002BD660 File Offset: 0x002BB860
	public SceneLoungeManager GetSceneLoungeManager(int MEFKFOHCOHK)
	{
		if (this.sceneLoungeManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneLoungeManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060BE RID: 24766 RVA: 0x002BE140 File Offset: 0x002BC340
	public UrlPingManager OPDCNNILKDB()
	{
		return this.LEOFIDDNKAF;
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x002C0954 File Offset: 0x002BEB54
	public void DestroyAssetBundleAssets(NMKDCBPMCKI PBKAAIONJOB, int OIGJAFGFIGP = -1)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
		{
			for (int i = 0; i < this.anthologyPreview2Assets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.anthologyPreview2Assets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.anthologyPreview2Assets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.anthologyPreview2Assets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.anthologyPreview2Assets.Clear();
			}
			for (int i = 0; i < this.anthologyPreview2AssetsMini.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.anthologyPreview2AssetsMini[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.anthologyPreview2AssetsMini[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.anthologyPreview2AssetsMini.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.anthologyPreview2AssetsMini.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleIconsPack)
		{
			for (int i = 0; i < this.iconsPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.iconsPackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.iconsPackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.iconsPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.iconsPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfilePack)
		{
			for (int i = 0; i < this.profilePackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.profilePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.profilePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.profilePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.profilePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			for (int i = 0; i < this.liveEventContentAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.liveEventContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.liveEventContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveEventContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveEventContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCollectableCard)
		{
			for (int i = 0; i < this.collectableCardAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.collectableCardAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.collectableCardAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.collectableCardAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.collectableCardAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveOfferContent)
		{
			for (int i = 0; i < this.liveOfferContentAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.liveOfferContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.liveOfferContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveOfferContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveOfferContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchThumbnail)
		{
			for (int i = 0; i < this.sketchThumbnailAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.sketchThumbnailAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.sketchThumbnailAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sketchThumbnailAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sketchThumbnailAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchActors)
		{
			for (int i = 0; i < this.sketchActorsAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.sketchActorsAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.sketchActorsAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sketchActorsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sketchActorsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleFrameContainer)
		{
			for (int i = 0; i < this.frameContainerAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && null != this.frameContainerAssets[i] && this.frameContainerAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + ((null != this.frameContainerAssets[i]) ? this.frameContainerAssets[i].index : -1).ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.frameContainerAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.frameContainerAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveProfileTheme)
		{
			for (int i = 0; i < this.liveProfileThemesAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.liveProfileThemesAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.liveProfileThemesAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveProfileThemesAssets.RemoveAt(i);
						this.liveProfileThemesVersion++;
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveProfileThemesAssets.Clear();
				this.liveProfileThemesVersion++;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCustomEffects)
		{
			for (int i = 0; i < this.customEffectsAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.customEffectsAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.customEffectsAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.customEffectsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.customEffectsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			for (int i = 0; i < this.storyNpcAnimationAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.storyNpcAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.storyNpcAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.storyNpcAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.storyNpcAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			for (int i = 0; i < this.storyItemAnimationAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.storyItemAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.storyItemAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.storyItemAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.storyItemAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCustomFader)
		{
			for (int i = 0; i < this.customFaderAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.customFaderAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.customFaderAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.customFaderAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.customFaderAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLobbyData)
		{
			null != this.lobbyDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLobbyData2)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchesData)
		{
			null != this.sketchesDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.sketchesDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData3)
		{
			null != this.profileDataAsset3;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset3 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData4)
		{
			null != this.profileDataAsset4;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset4 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			null != this.profileDataAsset5;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset5 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData6)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset6 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData2)
		{
			null != this.profileDataAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData)
		{
			null != this.profileDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileDataLocalized)
		{
			null != this.profileDataLocalizedAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.profileDataLocalizedAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleHeadersPack)
		{
			null != this.headersPackAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleHeadersPack2)
		{
			null != this.headersPackAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			for (int i = 0; i < this.avatarPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.avatarPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.avatarPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.avatarPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.avatarPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleKeepAlivePack)
		{
			for (int i = 0; i < this.keepAlivePackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.keepAlivePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.keepAlivePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.keepAlivePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.keepAlivePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
		{
			for (int i = 0; i < this.avatarExtensionPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.avatarExtensionPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + this.avatarExtensionPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.avatarExtensionPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.avatarExtensionPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleTextPack)
		{
			null != this.textPackAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
			this.textPackAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			if (null != this.purchasingViewManager)
			{
				this.purchasingViewManager.SetParent(null);
				UnityEngine.Object.Destroy(this.purchasingViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
				this.purchasingViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCutsceneView)
		{
			if (null != this.cutsceneViewManager)
			{
				this.cutsceneViewManager.SetParent(null);
				UnityEngine.Object.Destroy(this.cutsceneViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
				this.cutsceneViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchView)
		{
			if (null != this.sketchViewManager)
			{
				this.sketchViewManager.SetParent(null);
				UnityEngine.Object.Destroy(this.sketchViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString());
				this.sketchViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			for (int i = 0; i < this.storySplashManagers.Count; i++)
			{
				if (null != this.storySplashManagers[i])
				{
					this.storySplashManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.storySplashManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + i.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.storySplashManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.storySplashManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyAvatar)
		{
			for (int i = 0; i < this.sceneAvatarManagers.Count; i++)
			{
				if (null != this.sceneAvatarManagers[i])
				{
					this.sceneAvatarManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.sceneAvatarManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + i.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sceneAvatarManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sceneAvatarManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyLounge)
		{
			for (int i = 0; i < this.sceneLoungeManagers.Count; i++)
			{
				if (null != this.sceneLoungeManagers[i])
				{
					this.sceneLoungeManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.sceneLoungeManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle assets destroyed:" + PBKAAIONJOB.ToString() + ", index:" + i.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sceneLoungeManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.sceneLoungeManagers.Clear();
			}
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x002BD119 File Offset: 0x002BB319
	public void FNMJENGENBH()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x002BD119 File Offset: 0x002BB319
	public void MBELPNIGLKN()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x002C1AAC File Offset: 0x002BFCAC
	public void FJNNMGFLBKA(NMKDCBPMCKI PBKAAIONJOB, int OIGJAFGFIGP = -1)
	{
		if (PBKAAIONJOB == (NMKDCBPMCKI)(-93))
		{
			for (int i = 1; i < this.anthologyPreview2Assets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.anthologyPreview2Assets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("' has no category, skipped" + PBKAAIONJOB.ToString() + "abpd6" + this.anthologyPreview2Assets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.anthologyPreview2Assets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.anthologyPreview2Assets.Clear();
			}
			for (int i = 1; i < this.anthologyPreview2AssetsMini.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.anthologyPreview2AssetsMini[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("free" + PBKAAIONJOB.ToString() + "gptompatchestutorial" + this.anthologyPreview2AssetsMini[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.anthologyPreview2AssetsMini.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.anthologyPreview2AssetsMini.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated1)
		{
			for (int i = 1; i < this.iconsPackAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.iconsPackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("abld" + PBKAAIONJOB.ToString() + "aspksk" + this.iconsPackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.iconsPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.iconsPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.Count)
		{
			for (int i = 0; i < this.profilePackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.profilePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("pid" + PBKAAIONJOB.ToString() + "socialprofilesuspcantuse" + this.profilePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.profilePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.profilePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)115)
		{
			for (int i = 0; i < this.liveEventContentAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.liveEventContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnRewardsItemClose" + PBKAAIONJOB.ToString() + "OnAccountSignInRequestSuccess" + this.liveEventContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.liveEventContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.liveEventContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)69)
		{
			for (int i = 0; i < this.collectableCardAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.collectableCardAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("OnStoryCurrencyInfoClick" + PBKAAIONJOB.ToString() + "sfxtimeoutwarning" + this.collectableCardAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.collectableCardAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.collectableCardAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			for (int i = 0; i < this.liveOfferContentAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.liveOfferContentAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("analogglitch" + PBKAAIONJOB.ToString() + "credo" + this.liveOfferContentAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.liveOfferContentAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.liveOfferContentAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)98)
		{
			for (int i = 1; i < this.sketchThumbnailAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.sketchThumbnailAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("OnAvatarScreenAssetsDownloadSuccess" + PBKAAIONJOB.ToString() + "yes" + this.sketchThumbnailAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sketchThumbnailAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.sketchThumbnailAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-87))
		{
			for (int i = 0; i < this.sketchActorsAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.sketchActorsAssets[i].sketchId == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("loungegempassbody" + PBKAAIONJOB.ToString() + "AVATAR.CLIENT.TRINKET" + this.sketchActorsAssets[i].sketchId.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sketchActorsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.sketchActorsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)127)
		{
			for (int i = 0; i < this.frameContainerAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && null != this.frameContainerAssets[i] && this.frameContainerAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("</align>" + PBKAAIONJOB.ToString() + "OnLobbyManInTheMiddleAttackDetected" + ((null != this.frameContainerAssets[i]) ? this.frameContainerAssets[i].index : -1).ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.frameContainerAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.frameContainerAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleHeadersPack2)
		{
			for (int i = 0; i < this.liveProfileThemesAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.liveProfileThemesAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("nastring" + PBKAAIONJOB.ToString() + "OnLiveProfileThemeDownloadFailed" + this.liveProfileThemesAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.liveProfileThemesAssets.RemoveAt(i);
						this.liveProfileThemesVersion += 0;
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.liveProfileThemesAssets.Clear();
				this.liveProfileThemesVersion++;
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-29))
		{
			for (int i = 1; i < this.customEffectsAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.customEffectsAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString() + " already being downloaded, skip request but remember reference to it." + this.customEffectsAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.customEffectsAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.customEffectsAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-43))
		{
			for (int i = 0; i < this.storyNpcAnimationAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.storyNpcAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("" + PBKAAIONJOB.ToString() + "OnEmailSubscribeException" + this.storyNpcAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.storyNpcAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.storyNpcAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-30))
		{
			for (int i = 1; i < this.storyItemAnimationAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 0 && this.storyItemAnimationAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP(" candidates " + PBKAAIONJOB.ToString() + "myprofilelimitation" + this.storyItemAnimationAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.storyItemAnimationAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.storyItemAnimationAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)62)
		{
			for (int i = 0; i < this.customFaderAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 0 && this.customFaderAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("countryCode" + PBKAAIONJOB.ToString() + "_Steps" + this.customFaderAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.customFaderAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.customFaderAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-98))
		{
			null != this.lobbyDataAsset;
			DPGJIJGOCIC.CMGOAFDBAOH(" smallItems=" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI._deprecated3)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("minCompletedChapters" + PBKAAIONJOB.ToString());
			this.lobbyDataAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData3)
		{
			null != this.sketchesDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("apks2" + PBKAAIONJOB.ToString());
			this.sketchesDataAsset = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-37))
		{
			null != this.profileDataAsset3;
			DPGJIJGOCIC.NFIDPOMCNLP(" (- )</i>" + PBKAAIONJOB.ToString());
			this.profileDataAsset3 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)60)
		{
			null != this.profileDataAsset4;
			DPGJIJGOCIC.CMGOAFDBAOH("CCC" + PBKAAIONJOB.ToString());
			this.profileDataAsset4 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-90))
		{
			null != this.profileDataAsset5;
			DPGJIJGOCIC.CMGOAFDBAOH("AdsManagerLP: ShowAdRewarded() called" + PBKAAIONJOB.ToString());
			this.profileDataAsset5 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-71))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("OnFacebookLoginCanceled" + PBKAAIONJOB.ToString());
			this.profileDataAsset6 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)126)
		{
			null != this.profileDataAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString());
			this.profileDataAsset2 = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)93)
		{
			null != this.profileDataAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("<" + PBKAAIONJOB.ToString());
			this.profileDataAsset = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-82))
		{
			null != this.profileDataLocalizedAsset;
			DPGJIJGOCIC.CMGOAFDBAOH(" releasing " + PBKAAIONJOB.ToString());
			this.profileDataLocalizedAsset = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-60))
		{
			null != this.headersPackAsset;
			DPGJIJGOCIC.CMGOAFDBAOH(" expected ('" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset = null;
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-126))
		{
			null != this.headersPackAsset2;
			DPGJIJGOCIC.NFIDPOMCNLP("XXX" + PBKAAIONJOB.ToString());
			this.storyHeaderAssets.Clear();
			this.anthologyAssets.Clear();
			this.headersPackAsset2 = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			for (int i = 1; i < this.avatarPackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 1 && this.avatarPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("tradewishcardoption1" + PBKAAIONJOB.ToString() + "VideoGlitches.VideoGlitch" + this.avatarPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.avatarPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.avatarPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLobbyData)
		{
			for (int i = 1; i < this.keepAlivePackAssets.Count; i++)
			{
				if (OIGJAFGFIGP < 0 || (OIGJAFGFIGP >= 1 && this.keepAlivePackAssets[i].index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.CMGOAFDBAOH("" + PBKAAIONJOB.ToString() + "OnGetCdnDataBeforeOnDemandException" + this.keepAlivePackAssets[i].index.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.keepAlivePackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.keepAlivePackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)127)
		{
			for (int i = 1; i < this.avatarExtensionPackAssets.Count; i += 0)
			{
				if (OIGJAFGFIGP < 1 || (OIGJAFGFIGP >= 0 && this.avatarExtensionPackAssets[i].header.index == OIGJAFGFIGP))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("lititle" + PBKAAIONJOB.ToString() + "SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Break, AssetsManagerUtils.AllAssetAnthologyPreview2LowAssetsLoaded() is true!" + this.avatarExtensionPackAssets[i].header.index.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.avatarExtensionPackAssets.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 0)
			{
				this.avatarExtensionPackAssets.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleTextPack)
		{
			null != this.textPackAsset;
			DPGJIJGOCIC.NFIDPOMCNLP("" + PBKAAIONJOB.ToString());
			this.textPackAsset = null;
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			if (null != this.purchasingViewManager)
			{
				this.purchasingViewManager.KJEKPMIMPNC(null);
				UnityEngine.Object.Destroy(this.purchasingViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP("KKK" + PBKAAIONJOB.ToString());
				this.purchasingViewManager = null;
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-18))
		{
			if (null != this.cutsceneViewManager)
			{
				this.cutsceneViewManager.HNKHBDLFFEJ(null);
				UnityEngine.Object.Destroy(this.cutsceneViewManager.gameObject);
				DPGJIJGOCIC.NFIDPOMCNLP(" could not be loaded from the cache" + PBKAAIONJOB.ToString());
				this.cutsceneViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
		{
			if (null != this.sketchViewManager)
			{
				this.sketchViewManager.SetParent(null);
				UnityEngine.Object.Destroy(this.sketchViewManager.gameObject);
				DPGJIJGOCIC.CMGOAFDBAOH(" (http " + PBKAAIONJOB.ToString());
				this.sketchViewManager = null;
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStoryAssetPack)
		{
			for (int i = 0; i < this.storySplashManagers.Count; i++)
			{
				if (null != this.storySplashManagers[i])
				{
					this.storySplashManagers[i].ILLFKCLPBBH(null);
					UnityEngine.Object.Destroy(this.storySplashManagers[i].gameObject);
					DPGJIJGOCIC.CMGOAFDBAOH("Error. ZoomSrc(), environment " + PBKAAIONJOB.ToString() + "avtssnap1" + i.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.storySplashManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.storySplashManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.Variant)
		{
			for (int i = 0; i < this.sceneAvatarManagers.Count; i++)
			{
				if (null != this.sceneAvatarManagers[i])
				{
					this.sceneAvatarManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.sceneAvatarManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP(" (- )</i>" + PBKAAIONJOB.ToString() + "XXX" + i.ToString());
					if (OIGJAFGFIGP >= 0)
					{
						this.sceneAvatarManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.sceneAvatarManagers.Clear();
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-1))
		{
			for (int i = 0; i < this.sceneLoungeManagers.Count; i += 0)
			{
				if (null != this.sceneLoungeManagers[i])
				{
					this.sceneLoungeManagers[i].SetParent(null);
					UnityEngine.Object.Destroy(this.sceneLoungeManagers[i].gameObject);
					DPGJIJGOCIC.NFIDPOMCNLP("msh" + PBKAAIONJOB.ToString() + "h" + i.ToString());
					if (OIGJAFGFIGP >= 1)
					{
						this.sceneLoungeManagers.RemoveAt(i);
						break;
					}
				}
			}
			if (OIGJAFGFIGP < 1)
			{
				this.sceneLoungeManagers.Clear();
			}
		}
		AssetBundleManager.MLECPLAPNPH();
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x002C03D6 File Offset: 0x002BE5D6
	private IEnumerator IKGJAKAEOMG()
	{
		if (!this.AKCDHJCIJCG)
		{
			NPOILPKELOJ.LKNKIODCMFJ();
			this.POOGGCLFKMI = true;
			for (int i = 0; i < 50; i++)
			{
				this.DestroyAssetBundleAssets((NMKDCBPMCKI)i, -1);
			}
			this.UnloadPersistentAssetBundles();
			AssetBundleManager.UnloadAllAssetBundles();
			if (this.OOKEOHFPOKN)
			{
				AssetBundle.UnloadAllAssetBundles(true);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancachebody"), DFGILFBGPLN.popupTools, 0f, 28);
				yield return new WaitForSeconds(1f);
				Caching.ClearCache();
				yield return new WaitForSeconds(1f);
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				this.OOKEOHFPOKN = false;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.GMADGCBOAJF), new UnityAction(this.GMADGCBOAJF), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				yield return new WaitForSeconds(31536000f);
			}
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		this.BKKBJOOOEBO = true;
		if (this.OKMBMHIKIBC.Length != 0)
		{
			AssetBundleManager.SetSourceAssetBundleURL(this.OKMBMHIKIBC, DPGJIJGOCIC.POHBFGLLKFD(this.CLBECEDIAAB));
			if (NPOILPKELOJ.MMANKOLKKMG)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeout.ToString(), "", false, false);
				NPOILPKELOJ.MMANKOLKKMG = false;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeoutRetry.ToString(), NPOILPKELOJ.BGPKAOFOHHB.ToString() ?? "", false, false);
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("commonbundlehint"), DFGILFBGPLN.popupTools, 0f, 28);
				}
			}
			IEnumerator enumerator = AssetBundleManager.Initialize(LNDOOJOFFOM.Common.ToString(), 0);
			if (enumerator != null)
			{
				yield return base.StartCoroutine(enumerator);
			}
			PLOGDOACBMK assetBundleLoadManifestOperation = AssetBundleManager.GetAssetBundleLoadManifestOperation();
			if (assetBundleLoadManifestOperation == null || assetBundleLoadManifestOperation.HJOPIMGMGML())
			{
				this.AKCDHJCIJCG = false;
				if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
					this.BLHLMFJOCFP();
				}
			}
			else
			{
				this.AKCDHJCIJCG = true;
			}
			AssetBundleManager.ResetAssetBundleLoadManifestOperation();
			this.BKKBJOOOEBO = false;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			yield break;
		}
		this.AKCDHJCIJCG = false;
		this.BKKBJOOOEBO = false;
		yield break;
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x002BEC00 File Offset: 0x002BCE00
	public static bool BOAFMJDAIPC()
	{
		if (null == AssetsManager.IKLAPGJDMNA)
		{
			AssetsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AssetsManager)) as AssetsManager);
		}
		return AssetsManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x002C2C04 File Offset: 0x002C0E04
	public void QueueLiveProfileThumbnailsBundle()
	{
		this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData6, 0, -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x002C2C29 File Offset: 0x002C0E29
	public ICBGGEGIPPB GetLoadingProgressSnapshot()
	{
		return this.FPKDPDLNDKH;
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x002BD660 File Offset: 0x002BB860
	public SceneLoungeManager NLIGMAHPLKO(int MEFKFOHCOHK)
	{
		if (this.sceneLoungeManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneLoungeManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x002BD660 File Offset: 0x002BB860
	public SceneLoungeManager LDBGAINDLBG(int MEFKFOHCOHK)
	{
		if (this.sceneLoungeManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneLoungeManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x002BD119 File Offset: 0x002BB319
	public void KHNHDFILGLO()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x002C2C31 File Offset: 0x002C0E31
	public bool CacheCleanScheduled()
	{
		return !this.AKCDHJCIJCG && this.OOKEOHFPOKN;
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x002BEBF0 File Offset: 0x002BCDF0
	public PurchasingViewManager GetPurchasingViewManager()
	{
		return this.purchasingViewManager;
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x002C2C43 File Offset: 0x002C0E43
	private IEnumerator IEGIAKGGCIG()
	{
		AssetsManager.GDELPKNPMJC gdelpknpmjc = new AssetsManager.GDELPKNPMJC(1);
		gdelpknpmjc.<>4__this = this;
		return gdelpknpmjc;
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x002C07B8 File Offset: 0x002BE9B8
	public void ELMMNGFPGKE(int CMBCNMLGPPC)
	{
		this.CAACJIOPDOO = CMBCNMLGPPC;
	}

	// Token: 0x060060CE RID: 24782 RVA: 0x002C2C52 File Offset: 0x002C0E52
	private IEnumerator INDDODANPNB()
	{
		AssetsManager.BLKMLBLKHCC blkmlblkhcc = new AssetsManager.BLKMLBLKHCC(1);
		blkmlblkhcc.<>4__this = this;
		return blkmlblkhcc;
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x002C2C64 File Offset: 0x002C0E64
	public void HPIKAFDNPNC(string MNOCEFGMBHK, JSONArray FDILGIMHNBJ)
	{
		if (GeoLocationManager.JMHEAEKIGOC(LanguageManager.EHBBFMCILPC.MLOLBFBODHD()))
		{
			if (DPGJIJGOCIC.DLEEHLGNCOD(MNOCEFGMBHK, this.DGAICDDKDGJ) && (this.LEOFIDDNKAF.FMHDFLCCEJM() || (this.LEOFIDDNKAF.IsReady() && !this.LEOFIDDNKAF.EIOKMGIKPOF(MNOCEFGMBHK))))
			{
				MNOCEFGMBHK = this.LEOFIDDNKAF.LKHCPGCDICO(this.DGAICDDKDGJ) + this.KDPNMFNIKFO(MNOCEFGMBHK) + "";
				DPGJIJGOCIC.CMGOAFDBAOH("ok" + MNOCEFGMBHK);
			}
			this.HJNNIBFBAEF();
		}
		if (!this.OKMBMHIKIBC.Equals(MNOCEFGMBHK) || !this.CLBECEDIAAB.ToString().Equals(FDILGIMHNBJ.ToString()))
		{
			this.JNDGOONNLIA++;
			this.POOGGCLFKMI = false;
			if (this.OKMBMHIKIBC.Length > 0)
			{
				this.SetDirty();
			}
			DPGJIJGOCIC.NFIDPOMCNLP("congratstitle" + MNOCEFGMBHK);
			DPGJIJGOCIC.CMGOAFDBAOH("," + FDILGIMHNBJ.ToString());
		}
		this.OKMBMHIKIBC = MNOCEFGMBHK;
		try
		{
			AssetsManager.cdnDepotForAnalytics = this.OKMBMHIKIBC;
			if (AssetsManager.cdnDepotForAnalytics.Length > 1 && AssetsManager.cdnDepotForAnalytics.Contains("p"))
			{
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Substring(0, AssetsManager.cdnDepotForAnalytics.LastIndexOf("$EMLOOPSTART"));
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("npcp", "story");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("", "apkshe");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("no", "Lobby data 2 bundle loaded but its asset is missing or mis-named:");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("", "OnBackendRequestCollectGiftException");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("OnPopupStoryRestartManagerRestartStory0", "");
				AssetsManager.cdnDepotForAnalytics = AssetsManager.cdnDepotForAnalytics.Replace("", "errortitle");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.CLBECEDIAAB = FDILGIMHNBJ;
		PopupSettingsManager.cdnDepot = MNOCEFGMBHK;
		if (PopupSettingsManager.cdnDepot.EndsWith("+"))
		{
			PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(0, PopupSettingsManager.cdnDepot.Length - 0);
			if (PopupSettingsManager.cdnDepot.Contains("importanttitle"))
			{
				PopupSettingsManager.cdnDepot = PopupSettingsManager.cdnDepot.Substring(PopupSettingsManager.cdnDepot.LastIndexOf("aind") + 0);
			}
		}
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x002C2ED8 File Offset: 0x002C10D8
	private bool IFJCIJOBDFO(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, bool NOGJCGPAECH = false)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			for (int i = 0; i < this.avatarPackAssets.Count; i++)
			{
				if (this.avatarPackAssets[i].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleKeepAlivePack)
		{
			for (int j = 0; j < this.keepAlivePackAssets.Count; j++)
			{
				if (this.keepAlivePackAssets[j].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleIconsPack)
		{
			for (int k = 0; k < this.iconsPackAssets.Count; k++)
			{
				if (this.iconsPackAssets[k].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfilePack)
		{
			for (int l = 0; l < this.profilePackAssets.Count; l++)
			{
				if (this.profilePackAssets[l].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
		{
			for (int m = 0; m < this.avatarExtensionPackAssets.Count; m++)
			{
				if (this.avatarExtensionPackAssets[m].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
		{
			if (!NOGJCGPAECH)
			{
				for (int n = 0; n < this.anthologyPreview2Assets.Count; n++)
				{
					if (this.anthologyPreview2Assets[n].index == MEFKFOHCOHK)
					{
						return true;
					}
				}
			}
			else
			{
				for (int num = 0; num < this.anthologyPreview2AssetsMini.Count; num++)
				{
					if (this.anthologyPreview2AssetsMini[num].index == MEFKFOHCOHK)
					{
						return true;
					}
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			for (int num2 = 0; num2 < this.liveEventContentAssets.Count; num2++)
			{
				if (this.liveEventContentAssets[num2].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCollectableCard)
		{
			for (int num3 = 0; num3 < this.collectableCardAssets.Count; num3++)
			{
				if (this.collectableCardAssets[num3].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveOfferContent)
		{
			for (int num4 = 0; num4 < this.liveOfferContentAssets.Count; num4++)
			{
				if (this.liveOfferContentAssets[num4].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchThumbnail)
		{
			for (int num5 = 0; num5 < this.sketchThumbnailAssets.Count; num5++)
			{
				if (this.sketchThumbnailAssets[num5].sketchId == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchActors)
		{
			for (int num6 = 0; num6 < this.sketchActorsAssets.Count; num6++)
			{
				if (this.sketchActorsAssets[num6].sketchId == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleFrameContainer)
		{
			for (int num7 = 0; num7 < this.frameContainerAssets.Count; num7++)
			{
				if (null != this.frameContainerAssets[num7] && this.frameContainerAssets[num7].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveProfileTheme)
		{
			for (int num8 = 0; num8 < this.liveProfileThemesAssets.Count; num8++)
			{
				if (null != this.liveProfileThemesAssets[num8] && this.liveProfileThemesAssets[num8].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCustomFader)
		{
			for (int num9 = 0; num9 < this.customFaderAssets.Count; num9++)
			{
				if (this.customFaderAssets[num9].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCustomEffects)
		{
			for (int num10 = 0; num10 < this.customEffectsAssets.Count; num10++)
			{
				if (null != this.customEffectsAssets[num10] && this.customEffectsAssets[num10].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			for (int num11 = 0; num11 < this.storyNpcAnimationAssets.Count; num11++)
			{
				if (null != this.storyNpcAnimationAssets[num11] && this.storyNpcAnimationAssets[num11].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			for (int num12 = 0; num12 < this.storyItemAnimationAssets.Count; num12++)
			{
				if (null != this.storyItemAnimationAssets[num12] && this.storyItemAnimationAssets[num12].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			for (int num13 = 0; num13 < this.storySplashManagers.Count; num13++)
			{
				if (this.storySplashManagers[num13].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyAvatar)
		{
			for (int num14 = 0; num14 < this.sceneAvatarManagers.Count; num14++)
			{
				if (this.sceneAvatarManagers[num14].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyLounge)
		{
			for (int num15 = 0; num15 < this.sceneLoungeManagers.Count; num15++)
			{
				if (this.sceneLoungeManagers[num15].loungeAnthologyIndex == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else
		{
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLobbyData && null != this.lobbyDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLobbyData2 && null != this.lobbyDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchesData && null != this.sketchesDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData && null != this.profileDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData2 && null != this.profileDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData3 && null != this.profileDataAsset3)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData4 && null != this.profileDataAsset4)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData5 && null != this.profileDataAsset5)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData6 && null != this.profileDataAsset6)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileDataLocalized && null != this.profileDataLocalizedAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleHeadersPack && null != this.headersPackAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleHeadersPack2 && null != this.headersPackAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleTextPack && null != this.textPackAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView && null != this.purchasingViewManager)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleCutsceneView && null != this.cutsceneViewManager)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchView && null != this.sketchViewManager)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x002C3570 File Offset: 0x002C1770
	public void NAHNKNCCIMG()
	{
		this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleProfileData3, 1, -1, FLDBFOADFLH.startDownloadAndProceed, false, true, true, null, -1, false, "mpi", true, true);
	}

	// Token: 0x060060D2 RID: 24786 RVA: 0x002C3595 File Offset: 0x002C1795
	public static void CacheAssetBundle(string LBGGLHDOICL)
	{
		AssetBundleManager.CacheAssetBundle(LBGGLHDOICL);
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x002C35A0 File Offset: 0x002C17A0
	private bool KIJKBNFPFCP(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, bool NOGJCGPAECH = false)
	{
		if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			for (int i = 1; i < this.avatarPackAssets.Count; i++)
			{
				if (this.avatarPackAssets[i].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-60))
		{
			for (int j = 1; j < this.keepAlivePackAssets.Count; j++)
			{
				if (this.keepAlivePackAssets[j].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)127)
		{
			for (int k = 1; k < this.iconsPackAssets.Count; k++)
			{
				if (this.iconsPackAssets[k].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)121)
		{
			for (int l = 1; l < this.profilePackAssets.Count; l++)
			{
				if (this.profilePackAssets[l].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-30))
		{
			for (int m = 1; m < this.avatarExtensionPackAssets.Count; m++)
			{
				if (this.avatarExtensionPackAssets[m].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData3)
		{
			if (!NOGJCGPAECH)
			{
				for (int n = 1; n < this.anthologyPreview2Assets.Count; n++)
				{
					if (this.anthologyPreview2Assets[n].index == MEFKFOHCOHK)
					{
						return true;
					}
				}
			}
			else
			{
				for (int num = 1; num < this.anthologyPreview2AssetsMini.Count; num++)
				{
					if (this.anthologyPreview2AssetsMini[num].index == MEFKFOHCOHK)
					{
						return true;
					}
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-82))
		{
			for (int num2 = 1; num2 < this.liveEventContentAssets.Count; num2 += 0)
			{
				if (this.liveEventContentAssets[num2].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-69))
		{
			for (int num3 = 0; num3 < this.collectableCardAssets.Count; num3++)
			{
				if (this.collectableCardAssets[num3].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAnthologyReward)
		{
			for (int num4 = 0; num4 < this.liveOfferContentAssets.Count; num4++)
			{
				if (this.liveOfferContentAssets[num4].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			for (int num5 = 1; num5 < this.sketchThumbnailAssets.Count; num5 += 0)
			{
				if (this.sketchThumbnailAssets[num5].sketchId == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			for (int num6 = 0; num6 < this.sketchActorsAssets.Count; num6 += 0)
			{
				if (this.sketchActorsAssets[num6].sketchId == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			for (int num7 = 0; num7 < this.frameContainerAssets.Count; num7++)
			{
				if (null != this.frameContainerAssets[num7] && this.frameContainerAssets[num7].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-38))
		{
			for (int num8 = 1; num8 < this.liveProfileThemesAssets.Count; num8 += 0)
			{
				if (null != this.liveProfileThemesAssets[num8] && this.liveProfileThemesAssets[num8].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-57))
		{
			for (int num9 = 1; num9 < this.customFaderAssets.Count; num9++)
			{
				if (this.customFaderAssets[num9].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-21))
		{
			for (int num10 = 0; num10 < this.customEffectsAssets.Count; num10 += 0)
			{
				if (null != this.customEffectsAssets[num10] && this.customEffectsAssets[num10].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			for (int num11 = 1; num11 < this.storyNpcAnimationAssets.Count; num11 += 0)
			{
				if (null != this.storyNpcAnimationAssets[num11] && this.storyNpcAnimationAssets[num11].index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)(-15))
		{
			for (int num12 = 1; num12 < this.storyItemAnimationAssets.Count; num12++)
			{
				if (null != this.storyItemAnimationAssets[num12] && this.storyItemAnimationAssets[num12].index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			for (int num13 = 0; num13 < this.storySplashManagers.Count; num13++)
			{
				if (this.storySplashManagers[num13].header.index == MEFKFOHCOHK)
				{
					return true;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)100)
		{
			for (int num14 = 1; num14 < this.sceneAvatarManagers.Count; num14 += 0)
			{
				if (this.sceneAvatarManagers[num14].header.index == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else if (PBKAAIONJOB == (NMKDCBPMCKI)58)
		{
			for (int num15 = 0; num15 < this.sceneLoungeManagers.Count; num15 += 0)
			{
				if (this.sceneLoungeManagers[num15].loungeAnthologyIndex == MEFKFOHCOHK)
				{
					return false;
				}
			}
		}
		else
		{
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-4) && null != this.lobbyDataAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-50) && null != this.lobbyDataAsset2)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundlePurchasingView && null != this.sketchesDataAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-4) && null != this.profileDataAsset)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)114 && null != this.profileDataAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI._deprecated4 && null != this.profileDataAsset3)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-24) && null != this.profileDataAsset4)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleIconsPack && null != this.profileDataAsset5)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-120) && null != this.profileDataAsset6)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleSketchActors && null != this.profileDataLocalizedAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)61 && null != this.headersPackAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)(-70) && null != this.headersPackAsset2)
			{
				return true;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI._deprecated2 && null != this.textPackAsset)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleStory && null != this.purchasingViewManager)
			{
				return false;
			}
			if (PBKAAIONJOB == NMKDCBPMCKI.AssetBundleProfileData4 && null != this.cutsceneViewManager)
			{
				return true;
			}
			if (PBKAAIONJOB == (NMKDCBPMCKI)91 && null != this.sketchViewManager)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060060D4 RID: 24788 RVA: 0x002C07D0 File Offset: 0x002BE9D0
	public StorySplashManager BPHEIHPGAEM(int MEFKFOHCOHK)
	{
		if (this.storySplashManagers.Count > MEFKFOHCOHK)
		{
			return this.storySplashManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060D5 RID: 24789 RVA: 0x002C3C38 File Offset: 0x002C1E38
	public bool QueueNpcAnimationBundle(int MEFKFOHCOHK)
	{
		bool result;
		try
		{
			if (MEFKFOHCOHK < 1)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Invalid npc animation bundle index, skipped:" + MEFKFOHCOHK.ToString());
				result = false;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC != null && KDCJJBLGCBH.EHBBFMCILPC.FNMKCHCBLLF())
			{
				result = false;
			}
			else if (KHPGPLAMAIN.EJCNHEBIOJF())
			{
				result = false;
			}
			else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd)
			{
				result = false;
			}
			else if (this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleNpcAnimationPack, MEFKFOHCOHK, false))
			{
				result = false;
			}
			else
			{
				this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleNpcAnimationPack, MEFKFOHCOHK, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060060D6 RID: 24790 RVA: 0x002BD119 File Offset: 0x002BB319
	public void KDCKPLFBIPK()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x002BD67E File Offset: 0x002BB87E
	public void PFAHKIPPPPF(LNDOOJOFFOM ODGGFGGKPIG, string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		this.GOBDKBEIPMC = ODGGFGGKPIG;
		AssetBundleManager.SetFolderIndexHint((int)this.GOBDKBEIPMC);
		base.StartCoroutine(this.AFPOIEJOBIH(PLDNHKIKDIB, KLCOCBODJAF));
	}

	// Token: 0x060060D8 RID: 24792 RVA: 0x002C02C3 File Offset: 0x002BE4C3
	private IEnumerator LOAOENIJIHP(OPMGJPHENFJ OMFEFBJKHJG, NPOILPKELOJ JLDHNMKCIGH, string LBGGLHDOICL, string CEAADJNPKKA)
	{
		this.NJGOLBEFEPJ++;
		DPGJIJGOCIC.NFIDPOMCNLP("assetBundleLoadOperationActiveCoroutines:" + this.NJGOLBEFEPJ.ToString());
		if (JLDHNMKCIGH != null)
		{
			yield return base.StartCoroutine(JLDHNMKCIGH);
		}
		if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundlePurchasingView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.purchasingViewManager = UnityEngine.Object.FindObjectOfType<PurchasingViewManager>();
			this.purchasingViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.purchasingViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.purchasingViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCutsceneView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.cutsceneViewManager = UnityEngine.Object.FindObjectOfType<CutsceneViewManager>();
			this.cutsceneViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.cutsceneViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.cutsceneViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchView)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.sketchViewManager = UnityEngine.Object.FindObjectOfType<SketchViewManager>();
			this.sketchViewManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				this.sketchViewManager.DontDestroyOnLoad();
			}
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				this.sketchViewManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyReward)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.IEADNMABIID.Add(LBGGLHDOICL);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStorySplash)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			StorySplashManager storySplashManager = UnityEngine.Object.FindObjectOfType<StorySplashManager>();
			storySplashManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				storySplashManager.DontDestroyOnLoad();
			}
			this.storySplashManagers.Add(storySplashManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				storySplashManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyAvatar)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			SceneAvatarManager sceneAvatarManager = UnityEngine.Object.FindObjectOfType<SceneAvatarManager>();
			sceneAvatarManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				sceneAvatarManager.DontDestroyOnLoad();
			}
			this.sceneAvatarManagers.Add(sceneAvatarManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				sceneAvatarManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyLounge)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			SceneLoungeManager sceneLoungeManager = UnityEngine.Object.FindObjectOfType<SceneLoungeManager>();
			sceneLoungeManager.gameObject.SetActive(false);
			if (OMFEFBJKHJG.AEPMNLGJBOI)
			{
				sceneLoungeManager.DontDestroyOnLoad();
			}
			this.sceneLoungeManagers.Add(sceneLoungeManager);
			if (null != OMFEFBJKHJG.PCNJLOJEAJI)
			{
				sceneLoungeManager.gameObject.transform.SetParent(OMFEFBJKHJG.PCNJLOJEAJI.transform, false);
			}
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(CEAADJNPKKA))
			{
				yield return null;
			}
			SceneManager.MergeScenes(SceneManager.GetSceneByName(CEAADJNPKKA), SceneManager.GetActiveScene());
			this.NJGOLBEFEPJ--;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, type not implemented in ProcessAssetBundleLoadLevelAsyncRequest():" + OMFEFBJKHJG.OBKCKGHFMDN.ToString());
			this.NJGOLBEFEPJ--;
		}
		yield break;
	}

	// Token: 0x060060D9 RID: 24793 RVA: 0x002C3CD8 File Offset: 0x002C1ED8
	public void JFMJDBCCHIG(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				return;
			}
		}
		this.storyAssets.Add(AJEAEPFPACP);
	}

	// Token: 0x060060DA RID: 24794 RVA: 0x002BE1B0 File Offset: 0x002BC3B0
	public SceneAvatarManager GetSceneAvatarManager(int MEFKFOHCOHK)
	{
		if (this.sceneAvatarManagers.Count > MEFKFOHCOHK)
		{
			return this.sceneAvatarManagers[MEFKFOHCOHK];
		}
		return null;
	}

	// Token: 0x060060DB RID: 24795 RVA: 0x002BE54B File Offset: 0x002BC74B
	private void IHMDAFMIHHH()
	{
		this.FPKDPDLNDKH.ABJCALOEBGJ();
	}

	// Token: 0x060060DC RID: 24796 RVA: 0x002BEC00 File Offset: 0x002BCE00
	public static bool IsInitialized()
	{
		if (null == AssetsManager.IKLAPGJDMNA)
		{
			AssetsManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AssetsManager)) as AssetsManager);
		}
		return AssetsManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x002BE316 File Offset: 0x002BC516
	public JLINKDNLADM DIFLGADHJCH()
	{
		return this.DLFNGJILCEH;
	}

	// Token: 0x060060DE RID: 24798 RVA: 0x002BD119 File Offset: 0x002BB319
	public void ONGKOPHDJCE()
	{
		AssetBundleManager.ActivatePendingRequests();
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x002C3D1C File Offset: 0x002C1F1C
	private void ABLHPFMBOOC(AssetStoryHeader CMFNIGDJFKP)
	{
		if (null == CMFNIGDJFKP)
		{
			return;
		}
		if (AppManager.PCJEMMDDCIF().GOJPLFBMCNJ(CMFNIGDJFKP.minRevision))
		{
			return;
		}
		for (int i = 1; i < this.storyHeaderAssets.Count; i += 0)
		{
			if (null != this.storyHeaderAssets[i] && this.storyHeaderAssets[i].index == CMFNIGDJFKP.index)
			{
				return;
			}
		}
		this.storyHeaderAssets.Add(CMFNIGDJFKP);
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x002BD6E8 File Offset: 0x002BB8E8
	private void JMIEGJKLIJA()
	{
		this.FPKDPDLNDKH.HBEPAFKIIEH();
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x002C3D98 File Offset: 0x002C1F98
	private string EHEEAGOLJAJ(string MNOCEFGMBHK)
	{
		try
		{
			int num = 1;
			for (int i = MNOCEFGMBHK.Length - 0; i >= 1; i--)
			{
				if (MNOCEFGMBHK[i] == 'r')
				{
					num++;
				}
				if (num == 3)
				{
					return MNOCEFGMBHK.Substring(i).Replace("SceneStoryAssetPackSharedClient", "");
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "OnPopupCardOptionsUnlockWithSpException";
	}

	// Token: 0x060060E2 RID: 24802 RVA: 0x002C3E08 File Offset: 0x002C2008
	private bool CKOOKOGLDMO()
	{
		return this.AKCDHJCIJCG;
	}

	// Token: 0x060060E3 RID: 24803 RVA: 0x002BE316 File Offset: 0x002BC516
	public JLINKDNLADM GetOperationState()
	{
		return this.DLFNGJILCEH;
	}

	// Token: 0x060060E4 RID: 24804 RVA: 0x002C3E10 File Offset: 0x002C2010
	public void UnloadPersistentAssetBundle(string LBGGLHDOICL)
	{
		for (int i = 0; i < this.IEADNMABIID.Count; i++)
		{
			if (this.IEADNMABIID[i].Equals(LBGGLHDOICL))
			{
				AssetBundleManager.UnloadAssetBundle(this.IEADNMABIID[i], false);
				this.IEADNMABIID.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060060E5 RID: 24805 RVA: 0x002C07C1 File Offset: 0x002BE9C1
	private IEnumerator Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.LEOFIDDNKAF = base.GetComponent<UrlPingManager>();
		yield return base.StartCoroutine(this.KNPIMINGDEA());
		yield break;
	}

	// Token: 0x060060E6 RID: 24806 RVA: 0x002C3E68 File Offset: 0x002C2068
	private void COEFPGNAMHJ(AssetAnthology EPMNJLEBHND)
	{
		if (null == EPMNJLEBHND)
		{
			return;
		}
		if (AppManager.PCJEMMDDCIF().UnsupportedRevision(EPMNJLEBHND.minRevision))
		{
			return;
		}
		for (int i = 0; i < this.anthologyAssets.Count; i += 0)
		{
			if (null != this.anthologyAssets[i] && this.anthologyAssets[i].header.index == EPMNJLEBHND.header.index)
			{
				return;
			}
		}
		this.anthologyAssets.Add(EPMNJLEBHND);
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x002C3EEC File Offset: 0x002C20EC
	private void NKPPDCKCJAO(AssetAnthology EPMNJLEBHND)
	{
		if (null == EPMNJLEBHND)
		{
			return;
		}
		if (AppManager.AGANFKKBPFO().FPPCJOHDDDK(EPMNJLEBHND.minRevision))
		{
			return;
		}
		for (int i = 0; i < this.anthologyAssets.Count; i += 0)
		{
			if (null != this.anthologyAssets[i] && this.anthologyAssets[i].header.index == EPMNJLEBHND.header.index)
			{
				return;
			}
		}
		this.anthologyAssets.Add(EPMNJLEBHND);
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x002BE148 File Offset: 0x002BC348
	public void CleanupDownloadQueue()
	{
		this.MFPCGBNKHCC.Clear();
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x000FAFD0 File Offset: 0x000F91D0
	private void GMADGCBOAJF()
	{
		Application.Quit();
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x002C3F70 File Offset: 0x002C2170
	public void JNGEDFDGHAJ(string JEOKFNAFILA = null, string IOPJPDKHMDG = null, bool EAGAMDIOMEB = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("$NPCFROMAVATAR");
			return;
		}
		this.KAHJMAHGDFI = KGDFLLFLIPM.Busy;
		this.CFEJAMGNPAC("fsofts");
		this.MPEGJMEEIFA = JEOKFNAFILA;
		this.IDHIPDNNLIN = IOPJPDKHMDG;
		NPOILPKELOJ.DAEOMOJFKDN = true;
		this.EGLPBAJMOHJ = true;
		this.IOOFABBLGKE = EAGAMDIOMEB;
		this.ODDNKAMKHDA = DPGJIJGOCIC.MKJLJPMEPCC();
		base.StartCoroutine(this.MJGCKOIFLNK());
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x002C3FE0 File Offset: 0x002C21E0
	public void QueueAssetBundleDownloadNoSkip(NMKDCBPMCKI PBKAAIONJOB, int MEFKFOHCOHK, int AFENNOBCLFN, FLDBFOADFLH NLIDEHHMLLP, bool AOGDLLHFJHH, bool NOJLAFNCGHF, bool LHGBCGJNFJK, GameObject BFGBPKIGAJI, int NGMOBELPFII, string DDPMFNOGJIE, bool BNLEIHNDMOI = false, bool MLMDHOHNOPM = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error - can not queue asset bundles when download in progress.");
			return;
		}
		OPMGJPHENFJ opmgjphenfj = new OPMGJPHENFJ();
		opmgjphenfj.PCNJLOJEAJI = BFGBPKIGAJI;
		opmgjphenfj.GGICIBLJIKI = MEFKFOHCOHK;
		opmgjphenfj.MHGBNAFGKCE = AFENNOBCLFN;
		opmgjphenfj.OPDHIOLLADO = NLIDEHHMLLP;
		opmgjphenfj.OBKCKGHFMDN = PBKAAIONJOB;
		opmgjphenfj.MOKINGPDAFE = false;
		opmgjphenfj.KKJNKAFMANA = AOGDLLHFJHH;
		opmgjphenfj.AEPMNLGJBOI = LHGBCGJNFJK;
		opmgjphenfj.AOPIMPMDEHO = NGMOBELPFII;
		opmgjphenfj.IFKICNLMPPD = DDPMFNOGJIE;
		opmgjphenfj.MIACKIKIFJJ = BNLEIHNDMOI;
		opmgjphenfj.IPDGGPBONDP = false;
		opmgjphenfj.AMJBNEILEKN = MLMDHOHNOPM;
		if (!this.FKHJIMFBFGK(opmgjphenfj))
		{
			this.MFPCGBNKHCC.Add(opmgjphenfj);
		}
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x002C4080 File Offset: 0x002C2280
	public int LastOperationFailStateCounterHit()
	{
		if (!this.EGLPBAJMOHJ && !this.GCIIHKGFLFI.Equals(this.ODDNKAMKHDA) && this.OKMBMHIKIBC.Length > 0 && (this.DLFNGJILCEH == JLINKDNLADM.Failed || this.DLFNGJILCEH == JLINKDNLADM.NotInitialized))
		{
			this.EMOFAGMGIOI++;
		}
		this.GCIIHKGFLFI = this.ODDNKAMKHDA;
		this.EGLPBAJMOHJ = false;
		DPGJIJGOCIC.NFIDPOMCNLP("LastOperationFailStateCounterHit():" + this.EMOFAGMGIOI.ToString());
		return this.EMOFAGMGIOI;
	}

	// Token: 0x060060ED RID: 24813 RVA: 0x002C410C File Offset: 0x002C230C
	public void NAKMKJKJDCK(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP)
	{
		try
		{
			if (!(null == JFCABBGNNKJ) && JFCABBGNNKJ.chapterAssetPacks != null && OLKMHHNMDLP >= 0 && OLKMHHNMDLP < JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.AJNJENAFLPP())
					{
						if (!KHPGPLAMAIN.BOIFOPEAIBN())
						{
							if (KHPGPLAMAIN.CIEILKHLDCG() != IIHCCPLGGHP.highEnd)
							{
								for (int i = 0; i < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks.Count; i++)
								{
									if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i] < 0)
									{
										DPGJIJGOCIC.PJCLICBPPDA("OnBackendGetPublicProfileHallOfFameSuccess" + JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i].ToString());
									}
									else
									{
										this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleHeadersPack2, JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i], -1, FLDBFOADFLH.finishDownloadAndProceed, false, false, true, null, -1, true, "SceneLobbyManager2.OnLiveProfileThumbnailsCdnSuccess(): resident=", true, true);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060060EE RID: 24814 RVA: 0x002C424C File Offset: 0x002C244C
	public void InitializeAssetBundleFolder(LNDOOJOFFOM ODGGFGGKPIG, string PLDNHKIKDIB, string KLCOCBODJAF)
	{
		this.GOBDKBEIPMC = ODGGFGGKPIG;
		AssetBundleManager.SetFolderIndexHint((int)this.GOBDKBEIPMC);
		base.StartCoroutine(this.HLMLJKGKKPD(PLDNHKIKDIB, KLCOCBODJAF));
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x002C426F File Offset: 0x002C246F
	public void CleanAssetBundleManagerHasBeenResetFlag()
	{
		this.POOGGCLFKMI = false;
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x002C4278 File Offset: 0x002C2478
	private IEnumerator MFCEPBHJMGP()
	{
		yield return new WaitForEndOfFrame();
		this.MGHGEJLBBIH();
		if (this.MPEGJMEEIFA == null)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnAssetsManagerDownloadSuccess", 0f);
		}
		else
		{
			string mpegjmeeifa = this.MPEGJMEEIFA;
			this.MPEGJMEEIFA = null;
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(mpegjmeeifa, 0f);
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		yield break;
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x002C4287 File Offset: 0x002C2487
	private IEnumerator OHPNGFAIGEM()
	{
		AssetsManager.GKIFAGGLPJA gkifagglpja = new AssetsManager.GKIFAGGLPJA(1);
		gkifagglpja.<>4__this = this;
		return gkifagglpja;
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x002C44A8 File Offset: 0x002C26A8
	public void QueueFrameContainerBundle(int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 0)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("Invalid frame container bundle index, skipped:" + MEFKFOHCOHK.ToString());
			return;
		}
		if (KDCJJBLGCBH.EHBBFMCILPC != null && KDCJJBLGCBH.EHBBFMCILPC.INCKJPOBAKM())
		{
			DPGJIJGOCIC.ADFCDFHBDAF("Frame containers are disabled by the balance (fdfrc), bundle skipped:" + MEFKFOHCOHK.ToString());
			return;
		}
		this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleFrameContainer, MEFKFOHCOHK, -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
	}

	// Token: 0x060060F4 RID: 24820 RVA: 0x002C4512 File Offset: 0x002C2712
	private void MGHGEJLBBIH()
	{
		this.KAHJMAHGDFI = KGDFLLFLIPM.Idle;
	}

	// Token: 0x060060F5 RID: 24821 RVA: 0x002C451B File Offset: 0x002C271B
	private IEnumerator CCOABDDMHBP(OPMGJPHENFJ OMFEFBJKHJG, DAJHCGFBHMO JLDHNMKCIGH, string LBGGLHDOICL)
	{
		this.NJGOLBEFEPJ++;
		DPGJIJGOCIC.NFIDPOMCNLP("assetBundleLoadOperationActiveCoroutines:" + this.NJGOLBEFEPJ.ToString());
		if (JLDHNMKCIGH != null)
		{
			yield return base.StartCoroutine(JLDHNMKCIGH);
		}
		if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.avatarPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAvatarPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleKeepAlivePack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.keepAlivePackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetKeepAlivePack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.IEADNMABIID.Add(LBGGLHDOICL);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			if (OMFEFBJKHJG.IPDGGPBONDP)
			{
				AssetAnthologyPreview2 assetAnthologyPreview = JLDHNMKCIGH.PCGAGHLGLIM<AssetAnthologyPreview2>();
				assetAnthologyPreview.CNBBGIPAMAG();
				this.anthologyPreview2AssetsMini.Add(assetAnthologyPreview);
			}
			else
			{
				this.anthologyPreview2Assets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAnthologyPreview2>());
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleIconsPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.iconsPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetIconsPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfilePack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			AssetProfilePack assetProfilePack = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfilePack>();
			this.profilePackAssets.Add(assetProfilePack);
			if (null != this.profileDataAsset && null != this.lobbyDataAsset)
			{
				this.profileDataAsset.FLPAEANKGLG(assetProfilePack, this.lobbyDataAsset.maxAnthologyIndex);
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveEventContentAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveEventContent>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCollectableCard)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.collectableCardAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetCollectableCard>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveOfferContent)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveOfferContentAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveOfferContent>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchThumbnail)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchThumbnailAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchThumbnail>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchActors)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchActorsAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchActors>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleFrameContainer)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional frame container bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetFrameContainer assetFrameContainer = JLDHNMKCIGH.PCGAGHLGLIM<AssetFrameContainer>();
					if (null != assetFrameContainer)
					{
						if (assetFrameContainer.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Frame container asset index mismatch, correcting " + assetFrameContainer.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetFrameContainer.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						this.frameContainerAssets.Add(assetFrameContainer);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Frame container bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional lobby data 2 bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetLobbyData2 y = JLDHNMKCIGH.PCGAGHLGLIM<AssetLobbyData2>();
					if (null != y)
					{
						this.lobbyDataAsset2 = y;
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Lobby data 2 bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData6)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional profile data 6 bundle (live profile theme thumbnails) failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetProfileData6 y2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData6>();
					if (null != y2)
					{
						this.profileDataAsset6 = y2;
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Profile data 6 bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm3)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveProfileTheme)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveProfileThemesAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveProfileTheme>());
			this.liveProfileThemesVersion++;
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomEffects)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional custom effects bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetCustomEffects assetCustomEffects = JLDHNMKCIGH.PCGAGHLGLIM<AssetCustomEffects>();
					if (null != assetCustomEffects)
					{
						if (assetCustomEffects.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Custom effects asset index mismatch, correcting " + assetCustomEffects.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetCustomEffects.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						this.customEffectsAssets.Add(assetCustomEffects);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Custom effects bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional npc animation bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetStoryNpcAnimation assetStoryNpcAnimation = JLDHNMKCIGH.PCGAGHLGLIM<AssetStoryNpcAnimation>();
					if (null != assetStoryNpcAnimation)
					{
						if (assetStoryNpcAnimation.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Npc animation asset index mismatch, correcting " + assetStoryNpcAnimation.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetStoryNpcAnimation.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						assetStoryNpcAnimation.PGFEFJDBIME();
						this.storyNpcAnimationAssets.Add(assetStoryNpcAnimation);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Npc animation bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm5)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional item animation bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetStoryItemAnimation assetStoryItemAnimation = JLDHNMKCIGH.PCGAGHLGLIM<AssetStoryItemAnimation>();
					if (null != assetStoryItemAnimation)
					{
						if (assetStoryItemAnimation.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Item animation asset index mismatch, correcting " + assetStoryItemAnimation.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetStoryItemAnimation.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						assetStoryItemAnimation.PGFEFJDBIME();
						this.storyItemAnimationAssets.Add(assetStoryItemAnimation);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Item animation bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm6)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomFader)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.customFaderAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetCustomFader>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.lobbyDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetLobbyData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchesData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchesDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchesData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData2>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData3)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset3 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData3>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData4)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset4 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData4>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset5 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData5>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileDataLocalized)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataLocalizedAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileDataLocalized>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.headersPackAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetHeadersPack>();
			for (int i = 0; i < this.headersPackAsset.anthologiesList.Count; i++)
			{
				if (null != this.headersPackAsset.anthologiesList[i])
				{
					AssetAnthology assetAnthology = this.headersPackAsset.anthologiesList[i];
					GKJPOGNFKNK.PANECPKKMLJ(assetAnthology);
					if (assetAnthology.FMJONLDHPHN(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
					{
						this.FCGAFGDJHFF(assetAnthology);
					}
				}
			}
			for (int j = 0; j < this.headersPackAsset.storyHeadersList.Count; j++)
			{
				if (null != this.headersPackAsset.storyHeadersList[j])
				{
					this.NONGBOJEOAK(this.headersPackAsset.storyHeadersList[j]);
				}
			}
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.headersPackAsset2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetHeadersPack2>();
			for (int k = 0; k < this.headersPackAsset2.anthologiesList.Count; k++)
			{
				if (null != this.headersPackAsset2.anthologiesList[k])
				{
					AssetAnthology assetAnthology2 = this.headersPackAsset2.anthologiesList[k];
					GKJPOGNFKNK.PANECPKKMLJ(assetAnthology2);
					if (assetAnthology2.FMJONLDHPHN(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
					{
						this.FCGAFGDJHFF(assetAnthology2);
					}
				}
			}
			for (int l = 0; l < this.headersPackAsset2.storyHeadersList.Count; l++)
			{
				if (null != this.headersPackAsset2.storyHeadersList[l])
				{
					this.NONGBOJEOAK(this.headersPackAsset2.storyHeadersList[l]);
				}
			}
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.avatarExtensionPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAvatarExtensionPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleTextPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.textPackAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetTextPack>();
			for (int m = 0; m < this.textPackAsset.textAssetsCollection.Count; m++)
			{
				for (int n = 0; n < this.textPackAsset.textAssetsCollection[m].textAssets.Count; n++)
				{
					GKJPOGNFKNK.GIMAJLEGGHF(this.textPackAsset.textAssetsCollection[m].nameHint, this.textPackAsset.textAssetsCollection[m].textAssets[n]);
				}
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, type not implemented in ProcessAssetBundleLoadAssetOperationRequest():" + OMFEFBJKHJG.OBKCKGHFMDN.ToString());
			this.NJGOLBEFEPJ--;
		}
		yield break;
	}

	// Token: 0x060060F6 RID: 24822 RVA: 0x002C04FA File Offset: 0x002BE6FA
	public bool OMPIABBPDKB()
	{
		return this.POOGGCLFKMI;
	}

	// Token: 0x060060F7 RID: 24823 RVA: 0x002C453F File Offset: 0x002C273F
	private IEnumerator LGCDNFCMEHN()
	{
		this.DLFNGJILCEH = JLINKDNLADM.Progress;
		int num = 0;
		for (int k = 0; k < this.MFPCGBNKHCC.Count; k++)
		{
			if (this.MFPCGBNKHCC[k].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
			{
				num += 4;
			}
		}
		this.FPKDPDLNDKH.EPJKDCDOEMM(this.MFPCGBNKHCC.Count + num);
		this.DLFNGJILCEH = JLINKDNLADM.Progress;
		if (!this.CKOOKOGLDMO())
		{
			if (!this.BKKBJOOOEBO)
			{
				yield return base.StartCoroutine(this.KNPIMINGDEA());
			}
			else
			{
				yield return new WaitForSeconds(this.AAHOKPFGOBP);
			}
		}
		if (!this.CKOOKOGLDMO())
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, AssetsManager not initialized.");
			this.DLFNGJILCEH = JLINKDNLADM.NotInitialized;
			yield break;
		}
		this.CleanseAssetBundleAssets();
		for (int l = 0; l < this.MFPCGBNKHCC.Count; l++)
		{
			if (this.MFPCGBNKHCC[l].MOKINGPDAFE)
			{
				this.DestroyAssetBundleAssets(this.MFPCGBNKHCC[l].OBKCKGHFMDN, -1);
			}
		}
		AssetBundleManager.FPFDACGEAIK = new string[]
		{
			string.Concat(new string[]
			{
				NBDLBFJOEGN.FKJIECPMBFP(),
				"-",
				LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI()
			}),
			string.Concat(new string[]
			{
				NBDLBFJOEGN.FKJIECPMBFP(),
				"-",
				LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(),
				"-",
				NBDLBFJOEGN.IDFPPIFEDIF()
			}),
			string.Concat(new string[]
			{
				NBDLBFJOEGN.FKJIECPMBFP(),
				"-",
				CEIBHCNNIDC.en.ToString(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI()
			}),
			string.Concat(new string[]
			{
				NBDLBFJOEGN.FKJIECPMBFP(),
				"-",
				CEIBHCNNIDC.en.ToString(),
				"-",
				NBDLBFJOEGN.IDFPPIFEDIF()
			})
		};
		AssetBundleManager.AGPJIKOMILO = new string[]
		{
			string.Concat(new string[]
			{
				CBKCEDKJDMJ.sd.ToString(),
				"-",
				LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI()
			}),
			string.Concat(new string[]
			{
				CBKCEDKJDMJ.sd.ToString(),
				"-",
				LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString(),
				"-",
				NBDLBFJOEGN.IDFPPIFEDIF()
			}),
			string.Concat(new string[]
			{
				CBKCEDKJDMJ.sd.ToString(),
				"-",
				CEIBHCNNIDC.en.ToString(),
				"-",
				NBDLBFJOEGN.JHNDHBLDJOI()
			}),
			string.Concat(new string[]
			{
				CBKCEDKJDMJ.sd.ToString(),
				"-",
				CEIBHCNNIDC.en.ToString(),
				"-",
				NBDLBFJOEGN.IDFPPIFEDIF()
			})
		};
		int num3;
		for (int i = 0; i < this.MFPCGBNKHCC.Count; i = num3 + 1)
		{
			if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Breaking from download operation loop, current operation state is AssetBundleLoadingOperationState.Failed.");
				yield break;
			}
			if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleAnthologyPreview2, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].IPDGGPBONDP))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAnthologyPreview2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					if (this.MFPCGBNKHCC[i].IPDGGPBONDP)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.MiniVersion, -1, -1, -1);
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.MiniVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					else if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetAnthologyPreview2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetAnthologyPreview2));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCollectableCard)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleCollectableCard, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleCollectableCard, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetCollectableCard, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetCollectableCard));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveOfferContent)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleLiveOfferContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleLiveOfferContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetLiveOfferContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetLiveOfferContent));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchThumbnail)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleSketchThumbnail, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleSketchThumbnail, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetSketchThumbnail, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetSketchThumbnail));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchActors)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleSketchActors, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleSketchActors, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetSketchActors, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetSketchActors));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleFrameContainer)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleFrameContainer, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleFrameContainer, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetFrameContainer, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetFrameContainer));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveProfileTheme)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleLiveProfileTheme, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleLiveProfileTheme, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetLiveProfileTheme, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetLiveProfileTheme));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomFader)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleCustomFader, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleCustomFader, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetCustomFader, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetCustomFader));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomEffects)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleCustomEffects, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleCustomEffects, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetCustomEffects, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetCustomEffects));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveEventContent)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleLiveEventContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleLiveEventContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					if (this.MFPCGBNKHCC[i].IFKICNLMPPD != null && this.MFPCGBNKHCC[i].IFKICNLMPPD.Length > 0)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
							{
								assetBundleName = assetBundleName + this.MFPCGBNKHCC[i].IFKICNLMPPD + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
							}
							else
							{
								assetBundleName += this.MFPCGBNKHCC[i].IFKICNLMPPD;
							}
						}
						else if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), this.MFPCGBNKHCC[i].IFKICNLMPPD + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), this.MFPCGBNKHCC[i].IFKICNLMPPD + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					else if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
					{
						if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
						}
					}
					else if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
					{
						assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
					}
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetLiveEventContent, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetLiveEventContent));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleLobbyData, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleLobbyData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetLobbyData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetLobbyData));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData2)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleLobbyData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleLobbyData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetLobbyData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetLobbyData2));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData6)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData6, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData6, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData6, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData6));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchesData)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleSketchesData, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleSketchesData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetSketchesData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetSketchesData));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData2)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData2));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData3)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData3, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData3, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData3, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData3));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData4)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData4, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData4, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData4, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData4));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData5)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileData5, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileData5, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileData5, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileData5));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileDataLocalized)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfileDataLocalized, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfileDataLocalized, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfileDataLocalized, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfileDataLocalized));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleHeadersPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleHeadersPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetHeadersPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetHeadersPack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack2)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleHeadersPack2, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleHeadersPack2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetHeadersPack2, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetHeadersPack2));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleAvatarPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAvatarPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetAvatarPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, cooogacbakn, typeof(AssetAvatarPack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, (int)this.GOBDKBEIPMC))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleNpcAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleNpcAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetNpcAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, cooogacbakn, typeof(AssetStoryNpcAnimation));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, (int)this.GOBDKBEIPMC))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleItemAnimationPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleItemAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleItemAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetItemAnimationPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, cooogacbakn, typeof(AssetStoryItemAnimation));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, (int)this.GOBDKBEIPMC))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleKeepAlivePack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleKeepAlivePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetKeepAlivePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetKeepAlivePack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleIconsPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleIconsPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleIconsPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetIconsPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetIconsPack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfilePack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleProfilePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleProfilePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetProfilePack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetProfilePack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAvatarExtensionPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetAvatarExtensionPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, cooogacbakn, typeof(AssetAvatarExtensionPack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, (int)this.GOBDKBEIPMC))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleTextPack)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleTextPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleTextPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string cooogacbakn = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.AssetTextPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					DAJHCGFBHMO request = AssetBundleManager.LoadAssetAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, cooogacbakn, typeof(AssetTextPack));
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.CCOABDDMHBP(this.MFPCGBNKHCC[i], request, assetBundleName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundlePurchasingView)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundlePurchasingView, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundlePurchasingView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.ScenePurchasingView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCutsceneView)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleCutsceneView, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleCutsceneView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneCutsceneView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchView)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleSketchView, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleSketchView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneSketchView, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyReward)
			{
				string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAnthologyReward, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1);
				string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneAnthologyReward, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1);
				NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, false, false);
				if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
					base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
				}
				else
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
					while (this.NJGOLBEFEPJ > 0)
					{
						yield return null;
					}
					if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
						yield break;
					}
					yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
					{
						yield break;
					}
				}
				request2 = null;
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStory)
			{
				string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStory, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
				string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStory, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
				while (this.NJGOLBEFEPJ > 0)
				{
					yield return null;
				}
				if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
					yield break;
				}
				NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, sceneName, false, true);
				if (request2 != null)
				{
					yield return base.StartCoroutine(request2);
				}
				if (request2 == null || request2.HJOPIMGMGML())
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + assetBundleName);
					this.DLFNGJILCEH = JLINKDNLADM.Failed;
					yield break;
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + assetBundleName);
				AssetBundleManager.UnloadAssetBundle(assetBundleName, false);
				while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(sceneName))
				{
					yield return null;
				}
				for (int j = 0; j < this.MFPCGBNKHCC.Count; j = num3 + 1)
				{
					if (this.MFPCGBNKHCC[j].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
					{
						string storyPackAssetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.MFPCGBNKHCC[j].GGICIBLJIKI, this.MFPCGBNKHCC[j].MHGBNAFGKCE, -1);
						string storyPackSceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStoryAssetPack, this.MFPCGBNKHCC[j].GGICIBLJIKI, this.MFPCGBNKHCC[j].MHGBNAFGKCE, -1);
						if (AssetBundleManager.IsAssetBundleLoaded(storyPackAssetBundleName))
						{
							SceneManager.LoadSceneAsync(storyPackSceneName, LoadSceneMode.Additive);
							while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(storyPackSceneName))
							{
								yield return null;
							}
							SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
							for (int m = 0; m < array.Length; m++)
							{
								if (array[m].gameObject.scene.name.Equals(storyPackSceneName))
								{
									array[m].SetOnDemandResourcesCheckpointIndex(this.MFPCGBNKHCC[j].AOPIMPMDEHO);
									array[m].SaveSceneAndAssetBundleName(storyPackAssetBundleName, (int)this.GOBDKBEIPMC);
								}
							}
							AudioContainer[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(AudioContainer)) as AudioContainer[];
							for (int n = 0; n < array2.Length; n++)
							{
								if (array2[n].gameObject.scene.name.Equals(storyPackSceneName))
								{
									array2[n].SaveSceneAndAssetBundleName(storyPackAssetBundleName, (int)this.GOBDKBEIPMC);
								}
							}
							VideoContainer[] array3 = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
							for (int num2 = 0; num2 < array3.Length; num2++)
							{
								if (array3[num2].gameObject.scene.name.Equals(storyPackSceneName))
								{
									array3[num2].SaveSceneAndAssetBundleName(storyPackAssetBundleName, (int)this.GOBDKBEIPMC);
								}
							}
							SceneManager.MergeScenes(SceneManager.GetSceneByName(storyPackSceneName), SceneManager.GetSceneByName(sceneName));
							this.FPKDPDLNDKH.IFJCIJOBDFO(1);
							if (!this.MFPCGBNKHCC[j].KKJNKAFMANA)
							{
								AssetBundleManager.UnloadAssetBundle(storyPackAssetBundleName, this.MFPCGBNKHCC[j].AMJBNEILEKN);
							}
							else if (this.MFPCGBNKHCC[j].AMJBNEILEKN)
							{
								this.EIJMNBNOKBC.Add(storyPackAssetBundleName);
							}
							else
							{
								this.IEADNMABIID.Add(storyPackAssetBundleName);
							}
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Trying to load AssetBundleStoryAssetPack, but there is no bundle loaded:" + storyPackAssetBundleName);
						}
						storyPackAssetBundleName = null;
						storyPackSceneName = null;
					}
					num3 = j;
				}
				request2 = null;
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPackActivate)
			{
				while (this.NJGOLBEFEPJ > 0)
				{
					yield return null;
				}
				if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
					yield break;
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + NMKDCBPMCKI.AssetBundleStoryAssetPackActivate.ToString());
				for (int j = 0; j < this.MFPCGBNKHCC.Count; j = num3 + 1)
				{
					if (this.MFPCGBNKHCC[j].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
					{
						string storyPackSceneName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.MFPCGBNKHCC[j].GGICIBLJIKI, this.MFPCGBNKHCC[j].MHGBNAFGKCE, -1);
						string storyPackAssetBundleName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStoryAssetPack, this.MFPCGBNKHCC[j].GGICIBLJIKI, this.MFPCGBNKHCC[j].MHGBNAFGKCE, -1);
						if (AssetBundleManager.IsAssetBundleLoaded(storyPackSceneName))
						{
							SceneManager.LoadSceneAsync(storyPackAssetBundleName, LoadSceneMode.Additive);
							while (!SceneManagerUtils.EHBBFMCILPC.SceneLoaded(storyPackAssetBundleName))
							{
								yield return null;
							}
							SceneStoryAssetPackManager[] array4 = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
							for (int num4 = 0; num4 < array4.Length; num4++)
							{
								if (array4[num4].gameObject.scene.name.Equals(storyPackAssetBundleName))
								{
									array4[num4].SetOnDemandResourcesCheckpointIndex(this.MFPCGBNKHCC[j].AOPIMPMDEHO);
									array4[num4].SaveSceneAndAssetBundleName(storyPackSceneName, (int)this.GOBDKBEIPMC);
								}
							}
							AudioContainer[] array5 = UnityEngine.Object.FindObjectsOfType(typeof(AudioContainer)) as AudioContainer[];
							for (int num5 = 0; num5 < array5.Length; num5++)
							{
								if (array5[num5].gameObject.scene.name.Equals(storyPackAssetBundleName))
								{
									array5[num5].SaveSceneAndAssetBundleName(storyPackSceneName, (int)this.GOBDKBEIPMC);
								}
							}
							VideoContainer[] array6 = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
							for (int num6 = 0; num6 < array6.Length; num6++)
							{
								if (array6[num6].gameObject.scene.name.Equals(storyPackAssetBundleName))
								{
									array6[num6].SaveSceneAndAssetBundleName(storyPackSceneName, (int)this.GOBDKBEIPMC);
								}
							}
							SceneManager.MergeScenes(SceneManager.GetSceneByName(storyPackAssetBundleName), SceneManager.GetActiveScene());
							this.FPKDPDLNDKH.IFJCIJOBDFO(1);
							if (!this.MFPCGBNKHCC[j].KKJNKAFMANA)
							{
								AssetBundleManager.UnloadAssetBundle(storyPackSceneName, this.MFPCGBNKHCC[j].AMJBNEILEKN);
							}
							else if (this.MFPCGBNKHCC[j].AMJBNEILEKN)
							{
								this.EIJMNBNOKBC.Add(storyPackSceneName);
							}
							else
							{
								this.IEADNMABIID.Add(storyPackSceneName);
							}
						}
						else
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Trying to load AssetBundleStoryAssetPack, but there is no bundle loaded:" + storyPackSceneName);
						}
						storyPackSceneName = null;
						storyPackAssetBundleName = null;
					}
					num3 = j;
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStoryAssetPack)
			{
				string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStoryAssetPack, this.MFPCGBNKHCC[i].GGICIBLJIKI, this.MFPCGBNKHCC[i].MHGBNAFGKCE, -1);
				NPOILPKELOJ request2 = AssetBundleManager.PreloadAssetBundle(assetBundleName, this.GOBDKBEIPMC.ToString(), (int)this.GOBDKBEIPMC, this.MFPCGBNKHCC[i].AMJBNEILEKN);
				if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, (int)this.GOBDKBEIPMC))
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
					base.StartCoroutine(this.HONFMKOGDJP(this.MFPCGBNKHCC[i], request2, assetBundleName));
				}
				else
				{
					DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
					while (this.NJGOLBEFEPJ > 0)
					{
						yield return null;
					}
					if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
						yield break;
					}
					yield return base.StartCoroutine(this.HONFMKOGDJP(this.MFPCGBNKHCC[i], request2, assetBundleName));
					if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
					{
						yield break;
					}
				}
				request2 = null;
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleStorySplash)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleStorySplash, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleStorySplash, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					if (this.MFPCGBNKHCC[i].MIACKIKIFJJ)
					{
						if (!assetBundleName.EndsWith(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString()))
						{
							assetBundleName += OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1);
						}
						else
						{
							assetBundleName = assetBundleName.Replace(OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString(), OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.LowEndVersion, -1, -1, -1) + OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.Variant, -1, -1, -1).ToString());
						}
					}
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneStorySplash, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyAvatar)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleAnthologyAvatar, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAnthologyAvatar, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneAnthologyAvatar, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			else if (this.MFPCGBNKHCC[i].OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyLounge)
			{
				if (!this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleAnthologyLounge, this.MFPCGBNKHCC[i].GGICIBLJIKI, false))
				{
					string assetBundleName = OMIMIKMIMFE.NCDEKILOHGF(NMKDCBPMCKI.AssetBundleAnthologyLounge, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					string sceneName = OMIMIKMIMFE.JGLEMENLPJP(HEIDEJOPKAA.SceneAnthologyLounge, this.MFPCGBNKHCC[i].GGICIBLJIKI, -1, -1);
					NPOILPKELOJ request2 = AssetBundleManager.LoadLevelAsync(assetBundleName, LNDOOJOFFOM.Common.ToString(), 0, sceneName, true, true);
					if (this.MFPCGBNKHCC[i].OPDHIOLLADO == FLDBFOADFLH.startDownloadAndProceed && this.NJGOLBEFEPJ < this.GGBJNCPDJEN() && AssetBundleManager.DependenciesLoadedExceptOwnVariant(assetBundleName, 0))
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + assetBundleName);
						base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting non-parallel download:" + assetBundleName);
						while (this.NJGOLBEFEPJ > 0)
						{
							yield return null;
						}
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							yield break;
						}
						yield return base.StartCoroutine(this.LOAOENIJIHP(this.MFPCGBNKHCC[i], request2, assetBundleName, sceneName));
						if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
						{
							yield break;
						}
					}
					request2 = null;
				}
				else
				{
					this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				}
			}
			num3 = i;
		}
		if (this.DLFNGJILCEH == JLINKDNLADM.Failed)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
			yield break;
		}
		this.DLFNGJILCEH = JLINKDNLADM.Success;
		yield break;
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x002C4550 File Offset: 0x002C2750
	private void DJACMNCMPEL()
	{
		if (GeoLocationManager.HEKEPNDKCPM(LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()))
		{
			if (this.LEOFIDDNKAF.AODLJMNHPCI())
			{
				if (!this.LEOFIDDNKAF.NMNNKDDAOCH() && !this.LEOFIDDNKAF.AKDBKJJPMKG())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("-");
					this.LEOFIDDNKAF.NIBFLGOFPHL(KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB);
					return;
				}
			}
			else if (!this.LEOFIDDNKAF.IsReady())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("$tr");
				this.LEOFIDDNKAF.CPBBKOLHBDH(this.DGAICDDKDGJ, KBOJLHAJPCP.FDLNHBCAABL, KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB, KBOJLHAJPCP.COLJLNNOMGL);
			}
		}
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x002BE155 File Offset: 0x002BC355
	private void OnDestroy()
	{
		if (AssetsManager.IKLAPGJDMNA == this)
		{
			AssetsManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x002C45FE File Offset: 0x002C27FE
	public bool IsBusy()
	{
		return this.DLFNGJILCEH == JLINKDNLADM.Progress || AssetBundleManager.IsBusy() || this.KAHJMAHGDFI == KGDFLLFLIPM.Busy;
	}

	// Token: 0x060060FB RID: 24827 RVA: 0x002C461B File Offset: 0x002C281B
	public bool INPGGBEDFAB()
	{
		return this.DLFNGJILCEH == JLINKDNLADM.Idle || AssetBundleManager.AHALCGLJBLB() || this.KAHJMAHGDFI == KGDFLLFLIPM.Busy;
	}

	// Token: 0x060060FC RID: 24828 RVA: 0x002BD6F5 File Offset: 0x002BB8F5
	public void ResetForceNoParallelLoadOperations()
	{
		this.GPKCJNEIHBH = false;
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x002C451B File Offset: 0x002C271B
	private IEnumerator ONJGIKBMAHA(OPMGJPHENFJ OMFEFBJKHJG, DAJHCGFBHMO JLDHNMKCIGH, string LBGGLHDOICL)
	{
		this.NJGOLBEFEPJ++;
		DPGJIJGOCIC.NFIDPOMCNLP("assetBundleLoadOperationActiveCoroutines:" + this.NJGOLBEFEPJ.ToString());
		if (JLDHNMKCIGH != null)
		{
			yield return base.StartCoroutine(JLDHNMKCIGH);
		}
		if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.avatarPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAvatarPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleKeepAlivePack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.keepAlivePackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetKeepAlivePack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.IEADNMABIID.Add(LBGGLHDOICL);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAnthologyPreview2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			if (OMFEFBJKHJG.IPDGGPBONDP)
			{
				AssetAnthologyPreview2 assetAnthologyPreview = JLDHNMKCIGH.PCGAGHLGLIM<AssetAnthologyPreview2>();
				assetAnthologyPreview.CNBBGIPAMAG();
				this.anthologyPreview2AssetsMini.Add(assetAnthologyPreview);
			}
			else
			{
				this.anthologyPreview2Assets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAnthologyPreview2>());
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleIconsPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.iconsPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetIconsPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfilePack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			AssetProfilePack assetProfilePack = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfilePack>();
			this.profilePackAssets.Add(assetProfilePack);
			if (null != this.profileDataAsset && null != this.lobbyDataAsset)
			{
				this.profileDataAsset.FLPAEANKGLG(assetProfilePack, this.lobbyDataAsset.maxAnthologyIndex);
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveEventContent)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveEventContentAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveEventContent>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCollectableCard)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.collectableCardAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetCollectableCard>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveOfferContent)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveOfferContentAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveOfferContent>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchThumbnail)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchThumbnailAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchThumbnail>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchActors)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchActorsAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchActors>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleFrameContainer)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional frame container bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetFrameContainer assetFrameContainer = JLDHNMKCIGH.PCGAGHLGLIM<AssetFrameContainer>();
					if (null != assetFrameContainer)
					{
						if (assetFrameContainer.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Frame container asset index mismatch, correcting " + assetFrameContainer.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetFrameContainer.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						this.frameContainerAssets.Add(assetFrameContainer);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Frame container bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional lobby data 2 bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetLobbyData2 y = JLDHNMKCIGH.PCGAGHLGLIM<AssetLobbyData2>();
					if (null != y)
					{
						this.lobbyDataAsset2 = y;
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Lobby data 2 bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData6)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional profile data 6 bundle (live profile theme thumbnails) failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetProfileData6 y2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData6>();
					if (null != y2)
					{
						this.profileDataAsset6 = y2;
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Profile data 6 bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm3)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLiveProfileTheme)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.liveProfileThemesAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetLiveProfileTheme>());
			this.liveProfileThemesVersion++;
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomEffects)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional custom effects bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetCustomEffects assetCustomEffects = JLDHNMKCIGH.PCGAGHLGLIM<AssetCustomEffects>();
					if (null != assetCustomEffects)
					{
						if (assetCustomEffects.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Custom effects asset index mismatch, correcting " + assetCustomEffects.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetCustomEffects.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						this.customEffectsAssets.Add(assetCustomEffects);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Custom effects bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm4)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleNpcAnimationPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional npc animation bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetStoryNpcAnimation assetStoryNpcAnimation = JLDHNMKCIGH.PCGAGHLGLIM<AssetStoryNpcAnimation>();
					if (null != assetStoryNpcAnimation)
					{
						if (assetStoryNpcAnimation.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Npc animation asset index mismatch, correcting " + assetStoryNpcAnimation.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetStoryNpcAnimation.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						assetStoryNpcAnimation.PGFEFJDBIME();
						this.storyNpcAnimationAssets.Add(assetStoryNpcAnimation);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Npc animation bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm5)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleItemAnimationPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Optional item animation bundle failed to load, continuing without it:" + LBGGLHDOICL);
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				this.NJGOLBEFEPJ--;
			}
			else
			{
				try
				{
					AssetStoryItemAnimation assetStoryItemAnimation = JLDHNMKCIGH.PCGAGHLGLIM<AssetStoryItemAnimation>();
					if (null != assetStoryItemAnimation)
					{
						if (assetStoryItemAnimation.index != OMFEFBJKHJG.GGICIBLJIKI)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("Item animation asset index mismatch, correcting " + assetStoryItemAnimation.index.ToString() + " to bundle index:" + OMFEFBJKHJG.GGICIBLJIKI.ToString());
							assetStoryItemAnimation.index = OMFEFBJKHJG.GGICIBLJIKI;
						}
						assetStoryItemAnimation.PGFEFJDBIME();
						this.storyItemAnimationAssets.Add(assetStoryItemAnimation);
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Item animation bundle loaded but its asset is missing or mis-named:" + LBGGLHDOICL);
					}
				}
				catch (Exception aklgbjkdomm6)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
				}
				this.FPKDPDLNDKH.IFJCIJOBDFO(1);
				DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
				AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
				this.NJGOLBEFEPJ--;
			}
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleCustomFader)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.customFaderAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetCustomFader>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleLobbyData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.lobbyDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetLobbyData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleSketchesData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.sketchesDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetSketchesData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData2>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData3)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset3 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData3>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData4)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset4 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData4>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileData5)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataAsset5 = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileData5>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleProfileDataLocalized)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.profileDataLocalizedAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetProfileDataLocalized>();
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.headersPackAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetHeadersPack>();
			for (int i = 0; i < this.headersPackAsset.anthologiesList.Count; i++)
			{
				if (null != this.headersPackAsset.anthologiesList[i])
				{
					AssetAnthology assetAnthology = this.headersPackAsset.anthologiesList[i];
					GKJPOGNFKNK.PANECPKKMLJ(assetAnthology);
					if (assetAnthology.FMJONLDHPHN(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
					{
						this.FCGAFGDJHFF(assetAnthology);
					}
				}
			}
			for (int j = 0; j < this.headersPackAsset.storyHeadersList.Count; j++)
			{
				if (null != this.headersPackAsset.storyHeadersList[j])
				{
					this.NONGBOJEOAK(this.headersPackAsset.storyHeadersList[j]);
				}
			}
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleHeadersPack2)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.headersPackAsset2 = JLDHNMKCIGH.PCGAGHLGLIM<AssetHeadersPack2>();
			for (int k = 0; k < this.headersPackAsset2.anthologiesList.Count; k++)
			{
				if (null != this.headersPackAsset2.anthologiesList[k])
				{
					AssetAnthology assetAnthology2 = this.headersPackAsset2.anthologiesList[k];
					GKJPOGNFKNK.PANECPKKMLJ(assetAnthology2);
					if (assetAnthology2.FMJONLDHPHN(LanguageManager.EHBBFMCILPC.GetSelectedLanguage().ToString()))
					{
						this.FCGAFGDJHFF(assetAnthology2);
					}
				}
			}
			for (int l = 0; l < this.headersPackAsset2.storyHeadersList.Count; l++)
			{
				if (null != this.headersPackAsset2.storyHeadersList[l])
				{
					this.NONGBOJEOAK(this.headersPackAsset2.storyHeadersList[l]);
				}
			}
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleAvatarExtensionPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.avatarExtensionPackAssets.Add(JLDHNMKCIGH.PCGAGHLGLIM<AssetAvatarExtensionPack>());
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else if (OMFEFBJKHJG.OBKCKGHFMDN == NMKDCBPMCKI.AssetBundleTextPack)
		{
			if (JLDHNMKCIGH == null || JLDHNMKCIGH.HJOPIMGMGML())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Critical error, could not load asset bundle:" + LBGGLHDOICL);
				this.DLFNGJILCEH = JLINKDNLADM.Failed;
				this.NJGOLBEFEPJ--;
				yield break;
			}
			this.textPackAsset = JLDHNMKCIGH.PCGAGHLGLIM<AssetTextPack>();
			for (int m = 0; m < this.textPackAsset.textAssetsCollection.Count; m++)
			{
				for (int n = 0; n < this.textPackAsset.textAssetsCollection[m].textAssets.Count; n++)
				{
					GKJPOGNFKNK.GIMAJLEGGHF(this.textPackAsset.textAssetsCollection[m].nameHint, this.textPackAsset.textAssetsCollection[m].textAssets[n]);
				}
			}
			this.FPKDPDLNDKH.IFJCIJOBDFO(1);
			DPGJIJGOCIC.NFIDPOMCNLP("Loaded asset bundle:" + LBGGLHDOICL);
			AssetBundleManager.UnloadAssetBundle(LBGGLHDOICL, false);
			this.NJGOLBEFEPJ--;
		}
		else
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Critical error, type not implemented in ProcessAssetBundleLoadAssetOperationRequest():" + OMFEFBJKHJG.OBKCKGHFMDN.ToString());
			this.NJGOLBEFEPJ--;
		}
		yield break;
	}

	// Token: 0x060060FE RID: 24830 RVA: 0x002C4638 File Offset: 0x002C2838
	public bool JMHKBKKEJCG(int MEFKFOHCOHK)
	{
		bool result;
		try
		{
			if (MEFKFOHCOHK < 1)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("avts2" + MEFKFOHCOHK.ToString());
				result = true;
			}
			else if (KDCJJBLGCBH.EHBBFMCILPC != null && KDCJJBLGCBH.EHBBFMCILPC.AJNJENAFLPP())
			{
				result = true;
			}
			else if (KHPGPLAMAIN.KPIFAEEPHPH())
			{
				result = false;
			}
			else if (KHPGPLAMAIN.AKJOFJPLONG() == IIHCCPLGGHP.lowEnd)
			{
				result = false;
			}
			else if (this.IFJCIJOBDFO(NMKDCBPMCKI.AssetBundleTextPack, MEFKFOHCOHK, false))
			{
				result = true;
			}
			else
			{
				this.QueueAssetBundleDownload((NMKDCBPMCKI)102, MEFKFOHCOHK, -1, FLDBFOADFLH.startDownloadAndProceed, true, false, true, null, -1, false, "a", false, true);
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x060060FF RID: 24831 RVA: 0x002C2C43 File Offset: 0x002C0E43
	private IEnumerator ICGMLNEIPCL()
	{
		AssetsManager.GDELPKNPMJC gdelpknpmjc = new AssetsManager.GDELPKNPMJC(1);
		gdelpknpmjc.<>4__this = this;
		return gdelpknpmjc;
	}

	// Token: 0x06006100 RID: 24832 RVA: 0x002C03D6 File Offset: 0x002BE5D6
	private IEnumerator KNPIMINGDEA()
	{
		if (!this.AKCDHJCIJCG)
		{
			NPOILPKELOJ.LKNKIODCMFJ();
			this.POOGGCLFKMI = true;
			for (int i = 0; i < 50; i++)
			{
				this.DestroyAssetBundleAssets((NMKDCBPMCKI)i, -1);
			}
			this.UnloadPersistentAssetBundles();
			AssetBundleManager.UnloadAllAssetBundles();
			if (this.OOKEOHFPOKN)
			{
				AssetBundle.UnloadAllAssetBundles(true);
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("cleancachebody"), DFGILFBGPLN.popupTools, 0f, 28);
				yield return new WaitForSeconds(1f);
				Caching.ClearCache();
				yield return new WaitForSeconds(1f);
				CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
				this.OOKEOHFPOKN = false;
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupTwoOverride(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredtitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("restartrequiredbody"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("continue"), new UnityAction(this.GMADGCBOAJF), new UnityAction(this.GMADGCBOAJF), DFGILFBGPLN.popupEnergyHint, 0f, 28);
				CommonUserInterface.EHBBFMCILPC.HideConnectingAnimation();
				yield return new WaitForSeconds(31536000f);
			}
		}
		AssetBundleManager.LogLoadedAssetBundlesCount();
		this.BKKBJOOOEBO = true;
		if (this.OKMBMHIKIBC.Length != 0)
		{
			AssetBundleManager.SetSourceAssetBundleURL(this.OKMBMHIKIBC, DPGJIJGOCIC.POHBFGLLKFD(this.CLBECEDIAAB));
			if (NPOILPKELOJ.MMANKOLKKMG)
			{
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeout.ToString(), "", false, false);
				NPOILPKELOJ.MMANKOLKKMG = false;
				FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.issueRepCdn.ToString(), FFPHBMFGCNN.cdnCmnTimeoutRetry.ToString(), NPOILPKELOJ.BGPKAOFOHHB.ToString() ?? "", false, false);
				if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
				{
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("commonbundlehint"), DFGILFBGPLN.popupTools, 0f, 28);
				}
			}
			IEnumerator enumerator = AssetBundleManager.Initialize(LNDOOJOFFOM.Common.ToString(), 0);
			if (enumerator != null)
			{
				yield return base.StartCoroutine(enumerator);
			}
			PLOGDOACBMK assetBundleLoadManifestOperation = AssetBundleManager.GetAssetBundleLoadManifestOperation();
			if (assetBundleLoadManifestOperation == null || assetBundleLoadManifestOperation.HJOPIMGMGML())
			{
				this.AKCDHJCIJCG = false;
				if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
				{
					this.LEOFIDDNKAF.Next(this.OKMBMHIKIBC);
					this.BLHLMFJOCFP();
				}
			}
			else
			{
				this.AKCDHJCIJCG = true;
			}
			AssetBundleManager.ResetAssetBundleLoadManifestOperation();
			this.BKKBJOOOEBO = false;
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
			yield break;
		}
		this.AKCDHJCIJCG = false;
		this.BKKBJOOOEBO = false;
		yield break;
	}

	// Token: 0x06006101 RID: 24833 RVA: 0x002C46D8 File Offset: 0x002C28D8
	public void UnregisterStoryAssets(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				this.storyAssets.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06006102 RID: 24834 RVA: 0x002C471C File Offset: 0x002C291C
	public string IBMEDDLJIMI()
	{
		try
		{
			string text = this.OKMBMHIKIBC;
			if (text.Length > 1)
			{
				text = text.Replace("eventended", "hofcoff").Replace("CLIENT.AVATAR.HAIR", "CACHE API (fallback)");
				if (text.Contains("SceneStoryAssetPackSharedClient"))
				{
					text = text.Substring(0, text.IndexOf("[LoadingEnv] cache file of "));
				}
				if (text.Length > 1 && text.Contains("<b>"))
				{
					text = text.Substring(0, text.LastIndexOf("energyhinttitle"));
				}
				return text.Replace("YYY", "p").Replace("spld", "OnLobbySkinShopCdnFailed");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return "rain";
	}

	// Token: 0x06006103 RID: 24835 RVA: 0x002C47E8 File Offset: 0x002C29E8
	public bool OLIJIKAILEH()
	{
		return !this.LEOFIDDNKAF.NMNNKDDAOCH();
	}

	// Token: 0x06006104 RID: 24836 RVA: 0x002C47F8 File Offset: 0x002C29F8
	public void TryPingDepotDefaultUrls()
	{
		if (GeoLocationManager.GeoZoneMayBeFirewalled(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) && !this.LEOFIDDNKAF.IsInitialized())
		{
			DPGJIJGOCIC.NFIDPOMCNLP("AssetsManager.TryPingDepotDefaultUrls(): urlPingManager.StartPing()");
			this.LEOFIDDNKAF.StartPing(this.DGAICDDKDGJ, KBOJLHAJPCP.FDLNHBCAABL, KBOJLHAJPCP.GAIHNCBGMJP, KBOJLHAJPCP.CFIFJGMDNFN, KBOJLHAJPCP.IBEDCNNJBJB, KBOJLHAJPCP.COLJLNNOMGL);
		}
	}

	// Token: 0x06006106 RID: 24838 RVA: 0x002BD44D File Offset: 0x002BB64D
	public bool NCPAKFHGICE()
	{
		return this.anthologyPreview2Assets.Count > 1;
	}

	// Token: 0x06006107 RID: 24839 RVA: 0x000FAFD0 File Offset: 0x000F91D0
	private void KJOEFINANHM()
	{
		Application.Quit();
	}

	// Token: 0x06006108 RID: 24840 RVA: 0x002C4864 File Offset: 0x002C2A64
	private int ENBMIOLCFBO()
	{
		if (this.GPKCJNEIHBH)
		{
			DPGJIJGOCIC.ADFCDFHBDAF(">");
			return 1;
		}
		int num;
		if (KHPGPLAMAIN.IBFFFCIPOJC() == IIHCCPLGGHP.highEnd)
		{
			num = this.CAACJIOPDOO;
		}
		else if (KHPGPLAMAIN.CIEILKHLDCG() == IIHCCPLGGHP.highEnd)
		{
			num = this.CAACJIOPDOO / 2;
		}
		else
		{
			num = this.CAACJIOPDOO / 6;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			num /= (int)NPOILPKELOJ.IKDKDPNCJBO;
		}
		if (num < 1)
		{
			num = 1;
		}
		if (NPOILPKELOJ.IKDKDPNCJBO != LKBEFCALCCC.unknown)
		{
			DPGJIJGOCIC.PJCLICBPPDA("OnApplicationRestart" + NPOILPKELOJ.IKDKDPNCJBO.ToString() + "passpricetitle" + num.ToString());
		}
		else
		{
			DPGJIJGOCIC.PJCLICBPPDA("PlayerCharacterManager.UpdateComponentLink() - skipping updating custom hierarchy for " + num.ToString());
		}
		return num;
	}

	// Token: 0x06006109 RID: 24841 RVA: 0x002C4914 File Offset: 0x002C2B14
	public void FKFDICNPNCG(string JEOKFNAFILA = null, string IOPJPDKHMDG = null, bool EAGAMDIOMEB = false)
	{
		if (this.DLFNGJILCEH == JLINKDNLADM.Progress)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("\n\n");
			return;
		}
		this.KAHJMAHGDFI = KGDFLLFLIPM.Busy;
		this.CFEJAMGNPAC("OnBackendPremiumChoiceException");
		this.MPEGJMEEIFA = JEOKFNAFILA;
		this.IDHIPDNNLIN = IOPJPDKHMDG;
		NPOILPKELOJ.DAEOMOJFKDN = true;
		this.EGLPBAJMOHJ = true;
		this.IOOFABBLGKE = EAGAMDIOMEB;
		this.ODDNKAMKHDA = DPGJIJGOCIC.MKJLJPMEPCC();
		base.StartCoroutine(this.MJGCKOIFLNK());
	}

	// Token: 0x0600610A RID: 24842 RVA: 0x002C4981 File Offset: 0x002C2B81
	public CutsceneViewManager GetCutsceneViewManager()
	{
		return this.cutsceneViewManager;
	}

	// Token: 0x0600610B RID: 24843 RVA: 0x002C498C File Offset: 0x002C2B8C
	public void QueueNpcAnimationBundles(AssetStoryHeader JFCABBGNNKJ, int OLKMHHNMDLP)
	{
		try
		{
			if (!(null == JFCABBGNNKJ) && JFCABBGNNKJ.chapterAssetPacks != null && OLKMHHNMDLP >= 0 && OLKMHHNMDLP < JFCABBGNNKJ.chapterAssetPacks.Count)
			{
				if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks != null)
				{
					if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.FNMKCHCBLLF())
					{
						if (!KHPGPLAMAIN.EJCNHEBIOJF())
						{
							if (KHPGPLAMAIN.IBDGNKGIMFI() != IIHCCPLGGHP.lowEnd)
							{
								for (int i = 0; i < JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks.Count; i++)
								{
									if (JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i] < 1)
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Invalid npc animation bundle index in story header, skipped:" + JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i].ToString());
									}
									else
									{
										this.QueueAssetBundleDownload(NMKDCBPMCKI.AssetBundleNpcAnimationPack, JFCABBGNNKJ.chapterAssetPacks[OLKMHHNMDLP].npcAnimationPacks[i], -1, FLDBFOADFLH.startDownloadAndProceed, false, false, false, null, -1, false, "", false, false);
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600610C RID: 24844 RVA: 0x002C4ACC File Offset: 0x002C2CCC
	public void RegisterStoryAssets(SceneStoryManager AJEAEPFPACP)
	{
		for (int i = 0; i < this.storyAssets.Count; i++)
		{
			if (this.storyAssets[i] == AJEAEPFPACP)
			{
				return;
			}
		}
		this.storyAssets.Add(AJEAEPFPACP);
	}

	// Token: 0x0600610D RID: 24845 RVA: 0x002C4B10 File Offset: 0x002C2D10
	private void FCGAFGDJHFF(AssetAnthology EPMNJLEBHND)
	{
		if (null == EPMNJLEBHND)
		{
			return;
		}
		if (AppManager.EHBBFMCILPC.UnsupportedRevision(EPMNJLEBHND.minRevision))
		{
			return;
		}
		for (int i = 0; i < this.anthologyAssets.Count; i++)
		{
			if (null != this.anthologyAssets[i] && this.anthologyAssets[i].header.index == EPMNJLEBHND.header.index)
			{
				return;
			}
		}
		this.anthologyAssets.Add(EPMNJLEBHND);
	}

	// Token: 0x04001B7A RID: 7034
	public static string cdnDepotForAnalytics = "";

	// Token: 0x04001B7B RID: 7035
	private float AAHOKPFGOBP = 2f;

	// Token: 0x04001B7C RID: 7036
	private string OKMBMHIKIBC = "";

	// Token: 0x04001B7D RID: 7037
	private JSONArray CLBECEDIAAB = new JSONArray();

	// Token: 0x04001B7E RID: 7038
	private bool POOGGCLFKMI = true;

	// Token: 0x04001B7F RID: 7039
	private JLINKDNLADM DLFNGJILCEH;

	// Token: 0x04001B80 RID: 7040
	private KGDFLLFLIPM KAHJMAHGDFI;

	// Token: 0x04001B81 RID: 7041
	private int EMOFAGMGIOI;

	// Token: 0x04001B82 RID: 7042
	private static AssetsManager IKLAPGJDMNA;

	// Token: 0x04001B83 RID: 7043
	private bool AKCDHJCIJCG;

	// Token: 0x04001B84 RID: 7044
	private bool OOKEOHFPOKN;

	// Token: 0x04001B85 RID: 7045
	private ICBGGEGIPPB FPKDPDLNDKH = new ICBGGEGIPPB();

	// Token: 0x04001B86 RID: 7046
	private List<OPMGJPHENFJ> MFPCGBNKHCC = new List<OPMGJPHENFJ>();

	// Token: 0x04001B87 RID: 7047
	public const string onAssetsManagerDownloadFailed = "OnAssetsManagerDownloadFailed";

	// Token: 0x04001B88 RID: 7048
	public const string onAssetsManagerDownloadSuccess = "OnAssetsManagerDownloadSuccess";

	// Token: 0x04001B89 RID: 7049
	private string IDHIPDNNLIN;

	// Token: 0x04001B8A RID: 7050
	private string MPEGJMEEIFA;

	// Token: 0x04001B8B RID: 7051
	private bool BKKBJOOOEBO;

	// Token: 0x04001B8C RID: 7052
	private List<string> IEADNMABIID = new List<string>();

	// Token: 0x04001B8D RID: 7053
	private List<string> EIJMNBNOKBC = new List<string>();

	// Token: 0x04001B8E RID: 7054
	private int NJGOLBEFEPJ;

	// Token: 0x04001B8F RID: 7055
	private bool EGLPBAJMOHJ;

	// Token: 0x04001B90 RID: 7056
	private string GCIIHKGFLFI = "";

	// Token: 0x04001B91 RID: 7057
	private string ODDNKAMKHDA = "";

	// Token: 0x04001B92 RID: 7058
	private int CAACJIOPDOO = 1;

	// Token: 0x04001B93 RID: 7059
	private bool GPKCJNEIHBH;

	// Token: 0x04001B94 RID: 7060
	private LNDOOJOFFOM GOBDKBEIPMC;

	// Token: 0x04001B95 RID: 7061
	private bool IOOFABBLGKE;

	// Token: 0x04001B96 RID: 7062
	private List<string> DGAICDDKDGJ = new List<string>
	{
		"https://1275736238.rsc.cdn77.org/",
		"https://cdn4.ysicdn.org/rc1os/",
		"https://cdn4.ysi88.ru/rc1os/",
		"https://rcm8dkfcdn77.b-cdn.net/",
		"https://pgvg79kzy3.a.trbcdn.net/rc1os/",
		"http://1275736238.rsc.cdn77.org/",
		"http://cdn4.ysicdn.org/rc1os/",
		"http://rcm8dkfcdn77.b-cdn.net/",
		"http://pgvg79kzy3.a.trbcdn.net/rc1os/",
		"https://s-dt2.cloud.edgecore.ru/rc1os/"
	};

	// Token: 0x04001B97 RID: 7063
	private UrlPingManager LEOFIDDNKAF;

	// Token: 0x04001B98 RID: 7064
	private int JNDGOONNLIA;

	// Token: 0x04001B99 RID: 7065
	[HideInInspector]
	public List<AssetStoryHeader> storyHeaderAssets = new List<AssetStoryHeader>();

	// Token: 0x04001B9A RID: 7066
	[HideInInspector]
	public List<AssetAvatarPack> avatarPackAssets = new List<AssetAvatarPack>();

	// Token: 0x04001B9B RID: 7067
	[HideInInspector]
	public List<AssetKeepAlivePack> keepAlivePackAssets = new List<AssetKeepAlivePack>();

	// Token: 0x04001B9C RID: 7068
	[HideInInspector]
	public List<AssetIconsPack> iconsPackAssets = new List<AssetIconsPack>();

	// Token: 0x04001B9D RID: 7069
	[HideInInspector]
	public List<AssetProfilePack> profilePackAssets = new List<AssetProfilePack>();

	// Token: 0x04001B9E RID: 7070
	[HideInInspector]
	public List<AssetAvatarExtensionPack> avatarExtensionPackAssets = new List<AssetAvatarExtensionPack>();

	// Token: 0x04001B9F RID: 7071
	[HideInInspector]
	public AssetTextPack textPackAsset;

	// Token: 0x04001BA0 RID: 7072
	[HideInInspector]
	public PurchasingViewManager purchasingViewManager;

	// Token: 0x04001BA1 RID: 7073
	[HideInInspector]
	public CutsceneViewManager cutsceneViewManager;

	// Token: 0x04001BA2 RID: 7074
	[HideInInspector]
	public SketchViewManager sketchViewManager;

	// Token: 0x04001BA3 RID: 7075
	[HideInInspector]
	public List<StorySplashManager> storySplashManagers = new List<StorySplashManager>();

	// Token: 0x04001BA4 RID: 7076
	[HideInInspector]
	public List<SceneAvatarManager> sceneAvatarManagers = new List<SceneAvatarManager>();

	// Token: 0x04001BA5 RID: 7077
	[HideInInspector]
	public List<SceneLoungeManager> sceneLoungeManagers = new List<SceneLoungeManager>();

	// Token: 0x04001BA6 RID: 7078
	[HideInInspector]
	public List<AssetAnthology> anthologyAssets = new List<AssetAnthology>();

	// Token: 0x04001BA7 RID: 7079
	[HideInInspector]
	public List<AssetAnthologyPreview2> anthologyPreview2Assets = new List<AssetAnthologyPreview2>();

	// Token: 0x04001BA8 RID: 7080
	[HideInInspector]
	public List<AssetAnthologyPreview2> anthologyPreview2AssetsMini = new List<AssetAnthologyPreview2>();

	// Token: 0x04001BA9 RID: 7081
	[HideInInspector]
	public List<AssetLiveEventContent> liveEventContentAssets = new List<AssetLiveEventContent>();

	// Token: 0x04001BAA RID: 7082
	[HideInInspector]
	public List<AssetCollectableCard> collectableCardAssets = new List<AssetCollectableCard>();

	// Token: 0x04001BAB RID: 7083
	[HideInInspector]
	public List<AssetLiveOfferContent> liveOfferContentAssets = new List<AssetLiveOfferContent>();

	// Token: 0x04001BAC RID: 7084
	[HideInInspector]
	public List<AssetSketchThumbnail> sketchThumbnailAssets = new List<AssetSketchThumbnail>();

	// Token: 0x04001BAD RID: 7085
	[HideInInspector]
	public List<AssetSketchActors> sketchActorsAssets = new List<AssetSketchActors>();

	// Token: 0x04001BAE RID: 7086
	[HideInInspector]
	public List<AssetLiveProfileTheme> liveProfileThemesAssets = new List<AssetLiveProfileTheme>();

	// Token: 0x04001BAF RID: 7087
	public int liveProfileThemesVersion;

	// Token: 0x04001BB0 RID: 7088
	[HideInInspector]
	public List<AssetCustomFader> customFaderAssets = new List<AssetCustomFader>();

	// Token: 0x04001BB1 RID: 7089
	[HideInInspector]
	public List<AssetCustomEffects> customEffectsAssets = new List<AssetCustomEffects>();

	// Token: 0x04001BB2 RID: 7090
	[HideInInspector]
	public List<AssetStoryNpcAnimation> storyNpcAnimationAssets = new List<AssetStoryNpcAnimation>();

	// Token: 0x04001BB3 RID: 7091
	[HideInInspector]
	public List<AssetStoryItemAnimation> storyItemAnimationAssets = new List<AssetStoryItemAnimation>();

	// Token: 0x04001BB4 RID: 7092
	[HideInInspector]
	public List<AssetFrameContainer> frameContainerAssets = new List<AssetFrameContainer>();

	// Token: 0x04001BB5 RID: 7093
	[HideInInspector]
	public AssetHeadersPack headersPackAsset;

	// Token: 0x04001BB6 RID: 7094
	[HideInInspector]
	public AssetHeadersPack2 headersPackAsset2;

	// Token: 0x04001BB7 RID: 7095
	[HideInInspector]
	public AssetLobbyData lobbyDataAsset;

	// Token: 0x04001BB8 RID: 7096
	[HideInInspector]
	public AssetLobbyData2 lobbyDataAsset2;

	// Token: 0x04001BB9 RID: 7097
	[HideInInspector]
	public AssetSketchesData sketchesDataAsset;

	// Token: 0x04001BBA RID: 7098
	[HideInInspector]
	public AssetProfileData profileDataAsset;

	// Token: 0x04001BBB RID: 7099
	[HideInInspector]
	public AssetProfileData2 profileDataAsset2;

	// Token: 0x04001BBC RID: 7100
	[HideInInspector]
	public AssetProfileData3 profileDataAsset3;

	// Token: 0x04001BBD RID: 7101
	[HideInInspector]
	public AssetProfileData4 profileDataAsset4;

	// Token: 0x04001BBE RID: 7102
	[HideInInspector]
	public AssetProfileData5 profileDataAsset5;

	// Token: 0x04001BBF RID: 7103
	[HideInInspector]
	public AssetProfileData6 profileDataAsset6;

	// Token: 0x04001BC0 RID: 7104
	[HideInInspector]
	public AssetProfileDataLocalized profileDataLocalizedAsset;

	// Token: 0x04001BC1 RID: 7105
	[HideInInspector]
	public List<SceneStoryManager> storyAssets = new List<SceneStoryManager>();

	// Token: 0x04001BC2 RID: 7106
	[HideInInspector]
	public List<AssetStoryNpc> lobbyLoungeNpcAssets = new List<AssetStoryNpc>();

	// Token: 0x04001BC3 RID: 7107
	public GameObject playerCharacterPrefab;

	// Token: 0x04001BC4 RID: 7108
	public GameObject nonPlayerCharacterPrefab;

	// Token: 0x04001BC5 RID: 7109
	public GameObject playerCharacterRenderTexturePrefab;

	// Token: 0x04001BC6 RID: 7110
	public GameObject nonPlayerCharacterRenderTexturePrefab;
}
