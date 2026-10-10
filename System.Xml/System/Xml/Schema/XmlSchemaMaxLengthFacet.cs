using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="maxLength" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс позволяет установить ограничение по максимальной длине для значения данных <see langword="simpleType" /> элемента.
	///          Длина должна быть меньше, чем значение <see langword="maxLength" /> элемента.
	///       </summary>
	// Token: 0x020005B3 RID: 1459
	public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaMaxLengthFacet" />.
		///       </summary>
		// Token: 0x06003B12 RID: 15122 RVA: 0x0014DFF9 File Offset: 0x0014C1F9
		public XmlSchemaMaxLengthFacet()
		{
			base.FacetType = FacetType.MaxLength;
		}
	}
}
