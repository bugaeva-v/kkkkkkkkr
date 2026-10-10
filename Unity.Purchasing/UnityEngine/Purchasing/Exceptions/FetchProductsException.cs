using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Exceptions
{
	// Token: 0x0200011D RID: 285
	[NullableContext(1)]
	[Nullable(0)]
	internal class FetchProductsException : IapException
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0000BBFA File Offset: 0x00009DFA
		internal ProductFetchFailureDescription FailureDescription { get; }

		// Token: 0x06000512 RID: 1298 RVA: 0x0000BC02 File Offset: 0x00009E02
		public FetchProductsException(ProductFetchFailureDescription failureDescription) : base(failureDescription.Message)
		{
			this.FailureDescription = failureDescription;
		}
	}
}
