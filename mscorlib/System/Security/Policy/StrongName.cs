using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Предоставляет строгое имя сборки кода, используемое в качестве свидетельства для проверки политики. Этот класс не наследуется.</summary>
	// Token: 0x02000420 RID: 1056
	[ComVisible(true)]
	[Serializable]
	public sealed class StrongName : EvidenceBase, IIdentityPermissionFactory, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.StrongName" /> с заданным blob-объектом открытого ключа строгого имени, заданным именем и версией.</summary>
		/// <param name="blob">Объект <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> издателя программного обеспечения.</param>
		/// <param name="name">Секция простого имени в строгом имени.</param>
		/// <param name="version">Версия <see cref="T:System.Version" /> строгого имени.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="blob" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="version" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		// Token: 0x06002B33 RID: 11059 RVA: 0x0009C650 File Offset: 0x0009A850
		public StrongName(StrongNamePublicKeyBlob blob, string name, Version version)
		{
			if (blob == null)
			{
				throw new ArgumentNullException("blob");
			}
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException(Locale.GetText("Empty"), "name");
			}
			this.publickey = blob;
			this.name = name;
			this.version = version;
		}

		/// <summary>Получает простое имя текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>Часть, содержащая простое имя объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0009C6C5 File Offset: 0x0009A8C5
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> для текущего экземпляра <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" /> текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x0009C6CD File Offset: 0x0009A8CD
		public StrongNamePublicKeyBlob PublicKey
		{
			get
			{
				return this.publickey;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Version" /> для текущего экземпляра <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>
		///   <see cref="T:System.Version" /> текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x0009C6D5 File Offset: 0x0009A8D5
		public Version Version
		{
			get
			{
				return this.version;
			}
		}

		/// <summary>Создает эквивалентную копию текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>Новая, идентичная копия текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x06002B37 RID: 11063 RVA: 0x0009C6DD File Offset: 0x0009A8DD
		public object Copy()
		{
			return new StrongName(this.publickey, this.name, this.version);
		}

		/// <summary>Создает объект <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" />, который соответствует текущему объекту <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" />, на основе которого создается объект <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" />.</param>
		/// <returns>Разрешение <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> для указанного объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x06002B38 RID: 11064 RVA: 0x0009C6F6 File Offset: 0x0009A8F6
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return new StrongNameIdentityPermission(this.publickey, this.name, this.version);
		}

		/// <summary>Определяет, эквивалентно ли указанное строгое имя текущему строгому имени.</summary>
		/// <param name="o">Строгое имя, которое требуется сравнить с текущим строгим именем.</param>
		/// <returns>Значение <see langword="true" />, если указанное строгое имя эквивалентно текущему строгому имени; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002B39 RID: 11065 RVA: 0x0009C710 File Offset: 0x0009A910
		public override bool Equals(object o)
		{
			StrongName strongName = o as StrongName;
			return strongName != null && !(this.name != strongName.Name) && this.Version.Equals(strongName.Version) && this.PublicKey.Equals(strongName.PublicKey);
		}

		/// <summary>Получает хэш-код текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>Хэш-код текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x06002B3A RID: 11066 RVA: 0x0009C764 File Offset: 0x0009A964
		public override int GetHashCode()
		{
			return this.publickey.GetHashCode();
		}

		/// <summary>Создает строковое представление текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.StrongName" />.</returns>
		// Token: 0x06002B3B RID: 11067 RVA: 0x0009C774 File Offset: 0x0009A974
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement(typeof(StrongName).Name);
			securityElement.AddAttribute("version", "1");
			securityElement.AddAttribute("Key", this.publickey.ToString());
			securityElement.AddAttribute("Name", this.name);
			securityElement.AddAttribute("Version", this.version.ToString());
			return securityElement.ToString();
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0009C7E7 File Offset: 0x0009A9E7
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return (verbose ? 5 : 1) + this.name.Length;
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		// Token: 0x04001FB5 RID: 8117
		private StrongNamePublicKeyBlob publickey;

		// Token: 0x04001FB6 RID: 8118
		private string name;

		// Token: 0x04001FB7 RID: 8119
		private Version version;
	}
}
