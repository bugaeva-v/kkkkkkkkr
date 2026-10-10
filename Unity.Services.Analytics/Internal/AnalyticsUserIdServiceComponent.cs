using System;
using Unity.Services.Core.Analytics.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000025 RID: 37
	internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000043AC File Offset: 0x000025AC
		public AnalyticsUserIdServiceComponent(IAnalyticsService analyticsService)
		{
			this.m_AnalyticsService = analyticsService;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000043BB File Offset: 0x000025BB
		public string GetAnalyticsUserId()
		{
			return this.m_AnalyticsService.GetAnalyticsUserID();
		}

		// Token: 0x04000074 RID: 116
		private readonly IAnalyticsService m_AnalyticsService;
	}
}
