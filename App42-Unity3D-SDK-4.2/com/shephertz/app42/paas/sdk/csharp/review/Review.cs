using System;

namespace com.shephertz.app42.paas.sdk.csharp.review
{
	// Token: 0x02000092 RID: 146
	public class Review : App42Response
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00023CCC File Offset: 0x00021ECC
		public string GetUserId()
		{
			return this.userId;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00023CD4 File Offset: 0x00021ED4
		public void SetUserId(string userId)
		{
			this.userId = userId;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00023CDD File Offset: 0x00021EDD
		public string GetItemId()
		{
			return this.itemId;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00023CE5 File Offset: 0x00021EE5
		public void SetItemId(string itemId)
		{
			this.itemId = itemId;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00023CEE File Offset: 0x00021EEE
		public string GetStatus()
		{
			return this.status;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00023CF6 File Offset: 0x00021EF6
		public void SetStatus(string status)
		{
			this.status = status;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00023CFF File Offset: 0x00021EFF
		public string GetReviewId()
		{
			return this.reviewId;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00023D07 File Offset: 0x00021F07
		public void SetReviewId(string reviewId)
		{
			this.reviewId = reviewId;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00023D10 File Offset: 0x00021F10
		public string GetComment()
		{
			return this.comment;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00023D18 File Offset: 0x00021F18
		public void SetComment(string comment)
		{
			this.comment = comment;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00023D21 File Offset: 0x00021F21
		public double GetRating()
		{
			return this.rating;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00023D29 File Offset: 0x00021F29
		public void SetRating(double rating)
		{
			this.rating = rating;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00023D32 File Offset: 0x00021F32
		public DateTime GetCreatedOn()
		{
			return this.createdOn;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00023D3A File Offset: 0x00021F3A
		public void SetCreatedOn(DateTime createdOn)
		{
			this.createdOn = createdOn;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00023D43 File Offset: 0x00021F43
		public void SetCommentId(string commentId)
		{
			this.commentId = commentId;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00023D4C File Offset: 0x00021F4C
		public string GetCommentId()
		{
			return this.commentId;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00023D54 File Offset: 0x00021F54
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
				" : ReviewId : ",
				this.reviewId,
				" : Comment : ",
				this.comment,
				" : Rating : ",
				this.rating,
				" : CreatedOn : ",
				this.createdOn
			});
		}

		// Token: 0x04000268 RID: 616
		public string userId;

		// Token: 0x04000269 RID: 617
		public string itemId;

		// Token: 0x0400026A RID: 618
		public string status;

		// Token: 0x0400026B RID: 619
		public string reviewId;

		// Token: 0x0400026C RID: 620
		public string comment;

		// Token: 0x0400026D RID: 621
		public string commentId;

		// Token: 0x0400026E RID: 622
		public double rating;

		// Token: 0x0400026F RID: 623
		public DateTime createdOn;
	}
}
