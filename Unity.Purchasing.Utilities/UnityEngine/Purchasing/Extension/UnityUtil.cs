using System;
using System.Collections;
using System.Collections.Generic;
using Purchasing.Utilities;
using Uniject;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000012 RID: 18
	internal class UnityUtil : IUtil
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000026A7 File Offset: 0x000008A7
		[Preserve]
		public UnityUtil(IThreadUtils threadUtils, IMonoBehaviourUtil monoBehaviorUtil)
		{
			this.m_ThreadUtils = threadUtils;
			this.m_MonoBehaviourUtils = monoBehaviorUtil;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026C8 File Offset: 0x000008C8
		public T[] GetAnyComponentsOfType<T>() where T : class
		{
			GameObject[] gameObjects = this.m_MonoBehaviourUtils.GetGameObjects();
			List<T> list = new List<T>();
			GameObject[] array = gameObjects;
			for (int i = 0; i < array.Length; i++)
			{
				foreach (MonoBehaviour monoBehaviour in array[i].GetComponents<MonoBehaviour>())
				{
					if (monoBehaviour is T)
					{
						list.Add(monoBehaviour as T);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002737 File Offset: 0x00000937
		public DateTime currentTime
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000273E File Offset: 0x0000093E
		public string persistentDataPath
		{
			get
			{
				return Application.persistentDataPath;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002745 File Offset: 0x00000945
		public string deviceUniqueIdentifier
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000274C File Offset: 0x0000094C
		public string unityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002753 File Offset: 0x00000953
		public string cloudProjectId
		{
			get
			{
				return Application.cloudProjectId;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000275A File Offset: 0x0000095A
		public string userId
		{
			get
			{
				return PlayerPrefs.GetString("unity.cloud_userid", string.Empty);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000276B File Offset: 0x0000096B
		public string gameVersion
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002772 File Offset: 0x00000972
		public ulong sessionId
		{
			get
			{
				return ulong.Parse(PlayerPrefs.GetString("unity.player_sessionid", "0"));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002788 File Offset: 0x00000988
		public RuntimePlatform platform
		{
			get
			{
				return Application.platform;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000278F File Offset: 0x0000098F
		public bool isEditor
		{
			get
			{
				return Application.isEditor;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002796 File Offset: 0x00000996
		public string deviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000279D File Offset: 0x0000099D
		public string deviceName
		{
			get
			{
				return SystemInfo.deviceName;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000027A4 File Offset: 0x000009A4
		public DeviceType deviceType
		{
			get
			{
				return SystemInfo.deviceType;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000027AB File Offset: 0x000009AB
		public string operatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000027B2 File Offset: 0x000009B2
		public int screenWidth
		{
			get
			{
				return Screen.width;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000027B9 File Offset: 0x000009B9
		public int screenHeight
		{
			get
			{
				return Screen.height;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000027C0 File Offset: 0x000009C0
		public float screenDpi
		{
			get
			{
				return Screen.dpi;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000027C8 File Offset: 0x000009C8
		public string screenOrientation
		{
			get
			{
				return Screen.orientation.ToString();
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000027E8 File Offset: 0x000009E8
		object IUtil.InitiateCoroutine(IEnumerator start)
		{
			return this.m_MonoBehaviourUtils.StartCoroutine(start);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000027F6 File Offset: 0x000009F6
		void IUtil.InitiateCoroutine(IEnumerator start, int delay)
		{
			this.m_MonoBehaviourUtils.DelayedCoroutine(start, delay);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002806 File Offset: 0x00000A06
		public void RunOnMainThread(Action runnable)
		{
			if (this.m_ThreadUtils.IsRunningOnMainThread)
			{
				runnable();
				return;
			}
			this.m_ThreadUtils.PostAsync(runnable);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002829 File Offset: 0x00000A29
		public object GetWaitForSeconds(int seconds)
		{
			return new WaitForSeconds((float)seconds);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002832 File Offset: 0x00000A32
		public static bool PcPlatform()
		{
			return UnityUtil.s_PcControlledPlatforms.Contains(Application.platform);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002843 File Offset: 0x00000A43
		public void AddPauseListener(Action<bool> runnable)
		{
			this.pauseListeners.Add(runnable);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002851 File Offset: 0x00000A51
		public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant)
		{
			return potentialDescendant.IsSubclassOf(potentialBase) || potentialDescendant == potentialBase;
		}

		// Token: 0x0400000A RID: 10
		private IThreadUtils m_ThreadUtils;

		// Token: 0x0400000B RID: 11
		private IMonoBehaviourUtil m_MonoBehaviourUtils;

		// Token: 0x0400000C RID: 12
		private static readonly List<RuntimePlatform> s_PcControlledPlatforms = new List<RuntimePlatform>
		{
			RuntimePlatform.LinuxPlayer,
			RuntimePlatform.OSXEditor,
			RuntimePlatform.OSXPlayer,
			RuntimePlatform.WindowsEditor,
			RuntimePlatform.WindowsPlayer
		};

		// Token: 0x0400000D RID: 13
		private readonly List<Action<bool>> pauseListeners = new List<Action<bool>>();

		// Token: 0x0400000E RID: 14
		internal const string ObsoleteUpgradeToIAPV5Message = "This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5";
	}
}
