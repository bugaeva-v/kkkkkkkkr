using System;

namespace System.Data.SqlTypes
{
	/// <summary>Во всех объектах и структурах <see cref="N:System.Data.SqlTypes" /> реализован интерфейс <see langword="INullable" />.</summary>
	// Token: 0x02000304 RID: 772
	public interface INullable
	{
		/// <summary>Показывает, является ли структура неопределенной. Это свойство доступно только для чтения.</summary>
		/// <returns>
		///   <see cref="T:System.Data.SqlTypes.SqlBoolean" />
		///   <see langword="true" />, если значение этого объекта равно NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002242 RID: 8770
		bool IsNull { get; }
	}
}
