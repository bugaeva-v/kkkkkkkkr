using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000055 RID: 85
	[NullableContext(1)]
	public interface IOrderInfo
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000166 RID: 358
		[Nullable(2)]
		IAppleOrderInfo Apple { [NullableContext(2)] get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000167 RID: 359
		[Nullable(2)]
		IGoogleOrderInfo Google { [NullableContext(2)] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000168 RID: 360
		// (set) Token: 0x06000169 RID: 361
		List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600016A RID: 362
		string Receipt { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016B RID: 363
		string TransactionID { get; }
	}
}
