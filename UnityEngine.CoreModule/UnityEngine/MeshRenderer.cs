using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000196 RID: 406
	[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
	public class MeshRenderer : Renderer
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00004563 File Offset: 0x00002763
		[RequiredByNativeCode]
		private void DontStripMeshRenderer()
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EEB RID: 3819
		// (set) Token: 0x06000EEC RID: 3820
		public extern Mesh additionalVertexStreams { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EED RID: 3821
		// (set) Token: 0x06000EEE RID: 3822
		public extern Mesh enlightenVertexStream { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EEF RID: 3823
		public extern int subMeshStartIndex { [NativeName("GetSubMeshStartIndex")] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
