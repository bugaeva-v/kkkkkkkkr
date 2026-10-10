using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000015 RID: 21
	[StandardEventName("achievement_unlocked", "Engagement", "Send this event when all requirements to unlock an achievement have been met.")]
	public struct AchievementUnlocked
	{
		// Token: 0x040000A5 RID: 165
		[RequiredParameter("achievement_id", "A unique id for this achievement.", null)]
		public string achievementId;
	}
}
