using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public class NullReceiptException : ReceiptParserException
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public NullReceiptException()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public NullReceiptException(string message) : base(message)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004DE1 File Offset: 0x00002FE1
		protected NullReceiptException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
