using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000F RID: 15
	[NullableContext(1)]
	internal interface ITransactionLog
	{
		// Token: 0x06000042 RID: 66
		void Clear();

		// Token: 0x06000043 RID: 67
		bool HasRecordOf(string transactionID);

		// Token: 0x06000044 RID: 68
		void Record(string transactionID);
	}
}
