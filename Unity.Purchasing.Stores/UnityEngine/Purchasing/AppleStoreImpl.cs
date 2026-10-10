using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.MiniJSON;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000036 RID: 54
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleStoreImpl : JsonStore, IAppleStoreCallbacks, IAppleAppReceiptViewer
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600010F RID: 271 RVA: 0x00004EF8 File Offset: 0x000030F8
		// (remove) Token: 0x06000110 RID: 272 RVA: 0x00004F30 File Offset: 0x00003130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Product> OnPromotionalPurchaseIntercepted;

		// Token: 0x06000111 RID: 273 RVA: 0x00004F65 File Offset: 0x00003165
		protected AppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) : base(cartValidator, logger, "AppleAppStore")
		{
			this.m_AppAccountToken = Guid.Empty;
			AppleStoreImpl.s_Util = util;
			AppleStoreImpl.s_Instance = this;
			this.m_FetchProductsService = fetchProductsService;
			this.m_TransactionLog = transactionLog;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004FA4 File Offset: 0x000031A4
		public void SetNativeStore(INativeAppleStore apple)
		{
			base.SetNativeStore(apple);
			this.m_Native = apple;
			this.m_FetchProductsService.SetNativeStore(apple);
			Application.quitting += delegate()
			{
				apple.SetUnityPurchasingCallback(null);
			};
			apple.SetUnityPurchasingCallback(new UnityPurchasingCallback(AppleStoreImpl.MessageCallback));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000500F File Offset: 0x0000320F
		[NullableContext(2)]
		public INativeAppleStore GetNativeStore()
		{
			return this.m_Native;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005017 File Offset: 0x00003217
		[NullableContext(2)]
		public string AppReceipt()
		{
			return this.appReceipt;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000501F File Offset: 0x0000321F
		public override void Connect()
		{
			INativeAppleStore native = this.m_Native;
			if (native != null)
			{
				native.Connect();
			}
			IStoreConnectCallback connectCallback = this.ConnectCallback;
			if (connectCallback == null)
			{
				return;
			}
			connectCallback.OnStoreConnectionSucceeded();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005042 File Offset: 0x00003242
		protected override void FinishTransaction([Nullable(2)] ProductDefinition productDefinition, string transactionId)
		{
			this.m_TransactionLog.Record(transactionId);
			base.FinishTransaction(productDefinition, transactionId);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005058 File Offset: 0x00003258
		public override void Purchase(ICart cart)
		{
			this.m_CartValidator.Validate(cart);
			ProductDefinition definition = cart.Items().First<CartItem>().Product.definition;
			string developerPayload = this.PurchaseOptions();
			this.Purchase(definition, developerPayload);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005096 File Offset: 0x00003296
		private string PurchaseOptions()
		{
			return Json.Serialize(new Dictionary<string, object>
			{
				{
					"simulatesAskToBuyInSandbox",
					this.simulateAskToBuy
				},
				{
					"appAccountToken",
					this.m_AppAccountToken
				}
			});
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000050D0 File Offset: 0x000032D0
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			AppleStoreImpl.<FetchProducts>d__29 <FetchProducts>d__;
			<FetchProducts>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FetchProducts>d__.<>4__this = this;
			<FetchProducts>d__.products = products;
			<FetchProducts>d__.<>1__state = -1;
			<FetchProducts>d__.<>t__builder.Start<AppleStoreImpl.<FetchProducts>d__29>(ref <FetchProducts>d__);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000510F File Offset: 0x0000330F
		public override void FetchPurchases()
		{
			INativeAppleStore native = this.m_Native;
			if (native == null)
			{
				return;
			}
			native.FetchExistingPurchases();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005121 File Offset: 0x00003321
		public void SetFetchStorePromotionOrderCallbacks(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
			this.m_FetchStorePromotionOrderError = errorCallback;
			this.m_FetchStorePromotionOrderSuccess = successCallback;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005131 File Offset: 0x00003331
		public void SetFetchStorePromotionVisibilityCallbacks(Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
			this.m_FetchStorePromotionVisibilityError = errorCallback;
			this.m_FetchStorePromotionVisibilitySuccess = successCallback;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005141 File Offset: 0x00003341
		[NullableContext(2)]
		public void SetRestoreTransactionsCallback(Action<bool, string> successCallback)
		{
			this.m_RestoreCallback = successCallback;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000514A File Offset: 0x0000334A
		public void ClearTransactionLog()
		{
			this.m_TransactionLog.Clear();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005157 File Offset: 0x00003357
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000515F File Offset: 0x0000335F
		public bool simulateAskToBuy { get; set; }

		// Token: 0x06000121 RID: 289 RVA: 0x00005168 File Offset: 0x00003368
		public void SetAppAccountToken(Guid value)
		{
			this.m_AppAccountToken = value;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005174 File Offset: 0x00003374
		public override void OnPurchaseDeferred(string productDetails)
		{
			ProductDescription productDescription = JSONSerializer.DeserializeProductDescriptionsFromFetchProductsSk2(productDetails).FirstOrDefault<ProductDescription>();
			if (productDescription != null)
			{
				Guid? appAccountToken = null;
				DeferredOrder deferredOrder = this.GenerateAppleDeferredOrder(productDescription.storeSpecificId, productDescription.transactionId, "", OwnershipType.Undefined, appAccountToken, null);
				IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
				if (purchaseCallback == null)
				{
					return;
				}
				purchaseCallback.OnPurchaseDeferred(deferredOrder);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000051C4 File Offset: 0x000033C4
		private void OnPromotionalPurchaseAttempted(string payload)
		{
			if (this.OnPromotionalPurchaseIntercepted != null)
			{
				Product product = this.ProductCache.Find(payload);
				if (product != null)
				{
					this.OnPromotionalPurchaseIntercepted(product);
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000051F8 File Offset: 0x000033F8
		public override void OnPurchasesFetched(string json)
		{
			Dictionary<string, Dictionary<string, object>> fetchedPurchases = JSONSerializer.DeserializeFetchedPurchases(json);
			List<Order> orders = this.CreateOrdersFromFetchedPurchases(fetchedPurchases);
			IStorePurchaseFetchCallback purchaseFetchCallback = this.PurchaseFetchCallback;
			if (purchaseFetchCallback == null)
			{
				return;
			}
			purchaseFetchCallback.OnAllPurchasesRetrieved(orders);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005228 File Offset: 0x00003428
		private List<Order> CreateOrdersFromFetchedPurchases(Dictionary<string, Dictionary<string, object>> fetchedPurchases)
		{
			List<Order> first = new List<Order>();
			Dictionary<string, object> transactions;
			if (fetchedPurchases.TryGetValue("unfinishedTransactions", out transactions))
			{
				first = this.GenerateOrdersFromProducts(transactions, true);
			}
			List<Order> second = new List<Order>();
			Dictionary<string, object> transactions2;
			if (fetchedPurchases.TryGetValue("finishedTransactions", out transactions2))
			{
				second = this.GenerateOrdersFromProducts(transactions2, false);
			}
			return first.Concat(second).ToList<Order>();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005280 File Offset: 0x00003480
		private List<Order> GenerateOrdersFromProducts(Dictionary<string, object> transactions, bool isPending)
		{
			List<Order> list = new List<Order>();
			foreach (KeyValuePair<string, object> keyValuePair in transactions)
			{
				Dictionary<string, object> dictionary = keyValuePair.Value as Dictionary<string, object>;
				if (dictionary != null)
				{
					string transactionID = dictionary.TryGetString("transactionId");
					string id = dictionary.TryGetString("productId");
					string originalTransactionId = dictionary.TryGetString("originalTransactionId");
					OwnershipType ownershipType = AppleStoreImpl.OwnershipTypeFromString(dictionary.TryGetString("ownershipType"));
					string input = dictionary.TryGetString("appAccountToken");
					string signatureJws = dictionary.TryGetString("signatureJws");
					Guid? appAccountToken = null;
					Guid value;
					if (Guid.TryParse(input, out value))
					{
						appAccountToken = new Guid?(value);
					}
					if (isPending)
					{
						list.Add(this.GenerateApplePendingOrder(id, transactionID, originalTransactionId, ownershipType, appAccountToken, signatureJws));
					}
					else
					{
						list.Add(this.GenerateAppleConfirmedOrder(id, transactionID, originalTransactionId, ownershipType, appAccountToken, signatureJws));
					}
				}
			}
			return list;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000538C File Offset: 0x0000358C
		private static OwnershipType OwnershipTypeFromString(string ownershipTypeString)
		{
			OwnershipType result;
			if (!(ownershipTypeString == "PURCHASED"))
			{
				if (!(ownershipTypeString == "FAMILY_SHARED"))
				{
					result = OwnershipType.Undefined;
				}
				else
				{
					result = OwnershipType.FamilyShared;
				}
			}
			else
			{
				result = OwnershipType.Purchased;
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000053C0 File Offset: 0x000035C0
		private void OnTransactionsRestoredSuccess()
		{
			Action<bool, string> restoreCallback = this.m_RestoreCallback;
			if (restoreCallback == null)
			{
				return;
			}
			restoreCallback(true, null);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000053D4 File Offset: 0x000035D4
		private void OnTransactionsRestoredFail(string error)
		{
			Action<bool, string> restoreCallback = this.m_RestoreCallback;
			if (restoreCallback == null)
			{
				return;
			}
			restoreCallback(false, error);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000053E8 File Offset: 0x000035E8
		private void OnEntitlementRevoked(string purchaseDetailsJson)
		{
			string productId = JSONSerializer.DeserializePurchaseDetails(purchaseDetailsJson).TryGetString("productId");
			this.RevokeEntitlement(productId);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000540D File Offset: 0x0000360D
		private void RevokeEntitlement(string productId)
		{
			IOnEntitlementRevokedCallback entitlementRevokedCallback = this.EntitlementRevokedCallback;
			if (entitlementRevokedCallback == null)
			{
				return;
			}
			entitlementRevokedCallback.onEntitlementRevoked(productId);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005420 File Offset: 0x00003620
		private void OnFetchStorePromotionOrderSucceeded(string productIds)
		{
			if (this.m_FetchStorePromotionOrderSuccess != null)
			{
				List<object> list = productIds.ArrayListFromJson();
				List<Product> list2 = new List<Product>();
				if (list != null)
				{
					foreach (object obj in list)
					{
						Product item = this.ProductCache.FindOrDefault(obj as string);
						list2.Add(item);
					}
				}
				this.m_FetchStorePromotionOrderSuccess(list2);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000054A8 File Offset: 0x000036A8
		private void OnFetchStorePromotionOrderFailed(string error)
		{
			Action<string> fetchStorePromotionOrderError = this.m_FetchStorePromotionOrderError;
			if (fetchStorePromotionOrderError == null)
			{
				return;
			}
			fetchStorePromotionOrderError(error);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000054BC File Offset: 0x000036BC
		private void OnFetchStorePromotionVisibilitySucceeded(string result)
		{
			if (this.m_FetchStorePromotionVisibilitySuccess != null)
			{
				Dictionary<string, object> dictionary = Json.Deserialize(result) as Dictionary<string, object>;
				object obj;
				if (dictionary == null)
				{
					obj = null;
				}
				else
				{
					obj = dictionary.ToDictionary((KeyValuePair<string, object> k) => k.Key, (KeyValuePair<string, object> k) => k.Value.ToString());
				}
				object obj2 = obj;
				string arg = ((obj2 != null) ? obj2["productId"] : null) ?? string.Empty;
				AppleStorePromotionVisibility arg2;
				Enum.TryParse<AppleStorePromotionVisibility>((obj2 != null) ? obj2["visibility"] : null, out arg2);
				this.m_FetchStorePromotionVisibilitySuccess(arg, arg2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000556B File Offset: 0x0000376B
		private void OnFetchStorePromotionVisibilityFailed(string error)
		{
			Action<string> fetchStorePromotionVisibilityError = this.m_FetchStorePromotionVisibilityError;
			if (fetchStorePromotionVisibilityError == null)
			{
				return;
			}
			fetchStorePromotionVisibilityError(error);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005580 File Offset: 0x00003780
		[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
		private static void MessageCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
			IUtil util = AppleStoreImpl.s_Util;
			if (util == null)
			{
				return;
			}
			util.RunOnMainThread(delegate
			{
				AppleStoreImpl appleStoreImpl = AppleStoreImpl.s_Instance;
				if (appleStoreImpl == null)
				{
					return;
				}
				appleStoreImpl.ProcessCallbackMessage(subjectPtr, payloadPtr, entitlementStatus);
			});
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000055C4 File Offset: 0x000037C4
		private void ProcessCallbackMessage(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
			string text = this.ConvertPtrToString(subjectPtr);
			string text2 = this.ConvertPtrToString(payloadPtr);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 2800160766U)
			{
				if (num <= 773163747U)
				{
					if (num <= 418950463U)
					{
						if (num != 368617421U)
						{
							if (num != 418950463U)
							{
								return;
							}
							if (!(text == "OnCheckEntitlement"))
							{
								return;
							}
							this.OnCheckEntitlement(text2, entitlementStatus);
							return;
						}
						else
						{
							if (!(text == "OnProductsFetched"))
							{
								return;
							}
							this.m_FetchProductsService.OnProductsFetched(text2);
							return;
						}
					}
					else if (num != 677120319U)
					{
						if (num != 773163747U)
						{
							return;
						}
						if (!(text == "OnFetchStorePromotionOrderSucceeded"))
						{
							return;
						}
						this.OnFetchStorePromotionOrderSucceeded(text2);
						return;
					}
					else
					{
						if (!(text == "OnTransactionsRestoredFail"))
						{
							return;
						}
						this.OnTransactionsRestoredFail(text2);
						return;
					}
				}
				else if (num <= 853626987U)
				{
					if (num != 778562916U)
					{
						if (num != 853626987U)
						{
							return;
						}
						if (!(text == "OnEntitlementRevoked"))
						{
							return;
						}
						this.OnEntitlementRevoked(text2);
						return;
					}
					else
					{
						if (!(text == "OnPurchaseDeferred"))
						{
							return;
						}
						this.OnPurchaseDeferred(text2);
						return;
					}
				}
				else if (num != 1523640433U)
				{
					if (num != 2800160766U)
					{
						return;
					}
					if (!(text == "OnTransactionsRestoredSuccess"))
					{
						return;
					}
					this.OnTransactionsRestoredSuccess();
					return;
				}
				else
				{
					if (!(text == "onAppReceiptRefreshFailed"))
					{
						return;
					}
					this.OnAppReceiptRefreshedFailed(text2);
					return;
				}
			}
			else if (num <= 3385076384U)
			{
				if (num <= 2915647883U)
				{
					if (num != 2875512373U)
					{
						if (num != 2915647883U)
						{
							return;
						}
						if (!(text == "OnFetchStorePromotionVisibilitySucceeded"))
						{
							return;
						}
						this.OnFetchStorePromotionVisibilitySucceeded(text2);
						return;
					}
					else
					{
						if (!(text == "OnPromotionalPurchaseAttempted"))
						{
							return;
						}
						this.OnPromotionalPurchaseAttempted(text2);
						return;
					}
				}
				else if (num != 3320864102U)
				{
					if (num != 3385076384U)
					{
						return;
					}
					if (!(text == "OnPurchaseSucceeded"))
					{
						return;
					}
					this.OnPurchaseSucceeded(text2);
					return;
				}
				else
				{
					if (!(text == "OnPurchaseFailed"))
					{
						return;
					}
					base.OnPurchaseFailed(text2);
					return;
				}
			}
			else if (num <= 3621268753U)
			{
				if (num != 3386092303U)
				{
					if (num != 3621268753U)
					{
						return;
					}
					if (!(text == "OnPurchasesFetched"))
					{
						return;
					}
					this.OnPurchasesFetched(text2);
					return;
				}
				else
				{
					if (!(text == "OnFetchStorePromotionOrderFailed"))
					{
						return;
					}
					this.OnFetchStorePromotionOrderFailed(text2);
					return;
				}
			}
			else if (num != 3622431981U)
			{
				if (num != 4086114193U)
				{
					if (num != 4220937063U)
					{
						return;
					}
					if (!(text == "OnFetchStorePromotionVisibilityFailed"))
					{
						return;
					}
					this.OnFetchStorePromotionVisibilityFailed(text2);
					return;
				}
				else
				{
					if (!(text == "OnProductsFetchFailed"))
					{
						return;
					}
					this.m_FetchProductsService.OnProductDetailsRetrieveFailed(text2);
					return;
				}
			}
			else
			{
				if (!(text == "onAppReceiptRefreshed"))
				{
					return;
				}
				this.OnAppReceiptRetrieved(text2);
				return;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000588C File Offset: 0x00003A8C
		private string ConvertPtrToString(IntPtr subjectPtr)
		{
			string result = "";
			if (subjectPtr != IntPtr.Zero)
			{
				result = (Marshal.PtrToStringAuto(subjectPtr) ?? string.Empty);
				INativeAppleStore native = this.m_Native;
				if (native != null)
				{
					native.DeallocateMemory(subjectPtr);
				}
			}
			return result;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000058CF File Offset: 0x00003ACF
		public void SetRefreshAppReceiptCallbacks(Action<string> successCallback, Action<string> errorCallback)
		{
			this.m_RefreshAppReceiptSuccessCallback = successCallback;
			this.m_RefreshAppReceiptErrorCallback = errorCallback;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000058DF File Offset: 0x00003ADF
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
			this.m_RefreshAppReceipt = refreshAppReceipt;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000058E8 File Offset: 0x00003AE8
		private void OnAppReceiptRetrieved(string receipt)
		{
			this.appReceipt = receipt;
			TaskCompletionSource<bool> refreshAppReceiptTask = this.m_RefreshAppReceiptTask;
			if (refreshAppReceiptTask != null)
			{
				refreshAppReceiptTask.TrySetResult(true);
			}
			Action<string> refreshAppReceiptSuccessCallback = this.m_RefreshAppReceiptSuccessCallback;
			if (refreshAppReceiptSuccessCallback == null)
			{
				return;
			}
			refreshAppReceiptSuccessCallback(receipt);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005915 File Offset: 0x00003B15
		private void OnAppReceiptRefreshedFailed(string error)
		{
			TaskCompletionSource<bool> refreshAppReceiptTask = this.m_RefreshAppReceiptTask;
			if (refreshAppReceiptTask != null)
			{
				refreshAppReceiptTask.TrySetResult(false);
			}
			Action<string> refreshAppReceiptErrorCallback = this.m_RefreshAppReceiptErrorCallback;
			if (refreshAppReceiptErrorCallback == null)
			{
				return;
			}
			refreshAppReceiptErrorCallback(error);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000593B File Offset: 0x00003B3B
		public override void CheckEntitlement(ProductDefinition productDefinition)
		{
			INativeAppleStore native = this.m_Native;
			if (native == null)
			{
				return;
			}
			native.CheckEntitlement(productDefinition.storeSpecificId);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005954 File Offset: 0x00003B54
		private void OnCheckEntitlement(string productId, int entitlementStatus)
		{
			Product product = this.ProductCache.FindOrDefault(productId);
			if (entitlementStatus != 0)
			{
				ProductType type = product.definition.type;
				if (type != ProductType.Consumable)
				{
					if (type - ProductType.NonConsumable <= 1)
					{
						IStoreCheckEntitlementCallback entitlementCallback = this.EntitlementCallback;
						if (entitlementCallback == null)
						{
							return;
						}
						entitlementCallback.OnCheckEntitlement(product.definition, (entitlementStatus == 1) ? EntitlementStatus.FullyEntitled : EntitlementStatus.EntitledButNotFinished, null);
						return;
					}
				}
				else
				{
					IStoreCheckEntitlementCallback entitlementCallback2 = this.EntitlementCallback;
					if (entitlementCallback2 == null)
					{
						return;
					}
					entitlementCallback2.OnCheckEntitlement(product.definition, EntitlementStatus.EntitledUntilConsumed, null);
					return;
				}
			}
			IStoreCheckEntitlementCallback entitlementCallback3 = this.EntitlementCallback;
			if (entitlementCallback3 == null)
			{
				return;
			}
			entitlementCallback3.OnCheckEntitlement(product.definition, EntitlementStatus.NotEntitled, null);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000059DC File Offset: 0x00003BDC
		private void OnPurchaseSucceeded(string purchaseDetailsJson)
		{
			AppleStoreImpl.<OnPurchaseSucceeded>d__63 <OnPurchaseSucceeded>d__;
			<OnPurchaseSucceeded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnPurchaseSucceeded>d__.<>4__this = this;
			<OnPurchaseSucceeded>d__.purchaseDetailsJson = purchaseDetailsJson;
			<OnPurchaseSucceeded>d__.<>1__state = -1;
			<OnPurchaseSucceeded>d__.<>t__builder.Start<AppleStoreImpl.<OnPurchaseSucceeded>d__63>(ref <OnPurchaseSucceeded>d__);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005A1B File Offset: 0x00003C1B
		private Task<bool> RefreshAppReceiptAsync()
		{
			if (this.m_RefreshAppReceiptTask != null)
			{
				return this.m_RefreshAppReceiptTask.Task;
			}
			this.m_RefreshAppReceiptTask = new TaskCompletionSource<bool>();
			INativeAppleStore native = this.m_Native;
			if (native != null)
			{
				native.RefreshAppReceipt();
			}
			return this.m_RefreshAppReceiptTask.Task;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005A58 File Offset: 0x00003C58
		private void ProcessValidPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
			if (!this.m_TransactionLog.HasRecordOf(transactionId))
			{
				this.ProcessNewPurchase(id, transactionId, originalTransactionId, expirationDate, ownershipType, appAccountToken, signatureJws);
				return;
			}
			this.ProcessLoggedPurchase(id, transactionId, originalTransactionId, expirationDate, ownershipType, appAccountToken, signatureJws);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005A8C File Offset: 0x00003C8C
		private void ProcessNewPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
			PendingOrder order = this.GenerateApplePendingOrder(id, transactionId, originalTransactionId, ownershipType, appAccountToken, signatureJws);
			IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseSucceeded(order);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005ABC File Offset: 0x00003CBC
		private void ProcessLoggedPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, [Nullable(2)] string signatureJws)
		{
			ConfirmedOrder confirmedOrder = this.GenerateAppleConfirmedOrder(id, transactionId, originalTransactionId, ownershipType, appAccountToken, signatureJws);
			this.EnsureConfirmedOrderIsFinished(confirmedOrder);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00005AE0 File Offset: 0x00003CE0
		private DeferredOrder GenerateAppleDeferredOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, [Nullable(2)] string signatureJws)
		{
			return new DeferredOrder(new Cart(base.FindProductById(id)), new AppleOrderInfo(transactionID, this.m_StoreName, this, originalTransactionId, ownershipType, appAccountToken, signatureJws));
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005B0C File Offset: 0x00003D0C
		private PendingOrder GenerateApplePendingOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, [Nullable(2)] string signatureJws)
		{
			return new PendingOrder(new Cart(base.FindProductById(id)), new AppleOrderInfo(transactionID, this.m_StoreName, this, originalTransactionId, ownershipType, appAccountToken, signatureJws));
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005B38 File Offset: 0x00003D38
		private ConfirmedOrder GenerateAppleConfirmedOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, [Nullable(2)] string signatureJws)
		{
			return new ConfirmedOrder(new Cart(base.FindProductById(id)), new AppleOrderInfo(transactionID, this.m_StoreName, this, originalTransactionId, ownershipType, appAccountToken, signatureJws));
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005B64 File Offset: 0x00003D64
		private void EnsureConfirmedOrderIsFinished(ConfirmedOrder confirmedOrder)
		{
			CartItem cartItem = confirmedOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			ProductDefinition productDefinition = (cartItem != null) ? cartItem.Product.definition : null;
			this.InvokeErrorIfRepurchasedConsumables(confirmedOrder);
			base.FinishTransaction(productDefinition, confirmedOrder.Info.TransactionID);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005BAC File Offset: 0x00003DAC
		private void InvokeErrorIfRepurchasedConsumables(ConfirmedOrder confirmedOrder)
		{
			if (!confirmedOrder.CartOrdered.Items().All((CartItem item) => item.Product.definition.type == ProductType.Consumable))
			{
				return;
			}
			FailedOrder failedOrder = new FailedOrder(confirmedOrder.CartOrdered, PurchaseFailureReason.DuplicateTransaction, "Consumable purchase has already been confirmed by IAP.");
			IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseFailed(failedOrder);
		}

		// Token: 0x04000071 RID: 113
		[Nullable(2)]
		private Action<bool> m_ObsoleteRestoreCallback;

		// Token: 0x04000072 RID: 114
		[Nullable(2)]
		private Action<bool, string> m_RestoreCallback;

		// Token: 0x04000073 RID: 115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> m_FetchStorePromotionOrderError;

		// Token: 0x04000074 RID: 116
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<List<Product>> m_FetchStorePromotionOrderSuccess;

		// Token: 0x04000075 RID: 117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> m_FetchStorePromotionVisibilityError;

		// Token: 0x04000076 RID: 118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess;

		// Token: 0x04000077 RID: 119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> m_RefreshAppReceiptSuccessCallback;

		// Token: 0x04000078 RID: 120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> m_RefreshAppReceiptErrorCallback;

		// Token: 0x04000079 RID: 121
		[Nullable(2)]
		private TaskCompletionSource<bool> m_RefreshAppReceiptTask;

		// Token: 0x0400007A RID: 122
		private bool m_RefreshAppReceipt = true;

		// Token: 0x0400007B RID: 123
		[Nullable(2)]
		private INativeAppleStore m_Native;

		// Token: 0x0400007C RID: 124
		private readonly IAppleFetchProductsService m_FetchProductsService;

		// Token: 0x0400007D RID: 125
		private readonly ITransactionLog m_TransactionLog;

		// Token: 0x0400007E RID: 126
		[Nullable(2)]
		private static IUtil s_Util;

		// Token: 0x0400007F RID: 127
		[Nullable(2)]
		private static AppleStoreImpl s_Instance;

		// Token: 0x04000080 RID: 128
		[Nullable(2)]
		private string appReceipt;

		// Token: 0x04000081 RID: 129
		private bool m_IsTransactionObserverEnabled;

		// Token: 0x04000082 RID: 130
		private Guid m_AppAccountToken;
	}
}
