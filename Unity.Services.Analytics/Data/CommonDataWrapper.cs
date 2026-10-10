using System;
using Unity.Services.Analytics.Internal;
using Unity.Services.Analytics.Platform;
using UnityEngine;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x02000021 RID: 33
	internal class CommonDataWrapper : ICommonData
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003D21 File Offset: 0x00001F21
		public string Version { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003D29 File Offset: 0x00001F29
		public string GameBundleId { get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003D31 File Offset: 0x00001F31
		public string ProjectId { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003D39 File Offset: 0x00001F39
		public string Platform { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003D41 File Offset: 0x00001F41
		public string BuildGUID { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003D49 File Offset: 0x00001F49
		public string Idfv { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003D51 File Offset: 0x00001F51
		public string GameStoreId { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003D59 File Offset: 0x00001F59
		public bool HasVolume { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003D61 File Offset: 0x00001F61
		public float Volume
		{
			get
			{
				return DeviceVolumeProvider.GetDeviceVolume();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003D68 File Offset: 0x00001F68
		public double BatteryLevel
		{
			get
			{
				return (double)SystemInfo.batteryLevel;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003D70 File Offset: 0x00001F70
		public string AnalyticsRegionLanguageCode
		{
			get
			{
				return Locale.AnalyticsRegionLanguageCode();
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003D78 File Offset: 0x00001F78
		public CommonDataWrapper(string cloudProjectId)
		{
			this.Version = Application.version;
			this.ProjectId = cloudProjectId;
			this.GameBundleId = Application.identifier;
			this.Platform = CommonDataWrapper.GetPlatform();
			this.BuildGUID = Application.buildGUID;
			this.Idfv = SystemInfo.deviceUniqueIdentifier;
			this.GameStoreId = null;
			this.HasVolume = DeviceVolumeProvider.VolumeAvailable;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003DDC File Offset: 0x00001FDC
		private static string GetPlatform()
		{
			RuntimePlatform platform = Application.platform;
			if (platform <= RuntimePlatform.PS4)
			{
				switch (platform)
				{
				case RuntimePlatform.OSXEditor:
				case RuntimePlatform.OSXPlayer:
					return "MAC_CLIENT";
				case RuntimePlatform.WindowsPlayer:
				case RuntimePlatform.WindowsEditor:
				case RuntimePlatform.LinuxPlayer:
				case RuntimePlatform.LinuxEditor:
					return "PC_CLIENT";
				case RuntimePlatform.OSXWebPlayer:
				case RuntimePlatform.OSXDashboardPlayer:
				case RuntimePlatform.WindowsWebPlayer:
				case (RuntimePlatform)6:
				case RuntimePlatform.PS3:
				case RuntimePlatform.XBOX360:
				case RuntimePlatform.NaCl:
				case (RuntimePlatform)14:
				case RuntimePlatform.FlashPlayer:
					break;
				case RuntimePlatform.IPhonePlayer:
					return "IOS";
				case RuntimePlatform.Android:
					return "ANDROID";
				case RuntimePlatform.WebGLPlayer:
					return "WEB";
				case RuntimePlatform.MetroPlayerX86:
				case RuntimePlatform.MetroPlayerX64:
				case RuntimePlatform.MetroPlayerARM:
					if (SystemInfo.deviceType != DeviceType.Handheld)
					{
						return "PC_CLIENT";
					}
					return "WINDOWS_MOBILE";
				default:
					if (platform == RuntimePlatform.PS4)
					{
						return "PS4";
					}
					break;
				}
			}
			else
			{
				if (platform == RuntimePlatform.XboxOne)
				{
					return "XBOXONE";
				}
				if (platform == RuntimePlatform.tvOS)
				{
					return "IOS_TV";
				}
				if (platform == RuntimePlatform.Switch)
				{
					return "SWITCH";
				}
			}
			return "UNKNOWN";
		}
	}
}
