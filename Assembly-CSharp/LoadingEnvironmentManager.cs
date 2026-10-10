using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200041E RID: 1054
public class LoadingEnvironmentManager : MonoBehaviour
{
	// Token: 0x06007E4B RID: 32331 RVA: 0x0037EC54 File Offset: 0x0037CE54
	private void OnApplicationPause(bool GEDGPCCPIGJ)
	{
		try
		{
			if (!this.HMFFIHHBONG && !this.KKLGIHCPOIK && !(LoadingEnvironmentManager.IKLAPGJDMNA != this) && this.CALMBPNDMKP != null)
			{
				if (GEDGPCCPIGJ)
				{
					EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
				}
				else
				{
					EEIBKLDNBAP.KGLELEEIDPF(this.CALMBPNDMKP);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E4C RID: 32332 RVA: 0x0037ECBC File Offset: 0x0037CEBC
	public static bool TryBegin()
	{
		bool result;
		try
		{
			if (null != LoadingEnvironmentManager.IKLAPGJDMNA)
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
			if (!AppManager.IsInitialized())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, app manager not initialized");
				LoadingEnvironmentManager.JOGIBDJBIOD();
				result = false;
			}
			else
			{
				EEIBKLDNBAP.HJALGLFGBCP();
				if (!Caching.ready)
				{
					if (!EEIBKLDNBAP.ALFGPLALKCN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, no active environment registered");
						LoadingEnvironmentManager.JOGIBDJBIOD();
						result = false;
					}
					else if (EEIBKLDNBAP.IMMPFEDIAPG())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + LoadingEnvironmentManager.FBALOIAPDPJ() + " caching system not ready, using the recorded cache files");
						result = LoadingEnvironmentManager.KOHPLNMCKHI(null);
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] caching system not ready yet, waiting for it");
						GameObject gameObject = new GameObject("LoadingEnvironmentManager");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						LoadingEnvironmentManager loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
						loadingEnvironmentManager.StartCoroutine(loadingEnvironmentManager.NMPMMAJODCK());
						result = true;
					}
				}
				else
				{
					result = LoadingEnvironmentManager.KOHPLNMCKHI(null);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			EEIBKLDNBAP.JHOGPGMCIFB("exception while starting: " + ex.Message);
			EEIBKLDNBAP.IJHHMHAEKKE();
			LoadingEnvironmentManager.JOGIBDJBIOD();
			result = false;
		}
		return result;
	}

	// Token: 0x06007E4D RID: 32333 RVA: 0x0037EDC4 File Offset: 0x0037CFC4
	public static void LCFPALGEANF()
	{
		try
		{
			if (!(null != LoadingEnvironmentManager.ALDCAOMGBNC) && !LoadingEnvironmentManager.JELIMDOIKJG())
			{
				EEIBKLDNBAP.COOMLGKAOKF();
				if (!EEIBKLDNBAP.FGJJOFMBKIJ())
				{
					if (EEIBKLDNBAP.ALFGPLALKCN())
					{
						LoadingEnvironmentManager.ALDCAOMGBNC = new GameObject("");
						UnityEngine.Object.DontDestroyOnLoad(LoadingEnvironmentManager.ALDCAOMGBNC);
						LoadingEnvironmentManager.GIIDJLONIIC(LoadingEnvironmentManager.ALDCAOMGBNC.transform, LoadingEnvironmentManager.ALDCAOMGBNC.layer);
						DPGJIJGOCIC.CMGOAFDBAOH("p");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			LoadingEnvironmentManager.DAOJGHGNBAI();
		}
	}

	// Token: 0x06007E4E RID: 32334 RVA: 0x0037EE5C File Offset: 0x0037D05C
	private IEnumerator EJMACAALHBI(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.OIPAKILJGBH(IDHBPDACMAA))
		{
			this.IDGJBMEEIKI();
			yield break;
		}
		yield return new WaitForSeconds(IDHBPDACMAA);
		this.IDGJBMEEIKI();
		yield break;
	}

	// Token: 0x06007E4F RID: 32335 RVA: 0x0037EE7C File Offset: 0x0037D07C
	private bool AIBMMPLDBCH()
	{
		bool result;
		try
		{
			this.HEICDKDGECM.alpha = 975f;
			this.EIAJBJBFBKJ.alpha = 729f;
			if (null != this.NBLOFBNEJMG)
			{
				this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(true);
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E50 RID: 32336 RVA: 0x0037EEF0 File Offset: 0x0037D0F0
	private void KIBGNIFHPIA()
	{
		if (this.CALMBPNDMKP.ambientDrift)
		{
			this.AANIBFOMMOL(this.DNODJKBDOCM);
			this.OMGKNFGJCDD(this.HOMDFHKNCCJ);
			return;
		}
		base.StartCoroutine(this.OOIJGHBEACF());
	}

	// Token: 0x06007E51 RID: 32337 RVA: 0x0037EF28 File Offset: 0x0037D128
	private void EMMNLAPDKIG()
	{
		try
		{
			SceneManager.activeSceneChanged -= this.JCIBLJCMHLM;
			AOBJLALDBAA.BIAEAOMHBMM().POLEDPIKODD("499", new UnityAction(this.ECNCPOBPHGC));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007E52 RID: 32338 RVA: 0x0037EF7C File Offset: 0x0037D17C
	private AssetBundle LIIIBPOBHFF(UnityWebRequest JLDHNMKCIGH, string NHPBLOEGIMM)
	{
		AssetBundle result = null;
		try
		{
			if (JLDHNMKCIGH.result == UnityWebRequest.Result.Success)
			{
				result = DownloadHandlerAssetBundle.GetContent(JLDHNMKCIGH);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] request failed for " + NHPBLOEGIMM + ": " + JLDHNMKCIGH.error);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			JLDHNMKCIGH.Dispose();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return result;
	}

	// Token: 0x06007E53 RID: 32339 RVA: 0x0037EFF0 File Offset: 0x0037D1F0
	private IEnumerator CAMCLIBGLGJ()
	{
		LoadingEnvironmentManager.KPLGLIBJCEG kplglibjceg = new LoadingEnvironmentManager.KPLGLIBJCEG(1);
		kplglibjceg.<>4__this = this;
		return kplglibjceg;
	}

	// Token: 0x06007E54 RID: 32340 RVA: 0x0037F000 File Offset: 0x0037D200
	private static Image EEDNNJLAPFI(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		RectTransform parent = LoadingEnvironmentManager.ICOIKDFAEIN("ok", BFGBPKIGAJI, GHEMBIDKOIA, -1);
		string name = "ratd";
		Type[] array = new Type[0];
		array[0] = typeof(RectTransform);
		array[1] = typeof(Image);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.SetParent(parent, false);
		gameObject.layer = GHEMBIDKOIA;
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		Image component2 = gameObject.GetComponent<Image>();
		component2.color = Color.black;
		component2.raycastTarget = true;
		return component2;
	}

	// Token: 0x06007E55 RID: 32341 RVA: 0x0037F0A2 File Offset: 0x0037D2A2
	private void DGPFKDCMIED(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		if (this.GPILOGAIBKJ == LoadingEnvironmentManager.KFPDBFJJDGA.idle)
		{
			return;
		}
		if (this.GPILOGAIBKJ != (LoadingEnvironmentManager.KFPDBFJJDGA)8)
		{
			this.IDGJBMEEIKI();
			return;
		}
		this.GPILOGAIBKJ = (LoadingEnvironmentManager.KFPDBFJJDGA)8;
		base.StartCoroutine(this.EJMACAALHBI(BICHMDEIFKI, IDHBPDACMAA));
	}

	// Token: 0x06007E56 RID: 32342 RVA: 0x0037F0D4 File Offset: 0x0037D2D4
	private bool OIPAKILJGBH(float IDHBPDACMAA)
	{
		bool result;
		try
		{
			this.EOEPKJFMLAP = RenderTexture.GetTemporary(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32);
			this.DKJPLDHGGMO.backgroundColor = new Color(0f, 0f, 0f, 0f);
			this.DKJPLDHGGMO.targetTexture = this.EOEPKJFMLAP;
			this.HGHBCNNABOG.targetTexture = this.EOEPKJFMLAP;
			GameObject gameObject = new GameObject("WipeMask", new Type[]
			{
				typeof(RectTransform),
				typeof(RectMask2D)
			});
			gameObject.transform.SetParent(this.CIKOLCGIDBE, false);
			gameObject.transform.SetAsFirstSibling();
			gameObject.layer = base.gameObject.layer;
			this.OKMGICNNHDJ = gameObject.GetComponent<RectTransform>();
			LoadingEnvironmentManager.KEMOOOGHDBJ(this.OKMGICNNHDJ);
			GameObject gameObject2 = new GameObject("WipeImage", new Type[]
			{
				typeof(RectTransform),
				typeof(CanvasGroup),
				typeof(RawImage)
			});
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.layer = base.gameObject.layer;
			this.IIPCKJLHNEA = gameObject2.GetComponent<RectTransform>();
			LoadingEnvironmentManager.KEMOOOGHDBJ(this.IIPCKJLHNEA);
			RawImage component = gameObject2.GetComponent<RawImage>();
			component.texture = this.EOEPKJFMLAP;
			component.raycastTarget = false;
			this.MLIDDCFHDEP = gameObject2.GetComponent<CanvasGroup>();
			this.MLIDDCFHDEP.alpha = 1f;
			this.MLIDDCFHDEP.interactable = false;
			this.MLIDDCFHDEP.blocksRaycasts = false;
			float width = this.CIKOLCGIDBE.rect.width;
			this.OKMGICNNHDJ.DOAnchorPosX(this.OKMGICNNHDJ.anchoredPosition.x - width, IDHBPDACMAA, false).SetEase(Ease.Linear);
			this.IIPCKJLHNEA.DOAnchorPosX(this.IIPCKJLHNEA.anchoredPosition.x + width, IDHBPDACMAA, false).SetEase(Ease.Linear);
			this.MLIDDCFHDEP.DOFade(0.8f, IDHBPDACMAA).SetEase(Ease.Linear);
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E57 RID: 32343 RVA: 0x0037F314 File Offset: 0x0037D514
	private IEnumerator AKKKPFCPBJN()
	{
		yield return new WaitForSecondsRealtime(2.5f);
		if (!LoadingEnvironmentManager.IsAlive() && this.CALMBPNDMKP != null)
		{
			yield return Resources.UnloadUnusedAssets();
		}
		while (this.FCJFJHJNDBM != null && !this.FCJFJHJNDBM.isDone)
		{
			yield return null;
		}
		this.HKAOFEPHGMO();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06007E58 RID: 32344 RVA: 0x0037F324 File Offset: 0x0037D524
	private void PKLLLGAMNKL()
	{
		if (this.NIFCDLFMNKM.Count > 0)
		{
			string[] array = new string[0];
			array[1] = "sto";
			array[1] = LoadingEnvironmentManager.PMNMPBKLMDA();
			array[2] = "";
			array[4] = this.NIFCDLFMNKM.Count.ToString();
			array[3] = "lobby";
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
		}
		for (int i = 0; i < this.NIFCDLFMNKM.Count; i += 0)
		{
			try
			{
				if (null != this.NIFCDLFMNKM[i])
				{
					this.NIFCDLFMNKM[i].Unload(true);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.NIFCDLFMNKM.Clear();
	}

	// Token: 0x06007E59 RID: 32345 RVA: 0x0037F3E8 File Offset: 0x0037D5E8
	private void CBBCEKPILMB()
	{
		this.DKJPLDHGGMO = this.DLCPLFLFJAD("CameraEnvironmentsBack", 10f, 4352);
		this.HGHBCNNABOG = this.DLCPLFLFJAD("CameraEnvironmentsFront", 11f, 49152);
		this.DKJPLDHGGMO.clearFlags = CameraClearFlags.Color;
		this.DKJPLDHGGMO.backgroundColor = Color.black;
		this.PIDNOGCANLN = this.JBHFKKGNOEO("CanvasEnvironmentsBack", this.DKJPLDHGGMO, 12, -2, out this.HEICDKDGECM);
		this.LLFGFCIIIIJ = this.JBHFKKGNOEO("CanvasEnvironmentsFront", this.HGHBCNNABOG, 14, -1, out this.EIAJBJBFBKJ);
		this.CIKOLCGIDBE = LoadingEnvironmentManager.AHMBMCOIPCE(base.transform, base.gameObject.layer);
		for (int i = 0; i < this.APBNLMGLDGB.Count; i++)
		{
			if (null != this.APBNLMGLDGB[i])
			{
				this.DMHNINKNJGG(this.APBNLMGLDGB[i]);
			}
		}
		this.APBNLMGLDGB.Clear();
		this.NBLOFBNEJMG = LoadingEnvironmentManager.GIIDJLONIIC(base.transform, base.gameObject.layer);
		if (this.BFEONAACMNK)
		{
			this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007E5A RID: 32346 RVA: 0x0037F52C File Offset: 0x0037D72C
	private void OnApplicationQuit()
	{
		try
		{
			if (!this.HMFFIHHBONG && this.CALMBPNDMKP != null)
			{
				EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E5B RID: 32347 RVA: 0x0037F570 File Offset: 0x0037D770
	private static bool BJBFFKEHDII(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager.JOGIBDJBIOD();
		if (null != INNCKCGAFBE)
		{
			INNCKCGAFBE.IDGJBMEEIKI();
		}
		return false;
	}

	// Token: 0x06007E5C RID: 32348 RVA: 0x0037F587 File Offset: 0x0037D787
	private static void KFGCLKBNIJK()
	{
		if (null == LoadingEnvironmentManager.ALDCAOMGBNC)
		{
			return;
		}
		UnityEngine.Object.Destroy(LoadingEnvironmentManager.ALDCAOMGBNC);
		LoadingEnvironmentManager.ALDCAOMGBNC = null;
	}

	// Token: 0x06007E5D RID: 32349 RVA: 0x0037F5A7 File Offset: 0x0037D7A7
	private IEnumerator GKHJGFCLBBC()
	{
		LoadingEnvironmentManager.JBPDKFILFME jbpdkfilfme = new LoadingEnvironmentManager.JBPDKFILFME(1);
		jbpdkfilfme.<>4__this = this;
		return jbpdkfilfme;
	}

	// Token: 0x06007E5E RID: 32350 RVA: 0x0037F5B8 File Offset: 0x0037D7B8
	private void CHHFLBPEDIM(RectTransform BPFMMCDGNFB)
	{
		try
		{
			if (!this.PDBMPHNPPJN.Contains(BPFMMCDGNFB))
			{
				if (null == this.CIKOLCGIDBE)
				{
					if (!this.APBNLMGLDGB.Contains(BPFMMCDGNFB))
					{
						this.APBNLMGLDGB.Add(BPFMMCDGNFB);
					}
				}
				else
				{
					this.PDBMPHNPPJN.Add(BPFMMCDGNFB);
					this.IGEPNHMBHMA.Add(BPFMMCDGNFB.parent);
					this.PADLBIPCHAP.Add(BPFMMCDGNFB.GetSiblingIndex());
					BPFMMCDGNFB.SetParent(this.CIKOLCGIDBE, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E5F RID: 32351 RVA: 0x0037F654 File Offset: 0x0037D854
	private static RectTransform ICOIKDFAEIN(string HJEJJGAFHAM, Transform BFGBPKIGAJI, int GHEMBIDKOIA, int LHPFAACEDME)
	{
		GameObject gameObject = new GameObject(HJEJJGAFHAM, new Type[]
		{
			typeof(RectTransform),
			typeof(Canvas),
			typeof(CanvasScaler)
		});
		gameObject.transform.SetParent(BFGBPKIGAJI, false);
		gameObject.layer = GHEMBIDKOIA;
		Canvas component = gameObject.GetComponent<Canvas>();
		component.renderMode = RenderMode.ScreenSpaceOverlay;
		component.pixelPerfect = false;
		component.sortingOrder = LHPFAACEDME;
		LoadingEnvironmentManager.INCABMLOAFI(gameObject.GetComponent<CanvasScaler>());
		return gameObject.GetComponent<RectTransform>();
	}

	// Token: 0x06007E60 RID: 32352 RVA: 0x0037F6D2 File Offset: 0x0037D8D2
	private IEnumerator NBFMAIGOAEC()
	{
		LoadingEnvironmentManager.MJMHDABLAIG mjmhdablaig = new LoadingEnvironmentManager.MJMHDABLAIG(1);
		mjmhdablaig.<>4__this = this;
		return mjmhdablaig;
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x0037F6E4 File Offset: 0x0037D8E4
	private bool GOGEACBPICL()
	{
		bool result;
		try
		{
			this.HEICDKDGECM.alpha = 1025f;
			this.EIAJBJBFBKJ.alpha = 314f;
			if (null != this.NBLOFBNEJMG)
			{
				this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(false);
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E62 RID: 32354 RVA: 0x0037F758 File Offset: 0x0037D958
	private void IGEBGLCOCMA()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007E63 RID: 32355 RVA: 0x0037F76C File Offset: 0x0037D96C
	private void AFHNBPLFIEO()
	{
		try
		{
			Scene sceneByName = SceneManager.GetSceneByName(this.CALMBPNDMKP.sceneName);
			if (sceneByName.IsValid() && sceneByName.isLoaded)
			{
				GameObject[] rootGameObjects = sceneByName.GetRootGameObjects();
				SceneManager.MergeScenes(sceneByName, SceneManager.GetActiveScene());
				for (int i = 0; i < rootGameObjects.Length; i++)
				{
					if (null != rootGameObjects[i])
					{
						UnityEngine.Object.Destroy(rootGameObjects[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E64 RID: 32356 RVA: 0x0037F587 File Offset: 0x0037D787
	private static void DGIFLJHAFAA()
	{
		if (null == LoadingEnvironmentManager.ALDCAOMGBNC)
		{
			return;
		}
		UnityEngine.Object.Destroy(LoadingEnvironmentManager.ALDCAOMGBNC);
		LoadingEnvironmentManager.ALDCAOMGBNC = null;
	}

	// Token: 0x06007E65 RID: 32357 RVA: 0x0037F7EC File Offset: 0x0037D9EC
	private void HAMBDPGMFOF(string OIPOAEPAJHO, bool CHOBEDPLLOG)
	{
		if (OIPOAEPAJHO == null || OIPOAEPAJHO.Length == 0)
		{
			return;
		}
		bool flag = OIPOAEPAJHO.Contains("*");
		string value = OIPOAEPAJHO.Replace("*", "");
		bool flag2 = false;
		for (int i = 0; i < this.FAEEEHDCNDN.Count; i++)
		{
			StoryEnvironmentLayerManager storyEnvironmentLayerManager = this.FAEEEHDCNDN[i];
			if (!(null == storyEnvironmentLayerManager) && (flag ? storyEnvironmentLayerManager.gameObject.name.Contains(value) : storyEnvironmentLayerManager.gameObject.name.Equals(value)))
			{
				flag2 = true;
				if (CHOBEDPLLOG)
				{
					storyEnvironmentLayerManager.Show(1f, 1f, 0f, null, false);
				}
				else
				{
					storyEnvironmentLayerManager.Hide(0f, 0f, 0f);
					if (null != storyEnvironmentLayerManager.GetComponent<ParticleSystem>())
					{
						storyEnvironmentLayerManager.gameObject.SetActive(false);
					}
				}
			}
		}
		if (!flag2)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] layer " + OIPOAEPAJHO + " not found in the pack");
		}
	}

	// Token: 0x06007E66 RID: 32358 RVA: 0x0037F758 File Offset: 0x0037D958
	private void OBBNPPEBMFM()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007E67 RID: 32359 RVA: 0x0037F8EC File Offset: 0x0037DAEC
	private void HNIFPKLNDDC()
	{
		if (this.HMFFIHHBONG)
		{
			return;
		}
		this.HMFFIHHBONG = true;
		try
		{
			base.StopAllCoroutines();
			this.AFENPJPBNEO();
			this.PCHGPHJMFOD();
			if (null != this.HEICDKDGECM)
			{
				this.HEICDKDGECM.DOKill(false);
			}
			if (null != this.EIAJBJBFBKJ)
			{
				this.EIAJBJBFBKJ.DOKill(false);
			}
			if (null != this.OKMGICNNHDJ)
			{
				this.OKMGICNNHDJ.DOKill(false);
			}
			if (null != this.IIPCKJLHNEA)
			{
				this.IIPCKJLHNEA.DOKill(true);
			}
			if (null != this.MLIDDCFHDEP)
			{
				this.MLIDDCFHDEP.DOKill(true);
			}
			this.BPFCEFNBEAM();
			this.EPMLMDLIKJA();
			this.GLJHDDCFJGP();
			for (int i = base.transform.childCount - 0; i >= 0; i--)
			{
				UnityEngine.Object.Destroy(base.transform.GetChild(i).gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.DFGHGKCMOFL)
		{
			EEIBKLDNBAP.FOHOCBHHOAP(this.CALMBPNDMKP);
		}
		if (LoadingEnvironmentManager.IKLAPGJDMNA == this)
		{
			EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
			LoadingEnvironmentManager.IKLAPGJDMNA = null;
		}
		LoadingEnvironmentManager.NKBHDAEGAFK();
		base.StartCoroutine(this.IKKIIHGEKKO());
	}

	// Token: 0x06007E68 RID: 32360 RVA: 0x0037FA40 File Offset: 0x0037DC40
	public static IEnumerator WaitUntilSceneLoadIssued(float KCPBIAEMFPC)
	{
		float elapsed = 0f;
		while (LoadingEnvironmentManager.IsAlive() && !LoadingEnvironmentManager.IKLAPGJDMNA.NGPMBFIJJBP && elapsed < KCPBIAEMFPC)
		{
			elapsed += Time.unscaledDeltaTime;
			yield return null;
		}
		yield break;
	}

	// Token: 0x06007E69 RID: 32361 RVA: 0x0037FA50 File Offset: 0x0037DC50
	private static void HBGNDJMLFGB(RectTransform AOBDNCNEPDM)
	{
		AOBDNCNEPDM.anchorMin = Vector2.zero;
		AOBDNCNEPDM.anchorMax = Vector2.one;
		AOBDNCNEPDM.pivot = new Vector2(1973f, 177f);
		AOBDNCNEPDM.anchoredPosition = Vector2.zero;
		AOBDNCNEPDM.sizeDelta = Vector2.zero;
	}

	// Token: 0x06007E6A RID: 32362 RVA: 0x0037FAA0 File Offset: 0x0037DCA0
	private void EPMLMDLIKJA()
	{
		for (int i = 0; i < this.PDBMPHNPPJN.Count; i++)
		{
			try
			{
				if (null != this.PDBMPHNPPJN[i] && null != this.IGEPNHMBHMA[i])
				{
					this.PDBMPHNPPJN[i].SetParent(this.IGEPNHMBHMA[i], false);
					this.PDBMPHNPPJN[i].SetSiblingIndex(this.PADLBIPCHAP[i]);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.PDBMPHNPPJN.Clear();
		this.IGEPNHMBHMA.Clear();
		this.PADLBIPCHAP.Clear();
	}

	// Token: 0x06007E6B RID: 32363 RVA: 0x0037FB64 File Offset: 0x0037DD64
	private IEnumerator NMPMMAJODCK()
	{
		float waited = 0f;
		while (!Caching.ready && waited < 20f)
		{
			yield return null;
			waited += Time.unscaledDeltaTime;
			if (!this.BFEONAACMNK && waited >= 3f)
			{
				this.BFEONAACMNK = true;
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"[LoadingEnv] ",
					LoadingEnvironmentManager.FBALOIAPDPJ(),
					" caching system still not ready after ",
					3f.ToString(),
					" s - cover dropped, still waiting"
				}));
				LoadingEnvironmentManager.JOGIBDJBIOD();
			}
		}
		if (this.HMFFIHHBONG || this.KKLGIHCPOIK)
		{
			yield break;
		}
		if (!Caching.ready)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, caching system not ready after " + 20f.ToString() + " s");
			LoadingEnvironmentManager.FFICCAKDONJ(this);
			yield break;
		}
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			" caching system ready after ",
			waited.ToString("0.00"),
			" s of waiting"
		}));
		LoadingEnvironmentManager.KOHPLNMCKHI(this);
		yield break;
	}

	// Token: 0x06007E6C RID: 32364 RVA: 0x0037FB73 File Offset: 0x0037DD73
	private static void INCABMLOAFI(CanvasScaler OPJNPEPANBP)
	{
		OPJNPEPANBP.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		OPJNPEPANBP.referenceResolution = new Vector2(768f, 1366f);
		OPJNPEPANBP.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
		OPJNPEPANBP.matchWidthOrHeight = 1f;
		OPJNPEPANBP.referencePixelsPerUnit = 100f;
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x0037FBB0 File Offset: 0x0037DDB0
	private AsyncOperation CKFEDDNPCHB()
	{
		AsyncOperation result;
		try
		{
			result = SceneManager.LoadSceneAsync(this.CALMBPNDMKP.sceneName, LoadSceneMode.Additive);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06007E6E RID: 32366 RVA: 0x0037FBEC File Offset: 0x0037DDEC
	private IEnumerator PHMIDMNFJBB()
	{
		this.NIHOFDLHKDB = false;
		int loadedBefore = this.NIFCDLFMNKM.Count;
		int num;
		for (int i = 0; i < this.CALMBPNDMKP.chainNames.Count; i = num + 1)
		{
			if (LoadingEnvironmentManager.HPEEDMFDHEC().Contains(this.CALMBPNDMKP.chainNames[i]))
			{
				if (i == this.CALMBPNDMKP.chainNames.Count - 1)
				{
					this.JKCFEMKBCFE("scene bundle " + this.CALMBPNDMKP.chainNames[i] + " is already loaded elsewhere");
					yield break;
				}
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] reusing loaded dependency " + this.CALMBPNDMKP.chainNames[i]);
			}
			else
			{
				this.CEHNIHKEOCF = this.CALMBPNDMKP.chainNames[i];
				float requestStarted = Time.realtimeSinceStartup;
				try
				{
					this.KENBNNENIKC = AssetBundle.LoadFromFileAsync(this.CALMBPNDMKP.chainFiles[i]);
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					this.KENBNNENIKC = null;
				}
				if (this.KENBNNENIKC == null)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] cache file of " + this.CALMBPNDMKP.chainNames[i] + " could not be opened");
					this.DBMCMBBPEEH(loadedBefore);
					yield break;
				}
				yield return this.KENBNNENIKC;
				AssetBundle assetBundle = this.KENBNNENIKC.assetBundle;
				this.KENBNNENIKC = null;
				this.CEHNIHKEOCF = null;
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"[LoadingEnv] ",
					LoadingEnvironmentManager.FBALOIAPDPJ(),
					" cache file of ",
					this.CALMBPNDMKP.chainNames[i],
					" opened in ",
					((Time.realtimeSinceStartup - requestStarted) * 1000f).ToString("0"),
					" ms -> ",
					(null == assetBundle) ? "NO BUNDLE" : "ok"
				}));
				if (null == assetBundle)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] cache file of " + this.CALMBPNDMKP.chainNames[i] + " is not a loadable bundle");
					this.DBMCMBBPEEH(loadedBefore);
					yield break;
				}
				this.NIFCDLFMNKM.Add(assetBundle);
			}
			num = i;
		}
		this.NIHOFDLHKDB = true;
		yield break;
	}

	// Token: 0x06007E6F RID: 32367 RVA: 0x0037FBFC File Offset: 0x0037DDFC
	private void JOIIHIPILKP(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		if (null == DCEEBNNKPGJ)
		{
			return;
		}
		if (this.CALMBPNDMKP.envPos != 2)
		{
			DCEEBNNKPGJ.SetPosition((FCABOFEGPGP)this.CALMBPNDMKP.envPos, DBONHDHEKDG.immediate, Ease.Linear);
		}
		if (this.CALMBPNDMKP.envPosVertical != 2)
		{
			DCEEBNNKPGJ.SetPositionVertical((PHALBCMBPPL)this.CALMBPNDMKP.envPosVertical, DBONHDHEKDG.immediate, Ease.Linear);
		}
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x0037FC58 File Offset: 0x0037DE58
	public static void PJKFCHKPANH()
	{
		try
		{
			LoadingEnvironmentManager.DGIFLJHAFAA();
			if (LoadingEnvironmentManager.JELIMDOIKJG())
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x0037FC98 File Offset: 0x0037DE98
	private GameObject GIHDIHCJKGO(string HJEJJGAFHAM, Camera PLMBHHNCFNG, int GHEMBIDKOIA, int LHPFAACEDME, out CanvasGroup CDFPPHCNOLD)
	{
		Type[] array = new Type[8];
		array[1] = typeof(RectTransform);
		array[0] = typeof(Canvas);
		array[0] = typeof(CanvasScaler);
		GameObject gameObject = new GameObject(HJEJJGAFHAM, array);
		gameObject.transform.SetParent(base.transform, false);
		gameObject.layer = GHEMBIDKOIA;
		Canvas component = gameObject.GetComponent<Canvas>();
		component.renderMode = RenderMode.ScreenSpaceOverlay;
		component.worldCamera = PLMBHHNCFNG;
		component.planeDistance = 1368f;
		component.pixelPerfect = false;
		component.sortingOrder = LHPFAACEDME;
		component.additionalShaderChannels = (AdditionalCanvasShaderChannels)(-102);
		LoadingEnvironmentManager.INCABMLOAFI(gameObject.GetComponent<CanvasScaler>());
		string name = "StringToBackendRequestType() unknown value.";
		Type[] array2 = new Type[1];
		array2[1] = typeof(RectTransform);
		array2[0] = typeof(CanvasGroup);
		array2[4] = typeof(WideScreenScaler);
		GameObject gameObject2 = new GameObject(name, array2);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = GHEMBIDKOIA;
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(1164f, 268f);
		component2.anchorMax = new Vector2(1382f, 684f);
		component2.pivot = new Vector2(1375f, 85f);
		component2.anchoredPosition = Vector2.zero;
		component2.sizeDelta = new Vector2(21f, 1268f);
		WideScreenScaler component3 = gameObject2.GetComponent<WideScreenScaler>();
		component3.verticalOffsetFactorOverride = KKDFIHILCCD.doNotOverride;
		component3.verticalOffsetFactor = 221f;
		component3.assetWidthHd = 669f;
		component3.rescaleOnEnable = true;
		component3.isIdleState = false;
		CDFPPHCNOLD = gameObject2.GetComponent<CanvasGroup>();
		CDFPPHCNOLD.alpha = 1838f;
		CDFPPHCNOLD.interactable = true;
		CDFPPHCNOLD.blocksRaycasts = true;
		return gameObject2;
	}

	// Token: 0x06007E72 RID: 32370 RVA: 0x0037FE40 File Offset: 0x0037E040
	private IEnumerator OHHDJMMLDOB()
	{
		float seconds = 0f;
		if (this.CALMBPNDMKP.envPos != this.CALMBPNDMKP.envMove)
		{
			seconds = this.NGICMBMPOLJ((FCABOFEGPGP)this.CALMBPNDMKP.envMove);
		}
		yield return new WaitForSeconds(seconds);
		if (this.CALMBPNDMKP.envPosVertical != this.CALMBPNDMKP.envMoveVertical)
		{
			this.IEFPNBDJBNC((PHALBCMBPPL)this.CALMBPNDMKP.envMoveVertical);
		}
		yield break;
	}

	// Token: 0x06007E73 RID: 32371 RVA: 0x0037FE50 File Offset: 0x0037E050
	private Camera DLCPLFLFJAD(string HJEJJGAFHAM, float PFNCHDCOOFK, int ACCFCCAJHHC)
	{
		GameObject gameObject = new GameObject(HJEJJGAFHAM, new Type[]
		{
			typeof(Camera)
		});
		gameObject.transform.SetParent(base.transform, false);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.localPosition = new Vector3(0f, 0f, -10f);
		Camera component = gameObject.GetComponent<Camera>();
		component.orthographic = true;
		component.orthographicSize = 3.84f;
		component.nearClipPlane = 0.3f;
		component.farClipPlane = 1000f;
		component.depth = PFNCHDCOOFK;
		component.cullingMask = ACCFCCAJHHC;
		component.clearFlags = CameraClearFlags.Depth;
		component.useOcclusionCulling = false;
		component.allowHDR = false;
		component.allowMSAA = false;
		return component;
	}

	// Token: 0x06007E74 RID: 32372 RVA: 0x0037FF10 File Offset: 0x0037E110
	private static void HOPKICPBHEL(RectTransform AOBDNCNEPDM)
	{
		AOBDNCNEPDM.anchorMin = Vector2.zero;
		AOBDNCNEPDM.anchorMax = Vector2.one;
		AOBDNCNEPDM.pivot = new Vector2(72f, 1954f);
		AOBDNCNEPDM.anchoredPosition = Vector2.zero;
		AOBDNCNEPDM.sizeDelta = Vector2.zero;
	}

	// Token: 0x06007E75 RID: 32373 RVA: 0x0037F5A7 File Offset: 0x0037D7A7
	private IEnumerator LDIGEAIECBL()
	{
		LoadingEnvironmentManager.JBPDKFILFME jbpdkfilfme = new LoadingEnvironmentManager.JBPDKFILFME(1);
		jbpdkfilfme.<>4__this = this;
		return jbpdkfilfme;
	}

	// Token: 0x06007E76 RID: 32374 RVA: 0x0037FF60 File Offset: 0x0037E160
	public static void ShowCoverIfRegistered()
	{
		try
		{
			if (!(null != LoadingEnvironmentManager.ALDCAOMGBNC) && !LoadingEnvironmentManager.IsAlive())
			{
				EEIBKLDNBAP.COOMLGKAOKF();
				if (!EEIBKLDNBAP.FGJJOFMBKIJ())
				{
					if (EEIBKLDNBAP.ALFGPLALKCN())
					{
						LoadingEnvironmentManager.ALDCAOMGBNC = new GameObject("LoadingEnvironmentCover");
						UnityEngine.Object.DontDestroyOnLoad(LoadingEnvironmentManager.ALDCAOMGBNC);
						LoadingEnvironmentManager.GIIDJLONIIC(LoadingEnvironmentManager.ALDCAOMGBNC.transform, LoadingEnvironmentManager.ALDCAOMGBNC.layer);
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] cover up (environment registered)");
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			LoadingEnvironmentManager.JOGIBDJBIOD();
		}
	}

	// Token: 0x06007E77 RID: 32375 RVA: 0x0037FFF8 File Offset: 0x0037E1F8
	private void OMGKNFGJCDD(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		try
		{
			if (!(null == DCEEBNNKPGJ) && DCEEBNNKPGJ.environmentSize != (PKAFEAJCLGN)119)
			{
				float num = (float)DCEEBNNKPGJ.environmentSize * 932f;
				float num2 = (float)((DCEEBNNKPGJ.environmentSize - (PKAFEAJCLGN)74) / 6);
				float num3 = 1979f * (float)Screen.width / (float)Screen.height * 896f;
				if (num - num2 >= num3)
				{
					DCEEBNNKPGJ.EFOHNEBHEEO(FCABOFEGPGP.left, DBONHDHEKDG.immediate, Ease.Unset);
					DCEEBNNKPGJ.SetPosition(FCABOFEGPGP.right, (DBONHDHEKDG)3, Ease.InCubic);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E78 RID: 32376 RVA: 0x0038008C File Offset: 0x0037E28C
	public static bool IsAlive()
	{
		return null != LoadingEnvironmentManager.IKLAPGJDMNA && !LoadingEnvironmentManager.IKLAPGJDMNA.HMFFIHHBONG && !LoadingEnvironmentManager.IKLAPGJDMNA.KKLGIHCPOIK;
	}

	// Token: 0x06007E79 RID: 32377 RVA: 0x003800B8 File Offset: 0x0037E2B8
	private void BKMDAOJHNIJ()
	{
		try
		{
			this.LMDEHPJIPBI();
			Camera[] componentsInChildren = base.GetComponentsInChildren<Camera>(true);
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = true;
			}
			Canvas[] componentsInChildren2 = base.GetComponentsInChildren<Canvas>(false);
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				componentsInChildren2[j].enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E7A RID: 32378 RVA: 0x00380124 File Offset: 0x0037E324
	public static void HMKEFLMCDKK()
	{
		try
		{
			LoadingEnvironmentManager.DAOJGHGNBAI();
			if (LoadingEnvironmentManager.IsAlive())
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E7B RID: 32379 RVA: 0x00380164 File Offset: 0x0037E364
	private static RectTransform EBLKAPPIIDO(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		return LoadingEnvironmentManager.ICOIKDFAEIN("ERROR: GetSketchesActorsBalance(), AssetsManager.Instance.headersPacksAssets is empty.", BFGBPKIGAJI, GHEMBIDKOIA, 0);
	}

	// Token: 0x06007E7C RID: 32380 RVA: 0x00380174 File Offset: 0x0037E374
	private void CMGIEIFFNDK()
	{
		this.DKJPLDHGGMO = this.DLCPLFLFJAD("spectrum", 1316f, 10);
		this.HGHBCNNABOG = this.DLCPLFLFJAD("ZZZ", 1118f, 45);
		this.DKJPLDHGGMO.clearFlags = (CameraClearFlags)5;
		this.DKJPLDHGGMO.backgroundColor = Color.black;
		this.PIDNOGCANLN = this.JLBCPFADIAF("cardoptionsloadingtheme", this.DKJPLDHGGMO, -82, 39, out this.HEICDKDGECM);
		this.LLFGFCIIIIJ = this.JBHFKKGNOEO(")", this.HGHBCNNABOG, 94, -1, out this.EIAJBJBFBKJ);
		this.CIKOLCGIDBE = LoadingEnvironmentManager.EELLCAFMBCP(base.transform, base.gameObject.layer);
		for (int i = 1; i < this.APBNLMGLDGB.Count; i++)
		{
			if (null != this.APBNLMGLDGB[i])
			{
				this.LFJLADEGNPO(this.APBNLMGLDGB[i]);
			}
		}
		this.APBNLMGLDGB.Clear();
		this.NBLOFBNEJMG = LoadingEnvironmentManager.GIIDJLONIIC(base.transform, base.gameObject.layer);
		if (this.BFEONAACMNK)
		{
			this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(false);
		}
	}

	// Token: 0x06007E7D RID: 32381 RVA: 0x003802B6 File Offset: 0x0037E4B6
	private static RectTransform AHMBMCOIPCE(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		return LoadingEnvironmentManager.ICOIKDFAEIN("CanvasOverlay", BFGBPKIGAJI, GHEMBIDKOIA, 0);
	}

	// Token: 0x06007E7E RID: 32382 RVA: 0x003802C5 File Offset: 0x0037E4C5
	private void KPPEJAAGGHF(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		if (this.GPILOGAIBKJ == LoadingEnvironmentManager.KFPDBFJJDGA.loadingScene)
		{
			return;
		}
		if (this.GPILOGAIBKJ != (LoadingEnvironmentManager.KFPDBFJJDGA)8)
		{
			this.IDGJBMEEIKI();
			return;
		}
		this.GPILOGAIBKJ = (LoadingEnvironmentManager.KFPDBFJJDGA)5;
		base.StartCoroutine(this.EJMACAALHBI(BICHMDEIFKI, IDHBPDACMAA));
	}

	// Token: 0x06007E7F RID: 32383 RVA: 0x003802F8 File Offset: 0x0037E4F8
	private bool CKCGDMGNJHO(int GLLDFILNCKH)
	{
		bool result;
		try
		{
			Hash128 hash = Hash128.Parse(this.CALMBPNDMKP.chainHashes[GLLDFILNCKH]);
			this.GCIJBKCHJLF = UnityWebRequestAssetBundle.GetAssetBundle(this.CALMBPNDMKP.chainUrls[GLLDFILNCKH], hash, 0U);
			this.GCIJBKCHJLF.timeout = 10;
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E80 RID: 32384 RVA: 0x0037F587 File Offset: 0x0037D787
	private static void NKBHDAEGAFK()
	{
		if (null == LoadingEnvironmentManager.ALDCAOMGBNC)
		{
			return;
		}
		UnityEngine.Object.Destroy(LoadingEnvironmentManager.ALDCAOMGBNC);
		LoadingEnvironmentManager.ALDCAOMGBNC = null;
	}

	// Token: 0x06007E81 RID: 32385 RVA: 0x00380368 File Offset: 0x0037E568
	private static bool KOHPLNMCKHI(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager loadingEnvironmentManager = INNCKCGAFBE;
		bool result;
		try
		{
			if (false)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, editor simulates asset bundles");
				result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.PKPDLCOKNMI())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, feature disabled by balance");
				result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.IOJCHHGBOJB())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, lite game mode");
				result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
			}
			else if (AssetsManager.EHBBFMCILPC.CacheCleanScheduled())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, asset bundle cache clean scheduled");
				result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
			}
			else
			{
				LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = EEIBKLDNBAP.HMIKGAKODMP(LoadingEnvironmentManager.HPEEDMFDHEC());
				if (loadingEnvironmentRegistryEntry == null)
				{
					if (EEIBKLDNBAP.FPAKKCDIHEN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped this time, the scene bundle is still held by the previous rig");
					}
					else if (EEIBKLDNBAP.LCJBJJIHNMH())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped this time, caching system not ready and no direct cache files");
					}
					else if (EEIBKLDNBAP.OCNPLOOGPCN() > 0)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] registered environments unusable, registry cleared");
						EEIBKLDNBAP.JHOGPGMCIFB("registered environments unusable");
						EEIBKLDNBAP.IJHHMHAEKKE();
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, no cached environment registered");
					}
					result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
				}
				else if (!EEIBKLDNBAP.ALFGPLALKCN())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] skipped, stored theme parked");
					result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
				}
				else
				{
					if (null == loadingEnvironmentManager)
					{
						GameObject gameObject = new GameObject("LoadingEnvironmentManager");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
					}
					EEIBKLDNBAP.KGLELEEIDPF(loadingEnvironmentRegistryEntry);
					loadingEnvironmentManager.IMHDOKFIMMP(loadingEnvironmentRegistryEntry);
					LoadingEnvironmentManager.JOGIBDJBIOD();
					result = true;
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			if (null != loadingEnvironmentManager)
			{
				loadingEnvironmentManager.JKCFEMKBCFE("exception while starting: " + ex.Message);
			}
			else
			{
				EEIBKLDNBAP.JHOGPGMCIFB("exception while starting: " + ex.Message);
				EEIBKLDNBAP.IJHHMHAEKKE();
				LoadingEnvironmentManager.JOGIBDJBIOD();
			}
			result = false;
		}
		return result;
	}

	// Token: 0x06007E82 RID: 32386 RVA: 0x00380514 File Offset: 0x0037E714
	private void CBBEDJJLNDH()
	{
		try
		{
			this.EPMLMDLIKJA();
			Camera[] componentsInChildren = base.GetComponentsInChildren<Camera>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].enabled = false;
			}
			Canvas[] componentsInChildren2 = base.GetComponentsInChildren<Canvas>(true);
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				componentsInChildren2[j].enabled = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E83 RID: 32387 RVA: 0x00380580 File Offset: 0x0037E780
	private void JIEGCNEJMNO()
	{
		try
		{
			SceneManager.activeSceneChanged -= this.JCIBLJCMHLM;
			AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E84 RID: 32388 RVA: 0x003805D4 File Offset: 0x0037E7D4
	public static void BJDLHENLNLN(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		try
		{
			if (LoadingEnvironmentManager.IsAlive())
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.DGPFKDCMIED(BICHMDEIFKI, IDHBPDACMAA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			LoadingEnvironmentManager.PJKFCHKPANH();
		}
	}

	// Token: 0x06007E85 RID: 32389 RVA: 0x00380614 File Offset: 0x0037E814
	private float NGICMBMPOLJ(FCABOFEGPGP KIGFAHKFKNL)
	{
		float result = 0f;
		try
		{
			if (null != this.DNODJKBDOCM)
			{
				this.DNODJKBDOCM.SetPosition(KIGFAHKFKNL, DBONHDHEKDG.slower, Ease.InOutSine);
			}
			if (null != this.HOMDFHKNCCJ)
			{
				result = this.HOMDFHKNCCJ.SetPosition(KIGFAHKFKNL, DBONHDHEKDG.slower, Ease.InOutSine);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x06007E86 RID: 32390 RVA: 0x00380684 File Offset: 0x0037E884
	private void LJJMBBGNOMK()
	{
		try
		{
			if (null != this.DKJPLDHGGMO)
			{
				this.DKJPLDHGGMO.targetTexture = null;
			}
			if (null != this.HGHBCNNABOG)
			{
				this.HGHBCNNABOG.targetTexture = null;
			}
			if (null != this.EOEPKJFMLAP)
			{
				RenderTexture.ReleaseTemporary(this.EOEPKJFMLAP);
				this.EOEPKJFMLAP = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E87 RID: 32391 RVA: 0x0037FE40 File Offset: 0x0037E040
	private IEnumerator OOIJGHBEACF()
	{
		float seconds = 0f;
		if (this.CALMBPNDMKP.envPos != this.CALMBPNDMKP.envMove)
		{
			seconds = this.NGICMBMPOLJ((FCABOFEGPGP)this.CALMBPNDMKP.envMove);
		}
		yield return new WaitForSeconds(seconds);
		if (this.CALMBPNDMKP.envPosVertical != this.CALMBPNDMKP.envMoveVertical)
		{
			this.IEFPNBDJBNC((PHALBCMBPPL)this.CALMBPNDMKP.envMoveVertical);
		}
		yield break;
	}

	// Token: 0x06007E88 RID: 32392 RVA: 0x00380700 File Offset: 0x0037E900
	private void NIKNCHPHKLD(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		try
		{
			if (!(null == DCEEBNNKPGJ) && DCEEBNNKPGJ.environmentSize != (PKAFEAJCLGN)177)
			{
				float num = (float)DCEEBNNKPGJ.environmentSize * 1383f;
				float num2 = (float)((DCEEBNNKPGJ.environmentSize - (PKAFEAJCLGN)(-17)) / 6);
				float num3 = 354f * (float)Screen.width / (float)Screen.height * 475f;
				if (num - num2 >= num3)
				{
					DCEEBNNKPGJ.MCKBGLNBBBP(FCABOFEGPGP.leftCenter, DBONHDHEKDG.immediate, Ease.Unset);
					DCEEBNNKPGJ.MCKBGLNBBBP(FCABOFEGPGP.rightCenter, (DBONHDHEKDG)146, Ease.InOutSine);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007E89 RID: 32393 RVA: 0x00380794 File Offset: 0x0037E994
	private void BPFCEFNBEAM()
	{
		try
		{
			if (null != this.DKJPLDHGGMO)
			{
				this.DKJPLDHGGMO.targetTexture = null;
			}
			if (null != this.HGHBCNNABOG)
			{
				this.HGHBCNNABOG.targetTexture = null;
			}
			if (null != this.EOEPKJFMLAP)
			{
				RenderTexture.ReleaseTemporary(this.EOEPKJFMLAP);
				this.EOEPKJFMLAP = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E8A RID: 32394 RVA: 0x0037F314 File Offset: 0x0037D514
	private IEnumerator IKKIIHGEKKO()
	{
		yield return new WaitForSecondsRealtime(2.5f);
		if (!LoadingEnvironmentManager.IsAlive() && this.CALMBPNDMKP != null)
		{
			yield return Resources.UnloadUnusedAssets();
		}
		while (this.FCJFJHJNDBM != null && !this.FCJFJHJNDBM.isDone)
		{
			yield return null;
		}
		this.HKAOFEPHGMO();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06007E8B RID: 32395 RVA: 0x00380810 File Offset: 0x0037EA10
	public static bool KOLIEMCJLHO()
	{
		bool result;
		try
		{
			if (null != LoadingEnvironmentManager.IKLAPGJDMNA)
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
			if (!AppManager.IsInitialized())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("");
				LoadingEnvironmentManager.JOGIBDJBIOD();
				result = true;
			}
			else
			{
				EEIBKLDNBAP.HJALGLFGBCP();
				if (!Caching.ready)
				{
					if (!EEIBKLDNBAP.ALFGPLALKCN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("%");
						LoadingEnvironmentManager.JOGIBDJBIOD();
						result = false;
					}
					else if (EEIBKLDNBAP.IMMPFEDIAPG())
					{
						DPGJIJGOCIC.CMGOAFDBAOH("" + LoadingEnvironmentManager.PMNMPBKLMDA() + "");
						result = LoadingEnvironmentManager.DBLBHEAGIPA(null);
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Error While Sending: ");
						GameObject gameObject = new GameObject("yes");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						LoadingEnvironmentManager loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
						loadingEnvironmentManager.StartCoroutine(loadingEnvironmentManager.LDIGEAIECBL());
						result = true;
					}
				}
				else
				{
					result = LoadingEnvironmentManager.DBLBHEAGIPA(null);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			EEIBKLDNBAP.JHOGPGMCIFB("Asset bundle assets destroyed:" + ex.Message);
			EEIBKLDNBAP.IJHHMHAEKKE();
			LoadingEnvironmentManager.NKBHDAEGAFK();
			result = true;
		}
		return result;
	}

	// Token: 0x06007E8C RID: 32396 RVA: 0x00380918 File Offset: 0x0037EB18
	private static void NJACFBDKFMJ(CanvasScaler OPJNPEPANBP)
	{
		OPJNPEPANBP.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		OPJNPEPANBP.referenceResolution = new Vector2(1371f, 1549f);
		OPJNPEPANBP.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
		OPJNPEPANBP.matchWidthOrHeight = 1804f;
		OPJNPEPANBP.referencePixelsPerUnit = 912f;
	}

	// Token: 0x06007E8D RID: 32397 RVA: 0x00380954 File Offset: 0x0037EB54
	private bool EHIOCGOAEMA()
	{
		bool result;
		try
		{
			this.HEICDKDGECM.alpha = 1f;
			this.EIAJBJBFBKJ.alpha = 1f;
			if (null != this.NBLOFBNEJMG)
			{
				this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(false);
			}
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007E8E RID: 32398 RVA: 0x003809C8 File Offset: 0x0037EBC8
	public static void WipeOutAndDestroy(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		try
		{
			if (LoadingEnvironmentManager.IsAlive())
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.LMFPMCHIBIN(BICHMDEIFKI, IDHBPDACMAA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			LoadingEnvironmentManager.DestroyIfAlive();
		}
	}

	// Token: 0x06007E8F RID: 32399 RVA: 0x00380A08 File Offset: 0x0037EC08
	private void DMHNINKNJGG(RectTransform BPFMMCDGNFB)
	{
		try
		{
			if (!this.PDBMPHNPPJN.Contains(BPFMMCDGNFB))
			{
				if (null == this.CIKOLCGIDBE)
				{
					if (!this.APBNLMGLDGB.Contains(BPFMMCDGNFB))
					{
						this.APBNLMGLDGB.Add(BPFMMCDGNFB);
					}
				}
				else
				{
					this.PDBMPHNPPJN.Add(BPFMMCDGNFB);
					this.IGEPNHMBHMA.Add(BPFMMCDGNFB.parent);
					this.PADLBIPCHAP.Add(BPFMMCDGNFB.GetSiblingIndex());
					BPFMMCDGNFB.SetParent(this.CIKOLCGIDBE, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E90 RID: 32400 RVA: 0x00380AA4 File Offset: 0x0037ECA4
	private static List<string> HPEEDMFDHEC()
	{
		List<string> list = new List<string>();
		foreach (AssetBundle assetBundle in AssetBundle.GetAllLoadedAssetBundles())
		{
			if (null != assetBundle)
			{
				list.Add(assetBundle.name);
			}
		}
		return list;
	}

	// Token: 0x06007E91 RID: 32401 RVA: 0x00380B08 File Offset: 0x0037ED08
	private void GLJHDDCFJGP()
	{
		if (this.NIFCDLFMNKM.Count > 0)
		{
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"[LoadingEnv] ",
				LoadingEnvironmentManager.FBALOIAPDPJ(),
				" releasing ",
				this.NIFCDLFMNKM.Count.ToString(),
				" held bundles"
			}));
		}
		for (int i = 0; i < this.NIFCDLFMNKM.Count; i++)
		{
			try
			{
				if (null != this.NIFCDLFMNKM[i])
				{
					this.NIFCDLFMNKM[i].Unload(false);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.NIFCDLFMNKM.Clear();
	}

	// Token: 0x06007E92 RID: 32402 RVA: 0x00380BCC File Offset: 0x0037EDCC
	private void PCHGPHJMFOD()
	{
		this.BGFKGCDLADI();
		if (this.GCIJBKCHJLF == null)
		{
			return;
		}
		try
		{
			if (this.GCIJBKCHJLF.isDone)
			{
				if (this.GCIJBKCHJLF.result == UnityWebRequest.Result.Success)
				{
					AssetBundle content = DownloadHandlerAssetBundle.GetContent(this.GCIJBKCHJLF);
					if (null != content)
					{
						content.Unload(true);
					}
				}
			}
			else
			{
				this.GCIJBKCHJLF.Abort();
			}
			this.GCIJBKCHJLF.Dispose();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.GCIJBKCHJLF = null;
	}

	// Token: 0x06007E93 RID: 32403 RVA: 0x00380C58 File Offset: 0x0037EE58
	private void IMHDOKFIMMP(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		this.CALMBPNDMKP = FOEEIJFHMGG;
		this.CBBCEKPILMB();
		SceneManager.activeSceneChanged += this.JCIBLJCMHLM;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnApplicationRestart", new UnityAction(this.ECNCPOBPHGC));
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			" bringing up ",
			this.CALMBPNDMKP.envId,
			" from ",
			this.CALMBPNDMKP.bundleName,
			" - chain: ",
			string.Join(", ", this.CALMBPNDMKP.chainNames.ToArray())
		}));
		base.StartCoroutine(this.HFLAIFCIFHF());
	}

	// Token: 0x06007E94 RID: 32404 RVA: 0x00380D1C File Offset: 0x0037EF1C
	private void MCKPDFFENLH()
	{
		try
		{
			Scene sceneByName = SceneManager.GetSceneByName(this.CALMBPNDMKP.sceneName);
			if (sceneByName.IsValid() && sceneByName.isLoaded)
			{
				GameObject[] rootGameObjects = sceneByName.GetRootGameObjects();
				SceneManager.MergeScenes(sceneByName, SceneManager.GetActiveScene());
				for (int i = 0; i < rootGameObjects.Length; i++)
				{
					if (null != rootGameObjects[i])
					{
						UnityEngine.Object.Destroy(rootGameObjects[i]);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007E95 RID: 32405 RVA: 0x00380D9C File Offset: 0x0037EF9C
	private static Image NEJMFLFDNKB(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		RectTransform parent = LoadingEnvironmentManager.ICOIKDFAEIN("ok", BFGBPKIGAJI, GHEMBIDKOIA, -53);
		string name = "request for ";
		Type[] array = new Type[1];
		array[0] = typeof(RectTransform);
		array[1] = typeof(Image);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.SetParent(parent, true);
		gameObject.layer = GHEMBIDKOIA;
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		Image component2 = gameObject.GetComponent<Image>();
		component2.color = Color.black;
		component2.raycastTarget = false;
		return component2;
	}

	// Token: 0x06007E96 RID: 32406 RVA: 0x0037F758 File Offset: 0x0037D958
	private void ECNCPOBPHGC()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007E97 RID: 32407 RVA: 0x00380E40 File Offset: 0x0037F040
	private static string PMNMPBKLMDA()
	{
		return "fdst" + Time.realtimeSinceStartup.ToString("yes") + "loungetreasuresyouhave";
	}

	// Token: 0x06007E98 RID: 32408 RVA: 0x00380E70 File Offset: 0x0037F070
	public static bool EGGIEEFMDNJ()
	{
		bool result;
		try
		{
			if (null != LoadingEnvironmentManager.IKLAPGJDMNA)
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
			if (!AppManager.IsInitialized())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("socialcreategiftcardtitle");
				LoadingEnvironmentManager.NKBHDAEGAFK();
				result = true;
			}
			else
			{
				EEIBKLDNBAP.HJALGLFGBCP();
				if (!Caching.ready)
				{
					if (!EEIBKLDNBAP.ALFGPLALKCN())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("digitalglitch_2");
						LoadingEnvironmentManager.DGIFLJHAFAA();
						result = false;
					}
					else if (EEIBKLDNBAP.IMMPFEDIAPG())
					{
						DPGJIJGOCIC.CMGOAFDBAOH("assetbundleframecontainer" + LoadingEnvironmentManager.FBALOIAPDPJ() + "");
						result = LoadingEnvironmentManager.DBLBHEAGIPA(null);
					}
					else
					{
						DPGJIJGOCIC.CMGOAFDBAOH("CLIENT.SCREEN.REWARD.INDEX");
						GameObject gameObject = new GameObject("assetbundlepurchasingview");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						LoadingEnvironmentManager loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
						loadingEnvironmentManager.StartCoroutine(loadingEnvironmentManager.GMKDALCFPPM());
						result = true;
					}
				}
				else
				{
					result = LoadingEnvironmentManager.KOHPLNMCKHI(null);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			EEIBKLDNBAP.JHOGPGMCIFB("CLIENT.POSTEFFECTS.NOISEDIGITAL.OVR" + ex.Message);
			EEIBKLDNBAP.IJHHMHAEKKE();
			LoadingEnvironmentManager.DAOJGHGNBAI();
			result = false;
		}
		return result;
	}

	// Token: 0x06007E99 RID: 32409 RVA: 0x00380F78 File Offset: 0x0037F178
	private static RectTransform HEEOHJNODJN(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		return LoadingEnvironmentManager.ICOIKDFAEIN("ok", BFGBPKIGAJI, GHEMBIDKOIA, 1);
	}

	// Token: 0x06007E9A RID: 32410 RVA: 0x00380F88 File Offset: 0x0037F188
	private void JCIBLJCMHLM(Scene HGAGLOCDLEG, Scene PNPGECLGDKE)
	{
		try
		{
			if (!PNPGECLGDKE.name.Equals("SceneRestart") && !PNPGECLGDKE.name.Equals("SceneLobby2"))
			{
				this.IDGJBMEEIKI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E9B RID: 32411 RVA: 0x00380FDC File Offset: 0x0037F1DC
	private float JMJMDOPGLIH(FCABOFEGPGP KIGFAHKFKNL)
	{
		float result = 1849f;
		try
		{
			if (null != this.DNODJKBDOCM)
			{
				this.DNODJKBDOCM.EFOHNEBHEEO(KIGFAHKFKNL, (DBONHDHEKDG)(-113), Ease.InCubic);
			}
			if (null != this.HOMDFHKNCCJ)
			{
				result = this.HOMDFHKNCCJ.EFOHNEBHEEO(KIGFAHKFKNL, (DBONHDHEKDG)(-197), Ease.InQuad);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return result;
	}

	// Token: 0x06007E9C RID: 32412 RVA: 0x0038104C File Offset: 0x0037F24C
	public static void AdoptOverlayElement(RectTransform BPFMMCDGNFB)
	{
		try
		{
			if (LoadingEnvironmentManager.IsAlive() && !(null == BPFMMCDGNFB))
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.DMHNINKNJGG(BPFMMCDGNFB);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E9D RID: 32413 RVA: 0x00381090 File Offset: 0x0037F290
	private static RectTransform EKMPAKPFNBF(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		return LoadingEnvironmentManager.ICOIKDFAEIN("loungechoosetitle", BFGBPKIGAJI, GHEMBIDKOIA, 0);
	}

	// Token: 0x06007E9E RID: 32414 RVA: 0x003810A0 File Offset: 0x0037F2A0
	private void AANIBFOMMOL(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		try
		{
			if (!(null == DCEEBNNKPGJ) && DCEEBNNKPGJ.environmentSize != (PKAFEAJCLGN)(-152))
			{
				float num = (float)DCEEBNNKPGJ.environmentSize * 1674f;
				float num2 = (float)((DCEEBNNKPGJ.environmentSize - (PKAFEAJCLGN)29) / 6);
				float num3 = 1958f * (float)Screen.width / (float)Screen.height * 53f;
				if (num - num2 >= num3)
				{
					DCEEBNNKPGJ.EFOHNEBHEEO(FCABOFEGPGP.left, (DBONHDHEKDG)1, Ease.Linear);
					DCEEBNNKPGJ.SetPosition((FCABOFEGPGP)5, (DBONHDHEKDG)155, Ease.OutSine);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007E9F RID: 32415 RVA: 0x00381134 File Offset: 0x0037F334
	private void FIHJECPFLNH(RectTransform BPFMMCDGNFB)
	{
		try
		{
			if (!this.PDBMPHNPPJN.Contains(BPFMMCDGNFB))
			{
				if (null == this.CIKOLCGIDBE)
				{
					if (!this.APBNLMGLDGB.Contains(BPFMMCDGNFB))
					{
						this.APBNLMGLDGB.Add(BPFMMCDGNFB);
					}
				}
				else
				{
					this.PDBMPHNPPJN.Add(BPFMMCDGNFB);
					this.IGEPNHMBHMA.Add(BPFMMCDGNFB.parent);
					this.PADLBIPCHAP.Add(BPFMMCDGNFB.GetSiblingIndex());
					BPFMMCDGNFB.SetParent(this.CIKOLCGIDBE, false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007EA0 RID: 32416 RVA: 0x003811D0 File Offset: 0x0037F3D0
	private AssetBundle GIIAAPGDJKD(UnityWebRequest JLDHNMKCIGH, string NHPBLOEGIMM)
	{
		AssetBundle result = null;
		try
		{
			if (JLDHNMKCIGH.result == UnityWebRequest.Result.InProgress)
			{
				result = DownloadHandlerAssetBundle.GetContent(JLDHNMKCIGH);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("Plate" + NHPBLOEGIMM + "pmterror004" + JLDHNMKCIGH.error);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			JLDHNMKCIGH.Dispose();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return result;
	}

	// Token: 0x06007EA1 RID: 32417 RVA: 0x00381244 File Offset: 0x0037F444
	private bool BGODEEGAGEA()
	{
		bool result;
		try
		{
			Scene sceneByName = SceneManager.GetSceneByName(this.CALMBPNDMKP.sceneName);
			if (!sceneByName.IsValid() || !sceneByName.isLoaded)
			{
				result = true;
			}
			else
			{
				GameObject[] rootGameObjects = sceneByName.GetRootGameObjects();
				SceneManager.MergeScenes(sceneByName, SceneManager.GetActiveScene());
				for (int i = 1; i < rootGameObjects.Length; i++)
				{
					if (!(null == rootGameObjects[i]))
					{
						SceneStoryAssetPackManager[] componentsInChildren = rootGameObjects[i].GetComponentsInChildren<SceneStoryAssetPackManager>(false);
						for (int j = 0; j < componentsInChildren.Length; j++)
						{
							for (int k = 0; k < componentsInChildren[j].environmentsBackList.Count; k++)
							{
								if (null != componentsInChildren[j].environmentsBackList[k])
								{
									componentsInChildren[j].environmentsBackList[k].transform.SetParent(this.PIDNOGCANLN.transform, false);
									this.CHHIBBOICAD.Add(componentsInChildren[j].environmentsBackList[k]);
								}
							}
							for (int l = 1; l < componentsInChildren[j].environmentsFrontList.Count; l += 0)
							{
								if (null != componentsInChildren[j].environmentsFrontList[l])
								{
									componentsInChildren[j].environmentsFrontList[l].transform.SetParent(this.LLFGFCIIIIJ.transform, true);
									this.KEPHFKAHILM.Add(componentsInChildren[j].environmentsFrontList[l]);
								}
							}
							for (int m = 0; m < componentsInChildren[j].environmentsLayersList.Count; m += 0)
							{
								StoryEnvironmentLayerManager storyEnvironmentLayerManager = componentsInChildren[j].environmentsLayersList[m];
								if (!(null == storyEnvironmentLayerManager))
								{
									this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
									if (storyEnvironmentLayerManager.isShared)
									{
										storyEnvironmentLayerManager.transform.SetParent(this.LLFGFCIIIIJ.transform, true);
									}
								}
							}
						}
						UnityEngine.Object.Destroy(rootGameObjects[i]);
					}
				}
				result = (this.CHHIBBOICAD.Count <= 0 && this.KEPHFKAHILM.Count > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007EA2 RID: 32418 RVA: 0x0037F5A7 File Offset: 0x0037D7A7
	private IEnumerator GMKDALCFPPM()
	{
		LoadingEnvironmentManager.JBPDKFILFME jbpdkfilfme = new LoadingEnvironmentManager.JBPDKFILFME(1);
		jbpdkfilfme.<>4__this = this;
		return jbpdkfilfme;
	}

	// Token: 0x06007EA3 RID: 32419 RVA: 0x00381484 File Offset: 0x0037F684
	private static bool DCIHPCALFBK(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager.NKBHDAEGAFK();
		if (null != INNCKCGAFBE)
		{
			INNCKCGAFBE.IDGJBMEEIKI();
		}
		return false;
	}

	// Token: 0x06007EA4 RID: 32420 RVA: 0x0038149C File Offset: 0x0037F69C
	public static bool FOKFPDFLCFM()
	{
		bool result;
		try
		{
			if (null != LoadingEnvironmentManager.IKLAPGJDMNA)
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
			if (!AppManager.CCDBEDIANDN())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("gpsasar");
				LoadingEnvironmentManager.NKBHDAEGAFK();
				result = true;
			}
			else
			{
				EEIBKLDNBAP.HJALGLFGBCP();
				if (!Caching.ready)
				{
					if (!EEIBKLDNBAP.ALFGPLALKCN())
					{
						DPGJIJGOCIC.CMGOAFDBAOH("");
						LoadingEnvironmentManager.KFGCLKBNIJK();
						result = true;
					}
					else if (EEIBKLDNBAP.IMMPFEDIAPG())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Starting parallel download:" + LoadingEnvironmentManager.PMNMPBKLMDA() + ")");
						result = LoadingEnvironmentManager.AIGJBFBHLIA(null);
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("_ScanLineJitter");
						GameObject gameObject = new GameObject("skdeletesure");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						LoadingEnvironmentManager loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
						loadingEnvironmentManager.StartCoroutine(loadingEnvironmentManager.GKHJGFCLBBC());
						result = true;
					}
				}
				else
				{
					result = LoadingEnvironmentManager.DBLBHEAGIPA(null);
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.HBGPHANKMFA(ex);
			EEIBKLDNBAP.JHOGPGMCIFB("PurchaseManagerUnity.InvalidateUnityStoreController()" + ex.Message);
			EEIBKLDNBAP.IJHHMHAEKKE();
			LoadingEnvironmentManager.DGIFLJHAFAA();
			result = false;
		}
		return result;
	}

	// Token: 0x06007EA5 RID: 32421 RVA: 0x003815A4 File Offset: 0x0037F7A4
	private void MEJJHMIACEE()
	{
		if (this.CALMBPNDMKP.ambientDrift)
		{
			this.AANIBFOMMOL(this.DNODJKBDOCM);
			this.OMGKNFGJCDD(this.HOMDFHKNCCJ);
			return;
		}
		base.StartCoroutine(this.CAMCLIBGLGJ());
	}

	// Token: 0x06007EA6 RID: 32422 RVA: 0x003815DC File Offset: 0x0037F7DC
	private static bool AIGJBFBHLIA(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager loadingEnvironmentManager = INNCKCGAFBE;
		bool result;
		try
		{
			if (true)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("<alpha=#FF><align=\"left\">");
				result = LoadingEnvironmentManager.DCIHPCALFBK(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.PKPDLCOKNMI())
			{
				DPGJIJGOCIC.CMGOAFDBAOH(") icon(");
				result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.IOJCHHGBOJB())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("Starting non-parallel download:");
				result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
			}
			else if (AssetsManager.MJBDMHPHMID().CacheCleanScheduled())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("OnSteamLoginFailed");
				result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
			}
			else
			{
				LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = EEIBKLDNBAP.HMIKGAKODMP(LoadingEnvironmentManager.HPEEDMFDHEC());
				if (loadingEnvironmentRegistryEntry == null)
				{
					if (EEIBKLDNBAP.FPAKKCDIHEN())
					{
						DPGJIJGOCIC.CMGOAFDBAOH("OnSketchThumbnailsCdnFailed");
					}
					else if (EEIBKLDNBAP.LCJBJJIHNMH())
					{
						DPGJIJGOCIC.NFIDPOMCNLP(")");
					}
					else if (EEIBKLDNBAP.OCNPLOOGPCN() > 1)
					{
						DPGJIJGOCIC.PJCLICBPPDA("OnFriendsPopupSendPremClick");
						EEIBKLDNBAP.JHOGPGMCIFB(" attempt ");
						EEIBKLDNBAP.IJHHMHAEKKE();
					}
					else
					{
						DPGJIJGOCIC.CMGOAFDBAOH("userpublicprofileanthology");
					}
					result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
				}
				else if (!EEIBKLDNBAP.ALFGPLALKCN())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("NotificationManager");
					result = LoadingEnvironmentManager.DCIHPCALFBK(loadingEnvironmentManager);
				}
				else
				{
					if (null == loadingEnvironmentManager)
					{
						GameObject gameObject = new GameObject("Asset bundle assets destroyed:");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
					}
					EEIBKLDNBAP.KGLELEEIDPF(loadingEnvironmentRegistryEntry);
					loadingEnvironmentManager.IMHDOKFIMMP(loadingEnvironmentRegistryEntry);
					LoadingEnvironmentManager.DGIFLJHAFAA();
					result = true;
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(ex);
			if (null != loadingEnvironmentManager)
			{
				loadingEnvironmentManager.OPEIKCLMCID("selectedLanguage" + ex.Message);
			}
			else
			{
				EEIBKLDNBAP.JHOGPGMCIFB("[LoadingEnv] skipped, feature disabled by balance" + ex.Message);
				EEIBKLDNBAP.IJHHMHAEKKE();
				LoadingEnvironmentManager.DGIFLJHAFAA();
			}
			result = false;
		}
		return result;
	}

	// Token: 0x06007EA7 RID: 32423 RVA: 0x00381788 File Offset: 0x0037F988
	private static void KEMOOOGHDBJ(RectTransform AOBDNCNEPDM)
	{
		AOBDNCNEPDM.anchorMin = Vector2.zero;
		AOBDNCNEPDM.anchorMax = Vector2.one;
		AOBDNCNEPDM.pivot = new Vector2(0.5f, 0.5f);
		AOBDNCNEPDM.anchoredPosition = Vector2.zero;
		AOBDNCNEPDM.sizeDelta = Vector2.zero;
	}

	// Token: 0x06007EA8 RID: 32424 RVA: 0x003817D8 File Offset: 0x0037F9D8
	private void AFAJGNAAIOD(Scene HGAGLOCDLEG, Scene PNPGECLGDKE)
	{
		try
		{
			if (!PNPGECLGDKE.name.Equals("PurchaseManagerSteam.OnBackendValidateTransactionException().") && !PNPGECLGDKE.name.Equals("OnBackendInitiateSteamTransactionException"))
			{
				this.IDGJBMEEIKI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007EA9 RID: 32425 RVA: 0x0038182C File Offset: 0x0037FA2C
	private static List<string> KFIHJLCMFKF()
	{
		List<string> list = new List<string>();
		foreach (AssetBundle assetBundle in AssetBundle.GetAllLoadedAssetBundles())
		{
			if (null != assetBundle)
			{
				list.Add(assetBundle.name);
			}
		}
		return list;
	}

	// Token: 0x06007EAA RID: 32426 RVA: 0x00381890 File Offset: 0x0037FA90
	private void LMFPMCHIBIN(float BICHMDEIFKI, float IDHBPDACMAA)
	{
		if (this.GPILOGAIBKJ == LoadingEnvironmentManager.KFPDBFJJDGA.fadingOut)
		{
			return;
		}
		if (this.GPILOGAIBKJ != LoadingEnvironmentManager.KFPDBFJJDGA.showing)
		{
			this.IDGJBMEEIKI();
			return;
		}
		this.GPILOGAIBKJ = LoadingEnvironmentManager.KFPDBFJJDGA.fadingOut;
		base.StartCoroutine(this.EJMACAALHBI(BICHMDEIFKI, IDHBPDACMAA));
	}

	// Token: 0x06007EAB RID: 32427 RVA: 0x003818C4 File Offset: 0x0037FAC4
	private void IEFPNBDJBNC(PHALBCMBPPL KIGFAHKFKNL)
	{
		try
		{
			if (null != this.DNODJKBDOCM)
			{
				this.DNODJKBDOCM.SetPositionVertical(KIGFAHKFKNL, DBONHDHEKDG.slower, Ease.InOutSine);
			}
			if (null != this.HOMDFHKNCCJ)
			{
				this.HOMDFHKNCCJ.SetPositionVertical(KIGFAHKFKNL, DBONHDHEKDG.slower, Ease.InOutSine);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007EAC RID: 32428 RVA: 0x0038192C File Offset: 0x0037FB2C
	private GameObject JBHFKKGNOEO(string HJEJJGAFHAM, Camera PLMBHHNCFNG, int GHEMBIDKOIA, int LHPFAACEDME, out CanvasGroup CDFPPHCNOLD)
	{
		GameObject gameObject = new GameObject(HJEJJGAFHAM, new Type[]
		{
			typeof(RectTransform),
			typeof(Canvas),
			typeof(CanvasScaler)
		});
		gameObject.transform.SetParent(base.transform, false);
		gameObject.layer = GHEMBIDKOIA;
		Canvas component = gameObject.GetComponent<Canvas>();
		component.renderMode = RenderMode.ScreenSpaceCamera;
		component.worldCamera = PLMBHHNCFNG;
		component.planeDistance = 100f;
		component.pixelPerfect = false;
		component.sortingOrder = LHPFAACEDME;
		component.additionalShaderChannels = (AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.TexCoord2 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent);
		LoadingEnvironmentManager.INCABMLOAFI(gameObject.GetComponent<CanvasScaler>());
		GameObject gameObject2 = new GameObject("EnvironmentsPivot", new Type[]
		{
			typeof(RectTransform),
			typeof(CanvasGroup),
			typeof(WideScreenScaler)
		});
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = GHEMBIDKOIA;
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(0.5f, 0.5f);
		component2.anchorMax = new Vector2(0.5f, 0.5f);
		component2.pivot = new Vector2(0.5f, 0.5f);
		component2.anchoredPosition = Vector2.zero;
		component2.sizeDelta = new Vector2(1024f, 1366f);
		WideScreenScaler component3 = gameObject2.GetComponent<WideScreenScaler>();
		component3.verticalOffsetFactorOverride = KKDFIHILCCD.doNotOverride;
		component3.verticalOffsetFactor = -0.5f;
		component3.assetWidthHd = 1440f;
		component3.rescaleOnEnable = false;
		component3.isIdleState = false;
		CDFPPHCNOLD = gameObject2.GetComponent<CanvasGroup>();
		CDFPPHCNOLD.alpha = 0f;
		CDFPPHCNOLD.interactable = false;
		CDFPPHCNOLD.blocksRaycasts = false;
		return gameObject2;
	}

	// Token: 0x06007EAD RID: 32429 RVA: 0x00381AD4 File Offset: 0x0037FCD4
	private void OPEIKCLMCID(string FLBOCJFEMFE)
	{
		string[] array = new string[5];
		array[0] = "";
		array[0] = LoadingEnvironmentManager.FBALOIAPDPJ();
		array[6] = ((this.BHCOKJANFAH.Length > 1) ? ("null" + this.BHCOKJANFAH + ">") : "x");
		array[6] = "importanttitle";
		array[0] = FLBOCJFEMFE;
		array[1] = "%";
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(array));
		EEIBKLDNBAP.JHOGPGMCIFB(FLBOCJFEMFE);
		EEIBKLDNBAP.IJHHMHAEKKE();
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007EAE RID: 32430 RVA: 0x00381B53 File Offset: 0x0037FD53
	private void Awake()
	{
		LoadingEnvironmentManager.IKLAPGJDMNA = this;
	}

	// Token: 0x06007EAF RID: 32431 RVA: 0x00381B5C File Offset: 0x0037FD5C
	private void CEMHAIKEPHK()
	{
		try
		{
			if (null != this.DKJPLDHGGMO)
			{
				this.DKJPLDHGGMO.targetTexture = null;
			}
			if (null != this.HGHBCNNABOG)
			{
				this.HGHBCNNABOG.targetTexture = null;
			}
			if (null != this.EOEPKJFMLAP)
			{
				RenderTexture.ReleaseTemporary(this.EOEPKJFMLAP);
				this.EOEPKJFMLAP = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007EB0 RID: 32432 RVA: 0x00381BD8 File Offset: 0x0037FDD8
	private void JBMBMNAIIHF()
	{
		this.EMMNLAPDKIG();
		if (LoadingEnvironmentManager.IKLAPGJDMNA == this)
		{
			LoadingEnvironmentManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007EB1 RID: 32433 RVA: 0x00381BF4 File Offset: 0x0037FDF4
	private void HKAOFEPHGMO()
	{
		if (this.FCJFJHJNDBM == null)
		{
			return;
		}
		try
		{
			if (this.FCJFJHJNDBM.isDone && null != this.FCJFJHJNDBM.assetBundle)
			{
				this.FCJFJHJNDBM.assetBundle.Unload(false);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.FCJFJHJNDBM = null;
	}

	// Token: 0x06007EB2 RID: 32434 RVA: 0x00381C5C File Offset: 0x0037FE5C
	private void DBMCMBBPEEH(int BFHECAGFKFD)
	{
		for (int i = this.NIFCDLFMNKM.Count - 1; i >= BFHECAGFKFD; i--)
		{
			try
			{
				if (null != this.NIFCDLFMNKM[i])
				{
					this.NIFCDLFMNKM[i].Unload(true);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.NIFCDLFMNKM.RemoveAt(i);
		}
	}

	// Token: 0x06007EB3 RID: 32435 RVA: 0x00381CD0 File Offset: 0x0037FED0
	private bool MEBPBAJKLAP(string ICAHJJBAEHB)
	{
		bool result;
		try
		{
			bool flag = false;
			for (int i = 0; i < this.CHHIBBOICAD.Count; i++)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
			for (int j = 0; j < this.KEPHFKAHILM.Count; j++)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(false);
			}
			for (int k = 0; k < this.KEPHFKAHILM.Count; k++)
			{
				if (this.KEPHFKAHILM[k].gameObject.name.Equals(ICAHJJBAEHB))
				{
					this.KEPHFKAHILM[k].OptimizeParticleSystems();
					this.KEPHFKAHILM[k].gameObject.SetActive(true);
					this.DNODJKBDOCM = this.KEPHFKAHILM[k];
					break;
				}
			}
			for (int l = 0; l < this.CHHIBBOICAD.Count; l++)
			{
				if (this.CHHIBBOICAD[l].gameObject.name.Equals(ICAHJJBAEHB))
				{
					this.CHHIBBOICAD[l].OptimizeParticleSystems();
					this.CHHIBBOICAD[l].gameObject.SetActive(true);
					this.HOMDFHKNCCJ = this.CHHIBBOICAD[l];
					flag = true;
					break;
				}
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007EB4 RID: 32436 RVA: 0x00381E50 File Offset: 0x00380050
	private GameObject JLBCPFADIAF(string HJEJJGAFHAM, Camera PLMBHHNCFNG, int GHEMBIDKOIA, int LHPFAACEDME, out CanvasGroup CDFPPHCNOLD)
	{
		Type[] array = new Type[0];
		array[0] = typeof(RectTransform);
		array[1] = typeof(Canvas);
		array[5] = typeof(CanvasScaler);
		GameObject gameObject = new GameObject(HJEJJGAFHAM, array);
		gameObject.transform.SetParent(base.transform, false);
		gameObject.layer = GHEMBIDKOIA;
		Canvas component = gameObject.GetComponent<Canvas>();
		component.renderMode = RenderMode.ScreenSpaceCamera;
		component.worldCamera = PLMBHHNCFNG;
		component.planeDistance = 1517f;
		component.pixelPerfect = true;
		component.sortingOrder = LHPFAACEDME;
		component.additionalShaderChannels = (AdditionalCanvasShaderChannels)80;
		LoadingEnvironmentManager.INCABMLOAFI(gameObject.GetComponent<CanvasScaler>());
		string name = "UpdateSoundOnOffState";
		Type[] array2 = new Type[7];
		array2[0] = typeof(RectTransform);
		array2[1] = typeof(CanvasGroup);
		array2[0] = typeof(WideScreenScaler);
		GameObject gameObject2 = new GameObject(name, array2);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = GHEMBIDKOIA;
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(46f, 1200f);
		component2.anchorMax = new Vector2(992f, 36f);
		component2.pivot = new Vector2(1711f, 1438f);
		component2.anchoredPosition = Vector2.zero;
		component2.sizeDelta = new Vector2(585f, 152f);
		WideScreenScaler component3 = gameObject2.GetComponent<WideScreenScaler>();
		component3.verticalOffsetFactorOverride = KKDFIHILCCD.doNotOverride;
		component3.verticalOffsetFactor = 942f;
		component3.assetWidthHd = 1221f;
		component3.rescaleOnEnable = true;
		component3.isIdleState = true;
		CDFPPHCNOLD = gameObject2.GetComponent<CanvasGroup>();
		CDFPPHCNOLD.alpha = 129f;
		CDFPPHCNOLD.interactable = false;
		CDFPPHCNOLD.blocksRaycasts = false;
		return gameObject2;
	}

	// Token: 0x06007EB5 RID: 32437 RVA: 0x00381FF8 File Offset: 0x003801F8
	private void OGHCNAPFJMK()
	{
		if (this.CALMBPNDMKP.ambientDrift)
		{
			this.PPFGBKFFAGK(this.DNODJKBDOCM);
			this.PPFGBKFFAGK(this.HOMDFHKNCCJ);
			return;
		}
		base.StartCoroutine(this.CAMCLIBGLGJ());
	}

	// Token: 0x06007EB6 RID: 32438 RVA: 0x00382030 File Offset: 0x00380230
	private void LMDEHPJIPBI()
	{
		for (int i = 0; i < this.PDBMPHNPPJN.Count; i++)
		{
			try
			{
				if (null != this.PDBMPHNPPJN[i] && null != this.IGEPNHMBHMA[i])
				{
					this.PDBMPHNPPJN[i].SetParent(this.IGEPNHMBHMA[i], true);
					this.PDBMPHNPPJN[i].SetSiblingIndex(this.PADLBIPCHAP[i]);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.PDBMPHNPPJN.Clear();
		this.IGEPNHMBHMA.Clear();
		this.PADLBIPCHAP.Clear();
	}

	// Token: 0x06007EB7 RID: 32439 RVA: 0x0037F587 File Offset: 0x0037D787
	private static void DAOJGHGNBAI()
	{
		if (null == LoadingEnvironmentManager.ALDCAOMGBNC)
		{
			return;
		}
		UnityEngine.Object.Destroy(LoadingEnvironmentManager.ALDCAOMGBNC);
		LoadingEnvironmentManager.ALDCAOMGBNC = null;
	}

	// Token: 0x06007EB8 RID: 32440 RVA: 0x003820F4 File Offset: 0x003802F4
	private void PPFGBKFFAGK(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		try
		{
			if (!(null == DCEEBNNKPGJ) && DCEEBNNKPGJ.environmentSize != PKAFEAJCLGN.one)
			{
				float num = (float)DCEEBNNKPGJ.environmentSize * 0.5f;
				float num2 = (float)((DCEEBNNKPGJ.environmentSize - (PKAFEAJCLGN)768) / 4);
				float num3 = 1366f * (float)Screen.width / (float)Screen.height * 0.5f;
				if (num - num2 >= num3)
				{
					DCEEBNNKPGJ.SetPosition(FCABOFEGPGP.leftCenter, DBONHDHEKDG.immediate, Ease.Linear);
					DCEEBNNKPGJ.SetPosition(FCABOFEGPGP.center, DBONHDHEKDG.slowest, Ease.InOutSine);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007EB9 RID: 32441 RVA: 0x0037F587 File Offset: 0x0037D787
	private static void JOGIBDJBIOD()
	{
		if (null == LoadingEnvironmentManager.ALDCAOMGBNC)
		{
			return;
		}
		UnityEngine.Object.Destroy(LoadingEnvironmentManager.ALDCAOMGBNC);
		LoadingEnvironmentManager.ALDCAOMGBNC = null;
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x0037F570 File Offset: 0x0037D770
	private static bool FFICCAKDONJ(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager.JOGIBDJBIOD();
		if (null != INNCKCGAFBE)
		{
			INNCKCGAFBE.IDGJBMEEIKI();
		}
		return false;
	}

	// Token: 0x06007EBB RID: 32443 RVA: 0x00382188 File Offset: 0x00380388
	private void PHKDJPOLNDN(LoadingEnvironmentRegistryEntry FOEEIJFHMGG)
	{
		this.CALMBPNDMKP = FOEEIJFHMGG;
		this.INGKGGNOHCC();
		SceneManager.activeSceneChanged += this.JCIBLJCMHLM;
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("lastFilter", new UnityAction(this.ECNCPOBPHGC));
		string[] array = new string[8];
		array[1] = "<align=\"center\"><alpha=#88>";
		array[1] = LoadingEnvironmentManager.FBALOIAPDPJ();
		array[2] = "</nobr>";
		array[4] = this.CALMBPNDMKP.envId;
		array[0] = "seasoncomplete";
		array[7] = this.CALMBPNDMKP.bundleName;
		array[3] = "";
		array[2] = string.Join("msv", this.CALMBPNDMKP.chainNames.ToArray());
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
		base.StartCoroutine(this.HFLAIFCIFHF());
	}

	// Token: 0x06007EBC RID: 32444 RVA: 0x0038224C File Offset: 0x0038044C
	private AsyncOperation CBHPILDDHFE()
	{
		AsyncOperation result;
		try
		{
			result = SceneManager.LoadSceneAsync(this.CALMBPNDMKP.sceneName, LoadSceneMode.Single);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06007EBD RID: 32445 RVA: 0x00382288 File Offset: 0x00380488
	private static bool DBLBHEAGIPA(LoadingEnvironmentManager INNCKCGAFBE)
	{
		LoadingEnvironmentManager loadingEnvironmentManager = INNCKCGAFBE;
		bool result;
		try
		{
			if (true)
			{
				DPGJIJGOCIC.CMGOAFDBAOH("ZZZ");
				result = LoadingEnvironmentManager.FFICCAKDONJ(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.PKPDLCOKNMI())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("gmmd");
				result = LoadingEnvironmentManager.DCIHPCALFBK(loadingEnvironmentManager);
			}
			else if (EEIBKLDNBAP.IOJCHHGBOJB())
			{
				DPGJIJGOCIC.CMGOAFDBAOH("ok");
				result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
			}
			else if (AssetsManager.EHBBFMCILPC.CacheCleanScheduled())
			{
				DPGJIJGOCIC.NFIDPOMCNLP("socialbadgedesc");
				result = LoadingEnvironmentManager.BJBFFKEHDII(loadingEnvironmentManager);
			}
			else
			{
				LoadingEnvironmentRegistryEntry loadingEnvironmentRegistryEntry = EEIBKLDNBAP.HMIKGAKODMP(LoadingEnvironmentManager.HPEEDMFDHEC());
				if (loadingEnvironmentRegistryEntry == null)
				{
					if (EEIBKLDNBAP.FPAKKCDIHEN())
					{
						DPGJIJGOCIC.CMGOAFDBAOH("rwd");
					}
					else if (EEIBKLDNBAP.LCJBJJIHNMH())
					{
						DPGJIJGOCIC.NFIDPOMCNLP("Asset bundle load operation failed during parallel mode.");
					}
					else if (EEIBKLDNBAP.OCNPLOOGPCN() > 1)
					{
						DPGJIJGOCIC.ADFCDFHBDAF("sfxtimeoutwarning");
						EEIBKLDNBAP.JHOGPGMCIFB("socialdonotdisturb1");
						EEIBKLDNBAP.IJHHMHAEKKE();
					}
					else
					{
						DPGJIJGOCIC.NFIDPOMCNLP("OnBackendRequestFriendDeleteException");
					}
					result = LoadingEnvironmentManager.DCIHPCALFBK(loadingEnvironmentManager);
				}
				else if (!EEIBKLDNBAP.ALFGPLALKCN())
				{
					DPGJIJGOCIC.NFIDPOMCNLP("yes");
					result = LoadingEnvironmentManager.DCIHPCALFBK(loadingEnvironmentManager);
				}
				else
				{
					if (null == loadingEnvironmentManager)
					{
						GameObject gameObject = new GameObject("XXX");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						loadingEnvironmentManager = gameObject.AddComponent<LoadingEnvironmentManager>();
					}
					EEIBKLDNBAP.KGLELEEIDPF(loadingEnvironmentRegistryEntry);
					loadingEnvironmentManager.IMHDOKFIMMP(loadingEnvironmentRegistryEntry);
					LoadingEnvironmentManager.DGIFLJHAFAA();
					result = false;
				}
			}
		}
		catch (Exception ex)
		{
			DPGJIJGOCIC.HBGPHANKMFA(ex);
			if (null != loadingEnvironmentManager)
			{
				loadingEnvironmentManager.JKCFEMKBCFE("total while iterations:" + ex.Message);
			}
			else
			{
				EEIBKLDNBAP.JHOGPGMCIFB("" + ex.Message);
				EEIBKLDNBAP.IJHHMHAEKKE();
				LoadingEnvironmentManager.DAOJGHGNBAI();
			}
			result = true;
		}
		return result;
	}

	// Token: 0x06007EBE RID: 32446 RVA: 0x00382434 File Offset: 0x00380634
	private void GMIEIIGBDBC(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		try
		{
			if (!(null == DCEEBNNKPGJ) && DCEEBNNKPGJ.environmentSize != (PKAFEAJCLGN)150)
			{
				float num = (float)DCEEBNNKPGJ.environmentSize * 748f;
				float num2 = (float)((DCEEBNNKPGJ.environmentSize - (PKAFEAJCLGN)17) / 8);
				float num3 = 795f * (float)Screen.width / (float)Screen.height * 663f;
				if (num - num2 >= num3)
				{
					DCEEBNNKPGJ.MCKBGLNBBBP(FCABOFEGPGP.left, DBONHDHEKDG.immediate, Ease.Linear);
					DCEEBNNKPGJ.EFOHNEBHEEO(FCABOFEGPGP.center, (DBONHDHEKDG)(-118), Ease.InSine);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06007EC0 RID: 32448 RVA: 0x00382540 File Offset: 0x00380740
	private bool IPOLOJKIKML()
	{
		bool result;
		try
		{
			Scene sceneByName = SceneManager.GetSceneByName(this.CALMBPNDMKP.sceneName);
			if (!sceneByName.IsValid() || !sceneByName.isLoaded)
			{
				result = false;
			}
			else
			{
				GameObject[] rootGameObjects = sceneByName.GetRootGameObjects();
				SceneManager.MergeScenes(sceneByName, SceneManager.GetActiveScene());
				for (int i = 0; i < rootGameObjects.Length; i++)
				{
					if (!(null == rootGameObjects[i]))
					{
						SceneStoryAssetPackManager[] componentsInChildren = rootGameObjects[i].GetComponentsInChildren<SceneStoryAssetPackManager>(true);
						for (int j = 0; j < componentsInChildren.Length; j++)
						{
							for (int k = 0; k < componentsInChildren[j].environmentsBackList.Count; k++)
							{
								if (null != componentsInChildren[j].environmentsBackList[k])
								{
									componentsInChildren[j].environmentsBackList[k].transform.SetParent(this.PIDNOGCANLN.transform, false);
									this.CHHIBBOICAD.Add(componentsInChildren[j].environmentsBackList[k]);
								}
							}
							for (int l = 0; l < componentsInChildren[j].environmentsFrontList.Count; l++)
							{
								if (null != componentsInChildren[j].environmentsFrontList[l])
								{
									componentsInChildren[j].environmentsFrontList[l].transform.SetParent(this.LLFGFCIIIIJ.transform, false);
									this.KEPHFKAHILM.Add(componentsInChildren[j].environmentsFrontList[l]);
								}
							}
							for (int m = 0; m < componentsInChildren[j].environmentsLayersList.Count; m++)
							{
								StoryEnvironmentLayerManager storyEnvironmentLayerManager = componentsInChildren[j].environmentsLayersList[m];
								if (!(null == storyEnvironmentLayerManager))
								{
									this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
									if (storyEnvironmentLayerManager.isShared)
									{
										storyEnvironmentLayerManager.transform.SetParent(this.LLFGFCIIIIJ.transform, false);
									}
								}
							}
						}
						UnityEngine.Object.Destroy(rootGameObjects[i]);
					}
				}
				result = (this.CHHIBBOICAD.Count > 0 || this.KEPHFKAHILM.Count > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007EC1 RID: 32449 RVA: 0x0037F758 File Offset: 0x0037D958
	private void CIACMHCLGGB()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007EC2 RID: 32450 RVA: 0x00382780 File Offset: 0x00380980
	private void JGFENLLMGFK(int BFHECAGFKFD)
	{
		for (int i = this.NIFCDLFMNKM.Count - 0; i >= BFHECAGFKFD; i -= 0)
		{
			try
			{
				if (null != this.NIFCDLFMNKM[i])
				{
					this.NIFCDLFMNKM[i].Unload(false);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.NIFCDLFMNKM.RemoveAt(i);
		}
	}

	// Token: 0x06007EC3 RID: 32451 RVA: 0x003827F4 File Offset: 0x003809F4
	private bool FMAAEBOBFAD()
	{
		bool result;
		try
		{
			this.HEICDKDGECM.alpha = 397f;
			this.EIAJBJBFBKJ.alpha = 1308f;
			if (null != this.NBLOFBNEJMG)
			{
				this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(true);
			}
			result = false;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007EC4 RID: 32452 RVA: 0x00382868 File Offset: 0x00380A68
	private void NAOLICDECPO()
	{
		for (int i = 1; i < this.PDBMPHNPPJN.Count; i++)
		{
			try
			{
				if (null != this.PDBMPHNPPJN[i] && null != this.IGEPNHMBHMA[i])
				{
					this.PDBMPHNPPJN[i].SetParent(this.IGEPNHMBHMA[i], false);
					this.PDBMPHNPPJN[i].SetSiblingIndex(this.PADLBIPCHAP[i]);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		this.PDBMPHNPPJN.Clear();
		this.IGEPNHMBHMA.Clear();
		this.PADLBIPCHAP.Clear();
	}

	// Token: 0x06007EC5 RID: 32453 RVA: 0x0038292C File Offset: 0x00380B2C
	public static string DescribeHeldBundles()
	{
		string result;
		try
		{
			if (!LoadingEnvironmentManager.IsAlive())
			{
				result = "no rig";
			}
			else
			{
				List<string> list = new List<string>();
				for (int i = 0; i < LoadingEnvironmentManager.IKLAPGJDMNA.NIFCDLFMNKM.Count; i++)
				{
					if (null != LoadingEnvironmentManager.IKLAPGJDMNA.NIFCDLFMNKM[i])
					{
						list.Add(LoadingEnvironmentManager.IKLAPGJDMNA.NIFCDLFMNKM[i].name);
					}
				}
				string text = (LoadingEnvironmentManager.IKLAPGJDMNA.CEHNIHKEOCF == null) ? "" : (" loading " + LoadingEnvironmentManager.IKLAPGJDMNA.CEHNIHKEOCF);
				result = string.Concat(new string[]
				{
					"rig ",
					LoadingEnvironmentManager.IKLAPGJDMNA.GPILOGAIBKJ.ToString(),
					" holding [",
					string.Join(", ", list.ToArray()),
					"]",
					text
				});
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = "rig ?";
		}
		return result;
	}

	// Token: 0x06007EC6 RID: 32454 RVA: 0x00382A3C File Offset: 0x00380C3C
	private void OnDestroy()
	{
		this.JIEGCNEJMNO();
		if (LoadingEnvironmentManager.IKLAPGJDMNA == this)
		{
			LoadingEnvironmentManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06007EC7 RID: 32455 RVA: 0x00382A58 File Offset: 0x00380C58
	private void JKCFEMKBCFE(string FLBOCJFEMFE)
	{
		DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			(this.BHCOKJANFAH.Length > 0) ? (" " + this.BHCOKJANFAH + " path FAILED - ") : " ",
			"giving up: ",
			FLBOCJFEMFE,
			" - registry cleared"
		}));
		EEIBKLDNBAP.JHOGPGMCIFB(FLBOCJFEMFE);
		EEIBKLDNBAP.IJHHMHAEKKE();
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007EC8 RID: 32456 RVA: 0x00382AD8 File Offset: 0x00380CD8
	private void AFENPJPBNEO()
	{
		try
		{
			SceneManager.activeSceneChanged -= this.AFAJGNAAIOD;
			AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("", new UnityAction(this.OBBNPPEBMFM));
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007EC9 RID: 32457 RVA: 0x00382B2C File Offset: 0x00380D2C
	private static string FBALOIAPDPJ()
	{
		return "[t=" + Time.realtimeSinceStartup.ToString("0.00") + "s]";
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x00382B5C File Offset: 0x00380D5C
	private void BGFKGCDLADI()
	{
		if (this.KENBNNENIKC == null)
		{
			return;
		}
		try
		{
			if (this.KENBNNENIKC.isDone)
			{
				if (null != this.KENBNNENIKC.assetBundle)
				{
					this.KENBNNENIKC.assetBundle.Unload(true);
				}
			}
			else
			{
				this.FCJFJHJNDBM = this.KENBNNENIKC;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.KENBNNENIKC = null;
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x00382BD4 File Offset: 0x00380DD4
	private bool HANODDFLNPD()
	{
		bool result;
		try
		{
			if (this.NIFCDLFMNKM.Count == 0)
			{
				result = false;
			}
			else
			{
				AssetBundle assetBundle = this.NIFCDLFMNKM[this.NIFCDLFMNKM.Count - 1];
				result = (null != assetBundle && assetBundle.isStreamedSceneAssetBundle);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007ECC RID: 32460 RVA: 0x00382C3C File Offset: 0x00380E3C
	private static Image GIIDJLONIIC(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		RectTransform parent = LoadingEnvironmentManager.ICOIKDFAEIN("CanvasCover", BFGBPKIGAJI, GHEMBIDKOIA, 30);
		GameObject gameObject = new GameObject("Cover", new Type[]
		{
			typeof(RectTransform),
			typeof(Image)
		});
		gameObject.transform.SetParent(parent, false);
		gameObject.layer = GHEMBIDKOIA;
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		Image component2 = gameObject.GetComponent<Image>();
		component2.color = Color.black;
		component2.raycastTarget = false;
		return component2;
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x00382CE0 File Offset: 0x00380EE0
	private bool FILJCIIAAAH()
	{
		bool result;
		try
		{
			StoryEnvironmentLayerManager.SetLayersSystemVersion(this.CALMBPNDMKP.layersSystemVersion);
			if (this.CALMBPNDMKP.layersSystemVersion >= 2)
			{
				for (int i = 0; i < this.CALMBPNDMKP.layersHide.Count; i++)
				{
					this.HAMBDPGMFOF(this.CALMBPNDMKP.layersHide[i], false);
				}
				for (int j = 0; j < this.CALMBPNDMKP.layersShow.Count; j++)
				{
					this.HAMBDPGMFOF(this.CALMBPNDMKP.layersShow[j], true);
				}
			}
			else
			{
				for (int k = 0; k < this.CALMBPNDMKP.layersShow.Count; k++)
				{
					this.HAMBDPGMFOF(this.CALMBPNDMKP.layersShow[k], true);
				}
				for (int l = 0; l < this.CALMBPNDMKP.layersHide.Count; l++)
				{
					this.HAMBDPGMFOF(this.CALMBPNDMKP.layersHide[l], false);
				}
			}
			this.JOIIHIPILKP(this.HOMDFHKNCCJ);
			this.JOIIHIPILKP(this.DNODJKBDOCM);
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x0037F758 File Offset: 0x0037D958
	private void LMOBPPCPEDN()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007ECF RID: 32463 RVA: 0x00382E20 File Offset: 0x00381020
	public static IEnumerator EMPAJHGNNFO(float KCPBIAEMFPC)
	{
		LoadingEnvironmentManager.IOFBFEJNFDF iofbfejnfdf = new LoadingEnvironmentManager.IOFBFEJNFDF(1);
		iofbfejnfdf._timeout = KCPBIAEMFPC;
		return iofbfejnfdf;
	}

	// Token: 0x06007ED0 RID: 32464 RVA: 0x00382E30 File Offset: 0x00381030
	private void AOJLKOELGMH()
	{
		if (this.HMFFIHHBONG)
		{
			return;
		}
		this.HMFFIHHBONG = true;
		try
		{
			base.StopAllCoroutines();
			this.JIEGCNEJMNO();
			this.PCHGPHJMFOD();
			if (null != this.HEICDKDGECM)
			{
				this.HEICDKDGECM.DOKill(false);
			}
			if (null != this.EIAJBJBFBKJ)
			{
				this.EIAJBJBFBKJ.DOKill(false);
			}
			if (null != this.OKMGICNNHDJ)
			{
				this.OKMGICNNHDJ.DOKill(false);
			}
			if (null != this.IIPCKJLHNEA)
			{
				this.IIPCKJLHNEA.DOKill(false);
			}
			if (null != this.MLIDDCFHDEP)
			{
				this.MLIDDCFHDEP.DOKill(false);
			}
			this.CEMHAIKEPHK();
			this.EPMLMDLIKJA();
			this.GLJHDDCFJGP();
			for (int i = base.transform.childCount - 1; i >= 0; i--)
			{
				UnityEngine.Object.Destroy(base.transform.GetChild(i).gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.DFGHGKCMOFL)
		{
			EEIBKLDNBAP.FOHOCBHHOAP(this.CALMBPNDMKP);
		}
		if (LoadingEnvironmentManager.IKLAPGJDMNA == this)
		{
			EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
			LoadingEnvironmentManager.IKLAPGJDMNA = null;
		}
		LoadingEnvironmentManager.JOGIBDJBIOD();
		base.StartCoroutine(this.AKKKPFCPBJN());
	}

	// Token: 0x06007ED1 RID: 32465 RVA: 0x00382F84 File Offset: 0x00381184
	private void LFJLADEGNPO(RectTransform BPFMMCDGNFB)
	{
		try
		{
			if (!this.PDBMPHNPPJN.Contains(BPFMMCDGNFB))
			{
				if (null == this.CIKOLCGIDBE)
				{
					if (!this.APBNLMGLDGB.Contains(BPFMMCDGNFB))
					{
						this.APBNLMGLDGB.Add(BPFMMCDGNFB);
					}
				}
				else
				{
					this.PDBMPHNPPJN.Add(BPFMMCDGNFB);
					this.IGEPNHMBHMA.Add(BPFMMCDGNFB.parent);
					this.PADLBIPCHAP.Add(BPFMMCDGNFB.GetSiblingIndex());
					BPFMMCDGNFB.SetParent(this.CIKOLCGIDBE, true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007ED2 RID: 32466 RVA: 0x0037F758 File Offset: 0x0037D958
	private void GKEPDKIFEPP()
	{
		EEIBKLDNBAP.EDDOLOJALBG(this.CALMBPNDMKP);
		this.IDGJBMEEIKI();
	}

	// Token: 0x06007ED3 RID: 32467 RVA: 0x00383020 File Offset: 0x00381220
	private bool DDMPOIGIOCN()
	{
		bool result;
		try
		{
			Scene sceneByName = SceneManager.GetSceneByName(this.CALMBPNDMKP.sceneName);
			if (!sceneByName.IsValid() || !sceneByName.isLoaded)
			{
				result = true;
			}
			else
			{
				GameObject[] rootGameObjects = sceneByName.GetRootGameObjects();
				SceneManager.MergeScenes(sceneByName, SceneManager.GetActiveScene());
				for (int i = 0; i < rootGameObjects.Length; i++)
				{
					if (!(null == rootGameObjects[i]))
					{
						SceneStoryAssetPackManager[] componentsInChildren = rootGameObjects[i].GetComponentsInChildren<SceneStoryAssetPackManager>(true);
						for (int j = 1; j < componentsInChildren.Length; j++)
						{
							for (int k = 0; k < componentsInChildren[j].environmentsBackList.Count; k++)
							{
								if (null != componentsInChildren[j].environmentsBackList[k])
								{
									componentsInChildren[j].environmentsBackList[k].transform.SetParent(this.PIDNOGCANLN.transform, false);
									this.CHHIBBOICAD.Add(componentsInChildren[j].environmentsBackList[k]);
								}
							}
							for (int l = 0; l < componentsInChildren[j].environmentsFrontList.Count; l += 0)
							{
								if (null != componentsInChildren[j].environmentsFrontList[l])
								{
									componentsInChildren[j].environmentsFrontList[l].transform.SetParent(this.LLFGFCIIIIJ.transform, false);
									this.KEPHFKAHILM.Add(componentsInChildren[j].environmentsFrontList[l]);
								}
							}
							for (int m = 0; m < componentsInChildren[j].environmentsLayersList.Count; m += 0)
							{
								StoryEnvironmentLayerManager storyEnvironmentLayerManager = componentsInChildren[j].environmentsLayersList[m];
								if (!(null == storyEnvironmentLayerManager))
								{
									this.FAEEEHDCNDN.Add(storyEnvironmentLayerManager);
									if (storyEnvironmentLayerManager.isShared)
									{
										storyEnvironmentLayerManager.transform.SetParent(this.LLFGFCIIIIJ.transform, false);
									}
								}
							}
						}
						UnityEngine.Object.Destroy(rootGameObjects[i]);
					}
				}
				result = (this.CHHIBBOICAD.Count <= 1 && this.KEPHFKAHILM.Count > 0);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007ED4 RID: 32468 RVA: 0x00383260 File Offset: 0x00381460
	private static void MLLAAMHCOOD(RectTransform AOBDNCNEPDM)
	{
		AOBDNCNEPDM.anchorMin = Vector2.zero;
		AOBDNCNEPDM.anchorMax = Vector2.one;
		AOBDNCNEPDM.pivot = new Vector2(880f, 894f);
		AOBDNCNEPDM.anchoredPosition = Vector2.zero;
		AOBDNCNEPDM.sizeDelta = Vector2.zero;
	}

	// Token: 0x06007ED5 RID: 32469 RVA: 0x003832B0 File Offset: 0x003814B0
	public static void DestroyIfAlive()
	{
		try
		{
			LoadingEnvironmentManager.JOGIBDJBIOD();
			if (LoadingEnvironmentManager.IsAlive())
			{
				LoadingEnvironmentManager.IKLAPGJDMNA.IDGJBMEEIKI();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06007ED6 RID: 32470 RVA: 0x003832F0 File Offset: 0x003814F0
	private IEnumerator HFLAIFCIFHF()
	{
		this.GPILOGAIBKJ = LoadingEnvironmentManager.KFPDBFJJDGA.loadingBundles;
		List<string> loadedAssetBundleNames = LoadingEnvironmentManager.HPEEDMFDHEC();
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			" loaded elsewhere at start: [",
			string.Join(", ", loadedAssetBundleNames.ToArray()),
			"]"
		}));
		bool directFiles = EEIBKLDNBAP.FJKCFFJKNND(this.CALMBPNDMKP) && EEIBKLDNBAP.BGANJNLKPDO(this.CALMBPNDMKP, loadedAssetBundleNames);
		this.BHCOKJANFAH = (directFiles ? "DIRECT CACHE FILES" : "CACHE API");
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			" ",
			this.BHCOKJANFAH,
			" path: loading the chain",
			directFiles ? " from the recorded cache files" : " through the caching api"
		}));
		if (directFiles)
		{
			yield return this.PHMIDMNFJBB();
			if (this.HMFFIHHBONG || this.KKLGIHCPOIK)
			{
				yield break;
			}
			if (this.NIHOFDLHKDB)
			{
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + LoadingEnvironmentManager.FBALOIAPDPJ() + " DIRECT CACHE FILES path SUCCEEDED: chain loaded from the recorded cache files");
				this.DFGHGKCMOFL = true;
				EEIBKLDNBAP.FOHOCBHHOAP(this.CALMBPNDMKP);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("[LoadingEnv] " + LoadingEnvironmentManager.FBALOIAPDPJ() + " DIRECT CACHE FILES path FAILED, falling back to the CACHE API path");
				directFiles = false;
				this.BHCOKJANFAH = "CACHE API (fallback)";
				EEIBKLDNBAP.AALGIKKJJIC(this.CALMBPNDMKP);
				float waitedForCaching = 0f;
				while (!Caching.ready && waitedForCaching < 20f)
				{
					yield return null;
					waitedForCaching += Time.unscaledDeltaTime;
					if (!this.BFEONAACMNK && waitedForCaching >= 3f)
					{
						this.BFEONAACMNK = true;
						DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
						{
							"[LoadingEnv] ",
							LoadingEnvironmentManager.FBALOIAPDPJ(),
							" caching system still not ready after ",
							3f.ToString(),
							" s - cover dropped, still waiting for the fallback"
						}));
						if (null != this.NBLOFBNEJMG)
						{
							this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(false);
						}
					}
				}
				if (this.HMFFIHHBONG || this.KKLGIHCPOIK)
				{
					yield break;
				}
				if (!Caching.ready)
				{
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"[LoadingEnv] ",
						LoadingEnvironmentManager.FBALOIAPDPJ(),
						" CACHE API (fallback) path skipped, caching system not ready after ",
						20f.ToString(),
						" s"
					}));
					this.IDGJBMEEIKI();
					yield break;
				}
				loadedAssetBundleNames = LoadingEnvironmentManager.HPEEDMFDHEC();
				if (!EEIBKLDNBAP.PFJGDBPAEBH(this.CALMBPNDMKP, loadedAssetBundleNames))
				{
					this.JKCFEMKBCFE("bundles not in the cache index for the fallback");
					yield break;
				}
			}
		}
		int i = 0;
		while (i < this.CALMBPNDMKP.chainNames.Count && !directFiles)
		{
			if (!loadedAssetBundleNames.Contains(this.CALMBPNDMKP.chainNames[i]) && LoadingEnvironmentManager.HPEEDMFDHEC().Contains(this.CALMBPNDMKP.chainNames[i]))
			{
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"[LoadingEnv] ",
					LoadingEnvironmentManager.FBALOIAPDPJ(),
					" ",
					this.CALMBPNDMKP.chainNames[i],
					" became loaded elsewhere since the snapshot"
				}));
			}
			if (loadedAssetBundleNames.Contains(this.CALMBPNDMKP.chainNames[i]))
			{
				if (i == this.CALMBPNDMKP.chainNames.Count - 1)
				{
					this.JKCFEMKBCFE("scene bundle " + this.CALMBPNDMKP.chainNames[i] + " is already loaded elsewhere");
					yield break;
				}
				DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] reusing loaded dependency " + this.CALMBPNDMKP.chainNames[i]);
			}
			else
			{
				if (!this.CKCGDMGNJHO(i))
				{
					this.JKCFEMKBCFE("request for " + this.CALMBPNDMKP.chainNames[i] + " could not be created");
					yield break;
				}
				this.CEHNIHKEOCF = this.CALMBPNDMKP.chainNames[i];
				float waitedForCaching = Time.realtimeSinceStartup;
				yield return this.GCIJBKCHJLF.SendWebRequest();
				AssetBundle assetBundle = this.LIIIBPOBHFF(this.GCIJBKCHJLF, this.CALMBPNDMKP.chainNames[i]);
				this.GCIJBKCHJLF = null;
				this.CEHNIHKEOCF = null;
				DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
				{
					"[LoadingEnv] ",
					LoadingEnvironmentManager.FBALOIAPDPJ(),
					" cached request for ",
					this.CALMBPNDMKP.chainNames[i],
					" took ",
					((Time.realtimeSinceStartup - waitedForCaching) * 1000f).ToString("0"),
					" ms -> ",
					(null == assetBundle) ? "NO BUNDLE" : "ok"
				}));
				if (null == assetBundle)
				{
					this.JKCFEMKBCFE("bundle " + this.CALMBPNDMKP.chainNames[i] + " could not be loaded from the cache");
					yield break;
				}
				this.NIFCDLFMNKM.Add(assetBundle);
			}
			int num = i;
			i = num + 1;
		}
		if (!directFiles)
		{
			DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
			{
				"[LoadingEnv] ",
				LoadingEnvironmentManager.FBALOIAPDPJ(),
				" ",
				this.BHCOKJANFAH,
				" path SUCCEEDED: chain loaded through the caching api"
			}));
			EEIBKLDNBAP.LNMOJPLHION(this.CALMBPNDMKP);
		}
		if (!this.HANODDFLNPD())
		{
			this.JKCFEMKBCFE("the last bundle of the chain carries no scene");
			yield break;
		}
		this.GPILOGAIBKJ = LoadingEnvironmentManager.KFPDBFJJDGA.loadingScene;
		AsyncOperation asyncOperation = this.CKFEDDNPCHB();
		this.NGPMBFIJJBP = true;
		DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + LoadingEnvironmentManager.FBALOIAPDPJ() + " scene load issued for " + this.CALMBPNDMKP.sceneName);
		if (asyncOperation == null)
		{
			this.JKCFEMKBCFE("scene " + this.CALMBPNDMKP.sceneName + " could not be loaded");
			yield break;
		}
		yield return asyncOperation;
		if (this.KKLGIHCPOIK)
		{
			this.AFHNBPLFIEO();
			this.AOJLKOELGMH();
			yield break;
		}
		if (!this.IPOLOJKIKML())
		{
			this.JKCFEMKBCFE("scene " + this.CALMBPNDMKP.sceneName + " did not arrive");
			yield break;
		}
		DPGJIJGOCIC.NFIDPOMCNLP("[LoadingEnv] " + LoadingEnvironmentManager.FBALOIAPDPJ() + " scene adopted");
		this.GLJHDDCFJGP();
		if (!this.MEBPBAJKLAP(this.CALMBPNDMKP.envId))
		{
			this.JKCFEMKBCFE("environment " + this.CALMBPNDMKP.envId + " not found in " + this.CALMBPNDMKP.sceneName);
			yield break;
		}
		if (!this.FILJCIIAAAH())
		{
			this.JKCFEMKBCFE("authored look of " + this.CALMBPNDMKP.envId + " could not be applied");
			yield break;
		}
		if (!this.EHIOCGOAEMA())
		{
			this.JKCFEMKBCFE("environment " + this.CALMBPNDMKP.envId + " could not be revealed");
			yield break;
		}
		this.BMEMGJEPAFJ();
		this.GPILOGAIBKJ = LoadingEnvironmentManager.KFPDBFJJDGA.showing;
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"[LoadingEnv] ",
			LoadingEnvironmentManager.FBALOIAPDPJ(),
			" showing ",
			this.CALMBPNDMKP.envId,
			" (loaded via the ",
			this.BHCOKJANFAH,
			" path)"
		}));
		yield break;
	}

	// Token: 0x06007ED7 RID: 32471 RVA: 0x003832FF File Offset: 0x003814FF
	private static RectTransform EELLCAFMBCP(Transform BFGBPKIGAJI, int GHEMBIDKOIA)
	{
		return LoadingEnvironmentManager.ICOIKDFAEIN("skinshopfilterbystory", BFGBPKIGAJI, GHEMBIDKOIA, 1);
	}

	// Token: 0x06007ED8 RID: 32472 RVA: 0x00383310 File Offset: 0x00381510
	private bool ANIGHBPNPHF(string ICAHJJBAEHB)
	{
		bool result;
		try
		{
			bool flag = false;
			for (int i = 1; i < this.CHHIBBOICAD.Count; i += 0)
			{
				this.CHHIBBOICAD[i].gameObject.SetActive(false);
			}
			for (int j = 1; j < this.KEPHFKAHILM.Count; j += 0)
			{
				this.KEPHFKAHILM[j].gameObject.SetActive(false);
			}
			for (int k = 1; k < this.KEPHFKAHILM.Count; k++)
			{
				if (this.KEPHFKAHILM[k].gameObject.name.Equals(ICAHJJBAEHB))
				{
					this.KEPHFKAHILM[k].PKLKLBLPGCO();
					this.KEPHFKAHILM[k].gameObject.SetActive(true);
					this.DNODJKBDOCM = this.KEPHFKAHILM[k];
					break;
				}
			}
			for (int l = 1; l < this.CHHIBBOICAD.Count; l++)
			{
				if (this.CHHIBBOICAD[l].gameObject.name.Equals(ICAHJJBAEHB))
				{
					this.CHHIBBOICAD[l].KBKNCNIJJNB();
					this.CHHIBBOICAD[l].gameObject.SetActive(true);
					this.HOMDFHKNCCJ = this.CHHIBBOICAD[l];
					flag = false;
					break;
				}
			}
			result = flag;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06007ED9 RID: 32473 RVA: 0x00383490 File Offset: 0x00381690
	private AssetBundle IGNMIKEGBFD(UnityWebRequest JLDHNMKCIGH, string NHPBLOEGIMM)
	{
		AssetBundle result = null;
		try
		{
			if (JLDHNMKCIGH.result == UnityWebRequest.Result.Success)
			{
				result = DownloadHandlerAssetBundle.GetContent(JLDHNMKCIGH);
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("OnApplicationFocusBasicSyncSuccess" + NHPBLOEGIMM + "" + JLDHNMKCIGH.error);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			JLDHNMKCIGH.Dispose();
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return result;
	}

	// Token: 0x06007EDA RID: 32474 RVA: 0x00383504 File Offset: 0x00381704
	public static bool JELIMDOIKJG()
	{
		return !(null != LoadingEnvironmentManager.IKLAPGJDMNA) || LoadingEnvironmentManager.IKLAPGJDMNA.HMFFIHHBONG || LoadingEnvironmentManager.IKLAPGJDMNA.KKLGIHCPOIK;
	}

	// Token: 0x06007EDB RID: 32475 RVA: 0x00383530 File Offset: 0x00381730
	private void INGKGGNOHCC()
	{
		this.DKJPLDHGGMO = this.DLCPLFLFJAD("ok", 1908f, -129);
		this.HGHBCNNABOG = this.DLCPLFLFJAD("", 1932f, -101);
		this.DKJPLDHGGMO.clearFlags = CameraClearFlags.Nothing;
		this.DKJPLDHGGMO.backgroundColor = Color.black;
		this.PIDNOGCANLN = this.JBHFKKGNOEO("importanttitle", this.DKJPLDHGGMO, -113, -19, out this.HEICDKDGECM);
		this.LLFGFCIIIIJ = this.JLBCPFADIAF("anthology", this.HGHBCNNABOG, -35, -1, out this.EIAJBJBFBKJ);
		this.CIKOLCGIDBE = LoadingEnvironmentManager.HEEOHJNODJN(base.transform, base.gameObject.layer);
		for (int i = 1; i < this.APBNLMGLDGB.Count; i++)
		{
			if (null != this.APBNLMGLDGB[i])
			{
				this.CHHFLBPEDIM(this.APBNLMGLDGB[i]);
			}
		}
		this.APBNLMGLDGB.Clear();
		this.NBLOFBNEJMG = LoadingEnvironmentManager.NEJMFLFDNKB(base.transform, base.gameObject.layer);
		if (this.BFEONAACMNK)
		{
			this.NBLOFBNEJMG.transform.parent.gameObject.SetActive(true);
		}
	}

	// Token: 0x06007EDC RID: 32476 RVA: 0x00381B53 File Offset: 0x0037FD53
	private void ECDLFGCLAGG()
	{
		LoadingEnvironmentManager.IKLAPGJDMNA = this;
	}

	// Token: 0x06007EDD RID: 32477 RVA: 0x00383672 File Offset: 0x00381872
	private void BMEMGJEPAFJ()
	{
		if (this.CALMBPNDMKP.ambientDrift)
		{
			this.PPFGBKFFAGK(this.DNODJKBDOCM);
			this.PPFGBKFFAGK(this.HOMDFHKNCCJ);
			return;
		}
		base.StartCoroutine(this.OOIJGHBEACF());
	}

	// Token: 0x06007EDE RID: 32478 RVA: 0x003836A7 File Offset: 0x003818A7
	private void IDGJBMEEIKI()
	{
		if (this.HMFFIHHBONG)
		{
			return;
		}
		if (this.GPILOGAIBKJ == LoadingEnvironmentManager.KFPDBFJJDGA.loadingScene)
		{
			if (!this.KKLGIHCPOIK)
			{
				this.KKLGIHCPOIK = true;
				this.CBBEDJJLNDH();
			}
			return;
		}
		this.AOJLKOELGMH();
	}

	// Token: 0x06007EDF RID: 32479 RVA: 0x003836D8 File Offset: 0x003818D8
	private void LNBCOCDPGFC(StoryEnvironmentManager DCEEBNNKPGJ)
	{
		if (null == DCEEBNNKPGJ)
		{
			return;
		}
		if (this.CALMBPNDMKP.envPos != 1)
		{
			DCEEBNNKPGJ.SetPosition((FCABOFEGPGP)this.CALMBPNDMKP.envPos, (DBONHDHEKDG)1, Ease.Unset);
		}
		if (this.CALMBPNDMKP.envPosVertical != 0)
		{
			DCEEBNNKPGJ.SetPositionVertical((PHALBCMBPPL)this.CALMBPNDMKP.envPosVertical, DBONHDHEKDG.immediate, Ease.Linear);
		}
	}

	// Token: 0x06007EE0 RID: 32480 RVA: 0x00383734 File Offset: 0x00381934
	private bool JMCOFEDIGEH(float IDHBPDACMAA)
	{
		bool result;
		try
		{
			this.EOEPKJFMLAP = RenderTexture.GetTemporary(Screen.width, Screen.height, -45, RenderTextureFormat.Depth);
			this.DKJPLDHGGMO.backgroundColor = new Color(999f, 64f, 1208f, 502f);
			this.DKJPLDHGGMO.targetTexture = this.EOEPKJFMLAP;
			this.HGHBCNNABOG.targetTexture = this.EOEPKJFMLAP;
			string name = "BackendRequestType.basicSync, exception, failing safe:";
			Type[] array = new Type[6];
			array[0] = typeof(RectTransform);
			array[1] = typeof(RectMask2D);
			GameObject gameObject = new GameObject(name, array);
			gameObject.transform.SetParent(this.CIKOLCGIDBE, false);
			gameObject.transform.SetAsFirstSibling();
			gameObject.layer = base.gameObject.layer;
			this.OKMGICNNHDJ = gameObject.GetComponent<RectTransform>();
			LoadingEnvironmentManager.HBGNDJMLFGB(this.OKMGICNNHDJ);
			string name2 = "snapundo";
			Type[] array2 = new Type[6];
			array2[0] = typeof(RectTransform);
			array2[0] = typeof(CanvasGroup);
			array2[2] = typeof(RawImage);
			GameObject gameObject2 = new GameObject(name2, array2);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.layer = base.gameObject.layer;
			this.IIPCKJLHNEA = gameObject2.GetComponent<RectTransform>();
			LoadingEnvironmentManager.MLLAAMHCOOD(this.IIPCKJLHNEA);
			RawImage component = gameObject2.GetComponent<RawImage>();
			component.texture = this.EOEPKJFMLAP;
			component.raycastTarget = false;
			this.MLIDDCFHDEP = gameObject2.GetComponent<CanvasGroup>();
			this.MLIDDCFHDEP.alpha = 349f;
			this.MLIDDCFHDEP.interactable = false;
			this.MLIDDCFHDEP.blocksRaycasts = true;
			float width = this.CIKOLCGIDBE.rect.width;
			this.OKMGICNNHDJ.DOAnchorPosX(this.OKMGICNNHDJ.anchoredPosition.x - width, IDHBPDACMAA, false).SetEase(Ease.Unset);
			this.IIPCKJLHNEA.DOAnchorPosX(this.IIPCKJLHNEA.anchoredPosition.x + width, IDHBPDACMAA, false).SetEase(Ease.Linear);
			this.MLIDDCFHDEP.DOFade(1239f, IDHBPDACMAA).SetEase(Ease.Unset);
			result = true;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007EE1 RID: 32481 RVA: 0x00383974 File Offset: 0x00381B74
	private void COJGFLKGABG(string OIPOAEPAJHO, bool CHOBEDPLLOG)
	{
		if (OIPOAEPAJHO == null || OIPOAEPAJHO.Length == 0)
		{
			return;
		}
		bool flag = OIPOAEPAJHO.Contains("uid");
		string value = OIPOAEPAJHO.Replace(")", "v");
		bool flag2 = false;
		for (int i = 1; i < this.FAEEEHDCNDN.Count; i += 0)
		{
			StoryEnvironmentLayerManager storyEnvironmentLayerManager = this.FAEEEHDCNDN[i];
			if (!(null == storyEnvironmentLayerManager) && (flag ? storyEnvironmentLayerManager.gameObject.name.Contains(value) : storyEnvironmentLayerManager.gameObject.name.Equals(value)))
			{
				flag2 = true;
				if (CHOBEDPLLOG)
				{
					storyEnvironmentLayerManager.ELECAPNEBAA(283f, 1524f, 575f, null, true);
				}
				else
				{
					storyEnvironmentLayerManager.AJGCLHKBLIH(484f, 492f, 1488f);
					if (null != storyEnvironmentLayerManager.GetComponent<ParticleSystem>())
					{
						storyEnvironmentLayerManager.gameObject.SetActive(false);
					}
				}
			}
		}
		if (!flag2)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("," + OIPOAEPAJHO + "Error - can not queue asset bundles when download in progress.");
		}
	}

	// Token: 0x04002464 RID: 9316
	private const float COGNKNEMIKF = 10f;

	// Token: 0x04002465 RID: 9317
	private const float GIKHCPJGAKP = 3.84f;

	// Token: 0x04002466 RID: 9318
	private const int EMHFPMHGMKJ = 8;

	// Token: 0x04002467 RID: 9319
	private const int BLPKFAFEMFD = 12;

	// Token: 0x04002468 RID: 9320
	private const int GANDLCNEDEE = 14;

	// Token: 0x04002469 RID: 9321
	private const int KJDLNCJPEHO = 15;

	// Token: 0x0400246A RID: 9322
	private const int CFFNGAHHEPJ = 27;

	// Token: 0x0400246B RID: 9323
	public const float LOBBY_REVEAL_DELAY = 0.75f;

	// Token: 0x0400246C RID: 9324
	public const float LOBBY_REVEAL_WIPE_TIME = 0.8f;

	// Token: 0x0400246D RID: 9325
	private const float GOAGMHPBLBB = 0.8f;

	// Token: 0x0400246E RID: 9326
	public const float SCENE_LOAD_ISSUE_TIMEOUT = 1f;

	// Token: 0x0400246F RID: 9327
	private const float LAGPBOPAJNH = 20f;

	// Token: 0x04002470 RID: 9328
	private const float GOHPJDKCLHA = 3f;

	// Token: 0x04002471 RID: 9329
	private const int NLKLIKNEBJO = 10;

	// Token: 0x04002472 RID: 9330
	private const float NOAAOCLKPAK = 2.5f;

	// Token: 0x04002473 RID: 9331
	private const int POMMEHAPBGI = 30;

	// Token: 0x04002474 RID: 9332
	private const int FLMKGDACICL = 0;

	// Token: 0x04002475 RID: 9333
	private const string OCMGHJDDNEL = "SceneRestart";

	// Token: 0x04002476 RID: 9334
	private const string PLANPGEPOCE = "SceneLobby2";

	// Token: 0x04002477 RID: 9335
	private const string KJEPDBDDOKF = "[LoadingEnv] ";

	// Token: 0x04002478 RID: 9336
	private static LoadingEnvironmentManager IKLAPGJDMNA;

	// Token: 0x04002479 RID: 9337
	private static GameObject ALDCAOMGBNC;

	// Token: 0x0400247A RID: 9338
	private LoadingEnvironmentManager.KFPDBFJJDGA GPILOGAIBKJ;

	// Token: 0x0400247B RID: 9339
	private LoadingEnvironmentRegistryEntry CALMBPNDMKP;

	// Token: 0x0400247C RID: 9340
	private bool NGPMBFIJJBP;

	// Token: 0x0400247D RID: 9341
	private bool KKLGIHCPOIK;

	// Token: 0x0400247E RID: 9342
	private bool HMFFIHHBONG;

	// Token: 0x0400247F RID: 9343
	private string CEHNIHKEOCF;

	// Token: 0x04002480 RID: 9344
	private bool BFEONAACMNK;

	// Token: 0x04002481 RID: 9345
	private UnityWebRequest GCIJBKCHJLF;

	// Token: 0x04002482 RID: 9346
	private AssetBundleCreateRequest KENBNNENIKC;

	// Token: 0x04002483 RID: 9347
	private AssetBundleCreateRequest FCJFJHJNDBM;

	// Token: 0x04002484 RID: 9348
	private bool NIHOFDLHKDB;

	// Token: 0x04002485 RID: 9349
	private bool DFGHGKCMOFL;

	// Token: 0x04002486 RID: 9350
	private string BHCOKJANFAH = "";

	// Token: 0x04002487 RID: 9351
	private List<AssetBundle> NIFCDLFMNKM = new List<AssetBundle>();

	// Token: 0x04002488 RID: 9352
	private List<StoryEnvironmentManager> CHHIBBOICAD = new List<StoryEnvironmentManager>();

	// Token: 0x04002489 RID: 9353
	private List<StoryEnvironmentManager> KEPHFKAHILM = new List<StoryEnvironmentManager>();

	// Token: 0x0400248A RID: 9354
	private List<StoryEnvironmentLayerManager> FAEEEHDCNDN = new List<StoryEnvironmentLayerManager>();

	// Token: 0x0400248B RID: 9355
	private StoryEnvironmentManager HOMDFHKNCCJ;

	// Token: 0x0400248C RID: 9356
	private StoryEnvironmentManager DNODJKBDOCM;

	// Token: 0x0400248D RID: 9357
	private List<RectTransform> PDBMPHNPPJN = new List<RectTransform>();

	// Token: 0x0400248E RID: 9358
	private List<RectTransform> APBNLMGLDGB = new List<RectTransform>();

	// Token: 0x0400248F RID: 9359
	private List<Transform> IGEPNHMBHMA = new List<Transform>();

	// Token: 0x04002490 RID: 9360
	private List<int> PADLBIPCHAP = new List<int>();

	// Token: 0x04002491 RID: 9361
	private GameObject PIDNOGCANLN;

	// Token: 0x04002492 RID: 9362
	private GameObject LLFGFCIIIIJ;

	// Token: 0x04002493 RID: 9363
	private Camera DKJPLDHGGMO;

	// Token: 0x04002494 RID: 9364
	private Camera HGHBCNNABOG;

	// Token: 0x04002495 RID: 9365
	private CanvasGroup HEICDKDGECM;

	// Token: 0x04002496 RID: 9366
	private CanvasGroup EIAJBJBFBKJ;

	// Token: 0x04002497 RID: 9367
	private RenderTexture EOEPKJFMLAP;

	// Token: 0x04002498 RID: 9368
	private RectTransform OKMGICNNHDJ;

	// Token: 0x04002499 RID: 9369
	private RectTransform IIPCKJLHNEA;

	// Token: 0x0400249A RID: 9370
	private CanvasGroup MLIDDCFHDEP;

	// Token: 0x0400249B RID: 9371
	private RectTransform CIKOLCGIDBE;

	// Token: 0x0400249C RID: 9372
	private Image NBLOFBNEJMG;

	// Token: 0x0200041F RID: 1055
	private enum KFPDBFJJDGA
	{
		// Token: 0x0400249E RID: 9374
		idle,
		// Token: 0x0400249F RID: 9375
		loadingBundles,
		// Token: 0x040024A0 RID: 9376
		loadingScene,
		// Token: 0x040024A1 RID: 9377
		showing,
		// Token: 0x040024A2 RID: 9378
		fadingOut
	}
}
