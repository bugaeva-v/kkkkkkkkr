using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x0200000B RID: 11
	internal class FutureBase : IDisposable
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002826 File Offset: 0x00000A26
		internal FutureBase(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002844 File Offset: 0x00000A44
		internal static HandleRef getCPtr(FutureBase obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000286C File Offset: 0x00000A6C
		internal static HandleRef swigRelease(FutureBase obj)
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

		// Token: 0x06000036 RID: 54 RVA: 0x000028C4 File Offset: 0x00000AC4
		~FutureBase()
		{
			this.Dispose(false);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000028F8 File Offset: 0x00000AF8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000290C File Offset: 0x00000B0C
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
						AppUtilPINVOKE.delete_FutureBase(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000299C File Offset: 0x00000B9C
		public FutureBase() : this(AppUtilPINVOKE.new_FutureBase__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000029C8 File Offset: 0x00000BC8
		public FutureBase(FutureBase rhs) : this(AppUtilPINVOKE.new_FutureBase__SWIG_1(FutureBase.getCPtr(rhs)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029F8 File Offset: 0x00000BF8
		public void Release()
		{
			AppUtilPINVOKE.FutureBase_Release(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A24 File Offset: 0x00000C24
		public FutureStatus status()
		{
			FutureStatus result = (FutureStatus)AppUtilPINVOKE.FutureBase_status(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A54 File Offset: 0x00000C54
		public int error()
		{
			int result = AppUtilPINVOKE.FutureBase_error(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A84 File Offset: 0x00000C84
		public string error_message()
		{
			string result = AppUtilPINVOKE.FutureBase_error_message(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000021 RID: 33
		private HandleRef swigCPtr;

		// Token: 0x04000022 RID: 34
		protected bool swigCMemOwn;
	}
}
