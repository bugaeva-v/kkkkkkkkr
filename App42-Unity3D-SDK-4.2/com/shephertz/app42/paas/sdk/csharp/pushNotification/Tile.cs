using System;

namespace com.shephertz.app42.paas.sdk.csharp.pushNotification
{
	// Token: 0x020000BA RID: 186
	public class Tile
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x0002F6F1 File Offset: 0x0002D8F1
		public string GetTitle()
		{
			return this.title;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0002F6F9 File Offset: 0x0002D8F9
		public void SetTitle(string title)
		{
			this.title = title;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0002F702 File Offset: 0x0002D902
		public string GetCount()
		{
			return this.count;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0002F70A File Offset: 0x0002D90A
		public void SetCount(string count)
		{
			this.count = count;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0002F713 File Offset: 0x0002D913
		public string GetBackgroundImage()
		{
			return this.backgroundImage;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0002F71B File Offset: 0x0002D91B
		public void SetBackgroundImage(string backgroundImage)
		{
			this.backgroundImage = backgroundImage;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0002F724 File Offset: 0x0002D924
		public string GetBackBackgroundImage()
		{
			return this.backBackgroundImage;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0002F72C File Offset: 0x0002D92C
		public void SetBackBackgroundImage(string backBackgroundImage)
		{
			this.backBackgroundImage = backBackgroundImage;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002F735 File Offset: 0x0002D935
		public string GetBackTitle()
		{
			return this.backTitle;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0002F73D File Offset: 0x0002D93D
		public void SetBackTitle(string backTitle)
		{
			this.backTitle = backTitle;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002F746 File Offset: 0x0002D946
		public string GetBackContent()
		{
			return this.backContent;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002F74E File Offset: 0x0002D94E
		public void SetBackContent(string backContent)
		{
			this.backContent = backContent;
		}

		// Token: 0x040002DF RID: 735
		public string title = "";

		// Token: 0x040002E0 RID: 736
		public string count = "";

		// Token: 0x040002E1 RID: 737
		public string backgroundImage = "";

		// Token: 0x040002E2 RID: 738
		public string backBackgroundImage = "";

		// Token: 0x040002E3 RID: 739
		public string backTitle = "";

		// Token: 0x040002E4 RID: 740
		public string backContent = "";
	}
}
