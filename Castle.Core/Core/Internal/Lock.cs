using System;
using System.ComponentModel;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000E4 RID: 228
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class Lock
	{
		// Token: 0x0600061A RID: 1562
		public abstract IUpgradeableLockHolder ForReadingUpgradeable();

		// Token: 0x0600061B RID: 1563
		public abstract ILockHolder ForReading();

		// Token: 0x0600061C RID: 1564
		public abstract ILockHolder ForWriting();

		// Token: 0x0600061D RID: 1565
		public abstract IUpgradeableLockHolder ForReadingUpgradeable(bool waitForLock);

		// Token: 0x0600061E RID: 1566
		public abstract ILockHolder ForReading(bool waitForLock);

		// Token: 0x0600061F RID: 1567
		public abstract ILockHolder ForWriting(bool waitForLock);

		// Token: 0x06000620 RID: 1568 RVA: 0x000120B4 File Offset: 0x000102B4
		public static Lock Create()
		{
			return new SlimReadWriteLock();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000120BB File Offset: 0x000102BB
		internal static Lock CreateFor(ReaderWriterLockSlim underlyingLock)
		{
			return new SlimReadWriteLock(underlyingLock);
		}
	}
}
