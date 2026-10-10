using System;
using System.IO;
using System.Security;
using System.Xml;
using Unity;

namespace System.Configuration.Internal
{
	/// <summary>Делегирует всех членов интерфейса <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> в другой экземпляр узла.</summary>
	// Token: 0x0200007A RID: 122
	public class DelegatingConfigHost : IInternalConfigHost, IInternalConfigurationBuilderHost
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.Internal.DelegatingConfigHost" />.</summary>
		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		protected DelegatingConfigHost()
		{
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" />.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000B182 File Offset: 0x00009382
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000B18A File Offset: 0x0000938A
		protected IInternalConfigHost Host
		{
			get
			{
				return this.host;
			}
			set
			{
				this.host = value;
			}
		}

		/// <summary>Создает новый контекст конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="locationSubPath">Строка, представляющая вложенный путь расположения.</param>
		/// <returns>
		///   <see cref="T:System.Object" /> представляющее новый контекст конфигурации.</returns>
		// Token: 0x060003FB RID: 1019 RVA: 0x0000B193 File Offset: 0x00009393
		public virtual object CreateConfigurationContext(string configPath, string locationSubPath)
		{
			return this.host.CreateConfigurationContext(configPath, locationSubPath);
		}

		/// <summary>Создает устаревший контекст конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see cref="T:System.Object" /> представляющее устаревший контекст конфигурации.</returns>
		// Token: 0x060003FC RID: 1020 RVA: 0x0000B1A2 File Offset: 0x000093A2
		public virtual object CreateDeprecatedConfigContext(string configPath)
		{
			return this.host.CreateDeprecatedConfigContext(configPath);
		}

		/// <summary>Расшифровывает и зашифровывает раздел конфигурации.</summary>
		/// <param name="encryptedXml">Зашифрованный раздел файла конфигурации.</param>
		/// <param name="protectionProvider">Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</param>
		/// <param name="protectedConfigSection">Объект <see cref="T:System.Configuration.ProtectedConfigurationSection" />.</param>
		/// <returns>Строка, представляющая расшифрованный раздел конфигурации.</returns>
		// Token: 0x060003FD RID: 1021 RVA: 0x0000B1B0 File Offset: 0x000093B0
		public virtual string DecryptSection(string encryptedXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection)
		{
			return this.host.DecryptSection(encryptedXml, protectionProvider, protectedConfigSection);
		}

		/// <summary>Удаляет объект <see cref="T:System.IO.Stream" />, выполняющий операции ввода-вывода при работе с файлом конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		// Token: 0x060003FE RID: 1022 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public virtual void DeleteStream(string streamName)
		{
			this.host.DeleteStream(streamName);
		}

		/// <summary>Зашифровывает раздел объекта конфигурации.</summary>
		/// <param name="clearTextXml">Незашифрованный раздел конфигурации.</param>
		/// <param name="protectionProvider">Объект <see cref="T:System.Configuration.ProtectedConfigurationProvider" />.</param>
		/// <param name="protectedConfigSection">Объект <see cref="T:System.Configuration.ProtectedConfigurationSection" />.</param>
		/// <returns>Строка, представляющая зашифрованный раздел объекта конфигурации.</returns>
		// Token: 0x060003FF RID: 1023 RVA: 0x0000B1CE File Offset: 0x000093CE
		public virtual string EncryptSection(string clearTextXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection)
		{
			return this.host.EncryptSection(clearTextXml, protectionProvider, protectedConfigSection);
		}

		/// <summary>Возвращает путь конфигурации на основании вложенного пути расположения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="locationSubPath">Строка, представляющая вложенный путь расположения.</param>
		/// <returns>Строка, представляющая путь конфигурации.</returns>
		// Token: 0x06000400 RID: 1024 RVA: 0x0000B1DE File Offset: 0x000093DE
		public virtual string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath)
		{
			return this.host.GetConfigPathFromLocationSubPath(configPath, locationSubPath);
		}

		/// <summary>Возвращает <see cref="T:System.Type" />, представляющее тип конфигурации.</summary>
		/// <param name="typeName">Строка, представляющая тип конфигурации.</param>
		/// <param name="throwOnError">
		///   <see langword="true" /> если при возникновении ошибки должно создаваться исключение; <see langword="false" /> если при возникновении ошибки исключение не должно создаваться.</param>
		/// <returns>
		///   <see cref="T:System.Type" />, представляющее тип конфигурации.</returns>
		// Token: 0x06000401 RID: 1025 RVA: 0x0000B1ED File Offset: 0x000093ED
		public virtual Type GetConfigType(string typeName, bool throwOnError)
		{
			return this.host.GetConfigType(typeName, throwOnError);
		}

