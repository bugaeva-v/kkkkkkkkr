using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Задает отслеживание событий запуска и остановки действия. Следует использовать только младшие 24 бита. Дополнительные сведения см. в разделах <see cref="T:System.Diagnostics.Tracing.EventSourceOptions" /> и <see cref="M:System.Diagnostics.Tracing.EventSource.Write(System.String,System.Diagnostics.Tracing.EventSourceOptions)" />.</summary>
	// Token: 0x020009E6 RID: 2534
	[Flags]
	public enum EventTags
	{
		/// <summary>Не указывает тег и равняется нулю.</summary>
		// Token: 0x040037E7 RID: 14311
		None = 0
	}
}
