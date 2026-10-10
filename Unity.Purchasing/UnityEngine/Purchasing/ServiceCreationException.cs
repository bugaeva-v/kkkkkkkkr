using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000A RID: 10
	[NullableContext(1)]
	[Nullable(0)]
	public class ServiceCreationException : IapException
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002201 File Offset: 0x00000401
		internal ServiceCreationException()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002209 File Offset: 0x00000409
		internal ServiceCreationException(string message) : base(message)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002212 File Offset: 0x00000412
		protected ServiceCreationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
