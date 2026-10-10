using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000032 RID: 50
	internal interface IAsyncOperationAwaiter<out T> : ICriticalNotifyCompletion, INotifyCompletion
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C1 RID: 193
		bool IsCompleted { get; }

		// Token: 0x060000C2 RID: 194
		T GetResult();
	}
}
