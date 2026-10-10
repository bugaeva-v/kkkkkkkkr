using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Инкапсулирует алгоритм шифрования, используемый для XML-шифрования.</summary>
	// Token: 0x02000039 RID: 57
	public class EncryptionMethod
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" />.</summary>
		// Token: 0x06000162 RID: 354 RVA: 0x000075DF File Offset: 0x000057DF
		public EncryptionMethod()
		{
			this._cachedXml = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" /> с указанием универсального кода ресурса (URI) алгоритма шифрования.</summary>
		/// <param name="algorithm">Универсальный код ресурса (URI), который описывает алгоритм, представленный экземпляром класса <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" />.</param>
		// Token: 0x06000163 RID: 355 RVA: 0x000075EE File Offset: 0x000057EE
		public EncryptionMethod(string algorithm)
		{
			this._algorithm = algorithm;
			this._cachedXml = null;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00007604 File Offset: 0x00005804
		private bool CacheValid
		{
			get
			{
				return this._cachedXml != null;
			}
		}

		/// <summary>Получает или задает размер ключа алгоритма, используемого для XML-шифрования.</summary>
		/// <returns>Размер ключа алгоритма, используемого для XML-шифрования.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства <see cref="P:System.Security.Cryptography.Xml.EncryptionMethod.KeySize" /> задано значение меньше 0.</exception>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000760F File Offset: 0x0000580F
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00007617 File Offset: 0x00005817
		public int KeySize
		{
			get
			{
				return this._keySize;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value", "The key size should be a non negative integer.");
				}
				this._keySize = value;
				this._cachedXml = null;
			}
		}

		/// <summary>Получает или задает универсальный код ресурса (URI), который описывает алгоритм, используемый для XML-шифрования.</summary>
		/// <returns>Универсальный код ресурса (URI), который описывает алгоритм, используемый для XML-шифрования.</returns>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000763B File Offset: 0x0000583B
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00007643 File Offset: 0x00005843
		public string KeyAlgorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
				this._cachedXml = null;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Xml.XmlElement" />, который инкапсулирует экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, который инкапсулирует экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" />.</returns>
		// Token: 0x06000169 RID: 361 RVA: 0x00007654 File Offset: 0x00005854
		public XmlElement GetXml()
		{
			if (this.CacheValid)
			{
				return this._cachedXml;
			}
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007684 File Offset: 0x00005884
		internal XmlElement GetXml(XmlDocument document)
		{
			XmlElement xmlElement = document.CreateElement("EncryptionMethod", "http://www.w3.org/2001/04/xmlenc#");
			if (!string.IsNullOrEmpty(this._algorithm))
			{
				xmlElement.SetAttribute("Algorithm", this._algorithm);
			}
			if (this._keySize > 0)
			{
				XmlElement xmlElement2 = document.CreateElement("KeySize", "http://www.w3.org/2001/04/xmlenc#");
				xmlElement2.AppendChild(document.CreateTextNode(this._keySize.ToString(null, null)));
				xmlElement.AppendChild(xmlElement2);
			}
			return xmlElement;
		}

		/// <summary>Выполняет синтаксический анализ указанного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionMethod" /> таким образом, чтобы оно совпадало с состоянием проанализированного объекта.</summary>
		/// <param name="value">Анализируемый объект <see cref="T:System.Xml.XmlElement" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Размер ключа, выраженный как значение параметра <paramref name="value" />, меньше 0.</exception>
		// Token: 0x0600016B RID: 363 RVA: 0x00007700 File Offset: 0x00005900
		public void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(value.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			this._algorithm = Utils.GetAttribute(value, "Algorithm", "http://www.w3.org/2001/04/xmlenc#");
			XmlNode xmlNode = value.SelectSingleNode("enc:KeySize", xmlNamespaceManager);
			if (xmlNode != null)
			{
				this.KeySize = Convert.ToInt32(Utils.DiscardWhiteSpaces(xmlNode.InnerText), null);
			}
			this._cachedXml = value;
		}

		// Token: 0x04000199 RID: 409
		private XmlElement _cachedXml;

		// Token: 0x0400019A RID: 410
		private int _keySize;

		// Token: 0x0400019B RID: 411
		private string _algorithm;
	}
}
