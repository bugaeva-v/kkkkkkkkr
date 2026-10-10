using System;
using System.Collections;
using System.Linq.Expressions;

namespace System.Linq
{
	/// <summary>
	///         Предоставляет функциональные возможности для оценки запросов по определенным источникам данных в случае, если тип данных не указан.
	///       </summary>
	// Token: 0x02000074 RID: 116
	public interface IQueryable : IEnumerable
	{
		/// <summary>
		///         Возвращает дерево выражения, связанного с экземпляром <see cref="T:System.Linq.IQueryable" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Связанный с этим экземпляром <see cref="T:System.Linq.IQueryable" />.
		///       </returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000281 RID: 641
		Expression Expression { get; }

		/// <summary>
		///         Возвращает тип элементов, которые возвращаются, когда дерево выражения, связанный с этим экземпляром <see cref="T:System.Linq.IQueryable" /> выполняется.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" /> представляющий тип элементов, которые возвращаются при выполнении дерева выражения, связанного с данным объектом.
		///       </returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000282 RID: 642
		Type ElementType { get; }

		/// <summary>
		///         Возвращает поставщик запросов, связанный с этим источником данных.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryProvider" /> Связанный с этим источником данных.
		///       </returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000283 RID: 643
		IQueryProvider Provider { get; }
	}
}
