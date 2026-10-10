using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет оператор catch в блоке try.
	///       </summary>
	// Token: 0x0200023A RID: 570
	[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
	public sealed class CatchBlock
	{
		// Token: 0x06000FA2 RID: 4002 RVA: 0x00035626 File Offset: 0x00033826
		internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
		{
			this.Test = test;
			this.Variable = variable;
			this.Body = body;
			this.Filter = filter;
		}

		/// <summary>
		///         Получает ссылку на <see cref="T:System.Exception" /> объекта, Перехваченный данным обработчиком.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.ParameterExpression" /> Объект, представляющий ссылку на <see cref="T:System.Exception" /> объекта, Перехваченный данным обработчиком.
		///       </returns>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0003564B File Offset: 0x0003384B
		public ParameterExpression Variable { get; }

		/// <summary>
		///         Возвращает тип <see cref="T:System.Exception" /> перехватывает этот обработчик.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объект, представляющий тип <see cref="T:System.Exception" /> перехватывает этот обработчик.
		///       </returns>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00035653 File Offset: 0x00033853
		public Type Test { get; }

		/// <summary>
		///         Получает тело блока catch.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий тело catch.
		///       </returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0003565B File Offset: 0x0003385B
		public Expression Body { get; }

		/// <summary>
		///         Возвращает текст <see cref="T:System.Linq.Expressions.CatchBlock" /> фильтра.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий тело <see cref="T:System.Linq.Expressions.CatchBlock" /> фильтра.
		///       </returns>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00035663 File Offset: 0x00033863
		public Expression Filter { get; }

		/// <summary>
		///         Возвращает строку <see cref="T:System.String" />, которая представляет текущий объект <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.String" />, представляющий текущий объект <see cref="T:System.Object" />.
		///       </returns>
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0003566B File Offset: 0x0003386B
		public override string ToString()
		{
			return ExpressionStringBuilder.CatchBlockToString(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="variable">
		///           <see cref="P:System.Linq.Expressions.CatchBlock.Variable" /> Свойства результата.
		///         </param>
		/// <param name="filter">
		///           <see cref="P:System.Linq.Expressions.CatchBlock.Filter" /> Свойства результата.
		///         </param>
		/// <param name="body">
		///           <see cref="P:System.Linq.Expressions.CatchBlock.Body" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06000FA8 RID: 4008 RVA: 0x00035673 File Offset: 0x00033873
		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			if (variable == this.Variable && filter == this.Filter && body == this.Body)
			{
				return this;
			}
			return Expression.MakeCatchBlock(this.Test, variable, body, filter);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0000235B File Offset: 0x0000055B
		internal CatchBlock()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
