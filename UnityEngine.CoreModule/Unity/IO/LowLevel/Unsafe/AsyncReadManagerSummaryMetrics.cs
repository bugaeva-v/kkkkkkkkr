using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000083 RID: 131
	[NativeConditional("ENABLE_PROFILER")]
	[NativeAsStruct]
	[StructLayout(LayoutKind.Sequential)]
	public class AsyncReadManagerSummaryMetrics
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000040B5 File Offset: 0x000022B5
		[NativeName("totalBytesRead")]
		public ulong TotalBytesRead { get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000040BD File Offset: 0x000022BD
		[NativeName("averageBandwidthMBPerSecond")]
		public float AverageBandwidthMBPerSecond { get; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000040C5 File Offset: 0x000022C5
		[NativeName("averageReadSizeInBytes")]
		public float AverageReadSizeInBytes { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000040CD File Offset: 0x000022CD
		[NativeName("averageWaitTimeMicroseconds")]
		public float AverageWaitTimeMicroseconds { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000040D5 File Offset: 0x000022D5
		[NativeName("averageReadTimeMicroseconds")]
		public float AverageReadTimeMicroseconds { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000040DD File Offset: 0x000022DD
		[NativeName("averageTotalRequestTimeMicroseconds")]
		public float AverageTotalRequestTimeMicroseconds { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000040E5 File Offset: 0x000022E5
		[NativeName("averageThroughputMBPerSecond")]
		public float AverageThroughputMBPerSecond { get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000040ED File Offset: 0x000022ED
		[NativeName("longestWaitTimeMicroseconds")]
		public float LongestWaitTimeMicroseconds { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000040F5 File Offset: 0x000022F5
		[NativeName("longestReadTimeMicroseconds")]
		public float LongestReadTimeMicroseconds { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000040FD File Offset: 0x000022FD
		[NativeName("longestReadAssetType")]
		public ulong LongestReadAssetType { get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00004105 File Offset: 0x00002305
		[NativeName("longestWaitAssetType")]
		public ulong LongestWaitAssetType { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000410D File Offset: 0x0000230D
		[NativeName("longestReadSubsystem")]
		public AssetLoadingSubsystem LongestReadSubsystem { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00004115 File Offset: 0x00002315
		[NativeName("longestWaitSubsystem")]
		public AssetLoadingSubsystem LongestWaitSubsystem { get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000411D File Offset: 0x0000231D
		[NativeName("numberOfInProgressRequests")]
		public int NumberOfInProgressRequests { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00004125 File Offset: 0x00002325
		[NativeName("numberOfCompletedRequests")]
		public int NumberOfCompletedRequests { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000412D File Offset: 0x0000232D
		[NativeName("numberOfFailedRequests")]
		public int NumberOfFailedRequests { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00004135 File Offset: 0x00002335
		[NativeName("numberOfWaitingRequests")]
		public int NumberOfWaitingRequests { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000413D File Offset: 0x0000233D
		[NativeName("numberOfCanceledRequests")]
		public int NumberOfCanceledRequests { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00004145 File Offset: 0x00002345
		[NativeName("totalNumberOfRequests")]
		public int TotalNumberOfRequests { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000414D File Offset: 0x0000234D
		[NativeName("numberOfCachedReads")]
		public int NumberOfCachedReads { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00004155 File Offset: 0x00002355
		[NativeName("numberOfAsyncReads")]
		public int NumberOfAsyncReads { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000415D File Offset: 0x0000235D
		[NativeName("numberOfSyncReads")]
		public int NumberOfSyncReads { get; }
	}
}
