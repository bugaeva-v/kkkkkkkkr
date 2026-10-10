using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000029 RID: 41
	[StandardEventName("first_interaction", "Onboarding", "Send this event with the first voluntary action the user takes after install.")]
	public struct FirstInteraction
	{
		// Token: 0x040000DB RID: 219
		[OptionalParameter("action_id", "The action ID or name. For example, a unique identifier for the button clicked.")]
		public string actionId;
	}
}
