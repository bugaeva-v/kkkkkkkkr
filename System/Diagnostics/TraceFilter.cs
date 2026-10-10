using System;

namespace System.Diagnostics
{
	/// <summary>Представляет базовый класс для реализаций фильтров трассировки.</summary>
	// Token: 0x0200022E RID: 558
	public abstract class TraceFilter
	{
		/// <summary>При переопределении в производном классе определяет необходимость трассирования события прослушивателем трассировки.</summary>
		/// <param name="cache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий сведения о событии трассировки.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Номер идентификатора трассировки.</param>
		/// <param name="formatOrMessage">Формат, используемый для записи массива аргументов, заданных параметром <paramref name="args" />, или записываемое сообщение.</param>
		/// <param name="args">Массив объектов аргумента.</param>
		/// <param name="data1">Объект данных трассировки.</param>
		/// <param name="data">Массив объектов данных трассировки.</param>
		/// <returns>Значение <see langword="true" /> для трассировки указанного события; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001068 RID: 4200
		public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

		// Token: 0x06001069 RID: 4201 RVA: 0x0004745C File Offset: 0x0004565C
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage)
		{
			return this.ShouldTrace(cache, source, eventType, id, formatOrMessage, null, null, null);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0004747C File Offset: 0x0004567C
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args)
		{
			return this.ShouldTrace(cache, source, eventType, id, formatOrMessage, args, null, null);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0004749C File Offset: 0x0004569C
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1)
		{
			return this.ShouldTrace(cache, source, eventType, id, formatOrMessage, args, data1, null);
		}

		// Token: 0x040009E3 RID: 2531
		internal string initializeData;
	}
}
