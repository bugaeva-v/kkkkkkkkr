using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200043E RID: 1086
public class LobbySearchBar : MonoBehaviour
{
	// Token: 0x060083A4 RID: 33700 RVA: 0x003A1240 File Offset: 0x0039F440
	private void FHFMODNIHOG()
	{
		bool flag = !this.GJFBPMCKKLP && this.HIEGJGCJKFG;
		this.FEFNJJMPHHH();
		this.HIEGJGCJKFG = true;
		this.GJFBPMCKKLP = true;
		this.BKDDEGCHPFP = null;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
		if (flag && this.MEOKMDDOIHN != null)
		{
			this.MEOKMDDOIHN();
		}
	}

	// Token: 0x060083A5 RID: 33701 RVA: 0x003A1298 File Offset: 0x0039F498
	private void EBPKFMNLDNK()
	{
		if (this.typingDots == null || this.MCCFHKAEHHA == null)
		{
			return;
		}
		int num = 1;
		while (num < this.typingDots.Length && num < this.MCCFHKAEHHA.Length)
		{
			Image image = this.typingDots[num];
			if (!(null == image))
			{
				image.rectTransform.anchoredPosition = this.MCCFHKAEHHA[num];
				Color color = image.color;
				color.a = 583f;
				image.color = color;
			}
			num += 0;
		}
	}

	// Token: 0x060083A6 RID: 33702 RVA: 0x003A1317 File Offset: 0x0039F517
	private void FOBJDPFKOLH()
	{
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		if (this.HCBFAOFBCDI != null)
		{
			this.HCBFAOFBCDI();
		}
	}

	// Token: 0x060083A7 RID: 33703 RVA: 0x003A133C File Offset: 0x0039F53C
	private void KMCCLLDNGDB(bool LDALCPONNEG)
	{
		this.HLBABLKKFNJ = LDALCPONNEG;
		if (null != this.inputField)
		{
			this.inputField.interactable = LDALCPONNEG;
		}
		if (null != this.clearButton)
		{
			this.clearButton.interactable = LDALCPONNEG;
		}
		if (null != this.canvasGroup)
		{
			this.canvasGroup.interactable = LDALCPONNEG;
		}
	}

