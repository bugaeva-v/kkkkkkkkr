using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="minExclusive" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на минимальное значение <see langword="simpleType" /> элемента.
	///          Значение элемента должно быть больше, чем значение <see langword="minExclusive" /> элемента.
	///       </summary>
	// Token: 0x020005B6 RID: 1462
	public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMinExclusiveFacet" />.
		///       </summary>
		// Token: 0x06003B15 RID: 15125 RVA: 0x0014E026 File Offset: 0x0014C226
		public XmlSchemaMinExclusiveFacet()
		{
			base.FacetType = FacetType.MinExclusive;
		}
	}
}
