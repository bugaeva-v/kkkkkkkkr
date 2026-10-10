using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(2)]
	[Nullable(0)]
	public class StoreController : IStoreService, IProductService, IPurchaseService
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00006E58 File Offset: 0x00005058
		public StoreController(string storeName = null)
		{
			this.m_StoreService = ((storeName != null) ? StoreServiceProvider.GetStoreService(storeName) : StoreServiceProvider.GetDefaultStoreService());
			this.m_ProductService = ((storeName != null) ? ProductServiceProvider.GetProductService(storeName) : ProductServiceProvider.GetDefaultProductService());
			this.m_PurchaseService = ((storeName != null) ? PurchaseServiceProvider.GetPurchaseService(storeName) : PurchaseServiceProvider.GetDefaultPurchaseService());
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00006EAD File Offset: 0x000050AD
		[NullableContext(1)]
		internal void SetTestInstances(IStoreService storeService, IProductService productService, IPurchaseService purchaseService)
		{
			this.m_StoreService = storeService;
			this.m_ProductService = productService;
			this.m_PurchaseService = purchaseService;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00006EC4 File Offset: 0x000050C4
		IAppleStoreExtendedService IStoreService.Apple
		{
			get
			{
				return this.m_StoreService.Apple;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00006ED1 File Offset: 0x000050D1
		IGooglePlayStoreExtendedService IStoreService.Google
		{
			get
			{
				return this.m_StoreService.Google;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00006EDE File Offset: 0x000050DE
		IAppleStoreExtendedProductService IProductService.Apple
		{
			get
			{
				return this.m_ProductService.Apple;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00006EEB File Offset: 0x000050EB
		IAppleStoreExtendedPurchaseService IPurchaseService.Apple
		{
			get
			{
				return this.m_PurchaseService.Apple;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00006EF8 File Offset: 0x000050F8
		IGooglePlayStoreExtendedPurchaseService IPurchaseService.Google
		{
			get
			{
				return this.m_PurchaseService.Google;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00006F05 File Offset: 0x00005105
		public IAppleStoreExtendedService AppleStoreExtendedService
		{
			get
			{
				return this.m_StoreService.Apple;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00006F12 File Offset: 0x00005112
		public IGooglePlayStoreExtendedService GooglePlayStoreExtendedService
		{
			get
			{
				return this.m_StoreService.Google;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00006F1F File Offset: 0x0000511F
		public IAppleStoreExtendedProductService AppleStoreExtendedProductService
		{
			get
			{
				return this.m_ProductService.Apple;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00006F2C File Offset: 0x0000512C
		public IAppleStoreExtendedPurchaseService AppleStoreExtendedPurchaseService
		{
			get
			{
				return this.m_PurchaseService.Apple;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00006F39 File Offset: 0x00005139
		public IGooglePlayStoreExtendedPurchaseService GooglePlayStoreExtendedPurchaseService
		{
			get
			{
				return this.m_PurchaseService.Google;
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060002C9 RID: 713 RVA: 0x00006F46 File Offset: 0x00005146
		// (remove) Token: 0x060002CA RID: 714 RVA: 0x00006F54 File Offset: 0x00005154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<StoreConnectionFailureDescription> OnStoreDisconnected
		{
			add
			{
				this.m_StoreService.OnStoreDisconnected += value;
			}
			remove
			{
				this.m_StoreService.OnStoreDisconnected -= value;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00006F62 File Offset: 0x00005162
		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
			this.m_PurchaseService.ProcessPendingOrdersOnPurchasesFetched(shouldProcess);
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060002CC RID: 716 RVA: 0x00006F70 File Offset: 0x00005170
		// (remove) Token: 0x060002CD RID: 717 RVA: 0x00006F7E File Offset: 0x0000517E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<PendingOrder> OnPurchasePending
		{
			add
			{
				this.m_PurchaseService.OnPurchasePending += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchasePending -= value;
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060002CE RID: 718 RVA: 0x00006F8C File Offset: 0x0000518C
		// (remove) Token: 0x060002CF RID: 719 RVA: 0x00006F9A File Offset: 0x0000519A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Order> OnPurchaseConfirmed
		{
			add
			{
				this.m_PurchaseService.OnPurchaseConfirmed += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchaseConfirmed -= value;
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060002D0 RID: 720 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (remove) Token: 0x060002D1 RID: 721 RVA: 0x00006FB6 File Offset: 0x000051B6
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<FailedOrder> OnPurchaseFailed
		{
			add
			{
				this.m_PurchaseService.OnPurchaseFailed += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchaseFailed -= value;
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060002D2 RID: 722 RVA: 0x00006FC4 File Offset: 0x000051C4
		// (remove) Token: 0x060002D3 RID: 723 RVA: 0x00006FD2 File Offset: 0x000051D2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<DeferredOrder> OnPurchaseDeferred
		{
			add
			{
				this.m_PurchaseService.OnPurchaseDeferred += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchaseDeferred -= value;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060002D4 RID: 724 RVA: 0x00006FE0 File Offset: 0x000051E0
		// (remove) Token: 0x060002D5 RID: 725 RVA: 0x00006FEE File Offset: 0x000051EE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Orders> OnPurchasesFetched
		{
			add
			{
				this.m_PurchaseService.OnPurchasesFetched += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchasesFetched -= value;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060002D6 RID: 726 RVA: 0x00006FFC File Offset: 0x000051FC
		// (remove) Token: 0x060002D7 RID: 727 RVA: 0x0000700A File Offset: 0x0000520A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
		{
			add
			{
				this.m_PurchaseService.OnPurchasesFetchFailed += value;
			}
			remove
			{
				this.m_PurchaseService.OnPurchasesFetchFailed -= value;
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060002D8 RID: 728 RVA: 0x00007018 File Offset: 0x00005218
		// (remove) Token: 0x060002D9 RID: 729 RVA: 0x00007026 File Offset: 0x00005226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Entitlement> OnCheckEntitlement
		{
			add
			{
				this.m_PurchaseService.OnCheckEntitlement += value;
			}
			remove
			{
				this.m_PurchaseService.OnCheckEntitlement -= value;
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060002DA RID: 730 RVA: 0x00007034 File Offset: 0x00005234
		// (remove) Token: 0x060002DB RID: 731 RVA: 0x00007042 File Offset: 0x00005242
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public event Action<List<Product>> OnProductsFetched
		{
			add
			{
				this.m_ProductService.OnProductsFetched += value;
			}
			remove
			{
				this.m_ProductService.OnProductsFetched -= value;
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060002DC RID: 732 RVA: 0x00007050 File Offset: 0x00005250
		// (remove) Token: 0x060002DD RID: 733 RVA: 0x0000705E File Offset: 0x0000525E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<ProductFetchFailed> OnProductsFetchFailed
		{
			add
			{
				this.m_ProductService.OnProductsFetchFailed += value;
			}
			remove
			{
				this.m_ProductService.OnProductsFetchFailed -= value;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000706C File Offset: 0x0000526C
		[NullableContext(1)]
		public Task Connect()
		{
			return this.m_StoreService.Connect();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00007079 File Offset: 0x00005279
		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy)
		{
			this.m_StoreService.SetStoreReconnectionRetryPolicyOnDisconnection(retryPolicy);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00007087 File Offset: 0x00005287
		[NullableContext(1)]
		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
			this.m_ProductService.FetchProductsWithNoRetries(productDefinitions);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00007095 File Offset: 0x00005295
		[NullableContext(1)]
		public void FetchProducts(List<ProductDefinition> productDefinitions, [Nullable(2)] IRetryPolicy retryPolicy = null)
		{
			this.m_ProductService.FetchProducts(productDefinitions, retryPolicy);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000070A4 File Offset: 0x000052A4
		[NullableContext(1)]
		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return this.m_ProductService.GetProducts();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000070B1 File Offset: 0x000052B1
		[NullableContext(1)]
		[return: Nullable(2)]
		public Product GetProductById(string productId)
		{
			return this.m_ProductService.GetProductById(productId);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000070BF File Offset: 0x000052BF
		[NullableContext(1)]
		public void PurchaseProduct(Product product)
		{
			this.m_PurchaseService.PurchaseProduct(product);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000070CD File Offset: 0x000052CD
		[NullableContext(1)]
		public void Purchase(ICart cart)
		{
			this.m_PurchaseService.Purchase(cart);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000070DB File Offset: 0x000052DB
		[NullableContext(1)]
		public void ConfirmPurchase(PendingOrder order)
		{
			this.m_PurchaseService.ConfirmPurchase(order);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000070E9 File Offset: 0x000052E9
		public void FetchPurchases()
		{
			this.m_PurchaseService.FetchPurchases();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000070F6 File Offset: 0x000052F6
		[NullableContext(1)]
		public void CheckEntitlement(Product product)
		{
			this.m_PurchaseService.CheckEntitlement(product);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00007104 File Offset: 0x00005304
		public void RestoreTransactions(Action<bool, string> callback)
		{
			this.m_PurchaseService.RestoreTransactions(callback);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00007112 File Offset: 0x00005312
		[NullableContext(1)]
		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return this.m_PurchaseService.GetPurchases();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00007120 File Offset: 0x00005320
		public void PurchaseProduct(string productId)
		{
			ReadOnlyObservableCollection<Product> products = this.m_ProductService.GetProducts();
			Product product2 = ((products != null) ? products.FirstOrDefault((Product product) => product.definition.id == productId) : null) ?? Product.CreateUnknownProduct(productId);
			this.m_PurchaseService.PurchaseProduct(product2);
		}

		// Token: 0x040000E1 RID: 225
		[Nullable(1)]
		private IStoreService m_StoreService;

		// Token: 0x040000E2 RID: 226
		[Nullable(1)]
		private IProductService m_ProductService;

		// Token: 0x040000E3 RID: 227
		[Nullable(1)]
		private IPurchaseService m_PurchaseService;
	}
}
