using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003C8 RID: 968
public class ContentChatItem : ContentScrollItemHider
{
	// Token: 0x0600707A RID: 28794 RVA: 0x0032D834 File Offset: 0x0032BA34
	public void MMNHJINAENE(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.EAHANMIJNOB(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
	}

	// Token: 0x0600707B RID: 28795 RVA: 0x0032D8D8 File Offset: 0x0032BAD8
	public void LHHFFLOPLOH(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.KHLAJNCIKGK(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopCenter);
	}

	// Token: 0x0600707C RID: 28796 RVA: 0x0032D97C File Offset: 0x0032BB7C
	public void CJCAIJFFNBE(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.IDINMHCHHLF(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
	}

	// Token: 0x0600707D RID: 28797 RVA: 0x0032DA20 File Offset: 0x0032BC20
	public void KDDLHGMIPBF(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.MCPDGNJGICJ(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
	}

	// Token: 0x0600707E RID: 28798 RVA: 0x0032DAC4 File Offset: 0x0032BCC4
	public void GINANAIPOPG(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.NNDICCPJOIH(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
	}

	// Token: 0x0600707F RID: 28799 RVA: 0x0032DB68 File Offset: 0x0032BD68
	public void HBOBOKGLEGM(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.LJLFLDDNLLO(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
	}

	// Token: 0x06007081 RID: 28801 RVA: 0x0032DC14 File Offset: 0x0032BE14
	public void JFLPIIBJBLA(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.AHBHMAGKMJJ(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.IAMPILENHLI(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
	}

	// Token: 0x06007082 RID: 28802 RVA: 0x0032DCB8 File Offset: 0x0032BEB8
	public void MFHJBGBCAFA(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.KIGNOOINKLO(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
	}

	// Token: 0x06007083 RID: 28803 RVA: 0x0032DD5C File Offset: 0x0032BF5C
	public void LFPCCLGCPOP(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.JHFHDJNKNOK(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
	}

	// Token: 0x06007084 RID: 28804 RVA: 0x0032DE00 File Offset: 0x0032C000
	public void DAFPJHCHLMH(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.JPDELALNANK(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
	}

	// Token: 0x06007085 RID: 28805 RVA: 0x0032DEA4 File Offset: 0x0032C0A4
	public void DEFHMDCPDDD(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.PJBIMGCKEOE(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomLeft);
	}

	// Token: 0x06007086 RID: 28806 RVA: 0x0032DF48 File Offset: 0x0032C148
	public void EPBDNOFEEJH(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.MJBDMHPHMID().profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.JHFHDJNKNOK(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomRight);
	}

	// Token: 0x06007087 RID: 28807 RVA: 0x0032DFEC File Offset: 0x0032C1EC
	public void KABPKMCFAIH(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.OnSetContent(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
	}

	// Token: 0x06007088 RID: 28808 RVA: 0x0032E090 File Offset: 0x0032C290
	public void GMHKIPNMIDO(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.IAMPILENHLI(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.BottomCenter);
	}

	// Token: 0x06007089 RID: 28809 RVA: 0x0032E134 File Offset: 0x0032C334
	public void COCLEMFDEHK(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.KIGNOOINKLO(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
	}

	// Token: 0x0600708A RID: 28810 RVA: 0x0032E1D8 File Offset: 0x0032C3D8
	public void KCIKGOCKPKB(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.NFOFFLDJDEI(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = true;
		base.GetComponent<ContentSizeFitter>().enabled = true;
		base.EAHANMIJNOB(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.TopRight);
	}

	// Token: 0x0600708B RID: 28811 RVA: 0x0032E27C File Offset: 0x0032C47C
	public void LFJADOIGPPL(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, false);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.PFGGKGGIFJO(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleRight);
	}

	// Token: 0x0600708C RID: 28812 RVA: 0x0032E320 File Offset: 0x0032C520
	public void SetContent(PMEPALPCEAF LEJIJOAOEBK, string KNCFKDLOPGA, string KJPAGOJDABE, bool DNGFNDAMEPK, ScrollRect CHMDIFAGMAG)
	{
		if (!DNGFNDAMEPK)
		{
			this.profileImage.sprite = AssetsManager.EHBBFMCILPC.profileDataAsset.DJNLJPFFMBG(LEJIJOAOEBK.PGJBIPFBMAN());
			this.nameText.SetText(KNCFKDLOPGA, true);
		}
		this.bubbleText.text = KJPAGOJDABE;
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.bubbleText.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.containerToHide.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(base.GetComponent<RectTransform>());
		base.GetComponent<VerticalLayoutGroup>().enabled = false;
		base.GetComponent<ContentSizeFitter>().enabled = false;
		base.OnSetContent(CHMDIFAGMAG);
		base.GetComponent<RectTransform>().BLKGPIFNENN(LCAJAHHLNJN.MiddleCenter);
	}

	// Token: 0x0400219B RID: 8603
	[SerializeField]
	private Image profileImage;

	// Token: 0x0400219C RID: 8604
	[SerializeField]
	private TextMeshProUGUI nameText;

	// Token: 0x0400219D RID: 8605
	[SerializeField]
	private TextMeshProUGUI bubbleText;
}
