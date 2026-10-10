using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D8 RID: 216
	public class ProductDefinition
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00009E02 File Offset: 0x00008002
		private ProductDefinition()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00009E15 File Offset: 0x00008015
		public ProductDefinition(string id, string storeSpecificId, ProductType type) : this(id, storeSpecificId, type, true)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00009E21 File Offset: 0x00008021
		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled) : this(id, storeSpecificId, type, enabled, null)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00009E2F File Offset: 0x0000802F
		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, PayoutDefinition payout) : this(id, storeSpecificId, type, enabled, new List<PayoutDefinition>
		{
			payout
		})
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00009E49 File Offset: 0x00008049
		public ProductDefinition(string id, ProductType type, bool enabled, PayoutDefinition payout) : this(id, id, type, enabled, new List<PayoutDefinition>
		{
			payout
		})
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00009E62 File Offset: 0x00008062
		public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
		{
			this.id = id;
			this.storeSpecificId = storeSpecificId;
			this.type = type;
			this.enabled = enabled;
			this.SetPayouts(payouts);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00009E9A File Offset: 0x0000809A
		public ProductDefinition(string id, ProductType type) : this(id, id, type)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00009EA5 File Offset: 0x000080A5
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00009EAD File Offset: 0x000080AD
		public string id { get; private set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00009EB6 File Offset: 0x000080B6
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00009EBE File Offset: 0x000080BE
		public string storeSpecificId { get; internal set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00009EC7 File Offset: 0x000080C7
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00009ECF File Offset: 0x000080CF
		public ProductType type { get; private set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00009ED8 File Offset: 0x000080D8
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00009EE0 File Offset: 0x000080E0
		public bool enabled { get; private set; }

		// Token: 0x06000439 RID: 1081 RVA: 0x00009EE9 File Offset: 0x000080E9
		public override string ToString()
		{
			return string.Format("ProductDefinition: {0}, {1}, {2}, {3}", new object[]
			{
				this.id,
				this.storeSpecificId,
				this.type,
				this.enabled
			});
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00009F2C File Offset: 0x0000812C
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			ProductDefinition productDefinition = obj as ProductDefinition;
			return productDefinition != null && this.id == productDefinition.id;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00009F5B File Offset: 0x0000815B
		public override int GetHashCode()
		{
			return this.id.GetHashCode();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00009F68 File Offset: 0x00008168
		public IEnumerable<PayoutDefinition> payouts
		{
			get
			{
				return this.m_Payouts;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00009F70 File Offset: 0x00008170
		public PayoutDefinition payout
		{
			get
			{
				if (this.m_Payouts.Count <= 0)
				{
					return null;
				}
				return this.m_Payouts[0];
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00009F8E File Offset: 0x0000818E
		internal void SetPayouts(IEnumerable<PayoutDefinition> newPayouts)
		{
			if (newPayouts == null)
			{
				return;
			}
			this.m_Payouts.Clear();
			this.m_Payouts.AddRange(newPayouts);
		}

		// Token: 0x040001A2 RID: 418
		private readonly List<PayoutDefinition> m_Payouts = new List<PayoutDefinition>();
	}
}
