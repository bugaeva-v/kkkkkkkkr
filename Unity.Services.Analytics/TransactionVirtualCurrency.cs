using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics
{
	// Token: 0x02000012 RID: 18
	public class TransactionVirtualCurrency
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003838 File Offset: 0x00001A38
		internal void Serialize(IBuffer buffer)
		{
			buffer.PushString("virtualCurrencyName", this.VirtualCurrencyName);
			buffer.PushString("virtualCurrencyType", TransactionVirtualCurrency.k_VirtualCurrencyTypeValues[(int)this.VirtualCurrencyType]);
			buffer.PushInt64("virtualCurrencyAmount", this.VirtualCurrencyAmount);
		}

		// Token: 0x04000046 RID: 70
		private static readonly string[] k_VirtualCurrencyTypeValues = Event.BakeEnum2String<VirtualCurrencyType>(false);

		// Token: 0x04000047 RID: 71
		public string VirtualCurrencyName;

		// Token: 0x04000048 RID: 72
		public VirtualCurrencyType VirtualCurrencyType;

		// Token: 0x04000049 RID: 73
		public long VirtualCurrencyAmount;
	}
}
