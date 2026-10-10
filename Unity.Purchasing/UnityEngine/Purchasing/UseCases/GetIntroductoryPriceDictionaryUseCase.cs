using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000134 RID: 308
	[NullableContext(1)]
	[Nullable(0)]
	internal class GetIntroductoryPriceDictionaryUseCase : IGetIntroductoryPriceDictionaryUseCase
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		[Preserve]
		internal GetIntroductoryPriceDictionaryUseCase(IAppleFetchProductsService fetchProductsService)
		{
			this.m_FetchProductsService = fetchProductsService;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000BFEF File Offset: 0x0000A1EF
		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return JSONSerializer.DeserializeSubscriptionDescriptions(this.m_FetchProductsService.LastRequestProductsJson);
		}

		// Token: 0x04000289 RID: 649
		private readonly IAppleFetchProductsService m_FetchProductsService;
	}
}
