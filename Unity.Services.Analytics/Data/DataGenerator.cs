using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x02000023 RID: 35
	internal class DataGenerator : IDataGenerator
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00003EB5 File Offset: 0x000020B5
		public DataGenerator(IBuffer buffer, ICommonData staticData, IDeviceData deviceData)
		{
			this.m_Buffer = buffer;
			this.m_CommonData = staticData;
			this.m_DeviceData = deviceData;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003ED4 File Offset: 0x000020D4
		public void SdkStartup(string callingMethodIdentifier)
		{
			this.m_Buffer.PushStandardEventStart("sdkStart", 1);
			this.m_Buffer.PushString("sdkVersion", SdkVersion.SDK_VERSION);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushString("sdkName", "com.unity.services.analytics");
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003F2E File Offset: 0x0000212E
		public void GameRunning(string callingMethodIdentifier)
		{
			this.m_Buffer.PushStandardEventStart("gameRunning", 1);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003F53 File Offset: 0x00002153
		public void NewPlayer(string callingMethodIdentifier)
		{
			this.m_Buffer.PushStandardEventStart("newPlayer", 1);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushString("deviceModel", this.m_DeviceData.DeviceModel);
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003F94 File Offset: 0x00002194
		public void GameStarted(string callingMethodIdentifier)
		{
			this.m_Buffer.PushStandardEventStart("gameStarted", 1);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushString("userLocale", this.m_CommonData.AnalyticsRegionLanguageCode);
			if (!string.IsNullOrEmpty(this.m_CommonData.BuildGUID))
			{
				this.m_Buffer.PushString("idLocalProject", this.m_CommonData.BuildGUID);
			}
			this.m_Buffer.PushString("osVersion", this.m_DeviceData.OperatingSystem);
			this.m_Buffer.PushBool("isTiny", this.m_DeviceData.IsTiny);
			this.m_Buffer.PushBool("debugDevice", this.m_DeviceData.IsDebugDevice);
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004060 File Offset: 0x00002260
		public void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState)
		{
			this.m_Buffer.PushStandardEventStart("gameEnded", 1);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushString("sessionEndState", quitState.ToString());
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000040B0 File Offset: 0x000022B0
		public void ClientDevice(string callingMethodIdentifier)
		{
			this.m_Buffer.PushStandardEventStart("clientDevice", 1);
			this.PushCommonParams(callingMethodIdentifier);
			this.m_Buffer.PushString("cpuType", this.m_DeviceData.CpuType);
			this.m_Buffer.PushString("gpuType", this.m_DeviceData.GpuType);
			this.m_Buffer.PushInt64("cpuCores", (long)this.m_DeviceData.CpuCores);
			this.m_Buffer.PushInt64("ramTotal", (long)this.m_DeviceData.RamTotal);
			this.m_Buffer.PushInt64("screenWidth", (long)this.m_DeviceData.ScreenWidth);
			this.m_Buffer.PushInt64("screenHeight", (long)this.m_DeviceData.ScreenHeight);
			this.m_Buffer.PushInt64("screenResolution", (long)((int)this.m_DeviceData.ScreenDpi));
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000041A4 File Offset: 0x000023A4
		public void PushCommonParams(string callingMethodIdentifier)
		{
			this.m_Buffer.PushString("sdkMethod", callingMethodIdentifier);
			this.m_Buffer.PushString("clientVersion", this.m_CommonData.Version);
			this.m_Buffer.PushDouble("batteryLoad", this.m_CommonData.BatteryLevel);
			this.m_Buffer.PushString("platform", this.m_CommonData.Platform);
			if (!string.IsNullOrEmpty(this.m_CommonData.GameStoreId))
			{
				this.m_Buffer.PushString("gameStoreID", this.m_CommonData.GameStoreId);
			}
			if (!string.IsNullOrEmpty(this.m_CommonData.GameBundleId))
			{
				this.m_Buffer.PushString("gameBundleID", this.m_CommonData.GameBundleId);
			}
			if (!string.IsNullOrEmpty(this.m_CommonData.Idfv))
			{
				this.m_Buffer.PushString("idfv", this.m_CommonData.Idfv);
			}
			if (!string.IsNullOrEmpty(this.m_CommonData.BuildGUID))
			{
				this.m_Buffer.PushString("buildGUUID", this.m_CommonData.BuildGUID);
			}
			if (this.m_CommonData.HasVolume)
			{
				this.m_Buffer.PushDouble("deviceVolume", (double)this.m_CommonData.Volume);
			}
			if (!string.IsNullOrEmpty(this.m_CommonData.ProjectId))
			{
				this.m_Buffer.PushString("projectID", this.m_CommonData.ProjectId);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004320 File Offset: 0x00002520
		public void PushEvent(string callingMethodIdentifier, Event e)
		{
			e.Validate();
			if (e.StandardEvent)
			{
				this.m_Buffer.PushStandardEventStart(e.Name, e.EventVersion);
				this.PushCommonParams(callingMethodIdentifier);
			}
			else
			{
				this.m_Buffer.PushCustomEventStart(e.Name);
			}
			e.Serialize(this.m_Buffer);
			e.Reset();
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004389 File Offset: 0x00002589
		public void PushEmptyEvent(string name)
		{
			this.m_Buffer.PushCustomEventStart(name);
			this.m_Buffer.PushEndEvent();
		}

		// Token: 0x04000071 RID: 113
		private readonly IBuffer m_Buffer;

		// Token: 0x04000072 RID: 114
		private readonly ICommonData m_CommonData;

		// Token: 0x04000073 RID: 115
		private readonly IDeviceData m_DeviceData;

		// Token: 0x02000046 RID: 70
		internal enum SessionEndState
		{
			// Token: 0x040000DE RID: 222
			PAUSED,
			// Token: 0x040000DF RID: 223
			KILLEDINBACKGROUND,
			// Token: 0x040000E0 RID: 224
			KILLEDINFOREGROUND,
			// Token: 0x040000E1 RID: 225
			QUIT
		}
	}
}
