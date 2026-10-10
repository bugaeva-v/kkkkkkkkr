using System;

namespace System.Reflection.Emit
{
	/// <summary>Задает один из двух факторов, определяющих выравнивание памяти полей при маршалинге типа.</summary>
	// Token: 0x02000909 RID: 2313
	public enum PackingSize
	{
		/// <summary>Упаковочный размер не задан.</summary>
		// Token: 0x0400309E RID: 12446
		Unspecified,
		/// <summary>Упаковочный размер равен 1 байту.</summary>
		// Token: 0x0400309F RID: 12447
		Size1,
		/// <summary>Упаковочный размер равен 2 байтам.</summary>
		// Token: 0x040030A0 RID: 12448
		Size2,
		/// <summary>Упаковочный размер равен 4 байтам.</summary>
		// Token: 0x040030A1 RID: 12449
		Size4 = 4,
		/// <summary>Упаковочный размер равен 8 байтам.</summary>
		// Token: 0x040030A2 RID: 12450
		Size8 = 8,
		/// <summary>Упаковочный размер равен 16 байтам.</summary>
		// Token: 0x040030A3 RID: 12451
		Size16 = 16,
		/// <summary>Упаковочный размер равен 32 байтам.</summary>
		// Token: 0x040030A4 RID: 12452
		Size32 = 32,
		/// <summary>Упаковочный размер равен 64 байтам.</summary>
		// Token: 0x040030A5 RID: 12453
		Size64 = 64,
		/// <summary>Упаковочный размер равен 128 байтам.</summary>
		// Token: 0x040030A6 RID: 12454
		Size128 = 128
	}
}
