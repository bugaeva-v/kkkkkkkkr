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
	///         Представляет вызов конструктора.
	///       </summary>
	// Token: 0x0200028F RID: 655
	[DebuggerTypeProxy(typeof(Expression.NewExpressionProxy))]
	public class NewExpression : Expression, IArgumentProvider
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x0003C504 File Offset: 0x0003A704
		internal NewExpression(ConstructorInfo constructor, IReadOnlyList<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
		{
			this.Constructor = constructor;
			this._arguments = arguments;
			this.Members = members;
		}

		/// <summary>
		///         Получает статичный тип выражения, представленного этим выражением <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Тип <see cref="P:System.Linq.Expressions.NewExpression.Type" />, представляющий этот статичный тип выражения.
		///       </returns>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0003C521 File Offset: 0x0003A721
		public override Type Type
		{
			get
			{
				return this.Constructor.DeclaringType;
			}
		}

		/// <summary>
		///         Возвращает тип узла данного <see cref="T:System.Linq.Expressions.Expression" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Linq.Expressions.ExpressionType" />, представляющий данное выражение.
		///       </returns>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0003C52E File Offset: 0x0003A72E
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.New;
			}
		}

		/// <summary>
		///         Получает вызванный конструктор.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий вызываемый конструктор.
		///       </returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x0003C532 File Offset: 0x0003A732
		public ConstructorInfo Constructor { get; }

		/// <summary>
		///         Получает аргументы для конструктора.
		///       </summary>
		/// <returns>
		///         Коллекция объектов <see cref="T:System.Linq.Expressions.Expression" />, представляющая аргументы для конструктора.
		///       </returns>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0003C53A File Offset: 0x0003A73A
		public ReadOnlyCollection<Expression> Arguments
		{
			get
			{
				return ExpressionUtils.ReturnReadOnly<Expression>(ref this._arguments);
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0003C547 File Offset: 0x0003A747
		public Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0003C555 File Offset: 0x0003A755
		public int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		/// <summary>
		///         Получает члены, которые могут извлечь значения полей, инициализированных с помощью аргументов конструктора.
		///       </summary>
		/// <returns>
		///         Коллекция объектов <see cref="T:System.Reflection.MemberInfo" />, представляющих члены, которые могут извлечь значения полей, инициализированных с помощью аргументов конструктора.
		///       </returns>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0003C562 File Offset: 0x0003A762
		public ReadOnlyCollection<MemberInfo> Members { get; }

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
		// Token: 0x060012FF RID: 4863 RVA: 0x0003C56A File Offset: 0x0003A76A
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitNew(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="arguments">
		///           Свойство <see cref="P:System.Linq.Expressions.NewExpression.Arguments" /> результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001300 RID: 4864 RVA: 0x0003C573 File Offset: 0x0003A773
		public NewExpression Update(IEnumerable<Expression> arguments)
		{
			if (ExpressionUtils.SameElements<Expression>(ref arguments, this.Arguments))
			{
				return this;
			}
			if (this.Members == null)
			{
				return Expression.New(this.Constructor, arguments);
			}
			return Expression.New(this.Constructor, arguments, this.Members);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0000235B File Offset: 0x0000055B
		internal NewExpression()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A45 RID: 2629
		private IReadOnlyList<Expression> _arguments;
	}
}
