using System;
using System.Threading.Tasks;

namespace Uniject
{
	// Token: 0x02000005 RID: 5
	internal interface IThreadUtils
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5
		bool IsRunningOnMainThread { get; }

		// Token: 0x06000006 RID: 6
		Task PostAsync(Action action);

		// Token: 0x06000007 RID: 7
		Task PostAsync(Action<object> action, object state);

		// Token: 0x06000008 RID: 8
		Task<T> PostAsync<T>(Func<T> action);

		// Token: 0x06000009 RID: 9
		Task<T> PostAsync<T>(Func<object, T> action, object state);
	}
}
