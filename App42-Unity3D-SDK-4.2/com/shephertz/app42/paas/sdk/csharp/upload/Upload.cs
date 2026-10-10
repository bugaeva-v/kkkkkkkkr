using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.upload
{
	// Token: 0x020000BE RID: 190
	public class Upload : App42Response
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0002FE45 File Offset: 0x0002E045
		public IList<Upload.File> GetFileList()
		{
			return this.fileList;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002FE4D File Offset: 0x0002E04D
		public void SetFileList(IList<Upload.File> fileList)
		{
			this.fileList = fileList;
		}

		// Token: 0x040002EC RID: 748
		private IList<Upload.File> fileList = new List<Upload.File>();

		// Token: 0x020000BF RID: 191
		public class File
		{
			// Token: 0x06000822 RID: 2082 RVA: 0x0002FE69 File Offset: 0x0002E069
			public File(Upload upload)
			{
				upload.fileList.Add(this);
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x0002FE7D File Offset: 0x0002E07D
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x0002FE85 File Offset: 0x0002E085
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x0002FE8E File Offset: 0x0002E08E
			public string GetUserName()
			{
				return this.userName;
			}

			// Token: 0x06000826 RID: 2086 RVA: 0x0002FE96 File Offset: 0x0002E096
			public void SetUserName(string userName)
			{
				this.userName = userName;
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x0002FE9F File Offset: 0x0002E09F
			public new string GetType()
			{
				return this.type;
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x0002FEA7 File Offset: 0x0002E0A7
			public void SetType(string type)
			{
				this.type = type;
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
			public string GetUrl()
			{
				return this.url;
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
			public void SetUrl(string url)
			{
				this.url = url;
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x0002FEC1 File Offset: 0x0002E0C1
			public string GetTinyUrl()
			{
				return this.tinyUrl;
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x0002FEC9 File Offset: 0x0002E0C9
			public void SetTinyUrl(string tinyUrl)
			{
				this.tinyUrl = tinyUrl;
			}

			// Token: 0x0600082D RID: 2093 RVA: 0x0002FED2 File Offset: 0x0002E0D2
			public string GetDescription()
			{
				return this.description;
			}

			// Token: 0x0600082E RID: 2094 RVA: 0x0002FEDA File Offset: 0x0002E0DA
			public void SetDescription(string description)
			{
				this.description = description;
			}

			// Token: 0x040002ED RID: 749
			public string name;

			// Token: 0x040002EE RID: 750
			public string type;

			// Token: 0x040002EF RID: 751
			public string url;

			// Token: 0x040002F0 RID: 752
			public string tinyUrl;

			// Token: 0x040002F1 RID: 753
			public string userName;

			// Token: 0x040002F2 RID: 754
			public string description;
		}
	}
}
