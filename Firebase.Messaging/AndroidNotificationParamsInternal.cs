using System;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	// Token: 0x0200000A RID: 10
	internal class AndroidNotificationParamsInternal : IDisposable
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000027A2 File Offset: 0x000009A2
		internal AndroidNotificationParamsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000027C0 File Offset: 0x000009C0
		internal static HandleRef getCPtr(AndroidNotificationParamsInternal obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000027E8 File Offset: 0x000009E8
		internal static HandleRef swigRelease(AndroidNotificationParamsInternal obj)
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

		// Token: 0x06000069 RID: 105 RVA: 0x00002840 File Offset: 0x00000A40
		~AndroidNotificationParamsInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002874 File Offset: 0x00000A74
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002888 File Offset: 0x00000A88
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
						FirebaseMessagingInternalPINVOKE.delete_AndroidNotificationParamsInternal(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002918 File Offset: 0x00000B18
		public string channel_id
		{
			get
			{
				string result = FirebaseMessagingInternalPINVOKE.AndroidNotificationParamsInternal_channel_id_get(this.swigCPtr);
				bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
				if (pending)
				{
					throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002948 File Offset: 0x00000B48
		internal AndroidNotificationParamsInternal() : this(FirebaseMessagingInternalPINVOKE.new_AndroidNotificationParamsInternal(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x04000022 RID: 34
		private HandleRef swigCPtr;

		// Token: 0x04000023 RID: 35
		protected bool swigCMemOwn;
	}
}
