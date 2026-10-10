using System;
using System.Collections.Concurrent;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000020 RID: 32
	internal abstract class IosNativeObject : IDisposable
	{
		// Token: 0x0600019B RID: 411 RVA: 0x000053C8 File Offset: 0x000035C8
		protected IosNativeObject(bool usesCallbacks)
		{
			this.m_UsesCallbacks = usesCallbacks;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000053D7 File Offset: 0x000035D7
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000053E0 File Offset: 0x000035E0
		public IntPtr NativePtr
		{
			get
			{
				return this.m_NativePtr;
			}
			protected set
			{
				if (this.m_NativePtr == value)
				{
					return;
				}
				if (this.m_UsesCallbacks && this.m_NativePtr != IntPtr.Zero)
				{
					IosNativeObject iosNativeObject;
					IosNativeObject.s_Objects.TryRemove(this.m_NativePtr, out iosNativeObject);
				}
				this.m_NativePtr = value;
				if (this.m_UsesCallbacks && this.m_NativePtr != IntPtr.Zero)
				{
					IosNativeObject.s_Objects.TryAdd(this.m_NativePtr, this);
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000545C File Offset: 0x0000365C
		protected static T Get<T>(IntPtr ptr) where T : IosNativeObject
		{
			IosNativeObject iosNativeObject;
			if (!IosNativeObject.s_Objects.TryGetValue(ptr, out iosNativeObject))
			{
				return default(T);
			}
			return (T)((object)iosNativeObject);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005488 File Offset: 0x00003688
		public virtual void Dispose()
		{
			if (this.NativePtr == IntPtr.Zero)
			{
				return;
			}
			this.NativePtr = IntPtr.Zero;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000054A8 File Offset: 0x000036A8
		protected bool CheckDisposedAndLogError(string message)
		{
			if (this.NativePtr != IntPtr.Zero)
			{
				return false;
			}
			Debug.LogErrorFormat("LevelPlay SDK: {0}: Instance of type {1} is disposed. Please create a new instance in order to call any method.", new object[]
			{
				message,
				base.GetType().FullName
			});
			return true;
		}

		// Token: 0x0400009E RID: 158
		private static ConcurrentDictionary<IntPtr, IosNativeObject> s_Objects = new ConcurrentDictionary<IntPtr, IosNativeObject>();

		// Token: 0x0400009F RID: 159
		private IntPtr m_NativePtr;

		// Token: 0x040000A0 RID: 160
		private readonly bool m_UsesCallbacks;
	}
}
