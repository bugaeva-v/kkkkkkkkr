using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	// Token: 0x0200000C RID: 12
	internal class FirebaseMessageInternal : IDisposable
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00002DCA File Offset: 0x00000FCA
		internal FirebaseMessageInternal(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002DE8 File Offset: 0x00000FE8
		internal static HandleRef getCPtr(FirebaseMessageInternal obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002E10 File Offset: 0x00001010
		internal static HandleRef swigRelease(FirebaseMessageInternal obj)
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

		// Token: 0x06000085 RID: 133 RVA: 0x00002E68 File Offset: 0x00001068
		~FirebaseMessageInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002E9C File Offset: 0x0000109C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002EB0 File Offset: 0x000010B0
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
						FirebaseMessagingInternalPINVOKE.delete_FirebaseMessageInternal(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002F40 File Offset: 0x00001140
		internal FirebaseMessageInternal() : this(FirebaseMessagingInternalPINVOKE.new_FirebaseMessageInternal(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002F6C File Offset: 0x0000116C
		public string from
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_from_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002F9C File Offset: 0x0000119C
		public string to
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_to_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002FCC File Offset: 0x000011CC
		public string collapse_key
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_collapse_key_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002FFC File Offset: 0x000011FC
		public IDictionary<string, string> data
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_data_get(this.swigCPtr);
				StringStringMap result = (intPtr == IntPtr.Zero) ? null : new StringStringMap(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00003044 File Offset: 0x00001244
		public CharVector raw_data
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_raw_data_get(this.swigCPtr);
				CharVector result = (intPtr == IntPtr.Zero) ? null : new CharVector(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000308C File Offset: 0x0000128C
		public string message_id
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_message_id_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000030BC File Offset: 0x000012BC
		public string message_type
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_message_type_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000030EC File Offset: 0x000012EC
		public string priority
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_priority_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000311C File Offset: 0x0000131C
		public int time_to_live
		{
			get
			{
				int result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_time_to_live_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000314C File Offset: 0x0000134C
		public string error
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_error_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000317C File Offset: 0x0000137C
		public string error_description
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_error_description_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000031AC File Offset: 0x000013AC
		internal FirebaseNotificationInternal notification
		{
			get
			{
				IntPtr intPtr = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_notification_get(this.swigCPtr);
				FirebaseNotificationInternal result = (intPtr == IntPtr.Zero) ? null : new FirebaseNotificationInternal(intPtr, false);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000031F4 File Offset: 0x000013F4
		public bool notification_opened
		{
			get
			{
				bool result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_notification_opened_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003224 File Offset: 0x00001424
		public string link
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_link_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003254 File Offset: 0x00001454
		public string original_priority
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_original_priority_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003284 File Offset: 0x00001484
		public long sent_time
		{
			get
			{
				long result = FirebaseMessagingInternalPINVOKE.FirebaseMessageInternal_sent_time_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x04000026 RID: 38
		private HandleRef swigCPtr;

		// Token: 0x04000027 RID: 39
		protected bool swigCMemOwn;
	}
}
