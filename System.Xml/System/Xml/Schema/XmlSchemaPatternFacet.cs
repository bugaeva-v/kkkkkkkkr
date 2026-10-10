using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="pattern" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на значение, введенное для <see langword="simpleType" /> элемента.
	///       </summary>
	// Token: 0x020005B4 RID: 1460
	public class XmlSchemaPatternFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaPatternFacet" />.
		///       </summary>
		// Token: 0x06003B13 RID: 15123 RVA: 0x0014E008 File Offset: 0x0014C208
		public XmlSchemaPatternFacet()
		{
			base.FacetType = FacetType.Pattern;
		}
	}
}
