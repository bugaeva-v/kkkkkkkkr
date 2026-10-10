using System;

namespace System.Collections.Generic
{
	/// <summary>Предоставляет основной интерфейс для абстракции наборов.</summary>
	/// <typeparam name="T">Тип элементов в наборе.</typeparam>
	// Token: 0x020004F1 RID: 1265
	public interface ISet<T> : ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		/// <summary>Добавляет элемент в текущий набор и возвращает значение, указывающее, что элемент был добавлен успешно.</summary>
		/// <param name="item">Элемент, добавляемый в набор.</param>
		/// <returns>Значение <see langword="true" />, если элемент добавлен в набор; значение <see langword="false" />, если элемент уже был в наборе.</returns>
		// Token: 0x0600295B RID: 10587
		bool Add(T item);

		/// <summary>Изменяет текущий набор так, чтобы он содержал все элементы, которые имеются в текущем наборе, в указанной коллекции либо в них обоих.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600295C RID: 10588
		void UnionWith(IEnumerable<T> other);

		/// <summary>Изменяет текущий набор, чтобы он содержал только элементы, которые также имеются в заданной коллекции.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600295D RID: 10589
		void IntersectWith(IEnumerable<T> other);

		/// <summary>Удаляет все элементы указанной коллекции из текущего набора.</summary>
		/// <param name="other">Коллекция элементов, которые нужно удалить из набора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600295E RID: 10590
		void ExceptWith(IEnumerable<T> other);

		/// <summary>Изменяет текущий набор таким образом, чтобы он содержал только элементы, которые есть либо в нем, либо в указанной коллекции, но не одновременно там и там.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600295F RID: 10591
		void SymmetricExceptWith(IEnumerable<T> other);

		/// <summary>Определяет, является ли набор подмножеством заданной коллекции.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если текущий набор является подмножеством объекта <paramref name="other" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002960 RID: 10592
		bool IsSubsetOf(IEnumerable<T> other);

		/// <summary>Определяет, является ли текущий набор надмножеством заданной коллекции.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если текущий набор является надмножеством объекта <paramref name="other" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002961 RID: 10593
		bool IsSupersetOf(IEnumerable<T> other);

		/// <summary>Определяет, является ли текущий набор должным (строгим) подмножеством заданной коллекции.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если текущий набор является строгим надмножеством объекта <paramref name="other" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002962 RID: 10594
		bool IsProperSupersetOf(IEnumerable<T> other);

		/// <summary>Определяет, является ли текущий набор должным (строгим) подмножеством заданной коллекции.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если текущий набор является строгим подмножеством объекта <paramref name="other" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002963 RID: 10595
		bool IsProperSubsetOf(IEnumerable<T> other);

		/// <summary>Определяет, пересекаются ли текущий набор и указанная коллекция.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если в текущем наборе и объекте <paramref name="other" /> есть хотя бы один общий элемент; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002964 RID: 10596
		bool Overlaps(IEnumerable<T> other);

		/// <summary>Определяет, содержат ли текущий набор и указанная коллекция одни и те же элементы.</summary>
		/// <param name="other">Коллекция для сравнения с текущим набором.</param>
		/// <returns>Значение <see langword="true" />, если текущий набор равен объекту <paramref name="other" />; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="other" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002965 RID: 10597
		bool SetEquals(IEnumerable<T> other);
	}
}
