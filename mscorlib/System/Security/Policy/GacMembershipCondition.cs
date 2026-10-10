using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки ее членства в глобальном кэше сборок. Этот класс не наследуется.</summary>
	// Token: 0x02000411 RID: 1041
	[ComVisible(true)]
	[Serializable]
	public sealed class GacMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		/// <summary>Указывает, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Свидетельство <see cref="T:System.Security.Policy.Evidence" />, для которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A93 RID: 10899 RVA: 0x0009A0E0 File Offset: 0x000982E0
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				if (hostEnumerator.Current is GacInstalled)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новый объект <see cref="T:System.Security.Policy.GacMembershipCondition" />.</returns>
		// Token: 0x06002A94 RID: 10900 RVA: 0x0009A113 File Offset: 0x00098313
		public IMembershipCondition Copy()
		{
			return new GacMembershipCondition();
		}

		/// <summary>Указывает, эквивалентен ли текущий объект заданному объекту.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="o" /> является элементом <see cref="T:System.Security.Policy.GacMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A95 RID: 10901 RVA: 0x0009A11A File Offset: 0x0009831A
		public override bool Equals(object o)
		{
			return o != null && o is GacMembershipCondition;
		}

		/// <summary>Использует заданное XML-кодирование, чтобы восстановить объект безопасности.</summary>
		/// <param name="e">Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML, которая используется для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002A96 RID: 10902 RVA: 0x0009A12A File Offset: 0x0009832A
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Использует заданное XML-кодирование, чтобы восстановить объект безопасности с помощью заданного контекста уровня политики.</summary>
		/// <param name="e">Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML, которая используется для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" /> для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002A97 RID: 10903 RVA: 0x0009A134 File Offset: 0x00098334
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
		}

		/// <summary>Возвращает хэш-код для текущего состояния членства.</summary>
		/// <returns>Ноль (0).</returns>
		// Token: 0x06002A98 RID: 10904 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Возвращает строковое представление состояния членства.</summary>
		/// <returns>Строковое представление условия членства.</returns>
		// Token: 0x06002A99 RID: 10905 RVA: 0x0009A14E File Offset: 0x0009834E
		public override string ToString()
		{
			return "GAC";
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование объекта безопасности, включающее любые данные состояния.</returns>
		// Token: 0x06002A9A RID: 10906 RVA: 0x0009A155 File Offset: 0x00098355
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния, используя заданный контекст уровня безопасности.</summary>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" /> для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование объекта безопасности, включающее любые данные состояния.</returns>
		// Token: 0x06002A9B RID: 10907 RVA: 0x0009A15E File Offset: 0x0009835E
		public SecurityElement ToXml(PolicyLevel level)
		{
			return MembershipConditionHelper.Element(typeof(GacMembershipCondition), this.version);
		}

		// Token: 0x04001F97 RID: 8087
		private readonly int version = 1;
	}
}
