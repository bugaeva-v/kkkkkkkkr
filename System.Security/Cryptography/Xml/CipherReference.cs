using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;CipherReference&gt;" /> в XML-шифровании. Этот класс не наследуется.</summary>
	// Token: 0x0200002C RID: 44
	public sealed class CipherReference : EncryptedReference
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.CipherReference" />.</summary>
		// Token: 0x060000E1 RID: 225 RVA: 0x000049E6 File Offset: 0x00002BE6
		public CipherReference()
		{
			base.ReferenceType = "CipherReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.CipherReference" /> с помощью указанного универсального кода ресурса (URI).</summary>
		/// <param name="uri">Код URI, указывающий на зашифрованные данные.</param>
		// Token: 0x060000E2 RID: 226 RVA: 0x000049F9 File Offset: 0x00002BF9
		public CipherReference(string uri) : base(uri)
		{
			base.ReferenceType = "CipherReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.CipherReference" /> указанным URI и сведениями о цепочке преобразований.</summary>
		/// <param name="uri">Код URI, указывающий на зашифрованные данные.</param>
		/// <param name="transformChain">Объект <see cref="T:System.Security.Cryptography.Xml.TransformChain" />, описывающий преобразования, которые применяются к зашифрованным данным.</param>
		// Token: 0x060000E3 RID: 227 RVA: 0x00004A0D File Offset: 0x00002C0D
		public CipherReference(string uri, TransformChain transformChain) : base(uri, transformChain)
		{
			base.ReferenceType = "CipherReference";
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004A22 File Offset: 0x00002C22
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00004A34 File Offset: 0x00002C34
		internal byte[] CipherValue
		{
			get
			{
				if (!base.CacheValid)
				{
					return null;
				}
				return this._cipherValue;
			}
			set
			{
				this._cipherValue = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.CipherReference" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, представляющий элемент <see langword="&lt;CipherReference&gt;" /> в XML-шифровании.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение <see cref="T:System.Security.Cryptography.Xml.CipherReference" /> равно <see langword="null" />.</exception>
		// Token: 0x060000E6 RID: 230 RVA: 0x00004A40 File Offset: 0x00002C40
		public override XmlElement GetXml()
		{
			if (base.CacheValid)
			{
				return this._cachedXml;
			}
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004A70 File Offset: 0x00002C70
		internal new XmlElement GetXml(XmlDocument document)
		{
			if (base.ReferenceType == null)
			{
				throw new CryptographicException("The Reference type must be set in an EncryptedReference object.");
			}
			XmlElement xmlElement = document.CreateElement(base.ReferenceType, "http://www.w3.org/2001/04/xmlenc#");
			if (!string.IsNullOrEmpty(base.Uri))
			{
				xmlElement.SetAttribute("URI", base.Uri);
			}
			if (base.TransformChain.Count > 0)
			{
				xmlElement.AppendChild(base.TransformChain.GetXml(document, "http://www.w3.org/2001/04/xmlenc#"));
			}
			return xmlElement;
		}

		/// <summary>Загружает сведения XML в элемент <see langword="&lt;CipherReference&gt;" /> при XML-шифровании.</summary>
		/// <param name="value">Объект <see cref="T:System.Xml.XmlElement" />, который представляет XML-элемент, используемый в качестве ссылки.</param>
		/// <exception cref="T:System.ArgumentNullException">Предоставленное значение параметра <paramref name="value" /> равно <see langword="null" />.</exception>
		// Token: 0x060000E8 RID: 232 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public override void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			base.ReferenceType = value.LocalName;
			string attribute = Utils.GetAttribute(value, "URI", "http://www.w3.org/2001/04/xmlenc#");
			string text = attribute;
			if (text == null)
			{
				throw new CryptographicException("A Uri attribute is required for a CipherReference element.");
			}
			base.Uri = text;
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(value.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			XmlNode xmlNode = value.SelectSingleNode("enc:Transforms", xmlNamespaceManager);
			if (xmlNode != null)
			{
				base.TransformChain.LoadXml(xmlNode as XmlElement);
			}
			this._cachedXml = value;
		}

		// Token: 0x04000157 RID: 343
		private byte[] _cipherValue;
	}
}
