using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D4 RID: 212
	[Serializable]
	public class PayoutDefinition
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000099F7 File Offset: 0x00007BF7
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000099FF File Offset: 0x00007BFF
		public PayoutType type
		{
			get
			{
				return this.m_Type;
			}
			private set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00009A08 File Offset: 0x00007C08
		public string typeString
		{
			get
			{
				return this.m_Type.ToString();
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00009A1B File Offset: 0x00007C1B
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00009A23 File Offset: 0x00007C23
		public string subtype
		{
			get
			{
				return this.m_Subtype;
			}
			private set
			{
				if (value.Length > 64)
				{
					throw new ArgumentException(string.Format("subtype cannot be longer than {0}", 64));
				}
				this.m_Subtype = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00009A4D File Offset: 0x00007C4D
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00009A55 File Offset: 0x00007C55
		public double quantity
		{
			get
			{
				return this.m_Quantity;
			}
			private set
			{
				this.m_Quantity = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00009A5E File Offset: 0x00007C5E
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00009A66 File Offset: 0x00007C66
		public string data
		{
			get
			{
				return this.m_Data;
			}
			private set
			{
				if (value.Length > 1024)
				{
					throw new ArgumentException(string.Format("data cannot be longer than {0}", 1024));
				}
				this.m_Data = value;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00009A96 File Offset: 0x00007C96
		public PayoutDefinition()
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public PayoutDefinition(string typeString, string subtype, double quantity) : this(typeString, subtype, quantity, string.Empty)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public PayoutDefinition(string typeString, string subtype, double quantity, string data)
		{
			PayoutType type = PayoutType.Other;
			if (Enum.IsDefined(typeof(PayoutType), typeString))
			{
				type = (PayoutType)Enum.Parse(typeof(PayoutType), typeString);
			}
			this.type = type;
			this.subtype = subtype;
			this.quantity = quantity;
			this.data = data;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00009B34 File Offset: 0x00007D34
		public PayoutDefinition(string subtype, double quantity) : this(PayoutType.Other, subtype, quantity, string.Empty)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00009B44 File Offset: 0x00007D44
		public PayoutDefinition(string subtype, double quantity, string data) : this(PayoutType.Other, subtype, quantity, data)
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00009B50 File Offset: 0x00007D50
		public PayoutDefinition(PayoutType type, string subtype, double quantity) : this(type, subtype, quantity, string.Empty)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00009B60 File Offset: 0x00007D60
		public PayoutDefinition(PayoutType type, string subtype, double quantity, string data)
		{
			this.type = type;
			this.subtype = subtype;
			this.quantity = quantity;
			this.data = data;
		}

		// Token: 0x0400018A RID: 394
		[SerializeField]
		private PayoutType m_Type;

		// Token: 0x0400018B RID: 395
		[SerializeField]
		private string m_Subtype = string.Empty;

		// Token: 0x0400018C RID: 396
		[SerializeField]
		private double m_Quantity;

		// Token: 0x0400018D RID: 397
		[SerializeField]
		private string m_Data = string.Empty;

		// Token: 0x0400018E RID: 398
		public const int MaxSubtypeLength = 64;

		// Token: 0x0400018F RID: 399
		public const int MaxDataLength = 1024;
	}
}
