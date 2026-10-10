using System;

namespace System.Collections.Generic
{
	/// <summary>Определяет методы, поддерживающие сравнение объектов на предмет равенства.</summary>
	/// <typeparam name="T">Тип объектов для сравнения.</typeparam>
	// Token: 0x02000A9B RID: 2715
	public interface IEqualityComparer<in T>
	{
		/// <summary>Определяет, равны ли два указанных объекта.</summary>
		/// <param name="x">Первый сравниваемый объект типа <paramref name="T" />.</param>
		/// <param name="y">Второй сравниваемый объект типа <paramref name="T" />.</param>
		/// <returns>
		///   <see langword="true" />, если указанные объекты равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06006129 RID: 24873
		bool Equals(T x, T y);

		/// <summary>Возвращает хэш-код указанного объекта.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код указанного объекта.</returns>
		/// <exception cref="T:System.ArgumentNullException">Тип <paramref name="obj" /> является ссылочным типом и <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x0600612A RID: 24874
		int GetHashCode(T obj);
	}
}