		/// <summary>Возвращает строку, представляющую имя типа объекта конфигурации.</summary>
		/// <param name="t">Объект <see cref="T:System.Type" />.</param>
		/// <returns>Строка, представляющая имя типа объекта конфигурации.</returns>
		// Token: 0x06000402 RID: 1026 RVA: 0x0000B1FC File Offset: 0x000093FC
		public virtual string GetConfigTypeName(Type t)
		{
			return this.host.GetConfigTypeName(t);
		}

		/// <summary>Устанавливает набор определенных разрешений в пределах объекта узла (если возможно).</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <param name="permissionSet">Объект <see cref="T:System.Security.PermissionSet" />.</param>
		/// <param name="isHostReady">
		///   <see langword="true" />, если узел закончил инициализацию; в противном случае — <see langword="false" />.</param>
		// Token: 0x06000403 RID: 1027 RVA: 0x0000B20A File Offset: 0x0000940A
		public virtual void GetRestrictedPermissions(IInternalConfigRecord configRecord, out PermissionSet permissionSet, out bool isHostReady)
		{
			this.host.GetRestrictedPermissions(configRecord, out permissionSet, out isHostReady);
		}

		/// <summary>Возвращает имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</returns>
		// Token: 0x06000404 RID: 1028 RVA: 0x0000B21A File Offset: 0x0000941A
		public virtual string GetStreamName(string configPath)
		{
			return this.host.GetStreamName(configPath);
		}

		/// <summary>Возвращает имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с источником конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="configSource">Строка, представляющая источник конфигурации.</param>
		/// <returns>Строка, представляющая имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с источником конфигурации.</returns>
		// Token: 0x06000405 RID: 1029 RVA: 0x0000B228 File Offset: 0x00009428
		public virtual string GetStreamNameForConfigSource(string streamName, string configSource)
		{
			return this.host.GetStreamNameForConfigSource(streamName, configSource);
		}

		/// <summary>Возвращает объект <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion" />, представляющий версию объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>Объект <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion" />, представляющий версию объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</returns>
		// Token: 0x06000406 RID: 1030 RVA: 0x0000B237 File Offset: 0x00009437
		public virtual object GetStreamVersion(string streamName)
		{
			return this.host.GetStreamVersion(streamName);
		}

		/// <summary>Указывает узлу олицетворить и возвратить объект <see cref="T:System.IDisposable" />, требуемый платформой .NET Framework.</summary>
		/// <returns>Значение <see cref="T:System.IDisposable" />.</returns>
		// Token: 0x06000407 RID: 1031 RVA: 0x0000B245 File Offset: 0x00009445
		public virtual IDisposable Impersonate()
		{
			return this.host.Impersonate();
		}

		/// <summary>Инициализирует узел конфигурации.</summary>
		/// <param name="configRoot">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRoot" />.</param>
		/// <param name="hostInitParams">Параметр объекта содержит значения, используемые для инициализации узла конфигурации.</param>
		// Token: 0x06000408 RID: 1032 RVA: 0x0000B252 File Offset: 0x00009452
		public virtual void Init(IInternalConfigRoot configRoot, params object[] hostInitParams)
		{
			this.host.Init(configRoot, hostInitParams);
		}

