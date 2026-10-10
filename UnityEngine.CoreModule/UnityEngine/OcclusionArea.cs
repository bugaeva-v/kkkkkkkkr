using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000151 RID: 337
	[NativeHeader("Runtime/Camera/OcclusionArea.h")]
	public sealed class OcclusionArea : Component
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00012B50 File Offset: 0x00010D50
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00012B66 File Offset: 0x00010D66
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.get_center_Injected(out result);
				return result;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00012B70 File Offset: 0x00010D70
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00012B86 File Offset: 0x00010D86
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.get_size_Injected(out result);
				return result;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06000E23 RID: 3619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_center_Injected(out Vector3 ret);

		// Token: 0x06000E24 RID: 3620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_center_Injected(ref Vector3 value);

		// Token: 0x06000E25 RID: 3621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_size_Injected(out Vector3 ret);

		// Token: 0x06000E26 RID: 3622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_size_Injected(ref Vector3 value);
	}
}
