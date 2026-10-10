using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет вызов конструктора и инициализацию одного или нескольких членов нового объекта.
	///       </summary>
	// Token: 0x0200027B RID: 635
	[DebuggerTypeProxy(typeof(Expression.MemberInitExpressionProxy))]
	public sealed class MemberInitExpression : Expression
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x0003B689 File Offset: 0x00039889
		internal MemberInitExpression(NewExpression newExpression, ReadOnlyCollection<MemberBinding> bindings)
		{
			this.NewExpression = newExpression;
			this.Bindings = bindings;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.MemberInitExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x0003B69F File Offset: 0x0003989F
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
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00007E1D File Offset: 0x0000601D
		public override bool CanReduce
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает тип узла данного выражения.
		///          Узлы расширения должны возвращать <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> при переопределении этого метода.
		///       </summary>
		/// <returns>
		///         Тип <see cref="T:System.Linq.Expressions.ExpressionType" /> выражения.
		///       </returns>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0003B6AC File Offset: 0x000398AC
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.MemberInit;
			}
		}

		/// <summary>
		///         Возвращает выражение, представляющее вызов конструктора.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.NewExpression" /> представляющий вызов конструктора.
		///       </returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0003B6B0 File Offset: 0x000398B0
		public NewExpression NewExpression { get; }

		/// <summary>
		///         Получает привязки, описывающие способы инициализации членов вновь созданный объект.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.MemberBinding" /> объекты, описывающие способы инициализации членов.
		///       </returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0003B6B8 File Offset: 0x000398B8
		public ReadOnlyCollection<MemberBinding> Bindings { get; }

		// Token: 0x06001282 RID: 4738 RVA: 0x0003B6C0 File Offset: 0x000398C0
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitMemberInit(this);
		}

		/// <summary>
		///         Уменьшает <see cref="T:System.Linq.Expressions.MemberInitExpression" /> до более простого выражения.
		///       </summary>
		/// <returns>
		///         Преобразованное выражение.
		///       </returns>
		// Token: 0x06001283 RID: 4739 RVA: 0x0003B6C9 File Offset: 0x000398C9
		public override Expression Reduce()
		{
			return MemberInitExpression.ReduceMemberInit(this.NewExpression, this.Bindings, true);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0003B6E0 File Offset: 0x000398E0
		private static Expression ReduceMemberInit(Expression objExpression, ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack)
		{
			ParameterExpression parameterExpression = Expression.Variable(objExpression.Type);
			int count = bindings.Count;
			Expression[] array = new Expression[count + 2];
			array[0] = Expression.Assign(parameterExpression, objExpression);
			for (int i = 0; i < count; i++)
			{
				array[i + 1] = MemberInitExpression.ReduceMemberBinding(parameterExpression, bindings[i]);
			}
			array[count + 1] = (keepOnStack ? parameterExpression : Utils.Empty);
			return Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, array);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0003B754 File Offset: 0x00039954
		internal static Expression ReduceListInit(Expression listExpression, ReadOnlyCollection<ElementInit> initializers, bool keepOnStack)
		{
			ParameterExpression parameterExpression = Expression.Variable(listExpression.Type);
			int count = initializers.Count;
			Expression[] array = new Expression[count + 2];
			array[0] = Expression.Assign(parameterExpression, listExpression);
			for (int i = 0; i < count; i++)
			{
				ElementInit elementInit = initializers[i];
				array[i + 1] = Expression.Call(parameterExpression, elementInit.AddMethod, elementInit.Arguments);
			}
			array[count + 1] = (keepOnStack ? parameterExpression : Utils.Empty);
			return Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, array);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0003B7D8 File Offset: 0x000399D8
		internal static Expression ReduceMemberBinding(ParameterExpression objVar, MemberBinding binding)
		{
			MemberExpression memberExpression = Expression.MakeMemberAccess(objVar, binding.Member);
			switch (binding.BindingType)
			{
			case MemberBindingType.Assignment:
				return Expression.Assign(memberExpression, ((MemberAssignment)binding).Expression);
			case MemberBindingType.MemberBinding:
				return MemberInitExpression.ReduceMemberInit(memberExpression, ((MemberMemberBinding)binding).Bindings, false);
			case MemberBindingType.ListBinding:
				return MemberInitExpression.ReduceListInit(memberExpression, ((MemberListBinding)binding).Initializers, false);
			default:
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="newExpression">
		///           <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression" /> Свойства результата.
		///         </param>
		/// <param name="bindings">
		///           <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001287 RID: 4743 RVA: 0x0003B84A File Offset: 0x00039A4A
		public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
		{
			if ((newExpression == this.NewExpression & bindings != null) && ExpressionUtils.SameElements<MemberBinding>(ref bindings, this.Bindings))
			{
				return this;
			}
			return Expression.MemberInit(newExpression, bindings);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0000235B File Offset: 0x0000055B
		internal MemberInitExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
