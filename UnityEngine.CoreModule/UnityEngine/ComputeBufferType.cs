using System;

namespace UnityEngine
{
	// Token: 0x0200015F RID: 351
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x04000450 RID: 1104
		Default = 0,
		// Token: 0x04000451 RID: 1105
		Raw = 1,
		// Token: 0x04000452 RID: 1106
		Append = 2,
		// Token: 0x04000453 RID: 1107
		Counter = 4,
		// Token: 0x04000454 RID: 1108
		Constant = 8,
		// Token: 0x04000455 RID: 1109
		Structured = 16,
		// Token: 0x04000456 RID: 1110
		[Obsolete("Enum member DrawIndirect has been deprecated. Use IndirectArguments instead (UnityUpgradable) -> IndirectArguments", false)]
		DrawIndirect = 256,
		// Token: 0x04000457 RID: 1111
		IndirectArguments = 256,
		// Token: 0x04000458 RID: 1112
		[Obsolete("Enum member GPUMemory has been deprecated. All compute buffers now follow the behavior previously defined by this member.", false)]
		GPUMemory = 512
	}
}
