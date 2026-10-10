using System;
using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
	// Token: 0x02000008 RID: 8
	internal class MemoryConfigurationLoader : IConfigurationLoader
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021F7 File Offset: 0x000003F7
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000021FF File Offset: 0x000003FF
		public SerializableProjectConfiguration Config { get; set; }

		// Token: 0x06000018 RID: 24 RVA: 0x00002208 File Offset: 0x00000408
		Task<SerializableProjectConfiguration> IConfigurationLoader.GetConfigAsync()
		{
			TaskCompletionSource<SerializableProjectConfiguration> taskCompletionSource = new TaskCompletionSource<SerializableProjectConfiguration>();
			taskCompletionSource.SetResult(this.Config);
			return taskCompletionSource.Task;
		}
	}
}
