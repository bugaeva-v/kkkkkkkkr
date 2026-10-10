using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000292 RID: 658
public class StoryChatNonPlayerMessageManager : MonoBehaviour
{
	// Token: 0x06005200 RID: 20992 RVA: 0x0023FB80 File Offset: 0x0023DD80
	public void HPKILNBJCPH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "$USEMAPPINGV2" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005201 RID: 20993 RVA: 0x00003E52 File Offset: 0x00002052
	private void OMNGHDNDLKP()
	{
	}

	// Token: 0x06005202 RID: 20994 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void MFHHONHHCEC()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void AODCOGNJPAD()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005204 RID: 20996 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void OHPIOAOOMPD()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x00003E52 File Offset: 0x00002052
	private void AALDINEPEHJ()
	{
	}

	// Token: 0x06005206 RID: 20998 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIHMCECHLOI()
	{
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void MDLNNHHGIAB()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005208 RID: 21000 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void DMGCMLIGFCG()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x0023FDAC File Offset: 0x0023DFAC
	public void MIFPDCLHKDH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + " " + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
					this.img.gameObject.SetActive(true);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(false);
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

	// Token: 0x0600520B RID: 21003 RVA: 0x00003E52 File Offset: 0x00002052
	private void GEJFLNPODAD()
	{
	}

	// Token: 0x0600520C RID: 21004 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIIKCHOGIBH()
	{
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void PDHDJMJECJA()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void LAPDFFGEDMH()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x00003E52 File Offset: 0x00002052
	private void LPCKKJNJJCB()
	{
	}

	// Token: 0x06005210 RID: 21008 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void GGOHALPJGNL()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005211 RID: 21009 RVA: 0x00003E52 File Offset: 0x00002052
	private void EIMLAEEOBPD()
	{
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x00003E52 File Offset: 0x00002052
	private void OJGELECJGJC()
	{
	}

	// Token: 0x06005213 RID: 21011 RVA: 0x00003E52 File Offset: 0x00002052
	private void LKLNNDNCNOK()
	{
	}

	// Token: 0x06005214 RID: 21012 RVA: 0x0023FFC8 File Offset: 0x0023E1C8
	public void MLJINODMGAB(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "ok" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
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

	// Token: 0x06005215 RID: 21013 RVA: 0x00003E52 File Offset: 0x00002052
	private void NHOGOCONIEF()
	{
	}

	// Token: 0x06005216 RID: 21014 RVA: 0x002401E4 File Offset: 0x0023E3E4
	public void HJMIOBLIDKA(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "textsClient" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005217 RID: 21015 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPHKLKGJEBH()
	{
	}

	// Token: 0x06005218 RID: 21016 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void LOLPCOLPHLJ()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005219 RID: 21017 RVA: 0x00003E52 File Offset: 0x00002052
	private void DBCGAKFDLGD()
	{
	}

	// Token: 0x0600521A RID: 21018 RVA: 0x00003E52 File Offset: 0x00002052
	private void CJOOOIECMAE()
	{
	}

	// Token: 0x0600521B RID: 21019 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void IKLNMKEIIED()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600521C RID: 21020 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x0600521D RID: 21021 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void LOCANABKJEE()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600521E RID: 21022 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void GGKLFBOIKMF()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600521F RID: 21023 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06005220 RID: 21024 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABAKDIDDML()
	{
	}

	// Token: 0x06005221 RID: 21025 RVA: 0x00003E52 File Offset: 0x00002052
	private void GOCGNPBBCIO()
	{
	}

	// Token: 0x06005222 RID: 21026 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPDNJAKBOBC()
	{
	}

	// Token: 0x06005223 RID: 21027 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void DCODCLAGEOO()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005224 RID: 21028 RVA: 0x00003E52 File Offset: 0x00002052
	private void JEFCHJAKBFI()
	{
	}

	// Token: 0x06005225 RID: 21029 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void NGEFPBFMCBP()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005226 RID: 21030 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void JOLAMLIFMMB()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005227 RID: 21031 RVA: 0x00003E52 File Offset: 0x00002052
	private void NAAEEMDBPHC()
	{
	}

	// Token: 0x06005228 RID: 21032 RVA: 0x00240400 File Offset: 0x0023E600
	public void HPDEFGKBAMN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "OnPromoCodeConsumeSuccess" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG), true);
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005229 RID: 21033 RVA: 0x0024061C File Offset: 0x0023E81C
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

	// Token: 0x0600522A RID: 21034 RVA: 0x00003E52 File Offset: 0x00002052
	private void BOILGHBPIIN()
	{
	}

	// Token: 0x0600522B RID: 21035 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void MOEINDNENBB()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600522C RID: 21036 RVA: 0x00003E52 File Offset: 0x00002052
	private void NIIMGPDMHLA()
	{
	}

	// Token: 0x0600522D RID: 21037 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void MOHLNGBBIOB()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600522E RID: 21038 RVA: 0x00240838 File Offset: 0x0023EA38
	public void OELJOHCNBGK(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "ok" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG), false);
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
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 1 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600522F RID: 21039 RVA: 0x00240A54 File Offset: 0x0023EC54
	public void CIHDCFLGEMF(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG), false);
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
					this.img.gameObject.SetActive(false);
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005230 RID: 21040 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void CPLFHCNHAOK()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005231 RID: 21041 RVA: 0x00003E52 File Offset: 0x00002052
	private void PODHOCLABIO()
	{
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void DNANKPMNMIF()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005233 RID: 21043 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void BPFJJHDHJFJ()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005234 RID: 21044 RVA: 0x00003E52 File Offset: 0x00002052
	private void ALIKHOFAKKB()
	{
	}

	// Token: 0x06005235 RID: 21045 RVA: 0x00003E52 File Offset: 0x00002052
	private void EJCFKOHELJO()
	{
	}

	// Token: 0x06005236 RID: 21046 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x06005237 RID: 21047 RVA: 0x00003E52 File Offset: 0x00002052
	private void OPBNOGLBNDK()
	{
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x00003E52 File Offset: 0x00002052
	private void APICKNHCEDC()
	{
	}

	// Token: 0x06005239 RID: 21049 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x0600523A RID: 21050 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void OnDestroy()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600523B RID: 21051 RVA: 0x00240C70 File Offset: 0x0023EE70
	public void KPHAAHFCHFC(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 0 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x00003E52 File Offset: 0x00002052
	private void ECDLFGCLAGG()
	{
	}

	// Token: 0x0600523D RID: 21053 RVA: 0x00003E52 File Offset: 0x00002052
	private void OLEAIHHFBGB()
	{
	}

	// Token: 0x0600523E RID: 21054 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void IEKKNHMNBBK()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x00240E8C File Offset: 0x0023F08C
	public void BIGNJEGMOHJ(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "sto" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005241 RID: 21057 RVA: 0x002410A8 File Offset: 0x0023F2A8
	public void LCMPJIONDMN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "spr" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG), false);
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
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 1 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005242 RID: 21058 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDOPMEKNMEA()
	{
	}

	// Token: 0x06005243 RID: 21059 RVA: 0x002412C4 File Offset: 0x0023F4C4
	public void KJDNFFJJLDN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "youreceived" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005244 RID: 21060 RVA: 0x00003E52 File Offset: 0x00002052
	private void HGEODIPIBPG()
	{
	}

	// Token: 0x06005245 RID: 21061 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void GALHNFOLOAK()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005246 RID: 21062 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPGLEEHELDN()
	{
	}

	// Token: 0x06005247 RID: 21063 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void JPNDEHBIOGC()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005248 RID: 21064 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06005249 RID: 21065 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNDDKLJKFEK()
	{
	}

	// Token: 0x0600524A RID: 21066 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x0600524B RID: 21067 RVA: 0x002414E0 File Offset: 0x0023F6E0
	public void MBMFLGKLEJI(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "https://" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600524C RID: 21068 RVA: 0x002416FC File Offset: 0x0023F8FC
	public void FDNBMHHEBGC(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "hacomp" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG), true);
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
					this.img.gameObject.SetActive(true);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(false);
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

	// Token: 0x0600524D RID: 21069 RVA: 0x00241918 File Offset: 0x0023FB18
	public void FBACPHFCHJK(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "Starting non-parallel download:" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.PLHGCKCFLEN(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
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
			if (DKNNMLIDPHH.LFBDMBGDAKD.Length > 0 && null != this.img)
			{
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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

	// Token: 0x0600524E RID: 21070 RVA: 0x00003E52 File Offset: 0x00002052
	private void IFIDKAKFJID()
	{
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x00241B34 File Offset: 0x0023FD34
	public void AMJMPJAOPIK(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "OnPopupOfferManagerDismissed" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), false);
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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

	// Token: 0x06005250 RID: 21072 RVA: 0x00003E52 File Offset: 0x00002052
	private void MGKMJOOPHNN()
	{
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void JIJNNDHINGK()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void JNKPKECPLCB()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005254 RID: 21076 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06005255 RID: 21077 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void CDLEEFPLPLN()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x00241D50 File Offset: 0x0023FF50
	public void GPJODDANJNF(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + " struck out (" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
					this.img.gameObject.SetActive(true);
					this.img.sprite = assetStoryItem.sprite;
					this.img.SetNativeSize();
					this.body.gameObject.SetActive(true);
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

	// Token: 0x06005258 RID: 21080 RVA: 0x00003E52 File Offset: 0x00002052
	private void LFOJBMBCOFP()
	{
	}

	// Token: 0x06005259 RID: 21081 RVA: 0x00003E52 File Offset: 0x00002052
	private void FEIHEOJPNAK()
	{
	}

	// Token: 0x0600525A RID: 21082 RVA: 0x00003E52 File Offset: 0x00002052
	private void KBGOLEGBMAP()
	{
	}

	// Token: 0x0600525B RID: 21083 RVA: 0x00003E52 File Offset: 0x00002052
	private void LPEDJEOJIFP()
	{
	}

	// Token: 0x0600525C RID: 21084 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLHGINADNCA()
	{
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x00241F6C File Offset: 0x0024016C
	public void GPLADMDJEMC(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "NNN" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x00242188 File Offset: 0x00240388
	public void ACGGMOACIHN(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "ProfileItem2._DownloadCardsPool(): nothing to download around scroll index " + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, false);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LMDACNKELEC(DKNNMLIDPHH.NCAMFPGMCIG), false);
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void CKNCEKFOLKD()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005260 RID: 21088 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void HBDCHDHODOM()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005261 RID: 21089 RVA: 0x00003E52 File Offset: 0x00002052
	private void EGMNIHKPEFF()
	{
	}

	// Token: 0x06005262 RID: 21090 RVA: 0x002423A4 File Offset: 0x002405A4
	public void HBBFAAOICDH(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.FOMGCOENOKO(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "\nEXCEPTION " + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(false);
		}
		this.body.text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.NCAMFPGMCIG), true);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.HBJIJPKHDIO));
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.LFBDMBGDAKD));
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
					this.img.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005263 RID: 21091 RVA: 0x00003E52 File Offset: 0x00002052
	private void IPLLPHBHCPO()
	{
	}

	// Token: 0x06005264 RID: 21092 RVA: 0x002425C0 File Offset: 0x002407C0
	public void HMPPMBGBMMF(GNKBFDPLGOE DKNNMLIDPHH, PFADAFAHNNJ PANKDLOEOHJ, PLFDAJJHMKO BAOKJBJIFBH)
	{
		if (PANKDLOEOHJ.GCMMCPMFJGB)
		{
			string text = ONEHEBIHPFB.DEOJEIEJGEE(DKNNMLIDPHH.BPMFHNDCBOH);
			if (PANKDLOEOHJ.IOCEDIDHFHP)
			{
				text = text + "$USEDELAYV2" + DKNNMLIDPHH.MMIEJKMDJPG;
			}
			this.title.text = text;
			this.title.SetText(text, true);
		}
		else
		{
			this.title.gameObject.SetActive(true);
		}
		this.body.text = ONEHEBIHPFB.NCAMNNEOGKG(DKNNMLIDPHH.NCAMFPGMCIG);
		this.body.SetText(ONEHEBIHPFB.LCKCKFDDDLC(DKNNMLIDPHH.NCAMFPGMCIG), false);
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.GCOHKKMPJKJ(DKNNMLIDPHH.HBJIJPKHDIO));
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
				assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(BAOKJBJIFBH.NCAMFPGMCIG.KNBOMEDEPAD(DKNNMLIDPHH.LFBDMBGDAKD));
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
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005265 RID: 21093 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void HKFKOMMEMCN()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005266 RID: 21094 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDMGHFPMOAG()
	{
	}

	// Token: 0x06005267 RID: 21095 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void FIIIEHFCHMH()
	{
		this.icon.sprite = null;
	}

	// Token: 0x06005268 RID: 21096 RVA: 0x00003E52 File Offset: 0x00002052
	private void LMPBLJPPCKO()
	{
	}

	// Token: 0x06005269 RID: 21097 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void FEBECEEIHBP()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600526A RID: 21098 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void IJPIIOECDGL()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600526B RID: 21099 RVA: 0x00003E52 File Offset: 0x00002052
	private void LIBECOJEBKI()
	{
	}

	// Token: 0x0600526C RID: 21100 RVA: 0x00003E52 File Offset: 0x00002052
	private void OOMMKGMBAGK()
	{
	}

	// Token: 0x0600526D RID: 21101 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void BNJLIDFJOGD()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600526E RID: 21102 RVA: 0x0023FD9C File Offset: 0x0023DF9C
	private void IJCGEFMHPBN()
	{
		this.icon.sprite = null;
	}

	// Token: 0x0600526F RID: 21103 RVA: 0x00003E52 File Offset: 0x00002052
	private void KBGANABGEMK()
	{
	}

	// Token: 0x0400171F RID: 5919
	public TextMeshProUGUI title;

	// Token: 0x04001720 RID: 5920
	public TextMeshProUGUI body;

	// Token: 0x04001721 RID: 5921
	public Image icon;

	// Token: 0x04001722 RID: 5922
	public Image bubble;

	// Token: 0x04001723 RID: 5923
	public VerticalLayoutGroup bubbleVerticalLayout;

	// Token: 0x04001724 RID: 5924
	public Image img;

	// Token: 0x04001725 RID: 5925
	public RectOffset imgPaddingForBubbleVerticalLayout;
}
