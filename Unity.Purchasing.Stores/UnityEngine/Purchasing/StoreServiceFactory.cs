using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Services;
using UnityEngine.Purchasing.UseCases;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Purchasing.Utilities;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000044 RID: 68
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreServiceFactory : IStoreServiceFactory
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00006C65 File Offset: 0x00004E65
		internal static StoreServiceFactory Instance()
		{
			StoreServiceFactory result;
			if ((result = StoreServiceFactory.s_Instance) == null)
			{
				result = (StoreServiceFactory.s_Instance = new StoreServiceFactory());
			}
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006C7C File Offset: 0x00004E7C
		private StoreServiceFactory()
		{
			this.m_StoreServiceInstantiationByName.Add("GooglePlay", new Func<IRetryPolicy, IStoreWrapper, IStoreService>(StoreServiceFactory.CreateGoogleStoreService));
			this.m_StoreServiceInstantiationByName.Add("AppleAppStore", new Func<IRetryPolicy, IStoreWrapper, IStoreService>(StoreServiceFactory.CreateAppleStoreService));
			this.m_StoreServiceInstantiationByName.Add("MacAppStore", new Func<IRetryPolicy, IStoreWrapper, IStoreService>(StoreServiceFactory.CreateAppleStoreService));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public void RegisterNewService(string name, Func<IStoreService> createFunction)
		{
			StoreServiceFactory.<>c__DisplayClass4_0 CS$<>8__locals1 = new StoreServiceFactory.<>c__DisplayClass4_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_StoreServiceInstantiationByName.Add(name, new Func<IRetryPolicy, IStoreWrapper, IStoreService>(CS$<>8__locals1.<RegisterNewService>g__CreateCustomStoreServiceDiscardParams|0));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00006D24 File Offset: 0x00004F24
		public void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction)
		{
			StoreServiceFactory.<>c__DisplayClass5_0 CS$<>8__locals1 = new StoreServiceFactory.<>c__DisplayClass5_0();
			CS$<>8__locals1.createFunction = createFunction;
			this.m_StoreServiceInstantiationByName.Add(name, new Func<IRetryPolicy, IStoreWrapper, IStoreService>(CS$<>8__locals1.<RegisterNewExtendedService>g__CreateCustomStoreServiceDiscardParams|0));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006D58 File Offset: 0x00004F58
		public IStoreService Create(IStoreWrapper store, [Nullable(2)] IRetryPolicy retryPolicy)
		{
			object obj;
			if (!this.m_StoreServiceInstantiationByName.ContainsKey(store.name))
			{
				if (retryPolicy == null)
				{
					throw new ArgumentNullException("retryPolicy");
				}
				IStoreService storeService = StoreServiceFactory.CreateGenericStoreService(retryPolicy, store);
				obj = storeService;
			}
			else
			{
				Func<IRetryPolicy, IStoreWrapper, IStoreService> func = this.m_StoreServiceInstantiationByName[store.name];
				if (func == null)
				{
					obj = null;
				}
				else
				{
					if (retryPolicy == null)
					{
						throw new ArgumentNullException("retryPolicy");
					}
					obj = func(retryPolicy, store);
				}
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				throw new InvalidOperationException();
			}
			return obj2;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006DCA File Offset: 0x00004FCA
		private static StoreService CreateGenericStoreService(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper)
		{
			DependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			StoreServiceFactory.AddStoreServiceDependencies(dependencyInjectionService, retryPolicy, storeWrapper);
			return ((IDependencyInjectionService)dependencyInjectionService).GetInstance<StoreService>();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006DE0 File Offset: 0x00004FE0
		private static void AddStoreServiceDependencies(IDependencyInjectionService di, [Nullable(2)] IRetryPolicy retryPolicy, IStoreWrapper store)
		{
			di.AddInstance(UnityUtilContainer.Instance());
			di.AddService<RetryService>();
			IStoreConnectUseCase instance = new StoreConnectUseCaseFactory().CreateUseCase(store, di.GetInstance<IRetryService>());
			di.AddInstance(instance);
			if (retryPolicy != null)
			{
				di.AddInstance(retryPolicy);
			}
			di.AddService<StoreService>();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006E28 File Offset: 0x00005028
		private static GooglePlayStoreExtendedService CreateGoogleStoreService([Nullable(2)] IRetryPolicy retryPolicy, IStoreWrapper store)
		{
			DependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			((IDependencyInjectionService)dependencyInjectionService).AddInstance(Debug.unityLogger);
			((IDependencyInjectionService)dependencyInjectionService).AddInstance(((GooglePlayStore)store.instance).m_BillingClient);
			((IDependencyInjectionService)dependencyInjectionService).AddService<GooglePlayStoreSetObfuscatedIdUseCase>();
			((IDependencyInjectionService)dependencyInjectionService).AddService<GoogleQueryPurchasesUseCase>();
			((IDependencyInjectionService)dependencyInjectionService).AddService<GooglePlayStoreConnectionUseCase>();
			StoreServiceFactory.AddStoreServiceDependencies(dependencyInjectionService, retryPolicy, store);
			((IDependencyInjectionService)dependencyInjectionService).AddService<GooglePlayStoreExtendedService>();
			return ((IDependencyInjectionService)dependencyInjectionService).GetInstance<GooglePlayStoreExtendedService>();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006E80 File Offset: 0x00005080
		private static AppleStoreExtendedService CreateAppleStoreService([Nullable(2)] IRetryPolicy retryPolicy, IStoreWrapper store)
		{
			AppleStoreImpl appleStoreImpl = store.instance as AppleStoreImpl;
			INativeAppleStore nativeAppleStore = (appleStoreImpl != null) ? appleStoreImpl.GetNativeStore() : null;
			if (nativeAppleStore == null)
			{
				throw new Exception("AppleStoreImpl's INativeAppleStore has not been set");
			}
			DependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			((IDependencyInjectionService)dependencyInjectionService).AddInstance(nativeAppleStore);
			((IDependencyInjectionService)dependencyInjectionService).AddInstance((AppleStoreImpl)store.instance);
			((IDependencyInjectionService)dependencyInjectionService).AddService<CanMakePaymentsUseCase>();
			((IDependencyInjectionService)dependencyInjectionService).AddService<SetAppAccountTokenUseCase>();
			((IDependencyInjectionService)dependencyInjectionService).AddService<ClearAppleTransactionLogsUseCase>();
			StoreServiceFactory.AddStoreServiceDependencies(dependencyInjectionService, retryPolicy, store);
			((IDependencyInjectionService)dependencyInjectionService).AddService<AppleStoreExtendedService>();
			return ((IDependencyInjectionService)dependencyInjectionService).GetInstance<AppleStoreExtendedService>();
		}

		// Token: 0x0400009B RID: 155
		[Nullable(2)]
		private static StoreServiceFactory s_Instance;

		// Token: 0x0400009C RID: 156
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1,
			1,
			1
		})]
		private readonly Dictionary<string, Func<IRetryPolicy, IStoreWrapper, IStoreService>> m_StoreServiceInstantiationByName = new Dictionary<string, Func<IRetryPolicy, IStoreWrapper, IStoreService>>();
	}
}
