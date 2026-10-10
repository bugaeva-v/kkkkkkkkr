using System;
using UnityEngine;

namespace DG.DemiLib
{
	// Token: 0x02000006 RID: 6
	public abstract class DeScope : IDisposable
	{
		// Token: 0x06000007 RID: 7
		protected abstract void CloseScope();

		// Token: 0x06000008 RID: 8 RVA: 0x000024AC File Offset: 0x000006AC
		~DeScope()
		{
			if (!this._disposed)
			{
				Debug.LogError("Scope was not disposed! You should use the 'using' keyword or manually call Dispose.");
				this.Dispose();
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024EC File Offset: 0x000006EC
		public void Dispose()
		{
			if (this._disposed)
			{
				return;
			}
			this._disposed = true;
			this.CloseScope();
		}

		// Token: 0x04000015 RID: 21
		private bool _disposed;
	}
}
