using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000109 RID: 265
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class StringListAttribute : DictionaryBehaviorAttribute, IDictionaryPropertyGetter, IDictionaryBehavior, IDictionaryPropertySetter
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00013890 File Offset: 0x00011A90
		public StringListAttribute()
		{
			this.Separator = ',';
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000138A0 File Offset: 0x00011AA0
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000138A8 File Offset: 0x00011AA8
		public char Separator { get; set; }

		// Token: 0x060006F8 RID: 1784 RVA: 0x000138B4 File Offset: 0x00011AB4
		object IDictionaryPropertyGetter.GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			Type propertyType = property.PropertyType;
			if ((storedValue == null || !storedValue.GetType().IsInstanceOfType(propertyType)) && propertyType.GetTypeInfo().IsGenericType)
			{
				Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
				if (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(List<>) || genericTypeDefinition == typeof(IEnumerable<>))
				{
					Type type = propertyType.GetGenericArguments()[0];
					TypeConverter converter = TypeDescriptor.GetConverter(type);
					if (converter != null && converter.CanConvertFrom(typeof(string)))
					{
						return Activator.CreateInstance(typeof(StringListAttribute.StringListWrapper<>).MakeGenericType(new Type[]
						{
							type
						}), new object[]
						{
							key,
							storedValue,
							this.Separator,
							dictionaryAdapter.This.Dictionary
						});
					}
				}
			}
			return storedValue;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000139AC File Offset: 0x00011BAC
		bool IDictionaryPropertySetter.SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			IEnumerable enumerable = value as IEnumerable;
			if (enumerable != null)
			{
				value = StringListAttribute.BuildString(enumerable, this.Separator);
			}
			return true;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000139D4 File Offset: 0x00011BD4
		internal static string BuildString(IEnumerable enumerable, char separator)
		{
			bool flag = true;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object obj in enumerable)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(separator);
				}
				stringBuilder.Append(obj.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x020001FB RID: 507
		private class StringListWrapper<T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable
		{
			// Token: 0x06000E8F RID: 3727 RVA: 0x000228F6 File Offset: 0x00020AF6
			public StringListWrapper(string key, string list, char separator, IDictionary dictionary)
			{
				this.key = key;
				this.separator = separator;
				this.dictionary = dictionary;
				this.inner = new List<T>();
				this.ParseList(list);
			}

			// Token: 0x06000E90 RID: 3728 RVA: 0x00022926 File Offset: 0x00020B26
			public int IndexOf(T item)
			{
				return this.inner.IndexOf(item);
			}

			// Token: 0x06000E91 RID: 3729 RVA: 0x00022934 File Offset: 0x00020B34
			public void Insert(int index, T item)
			{
				this.inner.Insert(index, item);
				this.SynchronizeDictionary();
			}

			// Token: 0x06000E92 RID: 3730 RVA: 0x00022949 File Offset: 0x00020B49
			public void RemoveAt(int index)
			{
				this.inner.RemoveAt(index);
				this.SynchronizeDictionary();
			}

			// Token: 0x170002B0 RID: 688
			public T this[int index]
			{
				get
				{
					return this.inner[index];
				}
				set
				{
					this.inner[index] = value;
					this.SynchronizeDictionary();
				}
			}

			// Token: 0x06000E95 RID: 3733 RVA: 0x00022980 File Offset: 0x00020B80
			public void Add(T item)
			{
				this.inner.Add(item);
				this.SynchronizeDictionary();
			}

			// Token: 0x06000E96 RID: 3734 RVA: 0x00022994 File Offset: 0x00020B94
			public void Clear()
			{
				this.inner.Clear();
				this.SynchronizeDictionary();
			}

			// Token: 0x06000E97 RID: 3735 RVA: 0x000229A7 File Offset: 0x00020BA7
			public bool Contains(T item)
			{
				return this.inner.Contains(item);
			}

			// Token: 0x06000E98 RID: 3736 RVA: 0x000229B5 File Offset: 0x00020BB5
			public void CopyTo(T[] array, int arrayIndex)
			{
				this.inner.CopyTo(array, arrayIndex);
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000229C4 File Offset: 0x00020BC4
			public int Count
			{
				get
				{
					return this.inner.Count;
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000229D1 File Offset: 0x00020BD1
			public bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000E9B RID: 3739 RVA: 0x000229D4 File Offset: 0x00020BD4
			public bool Remove(T item)
			{
				if (this.inner.Remove(item))
				{
					this.SynchronizeDictionary();
					return true;
				}
				return false;
			}

			// Token: 0x06000E9C RID: 3740 RVA: 0x000229ED File Offset: 0x00020BED
			public IEnumerator<T> GetEnumerator()
			{
				return this.inner.GetEnumerator();
			}

			// Token: 0x06000E9D RID: 3741 RVA: 0x000229FF File Offset: 0x00020BFF
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.inner.GetEnumerator();
			}

			// Token: 0x06000E9E RID: 3742 RVA: 0x00022A14 File Offset: 0x00020C14
			private void ParseList(string list)
			{
				if (list != null)
				{
					TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
					foreach (string value in list.Split(new char[]
					{
						this.separator
					}))
					{
						this.inner.Add((T)((object)converter.ConvertFrom(value)));
					}
				}
			}

			// Token: 0x06000E9F RID: 3743 RVA: 0x00022A73 File Offset: 0x00020C73
			private void SynchronizeDictionary()
			{
				this.dictionary[this.key] = StringListAttribute.BuildString(this.inner, this.separator);
			}

			// Token: 0x040003BD RID: 957
			private readonly string key;

			// Token: 0x040003BE RID: 958
			private readonly char separator;

			// Token: 0x040003BF RID: 959
			private readonly IDictionary dictionary;

			// Token: 0x040003C0 RID: 960
			private readonly List<T> inner;
		}
	}
}
