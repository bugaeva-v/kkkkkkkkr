using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000143 RID: 323
	[NullableContext(1)]
	internal interface IGetIntroductoryPriceDictionaryUseCase
	{
		// Token: 0x060005A8 RID: 1448
		Dictionary<string, string> GetIntroductoryPriceDictionary();
	}
}
