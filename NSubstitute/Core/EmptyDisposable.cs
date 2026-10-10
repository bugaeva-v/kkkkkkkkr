using System;

namespace NSubstitute.Core
{
	// Token: 0x020000B2 RID: 178
	internal class EmptyDisposable : IDisposable
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00007348 File Offset: 0x00005548
		public static IDisposable Instance { get; } = new EmptyDisposable();

		// Token: 0x060002BA RID: 698 RVA: 0x0000734F File Offset: 0x0000554F
		public void Dispose()
		{
		}
	}
}
