using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Указывает порядок операций XML-шифрования и цифровой XML-подписи, если они выполняются в одном документе.</summary>
	// Token: 0x0200005E RID: 94
	public class XmlDecryptionTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</summary>
		// Token: 0x06000312 RID: 786 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
		public XmlDecryptionTransform()
		{
			base.Algorithm = "http://www.w3.org/2002/07/decrypt#XML";
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000ED0D File Offset: 0x0000CF0D
		private ArrayList ExceptUris
		{
			get
			{
				if (this._arrayListUri == null)
				{
					this._arrayListUri = new ArrayList();
				}
				return this._arrayListUri;
			}
		}

		/// <summary>Определяет, совпадает ли атрибут идентификатора объекта <see cref="T:System.Xml.XmlElement" /> с указанным значением.</summary>
		/// <param name="inputElement">Объект <see cref="T:System.Xml.XmlElement" /> с атрибутом идентификатора, сравниваемый с параметром <paramref name="idValue" />.</param>
		/// <param name="idValue">Значение для сравнения с атрибутом идентификатора параметра <paramref name="inputElement" />.</param>
		/// <returns>Значение <see langword="true" />, если атрибут идентификатора параметра <paramref name="inputElement" /> совпадает с параметром <paramref name="idValue" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000314 RID: 788 RVA: 0x0000ED28 File Offset: 0x0000CF28
		protected virtual bool IsTargetElement(XmlElement inputElement, string idValue)
		{
			return inputElement != null && (inputElement.GetAttribute("Id") == idValue || inputElement.GetAttribute("id") == idValue || inputElement.GetAttribute("ID") == idValue);
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />, содержащий сведения о ключах, необходимых для расшифровки XML-документа.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />, содержащий сведения о ключах, необходимых для расшифровки XML-документа.</returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000ED78 File Offset: 0x0000CF78
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000EDDD File Offset: 0x0000CFDD
		public EncryptedXml EncryptedXml
		{
			get
			{
				if (this._exml != null)
				{
					return this._exml;
				}
				Reference reference = base.Reference;
				SignedXml signedXml = (reference == null) ? base.SignedXml : reference.SignedXml;
				if (signedXml == null || signedXml.EncryptedXml == null)
				{
					this._exml = new EncryptedXml(this._containingDocument);
				}
				else
				{
					this._exml = signedXml.EncryptedXml;
				}
				return this._exml;
			}
			set
			{
				this._exml = value;
			}
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDecryptionTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDecryptionTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000EDE6 File Offset: 0x0000CFE6
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDecryptionTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDecryptionTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000EDEE File Offset: 0x0000CFEE
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Добавляет универсальный код ресурса (URI), который следует исключить из обработки.</summary>
		/// <param name="uri">Универсальный код ресурса (URI), который следует исключить из обработки.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="uri" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000319 RID: 793 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
		public void AddExceptUri(string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			this.ExceptUris.Add(uri);
		}

		/// <summary>Анализирует указанный объект <see cref="T:System.Xml.XmlNodeList" /> как связанный с преобразованием содержимого элемент <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, указывающий связанное с преобразованием содержимое для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="nodeList" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Значение универсального кода ресурса (URI) объекта <see cref="T:System.Xml.XmlNode" /> в <paramref name="nodeList" /> не найдено.  
		///
		/// или - 
		/// Длина значения универсального кода ресурса (URI) объекта <see cref="T:System.Xml.XmlNode" /> в <paramref name="nodeList" /> равна 0.  
		///
		/// или - 
		/// Первым знаком значения универсального кода ресурса (URI) объекта <see cref="T:System.Xml.XmlNode" /> в <paramref name="nodeList" /> не является знак решетки "#".</exception>
		// Token: 0x0600031A RID: 794 RVA: 0x0000EE14 File Offset: 0x0000D014
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList == null)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
			this.ExceptUris.Clear();
			foreach (object obj in nodeList)
			{
				XmlElement xmlElement = ((XmlNode)obj) as XmlElement;
				if (xmlElement != null)
				{
					if (!(xmlElement.LocalName == "Except") || !(xmlElement.NamespaceURI == "http://www.w3.org/2002/07/decrypt#"))
					{
						throw new CryptographicException("Unknown transform has been encountered.");
					}
					string attribute = Utils.GetAttribute(xmlElement, "URI", "http://www.w3.org/2002/07/decrypt#");
					if (attribute == null || attribute.Length == 0 || attribute[0] != '#')
					{
						throw new CryptographicException("A Uri attribute is required for a CipherReference element.");
					}
					if (!Utils.VerifyAttributes(xmlElement, "URI"))
					{
						throw new CryptographicException("Unknown transform has been encountered.");
					}
					string value = Utils.ExtractIdFromLocalUri(attribute);
					this.ExceptUris.Add(value);
				}
			}
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x0600031B RID: 795 RVA: 0x0000EF20 File Offset: 0x0000D120
		protected override XmlNodeList GetInnerXml()
		{
			if (this.ExceptUris.Count == 0)
			{
				return null;
			}
			XmlDocument xmlDocument = new XmlDocument();
			XmlElement xmlElement = xmlDocument.CreateElement("Transform", "http://www.w3.org/2000/09/xmldsig#");
			if (!string.IsNullOrEmpty(base.Algorithm))
			{
				xmlElement.SetAttribute("Algorithm", base.Algorithm);
			}
			foreach (object obj in this.ExceptUris)
			{
				string value = (string)obj;
				XmlElement xmlElement2 = xmlDocument.CreateElement("Except", "http://www.w3.org/2002/07/decrypt#");
				xmlElement2.SetAttribute("URI", value);
				xmlElement.AppendChild(xmlElement2);
			}
			return xmlElement.ChildNodes;
		}

		/// <summary>При переопределении в производном классе загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDecryptionTransform" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600031C RID: 796 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		public override void LoadInput(object obj)
		{
			if (obj is Stream)
			{
				this.LoadStreamInput((Stream)obj);
				return;
			}
			if (obj is XmlDocument)
			{
				this.LoadXmlDocumentInput((XmlDocument)obj);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000F014 File Offset: 0x0000D214
		private void LoadStreamInput(Stream stream)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			XmlResolver xmlResolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			XmlReader reader = Utils.PreProcessStreamInput(stream, xmlResolver, base.BaseURI);
			xmlDocument.Load(reader);
			this._containingDocument = xmlDocument;
			this._nsm = new XmlNamespaceManager(this._containingDocument.NameTable);
			this._nsm.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			this._encryptedDataList = xmlDocument.SelectNodes("//enc:EncryptedData", this._nsm);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		private void LoadXmlDocumentInput(XmlDocument document)
		{
			if (document == null)
			{
				throw new ArgumentNullException("document");
			}
			this._containingDocument = document;
			this._nsm = new XmlNamespaceManager(document.NameTable);
			this._nsm.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			this._encryptedDataList = document.SelectNodes("//enc:EncryptedData", this._nsm);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F110 File Offset: 0x0000D310
		private void ReplaceEncryptedData(XmlElement encryptedDataElement, byte[] decrypted)
		{
			XmlNode parentNode = encryptedDataElement.ParentNode;
			if (parentNode.NodeType == XmlNodeType.Document)
			{
				parentNode.InnerXml = this.EncryptedXml.Encoding.GetString(decrypted);
				return;
			}
			this.EncryptedXml.ReplaceData(encryptedDataElement, decrypted);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F154 File Offset: 0x0000D354
		private bool ProcessEncryptedDataItem(XmlElement encryptedDataElement)
		{
			if (this.ExceptUris.Count > 0)
			{
				for (int i = 0; i < this.ExceptUris.Count; i++)
				{
					if (this.IsTargetElement(encryptedDataElement, (string)this.ExceptUris[i]))
					{
						return false;
					}
				}
			}
			EncryptedData encryptedData = new EncryptedData();
			encryptedData.LoadXml(encryptedDataElement);
			SymmetricAlgorithm decryptionKey = this.EncryptedXml.GetDecryptionKey(encryptedData, null);
			if (decryptionKey == null)
			{
				throw new CryptographicException("Unable to retrieve the decryption key.");
			}
			byte[] decrypted = this.EncryptedXml.DecryptData(encryptedData, decryptionKey);
			this.ReplaceEncryptedData(encryptedDataElement, decrypted);
			return true;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
		private void ProcessElementRecursively(XmlNodeList encryptedDatas)
		{
			if (encryptedDatas == null || encryptedDatas.Count == 0)
			{
				return;
			}
			Queue queue = new Queue();
			foreach (object obj in encryptedDatas)
			{
				XmlNode obj2 = (XmlNode)obj;
				queue.Enqueue(obj2);
			}
			for (XmlNode xmlNode = queue.Dequeue() as XmlNode; xmlNode != null; xmlNode = (queue.Dequeue() as XmlNode))
			{
				XmlElement xmlElement = xmlNode as XmlElement;
				if (xmlElement != null && xmlElement.LocalName == "EncryptedData" && xmlElement.NamespaceURI == "http://www.w3.org/2001/04/xmlenc#")
				{
					XmlNode nextSibling = xmlElement.NextSibling;
					XmlNode parentNode = xmlElement.ParentNode;
					if (this.ProcessEncryptedDataItem(xmlElement))
					{
						XmlNode xmlNode2 = parentNode.FirstChild;
						while (xmlNode2 != null && xmlNode2.NextSibling != nextSibling)
						{
							xmlNode2 = xmlNode2.NextSibling;
						}
						if (xmlNode2 != null)
						{
							XmlNodeList xmlNodeList = xmlNode2.SelectNodes("//enc:EncryptedData", this._nsm);
							if (xmlNodeList.Count > 0)
							{
								foreach (object obj3 in xmlNodeList)
								{
									XmlNode obj4 = (XmlNode)obj3;
									queue.Enqueue(obj4);
								}
							}
						}
					}
				}
				if (queue.Count == 0)
				{
					break;
				}
			}
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось найти ключ расшифровки.</exception>
		// Token: 0x06000322 RID: 802 RVA: 0x0000F360 File Offset: 0x0000D560
		public override object GetOutput()
		{
			if (this._encryptedDataList != null)
			{
				this.ProcessElementRecursively(this._encryptedDataList);
			}
			Utils.AddNamespaces(this._containingDocument.DocumentElement, base.PropagatedNamespaces);
			return this._containingDocument;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.Xml.XmlNodeList" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.Xml.XmlNodeList" />.</exception>
		// Token: 0x06000323 RID: 803 RVA: 0x0000F392 File Offset: 0x0000D592
		public override object GetOutput(Type type)
		{
			if (type == typeof(XmlDocument))
			{
				return (XmlDocument)this.GetOutput();
			}
			throw new ArgumentException("The input type was invalid for this transform.", "type");
		}

		// Token: 0x04000234 RID: 564
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlDocument)
		};

		// Token: 0x04000235 RID: 565
		private Type[] _outputTypes = new Type[]
		{
			typeof(XmlDocument)
		};

		// Token: 0x04000236 RID: 566
		private XmlNodeList _encryptedDataList;

		// Token: 0x04000237 RID: 567
		private ArrayList _arrayListUri;

		// Token: 0x04000238 RID: 568
		private EncryptedXml _exml;

		// Token: 0x04000239 RID: 569
		private XmlDocument _containingDocument;

		// Token: 0x0400023A RID: 570
		private XmlNamespaceManager _nsm;

		// Token: 0x0400023B RID: 571
		private const string XmlDecryptionTransformNamespaceUrl = "http://www.w3.org/2002/07/decrypt#";
	}
}
