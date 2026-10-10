using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Создает выражение, применяющее делегат или лямбда-выражение к списку выражений аргумента.
	///       </summary>
	// Token: 0x02000261 RID: 609
	[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x0003A9DE File Offset: 0x00038BDE
		internal InvocationExpression(Expression expression, Type returnType)
		{
			this.Expression = expression;
			this.Type = returnType;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="P:System.Linq.Expressions.InvocationExpression.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.InvocationExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		public sealed override Type Type { get; }

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0003A9FC File Offset: 0x00038BFC
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Invoke;
			}
		}

		/// <summary>
		///         Получает делегат или лямбда-выражение для применения.
		///       </summary>
		/// <returns>
		///         Выражение <see cref="T:System.Linq.Expressions.Expression" />, представляющее делегат для применения.
		///       </returns>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0003AA00 File Offset: 0x00038C00
		public Expression Expression { get; }

		/// <summary>
		///         Получает аргументы, к которым применяется делегат или лямбда-выражение.
		///       </summary>
		/// <returns>
		///         Коллекция <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> объектов <see cref="T:System.Linq.Expressions.Expression" />, представляющих аргументы, к которым применяется делегат.
		///       </returns>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0003AA08 File Offset: 0x00038C08
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return this.GetOrMakeArguments();
			}
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="expression">
		///           Свойство <see cref="P:System.Linq.Expressions.InvocationExpression.Expression" /> результата.
		///         </param>
		/// <param name="arguments">
		///           Свойство <see cref="P:System.Linq.Expressions.InvocationExpression.Arguments" /> результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060011D0 RID: 4560 RVA: 0x0003AA10 File Offset: 0x00038C10
		public InvocationExpression Update(Expression expression, IEnumerable<Expression> arguments)
		{
			if ((expression == this.Expression & arguments != null) && ExpressionUtils.SameElements<Expression>(ref arguments, this.Arguments))
			{
				return this;
			}
			return Expression.Invoke(expression, arguments);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0003AA3A File Offset: 0x00038C3A
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitInvocation(this);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00034D18 File Offset: 0x00032F18
		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0003AA43 File Offset: 0x00038C43
		internal LambdaExpression LambdaOperand
		{
			get
			{
				if (this.Expression.NodeType != ExpressionType.Quote)
				{
					return this.Expression as LambdaExpression;
				}
				return (LambdaExpression)((UnaryExpression)this.Expression).Operand;
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000235B File Offset: 0x0000055B
		internal InvocationExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
