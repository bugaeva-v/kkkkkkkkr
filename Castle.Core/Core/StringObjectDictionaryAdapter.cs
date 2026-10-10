using System;
using System.Collections;
using System.Collections.Generic;

namespace Castle.Core
{
	// Token: 0x020000B4 RID: 180
	public sealed class StringObjectDictionaryAdapter : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x0000FA57 File Offset: 0x0000DC57
		public StringObjectDictionaryAdapter(IDictionary dictionary)
		{
			this.dictionary = dictionary;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000FA66 File Offset: 0x0000DC66
		bool IDictionary<string, object>.ContainsKey(string key)
		{
			return this.dictionary.Contains(key);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000FA74 File Offset: 0x0000DC74
		void IDictionary<string, object>.Add(string key, object value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000FA7B File Offset: 0x0000DC7B
		bool IDictionary<string, object>.Remove(string key)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000FA82 File Offset: 0x0000DC82
		bool IDictionary<string, object>.TryGetValue(string key, out object value)
		{
			value = null;
			if (this.dictionary.Contains(key))
			{
				value = this.dictionary[key];
				return true;
			}
			return false;
		}

		// Token: 0x1700009C RID: 156
		object IDictionary<string, object>.this[string key]
		{
			get
			{
				return this.dictionary[key];
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000FABC File Offset: 0x0000DCBC
		ICollection<string> IDictionary<string, object>.Keys
		{
			get
			{
				string[] array = new string[this.Count];
				this.dictionary.Keys.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
		ICollection<object> IDictionary<string, object>.Values
		{
			get
			{
				object[] array = new object[this.Count];
				this.dictionary.Values.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000FB14 File Offset: 0x0000DD14
		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000FB1B File Offset: 0x0000DD1B
		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000FB22 File Offset: 0x0000DD22
		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000FB29 File Offset: 0x0000DD29
		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000FB30 File Offset: 0x0000DD30
		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return new StringObjectDictionaryAdapter.EnumeratorAdapter(this);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public bool Contains(object key)
		{
			return this.dictionary.Contains(key);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000FB46 File Offset: 0x0000DD46
		public void Add(object key, object value)
		{
			this.dictionary.Add(key, value);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000FB55 File Offset: 0x0000DD55
		public void Clear()
		{
			this.dictionary.Clear();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000FB62 File Offset: 0x0000DD62
		public void Remove(object key)
		{
			this.dictionary.Remove(key);
		}

		// Token: 0x1700009F RID: 159
		public object this[object key]
		{
			get
			{
				return this.dictionary[key];
			}
			set
			{
				this.dictionary[key] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public ICollection Keys
		{
			get
			{
				return this.dictionary.Keys;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000FB9A File Offset: 0x0000DD9A
		public ICollection Values
		{
			get
			{
				return this.dictionary.Values;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000FBA7 File Offset: 0x0000DDA7
		public bool IsReadOnly
		{
			get
			{
				return this.dictionary.IsReadOnly;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		public bool IsFixedSize
		{
			get
			{
				return this.dictionary.IsFixedSize;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000FBC1 File Offset: 0x0000DDC1
		public void CopyTo(Array array, int index)
		{
			this.dictionary.CopyTo(array, index);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		public int Count
		{
			get
			{
				return this.dictionary.Count;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000FBDD File Offset: 0x0000DDDD
		public object SyncRoot
		{
			get
			{
				return this.dictionary.SyncRoot;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		public bool IsSynchronized
		{
			get
			{
				return this.dictionary.IsSynchronized;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000FBF7 File Offset: 0x0000DDF7
		public IEnumerator GetEnumerator()
		{
			return this.dictionary.GetEnumerator();
		}

		// Token: 0x0400013E RID: 318
		private readonly IDictionary dictionary;

		// Token: 0x020001E0 RID: 480
		internal class EnumeratorAdapter : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator
		{
			// Token: 0x06000E2E RID: 3630 RVA: 0x0002206F File Offset: 0x0002026F
			public EnumeratorAdapter(StringObjectDictionaryAdapter adapter)
			{
				this.adapter = adapter;
				this.keyEnumerator = ((IDictionary<string, object>)adapter).Keys.GetEnumerator();
			}

			// Token: 0x06000E2F RID: 3631 RVA: 0x0002208F File Offset: 0x0002028F
			public bool MoveNext()
			{
				if (this.keyEnumerator.MoveNext())
				{
					this.currentKey = this.keyEnumerator.Current;
					this.currentValue = this.adapter[this.currentKey];
					return true;
				}
				return false;
			}

			// Token: 0x06000E30 RID: 3632 RVA: 0x000220C9 File Offset: 0x000202C9
			public void Reset()
			{
				this.keyEnumerator.Reset();
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000220D6 File Offset: 0x000202D6
			public object Current
			{
				get
				{
					return new KeyValuePair<string, object>(this.currentKey, this.currentValue);
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000E32 RID: 3634 RVA: 0x000220EE File Offset: 0x000202EE
			KeyValuePair<string, object> IEnumerator<KeyValuePair<string, object>>.Current
			{
				get
				{
					return new KeyValuePair<string, object>(this.currentKey, this.currentValue);
				}
			}

			// Token: 0x06000E33 RID: 3635 RVA: 0x00022101 File Offset: 0x00020301
			public void Dispose()
			{
				GC.SuppressFinalize(this);
			}

			// Token: 0x04000378 RID: 888
			private readonly StringObjectDictionaryAdapter adapter;

			// Token: 0x04000379 RID: 889
			private IEnumerator<string> keyEnumerator;

			// Token: 0x0400037A RID: 890
			private string currentKey;

			// Token: 0x0400037B RID: 891
			private object currentValue;
		}
	}
}
