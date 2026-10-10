using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	// Token: 0x0200000B RID: 11
	internal class FirebaseNotificationInternal : IDisposable
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002972 File Offset: 0x00000B72
		internal FirebaseNotificationInternal(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002990 File Offset: 0x00000B90
		internal static HandleRef getCPtr(FirebaseNotificationInternal obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000029B8 File Offset: 0x00000BB8
		internal static HandleRef swigRelease(FirebaseNotificationInternal obj)
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

		// Token: 0x06000071 RID: 113 RVA: 0x00002A10 File Offset: 0x00000C10
		~FirebaseNotificationInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002A44 File Offset: 0x00000C44
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002A58 File Offset: 0x00000C58
		public virtual void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						this.swigCMemOwn = false;
						FirebaseMessagingInternalPINVOKE.delete_FirebaseNotificationInternal(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002AE8 File Offset: 0x00000CE8
		internal FirebaseNotificationInternal() : this(FirebaseMessagingInternalPINVOKE.new_FirebaseNotificationInternal(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002B14 File Offset: 0x00000D14
		public string title
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_title_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002B44 File Offset: 0x00000D44
		public string body
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_body_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002B74 File Offset: 0x00000D74
		public string icon
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_icon_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public string sound
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_sound_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public string badge
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_badge_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002C04 File Offset: 0x00000E04
		public string tag
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_tag_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002C34 File Offset: 0x00000E34
		public string color
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_color_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002C64 File Offset: 0x00000E64
		public string click_action
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_click_action_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002C94 File Offset: 0x00000E94
		public string body_loc_key
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_body_loc_key_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public IEnumerable<string> body_loc_args
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_body_loc_args_get(this.swigCPtr);
				StringList result = (intPtr == IntPtr.Zero) ? null : new StringList(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002D0C File Offset: 0x00000F0C
		public string title_loc_key
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_title_loc_key_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002D3C File Offset: 0x00000F3C
		public IEnumerable<string> title_loc_args
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_title_loc_args_get(this.swigCPtr);
				StringList result = (intPtr == IntPtr.Zero) ? null : new StringList(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002D84 File Offset: 0x00000F84
		internal AndroidNotificationParamsInternal android
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseNotificationInternal_android_get(this.swigCPtr);
				AndroidNotificationParamsInternal result = (intPtr == IntPtr.Zero) ? null : new AndroidNotificationParamsInternal(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x04000024 RID: 36
		private HandleRef swigCPtr;

		// Token: 0x04000025 RID: 37
		protected bool swigCMemOwn;
	}
}
