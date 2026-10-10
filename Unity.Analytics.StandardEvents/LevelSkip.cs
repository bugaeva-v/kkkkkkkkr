using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000026 RID: 38
	[StandardEventName("level_skip", "Progression", "Send this event when the player opts to skip past a level.")]
	public struct LevelSkip
	{
		// Token: 0x040000D5 RID: 213
		[RequiredParameter("level_name", "The level name. Either level_name or level_index is required.", "level")]
		public string name;

		// Token: 0x040000D6 RID: 214
		[RequiredParameter("level_index", "The order of this level within the game. Either level_name or level_index is required.", "level")]
		public int index;
	}
}
