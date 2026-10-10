using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000054 RID: 84
	[NullableContext(2)]
	public interface IGoogleOrderInfo
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000162 RID: 354
		// (set) Token: 0x06000163 RID: 355
		string ObfuscatedAccountId { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000164 RID: 356
		// (set) Token: 0x06000165 RID: 357
		string ObfuscatedProfileId { get; set; }
	}
}
