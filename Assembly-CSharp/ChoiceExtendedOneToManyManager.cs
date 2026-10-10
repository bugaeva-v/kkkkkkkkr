using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000124 RID: 292
public class ChoiceExtendedOneToManyManager : MonoBehaviour
{
	// Token: 0x0600265B RID: 9819 RVA: 0x00116140 File Offset: 0x00114340
	public bool Initialize(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		bool result;
		try
		{
			result = this.GCKHGJBPNHF(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID, IFPEJMLKMPB);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
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
			throw;
		}
		return result;
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x001161D0 File Offset: 0x001143D0
	private bool GCKHGJBPNHF(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.IIFKDKNJJDO.SetDirection(false);
		this.IIFKDKNJJDO.PlayAnimation(false);
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.OONENNLLFHL())
		{
			return false;
		}
		if (this.version >= 2 && this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0 && this.IMPAHLIGELE.JGEDOIDOPLA != null)
		{
			try
			{
				if (this.IMPAHLIGELE.JGEDOIDOPLA.JDJCPFDLBKG(this.IMPAHLIGELE.COEFNFJMBDG.Count))
				{
					this.IMPAHLIGELE.JGEDOIDOPLA.LOAJFPFKHJH(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
			{
				for (int i = 0; i < this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[i].EKDGAODNDOP() == HKCCMACFNEO.bulk)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
						{
							if (l < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[l] > 0)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[l] > 0)
							{
								num = 2;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JGEDOIDOPLA.PFLJLFGCIFB();
		try
		{
			sourceText = ONEHEBIHPFB.LMDACNKELEC(this.IMPAHLIGELE.JGEDOIDOPLA.PFLJLFGCIFB());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, true);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.item)
		{
			this.storyItemPivot.SetActive(true);
			string khjmandedma = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			if (BAOKJBJIFBH.NCAMFPGMCIG.GEPGEMMNAPC() >= 2)
			{
				khjmandedma = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyItemPrefab);
			gameObject.transform.SetParent(this.storyItemPivot.transform, false);
			this.OKLPOLPIJNF = gameObject.GetComponent<StoryItemManager>();
			this.OKLPOLPIJNF.Initialize(GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma), false);
			this.OKLPOLPIJNF.GetComponent<RectTransform>().AHLJBONHHKL(0, 30);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.npc)
		{
			this.storyItemPivot.SetActive(false);
			string text = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			try
			{
				text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
				if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, ""))
				{
					for (int m = 0; m < this.ODNCKIKLFCM.Count; m++)
					{
						if (null != this.ODNCKIKLFCM[m])
						{
							for (int n = 0; n < this.ODNCKIKLFCM[m].mappings.Count; n++)
							{
								if (this.ODNCKIKLFCM[m].mappings[n].Equals(text))
								{
									DPGJIJGOCIC.ADFCDFHBDAF("Character " + text + " not found, replacing with " + this.ODNCKIKLFCM[m].id);
									text = this.ODNCKIKLFCM[m].id;
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
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
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			this.LLEOBLHCNJA = this.OELALBBMILL(true);
			if (this.LLEOBLHCNJA != null)
			{
				this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
				this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
				this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
				gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
				gameObject3.transform.SetParent(this.characterPivot.transform, false);
				this.GOAEECPPHIB = gameObject3.GetComponent<PlayerCharacterManager>();
				this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
			}
			this.GOAEECPPHIB.AnimateAppearance(BKBCKPMDFOD.animationChoiceMetaAppearFromLeft);
		}
		else
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF != JJBCFINBFKL.BDBLHBOFMII.none)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ChoiceExtendedOneToManyManager.Initialize() - choice type not supported:" + this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF.ToString());
				return false;
			}
			this.storyItemPivot.SetActive(false);
		}
		int num2 = 0;
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			int num3 = 0;
			while (num3 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject4 = null;
				int num4 = 0;
				if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
				{
					if (this.HDBBHHBOJIN(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)] > 0)
					{
						num4 = 1;
					}
					else if (this.HDBBHHBOJIN(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.HDBBHHBOJIN(num3)] > 0)
					{
						num4 = 2;
					}
				}
				if (num4 == 2)
				{
					switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject4.transform.SetParent(this.choicePivot.transform, false);
					gameObject4.GetComponent<ChoiceStatManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.HDBBHHBOJIN(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)]].GALKFKBPLCK(), this.forcedChoiceWidth);
					gameObject4.GetComponent<ChoiceStatManager>().ExtendRightSide();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)]].GALKFKBPLCK());
							try
							{
								if (this.IMPAHLIGELE.JGEDOIDOPLA.NGNDOALIKAK.Contains("hidestatinfo"))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm4)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
							}
						}
						goto IL_C93;
					}
					catch (Exception aklgbjkdomm5)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
						goto IL_C93;
					}
					goto IL_A06;
				}
				goto IL_A06;
				IL_C93:
				gameObject4.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, (float)(this.choiceOffset * num2));
				Button component = gameObject4.GetComponent<Button>();
				if (this.HDBBHHBOJIN(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(num3) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(num3) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.HDBBHHBOJIN(num3) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.HDBBHHBOJIN(num3) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(num3) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.HMHIJLKJGFN));
				}
				this.AKFKCKHPIOA.Add(gameObject4);
				num2++;
				num3++;
				continue;
				IL_A06:
				if (num4 == 1)
				{
					gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject4.transform.SetParent(this.choicePivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ, this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ))
					{
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], 0, this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.CKLNCCAGCKE(this.HDBBHHBOJIN(num3), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("OnStoryCurrencyInfoClick");
						}
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)], this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.CKLNCCAGCKE(this.HDBBHHBOJIN(num3), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					gameObject4.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KAJNELPPCIJ[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ));
					goto IL_C93;
				}
				gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject4.transform.SetParent(this.choicePivot.transform, false);
				gameObject4.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], this.forcedChoiceWidth);
				goto IL_C93;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		if (this.version >= 2 && this.AKFKCKHPIOA.Count > 2)
		{
			try
			{
				this.EKAJHPJJIOK = Math.Abs(this.choiceOffset * (this.AKFKCKHPIOA.Count - 2));
				RectTransform component2 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component2)
				{
					component2.ACBKFBBCNNC(component2.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component3 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component3)
				{
					component3.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
				RectTransform component4 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component4)
				{
					component4.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
				goto IL_F5D;
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
				goto IL_F5D;
			}
		}
		if (this.version >= 2 && this.AKFKCKHPIOA.Count == 1)
		{
			try
			{
				this.EKAJHPJJIOK = this.choiceOffset / 2;
				RectTransform component5 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component5)
				{
					component5.ACBKFBBCNNC(component5.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component6 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component6)
				{
					component6.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
				RectTransform component7 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component7)
				{
					component7.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
		IL_F5D:
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x001171F4 File Offset: 0x001153F4
	private void EPIHFCPOLJJ()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("OnLiveOfferSuccessShowPassesWindow", 1031f);
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x00117216 File Offset: 0x00115416
	public void HidePanel()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnTryToFireNoteshowTimer", 0f);
		this.OPLDMEEFKDO(false);
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x00117234 File Offset: 0x00115434
	private bool JDAKOGIEFKK(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.IIFKDKNJJDO.BPCOKLEABJD(true);
		this.IIFKDKNJJDO.OENEEPHFNGD(false);
		this.OPLDMEEFKDO(false);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.LOJGGNLALGF())
		{
			return false;
		}
		if (this.version >= 6 && this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0 && this.IMPAHLIGELE.JGEDOIDOPLA != null)
		{
			try
			{
				if (this.IMPAHLIGELE.JGEDOIDOPLA.LJGAKGDBCOI(this.IMPAHLIGELE.COEFNFJMBDG.Count))
				{
					this.IMPAHLIGELE.JGEDOIDOPLA.DLKADKBAJNL(BAOKJBJIFBH.NCAMFPGMCIG.AGKMGGPILIA());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[i].OCOHIFJDCHD() == HKCCMACFNEO.free)
					{
						for (int j = 1; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 8; k++)
				{
					for (int l = 1; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
						{
							if (l < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[l] > 0)
							{
								num = 0;
							}
							else if (l < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[l] > 0)
							{
								num = 6;
							}
						}
						if ((k == 0 && num == 0) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JGEDOIDOPLA.ALAGMBEKNLD();
		try
		{
			sourceText = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.JGEDOIDOPLA.BEDLOHCEMAH());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, false);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.npc)
		{
			this.storyItemPivot.SetActive(false);
			string khjmandedma = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			if (BAOKJBJIFBH.NCAMFPGMCIG.HKJMEKPOPJF() >= 7)
			{
				khjmandedma = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyItemPrefab);
			gameObject.transform.SetParent(this.storyItemPivot.transform, true);
			this.OKLPOLPIJNF = gameObject.GetComponent<StoryItemManager>();
			this.OKLPOLPIJNF.DGAFAPKAKIA(GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma), false);
			this.OKLPOLPIJNF.GetComponent<RectTransform>().AHLJBONHHKL(0, 33);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			string text = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			try
			{
				text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
				if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "imagehard"))
				{
					for (int m = 0; m < this.ODNCKIKLFCM.Count; m++)
					{
						if (null != this.ODNCKIKLFCM[m])
						{
							for (int n = 0; n < this.ODNCKIKLFCM[m].mappings.Count; n += 0)
							{
								if (this.ODNCKIKLFCM[m].mappings[n].Equals(text))
								{
									DPGJIJGOCIC.ADFCDFHBDAF("Close console" + text + "OnBackendGetDefaultBundlesSuccess" + this.ODNCKIKLFCM[m].id);
									text = this.ODNCKIKLFCM[m].id;
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
			}
			this.DAHDOMMANDF = this.KJMPHNKPENL(false);
			if (this.DAHDOMMANDF != null)
			{
				this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
				this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, true);
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
				gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleLeft);
				gameObject2.transform.SetParent(this.characterPivot.transform, true);
				this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, true);
			}
			this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryAppearFromRight);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			this.LLEOBLHCNJA = this.AELDLODLLPI(true);
			if (this.LLEOBLHCNJA != null)
			{
				this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
				this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
				gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
				gameObject3.transform.SetParent(this.characterPivot.transform, true);
				this.GOAEECPPHIB = gameObject3.GetComponent<PlayerCharacterManager>();
				this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, null);
			}
			this.GOAEECPPHIB.AnimateAppearance(BKBCKPMDFOD.animationChoiceMetaAppear);
		}
		else
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF != (JJBCFINBFKL.BDBLHBOFMII)4)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("apkshe1" + this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF.ToString());
				return false;
			}
			this.storyItemPivot.SetActive(false);
		}
		int num2 = 0;
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			int num3 = 1;
			while (num3 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject4 = null;
				int num4 = 0;
				if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
				{
					if (this.DDGLJHFNBGK(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.DDGLJHFNBGK(num3)] > 1)
					{
						num4 = 0;
					}
					else if (this.LJPFELOIIPA(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.DDGLJHFNBGK(num3)] > 0)
					{
						num4 = 0;
					}
				}
				if (num4 == 5)
				{
					switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.LJPFELOIIPA(num3)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject4.transform.SetParent(this.choicePivot.transform, true);
					gameObject4.GetComponent<ChoiceStatManager>().KIDOILDEFEB(this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.DDGLJHFNBGK(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.LJPFELOIIPA(num3)]].LPKLANAEIFF(), this.forcedChoiceWidth);
					gameObject4.GetComponent<ChoiceStatManager>().FIDLNEAALBF();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.LJPFELOIIPA(num3)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)]].MOBKGNBCIJF());
							try
							{
								if (this.IMPAHLIGELE.JGEDOIDOPLA.NGNDOALIKAK.Contains("[LoadingEnv] cache files of "))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm4)
							{
								DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm4);
							}
						}
						goto IL_C93;
					}
					catch (Exception aklgbjkdomm5)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm5);
						goto IL_C93;
					}
					goto IL_A06;
				}
				goto IL_A06;
				IL_C93:
				gameObject4.GetComponent<RectTransform>().anchoredPosition += new Vector2(1275f, (float)(this.choiceOffset * num2));
				Button component = gameObject4.GetComponent<Button>();
				if (this.LJPFELOIIPA(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.HDBBHHBOJIN(num3) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.HDBBHHBOJIN(num3) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.LFCGEIGDHOG));
				}
				else if (this.HDBBHHBOJIN(num3) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.EPIHFCPOLJJ));
				}
				else if (this.LJPFELOIIPA(num3) == 7)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(num3) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.COLPDMCKNLP));
				}
				this.AKFKCKHPIOA.Add(gameObject4);
				num2 += 0;
				num3 += 0;
				continue;
				IL_A06:
				if (num4 == 1)
				{
					gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject4.transform.SetParent(this.choicePivot.transform, true);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ, this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ))
					{
						gameObject4.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], 0, this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.MHGNLMNFBPI(this.DDGLJHFNBGK(num3), LiveEventsManager.EHBBFMCILPC.LiveEventActive(EGMCEPOABBF.liveEventMessage, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("Starting non-parallel download:");
						}
						gameObject4.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.DDGLJHFNBGK(num3)], this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.OOECAIMDCHF(this.HDBBHHBOJIN(num3), LiveEventsManager.BIAEAOMHBMM().OPHKFJNACGB((EGMCEPOABBF)7, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					gameObject4.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KAJNELPPCIJ[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ));
					goto IL_C93;
				}
				gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject4.transform.SetParent(this.choicePivot.transform, true);
				gameObject4.GetComponent<ChoiceStandardManager>().HBBFAAOICDH(this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], this.forcedChoiceWidth);
				goto IL_C93;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		if (this.version >= 5 && this.AKFKCKHPIOA.Count > 8)
		{
			try
			{
				this.EKAJHPJJIOK = Math.Abs(this.choiceOffset * (this.AKFKCKHPIOA.Count - 8));
				RectTransform component2 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component2)
				{
					component2.ACBKFBBCNNC(component2.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component3 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component3)
				{
					component3.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component4 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component4)
				{
					component4.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
				goto IL_F5D;
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
				goto IL_F5D;
			}
		}
		if (this.version >= 7 && this.AKFKCKHPIOA.Count == 1)
		{
			try
			{
				this.EKAJHPJJIOK = this.choiceOffset / 5;
				RectTransform component5 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component5)
				{
					component5.ACBKFBBCNNC(component5.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component6 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component6)
				{
					component6.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component7 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component7)
				{
					component7.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
		IL_F5D:
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x00118258 File Offset: 0x00116458
	private void JNFEIONBJHI()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("mypsuspintrobtn", 446f);
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x0011827C File Offset: 0x0011647C
	public bool OIGPAKEFAGM(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		bool result;
		try
		{
			result = this.GCKHGJBPNHF(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID, IFPEJMLKMPB);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
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
			throw;
		}
		return result;
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x0011830C File Offset: 0x0011650C
	private void OnDisable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x00118329 File Offset: 0x00116529
	private void GMPJMMMIGLO()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x0011834B File Offset: 0x0011654B
	private bool OONENNLLFHL()
	{
		if (this.IMPAHLIGELE == null || this.IMPAHLIGELE.JGEDOIDOPLA == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("ChoiceExtendedOneToManyManager.InputDataIsValid() - step.choiceMetaOneToMany is null.");
			return false;
		}
		return true;
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x00118370 File Offset: 0x00116570
	private void KOOEFLDJLLC()
	{
		if (this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			if (!AudioManager.APGODIBBPOD().PlaySfx("OnTryToFireNoteshowTimer", false) && !AudioManager.IFDLAMLHKIJ().PlaySfx("errortitle", true) && !AudioManager.BFCHJBOOJKE().PlaySfx("hofr" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.DBFLIEGGGNN().PlaySfx("RT REPORT - CharacterRenderTexturePool - ", true);
			}
			this.premiumParticles.GetComponent<AnimationScale>().CJDFPJHCBBD();
			this.premiumParticles.Play();
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.GHGMNAINIBF(1318f));
		}
		else
		{
			if (!AudioManager.BFCHJBOOJKE().PlaySfx("ok", true) && !AudioManager.DMAAFFFEJGA().PlaySfx(") is outside range", true) && !AudioManager.BFCHJBOOJKE().PlaySfx("OnApplicationRestart" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.DMAAFFFEJGA().PlaySfx("mins", true);
			}
			this.standardParticles.GetComponent<AnimationScale>().HOBGLEOKFAE();
			this.standardParticles.Play();
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.IJNDFPIIIFD(1653f));
		}
		try
		{
			if (this.version >= 3 && this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JGEDOIDOPLA != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB.Length > 1)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB + "topcenter" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x001185AC File Offset: 0x001167AC
	private IEnumerator MNINPBAEEFM()
	{
		ChoiceExtendedOneToManyManager.DFHAINNCPOJ dfhainncpoj = new ChoiceExtendedOneToManyManager.DFHAINNCPOJ(1);
		dfhainncpoj.<>4__this = this;
		return dfhainncpoj;
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x001185BC File Offset: 0x001167BC
	private void MFPBKLMBANF()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(464f) && null != this.currencyPivot)
		{
			float num = Mathf.Abs(1399f - NarrowScreenScaler.HNPNANKGAOD(661f, (IMBLFHMKMAD)169));
			num = Mathf.Clamp01(num);
			this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(137f, 1537f * num);
		}
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x00118624 File Offset: 0x00116824
	public float GetChoiceExecutedAnimationTime()
	{
		if (this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			return 2.5f;
		}
		return 0.5f;
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x00118694 File Offset: 0x00116894
	private void ALKBENHJEPC()
	{
		if (this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("sparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles", false) && !AudioManager.EHBBFMCILPC.PlaySfx("sfxsparklesbundles" + AKLFPGMDKLA.EHBBFMCILPC.EEILOKHLKIM().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("sparkles", false);
			}
			this.premiumParticles.GetComponent<AnimationScale>().PlayAnimation();
			this.premiumParticles.Play();
			this.KMNAIGHHKEO(true);
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
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.AJKLIACJNAD(0f));
		}
		try
		{
			if (this.version >= 2 && this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JGEDOIDOPLA != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB + "+" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x001188D0 File Offset: 0x00116AD0
	private void HPDHFIHPKGP()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(584f) && null != this.currencyPivot)
		{
			float num = Mathf.Abs(1920f - NarrowScreenScaler.HNPNANKGAOD(1048f, (IMBLFHMKMAD)132));
			num = Mathf.Clamp01(num);
			this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(963f, 772f * num);
		}
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x00118938 File Offset: 0x00116B38
	private void DBKIECEKAGI()
	{
		if (this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 0)
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("0", true) && !AudioManager.IFDLAMLHKIJ().PlaySfx("OnBackendSavePublicProfileSuccess", true) && !AudioManager.APGODIBBPOD().PlaySfx("chs" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), true))
			{
				AudioManager.BFCHJBOOJKE().PlaySfx("  ", true);
			}
			this.premiumParticles.GetComponent<AnimationScale>().JJNBJPCALPG();
			this.premiumParticles.Play();
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.GHGMNAINIBF(412f));
		}
		else
		{
			if (!AudioManager.DBFLIEGGGNN().PlaySfx("aind", true) && !AudioManager.EHBBFMCILPC.PlaySfx("+", true) && !AudioManager.BFCHJBOOJKE().PlaySfx("app42error" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.IFDLAMLHKIJ().PlaySfx("", false);
			}
			this.standardParticles.GetComponent<AnimationScale>().HOBGLEOKFAE();
			this.standardParticles.Play();
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.AJKLIACJNAD(58f));
		}
		try
		{
			if (this.version >= 7 && this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JGEDOIDOPLA != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.NKIOJCLBKAK(this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB + "uid" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x00118B74 File Offset: 0x00116D74
	private void OPLDMEEFKDO(bool CHOBEDPLLOG)
	{
		float num = 0f;
		try
		{
			if (NarrowScreenScaler.ScreenIsTooNarrow(850f))
			{
				float num2 = Mathf.Clamp01(Mathf.Clamp01(NBDLBFJOEGN.LAIDCKNIOIN() - 2.25f) / 0.3499999f);
				num = 3f * num2;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (CHOBEDPLLOG)
		{
			this.backPanelButton.interactable = false;
			this.animationCanvasGroupBackPanel.SetDirection(true);
			this.animationCanvasGroupBackPanel.PlayAnimation(false);
			this.animationCanvasGroupChoicePanel.SetDirection(false);
			this.animationCanvasGroupChoicePanel.PlayAnimation(false);
			this.animationCanvasGroupCurrencyPanel.SetDirection(false);
			this.animationCanvasGroupCurrencyPanel.PlayAnimation(false);
			this.slidingPanelButtonHide1.interactable = false;
			this.slidingPanelButtonHide2.interactable = false;
			this.FOPNADOFECH.OGOFACPLOGO((float)((int)this.OIPMEGJLIDC.x), (float)((int)this.OIPMEGJLIDC.y) - num - (float)(this.slidingPanelTranslationAmountY + this.EKAJHPJJIOK) * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC, 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DKHPGMJOENF));
			return;
		}
		this.slidingPanelButtonHide1.interactable = false;
		this.slidingPanelButtonHide2.interactable = false;
		this.animationCanvasGroupBackPanel.SetDirection(false);
		this.animationCanvasGroupBackPanel.PlayAnimation(false);
		this.animationCanvasGroupChoicePanel.SetDirection(true);
		this.animationCanvasGroupChoicePanel.PlayAnimation(false);
		this.animationCanvasGroupCurrencyPanel.SetDirection(true);
		this.animationCanvasGroupCurrencyPanel.PlayAnimation(false);
		this.FOPNADOFECH.OGOFACPLOGO((int)this.OIPMEGJLIDC.x, (int)this.OIPMEGJLIDC.y);
		this.FOPNADOFECH.DOAnchorPos(this.OIPMEGJLIDC - new Vector2(0f, num + (float)(this.slidingPanelTranslationAmountY + this.EKAJHPJJIOK) * NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225)), 0.5f, false).SetEase(Ease.OutSine).OnComplete(new TweenCallback(this.DDNMMPIJLNK));
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x00118D9C File Offset: 0x00116F9C
	public void ShowPanel()
	{
		this.OPLDMEEFKDO(true);
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x00118DA5 File Offset: 0x00116FA5
	private void OLGOAJEBMIK()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x00118DC7 File Offset: 0x00116FC7
	private void AEBEAFNFGCE()
	{
		this.backPanelButton.interactable = true;
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x00118DD5 File Offset: 0x00116FD5
	private IEnumerator GHGMNAINIBF(float BICHMDEIFKI)
	{
		ChoiceExtendedOneToManyManager.LKOBBKMIBHF lkobbkmibhf = new ChoiceExtendedOneToManyManager.LKOBBKMIBHF(1);
		lkobbkmibhf.<>4__this = this;
		lkobbkmibhf._delay = BICHMDEIFKI;
		return lkobbkmibhf;
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x00118DEC File Offset: 0x00116FEC
	private void LOLKBOCEOMD()
	{
		if (this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG != null && this.IMPAHLIGELE.EKOIFOBAHDM() < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.IMPAHLIGELE.EKOIFOBAHDM()] > 1)
		{
			if (!AudioManager.DBFLIEGGGNN().PlaySfx("ok", true) && !AudioManager.DBFLIEGGGNN().PlaySfx("<i>", true) && !AudioManager.IFDLAMLHKIJ().PlaySfx("BackendOperationsManager.RequestSpinWheel, exception while initializing RSACryptoServiceProvider:" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), true))
			{
				AudioManager.DBFLIEGGGNN().PlaySfx(" ", false);
			}
			this.premiumParticles.GetComponent<AnimationScale>().CJDFPJHCBBD();
			this.premiumParticles.Play();
			this.KMNAIGHHKEO(false);
			base.StartCoroutine(this.GHGMNAINIBF(1364f));
		}
		else
		{
			if (!AudioManager.EHBBFMCILPC.PlaySfx("clthb", false) && !AudioManager.DMAAFFFEJGA().PlaySfx("OnAppleLoginSuccess", true) && !AudioManager.EHBBFMCILPC.PlaySfx("OnLobbyWheelDataDataCdnFailed" + AKLFPGMDKLA.EHBBFMCILPC.OMOJIEHBENF().GGICIBLJIKI.ToString(), false))
			{
				AudioManager.EHBBFMCILPC.PlaySfx("item", true);
			}
			this.standardParticles.GetComponent<AnimationScale>().CJDFPJHCBBD();
			this.standardParticles.Play();
			this.KMNAIGHHKEO(true);
			base.StartCoroutine(this.GHGMNAINIBF(1833f));
		}
		try
		{
			if (this.version >= 1 && this.LMKDNPOKOBF != null && this.IMPAHLIGELE.JGEDOIDOPLA != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB != null && this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB.Length > 0)
			{
				this.LMKDNPOKOBF.NCAMFPGMCIG.KEMFLHJKBNO(this.IMPAHLIGELE.JGEDOIDOPLA.NDPPILBPOGB + "_VignetteScale" + this.IMPAHLIGELE.EKOIFOBAHDM().ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x00119028 File Offset: 0x00117228
	private void LFCGEIGDHOG()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(7);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("", 190f);
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x0011904A File Offset: 0x0011724A
	private void FEJOMHHCNNI()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(1);
		AOBJLALDBAA.FILDBDMENPG().DCGCFPHHDDG("Collections/", 1281f);
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x0011906C File Offset: 0x0011726C
	private int DDGLJHFNBGK(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x0011906C File Offset: 0x0011726C
	private int HDBBHHBOJIN(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x0011907C File Offset: 0x0011727C
	private void Start()
	{
		if (NarrowScreenScaler.ScreenIsTooNarrow(850f) && null != this.currencyPivot)
		{
			float num = Mathf.Abs(1f - NarrowScreenScaler.CalculateNewScaleUtil(850f, IMBLFHMKMAD.aspectRatio225));
			num = Mathf.Clamp01(num);
			this.currencyPivot.GetComponent<RectTransform>().AHLJBONHHKL(0f, -50f * num);
		}
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x00118DC7 File Offset: 0x00116FC7
	private void OKLCKENLOLH()
	{
		this.backPanelButton.interactable = true;
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x001190E1 File Offset: 0x001172E1
	private void HMHIJLKJGFN()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(5);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x00119103 File Offset: 0x00117303
	private void AIGAAPBGLMN()
	{
		AOBJLALDBAA.BIAEAOMHBMM().MANLHALMCIH("payload serialize failed: ", new UnityAction(this.DBKIECEKAGI));
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x00119120 File Offset: 0x00117320
	private bool OPALODICAJK(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.IIFKDKNJJDO.FOLIHFAJOCP(false);
		this.IIFKDKNJJDO.PGKFNLNMIHN(false);
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.MOIAENHBGDJ())
		{
			return true;
		}
		if (this.version >= 8 && this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0 && this.IMPAHLIGELE.JGEDOIDOPLA != null)
		{
			try
			{
				if (this.IMPAHLIGELE.JGEDOIDOPLA.DBOMDDCPCFN(this.IMPAHLIGELE.COEFNFJMBDG.Count))
				{
					this.IMPAHLIGELE.JGEDOIDOPLA.DLKADKBAJNL(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[i].BFGHEPLHJFI() == (HKCCMACFNEO)6)
					{
						for (int j = 1; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 1; k += 0)
				{
					for (int l = 1; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l++)
					{
						int num = 0;
						if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
						{
							if (l < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[l] > 0)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[l] > 1)
							{
								num = 3;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 0))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JGEDOIDOPLA.PEHFOBFKFPG();
		try
		{
			sourceText = ONEHEBIHPFB.DEOJEIEJGEE(this.IMPAHLIGELE.JGEDOIDOPLA.MNFFMGOOHLE());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, false);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.npc)
		{
			this.storyItemPivot.SetActive(false);
			string khjmandedma = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			if (BAOKJBJIFBH.NCAMFPGMCIG.GEPGEMMNAPC() >= 4)
			{
				khjmandedma = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyItemPrefab);
			gameObject.transform.SetParent(this.storyItemPivot.transform, false);
			this.OKLPOLPIJNF = gameObject.GetComponent<StoryItemManager>();
			this.OKLPOLPIJNF.KGFEFGNFPJO(GKJPOGNFKNK.HNPOJCILEHP(khjmandedma), false);
			this.OKLPOLPIJNF.GetComponent<RectTransform>().AHLJBONHHKL(0, 92);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			string text = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			try
			{
				text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
				if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, " card(s) around scroll index "))
				{
					for (int m = 0; m < this.ODNCKIKLFCM.Count; m += 0)
					{
						if (null != this.ODNCKIKLFCM[m])
						{
							for (int n = 1; n < this.ODNCKIKLFCM[m].mappings.Count; n += 0)
							{
								if (this.ODNCKIKLFCM[m].mappings[n].Equals(text))
								{
									DPGJIJGOCIC.ADFCDFHBDAF("'" + text + "" + this.ODNCKIKLFCM[m].id);
									text = this.ODNCKIKLFCM[m].id;
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
			}
			this.DAHDOMMANDF = this.KJMPHNKPENL(false);
			if (this.DAHDOMMANDF != null)
			{
				this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
				this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, true);
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().nonPlayerCharacterPrefab);
				gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
				gameObject2.transform.SetParent(this.characterPivot.transform, true);
				this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.right, true);
			}
			this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationStoryAppearFromRight);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(true);
			this.LLEOBLHCNJA = this.AELDLODLLPI(true);
			if (this.LLEOBLHCNJA != null)
			{
				this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
				this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
				this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.MJBDMHPHMID().playerCharacterPrefab);
				gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
				gameObject3.transform.SetParent(this.characterPivot.transform, false);
				this.GOAEECPPHIB = gameObject3.GetComponent<PlayerCharacterManager>();
				this.GOAEECPPHIB.LPIKCMJLDFP(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, null);
			}
			this.GOAEECPPHIB.AnimateAppearance(BKBCKPMDFOD.animationStoryAppearFromRight);
		}
		else
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF != JJBCFINBFKL.BDBLHBOFMII.player)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("PlayMusic() file not found:" + this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF.ToString());
				return false;
			}
			this.storyItemPivot.SetActive(false);
		}
		int num2 = 1;
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			int num3 = 0;
			while (num3 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject4 = null;
				int num4 = 1;
				if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
				{
					if (this.DDGLJHFNBGK(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.LJPFELOIIPA(num3)] > 1)
					{
						num4 = 0;
					}
					else if (this.HDBBHHBOJIN(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.HDBBHHBOJIN(num3)] > 0)
					{
						num4 = 0;
					}
				}
				if (num4 == 7)
				{
					switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject4.transform.SetParent(this.choicePivot.transform, true);
					gameObject4.GetComponent<ChoiceStatManager>().KMDKBPNAKOG(this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.DDGLJHFNBGK(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)]].CJLDJAJHMMA(), this.forcedChoiceWidth);
					gameObject4.GetComponent<ChoiceStatManager>().KNBNNEKBJAM();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.LJPFELOIIPA(num3)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().AKPOHMDKCHP(this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)]].HOJDOEDDIBD());
							try
							{
								if (this.IMPAHLIGELE.JGEDOIDOPLA.NGNDOALIKAK.Contains("wshcds"))
								{
									this.NGGBBCDPMJH.SetActive(true);
								}
							}
							catch (Exception aklgbjkdomm4)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
							}
						}
						goto IL_C93;
					}
					catch (Exception aklgbjkdomm5)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
						goto IL_C93;
					}
					goto IL_A06;
				}
				goto IL_A06;
				IL_C93:
				gameObject4.GetComponent<RectTransform>().anchoredPosition += new Vector2(782f, (float)(this.choiceOffset * num2));
				Button component = gameObject4.GetComponent<Button>();
				if (this.DDGLJHFNBGK(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.DDGLJHFNBGK(num3) == 1)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.DDGLJHFNBGK(num3) == 7)
				{
					component.onClick.AddListener(new UnityAction(this.LFCGEIGDHOG));
				}
				else if (this.DDGLJHFNBGK(num3) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.EPIHFCPOLJJ));
				}
				else if (this.DDGLJHFNBGK(num3) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.LJPFELOIIPA(num3) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.JNFEIONBJHI));
				}
				this.AKFKCKHPIOA.Add(gameObject4);
				num2 += 0;
				num3 += 0;
				continue;
				IL_A06:
				if (num4 == 1)
				{
					gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject4.transform.SetParent(this.choicePivot.transform, true);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ, this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ))
					{
						gameObject4.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], 1, this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.BIHCGMMCFOG(this.HDBBHHBOJIN(num3), LiveEventsManager.OOGPALHPNGM().LiveEventActive((EGMCEPOABBF)7, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().OGNEMDIEHFO("ok");
						}
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)], this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.NFMCFKKPOMA(this.HDBBHHBOJIN(num3), LiveEventsManager.GIPAKOPBBEO().HLCKJEIFAFM(EGMCEPOABBF.liveEventFreeTea, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					gameObject4.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KAJNELPPCIJ[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ));
					goto IL_C93;
				}
				gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject4.transform.SetParent(this.choicePivot.transform, false);
				gameObject4.GetComponent<ChoiceStandardManager>().Initialize(this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], this.forcedChoiceWidth);
				goto IL_C93;
			}
		}
		if (this.AKFKCKHPIOA.Count > 0)
		{
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		if (this.version >= 0 && this.AKFKCKHPIOA.Count > 3)
		{
			try
			{
				this.EKAJHPJJIOK = Math.Abs(this.choiceOffset * (this.AKFKCKHPIOA.Count - 0));
				RectTransform component2 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component2)
				{
					component2.ACBKFBBCNNC(component2.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component3 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component3)
				{
					component3.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component4 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component4)
				{
					component4.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				goto IL_F5D;
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm6);
				goto IL_F5D;
			}
		}
		if (this.version >= 3 && this.AKFKCKHPIOA.Count == 1)
		{
			try
			{
				this.EKAJHPJJIOK = this.choiceOffset / 1;
				RectTransform component5 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component5)
				{
					component5.ACBKFBBCNNC(component5.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component6 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component6)
				{
					component6.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component7 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component7)
				{
					component7.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
		IL_F5D:
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x0011A144 File Offset: 0x00118344
	private void DKHPGMJOENF()
	{
		this.slidingPanelButtonHide1.interactable = true;
		this.slidingPanelButtonHide2.interactable = true;
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x0011A160 File Offset: 0x00118360
	public bool ONCMEAFFFIB(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		bool result;
		try
		{
			result = this.OPALODICAJK(JIKFCLOHJNN, BAOKJBJIFBH, OAGPAAMJOID, IFPEJMLKMPB);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
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
			throw;
		}
		return result;
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x0011A1F0 File Offset: 0x001183F0
	private bool ILJFKBLBGHP(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.IIFKDKNJJDO.JNMIPNKPAHC(true);
		this.IIFKDKNJJDO.CHOGMCMNIKA(true);
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.MOIAENHBGDJ())
		{
			return false;
		}
		if (this.version >= 6 && this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0 && this.IMPAHLIGELE.JGEDOIDOPLA != null)
		{
			try
			{
				if (this.IMPAHLIGELE.JGEDOIDOPLA.KDBAFJMAFOD(this.IMPAHLIGELE.COEFNFJMBDG.Count))
				{
					this.IMPAHLIGELE.JGEDOIDOPLA.CNDHJHEGLIB(BAOKJBJIFBH.NCAMFPGMCIG.AGKMGGPILIA());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL.Count; i += 0)
				{
					if (this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[i].FDGKLHMFDMK() == HKCCMACFNEO.premium)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 0; k < 7; k += 0)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 1;
						if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
						{
							if (l < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[l] > 0)
							{
								num = 1;
							}
							else if (l < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[l] > 1)
							{
								num = 6;
							}
						}
						if ((k == 0 && num == 0) || (k != 0 && num != 1))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JGEDOIDOPLA.PFLJLFGCIFB();
		try
		{
			sourceText = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.JGEDOIDOPLA.CIEBIPGGLFD());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, false);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == (JJBCFINBFKL.BDBLHBOFMII)6)
		{
			this.storyItemPivot.SetActive(false);
			string khjmandedma = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			if (BAOKJBJIFBH.NCAMFPGMCIG.HKJMEKPOPJF() >= 1)
			{
				khjmandedma = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyItemPrefab);
			gameObject.transform.SetParent(this.storyItemPivot.transform, true);
			this.OKLPOLPIJNF = gameObject.GetComponent<StoryItemManager>();
			this.OKLPOLPIJNF.AJNNDKIIFDN(GKJPOGNFKNK.HNPOJCILEHP(khjmandedma), true);
			this.OKLPOLPIJNF.GetComponent<RectTransform>().AHLJBONHHKL(1, 3);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			string text = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			try
			{
				text = BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
				if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "[LoadingEnv] direct cache files of "))
				{
					for (int m = 1; m < this.ODNCKIKLFCM.Count; m++)
					{
						if (null != this.ODNCKIKLFCM[m])
						{
							for (int n = 1; n < this.ODNCKIKLFCM[m].mappings.Count; n++)
							{
								if (this.ODNCKIKLFCM[m].mappings[n].Equals(text))
								{
									DPGJIJGOCIC.PJCLICBPPDA("Tracking status received: {0}" + text + "%)" + this.ODNCKIKLFCM[m].id);
									text = this.ODNCKIKLFCM[m].id;
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
			}
			this.DAHDOMMANDF = this.AELDLODLLPI(false);
			if (this.DAHDOMMANDF != null)
			{
				this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleLeft);
				this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, false);
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
				gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				gameObject2.transform.SetParent(this.characterPivot.transform, true);
				this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.right, false);
			}
			this.OIDNMECILMM.MAHHJBLOJFA(GFEJBOAKPMP.animationChoiceMetaAppearFromLeft);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			this.LLEOBLHCNJA = this.KJMPHNKPENL(true);
			if (this.LLEOBLHCNJA != null)
			{
				this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
				this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
				this.GOAEECPPHIB.AGBPEFEDKNG(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, this.LLEOBLHCNJA.AJDMCHIOJAK);
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
				gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				gameObject3.transform.SetParent(this.characterPivot.transform, true);
				this.GOAEECPPHIB = gameObject3.GetComponent<PlayerCharacterManager>();
				this.GOAEECPPHIB.OEOCAMNCGJJ(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
			}
			this.GOAEECPPHIB.NOHNKCNODDN(BKBCKPMDFOD.animationStoryAppearFromRight);
		}
		else
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF != (JJBCFINBFKL.BDBLHBOFMII)8)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnStoryInterfaceHeaderHideComplete" + this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF.ToString());
				return false;
			}
			this.storyItemPivot.SetActive(false);
		}
		int num2 = 1;
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			int num3 = 1;
			while (num3 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject4 = null;
				int num4 = 0;
				if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
				{
					if (this.LJPFELOIIPA(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.LJPFELOIIPA(num3)] > 0)
					{
						num4 = 1;
					}
					else if (this.LJPFELOIIPA(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.HDBBHHBOJIN(num3)] > 0)
					{
						num4 = 4;
					}
				}
				if (num4 == 0)
				{
					switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject4.transform.SetParent(this.choicePivot.transform, false);
					gameObject4.GetComponent<ChoiceStatManager>().KMDKBPNAKOG(this.IMPAHLIGELE.COEFNFJMBDG[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.DDGLJHFNBGK(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)]].MOBKGNBCIJF(), this.forcedChoiceWidth);
					gameObject4.GetComponent<ChoiceStatManager>().OGHBHHMJHAL();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().MCOMCHOLOOO(this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)]].KGEGKPHEMOJ());
							try
							{
								if (this.IMPAHLIGELE.JGEDOIDOPLA.NGNDOALIKAK.Contains("yes"))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm4)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
							}
						}
						goto IL_C93;
					}
					catch (Exception aklgbjkdomm5)
					{
						DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm5);
						goto IL_C93;
					}
					goto IL_A06;
				}
				goto IL_A06;
				IL_C93:
				gameObject4.GetComponent<RectTransform>().anchoredPosition += new Vector2(845f, (float)(this.choiceOffset * num2));
				Button component = gameObject4.GetComponent<Button>();
				if (this.DDGLJHFNBGK(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.DDGLJHFNBGK(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.DDGLJHFNBGK(num3) == 8)
				{
					component.onClick.AddListener(new UnityAction(this.FFDGLHACKON));
				}
				else if (this.DDGLJHFNBGK(num3) == 4)
				{
					component.onClick.AddListener(new UnityAction(this.EPIHFCPOLJJ));
				}
				else if (this.LJPFELOIIPA(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(num3) == 2)
				{
					component.onClick.AddListener(new UnityAction(this.COLPDMCKNLP));
				}
				this.AKFKCKHPIOA.Add(gameObject4);
				num2 += 0;
				num3++;
				continue;
				IL_A06:
				if (num4 == 1)
				{
					gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject4.transform.SetParent(this.choicePivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ, this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ))
					{
						gameObject4.GetComponent<ChoicePremiumManager>().GBFEDHPAIBH(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], 0, this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.GEBBHIGLIND(this.HDBBHHBOJIN(num3), LiveEventsManager.OBOOKJPGBJN().HLCKJEIFAFM(EGMCEPOABBF.liveEventMessage, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, true);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("var");
						}
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)], this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.JBEBPDBMKMP(this.DDGLJHFNBGK(num3), LiveEventsManager.OBOOKJPGBJN().PKHPPBPKOEE((EGMCEPOABBF)8, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					gameObject4.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KAJNELPPCIJ[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ));
					goto IL_C93;
				}
				gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject4.transform.SetParent(this.choicePivot.transform, false);
				gameObject4.GetComponent<ChoiceStandardManager>().HBBFAAOICDH(this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.forcedChoiceWidth);
				goto IL_C93;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		if (this.version >= 5 && this.AKFKCKHPIOA.Count > 3)
		{
			try
			{
				this.EKAJHPJJIOK = Math.Abs(this.choiceOffset * (this.AKFKCKHPIOA.Count - 3));
				RectTransform component2 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component2)
				{
					component2.ACBKFBBCNNC(component2.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component3 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component3)
				{
					component3.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component4 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component4)
				{
					component4.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				goto IL_F5D;
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm6);
				goto IL_F5D;
			}
		}
		if (this.version >= 2 && this.AKFKCKHPIOA.Count == 0)
		{
			try
			{
				this.EKAJHPJJIOK = this.choiceOffset / 4;
				RectTransform component5 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component5)
				{
					component5.ACBKFBBCNNC(component5.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component6 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component6)
				{
					component6.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component7 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component7)
				{
					component7.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm7);
			}
		}
		IL_F5D:
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x0011B214 File Offset: 0x00119414
	private void BENGHKGCLOG()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(4);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x0011B236 File Offset: 0x00119436
	private void COLPDMCKNLP()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(0);
		AOBJLALDBAA.DBLAIDPICIG().KGIKHEDLPND("spectrumovr_1", 268f);
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x0011B258 File Offset: 0x00119458
	private void APLBAENGMJH()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x0011B2AF File Offset: 0x001194AF
	public void BOOFIPJDGEE()
	{
		AOBJLALDBAA.AGANFKKBPFO().DCGCFPHHDDG("ok", 198f);
		this.OPLDMEEFKDO(false);
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x0011B2CC File Offset: 0x001194CC
	private void OPBNOGLBNDK()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x0011B378 File Offset: 0x00119578
	private bool CBFFOKFICJP(BAAFDFAEKIH JIKFCLOHJNN, PLFDAJJHMKO BAOKJBJIFBH, LDLLJFOJCDF[] OAGPAAMJOID, List<AssetStoryNpc> IFPEJMLKMPB)
	{
		this.LMKDNPOKOBF = BAOKJBJIFBH;
		this.ODNCKIKLFCM = IFPEJMLKMPB;
		this.IIFKDKNJJDO.HAEEBFCHLIK(false);
		this.IIFKDKNJJDO.KBMPFNHNADD(true);
		this.OPLDMEEFKDO(true);
		this.IMPAHLIGELE = JIKFCLOHJNN;
		if (!this.MOIAENHBGDJ())
		{
			return false;
		}
		if (this.version >= 5 && this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1 && this.IMPAHLIGELE.JGEDOIDOPLA != null)
		{
			try
			{
				if (this.IMPAHLIGELE.JGEDOIDOPLA.OLHFONJGNPM(this.IMPAHLIGELE.COEFNFJMBDG.Count))
				{
					this.IMPAHLIGELE.JGEDOIDOPLA.AONKKCPFLPF(BAOKJBJIFBH.NCAMFPGMCIG.MLCAAHPBNGP());
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 0)
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
			{
				for (int i = 1; i < this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL.Count; i++)
				{
					if (this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[i].KIFAPHKNJBF() == HKCCMACFNEO.premium)
					{
						for (int j = 0; j < this.IMPAHLIGELE.COEFNFJMBDG.Count; j++)
						{
							this.HNGBMIJHPLE.Add(j);
						}
						break;
					}
				}
			}
			if (this.HNGBMIJHPLE.Count == 0)
			{
				for (int k = 1; k < 1; k++)
				{
					for (int l = 0; l < this.IMPAHLIGELE.COEFNFJMBDG.Count; l += 0)
					{
						int num = 1;
						if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
						{
							if (l < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[l] > 1)
							{
								num = 0;
							}
							else if (l < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[l] > 0)
							{
								num = 8;
							}
						}
						if ((k == 0 && num == 1) || (k != 0 && num != 0))
						{
							this.HNGBMIJHPLE.Add(l);
						}
					}
				}
			}
		}
		string sourceText = this.IMPAHLIGELE.JGEDOIDOPLA.BEDLOHCEMAH();
		try
		{
			sourceText = ONEHEBIHPFB.PLHGCKCFLEN(this.IMPAHLIGELE.JGEDOIDOPLA.HMBHMHHBNDK());
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		this.choiceTitle.SetText(sourceText, true);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == (JJBCFINBFKL.BDBLHBOFMII)4)
		{
			this.storyItemPivot.SetActive(true);
			string khjmandedma = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			if (BAOKJBJIFBH.NCAMFPGMCIG.HKJMEKPOPJF() >= 3)
			{
				khjmandedma = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.storyItemPrefab);
			gameObject.transform.SetParent(this.storyItemPivot.transform, false);
			this.OKLPOLPIJNF = gameObject.GetComponent<StoryItemManager>();
			this.OKLPOLPIJNF.HHBPGAMBAAE(GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma), true);
			this.OKLPOLPIJNF.GetComponent<RectTransform>().AHLJBONHHKL(1, 45);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(false);
			string text = this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN;
			try
			{
				text = BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(this.IMPAHLIGELE.JGEDOIDOPLA.COOOGACBAKN);
				if (this.ODNCKIKLFCM != null && null == GKJPOGNFKNK.IAJMHBFGKBA(text, "usyncoll2"))
				{
					for (int m = 1; m < this.ODNCKIKLFCM.Count; m += 0)
					{
						if (null != this.ODNCKIKLFCM[m])
						{
							for (int n = 0; n < this.ODNCKIKLFCM[m].mappings.Count; n += 0)
							{
								if (this.ODNCKIKLFCM[m].mappings[n].Equals(text))
								{
									DPGJIJGOCIC.ADFCDFHBDAF("y" + text + "<size=80%><i><b>[" + this.ODNCKIKLFCM[m].id);
									text = this.ODNCKIKLFCM[m].id;
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm3)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
			}
			this.DAHDOMMANDF = this.OELALBBMILL(true);
			if (this.DAHDOMMANDF != null)
			{
				this.DAHDOMMANDF.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
				this.OIDNMECILMM = this.DAHDOMMANDF.OIDNMECILMM;
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.AKHCBFGADPJ(), OFLIHLDBDEB.center, true);
			}
			else
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.nonPlayerCharacterPrefab);
				gameObject2.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
				gameObject2.transform.SetParent(this.characterPivot.transform, false);
				this.OIDNMECILMM = gameObject2.GetComponent<NonPlayerCharacterManager>();
				this.OIDNMECILMM.Initialize(text, BAOKJBJIFBH.NCAMFPGMCIG.DLCABLNFEIO(), OFLIHLDBDEB.center, true);
			}
			this.OIDNMECILMM.MAHHJBLOJFA((GFEJBOAKPMP)7);
		}
		else if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.player)
		{
			this.storyItemPivot.SetActive(true);
			this.LLEOBLHCNJA = this.OELALBBMILL(false);
			if (this.LLEOBLHCNJA != null)
			{
				this.LLEOBLHCNJA.JAGHCEBFABP.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
				this.GOAEECPPHIB = this.LLEOBLHCNJA.GOAEECPPHIB;
				this.GOAEECPPHIB.InitializeFromSaveData(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.left, this.LLEOBLHCNJA.AJDMCHIOJAK);
			}
			else
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(AssetsManager.EHBBFMCILPC.playerCharacterPrefab);
				gameObject3.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopLeft);
				gameObject3.transform.SetParent(this.characterPivot.transform, false);
				this.GOAEECPPHIB = gameObject3.GetComponent<PlayerCharacterManager>();
				this.GOAEECPPHIB.FMPHMPABPKB(BAOKJBJIFBH.NCAMFPGMCIG.OHODCBKFNGJ(), EBFHKCOGJLB.center, null);
			}
			this.GOAEECPPHIB.NOHNKCNODDN(BKBCKPMDFOD.animationStoryAppearFromLeft);
		}
		else
		{
			if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF != JJBCFINBFKL.BDBLHBOFMII.player)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("p" + this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF.ToString());
				return false;
			}
			this.storyItemPivot.SetActive(false);
		}
		int num2 = 1;
		if (this.IMPAHLIGELE.COEFNFJMBDG != null && this.IMPAHLIGELE.COEFNFJMBDG.Count > 1)
		{
			int num3 = 0;
			while (num3 < this.IMPAHLIGELE.COEFNFJMBDG.Count)
			{
				GameObject gameObject4 = null;
				int num4 = 1;
				if (this.IMPAHLIGELE.JGEDOIDOPLA != null)
				{
					if (this.DDGLJHFNBGK(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG.Count && this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)] > 1)
					{
						num4 = 0;
					}
					else if (this.HDBBHHBOJIN(num3) < this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA.Count && this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.DDGLJHFNBGK(num3)] > 0)
					{
						num4 = 8;
					}
				}
				if (num4 == 4)
				{
					switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)])
					{
					case CHEEGEJNIDB.stat0:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat0Prefab);
						break;
					case CHEEGEJNIDB.stat1:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat1Prefab);
						break;
					case CHEEGEJNIDB.stat2:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat2Prefab);
						break;
					case CHEEGEJNIDB.stat3:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat3Prefab);
						break;
					case CHEEGEJNIDB.stat4:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat4Prefab);
						break;
					case CHEEGEJNIDB.stat5:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat5Prefab);
						break;
					case CHEEGEJNIDB.stat6:
						gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStat6Prefab);
						break;
					}
					gameObject4.transform.SetParent(this.choicePivot.transform, true);
					gameObject4.GetComponent<ChoiceStatManager>().KMDKBPNAKOG(this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.ENJDGEOFPAA[this.LJPFELOIIPA(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)]].BFMPOACOBPN(), this.forcedChoiceWidth);
					gameObject4.GetComponent<ChoiceStatManager>().ODEHJEOBANM();
					try
					{
						if (null == this.NGGBBCDPMJH)
						{
							switch (this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.HDBBHHBOJIN(num3)])
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
							this.NGGBBCDPMJH.GetComponent<StatPointInfoManager>().LAFCNAHCIFJ(this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.DDGLJHFNBGK(num3)], OAGPAAMJOID[(int)this.IMPAHLIGELE.JGEDOIDOPLA.ADHIIAONMDJ[this.LJPFELOIIPA(num3)]].NPEOEAFOPJP());
							try
							{
								if (this.IMPAHLIGELE.JGEDOIDOPLA.NGNDOALIKAK.Contains("OnSystemBackButton"))
								{
									this.NGGBBCDPMJH.SetActive(false);
								}
							}
							catch (Exception aklgbjkdomm4)
							{
								DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
							}
						}
						goto IL_C93;
					}
					catch (Exception aklgbjkdomm5)
					{
						DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
						goto IL_C93;
					}
					goto IL_A06;
				}
				goto IL_A06;
				IL_C93:
				gameObject4.GetComponent<RectTransform>().anchoredPosition += new Vector2(1570f, (float)(this.choiceOffset * num2));
				Button component = gameObject4.GetComponent<Button>();
				if (this.LJPFELOIIPA(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.GMPJMMMIGLO));
				}
				else if (this.LJPFELOIIPA(num3) == 0)
				{
					component.onClick.AddListener(new UnityAction(this.OLGOAJEBMIK));
				}
				else if (this.DDGLJHFNBGK(num3) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.LFCGEIGDHOG));
				}
				else if (this.LJPFELOIIPA(num3) == 3)
				{
					component.onClick.AddListener(new UnityAction(this.BOGHFJKGCNK));
				}
				else if (this.LJPFELOIIPA(num3) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.BENGHKGCLOG));
				}
				else if (this.HDBBHHBOJIN(num3) == 5)
				{
					component.onClick.AddListener(new UnityAction(this.KEALPELOGOF));
				}
				this.AKFKCKHPIOA.Add(gameObject4);
				num2 += 0;
				num3 += 0;
				continue;
				IL_A06:
				if (num4 == 0)
				{
					gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choicePremiumPrefab);
					gameObject4.transform.SetParent(this.choicePivot.transform, false);
					if (SceneStoryManager.PremiumChoicePurchased(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ, this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ))
					{
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.DDGLJHFNBGK(num3)], 0, this.forcedChoiceWidth, true, this.IMPAHLIGELE.JGEDOIDOPLA.CLHADGEPGFL(this.LJPFELOIIPA(num3), LiveEventsManager.PIPOLIAKGDM().OEHDOMDPHDN(EGMCEPOABBF.liveEventFreeAvatar, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					else
					{
						if (null == this.LOJHEKCOFME)
						{
							this.LOJHEKCOFME = UnityEngine.Object.Instantiate<GameObject>(this.premiumInfoPrefab);
							this.LOJHEKCOFME.transform.SetParent(this.currencyPivot.transform, false);
							this.LOJHEKCOFME.GetComponent<StoryCurrencyInfoManager>().Initialize("XXX");
						}
						gameObject4.GetComponent<ChoicePremiumManager>().Initialize(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.IPALJDCNBBG[this.HDBBHHBOJIN(num3)], this.forcedChoiceWidth, false, this.IMPAHLIGELE.JGEDOIDOPLA.OOECAIMDCHF(this.DDGLJHFNBGK(num3), LiveEventsManager.NMGMNAKLLMI().PKHPPBPKOEE(EGMCEPOABBF.liveEventFreeDiamonds, -1, -1)), this.IMPAHLIGELE.JGEDOIDOPLA.BGIOGOACCBJ);
					}
					gameObject4.GetComponent<ChoicePremiumManager>().SwitchCost(SceneStoryManager.QualifiesAsAdBasedChoice(this.IMPAHLIGELE.JGEDOIDOPLA.MKPMEKKGEIL[this.DDGLJHFNBGK(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KAJNELPPCIJ[this.HDBBHHBOJIN(num3)], this.IMPAHLIGELE.JGEDOIDOPLA.KMFABKNKFAJ));
					goto IL_C93;
				}
				gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.choiceStandardPrefab);
				gameObject4.transform.SetParent(this.choicePivot.transform, true);
				gameObject4.GetComponent<ChoiceStandardManager>().DOFLEONDCMI(this.IMPAHLIGELE.COEFNFJMBDG[this.LJPFELOIIPA(num3)], this.forcedChoiceWidth);
				goto IL_C93;
			}
		}
		if (this.AKFKCKHPIOA.Count > 1)
		{
			base.StartCoroutine(this.NEKBMPGBLCJ());
		}
		if (this.version >= 5 && this.AKFKCKHPIOA.Count > 5)
		{
			try
			{
				this.EKAJHPJJIOK = Math.Abs(this.choiceOffset * (this.AKFKCKHPIOA.Count - 1));
				RectTransform component2 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component2)
				{
					component2.ACBKFBBCNNC(component2.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component3 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component3)
				{
					component3.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				RectTransform component4 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component4)
				{
					component4.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
				goto IL_F5D;
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
				goto IL_F5D;
			}
		}
		if (this.version >= 7 && this.AKFKCKHPIOA.Count == 0)
		{
			try
			{
				this.EKAJHPJJIOK = this.choiceOffset / 0;
				RectTransform component5 = this.slidingPanel.GetComponent<RectTransform>();
				if (null != component5)
				{
					component5.ACBKFBBCNNC(component5.HILHDGDPANG() + (float)this.EKAJHPJJIOK);
				}
				RectTransform component6 = this.choicePivot.GetComponent<RectTransform>();
				if (null != component6)
				{
					component6.AHLJBONHHKL(0, this.EKAJHPJJIOK);
				}
				RectTransform component7 = this.currencyPivot.GetComponent<RectTransform>();
				if (null != component7)
				{
					component7.AHLJBONHHKL(1, this.EKAJHPJJIOK);
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
		IL_F5D:
		return null != this.LOJHEKCOFME;
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x0011C39C File Offset: 0x0011A59C
	private void PDFPAHMGKDC()
	{
		this.backPanelButton.interactable = false;
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x0011C3AA File Offset: 0x0011A5AA
	private void BLGILKBHCGP()
	{
		this.slidingPanelButtonHide1.interactable = false;
		this.slidingPanelButtonHide2.interactable = true;
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x0011C3C4 File Offset: 0x0011A5C4
	private void KEALPELOGOF()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(8);
		AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC("Front environment has been destroyed according to on demand data:", 587f);
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x0011C3E8 File Offset: 0x0011A5E8
	private void Awake()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x0011C43F File Offset: 0x0011A63F
	private IEnumerator IJNDFPIIIFD(float BICHMDEIFKI)
	{
		this.animationCanvasGroupBackPanel.gameObject.SetActive(false);
		this.OPLDMEEFKDO(false);
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.item)
		{
			this.IIFKDKNJJDO.SetDirection(true);
			this.IIFKDKNJJDO.PlayAnimation(false);
		}
		this.DCKJHLJKGOL.SetDirection(true);
		this.DCKJHLJKGOL.PlayAnimation();
		yield break;
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x0011C455 File Offset: 0x0011A655
	private bool LOJGGNLALGF()
	{
		if (this.IMPAHLIGELE == null || this.IMPAHLIGELE.JGEDOIDOPLA == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("acliffbw20");
			return false;
		}
		return false;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x0011C479 File Offset: 0x0011A679
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnStoryChoiceClickConfimed", new UnityAction(this.ALKBENHJEPC));
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x0011C43F File Offset: 0x0011A63F
	private IEnumerator AJKLIACJNAD(float BICHMDEIFKI)
	{
		this.animationCanvasGroupBackPanel.gameObject.SetActive(false);
		this.OPLDMEEFKDO(false);
		yield return new WaitForSeconds(BICHMDEIFKI);
		if (this.IMPAHLIGELE.JGEDOIDOPLA.GAOKFGHCIAF == JJBCFINBFKL.BDBLHBOFMII.item)
		{
			this.IIFKDKNJJDO.SetDirection(true);
			this.IIFKDKNJJDO.PlayAnimation(false);
		}
		this.DCKJHLJKGOL.SetDirection(true);
		this.DCKJHLJKGOL.PlayAnimation();
		yield break;
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x00118DC7 File Offset: 0x00116FC7
	private void DDNMMPIJLNK()
	{
		this.backPanelButton.interactable = true;
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x0011C498 File Offset: 0x0011A698
	private CharacterRenderTexturePool.AHLNEABNMOA AELDLODLLPI(bool EJLNKLNPBPJ)
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

	// Token: 0x0600268F RID: 9871 RVA: 0x0011C50C File Offset: 0x0011A70C
	private void IAKKINHMFNA()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x0011C563 File Offset: 0x0011A763
	public void JPNEFEHNCGE()
	{
		this.OPLDMEEFKDO(false);
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x0011C56C File Offset: 0x0011A76C
	private bool MOIAENHBGDJ()
	{
		if (this.IMPAHLIGELE == null || this.IMPAHLIGELE.JGEDOIDOPLA == null)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("htme");
			return false;
		}
		return false;
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x0011C590 File Offset: 0x0011A790
	private void KMNAIGHHKEO(bool BJEENNHMKFA)
	{
		try
		{
			CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa = null;
			CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa2 = null;
			if (this.LLEOBLHCNJA != null && null != this.LLEOBLHCNJA.AJDMCHIOJAK && this.LLEOBLHCNJA.AJDMCHIOJAK.alpha > 0.99f)
			{
				ahlneabnmoa = this.LLEOBLHCNJA;
			}
			if (this.DAHDOMMANDF != null && null != this.DAHDOMMANDF.AJDMCHIOJAK && this.DAHDOMMANDF.AJDMCHIOJAK.alpha > 0.99f)
			{
				ahlneabnmoa2 = this.DAHDOMMANDF;
			}
			if (ahlneabnmoa == null || ahlneabnmoa2 == null)
			{
				CharacterRenderTexturePool.AHLNEABNMOA ahlneabnmoa3 = ahlneabnmoa;
				if (ahlneabnmoa3 == null)
				{
					ahlneabnmoa3 = ahlneabnmoa2;
				}
				if (ahlneabnmoa3 != null)
				{
					AssetCustomEffects assetCustomEffects = DHGFCJGJFOB.ONMBOOEBFIB();
					if (null != assetCustomEffects)
					{
						DHGFCJGJFOB.IDNJIDPNFAE(ahlneabnmoa3, assetCustomEffects, BJEENNHMKFA);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x0011C658 File Offset: 0x0011A858
	private void FFDGLHACKON()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(2);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x0011C67A File Offset: 0x0011A87A
	private void BOGHFJKGCNK()
	{
		this.IMPAHLIGELE.IABNDHFJHAF(3);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryChoiceClick", 0f);
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x0011906C File Offset: 0x0011726C
	private int LJPFELOIIPA(int MEFKFOHCOHK)
	{
		return this.HNGBMIJHPLE[MEFKFOHCOHK];
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x0011C69C File Offset: 0x0011A89C
	private void OnDestroy()
	{
		this.FOPNADOFECH.DOKill(false);
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
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i++)
		{
			this.AKFKCKHPIOA[i].GetComponent<Button>().onClick.RemoveAllListeners();
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOKill(false);
			UnityEngine.Object.Destroy(this.AKFKCKHPIOA[i]);
		}
		this.AKFKCKHPIOA.Clear();
		this.ODNCKIKLFCM = null;
		if (null != this.OKLPOLPIJNF)
		{
			UnityEngine.Object.Destroy(this.OKLPOLPIJNF);
			this.OKLPOLPIJNF = null;
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
		if (null != this.LOJHEKCOFME)
		{
			UnityEngine.Object.Destroy(this.LOJHEKCOFME);
		}
		if (null != this.NGGBBCDPMJH)
		{
			UnityEngine.Object.Destroy(this.NGGBBCDPMJH);
		}
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x0011C563 File Offset: 0x0011A763
	public void IOBAPODGKCE()
	{
		this.OPLDMEEFKDO(false);
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x0011C810 File Offset: 0x0011AA10
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

	// Token: 0x06002699 RID: 9881 RVA: 0x0011C884 File Offset: 0x0011AA84
	private IEnumerator NEKBMPGBLCJ()
	{
		for (int j = 0; j < this.AKFKCKHPIOA.Count; j++)
		{
			this.AKFKCKHPIOA[j].GetComponent<CanvasGroup>().alpha = 0f;
		}
		int num;
		for (int i = 0; i < this.AKFKCKHPIOA.Count; i = num + 1)
		{
			yield return new WaitForSeconds(0.35f);
			this.AKFKCKHPIOA[i].GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
			num = i;
		}
		yield break;
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x0011C894 File Offset: 0x0011AA94
	private void KBIIMONICOB()
	{
		this.DCKJHLJKGOL = this.storyItemPivot.GetComponent<AnimationTranslation>();
		this.IIFKDKNJJDO = base.GetComponent<AnimationCanvasGroupAlpha>();
		this.FOPNADOFECH = this.slidingPanel.GetComponent<RectTransform>();
		this.OIPMEGJLIDC = this.FOPNADOFECH.anchoredPosition;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x0011C8EC File Offset: 0x0011AAEC
	private CharacterRenderTexturePool.AHLNEABNMOA KJMPHNKPENL(bool EJLNKLNPBPJ)
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

	// Token: 0x04000BFA RID: 3066
	public int version;

	// Token: 0x04000BFB RID: 3067
	public int slidingPanelTranslationAmountY = 412;

	// Token: 0x04000BFC RID: 3068
	public const float buttonFadeInTime = 0.5f;

	// Token: 0x04000BFD RID: 3069
	public const float buttonWaitInLine = 0.35f;

	// Token: 0x04000BFE RID: 3070
	public const float panelAnimationTime = 0.5f;

	// Token: 0x04000BFF RID: 3071
	public int choiceOffset = -130;

	// Token: 0x04000C00 RID: 3072
	public int forcedChoiceWidth = -1;

	// Token: 0x04000C01 RID: 3073
	public TextMeshProUGUI choiceTitle;

	// Token: 0x04000C02 RID: 3074
	public GameObject choicePivot;

	// Token: 0x04000C03 RID: 3075
	public GameObject choicePremiumPrefab;

	// Token: 0x04000C04 RID: 3076
	public GameObject choiceStandardPrefab;

	// Token: 0x04000C05 RID: 3077
	public GameObject choiceStat0Prefab;

	// Token: 0x04000C06 RID: 3078
	public GameObject choiceStat1Prefab;

	// Token: 0x04000C07 RID: 3079
	public GameObject choiceStat2Prefab;

	// Token: 0x04000C08 RID: 3080
	public GameObject choiceStat3Prefab;

	// Token: 0x04000C09 RID: 3081
	public GameObject choiceStat4Prefab;

	// Token: 0x04000C0A RID: 3082
	public GameObject choiceStat5Prefab;

	// Token: 0x04000C0B RID: 3083
	public GameObject choiceStat6Prefab;

	// Token: 0x04000C0C RID: 3084
	public GameObject stat0InfoPrefab;

	// Token: 0x04000C0D RID: 3085
	public GameObject stat1InfoPrefab;

	// Token: 0x04000C0E RID: 3086
	public GameObject stat2InfoPrefab;

	// Token: 0x04000C0F RID: 3087
	public GameObject stat3InfoPrefab;

	// Token: 0x04000C10 RID: 3088
	public GameObject stat4InfoPrefab;

	// Token: 0x04000C11 RID: 3089
	public GameObject stat5InfoPrefab;

	// Token: 0x04000C12 RID: 3090
	public GameObject stat6InfoPrefab;

	// Token: 0x04000C13 RID: 3091
	public GameObject storyItemPivot;

	// Token: 0x04000C14 RID: 3092
	public GameObject storyItemPrefab;

	// Token: 0x04000C15 RID: 3093
	public GameObject characterPivot;

	// Token: 0x04000C16 RID: 3094
	public GameObject premiumInfoPrefab;

	// Token: 0x04000C17 RID: 3095
	public GameObject currencyPivot;

	// Token: 0x04000C18 RID: 3096
	public GameObject slidingPanel;

	// Token: 0x04000C19 RID: 3097
	public Button slidingPanelButtonHide1;

	// Token: 0x04000C1A RID: 3098
	public Button slidingPanelButtonHide2;

	// Token: 0x04000C1B RID: 3099
	public AnimationCanvasGroupAlpha animationCanvasGroupChoicePanel;

	// Token: 0x04000C1C RID: 3100
	public AnimationCanvasGroupAlpha animationCanvasGroupCurrencyPanel;

	// Token: 0x04000C1D RID: 3101
	public AnimationCanvasGroupAlpha animationCanvasGroupBackPanel;

	// Token: 0x04000C1E RID: 3102
	public AnimationTranslation animationTranslationBackPanel;

	// Token: 0x04000C1F RID: 3103
	public Button backPanelButton;

	// Token: 0x04000C20 RID: 3104
	public ParticleSystem premiumParticles;

	// Token: 0x04000C21 RID: 3105
	public ParticleSystem standardParticles;

	// Token: 0x04000C22 RID: 3106
	private GameObject LOJHEKCOFME;

	// Token: 0x04000C23 RID: 3107
	private GameObject NGGBBCDPMJH;

	// Token: 0x04000C24 RID: 3108
	private BAAFDFAEKIH IMPAHLIGELE;

	// Token: 0x04000C25 RID: 3109
	private List<GameObject> AKFKCKHPIOA = new List<GameObject>();

	// Token: 0x04000C26 RID: 3110
	private StoryItemManager OKLPOLPIJNF;

	// Token: 0x04000C27 RID: 3111
	private NonPlayerCharacterManager OIDNMECILMM;

	// Token: 0x04000C28 RID: 3112
	private PlayerCharacterManager GOAEECPPHIB;

	// Token: 0x04000C29 RID: 3113
	private CharacterRenderTexturePool.AHLNEABNMOA LLEOBLHCNJA;

	// Token: 0x04000C2A RID: 3114
	private CharacterRenderTexturePool.AHLNEABNMOA DAHDOMMANDF;

	// Token: 0x04000C2B RID: 3115
	private CharacterRenderTexturePool EBHJLLIHIFE;

	// Token: 0x04000C2C RID: 3116
	private Vector2 OIPMEGJLIDC;

	// Token: 0x04000C2D RID: 3117
	private RectTransform FOPNADOFECH;

	// Token: 0x04000C2E RID: 3118
	private const int IAAMDEAAKCN = 3;

	// Token: 0x04000C2F RID: 3119
	private AnimationCanvasGroupAlpha IIFKDKNJJDO;

	// Token: 0x04000C30 RID: 3120
	private AnimationTranslation DCKJHLJKGOL;

	// Token: 0x04000C31 RID: 3121
	private List<int> HNGBMIJHPLE = new List<int>();

	// Token: 0x04000C32 RID: 3122
	private List<AssetStoryNpc> ODNCKIKLFCM = new List<AssetStoryNpc>();

	// Token: 0x04000C33 RID: 3123
	private int EKAJHPJJIOK;

	// Token: 0x04000C34 RID: 3124
	private PLFDAJJHMKO LMKDNPOKOBF;
}
