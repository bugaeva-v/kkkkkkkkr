using System;
using System.Linq.Expressions;

namespace System.Linq
{
	/// <summary>
	///         Определяет методы для создания и выполнения запросов, описываемых <see cref="T:System.Linq.IQueryable" /> объекта.
	///       </summary>
	// Token: 0x02000076 RID: 118
	public interface IQueryProvider
	{
		/// <summary>
		///         Создает <see cref="T:System.Linq.IQueryable" /> объекта, который позволяет вычислить запрос, представленный заданным деревом выражения.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое представляет LINQ запроса.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable" /> Можно вычислить запрос, представленный заданным деревом выражения.
		///       </returns>
		// Token: 0x06000284 RID: 644
		IQueryable CreateQuery(Expression expression);

		/// <summary>
		///         Создает <see cref="T:System.Linq.IQueryable`1" /> объекта, который позволяет вычислить запрос, представленный заданным деревом выражения.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое представляет LINQ запроса.
		///         </param>
		/// <typeparam name="TElement">
		///           Тип элементов <see cref="T:System.Linq.IQueryable`1" /> который возвращается.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Можно вычислить запрос, представленный заданным деревом выражения.
		///       </returns>
		// Token: 0x06000285 RID: 645
		IQueryable<TElement> CreateQuery<TElement>(Expression expression);

		/// <summary>
		///         Выполняет запрос, представленный заданным деревом выражения.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое представляет LINQ запроса.
		///         </param>
		/// <returns>
		///         Значение, получаемое в результате выполнения указанного запроса.
		///       </returns>
		// Token: 0x06000286 RID: 646
		object Execute(Expression expression);

		/// <summary>
		///         Выполняет строго типизированный запрос, представленный заданным деревом выражения.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое представляет LINQ запроса.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип значения, полученного в результате выполнения запроса.
		///         </typeparam>
		/// <returns>
		///         Значение, получаемое в результате выполнения указанного запроса.
		///       </returns>
		// Token: 0x06000287 RID: 647
		TResult Execute<TResult>(Expression expression);
	}
}
