using System;
using System.IO;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование XML-канонизации C14N для цифровой подписи в соответствии с определением консорциума W3C без комментариев.</summary>
	// Token: 0x02000060 RID: 96
	public class XmlDsigC14NTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		// Token: 0x0600032E RID: 814 RVA: 0x0000F678 File Offset: 0x0000D878
		public XmlDsigC14NTransform()
		{
			base.Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" /> комментариями, если они указаны.</summary>
		/// <param name="includeComments">Значение <see langword="true" />, если комментарии необходимо включить; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600032F RID: 815 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
		public XmlDsigC14NTransform(bool includeComments)
		{
			this._includeComments = includeComments;
			base.Algorithm = (includeComments ? "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments" : "http://www.w3.org/TR/2001/REC-xml-c14n-20010315");
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigC14NTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigC14NTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000F75F File Offset: 0x0000D95F
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigC14NTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDsigC14NTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000F767 File Offset: 0x0000D967
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Выполняет синтаксический анализ указанного объекта <see cref="T:System.Xml.XmlNodeList" /> в качестве связанного с преобразованием содержимого элемента <see langword="&lt;Transform&gt;" />; данный метод не поддерживается, поскольку данный элемент не содержит внутренних XML-элементов.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, загружаемый в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</param>
		// Token: 0x06000332 RID: 818 RVA: 0x0000F76F File Offset: 0x0000D96F
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList != null && nodeList.Count > 0)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x06000333 RID: 819 RVA: 0x0000F43E File Offset: 0x0000D63E
		protected override XmlNodeList GetInnerXml()
		{
			return null;
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> является объектом <see cref="T:System.IO.Stream" /> и равен значению <see langword="null" />.</exception>
		// Token: 0x06000334 RID: 820 RVA: 0x0000F788 File Offset: 0x0000D988
		public override void LoadInput(object obj)
		{
			XmlResolver resolver = base.ResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), base.BaseURI);
			if (obj is Stream)
			{
				this._cXml = new CanonicalXml((Stream)obj, this._includeComments, resolver, base.BaseURI);
				return;
			}
			if (obj is XmlDocument)
			{
				this._cXml = new CanonicalXml((XmlDocument)obj, resolver, this._includeComments);
				return;
			}
			if (obj is XmlNodeList)
			{
				this._cXml = new CanonicalXml((XmlNodeList)obj, resolver, this._includeComments);
				return;
			}
			throw new ArgumentException("Type of input object is invalid.", "obj");
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</returns>
		// Token: 0x06000335 RID: 821 RVA: 0x0000F82E File Offset: 0x0000DA2E
		public override object GetOutput()
		{
			return new MemoryStream(this._cXml.GetBytes());
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.IO.Stream" />.</exception>
		// Token: 0x06000336 RID: 822 RVA: 0x0000F840 File Offset: 0x0000DA40
		public override object GetOutput(Type type)
		{
			if (type != typeof(Stream) && !type.IsSubclassOf(typeof(Stream)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return new MemoryStream(this._cXml.GetBytes());
		}

		/// <summary>Возвращает дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</summary>
		/// <param name="hash">Объект <see cref="T:System.Security.Cryptography.HashAlgorithm" />, используемый для создания дайджеста.</param>
		/// <returns>Дайджест, связанный с объектом <see cref="T:System.Security.Cryptography.Xml.XmlDsigC14NTransform" />.</returns>
		// Token: 0x06000337 RID: 823 RVA: 0x0000F891 File Offset: 0x0000DA91
		public override byte[] GetDigestedOutput(HashAlgorithm hash)
		{
			return this._cXml.GetDigestedBytes(hash);
		}

		// Token: 0x0400023F RID: 575
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlDocument),
			typeof(XmlNodeList)
		};

		// Token: 0x04000240 RID: 576
		private Type[] _outputTypes = new Type[]
		{
			typeof(Stream)
		};

		// Token: 0x04000241 RID: 577
		private CanonicalXml _cXml;

		// Token: 0x04000242 RID: 578
		private bool _includeComments;
	}
}
