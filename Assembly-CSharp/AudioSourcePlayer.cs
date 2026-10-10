using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020002E9 RID: 745
public class AudioSourcePlayer : MonoBehaviour
{
	// Token: 0x06005AB2 RID: 23218 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void AAJMOOAGIHI()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void GNLBNLPNJHF()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x0028D870 File Offset: 0x0028BA70
	private void GEKKOMLJHIN()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK APBLNKANBOO()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005AB6 RID: 23222 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED PEJOLHBPJMN()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x0028D8C0 File Offset: 0x0028BAC0
	private void OnDestroy()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.JIEPMODHKLH();
	}

	// Token: 0x06005AB8 RID: 23224 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void LHIAGHLGLEB()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AB9 RID: 23225 RVA: 0x0028D8F0 File Offset: 0x0028BAF0
	public void KIIFNPNMMPN(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 205f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "  ", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "retry", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "FullscreenLiveOfferManager.PurchaseProductWebDuration(): productBalanceData is null for sku '", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InSine));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1510f;
		}
		if (BICHMDEIFKI > 179f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.JLJFGLGMJFC(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x0028DA40 File Offset: 0x0028BC40
	public void EECHKHNELHA(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1528f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "OsnStorySplashManagerHide", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.BAHKHPIPFDL)));
		}
		else
		{
			this.PKAAFCJCFOM = 224f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005ABB RID: 23227 RVA: 0x0028DAE4 File Offset: 0x0028BCE4
	public void Update()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = HADNEFMHLED.wasted;
			return;
		}
		if (this.PKAAFCJCFOM <= 0f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != HADNEFMHLED.wasted && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = HADNEFMHLED.wasted;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(this.EODLJGDPAOE, 0f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void GFNKCCEPPFO()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005ABD RID: 23229 RVA: 0x0028DB80 File Offset: 0x0028BD80
	private void BPBDODMLGJK()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(true);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005ABE RID: 23230 RVA: 0x0028DBC0 File Offset: 0x0028BDC0
	private void LGEJJBINCJP()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.HBNPNOHMILA();
	}

	// Token: 0x06005ABF RID: 23231 RVA: 0x0028DBF0 File Offset: 0x0028BDF0
	public void NNNKIPGJMMF(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 679f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "assetbundleprofiledatalocalized", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "p", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "noiseanalog_1", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.OutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 343f;
		}
		if (BICHMDEIFKI > 1693f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.OKLMFJAOKHP(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AC0 RID: 23232 RVA: 0x0028DD40 File Offset: 0x0028BF40
	public void CNPKJAIBOCF(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 322f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "AAA", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.GFNKCCEPPFO)));
		}
		else
		{
			this.PKAAFCJCFOM = 1915f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AC1 RID: 23233 RVA: 0x0028DDE4 File Offset: 0x0028BFE4
	public void LCDEDAKLIJO(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1732f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.BAHKHPIPFDL)));
		}
		else
		{
			this.PKAAFCJCFOM = 1791f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AC2 RID: 23234 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void DEHOJFACEMD()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AC3 RID: 23235 RVA: 0x0028DE87 File Offset: 0x0028C087
	private IEnumerator OBDCIILJAKI(float BICHMDEIFKI)
	{
		AudioSourcePlayer.MBFCJGOFDNL mbfcjgofdnl = new AudioSourcePlayer.MBFCJGOFDNL(1);
		mbfcjgofdnl.<>4__this = this;
		mbfcjgofdnl._delay = BICHMDEIFKI;
		return mbfcjgofdnl;
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK DLHMJJEAIMO()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005AC5 RID: 23237 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string GELJFNKEAFO()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x0028DEAF File Offset: 0x0028C0AF
	public void GKFGPJNNAJE()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005AC7 RID: 23239 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED GetSourceState()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005AC8 RID: 23240 RVA: 0x0028DEC4 File Offset: 0x0028C0C4
	public void GLIFGDPDMNC(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1134f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "[SkinShop] look without a resolvable amount (shop ", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "OnLoungePremiumChoicesHistorySuccess", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "acli21", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InOutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 210f;
		}
		if (BICHMDEIFKI > 1647f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.OKLMFJAOKHP(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x0028E014 File Offset: 0x0028C214
	public void MBCPGIICABK(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1013f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "fdvp", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "ButtonAvatar", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "body", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.OutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1280f;
		}
		if (BICHMDEIFKI > 1579f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.BOHFHHIIELI(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x0028E164 File Offset: 0x0028C364
	public void GLAFDEMAOCM(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1580f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "UpdateFastForwardOnOffState", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.FJEDBCCFJPB)));
		}
		else
		{
			this.PKAAFCJCFOM = 843f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x0028E207 File Offset: 0x0028C407
	public void CFABDCDOODB()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x0028E21C File Offset: 0x0028C41C
	private void DELCPCKCGIB()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string GetSourceName()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void IPMOGNHJGLG()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x0028E26C File Offset: 0x0028C46C
	public void GKJGAJOMNKD()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)8;
			return;
		}
		if (this.PKAAFCJCFOM <= 1197f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)3 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG(this.EODLJGDPAOE, 610f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x0028E2FC File Offset: 0x0028C4FC
	public void CNJKPDCGHHB(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 565f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "sshrpp", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "youreceived", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InOutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1240f;
		}
		if (BICHMDEIFKI > 308f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.CEHBOHLGHMF(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AD2 RID: 23250 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void GNDALMBKFFO()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x0028E45D File Offset: 0x0028C65D
	private void PDHDJMJECJA()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.MHCFOHHMIKN();
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void LMFAAEHFKCH()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x0028E48C File Offset: 0x0028C68C
	private void FAINIHIADNL()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x0028E4CC File Offset: 0x0028C6CC
	public AudioMixerGroup LMAJJLKDINA()
	{
		return this.ANENDGGAIDL.outputAudioMixerGroup;
	}

	// Token: 0x06005AD7 RID: 23255 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void Destroy()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x0028DB71 File Offset: 0x0028BD71
	[CompilerGenerated]
	private void LFNNKJGJHNM()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void ENFGENKELLB()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void JIGFGDBPBEA()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x0028E4D9 File Offset: 0x0028C6D9
	private void EIHABGEFOLK()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.KGHMKCHJDOJ();
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x0028E207 File Offset: 0x0028C407
	public void AEMKHMDDCMF()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x0028DEAF File Offset: 0x0028C0AF
	public void LAPEFDFBKJP()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x0028E508 File Offset: 0x0028C708
	public void NPKOEMIHBNI(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 118f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "mypnotif0", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.DBBEGHMGGLM)));
		}
		else
		{
			this.PKAAFCJCFOM = 298f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void BAHKHPIPFDL()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005AE0 RID: 23264 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void HIFPOLKELBI()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void FGINAFHLBPA()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005AE2 RID: 23266 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void Resume()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void JAHMBOAKMLG()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x0028E5AC File Offset: 0x0028C7AC
	public void BKLLPIBAGGO()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			return;
		}
		if (this.PKAAFCJCFOM <= 21f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != HADNEFMHLED.playing && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)8;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.BIAEAOMHBMM().EGELHPJBAIC(this.EODLJGDPAOE, 385f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x0028E63C File Offset: 0x0028C83C
	public void JPMDBNHJGIF(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 868f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "CLIENT.POSTEFFECTS.SPECTRUM", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InQuad).OnComplete(new TweenCallback(this.JFCAEFJDOLP)));
		}
		else
		{
			this.PKAAFCJCFOM = 394f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x0028E6E0 File Offset: 0x0028C8E0
	public void DGAFAPKAKIA(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1870f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "apks1", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "-", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "socialsimplegiftcollect", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.Linear));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1660f;
		}
		if (BICHMDEIFKI > 1798f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.OBDCIILJAKI(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x0028E830 File Offset: 0x0028CA30
	public void JLKPGJLNBFB(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 753f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "nick2", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InQuad).OnComplete(new TweenCallback(this.GNDALMBKFFO)));
		}
		else
		{
			this.PKAAFCJCFOM = 215f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x0028E207 File Offset: 0x0028C407
	public void BEDGGHLGFLI()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED FPHJGKPDPKC()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x0028D8C0 File Offset: 0x0028BAC0
	private void OLOGCFJNDGF()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.JIEPMODHKLH();
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x0028E8D4 File Offset: 0x0028CAD4
	private void PCEMPFIPBFD()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x0028E914 File Offset: 0x0028CB14
	public void PEOKGIENOBB(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 993f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.JFCAEFJDOLP)));
		}
		else
		{
			this.PKAAFCJCFOM = 76f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x0028E9B7 File Offset: 0x0028CBB7
	private void BMNDCBEKEPD()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.DELCPCKCGIB();
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK GetSourceType()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x0028E9E8 File Offset: 0x0028CBE8
	public void DPFIIBPDEJG(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1985f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "OnSettingsPopupCloseAndNeedToShowGameModeNotif", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "analogglitchovr_1", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "OnStorySplashManagerCdnSuccess", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.Linear));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 848f;
		}
		if (BICHMDEIFKI > 673f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.ELKPOBHNAKC(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void CKMNGJKDAHA()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x0028EB36 File Offset: 0x0028CD36
	private IEnumerator CCOHBIEPCJH(float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.LGIANLJLBHN)
		{
			this.ANENDGGAIDL.Play();
		}
		this.NMDGAADMMHC = false;
		yield break;
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x0028EB4C File Offset: 0x0028CD4C
	public void LGGCDOCMNBA(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 300f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.LGMNAPINNFN)));
		}
		else
		{
			this.PKAAFCJCFOM = 984f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x0028EBF0 File Offset: 0x0028CDF0
	private void JIEPMODHKLH()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005AF4 RID: 23284 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void AGIOKKEPHKL()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED LFPLJHACOCK()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x0028EC30 File Offset: 0x0028CE30
	private void KGHMKCHJDOJ()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void LGMNAPINNFN()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void CIFHEHPCNMB()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string HFGHFGFGNHE()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void FJEDBCCFJPB()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x0028EC70 File Offset: 0x0028CE70
	public void LLHCFKLPJNG(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 332f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "p", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.JFCAEFJDOLP)));
		}
		else
		{
			this.PKAAFCJCFOM = 1606f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x0028ED14 File Offset: 0x0028CF14
	public void HPDEFGKBAMN(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 587f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "favoritespattern", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "analogglitch20ovr_1", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.OutSine));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 946f;
		}
		if (BICHMDEIFKI > 590f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.OBDCIILJAKI(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005AFD RID: 23293 RVA: 0x0028E4D9 File Offset: 0x0028C6D9
	private void GOKDPNLEJBE()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.KGHMKCHJDOJ();
	}

	// Token: 0x06005AFE RID: 23294 RVA: 0x0028EE64 File Offset: 0x0028D064
	public void CLLBFMDDJHL(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 210f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.JFCAEFJDOLP)));
		}
		else
		{
			this.PKAAFCJCFOM = 890f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005AFF RID: 23295 RVA: 0x0028EF08 File Offset: 0x0028D108
	public void PALFAAEMPLH(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 434f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "OnSkinShopCardSelected", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InSine).OnComplete(new TweenCallback(this.FJEDBCCFJPB)));
		}
		else
		{
			this.PKAAFCJCFOM = 871f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x0028E207 File Offset: 0x0028C407
	public void INEGALBLONB()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005B01 RID: 23297 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void DNOBDCIOMOH()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B02 RID: 23298 RVA: 0x0028EFAC File Offset: 0x0028D1AC
	public void ADBMOOMEJMP(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1752f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "Asset bundle ", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.LGMNAPINNFN)));
		}
		else
		{
			this.PKAAFCJCFOM = 1547f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B03 RID: 23299 RVA: 0x0028F050 File Offset: 0x0028D250
	public void Kill(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 0.001f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "Vol", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.LFNNKJGJHNM)));
		}
		else
		{
			this.PKAAFCJCFOM = 0f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B04 RID: 23300 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED AMFAFNLEPCB()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B05 RID: 23301 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void CKIDEJELINP()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B06 RID: 23302 RVA: 0x0028DEAF File Offset: 0x0028C0AF
	public void BMJDLMJCJMD()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void EHDDLAGLPNG()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B08 RID: 23304 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK GONGHBDADKO()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005B09 RID: 23305 RVA: 0x0028F0F4 File Offset: 0x0028D2F4
	public void HFMIGJELJCD(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 737f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "Loaded asset bundle:", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.DBBEGHMGGLM)));
		}
		else
		{
			this.PKAAFCJCFOM = 1837f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B0A RID: 23306 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void JFCAEFJDOLP()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B0B RID: 23307 RVA: 0x0028F198 File Offset: 0x0028D398
	public void NBMLMHKEJAB(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 472f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "assetIndex", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.LFNNKJGJHNM)));
		}
		else
		{
			this.PKAAFCJCFOM = 110f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B0C RID: 23308 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void LJJDLOJGFNP()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B0D RID: 23309 RVA: 0x0028F23C File Offset: 0x0028D43C
	public void MICKEPALNPL(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1720f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "p", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.LJJDLOJGFNP)));
		}
		else
		{
			this.PKAAFCJCFOM = 1143f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B0E RID: 23310 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED JGGDCOHKOLE()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B0F RID: 23311 RVA: 0x0028F2DF File Offset: 0x0028D4DF
	private void CJAFGKPFPAA()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.FAINIHIADNL();
	}

	// Token: 0x06005B10 RID: 23312 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string IPFLFAEHHPJ()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005B11 RID: 23313 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK CACFEADLCFK()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x0028F310 File Offset: 0x0028D510
	public void NGKAHOJOHEE()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = HADNEFMHLED.wasted;
			return;
		}
		if (this.PKAAFCJCFOM <= 772f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)5 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(this.EODLJGDPAOE, 819f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x0028F3A0 File Offset: 0x0028D5A0
	public void BGLIAHEKACL(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 312f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "episode", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "OnStoryChoiceClick", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "Asset pack has been LOADED according to on demand resources data:", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InCubic));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 362f;
		}
		if (BICHMDEIFKI > 701f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.BOHFHHIIELI(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x0028F4F0 File Offset: 0x0028D6F0
	public void AIIBCCIJBGL(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 389f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "'", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "gpsku", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "lck", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.Linear));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1167f;
		}
		if (BICHMDEIFKI > 101f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.CCOHBIEPCJH(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B15 RID: 23317 RVA: 0x0028E4CC File Offset: 0x0028C6CC
	public AudioMixerGroup GetMixerGroup()
	{
		return this.ANENDGGAIDL.outputAudioMixerGroup;
	}

	// Token: 0x06005B16 RID: 23318 RVA: 0x0028F640 File Offset: 0x0028D840
	public void PLFFANJEOHP(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1158f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "Get Value For {0}", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.LJJDLOJGFNP)));
		}
		else
		{
			this.PKAAFCJCFOM = 279f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B17 RID: 23319 RVA: 0x0028E4CC File Offset: 0x0028C6CC
	public AudioMixerGroup FCLGJKCKKII()
	{
		return this.ANENDGGAIDL.outputAudioMixerGroup;
	}

	// Token: 0x06005B18 RID: 23320 RVA: 0x0028F6E3 File Offset: 0x0028D8E3
	private void GAOHHJLFPKA()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.KMCNGGFJFNK();
	}

	// Token: 0x06005B19 RID: 23321 RVA: 0x0028F711 File Offset: 0x0028D911
	private void BGELMCDMGKP()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.BPBDODMLGJK();
	}

	// Token: 0x06005B1A RID: 23322 RVA: 0x0028F740 File Offset: 0x0028D940
	private void KMCNGGFJFNK()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005B1B RID: 23323 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void CFEPHIMCJPL()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B1C RID: 23324 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED ONMGCJCCBJD()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B1D RID: 23325 RVA: 0x0028E4CC File Offset: 0x0028C6CC
	public AudioMixerGroup HNIIJJEOJPJ()
	{
		return this.ANENDGGAIDL.outputAudioMixerGroup;
	}

	// Token: 0x06005B1E RID: 23326 RVA: 0x0028F780 File Offset: 0x0028D980
	public void MLBNHHGMILD(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1698f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "OnShowStoryHeaderInterfaceGamePassAndUndoButton", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.ENFGENKELLB)));
		}
		else
		{
			this.PKAAFCJCFOM = 1395f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B1F RID: 23327 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void GBBMJEJOJAB()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005B20 RID: 23328 RVA: 0x0028F824 File Offset: 0x0028DA24
	public void GCGMEIFHBKN(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 4f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InOutSine).OnComplete(new TweenCallback(this.FJEDBCCFJPB)));
		}
		else
		{
			this.PKAAFCJCFOM = 299f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005B21 RID: 23329 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string CHIKFCPMLNA()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005B22 RID: 23330 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void DAKKKMNKBCH()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005B23 RID: 23331 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void LCPPHAFKEEP()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B24 RID: 23332 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED LGPAPMAAHKG()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B25 RID: 23333 RVA: 0x0028F2DF File Offset: 0x0028D4DF
	private void NJLMAAGDGJJ()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.FAINIHIADNL();
	}

	// Token: 0x06005B26 RID: 23334 RVA: 0x0028DEAF File Offset: 0x0028C0AF
	public void Pause()
	{
		this.DPNFENJDCEO = true;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005B27 RID: 23335 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string CLOGIELNDPK()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005B28 RID: 23336 RVA: 0x0028F8C8 File Offset: 0x0028DAC8
	private void HBNPNOHMILA()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i += 0)
		{
			this.AAAADHFPIMG[i].Kill(true);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005B29 RID: 23337 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void DBBEGHMGGLM()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B2A RID: 23338 RVA: 0x0028F908 File Offset: 0x0028DB08
	public void Initialize(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 0.001f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "Vol", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "Vol", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "Vol", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.OutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 1000000f;
		}
		if (BICHMDEIFKI > 0.0001f)
		{
			this.NMDGAADMMHC = true;
			this.JOOHABHEMIK = base.StartCoroutine(this.JLJFGLGMJFC(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B2B RID: 23339 RVA: 0x0028FA58 File Offset: 0x0028DC58
	public void ONCMEAFFFIB(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1842f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "StorySaveBody.GetAvatarsSnapshotsCountWardrobe(), unsupported wardrobe index:", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "energyhinttitle", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "nam", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 621f;
		}
		if (BICHMDEIFKI > 1609f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.CEHBOHLGHMF(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B2C RID: 23340 RVA: 0x0028EB36 File Offset: 0x0028CD36
	private IEnumerator CEHBOHLGHMF(float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.LGIANLJLBHN)
		{
			this.ANENDGGAIDL.Play();
		}
		this.NMDGAADMMHC = false;
		yield break;
	}

	// Token: 0x06005B2D RID: 23341 RVA: 0x0028FBA8 File Offset: 0x0028DDA8
	public void BIJEEKNMKLN(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1044f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "iac", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.ICIINCEJKPH)));
		}
		else
		{
			this.PKAAFCJCFOM = 918f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B2E RID: 23342 RVA: 0x0028FC4C File Offset: 0x0028DE4C
	public void NJINDDEAIDA()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)4;
			return;
		}
		if (this.PKAAFCJCFOM <= 303f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)3 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.CEGAOMEEFBE().KMAGHMCCMPG(this.EODLJGDPAOE, 1305f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005B2F RID: 23343 RVA: 0x0028DBC0 File Offset: 0x0028BDC0
	private void MNMJCFNKMKI()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.HBNPNOHMILA();
	}

	// Token: 0x06005B30 RID: 23344 RVA: 0x0028E9B7 File Offset: 0x0028CBB7
	private void LEHKKGLMFDL()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.DELCPCKCGIB();
	}

	// Token: 0x06005B31 RID: 23345 RVA: 0x0028FCD9 File Offset: 0x0028DED9
	private void MFINONMBMLM()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.GEKKOMLJHIN();
	}

	// Token: 0x06005B32 RID: 23346 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void GGDLMMLJLAF()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B33 RID: 23347 RVA: 0x0028FD08 File Offset: 0x0028DF08
	public void PPMOJEELMIH(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 367f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "%", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.BAHKHPIPFDL)));
		}
		else
		{
			this.PKAAFCJCFOM = 121f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005B34 RID: 23348 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void PGNGDINPEMJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B35 RID: 23349 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void ICIINCEJKPH()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B36 RID: 23350 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED OEBGEAKNLOI()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B37 RID: 23351 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void IJEHAEEIAPN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B38 RID: 23352 RVA: 0x0028EB36 File Offset: 0x0028CD36
	private IEnumerator ELKPOBHNAKC(float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.LGIANLJLBHN)
		{
			this.ANENDGGAIDL.Play();
		}
		this.NMDGAADMMHC = false;
		yield break;
	}

	// Token: 0x06005B39 RID: 23353 RVA: 0x0028FDAC File Offset: 0x0028DFAC
	private void CLLNCLFDDLJ()
	{
		for (int i = 0; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(false);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005B3A RID: 23354 RVA: 0x0028FDEC File Offset: 0x0028DFEC
	public void KLAKKHMCBOB(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 323f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "amt", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.OutQuad).OnComplete(new TweenCallback(this.BAHKHPIPFDL)));
		}
		else
		{
			this.PKAAFCJCFOM = 258f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = true;
	}

	// Token: 0x06005B3B RID: 23355 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void DEBBAJBGIFF()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B3C RID: 23356 RVA: 0x0028FE90 File Offset: 0x0028E090
	public void CDGCBAKKPDI()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)7;
			return;
		}
		if (this.PKAAFCJCFOM <= 32f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)4 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)5;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG(this.EODLJGDPAOE, 1652f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005B3D RID: 23357 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void KOJLEFHOPOK()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B3E RID: 23358 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
	public HADNEFMHLED FPHOICNEGFH()
	{
		return this.ONMCLGKDNND;
	}

	// Token: 0x06005B3F RID: 23359 RVA: 0x0028FF20 File Offset: 0x0028E120
	public void DFOBCCBLDJK()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = HADNEFMHLED.killing;
			return;
		}
		if (this.PKAAFCJCFOM <= 1912f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)8 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)3;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC(this.EODLJGDPAOE, 1207f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005B40 RID: 23360 RVA: 0x0028E4CC File Offset: 0x0028C6CC
	public AudioMixerGroup KOKIIHJLGGO()
	{
		return this.ANENDGGAIDL.outputAudioMixerGroup;
	}

	// Token: 0x06005B41 RID: 23361 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void IOJKDHJDNGN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B42 RID: 23362 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void BCBFDJGADCM()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06005B43 RID: 23363 RVA: 0x0028D846 File Offset: 0x0028BA46
	public void INEMKMMNGPP()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.UnPause();
	}

	// Token: 0x06005B44 RID: 23364 RVA: 0x0028D8B0 File Offset: 0x0028BAB0
	public CCEMAFOMLLK KBFDMIDFIHM()
	{
		return this.FAJABPBABOF;
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x0028FFB0 File Offset: 0x0028E1B0
	public void MDHJEDLMFOA()
	{
		if (null == this.ANENDGGAIDL)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)7;
			return;
		}
		if (this.PKAAFCJCFOM <= 937f && !this.ANENDGGAIDL.isPlaying && this.ONMCLGKDNND != (HADNEFMHLED)3 && !this.NMDGAADMMHC)
		{
			this.ONMCLGKDNND = (HADNEFMHLED)7;
			if (this.EODLJGDPAOE != null)
			{
				AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND(this.EODLJGDPAOE, 691f);
				return;
			}
		}
		else if (!this.DPNFENJDCEO)
		{
			this.PKAAFCJCFOM -= Time.deltaTime;
		}
	}

	// Token: 0x06005B46 RID: 23366 RVA: 0x0028D85A File Offset: 0x0028BA5A
	public void AELMLFECIPH()
	{
		this.DPNFENJDCEO = false;
		this.ANENDGGAIDL.Pause();
	}

	// Token: 0x06005B47 RID: 23367 RVA: 0x00290040 File Offset: 0x0028E240
	public void PNLADGLJHBN(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.playing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 389f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "OnLoungePremiumChoicesHistoryException", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "usyncoll2", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "SocialStatsUserPublicProfile.modified = true, UpdateNickNameText()", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InOutQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 911f;
		}
		if (BICHMDEIFKI > 1688f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.OKLMFJAOKHP(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B48 RID: 23368 RVA: 0x00290190 File Offset: 0x0028E390
	public void NDACAKGFEFP(CCEMAFOMLLK DIMNMKOJGGL, AudioMixerGroup AJGNPGEAGLP, AudioClip LNAMDFBACGA, bool CFBIPJJHDJE, float HNDCHPLIIGE, float BICHMDEIFKI, string JIFJFLIDPLC = null)
	{
		this.ONMCLGKDNND = HADNEFMHLED.killing;
		this.EODLJGDPAOE = JIFJFLIDPLC;
		this.ANENDGGAIDL = base.gameObject.GetComponentInChildren<AudioSource>();
		this.FAJABPBABOF = DIMNMKOJGGL;
		this.ANENDGGAIDL.clip = LNAMDFBACGA;
		this.ANENDGGAIDL.loop = CFBIPJJHDJE;
		this.ANENDGGAIDL.outputAudioMixerGroup = AJGNPGEAGLP;
		if (HNDCHPLIIGE < 1720f)
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "<i>", KBOJLHAJPCP.LPLMDGINNKL);
		}
		else
		{
			this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.SetFloat(AJGNPGEAGLP.name + "SocialStatsUserPublicProfile.SyncCutscenes(): Syncing new cutscene: ", KBOJLHAJPCP.GLBIBLIGHOD);
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(AJGNPGEAGLP.name + "SceneLobbyManager2.BuildGroupedParent() - no group could be built for ", KBOJLHAJPCP.LPLMDGINNKL, HNDCHPLIIGE).SetEase(Ease.InQuad));
		}
		if (!CFBIPJJHDJE)
		{
			this.PKAAFCJCFOM = this.ANENDGGAIDL.clip.length;
		}
		else
		{
			this.PKAAFCJCFOM = 18f;
		}
		if (BICHMDEIFKI > 28f)
		{
			this.NMDGAADMMHC = false;
			this.JOOHABHEMIK = base.StartCoroutine(this.CCOHBIEPCJH(BICHMDEIFKI));
			return;
		}
		this.ANENDGGAIDL.Play();
	}

	// Token: 0x06005B49 RID: 23369 RVA: 0x002902DE File Offset: 0x0028E4DE
	private void NLOFDEFADCL()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.PCEMPFIPBFD();
	}

	// Token: 0x06005B4A RID: 23370 RVA: 0x0028DB71 File Offset: 0x0028BD71
	private void HGGFJAJLJHM()
	{
		this.ANENDGGAIDL.Stop();
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x0029030C File Offset: 0x0028E50C
	private void MHCFOHHMIKN()
	{
		for (int i = 1; i < this.AAAADHFPIMG.Count; i++)
		{
			this.AAAADHFPIMG[i].Kill(true);
		}
		this.AAAADHFPIMG.Clear();
	}

	// Token: 0x06005B4C RID: 23372 RVA: 0x0028EB36 File Offset: 0x0028CD36
	private IEnumerator JLJFGLGMJFC(float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.LGIANLJLBHN)
		{
			this.ANENDGGAIDL.Play();
		}
		this.NMDGAADMMHC = false;
		yield break;
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x0028DE9D File Offset: 0x0028C09D
	public string MEIMDEOBLMG()
	{
		return this.ANENDGGAIDL.clip.name;
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x0028F6E3 File Offset: 0x0028D8E3
	private void MOCDMCLPBKC()
	{
		this.ANENDGGAIDL.Stop();
		if (this.JOOHABHEMIK != null)
		{
			base.StopCoroutine(this.JOOHABHEMIK);
			this.JOOHABHEMIK = null;
		}
		this.KMCNGGFJFNK();
	}

	// Token: 0x06005B4F RID: 23375 RVA: 0x0029034C File Offset: 0x0028E54C
	public void FIONBNEKFNC(float PAENKHPFKHM, bool IFOMNJBJBKH = false)
	{
		if (IFOMNJBJBKH)
		{
			this.EODLJGDPAOE = null;
		}
		if (PAENKHPFKHM > 1770f)
		{
			this.ONMCLGKDNND = HADNEFMHLED.playing;
			this.PKAAFCJCFOM = PAENKHPFKHM;
			this.AAAADHFPIMG.Add(this.ANENDGGAIDL.outputAudioMixerGroup.audioMixer.DOSetFloat(this.ANENDGGAIDL.outputAudioMixerGroup.name + "〉", KBOJLHAJPCP.GLBIBLIGHOD, PAENKHPFKHM).SetEase(Ease.InCubic).OnComplete(new TweenCallback(this.ICIINCEJKPH)));
		}
		else
		{
			this.PKAAFCJCFOM = 1502f;
			this.ANENDGGAIDL.Stop();
		}
		this.LGIANLJLBHN = false;
	}

	// Token: 0x06005B50 RID: 23376 RVA: 0x0028EB36 File Offset: 0x0028CD36
	private IEnumerator OKLMFJAOKHP(float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (!this.LGIANLJLBHN)
		{
			this.ANENDGGAIDL.Play();
		}
		this.NMDGAADMMHC = false;
		yield break;
	}

	// Token: 0x06005B51 RID: 23377 RVA: 0x0028DE87 File Offset: 0x0028C087
	private IEnumerator BOHFHHIIELI(float BICHMDEIFKI)
	{
		AudioSourcePlayer.MBFCJGOFDNL mbfcjgofdnl = new AudioSourcePlayer.MBFCJGOFDNL(1);
		mbfcjgofdnl.<>4__this = this;
		mbfcjgofdnl._delay = BICHMDEIFKI;
		return mbfcjgofdnl;
	}

	// Token: 0x040019E7 RID: 6631
	private CCEMAFOMLLK FAJABPBABOF;

	// Token: 0x040019E8 RID: 6632
	private HADNEFMHLED ONMCLGKDNND;

	// Token: 0x040019E9 RID: 6633
	private AudioSource ANENDGGAIDL;

	// Token: 0x040019EA RID: 6634
	private float PKAAFCJCFOM;

	// Token: 0x040019EB RID: 6635
	private string EODLJGDPAOE;

	// Token: 0x040019EC RID: 6636
	private List<Tween> AAAADHFPIMG = new List<Tween>();

	// Token: 0x040019ED RID: 6637
	private bool NMDGAADMMHC;

	// Token: 0x040019EE RID: 6638
	private bool LGIANLJLBHN;

	// Token: 0x040019EF RID: 6639
	private Coroutine JOOHABHEMIK;

	// Token: 0x040019F0 RID: 6640
	private bool DPNFENJDCEO;
}
