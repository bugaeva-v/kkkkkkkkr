using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Устанавливает <see cref="P:System.Xml.Serialization.IXmlTextParser.Normalized" /> свойство для использования инфраструктурой платформы .NET Framework.
	///       </summary>
	// Token: 0x0200027C RID: 636
	public interface IXmlTextParser
	{
		/// <summary>
		///         Возвращает или задает значение, указывающее пробелы и значения атрибутов нормализуются.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если значения атрибутов пробелы нормализуются; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001810 RID: 6160
		// (set) Token: 0x06001811 RID: 6161
		bool Normalized { get; set; }

		/// <summary>
		///         Возвращает или задает способ обработки пробелов при синтаксическом анализе XML.
		///       </summary>
		/// <returns>
		///         Член <see cref="T:System.Xml.WhitespaceHandling" /> перечисление, которое описывает, каким образом темпа белом обрабатывается при синтаксическом анализе XML.
		///       </returns>
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001812 RID: 6162
		// (set) Token: 0x06001813 RID: 6163
		WhitespaceHandling WhitespaceHandling { get; set; }
	}
}
