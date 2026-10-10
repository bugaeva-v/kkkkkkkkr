using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет World Wide Web Consortium (W3C) <see langword="selector" /> элемента.
	///       </summary>
	// Token: 0x020005C2 RID: 1474
	public class XmlSchemaXPath : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает атрибут для выражения XPath.
		///       </summary>
		/// <returns>
		///         Строковое значение атрибута для выражения XPath.
		///       </returns>
		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x0014E242 File Offset: 0x0014C442
		// (set) Token: 0x06003B44 RID: 15172 RVA: 0x0014E24A File Offset: 0x0014C44A
		[XmlAttribute("xpath")]
		[DefaultValue("")]
		public string XPath
		{
			get
			{
				return this.xpath;
			}
			set
			{
				this.xpath = value;
			}
		}

		// Token: 0x04002B70 RID: 11120
		private string xpath;
	}
}
