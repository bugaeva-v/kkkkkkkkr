using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000129 RID: 297
public class ChoiceStatManager : MonoBehaviour
{
	// Token: 0x0600273B RID: 10043 RVA: 0x00003E52 File Offset: 0x00002052
	private void APBOFOJKEDO()
	{
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x0011F1AC File Offset: 0x0011D3AC
	public void ELELPGEKJFK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.PFAFKBCBIAM();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x00003E52 File Offset: 0x00002052
	private void LMPBLJPPCKO()
	{
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x0011F29C File Offset: 0x0011D49C
	public void EPODIFAECIE()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 87)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < 90)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x0011F30C File Offset: 0x0011D50C
	public void GPLADMDJEMC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.EBLCJCAKNBB();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x0011F3FC File Offset: 0x0011D5FC
	public void KJDNFFJJLDN(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.FPPKDLDONGF();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x0011F4EC File Offset: 0x0011D6EC
	public void CBAADMGHIKA()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 120)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -33)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x0011F55C File Offset: 0x0011D75C
	public void DBPLNFOONIM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 75)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < 10)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x0011F5CC File Offset: 0x0011D7CC
	public void AIIBCCIJBGL(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.JMMOOHPPNGH();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x0011F6BC File Offset: 0x0011D8BC
	public void NDNIGCDKKHI()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -56)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < -57)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOHKGEPBDIG()
	{
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x00003E52 File Offset: 0x00002052
	private void JCOIBJANCMG()
	{
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x0011F72C File Offset: 0x0011D92C
	public void HDHEALHGBEC()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 23)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -14)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x0011F79C File Offset: 0x0011D99C
	public void DOFLEONDCMI(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.IHAKDCJMJDC();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x0011F88C File Offset: 0x0011DA8C
	public void KFEJNODELND()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -90)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < -52)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x0011F8FC File Offset: 0x0011DAFC
	public void AHOMFBLKMJG()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 29)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -9)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x0011F96C File Offset: 0x0011DB6C
	public void HPNNCFCAGAC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LKPPPKODJEO();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x0011FA5C File Offset: 0x0011DC5C
	public void OFOAFPKPIKC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LONDJHFBEFM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x0011FB60 File Offset: 0x0011DD60
	public void AFOPKJFPDFO()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 112)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 5));
				}
				else if (this.CENMIEOCAMN < 38)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJPNMBNKLOO()
	{
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x0011FBD0 File Offset: 0x0011DDD0
	public void CKAKKNFOBIG()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -37)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < 50)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x00003E52 File Offset: 0x00002052
	private void IJDCBFCKINN()
	{
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x0011FC40 File Offset: 0x0011DE40
	public void AICAIGFKCAK()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -36)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < -109)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x0011FCB0 File Offset: 0x0011DEB0
	public void ACFNKMCLNPF()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -46)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 1));
				}
				else if (this.CENMIEOCAMN < -3)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x00003E52 File Offset: 0x00002052
	private void MGKMJOOPHNN()
	{
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x0011FD20 File Offset: 0x0011DF20
	public void ABKLHHIJNHD(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.DKOMJDEGPNG();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x0011FE10 File Offset: 0x0011E010
	public void ADDGEAAFLCC()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -36)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -86)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x0011FE80 File Offset: 0x0011E080
	public void IJAMOCBLICC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.HHJGOALIHBE();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x0011FF70 File Offset: 0x0011E170
	public void HHBPGAMBAAE(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.EHDIPDJGLHE();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x00120060 File Offset: 0x0011E260
	public void MEFKAOIJJNH(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.KONLOEDIDPB();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002761 RID: 10081 RVA: 0x00120150 File Offset: 0x0011E350
	public void LOACMPKJGGC()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -65)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -85)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x001201C0 File Offset: 0x0011E3C0
	public void INICKJJCJAJ()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -26)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < -61)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x00120230 File Offset: 0x0011E430
	public void CNJKPDCGHHB(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MIJAJDJBJPO();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x00120320 File Offset: 0x0011E520
	public void KIDOILDEFEB(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.IMPLALDJMNM();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x00120410 File Offset: 0x0011E610
	public void AJNNDKIIFDN(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.INCHNFAAEDG();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x00120500 File Offset: 0x0011E700
	public void CLCKNOEDPKM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -29)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < -30)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x00003E52 File Offset: 0x00002052
	private void DEGAMINFFMK()
	{
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x00120570 File Offset: 0x0011E770
	public void NMNIJHAPMOF()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -85)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < 70)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x001205E0 File Offset: 0x0011E7E0
	public void ONCMEAFFFIB(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.GEMEEIEPHJH();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x001206D0 File Offset: 0x0011E8D0
	public void GINEBHBHEBB()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -32)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < 43)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x00120740 File Offset: 0x0011E940
	public void KMLCPAGOFEM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 102)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 7));
				}
				else if (this.CENMIEOCAMN < -39)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x001207B0 File Offset: 0x0011E9B0
	public void BKAFOLJGJHP()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -12)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 4));
				}
				else if (this.CENMIEOCAMN < 37)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x00120820 File Offset: 0x0011EA20
	public void HBBFAAOICDH(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.IMPLALDJMNM();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x00120910 File Offset: 0x0011EB10
	public void ODEHJEOBANM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 10)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -88)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x00120980 File Offset: 0x0011EB80
	public void GEJOJGFCOII()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -86)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -50)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x001209F0 File Offset: 0x0011EBF0
	public void ExtendRightSide()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 10)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < 100)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x00120A60 File Offset: 0x0011EC60
	public void IAIBDLLKEMC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.HKHNJACEEAH();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIFMJKGGBO()
	{
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x00120B50 File Offset: 0x0011ED50
	public void CJDPJGLMJIF()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 77)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < -23)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x00120BC0 File Offset: 0x0011EDC0
	public void CIGAAJGBLEJ()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 40)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -102)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x00120C30 File Offset: 0x0011EE30
	public void MEFOJFDBNHO(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.OPCIDMKAHBM();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x00003E52 File Offset: 0x00002052
	private void EAKEDEEHEDD()
	{
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIMLAEEOBPD()
	{
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x00120D20 File Offset: 0x0011EF20
	public void MDINPPLEHCK()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 60)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -37)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x00120D90 File Offset: 0x0011EF90
	public void FNLKGBALACA(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.PFAFKBCBIAM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x00120E80 File Offset: 0x0011F080
	public void BHPMJGCCEEN()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -90)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < 33)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIEAHKFCEEP()
	{
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x00120EF0 File Offset: 0x0011F0F0
	public void Initialize(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LONDJHFBEFM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x00003E52 File Offset: 0x00002052
	private void LJJJIPGIJJC()
	{
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00120FE0 File Offset: 0x0011F1E0
	public void KGFEFGNFPJO(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MMHCNDKDLIB();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x001210D0 File Offset: 0x0011F2D0
	public void GKLEAFGGGDI(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.IMPLALDJMNM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x001211C0 File Offset: 0x0011F3C0
	public void GDLJEHGEKFE()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 24)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 7));
				}
				else if (this.CENMIEOCAMN < -102)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x00121230 File Offset: 0x0011F430
	public void FDNBMHHEBGC(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.PFAFKBCBIAM();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOIJOKHACJL()
	{
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x00003E52 File Offset: 0x00002052
	private void JENGJLCDEFJ()
	{
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x00121320 File Offset: 0x0011F520
	public void OALABLLLLGE()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -77)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < -101)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x00003E52 File Offset: 0x00002052
	private void EICKIGIBJEE()
	{
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x00121390 File Offset: 0x0011F590
	public void LGOFOGNAGDK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.GCBGANDJGPC();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x00121480 File Offset: 0x0011F680
	public void DODNEEPIFGH(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.FNODAEJLGFH();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x00121570 File Offset: 0x0011F770
	public void MHFCKMPLMFP()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -109)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 1));
				}
				else if (this.CENMIEOCAMN < -12)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x001215E0 File Offset: 0x0011F7E0
	public void KMDKBPNAKOG(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MMHCNDKDLIB();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLAIJHABAKI()
	{
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIIMGPDMHLA()
	{
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x001216D0 File Offset: 0x0011F8D0
	public void IMADGDGPBOB(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.INCHNFAAEDG();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x00003E52 File Offset: 0x00002052
	private void KJFHBHJPFFI()
	{
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x001217C0 File Offset: 0x0011F9C0
	public void KOOCIEPNMDH()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -128)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -81)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x00121830 File Offset: 0x0011FA30
	public void OMFMEGBAAFK()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 59)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < -2)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x001218A0 File Offset: 0x0011FAA0
	public void LBMOHCDFBEL(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.HKHNJACEEAH();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x00121990 File Offset: 0x0011FB90
	public void DBBNCGGMEFE()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 72)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 7));
				}
				else if (this.CENMIEOCAMN < 7)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x00121A00 File Offset: 0x0011FC00
	public void AJHNIHLKNNI(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.EJMOPGHOEFH();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x00121AF0 File Offset: 0x0011FCF0
	public void HJMIOBLIDKA(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.CMPKNGEKKGL();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x00121BE0 File Offset: 0x0011FDE0
	public void OAFOIGLLDKO()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 86)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -53)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x00121C50 File Offset: 0x0011FE50
	public void DINELHLNOHE()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 120)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 5));
				}
				else if (this.CENMIEOCAMN < 48)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x00121CC0 File Offset: 0x0011FEC0
	public void AMJMPJAOPIK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.HKHNJACEEAH();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x00121DB0 File Offset: 0x0011FFB0
	public void GOALPPHDLLJ()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 90)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < 98)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x00121E20 File Offset: 0x00120020
	public void OELJOHCNBGK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.FNODAEJLGFH();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x00121F10 File Offset: 0x00120110
	public void KNBNNEKBJAM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -2)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < -67)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x00121F80 File Offset: 0x00120180
	public void ICLEGIPAPEB()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 104)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 4));
				}
				else if (this.CENMIEOCAMN < -23)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x00121FF0 File Offset: 0x001201F0
	public void JNCEDFJCGAO(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LOBIKMJKNPO();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x001220E0 File Offset: 0x001202E0
	public void DCLAMKAEJPI()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -54)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < -86)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x00122150 File Offset: 0x00120350
	public void BMPAKGMEFNH()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 1)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 3));
				}
				else if (this.CENMIEOCAMN < 41)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x001221C0 File Offset: 0x001203C0
	public void ECIPAHHEGOF()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 58)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 8));
				}
				else if (this.CENMIEOCAMN < -24)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x00122230 File Offset: 0x00120430
	public void FIDLNEAALBF()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 40)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < 67)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x001222A0 File Offset: 0x001204A0
	public void IPEJHMNJFND()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -114)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < 120)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x00122310 File Offset: 0x00120510
	public void OGHBHHMJHAL()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 42)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < -43)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x00122380 File Offset: 0x00120580
	public void ANNMKIHGLCK()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 6)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < -29)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x001223F0 File Offset: 0x001205F0
	public void IDELCOJIHIK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MCABAJEGKJK();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x001224E0 File Offset: 0x001206E0
	public void JEPFODDLOFK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MMHCNDKDLIB();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x001225D0 File Offset: 0x001207D0
	public void CDAMEAIIKMG(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.FPPKDLDONGF();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x001226C0 File Offset: 0x001208C0
	public void BANBAANIDFE(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MMHCNDKDLIB();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x001227B0 File Offset: 0x001209B0
	public void DENJPCGFKPM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 106)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 6));
				}
				else if (this.CENMIEOCAMN < 51)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x00122820 File Offset: 0x00120A20
	public void FLHLLIMDPIH()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 121)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 4));
				}
				else if (this.CENMIEOCAMN < 115)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x00122890 File Offset: 0x00120A90
	public void HGELPFDIMJK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.DPPDIHMKAKK();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x00122980 File Offset: 0x00120B80
	public void NNNKIPGJMMF(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LDJBPBKNDHE();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x00122A70 File Offset: 0x00120C70
	public void KNBKCAJCIJK(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.FCMHCHFHOGG();
		text = ONEHEBIHPFB.FOMGCOENOKO(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x00122B60 File Offset: 0x00120D60
	public void BGLIAHEKACL(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.GCBGANDJGPC();
		text = ONEHEBIHPFB.PLHGCKCFLEN(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x00122C50 File Offset: 0x00120E50
	public void OGNEMDIEHFO(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MCABAJEGKJK();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x00122D40 File Offset: 0x00120F40
	public void FEGIJDLNGND()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -86)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 5));
				}
				else if (this.CENMIEOCAMN < -12)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x00122DB0 File Offset: 0x00120FB0
	public void FFFPOFGBJDL()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 64)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 0));
				}
				else if (this.CENMIEOCAMN < -33)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x00122E20 File Offset: 0x00121020
	public void FMBMBGDMCJG(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.JMMOOHPPNGH();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x00122F10 File Offset: 0x00121110
	public void DBNKIEOCIPL(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.MIJAJDJBJPO();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x00003E52 File Offset: 0x00002052
	private void OHPNGFAIGEM()
	{
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x00123000 File Offset: 0x00121200
	public void LAFCNAHCIFJ(OCCBADNHFHK MPBHHDFCDMA, int MOPLBHJBAGG, int PKJBBIFMKGD, int DDMMDDFIALL = -1)
	{
		this.CENMIEOCAMN = MOPLBHJBAGG;
		string text = MPBHHDFCDMA.LONDJHFBEFM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		this.statCostText.SetText(MOPLBHJBAGG.ToString(), false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x001230F0 File Offset: 0x001212F0
	public void LMAOFEKMMCM()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 1)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < 13)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < 119)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x00123160 File Offset: 0x00121360
	public void LLBDENFFCMO()
	{
		try
		{
			if (this.choiceTextRightExtraExtensionPerChar > 0)
			{
				RectTransform component = this.choiceText.GetComponent<RectTransform>();
				if (this.CENMIEOCAMN < -111)
				{
					component.GHHPCIKDJHA((float)(this.choiceTextRightExtraExtensionPerChar * 2));
				}
				else if (this.CENMIEOCAMN < 72)
				{
					component.GHHPCIKDJHA((float)this.choiceTextRightExtraExtensionPerChar);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x04000C4A RID: 3146
	public TextMeshProUGUI choiceText;

	// Token: 0x04000C4B RID: 3147
	public TextMeshProUGUI statCostText;

	// Token: 0x04000C4C RID: 3148
	public List<Image> hints;

	// Token: 0x04000C4D RID: 3149
	public int choiceTextRightExtraExtensionPerChar;

	// Token: 0x04000C4E RID: 3150
	private int CENMIEOCAMN = 150;
}
