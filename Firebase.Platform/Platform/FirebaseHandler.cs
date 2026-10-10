using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Firebase.Unity;
using UnityEngine;

namespace Firebase.Platform
{
	// Token: 0x02000011 RID: 17
	internal sealed class FirebaseHandler
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002A90 File Offset: 0x00000C90
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002A97 File Offset: 0x00000C97
		public static IFirebaseAppUtils AppUtils { get; private set; } = FirebaseAppUtilsStub.Instance;

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public static int TickCount
		{
			get
			{
				return FirebaseHandler.tickCount;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002AB7 File Offset: 0x00000CB7
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002ABE File Offset: 0x00000CBE
		private static Dispatcher ThreadDispatcher { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002AC6 File Offset: 0x00000CC6
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002ACE File Offset: 0x00000CCE
		public bool IsPlayMode { get; set; }

		// Token: 0x06000057 RID: 87 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private FirebaseHandler()
		{
			bool isEditor = Application.isEditor;
			if (isEditor)
			{
				this.IsPlayMode = FirebaseEditorDispatcher.EditorIsPlaying;
				FirebaseEditorDispatcher.ListenToPlayState(true);
			}
			else
			{
				this.IsPlayMode = true;
			}
			bool isPlayMode = this.IsPlayMode;
			if (isPlayMode)
			{
				this.StartMonoBehaviour();
			}
			else
			{
				FirebaseEditorDispatcher.StartEditorUpdate();
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002B5C File Offset: 0x00000D5C
		internal void StartMonoBehaviour()
		{
			bool flag = FirebaseHandler.firebaseHandler == null;
			if (flag)
			{
				FirebaseHandler.firebaseHandler = this;
			}
			GameObject gameObject = new GameObject("Firebase Services");
			FirebaseHandler.firebaseMonoBehaviour = gameObject.AddComponent<FirebaseMonoBehaviour>();
			UnitySynchronizationContext.Create(gameObject);
			Object.DontDestroyOnLoad(gameObject);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002BA0 File Offset: 0x00000DA0
		internal void StopMonoBehaviour()
		{
			bool flag = FirebaseHandler.firebaseMonoBehaviour != null;
			if (flag)
			{
				FirebaseHandler.RunOnMainThread<bool>(delegate
				{
					bool flag2 = FirebaseHandler.firebaseMonoBehaviour != null;
					if (flag2)
					{
						UnitySynchronizationContext.Destroy();
						Object.Destroy(FirebaseHandler.firebaseMonoBehaviour.gameObject);
					}
					return true;
				});
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static TResult RunOnMainThread<TResult>(Func<TResult> f)
		{
			bool flag = FirebaseHandler.ThreadDispatcher != null;
			TResult result;
			if (flag)
			{
				TResult tresult = FirebaseHandler.ThreadDispatcher.Run<TResult>(f);
				result = tresult;
			}
			else
			{
				result = f();
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002C1C File Offset: 0x00000E1C
		public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f)
		{
			bool flag = FirebaseHandler.ThreadDispatcher != null;
			Task<TResult> result;
			if (flag)
			{
				result = FirebaseHandler.ThreadDispatcher.RunAsync<TResult>(f);
			}
			else
			{
				result = Dispatcher.RunAsyncNow<TResult>(f);
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002C50 File Offset: 0x00000E50
		internal bool IsMainThread()
		{
			bool flag = FirebaseHandler.ThreadDispatcher != null;
			return flag && FirebaseHandler.ThreadDispatcher.ManagesThisThread();
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600005D RID: 93 RVA: 0x00002C80 File Offset: 0x00000E80
		// (remove) Token: 0x0600005E RID: 94 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal event EventHandler<EventArgs> Updated;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600005F RID: 95 RVA: 0x00002CF0 File Offset: 0x00000EF0
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x00002D28 File Offset: 0x00000F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal event EventHandler<FirebaseHandler.ApplicationFocusChangedEventArgs> ApplicationFocusChanged;

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002D60 File Offset: 0x00000F60
		internal static FirebaseHandler DefaultInstance
		{
			get
			{
				return FirebaseHandler.firebaseHandler;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002D78 File Offset: 0x00000F78
		internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils)
		{
			appUtils.TranslateDllNotFoundException(delegate
			{
				Type typeFromHandle = typeof(FirebaseHandler);
				lock (typeFromHandle)
				{
					bool flag2 = FirebaseHandler.firebaseHandler != null;
					if (!flag2)
					{
						FirebaseHandler.AppUtils = appUtils;
						bool flag3 = FirebaseHandler.ThreadDispatcher == null;
						if (flag3)
						{
							FirebaseHandler.ThreadDispatcher = new Dispatcher();
						}
						FirebaseHandler.firebaseHandler = new FirebaseHandler();
					}
				}
			});
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002DAB File Offset: 0x00000FAB
		internal static void Create(IFirebaseAppUtils appUtils)
		{
			FirebaseHandler.CreatePartialOnMainThread(appUtils);
			UnityPlatformServices.SetupServices();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002DBC File Offset: 0x00000FBC
		internal void Update()
		{
			FirebaseHandler.ThreadDispatcher.PollJobs();
			FirebaseHandler.AppUtils.PollCallbacks();
			bool flag = this.Updated != null;
			if (flag)
			{
				bool flag2 = this.UpdatedEventWrapper == null;
				if (flag2)
				{
					this.UpdatedEventWrapper = delegate()
					{
						this.Updated(this, null);
					};
				}
				ExceptionAggregator.Wrap(this.UpdatedEventWrapper);
			}
			ExceptionAggregator.ThrowAndClearPendingExceptions();
			FirebaseHandler.tickCount++;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002E30 File Offset: 0x00001030
		internal void OnApplicationFocus(bool hasFocus)
		{
			bool flag = this.ApplicationFocusChanged != null;
			if (flag)
			{
				this.ApplicationFocusChanged(null, new FirebaseHandler.ApplicationFocusChangedEventArgs
				{
					HasFocus = hasFocus
				});
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E68 File Offset: 0x00001068
		internal static void Terminate()
		{
			bool flag = FirebaseHandler.firebaseHandler != null;
			if (flag)
			{
				FirebaseEditorDispatcher.Terminate(FirebaseHandler.firebaseHandler.IsPlayMode);
				FirebaseHandler.firebaseHandler.StopMonoBehaviour();
			}
			FirebaseHandler.firebaseHandler = null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002EA8 File Offset: 0x000010A8
		internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour)
		{
			bool flag = behaviour == FirebaseHandler.firebaseMonoBehaviour;
			if (flag)
			{
				FirebaseHandler.firebaseMonoBehaviour = null;
			}
		}

		// Token: 0x0400001A RID: 26
		private static FirebaseMonoBehaviour firebaseMonoBehaviour = null;

		// Token: 0x0400001C RID: 28
		private static int tickCount = 0;

		// Token: 0x0400001F RID: 31
		private static FirebaseHandler firebaseHandler = null;

		// Token: 0x04000021 RID: 33
		internal Action UpdatedEventWrapper = null;

		// Token: 0x02000023 RID: 35
		internal class ApplicationFocusChangedEventArgs : EventArgs
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00003C8C File Offset: 0x00001E8C
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00003C94 File Offset: 0x00001E94
			public bool HasFocus { get; set; }
		}
	}
}