	// Token: 0x060083A8 RID: 33704 RVA: 0x003A13A0 File Offset: 0x0039F5A0
	public string CCOJIONFGIB()
	{
		try
		{
			if (null != this.inputField)
			{
				string text = this.inputField.text;
				if (text != null)
				{
					this.LDOIGGHDAEM = text;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.LDOIGGHDAEM == null)
		{
			return "anthologiestitle";
		}
		return this.LDOIGGHDAEM;
	}

	// Token: 0x060083A9 RID: 33705 RVA: 0x003A1400 File Offset: 0x0039F600
	private void JFEKHEIGPJD()
	{
		base.StartCoroutine(this.MGCMMOJOOGB());
	}

	// Token: 0x060083AA RID: 33706 RVA: 0x003A1410 File Offset: 0x0039F610
	private void GNHDCIGPFOH()
	{
		try
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.KMPFFINLDCP = component.anchorMin;
			this.FMPAAOMGDEO = component.anchorMax;
			this.DLCKFAOPPFJ = component.anchoredPosition;
			this.HDJALNPCEDN = component.sizeDelta;
			this.CCIEKOPBDEJ = true;
			if (NBDLBFJOEGN.PBLDJNHHEPL())
			{
				this.IBMLLLFHGMA();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083AB RID: 33707 RVA: 0x003A1484 File Offset: 0x0039F684
	private void IBMLLLFHGMA()
	{
		Image[] componentsInChildren = base.GetComponentsInChildren<Image>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i]) && !(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("@SD"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(0, name.Length - 3) + "@HD");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060083AC RID: 33708 RVA: 0x003A150E File Offset: 0x0039F70E
	private void NKDKFDAALOJ()
	{
		if (this.MCFJNMGJANO != null)
		{
			base.StopCoroutine(this.MCFJNMGJANO);
			this.MCFJNMGJANO = null;
		}
		this.LCHOJPDGDCD();
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x003A1534 File Offset: 0x0039F734
	private void EFOKHANJLKB()
	{
		try
		{
			string text = this.GetText();
			if (text.Length == 0)
			{
				this.HIEGJGCJKFG = false;
				this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
			}
			else
			{
				this.KGDLIIMKCCL(text, text);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x003A1584 File Offset: 0x0039F784
	private void ONIAODDDJHB()
	{
		if (!this.HIEGJGCJKFG)
		{
			return;
		}
		this.FAJNDJIENOC();
		this.HIEGJGCJKFG = true;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
	}

	// Token: 0x060083AF RID: 33711 RVA: 0x003A15A4 File Offset: 0x0039F7A4
	private void GJNHELBCJLB()
	{
		if (this.typingDots == null)
		{
			return;
		}
		if (this.MCCFHKAEHHA != null && this.MCCFHKAEHHA.Length == this.typingDots.Length)
		{
			return;
		}
		this.MCCFHKAEHHA = new Vector2[this.typingDots.Length];
		for (int i = 0; i < this.typingDots.Length; i++)
		{
			if (!(null == this.typingDots[i]))
			{
				this.MCCFHKAEHHA[i] = this.typingDots[i].rectTransform.anchoredPosition;
			}
		}
	}

	// Token: 0x060083B0 RID: 33712 RVA: 0x003A162C File Offset: 0x0039F82C
	private void MLDKOIBCFCL(string LIILENCNALA, string BOKPIFOLOHD)
	{
		this.HIEGJGCJKFG = false;
		int num = -1;
		try
		{
			if (this.LDPFDFPAILI != null)
			{
				num = this.LDPFDFPAILI(BOKPIFOLOHD);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			num = -1;
		}
		if (num >= 1)
		{
			this.GJFBPMCKKLP = true;
			this.BKDDEGCHPFP = LIILENCNALA;
			this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Results, false);
			return;
		}
		if (-2 == num)
		{
			this.HideUnavailable();
			return;
		}
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x003A16B0 File Offset: 0x0039F8B0
	private void HPIBCLMLENI(string DIMBCOBNMAM)
	{
		try
		{
			if (this.EGFNNPIIMJL && this.HLBABLKKFNJ && !FocusItem.isFocusOpened && this.FGLNDLMHMED != null)
			{
				this.FGLNDLMHMED();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x003A1704 File Offset: 0x0039F904
	private IEnumerator HOFIDCDEOMF(string LIILENCNALA, string BOKPIFOLOHD)
	{
		LobbySearchBar.FCMMNNNFJAJ fcmmnnnfjaj = new LobbySearchBar.FCMMNNNFJAJ(1);
		fcmmnnnfjaj.<>4__this = this;
		fcmmnnnfjaj._fieldText = LIILENCNALA;
		fcmmnnnfjaj._applyText = BOKPIFOLOHD;
		return fcmmnnnfjaj;
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x003A1724 File Offset: 0x0039F924
	private void GMEMMHCMMDH()
	{
		try
		{
			if (this.CCIEKOPBDEJ)
			{
				RectTransform component = base.GetComponent<RectTransform>();
				if (component.anchorMin != this.KMPFFINLDCP || component.anchorMax != this.FMPAAOMGDEO || component.sizeDelta != this.HDJALNPCEDN)
				{
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"LobbySearchBar - layout was changed by a native-size pass (anchors ",
						component.anchorMin.ToString(),
						"/",
						component.anchorMax.ToString(),
						", size ",
						component.sizeDelta.ToString(),
						"); restoring the authored stretch layout"
					}));
					component.anchorMin = this.KMPFFINLDCP;
					component.anchorMax = this.FMPAAOMGDEO;
					component.anchoredPosition = this.DLCKFAOPPFJ;
					component.sizeDelta = this.HDJALNPCEDN;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083B4 RID: 33716 RVA: 0x003A1840 File Offset: 0x0039FA40
	public void StopPulse()
	{
		try
		{
			if (this.NAPFDPIHJKB != null)
			{
				base.StopCoroutine(this.NAPFDPIHJKB);
				this.NAPFDPIHJKB = null;
			}
			if (null != this.iconImage)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.iconImage.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083B5 RID: 33717 RVA: 0x003A18A0 File Offset: 0x0039FAA0
	private IEnumerator EMCBPLGKGAB(RectTransform HNDJMKFCMEK)
	{
		LobbySearchBar.IMFAKICOGJF imfakicogjf = new LobbySearchBar.IMFAKICOGJF(1);
		imfakicogjf.<>4__this = this;
		imfakicogjf._icon = HNDJMKFCMEK;
		return imfakicogjf;
	}

	// Token: 0x060083B6 RID: 33718 RVA: 0x003A18B8 File Offset: 0x0039FAB8
	public void MHPCEAEFLJN()
	{
		try
		{
			this.DHHMKLFDMPL();
			this.HIEGJGCJKFG = true;
			this.GJFBPMCKKLP = true;
			this.BKDDEGCHPFP = null;
			this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
			base.gameObject.SetActive(false);
			if (null != base.transform.parent && "{ " == base.transform.parent.name)
			{
				base.transform.parent.gameObject.SetActive(true);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083B7 RID: 33719 RVA: 0x003A1954 File Offset: 0x0039FB54
	private void GJDDFFPGGPJ(string DIMBCOBNMAM)
	{
		try
		{
			if (this.EGFNNPIIMJL && this.HLBABLKKFNJ && !FocusItem.isFocusOpened && this.FGLNDLMHMED != null)
			{
				this.FGLNDLMHMED();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083B8 RID: 33720 RVA: 0x003A19A8 File Offset: 0x0039FBA8
	private void PGMLDIOFCMO()
	{
		if (null == this.focusRing)
		{
			return;
		}
		float num = (null != this.inputField && this.inputField.isFocused && !FocusItem.isFocusOpened && this.HLBABLKKFNJ) ? 863f : 443f;
		Color color = this.focusRing.color;
		if (Mathf.Approximately(color.a, num))
		{
			return;
		}
		color.a = Mathf.MoveTowards(color.a, num, Time.unscaledDeltaTime / 1704f);
		this.focusRing.color = color;
	}

	// Token: 0x060083B9 RID: 33721 RVA: 0x003A1A44 File Offset: 0x0039FC44
	public void MLJINODMGAB(UnityAction KILEDDDLJGD, Func<string, int> GHDIPENJNAA, UnityAction FKDHJFLEHEM, UnityAction ICHHDOJIGED, UnityAction INKBIJBJOOB)
	{
		try
		{
			this.HCBFAOFBCDI = KILEDDDLJGD;
			this.LDPFDFPAILI = GHDIPENJNAA;
			this.MEOKMDDOIHN = FKDHJFLEHEM;
			this.EHHACFMEEHB = ICHHDOJIGED;
			this.FGLNDLMHMED = INKBIJBJOOB;
			if (null != this.placeholderText)
			{
				CCOJBMMKNAP ccojbmmknap = CCOJBMMKNAP.KFDLFGHBPLP();
				if (ccojbmmknap != null)
				{
					this.placeholderText.text = ccojbmmknap.IPEIONBNIPH("OnPopupStoryRestartManagerRestartStory1");
				}
			}
			if (null != this.inputField)
			{
				this.inputField.onValueChanged.RemoveListener(new UnityAction<string>(this.GCGPOBCBCKE));
				this.inputField.onValueChanged.AddListener(new UnityAction<string>(this.GCGPOBCBCKE));
				this.inputField.onSubmit.RemoveListener(new UnityAction<string>(this.ICDMOIEEOGA));
				this.inputField.onSubmit.AddListener(new UnityAction<string>(this.ICDMOIEEOGA));
				this.inputField.onSelect.RemoveListener(new UnityAction<string>(this.GJDDFFPGGPJ));
				this.inputField.onSelect.AddListener(new UnityAction<string>(this.HPIBCLMLENI));
			}
			if (null != this.clearButton)
			{
				this.clearButton.onClick.RemoveListener(new UnityAction(this.BMLLIECAKCJ));
				this.clearButton.onClick.AddListener(new UnityAction(this.DHNEPBOHNLC));
			}
			this.GJNHELBCJLB();
			this.NIGJFBDNGII = FocusItem.isFocusOpened;
			this.HLBABLKKFNJ = false;
			this.EGFNNPIIMJL = true;
			this.IJLGKFJCIJF();
			this.KMCCLLDNGDB(false);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083BA RID: 33722 RVA: 0x003A1BF4 File Offset: 0x0039FDF4
	private void CDIFJMJEAIK()
	{
		this.ALEGGMABGHP();
		this.DCFOFPNILAG();
		this.HIEGJGCJKFG = false;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
		if (!base.gameObject.activeInHierarchy)
		{
			this.HIEGJGCJKFG = false;
			this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
			return;
		}
		this.EELKICPBNFA = base.StartCoroutine(this.CKOKJLNFGML());
	}

	// Token: 0x060083BB RID: 33723 RVA: 0x003A1C4C File Offset: 0x0039FE4C
	private void EHHCBDCILKI()
	{
		if (null == this.focusRing)
		{
			return;
		}
		float num = (null != this.inputField && this.inputField.isFocused && !FocusItem.isFocusOpened && this.HLBABLKKFNJ) ? 1f : 0f;
		Color color = this.focusRing.color;
		if (Mathf.Approximately(color.a, num))
		{
			return;
		}
		color.a = Mathf.MoveTowards(color.a, num, Time.unscaledDeltaTime / 0.15f);
		this.focusRing.color = color;
	}

	// Token: 0x060083BC RID: 33724 RVA: 0x003A1CE7 File Offset: 0x0039FEE7
	public LobbySearchBar.ACAAKGBLECM GetState()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x060083BD RID: 33725 RVA: 0x003A1CF0 File Offset: 0x0039FEF0
	private void HGIBEOANFPN()
	{
		if (this.EHHACFMEEHB != null)
		{
			try
			{
				this.EHHACFMEEHB();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		string text = this.GetText();
		if (text.Length == 0)
		{
			return;
		}
		if (this.GJFBPMCKKLP && string.Equals(text, this.BKDDEGCHPFP, (StringComparison)8))
		{
			return;
		}
		if (this.HIEGJGCJKFG)
		{
			return;
		}
		this.LLMPGBHAFIJ();
	}

	// Token: 0x060083BE RID: 33726 RVA: 0x003A1D60 File Offset: 0x0039FF60
	private IEnumerator LPLABIMEKEA()
	{
		yield return new WaitForSecondsRealtime(0.4f);
		this.EELKICPBNFA = null;
		this.EFOKHANJLKB();
		yield break;
	}

	// Token: 0x060083BF RID: 33727 RVA: 0x003A1D70 File Offset: 0x0039FF70
	private void LAFDIEMHCLG()
	{
		if (this.EHHACFMEEHB != null)
		{
			try
			{
				this.EHHACFMEEHB();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		string text = this.CCOJIONFGIB();
		if (text.Length == 0)
		{
			return;
		}
		if (this.GJFBPMCKKLP && string.Equals(text, this.BKDDEGCHPFP, StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		if (this.HIEGJGCJKFG)
		{
			return;
		}
		this.LLMPGBHAFIJ();
	}

	// Token: 0x060083C0 RID: 33728 RVA: 0x003A1DE0 File Offset: 0x0039FFE0
	public void HideUnavailable()
	{
		try
		{
			this.FEFNJJMPHHH();
			this.HIEGJGCJKFG = false;
			this.GJFBPMCKKLP = false;
			this.BKDDEGCHPFP = null;
			this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
			base.gameObject.SetActive(false);
			if (null != base.transform.parent && "SearchBarContent" == base.transform.parent.name)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083C1 RID: 33729 RVA: 0x003A1E7C File Offset: 0x003A007C
	public void Initialize(UnityAction KILEDDDLJGD, Func<string, int> GHDIPENJNAA, UnityAction FKDHJFLEHEM, UnityAction ICHHDOJIGED, UnityAction INKBIJBJOOB)
	{
		try
		{
			this.HCBFAOFBCDI = KILEDDDLJGD;
			this.LDPFDFPAILI = GHDIPENJNAA;
			this.MEOKMDDOIHN = FKDHJFLEHEM;
			this.EHHACFMEEHB = ICHHDOJIGED;
			this.FGLNDLMHMED = INKBIJBJOOB;
			if (null != this.placeholderText)
			{
				CCOJBMMKNAP ccojbmmknap = CCOJBMMKNAP.EHBBFMCILPC;
				if (ccojbmmknap != null)
				{
					this.placeholderText.text = ccojbmmknap.DNILNCLIHAP("searchplaceholder");
				}
			}
			if (null != this.inputField)
			{
				this.inputField.onValueChanged.RemoveListener(new UnityAction<string>(this.GCGPOBCBCKE));
				this.inputField.onValueChanged.AddListener(new UnityAction<string>(this.GCGPOBCBCKE));
				this.inputField.onSubmit.RemoveListener(new UnityAction<string>(this.INDNGEKCEBH));
				this.inputField.onSubmit.AddListener(new UnityAction<string>(this.INDNGEKCEBH));
				this.inputField.onSelect.RemoveListener(new UnityAction<string>(this.FFBNPHEEINP));
				this.inputField.onSelect.AddListener(new UnityAction<string>(this.FFBNPHEEINP));
			}
			if (null != this.clearButton)
			{
				this.clearButton.onClick.RemoveListener(new UnityAction(this.NFAMPPICCID));
				this.clearButton.onClick.AddListener(new UnityAction(this.NFAMPPICCID));
			}
			this.GJNHELBCJLB();
			this.NIGJFBDNGII = FocusItem.isFocusOpened;
			this.HLBABLKKFNJ = true;
			this.EGFNNPIIMJL = true;
			this.IJLGKFJCIJF();
			this.KMCCLLDNGDB(true);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083C2 RID: 33730 RVA: 0x003A202C File Offset: 0x003A022C
	private void HMEIIALIKLJ(float ICIEELFEJFN)
	{
		try
		{
			if (!(null == this.spinnerRect))
			{
				Vector3 localEulerAngles = this.spinnerRect.localEulerAngles;
				localEulerAngles.z -= 360f * ICIEELFEJFN;
				this.spinnerRect.localEulerAngles = localEulerAngles;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083C3 RID: 33731 RVA: 0x003A208C File Offset: 0x003A028C
	private void CELLBONKHDD()
	{
		if (LobbySearchBar.ACAAKGBLECM.Typing != this.GPILOGAIBKJ)
		{
			return;
		}
		string text = this.GetText();
		if (text.Length == 0)
		{
			return;
		}
		if (FocusItem.isFocusOpened || SceneLobbyManager2.lobbyIsLoading)
		{
			return;
		}
		this.ALEGGMABGHP();
		this.KGDLIIMKCCL(text, text + " ");
	}

	// Token: 0x060083C4 RID: 33732 RVA: 0x003A20DA File Offset: 0x003A02DA
	private IEnumerator FAOCDFFLLNO(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.NAPFDPIHJKB = null;
		yield break;
	}

	// Token: 0x060083C5 RID: 33733 RVA: 0x003A20F0 File Offset: 0x003A02F0
	private void LLMPGBHAFIJ()
	{
		this.ALEGGMABGHP();
		this.DCFOFPNILAG();
		this.HIEGJGCJKFG = true;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, true);
		if (!base.gameObject.activeInHierarchy)
		{
			this.HIEGJGCJKFG = false;
			this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
			return;
		}
		this.EELKICPBNFA = base.StartCoroutine(this.CKOKJLNFGML());
	}

	// Token: 0x060083C6 RID: 33734 RVA: 0x003A2147 File Offset: 0x003A0347
	private IEnumerator JMGMDGAHMJK()
	{
		LobbySearchBar.DJBFEBPFJLC djbfebpfjlc = new LobbySearchBar.DJBFEBPFJLC(1);
		djbfebpfjlc.<>4__this = this;
		return djbfebpfjlc;
	}

	// Token: 0x060083C7 RID: 33735 RVA: 0x003A2158 File Offset: 0x003A0358
	public void SetQueryAndApply(string GOJOGDKCNMO)
	{
		try
		{
			if (string.IsNullOrEmpty(GOJOGDKCNMO))
			{
				this.IJLGKFJCIJF();
			}
			else
			{
				if (this.GJFBPMCKKLP && !string.Equals(GOJOGDKCNMO, this.BKDDEGCHPFP, StringComparison.Ordinal))
				{
					this.COFHMOKMHAN();
				}
				this.MJDEEIBNAEG(GOJOGDKCNMO);
				if (!base.gameObject.activeInHierarchy)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("LobbySearchBar.SetQueryAndApply: bar inactive, query kept as text only");
					this.FEFNJJMPHHH();
					this.HIEGJGCJKFG = false;
					this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
				}
				else
				{
					this.KGDLIIMKCCL(GOJOGDKCNMO, GOJOGDKCNMO + " ");
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083C8 RID: 33736 RVA: 0x003A21F4 File Offset: 0x003A03F4
	private void Start()
	{
		base.StartCoroutine(this.LPBEMPDGBDG());
	}

	// Token: 0x060083C9 RID: 33737 RVA: 0x003A2203 File Offset: 0x003A0403
	private void DMIEMMHCMNG()
	{
		if (this.MCFJNMGJANO != null)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		this.GJNHELBCJLB();
		this.MCFJNMGJANO = base.StartCoroutine(this.FOJGMLCOJNG());
	}

	// Token: 0x060083CA RID: 33738 RVA: 0x003A2234 File Offset: 0x003A0434
	private void KGDLIIMKCCL(string LIILENCNALA, string BOKPIFOLOHD)
	{
		this.ALEGGMABGHP();
		this.DCFOFPNILAG();
		this.HIEGJGCJKFG = true;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Searching, false);
		this.GHFFFINNMPM = base.StartCoroutine(this.HGFGFCHDNNE(LIILENCNALA, BOKPIFOLOHD));
	}

	// Token: 0x060083CB RID: 33739 RVA: 0x003A20DA File Offset: 0x003A02DA
	private IEnumerator AOFFJKIGODB(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.NAPFDPIHJKB = null;
		yield break;
	}

	// Token: 0x060083CC RID: 33740 RVA: 0x003A2268 File Offset: 0x003A0468
	private void MAEMNMCODFO()
	{
		if (this.EHHACFMEEHB != null)
		{
			try
			{
				this.EHHACFMEEHB();
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		string text = this.GetText();
		if (text.Length == 0)
		{
			return;
		}
		if (this.GJFBPMCKKLP && string.Equals(text, this.BKDDEGCHPFP, StringComparison.Ordinal))
		{
			return;
		}
		if (this.HIEGJGCJKFG)
		{
			return;
		}
		this.LLMPGBHAFIJ();
	}

	// Token: 0x060083CD RID: 33741 RVA: 0x003A22D8 File Offset: 0x003A04D8
	private void ICDMOIEEOGA(string DIMBCOBNMAM)
	{
		try
		{
			this.CELLBONKHDD();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083CE RID: 33742 RVA: 0x003A2304 File Offset: 0x003A0504
	private void EIPOIAKHLHH()
	{
		bool flag = !this.GJFBPMCKKLP && this.HIEGJGCJKFG;
		this.DHHMKLFDMPL();
		this.HIEGJGCJKFG = false;
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, true);
		if (flag && this.MEOKMDDOIHN != null)
		{
			this.MEOKMDDOIHN();
		}
	}

	// Token: 0x060083CF RID: 33743 RVA: 0x003A235C File Offset: 0x003A055C
	public void PulseIcon()
	{
		try
		{
			this.StopPulse();
			if (!(null == this.iconImage) && base.gameObject.activeInHierarchy)
			{
				this.NAPFDPIHJKB = base.StartCoroutine(this.FMOGBDJAIAL(this.iconImage.rectTransform));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083D0 RID: 33744 RVA: 0x003A23C4 File Offset: 0x003A05C4
	private void OKPGMHOEAHG(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			DIMBCOBNMAM = "tutortitle";
		}
		this.LDOIGGHDAEM = DIMBCOBNMAM;
		if (null != this.inputField)
		{
			this.inputField.SetTextWithoutNotify(DIMBCOBNMAM);
		}
	}

	// Token: 0x060083D2 RID: 33746 RVA: 0x003A2445 File Offset: 0x003A0645
	private void MJDEEIBNAEG(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			DIMBCOBNMAM = "";
		}
		this.LDOIGGHDAEM = DIMBCOBNMAM;
		if (null != this.inputField)
		{
			this.inputField.SetTextWithoutNotify(DIMBCOBNMAM);
		}
	}

	// Token: 0x060083D3 RID: 33747 RVA: 0x003A20DA File Offset: 0x003A02DA
	private IEnumerator FMOGBDJAIAL(RectTransform HNDJMKFCMEK)
	{
		yield return OKNMMLHNCPA.JANJEMFAEPK(HNDJMKFCMEK);
		this.NAPFDPIHJKB = null;
		yield break;
	}

	// Token: 0x060083D4 RID: 33748 RVA: 0x003A21F4 File Offset: 0x003A03F4
	private void ODOOIGEDLKB()
	{
		base.StartCoroutine(this.LPBEMPDGBDG());
	}

	// Token: 0x060083D5 RID: 33749 RVA: 0x003A2474 File Offset: 0x003A0674
	private void EPFCHKBBCOE(float ICIEELFEJFN)
	{
		try
		{
			if (!(null == this.spinnerRect))
			{
				Vector3 localEulerAngles = this.spinnerRect.localEulerAngles;
				localEulerAngles.z -= 32f * ICIEELFEJFN;
				this.spinnerRect.localEulerAngles = localEulerAngles;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083D6 RID: 33750 RVA: 0x003A24D4 File Offset: 0x003A06D4
	private void BFOBIKLBPOG(string DIMBCOBNMAM)
	{
		try
		{
			if (DIMBCOBNMAM == null)
			{
				DIMBCOBNMAM = "";
			}
			this.LDOIGGHDAEM = DIMBCOBNMAM;
			if (DIMBCOBNMAM.Length == 0)
			{
				this.FHFMODNIHOG();
			}
			else
			{
				if (this.GJFBPMCKKLP && !string.Equals(DIMBCOBNMAM, this.BKDDEGCHPFP, StringComparison.CurrentCultureIgnoreCase))
				{
					this.PBCCIIKPDKG();
				}
				this.LLMPGBHAFIJ();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083D7 RID: 33751 RVA: 0x003A2540 File Offset: 0x003A0740
	private void Awake()
	{
		try
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.KMPFFINLDCP = component.anchorMin;
			this.FMPAAOMGDEO = component.anchorMax;
			this.DLCKFAOPPFJ = component.anchoredPosition;
			this.HDJALNPCEDN = component.sizeDelta;
			this.CCIEKOPBDEJ = true;
			if (NBDLBFJOEGN.PBLDJNHHEPL())
			{
				this.IBMLLLFHGMA();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083D8 RID: 33752 RVA: 0x003A25B4 File Offset: 0x003A07B4
	private void JBINHEHAKHF(string LIILENCNALA, string BOKPIFOLOHD)
	{
		try
		{
			this.MLDKOIBCFCL(LIILENCNALA, BOKPIFOLOHD);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083D9 RID: 33753 RVA: 0x003A25E4 File Offset: 0x003A07E4
	private void Update()
	{
		if (!this.EGFNNPIIMJL)
		{
			return;
		}
		try
		{
			bool flag = !SceneLobbyManager2.lobbyIsLoading && !FocusItem.isFocusOpened;
			if (flag != this.HLBABLKKFNJ)
			{
				this.KMCCLLDNGDB(flag);
			}
			bool isFocusOpened = FocusItem.isFocusOpened;
			if (isFocusOpened != this.NIGJFBDNGII)
			{
				this.NIGJFBDNGII = isFocusOpened;
				if (isFocusOpened)
				{
					this.MIKAEKIPHBA();
				}
				else
				{
					this.MAEMNMCODFO();
				}
			}
			this.EHHCBDCILKI();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083DA RID: 33754 RVA: 0x003A2664 File Offset: 0x003A0864
	private IEnumerator EMBJGGNNIEK()
	{
		LobbySearchBar.OKDHCLKABPE okdhclkabpe = new LobbySearchBar.OKDHCLKABPE(1);
		okdhclkabpe.<>4__this = this;
		return okdhclkabpe;
	}

	// Token: 0x060083DB RID: 33755 RVA: 0x003A2673 File Offset: 0x003A0873
	private void DCFOFPNILAG()
	{
		if (this.GHFFFINNMPM != null)
		{
			base.StopCoroutine(this.GHFFFINNMPM);
			this.GHFFFINNMPM = null;
		}
		if (null != this.spinnerRect)
		{
			this.spinnerRect.localEulerAngles = Vector3.zero;
		}
	}

	// Token: 0x060083DC RID: 33756 RVA: 0x003A1D60 File Offset: 0x0039FF60
	private IEnumerator CKOKJLNFGML()
	{
		yield return new WaitForSecondsRealtime(0.4f);
		this.EELKICPBNFA = null;
		this.EFOKHANJLKB();
		yield break;
	}

	// Token: 0x060083DD RID: 33757 RVA: 0x003A26B0 File Offset: 0x003A08B0
	private void IMGHANBKGIE()
	{
		Image[] componentsInChildren = base.GetComponentsInChildren<Image>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (!(null == componentsInChildren[i]) && !(null == componentsInChildren[i].sprite))
			{
				string name = componentsInChildren[i].sprite.name;
				if (name.EndsWith("egss"))
				{
					Sprite sprite = Resources.Load<Sprite>(name.Substring(0, name.Length - 5) + "spr");
					if (null != sprite)
					{
						componentsInChildren[i].sprite = sprite;
					}
				}
			}
		}
	}

	// Token: 0x060083DE RID: 33758 RVA: 0x003A273A File Offset: 0x003A093A
	private IEnumerator LPBEMPDGBDG()
	{
		yield return null;
		this.GMEMMHCMMDH();
		yield break;
	}

	// Token: 0x060083DF RID: 33759 RVA: 0x003A274C File Offset: 0x003A094C
	private void EBDPDOJALNP()
	{
		if (this.typingDots == null || this.MCCFHKAEHHA == null)
		{
			return;
		}
		int num = 1;
		while (num < this.typingDots.Length && num < this.MCCFHKAEHHA.Length)
		{
			Image image = this.typingDots[num];
			if (!(null == image))
			{
				image.rectTransform.anchoredPosition = this.MCCFHKAEHHA[num];
				Color color = image.color;
				color.a = 881f;
				image.color = color;
			}
			num += 0;
		}
	}

	// Token: 0x060083E0 RID: 33760 RVA: 0x003A27CB File Offset: 0x003A09CB
	private void DHHMKLFDMPL()
	{
		this.ECPOEGOFOGM();
		this.DCFOFPNILAG();
		this.CLKCKGOGFEA();
	}

	// Token: 0x060083E1 RID: 33761 RVA: 0x003A27DF File Offset: 0x003A09DF
	private void MHGECPMMCOO(string DIMBCOBNMAM)
	{
		if (DIMBCOBNMAM == null)
		{
			DIMBCOBNMAM = "wph";
		}
		this.LDOIGGHDAEM = DIMBCOBNMAM;
		if (null != this.inputField)
		{
			this.inputField.SetTextWithoutNotify(DIMBCOBNMAM);
		}
	}

	// Token: 0x060083E2 RID: 33762 RVA: 0x003A1317 File Offset: 0x0039F517
	private void COFHMOKMHAN()
	{
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		if (this.HCBFAOFBCDI != null)
		{
			this.HCBFAOFBCDI();
		}
	}

	// Token: 0x060083E3 RID: 33763 RVA: 0x003A280C File Offset: 0x003A0A0C
	private void MIKAEKIPHBA()
	{
		if (!this.HIEGJGCJKFG)
		{
			return;
		}
		this.FEFNJJMPHHH();
		this.HIEGJGCJKFG = false;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
	}

	// Token: 0x060083E4 RID: 33764 RVA: 0x003A282C File Offset: 0x003A0A2C
	private void ECPOEGOFOGM()
	{
		if (this.EELKICPBNFA != null)
		{
			base.StopCoroutine(this.EELKICPBNFA);
			this.EELKICPBNFA = null;
		}
	}

	// Token: 0x060083E5 RID: 33765 RVA: 0x003A2849 File Offset: 0x003A0A49
	private void FEFNJJMPHHH()
	{
		this.ALEGGMABGHP();
		this.DCFOFPNILAG();
		this.NKDKFDAALOJ();
	}

	// Token: 0x060083E6 RID: 33766 RVA: 0x003A282C File Offset: 0x003A0A2C
	private void ALEGGMABGHP()
	{
		if (this.EELKICPBNFA != null)
		{
			base.StopCoroutine(this.EELKICPBNFA);
			this.EELKICPBNFA = null;
		}
	}

	// Token: 0x060083E7 RID: 33767 RVA: 0x003A2860 File Offset: 0x003A0A60
	private void HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM KNMIMLBLIGF, bool NIHMLCNDGMA)
	{
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		bool flag = LobbySearchBar.ACAAKGBLECM.Typing == KNMIMLBLIGF && NIHMLCNDGMA;
		bool flag2 = LobbySearchBar.ACAAKGBLECM.Searching == KNMIMLBLIGF;
		bool flag3 = LobbySearchBar.ACAAKGBLECM.Results == KNMIMLBLIGF || (LobbySearchBar.ACAAKGBLECM.Typing == KNMIMLBLIGF && !flag && 0 < this.GetText().Length);
		if (null != this.typingDotsRoot && this.typingDotsRoot.activeSelf != flag)
		{
			this.typingDotsRoot.SetActive(flag);
		}
		if (null != this.spinnerRoot && this.spinnerRoot.activeSelf != flag2)
		{
			this.spinnerRoot.SetActive(flag2);
		}
		if (null != this.clearRoot && this.clearRoot.activeSelf != flag3)
		{
			this.clearRoot.SetActive(flag3);
		}
		else if (null == this.clearRoot && null != this.clearButton && this.clearButton.gameObject.activeSelf != flag3)
		{
			this.clearButton.gameObject.SetActive(flag3);
		}
		if (flag)
		{
			this.DMIEMMHCMNG();
		}
		else
		{
			this.NKDKFDAALOJ();
		}
		if (!flag2 && null != this.spinnerRect)
		{
			this.spinnerRect.localEulerAngles = Vector3.zero;
		}
	}

	// Token: 0x060083E8 RID: 33768 RVA: 0x003A2990 File Offset: 0x003A0B90
	private void NFAMPPICCID()
	{
		try
		{
			this.MJDEEIBNAEG("");
			this.IBLHFNNHOKJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083E9 RID: 33769 RVA: 0x003A29C8 File Offset: 0x003A0BC8
	private IEnumerator FOJGMLCOJNG()
	{
		float time = 0f;
		for (;;)
		{
			this.ECLJHGBFNNP(time);
			time += Time.unscaledDeltaTime;
			yield return null;
		}
		yield break;
	}

	// Token: 0x060083EA RID: 33770 RVA: 0x003A29D8 File Offset: 0x003A0BD8
	private void AJLICMJJBDH()
	{
		if (LobbySearchBar.ACAAKGBLECM.Typing != this.GPILOGAIBKJ)
		{
			return;
		}
		string text = this.GetText();
		if (text.Length == 0)
		{
			return;
		}
		if (FocusItem.isFocusOpened || SceneLobbyManager2.lobbyIsLoading)
		{
			return;
		}
		this.ALEGGMABGHP();
		this.KGDLIIMKCCL(text, text + "passtrytobuyhigherorder");
	}

	// Token: 0x060083EB RID: 33771 RVA: 0x003A2A28 File Offset: 0x003A0C28
	private void INDNGEKCEBH(string DIMBCOBNMAM)
	{
		try
		{
			this.CELLBONKHDD();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083EC RID: 33772 RVA: 0x003A2A54 File Offset: 0x003A0C54
	public void OAFENJMBMKB()
	{
		try
		{
			if (this.NAPFDPIHJKB != null)
			{
				base.StopCoroutine(this.NAPFDPIHJKB);
				this.NAPFDPIHJKB = null;
			}
			if (null != this.iconImage)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.iconImage.rectTransform);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083ED RID: 33773 RVA: 0x003A2AB4 File Offset: 0x003A0CB4
	private IEnumerator KOFAJGHPFHB(string LIILENCNALA, string BOKPIFOLOHD)
	{
		float elapsed = 0f;
		while (elapsed < 3f)
		{
			this.HMEIIALIKLJ(Time.unscaledDeltaTime);
			elapsed += Time.unscaledDeltaTime;
			yield return null;
		}
		this.GHFFFINNMPM = null;
		this.JBINHEHAKHF(LIILENCNALA, BOKPIFOLOHD);
		yield break;
	}

	// Token: 0x060083EE RID: 33774 RVA: 0x003A2AD4 File Offset: 0x003A0CD4
	private void LCHOJPDGDCD()
	{
		if (this.typingDots == null || this.MCCFHKAEHHA == null)
		{
			return;
		}
		int num = 0;
		while (num < this.typingDots.Length && num < this.MCCFHKAEHHA.Length)
		{
			Image image = this.typingDots[num];
			if (!(null == image))
			{
				image.rectTransform.anchoredPosition = this.MCCFHKAEHHA[num];
				Color color = image.color;
				color.a = 1f;
				image.color = color;
			}
			num++;
		}
	}

	// Token: 0x060083EF RID: 33775 RVA: 0x003A2B54 File Offset: 0x003A0D54
	private void AJEJGHFCMHJ()
	{
		bool flag = !this.GJFBPMCKKLP && this.HIEGJGCJKFG;
		this.DHHMKLFDMPL();
		this.HIEGJGCJKFG = false;
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, true);
		if (flag && this.MEOKMDDOIHN != null)
		{
			this.MEOKMDDOIHN();
		}
	}

	// Token: 0x060083F0 RID: 33776 RVA: 0x003A2BAA File Offset: 0x003A0DAA
	private void CLKCKGOGFEA()
	{
		if (this.MCFJNMGJANO != null)
		{
			base.StopCoroutine(this.MCFJNMGJANO);
			this.MCFJNMGJANO = null;
		}
		this.EBDPDOJALNP();
	}

	// Token: 0x060083F1 RID: 33777 RVA: 0x003A1317 File Offset: 0x0039F517
	private void PBCCIIKPDKG()
	{
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		if (this.HCBFAOFBCDI != null)
		{
			this.HCBFAOFBCDI();
		}
	}

	// Token: 0x060083F2 RID: 33778 RVA: 0x003A2AB4 File Offset: 0x003A0CB4
	private IEnumerator HGFGFCHDNNE(string LIILENCNALA, string BOKPIFOLOHD)
	{
		elapsed = 0f;
		while (elapsed < 3f)
		{
			this.HMEIIALIKLJ(Time.unscaledDeltaTime);
			elapsed += Time.unscaledDeltaTime;
			yield return null;
		}
		this.GHFFFINNMPM = null;
		this.JBINHEHAKHF(LIILENCNALA, BOKPIFOLOHD);
		yield break;
	}

	// Token: 0x060083F3 RID: 33779 RVA: 0x003A2BD0 File Offset: 0x003A0DD0
	private void ECLJHGBFNNP(float JHBAIJIJIBN)
	{
		if (this.typingDots == null || this.MCCFHKAEHHA == null)
		{
			return;
		}
		int num = 0;
		while (num < this.typingDots.Length && num < this.MCCFHKAEHHA.Length)
		{
			Image image = this.typingDots[num];
			if (!(null == image))
			{
				float num2 = (JHBAIJIJIBN - (float)num * 0.15f) / 1.2f;
				num2 -= Mathf.Floor(num2);
				float num3 = 0.5f + 0.5f * Mathf.Sin(num2 * 3.1415927f * 2f);
				Color color = image.color;
				color.a = 0.25f + 0.75f * num3;
				image.color = color;
				Vector2 anchoredPosition = this.MCCFHKAEHHA[num];
				anchoredPosition.y += 6f * num3;
				image.rectTransform.anchoredPosition = anchoredPosition;
			}
			num++;
		}
	}

	// Token: 0x060083F4 RID: 33780 RVA: 0x003A2CB1 File Offset: 0x003A0EB1
	private void LAGLKHDEIHM()
	{
		if (this.MCFJNMGJANO != null)
		{
			base.StopCoroutine(this.MCFJNMGJANO);
			this.MCFJNMGJANO = null;
		}
		this.EBPKFMNLDNK();
	}

	// Token: 0x060083F5 RID: 33781 RVA: 0x003A2CD4 File Offset: 0x003A0ED4
	private void GCGPOBCBCKE(string DIMBCOBNMAM)
	{
		try
		{
			if (DIMBCOBNMAM == null)
			{
				DIMBCOBNMAM = "";
			}
			this.LDOIGGHDAEM = DIMBCOBNMAM;
			if (DIMBCOBNMAM.Length == 0)
			{
				this.IBLHFNNHOKJ();
			}
			else
			{
				if (this.GJFBPMCKKLP && !string.Equals(DIMBCOBNMAM, this.BKDDEGCHPFP, StringComparison.Ordinal))
				{
					this.COFHMOKMHAN();
				}
				this.LLMPGBHAFIJ();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083F6 RID: 33782 RVA: 0x003A2D40 File Offset: 0x003A0F40
	private void BMLLIECAKCJ()
	{
		try
		{
			this.OKPGMHOEAHG("OnStoryChoiceClick");
			this.AJEJGHFCMHJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083F7 RID: 33783 RVA: 0x003A2D78 File Offset: 0x003A0F78
	private void HOABAAPKPLC()
	{
		try
		{
			string text = this.CCOJIONFGIB();
			if (text.Length == 0)
			{
				this.HIEGJGCJKFG = true;
				this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, true);
			}
			else
			{
				this.KGDLIIMKCCL(text, text);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083F8 RID: 33784 RVA: 0x003A2DC8 File Offset: 0x003A0FC8
	public void ResetField()
	{
		try
		{
			this.IJLGKFJCIJF();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060083F9 RID: 33785 RVA: 0x003A2DF4 File Offset: 0x003A0FF4
	private void IJLGKFJCIJF()
	{
		this.FEFNJJMPHHH();
		this.HIEGJGCJKFG = false;
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		this.MJDEEIBNAEG("");
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
	}

	// Token: 0x060083FA RID: 33786 RVA: 0x003A2E24 File Offset: 0x003A1024
	private void PJAHIHDJDGM()
	{
		try
		{
			this.NAPFDPIHJKB = null;
			if (null != this.iconImage)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.iconImage.rectTransform);
			}
			if (this.HIEGJGCJKFG)
			{
				this.HIEGJGCJKFG = false;
				this.EELKICPBNFA = null;
				this.GHFFFINNMPM = null;
				this.MCFJNMGJANO = null;
				this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060083FB RID: 33787 RVA: 0x003A2E9C File Offset: 0x003A109C
	private void IBLHFNNHOKJ()
	{
		bool flag = this.GJFBPMCKKLP || this.HIEGJGCJKFG;
		this.FEFNJJMPHHH();
		this.HIEGJGCJKFG = false;
		this.GJFBPMCKKLP = false;
		this.BKDDEGCHPFP = null;
		this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Idle, false);
		if (flag && this.MEOKMDDOIHN != null)
		{
			this.MEOKMDDOIHN();
		}
	}

	// Token: 0x060083FC RID: 33788 RVA: 0x003A2EF4 File Offset: 0x003A10F4
	private void FLNBMIJDAEA()
	{
		if (null == this.focusRing)
		{
			return;
		}
		float num = (null != this.inputField && this.inputField.isFocused && !FocusItem.isFocusOpened && this.HLBABLKKFNJ) ? 798f : 325f;
		Color color = this.focusRing.color;
		if (Mathf.Approximately(color.a, num))
		{
			return;
		}
		color.a = Mathf.MoveTowards(color.a, num, Time.unscaledDeltaTime / 1952f);
		this.focusRing.color = color;
	}

	// Token: 0x060083FD RID: 33789 RVA: 0x003A273A File Offset: 0x003A093A
	private IEnumerator MGCMMOJOOGB()
	{
		yield return null;
		this.GMEMMHCMMDH();
		yield break;
	}

	// Token: 0x060083FE RID: 33790 RVA: 0x003A2203 File Offset: 0x003A0403
	private void KLBHHGPFCLB()
	{
		if (this.MCFJNMGJANO != null)
		{
			return;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		this.GJNHELBCJLB();
		this.MCFJNMGJANO = base.StartCoroutine(this.FOJGMLCOJNG());
	}

	// Token: 0x060083FF RID: 33791 RVA: 0x003A2F90 File Offset: 0x003A1190
	private void DHNEPBOHNLC()
	{
		try
		{
			this.MHGECPMMCOO("");
			this.AJEJGHFCMHJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008400 RID: 33792 RVA: 0x003A2FC8 File Offset: 0x003A11C8
	public string GetText()
	{
		try
		{
			if (null != this.inputField)
			{
				string text = this.inputField.text;
				if (text != null)
				{
					this.LDOIGGHDAEM = text;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.LDOIGGHDAEM == null)
		{
			return "";
		}
		return this.LDOIGGHDAEM;
	}

	// Token: 0x06008401 RID: 33793 RVA: 0x003A3028 File Offset: 0x003A1228
	private void FNDDKLJKFEK()
	{
		try
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.KMPFFINLDCP = component.anchorMin;
			this.FMPAAOMGDEO = component.anchorMax;
			this.DLCKFAOPPFJ = component.anchoredPosition;
			this.HDJALNPCEDN = component.sizeDelta;
			this.CCIEKOPBDEJ = true;
			if (NBDLBFJOEGN.EFMDGLOLMCJ())
			{
				this.IBMLLLFHGMA();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06008402 RID: 33794 RVA: 0x003A309C File Offset: 0x003A129C
	private void FAJNDJIENOC()
	{
		this.ECPOEGOFOGM();
		this.DCFOFPNILAG();
		this.LAGLKHDEIHM();
	}

	// Token: 0x06008403 RID: 33795 RVA: 0x003A30B0 File Offset: 0x003A12B0
	private void OnDisable()
	{
		try
		{
			this.NAPFDPIHJKB = null;
			if (null != this.iconImage)
			{
				OKNMMLHNCPA.EPJKDCDOEMM(this.iconImage.rectTransform);
			}
			if (this.HIEGJGCJKFG)
			{
				this.HIEGJGCJKFG = false;
				this.EELKICPBNFA = null;
				this.GHFFFINNMPM = null;
				this.MCFJNMGJANO = null;
				this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008404 RID: 33796 RVA: 0x003A3128 File Offset: 0x003A1328
	private void FFBNPHEEINP(string DIMBCOBNMAM)
	{
		try
		{
			if (this.EGFNNPIIMJL && this.HLBABLKKFNJ && !FocusItem.isFocusOpened && this.FGLNDLMHMED != null)
			{
				this.FGLNDLMHMED();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008405 RID: 33797 RVA: 0x003A317C File Offset: 0x003A137C
	private void CEPJJNGKIBN()
	{
		try
		{
			string text = this.CCOJIONFGIB();
			if (text.Length == 0)
			{
				this.HIEGJGCJKFG = false;
				this.HENOAKMCGCO(LobbySearchBar.ACAAKGBLECM.Typing, false);
			}
			else
			{
				this.KGDLIIMKCCL(text, text);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06008406 RID: 33798 RVA: 0x003A31CC File Offset: 0x003A13CC
	private void IGFOJLEMDAN()
	{
		if (!this.EGFNNPIIMJL)
		{
			return;
		}
		try
		{
			bool flag = !SceneLobbyManager2.lobbyIsLoading && !FocusItem.isFocusOpened;
			if (flag != this.HLBABLKKFNJ)
			{
				this.KMCCLLDNGDB(flag);
			}
			bool isFocusOpened = FocusItem.isFocusOpened;
			if (isFocusOpened != this.NIGJFBDNGII)
			{
				this.NIGJFBDNGII = isFocusOpened;
				if (isFocusOpened)
				{
					this.MIKAEKIPHBA();
				}
				else
				{
					this.LAFDIEMHCLG();
				}
			}
			this.PGMLDIOFCMO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0400255D RID: 9565
	public const float DEBOUNCE_SECONDS = 0.4f;

	// Token: 0x0400255E RID: 9566
	public const float SPINNER_SECONDS = 3f;

	// Token: 0x0400255F RID: 9567
	public const float SPINNER_DEGREES_PER_SECOND = 360f;

	// Token: 0x04002560 RID: 9568
	public const float DOT_PERIOD = 1.2f;

	// Token: 0x04002561 RID: 9569
	public const float DOT_STAGGER = 0.15f;

	// Token: 0x04002562 RID: 9570
	public const float DOT_MIN_ALPHA = 0.25f;

	// Token: 0x04002563 RID: 9571
	public const float DOT_BOUNCE_PIXELS = 6f;

	// Token: 0x04002564 RID: 9572
	public const float FOCUS_RING_FADE_SECONDS = 0.15f;

	// Token: 0x04002565 RID: 9573
	public TMP_InputField inputField;

	// Token: 0x04002566 RID: 9574
	public TextMeshProUGUI placeholderText;

	// Token: 0x04002567 RID: 9575
	public Image iconImage;

	// Token: 0x04002568 RID: 9576
	public GameObject typingDotsRoot;

	// Token: 0x04002569 RID: 9577
	public Image[] typingDots;

	// Token: 0x0400256A RID: 9578
	public GameObject spinnerRoot;

	// Token: 0x0400256B RID: 9579
	public RectTransform spinnerRect;

	// Token: 0x0400256C RID: 9580
	public Button clearButton;

	// Token: 0x0400256D RID: 9581
	public GameObject clearRoot;

	// Token: 0x0400256E RID: 9582
	public CanvasGroup canvasGroup;

	// Token: 0x0400256F RID: 9583
	public Image focusRing;

	// Token: 0x04002570 RID: 9584
	private UnityAction HCBFAOFBCDI;

	// Token: 0x04002571 RID: 9585
	private Func<string, int> LDPFDFPAILI;

	// Token: 0x04002572 RID: 9586
	private UnityAction MEOKMDDOIHN;

	// Token: 0x04002573 RID: 9587
	private UnityAction EHHACFMEEHB;

	// Token: 0x04002574 RID: 9588
	private UnityAction FGLNDLMHMED;

	// Token: 0x04002575 RID: 9589
	private LobbySearchBar.ACAAKGBLECM GPILOGAIBKJ;

	// Token: 0x04002576 RID: 9590
	private bool EGFNNPIIMJL;

	// Token: 0x04002577 RID: 9591
	private bool HIEGJGCJKFG;

	// Token: 0x04002578 RID: 9592
	private bool GJFBPMCKKLP;

	// Token: 0x04002579 RID: 9593
	private string BKDDEGCHPFP;

	// Token: 0x0400257A RID: 9594
	private string LDOIGGHDAEM = "";

	// Token: 0x0400257B RID: 9595
	private bool NIGJFBDNGII;

	// Token: 0x0400257C RID: 9596
	private bool HLBABLKKFNJ = true;

	// Token: 0x0400257D RID: 9597
	private Coroutine EELKICPBNFA;

	// Token: 0x0400257E RID: 9598
	private Coroutine GHFFFINNMPM;

	// Token: 0x0400257F RID: 9599
	private Coroutine MCFJNMGJANO;

	// Token: 0x04002580 RID: 9600
	private Vector2[] MCCFHKAEHHA;

	// Token: 0x04002581 RID: 9601
	private Coroutine NAPFDPIHJKB;

	// Token: 0x04002582 RID: 9602
	private Vector2 KMPFFINLDCP = Vector2.zero;

	// Token: 0x04002583 RID: 9603
	private Vector2 FMPAAOMGDEO = Vector2.zero;

	// Token: 0x04002584 RID: 9604
	private Vector2 DLCKFAOPPFJ = Vector2.zero;

	// Token: 0x04002585 RID: 9605
	private Vector2 HDJALNPCEDN = Vector2.zero;

	// Token: 0x04002586 RID: 9606
	private bool CCIEKOPBDEJ;

	// Token: 0x0200043F RID: 1087
	public enum ACAAKGBLECM
	{
		// Token: 0x04002588 RID: 9608
		Idle,
		// Token: 0x04002589 RID: 9609
		Typing,
		// Token: 0x0400258A RID: 9610
		Searching,
		// Token: 0x0400258B RID: 9611
		Results
	}
}
