using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000033 RID: 51
	[StandardEventName("tutorial_start", "Onboarding", "Send this event when the player starts a tutorial.")]
	public struct TutorialStart
	{
		// Token: 0x040000EC RID: 236
		[OptionalParameter("tutorial_id", "The tutorial name or ID.")]
		public string tutorialId;
	}
}
