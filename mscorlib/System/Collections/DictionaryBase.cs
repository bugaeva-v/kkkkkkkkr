using System;

namespace System.Collections
{
	/// <summary>Предоставляет базовый класс <see langword="abstract" /> для строго типизированной коллекции пар "ключ-значение".</summary>
	// Token: 0x02000A25 RID: 2597
	[Serializable]
	public abstract class DictionaryBase : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Получает список элементов, содержащихся в экземпляре <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Hashtable" />, предоставляющий экземпляр класса <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06005BF7 RID: 23543 RVA: 0x001358B1 File Offset: 0x00133AB1
		protected Hashtable InnerHashtable
		{
			get
			{
				if (this._hashtable == null)
				{
					this._hashtable = new Hashtable();
				}
				return this._hashtable;
			}
		}

		/// <summary>Получает список элементов, содержащихся в экземпляре <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Класс <see cref="T:System.Collections.IDictionary" />, предоставляющий экземпляр класса <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x0000270D File Offset: 0x0000090D
		protected IDictionary Dictionary
		{
			get
			{
				return this;
			}
		}

		/// <summary>Получает число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06005BF9 RID: 23545 RVA: 0x001358CC File Offset: 0x00133ACC
		public int Count
		{
			get
			{
				if (this._hashtable != null)
				{
					return this._hashtable.Count;
				}
				return 0;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Collections.DictionaryBase" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.DictionaryBase" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x001358E3 File Offset: 0x00133AE3
		bool IDictionary.IsReadOnly
		{
			get
			{
				return this.InnerHashtable.IsReadOnly;
			}
		}

		/// <summary>Получает значение, показывающее, имеет ли объект <see cref="T:System.Collections.DictionaryBase" /> фиксированный размер.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Collections.DictionaryBase" /> имеет фиксированный размер, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06005BFB RID: 23547 RVA: 0x001358F0 File Offset: 0x00133AF0
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this.InnerHashtable.IsFixedSize;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, является ли доступ к объекту <see cref="T:System.Collections.DictionaryBase" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к объекту <see cref="T:System.Collections.DictionaryBase" /> является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x001358FD File Offset: 0x00133AFD
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.InnerHashtable.IsSynchronized;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий ключи из объекта <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий ключи из объекта <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x0013590A File Offset: 0x00133B0A
		ICollection IDictionary.Keys
		{
			get
			{
				return this.InnerHashtable.Keys;
			}
		}

		/// <summary>Получает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x00135917 File Offset: 0x00133B17
		object ICollection.SyncRoot
		{
			get
			{
				return this.InnerHashtable.SyncRoot;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий значения из объекта <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий значения из объекта <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06005BFF RID: 23551 RVA: 0x00135924 File Offset: 0x00133B24
		ICollection IDictionary.Values
		{
			get
			{
				return this.InnerHashtable.Values;
			}
		}

		/// <summary>Копирует элементы класса <see cref="T:System.Collections.DictionaryBase" /> в одномерный массив класса <see cref="T:System.Array" /> с указанного индекса.</summary>
		/// <param name="array">Одномерный массив класса <see cref="T:System.Array" />, который является назначением для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из экземпляра класса <see cref="T:System.Collections.DictionaryBase" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.DictionaryBase" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.DictionaryBase" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005C00 RID: 23552 RVA: 0x00135931 File Offset: 0x00133B31
		public void CopyTo(Array array, int index)
		{
			this.InnerHashtable.CopyTo(array, index);
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Задаваемое или получаемое значение ключа.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается значение <see langword="null" />, а при попытке задания ключа создается новый элемент с использованием указанного ключа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и список <see cref="T:System.Collections.DictionaryBase" /> доступен только для чтения.  
		///
		/// или - 
		/// Свойство задано, <paramref name="key" /> не существует в коллекции, а <see cref="T:System.Collections.DictionaryBase" /> имеет фиксированный размер.</exception>
		// Token: 0x17000FF6 RID: 4086
		object IDictionary.this[object key]
		{
			get
			{
				object obj = this.InnerHashtable[key];
				this.OnGet(key, obj);
				return obj;
			}
			set
			{
				this.OnValidate(key, value);
				bool flag = true;
				object obj = this.InnerHashtable[key];
				if (obj == null)
				{
					flag = this.InnerHashtable.Contains(key);
				}
				this.OnSet(key, obj, value);
				this.InnerHashtable[key] = value;
				try
				{
					this.OnSetComplete(key, obj, value);
				}
				catch
				{
					if (flag)
					{
						this.InnerHashtable[key] = obj;
					}
					else
					{
						this.InnerHashtable.Remove(key);
					}
					throw;
				}
			}
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.DictionaryBase" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.DictionaryBase" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.DictionaryBase" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005C03 RID: 23555 RVA: 0x001359EC File Offset: 0x00133BEC
		bool IDictionary.Contains(object key)
		{
			return this.InnerHashtable.Contains(key);
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в словарь <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в <see cref="T:System.Collections.DictionaryBase" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.DictionaryBase" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.DictionaryBase" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C04 RID: 23556 RVA: 0x001359FC File Offset: 0x00133BFC
		void IDictionary.Add(object key, object value)
		{
			this.OnValidate(key, value);
			this.OnInsert(key, value);
			this.InnerHashtable.Add(key, value);
			try
			{
				this.OnInsertComplete(key, value);
			}
			catch
			{
				this.InnerHashtable.Remove(key);
				throw;
			}
		}

		/// <summary>Удаляет содержимое экземпляра <see cref="T:System.Collections.DictionaryBase" />.</summary>
		// Token: 0x06005C05 RID: 23557 RVA: 0x00135A50 File Offset: 0x00133C50
		public void Clear()
		{
			this.OnClear();
			this.InnerHashtable.Clear();
			this.OnClearComplete();
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.DictionaryBase" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.DictionaryBase" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C06 RID: 23558 RVA: 0x00135A6C File Offset: 0x00133C6C
		void IDictionary.Remove(object key)
		{
			if (this.InnerHashtable.Contains(key))
			{
				object value = this.InnerHashtable[key];
				this.OnValidate(key, value);
				this.OnRemove(key, value);
				this.InnerHashtable.Remove(key);
				try
				{
					this.OnRemoveComplete(key, value);
				}
				catch
				{
					this.InnerHashtable.Add(key, value);
					throw;
				}
			}
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" />, осуществляющий перебор элементов экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> для экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x06005C07 RID: 23559 RVA: 0x00135ADC File Offset: 0x00133CDC
		public IDictionaryEnumerator GetEnumerator()
		{
			return this.InnerHashtable.GetEnumerator();
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.DictionaryBase" />.</returns>
		// Token: 0x06005C08 RID: 23560 RVA: 0x00135ADC File Offset: 0x00133CDC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.InnerHashtable.GetEnumerator();
		}

		/// <summary>Получает элемент с указанными ключом и значением из экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется получить.</param>
		/// <param name="currentValue">Текущее значение элемента, связанного с параметром <paramref name="key" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий элемент с указанными ключом и значением.</returns>
		// Token: 0x06005C09 RID: 23561 RVA: 0x0008868F File Offset: 0x0008688F
		protected virtual object OnGet(object key, object currentValue)
		{
			return currentValue;
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед заданием значения в экземпляре класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется найти.</param>
		/// <param name="oldValue">Прежнее значение элемента, связанного с параметром <paramref name="key" />.</param>
		/// <param name="newValue">Новое значение элемента, связанного с параметром <paramref name="key" />.</param>
		// Token: 0x06005C0A RID: 23562 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnSet(object key, object oldValue, object newValue)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед вставкой нового элемента в экземпляр класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется вставить.</param>
		/// <param name="value">Значение элемента, который требуется вставить.</param>
		// Token: 0x06005C0B RID: 23563 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnInsert(object key, object value)
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия перед удалением содержимого экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		// Token: 0x06005C0C RID: 23564 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnClear()
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия перед удалением элемента из экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <param name="value">Значение элемента, который нужно удалить.</param>
		// Token: 0x06005C0D RID: 23565 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnRemove(object key, object value)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские операции при проверке элемента с указанными ключом и значением.</summary>
		/// <param name="key">Ключ элемента, который требуется проверить.</param>
		/// <param name="value">Значение элемента, который требуется проверить.</param>
		// Token: 0x06005C0E RID: 23566 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnValidate(object key, object value)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия после задания значения в экземпляре класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется найти.</param>
		/// <param name="oldValue">Прежнее значение элемента, связанного с параметром <paramref name="key" />.</param>
		/// <param name="newValue">Новое значение элемента, связанного с параметром <paramref name="key" />.</param>
		// Token: 0x06005C0F RID: 23567 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnSetComplete(object key, object oldValue, object newValue)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия после вставки нового элемента в экземпляр класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется вставить.</param>
		/// <param name="value">Значение элемента, который требуется вставить.</param>
		// Token: 0x06005C10 RID: 23568 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnInsertComplete(object key, object value)
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия после удаления содержимого экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		// Token: 0x06005C11 RID: 23569 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnClearComplete()
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия после удаления элемента из экземпляра класса <see cref="T:System.Collections.DictionaryBase" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <param name="value">Значение элемента, который нужно удалить.</param>
		// Token: 0x06005C12 RID: 23570 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnRemoveComplete(object key, object value)
		{
		}

		// Token: 0x04003887 RID: 14471
		private Hashtable _hashtable;
	}
}
