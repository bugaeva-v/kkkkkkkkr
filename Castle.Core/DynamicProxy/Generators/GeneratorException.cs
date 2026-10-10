using System;
using System.Runtime.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class GeneratorException : Exception
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x000074E0 File Offset: 0x000056E0
		public GeneratorException(string message) : base(message)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000074E9 File Offset: 0x000056E9
		public GeneratorException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000074F3 File Offset: 0x000056F3
		public GeneratorException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
