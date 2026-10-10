using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейсы, используемые внутренними структурами .NET, для инициализации свойств конфигурации приложения.</summary>
	// Token: 0x02000081 RID: 129
	[ComVisible(false)]
	public interface IInternalConfigHost
	{
		/// <summary>Создает и возвращает объект контекста для <see cref="T:System.Configuration.ConfigurationElement" /> конфигурации приложения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="locationSubPath">Строка, представляющая расположение вложенного пути элемента конфигурации.</param>
		/// <returns>Объект контекста для объекта <see cref="T:System.Configuration.ConfigurationElement" /> конфигурации приложения.</returns>
		// Token: 0x06000440 RID: 1088
		object CreateConfigurationContext(string configPath, string locationSubPath);

		/// <summary>Создает и возвращает устаревший объект контекста для конфигурации приложения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>Устаревший объект контекста для объекта конфигурации приложения.</returns>
		// Token: 0x06000441 RID: 1089
		object CreateDeprecatedConfigContext(string configPath);

		/// <summary>Расшифровывает и зашифровывает раздел конфигурации и возвращает его как строку.</summary>
		/// <param name="encryptedXml">Зашифрованная XML строка, представляющая раздел конфигурации.</param>
		/// <param name="protectionProvider">Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</param>
		/// <param name="protectedConfigSection">Объект <see cref="T:System.Configuration.ProtectedConfigurationSection" />.</param>
		/// <returns>Расшифрованный раздел конфигурации как строка.</returns>
		// Token: 0x06000442 RID: 1090
		string DecryptSection(string encryptedXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);

		/// <summary>Удаляет объект <see cref="T:System.IO.Stream" />, выполняющий операции ввода-вывода при работе с файлом конфигурации приложения.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		// Token: 0x06000443 RID: 1091
		void DeleteStream(string streamName);

		/// <summary>Зашифровывает раздел конфигурации и возвращает его как строку.</summary>
		/// <param name="clearTextXml">XML строка, представляющая раздел конфигурации для шифрования.</param>
		/// <param name="protectionProvider">Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</param>
		/// <param name="protectedConfigSection">Объект <see cref="T:System.Configuration.ProtectedConfigurationSection" />.</param>
		/// <returns>Зашифрованный раздел конфигурации, представленный как строка.</returns>
		// Token: 0x06000444 RID: 1092
		string EncryptSection(string clearTextXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);

		/// <summary>Возвращает полный путь к файлу конфигурации приложения на основе локального вложенного пути.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="locationSubPath">Расположение вложенного пути файла конфигурации.</param>
		/// <returns>Строка, представляющая полный путь к файлу конфигурации приложения.</returns>
		// Token: 0x06000445 RID: 1093
		string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath);

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий тип объекта конфигурации.</summary>
		/// <param name="typeName">Имя типа.</param>
		/// <param name="throwOnError">
		///   <see langword="true" /> создать исключение при возникновении ошибки; в противном случае — <see langword="false" /></param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип объекта конфигурации.</returns>
		// Token: 0x06000446 RID: 1094
		Type GetConfigType(string typeName, bool throwOnError);

		/// <summary>Возвращает строку, представляющую имя типа из объекта <see cref="T:System.Type" />, представляющего тип конфигурации.</summary>
		/// <param name="t">Объект <see cref="T:System.Type" />.</param>
		/// <returns>Строка, представляющую имя типа из объекта <see cref="T:System.Type" />, представляющего тип конфигурации.</returns>
		// Token: 0x06000447 RID: 1095
		string GetConfigTypeName(Type t);

		/// <summary>Связывает конфигурацию с объектом <see cref="T:System.Security.PermissionSet" />.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <param name="permissionSet">Объект <see cref="T:System.Security.PermissionSet" /> для связи с конфигурацией.</param>
		/// <param name="isHostReady">
		///   <see langword="true" /> указывает ,что узел конфигурации завершил построение связанных разрешений; в противном случае — <see langword="false" />.</param>
		// Token: 0x06000448 RID: 1096
		void GetRestrictedPermissions(IInternalConfigRecord configRecord, out PermissionSet permissionSet, out bool isHostReady);

		/// <summary>Возвращает строку, представляющую имя файла конфигурации, связанного с объектом <see cref="T:System.IO.Stream" />, выполняющим операции ввода-вывода при работе с файлом конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>Строка, представляющая имя файла конфигурации, связанного с <see cref="T:System.IO.Stream" /> операциями ввода-вывода при работе с файлом конфигурации.</returns>
		// Token: 0x06000449 RID: 1097
		string GetStreamName(string configPath);

		/// <summary>Возвращает строку, представляющую имя файла конфигурации, связанного с объектом <see cref="T:System.IO.Stream" />, выполняющим операции ввода-вывода при работе с удаленным файлом конфигурации.</summary>
		/// <param name="streamName">Строка, представляющая имя файла конфигурации, связанного с объектом <see cref="T:System.IO.Stream" />, выполняющим операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="configSource">Строка, представляющая путь к удаленному файлу конфигурации.</param>
		/// <returns>Строка, представляющая имя файла конфигурации, связанного с объектом <see cref="T:System.IO.Stream" />, выполняющим операции ввода-вывода при работе с файлом конфигурации.</returns>
		// Token: 0x0600044A RID: 1098
		string GetStreamNameForConfigSource(string streamName, string configSource);

		/// <summary>Возвращает версию объекта <see cref="T:System.IO.Stream" />, который связан с файлом конфигурации.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>Версия объекта <see cref="T:System.IO.Stream" />, который связан с файлом конфигурации.</returns>
		// Token: 0x0600044B RID: 1099
		object GetStreamVersion(string streamName);

		/// <summary>Указывает узлу олицетворить и возвратить объект <see cref="T:System.IDisposable" />, требуемый внутренней структурой .NET.</summary>
		/// <returns>Значение <see cref="T:System.IDisposable" />.</returns>
		// Token: 0x0600044C RID: 1100
		IDisposable Impersonate();

		/// <summary>Инициализирует узел конфигурации.</summary>
		/// <param name="configRoot">Корневой объект конфигурации.</param>
		/// <param name="hostInitParams">Параметр объекта содержит значения, используемые для инициализации узла конфигурации.</param>
		// Token: 0x0600044D RID: 1101
		void Init(IInternalConfigRoot configRoot, params object[] hostInitParams);

		/// <summary>Инициализирует объект конфигурации.</summary>
		/// <param name="locationSubPath">Расположение вложенного пути файла конфигурации.</param>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="locationConfigPath">Строка, представляющая расположение пути конфигурации.</param>
		/// <param name="configRoot">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRoot" />.</param>
		/// <param name="hostInitConfigurationParams">Параметр объекта содержит значения, используемые для инициализации узла конфигурации.</param>
		// Token: 0x0600044E RID: 1102
		void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams);

		/// <summary>Возвращает значение, определяющее, будет ли файл конфигурации расположен на более высоком уровне в иерархии конфигурации чем конфигурация приложения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>
		///   <see langword="true" /> файл конфигурации расположен на более высоком уровне в иерархии конфигурации чем конфигурация приложения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600044F RID: 1103
		bool IsAboveApplication(string configPath);

		/// <summary>Возвращает значение, определяющее, требуется ли запись дочернего элемента для пути конфигурации дочернего элемента.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>
		///   <see langword="true" /> если требуется запись дочернего элемента для пути конфигурации дочернего элемента; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000450 RID: 1104
		bool IsConfigRecordRequired(string configPath);

		/// <summary>Определяет, допустимы ли различные определения <see cref="T:System.Type" /> для объекта конфигурации приложения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="allowDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowDefinition" />.</param>
		/// <param name="allowExeDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowExeDefinition" />.</param>
		/// <returns>
		///   <see langword="true" /> если допустимы ли различные определения <see cref="T:System.Type" /> для объекта конфигурации приложения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000451 RID: 1105
		bool IsDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition);

		/// <summary>Возвращает значение, определяющее, является ли путь файла, используемый объектом <see cref="T:System.IO.Stream" /> для чтения файла конфигурации, действительным.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если путь, используемый объектом <see cref="T:System.IO.Stream" /> для чтения файла конфигурации, является действительным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000452 RID: 1106
		bool IsFile(string streamName);

		/// <summary>Возвращает значение, определяющее, будет ли раздел конфигурации требовать уровень полностью достоверного управления доступом для кода и не разрешать атрибуту <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> отключать неявные требования к связыванию.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <returns>
		///   <see langword="true" /> если раздел конфигурации требует уровень полностью достоверного управления доступом для кода и не разрешает атрибуту <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> отключать неявные требования к связыванию; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000453 RID: 1107
		bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord);

		/// <summary>Возвращает значение, определяющее, будет ли инициализация объекта конфигурации считаться отсроченной.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <returns>
		///   <see langword="true" /> если инициализация объекта конфигурации считаться отсроченной; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000454 RID: 1108
		bool IsInitDelayed(IInternalConfigRecord configRecord);

		/// <summary>Возвращает значение, определяющее, будет ли объект конфигурации поддерживать теги расположения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>
		///   <see langword="true" /> если объект конфигурации поддерживает теги расположения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000455 RID: 1109
		bool IsLocationApplicable(string configPath);

		/// <summary>Возвращает значение, определяющее, является ли конфигурация удаленной.</summary>
		/// <returns>
		///   <see langword="true" /> если конфигурация удаленная; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000456 RID: 1110
		bool IsRemote { get; }

		/// <summary>Возвращает значение, определяющее, является ли путь конфигурации к узлу конфигурации, содержание которого должно обрабатываться как корневое.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>
		///   <see langword="true" /> если путь конфигурации к узлу конфигурации, содержание которого должно обрабатываться как корневое, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000457 RID: 1111
		bool IsSecondaryRoot(string configPath);

		/// <summary>Возвращает значение, определяющее, будет ли путь конфигурации доверенным.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <returns>
		///   <see langword="true" /> если путь конфигурации доверенный; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000458 RID: 1112
		bool IsTrustedConfigPath(string configPath);

		/// <summary>Открывает <see cref="T:System.IO.Stream" /> для чтения файла конфигурации.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		// Token: 0x06000459 RID: 1113
		Stream OpenStreamForRead(string streamName);

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для чтения файла конфигурации.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект, заданный параметром <paramref name="streamName" />.</returns>
		// Token: 0x0600045A RID: 1114
		Stream OpenStreamForRead(string streamName, bool assertPermissions);

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для записи в файл конфигурации или записи во временный файл, используемый для построения файла конфигурации. Позволяет задавать объект <see cref="T:System.IO.Stream" /> в качестве шаблона для копирования атрибутов файла.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="templateStreamName">Имя объекта <see cref="T:System.IO.Stream" />, из которого атрибуты файла должны быть скопированы как шаблон.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		// Token: 0x0600045B RID: 1115
		Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext);

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для записи в файл конфигурации. Позволяет задавать объект <see cref="T:System.IO.Stream" /> в качестве шаблона для копирования атрибутов файла.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="templateStreamName">Имя <see cref="T:System.IO.Stream" />, из которого атрибуты файла должны быть скопированы как шаблон.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект, заданный параметром <paramref name="streamName" />.</returns>
		// Token: 0x0600045C RID: 1116
		Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions);

		/// <summary>Возвращает значение, определяющее, может ли весь файл конфигурации быть прочитан определяемым объектом <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если весь файл конфигурации может быть прочитан объектом <see cref="T:System.IO.Stream" /> определенным <paramref name="streamName" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600045D RID: 1117
		bool PrefetchAll(string configPath, string streamName);

		/// <summary>Указывает объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> для чтения определенного раздела связанного с ним файла конфигурации.</summary>
		/// <param name="sectionGroupName">Строка, представляющая идентифицирующее имя группы раздела файла конфигурации.</param>
		/// <param name="sectionName">Строка, представляющая идентифицирующее имя раздела файла конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если раздел файла конфигурации определенный <paramref name="sectionGroupName" /> и <paramref name="sectionName" /> могут быть прочитаны объектом <see cref="T:System.IO.Stream" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600045E RID: 1118
		bool PrefetchSection(string sectionGroupName, string sectionName);

		/// <summary>Указывает, что запись новой конфигурации требует полную инициализацию.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		// Token: 0x0600045F RID: 1119
		void RequireCompleteInit(IInternalConfigRecord configRecord);

		/// <summary>Указывает объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> контролировать связанный объект <see cref="T:System.IO.Stream" /> для изменений в файле конфигурации.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="callback">Объект <see cref="T:System.Configuration.Internal.StreamChangeCallback" /> для получения возвращенных данных, которые представляют изменения в файле конфигурации.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, содержащий измененные параметры конфигурации.</returns>
		// Token: 0x06000460 RID: 1120
		object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);

		/// <summary>Предписывает объекту <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> остановить отслеживание изменений в файле конфигурации для связанного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="callback">Объект <see cref="T:System.Configuration.Internal.StreamChangeCallback" />.</param>
		// Token: 0x06000461 RID: 1121
		void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);

		/// <summary>Проверяет, что определения конфигурации разрешены для записи конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации приложения.</param>
		/// <param name="allowDefinition">Объект <see cref="P:System.Configuration.SectionInformation.AllowDefinition" />.</param>
		/// <param name="allowExeDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowExeDefinition" /></param>
		/// <param name="errorInfo">Объект <see cref="T:System.Configuration.Internal.IConfigErrorInfo" />.</param>
		// Token: 0x06000462 RID: 1122
		void VerifyDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo);

		/// <summary>Указывает, что все записи в файл конфигурации завершены.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="success">
		///   <see langword="true" /> если запись в файл конфигурации успешно завершена; в противном случае — <see langword="false" />.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		// Token: 0x06000463 RID: 1123
		void WriteCompleted(string streamName, bool success, object writeContext);

		/// <summary>Указывает, что все записи в файл конфигурации завершены и определяет, должны ли быть утверждены разрешения.</summary>
		/// <param name="streamName">Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего задачи ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="success">
		///   <see langword="true" /> указывает, что запись выполнена успешно; в противном случае — <see langword="false" />.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		// Token: 0x06000464 RID: 1124
		void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions);

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать уведомление изменения.</summary>
		/// <returns>
		///   <see langword="true" /> если конфигурация поддерживает уведомление изменения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000465 RID: 1125
		bool SupportsChangeNotifications { get; }

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать теги расположения.</summary>
		/// <returns>
		///   <see langword="true" /> если конфигурация поддерживает теги расположения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000466 RID: 1126
		bool SupportsLocation { get; }

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать теги пути.</summary>
		/// <returns>
		///   <see langword="true" /> если конфигурация поддерживает теги пути; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000467 RID: 1127
		bool SupportsPath { get; }

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать обновление конфигурации.</summary>
		/// <returns>
		///   <see langword="true" />, если конфигурация узла поддерживает обновление конфигурации; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000468 RID: 1128
		bool SupportsRefresh { get; }
	}
}
