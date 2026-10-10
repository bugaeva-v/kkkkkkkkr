using System;

namespace System
{
	/// <summary>Представляет базовый класс для классов, содержащих данные событий, и предоставляет значение для событий, не содержащих данных.</summary>
	// Token: 0x02000115 RID: 277
	[Serializable]
	public class EventArgs
	{
		/// <summary>Содержит значение, которое использовать с событиями, которые не содержат данные события.</summary>
		// Token: 0x040010E2 RID: 4322
		public static readonly EventArgs Empty = new EventArgs();
	}
}
