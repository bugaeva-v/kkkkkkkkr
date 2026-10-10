using System;
using System.Collections.Generic;

namespace System.Collections.Specialized
{
	/// <summary>Реализует хэш-таблицу с ключом и значением, строго типизированными как строки, а не объекты.</summary>
	// Token: 0x020004B2 RID: 1202
	[Serializable]
	public class StringDictionary : IEnumerable
	{
		/// <summary>Получает число пар ключ/значение, содержащихся в <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <returns>Число пар ключ/значение, содержащихся в <see cref="T:System.Collections.Specialized.StringDictionary" />.  
		/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x000873EE File Offset: 0x000855EE
		public virtual int Count
		{
			get
			{
				return this.contents.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.Specialized.StringDictionary" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.Specialized.StringDictionary" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000873FB File Offset: 0x000855FB
		public virtual bool IsSynchronized
		{
			get
			{
				return this.contents.IsSynchronized;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Задаваемое или получаемое значение ключа.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, оператор Get возвращает значение <see langword="null" />, а оператор Set создает новую запись с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x170007E6 RID: 2022
		public virtual string this[string key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				return (string)this.contents[key.ToLowerInvariant()];
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				this.contents[key.ToLowerInvariant()] = value;
			}
		}

		/// <summary>Получает коллекцию ключей в <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.ICollection" />, предоставляющий ключи в <see cref="T:System.Collections.Specialized.StringDictionary" />.</returns>
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x00087450 File Offset: 0x00085650
		public virtual ICollection Keys
		{
			get
			{
				return this.contents.Keys;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который может использоваться для синхронизации доступа к коллекции <see cref="T:System.Collections.Specialized.StringDictionary" />.</returns>
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0008745D File Offset: 0x0008565D
		public virtual object SyncRoot
		{
			get
			{
				return this.contents.SyncRoot;
			}
		}

		/// <summary>Получает коллекцию значений в <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.ICollection" />, представляющий значения в <see cref="T:System.Collections.Specialized.StringDictionary" />.</returns>
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x0008746A File Offset: 0x0008566A
		public virtual ICollection Values
		{
			get
			{
				return this.contents.Values;
			}
		}

		/// <summary>Добавляет запись с указанными ключом и значением в <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется добавить.</param>
		/// <param name="value">Добавляемое значение записи. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Запись с таким ключом уже существует в <see cref="T:System.Collections.Specialized.StringDictionary" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringDictionary" /> доступен только для чтения.</exception>
		// Token: 0x060026E1 RID: 9953 RVA: 0x00087477 File Offset: 0x00085677
		public virtual void Add(string key, string value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.contents.Add(key.ToLowerInvariant(), value);
		}

		/// <summary>Удаляет все записи из <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringDictionary" /> доступен только для чтения.</exception>
		// Token: 0x060026E2 RID: 9954 RVA: 0x00087499 File Offset: 0x00085699
		public virtual void Clear()
		{
			this.contents.Clear();
		}

		/// <summary>Определяет, содержит ли <see cref="T:System.Collections.Specialized.StringDictionary" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Specialized.StringDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Specialized.StringDictionary" /> содержит запись с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Ключ имеет значение <see langword="null" />.</exception>
		// Token: 0x060026E3 RID: 9955 RVA: 0x000874A6 File Offset: 0x000856A6
		public virtual bool ContainsKey(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.contents.ContainsKey(key.ToLowerInvariant());
		}

		/// <summary>Определяет, содержит ли <see cref="T:System.Collections.Specialized.StringDictionary" /> указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Specialized.StringDictionary" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Specialized.StringDictionary" /> содержит элемент с указанным значением; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060026E4 RID: 9956 RVA: 0x000874C7 File Offset: 0x000856C7
		public virtual bool ContainsValue(string value)
		{
			return this.contents.ContainsValue(value);
		}

		/// <summary>Копирует значения из словаря строк в одномерный экземпляр класса <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является назначением для значений, копируемых из <see cref="T:System.Collections.Specialized.StringDictionary" />.</param>
		/// <param name="index">Индекс в массиве, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Количество элементов в массиве <see cref="T:System.Collections.Specialized.StringDictionary" /> больше, чем может поместиться в свободном пространстве между индексом <paramref name="index" /> и концом массива <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> меньше нижней границы массива <paramref name="array" />.</exception>
		// Token: 0x060026E5 RID: 9957 RVA: 0x000874D5 File Offset: 0x000856D5
		public virtual void CopyTo(Array array, int index)
		{
			this.contents.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, который осуществляет перебор элементов словаря строк.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор элементов в словаре строк.</returns>
		// Token: 0x060026E6 RID: 9958 RVA: 0x000874E4 File Offset: 0x000856E4
		public virtual IEnumerator GetEnumerator()
		{
			return this.contents.GetEnumerator();
		}

		/// <summary>Удаляет запись с указанным ключом из словаря строк.</summary>
		/// <param name="key">Ключ записи, которую требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Ключ имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Specialized.StringDictionary" /> доступен только для чтения.</exception>
		// Token: 0x060026E7 RID: 9959 RVA: 0x000874F1 File Offset: 0x000856F1
		public virtual void Remove(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.contents.Remove(key.ToLowerInvariant());
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00087512 File Offset: 0x00085712
		internal void ReplaceHashtable(Hashtable useThisHashtableInstead)
		{
			this.contents = useThisHashtableInstead;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0008751B File Offset: 0x0008571B
		internal IDictionary<string, string> AsGenericDictionary()
		{
			return new GenericAdapter(this);
		}

		// Token: 0x04001514 RID: 5396
		internal Hashtable contents = new Hashtable();
	}
}
