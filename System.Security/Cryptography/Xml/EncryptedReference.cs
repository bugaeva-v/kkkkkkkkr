using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет используемый в XML-шифровании абстрактный базовый класс, от которого наследуются классы <see cref="T:System.Security.Cryptography.Xml.CipherReference" />, <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> и <see cref="T:System.Security.Cryptography.Xml.DataReference" />.</summary>
	// Token: 0x02000036 RID: 54
	public abstract class EncryptedReference
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		// Token: 0x0600011B RID: 283 RVA: 0x000061E4 File Offset: 0x000043E4
		protected EncryptedReference() : this(string.Empty, new TransformChain())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" /> с помощью указанного универсального кода ресурса (URI).</summary>
		/// <param name="uri">Код URI, указывающий на шифруемые данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="uri" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600011C RID: 284 RVA: 0x000061F6 File Offset: 0x000043F6
		protected EncryptedReference(string uri) : this(uri, new TransformChain())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" /> указанным URI и цепочкой преобразований.</summary>
		/// <param name="uri">Код URI, указывающий на шифруемые данные.</param>
		/// <param name="transformChain">Объект <see cref="T:System.Security.Cryptography.Xml.TransformChain" />, описывающий преобразования, которые применяются к шифруемым данным.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="uri" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600011D RID: 285 RVA: 0x00006204 File Offset: 0x00004404
		protected EncryptedReference(string uri, TransformChain transformChain)
		{
			this.TransformChain = transformChain;
			this.Uri = uri;
			this._cachedXml = null;
		}

		/// <summary>Получает или задает универсальный код ресурса (URI) объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		/// <returns>URI объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства <see cref="P:System.Security.Cryptography.Xml.EncryptedReference.Uri" /> задано значение <see langword="null" />.</exception>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006221 File Offset: 0x00004421
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00006229 File Offset: 0x00004429
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("A Uri attribute is required for a CipherReference element.");
				}
				this._uri = value;
				this._cachedXml = null;
			}
		}

		/// <summary>Получает или задает цепочку преобразований объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.TransformChain" />, описывающий преобразования, которые применяются к зашифрованным данным.</returns>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00006247 File Offset: 0x00004447
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00006262 File Offset: 0x00004462
		public TransformChain TransformChain
		{
			get
			{
				if (this._transformChain == null)
				{
					this._transformChain = new TransformChain();
				}
				return this._transformChain;
			}
			set
			{
				this._transformChain = value;
				this._cachedXml = null;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.Transform" /> в цепочку преобразований объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		/// <param name="transform">Объект <see cref="T:System.Security.Cryptography.Xml.Transform" />, добавляемый в цепочку преобразований.</param>
		// Token: 0x06000122 RID: 290 RVA: 0x00006272 File Offset: 0x00004472
		public void AddTransform(Transform transform)
		{
			this.TransformChain.Add(transform);
		}

		/// <summary>Получает или задает ссылочный тип.</summary>
		/// <returns>Ссылочный тип зашифрованных данных.</returns>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00006288 File Offset: 0x00004488
		protected string ReferenceType
		{
			get
			{
				return this._referenceType;
			}
			set
			{
				this._referenceType = value;
				this._cachedXml = null;
			}
		}

		/// <summary>Получает значение, указывающее, является ли кэш допустимым.</summary>
		/// <returns>Значение <see langword="true" />, если кэш является допустимым; в противном случае — значение <see langword="false" /> .</returns>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006298 File Offset: 0x00004498
		protected internal bool CacheValid
		{
			get
			{
				return this._cachedXml != null;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, представляющий значения элемента <see langword="&lt;EncryptedReference&gt;" /> в XML-шифровании.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.Xml.EncryptedReference.ReferenceType" /> — <see langword="null" />.</exception>
		// Token: 0x06000126 RID: 294 RVA: 0x000062A4 File Offset: 0x000044A4
		public virtual XmlElement GetXml()
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

		// Token: 0x06000127 RID: 295 RVA: 0x000062D4 File Offset: 0x000044D4
		internal XmlElement GetXml(XmlDocument document)
		{
			if (this.ReferenceType == null)
			{
				throw new CryptographicException("The Reference type must be set in an EncryptedReference object.");
			}
			XmlElement xmlElement = document.CreateElement(this.ReferenceType, "http://www.w3.org/2001/04/xmlenc#");
			if (!string.IsNullOrEmpty(this._uri))
			{
				xmlElement.SetAttribute("URI", this._uri);
			}
			if (this.TransformChain.Count > 0)
			{
				xmlElement.AppendChild(this.TransformChain.GetXml(document, "http://www.w3.org/2000/09/xmldsig#"));
			}
			return xmlElement;
		}

		/// <summary>Загружает XML-элемент в объект <see cref="T:System.Security.Cryptography.Xml.EncryptedReference" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Xml.XmlElement" />, представляющий XML-элемент.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000128 RID: 296 RVA: 0x0000634C File Offset: 0x0000454C
		public virtual void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.ReferenceType = value.LocalName;
			string attribute = Utils.GetAttribute(value, "URI", "http://www.w3.org/2001/04/xmlenc#");
			if (attribute == null)
			{
				throw new ArgumentNullException("A Uri attribute is required for a CipherReference element.");
			}
			this.Uri = attribute;
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(value.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
			XmlNode xmlNode = value.SelectSingleNode("ds:Transforms", xmlNamespaceManager);
			if (xmlNode != null)
			{
				this.TransformChain.LoadXml(xmlNode as XmlElement);
			}
			this._cachedXml = value;
		}

		// Token: 0x04000170 RID: 368
		private string _uri;

		// Token: 0x04000171 RID: 369
		private string _referenceType;

		// Token: 0x04000172 RID: 370
		private TransformChain _transformChain;

		// Token: 0x04000173 RID: 371
		internal XmlElement _cachedXml;
	}
}
