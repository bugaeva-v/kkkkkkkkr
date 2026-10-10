using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет вызов конструктора, обладающий инициализатором коллекции.
	///       </summary>
	// Token: 0x02000273 RID: 627
	[DebuggerTypeProxy(typeof(Expression.ListInitExpressionProxy))]
	public sealed class ListInitExpression : Expression
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x0003B445 File Offset: 0x00039645
		internal ListInitExpression(NewExpression newExpression, ReadOnlyCollection<ElementInit> initializers)
		{
			this.NewExpression = newExpression;
			this.Initializers = initializers;
		}

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x0003B45B File Offset: 0x0003965B
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.ListInit;
			}
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.ListInitExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0003B45F File Offset: 0x0003965F
		public sealed override Type Type
		{
			get
			{
				return this.NewExpression.Type;
			}
		}

		/// <summary>
		///         Возвращает значение, которое указывает, можно ли сократить узел дерева выражений.
		///       </summary>
		/// <returns>
		///         Значение true, если узел можно сократить; в противном случае — значение false.
		///       </returns>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00007E1D File Offset: 0x0000601D
		public override bool CanReduce
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает выражение, содержащее вызов в конструктор типа коллекции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.NewExpression" /> представляющий вызов конструктора типа коллекции.
		///       </returns>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0003B46C File Offset: 0x0003966C
		public NewExpression NewExpression { get; }

		/// <summary>
		///         Инициализаторы элементов, которые используются для инициализации коллекции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.ElementInit" /> объектов, которые представляют элементы, которые используются для инициализации коллекции.
		///       </returns>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0003B474 File Offset: 0x00039674
		public ReadOnlyCollection<ElementInit> Initializers { get; }

		// Token: 0x06001254 RID: 4692 RVA: 0x0003B47C File Offset: 0x0003967C
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitListInit(this);
		}

		/// <summary>
		///         Сокращает узел двоичных выражений до более простого выражения.
		///       </summary>
		/// <returns>
		///         Преобразованное выражение.
		///       </returns>
		// Token: 0x06001255 RID: 4693 RVA: 0x0003B485 File Offset: 0x00039685
		public override Expression Reduce()
		{
			return MemberInitExpression.ReduceListInit(this.NewExpression, this.Initializers, true);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="newExpression">
		///           <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression" /> Свойства результата.
		///         </param>
		/// <param name="initializers">
		///           <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001256 RID: 4694 RVA: 0x0003B499 File Offset: 0x00039699
		public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers)
		{
			if ((newExpression == this.NewExpression & initializers != null) && ExpressionUtils.SameElements<ElementInit>(ref initializers, this.Initializers))
			{
				return this;
			}
			return Expression.ListInit(newExpression, initializers);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0000235B File Offset: 0x0000055B
		internal ListInitExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
