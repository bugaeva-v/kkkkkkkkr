using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200001D RID: 29
	[StandardEventName("cutscene_skip", "Application", "Send this event when the player opts to skip a cutscene or cinematic screen.")]
	public struct CutsceneSkip
	{
		// Token: 0x040000B6 RID: 182
		[RequiredParameter("scene_name", "The name of the cutscene skipped.", null)]
		public string name;
	}
}
