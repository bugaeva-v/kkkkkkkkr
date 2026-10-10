using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Используется для доступа к службе журнала событий на локальном или удаленном компьютере, поэтому можно управлять и сбора информации о журналах событий и поставщиков событий на компьютере.
	///       </summary>
	// Token: 0x0200039B RID: 923
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogSession : IDisposable
	{
		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> объекта, устанавливает соединение с локальной службой журнала событий.
		///       </summary>
		// Token: 0x06001B98 RID: 7064 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public EventLogSession()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> а также устанавливает соединение со службой журнала событий на указанном компьютере.
		///          Учетные данные (имя пользователя и пароль) пользователя, вызывающего метод используется для учетных данных для доступа к серверу терминалов.
		///       </summary>
		/// <param name="server">
		///           Имя компьютера, на котором для подключения к службе журнала событий.
		///         </param>
		// Token: 0x06001B99 RID: 7065 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogSession(string server)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> а также устанавливает соединение со службой журнала событий на указанном компьютере.
		///          Указанные учетные данные (имя пользователя и пароль) используются для учетных данных для доступа к серверу терминалов.
		///       </summary>
		/// <param name="server">
		///           Имя компьютера, на котором для подключения к службе журнала событий.
		///         </param>
		/// <param name="domain">
		///           Домен указанного пользователя.
		///         </param>
		/// <param name="user">
		///           Имя пользователя, используемое для подключения к удаленному компьютеру.
		///         </param>
		/// <param name="password">
		///           Пароль, используемый для подключения к удаленному компьютеру.
		///         </param>
		/// <param name="logOnType">
		///           Тип соединения для подключения к удаленному компьютеру.
		///         </param>
		// Token: 0x06001B9A RID: 7066 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public EventLogSession(string server, string domain, string user, SecureString password, SessionAuthentication logOnType)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает статический предопределенный объект сеанса, подключается к службе журнала событий на локальном компьютере.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogSession" /> представляющий предопределенный объект сеанса, подключается к службе журнала событий на локальном компьютере.
		///       </returns>
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0005A05A File Offset: 0x0005825A
		public static EventLogSession GlobalSession
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Отменяет любые операции (например, чтение журнала событий или подписка на журнал событий), которые активны в данный момент для службы журнала событий, который подключен этот объект сеанса.
		///       </summary>
		// Token: 0x06001B9C RID: 7068 RVA: 0x0000235B File Offset: 0x0000055B
		public void CancelCurrentOperations()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Удаляет события из указанного журнала событий.
		///       </summary>
		/// <param name="logName">
		///           Имя журнала событий, чтобы очистить все события.
		///         </param>
		// Token: 0x06001B9D RID: 7069 RVA: 0x0000235B File Offset: 0x0000055B
		public void ClearLog(string logName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Удаляет события из указанного журнала событий и сохраняет удаленные события в указанном файле.
		///       </summary>
		/// <param name="logName">
		///           Имя журнала событий, чтобы очистить все события.
		///         </param>
		/// <param name="backupPath">
		///           Путь к файлу, в котором будут сохранены удаленные события.
		///            Файл должен заканчиваться .evtx.
		///         </param>
		// Token: 0x06001B9E RID: 7070 RVA: 0x0000235B File Offset: 0x0000055B
		public void ClearLog(string logName, string backupPath)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001B9F RID: 7071 RVA: 0x0000235B File Offset: 0x0000055B
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
		// Token: 0x06001BA0 RID: 7072 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Экспортирует события во внешний файл журнала.
		///          События хранятся без сообщений о событиях.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий, чтобы экспорт событий или путь к файлу журнала событий для экспорта событий из.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <param name="query">
		///           Запрос, используемый для выбора экспортируемых событий.
		///             Будут экспортированы только события, возвращенные из запроса.
		///         </param>
		/// <param name="targetFilePath">
		///           Путь к файлу журнала (с расширением .evtx), в котором будут храниться экспортированные события после выполнения данного метода.
		///         </param>
		// Token: 0x06001BA1 RID: 7073 RVA: 0x0000235B File Offset: 0x0000055B
		public void ExportLog(string path, PathType pathType, string query, string targetFilePath)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Экспортирует события во внешний файл журнала.
		///          Можно установить флаг для указания, что метод продолжит экспортирование событий даже в случае сбоя указанного запроса для некоторых журналов.
		///          События хранятся без сообщений о событиях.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий, чтобы экспорт событий или путь к файлу журнала событий для экспорта событий из.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <param name="query">
		///           Запрос, используемый для выбора экспортируемых событий.
		///            Будут экспортированы только события, возвращенные из запроса.
		///         </param>
		/// <param name="targetFilePath">
		///           Путь к файлу журнала (с расширением .evtx), в котором будут храниться экспортированные события после выполнения данного метода.
		///         </param>
		/// <param name="tolerateQueryErrors">
		///           <see langword="true" /> Указывает, что метод продолжит экспортирование событий даже в случае сбоя указанного запроса для некоторых журналов и <see langword="false" /> Указывает, что этот метод не будет экспортировать события при сбое указанного запроса.
		///         </param>
		// Token: 0x06001BA2 RID: 7074 RVA: 0x0000235B File Offset: 0x0000055B
		public void ExportLog(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Экспортирует события и связанные сообщения в файл внешнего журнала.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий или путь к файлу журнала событий, из которого экспортируются события.
		///         </param>
		/// <param name="pathType">
		///           Указывает, определяет ли строка, которая используется в параметре пути, имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <param name="query">
		///           Запрос, используемый для выбора экспортируемых событий.
		///             Будут экспортированы только события, возвращенные запросом.
		///         </param>
		/// <param name="targetFilePath">
		///           Путь к файлу журнала (с расширением .evtx), в котором будут храниться экспортированные события после выполнения этого метода.
		///         </param>
		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000235B File Offset: 0x0000055B
		public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Экспортирует события и связанные сообщения в файл внешнего журнала.
		///          Флаг задается для указания того, что метод продолжит экспорт событий даже в случае сбоя при выполнении указанного запроса для некоторых журналов.
		///          Сообщения о событиях экспортируются на указанном языке.
		///       </summary>
		/// <param name="path">
		///           Имя журнала событий или путь к файлу журнала событий, из которого экспортируются события.
		///         </param>
		/// <param name="pathType">
		///           Указывает, определяет ли строка, которая используется в параметре пути, имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <param name="query">
		///           Запрос, используемый для выбора экспортируемых событий.
		///             Будут экспортированы только события, возвращенные запросом.
		///         </param>
		/// <param name="targetFilePath">
		///           Путь к файлу журнала (с расширением .evtx), в котором будут храниться экспортированные события после выполнения этого метода.
		///         </param>
		/// <param name="tolerateQueryErrors">
		///           <see langword="true" /> указывает на то, что метод продолжит экспорт событий даже в случае сбоя выполнения указанного запроса для некоторых журналов. <see langword="false" /> указывает на то, что этот метод не будет продолжать экспорт событий при сбое выполнения указанного запроса.
		///         </param>
		/// <param name="targetCultureInfo">
		///           Язык и региональные параметры, которые определяют язык, на котором будут экспортироваться сообщения о событиях.
		///         </param>
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000235B File Offset: 0x0000055B
		public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors, CultureInfo targetCultureInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает объект, содержащий информацию выполнения для указанного журнала событий.
		///       </summary>
		/// <param name="logName">
		///           Имя журнала событий для получения сведений о или путь к файлу журнала событий для получения сведений о.
		///         </param>
		/// <param name="pathType">
		///           Указывает ли строка, используемая в параметре path указывает имя журнала событий или путь к файлу журнала событий.
		///         </param>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLogInformation" /> содержащий сведения о указанного журнала.
		///       </returns>
		// Token: 0x06001BA5 RID: 7077 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventLogInformation GetLogInformation(string logName, PathType pathType)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Возвращает перечисляемую коллекцию всех имен журналов событий, зарегистрированных со службой журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию строк, содержащих имена журналов событий.
		///       </returns>
		// Token: 0x06001BA6 RID: 7078 RVA: 0x0005A6D7 File Offset: 0x000588D7
		[SecurityCritical]
		public IEnumerable<string> GetLogNames()
		{
			ThrowStub.ThrowNotSupportedException();
			return 0;
		}

		/// <summary>
		///         Получает перечисляемую коллекцию всех имен поставщиков событий, зарегистрированных со службой журнала событий.
		///          Поставщик событий является приложение, которое публикует события в журнал событий.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию строк, содержащих имена поставщиков событий.
		///       </returns>
		// Token: 0x06001BA7 RID: 7079 RVA: 0x0005A6D7 File Offset: 0x000588D7
		[SecurityCritical]
		public IEnumerable<string> GetProviderNames()
		{
			ThrowStub.ThrowNotSupportedException();
			return 0;
		}
	}
}
