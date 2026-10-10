using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000079 RID: 121
	public interface IRetryPolicyInformation
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000232 RID: 562
		int NumberOfAttempts { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000233 RID: 563
		float TimeSinceFirstAttempt { get; }
	}
}
