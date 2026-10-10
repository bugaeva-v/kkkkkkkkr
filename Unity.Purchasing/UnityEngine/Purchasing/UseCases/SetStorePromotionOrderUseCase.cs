using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000136 RID: 310
	[NullableContext(1)]
	[Nullable(0)]
	internal class SetStorePromotionOrderUseCase : ISetStorePromotionOrderUseCase
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x0000C022 File Offset: 0x0000A222
		[Preserve]
		internal SetStorePromotionOrderUseCase(INativeAppleStore nativeStore)
		{
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000C034 File Offset: 0x0000A234
		public void SetStorePromotionOrder(List<Product> products)
		{
			List<string> list = new List<string>();
			foreach (Product product in products)
			{
				if (product != null && !string.IsNullOrEmpty(product.definition.storeSpecificId))
				{
					list.Add(product.definition.storeSpecificId);
				}
			}
			this.m_NativeAppleStore.SetStorePromotionOrder(MiniJson.JsonEncode(list));
		}

		// Token: 0x0400028B RID: 651
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
