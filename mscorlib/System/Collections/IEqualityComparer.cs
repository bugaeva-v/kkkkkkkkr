using System;

namespace System.Collections
{
	/// <summary>Определяет методы, поддерживающие сравнение объектов на предмет равенства.</summary>
	// Token: 0x02000A18 RID: 2584
	public interface IEqualityComparer
	{
		/// <summary>Определяет, равны ли два указанных объекта.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если указанные объекты равны; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="x" /> и <paramref name="y" /> имеют разные типы и не могут сравниваться друг с другом.</exception>
		// Token: 0x06005B95 RID: 23445
		bool Equals(object x, object y);

		/// <summary>Возвращает хэш-код указанного объекта.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Тип <paramref name="obj" /> является ссылочным типом и <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06005B96 RID: 23446
		int GetHashCode(object obj);
	}
}
