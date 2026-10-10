using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Token: 0x020003A0 RID: 928
public class DialogReadInputManager : MonoBehaviour
{
	// Token: 0x06006B9C RID: 27548 RVA: 0x003128C4 File Offset: 0x00310AC4
	private CharacterRenderTexturePool.AHLNEABNMOA JHHDJIIKNNI(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.KOIEENLPADG(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator HEGPJENDEMB()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006B9E RID: 27550 RVA: 0x00312948 File Offset: 0x00310B48
	private CharacterRenderTexturePool.AHLNEABNMOA NBNBEDEODHL(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006B9F RID: 27551 RVA: 0x003129BC File Offset: 0x00310BBC
	private CharacterRenderTexturePool.AHLNEABNMOA FJJBNBENACC(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
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
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
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

	// Token: 0x06006BA0 RID: 27552 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator BJKEHBFKCMI()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BA1 RID: 27553 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator CJAHEBHPJDB()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BA2 RID: 27554 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string NOLDJGLMKOE()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BA3 RID: 27555 RVA: 0x00312A37 File Offset: 0x00310C37
	private void LFGPDNCHODF()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1602f, 374f);
		}
	}

	// Token: 0x06006BA4 RID: 27556 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string DKKILMLBBPH()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BA5 RID: 27557 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06006BA6 RID: 27558 RVA: 0x00312A5D File Offset: 0x00310C5D
	private void FJHOMCPCACP()
	{
		this.HDKFBJIMKBK();
	}

	// Token: 0x06006BA7 RID: 27559 RVA: 0x00312A68 File Offset: 0x00310C68
	public void APCBKOGALLK(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.AKILOCOMHCD();
		this.textInput.SetText("", true);
		this.textTitle.SetText(JIKFCLOHJNN.HMPNEBMJBBA(), true);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.OEGKAMPBCHL();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("", false);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.EHDDEHHFEJG(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 0)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("ok"))
			{
				this.LLEOBLHCNJA = this.OHKKCMIIPIO(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, true);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, null);
				}
				this.GOAEECPPHIB.GMFGEJGJNGA(BKBCKPMDFOD.animationStoryAppearFromRight);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "_"))
					{
						for (int i = 1; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 1; j < this.ODNCKIKLFCM[i].mappings.Count; j++)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("lang" + text + "" + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.OHKKCMIIPIO(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, true);
				}
				this.OIDNMECILMM.MAHHJBLOJFA((GFEJBOAKPMP)8);
			}
		}
		base.StartCoroutine(this.MBECDNCKKED());
	}

	// Token: 0x06006BA8 RID: 27560 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator FKNBIFEDFJC()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006BA9 RID: 27561 RVA: 0x00312DBB File Offset: 0x00310FBB
	private void DEEOCEJFDEP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(976f, 1618f);
		}
	}

	// Token: 0x06006BAA RID: 27562 RVA: 0x00312DE1 File Offset: 0x00310FE1
	private void GHLIAECIGCN()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(396f, 484f);
		}
	}

	// Token: 0x06006BAB RID: 27563 RVA: 0x00312A5D File Offset: 0x00310C5D
	private void OnEnable()
	{
		this.HDKFBJIMKBK();
	}

	// Token: 0x06006BAC RID: 27564 RVA: 0x00312E08 File Offset: 0x00311008
	private void LBDOGJFKKAB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BAD RID: 27565 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string BNNLDNPGBAG()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BAE RID: 27566 RVA: 0x00312ED3 File Offset: 0x003110D3
	private void HGEODIPIBPG()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1012f;
		}
	}

	// Token: 0x06006BAF RID: 27567 RVA: 0x00312F04 File Offset: 0x00311104
	public void KPHAAHFCHFC(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.LFGPDNCHODF();
		this.textInput.SetText("sfxtimeoutwarning", true);
		this.textTitle.SetText(JIKFCLOHJNN.CIEBIPGGLFD(), true);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.BGDOBCOGNOE();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("@", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.DDBDKHJGHLC(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 0)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("OnSketchViewAssetsDownloadSuccess"))
			{
				this.LLEOBLHCNJA = this.FJJBNBENACC(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, false);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.AGBPEFEDKNG(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.NOHNKCNODDN((BKBCKPMDFOD)8);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "SceneAvatarManager.AddOrUpdateAvatarCollection(): no free collection index left for this wardrobe"))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j += 0)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("SceneLobby2" + text + "Speed" + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.AEHFKFDGLFJ(true);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.center, true);
				}
				this.OIDNMECILMM.AnimateAppearance(GFEJBOAKPMP.animationChoiceMetaAppearFromLeft);
			}
		}
		base.StartCoroutine(this.NIBILOIHDEE());
	}

	// Token: 0x06006BB0 RID: 27568 RVA: 0x00313248 File Offset: 0x00311448
	public void NEBOHDPPOBO()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 5)
			{
				AOBJLALDBAA.CEGAOMEEFBE().FLLPDFLFEDA("", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.AGANFKKBPFO().HPIPBMEMOFK("OnApplicationRestart", this.textInput.text);
				return;
			}
			AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("\"", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BB1 RID: 27569 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator NGHOJOLFDJN()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006BB2 RID: 27570 RVA: 0x00003E52 File Offset: 0x00002052
	private void DEOBBAHAMLD()
	{
	}

	// Token: 0x06006BB3 RID: 27571 RVA: 0x003132D4 File Offset: 0x003114D4
	private CharacterRenderTexturePool.AHLNEABNMOA GMDEBBAMILN(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.KOIEENLPADG(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006BB4 RID: 27572 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x06006BB5 RID: 27573 RVA: 0x00313348 File Offset: 0x00311548
	private void MGNHFFHBLBP()
	{
		this.BDFBILJIHGE();
	}

	// Token: 0x06006BB6 RID: 27574 RVA: 0x00313350 File Offset: 0x00311550
	public void OJGDJMENKHC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(828f, 295f);
		}
	}

	// Token: 0x06006BB7 RID: 27575 RVA: 0x00313376 File Offset: 0x00311576
	private void AEIJBOMICJK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1727f, 1665f);
		}
	}

	// Token: 0x06006BB8 RID: 27576 RVA: 0x0031339C File Offset: 0x0031159C
	public void KFPEGCIDJNK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1671f, 1454f);
		}
	}

	// Token: 0x06006BB9 RID: 27577 RVA: 0x003133C2 File Offset: 0x003115C2
	private void EHBJOHMNJFH()
	{
		this.GPGCCIIOKON();
	}

	// Token: 0x06006BBA RID: 27578 RVA: 0x003133CA File Offset: 0x003115CA
	private void LPLBDKPLGMA()
	{
		this.INGECOHDDMC();
	}

	// Token: 0x06006BBB RID: 27579 RVA: 0x003133D4 File Offset: 0x003115D4
	public void NKMPLFNGPEO()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.KKPFOJMAONG().EGELHPJBAIC("anthology", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 7)
			{
				AOBJLALDBAA.EHBBFMCILPC.BDEMEIKEJHF("_not_found", this.textInput.text);
				return;
			}
			AOBJLALDBAA.NMGMNAKLLMI().FLLPDFLFEDA("story", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BBC RID: 27580 RVA: 0x0031345F File Offset: 0x0031165F
	private void PFNILJEJILB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 873f;
		}
	}

	// Token: 0x06006BBD RID: 27581 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string MACDMCGECLG()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BBE RID: 27582 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06006BBF RID: 27583 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string HEFNAHDCPGI()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BC0 RID: 27584 RVA: 0x00313490 File Offset: 0x00311690
	public void OHFBLNAMOCE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(798f, 1236f);
		}
	}

	// Token: 0x06006BC1 RID: 27585 RVA: 0x003134B8 File Offset: 0x003116B8
	public void EHMJOIHIELE()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.EHBBFMCILPC.OIMGLKLHNMO("energyhinttitle", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 8)
			{
				AOBJLALDBAA.FILDBDMENPG().PMDEKGAFCCL("pmtsuccess", this.textInput.text);
				return;
			}
			AOBJLALDBAA.CEGAOMEEFBE().FLLPDFLFEDA("npcp", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BC2 RID: 27586 RVA: 0x00313543 File Offset: 0x00311743
	public void IMDJBODLCFK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1808f, 791f);
		}
	}

	// Token: 0x06006BC3 RID: 27587 RVA: 0x00313569 File Offset: 0x00311769
	private void Awake()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06006BC4 RID: 27588 RVA: 0x00003E52 File Offset: 0x00002052
	private void MIMOJFLJLFO()
	{
	}

	// Token: 0x06006BC5 RID: 27589 RVA: 0x0031359C File Offset: 0x0031179C
	private void DBHJBGHNKJC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BC6 RID: 27590 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator KNENPIFBHME()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BC7 RID: 27591 RVA: 0x00313668 File Offset: 0x00311868
	public void JJKJGBJHABC()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 5)
			{
				AOBJLALDBAA.EHBBFMCILPC.NAHENFMHKAG("areyousure", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 3)
			{
				AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("p", this.textInput.text);
				return;
			}
			AOBJLALDBAA.AGANFKKBPFO().EMOCOKNPEFH("tmo", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BC8 RID: 27592 RVA: 0x003136F4 File Offset: 0x003118F4
	public void Initialize(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.HDKFBJIMKBK();
		this.textInput.SetText("", true);
		this.textTitle.SetText(JIKFCLOHJNN.PFLJLFGCIFB(), true);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.EDBKIGDFBEC();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.EDBKIGDFBEC(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 0)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("player"))
			{
				this.LLEOBLHCNJA = this.OELALBBMILL(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, false);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.AnimateAppearance(BKBCKPMDFOD.animationChoiceMetaAppearFromLeft);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j++)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Character " + text + " not found, replacing with " + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.OELALBBMILL(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.center, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					gameObject2.transform.SetParent(this.characterPivot.transform, false);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.center, false);
				}
				this.OIDNMECILMM.AnimateAppearance(GFEJBOAKPMP.animationChoiceMetaAppearFromRight);
			}
		}
		base.StartCoroutine(this.CJAHEBHPJDB());
	}

	// Token: 0x06006BC9 RID: 27593 RVA: 0x00313A38 File Offset: 0x00311C38
	private void LAPDFFGEDMH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BCA RID: 27594 RVA: 0x00313B04 File Offset: 0x00311D04
	public void ODPHJGEDKAA()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.FILDBDMENPG().NDGJNPBPCAF("' (", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.BIAEAOMHBMM().NEKAFJIEGHG("`", this.textInput.text);
				return;
			}
			AOBJLALDBAA.FILDBDMENPG().AKILMNPJGGM("ablpt", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BCB RID: 27595 RVA: 0x00313B8F File Offset: 0x00311D8F
	private void KGENGPOFIEL()
	{
		this.AKILOCOMHCD();
	}

	// Token: 0x06006BCC RID: 27596 RVA: 0x00313B97 File Offset: 0x00311D97
	public void DisappearAnimation()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(0f, 0.5f);
		}
	}

	// Token: 0x06006BCD RID: 27597 RVA: 0x00313BC0 File Offset: 0x00311DC0
	private void NAKFGFJPBBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BCE RID: 27598 RVA: 0x00313C8B File Offset: 0x00311E8B
	public void DCGNBLKDHNH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(797f, 1700f);
		}
	}

	// Token: 0x06006BCF RID: 27599 RVA: 0x00313CB1 File Offset: 0x00311EB1
	public void MFHIDMJGONK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1162f, 1948f);
		}
	}

	// Token: 0x06006BD0 RID: 27600 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator AFBNCMPEFLC()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006BD1 RID: 27601 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string MKEEOLJJOGP()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BD2 RID: 27602 RVA: 0x00313CD8 File Offset: 0x00311ED8
	private CharacterRenderTexturePool.AHLNEABNMOA OCBECAALNHF(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.GDAPPDLIBME(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006BD3 RID: 27603 RVA: 0x00313D4C File Offset: 0x00311F4C
	public void OnEndEdit()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnDialogReadInputEndEdit", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnDialogReadInputEndEdit", this.textInput.text);
				return;
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnDialogReadInputEndEdit", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BD4 RID: 27604 RVA: 0x00003E52 File Offset: 0x00002052
	private void CEDGALPCOLA()
	{
	}

	// Token: 0x06006BD5 RID: 27605 RVA: 0x00313DD8 File Offset: 0x00311FD8
	public void OHLAMMHADGH()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.FILDBDMENPG().IDEALDBPGJE("/", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.DBLAIDPICIG().FLLPDFLFEDA("OnSkinShopClose", this.textInput.text);
				return;
			}
			AOBJLALDBAA.FILDBDMENPG().NEKAFJIEGHG("story", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BD6 RID: 27606 RVA: 0x00313E63 File Offset: 0x00312063
	private void AALDINEPEHJ()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 547f;
		}
	}

	// Token: 0x06006BD7 RID: 27607 RVA: 0x00313E94 File Offset: 0x00312094
	private void NKFOENJFIBJ()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BD8 RID: 27608 RVA: 0x00313F5F File Offset: 0x0031215F
	private void BDFBILJIHGE()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1747f, 1660f);
		}
	}

	// Token: 0x06006BD9 RID: 27609 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06006BDA RID: 27610 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string ILGKDIGKIME()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BDB RID: 27611 RVA: 0x00313F88 File Offset: 0x00312188
	public void BAJPFMHGJIN()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.CEGAOMEEFBE().FIJKIAKDCNO("), currency price only", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.KKPFOJMAONG().NEKAFJIEGHG("+", this.textInput.text);
				return;
			}
			AOBJLALDBAA.KKPFOJMAONG().EMOCOKNPEFH("SceneLobbyManager2.OnRewardSubsequentEpisodeClick() getting one random out of ", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BDC RID: 27612 RVA: 0x00314013 File Offset: 0x00312213
	private void CPHKLKGJEBH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 59f;
		}
	}

	// Token: 0x06006BDD RID: 27613 RVA: 0x00314044 File Offset: 0x00312244
	private void AKILOCOMHCD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(453f, 103f);
		}
	}

	// Token: 0x06006BDE RID: 27614 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOJMIFNKDFF()
	{
	}

	// Token: 0x06006BDF RID: 27615 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string PFAONDEDAIJ()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BE0 RID: 27616 RVA: 0x0031406A File Offset: 0x0031226A
	private void FGJEJGKOLON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(864f, 1402f);
		}
	}

	// Token: 0x06006BE1 RID: 27617 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator LGJEACKMNLF()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BE2 RID: 27618 RVA: 0x00314090 File Offset: 0x00312290
	public void HPKILNBJCPH(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.GHLIAECIGCN();
		this.textInput.SetText("SceneLobbyManager2.PreInitializeAssetBundleFolder(): AssetsManager.Instance.IsBusy()", false);
		this.textTitle.SetText(JIKFCLOHJNN.MEENKNOEDCH(), true);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.PDIOAFCONPB();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("storyloaderr4", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.FBNLCPKDIDP(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 1)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("OnBackendGetPublicProfileException"))
			{
				this.LLEOBLHCNJA = this.OHKKCMIIPIO(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
					gameObject.transform.SetParent(this.characterPivot.transform, false);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.DMMKJDHCNKM(BKBCKPMDFOD.animationStoryAppearFromLeft);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i += 0)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j++)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("OnFriendsCurrencyPopupCollect" + text + "exception while starting: " + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.GMDEBBAMILN(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, true);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, true);
				}
				this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryAppearFromRight);
			}
		}
		base.StartCoroutine(this.AFBNCMPEFLC());
	}

	// Token: 0x06006BE3 RID: 27619 RVA: 0x003143D4 File Offset: 0x003125D4
	private void MKBADGCCNDJ()
	{
		this.FGJEJGKOLON();
	}

	// Token: 0x06006BE4 RID: 27620 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string LEAAGDOPCAH()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BE5 RID: 27621 RVA: 0x003143DC File Offset: 0x003125DC
	private void ICDHNPPEONB()
	{
		this.DEEOCEJFDEP();
	}

	// Token: 0x06006BE6 RID: 27622 RVA: 0x003143E4 File Offset: 0x003125E4
	private CharacterRenderTexturePool.AHLNEABNMOA AEHFKFDGLFJ(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.KOIEENLPADG(component, component);
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

	// Token: 0x06006BE8 RID: 27624 RVA: 0x00314464 File Offset: 0x00312664
	private void DLKPPJDKPFN()
	{
		this.PECLKIDFCKC();
	}

	// Token: 0x06006BE9 RID: 27625 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string EICFPKGFEML()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BEA RID: 27626 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string KONALOBDHPH()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006BEB RID: 27627 RVA: 0x00314464 File Offset: 0x00312664
	private void HDAHJCCAIAP()
	{
		this.PECLKIDFCKC();
	}

	// Token: 0x06006BEC RID: 27628 RVA: 0x0031446C File Offset: 0x0031266C
	private void EKPBNJABLMI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(271f, 553f);
		}
	}

	// Token: 0x06006BED RID: 27629 RVA: 0x003133C2 File Offset: 0x003115C2
	private void ILBAMCJFAAP()
	{
		this.GPGCCIIOKON();
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x00314464 File Offset: 0x00312664
	private void IKAAMMNIPGI()
	{
		this.PECLKIDFCKC();
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x00314494 File Offset: 0x00312694
	private void JPPBJKKNIED()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x0031455F File Offset: 0x0031275F
	private void APLBAENGMJH()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1913f;
		}
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator CCDOFEINKJH()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BF3 RID: 27635 RVA: 0x00314590 File Offset: 0x00312790
	private void PECLKIDFCKC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(935f, 829f);
		}
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x003145B8 File Offset: 0x003127B8
	private void MGOMPPDOPOA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x00314683 File Offset: 0x00312883
	private void LPCKKJNJJCB()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 1527f;
		}
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x003146B4 File Offset: 0x003128B4
	private void OCBDGGMOKDE()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 380f;
		}
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x003146E8 File Offset: 0x003128E8
	public void MGBEACPCBMJ()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.FILDBDMENPG().OIMGLKLHNMO("socialJoinRequest", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 0)
			{
				AOBJLALDBAA.DBLAIDPICIG().NAHENFMHKAG("–", this.textInput.text);
				return;
			}
			AOBJLALDBAA.EHBBFMCILPC.NAHENFMHKAG("", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x00314774 File Offset: 0x00312974
	private void JIJNNDHINGK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x0031483F File Offset: 0x00312A3F
	private void HDKFBJIMKBK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1f, 0.4f);
		}
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x00314868 File Offset: 0x00312A68
	public void HJMIOBLIDKA(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.AEIJBOMICJK();
		this.textInput.SetText("CLIENT.SCREEN.REWARD.", true);
		this.textTitle.SetText(JIKFCLOHJNN.JPAAHBEBNEC(), false);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.BGLKDCCEHAD();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("StoriesSearchBalance - duplicate concept '", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.JLAMNAEBCPD(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 1)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals(""))
			{
				this.LLEOBLHCNJA = this.BCEJPNIOMHN(false);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
					gameObject.transform.SetParent(this.characterPivot.transform, true);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.DMMKJDHCNKM(BKBCKPMDFOD.animationChoiceMetaAppearFromLeft);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j += 0)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("OnDialogReadInputEndEdit" + text + "EmotionLoopManager.RegisterEmotionLoop(): Input data is invalid." + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.GMDEBBAMILN(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, true);
				}
				this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryDisappearToLeft);
			}
		}
		base.StartCoroutine(this.OFLNPMPOCKF());
	}

	// Token: 0x06006BFB RID: 27643 RVA: 0x00314BAC File Offset: 0x00312DAC
	public void OCOOJNFJJPG(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.BDFBILJIHGE();
		this.textInput.SetText("timeoutwarning", false);
		this.textTitle.SetText(JIKFCLOHJNN.ENBOPDDODLK(), false);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.GCBPOHCEHGK();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText(" ", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.PJILBBMIDDE(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 1)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("p"))
			{
				this.LLEOBLHCNJA = this.LFBPIMLMFBK(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, true);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.FMPHMPABPKB(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.NOHNKCNODDN(BKBCKPMDFOD.animationStoryAppearFromLeft);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "featurenotavailable"))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i += 0)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j += 0)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("OnStoryChoiceClick" + text + "releasedchapterscount" + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.FIFNBBALBBE(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleLeft);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
					gameObject2.transform.SetParent(this.characterPivot.transform, false);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, true);
				}
				this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationChoiceMetaAppear);
			}
		}
		base.StartCoroutine(this.NGJMDIEHDGJ());
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator MBECDNCKKED()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006BFD RID: 27645 RVA: 0x00314EF0 File Offset: 0x003130F0
	private void OBONEJJNGMK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006BFE RID: 27646 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator KKFBHAKIPJF()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006BFF RID: 27647 RVA: 0x00314FBC File Offset: 0x003131BC
	public void LLGLLCMPDGK()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.KKPFOJMAONG().EMOCOKNPEFH("smsrc", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 2)
			{
				AOBJLALDBAA.AGANFKKBPFO().FIJKIAKDCNO("", this.textInput.text);
				return;
			}
			AOBJLALDBAA.NMGMNAKLLMI().BDEMEIKEJHF("post", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C00 RID: 27648 RVA: 0x00315048 File Offset: 0x00313248
	public void GLJCKEFBGBJ()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 3)
			{
				AOBJLALDBAA.CEGAOMEEFBE().EGELHPJBAIC("analogglitch", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.BIAEAOMHBMM().HPIPBMEMOFK("ok", this.textInput.text);
				return;
			}
			AOBJLALDBAA.DBLAIDPICIG().NAHENFMHKAG("", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C01 RID: 27649 RVA: 0x003150D3 File Offset: 0x003132D3
	private void JFFNFDKBMGP()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 440f;
		}
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator MLBHKNFHMIC()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x00315104 File Offset: 0x00313304
	private void JGDLPGEJGEM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x003151D0 File Offset: 0x003133D0
	public void KCCOADJOIIE()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 6)
			{
				AOBJLALDBAA.EHBBFMCILPC.IDEALDBPGJE("", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 7)
			{
				AOBJLALDBAA.BIAEAOMHBMM().AKILMNPJGGM("OnBackendRequestSendMessageSuccess", this.textInput.text);
				return;
			}
			AOBJLALDBAA.DBLAIDPICIG().FLLPDFLFEDA("uid", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x0031525C File Offset: 0x0031345C
	public void FCLGMEBCNBD()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 5)
			{
				AOBJLALDBAA.NMGMNAKLLMI().HPIPBMEMOFK("null", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("null", this.textInput.text);
				return;
			}
			AOBJLALDBAA.KKPFOJMAONG().PMDEKGAFCCL("OnSaveSlotDuplicateRequested", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x003152E8 File Offset: 0x003134E8
	private CharacterRenderTexturePool.AHLNEABNMOA LFBPIMLMFBK(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.JLJJGLCLLLE(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006C07 RID: 27655 RVA: 0x0031535C File Offset: 0x0031355C
	private CharacterRenderTexturePool.AHLNEABNMOA CKLKIELJMCK(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
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

	// Token: 0x06006C08 RID: 27656 RVA: 0x003153D0 File Offset: 0x003135D0
	public void NABADENNICC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(759f, 394f);
		}
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string HCJFLDELOAN()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x003153F6 File Offset: 0x003135F6
	private void LFHFJDOJGGB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(74f, 700f);
		}
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x0031541C File Offset: 0x0031361C
	private CharacterRenderTexturePool.AHLNEABNMOA BNCAINIPNCK(bool EJLNKLNPBPJ)
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

	// Token: 0x06006C0C RID: 27660 RVA: 0x00315490 File Offset: 0x00313690
	public void AFKNJILCGNO()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.AGANFKKBPFO().BDEMEIKEJHF("ver", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 7)
			{
				AOBJLALDBAA.EHBBFMCILPC.IDEALDBPGJE("CACHE API", this.textInput.text);
				return;
			}
			AOBJLALDBAA.DBLAIDPICIG().NEKAFJIEGHG("OnBackendStartPlayChapterException", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C0D RID: 27661 RVA: 0x0031551B File Offset: 0x0031371B
	private void INGECOHDDMC()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(690f, 600f);
		}
	}

	// Token: 0x06006C0E RID: 27662 RVA: 0x00315541 File Offset: 0x00313741
	private void GPGCCIIOKON()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(76f, 976f);
		}
	}

	// Token: 0x06006C0F RID: 27663 RVA: 0x00315568 File Offset: 0x00313768
	public void INIIJOLKPBH()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 7)
			{
				AOBJLALDBAA.BIAEAOMHBMM().NAHENFMHKAG("OnFacebookLoginSuccess", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 4)
			{
				AOBJLALDBAA.NMGMNAKLLMI().NDGJNPBPCAF("", this.textInput.text);
				return;
			}
			AOBJLALDBAA.BIAEAOMHBMM().IDEALDBPGJE("sfxsparklesbundles", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C10 RID: 27664 RVA: 0x003155F3 File Offset: 0x003137F3
	private void FBACIBOFHJO()
	{
		this.EKPBNJABLMI();
	}

	// Token: 0x06006C11 RID: 27665 RVA: 0x003155FC File Offset: 0x003137FC
	private void NKAPDJDPPDD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.NFACABIFMBF(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator LCDNDLPKLLI()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006C13 RID: 27667 RVA: 0x00314464 File Offset: 0x00312664
	private void PEEKLFBDFEO()
	{
		this.PECLKIDFCKC();
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDKDMMAMBKP()
	{
	}

	// Token: 0x06006C15 RID: 27669 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator PHFCIAIKOMO()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006C16 RID: 27670 RVA: 0x003156C8 File Offset: 0x003138C8
	public void DOFLEONDCMI(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.DEEOCEJFDEP();
		this.textInput.SetText("cind", false);
		this.textTitle.SetText(JIKFCLOHJNN.LODHPDGOPNB(), false);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.BNCGPHCIDOH();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("ok", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.BGLKDCCEHAD(), true);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 0)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals("</i>"))
			{
				this.LLEOBLHCNJA = this.AEHFKFDGLFJ(false);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, false);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, null);
				}
				this.GOAEECPPHIB.NOHNKCNODDN((BKBCKPMDFOD)8);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "saveslotslocked"))
					{
						for (int i = 1; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 1; j < this.ODNCKIKLFCM[i].mappings.Count; j++)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.ADFCDFHBDAF("Ambigious asset bundle variant chosen because there was no matching active variant: " + text + "cardsvolchancesmsgtitle" + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.JHHDJIIKNNI(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, false);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, true);
				}
				this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryDisappearToLeft);
			}
		}
		base.StartCoroutine(this.NIBILOIHDEE());
	}

	// Token: 0x06006C17 RID: 27671 RVA: 0x00315A0C File Offset: 0x00313C0C
	public void PNMFPLOPKPP()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 0)
			{
				AOBJLALDBAA.EHBBFMCILPC.IDEALDBPGJE("' is not the per-rarity product the tile prices and the store sells (", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 3)
			{
				AOBJLALDBAA.EHBBFMCILPC.OIMGLKLHNMO("openUrlOnClick", this.textInput.text);
				return;
			}
			AOBJLALDBAA.BIAEAOMHBMM().PMDEKGAFCCL("energyhinttitle", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C18 RID: 27672 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string FLKIJCPHPDL()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006C19 RID: 27673 RVA: 0x00315A98 File Offset: 0x00313C98
	private CharacterRenderTexturePool.AHLNEABNMOA FPPACLJHOEI(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
			if (null == this.EBHJLLIHIFE)
			{
				result = null;
			}
			else
			{
				RectTransform component = this.characterPivot.GetComponent<RectTransform>();
				if (EJLNKLNPBPJ)
				{
					result = this.EBHJLLIHIFE.KOIEENLPADG(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.JLJJGLCLLLE(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006C1A RID: 27674 RVA: 0x00315B0C File Offset: 0x00313D0C
	private void LKAJODOFNHF()
	{
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 815f;
		}
	}

	// Token: 0x06006C1B RID: 27675 RVA: 0x00312938 File Offset: 0x00310B38
	private IEnumerator NGJMDIEHDGJ()
	{
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.inputField.ActivateInputField();
		this.inputField.Select();
		yield break;
	}

	// Token: 0x06006C1C RID: 27676 RVA: 0x00315B3D File Offset: 0x00313D3D
	public void NCHPFPLIOOP()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(564f, 1314f);
		}
	}

	// Token: 0x06006C1D RID: 27677 RVA: 0x00315B63 File Offset: 0x00313D63
	public void KHAKLELEBAB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1892f, 1633f);
		}
	}

	// Token: 0x06006C1E RID: 27678 RVA: 0x00003E52 File Offset: 0x00002052
	private void HKJPPMMKGLP()
	{
	}

	// Token: 0x06006C1F RID: 27679 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator NIBILOIHDEE()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006C20 RID: 27680 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string JDLLKGIGMOF()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006C21 RID: 27681 RVA: 0x00315B8C File Offset: 0x00313D8C
	public void NAMMNENAHJI()
	{
		if (this.disablePlaceholderText)
		{
			if (this.textInput.text.Length > 1)
			{
				AOBJLALDBAA.EHBBFMCILPC.FLLPDFLFEDA("ok", this.textInput.text);
				return;
			}
		}
		else
		{
			if (this.textInput.text.Length > 0)
			{
				AOBJLALDBAA.CEGAOMEEFBE().PAODLAFIKBG("passhintundo", this.textInput.text);
				return;
			}
			AOBJLALDBAA.DBLAIDPICIG().HPIPBMEMOFK("genre_lgbtq", this.textPlaceholder.text);
		}
	}

	// Token: 0x06006C22 RID: 27682 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06006C23 RID: 27683 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator OFLNPMPOCKF()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006C24 RID: 27684 RVA: 0x00315C18 File Offset: 0x00313E18
	private CharacterRenderTexturePool.AHLNEABNMOA OHKKCMIIPIO(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.KOIEENLPADG(component, component);
				}
				else
				{
					result = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006C25 RID: 27685 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string INEPGMLBMMG()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006C26 RID: 27686 RVA: 0x00312DAC File Offset: 0x00310FAC
	private IEnumerator MFIKFOABDKM()
	{
		DialogReadInputManager.FKFFAFAANJD fkffafaanjd = new DialogReadInputManager.FKFFAFAANJD(1);
		fkffafaanjd.<>4__this = this;
		return fkffafaanjd;
	}

	// Token: 0x06006C27 RID: 27687 RVA: 0x00315C8C File Offset: 0x00313E8C
	public void BNMPAKBEIKG()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(1591f, 132f);
		}
	}

	// Token: 0x06006C28 RID: 27688 RVA: 0x00315CB2 File Offset: 0x00313EB2
	public void DIKKMLJNAOM()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(503f, 265f);
		}
	}

	// Token: 0x06006C29 RID: 27689 RVA: 0x00315CD8 File Offset: 0x00313ED8
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006C2B RID: 27691 RVA: 0x00315DD4 File Offset: 0x00313FD4
	public void GKIDBNCKGKO(MLGNGCLDHJO JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		base.gameObject.GetComponent<RectTransform>().AHLJBONHHKL(this.NEJLNIBGJGB);
		this.DEEOCEJFDEP();
		this.textInput.SetText("lang", false);
		this.textTitle.SetText(JIKFCLOHJNN.LODHPDGOPNB(), true);
		DialogReadInputManager.FOPDOCCCLAJ = JIKFCLOHJNN.BGLKDCCEHAD();
		if (this.disablePlaceholderText)
		{
			this.textPlaceholder.SetText("OnBackendStartPlayChapterException", true);
		}
		else
		{
			this.textPlaceholder.SetText(JIKFCLOHJNN.HBLIOFABOLD(), false);
		}
		if (JIKFCLOHJNN.MAGJOLHAAHM.Length > 1)
		{
			if (JIKFCLOHJNN.MAGJOLHAAHM.Equals(""))
			{
				this.LLEOBLHCNJA = this.BCEJPNIOMHN(true);
				if (this.LLEOBLHCNJA != null)
				{
					this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
					this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
					this.GOAEECPPHIB.LPIKCMJLDFP(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
					gameObject.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
					gameObject.transform.SetParent(this.characterPivot.transform, true);
					this.GOAEECPPHIB = gameObject.GetComponent<PlayerCharacterManager>();
					this.GOAEECPPHIB.LPIKCMJLDFP(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
				}
				this.GOAEECPPHIB.GMFGEJGJNGA(BKBCKPMDFOD.animationStoryDisappearToLeft);
			}
			else
			{
				string text = JIKFCLOHJNN.MAGJOLHAAHM;
				try
				{
					text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.MAGJOLHAAHM);
					if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "onConversionDataSuccess"))
					{
						for (int i = 0; i < this.ODNCKIKLFCM.Count; i++)
						{
							if (null != this.ODNCKIKLFCM[i])
							{
								for (int j = 0; j < this.ODNCKIKLFCM[i].mappings.Count; j += 0)
								{
									if (this.ODNCKIKLFCM[i].mappings[j].Equals(text))
									{
										DPGJIJGOCIC.PJCLICBPPDA("importanttitle" + text + "ok" + this.ODNCKIKLFCM[i].id);
										text = this.ODNCKIKLFCM[i].id;
										break;
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
				this.DAHDOMMANDF = this.AEHFKFDGLFJ(false);
				if (this.DAHDOMMANDF != null)
				{
					this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
					this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, true);
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
					gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
					gameObject2.transform.SetParent(this.characterPivot.transform, true);
					this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
					this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, false);
				}
				this.OIDNMECILMM.MAHHJBLOJFA((GFEJBOAKPMP)8);
			}
		}
		base.StartCoroutine(this.NGHOJOLFDJN());
	}

	// Token: 0x06006C2C RID: 27692 RVA: 0x00316118 File Offset: 0x00314318
	private CharacterRenderTexturePool.AHLNEABNMOA KBGMNHDGEKI(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006C2D RID: 27693 RVA: 0x0031618C File Offset: 0x0031438C
	private void MOOGCGPMILI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(798f, 914f);
		}
	}

	// Token: 0x06006C2E RID: 27694 RVA: 0x003161B4 File Offset: 0x003143B4
	private void HKELFCJCJHK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		if (null != this.EBHJLLIHIFE)
		{
			if (this.DAHDOMMANDF != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.DAHDOMMANDF);
				this.DAHDOMMANDF = null;
				this.OIDNMECILMM = null;
			}
			if (this.LLEOBLHCNJA != null)
			{
				this.EBHJLLIHIFE.ReleaseSlot(this.LLEOBLHCNJA);
				this.LLEOBLHCNJA = null;
				this.GOAEECPPHIB = null;
			}
		}
		if (null != this.OIDNMECILMM)
		{
			UnityEngine.Object.Destroy(this.OIDNMECILMM);
			this.OIDNMECILMM = null;
		}
		if (null != this.GOAEECPPHIB)
		{
			UnityEngine.Object.Destroy(this.GOAEECPPHIB);
			this.GOAEECPPHIB = null;
		}
		this.ODNCKIKLFCM = null;
	}

	// Token: 0x06006C2F RID: 27695 RVA: 0x00312A30 File Offset: 0x00310C30
	public static string GetPlaceholderText()
	{
		return DialogReadInputManager.FOPDOCCCLAJ;
	}

	// Token: 0x06006C30 RID: 27696 RVA: 0x00316280 File Offset: 0x00314480
	private CharacterRenderTexturePool.AHLNEABNMOA BHLJBNLPNOL(bool EJLNKLNPBPJ)
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
					result = this.EBHJLLIHIFE.AcquireNonPlayerCharacter(component, component);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = null;
		}
		return result;
	}

	// Token: 0x06006C31 RID: 27697 RVA: 0x00313B8F File Offset: 0x00311D8F
	private void OLDLKHFCIHC()
	{
		this.AKILOCOMHCD();
	}

	// Token: 0x06006C32 RID: 27698 RVA: 0x003162F4 File Offset: 0x003144F4
	private CharacterRenderTexturePool.AHLNEABNMOA BCEJPNIOMHN(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
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
					result = this.EBHJLLIHIFE.LJCNENNGBLP(component, component);
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

	// Token: 0x06006C33 RID: 27699 RVA: 0x00316368 File Offset: 0x00314568
	private void IJMPLMMFIEP()
	{
		this.LFHFJDOJGGB();
	}

	// Token: 0x06006C34 RID: 27700 RVA: 0x00316370 File Offset: 0x00314570
	private CharacterRenderTexturePool.AHLNEABNMOA FIFNBBALBBE(bool EJLNKLNPBPJ)
	{
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			this.EBHJLLIHIFE = CharacterRenderTexturePool.ABMBNFFADJJ();
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
					result = this.EBHJLLIHIFE.JLJJGLCLLLE(component, component);
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

	// Token: 0x06006C35 RID: 27701 RVA: 0x003163E4 File Offset: 0x003145E4
	public void GHEBIAJLJIK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOFade(385f, 566f);
		}
	}

	// Token: 0x06006C36 RID: 27702 RVA: 0x00003E52 File Offset: 0x00002052
	private void PBNCKCPKIGE()
	{
	}

	// Token: 0x06006C37 RID: 27703 RVA: 0x0031640C File Offset: 0x0031460C
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

	// Token: 0x04001FBA RID: 8122
	public const string onDialogReadInputEndEdit = "OnDialogReadInputEndEdit";

	// Token: 0x04001FBB RID: 8123
	public const float fadeInTime = 0.4f;

	// Token: 0x04001FBC RID: 8124
	public const float fadeOutTime = 0.5f;

	// Token: 0x04001FBD RID: 8125
	public TextMeshProUGUI textTitle;

	// Token: 0x04001FBE RID: 8126
	public TextMeshProUGUI textPlaceholder;

	// Token: 0x04001FBF RID: 8127
	public TextMeshProUGUI textInput;

	// Token: 0x04001FC0 RID: 8128
	public TMP_InputField inputField;

	// Token: 0x04001FC1 RID: 8129
	public GameObject characterPivot;

	// Token: 0x04001FC2 RID: 8130
	public bool disablePlaceholderText = true;

	// Token: 0x04001FC3 RID: 8131
	private static string FOPDOCCCLAJ = "";

	// Token: 0x04001FC4 RID: 8132
	private NonPlayerCharacterManager OIDNMECILMM;

	// Token: 0x04001FC5 RID: 8133
	private PlayerCharacterManager GOAEECPPHIB;

	// Token: 0x04001FC6 RID: 8134
	private CharacterRenderTexturePool.AHLNEABNMOA LLEOBLHCNJA;

	// Token: 0x04001FC7 RID: 8135
	private CharacterRenderTexturePool.AHLNEABNMOA DAHDOMMANDF;

	// Token: 0x04001FC8 RID: 8136
	private CharacterRenderTexturePool EBHJLLIHIFE;

	// Token: 0x04001FC9 RID: 8137
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001FCA RID: 8138
	private Vector2 NEJLNIBGJGB = new Vector2(0f, 0f);

	// Token: 0x04001FCB RID: 8139
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();
}
