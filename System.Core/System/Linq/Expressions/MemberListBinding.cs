using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет инициализацию элементов члена коллекции вновь созданного объекта.
	///       </summary>
	// Token: 0x0200027C RID: 636
	public sealed class MemberListBinding : MemberBinding
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x0003B874 File Offset: 0x00039A74
		internal MemberListBinding(MemberInfo member, ReadOnlyCollection<ElementInit> initializers) : base(MemberBindingType.ListBinding, member)
		{
			this.Initializers = initializers;
		}

		/// <summary>
		///         Инициализаторы элементов для инициализации коллекции элементов созданного объекта.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.ElementInit" /> объектов для инициализации коллекции элементов с.
		///       </returns>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0003B885 File Offset: 0x00039A85
		public ReadOnlyCollection<ElementInit> Initializers { get; }

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="initializers">
		///           <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x0600128B RID: 4747 RVA: 0x0003B88D File Offset: 0x00039A8D
		public MemberListBinding Update(IEnumerable<ElementInit> initializers)
		{
			if (initializers != null && ExpressionUtils.SameElements<ElementInit>(ref initializers, this.Initializers))
			{
				return this;
			}
			return Expression.ListBind(base.Member, initializers);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00003A59 File Offset: 0x00001C59
		internal override void ValidateAsDefinedHere(int index)
		{
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000235B File Offset: 0x0000055B
		internal MemberListBinding()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
