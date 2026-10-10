using System;
using System.Reflection;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет операцию присваивания для поля или свойства объекта.
	///       </summary>
	// Token: 0x02000275 RID: 629
	public sealed class MemberAssignment : MemberBinding
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0003B54C File Offset: 0x0003974C
		internal MemberAssignment(MemberInfo member, Expression expression) : base(MemberBindingType.Assignment, member)
		{
			this._expression = expression;
		}

		/// <summary>
		///         Возвращает выражение для назначения полю или свойству.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.Expression" /> Представляющий значение, присваиваемое полю или свойству.
		///       </returns>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x0003B55D File Offset: 0x0003975D
		public Expression Expression
		{
			get
			{
				return this._expression;
			}
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="expression">
		///           <see cref="P:System.Linq.Expressions.MemberAssignment.Expression" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001263 RID: 4707 RVA: 0x0003B565 File Offset: 0x00039765
		public MemberAssignment Update(Expression expression)
		{
			if (expression == this.Expression)
			{
				return this;
			}
			return Expression.Bind(base.Member, expression);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00003A59 File Offset: 0x00001C59
		internal override void ValidateAsDefinedHere(int index)
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0000235B File Offset: 0x0000055B
		internal MemberAssignment()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A1C RID: 2588
		private readonly Expression _expression;
	}
}
