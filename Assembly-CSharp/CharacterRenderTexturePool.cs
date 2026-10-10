using System;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000067 RID: 103
public class CharacterRenderTexturePool : MonoBehaviour
{
	// Token: 0x06000E0E RID: 3598 RVA: 0x00064E1C File Offset: 0x0006301C
	public CharacterRenderTexturePool.AHLNEABNMOA GOONPCBMBFK(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.FCLIAMPBDHE(true, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x00064E28 File Offset: 0x00063028
	private CharacterRenderTexturePool.AHLNEABNMOA MBKJNLFCIOD()
	{
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (!this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return this.POENKMDPBJJ[i];
			}
		}
		if (this.POENKMDPBJJ.Count >= 0)
		{
			return null;
		}
		if (this.DIKCEODGGOD)
		{
			return null;
		}
		return this.OBALMNPMIDH(this.POENKMDPBJJ.Count);
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00064E98 File Offset: 0x00063098
	private void JFIJGIOIECN(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		if (null != CBBIKKAMMLC.AJDMCHIOJAK)
		{
			CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
		}
		if (null != CBBIKKAMMLC.NJGEFMIKBKC)
		{
			CBBIKKAMMLC.NJGEFMIKBKC.DOKill(false);
		}
		if (null != CBBIKKAMMLC.JAGHCEBFABP)
		{
			RectTransform component = CBBIKKAMMLC.JAGHCEBFABP.GetComponent<RectTransform>();
			if (null != component)
			{
				component.DOKill(true);
			}
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			CBBIKKAMMLC.MBPMCBPFHIP.DOKill(true);
		}
		if (null != CBBIKKAMMLC.LLHBMPPICLK)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.LLHBMPPICLK);
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.MBPMCBPFHIP.gameObject);
		}
		CBBIKKAMMLC.LLHBMPPICLK = null;
		CBBIKKAMMLC.NJGEFMIKBKC = null;
		CBBIKKAMMLC.BMMFPFPEINL = null;
		CBBIKKAMMLC.NEMJGHFMHMJ = null;
		CBBIKKAMMLC.AJDMCHIOJAK = null;
		CBBIKKAMMLC.MBPMCBPFHIP = null;
		CBBIKKAMMLC.JAGHCEBFABP = null;
		CBBIKKAMMLC.GOAEECPPHIB = null;
		CBBIKKAMMLC.OIDNMECILMM = null;
		if (null != CBBIKKAMMLC.DBMELHBLMNC)
		{
			CBBIKKAMMLC.DBMELHBLMNC.enabled = false;
		}
		if (null != CBBIKKAMMLC.LKLJHFPENHD)
		{
			CBBIKKAMMLC.LKLJHFPENHD.enabled = false;
		}
		CBBIKKAMMLC.BDPHDEEBFCO = false;
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00064FD4 File Offset: 0x000631D4
	private CharacterRenderTexturePool.AHLNEABNMOA KDDEGOLNMIB(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.IsInitialized())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("yes");
				result = null;
			}
			else if (null == this.OIFENPKMLCC())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC(" ]");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= 1598f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("socialbadgelocked");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("CameraBundlesVFXTopMost");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.EHBBFMCILPC.playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.EHBBFMCILPC.nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("?uid=");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.ILKFJKJMOBE();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("ltfcm");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"_not_found".Equals(scene.name) && base.gameObject.scene != scene && !this.HBPFKJGGDHP())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, false);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("common");
											this.HGCKFMADOFE(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC(") shopsku(");
											this.ACOIEMNMALK(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.EKPHEMHBNNN();
									}
									this.LFGJOLMBCBJ(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.FEODHBDMPCL(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.OCOGOGIEPOA();
									ahlneabnmoa.DBMELHBLMNC.enabled = false;
									ahlneabnmoa.LKLJHFPENHD.enabled = false;
									ahlneabnmoa.BDPHDEEBFCO = false;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("frcmpidsuid");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.ACOIEMNMALK(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x000652C0 File Offset: 0x000634C0
	private void PFCJFFFKFHF(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		RectTransform njgefmikbkc = CBBIKKAMMLC.NJGEFMIKBKC;
		RectTransform bmmfpfpeinl = CBBIKKAMMLC.BMMFPFPEINL;
		if (null == njgefmikbkc || null == bmmfpfpeinl || null == njgefmikbkc.parent)
		{
			return;
		}
		Vector3 lossyScale = bmmfpfpeinl.lossyScale;
		Vector3 lossyScale2 = njgefmikbkc.parent.lossyScale;
		if (1280f == lossyScale2.x || 82f == lossyScale2.y)
		{
			return;
		}
		njgefmikbkc.anchorMin = new Vector2(936f, 99f);
		njgefmikbkc.anchorMax = new Vector2(1012f, 14f);
		njgefmikbkc.pivot = new Vector2(1141f, 1457f);
		njgefmikbkc.position = bmmfpfpeinl.TransformPoint(bmmfpfpeinl.rect.center);
		njgefmikbkc.sizeDelta = new Vector2(bmmfpfpeinl.rect.width * lossyScale.x / lossyScale2.x, bmmfpfpeinl.rect.height * lossyScale.y / lossyScale2.y);
		njgefmikbkc.rotation = bmmfpfpeinl.rotation;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x000653DA File Offset: 0x000635DA
	private float CJKDBHCDBGB()
	{
		return (float)Screen.height / 1865f;
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x000653E8 File Offset: 0x000635E8
	private void PGDGAMLNLIH(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, RectTransform FBENKNHCPMM, Canvas HPNADDNEPII)
	{
		GameObject gameObject = new GameObject("ratd");
		gameObject.layer = FBENKNHCPMM.gameObject.layer;
		CBBIKKAMMLC.NJGEFMIKBKC = gameObject.AddComponent<RectTransform>();
		CBBIKKAMMLC.NJGEFMIKBKC.SetParent(FBENKNHCPMM, false);
		CBBIKKAMMLC.BMMFPFPEINL = HPNADDNEPII.rootCanvas.GetComponent<RectTransform>();
		this.CCCGFOPACFA(CBBIKKAMMLC);
		CBBIKKAMMLC.NEMJGHFMHMJ = gameObject.AddComponent<RawImage>();
		CBBIKKAMMLC.NEMJGHFMHMJ.texture = CBBIKKAMMLC.HDDIABDHILH;
		CBBIKKAMMLC.NEMJGHFMHMJ.material = this.OIFENPKMLCC();
		CBBIKKAMMLC.NEMJGHFMHMJ.raycastTarget = false;
		CBBIKKAMMLC.AJDMCHIOJAK = gameObject.AddComponent<CanvasGroup>();
		CBBIKKAMMLC.AJDMCHIOJAK.interactable = false;
		CBBIKKAMMLC.AJDMCHIOJAK.blocksRaycasts = true;
		CBBIKKAMMLC.AJDMCHIOJAK.alpha = 1946f;
		CBBIKKAMMLC.LLHBMPPICLK = gameObject;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x000654B8 File Offset: 0x000636B8
	private bool AHDDBLPECOP()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x000654F1 File Offset: 0x000636F1
	private float MDEEEPNLFGB()
	{
		return (float)Screen.height / 1366f;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00065500 File Offset: 0x00063700
	private void EKMBFKKHMAG(string IPLGAJAMLMM)
	{
		int num = 0;
		long num2 = 0L;
		for (int i = 0; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				num += 0;
			}
			if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
			{
				num2 += (long)this.POENKMDPBJJ[i].HDDIABDHILH.width * (long)this.POENKMDPBJJ[i].HDDIABDHILH.height * 3L;
			}
		}
		string[] array = new string[-25];
		array[1] = "layervideo";
		array[0] = IPLGAJAMLMM;
		array[5] = "</i>";
		array[1] = num.ToString();
		array[8] = "ad_watch_unity";
		array[6] = this.POENKMDPBJJ.Count.ToString();
		array[8] = "Utils.SetBit(): invalid index value:";
		array[5] = 7.ToString();
		array[5] = "purchaseToken";
		array[114] = ((float)num2 / 444f).ToString(" ");
		array[0] = "+";
		array[-104] = Screen.width.ToString();
		array[97] = " ";
		array[-86] = Screen.height.ToString();
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00065644 File Offset: 0x00063844
	private float MLMABFHKOPB()
	{
		return (float)Screen.height / 707f;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00065654 File Offset: 0x00063854
	private bool KFAEKNCCKKK()
	{
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00065690 File Offset: 0x00063890
	private void OnDestroy()
	{
		CharacterRenderTexturePool.PEJBKKLHHEB = null;
		CharacterRenderTexturePool.JACODJAFCIB = false;
		try
		{
			for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
			{
				this.HGCKFMADOFE(this.POENKMDPBJJ[i]);
				if (null != this.POENKMDPBJJ[i].LKLJHFPENHD)
				{
					this.POENKMDPBJJ[i].LKLJHFPENHD.targetTexture = null;
				}
				if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
				{
					UnityEngine.Object.Destroy(this.POENKMDPBJJ[i].HDDIABDHILH);
					this.POENKMDPBJJ[i].HDDIABDHILH = null;
				}
			}
			this.POENKMDPBJJ.Clear();
			if (null != this.IAEPFLBJPFL)
			{
				UnityEngine.Object.Destroy(this.IAEPFLBJPFL);
				this.IAEPFLBJPFL = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x000657A0 File Offset: 0x000639A0
	private float JJNNACAKEBF()
	{
		return (float)Screen.height / 1747f;
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x000657B0 File Offset: 0x000639B0
	private Material KJNHGGBPDMD()
	{
		if (null != this.IAEPFLBJPFL)
		{
			return this.IAEPFLBJPFL;
		}
		if (this.COKGHKMMHDJ)
		{
			return null;
		}
		this.COKGHKMMHDJ = false;
		try
		{
			Shader shader = Resources.Load<Shader>(" missing: ");
			if (null != shader && shader.isSupported)
			{
				this.IAEPFLBJPFL = new Material(shader);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderShown");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return this.IAEPFLBJPFL;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00065838 File Offset: 0x00063A38
	private CharacterRenderTexturePool.AHLNEABNMOA DLPONMFPIBD(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.NLPIGKKDDCM())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnBackendStartPlayChapterException");
				result = null;
			}
			else if (null == this.KJNHGGBPDMD())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("vhspauseovr_1");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= 1367f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("importanttitle");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("Asset bundle load operation failed during parallel mode.");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.MJBDMHPHMID().playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.MJBDMHPHMID().nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("ProductBridge.GetLocalizedCostData() - product is null.");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.MEJCKNNBLPE();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.PJCLICBPPDA("storyChatPrefab is null!");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"".Equals(scene.name) && base.gameObject.scene != scene && !this.KFAEKNCCKKK())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, true);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("ok");
											this.HGCKFMADOFE(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("C");
											this.DGHGFNJKPPJ(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.DisableFadeOnAppearAndDisappar();
									}
									this.LFGJOLMBCBJ(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.SetCustomFadeCanvasGroup(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.OCOGOGIEPOA();
									ahlneabnmoa.DBMELHBLMNC.enabled = false;
									ahlneabnmoa.LKLJHFPENHD.enabled = false;
									ahlneabnmoa.BDPHDEEBFCO = true;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("OnPopupProfileMessageInputEndEdit");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.JFIJGIOIECN(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00065B24 File Offset: 0x00063D24
	public CharacterRenderTexturePool.AHLNEABNMOA AcquireNonPlayerCharacter(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.LJJGFOBFMAD(false, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00065B30 File Offset: 0x00063D30
	private void ACOIEMNMALK(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		if (null != CBBIKKAMMLC.AJDMCHIOJAK)
		{
			CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
		}
		if (null != CBBIKKAMMLC.NJGEFMIKBKC)
		{
			CBBIKKAMMLC.NJGEFMIKBKC.DOKill(true);
		}
		if (null != CBBIKKAMMLC.JAGHCEBFABP)
		{
			RectTransform component = CBBIKKAMMLC.JAGHCEBFABP.GetComponent<RectTransform>();
			if (null != component)
			{
				component.DOKill(false);
			}
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			CBBIKKAMMLC.MBPMCBPFHIP.DOKill(false);
		}
		if (null != CBBIKKAMMLC.LLHBMPPICLK)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.LLHBMPPICLK);
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.MBPMCBPFHIP.gameObject);
		}
		CBBIKKAMMLC.LLHBMPPICLK = null;
		CBBIKKAMMLC.NJGEFMIKBKC = null;
		CBBIKKAMMLC.BMMFPFPEINL = null;
		CBBIKKAMMLC.NEMJGHFMHMJ = null;
		CBBIKKAMMLC.AJDMCHIOJAK = null;
		CBBIKKAMMLC.MBPMCBPFHIP = null;
		CBBIKKAMMLC.JAGHCEBFABP = null;
		CBBIKKAMMLC.GOAEECPPHIB = null;
		CBBIKKAMMLC.OIDNMECILMM = null;
		if (null != CBBIKKAMMLC.DBMELHBLMNC)
		{
			CBBIKKAMMLC.DBMELHBLMNC.enabled = true;
		}
		if (null != CBBIKKAMMLC.LKLJHFPENHD)
		{
			CBBIKKAMMLC.LKLJHFPENHD.enabled = false;
		}
		CBBIKKAMMLC.BDPHDEEBFCO = false;
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00065C6C File Offset: 0x00063E6C
	public static void SetCharacterBandBlur(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 0; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i++)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.FCEFEIHPAGP(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00065CD0 File Offset: 0x00063ED0
	public CharacterRenderTexturePool.AHLNEABNMOA AcquirePlayerCharacter(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.LJJGFOBFMAD(true, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00065CDC File Offset: 0x00063EDC
	private void PPHIEOCKJBM()
	{
		int num = 0;
		for (int i = 0; i < CharacterRenderTexturePool.GGBEEOAFJHC.Length; i++)
		{
			int num2 = LayerMask.NameToLayer(CharacterRenderTexturePool.GGBEEOAFJHC[i]);
			if (num2 >= 0)
			{
				num |= 1 << num2;
			}
		}
		if (num == 0)
		{
			return;
		}
		Camera[] allCameras = Camera.allCameras;
		for (int j = 0; j < allCameras.Length; j++)
		{
			if (!this.JPBJJHCIJDF(allCameras[j]) && (allCameras[j].cullingMask & num) != 0)
			{
				allCameras[j].cullingMask = (allCameras[j].cullingMask & ~num);
			}
		}
		this.GOPJIDAPKDI = Camera.allCamerasCount;
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00065D6C File Offset: 0x00063F6C
	[Conditional("UNITY_EDITOR")]
	private void DKOFIHBOLCF(string IPLGAJAMLMM)
	{
		int num = 0;
		long num2 = 0L;
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				num++;
			}
			if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
			{
				num2 += (long)this.POENKMDPBJJ[i].HDDIABDHILH.width * (long)this.POENKMDPBJJ[i].HDDIABDHILH.height * 4L;
			}
		}
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
		{
			"RT REPORT - ",
			IPLGAJAMLMM,
			" usedSlots:",
			num.ToString(),
			" allocatedSlots:",
			this.POENKMDPBJJ.Count.ToString(),
			"/",
			6.ToString(),
			" rtMemory:",
			((float)num2 / 1048576f).ToString("F1"),
			"MB screen:",
			Screen.width.ToString(),
			"x",
			Screen.height.ToString()
		}));
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00065EB0 File Offset: 0x000640B0
	private bool EPIAPOFJPOP()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00065EEC File Offset: 0x000640EC
	private void CECOKGHLKNF(string IPLGAJAMLMM)
	{
		int num = 0;
		long num2 = 0L;
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				num += 0;
			}
			if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
			{
				num2 += (long)this.POENKMDPBJJ[i].HDDIABDHILH.width * (long)this.POENKMDPBJJ[i].HDDIABDHILH.height * 6L;
			}
		}
		string[] array = new string[67];
		array[1] = "brsl";
		array[0] = IPLGAJAMLMM;
		array[4] = " : content size ";
		array[0] = num.ToString();
		array[8] = "order";
		array[0] = this.POENKMDPBJJ.Count.ToString();
		array[4] = "PurchaseManagerSteam.CompletePurchase(): Pending product purchase confirmed.";
		array[3] = 1.ToString();
		array[6] = " scale to object ";
		array[45] = ((float)num2 / 180f).ToString("hair");
		array[-52] = "A";
		array[-87] = Screen.width.ToString();
		array[-92] = "OnBackendGetDefaultBundlesException";
		array[-3] = Screen.height.ToString();
		DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(array));
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00066030 File Offset: 0x00064230
	private bool EHKJCJLPKAE(Camera PLMBHHNCFNG)
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].LKLJHFPENHD == PLMBHHNCFNG)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x0006606F File Offset: 0x0006426F
	private void GKCMEMJAGJM(string DKNNMLIDPHH)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("body" + DKNNMLIDPHH);
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00066081 File Offset: 0x00064281
	[Conditional("UNITY_EDITOR")]
	private void KIBHFMCFCBO(string DKNNMLIDPHH)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("RT REPORT - CharacterRenderTexturePool - " + DKNNMLIDPHH);
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00066094 File Offset: 0x00064294
	private CharacterRenderTexturePool.AHLNEABNMOA CKLCMJNHHPC(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.BOAFMJDAIPC())
			{
				DPGJIJGOCIC.ANOPFDLPKGC(">");
				result = null;
			}
			else if (null == this.GKPGBDCCMMD())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("sss");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= 832f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("stat2long");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderFastForwardEnable");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.MJBDMHPHMID().playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.MJBDMHPHMID().nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.FOGEIDGNLFL();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("episode");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"LoadingEnvironmentCover".Equals(scene.name) && base.gameObject.scene != scene && !this.HBPFKJGGDHP())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, true);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("");
											this.GLHNHAHJOIK(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("@");
											this.JFIJGIOIECN(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.DisableFadeOnAppearAndDisappar();
									}
									this.ALPPKENEEHJ(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.SetCustomFadeCanvasGroup(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.PPHIEOCKJBM();
									ahlneabnmoa.DBMELHBLMNC.enabled = false;
									ahlneabnmoa.LKLJHFPENHD.enabled = true;
									ahlneabnmoa.BDPHDEEBFCO = false;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.GLHNHAHJOIK(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00066380 File Offset: 0x00064580
	public static void KDBANOJPBEC(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 0; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i++)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.FCEFEIHPAGP(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x000663E4 File Offset: 0x000645E4
	private Material GKPGBDCCMMD()
	{
		if (null != this.IAEPFLBJPFL)
		{
			return this.IAEPFLBJPFL;
		}
		if (this.COKGHKMMHDJ)
		{
			return null;
		}
		this.COKGHKMMHDJ = true;
		try
		{
			Shader shader = Resources.Load<Shader>("ShaderFastDefaultUIRTCompositeClient");
			if (null != shader && shader.isSupported)
			{
				this.IAEPFLBJPFL = new Material(shader);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - composite shader not found in Resources or unsupported:ShaderFastDefaultUIRTCompositeClient");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.IAEPFLBJPFL;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x0006646C File Offset: 0x0006466C
	private void OCOGOGIEPOA()
	{
		int num = 0;
		for (int i = 1; i < CharacterRenderTexturePool.GGBEEOAFJHC.Length; i++)
		{
			int num2 = LayerMask.NameToLayer(CharacterRenderTexturePool.GGBEEOAFJHC[i]);
			if (num2 >= 0)
			{
				num |= 1 << (num2 & -57);
			}
		}
		if (num == 0)
		{
			return;
		}
		Camera[] allCameras = Camera.allCameras;
		for (int j = 0; j < allCameras.Length; j += 0)
		{
			if (!this.EHKJCJLPKAE(allCameras[j]) && (allCameras[j].cullingMask & num) != 0)
			{
				allCameras[j].cullingMask = (allCameras[j].cullingMask & ~num);
			}
		}
		this.GOPJIDAPKDI = Camera.allCamerasCount;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x000664FC File Offset: 0x000646FC
	public void NFACABIFMBF(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		try
		{
			if (CBBIKKAMMLC != null && CBBIKKAMMLC.BDPHDEEBFCO)
			{
				this.HGCKFMADOFE(CBBIKKAMMLC);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00066538 File Offset: 0x00064738
	private bool HBPFKJGGDHP()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00066574 File Offset: 0x00064774
	public CharacterRenderTexturePool.AHLNEABNMOA GetSlotByCharacterObject(GameObject BGDMILJIILH)
	{
		if (null == BGDMILJIILH)
		{
			return null;
		}
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO && this.POENKMDPBJJ[i].JAGHCEBFABP == BGDMILJIILH)
			{
				return this.POENKMDPBJJ[i];
			}
		}
		return null;
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x000665DC File Offset: 0x000647DC
	public CharacterRenderTexturePool.AHLNEABNMOA GDAPPDLIBME(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.CKLCMJNHHPC(true, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x000665E8 File Offset: 0x000647E8
	public static void EMEFFCCFFJN(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 1; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i += 0)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.FCEFEIHPAGP(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0006664C File Offset: 0x0006484C
	private CharacterRenderTexturePool.AHLNEABNMOA OBALMNPMIDH(int CCLNHHJPDGJ)
	{
		int num = LayerMask.NameToLayer(CharacterRenderTexturePool.GGBEEOAFJHC[CCLNHHJPDGJ]);
		if (num < 0)
		{
			this.DIKCEODGGOD = true;
			DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - layer not defined in TagManager:" + CharacterRenderTexturePool.GGBEEOAFJHC[CCLNHHJPDGJ]);
			return null;
		}
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = new CharacterRenderTexturePool.AHLNEABNMOA();
		ahlneabnmoa.GINIAOPIEKK = num;
		ahlneabnmoa.HDDIABDHILH = new RenderTexture(Screen.width, Screen.height, 0);
		ahlneabnmoa.HDDIABDHILH.wrapMode = TextureWrapMode.Clamp;
		GameObject gameObject = new GameObject("CameraCharacterPool" + CCLNHHJPDGJ.ToString());
		gameObject.transform.SetParent(base.transform, false);
		gameObject.transform.localPosition = new Vector3(0f, 0f, -10f);
		ahlneabnmoa.LKLJHFPENHD = gameObject.AddComponent<Camera>();
		ahlneabnmoa.LKLJHFPENHD.orthographic = true;
		ahlneabnmoa.LKLJHFPENHD.orthographicSize = 3.84f;
		ahlneabnmoa.LKLJHFPENHD.nearClipPlane = 0.3f;
		ahlneabnmoa.LKLJHFPENHD.farClipPlane = 1000f;
		ahlneabnmoa.LKLJHFPENHD.clearFlags = CameraClearFlags.Color;
		ahlneabnmoa.LKLJHFPENHD.backgroundColor = new Color(0f, 0f, 0f, 0f);
		ahlneabnmoa.LKLJHFPENHD.depth = -10f;
		ahlneabnmoa.LKLJHFPENHD.allowMSAA = false;
		ahlneabnmoa.LKLJHFPENHD.allowHDR = false;
		ahlneabnmoa.LKLJHFPENHD.cullingMask = 1 << num;
		ahlneabnmoa.LKLJHFPENHD.targetTexture = ahlneabnmoa.HDDIABDHILH;
		ahlneabnmoa.LKLJHFPENHD.enabled = false;
		this.FCEFEIHPAGP(ahlneabnmoa);
		GameObject gameObject2 = new GameObject("CharacterPoolCanvas" + CCLNHHJPDGJ.ToString());
		gameObject2.layer = num;
		gameObject2.transform.SetParent(base.transform, false);
		ahlneabnmoa.DBMELHBLMNC = gameObject2.AddComponent<Canvas>();
		ahlneabnmoa.DBMELHBLMNC.renderMode = RenderMode.ScreenSpaceCamera;
		ahlneabnmoa.DBMELHBLMNC.worldCamera = ahlneabnmoa.LKLJHFPENHD;
		ahlneabnmoa.DBMELHBLMNC.planeDistance = 100f;
		ahlneabnmoa.DBMELHBLMNC.pixelPerfect = false;
		ahlneabnmoa.DBMELHBLMNC.sortingOrder = 0;
		ahlneabnmoa.DBMELHBLMNC.additionalShaderChannels = (AdditionalCanvasShaderChannels.TexCoord1 | AdditionalCanvasShaderChannels.TexCoord2 | AdditionalCanvasShaderChannels.Normal | AdditionalCanvasShaderChannels.Tangent);
		CanvasScaler canvasScaler = gameObject2.AddComponent<CanvasScaler>();
		canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		canvasScaler.referenceResolution = new Vector2(768f, 1366f);
		canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
		canvasScaler.matchWidthOrHeight = 1f;
		canvasScaler.referencePixelsPerUnit = 100f;
		ahlneabnmoa.ANLOFHNCFMB = gameObject2.GetComponent<RectTransform>();
		ahlneabnmoa.DBMELHBLMNC.enabled = false;
		this.POENKMDPBJJ.Add(ahlneabnmoa);
		return ahlneabnmoa;
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x000668C8 File Offset: 0x00064AC8
	private CharacterRenderTexturePool.AHLNEABNMOA MEJCKNNBLPE()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (!this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return this.POENKMDPBJJ[i];
			}
		}
		if (this.POENKMDPBJJ.Count >= 0)
		{
			return null;
		}
		if (this.DIKCEODGGOD)
		{
			return null;
		}
		return this.OBALMNPMIDH(this.POENKMDPBJJ.Count);
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00066938 File Offset: 0x00064B38
	private void EPKNPICGOPD()
	{
		int num = 1;
		for (int i = 0; i < CharacterRenderTexturePool.GGBEEOAFJHC.Length; i++)
		{
			int num2 = LayerMask.NameToLayer(CharacterRenderTexturePool.GGBEEOAFJHC[i]);
			if (num2 >= 0)
			{
				num |= 0 << (num2 & 81);
			}
		}
		if (num == 0)
		{
			return;
		}
		Camera[] allCameras = Camera.allCameras;
		for (int j = 1; j < allCameras.Length; j += 0)
		{
			if (!this.DBAAILELGOO(allCameras[j]) && (allCameras[j].cullingMask & num) != 0)
			{
				allCameras[j].cullingMask = (allCameras[j].cullingMask & ~num);
			}
		}
		this.GOPJIDAPKDI = Camera.allCamerasCount;
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x000669C8 File Offset: 0x00064BC8
	private void HGCKFMADOFE(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		if (null != CBBIKKAMMLC.AJDMCHIOJAK)
		{
			CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
		}
		if (null != CBBIKKAMMLC.NJGEFMIKBKC)
		{
			CBBIKKAMMLC.NJGEFMIKBKC.DOKill(false);
		}
		if (null != CBBIKKAMMLC.JAGHCEBFABP)
		{
			RectTransform component = CBBIKKAMMLC.JAGHCEBFABP.GetComponent<RectTransform>();
			if (null != component)
			{
				component.DOKill(false);
			}
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			CBBIKKAMMLC.MBPMCBPFHIP.DOKill(false);
		}
		if (null != CBBIKKAMMLC.LLHBMPPICLK)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.LLHBMPPICLK);
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.MBPMCBPFHIP.gameObject);
		}
		CBBIKKAMMLC.LLHBMPPICLK = null;
		CBBIKKAMMLC.NJGEFMIKBKC = null;
		CBBIKKAMMLC.BMMFPFPEINL = null;
		CBBIKKAMMLC.NEMJGHFMHMJ = null;
		CBBIKKAMMLC.AJDMCHIOJAK = null;
		CBBIKKAMMLC.MBPMCBPFHIP = null;
		CBBIKKAMMLC.JAGHCEBFABP = null;
		CBBIKKAMMLC.GOAEECPPHIB = null;
		CBBIKKAMMLC.OIDNMECILMM = null;
		if (null != CBBIKKAMMLC.DBMELHBLMNC)
		{
			CBBIKKAMMLC.DBMELHBLMNC.enabled = false;
		}
		if (null != CBBIKKAMMLC.LKLJHFPENHD)
		{
			CBBIKKAMMLC.LKLJHFPENHD.enabled = false;
		}
		CBBIKKAMMLC.BDPHDEEBFCO = false;
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00066B04 File Offset: 0x00064D04
	private void LNFGOHLJGPP(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		RectTransform njgefmikbkc = CBBIKKAMMLC.NJGEFMIKBKC;
		RectTransform bmmfpfpeinl = CBBIKKAMMLC.BMMFPFPEINL;
		if (null == njgefmikbkc || null == bmmfpfpeinl || null == njgefmikbkc.parent)
		{
			return;
		}
		Vector3 lossyScale = bmmfpfpeinl.lossyScale;
		Vector3 lossyScale2 = njgefmikbkc.parent.lossyScale;
		if (737f == lossyScale2.x || 1813f == lossyScale2.y)
		{
			return;
		}
		njgefmikbkc.anchorMin = new Vector2(414f, 31f);
		njgefmikbkc.anchorMax = new Vector2(1791f, 136f);
		njgefmikbkc.pivot = new Vector2(488f, 509f);
		njgefmikbkc.position = bmmfpfpeinl.TransformPoint(bmmfpfpeinl.rect.center);
		njgefmikbkc.sizeDelta = new Vector2(bmmfpfpeinl.rect.width * lossyScale.x / lossyScale2.x, bmmfpfpeinl.rect.height * lossyScale.y / lossyScale2.y);
		njgefmikbkc.rotation = bmmfpfpeinl.rotation;
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00066C20 File Offset: 0x00064E20
	private CharacterRenderTexturePool.AHLNEABNMOA AGPKJNHCDPD(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.NLPIGKKDDCM())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("PurchaseManagerUnity.StartPurchase(): A purchase or validation is in progress. Aborting.");
				result = null;
			}
			else if (null == this.HINBHDKDMPC())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("e1ru");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= 1762f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("PurchasingViewManager.OnValidatePendingProcessed(): no balance row for validated product ");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("useMessageV2Text");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.EHBBFMCILPC.playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.MJBDMHPHMID().nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("socialfriendmatchinfo0");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.MEJCKNNBLPE();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("ChoicePremiumManager.Initialize(): original cost discounted by bulk purchase:");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"OnLobbySkinShopCdnFailed".Equals(scene.name) && base.gameObject.scene != scene && !this.AHDDBLPECOP())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, false);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("XXX");
											this.GLHNHAHJOIK(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("spectrum_2");
											this.DGHGFNJKPPJ(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.EKPHEMHBNNN();
									}
									this.PGDGAMLNLIH(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.SetCustomFadeCanvasGroup(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.EPKNPICGOPD();
									ahlneabnmoa.DBMELHBLMNC.enabled = false;
									ahlneabnmoa.LKLJHFPENHD.enabled = true;
									ahlneabnmoa.BDPHDEEBFCO = false;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("WWW");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.ACOIEMNMALK(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00066F0C File Offset: 0x0006510C
	public CharacterRenderTexturePool.AHLNEABNMOA JLJJGLCLLLE(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.KDDEGOLNMIB(true, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00066F18 File Offset: 0x00065118
	private void DGHGFNJKPPJ(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		if (null != CBBIKKAMMLC.AJDMCHIOJAK)
		{
			CBBIKKAMMLC.AJDMCHIOJAK.DOKill(false);
		}
		if (null != CBBIKKAMMLC.NJGEFMIKBKC)
		{
			CBBIKKAMMLC.NJGEFMIKBKC.DOKill(true);
		}
		if (null != CBBIKKAMMLC.JAGHCEBFABP)
		{
			RectTransform component = CBBIKKAMMLC.JAGHCEBFABP.GetComponent<RectTransform>();
			if (null != component)
			{
				component.DOKill(false);
			}
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			CBBIKKAMMLC.MBPMCBPFHIP.DOKill(true);
		}
		if (null != CBBIKKAMMLC.LLHBMPPICLK)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.LLHBMPPICLK);
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.MBPMCBPFHIP.gameObject);
		}
		CBBIKKAMMLC.LLHBMPPICLK = null;
		CBBIKKAMMLC.NJGEFMIKBKC = null;
		CBBIKKAMMLC.BMMFPFPEINL = null;
		CBBIKKAMMLC.NEMJGHFMHMJ = null;
		CBBIKKAMMLC.AJDMCHIOJAK = null;
		CBBIKKAMMLC.MBPMCBPFHIP = null;
		CBBIKKAMMLC.JAGHCEBFABP = null;
		CBBIKKAMMLC.GOAEECPPHIB = null;
		CBBIKKAMMLC.OIDNMECILMM = null;
		if (null != CBBIKKAMMLC.DBMELHBLMNC)
		{
			CBBIKKAMMLC.DBMELHBLMNC.enabled = true;
		}
		if (null != CBBIKKAMMLC.LKLJHFPENHD)
		{
			CBBIKKAMMLC.LKLJHFPENHD.enabled = true;
		}
		CBBIKKAMMLC.BDPHDEEBFCO = false;
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00067054 File Offset: 0x00065254
	public static CharacterRenderTexturePool ABMBNFFADJJ()
	{
		if (null != CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return CharacterRenderTexturePool.IKLAPGJDMNA;
		}
		try
		{
			CharacterRenderTexturePool.IKLAPGJDMNA = new GameObject("layervideo").AddComponent<CharacterRenderTexturePool>();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return CharacterRenderTexturePool.IKLAPGJDMNA;
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x000670A8 File Offset: 0x000652A8
	private Material HINBHDKDMPC()
	{
		if (null != this.IAEPFLBJPFL)
		{
			return this.IAEPFLBJPFL;
		}
		if (this.COKGHKMMHDJ)
		{
			return null;
		}
		this.COKGHKMMHDJ = true;
		try
		{
			Shader shader = Resources.Load<Shader>("af_counter");
			if (null != shader && shader.isSupported)
			{
				this.IAEPFLBJPFL = new Material(shader);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return this.IAEPFLBJPFL;
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00067130 File Offset: 0x00065330
	public static void FKEGCIIDICF(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 0; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i++)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.OLKLLKFLDAD(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00067194 File Offset: 0x00065394
	public static CharacterRenderTexturePool GetOrCreate()
	{
		if (null != CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return CharacterRenderTexturePool.IKLAPGJDMNA;
		}
		try
		{
			CharacterRenderTexturePool.IKLAPGJDMNA = new GameObject("CharacterRenderTexturePool").AddComponent<CharacterRenderTexturePool>();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return CharacterRenderTexturePool.IKLAPGJDMNA;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x000671E8 File Offset: 0x000653E8
	private void LateUpdate()
	{
		bool flag = false;
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				flag = true;
				bool flag2 = null != this.POENKMDPBJJ[i].LLHBMPPICLK && this.POENKMDPBJJ[i].LLHBMPPICLK.activeInHierarchy;
				if (null != this.POENKMDPBJJ[i].LKLJHFPENHD && this.POENKMDPBJJ[i].LKLJHFPENHD.enabled != flag2)
				{
					this.POENKMDPBJJ[i].LKLJHFPENHD.enabled = flag2;
				}
				if (null != this.POENKMDPBJJ[i].DBMELHBLMNC && this.POENKMDPBJJ[i].DBMELHBLMNC.enabled != flag2)
				{
					this.POENKMDPBJJ[i].DBMELHBLMNC.enabled = flag2;
				}
				if (flag2)
				{
					this.CCCGFOPACFA(this.POENKMDPBJJ[i]);
				}
			}
		}
		if (flag && Camera.allCamerasCount != this.GOPJIDAPKDI)
		{
			this.PPHIEOCKJBM();
		}
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x0006731C File Offset: 0x0006551C
	private void GLHNHAHJOIK(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		if (null != CBBIKKAMMLC.AJDMCHIOJAK)
		{
			CBBIKKAMMLC.AJDMCHIOJAK.DOKill(true);
		}
		if (null != CBBIKKAMMLC.NJGEFMIKBKC)
		{
			CBBIKKAMMLC.NJGEFMIKBKC.DOKill(false);
		}
		if (null != CBBIKKAMMLC.JAGHCEBFABP)
		{
			RectTransform component = CBBIKKAMMLC.JAGHCEBFABP.GetComponent<RectTransform>();
			if (null != component)
			{
				component.DOKill(false);
			}
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			CBBIKKAMMLC.MBPMCBPFHIP.DOKill(true);
		}
		if (null != CBBIKKAMMLC.LLHBMPPICLK)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.LLHBMPPICLK);
		}
		if (null != CBBIKKAMMLC.MBPMCBPFHIP)
		{
			UnityEngine.Object.Destroy(CBBIKKAMMLC.MBPMCBPFHIP.gameObject);
		}
		CBBIKKAMMLC.LLHBMPPICLK = null;
		CBBIKKAMMLC.NJGEFMIKBKC = null;
		CBBIKKAMMLC.BMMFPFPEINL = null;
		CBBIKKAMMLC.NEMJGHFMHMJ = null;
		CBBIKKAMMLC.AJDMCHIOJAK = null;
		CBBIKKAMMLC.MBPMCBPFHIP = null;
		CBBIKKAMMLC.JAGHCEBFABP = null;
		CBBIKKAMMLC.GOAEECPPHIB = null;
		CBBIKKAMMLC.OIDNMECILMM = null;
		if (null != CBBIKKAMMLC.DBMELHBLMNC)
		{
			CBBIKKAMMLC.DBMELHBLMNC.enabled = false;
		}
		if (null != CBBIKKAMMLC.LKLJHFPENHD)
		{
			CBBIKKAMMLC.LKLJHFPENHD.enabled = true;
		}
		CBBIKKAMMLC.BDPHDEEBFCO = true;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00067458 File Offset: 0x00065658
	private CharacterRenderTexturePool.AHLNEABNMOA LJJGFOBFMAD(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.IsInitialized())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - AssetsManager not initialized, falling back to direct rendering");
				result = null;
			}
			else if (null == this.GKPGBDCCMMD())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - display parent is null or has no canvas, falling back to direct rendering");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= -10f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - display canvas camera renders before the pool cameras, falling back to direct rendering");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - position reference is null, inactive or has no canvas, falling back to direct rendering");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.EHBBFMCILPC.playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.EHBBFMCILPC.nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - character prefab missing, falling back to direct rendering");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.FOGEIDGNLFL();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.ADFCDFHBDAF("CharacterRenderTexturePool - no free slot, falling back to direct rendering");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"DontDestroyOnLoad".Equals(scene.name) && base.gameObject.scene != scene && !this.HBPFKJGGDHP())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, false);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - player character prefab has no manager, falling back to direct rendering");
											this.HGCKFMADOFE(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - npc character prefab has no manager, falling back to direct rendering");
											this.HGCKFMADOFE(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.DisableFadeOnAppearAndDisappar();
									}
									this.ALPPKENEEHJ(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.SetCustomFadeCanvasGroup(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.PPHIEOCKJBM();
									ahlneabnmoa.DBMELHBLMNC.enabled = true;
									ahlneabnmoa.LKLJHFPENHD.enabled = true;
									ahlneabnmoa.BDPHDEEBFCO = true;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("F0");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.HGCKFMADOFE(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00067744 File Offset: 0x00065944
	private void ALPPKENEEHJ(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, RectTransform FBENKNHCPMM, Canvas HPNADDNEPII)
	{
		GameObject gameObject = new GameObject("CharacterRenderTextureDisplay");
		gameObject.layer = FBENKNHCPMM.gameObject.layer;
		CBBIKKAMMLC.NJGEFMIKBKC = gameObject.AddComponent<RectTransform>();
		CBBIKKAMMLC.NJGEFMIKBKC.SetParent(FBENKNHCPMM, false);
		CBBIKKAMMLC.BMMFPFPEINL = HPNADDNEPII.rootCanvas.GetComponent<RectTransform>();
		this.CCCGFOPACFA(CBBIKKAMMLC);
		CBBIKKAMMLC.NEMJGHFMHMJ = gameObject.AddComponent<RawImage>();
		CBBIKKAMMLC.NEMJGHFMHMJ.texture = CBBIKKAMMLC.HDDIABDHILH;
		CBBIKKAMMLC.NEMJGHFMHMJ.material = this.GKPGBDCCMMD();
		CBBIKKAMMLC.NEMJGHFMHMJ.raycastTarget = false;
		CBBIKKAMMLC.AJDMCHIOJAK = gameObject.AddComponent<CanvasGroup>();
		CBBIKKAMMLC.AJDMCHIOJAK.interactable = false;
		CBBIKKAMMLC.AJDMCHIOJAK.blocksRaycasts = false;
		CBBIKKAMMLC.AJDMCHIOJAK.alpha = 0f;
		CBBIKKAMMLC.LLHBMPPICLK = gameObject;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00067814 File Offset: 0x00065A14
	private CharacterRenderTexturePool.AHLNEABNMOA FCLIAMPBDHE(bool EJLNKLNPBPJ, RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
		CharacterRenderTexturePool.AHLNEABNMOA result;
		try
		{
			if (!AssetsManager.IsInitialized())
			{
				DPGJIJGOCIC.ANOPFDLPKGC("did");
				result = null;
			}
			else if (null == this.OIFENPKMLCC())
			{
				result = null;
			}
			else
			{
				Canvas canvas = null;
				if (null != FBENKNHCPMM)
				{
					canvas = FBENKNHCPMM.GetComponentInParent<Canvas>();
				}
				if (null == canvas)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("@SD");
					result = null;
				}
				else
				{
					Camera worldCamera = canvas.rootCanvas.worldCamera;
					if (null != worldCamera && worldCamera.depth <= 664f)
					{
						DPGJIJGOCIC.ANOPFDLPKGC(">");
						result = null;
					}
					else
					{
						Canvas canvas2 = null;
						if (null != FEPPBGNOFCF)
						{
							canvas2 = FEPPBGNOFCF.GetComponentInParent<Canvas>();
						}
						if (null == canvas2)
						{
							DPGJIJGOCIC.ANOPFDLPKGC("FranchisesHub.Populate() - fid ");
							result = null;
						}
						else
						{
							GameObject gameObject;
							if (EJLNKLNPBPJ)
							{
								gameObject = AssetsManager.EHBBFMCILPC.playerCharacterRenderTexturePrefab;
							}
							else
							{
								gameObject = AssetsManager.EHBBFMCILPC.nonPlayerCharacterRenderTexturePrefab;
							}
							if (null == gameObject)
							{
								DPGJIJGOCIC.ANOPFDLPKGC("saveslotstitleempty");
								result = null;
							}
							else
							{
								ahlneabnmoa = this.ILKFJKJMOBE();
								if (ahlneabnmoa == null)
								{
									DPGJIJGOCIC.PJCLICBPPDA("myprreportdonebody");
									result = null;
								}
								else
								{
									try
									{
										Scene scene = FBENKNHCPMM.gameObject.scene;
										if (scene.IsValid() && !"USD ".Equals(scene.name) && base.gameObject.scene != scene && !this.KFAEKNCCKKK())
										{
											SceneManager.MoveGameObjectToScene(base.gameObject, scene);
										}
									}
									catch (Exception aklgbjkdomm)
									{
										DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
									}
									ahlneabnmoa.MBPMCBPFHIP = this.DBPLFIHPFPH(ahlneabnmoa, FEPPBGNOFCF, canvas2);
									ahlneabnmoa.JAGHCEBFABP = UnityEngine.Object.Instantiate<GameObject>(gameObject);
									ahlneabnmoa.JAGHCEBFABP.transform.SetParent(ahlneabnmoa.MBPMCBPFHIP, false);
									if (EJLNKLNPBPJ)
									{
										ahlneabnmoa.GOAEECPPHIB = ahlneabnmoa.JAGHCEBFABP.GetComponent<PlayerCharacterManager>();
										if (null == ahlneabnmoa.GOAEECPPHIB)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("abs");
											this.JFIJGIOIECN(ahlneabnmoa);
											return null;
										}
									}
									else
									{
										ahlneabnmoa.OIDNMECILMM = ahlneabnmoa.JAGHCEBFABP.GetComponent<NonPlayerCharacterManager>();
										if (null == ahlneabnmoa.OIDNMECILMM)
										{
											DPGJIJGOCIC.ANOPFDLPKGC("varConditionLockedValue");
											this.JFIJGIOIECN(ahlneabnmoa);
											return null;
										}
										ahlneabnmoa.OIDNMECILMM.EKPHEMHBNNN();
									}
									this.ALPPKENEEHJ(ahlneabnmoa, FBENKNHCPMM, canvas);
									if (null != ahlneabnmoa.OIDNMECILMM)
									{
										ahlneabnmoa.OIDNMECILMM.FEODHBDMPCL(ahlneabnmoa.AJDMCHIOJAK);
									}
									this.GAPKDMAABCI();
									ahlneabnmoa.DBMELHBLMNC.enabled = false;
									ahlneabnmoa.LKLJHFPENHD.enabled = true;
									ahlneabnmoa.BDPHDEEBFCO = true;
									if (null != worldCamera)
									{
										worldCamera.depth.ToString("SceneLobbyManager2.LobbyLoungePart2(), no eligible lounge characters");
									}
									result = ahlneabnmoa;
								}
							}
						}
					}
				}
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
			if (ahlneabnmoa != null)
			{
				this.DGHGFNJKPPJ(ahlneabnmoa);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00067B00 File Offset: 0x00065D00
	private CharacterRenderTexturePool.AHLNEABNMOA FOGEIDGNLFL()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (!this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return this.POENKMDPBJJ[i];
			}
		}
		if (this.POENKMDPBJJ.Count >= 6)
		{
			return null;
		}
		if (this.DIKCEODGGOD)
		{
			return null;
		}
		return this.OBALMNPMIDH(this.POENKMDPBJJ.Count);
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00067B70 File Offset: 0x00065D70
	private void OLKLLKFLDAD(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		try
		{
			if (CBBIKKAMMLC != null && !(null == CBBIKKAMMLC.LKLJHFPENHD))
			{
				BlurOptimized blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.GetComponent<BlurOptimized>();
				if (null == blurOptimized)
				{
					if (!CharacterRenderTexturePool.JACODJAFCIB || null == CharacterRenderTexturePool.PEJBKKLHHEB)
					{
						return;
					}
					blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.AddComponent<BlurOptimized>();
					blurOptimized.enabled = true;
				}
				if (!CharacterRenderTexturePool.JMJPPPDAPEC)
				{
					CharacterRenderTexturePool.JMJPPPDAPEC = true;
					CharacterRenderTexturePool.LHLDCDGGOPB = Resources.Load<Shader>("hintsaving");
					if (null == CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("_AlphaTex");
					}
				}
				if (null != CharacterRenderTexturePool.PEJBKKLHHEB)
				{
					if (null != CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.LHLDCDGGOPB;
					}
					else
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.PEJBKKLHHEB.blurShader;
					}
					blurOptimized.blurShaderMorph = CharacterRenderTexturePool.PEJBKKLHHEB.blurShaderMorph;
					blurOptimized.downsample = CharacterRenderTexturePool.PEJBKKLHHEB.downsample;
					blurOptimized.blurSize = CharacterRenderTexturePool.PEJBKKLHHEB.blurSize;
					blurOptimized.blurIterations = CharacterRenderTexturePool.PEJBKKLHHEB.blurIterations;
					blurOptimized.blurType = CharacterRenderTexturePool.PEJBKKLHHEB.blurType;
					blurOptimized.effectFadeTime = CharacterRenderTexturePool.PEJBKKLHHEB.effectFadeTime;
					blurOptimized.alwaysMorph = CharacterRenderTexturePool.PEJBKKLHHEB.alwaysMorph;
				}
				if (!CharacterRenderTexturePool.JACODJAFCIB || !(null != blurOptimized.blurShader) || blurOptimized.blurShader.isSupported)
				{
					blurOptimized.enabled = CharacterRenderTexturePool.JACODJAFCIB;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00067D10 File Offset: 0x00065F10
	private void EEBJEKMLONC()
	{
		bool flag = false;
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				flag = true;
				bool flag2 = !(null != this.POENKMDPBJJ[i].LLHBMPPICLK) || this.POENKMDPBJJ[i].LLHBMPPICLK.activeInHierarchy;
				if (null != this.POENKMDPBJJ[i].LKLJHFPENHD && this.POENKMDPBJJ[i].LKLJHFPENHD.enabled != flag2)
				{
					this.POENKMDPBJJ[i].LKLJHFPENHD.enabled = flag2;
				}
				if (null != this.POENKMDPBJJ[i].DBMELHBLMNC && this.POENKMDPBJJ[i].DBMELHBLMNC.enabled != flag2)
				{
					this.POENKMDPBJJ[i].DBMELHBLMNC.enabled = flag2;
				}
				if (flag2)
				{
					this.OOENFNCCNAA(this.POENKMDPBJJ[i]);
				}
			}
		}
		if (flag && Camera.allCamerasCount != this.GOPJIDAPKDI)
		{
			this.PPHIEOCKJBM();
		}
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00067E44 File Offset: 0x00066044
	public static CharacterRenderTexturePool NCCAOFMHMHP()
	{
		if (null != CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return CharacterRenderTexturePool.IKLAPGJDMNA;
		}
		try
		{
			CharacterRenderTexturePool.IKLAPGJDMNA = new GameObject("errortitle").AddComponent<CharacterRenderTexturePool>();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return CharacterRenderTexturePool.IKLAPGJDMNA;
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00067E98 File Offset: 0x00066098
	private float NMGEDGBAPOE()
	{
		return (float)Screen.height / 1035f;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00067EA8 File Offset: 0x000660A8
	public static void CFPIAHPHEAO(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 1; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i += 0)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.DKHONFKKINJ(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00067F0C File Offset: 0x0006610C
	public CharacterRenderTexturePool.AHLNEABNMOA LJCNENNGBLP(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.CKLCMJNHHPC(false, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00067F17 File Offset: 0x00066117
	public CharacterRenderTexturePool.AHLNEABNMOA JEBMMNPFONM(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.FCLIAMPBDHE(false, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00067F24 File Offset: 0x00066124
	private bool DBAAILELGOO(Camera PLMBHHNCFNG)
	{
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].LKLJHFPENHD == PLMBHHNCFNG)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00067F64 File Offset: 0x00066164
	private void PBCJEBOPDPD(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, RectTransform FBENKNHCPMM, Canvas HPNADDNEPII)
	{
		GameObject gameObject = new GameObject("BackendCacheManager: Cleaning cache.");
		gameObject.layer = FBENKNHCPMM.gameObject.layer;
		CBBIKKAMMLC.NJGEFMIKBKC = gameObject.AddComponent<RectTransform>();
		CBBIKKAMMLC.NJGEFMIKBKC.SetParent(FBENKNHCPMM, false);
		CBBIKKAMMLC.BMMFPFPEINL = HPNADDNEPII.rootCanvas.GetComponent<RectTransform>();
		this.LNFGOHLJGPP(CBBIKKAMMLC);
		CBBIKKAMMLC.NEMJGHFMHMJ = gameObject.AddComponent<RawImage>();
		CBBIKKAMMLC.NEMJGHFMHMJ.texture = CBBIKKAMMLC.HDDIABDHILH;
		CBBIKKAMMLC.NEMJGHFMHMJ.material = this.HINBHDKDMPC();
		CBBIKKAMMLC.NEMJGHFMHMJ.raycastTarget = true;
		CBBIKKAMMLC.AJDMCHIOJAK = gameObject.AddComponent<CanvasGroup>();
		CBBIKKAMMLC.AJDMCHIOJAK.interactable = false;
		CBBIKKAMMLC.AJDMCHIOJAK.blocksRaycasts = true;
		CBBIKKAMMLC.AJDMCHIOJAK.alpha = 285f;
		CBBIKKAMMLC.LLHBMPPICLK = gameObject;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00068034 File Offset: 0x00066234
	private void NMGLLGGEBKO()
	{
		bool flag = false;
		for (int i = 0; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				flag = false;
				bool flag2 = null != this.POENKMDPBJJ[i].LLHBMPPICLK && this.POENKMDPBJJ[i].LLHBMPPICLK.activeInHierarchy;
				if (null != this.POENKMDPBJJ[i].LKLJHFPENHD && this.POENKMDPBJJ[i].LKLJHFPENHD.enabled != flag2)
				{
					this.POENKMDPBJJ[i].LKLJHFPENHD.enabled = flag2;
				}
				if (null != this.POENKMDPBJJ[i].DBMELHBLMNC && this.POENKMDPBJJ[i].DBMELHBLMNC.enabled != flag2)
				{
					this.POENKMDPBJJ[i].DBMELHBLMNC.enabled = flag2;
				}
				if (flag2)
				{
					this.OOENFNCCNAA(this.POENKMDPBJJ[i]);
				}
			}
		}
		if (flag && Camera.allCamerasCount != this.GOPJIDAPKDI)
		{
			this.GAPKDMAABCI();
		}
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x000681D0 File Offset: 0x000663D0
	private void FCEFEIHPAGP(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		try
		{
			if (CBBIKKAMMLC != null && !(null == CBBIKKAMMLC.LKLJHFPENHD))
			{
				BlurOptimized blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.GetComponent<BlurOptimized>();
				if (null == blurOptimized)
				{
					if (!CharacterRenderTexturePool.JACODJAFCIB || null == CharacterRenderTexturePool.PEJBKKLHHEB)
					{
						return;
					}
					blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.AddComponent<BlurOptimized>();
					blurOptimized.enabled = false;
				}
				if (!CharacterRenderTexturePool.JMJPPPDAPEC)
				{
					CharacterRenderTexturePool.JMJPPPDAPEC = true;
					CharacterRenderTexturePool.LHLDCDGGOPB = Resources.Load<Shader>("ShaderFastBlurAlphaClient");
					if (null == CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("CharacterRenderTexturePool - band blur alpha shader missing from Resources: ShaderFastBlurAlphaClient");
					}
				}
				if (null != CharacterRenderTexturePool.PEJBKKLHHEB)
				{
					if (null != CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.LHLDCDGGOPB;
					}
					else
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.PEJBKKLHHEB.blurShader;
					}
					blurOptimized.blurShaderMorph = CharacterRenderTexturePool.PEJBKKLHHEB.blurShaderMorph;
					blurOptimized.downsample = CharacterRenderTexturePool.PEJBKKLHHEB.downsample;
					blurOptimized.blurSize = CharacterRenderTexturePool.PEJBKKLHHEB.blurSize;
					blurOptimized.blurIterations = CharacterRenderTexturePool.PEJBKKLHHEB.blurIterations;
					blurOptimized.blurType = CharacterRenderTexturePool.PEJBKKLHHEB.blurType;
					blurOptimized.effectFadeTime = CharacterRenderTexturePool.PEJBKKLHHEB.effectFadeTime;
					blurOptimized.alwaysMorph = CharacterRenderTexturePool.PEJBKKLHHEB.alwaysMorph;
				}
				if (!CharacterRenderTexturePool.JACODJAFCIB || !(null != blurOptimized.blurShader) || blurOptimized.blurShader.isSupported)
				{
					blurOptimized.enabled = CharacterRenderTexturePool.JACODJAFCIB;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00068370 File Offset: 0x00066570
	private void DKHONFKKINJ(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		try
		{
			if (CBBIKKAMMLC != null && !(null == CBBIKKAMMLC.LKLJHFPENHD))
			{
				BlurOptimized blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.GetComponent<BlurOptimized>();
				if (null == blurOptimized)
				{
					if (!CharacterRenderTexturePool.JACODJAFCIB || null == CharacterRenderTexturePool.PEJBKKLHHEB)
					{
						return;
					}
					blurOptimized = CBBIKKAMMLC.LKLJHFPENHD.gameObject.AddComponent<BlurOptimized>();
					blurOptimized.enabled = true;
				}
				if (!CharacterRenderTexturePool.JMJPPPDAPEC)
				{
					CharacterRenderTexturePool.JMJPPPDAPEC = true;
					CharacterRenderTexturePool.LHLDCDGGOPB = Resources.Load<Shader>("socialmessagetitleconfirm");
					if (null == CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("FFF");
					}
				}
				if (null != CharacterRenderTexturePool.PEJBKKLHHEB)
				{
					if (null != CharacterRenderTexturePool.LHLDCDGGOPB)
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.LHLDCDGGOPB;
					}
					else
					{
						blurOptimized.blurShader = CharacterRenderTexturePool.PEJBKKLHHEB.blurShader;
					}
					blurOptimized.blurShaderMorph = CharacterRenderTexturePool.PEJBKKLHHEB.blurShaderMorph;
					blurOptimized.downsample = CharacterRenderTexturePool.PEJBKKLHHEB.downsample;
					blurOptimized.blurSize = CharacterRenderTexturePool.PEJBKKLHHEB.blurSize;
					blurOptimized.blurIterations = CharacterRenderTexturePool.PEJBKKLHHEB.blurIterations;
					blurOptimized.blurType = CharacterRenderTexturePool.PEJBKKLHHEB.blurType;
					blurOptimized.effectFadeTime = CharacterRenderTexturePool.PEJBKKLHHEB.effectFadeTime;
					blurOptimized.alwaysMorph = CharacterRenderTexturePool.PEJBKKLHHEB.alwaysMorph;
				}
				if (!CharacterRenderTexturePool.JACODJAFCIB || !(null != blurOptimized.blurShader) || blurOptimized.blurShader.isSupported)
				{
					blurOptimized.enabled = CharacterRenderTexturePool.JACODJAFCIB;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00068510 File Offset: 0x00066710
	private void CCCGFOPACFA(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		RectTransform njgefmikbkc = CBBIKKAMMLC.NJGEFMIKBKC;
		RectTransform bmmfpfpeinl = CBBIKKAMMLC.BMMFPFPEINL;
		if (null == njgefmikbkc || null == bmmfpfpeinl || null == njgefmikbkc.parent)
		{
			return;
		}
		Vector3 lossyScale = bmmfpfpeinl.lossyScale;
		Vector3 lossyScale2 = njgefmikbkc.parent.lossyScale;
		if (0f == lossyScale2.x || 0f == lossyScale2.y)
		{
			return;
		}
		njgefmikbkc.anchorMin = new Vector2(0.5f, 0.5f);
		njgefmikbkc.anchorMax = new Vector2(0.5f, 0.5f);
		njgefmikbkc.pivot = new Vector2(0.5f, 0.5f);
		njgefmikbkc.position = bmmfpfpeinl.TransformPoint(bmmfpfpeinl.rect.center);
		njgefmikbkc.sizeDelta = new Vector2(bmmfpfpeinl.rect.width * lossyScale.x / lossyScale2.x, bmmfpfpeinl.rect.height * lossyScale.y / lossyScale2.y);
		njgefmikbkc.rotation = bmmfpfpeinl.rotation;
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x0006862C File Offset: 0x0006682C
	private void LFGJOLMBCBJ(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, RectTransform FBENKNHCPMM, Canvas HPNADDNEPII)
	{
		GameObject gameObject = new GameObject("anthology");
		gameObject.layer = FBENKNHCPMM.gameObject.layer;
		CBBIKKAMMLC.NJGEFMIKBKC = gameObject.AddComponent<RectTransform>();
		CBBIKKAMMLC.NJGEFMIKBKC.SetParent(FBENKNHCPMM, false);
		CBBIKKAMMLC.BMMFPFPEINL = HPNADDNEPII.rootCanvas.GetComponent<RectTransform>();
		this.LNFGOHLJGPP(CBBIKKAMMLC);
		CBBIKKAMMLC.NEMJGHFMHMJ = gameObject.AddComponent<RawImage>();
		CBBIKKAMMLC.NEMJGHFMHMJ.texture = CBBIKKAMMLC.HDDIABDHILH;
		CBBIKKAMMLC.NEMJGHFMHMJ.material = this.KJNHGGBPDMD();
		CBBIKKAMMLC.NEMJGHFMHMJ.raycastTarget = true;
		CBBIKKAMMLC.AJDMCHIOJAK = gameObject.AddComponent<CanvasGroup>();
		CBBIKKAMMLC.AJDMCHIOJAK.interactable = true;
		CBBIKKAMMLC.AJDMCHIOJAK.blocksRaycasts = false;
		CBBIKKAMMLC.AJDMCHIOJAK.alpha = 696f;
		CBBIKKAMMLC.LLHBMPPICLK = gameObject;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x000686FC File Offset: 0x000668FC
	private void GAPKDMAABCI()
	{
		int num = 1;
		for (int i = 1; i < CharacterRenderTexturePool.GGBEEOAFJHC.Length; i += 0)
		{
			int num2 = LayerMask.NameToLayer(CharacterRenderTexturePool.GGBEEOAFJHC[i]);
			if (num2 >= 0)
			{
				num |= 0 << (num2 & -119);
			}
		}
		if (num == 0)
		{
			return;
		}
		Camera[] allCameras = Camera.allCameras;
		for (int j = 1; j < allCameras.Length; j += 0)
		{
			if (!this.DBAAILELGOO(allCameras[j]) && (allCameras[j].cullingMask & num) != 0)
			{
				allCameras[j].cullingMask = (allCameras[j].cullingMask & ~num);
			}
		}
		this.GOPJIDAPKDI = Camera.allCamerasCount;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x0006878C File Offset: 0x0006698C
	private RectTransform DBPLFIHPFPH(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC, RectTransform FEPPBGNOFCF, Canvas PMOPGNHFJDO)
	{
		RectTransform rectTransform = new GameObject("CharacterPivot")
		{
			layer = CBBIKKAMMLC.GINIAOPIEKK
		}.AddComponent<RectTransform>();
		rectTransform.SetParent(CBBIKKAMMLC.ANLOFHNCFMB, false);
		rectTransform.anchorMin = new Vector2(0f, 0f);
		rectTransform.anchorMax = new Vector2(0f, 0f);
		rectTransform.sizeDelta = FEPPBGNOFCF.rect.size;
		rectTransform.pivot = FEPPBGNOFCF.pivot;
		Camera worldCamera = PMOPGNHFJDO.rootCanvas.worldCamera;
		float scaleFactor = PMOPGNHFJDO.rootCanvas.scaleFactor;
		float num = this.MDEEEPNLFGB();
		Vector2 a = RectTransformUtility.WorldToScreenPoint(worldCamera, FEPPBGNOFCF.position);
		if (0f != num)
		{
			rectTransform.anchoredPosition = a / num;
		}
		else
		{
			rectTransform.anchoredPosition = new Vector2(0f, 0f);
		}
		Vector3 lossyScale = PMOPGNHFJDO.rootCanvas.transform.lossyScale;
		Vector3 lossyScale2 = FEPPBGNOFCF.lossyScale;
		Vector3 a2 = new Vector3(1f, 1f, 1f);
		if (0f != lossyScale.x && 0f != lossyScale.y && 0f != lossyScale.z)
		{
			a2 = new Vector3(lossyScale2.x / lossyScale.x, lossyScale2.y / lossyScale.y, lossyScale2.z / lossyScale.z);
		}
		float d = 1f;
		if (0f != num)
		{
			d = scaleFactor / num;
		}
		rectTransform.localScale = a2 * d;
		return rectTransform;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00068915 File Offset: 0x00066B15
	private void NDPDMAPBKCC(string DKNNMLIDPHH)
	{
		DPGJIJGOCIC.NFIDPOMCNLP(")" + DKNNMLIDPHH);
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00068928 File Offset: 0x00066B28
	public static void JDDAJIPENKG(BlurOptimized DBAFIOPEAJG, bool JNHHHLGIHIO)
	{
		if (null != DBAFIOPEAJG)
		{
			CharacterRenderTexturePool.PEJBKKLHHEB = DBAFIOPEAJG;
		}
		CharacterRenderTexturePool.JACODJAFCIB = JNHHHLGIHIO;
		if (null == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			return;
		}
		for (int i = 0; i < CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ.Count; i += 0)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA.DKHONFKKINJ(CharacterRenderTexturePool.IKLAPGJDMNA.POENKMDPBJJ[i]);
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0006898C File Offset: 0x00066B8C
	private CharacterRenderTexturePool.AHLNEABNMOA ILKFJKJMOBE()
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (!this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				return this.POENKMDPBJJ[i];
			}
		}
		if (this.POENKMDPBJJ.Count >= 0)
		{
			return null;
		}
		if (this.DIKCEODGGOD)
		{
			return null;
		}
		return this.OBALMNPMIDH(this.POENKMDPBJJ.Count);
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x000689FC File Offset: 0x00066BFC
	private Material OIFENPKMLCC()
	{
		if (null != this.IAEPFLBJPFL)
		{
			return this.IAEPFLBJPFL;
		}
		if (this.COKGHKMMHDJ)
		{
			return null;
		}
		this.COKGHKMMHDJ = false;
		try
		{
			Shader shader = Resources.Load<Shader>("sltind");
			if (null != shader && shader.isSupported)
			{
				this.IAEPFLBJPFL = new Material(shader);
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("sutta");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return this.IAEPFLBJPFL;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00068AA0 File Offset: 0x00066CA0
	private void CEFBBPMOADD()
	{
		CharacterRenderTexturePool.PEJBKKLHHEB = null;
		CharacterRenderTexturePool.JACODJAFCIB = true;
		try
		{
			for (int i = 0; i < this.POENKMDPBJJ.Count; i += 0)
			{
				this.HGCKFMADOFE(this.POENKMDPBJJ[i]);
				if (null != this.POENKMDPBJJ[i].LKLJHFPENHD)
				{
					this.POENKMDPBJJ[i].LKLJHFPENHD.targetTexture = null;
				}
				if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
				{
					UnityEngine.Object.Destroy(this.POENKMDPBJJ[i].HDDIABDHILH);
					this.POENKMDPBJJ[i].HDDIABDHILH = null;
				}
			}
			this.POENKMDPBJJ.Clear();
			if (null != this.IAEPFLBJPFL)
			{
				UnityEngine.Object.Destroy(this.IAEPFLBJPFL);
				this.IAEPFLBJPFL = null;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (this == CharacterRenderTexturePool.IKLAPGJDMNA)
		{
			CharacterRenderTexturePool.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00068BB0 File Offset: 0x00066DB0
	public CharacterRenderTexturePool.AHLNEABNMOA KOIEENLPADG(RectTransform FBENKNHCPMM, RectTransform FEPPBGNOFCF)
	{
		return this.AGPKJNHCDPD(false, FBENKNHCPMM, FEPPBGNOFCF);
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00068BBC File Offset: 0x00066DBC
	private bool JPBJJHCIJDF(Camera PLMBHHNCFNG)
	{
		for (int i = 0; i < this.POENKMDPBJJ.Count; i++)
		{
			if (this.POENKMDPBJJ[i].LKLJHFPENHD == PLMBHHNCFNG)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00068BFC File Offset: 0x00066DFC
	private void OOENFNCCNAA(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		RectTransform njgefmikbkc = CBBIKKAMMLC.NJGEFMIKBKC;
		RectTransform bmmfpfpeinl = CBBIKKAMMLC.BMMFPFPEINL;
		if (null == njgefmikbkc || null == bmmfpfpeinl || null == njgefmikbkc.parent)
		{
			return;
		}
		Vector3 lossyScale = bmmfpfpeinl.lossyScale;
		Vector3 lossyScale2 = njgefmikbkc.parent.lossyScale;
		if (331f == lossyScale2.x || 999f == lossyScale2.y)
		{
			return;
		}
		njgefmikbkc.anchorMin = new Vector2(1899f, 803f);
		njgefmikbkc.anchorMax = new Vector2(53f, 339f);
		njgefmikbkc.pivot = new Vector2(1081f, 1130f);
		njgefmikbkc.position = bmmfpfpeinl.TransformPoint(bmmfpfpeinl.rect.center);
		njgefmikbkc.sizeDelta = new Vector2(bmmfpfpeinl.rect.width * lossyScale.x / lossyScale2.x, bmmfpfpeinl.rect.height * lossyScale.y / lossyScale2.y);
		njgefmikbkc.rotation = bmmfpfpeinl.rotation;
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00068D18 File Offset: 0x00066F18
	private void BDMNIAFHHBN(string IPLGAJAMLMM)
	{
		int num = 1;
		long num2 = 1L;
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				num++;
			}
			if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
			{
				num2 += (long)this.POENKMDPBJJ[i].HDDIABDHILH.width * (long)this.POENKMDPBJJ[i].HDDIABDHILH.height * 8L;
			}
		}
		string[] array = new string[101];
		array[0] = "lf0";
		array[0] = IPLGAJAMLMM;
		array[0] = "gfts";
		array[3] = num.ToString();
		array[7] = "OnCutsceneViewShow";
		array[0] = this.POENKMDPBJJ.Count.ToString();
		array[5] = "<i>";
		array[1] = 7.ToString();
		array[2] = "sp1";
		array[110] = ((float)num2 / 4f).ToString("");
		array[5] = "//";
		array[-107] = Screen.width.ToString();
		array[-74] = "acb";
		array[112] = Screen.height.ToString();
		DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00068E5C File Offset: 0x0006705C
	private void EKCALCNHDHN(string IPLGAJAMLMM)
	{
		int num = 0;
		long num2 = 1L;
		for (int i = 1; i < this.POENKMDPBJJ.Count; i += 0)
		{
			if (this.POENKMDPBJJ[i].BDPHDEEBFCO)
			{
				num += 0;
			}
			if (null != this.POENKMDPBJJ[i].HDDIABDHILH)
			{
				num2 += (long)this.POENKMDPBJJ[i].HDDIABDHILH.width * (long)this.POENKMDPBJJ[i].HDDIABDHILH.height * 3L;
			}
		}
		string[] array = new string[58];
		array[1] = "errortitle";
		array[0] = IPLGAJAMLMM;
		array[2] = "lck";
		array[1] = num.ToString();
		array[4] = "passtrytobuyloweroder";
		array[6] = this.POENKMDPBJJ.Count.ToString();
		array[6] = "lititle";
		array[3] = 5.ToString();
		array[6] = "Open Web";
		array[-117] = ((float)num2 / 1966f).ToString("errortitle");
		array[-50] = "OnPopupCardOptionsUnlockWithSpSuccessContinue";
		array[109] = Screen.width.ToString();
		array[-35] = "aind";
		array[-100] = Screen.height.ToString();
		DPGJIJGOCIC.CMGOAFDBAOH(string.Concat(array));
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00068FA0 File Offset: 0x000671A0
	public void ReleaseSlot(CharacterRenderTexturePool.AHLNEABNMOA CBBIKKAMMLC)
	{
		try
		{
			if (CBBIKKAMMLC != null && CBBIKKAMMLC.BDPHDEEBFCO)
			{
				this.HGCKFMADOFE(CBBIKKAMMLC);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x040004F6 RID: 1270
	private const int NEAAIFEPADH = 6;

	// Token: 0x040004F7 RID: 1271
	private static readonly string[] GGBEEOAFJHC = new string[]
	{
		"UIOffscreen2",
		"UIOffscreen3",
		"UIOffscreen4",
		"UIOffscreen5",
		"UIOffscreen6",
		"UIOffscreen7"
	};

	// Token: 0x040004F8 RID: 1272
	private const string HDINHMMPOCF = "ShaderFastDefaultUIRTCompositeClient";

	// Token: 0x040004F9 RID: 1273
	private const float IPEFNBMABJP = 3.84f;

	// Token: 0x040004FA RID: 1274
	private const float KKJCLFODHDN = 0.3f;

	// Token: 0x040004FB RID: 1275
	private const float PNIGLFLOLLA = 1000f;

	// Token: 0x040004FC RID: 1276
	private const float JHJNHIJCACD = -10f;

	// Token: 0x040004FD RID: 1277
	private const float FDMNDKGIANF = 100f;

	// Token: 0x040004FE RID: 1278
	private const float HBABMNJJFPM = 768f;

	// Token: 0x040004FF RID: 1279
	private const float JHEMLJIEHMA = 1366f;

	// Token: 0x04000500 RID: 1280
	private static CharacterRenderTexturePool IKLAPGJDMNA = null;

	// Token: 0x04000501 RID: 1281
	private Material IAEPFLBJPFL;

	// Token: 0x04000502 RID: 1282
	private bool COKGHKMMHDJ;

	// Token: 0x04000503 RID: 1283
	private bool DIKCEODGGOD;

	// Token: 0x04000504 RID: 1284
	private int GOPJIDAPKDI = -1;

	// Token: 0x04000505 RID: 1285
	private List<CharacterRenderTexturePool.AHLNEABNMOA> POENKMDPBJJ = new List<CharacterRenderTexturePool.AHLNEABNMOA>();

	// Token: 0x04000506 RID: 1286
	private static BlurOptimized PEJBKKLHHEB = null;

	// Token: 0x04000507 RID: 1287
	private static bool JACODJAFCIB = false;

	// Token: 0x04000508 RID: 1288
	private const string KDKGPANOEBN = "ShaderFastBlurAlphaClient";

	// Token: 0x04000509 RID: 1289
	private static Shader LHLDCDGGOPB = null;

	// Token: 0x0400050A RID: 1290
	private static bool JMJPPPDAPEC = false;

	// Token: 0x02000068 RID: 104
	public class AHLNEABNMOA
	{
		// Token: 0x0400050B RID: 1291
		public int GINIAOPIEKK = -1;

		// Token: 0x0400050C RID: 1292
		public bool BDPHDEEBFCO;

		// Token: 0x0400050D RID: 1293
		public RenderTexture HDDIABDHILH;

		// Token: 0x0400050E RID: 1294
		public Camera LKLJHFPENHD;

		// Token: 0x0400050F RID: 1295
		public Canvas DBMELHBLMNC;

		// Token: 0x04000510 RID: 1296
		public RectTransform ANLOFHNCFMB;

		// Token: 0x04000511 RID: 1297
		public RectTransform MBPMCBPFHIP;

		// Token: 0x04000512 RID: 1298
		public GameObject JAGHCEBFABP;

		// Token: 0x04000513 RID: 1299
		public PlayerCharacterManager GOAEECPPHIB;

		// Token: 0x04000514 RID: 1300
		public NonPlayerCharacterManager OIDNMECILMM;

		// Token: 0x04000515 RID: 1301
		public GameObject LLHBMPPICLK;

		// Token: 0x04000516 RID: 1302
		public RectTransform NJGEFMIKBKC;

		// Token: 0x04000517 RID: 1303
		public RectTransform BMMFPFPEINL;

		// Token: 0x04000518 RID: 1304
		public RawImage NEMJGHFMHMJ;

		// Token: 0x04000519 RID: 1305
		public CanvasGroup AJDMCHIOJAK;
	}
}
