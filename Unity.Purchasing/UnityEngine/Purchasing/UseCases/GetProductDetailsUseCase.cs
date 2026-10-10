using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000135 RID: 309
	[NullableContext(1)]
	[Nullable(0)]
	internal class GetProductDetailsUseCase : IGetProductDetailsUseCase
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x0000C001 File Offset: 0x0000A201
		[Preserve]
		internal GetProductDetailsUseCase(IAppleFetchProductsService fetchProductsService)
		{
			this.m_FetchProductsService = fetchProductsService;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000C010 File Offset: 0x0000A210
		public Dictionary<string, string> GetProductDetails()
		{
			return JSONSerializer.DeserializeProductDetails(this.m_FetchProductsService.LastRequestProductsJson);
		}

		// Token: 0x0400028A RID: 650
		private readonly IAppleFetchProductsService m_FetchProductsService;
	}
}
