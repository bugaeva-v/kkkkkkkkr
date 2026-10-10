using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000119 RID: 281
public class FilterItem : MonoBehaviour
{
	// Token: 0x06002548 RID: 9544 RVA: 0x001107D5 File Offset: 0x0010E9D5
	private void ILOPFODPJCL()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("OnPopupProfileNicknameInputEndEdit", new UnityAction(this.PPDPOBDELME));
		this.DGIMLPJGHNB();
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x001107F8 File Offset: 0x0010E9F8
	private void NFBINBIAFBF()
	{
		foreach (ThemeManager.CustomThemeProperties customThemeProperties in base.GetComponentInChildren<ThemeManager>().theme)
		{
			if (customThemeProperties.themeType == AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD())
			{
				this.PLLAMCJJCJB = customThemeProperties.themeColorText;
			}
		}
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x0011086C File Offset: 0x0010EA6C
	public void AIEECDLAOAM()
	{
		this.filterText.text = CCOJBMMKNAP.GIOAFDDKKHI().MEPECBDCOLG(this.id.ToString());
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x00110894 File Offset: 0x0010EA94
	public void LAMJMCKFFDJ()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x001108F4 File Offset: 0x0010EAF4
	public void IODPCDICGIO(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.HFAKOKBHCGH().BDGPNPNIAPA(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.GBHEKOKPNGF(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x001109B8 File Offset: 0x0010EBB8
	public void OAFENJMBMKB()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x00110A18 File Offset: 0x0010EC18
	public void EBDJLFJJKIO(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && component.isOn);
		component.isOn = false;
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x00110A48 File Offset: 0x0010EC48
	private void NCCMMHMPKOC()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.FEPLNBAMFGI();
			return;
		}
		this.CHPNKEKJIOI();
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x00110A6A File Offset: 0x0010EC6A
	private void AIHIIABBFKE()
	{
		AOBJLALDBAA.DBLAIDPICIG().MFIMALJPCDP("XXX", new UnityAction(this.NCCMMHMPKOC));
		this.ADDCPAEMJFC();
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x00110A90 File Offset: 0x0010EC90
	public void OPBFNLHIFCC()
	{
		try
		{
			this.LAMJMCKFFDJ();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.COGNAMJLIOM(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x00110AF8 File Offset: 0x0010ECF8
	private void CMIIIEAKFDC()
	{
		AOBJLALDBAA.KKPFOJMAONG().PEFKJOKLEDL("", new UnityAction(this.PPDPOBDELME));
		this.MKAHJOCBLHF();
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x00110B1C File Offset: 0x0010ED1C
	public void GGNPLGJNJBA(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.KFDLFGHBPLP().FCOCLEHKLDJ(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = false;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.KOLFLJFLALN(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x00110BE0 File Offset: 0x0010EDE0
	public void OMLPGBALONP()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 544f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 726f;
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x00110C3C File Offset: 0x0010EE3C
	public void FAGIPELEAHL()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1722f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 282f;
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x00110C98 File Offset: 0x0010EE98
	public void OJNMHNJOMMO()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 627f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1013f;
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x00110CF4 File Offset: 0x0010EEF4
	public void LDLNNJLCFKJ()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x00110D54 File Offset: 0x0010EF54
	private void ADDCPAEMJFC()
	{
		this.DGEAOIKLFJD();
		if (this.toggle.isOn)
		{
			this.SetActiveText();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x00110D76 File Offset: 0x0010EF76
	public void JCJILHEBEOI()
	{
		this.filterText.text = CCOJBMMKNAP.LMCCLMFGEBD().HHLECNIFHCO(this.id.ToString());
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x00110D9E File Offset: 0x0010EF9E
	public void JOPAHFINJJB()
	{
		this.filterText.text = CCOJBMMKNAP.BIAEAOMHBMM().PGKBCNBAOJN(this.id.ToString());
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x00110DC6 File Offset: 0x0010EFC6
	private void AHKJBOFGGMN()
	{
		this.LLKABMKNJKM();
		if (this.toggle.isOn)
		{
			this.BFLGMNGJFLP();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x00110DE8 File Offset: 0x0010EFE8
	private void FFLIDEPOFNH(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.HCEIMJKMGBA();
			if (!this.GHPDJJCLHGM)
			{
				this.KDEMPDFNIHI();
				if (JBBNEEHANHL.filterNone != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("LoadingEnvironmentManager", "0.000");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if (JBBNEEHANHL.filterCompleted != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("socialcardhintoncopiesv2", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.JHAABKGFEDC(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x00110E74 File Offset: 0x0010F074
	private void OOHJLJPPCOF(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.BFLGMNGJFLP();
			if (!this.GHPDJJCLHGM)
			{
				this.OOKPKOFMGOG();
				if ((JBBNEEHANHL)(-113) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("acomp2", "OnSystemBackButton");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)38 != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString(",", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.PFAPIFJIDFA(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.OFEHCBCIPDE();
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x00110EFE File Offset: 0x0010F0FE
	public void FELNAMJOMMK()
	{
		this.filterText.text = CCOJBMMKNAP.BFHKGNBFHCH().JHNELLJFBGC(this.id.ToString());
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x00110F28 File Offset: 0x0010F128
	public void EHNEKJPGGLM()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 366f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1739f;
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x00110F81 File Offset: 0x0010F181
	public void AJMNCNAGBGG()
	{
		this.filterText.text = CCOJBMMKNAP.ILACPHFEDEP().BGELFMIOBCL(this.id.ToString());
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x00110FAC File Offset: 0x0010F1AC
	public void AFCDNEOFEJC()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x0011100C File Offset: 0x0010F20C
	public void IJIFIJDCPHI(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && !component.isOn);
		component.isOn = false;
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x0011103C File Offset: 0x0010F23C
	public void JCCMHPGOGDK()
	{
		this.filterText.text = CCOJBMMKNAP.NIOJNOFGIJO().OHLNGCKIACD(this.id.ToString());
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x00111064 File Offset: 0x0010F264
	public void JOFBNIJIGLP()
	{
		this.filterText.text = CCOJBMMKNAP.OBOOKJPGBJN().JCDFHKDNEDH(this.id.ToString());
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x0011108C File Offset: 0x0010F28C
	private void DGIMLPJGHNB()
	{
		this.LLKABMKNJKM();
		if (this.toggle.isOn)
		{
			this.APHOENDINPF();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x001110B0 File Offset: 0x0010F2B0
	public void FKEBHLJAECD(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.KFAABHHGOPO().IPEIONBNIPH(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = false;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.HGFJEBOBMIO(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x00111174 File Offset: 0x0010F374
	private void EBLIMOOAPHD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("\"", new UnityAction(this.DMFKFJDDBEG));
		this.AFCDNEOFEJC();
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x001111A0 File Offset: 0x0010F3A0
	public void OOKPKOFMGOG()
	{
		try
		{
			this.LAMJMCKFFDJ();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.AFLDKGNMODP(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x00111208 File Offset: 0x0010F408
	private void JBGNFOBIBJH()
	{
		this.NFBINBIAFBF();
		if (this.toggle.isOn)
		{
			this.BFLGMNGJFLP();
			return;
		}
		this.FPCLNIIBBPH();
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x0011122C File Offset: 0x0010F42C
	public void PPPBIEDHGDO()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 386f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 864f;
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x00111288 File Offset: 0x0010F488
	public void LGDHPHBCECE()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1931f);
		this.filterText.fontSize = 1274f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 634f);
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 475f;
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x00111330 File Offset: 0x0010F530
	public void SetActiveText()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 37f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = -4f;
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x0011138C File Offset: 0x0010F58C
	private void MLBALKNKAAE(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.CNAKPBIGGEB();
			if (!this.GHPDJJCLHGM)
			{
				this.KDEMPDFNIHI();
				if ((JBBNEEHANHL)(-3) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("inkrevisionmissing", "loveInterestsBalance");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if (JBBNEEHANHL.newFilterSupernatural != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("AccountSignInManager.OnSignInSuccess() - sign in source not implemented.", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GOJJEEIILJN(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.OFEHCBCIPDE();
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x00111416 File Offset: 0x0010F616
	public void FGPIKFAKLIH()
	{
		this.filterText.text = CCOJBMMKNAP.INKJIBDDMLL().HIPJILDCHJC(this.id.ToString());
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x00111440 File Offset: 0x0010F640
	public void DBEBPEDIPKG(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && component.isOn);
		component.isOn = true;
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x00111470 File Offset: 0x0010F670
	public void KEMFIHCPCDA()
	{
		this.filterText.text = CCOJBMMKNAP.HFAKOKBHCGH().GGPHHLGPMPA(this.id.ToString());
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x00111498 File Offset: 0x0010F698
	private void GGDLLLNNEDM(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.CNAKPBIGGEB();
			if (!this.GHPDJJCLHGM)
			{
				this.PulseIcon();
				if ((JBBNEEHANHL)(-90) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("loungenotavailable", "SceneLobbyManager2.OpenPublicProfile(): AssetsManager.Instance.IsBusy()");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)108 != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.JHAABKGFEDC(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = false;
			return;
		}
		this.FDIMKFJBBLP();
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00111524 File Offset: 0x0010F724
	public void CNAFJFNKEFC(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && !component.isOn);
		component.isOn = true;
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x00111554 File Offset: 0x0010F754
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("onThemeChange", new UnityAction(this.ADDCPAEMJFC));
		this.StopPulse();
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x0011157F File Offset: 0x0010F77F
	private void GKPECDEPGBM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().NAMMLDPCHJO("total while iterations:", new UnityAction(this.PPDPOBDELME));
		this.AFCDNEOFEJC();
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x001115AC File Offset: 0x0010F7AC
	public void NHABDDCIEJG(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.JMDJPKKOHNI().BDGPNPNIAPA(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.ECLDAJDOENE(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x00111670 File Offset: 0x0010F870
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("onThemeChange", new UnityAction(this.ADDCPAEMJFC));
		this.ADDCPAEMJFC();
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x00111693 File Offset: 0x0010F893
	private void FDHHCPPPKKI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("importanttitle", new UnityAction(this.PMBLPNIPLGE));
		this.StopPulse();
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x001116C0 File Offset: 0x0010F8C0
	public void KOCNAGEHJEC()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1586f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 937f;
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x0011171C File Offset: 0x0010F91C
	public void KDEMPDFNIHI()
	{
		try
		{
			this.OKIBNDEKHBE();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.POOLAPEBKFL(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x00111784 File Offset: 0x0010F984
	public void FLEIIELMMDP()
	{
		this.filterText.text = CCOJBMMKNAP.BOFMCPPFAMO().JCDFHKDNEDH(this.id.ToString());
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x001117AC File Offset: 0x0010F9AC
	public void SetContent(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.JEIJLILCOEH(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x00111870 File Offset: 0x0010FA70
	public void PFNGNEGJGJM()
	{
		this.filterText.text = CCOJBMMKNAP.EHBBFMCILPC.FIENAKIHNOM(this.id.ToString());
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x00111898 File Offset: 0x0010FA98
	public void FEAFMMBDENH()
	{
		try
		{
			this.LDLNNJLCFKJ();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.COGNAMJLIOM(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x00111900 File Offset: 0x0010FB00
	public void HCEIMJKMGBA()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1261f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 1949f;
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x00111959 File Offset: 0x0010FB59
	private void BLDPGLLGHFM()
	{
		this.DGEAOIKLFJD();
		if (this.toggle.isOn)
		{
			this.FEPLNBAMFGI();
			return;
		}
		this.LLDGGDDCGMA();
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x0011197B File Offset: 0x0010FB7B
	public void FDEIKPPONLL()
	{
		this.filterText.text = CCOJBMMKNAP.HFAKOKBHCGH().FCOCLEHKLDJ(this.id.ToString());
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x001119A4 File Offset: 0x0010FBA4
	public void DNGMMOGLOFP()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1947f);
		this.filterText.fontSize = 1342f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 506f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 1279f;
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x00111A4C File Offset: 0x0010FC4C
	public void KCIKGOCKPKB(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.PKEINLPIAEH().MEPECBDCOLG(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.FFLIDEPOFNH(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x00111B10 File Offset: 0x0010FD10
	private void IKAAMMNIPGI()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("hintsigning", new UnityAction(this.DLIDGPJMNKB));
		this.CJHBHLGFFFH();
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x00111B34 File Offset: 0x0010FD34
	public void FPCLNIIBBPH()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1066f);
		this.filterText.fontSize = 976f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1409f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 1761f;
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x00111BDC File Offset: 0x0010FDDC
	public void CADHLIBKGBC(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (!GHPDJJCLHGM || !component.isOn);
		component.isOn = true;
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x00111C0C File Offset: 0x0010FE0C
	public void NMNIHHFJFLG()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00111C6C File Offset: 0x0010FE6C
	private void BFNOBDAKJON()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.NAMMLDPCHJO("", new UnityAction(this.CBDIANHDGFK));
		this.NMNIHHFJFLG();
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x00111C98 File Offset: 0x0010FE98
	public void MLPHPOHOOOP(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.MLFAGAAJJEM().HHLECNIFHCO(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.PHFLDLIIGAB(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x00111D5C File Offset: 0x0010FF5C
	public void PGEKJAIIOHN()
	{
		this.filterText.text = CCOJBMMKNAP.NIOJNOFGIJO().MEPECBDCOLG(this.id.ToString());
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x00111D84 File Offset: 0x0010FF84
	public void AKIJAODNANE()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1985f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 271f;
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x00111DE0 File Offset: 0x0010FFE0
	private void JEIJLILCOEH(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.SetActiveText();
			if (!this.GHPDJJCLHGM)
			{
				this.PulseIcon();
				if (JBBNEEHANHL.filterSearch != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("lastFilterTapped", "1");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if (JBBNEEHANHL.filterSearch != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("lastFilter", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.SetItemOnCenter(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = false;
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x00111E6A File Offset: 0x0011006A
	public void GLDIFHBNIDD()
	{
		this.filterText.text = CCOJBMMKNAP.ILACPHFEDEP().MEPECBDCOLG(this.id.ToString());
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00111E94 File Offset: 0x00110094
	public void CHPNKEKJIOI()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1061f);
		this.filterText.fontSize = 1015f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 77f);
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1257f;
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x00111F39 File Offset: 0x00110139
	private IEnumerator HNEMDEODCJH(RectTransform HNDJMKFCMEK)
	{
		FilterItem.FKICCGLJJJD fkiccgljjjd = new FilterItem.FKICCGLJJJD(1);
		fkiccgljjjd.<>4__this = this;
		fkiccgljjjd._icon = HNDJMKFCMEK;
		return fkiccgljjjd;
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00111F4F File Offset: 0x0011014F
	public void FDPJLBDFBPA()
	{
		this.filterText.text = CCOJBMMKNAP.EAIAHCBAIEJ().BGELFMIOBCL(this.id.ToString());
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x00111F78 File Offset: 0x00110178
	private void GMNAIHCNMKL()
	{
		foreach (ThemeManager.CustomThemeProperties customThemeProperties in base.GetComponentInChildren<ThemeManager>().theme)
		{
			if (customThemeProperties.themeType == AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD())
			{
				this.PLLAMCJJCJB = customThemeProperties.themeColorText;
			}
		}
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x00111FEC File Offset: 0x001101EC
	private void GJDCIHEPBEI()
	{
		this.NFBINBIAFBF();
		if (this.toggle.isOn)
		{
			this.OJNMHNJOMMO();
			return;
		}
		this.LGDHPHBCECE();
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x00112010 File Offset: 0x00110210
	public void BFLGMNGJFLP()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 886f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 1558f;
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x0011206C File Offset: 0x0011026C
	public void SetInactiveText()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1f);
		this.filterText.fontSize = 30f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1f);
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 0f;
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x00112111 File Offset: 0x00110311
	private void AILHMCGEMOG()
	{
		AOBJLALDBAA.NMGMNAKLLMI().BADOPKAOCPE("error", new UnityAction(this.GINNCBBODJO));
		this.JBGNFOBIBJH();
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x00112134 File Offset: 0x00110334
	private void DMFKFJDDBEG()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.OJNMHNJOMMO();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x00112156 File Offset: 0x00110356
	public void GFIMGLLDLJO()
	{
		this.filterText.text = CCOJBMMKNAP.HFAKOKBHCGH().IKMNGFIDCLM(this.id.ToString());
	}

	// Token: 0x06002598 RID: 9624 RVA: 0x00112180 File Offset: 0x00110380
	public void HNMIMALACNE()
	{
		try
		{
			this.AFCDNEOFEJC();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.HNEMDEODCJH(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x001121E8 File Offset: 0x001103E8
	public void CANDMGDHGGC(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.JMDJPKKOHNI().OBDCPLLLGBB(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.HGFJEBOBMIO(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x001122AC File Offset: 0x001104AC
	public void MHJMGGPKNBE(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.BFHKGNBFHCH().BGELFMIOBCL(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.JEIJLILCOEH(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x00112370 File Offset: 0x00110570
	public void LLILLNKOMHL()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1514f);
		this.filterText.fontSize = 1143f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1646f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 374f;
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x00112415 File Offset: 0x00110615
	private void NKADPEDEEFD()
	{
		AOBJLALDBAA.EHBBFMCILPC.PEFKJOKLEDL("app42error", new UnityAction(this.DLIDGPJMNKB));
		this.CJHBHLGFFFH();
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x00112438 File Offset: 0x00110638
	private void HGFJEBOBMIO(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.AKIJAODNANE();
			if (!this.GHPDJJCLHGM)
			{
				this.OOKPKOFMGOG();
				if ((JBBNEEHANHL)(-118) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("p", "");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)92 != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("KKK", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GFFAJPIGOHG(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = false;
			return;
		}
		this.LGDHPHBCECE();
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x001124C4 File Offset: 0x001106C4
	private void LLKABMKNJKM()
	{
		foreach (ThemeManager.CustomThemeProperties customThemeProperties in base.GetComponentInChildren<ThemeManager>().theme)
		{
			if (customThemeProperties.themeType == AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK())
			{
				this.PLLAMCJJCJB = customThemeProperties.themeColorText;
			}
		}
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x00112538 File Offset: 0x00110738
	public void DPBLLHJFPHN(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && !component.isOn);
		component.isOn = false;
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x00112568 File Offset: 0x00110768
	private void DLIDGPJMNKB()
	{
		this.LLKABMKNJKM();
		if (this.toggle.isOn)
		{
			this.FAGIPELEAHL();
			return;
		}
		this.LLDGGDDCGMA();
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x0011258C File Offset: 0x0011078C
	public void CPFBJPLKEJK()
	{
		try
		{
			this.LDLNNJLCFKJ();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.MFNKIDFPJAD(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x001125F4 File Offset: 0x001107F4
	public void LLDGGDDCGMA()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1905f);
		this.filterText.fontSize = 943f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 16f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 607f;
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x0011269C File Offset: 0x0011089C
	private void KOLFLJFLALN(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.HCEIMJKMGBA();
			if (!this.GHPDJJCLHGM)
			{
				this.HNMIMALACNE();
				if ((JBBNEEHANHL)(-128) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("OnApplicationFocusNeedToUpdateCurrency", "smpd");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)(-111) != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("</i>", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.SetItemOnCenter(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x00112726 File Offset: 0x00110926
	private void GINNCBBODJO()
	{
		this.NFBINBIAFBF();
		if (this.toggle.isOn)
		{
			this.SetActiveText();
			return;
		}
		this.CHPNKEKJIOI();
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x00112748 File Offset: 0x00110948
	private IEnumerator FMOGBDJAIAL(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.EMDHNFENFGN = null;
		yield break;
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x0011275E File Offset: 0x0011095E
	private void PPDPOBDELME()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.FAGIPELEAHL();
			return;
		}
		this.CHPNKEKJIOI();
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x00112780 File Offset: 0x00110980
	private void CPLOOMDNFFD()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("Asset bundle assets destroyed:", new UnityAction(this.GJDCIHEPBEI));
		this.NCCMMHMPKOC();
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x001127A4 File Offset: 0x001109A4
	public void SetActiveFilter(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && !component.isOn);
		component.isOn = true;
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x001127D4 File Offset: 0x001109D4
	public void OKIBNDEKHBE()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x00112834 File Offset: 0x00110A34
	private void AFMAHJBBGPB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("BackendOperationsManager.QueueRequestSaveSyncMoment(", new UnityAction(this.GJDCIHEPBEI));
		this.OAFENJMBMKB();
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x0011285F File Offset: 0x00110A5F
	private void GIAGKNDOADK()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().ONIBLJOFFPG("p", new UnityAction(this.MKAHJOCBLHF));
		this.LDLNNJLCFKJ();
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x00112748 File Offset: 0x00110948
	private IEnumerator POOLAPEBKFL(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.EMDHNFENFGN = null;
		yield break;
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x0011288C File Offset: 0x00110A8C
	public void NILGEIILBJF()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1506f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1688f;
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x00112748 File Offset: 0x00110948
	private IEnumerator AFLDKGNMODP(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.EMDHNFENFGN = null;
		yield break;
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x001128E5 File Offset: 0x00110AE5
	private void BPFIJKIPNEI()
	{
		this.NFBINBIAFBF();
		if (this.toggle.isOn)
		{
			this.CNAKPBIGGEB();
			return;
		}
		this.FDIMKFJBBLP();
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x00112748 File Offset: 0x00110948
	private IEnumerator COGNAMJLIOM(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.EMDHNFENFGN = null;
		yield break;
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x00112908 File Offset: 0x00110B08
	public void StopPulse()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x00112968 File Offset: 0x00110B68
	private void IJEPGGBEBNI()
	{
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("yes", new UnityAction(this.BLDPGLLGHFM));
		this.DLIDGPJMNKB();
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x0011298B File Offset: 0x00110B8B
	private void PMBLPNIPLGE()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.OJNMHNJOMMO();
			return;
		}
		this.FPCLNIIBBPH();
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x001129B0 File Offset: 0x00110BB0
	private void DGEAOIKLFJD()
	{
		foreach (ThemeManager.CustomThemeProperties customThemeProperties in base.GetComponentInChildren<ThemeManager>().theme)
		{
			if (customThemeProperties.themeType == AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL())
			{
				this.PLLAMCJJCJB = customThemeProperties.themeColorText;
			}
		}
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x00112A24 File Offset: 0x00110C24
	public void MFKDPFEGKMG(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.MPCBJEIMACA().IKMNGFIDCLM(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.GBHEKOKPNGF(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x00112AE8 File Offset: 0x00110CE8
	public void FDIMKFJBBLP()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 451f);
		this.filterText.fontSize = 1301f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 625f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 744f;
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x00112B8D File Offset: 0x00110D8D
	public void EBHBMHHNPCI()
	{
		this.filterText.text = CCOJBMMKNAP.AEELGGPEJCC().OHLNGCKIACD(this.id.ToString());
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x00112BB5 File Offset: 0x00110DB5
	private void NEKHLHGBMBP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("OnTryToFireNoteshowTimer", new UnityAction(this.BPFIJKIPNEI));
		this.StopPulse();
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x00112748 File Offset: 0x00110948
	private IEnumerator MFNKIDFPJAD(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.EMDHNFENFGN = null;
		yield break;
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x00112BE0 File Offset: 0x00110DE0
	public void HPPDJGIOPJA()
	{
		this.filterText.text = CCOJBMMKNAP.JINDKPHNLBK().OGKGHLHHAAI(this.id.ToString());
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x00112C08 File Offset: 0x00110E08
	public void HNHCBCCFJHF()
	{
		try
		{
			if (this.EMDHNFENFGN != null)
			{
				base.StopCoroutine(this.EMDHNFENFGN);
				this.EMDHNFENFGN = null;
			}
			if (null != this.filterIcon)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.filterIcon.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x00112C68 File Offset: 0x00110E68
	private void IHABJGIOFJK(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.EHNEKJPGGLM();
			if (!this.GHPDJJCLHGM)
			{
				this.CPFBJPLKEJK();
				if ((JBBNEEHANHL)(-33) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("no", "p");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)(-66) != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GFFAJPIGOHG(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.DKHMJOMBBDM();
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x00112CF2 File Offset: 0x00110EF2
	private void CJHBHLGFFFH()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.OMLPGBALONP();
			return;
		}
		this.DNGMMOGLOFP();
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x00112D14 File Offset: 0x00110F14
	public void FAGICHBNNBA(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (GHPDJJCLHGM && component.isOn);
		component.isOn = true;
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x00112D44 File Offset: 0x00110F44
	public void PulseIcon()
	{
		try
		{
			this.StopPulse();
			if (!(null == this.filterIcon) && base.gameObject.activeInHierarchy)
			{
				this.EMDHNFENFGN = base.StartCoroutine(this.FMOGBDJAIAL(this.filterIcon.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x00112DAC File Offset: 0x00110FAC
	public void KJCICFIMEDP(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.PEBMGCKFNAO().BDGPNPNIAPA(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = false;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.OOHJLJPPCOF(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x00112E70 File Offset: 0x00111070
	public void OnLanguageChange()
	{
		this.filterText.text = CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP(this.id.ToString());
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x00112E98 File Offset: 0x00111098
	public void BEPICOEHDGN(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.HJGDLOOHNLO().JLBEIFLLBLO(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.JEIJLILCOEH(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x00112F5C File Offset: 0x0011115C
	public void FPNHKJNILKO(bool GHPDJJCLHGM)
	{
		Toggle component = base.GetComponent<Toggle>();
		this.GHPDJJCLHGM = (!GHPDJJCLHGM || component.isOn);
		component.isOn = false;
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x00112F8C File Offset: 0x0011118C
	public void JHPPFFODNIB(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.PLJMLDOCPNM().OBDCPLLLGBB(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = true;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.FFLIDEPOFNH(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x00113050 File Offset: 0x00111250
	public void JAFEOBPLJDK()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 117f);
		this.filterText.fontSize = 719f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 1349f);
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 349f;
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x001130F5 File Offset: 0x001112F5
	private void EOAKHNIJECB()
	{
		AOBJLALDBAA.EHBBFMCILPC.FNMOFCMDFJP("", new UnityAction(this.BPFIJKIPNEI));
		this.FFJIEKNFAAK();
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x00113118 File Offset: 0x00111318
	public void OFEHCBCIPDE()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 698f);
		this.filterText.fontSize = 1764f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 775f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 827f;
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x001131C0 File Offset: 0x001113C0
	private void ECLDAJDOENE(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.PPPBIEDHGDO();
			if (!this.GHPDJJCLHGM)
			{
				this.CPFBJPLKEJK();
				if ((JBBNEEHANHL)(-93) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("gpshub", "");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)94 != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("eval", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GFFAJPIGOHG(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = false;
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x0011324C File Offset: 0x0011144C
	private void GBHEKOKPNGF(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.FAGIPELEAHL();
			if (!this.GHPDJJCLHGM)
			{
				this.OOKPKOFMGOG();
				if (JBBNEEHANHL.newFilterHorror != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("id", "CLIENT.SCREEN.REWARD.");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)(-4) != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("202", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GOJJEEIILJN(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = true;
			return;
		}
		this.LLILLNKOMHL();
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x001132D8 File Offset: 0x001114D8
	public void APHOENDINPF()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 963f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1342f;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x00113331 File Offset: 0x00111531
	private void MHBPJEDCLDM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().PBELMJCPJMK("", new UnityAction(this.BLDPGLLGHFM));
		this.OAFENJMBMKB();
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x0011335C File Offset: 0x0011155C
	private void MKAHJOCBLHF()
	{
		this.LLKABMKNJKM();
		if (this.toggle.isOn)
		{
			this.SetActiveText();
			return;
		}
		this.OFEHCBCIPDE();
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x00113380 File Offset: 0x00111580
	public void DKHMJOMBBDM()
	{
		this.filterIcon.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 28f);
		this.filterText.fontSize = 1773f;
		this.filterText.color = new Color(this.PLLAMCJJCJB.r, this.PLLAMCJJCJB.g, this.PLLAMCJJCJB.b, 792f);
		this.filterText.fontStyle = FontStyles.Bold;
		this.filterText.characterSpacing = 219f;
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x00113428 File Offset: 0x00111628
	private void PHFLDLIIGAB(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		if (this.toggle.isOn)
		{
			this.NILGEIILBJF();
			if (!this.GHPDJJCLHGM)
			{
				this.HNMIMALACNE();
				if ((JBBNEEHANHL)(-110) != GLOCCAIDHJC)
				{
					PlayerPrefs.SetString("", "socdnd");
				}
			}
			EKIFLHLCLKG(GLOCCAIDHJC);
			if ((JBBNEEHANHL)(-36) != GLOCCAIDHJC)
			{
				PlayerPrefs.SetString("CLIENT.AVATAR.TRINKET", GLOCCAIDHJC.ToString());
				PlayerPrefs.Save();
			}
			AFMIFFNPKOE.GOJJEEIILJN(base.transform, this.GHPDJJCLHGM);
			this.GHPDJJCLHGM = false;
			return;
		}
		this.LLILLNKOMHL();
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x001134B2 File Offset: 0x001116B2
	private void CBDIANHDGFK()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.HCEIMJKMGBA();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x001134D4 File Offset: 0x001116D4
	public void CNAKPBIGGEB()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 358f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 995f;
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x00113530 File Offset: 0x00111730
	public void LFPCCLGCPOP(JBBNEEHANHL GLOCCAIDHJC, UnityAction<JBBNEEHANHL> EKIFLHLCLKG, ScrollView2Controller AFMIFFNPKOE)
	{
		FilterItem.LGINLFHKMDA lginlfhkmda = new FilterItem.LGINLFHKMDA();
		lginlfhkmda.<>4__this = this;
		lginlfhkmda.filter = GLOCCAIDHJC;
		lginlfhkmda.filterItems = EKIFLHLCLKG;
		lginlfhkmda.scrollView2Controller = AFMIFFNPKOE;
		this.id = lginlfhkmda.filter;
		this.filterIcon.sprite = this.sprites[(int)lginlfhkmda.filter];
		this.filterIcon.SetNativeSize();
		this.filterText.text = CCOJBMMKNAP.PMABBOJDELF().OHLNGCKIACD(lginlfhkmda.filter.ToString());
		base.GetComponentInChildren<HDTrigger>().enabled = false;
		this.toggle.onValueChanged.AddListener(new UnityAction<bool>(lginlfhkmda.FKHKHDCHMJH));
		this.GGDLLLNNEDM(lginlfhkmda.filter, lginlfhkmda.filterItems, lginlfhkmda.scrollView2Controller);
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x001135F4 File Offset: 0x001117F4
	public void FEPLNBAMFGI()
	{
		this.filterIcon.color = Color.white;
		this.filterText.fontSize = 1434f;
		this.filterText.color = Color.white;
		this.filterText.fontStyle = FontStyles.Normal;
		this.filterText.characterSpacing = 1386f;
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x0011364D File Offset: 0x0011184D
	private void FFJIEKNFAAK()
	{
		this.GMNAIHCNMKL();
		if (this.toggle.isOn)
		{
			this.FEPLNBAMFGI();
			return;
		}
		this.SetInactiveText();
	}

	// Token: 0x04000BC4 RID: 3012
	[HideInInspector]
	public JBBNEEHANHL id;

	// Token: 0x04000BC5 RID: 3013
	public TextMeshProUGUI filterText;

	// Token: 0x04000BC6 RID: 3014
	public Toggle toggle;

	// Token: 0x04000BC7 RID: 3015
	public HorizontalLayoutGroup activeFilterHorizontalLayoutGroup;

	// Token: 0x04000BC8 RID: 3016
	public ContentSizeFitter activeFilterContentSizeFitter;

	// Token: 0x04000BC9 RID: 3017
	public Image filterIcon;

	// Token: 0x04000BCA RID: 3018
	public Sprite[] sprites;

	// Token: 0x04000BCB RID: 3019
	private Color PLLAMCJJCJB;

	// Token: 0x04000BCC RID: 3020
	private TextMeshProUGUI AFAAONAKNPI;

	// Token: 0x04000BCD RID: 3021
	private TextMeshProUGUI EHOJKOGLPBK;

	// Token: 0x04000BCE RID: 3022
	private bool GHPDJJCLHGM;

	// Token: 0x04000BCF RID: 3023
	private Coroutine EMDHNFENFGN;

	// Token: 0x0200011B RID: 283
	[CompilerGenerated]
	private sealed class LGINLFHKMDA
	{
		// Token: 0x060025DA RID: 9690 RVA: 0x001136DC File Offset: 0x001118DC
		internal void FKHKHDCHMJH(bool <p0>)
		{
			this.<>4__this.JEIJLILCOEH(this.filter, this.filterItems, this.scrollView2Controller);
		}

		// Token: 0x04000BD4 RID: 3028
		public FilterItem <>4__this;

		// Token: 0x04000BD5 RID: 3029
		public JBBNEEHANHL filter;

		// Token: 0x04000BD6 RID: 3030
		public UnityAction<JBBNEEHANHL> filterItems;

		// Token: 0x04000BD7 RID: 3031
		public ScrollView2Controller scrollView2Controller;
	}
}
