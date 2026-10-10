using System;
using System.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x0200037A RID: 890
	public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
	{
		// Token: 0x06001E97 RID: 7831 RVA: 0x00031AED File Offset: 0x0002FCED
		public static TCollection Get()
		{
			return CollectionPool<TCollection, TItem>.s_Pool.Get();
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00031AF9 File Offset: 0x0002FCF9
		public static PooledObject<TCollection> Get(out TCollection value)
		{
			return CollectionPool<TCollection, TItem>.s_Pool.Get(out value);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00031B06 File Offset: 0x0002FD06
		public static void Release(TCollection toRelease)
		{
			CollectionPool<TCollection, TItem>.s_Pool.Release(toRelease);
		}

		// Token: 0x04000A03 RID: 2563
		internal static readonly ObjectPool<TCollection> s_Pool = new ObjectPool<TCollection>(() => Activator.CreateInstance<TCollection>(), null, delegate(TCollection l)
		{
			l.Clear();
		}, null, true, 10, 10000);
	}
}
