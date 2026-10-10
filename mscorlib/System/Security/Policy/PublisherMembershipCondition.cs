using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки сертификата Authenticode X.509v3 издателя программного обеспечения. Этот класс не наследуется.</summary>
	// Token: 0x020003FD RID: 1021
	[Serializable]
	public sealed class PublisherMembershipCondition : ISecurityEncodable, ISecurityPolicyEncodable, IMembershipCondition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PublisherMembershipCondition" /> с сертификатом Authenticode X.509v3, определяющим членство.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, содержащий открытый ключ издателя программного обеспечения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060029BA RID: 10682 RVA: 0x0000259F File Offset: 0x0000079F
		public PublisherMembershipCondition(X509Certificate certificate)
		{
		}

		/// <summary>Возвращает или задает сертификат Authenticode X.509v3, который используется при проверке условия членства.</summary>
		/// <returns>Сертификат <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, используемый при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства — <see langword="null" />.</exception>
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x00097E3B File Offset: 0x0009603B
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x00097E43 File Offset: 0x00096043
		public X509Certificate Certificate { get; set; }

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Свидетельство <see cref="T:System.Security.Policy.Evidence" />, для которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029BD RID: 10685 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool Check(Evidence evidence)
		{
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029BE RID: 10686 RVA: 0x0000270D File Offset: 0x0000090D
		public IMembershipCondition Copy()
		{
			return this;
		}

		/// <summary>Определяет, эквивалентен ли сертификат издателя из указанного объекта сертификату, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.PublisherMembershipCondition" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Security.Policy.PublisherMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если сертификат издателя из указанного объекта эквивалентен сертификату, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.PublisherMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029BF RID: 10687 RVA: 0x00097E2A File Offset: 0x0009602A
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x060029C0 RID: 10688 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void FromXml(SecurityElement e)
		{
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x060029C1 RID: 10689 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029C2 RID: 10690 RVA: 0x000930E8 File Offset: 0x000912E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление объекта <see cref="T:System.Security.Policy.PublisherMembershipCondition" />.</summary>
		/// <returns>Представление объекта <see cref="T:System.Security.Policy.PublisherMembershipCondition" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029C3 RID: 10691 RVA: 0x00097E33 File Offset: 0x00096033
		public override string ToString()
		{
			return base.ToString();
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029C4 RID: 10692 RVA: 0x0000AF5E File Offset: 0x0000915E
		public SecurityElement ToXml()
		{
			return null;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.PublisherMembershipCondition.Certificate" /> — <see langword="null" />.</exception>
		// Token: 0x060029C5 RID: 10693 RVA: 0x0000AF5E File Offset: 0x0000915E
		public SecurityElement ToXml(PolicyLevel level)
		{
			return null;
		}
	}
}
