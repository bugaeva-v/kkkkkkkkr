using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200002D RID: 45
	internal class BufferSystemCalls : IBufferSystemCalls
	{
		// Token: 0x06000120 RID: 288 RVA: 0x000048D4 File Offset: 0x00002AD4
		public string GenerateGuid()
		{
			return Guid.NewGuid().ToString();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000048F4 File Offset: 0x00002AF4
		public DateTime Now()
		{
			return DateTime.Now;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000048FB File Offset: 0x00002AFB
		public TimeSpan GetTimeZoneUtcOffset(DateTime dateTime)
		{
			return TimeZoneInfo.Local.GetUtcOffset(dateTime);
		}
	}
}
