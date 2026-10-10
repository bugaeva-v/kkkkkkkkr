using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="import" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс используется для импорта компонентов схемы из других схем.
	///       </summary>
	// Token: 0x020005C6 RID: 1478
	public class XmlSchemaImport : XmlSchemaExternal
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaImport" />.
		///       </summary>
		// Token: 0x06003B4B RID: 15179 RVA: 0x0014E28F File Offset: 0x0014C48F
		public XmlSchemaImport()
		{
			base.Compositor = Compositor.Import;
		}

		/// <summary>
		///         Возвращает или задает целевое пространство имен для импортированной схемы в виде ссылки URI.
		///       </summary>
		/// <returns>
		///         Целевое пространство имен для импортированной схемы в виде ссылки URI.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x0014E29E File Offset: 0x0014C49E
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x0014E2A6 File Offset: 0x0014C4A6
		[XmlAttribute("namespace", DataType = "anyURI")]
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		/// <summary>
		///         Возвращает или задает свойство <see langword="annotation" />.
		///       </summary>
		/// <returns>
		///         Примечание.
		///       </returns>
		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x0014E2AF File Offset: 0x0014C4AF
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x0014E2B7 File Offset: 0x0014C4B7
		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		public XmlSchemaAnnotation Annotation
		{
			get
			{
				return this.annotation;
			}
			set
			{
				this.annotation = value;
			}
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x0014E2B7 File Offset: 0x0014C4B7
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.annotation = annotation;
		}

		// Token: 0x04002B72 RID: 11122
		private string ns;

		// Token: 0x04002B73 RID: 11123
		private XmlSchemaAnnotation annotation;
	}
}
