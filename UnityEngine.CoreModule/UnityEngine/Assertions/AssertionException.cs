using System;

namespace UnityEngine.Assertions
{
	// Token: 0x02000488 RID: 1160
	public class AssertionException : Exception
	{
		// Token: 0x06002919 RID: 10521 RVA: 0x00043F3B File Offset: 0x0004213B
		public AssertionException(string message, string userMessage) : base(message)
		{
			this.m_UserMessage = userMessage;
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x00043F50 File Offset: 0x00042150
		public override string Message
		{
			get
			{
				string text = base.Message;
				bool flag = this.m_UserMessage != null;
				if (flag)
				{
					text = this.m_UserMessage + "\n" + text;
				}
				return text;
			}
		}

		// Token: 0x04000F9E RID: 3998
		private string m_UserMessage;
	}
}
