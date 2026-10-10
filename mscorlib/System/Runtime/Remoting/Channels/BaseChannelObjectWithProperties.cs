using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает основную реализацию объекта канала, которая представляет интерфейс словаря его свойствам.</summary>
	// Token: 0x020005A4 RID: 1444
	[ComVisible(true)]
	public abstract class BaseChannelObjectWithProperties : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties" />.</summary>
		// Token: 0x06003814 RID: 14356 RVA: 0x000C9481 File Offset: 0x000C7681
		protected BaseChannelObjectWithProperties()
		{
			this.table = new Hashtable();
		}

		/// <summary>Возвращает число свойств, связанных с объектом канала.</summary>
		/// <returns>Число свойств, связанных с объектом канала.</returns>
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x000C9494 File Offset: 0x000C7694
		public virtual int Count
		{
			[SecuritySafeCritical]
			get
			{
				return this.table.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее, фиксировано ли число свойств, которые могут быть введены в объект канала.</summary>
		/// <returns>
		///   <see langword="true" />, если число свойств, которые могут быть введены в объект канала, является фиксированным, в противном случае значение равно <see langword="false" />.</returns>
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual bool IsFixedSize
		{
			[SecuritySafeCritical]
			get
			{
				return true;
			}
		}

		/// <summary>Логическое значение, указывающее, является ли коллекция свойств в объекте текущего канала предназначенной только для чтения.</summary>
		/// <returns>
		///   <see langword="true" />, если коллекция свойств в объекте канала доступна только для чтения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsReadOnly
		{
			[SecuritySafeCritical]
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, синхронизован ли словарь свойств объекта канала.</summary>
		/// <returns>
		///   <see langword="true" />, если словарь свойств объекта канала синхронизирован; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSynchronized
		{
			[SecuritySafeCritical]
			get
			{
				return false;
			}
		}

		/// <summary>При переопределении в производном классе возвращает или задает свойство, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ свойства, который требуется получить или задать.</param>
		/// <returns>Свойство, связанное с заданным ключом.</returns>
		/// <exception cref="T:System.NotImplementedException">Свойство, к которому производится доступ.</exception>
		// Token: 0x170007E9 RID: 2025
		public virtual object this[object key]
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
			[SecuritySafeCritical]
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>При перезаписи в выведенном классе возвращает коллекцию ключей <see cref="T:System.Collections.ICollection" />, с которыми связаны свойства объектов канала.</summary>
		/// <returns>Коллекция ключей <see cref="T:System.Collections.ICollection" />, с которыми связаны свойства объектов канала.</returns>
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x000C94A1 File Offset: 0x000C76A1
		public virtual ICollection Keys
		{
			[SecuritySafeCritical]
			get
			{
				return this.table.Keys;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Collections.IDictionary" /> канала, с которыми связаны свойства объекта канала.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IDictionary" /> свойств канала, с которыми связан объект канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x0000270D File Offset: 0x0000090D
		public virtual IDictionary Properties
		{
			get
			{
				return this;
			}
		}

		/// <summary>Получает объект, который может быть использован для синхронизации доступа к <see cref="T:System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties" />.</summary>
		/// <returns>Объект, который может быть использован для синхронизации доступа к <see cref="T:System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties" />.</returns>
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x0000270D File Offset: 0x0000090D
		public virtual object SyncRoot
		{
			[SecuritySafeCritical]
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Collections.ICollection" /> значений свойств, с которыми связан объект канала.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.ICollection" /> значений свойств, с которыми связан объект канала.</returns>
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x000C94AE File Offset: 0x000C76AE
		public virtual ICollection Values
		{
			[SecuritySafeCritical]
			get
			{
				return this.table.Values;
			}
		}

		/// <summary>Создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="key">Ключ, связанный с объектом, который содержится в параметре <paramref name="value" />.</param>
		/// <param name="value">Значение для сложения.</param>
		/// <exception cref="T:System.NotSupportedException">Был вызван метод.</exception>
		// Token: 0x0600381F RID: 14367 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecuritySafeCritical]
		public virtual void Add(object key, object value)
		{
			throw new NotSupportedException();
		}

		/// <summary>Создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Был вызван метод.</exception>
		// Token: 0x06003820 RID: 14368 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecuritySafeCritical]
		public virtual void Clear()
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает значение, указывающее, содержит ли объект текущего канала свойство, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ свойства для поиска.</param>
		/// <returns>
		///   <see langword="true" />, если объект канала содержит свойство, связанное с заданным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003821 RID: 14369 RVA: 0x000C94BB File Offset: 0x000C76BB
		[SecuritySafeCritical]
		public virtual bool Contains(object key)
		{
			return this.table.Contains(key);
		}

		/// <summary>Создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="array">Массив, в который выполняется копирование свойств.</param>
		/// <param name="index">Индекс, с которого начинается копирование.</param>
		/// <exception cref="T:System.NotSupportedException">Был вызван метод.</exception>
		// Token: 0x06003822 RID: 14370 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecuritySafeCritical]
		public virtual void CopyTo(Array array, int index)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает <see cref="T:System.Collections.IDictionaryEnumerator" />, который перечисляет все свойства, связанные с объектом канала.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IDictionaryEnumerator" />, который перечисляет все свойства, связанные с объектом канала.</returns>
		// Token: 0x06003823 RID: 14371 RVA: 0x000C94C9 File Offset: 0x000C76C9
		[SecuritySafeCritical]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return this.table.GetEnumerator();
		}

		/// <summary>Возвращает <see cref="T:System.Collections.IEnumerator" />, который перечисляет все свойства, связанные с объектом канала.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IEnumerator" />, который перечисляет все свойства, связанные с объектом канала.</returns>
		// Token: 0x06003824 RID: 14372 RVA: 0x000C94C9 File Offset: 0x000C76C9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.table.GetEnumerator();
		}

		/// <summary>Создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="key">Ключ объекта, который нужно удалить.</param>
		/// <exception cref="T:System.NotSupportedException">Был вызван метод.</exception>
		// Token: 0x06003825 RID: 14373 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecuritySafeCritical]
		public virtual void Remove(object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040025CD RID: 9677
		private Hashtable table;
	}
}
