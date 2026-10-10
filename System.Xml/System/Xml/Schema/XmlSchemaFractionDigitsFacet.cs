using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Задает ограничение на количество цифр, которые могут быть введены в дробной части элемента simpleType.
	///          Значение fractionDigits должен быть положительным целым числом.
	///          Представляет World Wide Web Consortium (W3C) <see langword="fractionDigits" /> аспекта.
	///       </summary>
	// Token: 0x020005BB RID: 1467
	public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaFractionDigitsFacet" />.
		///       </summary>
		// Token: 0x06003B1A RID: 15130 RVA: 0x0014E074 File Offset: 0x0014C274
		public XmlSchemaFractionDigitsFacet()
		{
			base.FacetType = FacetType.FractionDigits;
		}
	}
}
