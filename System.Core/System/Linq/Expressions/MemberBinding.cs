using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Предоставляет базовый класс, производными от которого являются классы, представляющие привязки для использования в инициализации членов вновь создаваемых объектов.
	///       </summary>
	// Token: 0x02000277 RID: 631
	public abstract class MemberBinding
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Linq.Expressions.MemberBinding" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Linq.Expressions.MemberBindingType" /> Исключает тип привязки, который представлен.
		///         </param>
		/// <param name="member">
		///           <see cref="T:System.Reflection.MemberInfo" /> Представляющий поле или свойство для инициализации.
		///         </param>
		// Token: 0x06001266 RID: 4710 RVA: 0x0003B57E File Offset: 0x0003977E
		[Obsolete("Do not use this constructor. It will be removed in future releases.")]
		protected MemberBinding(MemberBindingType type, MemberInfo member)
		{
			this.BindingType = type;
			this.Member = member;
		}

		/// <summary>
		///         Возвращает тип привязки, который представлен.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Linq.Expressions.MemberBindingType" />.
		///       </returns>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0003B594 File Offset: 0x00039794
		public MemberBindingType BindingType { get; }

		/// <summary>
		///         Возвращает поле или свойство для инициализации.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Reflection.MemberInfo" /> Представляющий поле или свойство для инициализации.
		///       </returns>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0003B59C File Offset: 0x0003979C
		public MemberInfo Member { get; }

		/// <summary>
		///         Возвращает текстовое представление текущего объекта <see cref="T:System.Linq.Expressions.MemberBinding" />.
		///       </summary>
		/// <returns>
		///         Текстовое представление выражения <see cref="T:System.Linq.Expressions.MemberBinding" />.
		///       </returns>
		// Token: 0x06001269 RID: 4713 RVA: 0x0003B5A4 File Offset: 0x000397A4
		public override string ToString()
		{
			return ExpressionStringBuilder.MemberBindingToString(this);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0003B5AC File Offset: 0x000397AC
		internal virtual void ValidateAsDefinedHere(int index)
		{
			throw Error.UnknownBindingType(index);
		}
	}
}
