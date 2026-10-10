using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	// Token: 0x02000008 RID: 8
	internal class FirebaseAnalyticsInternalPINVOKE
	{
		// Token: 0x06000052 RID: 82
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_ExportFix")]
		public static extern void ExportFix();

		// Token: 0x06000053 RID: 83
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_new_Future_LongLong")]
		public static extern IntPtr new_Future_LongLong();

		// Token: 0x06000054 RID: 84
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_Future_LongLong_SWIG_OnCompletion")]
		public static extern IntPtr Future_LongLong_SWIG_OnCompletion(HandleRef jarg1, Future_LongLong.SWIG_CompletionDelegate jarg2, int jarg3);

		// Token: 0x06000055 RID: 85
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_Future_LongLong_SWIG_FreeCompletionData")]
		public static extern void Future_LongLong_SWIG_FreeCompletionData(IntPtr jarg1);

		// Token: 0x06000056 RID: 86
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_Future_LongLong_GetResult")]
		public static extern long Future_LongLong_GetResult(HandleRef jarg1);

		// Token: 0x06000057 RID: 87
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_delete_Future_LongLong")]
		public static extern void delete_Future_LongLong(HandleRef jarg1);

		// Token: 0x06000058 RID: 88
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_new_IntIntMap__SWIG_0")]
		public static extern IntPtr new_IntIntMap__SWIG_0();

		// Token: 0x06000059 RID: 89
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_new_IntIntMap__SWIG_1")]
		public static extern IntPtr new_IntIntMap__SWIG_1(HandleRef jarg1);

		// Token: 0x0600005A RID: 90
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_size")]
		public static extern uint IntIntMap_size(HandleRef jarg1);

		// Token: 0x0600005B RID: 91
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_empty")]
		public static extern bool IntIntMap_empty(HandleRef jarg1);

		// Token: 0x0600005C RID: 92
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_Clear")]
		public static extern void IntIntMap_Clear(HandleRef jarg1);

		// Token: 0x0600005D RID: 93
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_getitem")]
		public static extern int IntIntMap_getitem(HandleRef jarg1, int jarg2);

		// Token: 0x0600005E RID: 94
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_setitem")]
		public static extern void IntIntMap_setitem(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x0600005F RID: 95
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_ContainsKey")]
		public static extern bool IntIntMap_ContainsKey(HandleRef jarg1, int jarg2);

		// Token: 0x06000060 RID: 96
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_Add")]
		public static extern void IntIntMap_Add(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x06000061 RID: 97
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_Remove")]
		public static extern bool IntIntMap_Remove(HandleRef jarg1, int jarg2);

		// Token: 0x06000062 RID: 98
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_create_iterator_begin")]
		public static extern IntPtr IntIntMap_create_iterator_begin(HandleRef jarg1);

		// Token: 0x06000063 RID: 99
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_get_next_key")]
		public static extern int IntIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x06000064 RID: 100
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_IntIntMap_destroy_iterator")]
		public static extern void IntIntMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x06000065 RID: 101
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_delete_IntIntMap")]
		public static extern void delete_IntIntMap(HandleRef jarg1);

		// Token: 0x06000066 RID: 102
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_SetAnalyticsCollectionEnabled")]
		public static extern void SetAnalyticsCollectionEnabled(bool jarg1);

		// Token: 0x06000067 RID: 103
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_0")]
		public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3);

		// Token: 0x06000068 RID: 104
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_1")]
		public static extern void LogEvent__SWIG_1(string jarg1, string jarg2, double jarg3);

		// Token: 0x06000069 RID: 105
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_2")]
		public static extern void LogEvent__SWIG_2(string jarg1, string jarg2, long jarg3);

		// Token: 0x0600006A RID: 106
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_3")]
		public static extern void LogEvent__SWIG_3(string jarg1, string jarg2, int jarg3);

		// Token: 0x0600006B RID: 107
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_4")]
		public static extern void LogEvent__SWIG_4(string jarg1);

		// Token: 0x0600006C RID: 108
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_InitiateOnDeviceConversionMeasurementWithEmailAddress")]
		public static extern void InitiateOnDeviceConversionMeasurementWithEmailAddress(string jarg1);

		// Token: 0x0600006D RID: 109
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_InitiateOnDeviceConversionMeasurementWithPhoneNumber")]
		public static extern void InitiateOnDeviceConversionMeasurementWithPhoneNumber(string jarg1);

		// Token: 0x0600006E RID: 110
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_InitiateOnDeviceConversionMeasurementWithHashedEmailAddress")]
		public static extern void InitiateOnDeviceConversionMeasurementWithHashedEmailAddress(HandleRef jarg1);

		// Token: 0x0600006F RID: 111
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber")]
		public static extern void InitiateOnDeviceConversionMeasurementWithHashedPhoneNumber(HandleRef jarg1);

		// Token: 0x06000070 RID: 112
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_SetUserProperty")]
		public static extern void SetUserProperty(string jarg1, string jarg2);

		// Token: 0x06000071 RID: 113
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_SetUserId")]
		public static extern void SetUserId(string jarg1);

		// Token: 0x06000072 RID: 114
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_SetSessionTimeoutDuration")]
		public static extern void SetSessionTimeoutDuration(long jarg1);

		// Token: 0x06000073 RID: 115
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_ResetAnalyticsData")]
		public static extern void ResetAnalyticsData();

		// Token: 0x06000074 RID: 116
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_GetAnalyticsInstanceId")]
		public static extern IntPtr GetAnalyticsInstanceId();

		// Token: 0x06000075 RID: 117
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_GetSessionId")]
		public static extern IntPtr GetSessionId();

		// Token: 0x06000076 RID: 118
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_LogEvent__SWIG_5")]
		public static extern void LogEvent__SWIG_5(string jarg1, HandleRef jarg2, HandleRef jarg3);

		// Token: 0x06000077 RID: 119
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_SetConsentWithInts")]
		public static extern void SetConsentWithInts(HandleRef jarg1);

		// Token: 0x06000078 RID: 120
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Analytics_CSharp_Future_LongLong_SWIGUpcast")]
		public static extern IntPtr Future_LongLong_SWIGUpcast(IntPtr jarg1);

		// Token: 0x0400007D RID: 125
		protected static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper();

		// Token: 0x0400007E RID: 126
		protected static FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper swigStringHelper = new FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper();

		// Token: 0x0200000E RID: 14
		protected class SWIGExceptionHelper
		{
			// Token: 0x0600009F RID: 159
			[DllImport("FirebaseCppApp-12_10_1")]
			internal static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);

			// Token: 0x060000A0 RID: 160
			[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "SWIGRegisterExceptionArgumentCallbacks_FirebaseAnalyticsInternal")]
			internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			// Token: 0x060000A1 RID: 161 RVA: 0x000037B3 File Offset: 0x000019B3
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new ApplicationException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000037C7 File Offset: 0x000019C7
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x000037DB File Offset: 0x000019DB
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x000037EF File Offset: 0x000019EF
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00003803 File Offset: 0x00001A03
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00003817 File Offset: 0x00001A17
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000382B File Offset: 0x00001A2B
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new IOException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x0000383F File Offset: 0x00001A3F
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00003853 File Offset: 0x00001A53
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00003867 File Offset: 0x00001A67
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new OverflowException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000AB RID: 171 RVA: 0x0000387B File Offset: 0x00001A7B
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new SystemException(message, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000AC RID: 172 RVA: 0x0000388F File Offset: 0x00001A8F
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000AD RID: 173 RVA: 0x000038A4 File Offset: 0x00001AA4
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
				Exception ex = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
			}

			// Token: 0x060000AE RID: 174 RVA: 0x000038E0 File Offset: 0x00001AE0
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
				Exception ex = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
			}

			// Token: 0x060000AF RID: 175 RVA: 0x0000391C File Offset: 0x00001B1C
			static SWIGExceptionHelper()
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.applicationDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.arithmeticDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.divideByZeroDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.indexOutOfRangeDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.invalidCastDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.invalidOperationDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ioDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.nullReferenceDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.outOfMemoryDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.overflowDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.systemDelegate);
				FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.argumentDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.argumentNullDelegate, FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.argumentOutOfRangeDelegate);
			}

			// Token: 0x04000087 RID: 135
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);

			// Token: 0x04000088 RID: 136
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);

			// Token: 0x04000089 RID: 137
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);

			// Token: 0x0400008A RID: 138
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);

			// Token: 0x0400008B RID: 139
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);

			// Token: 0x0400008C RID: 140
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);

			// Token: 0x0400008D RID: 141
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingIOException);

			// Token: 0x0400008E RID: 142
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);

			// Token: 0x0400008F RID: 143
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);

			// Token: 0x04000090 RID: 144
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);

			// Token: 0x04000091 RID: 145
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

			// Token: 0x04000092 RID: 146
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);

			// Token: 0x04000093 RID: 147
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);

			// Token: 0x04000094 RID: 148
			private static FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);

			// Token: 0x02000011 RID: 17
			// (Invoke) Token: 0x060000BB RID: 187
			public delegate void ExceptionDelegate(string message);

			// Token: 0x02000012 RID: 18
			// (Invoke) Token: 0x060000BF RID: 191
			public delegate void ExceptionArgumentDelegate(string message, string paramName);
		}

		// Token: 0x0200000F RID: 15
		public class SWIGPendingException
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003A6C File Offset: 0x00001C6C
			public static bool Pending
			{
				get
				{
					bool result = false;
					bool flag = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.numExceptionsPending > 0;
					if (flag)
					{
						bool flag2 = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException != null;
						if (flag2)
						{
							result = true;
						}
					}
					return result;
				}
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00003A9C File Offset: 0x00001C9C
			public static void Set(Exception e)
			{
				bool flag = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException != null;
				if (flag)
				{
					throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException.ToString() + ")", e);
				}
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException = e;
				object obj = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.exceptionsLock;
				lock (obj)
				{
					FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.numExceptionsPending++;
				}
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00003B18 File Offset: 0x00001D18
			public static Exception Retrieve()
			{
				Exception result = null;
				bool flag = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.numExceptionsPending > 0;
				if (flag)
				{
					bool flag2 = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException != null;
					if (flag2)
					{
						result = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException;
						FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.pendingException = null;
						object obj = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.exceptionsLock;
						lock (obj)
						{
							FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.numExceptionsPending--;
						}
					}
				}
				return result;
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x00003B98 File Offset: 0x00001D98
			static SWIGPendingException()
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.exceptionsLock = new object();
			}

			// Token: 0x04000095 RID: 149
			[ThreadStatic]
			private static Exception pendingException = null;

			// Token: 0x04000096 RID: 150
			private static int numExceptionsPending = 0;

			// Token: 0x04000097 RID: 151
			private static object exceptionsLock = null;
		}

		// Token: 0x02000010 RID: 16
		protected class SWIGStringHelper
		{
			// Token: 0x060000B6 RID: 182
			[DllImport("FirebaseCppApp-12_10_1")]
			internal static extern void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);

			// Token: 0x060000B7 RID: 183 RVA: 0x00003BB8 File Offset: 0x00001DB8
			[MonoPInvokeCallback(typeof(FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return cString;
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00003BCB File Offset: 0x00001DCB
			static SWIGStringHelper()
			{
				FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGRegisterStringCallback_FirebaseAnalyticsInternal(FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.stringDelegate);
			}

			// Token: 0x04000098 RID: 152
			private static FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate = new FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate(FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.CreateString);

			// Token: 0x02000013 RID: 19
			// (Invoke) Token: 0x060000C3 RID: 195
			public delegate string SWIGStringDelegate(string message);
		}
	}
}
