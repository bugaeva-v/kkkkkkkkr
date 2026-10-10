using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000026 RID: 38
	internal interface IIdentityManager
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000EA RID: 234
		string UserId { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000EB RID: 235
		string InstallId { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000EC RID: 236
		string PlayerId { get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000ED RID: 237
		string ExternalId { get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000EE RID: 238
		bool IsNewPlayer { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000EF RID: 239
		// (remove) Token: 0x060000F0 RID: 240
		event Action OnPlayerChanged;

		// Token: 0x060000F1 RID: 241
		void Initialize();
	}
}
