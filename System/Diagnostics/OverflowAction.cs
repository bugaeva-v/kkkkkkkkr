using System;

namespace System.Diagnostics
{
	/// <summary>Задает способ обработки записей в журнале событий, размер файла которого достиг максимально допустимой величины.</summary>
	// Token: 0x0200026F RID: 623
	public enum OverflowAction
	{
		/// <summary>Указывает на то, что при заполнении журнала событий существующие в нем записи сохраняются, а новые записи игнорируются.</summary>
		// Token: 0x04000B09 RID: 2825
		DoNotOverwrite = -1,
		/// <summary>Указывает на то, что при заполнении журнала событий каждая новая запись переопределяет самую старую запись.</summary>
		// Token: 0x04000B0A RID: 2826
		OverwriteAsNeeded,
		/// <summary>Указывает на то, что при заполнении журнала событий новые события переопределяют события, время существования которых превышает значение свойства <see cref="P:System.Diagnostics.EventLog.MinimumRetentionDays" />. Если журнал событий полон, а события, время существования которых превышает значение свойства <see cref="P:System.Diagnostics.EventLog.MinimumRetentionDays" />, отсутствуют, новые события игнорируются.</summary>
		// Token: 0x04000B0B RID: 2827
		OverwriteOlder
	}
}
