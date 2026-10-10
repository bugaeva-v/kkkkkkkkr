using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

// Token: 0x02000336 RID: 822
public class PurchaseManagerXiaomi : MonoBehaviour, ABLEFBBIBNB
{
	// Token: 0x060061F3 RID: 25075 RVA: 0x002D18F0 File Offset: 0x002CFAF0
	public OBHDGKFFICI GetProductData(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IHCGMFBCMOO);
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerXiaomi.GetProductData(): Not initialized.");
		}
		else
		{
			string text = DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO);
			PurchaseManagerXiaomi.HKNJMHFFFOA hknjmhfffoa;
			if (this.LKEMFOGBBJB.TryGetValue(text, out hknjmhfffoa))
			{
				obhdgkffici.MDFDHOKJOPB = new LIFHPKOLIGL
				{
					CECLJNKHJEE = hknjmhfffoa.CECLJNKHJEE,
					BPMFHNDCBOH = hknjmhfffoa.BPMFHNDCBOH,
					NMPOPLKIHFN = hknjmhfffoa.NMPOPLKIHFN,
					ICKHGADHPMJ = hknjmhfffoa.ICKHGADHPMJ,
					DDPEPDHLCAG = hknjmhfffoa.DDPEPDHLCAG,
					KPDNIIJNDIL = hknjmhfffoa.KPDNIIJNDIL,
					OBKCKGHFMDN = hknjmhfffoa.OBKCKGHFMDN
				};
			}
			else
			{
				Debug.LogError("PurchaseManagerXiaomi.GetProductData(): no cached SKU metadata for " + text);
			}
		}
		return obhdgkffici;
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x002D19B4 File Offset: 0x002CFBB4
	public List<NIIJIJNFIIA> GetValidatedPurchases()
	{
		return PurchaseManagerXiaomi.MNIFHEBFODF;
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x002D19BB File Offset: 0x002CFBBB
	public void OnAcknowledged(string AOAHJLDCEBK)
	{
		Debug.Log("PurchaseManagerXiaomi.OnAcknowledged(): " + AOAHJLDCEBK);
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x002D19D0 File Offset: 0x002CFBD0
	private void AMDPHCBMBHB()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		for (int i = 0; i < CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK().Count; i++)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.DNPADILDKKK()[i];
			string item = DPGJIJGOCIC.NEDLKPMGHLG(ocbiopoeenj.DEJCCBNPFEC);
			if (ocbiopoeenj.OBKCKGHFMDN == ProductType.Subscription)
			{
				list2.Add(item);
			}
			else
			{
				list.Add(item);
			}
		}
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x002D1A38 File Offset: 0x002CFC38
	private void AHLFAINKLEF(NIIJIJNFIIA DAEFEEAOEJF)
	{
		INBFGLCMEBN inbfglcmebn = DAEFEEAOEJF.IKBNBFECCOG();
		if (inbfglcmebn == null)
		{
			return;
		}
		if (inbfglcmebn.JIEBEFKGJIM == null)
		{
			OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(inbfglcmebn.DLCPOJGJFDG);
		}
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x002D1A6B File Offset: 0x002CFC6B
	public void FetchPurchases()
	{
		this.LJPMIDENENF(false);
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x002D1A74 File Offset: 0x002CFC74
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
		Debug.LogError("PurchaseManagerXiaomi.OnBackendValidateTransactionException().");
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x002D1ACC File Offset: 0x002CFCCC
	private void OnEnable()
	{
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionSuccess", new UnityAction(this.OnBackendValidateTransactionSuccess));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionFailed", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnBackendValidateTransactionException", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x060061FB RID: 25083 RVA: 0x002D1B2A File Offset: 0x002CFD2A
	public IEnumerator ValidatePendingPurchases()
	{
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.ValidateInProgress)
		{
			yield break;
		}
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerXiaomi.ValidatePendingPurchases(): Not initialized.");
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

	// Token: 0x060061FC RID: 25084 RVA: 0x002D1B3C File Offset: 0x002CFD3C
	public void RestorePurchases()
	{
		if (!this.IsInitialized() || !this.OFGJIAFMBNC)
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingNotInitialized", 0f);
			Debug.LogError("PurchaseManagerXiaomi.RestorePurchases(): Not initialized.");
			return;
		}
		PurchaseManagerXiaomi.MNIFHEBFODF.Clear();
		this.LJPMIDENENF(true);
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x002D1B8C File Offset: 0x002CFD8C
	public void OnProductsFetched(string AOAHJLDCEBK)
	{
		try
		{
			JSONObject jsonobject = JSON.Parse(AOAHJLDCEBK) as JSONObject;
			if (!(null == jsonobject))
			{
				string text = jsonobject["type"];
				int asInt = jsonobject["responseCode"].AsInt;
				if (asInt != 0)
				{
					string text2 = (asInt == -2) ? " [FEATURE_NOT_SUPPORTED: device region / GetApps app version doesn't support this product type (typically subscriptions)]" : "";
					Debug.LogError(string.Concat(new string[]
					{
						"PurchaseManagerXiaomi.OnProductsFetched(",
						text,
						"): code=",
						asInt.ToString(),
						" msg=",
						jsonobject["debugMessage"],
						text2
					}));
				}
				JSONArray asArray = jsonobject["skus"].AsArray;
				if (null != asArray)
				{
					for (int i = 0; i < asArray.Count; i++)
					{
						JSONObject asObject = asArray[i].AsObject;
						PurchaseManagerXiaomi.HKNJMHFFFOA hknjmhfffoa = new PurchaseManagerXiaomi.HKNJMHFFFOA
						{
							CECLJNKHJEE = asObject["sku"],
							OBKCKGHFMDN = asObject["type"],
							BPMFHNDCBOH = asObject["title"],
							NMPOPLKIHFN = asObject["description"],
							ICKHGADHPMJ = asObject["price"],
							KPDNIIJNDIL = long.Parse(asObject["priceAmountMicros"]),
							DDPEPDHLCAG = asObject["priceCurrencyCode"],
							MDKADMANKFK = asObject["basePlanId"],
							GELKJDGBIOE = asObject["offerToken"],
							FALGKPANABP = asObject["offerId"]
						};
						this.LKEMFOGBBJB[hknjmhfffoa.CECLJNKHJEE] = hknjmhfffoa;
					}
				}
				if (text == "inapp")
				{
					this.MKPEMCFMJKF = true;
				}
				else if (text == "subs")
				{
					this.OLDBABCABMB = true;
				}
				Debug.Log(string.Concat(new string[]
				{
					"PurchaseManagerXiaomi.OnProductsFetched(",
					text,
					"): ",
					((null != asArray) ? asArray.Count : 0).ToString(),
					" skus cached. Total cached=",
					this.LKEMFOGBBJB.Count.ToString()
				}));
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("PurchaseManagerXiaomi.OnProductsFetched(): parse error " + ex.Message);
		}
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x002D1E4C File Offset: 0x002D004C
	public OBHDGKFFICI IOGLFLGAKGJ(string IHCGMFBCMOO)
	{
		OBHDGKFFICI obhdgkffici = new OBHDGKFFICI();
		obhdgkffici.AGKJHMBIPHH = CJEKEHDEBLM.AGANFKKBPFO().FHDEDNGLNKI(IHCGMFBCMOO);
		if (!this.IsInitialized())
		{
			Debug.LogError("Cannot send LogEvent, the Appsflyer SDK is stopped");
		}
		else
		{
			string text = DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO);
			PurchaseManagerXiaomi.HKNJMHFFFOA hknjmhfffoa;
			if (this.LKEMFOGBBJB.TryGetValue(text, out hknjmhfffoa))
			{
				obhdgkffici.MDFDHOKJOPB = new LIFHPKOLIGL
				{
					CECLJNKHJEE = hknjmhfffoa.CECLJNKHJEE,
					BPMFHNDCBOH = hknjmhfffoa.BPMFHNDCBOH,
					NMPOPLKIHFN = hknjmhfffoa.NMPOPLKIHFN,
					ICKHGADHPMJ = hknjmhfffoa.ICKHGADHPMJ,
					DDPEPDHLCAG = hknjmhfffoa.DDPEPDHLCAG,
					KPDNIIJNDIL = hknjmhfffoa.KPDNIIJNDIL,
					OBKCKGHFMDN = hknjmhfffoa.OBKCKGHFMDN
				};
			}
			else
			{
				Debug.LogError("23819D" + text);
			}
		}
		return obhdgkffici;
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x002D1F10 File Offset: 0x002D0110
	public void StartPurchase(string IHCGMFBCMOO)
	{
		PurchaseManagerXiaomi.MNIFHEBFODF.Clear();
		if (!this.IsInitialized())
		{
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchasingNotInitialized", 0f);
			Debug.LogError("PurchaseManagerXiaomi.StartPurchase(): Not initialized.");
			return;
		}
		if (this.GPILOGAIBKJ == IMBBHEGNCFP.PurchaseInProgress || this.GetState() == IMBBHEGNCFP.ValidateInProgress)
		{
			Debug.LogError("PurchaseManagerXiaomi.StartPurchase(): A purchase or validation is in progress. Aborting.");
			return;
		}
		if (this.FPGCHHGNBEH.Count != 0)
		{
			Debug.LogError("PurchaseManagerXiaomi.StartPurchase(): Warning, there are waiting purchases to be validated, one more will be added to the list.");
		}
		string text = DPGJIJGOCIC.NEDLKPMGHLG(IHCGMFBCMOO);
		Debug.Log("PurchaseManagerXiaomi.StartPurchase(): Start purchase " + text);
		this.SetState(IMBBHEGNCFP.PurchaseInProgress);
		PurchaseManagerXiaomi.HKNJMHFFFOA hknjmhfffoa;
		if (this.LKEMFOGBBJB.TryGetValue(text, out hknjmhfffoa))
		{
			string obkckghfmdn = hknjmhfffoa.OBKCKGHFMDN;
			string gelkjdgbioe = hknjmhfffoa.GELKJDGBIOE;
			return;
		}
		OCBIOPOEENJ ocbiopoeenj = CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(IHCGMFBCMOO);
		if (ocbiopoeenj != null)
		{
			ProductType obkckghfmdn2 = ocbiopoeenj.OBKCKGHFMDN;
		}
	}

	// Token: 0x06006200 RID: 25088 RVA: 0x002D1FD7 File Offset: 0x002D01D7
	public void BPNFDGBOIJH(string AOAHJLDCEBK)
	{
		Debug.Log("$ENVSET" + AOAHJLDCEBK);
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x002D1FEC File Offset: 0x002D01EC
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

	// Token: 0x06006202 RID: 25090 RVA: 0x002D2052 File Offset: 0x002D0252
	public void LAKJGFKHFMI(string AOAHJLDCEBK)
	{
		Debug.Log("," + AOAHJLDCEBK);
	}

	// Token: 0x06006203 RID: 25091 RVA: 0x002D2064 File Offset: 0x002D0264
	public void OnBridgeDisconnected(string AOAHJLDCEBK)
	{
		Debug.LogError("PurchaseManagerXiaomi.OnBridgeDisconnected(): " + AOAHJLDCEBK);
		this.IBMCEHCKECM = false;
	}

	// Token: 0x06006204 RID: 25092 RVA: 0x002D2080 File Offset: 0x002D0280
	public void MFMHBIGOOGD(string AOAHJLDCEBK)
	{
		JSONObject jsonobject = JSON.Parse(AOAHJLDCEBK) as JSONObject;
		if (null != jsonobject && jsonobject[" "].AsBool)
		{
			this.IBMCEHCKECM = true;
			Debug.Log("idms");
			this.AMDPHCBMBHB();
			return;
		}
		int num = (null != jsonobject) ? jsonobject["OnCutsceneViewLobbyAssetBundleFolderInitializeSuccess"].AsInt : -1;
		string str = (null != jsonobject) ? jsonobject["socialtop"].Value : "YYY";
		Debug.LogError("" + num.ToString() + ") is missing data" + str);
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x002D212C File Offset: 0x002D032C
	public void OnBackendValidateTransactionSuccess()
	{
		for (int i = 0; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.EHBBFMCILPC.DAJBFDEPJGF();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateSuccess;
				PurchaseManagerXiaomi.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.AHLFAINKLEF(this.FPGCHHGNBEH[i]);
				break;
			}
		}
		Debug.Log("PurchaseManagerXiaomi.OnBackendValidateTransactionSuccess().");
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x002D21C4 File Offset: 0x002D03C4
	public bool IsInitialized()
	{
		return this.IBMCEHCKECM;
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x002D21CC File Offset: 0x002D03CC
	private void LJPMIDENENF(bool MIBEKNEGACA)
	{
		this.HILKHNKNFGK = MIBEKNEGACA;
		if (!this.IsInitialized())
		{
			Debug.LogError("PurchaseManagerXiaomi._FetchPurchases(): Not initialized.");
			return;
		}
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x002D21E8 File Offset: 0x002D03E8
	private void PCGPPEAFMGD(bool MIBEKNEGACA)
	{
		this.HILKHNKNFGK = MIBEKNEGACA;
		if (!this.IsInitialized())
		{
			Debug.LogError("AVATAR.CLIENT.TRINKET");
			return;
		}
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x002D2204 File Offset: 0x002D0404
	public void OnConsumed(string AOAHJLDCEBK)
	{
		Debug.Log("PurchaseManagerXiaomi.OnConsumed(): " + AOAHJLDCEBK);
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x00003E52 File Offset: 0x00002052
	public void RefreshSubscriptions()
	{
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x002D2216 File Offset: 0x002D0416
	public void OnBridgeLog(string FOGGFHMIOBF)
	{
		Debug.Log("PurchaseManagerXiaomi[bridge]: " + FOGGFHMIOBF);
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x002D2228 File Offset: 0x002D0428
	public void OnBridgeInitialized(string AOAHJLDCEBK)
	{
		JSONObject jsonobject = JSON.Parse(AOAHJLDCEBK) as JSONObject;
		if (null != jsonobject && jsonobject["ok"].AsBool)
		{
			this.IBMCEHCKECM = true;
			Debug.Log("PurchaseManagerXiaomi.OnBridgeInitialized(): connected to Xiaomi GetApps IAP service.");
			this.AMDPHCBMBHB();
			return;
		}
		int num = (null != jsonobject) ? jsonobject["responseCode"].AsInt : -1;
		string str = (null != jsonobject) ? jsonobject["debugMessage"].Value : "?";
		Debug.LogError("PurchaseManagerXiaomi.OnBridgeInitialized(): failed code=" + num.ToString() + " msg=" + str);
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x002D22D1 File Offset: 0x002D04D1
	public IMBBHEGNCFP GetState()
	{
		return this.GPILOGAIBKJ;
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x002D22EC File Offset: 0x002D04EC
	public void Initialize()
	{
		if (this.IBMCEHCKECM)
		{
			return;
		}
		Debug.Log("PurchaseManagerXiaomi.Initialize()");
		this.FPGCHHGNBEH = new List<NIIJIJNFIIA>();
		PurchaseManagerXiaomi.MNIFHEBFODF = new List<NIIJIJNFIIA>();
		if (!CJEKEHDEBLM.EHBBFMCILPC.FACIFBONANM())
		{
			Debug.LogError("PurchaseManagerXiaomi.Initialize(): Trying to initialize, but no products are defined.");
			return;
		}
		Debug.Log("PurchaseManagerXiaomi.Initialize(): non-Android editor build, bridge is a no-op.");
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x002D2344 File Offset: 0x002D0544
	public void OnPurchaseUpdated(string AOAHJLDCEBK)
	{
		JSONObject jsonobject = JSON.Parse(AOAHJLDCEBK) as JSONObject;
		if (null == jsonobject)
		{
			Debug.LogError("PurchaseManagerXiaomi.OnPurchaseUpdated(): invalid payload");
			return;
		}
		int asInt = jsonobject["responseCode"].AsInt;
		JSONArray asArray = jsonobject["purchases"].AsArray;
		if (asInt == 10)
		{
			Debug.Log("PurchaseManagerXiaomi.OnPurchaseUpdated(): checkout dialog shown (code 10), awaiting result.");
			return;
		}
		if (asInt == 1)
		{
			this.SetState(IMBBHEGNCFP.PurchaseFailed);
			this.OECGOKPIKIO = PurchaseFailureReason.UserCancelled;
			Debug.Log("PurchaseManagerXiaomi.OnPurchaseUpdated(): user cancelled checkout (code 1).");
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchaseFailed", 0f);
			return;
		}
		if (asInt != 0 || null == asArray || asArray.Count == 0)
		{
			this.SetState(IMBBHEGNCFP.PurchaseFailed);
			this.OECGOKPIKIO = PurchaseFailureReason.Unknown;
			Debug.LogError("PurchaseManagerXiaomi.OnPurchaseUpdated(): code=" + asInt.ToString() + " msg=" + jsonobject["debugMessage"]);
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnPurchaseFailed", 0f);
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnNeedToShowConnectingAnimation", 0f);
		this.SetState(IMBBHEGNCFP.ValidatePending);
		for (int i = 0; i < asArray.Count; i++)
		{
			JSONObject asObject = asArray[i].AsObject;
			string text = asObject["productId"];
			string ihcgmfbcmoo = DPGJIJGOCIC.DBLCEBNPIDN(text);
			INBFGLCMEBN inbfglcmebn = new INBFGLCMEBN(CJEKEHDEBLM.EHBBFMCILPC.PDJKPFLHFLO(ihcgmfbcmoo), asObject);
			PurchaseManagerXiaomi.HKNJMHFFFOA hknjmhfffoa;
			if (this.LKEMFOGBBJB.TryGetValue(text, out hknjmhfffoa))
			{
				inbfglcmebn.EPEDJKGMIAA = ((hknjmhfffoa.KPDNIIJNDIL > 0L) ? (hknjmhfffoa.KPDNIIJNDIL / 1000000m).ToString("0.##", CultureInfo.InvariantCulture) : LIFHPKOLIGL.PGANHDFMDMO(hknjmhfffoa.ICKHGADHPMJ));
				inbfglcmebn.AMGPFOKINPI = hknjmhfffoa.DDPEPDHLCAG;
				inbfglcmebn.OBKCKGHFMDN = hknjmhfffoa.OBKCKGHFMDN;
			}
			bool flag = false;
			for (int j = 0; j < this.FPGCHHGNBEH.Count; j++)
			{
				if (this.FPGCHHGNBEH[j].MDGKLOAPLHI() == inbfglcmebn.BAOPJDNMEAC)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				NIIJIJNFIIA niijijnfiia = new NIIJIJNFIIA();
				niijijnfiia.HCABKLCPFFH(inbfglcmebn);
				this.FPGCHHGNBEH.Add(niijijnfiia);
			}
		}
		AOBJLALDBAA.EHBBFMCILPC.MBNBMGBEHOC("OnPurchaseSuccess", 1f);
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x002D259A File Offset: 0x002D079A
	public void SetState(IMBBHEGNCFP KNMIMLBLIGF)
	{
		this.GPILOGAIBKJ = KNMIMLBLIGF;
		Debug.Log("PurchaseManagerXiaomi.SetState(). Changing manager state to:" + this.GPILOGAIBKJ.ToString());
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x002D25C4 File Offset: 0x002D07C4
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
		Debug.LogError("PurchaseManagerXiaomi.OnBackendValidateTransactionFailed().");
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x002D261C File Offset: 0x002D081C
	private static string OLOIDHEFHGG(List<string> NKEOFADDFHB)
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < NKEOFADDFHB.Count; i++)
		{
			jsonarray.Add(NKEOFADDFHB[i]);
		}
		return jsonarray.ToString();
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x002D2658 File Offset: 0x002D0858
	public PurchaseFailureReason GetPurchaseFailedReason()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x06006217 RID: 25111 RVA: 0x002D2658 File Offset: 0x002D0858
	public PurchaseFailureReason GENEHFPHNKO()
	{
		return this.OECGOKPIKIO;
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x002D2660 File Offset: 0x002D0860
	public void LBHGBKDLEDE(string AOAHJLDCEBK)
	{
		Debug.Log("OnPremiumChoiceExecutedHardBased" + AOAHJLDCEBK);
	}

	// Token: 0x06006219 RID: 25113 RVA: 0x002D2674 File Offset: 0x002D0874
	public void AHFADGLGKBD()
	{
		for (int i = 1; i < this.FPGCHHGNBEH.Count; i++)
		{
			if (this.FPGCHHGNBEH[i].KMDENBLAEJO == EBPDOCELHBN.ValidateInProgress)
			{
				this.FPGCHHGNBEH[i].EGEODKDPGDF = AOBJLALDBAA.FILDBDMENPG().PHNAFOKHOHO();
				this.FPGCHHGNBEH[i].KMDENBLAEJO = EBPDOCELHBN.ValidateException;
				PurchaseManagerXiaomi.MNIFHEBFODF.Add(this.FPGCHHGNBEH[i]);
				this.AHLFAINKLEF(this.FPGCHHGNBEH[i]);
				break;
			}
		}
		Debug.Log("sltind");
	}

	// Token: 0x0600621A RID: 25114 RVA: 0x002D270C File Offset: 0x002D090C
	public IEnumerator JLMCINGEFOI()
	{
		PurchaseManagerXiaomi.NNOHANCGPCH nnohancgpch = new PurchaseManagerXiaomi.NNOHANCGPCH(1);
		nnohancgpch.<>4__this = this;
		return nnohancgpch;
	}

	// Token: 0x0600621B RID: 25115 RVA: 0x002D271C File Offset: 0x002D091C
	public void OnPurchasesQueried(string AOAHJLDCEBK)
	{
		try
		{
			JSONObject jsonobject = JSON.Parse(AOAHJLDCEBK) as JSONObject;
			if (!(null == jsonobject))
			{
				string text = jsonobject["type"];
				int asInt = jsonobject["responseCode"].AsInt;
				JSONArray asArray = jsonobject["purchases"].AsArray;
				this.OFGJIAFMBNC = true;
				Debug.Log(string.Concat(new string[]
				{
					"PurchaseManagerXiaomi.OnPurchasesQueried(",
					text,
					"): code=",
					asInt.ToString(),
					" count=",
					((null != asArray) ? asArray.Count : 0).ToString()
				}));
				if (asInt != 0 || null == asArray || asArray.Count == 0)
				{
					if ((asArray == null || asArray.Count == 0) && this.HILKHNKNFGK)
					{
						AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnRestorePurchasesZeroResult", 0f);
					}
					this.HILKHNKNFGK = false;
				}
				else
				{
					this.HILKHNKNFGK = false;
					this.OnPurchaseUpdated(AOAHJLDCEBK);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("PurchaseManagerXiaomi.OnPurchasesQueried(): " + ex.Message);
		}
	}

	// Token: 0x0600621C RID: 25116 RVA: 0x002D2864 File Offset: 0x002D0A64
	private void GNJIMBFLDKO()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().POLEDPIKODD("PurchaseManagerSteam.OnBackendValidateTransactionException().", new UnityAction(this.AHFADGLGKBD));
		AOBJLALDBAA.NMGMNAKLLMI().ONIBLJOFFPG("sprite", new UnityAction(this.OnBackendValidateTransactionFailed));
		AOBJLALDBAA.NMGMNAKLLMI().ECDBIBPNBCO("$es", new UnityAction(this.OnBackendValidateTransactionException));
	}

	// Token: 0x04001C6F RID: 7279
	private PurchaseFailureReason OECGOKPIKIO;

	// Token: 0x04001C70 RID: 7280
	private IMBBHEGNCFP GPILOGAIBKJ;

	// Token: 0x04001C71 RID: 7281
	private bool IBMCEHCKECM;

	// Token: 0x04001C72 RID: 7282
	private bool MKPEMCFMJKF;

	// Token: 0x04001C73 RID: 7283
	private bool OLDBABCABMB;

	// Token: 0x04001C74 RID: 7284
	private bool OFGJIAFMBNC;

	// Token: 0x04001C75 RID: 7285
	private List<NIIJIJNFIIA> FPGCHHGNBEH;

	// Token: 0x04001C76 RID: 7286
	private static List<NIIJIJNFIIA> MNIFHEBFODF;

	// Token: 0x04001C77 RID: 7287
	private bool HILKHNKNFGK;

	// Token: 0x04001C78 RID: 7288
	private Dictionary<string, PurchaseManagerXiaomi.HKNJMHFFFOA> LKEMFOGBBJB = new Dictionary<string, PurchaseManagerXiaomi.HKNJMHFFFOA>();

	// Token: 0x02000337 RID: 823
	private class HKNJMHFFFOA
	{
		// Token: 0x04001C79 RID: 7289
		public string CECLJNKHJEE;

		// Token: 0x04001C7A RID: 7290
		public string OBKCKGHFMDN;

		// Token: 0x04001C7B RID: 7291
		public string BPMFHNDCBOH;

		// Token: 0x04001C7C RID: 7292
		public string NMPOPLKIHFN;

		// Token: 0x04001C7D RID: 7293
		public string ICKHGADHPMJ;

		// Token: 0x04001C7E RID: 7294
		public long KPDNIIJNDIL;

		// Token: 0x04001C7F RID: 7295
		public string DDPEPDHLCAG;

		// Token: 0x04001C80 RID: 7296
		public string MDKADMANKFK;

		// Token: 0x04001C81 RID: 7297
		public string GELKJDGBIOE;

		// Token: 0x04001C82 RID: 7298
		public string FALGKPANABP;
	}
}
