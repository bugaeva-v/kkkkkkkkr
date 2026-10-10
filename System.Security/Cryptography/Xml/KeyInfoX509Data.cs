using System;
using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет подэлемент <see langword="&lt;X509Data&gt;" /> элемента <see langword="&lt;KeyInfo&gt;" /> подписи XMLDSIG или XML-шифрования.</summary>
	// Token: 0x02000046 RID: 70
	public class KeyInfoX509Data : KeyInfoClause
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		// Token: 0x060001CF RID: 463 RVA: 0x00008215 File Offset: 0x00006415
		public KeyInfoX509Data()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" /> с помощью указанного кодирования ASN.1 DER сертификата X.509v3.</summary>
		/// <param name="rgbCert">Кодирование ASN.1 DER объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, с помощью которого инициализируется новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		// Token: 0x060001D0 RID: 464 RVA: 0x0000849C File Offset: 0x0000669C
		public KeyInfoX509Data(byte[] rgbCert)
		{
			X509Certificate2 certificate = new X509Certificate2(rgbCert);
			this.AddCertificate(certificate);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" /> из указанного сертификата X.509v3.</summary>
		/// <param name="cert">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, с помощью которого инициализируется новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="cert" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060001D1 RID: 465 RVA: 0x000084BD File Offset: 0x000066BD
		public KeyInfoX509Data(X509Certificate cert)
		{
			this.AddCertificate(cert);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" /> из указанного сертификата X.509v3.</summary>
		/// <param name="cert">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, с помощью которого инициализируется новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		/// <param name="includeOption">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509IncludeOption" />, задающее длину цепочки сертификатов, которую необходимо включить.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="cert" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат имеет только частичную цепочку сертификатов.</exception>
		// Token: 0x060001D2 RID: 466 RVA: 0x000084CC File Offset: 0x000066CC
		public KeyInfoX509Data(X509Certificate cert, X509IncludeOption includeOption)
		{
			if (cert == null)
			{
				throw new ArgumentNullException("cert");
			}
			X509Certificate2 certificate = new X509Certificate2(cert);
			switch (includeOption)
			{
			case X509IncludeOption.ExcludeRoot:
			{
				X509Chain x509Chain = new X509Chain();
				x509Chain.Build(certificate);
				if (x509Chain.ChainStatus.Length != 0 && (x509Chain.ChainStatus[0].Status & X509ChainStatusFlags.PartialChain) == X509ChainStatusFlags.PartialChain)
				{
					throw new CryptographicException("A certificate chain could not be built to a trusted root authority.");
				}
				X509ChainElementCollection chainElements = x509Chain.ChainElements;
				for (int i = 0; i < (Utils.IsSelfSigned(x509Chain) ? 1 : (chainElements.Count - 1)); i++)
				{
					this.AddCertificate(chainElements[i].Certificate);
				}
				return;
			}
			case X509IncludeOption.EndCertOnly:
				this.AddCertificate(certificate);
				return;
			case X509IncludeOption.WholeChain:
			{
				X509Chain x509Chain = new X509Chain();
				x509Chain.Build(certificate);
				if (x509Chain.ChainStatus.Length != 0 && (x509Chain.ChainStatus[0].Status & X509ChainStatusFlags.PartialChain) == X509ChainStatusFlags.PartialChain)
				{
					throw new CryptographicException("A certificate chain could not be built to a trusted root authority.");
				}
				X509ChainElementCollection chainElements = x509Chain.ChainElements;
				foreach (X509ChainElement x509ChainElement in chainElements)
				{
					this.AddCertificate(x509ChainElement.Certificate);
				}
				return;
			}
			default:
				return;
			}
		}

		/// <summary>Получает список сертификатов X.509v3, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <returns>Список сертификатов X.509, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000085FD File Offset: 0x000067FD
		public ArrayList Certificates
		{
			get
			{
				return this._certificates;
			}
		}

		/// <summary>Добавляет заданный сертификат X.509v3 в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, добавляемый в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060001D4 RID: 468 RVA: 0x00008608 File Offset: 0x00006808
		public void AddCertificate(X509Certificate certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (this._certificates == null)
			{
				this._certificates = new ArrayList();
			}
			X509Certificate2 value = new X509Certificate2(certificate);
			this._certificates.Add(value);
		}

		/// <summary>Получает список идентификаторов ключей субъектов (SKI), содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <returns>Список идентификаторов ключей субъектов (SKI), содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000864A File Offset: 0x0000684A
		public ArrayList SubjectKeyIds
		{
			get
			{
				return this._subjectKeyIds;
			}
		}

		/// <summary>Добавляет указанный массив байтов идентификатора ключа субъекта (SKI) в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <param name="subjectKeyId">Массив байтов, представляющий идентификатор ключа субъекта (SKI) для добавления в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		// Token: 0x060001D6 RID: 470 RVA: 0x00008652 File Offset: 0x00006852
		public void AddSubjectKeyId(byte[] subjectKeyId)
		{
			if (this._subjectKeyIds == null)
			{
				this._subjectKeyIds = new ArrayList();
			}
			this._subjectKeyIds.Add(subjectKeyId);
		}

		/// <summary>Добавляет указанную строку идентификатора ключа субъекта (SKI) в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <param name="subjectKeyId">Строка, представляющая идентификатор ключа субъекта (SKI) для добавления в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		// Token: 0x060001D7 RID: 471 RVA: 0x00008674 File Offset: 0x00006874
		public void AddSubjectKeyId(string subjectKeyId)
		{
			if (this._subjectKeyIds == null)
			{
				this._subjectKeyIds = new ArrayList();
			}
			this._subjectKeyIds.Add(Utils.DecodeHexString(subjectKeyId));
		}

		/// <summary>Получает список имен субъектов сущностей, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <returns>Список имен субъектов сущностей, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</returns>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000869B File Offset: 0x0000689B
		public ArrayList SubjectNames
		{
			get
			{
				return this._subjectNames;
			}
		}

		/// <summary>Добавляет имя субъекта сущности, предоставленное сертификатом X.509v3 объекту <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <param name="subjectName">Имя сущности, предоставленное сертификатом X.509 для добавления в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		// Token: 0x060001D9 RID: 473 RVA: 0x000086A3 File Offset: 0x000068A3
		public void AddSubjectName(string subjectName)
		{
			if (this._subjectNames == null)
			{
				this._subjectNames = new ArrayList();
			}
			this._subjectNames.Add(subjectName);
		}

		/// <summary>Получает список структур <see cref="T:System.Security.Cryptography.Xml.X509IssuerSerial" />, представляющих пару "имя поставщика-серийный номер".</summary>
		/// <returns>Список структур <see cref="T:System.Security.Cryptography.Xml.X509IssuerSerial" />, представляющих пару "имя поставщика-серийный номер".</returns>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000086C5 File Offset: 0x000068C5
		public ArrayList IssuerSerials
		{
			get
			{
				return this._issuerSerials;
			}
		}

		/// <summary>Добавляет указанную пару "имя поставщика-серийный номер" в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <param name="issuerName">Часть пары с именем поставщика, добавляемая в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		/// <param name="serialNumber">Часть пары с серийным номером, добавляемая в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		// Token: 0x060001DB RID: 475 RVA: 0x000086D0 File Offset: 0x000068D0
		public void AddIssuerSerial(string issuerName, string serialNumber)
		{
			if (string.IsNullOrEmpty(issuerName))
			{
				throw new ArgumentException("String cannot be empty or null.", "issuerName");
			}
			if (string.IsNullOrEmpty(serialNumber))
			{
				throw new ArgumentException("String cannot be empty or null.", "serialNumber");
			}
			BigInteger bigInteger;
			if (!BigInteger.TryParse(serialNumber, NumberStyles.AllowHexSpecifier, NumberFormatInfo.CurrentInfo, out bigInteger))
			{
				throw new ArgumentException("X509 issuer serial number is invalid.", "serialNumber");
			}
			if (this._issuerSerials == null)
			{
				this._issuerSerials = new ArrayList();
			}
			this._issuerSerials.Add(Utils.CreateX509IssuerSerial(issuerName, bigInteger.ToString()));
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008768 File Offset: 0x00006968
		internal void InternalAddIssuerSerial(string issuerName, string serialNumber)
		{
			if (this._issuerSerials == null)
			{
				this._issuerSerials = new ArrayList();
			}
			this._issuerSerials.Add(Utils.CreateX509IssuerSerial(issuerName, serialNumber));
		}

		/// <summary>Получает или задает список отзыва сертификатов (CRL), содержащийся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <returns>Список отзыва сертификатов (CRL), содержащийся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00008795 File Offset: 0x00006995
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000879D File Offset: 0x0000699D
		public byte[] CRL
		{
			get
			{
				return this._CRL;
			}
			set
			{
				this._CRL = value;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000087A8 File Offset: 0x000069A8
		private void Clear()
		{
			this._CRL = null;
			if (this._subjectKeyIds != null)
			{
				this._subjectKeyIds.Clear();
			}
			if (this._subjectNames != null)
			{
				this._subjectNames.Clear();
			}
			if (this._issuerSerials != null)
			{
				this._issuerSerials.Clear();
			}
			if (this._certificates != null)
			{
				this._certificates.Clear();
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</returns>
		// Token: 0x060001E0 RID: 480 RVA: 0x00008808 File Offset: 0x00006A08
		public override XmlElement GetXml()
		{
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000882C File Offset: 0x00006A2C
		internal override XmlElement GetXml(XmlDocument xmlDocument)
		{
			XmlElement xmlElement = xmlDocument.CreateElement("X509Data", "http://www.w3.org/2000/09/xmldsig#");
			if (this._issuerSerials != null)
			{
				foreach (object obj in this._issuerSerials)
				{
					X509IssuerSerial x509IssuerSerial = (X509IssuerSerial)obj;
					XmlElement xmlElement2 = xmlDocument.CreateElement("X509IssuerSerial", "http://www.w3.org/2000/09/xmldsig#");
					XmlElement xmlElement3 = xmlDocument.CreateElement("X509IssuerName", "http://www.w3.org/2000/09/xmldsig#");
					xmlElement3.AppendChild(xmlDocument.CreateTextNode(x509IssuerSerial.IssuerName));
					xmlElement2.AppendChild(xmlElement3);
					XmlElement xmlElement4 = xmlDocument.CreateElement("X509SerialNumber", "http://www.w3.org/2000/09/xmldsig#");
					xmlElement4.AppendChild(xmlDocument.CreateTextNode(x509IssuerSerial.SerialNumber));
					xmlElement2.AppendChild(xmlElement4);
					xmlElement.AppendChild(xmlElement2);
				}
			}
			if (this._subjectKeyIds != null)
			{
				foreach (object obj2 in this._subjectKeyIds)
				{
					byte[] inArray = (byte[])obj2;
					XmlElement xmlElement5 = xmlDocument.CreateElement("X509SKI", "http://www.w3.org/2000/09/xmldsig#");
					xmlElement5.AppendChild(xmlDocument.CreateTextNode(Convert.ToBase64String(inArray)));
					xmlElement.AppendChild(xmlElement5);
				}
			}
			if (this._subjectNames != null)
			{
				foreach (object obj3 in this._subjectNames)
				{
					string text = (string)obj3;
					XmlElement xmlElement6 = xmlDocument.CreateElement("X509SubjectName", "http://www.w3.org/2000/09/xmldsig#");
					xmlElement6.AppendChild(xmlDocument.CreateTextNode(text));
					xmlElement.AppendChild(xmlElement6);
				}
			}
			if (this._certificates != null)
			{
				foreach (object obj4 in this._certificates)
				{
					X509Certificate x509Certificate = (X509Certificate)obj4;
					XmlElement xmlElement7 = xmlDocument.CreateElement("X509Certificate", "http://www.w3.org/2000/09/xmldsig#");
					xmlElement7.AppendChild(xmlDocument.CreateTextNode(Convert.ToBase64String(x509Certificate.GetRawCertData())));
					xmlElement.AppendChild(xmlElement7);
				}
			}
			if (this._CRL != null)
			{
				XmlElement xmlElement8 = xmlDocument.CreateElement("X509CRL", "http://www.w3.org/2000/09/xmldsig#");
				xmlElement8.AppendChild(xmlDocument.CreateTextNode(Convert.ToBase64String(this._CRL)));
				xmlElement.AppendChild(xmlElement8);
			}
			return xmlElement;
		}

		/// <summary>Выполняет анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" /> для сопоставления.</summary>
		/// <param name="element">Объект <see cref="T:System.Xml.XmlElement" />, определяющий состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoX509Data" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="element" /> не содержит узел &lt;<see langword="X509IssuerName" />&gt;.  
		///
		/// или - 
		/// Параметр <paramref name="element" /> не содержит узел &lt;<see langword="X509SerialNumber" />&gt;.</exception>
		// Token: 0x060001E2 RID: 482 RVA: 0x00008AD0 File Offset: 0x00006CD0
		public override void LoadXml(XmlElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(element.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
			XmlNodeList xmlNodeList = element.SelectNodes("ds:X509IssuerSerial", xmlNamespaceManager);
			XmlNodeList xmlNodeList2 = element.SelectNodes("ds:X509SKI", xmlNamespaceManager);
			XmlNodeList xmlNodeList3 = element.SelectNodes("ds:X509SubjectName", xmlNamespaceManager);
			XmlNodeList xmlNodeList4 = element.SelectNodes("ds:X509Certificate", xmlNamespaceManager);
			XmlNodeList xmlNodeList5 = element.SelectNodes("ds:X509CRL", xmlNamespaceManager);
			if (xmlNodeList5.Count == 0 && xmlNodeList.Count == 0 && xmlNodeList2.Count == 0 && xmlNodeList3.Count == 0 && xmlNodeList4.Count == 0)
			{
				throw new CryptographicException("Malformed element {0}.", "X509Data");
			}
			this.Clear();
			if (xmlNodeList5.Count != 0)
			{
				this._CRL = Convert.FromBase64String(Utils.DiscardWhiteSpaces(xmlNodeList5.Item(0).InnerText));
			}
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				XmlNode xmlNode2 = xmlNode.SelectSingleNode("ds:X509IssuerName", xmlNamespaceManager);
				XmlNode xmlNode3 = xmlNode.SelectSingleNode("ds:X509SerialNumber", xmlNamespaceManager);
				if (xmlNode2 == null || xmlNode3 == null)
				{
					throw new CryptographicException("Malformed element {0}.", "IssuerSerial");
				}
				this.InternalAddIssuerSerial(xmlNode2.InnerText.Trim(), xmlNode3.InnerText.Trim());
			}
			foreach (object obj2 in xmlNodeList2)
			{
				XmlNode xmlNode4 = (XmlNode)obj2;
				this.AddSubjectKeyId(Convert.FromBase64String(Utils.DiscardWhiteSpaces(xmlNode4.InnerText)));
			}
			foreach (object obj3 in xmlNodeList3)
			{
				XmlNode xmlNode5 = (XmlNode)obj3;
				this.AddSubjectName(xmlNode5.InnerText.Trim());
			}
			foreach (object obj4 in xmlNodeList4)
			{
				XmlNode xmlNode6 = (XmlNode)obj4;
				this.AddCertificate(new X509Certificate2(Convert.FromBase64String(Utils.DiscardWhiteSpaces(xmlNode6.InnerText))));
			}
		}

		// Token: 0x040001AB RID: 427
		private ArrayList _certificates;

		// Token: 0x040001AC RID: 428
		private ArrayList _issuerSerials;

		// Token: 0x040001AD RID: 429
		private ArrayList _subjectKeyIds;

		// Token: 0x040001AE RID: 430
		private ArrayList _subjectNames;

		// Token: 0x040001AF RID: 431
		private byte[] _CRL;
	}
}
