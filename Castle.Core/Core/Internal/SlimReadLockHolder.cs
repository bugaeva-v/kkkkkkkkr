using System;
using System.ComponentModel;
using System.Threading;

namespace Castle.Core.Internal
{
	// Token: 0x020000E8 RID: 232
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class SlimReadLockHolder : ILockHolder, IDisposable
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x0001212A File Offset: 0x0001032A
		public SlimReadLockHolder(ReaderWriterLockSlim locker, bool waitForLock)
		{
			this.locker = locker;
			if (waitForLock)
			{
				locker.EnterReadLock();
				this.lockAcquired = true;
				return;
			}
			this.lockAcquired = locker.TryEnterReadLock(0);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00012157 File Offset: 0x00010357
		public void Dispose()
		{
			if (!this.LockAcquired)
			{
				return;
			}
			this.locker.ExitReadLock();
			this.lockAcquired = false;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00012174 File Offset: 0x00010374
		public bool LockAcquired
		{
			get
			{
				return this.lockAcquired;
			}
		}

		// Token: 0x04000178 RID: 376
		private readonly ReaderWriterLockSlim locker;

		// Token: 0x04000179 RID: 377
		private bool lockAcquired;
	}
}
