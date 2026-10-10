using System;
using System.Runtime.Serialization;

namespace Castle.Core.Resource
{
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public class ResourceException : Exception
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00010924 File Offset: 0x0000EB24
		public ResourceException()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001092C File Offset: 0x0000EB2C
		public ResourceException(string message) : base(message)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00010935 File Offset: 0x0000EB35
		public ResourceException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001093F File Offset: 0x0000EB3F
		protected ResourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
