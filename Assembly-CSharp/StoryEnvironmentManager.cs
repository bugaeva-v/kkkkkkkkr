using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// Token: 0x0200029A RID: 666
[ExecuteInEditMode]
public class StoryEnvironmentManager : MonoBehaviour
{
	// Token: 0x060053E1 RID: 21473 RVA: 0x00252D84 File Offset: 0x00250F84
	public void IHGEGLMJBLB(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		this.CIEHGJMAFKH = LBGGLHDOICL;
		this.FJFEPNKBELL = HCNAPDGGCDO;
	}

	// Token: 0x060053E2 RID: 21474 RVA: 0x00252D94 File Offset: 0x00250F94
	public void SetZoomOutParams(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.OPIKMAHLKFF = IDHBPDACMAA;
		this.EHHCLMMHHMM = BFLBCFEGMIB;
	}

	// Token: 0x060053E3 RID: 21475 RVA: 0x00252DA4 File Offset: 0x00250FA4
	private void EKEOFMOJCGF()
	{
		if (AppManager.CCDBEDIANDN())
		{
			this.BHMIFMMHEPA *= AppManager.JMDJPKKOHNI().debugSettings.HAKILJMJCLA(1682f);
			this.OPIKMAHLKFF *= AppManager.PCJEMMDDCIF().debugSettings.BIMIMMJLMAP(261f);
		}
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
	}

	// Token: 0x060053E4 RID: 21476 RVA: 0x00252E0C File Offset: 0x0025100C
	public void LBEBKKNOKNK(TweenCallback CDFFMKAOAGE = null)
	{
		this.IGJHDPAAIJC = CDFFMKAOAGE;
		Vector3 endValue = new Vector3(this.PICMAHMENMB, this.PICMAHMENMB, 1762f);
		base.gameObject.transform.DOScale(endValue, this.BHMIFMMHEPA).OnComplete(new TweenCallback(this.HCKEEEOLFLG));
	}

	// Token: 0x060053E5 RID: 21477 RVA: 0x00252E64 File Offset: 0x00251064
	public void ZoomIn(TweenCallback CDFFMKAOAGE = null)
	{
		this.IGJHDPAAIJC = CDFFMKAOAGE;
		Vector3 endValue = new Vector3(this.PICMAHMENMB, this.PICMAHMENMB, 1f);
		base.gameObject.transform.DOScale(endValue, this.BHMIFMMHEPA).OnComplete(new TweenCallback(this.OFMPKBKHLBC));
	}

	// Token: 0x060053E6 RID: 21478 RVA: 0x00252EBC File Offset: 0x002510BC
	public static PHALBCMBPPL StringToStoryEnvironmentPositionVertical(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("bottom"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("bottomcenter"))
		{
			return PHALBCMBPPL.bottomCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("center"))
		{
			return PHALBCMBPPL.center;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("topcenter"))
		{
			return PHALBCMBPPL.topCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("top"))
		{
			return PHALBCMBPPL.top;
		}
		return PHALBCMBPPL.center;
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x00252F2E File Offset: 0x0025112E
	private void LGEJJBINCJP()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
		this.CAPFGOKNDIM.Clear();
	}

