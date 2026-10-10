using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000045 RID: 69
	internal class DependencyTreeComponentHashException : HashException
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00003763 File Offset: 0x00001963
		public DependencyTreeComponentHashException(int hash) : base(hash)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000376C File Offset: 0x0000196C
		public DependencyTreeComponentHashException(int hash, string message) : base(hash, message)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003776 File Offset: 0x00001976
		public DependencyTreeComponentHashException(int hash, string message, Exception inner) : base(hash, message, inner)
		{
		}
	}
}
