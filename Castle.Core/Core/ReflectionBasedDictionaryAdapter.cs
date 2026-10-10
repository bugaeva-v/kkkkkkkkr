using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Castle.Core
{
	// Token: 0x020000B3 RID: 179
	public sealed class ReflectionBasedDictionaryAdapter : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		public ReflectionBasedDictionaryAdapter(object target)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			ReflectionBasedDictionaryAdapter.Read(this.properties, target);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000F8FA File Offset: 0x0000DAFA
		public int Count
		{
			get
			{
				return this.properties.Count;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000F907 File Offset: 0x0000DB07
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000F90A File Offset: 0x0000DB0A
		public object SyncRoot
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000F912 File Offset: 0x0000DB12
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000098 RID: 152
		public object this[object key]
		{
			get
			{
				object result;
				this.properties.TryGetValue(key.ToString(), out result);
				return result;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000F941 File Offset: 0x0000DB41
		public ICollection Keys
		{
			get
			{
				return this.properties.Keys;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000F94E File Offset: 0x0000DB4E
		public ICollection Values
		{
			get
			{
				return this.properties.Values;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000F95B File Offset: 0x0000DB5B
		bool IDictionary.IsFixedSize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000F962 File Offset: 0x0000DB62
		public void Add(object key, object value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000F969 File Offset: 0x0000DB69
		public void Clear()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000F970 File Offset: 0x0000DB70
		public bool Contains(object key)
		{
			return this.properties.ContainsKey(key.ToString());
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000F983 File Offset: 0x0000DB83
		public void Remove(object key)
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000F985 File Offset: 0x0000DB85
		public IEnumerator GetEnumerator()
		{
			return new ReflectionBasedDictionaryAdapter.DictionaryEntryEnumeratorAdapter(this.properties.GetEnumerator());
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000F99C File Offset: 0x0000DB9C
		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000F9A3 File Offset: 0x0000DBA3
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new ReflectionBasedDictionaryAdapter.DictionaryEntryEnumeratorAdapter(this.properties.GetEnumerator());
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		public static void Read(IDictionary targetDictionary, object valuesAsAnonymousObject)
		{
			foreach (PropertyInfo propertyInfo in ReflectionBasedDictionaryAdapter.GetReadableProperties(valuesAsAnonymousObject.GetType()))
			{
				object propertyValue = ReflectionBasedDictionaryAdapter.GetPropertyValue(valuesAsAnonymousObject, propertyInfo);
				targetDictionary[propertyInfo.Name] = propertyValue;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		private static object GetPropertyValue(object target, PropertyInfo property)
		{
			return property.GetValue(target, null);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000FA26 File Offset: 0x0000DC26
		private static IEnumerable<PropertyInfo> GetReadableProperties(Type targetType)
		{
			return targetType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(new Func<PropertyInfo, bool>(ReflectionBasedDictionaryAdapter.IsReadable));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000FA41 File Offset: 0x0000DC41
		private static bool IsReadable(PropertyInfo property)
		{
			return property.CanRead && property.GetIndexParameters().Length == 0;
		}

		// Token: 0x0400013D RID: 317
		private readonly Dictionary<string, object> properties = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x020001DF RID: 479
		private class DictionaryEntryEnumeratorAdapter : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06000E27 RID: 3623 RVA: 0x00021FE8 File Offset: 0x000201E8
			public DictionaryEntryEnumeratorAdapter(IDictionaryEnumerator enumerator)
			{
				this.enumerator = enumerator;
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00021FF7 File Offset: 0x000201F7
			public DictionaryEntry Entry
			{
				get
				{
					return new DictionaryEntry(this.Key, this.Value);
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0002200A File Offset: 0x0002020A
			public object Key
			{
				get
				{
					return this.current.Key;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00022017 File Offset: 0x00020217
			public object Value
			{
				get
				{
					return this.current.Value;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00022024 File Offset: 0x00020224
			public object Current
			{
				get
				{
					return new DictionaryEntry(this.Key, this.Value);
				}
			}

			// Token: 0x06000E2C RID: 3628 RVA: 0x0002203C File Offset: 0x0002023C
			public bool MoveNext()
			{
				bool flag = this.enumerator.MoveNext();
				if (flag)
				{
					this.current = (KeyValuePair<string, object>)this.enumerator.Current;
				}
				return flag;
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x00022062 File Offset: 0x00020262
			public void Reset()
			{
				this.enumerator.Reset();
			}

			// Token: 0x04000376 RID: 886
			private readonly IDictionaryEnumerator enumerator;

			// Token: 0x04000377 RID: 887
			private KeyValuePair<string, object> current;
		}
	}
}
