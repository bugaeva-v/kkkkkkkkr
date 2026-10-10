using System;

namespace System.Collections.Generic
{
	/// <summary>Представляет коллекцию объектов, доступ к которым может быть получен индивидуально по индексу.</summary>
	/// <typeparam name="T">Тип элементов в списке.</typeparam>
	// Token: 0x02000A9C RID: 2716
	public interface IList<T> : ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и список <see cref="T:System.Collections.Generic.IList`1" /> доступен только для чтения.</exception>
		// Token: 0x17001146 RID: 4422
		T this[int index]
		{
			get;
			set;
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.Generic.IList`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.IList`1" />.</param>
		/// <returns>Индекс <paramref name="item" />, если он найден в списке; в противном случае — значение -1.</returns>
		// Token: 0x0600612D RID: 24877
		int IndexOf(T item);

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.Generic.IList`1" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Объект, вставляемый в коллекцию <see cref="T:System.Collections.Generic.IList`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.IList`1" /> доступен только для чтения.</exception>
		// Token: 0x0600612E RID: 24878
		void Insert(int index, T item);

		/// <summary>Удаляет элемент <see cref="T:System.Collections.Generic.IList`1" />, расположенный по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.Generic.IList`1" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.IList`1" /> доступен только для чтения.</exception>
		// Token: 0x0600612F RID: 24879
		void RemoveAt(int index);
	}
}
