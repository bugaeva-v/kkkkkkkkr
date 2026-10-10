using System;

namespace System.Data
{
	/// <summary>Определяет действие, которое выполняется при отсутствии сопоставления в исходной таблице или исходном столбце.</summary>
	// Token: 0x02000111 RID: 273
	public enum MissingMappingAction
	{
		/// <summary>Создается исходный столбец или исходная таблица, которая добавляется к <see cref="T:System.Data.DataSet" /> с использованием исходного имени.</summary>
		// Token: 0x04000989 RID: 2441
		Passthrough = 1,
		/// <summary>Столбец или таблица, для которых сопоставление отсутствует, игнорируются. Возвращает <see langword="null" />.</summary>
		// Token: 0x0400098A RID: 2442
		Ignore,
		/// <summary>Если отсутствует сопоставление указанного столбца, создается исключение <see cref="T:System.InvalidOperationException" />.</summary>
		// Token: 0x0400098B RID: 2443
		Error
	}
}
