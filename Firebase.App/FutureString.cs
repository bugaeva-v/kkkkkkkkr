using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase
{
	// Token: 0x0200000F RID: 15
	internal class FutureString : FutureBase
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0000449F File Offset: 0x0000269F
		internal FutureString(IntPtr cPtr, bool cMemoryOwn) : base(AppUtilPINVOKE.FutureString_SWIGUpcast(cPtr), cMemoryOwn)
		{
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000044D0 File Offset: 0x000026D0
		internal static HandleRef getCPtr(FutureString obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000044F8 File Offset: 0x000026F8
		internal static HandleRef swigRelease(FutureString obj)
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

		// Token: 0x060000C9 RID: 201 RVA: 0x00004550 File Offset: 0x00002750
		public override void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					this.SetCompletionData(IntPtr.Zero);
					bool swigCMemOwn = this.swigCMemOwn;
					if (swigCMemOwn)
					{
						this.swigCMemOwn = false;
						AppUtilPINVOKE.delete_FutureString(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000045F4 File Offset: 0x000027F4
		public static Task<string> GetTask(FutureString fu)
		{
			TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			Task<string> task;
			if (pending)
			{
				tcs.SetException(AppUtilPINVOKE.SWIGPendingException.Retrieve());
				task = tcs.Task;
			}
			else
			{
				bool flag = fu.status() == FutureStatus.Invalid;
				if (flag)
				{
					tcs.SetException(new FirebaseException(0, "Asynchronous operation was not started."));
					task = tcs.Task;
				}
				else
				{
					fu.SetOnCompletionCallback(delegate
					{
						try
						{
							bool flag2 = fu.status() == FutureStatus.Invalid;
							if (flag2)
							{
								tcs.SetCanceled();
							}
							else
							{
								int num = fu.error();
								bool flag3 = num != 0;
								if (flag3)
								{
									tcs.SetException(new FirebaseException(num, fu.error_message()));
								}
								else
								{
									tcs.SetResult(fu.GetResult());
								}
							}
						}
						catch (Exception arg)
						{
							LogUtil.LogMessage(LogLevel.Error, string.Format("Internal error while completing task {0}", arg));
						}
						fu.Dispose();
					});
					task = tcs.Task;
				}
			}
			return task;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000046A4 File Offset: 0x000028A4
		private void ThrowIfDisposed()
		{
			bool flag = this.swigCPtr.Handle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentNullException("Object is disposed");
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000046D8 File Offset: 0x000028D8
		public void SetOnCompletionCallback(FutureString.Action userCompletionCallback)
		{
			this.ThrowIfDisposed();
			bool flag = this.SWIG_CompletionCB == null;
			if (flag)
			{
				this.SWIG_CompletionCB = new FutureString.SWIG_CompletionDelegate(FutureString.SWIG_CompletionDispatcher);
			}
			object callbackLock = FutureString.CallbackLock;
			int num;
			lock (callbackLock)
			{
				bool flag3 = FutureString.Callbacks == null;
				if (flag3)
				{
					FutureString.Callbacks = new Dictionary<int, FutureString.Action>();
				}
				num = ++FutureString.CallbackIndex;
				FutureString.Callbacks[num] = userCompletionCallback;
			}
			this.SetCompletionData(this.SWIG_OnCompletion(this.SWIG_CompletionCB, num));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004788 File Offset: 0x00002988
		private void SetCompletionData(IntPtr data)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle == IntPtr.Zero;
				if (flag2)
				{
					FutureString.SWIG_FreeCompletionData(data);
				}
				else
				{
					FutureString.SWIG_FreeCompletionData(this.callbackData);
					this.callbackData = data;
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004800 File Offset: 0x00002A00
		[MonoPInvokeCallback(typeof(FutureString.SWIG_CompletionDelegate))]
		private static void SWIG_CompletionDispatcher(int key)
		{
			FutureString.Action action = null;
			object callbackLock = FutureString.CallbackLock;
			lock (callbackLock)
			{
				bool flag2 = FutureString.Callbacks != null && FutureString.Callbacks.TryGetValue(key, out action);
				if (flag2)
				{
					FutureString.Callbacks.Remove(key);
				}
			}
			bool flag3 = action != null;
			if (flag3)
			{
				action();
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000487C File Offset: 0x00002A7C
		public FutureString() : this(AppUtilPINVOKE.new_FutureString(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000048A8 File Offset: 0x00002AA8
		internal IntPtr SWIG_OnCompletion(FutureString.SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			IntPtr result = AppUtilPINVOKE.FutureString_SWIG_OnCompletion(this.swigCPtr, cs_callback, cs_key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000048D8 File Offset: 0x00002AD8
		public static void SWIG_FreeCompletionData(IntPtr data)
		{
			AppUtilPINVOKE.FutureString_SWIG_FreeCompletionData(data);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000048FC File Offset: 0x00002AFC
		public string GetResult()
		{
			string result = AppUtilPINVOKE.FutureString_GetResult(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000029 RID: 41
		private HandleRef swigCPtr;

		// Token: 0x0400002A RID: 42
		private static Dictionary<int, FutureString.Action> Callbacks;

		// Token: 0x0400002B RID: 43
		private static int CallbackIndex = 0;

		// Token: 0x0400002C RID: 44
		private static object CallbackLock = new object();

		// Token: 0x0400002D RID: 45
		private IntPtr callbackData = IntPtr.Zero;

		// Token: 0x0400002E RID: 46
		private FutureString.SWIG_CompletionDelegate SWIG_CompletionCB = null;

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060002B2 RID: 690
		public delegate void Action();

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060002B6 RID: 694
		internal delegate void SWIG_CompletionDelegate(int index);
	}
}
