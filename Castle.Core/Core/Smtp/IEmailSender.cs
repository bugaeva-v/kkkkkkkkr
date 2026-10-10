using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Castle.Core.Smtp
{
	// Token: 0x020000B6 RID: 182
	public interface IEmailSender
	{
		// Token: 0x0600048F RID: 1167
		void Send(string from, string to, string subject, string messageText);

		// Token: 0x06000490 RID: 1168
		void Send(MailMessage message);

		// Token: 0x06000491 RID: 1169
		void Send(IEnumerable<MailMessage> messages);
	}
}
