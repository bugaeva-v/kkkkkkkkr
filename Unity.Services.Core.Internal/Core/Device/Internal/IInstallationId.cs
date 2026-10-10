using System;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Device.Internal
{
	// Token: 0x02000021 RID: 33
	public interface IInstallationId : IServiceComponent
	{
		// Token: 0x06000060 RID: 96
		string GetOrCreateIdentifier();
	}
}
