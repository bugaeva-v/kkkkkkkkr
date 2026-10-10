using System;
using System.Collections;
using System.Collections.Generic;

namespace Castle.Core.Internal
{
	// Token: 0x020000F0 RID: 240
	internal class WeakKeyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x0001269C File Offset: 0x0001089C
		public WeakKeyDictionary() : this(0, EqualityComparer<TKey>.Default)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000126AA File Offset: 0x000108AA
		public WeakKeyDictionary(int capacity) : this(capacity, EqualityComparer<TKey>.Default)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000126B8 File Offset: 0x000108B8
		public WeakKeyDictionary(IEqualityComparer<TKey> comparer) : this(0, comparer)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000126C2 File Offset: 0x000108C2
		public WeakKeyDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			this.comparer = new WeakKeyComparer<TKey>(comparer);
			this.dictionary = new Dictionary<object, TValue>(capacity, this.comparer);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000126E8 File Offset: 0x000108E8
		public int Count
		{
			get
			{
				this.Age(1);
				return this.dictionary.Count;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x000126FC File Offset: 0x000108FC
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00012700 File Offset: 0x00010900
		public ICollection<TKey> Keys
		{
			get
			{
				WeakKeyDictionary<TKey, TValue>.KeyCollection result;
				if ((result = this.keys) == null)
				{
					result = (this.keys = new WeakKeyDictionary<TKey, TValue>.KeyCollection(this.dictionary.Keys));
				}
				return result;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00012730 File Offset: 0x00010930
		public ICollection<TValue> Values
		{
			get
			{
				return this.dictionary.Values;
			}
		}

		// Token: 0x170000EA RID: 234
		public TValue this[TKey key]
		{
			get
			{
				this.Age(1);
				return this.dictionary[key];
			}
			set
			{
				this.Age(4);
				this.dictionary[this.comparer.Wrap(key)] = value;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00012778 File Offset: 0x00010978
		public bool ContainsKey(TKey key)
		{
			this.Age(1);
			return this.dictionary.ContainsKey(key);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00012794 File Offset: 0x00010994
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			this.Age(1);
			TValue x;
			return this.dictionary.TryGetValue(item.Key, out x) && EqualityComparer<TValue>.Default.Equals(x, item.Value);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000127D7 File Offset: 0x000109D7
		public bool TryGetValue(TKey key, out TValue value)
		{
			this.Age(1);
			return this.dictionary.TryGetValue(key, out value);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000127F2 File Offset: 0x000109F2
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			bool hasDeadObjects = false;
			foreach (KeyValuePair<object, TValue> keyValuePair in this.dictionary)
			{
				KeyValuePair<TKey, TValue> keyValuePair2 = new KeyValuePair<TKey, TValue>(this.comparer.Unwrap(keyValuePair.Key), keyValuePair.Value);
				if (keyValuePair2.Key == null)
				{
					hasDeadObjects = true;
				}
				else
				{
					yield return keyValuePair2;
				}
			}
			Dictionary<object, TValue>.Enumerator enumerator = default(Dictionary<object, TValue>.Enumerator);
			if (hasDeadObjects)
			{
				this.TrimDeadObjects();
			}
			yield break;
			yield break;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00012801 File Offset: 0x00010A01
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001280C File Offset: 0x00010A0C
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			foreach (KeyValuePair<TKey, TValue> keyValuePair in this)
			{
				array[index++] = keyValuePair;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001285C File Offset: 0x00010A5C
		public void Add(TKey key, TValue value)
		{
			this.Age(2);
			this.dictionary.Add(this.comparer.Wrap(key), value);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001287D File Offset: 0x00010A7D
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00012893 File Offset: 0x00010A93
		public bool Remove(TKey key)
		{
			this.Age(4);
			return this.dictionary.Remove(key);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x000128AD File Offset: 0x00010AAD
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return ((ICollection<KeyValuePair<TKey, TValue>>)this).Contains(item) && this.Remove(item.Key);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000128C7 File Offset: 0x00010AC7
		public void Clear()
		{
			this.age = 0;
			this.dictionary.Clear();
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000128DC File Offset: 0x00010ADC
		private void Age(int amount)
		{
			if ((this.age += amount) > 128)
			{
				this.TrimDeadObjects();
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00012908 File Offset: 0x00010B08
		public void TrimDeadObjects()
		{
			this.age = 0;
			List<object> list = null;
			foreach (object obj in this.dictionary.Keys)
			{
				if (this.comparer.Unwrap(obj) == null)
				{
					if (list == null)
					{
						list = new List<object>();
					}
					list.Add(obj);
				}
			}
			if (list != null)
			{
				foreach (object key in list)
				{
					this.dictionary.Remove(key);
				}
			}
		}

		// Token: 0x04000186 RID: 390
		private readonly Dictionary<object, TValue> dictionary;

		// Token: 0x04000187 RID: 391
		private readonly WeakKeyComparer<TKey> comparer;

		// Token: 0x04000188 RID: 392
		private WeakKeyDictionary<TKey, TValue>.KeyCollection keys;

		// Token: 0x04000189 RID: 393
		private int age;

		// Token: 0x0400018A RID: 394
		private const int AgeThreshold = 128;

		// Token: 0x020001F3 RID: 499
		private class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x06000E6C RID: 3692 RVA: 0x00022562 File Offset: 0x00020762
			public KeyCollection(ICollection<object> keys)
			{
				this.keys = keys;
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00022571 File Offset: 0x00020771
			public int Count
			{
				get
				{
					return this.keys.Count;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0002257E File Offset: 0x0002077E
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000E6F RID: 3695 RVA: 0x00022581 File Offset: 0x00020781
			public bool Contains(TKey item)
			{
				return this.keys.Contains(item);
			}

			// Token: 0x06000E70 RID: 3696 RVA: 0x00022594 File Offset: 0x00020794
			public IEnumerator<TKey> GetEnumerator()
			{
				foreach (object obj in this.keys)
				{
					TKey tkey = (TKey)((object)((WeakKey)obj).Target);
					if (tkey != null)
					{
						yield return tkey;
					}
				}
				IEnumerator<object> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x06000E71 RID: 3697 RVA: 0x000225A3 File Offset: 0x000207A3
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06000E72 RID: 3698 RVA: 0x000225AC File Offset: 0x000207AC
			public void CopyTo(TKey[] array, int index)
			{
				foreach (TKey tkey in this)
				{
					array[index++] = tkey;
				}
			}

			// Token: 0x06000E73 RID: 3699 RVA: 0x000225FC File Offset: 0x000207FC
			void ICollection<!0>.Add(TKey item)
			{
				throw WeakKeyDictionary<TKey, TValue>.KeyCollection.ReadOnlyCollectionError();
			}

			// Token: 0x06000E74 RID: 3700 RVA: 0x00022603 File Offset: 0x00020803
			bool ICollection<!0>.Remove(TKey item)
			{
				throw WeakKeyDictionary<TKey, TValue>.KeyCollection.ReadOnlyCollectionError();
			}

			// Token: 0x06000E75 RID: 3701 RVA: 0x0002260A File Offset: 0x0002080A
			void ICollection<!0>.Clear()
			{
				throw WeakKeyDictionary<TKey, TValue>.KeyCollection.ReadOnlyCollectionError();
			}

			// Token: 0x06000E76 RID: 3702 RVA: 0x00022611 File Offset: 0x00020811
			private static Exception ReadOnlyCollectionError()
			{
				return new NotSupportedException("The collection is read-only.");
			}

			// Token: 0x040003AD RID: 941
			private readonly ICollection<object> keys;
		}
	}
}
