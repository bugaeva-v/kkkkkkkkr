using System;
using System.ComponentModel;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000E9 RID: 233
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class SlimReadWriteLock : Lock
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0001217C File Offset: 0x0001037C
		public SlimReadWriteLock()
		{
			this.locker = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00012190 File Offset: 0x00010390
		internal SlimReadWriteLock(ReaderWriterLockSlim underlyingLock)
		{
			this.locker = underlyingLock;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001219F File Offset: 0x0001039F
		public override IUpgradeableLockHolder ForReadingUpgradeable()
		{
			return this.ForReadingUpgradeable(true);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000121A8 File Offset: 0x000103A8
		public override ILockHolder ForReading()
		{
			return this.ForReading(true);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000121B1 File Offset: 0x000103B1
		public override ILockHolder ForWriting()
		{
			return this.ForWriting(true);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000121BA File Offset: 0x000103BA
		public override IUpgradeableLockHolder ForReadingUpgradeable(bool waitForLock)
		{
			return new SlimUpgradeableReadLockHolder(this.locker, waitForLock, this.locker.IsUpgradeableReadLockHeld || this.locker.IsWriteLockHeld);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000121E3 File Offset: 0x000103E3
		public override ILockHolder ForReading(bool waitForLock)
		{
			if (this.locker.IsReadLockHeld || this.locker.IsUpgradeableReadLockHeld || this.locker.IsWriteLockHeld)
			{
				return NoOpLock.Lock;
			}
			return new SlimReadLockHolder(this.locker, waitForLock);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001221E File Offset: 0x0001041E
		public override ILockHolder ForWriting(bool waitForLock)
		{
			if (this.locker.IsWriteLockHeld)
			{
				return NoOpLock.Lock;
			}
			return new SlimWriteLockHolder(this.locker, waitForLock);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001223F File Offset: 0x0001043F
		public bool IsReadLockHeld
		{
			get
			{
				return this.locker.IsReadLockHeld;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001224C File Offset: 0x0001044C
		public bool IsUpgradeableReadLockHeld
		{
			get
			{
				return this.locker.IsUpgradeableReadLockHeld;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00012259 File Offset: 0x00010459
		public bool IsWriteLockHeld
		{
			get
			{
				return this.locker.IsWriteLockHeld;
			}
		}

		// Token: 0x0400017A RID: 378
		private readonly ReaderWriterLockSlim locker;
	}
}
