using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq
{
	/// <summary>
	///         Представляет коллекцию <see cref="T:System.Collections.Generic.IEnumerable`1" /> в качестве источника данных <see cref="T:System.Linq.IQueryable`1" />.
	///       </summary>
	/// <typeparam name="T">
	///           Тип данных в коллекции.
	///         </typeparam>
	// Token: 0x0200008F RID: 143
	public class EnumerableQuery<T> : EnumerableQuery, IOrderedQueryable<T>, IQueryable<T>, IEnumerable<!0>, IEnumerable, IQueryable, IOrderedQueryable, IQueryProvider
	{
		/// <summary>
		///         Возвращает поставщик запросов, связанный с данным экземпляром.
		///       </summary>
		/// <returns>
		///         Поставщик запросов, связанный с данным экземпляром.
		///       </returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000022A7 File Offset: 0x000004A7
		IQueryProvider IQueryable.Provider
		{
			get
			{
				return this;
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Linq.EnumerableQuery`1" /> класса и связывает его с <see cref="T:System.Collections.Generic.IEnumerable`1" /> коллекции.
		///       </summary>
		/// <param name="enumerable">
		///           Коллекция для связи с новым экземпляром.
		///         </param>
		// Token: 0x06000416 RID: 1046 RVA: 0x0000BE70 File Offset: 0x0000A070
		public EnumerableQuery(IEnumerable<T> enumerable)
		{
			this._enumerable = enumerable;
			this._expression = Expression.Constant(this);
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Linq.EnumerableQuery`1" /> класса и связывает экземпляр с помощью дерева выражений.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, чтобы связать с новым экземпляром.
		///         </param>
		// Token: 0x06000417 RID: 1047 RVA: 0x0000BE8B File Offset: 0x0000A08B
		public EnumerableQuery(Expression expression)
		{
			this._expression = expression;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000BE9A File Offset: 0x0000A09A
		internal override Expression Expression
		{
			get
			{
				return this._expression;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000BEA2 File Offset: 0x0000A0A2
		internal override IEnumerable Enumerable
		{
			get
			{
				return this._enumerable;
			}
		}

		/// <summary>
		///         Возвращает дерево выражения, связанное с или, представляющий этот экземпляр.
		///       </summary>
		/// <returns>
		///         Дерево выражения, связанное с или, представляющий этот экземпляр.
		///       </returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000BE9A File Offset: 0x0000A09A
		Expression IQueryable.Expression
		{
			get
			{
				return this._expression;
			}
		}

		/// <summary>
		///         Возвращает тип данных в коллекции, представляемый этим экземпляром.
		///       </summary>
		/// <returns>
		///         Тип данных в коллекции, представляемый этим экземпляром.
		///       </returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000BEAA File Offset: 0x0000A0AA
		Type IQueryable.ElementType
		{
			get
			{
				return typeof(T);
			}
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Linq.EnumerableQuery`1" /> объекта и связывает его с указанным выражением дерево, представляющее <see cref="T:System.Linq.IQueryable" /> коллекции данных.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое представляет <see cref="T:System.Linq.IQueryable" /> коллекцию данных.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Linq.EnumerableQuery`1" /> Объект, связанный с <paramref name="expression" />.
		///       </returns>
		// Token: 0x0600041C RID: 1052 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		IQueryable IQueryProvider.CreateQuery(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			Type type = TypeHelper.FindGenericType(typeof(IQueryable<>), expression.Type);
			if (type == null)
			{
				throw Error.ArgumentNotValid("expression");
			}
			return EnumerableQuery.Create(type.GetGenericArguments()[0], expression);
		}

		/// <summary>
		///         Создает новый <see cref="T:System.Linq.EnumerableQuery`1" /> объекта и связывает его с указанным выражением дерево, представляющее <see cref="T:System.Linq.IQueryable`1" /> коллекции данных.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражений для выполнения.
		///         </param>
		/// <typeparam name="S">
		///           Тип данных в коллекции, <paramref name="expression" /> представляет.
		///         </typeparam>
		/// <returns>
		///         Объект, связанный с EnumerableQuery <paramref name="expression" />.
		///       </returns>
		// Token: 0x0600041D RID: 1053 RVA: 0x0000BF09 File Offset: 0x0000A109
		IQueryable<TElement> IQueryProvider.CreateQuery<TElement>(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			if (!typeof(IQueryable<TElement>).IsAssignableFrom(expression.Type))
			{
				throw Error.ArgumentNotValid("expression");
			}
			return new EnumerableQuery<TElement>(expression);
		}

		/// <summary>
		///         Выполняет выражение после его для вызова перезаписи <see cref="T:System.Linq.Enumerable" /> методов вместо <see cref="T:System.Linq.Queryable" /> методы все перечислимые источники данных, не сможет выполнять запросы <see cref="T:System.Linq.Queryable" /> методы.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражений для выполнения.
		///         </param>
		/// <returns>
		///         Значение, получаемое в результате выполнения <paramref name="expression" />.
		///       </returns>
		// Token: 0x0600041E RID: 1054 RVA: 0x0000BF41 File Offset: 0x0000A141
		object IQueryProvider.Execute(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			return EnumerableExecutor.Create(expression).ExecuteBoxed();
		}

		/// <summary>
		///         Выполняет выражение после его для вызова перезаписи <see cref="T:System.Linq.Enumerable" /> методов вместо <see cref="T:System.Linq.Queryable" /> методы все перечислимые источники данных, не сможет выполнять запросы <see cref="T:System.Linq.Queryable" /> методы.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражений для выполнения.
		///         </param>
		/// <typeparam name="S">
		///           Тип данных в коллекции, <paramref name="expression" /> представляет.
		///         </typeparam>
		/// <returns>
		///         Значение, получаемое в результате выполнения <paramref name="expression" />.
		///       </returns>
		// Token: 0x0600041F RID: 1055 RVA: 0x0000BF5C File Offset: 0x0000A15C
		TElement IQueryProvider.Execute<TElement>(Expression expression)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			if (!typeof(TElement).IsAssignableFrom(expression.Type))
			{
				throw Error.ArgumentNotValid("expression");
			}
			return new EnumerableExecutor<TElement>(expression).Execute();
		}

		/// <summary>
		///         Возвращает перечислитель, выполняющий итерацию связанного <see cref="T:System.Collections.Generic.IEnumerable`1" /> коллекции, или, если он имеет значение null, если в коллекции, полученный в результате перезаписи дерева связанное выражение как запрос на <see cref="T:System.Collections.Generic.IEnumerable`1" /> источника данных и его выполнением.
		///       </summary>
		/// <returns>
		///         Перечислитель, который может использоваться для итерации по связанного источника данных.
		///       </returns>
		// Token: 0x06000420 RID: 1056 RVA: 0x0000BF99 File Offset: 0x0000A199
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000BF99 File Offset: 0x0000A199
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		private IEnumerator<T> GetEnumerator()
		{
			if (this._enumerable == null)
			{
				IEnumerable<T> enumerable = Expression.Lambda<Func<IEnumerable<T>>>(new EnumerableRewriter().Visit(this._expression), null).Compile()();
				if (enumerable == this)
				{
					throw Error.EnumeratingNullEnumerableExpression();
				}
				this._enumerable = enumerable;
			}
			return this._enumerable.GetEnumerator();
		}

		/// <summary>
		///         Возвращает текстовое представление перечислимой коллекции или, если он имеет значение null, дерева выражения, связанного с данным экземпляром.
		///       </summary>
		/// <returns>
		///         Текстовое представление перечислимой коллекции или, если он имеет значение null, дерева выражения, связанного с данным экземпляром.
		///       </returns>
		// Token: 0x06000423 RID: 1059 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		public override string ToString()
		{
			ConstantExpression constantExpression = this._expression as ConstantExpression;
			if (constantExpression == null || constantExpression.Value != this)
			{
				return this._expression.ToString();
			}
			if (this._enumerable != null)
			{
				return this._enumerable.ToString();
			}
			return "null";
		}

		// Token: 0x04000448 RID: 1096
		private readonly Expression _expression;

		// Token: 0x04000449 RID: 1097
		private IEnumerable<T> _enumerable;
	}
}
