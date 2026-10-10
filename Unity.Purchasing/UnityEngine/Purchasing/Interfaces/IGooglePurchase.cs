using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000126 RID: 294
	[NullableContext(1)]
	internal interface IGooglePurchase
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600052E RID: 1326
		int purchaseState { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600052F RID: 1327
		List<string> skus { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000530 RID: 1328
		string orderId { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000531 RID: 1329
		string receipt { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000532 RID: 1330
		string signature { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000533 RID: 1331
		[Nullable(2)]
		string obfuscatedAccountId { [NullableContext(2)] get; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000534 RID: 1332
		[Nullable(2)]
		string obfuscatedProfileId { [NullableContext(2)] get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000535 RID: 1333
		string originalJson { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000536 RID: 1334
		string purchaseToken { get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000537 RID: 1335
		IEnumerable<ProductDescription> productDescriptions { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000538 RID: 1336
		[Nullable(2)]
		string sku { [NullableContext(2)] get; }

		// Token: 0x06000539 RID: 1337
		bool IsAcknowledged();

		// Token: 0x0600053A RID: 1338
		bool IsPurchased();

		// Token: 0x0600053B RID: 1339
		bool IsPending();
	}
}
