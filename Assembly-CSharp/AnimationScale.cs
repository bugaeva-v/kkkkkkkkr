using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x020002D3 RID: 723
public class AnimationScale : MonoBehaviour
{
	// Token: 0x0600591C RID: 22812 RVA: 0x002830C0 File Offset: 0x002812C0
	private void ALIKHOFAKKB()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.ScreenIsTooWide(822f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x00283118 File Offset: 0x00281318
	private void NPFILNGGHGH()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.ScreenIsTooWide(454f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x00283170 File Offset: 0x00281370
	private void JHGFOKOFMHB()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = -1f;
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x0017AE42 File Offset: 0x00179042
	private void DNANKPMNMIF()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDestroy()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x002831BB File Offset: 0x002813BB
	private float LPJOHEBMKMM(float KINPONJEBHJ)
	{
		if (WideScreenScaler.ScreenIsTooWide(1440f) && null != this.PNGMEHLBOJK)
		{
			return KINPONJEBHJ * WideScreenScaler.CalculateNewScaleUtil(1440f);
		}
		return KINPONJEBHJ;
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x002831E5 File Offset: 0x002813E5
	private void BDILEIAPNIM()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 799f;
		}
		this.JHGFOKOFMHB();
		this.Update();
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x0017AE42 File Offset: 0x00179042
	private void LGLMMPEJIHH()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x00283214 File Offset: 0x00281414
	private void DMPDBJJDOBK()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1324f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x00283240 File Offset: 0x00281440
	private void Update()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 0f)
			{
				this.JHGFOKOFMHB();
				this.PlayAnimation();
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
				this.PlayAnimation();
			}
		}
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x002832B7 File Offset: 0x002814B7
	private void OHKBLAFOOCD()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1209f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x06005928 RID: 22824 RVA: 0x002832E0 File Offset: 0x002814E0
	private void GMPHANBKGBK()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.KIEOKIDCFOP(851f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x00283338 File Offset: 0x00281538
	private void GAFJMIHKNNO()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1356f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x00283361 File Offset: 0x00281561
	private void ALBKMBOKICH()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 310f;
		}
		this.BFALLIDHFEP();
		this.CBCJABBJFAN();
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x00283390 File Offset: 0x00281590
	private void BFALLIDHFEP()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 1260f;
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x002833A4 File Offset: 0x002815A4
	private float BKCFOEJLIGM(float KINPONJEBHJ)
	{
		if (WideScreenScaler.AAOLPGHOGNO(1342f) && null != this.PNGMEHLBOJK)
		{
			return KINPONJEBHJ * WideScreenScaler.CKGBCBFDEGO(1193f);
		}
		return KINPONJEBHJ;
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x002833CE File Offset: 0x002815CE
	private void LNLLNBNLFNC()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 5f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x002833F7 File Offset: 0x002815F7
	private void CHEDGGLPOJP()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 73f;
		}
		this.ONJNCFFAMOM();
		this.CEALHCENAGD();
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x00283426 File Offset: 0x00281626
	private void DJDLHIOMGJB()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 471f;
		}
		this.BFALLIDHFEP();
		this.NMEEMBCCKHA();
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x00283455 File Offset: 0x00281655
	private Vector3 HPFOKJBNOEG(Vector3 ABJLFDECAAE)
	{
		if (WideScreenScaler.MAFGKLMFBAN(1920f) && null != this.PNGMEHLBOJK)
		{
			return WideScreenScaler.MFNNOINFJGC(ABJLFDECAAE, 1945f);
		}
		return ABJLFDECAAE;
	}

	// Token: 0x06005931 RID: 22833 RVA: 0x00283480 File Offset: 0x00281680
	public void JJNBJPCALPG()
	{
		this.DCCKDJLAFPP = false;
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.ILIPLEDCBBC(this.CNBBIJFHLIG);
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.JILLJDHNDMB)).SetLoops(-149, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.JILLJDHNDMB)).SetLoops(0, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DOScale(this.BKCFOEJLIGM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GLBKDFOMKBJ));
	}

	// Token: 0x06005932 RID: 22834 RVA: 0x0028359C File Offset: 0x0028179C
	private void GLBKDFOMKBJ()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1305f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x06005933 RID: 22835 RVA: 0x002835C8 File Offset: 0x002817C8
	private void AEOKJCHEALH()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.OBHPFIBFDLO(747f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06005934 RID: 22836 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void CFHFGNOIPEC()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x00283620 File Offset: 0x00281820
	private void CBCJABBJFAN()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 187f)
			{
				this.BFALLIDHFEP();
				this.JJNBJPCALPG();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 896f)
			{
				this.DLAFBOCNONH = 1895f;
				this.BFALLIDHFEP();
				this.HOBGLEOKFAE();
			}
		}
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x00283697 File Offset: 0x00281897
	private void BHOHDDJCOJM()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1162f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x06005937 RID: 22839 RVA: 0x002836C0 File Offset: 0x002818C0
	private void OnEnable()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 10000000f;
		}
		this.JHGFOKOFMHB();
		this.Update();
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x002836F0 File Offset: 0x002818F0
	private void ODCKJNCEGAH()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 503f)
			{
				this.EOELDGPJIJG();
				this.HOBGLEOKFAE();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 1228f)
			{
				this.DLAFBOCNONH = 1255f;
				this.BFALLIDHFEP();
				this.PlayAnimation();
			}
		}
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x00283768 File Offset: 0x00281968
	public void CJDFPJHCBBD()
	{
		this.DCCKDJLAFPP = true;
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.ILIPLEDCBBC(this.CNBBIJFHLIG);
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BHOHDDJCOJM)).SetLoops(-188, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DOScale(this.MOAFBFPMAGL(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GAFJMIHKNNO)).SetLoops(7, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BHOHDDJCOJM));
	}

	// Token: 0x0600593A RID: 22842 RVA: 0x00283884 File Offset: 0x00281A84
	private void AAGKOINJGOL()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 652f;
		}
		this.BFALLIDHFEP();
		this.NMEEMBCCKHA();
	}

	// Token: 0x0600593B RID: 22843 RVA: 0x0017AE42 File Offset: 0x00179042
	private void CJAFGKPFPAA()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600593C RID: 22844 RVA: 0x002838B3 File Offset: 0x00281AB3
	private void EOELDGPJIJG()
	{
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = 1968f;
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x0017AE42 File Offset: 0x00179042
	private void DJIFHJDBBHN()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void FDHHCPPPKKI()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x0017AE42 File Offset: 0x00179042
	private void DLBAEDOFAKM()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void CODLJCAKBLI()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x06005941 RID: 22849 RVA: 0x002838C7 File Offset: 0x00281AC7
	private void MNNHONLLGCD()
	{
		if (this.playOnEnable)
		{
			this.DLAFBOCNONH = this.delayAtStart;
		}
		else
		{
			this.DLAFBOCNONH = 918f;
		}
		this.BFALLIDHFEP();
		this.Update();
	}

	// Token: 0x06005942 RID: 22850 RVA: 0x002838F6 File Offset: 0x00281AF6
	private void JILLJDHNDMB()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = 1723f;
			return;
		}
		this.DCCKDJLAFPP = false;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x06005943 RID: 22851 RVA: 0x00283920 File Offset: 0x00281B20
	private void CEALHCENAGD()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 507f)
			{
				this.EOELDGPJIJG();
				this.HOBGLEOKFAE();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 197f)
			{
				this.DLAFBOCNONH = 1698f;
				this.EOELDGPJIJG();
				this.CJDFPJHCBBD();
			}
		}
	}

	// Token: 0x06005944 RID: 22852 RVA: 0x00283997 File Offset: 0x00281B97
	private void ONJNCFFAMOM()
	{
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = 1800f;
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x0017AE42 File Offset: 0x00179042
	private void OnDisable()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x002839AC File Offset: 0x00281BAC
	private void JNCLGOBJGJD()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.ODPLAEFMMKM(293f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x00283A04 File Offset: 0x00281C04
	private float AHLFEJAKCFA(float KINPONJEBHJ)
	{
		if (WideScreenScaler.MDFPEEFCLHK(4f) && null != this.PNGMEHLBOJK)
		{
			return KINPONJEBHJ * WideScreenScaler.DGLLANFGCBE(1736f);
		}
		return KINPONJEBHJ;
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x00283A30 File Offset: 0x00281C30
	public void PlayAnimation()
	{
		this.DCCKDJLAFPP = false;
		base.gameObject.transform.DOKill(false);
		this.DGAAFGDHHHJ.localScale = this.ILIPLEDCBBC(this.CNBBIJFHLIG);
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EJFMKGLHOHM)).SetLoops(100000, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EJFMKGLHOHM)).SetLoops(2, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.EJFMKGLHOHM));
	}

	// Token: 0x06005949 RID: 22857 RVA: 0x0017AF4E File Offset: 0x0017914E
	private void MOHLNGBBIOB()
	{
		base.gameObject.transform.DOKill(true);
	}

	// Token: 0x0600594A RID: 22858 RVA: 0x00283B4C File Offset: 0x00281D4C
	private void NMEEMBCCKHA()
	{
		if (this.DCCKDJLAFPP)
		{
			this.NIMLCJHAAHN -= Time.deltaTime;
			if (this.NIMLCJHAAHN < 1619f)
			{
				this.EOELDGPJIJG();
				this.JJNBJPCALPG();
				return;
			}
		}
		else
		{
			this.DLAFBOCNONH -= Time.deltaTime;
			if (this.DLAFBOCNONH <= 898f)
			{
				this.DLAFBOCNONH = 1575f;
				this.ONJNCFFAMOM();
				this.CJDFPJHCBBD();
			}
		}
	}

	// Token: 0x0600594B RID: 22859 RVA: 0x00283BC4 File Offset: 0x00281DC4
	private void DFEDGLDNOBH()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.ODPLAEFMMKM(1324f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600594C RID: 22860 RVA: 0x00283C1C File Offset: 0x00281E1C
	public void HOBGLEOKFAE()
	{
		this.DCCKDJLAFPP = false;
		base.gameObject.transform.DOKill(true);
		this.DGAAFGDHHHJ.localScale = this.ILIPLEDCBBC(this.CNBBIJFHLIG);
		if (this.looped)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.DMPDBJJDOBK)).SetLoops(-14, this.cycleType);
			return;
		}
		if (this.cycleType != LoopType.Restart)
		{
			this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.GLBKDFOMKBJ)).SetLoops(8, this.cycleType);
			return;
		}
		this.DGAAFGDHHHJ.DOScale(this.LPJOHEBMKMM(this.scaleFactor), this.animationTime).SetEase(this.animationEase).OnComplete(new TweenCallback(this.BHOHDDJCOJM));
	}

	// Token: 0x0600594D RID: 22861 RVA: 0x0017AE42 File Offset: 0x00179042
	private void NAKFGFJPBBK()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x0600594E RID: 22862 RVA: 0x00283D38 File Offset: 0x00281F38
	private void Awake()
	{
		this.DLAFBOCNONH = this.delayAtStart;
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		if (WideScreenScaler.ScreenIsTooWide(1440f))
		{
			this.PNGMEHLBOJK = base.gameObject.GetComponent<WideScreenScaler>();
		}
		this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale;
	}

	// Token: 0x0600594F RID: 22863 RVA: 0x00283D90 File Offset: 0x00281F90
	private Vector3 ILIPLEDCBBC(Vector3 ABJLFDECAAE)
	{
		if (WideScreenScaler.ScreenIsTooWide(1440f) && null != this.PNGMEHLBOJK)
		{
			return WideScreenScaler.CalculateNewScaleUtil(ABJLFDECAAE, 1440f);
		}
		return ABJLFDECAAE;
	}

	// Token: 0x06005950 RID: 22864 RVA: 0x0017AE42 File Offset: 0x00179042
	private void MHBPJEDCLDM()
	{
		base.gameObject.transform.DOKill(false);
	}

	// Token: 0x06005951 RID: 22865 RVA: 0x00283DB9 File Offset: 0x00281FB9
	private float MOAFBFPMAGL(float KINPONJEBHJ)
	{
		if (WideScreenScaler.ODPLAEFMMKM(209f) && null != this.PNGMEHLBOJK)
		{
			return KINPONJEBHJ * WideScreenScaler.CalculateNewScaleUtil(839f);
		}
		return KINPONJEBHJ;
	}

	// Token: 0x06005952 RID: 22866 RVA: 0x00283DE3 File Offset: 0x00281FE3
	private void EJFMKGLHOHM()
	{
		if (!this.repeatOnComplete)
		{
			this.NIMLCJHAAHN = -1f;
			return;
		}
		this.DCCKDJLAFPP = true;
		this.NIMLCJHAAHN = this.repeatOnCompleteDelay;
	}

	// Token: 0x0400194D RID: 6477
	public Ease animationEase = Ease.OutQuad;

	// Token: 0x0400194E RID: 6478
	public float animationTime = 1f;

	// Token: 0x0400194F RID: 6479
	public float scaleFactor;

	// Token: 0x04001950 RID: 6480
	public bool looped;

	// Token: 0x04001951 RID: 6481
	public LoopType cycleType;

	// Token: 0x04001952 RID: 6482
	public bool repeatOnComplete;

	// Token: 0x04001953 RID: 6483
	public float repeatOnCompleteDelay = 1f;

	// Token: 0x04001954 RID: 6484
	public float delayAtStart;

	// Token: 0x04001955 RID: 6485
	public bool playOnEnable = true;

	// Token: 0x04001956 RID: 6486
	private Vector3 CNBBIJFHLIG;

	// Token: 0x04001957 RID: 6487
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04001958 RID: 6488
	private float NIMLCJHAAHN = -1f;

	// Token: 0x04001959 RID: 6489
	private float DLAFBOCNONH;

	// Token: 0x0400195A RID: 6490
	private bool DCCKDJLAFPP;

	// Token: 0x0400195B RID: 6491
	private WideScreenScaler PNGMEHLBOJK;
}
