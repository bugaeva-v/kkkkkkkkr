using System;
using com.shephertz.app42.paas.sdk.csharp.app42Event;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000018 RID: 24
	internal class App42EventTracker : MonoBehaviour
	{
		// Token: 0x060000EC RID: 236 RVA: 0x000051F0 File Offset: 0x000033F0
		internal static App42EventTracker GetInstance()
		{
			if (App42EventTracker.applicationIsQuitting)
			{
				App42Log.Console("[Singleton] Instance already destroyed on application quit. Won't create again - returning null.");
				return null;
			}
			App42EventTracker result;
			lock (App42EventTracker.lockString)
			{
				if (App42EventTracker.restCon == null)
				{
					App42Log.Console(" Attaching Event Tracker ");
					GameObject gameObject = new GameObject("App42EventTracker");
					App42EventTracker.restCon = gameObject.AddComponent<App42EventTracker>();
					Object.DontDestroyOnLoad(gameObject);
					result = App42EventTracker.restCon;
				}
				else
				{
					App42Log.Console(" Event Tracker is Attached ");
					result = App42EventTracker.restCon;
				}
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005284 File Offset: 0x00003484
		private void OnApplicationQuit()
		{
			this.eventService.EndActivityInternal("AppSession", null, new EventServiceUtils());
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000529C File Offset: 0x0000349C
		private void OnApplicationPause(bool pauseStatus)
		{
			if (pauseStatus)
			{
				App42Log.Console("Application Paused");
				this.eventService.EndActivityInternal("AppSession", null, new EventServiceUtils());
				return;
			}
			App42Log.Console("Application Resume");
			this.eventService.StartActivityInternal("AppSession", null, new EventServiceUtils());
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000052ED File Offset: 0x000034ED
		private void OnDestroy()
		{
			App42EventTracker.applicationIsQuitting = true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000052F5 File Offset: 0x000034F5
		internal void TrackEvent()
		{
			this.eventService.StartActivityInternal("AppSession", null, new EventServiceUtils());
		}

		// Token: 0x04000054 RID: 84
		private static string lockString = "lock";

		// Token: 0x04000055 RID: 85
		private static bool applicationIsQuitting = false;

		// Token: 0x04000056 RID: 86
		private static App42EventTracker restCon = null;

		// Token: 0x04000057 RID: 87
		private EventService eventService = App42API.BuildEventService();
	}
}
