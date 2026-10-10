using System;
using System.IO;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000062 RID: 98
	public class ItemData
	{
		// Token: 0x060003AF RID: 943 RVA: 0x00014ACA File Offset: 0x00012CCA
		public string GetItemId()
		{
			return this.itemId;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00014AD2 File Offset: 0x00012CD2
		public void SetItemId(string itemId)
		{
			this.itemId = itemId;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00014ADB File Offset: 0x00012CDB
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00014AE3 File Offset: 0x00012CE3
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00014AEC File Offset: 0x00012CEC
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00014AF4 File Offset: 0x00012CF4
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00014AFD File Offset: 0x00012CFD
		public string GetImage()
		{
			return this.image;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00014B05 File Offset: 0x00012D05
		public void SetImage(string image)
		{
			this.image = image;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00014B0E File Offset: 0x00012D0E
		public double GetPrice()
		{
			return this.price;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00014B16 File Offset: 0x00012D16
		public void SetPrice(double price)
		{
			this.price = price;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00014B1F File Offset: 0x00012D1F
		public Stream GetImageStream()
		{
			return this.imageStream;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00014B27 File Offset: 0x00012D27
		public void SetImageInputStream(Stream imageStream)
		{
			this.imageStream = imageStream;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00014B30 File Offset: 0x00012D30
		public string GetImageName()
		{
			return this.imageName;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00014B38 File Offset: 0x00012D38
		public void SetImageName(string imageName)
		{
			this.imageName = imageName;
		}

		// Token: 0x04000186 RID: 390
		private string itemId;

		// Token: 0x04000187 RID: 391
		private string name;

		// Token: 0x04000188 RID: 392
		private string description;

		// Token: 0x04000189 RID: 393
		private string image;

		// Token: 0x0400018A RID: 394
		private double price;

		// Token: 0x0400018B RID: 395
		private Stream imageStream;

		// Token: 0x0400018C RID: 396
		private string imageName;
	}
}
