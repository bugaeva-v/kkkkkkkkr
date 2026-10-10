using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x02000013 RID: 19
	public class TransactionEvent : Event
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00003888 File Offset: 0x00001A88
		public TransactionEvent() : this("transaction")
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003895 File Offset: 0x00001A95
		protected internal TransactionEvent(string name) : base(name, true, 1)
		{
			this.SpentVirtualCurrencies = new List<TransactionVirtualCurrency>();
			this.SpentItems = new List<TransactionItem>();
			this.ReceivedVirtualCurrencies = new List<TransactionVirtualCurrency>();
			this.ReceivedItems = new List<TransactionItem>();
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000038CC File Offset: 0x00001ACC
		public string TransactionName
		{
			set
			{
				base.SetParameter("transactionName", value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000038DA File Offset: 0x00001ADA
		public string TransactionId
		{
			set
			{
				base.SetParameter("transactionID", value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000038E8 File Offset: 0x00001AE8
		public TransactionType TransactionType
		{
			set
			{
				base.SetParameter("transactionType", TransactionEvent.k_TransactionTypeValues[(int)value]);
			}
		}

		// Token: 0x1700002A RID: 42
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000038FC File Offset: 0x00001AFC
		public string PaymentCountry
		{
			set
			{
				base.SetParameter("paymentCountry", value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000390A File Offset: 0x00001B0A
		public string ProductId
		{
			set
			{
				base.SetParameter("productID", value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00003918 File Offset: 0x00001B18
		public string StoreItemSkuId
		{
			set
			{
				base.SetParameter("storeItemSkuID", value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00003926 File Offset: 0x00001B26
		public string StoreItemId
		{
			set
			{
				base.SetParameter("storeItemID", value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003934 File Offset: 0x00001B34
		public string StoreId
		{
			set
			{
				base.SetParameter("storeID", value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00003942 File Offset: 0x00001B42
		public string StoreSourceId
		{
			set
			{
				base.SetParameter("storeSourceID", value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003950 File Offset: 0x00001B50
		public string TransactionReceipt
		{
			set
			{
				base.SetParameter("transactionReceipt", value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000395E File Offset: 0x00001B5E
		public string TransactionReceiptSignature
		{
			set
			{
				base.SetParameter("transactionReceiptSignature", value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000396C File Offset: 0x00001B6C
		public TransactionServer TransactionServer
		{
			set
			{
				base.SetParameter("transactionServer", TransactionEvent.k_TransactionServerValues[(int)value]);
			}
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00003980 File Offset: 0x00001B80
		public string TransactorID
		{
			set
			{
				base.SetParameter("transactorID", value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000398E File Offset: 0x00001B8E
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00003996 File Offset: 0x00001B96
		public TransactionRealCurrency SpentRealCurrency { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000399F File Offset: 0x00001B9F
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000039A7 File Offset: 0x00001BA7
		public List<TransactionVirtualCurrency> SpentVirtualCurrencies { get; private set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000039B8 File Offset: 0x00001BB8
		public List<TransactionItem> SpentItems { get; private set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000039C1 File Offset: 0x00001BC1
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000039C9 File Offset: 0x00001BC9
		public TransactionRealCurrency ReceivedRealCurrency { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000039D2 File Offset: 0x00001BD2
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000039DA File Offset: 0x00001BDA
		public List<TransactionVirtualCurrency> ReceivedVirtualCurrencies { get; private set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000039E3 File Offset: 0x00001BE3
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000039EB File Offset: 0x00001BEB
		public List<TransactionItem> ReceivedItems { get; private set; }

		// Token: 0x06000081 RID: 129 RVA: 0x000039F4 File Offset: 0x00001BF4
		internal override void Serialize(IBuffer buffer)
		{
			buffer.PushString("sdkVersion", SdkVersion.SDK_VERSION);
			base.Serialize(buffer);
			buffer.PushProduct("productsReceived", this.ReceivedRealCurrency, this.ReceivedVirtualCurrencies, this.ReceivedItems);
			buffer.PushProduct("productsSpent", this.SpentRealCurrency, this.SpentVirtualCurrencies, this.SpentItems);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003A52 File Offset: 0x00001C52
		public override void Validate()
		{
			base.Validate();
			if (!base.ParameterHasBeenSet("transactionName"))
			{
				Debug.LogWarning("A value for the TransactionName parameter is required for a Transaction event.");
			}
			if (!base.ParameterHasBeenSet("transactionType"))
			{
				Debug.LogWarning("A value for the TransactionType parameter is required for a Transaction event.");
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003A88 File Offset: 0x00001C88
		public override void Reset()
		{
			base.Reset();
			this.SpentRealCurrency = null;
			this.SpentItems.Clear();
			this.SpentVirtualCurrencies.Clear();
			this.ReceivedRealCurrency = null;
			this.ReceivedItems.Clear();
			this.ReceivedVirtualCurrencies.Clear();
		}

		// Token: 0x0400004A RID: 74
		private static readonly string[] k_TransactionTypeValues = Event.BakeEnum2String<TransactionType>(false);

		// Token: 0x0400004B RID: 75
		private static readonly string[] k_TransactionServerValues = Event.BakeEnum2String<TransactionServer>(false);
	}
}
