using System;
using UnityEngine.Events;

namespace UnityEngine.Device
{
	// Token: 0x02000452 RID: 1106
	public static class Application
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x0004117C File Offset: 0x0003F37C
		public static string absoluteURL
		{
			get
			{
				return Application.absoluteURL;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x00041183 File Offset: 0x0003F383
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0004118A File Offset: 0x0003F38A
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.backgroundLoadingPriority;
			}
			set
			{
				Application.backgroundLoadingPriority = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x00041193 File Offset: 0x0003F393
		public static string buildGUID
		{
			get
			{
				return Application.buildGUID;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x0004119A File Offset: 0x0003F39A
		public static string cloudProjectId
		{
			get
			{
				return Application.cloudProjectId;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000411A1 File Offset: 0x0003F3A1
		public static string companyName
		{
			get
			{
				return Application.companyName;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000411A8 File Offset: 0x0003F3A8
		public static string consoleLogPath
		{
			get
			{
				return Application.consoleLogPath;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x000411AF File Offset: 0x0003F3AF
		public static string dataPath
		{
			get
			{
				return Application.dataPath;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000411B6 File Offset: 0x0003F3B6
		public static bool genuine
		{
			get
			{
				return Application.genuine;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x000411BD File Offset: 0x0003F3BD
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.genuineCheckAvailable;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000411C4 File Offset: 0x0003F3C4
		public static string identifier
		{
			get
			{
				return Application.identifier;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000411CB File Offset: 0x0003F3CB
		public static string installerName
		{
			get
			{
				return Application.installerName;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000411D2 File Offset: 0x0003F3D2
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.installMode;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000411D9 File Offset: 0x0003F3D9
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.internetReachability;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000411E0 File Offset: 0x0003F3E0
		public static bool isBatchMode
		{
			get
			{
				return Application.isBatchMode;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000411E7 File Offset: 0x0003F3E7
		public static bool isConsolePlatform
		{
			get
			{
				return Application.isConsolePlatform;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000411EE File Offset: 0x0003F3EE
		public static bool isEditor
		{
			get
			{
				return Application.isEditor;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000411F5 File Offset: 0x0003F3F5
		public static bool isFocused
		{
			get
			{
				return Application.isFocused;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000411FC File Offset: 0x0003F3FC
		public static bool isMobilePlatform
		{
			get
			{
				return Application.isMobilePlatform;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x00041203 File Offset: 0x0003F403
		public static bool isPlaying
		{
			get
			{
				return Application.isPlaying;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x0004120A File Offset: 0x0003F40A
		public static string persistentDataPath
		{
			get
			{
				return Application.persistentDataPath;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x00041211 File Offset: 0x0003F411
		public static RuntimePlatform platform
		{
			get
			{
				return Application.platform;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00041218 File Offset: 0x0003F418
		public static string productName
		{
			get
			{
				return Application.productName;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0004121F File Offset: 0x0003F41F
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x00041226 File Offset: 0x0003F426
		public static bool runInBackground
		{
			get
			{
				return Application.runInBackground;
			}
			set
			{
				Application.runInBackground = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0004122F File Offset: 0x0003F42F
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.sandboxType;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00041236 File Offset: 0x0003F436
		public static string streamingAssetsPath
		{
			get
			{
				return Application.streamingAssetsPath;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x0004123D File Offset: 0x0003F43D
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.systemLanguage;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00041244 File Offset: 0x0003F444
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x0004124B File Offset: 0x0003F44B
		public static int targetFrameRate
		{
			get
			{
				return Application.targetFrameRate;
			}
			set
			{
				Application.targetFrameRate = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00041254 File Offset: 0x0003F454
		public static string temporaryCachePath
		{
			get
			{
				return Application.temporaryCachePath;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0004125B File Offset: 0x0003F45B
		public static string unityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00041262 File Offset: 0x0003F462
		public static string version
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600271C RID: 10012 RVA: 0x00041269 File Offset: 0x0003F469
		// (remove) Token: 0x0600271D RID: 10013 RVA: 0x00041272 File Offset: 0x0003F472
		public static event Action<string> deepLinkActivated
		{
			add
			{
				Application.deepLinkActivated += value;
			}
			remove
			{
				Application.deepLinkActivated -= value;
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x0600271E RID: 10014 RVA: 0x0004127B File Offset: 0x0003F47B
		// (remove) Token: 0x0600271F RID: 10015 RVA: 0x00041284 File Offset: 0x0003F484
		public static event Action<bool> focusChanged
		{
			add
			{
				Application.focusChanged += value;
			}
			remove
			{
				Application.focusChanged -= value;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06002720 RID: 10016 RVA: 0x0004128D File Offset: 0x0003F48D
		// (remove) Token: 0x06002721 RID: 10017 RVA: 0x00041296 File Offset: 0x0003F496
		public static event Application.LogCallback logMessageReceived
		{
			add
			{
				Application.logMessageReceived += value;
			}
			remove
			{
				Application.logMessageReceived -= value;
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06002722 RID: 10018 RVA: 0x0004129F File Offset: 0x0003F49F
		// (remove) Token: 0x06002723 RID: 10019 RVA: 0x000412A8 File Offset: 0x0003F4A8
		public static event Application.LogCallback logMessageReceivedThreaded
		{
			add
			{
				Application.logMessageReceivedThreaded += value;
			}
			remove
			{
				Application.logMessageReceivedThreaded -= value;
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06002724 RID: 10020 RVA: 0x000412B1 File Offset: 0x0003F4B1
		// (remove) Token: 0x06002725 RID: 10021 RVA: 0x000412BA File Offset: 0x0003F4BA
		public static event Application.LowMemoryCallback lowMemory
		{
			add
			{
				Application.lowMemory += value;
			}
			remove
			{
				Application.lowMemory -= value;
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06002726 RID: 10022 RVA: 0x000412C3 File Offset: 0x0003F4C3
		// (remove) Token: 0x06002727 RID: 10023 RVA: 0x000412CC File Offset: 0x0003F4CC
		public static event UnityAction onBeforeRender
		{
			add
			{
				Application.onBeforeRender += value;
			}
			remove
			{
				Application.onBeforeRender -= value;
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06002728 RID: 10024 RVA: 0x000412D5 File Offset: 0x0003F4D5
		// (remove) Token: 0x06002729 RID: 10025 RVA: 0x000412DE File Offset: 0x0003F4DE
		public static event Action quitting
		{
			add
			{
				Application.quitting += value;
			}
			remove
			{
				Application.quitting -= value;
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600272A RID: 10026 RVA: 0x000412E7 File Offset: 0x0003F4E7
		// (remove) Token: 0x0600272B RID: 10027 RVA: 0x000412F0 File Offset: 0x0003F4F0
		public static event Func<bool> wantsToQuit
		{
			add
			{
				Application.wantsToQuit += value;
			}
			remove
			{
				Application.wantsToQuit -= value;
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600272C RID: 10028 RVA: 0x000412F9 File Offset: 0x0003F4F9
		// (remove) Token: 0x0600272D RID: 10029 RVA: 0x00041302 File Offset: 0x0003F502
		public static event Action unloading
		{
			add
			{
				Application.unloading += value;
			}
			remove
			{
				Application.unloading -= value;
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x0004130C File Offset: 0x0003F50C
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return Application.CanStreamedLevelBeLoaded(levelIndex);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00041324 File Offset: 0x0003F524
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoaded(levelName);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0004133C File Offset: 0x0003F53C
		public static string[] GetBuildTags()
		{
			return Application.GetBuildTags();
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00041354 File Offset: 0x0003F554
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogType(logType);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0004136C File Offset: 0x0003F56C
		public static bool HasProLicense()
		{
			return Application.HasProLicense();
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00041384 File Offset: 0x0003F584
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorization(mode);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0004139C File Offset: 0x0003F59C
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlaying(obj);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000413B4 File Offset: 0x0003F5B4
		public static void OpenURL(string url)
		{
			Application.OpenURL(url);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000413BE File Offset: 0x0003F5BE
		public static void Quit()
		{
			Application.Quit();
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000413C7 File Offset: 0x0003F5C7
		public static void Quit(int exitCode)
		{
			Application.Quit(exitCode);
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000413D4 File Offset: 0x0003F5D4
		public static bool RequestAdvertisingIdentifierAsync(Application.AdvertisingIdentifierCallback delegateMethod)
		{
			return Application.RequestAdvertisingIdentifierAsync(delegateMethod);
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000413EC File Offset: 0x0003F5EC
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			return Application.RequestUserAuthorization(mode);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00041404 File Offset: 0x0003F604
		public static void SetBuildTags(string[] buildTags)
		{
			Application.SetBuildTags(buildTags);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0004140E File Offset: 0x0003F60E
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogType(logType, stackTraceType);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00041419 File Offset: 0x0003F619
		public static void Unload()
		{
			Application.Unload();
		}
	}
}
