using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000028 RID: 40
	[StandardEventName("level_up", "Progression", "Send this event when the player rank or level increases.")]
	public struct LevelUp
	{
		// Token: 0x040000D9 RID: 217
		[RequiredParameter("new_level_name", "The new rank or level name.", "level")]
		public string name;

		// Token: 0x040000DA RID: 218
		[RequiredParameter("new_level_index", "The new rank or level index.", "level")]
		public int index;
	}
}
