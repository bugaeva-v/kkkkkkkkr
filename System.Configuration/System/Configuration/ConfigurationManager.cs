using System;
using System.Collections.Specialized;
using System.Configuration.Internal;
using System.IO;
using System.Reflection;
using System.Text;
using Unity;

namespace System.Configuration
{
	/// <summary>Предоставляет доступ к файлам конфигурации для клиентских приложений. Этот класс не наследуется.</summary>
	// Token: 0x02000026 RID: 38
	public static class ConfigurationManager
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00005DC8 File Offset: 0x00003FC8
		[MonoTODO("Evidence and version still needs work")]
		private static string GetAssemblyInfo(Assembly a)
		{
			object[] customAttributes = a.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			string arg;
			if (customAttributes != null && customAttributes.Length != 0)
			{
				arg = ((AssemblyProductAttribute)customAttributes[0]).Product;
			}
			else
			{
				arg = AppDomain.CurrentDomain.FriendlyName;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("evidencehere");
			string arg2 = stringBuilder.ToString();
			customAttributes = a.GetCustomAttributes(typeof(AssemblyVersionAttribute), false);
			string path;
			if (customAttributes != null && customAttributes.Length != 0)
			{
				path = ((AssemblyVersionAttribute)customAttributes[0]).Version;
			}
			else
			{
				path = "1.0.0.0";
			}
			return Path.Combine(string.Format("{0}_{1}", arg, arg2), path);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005E64 File Offset: 0x00004064
		internal static Configuration OpenExeConfigurationInternal(ConfigurationUserLevel userLevel, Assembly calling_assembly, string exePath)
		{
			ExeConfigurationFileMap exeConfigurationFileMap = new ExeConfigurationFileMap();
			if (userLevel != ConfigurationUserLevel.None)
			{
				if (userLevel != ConfigurationUserLevel.PerUserRoaming)
				{
					if (userLevel != ConfigurationUserLevel.PerUserRoamingAndLocal)
					{
						goto IL_EA;
					}
					exeConfigurationFileMap.LocalUserConfigFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ConfigurationManager.GetAssemblyInfo(calling_assembly));
					exeConfigurationFileMap.LocalUserConfigFilename = Path.Combine(exeConfigurationFileMap.LocalUserConfigFilename, "user.config");
				}
				exeConfigurationFileMap.RoamingUserConfigFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ConfigurationManager.GetAssemblyInfo(calling_assembly));
				exeConfigurationFileMap.RoamingUserConfigFilename = Path.Combine(exeConfigurationFileMap.RoamingUserConfigFilename, "user.config");
			}
			if (exePath == null || exePath.Length == 0)
			{
				exeConfigurationFileMap.ExeConfigFilename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
			}
			else
			{
				if (!Path.IsPathRooted(exePath))
				{
					exePath = Path.GetFullPath(exePath);
				}
				if (!File.Exists(exePath))
				{
					Exception inner = new ArgumentException("The specified path does not exist.", "exePath");
					throw new ConfigurationErrorsException("Error Initializing the configuration system:", inner);
				}
				exeConfigurationFileMap.ExeConfigFilename = exePath + ".config";
			}
			IL_EA:
			return ConfigurationManager.ConfigurationFactory.Create(typeof(ExeConfigurationHost), new object[]
			{
				exeConfigurationFileMap,
				userLevel
			});
		}

