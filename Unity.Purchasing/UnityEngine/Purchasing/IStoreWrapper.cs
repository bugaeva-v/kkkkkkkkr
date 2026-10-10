using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000097 RID: 151
	[NullableContext(1)]
	public interface IStoreWrapper
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000284 RID: 644
		Store instance { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000285 RID: 645
		string name { get; }

		// Token: 0x06000286 RID: 646
		ConnectionState GetStoreConnectionState();
	}
}
