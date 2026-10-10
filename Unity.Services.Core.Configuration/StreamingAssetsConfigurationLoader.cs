using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration
{
	// Token: 0x0200000B RID: 11
	internal class StreamingAssetsConfigurationLoader : IConfigurationLoader
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002414 File Offset: 0x00000614
		public StreamingAssetsConfigurationLoader(IJsonSerializer serializer)
		{
			this.m_Serializer = serializer;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002424 File Offset: 0x00000624
		public Task<SerializableProjectConfiguration> GetConfigAsync()
		{
			StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2 <GetConfigAsync>d__;
			<GetConfigAsync>d__.<>t__builder = AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Create();
			<GetConfigAsync>d__.<>4__this = this;
			<GetConfigAsync>d__.<>1__state = -1;
			<GetConfigAsync>d__.<>t__builder.Start<StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>(ref <GetConfigAsync>d__);
			return <GetConfigAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400000B RID: 11
		private readonly IJsonSerializer m_Serializer;
	}
}
