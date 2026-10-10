using System;

namespace System.Xml
{
	/// <summary>
	///         Задает способ обработки значения времени при преобразовании строки и <see cref="T:System.DateTime" />.
	///       </summary>
	// Token: 0x02000227 RID: 551
	public enum XmlDateTimeSerializationMode
	{
		/// <summary>
		///         Рассматривается как местное время.
		///          Если <see cref="T:System.DateTime" /> объект представляет время в формате UTC, он преобразуется в местное время.
		///       </summary>
		// Token: 0x040012B3 RID: 4787
		Local,
		/// <summary>
		///         Рассматривается как UTC.
		///          Если <see cref="T:System.DateTime" /> объект представляет локальное время, он преобразуется в формат UTC.
		///       </summary>
		// Token: 0x040012B4 RID: 4788
		Utc,
		/// <summary>
		///         Рассматривается как местное время, если <see cref="T:System.DateTime" /> преобразуется в строку.
		///       </summary>
		// Token: 0x040012B5 RID: 4789
		Unspecified,
		/// <summary>
		///         Сведения о часовом поясе должны сохраняться при преобразовании.
		///       </summary>
		// Token: 0x040012B6 RID: 4790
		RoundtripKind
	}
}
