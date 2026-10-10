using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200008B RID: 139
	[NullableContext(1)]
	[Nullable(0)]
	public class StoreException : Exception
	{
		// Token: 0x06000267 RID: 615 RVA: 0x000067F7 File Offset: 0x000049F7
		public StoreException()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000067FF File Offset: 0x000049FF
		public StoreException(string message) : base(message)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00006808 File Offset: 0x00004A08
		public StoreException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
