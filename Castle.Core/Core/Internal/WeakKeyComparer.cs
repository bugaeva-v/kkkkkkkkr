using System;
using System.Collections.Generic;

namespace Castle.Core.Internal
{
	// Token: 0x020000EF RID: 239
	internal class WeakKeyComparer<TKey> : IEqualityComparer<object> where TKey : class
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x000125AB File Offset: 0x000107AB
		public WeakKeyComparer(IEqualityComparer<TKey> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			this.comparer = comparer;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000125C8 File Offset: 0x000107C8
		public object Wrap(TKey key)
		{
			return new WeakKey(key, this.comparer.GetHashCode(key));
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000125E4 File Offset: 0x000107E4
		public TKey Unwrap(object obj)
		{
			WeakKey weakKey = obj as WeakKey;
			if (weakKey == null)
			{
				return (TKey)((object)obj);
			}
			return (TKey)((object)weakKey.Target);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00012610 File Offset: 0x00010810
		public int GetHashCode(object obj)
		{
			WeakKey weakKey = obj as WeakKey;
			if (weakKey == null)
			{
				return this.comparer.GetHashCode((TKey)((object)obj));
			}
			return weakKey.GetHashCode();
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00012640 File Offset: 0x00010840
		public bool Equals(object objA, object objB)
		{
			TKey tkey = this.Unwrap(objA);
			TKey tkey2 = this.Unwrap(objB);
			if (tkey == null)
			{
				return tkey2 == null && objA == objB;
			}
			return tkey2 != null && this.comparer.Equals(tkey, tkey2);
		}

		// Token: 0x04000184 RID: 388
		public static readonly WeakKeyComparer<TKey> Default = new WeakKeyComparer<TKey>(EqualityComparer<TKey>.Default);

		// Token: 0x04000185 RID: 389
		private readonly IEqualityComparer<TKey> comparer;
	}
}
