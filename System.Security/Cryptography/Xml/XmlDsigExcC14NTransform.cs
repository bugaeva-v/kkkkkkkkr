using System;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование исключающей XML-канонизации C14N для цифровой подписи в соответствии с определением консорциума W3C без комментариев.</summary>
	// Token: 0x02000063 RID: 99
	public class XmlDsigExcC14NTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		// Token: 0x06000346 RID: 838 RVA: 0x0000FDE2 File Offset: 0x0000DFE2
		public XmlDsigExcC14NTransform() : this(false, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> с указанием значения, определяющего необходимость включения комментариев.</summary>
		/// <param name="includeComments">Значение <see langword="true" />, если комментарии необходимо включить; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000347 RID: 839 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		public XmlDsigExcC14NTransform(bool includeComments) : this(includeComments, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> с указанием списка префиксов пространств имен для канонизации с помощью стандартного алгоритма канонизации.</summary>
		/// <param name="inclusiveNamespacesPrefixList">Префиксы пространств имен для канонизации с помощью стандартного алгоритма канонизации.</param>
		// Token: 0x06000348 RID: 840 RVA: 0x0000FDF6 File Offset: 0x0000DFF6
		public XmlDsigExcC14NTransform(string inclusiveNamespacesPrefixList) : this(false, inclusiveNamespacesPrefixList)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> с указанием значения, определяющего необходимость включения комментариев, и списка префиксов пространств имен.</summary>
		/// <param name="includeComments">Значение <see langword="true" />, если комментарии необходимо включить; в противном случае — значение <see langword="false" />.</param>
		/// <param name="inclusiveNamespacesPrefixList">Префиксы пространств имен для канонизации с помощью стандартного алгоритма канонизации.</param>
		// Token: 0x06000349 RID: 841 RVA: 0x0000FE00 File Offset: 0x0000E000
		public XmlDsigExcC14NTransform(bool includeComments, string inclusiveNamespacesPrefixList)
		{
			this._includeComments = includeComments;
			this._inclusiveNamespacesPrefixList = inclusiveNamespacesPrefixList;
			base.Algorithm = (includeComments ? "http://www.w3.org/2001/10/xml-exc-c14n#WithComments" : "http://www.w3.org/2001/10/xml-exc-c14n#");
		}

		/// <summary>Получает или задает строку, содержащую префиксы пространств имен для канонизации с помощью стандартного алгоритма канонизации.</summary>
		/// <returns>Строка, содержащая префиксы пространств имен для канонизации с помощью стандартного алгоритма канонизации.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000FE82 File Offset: 0x0000E082
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000FE8A File Offset: 0x0000E08A
		public string InclusiveNamespacesPrefixList
		{
			get
			{
				return this._inclusiveNamespacesPrefixList;
			}
			set
			{
				this._inclusiveNamespacesPrefixList = value;
			}
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000FE93 File Offset: 0x0000E093
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />; методы <see cref="Overload:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000FE9B File Offset: 0x0000E09B
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Анализирует указанный объект <see cref="T:System.Xml.XmlNodeList" /> как связанный с преобразованием содержимого элемент <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, указывающий связанное с преобразованием содержимое для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</param>
		// Token: 0x0600034E RID: 846 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList != null)
			{
				foreach (object obj in nodeList)
				{
					XmlElement xmlElement = ((XmlNode)obj) as XmlElement;
					if (xmlElement != null)
					{
						if (!xmlElement.LocalName.Equals("InclusiveNamespaces") || !xmlElement.NamespaceURI.Equals("http://www.w3.org/2001/10/xml-exc-c14n#") || !Utils.HasAttribute(xmlElement, "PrefixList", "http://www.w3.org/2000/09/xmldsig#"))
						{
							throw new CryptographicException("Unknown transform has been encountered.");
						}
						if (!Utils.VerifyAttributes(xmlElement, "PrefixList"))
						{
							throw new CryptographicException("Unknown transform has been encountered.");
						}
						this.InclusiveNamespacesPrefixList = Utils.GetAttribute(xmlElement, "PrefixList", "http://www.w3.org/2000/09/xmldsig#");
						break;
					}
				}
			}
		}

		/// <summary>При переопределении в производном классе загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> не является объектом <see cref="T:System.IO.Stream" />.  
		///
		/// или - 
		/// Параметр <paramref name="obj" /> не является объектом <see cref="T:System.Xml.XmlDocument" />.  
		///
		/// или - 
		/// Параметр <paramref name="obj" /> не является объектом <see cref="T:System.Xml.XmlNodeList" />.</exception>
		// Token: 0x0600034F RID: 847 RVA: 0x0000FF78 File Offset: 0x0000E178
		public override void LoadInput(object obj)
		{
			XmlResolver resolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			if (obj is Stream)
			{
				this._excCanonicalXml = new ExcCanonicalXml((Stream)obj, this._includeComments, this._inclusiveNamespacesPrefixList, resolver, base.BaseURI);
				return;
			}
			if (obj is XmlDocument)
			{
				this._excCanonicalXml = new ExcCanonicalXml((XmlDocument)obj, this._includeComments, this._inclusiveNamespacesPrefixList, resolver);
				return;
			}
			if (obj is XmlNodeList)
			{
				this._excCanonicalXml = new ExcCanonicalXml((XmlNodeList)obj, this._includeComments, this._inclusiveNamespacesPrefixList, resolver);
				return;
			}
			throw new ArgumentException("Type of input object is invalid.", "obj");
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x06000350 RID: 848 RVA: 0x00010030 File Offset: 0x0000E230
		protected override XmlNodeList GetInnerXml()
		{
			if (this.InclusiveNamespacesPrefixList == null)
			{
				return null;
			}
			XmlDocument xmlDocument = new XmlDocument();
			XmlElement xmlElement = xmlDocument.CreateElement("Transform", "http://www.w3.org/2000/09/xmldsig#");
			if (!string.IsNullOrEmpty(base.Algorithm))
			{
				xmlElement.SetAttribute("Algorithm", base.Algorithm);
			}
			XmlElement xmlElement2 = xmlDocument.CreateElement("InclusiveNamespaces", "http://www.w3.org/2001/10/xml-exc-c14n#");
			xmlElement2.SetAttribute("PrefixList", this.InclusiveNamespacesPrefixList);
			xmlElement.AppendChild(xmlElement2);
			return xmlElement.ChildNodes;
		}

		/// <summary>Возвращает выходной объект текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</returns>
		// Token: 0x06000351 RID: 849 RVA: 0x000100AA File Offset: 0x0000E2AA
		public override object GetOutput()
		{
			return new MemoryStream(this._excCanonicalXml.GetBytes());
		}

		/// <summary>Возвращает выходной объект указанного типа для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Этот тип должен быть одним из типов, перечисленных в свойстве <see cref="P:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform.OutputTypes" />.</param>
		/// <returns>Выходной объект указанного типа для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.IO.Stream" />.  
		///
		/// или - 
		/// Параметр <paramref name="type" /> не является производным от объекта <see cref="T:System.IO.Stream" />.</exception>
		// Token: 0x06000352 RID: 850 RVA: 0x000100BC File Offset: 0x0000E2BC
		public override object GetOutput(Type type)
		{
			if (type != typeof(Stream) && !type.IsSubclassOf(typeof(Stream)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return new MemoryStream(this._excCanonicalXml.GetBytes());
		}

		/// <summary>Возвращает дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</summary>
		/// <param name="hash">Объект <see cref="T:System.Security.Cryptography.HashAlgorithm" />, используемый для создания дайджеста.</param>
		/// <returns>Дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.XmlDsigExcC14NTransform" />.</returns>
		// Token: 0x06000353 RID: 851 RVA: 0x0001010D File Offset: 0x0000E30D
		public override byte[] GetDigestedOutput(HashAlgorithm hash)
		{
			return this._excCanonicalXml.GetDigestedBytes(hash);
		}

		// Token: 0x0400024A RID: 586
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlDocument),
			typeof(XmlNodeList)
		};

		// Token: 0x0400024B RID: 587
		private Type[] _outputTypes = new Type[]
		{
			typeof(Stream)
		};

		// Token: 0x0400024C RID: 588
		private bool _includeComments;

		// Token: 0x0400024D RID: 589
		private string _inclusiveNamespacesPrefixList;

		// Token: 0x0400024E RID: 590
		private ExcCanonicalXml _excCanonicalXml;
	}
}
