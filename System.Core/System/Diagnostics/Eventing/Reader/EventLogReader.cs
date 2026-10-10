using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Позволяет считывать события из журнала событий на основе запроса событий.
	///          События, которые считываются этот объект возвращается в виде <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> объектов.
	///       </summary>
	// Token: 0x020003A9 RID: 937
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogReader : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> класса путем указания запроса событий.
		///       </summary>
		/// <param name="eventQuery">
		///           Запрос события, используемый для извлечения событий.
		///         </param>
		// Token: 0x06001BD1 RID: 7121 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReader(EventLogQuery eventQuery)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> класса путем указания запроса событий и закладка, которая используется в качестве начальной позиции для запроса.
		///       </summary>
		/// <param name="eventQuery">
		///           Запрос события, используемый для извлечения событий.
		///         </param>
		/// <param name="bookmark">
		///           Закладка (местозаполнитель), используемые в качестве начальной позиции в журнале событий или потоке событий.
		///            Только события, зарегистрированные после события закладки будет возвращаться в результатах запроса.
		///         </param>
		// Token: 0x06001BD2 RID: 7122 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public EventLogReader(EventLogQuery eventQuery, EventBookmark bookmark)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> класса путем указания для получения событий из активного журнала событий.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий, чтобы извлечь события.
		///         </param>
		// Token: 0x06001BD3 RID: 7123 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReader(string path)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> класса путем указания имени для получения событий из журнала событий или путь к файлу журнала следует извлечь события.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий, чтобы извлечь события или путь к файлу журнала событий следует извлечь события.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		// Token: 0x06001BD4 RID: 7124 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReader(string path, PathType pathType)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает или задает количество событий, извлекаемых из потока событий при каждой операции считывания.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///       </returns>
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x0005A814 File Offset: 0x00058A14
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000235B File Offset: 0x0000055B
		public int BatchSize
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Получает состояние каждого журнала событий или файла журнала, связанного с запросом события в данном объекте.
		///       </summary>
		/// <returns>
		///         Возвращает список <see cref="T:System.Diagnostics.Eventing.Reader.EventLogStatus" /> объектов, содержащих сведения о журнале событий, связанных с запросом события в данном объекте состоянии.
		///       </returns>
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventLogStatus> LogStatus
		{
			[SecurityCritical]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Отменяет текущую операцию запроса.
		///       </summary>
		// Token: 0x06001BD8 RID: 7128 RVA: 0x0000235B File Offset: 0x0000055B
		public void CancelReading()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001BD9 RID: 7129 RVA: 0x0000235B File Offset: 0x0000055B
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
		// Token: 0x06001BDA RID: 7130 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Считывает следующее событие, возвращенные из запроса события в данном объекте.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> объекта.
		///       </returns>
		// Token: 0x06001BDB RID: 7131 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventRecord ReadEvent()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Считывает следующее событие, возвращенные из запроса события в данном объекте.
		///       </summary>
		/// <param name="timeout">
		///           Максимальное время, операции чтения для запуска до отмены операции.
		///         </param>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> объекта.
		///       </returns>
		// Token: 0x06001BDC RID: 7132 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecurityCritical]
		public EventRecord ReadEvent(TimeSpan timeout)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Изменяет позицию в потоке событий, источник следующего события, которое считывается путем указания события закладки.
		///          Нет события, зарегистрированные до события закладки, будут извлечены.
		///       </summary>
		/// <param name="bookmark">
		///           Закладка (местозаполнитель), используемые в качестве начальной позиции в журнале событий или потоке событий.
		///            Только события, зарегистрированные после события закладки будет возвращаться в результатах запроса.
		///         </param>
		// Token: 0x06001BDD RID: 7133 RVA: 0x0000235B File Offset: 0x0000055B
		public void Seek(EventBookmark bookmark)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Изменения позицию в потоке событий источник следующего события, которое считывается путем указания события закладки и числа смещения событий из закладки.
		///          События, не зарегистрированные до закладки с учетом смещения, будут извлечены.
		///       </summary>
		/// <param name="bookmark">
		///           Закладка (местозаполнитель), используемые в качестве начальной позиции в журнале событий или потоке событий.
		///            Только события, зарегистрированные после события закладки будет возвращаться в результатах запроса.
		///         </param>
		/// <param name="offset">
		///           Число смещения событий для изменения позиции закладки.
		///         </param>
		// Token: 0x06001BDE RID: 7134 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public void Seek(EventBookmark bookmark, long offset)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Изменяет позицию в потоке событий, источник следующего события, которое считывается путем указания начальной позиции и смещения от начальной позиции.
		///          Нет события, зарегистрированные до начальной позиции с учетом смещения, будут извлечены.
		///       </summary>
		/// <param name="origin">
		///           Значение из <see cref="T:System.IO.SeekOrigin" /> перечисление определяет, где в поток событий для запуска запроса событий.
		///         </param>
		/// <param name="offset">
		///           Число смещения событий для добавления к началу координат.
		///         </param>
		// Token: 0x06001BDF RID: 7135 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public void Seek(SeekOrigin origin, long offset)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
