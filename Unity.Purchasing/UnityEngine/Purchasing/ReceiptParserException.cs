using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class ReceiptParserException : IapException
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00004D7F File Offset: 0x00002F7F
		public ReceiptParserException()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00004D87 File Offset: 0x00002F87
		public ReceiptParserException(string message) : base(message)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00004D90 File Offset: 0x00002F90
		protected ReceiptParserException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
