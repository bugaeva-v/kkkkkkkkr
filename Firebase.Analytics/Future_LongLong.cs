using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Analytics
{
	// Token: 0x02000006 RID: 6
	internal class Future_LongLong : FutureBase
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000026B2 File Offset: 0x000008B2
		internal Future_LongLong(IntPtr cPtr, bool cMemoryOwn) : base(FirebaseAnalyticsInternalPINVOKE.Future_LongLong_SWIGUpcast(cPtr), cMemoryOwn)
		{
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026E4 File Offset: 0x000008E4
		internal static HandleRef getCPtr(Future_LongLong obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000270C File Offset: 0x0000090C
		internal static HandleRef swigRelease(Future_LongLong obj)
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

		// Token: 0x06000023 RID: 35 RVA: 0x00002764 File Offset: 0x00000964
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
						FirebaseAnalyticsInternalPINVOKE.delete_Future_LongLong(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002808 File Offset: 0x00000A08
		public static Task<long> GetTask(Future_LongLong fu)
		{
			TaskCompletionSource<long> tcs = new TaskCompletionSource<long>();
			bool pending = FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Pending;
			Task<long> task;
			if (pending)
			{
				tcs.SetException(FirebaseAnalyticsInternalPINVOKE.SWIGPendingException.Retrieve());
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

		// Token: 0x06000025 RID: 37 RVA: 0x000028B8 File Offset: 0x00000AB8
		private void ThrowIfDisposed()
		{
			bool flag = this.swigCPtr.Handle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentNullException("Object is disposed");
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000028EC File Offset: 0x00000AEC
		public void SetOnCompletionCallback(Future_LongLong.Action userCompletionCallback)
		{
			this.ThrowIfDisposed();
			bool flag = this.SWIG_CompletionCB == null;
			if (flag)
			{
				this.SWIG_CompletionCB = new Future_LongLong.SWIG_CompletionDelegate(Future_LongLong.SWIG_CompletionDispatcher);
			}
			object callbackLock = Future_LongLong.CallbackLock;
			int num;
			lock (callbackLock)
			{
				bool flag3 = Future_LongLong.Callbacks == null;
				if (flag3)
				{
					Future_LongLong.Callbacks = new Dictionary<int, Future_LongLong.Action>();
				}
				num = ++Future_LongLong.CallbackIndex;
				Future_LongLong.Callbacks[num] = userCompletionCallback;
			}
			this.SetCompletionData(this.SWIG_OnCompletion(this.SWIG_CompletionCB, num));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000299C File Offset: 0x00000B9C
		private void SetCompletionData(IntPtr data)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle == IntPtr.Zero;
				if (flag2)
				{
					Future_LongLong.SWIG_FreeCompletionData(data);
				}
				else
				{
					Future_LongLong.SWIG_FreeCompletionData(this.callbackData);
					this.callbackData = data;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A14 File Offset: 0x00000C14
		[MonoPInvokeCallback(typeof(Future_LongLong.SWIG_CompletionDelegate))]
		private static void SWIG_CompletionDispatcher(int key)
		{
			Future_LongLong.Action action = null;
			object callbackLock = Future_LongLong.CallbackLock;
			lock (callbackLock)
			{
				bool flag2 = Future_LongLong.Callbacks != null && Future_LongLong.Callbacks.TryGetValue(key, out action);
				if (flag2)
				{
					Future_LongLong.Callbacks.Remove(key);
				}
			}
			bool flag3 = action != null;
			if (flag3)
			{
				action();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002A90 File Offset: 0x00000C90
		public Future_LongLong() : this(FirebaseAnalyticsInternalPINVOKE.new_Future_LongLong(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal IntPtr SWIG_OnCompletion(Future_LongLong.SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			IntPtr result = FirebaseAnalyticsInternalPINVOKE.Future_LongLong_SWIG_OnCompletion(this.swigCPtr, cs_callback, cs_key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002AEC File Offset: 0x00000CEC
		public static void SWIG_FreeCompletionData(IntPtr data)
		{
			FirebaseAnalyticsInternalPINVOKE.Future_LongLong_SWIG_FreeCompletionData(data);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002B10 File Offset: 0x00000D10
		public long GetResult()
		{
			long result = FirebaseAnalyticsInternalPINVOKE.Future_LongLong_GetResult(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000075 RID: 117
		private HandleRef swigCPtr;

		// Token: 0x04000076 RID: 118
		private static Dictionary<int, Future_LongLong.Action> Callbacks;

		// Token: 0x04000077 RID: 119
		private static int CallbackIndex = 0;

		// Token: 0x04000078 RID: 120
		private static object CallbackLock = new object();

		// Token: 0x04000079 RID: 121
		private IntPtr callbackData = IntPtr.Zero;

		// Token: 0x0400007A RID: 122
		private Future_LongLong.SWIG_CompletionDelegate SWIG_CompletionCB = null;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000090 RID: 144
		public delegate void Action();

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000094 RID: 148
		internal delegate void SWIG_CompletionDelegate(int index);
	}
}
