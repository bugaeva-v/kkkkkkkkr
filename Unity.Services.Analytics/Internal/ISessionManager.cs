using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000040 RID: 64
	internal interface ISessionManager
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600019E RID: 414
		string SessionId { get; }

		// Token: 0x0600019F RID: 415
		void StartNewSession();
	}
}
