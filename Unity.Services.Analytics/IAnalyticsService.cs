using System;

namespace Unity.Services.Analytics
{
	// Token: 0x02000018 RID: 24
	public interface IAnalyticsService
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000088 RID: 136
		string PrivacyUrl { get; }

		// Token: 0x06000089 RID: 137
		void StartDataCollection();

		// Token: 0x0600008A RID: 138
		string GetAnalyticsUserID();

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008B RID: 139
		string SessionID { get; }

		// Token: 0x0600008C RID: 140
		long ConvertCurrencyToMinorUnits(string currencyCode, double value);

		// Token: 0x0600008D RID: 141
		void RecordEvent(Event e);

		// Token: 0x0600008E RID: 142
		void RecordEvent(string eventName);

		// Token: 0x0600008F RID: 143
		void Flush();

		// Token: 0x06000090 RID: 144
		void StopDataCollection();

		// Token: 0x06000091 RID: 145
		void RequestDataDeletion();
	}
}
