using System;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	// Token: 0x0200027E RID: 638
	public struct DebugScreenCapture
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0002CA63 File Offset: 0x0002AC63
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0002CA6B File Offset: 0x0002AC6B
		public NativeArray<byte> rawImageDataReference { readonly get; set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0002CA74 File Offset: 0x0002AC74
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0002CA7C File Offset: 0x0002AC7C
		public TextureFormat imageFormat { readonly get; set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0002CA85 File Offset: 0x0002AC85
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0002CA8D File Offset: 0x0002AC8D
		public int width { readonly get; set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0002CA96 File Offset: 0x0002AC96
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0002CA9E File Offset: 0x0002AC9E
		public int height { readonly get; set; }
	}
}
