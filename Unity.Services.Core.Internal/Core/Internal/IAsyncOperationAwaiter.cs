using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000031 RID: 49
	internal interface IAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BF RID: 191
		bool IsCompleted { get; }

		// Token: 0x060000C0 RID: 192
		void GetResult();
	}
}