		/// <summary>Инициализирует узел для конфигурации.</summary>
		/// <param name="locationSubPath">Строка, представляющая вложенный путь расположения (переданный по ссылке).</param>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="locationConfigPath">Расположение пути конфигурации.</param>
		/// <param name="configRoot">Корневой элемент конфигурации.</param>
		/// <param name="hostInitConfigurationParams">Объект параметра, представляющий параметры, используемые для инициализации узла.</param>
		// Token: 0x06000409 RID: 1033 RVA: 0x0000B261 File Offset: 0x00009461
		public virtual void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams)
		{
			this.host.InitForConfiguration(ref locationSubPath, out configPath, out locationConfigPath, configRoot, hostInitConfigurationParams);
		}

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация выше конфигурации приложения в иерархии конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если конфигурация выше конфигурации приложения в иерархии конфигурации; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040A RID: 1034 RVA: 0x0000B275 File Offset: 0x00009475
		public virtual bool IsAboveApplication(string configPath)
		{
			return this.host.IsAboveApplication(configPath);
		}

		/// <summary>Возвращает значение, определяющее, требуется ли запись конфигурации для инициализации конфигурации узла.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если запись конфигурации требуется для инициализации конфигурации узла; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040B RID: 1035 RVA: 0x0000B283 File Offset: 0x00009483
		public virtual bool IsConfigRecordRequired(string configPath)
		{
			return this.host.IsConfigRecordRequired(configPath);
		}

		/// <summary>Ограничивает или разрешает определения в конфигурации узла.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="allowDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowDefinition" />.</param>
		/// <param name="allowExeDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowExeDefinition" />.</param>
		/// <returns>
		///   <see langword="true" /> если разрешение или ограничение определений в конфигурации узла выполнены успешно; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040C RID: 1036 RVA: 0x0000B291 File Offset: 0x00009491
		public virtual bool IsDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition)
		{
			return this.host.IsDefinitionAllowed(configPath, allowDefinition, allowExeDefinition);
		}

		/// <summary>Возвращает значение, определяющее, будет ли инициализация объекта конфигурации считаться отсроченной.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <returns>
		///   <see langword="true" /> если инициализация объекта конфигурации считаться отсроченной; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040D RID: 1037 RVA: 0x0000B2A1 File Offset: 0x000094A1
		public virtual bool IsInitDelayed(IInternalConfigRecord configRecord)
		{
			return this.host.IsInitDelayed(configRecord);
		}

		/// <summary>Возвращает значение, определяющее, является ли путь файла, используемый объектом <see cref="T:System.IO.Stream" /> для чтения файла конфигурации, действительным.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если путь, используемый объектом <see cref="T:System.IO.Stream" /> для чтения файла конфигурации, является действительным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040E RID: 1038 RVA: 0x0000B2AF File Offset: 0x000094AF
		public virtual bool IsFile(string streamName)
		{
			return this.host.IsFile(streamName);
		}

		/// <summary>Возвращает значение, определяющее, будет ли раздел конфигурации требовать уровень полностью достоверного управления доступом для кода и не разрешать атрибуту <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> отключать неявные требования к связыванию.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		/// <returns>
		///   <see langword="true" /> если раздел конфигурации требует уровень полностью достоверного управления доступом для кода и не разрешает атрибуту <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> отключать неявные требования к связыванию; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600040F RID: 1039 RVA: 0x0000B2BD File Offset: 0x000094BD
		public virtual bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord)
		{
			return this.host.IsFullTrustSectionWithoutAptcaAllowed(configRecord);
		}

		/// <summary>Возвращает значение, определяющее, будет ли объект конфигурации поддерживать теги расположения.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если объект конфигурации поддерживает теги расположения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000410 RID: 1040 RVA: 0x0000B2CB File Offset: 0x000094CB
		public virtual bool IsLocationApplicable(string configPath)
		{
			return this.host.IsLocationApplicable(configPath);
		}

		/// <summary>Возвращает значение, определяющее, является ли конфигурация удаленной.</summary>
		/// <returns>
		///   <see langword="true" /> если конфигурация удаленная; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000B2D9 File Offset: 0x000094D9
		public virtual bool IsRemote
		{
			get
			{
				return this.host.IsRemote;
			}
		}

		/// <summary>Возвращает значение, определяющее, является ли путь конфигурации к узлу конфигурации, содержание которого должно обрабатываться как корневое.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если путь конфигурации к узлу конфигурации, содержание которого должно обрабатываться как корневое, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000412 RID: 1042 RVA: 0x0000B2E6 File Offset: 0x000094E6
		public virtual bool IsSecondaryRoot(string configPath)
		{
			return this.host.IsSecondaryRoot(configPath);
		}

		/// <summary>Возвращает значение, определяющее, будет ли путь конфигурации доверенным.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если путь конфигурации доверенный; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000413 RID: 1043 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public virtual bool IsTrustedConfigPath(string configPath)
		{
			return this.host.IsTrustedConfigPath(configPath);
		}

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для чтения файла конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>Объект, заданный параметром <paramref name="streamName" />.</returns>
		// Token: 0x06000414 RID: 1044 RVA: 0x0000B302 File Offset: 0x00009502
		public virtual Stream OpenStreamForRead(string streamName)
		{
			return this.host.OpenStreamForRead(streamName);
		}

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для чтения файла конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект, заданный параметром <paramref name="streamName" />.</returns>
		// Token: 0x06000415 RID: 1045 RVA: 0x0000B310 File Offset: 0x00009510
		public virtual Stream OpenStreamForRead(string streamName, bool assertPermissions)
		{
			return this.host.OpenStreamForRead(streamName, assertPermissions);
		}

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для записи в файл конфигурации или записи во временный файл, используемый для построения файла конфигурации. Позволяет задавать объект <see cref="T:System.IO.Stream" /> в качестве шаблона для копирования атрибутов файла.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="templateStreamName">Имя объекта <see cref="T:System.IO.Stream" />, из которого атрибуты файла должны быть скопированы как шаблон.</param>
		/// <param name="writeContext">Запись контекста объекта (переданный по ссылке) <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		// Token: 0x06000416 RID: 1046 RVA: 0x0000B31F File Offset: 0x0000951F
		public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext)
		{
			return this.host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext);
		}

		/// <summary>Открывает объект <see cref="T:System.IO.Stream" /> для записи в файл конфигурации. Позволяет задавать объект <see cref="T:System.IO.Stream" /> в качестве шаблона для копирования атрибутов файла.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="templateStreamName">Имя объекта <see cref="T:System.IO.Stream" />, из которого атрибуты файла должны быть скопированы как шаблон.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации (переданный по ссылке).</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		/// <returns>Объект, указанный параметром <paramref name="streamName" />.</returns>
		// Token: 0x06000417 RID: 1047 RVA: 0x0000B32F File Offset: 0x0000952F
		public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions)
		{
			return this.host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext, assertPermissions);
		}

		/// <summary>Возвращает значение, определяющее, может ли весь файл конфигурации быть прочитан определяемым объектом <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если весь файл конфигурации может быть прочитан объектом <see cref="T:System.IO.Stream" /> определенным <paramref name="streamName" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000418 RID: 1048 RVA: 0x0000B341 File Offset: 0x00009541
		public virtual bool PrefetchAll(string configPath, string streamName)
		{
			return this.host.PrefetchAll(configPath, streamName);
		}

		/// <summary>Указывает объект <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> для чтения определенного раздела связанного с ним файла конфигурации.</summary>
		/// <param name="sectionGroupName">Строка, представляющая имя группы раздела в файле конфигурации.</param>
		/// <param name="sectionName">Строка, представляющая имя раздела в файле конфигурации.</param>
		/// <returns>
		///   <see langword="true" /> если раздел файла конфигурации определенный <paramref name="sectionGroupName" /> и параметры <paramref name="sectionName" /> могут быть прочитаны объектом <see cref="T:System.IO.Stream" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000419 RID: 1049 RVA: 0x0000B350 File Offset: 0x00009550
		public virtual bool PrefetchSection(string sectionGroupName, string sectionName)
		{
			return this.host.PrefetchSection(sectionGroupName, sectionName);
		}

		/// <summary>Указывает, что запись новой конфигурации требует полную инициализацию.</summary>
		/// <param name="configRecord">Объект <see cref="T:System.Configuration.Internal.IInternalConfigRecord" />.</param>
		// Token: 0x0600041A RID: 1050 RVA: 0x0000B35F File Offset: 0x0000955F
		public virtual void RequireCompleteInit(IInternalConfigRecord configRecord)
		{
			this.host.RequireCompleteInit(configRecord);
		}

		/// <summary>Указывает узлу отслеживать связанный объект <see cref="T:System.IO.Stream" /> для изменений в файле конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="callback">Объект <see cref="T:System.Configuration.Internal.StreamChangeCallback" /> для получения возвращенных данных, которые представляют изменения в файле конфигурации.</param>
		/// <returns>Экземпляр <see cref="T:System.Object" />, содержащий измененные параметры конфигурации.</returns>
		// Token: 0x0600041B RID: 1051 RVA: 0x0000B36D File Offset: 0x0000956D
		public virtual object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback)
		{
			return this.host.StartMonitoringStreamForChanges(streamName, callback);
		}

		/// <summary>Указывает объекту узла остановить отслеживание связанного объекта <see cref="T:System.IO.Stream" /> для изменений в файле конфигурации.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="callback">Объект <see cref="T:System.Configuration.Internal.StreamChangeCallback" />.</param>
		// Token: 0x0600041C RID: 1052 RVA: 0x0000B37C File Offset: 0x0000957C
		public virtual void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback)
		{
			this.host.StopMonitoringStreamForChanges(streamName, callback);
		}

		/// <summary>Проверяет, что определения конфигурации разрешены для записи конфигурации.</summary>
		/// <param name="configPath">Строка, представляющая путь к файлу конфигурации.</param>
		/// <param name="allowDefinition">Объект <see cref="P:System.Configuration.SectionInformation.AllowDefinition" />.</param>
		/// <param name="allowExeDefinition">Объект <see cref="T:System.Configuration.ConfigurationAllowExeDefinition" /></param>
		/// <param name="errorInfo">Объект <see cref="T:System.Configuration.Internal.IConfigErrorInfo" />.</param>
		// Token: 0x0600041D RID: 1053 RVA: 0x0000B38B File Offset: 0x0000958B
		public virtual void VerifyDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo)
		{
			this.host.VerifyDefinitionAllowed(configPath, allowDefinition, allowExeDefinition, errorInfo);
		}

		/// <summary>Указывает, что все записи в файл конфигурации завершены.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="success">
		///   <see langword="true" /> если запись в файл конфигурации успешно завершена; в противном случае — <see langword="false" />.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		// Token: 0x0600041E RID: 1054 RVA: 0x0000B39D File Offset: 0x0000959D
		public virtual void WriteCompleted(string streamName, bool success, object writeContext)
		{
			this.host.WriteCompleted(streamName, success, writeContext);
		}

		/// <summary>Указывает, что все записи в файл конфигурации завершены и определяет, должны ли быть утверждены разрешения.</summary>
		/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="success">
		///   <see langword="true" /> указывает, что запись успешно завершена; в противном случае — <see langword="false" />.</param>
		/// <param name="writeContext">Запись контекста объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
		/// <param name="assertPermissions">
		///   <see langword="true" /> чтобы утвердить разрешения; в противном случае — <see langword="false" />.</param>
		// Token: 0x0600041F RID: 1055 RVA: 0x0000B3AD File Offset: 0x000095AD
		public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions)
		{
			this.host.WriteCompleted(streamName, success, writeContext, assertPermissions);
		}

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать уведомления изменения.</summary>
		/// <returns>
		///   <see langword="true" /> если узел поддерживает уведомления изменения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000B3BF File Offset: 0x000095BF
		public virtual bool SupportsChangeNotifications
		{
			get
			{
				return this.host.SupportsChangeNotifications;
			}
		}

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать теги расположения.</summary>
		/// <returns>
		///   <see langword="true" /> если узел поддерживает теги расположения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000B3CC File Offset: 0x000095CC
		public virtual bool SupportsLocation
		{
			get
			{
				return this.host.SupportsLocation;
			}
		}

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла иметь поддержку пути.</summary>
		/// <returns>
		///   <see langword="true" />, если конфигурация узла имеет поддержку пути; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000B3D9 File Offset: 0x000095D9
		public virtual bool SupportsPath
		{
			get
			{
				return this.host.SupportsPath;
			}
		}

		/// <summary>Возвращает значение, определяющее, будет ли конфигурация узла поддерживать обновление.</summary>
		/// <returns>
		///   <see langword="true" />, если конфигурация узла поддерживает обновление; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000B3E6 File Offset: 0x000095E6
		public virtual bool SupportsRefresh
		{
			get
			{
				return this.host.SupportsRefresh;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Configuration.Internal.IInternalConfigurationBuilderHost" />, если делегированный узел предоставляет функциональные возможности, необходимые для этого интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.Internal.IInternalConfigurationBuilderHost" />.</returns>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00003527 File Offset: 0x00001727
		protected IInternalConfigurationBuilderHost ConfigBuilderHost
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Обрабатывает объект <see cref="T:System.Configuration.ConfigurationSection" />, используя предоставленную коллекцию <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
		/// <param name="configSection">Обрабатываемый тип <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <param name="builder">
		///   <see cref="T:System.Configuration.ConfigurationBuilder" /> для использования в обработке <paramref name="configSection" />.</param>
		/// <returns>Обработанный <see cref="T:System.Configuration.ConfigurationSection" />.</returns>
		// Token: 0x06000425 RID: 1061 RVA: 0x00003527 File Offset: 0x00001727
		public virtual ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection, ConfigurationBuilder builder)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Обрабатывает разметку раздела конфигурации, используя предоставленную коллекцию <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
		/// <param name="rawXml">Обрабатываемый тип <see cref="T:System.Xml.XmlNode" />.</param>
		/// <param name="builder">
		///   <see cref="T:System.Configuration.ConfigurationBuilder" /> для использования в обработке <paramref name="rawXml" />.</param>
		/// <returns>Обработанный <see cref="T:System.Xml.XmlNode" />.</returns>
		// Token: 0x06000426 RID: 1062 RVA: 0x00003527 File Offset: 0x00001727
		public virtual XmlNode ProcessRawXml(XmlNode rawXml, ConfigurationBuilder builder)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x04000166 RID: 358
		private IInternalConfigHost host;
	}
}
