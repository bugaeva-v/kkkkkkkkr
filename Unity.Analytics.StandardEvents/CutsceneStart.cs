using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200001C RID: 28
	[StandardEventName("cutscene_start", "Application", "Send this event when the player begins to watch a cutscene or cinematic screen.")]
	public struct CutsceneStart
	{
		// Token: 0x040000B5 RID: 181
		[RequiredParameter("scene_name", "The name of the cutscene being viewed.", null)]
		public string name;
	}
}
