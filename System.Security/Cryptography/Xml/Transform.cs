using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все элементы <see langword="&lt;Transform&gt;" />. Эти элементы можно использовать в цифровых подписях XML.</summary>
	// Token: 0x0200005B RID: 91
	public abstract class Transform
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000D062 File Offset: 0x0000B262
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000D06A File Offset: 0x0000B26A
		internal string BaseURI
		{
			get
			{
				return this._baseUri;
			}
			set
			{
				this._baseUri = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000D073 File Offset: 0x0000B273
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000D07B File Offset: 0x0000B27B
		internal SignedXml SignedXml
		{
			get
			{
				return this._signedXml;
			}
			set
			{
				this._signedXml = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000D084 File Offset: 0x0000B284
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000D08C File Offset: 0x0000B28C
		internal Reference Reference
		{
			get
			{
				return this._reference;
			}
			set
			{
				this._reference = value;
			}
		}

		/// <summary>Получает или задает универсальный код ресурса (URI), который определяет алгоритм, выполняемый текущим преобразованием.</summary>
		/// <returns>URI, который определяет алгоритм, выполняемый текущим объектом <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000D095 File Offset: 0x0000B295
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000D09D File Offset: 0x0000B29D
		public string Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
			}
		}

		/// <summary>Задает текущий объект <see cref="T:System.Xml.XmlResolver" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Xml.XmlResolver" />. Значением этого свойства по умолчанию является объект <see cref="T:System.Xml.XmlSecureResolver" />.</returns>
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000D0B6 File Offset: 0x0000B2B6
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000D0A6 File Offset: 0x0000B2A6
		public XmlResolver Resolver
		{
			internal get
			{
				return this._xmlResolver;
			}
			set
			{
				this._xmlResolver = value;
				this._bResolverSet = true;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000D0BE File Offset: 0x0000B2BE
		internal bool ResolverSet
		{
			get
			{
				return this._bResolverSet;
			}
		}

		/// <summary>При переопределении в производном классе получает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.Transform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />; методу <see cref="M:System.Security.Cryptography.Xml.Transform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002C6 RID: 710
		public abstract Type[] InputTypes { get; }

		/// <summary>При переопределении в производном классе получает массив типов, которые являются возможными выходными значениями, возвращаемыми из методов <see cref="M:System.Security.Cryptography.Xml.Transform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />; методы <see cref="M:System.Security.Cryptography.Xml.Transform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002C7 RID: 711
		public abstract Type[] OutputTypes { get; }

		// Token: 0x060002C8 RID: 712 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		internal bool AcceptsType(Type inputType)
		{
			if (this.InputTypes != null)
			{
				for (int i = 0; i < this.InputTypes.Length; i++)
				{
					if (inputType == this.InputTypes[i] || inputType.IsSubclassOf(this.InputTypes[i]))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>Возвращает XML-представление текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <returns>XML-представление текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x060002C9 RID: 713 RVA: 0x0000D114 File Offset: 0x0000B314
		public XmlElement GetXml()
		{
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000D135 File Offset: 0x0000B335
		internal XmlElement GetXml(XmlDocument document)
		{
			return this.GetXml(document, "Transform");
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000D144 File Offset: 0x0000B344
		internal XmlElement GetXml(XmlDocument document, string name)
		{
			XmlElement xmlElement = document.CreateElement(name, "http://www.w3.org/2000/09/xmldsig#");
			if (!string.IsNullOrEmpty(this.Algorithm))
			{
				xmlElement.SetAttribute("Algorithm", this.Algorithm);
			}
			XmlNodeList innerXml = this.GetInnerXml();
			if (innerXml != null)
			{
				foreach (object obj in innerXml)
				{
					XmlNode node = (XmlNode)obj;
					xmlElement.AppendChild(document.ImportNode(node, true));
				}
			}
			return xmlElement;
		}

		/// <summary>При переопределении в производном классе выполняет синтаксический анализ указанного объекта <see cref="T:System.Xml.XmlNodeList" /> в качестве связанного с преобразованием содержимого элемента <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.Transform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, указывающий связанное с преобразованием содержимое для текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</param>
		// Token: 0x060002CC RID: 716
		public abstract void LoadInnerXml(XmlNodeList nodeList);

		/// <summary>При переопределении в производном классе возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x060002CD RID: 717
		protected abstract XmlNodeList GetInnerXml();

		/// <summary>При переопределении в производном классе загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.Transform" />.</param>
		// Token: 0x060002CE RID: 718
		public abstract void LoadInput(object obj);

		/// <summary>При переопределении в производном классе возвращает выходной объект текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x060002CF RID: 719
		public abstract object GetOutput();

		/// <summary>При переопределении в производном классе возвращает для текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" /> выходной объект указанного типа.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Этот тип должен быть одним из типов, перечисленных в свойстве <see cref="P:System.Security.Cryptography.Xml.Transform.OutputTypes" />.</param>
		/// <returns>Выходной объект указанного типа для текущего объекта <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x060002D0 RID: 720
		public abstract object GetOutput(Type type);

		/// <summary>При переопределении в производном классе возвращает дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <param name="hash">Объект <see cref="T:System.Security.Cryptography.HashAlgorithm" />, используемый для создания дайджеста.</param>
		/// <returns>Дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x060002D1 RID: 721 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		public virtual byte[] GetDigestedOutput(HashAlgorithm hash)
		{
			return hash.ComputeHash((Stream)this.GetOutput(typeof(Stream)));
		}

		/// <summary>Получает или задает объект <see cref="T:System.Xml.XmlElement" />, представляющий контекст документа, в котором выполняется текущий объект <see cref="T:System.Security.Cryptography.Xml.Transform" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, представляющий контекст документа, в котором выполняется текущий объект <see cref="T:System.Security.Cryptography.Xml.Transform" />.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000D23C File Offset: 0x0000B43C
		public XmlElement Context
		{
			get
			{
				if (this._context != null)
				{
					return this._context;
				}
				Reference reference = this.Reference;
				SignedXml signedXml = (reference == null) ? this.SignedXml : reference.SignedXml;
				if (signedXml == null)
				{
					return null;
				}
				return signedXml._context;
			}
			set
			{
				this._context = value;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Collections.Hashtable" />, содержащий пространства имен, которые передаются в подпись.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Hashtable" />, содержащий пространства имен, которые передаются в подпись.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства <see cref="P:System.Security.Cryptography.Xml.Transform.PropagatedNamespaces" /> задано значение <see langword="null" />.</exception>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000D248 File Offset: 0x0000B448
		public Hashtable PropagatedNamespaces
		{
			get
			{
				if (this._propagatedNamespaces != null)
				{
					return this._propagatedNamespaces;
				}
				Reference reference = this.Reference;
				SignedXml signedXml = (reference == null) ? this.SignedXml : reference.SignedXml;
				if (reference != null && (reference.ReferenceTargetType != ReferenceTargetType.UriReference || string.IsNullOrEmpty(reference.Uri) || reference.Uri[0] != '#'))
				{
					this._propagatedNamespaces = new Hashtable(0);
					return this._propagatedNamespaces;
				}
				CanonicalXmlNodeList canonicalXmlNodeList = null;
				if (reference != null)
				{
					canonicalXmlNodeList = reference._namespaces;
				}
				else if (((signedXml != null) ? signedXml._context : null) != null)
				{
					canonicalXmlNodeList = Utils.GetPropagatedAttributes(signedXml._context);
				}
				if (canonicalXmlNodeList == null)
				{
					this._propagatedNamespaces = new Hashtable(0);
					return this._propagatedNamespaces;
				}
				this._propagatedNamespaces = new Hashtable(canonicalXmlNodeList.Count);
				foreach (object obj in canonicalXmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					string key = (xmlNode.Prefix.Length > 0) ? (xmlNode.Prefix + ":" + xmlNode.LocalName) : xmlNode.LocalName;
					if (!this._propagatedNamespaces.Contains(key))
					{
						this._propagatedNamespaces.Add(key, xmlNode.Value);
					}
				}
				return this._propagatedNamespaces;
			}
		}

		// Token: 0x04000225 RID: 549
		private string _algorithm;

		// Token: 0x04000226 RID: 550
		private string _baseUri;

		// Token: 0x04000227 RID: 551
		internal XmlResolver _xmlResolver;

		// Token: 0x04000228 RID: 552
		private bool _bResolverSet;

		// Token: 0x04000229 RID: 553
		private SignedXml _signedXml;

		// Token: 0x0400022A RID: 554
		private Reference _reference;

		// Token: 0x0400022B RID: 555
		private Hashtable _propagatedNamespaces;

		// Token: 0x0400022C RID: 556
		private XmlElement _context;
	}
}
