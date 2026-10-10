using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки веб-узла, являющегося источником сборки. Этот класс не наследуется.</summary>
	// Token: 0x0200041F RID: 1055
	[ComVisible(true)]
	[Serializable]
	public sealed class SiteMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		// Token: 0x06002B26 RID: 11046 RVA: 0x0009C483 File Offset: 0x0009A683
		internal SiteMembershipCondition()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.SiteMembershipCondition" /> с именем веб-узла, определяющим членство.</summary>
		/// <param name="site">Имя сайта или подстановочное выражение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="site" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="site" /> не является допустимым <see cref="T:System.Security.Policy.Site" />.</exception>
		// Token: 0x06002B27 RID: 11047 RVA: 0x0009C492 File Offset: 0x0009A692
		public SiteMembershipCondition(string site)
		{
			this.Site = site;
		}

		/// <summary>Возвращает или задает веб-узел, который используется при проверке условия членства.</summary>
		/// <returns>Веб-узел, используемый при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> недопустимое значение <see cref="T:System.Security.Policy.Site" />.</exception>
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0009C4A8 File Offset: 0x0009A6A8
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
		public string Site
		{
			get
			{
				return this._site;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("site");
				}
				if (!System.Security.Policy.Site.IsValid(value))
				{
					throw new ArgumentException("invalid site");
				}
				this._site = value;
			}
		}

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Свидетельство <see cref="T:System.Security.Policy.Evidence" />, для которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B2A RID: 11050 RVA: 0x0009C4DC File Offset: 0x0009A6DC
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				if (hostEnumerator.Current is Site)
				{
					string[] array = this._site.Split('.', StringSplitOptions.None);
					string[] array2 = (hostEnumerator.Current as Site).origin_site.Split('.', StringSplitOptions.None);
					int i = array.Length - 1;
					int num = array2.Length - 1;
					while (i >= 0)
					{
						if (i == 0)
						{
							return string.Compare(array[0], "*", true, CultureInfo.InvariantCulture) == 0;
						}
						if (string.Compare(array[i], array2[num], true, CultureInfo.InvariantCulture) != 0)
						{
							return false;
						}
						i--;
						num--;
					}
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B2B RID: 11051 RVA: 0x0009C58A File Offset: 0x0009A78A
		public IMembershipCondition Copy()
		{
			return new SiteMembershipCondition(this._site);
		}

		/// <summary>Определяет, эквивалентен ли веб-узел указанного объекта <see cref="T:System.Security.Policy.SiteMembershipCondition" /> веб-узлу, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.SiteMembershipCondition" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Security.Policy.SiteMembershipCondition" />, который требуется сравнить с текущим объектом <see cref="T:System.Security.Policy.SiteMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если веб-узел указанного объекта <see cref="T:System.Security.Policy.SiteMembershipCondition" /> эквивалентен веб-узлу, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.SiteMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> текущего объекта или указанный объект имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B2C RID: 11052 RVA: 0x0009C597 File Offset: 0x0009A797
		public override bool Equals(object o)
		{
			return o != null && o is SiteMembershipCondition && new Site((o as SiteMembershipCondition)._site).Equals(new Site(this._site));
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B2D RID: 11053 RVA: 0x0009C5C8 File Offset: 0x0009A7C8
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B2E RID: 11054 RVA: 0x0009C5D2 File Offset: 0x0009A7D2
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
			this._site = e.Attribute("Site");
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B2F RID: 11055 RVA: 0x0009C5FD File Offset: 0x0009A7FD
		public override int GetHashCode()
		{
			return this._site.GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление условия членства.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B30 RID: 11056 RVA: 0x0009C60A File Offset: 0x0009A80A
		public override string ToString()
		{
			return "Site - " + this._site;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B31 RID: 11057 RVA: 0x0009C61C File Offset: 0x0009A81C
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.SiteMembershipCondition.Site" /> — <see langword="null" />.</exception>
		// Token: 0x06002B32 RID: 11058 RVA: 0x0009C625 File Offset: 0x0009A825
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = MembershipConditionHelper.Element(typeof(SiteMembershipCondition), this.version);
			securityElement.AddAttribute("Site", this._site);
			return securityElement;
		}

		// Token: 0x04001FB3 RID: 8115
		private readonly int version = 1;

		// Token: 0x04001FB4 RID: 8116
		private string _site;
	}
}
