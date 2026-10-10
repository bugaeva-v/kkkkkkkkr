using System;

namespace System.Diagnostics
{
	/// <summary>Определяет по типу события, должен ли прослушиватель осуществлять трассировку.</summary>
	// Token: 0x0200021E RID: 542
	public class EventTypeFilter : TraceFilter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventTypeFilter" />.</summary>
		/// <param name="level">Поразрядная комбинация значений <see cref="T:System.Diagnostics.SourceLevels" />, определяющая тип события подлежащих трассировке сообщений.</param>
		// Token: 0x06000FC3 RID: 4035 RVA: 0x000460BC File Offset: 0x000442BC
		public EventTypeFilter(SourceLevels level)
		{
			this.level = level;
		}

		/// <summary>Определяет, должен ли прослушиватель трассировки осуществлять трассировку события.</summary>
		/// <param name="cache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, представляющий кэш данных для события трассировки.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <param name="id">Номер идентификатора трассировки.</param>
		/// <param name="formatOrMessage">Формат, используемый для записи массива аргументов, или сообщение, которое необходимо записать.</param>
		/// <param name="args">Массив объектов аргумента.</param>
		/// <param name="data1">Объект данных трассировки.</param>
		/// <param name="data">Массив объектов данных трассировки.</param>
		/// <returns>Значение <see langword="true" />, если трассировка должна быть осуществлена; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000FC4 RID: 4036 RVA: 0x000460CB File Offset: 0x000442CB
		public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
		{
			return (eventType & (TraceEventType)this.level) > (TraceEventType)0;
		}

		/// <summary>Получает или задает тип события подлежащих трассировке сообщений.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Diagnostics.SourceLevels" />.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000460D8 File Offset: 0x000442D8
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000460E0 File Offset: 0x000442E0
		public SourceLevels EventType
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x040009A3 RID: 2467
		private SourceLevels level;
	}
}
