using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000317 RID: 791
public class DialogItemShownManager : MonoBehaviour
{
	// Token: 0x06005F20 RID: 24352 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void MOCDMCLPBKC()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F21 RID: 24353 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void MBAJBIPOFCB()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F22 RID: 24354 RVA: 0x002B0A10 File Offset: 0x002AEC10
	public void MLJINODMGAB(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HKJMEKPOPJF() >= 0)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "p" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), true);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F24 RID: 24356 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x06005F25 RID: 24357 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void NKPBKBHKJMA()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F26 RID: 24358 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void LOCANABKJEE()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F27 RID: 24359 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void LDPOIIIAIOA()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x002B0AD0 File Offset: 0x002AECD0
	public void JOFNFNFEFKN(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HKJMEKPOPJF() >= 8)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "ext" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x002B0B90 File Offset: 0x002AED90
	public void MKFEABEHCNA(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GEPGEMMNAPC() >= 1)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupCardOptionsSendGiftClick");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "." + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x002B0C4E File Offset: 0x002AEE4E
	public void BAHGFOFKBIG()
	{
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("RequestGetUserPublicProfile(): timer hit: ", 1093f);
	}

	// Token: 0x06005F2B RID: 24363 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06005F2C RID: 24364 RVA: 0x0012BA7E File Offset: 0x00129C7E
	public void OnButtonClick()
	{
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnCollectableDialogShown", 0f);
	}

	// Token: 0x06005F2D RID: 24365 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void FIIIEHFCHMH()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x002B0C64 File Offset: 0x002AEE64
	public void JKCHIBDFAPA()
	{
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG("consumePromoCode", 1324f);
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x002B0C7C File Offset: 0x002AEE7C
	public void FJEHPCNPMMA(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CLDDLGIGAFB() >= 0)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("profilenametitleshort");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, " already listed by an earlier franchise, skipping" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x002B0D3C File Offset: 0x002AEF3C
	public void MHKHGHMJDJJ(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HKJMEKPOPJF() >= 6)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "mypsuspintrobtn" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGKHCNJOFKN()
	{
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x002B0DFC File Offset: 0x002AEFFC
	public void ACGGMOACIHN(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CLDDLGIGAFB() >= 3)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("StoryStepChoiceMeta.RemoveChoiceDataAtEnd - _choicesToRemove is <= 0.");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "acli20" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void FEBECEEIHBP()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x002B0EBC File Offset: 0x002AF0BC
	public void HBBFAAOICDH(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GEPGEMMNAPC() >= 4)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("BackendOperationsManager.RequestUpdateUserPublicProfileFriends, exception while initializing RSACryptoServiceProvider:");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "rsl" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x002B0F7A File Offset: 0x002AF17A
	public void FJMFJLJOFBK()
	{
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("OnBackendRequestSpinWheelSuccess", 1445f);
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x002B0F90 File Offset: 0x002AF190
	public void AHECDCAEHMB()
	{
		AOBJLALDBAA.EHBBFMCILPC.KGIKHEDLPND("onThemeChange", 628f);
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void PDHDJMJECJA()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void MAHJANFJIMG()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x002B0FA6 File Offset: 0x002AF1A6
	public void OBKAPEDFLBD()
	{
		AOBJLALDBAA.DBLAIDPICIG().DCGCFPHHDDG("importanttitle", 1195f);
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x002B0FBC File Offset: 0x002AF1BC
	public void IMEKEFDBAHH()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("\"", 180f);
	}

	// Token: 0x06005F3F RID: 24383 RVA: 0x002B0FD2 File Offset: 0x002AF1D2
	public void IGNHFEOFDIK()
	{
		AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("PurchaseManagerUnity.OnStoreDisconnected(): Store disconnected details: ", 1514f);
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x002B0FE8 File Offset: 0x002AF1E8
	public void DFFMNJDFNJG(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CLDDLGIGAFB() >= 2)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("SETBIT");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "passpremiumunlockeddescX" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void OnDestroy()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x002B10A6 File Offset: 0x002AF2A6
	public void NMJPOCMMFOK()
	{
		AOBJLALDBAA.KKPFOJMAONG().DCGCFPHHDDG(" missing: ", 1174f);
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKPANMAFAIL()
	{
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void MJGNCOLNIMD()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPCIIBNLBAL()
	{
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x002B10BC File Offset: 0x002AF2BC
	public void FNEBMKPJDJL()
	{
		AOBJLALDBAA.EHBBFMCILPC.LPNCDPHNBJK("", 803f);
	}

	// Token: 0x06005F4A RID: 24394 RVA: 0x00003E52 File Offset: 0x00002052
	private void OKBABBBHMIP()
	{
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x002B10D2 File Offset: 0x002AF2D2
	public void BGJAJIMBJII()
	{
		AOBJLALDBAA.EHBBFMCILPC.DCGCFPHHDDG("makeup", 163f);
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x002B10E8 File Offset: 0x002AF2E8
	public void LAFCNAHCIFJ(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GEPGEMMNAPC() >= 3)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("sketchFrames");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "AssetsManager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x002B11A6 File Offset: 0x002AF3A6
	public void NPJHNDEGMBM()
	{
		AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("\n\n", 62f);
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x002B0A01 File Offset: 0x002AEC01
	private void JLCJJONEBIB()
	{
		this.imageItem.sprite = null;
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06005F50 RID: 24400 RVA: 0x002B11BC File Offset: 0x002AF3BC
	public void APCBKOGALLK(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.CLDDLGIGAFB() >= 0)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("releasedchapterscount");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "mussplash" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()), false);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x002B127C File Offset: 0x002AF47C
	public void OCOOJNFJJPG(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HKJMEKPOPJF() >= 2)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.KNBOMEDEPAD(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.HNPOJCILEHP(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("per");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "</b>" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.MLOLBFBODHD()), true);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x002B133A File Offset: 0x002AF53A
	public void FDPLCOIKMKI()
	{
		AOBJLALDBAA.AGANFKKBPFO().CIGLHCJDDPI("OnBackendRequestBreakCardException", 1200f);
	}

	// Token: 0x06005F53 RID: 24403 RVA: 0x00003E52 File Offset: 0x00002052
	private void EAKEDEEHEDD()
	{
	}

	// Token: 0x06005F54 RID: 24404 RVA: 0x00003E52 File Offset: 0x00002052
	private void KGMBFKBNDPJ()
	{
	}

	// Token: 0x06005F55 RID: 24405 RVA: 0x00003E52 File Offset: 0x00002052
	private void JFEKHEIGPJD()
	{
	}

	// Token: 0x06005F56 RID: 24406 RVA: 0x002B1350 File Offset: 0x002AF550
	public void Initialize(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GEPGEMMNAPC() >= 2)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("DialogItemShownManager.Initialize() - storyItem is null.");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "itemstitle" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.GetSelectedLanguage()), true);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x00003E52 File Offset: 0x00002052
	private void BFGFJIJPMEH()
	{
	}

	// Token: 0x06005F58 RID: 24408 RVA: 0x002B140E File Offset: 0x002AF60E
	public void JELMNKEAGHO()
	{
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("XXX", 1979f);
	}

	// Token: 0x06005F59 RID: 24409 RVA: 0x002B1424 File Offset: 0x002AF624
	public void AJNNDKIIFDN(IPJEBHDFOKM JIKFCLOHJNN, int PLKMJJIIJNO)
	{
		string khjmandedma = JIKFCLOHJNN.IDGJMPJDEAO;
		if (AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.HKJMEKPOPJF() >= 6)
		{
			khjmandedma = AKLFPGMDKLA.EHBBFMCILPC.HFBNIIHICBP(-1).NCAMFPGMCIG.GCOHKKMPJKJ(JIKFCLOHJNN.IDGJMPJDEAO);
		}
		AssetStoryItem assetStoryItem = GKJPOGNFKNK.JJDJNCGJPBF(khjmandedma);
		if (null == assetStoryItem)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("serversync");
			return;
		}
		this.textItem.SetText(GKJPOGNFKNK.DNILNCLIHAP(assetStoryItem.id, "ok" + PLKMJJIIJNO.ToString(), LanguageManager.EHBBFMCILPC.NBANPEIHFOJ()), true);
		this.imageItem.sprite = assetStoryItem.sprite;
		this.imageItem.SetNativeSize();
		GKJPOGNFKNK.PCBCMBKIEKP(this.imageItem, assetStoryItem);
	}

	// Token: 0x06005F5A RID: 24410 RVA: 0x002B14E2 File Offset: 0x002AF6E2
	public void LCDNHOBIPMG()
	{
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("envlhrw", 1723f);
	}

	// Token: 0x06005F5B RID: 24411 RVA: 0x002B14F8 File Offset: 0x002AF6F8
	public void NAGMINKOAAJ()
	{
		AOBJLALDBAA.FILDBDMENPG().EGELHPJBAIC("+", 1509f);
	}

	// Token: 0x04001B2C RID: 6956
	public TextMeshProUGUI textTitle;

	// Token: 0x04001B2D RID: 6957
	public TextMeshProUGUI textAction;

	// Token: 0x04001B2E RID: 6958
	public TextMeshProUGUI textItem;

	// Token: 0x04001B2F RID: 6959
	public Image imageItem;
}
