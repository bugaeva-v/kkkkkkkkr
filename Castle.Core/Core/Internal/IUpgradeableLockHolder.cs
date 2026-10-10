using System;
using System.ComponentModel;

namespace Castle.Core.Internal
{
	// Token: 0x020000E3 RID: 227
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IUpgradeableLockHolder : ILockHolder, IDisposable
	{
		// Token: 0x06000618 RID: 1560
		ILockHolder Upgrade();

		// Token: 0x06000619 RID: 1561
		ILockHolder Upgrade(bool waitForLock);
	}
}
