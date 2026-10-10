using System;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration
{
	// Token: 0x02000005 RID: 5
	internal static class ConfigurationUtils
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000021AF File Offset: 0x000003AF
		public static IConfigurationLoader ConfigurationLoader { get; internal set; } = new StreamingAssetsConfigurationLoader(new NewtonsoftSerializer(null));

		// Token: 0x04000003 RID: 3
		public const string ConfigFileName = "UnityServicesProjectConfiguration.json";
	}
}
