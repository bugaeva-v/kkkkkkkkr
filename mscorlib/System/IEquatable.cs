using System;

namespace System
{
	/// <summary>Определяет обобщенный метод, который реализуется типом значения или классом для создания метода с целью определения экземпляров.</summary>
	/// <typeparam name="T">Тип объектов для сравнения.</typeparam>
	// Token: 0x0200013E RID: 318
	public interface IEquatable<T>
	{
		/// <summary>Указывает, эквивалентен ли текущий объект другому объекту того же типа.</summary>
		/// <param name="other">Объект, который требуется сравнить с данным объектом.</param>
		/// <returns>
		///   <see langword="true" />, если текущий объект эквивалентен параметру <paramref name="other" />, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000BFE RID: 3070
		bool Equals(T other);
	}
}
