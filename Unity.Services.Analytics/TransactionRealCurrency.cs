using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics
{
	// Token: 0x02000010 RID: 16
	public class TransactionRealCurrency
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000037CF File Offset: 0x000019CF
		internal void Serialize(IBuffer buffer)
		{
			buffer.PushString("realCurrencyType", this.RealCurrencyType);
			buffer.PushInt64("realCurrencyAmount", this.RealCurrencyAmount);
		}

		// Token: 0x04000041 RID: 65
		public string RealCurrencyType;

		// Token: 0x04000042 RID: 66
		public long RealCurrencyAmount;
	}
}
