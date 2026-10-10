using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public class NullProductIdException : ReceiptParserException
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00004DB5 File Offset: 0x00002FB5
		public NullProductIdException()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00004DBD File Offset: 0x00002FBD
		public NullProductIdException(string message) : base(message)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004DC6 File Offset: 0x00002FC6
		protected NullProductIdException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
