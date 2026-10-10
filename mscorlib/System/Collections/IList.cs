using System;

namespace System.Collections
{
	/// <summary>Представляет неуниверсальную коллекцию объектов, к каждому из которых можно получить индивидуальный доступ по индексу.</summary>
	// Token: 0x02000A19 RID: 2585
	public interface IList : ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и список <see cref="T:System.Collections.IList" /> доступен только для чтения.</exception>
		// Token: 0x17000FCB RID: 4043
		object this[int index]
		{
			get;
			set;
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект, добавляемый в коллекцию <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, в которую вставлен новый элемент, или значение -1, если элемент не вставлен в коллекцию.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005B99 RID: 23449
		int Add(object value);

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Object" /> найден в <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005B9A RID: 23450
		bool Contains(object value);

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.</exception>
		// Token: 0x06005B9B RID: 23451
		void Clear();

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06005B9C RID: 23452
		bool IsReadOnly { get; }

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06005B9D RID: 23453
		bool IsFixedSize { get; }

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		// Token: 0x06005B9E RID: 23454
		int IndexOf(object value);

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект, вставляемый в коллекцию <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="value" /> — пустая ссылка в списке <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06005B9F RID: 23455
		void Insert(int index, object value);

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005BA0 RID: 23456
		void Remove(object value);

		/// <summary>Удаляет элемент <see cref="T:System.Collections.IList" />, расположенный по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.IList" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.IList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005BA1 RID: 23457
		void RemoveAt(int index);
	}
}
