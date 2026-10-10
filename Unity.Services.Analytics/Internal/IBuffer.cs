using System;
using System.Collections.Generic;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200002B RID: 43
	internal interface IBuffer
	{
		// Token: 0x0600010B RID: 267
		void PushStandardEventStart(string name, int version);

		// Token: 0x0600010C RID: 268
		void PushCustomEventStart(string name);

		// Token: 0x0600010D RID: 269
		void PushEndEvent();

		// Token: 0x0600010E RID: 270
		void PushDouble(string name, double value);

		// Token: 0x0600010F RID: 271
		void PushFloat(string name, float value);

		// Token: 0x06000110 RID: 272
		void PushString(string name, string value);

		// Token: 0x06000111 RID: 273
		void PushInt64(string name, long value);

		// Token: 0x06000112 RID: 274
		void PushInt(string name, int value);

		// Token: 0x06000113 RID: 275
		void PushBool(string name, bool value);

		// Token: 0x06000114 RID: 276
		void PushObject(string name, object value);

		// Token: 0x06000115 RID: 277
		void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items);

		// Token: 0x06000116 RID: 278
		void FlushToDisk();

		// Token: 0x06000117 RID: 279
		void ClearDiskCache();

		// Token: 0x06000118 RID: 280
		void LoadFromDisk();

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000119 RID: 281
		int Length { get; }

		// Token: 0x0600011A RID: 282
		byte[] Serialize();

		// Token: 0x0600011B RID: 283
		void ClearBuffer();

		// Token: 0x0600011C RID: 284
		void ClearBuffer(long upTo);
	}
}
