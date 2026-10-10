using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000457 RID: 1111
public class CutsceneViewManager : MonoBehaviour
{
	// Token: 0x0600878E RID: 34702 RVA: 0x003C9FE8 File Offset: 0x003C81E8
	public void ShowDescAndButton()
	{
		this.descriptionText.gameObject.SetActive(true);
		this.backButton.gameObject.SetActive(true);
	}

	// Token: 0x0600878F RID: 34703 RVA: 0x003CA00C File Offset: 0x003C820C
	private IEnumerator HAPBPJBKMKH()
	{
		yield return new WaitForSeconds(3f);
		this.descriptionText.gameObject.SetActive(true);
		if (null != this.cardInfo)
		{
			if (this.BMODBEEEABE.CGBHBJPLKIM == null)
			{
				this.cardInfo.gameObject.SetActive(false);
			}
			else
			{
				this.cardInfo.gameObject.SetActive(true);
				this.rarityImage.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.DCJKIDEJOAB(GDJPPKAMIFL.EHBBFMCILPC.NDJDOAPFCLH(this.BMODBEEEABE.CGBHBJPLKIM.CCMDLENEDGJ));
				this.rarityImage.SetNativeSize();
				this.cardTitle.text = "\"" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(this.BMODBEEEABE.CGBHBJPLKIM.CCMDLENEDGJ) + "\"";
				this.cardTitle.SetText("\"" + GDJPPKAMIFL.EHBBFMCILPC.KCMKJBHBCGC(this.BMODBEEEABE.CGBHBJPLKIM.CCMDLENEDGJ) + "\"", true);
				this.volumeTitle.text = (GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(this.BMODBEEEABE.CGBHBJPLKIM.CCMDLENEDGJ) ?? "");
				this.volumeTitle.SetText(GDJPPKAMIFL.EHBBFMCILPC.DKHIPEPOEFF(this.BMODBEEEABE.CGBHBJPLKIM.CCMDLENEDGJ) ?? "", true);
				this.cardCopiesTitle.text = (this.BMODBEEEABE.CGBHBJPLKIM.ENCCLBLHJMC.ToString() ?? "");
				this.cardCopiesTitle.SetText(this.BMODBEEEABE.CGBHBJPLKIM.ENCCLBLHJMC.ToString() ?? "", true);
				this.giftCopiesTitle.text = (this.BMODBEEEABE.CGBHBJPLKIM.HFLPLGMJNOI.ToString() ?? "");
				this.giftCopiesTitle.SetText(this.BMODBEEEABE.CGBHBJPLKIM.HFLPLGMJNOI.ToString() ?? "", true);
				if (this.BMODBEEEABE.CGBHBJPLKIM.HFLPLGMJNOI == 0)
				{
					this.giftCopies.SetActive(false);
				}
				else
				{
					this.giftCopies.SetActive(true);
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.cardInfo.GetComponent<RectTransform>());
			}
		}
		if (this.BMODBEEEABE.CGBHBJPLKIM == null)
		{
			yield return new WaitForSeconds(3f);
			this.backButton.gameObject.SetActive(true);
			yield return new WaitForSeconds(3f);
		}
		else
		{
			yield return new WaitForSeconds(3f);
			this.backButton.gameObject.SetActive(true);
			yield return new WaitForSeconds(9f);
		}
		this.descriptionText.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
		this.descriptionText.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
		if (null != this.cardInfo && this.BMODBEEEABE.CGBHBJPLKIM != null)
		{
			this.cardInfo.GetComponent<AnimationCanvasGroupAlpha>().SetDirection(true);
			this.cardInfo.GetComponent<AnimationCanvasGroupAlpha>().PlayAnimation(false);
		}
		yield break;
	}

