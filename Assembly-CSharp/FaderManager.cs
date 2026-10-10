using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000128 RID: 296
public class FaderManager : MonoBehaviour
{
	// Token: 0x060026AC RID: 9900 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void PGAKMFFEHCO(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x0011CB98 File Offset: 0x0011AD98
	private void KJMJHCDFOED()
	{
		if (null != this.GHGABICPEJD)
		{
			Color color = new Color(359f, 659f, 1841f, 251f);
			color.r = this.GHGABICPEJD.color.r;
			color.g = this.GHGABICPEJD.color.g;
			color.b = this.GHGABICPEJD.color.b;
			color.a = 1755f;
			this.GHGABICPEJD.color = color;
		}
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void BALMIKEHHJL()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x0011CC4C File Offset: 0x0011AE4C
	private void LABLLDOFBJH()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.JFGNJFDDBDP();
			this.ODHKHJJPADF();
		}
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x0011CCB4 File Offset: 0x0011AEB4
	public void PAPMJOLHFFC(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.LABLLDOFBJH();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x0011CCCC File Offset: 0x0011AECC
	public void FadeIn(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(0f, 1f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x0011CD20 File Offset: 0x0011AF20
	public void DOLHLEBOPCA(TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		if (this.KPJHPLPCKIC(true, this.LDMGAJOLHHC, this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(false);
			this.ILCNKAEMKCJ = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(false);
			this.GHGABICPEJD.NFIPIOOJPEK(122f, 1038f, this.LDMGAJOLHHC, Ease.InCubic, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.MIANFIGMPLC(1531f, this.LDMGAJOLHHC, Ease.Unset, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x0011CDDB File Offset: 0x0011AFDB
	private void LAFCNAHCIFJ()
	{
		if (null == this.GHGABICPEJD)
		{
			this.GHGABICPEJD = base.gameObject.GetComponentInChildren<Image>();
			this.AGOOCIEAHFD();
		}
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float GKLEDGCKENH()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x0011CE0C File Offset: 0x0011B00C
	private void NNIDHCNOAJF()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.ABMNGNPMDPG();
			this.KJMJHCDFOED();
		}
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x0011CE74 File Offset: 0x0011B074
	public void DDPJIEHHOLL(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 1866f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1647f, 668f, this.BNHPMPPAAGB, Ease.Linear, new TweenCallback(this.DKLOGILHLNK));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(1170f, 1036f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.Unset, new TweenCallback(this.PAIAJJGKKBC));
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x0011CF00 File Offset: 0x0011B100
	public void FadeOut(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1f, 0f, this.BNHPMPPAAGB, PLFJHEJEHGB, new TweenCallback(this.ACJPGDEBBOI));
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x0011CF54 File Offset: 0x0011B154
	private void CENPBOPOHAI()
	{
		if (null != this.GHGABICPEJD)
		{
			Color color = new Color(534f, 1806f, 245f, 687f);
			color.r = this.GHGABICPEJD.color.r;
			color.g = this.GHGABICPEJD.color.g;
			color.b = this.GHGABICPEJD.color.b;
			color.a = 420f;
			this.GHGABICPEJD.color = color;
		}
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void FGGGNOIADBB(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x0011CFFC File Offset: 0x0011B1FC
	public void CJJMALOECOK(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 1961f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1466f, 1421f, this.BNHPMPPAAGB, Ease.Linear, new TweenCallback(this.BAJCGCDEJHN));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(788f, 1544f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.Unset, new TweenCallback(this.PAIAJJGKKBC));
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x0011D086 File Offset: 0x0011B286
	private void AGOOCIEAHFD()
	{
		if (null != this.GHGABICPEJD)
		{
			this.KLCPALLLLBH = this.GHGABICPEJD.color;
		}
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x0011D0A8 File Offset: 0x0011B2A8
	public void NMAMHCPIJKA(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BANBAANIDFE();
		float num = this.BNHPMPPAAGB;
		if (HMMBGAOOOBD > 806f)
		{
			num = HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
		}
		if (this.LLFEGPKNEAA(false, num, 1741f))
		{
			this.GHGABICPEJD.DOKill(false);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(158f, 198f, num, Ease.InSine, new TweenCallback(this.PAIAJJGKKBC));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1928f, 557f, num, Ease.InQuad, new TweenCallback(this.PAIAJJGKKBC));
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x0011D16A File Offset: 0x0011B36A
	public void BJIGLKGLAKM(TweenCallback CDFFMKAOAGE = null)
	{
		this.NNLFACPFOJH(1565f, CDFFMKAOAGE);
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x0011D178 File Offset: 0x0011B378
	private void IMFBCCBHABF()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.ABMNGNPMDPG();
			this.CENPBOPOHAI();
		}
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x0011D1E0 File Offset: 0x0011B3E0
	public void EEACANAGFEJ(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 1299f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(625f, 264f, this.BNHPMPPAAGB, Ease.InCubic, new TweenCallback(this.BAJCGCDEJHN));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(1314f, 1345f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.OutQuad, new TweenCallback(this.OFJEIMFLBOD));
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x0011D26A File Offset: 0x0011B46A
	public void EBHGDIEBJKI()
	{
		this.LAFCNAHCIFJ();
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.DOKill(true);
		this.SetCustomFader(null, null);
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x0011D298 File Offset: 0x0011B498
	public float FMHFHEHEICP()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void BEHIOPAHKKI(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x0011D298 File Offset: 0x0011B498
	public float HBKHIMPLLIK()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x0011D2A0 File Offset: 0x0011B4A0
	public void BOOFALLNOMA(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(12f, 673f, this.BNHPMPPAAGB, PLFJHEJEHGB, new TweenCallback(this.BAJCGCDEJHN));
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float IHEEFJDCCOA()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x0011D2F3 File Offset: 0x0011B4F3
	private void ALNEPGKEOLA()
	{
		if (this.ILCNKAEMKCJ != null)
		{
			this.ILCNKAEMKCJ();
			this.ILCNKAEMKCJ = null;
		}
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x0011D30F File Offset: 0x0011B50F
	public void FadeOut(TweenCallback CDFFMKAOAGE = null)
	{
		this.FadeOutWithCustomFader(-1f, CDFFMKAOAGE);
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAAEEMDBPHC()
	{
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x0011D31D File Offset: 0x0011B51D
	public void BBENFFEFCIO(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.DLEGIEGEJMJ();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x00003E52 File Offset: 0x00002052
	private void DEOBBAHAMLD()
	{
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x0011D334 File Offset: 0x0011B534
	public void FadeInFromCurrent(TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		if (this.KPJHPLPCKIC(false, this.LDMGAJOLHHC, this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(false);
			this.ILCNKAEMKCJ = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(1f, 1f, this.LDMGAJOLHHC, Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.MIANFIGMPLC(1f, this.LDMGAJOLHHC, Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x0011D3F0 File Offset: 0x0011B5F0
	public void FadeInWithCustomFader(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		float num = this.LDMGAJOLHHC;
		if (HMMBGAOOOBD > 0f)
		{
			num = HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
		}
		if (this.KPJHPLPCKIC(false, num, 0f))
		{
			this.GHGABICPEJD.DOKill(false);
			this.ILCNKAEMKCJ = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(1f, 1f, num, Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(0f, 1f, num, Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x0011D4B2 File Offset: 0x0011B6B2
	public void Reset()
	{
		this.BAMHPOCKBML();
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.DOKill(false);
		this.SetCustomFader(null, null);
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float HAPOOPGALOC()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x0011D4E0 File Offset: 0x0011B6E0
	private bool KPJHPLPCKIC(bool LGEKCMNIJCF, float HMMBGAOOOBD, float KJCLAIJCDIO)
	{
		if (null != this.HDODMPLBBGD)
		{
			try
			{
				this.OLCPDCOLHMN();
				ImageFrameAnimation imageFrameAnimation = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (imageFrameAnimation != null)
				{
					UnityEngine.Object.Destroy(imageFrameAnimation);
				}
				imageFrameAnimation = base.gameObject.AddComponent<ImageFrameAnimation>();
				int num = this.HDODMPLBBGD.frames.Count;
				if (KJCLAIJCDIO < 0.0001f)
				{
					KJCLAIJCDIO = 0f;
					imageFrameAnimation.framesSD = this.HDODMPLBBGD.frames.ToArray();
				}
				else
				{
					num = (int)((float)num * (1f - KJCLAIJCDIO));
					if (num <= 0)
					{
						num = 1;
					}
					imageFrameAnimation.framesSD = new Sprite[num];
					if (this.HDODMPLBBGD.reverseDirection)
					{
						for (int i = 0; i < num; i++)
						{
							imageFrameAnimation.framesSD[i] = this.HDODMPLBBGD.frames[i];
						}
					}
					else
					{
						for (int j = 0; j < num; j++)
						{
							imageFrameAnimation.framesSD[j] = this.HDODMPLBBGD.frames[j + (this.HDODMPLBBGD.frames.Count - num)];
						}
					}
				}
				imageFrameAnimation.forceUpdateOnEnable = true;
				imageFrameAnimation.forcedVersion = 2;
				if (num > 0)
				{
					if (this.NIDEHPGHNLH != null && this.NIDEHPGHNLH.forcedAnimationTime > 0f)
					{
						if (HMMBGAOOOBD <= this.NIDEHPGHNLH.forcedAnimationTime)
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 1;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 0;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
							if (imageFrameAnimation.frameChangeInterval <= 0f)
							{
								imageFrameAnimation.frameChangeInterval = 0.041666668f;
							}
						}
						else
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 1;
								imageFrameAnimation.pauseTime = 1000000f;
								imageFrameAnimation.frameChangeInterval = this.NIDEHPGHNLH.forcedAnimationTime / (float)num;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 0;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD - this.NIDEHPGHNLH.forcedAnimationTime + this.NIDEHPGHNLH.forcedAnimationTime / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
								imageFrameAnimation.frameChangeInterval = (this.NIDEHPGHNLH.forcedAnimationTime - imageFrameAnimation.pauseTime) / (float)num;
							}
							if (imageFrameAnimation.frameChangeInterval <= 0f)
							{
								imageFrameAnimation.frameChangeInterval = 0.041666668f;
							}
						}
					}
					else
					{
						if (!LGEKCMNIJCF)
						{
							imageFrameAnimation.pauseFrame = num - 1;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						else
						{
							imageFrameAnimation.pauseFrame = 0;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
						if (imageFrameAnimation.frameChangeInterval <= 0f)
						{
							imageFrameAnimation.frameChangeInterval = 0.041666668f;
						}
					}
				}
				else
				{
					imageFrameAnimation.frameChangeInterval = 0.041666668f;
				}
				if (LGEKCMNIJCF)
				{
					imageFrameAnimation.reverseDirection = !this.HDODMPLBBGD.reverseDirection;
				}
				else
				{
					imageFrameAnimation.reverseDirection = this.HDODMPLBBGD.reverseDirection;
				}
				imageFrameAnimation.isLooped = false;
				return true;
			}
			catch (Exception aklgbjkdomm)
			{
				this.LABLLDOFBJH();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return false;
			}
		}
		this.GHGABICPEJD.sprite = null;
		return false;
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x0011D298 File Offset: 0x0011B498
	public float PKMHJDPCOJA()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void HONBNKGALNF()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x0011D82C File Offset: 0x0011BA2C
	public void FadeOut(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 0f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1f, 0f, this.BNHPMPPAAGB, Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(1f, 0f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x0011D8B6 File Offset: 0x0011BAB6
	private void OFJEIMFLBOD()
	{
		this.AFMHNHIGDLG();
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (this.OGPFOBCCLIF != null)
		{
			this.OGPFOBCCLIF();
			this.OGPFOBCCLIF = null;
		}
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x0011D298 File Offset: 0x0011B498
	public float PAOPACADDGC()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x0011D8EC File Offset: 0x0011BAEC
	private void BMGIDCDKLBE()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.ABMNGNPMDPG();
			this.ODHKHJJPADF();
		}
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x0011D086 File Offset: 0x0011B286
	private void DENJEGKHNCJ()
	{
		if (null != this.GHGABICPEJD)
		{
			this.KLCPALLLLBH = this.GHGABICPEJD.color;
		}
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void HCMMPBLKCEF(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x0011D954 File Offset: 0x0011BB54
	private void AALDINEPEHJ()
	{
		this.MPOEFJBEKIJ();
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float GGKGCBCDMGG()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void OOKMEJPHCBB(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x0011D95C File Offset: 0x0011BB5C
	public void BLHBIOPPOBF(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1431f, 419f, this.BNHPMPPAAGB, PLFJHEJEHGB, new TweenCallback(this.DKLOGILHLNK));
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x0011D9B0 File Offset: 0x0011BBB0
	public IJKJHDGGAEB GetFaderState()
	{
		this.BAMHPOCKBML();
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 1f))
		{
			return IJKJHDGGAEB.opaque;
		}
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 0f))
		{
			return IJKJHDGGAEB.transparent;
		}
		return IJKJHDGGAEB.busy;
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x0011DA00 File Offset: 0x0011BC00
	private void BCHHCAKLHLO()
	{
		if (null == this.GHGABICPEJD)
		{
			this.GHGABICPEJD = base.gameObject.GetComponentInChildren<Image>();
			this.DENJEGKHNCJ();
		}
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x0011D298 File Offset: 0x0011B498
	public float PGHPDOHILHE()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x0011DA27 File Offset: 0x0011BC27
	public void PACBMBLIGNN(TweenCallback CDFFMKAOAGE = null)
	{
		this.FadeInWithCustomFader(789f, CDFFMKAOAGE);
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x00003E52 File Offset: 0x00002052
	private void MGKMJOOPHNN()
	{
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x0011DA38 File Offset: 0x0011BC38
	public void KGLNMHNFFIK(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		if (HMMBGAOOOBD < 952f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(740f, 486f, this.LDMGAJOLHHC, Ease.InOutQuad, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(1524f, 52f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.OutQuad, new TweenCallback(this.ALNEPGKEOLA));
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x0011DAC4 File Offset: 0x0011BCC4
	public void FadeOutWithCustomFader(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		float num = this.BNHPMPPAAGB;
		if (HMMBGAOOOBD > 0f)
		{
			num = HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
		}
		if (this.KPJHPLPCKIC(true, num, 0f))
		{
			this.GHGABICPEJD.DOKill(false);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(1f, 1f, num, Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1f, 0f, num, Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x0011DB86 File Offset: 0x0011BD86
	public void NCNBINOFOJM()
	{
		this.BAMHPOCKBML();
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.DOKill(false);
		this.HKOPLOKFPCL(null, null);
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x0011DBB4 File Offset: 0x0011BDB4
	public void HAKHLNMPEIN(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.MPOEFJBEKIJ();
		float num = this.BNHPMPPAAGB;
		if (HMMBGAOOOBD > 1524f)
		{
			num = HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
		}
		if (this.LLFEGPKNEAA(true, num, 804f))
		{
			this.GHGABICPEJD.DOKill(false);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(false);
			this.GHGABICPEJD.NFIPIOOJPEK(1338f, 1787f, num, Ease.InQuad, new TweenCallback(this.DKLOGILHLNK));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(1402f, 319f, num, Ease.InSine, new TweenCallback(this.BAJCGCDEJHN));
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x0011DC78 File Offset: 0x0011BE78
	private void ODHKHJJPADF()
	{
		if (null != this.GHGABICPEJD)
		{
			Color color = new Color(1f, 1f, 1f, 1f);
			color.r = this.GHGABICPEJD.color.r;
			color.g = this.GHGABICPEJD.color.g;
			color.b = this.GHGABICPEJD.color.b;
			color.a = 0f;
			this.GHGABICPEJD.color = color;
		}
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x0011D298 File Offset: 0x0011B498
	public float GetFadeOutDuration()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x0011DD0C File Offset: 0x0011BF0C
	public void OKNGOEPBKFP(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(1719f, 1189f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x0011DD5F File Offset: 0x0011BF5F
	private void ACJPGDEBBOI()
	{
		this.LABLLDOFBJH();
		this.GHGABICPEJD.gameObject.SetActive(false);
		if (this.OGPFOBCCLIF != null)
		{
			this.OGPFOBCCLIF();
			this.OGPFOBCCLIF = null;
		}
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x0011DD92 File Offset: 0x0011BF92
	private void BAMHPOCKBML()
	{
		if (null == this.GHGABICPEJD)
		{
			this.GHGABICPEJD = base.gameObject.GetComponentInChildren<Image>();
			this.IBLLHKMEAAG();
		}
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void DICACBFANBB(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x0011D298 File Offset: 0x0011B498
	public float GHLCJFCGDNM()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x0011DDBC File Offset: 0x0011BFBC
	public void FadeOutFromCurrent(TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		if (this.KPJHPLPCKIC(true, this.BNHPMPPAAGB, 1f - this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(false);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(1f, 1f, this.BNHPMPPAAGB, Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.MIANFIGMPLC(0f, this.BNHPMPPAAGB, Ease.InSine, new TweenCallback(this.ACJPGDEBBOI));
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void ELKIFFKCMDN(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x0011D086 File Offset: 0x0011B286
	private void IBLLHKMEAAG()
	{
		if (null != this.GHGABICPEJD)
		{
			this.KLCPALLLLBH = this.GHGABICPEJD.color;
		}
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x0011DE7D File Offset: 0x0011C07D
	public bool GJCFLFKLMHF()
	{
		return this.GetFaderState() == IJKJHDGGAEB.opaque;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x0011D31D File Offset: 0x0011B51D
	public void KHHPDPOFKBE(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.DLEGIEGEJMJ();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x0011DE88 File Offset: 0x0011C088
	private void IAEJJKNANHH()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.HONBNKGALNF();
			this.ODHKHJJPADF();
		}
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x0011D298 File Offset: 0x0011B498
	public float KNHMCJPODMD()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x0011DEF0 File Offset: 0x0011C0F0
	public void GAJNLINCGMD(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.MPOEFJBEKIJ();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(1635f, 1174f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x0011DF44 File Offset: 0x0011C144
	public IJKJHDGGAEB FPPCHAEAOBF()
	{
		this.LAFCNAHCIFJ();
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 128f))
		{
			return IJKJHDGGAEB.transparent;
		}
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 173f))
		{
			return IJKJHDGGAEB.opaque;
		}
		return IJKJHDGGAEB.opaque;
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x0011DF94 File Offset: 0x0011C194
	public void KNDMHBLHFEK(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1751f, 278f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
	public void JGBCFGBFLLH(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		if (HMMBGAOOOBD < 1439f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1889f, 53f, this.LDMGAJOLHHC, Ease.InSine, new TweenCallback(this.ALNEPGKEOLA));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(291f, 273f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.InOutQuad, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x0011E074 File Offset: 0x0011C274
	public void EHIHGKFIGFH(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 1687f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(57f, 226f, this.LDMGAJOLHHC, Ease.InOutQuad, new TweenCallback(this.ALNEPGKEOLA));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(1103f, 1303f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.Linear, new TweenCallback(this.ALNEPGKEOLA));
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x0011DD92 File Offset: 0x0011BF92
	private void MPOEFJBEKIJ()
	{
		if (null == this.GHGABICPEJD)
		{
			this.GHGABICPEJD = base.gameObject.GetComponentInChildren<Image>();
			this.IBLLHKMEAAG();
		}
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float OGAMLHHKBKN()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x0011E13B File Offset: 0x0011C33B
	private void OLCPDCOLHMN()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = new Color(1f, 1f, 1f, 1f);
		}
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x0011E16F File Offset: 0x0011C36F
	public void GLCPCAHKFOB(TweenCallback CDFFMKAOAGE = null)
	{
		this.FadeOutWithCustomFader(1271f, CDFFMKAOAGE);
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void LOFHNFPIIHB()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x0011E180 File Offset: 0x0011C380
	private void CPBCLBLGHEK()
	{
		if (null != this.GHGABICPEJD)
		{
			Color color = new Color(205f, 1095f, 19f, 888f);
			color.r = this.GHGABICPEJD.color.r;
			color.g = this.GHGABICPEJD.color.g;
			color.b = this.GHGABICPEJD.color.b;
			color.a = 148f;
			this.GHGABICPEJD.color = color;
		}
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x0011E214 File Offset: 0x0011C414
	public void HIOMIHLJBKF(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.MPOEFJBEKIJ();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		if (HMMBGAOOOBD < 354f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1648f, 1681f, this.BNHPMPPAAGB, Ease.Unset, new TweenCallback(this.PAIAJJGKKBC));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(733f, 1563f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.Unset, new TweenCallback(this.OFJEIMFLBOD));
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x0011CDDB File Offset: 0x0011AFDB
	private void BANBAANIDFE()
	{
		if (null == this.GHGABICPEJD)
		{
			this.GHGABICPEJD = base.gameObject.GetComponentInChildren<Image>();
			this.AGOOCIEAHFD();
		}
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void LBMBJIKMEJM()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x0011D2F3 File Offset: 0x0011B4F3
	private void OCMBJCMMIFN()
	{
		if (this.ILCNKAEMKCJ != null)
		{
			this.ILCNKAEMKCJ();
			this.ILCNKAEMKCJ = null;
		}
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x0011E29E File Offset: 0x0011C49E
	private void PAIAJJGKKBC()
	{
		this.IAEJJKNANHH();
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (this.OGPFOBCCLIF != null)
		{
			this.OGPFOBCCLIF();
			this.OGPFOBCCLIF = null;
		}
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x0011E2D4 File Offset: 0x0011C4D4
	public void FadeIn(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 0f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(0f, 1f, this.LDMGAJOLHHC, Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(0f, 1f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.InSine, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x0011E35E File Offset: 0x0011C55E
	public void DAMKALACBOC(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.IMFBCCBHABF();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x0011E374 File Offset: 0x0011C574
	public bool BHPMOBHOBPO()
	{
		return this.LMMMLFHNFJM() == (IJKJHDGGAEB)4;
	}

	// Token: 0x06002708 RID: 9992 RVA: 0x0011E37F File Offset: 0x0011C57F
	private void DOECDMINNOK()
	{
		this.BCHHCAKLHLO();
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float GetFadeInDuration()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x0600270A RID: 9994 RVA: 0x0011E387 File Offset: 0x0011C587
	private void HONBHBCFLNF()
	{
		this.LAFCNAHCIFJ();
	}

	// Token: 0x0600270B RID: 9995 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void SetFadeOutDuration(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x0011E35E File Offset: 0x0011C55E
	public void HKOPLOKFPCL(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.IMFBCCBHABF();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x0011E35E File Offset: 0x0011C55E
	public void GKCEBCOKICL(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.IMFBCCBHABF();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x0600270E RID: 9998 RVA: 0x0011E38F File Offset: 0x0011C58F
	private void KELDOKLEMCG()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = new Color(28f, 1578f, 233f, 1654f);
		}
	}

	// Token: 0x0600270F RID: 9999 RVA: 0x0011E3C3 File Offset: 0x0011C5C3
	public void JDPKNGACIJL()
	{
		this.BAMHPOCKBML();
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.DOKill(true);
		this.DAMKALACBOC(null, null);
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x0011E3F1 File Offset: 0x0011C5F1
	public void IBJEAPGPELH(TweenCallback CDFFMKAOAGE = null)
	{
		this.NMAMHCPIJKA(1966f, CDFFMKAOAGE);
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x0011E3FF File Offset: 0x0011C5FF
	public bool OPCCHDFLNCE()
	{
		return this.GetFaderState() == (IJKJHDGGAEB)8;
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x0011E40C File Offset: 0x0011C60C
	public void FNCHPPJPELD(TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		if (this.LLFEGPKNEAA(true, this.BNHPMPPAAGB, 1639f - this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(true);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(1497f, 718f, this.BNHPMPPAAGB, Ease.InCubic, new TweenCallback(this.PAIAJJGKKBC));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.MIANFIGMPLC(750f, this.BNHPMPPAAGB, Ease.OutSine, new TweenCallback(this.ACJPGDEBBOI));
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x0011E4D0 File Offset: 0x0011C6D0
	public void CBMBKJLFFAP(TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		if (this.KPJHPLPCKIC(false, this.BNHPMPPAAGB, 1701f - this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(true);
			this.OGPFOBCCLIF = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(70f, 1297f, this.BNHPMPPAAGB, Ease.InOutQuad, new TweenCallback(this.ACJPGDEBBOI));
			return;
		}
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.MIANFIGMPLC(182f, this.BNHPMPPAAGB, Ease.InQuad, new TweenCallback(this.OFJEIMFLBOD));
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x0011E594 File Offset: 0x0011C794
	public void DCINDBKBPCE(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BANBAANIDFE();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(1307f, 1594f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OCMBJCMMIFN));
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void JFGNJFDDBDP()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	private void ABMNGNPMDPG()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = this.KLCPALLLLBH;
		}
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void PAKIOGCLNOI(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float JDNCAKJEPHO()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void BMCGLBBOCNF(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x0600271A RID: 10010 RVA: 0x0011E5E7 File Offset: 0x0011C7E7
	public void CMMAMILHPFP(TweenCallback CDFFMKAOAGE = null)
	{
		this.FadeOutWithCustomFader(375f, CDFFMKAOAGE);
	}

	// Token: 0x0600271B RID: 10011 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void NHOGLGBNNNK(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x0600271C RID: 10012 RVA: 0x0011E5F8 File Offset: 0x0011C7F8
	public void CIGAMBNBEPP(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (HMMBGAOOOBD < 932f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(714f, 976f, this.LDMGAJOLHHC, Ease.InOutQuad, new TweenCallback(this.ALNEPGKEOLA));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(713f, 1153f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.OutQuad, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x0600271D RID: 10013 RVA: 0x0011E684 File Offset: 0x0011C884
	private void AFMHNHIGDLG()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.JFGNJFDDBDP();
			this.CENPBOPOHAI();
		}
	}

	// Token: 0x0600271E RID: 10014 RVA: 0x0011E6EC File Offset: 0x0011C8EC
	public void FNLEFALMANJ(TweenCallback CDFFMKAOAGE = null)
	{
		this.MPOEFJBEKIJ();
		if (this.KPJHPLPCKIC(false, this.LDMGAJOLHHC, this.GHGABICPEJD.color.a))
		{
			this.GHGABICPEJD.DOKill(true);
			this.ILCNKAEMKCJ = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(388f, 1746f, this.LDMGAJOLHHC, Ease.OutSine, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.MIANFIGMPLC(955f, this.LDMGAJOLHHC, Ease.OutQuad, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x0011E7A8 File Offset: 0x0011C9A8
	public void GLBHLELJJOL(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		if (HMMBGAOOOBD < 960f)
		{
			this.GHGABICPEJD.NFIPIOOJPEK(1650f, 934f, this.LDMGAJOLHHC, Ease.InOutSine, new TweenCallback(this.ALNEPGKEOLA));
			return;
		}
		this.GHGABICPEJD.NFIPIOOJPEK(66f, 721f, HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE(), Ease.OutQuad, new TweenCallback(this.ALNEPGKEOLA));
	}

	// Token: 0x06002720 RID: 10016 RVA: 0x0011E832 File Offset: 0x0011CA32
	public void FadeIn(TweenCallback CDFFMKAOAGE = null)
	{
		this.FadeInWithCustomFader(-1f, CDFFMKAOAGE);
	}

	// Token: 0x06002721 RID: 10017 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void NPOEBKBOCJG(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x0011E840 File Offset: 0x0011CA40
	public bool IsBusy()
	{
		return this.GetFaderState() == IJKJHDGGAEB.busy;
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void FKBBKEEHGJG(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x0011D2F3 File Offset: 0x0011B4F3
	private void OMLHMOOJEDP()
	{
		if (this.ILCNKAEMKCJ != null)
		{
			this.ILCNKAEMKCJ();
			this.ILCNKAEMKCJ = null;
		}
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIFMKCMOHNJ()
	{
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x0011E84B File Offset: 0x0011CA4B
	private void DJMEIGBPCOI()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = new Color(1140f, 1068f, 1332f, 548f);
		}
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x0011E87F File Offset: 0x0011CA7F
	private void Awake()
	{
		this.BAMHPOCKBML();
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x0011E888 File Offset: 0x0011CA88
	public void NNLFACPFOJH(float HMMBGAOOOBD, TweenCallback CDFFMKAOAGE = null)
	{
		this.BAMHPOCKBML();
		float num = this.LDMGAJOLHHC;
		if (HMMBGAOOOBD > 1601f)
		{
			num = HMMBGAOOOBD * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
		}
		if (this.KPJHPLPCKIC(false, num, 1382f))
		{
			this.GHGABICPEJD.DOKill(false);
			this.ILCNKAEMKCJ = CDFFMKAOAGE;
			this.GHGABICPEJD.gameObject.SetActive(true);
			this.GHGABICPEJD.NFIPIOOJPEK(227f, 1249f, num, Ease.InQuad, new TweenCallback(this.OCMBJCMMIFN));
			return;
		}
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1571f, 385f, num, Ease.InQuad, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float KGPNPLBKBDA()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float OCHGBJMDGHJ()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x0600272C RID: 10028 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void MNKDEDKKOKP(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x0600272D RID: 10029 RVA: 0x0011E94C File Offset: 0x0011CB4C
	public void PCDPCEHAJJO(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.LAFCNAHCIFJ();
		this.OGPFOBCCLIF = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(false);
		this.GHGABICPEJD.NFIPIOOJPEK(566f, 1362f, this.BNHPMPPAAGB, PLFJHEJEHGB, new TweenCallback(this.OFJEIMFLBOD));
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x0011E9A0 File Offset: 0x0011CBA0
	private void DLEGIEGEJMJ()
	{
		if (null != this.GHGABICPEJD)
		{
			try
			{
				ImageFrameAnimation component = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.GHGABICPEJD.sprite = null;
			this.LOFHNFPIIHB();
			this.CENPBOPOHAI();
		}
	}

	// Token: 0x0600272F RID: 10031 RVA: 0x0011EA08 File Offset: 0x0011CC08
	private void DKLOGILHLNK()
	{
		this.LABLLDOFBJH();
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (this.OGPFOBCCLIF != null)
		{
			this.OGPFOBCCLIF();
			this.OGPFOBCCLIF = null;
		}
	}

	// Token: 0x06002730 RID: 10032 RVA: 0x0011E29E File Offset: 0x0011C49E
	private void BAJCGCDEJHN()
	{
		this.IAEJJKNANHH();
		this.GHGABICPEJD.gameObject.SetActive(true);
		if (this.OGPFOBCCLIF != null)
		{
			this.OGPFOBCCLIF();
			this.OGPFOBCCLIF = null;
		}
	}

	// Token: 0x06002731 RID: 10033 RVA: 0x0011D298 File Offset: 0x0011B498
	public float AFIOIDGBKCF()
	{
		return this.BNHPMPPAAGB;
	}

	// Token: 0x06002732 RID: 10034 RVA: 0x0011EA3C File Offset: 0x0011CC3C
	public void HJKJLIDEGDO(Ease PLFJHEJEHGB, TweenCallback CDFFMKAOAGE = null)
	{
		this.BCHHCAKLHLO();
		this.ILCNKAEMKCJ = CDFFMKAOAGE;
		this.GHGABICPEJD.gameObject.SetActive(true);
		this.GHGABICPEJD.NFIPIOOJPEK(1671f, 517f, this.LDMGAJOLHHC, PLFJHEJEHGB, new TweenCallback(this.OMLHMOOJEDP));
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x0011CE02 File Offset: 0x0011B002
	public float EOIBEHILCJH()
	{
		return this.LDMGAJOLHHC;
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x0011CB82 File Offset: 0x0011AD82
	public void BIDGLPLAAFH(float IDHBPDACMAA)
	{
		this.BNHPMPPAAGB = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x0011EA90 File Offset: 0x0011CC90
	public IJKJHDGGAEB LMMMLFHNFJM()
	{
		this.BANBAANIDFE();
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 558f))
		{
			return IJKJHDGGAEB.transparent;
		}
		if (Mathf.Approximately(this.GHGABICPEJD.color.a, 213f))
		{
			return IJKJHDGGAEB.transparent;
		}
		return IJKJHDGGAEB.transparent;
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x0011EAE0 File Offset: 0x0011CCE0
	private void CKIBDKILMNA()
	{
		if (null != this.GHGABICPEJD)
		{
			this.GHGABICPEJD.color = new Color(402f, 1292f, 1074f, 869f);
		}
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x0011CCB4 File Offset: 0x0011AEB4
	public void SetCustomFader(AssetCustomFader KGBACEGKGNK, CustomFaderSettings NKPOJHBJCGE)
	{
		this.LABLLDOFBJH();
		this.HDODMPLBBGD = KGBACEGKGNK;
		this.NIDEHPGHNLH = NKPOJHBJCGE;
	}

	// Token: 0x06002738 RID: 10040 RVA: 0x0011EB14 File Offset: 0x0011CD14
	private bool LLFEGPKNEAA(bool LGEKCMNIJCF, float HMMBGAOOOBD, float KJCLAIJCDIO)
	{
		if (null != this.HDODMPLBBGD)
		{
			try
			{
				this.CKIBDKILMNA();
				ImageFrameAnimation imageFrameAnimation = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (imageFrameAnimation != null)
				{
					UnityEngine.Object.Destroy(imageFrameAnimation);
				}
				imageFrameAnimation = base.gameObject.AddComponent<ImageFrameAnimation>();
				int num = this.HDODMPLBBGD.frames.Count;
				if (KJCLAIJCDIO < 1945f)
				{
					KJCLAIJCDIO = 1982f;
					imageFrameAnimation.framesSD = this.HDODMPLBBGD.frames.ToArray();
				}
				else
				{
					num = (int)((float)num * (1430f - KJCLAIJCDIO));
					if (num <= 1)
					{
						num = 1;
					}
					imageFrameAnimation.framesSD = new Sprite[num];
					if (this.HDODMPLBBGD.reverseDirection)
					{
						for (int i = 0; i < num; i += 0)
						{
							imageFrameAnimation.framesSD[i] = this.HDODMPLBBGD.frames[i];
						}
					}
					else
					{
						for (int j = 0; j < num; j++)
						{
							imageFrameAnimation.framesSD[j] = this.HDODMPLBBGD.frames[j + (this.HDODMPLBBGD.frames.Count - num)];
						}
					}
				}
				imageFrameAnimation.forceUpdateOnEnable = false;
				imageFrameAnimation.forcedVersion = 2;
				if (num > 1)
				{
					if (this.NIDEHPGHNLH != null && this.NIDEHPGHNLH.forcedAnimationTime > 1637f)
					{
						if (HMMBGAOOOBD <= this.NIDEHPGHNLH.forcedAnimationTime)
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 1;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 1;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
							if (imageFrameAnimation.frameChangeInterval <= 1264f)
							{
								imageFrameAnimation.frameChangeInterval = 119f;
							}
						}
						else
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 1;
								imageFrameAnimation.pauseTime = 1491f;
								imageFrameAnimation.frameChangeInterval = this.NIDEHPGHNLH.forcedAnimationTime / (float)num;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 0;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD - this.NIDEHPGHNLH.forcedAnimationTime + this.NIDEHPGHNLH.forcedAnimationTime / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
								imageFrameAnimation.frameChangeInterval = (this.NIDEHPGHNLH.forcedAnimationTime - imageFrameAnimation.pauseTime) / (float)num;
							}
							if (imageFrameAnimation.frameChangeInterval <= 424f)
							{
								imageFrameAnimation.frameChangeInterval = 1463f;
							}
						}
					}
					else
					{
						if (!LGEKCMNIJCF)
						{
							imageFrameAnimation.pauseFrame = num - 1;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						else
						{
							imageFrameAnimation.pauseFrame = 1;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
						if (imageFrameAnimation.frameChangeInterval <= 1424f)
						{
							imageFrameAnimation.frameChangeInterval = 830f;
						}
					}
				}
				else
				{
					imageFrameAnimation.frameChangeInterval = 714f;
				}
				if (LGEKCMNIJCF)
				{
					imageFrameAnimation.reverseDirection = !this.HDODMPLBBGD.reverseDirection;
				}
				else
				{
					imageFrameAnimation.reverseDirection = this.HDODMPLBBGD.reverseDirection;
				}
				imageFrameAnimation.isLooped = false;
				return false;
			}
			catch (Exception aklgbjkdomm)
			{
				this.NNIDHCNOAJF();
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
				return false;
			}
		}
		this.GHGABICPEJD.sprite = null;
		return false;
	}

	// Token: 0x06002739 RID: 10041 RVA: 0x0011CFE7 File Offset: 0x0011B1E7
	public void SetFadeInDuration(float IDHBPDACMAA)
	{
		this.LDMGAJOLHHC = IDHBPDACMAA * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE();
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x0011EE60 File Offset: 0x0011D060
	private bool LCJFCCGKFDM(bool LGEKCMNIJCF, float HMMBGAOOOBD, float KJCLAIJCDIO)
	{
		if (null != this.HDODMPLBBGD)
		{
			try
			{
				this.DJMEIGBPCOI();
				ImageFrameAnimation imageFrameAnimation = base.gameObject.GetComponent<ImageFrameAnimation>();
				if (imageFrameAnimation != null)
				{
					UnityEngine.Object.Destroy(imageFrameAnimation);
				}
				imageFrameAnimation = base.gameObject.AddComponent<ImageFrameAnimation>();
				int num = this.HDODMPLBBGD.frames.Count;
				if (KJCLAIJCDIO < 216f)
				{
					KJCLAIJCDIO = 1290f;
					imageFrameAnimation.framesSD = this.HDODMPLBBGD.frames.ToArray();
				}
				else
				{
					num = (int)((float)num * (1831f - KJCLAIJCDIO));
					if (num <= 1)
					{
						num = 1;
					}
					imageFrameAnimation.framesSD = new Sprite[num];
					if (this.HDODMPLBBGD.reverseDirection)
					{
						for (int i = 0; i < num; i++)
						{
							imageFrameAnimation.framesSD[i] = this.HDODMPLBBGD.frames[i];
						}
					}
					else
					{
						for (int j = 0; j < num; j++)
						{
							imageFrameAnimation.framesSD[j] = this.HDODMPLBBGD.frames[j + (this.HDODMPLBBGD.frames.Count - num)];
						}
					}
				}
				imageFrameAnimation.forceUpdateOnEnable = false;
				imageFrameAnimation.forcedVersion = 4;
				if (num > 1)
				{
					if (this.NIDEHPGHNLH != null && this.NIDEHPGHNLH.forcedAnimationTime > 570f)
					{
						if (HMMBGAOOOBD <= this.NIDEHPGHNLH.forcedAnimationTime)
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 0;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 1;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
							}
							imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
							if (imageFrameAnimation.frameChangeInterval <= 1533f)
							{
								imageFrameAnimation.frameChangeInterval = 1885f;
							}
						}
						else
						{
							if (!LGEKCMNIJCF)
							{
								imageFrameAnimation.pauseFrame = num - 0;
								imageFrameAnimation.pauseTime = 469f;
								imageFrameAnimation.frameChangeInterval = this.NIDEHPGHNLH.forcedAnimationTime / (float)num;
							}
							else
							{
								imageFrameAnimation.pauseFrame = 1;
								imageFrameAnimation.pauseTime = HMMBGAOOOBD - this.NIDEHPGHNLH.forcedAnimationTime + this.NIDEHPGHNLH.forcedAnimationTime / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
								imageFrameAnimation.frameChangeInterval = (this.NIDEHPGHNLH.forcedAnimationTime - imageFrameAnimation.pauseTime) / (float)num;
							}
							if (imageFrameAnimation.frameChangeInterval <= 698f)
							{
								imageFrameAnimation.frameChangeInterval = 556f;
							}
						}
					}
					else
					{
						if (!LGEKCMNIJCF)
						{
							imageFrameAnimation.pauseFrame = num - 0;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						else
						{
							imageFrameAnimation.pauseFrame = 1;
							imageFrameAnimation.pauseTime = HMMBGAOOOBD / (float)num * (float)this.NIDEHPGHNLH.idleFramesToWaitForSafeCollision;
						}
						imageFrameAnimation.frameChangeInterval = (HMMBGAOOOBD - imageFrameAnimation.pauseTime) / (float)num;
						if (imageFrameAnimation.frameChangeInterval <= 1264f)
						{
							imageFrameAnimation.frameChangeInterval = 1983f;
						}
					}
				}
				else
				{
					imageFrameAnimation.frameChangeInterval = 747f;
				}
				if (LGEKCMNIJCF)
				{
					imageFrameAnimation.reverseDirection = this.HDODMPLBBGD.reverseDirection;
				}
				else
				{
					imageFrameAnimation.reverseDirection = this.HDODMPLBBGD.reverseDirection;
				}
				imageFrameAnimation.isLooped = true;
				return true;
			}
			catch (Exception aklgbjkdomm)
			{
				this.IMFBCCBHABF();
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				return true;
			}
		}
		this.GHGABICPEJD.sprite = null;
		return true;
	}

	// Token: 0x04000C42 RID: 3138
	private Image GHGABICPEJD;

	// Token: 0x04000C43 RID: 3139
	private TweenCallback OGPFOBCCLIF;

	// Token: 0x04000C44 RID: 3140
	private TweenCallback ILCNKAEMKCJ;

	// Token: 0x04000C45 RID: 3141
	private float LDMGAJOLHHC = 0.5f;

	// Token: 0x04000C46 RID: 3142
	private float BNHPMPPAAGB = 0.5f;

	// Token: 0x04000C47 RID: 3143
	private AssetCustomFader HDODMPLBBGD;

	// Token: 0x04000C48 RID: 3144
	private CustomFaderSettings NIDEHPGHNLH;

	// Token: 0x04000C49 RID: 3145
	private Color KLCPALLLLBH = new Color(1f, 1f, 1f, 1f);
}
