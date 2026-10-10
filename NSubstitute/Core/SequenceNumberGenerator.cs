using System;
using System.Threading;

namespace NSubstitute.Core
{
	// Token: 0x020000B6 RID: 182
	public class SequenceNumberGenerator
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00007528 File Offset: 0x00005728
		public virtual long Next()
		{
			return Interlocked.Increment(ref this._current);
		}

		// Token: 0x040000BE RID: 190
		private long _current = long.MinValue;
	}
}
