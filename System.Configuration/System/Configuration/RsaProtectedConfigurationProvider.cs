using System;
using System.Collections.Specialized;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using Unity;

namespace System.Configuration
{
	/// <summary>Предоставляет экземпляр <see cref="T:System.Configuration.ProtectedConfigurationProvider" />, использующий шифрование RSA для зашифровки и дешифровки данных конфигурации.</summary>
	// Token: 0x02000065 RID: 101
	public sealed class RsaProtectedConfigurationProvider : ProtectedConfigurationProvider
	{
		// Token: 0x0600033E RID: 830 RVA: 0x00008FA0 File Offset: 0x000071A0
		private RSACryptoServiceProvider GetProvider()
		{
			if (this.rsa == null)
			{
				CspParameters cspParameters = new CspParameters();
				cspParameters.ProviderName = this.cspProviderName;
				cspParameters.KeyContainerName = this.keyContainerName;
				if (this.useMachineContainer)
				{
					cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
				}
				this.rsa = new RSACryptoServiceProvider(cspParameters);
			}
			return this.rsa;
		}

		/// <summary>Расшифровывает переданный узел XML.</summary>
		/// <param name="encryptedNode">Объект <see cref="T:System.Xml.XmlNode" /> для расшифровки.</param>
		/// <returns>Расшифрованный узел XML.</returns>
		// Token: 0x06000340 RID: 832 RVA: 0x00008FFB File Offset: 0x000071FB
		[MonoTODO]
		public override XmlNode Decrypt(XmlNode encryptedNode)
		{
			ConfigurationXmlDocument configurationXmlDocument = new ConfigurationXmlDocument();
			configurationXmlDocument.Load(new StringReader(encryptedNode.OuterXml));
			EncryptedXml encryptedXml = new EncryptedXml(configurationXmlDocument);
			encryptedXml.AddKeyNameMapping("Rsa Key", this.GetProvider());
			encryptedXml.DecryptDocument();
			return configurationXmlDocument.DocumentElement;
		}

		/// <summary>Зашифровывает переданный в него узел XML.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.XmlNode" /> для шифрования.</param>
		/// <returns>Зашифрованный объект <see cref="T:System.Xml.XmlNode" />.</returns>
		// Token: 0x06000341 RID: 833 RVA: 0x00009034 File Offset: 0x00007234
		[MonoTODO]
		public override XmlNode Encrypt(XmlNode node)
		{
			XmlDocument xmlDocument = new ConfigurationXmlDocument();
			xmlDocument.Load(new StringReader(node.OuterXml));
			EncryptedXml encryptedXml = new EncryptedXml(xmlDocument);
			encryptedXml.AddKeyNameMapping("Rsa Key", this.GetProvider());
			return encryptedXml.Encrypt(xmlDocument.DocumentElement, "Rsa Key").GetXml();
		}

		/// <summary>Выполняет инициализацию поставщика параметрами по умолчанию.</summary>
		/// <param name="name">Имя используемого поставщика для объекта.</param>
		/// <param name="configurationValues">Коллекция значений <see cref="T:System.Collections.Specialized.NameValueCollection" />, используемая при инициализации объекта.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
		///   <paramref name="configurationValues" /> включает один или более нераспознанных значений.</exception>
		// Token: 0x06000342 RID: 834 RVA: 0x00009084 File Offset: 0x00007284
		[MonoTODO]
		public override void Initialize(string name, NameValueCollection configurationValues)
		{
			base.Initialize(name, configurationValues);
			this.keyContainerName = configurationValues["keyContainerName"];
			this.cspProviderName = configurationValues["cspProviderName"];
			string text = configurationValues["useMachineContainer"];
			if (text != null && text.ToLower() == "true")
			{
				this.useMachineContainer = true;
			}
			text = configurationValues["useOAEP"];
			if (text != null && text.ToLower() == "true")
			{
				this.useOAEP = true;
			}
		}

