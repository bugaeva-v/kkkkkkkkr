using System;
using System.Threading.Tasks;

namespace Unity.Services.Core
{
	// Token: 0x0200000B RID: 11
	public interface IUnityServices
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001E RID: 30
		// (remove) Token: 0x0600001F RID: 31
		event Action Initialized;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000020 RID: 32
		// (remove) Token: 0x06000021 RID: 33
		event Action<Exception> InitializeFailed;

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34
		ServicesInitializationState State { get; }

		// Token: 0x06000023 RID: 35
		Task InitializeAsync(InitializationOptions options = null);

		// Token: 0x06000024 RID: 36 RVA: 0x00002239 File Offset: 0x00000439
		string GetIdentifier()
		{
			return null;
		}

		// Token: 0x06000025 RID: 37
		T GetService<T>();
	}
}
