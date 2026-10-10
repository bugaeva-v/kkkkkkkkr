using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="minInclusive" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на минимальное значение элемента simpleType.
	///          Значение элемента должно быть больше или равно значению <see langword="minInclusive" /> элемента.
	///       </summary>
	// Token: 0x020005B7 RID: 1463
	public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMinInclusiveFacet" />.
		///       </summary>
		// Token: 0x06003B16 RID: 15126 RVA: 0x0014E035 File Offset: 0x0014C235
		public XmlSchemaMinInclusiveFacet()
		{
			base.FacetType = FacetType.MinInclusive;
		}
	}
}
