using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.email
{
	// Token: 0x0200003C RID: 60
	public class Email : App42Response
	{
		// Token: 0x06000258 RID: 600 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		public string GetFrom()
		{
			return this.from;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		public void SetFrom(string from)
		{
			this.from = from;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000D3D5 File Offset: 0x0000B5D5
		public string GetTo()
		{
			return this.to;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000D3DD File Offset: 0x0000B5DD
		public void SetTo(string to)
		{
			this.to = to;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public string GetSubject()
		{
			return this.subject;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000D3EE File Offset: 0x0000B5EE
		public void SetSubject(string subject)
		{
			this.subject = subject;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public string GetBody()
		{
			return this.body;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000D3FF File Offset: 0x0000B5FF
		public void SetBody(string body)
		{
			this.body = body;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000D408 File Offset: 0x0000B608
		public IList<Email.Configuration> GetConfigList()
		{
			return this.configList;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000D410 File Offset: 0x0000B610
		public void SetConfigList(IList<Email.Configuration> configList)
		{
			this.configList = configList;
		}

		// Token: 0x040000C8 RID: 200
		public string from;

		// Token: 0x040000C9 RID: 201
		public string to;

		// Token: 0x040000CA RID: 202
		public string subject;

		// Token: 0x040000CB RID: 203
		public string body;

		// Token: 0x040000CC RID: 204
		public IList<Email.Configuration> configList = new List<Email.Configuration>();

		// Token: 0x0200003D RID: 61
		public class Configuration
		{
			// Token: 0x06000263 RID: 611 RVA: 0x0000D42C File Offset: 0x0000B62C
			public Configuration(Email email)
			{
				email.configList.Add(this);
			}

			// Token: 0x06000264 RID: 612 RVA: 0x0000D440 File Offset: 0x0000B640
			public string GetEmailId()
			{
				return this.emailId;
			}

			// Token: 0x06000265 RID: 613 RVA: 0x0000D448 File Offset: 0x0000B648
			public void SetEmailId(string emailId)
			{
				this.emailId = emailId;
			}

			// Token: 0x06000266 RID: 614 RVA: 0x0000D451 File Offset: 0x0000B651
			public string GetHost()
			{
				return this.host;
			}

			// Token: 0x06000267 RID: 615 RVA: 0x0000D459 File Offset: 0x0000B659
			public void SetHost(string host)
			{
				this.host = host;
			}

			// Token: 0x06000268 RID: 616 RVA: 0x0000D462 File Offset: 0x0000B662
			public long GetPort()
			{
				return this.port;
			}

			// Token: 0x06000269 RID: 617 RVA: 0x0000D46A File Offset: 0x0000B66A
			public void SetPort(long port)
			{
				this.port = port;
			}

			// Token: 0x0600026A RID: 618 RVA: 0x0000D473 File Offset: 0x0000B673
			public bool GetSsl()
			{
				return this.ssl;
			}

			// Token: 0x0600026B RID: 619 RVA: 0x0000D47B File Offset: 0x0000B67B
			public void SetSsl(bool ssl)
			{
				this.ssl = ssl;
			}

			// Token: 0x0600026C RID: 620 RVA: 0x0000D484 File Offset: 0x0000B684
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					"Email : ",
					this.emailId,
					" : Host  : ",
					this.host,
					" : port : ",
					this.port,
					" : ssl : ",
					this.ssl
				});
			}

			// Token: 0x040000CD RID: 205
			public string emailId;

			// Token: 0x040000CE RID: 206
			public string host;

			// Token: 0x040000CF RID: 207
			public long port;

			// Token: 0x040000D0 RID: 208
			public bool ssl;
		}
	}
}
