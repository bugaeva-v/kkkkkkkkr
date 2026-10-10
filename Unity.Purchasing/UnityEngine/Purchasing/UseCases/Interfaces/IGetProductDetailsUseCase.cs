using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000144 RID: 324
	[NullableContext(1)]
	internal interface IGetProductDetailsUseCase
	{
		// Token: 0x060005A9 RID: 1449
		Dictionary<string, string> GetProductDetails();
	}
}
