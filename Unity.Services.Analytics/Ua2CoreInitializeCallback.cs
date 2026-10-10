using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using UnityEngine;

// Token: 0x02000002 RID: 2
internal class Ua2CoreInitializeCallback : IInitializablePackage
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Register()
	{
		CoreRegistry.Instance.RegisterPackage<Ua2CoreInitializeCallback>(new Ua2CoreInitializeCallback()).DependsOn<IInstallationId>().DependsOn<ICloudProjectId>().DependsOn<IEnvironments>().DependsOn<IExternalUserId>().DependsOn<IProjectConfiguration>().OptionallyDependsOn<IPlayerId>().ProvidesComponent<IAnalyticsStandardEventComponent>();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020A8 File Offset: 0x000002A8
	public Task Initialize(CoreRegistry registry)
	{
		Ua2CoreInitializeCallback.<Initialize>d__1 <Initialize>d__;
		<Initialize>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Initialize>d__.registry = registry;
		<Initialize>d__.<>1__state = -1;
		<Initialize>d__.<>t__builder.Start<Ua2CoreInitializeCallback.<Initialize>d__1>(ref <Initialize>d__);
		return <Initialize>d__.<>t__builder.Task;
	}
}
