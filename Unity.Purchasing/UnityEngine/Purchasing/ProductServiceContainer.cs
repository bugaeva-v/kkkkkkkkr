using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000019 RID: 25
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductServiceContainer
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000283F File Offset: 0x00000A3F
		internal static ProductServiceContainer Instance()
		{
			ProductServiceContainer result;
			if ((result = ProductServiceContainer.s_Instance) == null)
			{
				result = (ProductServiceContainer.s_Instance = new ProductServiceContainer());
			}
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002855 File Offset: 0x00000A55
		[return: Nullable(2)]
		internal IProductService FindService(string storeName)
		{
			if (!this.m_InstantiatedServices.ContainsKey(storeName))
			{
				return null;
			}
			return this.m_InstantiatedServices[storeName];
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002873 File Offset: 0x00000A73
		internal void SetService(string storeName, IProductService service)
		{
			if (this.m_InstantiatedServices.ContainsKey(storeName))
			{
				throw new ServiceCreationException("ProductService for store " + storeName + " already exists. Cannot create a new instance.");
			}
			this.m_InstantiatedServices.Add(storeName, service);
		}

		// Token: 0x0400001A RID: 26
		[Nullable(2)]
		private static ProductServiceContainer s_Instance;

		// Token: 0x0400001B RID: 27
		private readonly Dictionary<string, IProductService> m_InstantiatedServices = new Dictionary<string, IProductService>();
	}
}
