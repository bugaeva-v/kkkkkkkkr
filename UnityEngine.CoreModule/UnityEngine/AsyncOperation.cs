using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001ED RID: 493
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06001648 RID: 5704
		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalDestroy(IntPtr ptr);

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001649 RID: 5705
		public extern bool isDone { [NativeMethod("IsDone")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600164A RID: 5706
		public extern float progress { [NativeMethod("GetProgress")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600164B RID: 5707
		// (set) Token: 0x0600164C RID: 5708
		public extern int priority { [NativeMethod("GetPriority")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetPriority")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600164D RID: 5709
		// (set) Token: 0x0600164E RID: 5710
		public extern bool allowSceneActivation { [NativeMethod("GetAllowSceneActivation")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetAllowSceneActivation")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600164F RID: 5711 RVA: 0x00023AFC File Offset: 0x00021CFC
		~AsyncOperation()
		{
			AsyncOperation.InternalDestroy(this.m_Ptr);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00023B34 File Offset: 0x00021D34
		[RequiredByNativeCode]
		internal void InvokeCompletionEvent()
		{
			bool flag = this.m_completeCallback != null;
			if (flag)
			{
				this.m_completeCallback(this);
				this.m_completeCallback = null;
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001651 RID: 5713 RVA: 0x00023B68 File Offset: 0x00021D68
		// (remove) Token: 0x06001652 RID: 5714 RVA: 0x00023BA5 File Offset: 0x00021DA5
		public event Action<AsyncOperation> completed
		{
			add
			{
				bool isDone = this.isDone;
				if (isDone)
				{
					value(this);
				}
				else
				{
					this.m_completeCallback = (Action<AsyncOperation>)Delegate.Combine(this.m_completeCallback, value);
				}
			}
			remove
			{
				this.m_completeCallback = (Action<AsyncOperation>)Delegate.Remove(this.m_completeCallback, value);
			}
		}

		// Token: 0x040007CE RID: 1998
		internal IntPtr m_Ptr;

		// Token: 0x040007CF RID: 1999
		private Action<AsyncOperation> m_completeCallback;
	}
}
