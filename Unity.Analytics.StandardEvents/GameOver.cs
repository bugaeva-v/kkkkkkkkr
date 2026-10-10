using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200001E RID: 30
	[StandardEventName("game_over", "Progression", "Send this event when gameplay ends (in a game with an identifiable conclusion).")]
	public struct GameOver
	{
		// Token: 0x040000B7 RID: 183
		[OptionalParameter("level_index", "The order of this level within the game.")]
		public int index;

		// Token: 0x040000B8 RID: 184
		[OptionalParameter("level_name", "The level name.")]
		public string name;
	}
}
