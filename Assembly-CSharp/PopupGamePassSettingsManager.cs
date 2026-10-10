using System;
using UnityEngine;

// Token: 0x020004E1 RID: 1249
public class PopupGamePassSettingsManager : MonoBehaviour
{
	// Token: 0x060096CD RID: 38605 RVA: 0x0041EA95 File Offset: 0x0041CC95
	public void HJBANHOJCMJ()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke(", also auto-syncing all avatar elements with new index.", 1915f);
	}

	// Token: 0x060096CE RID: 38606 RVA: 0x0041EAC2 File Offset: 0x0041CCC2
	private void GBLJNKDFFJD()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x060096CF RID: 38607 RVA: 0x0041EAD0 File Offset: 0x0041CCD0
	private void JHDHJNJDPDM()
	{
		this.BGMOEDJBIDO = true;
		this.statsBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 1)
		{
			this.statsOn.SetActive(false);
			this.statsOff.SetActive(true);
			return;
		}
		this.statsOn.SetActive(true);
		this.statsOff.SetActive(false);
	}

	// Token: 0x060096D0 RID: 38608 RVA: 0x0041EB30 File Offset: 0x0041CD30
	private void LDLLCBDGGHN()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		this.NCBPCMHFNLC = true;
		this.MMGINBAEHHO = false;
		this.JOKBNEBGLNG = true;
		this.BGMOEDJBIDO = true;
		this.GPOFCGGGFBA = false;
		this.DNHIJBHJDOD = false;
		this.PAOGKGOCLLJ();
		this.FAACMDMDBBK();
		this.LMPIGJEFMIK();
		this.EDOMMFFCLGO();
		this.NIJGHAOBPIL();
		this.DOELEGKNOPO();
		if (ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, true) == null)
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(false);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(false);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x060096D1 RID: 38609 RVA: 0x0041EC1F File Offset: 0x0041CE1F
	public void AGLNKOAIINA()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = false;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 1;
		base.Invoke("PopIfOnly ", 1605f);
	}

	// Token: 0x060096D2 RID: 38610 RVA: 0x0041EC4C File Offset: 0x0041CE4C
	public void FKKAHMBHEIK()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 0;
		base.Invoke("yes", 1215f);
	}

	// Token: 0x060096D3 RID: 38611 RVA: 0x0041EC79 File Offset: 0x0041CE79
	public void OnAutoReadOnClick()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("ACOBALOLPIA", 0.1f);
	}

	// Token: 0x060096D4 RID: 38612 RVA: 0x0041ECA6 File Offset: 0x0041CEA6
	public void HFCDCJKDKFC()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = true;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 0;
		base.Invoke("ok", 910f);
	}

	// Token: 0x060096D5 RID: 38613 RVA: 0x0041ECD3 File Offset: 0x0041CED3
	public void IMGADAPCPJA()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 1;
		base.Invoke("rtng", 597f);
	}

	// Token: 0x060096D6 RID: 38614 RVA: 0x0041ED00 File Offset: 0x0041CF00
	public void HBKAHOLFOAG()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke("/", 1216f);
	}

	// Token: 0x060096D7 RID: 38615 RVA: 0x0041EAC2 File Offset: 0x0041CCC2
	private void OnDisable()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x060096D8 RID: 38616 RVA: 0x0041ED30 File Offset: 0x0041CF30
	private void ADMCLHAMGKA()
	{
		this.BGMOEDJBIDO = true;
		this.statsBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 1)
		{
			this.statsOn.SetActive(true);
			this.statsOff.SetActive(false);
			return;
		}
		this.statsOn.SetActive(false);
		this.statsOff.SetActive(false);
	}

	// Token: 0x060096D9 RID: 38617 RVA: 0x0041ED8E File Offset: 0x0041CF8E
	public void EJFFHEPHJGN()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("%", 834f);
	}

	// Token: 0x060096DA RID: 38618 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void BNHNOHLINDK()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x060096DB RID: 38619 RVA: 0x0041EDBC File Offset: 0x0041CFBC
	private void MHGEAMINEHD()
	{
		this.MMGINBAEHHO = false;
		this.undoBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(false);
			return;
		}
		this.undoOn.SetActive(true);
		this.undoOff.SetActive(true);
	}

	// Token: 0x060096DC RID: 38620 RVA: 0x0041EE1C File Offset: 0x0041D01C
	private void FAACMDMDBBK()
	{
		this.MMGINBAEHHO = false;
		this.undoBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.undoOn.SetActive(false);
			this.undoOff.SetActive(false);
			return;
		}
		this.undoOn.SetActive(false);
		this.undoOff.SetActive(true);
	}

	// Token: 0x060096DD RID: 38621 RVA: 0x0041EE7A File Offset: 0x0041D07A
	public void EDGHOJKFCJH()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("</i>", 1299f);
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x00003E52 File Offset: 0x00002052
	private void ECDLFGCLAGG()
	{
	}

	// Token: 0x060096DF RID: 38623 RVA: 0x0041EEA7 File Offset: 0x0041D0A7
	public void KEGLFLIHIJC()
	{
		AOBJLALDBAA.NMGMNAKLLMI().LPNCDPHNBJK(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 977f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x060096E0 RID: 38624 RVA: 0x0041EEC9 File Offset: 0x0041D0C9
	private void ANENAICKOJM()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x060096E1 RID: 38625 RVA: 0x0041EED7 File Offset: 0x0041D0D7
	public void PAKJEIFCHAP()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("OnPopupStoryRestartManagerRestartStory4", 225f);
	}

	// Token: 0x060096E2 RID: 38626 RVA: 0x0041EF04 File Offset: 0x0041D104
	private void IPFEBJPHFIN()
	{
		this.BGMOEDJBIDO = true;
		this.statsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 1)
		{
			this.statsOn.SetActive(true);
			this.statsOff.SetActive(false);
			return;
		}
		this.statsOn.SetActive(false);
		this.statsOff.SetActive(true);
	}

	// Token: 0x060096E3 RID: 38627 RVA: 0x0041EF64 File Offset: 0x0041D164
	private void DCDHCHNCJNK()
	{
		this.NCBPCMHFNLC = true;
		this.hardSpendBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 1)
		{
			this.hardSpendOn.SetActive(true);
			this.hardSpendOff.SetActive(false);
			return;
		}
		this.hardSpendOn.SetActive(false);
		this.hardSpendOff.SetActive(true);
	}

	// Token: 0x060096E4 RID: 38628 RVA: 0x0041EFC4 File Offset: 0x0041D1C4
	private void PAOGKGOCLLJ()
	{
		this.NCBPCMHFNLC = false;
		this.hardSpendBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 1)
		{
			this.hardSpendOn.SetActive(true);
			this.hardSpendOff.SetActive(true);
			return;
		}
		this.hardSpendOn.SetActive(true);
		this.hardSpendOff.SetActive(false);
	}

	// Token: 0x060096E5 RID: 38629 RVA: 0x00003E52 File Offset: 0x00002052
	private void IFHJKBHODGG()
	{
	}

	// Token: 0x060096E6 RID: 38630 RVA: 0x0041F024 File Offset: 0x0041D224
	public void JGDDMNOHFEJ()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = false;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("s]", 523f);
		base.Invoke("high", 765f);
	}

	// Token: 0x060096E7 RID: 38631 RVA: 0x0041F077 File Offset: 0x0041D277
	public void OnLoveInterestsOnClick()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = false;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 0;
		base.Invoke("LLJPEBCNEAP", 0.1f);
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x0041F0A4 File Offset: 0x0041D2A4
	public void BAJKINIHNPK()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = false;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("", 1613f);
		base.Invoke("assetbundleanthology", 1328f);
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x0041F0F8 File Offset: 0x0041D2F8
	private void IBOEBOBJHIC()
	{
		this.MMGINBAEHHO = true;
		this.undoBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(true);
			return;
		}
		this.undoOn.SetActive(false);
		this.undoOff.SetActive(true);
	}

	// Token: 0x060096EA RID: 38634 RVA: 0x0041F156 File Offset: 0x0041D356
	public void GPOJDODNLFK()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		base.Invoke("sketches", 225f);
	}

	// Token: 0x060096EB RID: 38635 RVA: 0x0041EAC2 File Offset: 0x0041CCC2
	private void FGNEEMMJFCA()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x060096EC RID: 38636 RVA: 0x0041F183 File Offset: 0x0041D383
	public void MIMKAHNHLNH()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("storiesSearchConcepts", 435f);
	}

	// Token: 0x060096EE RID: 38638 RVA: 0x0041F1BC File Offset: 0x0041D3BC
	public void KBDMJNCJKDA()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = false;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 0;
		base.Invoke("", 1810f);
	}

	// Token: 0x060096EF RID: 38639 RVA: 0x0041F1EC File Offset: 0x0041D3EC
	private void LMPIGJEFMIK()
	{
		this.JOKBNEBGLNG = false;
		this.loveInterestsBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ == 0)
		{
			this.loveInterestsOn.SetActive(false);
			this.loveInterestsOff.SetActive(false);
			return;
		}
		this.loveInterestsOn.SetActive(false);
		this.loveInterestsOff.SetActive(false);
	}

	// Token: 0x060096F0 RID: 38640 RVA: 0x0041F24A File Offset: 0x0041D44A
	public void HFFJACPIHKE()
	{
		AOBJLALDBAA.AGANFKKBPFO().KGIKHEDLPND(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 669f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x060096F1 RID: 38641 RVA: 0x0041F26C File Offset: 0x0041D46C
	public void OnHardSpendOnClick()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("DCDHCHNCJNK", 0.1f);
	}

	// Token: 0x060096F2 RID: 38642 RVA: 0x0041F299 File Offset: 0x0041D499
	public void OnLoveInterestsOffClick()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = false;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 1;
		base.Invoke("LLJPEBCNEAP", 0.1f);
	}

	// Token: 0x060096F3 RID: 38643 RVA: 0x0041F2C8 File Offset: 0x0041D4C8
	private void NIJGHAOBPIL()
	{
		this.GPOFCGGGFBA = true;
		this.fastForwardBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1)
		{
			this.fastForwardOn.SetActive(true);
			this.fastForwardOff.SetActive(false);
			return;
		}
		this.fastForwardOn.SetActive(false);
		this.fastForwardOff.SetActive(true);
	}

	// Token: 0x060096F4 RID: 38644 RVA: 0x0041F328 File Offset: 0x0041D528
	public void BBDPJPIEGDP()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("vwht", 1878f);
		base.Invoke("", 152f);
	}

	// Token: 0x060096F5 RID: 38645 RVA: 0x00002296 File Offset: 0x00000496
	private void PBIJFPLLPDH()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060096F6 RID: 38646 RVA: 0x0041F37B File Offset: 0x0041D57B
	public void JBKMOKOKCNK()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("retry", 1326f);
	}

	// Token: 0x060096F7 RID: 38647 RVA: 0x0041F3A8 File Offset: 0x0041D5A8
	public void GPPPIODPBPO()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 1;
		base.Invoke(" (", 1499f);
	}

	// Token: 0x060096F8 RID: 38648 RVA: 0x0041F3D5 File Offset: 0x0041D5D5
	public void DDPHFKOHDJB()
	{
		AOBJLALDBAA.BIAEAOMHBMM().DCGCFPHHDDG(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 1272f);
		base.gameObject.SetActive(true);
	}

	// Token: 0x060096F9 RID: 38649 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIHMCECHLOI()
	{
	}

	// Token: 0x060096FA RID: 38650 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060096FB RID: 38651 RVA: 0x0041F3F7 File Offset: 0x0041D5F7
	public void LNAMFMONFHL()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		base.Invoke("_TVDotsBlend", 796f);
	}

	// Token: 0x060096FC RID: 38652 RVA: 0x0041F424 File Offset: 0x0041D624
	public void Hide()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 0f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x060096FD RID: 38653 RVA: 0x0041F446 File Offset: 0x0041D646
	public void FPHMACAECBE()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke("<i>", 243f);
	}

	// Token: 0x060096FE RID: 38654 RVA: 0x0041F474 File Offset: 0x0041D674
	private void LALLLDADLON()
	{
		this.MMGINBAEHHO = true;
		this.undoBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(false);
			return;
		}
		this.undoOn.SetActive(true);
		this.undoOff.SetActive(true);
	}

	// Token: 0x060096FF RID: 38655 RVA: 0x0041F4D2 File Offset: 0x0041D6D2
	public void JABGOCALEOA()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("ok", 536f);
	}

	// Token: 0x06009700 RID: 38656 RVA: 0x0041F500 File Offset: 0x0041D700
	private void BNFKLKGJHHD()
	{
		this.NCBPCMHFNLC = true;
		this.hardSpendBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 0)
		{
			this.hardSpendOn.SetActive(true);
			this.hardSpendOff.SetActive(true);
			return;
		}
		this.hardSpendOn.SetActive(false);
		this.hardSpendOff.SetActive(true);
	}

	// Token: 0x06009701 RID: 38657 RVA: 0x00172DCA File Offset: 0x00170FCA
	public void Show()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06009702 RID: 38658 RVA: 0x0041F560 File Offset: 0x0041D760
	public void OnFastForwardOffClick()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = false;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("NIJGHAOBPIL", 0.1f);
		base.Invoke("ACOBALOLPIA", 0.1f);
	}

	// Token: 0x06009703 RID: 38659 RVA: 0x0041F5B3 File Offset: 0x0041D7B3
	public void LFPHNGHJCDF()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 1;
		base.Invoke("", 1657f);
	}

	// Token: 0x06009704 RID: 38660 RVA: 0x0041F5E0 File Offset: 0x0041D7E0
	private void HJJCOPBEDIM()
	{
		this.BGMOEDJBIDO = false;
		this.statsBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 1)
		{
			this.statsOn.SetActive(false);
			this.statsOff.SetActive(false);
			return;
		}
		this.statsOn.SetActive(true);
		this.statsOff.SetActive(true);
	}

	// Token: 0x06009705 RID: 38661 RVA: 0x0041F63E File Offset: 0x0041D83E
	public void KPHBBEKNGGD()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 1;
		base.Invoke("OnPopupProfileSaveCutsceneInputCancel", 830f);
	}

	// Token: 0x06009706 RID: 38662 RVA: 0x0041EAC2 File Offset: 0x0041CCC2
	private void MHBPJEDCLDM()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06009707 RID: 38663 RVA: 0x0041F66B File Offset: 0x0041D86B
	public void PGKJEEBDGKL()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("rig ", 1688f);
	}

	// Token: 0x06009708 RID: 38664 RVA: 0x0041F698 File Offset: 0x0041D898
	public void AOBMBDNIOLD()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("OnSketchThumbnailDuplicatePositive", 444f);
	}

	// Token: 0x06009709 RID: 38665 RVA: 0x0041F6C8 File Offset: 0x0041D8C8
	public void OnAutoReadOffClick()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = false;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		base.Invoke("ACOBALOLPIA", 0.1f);
		base.Invoke("NIJGHAOBPIL", 0.1f);
	}

	// Token: 0x0600970A RID: 38666 RVA: 0x0041F71B File Offset: 0x0041D91B
	public void OnUndoOffClick()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("NDFNOAHJENJ", 0.1f);
	}

	// Token: 0x0600970B RID: 38667 RVA: 0x0041F748 File Offset: 0x0041D948
	public void CPLBHDCLNGM()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("?uid=", 1151f);
	}

	// Token: 0x0600970C RID: 38668 RVA: 0x0041F775 File Offset: 0x0041D975
	public void OIPBKOFJECJ()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke(" score ", 505f);
	}

	// Token: 0x0600970D RID: 38669 RVA: 0x0041F7A4 File Offset: 0x0041D9A4
	public void HEFAKCANOBF()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		base.Invoke("tmd", 1841f);
		base.Invoke("lck", 736f);
	}

	// Token: 0x0600970E RID: 38670 RVA: 0x0041F7F8 File Offset: 0x0041D9F8
	private void JMDPNLHIEBK()
	{
		this.GPOFCGGGFBA = false;
		this.fastForwardBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 0)
		{
			this.fastForwardOn.SetActive(true);
			this.fastForwardOff.SetActive(true);
			return;
		}
		this.fastForwardOn.SetActive(true);
		this.fastForwardOff.SetActive(false);
	}

	// Token: 0x0600970F RID: 38671 RVA: 0x0041F856 File Offset: 0x0041DA56
	public void OnStatsOnClick()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 0;
		base.Invoke("IPFEBJPHFIN", 0.1f);
	}

	// Token: 0x06009710 RID: 38672 RVA: 0x0041F883 File Offset: 0x0041DA83
	public void ECBFDMOLHIG()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("pmterror007", 750f);
	}

	// Token: 0x06009711 RID: 38673 RVA: 0x0041F8B0 File Offset: 0x0041DAB0
	public void DIFKOOMLHBE()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke(" ", 380f);
	}

	// Token: 0x06009712 RID: 38674 RVA: 0x0041F8E0 File Offset: 0x0041DAE0
	private void LLJPEBCNEAP()
	{
		this.JOKBNEBGLNG = true;
		this.loveInterestsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ == 1)
		{
			this.loveInterestsOn.SetActive(true);
			this.loveInterestsOff.SetActive(false);
			return;
		}
		this.loveInterestsOn.SetActive(false);
		this.loveInterestsOff.SetActive(true);
	}

	// Token: 0x06009713 RID: 38675 RVA: 0x0041F940 File Offset: 0x0041DB40
	public void IHFOEBOOLGG()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = false;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("OnBackendUpgradeToGiftCardException", 1503f);
		base.Invoke("rev", 1826f);
	}

	// Token: 0x06009714 RID: 38676 RVA: 0x0041F994 File Offset: 0x0041DB94
	private void BEDJCJPJHHN()
	{
		this.MMGINBAEHHO = true;
		this.undoBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(false);
			return;
		}
		this.undoOn.SetActive(false);
		this.undoOff.SetActive(true);
	}

	// Token: 0x06009715 RID: 38677 RVA: 0x0041F9F2 File Offset: 0x0041DBF2
	public void FHPJGPKNBCK()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 0;
		base.Invoke("OnPopupProfileSaveCutsceneInputCancel", 1297f);
	}

	// Token: 0x06009716 RID: 38678 RVA: 0x0041FA1F File Offset: 0x0041DC1F
	public void DGMGCOIFAHK()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke("tbits2", 473f);
	}

	// Token: 0x06009717 RID: 38679 RVA: 0x0041FA4C File Offset: 0x0041DC4C
	public void NGLHFMPAJHL()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		base.Invoke(">", 445f);
	}

	// Token: 0x06009718 RID: 38680 RVA: 0x0041FA79 File Offset: 0x0041DC79
	public void EJACPPFFPCM()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		base.Invoke("ZZZ", 678f);
	}

	// Token: 0x06009719 RID: 38681 RVA: 0x0041FAA8 File Offset: 0x0041DCA8
	private void LMHMPJLKMOF()
	{
		this.MMGINBAEHHO = false;
		this.undoBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(true);
			return;
		}
		this.undoOn.SetActive(true);
		this.undoOff.SetActive(false);
	}

	// Token: 0x0600971A RID: 38682 RVA: 0x0041FB06 File Offset: 0x0041DD06
	public void LFNAHAFMANH()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("socialrequestwarnyou", 1427f);
	}

	// Token: 0x0600971B RID: 38683 RVA: 0x0041FB34 File Offset: 0x0041DD34
	private void NJJHPCBFEFJ()
	{
		this.DNHIJBHJDOD = true;
		if (null == this.autoReadBlock)
		{
			return;
		}
		this.autoReadBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1)
		{
			this.autoReadOn.SetActive(true);
			this.autoReadOff.SetActive(true);
			return;
		}
		this.autoReadOn.SetActive(false);
		this.autoReadOff.SetActive(true);
	}

	// Token: 0x0600971C RID: 38684 RVA: 0x0041FBA1 File Offset: 0x0041DDA1
	public void OnFastForwardOnClick()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = false;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 0;
		base.Invoke("NIJGHAOBPIL", 0.1f);
	}

	// Token: 0x0600971D RID: 38685 RVA: 0x0041FBD0 File Offset: 0x0041DDD0
	private void CPFLEGKINCD()
	{
		this.MMGINBAEHHO = true;
		this.undoBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 0)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(true);
			return;
		}
		this.undoOn.SetActive(true);
		this.undoOff.SetActive(true);
	}

	// Token: 0x0600971E RID: 38686 RVA: 0x0041FC2E File Offset: 0x0041DE2E
	public void LMKOBGCAHJH()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("syn", 1650f);
	}

	// Token: 0x0600971F RID: 38687 RVA: 0x0041FC5B File Offset: 0x0041DE5B
	public void JAHJCCJLKKN()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 1;
		base.Invoke("", 1688f);
	}

	// Token: 0x06009720 RID: 38688 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06009721 RID: 38689 RVA: 0x0041FC88 File Offset: 0x0041DE88
	public void KIILBALFPHN()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = true;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 1;
		base.Invoke("fvrt", 671f);
	}

	// Token: 0x06009722 RID: 38690 RVA: 0x0041EAC2 File Offset: 0x0041CCC2
	private void EBANEHOGOIO()
	{
		StoryInterfaceHeaderManager.modalDialogActive = false;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06009723 RID: 38691 RVA: 0x0041FCB8 File Offset: 0x0041DEB8
	private void DJPLCFDHLFI()
	{
		this.GPOFCGGGFBA = true;
		this.fastForwardBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD == 1)
		{
			this.fastForwardOn.SetActive(true);
			this.fastForwardOff.SetActive(false);
			return;
		}
		this.fastForwardOn.SetActive(false);
		this.fastForwardOff.SetActive(false);
	}

	// Token: 0x06009724 RID: 38692 RVA: 0x0041FD18 File Offset: 0x0041DF18
	private void LEKHCDHHGLF()
	{
		this.JOKBNEBGLNG = true;
		this.loveInterestsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ == 0)
		{
			this.loveInterestsOn.SetActive(true);
			this.loveInterestsOff.SetActive(true);
			return;
		}
		this.loveInterestsOn.SetActive(true);
		this.loveInterestsOff.SetActive(true);
	}

	// Token: 0x06009725 RID: 38693 RVA: 0x0041FD78 File Offset: 0x0041DF78
	private void OnEnable()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		this.NCBPCMHFNLC = true;
		this.MMGINBAEHHO = true;
		this.JOKBNEBGLNG = true;
		this.BGMOEDJBIDO = true;
		this.GPOFCGGGFBA = true;
		this.DNHIJBHJDOD = true;
		this.DCDHCHNCJNK();
		this.NDFNOAHJENJ();
		this.LLJPEBCNEAP();
		this.IPFEBJPHFIN();
		this.NIJGHAOBPIL();
		this.ACOBALOLPIA();
		if (ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true) == null)
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(false);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			this.hardSpendBlock.gameObject.SetActive(true);
			this.fastForwardBlock.gameObject.SetActive(true);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009726 RID: 38694 RVA: 0x00003E52 File Offset: 0x00002052
	private void ANPIDDAIALE()
	{
	}

	// Token: 0x06009727 RID: 38695 RVA: 0x0041FE67 File Offset: 0x0041E067
	public void LPDFPFEHOPH()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = true;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 1;
		base.Invoke("", 1840f);
	}

	// Token: 0x06009728 RID: 38696 RVA: 0x0041FE94 File Offset: 0x0041E094
	public void DFKIIENKNNP()
	{
		if (!this.JOKBNEBGLNG)
		{
			return;
		}
		this.JOKBNEBGLNG = true;
		AKLFPGMDKLA.EHBBFMCILPC.EKHACLPEIBJ = 1;
		base.Invoke("Audio asset bundle loading skipped due forced option:", 1274f);
	}

	// Token: 0x06009729 RID: 38697 RVA: 0x0041FEC1 File Offset: 0x0041E0C1
	public void KFBNCKIBHPE()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("Error. Trying to use $IMPORTVARS without declaring a prequel story index.", 1790f);
	}

	// Token: 0x0600972A RID: 38698 RVA: 0x0041FEEE File Offset: 0x0041E0EE
	public void HNJILFNNLDA()
	{
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 1421f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x0600972B RID: 38699 RVA: 0x0041FF10 File Offset: 0x0041E110
	private void FHIGOMINDKP()
	{
		this.NCBPCMHFNLC = false;
		this.hardSpendBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ == 0)
		{
			this.hardSpendOn.SetActive(false);
			this.hardSpendOff.SetActive(true);
			return;
		}
		this.hardSpendOn.SetActive(false);
		this.hardSpendOff.SetActive(true);
	}

	// Token: 0x0600972C RID: 38700 RVA: 0x000022C3 File Offset: 0x000004C3
	private void HEHADOKFGBB()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x0041FF70 File Offset: 0x0041E170
	private void KHOLJLKNAPJ()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		this.NCBPCMHFNLC = true;
		this.MMGINBAEHHO = false;
		this.JOKBNEBGLNG = false;
		this.BGMOEDJBIDO = true;
		this.GPOFCGGGFBA = true;
		this.DNHIJBHJDOD = false;
		this.FHIGOMINDKP();
		this.LMHMPJLKMOF();
		this.LLJPEBCNEAP();
		this.JHDHJNJDPDM();
		this.JMDPNLHIEBK();
		this.DOELEGKNOPO();
		if (ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.gamePass, false) == null)
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(true);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(true);
				return;
			}
		}
		else
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(false);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x0042005F File Offset: 0x0041E25F
	public void CEKPPEIGNFM()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = true;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 0;
		base.Invoke("avts2", 621f);
	}

	// Token: 0x0600972F RID: 38703 RVA: 0x0042008C File Offset: 0x0041E28C
	public void NOHNHDMPAHC()
	{
		AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND(PopupGamePassSettingsManager.onPopupGamePassSettingsManagerClose, 1037f);
		base.gameObject.SetActive(false);
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x004200B0 File Offset: 0x0041E2B0
	private void EDOMMFFCLGO()
	{
		this.BGMOEDJBIDO = true;
		this.statsBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 0)
		{
			this.statsOn.SetActive(true);
			this.statsOff.SetActive(false);
			return;
		}
		this.statsOn.SetActive(true);
		this.statsOff.SetActive(false);
	}

	// Token: 0x06009731 RID: 38705 RVA: 0x00420110 File Offset: 0x0041E310
	private void FPGEBMIFOPK()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		this.NCBPCMHFNLC = false;
		this.MMGINBAEHHO = true;
		this.JOKBNEBGLNG = false;
		this.BGMOEDJBIDO = true;
		this.GPOFCGGGFBA = true;
		this.DNHIJBHJDOD = true;
		this.BNFKLKGJHHD();
		this.LALLLDADLON();
		this.LLJPEBCNEAP();
		this.JHDHJNJDPDM();
		this.NIJGHAOBPIL();
		this.NJJHPCBFEFJ();
		if (ODLJHDIGLGO.HBBBLMBHIAH(CLHDENLPOFP.gamePass, false) == null)
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(true);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(false);
				return;
			}
		}
		else
		{
			this.hardSpendBlock.gameObject.SetActive(false);
			this.fastForwardBlock.gameObject.SetActive(true);
			if (null != this.autoReadBlock)
			{
				this.autoReadBlock.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06009732 RID: 38706 RVA: 0x00420200 File Offset: 0x0041E400
	private void NDFNOAHJENJ()
	{
		this.MMGINBAEHHO = true;
		this.undoBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL == 1)
		{
			this.undoOn.SetActive(true);
			this.undoOff.SetActive(false);
			return;
		}
		this.undoOn.SetActive(false);
		this.undoOff.SetActive(true);
	}

	// Token: 0x06009733 RID: 38707 RVA: 0x00420260 File Offset: 0x0041E460
	public void CHDHJBDIOJF()
	{
		if (!this.GPOFCGGGFBA)
		{
			return;
		}
		this.GPOFCGGGFBA = true;
		AKLFPGMDKLA.EHBBFMCILPC.MEDFMIPBDFD = 1;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 0;
		base.Invoke("OnCutsceneViewShowWI", 961f);
		base.Invoke("chata", 114f);
	}

	// Token: 0x06009734 RID: 38708 RVA: 0x004202B3 File Offset: 0x0041E4B3
	public void EDKFOIONDDP()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("Swipe tutorial shown, frames:", 200f);
	}

	// Token: 0x06009735 RID: 38709 RVA: 0x004202E0 File Offset: 0x0041E4E0
	private void DOELEGKNOPO()
	{
		this.DNHIJBHJDOD = true;
		if (null == this.autoReadBlock)
		{
			return;
		}
		this.autoReadBlock.SetActive(false);
		if (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 0)
		{
			this.autoReadOn.SetActive(false);
			this.autoReadOff.SetActive(false);
			return;
		}
		this.autoReadOn.SetActive(true);
		this.autoReadOff.SetActive(false);
	}

	// Token: 0x06009736 RID: 38710 RVA: 0x0041EEC9 File Offset: 0x0041D0C9
	private void OJIOGKJEBMM()
	{
		StoryInterfaceHeaderManager.modalDialogActive = true;
		bool isQuitting = AppManager.isQuitting;
	}

	// Token: 0x06009737 RID: 38711 RVA: 0x00420350 File Offset: 0x0041E550
	private void ACOBALOLPIA()
	{
		this.DNHIJBHJDOD = true;
		if (null == this.autoReadBlock)
		{
			return;
		}
		this.autoReadBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1)
		{
			this.autoReadOn.SetActive(true);
			this.autoReadOff.SetActive(false);
			return;
		}
		this.autoReadOn.SetActive(false);
		this.autoReadOff.SetActive(true);
	}

	// Token: 0x06009738 RID: 38712 RVA: 0x00003E52 File Offset: 0x00002052
	private void PPMLHHMFHLO()
	{
	}

	// Token: 0x06009739 RID: 38713 RVA: 0x004203BD File Offset: 0x0041E5BD
	public void FPKBKCBOBPP()
	{
		if (!this.DNHIJBHJDOD)
		{
			return;
		}
		this.DNHIJBHJDOD = true;
		AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH = 1;
		base.Invoke("Could not find an existent component for tryAvatarConfig/face, forcing default option.", 1785f);
	}

	// Token: 0x0600973A RID: 38714 RVA: 0x004203EC File Offset: 0x0041E5EC
	private void KDHOKHONBEF()
	{
		this.BGMOEDJBIDO = false;
		this.statsBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO == 0)
		{
			this.statsOn.SetActive(true);
			this.statsOff.SetActive(true);
			return;
		}
		this.statsOn.SetActive(false);
		this.statsOff.SetActive(true);
	}

	// Token: 0x0600973B RID: 38715 RVA: 0x0042044A File Offset: 0x0041E64A
	public void OnStatsOffClick()
	{
		if (!this.BGMOEDJBIDO)
		{
			return;
		}
		this.BGMOEDJBIDO = false;
		AKLFPGMDKLA.EHBBFMCILPC.IHMLBGPJKDO = 1;
		base.Invoke("IPFEBJPHFIN", 0.1f);
	}

	// Token: 0x0600973C RID: 38716 RVA: 0x00420477 File Offset: 0x0041E677
	public void OnHardSpendOffClick()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 1;
		base.Invoke("DCDHCHNCJNK", 0.1f);
	}

	// Token: 0x0600973D RID: 38717 RVA: 0x004204A4 File Offset: 0x0041E6A4
	public void IIBLIDBHOKN()
	{
		if (!this.NCBPCMHFNLC)
		{
			return;
		}
		this.NCBPCMHFNLC = false;
		AKLFPGMDKLA.EHBBFMCILPC.MDPMKICGGIJ = 1;
		base.Invoke("0.00", 1157f);
	}

	// Token: 0x0600973E RID: 38718 RVA: 0x004204D4 File Offset: 0x0041E6D4
	private void JGGJNDDMHFJ()
	{
		this.DNHIJBHJDOD = false;
		if (null == this.autoReadBlock)
		{
			return;
		}
		this.autoReadBlock.SetActive(true);
		if (AKLFPGMDKLA.EHBBFMCILPC.AJLAADOFOLH == 1)
		{
			this.autoReadOn.SetActive(true);
			this.autoReadOff.SetActive(false);
			return;
		}
		this.autoReadOn.SetActive(false);
		this.autoReadOff.SetActive(true);
	}

	// Token: 0x0600973F RID: 38719 RVA: 0x00420541 File Offset: 0x0041E741
	public void OPAGAICOPHH()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = true;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 1;
		base.Invoke("drs", 745f);
	}

	// Token: 0x06009740 RID: 38720 RVA: 0x0042056E File Offset: 0x0041E76E
	public void ILAJDAGEAIB()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke("\n<alpha=#C0>...", 1960f);
	}

	// Token: 0x06009741 RID: 38721 RVA: 0x0042059B File Offset: 0x0041E79B
	public void OnUndoOnClick()
	{
		if (!this.MMGINBAEHHO)
		{
			return;
		}
		this.MMGINBAEHHO = false;
		AKLFPGMDKLA.EHBBFMCILPC.ENCEBEJPGPL = 0;
		base.Invoke("NDFNOAHJENJ", 0.1f);
	}

	// Token: 0x040029AD RID: 10669
	public static string onPopupGamePassSettingsManagerClose = "OnPopupGamePassSettingsManagerClose";

	// Token: 0x040029AE RID: 10670
	public GameObject hardSpendBlock;

	// Token: 0x040029AF RID: 10671
	public GameObject hardSpendOn;

	// Token: 0x040029B0 RID: 10672
	public GameObject hardSpendOff;

	// Token: 0x040029B1 RID: 10673
	public GameObject undoBlock;

	// Token: 0x040029B2 RID: 10674
	public GameObject undoOn;

	// Token: 0x040029B3 RID: 10675
	public GameObject undoOff;

	// Token: 0x040029B4 RID: 10676
	public GameObject loveInterestsBlock;

	// Token: 0x040029B5 RID: 10677
	public GameObject loveInterestsOn;

	// Token: 0x040029B6 RID: 10678
	public GameObject loveInterestsOff;

	// Token: 0x040029B7 RID: 10679
	public GameObject statsBlock;

	// Token: 0x040029B8 RID: 10680
	public GameObject statsOn;

	// Token: 0x040029B9 RID: 10681
	public GameObject statsOff;

	// Token: 0x040029BA RID: 10682
	public GameObject fastForwardBlock;

	// Token: 0x040029BB RID: 10683
	public GameObject fastForwardOn;

	// Token: 0x040029BC RID: 10684
	public GameObject fastForwardOff;

	// Token: 0x040029BD RID: 10685
	public GameObject autoReadBlock;

	// Token: 0x040029BE RID: 10686
	public GameObject autoReadOn;

	// Token: 0x040029BF RID: 10687
	public GameObject autoReadOff;

	// Token: 0x040029C0 RID: 10688
	private bool NCBPCMHFNLC = true;

	// Token: 0x040029C1 RID: 10689
	private bool MMGINBAEHHO = true;

	// Token: 0x040029C2 RID: 10690
	private bool JOKBNEBGLNG = true;

	// Token: 0x040029C3 RID: 10691
	private bool BGMOEDJBIDO = true;

	// Token: 0x040029C4 RID: 10692
	private bool GPOFCGGGFBA = true;

	// Token: 0x040029C5 RID: 10693
	private bool DNHIJBHJDOD = true;
}
