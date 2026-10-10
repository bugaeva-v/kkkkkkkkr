using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000025 RID: 37
	[StandardEventName("level_quit", "Progression", "Send this event when the player opts to quit from a level before completing it.")]
	public struct LevelQuit
	{
		// Token: 0x040000D3 RID: 211
		[RequiredParameter("level_name", "The level name. Either level_name or level_index is required.", "level")]
		public string name;

		// Token: 0x040000D4 RID: 212
		[RequiredParameter("level_index", "The order of this level within the game. Either level_name or level_index is required.", "level")]
		public int index;
	}
}
