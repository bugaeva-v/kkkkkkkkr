using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет выражение элемента управления, которое обрабатывает множественный выбор, передачей управления <see cref="T:System.Linq.Expressions.SwitchCase" />.
	///       </summary>
	// Token: 0x0200029D RID: 669
	[DebuggerTypeProxy(typeof(Expression.SwitchExpressionProxy))]
	public sealed class SwitchExpression : Expression
	{
		// Token: 0x060013DB RID: 5083 RVA: 0x0003D139 File Offset: 0x0003B339
		internal SwitchExpression(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, ReadOnlyCollection<SwitchCase> cases)
		{
			this.Type = type;
			this.SwitchValue = switchValue;
			this.DefaultBody = defaultBody;
			this.Comparison = comparison;
			this.Cases = cases;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.SwitchExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0003D166 File Offset: 0x0003B366
		public sealed override Type Type { get; }

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0003D16E File Offset: 0x0003B36E
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Switch;
			}
		}

		/// <summary>
		///         Возвращает тест для коммутатора.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий теста для коммутатора.
		///       </returns>
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0003D172 File Offset: 0x0003B372
		public Expression SwitchValue { get; }

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Linq.Expressions.SwitchCase" /> объектов для коммутатора.
		///       </summary>
		/// <returns>
		///         Коллекция объектов <see cref="T:System.Linq.Expressions.SwitchCase" />.
		///       </returns>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0003D17A File Offset: 0x0003B37A
		public ReadOnlyCollection<SwitchCase> Cases { get; }

		/// <summary>
		///         Возвращает тест для коммутатора.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Объект, представляющий теста для коммутатора.
		///       </returns>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0003D182 File Offset: 0x0003B382
		public Expression DefaultBody { get; }

		/// <summary>
		///         Получает метод проверки равенства, если таковые имеются.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Reflection.MethodInfo" /> Объект, представляющий метод проверки равенства.
		///       </returns>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0003D18A File Offset: 0x0003B38A
		public MethodInfo Comparison { get; }

		// Token: 0x060013E2 RID: 5090 RVA: 0x0003D192 File Offset: 0x0003B392
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitSwitch(this);
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0003D19C File Offset: 0x0003B39C
		internal bool IsLifted
		{
			get
			{
				return this.SwitchValue.Type.IsNullableType() && (this.Comparison == null || !TypeUtils.AreEquivalent(this.SwitchValue.Type, this.Comparison.GetParametersCached()[0].ParameterType.GetNonRefType()));
			}
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="switchValue">
		///           <see cref="P:System.Linq.Expressions.SwitchExpression.SwitchValue" /> Свойства результата.
		///         </param>
		/// <param name="cases">
		///           <see cref="P:System.Linq.Expressions.SwitchExpression.Cases" /> Свойства результата.
		///         </param>
		/// <param name="defaultBody">
		///           <see cref="P:System.Linq.Expressions.SwitchExpression.DefaultBody" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x060013E4 RID: 5092 RVA: 0x0003D1F8 File Offset: 0x0003B3F8
		public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody)
		{
			if ((switchValue == this.SwitchValue & defaultBody == this.DefaultBody & cases != null) && ExpressionUtils.SameElements<SwitchCase>(ref cases, this.Cases))
			{
				return this;
			}
			return Expression.Switch(this.Type, switchValue, defaultBody, this.Comparison, cases);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0000235B File Offset: 0x0000055B
		internal SwitchExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
