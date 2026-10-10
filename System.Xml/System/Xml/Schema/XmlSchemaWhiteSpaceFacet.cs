using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет World Wide Web Consortium (W3C) <see langword="whiteSpace" /> аспекта.
	///       </summary>
	// Token: 0x020005BC RID: 1468
	public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaWhiteSpaceFacet" />.
		///       </summary>
		// Token: 0x06003B1B RID: 15131 RVA: 0x0014E084 File Offset: 0x0014C284
		public XmlSchemaWhiteSpaceFacet()
		{
			base.FacetType = FacetType.Whitespace;
		}
	}
}
