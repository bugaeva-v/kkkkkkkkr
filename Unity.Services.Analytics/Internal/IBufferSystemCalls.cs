using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200002C RID: 44
	internal interface IBufferSystemCalls
	{
		// Token: 0x0600011D RID: 285
		string GenerateGuid();

		// Token: 0x0600011E RID: 286
		DateTime Now();

		// Token: 0x0600011F RID: 287
		TimeSpan GetTimeZoneUtcOffset(DateTime dateTime);
	}
}
