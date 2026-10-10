using System;

namespace com.shephertz.app42.paas.sdk.csharp.avatar
{
	// Token: 0x02000022 RID: 34
	public class Avatar : App42Response
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public bool IsCurrent()
		{
			return this.isCurrent;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006BB8 File Offset: 0x00004DB8
		public void setIsCurrent(bool IsCurrent)
		{
			this.isCurrent = IsCurrent;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006BC1 File Offset: 0x00004DC1
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006BC9 File Offset: 0x00004DC9
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006BD2 File Offset: 0x00004DD2
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006BDA File Offset: 0x00004DDA
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006BE3 File Offset: 0x00004DE3
		public string GetUrl()
		{
			return this.url;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006BEB File Offset: 0x00004DEB
		public void SetUrl(string url)
		{
			this.url = url;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006BF4 File Offset: 0x00004DF4
		public string GetTinyUrl()
		{
			return this.tinyUrl;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006BFC File Offset: 0x00004DFC
		public void SetTinyUrl(string tinyUrl)
		{
			this.tinyUrl = tinyUrl;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006C05 File Offset: 0x00004E05
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006C0D File Offset: 0x00004E0D
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006C16 File Offset: 0x00004E16
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006C1E File Offset: 0x00004E1E
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x04000078 RID: 120
		public string userName;

		// Token: 0x04000079 RID: 121
		public string name;

		// Token: 0x0400007A RID: 122
		public string url;

		// Token: 0x0400007B RID: 123
		public string tinyUrl;

		// Token: 0x0400007C RID: 124
		public DateTime createdOn;

		// Token: 0x0400007D RID: 125
		public string description;

		// Token: 0x0400007E RID: 126
		public bool isCurrent;
	}
}
