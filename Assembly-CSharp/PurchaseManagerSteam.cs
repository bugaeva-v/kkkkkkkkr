using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Steamworks;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

// Token: 0x0200020D RID: 525
public class PurchaseManagerSteam : MonoBehaviour, ABLEFBBIBNB
{
	// Token: 0x0600419E RID: 16798 RVA: 0x001CADD8 File Offset: 0x001C8FD8
	private void FKAAPHLJBNJ(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("avatarstitle" + string.Format("", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x001CAE0C File Offset: 0x001C900C
	private void LGJHNMFNMDP()
	{
		Debug.LogError("*");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				CommonUserInterface.EHBBFMCILPC.MJNDCBAPEOP(CCOJBMMKNAP.NIOJNOFGIJO().HIPJILDCHJC("Error. FlipEnvironment(), environment "), CCOJBMMKNAP.CPCOODCFDDP().OGKGHLHHAAI("errortitle"), (DFGILFBGPLN)(-73), 1164f, -6);
			}
			this.OKABAJJFEFJ = false;
			this.FKGJJLIFJLO.JNKKIHELBAL(AOBJLALDBAA.FILDBDMENPG().AOODBNEBEBJ());
		}
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x001CAE88 File Offset: 0x001C9088
	private void NLLLCACJKBP(OHHJAMPEKNK KBIIJJJNAND)
	{
		this.OKABAJJFEFJ = false;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		if (KBIIJJJNAND.BEJKCJBHNEO == 0)
		{
			this.MGFNNKGIFOJ(PurchaseFailureReason.UserCancelled);
			return;
		}
		if (this.FKGJJLIFJLO == null)
		{
			this.OnPurchaseFailed((PurchaseFailureReason)103);
			Debug.LogError("o");
			return;
		}
		if (KBIIJJJNAND.PFBDIHBIPPB != Convert.ToUInt64(this.FKGJJLIFJLO.OCAHOPHJJFF))
		{
			Debug.LogError("<size=28px>");
			this.OnPurchaseFailed(PurchaseFailureReason.SignatureInvalid);
			return;
		}
		this.OnPurchasePendingProcess(this.FKGJJLIFJLO);
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x001CAF08 File Offset: 0x001C9108
	private void HJACDEHIKGJ()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log("PurchaseManagerSteam.InvalidateUnityStoreController()");
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
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> GetValidatedPurchases()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x001CB013 File Offset: 0x001C9213
	private void IHFLGPIBAIL()
	{
		Debug.LogError("Starting parallel download:");
		this.OnPurchaseFailed((PurchaseFailureReason)(-106));
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x001CB027 File Offset: 0x001C9227
	private void DFJEPECBGMC()
	{
		Debug.Log("OnCutsceneViewLobbyAssetsDownloadSuccess");
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x001CB033 File Offset: 0x001C9233
	private void FODAKFKNAJA(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("PurchaseManagerSteam.OnProductsFetched(): " + string.Format("Products fetched successfully for {0} products.", FNLMOBFNBDO.Count));
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x001CB05C File Offset: 0x001C925C
	public void JALOHOEMAHK()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.Idle;
				break;
			}
		}
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("socialjoinbody");
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x001CB0BC File Offset: 0x001C92BC
	private void FHDHICFCEOG(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerSteam.PFMJOKKIFBP pfmjokkifbp = new PurchaseManagerSteam.PFMJOKKIFBP();
		pfmjokkifbp._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("production")).ContinueWith(new Action<Task>(pfmjokkifbp.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x00003E52 File Offset: 0x00002052
	public void NOLGJDJKJDL()
	{
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x00003E52 File Offset: 0x00002052
	private void EDJMBKNFDNK(DeferredOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x001CB120 File Offset: 0x001C9320
	private void EAHNODDIIEB()
	{
		PurchaseManagerSteam.OJDPCIHBELK ojdpcihbelk;
		ojdpcihbelk.<>t__builder = AsyncVoidMethodBuilder.Create();
		ojdpcihbelk.<>4__this = this;
		ojdpcihbelk.<>1__state = -1;
		ojdpcihbelk.<>t__builder.Start<PurchaseManagerSteam.OJDPCIHBELK>(ref ojdpcihbelk);
	}

	// Token: 0x060041AB RID: 16811 RVA: 0x001CB157 File Offset: 0x001C9357
	private void ONPHAOIGBNC(IMIPKHBHFJO HLJNJIECKDK)
	{
		if (this.FKGJJLIFJLO != null)
		{
			base.StartCoroutine(this.HMMFKKJKGOL(HLJNJIECKDK));
		}
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> JCAHBONPMDK()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDBIKLMIIDJ(Order OILKKJGIKEA)
	{
	}

	// Token: 0x060041AE RID: 16814 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnPurchaseFailed(FailedOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLNFBMHCKAK(PendingOrder FODKOPMKCBK)
	{
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x00003E52 File Offset: 0x00002052
	public void AMHDECHICAB()
	{
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x001CB16F File Offset: 0x001C936F
	public void PNLADGLJHBN()
	{
		if (SteamManager.JJODFGPAPCG() && (this.JPPKJCMHFMH == null || this.OIHOMGNOJOE == null))
		{
			this.NEDFGMADFPH();
		}
		this.InitializeUnityPurchasing();
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x001CB194 File Offset: 0x001C9394
	public void BDJHDEAINLB(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.ODLGMEHHIAL() == (IMBBHEGNCFP)8)
		{
			Debug.Log("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:" + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("" + OILKKJGIKEA.NIDDOGGMHAA);
		this.LGBNNKNOJPB(IMBBHEGNCFP.ValidateInProgress);
		bool flag = true;
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].CDIHDNKKLCE().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.PDKENAHOGPJ(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.FILDBDMENPG().MBNBMGBEHOC("ZZZ", 1203f);
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x001CB246 File Offset: 0x001C9446
	public void IJOFMOBLBIA(GGAHKHBFKDA LLOOBCHLFNG)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("OnNeedToShowNoMoreEnergyPopup");
			return;
		}
		Debug.Log("");
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x060041B4 RID: 16820 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> KBFCLAILMFF()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x001CB278 File Offset: 0x001C9478
	private void OAFGMHFDAIN(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = false;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.PMABBOJDELF().DOOPGOIBFAN(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "OnSketchThumbnailDuplicatePositive", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()));
		BackendOperationsManager.EHBBFMCILPC.FLDBKFAJLDP(this.FKGJJLIFJLO.BPDNKHBHKMA().ToString(), IHCGMFBCMOO, " ", ", from:", "acd");
	}

	// Token: 0x060041B6 RID: 16822 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	public IEnumerator ValidatePendingPurchases()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
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

	// Token: 0x060041B7 RID: 16823 RVA: 0x00003E52 File Offset: 0x00002052
	public void PCOJBNGAEGA(FailedOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041B9 RID: 16825 RVA: 0x001CB302 File Offset: 0x001C9502
	private void MGBPMBIECJJ(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("" + string.Format("ChoiceExtendedManager - dual-payment look without a resolvable store price (sku:", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x001CB334 File Offset: 0x001C9534
	private void NNDDDJOHPHE()
	{
		Debug.LogError("OnLobbyStartFireworksEffect");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.IKNOFBFMPGA().LHBOBMDENGJ())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.KNKGCDDMLDP().JLBEIFLLBLO("anthology"), CCOJBMMKNAP.HFAKOKBHCGH().GGPHHLGPMPA("-"), DFGILFBGPLN.popupRestorePurchaseConfirm, 992f, -107);
			}
			this.OKABAJJFEFJ = false;
			this.FKGJJLIFJLO.IBHFLEJBDDM(AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF());
		}
	}

	// Token: 0x060041BB RID: 16827 RVA: 0x001CB3B0 File Offset: 0x001C95B0
	public void OPOOAAGAEKH()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)5;
				break;
			}
		}
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("ias");
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x001CB40F File Offset: 0x001C960F
	private void PGPCKAHNLHI()
	{
		Debug.Log("errortitle");
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x001CB41B File Offset: 0x001C961B
	private void EHKLJJHKLGF(string KJPAGOJDABE)
	{
		Debug.LogError("socialfriendmatchinfo1" + KJPAGOJDABE);
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x00003E52 File Offset: 0x00002052
	public void HBFBBGNPIKL()
	{
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x001CB430 File Offset: 0x001C9630
	public void MGPHOKEHLPI(string IHCGMFBCMOO)
	{
		PurchaseManagerSteam.MNIFHEBFODF.Clear();
		if (!this.IsInitialized())
		{
			AOBJLALDBAA.FILDBDMENPG().KMAGHMCCMPG("", 854f);
			Debug.LogError("noiseanalog_2");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.Idle || this.DKCDPLHOALG() == IMBBHEGNCFP.Idle)
		{
			Debug.LogError("retry");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("=");
		}
		Debug.Log("p" + IHCGMFBCMOO);
		this.IDGGLGHACCH(IMBBHEGNCFP.Idle);
		this.OAFGMHFDAIN(IHCGMFBCMOO);
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x001CB4C0 File Offset: 0x001C96C0
	public void NJOAFCCKIIP(GGAHKHBFKDA LLOOBCHLFNG)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError(" ");
			return;
		}
		Debug.Log("x");
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x001CB4F0 File Offset: 0x001C96F0
	public void IJHJGKHCOEL(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("Asset bundle load operation failed during parallel mode." + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x001CB52C File Offset: 0x001C972C
	public void DAFHLFENJNF()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)6;
				break;
			}
		}
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		Debug.LogError("[SkinShop] IAP look without a resolvable store price (shop ");
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x001CB58B File Offset: 0x001C978B
	private IEnumerator DJIOIBNIDMC(IMIPKHBHFJO HLJNJIECKDK)
	{
		PurchaseManagerSteam.JNGNPPAGNBH jngnppagnbh = new PurchaseManagerSteam.JNGNPPAGNBH(1);
		jngnppagnbh.<>4__this = this;
		jngnppagnbh.callback = HLJNJIECKDK;
		return jngnppagnbh;
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x001CB5A1 File Offset: 0x001C97A1
	private void EEHFHOAIOFN()
	{
		Debug.LogError("");
		this.OnPurchaseFailed((PurchaseFailureReason)114);
	}

	// Token: 0x060041C5 RID: 16837 RVA: 0x001CB5B8 File Offset: 0x001C97B8
	public void NFKDBFECGBK(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.EDLKHDGOLCI() == IMBBHEGNCFP.Idle)
		{
			Debug.Log("OnPopupOfferManagerContinueToPurchasingScreen" + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("}" + OILKKJGIKEA.NIDDOGGMHAA);
		this.SetState(IMBBHEGNCFP.Idle);
		bool flag = true;
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].MFBNOLFOCCL().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.GJFPCBGNAKF(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.EHBBFMCILPC.CMLLHEELAAB("</i>", 227f);
	}

	// Token: 0x060041C6 RID: 16838 RVA: 0x001CB66A File Offset: 0x001C986A
	public IEnumerator JHIDONOFJKH()
	{
		PurchaseManagerSteam.KNHLAIKAPFL knhlaikapfl = new PurchaseManagerSteam.KNHLAIKAPFL(1);
		knhlaikapfl.<>4__this = this;
		return knhlaikapfl;
	}

	// Token: 0x060041C7 RID: 16839 RVA: 0x001CB679 File Offset: 0x001C9879
	public PurchaseFailureReason PCDGEOMEFIM()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x060041C8 RID: 16840 RVA: 0x001CB681 File Offset: 0x001C9881
	private void EGCLJLMCPKK(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("PurchaseManagerSteam.OnStoreDisconnected(): Store disconnected details: " + NMPOPLKIHFN.message);
		this.HJACDEHIKGJ();
	}

	// Token: 0x060041C9 RID: 16841 RVA: 0x001CB6A0 File Offset: 0x001C98A0
	public void HLNBCNAPBAI()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)5;
				PurchaseManagerSteam.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].OCHOGBDCBIJ());
				break;
			}
		}
		Debug.Log("ZZZ");
	}

	// Token: 0x060041CA RID: 16842 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDestroy()
	{
	}

	// Token: 0x060041CB RID: 16843 RVA: 0x00003E52 File Offset: 0x00002052
	private void NFFBIFBLDKL(Order OILKKJGIKEA)
	{
	}

	// Token: 0x060041CC RID: 16844 RVA: 0x001CB740 File Offset: 0x001C9940
	public void InitializeUnityPurchasing()
	{
		if (UnityServices.State == ServicesInitializationState.Uninitialized)
		{
			Debug.LogError("PurchaseManagerSteam.Initialize(): Unity Gaming Services not initialized.");
			this.FHDHICFCEOG(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		}
		if (this.GLJDCOPMGBJ != null)
		{
			return;
		}
		Debug.Log("PurchaseManagerSteam.InitializeUnityPurchasing()");
		this.FPGCHHGNBEH = new List<NIIJIJNFIIA>();
		PurchaseManagerSteam.MNIFHEBFODF = new List<NIIJIJNFIIA>();
		if (!CJEKEHDEBLM.EHBBFMCILPC.FACIFBONANM())
		{
			Debug.LogError("PurchaseManagerSteam.Initialize(): Trying to initialize PurchaseManagerSteam, but no products are defined.");
			return;
		}
		this.LAEKMIEBOEL();
	}

	// Token: 0x060041CD RID: 16845 RVA: 0x001CB7C4 File Offset: 0x001C99C4
	private void KNMBBOCCBKK(OHHJAMPEKNK KBIIJJJNAND)
	{
		this.OKABAJJFEFJ = false;
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		if (KBIIJJJNAND.BEJKCJBHNEO == 0)
		{
			this.MGFNNKGIFOJ(PurchaseFailureReason.StoreNotConnected);
			return;
		}
		if (this.FKGJJLIFJLO == null)
		{
			this.MGFNNKGIFOJ((PurchaseFailureReason)39);
			Debug.LogError("socialmaketradeable");
			return;
		}
		if (KBIIJJJNAND.PFBDIHBIPPB != Convert.ToUInt64(this.FKGJJLIFJLO.OCAHOPHJJFF))
		{
			Debug.LogError("DDD");
			this.OnPurchaseFailed(PurchaseFailureReason.StoreNotConnected);
			return;
		}
		this.MPKGAOFLKCF(this.FKGJJLIFJLO);
	}

	// Token: 0x060041CE RID: 16846 RVA: 0x001CB843 File Offset: 0x001C9A43
	private void Awake()
	{
		this.FHDHICFCEOG(new Action(this.FNFOKKAFIME), new Action<string>(this.LNCNIOOHEMK));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> CDOPLCDLENG()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x001CB86E File Offset: 0x001C9A6E
	public void LGBNNKNOJPB(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("apks");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("env" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x060041D1 RID: 16849 RVA: 0x001CB8AA File Offset: 0x001C9AAA
	private void DMNDFFLFCED(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("OnPopupSaveSlotInputCancel" + NMPOPLKIHFN.message);
		this.DHFPOIFAPBA();
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x001CB8C7 File Offset: 0x001C9AC7
	private void HJINLBFJJHL(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("errortitle" + NMPOPLKIHFN.message);
		this.EDIOECGGAOM();
	}

	// Token: 0x060041D3 RID: 16851 RVA: 0x001CB8E4 File Offset: 0x001C9AE4
	private void MBFENGNIEFD(string KJPAGOJDABE)
	{
		Debug.LogError("" + KJPAGOJDABE);
	}

	// Token: 0x060041D4 RID: 16852 RVA: 0x001CB8F8 File Offset: 0x001C9AF8
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
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("PurchaseManagerSteam.OnBackendValidateTransactionFailed().");
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x001CB958 File Offset: 0x001C9B58
	public void OnBackendValidateTransactionSuccess()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateSuccess;
				PurchaseManagerSteam.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].KDJILGELJCN());
				break;
			}
		}
		Debug.Log("PurchaseManagerSteam.OnBackendValidateTransactionSuccess().");
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x001CB9F8 File Offset: 0x001C9BF8
	public void Initialize()
	{
		if (SteamManager.BCPOMPPLLPE && (this.JPPKJCMHFMH == null || this.OIHOMGNOJOE == null))
		{
			this.InitializeSteamPurchasing();
		}
		this.InitializeUnityPurchasing();
	}

	// Token: 0x060041D7 RID: 16855 RVA: 0x001CB58B File Offset: 0x001C978B
	private IEnumerator NLFEDIFAAJO(IMIPKHBHFJO HLJNJIECKDK)
	{
		PurchaseManagerSteam.JNGNPPAGNBH jngnppagnbh = new PurchaseManagerSteam.JNGNPPAGNBH(1);
		jngnppagnbh.<>4__this = this;
		jngnppagnbh.callback = HLJNJIECKDK;
		return jngnppagnbh;
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x001CBA1D File Offset: 0x001C9C1D
	public IMBBHEGNCFP ODLGMEHHIAL()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x001CBA28 File Offset: 0x001C9C28
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendInitiateSteamTransactionSuccess", new UnityAction(this.GMDKLDHJDBM));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendInitiateSteamTransactionFailed", new UnityAction(this.IGPKMPMLLLK));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendInitiateSteamTransactionException", new UnityAction(this.GDLKBGMJGPN));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionSuccess", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionFailed", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionException", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x060041DA RID: 16858 RVA: 0x001CBAD8 File Offset: 0x001C9CD8
	public OBHDGKFFICI GetProductData(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IHCGMFBCMOO);
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.GetProductData(): Not initialized.");
		}
		else
		{
			obhdgkffici.HOCIKJAGDMC = this.GLJDCOPMGBJ.GetProductById(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		}
		return obhdgkffici;
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x00003E52 File Offset: 0x00002052
	public void JDEPDNKEOHC()
	{
	}

	// Token: 0x060041DC RID: 16860 RVA: 0x001CBB28 File Offset: 0x001C9D28
	public void HAIDBLMONIJ()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.FILDBDMENPG().MAPPJFANLDL();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateFailed;
				PurchaseManagerSteam.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.CompletePurchase(this.FPGCHHGNBEH[i].KDJILGELJCN());
				break;
			}
		}
		Debug.Log("string_not_found");
	}

	// Token: 0x060041DD RID: 16861 RVA: 0x00003E52 File Offset: 0x00002052
	private void NACKBBGKFMM(DeferredOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x001CBBC8 File Offset: 0x001C9DC8
	private void EDEOEOKMFNG(string KJPAGOJDABE)
	{
		Debug.LogError("did" + KJPAGOJDABE);
	}

	// Token: 0x060041DF RID: 16863 RVA: 0x00003E52 File Offset: 0x00002052
	public void ABJLIPADLEB(FailedOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041E0 RID: 16864 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIOKLNOMAHH(Entitlement NFAAHJHABOA)
	{
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x001CBBDA File Offset: 0x001C9DDA
	public bool IsInitialized()
	{
		return SteamManager.BCPOMPPLLPE && this.GLJDCOPMGBJ != null && this.JPPKJCMHFMH != null && this.OIHOMGNOJOE != null && this.MBEEEAHJLOF;
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x001CB679 File Offset: 0x001C9879
	public PurchaseFailureReason GetPurchaseFailedReason()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x001CBC03 File Offset: 0x001C9E03
	private IEnumerator IIKENFLECCG(IMIPKHBHFJO HLJNJIECKDK)
	{
		yield return new WaitForSeconds(0.5f);
		if (HLJNJIECKDK.PJBCJPJJADF == 0 && this.OKABAJJFEFJ && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("steamwaitforuseraction"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else if (HLJNJIECKDK.PJBCJPJJADF == 1 && this.OKABAJJFEFJ && CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		yield break;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x001CBA1D File Offset: 0x001C9C1D
	public IMBBHEGNCFP DKCDPLHOALG()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x001CBC1C File Offset: 0x001C9E1C
	public void StartPurchase(string IHCGMFBCMOO)
	{
		PurchaseManagerSteam.MNIFHEBFODF.Clear();
		if (!this.IsInitialized())
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingNotInitialized", 0f);
			Debug.LogError("PurchaseManagerSteam.StartPurchase(): Not initialized.");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.GetState() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.LogError("PurchaseManagerSteam.StartPurchase(): A purchase or validation is in progress. Aborting.");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("PurchaseManagerSteam.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list.");
		}
		Debug.Log("PurchaseManagerSteam.StartPurchase(): Start purchase " + IHCGMFBCMOO);
		this.SetState(IMBBHEGNCFP.PurchaseInProgress);
		this.GDGGGJPBMOI(IHCGMFBCMOO);
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x001CBCAC File Offset: 0x001C9EAC
	private void PEMCPHEJGOG(string KJPAGOJDABE)
	{
		Debug.LogError("OnSaveSlotsItemSlotChanged" + KJPAGOJDABE);
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMHLOLHAHHI(Order OILKKJGIKEA)
	{
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x001CBCC0 File Offset: 0x001C9EC0
	private void LECPDIEBFLD()
	{
		PurchaseManagerSteam.OJDPCIHBELK ojdpcihbelk;
		ojdpcihbelk.<>t__builder = AsyncVoidMethodBuilder.Create();
		ojdpcihbelk.<>4__this = this;
		ojdpcihbelk.<>1__state = -1;
		ojdpcihbelk.<>t__builder.Start<PurchaseManagerSteam.OJDPCIHBELK>(ref ojdpcihbelk);
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x001CBCF7 File Offset: 0x001C9EF7
	private void DLCICDJACIP(string KJPAGOJDABE)
	{
		Debug.LogError("OnBackendRequestSendMessageSuccess" + KJPAGOJDABE);
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x001CBD0C File Offset: 0x001C9F0C
	private void AOPGONGKADA(OHHJAMPEKNK KBIIJJJNAND)
	{
		this.OKABAJJFEFJ = false;
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		if (KBIIJJJNAND.BEJKCJBHNEO == 0)
		{
			this.OnPurchaseFailed(PurchaseFailureReason.UserCancelled);
			return;
		}
		if (this.FKGJJLIFJLO == null)
		{
			this.OnPurchaseFailed(PurchaseFailureReason.Unknown);
			Debug.LogError("PurchaseManagerSteam.InitiateTransactionSteam(). Condition not passed: initiatedPurchase is null. Aborting.");
			return;
		}
		if (KBIIJJJNAND.PFBDIHBIPPB != Convert.ToUInt64(this.FKGJJLIFJLO.OCAHOPHJJFF))
		{
			Debug.LogError("PurchaseManagerSteam.InitiateTransactionSteam(). pCallback.m_ulOrderID != initiatedPurchase.orderId. Aborting.");
			this.OnPurchaseFailed(PurchaseFailureReason.SignatureInvalid);
			return;
		}
		this.OnPurchasePendingProcess(this.FKGJJLIFJLO);
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x00003E52 File Offset: 0x00002052
	public void LELMGBPEAGI()
	{
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x001CBD8B File Offset: 0x001C9F8B
	private void PINDFDKJDIP()
	{
		Debug.Log("$jp");
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x00003E52 File Offset: 0x00002052
	public void CKNOFEIIECA()
	{
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBNDOFAMMMM(DeferredOrder NJBCLIILMOF)
	{
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x00003E52 File Offset: 0x00002052
	private void ENJJIEICJOP(PendingOrder FODKOPMKCBK)
	{
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x001CBD98 File Offset: 0x001C9F98
	private void ODBONMMMNJD()
	{
		Debug.LogError("OnEmailSubscribeException");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.IKNOFBFMPGA().AnyGenericPopupIsActive())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.ONCPHEEJLOP().GLEFEKBDHNK("UpdateStatsOnOffState"), CCOJBMMKNAP.NIOJNOFGIJO().HIPJILDCHJC("ok"), DFGILFBGPLN.popupNotEnoughHardCurrency, 1790f, -56);
			}
			this.OKABAJJFEFJ = false;
			this.FKGJJLIFJLO.GAEPBGNKJBA(AOBJLALDBAA.NMGMNAKLLMI().EEEOAHJMGFB());
		}
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00003E52 File Offset: 0x00002052
	private void CFHFGNOIPEC()
	{
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x001CBE11 File Offset: 0x001CA011
	public void KCMLKPBMABE(GGAHKHBFKDA LLOOBCHLFNG)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("loop");
			return;
		}
		Debug.Log("OnSettingsPopupCloseAndNeedToShowGameModeNotif");
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x00003E52 File Offset: 0x00002052
	private void ALAANDAKFFD()
	{
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x00003E52 File Offset: 0x00002052
	public void FKKFCAOKIHH()
	{
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x001CBE41 File Offset: 0x001CA041
	private void MDJNPIHMPOE()
	{
		Debug.Log("trsv");
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x001CBE50 File Offset: 0x001CA050
	public void EPJBFCIAJHN(string IHCGMFBCMOO)
	{
		PurchaseManagerSteam.MNIFHEBFODF.Clear();
		if (!this.IsInitialized())
		{
			AOBJLALDBAA.NMGMNAKLLMI().EFBNBFIDEOK("yes", 327f);
			Debug.LogError("");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.EDLKHDGOLCI() == IMBBHEGNCFP.ValidatePending)
		{
			Debug.LogError("");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("OnBackendGetPublicProfileHallOfFameMoreSuccess");
		}
		Debug.Log("$" + IHCGMFBCMOO);
		this.IJHJGKHCOEL(IMBBHEGNCFP.Idle);
		this.GKEBECPFBCH(IHCGMFBCMOO);
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x001CBEE0 File Offset: 0x001CA0E0
	private void LDGIJCDJEDJ()
	{
		Debug.Log("[LoadingEnv] ");
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x001CBEEC File Offset: 0x001CA0EC
	public void InitializeSteamPurchasing()
	{
		this.JPPKJCMHFMH = EPJEPKKGDLI<OHHJAMPEKNK>.HJNOKBOHODP(new EPJEPKKGDLI<OHHJAMPEKNK>.DMGGAJDGAFJ(this.AOPGONGKADA));
		this.OIHOMGNOJOE = EPJEPKKGDLI<IMIPKHBHFJO>.HJNOKBOHODP(new EPJEPKKGDLI<IMIPKHBHFJO>.DMGGAJDGAFJ(this.LLNJBOJPLFM));
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x001CBF24 File Offset: 0x001CA124
	private void EDIOECGGAOM()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log("iapSku");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.HLNFBMHCKAK;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.EMHLOLHAHHI;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.OnPurchaseFailed;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.DMNDFFLFCED;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.EDJMBKNFDNK;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.KFFCAEGCCIL;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.FKAAPHLJBNJ;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.FODAKFKNAJA;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x00003E52 File Offset: 0x00002052
	public void RestorePurchases()
	{
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x001CC028 File Offset: 0x001CA228
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
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("PurchaseManagerSteam.OnBackendValidateTransactionException().");
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x001CC088 File Offset: 0x001CA288
	public void KCNIAAOAHNL()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)8;
				break;
			}
		}
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("");
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x001CC0E8 File Offset: 0x001CA2E8
	private void CMKAADFBHHF(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerSteam.PFMJOKKIFBP pfmjokkifbp = new PurchaseManagerSteam.PFMJOKKIFBP();
		pfmjokkifbp._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("mypsuspendedbody2")).ContinueWith(new Action<Task>(pfmjokkifbp.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x001CC14C File Offset: 0x001CA34C
	private void HJIFDINILFA()
	{
		Debug.LogError("s, ");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				CommonUserInterface.IKNOFBFMPGA().ShowGenericPopupNoButtons(CCOJBMMKNAP.PLJMLDOCPNM().HDIPNMFHIEJ("OnChoiceExtendedEnvironmentChange"), CCOJBMMKNAP.ILACPHFEDEP().BGELFMIOBCL("item"), (DFGILFBGPLN)(-113), 1440f, 41);
			}
			this.OKABAJJFEFJ = true;
			this.FKGJJLIFJLO.DOAKFCNHGAC(AOBJLALDBAA.EHBBFMCILPC.AOODBNEBEBJ());
		}
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x001CC1C5 File Offset: 0x001CA3C5
	private void HLMHFICHFLD(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("PurchaseManagerSteam.OnProductsFetchedFailed(): " + string.Format("Products fetch failed for {0} products: {1}", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x06004200 RID: 16896 RVA: 0x001CC1F6 File Offset: 0x001CA3F6
	private void AEOKBMNIOAI()
	{
		Debug.LogError("</i>");
		this.OnPurchaseFailed((PurchaseFailureReason)(-128));
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x001CC20C File Offset: 0x001CA40C
	public OBHDGKFFICI MDFDGLDJHLL(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.AGANFKKBPFO().ICBJCNKKGPJ(IHCGMFBCMOO);
		if (!this.IsInitialized())
		{
			Debug.LogError("frsgcmsg64");
		}
		else
		{
			obhdgkffici.HOCIKJAGDMC = this.GLJDCOPMGBJ.GetProductById(DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO));
		}
		return obhdgkffici;
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x001CC25C File Offset: 0x001CA45C
	private void CEJKPHFOOMA()
	{
		List<ProductDefinition> list = new List<ProductDefinition>();
		for (int i = 0; i < CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK().Count; i++)
		{
			list.Add(new ProductDefinition(DPGJIJGOCIC.NEDLKPMGHLG(CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[i].DEJCCBNPFEC), CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[i].OBKCKGHFMDN));
		}
		this.GLJDCOPMGBJ.FetchProducts(list, null);
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	public IEnumerator JJINHNAGNEN()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
		}
		else
		{
			this.SetState(IMBBHEGNCFP.ValidateInProgress);
			processedReceiptsCount = 0;
			breakFromLoop = false;
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

	// Token: 0x06004204 RID: 16900 RVA: 0x001CC2D0 File Offset: 0x001CA4D0
	public void GDBDHBHHNJJ()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.NMGMNAKLLMI().OMABKBGMFJF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)8;
				PurchaseManagerSteam.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.KCMLKPBMABE(this.FPGCHHGNBEH[i].OCHOGBDCBIJ());
				break;
			}
		}
		Debug.Log("");
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x001CC370 File Offset: 0x001CA570
	private void GDGGGJPBMOI(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = false;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "iaps", LanguageManager.EHBBFMCILPC.GetSelectedLanguage()));
		BackendOperationsManager.EHBBFMCILPC.RequestProcessTransaction(this.FKGJJLIFJLO.CDHKEPGJLMB().ToString(), IHCGMFBCMOO, "OnBackendInitiateSteamTransactionSuccess", "OnBackendInitiateSteamTransactionFailed", "OnBackendInitiateSteamTransactionException");
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x001CB679 File Offset: 0x001C9879
	public PurchaseFailureReason OJNIFFHMGPG()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x001CC3EB File Offset: 0x001CA5EB
	private void IGPKMPMLLLK()
	{
		Debug.LogError("OnBackendInitiateSteamTransactionFailed");
		this.OnPurchaseFailed(PurchaseFailureReason.Unknown);
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x001CC400 File Offset: 0x001CA600
	private void MIOKJGDONNM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.BIAEAOMHBMM().KDIFKFKMCOH("", new UnityAction(this.NNDDDJOHPHE));
		AOBJLALDBAA.CEGAOMEEFBE().NAMMLDPCHJO("mps", new UnityAction(this.IHFLGPIBAIL));
		AOBJLALDBAA.BIAEAOMHBMM().PBELMJCPJMK("franchisepattern", new UnityAction(this.EEHFHOAIOFN));
		AOBJLALDBAA.AGANFKKBPFO().MHLNJIACIGO("loungeplayfirst", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.AGANFKKBPFO().PBELMJCPJMK("country_code", new UnityAction(this.KCNIAAOAHNL));
		AOBJLALDBAA.AGANFKKBPFO().KDIFKFKMCOH("\n", new UnityAction(this.GIKNJMHDJFD));
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x001CC4B8 File Offset: 0x001CA6B8
	private void HAEINOAOGMO(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = false;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.NACPAKLINNH().AOAGHIJNFDL(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "0", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()));
		BackendOperationsManager.EHBBFMCILPC.RequestProcessTransaction(this.FKGJJLIFJLO.LFGKAKGFPIC().ToString(), IHCGMFBCMOO, "", "$SKINCHECKPOINTSTART", "'{0}' material null.");
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x00003E52 File Offset: 0x00002052
	public void LOCJHEDHODG(FailedOrder NJBCLIILMOF)
	{
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x001CC533 File Offset: 0x001CA733
	private void OGNGFHPMELA()
	{
		Debug.Log("\f");
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x001CC540 File Offset: 0x001CA740
	private void GKDFGAGAJHG()
	{
		Debug.LogError("newpattern");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ())
			{
				CommonUserInterface.IKNOFBFMPGA().MJNDCBAPEOP(CCOJBMMKNAP.PEBMGCKFNAO().PGKBCNBAOJN(""), CCOJBMMKNAP.PLJMLDOCPNM().DNILNCLIHAP("<"), DFGILFBGPLN.popupDailyReward, 666f, 43);
			}
			this.OKABAJJFEFJ = false;
			this.FKGJJLIFJLO.LPLAOKEAJMH(AOBJLALDBAA.DBLAIDPICIG().OMABKBGMFJF());
		}
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x001CC5BC File Offset: 0x001CA7BC
	private void GKEBECPFBCH(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = true;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.JLEOPAOEFGP().PCBGLNFIPPK(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "cmetaotm", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()));
		BackendOperationsManager.EHBBFMCILPC.FLDBKFAJLDP(this.FKGJJLIFJLO.KOKGBJDCFOI().ToString(), IHCGMFBCMOO, "no", "'", " has no anthology, skipping");
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x001CBA1D File Offset: 0x001C9C1D
	public IMBBHEGNCFP LBAMMGFIAHF()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x001CC638 File Offset: 0x001CA838
	public void AJOMGFKABHG()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateInProgress;
				break;
			}
		}
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		Debug.LogError("cdnerror");
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00003E52 File Offset: 0x00002052
	public void GLDNNKOBPNH()
	{
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x001CC697 File Offset: 0x001CA897
	private void IKFAOLGPMCF()
	{
		Debug.LogError("nick");
		this.MGFNNKGIFOJ((PurchaseFailureReason)(-39));
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x001CC6AB File Offset: 0x001CA8AB
	private void CLOBDHPLDGF()
	{
		Debug.LogError("common");
		this.OnPurchaseFailed((PurchaseFailureReason)73);
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x001CC6BF File Offset: 0x001CA8BF
	private void KFMADDMKEJN(IMIPKHBHFJO HLJNJIECKDK)
	{
		if (this.FKGJJLIFJLO != null)
		{
			base.StartCoroutine(this.NLFEDIFAAJO(HLJNJIECKDK));
		}
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x001CBC03 File Offset: 0x001C9E03
	private IEnumerator JEGOHMBABOK(IMIPKHBHFJO HLJNJIECKDK)
	{
		yield return new WaitForSeconds(0.5f);
		if (HLJNJIECKDK.PJBCJPJJADF == 0 && this.OKABAJJFEFJ && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("steamwaitforuseraction"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else if (HLJNJIECKDK.PJBCJPJJADF == 1 && this.OKABAJJFEFJ && CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		yield break;
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x001CC6D7 File Offset: 0x001CA8D7
	private void MPEEAJLCKHD(List<Product> FNLMOBFNBDO)
	{
		Debug.Log("%" + string.Format("CCC", FNLMOBFNBDO.Count));
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x00148202 File Offset: 0x00146402
	private void EDAMJCBGDGF(string KJPAGOJDABE)
	{
		Debug.LogError("ok" + KJPAGOJDABE);
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x001CC700 File Offset: 0x001CA900
	private void LAEKMIEBOEL()
	{
		PurchaseManagerSteam.OJDPCIHBELK ojdpcihbelk;
		ojdpcihbelk.<>t__builder = AsyncVoidMethodBuilder.Create();
		ojdpcihbelk.<>4__this = this;
		ojdpcihbelk.<>1__state = -1;
		ojdpcihbelk.<>t__builder.Start<PurchaseManagerSteam.OJDPCIHBELK>(ref ojdpcihbelk);
	}

	// Token: 0x06004218 RID: 16920 RVA: 0x001CC738 File Offset: 0x001CA938
	private void NFKLGAHBEHB()
	{
		Debug.LogError("\"");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.EHBBFMCILPC.LHBOBMDENGJ())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.FEEDGKCJBLE().GGPHHLGPMPA("<"), CCOJBMMKNAP.ILACPHFEDEP().JLBEIFLLBLO("App42Manager.UpdateUrlPingManagerState(): urlPingManager.ContinuePing()"), DFGILFBGPLN.popupPurchaseError, 865f, 105);
			}
			this.OKABAJJFEFJ = true;
			this.FKGJJLIFJLO.LPLAOKEAJMH(AOBJLALDBAA.KKPFOJMAONG().PHNAFOKHOHO());
		}
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	public IEnumerator FGHKLBHOAJD()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
		}
		else
		{
			this.SetState(IMBBHEGNCFP.ValidateInProgress);
			processedReceiptsCount = 0;
			breakFromLoop = false;
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

	// Token: 0x0600421A RID: 16922 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> JDCKCAIGLFJ()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x0600421B RID: 16923 RVA: 0x001CC7B1 File Offset: 0x001CA9B1
	private void LLNJBOJPLFM(IMIPKHBHFJO HLJNJIECKDK)
	{
		if (this.FKGJJLIFJLO != null)
		{
			base.StartCoroutine(this.IIKENFLECCG(HLJNJIECKDK));
		}
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x001CC7C9 File Offset: 0x001CA9C9
	public void CompletePurchase(GGAHKHBFKDA LLOOBCHLFNG)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.CompletePurchase(): Not initialized.");
			return;
		}
		Debug.Log("PurchaseManagerSteam.CompletePurchase(): Pending product purchase confirmed.");
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x001CC7F9 File Offset: 0x001CA9F9
	private void BMBLIBGMOCA(ProductFetchFailed FHANCMLKJAA)
	{
		Debug.Log("energyhinttitle" + string.Format("_ColorIntensity", FHANCMLKJAA.FailedFetchProducts.Count, FHANCMLKJAA.FailureReason));
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x001CBA1D File Offset: 0x001C9C1D
	public IMBBHEGNCFP GetState()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x001CC82C File Offset: 0x001CAA2C
	public void OnPurchasePendingProcess(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.GetState() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.Log("PurchaseManagerSteam.OnPurchasePendingProcess(): Validation already in progress, will finish processing purchase at a later date. Product - " + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("PurchaseManagerSteam.OnPurchasePendingProcess(): Product - " + OILKKJGIKEA.NIDDOGGMHAA);
		this.SetState(IMBBHEGNCFP.ValidatePending);
		bool flag = false;
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].MDGKLOAPLHI().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.NLPANLMJLEG(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.EHBBFMCILPC.MBNBMGBEHOC("OnPurchaseSuccess", 1f);
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x001CC8E0 File Offset: 0x001CAAE0
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendInitiateSteamTransactionSuccess", new UnityAction(this.GMDKLDHJDBM));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendInitiateSteamTransactionFailed", new UnityAction(this.IGPKMPMLLLK));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendInitiateSteamTransactionException", new UnityAction(this.GDLKBGMJGPN));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionSuccess", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionFailed", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnBackendValidateTransactionException", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x06004221 RID: 16929 RVA: 0x00003E52 File Offset: 0x00002052
	private void AJMIMOJPJNK(DeferredOrder NJBCLIILMOF)
	{
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x001CC997 File Offset: 0x001CAB97
	public void CIBKABDNLDJ()
	{
		if (SteamManager.EODHHAHDHBK() && (this.JPPKJCMHFMH == null || this.OIHOMGNOJOE == null))
		{
			this.GDAJBFKCIFH();
		}
		this.HADNHBHHHNA();
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x001CC9BC File Offset: 0x001CABBC
	private void LNCNIOOHEMK(string KJPAGOJDABE)
	{
		Debug.LogError("PurchaseManagerSteam.OnErrorInitializeGamingServices(): Error - " + KJPAGOJDABE);
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x00003E52 File Offset: 0x00002052
	public void FetchPurchases()
	{
	}

	// Token: 0x06004225 RID: 16933 RVA: 0x000022C3 File Offset: 0x000004C3
	private void EHCGGEMIOGE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x001CC9D0 File Offset: 0x001CABD0
	public void NMKPJMJOMEI()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)5;
				break;
			}
		}
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		Debug.LogError("sfxchatnotification");
	}

	// Token: 0x06004227 RID: 16935 RVA: 0x001CCA30 File Offset: 0x001CAC30
	public void MPKGAOFLKCF(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.ODLGMEHHIAL() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.Log("XXX" + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("love" + OILKKJGIKEA.NIDDOGGMHAA);
		this.SetState(IMBBHEGNCFP.ValidateSuccess);
		bool flag = true;
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].MFBNOLFOCCL().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.DNGGPPEKFII(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.NMGMNAKLLMI().MFHNFMPBDEJ("ok", 58f);
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x001CCAE2 File Offset: 0x001CACE2
	private void IFJIKEAMOBF()
	{
		Debug.LogError("OnFriendsPlusUnlockContinueToPurchasingScreen");
		this.OnPurchaseFailed((PurchaseFailureReason)(-127));
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x00003E52 File Offset: 0x00002052
	public void MLPJGMMCCIN(FailedOrder NJBCLIILMOF)
	{
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x00003E52 File Offset: 0x00002052
	public void RefreshSubscriptions()
	{
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x001CCAF8 File Offset: 0x001CACF8
	private void PBJPCPHBNIM(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = true;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.FILDBDMENPG().DCCLKMCBPPJ(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "OnPopupPasswordInputCancel", LanguageManager.EHBBFMCILPC.IEBFINIJAMJ()));
		BackendOperationsManager.NPDDBAONMJP().RequestProcessTransaction(this.FKGJJLIFJLO.JCFPKBDLLKJ().ToString(), IHCGMFBCMOO, "spectrum", "laebs", ") - Support Inquiry (");
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x001CCB74 File Offset: 0x001CAD74
	public void HADNHBHHHNA()
	{
		if (UnityServices.State == ServicesInitializationState.Uninitialized)
		{
			Debug.LogError("OnAccountForgetException");
			this.CMKAADFBHHF(new Action(this.PGPCKAHNLHI), new Action<string>(this.DLCICDJACIP));
		}
		if (this.GLJDCOPMGBJ != null)
		{
			return;
		}
		Debug.Log("Shaders/VideoGlitchOldTV");
		this.FPGCHHGNBEH = new List<NIIJIJNFIIA>();
		PurchaseManagerSteam.MNIFHEBFODF = new List<NIIJIJNFIIA>();
		if (!CJEKEHDEBLM.KBNLANLMNCN().FCEOMEILMHH())
		{
			Debug.LogError("ok");
			return;
		}
		this.LECPDIEBFLD();
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x001CCBF8 File Offset: 0x001CADF8
	private void BFLALFDCALG(string IHCGMFBCMOO)
	{
		this.OKABAJJFEFJ = true;
		this.FKGJJLIFJLO = new GGAHKHBFKDA(CJEKEHDEBLM.EHBBFMCILPC.EPNHMLIJCCM(IHCGMFBCMOO), NDFODCDLPAC.MBABIFOJGFK().m_SteamID.ToString(), GKJPOGNFKNK.DNILNCLIHAP(IHCGMFBCMOO, "OnPopupOfferManagerContinueToPurchasingScreen", LanguageManager.EHBBFMCILPC.MLOLBFBODHD()));
		BackendOperationsManager.EHBBFMCILPC.FLDBKFAJLDP(this.FKGJJLIFJLO.KCBHIANEGJO().ToString(), IHCGMFBCMOO, " path: loading the chain", "", "energyhinttitle");
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x001CBA1D File Offset: 0x001C9C1D
	public IMBBHEGNCFP EDLKHDGOLCI()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x00003E52 File Offset: 0x00002052
	private void BDPDIEHPBIN(PendingOrder FODKOPMKCBK)
	{
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x001CC7B1 File Offset: 0x001CA9B1
	private void PDCFNBCEMBM(IMIPKHBHFJO HLJNJIECKDK)
	{
		if (this.FKGJJLIFJLO != null)
		{
			base.StartCoroutine(this.IIKENFLECCG(HLJNJIECKDK));
		}
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x001CB00C File Offset: 0x001C920C
	public List<NIIJIJNFIIA> AMDNCOAMEGD()
	{
		return PurchaseManagerSteam.MNIFHEBFODF;
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x001CCC74 File Offset: 0x001CAE74
	public void PDLHIBCHHEG(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.DKCDPLHOALG() == IMBBHEGNCFP.ValidateSuccess)
		{
			Debug.Log("brsl" + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("OnStoryInterfaceHeaderHideComplete" + OILKKJGIKEA.NIDDOGGMHAA);
		this.IJHJGKHCOEL((IMBBHEGNCFP)8);
		bool flag = false;
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].CDIHDNKKLCE().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.DNGGPPEKFII(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.NMGMNAKLLMI().ICEJACOADDF(")", 260f);
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFDCAJIJDOC(Entitlement NFAAHJHABOA)
	{
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x001CCD28 File Offset: 0x001CAF28
	public void GIKNJMHDJFD()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = (EBPDOCELHBN)5;
				break;
			}
		}
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		Debug.LogError("specialcurrencydesc");
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x001CCD87 File Offset: 0x001CAF87
	private void GDLKBGMJGPN()
	{
		Debug.LogError("OnBackendInitiateSteamTransactionException");
		this.OnPurchaseFailed(PurchaseFailureReason.Unknown);
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x001CCD9C File Offset: 0x001CAF9C
	private void EMNLEBFDJNE(Action DAMHHHFPCEI, Action<string> GOPCGODFKIL)
	{
		PurchaseManagerSteam.PFMJOKKIFBP pfmjokkifbp = new PurchaseManagerSteam.PFMJOKKIFBP();
		pfmjokkifbp._onSuccess = DAMHHHFPCEI;
		try
		{
			UnityServices.InitializeAsync(new InitializationOptions().SetEnvironmentName("[LoadingEnv] ")).ContinueWith(new Action<Task>(pfmjokkifbp.MPBHILCNFLE));
		}
		catch (Exception ex)
		{
			GOPCGODFKIL(ex.Message);
		}
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x001CCE00 File Offset: 0x001CB000
	public void OnPurchaseFailed(PurchaseFailureReason FLBOCJFEMFE)
	{
		this.SetState(IMBBHEGNCFP.PurchaseFailed);
		this.OECGOKPIKIO = FLBOCJFEMFE;
		Debug.LogError("PurchaseManagerSteam.OnPurchaseFailed(), reason - " + this.OECGOKPIKIO.ToString());
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchaseFailed", 0f);
		CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x001CCE60 File Offset: 0x001CB060
	private void HONBHBCFLNF()
	{
		this.FHDHICFCEOG(new Action(this.DFJEPECBGMC), new Action<string>(this.EHKLJJHKLGF));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x001CCE8C File Offset: 0x001CB08C
	private void GMDKLDHJDBM()
	{
		Debug.LogError("OnBackendInitiateSteamTransactionSuccess");
		if (this.FKGJJLIFJLO != null)
		{
			if (!CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
			{
				CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("steamwaitforuseraction"), DFGILFBGPLN.popupTools, 0f, 28);
			}
			this.OKABAJJFEFJ = true;
			this.FKGJJLIFJLO.CBCFLNJEGLO(AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF());
		}
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x001CCF05 File Offset: 0x001CB105
	private void OOJBLNJKFLB(StoreConnectionFailureDescription NMPOPLKIHFN)
	{
		Debug.Log("OnPurchasingViewLeave" + NMPOPLKIHFN.message);
		this.DHFPOIFAPBA();
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x001CB679 File Offset: 0x001C9879
	public PurchaseFailureReason FHCKILEJIGB()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x0600423D RID: 16957 RVA: 0x001CCF22 File Offset: 0x001CB122
	public void SetState(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.SetState(): Not initialized.");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("PurchaseManagerSteam.SetState(): Changing manager state to:" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x001CCF5E File Offset: 0x001CB15E
	public void NEDFGMADFPH()
	{
		this.JPPKJCMHFMH = EPJEPKKGDLI<OHHJAMPEKNK>.HJNOKBOHODP(new EPJEPKKGDLI<OHHJAMPEKNK>.DMGGAJDGAFJ(this.KNMBBOCCBKK));
		this.OIHOMGNOJOE = EPJEPKKGDLI<IMIPKHBHFJO>.HJNOKBOHODP(new EPJEPKKGDLI<IMIPKHBHFJO>.DMGGAJDGAFJ(this.ONPHAOIGBNC));
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x0600423F RID: 16959 RVA: 0x001CCF95 File Offset: 0x001CB195
	private void MAECFKHNANJ()
	{
		Debug.LogError("smpd");
		this.MGFNNKGIFOJ((PurchaseFailureReason)122);
	}

	// Token: 0x06004240 RID: 16960 RVA: 0x001CCFA9 File Offset: 0x001CB1A9
	public void GDAJBFKCIFH()
	{
		this.JPPKJCMHFMH = EPJEPKKGDLI<OHHJAMPEKNK>.HJNOKBOHODP(new EPJEPKKGDLI<OHHJAMPEKNK>.DMGGAJDGAFJ(this.AOPGONGKADA));
		this.OIHOMGNOJOE = EPJEPKKGDLI<IMIPKHBHFJO>.HJNOKBOHODP(new EPJEPKKGDLI<IMIPKHBHFJO>.DMGGAJDGAFJ(this.ONPHAOIGBNC));
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x06004241 RID: 16961 RVA: 0x001CCFE0 File Offset: 0x001CB1E0
	private void LDICDJMJBLG()
	{
		PurchaseManagerSteam.OJDPCIHBELK ojdpcihbelk;
		ojdpcihbelk.<>t__builder = AsyncVoidMethodBuilder.Create();
		ojdpcihbelk.<>4__this = this;
		ojdpcihbelk.<>1__state = -1;
		ojdpcihbelk.<>t__builder.Start<PurchaseManagerSteam.OJDPCIHBELK>(ref ojdpcihbelk);
	}

	// Token: 0x06004242 RID: 16962 RVA: 0x001CD017 File Offset: 0x001CB217
	public void IDGGLGHACCH(IMBBHEGNCFP KNMIMLBLIGF)
	{
		if (!this.IsInitialized())
		{
			Debug.LogError("ok");
			return;
		}
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("ProfileItem2.OnAllCollectableCardsDownloadSuccess(): the pool ended but the scroll index card is still not resident" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x06004243 RID: 16963 RVA: 0x00003E52 File Offset: 0x00002052
	public void NPADNPJGNIN()
	{
	}

	// Token: 0x06004244 RID: 16964 RVA: 0x001CBC03 File Offset: 0x001C9E03
	private IEnumerator HMMFKKJKGOL(IMIPKHBHFJO HLJNJIECKDK)
	{
		yield return new WaitForSeconds(0.5f);
		if (HLJNJIECKDK.PJBCJPJJADF == 0 && this.OKABAJJFEFJ && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("steamwaitforuseraction"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else if (HLJNJIECKDK.PJBCJPJJADF == 1 && this.OKABAJJFEFJ && CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		yield break;
	}

	// Token: 0x06004245 RID: 16965 RVA: 0x001CD054 File Offset: 0x001CB254
	public void LGGKCIMFBKD()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.Idle)
			{
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateSuccess;
				break;
			}
		}
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		Debug.LogError("YYY");
	}

	// Token: 0x06004246 RID: 16966 RVA: 0x001CD0B4 File Offset: 0x001CB2B4
	public void IBNCCFMKKJD(GGAHKHBFKDA OILKKJGIKEA)
	{
		if (this.GetState() == IMBBHEGNCFP.PurchaseFailed)
		{
			Debug.Log("_TVLinesOpacity" + OILKKJGIKEA.NIDDOGGMHAA);
			return;
		}
		Debug.Log("?uid=" + OILKKJGIKEA.NIDDOGGMHAA);
		this.LGBNNKNOJPB(IMBBHEGNCFP.ValidateSuccess);
		bool flag = true;
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i += 0)
		{
			if (this.FPGCHHGNBEH[i].EJHHLGDKMMF().Equals(OILKKJGIKEA.BAOPJDNMEAC))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
			niijijnfiia.PDKENAHOGPJ(OILKKJGIKEA);
			this.FPGCHHGNBEH.Add(niijijnfiia);
		}
		AOBJLALDBAA.KKPFOJMAONG().DNFCPNFCAPC("HD", 1675f);
	}

	// Token: 0x06004247 RID: 16967 RVA: 0x001CD166 File Offset: 0x001CB366
	private void GNHDCIGPFOH()
	{
		this.FHDHICFCEOG(new Action(this.PINDFDKJDIP), new Action<string>(this.LNCNIOOHEMK));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x001CD191 File Offset: 0x001CB391
	private void KBGANABGEMK()
	{
		this.EMNLEBFDJNE(new Action(this.PGPCKAHNLHI), new Action<string>(this.EDEOEOKMFNG));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004249 RID: 16969 RVA: 0x001CBC03 File Offset: 0x001C9E03
	private IEnumerator GGICCHHFLEB(IMIPKHBHFJO HLJNJIECKDK)
	{
		yield return new WaitForSeconds(0.5f);
		if (HLJNJIECKDK.PJBCJPJJADF == 0 && this.OKABAJJFEFJ && !CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.ShowGenericPopupNoButtons(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("importanttitle"), CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("steamwaitforuseraction"), DFGILFBGPLN.popupTools, 0f, 28);
		}
		else if (HLJNJIECKDK.PJBCJPJJADF == 1 && this.OKABAJJFEFJ && CommonUserInterface.EHBBFMCILPC.AnyGenericPopupIsActive())
		{
			CommonUserInterface.EHBBFMCILPC.HideGenericPopupNoButtons();
		}
		yield break;
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x00003E52 File Offset: 0x00002052
	private void DAHLNGEDMLF(PendingOrder FODKOPMKCBK)
	{
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	public IEnumerator IPEBEJLBOHI()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
		}
		else
		{
			this.SetState(IMBBHEGNCFP.ValidateInProgress);
			processedReceiptsCount = 0;
			breakFromLoop = false;
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

	// Token: 0x0600424C RID: 16972 RVA: 0x00002296 File Offset: 0x00000496
	private void KNCAACKFGDC()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x001CB66A File Offset: 0x001C986A
	public IEnumerator KNEGDFPENOK()
	{
		PurchaseManagerSteam.KNHLAIKAPFL knhlaikapfl = new PurchaseManagerSteam.KNHLAIKAPFL(1);
		knhlaikapfl.<>4__this = this;
		return knhlaikapfl;
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x001CB2F3 File Offset: 0x001C94F3
	public IEnumerator LILIFJDCPNF()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerSteam.ValidatePendingProducts(): Not initialized.");
		}
		else
		{
			this.SetState(IMBBHEGNCFP.ValidateInProgress);
			processedReceiptsCount = 0;
			breakFromLoop = false;
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

	// Token: 0x0600424F RID: 16975 RVA: 0x001CD1BC File Offset: 0x001CB3BC
	public void MGFNNKGIFOJ(PurchaseFailureReason FLBOCJFEMFE)
	{
		this.LGBNNKNOJPB(IMBBHEGNCFP.ValidateInProgress);
		this.OECGOKPIKIO = FLBOCJFEMFE;
		Debug.LogError("ok" + this.OECGOKPIKIO.ToString());
		AOBJLALDBAA.EHBBFMCILPC.FDKBIBKABCM("OnPopupProfileUIDInputCancel", 450f);
		CommonUserInterface.IKNOFBFMPGA().HideGenericPopupNoButtons();
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFFCAEGCCIL(Entitlement NFAAHJHABOA)
	{
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x001CD21C File Offset: 0x001CB41C
	private void AECEPKMCKGB()
	{
		AOBJLALDBAA.EHBBFMCILPC.BADOPKAOCPE("sae", new UnityAction(this.ODBONMMMNJD));
		AOBJLALDBAA.CEGAOMEEFBE().EFKNEJFLGED("'", new UnityAction(this.IHFLGPIBAIL));
		AOBJLALDBAA.BIAEAOMHBMM().GNBGEMMDGOJ("RequestGetUserPublicProfile(): timer hit: ", new UnityAction(this.IFJIKEAMOBF));
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP("friendspluschattutorialactive", new UnityAction(this.HLNBCNAPBAI));
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL(" ", new UnityAction(this.JALOHOEMAHK));
		AOBJLALDBAA.NMGMNAKLLMI().EFKNEJFLGED("smsrc", new UnityAction(this.GIKNJMHDJFD));
	}

	// Token: 0x06004252 RID: 16978 RVA: 0x001CD2CB File Offset: 0x001CB4CB
	private void CMGJHALEOFC()
	{
		Debug.Log("");
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x001CD2D7 File Offset: 0x001CB4D7
	public void OPOONMNENKK()
	{
		this.JPPKJCMHFMH = EPJEPKKGDLI<OHHJAMPEKNK>.HJNOKBOHODP(new EPJEPKKGDLI<OHHJAMPEKNK>.DMGGAJDGAFJ(this.NLLLCACJKBP));
		this.OIHOMGNOJOE = EPJEPKKGDLI<IMIPKHBHFJO>.HJNOKBOHODP(new EPJEPKKGDLI<IMIPKHBHFJO>.DMGGAJDGAFJ(this.PDCFNBCEMBM));
		this.FKGJJLIFJLO = null;
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x001CD30E File Offset: 0x001CB50E
	private void CJOOOIECMAE()
	{
		this.EMNLEBFDJNE(new Action(this.MDJNPIHMPOE), new Action<string>(this.DLCICDJACIP));
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004255 RID: 16981 RVA: 0x001CD339 File Offset: 0x001CB539
	private void FNFOKKAFIME()
	{
		Debug.Log("PurchaseManagerSteam.OnSuccessInitializeGamingServices()!");
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x001CD348 File Offset: 0x001CB548
	private void DHFPOIFAPBA()
	{
		if (this.GLJDCOPMGBJ != null)
		{
			Debug.Log("");
			try
			{
				this.GLJDCOPMGBJ.OnPurchasePending -= this.ENJJIEICJOP;
				this.GLJDCOPMGBJ.OnPurchaseConfirmed -= this.NFFBIFBLDKL;
				this.GLJDCOPMGBJ.OnPurchaseFailed -= this.LOCJHEDHODG;
				this.GLJDCOPMGBJ.OnStoreDisconnected -= this.HJINLBFJJHL;
				this.GLJDCOPMGBJ.OnPurchaseDeferred -= this.BKPHBMOFAIG;
				this.GLJDCOPMGBJ.OnCheckEntitlement -= this.GFDCAJIJDOC;
				this.GLJDCOPMGBJ.OnProductsFetchFailed -= this.HLMHFICHFLD;
				this.GLJDCOPMGBJ.OnProductsFetched -= this.MPEEAJLCKHD;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.GLJDCOPMGBJ = null;
		}
		this.MBEEEAHJLOF = false;
	}

	// Token: 0x06004257 RID: 16983 RVA: 0x00003E52 File Offset: 0x00002052
	private void BKPHBMOFAIG(DeferredOrder NJBCLIILMOF)
	{
	}

	// Token: 0x04001267 RID: 4711
	public const string onBackendInitiateSteamTransactionSuccess = "OnBackendInitiateSteamTransactionSuccess";

	// Token: 0x04001268 RID: 4712
	public const string onBackendInitiateSteamTransactionFailed = "OnBackendInitiateSteamTransactionFailed";

	// Token: 0x04001269 RID: 4713
	public const string onBackendInitiateSteamTransactionException = "OnBackendInitiateSteamTransactionException";

	// Token: 0x0400126A RID: 4714
	private EPJEPKKGDLI<OHHJAMPEKNK> JPPKJCMHFMH;

	// Token: 0x0400126B RID: 4715
	private EPJEPKKGDLI<IMIPKHBHFJO> OIHOMGNOJOE;

	// Token: 0x0400126C RID: 4716
	private bool OKABAJJFEFJ;

	// Token: 0x0400126D RID: 4717
	private GGAHKHBFKDA FKGJJLIFJLO;

	// Token: 0x0400126E RID: 4718
	private PurchaseFailureReason OECGOKPIKIO;

	// Token: 0x0400126F RID: 4719
	private IMBBHEGNCFP GPILOGAIBKJ;

	// Token: 0x04001270 RID: 4720
	private StoreController GLJDCOPMGBJ;

	// Token: 0x04001271 RID: 4721
	private bool MBEEEAHJLOF;

	// Token: 0x04001272 RID: 4722
	private List<NIIJIJNFIIA> FPGCHHGNBEH;

	// Token: 0x04001273 RID: 4723
	private static List<NIIJIJNFIIA> MNIFHEBFODF;

	// Token: 0x0200020F RID: 527
	[CompilerGenerated]
	private sealed class PFMJOKKIFBP
	{
		// Token: 0x0600425E RID: 16990 RVA: 0x001CD531 File Offset: 0x001CB731
		internal void MPBHILCNFLE(Task task)
		{
			this._onSuccess();
		}

		// Token: 0x04001278 RID: 4728
		public Action _onSuccess;
	}
}
