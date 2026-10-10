using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Security.Permissions;
using Castle.Core.Internal;

namespace Castle.Core.Smtp
{
	// Token: 0x020000B5 RID: 181
	public class DefaultSmtpSender : IEmailSender
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public DefaultSmtpSender()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000FC1F File Offset: 0x0000DE1F
		public DefaultSmtpSender(string hostname)
		{
			this.hostname = hostname;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000FC41 File Offset: 0x0000DE41
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0000FC49 File Offset: 0x0000DE49
		public int Port
		{
			get
			{
				return this.port;
			}
			set
			{
				this.port = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000FC52 File Offset: 0x0000DE52
		public string Hostname
		{
			get
			{
				return this.hostname;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0000FC62 File Offset: 0x0000DE62
		public bool AsyncSend
		{
			get
			{
				return this.asyncSend;
			}
			set
			{
				this.asyncSend = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000FC6B File Offset: 0x0000DE6B
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0000FC87 File Offset: 0x0000DE87
		public int Timeout
		{
			get
			{
				if (this.timeout == null)
				{
					return 0;
				}
				return this.timeout.Value;
			}
			set
			{
				this.timeout = new int?(value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000FC95 File Offset: 0x0000DE95
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x0000FC9D File Offset: 0x0000DE9D
		public bool UseSsl
		{
			get
			{
				return this.useSsl;
			}
			set
			{
				this.useSsl = value;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[SecuritySafeCritical]
		public void Send(string from, string to, string subject, string messageText)
		{
			if (from == null)
			{
				throw new ArgumentNullException("from");
			}
			if (to == null)
			{
				throw new ArgumentNullException("to");
			}
			if (subject == null)
			{
				throw new ArgumentNullException("subject");
			}
			if (messageText == null)
			{
				throw new ArgumentNullException("messageText");
			}
			this.Send(new MailMessage(from, to, subject, messageText));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000FCFE File Offset: 0x0000DEFE
		[SecuritySafeCritical]
		public void Send(MailMessage message)
		{
			this.InternalSend(message);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[SecurityCritical]
		private void InternalSend(MailMessage message)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			if (this.asyncSend)
			{
				SmtpClient smtpClient = this.CreateSmtpClient();
				Guid msgGuid = default(Guid);
				SendCompletedEventHandler sceh = null;
				sceh = delegate(object sender, AsyncCompletedEventArgs e)
				{
					if (msgGuid == (Guid)e.UserState)
					{
						message.Dispose();
					}
					smtpClient.SendCompleted -= sceh;
				};
				smtpClient.SendCompleted += sceh;
				smtpClient.SendAsync(message, msgGuid);
				return;
			}
			using (message)
			{
				this.CreateSmtpClient().Send(message);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		[SecuritySafeCritical]
		public void Send(IEnumerable<MailMessage> messages)
		{
			foreach (MailMessage message in messages)
			{
				this.Send(message);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000FE2C File Offset: 0x0000E02C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0000FE39 File Offset: 0x0000E039
		public string Domain
		{
			get
			{
				return this.credentials.Domain;
			}
			set
			{
				this.credentials.Domain = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000FE47 File Offset: 0x0000E047
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0000FE54 File Offset: 0x0000E054
		public string UserName
		{
			get
			{
				return this.credentials.UserName;
			}
			set
			{
				this.credentials.UserName = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000FE62 File Offset: 0x0000E062
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000FE6F File Offset: 0x0000E06F
		public string Password
		{
			get
			{
				return this.credentials.Password;
			}
			set
			{
				this.credentials.Password = value;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000FE80 File Offset: 0x0000E080
		[SecurityCritical]
		protected virtual void Configure(SmtpClient smtpClient)
		{
			smtpClient.Credentials = null;
			if (DefaultSmtpSender.CanAccessCredentials() && this.HasCredentials)
			{
				smtpClient.Credentials = this.credentials;
			}
			if (this.timeout != null)
			{
				smtpClient.Timeout = this.timeout.Value;
			}
			if (this.useSsl)
			{
				smtpClient.EnableSsl = this.useSsl;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000FEE1 File Offset: 0x0000E0E1
		private bool HasCredentials
		{
			get
			{
				return !string.IsNullOrEmpty(this.credentials.UserName);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		[SecuritySafeCritical]
		private SmtpClient CreateSmtpClient()
		{
			if (string.IsNullOrEmpty(this.hostname))
			{
				return new SmtpClient();
			}
			SmtpClient smtpClient = new SmtpClient(this.hostname, this.port);
			this.Configure(smtpClient);
			return smtpClient;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000FF32 File Offset: 0x0000E132
		private static bool CanAccessCredentials()
		{
			return new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).IsGranted();
		}

		// Token: 0x0400013F RID: 319
		private bool asyncSend;

		// Token: 0x04000140 RID: 320
		private readonly string hostname;

		// Token: 0x04000141 RID: 321
		private int port = 25;

		// Token: 0x04000142 RID: 322
		private int? timeout;

		// Token: 0x04000143 RID: 323
		private bool useSsl;

		// Token: 0x04000144 RID: 324
		private readonly NetworkCredential credentials = new NetworkCredential();
	}
}
