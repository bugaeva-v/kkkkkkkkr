using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000002 RID: 2
	internal class iOSStoreBindings : INativeAppleStore, INativeStore
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public void RestoreTransactions()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000205E File Offset: 0x0000025E
		public void SetAppAccountToken(string token)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002065 File Offset: 0x00000265
		public string AppReceipt()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		public void Connect()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002073 File Offset: 0x00000273
		public void AddTransactionObserver()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207A File Offset: 0x0000027A
		public void FetchProducts(string json)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002081 File Offset: 0x00000281
		public void FetchExistingPurchases()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002088 File Offset: 0x00000288
		public void Purchase(string productJSON, string developerPayload)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000208F File Offset: 0x0000028F
		public void FinishTransaction(string productJSON, string transactionID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002096 File Offset: 0x00000296
		public bool CheckEntitlement(string productJSON)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000209D File Offset: 0x0000029D
		public bool canMakePayments
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020A4 File Offset: 0x000002A4
		public void FetchStorePromotionOrder()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020AB File Offset: 0x000002AB
		public void SetStorePromotionOrder(string json)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020B2 File Offset: 0x000002B2
		public void FetchStorePromotionVisibility(string productId)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020B9 File Offset: 0x000002B9
		public void SetStorePromotionVisibility(string productId, string visibility)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020C0 File Offset: 0x000002C0
		public void InterceptPromotionalPurchases()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020C7 File Offset: 0x000002C7
		public void ContinuePromotionalPurchases()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020CE File Offset: 0x000002CE
		public void PresentCodeRedemptionSheet()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020D5 File Offset: 0x000002D5
		public void DeallocateMemory(IntPtr pointer)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020DC File Offset: 0x000002DC
		public void RefreshAppReceipt()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E3 File Offset: 0x000002E3
		public void FetchPurchases(string json)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020EA File Offset: 0x000002EA
		public void Purchase(string productJson, string optionsJson, StorefrontChangeCallback callback)
		{
			throw new NotImplementedException();
		}
	}
}
