using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Services;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.UseCases;
using UnityEngine.Purchasing.Utilities;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003E RID: 62
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductServiceFactory : IProductServiceFactory
	{
		// Token: 0x0600016F RID: 367 RVA: 0x0000632A File Offset: 0x0000452A
		internal static ProductServiceFactory Instance()
		{
			ProductServiceFactory result;
			if ((result = ProductServiceFactory.s_Instance) == null)
			{
				result = (ProductServiceFactory.s_Instance = new ProductServiceFactory());
			}
			return result;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006340 File Offset: 0x00004540
		private ProductServiceFactory()
		{
			this.m_ProductServiceInstantiationByName.Add("AppleAppStore", new Func<IStoreWrapper, IProductService>(ProductServiceFactory.CreateAppleProductService));
			this.m_ProductServiceInstantiationByName.Add("MacAppStore", new Func<IStoreWrapper, IProductService>(ProductServiceFactory.CreateAppleProductService));
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00006398 File Offset: 0x00004598
		public void RegisterNewService(string name, Func<IProductService> createFunction)
		{
			ProductServiceFactory.<>c__DisplayClass4_0 CS$<>8__locals1 = new ProductServiceFactory.<>c__DisplayClass4_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_ProductServiceInstantiationByName.Add(name, new Func<IStoreWrapper, IProductService>(CS$<>8__locals1.<RegisterNewService>g__CreateCustomProductServiceDiscardParams|0));
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000063CC File Offset: 0x000045CC
		public void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction)
		{
			ProductServiceFactory.<>c__DisplayClass5_0 CS$<>8__locals1 = new ProductServiceFactory.<>c__DisplayClass5_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_ProductServiceInstantiationByName.Add(name, new Func<IStoreWrapper, IProductService>(CS$<>8__locals1.<RegisterNewExtendedService>g__CreateCustomProductServiceDiscardParams|0));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006400 File Offset: 0x00004600
		public IProductService Create(IStoreWrapper store)
		{
			object obj;
			if (!this.m_ProductServiceInstantiationByName.ContainsKey(store.name))
			{
				IProductService productService = ProductServiceFactory.CreateGenericProductService(store);
				obj = productService;
			}
			else
			{
				Func<IStoreWrapper, IProductService> func = this.m_ProductServiceInstantiationByName[store.name];
				obj = ((func != null) ? func(store) : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				throw new InvalidOperationException();
			}
			return obj2;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006454 File Offset: 0x00004654
		private static ProductService CreateGenericProductService(IStoreWrapper storeWrapper)
		{
			IDependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			ProductServiceFactory.AddProductServiceDependencies(storeWrapper, dependencyInjectionService);
			return dependencyInjectionService.GetInstance<ProductService>();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006474 File Offset: 0x00004674
		private static void AddProductServiceDependencies(IStoreWrapper store, IDependencyInjectionService di)
		{
			di.AddInstance(new RetryService(UnityUtilContainer.Instance()));
			di.AddInstance(store.instance);
			di.AddInstance(store);
			di.AddService<FetchProductsUseCase>();
			di.AddService<ProductService>();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000064A8 File Offset: 0x000046A8
		private static AppleStoreExtendedProductService CreateAppleProductService(IStoreWrapper store)
		{
			AppleStoreImpl appleStoreImpl = store.instance as AppleStoreImpl;
			INativeAppleStore nativeAppleStore = (appleStoreImpl != null) ? appleStoreImpl.GetNativeStore() : null;
			if (nativeAppleStore == null)
			{
				throw new Exception("AppleStoreImpl's INativeAppleStore has not been set");
			}
			IDependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			dependencyInjectionService.AddInstance(nativeAppleStore);
			dependencyInjectionService.AddInstance(store);
			dependencyInjectionService.AddService<FetchStorePromotionOrderUseCase>();
			dependencyInjectionService.AddService<FetchStorePromotionVisibilityUseCase>();
			dependencyInjectionService.AddInstance(StoreFactory.Instance().TelemetryDiagnosticsInstanceWrapper);
			dependencyInjectionService.AddService<TelemetryDiagnostics>();
			dependencyInjectionService.AddService<AppleFetchProductsService>();
			dependencyInjectionService.AddService<GetIntroductoryPriceDictionaryUseCase>();
			dependencyInjectionService.AddService<GetProductDetailsUseCase>();
			dependencyInjectionService.AddService<SetStorePromotionOrderUseCase>();
			dependencyInjectionService.AddService<SetStorePromotionVisibilityUseCase>();
			ProductServiceFactory.AddProductServiceDependencies(store, dependencyInjectionService);
			dependencyInjectionService.AddService<AppleStoreExtendedProductService>();
			return dependencyInjectionService.GetInstance<AppleStoreExtendedProductService>();
		}

		// Token: 0x04000090 RID: 144
		[Nullable(2)]
		private static ProductServiceFactory s_Instance;

		// Token: 0x04000091 RID: 145
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1,
			1
		})]
		private readonly Dictionary<string, Func<IStoreWrapper, IProductService>> m_ProductServiceInstantiationByName = new Dictionary<string, Func<IStoreWrapper, IProductService>>();
	}
}
