using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="maxExclusive" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на максимальное значение <see langword="simpleType" /> элемента.
	///          Значение элемента должно быть меньше, чем значение <see langword="maxExclusive" /> элемента.
	///       </summary>
	// Token: 0x020005B8 RID: 1464
	public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMaxExclusiveFacet" />.
		///       </summary>
		// Token: 0x06003B17 RID: 15127 RVA: 0x0014E044 File Offset: 0x0014C244
		public XmlSchemaMaxExclusiveFacet()
		{
			base.FacetType = FacetType.MaxExclusive;
		}
	}
}
