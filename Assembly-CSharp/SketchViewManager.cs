using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000319 RID: 793
public class SketchViewManager : MonoBehaviour
{
	// Token: 0x06005F5C RID: 24412 RVA: 0x002B1510 File Offset: 0x002AF710
	private float PPBCDDKOHFP(string EPBDEELOHOI, FCABOFEGPGP OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 1; i < this.KEPHFKAHILM.Count; i += 0)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].EFOHNEBHEEO(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j += 0)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("wind" + EPBDEELOHOI + "OnPopupCardOptionsBackClickLobby");
		return 929f;
	}

	// Token: 0x06005F5D RID: 24413 RVA: 0x002B15CC File Offset: 0x002AF7CC
	private void HLBIEIAFBFK()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.ShowAllEffectsWithTag("");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
	}

	// Token: 0x06005F5E RID: 24414 RVA: 0x000693D6 File Offset: 0x000675D6
	public void NILEOAFAEFC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06005F5F RID: 24415 RVA: 0x002B1619 File Offset: 0x002AF819
	private void CIDNAMNICJI()
	{
		this.Hide(true);
	}

	// Token: 0x06005F60 RID: 24416 RVA: 0x002B1619 File Offset: 0x002AF819
	private void PGEEMANJOHD()
	{
		this.Hide(true);
	}

	// Token: 0x06005F61 RID: 24417 RVA: 0x002B1624 File Offset: 0x002AF824
	private void OnDestroy()
	{
		if (this.JGGGNGEFDJG != null)
		{
			base.StopCoroutine(this.JGGGNGEFDJG);
		}
		this.JGGGNGEFDJG = null;
		this.KIDLCBGDMJB = null;
		this.GLGKHNLBELI = null;
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		this.FJIBKABPIGJ = null;
		this.GFFLNCOEEKP.DOKill(false);
		this.MGDOAFNHBHP.DOKill(false);
	}

	// Token: 0x06005F62 RID: 24418 RVA: 0x002B16B2 File Offset: 0x002AF8B2
	private void MGCNIABEDNL()
	{
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("OnPopupStoryRestartManagerRestartStory", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.BIAEAOMHBMM().MFIMALJPCDP("OnRequestCheckForUpdatesException", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06005F63 RID: 24419 RVA: 0x002B16EC File Offset: 0x002AF8EC
	private void DJNJCGFBFBA()
	{
		ODJKHCHFKNL.LAEBOGKCLGE((DFGILFBGPLN)(-33));
		this.content.SetActive(true);
		base.gameObject.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().CMMAMILHPFP(null);
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("giftcardsstockempty", 1903f);
	}

	// Token: 0x06005F64 RID: 24420 RVA: 0x002B173C File Offset: 0x002AF93C
	private void EPMCPFDGPEC()
	{
		VideoContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].name.EndsWith("Bundles"))
			{
				array[i].transform.SetParent(this.content.transform, false);
			}
		}
	}

	// Token: 0x06005F65 RID: 24421 RVA: 0x002B1799 File Offset: 0x002AF999
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnVideoLayerPlaybackEndsSoon", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06005F66 RID: 24422 RVA: 0x002B17D4 File Offset: 0x002AF9D4
	private float MEEKOPBHLDB(string EPBDEELOHOI, PHALBCMBPPL OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].SetPositionVertical(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].SetPositionVertical(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. MoveEnvironmentVertical(), environment " + EPBDEELOHOI + " not found.");
		return 0f;
	}

	// Token: 0x06005F67 RID: 24423 RVA: 0x002B1890 File Offset: 0x002AFA90
	private void GFEKNLLBIJJ(string EPBDEELOHOI)
	{
		for (int i = 1; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
		}
		for (int j = 1; j < this.KEPHFKAHILM.Count; j++)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(true);
			}
		}
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].PILPDIDOLPE();
				this.KEPHFKAHILM[k].gameObject.SetActive(false);
				break;
			}
		}
		for (int l = 1; l < this.CHHIBBOICAD.Count; l++)
		{
			if (this.CHHIBBOICAD[l].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.CHHIBBOICAD[l].PKLKLBLPGCO();
				this.CHHIBBOICAD[l].gameObject.SetActive(false);
				return;
			}
		}
		try
		{
			for (int m = 1; m < this.CHHIBBOICAD.Count; m += 0)
			{
				for (int n = 1; n < this.CHHIBBOICAD[m].mappings.Count; n += 0)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Character " + EPBDEELOHOI + "xx" + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num += 0)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(true);
							}
						}
						for (int num2 = 0; num2 < this.KEPHFKAHILM.Count; num2 += 0)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(false);
							}
						}
						for (int num3 = 1; num3 < this.KEPHFKAHILM.Count; num3++)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].PKLKLBLPGCO();
								this.KEPHFKAHILM[num3].gameObject.SetActive(false);
								break;
							}
						}
						for (int num4 = 1; num4 < this.CHHIBBOICAD.Count; num4 += 0)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.CHHIBBOICAD[num4].OptimizeParticleSystems();
								this.CHHIBBOICAD[num4].gameObject.SetActive(false);
								return;
							}
						}
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("XXX" + EPBDEELOHOI + "");
		if (!EPBDEELOHOI.Equals("OnLoungeUnlockNpcSkinException"))
		{
			this.MEBPBAJKLAP("<align=\"left\"><alpha=#FF>\n\n");
		}
	}

	// Token: 0x06005F68 RID: 24424 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x06005F69 RID: 24425 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06005F6A RID: 24426 RVA: 0x002B1C48 File Offset: 0x002AFE48
	private void CNENCIIEDAP()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.popupBonusEpisodeWarning);
		this.content.SetActive(true);
		base.gameObject.SetActive(true);
		CommonUserInterface.EHBBFMCILPC.GetFader().GLCPCAHKFOB(null);
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("rand", 890f);
	}

	// Token: 0x06005F6B RID: 24427 RVA: 0x002B1C98 File Offset: 0x002AFE98
	private void NHHBKHNBKBC(string EPBDEELOHOI)
	{
		for (int i = 1; i < this.CHHIBBOICAD.Count; i += 0)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
		}
		for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(true);
			}
		}
		for (int k = 1; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].PKLKLBLPGCO();
				this.KEPHFKAHILM[k].gameObject.SetActive(false);
				break;
			}
		}
		for (int l = 0; l < this.CHHIBBOICAD.Count; l++)
		{
			if (this.CHHIBBOICAD[l].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.CHHIBBOICAD[l].KBKNCNIJJNB();
				this.CHHIBBOICAD[l].gameObject.SetActive(false);
				return;
			}
		}
		try
		{
			for (int m = 0; m < this.CHHIBBOICAD.Count; m++)
			{
				for (int n = 1; n < this.CHHIBBOICAD[m].mappings.Count; n++)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("OnChapterSnapshotsBackendFetchException" + EPBDEELOHOI + "OnStoryInterfaceFastForwardStop" + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num += 0)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(false);
							}
						}
						for (int num2 = 1; num2 < this.KEPHFKAHILM.Count; num2++)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(true);
							}
						}
						for (int num3 = 1; num3 < this.KEPHFKAHILM.Count; num3 += 0)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].KBKNCNIJJNB();
								this.KEPHFKAHILM[num3].gameObject.SetActive(false);
								break;
							}
						}
						for (int num4 = 0; num4 < this.CHHIBBOICAD.Count; num4++)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.CHHIBBOICAD[num4].OptimizeParticleSystems();
								this.CHHIBBOICAD[num4].gameObject.SetActive(false);
								return;
							}
						}
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnLobbyStoryManagerDownloadSplashScreenSuccess" + EPBDEELOHOI + "");
		if (!EPBDEELOHOI.Equals("mfs"))
		{
			this.GFEKNLLBIJJ("bdid");
		}
	}

	// Token: 0x06005F6C RID: 24428 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	private bool BFOEOHEAPEK(bool OFJLCKMOELF)
	{
		return false;
	}

	// Token: 0x06005F6D RID: 24429 RVA: 0x002B2050 File Offset: 0x002B0250
	private void EKOJFMLPNGJ()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("friendsmaxlimitdefaultfp", new UnityAction(this.PGEEMANJOHD));
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("scene ", new UnityAction(this.CIDNAMNICJI));
	}

	// Token: 0x06005F6E RID: 24430 RVA: 0x002B2088 File Offset: 0x002B0288
	private void CJOOOIECMAE()
	{
		this.GFFLNCOEEKP = this.environmentsBackPivot.GetComponent<RectTransform>();
		this.MGDOAFNHBHP = this.environmentsFrontPivot.GetComponent<RectTransform>();
	}

	// Token: 0x06005F6F RID: 24431 RVA: 0x002B20AC File Offset: 0x002B02AC
	private float IPKBFLAIAHB(string EPBDEELOHOI, FCABOFEGPGP OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 1; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j += 0)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("InitStoryChapterInformation() - currentAnthology is null." + EPBDEELOHOI + " ");
		return 1949f;
	}

	// Token: 0x06005F70 RID: 24432 RVA: 0x002B2167 File Offset: 0x002B0367
	private void ADCNNKDPHLI()
	{
		this.JGGGNGEFDJG = base.StartCoroutine(this.BFECJKPHEJL());
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x002B1619 File Offset: 0x002AF819
	private void FOGNNOAFMMC()
	{
		this.Hide(true);
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x002B217C File Offset: 0x002B037C
	private void MEBPBAJKLAP(string EPBDEELOHOI)
	{
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
		}
		for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(false);
			}
		}
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].OptimizeParticleSystems();
				this.KEPHFKAHILM[k].gameObject.SetActive(true);
				break;
			}
		}
		for (int l = 0; l < this.CHHIBBOICAD.Count; l++)
		{
			if (this.CHHIBBOICAD[l].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.CHHIBBOICAD[l].OptimizeParticleSystems();
				this.CHHIBBOICAD[l].gameObject.SetActive(true);
				return;
			}
		}
		try
		{
			for (int m = 0; m < this.CHHIBBOICAD.Count; m++)
			{
				for (int n = 0; n < this.CHHIBBOICAD[m].mappings.Count; n++)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("Environment " + EPBDEELOHOI + " not found, replacing with " + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num++)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(false);
							}
						}
						for (int num2 = 0; num2 < this.KEPHFKAHILM.Count; num2++)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(false);
							}
						}
						for (int num3 = 0; num3 < this.KEPHFKAHILM.Count; num3++)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].OptimizeParticleSystems();
								this.KEPHFKAHILM[num3].gameObject.SetActive(true);
								break;
							}
						}
						for (int num4 = 0; num4 < this.CHHIBBOICAD.Count; num4++)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.CHHIBBOICAD[num4].OptimizeParticleSystems();
								this.CHHIBBOICAD[num4].gameObject.SetActive(true);
								return;
							}
						}
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowEnvironment(), environment " + EPBDEELOHOI + " not found.");
		if (!EPBDEELOHOI.Equals("default"))
		{
			this.MEBPBAJKLAP("default");
		}
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x002B2534 File Offset: 0x002B0734
	public void Show(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM)
	{
		this.OPCNCJLMHAP = OBOOCMMCPNL;
		this.GLGKHNLBELI = CJPACBBNKCM;
		this.KIDLCBGDMJB = DPPMPNEOPNF.JHJMDJGEHDK(OBOOCMMCPNL, CJPACBBNKCM);
		this.JEJJOGFIOKA = false;
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenSketch);
		base.gameObject.SetActive(true);
		this.content.SetActive(true);
		StoryEnvironmentLayerManager.SetLayersSystemVersion(3);
		this.LFFONLGJFBH();
		this.BKBBPLJOLGM();
		this.EPMCPFDGPEC();
		this.MEBPBAJKLAP(this.MBNLJJPBGBP().IBFLNCMCKAL);
		if (this.MBNLJJPBGBP().LDECHKECBHB != FCABOFEGPGP.center)
		{
			this.NFGHFMEEBHN(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().LDECHKECBHB, DBONHDHEKDG.immediate, Ease.InOutSine);
		}
		if (this.MBNLJJPBGBP().ONNHAPFMDEN != PHALBCMBPPL.center)
		{
			this.MEEKOPBHLDB(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().ONNHAPFMDEN, DBONHDHEKDG.immediate, Ease.InOutSine);
		}
		float lnaoahmajkn = 0f;
		this.HLBIEIAFBFK();
		this.AMBEPJCICOF();
		base.StartCoroutine(this.GLNGPMHCOEC(lnaoahmajkn));
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socCut.ToString(), BGHLMGPPCNN.socCutView.ToString(), false, false);
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x002B2662 File Offset: 0x002B0862
	private void KHOLJLKNAPJ()
	{
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP(" took ", new UnityAction(this.LCGMBMOJHIN));
		AOBJLALDBAA.AGANFKKBPFO().FNMOFCMDFJP("ZZZ", new UnityAction(this.CIDNAMNICJI));
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x002B269A File Offset: 0x002B089A
	private void HGFJJFKDBFI()
	{
		this.Hide(false);
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x002B26A3 File Offset: 0x002B08A3
	private IEnumerator GLNGPMHCOEC(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		if (this.MBNLJJPBGBP().FONKDFDJFEL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(this.MBNLJJPBGBP().FONKDFDJFEL, true, 1f, false);
		}
		if (this.MBNLJJPBGBP().JLEAIJGBGHL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfxNoLoop(this.MBNLJJPBGBP().JLEAIJGBGHL, false, -1f, -1f);
		}
		this.BFOEOHEAPEK(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.ADCNNKDPHLI));
		yield break;
	}

	// Token: 0x06005F77 RID: 24439 RVA: 0x002B26BC File Offset: 0x002B08BC
	private float NFGHFMEEBHN(string EPBDEELOHOI, FCABOFEGPGP OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 0; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].SetPosition(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("Error. MoveEnvironment(), environment " + EPBDEELOHOI + " not found.");
		return 0f;
	}

	// Token: 0x06005F78 RID: 24440 RVA: 0x002B2088 File Offset: 0x002B0288
	private void Awake()
	{
		this.GFFLNCOEEKP = this.environmentsBackPivot.GetComponent<RectTransform>();
		this.MGDOAFNHBHP = this.environmentsFrontPivot.GetComponent<RectTransform>();
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x002B2778 File Offset: 0x002B0978
	private void LFFONLGJFBH()
	{
		SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].environmentsBackList.Count; j++)
			{
				if (null != array[i].environmentsBackList[j])
				{
					array[i].environmentsBackList[j].transform.SetParent(this.environmentsBackPivot.transform, false);
					this.CHHIBBOICAD.Add(array[i].environmentsBackList[j]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsBackList[j] is null!");
				}
			}
			for (int k = 0; k < array[i].environmentsFrontList.Count; k++)
			{
				if (null != array[i].environmentsFrontList[k])
				{
					array[i].environmentsFrontList[k].transform.SetParent(this.environmentsFrontPivot.transform, false);
					this.KEPHFKAHILM.Add(array[i].environmentsFrontList[k]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsFrontList[j] is null!");
				}
			}
			for (int l = 0; l < array[i].environmentsLayersList.Count; l++)
			{
				if (null != array[i].environmentsLayersList[l])
				{
					this.FAEEEHDCNDN.Add(array[i].environmentsLayersList[l]);
					if (null != this.sharedLayersFrontPivot && array[i].environmentsLayersList[l].isShared)
					{
						array[i].environmentsLayersList[l].transform.SetParent(this.sharedLayersFrontPivot.transform, false);
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].environmentsFrontList[j] is null!");
				}
			}
			for (int m = 0; m < array[i].storyItemsAssets.Count; m++)
			{
				if (null != array[i].storyItemsAssets[m])
				{
					this.BAFONBJIKLA.Add(array[i].storyItemsAssets[m]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].storyItemsAssets[j] is null!");
				}
			}
			for (int n = 0; n < array[i].storyNpcAssets.Count; n++)
			{
				if (null != array[i].storyNpcAssets[n])
				{
					this.ODNCKIKLFCM.Add(array[i].storyNpcAssets[n]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("storyAssetPackManager[i].storyNpcAssets[j] is null!");
				}
			}
			if (array[i].chapterInk != null)
			{
				this.FJIBKABPIGJ = array[i].chapterInk;
			}
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x002B2A24 File Offset: 0x002B0C24
	private void LHANLCDCAEB(string EPBDEELOHOI)
	{
		for (int i = 0; i < this.CHHIBBOICAD.Count; i += 0)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(true);
			}
		}
		for (int j = 1; j < this.KEPHFKAHILM.Count; j++)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(true);
			}
		}
		for (int k = 1; k < this.KEPHFKAHILM.Count; k += 0)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].PILPDIDOLPE();
				this.KEPHFKAHILM[k].gameObject.SetActive(false);
				break;
			}
		}
		for (int l = 0; l < this.CHHIBBOICAD.Count; l += 0)
		{
			if (this.CHHIBBOICAD[l].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.CHHIBBOICAD[l].KBKNCNIJJNB();
				this.CHHIBBOICAD[l].gameObject.SetActive(true);
				return;
			}
		}
		try
		{
			for (int m = 1; m < this.CHHIBBOICAD.Count; m += 0)
			{
				for (int n = 1; n < this.CHHIBBOICAD[m].mappings.Count; n += 0)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.PJCLICBPPDA("p" + EPBDEELOHOI + "ok" + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 1; num < this.CHHIBBOICAD.Count; num += 0)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(false);
							}
						}
						for (int num2 = 1; num2 < this.KEPHFKAHILM.Count; num2 += 0)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(false);
							}
						}
						for (int num3 = 1; num3 < this.KEPHFKAHILM.Count; num3 += 0)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].KBKNCNIJJNB();
								this.KEPHFKAHILM[num3].gameObject.SetActive(false);
								break;
							}
						}
						for (int num4 = 1; num4 < this.CHHIBBOICAD.Count; num4 += 0)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.CHHIBBOICAD[num4].PKLKLBLPGCO();
								this.CHHIBBOICAD[num4].gameObject.SetActive(true);
								return;
							}
						}
						break;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		DPGJIJGOCIC.ANOPFDLPKGC("aind" + EPBDEELOHOI + "");
		if (!EPBDEELOHOI.Equals("importanttitle"))
		{
			this.NHHBKHNBKBC("");
		}
	}

	// Token: 0x06005F7C RID: 24444 RVA: 0x002B2DE8 File Offset: 0x002B0FE8
	private float JHDOMNDEBFP(string EPBDEELOHOI, FCABOFEGPGP OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 0; i < this.KEPHFKAHILM.Count; i++)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].MCKBGLNBBBP(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 1; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].MCKBGLNBBBP(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("OnPopupStoryRestartManagerRestartStory0" + EPBDEELOHOI + "");
		return 1895f;
	}

	// Token: 0x06005F7D RID: 24445 RVA: 0x002B2EA3 File Offset: 0x002B10A3
	private IEnumerator MOGFCJLALIF()
	{
		float seconds = 0f;
		if (this.MBNLJJPBGBP().LDECHKECBHB != this.MBNLJJPBGBP().EHPIMACBDLM)
		{
			seconds = this.NFGHFMEEBHN(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().EHPIMACBDLM, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield return new WaitForSeconds(seconds);
		if (this.MBNLJJPBGBP().ONNHAPFMDEN != this.MBNLJJPBGBP().JKAHANJANEI)
		{
			this.MEEKOPBHLDB(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().JKAHANJANEI, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield break;
	}

	// Token: 0x06005F7E RID: 24446 RVA: 0x002B2EB4 File Offset: 0x002B10B4
	private void KGPNJMEGMLN()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.screenSketch);
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnSketchViewLeft", 0f);
	}

	// Token: 0x06005F7F RID: 24447 RVA: 0x002B26A3 File Offset: 0x002B08A3
	private IEnumerator JPNDAGIFKDG(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		if (this.MBNLJJPBGBP().FONKDFDJFEL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(this.MBNLJJPBGBP().FONKDFDJFEL, true, 1f, false);
		}
		if (this.MBNLJJPBGBP().JLEAIJGBGHL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfxNoLoop(this.MBNLJJPBGBP().JLEAIJGBGHL, false, -1f, -1f);
		}
		this.BFOEOHEAPEK(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.ADCNNKDPHLI));
		yield break;
	}

	// Token: 0x06005F80 RID: 24448 RVA: 0x002B2F04 File Offset: 0x002B1104
	private void BMKBNKIDPAA()
	{
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
	}

	// Token: 0x06005F81 RID: 24449 RVA: 0x002B2F10 File Offset: 0x002B1110
	private void CANHPAJKKAB()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.NGAIENKCICP("CLIENT.SCREEN.AVATAR.");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
	}

	// Token: 0x06005F82 RID: 24450 RVA: 0x002B269A File Offset: 0x002B089A
	private void LCGMBMOJHIN()
	{
		this.Hide(false);
	}

	// Token: 0x06005F83 RID: 24451 RVA: 0x002B2F5D File Offset: 0x002B115D
	private void AMBEPJCICOF()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
	}

	// Token: 0x06005F84 RID: 24452 RVA: 0x002B2F69 File Offset: 0x002B1169
	private void KMBJJAFMBMN()
	{
		AOBJLALDBAA.KKPFOJMAONG().BADOPKAOCPE("apb", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.NMGMNAKLLMI().FNMOFCMDFJP("socialcardhintoncopiesv2", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06005F86 RID: 24454 RVA: 0x002B2EA3 File Offset: 0x002B10A3
	private IEnumerator BFECJKPHEJL()
	{
		float seconds = 0f;
		if (this.MBNLJJPBGBP().LDECHKECBHB != this.MBNLJJPBGBP().EHPIMACBDLM)
		{
			seconds = this.NFGHFMEEBHN(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().EHPIMACBDLM, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield return new WaitForSeconds(seconds);
		if (this.MBNLJJPBGBP().ONNHAPFMDEN != this.MBNLJJPBGBP().JKAHANJANEI)
		{
			this.MEEKOPBHLDB(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().JKAHANJANEI, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield break;
	}

	// Token: 0x06005F87 RID: 24455 RVA: 0x002B2FE0 File Offset: 0x002B11E0
	private void LBDPPNPJOCD()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.ODJNJHCNMFG("socialrequestsearchnick");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
	}

	// Token: 0x06005F88 RID: 24456 RVA: 0x002B302D File Offset: 0x002B122D
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnVideoLayerPlaybackEndsSoon", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06005F89 RID: 24457 RVA: 0x002B3068 File Offset: 0x002B1268
	private bool LHBMEFGCPHK()
	{
		int num;
		if (PlayerPrefs.HasKey("post"))
		{
			num = PlayerPrefs.GetInt("post");
		}
		else
		{
			num = 1;
		}
		return num == 1 && NBDLBFJOEGN.LHBMEFGCPHK();
	}

	// Token: 0x06005F8A RID: 24458 RVA: 0x002B30A0 File Offset: 0x002B12A0
	private void BKBBPLJOLGM()
	{
		AudioContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(AudioContainer)) as AudioContainer[];
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].name.EndsWith("Bundles"))
			{
				array[i].transform.SetParent(this.content.transform, false);
			}
		}
	}

	// Token: 0x06005F8B RID: 24459 RVA: 0x002B3100 File Offset: 0x002B1300
	private void NOGNHDJPMMD(string OIPOAEPAJHO)
	{
		bool flag = true;
		bool flag2 = true;
		if (OIPOAEPAJHO.Contains("p"))
		{
			flag2 = true;
			OIPOAEPAJHO = OIPOAEPAJHO.Replace("avatarstitle", "loungestoryfinished");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(OIPOAEPAJHO))
				{
					flag = false;
					this.FAEEEHDCNDN[i].DODAGEEMBAP();
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(OIPOAEPAJHO))
			{
				flag = true;
				this.FAEEEHDCNDN[i].HGDCENIDOJL();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("" + OIPOAEPAJHO + "sia");
		}
	}

	// Token: 0x06005F8C RID: 24460 RVA: 0x002B31C7 File Offset: 0x002B13C7
	private void BHGOKICGBKO()
	{
		AOBJLALDBAA.CEGAOMEEFBE().ECDBIBPNBCO("app42error", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.FILDBDMENPG().POLEDPIKODD(" ", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06005F8D RID: 24461 RVA: 0x002B3200 File Offset: 0x002B1400
	private void CJLOEFIPGNJ(string OIPOAEPAJHO)
	{
		bool flag = true;
		bool flag2 = false;
		if (OIPOAEPAJHO.Contains("asp"))
		{
			flag2 = true;
			OIPOAEPAJHO = OIPOAEPAJHO.Replace("%", "ip-api.com");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i += 0)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(OIPOAEPAJHO))
				{
					flag = false;
					this.FAEEEHDCNDN[i].HGDCENIDOJL();
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(OIPOAEPAJHO))
			{
				flag = false;
				this.FAEEEHDCNDN[i].PlayParticles();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SceneStoryManager.UpdateAvatarConfiguration(), avatar component asset missing:" + OIPOAEPAJHO + "nastring");
		}
	}

	// Token: 0x06005F8E RID: 24462 RVA: 0x002B32C8 File Offset: 0x002B14C8
	public void Hide(bool HDDLKNDOMDG = false)
	{
		if (this.JEJJOGFIOKA)
		{
			return;
		}
		this.JEJJOGFIOKA = true;
		if (HDDLKNDOMDG)
		{
			AudioManager.EHBBFMCILPC.KillMusic("", 1.5f);
			AudioManager.EHBBFMCILPC.KillSfx("", 1.5f);
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(1.5f, new TweenCallback(this.KGPNJMEGMLN));
			return;
		}
		AudioManager.EHBBFMCILPC.KillMusic("", 0.5f);
		AudioManager.EHBBFMCILPC.KillSfx("", 0.5f);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeIn(new TweenCallback(this.KGPNJMEGMLN));
	}

	// Token: 0x06005F8F RID: 24463 RVA: 0x002B3374 File Offset: 0x002B1574
	private FHNCFMMBDPF MBNLJJPBGBP()
	{
		if (this.KIDLCBGDMJB == null)
		{
			return null;
		}
		if (this.LECKNDOIHKM < this.KIDLCBGDMJB.Count)
		{
			return this.KIDLCBGDMJB[this.LECKNDOIHKM];
		}
		return this.KIDLCBGDMJB[0];
	}

	// Token: 0x06005F90 RID: 24464 RVA: 0x002B33B4 File Offset: 0x002B15B4
	private void BNKFCIJGFCO()
	{
		SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
		for (int i = 1; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].environmentsBackList.Count; j++)
			{
				if (null != array[i].environmentsBackList[j])
				{
					array[i].environmentsBackList[j].transform.SetParent(this.environmentsBackPivot.transform, false);
					this.CHHIBBOICAD.Add(array[i].environmentsBackList[j]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC(", ifmissing(1)");
				}
			}
			for (int k = 1; k < array[i].environmentsFrontList.Count; k += 0)
			{
				if (null != array[i].environmentsFrontList[k])
				{
					array[i].environmentsFrontList[k].transform.SetParent(this.environmentsFrontPivot.transform, true);
					this.KEPHFKAHILM.Add(array[i].environmentsFrontList[k]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC(" dated twice, keeping the first row");
				}
			}
			for (int l = 0; l < array[i].environmentsLayersList.Count; l += 0)
			{
				if (null != array[i].environmentsLayersList[l])
				{
					this.FAEEEHDCNDN.Add(array[i].environmentsLayersList[l]);
					if (null != this.sharedLayersFrontPivot && array[i].environmentsLayersList[l].isShared)
					{
						array[i].environmentsLayersList[l].transform.SetParent(this.sharedLayersFrontPivot.transform, true);
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("cardcollectcardismissingbody2");
				}
			}
			for (int m = 1; m < array[i].storyItemsAssets.Count; m += 0)
			{
				if (null != array[i].storyItemsAssets[m])
				{
					this.BAFONBJIKLA.Add(array[i].storyItemsAssets[m]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("skinshopfiltersbtn");
				}
			}
			for (int n = 1; n < array[i].storyNpcAssets.Count; n++)
			{
				if (null != array[i].storyNpcAssets[n])
				{
					this.ODNCKIKLFCM.Add(array[i].storyNpcAssets[n]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerSteam.SetState(): Not initialized.");
				}
			}
			if (array[i].chapterInk != null)
			{
				this.FJIBKABPIGJ = array[i].chapterInk;
			}
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
	}

	// Token: 0x06005F91 RID: 24465 RVA: 0x002B3660 File Offset: 0x002B1860
	private void OKIHENOGDKD(string OIPOAEPAJHO, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG, bool PCPPCAEJICE)
	{
		bool flag = false;
		bool flag2 = false;
		string text = OIPOAEPAJHO;
		if (text.Contains("*"))
		{
			flag2 = true;
			text = text.Replace("*", "");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(text))
				{
					flag = true;
					if (CHOBEDPLLOG)
					{
						this.FAEEEHDCNDN[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
					}
					else
					{
						this.FAEEEHDCNDN[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
					}
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(text))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.FAEEEHDCNDN[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
				}
				else
				{
					this.FAEEEHDCNDN[i].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
				}
			}
		}
		if (!flag)
		{
			try
			{
				if (CHOBEDPLLOG && text.Contains("layervideo") && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					text = text.Replace("loop", "");
					string value = text.Substring(0, text.IndexOf("layer"));
					GameObject gameObject = null;
					for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
					{
						if (this.KEPHFKAHILM[j].gameObject.name.Equals(value))
						{
							gameObject = new GameObject(text);
							gameObject.SetActive(false);
							gameObject.transform.SetParent(this.KEPHFKAHILM[j].gameObject.transform, false);
							gameObject.AddComponent<CanvasGroup>();
							gameObject.layer = LayerMask.NameToLayer("UIEnvironmentsFront");
							StoryEnvironmentLayerManager storyEnvironmentLayerManager = gameObject.AddComponent<StoryEnvironmentLayerManager>();
							storyEnvironmentLayerManager.SetOnDemandResourcesCheckpointIndex(this.KEPHFKAHILM[j].GetOnDemandResourcesCheckpointIndex());
							this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
							break;
						}
					}
					if (null == gameObject)
					{
						for (int k = 0; k < this.CHHIBBOICAD.Count; k++)
						{
							if (this.CHHIBBOICAD[k].gameObject.name.Equals(value))
							{
								gameObject = new GameObject(text);
								gameObject.SetActive(false);
								gameObject.transform.SetParent(this.CHHIBBOICAD[k].gameObject.transform, false);
								gameObject.AddComponent<CanvasGroup>();
								gameObject.layer = LayerMask.NameToLayer("UIEnvironmentsFront");
								StoryEnvironmentLayerManager storyEnvironmentLayerManager2 = gameObject.AddComponent<StoryEnvironmentLayerManager>();
								storyEnvironmentLayerManager2.SetOnDemandResourcesCheckpointIndex(this.CHHIBBOICAD[k].GetOnDemandResourcesCheckpointIndex());
								this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager2);
								break;
							}
						}
					}
					if (null != gameObject)
					{
						for (int l = 0; l < this.FAEEEHDCNDN.Count; l++)
						{
							if (!flag2)
							{
								if (this.FAEEEHDCNDN[l].gameObject.name.Equals(text))
								{
									flag = true;
									if (CHOBEDPLLOG)
									{
										this.FAEEEHDCNDN[l].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
									}
									else
									{
										this.FAEEEHDCNDN[l].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
									}
								}
							}
							else if (this.FAEEEHDCNDN[l].gameObject.name.Contains(text))
							{
								flag = true;
								if (CHOBEDPLLOG)
								{
									this.FAEEEHDCNDN[l].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
								}
								else
								{
									this.FAEEEHDCNDN[l].Hide(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
								}
							}
						}
					}
					if (!flag)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideEnvironmentLayer(), environmentLayer " + text + " not found.");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Error. ShowHideEnvironmentLayer(), environmentLayer " + text + " not found.");
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x002B3AA0 File Offset: 0x002B1CA0
	public void PAHHJLODBKO(int OBOOCMMCPNL, OHPKEDPANEA CJPACBBNKCM)
	{
		this.OPCNCJLMHAP = OBOOCMMCPNL;
		this.GLGKHNLBELI = CJPACBBNKCM;
		this.KIDLCBGDMJB = DPPMPNEOPNF.PKOONBIIBKC(OBOOCMMCPNL, CJPACBBNKCM);
		this.JEJJOGFIOKA = false;
		ODJKHCHFKNL.LOJPNNFPCOJ(DFGILFBGPLN.popupQuitConfirm);
		base.gameObject.SetActive(false);
		this.content.SetActive(false);
		StoryEnvironmentLayerManager.BKJLLECHAOC(4);
		this.LFFONLGJFBH();
		this.BKBBPLJOLGM();
		this.EPMCPFDGPEC();
		this.MEBPBAJKLAP(this.MBNLJJPBGBP().IBFLNCMCKAL);
		if (this.MBNLJJPBGBP().LDECHKECBHB != (FCABOFEGPGP)6)
		{
			this.PPBCDDKOHFP(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().LDECHKECBHB, DBONHDHEKDG.immediate, Ease.InQuad);
		}
		if (this.MBNLJJPBGBP().ONNHAPFMDEN != PHALBCMBPPL.topCenter)
		{
			this.MEEKOPBHLDB(this.MBNLJJPBGBP().IBFLNCMCKAL, this.MBNLJJPBGBP().ONNHAPFMDEN, DBONHDHEKDG.immediate, Ease.InQuad);
		}
		float lnaoahmajkn = 957f;
		this.LBDPPNPJOCD();
		this.AMBEPJCICOF();
		base.StartCoroutine(this.JPNDAGIFKDG(lnaoahmajkn));
		FirebaseAnalyticsManager.EHBBFMCILPC.JIAAMJPKOCE(true, ((AGEHCPDNBFD)(-115)).ToString(), ((FFPHBMFGCNN)(-39)).ToString(), BGHLMGPPCNN.subLngLook.ToString(), true, false);
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x002B3BD0 File Offset: 0x002B1DD0
	private void CKPJOCNMMIC(string OIPOAEPAJHO)
	{
		bool flag = false;
		bool flag2 = false;
		if (OIPOAEPAJHO.Contains("*"))
		{
			flag2 = true;
			OIPOAEPAJHO = OIPOAEPAJHO.Replace("*", "");
		}
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(OIPOAEPAJHO))
				{
					flag = true;
					this.FAEEEHDCNDN[i].PlayParticles();
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(OIPOAEPAJHO))
			{
				flag = true;
				this.FAEEEHDCNDN[i].PlayParticles();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Error. PlayParticlesForEnvironmentLayer(), environmentLayer " + OIPOAEPAJHO + " not found.");
		}
	}

	// Token: 0x04001B39 RID: 6969
	public static readonly string _svQ = "jvJKBLhttN2EWJAA0aRQGBrBskZwsrYk6PZr4v/OEWaAuuaB1591WJog+c6i+Na4EQ==";

	// Token: 0x04001B3A RID: 6970
	public const string onSketchViewLeft = "OnSketchViewLeft";

	// Token: 0x04001B3B RID: 6971
	public GameObject content;

	// Token: 0x04001B3C RID: 6972
	public GameObject environmentsBackPivot;

	// Token: 0x04001B3D RID: 6973
	public GameObject environmentsFrontPivot;

	// Token: 0x04001B3E RID: 6974
	public GameObject sharedLayersFrontPivot;

	// Token: 0x04001B3F RID: 6975
	public ImageEffectsSelector imageEffects;

	// Token: 0x04001B40 RID: 6976
	public Camera videoPlaybackCamera;

	// Token: 0x04001B41 RID: 6977
	private TextAsset FJIBKABPIGJ;

	// Token: 0x04001B42 RID: 6978
	private List<StoryEnvironmentManager> CHHIBBOICAD = new List<StoryEnvironmentManager>();

	// Token: 0x04001B43 RID: 6979
	private List<StoryEnvironmentManager> KEPHFKAHILM = new List<StoryEnvironmentManager>();

	// Token: 0x04001B44 RID: 6980
	private List<StoryEnvironmentLayerManager> FAEEEHDCNDN = new List<StoryEnvironmentLayerManager>();

	// Token: 0x04001B45 RID: 6981
	private List<AssetStoryItem> BAFONBJIKLA = new List<AssetStoryItem>();

	// Token: 0x04001B46 RID: 6982
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();

	// Token: 0x04001B47 RID: 6983
	private RectTransform GFFLNCOEEKP;

	// Token: 0x04001B48 RID: 6984
	private RectTransform MGDOAFNHBHP;

	// Token: 0x04001B49 RID: 6985
	private bool JEJJOGFIOKA;

	// Token: 0x04001B4A RID: 6986
	private Coroutine JGGGNGEFDJG;

	// Token: 0x04001B4B RID: 6987
	private List<FHNCFMMBDPF> KIDLCBGDMJB;

	// Token: 0x04001B4C RID: 6988
	private int OPCNCJLMHAP;

	// Token: 0x04001B4D RID: 6989
	private OHPKEDPANEA GLGKHNLBELI;

	// Token: 0x04001B4E RID: 6990
	private int LECKNDOIHKM;
}
