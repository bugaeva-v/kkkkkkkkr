using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Позволяет подписаться на входящие события.
	///          Каждый раз при публикации требуемое событие в журнал событий <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события, и метод, который обрабатывает это событие будет выполняться.
	///       </summary>
	// Token: 0x020003AF RID: 943
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogWatcher : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogWatcher" /> класса путем указания запроса событий.
		///       </summary>
		/// <param name="eventQuery">
		///           Указывает запрос для подписки на событие.
		///            При регистрации события, соответствующего критериям, выраженное в запросе, то <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события.
		///         </param>
		// Token: 0x06001C27 RID: 7207 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogWatcher(EventLogQuery eventQuery)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogWatcher" /> класса путем указания запроса событий и закладка, которая используется в качестве начальной позиции для запроса.
		///       </summary>
		/// <param name="eventQuery">
		///           Указывает запрос для подписки на событие.
		///            При регистрации события, соответствующего критериям, выраженное в запросе, то <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события.
		///         </param>
		/// <param name="bookmark">
		///           Закладка (местозаполнитель), используемые в качестве начальной позиции в журнале событий или потоке событий.
		///            Только события, зарегистрированные после события закладки будет возвращаться в результатах запроса.
		///         </param>
		// Token: 0x06001C28 RID: 7208 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogWatcher" /> класс, указав запрос события, закладку, которая используется в качестве начальной позиции для запроса и логическое значение, определяющее, следует ли считывать события, уже существует в журнале событий.
		///       </summary>
		/// <param name="eventQuery">
		///           Указывает запрос для подписки на событие.
		///            При регистрации события, соответствующего критериям, выраженное в запросе, то <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события.
		///         </param>
		/// <param name="bookmark">
		///           Закладка (местозаполнитель), используемые в качестве начальной позиции в журнале событий или потоке событий.
		///            Только события, зарегистрированные после события закладки будет возвращаться в результатах запроса.
		///         </param>
		/// <param name="readExistingEvents">
		///           Логическое значение, определяющее, следует ли считывать события, которые уже существуют в журнале событий.
		///            Если это значение равно <see langword="true" />, затем считываются существующих событий, и если это значение равно <see langword="false" />, а затем существующих событий не считываются.
		///         </param>
		// Token: 0x06001C29 RID: 7209 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark, bool readExistingEvents)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogWatcher" /> класс, указав имя или путь к журналу событий.
		///       </summary>
		/// <param name="path">
		///           Путь или имя монитора журнала событий.
		///            Если любое событие регистрируется в журнале событий, а затем <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события.
		///         </param>
		// Token: 0x06001C2A RID: 7210 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogWatcher(string path)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Определяет, начинается ли данный объект доставки событий для делегата события.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Когда этот объект можно доставить события делегат события и возвращает <see langword="false" /> Когда этот объект был остановлен доставки.
		///       </returns>
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000235B File Offset: 0x0000055B
		public bool Enabled
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Позволяет задать делегат (метод обработчика событий), вызывается каждый раз при публикации события, соответствующего критериям, указанный в событии запроса для этого объекта.
		///       </summary>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06001C2D RID: 7213 RVA: 0x0000235B File Offset: 0x0000055B
		// (remove) Token: 0x06001C2E RID: 7214 RVA: 0x0000235B File Offset: 0x0000055B
		public event EventHandler<EventRecordWrittenEventArgs> EventRecordWritten
		{
			add
			{
				ThrowStub.ThrowNotSupportedException();
			}
			remove
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001C2F RID: 7215 RVA: 0x0000235B File Offset: 0x0000055B
		public void Dispose()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые этим объектом и при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x06001C30 RID: 7216 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
