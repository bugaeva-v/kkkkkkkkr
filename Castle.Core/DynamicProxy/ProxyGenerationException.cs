using System;

namespace Castle.DynamicProxy
{
	// Token: 0x02000017 RID: 23
	public class ProxyGenerationException : Exception
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000397F File Offset: 0x00001B7F
		public ProxyGenerationException(string message) : base(message)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003988 File Offset: 0x00001B88
		public ProxyGenerationException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
