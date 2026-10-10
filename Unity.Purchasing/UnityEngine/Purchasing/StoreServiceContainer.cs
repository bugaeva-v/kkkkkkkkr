using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200009E RID: 158
	[NullableContext(1)]
	[Nullable(0)]
	internal class StoreServiceContainer
	{
		// Token: 0x0600029E RID: 670 RVA: 0x00006A25 File Offset: 0x00004C25
		internal static StoreServiceContainer Instance()
		{
			StoreServiceContainer result;
			if ((result = StoreServiceContainer.s_Instance) == null)
			{
				result = (StoreServiceContainer.s_Instance = new StoreServiceContainer());
			}
			return result;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006A3B File Offset: 0x00004C3B
		[return: Nullable(2)]
		internal IStoreService FindService(string storeName)
		{
			if (this.m_InstantiatedServices.ContainsKey(storeName))
			{
				return this.m_InstantiatedServices[storeName];
			}
			return null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00006A59 File Offset: 0x00004C59
		internal void SetService(string storeName, IStoreService service)
		{
			if (this.m_InstantiatedServices.ContainsKey(storeName))
			{
				throw new ServiceCreationException("StoreService for store " + storeName + " already exists. Cannot create a new instance.");
			}
			this.m_InstantiatedServices.Add(storeName, service);
		}

		// Token: 0x040000D2 RID: 210
		[Nullable(2)]
		private static StoreServiceContainer s_Instance;

		// Token: 0x040000D3 RID: 211
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly Dictionary<string, IStoreService> m_InstantiatedServices = new Dictionary<string, IStoreService>();
	}
}
