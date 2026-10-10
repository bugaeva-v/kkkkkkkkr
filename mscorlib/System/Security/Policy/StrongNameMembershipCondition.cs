using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки ее строгого имени. Этот класс не наследуется.</summary>
	// Token: 0x02000421 RID: 1057
	[ComVisible(true)]
	[Serializable]
	public sealed class StrongNameMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> с заданным BLOB-объектом открытого ключа строгого имени, заданным именем и версией, определяющими членство.</summary>
		/// <param name="blob">BLOB-объект открытого ключа строгого имени издателя программного обеспечения.</param>
		/// <param name="name">Секция простого имени в строгом имени.</param>
		/// <param name="version">Номер версии строгого имени.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="blob" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		// Token: 0x06002B3F RID: 11071 RVA: 0x0009C7FC File Offset: 0x0009A9FC
		public StrongNameMembershipCondition(StrongNamePublicKeyBlob blob, string name, Version version)
		{
			if (blob == null)
			{
				throw new ArgumentNullException("blob");
			}
			this.blob = blob;
			this.name = name;
			if (version != null)
			{
				this.assemblyVersion = (Version)version.Clone();
			}
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0009C84C File Offset: 0x0009AA4C
		internal StrongNameMembershipCondition(SecurityElement e)
		{
			this.FromXml(e);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0009C862 File Offset: 0x0009AA62
		internal StrongNameMembershipCondition()
		{
		}

		/// <summary>Возвращает или задает простое имя для объекта <see cref="T:System.Security.Policy.StrongName" />, которое используется при проверке условия членства.</summary>
		/// <returns>Простое имя для объекта <see cref="T:System.Security.Policy.StrongName" />, которое используется при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentException">Значение — <see langword="null" />.  
		///
		/// или - 
		/// Значением является пустая строка ("").</exception>
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x0009C871 File Offset: 0x0009AA71
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x0009C879 File Offset: 0x0009AA79
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Возвращает или задает член <see cref="T:System.Version" /> для объекта <see cref="T:System.Security.Policy.StrongName" />, который используется при проверке условия членства.</summary>
		/// <returns>Член <see cref="T:System.Version" /> для объекта <see cref="T:System.Security.Policy.StrongName" />, используемый при проверке условия членства.</returns>
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x0009C882 File Offset: 0x0009AA82
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x0009C88A File Offset: 0x0009AA8A
		public Version Version
		{
			get
			{
				return this.assemblyVersion;
			}
			set
			{
				this.assemblyVersion = value;
			}
		}

		/// <summary>Возвращает или задает член <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> для объекта <see cref="T:System.Security.Policy.StrongName" />, который используется при проверке условия членства.</summary>
		/// <returns>Член <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> для объекта <see cref="T:System.Security.Policy.StrongName" />, используемый при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для объекта <see cref="P:System.Security.Policy.StrongNameMembershipCondition.PublicKey" /> значение <see langword="null" />.</exception>
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x0009C893 File Offset: 0x0009AA93
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x0009C89B File Offset: 0x0009AA9B
		public StrongNamePublicKeyBlob PublicKey
		{
			get
			{
				return this.blob;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("PublicKey");
				}
				this.blob = value;
			}
		}

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Свидетельство <see cref="T:System.Security.Policy.Evidence" />, для которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002B48 RID: 11080 RVA: 0x0009C8B4 File Offset: 0x0009AAB4
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
				StrongName strongName = obj as StrongName;
				if (strongName != null)
				{
					return strongName.PublicKey.Equals(this.blob) && (this.name == null || !(this.name != strongName.Name)) && (!(this.assemblyVersion != null) || this.assemblyVersion.Equals(strongName.Version));
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию текущего объекта <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</summary>
		/// <returns>Новая, идентичная копия текущего объекта <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</returns>
		// Token: 0x06002B49 RID: 11081 RVA: 0x0009C93E File Offset: 0x0009AB3E
		public IMembershipCondition Copy()
		{
			return new StrongNameMembershipCondition(this.blob, this.name, this.assemblyVersion);
		}

		/// <summary>Определяет, эквивалентен ли член <see cref="T:System.Security.Policy.StrongName" /> из указанного объекта члену <see cref="T:System.Security.Policy.StrongName" />, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если член <see cref="T:System.Security.Policy.StrongName" /> указанного объекта эквивалентен члену <see cref="T:System.Security.Policy.StrongName" />, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Security.Policy.StrongNameMembershipCondition.PublicKey" /> текущего объекта или указанный объект имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B4A RID: 11082 RVA: 0x0009C958 File Offset: 0x0009AB58
		public override bool Equals(object o)
		{
			StrongNameMembershipCondition strongNameMembershipCondition = o as StrongNameMembershipCondition;
			if (strongNameMembershipCondition == null)
			{
				return false;
			}
			if (!strongNameMembershipCondition.PublicKey.Equals(this.PublicKey))
			{
				return false;
			}
			if (this.name != strongNameMembershipCondition.Name)
			{
				return false;
			}
			if (this.assemblyVersion != null)
			{
				return this.assemblyVersion.Equals(strongNameMembershipCondition.Version);
			}
			return strongNameMembershipCondition.Version == null;
		}

		/// <summary>Возвращает хэш-код для текущего объекта класса <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</summary>
		/// <returns>Хэш-код для текущего значения свойства <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства <see cref="P:System.Security.Policy.StrongNameMembershipCondition.PublicKey" /> — <see langword="null" />.</exception>
		// Token: 0x06002B4B RID: 11083 RVA: 0x0009C9C7 File Offset: 0x0009ABC7
		public override int GetHashCode()
		{
			return this.blob.GetHashCode();
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x06002B4C RID: 11084 RVA: 0x0009C9D4 File Offset: 0x0009ABD4
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B4D RID: 11085 RVA: 0x0009C9E0 File Offset: 0x0009ABE0
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
			this.blob = StrongNamePublicKeyBlob.FromString(e.Attribute("PublicKeyBlob"));
			this.name = e.Attribute("Name");
			string text = e.Attribute("AssemblyVersion");
			if (text == null)
			{
				this.assemblyVersion = null;
				return;
			}
			this.assemblyVersion = new Version(text);
		}

		/// <summary>Создает и возвращает строковое представление текущего <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />.</returns>
		// Token: 0x06002B4E RID: 11086 RVA: 0x0009CA50 File Offset: 0x0009AC50
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("StrongName - ");
			stringBuilder.Append(this.blob);
			if (this.name != null)
			{
				stringBuilder.AppendFormat(" name = {0}", this.name);
			}
			if (this.assemblyVersion != null)
			{
				stringBuilder.AppendFormat(" version = {0}", this.assemblyVersion);
			}
			return stringBuilder.ToString();
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B4F RID: 11087 RVA: 0x0009CAB5 File Offset: 0x0009ACB5
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст <see cref="T:System.Security.Policy.PolicyLevel" />, используемый для разрешения ссылок <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B50 RID: 11088 RVA: 0x0009CAC0 File Offset: 0x0009ACC0
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = MembershipConditionHelper.Element(typeof(StrongNameMembershipCondition), this.version);
			if (this.blob != null)
			{
				securityElement.AddAttribute("PublicKeyBlob", this.blob.ToString());
			}
			if (this.name != null)
			{
				securityElement.AddAttribute("Name", this.name);
			}
			if (this.assemblyVersion != null)
			{
				string text = this.assemblyVersion.ToString();
				if (text != "0.0")
				{
					securityElement.AddAttribute("AssemblyVersion", text);
				}
			}
			return securityElement;
		}

		// Token: 0x04001FB8 RID: 8120
		private readonly int version = 1;

		// Token: 0x04001FB9 RID: 8121
		private StrongNamePublicKeyBlob blob;

		// Token: 0x04001FBA RID: 8122
		private string name;

		// Token: 0x04001FBB RID: 8123
		private Version assemblyVersion;
	}
}
