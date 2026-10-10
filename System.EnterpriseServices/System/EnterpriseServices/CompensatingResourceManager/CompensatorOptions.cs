using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Задает флаги, определяющие, какие этапы выполнения транзакции должны быть получены компенсатором CRM и должно ли быть прервано восстановление, если после его попытки остаются сомнительные транзакции.</summary>
	// Token: 0x02000074 RID: 116
	[Flags]
	[Serializable]
	public enum CompensatorOptions
	{
		/// <summary>Представляет этап подготовки.</summary>
		// Token: 0x040000B9 RID: 185
		PreparePhase = 1,
		/// <summary>Представляет этап фиксирования.</summary>
		// Token: 0x040000BA RID: 186
		CommitPhase = 2,
		/// <summary>Представляет этап прерывания.</summary>
		// Token: 0x040000BB RID: 187
		AbortPhase = 4,
		/// <summary>Представляет все этапы.</summary>
		// Token: 0x040000BC RID: 188
		AllPhases = 7,
		/// <summary>Прерывание при наличии сомнительных транзакций после попытки восстановления.</summary>
		// Token: 0x040000BD RID: 189
		FailIfInDoubtsRemain = 16
	}
}
