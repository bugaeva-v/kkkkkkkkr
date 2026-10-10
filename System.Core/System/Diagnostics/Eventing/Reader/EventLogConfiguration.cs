using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит статические сведения и параметры конфигурации для журнала событий.
	///          Многие параметры конфигураций были определены поставщиком событий, создавшим журнал.
	///       </summary>
	// Token: 0x0200039A RID: 922
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogConfiguration : IDisposable
	{
		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogConfiguration" /> объекта, указав локальный журнал событий, для которого необходимо получить информацию и параметры конфигурации.
		///       </summary>
		/// <param name="logName">
		///           Имя локального журнала событий, для которого необходимо получить информацию и параметры конфигурации.
		///         </param>
		// Token: 0x06001B7A RID: 7034 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogConfiguration(string logName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogConfiguration" /> объектов путем указания имени журнала, для которого необходимо получить информацию и параметры конфигурации.
		///          Этот журнал может быть на локальном или удаленном компьютере, в зависимости от указанного сеанса журнала событий.
		///       </summary>
		/// <param name="logName">
		///           Имя журнала событий, для которого необходимо получить информацию и параметры конфигурации.
		///         </param>
		/// <param name="session">
		///           Сеанс журнала событий, используемый для определения службы журнала событий, к которой принадлежит указанный журнал.
		///            Сеанс или подключен к службе журнала событий на локальном или удаленном компьютере.
		///         </param>
		// Token: 0x06001B7B RID: 7035 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public EventLogConfiguration(string logName, EventLogSession session)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает флаг, который указывает, является ли журнал событий классическим журналом событий.
		///          Классический журнал событий, которое события которого определены в файле .mc вместо манифеста (XML-файл), используемый поставщиком событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если журнал событий является классическим журналом и возвращает <see langword="false" /> Если журнал событий не классический журнал.
		///       </returns>
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0005A56C File Offset: 0x0005876C
		public bool IsClassicLog
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>
		///         Возвращает или задает логическое значение, определяющее, включен ли журнал событий.
		///          Включенный журнал, в котором можно заносить в журнал события и отключенные журнал представляет собой одно в нельзя журнал событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> если журнал включен и возвращает <see langword="false" /> при отключении журнала.
		///       </returns>
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0005A588 File Offset: 0x00058788
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x0000235B File Offset: 0x0000055B
		public bool IsEnabled
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
		///         Возвращает или задает путь к каталогу файла расположение файла, где хранятся события в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую путь к файлу журнала событий.
		///       </returns>
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0000235B File Offset: 0x0000055B
		public string LogFilePath
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogIsolation" /> значение, указывающее, является ли журнал событий приложения, системы или настраиваемый журнал событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogIsolation" /> значение.
		///       </returns>
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0005A5A4 File Offset: 0x000587A4
		public EventLogIsolation LogIsolation
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return EventLogIsolation.Application;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogMode" /> значение, определяющее способ обработки событий при заполнении журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogMode" /> значение.
		///       </returns>
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0005A5C0 File Offset: 0x000587C0
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogMode LogMode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return EventLogMode.Circular;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает имя журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя журнала событий.
		///       </returns>
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0005A05A File Offset: 0x0005825A
		public string LogName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogType" /> значение, определяющее тип журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogType" /> значение.
		///       </returns>
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0005A5DC File Offset: 0x000587DC
		public EventLogType LogType
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return EventLogType.Administrative;
			}
		}

		/// <summary>
		///         Возвращает или задает максимальный размер в байтах, который может быть файл журнала событий.
		///          По достижении максимального размера файл считается заполненным.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long, представляющее максимальный размер в байтах, что файл журнала событий может быть.
		///       </returns>
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0005A5F8 File Offset: 0x000587F8
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000235B File Offset: 0x0000055B
		public long MaximumSizeInBytes
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает имя поставщика событий, создавшего данный журнал событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя поставщика событий, создавшего данный журнал событий.
		///       </returns>
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0005A05A File Offset: 0x0005825A
		public string OwningProviderName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает размер буфера, который использует поставщик событий для публикации событий в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение, которое может иметь значение null.
		///       </returns>
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0005A614 File Offset: 0x00058814
		public int? ProviderBufferSize
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает управления глобально уникальный идентификатор (GUID) для журнала событий, если журнал является журналом отладки.
		///          Если данный журнал не является журналом отладки, это значение будет равно null.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID или значение null.
		///       </returns>
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0005A630 File Offset: 0x00058830
		public Guid? ProviderControlGuid
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает или задает маску ключевого слова, используемого поставщиком событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение типа long, может иметь значение null, если поставщик событий не определил ключевые слова.
		///       </returns>
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0005A64C File Offset: 0x0005884C
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000235B File Offset: 0x0000055B
		public long? ProviderKeywords
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Получает максимальное время задержки используемый поставщиком событий при публикации событий в журнале.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение, которое может быть равно null, если время задержки не было указано поставщиком событий.
		///       </returns>
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0005A668 File Offset: 0x00058868
		public int? ProviderLatency
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает или задает максимальный уровень события (определяющий важность события), разрешено регистрироваться в журнале событий.
		///          Это значение определяется поставщиком событий.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение, которое может быть равно null, если максимальный уровень события не был определен в событии поставщика.
		///       </returns>
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0005A684 File Offset: 0x00058884
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x0000235B File Offset: 0x0000055B
		public int? ProviderLevel
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Получает максимальное количество буферов, используемых поставщиком событий при публикации событий в журнале событий.
		///       </summary>
		/// <returns>
		///         Возвращает целое значение, представляющее максимальное количество буферов, используемых поставщиком событий при публикации событий в журнале событий.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0005A6A0 File Offset: 0x000588A0
		public int? ProviderMaximumNumberOfBuffers
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает минимальное количество буферов, используемых поставщиком событий при публикации событий в журнале событий.
		///       </summary>
		/// <returns>
		///         Возвращает целое значение, представляющее минимальное количество буферов, используемых поставщиком событий при публикации событий в журнале событий.
		///          Это значение может быть null.
		///       </returns>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0005A6BC File Offset: 0x000588BC
		public int? ProviderMinimumNumberOfBuffers
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию имен всех поставщиков событий, которые могут публиковать события в данном журнале событий.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию строк, содержащих имена поставщиков событий.
		///       </returns>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IEnumerable<string> ProviderNames
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает или задает дескриптор безопасности журнала событий.
		///          Дескриптор безопасности определяет пользователей и группы пользователей, которые могут читать и записывать в журнал событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую дескриптор безопасности для журнала событий.
		///       </returns>
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000235B File Offset: 0x0000055B
		public string SecurityDescriptor
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001B95 RID: 7061 RVA: 0x0000235B File Offset: 0x0000055B
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
		// Token: 0x06001B96 RID: 7062 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Сохраняет параметры конфигурации 
		///       </summary>
		// Token: 0x06001B97 RID: 7063 RVA: 0x0000235B File Offset: 0x0000055B
		public void SaveChanges()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
