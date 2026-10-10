using System;
using System.Collections;
using System.Collections.Generic;

namespace System.ComponentModel
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
	// Token: 0x020003E0 RID: 992
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />.</summary>
		/// <param name="properties">Массив типа <see cref="T:System.ComponentModel.PropertyDescriptor" />, предоставляющий свойства для данной коллекции.</param>
		// Token: 0x0600206A RID: 8298 RVA: 0x00070284 File Offset: 0x0006E484
		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
			if (properties == null)
			{
				this._properties = Array.Empty<PropertyDescriptor>();
				this.Count = 0;
			}
			else
			{
				this._properties = properties;
				this.Count = properties.Length;
			}
			this._propsOwned = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, который может быть экземпляром только для чтения.</summary>
		/// <param name="properties">Массив типа <see cref="T:System.ComponentModel.PropertyDescriptor" />, предоставляющий свойства для данной коллекции.</param>
		/// <param name="readOnly">Значение <see langword="true" /> определяет, что эта коллекция не может быть изменена.</param>
		// Token: 0x0600206B RID: 8299 RVA: 0x000702D0 File Offset: 0x0006E4D0
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) : this(properties)
		{
			this._readOnly = readOnly;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000702E0 File Offset: 0x0006E4E0
		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
		{
			this._propsOwned = false;
			if (namedSort != null)
			{
				this._namedSort = (string[])namedSort.Clone();
			}
			this._comparer = comparer;
			this._properties = properties;
			this.Count = propCount;
			this._needSort = true;
		}

		/// <summary>Возвращает количество дескрипторов свойств в коллекции.</summary>
		/// <returns>Количество дескрипторов свойств в коллекции.</returns>
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00070336 File Offset: 0x0006E536
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x0007033E File Offset: 0x0006E53E
		public int Count { get; private set; }

		/// <summary>Получает или задает дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным индексом.</summary>
		/// <param name="index">Индекс (с нуля) возвращаемого или задаваемого <see cref="T:System.ComponentModel.PropertyDescriptor" />.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным индексом.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="index" /> является недопустимым индексом <see cref="P:System.ComponentModel.PropertyDescriptorCollection.Item(System.Int32)" /> .</exception>
		// Token: 0x170006A4 RID: 1700
		public virtual PropertyDescriptor this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				this.EnsurePropsOwned();
				return this._properties[index];
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным именем.</summary>
		/// <param name="name">Имя дескриптора <see cref="T:System.ComponentModel.PropertyDescriptor" />, который нужно получить из коллекции.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным именем или <see langword="null" />, если свойство не существует.</returns>
		// Token: 0x170006A5 RID: 1701
		public virtual PropertyDescriptor this[string name]
		{
			get
			{
				return this.Find(name, false);
			}
		}

		/// <summary>Добавляет указанный параметр <see cref="T:System.ComponentModel.PropertyDescriptor" /> в коллекцию.</summary>
		/// <param name="value">Параметр <see cref="T:System.ComponentModel.PropertyDescriptor" /> для добавления в коллекцию.</param>
		/// <returns>Индекс объекта <see cref="T:System.ComponentModel.PropertyDescriptor" />, который был добавлен к коллекции.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002071 RID: 8305 RVA: 0x00070370 File Offset: 0x0006E570
		public int Add(PropertyDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			PropertyDescriptor[] properties = this._properties;
			int count = this.Count;
			this.Count = count + 1;
			properties[count] = value;
			return this.Count - 1;
		}

		/// <summary>Удаляет все объекты <see cref="T:System.ComponentModel.PropertyDescriptor" /> из коллекции.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002072 RID: 8306 RVA: 0x000703BA File Offset: 0x0006E5BA
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.Count = 0;
			this._cachedFoundProperties = null;
		}

		/// <summary>Возвращает значение, показывающее, содержит ли коллекция данный дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> .</summary>
		/// <param name="value">Параметр <see cref="T:System.ComponentModel.PropertyDescriptor" /> для поиска в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит данный дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002073 RID: 8307 RVA: 0x000703D8 File Offset: 0x0006E5D8
		public bool Contains(PropertyDescriptor value)
		{
			return this.IndexOf(value) >= 0;
		}

		/// <summary>Копирует всю коллекцию в массив, начиная с заданного индекса.</summary>
		/// <param name="array">Массив объектов <see cref="T:System.ComponentModel.PropertyDescriptor" />, в которые нужно занести элементы коллекции.</param>
		/// <param name="index">Индекс в параметре <paramref name="array" />, с которого начинается копирование.</param>
		// Token: 0x06002074 RID: 8308 RVA: 0x000703E7 File Offset: 0x0006E5E7
		public void CopyTo(Array array, int index)
		{
			this.EnsurePropsOwned();
			Array.Copy(this._properties, 0, array, index, this.Count);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00070404 File Offset: 0x0006E604
		private void EnsurePropsOwned()
		{
			if (!this._propsOwned)
			{
				this._propsOwned = true;
				if (this._properties != null)
				{
					PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
					Array.Copy(this._properties, 0, array, 0, this.Count);
					this._properties = array;
				}
			}
			if (this._needSort)
			{
				this._needSort = false;
				this.InternalSort(this._namedSort);
			}
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0007046C File Offset: 0x0006E66C
		private void EnsureSize(int sizeNeeded)
		{
			if (sizeNeeded <= this._properties.Length)
			{
				return;
			}
			if (this._properties.Length == 0)
			{
				this.Count = 0;
				this._properties = new PropertyDescriptor[sizeNeeded];
				return;
			}
			this.EnsurePropsOwned();
			PropertyDescriptor[] array = new PropertyDescriptor[Math.Max(sizeNeeded, this._properties.Length * 2)];
			Array.Copy(this._properties, 0, array, 0, this.Count);
			this._properties = array;
		}

		/// <summary>Возвращает объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным именем, используя логическое значение, чтобы показать, игнорируется ли регистр знаков.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.ComponentModel.PropertyDescriptor" />, которое нужно возвратить из коллекции.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, если регистр в имени свойства не нужно учитывать, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным именем или <see langword="null" />, если свойство не существует.</returns>
		// Token: 0x06002077 RID: 8311 RVA: 0x000704DC File Offset: 0x0006E6DC
		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			object internalSyncObject = this._internalSyncObject;
			PropertyDescriptor result;
			lock (internalSyncObject)
			{
				PropertyDescriptor propertyDescriptor = null;
				if (this._cachedFoundProperties == null || this._cachedIgnoreCase != ignoreCase)
				{
					this._cachedIgnoreCase = ignoreCase;
					if (ignoreCase)
					{
						this._cachedFoundProperties = new Hashtable(StringComparer.OrdinalIgnoreCase);
					}
					else
					{
						this._cachedFoundProperties = new Hashtable();
					}
				}
				object obj = this._cachedFoundProperties[name];
				if (obj != null)
				{
					result = (PropertyDescriptor)obj;
				}
				else
				{
					for (int i = 0; i < this.Count; i++)
					{
						if (ignoreCase)
						{
							if (string.Equals(this._properties[i].Name, name, StringComparison.OrdinalIgnoreCase))
							{
								this._cachedFoundProperties[name] = this._properties[i];
								propertyDescriptor = this._properties[i];
								break;
							}
						}
						else if (this._properties[i].Name.Equals(name))
						{
							this._cachedFoundProperties[name] = this._properties[i];
							propertyDescriptor = this._properties[i];
							break;
						}
					}
					result = propertyDescriptor;
				}
			}
			return result;
		}

		/// <summary>Возвращает индекс данного дескриптора <see cref="T:System.ComponentModel.PropertyDescriptor" /> .</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, для которого возвращается индекс.</param>
		/// <returns>Индекс заданного объекта <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x06002078 RID: 8312 RVA: 0x000705FC File Offset: 0x0006E7FC
		public int IndexOf(PropertyDescriptor value)
		{
			return Array.IndexOf<PropertyDescriptor>(this._properties, value, 0, this.Count);
		}

		/// <summary>Добавляет в коллекцию дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> в позицию с заданным индексом.</summary>
		/// <param name="index">Индекс в коллекции, в позицию которого нужно добавить параметр <paramref name="value" /> .</param>
		/// <param name="value">Параметр <see cref="T:System.ComponentModel.PropertyDescriptor" /> для добавления в коллекцию.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002079 RID: 8313 RVA: 0x00070614 File Offset: 0x0006E814
		public void Insert(int index, PropertyDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			this.EnsureSize(this.Count + 1);
			if (index < this.Count)
			{
				Array.Copy(this._properties, index, this._properties, index + 1, this.Count - index);
			}
			this._properties[index] = value;
			int count = this.Count;
			this.Count = count + 1;
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> из коллекции.</summary>
		/// <param name="value">Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, который требуется удалить из коллекции.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x0600207A RID: 8314 RVA: 0x0007067C File Offset: 0x0006E87C
		public void Remove(PropertyDescriptor value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			int num = this.IndexOf(value);
			if (num != -1)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Удаляет из коллекции дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> с заданным индексом.</summary>
		/// <param name="index">Индекс дескриптора <see cref="T:System.ComponentModel.PropertyDescriptor" />, который нужно удалить из коллекции.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x0600207B RID: 8315 RVA: 0x000706AC File Offset: 0x0006E8AC
		public void RemoveAt(int index)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException();
			}
			if (index < this.Count - 1)
			{
				Array.Copy(this._properties, index + 1, this._properties, index, this.Count - index - 1);
			}
			this._properties[this.Count - 1] = null;
			int count = this.Count;
			this.Count = count - 1;
		}

		/// <summary>Сортирует члены данной коллекции, используя порядок сортировки, установленный по умолчанию для этой коллекции, являющийся обычно порядком сортировки по алфавиту.</summary>
		/// <returns>Новая коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая отсортированные объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x0600207C RID: 8316 RVA: 0x00070711 File Offset: 0x0006E911
		public virtual PropertyDescriptorCollection Sort()
		{
			return new PropertyDescriptorCollection(this._properties, this.Count, this._namedSort, this._comparer);
		}

		/// <summary>Сортирует членов коллекции. Сначала выполняется сортировка в указанном порядке, затем используется порядок сортировки по умолчанию, обычно являющийся алфавитным,.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки для объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в этой коллекции.</param>
		/// <returns>Новая коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая отсортированные объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x0600207D RID: 8317 RVA: 0x00070730 File Offset: 0x0006E930
		public virtual PropertyDescriptorCollection Sort(string[] names)
		{
			return new PropertyDescriptorCollection(this._properties, this.Count, names, this._comparer);
		}

		/// <summary>Сортирует членов коллекции. Вслед за выполнением сортировки в указанном порядке производится сортировка с использованием средства <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки для объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в этой коллекции.</param>
		/// <param name="comparer">Средство сравнения, которое нужно использовать для сортировки объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в данной коллекции.</param>
		/// <returns>Новая коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая отсортированные объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x0600207E RID: 8318 RVA: 0x0007074A File Offset: 0x0006E94A
		public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return new PropertyDescriptorCollection(this._properties, this.Count, names, comparer);
		}

		/// <summary>Сортирует члены данной коллекции, используя заданный интерфейс <see cref="T:System.Collections.IComparer" /> .</summary>
		/// <param name="comparer">Средство сравнения, которое нужно использовать для сортировки объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в данной коллекции.</param>
		/// <returns>Новая коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая отсортированные объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x0600207F RID: 8319 RVA: 0x0007075F File Offset: 0x0006E95F
		public virtual PropertyDescriptorCollection Sort(IComparer comparer)
		{
			return new PropertyDescriptorCollection(this._properties, this.Count, this._namedSort, comparer);
		}

		/// <summary>Сортирует членов коллекции. Сначала выполняется сортировка в указанном порядке, затем используется порядок сортировки по умолчанию, обычно являющийся алфавитным,.</summary>
		/// <param name="names">Массив строк, описывающий порядок сортировки для объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в этой коллекции.</param>
		// Token: 0x06002080 RID: 8320 RVA: 0x0007077C File Offset: 0x0006E97C
		protected void InternalSort(string[] names)
		{
			if (this._properties.Length == 0)
			{
				return;
			}
			this.InternalSort(this._comparer);
			if (names != null && names.Length != 0)
			{
				List<PropertyDescriptor> list = new List<PropertyDescriptor>(this._properties);
				int num = 0;
				int num2 = this._properties.Length;
				for (int i = 0; i < names.Length; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						PropertyDescriptor propertyDescriptor = list[j];
						if (propertyDescriptor != null && propertyDescriptor.Name.Equals(names[i]))
						{
							this._properties[num++] = propertyDescriptor;
							list[j] = null;
							break;
						}
					}
				}
				for (int k = 0; k < num2; k++)
				{
					if (list[k] != null)
					{
						this._properties[num++] = list[k];
					}
				}
			}
		}

		/// <summary>Сортирует члены данной коллекции, используя заданный интерфейс <see cref="T:System.Collections.IComparer" /> .</summary>
		/// <param name="sorter">Средство сравнения, которое нужно использовать для сортировки объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в данной коллекции.</param>
		// Token: 0x06002081 RID: 8321 RVA: 0x00070847 File Offset: 0x0006EA47
		protected void InternalSort(IComparer sorter)
		{
			if (sorter == null)
			{
				TypeDescriptor.SortDescriptorArray(this);
				return;
			}
			Array.Sort(this._properties, sorter);
		}

		/// <summary>Возвращает перечислитель для этого класса.</summary>
		/// <returns>Перечислитель типа <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06002082 RID: 8322 RVA: 0x00070860 File Offset: 0x0006EA60
		public virtual IEnumerator GetEnumerator()
		{
			this.EnsurePropsOwned();
			if (this._properties.Length != this.Count)
			{
				PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
				Array.Copy(this._properties, 0, array, 0, this.Count);
				return array.GetEnumerator();
			}
			return this._properties.GetEnumerator();
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000708B5 File Offset: 0x0006EAB5
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Удаляет все элементы из коллекции.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002086 RID: 8326 RVA: 0x000708BD File Offset: 0x0006EABD
		void IList.Clear()
		{
			this.Clear();
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.IDictionary" /> все элементы.</summary>
		// Token: 0x06002087 RID: 8327 RVA: 0x000708BD File Offset: 0x0006EABD
		void IDictionary.Clear()
		{
			this.Clear();
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" /> для словаря <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06002088 RID: 8328 RVA: 0x000708C5 File Offset: 0x0006EAC5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Удаляет элемент с указанным индексом.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002089 RID: 8329 RVA: 0x000708CD File Offset: 0x0006EACD
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Объект <see cref="T:System.Object" /> используется в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> используется в качестве значения добавляемого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600208A RID: 8330 RVA: 0x000708D8 File Offset: 0x0006EAD8
		void IDictionary.Add(object key, object value)
		{
			PropertyDescriptor propertyDescriptor = value as PropertyDescriptor;
			if (propertyDescriptor == null)
			{
				throw new ArgumentException("value");
			}
			this.Add(propertyDescriptor);
		}

		/// <summary>Определяет, содержится ли элемент с указанным ключом в <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Collections.IDictionary" /> содержится элемент с данным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600208B RID: 8331 RVA: 0x00070902 File Offset: 0x0006EB02
		bool IDictionary.Contains(object key)
		{
			return key is string && this[(string)key] != null;
		}

		/// <summary>Возвращает перечислитель для этого класса.</summary>
		/// <returns>Перечислитель типа <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x0600208C RID: 8332 RVA: 0x0007091D File Offset: 0x0006EB1D
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new PropertyDescriptorCollection.PropertyDescriptorEnumerator(this);
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IDictionary" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x00070925 File Offset: 0x0006EB25
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IDictionary" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IDictionary" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x00070925 File Offset: 0x0006EB25
		bool IDictionary.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить или задать.</param>
		/// <returns>Элемент с указанным ключом.</returns>
		// Token: 0x170006AB RID: 1707
		object IDictionary.this[object key]
		{
			get
			{
				if (key is string)
				{
					return this[(string)key];
				}
				return null;
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException();
				}
				if (value != null && !(value is PropertyDescriptor))
				{
					throw new ArgumentException("value");
				}
				int num = -1;
				if (key is int)
				{
					num = (int)key;
					if (num < 0 || num >= this.Count)
					{
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					if (!(key is string))
					{
						throw new ArgumentException("key");
					}
					for (int i = 0; i < this.Count; i++)
					{
						if (this._properties[i].Name.Equals((string)key))
						{
							num = i;
							break;
						}
					}
				}
				if (num == -1)
				{
					this.Add((PropertyDescriptor)value);
					return;
				}
				this.EnsurePropsOwned();
				this._properties[num] = (PropertyDescriptor)value;
				if (this._cachedFoundProperties != null && key is string)
				{
					this._cachedFoundProperties[key] = value;
				}
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи из <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x00070A24 File Offset: 0x0006EC24
		ICollection IDictionary.Keys
		{
			get
			{
				string[] array = new string[this.Count];
				for (int i = 0; i < this.Count; i++)
				{
					array[i] = this._properties[i].Name;
				}
				return array;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x00070A60 File Offset: 0x0006EC60
		ICollection IDictionary.Values
		{
			get
			{
				if (this._properties.Length != this.Count)
				{
					PropertyDescriptor[] array = new PropertyDescriptor[this.Count];
					Array.Copy(this._properties, 0, array, 0, this.Count);
					return array;
				}
				return (ICollection)this._properties.Clone();
			}
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06002093 RID: 8339 RVA: 0x00070AB0 File Offset: 0x0006ECB0
		void IDictionary.Remove(object key)
		{
			if (key is string)
			{
				PropertyDescriptor propertyDescriptor = this[(string)key];
				if (propertyDescriptor != null)
				{
					((IList)this).Remove(propertyDescriptor);
				}
			}
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Элемент для добавления в коллекцию.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		// Token: 0x06002094 RID: 8340 RVA: 0x00070ADC File Offset: 0x0006ECDC
		int IList.Add(object value)
		{
			return this.Add((PropertyDescriptor)value);
		}

		/// <summary>Определяет, содержит ли коллекция указанное значение.</summary>
		/// <param name="value">Элемент, помещаемый в эту коллекцию.</param>
		/// <returns>Значение <see langword="true" />, если элемент найден в коллекции; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002095 RID: 8341 RVA: 0x00070AEA File Offset: 0x0006ECEA
		bool IList.Contains(object value)
		{
			return this.Contains((PropertyDescriptor)value);
		}

		/// <summary>Определяет индекс указанного элемента коллекции.</summary>
		/// <param name="value">Элемент, помещаемый в эту коллекцию.</param>
		/// <returns>Индекс параметра <paramref name="value" />, если он найден в списке; в противном случае -1.</returns>
		// Token: 0x06002096 RID: 8342 RVA: 0x00070AF8 File Offset: 0x0006ECF8
		int IList.IndexOf(object value)
		{
			return this.IndexOf((PropertyDescriptor)value);
		}

		/// <summary>Вставляет элемент в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Элемент, вставляемый в коллекцию.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002097 RID: 8343 RVA: 0x00070B06 File Offset: 0x0006ED06
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (PropertyDescriptor)value);
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция доступна только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00070925 File Offset: 0x0006EB25
		bool IList.IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Возвращает значение, указывающее, имеет ли коллекция фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00070925 File Offset: 0x0006EB25
		bool IList.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Удаляет первое вхождение указанного значения из коллекции.</summary>
		/// <param name="value">Элемент, который нужно удалить из коллекции.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x0600209A RID: 8346 RVA: 0x00070B15 File Offset: 0x0006ED15
		void IList.Remove(object value)
		{
			this.Remove((PropertyDescriptor)value);
		}

		/// <summary>Возвращает или задает элемент, расположенный в коллекции по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс получаемого или задаваемого элемента.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.ComponentModel.PropertyDescriptor" />.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
		// Token: 0x170006B0 RID: 1712
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException();
				}
				if (index >= this.Count)
				{
					throw new IndexOutOfRangeException();
				}
				if (value != null && !(value is PropertyDescriptor))
				{
					throw new ArgumentException("value");
				}
				this.EnsurePropsOwned();
				this._properties[index] = (PropertyDescriptor)value;
			}
		}

		/// <summary>Задает пустую коллекцию, которую можно использовать вместо создания ново коллекции без элементов. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FC4 RID: 4036
		public static readonly PropertyDescriptorCollection Empty = new PropertyDescriptorCollection(null, true);

		// Token: 0x04000FC5 RID: 4037
		private IDictionary _cachedFoundProperties;

		// Token: 0x04000FC6 RID: 4038
		private bool _cachedIgnoreCase;

		// Token: 0x04000FC7 RID: 4039
		private PropertyDescriptor[] _properties;

		// Token: 0x04000FC8 RID: 4040
		private readonly string[] _namedSort;

		// Token: 0x04000FC9 RID: 4041
		private readonly IComparer _comparer;

		// Token: 0x04000FCA RID: 4042
		private bool _propsOwned;

		// Token: 0x04000FCB RID: 4043
		private bool _needSort;

		// Token: 0x04000FCC RID: 4044
		private bool _readOnly;

		// Token: 0x04000FCD RID: 4045
		private readonly object _internalSyncObject = new object();

		// Token: 0x020003E1 RID: 993
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600209E RID: 8350 RVA: 0x00070B8E File Offset: 0x0006ED8E
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
			{
				this._owner = owner;
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x00070BA4 File Offset: 0x0006EDA4
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00070BB4 File Offset: 0x0006EDB4
			public DictionaryEntry Entry
			{
				get
				{
					PropertyDescriptor propertyDescriptor = this._owner[this._index];
					return new DictionaryEntry(propertyDescriptor.Name, propertyDescriptor);
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00070BDF File Offset: 0x0006EDDF
			public object Key
			{
				get
				{
					return this._owner[this._index].Name;
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00070BDF File Offset: 0x0006EDDF
			public object Value
			{
				get
				{
					return this._owner[this._index].Name;
				}
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x00070BF7 File Offset: 0x0006EDF7
			public bool MoveNext()
			{
				if (this._index < this._owner.Count - 1)
				{
					this._index++;
					return true;
				}
				return false;
			}

			// Token: 0x060020A4 RID: 8356 RVA: 0x00070C1F File Offset: 0x0006EE1F
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x04000FCF RID: 4047
			private PropertyDescriptorCollection _owner;

			// Token: 0x04000FD0 RID: 4048
			private int _index = -1;
		}
	}
}
