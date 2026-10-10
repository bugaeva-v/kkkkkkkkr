using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000037 RID: 55
	public class CircularDependencyException : ServicesInitializationException
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public CircularDependencyException()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002AFC File Offset: 0x00000CFC
		public CircularDependencyException(string message) : base(message)
		{
		}
	}
}