	// Token: 0x060053E8 RID: 21480 RVA: 0x00252F58 File Offset: 0x00251158
	public static DBONHDHEKDG AKGFMPHPHFG(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnStoryInterfaceHeaderShown"))
		{
			return (DBONHDHEKDG)1;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("digitalglitch"))
		{
			return (DBONHDHEKDG)67;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnSaveSyncAnyResultFocusItem"))
		{
			return (DBONHDHEKDG)(-33);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnSaveSlotsExpiredPassSubscribePositive"))
		{
			return (DBONHDHEKDG)(-30);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("importanttitle"))
		{
			return (DBONHDHEKDG)7;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("apks1"))
		{
			return (DBONHDHEKDG)(-87);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("continue"))
		{
			return (DBONHDHEKDG)(-122);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("CharacterRenderTexturePool - display canvas camera renders before the pool cameras, falling back to direct rendering"))
		{
			return (DBONHDHEKDG)20;
		}
		return (DBONHDHEKDG)(-3);
	}

	// Token: 0x060053E9 RID: 21481 RVA: 0x00253013 File Offset: 0x00251213
	public int DDBEFLAIEIN()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x0025301B File Offset: 0x0025121B
	public int ACFKLGCAKMM()
	{
		return this.FJFEPNKBELL;
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x00253023 File Offset: 0x00251223
	public void NNFGIOLJOIC(float ABJLFDECAAE)
	{
		base.gameObject.transform.localScale = new Vector3(ABJLFDECAAE, 1897f, 1624f);
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x00253045 File Offset: 0x00251245
	private void HCKEEEOLFLG()
	{
		if (this.IGJHDPAAIJC != null)
		{
			this.IGJHDPAAIJC();
		}
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x0025305C File Offset: 0x0025125C
	public void KBKNCNIJJNB()
	{
		try
		{
			if ((KHPGPLAMAIN.DJFLMBEOBIB() == IIHCCPLGGHP.highEnd || KHPGPLAMAIN.IBFFFCIPOJC() == IIHCCPLGGHP.midEnd || KHPGPLAMAIN.BEEEJNHEFOJ()) && this.CAPFGOKNDIM.Count == 0)
			{
				this.FindAllObjectsInChildren(base.gameObject);
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i += 0)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("char") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("Starting non-parallel download:") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("igne") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("/") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("socialjoinno") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnApplicationRestart") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnPurchasingViewLeave") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("PurchaseManagerXiaomi.GetProductData(): Not initialized.") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("colskt") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("$SENDNOTIF") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("،") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("aindas2"))
					{
						ParticleSystem component = this.CAPFGOKNDIM[i].GetComponent<ParticleSystem>();
						if (null != component)
						{
							ParticleSystem.EmissionModule emission = component.emission;
							if (KHPGPLAMAIN.DJFLMBEOBIB() == (IIHCCPLGGHP)4 || KHPGPLAMAIN.BEEEJNHEFOJ())
							{
								if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("strid") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("p") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("onboardingthankyoutitle"))
								{
									emission.rateOverTime = emission.rateOverTime.constant / 1393f;
									if (emission.rateOverTime.constant > 225f)
									{
										emission.rateOverTime = 1364f;
									}
								}
								else
								{
									emission.rateOverTime = emission.rateOverTime.constant / 1757f;
								}
							}
							else if (KHPGPLAMAIN.IBFFFCIPOJC() == IIHCCPLGGHP.highEnd && (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(". Retrieving persistent save data is impossible.") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("ok") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("assetbundlekeepalivepack") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("Low version preview2 assets loaded:")))
							{
								emission.rateOverTime = emission.rateOverTime.constant / 475f;
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
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x002534F0 File Offset: 0x002516F0
	public void PKLKLBLPGCO()
	{
		try
		{
			if ((KHPGPLAMAIN.CIAFFHAENHD() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.CIEILKHLDCG() == IIHCCPLGGHP.highEnd || KHPGPLAMAIN.FGJDAMFPFIH()) && this.CAPFGOKNDIM.Count == 0)
			{
				this.FindAllObjectsInChildren(base.gameObject);
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("spsku") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("aindas2") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("abs") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnChoiceExtendedLayerChange") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("+") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("$EMLOOPSTART") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("</i>") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("storiesSearchDefaults") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("max") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("storyAssetPackManager[i].environmentsBackList[j] is null!") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("pov") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("AVATAR.CLIENT.TRINKET"))
					{
						ParticleSystem component = this.CAPFGOKNDIM[i].GetComponent<ParticleSystem>();
						if (null != component)
						{
							ParticleSystem.EmissionModule emission = component.emission;
							if (KHPGPLAMAIN.DJFLMBEOBIB() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.KPIFAEEPHPH())
							{
								if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(":") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("VER:") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(""))
								{
									emission.rateOverTime = emission.rateOverTime.constant / 1855f;
									if (emission.rateOverTime.constant > 905f)
									{
										emission.rateOverTime = 1695f;
									}
								}
								else
								{
									emission.rateOverTime = emission.rateOverTime.constant / 1009f;
								}
							}
							else if (KHPGPLAMAIN.CIAFFHAENHD() == IIHCCPLGGHP.highEnd && (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("sto") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(";") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("avatarcollectionssyncdone") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("AnimationCanvasGroupAlpha - no canvas group attached.") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("LoveInterestLoungeMapping - unknown shopcur '")))
							{
								emission.rateOverTime = emission.rateOverTime.constant / 648f;
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

	// Token: 0x060053EF RID: 21487 RVA: 0x00253045 File Offset: 0x00251245
	private void OFMPKBKHLBC()
	{
		if (this.IGJHDPAAIJC != null)
		{
			this.IGJHDPAAIJC();
		}
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x00253984 File Offset: 0x00251B84
	public string BOBJFJPPDJG()
	{
		return this.CIEHGJMAFKH;
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x0025301B File Offset: 0x0025121B
	public int MHFHGPPMHIC()
	{
		return this.FJFEPNKBELL;
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x00253045 File Offset: 0x00251245
	private void CAPLEHOIBCO()
	{
		if (this.IGJHDPAAIJC != null)
		{
			this.IGJHDPAAIJC();
		}
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x0025398C File Offset: 0x00251B8C
	public static DBONHDHEKDG NBJGIKADBIH(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("null"))
		{
			return (DBONHDHEKDG)1;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("<size=28px>"))
		{
			return (DBONHDHEKDG)(-108);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("ok"))
		{
			return (DBONHDHEKDG)19;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("anthologiestitle"))
		{
			return (DBONHDHEKDG)(-95);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("offerId"))
		{
			return (DBONHDHEKDG)5;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("socialenteruseridmalformed"))
		{
			return (DBONHDHEKDG)(-23);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("errortitle"))
		{
			return (DBONHDHEKDG)(-181);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("onThemeChange"))
		{
			return (DBONHDHEKDG)55;
		}
		return (DBONHDHEKDG)(-15);
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x00253984 File Offset: 0x00251B84
	public string MILGDNMJKCF()
	{
		return this.CIEHGJMAFKH;
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x00253984 File Offset: 0x00251B84
	public string OPOBHOIBOMB()
	{
		return this.CIEHGJMAFKH;
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x00253A47 File Offset: 0x00251C47
	public void LNABDNBOPCN(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.BHMIFMMHEPA = IDHBPDACMAA;
		this.PICMAHMENMB = BFLBCFEGMIB;
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x00253A58 File Offset: 0x00251C58
	public void AMCCFCOFGGP(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 1546f);
		base.gameObject.transform.DOScale(new Vector3(1129f, 1677f, 1916f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x00253ACE File Offset: 0x00251CCE
	public void KCBBNCNEJLJ(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x00253AD8 File Offset: 0x00251CD8
	public void IKFLOIMIOLB(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 1198f);
		base.gameObject.transform.DOScale(new Vector3(1941f, 337f, 405f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x00253A47 File Offset: 0x00251C47
	public void SetZoomInParams(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.BHMIFMMHEPA = IDHBPDACMAA;
		this.PICMAHMENMB = BFLBCFEGMIB;
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x00253B50 File Offset: 0x00251D50
	public static DBONHDHEKDG StringToStoryEnvironmentMoveSpeed(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("immediate"))
		{
			return DBONHDHEKDG.immediate;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("normal"))
		{
			return DBONHDHEKDG.normal;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("fast"))
		{
			return DBONHDHEKDG.fast;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("slow"))
		{
			return DBONHDHEKDG.slow;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("talk"))
		{
			return DBONHDHEKDG.talk;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("cosmic"))
		{
			return DBONHDHEKDG.cosmic;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("slower"))
		{
			return DBONHDHEKDG.slower;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("slowest"))
		{
			return DBONHDHEKDG.slowest;
		}
		return DBONHDHEKDG.normal;
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x00253C0C File Offset: 0x00251E0C
	public static DBONHDHEKDG LFDLGKPFANN(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("CharacterRenderTexturePool - layer not defined in TagManager:"))
		{
			return (DBONHDHEKDG)1;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnStoryChoiceClick"))
		{
			return (DBONHDHEKDG)94;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(", direction "))
		{
			return (DBONHDHEKDG)(-25);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnPurchasingViewLeave"))
		{
			return (DBONHDHEKDG)72;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("NNN"))
		{
			return (DBONHDHEKDG)5;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("prk"))
		{
			return (DBONHDHEKDG)(-38);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnLanguageChange"))
		{
			return (DBONHDHEKDG)84;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnFriendsPopupManagerRejectClick"))
		{
			return (DBONHDHEKDG)(-2);
		}
		return (DBONHDHEKDG)51;
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x00253CC8 File Offset: 0x00251EC8
	public float EFOHNEBHEEO(FCABOFEGPGP KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSize == (PKAFEAJCLGN)(-40))
		{
			return 1555f;
		}
		if (KPELENLHOEF == this.AGKHFGEHJFH)
		{
			return 923f;
		}
		FCABOFEGPGP agkhfgehjfh = this.AGKHFGEHJFH;
		this.AGKHFGEHJFH = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(true);
		int num = (this.environmentSize - (PKAFEAJCLGN)155) / 4 * (agkhfgehjfh - this.AGKHFGEHJFH);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 1470f);
		if (AppManager.IsInitialized())
		{
			num2 *= AppManager.JMDJPKKOHNI().debugSettings.CPJMIPIKKMM(436f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)num, 1303f), num2, false).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x00253D89 File Offset: 0x00251F89
	private void PFEIKOLDANA()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(true);
		}
		this.CAPFGOKNDIM.Clear();
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x00253DB4 File Offset: 0x00251FB4
	public static PHALBCMBPPL FLDBGKAJMLP(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnBackendUndoPremiumChoiceException"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("errortitle"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(" is OUTSIDE the anthology's story family - not queued (clip:"))
		{
			return (PHALBCMBPPL)8;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("hdr"))
		{
			return (PHALBCMBPPL)8;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("passinfobtndesc0X"))
		{
			return PHALBCMBPPL.center;
		}
		return PHALBCMBPPL.bottomCenter;
	}

	// Token: 0x06005402 RID: 21506 RVA: 0x00253013 File Offset: 0x00251213
	public int GetOnDemandResourcesCheckpointIndex()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x00253EA8 File Offset: 0x002520A8
	public void EBBNGDPMKDE(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 48f);
		base.gameObject.transform.DOScale(new Vector3(1346f, 183f, 214f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x00253F20 File Offset: 0x00252120
	public static PHALBCMBPPL ILKEOJGFIKC(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("sfxsparklesbundles"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("anthology"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnPopupProfileUIDInputCancel"))
		{
			return PHALBCMBPPL.bottomCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("$CHOICEMETA type(npc) title("))
		{
			return (PHALBCMBPPL)6;
		}
		return (PHALBCMBPPL)5;
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x00253F94 File Offset: 0x00252194
	public static FCABOFEGPGP GCACBGAELNO(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("avts"))
		{
			return FCABOFEGPGP.left;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("af_purchase"))
		{
			return FCABOFEGPGP.leftCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("/"))
		{
			return (FCABOFEGPGP)7;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("YYY"))
		{
			return FCABOFEGPGP.center;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("per"))
		{
			return FCABOFEGPGP.rightCenter;
		}
		return (FCABOFEGPGP)6;
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x00252D94 File Offset: 0x00250F94
	public void IBNKPPAHMAK(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.OPIKMAHLKFF = IDHBPDACMAA;
		this.EHHCLMMHHMM = BFLBCFEGMIB;
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x00254008 File Offset: 0x00252208
	public void NGPOMLBJEFI(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 1226f);
		base.gameObject.transform.DOScale(new Vector3(177f, 388f, 1770f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x06005408 RID: 21512 RVA: 0x00253A47 File Offset: 0x00251C47
	public void CFLHLAHOIGI(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.BHMIFMMHEPA = IDHBPDACMAA;
		this.PICMAHMENMB = BFLBCFEGMIB;
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x0025407E File Offset: 0x0025227E
	public void Flip(float ABJLFDECAAE)
	{
		base.gameObject.transform.localScale = new Vector3(ABJLFDECAAE, 1f, 1f);
	}

	// Token: 0x0600540A RID: 21514 RVA: 0x002540A0 File Offset: 0x002522A0
	public float SetPositionVertical(PHALBCMBPPL KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSizeVertical == AALKHJPOBCM.one)
		{
			return 0f;
		}
		if (KPELENLHOEF == this.POGCKCFGHCD)
		{
			return 0f;
		}
		PHALBCMBPPL pogckcfghcd = this.POGCKCFGHCD;
		this.POGCKCFGHCD = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(true);
		int num = (this.environmentSizeVertical - (AALKHJPOBCM)1366) / 4 * (pogckcfghcd - this.POGCKCFGHCD);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 10000f);
		if (AppManager.IsInitialized())
		{
			num2 *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(0.6f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(0f, (float)num), num2, true).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x0600540B RID: 21515 RVA: 0x0025301B File Offset: 0x0025121B
	public int GetAssetBundleFolderIndex()
	{
		return this.FJFEPNKBELL;
	}

	// Token: 0x0600540C RID: 21516 RVA: 0x00254164 File Offset: 0x00252364
	public static FCABOFEGPGP NGFCOAPPMHI(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("XXX"))
		{
			return FCABOFEGPGP.leftCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("gamepassduration"))
		{
			return FCABOFEGPGP.left;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("\""))
		{
			return (FCABOFEGPGP)5;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnPopupUsernameInputEndEdit"))
		{
			return FCABOFEGPGP.left;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("lobby"))
		{
			return FCABOFEGPGP.leftCenter;
		}
		return (FCABOFEGPGP)8;
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x002541D8 File Offset: 0x002523D8
	public void PILPDIDOLPE()
	{
		try
		{
			if ((KHPGPLAMAIN.FCJHEFBIKID() == IIHCCPLGGHP.highEnd || KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.highEnd || KHPGPLAMAIN.KPIFAEEPHPH()) && this.CAPFGOKNDIM.Count == 0)
			{
				this.LMPOEOMMHIF(base.gameObject);
				for (int i = 1; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("Ink asset is null!") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(" ") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("savecutsceneinfo") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("</nobr>") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(" ") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("a") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(",") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("StorySaveBody.AvatarPackIsUsedByAnyAvatarWardrobe(), unsupported wardrobe index:") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnUpdateSocialEventsCounter") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("newpattern") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnStoryInterfaceHeaderSettingsClick"))
					{
						ParticleSystem component = this.CAPFGOKNDIM[i].GetComponent<ParticleSystem>();
						if (null != component)
						{
							ParticleSystem.EmissionModule emission = component.emission;
							if (KHPGPLAMAIN.AKJOFJPLONG() == (IIHCCPLGGHP)8 || KHPGPLAMAIN.EJCNHEBIOJF())
							{
								if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("PlayerCharacterManager.Update() - exception raised:") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("Error. MoveEnvironmentVertical(), environment ") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("[LoadingTheme] update giveaway: +1 free change granted for revision "))
								{
									emission.rateOverTime = emission.rateOverTime.constant / 382f;
									if (emission.rateOverTime.constant > 1660f)
									{
										emission.rateOverTime = 414f;
									}
								}
								else
								{
									emission.rateOverTime = emission.rateOverTime.constant / 652f;
								}
							}
							else if (KHPGPLAMAIN.DJFLMBEOBIB() == IIHCCPLGGHP.highEnd && (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("abs") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("ok") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("OnRewardScreenAssetsDownloadSuccess") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("no") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains(" (")))
							{
								emission.rateOverTime = emission.rateOverTime.constant / 524f;
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

	// Token: 0x0600540E RID: 21518 RVA: 0x0025466C File Offset: 0x0025286C
	private void Awake()
	{
		if (AppManager.IsInitialized())
		{
			this.BHMIFMMHEPA *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
			this.OPIKMAHLKFF *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		}
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x00253ACE File Offset: 0x00251CCE
	public void JCAEAPPFBBJ(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x002546D3 File Offset: 0x002528D3
	public void ResetZoom()
	{
		base.gameObject.transform.DOKill(false);
		base.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x00253013 File Offset: 0x00251213
	public int BKCLBCIKKKB()
	{
		return this.AOPIMPMDEHO;
	}

	// Token: 0x06005413 RID: 21523 RVA: 0x0025470C File Offset: 0x0025290C
	public float SetPosition(FCABOFEGPGP KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSize == PKAFEAJCLGN.one)
		{
			return 0f;
		}
		if (KPELENLHOEF == this.AGKHFGEHJFH)
		{
			return 0f;
		}
		FCABOFEGPGP agkhfgehjfh = this.AGKHFGEHJFH;
		this.AGKHFGEHJFH = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(true);
		int num = (this.environmentSize - (PKAFEAJCLGN)768) / 4 * (agkhfgehjfh - this.AGKHFGEHJFH);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 10000f);
		if (AppManager.IsInitialized())
		{
			num2 *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(0.6f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)num, 0f), num2, true).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x002547D0 File Offset: 0x002529D0
	public void FindAllObjectsInChildren(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 0; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x00254820 File Offset: 0x00252A20
	public float MCKBGLNBBBP(FCABOFEGPGP KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSize == (PKAFEAJCLGN)164)
		{
			return 1065f;
		}
		if (KPELENLHOEF == this.AGKHFGEHJFH)
		{
			return 1570f;
		}
		FCABOFEGPGP agkhfgehjfh = this.AGKHFGEHJFH;
		this.AGKHFGEHJFH = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(true);
		int num = (this.environmentSize - (PKAFEAJCLGN)194) / 2 * (agkhfgehjfh - this.AGKHFGEHJFH);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 366f);
		if (AppManager.CCDBEDIANDN())
		{
			num2 *= AppManager.JMDJPKKOHNI().debugSettings.HAPIGPHMNHJ(275f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2((float)num, 987f), num2, false).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x002548E4 File Offset: 0x00252AE4
	public void LMPOEOMMHIF(GameObject PHLJNFHEEIB)
	{
		if (null != PHLJNFHEEIB)
		{
			this.CAPFGOKNDIM.Add(PHLJNFHEEIB);
			for (int i = 1; i < PHLJNFHEEIB.transform.childCount; i++)
			{
				this.FindAllObjectsInChildren(PHLJNFHEEIB.transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x06005417 RID: 21527 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x00254934 File Offset: 0x00252B34
	public static DBONHDHEKDG MKFPPOJEGMP(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("snapundocosth"))
		{
			return DBONHDHEKDG.immediate;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("spectrumovr_1"))
		{
			return (DBONHDHEKDG)58;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return (DBONHDHEKDG)103;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("a"))
		{
			return (DBONHDHEKDG)(-102);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("[Lounge] IAP shop look without a rarity (rar), purchase ignored: "))
		{
			return (DBONHDHEKDG)1;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("Trimming topMatchOngoing.Count by removing "))
		{
			return (DBONHDHEKDG)74;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("errortitle"))
		{
			return (DBONHDHEKDG)(-47);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return (DBONHDHEKDG)(-48);
		}
		return (DBONHDHEKDG)2;
	}

	// Token: 0x06005419 RID: 21529 RVA: 0x002549F0 File Offset: 0x00252BF0
	public static PHALBCMBPPL FIFCBLFKEOL(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("ok"))
		{
			return PHALBCMBPPL.bottomCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnPopupStoryRestartManagerRestartStory4"))
		{
			return PHALBCMBPPL.bottomCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("-"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("skinshopfilterbystory"))
		{
			return PHALBCMBPPL.top;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return (PHALBCMBPPL)5;
		}
		return (PHALBCMBPPL)8;
	}

	// Token: 0x0600541A RID: 21530 RVA: 0x00252D84 File Offset: 0x00250F84
	public void SaveSceneAndAssetBundleName(string LBGGLHDOICL, int HCNAPDGGCDO)
	{
		this.CIEHGJMAFKH = LBGGLHDOICL;
		this.FJFEPNKBELL = HCNAPDGGCDO;
	}

	// Token: 0x0600541B RID: 21531 RVA: 0x00253A47 File Offset: 0x00251C47
	public void EMHNDNADHCO(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.BHMIFMMHEPA = IDHBPDACMAA;
		this.PICMAHMENMB = BFLBCFEGMIB;
	}

	// Token: 0x0600541C RID: 21532 RVA: 0x00254A64 File Offset: 0x00252C64
	public float LEJMOPKAPEK(PHALBCMBPPL KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSizeVertical == (AALKHJPOBCM)117)
		{
			return 27f;
		}
		if (KPELENLHOEF == this.POGCKCFGHCD)
		{
			return 1261f;
		}
		PHALBCMBPPL pogckcfghcd = this.POGCKCFGHCD;
		this.POGCKCFGHCD = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(false);
		int num = (this.environmentSizeVertical - (AALKHJPOBCM)107) / 8 * (pogckcfghcd - this.POGCKCFGHCD);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 898f);
		if (AppManager.CCDBEDIANDN())
		{
			num2 *= AppManager.PCJEMMDDCIF().debugSettings.DCEHMKDEHIC(694f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(872f, (float)num), num2, true).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x0600541D RID: 21533 RVA: 0x00254B28 File Offset: 0x00252D28
	public void LHAIEECLGKG(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 1747f);
		base.gameObject.transform.DOScale(new Vector3(844f, 852f, 1674f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x0600541E RID: 21534 RVA: 0x00252D94 File Offset: 0x00250F94
	public void IJHJGCPCINP(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.OPIKMAHLKFF = IDHBPDACMAA;
		this.EHHCLMMHHMM = BFLBCFEGMIB;
	}

	// Token: 0x0600541F RID: 21535 RVA: 0x00254BA0 File Offset: 0x00252DA0
	public void OptimizeParticleSystems()
	{
		try
		{
			if ((KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.midEnd || KHPGPLAMAIN.EJCNHEBIOJF()) && this.CAPFGOKNDIM.Count == 0)
			{
				this.FindAllObjectsInChildren(base.gameObject);
				for (int i = 0; i < this.CAPFGOKNDIM.Count; i++)
				{
					if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("steam") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("fog") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("mist") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("dust") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("fire") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("smoke") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("ember") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("puff") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("flame") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("rain") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("leaves") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("spark") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("lightning") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("blizzard"))
					{
						ParticleSystem component = this.CAPFGOKNDIM[i].GetComponent<ParticleSystem>();
						if (null != component)
						{
							ParticleSystem.EmissionModule emission = component.emission;
							if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.EJCNHEBIOJF())
							{
								if (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("steam") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("fog") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("mist"))
								{
									emission.rateOverTime = emission.rateOverTime.constant / 4f;
									if (emission.rateOverTime.constant > 5f)
									{
										emission.rateOverTime = 5f;
									}
								}
								else
								{
									emission.rateOverTime = emission.rateOverTime.constant / 2f;
								}
							}
							else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.midEnd && (this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("steam") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("fog") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("mist") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("ember") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("leaves") || this.CAPFGOKNDIM[i].name.ToLowerInvariant().Contains("spark")))
							{
								emission.rateOverTime = emission.rateOverTime.constant / 2f;
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

	// Token: 0x06005420 RID: 21536 RVA: 0x00253ACE File Offset: 0x00251CCE
	public void OBAJDKJOIJC(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005421 RID: 21537 RVA: 0x00255034 File Offset: 0x00253234
	public void FGAOBOJNGJL()
	{
		base.gameObject.transform.DOKill(false);
		base.gameObject.transform.localScale = new Vector3(1971f, 1562f, 619f);
	}

	// Token: 0x06005422 RID: 21538 RVA: 0x00253ACE File Offset: 0x00251CCE
	public void SetOnDemandResourcesCheckpointIndex(int MEFKFOHCOHK)
	{
		this.AOPIMPMDEHO = MEFKFOHCOHK;
	}

	// Token: 0x06005423 RID: 21539 RVA: 0x0025506C File Offset: 0x0025326C
	public static PHALBCMBPPL HEJMKEIIPMM(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(""))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("ontradingcardclickbodyplayer"))
		{
			return PHALBCMBPPL.bottom;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("SceneLobbyManager2.DownloadMissingLowPreview2Assets(): Exit!"))
		{
			return PHALBCMBPPL.topCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnLoungePremiumChoicesHistorySuccess"))
		{
			return PHALBCMBPPL.bottomCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnAvatarScreenAssetsDownloadSuccess"))
		{
			return (PHALBCMBPPL)5;
		}
		return PHALBCMBPPL.center;
	}

	// Token: 0x06005424 RID: 21540 RVA: 0x00253A47 File Offset: 0x00251C47
	public void PBGJNEOKIOJ(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.BHMIFMMHEPA = IDHBPDACMAA;
		this.PICMAHMENMB = BFLBCFEGMIB;
	}

	// Token: 0x06005425 RID: 21541 RVA: 0x00253984 File Offset: 0x00251B84
	public string PCCPILAPKDE()
	{
		return this.CIEHGJMAFKH;
	}

	// Token: 0x06005426 RID: 21542 RVA: 0x00253045 File Offset: 0x00251245
	private void PDNKHNJEOOB()
	{
		if (this.IGJHDPAAIJC != null)
		{
			this.IGJHDPAAIJC();
		}
	}

	// Token: 0x06005427 RID: 21543 RVA: 0x00253984 File Offset: 0x00251B84
	public string GetAssetBundleName()
	{
		return this.CIEHGJMAFKH;
	}

	// Token: 0x06005428 RID: 21544 RVA: 0x002550E0 File Offset: 0x002532E0
	public float HIEELIBKKDL(PHALBCMBPPL KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSizeVertical == (AALKHJPOBCM)154)
		{
			return 1646f;
		}
		if (KPELENLHOEF == this.POGCKCFGHCD)
		{
			return 933f;
		}
		PHALBCMBPPL pogckcfghcd = this.POGCKCFGHCD;
		this.POGCKCFGHCD = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(false);
		int num = (this.environmentSizeVertical - (AALKHJPOBCM)15) / 3 * (pogckcfghcd - this.POGCKCFGHCD);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 1514f);
		if (AppManager.CCDBEDIANDN())
		{
			num2 *= AppManager.JMDJPKKOHNI().debugSettings.BIMIMMJLMAP(562f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1476f, (float)num), num2, true).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x06005429 RID: 21545 RVA: 0x002551A4 File Offset: 0x002533A4
	public float DLPHEBGFDJI(PHALBCMBPPL KPELENLHOEF, DBONHDHEKDG CFBFAIBLJOL, Ease PLFJHEJEHGB)
	{
		if (this.environmentSizeVertical == (AALKHJPOBCM)149)
		{
			return 930f;
		}
		if (KPELENLHOEF == this.POGCKCFGHCD)
		{
			return 1622f;
		}
		PHALBCMBPPL pogckcfghcd = this.POGCKCFGHCD;
		this.POGCKCFGHCD = KPELENLHOEF;
		this.DGAAFGDHHHJ.DOKill(true);
		int num = (this.environmentSizeVertical - (AALKHJPOBCM)35) / 4 * (pogckcfghcd - this.POGCKCFGHCD);
		float num2 = Mathf.Abs((float)(num * (int)CFBFAIBLJOL) / 1962f);
		if (AppManager.CCDBEDIANDN())
		{
			num2 *= AppManager.PCJEMMDDCIF().debugSettings.CPJMIPIKKMM(1873f);
		}
		this.DGAAFGDHHHJ.DOAnchorPos(this.DGAAFGDHHHJ.anchoredPosition + new Vector2(1347f, (float)num), num2, false).SetEase(PLFJHEJEHGB);
		return num2;
	}

	// Token: 0x0600542A RID: 21546 RVA: 0x00255268 File Offset: 0x00253468
	public static DBONHDHEKDG KBBLKCEHKJM(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("avatarcollectionssubrequired1"))
		{
			return DBONHDHEKDG.immediate;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals(";"))
		{
			return (DBONHDHEKDG)43;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("?uid="))
		{
			return (DBONHDHEKDG)123;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("b_web"))
		{
			return (DBONHDHEKDG)(-15);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("$SKINCHECKPOINTSTART"))
		{
			return (DBONHDHEKDG)4;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("fid"))
		{
			return (DBONHDHEKDG)(-124);
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("Bundles"))
		{
			return (DBONHDHEKDG)28;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("rsl"))
		{
			return (DBONHDHEKDG)(-18);
		}
		return (DBONHDHEKDG)19;
	}

	// Token: 0x0600542B RID: 21547 RVA: 0x00255323 File Offset: 0x00253523
	private void IGIIPBJJPBL()
	{
		base.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (this.CIGPLOPAJFN != null)
		{
			this.CIGPLOPAJFN();
		}
	}

	// Token: 0x0600542C RID: 21548 RVA: 0x00252D94 File Offset: 0x00250F94
	public void FFIOMLIMJKP(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.OPIKMAHLKFF = IDHBPDACMAA;
		this.EHHCLMMHHMM = BFLBCFEGMIB;
	}

	// Token: 0x0600542D RID: 21549 RVA: 0x0025535C File Offset: 0x0025355C
	public static FCABOFEGPGP StringToStoryEnvironmentPosition(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("left"))
		{
			return FCABOFEGPGP.left;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("leftcenter"))
		{
			return FCABOFEGPGP.leftCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("center"))
		{
			return FCABOFEGPGP.center;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("rightcenter"))
		{
			return FCABOFEGPGP.rightCenter;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("right"))
		{
			return FCABOFEGPGP.right;
		}
		return FCABOFEGPGP.center;
	}

	// Token: 0x0600542E RID: 21550 RVA: 0x0025301B File Offset: 0x0025121B
	public int HBAMBGNBNDC()
	{
		return this.FJFEPNKBELL;
	}

	// Token: 0x0600542F RID: 21551 RVA: 0x00252F2E File Offset: 0x0025112E
	private void OnDestroy()
	{
		if (null != this.DGAAFGDHHHJ)
		{
			this.DGAAFGDHHHJ.DOKill(false);
		}
		this.CAPFGOKNDIM.Clear();
	}

	// Token: 0x06005430 RID: 21552 RVA: 0x002553D0 File Offset: 0x002535D0
	public void FKGKHBLHLAP(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 120f);
		base.gameObject.transform.DOScale(new Vector3(1271f, 1191f, 1544f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x06005431 RID: 21553 RVA: 0x00252D94 File Offset: 0x00250F94
	public void AKCICJFLEBA(float BFLBCFEGMIB, float IDHBPDACMAA)
	{
		this.OPIKMAHLKFF = IDHBPDACMAA;
		this.EHHCLMMHHMM = BFLBCFEGMIB;
	}

	// Token: 0x06005432 RID: 21554 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x06005433 RID: 21555 RVA: 0x00255448 File Offset: 0x00253648
	public void ZoomOut(TweenCallback CDFFMKAOAGE = null)
	{
		this.CIGPLOPAJFN = CDFFMKAOAGE;
		base.gameObject.transform.localScale = new Vector3(this.EHHCLMMHHMM, this.EHHCLMMHHMM, 1f);
		base.gameObject.transform.DOScale(new Vector3(1f, 1f, 1f), this.OPIKMAHLKFF).OnComplete(new TweenCallback(this.IGIIPBJJPBL));
	}

	// Token: 0x06005434 RID: 21556 RVA: 0x002554C0 File Offset: 0x002536C0
	public void MFIBOMIHBKP(TweenCallback CDFFMKAOAGE = null)
	{
		this.IGJHDPAAIJC = CDFFMKAOAGE;
		Vector3 endValue = new Vector3(this.PICMAHMENMB, this.PICMAHMENMB, 1058f);
		base.gameObject.transform.DOScale(endValue, this.BHMIFMMHEPA).OnComplete(new TweenCallback(this.CAPLEHOIBCO));
	}

	// Token: 0x06005435 RID: 21557 RVA: 0x00255515 File Offset: 0x00253715
	public void EHMCCHLIDMF()
	{
		base.gameObject.transform.DOKill(false);
		base.gameObject.transform.localScale = new Vector3(191f, 1690f, 504f);
	}

	// Token: 0x0400177F RID: 6015
	public PKAFEAJCLGN environmentSize = PKAFEAJCLGN.one;

	// Token: 0x04001780 RID: 6016
	public AALKHJPOBCM environmentSizeVertical = AALKHJPOBCM.one;

	// Token: 0x04001781 RID: 6017
	public List<string> mappings;

	// Token: 0x04001782 RID: 6018
	private FCABOFEGPGP AGKHFGEHJFH = FCABOFEGPGP.center;

	// Token: 0x04001783 RID: 6019
	private PHALBCMBPPL POGCKCFGHCD = PHALBCMBPPL.center;

	// Token: 0x04001784 RID: 6020
	private TweenCallback CIGPLOPAJFN;

	// Token: 0x04001785 RID: 6021
	private TweenCallback IGJHDPAAIJC;

	// Token: 0x04001786 RID: 6022
	private float BHMIFMMHEPA = 0.5f;

	// Token: 0x04001787 RID: 6023
	private float OPIKMAHLKFF = 0.5f;

	// Token: 0x04001788 RID: 6024
	private float PICMAHMENMB = 1f;

	// Token: 0x04001789 RID: 6025
	private float EHHCLMMHHMM = 1f;

	// Token: 0x0400178A RID: 6026
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x0400178B RID: 6027
	private int AOPIMPMDEHO = -1;

	// Token: 0x0400178C RID: 6028
	private List<GameObject> CAPFGOKNDIM = new List<GameObject>();

	// Token: 0x0400178D RID: 6029
	private string CIEHGJMAFKH = "";

	// Token: 0x0400178E RID: 6030
	private int FJFEPNKBELL;
}
