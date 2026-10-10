using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000041 RID: 65
	internal class SessionManager : ISessionManager
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00006622 File Offset: 0x00004822
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000662A File Offset: 0x0000482A
		public string SessionId { get; private set; }

		// Token: 0x060001A2 RID: 418 RVA: 0x00006633 File Offset: 0x00004833
		public SessionManager()
		{
			this.StartNewSession();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006644 File Offset: 0x00004844
		public void StartNewSession()
		{
			this.SessionId = Guid.NewGuid().ToString();
		}
	}
}
