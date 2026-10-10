using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009C RID: 156
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreManager : IStoreManager, IStoreManagerFactoryInjectionPoint
	{
		// Token: 0x06000291 RID: 657 RVA: 0x000068E0 File Offset: 0x00004AE0
		[NullableContext(2)]
		public void SetStoreFactory(IStoreFactory storeFactory)
		{
			this.m_StoreFactory = storeFactory;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000068E9 File Offset: 0x00004AE9
		public static StoreManager Instance()
		{
			StoreManager result;
			if ((result = StoreManager.s_Instance) == null)
			{
				result = (StoreManager.s_Instance = new StoreManager());
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00006900 File Offset: 0x00004B00
		public IStoreWrapper GetStore(string name)
		{
			if (!this.m_InstantiatedStores.ContainsKey(name))
			{
				if (this.m_StoreFactory == null)
				{
					throw new StoreException("Store Factory not present to create any new stores");
				}
				IStoreWrapper value = this.m_StoreFactory.CreateStore(name);
				this.m_InstantiatedStores[name] = value;
			}
			return this.m_InstantiatedStores[name];
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00006954 File Offset: 0x00004B54
		public IStoreWrapper GetDefaultStore()
		{
			return this.GetStore(DefaultStoreHelper.GetDefaultStoreName());
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00006964 File Offset: 0x00004B64
		public void AddNewCustomStore(IStoreWrapper customStore)
		{
			StoreManager.<>c__DisplayClass7_0 CS$<>8__locals1 = new StoreManager.<>c__DisplayClass7_0();
			CS$<>8__locals1.customStore = customStore;
			if (this.m_StoreFactory == null)
			{
				throw new StoreException("Store Factory not present to create any new stores");
			}
			this.m_StoreFactory.RegisterStore(CS$<>8__locals1.customStore.name, new Func<IStoreWrapper>(CS$<>8__locals1.<AddNewCustomStore>g__InstantiateCustomStore|0));
		}

		// Token: 0x040000CE RID: 206
		[Nullable(2)]
		private static StoreManager s_Instance;

		// Token: 0x040000CF RID: 207
		[Nullable(2)]
		private IStoreFactory m_StoreFactory;

		// Token: 0x040000D0 RID: 208
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly Dictionary<string, IStoreWrapper> m_InstantiatedStores = new Dictionary<string, IStoreWrapper>();
	}
}
