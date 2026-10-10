using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200019F RID: 415
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshCombiner.h")]
	internal struct StaticBatchingHelper
	{
		// Token: 0x06001093 RID: 4243
		[FreeFunction("MeshScripting::CombineMeshVerticesForStaticBatching")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Mesh InternalCombineVertices(MeshSubsetCombineUtility.MeshInstance[] meshes, string meshName);

		// Token: 0x06001094 RID: 4244
		[FreeFunction("MeshScripting::CombineMeshIndicesForStaticBatching")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalCombineIndices(MeshSubsetCombineUtility.SubMeshInstance[] submeshes, Mesh combinedMesh);

		// Token: 0x06001095 RID: 4245
		[FreeFunction("IsMeshBatchable")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsMeshBatchable(Mesh mesh);
	}
}
