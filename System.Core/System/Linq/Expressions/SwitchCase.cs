using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет отдельный случай класса <see cref="T:System.Linq.Expressions.SwitchExpression" />.
	///       </summary>
	// Token: 0x0200029C RID: 668
	[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
	public sealed class SwitchCase
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0003D0E1 File Offset: 0x0003B2E1
		internal SwitchCase(Expression body, ReadOnlyCollection<Expression> testValues)
		{
			this.Body = body;
			this.TestValues = testValues;
		}

		/// <summary>
		///         Возвращает значения для данного блока case.
		///          Этот вариант выбран для выполнения при <see cref="P:System.Linq.Expressions.SwitchExpression.SwitchValue" /> соответствует любому из следующих значений.
		///       </summary>
		/// <returns>
		///         Только для чтения коллекция значений данного блока case.
		///       </returns>
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0003D0F7 File Offset: 0x0003B2F7
		public ReadOnlyCollection<Expression> TestValues { get; }

		/// <summary>
		///         Получает тело блока case.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий тело блока case.
		///       </returns>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0003D0FF File Offset: 0x0003B2FF
		public Expression Body { get; }

		/// <summary>
		///         Возвращает строку <see cref="T:System.String" />, которая представляет текущий объект <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.String" />, представляющий текущий объект <see cref="T:System.Object" />.
		///       </returns>
		// Token: 0x060013D8 RID: 5080 RVA: 0x0003D107 File Offset: 0x0003B307
		public override string ToString()
		{
			return ExpressionStringBuilder.SwitchCaseToString(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="testValues">
		///           <see cref="P:System.Linq.Expressions.SwitchCase.TestValues" /> Свойства результата.
		///         </param>
		/// <param name="body">
		///           <see cref="P:System.Linq.Expressions.SwitchCase.Body" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060013D9 RID: 5081 RVA: 0x0003D10F File Offset: 0x0003B30F
		public SwitchCase Update(IEnumerable<Expression> testValues, Expression body)
		{
			if ((body == this.Body & testValues != null) && ExpressionUtils.SameElements<Expression>(ref testValues, this.TestValues))
			{
				return this;
			}
			return Expression.SwitchCase(body, testValues);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000235B File Offset: 0x0000055B
		internal SwitchCase()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
