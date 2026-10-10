using System;

namespace System.Collections.Specialized
{
	/// <summary>Представляет индексированную коллекцию пар «ключ-значение».</summary>
	// Token: 0x020004A6 RID: 1190
	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ICollection.Count" />.</exception>
		// Token: 0x170007B5 RID: 1973
		object this[int index]
		{
			get;
			set;
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию элементов коллекции <see cref="T:System.Collections.Specialized.IOrderedDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для всей коллекции <see cref="T:System.Collections.Specialized.IOrderedDictionary" />.</returns>
		// Token: 0x06002645 RID: 9797
		IDictionaryEnumerator GetEnumerator();

		/// <summary>Вставляет пару "ключ-значение" в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому требуется вставить пару "ключ-значение".</param>
		/// <param name="key">Объект, используемый в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект, используемый в качестве значения добавляемого элемента.  Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ICollection.Count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в коллекции <see cref="T:System.Collections.Specialized.IOrderedDictionary" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.IOrderedDictionary" /> доступна только для чтения.  
		///
		/// или - 
		/// Коллекция <see cref="T:System.Collections.Specialized.IOrderedDictionary" /> имеет фиксированный размер.</exception>
		// Token: 0x06002646 RID: 9798
		void Insert(int index, object key, object value);

		/// <summary>Удаляет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ICollection.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.IOrderedDictionary" /> доступна только для чтения.  
		///
		/// или - 
		/// Коллекция <see cref="T:System.Collections.Specialized.IOrderedDictionary" /> имеет фиксированный размер.</exception>
		// Token: 0x06002647 RID: 9799
		void RemoveAt(int index);
	}
}
