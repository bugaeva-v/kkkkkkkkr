using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000033 RID: 51
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class InvalidCartException : IapException
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000035EC File Offset: 0x000017EC
		public InvalidCartException()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000035F4 File Offset: 0x000017F4
		public InvalidCartException(string message) : base(message)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000035FD File Offset: 0x000017FD
		protected InvalidCartException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
