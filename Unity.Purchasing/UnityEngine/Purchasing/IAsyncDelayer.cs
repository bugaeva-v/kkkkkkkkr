using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000076 RID: 118
	[NullableContext(1)]
	internal interface IAsyncDelayer
	{
		// Token: 0x0600022F RID: 559
		Task Delay(int delayMilliseconds);
	}
}
