using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase
{
	// Token: 0x02000010 RID: 16
	internal class FutureVoid : FutureBase
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x0000493C File Offset: 0x00002B3C
		internal FutureVoid(IntPtr cPtr, bool cMemoryOwn) : base(AppUtilPINVOKE.FutureVoid_SWIGUpcast(cPtr), cMemoryOwn)
		{
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000496C File Offset: 0x00002B6C
		internal static HandleRef getCPtr(FutureVoid obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004994 File Offset: 0x00002B94
		internal static HandleRef swigRelease(FutureVoid obj)
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

		// Token: 0x060000D7 RID: 215 RVA: 0x000049EC File Offset: 0x00002BEC
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
						AppUtilPINVOKE.delete_FutureVoid(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004A90 File Offset: 0x00002C90
		public static Task GetTask(FutureVoid fu)
		{
			TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			Task task;
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
									tcs.SetResult(0);
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

		// Token: 0x060000D9 RID: 217 RVA: 0x00004B40 File Offset: 0x00002D40
		private void ThrowIfDisposed()
		{
			bool flag = this.swigCPtr.Handle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentNullException("Object is disposed");
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004B74 File Offset: 0x00002D74
		public void SetOnCompletionCallback(FutureVoid.Action userCompletionCallback)
		{
			this.ThrowIfDisposed();
			bool flag = this.SWIG_CompletionCB == null;
			if (flag)
			{
				this.SWIG_CompletionCB = new FutureVoid.SWIG_CompletionDelegate(FutureVoid.SWIG_CompletionDispatcher);
			}
			object callbackLock = FutureVoid.CallbackLock;
			int num;
			lock (callbackLock)
			{
				bool flag3 = FutureVoid.Callbacks == null;
				if (flag3)
				{
					FutureVoid.Callbacks = new Dictionary<int, FutureVoid.Action>();
				}
				num = ++FutureVoid.CallbackIndex;
				FutureVoid.Callbacks[num] = userCompletionCallback;
			}
			this.SetCompletionData(this.SWIG_OnCompletion(this.SWIG_CompletionCB, num));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004C24 File Offset: 0x00002E24
		private void SetCompletionData(IntPtr data)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle == IntPtr.Zero;
				if (flag2)
				{
					FutureVoid.SWIG_FreeCompletionData(data);
				}
				else
				{
					FutureVoid.SWIG_FreeCompletionData(this.callbackData);
					this.callbackData = data;
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004C9C File Offset: 0x00002E9C
		[MonoPInvokeCallback(typeof(FutureVoid.SWIG_CompletionDelegate))]
		private static void SWIG_CompletionDispatcher(int key)
		{
			FutureVoid.Action action = null;
			object callbackLock = FutureVoid.CallbackLock;
			lock (callbackLock)
			{
				bool flag2 = FutureVoid.Callbacks != null && FutureVoid.Callbacks.TryGetValue(key, out action);
				if (flag2)
				{
					FutureVoid.Callbacks.Remove(key);
				}
			}
			bool flag3 = action != null;
			if (flag3)
			{
				action();
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004D18 File Offset: 0x00002F18
		public FutureVoid() : this(AppUtilPINVOKE.new_FutureVoid(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004D44 File Offset: 0x00002F44
		internal IntPtr SWIG_OnCompletion(FutureVoid.SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			IntPtr result = AppUtilPINVOKE.FutureVoid_SWIG_OnCompletion(this.swigCPtr, cs_callback, cs_key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004D74 File Offset: 0x00002F74
		public static void SWIG_FreeCompletionData(IntPtr data)
		{
			AppUtilPINVOKE.FutureVoid_SWIG_FreeCompletionData(data);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0400002F RID: 47
		private HandleRef swigCPtr;

		// Token: 0x04000030 RID: 48
		private static Dictionary<int, FutureVoid.Action> Callbacks;

		// Token: 0x04000031 RID: 49
		private static int CallbackIndex = 0;

		// Token: 0x04000032 RID: 50
		private static object CallbackLock = new object();

		// Token: 0x04000033 RID: 51
		private IntPtr callbackData = IntPtr.Zero;

		// Token: 0x04000034 RID: 52
		private FutureVoid.SWIG_CompletionDelegate SWIG_CompletionCB = null;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060002BC RID: 700
		public delegate void Action();

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060002C0 RID: 704
		internal delegate void SWIG_CompletionDelegate(int index);
	}
}
