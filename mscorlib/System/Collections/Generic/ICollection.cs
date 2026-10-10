using System;

namespace System.Collections.Generic
{
	/// <summary>Определяет методы для управления универсальными коллекциями.</summary>
	/// <typeparam name="T">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000A92 RID: 2706
	public interface ICollection<T> : IEnumerable<!0>, IEnumerable
	{
		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600610F RID: 24847
		int Count { get; }

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.Generic.ICollection`1" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.Generic.ICollection`1" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06006110 RID: 24848
		bool IsReadOnly { get; }

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <param name="item">Объект, добавляемый в коллекцию <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.ICollection`1" /> доступен только для чтения.</exception>
		// Token: 0x06006111 RID: 24849
		void Add(T item);

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.ICollection`1" /> доступен только для чтения.</exception>
		// Token: 0x06006112 RID: 24850
		void Clear();

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.Generic.ICollection`1" /> указанное значение.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.Generic.ICollection`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06006113 RID: 24851
		bool Contains(T item);

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.ICollection`1" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.ICollection`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.ICollection`1" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006114 RID: 24852
		void CopyTo(T[] array, int arrayIndex);

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
		/// <param name="item">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="item" /> успешно удален из <see cref="T:System.Collections.Generic.ICollection`1" />; в противном случае — значение <see langword="false" />. Этот метод также возвращает значение <see langword="false" />, если значение <paramref name="item" /> не найдено в исходной коллекции <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.ICollection`1" /> доступен только для чтения.</exception>
		// Token: 0x06006115 RID: 24853
		bool Remove(T item);
	}
}
