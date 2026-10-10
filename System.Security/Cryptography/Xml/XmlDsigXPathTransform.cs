using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование XPath для цифровой подписи в соответствии с определением консорциума W3C.</summary>
	// Token: 0x02000065 RID: 101
	public class XmlDsigXPathTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</summary>
		// Token: 0x06000356 RID: 854 RVA: 0x00010144 File Offset: 0x0000E344
		public XmlDsigXPathTransform()
		{
			base.Algorithm = "http://www.w3.org/TR/1999/REC-xpath-19991116";
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigXPathTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigXPathTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000357 RID: 855 RVA: 0x000101AE File Offset: 0x0000E3AE
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigXPathTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDsigXPathTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000101B6 File Offset: 0x0000E3B6
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Анализирует указанный объект <see cref="T:System.Xml.XmlNodeList" /> как связанный с преобразованием содержимого элемент <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, загружаемый в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="nodeList" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="nodeList" /> не содержит элемент <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</exception>
		// Token: 0x06000359 RID: 857 RVA: 0x000101C0 File Offset: 0x0000E3C0
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList == null)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
			foreach (object obj in nodeList)
			{
				XmlElement xmlElement = ((XmlNode)obj) as XmlElement;
				if (xmlElement != null)
				{
					if (xmlElement.LocalName == "XPath")
					{
						this._xpathexpr = xmlElement.InnerXml.Trim(null);
						XmlNameTable nameTable = new XmlNodeReader(xmlElement).NameTable;
						this._nsm = new XmlNamespaceManager(nameTable);
						if (!Utils.VerifyAttributes(xmlElement, null))
						{
							throw new CryptographicException("Unknown transform has been encountered.");
						}
						using (IEnumerator enumerator2 = xmlElement.Attributes.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object obj2 = enumerator2.Current;
								XmlAttribute xmlAttribute = (XmlAttribute)obj2;
								if (xmlAttribute.Prefix == "xmlns")
								{
									string text = xmlAttribute.LocalName;
									string uri = xmlAttribute.Value;
									if (text == null)
									{
										text = xmlElement.Prefix;
										uri = xmlElement.NamespaceURI;
									}
									this._nsm.AddNamespace(text, uri);
								}
							}
							break;
						}
					}
					throw new CryptographicException("Unknown transform has been encountered.");
				}
			}
			if (this._xpathexpr == null)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x0600035A RID: 858 RVA: 0x00010348 File Offset: 0x0000E548
		protected override XmlNodeList GetInnerXml()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlElement xmlElement = xmlDocument.CreateElement(null, "XPath", "http://www.w3.org/2000/09/xmldsig#");
			if (this._nsm != null)
			{
				foreach (object obj in this._nsm)
				{
					string text = (string)obj;
					if (!(text == "xml") && !(text == "xmlns") && text != null && text.Length > 0)
					{
						xmlElement.SetAttribute("xmlns:" + text, this._nsm.LookupNamespace(text));
					}
				}
			}
			xmlElement.InnerXml = this._xpathexpr;
			xmlDocument.AppendChild(xmlElement);
			return xmlDocument.ChildNodes;
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</param>
		// Token: 0x0600035B RID: 859 RVA: 0x0001041C File Offset: 0x0000E61C
		public override void LoadInput(object obj)
		{
			if (obj is Stream)
			{
				this.LoadStreamInput((Stream)obj);
				return;
			}
			if (obj is XmlNodeList)
			{
				this.LoadXmlNodeListInput((XmlNodeList)obj);
				return;
			}
			if (obj is XmlDocument)
			{
				this.LoadXmlDocumentInput((XmlDocument)obj);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001045C File Offset: 0x0000E65C
		private void LoadStreamInput(Stream stream)
		{
			XmlResolver xmlResolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			XmlReader reader = Utils.PreProcessStreamInput(stream, xmlResolver, base.BaseURI);
			this._document = new XmlDocument();
			this._document.PreserveWhitespace = true;
			this._document.Load(reader);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000104BC File Offset: 0x0000E6BC
		private void LoadXmlNodeListInput(XmlNodeList nodeList)
		{
			XmlResolver resolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			using (MemoryStream memoryStream = new MemoryStream(new CanonicalXml(nodeList, resolver, true).GetBytes()))
			{
				this.LoadStreamInput(memoryStream);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00010520 File Offset: 0x0000E720
		private void LoadXmlDocumentInput(XmlDocument doc)
		{
			this._document = doc;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />.</returns>
		// Token: 0x0600035F RID: 863 RVA: 0x0001052C File Offset: 0x0000E72C
		public override object GetOutput()
		{
			CanonicalXmlNodeList canonicalXmlNodeList = new CanonicalXmlNodeList();
			if (!string.IsNullOrEmpty(this._xpathexpr))
			{
				XPathNavigator xpathNavigator = this._document.CreateNavigator();
				XPathNodeIterator xpathNodeIterator = xpathNavigator.Select("//. | //@*");
				XPathExpression xpathExpression = xpathNavigator.Compile("boolean(" + this._xpathexpr + ")");
				xpathExpression.SetContext(this._nsm);
				while (xpathNodeIterator.MoveNext())
				{
					XPathNavigator xpathNavigator2 = xpathNodeIterator.Current;
					XmlNode node = ((IHasXmlNode)xpathNavigator2).GetNode();
					if ((bool)xpathNodeIterator.Current.Evaluate(xpathExpression))
					{
						canonicalXmlNodeList.Add(node);
					}
				}
				xpathNodeIterator = xpathNavigator.Select("//namespace::*");
				while (xpathNodeIterator.MoveNext())
				{
					XPathNavigator xpathNavigator3 = xpathNodeIterator.Current;
					XmlNode node2 = ((IHasXmlNode)xpathNavigator3).GetNode();
					canonicalXmlNodeList.Add(node2);
				}
			}
			return canonicalXmlNodeList;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />, принадлежащего к типу <see cref="T:System.Xml.XmlNodeList" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.Xml.XmlNodeList" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXPathTransform" />, принадлежащего к типу <see cref="T:System.Xml.XmlNodeList" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.Xml.XmlNodeList" />.</exception>
		// Token: 0x06000360 RID: 864 RVA: 0x000105FC File Offset: 0x0000E7FC
		public override object GetOutput(Type type)
		{
			if (type != typeof(XmlNodeList) && !type.IsSubclassOf(typeof(XmlNodeList)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return (XmlNodeList)this.GetOutput();
		}

		// Token: 0x0400024F RID: 591
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlNodeList),
			typeof(XmlDocument)
		};

		// Token: 0x04000250 RID: 592
		private Type[] _outputTypes = new Type[]
		{
			typeof(XmlNodeList)
		};

		// Token: 0x04000251 RID: 593
		private string _xpathexpr;

		// Token: 0x04000252 RID: 594
		private XmlDocument _document;

		// Token: 0x04000253 RID: 595
		private XmlNamespaceManager _nsm;
	}
}
