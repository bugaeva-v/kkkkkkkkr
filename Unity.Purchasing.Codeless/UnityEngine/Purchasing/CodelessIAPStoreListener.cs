using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Core;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000008 RID: 8
	[NullableContext(1)]
	[Nullable(0)]
	public class CodelessIAPStoreListener
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000024D4 File Offset: 0x000006D4
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeCodelessPurchasingOnLoad()
		{
			CodelessIAPStoreListener.<InitializeCodelessPurchasingOnLoad>d__14 <InitializeCodelessPurchasingOnLoad>d__;
			<InitializeCodelessPurchasingOnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitializeCodelessPurchasingOnLoad>d__.<>1__state = -1;
			<InitializeCodelessPurchasingOnLoad>d__.<>t__builder.Start<CodelessIAPStoreListener.<InitializeCodelessPurchasingOnLoad>d__14>(ref <InitializeCodelessPurchasingOnLoad>d__);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002503 File Offset: 0x00000703
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreConfiguration<[Nullable(0)] T>() where T : IStoreConfiguration
		{
			return this.m_Builder.Configure<T>();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002510 File Offset: 0x00000710
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreExtensions<[Nullable(0)] T>() where T : IStoreExtension
		{
			return this.extensions.GetExtension<T>();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000251D File Offset: 0x0000071D
		public static CodelessIAPStoreListener Instance
		{
			get
			{
				if (CodelessIAPStoreListener.s_Instance == null)
				{
					CodelessIAPStoreListener.CreateCodelessIAPStoreListenerInstance().GetAwaiter();
				}
				return CodelessIAPStoreListener.s_Instance;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002538 File Offset: 0x00000738
		private static Task CreateCodelessIAPStoreListenerInstance()
		{
			CodelessIAPStoreListener.<CreateCodelessIAPStoreListenerInstance>d__19 <CreateCodelessIAPStoreListenerInstance>d__;
			<CreateCodelessIAPStoreListenerInstance>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateCodelessIAPStoreListenerInstance>d__.<>1__state = -1;
			<CreateCodelessIAPStoreListenerInstance>d__.<>t__builder.Start<CodelessIAPStoreListener.<CreateCodelessIAPStoreListenerInstance>d__19>(ref <CreateCodelessIAPStoreListenerInstance>d__);
			return <CreateCodelessIAPStoreListenerInstance>d__.<>t__builder.Task;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002574 File Offset: 0x00000774
		private Task InitializePurchasing()
		{
			CodelessIAPStoreListener.<InitializePurchasing>d__20 <InitializePurchasing>d__;
			<InitializePurchasing>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitializePurchasing>d__.<>4__this = this;
			<InitializePurchasing>d__.<>1__state = -1;
			<InitializePurchasing>d__.<>t__builder.Start<CodelessIAPStoreListener.<InitializePurchasing>d__20>(ref <InitializePurchasing>d__);
			return <InitializePurchasing>d__.<>t__builder.Task;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000025B7 File Offset: 0x000007B7
		private void InitCatalog()
		{
			this.m_CatalogProvider = CodelessCatalogProvider.PopulateCatalogProvider(this.m_Catalog);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025CA File Offset: 0x000007CA
		private void CreateServices()
		{
			this.m_StoreService = StoreServiceProvider.GetDefaultStoreService();
			this.m_ProductService = ProductServiceProvider.GetDefaultProductService();
			this.m_PurchasingService = PurchaseServiceProvider.GetDefaultPurchaseService();
			this.ConfigureServiceCallbacks();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025F3 File Offset: 0x000007F3
		private void ConfigureServiceCallbacks()
		{
			this.ConfigureProductServiceCallbacks();
			this.ConfigurePurchasingServiceCallbacks();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002601 File Offset: 0x00000801
		private void ConfigureProductServiceCallbacks()
		{
			if (this.m_ProductService != null)
			{
				this.m_ProductService.OnProductsFetched += this.OnInitialProductsFetched;
				this.m_ProductService.OnProductsFetchFailed += this.OnInitialProductsFetchFailed;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000263C File Offset: 0x0000083C
		private void ChangeProductServiceCallbacks()
		{
			if (this.m_ProductService != null)
			{
				this.m_ProductService.OnProductsFetched -= this.OnInitialProductsFetched;
				this.m_ProductService.OnProductsFetchFailed -= this.OnInitialProductsFetchFailed;
				this.m_ProductService.OnProductsFetched += this.OnAdditionalProductsFetched;
				this.m_ProductService.OnProductsFetchFailed += this.OnAdditionalProductsFetchFailed;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000026B0 File Offset: 0x000008B0
		private void ConfigurePurchasingServiceCallbacks()
		{
			if (this.m_PurchasingService != null)
			{
				this.m_PurchasingService.OnPurchasesFetched += this.OnPurchasesFetched;
				this.m_PurchasingService.OnPurchasesFetchFailed += this.OnPurchasesFetchFailure;
				this.m_PurchasingService.OnPurchasePending += this.OnOrderPending;
				this.m_PurchasingService.OnPurchaseConfirmed += this.OnPurchaseConfirmed;
				this.m_PurchasingService.OnPurchaseFailed += this.OnPurchaseFailed;
				this.m_PurchasingService.OnPurchaseDeferred += this.OnOrderDeferred;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002752 File Offset: 0x00000952
		private void OnInitialProductsFetched(List<Product> products)
		{
			this.FetchExistingPurchases();
			this.ChangeProductServiceCallbacks();
			this.m_InitializationComplete = true;
			CodelessIAPStoreListener.initializationComplete = true;
			this.HandleOnInitForAllButtons();
			this.InvokeOnProductsFetched(products);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000277C File Offset: 0x0000097C
		private void HandleOnInitForAllButtons()
		{
			foreach (CodelessIAPButton codelessIAPButton in this.m_ActiveCodelessButtons)
			{
				codelessIAPButton.OnInitCompleted();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000027CC File Offset: 0x000009CC
		private void FetchExistingPurchases()
		{
			IPurchaseService purchasingService = this.m_PurchasingService;
			if (purchasingService == null)
			{
				return;
			}
			purchasingService.FetchPurchases();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027DE File Offset: 0x000009DE
		private void InvokeOnProductsFetched(List<Product> products)
		{
			this.InvokeListenersOnProductsFetched(products);
			this.InvokeButtonsOnProductsFetched(products);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000027F0 File Offset: 0x000009F0
		private void InvokeListenersOnProductsFetched(List<Product> products)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnProductsFetched(products);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002844 File Offset: 0x00000A44
		private void InvokeButtonsOnProductsFetched(List<Product> products)
		{
			using (List<Product>.Enumerator enumerator = products.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Product product = enumerator.Current;
					IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
					Func<CodelessIAPButton, bool> predicate;
					Func<CodelessIAPButton, bool> <>9__0;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == product.definition.id));
					}
					foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
					{
						codelessIAPButton.OnProductFetched(product);
					}
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000028FC File Offset: 0x00000AFC
		private void OnInitialProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
			this.InvokeListenersOnProductsFetchFailed(productFetchFailed);
			this.InvokeButtonsOnProductsFetchFailed(productFetchFailed);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000290C File Offset: 0x00000B0C
		private void InvokeListenersOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnProductsFetchFailed(productFetchFailed);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002960 File Offset: 0x00000B60
		private void InvokeButtonsOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
			using (List<ProductDefinition>.Enumerator enumerator = productFetchFailed.FailedFetchProducts.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProductDefinition product = enumerator.Current;
					IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
					Func<CodelessIAPButton, bool> predicate;
					Func<CodelessIAPButton, bool> <>9__0;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == product.id));
					}
					foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
					{
						codelessIAPButton.OnProductFetchFailed(product, productFetchFailed.FailureReason);
					}
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002A20 File Offset: 0x00000C20
		private void OnAdditionalProductsFetched(List<Product> products)
		{
			this.InvokeOnProductsFetched(products);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002A29 File Offset: 0x00000C29
		private void OnAdditionalProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
			this.InvokeListenersOnProductsFetchFailed(productFetchFailed);
			this.InvokeButtonsOnProductsFetchFailed(productFetchFailed);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A39 File Offset: 0x00000C39
		private void OnPurchasesFetched(Orders existingOrders)
		{
			this.InvokeListenersOnPurchasesFetched(existingOrders);
			this.InvokeButtonsOnPurchasesFetched(existingOrders);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A4C File Offset: 0x00000C4C
		private void InvokeListenersOnPurchasesFetched(Orders existingOrders)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnPurchasesFetched(existingOrders);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002AA0 File Offset: 0x00000CA0
		private void InvokeButtonsOnPurchasesFetched(Orders existingOrders)
		{
			foreach (PendingOrder pendingOrder in existingOrders.PendingOrders)
			{
				using (IEnumerator<CartItem> enumerator2 = pendingOrder.CartOrdered.Items().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						CartItem cartItem = enumerator2.Current;
						IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
						Func<CodelessIAPButton, bool> predicate;
						Func<CodelessIAPButton, bool> <>9__0;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == cartItem.Product.definition.id));
						}
						foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
						{
							codelessIAPButton.OnPurchaseFetched(pendingOrder);
						}
					}
				}
			}
			foreach (ConfirmedOrder confirmedOrder in existingOrders.ConfirmedOrders)
			{
				using (IEnumerator<CartItem> enumerator2 = confirmedOrder.CartOrdered.Items().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						CartItem cartItem = enumerator2.Current;
						IEnumerable<CodelessIAPButton> activeCodelessButtons2 = this.m_ActiveCodelessButtons;
						Func<CodelessIAPButton, bool> predicate2;
						Func<CodelessIAPButton, bool> <>9__1;
						if ((predicate2 = <>9__1) == null)
						{
							predicate2 = (<>9__1 = ((CodelessIAPButton button) => button.productId == cartItem.Product.definition.id));
						}
						foreach (CodelessIAPButton codelessIAPButton2 in activeCodelessButtons2.Where(predicate2))
						{
							codelessIAPButton2.OnPurchaseFetched(confirmedOrder);
						}
					}
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002C88 File Offset: 0x00000E88
		private void OnPurchasesFetchFailure(PurchasesFetchFailureDescription failure)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnPurchasesFetchFailure(failure);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void OnOrderPending(PendingOrder order)
		{
			this.InvokeOnOrderPending(order);
			this.ConfirmOrderIfAutomatic(order);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002CEC File Offset: 0x00000EEC
		private void InvokeOnOrderPending(PendingOrder pendingOrder)
		{
			this.InvokeListenersOnOrderPending(pendingOrder);
			this.InvokeButtonsOnOrderPending(pendingOrder);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002CFC File Offset: 0x00000EFC
		private void InvokeListenersOnOrderPending(PendingOrder pendingOrder)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnOrderPending(pendingOrder);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002D50 File Offset: 0x00000F50
		private void InvokeButtonsOnOrderPending(PendingOrder pendingOrder)
		{
			using (IEnumerator<CartItem> enumerator = pendingOrder.CartOrdered.Items().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CartItem cartItem = enumerator.Current;
					IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
					Func<CodelessIAPButton, bool> predicate;
					Func<CodelessIAPButton, bool> <>9__0;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == cartItem.Product.definition.id));
					}
					foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
					{
						codelessIAPButton.OnOrderPending(pendingOrder);
					}
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002E04 File Offset: 0x00001004
		private void ConfirmOrderIfAutomatic(PendingOrder order)
		{
			if (this.ShouldConfirmOrderAutomatically(order))
			{
				this.ConfirmOrder(order);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002E18 File Offset: 0x00001018
		private bool ShouldConfirmOrderAutomatically(PendingOrder order)
		{
			if (this.m_ActiveListeners.Any((IAPListener listener) => listener != null && listener.automaticallyConfirmTransaction))
			{
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			foreach (CartItem cartItem in order.CartOrdered.Items())
			{
				CodelessIAPButton codelessIAPButton = this.FindMatchingButtonByProduct(cartItem.Product.definition.id);
				if (codelessIAPButton)
				{
					if (codelessIAPButton != null && codelessIAPButton.automaticallyConfirmTransaction)
					{
						flag2 = true;
					}
					else
					{
						flag = true;
					}
				}
			}
			bool flag3 = flag && flag2;
			return flag2;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002ED0 File Offset: 0x000010D0
		[return: Nullable(2)]
		private CodelessIAPButton FindMatchingButtonByProduct(string productId)
		{
			foreach (CodelessIAPButton codelessIAPButton in this.m_ActiveCodelessButtons)
			{
				if (productId.Equals(codelessIAPButton.productId))
				{
					return codelessIAPButton;
				}
			}
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002F34 File Offset: 0x00001134
		private void ConfirmOrder(PendingOrder pendingOrder)
		{
			IPurchaseService purchasingService = this.m_PurchasingService;
			if (purchasingService == null)
			{
				return;
			}
			purchasingService.ConfirmPurchase(pendingOrder);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F48 File Offset: 0x00001148
		private void OnPurchaseConfirmed(Order order)
		{
			ConfirmedOrder confirmedOrder = order as ConfirmedOrder;
			if (confirmedOrder != null)
			{
				this.OnOrderConfirmed(confirmedOrder);
				return;
			}
			FailedOrder failedOrder = order as FailedOrder;
			if (failedOrder == null)
			{
				Debug.unityLogger.LogIAPError(string.Format("CodelessIAPStoreListener OnPurchaseConfirmed invoked with an unexpected order type: : {0}", order.GetType()));
				return;
			}
			this.OnPurchaseFailed(failedOrder);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F95 File Offset: 0x00001195
		private void OnOrderConfirmed(ConfirmedOrder order)
		{
			this.InvokeListenersOnOrderConfirmed(order);
			this.InvokeButtonsOnOrderConfirmed(order);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FA8 File Offset: 0x000011A8
		private void InvokeListenersOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnOrderConfirmed(confirmedOrder);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FFC File Offset: 0x000011FC
		private void InvokeButtonsOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
			using (IEnumerator<CartItem> enumerator = confirmedOrder.CartOrdered.Items().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CartItem cartItem = enumerator.Current;
					IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
					Func<CodelessIAPButton, bool> predicate;
					Func<CodelessIAPButton, bool> <>9__0;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == cartItem.Product.definition.id));
					}
					foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
					{
						codelessIAPButton.OnOrderConfirmed(confirmedOrder);
					}
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030B0 File Offset: 0x000012B0
		private void OnPurchaseFailed(FailedOrder failedOrder)
		{
			this.InvokeListenersOnPurchaseFailed(failedOrder);
			this.InvokeButtonsOnPurchaseFailed(failedOrder);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030C0 File Offset: 0x000012C0
		private void InvokeListenersOnPurchaseFailed(FailedOrder failedOrder)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnPurchaseFailed(failedOrder);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003114 File Offset: 0x00001314
		private void InvokeButtonsOnPurchaseFailed(FailedOrder failedOrder)
		{
			if (failedOrder.CartOrdered != null)
			{
				using (IEnumerator<CartItem> enumerator = failedOrder.CartOrdered.Items().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						CartItem cartItem = enumerator.Current;
						IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
						Func<CodelessIAPButton, bool> predicate;
						Func<CodelessIAPButton, bool> <>9__0;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == cartItem.Product.definition.id));
						}
						foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
						{
							codelessIAPButton.OnPurchaseFailed(failedOrder);
						}
					}
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000031D4 File Offset: 0x000013D4
		private void OnOrderDeferred(DeferredOrder deferredOrder)
		{
			this.InvokeListenersOnOrderDeferred(deferredOrder);
			this.InvokeButtonsOnOrderDeferred(deferredOrder);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000031E4 File Offset: 0x000013E4
		private void InvokeListenersOnOrderDeferred(DeferredOrder deferredOrder)
		{
			foreach (IAPListener iaplistener in this.m_ActiveListeners)
			{
				iaplistener.OnOrderDeferred(deferredOrder);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003238 File Offset: 0x00001438
		private void InvokeButtonsOnOrderDeferred(DeferredOrder deferredOrder)
		{
			foreach (CartItem cartItem in deferredOrder.CartOrdered.Items())
			{
				Product product = cartItem.Product;
				IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
				Func<CodelessIAPButton, bool> predicate;
				Func<CodelessIAPButton, bool> <>9__0;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((CodelessIAPButton button) => button.productId == product.definition.id));
				}
				foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
				{
					codelessIAPButton.OnOrderDeferred(deferredOrder);
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000032F8 File Offset: 0x000014F8
		private Task ConnectToStore()
		{
			CodelessIAPStoreListener.<ConnectToStore>d__60 <ConnectToStore>d__;
			<ConnectToStore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectToStore>d__.<>4__this = this;
			<ConnectToStore>d__.<>1__state = -1;
			<ConnectToStore>d__.<>t__builder.Start<CodelessIAPStoreListener.<ConnectToStore>d__60>(ref <ConnectToStore>d__);
			return <ConnectToStore>d__.<>t__builder.Task;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000333B File Offset: 0x0000153B
		private void FetchInitialProducts()
		{
			if (this.m_ProductService != null)
			{
				CatalogProvider catalogProvider = this.m_CatalogProvider;
				if (catalogProvider == null)
				{
					return;
				}
				catalogProvider.FetchProducts(new Action<List<ProductDefinition>>(this.m_ProductService.FetchProductsWithNoRetries), DefaultStoreHelper.GetDefaultStoreName());
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000336C File Offset: 0x0000156C
		private Task AutoInitializeUnityGamingServicesIfEnabled()
		{
			if (!CodelessIAPStoreListener.ShouldAutoInitUgs())
			{
				return Task.CompletedTask;
			}
			return UnityServices.InitializeAsync();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003380 File Offset: 0x00001580
		private static bool ShouldAutoInitUgs()
		{
			return CodelessIAPStoreListener.Instance.m_Catalog.enableCodelessAutoInitialization && CodelessIAPStoreListener.Instance.m_Catalog.enableUnityGamingServicesAutoInitialization;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000033A4 File Offset: 0x000015A4
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public IStoreController StoreController
		{
			get
			{
				return this.controller;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000033AC File Offset: 0x000015AC
		public bool HasProductInCatalog(string productID)
		{
			using (IEnumerator<ProductCatalogItem> enumerator = this.m_Catalog.allProducts.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.id == productID)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000340C File Offset: 0x0000160C
		[NullableContext(2)]
		public Product GetProduct(string productID)
		{
			IProductService productService = this.m_ProductService;
			ReadOnlyObservableCollection<Product> readOnlyObservableCollection = (productService != null) ? productService.GetProducts() : null;
			Product product2 = (readOnlyObservableCollection != null) ? readOnlyObservableCollection.FirstOrDefault((Product product) => product.definition.id == productID) : null;
			if (product2 != null)
			{
				return product2;
			}
			Debug.unityLogger.LogIAPError("CodelessIAPStoreListener attempted to get unknown product " + productID);
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003471 File Offset: 0x00001671
		public void AddButton(CodelessIAPButton button)
		{
			this.m_ActiveCodelessButtons.Add(button);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000347F File Offset: 0x0000167F
		public void RemoveButton(CodelessIAPButton button)
		{
			this.m_ActiveCodelessButtons.Remove(button);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000348E File Offset: 0x0000168E
		public void AddListener(IAPListener listener)
		{
			this.m_ActiveListeners.Add(listener);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000349C File Offset: 0x0000169C
		public void RemoveListener(IAPListener listener)
		{
			this.m_ActiveListeners.Remove(listener);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000034AC File Offset: 0x000016AC
		[NullableContext(2)]
		public void InitiatePurchase(string productID)
		{
			Product product = this.GetProduct(productID);
			if (product != null)
			{
				try
				{
					IPurchaseService purchasingService = this.m_PurchasingService;
					if (purchasingService != null)
					{
						purchasingService.PurchaseProduct(product);
					}
					return;
				}
				catch (Exception ex)
				{
					this.SendPurchaseFailedEventsToAllButtons(product);
					Debug.unityLogger.LogIAPError(ex.Message);
					return;
				}
			}
			this.SendPurchaseFailedEventsToAllButtons(product);
			Debug.unityLogger.LogIAPError("Cannot initiate purchase because product was not found for ID '" + productID + "'");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003524 File Offset: 0x00001724
		[NullableContext(2)]
		private void SendPurchaseFailedEventsToAllButtons(Product product)
		{
			if (product == null)
			{
				return;
			}
			IEnumerable<CodelessIAPButton> activeCodelessButtons = this.m_ActiveCodelessButtons;
			Func<CodelessIAPButton, bool> <>9__0;
			Func<CodelessIAPButton, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = delegate(CodelessIAPButton button)
				{
					if (button.productId != null)
					{
						string productId = button.productId;
						Product product2 = product;
						return productId == ((product2 != null) ? product2.definition.id : null);
					}
					return false;
				});
			}
			foreach (CodelessIAPButton codelessIAPButton in activeCodelessButtons.Where(predicate))
			{
				PurchaseFailureDescription purchaseFailureDescription = new PurchaseFailureDescription(product, PurchaseFailureReason.PurchasingUnavailable, "PurchasingUnavailable");
				codelessIAPButton.OnPurchaseFailed(purchaseFailureDescription.ConvertToFailedOrder(""));
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000035CC File Offset: 0x000017CC
		public ProductCatalog GetProductCatalog()
		{
			return this.m_Catalog;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000035D4 File Offset: 0x000017D4
		public bool IsInitialized()
		{
			return this.m_InitializationComplete;
		}

		// Token: 0x04000014 RID: 20
		[Nullable(2)]
		private static CodelessIAPStoreListener s_Instance;

		// Token: 0x04000015 RID: 21
		private readonly List<CodelessIAPButton> m_ActiveCodelessButtons = new List<CodelessIAPButton>();

		// Token: 0x04000016 RID: 22
		private readonly List<IAPListener> m_ActiveListeners = new List<IAPListener>();

		// Token: 0x04000017 RID: 23
		private bool m_UnityPurchasingInitialized;

		// Token: 0x04000018 RID: 24
		[Nullable(2)]
		private IStoreService m_StoreService;

		// Token: 0x04000019 RID: 25
		[Nullable(2)]
		private IProductService m_ProductService;

		// Token: 0x0400001A RID: 26
		[Nullable(2)]
		private IPurchaseService m_PurchasingService;

		// Token: 0x0400001B RID: 27
		private readonly ProductCatalog m_Catalog = ProductCatalog.LoadDefaultCatalog();

		// Token: 0x0400001C RID: 28
		[Nullable(2)]
		private CatalogProvider m_CatalogProvider;

		// Token: 0x0400001D RID: 29
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IStoreController controller = new PurchasingManager();

		// Token: 0x0400001E RID: 30
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IExtensionProvider extensions;

		// Token: 0x0400001F RID: 31
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		private ConfigurationBuilder m_Builder;

		// Token: 0x04000020 RID: 32
		private bool m_InitializationComplete;

		// Token: 0x04000021 RID: 33
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public static bool initializationComplete;
	}
}
