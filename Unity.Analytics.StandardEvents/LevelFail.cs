using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000024 RID: 36
	[StandardEventName("level_fail", "Progression", "Send this event when the player fails a level.")]
	public struct LevelFail
	{
		// Token: 0x040000D1 RID: 209
		[RequiredParameter("level_name", "The level name. Either level_name or level_index is required.", "level")]
		public string name;

		// Token: 0x040000D2 RID: 210
		[RequiredParameter("level_index", "The order of this level within the game. Either level_name or level_index is required.", "level")]
		public int index;
	}
}
