using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="documentation" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс задает информацию для прочтения или использования пользователем в <see langword="annotation" />.
	///       </summary>
	// Token: 0x020005AA RID: 1450
	public class XmlSchemaDocumentation : XmlSchemaObject
	{
		/// <summary>
		///         Возвращает или задает уникальный идентификатор ресурса (URI) для источника сведений.
		///       </summary>
		/// <returns>
		///         Ссылка URI.
		///          Значение по умолчанию — <see langword="String.Empty" />.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x0014D83C File Offset: 0x0014BA3C
		// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x0014D844 File Offset: 0x0014BA44
		[XmlAttribute("source", DataType = "anyURI")]
		public string Source
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see langword="xml:lang" /> атрибута.
		///          Указывает язык содержимого.
		///       </summary>
		/// <returns>
		///         <see langword="xml:lang" /> Атрибута.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x0014D84D File Offset: 0x0014BA4D
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x0014D855 File Offset: 0x0014BA55
		[XmlAttribute("xml:lang")]
		public string Language
		{
			get
			{
				return this.language;
			}
			set
			{
				this.language = (string)XmlSchemaDocumentation.languageType.Datatype.ParseValue(value, null, null);
			}
		}

		/// <summary>
		///         Возвращает или задает массив <see langword="XmlNodes" /> представляющий дочерние узлы документации.
		///       </summary>
		/// <returns>
		///         Массив, представляющий дочерние узлы документации.
		///       </returns>
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x0014D874 File Offset: 0x0014BA74
		// (set) Token: 0x06003AA9 RID: 15017 RVA: 0x0014D87C File Offset: 0x0014BA7C
		[XmlAnyElement]
		[XmlText]
		public XmlNode[] Markup
		{
			get
			{
				return this.markup;
			}
			set
			{
				this.markup = value;
			}
		}

		// Token: 0x04002B27 RID: 11047
		private string source;

		// Token: 0x04002B28 RID: 11048
		private string language;

		// Token: 0x04002B29 RID: 11049
		private XmlNode[] markup;

		// Token: 0x04002B2A RID: 11050
		private static XmlSchemaSimpleType languageType = DatatypeImplementation.GetSimpleTypeFromXsdType(new XmlQualifiedName("language", "http://www.w3.org/2001/XMLSchema"));
	}
}
