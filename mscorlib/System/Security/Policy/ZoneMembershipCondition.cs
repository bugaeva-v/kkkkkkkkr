using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки зоны ее источника. Этот класс не наследуется.</summary>
	// Token: 0x02000428 RID: 1064
	[ComVisible(true)]
	[Serializable]
	public sealed class ZoneMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		// Token: 0x06002B8B RID: 11147 RVA: 0x0009D3F5 File Offset: 0x0009B5F5
		internal ZoneMembershipCondition()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ZoneMembershipCondition" /> с зоной, определяющей членство.</summary>
		/// <param name="zone">Зона <see cref="T:System.Security.SecurityZone" />, используемая при проверке.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="zone" /> не является допустимым <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B8C RID: 11148 RVA: 0x0009D404 File Offset: 0x0009B604
		public ZoneMembershipCondition(SecurityZone zone)
		{
			this.SecurityZone = zone;
		}

		/// <summary>Возвращает или задает зону, которая используется при проверке условия членства.</summary>
		/// <returns>Зона, используемая при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> недопустимое значение <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x0009D41A File Offset: 0x0009B61A
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x0009D424 File Offset: 0x0009B624
		public SecurityZone SecurityZone
		{
			get
			{
				return this.zone;
			}
			set
			{
				if (!Enum.IsDefined(typeof(SecurityZone), value))
				{
					throw new ArgumentException(Locale.GetText("invalid zone"));
				}
				if (value == SecurityZone.NoZone)
				{
					throw new ArgumentException(Locale.GetText("NoZone isn't valid for membership condition"));
				}
				this.zone = value;
			}
		}

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B8F RID: 11151 RVA: 0x0009D474 File Offset: 0x0009B674
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				object obj = hostEnumerator.Current;
				Zone zone = obj as Zone;
				if (zone != null && zone.SecurityZone == this.zone)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B90 RID: 11152 RVA: 0x0009D4B7 File Offset: 0x0009B6B7
		public IMembershipCondition Copy()
		{
			return new ZoneMembershipCondition(this.zone);
		}

		/// <summary>Определяет, эквивалентна ли зона указанного объекта зоне, содержащейся в текущем объекте <see cref="T:System.Security.Policy.ZoneMembershipCondition" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Security.Policy.ZoneMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если зона указанного объекта эквивалентна зоне, содержащейся в текущем объекте <see cref="T:System.Security.Policy.ZoneMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> текущего объекта или указанный объект имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> текущего объекта или указанный объект не является допустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B91 RID: 11153 RVA: 0x0009D4C4 File Offset: 0x0009B6C4
		public override bool Equals(object o)
		{
			ZoneMembershipCondition zoneMembershipCondition = o as ZoneMembershipCondition;
			return zoneMembershipCondition != null && zoneMembershipCondition.SecurityZone == this.zone;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B92 RID: 11154 RVA: 0x0009D4EB File Offset: 0x0009B6EB
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для разрешения ссылок на именованные наборы разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B93 RID: 11155 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
			string text = e.Attribute("Zone");
			if (text != null)
			{
				this.zone = (SecurityZone)Enum.Parse(typeof(SecurityZone), text);
			}
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B94 RID: 11156 RVA: 0x0009D547 File Offset: 0x0009B747
		public override int GetHashCode()
		{
			return this.zone.GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление состояния условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B95 RID: 11157 RVA: 0x0009D55A File Offset: 0x0009B75A
		public override string ToString()
		{
			return "Zone - " + this.zone.ToString();
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B96 RID: 11158 RVA: 0x0009D577 File Offset: 0x0009B777
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст уровня политики для разрешения ссылок на именованные наборы разрешений.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.ZoneMembershipCondition.SecurityZone" /> является недопустимым объектом <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x06002B97 RID: 11159 RVA: 0x0009D580 File Offset: 0x0009B780
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = MembershipConditionHelper.Element(typeof(ZoneMembershipCondition), this.version);
			securityElement.AddAttribute("Zone", this.zone.ToString());
			return securityElement;
		}

		// Token: 0x04001FCB RID: 8139
		private readonly int version = 1;

		// Token: 0x04001FCC RID: 8140
		private SecurityZone zone;
	}
}
