using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Services;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.UseCases;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000040 RID: 64
	[NullableContext(1)]
	[Nullable(0)]
	internal class PurchaseServiceFactory : IPurchaseServiceFactory
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00006553 File Offset: 0x00004753
		internal static PurchaseServiceFactory Instance()
		{
			PurchaseServiceFactory result;
			if ((result = PurchaseServiceFactory.s_Instance) == null)
			{
				result = (PurchaseServiceFactory.s_Instance = new PurchaseServiceFactory());
			}
			return result;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000656C File Offset: 0x0000476C
		private PurchaseServiceFactory()
		{
			this.m_PurchaseServiceInstantiationByName.Add("GooglePlay", new Func<IStoreWrapper, IPurchaseService>(PurchaseServiceFactory.CreateGooglePurchaseService));
			this.m_PurchaseServiceInstantiationByName.Add("AppleAppStore", new Func<IStoreWrapper, IPurchaseService>(PurchaseServiceFactory.CreateApplePurchaseService));
			this.m_PurchaseServiceInstantiationByName.Add("MacAppStore", new Func<IStoreWrapper, IPurchaseService>(PurchaseServiceFactory.CreateApplePurchaseService));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000065E0 File Offset: 0x000047E0
		public void RegisterNewService(string name, Func<IPurchaseService> createFunction)
		{
			PurchaseServiceFactory.<>c__DisplayClass4_0 CS$<>8__locals1 = new PurchaseServiceFactory.<>c__DisplayClass4_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_PurchaseServiceInstantiationByName.Add(name, new Func<IStoreWrapper, IPurchaseService>(CS$<>8__locals1.<RegisterNewService>g__CreateCustomProductServiceDiscardParams|0));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006614 File Offset: 0x00004814
		public void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction)
		{
			PurchaseServiceFactory.<>c__DisplayClass5_0 CS$<>8__locals1 = new PurchaseServiceFactory.<>c__DisplayClass5_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_PurchaseServiceInstantiationByName.Add(name, new Func<IStoreWrapper, IPurchaseService>(CS$<>8__locals1.<RegisterNewExtendedService>g__CreateCustomProductServiceDiscardParams|0));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006648 File Offset: 0x00004848
		public IPurchaseService Create(IStoreWrapper store)
		{
			object obj;
			if (!this.m_PurchaseServiceInstantiationByName.ContainsKey(store.name))
			{
				IPurchaseService purchaseService = PurchaseServiceFactory.CreateDefaultPurchaseService(store);
				obj = purchaseService;
			}
			else
			{
				Func<IStoreWrapper, IPurchaseService> func = this.m_PurchaseServiceInstantiationByName[store.name];
				obj = ((func != null) ? func(store) : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				throw new InvalidOperationException();
			}
			return obj2;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000669C File Offset: 0x0000489C
		private static PurchaseService CreateDefaultPurchaseService(IStoreWrapper store)
		{
			IDependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			PurchaseServiceFactory.AddPurchaseServiceDependencies(store, dependencyInjectionService);
			dependencyInjectionService.AddService<PurchaseService>();
			return dependencyInjectionService.GetInstance<PurchaseService>();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000066C4 File Offset: 0x000048C4
		private static void AddPurchaseServiceDependencies(IStoreWrapper store, IDependencyInjectionService di)
		{
			di.AddInstance(store);
			di.AddInstance(store.instance);
			di.AddService<FetchPurchasesUseCase>();
			di.AddInstance(PurchaseUseCaseFactory.Create(store.instance, store.instance.ProductCache));
			di.AddService<ConfirmOrderUseCase>();
			di.AddService<CheckEntitlementUseCase>();
			di.AddService<OnEntitlementRevokedUseCase>();
			di.AddService<AnalyticsClient>();
			di.AddService<AppleRefreshAppReceiptUseCase>();
			di.AddInstance(Debug.unityLogger);
			PurchaseServiceFactory.AddAnalyticsDependencies(di);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006735 File Offset: 0x00004935
		private static void AddAnalyticsDependencies(IDependencyInjectionService di)
		{
			di.AddService<AnalyticsServiceWrapper>();
			di.AddService<CoreAnalyticsAdapter>();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006744 File Offset: 0x00004944
		private static GooglePlayStoreExtendedPurchaseService CreateGooglePurchaseService(IStoreWrapper store)
		{
			IDependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			dependencyInjectionService.AddService<GooglePlayRestoreTransactionUseCase>();
			dependencyInjectionService.AddInstance(StoreFactory.Instance().TelemetryDiagnosticsInstanceWrapper);
			dependencyInjectionService.AddService<TelemetryDiagnostics>();
			PurchaseServiceFactory.AddPurchaseServiceDependencies(store, dependencyInjectionService);
			dependencyInjectionService.AddService<GooglePlayStoreExtendedPurchaseService>();
			return dependencyInjectionService.GetInstance<GooglePlayStoreExtendedPurchaseService>();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006788 File Offset: 0x00004988
		private static AppleStoreExtendedPurchaseService CreateApplePurchaseService(IStoreWrapper store)
		{
			AppleStoreImpl appleStoreImpl = store.instance as AppleStoreImpl;
			INativeAppleStore nativeAppleStore = (appleStoreImpl != null) ? appleStoreImpl.GetNativeStore() : null;
			if (nativeAppleStore == null)
			{
				throw new Exception("AppleStoreImpl's INativeAppleStore has not been set");
			}
			IDependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			dependencyInjectionService.AddInstance(nativeAppleStore);
			dependencyInjectionService.AddService<AppReceiptUseCase>();
			dependencyInjectionService.AddService<ContinuePromotionalPurchasesUseCase>();
			dependencyInjectionService.AddService<PresentCodeRedemptionSheetUseCase>();
			dependencyInjectionService.AddService<AppleRestoreTransactionsUseCase>();
			dependencyInjectionService.AddService<SetPromotionalPurchaseInterceptorCallbackUseCase>();
			dependencyInjectionService.AddService<SimulateAskToBuyUseCase>();
			PurchaseServiceFactory.AddPurchaseServiceDependencies(store, dependencyInjectionService);
			dependencyInjectionService.AddService<AppleStoreExtendedPurchaseService>();
			return dependencyInjectionService.GetInstance<AppleStoreExtendedPurchaseService>();
		}

		// Token: 0x04000092 RID: 146
		[Nullable(2)]
		private static PurchaseServiceFactory s_Instance;

		// Token: 0x04000093 RID: 147
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1,
			1
		})]
		private readonly Dictionary<string, Func<IStoreWrapper, IPurchaseService>> m_PurchaseServiceInstantiationByName = new Dictionary<string, Func<IStoreWrapper, IPurchaseService>>();
	}
}
