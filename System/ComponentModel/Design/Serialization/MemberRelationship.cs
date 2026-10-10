using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Представляет одиночную связь между объектом и элементом.</summary>
	// Token: 0x0200048F RID: 1167
	public readonly struct MemberRelationship
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</summary>
		/// <param name="owner">Объект, являющийся владельцем элемента <paramref name="member" />.</param>
		/// <param name="member">Элемент, связанный с владельцем <paramref name="owner" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="owner" /> или <paramref name="member" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002546 RID: 9542 RVA: 0x0008318E File Offset: 0x0008138E
		public MemberRelationship(object owner, MemberDescriptor member)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			if (member == null)
			{
				throw new ArgumentNullException("member");
			}
			this.Owner = owner;
			this.Member = member;
		}

		/// <summary>Возвращает значение, указывающее, соответствует ли эта связь связи <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" />.</summary>
		/// <returns>Значение <see langword="true" />, если эта связь соответствует связи <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000831BA File Offset: 0x000813BA
		public bool IsEmpty
		{
			get
			{
				return this.Owner == null;
			}
		}

		/// <summary>Возвращает связанный элемент.</summary>
		/// <returns>Элемент, передаваемый в метод <see cref="M:System.ComponentModel.Design.Serialization.MemberRelationship.#ctor(System.Object,System.ComponentModel.MemberDescriptor)" />.</returns>
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000831C5 File Offset: 0x000813C5
		public MemberDescriptor Member { get; }

		/// <summary>Возвращает владеющий объект.</summary>
		/// <returns>Владеющий объект, передаваемый в метод <see cref="M:System.ComponentModel.Design.Serialization.MemberRelationship.#ctor(System.Object,System.ComponentModel.MemberDescriptor)" />.</returns>
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000831CD File Offset: 0x000813CD
		public object Owner { get; }

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, с которым сравнивается текущий объект <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> равен текущему объекту <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600254A RID: 9546 RVA: 0x000831D8 File Offset: 0x000813D8
		public override bool Equals(object obj)
		{
			if (!(obj is MemberRelationship))
			{
				return false;
			}
			MemberRelationship memberRelationship = (MemberRelationship)obj;
			return memberRelationship.Owner == this.Owner && memberRelationship.Member == this.Member;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</returns>
		// Token: 0x0600254B RID: 9547 RVA: 0x00083216 File Offset: 0x00081416
		public override int GetHashCode()
		{
			if (this.Owner == null)
			{
				return base.GetHashCode();
			}
			return this.Owner.GetHashCode() ^ this.Member.GetHashCode();
		}

		/// <summary>Проверяет эквивалентность двух указанных структур <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</summary>
		/// <param name="left">Структура <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, которая находится справа от оператора равенства.</param>
		/// <returns>Этот оператор возвращает значение <see langword="true" />, если две структуры <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600254C RID: 9548 RVA: 0x00083248 File Offset: 0x00081448
		public static bool operator ==(MemberRelationship left, MemberRelationship right)
		{
			return left.Owner == right.Owner && left.Member == right.Member;
		}

		/// <summary>Проверяет различие двух указанных структур <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />.</summary>
		/// <param name="left">Структура <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Этот оператор возвращает значение <see langword="true" />, если две структуры <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" /> различны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600254D RID: 9549 RVA: 0x0008326C File Offset: 0x0008146C
		public static bool operator !=(MemberRelationship left, MemberRelationship right)
		{
			return !(left == right);
		}

		/// <summary>Представляет связь пустого элемента. Это поле доступно только для чтения.</summary>
		// Token: 0x0400149E RID: 5278
		public static readonly MemberRelationship Empty;
	}
}
