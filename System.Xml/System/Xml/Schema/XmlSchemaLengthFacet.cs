using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="length" /> аспекта из XML-схемы в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на длину <see langword="simpleType" /> элемент на типе данных.
	///       </summary>
	// Token: 0x020005B1 RID: 1457
	public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaLengthFacet" />.
		///       </summary>
		// Token: 0x06003B10 RID: 15120 RVA: 0x0014DFDB File Offset: 0x0014C1DB
		public XmlSchemaLengthFacet()
		{
			base.FacetType = FacetType.Length;
		}
	}
}
