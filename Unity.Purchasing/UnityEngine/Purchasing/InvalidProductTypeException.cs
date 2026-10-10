using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public class InvalidProductTypeException : ReceiptParserException
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00004D9A File Offset: 0x00002F9A
		public InvalidProductTypeException()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004DA2 File Offset: 0x00002FA2
		public InvalidProductTypeException(string message) : base(message)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00004DAB File Offset: 0x00002FAB
		protected InvalidProductTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
