using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006B RID: 107
	[NullableContext(1)]
	[Nullable(0)]
	internal class PurchaseServiceContainer
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00005A62 File Offset: 0x00003C62
		internal static PurchaseServiceContainer Instance()
		{
			PurchaseServiceContainer result;
			if ((result = PurchaseServiceContainer.s_Instance) == null)
			{
				result = (PurchaseServiceContainer.s_Instance = new PurchaseServiceContainer());
			}
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005A78 File Offset: 0x00003C78
		[return: Nullable(2)]
		internal IPurchaseService FindService(string storeName)
		{
			if (!this.m_InstantiatedServices.ContainsKey(storeName))
			{
				return null;
			}
			return this.m_InstantiatedServices[storeName];
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005A96 File Offset: 0x00003C96
		internal void SetService(string storeName, IPurchaseService service)
		{
			if (this.m_InstantiatedServices.ContainsKey(storeName))
			{
				throw new ServiceCreationException("PurchaseService for store " + storeName + " already exists. Cannot create a new instance.");
			}
			this.m_InstantiatedServices.Add(storeName, service);
		}

		// Token: 0x0400009D RID: 157
		[Nullable(2)]
		private static PurchaseServiceContainer s_Instance;

		// Token: 0x0400009E RID: 158
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly Dictionary<string, IPurchaseService> m_InstantiatedServices = new Dictionary<string, IPurchaseService>();
	}
}
