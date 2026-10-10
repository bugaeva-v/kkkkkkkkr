using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000159 RID: 345
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	public sealed class MeshFilter : Component
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x00004563 File Offset: 0x00002763
		[RequiredByNativeCode]
		private void DontStripMeshFilter()
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000EA9 RID: 3753
		// (set) Token: 0x06000EAA RID: 3754
		public extern Mesh sharedMesh { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000EAB RID: 3755
		// (set) Token: 0x06000EAC RID: 3756
		public extern Mesh mesh { [NativeName("GetInstantiatedMeshFromScript")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetInstantiatedMesh")] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
