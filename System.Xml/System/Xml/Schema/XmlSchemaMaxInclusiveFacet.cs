using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="maxInclusive" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на максимальное значение <see langword="simpleType" /> элемента.
	///          Значение элемента должно быть меньше или равно значению <see langword="maxInclusive" /> элемента.
	///       </summary>
	// Token: 0x020005B9 RID: 1465
	public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMaxInclusiveFacet" />.
		///       </summary>
		// Token: 0x06003B18 RID: 15128 RVA: 0x0014E054 File Offset: 0x0014C254
		public XmlSchemaMaxInclusiveFacet()
		{
			base.FacetType = FacetType.MaxInclusive;
		}
	}
}
