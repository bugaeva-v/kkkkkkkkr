using System;

namespace Firebase.Messaging
{
	// Token: 0x02000007 RID: 7
	public sealed class TokenReceivedEventArgs : EventArgs
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002568 File Offset: 0x00000768
		public TokenReceivedEventArgs(string token)
		{
			this.Token = token;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000257A File Offset: 0x0000077A
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002582 File Offset: 0x00000782
		public string Token { get; set; }
	}
}
