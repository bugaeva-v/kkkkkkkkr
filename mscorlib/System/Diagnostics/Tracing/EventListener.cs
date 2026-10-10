using System;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
	/// <summary>Предоставляет методы для включения и отключения событий из источников событий.</summary>
	// Token: 0x020009F5 RID: 2549
	public class EventListener : IDisposable
	{
		/// <summary>Возвращает маленькое неотрицательное число, представляющее указанный источник события.</summary>
		/// <param name="eventSource">Источник события, для которого требуется найти индекс.</param>
		/// <returns>Маленькое неотрицательное число, представляющее указанный источник события.</returns>
		// Token: 0x06005AC6 RID: 23238 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public static int EventSourceIndex(EventSource eventSource)
		{
			return 0;
		}

		/// <summary>Включает события для заданного источника событий, который содержит указанный уровень детализации или ниже.</summary>
		/// <param name="eventSource">Источник события, для которого требуется включить события.</param>
		/// <param name="level">Уровень событий, который требуется разрешить.</param>
		// Token: 0x06005AC7 RID: 23239 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void EnableEvents(EventSource eventSource, EventLevel level)
		{
		}

		/// <summary>Включает события для заданного источника события, который содержит указанный уровень детализации или ниже, и соответствующие флаги ключевого слова.</summary>
		/// <param name="eventSource">Источник события, для которого требуется включить события.</param>
		/// <param name="level">Уровень событий, который требуется разрешить.</param>
		/// <param name="matchAnyKeyword">Флаги ключевых слов, необходимые для включения событий.</param>
		// Token: 0x06005AC8 RID: 23240 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword)
		{
		}

		/// <summary>Включает события для заданного источника события, который содержит указанный уровень детализации или ниже, соответствующие флаги ключевого слова и аргументы.</summary>
		/// <param name="eventSource">Источник события, для которого требуется включить события.</param>
		/// <param name="level">Уровень событий, который требуется разрешить.</param>
		/// <param name="matchAnyKeyword">Флаги ключевых слов, необходимые для включения событий.</param>
		/// <param name="arguments">Аргументы, сопоставляемые для реализации событий.</param>
		// Token: 0x06005AC9 RID: 23241 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> arguments)
		{
		}

		/// <summary>Отключает все события для заданного источника события.</summary>
		/// <param name="eventSource">Источник событий, для которого требуется отключить события.</param>
		// Token: 0x06005ACA RID: 23242 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void DisableEvents(EventSource eventSource)
		{
		}

		/// <summary>Вызывается для всех существующих источников событий, когда прослушиватель события создан и когда новый источник события вложен в прослушиватель.</summary>
		/// <param name="eventSource">Источник события.</param>
		// Token: 0x06005ACB RID: 23243 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected internal virtual void OnEventSourceCreated(EventSource eventSource)
		{
		}

		/// <summary>Вызывается, когда событие было записано источником события, для которого прослушиватель события включил события.</summary>
		/// <param name="eventData">Аргументы события, описывающие событие.</param>
		// Token: 0x06005ACC RID: 23244 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData)
		{
		}

		/// <summary>Освобождает ресурсы, используемые текущим экземпляром класса <see cref="T:System.Diagnostics.Tracing.EventListener" />.</summary>
		// Token: 0x06005ACD RID: 23245 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void Dispose()
		{
		}

		/// <summary>Происходит, когда источник событий (объект <see cref="T:System.Diagnostics.Tracing.EventSource" />) подключается к диспетчеру.</summary>
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06005ACE RID: 23246 RVA: 0x00134468 File Offset: 0x00132668
		// (remove) Token: 0x06005ACF RID: 23247 RVA: 0x001344A0 File Offset: 0x001326A0
		public event EventHandler<EventSourceCreatedEventArgs> EventSourceCreated;

		/// <summary>Происходит, когда событие записано источником события (объектом <see cref="T:System.Diagnostics.Tracing.EventSource" />), для которого прослушиватель события включил события.</summary>
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06005AD0 RID: 23248 RVA: 0x001344D8 File Offset: 0x001326D8
		// (remove) Token: 0x06005AD1 RID: 23249 RVA: 0x00134510 File Offset: 0x00132710
		public event EventHandler<EventWrittenEventArgs> EventWritten;
	}
}
