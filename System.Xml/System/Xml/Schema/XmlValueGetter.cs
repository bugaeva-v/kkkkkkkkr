using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         A <see langword="delegate" /> используемой <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> класса для передачи значения атрибута, текста и пробелы в качестве типа Common Language Runtime (CLR) совместим с типом языка определения схемы XML (XSD) из атрибута, текста или пустого пространства.
	///       </summary>
	/// <returns>
	///         Объект, содержащий значение атрибута, текста или пустого пространства.
	///          Объект является типом CLR, соответствующий типу XSD значение атрибута, текста или пустого пространства.
	///       </returns>
	// Token: 0x020005E7 RID: 1511
	// (Invoke) Token: 0x06003C8A RID: 15498
	public delegate object XmlValueGetter();
}
