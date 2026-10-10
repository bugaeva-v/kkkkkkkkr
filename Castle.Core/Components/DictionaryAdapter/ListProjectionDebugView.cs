using System;
using System.Diagnostics;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200014B RID: 331
	internal sealed class ListProjectionDebugView<T>
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x0001761B File Offset: 0x0001581B
		public ListProjectionDebugView(ListProjection<T> projection)
		{
			if (projection == null)
			{
				throw new ArgumentNullException("projection");
			}
			this.projection = projection;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00017638 File Offset: 0x00015838
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				T[] array = new T[this.projection.Count];
				this.projection.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00017664 File Offset: 0x00015864
		public ICollectionAdapter<T> Adapter
		{
			get
			{
				return this.projection.Adapter;
			}
		}

		// Token: 0x04000205 RID: 517
		private readonly ListProjection<T> projection;
	}
}
