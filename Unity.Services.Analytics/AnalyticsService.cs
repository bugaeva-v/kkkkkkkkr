using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x02000003 RID: 3
	public static class AnalyticsService
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020F3 File Offset: 0x000002F3
		internal static bool IsInitialized
		{
			get
			{
				return AnalyticsService.m_Instance != null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020FD File Offset: 0x000002FD
		internal static IServiceDebug ServiceDebug
		{
			get
			{
				return AnalyticsService.m_Instance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002104 File Offset: 0x00000304
		internal static IDispatcherDebug DispatcherDebug
		{
			get
			{
				return AnalyticsService.m_DispatcherDebug;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000210C File Offset: 0x0000030C
		internal static void Initialize(CoreRegistry registry)
		{
			ICloudProjectId serviceComponent = registry.GetServiceComponent<ICloudProjectId>();
			IInstallationId serviceComponent2 = registry.GetServiceComponent<IInstallationId>();
			IPlayerId serviceComponent3 = registry.GetServiceComponent<IPlayerId>();
			IEnvironments serviceComponent4 = registry.GetServiceComponent<IEnvironments>();
			IExternalUserId serviceComponent5 = registry.GetServiceComponent<IExternalUserId>();
			CoreStatsHelper coreStatsHelper = new CoreStatsHelper();
			PlayerPrefsPersistence persistence = new PlayerPrefsPersistence();
			IdentityManager userIdentity = new IdentityManager(serviceComponent2, serviceComponent3, serviceComponent5, persistence);
			SessionManager session = new SessionManager();
			string text = ((serviceComponent != null) ? serviceComponent.GetCloudProjectId() : null) ?? Application.cloudProjectId;
			string collectUrl = string.Format("https://collect.analytics.unity3d.com/api/analytics/collect/v2/projects/{0}/environments/{1}", text, serviceComponent4.Current.ToLowerInvariant());
			BufferX bufferX = new BufferX(new BufferSystemCalls(), new DiskCache(new FileSystemCalls()), userIdentity, session);
			AnalyticsContainer analyticsContainer = AnalyticsContainer.CreateContainer();
			WebRequestHelper webRequestHelper = new WebRequestHelper();
			Dispatcher dispatcher = new Dispatcher(webRequestHelper, collectUrl);
			AnalyticsService.m_Instance = new AnalyticsServiceInstance(new DataGenerator(bufferX, new CommonDataWrapper(text), new DeviceDataWrapper()), bufferX, coreStatsHelper, dispatcher, new AnalyticsForgetter(collectUrl, persistence, webRequestHelper), userIdentity, serviceComponent4.Current, new AnalyticsServiceSystemCalls(), analyticsContainer, session);
			analyticsContainer.Initialize(AnalyticsService.m_Instance);
			AnalyticsService.m_Instance.ResumeDataDeletionIfNecessary();
			AnalyticsService.m_DispatcherDebug = dispatcher;
			AnalyticsService.m_BufferDebug = bufferX;
			if (AnalyticsService.m_EventRecordedCallback != null)
			{
				AnalyticsService.m_BufferDebug.EventRecorded += AnalyticsService.m_EventRecordedCallback;
				AnalyticsService.m_BufferDebug.EventsClearing += AnalyticsService.m_EventsClearingCallback;
				AnalyticsService.m_DispatcherDebug.FlushStarted += AnalyticsService.m_FlushStartedCallback;
				AnalyticsService.m_DispatcherDebug.FlushFinished += AnalyticsService.m_FlushCompletedCallback;
			}
			StandardEventServiceComponent component = new StandardEventServiceComponent(registry.GetServiceComponent<IProjectConfiguration>(), AnalyticsService.m_Instance);
			registry.RegisterServiceComponent<IAnalyticsStandardEventComponent>(component);
			AnalyticsUserIdServiceComponent component2 = new AnalyticsUserIdServiceComponent(AnalyticsService.m_Instance);
			registry.RegisterServiceComponent<IAnalyticsUserId>(component2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002290 File Offset: 0x00000490
		internal static void SubscribeDebugEvents(Action<string, string, DateTime, byte[]> eventRecordedCallback, Action<HashSet<string>> eventsUploadingCallback, Action<byte[]> flushStarted, Action<int, bool, bool, bool, bool, byte[]> flushCompleted)
		{
			AnalyticsService.m_EventRecordedCallback = eventRecordedCallback;
			AnalyticsService.m_EventsClearingCallback = eventsUploadingCallback;
			AnalyticsService.m_FlushStartedCallback = flushStarted;
			AnalyticsService.m_FlushCompletedCallback = flushCompleted;
			if (AnalyticsService.m_BufferDebug != null)
			{
				AnalyticsService.m_BufferDebug.EventRecorded += AnalyticsService.m_EventRecordedCallback;
				AnalyticsService.m_BufferDebug.EventsClearing += AnalyticsService.m_EventsClearingCallback;
				AnalyticsService.m_DispatcherDebug.FlushStarted += AnalyticsService.m_FlushStartedCallback;
				AnalyticsService.m_DispatcherDebug.FlushFinished += AnalyticsService.m_FlushCompletedCallback;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022F8 File Offset: 0x000004F8
		internal static void UnsubscribeDebugEvents()
		{
			if (AnalyticsService.m_BufferDebug != null)
			{
				AnalyticsService.m_BufferDebug.EventRecorded -= AnalyticsService.m_EventRecordedCallback;
				AnalyticsService.m_BufferDebug.EventsClearing -= AnalyticsService.m_EventsClearingCallback;
				AnalyticsService.m_DispatcherDebug.FlushStarted -= AnalyticsService.m_FlushStartedCallback;
				AnalyticsService.m_DispatcherDebug.FlushFinished -= AnalyticsService.m_FlushCompletedCallback;
			}
			AnalyticsService.m_EventRecordedCallback = null;
			AnalyticsService.m_EventsClearingCallback = null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002354 File Offset: 0x00000554
		internal static void TearDown()
		{
			if (AnalyticsService.m_BufferDebug != null && AnalyticsService.m_EventRecordedCallback != null)
			{
				AnalyticsService.m_BufferDebug.EventRecorded -= AnalyticsService.m_EventRecordedCallback;
				AnalyticsService.m_BufferDebug.EventsClearing -= AnalyticsService.m_EventsClearingCallback;
				AnalyticsService.m_DispatcherDebug.FlushStarted -= AnalyticsService.m_FlushStartedCallback;
				AnalyticsService.m_DispatcherDebug.FlushFinished -= AnalyticsService.m_FlushCompletedCallback;
			}
			AnalyticsService.m_Instance = null;
			AnalyticsService.m_DispatcherDebug = null;
			AnalyticsService.m_BufferDebug = null;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000023BD File Offset: 0x000005BD
		public static IAnalyticsService Instance
		{
			get
			{
				if (AnalyticsService.m_Instance == null)
				{
					throw new ServicesInitializationException("The Analytics service has not been initialized. Please initialize Unity Services.");
				}
				return AnalyticsService.m_Instance;
			}
		}

		// Token: 0x04000001 RID: 1
		private const string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v2/projects/{0}/environments/{1}";

		// Token: 0x04000002 RID: 2
		private static AnalyticsServiceInstance m_Instance;

		// Token: 0x04000003 RID: 3
		private static IDispatcherDebug m_DispatcherDebug;

		// Token: 0x04000004 RID: 4
		private static IBufferDebug m_BufferDebug;

		// Token: 0x04000005 RID: 5
		private static Action<string, string, DateTime, byte[]> m_EventRecordedCallback;

		// Token: 0x04000006 RID: 6
		private static Action<HashSet<string>> m_EventsClearingCallback;

		// Token: 0x04000007 RID: 7
		private static Action<byte[]> m_FlushStartedCallback;

		// Token: 0x04000008 RID: 8
		private static Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback;
	}
}
