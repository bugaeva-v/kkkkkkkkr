using System;
using System.IO;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000019 RID: 25
	public class App42File
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00005338 File Offset: 0x00003538
		public App42File(Stream inputStream, string fileName, string fileType)
		{
			Util.ThrowExceptionIfNotValidExtension(fileName, "File Name");
			this.fileInputStream = inputStream;
			this.name = fileName;
			this.fileType = fileType;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005360 File Offset: 0x00003560
		public App42File()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005368 File Offset: 0x00003568
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005370 File Offset: 0x00003570
		public void SetName(string name)
		{
			Util.ThrowExceptionIfNotValidExtension(name, "File Name");
			this.name = name;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005384 File Offset: 0x00003584
		public Stream GetFileInputStream()
		{
			return this.fileInputStream;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000538C File Offset: 0x0000358C
		public void SetFileInputStream(Stream fileInputStream)
		{
			this.fileInputStream = fileInputStream;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005395 File Offset: 0x00003595
		public string GetFileType()
		{
			return this.fileType;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000539D File Offset: 0x0000359D
		public void SetFileType(string fileType)
		{
			this.fileType = fileType;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000053A6 File Offset: 0x000035A6
		public new string GetType()
		{
			return this.type;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000053AE File Offset: 0x000035AE
		public string GetUrl()
		{
			return this.url;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000053B6 File Offset: 0x000035B6
		public string GetFileId()
		{
			return this.fileId;
		}

		// Token: 0x04000058 RID: 88
		public Stream fileInputStream;

		// Token: 0x04000059 RID: 89
		public string fileType;

		// Token: 0x0400005A RID: 90
		public string name;

		// Token: 0x0400005B RID: 91
		public string fileId;

		// Token: 0x0400005C RID: 92
		public string url;

		// Token: 0x0400005D RID: 93
		public string type;
	}
}
