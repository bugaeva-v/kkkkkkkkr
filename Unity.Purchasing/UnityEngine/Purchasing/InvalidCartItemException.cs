using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000034 RID: 52
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class InvalidCartItemException : IapException
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00003607 File Offset: 0x00001807
		public InvalidCartItemException()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000360F File Offset: 0x0000180F
		public InvalidCartItemException(string message) : base(message)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003618 File Offset: 0x00001818
		protected InvalidCartItemException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
