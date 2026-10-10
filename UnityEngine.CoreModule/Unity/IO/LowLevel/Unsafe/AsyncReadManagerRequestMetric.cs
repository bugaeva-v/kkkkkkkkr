using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000080 RID: 128
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	public struct AsyncReadManagerRequestMetric
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00003EF4 File Offset: 0x000020F4
		[NativeName("assetName")]
		public readonly string AssetName { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00003EFC File Offset: 0x000020FC
		[NativeName("fileName")]
		public readonly string FileName { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00003F04 File Offset: 0x00002104
		[NativeName("offsetBytes")]
		public readonly ulong OffsetBytes { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00003F0C File Offset: 0x0000210C
		[NativeName("sizeBytes")]
		public readonly ulong SizeBytes { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00003F14 File Offset: 0x00002114
		[NativeName("assetTypeId")]
		public readonly ulong AssetTypeId { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00003F1C File Offset: 0x0000211C
		[NativeName("currentBytesRead")]
		public readonly ulong CurrentBytesRead { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00003F24 File Offset: 0x00002124
		[NativeName("batchReadCount")]
		public readonly uint BatchReadCount { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00003F2C File Offset: 0x0000212C
		[NativeName("isBatchRead")]
		public readonly bool IsBatchRead { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00003F34 File Offset: 0x00002134
		[NativeName("state")]
		public readonly ProcessingState State { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00003F3C File Offset: 0x0000213C
		[NativeName("readType")]
		public readonly FileReadType ReadType { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00003F44 File Offset: 0x00002144
		[NativeName("priorityLevel")]
		public readonly Priority PriorityLevel { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00003F4C File Offset: 0x0000214C
		[NativeName("subsystem")]
		public readonly AssetLoadingSubsystem Subsystem { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00003F54 File Offset: 0x00002154
		[NativeName("requestTimeMicroseconds")]
		public readonly double RequestTimeMicroseconds { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00003F5C File Offset: 0x0000215C
		[NativeName("timeInQueueMicroseconds")]
		public readonly double TimeInQueueMicroseconds { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00003F64 File Offset: 0x00002164
		[NativeName("totalTimeMicroseconds")]
		public readonly double TotalTimeMicroseconds { get; }
	}
}
