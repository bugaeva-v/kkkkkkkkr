using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет XSLT-преобразование для цифровой подписи в соответствии с определением консорциума W3C.</summary>
	// Token: 0x02000066 RID: 102
	public class XmlDsigXsltTransform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</summary>
		// Token: 0x06000361 RID: 865 RVA: 0x00010648 File Offset: 0x0000E848
		public XmlDsigXsltTransform()
		{
			base.Algorithm = "http://www.w3.org/TR/1999/REC-xslt-19991116";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" /> комментариями, если они указаны.</summary>
		/// <param name="includeComments">Значение <see langword="true" />, если комментарии необходимо включить; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000362 RID: 866 RVA: 0x000106B4 File Offset: 0x0000E8B4
		public XmlDsigXsltTransform(bool includeComments)
		{
			this._includeComments = includeComments;
			base.Algorithm = "http://www.w3.org/TR/1999/REC-xslt-19991116";
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigXsltTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigXsltTransform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00010725 File Offset: 0x0000E925
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigXsltTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDsigXsltTransform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0001072D File Offset: 0x0000E92D
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Анализирует указанный объект <see cref="T:System.Xml.XmlNodeList" /> как связанный с преобразованием содержимого элемент <see langword="&lt;Transform&gt;" /> и настраивает внутреннее состояние текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" /> таким образом, чтобы оно совпадало с состоянием элемента <see langword="&lt;Transform&gt;" />.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, который инкапсулирует таблицу стилей XSLT, загружаемую в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />. Таблица стилей, которая применяется к документу, загружаемому методом <see cref="M:System.Security.Cryptography.Xml.XmlDsigXsltTransform.LoadInput(System.Object)" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="nodeList" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="nodeList" /> не содержит объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</exception>
		// Token: 0x06000365 RID: 869 RVA: 0x00010738 File Offset: 0x0000E938
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
			if (nodeList == null)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
			XmlElement xmlElement = null;
			int num = 0;
			foreach (object obj in nodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (!(xmlNode is XmlWhitespace))
				{
					if (xmlNode is XmlElement)
					{
						if (num != 0)
						{
							throw new CryptographicException("Unknown transform has been encountered.");
						}
						xmlElement = (xmlNode as XmlElement);
						num++;
					}
					else
					{
						num++;
					}
				}
			}
			if (num != 1 || xmlElement == null)
			{
				throw new CryptographicException("Unknown transform has been encountered.");
			}
			this._xslNodes = nodeList;
			this._xslFragment = xmlElement.OuterXml.Trim(null);
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x06000366 RID: 870 RVA: 0x000107F4 File Offset: 0x0000E9F4
		protected override XmlNodeList GetInnerXml()
		{
			return this._xslNodes;
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</param>
		// Token: 0x06000367 RID: 871 RVA: 0x000107FC File Offset: 0x0000E9FC
		public override void LoadInput(object obj)
		{
			if (this._inputStream != null)
			{
				this._inputStream.Close();
			}
			this._inputStream = new MemoryStream();
			if (obj is Stream)
			{
				this._inputStream = (Stream)obj;
				return;
			}
			if (!(obj is XmlNodeList))
			{
				if (obj is XmlDocument)
				{
					byte[] bytes = new CanonicalXml((XmlDocument)obj, null, this._includeComments).GetBytes();
					if (bytes == null)
					{
						return;
					}
					this._inputStream.Write(bytes, 0, bytes.Length);
					this._inputStream.Flush();
					this._inputStream.Position = 0L;
				}
				return;
			}
			byte[] bytes2 = new CanonicalXml((XmlNodeList)obj, null, this._includeComments).GetBytes();
			if (bytes2 == null)
			{
				return;
			}
			this._inputStream.Write(bytes2, 0, bytes2.Length);
			this._inputStream.Flush();
			this._inputStream.Position = 0L;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />.</returns>
		// Token: 0x06000368 RID: 872 RVA: 0x000108D8 File Offset: 0x0000EAD8
		public override object GetOutput()
		{
			XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			xmlReaderSettings.XmlResolver = null;
			xmlReaderSettings.MaxCharactersFromEntities = 10000000L;
			xmlReaderSettings.MaxCharactersInDocument = 0L;
			object result;
			using (StringReader stringReader = new StringReader(this._xslFragment))
			{
				XmlReader stylesheet = XmlReader.Create(stringReader, xmlReaderSettings, null);
				xslCompiledTransform.Load(stylesheet, XsltSettings.Default, null);
				XPathDocument input = new XPathDocument(XmlReader.Create(this._inputStream, xmlReaderSettings, base.BaseURI), XmlSpace.Preserve);
				MemoryStream memoryStream = new MemoryStream();
				XmlWriter results = new XmlTextWriter(memoryStream, null);
				xslCompiledTransform.Transform(input, null, results);
				memoryStream.Position = 0L;
				result = memoryStream;
			}
			return result;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigXsltTransform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.IO.Stream" />.</exception>
		// Token: 0x06000369 RID: 873 RVA: 0x0001098C File Offset: 0x0000EB8C
		public override object GetOutput(Type type)
		{
			if (type != typeof(Stream) && !type.IsSubclassOf(typeof(Stream)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return (Stream)this.GetOutput();
		}

		// Token: 0x04000254 RID: 596
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlDocument),
			typeof(XmlNodeList)
		};

		// Token: 0x04000255 RID: 597
		private Type[] _outputTypes = new Type[]
		{
			typeof(Stream)
		};

		// Token: 0x04000256 RID: 598
		private XmlNodeList _xslNodes;

		// Token: 0x04000257 RID: 599
		private string _xslFragment;

		// Token: 0x04000258 RID: 600
		private Stream _inputStream;

		// Token: 0x04000259 RID: 601
		private bool _includeComments;
	}
}
