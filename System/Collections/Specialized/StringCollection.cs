using System;

namespace System.Collections.Specialized
{
	/// <summary>Представляет коллекцию строк.</summary>
	// Token: 0x020004B0 RID: 1200
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс записи, которую требуется получить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Specialized.StringCollection.Count" />.</exception>
		// Token: 0x170007DB RID: 2011
		public string this[int index]
		{
			get
			{
				return (string)this.data[index];
			}
			set
			{
				this.data[index] = value;
			}
		}

		/// <summary>Получает число строк, содержащихся в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>Число строк, содержащихся в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x00087261 File Offset: 0x00085461
		public int Count
		{
			get
			{
				return this.data.Count;
			}
		}

		/// <summary>Получает значение, показывающее, является ли объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, показывающее, имеет ли объект <see cref="T:System.Collections.Specialized.StringCollection" /> фиксированный размер.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Collections.Specialized.StringCollection" /> имеет фиксированный размер, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x00003062 File Offset: 0x00001262
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет строку в конец <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Строка, добавляемая в конец <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Отсчитываемый от нуля индекс, указывающий место вставки нового элемента.</returns>
		// Token: 0x060026BD RID: 9917 RVA: 0x0008726E File Offset: 0x0008546E
		public int Add(string value)
		{
			return this.data.Add(value);
		}

		/// <summary>Копирует элементы массива строк в конец <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Массив строк, добавляемый в конец <see cref="T:System.Collections.Specialized.StringCollection" />. Сам массив не может быть равен <see langword="null" />, но может содержать элементы со значением <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060026BE RID: 9918 RVA: 0x0008727C File Offset: 0x0008547C
		public void AddRange(string[] value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.data.AddRange(value);
		}

		/// <summary>Удаляет все строки из <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		// Token: 0x060026BF RID: 9919 RVA: 0x00087298 File Offset: 0x00085498
		public void Clear()
		{
			this.data.Clear();
		}

		/// <summary>Определяет, входит ли указанная строка в коллекцию <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Строка, которую требуется найти в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> найден в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060026C0 RID: 9920 RVA: 0x000872A5 File Offset: 0x000854A5
		public bool Contains(string value)
		{
			return this.data.Contains(value);
		}

		/// <summary>Копирует значения всей коллекции <see cref="T:System.Collections.Specialized.StringCollection" /> в одномерный массив строк, начиная с указанного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив строк, который является конечным массивом для элементов, копируемых из <see cref="T:System.Collections.Specialized.StringCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Specialized.StringCollection" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Specialized.StringCollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060026C1 RID: 9921 RVA: 0x000872B3 File Offset: 0x000854B3
		public void CopyTo(string[] array, int index)
		{
			this.data.CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.Specialized.StringEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Collections.Specialized.StringEnumerator" /> для <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x060026C2 RID: 9922 RVA: 0x000872C2 File Offset: 0x000854C2
		public StringEnumerator GetEnumerator()
		{
			return new StringEnumerator(this);
		}

		/// <summary>Осуществляет поиск указанной строки и возвращает отсчитываемый от нуля индекс ее первого вхождения в коллекцию <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Строка для поиска. Допускается значение <see langword="null" />.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения <paramref name="value" /> в <see cref="T:System.Collections.Specialized.StringCollection" />, если он найден; в противном случае — значение -1.</returns>
		// Token: 0x060026C3 RID: 9923 RVA: 0x000872CA File Offset: 0x000854CA
		public int IndexOf(string value)
		{
			return this.data.IndexOf(value);
		}

		/// <summary>Вставляет строку в <see cref="T:System.Collections.Specialized.StringCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить <paramref name="value" />.</param>
		/// <param name="value">Строка, которую требуется вставить. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.Specialized.StringCollection.Count" />.</exception>
		// Token: 0x060026C4 RID: 9924 RVA: 0x000872D8 File Offset: 0x000854D8
		public void Insert(int index, string value)
		{
			this.data.Insert(index, value);
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступным только для чтения.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.Specialized.StringCollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Удаляет первое вхождение конкретной строки из <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Строка, которую требуется удалить из <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		// Token: 0x060026C7 RID: 9927 RVA: 0x000872E7 File Offset: 0x000854E7
		public void Remove(string value)
		{
			this.data.Remove(value);
		}

		/// <summary>Удаляет строку по указанному индексу в <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс строки, которую требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Specialized.StringCollection.Count" />.</exception>
		// Token: 0x060026C8 RID: 9928 RVA: 0x000872F5 File Offset: 0x000854F5
		public void RemoveAt(int index)
		{
			this.data.RemoveAt(index);
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00087303 File Offset: 0x00085503
		public object SyncRoot
		{
			get
			{
				return this.data.SyncRoot;
			}
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Specialized.StringCollection.Count" />.</exception>
		// Token: 0x170007E2 RID: 2018
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (string)value;
			}
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в конец коллекции <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Индекс <see cref="T:System.Collections.Specialized.StringCollection" />, по которому добавлен параметр <paramref name="value" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.Specialized.StringCollection" /> имеет фиксированный размер.</exception>
		// Token: 0x060026CC RID: 9932 RVA: 0x00087328 File Offset: 0x00085528
		int IList.Add(object value)
		{
			return this.Add((string)value);
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> найден в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060026CD RID: 9933 RVA: 0x00087336 File Offset: 0x00085536
		bool IList.Contains(object value)
		{
			return this.Contains((string)value);
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="value" />, если оно найдено в коллекции <see cref="T:System.Collections.Specialized.StringCollection" />; в противном случае -1.</returns>
		// Token: 0x060026CE RID: 9934 RVA: 0x00087344 File Offset: 0x00085544
		int IList.IndexOf(object value)
		{
			return this.IndexOf((string)value);
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.Specialized.StringCollection" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Object" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.Specialized.StringCollection.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.Specialized.StringCollection" /> имеет фиксированный размер.</exception>
		// Token: 0x060026CF RID: 9935 RVA: 0x00087352 File Offset: 0x00085552
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (string)value);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.Specialized.StringCollection" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringCollection" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.Specialized.StringCollection" /> имеет фиксированный размер.</exception>
		// Token: 0x060026D0 RID: 9936 RVA: 0x00087361 File Offset: 0x00085561
		void IList.Remove(object value)
		{
			this.Remove((string)value);
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.Specialized.StringCollection" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Specialized.StringCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Specialized.StringCollection" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Specialized.StringCollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060026D1 RID: 9937 RVA: 0x000872B3 File Offset: 0x000854B3
		void ICollection.CopyTo(Array array, int index)
		{
			this.data.CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.StringCollection" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.Specialized.StringCollection" />.</returns>
		// Token: 0x060026D2 RID: 9938 RVA: 0x0008736F File Offset: 0x0008556F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.data.GetEnumerator();
		}

		// Token: 0x04001511 RID: 5393
		private readonly ArrayList data = new ArrayList();
	}
}
