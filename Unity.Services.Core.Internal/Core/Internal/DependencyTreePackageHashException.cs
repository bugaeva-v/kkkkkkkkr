using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000044 RID: 68
	internal class DependencyTreePackageHashException : HashException
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00003745 File Offset: 0x00001945
		public DependencyTreePackageHashException(int hash) : base(hash)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000374E File Offset: 0x0000194E
		public DependencyTreePackageHashException(int hash, string message) : base(hash, message)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003758 File Offset: 0x00001958
		public DependencyTreePackageHashException(int hash, string message, Exception inner) : base(hash, message, inner)
		{
		}
	}
}
