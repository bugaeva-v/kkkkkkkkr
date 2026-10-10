using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000035 RID: 53
	public class Catalogue : App42Response
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000BEFA File Offset: 0x0000A0FA
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000BF02 File Offset: 0x0000A102
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000BF0B File Offset: 0x0000A10B
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000BF13 File Offset: 0x0000A113
		public void SetName(string name)
		{
			this.name = name;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public IList<Catalogue.Category> GetCategoryList()
		{
			return this.categoryList;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000BF24 File Offset: 0x0000A124
		public void SetCategoryList(IList<Catalogue.Category> categoryList)
		{
			this.categoryList = categoryList;
		}

		// Token: 0x040000B4 RID: 180
		public string name;

		// Token: 0x040000B5 RID: 181
		public string description;

		// Token: 0x040000B6 RID: 182
		public IList<Catalogue.Category> categoryList = new List<Catalogue.Category>();

		// Token: 0x02000036 RID: 54
		public class Category
		{
			// Token: 0x0600021F RID: 543 RVA: 0x0000BF40 File Offset: 0x0000A140
			public Category(Catalogue category)
			{
				category.categoryList.Add(this);
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0000BF5F File Offset: 0x0000A15F
			public string GetDescription()
			{
				return this.description;
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0000BF67 File Offset: 0x0000A167
			public void SetDescription(string description)
			{
				this.description = description;
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0000BF70 File Offset: 0x0000A170
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000BF78 File Offset: 0x0000A178
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x06000224 RID: 548 RVA: 0x0000BF81 File Offset: 0x0000A181
			public IList<Catalogue.Category.Item> GetItemList()
			{
				return this.itemList;
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000BF89 File Offset: 0x0000A189
			public void SetItemList(IList<Catalogue.Category.Item> itemList)
			{
				this.itemList = itemList;
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0000BF92 File Offset: 0x0000A192
			public override string ToString()
			{
				return " name : " + this.name + " : description : " + this.description;
			}

			// Token: 0x040000B7 RID: 183
			public string name;

			// Token: 0x040000B8 RID: 184
			public string description;

			// Token: 0x040000B9 RID: 185
			public IList<Catalogue.Category.Item> itemList = new List<Catalogue.Category.Item>();

			// Token: 0x02000037 RID: 55
			public class Item
			{
				// Token: 0x06000227 RID: 551 RVA: 0x0000BFAF File Offset: 0x0000A1AF
				public Item(Catalogue.Category item)
				{
					item.itemList.Add(this);
				}

				// Token: 0x06000228 RID: 552 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
				public string GetItemId()
				{
					return this.itemId;
				}

				// Token: 0x06000229 RID: 553 RVA: 0x0000BFCB File Offset: 0x0000A1CB
				public void SetItemId(string itemId)
				{
					this.itemId = itemId;
				}

				// Token: 0x0600022A RID: 554 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
				public string GetName()
				{
					return this.name;
				}

				// Token: 0x0600022B RID: 555 RVA: 0x0000BFDC File Offset: 0x0000A1DC
				public void SetName(string name)
				{
					this.name = name;
				}

				// Token: 0x0600022C RID: 556 RVA: 0x0000BFE5 File Offset: 0x0000A1E5
				public string GetDescription()
				{
					return this.description;
				}

				// Token: 0x0600022D RID: 557 RVA: 0x0000BFED File Offset: 0x0000A1ED
				public void SetDescription(string description)
				{
					this.description = description;
				}

				// Token: 0x0600022E RID: 558 RVA: 0x0000BFF6 File Offset: 0x0000A1F6
				public string GetUrl()
				{
					return this.url;
				}

				// Token: 0x0600022F RID: 559 RVA: 0x0000BFFE File Offset: 0x0000A1FE
				public void SetUrl(string url)
				{
					this.url = url;
				}

				// Token: 0x06000230 RID: 560 RVA: 0x0000C007 File Offset: 0x0000A207
				public string GetTinyUrl()
				{
					return this.tinyUrl;
				}

				// Token: 0x06000231 RID: 561 RVA: 0x0000C00F File Offset: 0x0000A20F
				public void SetTinyUrl(string tinyUrl)
				{
					this.tinyUrl = tinyUrl;
				}

				// Token: 0x06000232 RID: 562 RVA: 0x0000C018 File Offset: 0x0000A218
				public double GetPrice()
				{
					return this.price;
				}

				// Token: 0x06000233 RID: 563 RVA: 0x0000C020 File Offset: 0x0000A220
				public void GetPrice(double price)
				{
					this.price = price;
				}

				// Token: 0x06000234 RID: 564 RVA: 0x0000C02C File Offset: 0x0000A22C
				public override string ToString()
				{
					return string.Concat(new object[]
					{
						" itemId : ",
						this.itemId,
						" : name : ",
						this.name,
						" : description : ",
						this.description,
						" : url : ",
						this.url,
						" : price : ",
						this.price
					});
				}

				// Token: 0x040000BA RID: 186
				public string itemId;

				// Token: 0x040000BB RID: 187
				public string name;

				// Token: 0x040000BC RID: 188
				public string description;

				// Token: 0x040000BD RID: 189
				public string url;

				// Token: 0x040000BE RID: 190
				public string tinyUrl;

				// Token: 0x040000BF RID: 191
				public double price;
			}
		}
	}
}
