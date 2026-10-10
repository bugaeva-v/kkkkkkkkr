using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;
using Unity;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Представляет инициализацию элементов члена вновь созданного объекта.
	///       </summary>
	// Token: 0x0200027D RID: 637
	public sealed class MemberMemberBinding : MemberBinding
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x0003B8AF File Offset: 0x00039AAF
		internal MemberMemberBinding(MemberInfo member, ReadOnlyCollection<MemberBinding> bindings) : base(MemberBindingType.MemberBinding, member)
		{
			this.Bindings = bindings;
		}

		/// <summary>
		///         Получает привязки, описывающие способы инициализации элементов элемента.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> из <see cref="T:System.Linq.Expressions.MemberBinding" /> объекты, описывающие способы инициализации элементов элемента.
		///       </returns>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0003B8C0 File Offset: 0x00039AC0
		public ReadOnlyCollection<MemberBinding> Bindings { get; }

		/// <summary>
		///         Создает новое выражение, аналогичное данному, но с использованием предоставленного дочернего элемента.
		///          Если все дочерние элементы совпадают, возвращается данное выражение.
		///       </summary>
		/// <param name="bindings">
		///           <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings" /> Свойства результата.
		///         </param>
		/// <returns>
		///         Данное выражение, если никакие дочерние элементы не изменялись, или выражение с обновленными дочерними элементами.
		///       </returns>
		// Token: 0x06001290 RID: 4752 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings)
		{
			if (bindings != null && ExpressionUtils.SameElements<MemberBinding>(ref bindings, this.Bindings))
			{
				return this;
			}
			return Expression.MemberBind(base.Member, bindings);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00003A59 File Offset: 0x00001C59
		internal override void ValidateAsDefinedHere(int index)
		{
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000235B File Offset: 0x0000055B
		internal MemberMemberBinding()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
