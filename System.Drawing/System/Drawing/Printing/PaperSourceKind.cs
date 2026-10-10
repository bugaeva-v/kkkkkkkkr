using System;

namespace System.Drawing.Printing
{
	/// <summary>Стандартные источники бумаги.</summary>
	// Token: 0x020000BD RID: 189
	public enum PaperSourceKind
	{
		/// <summary>Верхний лоток принтера (или лоток по умолчанию, если это единственный имеющийся лоток).</summary>
		// Token: 0x040006E9 RID: 1769
		Upper = 1,
		/// <summary>Нижний лоток принтера.</summary>
		// Token: 0x040006EA RID: 1770
		Lower,
		/// <summary>Средний лоток принтера.</summary>
		// Token: 0x040006EB RID: 1771
		Middle,
		/// <summary>Подача бумаги вручную.</summary>
		// Token: 0x040006EC RID: 1772
		Manual,
		/// <summary>Конверт.</summary>
		// Token: 0x040006ED RID: 1773
		Envelope,
		/// <summary>Подача конверта вручную.</summary>
		// Token: 0x040006EE RID: 1774
		ManualFeed,
		/// <summary>Автоматическая подача бумаги.</summary>
		// Token: 0x040006EF RID: 1775
		AutomaticFeed,
		/// <summary>Подача с перфорацией.</summary>
		// Token: 0x040006F0 RID: 1776
		TractorFeed,
		/// <summary>Бумага малого размера.</summary>
		// Token: 0x040006F1 RID: 1777
		SmallFormat,
		/// <summary>Бумага большого размера.</summary>
		// Token: 0x040006F2 RID: 1778
		LargeFormat,
		/// <summary>Лоток большой емкости.</summary>
		// Token: 0x040006F3 RID: 1779
		LargeCapacity,
		/// <summary>Кассета с бумагой.</summary>
		// Token: 0x040006F4 RID: 1780
		Cassette = 14,
		/// <summary>Входной лоток принтера по умолчанию.</summary>
		// Token: 0x040006F5 RID: 1781
		FormSource,
		/// <summary>Специальный источник бумаги.</summary>
		// Token: 0x040006F6 RID: 1782
		Custom = 257
	}
}
