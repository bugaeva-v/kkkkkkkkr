using System;
using System.Collections.ObjectModel;
using Unity;

namespace System.Diagnostics.Tracing
{
	/// <summary>Предоставляет данные для обратного вызова <see cref="M:System.Diagnostics.Tracing.EventListener.OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs)" />.</summary>
	// Token: 0x020009FC RID: 2556
	public class EventWrittenEventArgs : EventArgs
	{
		// Token: 0x06005B1F RID: 23327 RVA: 0x0013483A File Offset: 0x00132A3A
		internal EventWrittenEventArgs(EventSource eventSource)
		{
			this.EventSource = eventSource;
		}

		/// <summary>Получает идентификатор действий в потоке, куда было записано событие.</summary>
		/// <returns>Идентификатор действий в потоке, куда было записано событие.</returns>
		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x00134849 File Offset: 0x00132A49
		public Guid ActivityId
		{
			get
			{
				return EventSource.CurrentThreadActivityId;
			}
		}

		/// <summary>Возвращает канал события.</summary>
		/// <returns>Канал события.</returns>
		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06005B21 RID: 23329 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public EventChannel Channel
		{
			get
			{
				return EventChannel.None;
			}
		}

		/// <summary>Возвращает идентификатор события.</summary>
		/// <returns>Идентификатор события.</returns>
		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x00134850 File Offset: 0x00132A50
		// (set) Token: 0x06005B23 RID: 23331 RVA: 0x00134858 File Offset: 0x00132A58
		public int EventId { get; internal set; }

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x00134861 File Offset: 0x00132A61
		// (set) Token: 0x06005B25 RID: 23333 RVA: 0x00134869 File Offset: 0x00132A69
		public long OSThreadId { get; internal set; }

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x00134872 File Offset: 0x00132A72
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x0013487A File Offset: 0x00132A7A
		public DateTime TimeStamp { get; internal set; }

		/// <summary>Возвращает имя события.</summary>
		/// <returns>Имя события.</returns>
		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x00134883 File Offset: 0x00132A83
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x0013488B File Offset: 0x00132A8B
		public string EventName { get; internal set; }

		/// <summary>Возвращает объект источника события.</summary>
		/// <returns>Объект источника события.</returns>
		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x00134894 File Offset: 0x00132A94
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x0013489C File Offset: 0x00132A9C
		public EventSource EventSource { get; private set; }

		/// <summary>Возвращает ключевые слова для события.</summary>
		/// <returns>Ключевые слова для события.</returns>
		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x0005CD46 File Offset: 0x0005AF46
		public EventKeywords Keywords
		{
			get
			{
				return EventKeywords.None;
			}
		}

		/// <summary>Возвращает уровень события.</summary>
		/// <returns>Уровень события.</returns>
		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public EventLevel Level
		{
			get
			{
				return EventLevel.LogAlways;
			}
		}

		/// <summary>Возвращает сообщение для события.</summary>
		/// <returns>Сообщение для события.</returns>
		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x001348A5 File Offset: 0x00132AA5
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x001348AD File Offset: 0x00132AAD
		public string Message { get; internal set; }

		/// <summary>Возвращает код операции для события.</summary>
		/// <returns>Код операции для события.</returns>
		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public EventOpcode Opcode
		{
			get
			{
				return EventOpcode.Info;
			}
		}

		/// <summary>Возвращает полезные данные для события.</summary>
		/// <returns>Полезные данные для события.</returns>
		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x001348B6 File Offset: 0x00132AB6
		// (set) Token: 0x06005B32 RID: 23346 RVA: 0x001348BE File Offset: 0x00132ABE
		public ReadOnlyCollection<object> Payload { get; internal set; }

		/// <summary>Возвращает список строк, представляющих имена свойств события.</summary>
		/// <returns>Возвращает <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x001348C7 File Offset: 0x00132AC7
		// (set) Token: 0x06005B34 RID: 23348 RVA: 0x001348CF File Offset: 0x00132ACF
		public ReadOnlyCollection<string> PayloadNames { get; internal set; }

		/// <summary>Возвращает идентификатор действия, которое связано с действием, представленным текущим экземпляром.</summary>
		/// <returns>Идентификатор связанного действия, либо значение <see cref="F:System.Guid.Empty" />, если отсутствует связанная действие.</returns>
		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06005B35 RID: 23349 RVA: 0x001348D8 File Offset: 0x00132AD8
		// (set) Token: 0x06005B36 RID: 23350 RVA: 0x001348E0 File Offset: 0x00132AE0
		public Guid RelatedActivityId { get; internal set; }

		/// <summary>Возвращает указанные теги в вызове метода <see cref="M:System.Diagnostics.Tracing.EventSource.Write(System.String,System.Diagnostics.Tracing.EventSourceOptions)" />.</summary>
		/// <returns>Возвращает <see cref="T:System.Diagnostics.Tracing.EventTags" />.</returns>
		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public EventTags Tags
		{
			get
			{
				return EventTags.None;
			}
		}

		/// <summary>Возвращает задачу для события.</summary>
		/// <returns>Задача для события.</returns>
		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public EventTask Task
		{
			get
			{
				return EventTask.None;
			}
		}

		/// <summary>Возвращает версию события.</summary>
		/// <returns>Версия события.</returns>
		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public byte Version
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x000173AD File Offset: 0x000155AD
		internal EventWrittenEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
