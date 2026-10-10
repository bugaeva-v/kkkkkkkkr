using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000034 RID: 52
	[StandardEventName("tutorial_step", "Onboarding", "Send this event when the player completes a step or stage in a multi-part tutorial.")]
	public struct TutorialStep
	{
		// Token: 0x040000ED RID: 237
		[RequiredParameter("step_index", "The step or stage completed in a multi-part tutorial.", null)]
		public int stepIndex;

		// Token: 0x040000EE RID: 238
		[OptionalParameter("tutorial_id", "The tutorial name or ID.")]
		public string tutorialId;
	}
}
