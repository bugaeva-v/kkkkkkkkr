using System;

namespace com.shephertz.app42.paas.sdk.csharp.imageProcessor
{
	// Token: 0x0200005C RID: 92
	public class Image : App42Response
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00012D0F File Offset: 0x00010F0F
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00012D17 File Offset: 0x00010F17
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00012D20 File Offset: 0x00010F20
		public string GetAction()
		{
			return this.action;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00012D28 File Offset: 0x00010F28
		public void SetAction(string action)
		{
			this.action = action;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00012D31 File Offset: 0x00010F31
		public string GetOriginalImage()
		{
			return this.originalImage;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00012D39 File Offset: 0x00010F39
		public void SetOriginalImage(string originalImage)
		{
			this.originalImage = originalImage;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00012D42 File Offset: 0x00010F42
		public string GetConvertedImage()
		{
			return this.convertedImage;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00012D4A File Offset: 0x00010F4A
		public void SetConvertedImage(string convertedImage)
		{
			this.convertedImage = convertedImage;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00012D53 File Offset: 0x00010F53
		public double GetPercentage()
		{
			return this.percentage;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00012D5B File Offset: 0x00010F5B
		public string GetOriginalImageTinyUrl()
		{
			return this.originalImageTinyUrl;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00012D63 File Offset: 0x00010F63
		public void SetOriginalImageTinyUrl(string originalImageTinyUrl)
		{
			this.originalImageTinyUrl = originalImageTinyUrl;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00012D6C File Offset: 0x00010F6C
		public string GetConvertedImageTinyUrl()
		{
			return this.convertedImageTinyUrl;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00012D74 File Offset: 0x00010F74
		public void SetConvertedImageTinyUrl(string convertedImageTinyUrl)
		{
			this.convertedImageTinyUrl = convertedImageTinyUrl;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00012D7D File Offset: 0x00010F7D
		public void SetPercentage(double percentage)
		{
			this.percentage = percentage;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00012D86 File Offset: 0x00010F86
		public double GetWidth()
		{
			return (double)this.width;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00012D8F File Offset: 0x00010F8F
		public void SetWidth(long width)
		{
			this.width = width;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00012D98 File Offset: 0x00010F98
		public long GetHeight()
		{
			return this.height;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00012DA0 File Offset: 0x00010FA0
		public void SetHeight(long height)
		{
			this.height = height;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00012DA9 File Offset: 0x00010FA9
		public long GetX()
		{
			return this.x;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00012DB1 File Offset: 0x00010FB1
		public void SetX(long x)
		{
			this.x = x;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00012DBA File Offset: 0x00010FBA
		public long GetY()
		{
			return this.y;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00012DC2 File Offset: 0x00010FC2
		public void SetY(long y)
		{
			this.y = y;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00012DCC File Offset: 0x00010FCC
		public string GetStringView()
		{
			return string.Concat(new object[]
			{
				" Name : ",
				this.name,
				" : Action : ",
				this.action,
				" : originalImage : ",
				this.originalImage,
				" :convertedImage : ",
				this.convertedImage,
				" : percentage : ",
				this.percentage,
				" : width : ",
				this.width,
				" : height  : ",
				this.height,
				" : x : ",
				this.x,
				" :y : ",
				this.y
			});
		}

		// Token: 0x04000173 RID: 371
		public string name;

		// Token: 0x04000174 RID: 372
		public string action;

		// Token: 0x04000175 RID: 373
		public string originalImage;

		// Token: 0x04000176 RID: 374
		public string convertedImage;

		// Token: 0x04000177 RID: 375
		public string originalImageTinyUrl;

		// Token: 0x04000178 RID: 376
		public string convertedImageTinyUrl;

		// Token: 0x04000179 RID: 377
		public double percentage;

		// Token: 0x0400017A RID: 378
		public long width;

		// Token: 0x0400017B RID: 379
		public long height;

		// Token: 0x0400017C RID: 380
		public long x;

		// Token: 0x0400017D RID: 381
		public long y;
	}
}
