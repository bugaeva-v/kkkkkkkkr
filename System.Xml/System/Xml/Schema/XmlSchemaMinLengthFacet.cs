using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="minLength" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на минимальную длину значения данных <see langword="simpleType" /> элемента.
	///          Длина должна быть больше, чем значение <see langword="minLength" /> элемента.
	///       </summary>
	// Token: 0x020005B2 RID: 1458
	public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMinLengthFacet" />.
		///       </summary>
		// Token: 0x06003B11 RID: 15121 RVA: 0x0014DFEA File Offset: 0x0014C1EA
		public XmlSchemaMinLengthFacet()
		{
			base.FacetType = FacetType.MinLength;
		}
	}
}
