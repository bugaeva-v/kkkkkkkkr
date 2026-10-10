using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет создание нового массива и по возможности инициализацию элементов нового массива.
	///       </summary>
	// Token: 0x0200028C RID: 652
	[DebuggerTypeProxy(typeof(Expression.NewArrayExpressionProxy))]
	public class NewArrayExpression : Expression
	{
		// Token: 0x060012EC RID: 4844 RVA: 0x0003C455 File Offset: 0x0003A655
		internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
			this.Expressions = expressions;
			this.Type = type;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0003C46B File Offset: 0x0003A66B
		internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
		{
			if (nodeType == ExpressionType.NewArrayInit)
			{
				return new NewArrayInitExpression(type, expressions);
			}
			return new NewArrayBoundsExpression(type, expressions);
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.NewArrayExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x0003C481 File Offset: 0x0003A681
		public sealed override Type Type { get; }

		/// <summary>
		///         Возвращает границы массива, если значение <see cref="P:System.Linq.Expressions.Expression.NodeType" /> свойство <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayBounds" />, или значения для инициализации элементов нового массива, если значение <see cref="P:System.Linq.Expressions.Expression.NodeType" /> свойство <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.Expression" /> объектов, которые представляют либо границ массива или значения инициализации.
		///       </returns>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0003C489 File Offset: 0x0003A689
		public ReadOnlyCollection<Expression> Expressions { get; }

		/// <summary>
		///         Отправляет в конкретный метод Visit для данного типа узла.
		///          Например, объект <see cref="T:System.Linq.Expressions.MethodCallExpression" /> вызывает метод <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.
		///       </summary>
		/// <param name="visitor">
		///           Посетитель, с помощью которого выполняется посещение этого узла.
		///         </param>
		/// <returns>
		///         Результат посещения этого узла.
		///       </returns>
		// Token: 0x060012F0 RID: 4848 RVA: 0x0003C491 File Offset: 0x0003A691
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitNewArray(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="expressions">
		///           <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060012F1 RID: 4849 RVA: 0x0003C49C File Offset: 0x0003A69C
		public NewArrayExpression Update(IEnumerable<Expression> expressions)
		{
			ContractUtils.RequiresNotNull(expressions, "expressions");
			if (ExpressionUtils.SameElements<Expression>(ref expressions, this.Expressions))
			{
				return this;
			}
			if (this.NodeType != ExpressionType.NewArrayInit)
			{
				return Expression.NewArrayBounds(this.Type.GetElementType(), expressions);
			}
			return Expression.NewArrayInit(this.Type.GetElementType(), expressions);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0000235B File Offset: 0x0000055B
		internal NewArrayExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
