using System;

namespace Firebase
{
	// Token: 0x02000005 RID: 5
	public sealed class InitializationException : Exception
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000022C0 File Offset: 0x000004C0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000022C8 File Offset: 0x000004C8
		public InitResult InitResult { get; private set; }

		// Token: 0x0600001C RID: 28 RVA: 0x000022D1 File Offset: 0x000004D1
		public InitializationException(InitResult result)
		{
			this.InitResult = result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022E3 File Offset: 0x000004E3
		public InitializationException(InitResult result, string message) : base(message)
		{
			this.InitResult = result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022F6 File Offset: 0x000004F6
		public InitializationException(InitResult result, string message, Exception inner) : base(message, inner)
		{
			this.InitResult = result;
		}
	}
}
