using System;
using System.ComponentModel;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000EB RID: 235
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class SlimWriteLockHolder : ILockHolder, IDisposable
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x0001233D File Offset: 0x0001053D
		public SlimWriteLockHolder(ReaderWriterLockSlim locker, bool waitForLock)
		{
			this.locker = locker;
			if (waitForLock)
			{
				locker.EnterWriteLock();
				this.lockAcquired = true;
				return;
			}
			this.lockAcquired = locker.TryEnterWriteLock(0);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001236A File Offset: 0x0001056A
		public void Dispose()
		{
			if (!this.LockAcquired)
			{
				return;
			}
			this.locker.ExitWriteLock();
			this.lockAcquired = false;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00012387 File Offset: 0x00010587
		public bool LockAcquired
		{
			get
			{
				return this.lockAcquired;
			}
		}

		// Token: 0x0400017F RID: 383
		private readonly ReaderWriterLockSlim locker;

		// Token: 0x04000180 RID: 384
		private bool lockAcquired;
	}
}
