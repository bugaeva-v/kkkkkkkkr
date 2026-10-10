using System;
using System.Threading.Tasks;

namespace Firebase
{
	// Token: 0x0200001B RID: 27
	internal class AppUtil
	{
		// Token: 0x06000277 RID: 631 RVA: 0x000084CD File Offset: 0x000066CD
		public static void ExportFix()
		{
			AppUtilPINVOKE.ExportFix();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000084D8 File Offset: 0x000066D8
		public static void SetLogLevel(LogLevel level)
		{
			AppUtilPINVOKE.SetLogLevel((int)level);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000084FC File Offset: 0x000066FC
		public static LogLevel GetLogLevel()
		{
			LogLevel logLevel = (LogLevel)AppUtilPINVOKE.GetLogLevel();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return logLevel;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008524 File Offset: 0x00006724
		internal static void PollCallbacks()
		{
			AppUtilPINVOKE.PollCallbacks();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00008548 File Offset: 0x00006748
		internal static void AppEnableLogCallback(bool arg0)
		{
			AppUtilPINVOKE.AppEnableLogCallback(arg0);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000856C File Offset: 0x0000676C
		internal static LogLevel AppGetLogLevel()
		{
			LogLevel result = (LogLevel)AppUtilPINVOKE.AppGetLogLevel();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008594 File Offset: 0x00006794
		internal static void SetEnabledAllAppCallbacks(bool arg0)
		{
			AppUtilPINVOKE.SetEnabledAllAppCallbacks(arg0);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000085B8 File Offset: 0x000067B8
		internal static void SetEnabledAppCallbackByName(string arg0, bool arg1)
		{
			AppUtilPINVOKE.SetEnabledAppCallbackByName(arg0, arg1);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000085E0 File Offset: 0x000067E0
		internal static bool GetEnabledAppCallbackByName(string arg0)
		{
			bool enabledAppCallbackByName = AppUtilPINVOKE.GetEnabledAppCallbackByName(arg0);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return enabledAppCallbackByName;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000860C File Offset: 0x0000680C
		internal static void SetLogFunction(LogUtil.LogMessageDelegate arg0)
		{
			AppUtilPINVOKE.SetLogFunction(arg0);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00008630 File Offset: 0x00006830
		internal static AppOptionsInternal AppOptionsLoadFromJsonConfig(string config)
		{
			IntPtr intPtr = AppUtilPINVOKE.AppOptionsLoadFromJsonConfig(config);
			AppOptionsInternal result = (intPtr == IntPtr.Zero) ? null : new AppOptionsInternal(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008674 File Offset: 0x00006874
		public static GooglePlayServicesAvailability CheckAndroidDependencies()
		{
			GooglePlayServicesAvailability result = (GooglePlayServicesAvailability)AppUtilPINVOKE.CheckAndroidDependencies();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000869C File Offset: 0x0000689C
		public static Task FixAndroidDependenciesAsync()
		{
			return FutureVoid.GetTask(new FutureVoid(AppUtilPINVOKE.FixAndroidDependencies(), true));
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000086C0 File Offset: 0x000068C0
		internal static void InitializePlayServicesInternal()
		{
			AppUtilPINVOKE.InitializePlayServicesInternal();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000086E4 File Offset: 0x000068E4
		internal static void TerminatePlayServicesInternal()
		{
			AppUtilPINVOKE.TerminatePlayServicesInternal();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
