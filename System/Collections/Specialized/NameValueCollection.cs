using System;
using System.Runtime.Serialization;
using System.Text;

namespace System.Collections.Specialized
{
	/// <summary>Представляет коллекцию связанных ключей <see cref="T:System.String" /> и значений <see cref="T:System.String" />, доступ к которым можно получить с помощью ключа или индекса.</summary>
	// Token: 0x020004AC RID: 1196
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который является пустым, обладает исходной емкостью по умолчанию, использует поставщика хэш-кода по умолчанию и функцию сравнения по умолчанию. Функция сравнения и поставщик хэш-кода работают без учета регистра.</summary>
		// Token: 0x0600266C RID: 9836 RVA: 0x00086659 File Offset: 0x00084859
		public NameValueCollection()
		{
		}

		/// <summary>Копирует записи из указанной коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" /> в новую коллекцию <see cref="T:System.Collections.Specialized.NameValueCollection" /> с начальной емкостью, равной количеству копируемых записей. При этом используется такой же поставщик хэш-кода и такая же функция сравнения, которые использовались в исходной коллекции.</summary>
		/// <param name="col">Коллекция <see cref="T:System.Collections.Specialized.NameValueCollection" />, копируемая в новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="col" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600266D RID: 9837 RVA: 0x00086661 File Offset: 0x00084861
		public NameValueCollection(NameValueCollection col) : base((col != null) ? col.Comparer : null)
		{
			this.Add(col);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который является пустым, обладает начальной емкостью по умолчанию и использует указанного поставщика хэш-кода и указанную функцию сравнения.</summary>
		/// <param name="hashProvider">Объект <see cref="T:System.Collections.IHashCodeProvider" />, который предоставит хэш-коды для всех ключей в <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.</param>
		// Token: 0x0600266E RID: 9838 RVA: 0x0008667C File Offset: 0x0008487C
		[Obsolete("Please use NameValueCollection(IEqualityComparer) instead.")]
		public NameValueCollection(IHashCodeProvider hashProvider, IComparer comparer) : base(hashProvider, comparer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который является пустым, обладает указанной исходной емкостью, использует поставщика хэш-кода по умолчанию и функцию сравнения по умолчанию. Функция сравнения и поставщик хэш-кода работают без учета регистра.</summary>
		/// <param name="capacity">Начальное количество записей, которое может содержать <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x0600266F RID: 9839 RVA: 0x00086686 File Offset: 0x00084886
		public NameValueCollection(int capacity) : base(capacity)
		{
		}

		/// <summary>Инициализирует новый экземпляр пустого класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который обладает начальной емкостью по умолчанию и использует указанный объект <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="equalityComparer">Объект <see cref="T:System.Collections.IEqualityComparer" />, который используется для определения равенства двух ключей и создания хэш-кодов для ключей в коллекции.</param>
		// Token: 0x06002670 RID: 9840 RVA: 0x0008668F File Offset: 0x0008488F
		public NameValueCollection(IEqualityComparer equalityComparer) : base(equalityComparer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который является пустым, обладает указанной исходной емкостью и использует заданный объект <see cref="T:System.Collections.IEqualityComparer" />.</summary>
		/// <param name="capacity">Начальное количество записей, которое может содержать объект <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="equalityComparer">Объект <see cref="T:System.Collections.IEqualityComparer" />, который используется для определения равенства двух ключей и создания хэш-кодов для ключей в коллекции.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06002671 RID: 9841 RVA: 0x00086698 File Offset: 0x00084898
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer) : base(capacity, equalityComparer)
		{
		}

		/// <summary>Копирует записи из указанной коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" /> в новую коллекцию <see cref="T:System.Collections.Specialized.NameValueCollection" /> с указанной начальной емкостью или начальной емкостью, равной количеству копируемых записей, — в зависимости от того, какое значение больше. При этом используются поставщик хэш-кода по умолчанию и функция сравнения по умолчанию, работающие без учета регистра.</summary>
		/// <param name="capacity">Начальное количество записей, которое может содержать <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="col">Коллекция <see cref="T:System.Collections.Specialized.NameValueCollection" />, копируемая в новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="col" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002672 RID: 9842 RVA: 0x000866A2 File Offset: 0x000848A2
		public NameValueCollection(int capacity, NameValueCollection col) : base(capacity, (col != null) ? col.Comparer : null)
		{
			if (col == null)
			{
				throw new ArgumentNullException("col");
			}
			base.Comparer = col.Comparer;
			this.Add(col);
		}

		/// <summary>Инициализирует новый экземпляр пустого класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который обладает указанной исходной емкостью и использует заданного поставщика хэш-кода и функцию сравнения.</summary>
		/// <param name="capacity">Начальное количество записей, которое может содержать <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="hashProvider">Объект <see cref="T:System.Collections.IHashCodeProvider" />, который предоставит хэш-коды для всех ключей в <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06002673 RID: 9843 RVA: 0x000866D8 File Offset: 0x000848D8
		[Obsolete("Please use NameValueCollection(Int32, IEqualityComparer) instead.")]
		public NameValueCollection(int capacity, IHashCodeProvider hashProvider, IComparer comparer) : base(capacity, hashProvider, comparer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.NameValueCollection" />, который поддерживает сериализацию и использует указанные объекты <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		// Token: 0x06002674 RID: 9844 RVA: 0x000866E3 File Offset: 0x000848E3
		protected NameValueCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Сбрасывает кэшированные массивы в коллекции до значения <see langword="null" />.</summary>
		// Token: 0x06002675 RID: 9845 RVA: 0x000866ED File Offset: 0x000848ED
		protected void InvalidateCachedArrays()
		{
			this._all = null;
			this._allKeys = null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00086700 File Offset: 0x00084900
		private static string GetAsOneString(ArrayList list)
		{
			int num = (list != null) ? list.Count : 0;
			if (num == 1)
			{
				return (string)list[0];
			}
			if (num > 1)
			{
				StringBuilder stringBuilder = new StringBuilder((string)list[0]);
				for (int i = 1; i < num; i++)
				{
					stringBuilder.Append(',');
					stringBuilder.Append((string)list[i]);
				}
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00086774 File Offset: 0x00084974
		private static string[] GetAsStringArray(ArrayList list)
		{
			int num = (list != null) ? list.Count : 0;
			if (num == 0)
			{
				return null;
			}
			string[] array = new string[num];
			list.CopyTo(0, array, 0, num);
			return array;
		}

		/// <summary>Копирует записи из указанной коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" /> в текущую коллекцию <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="c">Коллекция <see cref="T:System.Collections.Specialized.NameValueCollection" />, копируемая в текущую коллекцию <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="c" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002678 RID: 9848 RVA: 0x000867A8 File Offset: 0x000849A8
		public void Add(NameValueCollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			this.InvalidateCachedArrays();
			int count = c.Count;
			for (int i = 0; i < count; i++)
			{
				string key = c.GetKey(i);
				string[] values = c.GetValues(i);
				if (values != null)
				{
					for (int j = 0; j < values.Length; j++)
					{
						this.Add(key, values[j]);
					}
				}
				else
				{
					this.Add(key, null);
				}
			}
		}

		/// <summary>Делает недопустимыми кэшированные массивы и удаляет все записи из коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002679 RID: 9849 RVA: 0x00086816 File Offset: 0x00084A16
		public virtual void Clear()
		{
			if (base.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only.");
			}
			this.InvalidateCachedArrays();
			base.BaseClear();
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.Specialized.NameValueCollection" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="dest">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Specialized.NameValueCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="dest" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dest" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="dest" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Specialized.NameValueCollection" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="dest" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Specialized.NameValueCollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="dest" />.</exception>
		// Token: 0x0600267A RID: 9850 RVA: 0x00086838 File Offset: 0x00084A38
		public void CopyTo(Array dest, int index)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			if (dest.Rank != 1)
			{
				throw new ArgumentException("Multi dimension array is not supported on this operation.", "dest");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (dest.Length - index < this.Count)
			{
				throw new ArgumentException("Insufficient space in the target location to copy the information.");
			}
			int count = this.Count;
			if (this._all == null)
			{
				string[] array = new string[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = this.Get(i);
					dest.SetValue(array[i], i + index);
				}
				this._all = array;
				return;
			}
			for (int j = 0; j < count; j++)
			{
				dest.SetValue(this._all[j], j + index);
			}
		}

		/// <summary>Получает значение, показывающее, содержит ли коллекция <see cref="T:System.Collections.Specialized.NameValueCollection" /> ключи, отличные от <see langword="null" />.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Collections.Specialized.NameValueCollection" /> содержит ключи, которые отличны от <see langword="null" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600267B RID: 9851 RVA: 0x000868FE File Offset: 0x00084AFE
		public bool HasKeys()
		{
			return this.InternalHasKeys();
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00086906 File Offset: 0x00084B06
		internal virtual bool InternalHasKeys()
		{
			return base.BaseHasKeys();
		}

		/// <summary>Добавляет запись с указанным ключом и значением в коллекцию <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">Добавляемый ключ записи <see cref="T:System.String" />. Значением ключа может быть <see langword="null" />.</param>
		/// <param name="value">Добавляемое значение записи <see cref="T:System.String" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x0600267D RID: 9853 RVA: 0x00086910 File Offset: 0x00084B10
		public virtual void Add(string name, string value)
		{
			if (base.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only.");
			}
			this.InvalidateCachedArrays();
			ArrayList arrayList = (ArrayList)base.BaseGet(name);
			if (arrayList == null)
			{
				arrayList = new ArrayList(1);
				if (value != null)
				{
					arrayList.Add(value);
				}
				base.BaseAdd(name, arrayList);
				return;
			}
			if (value != null)
			{
				arrayList.Add(value);
			}
		}

		/// <summary>Получает значения, связанные с указанным ключом, из коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, объединенные в один список, в котором используются разделители-запятые.</summary>
		/// <param name="name">Ключ <see cref="T:System.String" /> для записи, содержащей значения, которые требуется получить. Значением ключа может быть <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.String" />, который содержит список значений с разделителями-запятыми, связанных с указанным ключом в классе <see cref="T:System.Collections.Specialized.NameValueCollection" />, если найден; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x0600267E RID: 9854 RVA: 0x0008696C File Offset: 0x00084B6C
		public virtual string Get(string name)
		{
			return NameValueCollection.GetAsOneString((ArrayList)base.BaseGet(name));
		}

		/// <summary>Получает значения, связанные с указанным ключом, из коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">Ключ <see cref="T:System.String" /> для записи, содержащей значения, которые требуется получить. Значением ключа может быть <see langword="null" />.</param>
		/// <returns>Массив <see cref="T:System.String" />, который содержит значения, связанные с указанным ключом, в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, если найден; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x0600267F RID: 9855 RVA: 0x0008697F File Offset: 0x00084B7F
		public virtual string[] GetValues(string name)
		{
			return NameValueCollection.GetAsStringArray((ArrayList)base.BaseGet(name));
		}

		/// <summary>Задает значение записи в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">Ключ <see cref="T:System.String" /> для записи, в которую требуется добавить новое значение. Значением ключа может быть <see langword="null" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, представляющий новое значение, которое требуется добавить в указанную запись. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002680 RID: 9856 RVA: 0x00086994 File Offset: 0x00084B94
		public virtual void Set(string name, string value)
		{
			if (base.IsReadOnly)
			{
				throw new NotSupportedException("Collection is read-only.");
			}
			this.InvalidateCachedArrays();
			base.BaseSet(name, new ArrayList(1)
			{
				value
			});
		}

		/// <summary>Удаляет записи с указанным ключом из экземпляра класса <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />.</summary>
		/// <param name="name">Удаляемый ключ записи <see cref="T:System.String" />. Значением ключа может быть <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06002681 RID: 9857 RVA: 0x000869D1 File Offset: 0x00084BD1
		public virtual void Remove(string name)
		{
			this.InvalidateCachedArrays();
			base.BaseRemove(name);
		}

		/// <summary>Получает или задает запись с указанным ключом в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="name">Ключ <see cref="T:System.String" /> для записи, которую требуется найти. Значением ключа может быть <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.String" />, который содержит список значений с разделителями-запятыми, связанных с указанным ключом, если он найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Коллекция доступна только для чтения, а в операции предпринимается попытка изменить коллекцию.</exception>
		// Token: 0x170007C6 RID: 1990
		public string this[string name]
		{
			get
			{
				return this.Get(name);
			}
			set
			{
				this.Set(name, value);
			}
		}

		/// <summary>Получает значения по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, объединенные в один список с разделителями-запятыми.</summary>
		/// <param name="index">Индекс (с нуля) записи, содержащей значения, которые требуется получить из коллекции.</param>
		/// <returns>Объект <see cref="T:System.String" />, который содержит список значений с разделителями-запятыми, по указанному адресу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, если найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x06002684 RID: 9860 RVA: 0x000869F3 File Offset: 0x00084BF3
		public virtual string Get(int index)
		{
			return NameValueCollection.GetAsOneString((ArrayList)base.BaseGet(index));
		}

		/// <summary>Получает значения по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="index">Индекс (с нуля) записи, содержащей значения, которые требуется получить из коллекции.</param>
		/// <returns>Массив <see cref="T:System.String" />, который содержит значения по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, если найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x06002685 RID: 9861 RVA: 0x00086A06 File Offset: 0x00084C06
		public virtual string[] GetValues(int index)
		{
			return NameValueCollection.GetAsStringArray((ArrayList)base.BaseGet(index));
		}

		/// <summary>Получает ключ по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс ключа, который требуется получить из коллекции.</param>
		/// <returns>Объект <see cref="T:System.String" />, который содержит ключ по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />, если найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x06002686 RID: 9862 RVA: 0x00086A19 File Offset: 0x00084C19
		public virtual string GetKey(int index)
		{
			return base.BaseGetKey(index);
		}

		/// <summary>Получает запись по указанному индексу в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <param name="index">Индекс (с нуля) записи, расположение которой требуется определить в коллекции.</param>
		/// <returns>Объект <see cref="T:System.String" />, который содержит список значений с разделителями-запятыми по указанному индексу в коллекции.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне допустимого диапазона индексов для коллекции.</exception>
		// Token: 0x170007C7 RID: 1991
		public string this[int index]
		{
			get
			{
				return this.Get(index);
			}
		}

		/// <summary>Получает все ключи в коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
		/// <returns>Массив <see cref="T:System.String" />, который содержит все ключи коллекции <see cref="T:System.Collections.Specialized.NameValueCollection" />.</returns>
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x00086A2B File Offset: 0x00084C2B
		public virtual string[] AllKeys
		{
			get
			{
				if (this._allKeys == null)
				{
					this._allKeys = base.BaseGetAllKeys();
				}
				return this._allKeys;
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00086A47 File Offset: 0x00084C47
		internal NameValueCollection(DBNull dummy) : base(dummy)
		{
		}

		// Token: 0x040014FD RID: 5373
		private string[] _all;

		// Token: 0x040014FE RID: 5374
		private string[] _allKeys;
	}
}
