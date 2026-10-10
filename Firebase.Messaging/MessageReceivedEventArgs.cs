using System;

namespace Firebase.Messaging
{
	// Token: 0x02000006 RID: 6
	public sealed class MessageReceivedEventArgs : EventArgs
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002545 File Offset: 0x00000745
		public MessageReceivedEventArgs(FirebaseMessage msg)
		{
			this.Message = msg;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002557 File Offset: 0x00000757
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000255F File Offset: 0x0000075F
		public FirebaseMessage Message { get; set; }
	}
}
