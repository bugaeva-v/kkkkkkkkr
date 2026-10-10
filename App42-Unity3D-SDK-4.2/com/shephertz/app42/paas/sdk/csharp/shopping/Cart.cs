using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x0200002F RID: 47
	public class Cart : App42Response
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0000A97F File Offset: 0x00008B7F
		public string GetUserName()
		{
			return this.userName;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A987 File Offset: 0x00008B87
		public void SetUserName(string userName)
		{
			this.userName = userName;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A990 File Offset: 0x00008B90
		public string GetCartId()
		{
			return this.cartId;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A998 File Offset: 0x00008B98
		public void SetCartId(string cartId)
		{
			this.cartId = cartId;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A9A1 File Offset: 0x00008BA1
		public DateTime GetCreationTime()
		{
			return this.creationTime;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		public void SetCreationTime(DateTime creationTime)
		{
			this.creationTime = creationTime;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public DateTime GetCheckOutTime()
		{
			return this.checkOutTime;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A9BA File Offset: 0x00008BBA
		public void SetCheckOutTime(DateTime checkOutTime)
		{
			this.checkOutTime = checkOutTime;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A9C3 File Offset: 0x00008BC3
		public string GetState()
		{
			return this.state;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public void SetState(string state)
		{
			this.state = state;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		public bool GetIsEmpty()
		{
			return this.isEmpty;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public void SetIsEmpty(bool isEmpty)
		{
			this.isEmpty = isEmpty;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A9E5 File Offset: 0x00008BE5
		public string GetCartSession()
		{
			return this.cartSession;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A9ED File Offset: 0x00008BED
		public void SetCartSession(string cartSession)
		{
			this.cartSession = cartSession;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A9F6 File Offset: 0x00008BF6
		public double GetTotalAmount()
		{
			return this.totalAmount;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A9FE File Offset: 0x00008BFE
		public void SetTotalAmount(double totalAmount)
		{
			this.totalAmount = totalAmount;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000AA07 File Offset: 0x00008C07
		public IList<Cart.Item> GetItemList()
		{
			return this.itemList;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000AA0F File Offset: 0x00008C0F
		public void SetItemList(IList<Cart.Item> itemList)
		{
			this.itemList = itemList;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000AA18 File Offset: 0x00008C18
		public Cart.Payment GetPayment()
		{
			return this.payment;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000AA20 File Offset: 0x00008C20
		public void SetPayment(Cart.Payment payment)
		{
			this.payment = payment;
		}

		// Token: 0x0400009C RID: 156
		public string userName;

		// Token: 0x0400009D RID: 157
		public string cartId;

		// Token: 0x0400009E RID: 158
		public DateTime creationTime;

		// Token: 0x0400009F RID: 159
		public DateTime checkOutTime;

		// Token: 0x040000A0 RID: 160
		public string state;

		// Token: 0x040000A1 RID: 161
		public bool isEmpty;

		// Token: 0x040000A2 RID: 162
		public string cartSession;

		// Token: 0x040000A3 RID: 163
		public double totalAmount;

		// Token: 0x040000A4 RID: 164
		public IList<Cart.Item> itemList = new List<Cart.Item>();

		// Token: 0x040000A5 RID: 165
		public Cart.Payment payment;

		// Token: 0x02000030 RID: 48
		public class Item
		{
			// Token: 0x060001E7 RID: 487 RVA: 0x0000AA3C File Offset: 0x00008C3C
			public Item(Cart item)
			{
				item.itemList.Add(this);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0000AA50 File Offset: 0x00008C50
			public string GetItemId()
			{
				return this.itemId;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x0000AA58 File Offset: 0x00008C58
			public void SetItemId(string itemId)
			{
				this.itemId = itemId;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x0000AA61 File Offset: 0x00008C61
			public long GetQuantity()
			{
				return this.quantity;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x0000AA69 File Offset: 0x00008C69
			public void SetQuantity(long quantity)
			{
				this.quantity = quantity;
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0000AA72 File Offset: 0x00008C72
			public string GetName()
			{
				return this.name;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0000AA7A File Offset: 0x00008C7A
			public void SetName(string name)
			{
				this.name = name;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0000AA83 File Offset: 0x00008C83
			public string GetImage()
			{
				return this.image;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x0000AA8B File Offset: 0x00008C8B
			public void SetImage(string image)
			{
				this.image = image;
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x0000AA94 File Offset: 0x00008C94
			public double GetPrice()
			{
				return this.price;
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x0000AA9C File Offset: 0x00008C9C
			public void SetPrice(double price)
			{
				this.price = price;
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x0000AAA5 File Offset: 0x00008CA5
			public double GetTotalAmount()
			{
				return this.totalAmount;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x0000AAAD File Offset: 0x00008CAD
			public void SetTotalAmount(double totalAmount)
			{
				this.totalAmount = totalAmount;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x0000AAB8 File Offset: 0x00008CB8
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					" name : ",
					this.name,
					" : itemId : ",
					this.itemId,
					" : price : ",
					this.price,
					" : quantity : ",
					this.quantity
				});
			}

			// Token: 0x040000A6 RID: 166
			public string itemId;

			// Token: 0x040000A7 RID: 167
			public long quantity;

			// Token: 0x040000A8 RID: 168
			public string name;

			// Token: 0x040000A9 RID: 169
			public string image;

			// Token: 0x040000AA RID: 170
			public double price;

			// Token: 0x040000AB RID: 171
			public double totalAmount;
		}

		// Token: 0x02000031 RID: 49
		public class Payment
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x0000AB20 File Offset: 0x00008D20
			public Payment(Cart cart)
			{
				cart.payment = this;
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000AB2F File Offset: 0x00008D2F
			public string GetTransactionId()
			{
				return this.transactionId;
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x0000AB37 File Offset: 0x00008D37
			public void SetTransactionId(string transactionId)
			{
				this.transactionId = transactionId;
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x0000AB40 File Offset: 0x00008D40
			public double GetTotalAmount()
			{
				return this.totalAmount;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x0000AB48 File Offset: 0x00008D48
			public void SetTotalAmount(double totalAmount)
			{
				this.totalAmount = totalAmount;
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000AB51 File Offset: 0x00008D51
			public string GetStatus()
			{
				return this.status;
			}

			// Token: 0x060001FB RID: 507 RVA: 0x0000AB59 File Offset: 0x00008D59
			public void SetStatus(string status)
			{
				this.status = status;
			}

			// Token: 0x060001FC RID: 508 RVA: 0x0000AB62 File Offset: 0x00008D62
			public DateTime GetDate()
			{
				return this.date;
			}

			// Token: 0x060001FD RID: 509 RVA: 0x0000AB6A File Offset: 0x00008D6A
			public void SetDate(DateTime date)
			{
				this.date = date;
			}

			// Token: 0x040000AC RID: 172
			public string transactionId;

			// Token: 0x040000AD RID: 173
			public double totalAmount;

			// Token: 0x040000AE RID: 174
			public string status;

			// Token: 0x040000AF RID: 175
			public DateTime date;
		}
	}
}
