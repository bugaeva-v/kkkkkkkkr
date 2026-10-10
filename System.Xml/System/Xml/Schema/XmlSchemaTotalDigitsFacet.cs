using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="totalDigits" /> аспекта из XML-схемы в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения ограничения на количество цифр, которые могут быть введены значения <see langword="simpleType" /> элемента.
	///          Это значение <see langword="totalDigits" /> должно быть положительным целым числом.
	///       </summary>
	// Token: 0x020005BA RID: 1466
	public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaTotalDigitsFacet" />.
		///       </summary>
		// Token: 0x06003B19 RID: 15129 RVA: 0x0014E064 File Offset: 0x0014C264
		public XmlSchemaTotalDigitsFacet()
		{
			base.FacetType = FacetType.TotalDigits;
		}
	}
}
