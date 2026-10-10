using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008D RID: 141
	[NullableContext(1)]
	public interface IStoreConnectCallback
	{
		// Token: 0x06000271 RID: 625
		void OnStoreConnectionSucceeded();

		// Token: 0x06000272 RID: 626
		void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription);
	}
}
