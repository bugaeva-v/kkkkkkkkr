using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000081 RID: 129
	public struct RetryPolicyInformation : IRetryPolicyInformation
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000065A3 File Offset: 0x000047A3
		public readonly int NumberOfAttempts { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000065AB File Offset: 0x000047AB
		public readonly float TimeSinceFirstAttempt { get; }

		// Token: 0x06000249 RID: 585 RVA: 0x000065B3 File Offset: 0x000047B3
		internal RetryPolicyInformation(int numberOfAttempts, float timeSinceFirstAttempt)
		{
			this.NumberOfAttempts = numberOfAttempts;
			this.TimeSinceFirstAttempt = timeSinceFirstAttempt;
		}
	}
}
