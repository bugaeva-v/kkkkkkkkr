using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200002C RID: 44
	[StandardEventName("screen_visit", "Application", "Send this event when the player opens a menu or visits a screen in the game.")]
	public struct ScreenVisit
	{
		// Token: 0x040000DD RID: 221
		[CustomizableEnum(true)]
		[RequiredParameter("screen_name", "The name of the screen or type of screen visited.", null)]
		public ScreenName screenName;
	}
}
