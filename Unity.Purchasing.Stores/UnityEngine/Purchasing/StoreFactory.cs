using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Purchasing.Extension;
using Stores.Android.GooglePlay.AAR.Interfaces;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.Utilities;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000041 RID: 65
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreFactory : IStoreFactory
	{
		// Token: 0x06000182 RID: 386 RVA: 0x000067FF File Offset: 0x000049FF
		internal StoreFactory(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
			this.m_Util = util;
			this.m_Logger = logger;
			this.m_NativeStoreProvider = nativeStoreProvider;
			this.TelemetryDiagnosticsInstanceWrapper = telemetryDiagnosticsInstanceWrapper;
			this.TelemetryMetricsInstanceWrapper = telemetryMetricsInstanceWrapper;
			this.RegisterBaseStores();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006840 File Offset: 0x00004A40
		internal static StoreFactory Instance()
		{
			if (StoreFactory.s_Instance == null)
			{
				ILogger unityLogger = Debug.unityLogger;
				UnityUtil util = UnityUtilContainer.Instance();
				NativeStoreProvider nativeStoreProvider = new NativeStoreProvider();
				StoreFactory.s_Instance = new StoreFactory(util, unityLogger, nativeStoreProvider, new TelemetryDiagnosticsInstanceWrapper(unityLogger, util), new TelemetryMetricsInstanceWrapper(unityLogger, util));
			}
			return StoreFactory.s_Instance;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006888 File Offset: 0x00004A88
		private void RegisterBaseStores()
		{
			this.RegisterStore("AppleAppStore", new Func<IStoreWrapper>(this.InstantiateAppleStore));
			this.RegisterStore("fake", new Func<IStoreWrapper>(this.InstantiateFakeStore));
			this.RegisterStore("MacAppStore", new Func<IStoreWrapper>(this.InstantiateMacAppStore));
			this.RegisterStore("GooglePlay", new Func<IStoreWrapper>(this.InstantiateGooglePlayStore));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000068F1 File Offset: 0x00004AF1
		public void RegisterStore(string storeName, Func<IStoreWrapper> function)
		{
			this.m_StoreInstantiationByName[storeName] = function;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006900 File Offset: 0x00004B00
		public IStoreWrapper CreateStore(string storeName)
		{
			IStoreWrapper result;
			try
			{
				result = this.m_StoreInstantiationByName[storeName]();
			}
			catch (Exception innerException)
			{
				throw new StoreException("An error has occured when attempting to create the store: " + storeName + ".", innerException);
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000694C File Offset: 0x00004B4C
		private IDependencyInjectionService CreateBaseDiService()
		{
			DependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			this.AddUtilsDependencies(dependencyInjectionService);
			this.AddTelemetryDependencies(dependencyInjectionService);
			return dependencyInjectionService;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000696E File Offset: 0x00004B6E
		private void AddUtilsDependencies(IDependencyInjectionService di)
		{
			di.AddInstance(this.m_Util);
			di.AddInstance(this.m_Logger);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006988 File Offset: 0x00004B88
		private void AddTelemetryDependencies(IDependencyInjectionService di)
		{
			di.AddInstance(this.TelemetryMetricsInstanceWrapper);
			di.AddInstance(this.TelemetryDiagnosticsInstanceWrapper);
			di.AddService<TelemetryDiagnostics>();
			di.AddService<TelemetryMetricsService>();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000069AE File Offset: 0x00004BAE
		private IStoreWrapper InstantiateAppleStore()
		{
			return this.InstantiateAppleAppStore("AppleAppStore", "Apple App Store");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000069C0 File Offset: 0x00004BC0
		private IStoreWrapper InstantiateMacAppStore()
		{
			return this.InstantiateAppleAppStore("MacAppStore", "Mac App Store");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000069D4 File Offset: 0x00004BD4
		private IStoreWrapper InstantiateAppleAppStore(string storeName, string storeDisplayName)
		{
			IDependencyInjectionService dependencyInjectionService = this.CreateBaseDiService();
			dependencyInjectionService.AddInstance(new AppleAppStoreCartValidator(storeDisplayName));
			this.AddMetricizedAppleStoreDependencies(dependencyInjectionService);
			this.CreateAndAssignNativeAppleStore(dependencyInjectionService.GetInstance<AppleStoreImpl>());
			return StoreFactory.CreateStoreWrapper(storeName, dependencyInjectionService);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006A0E File Offset: 0x00004C0E
		private void AddMetricizedAppleStoreDependencies(IDependencyInjectionService di)
		{
			di.AddService<AppleFetchProductsService>();
			di.AddService<MetricizedAppleStoreImpl>();
			di.AddInstance(StoreFactory.BuildTransactionLog());
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006A27 File Offset: 0x00004C27
		private static ITransactionLog BuildTransactionLog()
		{
			return new TransactionLog(Application.persistentDataPath);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006A34 File Offset: 0x00004C34
		private void CreateAndAssignNativeAppleStore(AppleStoreImpl store)
		{
			INativeAppleStore storekit = this.m_NativeStoreProvider.GetStorekit(store);
			store.SetNativeStore(storekit);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00006A58 File Offset: 0x00004C58
		private IStoreWrapper InstantiateFakeStore()
		{
			FakeStoreUIMode useFakeStoreUIMode = FakeStoreUIMode.StandardUser;
			FakeStore instance = this.CreateFakeStoreByUIMode(useFakeStoreUIMode);
			return new StoreWrapper("fake", instance);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006A7C File Offset: 0x00004C7C
		private FakeStore CreateFakeStoreByUIMode(FakeStoreUIMode useFakeStoreUIMode)
		{
			FakeStoreCartValidator cartValidator = new FakeStoreCartValidator();
			if (useFakeStoreUIMode != FakeStoreUIMode.Default)
			{
				return new UIFakeStore(cartValidator, this.m_Logger)
				{
					UIMode = useFakeStoreUIMode
				};
			}
			return new FakeStore(cartValidator, this.m_Logger);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006AB4 File Offset: 0x00004CB4
		private IStoreWrapper InstantiateGooglePlayStore()
		{
			IDependencyInjectionService di = this.CreateBaseDiService();
			StoreFactory.AddGooglePlayStoreServices(di);
			this.AddGooglePlayStoreServiceAars(di);
			this.LinkGooglePlayStoreDependencies(di);
			return StoreFactory.CreateStoreWrapper("GooglePlay", di);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006AE7 File Offset: 0x00004CE7
		private static IStoreWrapper CreateStoreWrapper(string storeName, IDependencyInjectionService di)
		{
			return new StoreWrapper(storeName, di.GetInstance<InternalStore>());
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006AF5 File Offset: 0x00004CF5
		private void LinkGooglePlayStoreDependencies(IDependencyInjectionService di)
		{
			di.GetInstance<GooglePurchasesUpdatedHandler>().SubscribeToPurchasesUpdatedEvent(di.GetInstance<GooglePurchasesUpdatedListener>());
			StoreFactory.LinkProductCache(di);
			this.m_Util.AddPauseListener(new Action<bool>(di.GetInstance<IGooglePlayStore>().OnPause));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006B2C File Offset: 0x00004D2C
		private static void LinkProductCache(IDependencyInjectionService di)
		{
			IProductCache productCache = di.GetInstance<GooglePlayStore>().ProductCache;
			di.GetInstance<IGooglePlayStoreFetchPurchasesService>().SetProductCache(productCache);
			di.GetInstance<IGooglePlayStoreFinishTransactionService>().SetProductCache(productCache);
			di.GetInstance<IGooglePurchaseService>().SetProductCache(productCache);
			di.GetInstance<IGooglePurchasesUpdatedHandler>().SetProductCache(productCache);
			di.GetInstance<GooglePlayPurchaseCallback>().SetProductCache(productCache);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006B84 File Offset: 0x00004D84
		private static void AddGooglePlayStoreServices(IDependencyInjectionService di)
		{
			di.AddService<ProductDetailsConverter>();
			di.AddService<GooglePurchaseConverter>();
			di.AddService<GooglePlayPurchaseCallback>();
			di.AddService<GooglePlayStorePurchaseService>();
			di.AddService<GooglePlayStoreFinishTransactionService>();
			di.AddService<GooglePlayStoreFetchPurchasesService>();
			di.AddService<TelemetryMetricsInstanceWrapper>();
			di.AddService<GooglePlayStoreFetchProductsService>();
			di.AddService<GooglePlayStoreCheckEntitlementService>();
			di.AddService<GooglePlayStoreChangeSubscriptionService>();
			di.AddService<GooglePlayCartValidator>();
			di.AddService<GooglePlayStore>();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006BDC File Offset: 0x00004DDC
		private void AddGooglePlayStoreServiceAars(IDependencyInjectionService di)
		{
			di.AddService<GoogleLastKnownProductService>();
			di.AddService<GooglePurchaseStateEnumProvider>();
			di.AddService<GooglePurchaseBuilder>();
			di.AddService<GooglePurchasesUpdatedListener>();
			di.AddService<GoogleBillingClient>();
			di.AddService<GoogleCachedQueryProductDetailsService>();
			di.AddService<QueryProductDetailsService>();
			di.AddService<GooglePurchaseService>();
			di.AddService<GoogleQueryPurchasesUseCase>();
			di.AddService<GoogleFinishTransactionUseCase>();
			di.AddService<GooglePlayCheckEntitlementUseCase>();
			di.AddService<BillingClientStateListener>();
			di.AddService<GooglePlayStoreConnectionService>();
			di.AddService<GooglePurchasesUpdatedHandler>();
			di.AddService<MetricizedGooglePlayStoreService>();
		}

		// Token: 0x04000094 RID: 148
		[Nullable(2)]
		private static StoreFactory s_Instance;

		// Token: 0x04000095 RID: 149
		private readonly IUtil m_Util;

		// Token: 0x04000096 RID: 150
		private readonly ILogger m_Logger;

		// Token: 0x04000097 RID: 151
		private readonly INativeStoreProvider m_NativeStoreProvider;

		// Token: 0x04000098 RID: 152
		public readonly ITelemetryMetricsInstanceWrapper TelemetryMetricsInstanceWrapper;

		// Token: 0x04000099 RID: 153
		public readonly ITelemetryDiagnosticsInstanceWrapper TelemetryDiagnosticsInstanceWrapper;

		// Token: 0x0400009A RID: 154
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})]
		private readonly Dictionary<string, Func<IStoreWrapper>> m_StoreInstantiationByName = new Dictionary<string, Func<IStoreWrapper>>();
	}
}
