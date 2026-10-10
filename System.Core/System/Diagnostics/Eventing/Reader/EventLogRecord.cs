using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит свойства экземпляра события для события, полученные от <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReader" /> объекта.
	///          Свойства события предоставляют сведения о событии, такие как имя компьютера, на котором было зарегистрировано событие и время создания события.
	///       </summary>
	// Token: 0x020003AE RID: 942
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogRecord : EventRecord
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventLogRecord()
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
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x0005A84C File Offset: 0x00058A4C
		public override Guid? ActivityId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает местозаполнитель (закладку), соответствующий на это событие.
		///          Это может использоваться в качестве местозаполнителя в потоке событий.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventBookmark" />.
		///       </returns>
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0005A05A File Offset: 0x0005825A
		public override EventBookmark Bookmark
		{
			[SecuritySafeCritical]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает имя журнала событий или файла журнала событий, в котором хранится событие.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя журнала событий или файла журнала событий, в котором хранится событие.
		///       </returns>
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0005A05A File Offset: 0x0005825A
		public string ContainerLog
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает идентификатор для данного события.
		///          Все события с данным идентификатором представляют один и тот же тип события.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0005A868 File Offset: 0x00058A68
		public override int Id
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает маску ключевого слова события.
		///          Получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventLogRecord.KeywordsDisplayNames" /> Свойства, чтобы получить имя ключевые слова, используемые в этой маски.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0005A884 File Offset: 0x00058A84
		public override long? Keywords
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает отображаемые имена ключевых слов, используемых в маске ключевых слов для этого события.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию строк, содержащих отображаемые имена ключевых слов, используемых в маске ключевых слов для этого события.
		///       </returns>
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public override IEnumerable<string> KeywordsDisplayNames
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает уровень события.
		///          Данный уровень указывает серьезность события.
		///          Имя уровня, получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventLogRecord.LevelDisplayName" /> Свойства.
		///       </summary>
		/// <returns>
		///         Возвращает значение в байтах.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		public override byte? Level
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает отображаемое имя уровня для данного события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя уровня для данного события.
		///       </returns>
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string LevelDisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает имя журнала событий, где это событие регистрируется.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя журнала событий, который содержит это событие.
		///       </returns>
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string LogName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает имя компьютера, на котором было зарегистрировано это событие.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя компьютера, на котором было зарегистрировано это событие.
		///       </returns>
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string MachineName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает список идентификаторов запроса, которым соответствует данное событие.
		///          Данное событие соответствует запроса, если запрос будет возвращать это событие.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию целых значений.
		///       </returns>
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IEnumerable<int> MatchedQueryIds
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает код операция события.
		///          Код операций определяет числовое значение, идентифицирующее действие или пункт действия, который приложение при вызове события.
		///          Для имени кода операции получения значения <see cref="P:System.Diagnostics.Eventing.Reader.EventLogRecord.OpcodeDisplayName" /> свойство.
		///       </summary>
		/// <returns>
		///         Возвращает короткое значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0005A8BC File Offset: 0x00058ABC
		public override short? Opcode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает отображаемое имя кода операций для данного события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя кода операций для данного события.
		///       </returns>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string OpcodeDisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает идентификатор процесса для поставщика событий, зарегистрировавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0005A8D8 File Offset: 0x00058AD8
		public override int? ProcessId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает определяемые пользователем свойства события.
		///       </summary>
		/// <returns>
		///         Возвращает список <see cref="T:System.Diagnostics.Eventing.Reader.EventProperty" /> объектов.
		///       </returns>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public override IList<EventProperty> Properties
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) поставщика событий, опубликовавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0005A8F4 File Offset: 0x00058AF4
		public override Guid? ProviderId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает имя поставщика событий, опубликовавшего данное событие.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя поставщика событий, опубликовавшего данное событие.
		///       </returns>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string ProviderName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает номера квалификаторов, используемых для идентификации события.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0005A910 File Offset: 0x00058B10
		public override int? Qualifiers
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает идентификатор записи события в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0005A92C File Offset: 0x00058B2C
		public override long? RecordId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) для связанного действия в процессе, для которого задействуется событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0005A948 File Offset: 0x00058B48
		public override Guid? RelatedActivityId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает идентификатор задачи для части приложения или компонента, публикующего событие.
		///          Задача — 16-разрядное значение с 16 максимальных значений зарезервировано.
		///          Этот тип позволяет использовать любое значение между 0x0000 и 0xffef для использования.
		///          Для имени задачи, получить значение <see cref="P:System.Diagnostics.Eventing.Reader.EventLogRecord.TaskDisplayName" /> Свойства.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0005A964 File Offset: 0x00058B64
		public override int? Task
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает отображаемое имя задачи для события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую отображаемое имя задачи для события.
		///       </returns>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string TaskDisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает идентификатор потока для потока, выполняющегося поставщика событий.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0005A980 File Offset: 0x00058B80
		public override int? ThreadId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает время, в <see cref="T:System.DateTime" /> формате, что было создано событие.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see cref="T:System.DateTime" />.
		///          Может иметь значение NULL.
		///       </returns>
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0005A99C File Offset: 0x00058B9C
		public override DateTime? TimeCreated
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает дескриптор безопасности пользователя, контекст которого используется для публикации события.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see cref="T:System.Security.Principal.SecurityIdentifier" />.
		///       </returns>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0005A05A File Offset: 0x0005825A
		public override SecurityIdentifier UserId
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает номер версии для события.
		///       </summary>
		/// <returns>
		///         Возвращает значение в байтах.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0005A9B8 File Offset: 0x00058BB8
		public override byte? Version
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые этим объектом и при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x06001C22 RID: 7202 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected override void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает сообщение события в текущем языковом стандарте.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую сообщение события в текущем языковом стандарте.
		///       </returns>
		// Token: 0x06001C23 RID: 7203 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string FormatDescription()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

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
		// Token: 0x06001C24 RID: 7204 RVA: 0x0005A05A File Offset: 0x0005825A
		public override string FormatDescription(IEnumerable<object> values)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Возвращает перечисление значений свойств определяемых пользователем событий или результаты данных на основе XPath, если событие имеет представление XML.
		///       </summary>
		/// <param name="propertySelector">
		///           Выбирает возвращаемые значения свойств.
		///         </param>
		/// <returns>
		///         Возвращает список объектов.
		///       </returns>
		// Token: 0x06001C25 RID: 7205 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<object> GetPropertyValues(EventLogPropertySelector propertySelector)
		{
			ThrowStub.ThrowNotSupportedException();
			return 0;
		}

		/// <summary>
		///         Возвращает XML-представление события.
		///          Все свойства события представлены в XML события.
		///          XML соответствует приведенному event schema.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую XML-представление события.
		///       </returns>
		// Token: 0x06001C26 RID: 7206 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public override string ToXml()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
