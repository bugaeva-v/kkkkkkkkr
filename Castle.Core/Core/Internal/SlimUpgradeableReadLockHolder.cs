using System;
using System.ComponentModel;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000EA RID: 234
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class SlimUpgradeableReadLockHolder : IUpgradeableLockHolder, ILockHolder, IDisposable
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x00012266 File Offset: 0x00010466
		public SlimUpgradeableReadLockHolder(ReaderWriterLockSlim locker, bool waitForLock, bool wasLockAlreadyHelf)
		{
			this.locker = locker;
			if (wasLockAlreadyHelf)
			{
				this.lockAcquired = true;
				this.wasLockAlreadyHeld = true;
				return;
			}
			if (waitForLock)
			{
				locker.EnterUpgradeableReadLock();
				this.lockAcquired = true;
				return;
			}
			this.lockAcquired = locker.TryEnterUpgradeableReadLock(0);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000122A8 File Offset: 0x000104A8
		public void Dispose()
		{
			if (this.writerLock != null && this.writerLock.LockAcquired)
			{
				this.writerLock.Dispose();
				this.writerLock = null;
			}
			if (!this.LockAcquired)
			{
				return;
			}
			if (!this.wasLockAlreadyHeld)
			{
				this.locker.ExitUpgradeableReadLock();
			}
			this.lockAcquired = false;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000122FF File Offset: 0x000104FF
		public ILockHolder Upgrade()
		{
			return this.Upgrade(true);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00012308 File Offset: 0x00010508
		public ILockHolder Upgrade(bool waitForLock)
		{
			if (this.locker.IsWriteLockHeld)
			{
				return NoOpLock.Lock;
			}
			this.writerLock = new SlimWriteLockHolder(this.locker, waitForLock);
			return this.writerLock;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00012335 File Offset: 0x00010535
		public bool LockAcquired
		{
			get
			{
				return this.lockAcquired;
			}
		}

		// Token: 0x0400017B RID: 379
		private readonly ReaderWriterLockSlim locker;

		// Token: 0x0400017C RID: 380
		private bool lockAcquired;

		// Token: 0x0400017D RID: 381
		private SlimWriteLockHolder writerLock;

		// Token: 0x0400017E RID: 382
		private bool wasLockAlreadyHeld;
	}
}
