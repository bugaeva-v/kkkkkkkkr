using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000CF RID: 207
	public interface IContextStack
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000521 RID: 1313
		int Count { get; }

		// Token: 0x06000522 RID: 1314
		void Clear();

		// Token: 0x06000523 RID: 1315
		string Pop();

		// Token: 0x06000524 RID: 1316
		IDisposable Push(string message);
	}
}
