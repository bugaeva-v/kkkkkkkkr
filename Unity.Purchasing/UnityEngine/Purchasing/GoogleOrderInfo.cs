using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000052 RID: 82
	[NullableContext(2)]
	[Nullable(0)]
	internal class GoogleOrderInfo : OrderInfo, IGoogleOrderInfo
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public string ObfuscatedAccountId { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003BAD File Offset: 0x00001DAD
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public string ObfuscatedProfileId { get; set; }

		// Token: 0x06000156 RID: 342 RVA: 0x00003BBE File Offset: 0x00001DBE
		public GoogleOrderInfo([Nullable(1)] string receipt, string transactionID, [Nullable(1)] string storeName, string obfuscatedAccountId, string obfuscatedProfileId) : base(receipt, transactionID, storeName)
		{
			this.ObfuscatedAccountId = obfuscatedAccountId;
			this.ObfuscatedProfileId = obfuscatedProfileId;
		}
	}
}
