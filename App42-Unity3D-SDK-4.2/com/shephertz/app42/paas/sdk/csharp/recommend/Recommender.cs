using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.recommend
{
	// Token: 0x0200008C RID: 140
	public class Recommender : App42Response
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x0002053F File Offset: 0x0001E73F
		public IList<Recommender.RecommendedItem> GetRecommendedItemList()
		{
			return this.recommendedItemList;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00020547 File Offset: 0x0001E747
		public void SetRecommendedItemList(IList<Recommender.RecommendedItem> recommendedItemList)
		{
			this.recommendedItemList = recommendedItemList;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00020550 File Offset: 0x0001E750
		public string GetFileName()
		{
			return this.fileName;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00020558 File Offset: 0x0001E758
		public void SetFileName(string fileName)
		{
			this.fileName = fileName;
		}

		// Token: 0x0400025D RID: 605
		public string fileName;

		// Token: 0x0400025E RID: 606
		public IList<Recommender.RecommendedItem> recommendedItemList = new List<Recommender.RecommendedItem>();

		// Token: 0x0200008D RID: 141
		public class RecommendedItem
		{
			// Token: 0x060005B3 RID: 1459 RVA: 0x00020574 File Offset: 0x0001E774
			public RecommendedItem(Recommender recommender)
			{
				recommender.recommendedItemList.Add(this);
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x00020588 File Offset: 0x0001E788
			public string GetUserId()
			{
				return this.userId;
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x00020590 File Offset: 0x0001E790
			public void SetUserId(string userId)
			{
				this.userId = userId;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x00020599 File Offset: 0x0001E799
			public string GetItem()
			{
				return this.item;
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x000205A1 File Offset: 0x0001E7A1
			public void SetItem(string item)
			{
				this.item = item;
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x000205AA File Offset: 0x0001E7AA
			public double GetValue()
			{
				return this.value;
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x000205B2 File Offset: 0x0001E7B2
			public void SetValue(double value)
			{
				this.value = value;
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x000205BC File Offset: 0x0001E7BC
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					"userId : ",
					this.userId,
					": item : ",
					this.item,
					" : value : ",
					this.value
				});
			}

			// Token: 0x0400025F RID: 607
			public string userId;

			// Token: 0x04000260 RID: 608
			public string item;

			// Token: 0x04000261 RID: 609
			public double value;
		}
	}
}
