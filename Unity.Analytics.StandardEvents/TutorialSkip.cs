using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000032 RID: 50
	[StandardEventName("tutorial_skip", "Onboarding", "Send this event when the player opts to skip a tutorial.")]
	public struct TutorialSkip
	{
		// Token: 0x040000EB RID: 235
		[OptionalParameter("tutorial_id", "The tutorial name or ID.")]
		public string tutorialId;
	}
}
