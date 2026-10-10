using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000AA RID: 170
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	internal class DependencyInjectionException : Exception
	{
		// Token: 0x06000303 RID: 771 RVA: 0x000072FC File Offset: 0x000054FC
		internal DependencyInjectionException()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00007304 File Offset: 0x00005504
		internal DependencyInjectionException(string message) : base(message)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000730D File Offset: 0x0000550D
		protected DependencyInjectionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
