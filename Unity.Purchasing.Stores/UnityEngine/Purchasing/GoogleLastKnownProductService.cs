using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000012 RID: 18
	[NullableContext(2)]
	[Nullable(0)]
	[Preserve]
	internal class GoogleLastKnownProductService : IGoogleLastKnownProductService
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000029A7 File Offset: 0x00000BA7
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000029AF File Offset: 0x00000BAF
		public string LastKnownOldProductId { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000029C0 File Offset: 0x00000BC0
		public string LastKnownProductId { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000029C9 File Offset: 0x00000BC9
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000029D1 File Offset: 0x00000BD1
		public GooglePlayReplacementMode? LastKnownReplacementMode { get; set; } = new GooglePlayReplacementMode?(GooglePlayReplacementMode.UnknownReplacementMode);
	}
}
