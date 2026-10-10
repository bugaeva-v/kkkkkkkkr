using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Выражение, предоставляющее разрешение выполнения чтения и записи для переменных.
	///       </summary>
	// Token: 0x02000295 RID: 661
	[DebuggerTypeProxy(typeof(Expression.RuntimeVariablesExpressionProxy))]
	public sealed class RuntimeVariablesExpression : Expression
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x0003C75A File Offset: 0x0003A95A
		internal RuntimeVariablesExpression(ReadOnlyCollection<ParameterExpression> variables)
		{
			this.Variables = variables;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0003C769 File Offset: 0x0003A969
		public sealed override Type Type
		{
			get
			{
				return typeof(IRuntimeVariables);
			}
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x0003C775 File Offset: 0x0003A975
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.RuntimeVariables;
			}
		}

		/// <summary>
		///         Переменные или параметры, к которым среда выполнения предоставляет доступ.
		///       </summary>
		/// <returns>
		///         Только для чтения коллекция, содержащая параметры, которые будут предоставляться доступ среды выполнения.
		///       </returns>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0003C779 File Offset: 0x0003A979
		public ReadOnlyCollection<ParameterExpression> Variables { get; }

		// Token: 0x06001317 RID: 4887 RVA: 0x0003C781 File Offset: 0x0003A981
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitRuntimeVariables(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="variables">
		///           <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Variables" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001318 RID: 4888 RVA: 0x0003C78A File Offset: 0x0003A98A
		public RuntimeVariablesExpression Update(IEnumerable<ParameterExpression> variables)
		{
			if (variables != null && ExpressionUtils.SameElements<ParameterExpression>(ref variables, this.Variables))
			{
				return this;
			}
			return Expression.RuntimeVariables(variables);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0000235B File Offset: 0x0000055B
		internal RuntimeVariablesExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
