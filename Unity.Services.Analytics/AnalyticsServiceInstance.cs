using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x02000007 RID: 7
	internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IServiceDebug
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000023E5 File Offset: 0x000005E5
		public string PrivacyUrl
		{
			get
			{
				return "https://unity.com/legal/game-player-and-app-user-privacy-policy";
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000023EC File Offset: 0x000005EC
		public string SessionID
		{
			get
			{
				return this.m_Session.SessionId;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000023F9 File Offset: 0x000005F9
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002401 File Offset: 0x00000601
		internal bool Active
		{
			get
			{
				return this.m_IsActive;
			}
			set
			{
				this.m_IsActive = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000240A File Offset: 0x0000060A
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002412 File Offset: 0x00000612
		public string GetAnalyticsUserID()
		{
			return this.m_UserIdentity.UserId;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000241F File Offset: 0x0000061F
		public IIdentityManager UserIdentity
		{
			get
			{
				return this.m_UserIdentity;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002428 File Offset: 0x00000628
		internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session)
		{
			this.m_DataGenerator = dataGenerator;
			this.m_SystemCalls = systemCalls;
			this.m_CoreStatsHelper = coreStatsHelper;
			this.m_DataDispatcher = dispatcher;
			this.m_Container = container;
			this.m_DataBuffer = realBuffer;
			this.m_DataDispatcher.SetBuffer(realBuffer);
			this.m_IsActive = false;
			this.m_StartUpEventsRecorded = false;
			this.m_AnalyticsForgetter = forgetter;
			this.m_UserIdentity = userIdentity;
			this.m_UserIdentity.OnPlayerChanged += this.PlayerChanged;
			this.m_Session = session;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024D0 File Offset: 0x000006D0
		internal void ResumeDataDeletionIfNecessary()
		{
			if (this.m_AnalyticsForgetter.DeletionInProgress)
			{
				this.DeactivateWithDataDeletionRequest();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024E5 File Offset: 0x000006E5
		public void StartDataCollection()
		{
			if (!this.m_IsActive)
			{
				this.m_AnalyticsForgetter.ResetDataDeletionStatus();
				this.m_CoreStatsHelper.SetCoreStatsConsent(true);
				this.Activate();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000250C File Offset: 0x0000070C
		private void Activate()
		{
			if (!this.m_IsActive)
			{
				this.m_IsActive = true;
				this.m_Container.Enable();
				this.m_DataBuffer.LoadFromDisk();
				this.m_UserIdentity.Initialize();
				this.RecordStartupEvents("com.unity.services.analytics.Events.Startup");
				this.Flush();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000255A File Offset: 0x0000075A
		public void StopDataCollection()
		{
			if (this.m_IsActive)
			{
				this.m_DataDispatcher.Flush();
				this.Deactivate();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002578 File Offset: 0x00000778
		internal void DeactivateWithDataDeletionRequest()
		{
			this.m_DataBuffer.ClearBuffer();
			this.m_DataBuffer.ClearDiskCache();
			this.m_Container.Enable();
			this.m_AnalyticsForgetter.AttemptToForget(this.m_UserIdentity.UserId, this.m_UserIdentity.InstallId, this.m_UserIdentity.PlayerId, BufferX.SerializeDateTime(DateTime.Now), "com.unity.services.analytics.Events.RequestDataDeletion", new Action(this.DataDeletionCompleted));
			this.Deactivate();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025F3 File Offset: 0x000007F3
		private void DataDeletionCompleted()
		{
			if (!this.m_IsActive)
			{
				this.m_Container.Disable();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002608 File Offset: 0x00000808
		private void Deactivate()
		{
			if (this.m_IsActive)
			{
				this.m_IsActive = false;
				if (!this.m_AnalyticsForgetter.DeletionInProgress)
				{
					this.m_Container.Disable();
				}
			}
			this.m_CoreStatsHelper.SetCoreStatsConsent(false);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002640 File Offset: 0x00000840
		private void RecordStartupEvents(string callingId)
		{
			if (!this.m_StartUpEventsRecorded)
			{
				this.m_StartUpEventsRecorded = true;
				this.m_DataGenerator.SdkStartup(callingId);
				this.m_DataGenerator.ClientDevice(callingId);
				this.m_DataGenerator.GameStarted(callingId);
				if (this.m_UserIdentity.IsNewPlayer)
				{
					this.m_DataGenerator.NewPlayer(callingId);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002699 File Offset: 0x00000899
		private void PlayerChanged()
		{
			if (this.m_UserIdentity.IsNewPlayer)
			{
				this.m_Session.StartNewSession();
				this.m_StartUpEventsRecorded = false;
				if (this.m_IsActive)
				{
					this.RecordStartupEvents("com.unity.services.analytics.Events.PlayerChanged");
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026D0 File Offset: 0x000008D0
		internal void ApplicationPaused(bool paused)
		{
			if (paused)
			{
				this.m_ApplicationPauseTime = this.m_SystemCalls.UtcNow;
				return;
			}
			if (this.m_SystemCalls.UtcNow > this.m_ApplicationPauseTime + this.k_BackgroundSessionRefreshPeriod)
			{
				this.m_Session.StartNewSession();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002720 File Offset: 0x00000920
		internal int AutoflushPeriodMultiplier
		{
			get
			{
				return Mathf.Clamp(1 + this.m_DataDispatcher.ConsecutiveFailedUploadCount, 1, 8);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002736 File Offset: 0x00000936
		public void Flush()
		{
			if (this.m_IsActive)
			{
				this.m_DataDispatcher.Flush();
				return;
			}
			if (this.m_AnalyticsForgetter.DeletionInProgress)
			{
				this.DeactivateWithDataDeletionRequest();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000275F File Offset: 0x0000095F
		public void RequestDataDeletion()
		{
			this.DeactivateWithDataDeletionRequest();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002767 File Offset: 0x00000967
		internal void ApplicationQuit()
		{
			if (this.m_IsActive)
			{
				this.m_DataGenerator.GameEnded("com.unity.services.analytics.Events.Shutdown", DataGenerator.SessionEndState.QUIT);
				this.m_DataBuffer.FlushToDisk();
				this.Flush();
			}
			AnalyticsService.TearDown();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002798 File Offset: 0x00000998
		internal void RecordGameRunningIfNecessary()
		{
			if (this.m_IsActive)
			{
				if (this.m_DataBuffer.Length == 0 || this.m_DataBuffer.Length == this.m_BufferLengthAtLastGameRunning)
				{
					this.m_DataGenerator.GameRunning("com.unity.services.analytics.AnalyticsServiceInstance.RecordGameRunningIfNecessary");
					this.m_BufferLengthAtLastGameRunning = this.m_DataBuffer.Length;
					return;
				}
				this.m_BufferLengthAtLastGameRunning = this.m_DataBuffer.Length;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002800 File Offset: 0x00000A00
		public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
		{
			return this.converter.Convert(currencyCode, value);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000280F File Offset: 0x00000A0F
		public void CustomData(string eventName)
		{
			this.CustomData(eventName, null);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000281C File Offset: 0x00000A1C
		public void CustomData(string eventName, IDictionary<string, object> eventParams)
		{
			this.CustomData(eventName, eventParams, null, false, "AnalyticsServiceInstance.CustomData");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002840 File Offset: 0x00000A40
		public void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool isStandardEvent, string callingMethodIdentifier)
		{
			if (this.m_IsActive)
			{
				if (isStandardEvent)
				{
					this.m_DataBuffer.PushStandardEventStart(eventName, eventVersion.Value);
					this.m_DataGenerator.PushCommonParams(callingMethodIdentifier);
				}
				else
				{
					this.m_DataBuffer.PushCustomEventStart(eventName);
				}
				if (eventParams != null)
				{
					foreach (KeyValuePair<string, object> keyValuePair in eventParams)
					{
						this.m_DataBuffer.PushObject(keyValuePair.Key, keyValuePair.Value);
					}
				}
				this.m_DataBuffer.PushEndEvent();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028E4 File Offset: 0x00000AE4
		public void RecordEvent(string name)
		{
			if (this.m_IsActive)
			{
				this.m_DataGenerator.PushEmptyEvent(name);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028FA File Offset: 0x00000AFA
		public void RecordEvent(Event e)
		{
			this.RecordEvent(e, "com.unity.services.analytics.Events.UserInvoked");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002908 File Offset: 0x00000B08
		internal void RecordEvent(Event e, string callingMethodIdentifier)
		{
			if (this.m_IsActive)
			{
				this.m_DataGenerator.PushEvent(callingMethodIdentifier, e);
			}
		}

		// Token: 0x04000009 RID: 9
		private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion";

		// Token: 0x0400000A RID: 10
		private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup";

		// Token: 0x0400000B RID: 11
		private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged";

		// Token: 0x0400000C RID: 12
		internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked";

		// Token: 0x0400000D RID: 13
		private readonly TimeSpan k_BackgroundSessionRefreshPeriod = TimeSpan.FromMinutes(5.0);

		// Token: 0x0400000E RID: 14
		private readonly TransactionCurrencyConverter converter = new TransactionCurrencyConverter();

		// Token: 0x0400000F RID: 15
		private readonly IIdentityManager m_UserIdentity;

		// Token: 0x04000010 RID: 16
		private readonly ISessionManager m_Session;

		// Token: 0x04000011 RID: 17
		private readonly IDataGenerator m_DataGenerator;

		// Token: 0x04000012 RID: 18
		private readonly ICoreStatsHelper m_CoreStatsHelper;

		// Token: 0x04000013 RID: 19
		private readonly IDispatcher m_DataDispatcher;

		// Token: 0x04000014 RID: 20
		private readonly IAnalyticsForgetter m_AnalyticsForgetter;

		// Token: 0x04000015 RID: 21
		private readonly IAnalyticsServiceSystemCalls m_SystemCalls;

		// Token: 0x04000016 RID: 22
		private readonly IAnalyticsContainer m_Container;

		// Token: 0x04000017 RID: 23
		internal IBuffer m_DataBuffer;

		// Token: 0x04000018 RID: 24
		private int m_BufferLengthAtLastGameRunning;

		// Token: 0x04000019 RID: 25
		private DateTime m_ApplicationPauseTime;

		// Token: 0x0400001A RID: 26
		private bool m_IsActive;

		// Token: 0x0400001B RID: 27
		private bool m_StartUpEventsRecorded;
	}
}
