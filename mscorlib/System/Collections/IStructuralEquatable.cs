using System;

namespace System.Collections
{
	/// <summary>Определяет методы, поддерживающие сравнение объектов на предмет структурного равенства.</summary>
	// Token: 0x02000A1B RID: 2587
	public interface IStructuralEquatable
	{
		/// <summary>Определяет, соблюдается ли структурное равенство между объектом и текущим экземпляром.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, определяющий, равны ли текущий экземпляр и объект <paramref name="other" />.</param>
		/// <returns>Значение <see langword="true" />, если эти два объекта равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005BA3 RID: 23459
		bool Equals(object other, IEqualityComparer comparer);

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <param name="comparer">Объект, вычисляющий хэш-код текущего объекта.</param>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x06005BA4 RID: 23460
		int GetHashCode(IEqualityComparer comparer);
	}
}
