using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000023 RID: 35
	[StandardEventName("level_complete", "Progression", "Send this event when the player has successfully completed a level.")]
	public struct LevelComplete
	{
		// Token: 0x040000CF RID: 207
		[RequiredParameter("level_name", "The level name. Either level_name or level_index is required.", "level")]
		public string name;

		// Token: 0x040000D0 RID: 208
		[RequiredParameter("level_index", "The order of this level within the game. Either level_name or level_index is required.", "level")]
		public int index;
	}
}
