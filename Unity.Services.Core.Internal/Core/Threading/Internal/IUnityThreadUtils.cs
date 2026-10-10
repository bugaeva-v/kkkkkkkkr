using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Threading.Internal
{
	// Token: 0x02000012 RID: 18
	public interface IUnityThreadUtils : IServiceComponent
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28
		bool IsRunningOnUnityThread { get; }

		// Token: 0x0600001D RID: 29
		Task PostAsync([NotNull] Action action);

		// Token: 0x0600001E RID: 30
		Task PostAsync([NotNull] Action<object> action, object state);

		// Token: 0x0600001F RID: 31
		Task<T> PostAsync<T>([NotNull] Func<T> action);

		// Token: 0x06000020 RID: 32
		Task<T> PostAsync<T>([NotNull] Func<object, T> action, object state);

		// Token: 0x06000021 RID: 33
		void Send([NotNull] Action action);

		// Token: 0x06000022 RID: 34
		void Send([NotNull] Action<object> action, object state);

		// Token: 0x06000023 RID: 35
		T Send<T>([NotNull] Func<T> action);

		// Token: 0x06000024 RID: 36
		T Send<T>([NotNull] Func<object, T> action, object state);
	}
}
