using System;
using System.Runtime.CompilerServices;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000083 RID: 131
	[NullableContext(1)]
	[Nullable(0)]
	internal class RetryService : IRetryService
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00006737 File Offset: 0x00004937
		internal RetryService(IUtil util)
		{
			this.m_Util = util;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00006746 File Offset: 0x00004946
		public IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy)
		{
			return new RetryRequest(request, retryPolicy, this.m_Util);
		}

		// Token: 0x040000BE RID: 190
		private readonly IUtil m_Util;
	}
}
