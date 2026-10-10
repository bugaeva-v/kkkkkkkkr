using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет выражение, имеющее условный оператор.
	///       </summary>
	// Token: 0x0200023E RID: 574
	[DebuggerTypeProxy(typeof(Expression.ConditionalExpressionProxy))]
	public class ConditionalExpression : Expression
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x00035782 File Offset: 0x00033982
		internal ConditionalExpression(Expression test, Expression ifTrue)
		{
			this.Test = test;
			this.IfTrue = ifTrue;
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00035798 File Offset: 0x00033998
		internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			if (ifTrue.Type != type || ifFalse.Type != type)
			{
				return new FullConditionalExpressionWithType(test, ifTrue, ifFalse, type);
			}
			if (ifFalse is DefaultExpression && ifFalse.Type == typeof(void))
			{
				return new ConditionalExpression(test, ifTrue);
			}
			return new FullConditionalExpression(test, ifTrue, ifFalse);
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x000357FA File Offset: 0x000339FA
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Conditional;
			}
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.ConditionalExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000357FD File Offset: 0x000339FD
		public override Type Type
		{
			get
			{
				return this.IfTrue.Type;
			}
		}

		/// <summary>
		///         Получает проверку условной операции.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий теста условной операции.
		///       </returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0003580A File Offset: 0x00033A0A
		public Expression Test { get; }

		/// <summary>
		///         Возвращает выражение для выполнения, если проверка имеет значение <see langword="true" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий выражение для выполнения, если проверка не <see langword="true" />.
		///       </returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00035812 File Offset: 0x00033A12
		public Expression IfTrue { get; }

		/// <summary>
		///         Возвращает выражение для выполнения, если проверка имеет значение <see langword="false" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий выражение для выполнения, если проверка не <see langword="false" />.
		///       </returns>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0003581A File Offset: 0x00033A1A
		public Expression IfFalse
		{
			get
			{
				return this.GetFalse();
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00035822 File Offset: 0x00033A22
		internal virtual Expression GetFalse()
		{
			return Utils.Empty;
		}

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
		// Token: 0x06000FB6 RID: 4022 RVA: 0x00035829 File Offset: 0x00033A29
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitConditional(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, то возвращается это выражение
		///       </summary>
		/// <param name="test">
		///           <see cref="P:System.Linq.Expressions.ConditionalExpression.Test" /> Свойства результата.
		///         </param>
		/// <param name="ifTrue">
		///           <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue" /> Свойства результата.
		///         </param>
		/// <param name="ifFalse">
		///           <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Это выражение, если дочерние элементы не изменились, либо выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00035832 File Offset: 0x00033A32
		public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
		{
			if (test == this.Test && ifTrue == this.IfTrue && ifFalse == this.IfFalse)
			{
				return this;
			}
			return Expression.Condition(test, ifTrue, ifFalse, this.Type);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0000235B File Offset: 0x0000055B
		internal ConditionalExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
