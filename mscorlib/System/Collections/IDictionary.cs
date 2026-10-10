using System;

namespace System.Collections
{
	/// <summary>Представляет небазовую коллекцию пар «ключ-значение».</summary>
	// Token: 0x02000A14 RID: 2580
	public interface IDictionary : ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить или задать.</param>
		/// <returns>Элемент с указанным ключом либо <see langword="null" />, если такого ключа не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и объект <see cref="T:System.Collections.IDictionary" /> доступен только для чтения.  
		///
		/// или - 
		/// Свойство задано, <paramref name="key" /> не существует в коллекции, а <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер.</exception>
		// Token: 0x17000FC2 RID: 4034
		object this[object key]
		{
			get;
			set;
		}

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий ключи объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий ключи объекта <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06005B85 RID: 23429
		ICollection Keys { get; }

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий значения из объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий значения из объекта <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06005B86 RID: 23430
		ICollection Values { get; }

		/// <summary>Определяет, содержится ли элемент с указанным ключом в объекте <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ для размещения в объекте <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Collections.IDictionary" /> содержится элемент с данным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005B87 RID: 23431
		bool Contains(object key);

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Объект <see cref="T:System.Object" /> используется в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> используется в качестве значения добавляемого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в объекте <see cref="T:System.Collections.IDictionary" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IDictionary" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер.</exception>
		// Token: 0x06005B88 RID: 23432
		void Add(object key, object value);

		/// <summary>Удаляет все элементы из объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IDictionary" /> доступен только для чтения.</exception>
		// Token: 0x06005B89 RID: 23433
		void Clear();

		/// <summary>Получает значение, показывающее, является ли объект <see cref="T:System.Collections.IDictionary" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.IDictionary" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06005B8A RID: 23434
		bool IsReadOnly { get; }

		/// <summary>Получает значение, показывающее, имеет ли объект <see cref="T:System.Collections.IDictionary" /> фиксированный размер.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06005B8B RID: 23435
		bool IsFixedSize { get; }

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для объекта <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06005B8C RID: 23436
		IDictionaryEnumerator GetEnumerator();

		/// <summary>Удаляет элемент с указанным ключом из объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IDictionary" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер.</exception>
		// Token: 0x06005B8D RID: 23437
		void Remove(object key);
	}
}
