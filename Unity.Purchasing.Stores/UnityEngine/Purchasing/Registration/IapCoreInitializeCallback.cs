using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Telemetry.Internal;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing.Registration
{
	// Token: 0x0200004D RID: 77
	internal class IapCoreInitializeCallback : IInitializablePackage
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00007D2C File Offset: 0x00005F2C
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Register()
		{
			CoreRegistry.Instance.RegisterPackage<IapCoreInitializeCallback>(new IapCoreInitializeCallback()).DependsOn<IMetricsFactory>().DependsOn<IDiagnosticsFactory>().DependsOn<ICloudProjectId>().OptionallyDependsOn<IEnvironmentId>().OptionallyDependsOn<IAnalyticsStandardEventComponent>();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00007D74 File Offset: 0x00005F74
		public Task Initialize(CoreRegistry registry)
		{
			ITelemetryMetricsInstanceWrapper metricsInstanceWrapper = StoreFactory.Instance().TelemetryMetricsInstanceWrapper;
			ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper = StoreFactory.Instance().TelemetryDiagnosticsInstanceWrapper;
			((ITelemetryMetricsService)new TelemetryMetricsService(metricsInstanceWrapper)).ExecuteTimedAction(delegate
			{
				IapCoreInitializeCallback.CacheInitializedEnvironment(registry);
				IapCoreInitializeCallback.InitializeTelemetryComponents(metricsInstanceWrapper, diagnosticsInstanceWrapper);
			}, TelemetryMetricDefinitions.packageInitTimeName);
			return Task.CompletedTask;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007DD4 File Offset: 0x00005FD4
		private static void CacheInitializedEnvironment(CoreRegistry registry)
		{
			string currentEnvironment = IapCoreInitializeCallback.GetCurrentEnvironment(registry);
			CoreServicesEnvironmentSubject.Instance().UpdateCurrentEnvironment(currentEnvironment);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00007DF4 File Offset: 0x00005FF4
		private static string GetCurrentEnvironment(CoreRegistry registry)
		{
			string result;
			try
			{
				result = registry.GetServiceComponent<IEnvironments>().Current;
			}
			catch (KeyNotFoundException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007E28 File Offset: 0x00006028
		private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper)
		{
			IDiagnosticsFactory serviceComponent = CoreRegistry.Instance.GetServiceComponent<IDiagnosticsFactory>();
			diagnosticsInstanceWrapper.SetDiagnosticsInstance(serviceComponent.Create("com.unity.purchasing"));
			IMetricsFactory serviceComponent2 = CoreRegistry.Instance.GetServiceComponent<IMetricsFactory>();
			metricsInstanceWrapper.SetMetricsInstance(serviceComponent2.Create("com.unity.purchasing"));
		}

		// Token: 0x040000C1 RID: 193
		private const string k_PurchasingPackageName = "com.unity.purchasing";
	}
}
