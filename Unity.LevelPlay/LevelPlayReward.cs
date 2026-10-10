using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000012 RID: 18
	public sealed class LevelPlayReward
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003BA1 File Offset: 0x00001DA1
		public string Name { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003BA9 File Offset: 0x00001DA9
		public int Amount { get; }

		// Token: 0x060000FD RID: 253 RVA: 0x00003BB1 File Offset: 0x00001DB1
		internal LevelPlayReward(string name, int amount)
		{
			this.Name = name;
			this.Amount = amount;
		}

		// Token: 0x0400005D RID: 93
		internal static readonly LevelPlayReward Default = new LevelPlayReward(string.Empty, 0);
	}
}
