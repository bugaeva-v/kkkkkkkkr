using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Представляет условие членства, которому соответствует любой код. Этот класс не наследуется.</summary>
	// Token: 0x020003FE RID: 1022
	[ComVisible(true)]
	[Serializable]
	public sealed class AllMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Всегда <see langword="true" />.</returns>
		// Token: 0x060029C7 RID: 10695 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool Check(Evidence evidence)
		{
			return true;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		// Token: 0x060029C8 RID: 10696 RVA: 0x00097E5B File Offset: 0x0009605B
		public IMembershipCondition Copy()
		{
			return new AllMembershipCondition();
		}

		/// <summary>Определяет, является ли указанное условие членства экземпляром класса <see cref="T:System.Security.Policy.AllMembershipCondition" />.</summary>
		/// <param name="o">Объект, который необходимо сравнить с объектом <see cref="T:System.Security.Policy.AllMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если указанное условие членства является экземпляром <see cref="T:System.Security.Policy.AllMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060029C9 RID: 10697 RVA: 0x00097E62 File Offset: 0x00096062
		public override bool Equals(object o)
		{
			return o is AllMembershipCondition;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x060029CA RID: 10698 RVA: 0x00097E6D File Offset: 0x0009606D
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для разрешения ссылок на именованные наборы разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x060029CB RID: 10699 RVA: 0x00097E77 File Offset: 0x00096077
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		// Token: 0x060029CC RID: 10700 RVA: 0x00097E91 File Offset: 0x00096091
		public override int GetHashCode()
		{
			return typeof(AllMembershipCondition).GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Представление условия членства.</returns>
		// Token: 0x060029CD RID: 10701 RVA: 0x00097EA2 File Offset: 0x000960A2
		public override string ToString()
		{
			return "All code";
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060029CE RID: 10702 RVA: 0x00097EA9 File Offset: 0x000960A9
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст уровня политики для разрешения ссылок на именованные наборы разрешений.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060029CF RID: 10703 RVA: 0x00097EB2 File Offset: 0x000960B2
		public SecurityElement ToXml(PolicyLevel level)
		{
			return MembershipConditionHelper.Element(typeof(AllMembershipCondition), this.version);
		}

		// Token: 0x04001F52 RID: 8018
		private readonly int version = 1;
	}
}
