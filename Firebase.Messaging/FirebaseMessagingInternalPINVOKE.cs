using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	// Token: 0x0200000E RID: 14
	internal class FirebaseMessagingInternalPINVOKE
	{
		// Token: 0x0600009A RID: 154
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_ExportFix")]
		public static extern void ExportFix();

		// Token: 0x0600009B RID: 155
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_new_MessagingOptionsInternal")]
		internal static extern IntPtr new_MessagingOptionsInternal();

		// Token: 0x0600009C RID: 156
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_MessagingOptionsInternal_suppress_notification_permission_prompt_set")]
		public static extern void MessagingOptionsInternal_suppress_notification_permission_prompt_set(HandleRef jarg1, bool jarg2);

		// Token: 0x0600009D RID: 157
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_MessagingOptionsInternal_suppress_notification_permission_prompt_get")]
		public static extern bool MessagingOptionsInternal_suppress_notification_permission_prompt_get(HandleRef jarg1);

		// Token: 0x0600009E RID: 158
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_delete_MessagingOptionsInternal")]
		internal static extern void delete_MessagingOptionsInternal(HandleRef jarg1);

		// Token: 0x0600009F RID: 159
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_AndroidNotificationParamsInternal_channel_id_get")]
		public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1);

		// Token: 0x060000A0 RID: 160
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_new_AndroidNotificationParamsInternal")]
		internal static extern IntPtr new_AndroidNotificationParamsInternal();

		// Token: 0x060000A1 RID: 161
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_delete_AndroidNotificationParamsInternal")]
		internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1);

		// Token: 0x060000A2 RID: 162
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_new_FirebaseNotificationInternal")]
		internal static extern IntPtr new_FirebaseNotificationInternal();

		// Token: 0x060000A3 RID: 163
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_delete_FirebaseNotificationInternal")]
		internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1);

		// Token: 0x060000A4 RID: 164
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_title_get")]
		public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1);

		// Token: 0x060000A5 RID: 165
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_body_get")]
		public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1);

		// Token: 0x060000A6 RID: 166
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_icon_get")]
		public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1);

		// Token: 0x060000A7 RID: 167
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_sound_get")]
		public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1);

		// Token: 0x060000A8 RID: 168
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_badge_get")]
		public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1);

		// Token: 0x060000A9 RID: 169
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_tag_get")]
		public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1);

		// Token: 0x060000AA RID: 170
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_color_get")]
		public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1);

		// Token: 0x060000AB RID: 171
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_click_action_get")]
		public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1);

		// Token: 0x060000AC RID: 172
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_body_loc_key_get")]
		public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1);

		// Token: 0x060000AD RID: 173
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_body_loc_args_get")]
		public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1);

		// Token: 0x060000AE RID: 174
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_title_loc_key_get")]
		public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1);

		// Token: 0x060000AF RID: 175
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_title_loc_args_get")]
		public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1);

		// Token: 0x060000B0 RID: 176
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseNotificationInternal_android_get")]
		public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1);

		// Token: 0x060000B1 RID: 177
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_new_FirebaseMessageInternal")]
		internal static extern IntPtr new_FirebaseMessageInternal();

		// Token: 0x060000B2 RID: 178
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_delete_FirebaseMessageInternal")]
		internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1);

		// Token: 0x060000B3 RID: 179
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_from_get")]
		public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1);

		// Token: 0x060000B4 RID: 180
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_to_get")]
		public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1);

		// Token: 0x060000B5 RID: 181
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_collapse_key_get")]
		public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1);

		// Token: 0x060000B6 RID: 182
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_data_get")]
		public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1);

		// Token: 0x060000B7 RID: 183
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_raw_data_get")]
		public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1);

		// Token: 0x060000B8 RID: 184
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_message_id_get")]
		public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1);

		// Token: 0x060000B9 RID: 185
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_message_type_get")]
		public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1);

		// Token: 0x060000BA RID: 186
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_priority_get")]
		public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1);

		// Token: 0x060000BB RID: 187
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_time_to_live_get")]
		public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1);

		// Token: 0x060000BC RID: 188
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_error_get")]
		public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1);

		// Token: 0x060000BD RID: 189
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_error_description_get")]
		public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1);

		// Token: 0x060000BE RID: 190
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_notification_get")]
		public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1);

		// Token: 0x060000BF RID: 191
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_notification_opened_get")]
		public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1);

		// Token: 0x060000C0 RID: 192
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_link_get")]
		public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1);

		// Token: 0x060000C1 RID: 193
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_original_priority_get")]
		public static extern string FirebaseMessageInternal_original_priority_get(HandleRef jarg1);

		// Token: 0x060000C2 RID: 194
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_FirebaseMessageInternal_sent_time_get")]
		public static extern long FirebaseMessageInternal_sent_time_get(HandleRef jarg1);

		// Token: 0x060000C3 RID: 195
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_IsTokenRegistrationOnInitEnabled")]
		public static extern bool IsTokenRegistrationOnInitEnabled();

		// Token: 0x060000C4 RID: 196
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_SetTokenRegistrationOnInitEnabled")]
		public static extern void SetTokenRegistrationOnInitEnabled(bool jarg1);

		// Token: 0x060000C5 RID: 197
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_RequestPermission")]
		public static extern IntPtr RequestPermission();

		// Token: 0x060000C6 RID: 198
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_Subscribe")]
		public static extern IntPtr Subscribe(string jarg1);

		// Token: 0x060000C7 RID: 199
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_Unsubscribe")]
		public static extern IntPtr Unsubscribe(string jarg1);

		// Token: 0x060000C8 RID: 200
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_DeliveryMetricsExportToBigQueryEnabled")]
		public static extern bool DeliveryMetricsExportToBigQueryEnabled();

		// Token: 0x060000C9 RID: 201
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_SetDeliveryMetricsExportToBigQuery")]
		public static extern void SetDeliveryMetricsExportToBigQuery(bool jarg1);

		// Token: 0x060000CA RID: 202
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_GetToken")]
		public static extern IntPtr GetToken();

		// Token: 0x060000CB RID: 203
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_DeleteToken")]
		public static extern IntPtr DeleteToken();

		// Token: 0x060000CC RID: 204
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_SetListenerCallbacks")]
		public static extern void SetListenerCallbacks(FirebaseMessagingInternal.Listener.MessageReceivedDelegate jarg1, FirebaseMessagingInternal.Listener.TokenReceivedDelegate jarg2);

		// Token: 0x060000CD RID: 205
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_SetListenerCallbacksEnabled")]
		public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2);

		// Token: 0x060000CE RID: 206
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_Messaging_CSharp_SendPendingEvents")]
		public static extern void SendPendingEvents();

		// Token: 0x0400002E RID: 46
		protected static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper();

		// Token: 0x0400002F RID: 47
		protected static FirebaseMessagingInternalPINVOKE.SWIGStringHelper swigStringHelper = new FirebaseMessagingInternalPINVOKE.SWIGStringHelper();

		// Token: 0x02000010 RID: 16
		protected class SWIGExceptionHelper
		{
			// Token: 0x060000E9 RID: 233
			[DllImport("FirebaseCppApp-12_10_1")]
			internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);

			// Token: 0x060000EA RID: 234
			[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "SWIGRegisterExceptionArgumentCallbacks_FirebaseMessagingInternal")]
			internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			// Token: 0x060000EB RID: 235 RVA: 0x0000376F File Offset: 0x0000196F
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new ApplicationException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00003783 File Offset: 0x00001983
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00003797 File Offset: 0x00001997
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000EE RID: 238 RVA: 0x000037AB File Offset: 0x000019AB
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000EF RID: 239 RVA: 0x000037BF File Offset: 0x000019BF
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x000037D3 File Offset: 0x000019D3
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000037E7 File Offset: 0x000019E7
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new IOException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x000037FB File Offset: 0x000019FB
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x0000380F File Offset: 0x00001A0F
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00003823 File Offset: 0x00001A23
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new OverflowException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00003837 File Offset: 0x00001A37
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new SystemException(message, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x0000384B File Offset: 0x00001A4B
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00003860 File Offset: 0x00001A60
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
				Exception ex = FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x0000389C File Offset: 0x00001A9C
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
				Exception ex = FirebaseMessagingInternalPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x000038D8 File Offset: 0x00001AD8
			static SWIGExceptionHelper()
			{
				FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.applicationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.arithmeticDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.divideByZeroDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.indexOutOfRangeDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.invalidCastDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.invalidOperationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ioDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.nullReferenceDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.outOfMemoryDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.overflowDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.systemDelegate);
				FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.argumentDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.argumentNullDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.argumentOutOfRangeDelegate);
			}

			// Token: 0x04000033 RID: 51
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);

			// Token: 0x04000034 RID: 52
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);

			// Token: 0x04000035 RID: 53
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);

			// Token: 0x04000036 RID: 54
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);

			// Token: 0x04000037 RID: 55
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);

			// Token: 0x04000038 RID: 56
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);

			// Token: 0x04000039 RID: 57
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingIOException);

			// Token: 0x0400003A RID: 58
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);

			// Token: 0x0400003B RID: 59
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);

			// Token: 0x0400003C RID: 60
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);

			// Token: 0x0400003D RID: 61
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

			// Token: 0x0400003E RID: 62
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);

			// Token: 0x0400003F RID: 63
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);

			// Token: 0x04000040 RID: 64
			private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate = new FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);

			// Token: 0x02000014 RID: 20
			// (Invoke) Token: 0x0600010D RID: 269
			public delegate void ExceptionDelegate(string message);

			// Token: 0x02000015 RID: 21
			// (Invoke) Token: 0x06000111 RID: 273
			public delegate void ExceptionArgumentDelegate(string message, string paramName);
		}

		// Token: 0x02000011 RID: 17
		public class SWIGPendingException
		{
			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00003A28 File Offset: 0x00001C28
			public static bool Pending
			{
				get
				{
					bool result = false;
					bool flag = FirebaseMessagingInternalPINVOKE.SWIGPendingException.numExceptionsPending > 0;
					if (flag)
					{
						bool flag2 = FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException != null;
						if (flag2)
						{
							result = true;
						}
					}
					return result;
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00003A58 File Offset: 0x00001C58
			public static void Set(Exception e)
			{
				bool flag = FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException != null;
				if (flag)
				{
					throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException.ToString() + ")", e);
				}
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException = e;
				object obj = FirebaseMessagingInternalPINVOKE.SWIGPendingException.exceptionsLock;
				lock (obj)
				{
					FirebaseMessagingInternalPINVOKE.SWIGPendingException.numExceptionsPending++;
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00003AD4 File Offset: 0x00001CD4
			public static Exception Retrieve()
			{
				Exception result = null;
				bool flag = FirebaseMessagingInternalPINVOKE.SWIGPendingException.numExceptionsPending > 0;
				if (flag)
				{
					bool flag2 = FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException != null;
					if (flag2)
					{
						result = FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException;
						FirebaseMessagingInternalPINVOKE.SWIGPendingException.pendingException = null;
						object obj = FirebaseMessagingInternalPINVOKE.SWIGPendingException.exceptionsLock;
						lock (obj)
						{
							FirebaseMessagingInternalPINVOKE.SWIGPendingException.numExceptionsPending--;
						}
					}
				}
				return result;
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00003B54 File Offset: 0x00001D54
			static SWIGPendingException()
			{
				FirebaseMessagingInternalPINVOKE.SWIGPendingException.exceptionsLock = new object();
			}

			// Token: 0x04000041 RID: 65
			[ThreadStatic]
			private static Exception pendingException = null;

			// Token: 0x04000042 RID: 66
			private static int numExceptionsPending = 0;

			// Token: 0x04000043 RID: 67
			private static object exceptionsLock = null;
		}

		// Token: 0x02000012 RID: 18
		protected class SWIGStringHelper
		{
			// Token: 0x06000100 RID: 256
			[DllImport("FirebaseCppApp-12_10_1")]
			internal static extern void SWIGRegisterStringCallback_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);

			// Token: 0x06000101 RID: 257 RVA: 0x00003B74 File Offset: 0x00001D74
			[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return cString;
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00003B87 File Offset: 0x00001D87
			static SWIGStringHelper()
			{
				FirebaseMessagingInternalPINVOKE.SWIGStringHelper.SWIGRegisterStringCallback_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGStringHelper.stringDelegate);
			}

			// Token: 0x04000044 RID: 68
			private static FirebaseMessagingInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate = new FirebaseMessagingInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate(FirebaseMessagingInternalPINVOKE.SWIGStringHelper.CreateString);

			// Token: 0x02000016 RID: 22
			// (Invoke) Token: 0x06000115 RID: 277
			public delegate string SWIGStringDelegate(string message);
		}
	}
}
