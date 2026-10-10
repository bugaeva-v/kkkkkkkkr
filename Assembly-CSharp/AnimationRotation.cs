using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x020004DC RID: 1244
public class AnimationRotation : MonoBehaviour
{
	// Token: 0x060095A9 RID: 38313 RVA: 0x00419B78 File Offset: 0x00417D78
	private void LAKIJEGLFHJ()
	{
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.Fast;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.FastBeyond360;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(0f, 0f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMNDEOBBLGI)).SetLoops(100000, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(0f, 0f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMNDEOBBLGI)).SetLoops(2, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(0f, 0f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMNDEOBBLGI));
	}

	// Token: 0x060095AA RID: 38314 RVA: 0x00419CC0 File Offset: 0x00417EC0
	private void GKJEACCEHPF()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1407f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095AB RID: 38315 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void BNMJABILOKK()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095AC RID: 38316 RVA: 0x00419D19 File Offset: 0x00417F19
	private void PCLKNFOBGJC()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1480f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095AD RID: 38317 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void Awake()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095AE RID: 38318 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void CFHFGNOIPEC()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095AF RID: 38319 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void KGEINIJLFMI()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095B0 RID: 38320 RVA: 0x00419D42 File Offset: 0x00417F42
	private void OLFGDFCHEEC()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1627f;
	}

	// Token: 0x060095B1 RID: 38321 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void GMPHANBKGBK()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095B2 RID: 38322 RVA: 0x00419D56 File Offset: 0x00417F56
	private void EFIBBLFAMGD()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.NPLEBHBJEAM();
		this.FIJDKGJEPGC();
	}

	// Token: 0x060095B3 RID: 38323 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void NAAFHFFELKK()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095B4 RID: 38324 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void LIBECOJEBKI()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095B5 RID: 38325 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void OPBNOGLBNDK()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095B6 RID: 38326 RVA: 0x00419D70 File Offset: 0x00417F70
	private void ILLMKMLEHMI()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 297f)
			{
				this.NOJCABCLBCL();
				this.KEFOFHHLINI();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 602f)
			{
				this.DLAFBOCNONH = 663f;
				this.NLNBPPBMHMH();
				this.KEFOFHHLINI();
			}
		}
	}

	// Token: 0x060095B7 RID: 38327 RVA: 0x00419DE7 File Offset: 0x00417FE7
	private void MMHIEPGFBJJ()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 524f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095B8 RID: 38328 RVA: 0x00419E10 File Offset: 0x00418010
	private void KEFOFHHLINI()
	{
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(true);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.Fast;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1887f, 963f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BKMDLBICEAB)).SetLoops(-144, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(802f, 804f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PMECININEKG)).SetLoops(1, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(1727f, 1490f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MMHIEPGFBJJ));
	}

	// Token: 0x060095B9 RID: 38329 RVA: 0x00419F58 File Offset: 0x00418158
	private void Update()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 0f)
			{
				this.JHGFOKOFMHB();
				this.LAKIJEGLFHJ();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 0f)
			{
				this.DLAFBOCNONH = 10000000f;
				this.JHGFOKOFMHB();
				this.LAKIJEGLFHJ();
			}
		}
	}

	// Token: 0x060095BA RID: 38330 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void LOCANABKJEE()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095BB RID: 38331 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void LFPPGGLOOHJ()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095BC RID: 38332 RVA: 0x00419FCF File Offset: 0x004181CF
	private void JHGFOKOFMHB()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = -1f;
	}

	// Token: 0x060095BD RID: 38333 RVA: 0x00419FE3 File Offset: 0x004181E3
	private void NPLEBHBJEAM()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 736f;
	}

	// Token: 0x060095BE RID: 38334 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void JFFNFDKBMGP()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095BF RID: 38335 RVA: 0x00419FF7 File Offset: 0x004181F7
	private void KOOJDNONAOO()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1416f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095C0 RID: 38336 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void NGPHDNKNGHE()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095C1 RID: 38337 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void GFOCPBFLJFC()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095C2 RID: 38338 RVA: 0x0041A020 File Offset: 0x00418220
	private void BKMDLBICEAB()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 815f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095C3 RID: 38339 RVA: 0x0041A049 File Offset: 0x00418249
	private void HOJIMOHCLHE()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.ONDMDMMJDOD();
		this.CBCJABBJFAN();
	}

	// Token: 0x060095C4 RID: 38340 RVA: 0x0017AE42 File Offset: 0x00179042
	private void GIAGKNDOADK()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095C5 RID: 38341 RVA: 0x0041A063 File Offset: 0x00418263
	private void EBEHKLMOLAG()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 858f;
	}

	// Token: 0x060095C6 RID: 38342 RVA: 0x0041A078 File Offset: 0x00418278
	private void NFFGMDALKCE()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 963f)
			{
				this.GOFOBEOIELF();
				this.LAKIJEGLFHJ();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 775f)
			{
				this.DLAFBOCNONH = 1607f;
				this.NPLEBHBJEAM();
				this.MKICMLECFFC();
			}
		}
	}

	// Token: 0x060095C7 RID: 38343 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void CJOOOIECMAE()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095C8 RID: 38344 RVA: 0x0041A0F0 File Offset: 0x004182F0
	private void OODAOLBKEOH()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1361f)
			{
				this.NLNBPPBMHMH();
				this.DJIHEOLJHEP();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1899f)
			{
				this.DLAFBOCNONH = 1682f;
				this.NOJCABCLBCL();
				this.DJIHEOLJHEP();
			}
		}
	}

	// Token: 0x060095C9 RID: 38345 RVA: 0x0017AE42 File Offset: 0x00179042
	private void EJAENAPIMKF()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095CA RID: 38346 RVA: 0x0041A168 File Offset: 0x00418368
	private void EHGLPNPAHDC()
	{
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(true);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.FastBeyond360;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(781f, 1094f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.KEPIPMNPFCP)).SetLoops(92, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(100f, 1954f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMNDEOBBLGI)).SetLoops(2, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(1961f, 1980f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GKJEACCEHPF));
	}

	// Token: 0x060095CB RID: 38347 RVA: 0x0041A2B0 File Offset: 0x004184B0
	private void IJMPLMMFIEP()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.AOODHKFMHBL();
		this.CEALHCENAGD();
	}

	// Token: 0x060095CC RID: 38348 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void LPEDJEOJIFP()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095CD RID: 38349 RVA: 0x0041A2CA File Offset: 0x004184CA
	private void IBODIHNMEDM()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1162f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095CE RID: 38350 RVA: 0x0041A2F4 File Offset: 0x004184F4
	private void FIJDKGJEPGC()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1539f)
			{
				this.NOJCABCLBCL();
				this.KEFOFHHLINI();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 535f)
			{
				this.DLAFBOCNONH = 1551f;
				this.EBEHKLMOLAG();
				this.ECGLANFCPKB();
			}
		}
	}

	// Token: 0x060095CF RID: 38351 RVA: 0x0041A36C File Offset: 0x0041856C
	private void CHOGMCMNIKA()
	{
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.Fast;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1185f, 1146f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.ONBKONFCNKF)).SetLoops(59, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1696f, 1380f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.ONBKONFCNKF)).SetLoops(3, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(628f, 1107f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PCLKNFOBGJC));
	}

	// Token: 0x060095D0 RID: 38352 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void PODHOCLABIO()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095D1 RID: 38353 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void KFMLOGKINPG()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095D2 RID: 38354 RVA: 0x0041A4B4 File Offset: 0x004186B4
	private void GOFOBEOIELF()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 274f;
	}

	// Token: 0x060095D3 RID: 38355 RVA: 0x0041A4C8 File Offset: 0x004186C8
	private void CBCJABBJFAN()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 912f)
			{
				this.NPLEBHBJEAM();
				this.MKICMLECFFC();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1490f)
			{
				this.DLAFBOCNONH = 461f;
				this.GOFOBEOIELF();
				this.DJIHEOLJHEP();
			}
		}
	}

	// Token: 0x060095D4 RID: 38356 RVA: 0x0041A53F File Offset: 0x0041873F
	private void DMNDEOBBLGI()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = -1f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095D5 RID: 38357 RVA: 0x0041A568 File Offset: 0x00418768
	private void MKICMLECFFC()
	{
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(true);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.Fast;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.Fast;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1006f, 410f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PCLKNFOBGJC)).SetLoops(-37, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(104f, 1764f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GPBMDBPEBEB)).SetLoops(4, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(313f, 952f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PKOHKEDPAAE));
	}

	// Token: 0x060095D6 RID: 38358 RVA: 0x0041A6B0 File Offset: 0x004188B0
	private void ONDMDMMJDOD()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 1300f;
	}

	// Token: 0x060095D7 RID: 38359 RVA: 0x0041A6C4 File Offset: 0x004188C4
	private void OnEnable()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.JHGFOKOFMHB();
		this.Update();
	}

	// Token: 0x060095D8 RID: 38360 RVA: 0x0041A6DE File Offset: 0x004188DE
	private void PKOHKEDPAAE()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1064f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095D9 RID: 38361 RVA: 0x0041A707 File Offset: 0x00418907
	private void AONMDEOALPM()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 448f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095DA RID: 38362 RVA: 0x0041A730 File Offset: 0x00418930
	private void ILMGFGFCHNL()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.NLNBPPBMHMH();
		this.KMEGABEIPBL();
	}

	// Token: 0x060095DB RID: 38363 RVA: 0x0041A74A File Offset: 0x0041894A
	private void DHNNINOOBLA()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1971f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095DC RID: 38364 RVA: 0x0041A773 File Offset: 0x00418973
	private void DJDLHIOMGJB()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.OLFGDFCHEEC();
		this.DNCGCGGCJNE();
	}

	// Token: 0x060095DD RID: 38365 RVA: 0x0017AE42 File Offset: 0x00179042
	private void AODCOGNJPAD()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095DE RID: 38366 RVA: 0x0041A790 File Offset: 0x00418990
	private void LBFFLMMCHFG()
	{
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.Fast;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1822f, 1838f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GPBMDBPEBEB)).SetLoops(199, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1102f, 751f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMNDEOBBLGI)).SetLoops(8, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(513f, 346f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PMECININEKG));
	}

	// Token: 0x060095DF RID: 38367 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDestroy()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095E0 RID: 38368 RVA: 0x0041A8D8 File Offset: 0x00418AD8
	private void ONBKONFCNKF()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 162f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095E1 RID: 38369 RVA: 0x0041A901 File Offset: 0x00418B01
	private void PMECININEKG()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 287f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095E3 RID: 38371 RVA: 0x0041A961 File Offset: 0x00418B61
	private void AOODHKFMHBL()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1274f;
	}

	// Token: 0x060095E4 RID: 38372 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void IABDONMCMPM()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095E5 RID: 38373 RVA: 0x0017AE42 File Offset: 0x00179042
	private void MJGNCOLNIMD()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095E6 RID: 38374 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDisable()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095E7 RID: 38375 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NGEFPBFMCBP()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x060095E8 RID: 38376 RVA: 0x0041A978 File Offset: 0x00418B78
	private void KMEGABEIPBL()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1454f)
			{
				this.ONDMDMMJDOD();
				this.LBFFLMMCHFG();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 67f)
			{
				this.DLAFBOCNONH = 99f;
				this.AOODHKFMHBL();
				this.ECGLANFCPKB();
			}
		}
	}

	// Token: 0x060095E9 RID: 38377 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void GOLKPDKALNC()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095EA RID: 38378 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void BNJLIDFJOGD()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095EB RID: 38379 RVA: 0x0041A9EF File Offset: 0x00418BEF
	private void EHBJOHMNJFH()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.JHGFOKOFMHB();
		this.CEALHCENAGD();
	}

	// Token: 0x060095EC RID: 38380 RVA: 0x0041AA0C File Offset: 0x00418C0C
	private void ECGLANFCPKB()
	{
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.FastBeyond360;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(584f, 137f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PKOHKEDPAAE)).SetLoops(42, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(215f, 555f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DHNNINOOBLA)).SetLoops(5, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(1698f, 1341f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MMHIEPGFBJJ));
	}

	// Token: 0x060095ED RID: 38381 RVA: 0x0041AB54 File Offset: 0x00418D54
	private void GPBMDBPEBEB()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 477f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095EE RID: 38382 RVA: 0x0041AB7D File Offset: 0x00418D7D
	private void GFJBNGMOBAC()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.OLFGDFCHEEC();
		this.NFFGMDALKCE();
	}

	// Token: 0x060095EF RID: 38383 RVA: 0x0041AB98 File Offset: 0x00418D98
	private void CEALHCENAGD()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 182f)
			{
				this.GOFOBEOIELF();
				this.LAKIJEGLFHJ();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1038f)
			{
				this.DLAFBOCNONH = 542f;
				this.OLFGDFCHEEC();
				this.EHGLPNPAHDC();
			}
		}
	}

	// Token: 0x060095F0 RID: 38384 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void GBLJNKDFFJD()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095F1 RID: 38385 RVA: 0x0041AC0F File Offset: 0x00418E0F
	private void KEPIPMNPFCP()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 32f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x060095F2 RID: 38386 RVA: 0x0041AC38 File Offset: 0x00418E38
	private void NOJCABCLBCL()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 1147f;
	}

	// Token: 0x060095F3 RID: 38387 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void PDHDJMJECJA()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095F4 RID: 38388 RVA: 0x0041AC4C File Offset: 0x00418E4C
	private void NLNBPPBMHMH()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 199f;
	}

	// Token: 0x060095F5 RID: 38389 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void LDBOLMLPPHJ()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x060095F6 RID: 38390 RVA: 0x0041AC60 File Offset: 0x00418E60
	private void DJIHEOLJHEP()
	{
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(true);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.FastBeyond360;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.Fast;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(437f, 1876f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.KOOJDNONAOO)).SetLoops(-189, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(1199f, 1757f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.KOOJDNONAOO)).SetLoops(5, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(452f, 1685f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.PMECININEKG));
	}

	// Token: 0x060095F7 RID: 38391 RVA: 0x0041ADA8 File Offset: 0x00418FA8
	private void BDILEIAPNIM()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.NLNBPPBMHMH();
		this.Update();
	}

	// Token: 0x060095F8 RID: 38392 RVA: 0x0041ADC4 File Offset: 0x00418FC4
	private void DNCGCGGCJNE()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1464f)
			{
				this.NOJCABCLBCL();
				this.LAKIJEGLFHJ();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1149f)
			{
				this.DLAFBOCNONH = 1105f;
				this.AOODHKFMHBL();
				this.DJIHEOLJHEP();
			}
		}
	}

	// Token: 0x060095F9 RID: 38393 RVA: 0x0041AE3C File Offset: 0x0041903C
	private void NPBNPBBHJPI()
	{
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(true);
		}
		this.DGAAFGDHHHJ.localRotation = this.NPAMMFFIAOC;
		RotateMode mode = RotateMode.Fast;
		if (this.rotateBeyond360)
		{
			mode = RotateMode.FastBeyond360;
		}
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(318f, 1926f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BKMDLBICEAB)).SetLoops(-87, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DORotate(new Vector3(164f, 15f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GPBMDBPEBEB)).SetLoops(7, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DORotate(new Vector3(1342f, 659f, this.destinationAngleDegrees), this.animationTime, mode).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BKMDLBICEAB));
	}

	// Token: 0x060095FA RID: 38394 RVA: 0x0041AF84 File Offset: 0x00419184
	private void KHOLJLKNAPJ()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.EBEHKLMOLAG();
		this.FIJDKGJEPGC();
	}

	// Token: 0x060095FB RID: 38395 RVA: 0x00419CE9 File Offset: 0x00417EE9
	private void PHHELAPHLOK()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.NPAMMFFIAOC = this.DGAAFGDHHHJ.localRotation;
	}

	// Token: 0x060095FC RID: 38396 RVA: 0x0017AE42 File Offset: 0x00179042
	private void DNANKPMNMIF()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0400298F RID: 10639
	public Ease animationEase = Ease.OutQuad;

	// Token: 0x04002990 RID: 10640
	public float animationTime = 1f;

	// Token: 0x04002991 RID: 10641
	public float destinationAngleDegrees;

	// Token: 0x04002992 RID: 10642
	public bool looped;

	// Token: 0x04002993 RID: 10643
	public LoopType cycleType;

	// Token: 0x04002994 RID: 10644
	public bool repeatOnComplete;

	// Token: 0x04002995 RID: 10645
	public float repeatOnCompleteDelay = 1f;

	// Token: 0x04002996 RID: 10646
	public float delayAtStart;

	// Token: 0x04002997 RID: 10647
	public bool killTweenOnPlay = true;

	// Token: 0x04002998 RID: 10648
	public bool rotateBeyond360;

	// Token: 0x04002999 RID: 10649
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x0400299A RID: 10650
	private float NIMLCJHAAHN = -1f;

	// Token: 0x0400299B RID: 10651
	private float DLAFBOCNONH;

	// Token: 0x0400299C RID: 10652
	private bool DCCKDJLAFPP;

	// Token: 0x0400299D RID: 10653
	private Quaternion NPAMMFFIAOC;
}
