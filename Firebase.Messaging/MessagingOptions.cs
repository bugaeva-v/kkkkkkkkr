using System;

namespace Firebase.Messaging
{
	// Token: 0x02000008 RID: 8
	public sealed class MessagingOptions
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002595 File Offset: 0x00000795
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000259D File Offset: 0x0000079D
		public bool SuppressNotificationPermissionPrompt { get; set; }

		// Token: 0x0600005B RID: 91 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose()
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000224D File Offset: 0x0000044D
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose(bool disposing)
		{
		}
	}
}
