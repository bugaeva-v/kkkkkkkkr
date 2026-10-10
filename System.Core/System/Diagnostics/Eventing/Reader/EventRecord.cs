using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Security.Principal;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Определение свойств экземпляра события для события, полученные от <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> объекта.
	///          Свойства события предоставляют сведения о события, такие как имя компьютера, на котором было зарегистрировано событие и время создания события.
	///          Этот класс является абстрактным классом.
	///         <see cref="T:System.Diagnostics.Eventing.Reader.EventLogRecord" /> Класс реализует этот класс.
	///       </summary>
	// Token: 0x020003AB RID: 939
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public abstract class EventRecord : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" />.
		///       </summary>
		// Token: 0x06001BE3 RID: 7139 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventRecord()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) для действия в процессе, для которого используется событие.
		///          Это позволит потребителям группировать связанные действия.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID.
		///       </returns>
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001BE4 RID: 7140
		public abstract Guid? ActivityId { get; }

		/// <summary>
		///         Получает местозаполнитель (закладку), соответствующий на это событие.
		///          Это может использоваться в качестве местозаполнителя в потоке событий.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventBookmark" />.
		///       </returns>
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001BE5 RID: 7141
		public abstract EventBookmark Bookmark { get; }

		/// <summary>
		///         Возвращает идентификатор для данного события.
		///          Все события с данным идентификатором представляют один и тот же тип события.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001BE6 RID: 7142
		public abstract int Id { get; }

		/// <summary>
		///         Получает маску ключевого слова события.
		///          Получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventRecord.KeywordsDisplayNames" /> Свойства, чтобы получить имя ключевые слова, используемые в этой маски.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001BE7 RID: 7143
		public abstract long? Keywords { get; }

		/// <summary>
		///         Получает отображаемые имена ключевых слов, используемых в маске ключевых слов для данного события.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию строк, содержащих отображаемые имена ключевых слов, используемых в маске ключевых слов для данного события.
		///       </returns>
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001BE8 RID: 7144
		public abstract IEnumerable<string> KeywordsDisplayNames { get; }

		/// <summary>
		///         Возвращает уровень события.
		///          Данный уровень указывает серьезность события.
		///          Имя уровня, получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventRecord.LevelDisplayName" /> Свойства.
		///       </summary>
		/// <returns>
		///         Возвращает значение в байтах.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001BE9 RID: 7145
		public abstract byte? Level { get; }

		/// <summary>
		///         Возвращает отображаемое имя уровня для данного события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя уровня для данного события.
		///       </returns>
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001BEA RID: 7146
		public abstract string LevelDisplayName { get; }

		/// <summary>
		///         Возвращает имя журнала событий, где это событие регистрируется.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя журнала событий, который содержит это событие.
		///       </returns>
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001BEB RID: 7147
		public abstract string LogName { get; }

		/// <summary>
		///         Возвращает имя компьютера, на котором было зарегистрировано это событие.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя компьютера, на котором было зарегистрировано это событие.
		///       </returns>
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001BEC RID: 7148
		public abstract string MachineName { get; }

		/// <summary>
		///         Получает код операция события.
		///          Код операций определяет числовое значение, идентифицирующее действие или пункт действия, который приложение при вызове события.
		///          Для имени кода операции получения значения <see cref="P:System.Diagnostics.Eventing.Reader.EventRecord.OpcodeDisplayName" /> свойство.
		///       </summary>
		/// <returns>
		///         Возвращает короткое значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001BED RID: 7149
		public abstract short? Opcode { get; }

		/// <summary>
		///         Возвращает отображаемое имя кода операций для данного события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя кода операций для данного события.
		///       </returns>
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001BEE RID: 7150
		public abstract string OpcodeDisplayName { get; }

		/// <summary>
		///         Возвращает идентификатор процесса для поставщика событий, зарегистрировавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001BEF RID: 7151
		public abstract int? ProcessId { get; }

		/// <summary>
		///         Получает определяемые пользователем свойства события.
		///       </summary>
		/// <returns>
		///         Возвращает список <see cref="T:System.Diagnostics.Eventing.Reader.EventProperty" /> объектов.
		///       </returns>
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001BF0 RID: 7152
		public abstract IList<EventProperty> Properties { get; }

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) поставщика событий, опубликовавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001BF1 RID: 7153
		public abstract Guid? ProviderId { get; }

		/// <summary>
		///         Возвращает имя поставщика событий, опубликовавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя поставщика событий, опубликовавшего данное событие.
		///       </returns>
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001BF2 RID: 7154
		public abstract string ProviderName { get; }

		/// <summary>
		///         Получает номера квалификаторов, используемых для идентификации события.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001BF3 RID: 7155
		public abstract int? Qualifiers { get; }

		/// <summary>
		///         Получает идентификатор записи события в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001BF4 RID: 7156
		public abstract long? RecordId { get; }

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) для связанного действия в процессе, для которого задействуется событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001BF5 RID: 7157
		public abstract Guid? RelatedActivityId { get; }

		/// <summary>
		///         Получает идентификатор задачи для части приложения или компонента, публикующего событие.
		///          Задача — 16-разрядное значение с 16 максимальных значений зарезервировано.
		///          Этот тип позволяет использовать любое значение между 0x0000 и 0xffef для использования.
		///          Чтобы получить имя задачи, получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventRecord.TaskDisplayName" /> Свойства.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001BF6 RID: 7158
		public abstract int? Task { get; }

		/// <summary>
		///         Возвращает отображаемое имя задачи для события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя задачи для события.
		///       </returns>
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001BF7 RID: 7159
		public abstract string TaskDisplayName { get; }

		/// <summary>
		///         Получает идентификатор потока для потока, выполняющегося поставщика событий.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001BF8 RID: 7160
		public abstract int? ThreadId { get; }

		/// <summary>
		///         Возвращает время, в <see cref="T:System.DateTime" /> формате, что было создано событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see cref="T:System.DateTime" />.
		///          Может иметь значение NULL.
		///       </returns>
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001BF9 RID: 7161
		public abstract DateTime? TimeCreated { get; }

		/// <summary>
		///         Получает дескриптор безопасности пользователя, контекст которого используется для публикации события.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see cref="T:System.Security.Principal.SecurityIdentifier" />.
		///       </returns>
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001BFA RID: 7162
		public abstract SecurityIdentifier UserId { get; }

		/// <summary>
		///         Возвращает номер версии для события.
		///       </summary>
		/// <returns>
		///         Возвращает значение в байтах.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001BFB RID: 7163
		public abstract byte? Version { get; }

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001BFC RID: 7164 RVA: 0x0000235B File Offset: 0x0000055B
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
		// Token: 0x06001BFD RID: 7165 RVA: 0x0000235B File Offset: 0x0000055B
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает сообщение события в текущем языковом стандарте.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую сообщение события в текущем языковом стандарте.
		///       </returns>
		// Token: 0x06001BFE RID: 7166
		public abstract string FormatDescription();

		/// <summary>
		///         Получает сообщение события, замещая переменные в сообщении с указанными значениями.
		///       </summary>
		/// <param name="values">
		///           Значения, используемые для замещения переменных в сообщении о событии.
		///            Переменные представлены %n, где n является числом.
		///         </param>
		/// <returns>
		///         Возвращает строку, содержащую сообщение события в текущем языковом стандарте.
		///       </returns>
		// Token: 0x06001BFF RID: 7167
		public abstract string FormatDescription(IEnumerable<object> values);

		/// <summary>
		///         Возвращает XML-представление события.
		///          Все свойства события представлены в XML.
		///          XML соответствует приведенному event schema.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую XML-представление события.
		///       </returns>
		// Token: 0x06001C00 RID: 7168
		public abstract string ToXml();
	}
}
