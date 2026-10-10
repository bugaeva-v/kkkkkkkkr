using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000014 RID: 20
	[StandardEventName("achievement_step", "Engagement", "Send this event when a requirement or step toward completing a multi-part achievement is complete.")]
	public struct AchievementStep
	{
		// Token: 0x040000A3 RID: 163
		[RequiredParameter("step_index", "The order of the step.", null)]
		public int stepIndex;

		// Token: 0x040000A4 RID: 164
		[RequiredParameter("achievement_id", "A unique id for this achievement.", null)]
		public string achievementId;
	}
}
