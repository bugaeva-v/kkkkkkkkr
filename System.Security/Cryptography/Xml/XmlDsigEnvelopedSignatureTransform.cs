using System;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование запечатанной подписи для цифровой XML-подписи в соответствии с определением консорциума W3C.</summary>
	// Token: 0x02000062 RID: 98
	public class XmlDsigEnvelopedSignatureTransform : Transform
	{
		// Token: 0x170000AC RID: 172
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000F8B3 File Offset: 0x0000DAB3
		internal int SignaturePosition
		{
			set
			{
				this._signaturePosition = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		// Token: 0x0600033A RID: 826 RVA: 0x0000F8BC File Offset: 0x0000DABC
		public XmlDsigEnvelopedSignatureTransform()
		{
			base.Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" /> комментариями, если они указаны.</summary>
		/// <param name="includeComments">Значение <see langword="true" />, если комментарии необходимо включить; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600033B RID: 827 RVA: 0x0000F934 File Offset: 0x0000DB34
		public XmlDsigEnvelopedSignatureTransform(bool includeComments)
		{
			this._includeComments = includeComments;
			base.Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000F9BA File Offset: 0x0000DBBA
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Выполняет анализ указанного объекта <see cref="T:System.Xml.XmlNodeList" /> в качестве связанного с преобразованием содержимого элемента <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">
		///   <see cref="T:System.Xml.XmlNodeList" /> для загрузки в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</param>
		// Token: 0x0600033E RID: 830 RVA: 0x0000F76F File Offset: 0x0000D96F
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList != null && nodeList.Count > 0)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x0600033F RID: 831 RVA: 0x0000F43E File Offset: 0x0000D63E
		protected override XmlNodeList GetInnerXml()
		{
			return null;
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Содержащий XML-документ имеет значение <see langword="null" />.</exception>
		// Token: 0x06000340 RID: 832 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
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
				return;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000FA10 File Offset: 0x0000DC10
		private void LoadStreamInput(Stream stream)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.PreserveWhitespace = true;
			XmlResolver xmlResolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			XmlReader reader = Utils.PreProcessStreamInput(stream, xmlResolver, base.BaseURI);
			xmlDocument.Load(reader);
			this._containingDocument = xmlDocument;
			if (this._containingDocument == null)
			{
				throw new CryptographicException("An XmlDocument context is required for enveloped transforms.");
			}
			this._nsm = new XmlNamespaceManager(this._containingDocument.NameTable);
			this._nsm.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		private void LoadXmlNodeListInput(XmlNodeList nodeList)
		{
			if (nodeList == null)
			{
				throw new ArgumentNullException("nodeList");
			}
			this._containingDocument = Utils.GetOwnerDocument(nodeList);
			if (this._containingDocument == null)
			{
				throw new CryptographicException("An XmlDocument context is required for enveloped transforms.");
			}
			this._nsm = new XmlNamespaceManager(this._containingDocument.NameTable);
			this._nsm.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
			this._inputNodeList = nodeList;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000FB14 File Offset: 0x0000DD14
		private void LoadXmlDocumentInput(XmlDocument doc)
		{
			if (doc == null)
			{
				throw new ArgumentNullException("doc");
			}
			this._containingDocument = doc;
			this._nsm = new XmlNamespaceManager(this._containingDocument.NameTable);
			this._nsm.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Содержащий XML-документ имеет значение <see langword="null" />.</exception>
		// Token: 0x06000344 RID: 836 RVA: 0x0000FB64 File Offset: 0x0000DD64
		public override object GetOutput()
		{
			if (this._containingDocument == null)
			{
				throw new CryptographicException("An XmlDocument context is required for enveloped transforms.");
			}
			if (this._inputNodeList != null)
			{
				if (this._signaturePosition == 0)
				{
					return this._inputNodeList;
				}
				XmlNodeList xmlNodeList = this._containingDocument.SelectNodes("//dsig:Signature", this._nsm);
				if (xmlNodeList == null)
				{
					return this._inputNodeList;
				}
				CanonicalXmlNodeList canonicalXmlNodeList = new CanonicalXmlNodeList();
				foreach (object obj in this._inputNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode != null)
					{
						if (Utils.IsXmlNamespaceNode(xmlNode) || Utils.IsNamespaceNode(xmlNode))
						{
							canonicalXmlNodeList.Add(xmlNode);
						}
						else
						{
							try
							{
								XmlNode xmlNode2 = xmlNode.SelectSingleNode("ancestor-or-self::dsig:Signature[1]", this._nsm);
								int num = 0;
								foreach (object obj2 in xmlNodeList)
								{
									XmlNode xmlNode3 = (XmlNode)obj2;
									num++;
									if (xmlNode3 == xmlNode2)
									{
										break;
									}
								}
								if (xmlNode2 == null || (xmlNode2 != null && num != this._signaturePosition))
								{
									canonicalXmlNodeList.Add(xmlNode);
								}
							}
							catch
							{
							}
						}
					}
				}
				return canonicalXmlNodeList;
			}
			else
			{
				XmlNodeList xmlNodeList2 = this._containingDocument.SelectNodes("//dsig:Signature", this._nsm);
				if (xmlNodeList2 == null)
				{
					return this._containingDocument;
				}
				if (xmlNodeList2.Count < this._signaturePosition || this._signaturePosition <= 0)
				{
					return this._containingDocument;
				}
				xmlNodeList2[this._signaturePosition - 1].ParentNode.RemoveChild(xmlNodeList2[this._signaturePosition - 1]);
				return this._containingDocument;
			}
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />, принадлежащего к типу <see cref="T:System.Xml.XmlNodeList" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.Xml.XmlNodeList" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform" />, принадлежащего к типу <see cref="T:System.Xml.XmlNodeList" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.Xml.XmlNodeList" />.</exception>
		// Token: 0x06000345 RID: 837 RVA: 0x0000FD34 File Offset: 0x0000DF34
		public override object GetOutput(Type type)
		{
			if (type == typeof(XmlNodeList) || type.IsSubclassOf(typeof(XmlNodeList)))
			{
				if (this._inputNodeList == null)
				{
					this._inputNodeList = Utils.AllDescendantNodes(this._containingDocument, true);
				}
				return (XmlNodeList)this.GetOutput();
			}
			if (!(type == typeof(XmlDocument)) && !type.IsSubclassOf(typeof(XmlDocument)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			if (this._inputNodeList != null)
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return (XmlDocument)this.GetOutput();
		}

		// Token: 0x04000243 RID: 579
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlNodeList),
			typeof(XmlDocument)
		};

		// Token: 0x04000244 RID: 580
		private Type[] _outputTypes = new Type[]
		{
			typeof(XmlNodeList),
			typeof(XmlDocument)
		};

		// Token: 0x04000245 RID: 581
		private XmlNodeList _inputNodeList;

		// Token: 0x04000246 RID: 582
		private bool _includeComments;

		// Token: 0x04000247 RID: 583
		private XmlNamespaceManager _nsm;

		// Token: 0x04000248 RID: 584
		private XmlDocument _containingDocument;

		// Token: 0x04000249 RID: 585
		private int _signaturePosition;
	}
}
