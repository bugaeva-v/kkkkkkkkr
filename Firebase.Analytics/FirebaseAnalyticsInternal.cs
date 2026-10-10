using System;
using System.Threading.Tasks;

namespace Firebase.Analytics
{
	// Token: 0x02000009 RID: 9
	internal static class FirebaseAnalyticsInternal
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000323A File Offset: 0x0000143A
		public static void ExportFix()
		{
			FirebaseAnalyticsInternalPINVOKE.ExportFix();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003250 File Offset: 0x00001450
		private static FirebaseApp App
		{
			get
			{
				return FirebaseAnalyticsInternal.app;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003268 File Offset: 0x00001468
		public static void SetAnalyticsCollectionEnabled(bool enabled)
		{
			FirebaseAnalyticsInternalPINVOKE.SetAnalyticsCollectionEnabled(enabled);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000328C File Offset: 0x0000148C
		public static void LogEvent(string name, string parameterName, string parameterValue)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_0(name, parameterName, parameterValue);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000032B4 File Offset: 0x000014B4
		public static void LogEvent(string name, string parameterName, double parameterValue)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_1(name, parameterName, parameterValue);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000032DC File Offset: 0x000014DC
		public static void LogEvent(string name, string parameterName, long parameterValue)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_2(name, parameterName, parameterValue);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003304 File Offset: 0x00001504
		public static void LogEvent(string name, string parameterName, int parameterValue)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_3(name, parameterName, parameterValue);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000332C File Offset: 0x0000152C
		public static void LogEvent(string name)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_4(name);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003350 File Offset: 0x00001550
		public static void InitiateOnDeviceConversionMeasurementWithEmailAddress(string emailAddress)
		{
			FirebaseAnalyticsInternalPINVOKE.InitiateOnDeviceConversionMeasurementWithEmailAddress(emailAddress);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003374 File Offset: 0x00001574
		public static void InitiateOnDeviceConversionMeasurementWithPhoneNumber(string phoneNumber)
		{
			FirebaseAnalyticsInternalPINVOKE.InitiateOnDeviceConversionMeasurementWithPhoneNumber(phoneNumber);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003398 File Offset: 0x00001598
		public static void InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(CharVector hashedEmailAddress)
		{
			FirebaseAnalyticsInternalPINVOKE.InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(CharVector.getCPtr(hashedEmailAddress));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000033C4 File Offset: 0x000015C4
		public static void InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(CharVector hashedPhoneNumber)
		{
			FirebaseAnalyticsInternalPINVOKE.InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(CharVector.getCPtr(hashedPhoneNumber));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000033F0 File Offset: 0x000015F0
		public static void SetUserProperty(string name, string property)
		{
			FirebaseAnalyticsInternalPINVOKE.SetUserProperty(name, property);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003418 File Offset: 0x00001618
		public static void SetUserId(string userId)
		{
			FirebaseAnalyticsInternalPINVOKE.SetUserId(userId);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000343C File Offset: 0x0000163C
		public static void SetSessionTimeoutDuration(long milliseconds)
		{
			FirebaseAnalyticsInternalPINVOKE.SetSessionTimeoutDuration(milliseconds);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003460 File Offset: 0x00001660
		public static void ResetAnalyticsData()
		{
			FirebaseAnalyticsInternalPINVOKE.ResetAnalyticsData();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003484 File Offset: 0x00001684
		public static Task<string> GetAnalyticsInstanceIdAsync()
		{
			IntPtr analyticsInstanceId = FirebaseAnalyticsInternalPINVOKE.GetAnalyticsInstanceId();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return FutureString.GetTask(new FutureString(analyticsInstanceId, true));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000034B8 File Offset: 0x000016B8
		public static Task<long> GetSessionIdAsync()
		{
			IntPtr sessionId = FirebaseAnalyticsInternalPINVOKE.GetSessionId();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return Future_LongLong.GetTask(new Future_LongLong(sessionId, true));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000034EC File Offset: 0x000016EC
		public static void LogEvent(string name, StringList parameterNames, VariantList parameterValues)
		{
			FirebaseAnalyticsInternalPINVOKE.LogEvent__SWIG_5(name, StringList.getCPtr(parameterNames), VariantList.getCPtr(parameterValues));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000351C File Offset: 0x0000171C
		public static void SetConsentWithInts(IntIntMap settings)
		{
			FirebaseAnalyticsInternalPINVOKE.SetConsentWithInts(IntIntMap.getCPtr(settings));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0400007F RID: 127
		private static FirebaseApp app = FirebaseApp.DefaultInstance;
	}
}
