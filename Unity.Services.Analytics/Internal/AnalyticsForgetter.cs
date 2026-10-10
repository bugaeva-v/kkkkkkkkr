using System;
using System.Text;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200002A RID: 42
	internal class AnalyticsForgetter : IAnalyticsForgetter
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000046DE File Offset: 0x000028DE
		public bool DeletionInProgress
		{
			get
			{
				return this.m_DeletionStatus == AnalyticsForgetter.DataDeletionStatus.DeletionInProgress;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000046E9 File Offset: 0x000028E9
		internal AnalyticsForgetter(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper)
		{
			this.m_CollectUrl = collectUrl;
			this.m_Persistence = persistence;
			this.m_WebRequestHelper = webRequestHelper;
			this.m_DeletionStatus = (AnalyticsForgetter.DataDeletionStatus)persistence.LoadInt("unity.services.analytics.data_deletion_status");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004717 File Offset: 0x00002917
		public void ResetDataDeletionStatus()
		{
			this.SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus.DataAllowed);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004720 File Offset: 0x00002920
		private void SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus state)
		{
			this.m_DeletionStatus = state;
			this.m_Persistence.SaveValue("unity.services.analytics.data_deletion_status", (int)state);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000473C File Offset: 0x0000293C
		public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback)
		{
			if (this.m_Request == null)
			{
				this.SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus.DeletionInProgress);
				this.m_Callback = successfulUploadCallback;
				string s = string.Concat(new string[]
				{
					"{\"eventList\":[{\"eventName\":\"ddnaForgetMe\",\"userID\":\"",
					userId,
					"\",\"eventUUID\":\"",
					Guid.NewGuid().ToString(),
					"\",\"eventTimestamp\":\"",
					timestamp,
					"\",\"eventVersion\":1,\"unityInstallationID\":\"",
					installationId,
					"\",",
					string.IsNullOrEmpty(playerId) ? "" : ("\"unityPlayerID\":\"" + playerId + "\","),
					"\"eventParams\":{\"clientVersion\":\"",
					Application.version,
					"\",\"sdkMethod\":\"",
					callingMethod,
					"\"}}]}"
				});
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				this.m_Request = this.m_WebRequestHelper.CreateWebRequest(this.m_CollectUrl, "POST", bytes);
				this.m_Request.SetRequestHeader("PIPL_EXPORT", "true");
				this.m_Request.SetRequestHeader("PIPL_CONSENT", "true");
				this.m_WebRequestHelper.SendWebRequest(this.m_Request, new Action<long>(this.UploadComplete));
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004878 File Offset: 0x00002A78
		private void UploadComplete(long code)
		{
			bool flag = code >= 200L && code <= 299L;
			if (!this.m_Request.IsNetworkError && flag)
			{
				this.SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus.SuccessfullyDeleted);
				this.m_Callback();
			}
			this.m_Request.Dispose();
			this.m_Request = null;
		}

		// Token: 0x04000080 RID: 128
		private const string k_ForgottenStatusKey = "unity.services.analytics.data_deletion_status";

		// Token: 0x04000081 RID: 129
		private readonly string m_CollectUrl;

		// Token: 0x04000082 RID: 130
		private readonly IPersistence m_Persistence;

		// Token: 0x04000083 RID: 131
		private readonly IWebRequestHelper m_WebRequestHelper;

		// Token: 0x04000084 RID: 132
		private Action m_Callback;

		// Token: 0x04000085 RID: 133
		private AnalyticsForgetter.DataDeletionStatus m_DeletionStatus;

		// Token: 0x04000086 RID: 134
		private IWebRequest m_Request;

		// Token: 0x02000047 RID: 71
		private enum DataDeletionStatus
		{
			// Token: 0x040000E3 RID: 227
			DataAllowed,
			// Token: 0x040000E4 RID: 228
			DeletionInProgress,
			// Token: 0x040000E5 RID: 229
			SuccessfullyDeleted
		}
	}
}
