using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Определяет набор сведений после проверки схемы для проверенного узла XML.
	///       </summary>
	// Token: 0x0200055E RID: 1374
	public interface IXmlSchemaInfo
	{
		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> значение этого проверенный узел XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> Проверяется значение этого XML-узла.
		///       </returns>
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600369B RID: 13979
		XmlSchemaValidity Validity { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если проверенный узел XML был установлен в результате значения по умолчанию, применяемого в ходе проверки схемы языка определения схем XML (XSD).
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если проверенный узел XML был установлен в результате значения по умолчанию, применяемого в ходе проверки схемы; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600369C RID: 13980
		bool IsDefault { get; }

		/// <summary>
		///         Возвращает значение, показывающее, если значение для этого проверенного XML-узла nil.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если значение для проверенный узел XML является пустым; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600369D RID: 13981
		bool IsNil { get; }

		/// <summary>
		///         Получает динамический тип схемы для этого проверенного XML-узла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> Объект, который представляет динамический тип схемы для этого проверенный узел XML.
		///       </returns>
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600369E RID: 13982
		XmlSchemaSimpleType MemberType { get; }

		/// <summary>
		///         Возвращает статический тип схемы языка определения схем XML (XSD) проверенный узел XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaType" /> Этого проверенный узел XML.
		///       </returns>
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600369F RID: 13983
		XmlSchemaType SchemaType { get; }

		/// <summary>
		///         Возвращает скомпилированный <see cref="T:System.Xml.Schema.XmlSchemaElement" /> соответствующий проверенный узел XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaElement" /> Соответствующий проверенный узел XML.
		///       </returns>
		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060036A0 RID: 13984
		XmlSchemaElement SchemaElement { get; }

		/// <summary>
		///         Возвращает скомпилированный <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> соответствующий проверенный узел XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> Соответствующий проверенный узел XML.
		///       </returns>
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060036A1 RID: 13985
		XmlSchemaAttribute SchemaAttribute { get; }
	}
}
