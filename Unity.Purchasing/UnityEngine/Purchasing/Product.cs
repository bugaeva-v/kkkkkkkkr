using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D6 RID: 214
	public class Product
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00009B9B File Offset: 0x00007D9B
		[Obsolete("This constructor is obsolete and should not be used. Use the Product(ProductDefinition, ProductMetadata) constructor and assign the receipt separately if needed.")]
		internal Product(ProductDefinition definition, ProductMetadata metadata, string receipt) : this(definition, metadata)
		{
			this.receipt = receipt;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00009BAC File Offset: 0x00007DAC
		internal Product(ProductDefinition definition, ProductMetadata metadata)
		{
			this.definition = definition;
			this.metadata = metadata;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00009BC2 File Offset: 0x00007DC2
		internal static Product CreateUnknownProduct(string productId)
		{
			return new Product(new ProductDefinition(productId, ProductType.Unknown), new ProductMetadata());
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00009BD5 File Offset: 0x00007DD5
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00009BDD File Offset: 0x00007DDD
		public ProductDefinition definition { get; private set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00009BE6 File Offset: 0x00007DE6
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00009BEE File Offset: 0x00007DEE
		public ProductMetadata metadata { get; internal set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00009BF7 File Offset: 0x00007DF7
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00009BFF File Offset: 0x00007DFF
		public bool availableToPurchase { get; internal set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00009C08 File Offset: 0x00007E08
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00009C10 File Offset: 0x00007E10
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string transactionID { get; internal set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00009C19 File Offset: 0x00007E19
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00009C21 File Offset: 0x00007E21
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string appleOriginalTransactionID { get; internal set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00009C2A File Offset: 0x00007E2A
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00009C32 File Offset: 0x00007E32
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public bool appleProductIsRestored { get; internal set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00009C3B File Offset: 0x00007E3B
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public bool hasReceipt
		{
			get
			{
				return !string.IsNullOrEmpty(this.transactionID) && !string.IsNullOrEmpty(this.receipt);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00009C5A File Offset: 0x00007E5A
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00009C62 File Offset: 0x00007E62
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string receipt
		{
			get
			{
				return this.GetReceipt();
			}
			internal set
			{
				this.SetReceipt(value);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00009C6C File Offset: 0x00007E6C
		private string GetReceipt()
		{
			AppStore defaultBuiltInAppStore = DefaultStoreHelper.GetDefaultBuiltInAppStore();
			if (defaultBuiltInAppStore != AppStore.AppleAppStore && defaultBuiltInAppStore != AppStore.MacAppStore)
			{
				return this.m_Receipt;
			}
			if (this.transactionID == null)
			{
				return null;
			}
			IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
			return Product.CreateUnifiedReceipt((apple != null) ? apple.appReceipt : null, this.transactionID, (defaultBuiltInAppStore == AppStore.AppleAppStore) ? "AppleAppStore" : "MacAppStore");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00009CC9 File Offset: 0x00007EC9
		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return UnifiedReceiptFormatter.FormatUnifiedReceipt(rawReceipt, transactionId, storeName);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00009CD4 File Offset: 0x00007ED4
		private void SetReceipt(string curReceipt)
		{
			AppStore defaultBuiltInAppStore = DefaultStoreHelper.GetDefaultBuiltInAppStore();
			if (defaultBuiltInAppStore != AppStore.AppleAppStore && defaultBuiltInAppStore != AppStore.MacAppStore)
			{
				this.m_Receipt = curReceipt;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00009CF8 File Offset: 0x00007EF8
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			Product product = obj as Product;
			return product != null && this.definition.Equals(product.definition);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00009D27 File Offset: 0x00007F27
		public override int GetHashCode()
		{
			return this.definition.GetHashCode();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00009D34 File Offset: 0x00007F34
		public override string ToString()
		{
			return string.Format("Product: {0}, {1}, {2}", this.definition, this.metadata, this.receipt);
		}

		// Token: 0x0400019B RID: 411
		private string m_Receipt;
	}
}
