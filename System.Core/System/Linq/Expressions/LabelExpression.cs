using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет метку, которую можно разместить в любом <see cref="T:System.Linq.Expressions.Expression" /> контекста.
	///          Если выполняется переход, он получит значение, указанное с помощью соответствующих <see cref="T:System.Linq.Expressions.GotoExpression" />.
	///          В противном случае она получает значение в <see cref="P:System.Linq.Expressions.LabelExpression.DefaultValue" />.
	///          Если <see cref="T:System.Type" /> равно System.Void, значение не должно быть указано.
	///       </summary>
	// Token: 0x02000269 RID: 617
	[DebuggerTypeProxy(typeof(Expression.LabelExpressionProxy))]
	public sealed class LabelExpression : Expression
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x0003AE13 File Offset: 0x00039013
		internal LabelExpression(LabelTarget label, Expression defaultValue)
		{
			this.Target = label;
			this.DefaultValue = defaultValue;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.LabelExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0003AE29 File Offset: 0x00039029
		public sealed override Type Type
		{
			get
			{
				return this.Target.Type;
			}
		}

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0003AE36 File Offset: 0x00039036
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Label;
			}
		}

		/// <summary>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Связанный с меткой.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Связанный с меткой.
		///       </returns>
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0003AE3A File Offset: 0x0003903A
		public LabelTarget Target { get; }

		/// <summary>
		///         Значение <see cref="T:System.Linq.Expressions.LabelExpression" /> после достижения метки через стандартный поток управления (например, является не вышла).
		///       </summary>
		/// <returns>
		///         Выражение объект, представляющий значение <see cref="T:System.Linq.Expressions.LabelExpression" />.
		///       </returns>
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0003AE42 File Offset: 0x00039042
		public Expression DefaultValue { get; }

		// Token: 0x06001200 RID: 4608 RVA: 0x0003AE4A File Offset: 0x0003904A
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLabel(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="target">
		///           <see cref="P:System.Linq.Expressions.LabelExpression.Target" /> Свойства результата.
		///         </param>
		/// <param name="defaultValue">
		///           <see cref="P:System.Linq.Expressions.LabelExpression.DefaultValue" /> Свойства результата
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001201 RID: 4609 RVA: 0x0003AE53 File Offset: 0x00039053
		public LabelExpression Update(LabelTarget target, Expression defaultValue)
		{
			if (target == this.Target && defaultValue == this.DefaultValue)
			{
				return this;
			}
			return Expression.Label(target, defaultValue);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000235B File Offset: 0x0000055B
		internal LabelExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
