using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008F RID: 143
	[NullableContext(1)]
	internal interface IStoreFactory
	{
		// Token: 0x06000275 RID: 629
		IStoreWrapper CreateStore(string storeName);

		// Token: 0x06000276 RID: 630
		void RegisterStore(string storeName, Func<IStoreWrapper> function);
	}
}
