using System;
using UnityEngine.Analytics;

namespace Unity.Services.Analytics
{
	// Token: 0x0200001C RID: 28
	internal class CoreStatsHelper : ICoreStatsHelper
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public void SetCoreStatsConsent(bool userProvidedConsent)
		{
			UGSAnalyticsInternalTools.SetPrivacyStatus(userProvidedConsent);
		}
	}
}
