using System;
using System.ComponentModel;

namespace Castle.Core.Internal
{
	// Token: 0x020000E6 RID: 230
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class NoOpUpgradeableLock : IUpgradeableLockHolder, ILockHolder, IDisposable
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x000120E4 File Offset: 0x000102E4
		public void Dispose()
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000120E6 File Offset: 0x000102E6
		public bool LockAcquired
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000120E9 File Offset: 0x000102E9
		public ILockHolder Upgrade()
		{
			return NoOpLock.Lock;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000120F0 File Offset: 0x000102F0
		public ILockHolder Upgrade(bool waitForLock)
		{
			return NoOpLock.Lock;
		}

		// Token: 0x04000177 RID: 375
		public static readonly IUpgradeableLockHolder Lock = new NoOpUpgradeableLock();
	}
}
