using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.bravoboard
{
	// Token: 0x02000027 RID: 39
	public class BravoBoard : App42Response
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000079ED File Offset: 0x00005BED
		public string GetUserId()
		{
			return this.userId;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000079F5 File Offset: 0x00005BF5
		public void SetUserId(string userId)
		{
			this.userId = userId;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000079FE File Offset: 0x00005BFE
		public string GetItemId()
		{
			return this.itemId;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007A06 File Offset: 0x00005C06
		public void SetItemId(string itemId)
		{
			this.itemId = itemId;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007A0F File Offset: 0x00005C0F
		public string GetStatus()
		{
			return this.status;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007A17 File Offset: 0x00005C17
		public void SetStatus(string status)
		{
			this.status = status;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007A20 File Offset: 0x00005C20
		public string GetComment()
		{
			return this.comment;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007A28 File Offset: 0x00005C28
		public void SetComment(string comment)
		{
			this.comment = comment;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007A31 File Offset: 0x00005C31
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007A39 File Offset: 0x00005C39
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007A42 File Offset: 0x00005C42
		public void SetActivityId(string activityId)
		{
			this.activityId = activityId;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007A4B File Offset: 0x00005C4B
		public string GetActivityId()
		{
			return this.activityId;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007A53 File Offset: 0x00005C53
		public IList<BravoBoard.Tags> GetTagList()
		{
			return this.tags;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00007A5B File Offset: 0x00005C5B
		public void SetTagList(IList<BravoBoard.Tags> tags)
		{
			this.tags = tags;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007A64 File Offset: 0x00005C64
		public string GetStringView()
		{
			return string.Concat(new object[]
			{
				"UserId :",
				this.userId,
				" : ItemId : ",
				this.itemId,
				" : Status : ",
				this.status,
				" : Comment : ",
				this.comment,
				" : CreatedOn : ",
				this.createdOn,
				" : activityId : ",
				this.activityId
			});
		}

		// Token: 0x04000083 RID: 131
		public string userId;

		// Token: 0x04000084 RID: 132
		public string itemId;

		// Token: 0x04000085 RID: 133
		public string status;

		// Token: 0x04000086 RID: 134
		public string comment;

		// Token: 0x04000087 RID: 135
		public string activityId;

		// Token: 0x04000088 RID: 136
		public DateTime createdOn;

		// Token: 0x04000089 RID: 137
		public IList<BravoBoard.Tags> tags = new List<BravoBoard.Tags>();

		// Token: 0x02000028 RID: 40
		public class Tags
		{
			// Token: 0x06000178 RID: 376 RVA: 0x00007B00 File Offset: 0x00005D00
			public Tags(BravoBoard bravo)
			{
				bravo.tags.Add(this);
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00007B14 File Offset: 0x00005D14
			public string GetUser()
			{
				return this.user;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00007B1C File Offset: 0x00005D1C
			public void SetUser(string user)
			{
				this.user = user;
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00007B25 File Offset: 0x00005D25
			public string GetTagName()
			{
				return this.tagName;
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00007B2D File Offset: 0x00005D2D
			public void SetTagName(string tagName)
			{
				this.tagName = tagName;
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00007B36 File Offset: 0x00005D36
			public string GetTaggedOn()
			{
				return this.taggedOn;
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00007B3E File Offset: 0x00005D3E
			public void SetTaggedOn(string taggedOn)
			{
				this.taggedOn = taggedOn;
			}

			// Token: 0x0400008A RID: 138
			public string user;

			// Token: 0x0400008B RID: 139
			public string tagName;

			// Token: 0x0400008C RID: 140
			public string taggedOn;
		}
	}
}
