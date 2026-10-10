using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет безусловный переход.
	///          Сюда входят операторы возврата, прерывания и продолжения выполнения, а также другие переходы.
	///       </summary>
	// Token: 0x0200025C RID: 604
	[DebuggerTypeProxy(typeof(Expression.GotoExpressionProxy))]
	public sealed class GotoExpression : Expression
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x0003A875 File Offset: 0x00038A75
		internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
			this.Kind = kind;
			this.Value = value;
			this.Target = target;
			this.Type = type;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.GotoExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0003A89A File Offset: 0x00038A9A
		public sealed override Type Type { get; }

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0003A8A2 File Offset: 0x00038AA2
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Goto;
			}
		}

		/// <summary>
		///         Значение, передаваемое в целевой объект или значение null, если целевой тип — System.Void.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий значение передается в целевой или значение null.
		///       </returns>
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0003A8A6 File Offset: 0x00038AA6
		public Expression Value { get; }

		/// <summary>
		///         Целевая метка, где перейти из данного узла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Объект, представляющий целевой метку для данного узла.
		///       </returns>
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0003A8AE File Offset: 0x00038AAE
		public LabelTarget Target { get; }

		/// <summary>
		///         Тип выражения «перейти к».
		///          Служит только в информационных целях.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.GotoExpressionKind" /> Объект, представляющий тип выражения «перейти к».
		///       </returns>
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0003A8B6 File Offset: 0x00038AB6
		public GotoExpressionKind Kind { get; }

		// Token: 0x060011B5 RID: 4533 RVA: 0x0003A8BE File Offset: 0x00038ABE
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitGoto(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="target">
		///           <see cref="P:System.Linq.Expressions.GotoExpression.Target" /> Свойства результата.
		///         </param>
		/// <param name="value">
		///           <see cref="P:System.Linq.Expressions.GotoExpression.Value" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060011B6 RID: 4534 RVA: 0x0003A8C7 File Offset: 0x00038AC7
		public GotoExpression Update(LabelTarget target, Expression value)
		{
			if (target == this.Target && value == this.Value)
			{
				return this;
			}
			return Expression.MakeGoto(this.Kind, target, value, this.Type);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000235B File Offset: 0x0000055B
		internal GotoExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
