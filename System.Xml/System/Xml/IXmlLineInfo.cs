using System;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет интерфейс для включения класса, возвращающего сведения о строке о позиции.
	///       </summary>
	// Token: 0x020001E2 RID: 482
	public interface IXmlLineInfo
	{
		/// <summary>
		///         Возвращает значение, определяющее возможность возвращения классом сведений о строке.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если могут быть предоставлены свойства <see cref="P:System.Xml.IXmlLineInfo.LineNumber" /> и <see cref="P:System.Xml.IXmlLineInfo.LinePosition" />, в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x0600131B RID: 4891
		bool HasLineInfo();

		/// <summary>
		///         Возвращает номер текущей строки.
		///       </summary>
		/// <returns>
		///         Номер текущей строки или 0, если нет строки информации (например, <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" /> возвращает <see langword="false" />).
		///       </returns>
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600131C RID: 4892
		int LineNumber { get; }

		/// <summary>
		///         Возвращает позицию в текущей строке.
		///       </summary>
		/// <returns>
		///         Текущее положение строки или 0, если нет строки информации (например, <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" /> возвращает <see langword="false" />).
		///       </returns>
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600131D RID: 4893
		int LinePosition { get; }
	}
}
