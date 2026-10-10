using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>
	///         Представляет результат операции сортировки.
	///       </summary>
	/// <typeparam name="T">
	///           Тип содержимого источника данных.
	///         </typeparam>
	// Token: 0x02000078 RID: 120
	public interface IOrderedQueryable<out T> : IQueryable<T>, IEnumerable<!0>, IEnumerable, IQueryable, IOrderedQueryable
	{
	}
}