		/// <summary>Добавляет ключ к контейнеру ключа RSA.</summary>
		/// <param name="keySize">Размер добавляемого ключа.</param>
		/// <param name="exportable">Значение <see langword="true" /> указывает, что ключ может быть экспортирован, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000343 RID: 835 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		public void AddKey(int keySize, bool exportable)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет ключ из контейнера ключа RSA.</summary>
		// Token: 0x06000344 RID: 836 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		public void DeleteKey()
		{
			throw new NotImplementedException();
		}

		/// <summary>Экспортирует ключ RSA из контейнера ключа.</summary>
		/// <param name="xmlFileName">Полный путь для экспорта ключа.</param>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> указывает, что частные параметры экспортированы, в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла возникла ошибка.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> задает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06000345 RID: 837 RVA: 0x0000910C File Offset: 0x0000730C
		[MonoTODO]
		public void ExportKey(string xmlFileName, bool includePrivateParameters)
		{
			string value = this.GetProvider().ToXmlString(includePrivateParameters);
			StreamWriter streamWriter = new StreamWriter(new FileStream(xmlFileName, FileMode.OpenOrCreate, FileAccess.Write));
			streamWriter.Write(value);
			streamWriter.Close();
		}

		/// <summary>Импортирует ключ RSA в ключ контейнера.</summary>
		/// <param name="xmlFileName">Имя файла и путь, откуда следует импортировать ключ.</param>
		/// <param name="exportable">Значение <see langword="true" /> указывает, что ключ может быть экспортирован, в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла возникла ошибка.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> указывает файл, доступный только для записи.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> задает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06000346 RID: 838 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		public void ImportKey(string xmlFileName, bool exportable)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает имя API шифрования Windows (API шифрования) поставщика служб шифрования (CSP).</summary>
		/// <returns>Имя поставщика служб шифрования CryptoAPI.</returns>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000913F File Offset: 0x0000733F
		public string CspProviderName
		{
			get
			{
				return this.cspProviderName;
			}
		}

		/// <summary>Возвращает имя контейнера ключа.</summary>
		/// <returns>Имя контейнера ключа.</returns>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00009147 File Offset: 0x00007347
		public string KeyContainerName
		{
			get
			{
				return this.keyContainerName;
			}
		}

		/// <summary>Возвращает открытый ключ, используемый поставщиком.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.RSAParameters" /> содержит открытый ключ, используемый поставщиком.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000914F File Offset: 0x0000734F
		public RSAParameters RsaPublicKey
		{
			get
			{
				return this.GetProvider().ExportParameters(false);
			}
		}

		/// <summary>Возвращает значение, указывающее на то, использует ли объект <see cref="T:System.Configuration.RsaProtectedConfigurationProvider" /> контейнер ключа машины.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Configuration.RsaProtectedConfigurationProvider" /> использует контейнер ключа машины, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000915D File Offset: 0x0000735D
		public bool UseMachineContainer
		{
			get
			{
				return this.useMachineContainer;
			}
		}

		/// <summary>Возвращает значение, которое указывает на то, использует ли поставщик данные обмена ключа Optimal Asymmetric Encryption Padding (OAEP).</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Configuration.RsaProtectedConfigurationProvider" /> использует данные обмена ключа Optimal Asymmetric Encryption Padding (OAEP), в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00009165 File Offset: 0x00007365
		public bool UseOAEP
		{
			get
			{
				return this.useOAEP;
			}
		}

		/// <summary>Возвращает значение, указывающее, использует ли поставщик FIPS.</summary>
		/// <returns>Значение <see langword="true" />, если поставщик использует FIPS; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00009170 File Offset: 0x00007370
		public bool UseFIPS
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		// Token: 0x0400012F RID: 303
		private string cspProviderName;

		// Token: 0x04000130 RID: 304
		private string keyContainerName;

		// Token: 0x04000131 RID: 305
		private bool useMachineContainer;

		// Token: 0x04000132 RID: 306
		private bool useOAEP;

		// Token: 0x04000133 RID: 307
		private RSACryptoServiceProvider rsa;
	}
}
