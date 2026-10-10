using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000029 RID: 41
	internal interface IAnalyticsForgetter
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000102 RID: 258
		bool DeletionInProgress { get; }

		// Token: 0x06000103 RID: 259
		void ResetDataDeletionStatus();

		// Token: 0x06000104 RID: 260
		void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback);
	}
}
