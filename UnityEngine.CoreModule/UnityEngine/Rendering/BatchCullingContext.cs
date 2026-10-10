using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020003EB RID: 1003
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	public struct BatchCullingContext
	{
		// Token: 0x060021E0 RID: 8672 RVA: 0x00037F28 File Offset: 0x00036128
		[Obsolete("For internal BatchRendererGroup use only")]
		public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters)
		{
			this.cullingPlanes = inCullingPlanes;
			this.batchVisibility = inOutBatchVisibility;
			this.visibleIndices = outVisibleIndices;
			this.visibleIndicesY = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(null, 0, Allocator.Invalid);
			this.lodParameters = inLodParameters;
			this.cullingMatrix = Matrix4x4.identity;
			this.nearPlane = 0f;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00037F78 File Offset: 0x00036178
		[Obsolete("For internal BatchRendererGroup use only")]
		public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
			this.cullingPlanes = inCullingPlanes;
			this.batchVisibility = inOutBatchVisibility;
			this.visibleIndices = outVisibleIndices;
			this.visibleIndicesY = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(null, 0, Allocator.Invalid);
			this.lodParameters = inLodParameters;
			this.cullingMatrix = inCullingMatrix;
			this.nearPlane = inNearPlane;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00037FB7 File Offset: 0x000361B7
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
			this.cullingPlanes = inCullingPlanes;
			this.batchVisibility = inOutBatchVisibility;
			this.visibleIndices = outVisibleIndices;
			this.visibleIndicesY = outVisibleIndicesY;
			this.lodParameters = inLodParameters;
			this.cullingMatrix = inCullingMatrix;
			this.nearPlane = inNearPlane;
		}

		// Token: 0x04000C55 RID: 3157
		public readonly NativeArray<Plane> cullingPlanes;

		// Token: 0x04000C56 RID: 3158
		public NativeArray<BatchVisibility> batchVisibility;

		// Token: 0x04000C57 RID: 3159
		public NativeArray<int> visibleIndices;

		// Token: 0x04000C58 RID: 3160
		public NativeArray<int> visibleIndicesY;

		// Token: 0x04000C59 RID: 3161
		public readonly LODParameters lodParameters;

		// Token: 0x04000C5A RID: 3162
		public readonly Matrix4x4 cullingMatrix;

		// Token: 0x04000C5B RID: 3163
		public readonly float nearPlane;
	}
}
