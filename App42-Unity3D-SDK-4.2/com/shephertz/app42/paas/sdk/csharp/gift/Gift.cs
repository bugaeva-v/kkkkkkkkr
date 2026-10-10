using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.gift
{
	// Token: 0x02000055 RID: 85
	public class Gift : App42Response
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00011AA6 File Offset: 0x0000FCA6
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00011AAE File Offset: 0x0000FCAE
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00011AB7 File Offset: 0x0000FCB7
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00011ABF File Offset: 0x0000FCBF
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		public string GetDisplayName()
		{
			return this.displayName;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00011AD0 File Offset: 0x0000FCD0
		public void SetDisplayName(string displayName)
		{
			this.displayName = displayName;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00011AD9 File Offset: 0x0000FCD9
		public string GetIcon()
		{
			return this.icon;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00011AE1 File Offset: 0x0000FCE1
		public void SetIcon(string icon)
		{
			this.icon = icon;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00011AEA File Offset: 0x0000FCEA
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00011AF2 File Offset: 0x0000FCF2
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011AFB File Offset: 0x0000FCFB
		public string GetTag()
		{
			return this.tag;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00011B03 File Offset: 0x0000FD03
		public void SetTag(string tag)
		{
			this.tag = tag;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public IList<Gift.Requests> GetRequestsList()
		{
			return this.requests;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00011B14 File Offset: 0x0000FD14
		public void SetRequestsList(IList<Gift.Requests> requests)
		{
			this.requests = requests;
		}

		// Token: 0x0400015C RID: 348
		public string name;

		// Token: 0x0400015D RID: 349
		public string displayName;

		// Token: 0x0400015E RID: 350
		public string icon;

		// Token: 0x0400015F RID: 351
		public string description;

		// Token: 0x04000160 RID: 352
		public string tag;

		// Token: 0x04000161 RID: 353
		public DateTime createdOn;

		// Token: 0x04000162 RID: 354
		public IList<Gift.Requests> requests = new List<Gift.Requests>();

		// Token: 0x02000056 RID: 86
		public class Requests
		{
			// Token: 0x06000331 RID: 817 RVA: 0x00011B30 File Offset: 0x0000FD30
			public Requests(Gift gft)
			{
				gft.requests.Add(this);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00011B44 File Offset: 0x0000FD44
			public DateTime GetSentOn()
			{
				return this.sentOn;
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00011B4C File Offset: 0x0000FD4C
			public void SetSentOn(DateTime sentOn)
			{
				this.sentOn = sentOn;
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00011B55 File Offset: 0x0000FD55
			public DateTime GetExpiration()
			{
				return this.expiration;
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00011B5D File Offset: 0x0000FD5D
			public void SetExpiration(DateTime expiration)
			{
				this.expiration = expiration;
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00011B66 File Offset: 0x0000FD66
			public new string GetType()
			{
				return this.type;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00011B6E File Offset: 0x0000FD6E
			public void SetType(string type)
			{
				this.type = type;
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00011B77 File Offset: 0x0000FD77
			public string GetSender()
			{
				return this.sender;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00011B7F File Offset: 0x0000FD7F
			public void SetSender(string sender)
			{
				this.sender = sender;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00011B88 File Offset: 0x0000FD88
			public string GetRecipient()
			{
				return this.recipient;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00011B90 File Offset: 0x0000FD90
			public void SetRecipient(string recipient)
			{
				this.recipient = recipient;
			}

			// Token: 0x0600033C RID: 828 RVA: 0x00011B99 File Offset: 0x0000FD99
			public string GetRequestId()
			{
				return this.requestId;
			}

			// Token: 0x0600033D RID: 829 RVA: 0x00011BA1 File Offset: 0x0000FDA1
			public void SetRequestId(string requestId)
			{
				this.requestId = requestId;
			}

			// Token: 0x0600033E RID: 830 RVA: 0x00011BAA File Offset: 0x0000FDAA
			public string GetMessage()
			{
				return this.message;
			}

			// Token: 0x0600033F RID: 831 RVA: 0x00011BB2 File Offset: 0x0000FDB2
			public void SetMessage(string message)
			{
				this.message = message;
			}

			// Token: 0x04000163 RID: 355
			public string sender;

			// Token: 0x04000164 RID: 356
			public string recipient;

			// Token: 0x04000165 RID: 357
			public DateTime expiration;

			// Token: 0x04000166 RID: 358
			public DateTime sentOn;

			// Token: 0x04000167 RID: 359
			public string requestId;

			// Token: 0x04000168 RID: 360
			public string type;

			// Token: 0x04000169 RID: 361
			public string message;
		}
	}
}
