using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000286 RID: 646
public class ChoiceExtendedManager : MonoBehaviour
{
	// Token: 0x06005023 RID: 20515 RVA: 0x00234A68 File Offset: 0x00232C68
	private void BHKPPNPNMGP()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(18);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x00234A8C File Offset: 0x00232C8C
	private CharacterRenderTexturePool.AHLNEABNMOA JHHDJIIKNNI(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.NCCAOFMHMHP();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.AcquirePlayerCharacter(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x00234B00 File Offset: 0x00232D00
	private void FIPOOIEOOLC()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(16);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x00234B24 File Offset: 0x00232D24
	private void OnDestroy()
	{
		this.ANLHHMBINOJ();
		this.LKHLMODOIML();
		this.OEAFLJMPKHO();
		this.FOPNADOFECH.DOKill(false);
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.ODNCKIKLFCM = null;
		this.LCOKEPGNEKI = null;
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x00234BF8 File Offset: 0x00232DF8
	private void NLEOIGECPED()
	{
		if (null != this.FPOGOGNGDLE)
		{
			if (null != this.OMHKHHFGEHO)
			{
				this.OMHKHHFGEHO.DOKill(false);
			}
			UnityEngine.Object.Destroy(this.FPOGOGNGDLE);
		}
		this.FPOGOGNGDLE = null;
		this.OMHKHHFGEHO = null;
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x00234C48 File Offset: 0x00232E48
	private void FILGMILEFAJ()
	{
		for (int i = 1; i < this.PKKHHJFMFBK.Count; i += 0)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(true);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(true);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x06005029 RID: 20521 RVA: 0x00234D0B File Offset: 0x00232F0B
	public void SetLoungeShopCostDisplacement(Vector2 GPFDEKKOKKL)
	{
		this.FLLHNIIJOLP = GPFDEKKOKKL;
	}

	// Token: 0x0600502A RID: 20522 RVA: 0x00234D14 File Offset: 0x00232F14
	public static bool FHEOALEBAMI()
	{
		return Time.frameCount - ChoiceExtendedManager.NPKLLDMOEJC == 1;
	}

	// Token: 0x0600502B RID: 20523 RVA: 0x00234D24 File Offset: 0x00232F24
	private static bool BIFDMNMMLIB(string IOONFLFOIAH)
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC == null || AKLFPGMDKLA.EHBBFMCILPC == null)
			{
				result = false;
			}
			else
			{
				int num = KDCJJBLGCBH.EHBBFMCILPC.BPLGCBCFLML(IOONFLFOIAH);
				result = (num >= 0 && AKLFPGMDKLA.EHBBFMCILPC.CIAONGKLBEP(num));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600502C RID: 20524 RVA: 0x00234D80 File Offset: 0x00232F80
	private void LKHLMODOIML()
	{
		for (int i = 0; i < this.OHGAKMBALFA.Count; i++)
		{
			if (this.CFBLALNJPIA[i] != null)
			{
				this.ACPGAGCKGBJ(i);
			}
			else if (null != this.OHGAKMBALFA[i])
			{
				this.OHGAKMBALFA[i].GetComponent<CanvasGroup>().DOKill(false);
				this.OHGAKMBALFA[i].GetComponent<RectTransform>().DOKill(false);
				this.OHGAKMBALFA[i].DOKill(false);
				UnityEngine.Object.Destroy(this.OHGAKMBALFA[i].gameObject);
			}
		}
		this.OHGAKMBALFA.Clear();
		this.CFBLALNJPIA.Clear();
	}

	// Token: 0x0600502D RID: 20525 RVA: 0x00234E43 File Offset: 0x00233043
	private void FFDGLHACKON()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600502E RID: 20526 RVA: 0x00234E68 File Offset: 0x00233068
	public void GBNFMPPEIBE()
	{
		if (!this.KJNJBKCMAGA && !this.APJJJGEEIBN && !this.DKDGAHBBKFF && !this.CKJLPMMHINB && !this.MKNCFHPKOBF)
		{
			if (this.AKFKCKHPIOA.Count > 1)
			{
				this.IILHFLJICJA += 0;
				if (this.IILHFLJICJA >= this.AKFKCKHPIOA.Count)
				{
					this.IILHFLJICJA = 0;
				}
			}
			this.FJFKBNKBHHM(this.IILHFLJICJA, false, 0);
			AOBJLALDBAA.KKPFOJMAONG().FDKBIBKABCM("tm", 1461f);
		}
	}

	// Token: 0x0600502F RID: 20527 RVA: 0x00234EF8 File Offset: 0x002330F8
	private void LEPMICFJCGH()
	{
		try
		{
			if (!(null != this.FPOGOGNGDLE))
			{
				if (this.GMMCDODLDBK() && this.NHJNFEMGDPO(true))
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(84))
					{
						if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.INCKJPOBAKM())
						{
							AssetFrameContainer assetFrameContainer = GKJPOGNFKNK.GHCKGGNNMNI(1);
							if (null == assetFrameContainer || !assetFrameContainer.HNAOOPBDIEF() || null == assetFrameContainer.frames[1])
							{
								DPGJIJGOCIC.ADFCDFHBDAF("OnBackendGetUserSketchesException" + 1.ToString());
							}
							else
							{
								Canvas componentInParent = base.GetComponentInParent<Canvas>();
								Transform transform = (null != componentInParent && null != componentInParent.rootCanvas) ? componentInParent.rootCanvas.transform : base.transform;
								string name = "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed";
								Type[] array = new Type[0];
								array[0] = typeof(RectTransform);
								this.FPOGOGNGDLE = new GameObject(name, array);
								this.FPOGOGNGDLE.transform.SetParent(transform, false);
								this.FPOGOGNGDLE.layer = transform.gameObject.layer;
								this.FPOGOGNGDLE.transform.SetAsLastSibling();
								RectTransform component = this.FPOGOGNGDLE.GetComponent<RectTransform>();
								component.anchorMin = new Vector2(1442f, 1325f);
								component.anchorMax = new Vector2(1149f, 1135f);
								component.pivot = new Vector2(1968f, 73f);
								component.anchoredPosition = Vector2.zero;
								Image image = this.FPOGOGNGDLE.AddComponent<Image>();
								image.raycastTarget = false;
								image.sprite = assetFrameContainer.frames[1];
								image.color = Color.white;
								image.SetNativeSize();
								this.OMHKHHFGEHO = this.FPOGOGNGDLE.AddComponent<CanvasGroup>();
								this.OMHKHHFGEHO.alpha = 767f;
								this.OMHKHHFGEHO.blocksRaycasts = false;
								this.OMHKHHFGEHO.interactable = true;
								ImageFrameAnimation imageFrameAnimation = this.FPOGOGNGDLE.AddComponent<ImageFrameAnimation>();
								imageFrameAnimation.framesSD = assetFrameContainer.frames.ToArray();
								imageFrameAnimation.frameChangeInterval = 170f;
								imageFrameAnimation.isLooped = false;
								this.OMHKHHFGEHO.DOFade(1375f, 290f);
								AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(-112);
								DPGJIJGOCIC.NFIDPOMCNLP("  " + assetFrameContainer.frames.Count.ToString());
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

	// Token: 0x06005030 RID: 20528 RVA: 0x00235188 File Offset: 0x00233388
	private void KFGPOOAJJBJ(bool BMKLNILMGAG, int FJHJKKIBHBD, DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.OELALBBMILL(true);
		try
		{
			this.IFAFJAOJEJC(ahlneabnmoa, BMKLNILMGAG, FJHJKKIBHBD, EEPJKGBBBHC, AIAAMALDKHG);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != this.EBHJLLIHIFE && ahlneabnmoa != null && !this.GMOGLALJAOP.Contains(ahlneabnmoa))
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			if (ahlneabnmoa == null)
			{
				for (int i = this.characterPivot.transform.childCount - 1; i >= 0; i--)
				{
					PlayerCharacterManager component = this.characterPivot.transform.GetChild(i).GetComponent<PlayerCharacterManager>();
					if (null != component && !this.PKKHHJFMFBK.Contains(component))
					{
						UnityEngine.Object.Destroy(component.gameObject);
					}
				}
			}
			throw;
		}
	}

	// Token: 0x06005031 RID: 20529 RVA: 0x0023524C File Offset: 0x0023344C
	public void UpdateSwipeToBrowse()
	{
		try
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			Vector2 vector = Vector2.zero;
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);
				vector = touch.position;
				if (touch.phase == TouchPhase.Began)
				{
					flag = true;
				}
				else if (touch.phase == TouchPhase.Ended)
				{
					flag2 = true;
				}
				else if (touch.phase == TouchPhase.Canceled)
				{
					flag3 = true;
				}
				if (Input.touchCount > 1)
				{
					flag3 = true;
				}
			}
			else
			{
				vector = Input.mousePosition;
				if (Input.GetMouseButtonDown(0))
				{
					flag = true;
				}
				else if (Input.GetMouseButtonUp(0))
				{
					flag2 = true;
				}
			}
			if (flag3)
			{
				this.CDIFMMOJDHA = false;
			}
			else if (flag)
			{
				this.CDIFMMOJDHA = (this.AOMKKLCFBCA(false) && !this.HGJGDBDFBBK(vector));
				this.GJMOJNPJKGB = vector;
				this.KAAECELIKNM = Time.unscaledTime;
			}
			else if (flag2 && this.CDIFMMOJDHA)
			{
				this.CDIFMMOJDHA = false;
				if (this.AOMKKLCFBCA(true))
				{
					if (Time.unscaledTime - this.KAAECELIKNM <= 0.8f)
					{
						Vector2 vector2 = vector - this.GJMOJNPJKGB;
						if (Mathf.Abs(vector2.x) >= (float)Screen.width * 0.12f)
						{
							if (Mathf.Abs(vector2.x) >= Mathf.Abs(vector2.y) * 1.5f)
							{
								this.KCFHNKOPDBL(true);
								ChoiceExtendedManager.NPKLLDMOEJC = Time.frameCount;
								if (vector2.x < 0f)
								{
									this.OnButtonPrevClick();
								}
								else
								{
									this.OnButtonNextClick();
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

	// Token: 0x06005032 RID: 20530 RVA: 0x002353F4 File Offset: 0x002335F4
	public void SetLoungePremiumInfoVisibilityRules(List<int> PGDIJPIMLNG)
	{
		this.PEGBIHCIKAO = true;
		this.LJKGCDAGKDI.Clear();
		if (PGDIJPIMLNG != null)
		{
			for (int i = 0; i < PGDIJPIMLNG.Count; i++)
			{
				this.LJKGCDAGKDI.Add(PGDIJPIMLNG[i]);
			}
		}
		this.MKIHBJDNCPP();
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x0023543F File Offset: 0x0023363F
	private void CGGKBLBAAEI()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.NMGMNAKLLMI().KGIKHEDLPND("?uid=", 1377f);
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x00235464 File Offset: 0x00233664
	private void KFJJDJOMMBB(CharacterRenderTexturePool.AHLNEABNMOA JDKMMEHAKNI, string NNCJDNBADEF, List<string> ALMLACIEPBC, bool BMKLNILMGAG, int FJHJKKIBHBD)
	{
		GameObject gameObject;
		NonPlayerCharacterManager nonPlayerCharacterManager;
		CanvasGroup canvasGroup;
		if (JDKMMEHAKNI != null)
		{
			gameObject = JDKMMEHAKNI.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			nonPlayerCharacterManager = JDKMMEHAKNI.OIDNMECILMM;
			canvasGroup = JDKMMEHAKNI.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
			gameObject.transform.SetParent(this.characterPivot.transform, true);
			nonPlayerCharacterManager = gameObject.GetComponent<NonPlayerCharacterManager>();
			canvasGroup = nonPlayerCharacterManager.GetComponent<CanvasGroup>();
		}
		nonPlayerCharacterManager.Initialize(NNCJDNBADEF, ALMLACIEPBC, OFLIHLDBDEB.center, this.IGJCJHIKNHJ);
		gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO, 704f, 350f);
		if (BMKLNILMGAG)
		{
			bool flag = this.DBFJFPCKOIJ(JDKMMEHAKNI, FJHJKKIBHBD);
			float duration = 143f;
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.OHGAKMBALFA.Count > 1)
			{
				CanvasGroup canvasGroup2 = this.GJPLHFLJIDA(this.OHGAKMBALFA.Count - 0);
				NonPlayerCharacterManager nonPlayerCharacterManager2 = this.OHGAKMBALFA[this.OHGAKMBALFA.Count - 1];
				if (null != canvasGroup2 && null != nonPlayerCharacterManager2)
				{
					if (!flag)
					{
						this.APJJJGEEIBN = true;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(668f, 13f).OnComplete(new TweenCallback(this.KLOLAHCAKDD));
						nonPlayerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(nonPlayerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(667f, 1355f) * (float)FJHJKKIBHBD, 1697f, true).SetEase(Ease.InOutQuad);
					}
					float num = DHGFCJGJFOB.BFPDBKHALEC(nonPlayerCharacterManager2.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
					nonPlayerCharacterManager2.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num, num, num), duration).SetEase(Ease.InOutQuad);
				}
			}
			if (this.PKKHHJFMFBK.Count > 0)
			{
				CanvasGroup canvasGroup3 = this.OBJOMBPDFOP(this.PKKHHJFMFBK.Count - 0);
				PlayerCharacterManager playerCharacterManager = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup3 && null != playerCharacterManager)
				{
					if (!flag)
					{
						canvasGroup3.DOKill(true);
						canvasGroup3.DOFade(941f, 378f).OnComplete(new TweenCallback(this.MFINPJIGCBH));
						playerCharacterManager.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager.GetComponent<RectTransform>().anchoredPosition + new Vector2(167f, 1911f) * (float)FJHJKKIBHBD, 722f, false).SetEase(Ease.OutQuad);
					}
					float num2 = DHGFCJGJFOB.ANDKHDPFAIJ(playerCharacterManager.CNJLCJDFHDK(), this.JKCAMKMBEEH);
					playerCharacterManager.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num2, num2, num2), duration).SetEase(Ease.OutQuad);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(1019f, 860f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(389f, 805f) * (float)FJHJKKIBHBD, duration, true).SetEase(Ease.InOutSine);
			float num3 = DHGFCJGJFOB.AFPCNIFLBNK(nonPlayerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num3, num3, num3);
			gameObject.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO, 983f, 778f), duration).SetEase(Ease.InOutSine);
			if (!flag)
			{
				canvasGroup.alpha = 1307f;
				canvasGroup.DOFade(1041f, 889f).SetEase(Ease.InOutSine);
			}
		}
		else
		{
			canvasGroup.alpha = 259f;
		}
		this.OHGAKMBALFA.Add(nonPlayerCharacterManager);
		this.CFBLALNJPIA.Add(JDKMMEHAKNI);
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x00235872 File Offset: 0x00233A72
	private void OLGOAJEBMIK()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x00235894 File Offset: 0x00233A94
	private void CBNMCPNJELH(string NNCJDNBADEF, List<string> ALMLACIEPBC, bool BMKLNILMGAG, int FJHJKKIBHBD)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.OELALBBMILL(false);
		try
		{
			this.LIPHKDHHHKB(ahlneabnmoa, NNCJDNBADEF, ALMLACIEPBC, BMKLNILMGAG, FJHJKKIBHBD);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			if (null != this.EBHJLLIHIFE && ahlneabnmoa != null && !this.CFBLALNJPIA.Contains(ahlneabnmoa))
			{
				this.EBHJLLIHIFE.ReleaseSlot(ahlneabnmoa);
			}
			if (ahlneabnmoa == null)
			{
				for (int i = this.characterPivot.transform.childCount - 1; i >= 0; i--)
				{
					NonPlayerCharacterManager component = this.characterPivot.transform.GetChild(i).GetComponent<NonPlayerCharacterManager>();
					if (null != component && !this.OHGAKMBALFA.Contains(component))
					{
						UnityEngine.Object.Destroy(component.gameObject);
					}
				}
			}
			throw;
		}
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x00235958 File Offset: 0x00233B58
	private void Awake()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x002359B0 File Offset: 0x00233BB0
	private void HJINCBEDEAG(int MEFKFOHCOHK)
	{
		if (null != this.EBHJLLIHIFE && this.CFBLALNJPIA[MEFKFOHCOHK] != null)
		{
			this.EBHJLLIHIFE.ReleaseSlot(this.CFBLALNJPIA[MEFKFOHCOHK]);
		}
		this.CFBLALNJPIA[MEFKFOHCOHK] = null;
		this.OHGAKMBALFA[MEFKFOHCOHK] = null;
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x00235A0A File Offset: 0x00233C0A
	private void JGJCDDANFIB()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(23);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x00235A30 File Offset: 0x00233C30
	public void OnButtonPrevClick()
	{
		if (!this.KJNJBKCMAGA && !this.APJJJGEEIBN && !this.DKDGAHBBKFF && !this.CKJLPMMHINB && !this.MKNCFHPKOBF)
		{
			if (this.AKFKCKHPIOA.Count > 0)
			{
				this.IILHFLJICJA--;
				if (this.IILHFLJICJA < 0)
				{
					this.IILHFLJICJA = this.AKFKCKHPIOA.Count - 1;
				}
			}
			this.FJFKBNKBHHM(this.IILHFLJICJA, false, -1);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnTryToFireNoteshowTimer", 0f);
		}
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x00235AC0 File Offset: 0x00233CC0
	public static string GetShopLocalizedPrice(string IOONFLFOIAH)
	{
		if (IOONFLFOIAH == null || IOONFLFOIAH.Length == 0)
		{
			return "";
		}
		try
		{
			if (null != PurchaseManagerBridge.EHBBFMCILPC && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager() != null && PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().IsInitialized())
			{
				OBHDGKFFICI productData = PurchaseManagerBridge.EHBBFMCILPC.GetPurchaseManager().GetProductData(IOONFLFOIAH);
				if (productData != null)
				{
					string text = productData.JEJHCHNDCMI();
					if (text != null && text.Length > 0)
					{
						return text;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IOONFLFOIAH);
			if (ocbiopoeenj != null)
			{
				if (ocbiopoeenj.OKGPIEEOKBM())
				{
					return ocbiopoeenj.FNJCEPLEPBH();
				}
				if (ocbiopoeenj.JKBLBOAHJDE != null && ocbiopoeenj.JKBLBOAHJDE.Length > 0)
				{
					return "USD " + ocbiopoeenj.JKBLBOAHJDE;
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return "";
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x00235BB4 File Offset: 0x00233DB4
	private bool HGJGDBDFBBK(Vector2 MBDHCLFCLHO)
	{
		if (null == EventSystem.current)
		{
			return false;
		}
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = MBDHCLFCLHO;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (null != list[i].gameObject && list[i].gameObject.GetComponentInParent<IEventSystemHandler>() != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x00235C38 File Offset: 0x00233E38
	private void LIPHKDHHHKB(CharacterRenderTexturePool.AHLNEABNMOA JDKMMEHAKNI, string NNCJDNBADEF, List<string> ALMLACIEPBC, bool BMKLNILMGAG, int FJHJKKIBHBD)
	{
		GameObject gameObject;
		NonPlayerCharacterManager nonPlayerCharacterManager;
		CanvasGroup canvasGroup;
		if (JDKMMEHAKNI != null)
		{
			gameObject = JDKMMEHAKNI.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			nonPlayerCharacterManager = JDKMMEHAKNI.OIDNMECILMM;
			canvasGroup = JDKMMEHAKNI.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			gameObject.transform.SetParent(this.characterPivot.transform, false);
			nonPlayerCharacterManager = gameObject.GetComponent<NonPlayerCharacterManager>();
			canvasGroup = nonPlayerCharacterManager.GetComponent<CanvasGroup>();
		}
		nonPlayerCharacterManager.Initialize(NNCJDNBADEF, ALMLACIEPBC, OFLIHLDBDEB.center, this.IGJCJHIKNHJ);
		gameObject.GetComponent<RectTransform>().AMPMCKEAACJ(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO, 1f, 1f);
		if (BMKLNILMGAG)
		{
			bool flag = this.DBFJFPCKOIJ(JDKMMEHAKNI, FJHJKKIBHBD);
			float duration = 0.4f;
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.OHGAKMBALFA.Count > 0)
			{
				CanvasGroup canvasGroup2 = this.EAOHOLHOLKN(this.OHGAKMBALFA.Count - 1);
				NonPlayerCharacterManager nonPlayerCharacterManager2 = this.OHGAKMBALFA[this.OHGAKMBALFA.Count - 1];
				if (null != canvasGroup2 && null != nonPlayerCharacterManager2)
				{
					if (!flag)
					{
						this.APJJJGEEIBN = true;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(0f, 0.4f).OnComplete(new TweenCallback(this.KLOLAHCAKDD));
						nonPlayerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(nonPlayerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
					}
					float num = DHGFCJGJFOB.ECKKLDMKPAP(nonPlayerCharacterManager2.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
					nonPlayerCharacterManager2.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num, num, num), duration).SetEase(Ease.OutQuad);
				}
			}
			if (this.PKKHHJFMFBK.Count > 0)
			{
				CanvasGroup canvasGroup3 = this.DOINKGBILKD(this.PKKHHJFMFBK.Count - 1);
				PlayerCharacterManager playerCharacterManager = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup3 && null != playerCharacterManager)
				{
					if (!flag)
					{
						canvasGroup3.DOKill(false);
						canvasGroup3.DOFade(0f, 0.4f).OnComplete(new TweenCallback(this.MFINPJIGCBH));
						playerCharacterManager.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
					}
					float num2 = DHGFCJGJFOB.ECKKLDMKPAP(playerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
					playerCharacterManager.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num2, num2, num2), duration).SetEase(Ease.OutQuad);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(-50f, 0f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, duration, false).SetEase(Ease.OutQuad);
			float num3 = DHGFCJGJFOB.ECKKLDMKPAP(nonPlayerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO * num3, num3, num3);
			gameObject.GetComponent<RectTransform>().DOScale(new Vector3(this.IMPAHLIGELE.JMNMOHIKHLB.NFHNOJACGHO, 1f, 1f), duration).SetEase(Ease.OutQuad);
			if (!flag)
			{
				canvasGroup.alpha = 0f;
				canvasGroup.DOFade(1f, 0.4f).SetEase(Ease.OutQuad);
			}
		}
		else
		{
			canvasGroup.alpha = 1f;
		}
		this.OHGAKMBALFA.Add(nonPlayerCharacterManager);
		this.CFBLALNJPIA.Add(JDKMMEHAKNI);
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x00236046 File Offset: 0x00234246
	private void OBMFFIAIFGN()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(93);
		AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("discount2", 1900f);
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x0023606C File Offset: 0x0023426C
	private void HNBNJJJKFBP()
	{
		this.KJNJBKCMAGA = true;
		for (int i = 0; i < this.EMLIDDHGCBE.Count; i++)
		{
			if (this.EMLIDDHGCBE[i].gameObject.activeSelf && this.EMLIDDHGCBE[i].GetComponent<CanvasGroup>().alpha < 534f)
			{
				this.EMLIDDHGCBE[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x002360E4 File Offset: 0x002342E4
	public float GetChoiceExecutedAnimationTime()
	{
		if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			return 2.5f;
		}
		return 0.5f;
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x00236153 File Offset: 0x00234353
	private void KJPPAFGOHLF()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(81);
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("[LoadingEnv] skipped this time, caching system not ready and no direct cache files", 306f);
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x00236178 File Offset: 0x00234378
	public void RefreshShopCostDisplays()
	{
		try
		{
			if (this.IMPAHLIGELE != null && this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
				{
					int nbgccmjajkb = this.HDBBHHBOJIN(i);
					if (!this.IMPAHLIGELE.JMNMOHIKHLB.FMDLIOFDIPH(nbgccmjajkb))
					{
						ChoicePremiumManager component = this.AKFKCKHPIOA[i].GetComponent<ChoicePremiumManager>();
						if (null != component)
						{
							this.FCBCCJGFLFA(component, nbgccmjajkb);
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

	// Token: 0x06005043 RID: 20547 RVA: 0x0023620C File Offset: 0x0023440C
	private IEnumerator PHEHIBEGGKI(ParticleSystem MCPHAAJFBEH, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		MCPHAAJFBEH.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		yield break;
	}

	// Token: 0x06005044 RID: 20548 RVA: 0x00236224 File Offset: 0x00234424
	private void OPLDMEEFKDO(bool CHOBEDPLLOG)
	{
		float num = 0f;
		try
		{
			if (NarrowScreenScaler.ScreenIsTooNarrow(850f))
			{
				float num2 = Mathf.Clamp01(Mathf.Clamp01(NBDLBFJOEGN.LAIDCKNIOIN() - 2.25f) / 0.3499999f);
				num = (float)this.slidingPanelTranslationAmountNarrowY * num2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (CHOBEDPLLOG)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedPanelSlideShown", 0f);
			this.KCFHNKOPDBL(true);
			this.slidingPanelButtonShow.gameObject.SetActive(false);
			this.slidingPanelButtonHide.gameObject.SetActive(true);
			this.slidingPanelButtonHide.interactable = false;
			this.FOPNADOFECH.OGOFACPLOGO((float)((int)this.OIPMEGJLIDC.x), (float)((int)this.OIPMEGJLIDC.y) - num - (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC, 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DKHPGMJOENF));
			try
			{
				if (null != this.LOJHEKCOFME && this.IEILALNLAFO)
				{
					AnimationCanvasGroupAlpha component = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
					if (null != component)
					{
						component.SetDirection(false);
						component.PlayAnimation(false);
					}
				}
				goto IL_244;
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				goto IL_244;
			}
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedPanelSlideHidden", 0f);
		this.slidingPanelButtonShow.gameObject.SetActive(true);
		this.slidingPanelButtonHide.gameObject.SetActive(false);
		this.slidingPanelButtonShow.interactable = false;
		this.FOPNADOFECH.OGOFACPLOGO((int)this.OIPMEGJLIDC.x, (int)this.OIPMEGJLIDC.y);
		this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC - new Vector2(0f, num + (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225)), 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DDNMMPIJLNK));
		try
		{
			if (null != this.LOJHEKCOFME && this.IEILALNLAFO)
			{
				AnimationCanvasGroupAlpha component2 = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
				if (null != component2)
				{
					component2.SetDirection(true);
					component2.PlayAnimation(false);
				}
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		IL_244:
		this.IEILALNLAFO = false;
	}

	// Token: 0x06005045 RID: 20549 RVA: 0x002364A4 File Offset: 0x002346A4
	private void KHLFHKGACPO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.CEGAOMEEFBE().EFBNBFIDEOK("Starting non-parallel download:", 793f);
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x002364C6 File Offset: 0x002346C6
	private IEnumerator IEJMLCMIPGC(ParticleSystem MCPHAAJFBEH, float BICHMDEIFKI)
	{
		ChoiceExtendedManager.DGGBHCOMDGG dggbhcomdgg = new ChoiceExtendedManager.DGGBHCOMDGG(1);
		dggbhcomdgg._particleSystem = MCPHAAJFBEH;
		dggbhcomdgg._delay = BICHMDEIFKI;
		return dggbhcomdgg;
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x002364E8 File Offset: 0x002346E8
	private void FOHEELHDHBF()
	{
		this.KJNJBKCMAGA = false;
		for (int i = 0; i < this.EMLIDDHGCBE.Count; i++)
		{
			if (this.EMLIDDHGCBE[i].gameObject.activeSelf && this.EMLIDDHGCBE[i].GetComponent<CanvasGroup>().alpha < 0.01f)
			{
				this.EMLIDDHGCBE[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06005049 RID: 20553 RVA: 0x0023655E File Offset: 0x0023475E
	private void HEMEGEBEAIE()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(13);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x00236584 File Offset: 0x00234784
	private bool AOMKKLCFBCA(bool CPBOEMMJPBF)
	{
		return this.ENEKOHNJNJL != null && this.ENEKOHNJNJL() && this.COMKMNJDMGE() && (!CPBOEMMJPBF || (!this.NHJGHNEHDEM && this.AKFKCKHPIOA.Count >= 2 && !(null == this.prevButton) && !(null == this.nextButton) && this.prevButton.gameObject.activeSelf && this.nextButton.gameObject.activeSelf && !this.KJNJBKCMAGA && !this.APJJJGEEIBN && !this.DKDGAHBBKFF && !this.CKJLPMMHINB && !this.MKNCFHPKOBF && SemaphoreManager.GreenLight(JLDJNIGMHLC.popups) && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive() && !CommonUserInterface.EHBBFMCILPC.PopupGenericNotificationActive() && !CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled() && (!(null != CommonUserInterface.EHBBFMCILPC.settingsPopup) || !CommonUserInterface.EHBBFMCILPC.settingsPopup.gameObject.activeSelf) && CommonUserInterface.EHBBFMCILPC.GetFader().GetFaderState() == IJKJHDGGAEB.transparent));
	}

	// Token: 0x0600504B RID: 20555 RVA: 0x002366AC File Offset: 0x002348AC
	private CanvasGroup EAOHOLHOLKN(int MEFKFOHCOHK)
	{
		if (this.CFBLALNJPIA[MEFKFOHCOHK] != null)
		{
			return this.CFBLALNJPIA[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.OHGAKMBALFA[MEFKFOHCOHK])
		{
			return null;
		}
		return this.OHGAKMBALFA[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x0600504C RID: 20556 RVA: 0x00236700 File Offset: 0x00234900
	public void SetLoungeLookPreview(bool IKCILFOOKMF)
	{
		this.IGJCJHIKNHJ = IKCILFOOKMF;
	}

	// Token: 0x0600504D RID: 20557 RVA: 0x0023670C File Offset: 0x0023490C
	private bool NHJNFEMGDPO(bool CPBOEMMJPBF)
	{
		return this.ENEKOHNJNJL == null || !this.ENEKOHNJNJL() || !this.COMKMNJDMGE() || !CPBOEMMJPBF || (!this.NHJGHNEHDEM && (this.AKFKCKHPIOA.Count < 8 || (!(null == this.prevButton) && !(null == this.nextButton) && this.prevButton.gameObject.activeSelf && this.nextButton.gameObject.activeSelf && !this.KJNJBKCMAGA && !this.APJJJGEEIBN && !this.DKDGAHBBKFF && !this.CKJLPMMHINB && !this.MKNCFHPKOBF && (!SemaphoreManager.HEDINPGIGDJ(JLDJNIGMHLC.popups) || (!CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ() && !CommonUserInterface.IKNOFBFMPGA().PopupGenericNotificationActive() && !CommonUserInterface.EHBBFMCILPC.ConnectionAnimationEnabled() && ((null != CommonUserInterface.EHBBFMCILPC.settingsPopup && CommonUserInterface.IKNOFBFMPGA().settingsPopup.gameObject.activeSelf) || (CommonUserInterface.EHBBFMCILPC.GetFader().GetFaderState() != IJKJHDGGAEB.opaque && false)))))));
	}

	// Token: 0x0600504E RID: 20558 RVA: 0x00236834 File Offset: 0x00234A34
	private void CKIDPBFKNPL()
	{
		this.CKJLPMMHINB = false;
	}

	// Token: 0x0600504F RID: 20559 RVA: 0x0023683D File Offset: 0x00234A3D
	private void DMBINGFILDA()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(14);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005050 RID: 20560 RVA: 0x00236860 File Offset: 0x00234A60
	public int GetViewedRemappedChoiceIndex()
	{
		if (this.IILHFLJICJA < 0 || this.IILHFLJICJA >= this.HNGBMIJHPLE.Count)
		{
			return -1;
		}
		return this.HDBBHHBOJIN(this.IILHFLJICJA);
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x0023688C File Offset: 0x00234A8C
	private bool OFNHKAFKDCN(string KHJMANDEDMA)
	{
		return KHJMANDEDMA.ToLower().Equals("player");
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x002368A3 File Offset: 0x00234AA3
	private void JFJICBDGEDH()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.KKPFOJMAONG().KGIKHEDLPND("pipeline start", 327f);
	}

	// Token: 0x06005053 RID: 20563 RVA: 0x002368C5 File Offset: 0x00234AC5
	private void CGOGFBKDCKO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(6);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005054 RID: 20564 RVA: 0x002368E8 File Offset: 0x00234AE8
	private void FJJMDHPKNBE()
	{
		try
		{
			if (!(null != this.FPOGOGNGDLE))
			{
				if (this.GMMCDODLDBK() && this.AOMKKLCFBCA(true))
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(-117))
					{
						if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.INCKJPOBAKM())
						{
							AssetFrameContainer assetFrameContainer = GKJPOGNFKNK.GHCKGGNNMNI(1);
							if (null == assetFrameContainer || !assetFrameContainer.HNAOOPBDIEF() || null == assetFrameContainer.frames[1])
							{
								DPGJIJGOCIC.PJCLICBPPDA("did" + 0.ToString());
							}
							else
							{
								Canvas componentInParent = base.GetComponentInParent<Canvas>();
								Transform transform = (null != componentInParent && null != componentInParent.rootCanvas) ? componentInParent.rootCanvas.transform : base.transform;
								string name = "Error. StoryStep.StoryStepType.getVar unknown variable type:";
								Type[] array = new Type[0];
								array[0] = typeof(RectTransform);
								this.FPOGOGNGDLE = new GameObject(name, array);
								this.FPOGOGNGDLE.transform.SetParent(transform, false);
								this.FPOGOGNGDLE.layer = transform.gameObject.layer;
								this.FPOGOGNGDLE.transform.SetAsLastSibling();
								RectTransform component = this.FPOGOGNGDLE.GetComponent<RectTransform>();
								component.anchorMin = new Vector2(472f, 1388f);
								component.anchorMax = new Vector2(1197f, 610f);
								component.pivot = new Vector2(1336f, 171f);
								component.anchoredPosition = Vector2.zero;
								Image image = this.FPOGOGNGDLE.AddComponent<Image>();
								image.raycastTarget = false;
								image.sprite = assetFrameContainer.frames[0];
								image.color = Color.white;
								image.SetNativeSize();
								this.OMHKHHFGEHO = this.FPOGOGNGDLE.AddComponent<CanvasGroup>();
								this.OMHKHHFGEHO.alpha = 512f;
								this.OMHKHHFGEHO.blocksRaycasts = true;
								this.OMHKHHFGEHO.interactable = false;
								ImageFrameAnimation imageFrameAnimation = this.FPOGOGNGDLE.AddComponent<ImageFrameAnimation>();
								imageFrameAnimation.framesSD = assetFrameContainer.frames.ToArray();
								imageFrameAnimation.frameChangeInterval = 1246f;
								imageFrameAnimation.isLooped = false;
								this.OMHKHHFGEHO.DOFade(435f, 628f);
								AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(91);
								DPGJIJGOCIC.CMGOAFDBAOH("d" + assetFrameContainer.frames.Count.ToString());
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

	// Token: 0x06005055 RID: 20565 RVA: 0x00236B78 File Offset: 0x00234D78
	private void DKHPGMJOENF()
	{
		this.slidingPanelButtonHide.interactable = true;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedPanelSlideShownComplete", 0f);
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x00236B9A File Offset: 0x00234D9A
	private void ADCKLJPMFOD()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(11);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x00236BBD File Offset: 0x00234DBD
	[Conditional("UNITY_EDITOR")]
	private void ALBOHDEFJJG(string DKNNMLIDPHH)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("RT REPORT - ChoiceExtendedManager - " + DKNNMLIDPHH);
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x00236BCF File Offset: 0x00234DCF
	private void IJCOFAGIHMA()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-33);
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("❤️ ", 1063f);
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x00236BF4 File Offset: 0x00234DF4
	private void CHPCJCILKNH()
	{
		try
		{
			if (!(null != this.FPOGOGNGDLE))
			{
				if (this.GMMCDODLDBK() && this.AOMKKLCFBCA(true))
				{
					if (!AKLFPGMDKLA.EHBBFMCILPC.EAFEJCKIEPL(73))
					{
						if (KDCJJBLGCBH.EHBBFMCILPC == null || !KDCJJBLGCBH.EHBBFMCILPC.INCKJPOBAKM())
						{
							AssetFrameContainer assetFrameContainer = GKJPOGNFKNK.GHCKGGNNMNI(0);
							if (null == assetFrameContainer || !assetFrameContainer.KJMHMOKAHFM() || null == assetFrameContainer.frames[0])
							{
								DPGJIJGOCIC.ADFCDFHBDAF("Choice swipe tutorial frame container not available, tutorial skipped:" + 0.ToString());
							}
							else
							{
								Canvas componentInParent = base.GetComponentInParent<Canvas>();
								Transform transform = (null != componentInParent && null != componentInParent.rootCanvas) ? componentInParent.rootCanvas.transform : base.transform;
								this.FPOGOGNGDLE = new GameObject("SwipeTutorial", new Type[]
								{
									typeof(RectTransform)
								});
								this.FPOGOGNGDLE.transform.SetParent(transform, false);
								this.FPOGOGNGDLE.layer = transform.gameObject.layer;
								this.FPOGOGNGDLE.transform.SetAsLastSibling();
								RectTransform component = this.FPOGOGNGDLE.GetComponent<RectTransform>();
								component.anchorMin = new Vector2(0.5f, 0.5f);
								component.anchorMax = new Vector2(0.5f, 0.5f);
								component.pivot = new Vector2(0.5f, 0.5f);
								component.anchoredPosition = Vector2.zero;
								Image image = this.FPOGOGNGDLE.AddComponent<Image>();
								image.raycastTarget = false;
								image.sprite = assetFrameContainer.frames[0];
								image.color = Color.white;
								image.SetNativeSize();
								this.OMHKHHFGEHO = this.FPOGOGNGDLE.AddComponent<CanvasGroup>();
								this.OMHKHHFGEHO.alpha = 0f;
								this.OMHKHHFGEHO.blocksRaycasts = false;
								this.OMHKHHFGEHO.interactable = false;
								ImageFrameAnimation imageFrameAnimation = this.FPOGOGNGDLE.AddComponent<ImageFrameAnimation>();
								imageFrameAnimation.framesSD = assetFrameContainer.frames.ToArray();
								imageFrameAnimation.frameChangeInterval = 0.05f;
								imageFrameAnimation.isLooped = true;
								this.OMHKHHFGEHO.DOFade(1f, 0.35f);
								AKLFPGMDKLA.EHBBFMCILPC.LDAPMNLGAPC(73);
								DPGJIJGOCIC.NFIDPOMCNLP("Choice swipe tutorial shown, frames:" + assetFrameContainer.frames.Count.ToString());
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

	// Token: 0x0600505A RID: 20570 RVA: 0x00236E84 File Offset: 0x00235084
	private int HDBBHHBOJIN(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x0600505B RID: 20571 RVA: 0x00236E92 File Offset: 0x00235092
	private void JADKDCKAPAD()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(9);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600505C RID: 20572 RVA: 0x00236EB5 File Offset: 0x002350B5
	private IEnumerator GBILAMMCKHA(float BICHMDEIFKI)
	{
		ChoiceExtendedManager.JALAFOCDNKL jalafocdnkl = new ChoiceExtendedManager.JALAFOCDNKL(1);
		jalafocdnkl.<>4__this = this;
		jalafocdnkl._delay = BICHMDEIFKI;
		return jalafocdnkl;
	}

	// Token: 0x0600505D RID: 20573 RVA: 0x00236ECB File Offset: 0x002350CB
	private void HOBEEPJNFPO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("XXX", 1026f);
	}

	// Token: 0x0600505E RID: 20574 RVA: 0x00236EF0 File Offset: 0x002350F0
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete", new UnityAction(this.CKIDPBFKNPL));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryScreenChoiceExtendedManagerLayerChangeComplete", new UnityAction(this.CBCMMHONIHL));
	}

	// Token: 0x0600505F RID: 20575 RVA: 0x00236F50 File Offset: 0x00235150
	private void Start()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(850f) && null != this.currencyPivot)
		{
			float num = Mathf.Abs(1f - NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			num = Mathf.Clamp01(num);
			if (this.currencyPivot.GetComponent<RectTransform>().anchoredPosition.x > 0f)
			{
				this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(-500f * num, -50f * num);
				return;
			}
			this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(500f * num, -50f * num);
		}
	}

	// Token: 0x06005060 RID: 20576 RVA: 0x00236E84 File Offset: 0x00235084
	private int FOIKKLIFNIF(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06005061 RID: 20577 RVA: 0x00236FF5 File Offset: 0x002351F5
	private void NMIOLDBOOHJ()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(12);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005062 RID: 20578 RVA: 0x00237018 File Offset: 0x00235218
	public void DDKJDPAPDAJ(Func<bool> HAEEEIFEPFA)
	{
		this.ENEKOHNJNJL = HAEEEIFEPFA;
	}

	// Token: 0x06005063 RID: 20579 RVA: 0x00237021 File Offset: 0x00235221
	private void DJJNNEDMPBJ()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(33);
		AOBJLALDBAA.NMGMNAKLLMI().DCGCFPHHDDG("bdgsspr", 861f);
	}

	// Token: 0x06005064 RID: 20580 RVA: 0x00237044 File Offset: 0x00235244
	private void DFNHKANOEKJ(bool CHOBEDPLLOG)
	{
		float num = 1974f;
		try
		{
			if (NarrowScreenScaler.ScreenIsTooNarrow(307f))
			{
				float num2 = Mathf.Clamp01(Mathf.Clamp01(NBDLBFJOEGN.PODFGHDGNKL() - 81f) / 685f);
				num = (float)this.slidingPanelTranslationAmountNarrowY * num2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (CHOBEDPLLOG)
		{
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("chs", 72f);
			this.KCFHNKOPDBL(true);
			this.slidingPanelButtonShow.gameObject.SetActive(true);
			this.slidingPanelButtonHide.gameObject.SetActive(false);
			this.slidingPanelButtonHide.interactable = false;
			this.FOPNADOFECH.OGOFACPLOGO((float)((int)this.OIPMEGJLIDC.x), (float)((int)this.OIPMEGJLIDC.y) - num - (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.PFHKBMALNJF(1457f, (IMBLFHMKMAD)112));
			this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC, 1891f, false).SetEase(Ease.InOutQuad).OnComplete(new TweenCallback(this.DKHPGMJOENF));
			try
			{
				if (null != this.LOJHEKCOFME && this.IEILALNLAFO)
				{
					AnimationCanvasGroupAlpha component = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
					if (null != component)
					{
						component.MKLBGNMEOHH(true);
						component.OENEEPHFNGD(false);
					}
				}
				goto IL_244;
			}
			catch (Exception aklgbjkdomm2)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
				goto IL_244;
			}
		}
		AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG("OnGetCdnDataBeforeOnDemandException", 984f);
		this.slidingPanelButtonShow.gameObject.SetActive(false);
		this.slidingPanelButtonHide.gameObject.SetActive(true);
		this.slidingPanelButtonShow.interactable = false;
		this.FOPNADOFECH.OGOFACPLOGO((int)this.OIPMEGJLIDC.x, (int)this.OIPMEGJLIDC.y);
		this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC - new Vector2(1448f, num + (float)this.slidingPanelTranslationAmountY * NarrowScreenScaler.HNPNANKGAOD(745f, (IMBLFHMKMAD)163)), 1992f, true).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.DDNMMPIJLNK));
		try
		{
			if (null != this.LOJHEKCOFME && this.IEILALNLAFO)
			{
				AnimationCanvasGroupAlpha component2 = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
				if (null != component2)
				{
					component2.BPCOKLEABJD(true);
					component2.PKEELDKHLHN(true);
				}
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
		IL_244:
		this.IEILALNLAFO = false;
	}

	// Token: 0x06005065 RID: 20581 RVA: 0x002372C4 File Offset: 0x002354C4
	private void CFABGJOONAM()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(21);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005066 RID: 20582 RVA: 0x002372E8 File Offset: 0x002354E8
	private void FCBCCJGFLFA(ChoicePremiumManager HODBFLABJOF, int NBGCCMJAJKB)
	{
		try
		{
			if (!(null == HODBFLABJOF))
			{
				int num = this.IMPAHLIGELE.JMNMOHIKHLB.AIHCGKNBKPK(NBGCCMJAJKB);
				string text = this.IMPAHLIGELE.JMNMOHIKHLB.PGIMLCDEEPP(NBGCCMJAJKB);
				if (num == 3)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.FMDLIOFDIPH(NBGCCMJAJKB))
					{
						HODBFLABJOF.SetCustomCostDisplay(KBOJLHAJPCP.GOEIBHCAJLM, this.FLLHNIIJOLP, false);
					}
					else if (ChoiceExtendedManager.BIFDMNMMLIB(text))
					{
						HODBFLABJOF.SetCustomCostDisplay(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfree") + KBOJLHAJPCP.GOEIBHCAJLM, this.FLLHNIIJOLP, false);
					}
					else
					{
						string shopLocalizedPrice = ChoiceExtendedManager.GetShopLocalizedPrice(text);
						if (shopLocalizedPrice.Length == 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("ChoiceExtendedManager - IAP shop look without a resolvable price (sku:" + text + "), cost hidden");
							HODBFLABJOF.SetCustomCostDisplay("", this.FLLHNIIJOLP, false);
						}
						else
						{
							HODBFLABJOF.SetCustomCostDisplay(shopLocalizedPrice + KBOJLHAJPCP.GOEIBHCAJLM, this.FLLHNIIJOLP, false);
						}
					}
				}
				else if (num >= 0 && num <= 2)
				{
					string text2 = KBOJLHAJPCP.DBCAFJGPECE;
					if (num == 1)
					{
						text2 = KBOJLHAJPCP.DGMDEJKHKFL;
					}
					else if (num == 2)
					{
						text2 = KBOJLHAJPCP.KMEBHIBPPJC;
					}
					string text3 = this.IMPAHLIGELE.JMNMOHIKHLB.IPJAPHIADEP(NBGCCMJAJKB);
					bool flag = this.IMPAHLIGELE.JMNMOHIKHLB.FMDLIOFDIPH(NBGCCMJAJKB);
					if (text3.Length > 0)
					{
						if (flag || ChoiceExtendedManager.GetShopLocalizedPrice(text3).Length > 0)
						{
							text2 = ChoiceExtendedManager.GDJBPHPFBIN(num);
						}
						else
						{
							DPGJIJGOCIC.ADFCDFHBDAF("ChoiceExtendedManager - dual-payment look without a resolvable store price (sku:" + text3 + "), currency price only");
						}
					}
					if (flag)
					{
						HODBFLABJOF.SetCustomCostDisplay(text2, this.FLLHNIIJOLP, false);
					}
					else if (text3.Length > 0 && ChoiceExtendedManager.BIFDMNMMLIB(text3))
					{
						HODBFLABJOF.SetCustomCostDisplay(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("skinshopfree") + KBOJLHAJPCP.GOEIBHCAJLM, this.FLLHNIIJOLP, false);
					}
					else
					{
						int num2 = -1;
						if (!int.TryParse(text, out num2) || num2 < 0)
						{
							DPGJIJGOCIC.ADFCDFHBDAF("ChoiceExtendedManager - special-currency shop look without a price (ref:" + text + "), cost hidden");
							HODBFLABJOF.SetCustomCostDisplay("", this.FLLHNIIJOLP, false);
						}
						else
						{
							HODBFLABJOF.SetCustomCostDisplay(num2.ToString() + text2, this.FLLHNIIJOLP, false);
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

	// Token: 0x06005067 RID: 20583 RVA: 0x0023753C File Offset: 0x0023573C
	private void MJKFFGNMFHA()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("$INCSTAT", 1510f);
	}

	// Token: 0x06005068 RID: 20584 RVA: 0x00237560 File Offset: 0x00235760
	private void KCFHNKOPDBL(bool NINGMOLOCBB)
	{
		if (null == this.FPOGOGNGDLE)
		{
			return;
		}
		if (NINGMOLOCBB && null != this.OMHKHHFGEHO)
		{
			ChoiceExtendedManager.DDPPBFBFMLP ddppbfbfmlp = new ChoiceExtendedManager.DDPPBFBFMLP();
			ddppbfbfmlp.fadingObject = this.FPOGOGNGDLE;
			CanvasGroup omhkhhfgeho = this.OMHKHHFGEHO;
			this.FPOGOGNGDLE = null;
			this.OMHKHHFGEHO = null;
			omhkhhfgeho.DOKill(false);
			omhkhhfgeho.DOFade(0f, 0.25f).OnComplete(new TweenCallback(ddppbfbfmlp.BIIFGFCDGOF));
			return;
		}
		this.NLEOIGECPED();
	}

	// Token: 0x06005069 RID: 20585 RVA: 0x002375E3 File Offset: 0x002357E3
	private void KAEEDLNMEEF()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-45);
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("avind", 948f);
	}

	// Token: 0x0600506A RID: 20586 RVA: 0x00237606 File Offset: 0x00235806
	private void GMPJMMMIGLO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600506B RID: 20587 RVA: 0x00237628 File Offset: 0x00235828
	private bool COMKMNJDMGE()
	{
		return this.GMMCDODLDBK() || (null != this.slidingPanelButtonHide && this.slidingPanelButtonHide.gameObject.activeSelf && this.slidingPanelButtonHide.interactable);
	}

	// Token: 0x0600506C RID: 20588 RVA: 0x00237661 File Offset: 0x00235861
	private IEnumerator AJKLIACJNAD(float BICHMDEIFKI)
	{
		this.OPLDMEEFKDO(false);
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.item || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.cue)
		{
			this.IIFKDKNJJDO.SetDirection(true);
			this.IIFKDKNJJDO.PlayAnimation(false);
		}
		this.DCKJHLJKGOL.SetDirection(true);
		this.DCKJHLJKGOL.PlayAnimation();
		yield break;
	}

	// Token: 0x0600506D RID: 20589 RVA: 0x00237677 File Offset: 0x00235877
	private void KODNKKFCCFM()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-12);
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("gfts", 1770f);
	}

	// Token: 0x0600506E RID: 20590 RVA: 0x0023769A File Offset: 0x0023589A
	private void CDMENACGDAG()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(10);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600506F RID: 20591 RVA: 0x002376BD File Offset: 0x002358BD
	private bool JMLGHILGDGM(string KHJMANDEDMA)
	{
		return KHJMANDEDMA.ToLower().Equals("), skipped: a saveSync is already queued");
	}

	// Token: 0x06005070 RID: 20592 RVA: 0x002376D4 File Offset: 0x002358D4
	private void HHPNJJPFGPN(bool BJEENNHMKFA)
	{
		try
		{
			if (!this.DKDGAHBBKFF && !this.APJJJGEEIBN)
			{
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa2 = null;
				if (this.PKKHHJFMFBK.Count > 0)
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa3 = this.GMOGLALJAOP[this.PKKHHJFMFBK.Count - 1];
					if (ahlneabnmoa3 != null && null != ahlneabnmoa3.AJDMCHIOJAK && ahlneabnmoa3.AJDMCHIOJAK.alpha > 0.99f)
					{
						ahlneabnmoa = ahlneabnmoa3;
					}
				}
				if (this.OHGAKMBALFA.Count > 0)
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa4 = this.CFBLALNJPIA[this.OHGAKMBALFA.Count - 1];
					if (ahlneabnmoa4 != null && null != ahlneabnmoa4.AJDMCHIOJAK && ahlneabnmoa4.AJDMCHIOJAK.alpha > 0.99f)
					{
						ahlneabnmoa2 = ahlneabnmoa4;
					}
				}
				if (ahlneabnmoa == null || ahlneabnmoa2 == null)
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa5 = ahlneabnmoa;
					if (ahlneabnmoa5 == null)
					{
						ahlneabnmoa5 = ahlneabnmoa2;
					}
					if (ahlneabnmoa5 != null)
					{
						AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.ONMBOOEBFIB();
						if (null != assetCustomEffects)
						{
							DHGFCJGJFOB.IDNJIDPNFAE(ahlneabnmoa5, assetCustomEffects, BJEENNHMKFA);
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

	// Token: 0x06005071 RID: 20593 RVA: 0x002377E4 File Offset: 0x002359E4
	private bool HACMNFIGBFG(int NBGCCMJAJKB)
	{
		return NBGCCMJAJKB < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[NBGCCMJAJKB] > 0;
	}

	// Token: 0x06005072 RID: 20594 RVA: 0x0023781A File Offset: 0x00235A1A
	public void HidePanel()
	{
		this.IEILALNLAFO = true;
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnTryToFireNoteshowTimer", 0f);
		this.OPLDMEEFKDO(false);
	}

	// Token: 0x06005073 RID: 20595 RVA: 0x0023783E File Offset: 0x00235A3E
	private void CCAKILNJENF()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-83);
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("no", 1575f);
	}

	// Token: 0x06005074 RID: 20596 RVA: 0x00237861 File Offset: 0x00235A61
	private void JAFHHADBLED()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-97);
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess", 712f);
	}

	// Token: 0x06005075 RID: 20597 RVA: 0x00237884 File Offset: 0x00235A84
	private void CDHHGBKGGDG()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06005076 RID: 20598 RVA: 0x002378DB File Offset: 0x00235ADB
	private void GEADEEKJOHO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-127);
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("id", 1864f);
	}

	// Token: 0x06005077 RID: 20599 RVA: 0x00237900 File Offset: 0x00235B00
	private bool ONJJIPDEECM(int NBGCCMJAJKB)
	{
		int num = this.IMPAHLIGELE.JMNMOHIKHLB.AIHCGKNBKPK(NBGCCMJAJKB);
		return num == 3 || (num >= 0 && num <= 2);
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x0023620C File Offset: 0x0023440C
	private IEnumerator MKJBNOCAOKG(ParticleSystem MCPHAAJFBEH, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		MCPHAAJFBEH.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		yield break;
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x00237932 File Offset: 0x00235B32
	public void SetLoungeSingleLookTitleExpand(float NKLGHPLONLL)
	{
		this.FCNIIOBIIFP = NKLGHPLONLL;
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x0023793C File Offset: 0x00235B3C
	private bool DBFJFPCKOIJ(CharacterRenderTexturePool.AHLNEABNMOA IGBMMAHEIEK, int FJHJKKIBHBD)
	{
		bool result;
		try
		{
			this.JKCAMKMBEEH = 1f;
			if (IGBMMAHEIEK == null)
			{
				result = false;
			}
			else
			{
				string nflfjfkiola = "";
				if (this.IMPAHLIGELE != null && this.IMPAHLIGELE.JMNMOHIKHLB != null)
				{
					nflfjfkiola = this.IMPAHLIGELE.JMNMOHIKHLB.DCOBPBAJOAA;
				}
				AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.FDABGEGNDFO(nflfjfkiola);
				if (null == assetCustomEffects)
				{
					result = false;
				}
				else
				{
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
					CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa2 = null;
					if (this.PKKHHJFMFBK.Count > 0)
					{
						CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa3 = this.GMOGLALJAOP[this.PKKHHJFMFBK.Count - 1];
						if (ahlneabnmoa3 != null && ahlneabnmoa3 != IGBMMAHEIEK && null != ahlneabnmoa3.AJDMCHIOJAK && ahlneabnmoa3.AJDMCHIOJAK.alpha > 0.99f)
						{
							ahlneabnmoa = ahlneabnmoa3;
						}
					}
					if (this.OHGAKMBALFA.Count > 0)
					{
						CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa4 = this.CFBLALNJPIA[this.OHGAKMBALFA.Count - 1];
						if (ahlneabnmoa4 != null && ahlneabnmoa4 != IGBMMAHEIEK && null != ahlneabnmoa4.AJDMCHIOJAK && ahlneabnmoa4.AJDMCHIOJAK.alpha > 0.99f)
						{
							ahlneabnmoa2 = ahlneabnmoa4;
						}
					}
					if (ahlneabnmoa != null && ahlneabnmoa2 != null)
					{
						result = false;
					}
					else
					{
						float bjopegbaejf = DHGFCJGJFOB.BCIIGJGCAFA(assetCustomEffects);
						if (ahlneabnmoa != null)
						{
							if (DHGFCJGJFOB.DCJIOGJAACI(ahlneabnmoa, IGBMMAHEIEK, assetCustomEffects, FJHJKKIBHBD, new TweenCallback(this.MFINPJIGCBH)))
							{
								this.DKDGAHBBKFF = true;
								this.BJOPEGBAEJF = bjopegbaejf;
								this.JKCAMKMBEEH = Mathf.Max(assetCustomEffects.animationScaleImpact, 0f);
								result = true;
							}
							else
							{
								result = false;
							}
						}
						else if (ahlneabnmoa2 != null)
						{
							if (DHGFCJGJFOB.DCJIOGJAACI(ahlneabnmoa2, IGBMMAHEIEK, assetCustomEffects, FJHJKKIBHBD, new TweenCallback(this.KLOLAHCAKDD)))
							{
								this.APJJJGEEIBN = true;
								this.BJOPEGBAEJF = bjopegbaejf;
								this.JKCAMKMBEEH = Mathf.Max(assetCustomEffects.animationScaleImpact, 0f);
								result = true;
							}
							else
							{
								result = false;
							}
						}
						else
						{
							result = false;
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x00237B28 File Offset: 0x00235D28
	private CanvasGroup GJPLHFLJIDA(int MEFKFOHCOHK)
	{
		if (this.CFBLALNJPIA[MEFKFOHCOHK] != null)
		{
			return this.CFBLALNJPIA[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.OHGAKMBALFA[MEFKFOHCOHK])
		{
			return null;
		}
		return this.OHGAKMBALFA[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x00237B7C File Offset: 0x00235D7C
	private void ANLHHMBINOJ()
	{
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(false);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(false);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x00237C40 File Offset: 0x00235E40
	private bool KEKHCAPNKCN(int NBGCCMJAJKB)
	{
		int num = this.IMPAHLIGELE.JMNMOHIKHLB.AIHCGKNBKPK(NBGCCMJAJKB);
		if (num == 3)
		{
			return true;
		}
		if (num < 0 || num > 2)
		{
			return false;
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.FMDLIOFDIPH(NBGCCMJAJKB))
		{
			return true;
		}
		int num2 = -1;
		return !int.TryParse(this.IMPAHLIGELE.JMNMOHIKHLB.PGIMLCDEEPP(NBGCCMJAJKB), out num2) || num2 != 0;
	}

	// Token: 0x0600507E RID: 20606 RVA: 0x00237CA6 File Offset: 0x00235EA6
	private void KLBBBDNLHFB()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(19);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x00237CCC File Offset: 0x00235ECC
	private void OGBHEBHMGGH()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x00237D24 File Offset: 0x00235F24
	private void IGAJLALPOJF(CharacterRenderTexturePool.AHLNEABNMOA MJHGPLDAPCN, bool BMKLNILMGAG, int FJHJKKIBHBD, DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG)
	{
		GameObject gameObject;
		PlayerCharacterManager playerCharacterManager;
		CanvasGroup canvasGroup;
		if (MJHGPLDAPCN != null)
		{
			gameObject = MJHGPLDAPCN.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleLeft);
			playerCharacterManager = MJHGPLDAPCN.GOAEECPPHIB;
			playerCharacterManager.LPIKCMJLDFP(EEPJKGBBBHC, AIAAMALDKHG, MJHGPLDAPCN.AJDMCHIOJAK);
			canvasGroup = MJHGPLDAPCN.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
			gameObject.transform.SetParent(this.characterPivot.transform, true);
			playerCharacterManager = gameObject.GetComponent<PlayerCharacterManager>();
			playerCharacterManager.LPIKCMJLDFP(EEPJKGBBBHC, AIAAMALDKHG, null);
			canvasGroup = playerCharacterManager.GetComponent<CanvasGroup>();
		}
		try
		{
			if (this.IMPAHLIGELE != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains(""))
			{
				playerCharacterManager.NPEKLBODNJH();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (BMKLNILMGAG)
		{
			bool flag = this.DBFJFPCKOIJ(MJHGPLDAPCN, FJHJKKIBHBD);
			float duration = 1240f;
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.PKKHHJFMFBK.Count > 1)
			{
				CanvasGroup canvasGroup2 = this.DOINKGBILKD(this.PKKHHJFMFBK.Count - 1);
				PlayerCharacterManager playerCharacterManager2 = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup2 && null != playerCharacterManager2)
				{
					if (!flag)
					{
						this.DKDGAHBBKFF = false;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(945f, 1210f).OnComplete(new TweenCallback(this.MFINPJIGCBH));
						playerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(1556f, 275f) * (float)FJHJKKIBHBD, 1937f, true).SetEase(Ease.InOutQuad);
					}
					playerCharacterManager2.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ANDKHDPFAIJ(playerCharacterManager2.ICJDECOGCGF(), this.JKCAMKMBEEH), duration).SetEase(Ease.InSine);
				}
			}
			if (this.OHGAKMBALFA.Count > 1)
			{
				CanvasGroup canvasGroup3 = this.GJPLHFLJIDA(this.OHGAKMBALFA.Count - 0);
				NonPlayerCharacterManager nonPlayerCharacterManager = this.OHGAKMBALFA[this.OHGAKMBALFA.Count - 1];
				if (null != canvasGroup3 && null != nonPlayerCharacterManager)
				{
					if (!flag)
					{
						canvasGroup3.DOKill(true);
						canvasGroup3.DOFade(117f, 1569f).OnComplete(new TweenCallback(this.KLOLAHCAKDD));
						nonPlayerCharacterManager.GetComponent<RectTransform>().DOAnchorPos(nonPlayerCharacterManager.GetComponent<RectTransform>().anchoredPosition + new Vector2(53f, 915f) * (float)FJHJKKIBHBD, 302f, true).SetEase(Ease.OutSine);
					}
					nonPlayerCharacterManager.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ANDKHDPFAIJ(nonPlayerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH), duration).SetEase(Ease.Unset);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(913f, 1448f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(875f, 1296f) * (float)FJHJKKIBHBD, duration, false).SetEase(Ease.Unset);
			float num = DHGFCJGJFOB.DKFKBOKPDEC(playerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(num, num, num);
			gameObject.GetComponent<RectTransform>().DOScale(3f, duration).SetEase(Ease.InSine);
			if (!flag)
			{
				canvasGroup.alpha = 1994f;
				canvasGroup.DOFade(1980f, 367f).SetEase(Ease.InOutSine);
			}
		}
		else
		{
			canvasGroup.alpha = 1918f;
		}
		this.PKKHHJFMFBK.Add(playerCharacterManager);
		this.GMOGLALJAOP.Add(MJHGPLDAPCN);
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x00238100 File Offset: 0x00236300
	private void BANNCCOOCOK()
	{
		if (!this.PEGBIHCIKAO || null == this.LOJHEKCOFME)
		{
			return;
		}
		try
		{
			int viewedRemappedChoiceIndex = this.GetViewedRemappedChoiceIndex();
			bool flag = viewedRemappedChoiceIndex < 0 || !this.HACMNFIGBFG(viewedRemappedChoiceIndex) || !this.LJKGCDAGKDI.Contains(viewedRemappedChoiceIndex);
			if (((viewedRemappedChoiceIndex >= 0) ? this.IMPAHLIGELE.JMNMOHIKHLB.HHLAFICPJLF(viewedRemappedChoiceIndex) : -1) >= 1)
			{
				flag = true;
			}
			if (flag && viewedRemappedChoiceIndex < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count && SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[viewedRemappedChoiceIndex], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
			{
				flag = true;
			}
			if (flag && !this.LOJHEKCOFME.activeSelf)
			{
				AnimationCanvasGroupAlpha component = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
				if (null != component)
				{
					component.delayAtStart = 496f;
				}
			}
			this.LOJHEKCOFME.SetActive(flag);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x00238218 File Offset: 0x00236418
	private void APJGNJEAOOE()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x0023823A File Offset: 0x0023643A
	private void MHPFIKABAIH()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("Loaded asset bundle:", 1358f);
	}

	// Token: 0x06005084 RID: 20612 RVA: 0x0023825C File Offset: 0x0023645C
	private void NMIJIAKNBCC()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-92);
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("overlay", 389f);
	}

	// Token: 0x06005085 RID: 20613 RVA: 0x00238280 File Offset: 0x00236480
	private void GNOOJHLPJNC(GameObject AFGGHKMOBCJ)
	{
		try
		{
			if (!(null == AFGGHKMOBCJ))
			{
				Sprite sprite = this.NHADDEPNEON;
				Sprite sprite2 = this.MONFLBMAKCM;
				if ((null == sprite || null == sprite2) && null != this.choicePremiumPrefab)
				{
					Image component = this.choicePremiumPrefab.GetComponent<Image>();
					Button component2 = this.choicePremiumPrefab.GetComponent<Button>();
					if (null == sprite && null != component)
					{
						sprite = component.sprite;
					}
					if (null == sprite2 && null != component2)
					{
						sprite2 = component2.spriteState.pressedSprite;
					}
				}
				if (null == sprite)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("ChoiceExtendedManager - no shop button sprite (scene or ChoicePremium prefab), premium art kept");
				}
				else
				{
					Image component3 = AFGGHKMOBCJ.GetComponent<Image>();
					if (null != component3)
					{
						component3.sprite = sprite;
						component3.type = Image.Type.Sliced;
					}
					Button component4 = AFGGHKMOBCJ.GetComponent<Button>();
					if (null != component4)
					{
						SpriteState spriteState = component4.spriteState;
						spriteState.highlightedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.pressedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.selectedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.disabledSprite = null;
						component4.transition = Selectable.Transition.SpriteSwap;
						component4.spriteState = spriteState;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005086 RID: 20614 RVA: 0x002383E8 File Offset: 0x002365E8
	public void CDBNALOMEPD(int GMHPANAHEPM)
	{
		this.IFKHBKGIHIN = GMHPANAHEPM;
	}

	// Token: 0x06005087 RID: 20615 RVA: 0x00237018 File Offset: 0x00235218
	public void SetSwipeToBrowseHostGate(Func<bool> HAEEEIFEPFA)
	{
		this.ENEKOHNJNJL = HAEEEIFEPFA;
	}

	// Token: 0x06005088 RID: 20616 RVA: 0x002383F4 File Offset: 0x002365F4
	public bool Initialize(LHBFJJIJNMI JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB, CustomWardrobeSettings FHIBKDHEKEB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.LCOKEPGNEKI = FHIBKDHEKEB;
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return false;
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0 && this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("dynamic"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.AEMELJEDNJH(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
					int num = 0;
					for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.premium)
						{
							num++;
						}
					}
					if (LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeDiamonds, -1, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ) || num > KBOJLHAJPCP.MHHMEBPPENC)
					{
						bool flag = false;
						for (int j = 0; j < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; j++)
						{
							if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[j].EKDGAODNDOP() == HKCCMACFNEO.bulk && j == this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count - 1)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							if (num > KBOJLHAJPCP.MHHMEBPPENC)
							{
								DPGJIJGOCIC.ADFCDFHBDAF("ChoiceExtendedManager.Initialize() - disabling bulk choice option as to comply with RSA encryption limits.");
							}
							this.IMPAHLIGELE.IKNCHNAGLMK(1);
							this.IMPAHLIGELE.JMNMOHIKHLB.EFHNKCGGCNF(1);
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB.Count > 0)
		{
			for (int k = 0; k < this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB.Count; k++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.face)
				{
					AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.KGFLNLPJGAL(KFIHMMIGPLO.face, this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB[k]), this.LMKDNPOKOBF.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.LCOKEPGNEKI);
					if (null != assetAvatarComponent)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[k].COOOGACBAKN = assetAvatarComponent.id;
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("ERROR: ChoiceExtendedManager.Initialize() - finalAvatarComponentAsset is null.");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ERROR: ChoiceExtendedManager.Initialize() - step.choiceMeta.choiceType is invalid:" + this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF.ToString());
				}
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int l = 0; l < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; l++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[l].EKDGAODNDOP() == HKCCMACFNEO.bulk)
					{
						for (int m = 0; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
						{
							this.HNGBMIJHPLE.Add(m);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int n = 0; n < 2; n++)
				{
					for (int num2 = 0; num2 < this.IMPAHLIGELE.COEFNFJMBDG.Count; num2++)
					{
						int num3 = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if ((num2 < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[num2] > 0) || this.KEKHCAPNKCN(num2))
							{
								num3 = 1;
							}
							else if (num2 < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[num2] > 0)
							{
								num3 = 2;
							}
						}
						if ((n == 0 && num3 == 1) || (n != 0 && num3 != 1))
						{
							this.HNGBMIJHPLE.Add(num2);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JMNMOHIKHLB.PFLJLFGCIFB();
		try
		{
			sourceText = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.JMNMOHIKHLB.PFLJLFGCIFB());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, true);
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.cue || (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count == 1))
		{
			this.prevButton.gameObject.SetActive(false);
			this.nextButton.gameObject.SetActive(false);
			if (this.FCNIIOBIIFP > 0f && null != this.itemTitle)
			{
				this.itemTitle.rectTransform.sizeDelta = new Vector2(this.itemTitle.rectTransform.sizeDelta.x + 2f * this.FCNIIOBIIFP, this.itemTitle.rectTransform.sizeDelta.y);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			int num4 = 0;
			while (num4 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject = null;
				int num5 = 0;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
				{
					if ((this.HDBBHHBOJIN(num4) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(num4)] > 0) || this.KEKHCAPNKCN(this.HDBBHHBOJIN(num4)))
					{
						num5 = 1;
					}
					else if (this.HDBBHHBOJIN(num4) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(num4)] > 0)
					{
						num5 = 2;
					}
				}
				if (num5 == 2)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject.transform.SetParent(this.choicePivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.HDBBHHBOJIN(num4)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)]].GALKFKBPLCK(), 500);
					gameObject.GetComponent<ChoiceStatManager>().ExtendRightSide();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)])
							{
							case CHEEGEJNIDB.stat0:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
								break;
							case CHEEGEJNIDB.stat1:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
								break;
							case CHEEGEJNIDB.stat2:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
								break;
							case CHEEGEJNIDB.stat3:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
								break;
							case CHEEGEJNIDB.stat4:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
								break;
							case CHEEGEJNIDB.stat5:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
								break;
							case CHEEGEJNIDB.stat6:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
								break;
							}
							this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, false);
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)]].GALKFKBPLCK());
							try
							{
								if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("hidestatinfo"))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm3)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							}
						}
						goto IL_C6B;
					}
					catch (Exception aklgbjkdomm4)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
						goto IL_C6B;
					}
					goto IL_975;
				}
				goto IL_975;
				IL_C6B:
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(num4) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(num4) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(num4) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(num4) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(num4) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(num4) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				else if (this.HDBBHHBOJIN(num4) == 6)
				{
					component.onClick.AddListener(new UnityAction(this.CGOGFBKDCKO));
				}
				else if (this.HDBBHHBOJIN(num4) == 7)
				{
					component.onClick.AddListener(new UnityAction(this.KMKDEDCJMED));
				}
				else if (this.HDBBHHBOJIN(num4) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.APJGNJEAOOE));
				}
				else if (this.HDBBHHBOJIN(num4) == 9)
				{
					component.onClick.AddListener(new UnityAction(this.JADKDCKAPAD));
				}
				else if (this.HDBBHHBOJIN(num4) == 10)
				{
					component.onClick.AddListener(new UnityAction(this.CDMENACGDAG));
				}
				else if (this.HDBBHHBOJIN(num4) == 11)
				{
					component.onClick.AddListener(new UnityAction(this.ADCKLJPMFOD));
				}
				else if (this.HDBBHHBOJIN(num4) == 12)
				{
					component.onClick.AddListener(new UnityAction(this.NMIOLDBOOHJ));
				}
				else if (this.HDBBHHBOJIN(num4) == 13)
				{
					component.onClick.AddListener(new UnityAction(this.HEMEGEBEAIE));
				}
				else if (this.HDBBHHBOJIN(num4) == 14)
				{
					component.onClick.AddListener(new UnityAction(this.DMBINGFILDA));
				}
				else if (this.HDBBHHBOJIN(num4) == 15)
				{
					component.onClick.AddListener(new UnityAction(this.DMFJEODPAOJ));
				}
				else if (this.HDBBHHBOJIN(num4) == 16)
				{
					component.onClick.AddListener(new UnityAction(this.FIPOOIEOOLC));
				}
				else if (this.HDBBHHBOJIN(num4) == 17)
				{
					component.onClick.AddListener(new UnityAction(this.JPBGDDDOCEK));
				}
				else if (this.HDBBHHBOJIN(num4) == 18)
				{
					component.onClick.AddListener(new UnityAction(this.BHKPPNPNMGP));
				}
				else if (this.HDBBHHBOJIN(num4) == 19)
				{
					component.onClick.AddListener(new UnityAction(this.KLBBBDNLHFB));
				}
				else if (this.HDBBHHBOJIN(num4) == 20)
				{
					component.onClick.AddListener(new UnityAction(this.IBEAPGIBIPN));
				}
				else if (this.HDBBHHBOJIN(num4) == 21)
				{
					component.onClick.AddListener(new UnityAction(this.CFABGJOONAM));
				}
				else if (this.HDBBHHBOJIN(num4) == 22)
				{
					component.onClick.AddListener(new UnityAction(this.EIBHLKBNLII));
				}
				else if (this.HDBBHHBOJIN(num4) == 23)
				{
					component.onClick.AddListener(new UnityAction(this.JGJCDDANFIB));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ChoiceExtendedManager - choice index " + this.HDBBHHBOJIN(num4).ToString() + " exceeds the wired click listeners (0..23), the option will NOT respond");
				}
				gameObject.SetActive(false);
				this.AKFKCKHPIOA.Add(gameObject);
				num4++;
				continue;
				IL_975:
				if (num5 == 1)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicePivot.transform, false);
					if (this.BLBHCDOKDFC && this.ONJJIPDEECM(this.HDBBHHBOJIN(num4)))
					{
						this.GNOOJHLPJNC(gameObject);
					}
					if ((this.KEKHCAPNKCN(this.HDBBHHBOJIN(num4)) && this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)].EKDGAODNDOP() == HKCCMACFNEO.free) || SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], 0, 500, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(num4), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						}
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(num4)], 500, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(this.HDBBHHBOJIN(num4), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.FCBCCJGFLFA(gameObject.GetComponent<ChoicePremiumManager>(), this.HDBBHHBOJIN(num4));
					goto IL_C6B;
				}
				gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject.transform.SetParent(this.choicePivot.transform, false);
				gameObject.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], 500);
				goto IL_C6B;
			}
		}
		if (this.IFKHBKGIHIN >= 0)
		{
			for (int num6 = 0; num6 < this.HNGBMIJHPLE.Count; num6++)
			{
				if (this.HNGBMIJHPLE[num6] == this.IFKHBKGIHIN)
				{
					this.IILHFLJICJA = num6;
					break;
				}
			}
			this.IFKHBKGIHIN = -1;
		}
		this.FJFKBNKBHHM(this.IILHFLJICJA, true, 1);
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x06005089 RID: 20617 RVA: 0x00239558 File Offset: 0x00237758
	private CanvasGroup OBJOMBPDFOP(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x0600508A RID: 20618 RVA: 0x002395AC File Offset: 0x002377AC
	private void MJFIKHGDHMI()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(101);
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("narrator", 1073f);
	}

	// Token: 0x0600508B RID: 20619 RVA: 0x002395CF File Offset: 0x002377CF
	public void ShowPanel()
	{
		this.IEILALNLAFO = true;
		this.OPLDMEEFKDO(true);
	}

	// Token: 0x0600508C RID: 20620 RVA: 0x002395DF File Offset: 0x002377DF
	private void HCCIFINAELG()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.DBLAIDPICIG().KMAGHMCCMPG("wofcoic", 1386f);
	}

	// Token: 0x0600508D RID: 20621 RVA: 0x00239601 File Offset: 0x00237801
	private void JPBGDDDOCEK()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(17);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600508E RID: 20622 RVA: 0x00239624 File Offset: 0x00237824
	private void KLOLAHCAKDD()
	{
		this.APJJJGEEIBN = false;
		for (int i = 0; i < this.OHGAKMBALFA.Count; i++)
		{
			if (this.CFBLALNJPIA[i] != null)
			{
				if (null != this.CFBLALNJPIA[i].AJDMCHIOJAK && this.CFBLALNJPIA[i].AJDMCHIOJAK.alpha < 0.01f && !DOTween.IsTweening(this.CFBLALNJPIA[i].AJDMCHIOJAK, true))
				{
					this.ACPGAGCKGBJ(i);
				}
			}
			else if (null != this.OHGAKMBALFA[i] && this.OHGAKMBALFA[i].gameObject.activeSelf && this.OHGAKMBALFA[i].GetComponent<CanvasGroup>().alpha < 0.01f && !DOTween.IsTweening(this.OHGAKMBALFA[i].GetComponent<CanvasGroup>(), true))
			{
				this.OHGAKMBALFA[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x0600508F RID: 20623 RVA: 0x0023973C File Offset: 0x0023793C
	private void IDNANEBJACO(int MEFKFOHCOHK)
	{
		if (null != this.EBHJLLIHIFE && this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			this.EBHJLLIHIFE.ReleaseSlot(this.GMOGLALJAOP[MEFKFOHCOHK]);
		}
		this.GMOGLALJAOP[MEFKFOHCOHK] = null;
		this.PKKHHJFMFBK[MEFKFOHCOHK] = null;
	}

	// Token: 0x06005090 RID: 20624 RVA: 0x00239798 File Offset: 0x00237998
	private void ALKBENHJEPC()
	{
		this.NHJGHNEHDEM = true;
		this.CDIFMMOJDHA = false;
		this.KCFHNKOPDBL(true);
		if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("sparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("sparkles", false);
			}
			this.premiumParticles.GetComponent<AnimationScale>().PlayAnimation();
			this.premiumParticles.Play();
			this.HHPNJJPFGPN(true);
			base.StartCoroutine(this.AJKLIACJNAD(2f));
		}
		else
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("sparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("sparkles", false);
			}
			this.standardParticles.GetComponent<AnimationScale>().PlayAnimation();
			this.standardParticles.Play();
			this.HHPNJJPFGPN(false);
			base.StartCoroutine(this.AJKLIACJNAD(0f));
		}
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "+" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x002399E0 File Offset: 0x00237BE0
	public void BBOJIIFKBCH()
	{
		this.IEILALNLAFO = false;
		AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("", 1950f);
		this.DFNHKANOEKJ(true);
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x00239A04 File Offset: 0x00237C04
	private void INBKOHDEAFF()
	{
		this.NHJGHNEHDEM = true;
		this.CDIFMMOJDHA = false;
		this.NCIAHHBCHEA(true);
		if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			if (!AudioManager.BFCHJBOOJKE().PlaySfx("ok", false) && !AudioManager.IFDLAMLHKIJ().PlaySfx("USD ", true) && !AudioManager.APGODIBBPOD().PlaySfx("rewindtitle0" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.APGODIBBPOD().PlaySfx("lacr", false);
			}
			this.premiumParticles.GetComponent<AnimationScale>().PlayAnimation();
			this.premiumParticles.Play();
			this.HHPNJJPFGPN(true);
			base.StartCoroutine(this.GBILAMMCKHA(18f));
		}
		else
		{
			if (!AudioManager.APGODIBBPOD().PlaySfx("did", false) && !AudioManager.BFCHJBOOJKE().PlaySfx("\\b", false) && !AudioManager.BFCHJBOOJKE().PlaySfx("season" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), true))
			{
				AudioManager.DMAAFFFEJGA().PlaySfx("amfc", false);
			}
			this.standardParticles.GetComponent<AnimationScale>().JJNBJPCALPG();
			this.standardParticles.Play();
			this.HHPNJJPFGPN(true);
			base.StartCoroutine(this.GBILAMMCKHA(1357f));
		}
		try
		{
			if (this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JMNMOHIKHLB.NDPPILBPOGB + "cat" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005093 RID: 20627 RVA: 0x00239C4C File Offset: 0x00237E4C
	public void PlayLoungeChoiceConfirmedEffects(bool BJEENNHMKFA)
	{
		if (Time.unscaledTime - this.MMCDNLDCDFC < 0.5f)
		{
			return;
		}
		this.MMCDNLDCDFC = Time.unscaledTime;
		try
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("sparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("sparkles", false);
			}
			if (BJEENNHMKFA)
			{
				this.premiumParticles.GetComponent<AnimationScale>().PlayAnimation();
				this.premiumParticles.Play();
				base.StartCoroutine(this.MKJBNOCAOKG(this.premiumParticles, 2f));
			}
			else
			{
				this.standardParticles.GetComponent<AnimationScale>().PlayAnimation();
				this.standardParticles.Play();
				base.StartCoroutine(this.MKJBNOCAOKG(this.standardParticles, 2f));
			}
			if (!this.APJJJGEEIBN && this.OHGAKMBALFA.Count > 0)
			{
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.CFBLALNJPIA[this.OHGAKMBALFA.Count - 1];
				if (ahlneabnmoa != null)
				{
					AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.ONMBOOEBFIB();
					if (null != assetCustomEffects)
					{
						DHGFCJGJFOB.IDNJIDPNFAE(ahlneabnmoa, assetCustomEffects, BJEENNHMKFA);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005094 RID: 20628 RVA: 0x00239DB4 File Offset: 0x00237FB4
	private void OMLDAIBLJIC(GameObject ABBLKKOJAFJ, AssetStoryItem FHFAPLPBKOD, bool BMKLNILMGAG, int FJHJKKIBHBD, bool MOMCFCNKEJA = false)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(ABBLKKOJAFJ);
		gameObject.transform.SetParent(this.storyItemPivot.transform, false);
		StoryItemManager component = gameObject.GetComponent<StoryItemManager>();
		component.Initialize(FHFAPLPBKOD, MOMCFCNKEJA);
		if (BMKLNILMGAG)
		{
			if (this.EMLIDDHGCBE.Count > 0)
			{
				this.KJNJBKCMAGA = true;
				this.EMLIDDHGCBE[this.EMLIDDHGCBE.Count - 1].GetComponent<CanvasGroup>().DOKill(false);
				this.EMLIDDHGCBE[this.EMLIDDHGCBE.Count - 1].GetComponent<CanvasGroup>().DOFade(0f, 0.4f).OnComplete(new TweenCallback(this.FOHEELHDHBF));
				this.EMLIDDHGCBE[this.EMLIDDHGCBE.Count - 1].GetComponent<RectTransform>().DOScale(0.97f, 0.4f).SetEase(Ease.OutQuad);
				this.EMLIDDHGCBE[this.EMLIDDHGCBE.Count - 1].GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(-50f, 0f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(0.97f, 0.97f, 0.97f);
			gameObject.GetComponent<RectTransform>().DOScale(1f, 0.4f).SetEase(Ease.OutQuad);
			component.GetComponent<CanvasGroup>().alpha = 0f;
			component.GetComponent<CanvasGroup>().DOFade(1f, 0.4f).SetEase(Ease.OutQuad);
		}
		this.EMLIDDHGCBE.Add(component);
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x00239FCC File Offset: 0x002381CC
	private CharacterRenderTexturePool.AHLNEABNMOA OELALBBMILL(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.GetOrCreate();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.AcquirePlayerCharacter(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x0023A040 File Offset: 0x00238240
	private void MKIHBJDNCPP()
	{
		if (!this.PEGBIHCIKAO || null == this.LOJHEKCOFME)
		{
			return;
		}
		try
		{
			int viewedRemappedChoiceIndex = this.GetViewedRemappedChoiceIndex();
			bool flag = viewedRemappedChoiceIndex >= 0 && this.HACMNFIGBFG(viewedRemappedChoiceIndex) && !this.LJKGCDAGKDI.Contains(viewedRemappedChoiceIndex);
			if (((viewedRemappedChoiceIndex >= 0) ? this.IMPAHLIGELE.JMNMOHIKHLB.AIHCGKNBKPK(viewedRemappedChoiceIndex) : -1) >= 0)
			{
				flag = false;
			}
			if (flag && viewedRemappedChoiceIndex < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count && SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[viewedRemappedChoiceIndex], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
			{
				flag = false;
			}
			if (flag && !this.LOJHEKCOFME.activeSelf)
			{
				AnimationCanvasGroupAlpha component = this.LOJHEKCOFME.GetComponent<AnimationCanvasGroupAlpha>();
				if (null != component)
				{
					component.delayAtStart = 0f;
				}
			}
			this.LOJHEKCOFME.SetActive(flag);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005097 RID: 20631 RVA: 0x0023A158 File Offset: 0x00238358
	private void NCIAHHBCHEA(bool NINGMOLOCBB)
	{
		if (null == this.FPOGOGNGDLE)
		{
			return;
		}
		if (NINGMOLOCBB && null != this.OMHKHHFGEHO)
		{
			ChoiceExtendedManager.DDPPBFBFMLP ddppbfbfmlp = new ChoiceExtendedManager.DDPPBFBFMLP();
			ddppbfbfmlp.fadingObject = this.FPOGOGNGDLE;
			CanvasGroup omhkhhfgeho = this.OMHKHHFGEHO;
			this.FPOGOGNGDLE = null;
			this.OMHKHHFGEHO = null;
			omhkhhfgeho.DOKill(true);
			omhkhhfgeho.DOFade(1793f, 475f).OnComplete(new TweenCallback(ddppbfbfmlp.BIIFGFCDGOF));
			return;
		}
		this.NLEOIGECPED();
	}

	// Token: 0x06005098 RID: 20632 RVA: 0x0023A1DB File Offset: 0x002383DB
	private void FKLCKMHIEGM()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(-98);
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK("OnSkinShopClose", 1689f);
	}

	// Token: 0x06005099 RID: 20633 RVA: 0x0023A200 File Offset: 0x00238400
	private void PILCIDIJADK()
	{
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				this.IDNANEBJACO(i);
			}
			else if (null != this.PKKHHJFMFBK[i])
			{
				this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().DOKill(true);
				this.PKKHHJFMFBK[i].GetComponent<RectTransform>().DOKill(false);
				this.PKKHHJFMFBK[i].DOKill(true);
				UnityEngine.Object.Destroy(this.PKKHHJFMFBK[i].gameObject);
			}
		}
		this.PKKHHJFMFBK.Clear();
		this.GMOGLALJAOP.Clear();
	}

	// Token: 0x0600509A RID: 20634 RVA: 0x0023A2C3 File Offset: 0x002384C3
	public void SetLoungeShopButtonSprites(Sprite GOOJKONMPHH, Sprite AMHPIABNEOJ)
	{
		this.BLBHCDOKDFC = true;
		this.NHADDEPNEON = GOOJKONMPHH;
		this.MONFLBMAKCM = AMHPIABNEOJ;
	}

	// Token: 0x0600509C RID: 20636 RVA: 0x0023A3AD File Offset: 0x002385AD
	private void ELKJNBEPBLO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("", 1298f);
	}

	// Token: 0x0600509D RID: 20637 RVA: 0x0023A3D0 File Offset: 0x002385D0
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryScreenChoiceExtendedManagerEnvironmentChangeComplete", new UnityAction(this.CKIDPBFKNPL));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryScreenChoiceExtendedManagerLayerChangeComplete", new UnityAction(this.CBCMMHONIHL));
		this.CDIFMMOJDHA = false;
		this.NLEOIGECPED();
	}

	// Token: 0x0600509E RID: 20638 RVA: 0x0023A43B File Offset: 0x0023863B
	private void CBCMMHONIHL()
	{
		this.MKNCFHPKOBF = false;
	}

	// Token: 0x0600509F RID: 20639 RVA: 0x0023A444 File Offset: 0x00238644
	private void BOGHFJKGCNK()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050A0 RID: 20640 RVA: 0x0023A466 File Offset: 0x00238666
	private void HMHIJLKJGFN()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050A1 RID: 20641 RVA: 0x0023A488 File Offset: 0x00238688
	private void IFAFJAOJEJC(CharacterRenderTexturePool.AHLNEABNMOA MJHGPLDAPCN, bool BMKLNILMGAG, int FJHJKKIBHBD, DOLBFGIPPOG EEPJKGBBBHC, EBFHKCOGJLB AIAAMALDKHG)
	{
		GameObject gameObject;
		PlayerCharacterManager playerCharacterManager;
		CanvasGroup canvasGroup;
		if (MJHGPLDAPCN != null)
		{
			gameObject = MJHGPLDAPCN.JAGHCEBFABP;
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			playerCharacterManager = MJHGPLDAPCN.GOAEECPPHIB;
			playerCharacterManager.InitializeFromSaveData(EEPJKGBBBHC, AIAAMALDKHG, MJHGPLDAPCN.AJDMCHIOJAK);
			canvasGroup = MJHGPLDAPCN.AJDMCHIOJAK;
		}
		else
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
			gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
			gameObject.transform.SetParent(this.characterPivot.transform, false);
			playerCharacterManager = gameObject.GetComponent<PlayerCharacterManager>();
			playerCharacterManager.InitializeFromSaveData(EEPJKGBBBHC, AIAAMALDKHG, null);
			canvasGroup = playerCharacterManager.GetComponent<CanvasGroup>();
		}
		try
		{
			if (this.IMPAHLIGELE != null && this.IMPAHLIGELE.JMNMOHIKHLB != null && this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("playavatarframesonce"))
			{
				playerCharacterManager.PlayAvatarFramesOnce();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (BMKLNILMGAG)
		{
			bool flag = this.DBFJFPCKOIJ(MJHGPLDAPCN, FJHJKKIBHBD);
			float duration = 0.4f;
			if (flag)
			{
				duration = this.BJOPEGBAEJF;
			}
			if (this.PKKHHJFMFBK.Count > 0)
			{
				CanvasGroup canvasGroup2 = this.DOINKGBILKD(this.PKKHHJFMFBK.Count - 1);
				PlayerCharacterManager playerCharacterManager2 = this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1];
				if (null != canvasGroup2 && null != playerCharacterManager2)
				{
					if (!flag)
					{
						this.DKDGAHBBKFF = true;
						canvasGroup2.DOKill(false);
						canvasGroup2.DOFade(0f, 0.4f).OnComplete(new TweenCallback(this.MFINPJIGCBH));
						playerCharacterManager2.GetComponent<RectTransform>().DOAnchorPos(playerCharacterManager2.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
					}
					playerCharacterManager2.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ECKKLDMKPAP(playerCharacterManager2.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH), duration).SetEase(Ease.OutQuad);
				}
			}
			if (this.OHGAKMBALFA.Count > 0)
			{
				CanvasGroup canvasGroup3 = this.EAOHOLHOLKN(this.OHGAKMBALFA.Count - 1);
				NonPlayerCharacterManager nonPlayerCharacterManager = this.OHGAKMBALFA[this.OHGAKMBALFA.Count - 1];
				if (null != canvasGroup3 && null != nonPlayerCharacterManager)
				{
					if (!flag)
					{
						canvasGroup3.DOKill(false);
						canvasGroup3.DOFade(0f, 0.4f).OnComplete(new TweenCallback(this.KLOLAHCAKDD));
						nonPlayerCharacterManager.GetComponent<RectTransform>().DOAnchorPos(nonPlayerCharacterManager.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, 0.4f, false).SetEase(Ease.OutQuad);
					}
					nonPlayerCharacterManager.GetComponent<RectTransform>().DOScale(DHGFCJGJFOB.ECKKLDMKPAP(nonPlayerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH), duration).SetEase(Ease.OutQuad);
				}
			}
			gameObject.GetComponent<RectTransform>().AHLJBONHHKL(new Vector2(-50f, 0f) * (float)FJHJKKIBHBD);
			gameObject.GetComponent<RectTransform>().DOAnchorPos(gameObject.GetComponent<RectTransform>().anchoredPosition + new Vector2(50f, 0f) * (float)FJHJKKIBHBD, duration, false).SetEase(Ease.OutQuad);
			float num = DHGFCJGJFOB.ECKKLDMKPAP(playerCharacterManager.GetAnimationScaleCoefficient(), this.JKCAMKMBEEH);
			gameObject.GetComponent<RectTransform>().localScale = new Vector3(num, num, num);
			gameObject.GetComponent<RectTransform>().DOScale(1f, duration).SetEase(Ease.OutQuad);
			if (!flag)
			{
				canvasGroup.alpha = 0f;
				canvasGroup.DOFade(1f, 0.4f).SetEase(Ease.OutQuad);
			}
		}
		else
		{
			canvasGroup.alpha = 1f;
		}
		this.PKKHHJFMFBK.Add(playerCharacterManager);
		this.GMOGLALJAOP.Add(MJHGPLDAPCN);
	}

	// Token: 0x060050A2 RID: 20642 RVA: 0x0023A864 File Offset: 0x00238A64
	private void OEAFLJMPKHO()
	{
		for (int i = 0; i < this.EMLIDDHGCBE.Count; i++)
		{
			this.EMLIDDHGCBE[i].GetComponent<CanvasGroup>().DOKill(false);
			this.EMLIDDHGCBE[i].GetComponent<RectTransform>().DOKill(false);
			this.EMLIDDHGCBE[i].DOKill(false);
			UnityEngine.Object.Destroy(this.EMLIDDHGCBE[i].gameObject);
		}
		this.EMLIDDHGCBE.Clear();
	}

	// Token: 0x060050A3 RID: 20643 RVA: 0x0023A8EC File Offset: 0x00238AEC
	public void GAJHIAEIAHF(bool BJEENNHMKFA)
	{
		if (Time.unscaledTime - this.MMCDNLDCDFC < 1701f)
		{
			return;
		}
		this.MMCDNLDCDFC = Time.unscaledTime;
		try
		{
			if (!AudioManager.DMAAFFFEJGA().PlaySfx("fid", false) && !AudioManager.BFCHJBOOJKE().PlaySfx("layervideo", false) && !AudioManager.DMAAFFFEJGA().PlaySfx("] | " + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), true))
			{
				AudioManager.BFCHJBOOJKE().PlaySfx("serversync", true);
			}
			if (BJEENNHMKFA)
			{
				this.premiumParticles.GetComponent<AnimationScale>().CJDFPJHCBBD();
				this.premiumParticles.Play();
				base.StartCoroutine(this.IEJMLCMIPGC(this.premiumParticles, 240f));
			}
			else
			{
				this.standardParticles.GetComponent<AnimationScale>().HOBGLEOKFAE();
				this.standardParticles.Play();
				base.StartCoroutine(this.MKJBNOCAOKG(this.standardParticles, 1087f));
			}
			if (!this.APJJJGEEIBN && this.OHGAKMBALFA.Count > 0)
			{
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = this.CFBLALNJPIA[this.OHGAKMBALFA.Count - 0];
				if (ahlneabnmoa != null)
				{
					AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.ECBLOIBCNPM();
					if (null != assetCustomEffects)
					{
						DHGFCJGJFOB.ENEHPCEDNIP(ahlneabnmoa, assetCustomEffects, BJEENNHMKFA);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060050A4 RID: 20644 RVA: 0x0023AA54 File Offset: 0x00238C54
	public bool GBFEDHPAIBH(LHBFJJIJNMI JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB, CustomWardrobeSettings FHIBKDHEKEB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.LCOKEPGNEKI = FHIBKDHEKEB;
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return false;
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1 && this.IMPAHLIGELE.JMNMOHIKHLB != null)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("asv"))
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count > this.IMPAHLIGELE.COEFNFJMBDG.Count)
				{
					this.IMPAHLIGELE.JMNMOHIKHLB.HFINIHDDKHM(this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count - this.IMPAHLIGELE.COEFNFJMBDG.Count);
				}
			}
			else
			{
				try
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.EEFGNGBJHPN(this.IMPAHLIGELE.COEFNFJMBDG.Count))
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
					}
					int num = 1;
					for (int i = 0; i < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; i++)
					{
						if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.premium)
						{
							num++;
						}
					}
					if (LiveEventsManager.NMGMNAKLLMI().CENBCALNAJN((EGMCEPOABBF)8, -1, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ) || num > KBOJLHAJPCP.MHHMEBPPENC)
					{
						bool flag = false;
						for (int j = 0; j < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; j += 0)
						{
							if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[j].BFGHEPLHJFI() == (HKCCMACFNEO)5 && j == this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count - 1)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							if (num > KBOJLHAJPCP.MHHMEBPPENC)
							{
								DPGJIJGOCIC.ADFCDFHBDAF("@");
							}
							this.IMPAHLIGELE.MPHEAGJJEHC(1);
							this.IMPAHLIGELE.JMNMOHIKHLB.NGBIBFMGIJM(1);
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB.Count > 1)
		{
			for (int k = 1; k < this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB.Count; k++)
			{
				if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == (PMNHKIDIMLM.NMGJJGIPDJP)(-80))
				{
					AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.KGFLNLPJGAL(KFIHMMIGPLO.overlay, this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.GEMBCIPGIEB[k]), this.LMKDNPOKOBF.NCAMFPGMCIG.OHODCBKFNGJ().OHCMCJHDMOH[0], this.LCOKEPGNEKI);
					if (null != assetAvatarComponent)
					{
						this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[k].COOOGACBAKN = assetAvatarComponent.id;
					}
					else
					{
						DPGJIJGOCIC.ANOPFDLPKGC("tradewishcardoption0");
					}
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("" + this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF.ToString());
				}
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
			{
				for (int l = 0; l < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count; l++)
				{
					if (this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[l].BFGHEPLHJFI() == (HKCCMACFNEO)7)
					{
						for (int m = 1; m < this.IMPAHLIGELE.COEFNFJMBDG.Count; m++)
						{
							this.HNGBMIJHPLE.Add(m);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int n = 0; n < 1; n += 0)
				{
					for (int num2 = 0; num2 < this.IMPAHLIGELE.COEFNFJMBDG.Count; num2++)
					{
						int num3 = 0;
						if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
						{
							if ((num2 < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[num2] > 1) || this.KEKHCAPNKCN(num2))
							{
								num3 = 1;
							}
							else if (num2 < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[num2] > 1)
							{
								num3 = 6;
							}
						}
						if ((n == 0 && num3 == 1) || (n != 0 && num3 != 0))
						{
							this.HNGBMIJHPLE.Add(num2);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JMNMOHIKHLB.ALAGMBEKNLD();
		try
		{
			sourceText = ONEHEBIHPFB.LCKCKFDDDLC(this.IMPAHLIGELE.JMNMOHIKHLB.NIDBKIANFFI());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, false);
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.clothes || (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count == 0))
		{
			this.prevButton.gameObject.SetActive(false);
			this.nextButton.gameObject.SetActive(false);
			if (this.FCNIIOBIIFP > 756f && null != this.itemTitle)
			{
				this.itemTitle.rectTransform.sizeDelta = new Vector2(this.itemTitle.rectTransform.sizeDelta.x + 1109f * this.FCNIIOBIIFP, this.itemTitle.rectTransform.sizeDelta.y);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			int num4 = 0;
			while (num4 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject = null;
				int num5 = 1;
				if (this.IMPAHLIGELE.JMNMOHIKHLB != null)
				{
					if ((this.FOIKKLIFNIF(num4) < this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count && this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.FOIKKLIFNIF(num4)] > 0) || this.KEKHCAPNKCN(this.HDBBHHBOJIN(num4)))
					{
						num5 = 0;
					}
					else if (this.FOIKKLIFNIF(num4) < this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.FOIKKLIFNIF(num4)] > 1)
					{
						num5 = 8;
					}
				}
				if (num5 == 7)
				{
					switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FOIKKLIFNIF(num4)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject.transform.SetParent(this.choicePivot.transform, false);
					gameObject.GetComponent<ChoiceStatManager>().BGLIAHEKACL(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.ENJDGEOFPAA[this.FOIKKLIFNIF(num4)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)]].DPLHPBMJAPJ(), -159);
					gameObject.GetComponent<ChoiceStatManager>().BHPMJGCCEEN();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FOIKKLIFNIF(num4)])
							{
							case CHEEGEJNIDB.stat0:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat0InfoPrefab);
								break;
							case CHEEGEJNIDB.stat1:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat1InfoPrefab);
								break;
							case CHEEGEJNIDB.stat2:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat2InfoPrefab);
								break;
							case CHEEGEJNIDB.stat3:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat3InfoPrefab);
								break;
							case CHEEGEJNIDB.stat4:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat4InfoPrefab);
								break;
							case CHEEGEJNIDB.stat5:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat5InfoPrefab);
								break;
							case CHEEGEJNIDB.stat6:
								this.NGGBBCDPMJH = UnityEngine.Object.Instantiate<GameObject>(this.stat6InfoPrefab);
								break;
							}
							this.NGGBBCDPMJH.transform.SetParent(this.currencyPivot.transform, true);
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().CNJKPDCGHHB(this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.HDBBHHBOJIN(num4)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JMNMOHIKHLB.ADHIIAONMDJ[this.FOIKKLIFNIF(num4)]].NPEOEAFOPJP());
							try
							{
								if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains(""))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm3)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
							}
						}
						goto IL_C6B;
					}
					catch (Exception aklgbjkdomm4)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
						goto IL_C6B;
					}
					goto IL_975;
				}
				goto IL_975;
				IL_C6B:
				Button component = gameObject.GetComponent<Button>();
				if (this.HDBBHHBOJIN(num4) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(num4) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.HOBEEPJNFPO));
				}
				else if (this.HDBBHHBOJIN(num4) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.KHLFHKGACPO));
				}
				else if (this.FOIKKLIFNIF(num4) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(num4) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.FOIKKLIFNIF(num4) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				else if (this.FOIKKLIFNIF(num4) == 6)
				{
					component.onClick.AddListener(new UnityAction(this.CGOGFBKDCKO));
				}
				else if (this.FOIKKLIFNIF(num4) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.KMKDEDCJMED));
				}
				else if (this.FOIKKLIFNIF(num4) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.APJGNJEAOOE));
				}
				else if (this.HDBBHHBOJIN(num4) == -48)
				{
					component.onClick.AddListener(new UnityAction(this.IJCOFAGIHMA));
				}
				else if (this.HDBBHHBOJIN(num4) == 80)
				{
					component.onClick.AddListener(new UnityAction(this.FKLCKMHIEGM));
				}
				else if (this.FOIKKLIFNIF(num4) == -22)
				{
					component.onClick.AddListener(new UnityAction(this.ADCKLJPMFOD));
				}
				else if (this.HDBBHHBOJIN(num4) == -23)
				{
					component.onClick.AddListener(new UnityAction(this.MIAGPJPEBNI));
				}
				else if (this.HDBBHHBOJIN(num4) == 67)
				{
					component.onClick.AddListener(new UnityAction(this.MJFIKHGDHMI));
				}
				else if (this.HDBBHHBOJIN(num4) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.DMBINGFILDA));
				}
				else if (this.HDBBHHBOJIN(num4) == -18)
				{
					component.onClick.AddListener(new UnityAction(this.DMFJEODPAOJ));
				}
				else if (this.HDBBHHBOJIN(num4) == -2)
				{
					component.onClick.AddListener(new UnityAction(this.DJJNNEDMPBJ));
				}
				else if (this.FOIKKLIFNIF(num4) == -18)
				{
					component.onClick.AddListener(new UnityAction(this.JPBGDDDOCEK));
				}
				else if (this.FOIKKLIFNIF(num4) == -120)
				{
					component.onClick.AddListener(new UnityAction(this.BHKPPNPNMGP));
				}
				else if (this.HDBBHHBOJIN(num4) == -80)
				{
					component.onClick.AddListener(new UnityAction(this.GEADEEKJOHO));
				}
				else if (this.HDBBHHBOJIN(num4) == -110)
				{
					component.onClick.AddListener(new UnityAction(this.IBEAPGIBIPN));
				}
				else if (this.FOIKKLIFNIF(num4) == -53)
				{
					component.onClick.AddListener(new UnityAction(this.CFABGJOONAM));
				}
				else if (this.FOIKKLIFNIF(num4) == -54)
				{
					component.onClick.AddListener(new UnityAction(this.EIBHLKBNLII));
				}
				else if (this.FOIKKLIFNIF(num4) == 65)
				{
					component.onClick.AddListener(new UnityAction(this.JGJCDDANFIB));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("favstostr" + this.FOIKKLIFNIF(num4).ToString() + "Starting non-parallel download:");
				}
				gameObject.SetActive(true);
				this.AKFKCKHPIOA.Add(gameObject);
				num4++;
				continue;
				IL_975:
				if (num5 == 1)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject.transform.SetParent(this.choicePivot.transform, true);
					if (this.BLBHCDOKDFC && this.ONJJIPDEECM(this.HDBBHHBOJIN(num4)))
					{
						this.GNOOJHLPJNC(gameObject);
					}
					if ((!this.KEKHCAPNKCN(this.HDBBHHBOJIN(num4)) || this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)].JANBJONALDA() != HKCCMACFNEO.free) && SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ, this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ))
					{
						gameObject.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], 1, -18, false, this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.FOIKKLIFNIF(num4), LiveEventsManager.NMGMNAKLLMI().LiveEventActive((EGMCEPOABBF)8, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().FFAKMKJMEGI("musavatar");
						}
						gameObject.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[this.HDBBHHBOJIN(num4)], -34, false, this.IMPAHLIGELE.JMNMOHIKHLB.NEKLAJAEOJJ(this.FOIKKLIFNIF(num4), LiveEventsManager.ONCPHEEJLOP().OEHDOMDPHDN((EGMCEPOABBF)6, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
					}
					gameObject.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[this.HDBBHHBOJIN(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KAJNELPPCIJ[this.FOIKKLIFNIF(num4)], this.IMPAHLIGELE.JMNMOHIKHLB.KMFABKNKFAJ));
					this.FCBCCJGFLFA(gameObject.GetComponent<ChoicePremiumManager>(), this.FOIKKLIFNIF(num4));
					goto IL_C6B;
				}
				gameObject = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject.transform.SetParent(this.choicePivot.transform, true);
				gameObject.GetComponent<ChoiceStandardManager>().HBBFAAOICDH(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num4)], 143);
				goto IL_C6B;
			}
		}
		if (this.IFKHBKGIHIN >= 1)
		{
			for (int num6 = 1; num6 < this.HNGBMIJHPLE.Count; num6 += 0)
			{
				if (this.HNGBMIJHPLE[num6] == this.IFKHBKGIHIN)
				{
					this.IILHFLJICJA = num6;
					break;
				}
			}
			this.IFKHBKGIHIN = -1;
		}
		this.FJFKBNKBHHM(this.IILHFLJICJA, true, 1);
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x060050A5 RID: 20645 RVA: 0x0023BBB8 File Offset: 0x00239DB8
	private bool JIDKMHKIHLL(int NBGCCMJAJKB)
	{
		int num = this.IMPAHLIGELE.JMNMOHIKHLB.KFEDEBGDAHH(NBGCCMJAJKB);
		return num != 3 && num >= 0 && num <= 5;
	}

	// Token: 0x060050A6 RID: 20646 RVA: 0x0023BBEC File Offset: 0x00239DEC
	private CanvasGroup DOINKGBILKD(int MEFKFOHCOHK)
	{
		if (this.GMOGLALJAOP[MEFKFOHCOHK] != null)
		{
			return this.GMOGLALJAOP[MEFKFOHCOHK].AJDMCHIOJAK;
		}
		if (null == this.PKKHHJFMFBK[MEFKFOHCOHK])
		{
			return null;
		}
		return this.PKKHHJFMFBK[MEFKFOHCOHK].GetComponent<CanvasGroup>();
	}

	// Token: 0x060050A7 RID: 20647 RVA: 0x0023BC40 File Offset: 0x00239E40
	private CharacterRenderTexturePool.AHLNEABNMOA INGNDHEBIFA(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.GetOrCreate();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.JEBMMNPFONM(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.GOONPCBMBFK(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x060050A8 RID: 20648 RVA: 0x0023BCB4 File Offset: 0x00239EB4
	private void MIAGPJPEBNI()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(66);
		AOBJLALDBAA.DBLAIDPICIG().EFBNBFIDEOK("Starting parallel download:", 1520f);
	}

	// Token: 0x060050A9 RID: 20649 RVA: 0x0023BCD8 File Offset: 0x00239ED8
	private void EAFGCBFCLLG(GameObject AFGGHKMOBCJ)
	{
		try
		{
			if (!(null == AFGGHKMOBCJ))
			{
				Sprite sprite = this.NHADDEPNEON;
				Sprite sprite2 = this.MONFLBMAKCM;
				if ((null == sprite || null == sprite2) && null != this.choicePremiumPrefab)
				{
					Image component = this.choicePremiumPrefab.GetComponent<Image>();
					Button component2 = this.choicePremiumPrefab.GetComponent<Button>();
					if (null == sprite && null != component)
					{
						sprite = component.sprite;
					}
					if (null == sprite2 && null != component2)
					{
						sprite2 = component2.spriteState.pressedSprite;
					}
				}
				if (null == sprite)
				{
					DPGJIJGOCIC.PJCLICBPPDA("(");
				}
				else
				{
					Image component3 = AFGGHKMOBCJ.GetComponent<Image>();
					if (null != component3)
					{
						component3.sprite = sprite;
						component3.type = Image.Type.Simple;
					}
					Button component4 = AFGGHKMOBCJ.GetComponent<Button>();
					if (null != component4)
					{
						SpriteState spriteState = component4.spriteState;
						spriteState.highlightedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.pressedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.selectedSprite = ((null != sprite2) ? sprite2 : sprite);
						spriteState.disabledSprite = null;
						component4.transition = (Selectable.Transition)5;
						component4.spriteState = spriteState;
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060050AA RID: 20650 RVA: 0x0023BE40 File Offset: 0x0023A040
	private void ACPGAGCKGBJ(int MEFKFOHCOHK)
	{
		if (null != this.EBHJLLIHIFE && this.CFBLALNJPIA[MEFKFOHCOHK] != null)
		{
			this.EBHJLLIHIFE.ReleaseSlot(this.CFBLALNJPIA[MEFKFOHCOHK]);
		}
		this.CFBLALNJPIA[MEFKFOHCOHK] = null;
		this.OHGAKMBALFA[MEFKFOHCOHK] = null;
	}

	// Token: 0x060050AB RID: 20651 RVA: 0x0023BE9C File Offset: 0x0023A09C
	private void FJFKBNKBHHM(int NBGCCMJAJKB, bool BABNFFJPGNB, int FOOPINEFKIO)
	{
		if (!this.OONENNLLFHL())
		{
			return;
		}
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].SetActive(false);
		}
		if (NBGCCMJAJKB < this.AKFKCKHPIOA.Count)
		{
			this.AKFKCKHPIOA[NBGCCMJAJKB].SetActive(true);
			if (!BABNFFJPGNB)
			{
				try
				{
					ChoicePremiumManager component = this.AKFKCKHPIOA[NBGCCMJAJKB].GetComponent<ChoicePremiumManager>();
					if (null != component && ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass) != null)
					{
						component.UpdateParams(false);
					}
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.cue || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.item)
		{
			string khjmandedma = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
			if (this.HACMNFIGBFG(this.HDBBHHBOJIN(NBGCCMJAJKB)))
			{
				this.OMLDAIBLJIC(this.storyItemPrefabPrem, GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma), true, FOOPINEFKIO, this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("fullscreen"));
			}
			else
			{
				this.OMLDAIBLJIC(this.storyItemPrefab, GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma), true, FOOPINEFKIO, this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("fullscreen"));
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.npc)
		{
			if (this.OFNHKAFKDCN(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN))
			{
				this.KFGPOOAJJBJ(true, FOOPINEFKIO, this.LMKDNPOKOBF.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center);
			}
			else
			{
				string text = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				try
				{
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
					{
						for (int j = 0; j < this.ODNCKIKLFCM.Count; j++)
						{
							if (null != this.ODNCKIKLFCM[j])
							{
								for (int k = 0; k < this.ODNCKIKLFCM[j].mappings.Count; k++)
								{
									if (this.ODNCKIKLFCM[j].mappings[k].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Character " + text + " not found, replacing with " + this.ODNCKIKLFCM[j].id);
										text = this.ODNCKIKLFCM[j].id;
										break;
									}
								}
							}
						}
					}
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
				if (this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.KIDPANPCBFF.Count)
				{
					List<string> list = new List<string>();
					list.Add(this.IMPAHLIGELE.JMNMOHIKHLB.KIDPANPCBFF[this.HDBBHHBOJIN(NBGCCMJAJKB)]);
					try
					{
						if (this.LMKDNPOKOBF.NCAMFPGMCIG.AKHCBFGADPJ().Count > 0)
						{
							list.AddRange(this.LMKDNPOKOBF.NCAMFPGMCIG.AKHCBFGADPJ());
						}
					}
					catch (Exception aklgbjkdomm3)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
					}
					this.CBNMCPNJELH(text, list, true, FOOPINEFKIO);
				}
				else
				{
					this.CBNMCPNJELH(text, this.LMKDNPOKOBF.NCAMFPGMCIG.AKHCBFGADPJ(), true, FOOPINEFKIO);
				}
				if (this.IMPAHLIGELE.JMNMOHIKHLB.NGNDOALIKAK.Contains("emlooprestart"))
				{
					LPEMDECEIAO.IKPBDMAACKG(text);
					LPEMDECEIAO.EIGLJFIOJPE(text);
				}
				if (this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.PPMGNKCCIPG.Count)
				{
					this.OHGAKMBALFA[this.OHGAKMBALFA.Count - 1].SetEmotion(AssetAvatarComponent.EIGIDJLDCLH(this.IMPAHLIGELE.JMNMOHIKHLB.PPMGNKCCIPG[this.HDBBHHBOJIN(NBGCCMJAJKB)]), BIDPEOLOIIG.appearImmediate, FLNOFHCNJDM.neutral);
				}
			}
		}
		if (this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL.Count)
		{
			string sourceText = this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].CEIICLNKAIG();
			try
			{
				sourceText = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].CEIICLNKAIG());
			}
			catch (Exception aklgbjkdomm4)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
			}
			this.itemTitle.SetText(sourceText, true);
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.emotion || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.clothes || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.hair || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.face || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.body || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.trinket || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.overlay)
		{
			this.KFGPOOAJJBJ(true, FOOPINEFKIO, this.LMKDNPOKOBF.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center);
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.emotion)
			{
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetEmotion(AssetAvatarComponent.EIGIDJLDCLH(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN), KBACNADIIDP.appearImmediate, FLNOFHCNJDM.neutral);
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.clothes)
			{
				string khjmandedma2 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetClothesComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, khjmandedma2, null));
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].ForceUpdateComponentsInterVisibility();
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.hair)
			{
				string khjmandedma3 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetHairComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.hair, khjmandedma3, null));
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].ForceUpdateComponentsInterVisibility();
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.face)
			{
				string khjmandedma4 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetFaceComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, khjmandedma4, null));
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].ForceUpdateComponentsInterVisibility();
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.body)
			{
				string text2 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetBodyComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.body, text2, null));
				AssetAvatarComponent assetAvatarComponent = GKJPOGNFKNK.IIHLMMBEPMB(KFIHMMIGPLO.face, text2, this.LCOKEPGNEKI);
				if (null != assetAvatarComponent)
				{
					this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetFaceComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.face, assetAvatarComponent.id, null));
				}
				else
				{
					DPGJIJGOCIC.ANOPFDLPKGC("ERROR: UpdateChoiceData(): - firstAvailableFaceAsset is null.");
				}
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.trinket)
			{
				string khjmandedma5 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetTrinketComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.trinket, khjmandedma5, null));
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].ForceUpdateComponentsInterVisibility();
			}
			if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.overlay)
			{
				string khjmandedma6 = this.LMKDNPOKOBF.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetOverlayComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.overlay, khjmandedma6, null));
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].ForceUpdateComponentsInterVisibility();
			}
			if ((this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.clothes || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.hair || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.face || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.body || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.overlay || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.trinket) && this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.PPMGNKCCIPG.Count)
			{
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetEmotion(AssetAvatarComponent.EIGIDJLDCLH(this.IMPAHLIGELE.JMNMOHIKHLB.PPMGNKCCIPG[this.HDBBHHBOJIN(NBGCCMJAJKB)]), KBACNADIIDP.appearImmediate, FLNOFHCNJDM.neutral);
			}
			if ((this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.trinket || this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.overlay) && this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.NHOAKCNFEDP.Count)
			{
				this.PKKHHJFMFBK[this.PKKHHJFMFBK.Count - 1].SetClothesComponent(GKJPOGNFKNK.HLLPGFEJNJG(KFIHMMIGPLO.clothes, this.IMPAHLIGELE.JMNMOHIKHLB.NHOAKCNFEDP[this.HDBBHHBOJIN(NBGCCMJAJKB)], null));
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.environment)
		{
			if (!BABNFFJPGNB)
			{
				this.CKJLPMMHINB = true;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedEnvironmentChange", this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedEnvironmentChangeOnInit", this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
			}
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.GAOKFGHCIAF == PMNHKIDIMLM.NMGJJGIPDJP.layer)
		{
			this.MKNCFHPKOBF = true;
			if (this.JJKKDONEPID != null && this.JJKKDONEPID.Length > 0)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedLayerChange", this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN + "," + this.JJKKDONEPID);
			}
			else
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedLayerChange", this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN);
			}
			this.JJKKDONEPID = this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL[this.HDBBHHBOJIN(NBGCCMJAJKB)].COOOGACBAKN;
		}
		if (this.HDBBHHBOJIN(NBGCCMJAJKB) < this.IMPAHLIGELE.JMNMOHIKHLB.LDGIOAPNEJD.Count)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedPlayNewAmbient", this.IMPAHLIGELE.JMNMOHIKHLB.LDGIOAPNEJD[this.HDBBHHBOJIN(NBGCCMJAJKB)]);
		}
		this.MKIHBJDNCPP();
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnChoiceExtendedViewedChoiceChanged", 0f);
	}

	// Token: 0x060050AC RID: 20652 RVA: 0x0023CABC File Offset: 0x0023ACBC
	public void OnButtonNextClick()
	{
		if (!this.KJNJBKCMAGA && !this.APJJJGEEIBN && !this.DKDGAHBBKFF && !this.CKJLPMMHINB && !this.MKNCFHPKOBF)
		{
			if (this.AKFKCKHPIOA.Count > 0)
			{
				this.IILHFLJICJA++;
				if (this.IILHFLJICJA >= this.AKFKCKHPIOA.Count)
				{
					this.IILHFLJICJA = 0;
				}
			}
			this.FJFKBNKBHHM(this.IILHFLJICJA, false, 1);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnTryToFireNoteshowTimer", 0f);
		}
	}

	// Token: 0x060050AD RID: 20653 RVA: 0x0023CB49 File Offset: 0x0023AD49
	private void DDNMMPIJLNK()
	{
		this.slidingPanelButtonShow.interactable = true;
		this.CHPCJCILKNH();
	}

	// Token: 0x060050AE RID: 20654 RVA: 0x0023CB5D File Offset: 0x0023AD5D
	private static string GDJBPHPFBIN(int LGOPLJPNHHM)
	{
		if (LGOPLJPNHHM == 1)
		{
			return KBOJLHAJPCP.PCGOLCMNFBI;
		}
		if (LGOPLJPNHHM == 2)
		{
			return KBOJLHAJPCP.AAHIADFKCKH;
		}
		return KBOJLHAJPCP.NENCABBIJOK;
	}

	// Token: 0x060050AF RID: 20655 RVA: 0x0023CB78 File Offset: 0x0023AD78
	private bool PBJGCPCEAIH(int NBGCCMJAJKB)
	{
		return NBGCCMJAJKB >= this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG.Count || this.IMPAHLIGELE.JMNMOHIKHLB.IPALJDCNBBG[NBGCCMJAJKB] <= 1 || true;
	}

	// Token: 0x060050B0 RID: 20656 RVA: 0x0023CBAE File Offset: 0x0023ADAE
	private void BENGHKGCLOG()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050B1 RID: 20657 RVA: 0x0023CBD0 File Offset: 0x0023ADD0
	public static bool SwipeConsumedRelease()
	{
		return Time.frameCount - ChoiceExtendedManager.NPKLLDMOEJC == 0;
	}

	// Token: 0x060050B2 RID: 20658 RVA: 0x0023CBE0 File Offset: 0x0023ADE0
	public void IOBAPODGKCE()
	{
		this.IEILALNLAFO = false;
		this.OPLDMEEFKDO(true);
	}

	// Token: 0x060050B3 RID: 20659 RVA: 0x0023CBF0 File Offset: 0x0023ADF0
	private void DMFJEODPAOJ()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(15);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050B4 RID: 20660 RVA: 0x0023CC13 File Offset: 0x0023AE13
	private void IBEAPGIBIPN()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(20);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050B5 RID: 20661 RVA: 0x0023CC38 File Offset: 0x0023AE38
	private void MFINPJIGCBH()
	{
		this.DKDGAHBBKFF = false;
		for (int i = 0; i < this.PKKHHJFMFBK.Count; i++)
		{
			if (this.GMOGLALJAOP[i] != null)
			{
				if (null != this.GMOGLALJAOP[i].AJDMCHIOJAK && this.GMOGLALJAOP[i].AJDMCHIOJAK.alpha < 0.01f && !DOTween.IsTweening(this.GMOGLALJAOP[i].AJDMCHIOJAK, true))
				{
					this.IDNANEBJACO(i);
				}
			}
			else if (null != this.PKKHHJFMFBK[i] && this.PKKHHJFMFBK[i].gameObject.activeSelf && this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>().alpha < 0.01f && !DOTween.IsTweening(this.PKKHHJFMFBK[i].GetComponent<CanvasGroup>(), true))
			{
				this.PKKHHJFMFBK[i].gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060050B6 RID: 20662 RVA: 0x0023CD50 File Offset: 0x0023AF50
	private bool GMMCDODLDBK()
	{
		return null != this.slidingPanelButtonShow && this.slidingPanelButtonShow.gameObject.activeSelf && this.slidingPanelButtonShow.interactable;
	}

	// Token: 0x060050B7 RID: 20663 RVA: 0x0023CD7F File Offset: 0x0023AF7F
	private void KMKDEDCJMED()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050B8 RID: 20664 RVA: 0x0023CDA4 File Offset: 0x0023AFA4
	public void RefreshPremiumChoiceOwnedState(int KMDCDNCADGJ)
	{
		try
		{
			for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
			{
				if (this.HDBBHHBOJIN(i) == KMDCDNCADGJ)
				{
					ChoicePremiumManager component = this.AKFKCKHPIOA[i].GetComponent<ChoicePremiumManager>();
					if (null != component && KMDCDNCADGJ < this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL.Count && KMDCDNCADGJ < this.IMPAHLIGELE.COEFNFJMBDG.Count)
					{
						component.ClearCustomCostDisplay();
						component.Initialize(this.IMPAHLIGELE.JMNMOHIKHLB.MKPMEKKGEIL[KMDCDNCADGJ], this.IMPAHLIGELE.COEFNFJMBDG[KMDCDNCADGJ], 0, 500, false, this.IMPAHLIGELE.JMNMOHIKHLB.CKLNCCAGCKE(KMDCDNCADGJ, LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JMNMOHIKHLB.BGIOGOACCBJ);
						component.SwitchCost(false);
						this.FCBCCJGFLFA(component, KMDCDNCADGJ);
					}
					this.MKIHBJDNCPP();
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060050B9 RID: 20665 RVA: 0x0023CEC0 File Offset: 0x0023B0C0
	public Vector3 GetSlidingPanelWorldOffsetToRest()
	{
		if (null == this.FOPNADOFECH)
		{
			return Vector3.zero;
		}
		Vector2 vector = this.OIPMEGJLIDC - this.FOPNADOFECH.anchoredPosition;
		if (null == this.FOPNADOFECH.parent)
		{
			return new Vector3(vector.x, vector.y, 0f);
		}
		return this.FOPNADOFECH.parent.TransformVector(new Vector3(vector.x, vector.y, 0f));
	}

	// Token: 0x060050BA RID: 20666 RVA: 0x0023CF48 File Offset: 0x0023B148
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null || this.IMPAHLIGELE.JMNMOHIKHLB == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: ChoiceExtendedManager.InputDataIsValid() - step.choiceMeta is null.");
			return false;
		}
		if (this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL.Count > 0 && this.IMPAHLIGELE.COEFNFJMBDG.Count > this.IMPAHLIGELE.JMNMOHIKHLB.AOANDELCCEL.Count)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ERROR: ChoiceExtendedManager.InputDataIsValid() - choices count is greater than assetList count.");
			return false;
		}
		return true;
	}

	// Token: 0x060050BB RID: 20667 RVA: 0x0023CFC4 File Offset: 0x0023B1C4
	private void OJIGNBBCBPE()
	{
		for (int i = 0; i < this.OHGAKMBALFA.Count; i++)
		{
			if (this.CFBLALNJPIA[i] != null)
			{
				this.HJINCBEDEAG(i);
			}
			else if (null != this.OHGAKMBALFA[i])
			{
				this.OHGAKMBALFA[i].GetComponent<CanvasGroup>().DOKill(false);
				this.OHGAKMBALFA[i].GetComponent<RectTransform>().DOKill(true);
				this.OHGAKMBALFA[i].DOKill(true);
				UnityEngine.Object.Destroy(this.OHGAKMBALFA[i].gameObject);
			}
		}
		this.OHGAKMBALFA.Clear();
		this.CFBLALNJPIA.Clear();
	}

	// Token: 0x060050BC RID: 20668 RVA: 0x002383E8 File Offset: 0x002365E8
	public void SetInitialChoiceByRemappedIndex(int GMHPANAHEPM)
	{
		this.IFKHBKGIHIN = GMHPANAHEPM;
	}

	// Token: 0x060050BD RID: 20669 RVA: 0x0023D087 File Offset: 0x0023B287
	private void EIBHLKBNLII()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(22);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x060050BE RID: 20670 RVA: 0x0023D0AC File Offset: 0x0023B2AC
	private void EAKEDEEHEDD()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(911f) && null != this.currencyPivot)
		{
			float num = Mathf.Abs(1372f - NarrowScreenScaler.CalculateNewScaleUtil(908f, (IMBLFHMKMAD)(-33)));
			num = Mathf.Clamp01(num);
			if (this.currencyPivot.GetComponent<RectTransform>().anchoredPosition.x > 816f)
			{
				this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(1624f * num, 1203f * num);
				return;
			}
			this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(396f * num, 1168f * num);
		}
	}

	// Token: 0x04001693 RID: 5779
	public const string onChoiceExtendedPlayNewAmbient = "OnChoiceExtendedPlayNewAmbient";

	// Token: 0x04001694 RID: 5780
	public const string onChoiceExtendedEnvironmentChange = "OnChoiceExtendedEnvironmentChange";

	// Token: 0x04001695 RID: 5781
	public const string onChoiceExtendedLayerChange = "OnChoiceExtendedLayerChange";

	// Token: 0x04001696 RID: 5782
	public const string onChoiceExtendedEnvironmentChangeOnInit = "OnChoiceExtendedEnvironmentChangeOnInit";

	// Token: 0x04001697 RID: 5783
	public const string onChoiceExtendedPanelSlideShown = "OnChoiceExtendedPanelSlideShown";

	// Token: 0x04001698 RID: 5784
	public const string onChoiceExtendedPanelSlideHidden = "OnChoiceExtendedPanelSlideHidden";

	// Token: 0x04001699 RID: 5785
	public const string onChoiceExtendedPanelSlideShownComplete = "OnChoiceExtendedPanelSlideShownComplete";

	// Token: 0x0400169A RID: 5786
	public const string onChoiceExtendedViewedChoiceChanged = "OnChoiceExtendedViewedChoiceChanged";

	// Token: 0x0400169B RID: 5787
	private const float ELFIGAONIFF = 0.5f;

	// Token: 0x0400169C RID: 5788
	public int slidingPanelTranslationAmountY = 412;

	// Token: 0x0400169D RID: 5789
	public int slidingPanelTranslationAmountNarrowY = 3;

	// Token: 0x0400169E RID: 5790
	public TextMeshProUGUI choiceTitle;

	// Token: 0x0400169F RID: 5791
	public TextMeshProUGUI itemTitle;

	// Token: 0x040016A0 RID: 5792
	public TextMeshProUGUI itemDescription;

	// Token: 0x040016A1 RID: 5793
	public Button prevButton;

	// Token: 0x040016A2 RID: 5794
	public Button nextButton;

	// Token: 0x040016A3 RID: 5795
	public GameObject choicePivot;

	// Token: 0x040016A4 RID: 5796
	public GameObject choicePremiumPrefab;

	// Token: 0x040016A5 RID: 5797
	public GameObject choiceStandardPrefab;

	// Token: 0x040016A6 RID: 5798
	public GameObject choiceStat0Prefab;

	// Token: 0x040016A7 RID: 5799
	public GameObject choiceStat1Prefab;

	// Token: 0x040016A8 RID: 5800
	public GameObject choiceStat2Prefab;

	// Token: 0x040016A9 RID: 5801
	public GameObject choiceStat3Prefab;

	// Token: 0x040016AA RID: 5802
	public GameObject choiceStat4Prefab;

	// Token: 0x040016AB RID: 5803
	public GameObject choiceStat5Prefab;

	// Token: 0x040016AC RID: 5804
	public GameObject choiceStat6Prefab;

	// Token: 0x040016AD RID: 5805
	public GameObject stat0InfoPrefab;

	// Token: 0x040016AE RID: 5806
	public GameObject stat1InfoPrefab;

	// Token: 0x040016AF RID: 5807
	public GameObject stat2InfoPrefab;

	// Token: 0x040016B0 RID: 5808
	public GameObject stat3InfoPrefab;

	// Token: 0x040016B1 RID: 5809
	public GameObject stat4InfoPrefab;

	// Token: 0x040016B2 RID: 5810
	public GameObject stat5InfoPrefab;

	// Token: 0x040016B3 RID: 5811
	public GameObject stat6InfoPrefab;

	// Token: 0x040016B4 RID: 5812
	public GameObject storyItemPivot;

	// Token: 0x040016B5 RID: 5813
	public GameObject storyItemPrefab;

	// Token: 0x040016B6 RID: 5814
	public GameObject storyItemPrefabPrem;

	// Token: 0x040016B7 RID: 5815
	public GameObject characterPivot;

	// Token: 0x040016B8 RID: 5816
	public GameObject slidingPanel;

	// Token: 0x040016B9 RID: 5817
	public Button slidingPanelButtonShow;

	// Token: 0x040016BA RID: 5818
	public Button slidingPanelButtonHide;

	// Token: 0x040016BB RID: 5819
	public GameObject currencyPivot;

	// Token: 0x040016BC RID: 5820
	public GameObject premiumInfoPrefab;

	// Token: 0x040016BD RID: 5821
	private GameObject NGGBBCDPMJH;

	// Token: 0x040016BE RID: 5822
	public ParticleSystem premiumParticles;

	// Token: 0x040016BF RID: 5823
	public ParticleSystem standardParticles;

	// Token: 0x040016C0 RID: 5824
	private GameObject LOJHEKCOFME;

	// Token: 0x040016C1 RID: 5825
	private LHBFJJIJNMI IMPAHLIGELE;

	// Token: 0x040016C2 RID: 5826
	private int IILHFLJICJA;

	// Token: 0x040016C3 RID: 5827
	private int IFKHBKGIHIN = -1;

	// Token: 0x040016C4 RID: 5828
	private float FCNIIOBIIFP;

	// Token: 0x040016C5 RID: 5829
	private bool IGJCJHIKNHJ;

	// Token: 0x040016C6 RID: 5830
	private List<GameObject> AKFKCKHPIOA = new List<GameObject>();

	// Token: 0x040016C7 RID: 5831
	private Vector2 OIPMEGJLIDC;

	// Token: 0x040016C8 RID: 5832
	private RectTransform FOPNADOFECH;

	// Token: 0x040016C9 RID: 5833
	private AnimationCanvasGroupAlpha IIFKDKNJJDO;

	// Token: 0x040016CA RID: 5834
	private List<int> HNGBMIJHPLE = new List<int>();

	// Token: 0x040016CB RID: 5835
	private bool KJNJBKCMAGA;

	// Token: 0x040016CC RID: 5836
	private bool APJJJGEEIBN;

	// Token: 0x040016CD RID: 5837
	private List<StoryItemManager> EMLIDDHGCBE = new List<StoryItemManager>();

	// Token: 0x040016CE RID: 5838
	private List<NonPlayerCharacterManager> OHGAKMBALFA = new List<NonPlayerCharacterManager>();

	// Token: 0x040016CF RID: 5839
	private AnimationTranslation DCKJHLJKGOL;

	// Token: 0x040016D0 RID: 5840
	private List<PlayerCharacterManager> PKKHHJFMFBK = new List<PlayerCharacterManager>();

	// Token: 0x040016D1 RID: 5841
	private List<CharacterRenderTexturePool.AHLNEABNMOA> GMOGLALJAOP = new List<CharacterRenderTexturePool.AHLNEABNMOA>();

	// Token: 0x040016D2 RID: 5842
	private List<CharacterRenderTexturePool.AHLNEABNMOA> CFBLALNJPIA = new List<CharacterRenderTexturePool.AHLNEABNMOA>();

	// Token: 0x040016D3 RID: 5843
	private CharacterRenderTexturePool EBHJLLIHIFE;

	// Token: 0x040016D4 RID: 5844
	private float BJOPEGBAEJF = 0.4f;

	// Token: 0x040016D5 RID: 5845
	private float JKCAMKMBEEH = 1f;

	// Token: 0x040016D6 RID: 5846
	private bool DKDGAHBBKFF;

	// Token: 0x040016D7 RID: 5847
	private bool CKJLPMMHINB;

	// Token: 0x040016D8 RID: 5848
	private bool MKNCFHPKOBF;

	// Token: 0x040016D9 RID: 5849
	private const float LMOGKFFGPEM = 0.05f;

	// Token: 0x040016DA RID: 5850
	private const float LMPLACLFFOC = 0.12f;

	// Token: 0x040016DB RID: 5851
	private const float MIPCNHPHMHH = 0.8f;

	// Token: 0x040016DC RID: 5852
	private const float JMJPFCDBFNO = 1.5f;

	// Token: 0x040016DD RID: 5853
	private static int NPKLLDMOEJC = -10;

	// Token: 0x040016DE RID: 5854
	private Func<bool> ENEKOHNJNJL;

	// Token: 0x040016DF RID: 5855
	private bool CDIFMMOJDHA;

	// Token: 0x040016E0 RID: 5856
	private Vector2 GJMOJNPJKGB = Vector2.zero;

	// Token: 0x040016E1 RID: 5857
	private float KAAECELIKNM;

	// Token: 0x040016E2 RID: 5858
	private bool NHJGHNEHDEM;

	// Token: 0x040016E3 RID: 5859
	private GameObject FPOGOGNGDLE;

	// Token: 0x040016E4 RID: 5860
	private CanvasGroup OMHKHHFGEHO;

	// Token: 0x040016E5 RID: 5861
	private string JJKKDONEPID = "";

	// Token: 0x040016E6 RID: 5862
	private PLFDAJJHMKO LMKDNPOKOBF;

	// Token: 0x040016E7 RID: 5863
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();

	// Token: 0x040016E8 RID: 5864
	private bool IEILALNLAFO;

	// Token: 0x040016E9 RID: 5865
	private CustomWardrobeSettings LCOKEPGNEKI;

	// Token: 0x040016EA RID: 5866
	[NonSerialized]
	private float MMCDNLDCDFC = -10f;

	// Token: 0x040016EB RID: 5867
	private bool BLBHCDOKDFC;

	// Token: 0x040016EC RID: 5868
	private Sprite NHADDEPNEON;

	// Token: 0x040016ED RID: 5869
	private Sprite MONFLBMAKCM;

	// Token: 0x040016EE RID: 5870
	private Vector2 FLLHNIIJOLP = Vector2.zero;

	// Token: 0x040016EF RID: 5871
	private bool PEGBIHCIKAO;

	// Token: 0x040016F0 RID: 5872
	private List<int> LJKGCDAGKDI = new List<int>();

	// Token: 0x02000289 RID: 649
	[CompilerGenerated]
	private sealed class DDPPBFBFMLP
	{
		// Token: 0x060050CC RID: 20684 RVA: 0x0023D27B File Offset: 0x0023B47B
		internal void BIIFGFCDGOF()
		{
			if (null != this.fadingObject)
			{
				UnityEngine.Object.Destroy(this.fadingObject);
			}
		}

		// Token: 0x040016F9 RID: 5881
		public GameObject fadingObject;
	}
}
