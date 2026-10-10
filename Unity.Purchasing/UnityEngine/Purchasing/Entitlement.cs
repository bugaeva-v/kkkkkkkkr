using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004F RID: 79
	[NullableContext(2)]
	[Nullable(0)]
	public class Entitlement
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00003AF1 File Offset: 0x00001CF1
		public Product Product { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00003AF9 File Offset: 0x00001CF9
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00003B01 File Offset: 0x00001D01
		public Order Order { get; internal set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00003B0A File Offset: 0x00001D0A
		public EntitlementStatus Status { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00003B12 File Offset: 0x00001D12
		public string ErrorMessage { get; }

		// Token: 0x0600014D RID: 333 RVA: 0x00003B1A File Offset: 0x00001D1A
		internal Entitlement(Product product, Order order, EntitlementStatus status, string message = null)
		{
			this.Product = product;
			this.Order = order;
			this.Status = status;
			this.ErrorMessage = message;
		}
	}
}
