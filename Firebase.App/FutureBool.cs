using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase
{
	// Token: 0x02000011 RID: 17
	internal class FutureBool : FutureBase
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00004DAA File Offset: 0x00002FAA
		internal FutureBool(IntPtr cPtr, bool cMemoryOwn) : base(AppUtilPINVOKE.FutureBool_SWIGUpcast(cPtr), cMemoryOwn)
		{
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004DDC File Offset: 0x00002FDC
		internal static HandleRef getCPtr(FutureBool obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004E04 File Offset: 0x00003004
		internal static HandleRef swigRelease(FutureBool obj)
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

		// Token: 0x060000E4 RID: 228 RVA: 0x00004E5C File Offset: 0x0000305C
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
						AppUtilPINVOKE.delete_FutureBool(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004F00 File Offset: 0x00003100
		public static Task<bool> GetTask(FutureBool fu)
		{
			TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			Task<bool> task;
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

		// Token: 0x060000E6 RID: 230 RVA: 0x00004FB0 File Offset: 0x000031B0
		private void ThrowIfDisposed()
		{
			bool flag = this.swigCPtr.Handle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentNullException("Object is disposed");
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004FE4 File Offset: 0x000031E4
		public void SetOnCompletionCallback(FutureBool.Action userCompletionCallback)
		{
			this.ThrowIfDisposed();
			bool flag = this.SWIG_CompletionCB == null;
			if (flag)
			{
				this.SWIG_CompletionCB = new FutureBool.SWIG_CompletionDelegate(FutureBool.SWIG_CompletionDispatcher);
			}
			object callbackLock = FutureBool.CallbackLock;
			int num;
			lock (callbackLock)
			{
				bool flag3 = FutureBool.Callbacks == null;
				if (flag3)
				{
					FutureBool.Callbacks = new Dictionary<int, FutureBool.Action>();
				}
				num = ++FutureBool.CallbackIndex;
				FutureBool.Callbacks[num] = userCompletionCallback;
			}
			this.SetCompletionData(this.SWIG_OnCompletion(this.SWIG_CompletionCB, num));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005094 File Offset: 0x00003294
		private void SetCompletionData(IntPtr data)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle == IntPtr.Zero;
				if (flag2)
				{
					FutureBool.SWIG_FreeCompletionData(data);
				}
				else
				{
					FutureBool.SWIG_FreeCompletionData(this.callbackData);
					this.callbackData = data;
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000510C File Offset: 0x0000330C
		[MonoPInvokeCallback(typeof(FutureBool.SWIG_CompletionDelegate))]
		private static void SWIG_CompletionDispatcher(int key)
		{
			FutureBool.Action action = null;
			object callbackLock = FutureBool.CallbackLock;
			lock (callbackLock)
			{
				bool flag2 = FutureBool.Callbacks != null && FutureBool.Callbacks.TryGetValue(key, out action);
				if (flag2)
				{
					FutureBool.Callbacks.Remove(key);
				}
			}
			bool flag3 = action != null;
			if (flag3)
			{
				action();
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005188 File Offset: 0x00003388
		public FutureBool() : this(AppUtilPINVOKE.new_FutureBool(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000051B4 File Offset: 0x000033B4
		internal IntPtr SWIG_OnCompletion(FutureBool.SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			IntPtr result = AppUtilPINVOKE.FutureBool_SWIG_OnCompletion(this.swigCPtr, cs_callback, cs_key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000051E4 File Offset: 0x000033E4
		public static void SWIG_FreeCompletionData(IntPtr data)
		{
			AppUtilPINVOKE.FutureBool_SWIG_FreeCompletionData(data);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005208 File Offset: 0x00003408
		public bool GetResult()
		{
			bool result = AppUtilPINVOKE.FutureBool_GetResult(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000035 RID: 53
		private HandleRef swigCPtr;

		// Token: 0x04000036 RID: 54
		private static Dictionary<int, FutureBool.Action> Callbacks;

		// Token: 0x04000037 RID: 55
		private static int CallbackIndex = 0;

		// Token: 0x04000038 RID: 56
		private static object CallbackLock = new object();

		// Token: 0x04000039 RID: 57
		private IntPtr callbackData = IntPtr.Zero;

		// Token: 0x0400003A RID: 58
		private FutureBool.SWIG_CompletionDelegate SWIG_CompletionCB = null;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060002C6 RID: 710
		public delegate void Action();

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060002CA RID: 714
		internal delegate void SWIG_CompletionDelegate(int index);
	}
}
