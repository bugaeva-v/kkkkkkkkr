using System;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
	/// <summary>Определяет методы для управления потокобезопасными коллекциями, предназначенными для использования производителем и потребителем. Этот интерфейс обеспечивает унифицированное представление для коллекций производителей/потребителей, чтобы абстракции более высокого уровня, такие как <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />, могли использовать коллекцию в качестве базового механизма хранения.</summary>
	/// <typeparam name="T">Определяет тип элементов коллекции.</typeparam>
	// Token: 0x02000A61 RID: 2657
	public interface IProducerConsumerCollection<T> : IEnumerable<!0>, IEnumerable, ICollection
	{
		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" /> в массив <see cref="T:System.Array" /> начиная с указанного индекса.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.  
		/// Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> больше или равен длине <paramref name="array" />, -или- количество элементов в коллекции больше, чем свободное пространство в диапазоне от <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005F75 RID: 24437
		void CopyTo(T[] array, int index);

		/// <summary>Пытается добавить объект в коллекцию <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.</summary>
		/// <param name="item">Объект, добавляемый в коллекцию <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.</param>
		/// <returns>Значение true, если объект был успешно добавлен; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> недопустим для данной коллекции.</exception>
		// Token: 0x06005F76 RID: 24438
		bool TryAdd(T item);

		/// <summary>Пытается удалить и вернуть объект из коллекции <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.</summary>
		/// <param name="item">В случае успешного удаления и возвращения объекта параметр <paramref name="item" />, возвращаемый данным методом, содержит удаленный объект. Если объект, доступный для удаления, не найден, значение не определено.</param>
		/// <returns>Значение true, если объект был успешно удален и возвращен; в противном случае — значение false.</returns>
		// Token: 0x06005F77 RID: 24439
		bool TryTake(out T item);

		/// <summary>Копирует элементы, содержащиеся в коллекции <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />, в новый массив.</summary>
		/// <returns>Новый массив, содержащий элементы, скопированные из коллекции <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.</returns>
		// Token: 0x06005F78 RID: 24440
		T[] ToArray();
	}
}
