using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="enumeration" /> аспекта из XML-схемы в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс задает список допустимых значений для элемента simpleType.
	///          Объявление содержится в <see langword="restriction" /> объявления.
	///       </summary>
	// Token: 0x020005B5 RID: 1461
	public class XmlSchemaEnumerationFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaEnumerationFacet" />.
		///       </summary>
		// Token: 0x06003B14 RID: 15124 RVA: 0x0014E017 File Offset: 0x0014C217
		public XmlSchemaEnumerationFacet()
		{
			base.FacetType = FacetType.Enumeration;
		}
	}
}
