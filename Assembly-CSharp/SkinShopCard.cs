using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003C RID: 60
public class SkinShopCard : MonoBehaviour
{
	// Token: 0x0600085E RID: 2142 RVA: 0x00038158 File Offset: 0x00036358
	private void GHJLDHCPJHG(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 1878f) ? this.infoRowsFourRowsScale : 1478f;
		this.infoRowsRect.localScale = new Vector3(num, num, 176f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 536f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 1791f) + ((null != component3) ? component3.spacing : 1732f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00038295 File Offset: 0x00036495
	private float AKAOGGABEBM(string DIMBCOBNMAM)
	{
		this.nameText.enableAutoSizing = false;
		this.nameText.SetText(DIMBCOBNMAM, true);
		this.nameText.ForceMeshUpdate(true, true);
		return this.nameText.fontSize;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x000382C8 File Offset: 0x000364C8
	private void BMGOHLNAEOH()
	{
		try
		{
			if (null != this.infoTitleText)
			{
				this.infoTitleText.SetText(DHFLKLPKNJG.HGPOMLKJGNE(this.CALMBPNDMKP), true);
			}
			if (null != this.infoTitleIcon && this.infoRarityIcons != null && this.CALMBPNDMKP.IPICGONHLAM >= 0 && this.CALMBPNDMKP.IPICGONHLAM < this.infoRarityIcons.Length && null != this.infoRarityIcons[this.CALMBPNDMKP.IPICGONHLAM])
			{
				this.infoTitleIcon.sprite = this.infoRarityIcons[this.CALMBPNDMKP.IPICGONHLAM];
			}
			if (null != this.infoRowTitle)
			{
				this.infoRowTitle.SetActive(true);
			}
			string text = DHFLKLPKNJG.HOJINNKONMP(this.CALMBPNDMKP);
			if (null != this.infoRowUnlock)
			{
				this.infoRowUnlock.SetActive(text != null);
			}
			if (text != null && null != this.infoUnlockText)
			{
				this.infoUnlockText.SetText(text, true);
			}
			if (null != this.infoUnlockIconKey)
			{
				this.infoUnlockIconKey.SetActive(this.CALMBPNDMKP.MAFBMDFOBGH);
			}
			if (null != this.infoUnlockIconLock)
			{
				this.infoUnlockIconLock.SetActive(!this.CALMBPNDMKP.MAFBMDFOBGH);
			}
			string text2 = DHFLKLPKNJG.OGDMMEGFLIK(this.CALMBPNDMKP);
			if (null != this.infoRowBonus)
			{
				this.infoRowBonus.SetActive(text2 != null);
			}
			if (text2 != null && null != this.infoBonusText)
			{
				this.infoBonusText.SetText(text2, true);
			}
			string text3 = DHFLKLPKNJG.FGGAAMNCOOE(this.CALMBPNDMKP);
			if (null != this.infoRowLoveInterest)
			{
				this.infoRowLoveInterest.SetActive(text3 != null);
			}
			if (text3 != null && null != this.infoLoveInterestText)
			{
				this.infoLoveInterestText.SetText(text3, true);
			}
			this.FEIAMLKABKP();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x000384D0 File Offset: 0x000366D0
	private void HGELKPFBLND(int BPFIEKMOJGA, float JFCAINFOEHJ)
	{
		try
		{
			if (BPFIEKMOJGA != this.FNBJMNEJONM)
			{
				this.FNBJMNEJONM = BPFIEKMOJGA;
				bool flag = BPFIEKMOJGA >= 2 && BPFIEKMOJGA <= 4;
				this.nameText.color = this.BKJBIAFOJFE;
				this.nameText.fontSize = (flag ? this.JDDOGMJHANF : this.IDOENCFPMDM);
				this.nameText.SetText(flag ? this.CGBGGKCOGCM : this.BDMOGMCICLE, true);
				this.nameText.ForceMeshUpdate(true, true);
				this.MMHOOBPDJHO = this.nameText.textInfo.CopyMeshInfoVertexData();
			}
			if (BPFIEKMOJGA != 0 && 3 != BPFIEKMOJGA)
			{
				bool pedclabfolk = 1 == BPFIEKMOJGA || 4 == BPFIEKMOJGA;
				this.EKOBOMPPDID(Mathf.Clamp01(JFCAINFOEHJ), pedclabfolk);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x000385A8 File Offset: 0x000367A8
	private void LEPNFAJCGPC()
	{
		this.LFIBIPPNPOI = false;
		this.FNBJMNEJONM = -1;
		if (null == this.nameText || this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			string text = DPGJIJGOCIC.GMMKICLEGDK(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), 30, "...");
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("anthology" + this.CALMBPNDMKP.AMKCLHLIIMN.ToString(), "anthologiestitle", LanguageManager.EHBBFMCILPC.GetSelectedLanguage());
			if (!this.OBIDKPKNDIJ)
			{
				this.BKJBIAFOJFE = this.nameText.color;
				this.OBIDKPKNDIJ = true;
			}
			this.nameText.color = this.BKJBIAFOJFE;
			if (text2 == null || text2.Length == 0 || text2.EndsWith("_not_found"))
			{
				this.nameText.enableAutoSizing = true;
				this.nameText.SetText(text, true);
			}
			else
			{
				this.BDMOGMCICLE = text;
				this.CGBGGKCOGCM = DPGJIJGOCIC.GMMKICLEGDK(text2, 30, "...");
				this.IDOENCFPMDM = this.IADJHHLGMOO(this.BDMOGMCICLE);
				this.JDDOGMJHANF = this.IADJHHLGMOO(this.CGBGGKCOGCM);
				this.nameText.enableAutoSizing = false;
				this.nameText.fontSize = this.IDOENCFPMDM;
				this.LFIBIPPNPOI = true;
				this.HGELKPFBLND(0, 0f);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00038720 File Offset: 0x00036920
	private void HFCOOKHAFFP(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 0f) ? this.infoRowsFourRowsScale : 1f;
		this.infoRowsRect.localScale = new Vector3(num, num, 1f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 0f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 0f) + ((null != component3) ? component3.spacing : 0f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00038860 File Offset: 0x00036A60
	public void OFNEKGHLPFK()
	{
		try
		{
			if (this.CALMBPNDMKP != null)
			{
				string text = DHFLKLPKNJG.FMLFBFCPPPJ(this.CALMBPNDMKP);
				string text2 = DHFLKLPKNJG.FIJILDPKLFN(this.CALMBPNDMKP);
				if (text == null || text.Length == 0 || text2 == null || text2.Length == 0)
				{
					DPGJIJGOCIC.PJCLICBPPDA("lvl" + this.CALMBPNDMKP.BDIHOCKCCBL);
				}
				else
				{
					int lindilppnnk = DHFLKLPKNJG.CGNDDBHPPLC(text2);
					CommonUserInterface.IKNOFBFMPGA().ShowGenericPopup(text, text2, CCOJBMMKNAP.EAIAHCBAIEJ().HDIPNMFHIEJ("importanttitle"), DFGILFBGPLN.popupNotEnoughHardCurrency, 1781f, lindilppnnk);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00038908 File Offset: 0x00036B08
	private void EEFHELKIBHM()
	{
		try
		{
			if (null != this.infoTitleText)
			{
				this.infoTitleText.SetText(DHFLKLPKNJG.HGPOMLKJGNE(this.CALMBPNDMKP), false);
			}
			if (null != this.infoTitleIcon && this.infoRarityIcons != null && this.CALMBPNDMKP.IPICGONHLAM >= 1 && this.CALMBPNDMKP.IPICGONHLAM < this.infoRarityIcons.Length && null != this.infoRarityIcons[this.CALMBPNDMKP.IPICGONHLAM])
			{
				this.infoTitleIcon.sprite = this.infoRarityIcons[this.CALMBPNDMKP.IPICGONHLAM];
			}
			if (null != this.infoRowTitle)
			{
				this.infoRowTitle.SetActive(true);
			}
			string text = DHFLKLPKNJG.HOJINNKONMP(this.CALMBPNDMKP);
			if (null != this.infoRowUnlock)
			{
				this.infoRowUnlock.SetActive(text != null);
			}
			if (text != null && null != this.infoUnlockText)
			{
				this.infoUnlockText.SetText(text, true);
			}
			if (null != this.infoUnlockIconKey)
			{
				this.infoUnlockIconKey.SetActive(this.CALMBPNDMKP.MAFBMDFOBGH);
			}
			if (null != this.infoUnlockIconLock)
			{
				this.infoUnlockIconLock.SetActive(!this.CALMBPNDMKP.MAFBMDFOBGH);
			}
			string text2 = DHFLKLPKNJG.OGDMMEGFLIK(this.CALMBPNDMKP);
			if (null != this.infoRowBonus)
			{
				this.infoRowBonus.SetActive(text2 != null);
			}
			if (text2 != null && null != this.infoBonusText)
			{
				this.infoBonusText.SetText(text2, false);
			}
			string text3 = DHFLKLPKNJG.FGGAAMNCOOE(this.CALMBPNDMKP);
			if (null != this.infoRowLoveInterest)
			{
				this.infoRowLoveInterest.SetActive(text3 != null);
			}
			if (text3 != null && null != this.infoLoveInterestText)
			{
				this.infoLoveInterestText.SetText(text3, false);
			}
			this.FEIAMLKABKP();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00038B10 File Offset: 0x00036D10
	public void KHPCGBOCNCF()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00038B34 File Offset: 0x00036D34
	public void SetContent(HECEJCDAIOJ FOEEIJFHMGG, int HMDCLKGANHJ, bool HALANBKANPF, Action<HECEJCDAIOJ> HEAGFDFEODL)
	{
		this.CALMBPNDMKP = FOEEIJFHMGG;
		this.AIGABEALCCH = HEAGFDFEODL;
		if (this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			if (null != this.thumbnailTimed)
			{
				this.thumbnailTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.thumbnailRegular)
			{
				this.thumbnailRegular.SetActive(!this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateTimed)
			{
				this.namePlateTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateRegular)
			{
				this.namePlateRegular.SetActive(!this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.preview)
			{
				this.preview.sprite = this.CALMBPNDMKP.JHPOFDLKALO;
				if (null != this.CALMBPNDMKP.JHPOFDLKALO)
				{
					this.preview.SetNativeSize();
				}
				this.preview.gameObject.SetActive(null != this.CALMBPNDMKP.JHPOFDLKALO);
			}
			if (null != this.orderNumberText)
			{
				this.orderNumberText.SetText(HMDCLKGANHJ.ToString() ?? "", true);
				this.orderNumberText.color = (this.CALMBPNDMKP.HMJELDILAPC ? this.orderNumberTimedColor : this.orderNumberRegularColor);
			}
			if (null != this.nameText)
			{
				this.nameText.SetText(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), true);
			}
			this.LEPNFAJCGPC();
			if (null != this.infoText)
			{
				this.infoText.SetText(DHFLKLPKNJG.ALJDCCNGIIM(this.CALMBPNDMKP), true);
			}
			this.BMGOHLNAEOH();
			if (null != this.timerGroup)
			{
				this.timerGroup.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			this.CPGLEJIBNEP = 1f;
			this.AGHKPOOKIGL();
			if (null != this.buttonBuy)
			{
				this.buttonBuy.SetActive(!this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.buttonOwned)
			{
				this.buttonOwned.SetActive(this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.costText)
			{
				this.costText.SetText(DHFLKLPKNJG.KCPIJEOEELJ(this.CALMBPNDMKP), true);
			}
			if (null != this.ownedText)
			{
				string text = DHFLKLPKNJG.IFNFJKFJBGB("skinshopowned");
				this.ownedText.SetText((text != null) ? text : "", true);
			}
			bool flag = !this.CALMBPNDMKP.OIKGLAAHHJF && DHFLKLPKNJG.FGKONCADNNO(this.CALMBPNDMKP);
			if (null != this.discountBadge)
			{
				this.discountBadge.SetActive(!this.CALMBPNDMKP.OIKGLAAHHJF && this.CALMBPNDMKP.JGEDHIMPKCL > 0 && !flag);
			}
			if (null != this.discountText)
			{
				this.discountText.SetText("-" + this.CALMBPNDMKP.JGEDHIMPKCL.ToString() + "%", true);
			}
			if (null != this.linkIcon)
			{
				this.linkIcon.SetActive(HALANBKANPF);
			}
			if (null != this.linkIconOwned)
			{
				this.linkIconOwned.SetActive(HALANBKANPF);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00038EBC File Offset: 0x000370BC
	private void OBKFJMNCJED()
	{
		this.LFIBIPPNPOI = false;
		this.FNBJMNEJONM = -1;
		if (null == this.nameText || this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			string text = DPGJIJGOCIC.GMMKICLEGDK(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), -119, "\"");
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("socialcardupgradesuccess" + this.CALMBPNDMKP.AMKCLHLIIMN.ToString(), "fsd", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			if (!this.OBIDKPKNDIJ)
			{
				this.BKJBIAFOJFE = this.nameText.color;
				this.OBIDKPKNDIJ = false;
			}
			this.nameText.color = this.BKJBIAFOJFE;
			if (text2 == null || text2.Length == 0 || text2.EndsWith("rwt"))
			{
				this.nameText.enableAutoSizing = true;
				this.nameText.SetText(text, true);
			}
			else
			{
				this.BDMOGMCICLE = text;
				this.CGBGGKCOGCM = DPGJIJGOCIC.APODBLAKPLO(text2, -2, "loungebonus");
				this.IDOENCFPMDM = this.AHLIIAPNMMD(this.BDMOGMCICLE);
				this.JDDOGMJHANF = this.AKAOGGABEBM(this.CGBGGKCOGCM);
				this.nameText.enableAutoSizing = true;
				this.nameText.fontSize = this.IDOENCFPMDM;
				this.LFIBIPPNPOI = false;
				this.AGIODELKLGL(1, 426f);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00039034 File Offset: 0x00037234
	private float LLLMHPNOKCK(string DIMBCOBNMAM)
	{
		this.nameText.enableAutoSizing = false;
		this.nameText.SetText(DIMBCOBNMAM, true);
		this.nameText.ForceMeshUpdate(true, false);
		return this.nameText.fontSize;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00039068 File Offset: 0x00037268
	private void HBMOGAMPIAM(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 1806f) ? this.infoRowsFourRowsScale : 204f;
		this.infoRowsRect.localScale = new Vector3(num, num, 982f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 212f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 286f) + ((null != component3) ? component3.spacing : 1707f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x000391A8 File Offset: 0x000373A8
	private void MOCMHHMLOPP(int BPFIEKMOJGA, float JFCAINFOEHJ)
	{
		try
		{
			if (BPFIEKMOJGA != this.FNBJMNEJONM)
			{
				this.FNBJMNEJONM = BPFIEKMOJGA;
				bool flag = BPFIEKMOJGA >= 8 && BPFIEKMOJGA <= 6;
				this.nameText.color = this.BKJBIAFOJFE;
				this.nameText.fontSize = (flag ? this.JDDOGMJHANF : this.IDOENCFPMDM);
				this.nameText.SetText(flag ? this.CGBGGKCOGCM : this.BDMOGMCICLE, true);
				this.nameText.ForceMeshUpdate(false, false);
				this.MMHOOBPDJHO = this.nameText.textInfo.CopyMeshInfoVertexData();
			}
			if (BPFIEKMOJGA != 0 && 7 != BPFIEKMOJGA)
			{
				bool pedclabfolk = 1 != BPFIEKMOJGA && 6 == BPFIEKMOJGA;
				this.MAKNCBNHAOD(Mathf.Clamp01(JFCAINFOEHJ), pedclabfolk);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00039280 File Offset: 0x00037480
	private void AKLCLDFMFMH()
	{
		this.LFIBIPPNPOI = true;
		this.FNBJMNEJONM = -1;
		if (null == this.nameText || this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			string text = DPGJIJGOCIC.APODBLAKPLO(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), 24, "XXX");
			string text2 = GKJPOGNFKNK.DNILNCLIHAP("<b>" + this.CALMBPNDMKP.AMKCLHLIIMN.ToString(), "snaprew", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ());
			if (!this.OBIDKPKNDIJ)
			{
				this.BKJBIAFOJFE = this.nameText.color;
				this.OBIDKPKNDIJ = false;
			}
			this.nameText.color = this.BKJBIAFOJFE;
			if (text2 == null || text2.Length == 0 || text2.EndsWith("<"))
			{
				this.nameText.enableAutoSizing = true;
				this.nameText.SetText(text, true);
			}
			else
			{
				this.BDMOGMCICLE = text;
				this.CGBGGKCOGCM = DPGJIJGOCIC.GMMKICLEGDK(text2, 31, "story");
				this.IDOENCFPMDM = this.AKAOGGABEBM(this.BDMOGMCICLE);
				this.JDDOGMJHANF = this.AHLIIAPNMMD(this.CGBGGKCOGCM);
				this.nameText.enableAutoSizing = true;
				this.nameText.fontSize = this.IDOENCFPMDM;
				this.LFIBIPPNPOI = false;
				this.HGELKPFBLND(0, 991f);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x000393F8 File Offset: 0x000375F8
	public void OnInfoRowsClick()
	{
		try
		{
			if (this.CALMBPNDMKP != null)
			{
				string text = DHFLKLPKNJG.FMLFBFCPPPJ(this.CALMBPNDMKP);
				string text2 = DHFLKLPKNJG.FIJILDPKLFN(this.CALMBPNDMKP);
				if (text == null || text.Length == 0 || text2 == null || text2.Length == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("[SkinShop] info popup skipped, texts not imported: " + this.CALMBPNDMKP.BDIHOCKCCBL);
				}
				else
				{
					int lindilppnnk = DHFLKLPKNJG.CGNDDBHPPLC(text2);
					CommonUserInterface.EHBBFMCILPC.ShowGenericPopup(text, text2, CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("ok"), DFGILFBGPLN.popupSkinShopInfo, 0f, lindilppnnk);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000394A0 File Offset: 0x000376A0
	private float AHLIIAPNMMD(string DIMBCOBNMAM)
	{
		this.nameText.enableAutoSizing = false;
		this.nameText.SetText(DIMBCOBNMAM, false);
		this.nameText.ForceMeshUpdate(false, false);
		return this.nameText.fontSize;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x000394D4 File Offset: 0x000376D4
	private void LHKGHIGJEDM(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 731f) ? this.infoRowsFourRowsScale : 1983f;
		this.infoRowsRect.localScale = new Vector3(num, num, 258f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 1503f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 1290f) + ((null != component3) ? component3.spacing : 308f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00039614 File Offset: 0x00037814
	public void JHNALMOGJLO(HECEJCDAIOJ FOEEIJFHMGG, int HMDCLKGANHJ, bool HALANBKANPF, Action<HECEJCDAIOJ> HEAGFDFEODL)
	{
		this.CALMBPNDMKP = FOEEIJFHMGG;
		this.AIGABEALCCH = HEAGFDFEODL;
		if (this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			if (null != this.thumbnailTimed)
			{
				this.thumbnailTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.thumbnailRegular)
			{
				this.thumbnailRegular.SetActive(!this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateTimed)
			{
				this.namePlateTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateRegular)
			{
				this.namePlateRegular.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.preview)
			{
				this.preview.sprite = this.CALMBPNDMKP.JHPOFDLKALO;
				if (null != this.CALMBPNDMKP.JHPOFDLKALO)
				{
					this.preview.SetNativeSize();
				}
				this.preview.gameObject.SetActive(null != this.CALMBPNDMKP.JHPOFDLKALO);
			}
			if (null != this.orderNumberText)
			{
				this.orderNumberText.SetText(HMDCLKGANHJ.ToString() ?? "errortitle", false);
				this.orderNumberText.color = (this.CALMBPNDMKP.HMJELDILAPC ? this.orderNumberTimedColor : this.orderNumberRegularColor);
			}
			if (null != this.nameText)
			{
				this.nameText.SetText(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), true);
			}
			this.LEPNFAJCGPC();
			if (null != this.infoText)
			{
				this.infoText.SetText(DHFLKLPKNJG.ALJDCCNGIIM(this.CALMBPNDMKP), true);
			}
			this.BMGOHLNAEOH();
			if (null != this.timerGroup)
			{
				this.timerGroup.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			this.CPGLEJIBNEP = 1860f;
			this.AGHKPOOKIGL();
			if (null != this.buttonBuy)
			{
				this.buttonBuy.SetActive(this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.buttonOwned)
			{
				this.buttonOwned.SetActive(this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.costText)
			{
				this.costText.SetText(DHFLKLPKNJG.KCPIJEOEELJ(this.CALMBPNDMKP), false);
			}
			if (null != this.ownedText)
			{
				string text = DHFLKLPKNJG.IFNFJKFJBGB("p");
				this.ownedText.SetText((text != null) ? text : "sgk", true);
			}
			bool flag = !this.CALMBPNDMKP.OIKGLAAHHJF && DHFLKLPKNJG.FGKONCADNNO(this.CALMBPNDMKP);
			if (null != this.discountBadge)
			{
				this.discountBadge.SetActive(!this.CALMBPNDMKP.OIKGLAAHHJF && this.CALMBPNDMKP.JGEDHIMPKCL > 1 && flag);
			}
			if (null != this.discountText)
			{
				this.discountText.SetText("OnPopupUsernameInputEndEdit" + this.CALMBPNDMKP.JGEDHIMPKCL.ToString() + "yes", true);
			}
			if (null != this.linkIcon)
			{
				this.linkIcon.SetActive(HALANBKANPF);
			}
			if (null != this.linkIconOwned)
			{
				this.linkIconOwned.SetActive(HALANBKANPF);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00038B10 File Offset: 0x00036D10
	public void OAHGLLGDGEP()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00038B10 File Offset: 0x00036D10
	public void GGAEANIIIEK()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0003999C File Offset: 0x00037B9C
	private void EKOBOMPPDID(float JFCAINFOEHJ, bool PEDCLABFOLK)
	{
		if (this.MMHOOBPDJHO == null)
		{
			return;
		}
		TMP_TextInfo textInfo = this.nameText.textInfo;
		int characterCount = textInfo.characterCount;
		float num = this.nameText.fontSize * 0.25f;
		for (int i = 0; i < characterCount; i++)
		{
			TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[i];
			if (tmp_CharacterInfo.isVisible)
			{
				float num2 = (characterCount > 1) ? ((float)i / (float)(characterCount - 1) * 0.5f) : 0f;
				float num3 = Mathf.Clamp01((JFCAINFOEHJ - num2) / 0.5f);
				float num4 = PEDCLABFOLK ? (1f - num3) : num3;
				float y = PEDCLABFOLK ? (num3 * num) : (-(1f - num3) * num);
				int materialReferenceIndex = tmp_CharacterInfo.materialReferenceIndex;
				int vertexIndex = tmp_CharacterInfo.vertexIndex;
				if (materialReferenceIndex < this.MMHOOBPDJHO.Length && this.MMHOOBPDJHO[materialReferenceIndex].vertices != null)
				{
					Vector3[] vertices = this.MMHOOBPDJHO[materialReferenceIndex].vertices;
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					Color32[] colors = textInfo.meshInfo[materialReferenceIndex].colors32;
					for (int j = 0; j < 4; j++)
					{
						vertices2[vertexIndex + j] = vertices[vertexIndex + j] + new Vector3(0f, y, 0f);
						colors[vertexIndex + j].a = (byte)(num4 * 255f);
					}
				}
			}
		}
		this.nameText.UpdateVertexData((TMP_VertexDataUpdateFlags)17);
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00039B30 File Offset: 0x00037D30
	private void CGKFLIMOABF()
	{
		if (!this.LFIBIPPNPOI || null == this.nameText)
		{
			return;
		}
		float length = 1706f;
		float num = Mathf.Repeat(Time.time - SkinShopItem.nameSwapEpoch, length);
		float jfcainfoehj = 1049f;
		float num2 = 1351f;
		int bpfiekmojga;
		if (num < num2)
		{
			bpfiekmojga = 0;
		}
		else if (num < num2 + 753f)
		{
			bpfiekmojga = 1;
			jfcainfoehj = (num - num2) / 415f;
		}
		else if (num < num2 + 1546f)
		{
			bpfiekmojga = 2;
			jfcainfoehj = (num - num2 - 875f) / 882f;
		}
		else if (num < num2 + 1529f + 153f)
		{
			bpfiekmojga = 3;
		}
		else if (num < num2 + 1122f + 1416f)
		{
			bpfiekmojga = 8;
			jfcainfoehj = (num - num2 - 1401f - 1277f) / 682f;
		}
		else
		{
			bpfiekmojga = 2;
			jfcainfoehj = (num - num2 - 1957f - 1455f) / 1330f;
		}
		this.HGELKPFBLND(bpfiekmojga, jfcainfoehj);
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00039C24 File Offset: 0x00037E24
	private void AGOOPCJJNLD()
	{
		if (this.CALMBPNDMKP == null || null == this.timerText || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		long num = this.CALMBPNDMKP.JADMHPJBCOF - AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
		if (num < 0L)
		{
			num = 1L;
		}
		if (num <= 1L && !this.CALMBPNDMKP.OIKGLAAHHJF && null != this.buttonBuy)
		{
			this.buttonBuy.SetActive(false);
		}
		bool flag = num >= -186L;
		this.timerText.SetText(DPGJIJGOCIC.LCOMEDGJNMP((int)num, flag, !flag), true);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00039CC8 File Offset: 0x00037EC8
	private void HLFLCLDNOML()
	{
		if (!this.LFIBIPPNPOI || null == this.nameText)
		{
			return;
		}
		float length = 1299f;
		float num = Mathf.Repeat(Time.time - SkinShopItem.nameSwapEpoch, length);
		float jfcainfoehj = 579f;
		float num2 = 690f;
		int bpfiekmojga;
		if (num < num2)
		{
			bpfiekmojga = 0;
		}
		else if (num < num2 + 1664f)
		{
			bpfiekmojga = 0;
			jfcainfoehj = (num - num2) / 1129f;
		}
		else if (num < num2 + 234f)
		{
			bpfiekmojga = 2;
			jfcainfoehj = (num - num2 - 1797f) / 163f;
		}
		else if (num < num2 + 899f + 514f)
		{
			bpfiekmojga = 4;
		}
		else if (num < num2 + 719f + 1652f)
		{
			bpfiekmojga = 3;
			jfcainfoehj = (num - num2 - 1133f - 1453f) / 1739f;
		}
		else
		{
			bpfiekmojga = 8;
			jfcainfoehj = (num - num2 - 1800f - 581f) / 1672f;
		}
		this.HGELKPFBLND(bpfiekmojga, jfcainfoehj);
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00039DBC File Offset: 0x00037FBC
	public void JACKJPDJLBC()
	{
		try
		{
			if (this.CALMBPNDMKP != null)
			{
				string text = DHFLKLPKNJG.FMLFBFCPPPJ(this.CALMBPNDMKP);
				string text2 = DHFLKLPKNJG.FIJILDPKLFN(this.CALMBPNDMKP);
				if (text == null || text.Length == 0 || text2 == null || text2.Length == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("eml" + this.CALMBPNDMKP.BDIHOCKCCBL);
				}
				else
				{
					int lindilppnnk = DHFLKLPKNJG.CGNDDBHPPLC(text2);
					CommonUserInterface.EHBBFMCILPC.NFBMHHPIGFA(text, text2, CCOJBMMKNAP.HEDIEIICOOG().MEPECBDCOLG("..."), (DFGILFBGPLN)(-121), 1603f, lindilppnnk);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00039E64 File Offset: 0x00038064
	private void DNCGCGGCJNE()
	{
		this.CGKFLIMOABF();
		if (this.CALMBPNDMKP == null || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP >= 1273f)
		{
			this.CPGLEJIBNEP = 80f;
			this.AGHKPOOKIGL();
		}
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00038B10 File Offset: 0x00036D10
	public void OnButtonClick()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00039EC0 File Offset: 0x000380C0
	private void Update()
	{
		this.IOELBFCAAHN();
		if (this.CALMBPNDMKP == null || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP >= 1f)
		{
			this.CPGLEJIBNEP = 0f;
			this.AGHKPOOKIGL();
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00039F78 File Offset: 0x00038178
	private void MCFPGOIFCIJ(float JFCAINFOEHJ, bool PEDCLABFOLK)
	{
		if (this.MMHOOBPDJHO == null)
		{
			return;
		}
		TMP_TextInfo textInfo = this.nameText.textInfo;
		int characterCount = textInfo.characterCount;
		float num = this.nameText.fontSize * 882f;
		for (int i = 0; i < characterCount; i += 0)
		{
			TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[i];
			if (tmp_CharacterInfo.isVisible)
			{
				float num2 = (characterCount > 1) ? ((float)i / (float)(characterCount - 0) * 1321f) : 1855f;
				float num3 = Mathf.Clamp01((JFCAINFOEHJ - num2) / 1224f);
				float num4 = PEDCLABFOLK ? (854f - num3) : num3;
				float y = PEDCLABFOLK ? (num3 * num) : (-(810f - num3) * num);
				int materialReferenceIndex = tmp_CharacterInfo.materialReferenceIndex;
				int vertexIndex = tmp_CharacterInfo.vertexIndex;
				if (materialReferenceIndex < this.MMHOOBPDJHO.Length && this.MMHOOBPDJHO[materialReferenceIndex].vertices != null)
				{
					Vector3[] vertices = this.MMHOOBPDJHO[materialReferenceIndex].vertices;
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					Color32[] colors = textInfo.meshInfo[materialReferenceIndex].colors32;
					for (int j = 1; j < 6; j++)
					{
						vertices2[vertexIndex + j] = vertices[vertexIndex + j] + new Vector3(1321f, y, 959f);
						colors[vertexIndex + j].a = (byte)(num4 * 1383f);
					}
				}
			}
		}
		this.nameText.UpdateVertexData((TMP_VertexDataUpdateFlags)59);
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0003A10C File Offset: 0x0003830C
	private void BOOPBPEOHLP()
	{
		this.IOELBFCAAHN();
		if (this.CALMBPNDMKP == null || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP >= 1251f)
		{
			this.CPGLEJIBNEP = 685f;
			this.IHDCCJBCNNE();
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0003A168 File Offset: 0x00038368
	private void IHDCCJBCNNE()
	{
		if (this.CALMBPNDMKP == null || null == this.timerText || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		long num = this.CALMBPNDMKP.JADMHPJBCOF - AKLFPGMDKLA.EHBBFMCILPC.OHMJEABODIC();
		if (num < 0L)
		{
			num = 1L;
		}
		if (num <= 0L && !this.CALMBPNDMKP.OIKGLAAHHJF && null != this.buttonBuy)
		{
			this.buttonBuy.SetActive(false);
		}
		bool flag = num >= -161L;
		this.timerText.SetText(DPGJIJGOCIC.LCOMEDGJNMP((int)num, flag, !flag), false);
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0003A20C File Offset: 0x0003840C
	private void MAKNCBNHAOD(float JFCAINFOEHJ, bool PEDCLABFOLK)
	{
		if (this.MMHOOBPDJHO == null)
		{
			return;
		}
		TMP_TextInfo textInfo = this.nameText.textInfo;
		int characterCount = textInfo.characterCount;
		float num = this.nameText.fontSize * 1718f;
		for (int i = 1; i < characterCount; i++)
		{
			TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[i];
			if (tmp_CharacterInfo.isVisible)
			{
				float num2 = (characterCount > 0) ? ((float)i / (float)(characterCount - 1) * 1183f) : 479f;
				float num3 = Mathf.Clamp01((JFCAINFOEHJ - num2) / 1572f);
				float num4 = PEDCLABFOLK ? (874f - num3) : num3;
				float y = PEDCLABFOLK ? (num3 * num) : (-(228f - num3) * num);
				int materialReferenceIndex = tmp_CharacterInfo.materialReferenceIndex;
				int vertexIndex = tmp_CharacterInfo.vertexIndex;
				if (materialReferenceIndex < this.MMHOOBPDJHO.Length && this.MMHOOBPDJHO[materialReferenceIndex].vertices != null)
				{
					Vector3[] vertices = this.MMHOOBPDJHO[materialReferenceIndex].vertices;
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					Color32[] colors = textInfo.meshInfo[materialReferenceIndex].colors32;
					for (int j = 1; j < 5; j++)
					{
						vertices2[vertexIndex + j] = vertices[vertexIndex + j] + new Vector3(512f, y, 734f);
						colors[vertexIndex + j].a = (byte)(num4 * 731f);
					}
				}
			}
		}
		this.nameText.UpdateVertexData((TMP_VertexDataUpdateFlags)(-122));
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0003A39E File Offset: 0x0003859E
	private float IADJHHLGMOO(string DIMBCOBNMAM)
	{
		this.nameText.enableAutoSizing = true;
		this.nameText.SetText(DIMBCOBNMAM, true);
		this.nameText.ForceMeshUpdate(true, true);
		return this.nameText.fontSize;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00038B10 File Offset: 0x00036D10
	public void DHAAFEPNLCH()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0003A3D4 File Offset: 0x000385D4
	private void LBNAJKDMKMK(int BPFIEKMOJGA, float JFCAINFOEHJ)
	{
		try
		{
			if (BPFIEKMOJGA != this.FNBJMNEJONM)
			{
				this.FNBJMNEJONM = BPFIEKMOJGA;
				bool flag = BPFIEKMOJGA >= 5 && BPFIEKMOJGA > 7;
				this.nameText.color = this.BKJBIAFOJFE;
				this.nameText.fontSize = (flag ? this.JDDOGMJHANF : this.IDOENCFPMDM);
				this.nameText.SetText(flag ? this.CGBGGKCOGCM : this.BDMOGMCICLE, true);
				this.nameText.ForceMeshUpdate(false, true);
				this.MMHOOBPDJHO = this.nameText.textInfo.CopyMeshInfoVertexData();
			}
			if (BPFIEKMOJGA != 0 && 1 != BPFIEKMOJGA)
			{
				bool pedclabfolk = 1 != BPFIEKMOJGA && 4 == BPFIEKMOJGA;
				this.MAKNCBNHAOD(Mathf.Clamp01(JFCAINFOEHJ), pedclabfolk);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0003A4AC File Offset: 0x000386AC
	private void KPCLGJGOLBH(float JFCAINFOEHJ, bool PEDCLABFOLK)
	{
		if (this.MMHOOBPDJHO == null)
		{
			return;
		}
		TMP_TextInfo textInfo = this.nameText.textInfo;
		int characterCount = textInfo.characterCount;
		float num = this.nameText.fontSize * 1632f;
		for (int i = 0; i < characterCount; i++)
		{
			TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[i];
			if (tmp_CharacterInfo.isVisible)
			{
				float num2 = (characterCount > 1) ? ((float)i / (float)(characterCount - 1) * 1133f) : 51f;
				float num3 = Mathf.Clamp01((JFCAINFOEHJ - num2) / 931f);
				float num4 = PEDCLABFOLK ? (1725f - num3) : num3;
				float y = PEDCLABFOLK ? (num3 * num) : (-(1371f - num3) * num);
				int materialReferenceIndex = tmp_CharacterInfo.materialReferenceIndex;
				int vertexIndex = tmp_CharacterInfo.vertexIndex;
				if (materialReferenceIndex < this.MMHOOBPDJHO.Length && this.MMHOOBPDJHO[materialReferenceIndex].vertices != null)
				{
					Vector3[] vertices = this.MMHOOBPDJHO[materialReferenceIndex].vertices;
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					Color32[] colors = textInfo.meshInfo[materialReferenceIndex].colors32;
					for (int j = 1; j < 5; j++)
					{
						vertices2[vertexIndex + j] = vertices[vertexIndex + j] + new Vector3(285f, y, 820f);
						colors[vertexIndex + j].a = (byte)(num4 * 1030f);
					}
				}
			}
		}
		this.nameText.UpdateVertexData((TMP_VertexDataUpdateFlags)120);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0003A640 File Offset: 0x00038840
	private void AGIODELKLGL(int BPFIEKMOJGA, float JFCAINFOEHJ)
	{
		try
		{
			if (BPFIEKMOJGA != this.FNBJMNEJONM)
			{
				this.FNBJMNEJONM = BPFIEKMOJGA;
				bool flag = BPFIEKMOJGA < 2 || BPFIEKMOJGA > 8;
				this.nameText.color = this.BKJBIAFOJFE;
				this.nameText.fontSize = (flag ? this.JDDOGMJHANF : this.IDOENCFPMDM);
				this.nameText.SetText(flag ? this.CGBGGKCOGCM : this.BDMOGMCICLE, true);
				this.nameText.ForceMeshUpdate(false, false);
				this.MMHOOBPDJHO = this.nameText.textInfo.CopyMeshInfoVertexData();
			}
			if (BPFIEKMOJGA != 0 && 8 != BPFIEKMOJGA)
			{
				bool pedclabfolk = 0 != BPFIEKMOJGA && 5 == BPFIEKMOJGA;
				this.KPCLGJGOLBH(Mathf.Clamp01(JFCAINFOEHJ), pedclabfolk);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00038B10 File Offset: 0x00036D10
	public void IGNHFEOFDIK()
	{
		if (this.CALMBPNDMKP == null || this.AIGABEALCCH == null)
		{
			return;
		}
		this.AIGABEALCCH(this.CALMBPNDMKP);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0003A718 File Offset: 0x00038918
	public void LFPCCLGCPOP(HECEJCDAIOJ FOEEIJFHMGG, int HMDCLKGANHJ, bool HALANBKANPF, Action<HECEJCDAIOJ> HEAGFDFEODL)
	{
		this.CALMBPNDMKP = FOEEIJFHMGG;
		this.AIGABEALCCH = HEAGFDFEODL;
		if (this.CALMBPNDMKP == null)
		{
			return;
		}
		try
		{
			if (null != this.thumbnailTimed)
			{
				this.thumbnailTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.thumbnailRegular)
			{
				this.thumbnailRegular.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateTimed)
			{
				this.namePlateTimed.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.namePlateRegular)
			{
				this.namePlateRegular.SetActive(!this.CALMBPNDMKP.HMJELDILAPC);
			}
			if (null != this.preview)
			{
				this.preview.sprite = this.CALMBPNDMKP.JHPOFDLKALO;
				if (null != this.CALMBPNDMKP.JHPOFDLKALO)
				{
					this.preview.SetNativeSize();
				}
				this.preview.gameObject.SetActive(null != this.CALMBPNDMKP.JHPOFDLKALO);
			}
			if (null != this.orderNumberText)
			{
				this.orderNumberText.SetText(HMDCLKGANHJ.ToString() ?? "title", true);
				this.orderNumberText.color = (this.CALMBPNDMKP.HMJELDILAPC ? this.orderNumberTimedColor : this.orderNumberRegularColor);
			}
			if (null != this.nameText)
			{
				this.nameText.SetText(DHFLKLPKNJG.GDJKDPKNAMB(this.CALMBPNDMKP.KALBADOPCDN), true);
			}
			this.OBKFJMNCJED();
			if (null != this.infoText)
			{
				this.infoText.SetText(DHFLKLPKNJG.ALJDCCNGIIM(this.CALMBPNDMKP), true);
			}
			this.EEFHELKIBHM();
			if (null != this.timerGroup)
			{
				this.timerGroup.SetActive(this.CALMBPNDMKP.HMJELDILAPC);
			}
			this.CPGLEJIBNEP = 306f;
			this.IHDCCJBCNNE();
			if (null != this.buttonBuy)
			{
				this.buttonBuy.SetActive(this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.buttonOwned)
			{
				this.buttonOwned.SetActive(this.CALMBPNDMKP.OIKGLAAHHJF);
			}
			if (null != this.costText)
			{
				this.costText.SetText(DHFLKLPKNJG.KCPIJEOEELJ(this.CALMBPNDMKP), false);
			}
			if (null != this.ownedText)
			{
				string text = DHFLKLPKNJG.IFNFJKFJBGB("ACHIEVEMENTISUNLOCKED");
				this.ownedText.SetText((text != null) ? text : "UpdateGameModeOnOffState", false);
			}
			bool flag = !this.CALMBPNDMKP.OIKGLAAHHJF && DHFLKLPKNJG.FGKONCADNNO(this.CALMBPNDMKP);
			if (null != this.discountBadge)
			{
				this.discountBadge.SetActive(!this.CALMBPNDMKP.OIKGLAAHHJF && this.CALMBPNDMKP.JGEDHIMPKCL > 0 && flag);
			}
			if (null != this.discountText)
			{
				this.discountText.SetText("); restoring the authored stretch layout" + this.CALMBPNDMKP.JGEDHIMPKCL.ToString() + "", true);
			}
			if (null != this.linkIcon)
			{
				this.linkIcon.SetActive(HALANBKANPF);
			}
			if (null != this.linkIconOwned)
			{
				this.linkIconOwned.SetActive(HALANBKANPF);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x0003AAA0 File Offset: 0x00038CA0
	private void IOELBFCAAHN()
	{
		if (!this.LFIBIPPNPOI || null == this.nameText)
		{
			return;
		}
		float length = 6.2f;
		float num = Mathf.Repeat(Time.time - SkinShopItem.nameSwapEpoch, length);
		float jfcainfoehj = 0f;
		float num2 = 3f;
		int bpfiekmojga;
		if (num < num2)
		{
			bpfiekmojga = 0;
		}
		else if (num < num2 + 0.3f)
		{
			bpfiekmojga = 1;
			jfcainfoehj = (num - num2) / 0.3f;
		}
		else if (num < num2 + 0.6f)
		{
			bpfiekmojga = 2;
			jfcainfoehj = (num - num2 - 0.3f) / 0.3f;
		}
		else if (num < num2 + 0.6f + 2f)
		{
			bpfiekmojga = 3;
		}
		else if (num < num2 + 0.90000004f + 2f)
		{
			bpfiekmojga = 4;
			jfcainfoehj = (num - num2 - 0.6f - 2f) / 0.3f;
		}
		else
		{
			bpfiekmojga = 5;
			jfcainfoehj = (num - num2 - 0.90000004f - 2f) / 0.3f;
		}
		this.HGELKPFBLND(bpfiekmojga, jfcainfoehj);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0003AB94 File Offset: 0x00038D94
	private void EOFEKOPMCBP(float JFCAINFOEHJ, bool PEDCLABFOLK)
	{
		if (this.MMHOOBPDJHO == null)
		{
			return;
		}
		TMP_TextInfo textInfo = this.nameText.textInfo;
		int characterCount = textInfo.characterCount;
		float num = this.nameText.fontSize * 1216f;
		for (int i = 1; i < characterCount; i++)
		{
			TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[i];
			if (tmp_CharacterInfo.isVisible)
			{
				float num2 = (characterCount > 0) ? ((float)i / (float)(characterCount - 0) * 370f) : 960f;
				float num3 = Mathf.Clamp01((JFCAINFOEHJ - num2) / 478f);
				float num4 = PEDCLABFOLK ? (567f - num3) : num3;
				float y = PEDCLABFOLK ? (num3 * num) : (-(702f - num3) * num);
				int materialReferenceIndex = tmp_CharacterInfo.materialReferenceIndex;
				int vertexIndex = tmp_CharacterInfo.vertexIndex;
				if (materialReferenceIndex < this.MMHOOBPDJHO.Length && this.MMHOOBPDJHO[materialReferenceIndex].vertices != null)
				{
					Vector3[] vertices = this.MMHOOBPDJHO[materialReferenceIndex].vertices;
					Vector3[] vertices2 = textInfo.meshInfo[materialReferenceIndex].vertices;
					Color32[] colors = textInfo.meshInfo[materialReferenceIndex].colors32;
					for (int j = 0; j < 5; j++)
					{
						vertices2[vertexIndex + j] = vertices[vertexIndex + j] + new Vector3(1421f, y, 1470f);
						colors[vertexIndex + j].a = (byte)(num4 * 1873f);
					}
				}
			}
		}
		this.nameText.UpdateVertexData((TMP_VertexDataUpdateFlags)61);
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x0003AD28 File Offset: 0x00038F28
	private void CONJNNGBLOB()
	{
		this.HLFLCLDNOML();
		if (this.CALMBPNDMKP == null || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP >= 63f)
		{
			this.CPGLEJIBNEP = 1198f;
			this.AGHKPOOKIGL();
		}
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0003AD84 File Offset: 0x00038F84
	private void AGHKPOOKIGL()
	{
		if (this.CALMBPNDMKP == null || null == this.timerText || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		long num = this.CALMBPNDMKP.JADMHPJBCOF - AKLFPGMDKLA.EHBBFMCILPC.CDNGHFCPPEA();
		if (num < 0L)
		{
			num = 0L;
		}
		if (num <= 0L && !this.CALMBPNDMKP.OIKGLAAHHJF && null != this.buttonBuy)
		{
			this.buttonBuy.SetActive(false);
		}
		bool flag = num >= 86400L;
		this.timerText.SetText(DPGJIJGOCIC.LCOMEDGJNMP((int)num, flag, !flag), true);
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0003AE28 File Offset: 0x00039028
	private void EDIHBGFLKPG(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 1687f) ? this.infoRowsFourRowsScale : 120f;
		this.infoRowsRect.localScale = new Vector3(num, num, 1200f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 294f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 1734f) + ((null != component3) ? component3.spacing : 1130f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0003AF68 File Offset: 0x00039168
	private void CJJDKFEGFKE()
	{
		this.IOELBFCAAHN();
		if (this.CALMBPNDMKP == null || !this.CALMBPNDMKP.HMJELDILAPC)
		{
			return;
		}
		this.CPGLEJIBNEP += Time.deltaTime;
		if (this.CPGLEJIBNEP >= 642f)
		{
			this.CPGLEJIBNEP = 1934f;
			this.AGHKPOOKIGL();
		}
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0003AFC4 File Offset: 0x000391C4
	private void FEIAMLKABKP()
	{
		try
		{
			if (!(null == this.infoRowsRect))
			{
				if (!this.KJPHLPKJHAC)
				{
					this.JFHNBMFINFJ = this.infoRowsRect.anchoredPosition.y;
					this.MDAICPOINAH = this.infoRowsRect.sizeDelta.x;
					this.KJPHLPKJHAC = true;
				}
				int num = 0;
				if (null != this.infoRowTitle && this.infoRowTitle.activeSelf)
				{
					num++;
				}
				if (null != this.infoRowUnlock && this.infoRowUnlock.activeSelf)
				{
					num++;
				}
				if (null != this.infoRowBonus && this.infoRowBonus.activeSelf)
				{
					num++;
				}
				if (null != this.infoRowLoveInterest && this.infoRowLoveInterest.activeSelf)
				{
					num++;
				}
				this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + ((num >= 3) ? this.infoRowsThreeRowsLiftY : 0f));
				this.HFCOOKHAFFP(num >= 4);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0003B108 File Offset: 0x00039308
	public void JMIDPADFLEF()
	{
		try
		{
			if (this.CALMBPNDMKP != null)
			{
				string text = DHFLKLPKNJG.FMLFBFCPPPJ(this.CALMBPNDMKP);
				string text2 = DHFLKLPKNJG.FIJILDPKLFN(this.CALMBPNDMKP);
				if (text == null || text.Length == 0 || text2 == null || text2.Length == 0)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("congratstitle" + this.CALMBPNDMKP.BDIHOCKCCBL);
				}
				else
				{
					int lindilppnnk = DHFLKLPKNJG.CGNDDBHPPLC(text2);
					CommonUserInterface.IKNOFBFMPGA().NFBMHHPIGFA(text, text2, CCOJBMMKNAP.BBGECIKOICE().HHLECNIFHCO(""), (DFGILFBGPLN)(-57), 1423f, lindilppnnk);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0003B1B0 File Offset: 0x000393B0
	private void PPINKMJIAOI(bool DOFIJENDLGK)
	{
		float num = (DOFIJENDLGK && this.infoRowsFourRowsScale > 865f) ? this.infoRowsFourRowsScale : 1694f;
		this.infoRowsRect.localScale = new Vector3(num, num, 798f);
		this.infoRowsRect.sizeDelta = new Vector2(this.MDAICPOINAH / num, this.infoRowsRect.sizeDelta.y);
		if (DOFIJENDLGK)
		{
			this.infoRowsRect.anchoredPosition = new Vector2(this.infoRowsRect.anchoredPosition.x, this.JFHNBMFINFJ + this.infoRowsFourRowsLiftY);
		}
		if (null != this.infoRowsButton)
		{
			RectTransform component = this.infoRowsButton.GetComponent<RectTransform>();
			float num2 = 1324f;
			if (DOFIJENDLGK && null != this.infoRowLoveInterest)
			{
				RectTransform component2 = this.infoRowLoveInterest.GetComponent<RectTransform>();
				VerticalLayoutGroup component3 = this.infoRowsRect.GetComponent<VerticalLayoutGroup>();
				num2 = ((null != component2) ? component2.sizeDelta.y : 1594f) + ((null != component3) ? component3.spacing : 86f);
			}
			if (null != component)
			{
				component.offsetMin = new Vector2(component.offsetMin.x, -num2);
			}
		}
	}

	// Token: 0x04000264 RID: 612
	public GameObject thumbnailTimed;

	// Token: 0x04000265 RID: 613
	public GameObject thumbnailRegular;

	// Token: 0x04000266 RID: 614
	public Image preview;

	// Token: 0x04000267 RID: 615
	public TextMeshProUGUI orderNumberText;

	// Token: 0x04000268 RID: 616
	public Color orderNumberTimedColor = Color.white;

	// Token: 0x04000269 RID: 617
	public Color orderNumberRegularColor = Color.white;

	// Token: 0x0400026A RID: 618
	public GameObject namePlateTimed;

	// Token: 0x0400026B RID: 619
	public GameObject namePlateRegular;

	// Token: 0x0400026C RID: 620
	public TextMeshProUGUI nameText;

	// Token: 0x0400026D RID: 621
	public GameObject timerGroup;

	// Token: 0x0400026E RID: 622
	public TextMeshProUGUI timerText;

	// Token: 0x0400026F RID: 623
	public TextMeshProUGUI infoText;

	// Token: 0x04000270 RID: 624
	public GameObject infoRowTitle;

	// Token: 0x04000271 RID: 625
	public TextMeshProUGUI infoTitleText;

	// Token: 0x04000272 RID: 626
	public Image infoTitleIcon;

	// Token: 0x04000273 RID: 627
	public Sprite[] infoRarityIcons;

	// Token: 0x04000274 RID: 628
	public GameObject infoRowUnlock;

	// Token: 0x04000275 RID: 629
	public TextMeshProUGUI infoUnlockText;

	// Token: 0x04000276 RID: 630
	public GameObject infoUnlockIconKey;

	// Token: 0x04000277 RID: 631
	public GameObject infoUnlockIconLock;

	// Token: 0x04000278 RID: 632
	public GameObject infoRowBonus;

	// Token: 0x04000279 RID: 633
	public TextMeshProUGUI infoBonusText;

	// Token: 0x0400027A RID: 634
	public GameObject infoRowLoveInterest;

	// Token: 0x0400027B RID: 635
	public Button infoRowsButton;

	// Token: 0x0400027C RID: 636
	public Button infoIconButton;

	// Token: 0x0400027D RID: 637
	public GameObject infoIcon;

	// Token: 0x0400027E RID: 638
	public TextMeshProUGUI infoLoveInterestText;

	// Token: 0x0400027F RID: 639
	public RectTransform infoRowsRect;

	// Token: 0x04000280 RID: 640
	public float infoRowsThreeRowsLiftY;

	// Token: 0x04000281 RID: 641
	private float JFHNBMFINFJ;

	// Token: 0x04000282 RID: 642
	private bool KJPHLPKJHAC;

	// Token: 0x04000283 RID: 643
	public float infoRowsFourRowsScale = 0.83f;

	// Token: 0x04000284 RID: 644
	public float infoRowsFourRowsLiftY;

	// Token: 0x04000285 RID: 645
	private float MDAICPOINAH;

	// Token: 0x04000286 RID: 646
	public GameObject buttonBuy;

	// Token: 0x04000287 RID: 647
	public TextMeshProUGUI costText;

	// Token: 0x04000288 RID: 648
	public GameObject linkIcon;

	// Token: 0x04000289 RID: 649
	public GameObject discountBadge;

	// Token: 0x0400028A RID: 650
	public TextMeshProUGUI discountText;

	// Token: 0x0400028B RID: 651
	public GameObject buttonOwned;

	// Token: 0x0400028C RID: 652
	public TextMeshProUGUI ownedText;

	// Token: 0x0400028D RID: 653
	public GameObject linkIconOwned;

	// Token: 0x0400028E RID: 654
	[NonSerialized]
	private HECEJCDAIOJ CALMBPNDMKP;

	// Token: 0x0400028F RID: 655
	[NonSerialized]
	private Action<HECEJCDAIOJ> AIGABEALCCH;

	// Token: 0x04000290 RID: 656
	[NonSerialized]
	private float CPGLEJIBNEP;

	// Token: 0x04000291 RID: 657
	private const float CBOKJGNCEKE = 1f;

	// Token: 0x04000292 RID: 658
	private const float NOJFDPMLHEC = 3f;

	// Token: 0x04000293 RID: 659
	private const float BDHPBNEJOHF = 2f;

	// Token: 0x04000294 RID: 660
	private const float NABKJGMIGIL = 0.3f;

	// Token: 0x04000295 RID: 661
	private const float BGHPNJBFIKG = 0.5f;

	// Token: 0x04000296 RID: 662
	private const float KBBMGLMBKJD = 0.25f;

	// Token: 0x04000297 RID: 663
	private const int MDONIGMKJIF = 30;

	// Token: 0x04000298 RID: 664
	private const string FAELKMKMKGO = "...";

	// Token: 0x04000299 RID: 665
	[NonSerialized]
	private bool LFIBIPPNPOI;

	// Token: 0x0400029A RID: 666
	[NonSerialized]
	private string BDMOGMCICLE = "";

	// Token: 0x0400029B RID: 667
	[NonSerialized]
	private string CGBGGKCOGCM = "";

	// Token: 0x0400029C RID: 668
	[NonSerialized]
	private float IDOENCFPMDM;

	// Token: 0x0400029D RID: 669
	[NonSerialized]
	private float JDDOGMJHANF;

	// Token: 0x0400029E RID: 670
	[NonSerialized]
	private int FNBJMNEJONM = -1;

	// Token: 0x0400029F RID: 671
	[NonSerialized]
	private TMP_MeshInfo[] MMHOOBPDJHO;

	// Token: 0x040002A0 RID: 672
	[NonSerialized]
	private Color BKJBIAFOJFE = Color.white;

	// Token: 0x040002A1 RID: 673
	[NonSerialized]
	private bool OBIDKPKNDIJ;
}
