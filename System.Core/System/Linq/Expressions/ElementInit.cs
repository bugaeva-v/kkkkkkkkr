using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет инициализатор для единичного элемента коллекции <see cref="T:System.Collections.IEnumerable" />.
	///       </summary>
	// Token: 0x02000256 RID: 598
	public sealed class ElementInit : IArgumentProvider
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x00038329 File Offset: 0x00036529
		internal ElementInit(MethodInfo addMethod, ReadOnlyCollection<Expression> arguments)
		{
			this.AddMethod = addMethod;
			this.Arguments = arguments;
		}

		/// <summary>
		///         Получает метод экземпляра, который используется для добавления элемента в коллекцию <see cref="T:System.Collections.IEnumerable" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод экземпляра, который добавляет элемент в коллекцию.
		///       </returns>
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0003833F File Offset: 0x0003653F
		public MethodInfo AddMethod { get; }

		/// <summary>
		///         Получает коллекцию аргументов, передаваемых в метод, который добавляет элемент в коллекцию <see cref="T:System.Collections.IEnumerable" />.
		///       </summary>
		/// <returns>
		///         Коллекция <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> объектов <see cref="T:System.Linq.Expressions.Expression" />, представляющих аргументы для метода, который добавляет элемент в коллекцию.
		///       </returns>
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00038347 File Offset: 0x00036547
		public ReadOnlyCollection<Expression> Arguments { get; }

		// Token: 0x0600108D RID: 4237 RVA: 0x0003834F File Offset: 0x0003654F
		public Expression GetArgument(int index)
		{
			return this.Arguments[index];
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0003835D File Offset: 0x0003655D
		public int ArgumentCount
		{
			get
			{
				return this.Arguments.Count;
			}
		}

		/// <summary>
		///         Возвращает текстовое представление объекта <see cref="T:System.Linq.Expressions.ElementInit" />.
		///       </summary>
		/// <returns>
		///         Текстовое представление объекта <see cref="T:System.Linq.Expressions.ElementInit" />.
		///       </returns>
		// Token: 0x0600108F RID: 4239 RVA: 0x0003836A File Offset: 0x0003656A
		public override string ToString()
		{
			return ExpressionStringBuilder.ElementInitBindingToString(this);
		}

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="arguments">
		///           Свойство <see cref="P:System.Linq.Expressions.ElementInit.Arguments" /> результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001090 RID: 4240 RVA: 0x00038372 File Offset: 0x00036572
		public ElementInit Update(IEnumerable<Expression> arguments)
		{
			if (arguments == this.Arguments)
			{
				return this;
			}
			return Expression.ElementInit(this.AddMethod, arguments);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0000235B File Offset: 0x0000055B
		internal ElementInit()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
