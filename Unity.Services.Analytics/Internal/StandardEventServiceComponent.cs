using System;
using System.Collections.Generic;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000042 RID: 66
	internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0000666A File Offset: 0x0000486A
		public StandardEventServiceComponent(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService)
		{
			this.m_Configuration = configuration;
			this.m_AnalyticsService = analyticsService;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006680 File Offset: 0x00004880
		public void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName)
		{
			string @string = this.m_Configuration.GetString(packageName + ".version", null);
			string callingMethodIdentifier = packageName + "@" + @string;
			this.m_AnalyticsService.CustomData(eventName, eventParameters, new int?(eventVersion), true, callingMethodIdentifier);
		}

		// Token: 0x040000CE RID: 206
		private readonly IProjectConfiguration m_Configuration;

		// Token: 0x040000CF RID: 207
		private readonly IUnstructuredEventRecorder m_AnalyticsService;
	}
}
