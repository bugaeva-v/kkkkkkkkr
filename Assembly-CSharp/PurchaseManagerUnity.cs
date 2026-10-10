using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

// Token: 0x0200017F RID: 383
public class PurchaseManagerUnity : MonoBehaviour, ABLEFBBIBNB
{
	// Token: 0x06002FF9 RID: 12281 RVA: 0x00147B40 File Offset: 0x00145D40
	private void NFFBIFBLDKL(ConfirmedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchaseConfirmed(): Could not find product in purchase confirmation.");
			return;
		}
		Debug.Log("PurchaseManagerUnity.OnPurchaseConfirmed(): Purchase confirmed - Product: " + ((product != null) ? product.definition.id : null));
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x00147B82 File Offset: 0x00145D82
	public void RestorePurchases()
	{
		base.StartCoroutine(this.NFKDMFFNHON());
	}

	// Token: 0x06002FFB RID: 12283 RVA: 0x00147B91 File Offset: 0x00145D91
	private void LDODMANCAGI(string DKNNMLIDPHH)
	{
		Debug.LogError("JJJ" + DKNNMLIDPHH);
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x00147BA4 File Offset: 0x00145DA4
	private void AEOKEOBCFFF()
	{
		PurchaseManagerUnity.AIAJHHHLMNL aiajhhhlmnl;
		aiajhhhlmnl.<>t__builder = AsyncVoidMethodBuilder.Create();
		aiajhhhlmnl.<>4__this = this;
		aiajhhhlmnl.<>1__state = -1;
		aiajhhhlmnl.<>t__builder.Start<PurchaseManagerUnity.AIAJHHHLMNL>(ref aiajhhhlmnl);
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x00147BF0 File Offset: 0x00145DF0
	public bool HOICDJBDLKB()
	{
		return this.GLJDCOPMGBJ != null && this.MBEEEAHJLOF;
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x00147C02 File Offset: 0x00145E02
	private void DNMKJGOLIBO(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("" + string.Format("", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003000 RID: 12288 RVA: 0x00147C30 File Offset: 0x00145E30
	private void FMGJGMNOCMP()
	{
		AOBJLALDBAA.NMGMNAKLLMI().GNBGEMMDGOJ("", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.DBLAIDPICIG().GNBGEMMDGOJ("EnvironmentsPivot", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("lo", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x06003001 RID: 12289 RVA: 0x00147C8E File Offset: 0x00145E8E
	private void FNFOKKAFIME()
	{
		Debug.Log("PurchaseManagerUnity.OnSuccessInitializeGamingServices()");
	}

	// Token: 0x06003002 RID: 12290 RVA: 0x00147C9A File Offset: 0x00145E9A
	private void DNBNCLHPOBD(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("" + string.Format("❤️ ", FNLMOBFNBDO.Count));
	}

	// Token: 0x06003003 RID: 12291 RVA: 0x00147CC0 File Offset: 0x00145EC0
	private void ACJOMELFNHG()
	{
		PurchaseManagerUnity.AIAJHHHLMNL aiajhhhlmnl;
		aiajhhhlmnl.<>t__builder = AsyncVoidMethodBuilder.Create();
		aiajhhhlmnl.<>4__this = this;
		aiajhhhlmnl.<>1__state = -1;
		aiajhhhlmnl.<>t__builder.Start<PurchaseManagerUnity.AIAJHHHLMNL>(ref aiajhhhlmnl);
	}

	// Token: 0x06003004 RID: 12292 RVA: 0x00147CF8 File Offset: 0x00145EF8
	public void OnBackendValidateTransactionSuccess()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateSuccess;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].ODBJLMOLJIE());
				break;
			}
		}
		Debug.Log("PurchaseManagerUnity.OnBackendValidateTransactionSuccess().");
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x00147D98 File Offset: 0x00145F98
	private void HKEJJEIFLEP(Orders FCPFEOCGNMB)
	{
		this.OFGJIAFMBNC = false;
		Debug.Log("$ENABLEAVATAREXTENSION" + string.Format("abs", FCPFEOCGNMB.DeferredOrders.Count, FCPFEOCGNMB.PendingOrders.Count, FCPFEOCGNMB.ConfirmedOrders.Count));
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x00147DF8 File Offset: 0x00145FF8
	private void MKOPAFJNJLB(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("OnAvatarCollectionEdit");
			return;
		}
		if (this.HAEFCIHEKEF() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.Log("acli21" + product.definition.id);
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().CIGLHCJDDPI("myprofilewhatis", 1434f);
		Debug.Log("msgt" + product.definition.id);
		this.SetState(IMBBHEGNCFP.ValidatePending);
		bool flag = true;
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].MFBNOLFOCCL().Equals(OILKKJGIKEA.Info.TransactionID))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.HEAIDLCDNMF(FODKOPMKCBK, OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.AGANFKKBPFO().FKJBCNLONJH("", 1803f);
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x00147EE3 File Offset: 0x001460E3
	public PurchaseFailureReason KMJLGMCEDED()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x06003008 RID: 12296 RVA: 0x00147EEB File Offset: 0x001460EB
	private void GFGKHOCCAFL(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("" + string.Format(" ", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003009 RID: 12297 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> GetValidatedPurchases()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x0600300A RID: 12298 RVA: 0x00147F20 File Offset: 0x00146120
	public OBHDGKFFICI ANDPLADKNMM(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.CAAKHBIFGMG().HCHKAOGEPMG(IHCGMFBCMOO);
		if (!this.HOICDJBDLKB())
		{
			Debug.LogError(">");
		}
		else
		{
			obhdgkffici.HOCIKJAGDMC = this.GLJDCOPMGBJ.GetProductById(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		}
		return obhdgkffici;
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x00147F70 File Offset: 0x00146170
	public bool MNKOKKAJGMP()
	{
		return this.GLJDCOPMGBJ == null || this.MBEEEAHJLOF;
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x00147F84 File Offset: 0x00146184
	private void FOMJPOAFLDA(FailedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("loungeskinnotenough");
			return;
		}
		string[] array = new string[6];
		array[0] = "actant";
		array[1] = ((product != null) ? product.definition.id : null);
		array[3] = "OnToolsPopupSaveToCloudException";
		array[2] = OILKKJGIKEA.FailureReason.ToString();
		array[0] = "،";
		array[2] = OILKKJGIKEA.Details;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600300D RID: 12301 RVA: 0x00148002 File Offset: 0x00146202
	private void BKPHBMOFAIG(DeferredOrder NJBCLIILMOF)
	{
		Debug.Log("PurchaseManagerUnity.OnPurchaseDeferred():Purchase deferred - Product: " + ABLEFBBIBNB.NAOFMENDDLO(ABLEFBBIBNB.ECAJAEBFDJB(NJBCLIILMOF)));
	}

	// Token: 0x0600300E RID: 12302 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP JCBMAKCKLOF()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x00148028 File Offset: 0x00146228
	public OBHDGKFFICI ELEGDCMMNJM(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.GIOAFDDKKHI().AOAGHIJNFDL(IHCGMFBCMOO);
		if (!this.CCDBEDIANDN())
		{
			Debug.LogError("SceneLobbyManager.OpenFocusItem() - using save slot ");
		}
		else
		{
			obhdgkffici.HOCIKJAGDMC = this.GLJDCOPMGBJ.GetProductById(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		}
		return obhdgkffici;
	}

	// Token: 0x06003010 RID: 12304 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP HAEFCIHEKEF()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x00147EE3 File Offset: 0x001460E3
	public PurchaseFailureReason PPNLMJJNCGP()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x06003012 RID: 12306 RVA: 0x00148078 File Offset: 0x00146278
	private void NFNAMKCFKMH(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("spld" + string.Format("", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x000022C3 File Offset: 0x000004C3
	private void OBIGGJFHBKA()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x001480AC File Offset: 0x001462AC
	private void HLAGLPEJKIP(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("noisedigitalovr_2");
			return;
		}
		if (this.NHNCGIBJGBI() == IMBBHEGNCFP.Idle)
		{
			Debug.Log("OnStoryChoiceClickConfimed" + product.definition.id);
			return;
		}
		AOBJLALDBAA.FILDBDMENPG().CIGLHCJDDPI(", ifmissing(1)", 1811f);
		Debug.Log("id" + product.definition.id);
		this.SetState(IMBBHEGNCFP.ValidateException);
		bool flag = false;
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].MDGKLOAPLHI().Equals(OILKKJGIKEA.Info.TransactionID))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.JIAOKCAPDAF(FODKOPMKCBK, OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.NMGMNAKLLMI().MFIAKLMIILK("OnStoryChoiceClick", 1218f);
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x00003E52 File Offset: 0x00002052
	public void RefreshSubscriptions()
	{
	}

	// Token: 0x06003016 RID: 12310 RVA: 0x00148197 File Offset: 0x00146397
	public void KODJKOCLJBC()
	{
		if (!this.PPHGCJGPECL())
		{
			Debug.LogError("OnStoryInterfaceHeaderAvatarClick");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress || this.GPILOGAIBKJ == IMBBHEGNCFP.ValidatePending)
		{
			this.GLJDCOPMGBJ.FetchPurchases();
		}
	}

	// Token: 0x06003017 RID: 12311 RVA: 0x001481D1 File Offset: 0x001463D1
	private void KACKBLENHEE(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("MENU" + string.Format("...", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x00148202 File Offset: 0x00146402
	private void IAIBDCDMPIE(string DKNNMLIDPHH)
	{
		Debug.LogError("ok" + DKNNMLIDPHH);
	}

	// Token: 0x06003019 RID: 12313 RVA: 0x00148214 File Offset: 0x00146414
	private void LKIPNHKAMIG()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log(" ");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.GIPOCHNOIGD;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.LJGLDDOMFHI;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.PIFLNFEFDJF;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.NGMABOGGFNF;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.MOFOOJCKMMI;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.PPFPCEHEKCK;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.PLFPEGPAKEO;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.GLEDPDKBFBC;
				this.GLJDCOPMGBJ.OnPurchasesFetched -= this.HKEJJEIFLEP;
				this.GLJDCOPMGBJ.OnPurchasesFetchFailed -= this.ONEONHFNHBI;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x0600301A RID: 12314 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> GCDLAEGNPBJ()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x0600301B RID: 12315 RVA: 0x00148344 File Offset: 0x00146544
	public void StartPurchase(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.IsInitialized())
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingNotInitialized", 0f);
			Debug.LogError("PurchaseManagerUnity.StartPurchase(): Not initialized.");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.GetState() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.LogError("PurchaseManagerUnity.StartPurchase(): A purchase or validation is in progress. Aborting.");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("PurchaseManagerUnity.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list.");
		}
		Debug.Log("PurchaseManagerUnity.StartPurchase(): Start purchase " + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.SetState(IMBBHEGNCFP.PurchaseInProgress);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x0600301C RID: 12316 RVA: 0x001483E4 File Offset: 0x001465E4
	private void FCAMJBNEKMJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().ONIBLJOFFPG("〈", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.CEGAOMEEFBE().POLEDPIKODD("", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("", new UnityAction(this.GFPAJHDGOJC));
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x00003E52 File Offset: 0x00002052
	private void DCODCLAGEOO()
	{
	}

	// Token: 0x0600301E RID: 12318 RVA: 0x0014844C File Offset: 0x0014664C
	public void PIFLNFEFDJF(FailedOrder OILKKJGIKEA)
	{
		this.SetState((IMBBHEGNCFP)8);
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("ChoiceExtendedManager - IAP shop look without a resolvable price (sku:");
			return;
		}
		this.OECGOKPIKIO = OILKKJGIKEA.FailureReason;
		string[] array = new string[1];
		array[1] = "</i>.";
		array[0] = ((product != null) ? product.definition.id : null);
		array[1] = "OnFriendsPopupSendPremClick";
		array[2] = OILKKJGIKEA.FailureReason.ToString();
		array[6] = "OnCollectableDialogShown";
		array[8] = OILKKJGIKEA.Details;
		Debug.LogError(string.Concat(array));
		AOBJLALDBAA.EHBBFMCILPC.CIGLHCJDDPI("avatarcollectionstutor4title", 1475f);
	}

	// Token: 0x0600301F RID: 12319 RVA: 0x001484F4 File Offset: 0x001466F4
	public void EAFGNFCBDMM(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.HOICDJBDLKB())
		{
			AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK("retry", 761f);
			Debug.LogError("");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.HAEFCIHEKEF() == IMBBHEGNCFP.ValidateException)
		{
			Debug.LogError("filtersAnimation");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("_UVRemap");
		}
		Debug.Log("onThemeChange" + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.SetState(IMBBHEGNCFP.PurchaseInProgress);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x06003020 RID: 12320 RVA: 0x00148593 File Offset: 0x00146793
	public void CompletePurchase(PendingOrder OILKKJGIKEA)
	{
		if (OILKKJGIKEA == null)
		{
			Debug.Log("PurchaseManagerUnity.CompletePurchase(): _order is null, can happen when restoring purchases.");
			return;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerUnity.CompletePurchase(): Not initialized.");
			return;
		}
		this.GLJDCOPMGBJ.ConfirmPurchase(OILKKJGIKEA);
		Debug.Log("PurchaseManagerUnity.CompletePurchase(): Pending product purchase confirmed.");
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x001485CC File Offset: 0x001467CC
	public void OnBackendValidateTransactionFailed()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateFailed;
				break;
			}
		}
		Debug.LogError("PurchaseManagerUnity.OnBackendValidateTransactionFailed().");
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x00148624 File Offset: 0x00146824
	public void GJBMNMOJMOK(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.CCDBEDIANDN())
		{
			AOBJLALDBAA.AGANFKKBPFO().EGELHPJBAIC(" ", 595f);
			Debug.LogError("");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.HAEFCIHEKEF() == IMBBHEGNCFP.ValidateException)
		{
			Debug.LogError(";");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("Critical error, could not load asset bundle:");
		}
		Debug.Log("brsl" + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.ODHAOFMJKLN(IMBBHEGNCFP.PurchaseInProgress);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x06003023 RID: 12323 RVA: 0x001486C4 File Offset: 0x001468C4
	public void LCNPPLCLCBL(FailedOrder OILKKJGIKEA)
	{
		this.HADODBLLLEK(IMBBHEGNCFP.PurchaseFailed);
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("splash");
			return;
		}
		this.OECGOKPIKIO = OILKKJGIKEA.FailureReason;
		string[] array = new string[]
		{
			null,
			"responseCode"
		};
		array[0] = ((product != null) ? product.definition.id : null);
		array[5] = "tmd";
		array[5] = OILKKJGIKEA.FailureReason.ToString();
		array[8] = "...";
		array[6] = OILKKJGIKEA.Details;
		Debug.LogError(string.Concat(array));
		AOBJLALDBAA.AGANFKKBPFO().EFBNBFIDEOK(" ", 1295f);
	}

	// Token: 0x06003024 RID: 12324 RVA: 0x0014876C File Offset: 0x0014696C
	private void BEIJEFPNGHK(ConfirmedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("");
			return;
		}
		Debug.Log("c" + ((product != null) ? product.definition.id : null));
	}

	// Token: 0x06003025 RID: 12325 RVA: 0x001487B0 File Offset: 0x001469B0
	public void GOENCEPCFEI()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.NMGMNAKLLMI().MAPPJFANLDL();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)6;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].CLMIKDHEABK());
				break;
			}
		}
		Debug.Log("OnPromoCodeConsumeException");
	}

	// Token: 0x06003026 RID: 12326 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NDCCFOFPMBM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003027 RID: 12327 RVA: 0x00148850 File Offset: 0x00146A50
	public void MONOHMKGFJL()
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("F1");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.GPILOGAIBKJ == IMBBHEGNCFP.Idle)
		{
			this.GLJDCOPMGBJ.FetchPurchases();
		}
	}

	// Token: 0x06003028 RID: 12328 RVA: 0x0014888C File Offset: 0x00146A8C
	private void AHCAHDDMJND(FailedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("hkfx-91");
			return;
		}
		string[] array = new string[0];
		array[1] = "";
		array[1] = ((product != null) ? product.definition.id : null);
		array[4] = "OnStoryChoiceClickConfimed";
		array[5] = OILKKJGIKEA.FailureReason.ToString();
		array[5] = "cindbns";
		array[4] = OILKKJGIKEA.Details;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x06003029 RID: 12329 RVA: 0x0014890C File Offset: 0x00146B0C
	public void HHKPNKNDBHB()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)6;
				break;
			}
		}
		Debug.LogError(" ");
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00148961 File Offset: 0x00146B61
	private void GIPOCHNOIGD(PendingOrder FODKOPMKCBK)
	{
		this.HLAGLPEJKIP(FODKOPMKCBK, FODKOPMKCBK);
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x0014896B File Offset: 0x00146B6B
	private void HLMHFICHFLD(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("PurchaseManagerUnity.OnProductsFetchedFailed(): " + string.Format("Products fetch failed for {0} products: {1}", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x0600302C RID: 12332 RVA: 0x0014899C File Offset: 0x00146B9C
	private void EDFAPEMNFCH()
	{
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("onAppOpenAttribution", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("importanttitle", new UnityAction(this.FHDDOJCNDBC));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("OnPopupProfileMessageInputCancel", new UnityAction(this.GINIFJMEGAE));
	}

	// Token: 0x0600302D RID: 12333 RVA: 0x001489FA File Offset: 0x00146BFA
	private void LNCNIOOHEMK(string DKNNMLIDPHH)
	{
		Debug.LogError("PurchaseManagerUnity.OnErrorInitializeGamingServices(): Error:" + DKNNMLIDPHH);
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x00003E52 File Offset: 0x00002052
	private void NOFOJGENEEI()
	{
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x00148A0C File Offset: 0x00146C0C
	private void ODJCPKNMCAP()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 1; i < CJEKEHDEBLM.EHBBFMCILPC.LIJGHJKDHKH().Count; i++)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.FILDBDMENPG().DFJNLOIKAGJ()[i].DEJCCBNPFEC), CJEKEHDEBLM.AGANFKKBPFO().PIOKNMNKLBN()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP NHNCGIBJGBI()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x00148A80 File Offset: 0x00146C80
	private void IHKENNKMGMB()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 0; i < CJEKEHDEBLM.GIOAFDDKKHI().PIOKNMNKLBN().Count; i += 0)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.APGODIBBPOD().DFKCBOPNKOG()[i].DEJCCBNPFEC), CJEKEHDEBLM.CAAKHBIFGMG().NGMLFBJEBEE()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x00148AF4 File Offset: 0x00146CF4
	private void GPHNPKOGNCM(FailedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchaseConfirmationFailed(): Could not find product in failed confirmation.");
			return;
		}
		Debug.Log(string.Concat(new string[]
		{
			"PurchaseManagerUnity.OnPurchaseConfirmationFailed(): Confirmation failed - Product: '",
			(product != null) ? product.definition.id : null,
			"',PurchaseFailureReason: ",
			OILKKJGIKEA.FailureReason.ToString(),
			",Confirmation Failure Details: ",
			OILKKJGIKEA.Details
		}));
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x00148B72 File Offset: 0x00146D72
	private void BPNFKBJLEDL(string DKNNMLIDPHH)
	{
		Debug.LogError("(" + DKNNMLIDPHH);
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x00148B84 File Offset: 0x00146D84
	private void CNLNIHFEEPA()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 1; i < CJEKEHDEBLM.AGANFKKBPFO().DEMGKDCNAPK().Count; i++)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.KBNLANLMNCN().DFJNLOIKAGJ()[i].DEJCCBNPFEC), CJEKEHDEBLM.KBNLANLMNCN().DEMGKDCNAPK()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06003035 RID: 12341 RVA: 0x00003E52 File Offset: 0x00002052
	private void PLGGGOBMLIN()
	{
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x00148BF8 File Offset: 0x00146DF8
	private void CNILFBDJKMD(Orders FCPFEOCGNMB)
	{
		this.OFGJIAFMBNC = true;
		Debug.Log("PurchaseManagerUnity.OnPurchasesFetched(): " + string.Format("Purchases fetched successfully, deferred orders: {0}, pending orders: {1}, confirmed orders: {2}", FCPFEOCGNMB.DeferredOrders.Count, FCPFEOCGNMB.PendingOrders.Count, FCPFEOCGNMB.ConfirmedOrders.Count));
	}

	// Token: 0x06003037 RID: 12343 RVA: 0x00148C58 File Offset: 0x00146E58
	public void BMBBOHIMGJO(FailedOrder OILKKJGIKEA)
	{
		this.ODHAOFMJKLN(IMBBHEGNCFP.ValidateInProgress);
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("hoursshort");
			return;
		}
		this.OECGOKPIKIO = OILKKJGIKEA.FailureReason;
		string[] array = new string[4];
		array[0] = "-";
		array[0] = ((product != null) ? product.definition.id : null);
		array[8] = "OnStartFreePassSuccess";
		array[6] = OILKKJGIKEA.FailureReason.ToString();
		array[2] = "brsl";
		array[6] = OILKKJGIKEA.Details;
		Debug.LogError(string.Concat(array));
		AOBJLALDBAA.EHBBFMCILPC.EFBNBFIDEOK("sparkles", 1928f);
	}

	// Token: 0x06003038 RID: 12344 RVA: 0x00148CFD File Offset: 0x00146EFD
	private void PLOFBAGLOED(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("nomorediamonds" + NMPOPLKIHFN.message);
		this.LKIPNHKAMIG();
	}

	// Token: 0x06003039 RID: 12345 RVA: 0x00148D1A File Offset: 0x00146F1A
	public void SetState(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerUnity.SetState(): Not initialized.");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("PurchaseManagerUnity.SetState(). Changing manager state to:" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00148D56 File Offset: 0x00146F56
	private void GLEDPDKBFBC(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("episode" + string.Format("saveslotsswitch", FNLMOBFNBDO.Count));
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00148D7C File Offset: 0x00146F7C
	private void GNBAKJDCDKE(PendingOrder FODKOPMKCBK)
	{
		this.LNGIKHJLNAI(FODKOPMKCBK, FODKOPMKCBK);
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x00148D86 File Offset: 0x00146F86
	private void ONEONHFNHBI(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("asp" + string.Format("", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x00147BF0 File Offset: 0x00145DF0
	public bool PPHGCJGPECL()
	{
		return this.GLJDCOPMGBJ != null && this.MBEEEAHJLOF;
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x00003E52 File Offset: 0x00002052
	public void GCMJGBMPCOO()
	{
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x00148DB2 File Offset: 0x00146FB2
	private void PLFPEGPAKEO(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("%" + string.Format("-", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> IJFNKNLIGFE()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00148DE3 File Offset: 0x00146FE3
	public void HADODBLLLEK(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError(" has no name in the text pack explore tab, group skipped");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("analogglitch20_2" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x00148E1F File Offset: 0x0014701F
	private void DPFJOKJHOJP(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("avind" + string.Format("user", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x00148E50 File Offset: 0x00147050
	private void KMALILGNCKE()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log("hoursshort");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.ENJJIEICJOP;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.LJGLDDOMFHI;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.PIFLNFEFDJF;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.PLOFBAGLOED;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.BKPHBMOFAIG;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.FMDJDFLPBAH;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.PLFPEGPAKEO;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.DNBNCLHPOBD;
				this.GLJDCOPMGBJ.OnPurchasesFetched -= this.HKEJJEIFLEP;
				this.GLJDCOPMGBJ.OnPurchasesFetchFailed -= this.LJJOFMEGEMP;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = true;
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x000022C3 File Offset: 0x000004C3
	private void HKILDOOFJLG()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00148F80 File Offset: 0x00147180
	private void PFBLCBOPOEE(FailedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("");
			return;
		}
		string[] array = new string[0];
		array[1] = "Initializing folderIndex ";
		array[0] = ((product != null) ? product.definition.id : null);
		array[3] = "socialdequeusp1get";
		array[2] = OILKKJGIKEA.FailureReason.ToString();
		array[6] = "varConditionNot";
		array[8] = OILKKJGIKEA.Details;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00003E52 File Offset: 0x00002052
	private void DPGJDANLGIO()
	{
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00148FFE File Offset: 0x001471FE
	private void NJFBCPFBOAP(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("storyChatPrefab is null!" + string.Format("CLIENT.POSTEFFECTS.BLUR", FNLMOBFNBDO.Count));
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00149024 File Offset: 0x00147224
	private void KKCHKOFAANG()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 1; i < CJEKEHDEBLM.OBOOKJPGBJN().IICMMKPGHKI().Count; i += 0)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.OBOOKJPGBJN().DNPADILDKKK()[i].DEJCCBNPFEC), CJEKEHDEBLM.NACPAKLINNH().DFKCBOPNKOG()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00149098 File Offset: 0x00147298
	public void GINIFJMEGAE()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.Idle;
				break;
			}
		}
		Debug.LogError("sketchActors");
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x001490ED File Offset: 0x001472ED
	private IEnumerator MHMKNNFGMKJ()
	{
		while (!this.IsInitialized() || this.GLJDCOPMGBJ.GetProducts() == null || this.PHGMDKIAOGO)
		{
			yield return new WaitForSeconds(1f);
		}
		if (!this.OFGJIAFMBNC)
		{
			this.FetchPurchases();
		}
		while (!this.OFGJIAFMBNC)
		{
			yield return new WaitForSeconds(1f);
		}
		this.JPIICKMAKHO = 1;
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] = (this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] = 0);
		PurchaseManagerUnity.HMAIIJFKCNG hmaiijfkcng = new PurchaseManagerUnity.HMAIIJFKCNG();
		hmaiijfkcng.i = 0;
		while (hmaiijfkcng.i < ODLJHDIGLGO.LNELLCNHKOC.Count)
		{
			if (ODLJHDIGLGO.LNELLCNHKOC[hmaiijfkcng.i].OCFAMHOEIJN.Length > 0)
			{
				Product product = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(hmaiijfkcng.OGJIINDBAMI));
				if (product != null)
				{
					this.CAMAJDDJJJG[this.JPIICKMAKHO, 0]++;
				}
			}
			int i = hmaiijfkcng.i;
			hmaiijfkcng.i = i + 1;
		}
		PurchaseManagerUnity.NHPAKCMLDIB nhpakcmldib = new PurchaseManagerUnity.NHPAKCMLDIB();
		nhpakcmldib.i = 0;
		while (nhpakcmldib.i < ODLJHDIGLGO.LNELLCNHKOC.Count)
		{
			if (ODLJHDIGLGO.LNELLCNHKOC[nhpakcmldib.i].OCFAMHOEIJN.Length > 0)
			{
				Product product2 = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(nhpakcmldib.DOPGDLOGIIK));
				if (product2 != null)
				{
					this.PHGMDKIAOGO = true;
					this.GLJDCOPMGBJ.CheckEntitlement(product2);
				}
			}
			int i = nhpakcmldib.i;
			nhpakcmldib.i = i + 1;
		}
		yield break;
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x001490FC File Offset: 0x001472FC
	private void KEDHPIKFPOE(DeferredOrder NJBCLIILMOF)
	{
		Debug.Log("OnFullscreenCardOptionClick" + ABLEFBBIBNB.NAOFMENDDLO(ABLEFBBIBNB.ECAJAEBFDJB(NJBCLIILMOF)));
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x00147B82 File Offset: 0x00145D82
	public void LKPJPJKCENB()
	{
		base.StartCoroutine(this.NFKDMFFNHON());
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x00149118 File Offset: 0x00147318
	public void OnBackendValidateTransactionException()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateException;
				break;
			}
		}
		Debug.LogError("PurchaseManagerUnity.OnBackendValidateTransactionException().");
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x0014916D File Offset: 0x0014736D
	public IEnumerator HAIGECFCFKF()
	{
		PurchaseManagerUnity.FMNLAIBFGDL fmnlaibfgdl = new PurchaseManagerUnity.FMNLAIBFGDL(1);
		fmnlaibfgdl.<>4__this = this;
		return fmnlaibfgdl;
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x0014917C File Offset: 0x0014737C
	private void GFDCAJIJDOC(Entitlement NFAAHJHABOA)
	{
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0]--;
		if (NFAAHJHABOA.Status == EntitlementStatus.FullyEntitled)
		{
			this.CAMAJDDJJJG[this.JPIICKMAKHO, 1]++;
			if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				this.LNGIKHJLNAI(null, NFAAHJHABOA.Order);
			}
			else if (this.JPIICKMAKHO == 1 && NFAAHJHABOA.Order != null)
			{
				ODLJHDIGLGO.NIAIJIJJAIF(NFAAHJHABOA.Order);
			}
		}
		if (this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
		{
			this.PHGMDKIAOGO = false;
		}
		if (!this.PHGMDKIAOGO)
		{
			if (this.JPIICKMAKHO == 0 && this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] == 0)
			{
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRestorePurchasesZeroResult", 0f);
				return;
			}
			int jpiickmakho = this.JPIICKMAKHO;
		}
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x00149258 File Offset: 0x00147458
	private IEnumerator EDNHKBMHDJO()
	{
		PurchaseManagerUnity.OCEEMICFKMF oceemicfkmf = new PurchaseManagerUnity.OCEEMICFKMF(1);
		oceemicfkmf.<>4__this = this;
		return oceemicfkmf;
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x00149268 File Offset: 0x00147468
	private void KOCEOADMCCA(Entitlement NFAAHJHABOA)
	{
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] -= 0;
		if (NFAAHJHABOA.Status == (EntitlementStatus)8)
		{
			this.CAMAJDDJJJG[this.JPIICKMAKHO, 1]++;
			if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				this.HLAGLPEJKIP(null, NFAAHJHABOA.Order);
			}
			else if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				ODLJHDIGLGO.KCBHHLFKNHJ(NFAAHJHABOA.Order);
			}
		}
		if (this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
		{
			this.PHGMDKIAOGO = false;
		}
		if (!this.PHGMDKIAOGO)
		{
			if (this.JPIICKMAKHO == 0 && this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
			{
				AOBJLALDBAA.DBLAIDPICIG().FDKBIBKABCM("SceneAvatarManager.SyncLobbyAndStoryAvatarComponents(), first story->anthology avatar sync for wardrobe index:", 1557f);
				return;
			}
			int jpiickmakho = this.JPIICKMAKHO;
		}
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00149344 File Offset: 0x00147544
	private void NFFBIFBLDKL(Order OILKKJGIKEA)
	{
		ConfirmedOrder confirmedOrder = OILKKJGIKEA as ConfirmedOrder;
		if (confirmedOrder != null)
		{
			this.NFFBIFBLDKL(confirmedOrder);
			return;
		}
		FailedOrder failedOrder = OILKKJGIKEA as FailedOrder;
		if (failedOrder == null)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchaseConfirmed(): Unknown OnPurchaseConfirmed result.");
			return;
		}
		this.GPHNPKOGNCM(failedOrder);
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x00149381 File Offset: 0x00147581
	private void KEGBPHNAFDG(string DKNNMLIDPHH)
	{
		Debug.LogError("getCardsBalance" + DKNNMLIDPHH);
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x00149394 File Offset: 0x00147594
	private void BCFEEKKHOHK(ConfirmedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("SceneLobbyManager2.BuildGroupedParent() - no group could be built for ");
			return;
		}
		Debug.Log("OnBackendRequestSendMessageSuccess" + ((product != null) ? product.definition.id : null));
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x001493D6 File Offset: 0x001475D6
	private void OGMILPEGHKP(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("Asset bundle assets destroyed:" + NMPOPLKIHFN.message);
		this.HJACDEHIKGJ();
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x001493F4 File Offset: 0x001475F4
	public void JBNNEILEHJI()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.KKPFOJMAONG().OMABKBGMFJF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)5;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].ODBJLMOLJIE());
				break;
			}
		}
		Debug.Log("hidestatinfo");
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00149494 File Offset: 0x00147694
	private void DNMKOCHGLPM(Entitlement NFAAHJHABOA)
	{
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] -= 0;
		if (NFAAHJHABOA.Status == EntitlementStatus.FullyEntitled)
		{
			this.CAMAJDDJJJG[this.JPIICKMAKHO, 1]++;
			if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				this.MKOPAFJNJLB(null, NFAAHJHABOA.Order);
			}
			else if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				ODLJHDIGLGO.HNEPFAMOMPN(NFAAHJHABOA.Order);
			}
		}
		if (this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] == 0)
		{
			this.PHGMDKIAOGO = true;
		}
		if (!this.PHGMDKIAOGO)
		{
			if (this.JPIICKMAKHO == 0 && this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
			{
				AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("OnPurchasingViewLeave", 485f);
				return;
			}
			int jpiickmakho = this.JPIICKMAKHO;
		}
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00149570 File Offset: 0x00147770
	private void OJHPJFCKMAF(FailedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log(">");
			return;
		}
		string[] array = new string[1];
		array[1] = "newtutorialtreasures";
		array[1] = ((product != null) ? product.definition.id : null);
		array[4] = "ratd";
		array[0] = OILKKJGIKEA.FailureReason.ToString();
		array[1] = "loungeskinpurchasepending";
		array[0] = OILKKJGIKEA.Details;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x001495EE File Offset: 0x001477EE
	private void OADBEGOCCBA()
	{
		this.FINEGADJIPG(new Action(this.MBJCCKPMKJM), new Action<string>(this.BPNFKBJLEDL));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x0014961C File Offset: 0x0014781C
	private void FHDHICFCEOG(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerUnity.KLKPOGEEHHI klkpogeehhi = new PurchaseManagerUnity.KLKPOGEEHHI();
		klkpogeehhi._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("production")).ContinueWith(new Action<Task>(klkpogeehhi.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x00149680 File Offset: 0x00147880
	private void PPFPCEHEKCK(Entitlement NFAAHJHABOA)
	{
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] -= 0;
		if (NFAAHJHABOA.Status == EntitlementStatus.EntitledButNotFinished)
		{
			this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] += 0;
			if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				this.HLAGLPEJKIP(null, NFAAHJHABOA.Order);
			}
			else if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				ODLJHDIGLGO.HHNFNOAFICL(NFAAHJHABOA.Order);
			}
		}
		if (this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] == 0)
		{
			this.PHGMDKIAOGO = false;
		}
		if (!this.PHGMDKIAOGO)
		{
			if (this.JPIICKMAKHO == 0 && this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
			{
				AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("+", 729f);
				return;
			}
			int jpiickmakho = this.JPIICKMAKHO;
		}
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x0014975C File Offset: 0x0014795C
	private void KBIIMONICOB()
	{
		this.FINEGADJIPG(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00003E52 File Offset: 0x00002052
	private void CDNMKPKIHIH()
	{
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00149788 File Offset: 0x00147988
	public void OnPurchaseFailed(FailedOrder OILKKJGIKEA)
	{
		this.SetState(IMBBHEGNCFP.PurchaseFailed);
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchaseFailed(): Could not find product in failed order.");
			return;
		}
		this.OECGOKPIKIO = OILKKJGIKEA.FailureReason;
		Debug.LogError(string.Concat(new string[]
		{
			"PurchaseManagerUnity.OnPurchaseFailed(): Confirmation failed - Product: '",
			(product != null) ? product.definition.id : null,
			"',PurchaseFailureReason: ",
			OILKKJGIKEA.FailureReason.ToString(),
			",Confirmation Failure Details: ",
			OILKKJGIKEA.Details
		}));
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchaseFailed", 0f);
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00149830 File Offset: 0x00147A30
	private void CEJKPHFOOMA()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 0; i < CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK().Count; i++)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[i].DEJCCBNPFEC), CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x001498A4 File Offset: 0x00147AA4
	private void HCKLMFNDKBC()
	{
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("...", new UnityAction(this.LNODHEJEOKB));
		AOBJLALDBAA.CEGAOMEEFBE().FNMOFCMDFJP("stat3long", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("NNN", new UnityAction(this.HHKPNKNDBHB));
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00147BF0 File Offset: 0x00145DF0
	public bool CCDBEDIANDN()
	{
		return this.GLJDCOPMGBJ != null && this.MBEEEAHJLOF;
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x00149904 File Offset: 0x00147B04
	private void PNDEPPMAJAJ(ConfirmedOrder OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("ach");
			return;
		}
		Debug.Log("SceneLobbyManager2.RunStorySearch() - ranker returned non-candidate anthology " + ((product != null) ? product.definition.id : null));
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x00149946 File Offset: 0x00147B46
	private void OOOOJNJEODB(List<Product> FNLMOBFNBDO)
	{
		Debug.Log(", also auto-syncing all avatar elements with new index." + string.Format("HTTP ok: ", FNLMOBFNBDO.Count));
	}

	// Token: 0x06003065 RID: 12389 RVA: 0x0014996C File Offset: 0x00147B6C
	private void GEJFLNPODAD()
	{
		this.HCICLEKNGHL(new Action(this.MBJCCKPMKJM), new Action<string>(this.LNCNIOOHEMK));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x00149997 File Offset: 0x00147B97
	public void FetchPurchases()
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerUnity.FetchPurchases(): Not initialized.");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseFailed || this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateSuccess)
		{
			this.GLJDCOPMGBJ.FetchPurchases();
		}
	}

	// Token: 0x06003067 RID: 12391 RVA: 0x001499D1 File Offset: 0x00147BD1
	public void APEMNBGMGOA()
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("mps");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseFailed || this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateSuccess)
		{
			this.GLJDCOPMGBJ.FetchPurchases();
		}
	}

	// Token: 0x06003068 RID: 12392 RVA: 0x00149A0B File Offset: 0x00147C0B
	private void Awake()
	{
		this.FHDHICFCEOG(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003069 RID: 12393 RVA: 0x00149A38 File Offset: 0x00147C38
	private void LJGLDDOMFHI(Order OILKKJGIKEA)
	{
		ConfirmedOrder confirmedOrder = OILKKJGIKEA as ConfirmedOrder;
		if (confirmedOrder != null)
		{
			this.PNDEPPMAJAJ(confirmedOrder);
			return;
		}
		FailedOrder failedOrder = OILKKJGIKEA as FailedOrder;
		if (failedOrder == null)
		{
			Debug.Log("BackendOperationsManager.QueueRequestSaveSync, exception while initializing RSACryptoServiceProvider:");
			return;
		}
		this.AHCAHDDMJND(failedOrder);
	}

	// Token: 0x0600306A RID: 12394 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP GetState()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x0600306B RID: 12395 RVA: 0x00149A75 File Offset: 0x00147C75
	private void EGCLJLMCPKK(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("PurchaseManagerUnity.OnStoreDisconnected(): Store disconnected details: " + NMPOPLKIHFN.message);
		this.HJACDEHIKGJ();
	}

	// Token: 0x0600306C RID: 12396 RVA: 0x00149A94 File Offset: 0x00147C94
	private void KAFMNEINFJC()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("PlayVoiceOver() file not found:", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("UNHIDEAVATARCOMPONENT", new UnityAction(this.EHHIHMFOGHA));
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x0600306D RID: 12397 RVA: 0x00149AF4 File Offset: 0x00147CF4
	public void NNKAPLJCMGE(FailedOrder OILKKJGIKEA)
	{
		this.ODHAOFMJKLN(IMBBHEGNCFP.PurchaseFailed);
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("OnLiveProfileThemesLoaderStop");
			return;
		}
		this.OECGOKPIKIO = OILKKJGIKEA.FailureReason;
		string[] array = new string[]
		{
			null,
			"OnMissingPreview2CdnSuccess"
		};
		array[0] = ((product != null) ? product.definition.id : null);
		array[1] = "eposv";
		array[6] = OILKKJGIKEA.FailureReason.ToString();
		array[0] = "All stories will be synced with server due to duplicate save system error.";
		array[8] = OILKKJGIKEA.Details;
		Debug.LogError(string.Concat(array));
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM("¶", 1759f);
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x00003E52 File Offset: 0x00002052
	public void FNNJCAKDAJF()
	{
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x00148D7C File Offset: 0x00146F7C
	private void ENJJIEICJOP(PendingOrder FODKOPMKCBK)
	{
		this.LNGIKHJLNAI(FODKOPMKCBK, FODKOPMKCBK);
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x00147BF0 File Offset: 0x00145DF0
	public bool IsInitialized()
	{
		return this.GLJDCOPMGBJ != null && this.MBEEEAHJLOF;
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x00149B9C File Offset: 0x00147D9C
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionSuccess", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionFailed", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionException", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x00149BFC File Offset: 0x00147DFC
	public void EHHIHMFOGHA()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateInProgress;
				break;
			}
		}
		Debug.LogError("F");
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x00149C54 File Offset: 0x00147E54
	private void LNGIKHJLNAI(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		Product product = ABLEFBBIBNB.ECAJAEBFDJB(OILKKJGIKEA);
		if (product == null)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchasePendingProcess(): Could not find product in failed order.");
			return;
		}
		if (this.GetState() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.Log("PurchaseManagerUnity.OnPurchasePendingProcess(): Validation already in progress, will finish processing purchase at a later date. Product - " + product.definition.id);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowConnectingAnimation", 0f);
		Debug.Log("PurchaseManagerUnity.OnPurchasePendingProcess(): Product - " + product.definition.id);
		this.SetState(IMBBHEGNCFP.ValidatePending);
		bool flag = false;
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].MDGKLOAPLHI().Equals(OILKKJGIKEA.Info.TransactionID))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.DJDCBDEAPCO(FODKOPMKCBK, OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.EHBBFMCILPC.MBNBMGBEHOC("OnPurchaseSuccess", 1f);
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x00149D3F File Offset: 0x00147F3F
	private void LAENHPJHCDH(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("" + string.Format("center", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP IBAMKDIKJNN()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x06003076 RID: 12406 RVA: 0x00147F70 File Offset: 0x00146170
	public bool JMKELBNJEFK()
	{
		return this.GLJDCOPMGBJ == null || this.MBEEEAHJLOF;
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x00149D70 File Offset: 0x00147F70
	public void BNJNCGGGLDE(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.HOICDJBDLKB())
		{
			Debug.LogError("filtersAnimation");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("Trading/Wished cards userPublicProfile.modified = true hit" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x00149DAC File Offset: 0x00147FAC
	private void AIHIIABBFKE()
	{
		AOBJLALDBAA.EHBBFMCILPC.GNBGEMMDGOJ("WideScreenScaler(): applied a ", new UnityAction(this.LNODHEJEOKB));
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("sfxtimeoutwarning", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("lite game mode on", new UnityAction(this.GFPAJHDGOJC));
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x00147EE3 File Offset: 0x001460E3
	public PurchaseFailureReason MFAAGDBHNIJ()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x0600307A RID: 12410 RVA: 0x00149E0C File Offset: 0x0014800C
	public void MLMIMFDNALG()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.FILDBDMENPG().MAPPJFANLDL();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateFailed;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].CLMIKDHEABK());
				break;
			}
		}
		Debug.Log("OnSketchViewAssetBundleFolderInitializeSuccess");
	}

	// Token: 0x0600307B RID: 12411 RVA: 0x00149EAC File Offset: 0x001480AC
	private void HCICLEKNGHL(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerUnity.KLKPOGEEHHI klkpogeehhi = new PurchaseManagerUnity.KLKPOGEEHHI();
		klkpogeehhi._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("")).ContinueWith(new Action<Task>(klkpogeehhi.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x0600307C RID: 12412 RVA: 0x00149F10 File Offset: 0x00148110
	public void OAEDIAMHBEN()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateException;
				break;
			}
		}
		Debug.LogError("avatarstitle");
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x00149F65 File Offset: 0x00148165
	public void ODHAOFMJKLN(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.PPHGCJGPECL())
		{
			Debug.LogError("OnApplicationFocusBasicSyncSuccess");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("XXX" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x00149258 File Offset: 0x00147458
	private IEnumerator KFJNHGHCIEK()
	{
		PurchaseManagerUnity.OCEEMICFKMF oceemicfkmf = new PurchaseManagerUnity.OCEEMICFKMF(1);
		oceemicfkmf.<>4__this = this;
		return oceemicfkmf;
	}

	// Token: 0x0600307F RID: 12415 RVA: 0x00149FA1 File Offset: 0x001481A1
	private void MBJCCKPMKJM()
	{
		Debug.Log("OnPopupStoryRestartManagerRestartStory");
	}

	// Token: 0x06003080 RID: 12416 RVA: 0x00149FAD File Offset: 0x001481AD
	private void JHDJGGGGFDM(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("doublerewardtut" + NMPOPLKIHFN.message);
		this.LKIPNHKAMIG();
	}

	// Token: 0x06003081 RID: 12417 RVA: 0x00149FCC File Offset: 0x001481CC
	private void DGEBDEGLEIJ()
	{
		AOBJLALDBAA.FILDBDMENPG().FNMOFCMDFJP("energyhinttitle", new UnityAction(this.LNODHEJEOKB));
		AOBJLALDBAA.NMGMNAKLLMI().PEFKJOKLEDL("OnAvatarScreenAssetsDownloadSuccess", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.BIAEAOMHBMM().FNMOFCMDFJP("[LoadingEnv] ", new UnityAction(this.HHKPNKNDBHB));
	}

	// Token: 0x06003082 RID: 12418 RVA: 0x0014A02A File Offset: 0x0014822A
	private void OLCAHJJJHKK()
	{
		Debug.Log(", index:");
	}

	// Token: 0x06003083 RID: 12419 RVA: 0x00147B82 File Offset: 0x00145D82
	public void FOJBIPNPDEM()
	{
		base.StartCoroutine(this.NFKDMFFNHON());
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x0014A036 File Offset: 0x00148236
	private void MOFOOJCKMMI(DeferredOrder NJBCLIILMOF)
	{
		Debug.Log("OnStoryInterfaceHeaderShopClick" + ABLEFBBIBNB.NAOFMENDDLO(ABLEFBBIBNB.ECAJAEBFDJB(NJBCLIILMOF)));
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x0014A054 File Offset: 0x00148254
	public void MLJHLBGBBAL()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.KKPFOJMAONG().AOODBNEBEBJ();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)8;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].CLMIKDHEABK());
				break;
			}
		}
		Debug.Log("' folded into desc");
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> IAJFKDCKGOF()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x06003087 RID: 12423 RVA: 0x0014A0F4 File Offset: 0x001482F4
	private void ADLPKHBHLLH(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerUnity.KLKPOGEEHHI klkpogeehhi = new PurchaseManagerUnity.KLKPOGEEHHI();
		klkpogeehhi._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("OnSaveSlotsItemClose")).ContinueWith(new Action<Task>(klkpogeehhi.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x06003088 RID: 12424 RVA: 0x0014A158 File Offset: 0x00148358
	public void GFPAJHDGOJC()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.Idle;
				break;
			}
		}
		Debug.LogError("OnVideoLayerAutoHide");
	}

	// Token: 0x06003089 RID: 12425 RVA: 0x0014A1AD File Offset: 0x001483AD
	private void FDJGMFNMCEF(string DKNNMLIDPHH)
	{
		Debug.LogError("YYY" + DKNNMLIDPHH);
	}

	// Token: 0x0600308A RID: 12426 RVA: 0x0014A1C0 File Offset: 0x001483C0
	private void MKBADGCCNDJ()
	{
		AOBJLALDBAA.DBLAIDPICIG().BADOPKAOCPE("s", new UnityAction(this.GOENCEPCFEI));
		AOBJLALDBAA.AGANFKKBPFO().GNBGEMMDGOJ("spectrumovr_1", new UnityAction(this.FHDDOJCNDBC));
		AOBJLALDBAA.NMGMNAKLLMI().MFIMALJPCDP("importanttitle", new UnityAction(this.GFPAJHDGOJC));
	}

	// Token: 0x0600308B RID: 12427 RVA: 0x0014A21E File Offset: 0x0014841E
	private void LBFEMODDOGK(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("lf4" + string.Format("', treated as undefined", FNLMOBFNBDO.Count));
	}

	// Token: 0x0600308C RID: 12428 RVA: 0x0014A244 File Offset: 0x00148444
	private void FIIMDIKHIHG()
	{
		AOBJLALDBAA.KKPFOJMAONG().EFKNEJFLGED("wofrewardmsgcard3", new UnityAction(this.JBNNEILEHJI));
		AOBJLALDBAA.DBLAIDPICIG().EFKNEJFLGED("socialrequestsharegr", new UnityAction(this.EHHIHMFOGHA));
		AOBJLALDBAA.KKPFOJMAONG().GNBGEMMDGOJ("storiesSearchConcepts", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x0600308D RID: 12429 RVA: 0x00147EE3 File Offset: 0x001460E3
	public PurchaseFailureReason FEMJHAOKHOC()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x0600308E RID: 12430 RVA: 0x0014A2A4 File Offset: 0x001484A4
	private void CDLLKNKFGPF()
	{
		PurchaseManagerUnity.AIAJHHHLMNL aiajhhhlmnl;
		aiajhhhlmnl.<>t__builder = AsyncVoidMethodBuilder.Create();
		aiajhhhlmnl.<>4__this = this;
		aiajhhhlmnl.<>1__state = -1;
		aiajhhhlmnl.<>t__builder.Start<PurchaseManagerUnity.AIAJHHHLMNL>(ref aiajhhhlmnl);
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x0014A2DC File Offset: 0x001484DC
	private void HJACDEHIKGJ()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log("PurchaseManagerUnity.InvalidateUnityStoreController()");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.ENJJIEICJOP;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.NFFBIFBLDKL;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.OnPurchaseFailed;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.EGCLJLMCPKK;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.BKPHBMOFAIG;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.GFDCAJIJDOC;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.HLMHFICHFLD;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.FODAKFKNAJA;
				this.GLJDCOPMGBJ.OnPurchasesFetched -= this.CNILFBDJKMD;
				this.GLJDCOPMGBJ.OnPurchasesFetchFailed -= this.LJJOFMEGEMP;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x06003090 RID: 12432 RVA: 0x0014A40C File Offset: 0x0014860C
	private void CMAMNPDKNKM()
	{
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("spld", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.CEGAOMEEFBE().MFIMALJPCDP("PassThumbnail.PurchaseProductWebDuration(): productBalanceData is null for suffix '", new UnityAction(this.ENJKMKBDACF));
		AOBJLALDBAA.FILDBDMENPG().EFKNEJFLGED("spld", new UnityAction(this.GFPAJHDGOJC));
	}

	// Token: 0x06003091 RID: 12433 RVA: 0x0014A46C File Offset: 0x0014866C
	public void Initialize()
	{
		if (UnityServices.State == ServicesInitializationState.Uninitialized)
		{
			Debug.LogError("PurchaseManagerUnity.Initialize(): Unity Gaming Services not initialized.");
			this.FHDHICFCEOG(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		}
		if (this.GLJDCOPMGBJ != null)
		{
			return;
		}
		Debug.Log("PurchaseManagerUnity.Initialize()");
		this.FPGCHHGNBEH = new List<NIIJIJNFIIA>();
		PurchaseManagerUnity.MNIFHEBFODF = new List<NIIJIJNFIIA>();
		if (!CJEKEHDEBLM.EHBBFMCILPC.FACIFBONANM())
		{
			Debug.LogError("PurchaseManagerUnity.Initialize(): Trying to initialize PurchaseManagerUnity, but no products are defined.");
			return;
		}
		this.LAEKMIEBOEL();
	}

	// Token: 0x06003092 RID: 12434 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x0014A4ED File Offset: 0x001486ED
	private void BKLLCOMOEGJ(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("\nresults=" + string.Format(" digit", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06003094 RID: 12436 RVA: 0x0014A51C File Offset: 0x0014871C
	public void FHDDOJCNDBC()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.Idle;
				break;
			}
		}
		Debug.LogError("");
	}

	// Token: 0x06003095 RID: 12437 RVA: 0x0014A574 File Offset: 0x00148774
	private void EDGEPNNAKHG(Order OILKKJGIKEA)
	{
		ConfirmedOrder confirmedOrder = OILKKJGIKEA as ConfirmedOrder;
		if (confirmedOrder != null)
		{
			this.PNDEPPMAJAJ(confirmedOrder);
			return;
		}
		FailedOrder failedOrder = OILKKJGIKEA as FailedOrder;
		if (failedOrder == null)
		{
			Debug.Log("Optional npc animation bundle failed to load, continuing without it:");
			return;
		}
		this.PFBLCBOPOEE(failedOrder);
	}

	// Token: 0x06003096 RID: 12438 RVA: 0x0014A5B4 File Offset: 0x001487B4
	private void FMDJDFLPBAH(Entitlement NFAAHJHABOA)
	{
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0]--;
		if (NFAAHJHABOA.Status == EntitlementStatus.EntitledButNotFinished)
		{
			this.CAMAJDDJJJG[this.JPIICKMAKHO, 1]++;
			if (this.JPIICKMAKHO == 0 && NFAAHJHABOA.Order != null)
			{
				this.HLAGLPEJKIP(null, NFAAHJHABOA.Order);
			}
			else if (this.JPIICKMAKHO == 1 && NFAAHJHABOA.Order != null)
			{
				ODLJHDIGLGO.AENHFCHEOGM(NFAAHJHABOA.Order);
			}
		}
		if (this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] == 0)
		{
			this.PHGMDKIAOGO = true;
		}
		if (!this.PHGMDKIAOGO)
		{
			if (this.JPIICKMAKHO == 0 && this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] == 0)
			{
				AOBJLALDBAA.NMGMNAKLLMI().FDKBIBKABCM("spectrum", 1816f);
				return;
			}
			int jpiickmakho = this.JPIICKMAKHO;
		}
	}

	// Token: 0x06003097 RID: 12439 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> LGNKEFCLFPL()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x0014A690 File Offset: 0x00148890
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionSuccess", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionFailed", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionException", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x06003099 RID: 12441 RVA: 0x0014A6F8 File Offset: 0x001488F8
	public void LNODHEJEOKB()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.DBLAIDPICIG().AOODBNEBEBJ();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateSuccess;
				PurchaseManagerUnity.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].DAJNEGNAAHM());
				break;
			}
		}
		Debug.Log("t");
	}

	// Token: 0x0600309A RID: 12442 RVA: 0x0014A798 File Offset: 0x00148998
	private void LAEKMIEBOEL()
	{
		PurchaseManagerUnity.AIAJHHHLMNL aiajhhhlmnl;
		aiajhhhlmnl.<>t__builder = AsyncVoidMethodBuilder.Create();
		aiajhhhlmnl.<>4__this = this;
		aiajhhhlmnl.<>1__state = -1;
		aiajhhhlmnl.<>t__builder.Start<PurchaseManagerUnity.AIAJHHHLMNL>(ref aiajhhhlmnl);
	}

	// Token: 0x0600309B RID: 12443 RVA: 0x00147B82 File Offset: 0x00145D82
	public void NOPKDDLGFMD()
	{
		base.StartCoroutine(this.NFKDMFFNHON());
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x001490ED File Offset: 0x001472ED
	private IEnumerator MJDOFCOMGAE()
	{
		while (!this.IsInitialized() || this.GLJDCOPMGBJ.GetProducts() == null || this.PHGMDKIAOGO)
		{
			yield return new WaitForSeconds(1f);
		}
		if (!this.OFGJIAFMBNC)
		{
			this.FetchPurchases();
		}
		while (!this.OFGJIAFMBNC)
		{
			yield return new WaitForSeconds(1f);
		}
		this.JPIICKMAKHO = 1;
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] = (this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] = 0);
		PurchaseManagerUnity.HMAIIJFKCNG hmaiijfkcng = new PurchaseManagerUnity.HMAIIJFKCNG();
		hmaiijfkcng.i = 0;
		while (hmaiijfkcng.i < ODLJHDIGLGO.LNELLCNHKOC.Count)
		{
			if (ODLJHDIGLGO.LNELLCNHKOC[hmaiijfkcng.i].OCFAMHOEIJN.Length > 0)
			{
				Product product = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(hmaiijfkcng.OGJIINDBAMI));
				if (product != null)
				{
					this.CAMAJDDJJJG[this.JPIICKMAKHO, 0]++;
				}
			}
			int i = hmaiijfkcng.i;
			hmaiijfkcng.i = i + 1;
		}
		PurchaseManagerUnity.NHPAKCMLDIB nhpakcmldib = new PurchaseManagerUnity.NHPAKCMLDIB();
		nhpakcmldib.i = 0;
		while (nhpakcmldib.i < ODLJHDIGLGO.LNELLCNHKOC.Count)
		{
			if (ODLJHDIGLGO.LNELLCNHKOC[nhpakcmldib.i].OCFAMHOEIJN.Length > 0)
			{
				Product product2 = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(nhpakcmldib.DOPGDLOGIIK));
				if (product2 != null)
				{
					this.PHGMDKIAOGO = true;
					this.GLJDCOPMGBJ.CheckEntitlement(product2);
				}
			}
			int i = nhpakcmldib.i;
			nhpakcmldib.i = i + 1;
		}
		yield break;
	}

	// Token: 0x0600309D RID: 12445 RVA: 0x00003E52 File Offset: 0x00002052
	private void CPLFHCNHAOK()
	{
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x00147EE3 File Offset: 0x001460E3
	public PurchaseFailureReason GetPurchaseFailedReason()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x0014A7CF File Offset: 0x001489CF
	private IEnumerator NFKDMFFNHON()
	{
		if (!this.IsInitialized() || !this.OFGJIAFMBNC)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingNotInitialized", 0f);
			Debug.LogError("PurchaseManagerUnity.RestorePurchases(). Not initialized.");
			yield break;
		}
		while (this.PHGMDKIAOGO)
		{
			yield return new WaitForSeconds(1f);
		}
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		this.JPIICKMAKHO = 0;
		this.CAMAJDDJJJG[this.JPIICKMAKHO, 0] = (this.CAMAJDDJJJG[this.JPIICKMAKHO, 1] = 0);
		PurchaseManagerUnity.FNBBBJEICEN fnbbbjeicen = new PurchaseManagerUnity.FNBBBJEICEN();
		fnbbbjeicen.i = 0;
		while (fnbbbjeicen.i < CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK().Count)
		{
			if (CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[fnbbbjeicen.i].OBKCKGHFMDN == ProductType.NonConsumable || CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[fnbbbjeicen.i].OBKCKGHFMDN == ProductType.Subscription)
			{
				Product product = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(fnbbbjeicen.INJANCMEDBE));
				if (product != null)
				{
					this.CAMAJDDJJJG[this.JPIICKMAKHO, 0]++;
				}
			}
			int i = fnbbbjeicen.i;
			fnbbbjeicen.i = i + 1;
		}
		PurchaseManagerUnity.ACEJOBJHHDM acejobjhhdm = new PurchaseManagerUnity.ACEJOBJHHDM();
		acejobjhhdm.i = 0;
		while (acejobjhhdm.i < CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK().Count)
		{
			if (CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[acejobjhhdm.i].OBKCKGHFMDN == ProductType.NonConsumable || CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[acejobjhhdm.i].OBKCKGHFMDN == ProductType.Subscription)
			{
				Product product2 = this.GLJDCOPMGBJ.GetProducts().FirstOrDefault(new Func<Product, bool>(acejobjhhdm.OCGOJGKCPBG));
				if (product2 != null)
				{
					this.PHGMDKIAOGO = true;
					this.GLJDCOPMGBJ.CheckEntitlement(product2);
				}
			}
			int i = acejobjhhdm.i;
			acejobjhhdm.i = i + 1;
		}
		yield break;
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x0014A7E0 File Offset: 0x001489E0
	private void FINEGADJIPG(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerUnity.KLKPOGEEHHI klkpogeehhi = new PurchaseManagerUnity.KLKPOGEEHHI();
		klkpogeehhi._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("")).ContinueWith(new Action<Task>(klkpogeehhi.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x060030A1 RID: 12449 RVA: 0x0014A844 File Offset: 0x00148A44
	private void LJJOFMEGEMP(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("PurchaseManagerUnity.OnPurchasesFetchFailed(): " + string.Format("Purchases fetch failed message: {0}, reason: {1}", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x0014A870 File Offset: 0x00148A70
	public void ENJKMKBDACF()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateException;
				break;
			}
		}
		Debug.LogError("freediamondsbody");
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x0014A8C8 File Offset: 0x00148AC8
	private void MHBPJEDCLDM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.AGANFKKBPFO().MANLHALMCIH("XXX", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.AGANFKKBPFO().POLEDPIKODD("ok", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.FILDBDMENPG().ONIBLJOFFPG("dospns", new UnityAction(this.HHKPNKNDBHB));
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x0014A92E File Offset: 0x00148B2E
	private void NGMABOGGFNF(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("importanttitle" + NMPOPLKIHFN.message);
		this.LKIPNHKAMIG();
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x0014A94C File Offset: 0x00148B4C
	public void DOFLEONDCMI()
	{
		if (UnityServices.State == ServicesInitializationState.Uninitialized)
		{
			Debug.LogError("loungeskinremoved");
			this.HCICLEKNGHL(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		}
		if (this.GLJDCOPMGBJ != null)
		{
			return;
		}
		Debug.Log(" not found.");
		this.FPGCHHGNBEH = new List<NIIJIJNFIIA>();
		PurchaseManagerUnity.MNIFHEBFODF = new List<NIIJIJNFIIA>();
		if (!CJEKEHDEBLM.EHBBFMCILPC.FACIFBONANM())
		{
			Debug.LogError(" could not be loaded from the cache");
			return;
		}
		this.ACJOMELFNHG();
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x0014A9CD File Offset: 0x00148BCD
	private void NHFNDBJKMPA(PurchasesFetchFailureDescription FHANCMLKJAA)
	{
		Debug.Log("+" + string.Format("onwishcardclickbodymatch", FHANCMLKJAA.message, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x0014A9F9 File Offset: 0x00148BF9
	private void FODAKFKNAJA(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("PurchaseManagerUnity.OnProductsFetched(): " + string.Format("Products fetched successfully for {0} products.", FNLMOBFNBDO.Count));
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x0014AA20 File Offset: 0x00148C20
	public void NNEOIFKMDDL(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.MNKOKKAJGMP())
		{
			AOBJLALDBAA.CEGAOMEEFBE().LPNCDPHNBJK("OnPremiumChoiceExecutedAdBased", 234f);
			Debug.LogError("getNpcSkinShopBalance answered without a payload and no cached copy - shop rows unchanged");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.IBAMKDIKJNN() == IMBBHEGNCFP.ValidatePending)
		{
			Debug.LogError("p");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("eventIsHidden");
		}
		Debug.Log("Asset pack has been SKIPPED according to on demand resources data:" + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.SetState(IMBBHEGNCFP.PurchaseInProgress);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x0014AAC0 File Offset: 0x00148CC0
	private void BNEGNCMALOP()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log(" has only ");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.ENJJIEICJOP;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.NFFBIFBLDKL;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.PIFLNFEFDJF;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.PLOFBAGLOED;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.KEDHPIKFPOE;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.DNMKOCHGLPM;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.LAENHPJHCDH;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.DNBNCLHPOBD;
				this.GLJDCOPMGBJ.OnPurchasesFetched -= this.CNILFBDJKMD;
				this.GLJDCOPMGBJ.OnPurchasesFetchFailed -= this.GFGKHOCCAFL;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00003E52 File Offset: 0x00002052
	public void DBNMMEHNHGP()
	{
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x0014ABF0 File Offset: 0x00148DF0
	private void JDKJLOMIAEC(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("avatarstitle" + string.Format("OnLoadingThemeSelectorDownloadFailed", FNLMOBFNBDO.Count));
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x0014AC18 File Offset: 0x00148E18
	public OBHDGKFFICI GetProductData(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IHCGMFBCMOO);
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerUnity.GetProductData(): Not initialized.");
		}
		else
		{
			obhdgkffici.HOCIKJAGDMC = this.GLJDCOPMGBJ.GetProductById(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		}
		return obhdgkffici;
	}

	// Token: 0x060030AD RID: 12461 RVA: 0x00147F17 File Offset: 0x00146117
	public List<NIIJIJNFIIA> NNBLICLCIGB()
	{
		return PurchaseManagerUnity.MNIFHEBFODF;
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x0014AC68 File Offset: 0x00148E68
	private void KFMLOGKINPG()
	{
		this.HCICLEKNGHL(new Action(this.MBJCCKPMKJM), new Action<string>(this.LDODMANCAGI));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x0014AC94 File Offset: 0x00148E94
	public void OFEPODPPNFF(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.PPHGCJGPECL())
		{
			AOBJLALDBAA.AGANFKKBPFO().KMAGHMCCMPG("hiddenTopMatchEntries:", 186f);
			Debug.LogError("profilenametitleshort");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.IBAMKDIKJNN() == IMBBHEGNCFP.ValidateFailed)
		{
			Debug.LogError("Asset bundle assets destroyed:");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("\"");
		}
		Debug.Log("OnSketchThumbnailPublish" + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.BNJNCGGGLDE(IMBBHEGNCFP.Idle);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x0014AD33 File Offset: 0x00148F33
	private void IFMEDGBIGCK(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("" + NMPOPLKIHFN.message);
		this.KMALILGNCKE();
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x0014AD50 File Offset: 0x00148F50
	public IEnumerator ValidatePendingPurchases()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerUnity.ValidatePendingProducts(): Not initialized.");
		}
		else
		{
			this.SetState(IMBBHEGNCFP.ValidateInProgress);
			int processedReceiptsCount = 0;
			bool breakFromLoop = false;
			while (processedReceiptsCount < this.FPGCHHGNBEH.Count)
			{
				if (this.FPGCHHGNBEH[processedReceiptsCount].KMDENBLAEJO != EBPDOCELHBN.Idle)
				{
					switch (this.FPGCHHGNBEH[processedReceiptsCount].KMDENBLAEJO)
					{
					case EBPDOCELHBN.ValidateException:
					case EBPDOCELHBN.ValidateFailed:
						breakFromLoop = true;
						break;
					case EBPDOCELHBN.ValidateSuccess:
					{
						int num = processedReceiptsCount;
						processedReceiptsCount = num + 1;
						if (processedReceiptsCount >= this.FPGCHHGNBEH.Count)
						{
							breakFromLoop = true;
						}
						break;
					}
					default:
						yield return null;
						break;
					}
				}
				yield return null;
				if (breakFromLoop)
				{
					for (;;)
					{
						int num2 = 0;
						for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
						{
							if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateSuccess)
							{
								num2++;
							}
						}
						if (num2 == 0)
						{
							break;
						}
						for (int j = 0; j < this.FPGCHHGNBEH.Count; j++)
						{
							if (this.FPGCHHGNBEH[j].KMDENBLAEJO == EBPDOCELHBN.ValidateSuccess)
							{
								this.FPGCHHGNBEH.RemoveAt(j);
								break;
							}
						}
					}
					if (this.FPGCHHGNBEH.Count == 0)
					{
						this.SetState(IMBBHEGNCFP.ValidateSuccess);
					}
					else
					{
						for (int k = 0; k < this.FPGCHHGNBEH.Count; k++)
						{
							if (this.FPGCHHGNBEH[k].KMDENBLAEJO == EBPDOCELHBN.ValidateException)
							{
								this.SetState(IMBBHEGNCFP.ValidateException);
								break;
							}
							if (this.FPGCHHGNBEH[k].KMDENBLAEJO == EBPDOCELHBN.ValidateFailed)
							{
								this.SetState(IMBBHEGNCFP.ValidateFailed);
								break;
							}
						}
					}
					for (int l = 0; l < this.FPGCHHGNBEH.Count; l++)
					{
						this.FPGCHHGNBEH[l].KMDENBLAEJO = EBPDOCELHBN.Idle;
					}
					break;
				}
				if (this.FPGCHHGNBEH[processedReceiptsCount].KMDENBLAEJO == EBPDOCELHBN.Idle)
				{
					this.FPGCHHGNBEH[processedReceiptsCount].KMDENBLAEJO = EBPDOCELHBN.ValidateInProgress;
					BackendOperationsManager.EHBBFMCILPC.RequestProcessTransaction(this.FPGCHHGNBEH[processedReceiptsCount].CDHKEPGJLMB(), DPGJIJGOCIC.DBLCEBNPIDN(this.FPGCHHGNBEH[processedReceiptsCount].AGAGIJCFIKK()), "OnBackendValidateTransactionSuccess", "OnBackendValidateTransactionFailed", "OnBackendValidateTransactionException");
				}
			}
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnValidatePendingProcessed", 0f);
		yield break;
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x0014801E File Offset: 0x0014621E
	public IMBBHEGNCFP FLPFKBLBFIK()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x0014AD60 File Offset: 0x00148F60
	public void EKIPHKDMFFI(string IHCGMFBCMOO)
	{
		PurchaseManagerUnity.MNIFHEBFODF.Clear();
		if (!this.PPHGCJGPECL())
		{
			AOBJLALDBAA.DBLAIDPICIG().CIGLHCJDDPI("acomp1", 20f);
			Debug.LogError("anthologycompletetitle");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.FLPFKBLBFIK() == IMBBHEGNCFP.Idle)
		{
			Debug.LogError("af_content_id");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("ok");
		}
		Debug.Log("Fixed the bug when anthology progress would not be incremented in SceneStoryManager at chapter end, for story with index:" + DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		this.BNJNCGGGLDE(IMBBHEGNCFP.PurchaseInProgress);
		this.GLJDCOPMGBJ.PurchaseProduct(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
	}

	// Token: 0x04000ED7 RID: 3799
	private PurchaseFailureReason OECGOKPIKIO;

	// Token: 0x04000ED8 RID: 3800
	private IMBBHEGNCFP GPILOGAIBKJ;

	// Token: 0x04000ED9 RID: 3801
	private StoreController GLJDCOPMGBJ;

	// Token: 0x04000EDA RID: 3802
	private bool MBEEEAHJLOF;

	// Token: 0x04000EDB RID: 3803
	private List<NIIJIJNFIIA> FPGCHHGNBEH;

	// Token: 0x04000EDC RID: 3804
	private int[,] CAMAJDDJJJG = new int[2, 2];

	// Token: 0x04000EDD RID: 3805
	private int JPIICKMAKHO;

	// Token: 0x04000EDE RID: 3806
	private bool PHGMDKIAOGO;

	// Token: 0x04000EDF RID: 3807
	private static List<NIIJIJNFIIA> MNIFHEBFODF;

	// Token: 0x04000EE0 RID: 3808
	private bool OFGJIAFMBNC;

	// Token: 0x02000180 RID: 384
	[CompilerGenerated]
	private sealed class KLKPOGEEHHI
	{
		// Token: 0x060030B5 RID: 12469 RVA: 0x0014ADFF File Offset: 0x00148FFF
		internal void MPBHILCNFLE(Task task)
		{
			this._onSuccess();
		}

		// Token: 0x04000EE1 RID: 3809
		public Action _onSuccess;
	}

	// Token: 0x02000183 RID: 387
	[CompilerGenerated]
	private sealed class FNBBBJEICEN
	{
		// Token: 0x060030BF RID: 12479 RVA: 0x0014B306 File Offset: 0x00149506
		internal bool INJANCMEDBE(Product product)
		{
			return product.definition.id == DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[this.i].DEJCCBNPFEC);
		}

		// Token: 0x04000EEB RID: 3819
		public int i;
	}

	// Token: 0x02000184 RID: 388
	[CompilerGenerated]
	private sealed class ACEJOBJHHDM
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x0014B337 File Offset: 0x00149537
		internal bool OCGOJGKCPBG(Product product)
		{
			return product.definition.id == DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[this.i].DEJCCBNPFEC);
		}

		// Token: 0x04000EEC RID: 3820
		public int i;
	}

	// Token: 0x02000186 RID: 390
	[CompilerGenerated]
	private sealed class HMAIIJFKCNG
	{
		// Token: 0x060030C8 RID: 12488 RVA: 0x0014B5A0 File Offset: 0x001497A0
		internal bool OGJIINDBAMI(Product product)
		{
			return product.definition.id == DPGJIJGOCIC.NEDLKPMGHLG(ODLJHDIGLGO.LNELLCNHKOC[this.i].OCFAMHOEIJN);
		}

		// Token: 0x04000EF0 RID: 3824
		public int i;
	}

	// Token: 0x02000187 RID: 391
	[CompilerGenerated]
	private sealed class NHPAKCMLDIB
	{
		// Token: 0x060030CB RID: 12491 RVA: 0x0014B5CC File Offset: 0x001497CC
		internal bool DOPGDLOGIIK(Product product)
		{
			return product.definition.id == DPGJIJGOCIC.NEDLKPMGHLG(ODLJHDIGLGO.LNELLCNHKOC[this.i].OCFAMHOEIJN);
		}

		// Token: 0x04000EF1 RID: 3825
		public int i;
	}
}
