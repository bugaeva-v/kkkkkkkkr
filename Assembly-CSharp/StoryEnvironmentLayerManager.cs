using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x020002A1 RID: 673
[ExecuteInEditMode]
public class StoryEnvironmentLayerManager : MonoBehaviour
{
	// Token: 0x060054F6 RID: 21750 RVA: 0x00256CF4 File Offset: 0x00254EF4
	public void ELECAPNEBAA(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 4)
			{
				this.ANMHOOKIOBJ.Emit(0);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 1657.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
					{
						if (!activeSelf && OLALNEIHHOC >= 1846f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 1950f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InOutSine);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 1867f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
			{
				this.ANMOIJKEJBH = 1958f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(1, base.gameObject.name.IndexOf("\""));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("OnBackendPassResourcesChangedType0"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace(" has been unloaded successfully", "ok");
						this.KGFDIIPHOKP.clip = VideoManager.LMCCLMFGEBD().KNDBPOMIOCD(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("@");
						this.KGFDIIPHOKP.prepareCompleted += this.IFGBBMLGOMH;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.CMGOAFDBAOH("nam" + this.EOMLCNKAHCL + "");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.EHBBFMCILPC.GHOBDOMMEOJ(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.FPHICJFMJMJ().GetContainerForVideoClip(this.EOMLCNKAHCL).OJEMIOGPDJE();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "_ColorDrift";
							}
							this.PKCNHJIHHHN = true;
							DPGJIJGOCIC.CMGOAFDBAOH("OnStorySplashManagerAdsProviderAdSuccess" + this.EOMLCNKAHCL + "[Lounge] dual-payment look without a resolvable store price, currency method only: ");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 911f)
						{
							this.JEOOHHADLKO = 362f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("areyousurerestartepbody0" + this.EOMLCNKAHCL + "volcompletedesc");
						base.gameObject.SetActive(true);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x002570C8 File Offset: 0x002552C8
	public CanvasGroup EPEALPOBOHD()
	{
		return this.PANMNKKODPC;
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x002570D0 File Offset: 0x002552D0
	public void Show(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.BAMHPOCKBML();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
			{
				this.ANMHOOKIOBJ.Emit(1);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 0.001)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
					{
						if (!activeSelf && OLALNEIHHOC >= 0f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 0f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InSine);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 0f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
			{
				this.ANMOIJKEJBH = -1f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(0, base.gameObject.name.IndexOf("env"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("video"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("loop", "");
						this.KGFDIIPHOKP.clip = VideoManager.EHBBFMCILPC.SearchContainersForVideoClip(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("loop");
						this.KGFDIIPHOKP.prepareCompleted += this.NGIOBMPNPPN;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.NFIDPOMCNLP("Video: " + this.EOMLCNKAHCL + " preparing!");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.EHBBFMCILPC.GetContainerForVideoClip(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.EHBBFMCILPC.GetContainerForVideoClip(this.EOMLCNKAHCL).GetAssetBundleName();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "";
							}
							this.PKCNHJIHHHN = false;
							DPGJIJGOCIC.NFIDPOMCNLP("Video:" + this.EOMLCNKAHCL + " playing!");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 0f)
						{
							this.JEOOHHADLKO = 0.75f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("Video:" + this.EOMLCNKAHCL + " not found!");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x002574A4 File Offset: 0x002556A4
	public int FJMPAOOMDGK()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.FMNIKCFNNFO() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
		{
			this.KGFDIIPHOKP.Pause();
			return 1;
		}
		return 1;
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x00257518 File Offset: 0x00255718
	private void LBPCHKHFKIK()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.IFGBBMLGOMH;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.NFIDPOMCNLP("..." + this.EOMLCNKAHCL + "OnPurchaseFailed");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x002575C4 File Offset: 0x002557C4
	private void MOHLNGBBIOB()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.HHOBLFCHLGB;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.CMGOAFDBAOH("\"" + this.EOMLCNKAHCL + "usyncs");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x00257670 File Offset: 0x00255870
	public void OMKKOKEAGGE(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = true;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1501f)
		{
			if (OLALNEIHHOC >= 586f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.MPOANKKIKAA));
		}
		else
		{
			this.LLALFKNANDC();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 1)
		{
			this.ANMOIJKEJBH = 1835f;
		}
	}

	// Token: 0x060054FD RID: 21757 RVA: 0x0025770F File Offset: 0x0025590F
	public void PIBKKEMMCBL(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x060054FE RID: 21758 RVA: 0x00257718 File Offset: 0x00255918
	private void JHBKAGKAMAP()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 6)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(false);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 1289f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 1631f)
					{
						try
						{
							AOBJLALDBAA.KKPFOJMAONG().IDEALDBPGJE("OnMusicEnded", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = false;
					}
					if (this.ANMOIJKEJBH < 1276f)
					{
						try
						{
							AOBJLALDBAA.DBLAIDPICIG().FLLPDFLFEDA("aind", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						this.KEGLFLIHIJC(196f, 3f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x060054FF RID: 21759 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void SetLayersSystemVersion(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x06005500 RID: 21760 RVA: 0x002570C8 File Offset: 0x002552C8
	public CanvasGroup GetCanvasGroup()
	{
		return this.PANMNKKODPC;
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x002578F0 File Offset: 0x00255AF0
	private void NEAKAMJNFNJ()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x002578F8 File Offset: 0x00255AF8
	public int PauseVideoIfPlaying()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
		{
			this.KGFDIIPHOKP.Pause();
			return 1;
		}
		return 0;
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x00257969 File Offset: 0x00255B69
	public int NAKBKDAMOCE()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x002578F0 File Offset: 0x00255AF0
	private void PHHELAPHLOK()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x00257971 File Offset: 0x00255B71
	public void DODAGEEMBAP()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 4 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x06005506 RID: 21766 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void FHDHDEEHLLM(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x002579B0 File Offset: 0x00255BB0
	public int FCNBEJDGGMD()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
		{
			this.KGFDIIPHOKP.Pause();
			return 0;
		}
		return 1;
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x00257A24 File Offset: 0x00255C24
	public void AJGCLHKBLIH(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = false;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1267f)
		{
			if (OLALNEIHHOC >= 630f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.PDADJNGLHJJ));
		}
		else
		{
			this.MPOANKKIKAA();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
		{
			this.ANMOIJKEJBH = 120f;
		}
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x00257AC4 File Offset: 0x00255CC4
	public void DFKDHFNMMFK(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 1)
			{
				this.ANMHOOKIOBJ.Emit(0);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 868.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 1)
					{
						if (!activeSelf && OLALNEIHHOC >= 1554f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 791f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.OutSine);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 909f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 6)
			{
				this.ANMOIJKEJBH = 254f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.GHJOJANKGHM() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(0, base.gameObject.name.IndexOf("b_web"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("OnBackendGetFriendMessagingHistoryException"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("sparklesbundles", "XXX");
						this.KGFDIIPHOKP.clip = VideoManager.FPHICJFMJMJ().KCPKDBBIOPK(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("large");
						this.KGFDIIPHOKP.prepareCompleted += this.IFGBBMLGOMH;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.CMGOAFDBAOH("OnChoiceExtendedViewedChoiceChanged" + this.EOMLCNKAHCL + "socialrequestwarnyou2");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.DBFLIEGGGNN().EBLOFHGAEBD(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.LMCCLMFGEBD().LGKACMKJJNJ(this.EOMLCNKAHCL).DOBBBPKDCDA();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "hids";
							}
							this.PKCNHJIHHHN = true;
							DPGJIJGOCIC.NFIDPOMCNLP("sfxtimeoutwarning" + this.EOMLCNKAHCL + "creature");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 142f)
						{
							this.JEOOHHADLKO = 1335f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("OnBackendPremiumChoiceSuccess" + this.EOMLCNKAHCL + "</i>");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x00257E98 File Offset: 0x00256098
	public void HPKIOMOKEDC()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 2 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x0025770F File Offset: 0x0025590F
	public void BGOKOJOBPHJ(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x0600550C RID: 21772 RVA: 0x00257ED4 File Offset: 0x002560D4
	private void OLIACOCGJNA()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 4)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 739f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 875f)
					{
						try
						{
							AOBJLALDBAA.KKPFOJMAONG().IDEALDBPGJE("CLIENT.SCREEN.AVATAR.", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = true;
					}
					if (this.ANMOIJKEJBH < 1289f)
					{
						try
						{
							AOBJLALDBAA.DBLAIDPICIG().PMDEKGAFCCL("saveslotsdelete", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						this.NNDFCMJMAJO(883f, 1082f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void OBBLLEOBHMD(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x0025770F File Offset: 0x0025590F
	public void KGNHEEGIDOE(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x002580A4 File Offset: 0x002562A4
	public void LKBAJAADAHH(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = true;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1003f)
		{
			if (OLALNEIHHOC >= 1531f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.MPOANKKIKAA));
		}
		else
		{
			this.MPOANKKIKAA();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 6)
		{
			this.ANMOIJKEJBH = 1083f;
		}
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x00258144 File Offset: 0x00256344
	private void HHEFDJHIOFA(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("errortitle" + this.EOMLCNKAHCL + "blur");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.OOGPALHPNGM().EBLOFHGAEBD(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.BOFMCPPFAMO().HBNMJMOILCH(this.EOMLCNKAHCL).DOBBBPKDCDA();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "-";
			}
			this.PKCNHJIHHHN = false;
			DPGJIJGOCIC.CMGOAFDBAOH("no" + this.EOMLCNKAHCL + "common");
		}
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void IBDCOMLNHNI(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x00258244 File Offset: 0x00256444
	public int HEONAJJEMHL()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
		{
			this.KGFDIIPHOKP.Pause();
			return 0;
		}
		return 1;
	}

	// Token: 0x06005513 RID: 21779 RVA: 0x002582B8 File Offset: 0x002564B8
	private void IBJBECEPPEO(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("OnBackendRequestFriendAcceptException" + this.EOMLCNKAHCL + "");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.JBMLNGMBICE().DPCLHODAGKO(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.FFLFMNPOCED().HBNMJMOILCH(this.EOMLCNKAHCL).DGFIBGOKKMA();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "";
			}
			this.PKCNHJIHHHN = true;
			DPGJIJGOCIC.CMGOAFDBAOH("ok" + this.EOMLCNKAHCL + "≡");
		}
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x002583B8 File Offset: 0x002565B8
	public void OALDKKKILIB()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.GJPAEPMCADN() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPaused)
		{
			this.KGFDIIPHOKP.Play();
		}
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x0025770F File Offset: 0x0025590F
	public void LALPGAGDOMN(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005516 RID: 21782 RVA: 0x00258428 File Offset: 0x00256628
	public int OHDEDFBDFCJ()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.ACJAKBCPNGI() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
		{
			this.KGFDIIPHOKP.Pause();
			return 0;
		}
		return 0;
	}

	// Token: 0x06005517 RID: 21783 RVA: 0x00257969 File Offset: 0x00255B69
	public int GetOnDemandResourcesCheckpointIndex()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x00257E98 File Offset: 0x00256098
	public void PlayParticles()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 2 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x0025849C File Offset: 0x0025669C
	public void KFLFFOPPNEO(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(false);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 0)
			{
				this.ANMHOOKIOBJ.Emit(1);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 1081.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 5)
					{
						if (!activeSelf && OLALNEIHHOC >= 1636f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 465f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.Unset);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 1342f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
			{
				this.ANMOIJKEJBH = 528f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.NOEBCMMNALO() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(0, base.gameObject.name.IndexOf("XXX"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("OnConsumeEnergySuccess"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("$", "tmdp");
						this.KGFDIIPHOKP.clip = VideoManager.APFOBOLCFJE().PABNKHPKBEN(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("،");
						this.KGFDIIPHOKP.prepareCompleted += this.BEFHNMFBBCA;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.NFIDPOMCNLP("loveInterestsLoungeMappingBalance" + this.EOMLCNKAHCL + "ok");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.PKEINLPIAEH().CDHDCCJGGOH(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.APFOBOLCFJE().IENNDEPKEHN(this.EOMLCNKAHCL).IHFLNEHNLBL();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "_TrashTex";
							}
							this.PKCNHJIHHHN = false;
							DPGJIJGOCIC.CMGOAFDBAOH("OnCutsceneViewShowWI" + this.EOMLCNKAHCL + "$ENVFADESRC");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 1949f)
						{
							this.JEOOHHADLKO = 307f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("/" + this.EOMLCNKAHCL + "ok");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x00258870 File Offset: 0x00256A70
	private void EIJHNJBIIMF(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("isad" + this.EOMLCNKAHCL + "...");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.BOFMCPPFAMO().CDHDCCJGGOH(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.EHBBFMCILPC.IENNDEPKEHN(this.EOMLCNKAHCL).KMKEADANHAA();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "OnPopupProfileNicknameInputCancel";
			}
			this.PKCNHJIHHHN = false;
			DPGJIJGOCIC.CMGOAFDBAOH(" secondary(pending)" + this.EOMLCNKAHCL + "oldvhsovr_2");
		}
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x00258970 File Offset: 0x00256B70
	public void JJFHHPIAANF(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = true;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1574f)
		{
			if (OLALNEIHHOC >= 1855f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.LLALFKNANDC));
		}
		else
		{
			this.PDADJNGLHJJ();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 4)
		{
			this.ANMOIJKEJBH = 791f;
		}
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x00258A10 File Offset: 0x00256C10
	public void KEGLFLIHIJC(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = false;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1687f)
		{
			if (OLALNEIHHOC >= 1231f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.LLALFKNANDC));
		}
		else
		{
			this.MPOANKKIKAA();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 1)
		{
			this.ANMOIJKEJBH = 1617f;
		}
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x00258AB0 File Offset: 0x00256CB0
	private void CDAMEAIIKMG()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
			this.ANMHOOKIOBJ = base.GetComponent<ParticleSystem>();
			try
			{
				if (StoryEnvironmentLayerManager.layersSystemVersion >= 5 && KHPGPLAMAIN.FMNIKCFNNFO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && base.gameObject.name.Contains("releaseTimeline"))
				{
					this.KGFDIIPHOKP = base.gameObject.GetComponent<VideoPlayer>();
					if (null == this.KGFDIIPHOKP)
					{
						this.KGFDIIPHOKP = base.gameObject.AddComponent<VideoPlayer>();
						this.KGFDIIPHOKP.source = VideoSource.Url;
						this.KGFDIIPHOKP.clip = null;
						this.KGFDIIPHOKP.playOnAwake = true;
						this.KGFDIIPHOKP.waitForFirstFrame = false;
						this.KGFDIIPHOKP.isLooping = false;
						this.KGFDIIPHOKP.skipOnDrop = false;
						this.KGFDIIPHOKP.playbackSpeed = 205f;
						this.KGFDIIPHOKP.renderMode = VideoRenderMode.CameraFarPlane;
						this.KGFDIIPHOKP.targetCamera = null;
						this.KGFDIIPHOKP.targetCameraAlpha = 297f;
						this.KGFDIIPHOKP.targetCamera3DLayout = Video3DLayout.No3D;
						if (WideScreenScaler.FICKNODIDKP(908f))
						{
							this.KGFDIIPHOKP.aspectRatio = VideoAspectRatio.NoScaling;
							DPGJIJGOCIC.PJCLICBPPDA("tmo");
						}
						else
						{
							this.KGFDIIPHOKP.aspectRatio = VideoAspectRatio.FitVertically;
						}
						this.KGFDIIPHOKP.audioOutputMode = VideoAudioOutputMode.None;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x00258C48 File Offset: 0x00256E48
	private void LHKGGKDIAEH(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("favstostr" + this.EOMLCNKAHCL + "OnApplicationRestart");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.HEDIEIICOOG().GetContainerForVideoClip(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.HEDIEIICOOG().IENNDEPKEHN(this.EOMLCNKAHCL).MKLOOOMCLPP();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "OnGamePassUnlockContinueToPurchasingScreen";
			}
			this.PKCNHJIHHHN = true;
			DPGJIJGOCIC.NFIDPOMCNLP("TV dots" + this.EOMLCNKAHCL + "yes");
		}
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x00258D46 File Offset: 0x00256F46
	private void LIBECOJEBKI()
	{
		this.CDAMEAIIKMG();
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOJMIFNKDFF()
	{
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x00258D6A File Offset: 0x00256F6A
	public void HGDCENIDOJL()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 0 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x00258DA8 File Offset: 0x00256FA8
	private void IFGBBMLGOMH(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("OnPopupProfileNicknameInputCancel" + this.EOMLCNKAHCL + "");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.EOOPNMILPKG().JAEJKEDLDOD(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.JBMLNGMBICE().DPCLHODAGKO(this.EOMLCNKAHCL).IHFLNEHNLBL();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "XXX";
			}
			this.PKCNHJIHHHN = false;
			DPGJIJGOCIC.NFIDPOMCNLP("onPopupCardOptionsCloseClick" + this.EOMLCNKAHCL + "aind");
		}
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x00258EA8 File Offset: 0x002570A8
	private void PFEIKOLDANA()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(true);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.LHKGGKDIAEH;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.NFIDPOMCNLP("" + this.EOMLCNKAHCL + "ok");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x00258F54 File Offset: 0x00257154
	public void DJKKGMHJFNG(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(false);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 1)
			{
				this.ANMHOOKIOBJ.Emit(1);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 1900.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
					{
						if (!activeSelf && OLALNEIHHOC >= 368f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 232f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InQuad);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 903f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
			{
				this.ANMOIJKEJBH = 1014f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.GHJOJANKGHM() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(1, base.gameObject.name.IndexOf("newpattern"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("socialrequestwarnyou"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("", "spr");
						this.KGFDIIPHOKP.clip = VideoManager.FPHICJFMJMJ().DIILOMJLMOH(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("acliffbw20");
						this.KGFDIIPHOKP.prepareCompleted += this.NGIOBMPNPPN;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.CMGOAFDBAOH("[LoadingEnv] skipped, caching system not ready after " + this.EOMLCNKAHCL + ", direction ");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.FFLFMNPOCED().DPCLHODAGKO(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.BOFMCPPFAMO().EBLOFHGAEBD(this.EOMLCNKAHCL).POFLECNMFNP();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "no";
							}
							this.PKCNHJIHHHN = false;
							DPGJIJGOCIC.CMGOAFDBAOH("layervideo" + this.EOMLCNKAHCL + " dated twice, keeping the first row");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 1967f)
						{
							this.JEOOHHADLKO = 601f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("maxrf" + this.EOMLCNKAHCL + "love");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x0025770F File Offset: 0x0025590F
	public void SetOnDemandResourcesCheckpointIndex(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x00259328 File Offset: 0x00257528
	private void HHOBLFCHLGB(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("bv" + this.EOMLCNKAHCL + "shnts");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.FPHICJFMJMJ().JPMNBGLJBIC(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.LMCCLMFGEBD().GetContainerForVideoClip(this.EOMLCNKAHCL).MKLOOOMCLPP();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "restartepisode";
			}
			this.PKCNHJIHHHN = false;
			DPGJIJGOCIC.CMGOAFDBAOH("var" + this.EOMLCNKAHCL + "Bundles");
		}
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void NFOMCBNIMBB(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x00259428 File Offset: 0x00257628
	private void Update()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(false);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 0f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 2f)
					{
						try
						{
							AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnVideoLayerPlaybackEndsSoon", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = true;
					}
					if (this.ANMOIJKEJBH < 0f)
					{
						try
						{
							AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnVideoLayerAutoHide", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						this.Hide(-1f, 0f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x0600552C RID: 21804 RVA: 0x00259620 File Offset: 0x00257820
	private void NKIEJIHEADI()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.EIJHNJBIIMF;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.CMGOAFDBAOH(") assettitle(" + this.EOMLCNKAHCL + "OnFriendsPopupDeleteClick");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x002596CC File Offset: 0x002578CC
	public void Hide(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = false;
		this.BAMHPOCKBML();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 0.001f)
		{
			if (OLALNEIHHOC >= 0f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.LLALFKNANDC));
		}
		else
		{
			this.LLALFKNANDC();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			this.ANMOIJKEJBH = -1f;
		}
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x0025976C File Offset: 0x0025796C
	private void NGIOBMPNPPN(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.NFIDPOMCNLP("Video:" + this.EOMLCNKAHCL + " prepared!");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.EHBBFMCILPC.GetContainerForVideoClip(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.EHBBFMCILPC.GetContainerForVideoClip(this.EOMLCNKAHCL).GetAssetBundleName();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "";
			}
			this.PKCNHJIHHHN = false;
			DPGJIJGOCIC.NFIDPOMCNLP("Video:" + this.EOMLCNKAHCL + " playing!");
		}
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x00258D46 File Offset: 0x00256F46
	private void FNDDKLJKFEK()
	{
		this.CDAMEAIIKMG();
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x0025986C File Offset: 0x00257A6C
	public void ResumeVideoIfPaused()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPaused)
		{
			this.KGFDIIPHOKP.Play();
		}
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x002598DA File Offset: 0x00257ADA
	public void NAKEJHNDEDI()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 6 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x00259918 File Offset: 0x00257B18
	private void BKFCGNCKFEC()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 5)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.GHJOJANKGHM() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 306f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 1374f)
					{
						try
						{
							AOBJLALDBAA.BIAEAOMHBMM().BDEMEIKEJHF("-", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = true;
					}
					if (this.ANMOIJKEJBH < 138f)
					{
						try
						{
							AOBJLALDBAA.DBLAIDPICIG().EMOCOKNPEFH("low", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						this.OMKKOKEAGGE(1285f, 718f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x00259AE8 File Offset: 0x00257CE8
	private void LLALFKNANDC()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
		{
			this.KGFDIIPHOKP.Stop();
			this.KGFDIIPHOKP.targetCamera = null;
			DPGJIJGOCIC.NFIDPOMCNLP("Video:" + this.EOMLCNKAHCL + " stopping!");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x00257969 File Offset: 0x00255B69
	public int FHKACJNJPCL()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x00259B54 File Offset: 0x00257D54
	public void GOJJHALEGOD(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 8)
			{
				this.ANMHOOKIOBJ.Emit(1);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 720.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
					{
						if (!activeSelf && OLALNEIHHOC >= 1137f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 753f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InOutQuad);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 1427f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 7)
			{
				this.ANMOIJKEJBH = 675f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.FMNIKCFNNFO() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(1, base.gameObject.name.IndexOf("achievdesc"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("continue"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("assetbundlesketchesdata", "errortitle");
						this.KGFDIIPHOKP.clip = VideoManager.APFOBOLCFJE().NHIPBBGIHAA(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("OnPopupProfileLoveInputCancel");
						this.KGFDIIPHOKP.prepareCompleted += this.HHEFDJHIOFA;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.CMGOAFDBAOH("sind" + this.EOMLCNKAHCL + "cdnerror");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.EOOPNMILPKG().FIGFHOCNANF(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.GIPAKOPBBEO().GetContainerForVideoClip(this.EOMLCNKAHCL).DGFIBGOKKMA();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "OnPopupStoryRestartManagerRestartStory1";
							}
							this.PKCNHJIHHHN = false;
							DPGJIJGOCIC.CMGOAFDBAOH("XXX" + this.EOMLCNKAHCL + "ok");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 1017f)
						{
							this.JEOOHHADLKO = 1383f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("Loaded asset bundle:" + this.EOMLCNKAHCL + "tbits2");
						base.gameObject.SetActive(true);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x00259F28 File Offset: 0x00258128
	private void BEFIJFGNNNK()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 1)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 1530f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 483f)
					{
						try
						{
							AOBJLALDBAA.AGANFKKBPFO().IDEALDBPGJE("frcnt", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = false;
					}
					if (this.ANMOIJKEJBH < 405f)
					{
						try
						{
							AOBJLALDBAA.NMGMNAKLLMI().FLLPDFLFEDA("OnNeedToActivateFocusItemCloseButton", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						this.AJGCLHKBLIH(431f, 1434f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x0025A0F8 File Offset: 0x002582F8
	public void NNDFCMJMAJO(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = true;
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 84f)
		{
			if (OLALNEIHHOC >= 99f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.PDADJNGLHJJ));
		}
		else
		{
			this.MPOANKKIKAA();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			this.ANMOIJKEJBH = 1404f;
		}
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x0025A198 File Offset: 0x00258398
	public void CEMMEKGFOIE(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN)
	{
		this.MFMAFGBCLBD = true;
		this.BAMHPOCKBML();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Stop();
		}
		else if (null != this.PANMNKKODPC && JHBAIJIJIBN > 1927f)
		{
			if (OLALNEIHHOC >= 875f)
			{
				this.PANMNKKODPC.alpha = OLALNEIHHOC;
			}
			this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.LLALFKNANDC));
		}
		else
		{
			this.LLALFKNANDC();
		}
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			this.ANMOIJKEJBH = 1703f;
		}
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x0025A238 File Offset: 0x00258438
	private void BEFHNMFBBCA(VideoPlayer INGGFLCCDPD)
	{
		DPGJIJGOCIC.CMGOAFDBAOH("sfxtimeoutwarning" + this.EOMLCNKAHCL + "liveEventId");
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && !this.MFMAFGBCLBD)
		{
			if (null != this.PANMNKKODPC)
			{
				this.PANMNKKODPC.DOPlay();
			}
			this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
			this.KGFDIIPHOKP.Play();
			StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
			if (null != VideoManager.DBFLIEGGGNN().JAEJKEDLDOD(this.EOMLCNKAHCL))
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.KLAKLFCOMJC().FGJFKLHFLLK(this.EOMLCNKAHCL).POFLECNMFNP();
			}
			else
			{
				StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "iapSku";
			}
			this.PKCNHJIHHHN = true;
			DPGJIJGOCIC.NFIDPOMCNLP("cdnerror" + this.EOMLCNKAHCL + "loop");
		}
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x002570C8 File Offset: 0x002552C8
	public CanvasGroup BMGJPCPKCNP()
	{
		return this.PANMNKKODPC;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x0025A338 File Offset: 0x00258538
	public void ECDNEHIKLIH(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.BAMHPOCKBML();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 6)
			{
				this.ANMHOOKIOBJ.Emit(0);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 1025.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 4)
					{
						if (!activeSelf && OLALNEIHHOC >= 1730f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 878f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.Linear);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 235f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 7)
			{
				this.ANMOIJKEJBH = 776f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.GHJOJANKGHM() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(0, base.gameObject.name.IndexOf("aind"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf(""));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("WipeImage", "<i>");
						this.KGFDIIPHOKP.clip = VideoManager.ADHEACMDLJN().NHIPBBGIHAA(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("_NoiseTex");
						this.KGFDIIPHOKP.prepareCompleted += this.NGIOBMPNPPN;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.NFIDPOMCNLP("ext" + this.EOMLCNKAHCL + "/");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.GIPAKOPBBEO().FIGFHOCNANF(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.GIPAKOPBBEO().HBNMJMOILCH(this.EOMLCNKAHCL).GetAssetBundleName();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "YYY";
							}
							this.PKCNHJIHHHN = true;
							DPGJIJGOCIC.NFIDPOMCNLP("" + this.EOMLCNKAHCL + "App42Manager.UpdateUrlPingManagerState(): urlPingManager.StartPing()");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 212f)
						{
							this.JEOOHHADLKO = 1601f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("sslt" + this.EOMLCNKAHCL + "friendsmaxlimitdefault");
						base.gameObject.SetActive(true);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x00258D46 File Offset: 0x00256F46
	private void OLEAIHHFBGB()
	{
		this.CDAMEAIIKMG();
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x002578E8 File Offset: 0x00255AE8
	public static void BKJLLECHAOC(int IALPHEADDFO)
	{
		StoryEnvironmentLayerManager.layersSystemVersion = IALPHEADDFO;
	}

	// Token: 0x0600553F RID: 21823 RVA: 0x0025A70C File Offset: 0x0025890C
	private void LFBPHHOPPBO()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.GJPAEPMCADN() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 701f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 762f)
					{
						try
						{
							AOBJLALDBAA.CEGAOMEEFBE().NEKAFJIEGHG("unknownerror", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = false;
					}
					if (this.ANMOIJKEJBH < 817f)
					{
						try
						{
							AOBJLALDBAA.NMGMNAKLLMI().AKILMNPJGGM("\n<alpha=#C0>...\n", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						this.KEGLFLIHIJC(476f, 890f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x06005540 RID: 21824 RVA: 0x0025A8DC File Offset: 0x00258ADC
	private void PDADJNGLHJJ()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
		{
			this.KGFDIIPHOKP.Stop();
			this.KGFDIIPHOKP.targetCamera = null;
			DPGJIJGOCIC.CMGOAFDBAOH("nomorediamonds" + this.EOMLCNKAHCL + "/");
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x0025A948 File Offset: 0x00258B48
	private void GPHOBCEMEMN()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 2)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.NOEBCMMNALO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 246f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 1687f)
					{
						try
						{
							AOBJLALDBAA.KKPFOJMAONG().IDEALDBPGJE("mypsuspintrobody", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = true;
					}
					if (this.ANMOIJKEJBH < 955f)
					{
						try
						{
							AOBJLALDBAA.KKPFOJMAONG().NAHENFMHKAG("", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
						}
						this.CEMMEKGFOIE(897f, 281f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x00257969 File Offset: 0x00255B69
	public int PAJNKIJOMCE()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x0025AB18 File Offset: 0x00258D18
	private void MPOANKKIKAA()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
		{
			this.KGFDIIPHOKP.Stop();
			this.KGFDIIPHOKP.targetCamera = null;
			DPGJIJGOCIC.CMGOAFDBAOH("asp" + this.EOMLCNKAHCL + "");
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x0025AB84 File Offset: 0x00258D84
	public void DLLNHMLKNKP()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.NKMCPGBKEEP() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPaused)
		{
			this.KGFDIIPHOKP.Play();
		}
	}

	// Token: 0x06005546 RID: 21830 RVA: 0x002570C8 File Offset: 0x002552C8
	public CanvasGroup AAFMGDOIFBM()
	{
		return this.PANMNKKODPC;
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06005548 RID: 21832 RVA: 0x0025770F File Offset: 0x0025590F
	public void EAOFLCLKDOA(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x0600554A RID: 21834 RVA: 0x002578F0 File Offset: 0x00255AF0
	private void Awake()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x0025ABF4 File Offset: 0x00258DF4
	private void LEEEOAHDCJD()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.IBJBECEPPEO;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.CMGOAFDBAOH("OnChapterSnapshotsBackendFetchSuccess2" + this.EOMLCNKAHCL + "retry");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x002570C8 File Offset: 0x002552C8
	public CanvasGroup JCCKAAMKNCA()
	{
		return this.PANMNKKODPC;
	}

	// Token: 0x0600554D RID: 21837 RVA: 0x0025ACA0 File Offset: 0x00258EA0
	private void CFLAPIBHFMO()
	{
		if (Application.isPlaying && StoryEnvironmentLayerManager.layersSystemVersion >= 7)
		{
			if (null != this.ANMHOOKIOBJ && base.gameObject.activeSelf && !this.ANMHOOKIOBJ.isPlaying && this.ANMHOOKIOBJ.particleCount == 0)
			{
				base.gameObject.SetActive(true);
			}
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.NOEBCMMNALO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && !this.MFMAFGBCLBD)
			{
				if (this.ANMOIJKEJBH >= 284f && !this.KGFDIIPHOKP.isLooping && !this.KGFDIIPHOKP.isPaused)
				{
					this.ANMOIJKEJBH -= Time.deltaTime;
					if (!this.PKCNHJIHHHN && this.ANMOIJKEJBH < 1846f)
					{
						try
						{
							AOBJLALDBAA.CEGAOMEEFBE().FLLPDFLFEDA("OnLiveProfileThemesLoaderStart", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
						}
						this.PKCNHJIHHHN = false;
					}
					if (this.ANMOIJKEJBH < 515f)
					{
						try
						{
							AOBJLALDBAA.FILDBDMENPG().EMOCOKNPEFH("yes", base.gameObject.name);
						}
						catch (Exception aklgbjkdomm2)
						{
							DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
						}
						this.CEMMEKGFOIE(893f, 577f, this.JEOOHHADLKO);
					}
				}
				if (null != this.PANMNKKODPC && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPlaying)
				{
					this.KGFDIIPHOKP.targetCameraAlpha = this.PANMNKKODPC.alpha;
				}
			}
		}
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x0025AE70 File Offset: 0x00259070
	private void INJJOHNFBKH()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.LHKGGKDIAEH;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.NFIDPOMCNLP("storyChatPrefab is null!" + this.EOMLCNKAHCL + "error: ");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x0025770F File Offset: 0x0025590F
	public void AONNOIPGDNC(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005550 RID: 21840 RVA: 0x0025AF1C File Offset: 0x0025911C
	public void MOLFJIOCFIC(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(false);
		this.CDAMEAIIKMG();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 2)
			{
				this.ANMHOOKIOBJ.Emit(1);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 1560.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 5)
					{
						if (!activeSelf && OLALNEIHHOC >= 1561f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 1377f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.OutSine);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 135f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 3)
			{
				this.ANMOIJKEJBH = 98f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.NKMCPGBKEEP() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(1, base.gameObject.name.IndexOf("voiceover"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("post"));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("passinfobtntitle", "storyChatPrefab is null!");
						this.KGFDIIPHOKP.clip = VideoManager.EOOPNMILPKG().DCPKDCGLEDN(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("RunCustomCode() repeat:");
						this.KGFDIIPHOKP.prepareCompleted += this.IBJBECEPPEO;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.NFIDPOMCNLP("OnRestartChapterUpsellGetPassNegative" + this.EOMLCNKAHCL + "OnAvatarCollectionRestoreEntry");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.APFOBOLCFJE().GetContainerForVideoClip(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.DBFLIEGGGNN().GetContainerForVideoClip(this.EOMLCNKAHCL).NPEBJNMLEHB();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "";
							}
							this.PKCNHJIHHHN = true;
							DPGJIJGOCIC.CMGOAFDBAOH("" + this.EOMLCNKAHCL + "OnFriendsPopupSendPremClick");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 86f)
						{
							this.JEOOHHADLKO = 1629f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("OnSceneStoryManagerPremiumChoiceAdsProviderAdSuccess" + this.EOMLCNKAHCL + "");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005551 RID: 21841 RVA: 0x0025B2F0 File Offset: 0x002594F0
	public void FDALGKNFCAN(float OLALNEIHHOC, float OHKAFKBOIGJ, float JHBAIJIJIBN, Camera EAGFIJMJLKN, bool PCPPCAEJICE)
	{
		this.MFMAFGBCLBD = PCPPCAEJICE;
		bool activeSelf = base.gameObject.activeSelf;
		base.gameObject.SetActive(true);
		this.BAMHPOCKBML();
		if (null != this.ANMHOOKIOBJ)
		{
			this.ANMHOOKIOBJ.Play();
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 8)
			{
				this.ANMHOOKIOBJ.Emit(0);
			}
		}
		else if (null != this.PANMNKKODPC)
		{
			if (!this.MFMAFGBCLBD)
			{
				if ((double)JHBAIJIJIBN > 551.0)
				{
					if (StoryEnvironmentLayerManager.layersSystemVersion >= 6)
					{
						if (!activeSelf && OLALNEIHHOC >= 466f)
						{
							this.PANMNKKODPC.alpha = OLALNEIHHOC;
						}
					}
					else if (OLALNEIHHOC >= 1531f)
					{
						this.PANMNKKODPC.alpha = OLALNEIHHOC;
					}
					this.PANMNKKODPC.DOFade(OHKAFKBOIGJ, JHBAIJIJIBN).SetEase(Ease.OutSine);
					if (null != this.KGFDIIPHOKP)
					{
						this.PANMNKKODPC.DOPause();
					}
				}
				else
				{
					this.PANMNKKODPC.alpha = OHKAFKBOIGJ;
				}
			}
			else
			{
				this.PANMNKKODPC.alpha = 1516f;
			}
		}
		try
		{
			if (StoryEnvironmentLayerManager.layersSystemVersion >= 4)
			{
				this.ANMOIJKEJBH = 519f;
				if (null != this.KGFDIIPHOKP && null != EAGFIJMJLKN && KHPGPLAMAIN.NKMCPGBKEEP() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL())
				{
					this.ACECOBEMCPI = EAGFIJMJLKN;
					if (null == this.KGFDIIPHOKP.clip)
					{
						this.EOMLCNKAHCL = base.gameObject.name.Substring(1, base.gameObject.name.IndexOf(":"));
						this.EOMLCNKAHCL += base.gameObject.name.Substring(base.gameObject.name.IndexOf("..."));
						this.EOMLCNKAHCL = this.EOMLCNKAHCL.Replace("OnSkinShopCardSelected", "wshcds");
						this.KGFDIIPHOKP.clip = VideoManager.HEDIEIICOOG().GEONJNLDIEI(this.EOMLCNKAHCL);
						this.KGFDIIPHOKP.isLooping = base.gameObject.name.EndsWith("ISBITSET");
						this.KGFDIIPHOKP.prepareCompleted += this.BEFHNMFBBCA;
					}
					if (null != this.KGFDIIPHOKP.clip)
					{
						if (!this.KGFDIIPHOKP.isPrepared)
						{
							this.KGFDIIPHOKP.Prepare();
							DPGJIJGOCIC.NFIDPOMCNLP("stat6" + this.EOMLCNKAHCL + "franchisepattern");
						}
						else if (!this.MFMAFGBCLBD)
						{
							if (null != this.PANMNKKODPC)
							{
								this.PANMNKKODPC.DOPlay();
							}
							this.KGFDIIPHOKP.targetCamera = this.ACECOBEMCPI;
							this.KGFDIIPHOKP.Play();
							StoryEnvironmentLayerManager.lastVideoLayerName = base.gameObject.name;
							if (null != VideoManager.OOGPALHPNGM().IENNDEPKEHN(this.EOMLCNKAHCL))
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = VideoManager.GIPAKOPBBEO().MIKMGELODHJ(this.EOMLCNKAHCL).MKLOOOMCLPP();
							}
							else
							{
								StoryEnvironmentLayerManager.lastVideoLayerAssetBundleName = "anthology";
							}
							this.PKCNHJIHHHN = false;
							DPGJIJGOCIC.CMGOAFDBAOH("Starting non-parallel download:" + this.EOMLCNKAHCL + "socialgiftcollectinfodone");
						}
						this.JEOOHHADLKO = JHBAIJIJIBN;
						if (this.JEOOHHADLKO <= 1298f)
						{
							this.JEOOHHADLKO = 1480f;
						}
						this.ANMOIJKEJBH = (float)this.KGFDIIPHOKP.length - this.JEOOHHADLKO;
					}
					else
					{
						Debug.LogError("DialogItemShownManager.Initialize() - storyItem is null." + this.EOMLCNKAHCL + "OnSceneStoryManagerPremiumChoiceAdsProviderAdFailed");
						base.gameObject.SetActive(false);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005552 RID: 21842 RVA: 0x0025B6C4 File Offset: 0x002598C4
	private void BAMHPOCKBML()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
			this.ANMHOOKIOBJ = base.GetComponent<ParticleSystem>();
			try
			{
				if (StoryEnvironmentLayerManager.layersSystemVersion >= 2 && KHPGPLAMAIN.DFJHJCAIFJO() && !KDCJJBLGCBH.EHBBFMCILPC.KACCIOPAEMI() && base.gameObject.name.Contains("layervideo"))
				{
					this.KGFDIIPHOKP = base.gameObject.GetComponent<VideoPlayer>();
					if (null == this.KGFDIIPHOKP)
					{
						this.KGFDIIPHOKP = base.gameObject.AddComponent<VideoPlayer>();
						this.KGFDIIPHOKP.source = VideoSource.VideoClip;
						this.KGFDIIPHOKP.clip = null;
						this.KGFDIIPHOKP.playOnAwake = false;
						this.KGFDIIPHOKP.waitForFirstFrame = true;
						this.KGFDIIPHOKP.isLooping = false;
						this.KGFDIIPHOKP.skipOnDrop = true;
						this.KGFDIIPHOKP.playbackSpeed = 1f;
						this.KGFDIIPHOKP.renderMode = VideoRenderMode.CameraFarPlane;
						this.KGFDIIPHOKP.targetCamera = null;
						this.KGFDIIPHOKP.targetCameraAlpha = 0f;
						this.KGFDIIPHOKP.targetCamera3DLayout = Video3DLayout.No3D;
						if (WideScreenScaler.ScreenIsTooWide(1640f))
						{
							this.KGFDIIPHOKP.aspectRatio = VideoAspectRatio.FitHorizontally;
							DPGJIJGOCIC.ADFCDFHBDAF("WideScreenScaler(): screen is to wide, video aspect ratio set to: VideoAspectRatio.FitHorizontally");
						}
						else
						{
							this.KGFDIIPHOKP.aspectRatio = VideoAspectRatio.FitVertically;
						}
						this.KGFDIIPHOKP.audioOutputMode = VideoAudioOutputMode.None;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06005553 RID: 21843 RVA: 0x0025B85C File Offset: 0x00259A5C
	public void OEDCGDDJJHN()
	{
		if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip && KHPGPLAMAIN.NOEBCMMNALO() && !KDCJJBLGCBH.EHBBFMCILPC.GOLIJKAPBHL() && !this.MFMAFGBCLBD && this.KGFDIIPHOKP.isPrepared && this.KGFDIIPHOKP.isPaused)
		{
			this.KGFDIIPHOKP.Play();
		}
	}

	// Token: 0x06005554 RID: 21844 RVA: 0x00258D46 File Offset: 0x00256F46
	private void OKBGBJDJMNI()
	{
		this.CDAMEAIIKMG();
	}

	// Token: 0x06005555 RID: 21845 RVA: 0x0025B8CA File Offset: 0x00259ACA
	public void OAGPEDBFHKG()
	{
		if (StoryEnvironmentLayerManager.layersSystemVersion >= 5 && null != this.ANMHOOKIOBJ && base.gameObject.activeSelf)
		{
			this.ANMHOOKIOBJ.Play();
			this.ANMHOOKIOBJ.Emit(1);
		}
	}

	// Token: 0x06005556 RID: 21846 RVA: 0x0025B908 File Offset: 0x00259B08
	private void OnDestroy()
	{
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.DOKill(false);
		}
		try
		{
			if (null != this.KGFDIIPHOKP && null != this.KGFDIIPHOKP.clip)
			{
				this.KGFDIIPHOKP.prepareCompleted -= this.NGIOBMPNPPN;
				this.KGFDIIPHOKP.Stop();
				this.KGFDIIPHOKP.targetCamera = null;
				DPGJIJGOCIC.NFIDPOMCNLP("Video:" + this.EOMLCNKAHCL + " stopping!");
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x040017AF RID: 6063
	public const string onVideoLayerAutoHide = "OnVideoLayerAutoHide";

	// Token: 0x040017B0 RID: 6064
	public const string onVideoLayerPlaybackEndsSoon = "OnVideoLayerPlaybackEndsSoon";

	// Token: 0x040017B1 RID: 6065
	public static int layersSystemVersion = 0;

	// Token: 0x040017B2 RID: 6066
	public static string lastVideoLayerName = "";

	// Token: 0x040017B3 RID: 6067
	public static string lastVideoLayerAssetBundleName = "";

	// Token: 0x040017B4 RID: 6068
	public bool isShared;

	// Token: 0x040017B5 RID: 6069
	private CanvasGroup PANMNKKODPC;

	// Token: 0x040017B6 RID: 6070
	private ParticleSystem ANMHOOKIOBJ;

	// Token: 0x040017B7 RID: 6071
	private VideoPlayer KGFDIIPHOKP;

	// Token: 0x040017B8 RID: 6072
	private bool JIEPCIDINEH;

	// Token: 0x040017B9 RID: 6073
	private int AOPIMPMDEHO = -1;

	// Token: 0x040017BA RID: 6074
	private float ANMOIJKEJBH = -1f;

	// Token: 0x040017BB RID: 6075
	private float JEOOHHADLKO;

	// Token: 0x040017BC RID: 6076
	private bool MFMAFGBCLBD;

	// Token: 0x040017BD RID: 6077
	private Camera ACECOBEMCPI;

	// Token: 0x040017BE RID: 6078
	private string EOMLCNKAHCL = "";

	// Token: 0x040017BF RID: 6079
	private bool PKCNHJIHHHN;
}
