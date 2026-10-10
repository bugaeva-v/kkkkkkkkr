using System;
using System.ComponentModel;

namespace Castle.Core.Internal
{
	// Token: 0x020000E5 RID: 229
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class NoOpLock : ILockHolder, IDisposable
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x000120CB File Offset: 0x000102CB
		public void Dispose()
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000120CD File Offset: 0x000102CD
		public bool LockAcquired
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000176 RID: 374
		public static readonly ILockHolder Lock = new NoOpLock();
	}
}
