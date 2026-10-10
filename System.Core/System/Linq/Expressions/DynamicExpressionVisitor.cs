using System;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет посетителя или модуль записи для деревьев динамических выражений.
	///       </summary>
	// Token: 0x02000255 RID: 597
	public class DynamicExpressionVisitor : ExpressionVisitor
	{
		/// <summary>
		///         Просматривает дочерний <see cref="T:System.Linq.Expressions.DynamicExpression" />.
		///       </summary>
		/// <param name="node">
		///           Выражение для посещения.
		///         </param>
		/// <returns>
		///         Возвращает <see cref="T:System.Linq.Expressions.Expression" />, измененные выражение, если изменяется или любого его подвыражения; в противном случае — возвращает исходное выражение.
		///       </returns>
		// Token: 0x06001088 RID: 4232 RVA: 0x00038308 File Offset: 0x00036508
		protected internal override Expression VisitDynamic(DynamicExpression node)
		{
			Expression[] array = ExpressionVisitorUtils.VisitArguments(this, node);
			if (array == null)
			{
				return node;
			}
			return node.Rewrite(array);
		}
	}
}
