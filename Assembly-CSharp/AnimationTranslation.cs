using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x02000144 RID: 324
public class AnimationTranslation : MonoBehaviour
{
	// Token: 0x06002B2B RID: 11051 RVA: 0x00132A44 File Offset: 0x00130C44
	private void ACJDLLIOGMJ()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1345f)
			{
				this.HNPIGDMHPPF();
				this.KLOMOKAJMKK();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 4 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1573f)
			{
				this.DLAFBOCNONH = 19f;
				this.FFJINOGCNPO();
				this.KLOMOKAJMKK();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 3 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x00132B37 File Offset: 0x00130D37
	private void EIHABGEFOLK()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x00132B68 File Offset: 0x00130D68
	private void LIBECOJEBKI()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = true;
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void HBEJHENNIFG(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x00132BE0 File Offset: 0x00130DE0
	public void GFHBKIAMABC()
	{
		if (!this.GKLCAECKAPD)
		{
			this.CHIEGPIIDMK();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x00132C58 File Offset: 0x00130E58
	public void GGIKIAPIGAB()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x00132CBC File Offset: 0x00130EBC
	public void CNNCHJAGABE()
	{
		if (!this.GKLCAECKAPD)
		{
			this.NNFBLEPIGCO();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x00132B37 File Offset: 0x00130D37
	private void OHPIOAOOMPD()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x00132D32 File Offset: 0x00130F32
	public void NPBNPBBHJPI()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x00132D52 File Offset: 0x00130F52
	public float GBKPPPGELGL()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 1573f;
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x00132D70 File Offset: 0x00130F70
	private void LPLBDKPLGMA()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 17f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = true;
		this.JKAIDMIIHHB();
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x00132DCA File Offset: 0x00130FCA
	public float OJCEHIPNFFD()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(false);
		}
		return 47f;
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x00132DE8 File Offset: 0x00130FE8
	private void PFJBGNOMKFJ()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1889f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = false;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x00132E50 File Offset: 0x00131050
	public void ResetAnchoredPositionOriginalX()
	{
		if (!this.GKLCAECKAPD)
		{
			this.ResetAnchoredPositionOriginal();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x00132EC8 File Offset: 0x001310C8
	private void CKBLBHEBHPH()
	{
		float d = 1f;
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
			if (this.EEKPKANOEFC != null)
			{
				this.EEKPKANOEFC.Kill(false);
			}
			this.EEKPKANOEFC = null;
		}
		if (this.LNGMMALCMPF)
		{
			this.DGAAFGDHHHJ.EKGKENJHKLE();
		}
		if (!this.BBHHFLFJCNL)
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		}
		else
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			this.DGAAFGDHHHJ.AHLJBONHHKL(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC);
			d = -1f;
		}
		this.PNJBCKPMJDP = false;
		if (this.looped)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE)).SetLoops(100000, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE)).SetLoops(2, this.cycleType);
			return;
		}
		if (!this.GOEPJICCLPO)
		{
			if (this.JEMOLKFHHGF < 0f)
			{
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE));
			}
			else
			{
				this.JEMOLKFHHGF = Mathf.Clamp01(this.JEMOLKFHHGF);
				this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * this.JEMOLKFHHGF);
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (1f - this.JEMOLKFHHGF), this.animationTime * (1f - this.JEMOLKFHHGF), false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE));
			}
		}
		else
		{
			float num = 0f;
			for (int i = 0; i < 10; i++)
			{
				num = DPGJIJGOCIC.BOHONBJIIKM(0f, 1f);
				if (Mathf.Abs(num - AnimationTranslation.DGJMIIEKJMN) > 0.33f)
				{
					break;
				}
			}
			AnimationTranslation.DGJMIIEKJMN = num;
			this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * num);
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (1f - num), this.animationTime * (1f - num), false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE));
		}
		this.GOEPJICCLPO = false;
		this.JEMOLKFHHGF = -1f;
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x00133314 File Offset: 0x00131514
	private void FBACIBOFHJO()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1857f;
		}
		this.FFJINOGCNPO();
		this.PNJBCKPMJDP = false;
		this.OEALLIKCBIC();
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x0013336E File Offset: 0x0013156E
	public void FFNGMJCHJJK(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x00133382 File Offset: 0x00131582
	public float GKGCBPBOOGM()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(false);
		}
		return 537f;
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x001333A0 File Offset: 0x001315A0
	public void HIAPNCJOKJF()
	{
		if (!this.GKLCAECKAPD)
		{
			this.GGIKIAPIGAB();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x00133416 File Offset: 0x00131616
	public void LALNCCCIOIC()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.ANGDHJLMKFN();
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x00133436 File Offset: 0x00131636
	private void DMGCMLIGFCG()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x00133468 File Offset: 0x00131668
	public void GDGFFEDFAAI()
	{
		if (!this.GKLCAECKAPD)
		{
			this.IJLGFPGEOAB();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x001334DE File Offset: 0x001316DE
	public float KHMGBJNGDIG()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 560f;
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x001334FC File Offset: 0x001316FC
	private void HILONIKFEIH()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x0013356C File Offset: 0x0013176C
	public void HGMIOJMPMLH()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x001335CD File Offset: 0x001317CD
	private void JAIDEFDDAIB()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x001335FC File Offset: 0x001317FC
	public float GOFCDICHOEO()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 896f;
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x0013336E File Offset: 0x0013156E
	public void PPOOHPLOOLA(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x00133618 File Offset: 0x00131818
	public float GetLerp()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 0f;
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x00133634 File Offset: 0x00131834
	private void NPDBFEBICIK()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 680f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = true;
		this.ACJDLLIOGMJ();
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x00133690 File Offset: 0x00131890
	private void LDLMOGJIHFC()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 155f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = true;
		this.KMMEFNOCPOO();
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x0013336E File Offset: 0x0013156E
	public void JNMIPNKPAHC(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x001336EC File Offset: 0x001318EC
	private void DJDLHIOMGJB()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1066f;
		}
		this.IFONNBIFPFA();
		this.PNJBCKPMJDP = true;
		this.KMMEFNOCPOO();
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x00133746 File Offset: 0x00131946
	public float AIENCNCMPFA()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 6f;
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x00133764 File Offset: 0x00131964
	private void JKAIDMIIHHB()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1307f)
			{
				this.FFJINOGCNPO();
				this.KLOMOKAJMKK();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 8 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 754f)
			{
				this.DLAFBOCNONH = 809f;
				this.FFJINOGCNPO();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 4 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x00132D32 File Offset: 0x00130F32
	public void FFKFIKPGJDI()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x00133858 File Offset: 0x00131A58
	private void FOBJABNIPPB()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 896f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = false;
		this.KMMEFNOCPOO();
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void JLILGENMENM()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x001338E4 File Offset: 0x00131AE4
	private void BOAEKDACMFC()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 260f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = true;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x0013394C File Offset: 0x00131B4C
	public void ResetAnchoredPositionOriginal()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x00133436 File Offset: 0x00131636
	private void KLPGHNELPIH()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x00133416 File Offset: 0x00131616
	public void PGKFNLNMIHN()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.ANGDHJLMKFN();
	}

	// Token: 0x06002B55 RID: 11093 RVA: 0x00132B37 File Offset: 0x00130D37
	private void KNPBDPGCMOJ()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B56 RID: 11094 RVA: 0x001339B0 File Offset: 0x00131BB0
	private void KNBBPNKLFAA()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1839f)
			{
				this.FFJINOGCNPO();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 6 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1552f)
			{
				this.DLAFBOCNONH = 1923f;
				this.IFONNBIFPFA();
				this.KLOMOKAJMKK();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 8 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B57 RID: 11095 RVA: 0x00133AA4 File Offset: 0x00131CA4
	private void EIIKCHOGIBH()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = true;
	}

	// Token: 0x06002B58 RID: 11096 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void DJIFHJDBBHN()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x0013336E File Offset: 0x0013156E
	public void POKKFLGNMCF(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x00133B14 File Offset: 0x00131D14
	public float AKFHLAKDFIF()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(false);
		}
		return 123f;
	}

	// Token: 0x06002B5B RID: 11099 RVA: 0x00133B30 File Offset: 0x00131D30
	public void CHIEGPIIDMK()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x00132B37 File Offset: 0x00130D37
	private void IAJMGGFACOD()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x00133436 File Offset: 0x00131636
	private void IMHILNMKAIN()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x00133B91 File Offset: 0x00131D91
	public float NMNINGHAPCA()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(false);
		}
		return 1233f;
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x00133416 File Offset: 0x00131616
	public void LEEKMKMKKAC()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.ANGDHJLMKFN();
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x00133BB0 File Offset: 0x00131DB0
	private void EFIBBLFAMGD()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1849f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = false;
		this.KMMEFNOCPOO();
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x00133C0A File Offset: 0x00131E0A
	public float DCLDOBECHJD()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(false);
		}
		return 692f;
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x00133C28 File Offset: 0x00131E28
	private void JLCMPGICMDC()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = false;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1800f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = true;
		this.JKAIDMIIHHB();
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x00133C84 File Offset: 0x00131E84
	private void ECDEPAAOGHC()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 382f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = true;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x00133CEC File Offset: 0x00131EEC
	private void NPFILNGGHGH()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x00133D5C File Offset: 0x00131F5C
	private void EFOBIAOGBHP()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x00133DCC File Offset: 0x00131FCC
	private void MKBADGCCNDJ()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1282f;
		}
		this.IFONNBIFPFA();
		this.PNJBCKPMJDP = true;
		this.OEALLIKCBIC();
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x00133E28 File Offset: 0x00132028
	public void KKKAJJDOLAO()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x00133E89 File Offset: 0x00132089
	public void PlayAnimation()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.CKBLBHEBHPH();
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x00133EAC File Offset: 0x001320AC
	private void EGJMFKHKNCK()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1482f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = true;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x00133F14 File Offset: 0x00132114
	public void BPCMFPCBLAD()
	{
		if (!this.GKLCAECKAPD)
		{
			this.KKKAJJDOLAO();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x00133416 File Offset: 0x00131616
	public void DODGGGHNHCD()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.ANGDHJLMKFN();
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x00133F8A File Offset: 0x0013218A
	public float PBGACPLFKJC()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 413f;
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x00133FA8 File Offset: 0x001321A8
	public void DCDMGPNPBCL()
	{
		if (!this.GKLCAECKAPD)
		{
			this.JGHEJEAALMC();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x00134020 File Offset: 0x00132220
	public void IJLGFPGEOAB()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x0013336E File Offset: 0x0013156E
	public void OIGNMAPLGIK(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x00134081 File Offset: 0x00132281
	public float IEJEDGFMCKD()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 301f;
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x00133416 File Offset: 0x00131616
	public void FNNJAFDDBHH()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.ANGDHJLMKFN();
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void JLNPLOIAGLL(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x00132D32 File Offset: 0x00130F32
	public void HEGKDADPNNG()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x001340A0 File Offset: 0x001322A0
	private void FKIBNDJMJOL()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 666f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = false;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x00134108 File Offset: 0x00132308
	private void EOAKHNIJECB()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 824f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = true;
		this.KMMEFNOCPOO();
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x00134164 File Offset: 0x00132364
	private void Awake()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = true;
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x001341D4 File Offset: 0x001323D4
	private void DFGMMBJLDIB()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 637f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = true;
				this.BBHHFLFJCNL = this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x0013423C File Offset: 0x0013243C
	private void KDLMMHEAPNH()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = true;
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x001342AC File Offset: 0x001324AC
	public void NMLKEOBPMDM()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x00132D32 File Offset: 0x00130F32
	public void COLNALFMOHC()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void KKPOMOMKOFF(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x00134378 File Offset: 0x00132578
	private void AADMBDFACAJ()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 502f)
			{
				this.JHGFOKOFMHB();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 6 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 558f)
			{
				this.DLAFBOCNONH = 1399f;
				this.FFJINOGCNPO();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 0 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void EPHPGCDPLAG(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x0013446B File Offset: 0x0013266B
	public void PBMCHKLBOHL(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 1;
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x0013447F File Offset: 0x0013267F
	public float BBDIJGEBLDG()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 514f;
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x0013449C File Offset: 0x0013269C
	private void OFLPHDKOJOP()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1500f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = false;
		this.JKAIDMIIHHB();
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x001344F8 File Offset: 0x001326F8
	public void JGHEJEAALMC()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x0013455C File Offset: 0x0013275C
	private void OHLGFODHMLD()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1009f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = false;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = false;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x00133436 File Offset: 0x00131636
	private void IEKKNHMNBBK()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x0013336E File Offset: 0x0013156E
	public void IDADDLKEOEN(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 0;
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x001345C4 File Offset: 0x001327C4
	public void FKFKMGJPGKA()
	{
		if (!this.GKLCAECKAPD)
		{
			this.IMMHABKJBCH();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void GMPIOAHIKPP()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x001335CD File Offset: 0x001317CD
	private void GLBHMBIHNFN()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(true);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x0013463C File Offset: 0x0013283C
	public void JOIKGPCEHBN()
	{
		if (!this.GKLCAECKAPD)
		{
			this.IJLGFPGEOAB();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x001346B4 File Offset: 0x001328B4
	public void KJNNHLJGKAO()
	{
		if (!this.GKLCAECKAPD)
		{
			this.ResetAnchoredPositionOriginal();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void HGNPNNKGNLG()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x0013472C File Offset: 0x0013292C
	private void KLKMGHDBFKK()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1196f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = false;
		this.OEALLIKCBIC();
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x00134788 File Offset: 0x00132988
	private void KMMEFNOCPOO()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 702f)
			{
				this.IFONNBIFPFA();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 4 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 810f)
			{
				this.DLAFBOCNONH = 19f;
				this.FFJINOGCNPO();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 5 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x0013487C File Offset: 0x00132A7C
	public void IMMHABKJBCH()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x001348DD File Offset: 0x00132ADD
	private void FFJINOGCNPO()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 976f;
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x001348F4 File Offset: 0x00132AF4
	public void NNFBLEPIGCO()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x00134955 File Offset: 0x00132B55
	private void HNPIGDMHPPF()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 765f;
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x00132D32 File Offset: 0x00130F32
	public void DJIHEOLJHEP()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void MGFIMBGIMDG(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x0013496C File Offset: 0x00132B6C
	private void OEALLIKCBIC()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1073f)
			{
				this.JHGFOKOFMHB();
				this.ANGDHJLMKFN();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 1 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1596f)
			{
				this.DLAFBOCNONH = 399f;
				this.HNPIGDMHPPF();
				this.ANGDHJLMKFN();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 2 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = true;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x00132B37 File Offset: 0x00130D37
	private void JPPBJKKNIED()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x00134A60 File Offset: 0x00132C60
	private void LCCCCHNJEMB()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x00134AD0 File Offset: 0x00132CD0
	public float KFCJJLICMFG()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 1020f;
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x00134AEC File Offset: 0x00132CEC
	public void GIGOLBODLKI()
	{
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		}
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x00132B37 File Offset: 0x00130D37
	private void OnDestroy()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x00134B50 File Offset: 0x00132D50
	private void OJGELECJGJC()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x00134BC0 File Offset: 0x00132DC0
	private void NJKJLLPKDNC()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1301f;
		}
		this.IFONNBIFPFA();
		this.PNJBCKPMJDP = false;
		this.JKAIDMIIHHB();
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x0013446B File Offset: 0x0013266B
	public void BPCOKLEABJD(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 1;
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void SetTranslationSystemVersion(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x00134C1C File Offset: 0x00132E1C
	public void CGFFPLHKOEC()
	{
		if (!this.GKLCAECKAPD)
		{
			this.NMLKEOBPMDM();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x00134C94 File Offset: 0x00132E94
	private void OnEnable()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 10000000f;
		}
		this.JHGFOKOFMHB();
		this.PNJBCKPMJDP = true;
		this.Update();
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x00134CF0 File Offset: 0x00132EF0
	public void OMKHMEJLJII()
	{
		if (!this.GKLCAECKAPD)
		{
			this.KKKAJJDOLAO();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void PFEIKOLDANA()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x00134D68 File Offset: 0x00132F68
	private void KLOMOKAJMKK()
	{
		float d = 1925f;
		this.DCCKDJLAFPP = true;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
			if (this.EEKPKANOEFC != null)
			{
				this.EEKPKANOEFC.Kill(true);
			}
			this.EEKPKANOEFC = null;
		}
		if (this.LNGMMALCMPF)
		{
			this.DGAAFGDHHHJ.EKGKENJHKLE();
		}
		if (!this.BBHHFLFJCNL)
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		}
		else
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			this.DGAAFGDHHHJ.AHLJBONHHKL(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC);
			d = 1818f;
		}
		this.PNJBCKPMJDP = true;
		if (this.looped)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE)).SetLoops(-195, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DFGMMBJLDIB)).SetLoops(2, this.cycleType);
			return;
		}
		if (!this.GOEPJICCLPO)
		{
			if (this.JEMOLKFHHGF < 1274f)
			{
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.ECDEPAAOGHC));
			}
			else
			{
				this.JEMOLKFHHGF = Mathf.Clamp01(this.JEMOLKFHHGF);
				this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * this.JEMOLKFHHGF);
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (1803f - this.JEMOLKFHHGF), this.animationTime * (946f - this.JEMOLKFHHGF), true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BOAEKDACMFC));
			}
		}
		else
		{
			float num = 445f;
			for (int i = 0; i < 57; i++)
			{
				num = DPGJIJGOCIC.BOHONBJIIKM(1671f, 1782f);
				if (Mathf.Abs(num - AnimationTranslation.DGJMIIEKJMN) > 1305f)
				{
					break;
				}
			}
			AnimationTranslation.DGJMIIEKJMN = num;
			this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * num);
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (737f - num), this.animationTime * (423f - num), false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.MCKBKCHPPNE));
		}
		this.GOEPJICCLPO = true;
		this.JEMOLKFHHGF = 1845f;
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x001351B4 File Offset: 0x001333B4
	private void JJIGCFGKFHO()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 283f;
		}
		this.IFONNBIFPFA();
		this.PNJBCKPMJDP = false;
		this.JKAIDMIIHHB();
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x0013520E File Offset: 0x0013340E
	public float LBPEEJGLJFC()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 1922f;
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x0013522C File Offset: 0x0013342C
	private void MOAHMBJJGOH()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 759f;
		}
		this.IFONNBIFPFA();
		this.PNJBCKPMJDP = false;
		this.ACJDLLIOGMJ();
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x00135286 File Offset: 0x00133486
	private void JHGFOKOFMHB()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = -1f;
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x0013529C File Offset: 0x0013349C
	private void Update()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 0f)
			{
				this.JHGFOKOFMHB();
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 2 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
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
				this.CKBLBHEBHPH();
				return;
			}
			if (AnimationTranslation.animationTranslationVersion >= 2 && this.PNJBCKPMJDP)
			{
				this.PNJBCKPMJDP = false;
				this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			}
		}
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x0013538F File Offset: 0x0013358F
	private void IFONNBIFPFA()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 738f;
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x001353A4 File Offset: 0x001335A4
	public void DEFDHOHOECC()
	{
		if (!this.GKLCAECKAPD)
		{
			this.JGHEJEAALMC();
			return;
		}
		if (null == this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		}
		if (null != this.DGAAFGDHHHJ)
		{
			this.HCOLPEBENOF = new Vector2(this.DGAAFGDHHHJ.anchoredPosition.x + this.offsetAtStartX, this.HCOLPEBENOF.y);
		}
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x0013541C File Offset: 0x0013361C
	private void HMKMNGBBOMF()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x0013446B File Offset: 0x0013266B
	public void SetDirection(bool GEAPJFPNBIM = false)
	{
		if (GEAPJFPNBIM)
		{
			this.OPJPPAKGDLC = -1;
			return;
		}
		this.OPJPPAKGDLC = 1;
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x00132D32 File Offset: 0x00130F32
	public void OPFMGNNLPJD()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x001338B2 File Offset: 0x00131AB2
	private void LJCCPAJALKD()
	{
		base.gameObject.transform.DOKill(true);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x0013548C File Offset: 0x0013368C
	private void OAPJBCOGOMK()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x001354FC File Offset: 0x001336FC
	private void HBELNHOMGCI()
	{
		this.LNGMMALCMPF = false;
		this.BBHHFLFJCNL = false;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 979f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = true;
		this.KNBBPNKLFAA();
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x00132D32 File Offset: 0x00130F32
	public void ECDILLNILIP()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.KLOMOKAJMKK();
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x00135558 File Offset: 0x00133758
	private void GFJBNGMOBAC()
	{
		this.LNGMMALCMPF = true;
		this.BBHHFLFJCNL = true;
		this.DGAAFGDHHHJ.IMGKEIAKLOH();
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 1646f;
		}
		this.HNPIGDMHPPF();
		this.PNJBCKPMJDP = true;
		this.Update();
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x00132BD8 File Offset: 0x00130DD8
	public static void IGLFFKAMKJK(int IALPHEADDFO)
	{
		AnimationTranslation.animationTranslationVersion = IALPHEADDFO;
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x001355B4 File Offset: 0x001337B4
	private void DCMMAADPBPM()
	{
		this.GOEPJICCLPO = this.randomSeed;
		this.JEMOLKFHHGF = this.randomSeedValue;
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.offsetAtStartX, this.offsetAtStartY);
		this.GKLCAECKAPD = false;
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x00135624 File Offset: 0x00133824
	private void ANGDHJLMKFN()
	{
		float d = 172f;
		this.DCCKDJLAFPP = false;
		if (this.killTweenOnPlay)
		{
			base.gameObject.transform.DOKill(false);
			if (this.EEKPKANOEFC != null)
			{
				this.EEKPKANOEFC.Kill(false);
			}
			this.EEKPKANOEFC = null;
		}
		if (this.LNGMMALCMPF)
		{
			this.DGAAFGDHHHJ.EKGKENJHKLE();
		}
		if (!this.BBHHFLFJCNL)
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
		}
		else
		{
			this.DGAAFGDHHHJ.OGOFACPLOGO((int)this.HCOLPEBENOF.x, (int)this.HCOLPEBENOF.y);
			this.DGAAFGDHHHJ.AHLJBONHHKL(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC);
			d = 76f;
		}
		this.PNJBCKPMJDP = false;
		if (this.looped)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BOAEKDACMFC)).SetLoops(-97, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EGJMFKHKNCK)).SetLoops(6, this.cycleType);
			return;
		}
		if (!this.GOEPJICCLPO)
		{
			if (this.JEMOLKFHHGF < 57f)
			{
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d, this.animationTime, false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.FKIBNDJMJOL));
			}
			else
			{
				this.JEMOLKFHHGF = Mathf.Clamp01(this.JEMOLKFHHGF);
				this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * this.JEMOLKFHHGF);
				this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (1655f - this.JEMOLKFHHGF), this.animationTime * (417f - this.JEMOLKFHHGF), true).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EGJMFKHKNCK));
			}
		}
		else
		{
			float num = 1245f;
			for (int i = 1; i < 76; i++)
			{
				num = DPGJIJGOCIC.GJBHHIMLIGB(350f, 1004f);
				if (Mathf.Abs(num - AnimationTranslation.DGJMIIEKJMN) > 92f)
				{
					break;
				}
			}
			AnimationTranslation.DGJMIIEKJMN = num;
			this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * num);
			this.EEKPKANOEFC = this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(this.translationAmountX * (float)this.OPJPPAKGDLC, this.translationAmountY * (float)this.OPJPPAKGDLC) * d * (1411f - num), this.animationTime * (1690f - num), false).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DFGMMBJLDIB));
		}
		this.GOEPJICCLPO = false;
		this.JEMOLKFHHGF = 1853f;
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x00132B37 File Offset: 0x00130D37
	private void OnDisable()
	{
		base.gameObject.transform.DOKill(false);
		if (this.EEKPKANOEFC != null)
		{
			this.EEKPKANOEFC.Kill(false);
		}
		this.EEKPKANOEFC = null;
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x00135A6E File Offset: 0x00133C6E
	public float KGENIBCLJHD()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 1511f;
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x00135A8C File Offset: 0x00133C8C
	private void MCKBKCHPPNE()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = -1f;
			if (this.disableOnComplete)
			{
				base.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			this.DCCKDJLAFPP = true;
			this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
			if (this.flipAnimationOnComplete)
			{
				this.LNGMMALCMPF = true;
				this.BBHHFLFJCNL = !this.BBHHFLFJCNL;
			}
		}
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x00135AF2 File Offset: 0x00133CF2
	public float JFKMPNANMPA()
	{
		if (this.EEKPKANOEFC != null)
		{
			return this.EEKPKANOEFC.ElapsedPercentage(true);
		}
		return 599f;
	}

	// Token: 0x04000CE4 RID: 3300
	public static int animationTranslationVersion;

	// Token: 0x04000CE5 RID: 3301
	public Ease animationEase = Ease.OutQuad;

	// Token: 0x04000CE6 RID: 3302
	public float animationTime = 1f;

	// Token: 0x04000CE7 RID: 3303
	public float translationAmountX;

	// Token: 0x04000CE8 RID: 3304
	public float translationAmountY;

	// Token: 0x04000CE9 RID: 3305
	public float offsetAtStartX;

	// Token: 0x04000CEA RID: 3306
	public float offsetAtStartY;

	// Token: 0x04000CEB RID: 3307
	[NonSerialized]
	private bool GKLCAECKAPD;

	// Token: 0x04000CEC RID: 3308
	public bool looped;

	// Token: 0x04000CED RID: 3309
	public LoopType cycleType;

	// Token: 0x04000CEE RID: 3310
	public bool repeatOnComplete;

	// Token: 0x04000CEF RID: 3311
	public float repeatOnCompleteDelay = 1f;

	// Token: 0x04000CF0 RID: 3312
	public bool flipAnimationOnComplete;

	// Token: 0x04000CF1 RID: 3313
	public float delayAtStart;

	// Token: 0x04000CF2 RID: 3314
	public bool playOnEnable = true;

	// Token: 0x04000CF3 RID: 3315
	public bool killTweenOnPlay = true;

	// Token: 0x04000CF4 RID: 3316
	public bool randomSeed;

	// Token: 0x04000CF5 RID: 3317
	public float randomSeedValue = -1f;

	// Token: 0x04000CF6 RID: 3318
	public bool disableOnComplete;

	// Token: 0x04000CF7 RID: 3319
	private Vector2 HCOLPEBENOF;

	// Token: 0x04000CF8 RID: 3320
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04000CF9 RID: 3321
	private float NIMLCJHAAHN = -1f;

	// Token: 0x04000CFA RID: 3322
	private float DLAFBOCNONH;

	// Token: 0x04000CFB RID: 3323
	private bool DCCKDJLAFPP;

	// Token: 0x04000CFC RID: 3324
	private int OPJPPAKGDLC = 1;

	// Token: 0x04000CFD RID: 3325
	private bool LNGMMALCMPF;

	// Token: 0x04000CFE RID: 3326
	private bool BBHHFLFJCNL;

	// Token: 0x04000CFF RID: 3327
	private bool GOEPJICCLPO;

	// Token: 0x04000D00 RID: 3328
	private float JEMOLKFHHGF = -1f;

	// Token: 0x04000D01 RID: 3329
	private Tweener EEKPKANOEFC;

	// Token: 0x04000D02 RID: 3330
	private static float DGJMIIEKJMN;

	// Token: 0x04000D03 RID: 3331
	private bool PNJBCKPMJDP;
}
