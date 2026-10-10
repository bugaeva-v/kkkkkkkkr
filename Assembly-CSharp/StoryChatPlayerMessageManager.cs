using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000177 RID: 375
public class StoryChatPlayerMessageManager : MonoBehaviour
{
	// Token: 0x06002F25 RID: 12069 RVA: 0x00144DF8 File Offset: 0x00142FF8
	public void MLJINODMGAB(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + ", anthologies " + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
		if (null != assetStoryItem)
		{
			this.icon.sprite = assetStoryItem.sprite;
			this.icon.SetNativeSize();
		}
		else
		{
			this.icon.gameObject.SetActive(false);
		}
		try
		{
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 1 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
				if (null != assetStoryItem)
				{
					if (null != this.bubbleVerticalLayout)
					{
						this.bubbleVerticalLayout.padding.left = this.imgPaddingForBubbleVerticalLayout.left;
						this.bubbleVerticalLayout.padding.right = this.imgPaddingForBubbleVerticalLayout.right;
						this.bubbleVerticalLayout.padding.top = this.imgPaddingForBubbleVerticalLayout.top;
						this.bubbleVerticalLayout.padding.bottom = this.imgPaddingForBubbleVerticalLayout.bottom;
					}
					this.img.gameObject.SetActive(false);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(false);
				}
				else
				{
					this.img.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIPLGPPPJCJ()
	{
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x00145014 File Offset: 0x00143214
	private void MFINONMBMLM()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x00145014 File Offset: 0x00143214
	private void OnDestroy()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06002F2D RID: 12077 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMNBHDNALGO()
	{
	}

	// Token: 0x06002F2E RID: 12078 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x00145014 File Offset: 0x00143214
	private void DNANKPMNMIF()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x00145024 File Offset: 0x00143224
	public void KLJIMOGLHEF(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "serversync" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
		if (null != assetStoryItem)
		{
			this.icon.sprite = assetStoryItem.sprite;
			this.icon.SetNativeSize();
		}
		else
		{
			this.icon.gameObject.SetActive(true);
		}
		try
		{
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 1 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
				if (null != assetStoryItem)
				{
					if (null != this.bubbleVerticalLayout)
					{
						this.bubbleVerticalLayout.padding.left = this.imgPaddingForBubbleVerticalLayout.left;
						this.bubbleVerticalLayout.padding.right = this.imgPaddingForBubbleVerticalLayout.right;
						this.bubbleVerticalLayout.padding.top = this.imgPaddingForBubbleVerticalLayout.top;
						this.bubbleVerticalLayout.padding.bottom = this.imgPaddingForBubbleVerticalLayout.bottom;
					}
					this.img.gameObject.SetActive(true);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(true);
				}
				else
				{
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x00003E52 File Offset: 0x00002052
	private void BHDHJLIBHCJ()
	{
	}

	// Token: 0x06002F33 RID: 12083 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x00145240 File Offset: 0x00143440
	public void Initialize(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + ", " + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
		if (null != assetStoryItem)
		{
			this.icon.sprite = assetStoryItem.sprite;
			this.icon.SetNativeSize();
		}
		else
		{
			this.icon.gameObject.SetActive(false);
		}
		try
		{
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 0 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
				if (null != assetStoryItem)
				{
					if (null != this.bubbleVerticalLayout)
					{
						this.bubbleVerticalLayout.padding.left = this.imgPaddingForBubbleVerticalLayout.left;
						this.bubbleVerticalLayout.padding.right = this.imgPaddingForBubbleVerticalLayout.right;
						this.bubbleVerticalLayout.padding.top = this.imgPaddingForBubbleVerticalLayout.top;
						this.bubbleVerticalLayout.padding.bottom = this.imgPaddingForBubbleVerticalLayout.bottom;
					}
					this.img.gameObject.SetActive(true);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(false);
				}
				else
				{
					this.img.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06002F36 RID: 12086 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x00003E52 File Offset: 0x00002052
	private void NCLALOLOIGP()
	{
	}

	// Token: 0x04000EAC RID: 3756
	public TextMeshProUGUI title;

	// Token: 0x04000EAD RID: 3757
	public TextMeshProUGUI body;

	// Token: 0x04000EAE RID: 3758
	public Image icon;

	// Token: 0x04000EAF RID: 3759
	public Image bubble;

	// Token: 0x04000EB0 RID: 3760
	public VerticalLayoutGroup bubbleVerticalLayout;

	// Token: 0x04000EB1 RID: 3761
	public Image img;

	// Token: 0x04000EB2 RID: 3762
	public RectOffset imgPaddingForBubbleVerticalLayout;
}
