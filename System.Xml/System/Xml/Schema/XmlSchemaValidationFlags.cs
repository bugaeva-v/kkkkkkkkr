using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Задает параметры проверки схемы, используемые <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> и <see cref="T:System.Xml.XmlReader" /> классы.
	///       </summary>
	// Token: 0x020005E8 RID: 1512
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		/// <summary>
		///         Не обрабатывайте ограничения идентификации, встроенные схемы, указания по расположению схемы или предупреждений проверки схемы отчета.
		///       </summary>
		// Token: 0x04002BE3 RID: 11235
		None = 0,
		/// <summary>
		///         Обработайте внутренние схемы, найденные при проверке.
		///       </summary>
		// Token: 0x04002BE4 RID: 11236
		ProcessInlineSchema = 1,
		/// <summary>
		///         Указания по расположению схемы обработки (xsi:schemaLocation, xsi:noNamespaceSchemaLocation) во время проверки.
		///       </summary>
		// Token: 0x04002BE5 RID: 11237
		ProcessSchemaLocation = 2,
		/// <summary>
		///         Отчет при проверке были обнаружены предупреждения проверки схемы.
		///       </summary>
		// Token: 0x04002BE6 RID: 11238
		ReportValidationWarnings = 4,
		/// <summary>
		///         Обрабатывать ограничения идентификаторов (xs:ID, xs:IDREF, xs:key, xs:keyref, xs:unique) во время проверки.
		///       </summary>
		// Token: 0x04002BE7 RID: 11239
		ProcessIdentityConstraints = 8,
		/// <summary>
		///         Разрешить xml: * атрибутов, даже если они не определены в схеме.
		///          Атрибуты проверяются на основе их типа данных.
		///       </summary>
		// Token: 0x04002BE8 RID: 11240
		AllowXmlAttributes = 16
	}
}
