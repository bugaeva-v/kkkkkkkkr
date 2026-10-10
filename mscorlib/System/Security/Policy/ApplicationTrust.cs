using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using Mono.Security.Cryptography;

namespace System.Security.Policy
{
	/// <summary>Инкапсулирует решения по обеспечению безопасности приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000403 RID: 1027
	[ComVisible(true)]
	[Serializable]
	public sealed class ApplicationTrust : EvidenceBase, ISecurityEncodable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ApplicationTrust" />.</summary>
		// Token: 0x060029F0 RID: 10736 RVA: 0x000981FA File Offset: 0x000963FA
		public ApplicationTrust()
		{
			this.fullTrustAssemblies = new List<StrongName>(0);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ApplicationTrust" />, используя объект <see cref="T:System.ApplicationIdentity" />.</summary>
		/// <param name="applicationIdentity">Объект <see cref="T:System.ApplicationIdentity" />, который однозначно определяет приложение.</param>
		// Token: 0x060029F1 RID: 10737 RVA: 0x0009820E File Offset: 0x0009640E
		public ApplicationTrust(ApplicationIdentity applicationIdentity) : this()
		{
			if (applicationIdentity == null)
			{
				throw new ArgumentNullException("applicationIdentity");
			}
			this._appid = applicationIdentity;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ApplicationTrust" />, используя предоставленный набор разрешений и коллекцию полностью доверенных сборок.</summary>
		/// <param name="defaultGrantSet">Набор разрешений по умолчанию, предоставляемый всем сборкам, не имеющим определенных разрешений.</param>
		/// <param name="fullTrustAssemblies">Массив строгих имен, представляющих сборки, которые должны считаться полностью доверенными в домене приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fullTrustAssemblies" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="fullTrustAssemblies" /> содержит сборку, которая не имеет <see cref="T:System.Security.Policy.StrongName" />.</exception>
		// Token: 0x060029F2 RID: 10738 RVA: 0x0009822C File Offset: 0x0009642C
		public ApplicationTrust(PermissionSet defaultGrantSet, IEnumerable<StrongName> fullTrustAssemblies)
		{
			if (defaultGrantSet == null)
			{
				throw new ArgumentNullException("defaultGrantSet");
			}
			this._defaultPolicy = new PolicyStatement(defaultGrantSet);
			if (fullTrustAssemblies == null)
			{
				throw new ArgumentNullException("fullTrustAssemblies");
			}
			this.fullTrustAssemblies = new List<StrongName>();
			foreach (StrongName strongName in fullTrustAssemblies)
			{
				if (strongName == null)
				{
					throw new ArgumentException("fullTrustAssemblies contains an assembly that does not have a StrongName");
				}
				this.fullTrustAssemblies.Add((StrongName)strongName.Copy());
			}
		}

		/// <summary>Возвращает или задает идентификацию приложения для объекта доверия приложения.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationIdentity" /> для объекта доверия приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Объект <see cref="T:System.ApplicationIdentity" /> не может быть установлен, так как он имеет значение <see langword="null" />.</exception>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000982CC File Offset: 0x000964CC
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x000982D4 File Offset: 0x000964D4
		public ApplicationIdentity ApplicationIdentity
		{
			get
			{
				return this._appid;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("ApplicationIdentity");
				}
				this._appid = value;
			}
		}

		/// <summary>Возвращает или задает инструкцию политики, определяющую набор разрешений по умолчанию.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.PolicyStatement" />, описывающий разрешения по умолчанию.</returns>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000982EB File Offset: 0x000964EB
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00098307 File Offset: 0x00096507
		public PolicyStatement DefaultGrantSet
		{
			get
			{
				if (this._defaultPolicy == null)
				{
					this._defaultPolicy = this.GetDefaultGrantSet();
				}
				return this._defaultPolicy;
			}
			set
			{
				this._defaultPolicy = value;
			}
		}

		/// <summary>Возвращает или задает дополнительные сведения о безопасности для приложения.</summary>
		/// <returns>Объект, содержащий дополнительные сведения о безопасности для приложения.</returns>
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x00098310 File Offset: 0x00096510
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00098318 File Offset: 0x00096518
		public object ExtraInfo
		{
			get
			{
				return this._xtranfo;
			}
			set
			{
				this._xtranfo = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, имеет ли приложение необходимые разрешения и является ли оно доверенным для выполнения.</summary>
		/// <returns>Значение <see langword="true" />, если приложение является доверенным для выполнения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00098321 File Offset: 0x00096521
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x00098329 File Offset: 0x00096529
		public bool IsApplicationTrustedToRun
		{
			get
			{
				return this._trustrun;
			}
			set
			{
				this._trustrun = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, сохраняется ли информация о доверии для приложения.</summary>
		/// <returns>Значение <see langword="true" />, если информация о доверии для приложения сохраняется; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00098332 File Offset: 0x00096532
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x0009833A File Offset: 0x0009653A
		public bool Persist
		{
			get
			{
				return this._persist;
			}
			set
			{
				this._persist = value;
			}
		}

		/// <summary>Восстанавливает объект <see cref="T:System.Security.Policy.ApplicationTrust" /> с заданным состоянием из кодировки XML.</summary>
		/// <param name="element">Кодировка XML, используемая для восстановления объекта <see cref="T:System.Security.Policy.ApplicationTrust" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Кодировка XML, используемая для параметра <paramref name="element" />, является недопустимой.</exception>
		// Token: 0x060029FD RID: 10749 RVA: 0x00098344 File Offset: 0x00096544
		public void FromXml(SecurityElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (element.Tag != "ApplicationTrust")
			{
				throw new ArgumentException("element");
			}
			string text = element.Attribute("FullName");
			if (text != null)
			{
				this._appid = new ApplicationIdentity(text);
			}
			else
			{
				this._appid = null;
			}
			this._defaultPolicy = null;
			SecurityElement securityElement = element.SearchForChildByTag("DefaultGrant");
			if (securityElement != null)
			{
				for (int i = 0; i < securityElement.Children.Count; i++)
				{
					SecurityElement securityElement2 = securityElement.Children[i] as SecurityElement;
					if (securityElement2.Tag == "PolicyStatement")
					{
						this.DefaultGrantSet.FromXml(securityElement2, null);
						break;
					}
				}
			}
			if (!bool.TryParse(element.Attribute("TrustedToRun"), out this._trustrun))
			{
				this._trustrun = false;
			}
			if (!bool.TryParse(element.Attribute("Persist"), out this._persist))
			{
				this._persist = false;
			}
			this._xtranfo = null;
			SecurityElement securityElement3 = element.SearchForChildByTag("ExtraInfo");
			if (securityElement3 != null)
			{
				text = securityElement3.Attribute("Data");
				if (text != null)
				{
					using (MemoryStream memoryStream = new MemoryStream(CryptoConvert.FromHex(text)))
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						this._xtranfo = binaryFormatter.Deserialize(memoryStream);
					}
				}
			}
		}

		/// <summary>Создает кодирование XML объекта <see cref="T:System.Security.Policy.ApplicationTrust" /> и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x060029FE RID: 10750 RVA: 0x000984A8 File Offset: 0x000966A8
		public SecurityElement ToXml()
		{
			SecurityElement securityElement = new SecurityElement("ApplicationTrust");
			securityElement.AddAttribute("version", "1");
			if (this._appid != null)
			{
				securityElement.AddAttribute("FullName", this._appid.FullName);
			}
			if (this._trustrun)
			{
				securityElement.AddAttribute("TrustedToRun", "true");
			}
			if (this._persist)
			{
				securityElement.AddAttribute("Persist", "true");
			}
			SecurityElement securityElement2 = new SecurityElement("DefaultGrant");
			securityElement2.AddChild(this.DefaultGrantSet.ToXml());
			securityElement.AddChild(securityElement2);
			if (this._xtranfo != null)
			{
				byte[] input = null;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					new BinaryFormatter().Serialize(memoryStream, this._xtranfo);
					input = memoryStream.ToArray();
				}
				SecurityElement securityElement3 = new SecurityElement("ExtraInfo");
				securityElement3.AddAttribute("Data", CryptoConvert.ToHex(input));
				securityElement.AddChild(securityElement3);
			}
			return securityElement;
		}

		/// <summary>Получает список полностью доверенных сборок, которые будут доверенными для этого приложения.</summary>
		/// <returns>Список полностью доверенных сборок.</returns>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000985B0 File Offset: 0x000967B0
		public IList<StrongName> FullTrustAssemblies
		{
			get
			{
				return this.fullTrustAssemblies;
			}
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000985B8 File Offset: 0x000967B8
		private PolicyStatement GetDefaultGrantSet()
		{
			return new PolicyStatement(new PermissionSet(PermissionState.None));
		}

		// Token: 0x04001F5B RID: 8027
		private ApplicationIdentity _appid;

		// Token: 0x04001F5C RID: 8028
		private PolicyStatement _defaultPolicy;

		// Token: 0x04001F5D RID: 8029
		private object _xtranfo;

		// Token: 0x04001F5E RID: 8030
		private bool _trustrun;

		// Token: 0x04001F5F RID: 8031
		private bool _persist;

		// Token: 0x04001F60 RID: 8032
		private IList<StrongName> fullTrustAssemblies;
	}
}
