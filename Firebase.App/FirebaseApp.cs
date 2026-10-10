using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Platform;

namespace Firebase
{
	// Token: 0x02000014 RID: 20
	public sealed class FirebaseApp : IDisposable
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000572A File Offset: 0x0000392A
		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005750 File Offset: 0x00003950
		internal static HandleRef getCPtr(FirebaseApp obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005778 File Offset: 0x00003978
		internal static HandleRef swigRelease(FirebaseApp obj)
		{
			bool flag = obj != null;
			HandleRef result;
			if (flag)
			{
				bool flag2 = !obj.swigCMemOwn;
				if (flag2)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				result = handleRef;
			}
			else
			{
				result = new HandleRef(null, IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000057D0 File Offset: 0x000039D0
		~FirebaseApp()
		{
			this.Dispose(false);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005804 File Offset: 0x00003A04
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005818 File Offset: 0x00003A18
		public void Dispose(bool disposing)
		{
			bool flag = this.name == null;
			if (flag)
			{
				this.name = this.NameInternal;
			}
			bool flag2 = this.AppDisposed != null;
			if (flag2)
			{
				this.AppDisposed(this, EventArgs.Empty);
				this.AppDisposed = null;
			}
			this.RemoveReference();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00005870 File Offset: 0x00003A70
		static FirebaseApp()
		{
			LogUtil.InitializeLogging();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000058D4 File Offset: 0x00003AD4
		internal static void TranslateDllNotFoundException(Action closureToExecute)
		{
			try
			{
				closureToExecute();
			}
			catch (Exception ex)
			{
				bool flag = ex.GetBaseException() is DllNotFoundException;
				if (flag)
				{
					throw new InitializationException(InitResult.FailedMissingDependency, ErrorMessages.DllNotFoundExceptionErrorMessage);
				}
				throw;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00005920 File Offset: 0x00003B20
		public static FirebaseApp DefaultInstance
		{
			get
			{
				FirebaseApp instance = FirebaseApp.GetInstance(FirebaseApp.DefaultName);
				return (instance != null) ? instance : FirebaseApp.Create();
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005948 File Offset: 0x00003B48
		public static FirebaseApp GetInstance(string name)
		{
			FirebaseApp.ThrowIfCheckDependenciesRunning();
			FirebaseApp firebaseApp = null;
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			FirebaseApp result;
			lock (obj)
			{
				bool flag2 = FirebaseApp.nameToProxy.TryGetValue(name, out firebaseApp);
				if (flag2)
				{
					bool flag3 = firebaseApp == null;
					if (flag3)
					{
						FirebaseApp.nameToProxy.Remove(name);
					}
				}
				result = firebaseApp;
			}
			return result;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000059BC File Offset: 0x00003BBC
		public static FirebaseApp Create()
		{
			return FirebaseApp.CreateAndTrack(() => FirebaseApp.CreateInternal(), FirebaseApp.GetInstance(FirebaseApp.DefaultName));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000059FC File Offset: 0x00003BFC
		public static FirebaseApp Create(AppOptions options)
		{
			return FirebaseApp.CreateAndTrack(() => FirebaseApp.CreateInternal(options.ConvertToInternal()), FirebaseApp.GetInstance(FirebaseApp.DefaultName));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005A38 File Offset: 0x00003C38
		public static FirebaseApp Create(AppOptions options, string name)
		{
			return FirebaseApp.CreateAndTrack(() => FirebaseApp.CreateInternal(options.ConvertToInternal(), name), FirebaseApp.GetInstance(name));
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005A7C File Offset: 0x00003C7C
		public string Name
		{
			get
			{
				bool flag = this.name == null;
				if (flag)
				{
					this.ThrowIfNull();
					this.name = this.NameInternal;
				}
				return this.name;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005AB8 File Offset: 0x00003CB8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00005ACF File Offset: 0x00003CCF
		public static LogLevel LogLevel
		{
			get
			{
				return (LogLevel)AppUtilPINVOKE.FirebaseApp_GetLogLevelInternal();
			}
			set
			{
				AppUtilPINVOKE.FirebaseApp_SetLogLevelInternal((int)value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000118 RID: 280 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x00005B14 File Offset: 0x00003D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal event EventHandler AppDisposed;

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005B4C File Offset: 0x00003D4C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00005B64 File Offset: 0x00003D64
		private bool IsDataCollectionDefaultEnabled
		{
			get
			{
				return this.IsDataCollectionDefaultEnabledInternal();
			}
			set
			{
				this.SetDataCollectionDefaultEnabledInternal(value);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005B70 File Offset: 0x00003D70
		internal static void DisposeAllApps()
		{
			List<FirebaseApp> list = new List<FirebaseApp>();
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			lock (obj)
			{
				foreach (KeyValuePair<string, FirebaseApp> keyValuePair in FirebaseApp.nameToProxy)
				{
					list.Add(keyValuePair.Value);
				}
			}
			foreach (FirebaseApp firebaseApp in list)
			{
				firebaseApp.Dispose();
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005C48 File Offset: 0x00003E48
		private void AddReference()
		{
			FirebaseApp.ThrowIfCheckDependenciesRunning();
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			lock (obj)
			{
				this.swigCMemOwn = true;
				FirebaseApp.nameToProxy[this.Name] = this;
				FirebaseApp.cPtrToProxy[this.swigCPtr.Handle] = this;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005CBC File Offset: 0x00003EBC
		private void RemoveReference()
		{
			FirebaseApp.ThrowIfCheckDependenciesRunning();
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			lock (obj)
			{
				IntPtr handle = this.swigCPtr.Handle;
				bool flag2 = handle != IntPtr.Zero;
				if (flag2)
				{
					GC.SuppressFinalize(this);
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						int count = FirebaseApp.nameToProxy.Count;
						FirebaseApp.cPtrToProxy.Remove(handle);
						FirebaseApp.nameToProxy.Remove(this.Name);
						FirebaseApp.ReleaseReferenceInternal(this);
						bool flag4 = count > 0 && FirebaseApp.nameToProxy.Count == 0;
						if (flag4)
						{
							FirebaseApp.OnAllAppsDestroyed();
						}
					}
				}
				this.swigCMemOwn = false;
				this.swigCPtr = new HandleRef(null, IntPtr.Zero);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005DA0 File Offset: 0x00003FA0
		private void ThrowIfNull()
		{
			bool flag = this.swigCPtr.Handle == IntPtr.Zero;
			if (flag)
			{
				throw new NullReferenceException("App has been disposed");
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005DD4 File Offset: 0x00003FD4
		private static void InitializeAppUtilCallbacks()
		{
			object appUtilCallbacksLock = FirebaseApp.AppUtilCallbacksLock;
			lock (appUtilCallbacksLock)
			{
				bool appUtilCallbacksInitialized = FirebaseApp.AppUtilCallbacksInitialized;
				if (!appUtilCallbacksInitialized)
				{
					FirebaseApp.EnableModuleParams[] array = new FirebaseApp.EnableModuleParams[]
					{
						new FirebaseApp.EnableModuleParams("Firebase.Analytics.FirebaseAnalytics, Firebase.Analytics", "analytics", false),
						new FirebaseApp.EnableModuleParams("Firebase.AppCheck.FirebaseAppCheck, Firebase.AppCheck", "app_check", false),
						new FirebaseApp.EnableModuleParams("Firebase.Auth.FirebaseAuth, Firebase.Auth", "auth", false),
						new FirebaseApp.EnableModuleParams("Firebase.Crashlytics.Crashlytics, Firebase.Crashlytics", "crashlytics", false),
						new FirebaseApp.EnableModuleParams("Firebase.Database.FirebaseDatabase, Firebase.Database", "database", false),
						new FirebaseApp.EnableModuleParams("Firebase.DynamicLinks.DynamicLinks, Firebase.DynamicLinks", "dynamic_links", false),
						new FirebaseApp.EnableModuleParams("Firebase.Functions.FirebaseFunctions, Firebase.Functions", "functions", false),
						new FirebaseApp.EnableModuleParams("Firebase.Installations.FirebaseInstallations, Firebase.Installations", "installations", false),
						new FirebaseApp.EnableModuleParams("Firebase.Invites.FirebaseInvites, Firebase.Invites", "invites", false),
						new FirebaseApp.EnableModuleParams("Firebase.Messaging.FirebaseMessaging, Firebase.Messaging", "messaging", false),
						new FirebaseApp.EnableModuleParams("Firebase.Performance.FirebasePerformance, Firebase.Performance", "performance", false),
						new FirebaseApp.EnableModuleParams("Firebase.RemoteConfig.FirebaseRemoteConfig, Firebase.RemoteConfig", "remote_config", false),
						new FirebaseApp.EnableModuleParams("Firebase.Storage.FirebaseStorage, Firebase.Storage", "storage", false),
						new FirebaseApp.EnableModuleParams("Firebase.TestLab.GameLoop, Firebase.TestLab", "test_lab", true)
					};
					bool isAndroid = PlatformInformation.IsAndroid;
					bool flag2 = false;
					bool flag3 = !isAndroid;
					if (flag3)
					{
						AppUtil.SetEnabledAllAppCallbacks(false);
						flag2 = true;
					}
					foreach (FirebaseApp.EnableModuleParams enableModuleParams in array)
					{
						bool flag4 = false;
						try
						{
							flag4 = (Type.GetType(enableModuleParams.CSharpClassName) != null);
						}
						catch (Exception)
						{
						}
						bool enabledAppCallbackByName = AppUtil.GetEnabledAppCallbackByName(enableModuleParams.CppModuleName);
						bool flag5 = flag4 && (flag2 || enabledAppCallbackByName || enableModuleParams.AlwaysEnable);
						bool flag6 = flag5 != enabledAppCallbackByName;
						if (flag6)
						{
							LogUtil.LogMessage(LogLevel.Debug, string.Format("{0} module '{1}' for '{2}'", flag5 ? "Enable" : "Disable", enableModuleParams.CppModuleName, enableModuleParams.CSharpClassName));
						}
						AppUtil.SetEnabledAppCallbackByName(enableModuleParams.CppModuleName, flag5);
					}
					FirebaseApp.AppUtilCallbacksInitialized = true;
				}
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006040 File Offset: 0x00004240
		private static void OnAllAppsDestroyed()
		{
			bool flag = FirebaseApp.PreventOnAllAppsDestroyed || FirebaseApp.nameToProxy.Count > 0;
			if (!flag)
			{
				object appUtilCallbacksLock = FirebaseApp.AppUtilCallbacksLock;
				lock (appUtilCallbacksLock)
				{
					bool appUtilCallbacksInitialized = FirebaseApp.AppUtilCallbacksInitialized;
					if (appUtilCallbacksInitialized)
					{
						bool flag3 = !PlatformInformation.IsAndroid;
						if (flag3)
						{
							AppUtil.SetEnabledAllAppCallbacks(false);
						}
						FirebaseApp.AppUtilCallbacksInitialized = false;
					}
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000060C4 File Offset: 0x000042C4
		internal static Uri UrlStringToUri(string urlString)
		{
			bool flag = string.IsNullOrEmpty(urlString);
			Uri result;
			if (flag)
			{
				result = null;
			}
			else
			{
				try
				{
					result = new Uri(urlString);
				}
				catch (UriFormatException)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006104 File Offset: 0x00004304
		internal static string UriToUrlString(Uri uri)
		{
			return (uri != null) ? uri.OriginalString : "";
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000612C File Offset: 0x0000432C
		internal static object WeakReferenceGetTarget(WeakReference weakReference)
		{
			bool flag = weakReference != null;
			if (flag)
			{
				try
				{
					return weakReference.Target;
				}
				catch (InvalidOperationException)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006168 File Offset: 0x00004368
		private static bool InitializeCrashlyticsIfPresent()
		{
			try
			{
				Assembly assembly = Assembly.Load("Firebase.Crashlytics");
				Type type = assembly.GetType("Firebase.Crashlytics.Crashlytics");
				bool flag = type == null;
				if (flag)
				{
					throw new InitializationException(InitResult.FailedMissingDependency, "Crashlytics initialization failed. Could not find Crashlytics class.");
				}
				MethodInfo method = type.GetMethod("Initialize", BindingFlags.Static | BindingFlags.NonPublic);
				bool flag2 = method == null;
				if (flag2)
				{
					throw new InitializationException(InitResult.FailedMissingDependency, "Crashlytics initialization failed. Could not find Crashlytics initializer.");
				}
				method.Invoke(null, null);
			}
			catch (FileNotFoundException)
			{
				return false;
			}
			catch (Exception inner)
			{
				throw new InitializationException(InitResult.FailedMissingDependency, "Crashlytics initialization failed with an unexpected error.", inner);
			}
			return true;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006218 File Offset: 0x00004418
		private static FirebaseApp CreateAndTrack(FirebaseApp.CreateDelegate createDelegate, FirebaseApp existingProxy)
		{
			FirebaseApp.ThrowIfCheckDependenciesRunning();
			bool flag = false;
			FirebaseHandler.Create(FirebaseAppUtils.Instance);
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			FirebaseApp firebaseApp;
			lock (obj)
			{
				bool flag3 = !FirebaseApp.userAgentRegistered;
				if (flag3)
				{
					FirebaseApp.userAgentRegistered = true;
					StringStringMap stringStringMap = new StringStringMap();
					string text = "fire-" + PlatformInformation.RuntimeName;
					stringStringMap[text] = VersionInfo.SdkVersion;
					stringStringMap[text + "-ver"] = PlatformInformation.RuntimeVersion;
					stringStringMap[text + "-buildsrc"] = VersionInfo.BuildSource;
					try
					{
						foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
						{
							Type type = assembly.GetType("Firebase.AI.FirebaseAI", false, false);
							bool flag4 = type != null;
							if (flag4)
							{
								stringStringMap["fire-vertex"] = VersionInfo.SdkVersion;
								break;
							}
						}
					}
					catch
					{
					}
					FirebaseApp.RegisterLibrariesInternal(stringStringMap);
				}
				FirebaseApp.InitializeAppUtilCallbacks();
				HandleRef cptr = new HandleRef(null, IntPtr.Zero);
				try
				{
					FirebaseApp.AppSetDefaultConfigPath(PlatformInformation.DefaultConfigLocation);
					firebaseApp = createDelegate();
					bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
					if (pending)
					{
						throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
					}
					bool flag5 = firebaseApp == null;
					if (flag5)
					{
						throw new InitializationException(InitResult.FailedMissingDependency, "App creation failed with an unknown error.");
					}
					cptr = FirebaseApp.getCPtr(firebaseApp);
				}
				catch (ApplicationException ex)
				{
					FirebaseApp.OnAllAppsDestroyed();
					string text2 = ex.Message;
					InitResult result = InitResult.FailedMissingDependency;
					int num = text2.IndexOf(":");
					bool flag6 = num >= 0;
					if (flag6)
					{
						result = (InitResult)int.Parse(text2.Substring(0, num));
						text2 = text2.Substring(num + 1);
					}
					bool flag7 = text2.IndexOf("Please verify the AAR") >= 0;
					if (flag7)
					{
						text2 = text2 + "\n" + ErrorMessages.DependencyNotFoundErrorMessage;
					}
					throw new InitializationException(result, text2);
				}
				catch (Exception ex2)
				{
					FirebaseApp.OnAllAppsDestroyed();
					throw ex2;
				}
				bool flag8 = cptr.Handle == IntPtr.Zero;
				if (flag8)
				{
					return null;
				}
				FirebaseApp firebaseApp2 = null;
				bool flag9 = FirebaseApp.cPtrToProxy.TryGetValue(cptr.Handle, out firebaseApp2);
				if (flag9)
				{
					bool flag10 = firebaseApp2 != null;
					if (flag10)
					{
						bool flag11 = existingProxy != firebaseApp2;
						if (flag11)
						{
							LogUtil.LogMessage(LogLevel.Warning, string.Format("Detected multiple FirebaseApp proxies for {0}", existingProxy.Name));
							existingProxy.Dispose();
						}
						return firebaseApp2;
					}
				}
				FirebaseApp.LogHeartbeatInternal(firebaseApp);
				firebaseApp.name = firebaseApp.NameInternal;
				firebaseApp.AddReference();
				bool flag12 = !FirebaseApp.crashlyticsInitializationAttempted && !FirebaseApp.IsCheckDependenciesRunning();
				if (flag12)
				{
					flag = true;
					FirebaseApp.crashlyticsInitializationAttempted = true;
				}
			}
			bool flag13 = flag;
			if (flag13)
			{
				FirebaseHandler.RunOnMainThread<bool>(() => FirebaseApp.InitializeCrashlyticsIfPresent());
			}
			return firebaseApp;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000657C File Offset: 0x0000477C
		private static void SetCheckDependenciesThread(int threadId)
		{
			object checkDependenciesThreadLock = FirebaseApp.CheckDependenciesThreadLock;
			lock (checkDependenciesThreadLock)
			{
				bool flag2 = FirebaseApp.CheckDependenciesThread == -1 || FirebaseApp.CheckDependenciesThread == -2 || FirebaseApp.CheckDependenciesThread == Thread.CurrentThread.ManagedThreadId;
				if (!flag2)
				{
					throw new InvalidOperationException("Don't call other Firebase functions while CheckDependencies is running.");
				}
				FirebaseApp.CheckDependenciesThread = threadId;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000065FC File Offset: 0x000047FC
		private static void ThrowIfCheckDependenciesRunning()
		{
			object checkDependenciesThreadLock = FirebaseApp.CheckDependenciesThreadLock;
			lock (checkDependenciesThreadLock)
			{
				bool flag2 = FirebaseApp.CheckDependenciesThread != -1 && FirebaseApp.CheckDependenciesThread != Thread.CurrentThread.ManagedThreadId;
				if (flag2)
				{
					throw new InvalidOperationException("Don't call Firebase functions before CheckDependencies has finished");
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000666C File Offset: 0x0000486C
		private static bool IsCheckDependenciesRunning()
		{
			object checkDependenciesThreadLock = FirebaseApp.CheckDependenciesThreadLock;
			bool result;
			lock (checkDependenciesThreadLock)
			{
				result = (FirebaseApp.CheckDependenciesThread != -1);
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000066B8 File Offset: 0x000048B8
		public static Task<DependencyStatus> CheckDependenciesAsync()
		{
			FirebaseApp.SetCheckDependenciesThread(-2);
			FirebaseHandler.CreatePartialOnMainThread(FirebaseAppUtils.Instance);
			FirebaseApp.InitializeAppUtilCallbacks();
			return Task.Run<DependencyStatus>(delegate()
			{
				FirebaseApp.SetCheckDependenciesThread(Thread.CurrentThread.ManagedThreadId);
				DependencyStatus result = FirebaseApp.CheckDependencies();
				FirebaseApp.SetCheckDependenciesThread(-1);
				return result;
			});
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006708 File Offset: 0x00004908
		public static Task<DependencyStatus> CheckAndFixDependenciesAsync()
		{
			return FirebaseApp.CheckDependenciesAsync().ContinueWith<Task<DependencyStatus>>(delegate(Task<DependencyStatus> checkTask)
			{
				DependencyStatus result = checkTask.Result;
				bool flag = result > DependencyStatus.Available;
				Task<DependencyStatus> result2;
				if (flag)
				{
					result2 = FirebaseApp.FixDependenciesAsync().ContinueWith<Task<DependencyStatus>>((Task t) => FirebaseApp.CheckDependenciesAsync()).Unwrap<DependencyStatus>();
				}
				else
				{
					result2 = checkTask;
				}
				return result2;
			}).Unwrap<DependencyStatus>();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006748 File Offset: 0x00004948
		private static DependencyStatus CheckDependencies()
		{
			DependencyStatus status = DependencyStatus.Available;
			FirebaseApp.TranslateDllNotFoundException(delegate
			{
				status = FirebaseApp.CheckDependenciesInternal();
			});
			return status;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006780 File Offset: 0x00004980
		private static DependencyStatus CheckDependenciesInternal()
		{
			bool flag = PlatformInformation.IsAndroid && FirebaseApp.GetInstance(FirebaseApp.DefaultName) == null;
			DependencyStatus result;
			if (flag)
			{
				InitResult initResult = InitResult.Success;
				FirebaseApp firebaseApp = null;
				try
				{
					firebaseApp = FirebaseApp.DefaultInstance;
					return DependencyStatus.Available;
				}
				catch (InitializationException ex)
				{
					initResult = ex.InitResult;
					bool flag2 = initResult != InitResult.FailedMissingDependency;
					if (flag2)
					{
						throw ex;
					}
				}
				finally
				{
					bool flag3 = firebaseApp != null;
					if (flag3)
					{
						firebaseApp.Dispose();
					}
				}
				switch (AppUtil.CheckAndroidDependencies())
				{
				case GooglePlayServicesAvailability.AvailabilityAvailable:
					result = DependencyStatus.Available;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableDisabled:
					result = DependencyStatus.UnavailableDisabled;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableInvalid:
					result = DependencyStatus.UnavailableInvalid;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableMissing:
					result = DependencyStatus.UnavilableMissing;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailablePermissions:
					result = DependencyStatus.UnavailablePermission;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableUpdateRequired:
					result = DependencyStatus.UnavailableUpdaterequired;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableUpdating:
					result = DependencyStatus.UnavailableUpdating;
					break;
				case GooglePlayServicesAvailability.AvailabilityUnavailableOther:
					result = DependencyStatus.UnavailableOther;
					break;
				default:
					result = ((initResult == InitResult.Success) ? DependencyStatus.Available : DependencyStatus.UnavailableOther);
					break;
				}
			}
			else
			{
				result = DependencyStatus.Available;
			}
			return result;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006884 File Offset: 0x00004A84
		public static Task FixDependenciesAsync()
		{
			Task task = null;
			FirebaseApp.TranslateDllNotFoundException(delegate
			{
				task = AppUtil.FixAndroidDependenciesAsync().ContinueWith(delegate(Task t)
				{
					bool flag = t.Exception != null;
					if (flag)
					{
						throw t.Exception;
					}
					FirebaseApp.ResetDefaultAppCPtr();
				});
			});
			return task;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000068BC File Offset: 0x00004ABC
		private static void ResetDefaultAppCPtr()
		{
			FirebaseApp.ThrowIfCheckDependenciesRunning();
			Dictionary<string, FirebaseApp> obj = FirebaseApp.nameToProxy;
			lock (obj)
			{
				AppUtil.InitializePlayServicesInternal();
				FirebaseApp.PreventOnAllAppsDestroyed = true;
				FirebaseApp defaultInstance = FirebaseApp.DefaultInstance;
				defaultInstance.RemoveReference();
				defaultInstance.swigCPtr = new HandleRef(defaultInstance, AppUtilPINVOKE.FirebaseApp_CreateInternal__SWIG_0());
				defaultInstance.AddReference();
				FirebaseApp.PreventOnAllAppsDestroyed = false;
				AppUtil.TerminatePlayServicesInternal();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006940 File Offset: 0x00004B40
		public AppOptions Options
		{
			get
			{
				this.ThrowIfNull();
				return new AppOptions(this.options());
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006964 File Offset: 0x00004B64
		internal static SynchronizationContext ThreadSynchronizationContext
		{
			get
			{
				return (FirebaseHandler.DefaultInstance != null && FirebaseHandler.DefaultInstance.IsMainThread()) ? PlatformInformation.SynchronizationContext : null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006994 File Offset: 0x00004B94
		internal FirebaseAppPlatform AppPlatform
		{
			get
			{
				Type typeFromHandle = typeof(FirebaseAppPlatform);
				FirebaseAppPlatform result;
				lock (typeFromHandle)
				{
					bool flag2 = this.appPlatform == null;
					if (flag2)
					{
						this.appPlatform = new FirebaseAppPlatform(this);
					}
					result = this.appPlatform;
				}
				return result;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000069FC File Offset: 0x00004BFC
		internal AppOptionsInternal options()
		{
			AppOptionsInternal result = new AppOptionsInternal(AppUtilPINVOKE.FirebaseApp_options(this.swigCPtr), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006A30 File Offset: 0x00004C30
		internal void SetDataCollectionDefaultEnabledInternal(bool enabled)
		{
			AppUtilPINVOKE.FirebaseApp_SetDataCollectionDefaultEnabledInternal(this.swigCPtr, enabled);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006A5C File Offset: 0x00004C5C
		internal bool IsDataCollectionDefaultEnabledInternal()
		{
			bool result = AppUtilPINVOKE.FirebaseApp_IsDataCollectionDefaultEnabledInternal(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006A8C File Offset: 0x00004C8C
		internal string NameInternal
		{
			get
			{
				string result = AppUtilPINVOKE.FirebaseApp_NameInternal_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006ABC File Offset: 0x00004CBC
		internal static FirebaseApp CreateInternal()
		{
			IntPtr intPtr = AppUtilPINVOKE.FirebaseApp_CreateInternal__SWIG_0();
			FirebaseApp result = (intPtr == IntPtr.Zero) ? null : new FirebaseApp(intPtr, false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006AFC File Offset: 0x00004CFC
		internal static FirebaseApp CreateInternal(AppOptionsInternal options)
		{
			IntPtr intPtr = AppUtilPINVOKE.FirebaseApp_CreateInternal__SWIG_1(AppOptionsInternal.getCPtr(options));
			FirebaseApp result = (intPtr == IntPtr.Zero) ? null : new FirebaseApp(intPtr, false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006B44 File Offset: 0x00004D44
		internal static FirebaseApp CreateInternal(AppOptionsInternal options, string name)
		{
			IntPtr intPtr = AppUtilPINVOKE.FirebaseApp_CreateInternal__SWIG_2(AppOptionsInternal.getCPtr(options), name);
			FirebaseApp result = (intPtr == IntPtr.Zero) ? null : new FirebaseApp(intPtr, false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006B8C File Offset: 0x00004D8C
		internal static void ReleaseReferenceInternal(FirebaseApp app)
		{
			AppUtilPINVOKE.FirebaseApp_ReleaseReferenceInternal(FirebaseApp.getCPtr(app));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006BB8 File Offset: 0x00004DB8
		internal static void SetLogLevelInternal(LogLevel level)
		{
			AppUtilPINVOKE.FirebaseApp_SetLogLevelInternal((int)level);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006BDC File Offset: 0x00004DDC
		internal static LogLevel GetLogLevelInternal()
		{
			LogLevel result = (LogLevel)AppUtilPINVOKE.FirebaseApp_GetLogLevelInternal();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006C04 File Offset: 0x00004E04
		internal static void RegisterLibrariesInternal(StringStringMap libraries)
		{
			AppUtilPINVOKE.FirebaseApp_RegisterLibrariesInternal(StringStringMap.getCPtr(libraries));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006C30 File Offset: 0x00004E30
		internal static void LogHeartbeatInternal(FirebaseApp app)
		{
			AppUtilPINVOKE.FirebaseApp_LogHeartbeatInternal(FirebaseApp.getCPtr(app));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006C5C File Offset: 0x00004E5C
		internal static void AppSetDefaultConfigPath(string path)
		{
			AppUtilPINVOKE.FirebaseApp_AppSetDefaultConfigPath(path);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006C80 File Offset: 0x00004E80
		public static string DefaultName
		{
			get
			{
				string result = AppUtilPINVOKE.FirebaseApp_DefaultName_get();
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x04000040 RID: 64
		private HandleRef swigCPtr;

		// Token: 0x04000041 RID: 65
		private bool swigCMemOwn;

		// Token: 0x04000042 RID: 66
		internal static readonly object disposeLock = new object();

		// Token: 0x04000043 RID: 67
		private string name;

		// Token: 0x04000045 RID: 69
		private static Dictionary<string, FirebaseApp> nameToProxy = new Dictionary<string, FirebaseApp>();

		// Token: 0x04000046 RID: 70
		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy = new Dictionary<IntPtr, FirebaseApp>();

		// Token: 0x04000047 RID: 71
		private static bool AppUtilCallbacksInitialized = false;

		// Token: 0x04000048 RID: 72
		private static object AppUtilCallbacksLock = new object();

		// Token: 0x04000049 RID: 73
		private static bool PreventOnAllAppsDestroyed = false;

		// Token: 0x0400004A RID: 74
		private static bool crashlyticsInitializationAttempted = false;

		// Token: 0x0400004B RID: 75
		private static bool userAgentRegistered = false;

		// Token: 0x0400004C RID: 76
		private const int CheckDependenciesNoThread = -1;

		// Token: 0x0400004D RID: 77
		private const int CheckDependenciesPendingThread = -2;

		// Token: 0x0400004E RID: 78
		private static int CheckDependenciesThread = -1;

		// Token: 0x0400004F RID: 79
		private static object CheckDependenciesThreadLock = new object();

		// Token: 0x04000050 RID: 80
		private FirebaseAppPlatform appPlatform = null;

		// Token: 0x0200002E RID: 46
		public class EnableModuleParams
		{
			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060002CF RID: 719 RVA: 0x00008FD8 File Offset: 0x000071D8
			// (set) Token: 0x060002D0 RID: 720 RVA: 0x00008FE0 File Offset: 0x000071E0
			public string CppModuleName { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x00008FE9 File Offset: 0x000071E9
			// (set) Token: 0x060002D2 RID: 722 RVA: 0x00008FF1 File Offset: 0x000071F1
			public string CSharpClassName { get; set; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x00008FFA File Offset: 0x000071FA
			// (set) Token: 0x060002D4 RID: 724 RVA: 0x00009002 File Offset: 0x00007202
			public bool AlwaysEnable { get; set; }

			// Token: 0x060002D5 RID: 725 RVA: 0x0000900B File Offset: 0x0000720B
			public EnableModuleParams(string csharp, string cpp, bool always = false)
			{
				this.CSharpClassName = csharp;
				this.CppModuleName = cpp;
				this.AlwaysEnable = always;
			}
		}

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060002D7 RID: 727
		private delegate FirebaseApp CreateDelegate();
	}
}
