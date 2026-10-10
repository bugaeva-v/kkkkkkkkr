using System;
using System.Diagnostics;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет выражение, имеющее постоянное значение.
	///       </summary>
	// Token: 0x02000241 RID: 577
	[DebuggerTypeProxy(typeof(Expression.ConstantExpressionProxy))]
	public class ConstantExpression : Expression
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x00035893 File Offset: 0x00033A93
		internal ConstantExpression(object value)
		{
			this.Value = value;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.ConstantExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000358A2 File Offset: 0x00033AA2
		public override Type Type
		{
			get
			{
				if (this.Value == null)
				{
					return typeof(object);
				}
				return this.Value.GetType();
			}
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000358C2 File Offset: 0x00033AC2
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Constant;
			}
		}

		/// <summary>
		///         Возвращает значение константного выражения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Object" /> Равно значению, представленный выражения.
		///       </returns>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000358C6 File Offset: 0x00033AC6
		public object Value { get; }

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
		// Token: 0x06000FC1 RID: 4033 RVA: 0x000358CE File Offset: 0x00033ACE
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitConstant(this);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0000235B File Offset: 0x0000055B
		internal ConstantExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
