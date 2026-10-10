using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Представляет оператор объекта <see cref="T:System.Security.Policy.CodeGroup" />, описывающую разрешения и другую информацию, применяемую к коду с определенным набором свидетельств. Этот класс не наследуется.</summary>
	// Token: 0x0200041D RID: 1053
	[ComVisible(true)]
	[Serializable]
	public sealed class PolicyStatement : ISecurityEncodable, ISecurityPolicyEncodable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyStatement" /> указанным значением <see cref="T:System.Security.PermissionSet" />.</summary>
		/// <param name="permSet">Объект <see cref="T:System.Security.PermissionSet" /> для инициализации нового экземпляра.</param>
		// Token: 0x06002B0A RID: 11018 RVA: 0x0009BFE0 File Offset: 0x0009A1E0
		public PolicyStatement(PermissionSet permSet) : this(permSet, PolicyStatementAttribute.Nothing)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyStatement" /> с указанным объектом <see cref="T:System.Security.PermissionSet" /> и атрибутами.</summary>
		/// <param name="permSet">Объект <see cref="T:System.Security.PermissionSet" /> для инициализации нового экземпляра.</param>
		/// <param name="attributes">Поразрядное сочетание значений <see cref="T:System.Security.Policy.PolicyStatementAttribute" />.</param>
		// Token: 0x06002B0B RID: 11019 RVA: 0x0009BFEA File Offset: 0x0009A1EA
		public PolicyStatement(PermissionSet permSet, PolicyStatementAttribute attributes)
		{
			if (permSet != null)
			{
				this.perms = permSet.Copy();
				this.perms.SetReadOnly(true);
			}
			this.attrs = attributes;
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.PermissionSet" /> инструкции политики.</summary>
		/// <returns>Объект <see cref="T:System.Security.PermissionSet" /> инструкции политики.</returns>
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0009C014 File Offset: 0x0009A214
		// (set) Token: 0x06002B0D RID: 11021 RVA: 0x0009C03C File Offset: 0x0009A23C
		public PermissionSet PermissionSet
		{
			get
			{
				if (this.perms == null)
				{
					this.perms = new PermissionSet(PermissionState.None);
					this.perms.SetReadOnly(true);
				}
				return this.perms;
			}
			set
			{
				this.perms = value;
			}
		}

		/// <summary>Возвращает или задает атрибуты инструкции политики.</summary>
		/// <returns>Атрибуты инструкции политики.</returns>
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0009C045 File Offset: 0x0009A245
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0009C04D File Offset: 0x0009A24D
		public PolicyStatementAttribute Attributes
		{
			get
			{
				return this.attrs;
			}
			set
			{
				if (value <= PolicyStatementAttribute.All)
				{
					this.attrs = value;
					return;
				}
				throw new ArgumentException(string.Format(Locale.GetText("Invalid value for {0}."), "PolicyStatementAttribute"));
			}
		}

		/// <summary>Получает строковое представление атрибутов инструкции политики.</summary>
		/// <returns>Текстовая строка, представляющая атрибуты инструкции политики.</returns>
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0009C074 File Offset: 0x0009A274
		public string AttributeString
		{
			get
			{
				switch (this.attrs)
				{
				case PolicyStatementAttribute.Exclusive:
					return "Exclusive";
				case PolicyStatementAttribute.LevelFinal:
					return "LevelFinal";
				case PolicyStatementAttribute.All:
					return "Exclusive LevelFinal";
				default:
					return string.Empty;
				}
			}
		}

		/// <summary>Создает эквивалентную копию текущей инструкции политики.</summary>
		/// <returns>Новая копия объекта <see cref="T:System.Security.Policy.PolicyStatement" /> со значениями членов <see cref="P:System.Security.Policy.PolicyStatement.PermissionSet" /> и <see cref="P:System.Security.Policy.PolicyStatement.Attributes" />, совпадающими со значениями этих членов текущего объекта <see cref="T:System.Security.Policy.PolicyStatement" />.</returns>
		// Token: 0x06002B11 RID: 11025 RVA: 0x0009C0B5 File Offset: 0x0009A2B5
		public PolicyStatement Copy()
		{
			return new PolicyStatement(this.perms, this.attrs);
		}

		/// <summary>Восстанавливает объект безопасности с данным состоянием из кодировки XML.</summary>
		/// <param name="et">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="et" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="et" /> является недопустимой кодировкой <see cref="T:System.Security.Policy.PolicyStatement" />.</exception>
		// Token: 0x06002B12 RID: 11026 RVA: 0x0009C0C8 File Offset: 0x0009A2C8
		public void FromXml(SecurityElement et)
		{
			this.FromXml(et, null);
		}

		/// <summary>Восстанавливает объект безопасности с данным состоянием из кодировки XML.</summary>
		/// <param name="et">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" /> для поиска значений <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="et" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="et" /> является недопустимой кодировкой <see cref="T:System.Security.Policy.PolicyStatement" />.</exception>
		// Token: 0x06002B13 RID: 11027 RVA: 0x0009C0D4 File Offset: 0x0009A2D4
		[SecuritySafeCritical]
		public void FromXml(SecurityElement et, PolicyLevel level)
		{
			if (et == null)
			{
				throw new ArgumentNullException("et");
			}
			if (et.Tag != "PolicyStatement")
			{
				throw new ArgumentException(Locale.GetText("Invalid tag."));
			}
			string text = et.Attribute("Attributes");
			if (text != null)
			{
				this.attrs = (PolicyStatementAttribute)Enum.Parse(typeof(PolicyStatementAttribute), text);
			}
			SecurityElement et2 = et.SearchForChildByTag("PermissionSet");
			this.PermissionSet.FromXml(et2);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B14 RID: 11028 RVA: 0x0009C153 File Offset: 0x0009A353
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" /> для поиска значений <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B15 RID: 11029 RVA: 0x0009C15C File Offset: 0x0009A35C
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = new SecurityElement("PolicyStatement");
			securityElement.AddAttribute("version", "1");
			if (this.attrs != PolicyStatementAttribute.Nothing)
			{
				securityElement.AddAttribute("Attributes", this.attrs.ToString());
			}
			securityElement.AddChild(this.PermissionSet.ToXml());
			return securityElement;
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Security.Policy.PolicyStatement" /> текущему объекту <see cref="T:System.Security.Policy.PolicyStatement" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Security.Policy.PolicyStatement" />, который требуется сравнить с текущим объектом <see cref="T:System.Security.Policy.PolicyStatement" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Security.Policy.PolicyStatement" /> равен текущему объекту <see cref="T:System.Security.Policy.PolicyStatement" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002B16 RID: 11030 RVA: 0x0009C1BC File Offset: 0x0009A3BC
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			PolicyStatement policyStatement = obj as PolicyStatement;
			return policyStatement != null && this.PermissionSet.Equals(obj) && this.attrs == policyStatement.attrs;
		}

		/// <summary>Возвращает хэш-код для объекта <see cref="T:System.Security.Policy.PolicyStatement" />, который можно использовать в алгоритмах хэширования и структурах данных, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Security.Policy.PolicyStatement" />.</returns>
		// Token: 0x06002B17 RID: 11031 RVA: 0x0009C1F8 File Offset: 0x0009A3F8
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return this.PermissionSet.GetHashCode() ^ (int)this.attrs;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000985B8 File Offset: 0x000967B8
		internal static PolicyStatement Empty()
		{
			return new PolicyStatement(new PermissionSet(PermissionState.None));
		}

		// Token: 0x04001FB0 RID: 8112
		private PermissionSet perms;

		// Token: 0x04001FB1 RID: 8113
		private PolicyStatementAttribute attrs;
	}
}
