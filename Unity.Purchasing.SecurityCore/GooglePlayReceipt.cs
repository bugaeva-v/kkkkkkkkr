using System;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000005 RID: 5
	public class GooglePlayReceipt : IPurchaseReceipt
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002192 File Offset: 0x00000392
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000219A File Offset: 0x0000039A
		public string productID { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021A3 File Offset: 0x000003A3
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021AB File Offset: 0x000003AB
		public string orderID { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000021B4 File Offset: 0x000003B4
		public string transactionID
		{
			get
			{
				return this.orderID;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000021BC File Offset: 0x000003BC
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000021C4 File Offset: 0x000003C4
		public string packageName { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000021CD File Offset: 0x000003CD
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000021D5 File Offset: 0x000003D5
		public string purchaseToken { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000021DE File Offset: 0x000003DE
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000021E6 File Offset: 0x000003E6
		public DateTime purchaseDate { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000021EF File Offset: 0x000003EF
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000021F7 File Offset: 0x000003F7
		public GooglePurchaseState purchaseState { get; private set; }

		// Token: 0x06000034 RID: 52 RVA: 0x00002200 File Offset: 0x00000400
		public GooglePlayReceipt(string productID, string orderID, string packageName, string purchaseToken, DateTime purchaseTime, GooglePurchaseState purchaseState)
		{
			this.productID = productID;
			this.orderID = orderID;
			this.packageName = packageName;
			this.purchaseToken = purchaseToken;
			this.purchaseDate = purchaseTime;
			this.purchaseState = purchaseState;
		}
	}
}
