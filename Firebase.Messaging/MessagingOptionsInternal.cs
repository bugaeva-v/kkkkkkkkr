using System;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	// Token: 0x02000009 RID: 9
	internal class MessagingOptionsInternal : IDisposable
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000025A6 File Offset: 0x000007A6
		internal MessagingOptionsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000025C4 File Offset: 0x000007C4
		internal static HandleRef getCPtr(MessagingOptionsInternal obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000025EC File Offset: 0x000007EC
		internal static HandleRef swigRelease(MessagingOptionsInternal obj)
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

		// Token: 0x06000060 RID: 96 RVA: 0x00002644 File Offset: 0x00000844
		~MessagingOptionsInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002678 File Offset: 0x00000878
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000268C File Offset: 0x0000088C
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
						FirebaseMessagingInternalPINVOKE.delete_MessagingOptionsInternal(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000271C File Offset: 0x0000091C
		internal MessagingOptionsInternal() : this(FirebaseMessagingInternalPINVOKE.new_MessagingOptionsInternal(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002774 File Offset: 0x00000974
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002748 File Offset: 0x00000948
		public bool suppress_notification_permission_prompt
		{
			get
			{
				bool result = FirebaseMessagingInternalPINVOKE.MessagingOptionsInternal_suppress_notification_permission_prompt_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				FirebaseMessagingInternalPINVOKE.MessagingOptionsInternal_suppress_notification_permission_prompt_set(this.swigCPtr, value);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		// Token: 0x04000020 RID: 32
		private HandleRef swigCPtr;

		// Token: 0x04000021 RID: 33
		protected bool swigCMemOwn;
	}
}