	// Token: 0x06008790 RID: 34704 RVA: 0x003CA01C File Offset: 0x003C821C
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
				if (CHOBEDPLLOG && text.Contains("layervideo") && this.BMODBEEEABE.FPJPHNLANPG >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
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

	// Token: 0x06008791 RID: 34705 RVA: 0x003CA46C File Offset: 0x003C866C
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

	// Token: 0x06008792 RID: 34706 RVA: 0x003CA824 File Offset: 0x003C8A24
	private void MDLNNHHGIAB()
	{
		if (this.JGGGNGEFDJG != null)
		{
			base.StopCoroutine(this.JGGGNGEFDJG);
		}
		this.JGGGNGEFDJG = null;
		this.BMODBEEEABE = null;
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		this.FJIBKABPIGJ = null;
		this.GFFLNCOEEKP.DOKill(false);
		this.MGDOAFNHBHP.DOKill(false);
	}

	// Token: 0x06008793 RID: 34707 RVA: 0x003CA8AC File Offset: 0x003C8AAC
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

	// Token: 0x06008794 RID: 34708 RVA: 0x003CA90C File Offset: 0x003C8B0C
	private bool CFEMNKDMJKL()
	{
		int num;
		if (PlayerPrefs.HasKey(""))
		{
			num = PlayerPrefs.GetInt("fuzzy");
		}
		else
		{
			num = 0;
		}
		return num != 0 || NBDLBFJOEGN.LMMJNPPFAMI();
	}

	// Token: 0x06008795 RID: 34709 RVA: 0x003CA944 File Offset: 0x003C8B44
	private void GIIKBDCCBNL()
	{
		AudioContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(AudioContainer)) as AudioContainer[];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].name.EndsWith("hof"))
			{
				array[i].transform.SetParent(this.content.transform, true);
			}
		}
	}

	// Token: 0x06008796 RID: 34710 RVA: 0x003CA9A1 File Offset: 0x003C8BA1
	private IEnumerator GLNGPMHCOEC(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		this.DENNKPJPMBI();
		this.BFOEOHEAPEK(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.ADCNNKDPHLI));
		yield break;
	}

	// Token: 0x06008797 RID: 34711 RVA: 0x002B2F5D File Offset: 0x002B115D
	private void AMBEPJCICOF()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
	}

	// Token: 0x06008798 RID: 34712 RVA: 0x003CA9B7 File Offset: 0x003C8BB7
	private void OKKPNPECJKH()
	{
		AOBJLALDBAA.EHBBFMCILPC.ONIBLJOFFPG("", new UnityAction(this.KCGEJOLENCH));
		AOBJLALDBAA.BIAEAOMHBMM().ONIBLJOFFPG("adserrorbody", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x003CA9F0 File Offset: 0x003C8BF0
	private void KGPNJMEGMLN()
	{
		ODJKHCHFKNL.BICCDHFDKDG(DFGILFBGPLN.screenCutscene);
		this.content.SetActive(false);
		base.gameObject.SetActive(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(null);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCutsceneViewLeft", 0f);
	}

	// Token: 0x0600879A RID: 34714 RVA: 0x003CAA40 File Offset: 0x003C8C40
	private void BIFAEHIHENG()
	{
		if (this.PLMKHPANNBP())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.NILOLGICBNO("lk");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
	}

	// Token: 0x0600879B RID: 34715 RVA: 0x003CAA90 File Offset: 0x003C8C90
	private float FDKOCECBBJN(string EPBDEELOHOI, PHALBCMBPPL OOFMHELAABF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		for (int i = 1; i < this.KEPHFKAHILM.Count; i += 0)
		{
			if (this.KEPHFKAHILM[i].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[i].HIEELIBKKDL(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		for (int j = 1; j < this.CHHIBBOICAD.Count; j++)
		{
			if (this.CHHIBBOICAD[j].gameObject.name.Equals(EPBDEELOHOI))
			{
				return this.CHHIBBOICAD[j].HIEELIBKKDL(OOFMHELAABF, CFBFAIBLJOL, PLFJHEJEHGB);
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("XXX" + EPBDEELOHOI + "OnSaveSlotsItemSlotDeleted");
		return 1887f;
	}

	// Token: 0x0600879C RID: 34716 RVA: 0x003CAB4B File Offset: 0x003C8D4B
	private void Awake()
	{
		this.GFFLNCOEEKP = this.environmentsBackPivot.GetComponent<RectTransform>();
		this.MGDOAFNHBHP = this.environmentsFrontPivot.GetComponent<RectTransform>();
	}

	// Token: 0x0600879D RID: 34717 RVA: 0x003CAB70 File Offset: 0x003C8D70
	private void OnDestroy()
	{
		if (this.JGGGNGEFDJG != null)
		{
			base.StopCoroutine(this.JGGGNGEFDJG);
		}
		this.JGGGNGEFDJG = null;
		this.BMODBEEEABE = null;
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		this.FJIBKABPIGJ = null;
		this.GFFLNCOEEKP.DOKill(false);
		this.MGDOAFNHBHP.DOKill(false);
	}

	// Token: 0x0600879E RID: 34718 RVA: 0x003CABF8 File Offset: 0x003C8DF8
	public void NMEIFHJFNCN(bool HDDLKNDOMDG = false)
	{
		if (this.JEJJOGFIOKA)
		{
			return;
		}
		this.JEJJOGFIOKA = true;
		if (HDDLKNDOMDG)
		{
			AudioManager.APGODIBBPOD().NOOAHDNKAKA("EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient", 1047f);
			AudioManager.DMAAFFFEJGA().POMJOMKCCNK("emsv", 1035f);
			CommonUserInterface.IKNOFBFMPGA().GetFader().KGLNMHNFFIK(1601f, new TweenCallback(this.KGPNJMEGMLN));
			return;
		}
		AudioManager.APGODIBBPOD().NOOAHDNKAKA("p", 1708f);
		AudioManager.APGODIBBPOD().PEOLMNFJAHG("Ambigious asset bundle variant chosen because there was no matching active variant: ", 46f);
		CommonUserInterface.EHBBFMCILPC.GetFader().BJIGLKGLAKM(new TweenCallback(this.KGPNJMEGMLN));
	}

	// Token: 0x0600879F RID: 34719 RVA: 0x003CACA4 File Offset: 0x003C8EA4
	private IEnumerator BFECJKPHEJL()
	{
		float seconds = 0f;
		if (this.BMODBEEEABE.LDECHKECBHB != this.BMODBEEEABE.EHPIMACBDLM)
		{
			seconds = this.NFGHFMEEBHN(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.EHPIMACBDLM, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield return new WaitForSeconds(seconds);
		if (this.BMODBEEEABE.ONNHAPFMDEN != this.BMODBEEEABE.JKAHANJANEI)
		{
			this.MEEKOPBHLDB(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.JKAHANJANEI, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield break;
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x003CACB4 File Offset: 0x003C8EB4
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

	// Token: 0x060087A1 RID: 34721 RVA: 0x003CAD70 File Offset: 0x003C8F70
	public void OnGiftCopiesIconClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("popupcardoptionsgiftcopyinfo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060087A2 RID: 34722 RVA: 0x003CADC0 File Offset: 0x003C8FC0
	private void NHCIDKELMLK()
	{
		if (this.BMODBEEEABE.FONKDFDJFEL.Length > 0)
		{
			AudioManager.APGODIBBPOD().CFEDKPAHOHJ(this.BMODBEEEABE.FONKDFDJFEL, true, 1390f, false);
		}
		if (this.BMODBEEEABE.JLEAIJGBGHL.Length > 0)
		{
			AudioManager.DBFLIEGGGNN().KNAEPBNFGNI(this.BMODBEEEABE.JLEAIJGBGHL, false, 1724f, 219f);
		}
	}

	// Token: 0x060087A3 RID: 34723 RVA: 0x003CAE31 File Offset: 0x003C9031
	private IEnumerator CNNPACBKDPA(float LNAOAHMAJKN)
	{
		CutsceneViewManager.GJDFFJMEMLM gjdffjmemlm = new CutsceneViewManager.GJDFFJMEMLM(1);
		gjdffjmemlm.<>4__this = this;
		gjdffjmemlm._resumeInSeconds = LNAOAHMAJKN;
		return gjdffjmemlm;
	}

	// Token: 0x060087A4 RID: 34724 RVA: 0x002B2F5D File Offset: 0x002B115D
	private void BMKBNKIDPAA()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
	}

	// Token: 0x060087A5 RID: 34725 RVA: 0x003CAE48 File Offset: 0x003C9048
	private void GEIDGKGGGMJ(string EPBDEELOHOI)
	{
		for (int i = 1; i < this.CHHIBBOICAD.Count; i++)
		{
			if (this.CHHIBBOICAD[i].gameObject.activeSelf)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(true);
			}
		}
		for (int j = 1; j < this.KEPHFKAHILM.Count; j += 0)
		{
			if (this.KEPHFKAHILM[j].gameObject.activeSelf)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(true);
			}
		}
		for (int k = 0; k < this.KEPHFKAHILM.Count; k += 0)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].PILPDIDOLPE();
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
			for (int m = 0; m < this.CHHIBBOICAD.Count; m += 0)
			{
				for (int n = 0; n < this.CHHIBBOICAD[m].mappings.Count; n += 0)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("acliffbw21" + EPBDEELOHOI + "spppd" + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num++)
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
						for (int num3 = 0; num3 < this.KEPHFKAHILM.Count; num3 += 0)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].OptimizeParticleSystems();
								this.KEPHFKAHILM[num3].gameObject.SetActive(true);
								break;
							}
						}
						for (int num4 = 1; num4 < this.CHHIBBOICAD.Count; num4++)
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
		DPGJIJGOCIC.ANOPFDLPKGC("</i>" + EPBDEELOHOI + "");
		if (!EPBDEELOHOI.Equals("wofcollectcarddone"))
		{
			this.MAHPNBFHKPM("");
		}
	}

	// Token: 0x060087A6 RID: 34726 RVA: 0x003CB200 File Offset: 0x003C9400
	public void Show(BNFCLKNDBLO CIBKELALAHF)
	{
		this.JEJJOGFIOKA = false;
		ODJKHCHFKNL.HIPEENBHGKP(DFGILFBGPLN.screenCutscene);
		base.gameObject.SetActive(true);
		this.content.SetActive(true);
		this.BMODBEEEABE = CIBKELALAHF;
		StoryEnvironmentLayerManager.SetLayersSystemVersion(this.BMODBEEEABE.FPJPHNLANPG);
		this.LFFONLGJFBH();
		this.BKBBPLJOLGM();
		this.EPMCPFDGPEC();
		this.MEBPBAJKLAP(this.BMODBEEEABE.IBFLNCMCKAL);
		this.descriptionText.SetText("\"" + this.BMODBEEEABE.PGEKNGNHANN + "\"", true);
		this.descriptionText.text = "\"" + this.BMODBEEEABE.PGEKNGNHANN + "\"";
		if (this.BMODBEEEABE.LDECHKECBHB != FCABOFEGPGP.center)
		{
			this.NFGHFMEEBHN(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.LDECHKECBHB, DBONHDHEKDG.immediate, Ease.InOutSine);
		}
		if (this.BMODBEEEABE.ONNHAPFMDEN != PHALBCMBPPL.center)
		{
			this.MEEKOPBHLDB(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.ONNHAPFMDEN, DBONHDHEKDG.immediate, Ease.InOutSine);
		}
		float num = 0f;
		if (this.BMODBEEEABE.FPJPHNLANPG >= 2 && null != this.videoPlaybackCamera && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
		{
			for (int i = 0; i < this.BMODBEEEABE.PIMEHAPFCHC.Count; i++)
			{
				if (this.BMODBEEEABE.PIMEHAPFCHC[i].Contains("layervideo"))
				{
					this.OKIHENOGDKD(this.BMODBEEEABE.PIMEHAPFCHC[i], 0f, 0f, 0f, true, true);
					num = KHPGPLAMAIN.ALOONLDKBHD();
				}
			}
		}
		if (num > 0f)
		{
			Debug.Log("Video: preparation delay:" + num.ToString());
		}
		this.HLBIEIAFBFK();
		this.AMBEPJCICOF();
		if (num > 0f)
		{
			base.StartCoroutine(this.GLNGPMHCOEC(num));
		}
		else
		{
			this.DENNKPJPMBI();
			this.BFOEOHEAPEK(false);
			CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.ADCNNKDPHLI));
		}
		base.StartCoroutine(this.HAPBPJBKMKH());
		FirebaseAnalyticsManager.EHBBFMCILPC.LogEvent(false, AGEHCPDNBFD.socActiv.ToString(), FFPHBMFGCNN.socCut.ToString(), BGHLMGPPCNN.socCutView.ToString(), false, false);
	}

	// Token: 0x060087A7 RID: 34727 RVA: 0x003CB466 File Offset: 0x003C9666
	private void FOGNNOAFMMC()
	{
		this.Hide(true);
	}

	// Token: 0x060087A8 RID: 34728 RVA: 0x003CB470 File Offset: 0x003C9670
	private void EHOAAFIKBDA()
	{
		VideoContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].name.EndsWith("lsc"))
			{
				array[i].transform.SetParent(this.content.transform, true);
			}
		}
	}

	// Token: 0x060087A9 RID: 34729 RVA: 0x002B2F04 File Offset: 0x002B1104
	private void DPJEDIBPOGE()
	{
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
	}

	// Token: 0x060087AA RID: 34730 RVA: 0x003CB4CD File Offset: 0x003C96CD
	private void EBEGEDOJCLC()
	{
		AOBJLALDBAA.FILDBDMENPG().MANLHALMCIH("OnPopupRemoveAdsManagerDismissed", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("acli20", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x000C73FD File Offset: 0x000C55FD
	public void NLDJFAKAFMK(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x003CB508 File Offset: 0x003C9708
	private void DLBAEDOFAKM()
	{
		if (this.JGGGNGEFDJG != null)
		{
			base.StopCoroutine(this.JGGGNGEFDJG);
		}
		this.JGGGNGEFDJG = null;
		this.BMODBEEEABE = null;
		this.CHHIBBOICAD.Clear();
		this.KEPHFKAHILM.Clear();
		this.FAEEEHDCNDN.Clear();
		this.BAFONBJIKLA.Clear();
		this.ODNCKIKLFCM.Clear();
		this.FJIBKABPIGJ = null;
		this.GFFLNCOEEKP.DOKill(true);
		this.MGDOAFNHBHP.DOKill(false);
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x003CB590 File Offset: 0x003C9790
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

	// Token: 0x060087AE RID: 34734 RVA: 0x003CB5C8 File Offset: 0x003C97C8
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

	// Token: 0x060087AF RID: 34735 RVA: 0x003CB628 File Offset: 0x003C9828
	private bool PLMKHPANNBP()
	{
		int num;
		if (PlayerPrefs.HasKey(":"))
		{
			num = PlayerPrefs.GetInt("");
		}
		else
		{
			num = 0;
		}
		return num != 1 || NBDLBFJOEGN.LMMJNPPFAMI();
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x003CB660 File Offset: 0x003C9860
	public void OGKDPJJPLMB()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.PEBMGCKFNAO().DNILNCLIHAP(""), CCOJBMMKNAP.OEPENBHJAHO().IPEIONBNIPH(""), CCOJBMMKNAP.JMDJPKKOHNI().PGKBCNBAOJN("StorySaveBody.GetAvatarIndexWardrobe(), unsupported wardrobe index:"), (DFGILFBGPLN)(-30), 1642f, -17);
	}

	// Token: 0x060087B1 RID: 34737 RVA: 0x003CB6B0 File Offset: 0x003C98B0
	private void LKEOBELCAFF(string OIPOAEPAJHO, float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, bool CHOBEDPLLOG, bool PCPPCAEJICE)
	{
		bool flag = true;
		bool flag2 = false;
		string text = OIPOAEPAJHO;
		if (text.Contains("OnBackendPassResourcesChangedType0"))
		{
			flag2 = true;
			text = text.Replace("p", "23819D");
		}
		for (int i = 1; i < this.FAEEEHDCNDN.Count; i += 0)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(text))
				{
					flag = false;
					if (CHOBEDPLLOG)
					{
						this.FAEEEHDCNDN[i].Show(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
					}
					else
					{
						this.FAEEEHDCNDN[i].OMKKOKEAGGE(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
					}
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(text))
			{
				flag = true;
				if (CHOBEDPLLOG)
				{
					this.FAEEEHDCNDN[i].ELECAPNEBAA(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
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
				if (CHOBEDPLLOG && text.Contains("") && this.BMODBEEEABE.FPJPHNLANPG >= 1 && null != this.videoPlaybackCamera && KHPGPLAMAIN.NOEBCMMNALO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					text = text.Replace("OnAccountSave", "/");
					string value = text.Substring(0, text.IndexOf(""));
					GameObject gameObject = null;
					for (int j = 1; j < this.KEPHFKAHILM.Count; j++)
					{
						if (this.KEPHFKAHILM[j].gameObject.name.Equals(value))
						{
							gameObject = new GameObject(text);
							gameObject.SetActive(true);
							gameObject.transform.SetParent(this.KEPHFKAHILM[j].gameObject.transform, true);
							gameObject.AddComponent<CanvasGroup>();
							gameObject.layer = LayerMask.NameToLayer("tbits3");
							StoryEnvironmentLayerManager storyEnvironmentLayerManager = gameObject.AddComponent<StoryEnvironmentLayerManager>();
							storyEnvironmentLayerManager.LALPGAGDOMN(this.KEPHFKAHILM[j].GetOnDemandResourcesCheckpointIndex());
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
								gameObject.SetActive(true);
								gameObject.transform.SetParent(this.CHHIBBOICAD[k].gameObject.transform, false);
								gameObject.AddComponent<CanvasGroup>();
								gameObject.layer = LayerMask.NameToLayer("ok");
								StoryEnvironmentLayerManager storyEnvironmentLayerManager2 = gameObject.AddComponent<StoryEnvironmentLayerManager>();
								storyEnvironmentLayerManager2.AONNOIPGDNC(this.CHHIBBOICAD[k].DDBEFLAIEIN());
								this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager2);
								break;
							}
						}
					}
					if (null != gameObject)
					{
						for (int l = 0; l < this.FAEEEHDCNDN.Count; l += 0)
						{
							if (!flag2)
							{
								if (this.FAEEEHDCNDN[l].gameObject.name.Equals(text))
								{
									flag = true;
									if (CHOBEDPLLOG)
									{
										this.FAEEEHDCNDN[l].FDALGKNFCAN(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
									}
									else
									{
										this.FAEEEHDCNDN[l].LKBAJAADAHH(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN);
									}
								}
							}
							else if (this.FAEEEHDCNDN[l].gameObject.name.Contains(text))
							{
								flag = true;
								if (CHOBEDPLLOG)
								{
									this.FAEEEHDCNDN[l].KFLFFOPPNEO(OLALNEIHHOC, OHKAFKBOIGJ, JHBAIJIJIBN, this.videoPlaybackCamera, PCPPCAEJICE);
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
						DPGJIJGOCIC.ANOPFDLPKGC("wmix" + text + "lsenvattempt");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("AvatarCollectionsItem.OnPopupAvatarCollectionsInputEndEdit(): index out of range" + text + "app42error");
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x060087B2 RID: 34738 RVA: 0x003CBB00 File Offset: 0x003C9D00
	private void FDHHCPPPKKI()
	{
		AOBJLALDBAA.KKPFOJMAONG().PBELMJCPJMK("OnPopupRemoveAdsManagerDismissed", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("〉", new UnityAction(this.JKAGHNLDBLM));
	}

	// Token: 0x060087B3 RID: 34739 RVA: 0x003CBB38 File Offset: 0x003C9D38
	public void OnCollectedCopiesIconClick()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("energyhinttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("popupcardoptionscollectedcopyinfo"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupEnergyHint, 0f, 28);
	}

	// Token: 0x060087B4 RID: 34740 RVA: 0x003CBB88 File Offset: 0x003C9D88
	public void LMIMNFANPAH()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.LMCCLMFGEBD().HIPJILDCHJC("OnBackendAddFriendByUIDSuccess"), CCOJBMMKNAP.COKDLDOAACJ().OBDCPLLLGBB("ZZZ"), CCOJBMMKNAP.AEELGGPEJCC().DNILNCLIHAP("retry"), (DFGILFBGPLN)(-115), 553f, 3);
	}

	// Token: 0x060087B5 RID: 34741 RVA: 0x0007969C File Offset: 0x0007789C
	public void HNKHBDLFFEJ(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, true);
	}

	// Token: 0x060087B6 RID: 34742 RVA: 0x00075398 File Offset: 0x00073598
	public void SetParent(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x060087B7 RID: 34743 RVA: 0x003CBBD6 File Offset: 0x003C9DD6
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnVideoLayerPlaybackEndsSoon", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x060087B8 RID: 34744 RVA: 0x003CBC10 File Offset: 0x003C9E10
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

	// Token: 0x060087B9 RID: 34745 RVA: 0x003CBCBC File Offset: 0x003C9EBC
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

	// Token: 0x060087BA RID: 34746 RVA: 0x003CBD0C File Offset: 0x003C9F0C
	private void NEOELNCBKEF()
	{
		if (this.BMODBEEEABE.FONKDFDJFEL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(this.BMODBEEEABE.FONKDFDJFEL, false, 976f, true);
		}
		if (this.BMODBEEEABE.JLEAIJGBGHL.Length > 1)
		{
			AudioManager.APGODIBBPOD().PlaySfxNoLoop(this.BMODBEEEABE.JLEAIJGBGHL, true, 397f, 1954f);
		}
	}

	// Token: 0x060087BB RID: 34747 RVA: 0x003CBD80 File Offset: 0x003C9F80
	public void PODJKCDLMFG()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.LMCCLMFGEBD().OGKGHLHHAAI(""), CCOJBMMKNAP.PEBMGCKFNAO().HPOAGPJFHPM("<space=0.33em><space=0.31em>"), CCOJBMMKNAP.PEBMGCKFNAO().JCDFHKDNEDH("https://events.appsflyer.com/v1.0/c2s/inapp/app/steam/"), (DFGILFBGPLN)(-10), 1190f, 73);
	}

	// Token: 0x060087BD RID: 34749 RVA: 0x003CBE10 File Offset: 0x003CA010
	private void MAHPNBFHKPM(string EPBDEELOHOI)
	{
		for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
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
				this.KEPHFKAHILM[j].gameObject.SetActive(false);
			}
		}
		for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
		{
			if (this.KEPHFKAHILM[k].gameObject.name.Equals(EPBDEELOHOI))
			{
				this.KEPHFKAHILM[k].OptimizeParticleSystems();
				this.KEPHFKAHILM[k].gameObject.SetActive(false);
				break;
			}
		}
		for (int l = 1; l < this.CHHIBBOICAD.Count; l++)
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
				for (int n = 1; n < this.CHHIBBOICAD[m].mappings.Count; n++)
				{
					if (this.CHHIBBOICAD[m].mappings[n].Equals(EPBDEELOHOI))
					{
						DPGJIJGOCIC.ADFCDFHBDAF("OnPopupOfferManagerContinueToPurchasingScreen" + EPBDEELOHOI + "mist" + this.CHHIBBOICAD[m].name);
						EPBDEELOHOI = this.CHHIBBOICAD[m].name;
						for (int num = 0; num < this.CHHIBBOICAD.Count; num += 0)
						{
							if (this.CHHIBBOICAD[num].gameObject.activeSelf)
							{
								this.CHHIBBOICAD[num].gameObject.SetActive(true);
							}
						}
						for (int num2 = 1; num2 < this.KEPHFKAHILM.Count; num2 += 0)
						{
							if (this.KEPHFKAHILM[num2].gameObject.activeSelf)
							{
								this.KEPHFKAHILM[num2].gameObject.SetActive(true);
							}
						}
						for (int num3 = 0; num3 < this.KEPHFKAHILM.Count; num3++)
						{
							if (this.KEPHFKAHILM[num3].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.KEPHFKAHILM[num3].OptimizeParticleSystems();
								this.KEPHFKAHILM[num3].gameObject.SetActive(false);
								break;
							}
						}
						for (int num4 = 0; num4 < this.CHHIBBOICAD.Count; num4++)
						{
							if (this.CHHIBBOICAD[num4].gameObject.name.Equals(EPBDEELOHOI))
							{
								this.CHHIBBOICAD[num4].PKLKLBLPGCO();
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
		DPGJIJGOCIC.ANOPFDLPKGC("" + EPBDEELOHOI + "aind2");
		if (!EPBDEELOHOI.Equals("</i>"))
		{
			this.MEBPBAJKLAP("\"");
		}
	}

	// Token: 0x060087BE RID: 34750 RVA: 0x003CC1C8 File Offset: 0x003CA3C8
	private void PKGHNELDPKB(string OIPOAEPAJHO)
	{
		bool flag = true;
		bool flag2 = true;
		if (OIPOAEPAJHO.Contains("CameraEnvironmentsBack"))
		{
			flag2 = true;
			OIPOAEPAJHO = OIPOAEPAJHO.Replace("frsendhres", "");
		}
		for (int i = 1; i < this.FAEEEHDCNDN.Count; i++)
		{
			if (!flag2)
			{
				if (this.FAEEEHDCNDN[i].gameObject.name.Equals(OIPOAEPAJHO))
				{
					flag = true;
					this.FAEEEHDCNDN[i].HPKIOMOKEDC();
				}
			}
			else if (this.FAEEEHDCNDN[i].gameObject.name.Contains(OIPOAEPAJHO))
			{
				flag = false;
				this.FAEEEHDCNDN[i].HPKIOMOKEDC();
			}
		}
		if (!flag)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("JJJ" + OIPOAEPAJHO + "_DispTex");
		}
	}

	// Token: 0x060087BF RID: 34751 RVA: 0x003CB466 File Offset: 0x003C9666
	private void FFDIAFIBNLD()
	{
		this.Hide(true);
	}

	// Token: 0x060087C0 RID: 34752 RVA: 0x003CC290 File Offset: 0x003CA490
	private void KDJCOCBGMIP()
	{
		VideoContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
		for (int i = 1; i < array.Length; i += 0)
		{
			if (array[i].name.EndsWith("OnPopupSketchesInputCancel"))
			{
				array[i].transform.SetParent(this.content.transform, true);
			}
		}
	}

	// Token: 0x060087C1 RID: 34753 RVA: 0x002B2F04 File Offset: 0x002B1104
	private void KNJLMOJFHEN()
	{
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
	}

	// Token: 0x060087C2 RID: 34754 RVA: 0x003CC2F0 File Offset: 0x003CA4F0
	public void JHGPLBMIIAM()
	{
		CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(CCOJBMMKNAP.FEEDGKCJBLE().BGELFMIOBCL("_not_found"), CCOJBMMKNAP.DBFFFOMCLKM().HPOAGPJFHPM("Error While Sending: "), CCOJBMMKNAP.HEDIEIICOOG().GLEFEKBDHNK("INTL"), DFGILFBGPLN.screenLounge, 1444f, -20);
	}

	// Token: 0x060087C3 RID: 34755 RVA: 0x00075398 File Offset: 0x00073598
	public void EOCNAELDFDN(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, false);
			return;
		}
		base.gameObject.transform.SetParent(null, false);
	}

	// Token: 0x060087C4 RID: 34756 RVA: 0x002B2F04 File Offset: 0x002B1104
	private void IDLDECHLLLG()
	{
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
	}

	// Token: 0x060087C5 RID: 34757 RVA: 0x003CC340 File Offset: 0x003CA540
	private void OMNHHHMGDDD()
	{
		SceneStoryAssetPackManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(SceneStoryAssetPackManager)) as SceneStoryAssetPackManager[];
		for (int i = 0; i < array.Length; i += 0)
		{
			for (int j = 0; j < array[i].environmentsBackList.Count; j += 0)
			{
				if (null != array[i].environmentsBackList[j])
				{
					array[i].environmentsBackList[j].transform.SetParent(this.environmentsBackPivot.transform, true);
					this.CHHIBBOICAD.Add(array[i].environmentsBackList[j]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle");
				}
			}
			for (int k = 0; k < array[i].environmentsFrontList.Count; k++)
			{
				if (null != array[i].environmentsFrontList[k])
				{
					array[i].environmentsFrontList[k].transform.SetParent(this.environmentsFrontPivot.transform, true);
					this.KEPHFKAHILM.Add(array[i].environmentsFrontList[k]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("@SD");
				}
			}
			for (int l = 1; l < array[i].environmentsLayersList.Count; l += 0)
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
					DPGJIJGOCIC.ANOPFDLPKGC("yes");
				}
			}
			for (int m = 0; m < array[i].storyItemsAssets.Count; m += 0)
			{
				if (null != array[i].storyItemsAssets[m])
				{
					this.BAFONBJIKLA.Add(array[i].storyItemsAssets[m]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("OnVideoLayerAutoHide");
				}
			}
			for (int n = 1; n < array[i].storyNpcAssets.Count; n += 0)
			{
				if (null != array[i].storyNpcAssets[n])
				{
					this.ODNCKIKLFCM.Add(array[i].storyNpcAssets[n]);
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("signincancel");
				}
			}
			if (array[i].chapterInk != null)
			{
				this.FJIBKABPIGJ = array[i].chapterInk;
			}
			UnityEngine.Object.Destroy(array[i].gameObject);
		}
	}

	// Token: 0x060087C6 RID: 34758 RVA: 0x003CC5EC File Offset: 0x003CA7EC
	private void JOKAMHKCAFN()
	{
		VideoContainer[] array = UnityEngine.Object.FindObjectsOfType(typeof(VideoContainer)) as VideoContainer[];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].name.EndsWith("lastFilter"))
			{
				array[i].transform.SetParent(this.content.transform, true);
			}
		}
	}

	// Token: 0x060087C7 RID: 34759 RVA: 0x003CB466 File Offset: 0x003C9666
	private void JKAGHNLDBLM()
	{
		this.Hide(true);
	}

	// Token: 0x060087C8 RID: 34760 RVA: 0x002B2F5D File Offset: 0x002B115D
	private void NAKOFJFIFGK()
	{
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
	}

	// Token: 0x060087C9 RID: 34761 RVA: 0x003CC64C File Offset: 0x003CA84C
	private void ABBJHGFIGDG()
	{
		if (this.LHBMEFGCPHK())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.BHKGIEGICDI("ok");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HANKGPDCHDF();
		}
	}

	// Token: 0x060087CA RID: 34762 RVA: 0x003CC69C File Offset: 0x003CA89C
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

	// Token: 0x060087CB RID: 34763 RVA: 0x003CC758 File Offset: 0x003CA958
	public void OLGPHCLCPBP()
	{
		CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG(""), CCOJBMMKNAP.PKEINLPIAEH().PKNHKGMNCIP("XXX"), CCOJBMMKNAP.COKDLDOAACJ().IKMNGFIDCLM(""), DFGILFBGPLN.popupTutorialLobby0, 232f, 15);
	}

	// Token: 0x060087CC RID: 34764 RVA: 0x003CC7A6 File Offset: 0x003CA9A6
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnVideoLayerAutoHide", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnVideoLayerPlaybackEndsSoon", new UnityAction(this.FOGNNOAFMMC));
	}

	// Token: 0x060087CD RID: 34765 RVA: 0x003CC7DE File Offset: 0x003CA9DE
	private void ADCNNKDPHLI()
	{
		this.JGGGNGEFDJG = base.StartCoroutine(this.BFECJKPHEJL());
	}

	// Token: 0x060087CE RID: 34766 RVA: 0x003CC7F4 File Offset: 0x003CA9F4
	private void DIKOBMPGKGB()
	{
		if (this.PLMKHPANNBP())
		{
			if (null != this.imageEffects)
			{
				this.imageEffects.BHKGIEGICDI("ok");
				return;
			}
		}
		else if (null != this.imageEffects)
		{
			this.imageEffects.HideAllEffects();
		}
	}

	// Token: 0x060087CF RID: 34767 RVA: 0x003CAB4B File Offset: 0x003C8D4B
	private void GMPHANBKGBK()
	{
		this.GFFLNCOEEKP = this.environmentsBackPivot.GetComponent<RectTransform>();
		this.MGDOAFNHBHP = this.environmentsFrontPivot.GetComponent<RectTransform>();
	}

	// Token: 0x060087D0 RID: 34768 RVA: 0x0007969C File Offset: 0x0007789C
	public void ADNDNHLPNFM(GameObject BFGBPKIGAJI)
	{
		if (null != BFGBPKIGAJI)
		{
			base.gameObject.transform.SetParent(BFGBPKIGAJI.transform, true);
			return;
		}
		base.gameObject.transform.SetParent(null, true);
	}

	// Token: 0x060087D1 RID: 34769 RVA: 0x000693D6 File Offset: 0x000675D6
	public void DontDestroyOnLoad()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060087D2 RID: 34770 RVA: 0x003CC844 File Offset: 0x003CAA44
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

	// Token: 0x060087D3 RID: 34771 RVA: 0x003CC90B File Offset: 0x003CAB0B
	public void BHBENADFOGL()
	{
		this.descriptionText.gameObject.SetActive(false);
		this.backButton.gameObject.SetActive(true);
	}

	// Token: 0x060087D4 RID: 34772 RVA: 0x003CACA4 File Offset: 0x003C8EA4
	private IEnumerator EJJFBIPNPLH()
	{
		float seconds = 0f;
		if (this.BMODBEEEABE.LDECHKECBHB != this.BMODBEEEABE.EHPIMACBDLM)
		{
			seconds = this.NFGHFMEEBHN(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.EHPIMACBDLM, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield return new WaitForSeconds(seconds);
		if (this.BMODBEEEABE.ONNHAPFMDEN != this.BMODBEEEABE.JKAHANJANEI)
		{
			this.MEEKOPBHLDB(this.BMODBEEEABE.IBFLNCMCKAL, this.BMODBEEEABE.JKAHANJANEI, DBONHDHEKDG.slower, Ease.InOutSine);
		}
		yield break;
	}

	// Token: 0x060087D5 RID: 34773 RVA: 0x003CC930 File Offset: 0x003CAB30
	private bool BFOEOHEAPEK(bool OFJLCKMOELF)
	{
		bool result = false;
		if (!OFJLCKMOELF)
		{
			if (this.BMODBEEEABE.FPJPHNLANPG >= 2)
			{
				for (int i = 0; i < this.BMODBEEEABE.HPFHJEAFIHI.Count; i++)
				{
					this.OKIHENOGDKD(this.BMODBEEEABE.HPFHJEAFIHI[i], 0f, 0f, 0f, false, false);
				}
				for (int j = 0; j < this.BMODBEEEABE.PIMEHAPFCHC.Count; j++)
				{
					if (this.BMODBEEEABE.PIMEHAPFCHC[j].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(this.BMODBEEEABE.PIMEHAPFCHC[j], 1f, 1f, 0f, true, false);
				}
			}
			else
			{
				for (int k = 0; k < this.BMODBEEEABE.PIMEHAPFCHC.Count; k++)
				{
					if (this.BMODBEEEABE.PIMEHAPFCHC[k].Contains("layervideo"))
					{
						result = true;
					}
					this.OKIHENOGDKD(this.BMODBEEEABE.PIMEHAPFCHC[k], 1f, 1f, 0f, true, false);
				}
				for (int l = 0; l < this.BMODBEEEABE.HPFHJEAFIHI.Count; l++)
				{
					this.OKIHENOGDKD(this.BMODBEEEABE.HPFHJEAFIHI[l], 0f, 0f, 0f, false, false);
				}
			}
		}
		else if (this.BMODBEEEABE.FPJPHNLANPG >= 2)
		{
			for (int m = 0; m < this.BMODBEEEABE.PIMEHAPFCHC.Count; m++)
			{
				this.CKPJOCNMMIC(this.BMODBEEEABE.PIMEHAPFCHC[m]);
			}
		}
		return result;
	}

	// Token: 0x060087D6 RID: 34774 RVA: 0x003CA9A1 File Offset: 0x003C8BA1
	private IEnumerator BBPBHFNECKG(float LNAOAHMAJKN)
	{
		yield return new WaitForSeconds(LNAOAHMAJKN);
		this.DENNKPJPMBI();
		this.BFOEOHEAPEK(false);
		CommonUserInterface.EHBBFMCILPC.GetFader().FadeOut(new TweenCallback(this.ADCNNKDPHLI));
		yield break;
	}

	// Token: 0x060087D7 RID: 34775 RVA: 0x003CCAF4 File Offset: 0x003CACF4
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

	// Token: 0x060087D8 RID: 34776 RVA: 0x003CCD9D File Offset: 0x003CAF9D
	private void HGFJJFKDBFI()
	{
		this.Hide(false);
	}

	// Token: 0x060087D9 RID: 34777 RVA: 0x003CCDA8 File Offset: 0x003CAFA8
	private void DENNKPJPMBI()
	{
		if (this.BMODBEEEABE.FONKDFDJFEL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlayMusic(this.BMODBEEEABE.FONKDFDJFEL, true, 1f, false);
		}
		if (this.BMODBEEEABE.JLEAIJGBGHL.Length > 0)
		{
			AudioManager.EHBBFMCILPC.PlaySfxNoLoop(this.BMODBEEEABE.JLEAIJGBGHL, false, -1f, -1f);
		}
	}

	// Token: 0x060087DA RID: 34778 RVA: 0x003CCE19 File Offset: 0x003CB019
	private void KCGEJOLENCH()
	{
		this.NMEIFHJFNCN(false);
	}

	// Token: 0x060087DB RID: 34779 RVA: 0x003CCE22 File Offset: 0x003CB022
	private void LFABJIFAAII()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("OnPostEffectSettingsChanged", new UnityAction(this.HGFJJFKDBFI));
		AOBJLALDBAA.FILDBDMENPG().GNBGEMMDGOJ("ZZZ", new UnityAction(this.JKAGHNLDBLM));
	}

	// Token: 0x040025DA RID: 9690
	public const string onCutsceneViewLeft = "OnCutsceneViewLeft";

	// Token: 0x040025DB RID: 9691
	public GameObject content;

	// Token: 0x040025DC RID: 9692
	public GameObject environmentsBackPivot;

	// Token: 0x040025DD RID: 9693
	public GameObject environmentsFrontPivot;

	// Token: 0x040025DE RID: 9694
	public GameObject sharedLayersFrontPivot;

	// Token: 0x040025DF RID: 9695
	public ImageEffectsSelector imageEffects;

	// Token: 0x040025E0 RID: 9696
	public Camera videoPlaybackCamera;

	// Token: 0x040025E1 RID: 9697
	public TextMeshProUGUI descriptionText;

	// Token: 0x040025E2 RID: 9698
	public GameObject backButton;

	// Token: 0x040025E3 RID: 9699
	public GameObject cardInfo;

	// Token: 0x040025E4 RID: 9700
	public Image rarityImage;

	// Token: 0x040025E5 RID: 9701
	public TextMeshProUGUI cardTitle;

	// Token: 0x040025E6 RID: 9702
	public TextMeshProUGUI volumeTitle;

	// Token: 0x040025E7 RID: 9703
	public TextMeshProUGUI cardCopiesTitle;

	// Token: 0x040025E8 RID: 9704
	public TextMeshProUGUI giftCopiesTitle;

	// Token: 0x040025E9 RID: 9705
	public GameObject giftCopies;

	// Token: 0x040025EA RID: 9706
	private TextAsset FJIBKABPIGJ;

	// Token: 0x040025EB RID: 9707
	private List<StoryEnvironmentManager> CHHIBBOICAD = new List<StoryEnvironmentManager>();

	// Token: 0x040025EC RID: 9708
	private List<StoryEnvironmentManager> KEPHFKAHILM = new List<StoryEnvironmentManager>();

	// Token: 0x040025ED RID: 9709
	private List<StoryEnvironmentLayerManager> FAEEEHDCNDN = new List<StoryEnvironmentLayerManager>();

	// Token: 0x040025EE RID: 9710
	private List<AssetStoryItem> BAFONBJIKLA = new List<AssetStoryItem>();

	// Token: 0x040025EF RID: 9711
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();

	// Token: 0x040025F0 RID: 9712
	private RectTransform GFFLNCOEEKP;

	// Token: 0x040025F1 RID: 9713
	private RectTransform MGDOAFNHBHP;

	// Token: 0x040025F2 RID: 9714
	private BNFCLKNDBLO BMODBEEEABE;

	// Token: 0x040025F3 RID: 9715
	private bool JEJJOGFIOKA;

	// Token: 0x040025F4 RID: 9716
	private Coroutine JGGGNGEFDJG;
}
