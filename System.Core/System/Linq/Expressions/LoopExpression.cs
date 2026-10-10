using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет бесконечный цикл.
	///          Он может завершаться прерыванием.
	///       </summary>
	// Token: 0x02000274 RID: 628
	[DebuggerTypeProxy(typeof(Expression.LoopExpressionProxy))]
	public sealed class LoopExpression : Expression
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x0003B4C3 File Offset: 0x000396C3
		internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
		{
			this.Body = body;
			this.BreakLabel = @break;
			this.ContinueLabel = @continue;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.LoopExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0003B4E0 File Offset: 0x000396E0
		public sealed override Type Type
		{
			get
			{
				if (this.BreakLabel != null)
				{
					return this.BreakLabel.Type;
				}
				return typeof(void);
			}
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0003B500 File Offset: 0x00039700
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Loop;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" /> именно тело цикла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Именно тело цикла.
		///       </returns>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0003B504 File Offset: 0x00039704
		public Expression Body { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.LabelTarget" /> используемый в теле цикла как цель оператора break.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Используемая телом цикла как цель оператора break.
		///       </returns>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0003B50C File Offset: 0x0003970C
		public LabelTarget BreakLabel { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.LabelTarget" /> используемая телом цикла в качестве цель оператора continue.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Используемая телом цикла в качестве цель оператора continue.
		///       </returns>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0003B514 File Offset: 0x00039714
		public LabelTarget ContinueLabel { get; }

		// Token: 0x0600125E RID: 4702 RVA: 0x0003B51C File Offset: 0x0003971C
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLoop(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="breakLabel">
		///           <see cref="P:System.Linq.Expressions.LoopExpression.BreakLabel" /> Свойства результата.
		///         </param>
		/// <param name="continueLabel">
		///           <see cref="P:System.Linq.Expressions.LoopExpression.ContinueLabel" /> Свойства результата.
		///         </param>
		/// <param name="body">
		///           <see cref="P:System.Linq.Expressions.LoopExpression.Body" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x0600125F RID: 4703 RVA: 0x0003B525 File Offset: 0x00039725
		public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
		{
			if (breakLabel == this.BreakLabel && continueLabel == this.ContinueLabel && body == this.Body)
			{
				return this;
			}
			return Expression.Loop(body, breakLabel, continueLabel);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000235B File Offset: 0x0000055B
		internal LoopExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
