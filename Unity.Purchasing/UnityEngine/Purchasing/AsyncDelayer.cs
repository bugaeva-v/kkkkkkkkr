using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000075 RID: 117
	internal class AsyncDelayer : IAsyncDelayer
	{
		// Token: 0x0600022D RID: 557 RVA: 0x000063A2 File Offset: 0x000045A2
		[NullableContext(1)]
		public Task Delay(int delayMilliseconds)
		{
			return Task.Delay(delayMilliseconds);
		}
	}
}
