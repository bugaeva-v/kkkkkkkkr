using System;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет алгоритм преобразования лицензий, который используется для нормализации лицензий XrML для сигнатур.</summary>
	// Token: 0x02000067 RID: 103
	public class XmlLicenseTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		// Token: 0x0600036A RID: 874 RVA: 0x000109D8 File Offset: 0x0000EBD8
		public XmlLicenseTransform()
		{
			base.Algorithm = "urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform";
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="P:System.Security.Cryptography.Xml.XmlLicenseTransform.OutputTypes" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <returns>Массив типов, которые являются допустимыми входными значениями для метода <see cref="P:System.Security.Cryptography.Xml.XmlLicenseTransform.OutputTypes" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />; методу <see cref="P:System.Security.Cryptography.Xml.XmlLicenseTransform.OutputTypes" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00010A28 File Offset: 0x0000EC28
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Получает массив типов, которые являются допустимыми выходными значениями для метода <see cref="P:System.Security.Cryptography.Xml.XmlLicenseTransform.OutputTypes" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlLicenseTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00010A30 File Offset: 0x0000EC30
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Получает или задает дешифратор текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <returns>Дешифратор текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</returns>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00010A38 File Offset: 0x0000EC38
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00010A40 File Offset: 0x0000EC40
		public IRelDecryptor Decryptor
		{
			get
			{
				return this._relDecryptor;
			}
			set
			{
				this._relDecryptor = value;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00010A4C File Offset: 0x0000EC4C
		private void DecryptEncryptedGrants(XmlNodeList encryptedGrantList, IRelDecryptor decryptor)
		{
			int i = 0;
			int count = encryptedGrantList.Count;
			while (i < count)
			{
				XmlElement xmlElement = encryptedGrantList[i].SelectSingleNode("//r:encryptedGrant/enc:EncryptionMethod", this._namespaceManager) as XmlElement;
				XmlElement xmlElement2 = encryptedGrantList[i].SelectSingleNode("//r:encryptedGrant/dsig:KeyInfo", this._namespaceManager) as XmlElement;
				XmlElement xmlElement3 = encryptedGrantList[i].SelectSingleNode("//r:encryptedGrant/enc:CipherData", this._namespaceManager) as XmlElement;
				if (xmlElement != null && xmlElement2 != null && xmlElement3 != null)
				{
					EncryptionMethod encryptionMethod = new EncryptionMethod();
					KeyInfo keyInfo = new KeyInfo();
					CipherData cipherData = new CipherData();
					encryptionMethod.LoadXml(xmlElement);
					keyInfo.LoadXml(xmlElement2);
					cipherData.LoadXml(xmlElement3);
					MemoryStream memoryStream = null;
					Stream stream = null;
					StreamReader streamReader = null;
					try
					{
						memoryStream = new MemoryStream(cipherData.CipherValue);
						stream = this._relDecryptor.Decrypt(encryptionMethod, keyInfo, memoryStream);
						if (stream == null || stream.Length == 0L)
						{
							throw new CryptographicException("Unable to decrypt grant content.");
						}
						streamReader = new StreamReader(stream);
						string innerXml = streamReader.ReadToEnd();
						encryptedGrantList[i].ParentNode.InnerXml = innerXml;
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (stream != null)
						{
							stream.Close();
						}
						if (streamReader != null)
						{
							streamReader.Close();
						}
					}
				}
				i++;
			}
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x06000370 RID: 880 RVA: 0x0000F43E File Offset: 0x0000D63E
		protected override XmlNodeList GetInnerXml()
		{
			return null;
		}

		/// <summary>Возвращает выходные данные объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <returns>Выходные данные объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</returns>
		// Token: 0x06000371 RID: 881 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		public override object GetOutput()
		{
			return this._license;
		}

		/// <summary>Возвращает выходные данные объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.Xml.XmlDocument" />.</param>
		/// <returns>Выходные данные объекта <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.Xml.XmlDocument" />.</exception>
		// Token: 0x06000372 RID: 882 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		public override object GetOutput(Type type)
		{
			if (type != typeof(XmlDocument) && !type.IsSubclassOf(typeof(XmlDocument)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return this.GetOutput();
		}

		/// <summary>Выполняет анализ указанного объекта <see cref="T:System.Xml.XmlNodeList" /> ка связанного с преобразованием содержимого элемента <see langword="&lt;Transform&gt;" />; данный метод не поддерживается, поскольку объект <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" /> не содержит внутренних XML-элементов.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, который инкапсулирует преобразование для загрузки в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</param>
		// Token: 0x06000373 RID: 883 RVA: 0x0000F76F File Offset: 0x0000D96F
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList != null && nodeList.Count > 0)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlLicenseTransform" />. Входной объект должен принадлежать к типу <see cref="T:System.Xml.XmlDocument" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Контекст не был задан до вызова этого преобразования.  
		///
		/// или - 
		/// Элемент <see langword="&lt;issuer&gt;" /> не был задан до вызова этого преобразования.  
		///
		/// или - 
		/// Элемент <see langword="&lt;license&gt;" /> не был задан до вызова этого преобразования.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Security.Cryptography.Xml.XmlLicenseTransform.Decryptor" /> не было задано до вызова этого преобразования.</exception>
		// Token: 0x06000374 RID: 884 RVA: 0x00010C0C File Offset: 0x0000EE0C
		public override void LoadInput(object obj)
		{
			if (base.Context == null)
			{
				throw new CryptographicException("Null Context property encountered.");
			}
			this._license = new XmlDocument();
			this._license.PreserveWhitespace = true;
			this._namespaceManager = new XmlNamespaceManager(this._license.NameTable);
			this._namespaceManager.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
			this._namespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			this._namespaceManager.AddNamespace("r", "urn:mpeg:mpeg21:2003:01-REL-R-NS");
			XmlElement xmlElement = base.Context.SelectSingleNode("ancestor-or-self::r:issuer[1]", this._namespaceManager) as XmlElement;
			if (xmlElement == null)
			{
				throw new CryptographicException("Issuer node is required.");
			}
			XmlNode xmlNode = xmlElement.SelectSingleNode("descendant-or-self::dsig:Signature[1]", this._namespaceManager) as XmlElement;
			if (xmlNode != null)
			{
				xmlNode.ParentNode.RemoveChild(xmlNode);
			}
			XmlElement xmlElement2 = xmlElement.SelectSingleNode("ancestor-or-self::r:license[1]", this._namespaceManager) as XmlElement;
			if (xmlElement2 == null)
			{
				throw new CryptographicException("License node is required.");
			}
			XmlNodeList xmlNodeList = xmlElement2.SelectNodes("descendant-or-self::r:license[1]/r:issuer", this._namespaceManager);
			int i = 0;
			int count = xmlNodeList.Count;
			while (i < count)
			{
				if (xmlNodeList[i] != xmlElement && xmlNodeList[i].LocalName == "issuer" && xmlNodeList[i].NamespaceURI == "urn:mpeg:mpeg21:2003:01-REL-R-NS")
				{
					xmlNodeList[i].ParentNode.RemoveChild(xmlNodeList[i]);
				}
				i++;
			}
			XmlNodeList xmlNodeList2 = xmlElement2.SelectNodes("/r:license/r:grant/r:encryptedGrant", this._namespaceManager);
			if (xmlNodeList2.Count > 0)
			{
				if (this._relDecryptor == null)
				{
					throw new CryptographicException("IRelDecryptor is required.");
				}
				this.DecryptEncryptedGrants(xmlNodeList2, this._relDecryptor);
			}
			this._license.InnerXml = xmlElement2.OuterXml;
		}

		// Token: 0x0400025A RID: 602
		private Type[] _inputTypes = new Type[]
		{
			typeof(XmlDocument)
		};

		// Token: 0x0400025B RID: 603
		private Type[] _outputTypes = new Type[]
		{
			typeof(XmlDocument)
		};

		// Token: 0x0400025C RID: 604
		private XmlNamespaceManager _namespaceManager;

		// Token: 0x0400025D RID: 605
		private XmlDocument _license;

		// Token: 0x0400025E RID: 606
		private IRelDecryptor _relDecryptor;

		// Token: 0x0400025F RID: 607
		private const string ElementIssuer = "issuer";

		// Token: 0x04000260 RID: 608
		private const string NamespaceUriCore = "urn:mpeg:mpeg21:2003:01-REL-R-NS";
	}
}
