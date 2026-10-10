using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000103 RID: 259
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	[StructLayout(LayoutKind.Sequential)]
	public class CullingGroup : IDisposable
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x000080F3 File Offset: 0x000062F3
		public CullingGroup()
		{
			this.m_Ptr = CullingGroup.Init(this);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00008110 File Offset: 0x00006310
		protected override void Finalize()
		{
			try
			{
				bool flag = this.m_Ptr != IntPtr.Zero;
				if (flag)
				{
					this.FinalizerFailure();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x060005B8 RID: 1464
		[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DisposeInternal();

		// Token: 0x060005B9 RID: 1465 RVA: 0x00008158 File Offset: 0x00006358
		public void Dispose()
		{
			this.DisposeInternal();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00008170 File Offset: 0x00006370
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00008188 File Offset: 0x00006388
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005BC RID: 1468
		// (set) Token: 0x060005BD RID: 1469
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005BE RID: 1470
		// (set) Token: 0x060005BF RID: 1471
		public extern Camera targetCamera { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060005C0 RID: 1472
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingSpheres([Unmarshalled] BoundingSphere[] array);

		// Token: 0x060005C1 RID: 1473
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingSphereCount(int count);

		// Token: 0x060005C2 RID: 1474
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EraseSwapBack(int index);

		// Token: 0x060005C3 RID: 1475 RVA: 0x00008192 File Offset: 0x00006392
		public static void EraseSwapBack<T>(int index, T[] myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000081AC File Offset: 0x000063AC
		public int QueryIndices(bool visible, int[] result, int firstIndex)
		{
			return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000081CC File Offset: 0x000063CC
		public int QueryIndices(int distanceIndex, int[] result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000081EC File Offset: 0x000063EC
		public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x060005C7 RID: 1479
		[NativeThrows]
		[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, [Unmarshalled] int[] result, int firstIndex);

		// Token: 0x060005C8 RID: 1480
		[FreeFunction("CullingGroup_Bindings::IsVisible", HasExplicitThis = true)]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsVisible(int index);

		// Token: 0x060005C9 RID: 1481
		[NativeThrows]
		[FreeFunction("CullingGroup_Bindings::GetDistance", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetDistance(int index);

		// Token: 0x060005CA RID: 1482
		[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingDistances([Unmarshalled] float[] distances);

		// Token: 0x060005CB RID: 1483 RVA: 0x0000820A File Offset: 0x0000640A
		[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = true)]
		private void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3_Injected(ref point);
		}

		// Token: 0x060005CC RID: 1484
		[NativeMethod("SetDistanceReferenceTransform")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetDistanceReferencePoint_InternalTransform(Transform transform);

		// Token: 0x060005CD RID: 1485 RVA: 0x00008214 File Offset: 0x00006414
		public void SetDistanceReferencePoint(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3(point);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000821F File Offset: 0x0000641F
		public void SetDistanceReferencePoint(Transform transform)
		{
			this.SetDistanceReferencePoint_InternalTransform(transform);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000822C File Offset: 0x0000642C
		[SecuritySafeCritical]
		[RequiredByNativeCode]
		private unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			CullingGroupEvent* ptr = (CullingGroupEvent*)eventsPtr.ToPointer();
			bool flag = cullingGroup.m_OnStateChanged == null;
			if (!flag)
			{
				for (int i = 0; i < count; i++)
				{
					cullingGroup.m_OnStateChanged(ptr[i]);
				}
			}
		}

		// Token: 0x060005D0 RID: 1488
		[FreeFunction("CullingGroup_Bindings::Init")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Init(object scripting);

		// Token: 0x060005D1 RID: 1489
		[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void FinalizerFailure();

		// Token: 0x060005D2 RID: 1490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point);

		// Token: 0x04000372 RID: 882
		internal IntPtr m_Ptr;

		// Token: 0x04000373 RID: 883
		private CullingGroup.StateChanged m_OnStateChanged = null;

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060005D4 RID: 1492
		public delegate void StateChanged(CullingGroupEvent sphere);
	}
}
