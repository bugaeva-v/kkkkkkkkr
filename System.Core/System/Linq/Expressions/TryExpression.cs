using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет блок try/catch/finally/fault.
	///       </summary>
	// Token: 0x020002A0 RID: 672
	[DebuggerTypeProxy(typeof(Expression.TryExpressionProxy))]
	public sealed class TryExpression : Expression
	{
		// Token: 0x060013F3 RID: 5107 RVA: 0x0003D342 File Offset: 0x0003B542
		internal TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
		{
			this.Type = type;
			this.Body = body;
			this.Handlers = handlers;
			this.Finally = @finally;
			this.Fault = fault;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.TryExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0003D36F File Offset: 0x0003B56F
		public sealed override Type Type { get; }

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0003D377 File Offset: 0x0003B577
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Try;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" /> представляющий тело блока try.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий тело блока try.
		///       </returns>
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0003D37B File Offset: 0x0003B57B
		public Expression Body { get; }

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Linq.Expressions.CatchBlock" /> выражения, связанный с блоком try.
		///       </summary>
		/// <returns>
		///         Коллекция <see cref="T:System.Linq.Expressions.CatchBlock" /> выражения, связанный с блоком try.
		///       </returns>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0003D383 File Offset: 0x0003B583
		public ReadOnlyCollection<CatchBlock> Handlers { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" /> представляет блок finally.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляет блок finally.
		///       </returns>
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0003D38B File Offset: 0x0003B58B
		public Expression Finally { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" /> представляет блок fault.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляет блок fault.
		///       </returns>
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0003D393 File Offset: 0x0003B593
		public Expression Fault { get; }

		// Token: 0x060013FA RID: 5114 RVA: 0x0003D39B File Offset: 0x0003B59B
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitTry(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="body">
		///           <see cref="P:System.Linq.Expressions.TryExpression.Body" /> Свойства результата.
		///         </param>
		/// <param name="handlers">
		///           <see cref="P:System.Linq.Expressions.TryExpression.Handlers" /> Свойства результата.
		///         </param>
		/// <param name="finally">
		///           <see cref="P:System.Linq.Expressions.TryExpression.Finally" /> Свойства результата.
		///         </param>
		/// <param name="fault">
		///           <see cref="P:System.Linq.Expressions.TryExpression.Fault" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060013FB RID: 5115 RVA: 0x0003D3A4 File Offset: 0x0003B5A4
		public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
		{
			if ((body == this.Body & @finally == this.Finally & fault == this.Fault) && ExpressionUtils.SameElements<CatchBlock>(ref handlers, this.Handlers))
			{
				return this;
			}
			return Expression.MakeTry(this.Type, body, @finally, fault, handlers);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0000235B File Offset: 0x0000055B
		internal TryExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
