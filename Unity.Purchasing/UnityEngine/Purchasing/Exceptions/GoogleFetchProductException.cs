using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Exceptions
{
	// Token: 0x0200011C RID: 284
	internal class GoogleFetchProductException : FetchProductsException
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000BBD3 File Offset: 0x00009DD3
		private GoogleFetchProductsFailureReason FailureReason { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000BBDB File Offset: 0x00009DDB
		private GoogleBillingResponseCode ResponseCode { get; }

		// Token: 0x06000510 RID: 1296 RVA: 0x0000BBE3 File Offset: 0x00009DE3
		[NullableContext(1)]
		public GoogleFetchProductException(GoogleFetchProductsFailureReason failureReason, GoogleBillingResponseCode responseCode, ProductFetchFailureDescription failureDescription) : base(failureDescription)
		{
			this.FailureReason = failureReason;
			this.ResponseCode = responseCode;
		}
	}
}
