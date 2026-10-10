using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000027 RID: 39
	[StandardEventName("level_start", "Progression", "Send this event when the player enters into or begins a level.")]
	public struct LevelStart
	{
		// Token: 0x040000D7 RID: 215
		[RequiredParameter("level_name", "The level name. Either level_name or level_index is required.", "level")]
		public string name;

		// Token: 0x040000D8 RID: 216
		[RequiredParameter("level_index", "The order of this level within the game. Either level_name or level_index is required.", "level")]
		public int index;
	}
}
