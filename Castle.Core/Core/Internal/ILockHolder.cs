using System;
using System.ComponentModel;

namespace Castle.Core.Internal
{
	// Token: 0x020000E0 RID: 224
	[Obsolete("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and related types.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ILockHolder : IDisposable
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000607 RID: 1543
		bool LockAcquired { get; }
	}
}
