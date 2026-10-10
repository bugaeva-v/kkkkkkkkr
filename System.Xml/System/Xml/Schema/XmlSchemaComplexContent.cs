using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="complexContent" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Данный класс представляет сложную модель содержимого для сложных типов.
	///          Он содержит расширения и ограничения по сложному типу, который включает либо только элементы, либо смешанное содержимое.
	///       </summary>
	// Token: 0x020005A0 RID: 1440
	public class XmlSchemaComplexContent : XmlSchemaContentModel
	{
		/// <summary>
		///         Возвращает или задает информацию, которая определяет, имеет ли тип модель смешанного содержимого.
		///       </summary>
		/// <returns>
		///         Если это свойство имеет <see langword="true" />, символьные данные могут появиться между дочерними элементами сложного типа (модель смешанного содержимого).
		///          Значение по умолчанию — <see langword="false" />.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x0014C88B File Offset: 0x0014AA8B
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x0014C893 File Offset: 0x0014AA93
		[XmlAttribute("mixed")]
		public bool IsMixed
		{
			get
			{
				return this.isMixed;
			}
			set
			{
				this.isMixed = value;
				this.hasMixedAttribute = true;
			}
		}

		/// <summary>
		///         Возвращает или задает содержимое.
		///       </summary>
		/// <returns>
		///         Одно из следующих <see cref="T:System.Xml.Schema.XmlSchemaComplexContentRestriction" /> или <see cref="T:System.Xml.Schema.XmlSchemaComplexContentExtension" /> классы.
		///       </returns>
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x0014C8A3 File Offset: 0x0014AAA3
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x0014C8AB File Offset: 0x0014AAAB
		[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
		[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
		public override XmlSchemaContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x0014C8B4 File Offset: 0x0014AAB4
		[XmlIgnore]
		internal bool HasMixedAttribute
		{
			get
			{
				return this.hasMixedAttribute;
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private XmlSchemaContent content;

		// Token: 0x04002AF9 RID: 11001
		private bool isMixed;

		// Token: 0x04002AFA RID: 11002
		private bool hasMixedAttribute;
	}
}