		/// <summary>Открывает файл конфигурации для текущего приложения в качестве объекта <see cref="T:System.Configuration.Configuration" />.</summary>
		/// <param name="userLevel">Объект <see cref="T:System.Configuration.ConfigurationUserLevel" />, для которого открывается конфигурация.</param>
		/// <returns>Объект <see cref="T:System.Configuration.Configuration" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x0600014C RID: 332 RVA: 0x00005F82 File Offset: 0x00004182
		public static Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel)
		{
			return ConfigurationManager.OpenExeConfigurationInternal(userLevel, Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly(), null);
		}

		/// <summary>Открывает указанный файл конфигурации клиента в качестве объекта <see cref="T:System.Configuration.Configuration" />.</summary>
		/// <param name="exePath">Путь к исполняемому файлу (EXE-файлу).</param>
		/// <returns>Объект <see cref="T:System.Configuration.Configuration" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x0600014D RID: 333 RVA: 0x00005F99 File Offset: 0x00004199
		public static Configuration OpenExeConfiguration(string exePath)
		{
			return ConfigurationManager.OpenExeConfigurationInternal(ConfigurationUserLevel.None, Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly(), exePath);
		}

		/// <summary>Открывает указанный файл конфигурации клиента в качестве объекта <see cref="T:System.Configuration.Configuration" />, который использует указанные сопоставление файлов и уровень пользователя.</summary>
		/// <param name="fileMap">Объект <see cref="T:System.Configuration.ExeConfigurationFileMap" />, который ссылается на файл конфигурации, используемый вместо файла конфигурации приложения по умолчанию.</param>
		/// <param name="userLevel">Объект <see cref="T:System.Configuration.ConfigurationUserLevel" />, для которого открывается конфигурация.</param>
		/// <returns>Объект конфигурации.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x0600014E RID: 334 RVA: 0x00005FB0 File Offset: 0x000041B0
		[MonoLimitation("ConfigurationUserLevel parameter is not supported.")]
		public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel)
		{
			return ConfigurationManager.ConfigurationFactory.Create(typeof(ExeConfigurationHost), new object[]
			{
				fileMap,
				userLevel
			});
		}

		/// <summary>Открывает файл конфигурации компьютера на текущем компьютере в качестве объекта <see cref="T:System.Configuration.Configuration" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.Configuration" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x0600014F RID: 335 RVA: 0x00005FDC File Offset: 0x000041DC
		public static Configuration OpenMachineConfiguration()
		{
			ConfigurationFileMap configurationFileMap = new ConfigurationFileMap();
			return ConfigurationManager.ConfigurationFactory.Create(typeof(MachineConfigurationHost), new object[]
			{
				configurationFileMap
			});
		}

		/// <summary>Открывает файл конфигурации компьютера, как объект <see cref="T:System.Configuration.Configuration" />, который использует указанное сопоставление файлов.</summary>
		/// <param name="fileMap">Объект <see cref="T:System.Configuration.ExeConfigurationFileMap" />, который ссылается на файл конфигурации, используемый вместо файла конфигурации приложения по умолчанию.</param>
		/// <returns>Объект <see cref="T:System.Configuration.Configuration" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x06000150 RID: 336 RVA: 0x0000600D File Offset: 0x0000420D
		public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap)
		{
			return ConfigurationManager.ConfigurationFactory.Create(typeof(MachineConfigurationHost), new object[]
			{
				fileMap
			});
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000602D File Offset: 0x0000422D
		internal static IInternalConfigConfigurationFactory ConfigurationFactory
		{
			get
			{
				return ConfigurationManager.configFactory;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006034 File Offset: 0x00004234
		internal static IInternalConfigSystem ConfigurationSystem
		{
			get
			{
				return ConfigurationManager.configSystem;
			}
		}

		/// <summary>Извлекает указанный раздел конфигурации для конфигурации по умолчанию текущего приложения.</summary>
		/// <param name="sectionName">Путь и имя раздела конфигурации. Имена узлов разделяются косой чертой, например system.net/mailSettings/smtp.</param>
		/// <returns>Указанный объект <see cref="T:System.Configuration.ConfigurationSection" /> или <see langword="null" />, если раздел не существует.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x06000153 RID: 339 RVA: 0x0000603C File Offset: 0x0000423C
		public static object GetSection(string sectionName)
		{
			object section = ConfigurationManager.ConfigurationSystem.GetSection(sectionName);
			if (section is ConfigurationSection)
			{
				return ((ConfigurationSection)section).GetRuntimeObject();
			}
			return section;
		}

		/// <summary>Обновляет именованный раздел, чтобы при следующем извлечении он повторно считывался с диска.</summary>
		/// <param name="sectionName">Имя раздела конфигурации, или имя пути и раздела конфигурации раздела для обновления.</param>
		// Token: 0x06000154 RID: 340 RVA: 0x0000606A File Offset: 0x0000426A
		public static void RefreshSection(string sectionName)
		{
			ConfigurationManager.ConfigurationSystem.RefreshConfig(sectionName);
		}

		/// <summary>Получает данные <see cref="T:System.Configuration.AppSettingsSection" /> для конфигурации текущего приложения по умолчанию.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.NameValueCollection" /> , содержащий содержимое <see cref="T:System.Configuration.AppSettingsSection" /> для конфигурации текущего приложения по умолчанию.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось извлечь объект <see cref="T:System.Collections.Specialized.NameValueCollection" /> с данными о параметрах приложения.</exception>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006077 File Offset: 0x00004277
		public static NameValueCollection AppSettings
		{
			get
			{
				return (NameValueCollection)ConfigurationManager.GetSection("appSettings");
			}
		}

		/// <summary>Получает данные <see cref="T:System.Configuration.ConnectionStringsSection" /> для конфигурации текущего приложения по умолчанию.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConnectionStringSettingsCollection" /> , содержащий содержимое <see cref="T:System.Configuration.ConnectionStringsSection" /> для конфигурации текущего приложения по умолчанию.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось извлечь объект <see cref="T:System.Configuration.ConnectionStringSettingsCollection" />.</exception>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00006088 File Offset: 0x00004288
		public static ConnectionStringSettingsCollection ConnectionStrings
		{
			get
			{
				return ((ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings")).ConnectionStrings;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000060A0 File Offset: 0x000042A0
		internal static IInternalConfigSystem ChangeConfigurationSystem(IInternalConfigSystem newSystem)
		{
			if (newSystem == null)
			{
				throw new ArgumentNullException("newSystem");
			}
			object obj = ConfigurationManager.lockobj;
			IInternalConfigSystem result;
			lock (obj)
			{
				IInternalConfigSystem internalConfigSystem = ConfigurationManager.configSystem;
				ConfigurationManager.configSystem = newSystem;
				result = internalConfigSystem;
			}
			return result;
		}

		/// <summary>Открывает указанный файл конфигурации клиента в качестве объекта <see cref="T:System.Configuration.Configuration" />, который использует указанное сопоставление файлов, уровень пользователя и параметр предварительной загрузки.</summary>
		/// <param name="fileMap">Объект <see cref="T:System.Configuration.ExeConfigurationFileMap" />, который ссылается на файл конфигурации, используемый вместо файла конфигурации приложения по умолчанию.</param>
		/// <param name="userLevel">Объект <see cref="T:System.Configuration.ConfigurationUserLevel" />, для которого открывается конфигурация.</param>
		/// <param name="preLoad">Значение <see langword="true" /> для предварительной загрузки всех групп разделов и разделов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект конфигурации.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удалось загрузить файл конфигурации.</exception>
		// Token: 0x06000159 RID: 345 RVA: 0x00003527 File Offset: 0x00001727
		public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel, bool preLoad)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x0400009A RID: 154
		private static InternalConfigurationFactory configFactory = new InternalConfigurationFactory();

		// Token: 0x0400009B RID: 155
		private static IInternalConfigSystem configSystem = new ClientConfigurationSystem();

		// Token: 0x0400009C RID: 156
		private static object lockobj = new object();
	}
}
