using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит статическую информацию о поставщике событий, такие как имя и идентификатор поставщика, а также коллекцию событий, определенных в поставщике.
	///       </summary>
	// Token: 0x020003B4 RID: 948
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class ProviderMetadata : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.ProviderMetadata" /> класса путем указания имени поставщика, который вы хотите получить сведения о.
		///       </summary>
		/// <param name="providerName">
		///           Имя поставщика событий, который вы хотите получить сведения о.
		///         </param>
		// Token: 0x06001C47 RID: 7239 RVA: 0x0000235B File Offset: 0x0000055B
		public ProviderMetadata(string providerName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.ProviderMetadata" /> класса путем указания имени поставщика, чтобы получить сведения о службе журнала событий, который зарегистрирован поставщик и язык, который требуется возвратить информацию.
		///       </summary>
		/// <param name="providerName">
		///           Имя поставщика событий, который вы хотите получить сведения о.
		///         </param>
		/// <param name="session">
		///           <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> Объект, который указывает, следует ли получить сведения о поставщике из поставщика на локальном компьютере или поставщика на удаленном компьютере.
		///         </param>
		/// <param name="targetCultureInfo">
		///           Язык и региональные параметры, язык, данные должны быть возвращены в по.
		///         </param>
		// Token: 0x06001C48 RID: 7240 RVA: 0x0000235B File Offset: 0x0000055B
		public ProviderMetadata(string providerName, EventLogSession session, CultureInfo targetCultureInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает локализованное имя поставщика событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую локализованное имя поставщика событий.
		///       </returns>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0005A05A File Offset: 0x0005825A
		public string DisplayName
		{
			[SecurityCritical]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventMetadata" /> объектов, каждый из которых представляет событие, определенных в поставщике.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventMetadata" /> объектов.
		///       </returns>
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IEnumerable<EventMetadata> Events
		{
			[SecurityCritical]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Получает базовый URL-адрес, используемый для формирования запросов справки для событий в этом поставщике событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see cref="T:System.Uri" />.
		///       </returns>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0005A05A File Offset: 0x0005825A
		public Uri HelpLink
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает глобальный уникальный идентификатор (GUID) для поставщика событий.
		///       </summary>
		/// <returns>
		///         Возвращает значение GUID для поставщика событий.
		///       </returns>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0005AA7C File Offset: 0x00058C7C
		public Guid Id
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(Guid);
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventKeyword" /> объектов, каждый из которых представляет ключевое слово event, определенные в событии поставщика.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventKeyword" /> объектов.
		///       </returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventKeyword> Keywords
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventLevel" /> объектов, каждый из которых представляет уровень, определенные в событии поставщика.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventLevel" /> объектов.
		///       </returns>
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventLevel> Levels
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventLogLink" /> объектов, каждый из которых представляет ссылку в журнал событий, который используется поставщиком событий.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventLogLink" /> объектов.
		///       </returns>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventLogLink> LogLinks
		{
			[SecurityCritical]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает путь к файлу, содержащему ресурс таблицы сообщений, содержащий строки, связанные с поставщиком метаданных.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую путь поставщика файл сообщения.
		///       </returns>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0005A05A File Offset: 0x0005825A
		public string MessageFilePath
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает уникальное имя поставщика событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую уникальное имя поставщика событий.
		///       </returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventOpcode" /> объектов, каждый из которых представляет код операции, определенные в событии поставщика.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventOpcode" /> объектов.
		///       </returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventOpcode> Opcodes
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает путь к файлу, содержащему ресурс таблицы сообщений, содержащий строки, используемые для замены параметров в описаниях события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую путь к файлу, содержащему ресурс таблицы сообщений, содержащий строки, используемые для замены параметров в описаниях события.
		///       </returns>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0005A05A File Offset: 0x0005825A
		public string ParameterFilePath
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает путь к файлу, содержащему метаданные, связанные с поставщиком.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую путь к файлу, содержащему метаданные, связанные с поставщиком.
		///       </returns>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0005A05A File Offset: 0x0005825A
		public string ResourceFilePath
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventTask" /> объектов, каждый из которых представляет задачу, которая имеет определенные события поставщика.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию <see cref="T:System.Diagnostics.Eventing.Reader.EventTask" /> объектов.
		///       </returns>
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IList<EventTask> Tasks
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001C56 RID: 7254 RVA: 0x0000235B File Offset: 0x0000055B
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
		// Token: 0x06001C57 RID: 7255 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
