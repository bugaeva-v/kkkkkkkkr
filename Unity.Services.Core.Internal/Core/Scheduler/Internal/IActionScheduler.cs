using System;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Scheduler.Internal
{
	// Token: 0x02000018 RID: 24
	public interface IActionScheduler : IServiceComponent
	{
		// Token: 0x0600002F RID: 47
		long ScheduleAction(Action action, double delaySeconds = 0.0);

		// Token: 0x06000030 RID: 48
		void CancelAction(long actionId);
	}
}
