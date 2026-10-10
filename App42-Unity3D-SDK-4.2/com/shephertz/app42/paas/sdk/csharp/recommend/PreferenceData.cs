using System;

namespace com.shephertz.app42.paas.sdk.csharp.recommend
{
	// Token: 0x0200007D RID: 125
	public class PreferenceData
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x0001C354 File Offset: 0x0001A554
		public string GetUserId()
		{
			return this.userId;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001C35C File Offset: 0x0001A55C
		public void SetUserId(string userId)
		{
			this.userId = userId;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001C365 File Offset: 0x0001A565
		public string GetItemId()
		{
			return this.itemId;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001C36D File Offset: 0x0001A56D
		public void SetItemId(string itemId)
		{
			this.itemId = itemId;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001C376 File Offset: 0x0001A576
		public string GetPreference()
		{
			return this.preference;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001C37E File Offset: 0x0001A57E
		public void SetPreference(string preference)
		{
			this.preference = preference;
		}

		// Token: 0x04000227 RID: 551
		public string userId;

		// Token: 0x04000228 RID: 552
		public string itemId;

		// Token: 0x04000229 RID: 553
		public string preference;
	}
}
