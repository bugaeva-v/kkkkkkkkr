using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000009 RID: 9
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public abstract class IapException : Exception
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000021E6 File Offset: 0x000003E6
		internal IapException()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021EE File Offset: 0x000003EE
		internal IapException(string message) : base(message)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021F7 File Offset: 0x000003F7
		protected IapException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
