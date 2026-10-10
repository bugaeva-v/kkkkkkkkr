using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	/// <summary>Предоставляет различные статические методы для конфигурации инфраструктуры удаленного взаимодействия.</summary>
	// Token: 0x02000565 RID: 1381
	[ComVisible(true)]
	public static class RemotingConfiguration
	{
		/// <summary>Возвращает идентификатор выполняемого в настоящий момент приложения.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит идентификатор выполняемого в настоящий момент приложения.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x000C2AFC File Offset: 0x000C0CFC
		public static string ApplicationId
		{
			get
			{
				RemotingConfiguration.applicationID = RemotingConfiguration.ApplicationName;
				return RemotingConfiguration.applicationID;
			}
		}

		/// <summary>Возвращает или устанавливает имя приложения удаленного доступа.</summary>
		/// <returns>Имя приложения удаленного доступа.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия. Это исключение создается только при настройке значения свойства.</exception>
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000C2B0D File Offset: 0x000C0D0D
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x000C2B14 File Offset: 0x000C0D14
		public static string ApplicationName
		{
			get
			{
				return RemotingConfiguration.applicationName;
			}
			set
			{
				RemotingConfiguration.applicationName = value;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, как выполняется обработка пользовательских ошибок.</summary>
		/// <returns>Член перечисления <see cref="T:System.Runtime.Remoting.CustomErrorsModes" />, указывающий, как осуществляется обработка пользовательских ошибок.</returns>
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x000C2B1C File Offset: 0x000C0D1C
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x000C2B23 File Offset: 0x000C0D23
		public static CustomErrorsModes CustomErrorsMode
		{
			get
			{
				return RemotingConfiguration._errorMode;
			}
			set
			{
				RemotingConfiguration._errorMode = value;
			}
		}

		/// <summary>Получает идентификатор выполняемого в настоящий момент процесса.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит идентификатор выполняемого в настоящий момент процесса.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x000C2B2B File Offset: 0x000C0D2B
		public static string ProcessId
		{
			get
			{
				if (RemotingConfiguration.processGuid == null)
				{
					RemotingConfiguration.processGuid = AppDomain.GetProcessGuid();
				}
				return RemotingConfiguration.processGuid;
			}
		}

		/// <summary>Читает файл конфигурации и настраивает инфраструктуру удаленного взаимодействия.</summary>
		/// <param name="filename">Имя файла конфигурации удаленного доступа. Может иметь значение <see langword="null" />.</param>
		/// <param name="ensureSecurity">Если значение равно <see langword="true" />, обеспечение безопасности обязательно. Если значение равно <see langword="false" />, обеспечение безопасности необязательно, но возможно.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003628 RID: 13864 RVA: 0x000C2B44 File Offset: 0x000C0D44
		[MonoTODO("ensureSecurity support has not been implemented")]
		public static void Configure(string filename, bool ensureSecurity)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (!RemotingConfiguration.defaultConfigRead)
				{
					string bundledMachineConfig = Environment.GetBundledMachineConfig();
					if (bundledMachineConfig != null)
					{
						RemotingConfiguration.ReadConfigString(bundledMachineConfig);
					}
					if (File.Exists(Environment.GetMachineConfigPath()))
					{
						RemotingConfiguration.ReadConfigFile(Environment.GetMachineConfigPath());
					}
					RemotingConfiguration.defaultConfigRead = true;
				}
				if (filename != null)
				{
					RemotingConfiguration.ReadConfigFile(filename);
				}
			}
		}

		/// <summary>Читает файл конфигурации и настраивает инфраструктуру удаленного взаимодействия. <see cref="M:System.Runtime.Remoting.RemotingConfiguration.Configure(System.String)" /> устарел. Взамен рекомендуется использовать <see cref="M:System.Runtime.Remoting.RemotingConfiguration.Configure(System.String,System.Boolean)" />.</summary>
		/// <param name="filename">Имя файла конфигурации удаленного доступа. Может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003629 RID: 13865 RVA: 0x000C2BB8 File Offset: 0x000C0DB8
		[Obsolete("Use Configure(String,Boolean)")]
		public static void Configure(string filename)
		{
			RemotingConfiguration.Configure(filename, false);
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x000C2BC4 File Offset: 0x000C0DC4
		private static void ReadConfigString(string filename)
		{
			try
			{
				SmallXmlParser smallXmlParser = new SmallXmlParser();
				using (TextReader textReader = new StringReader(filename))
				{
					ConfigHandler handler = new ConfigHandler(false);
					smallXmlParser.Parse(textReader, handler);
				}
			}
			catch (Exception ex)
			{
				throw new RemotingException("Configuration string could not be loaded: " + ex.Message, ex);
			}
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x000C2C30 File Offset: 0x000C0E30
		private static void ReadConfigFile(string filename)
		{
			try
			{
				SmallXmlParser smallXmlParser = new SmallXmlParser();
				using (TextReader textReader = new StreamReader(filename))
				{
					ConfigHandler handler = new ConfigHandler(false);
					smallXmlParser.Parse(textReader, handler);
				}
			}
			catch (Exception ex)
			{
				throw new RemotingException("Configuration file '" + filename + "' could not be loaded: " + ex.Message, ex);
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000C2CA4 File Offset: 0x000C0EA4
		internal static void LoadDefaultDelayedChannels()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (!RemotingConfiguration.defaultDelayedConfigRead && !RemotingConfiguration.defaultConfigRead)
				{
					SmallXmlParser smallXmlParser = new SmallXmlParser();
					using (TextReader textReader = new StreamReader(Environment.GetMachineConfigPath()))
					{
						ConfigHandler handler = new ConfigHandler(true);
						smallXmlParser.Parse(textReader, handler);
					}
					RemotingConfiguration.defaultDelayedConfigRead = true;
				}
			}
		}

		/// <summary>Извлекает массив типов объектов, зарегистрированных со стороны клиента в качестве удаленно активированных типов.</summary>
		/// <returns>Массив типов объектов, зарегистрированных со стороны клиента в качестве удаленно активированных типов.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600362D RID: 13869 RVA: 0x000C2D30 File Offset: 0x000C0F30
		public static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			ActivatedClientTypeEntry[] result;
			lock (obj)
			{
				ActivatedClientTypeEntry[] array = new ActivatedClientTypeEntry[RemotingConfiguration.activatedClientEntries.Count];
				RemotingConfiguration.activatedClientEntries.Values.CopyTo(array, 0);
				result = array;
			}
			return result;
		}

		/// <summary>Извлекает массив типа объектов, зарегистрированных со стороны службы, который может быть активирован по запросу клиента.</summary>
		/// <returns>Массив типов объектов, зарегистрированных со стороны службы, который может быть активирован по запросу клиента.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600362E RID: 13870 RVA: 0x000C2D90 File Offset: 0x000C0F90
		public static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			ActivatedServiceTypeEntry[] result;
			lock (obj)
			{
				ActivatedServiceTypeEntry[] array = new ActivatedServiceTypeEntry[RemotingConfiguration.activatedServiceEntries.Count];
				RemotingConfiguration.activatedServiceEntries.Values.CopyTo(array, 0);
				result = array;
			}
			return result;
		}

		/// <summary>Извлекает массив типов объектов, зарегистрированных со стороны клиента в качестве хорошо известных типов.</summary>
		/// <returns>Массив типов объектов, зарегистрированных со стороны клиента в качестве хорошо известных типов.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600362F RID: 13871 RVA: 0x000C2DF0 File Offset: 0x000C0FF0
		public static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			WellKnownClientTypeEntry[] result;
			lock (obj)
			{
				WellKnownClientTypeEntry[] array = new WellKnownClientTypeEntry[RemotingConfiguration.wellKnownClientEntries.Count];
				RemotingConfiguration.wellKnownClientEntries.Values.CopyTo(array, 0);
				result = array;
			}
			return result;
		}

		/// <summary>Извлекает массив типов объектов, зарегистрированных со стороны службы в качестве хорошо известных типов.</summary>
		/// <returns>Массив типов объектов, зарегистрированных со стороны службы в качестве хорошо известных типов.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003630 RID: 13872 RVA: 0x000C2E50 File Offset: 0x000C1050
		public static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes()
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			WellKnownServiceTypeEntry[] result;
			lock (obj)
			{
				WellKnownServiceTypeEntry[] array = new WellKnownServiceTypeEntry[RemotingConfiguration.wellKnownServiceEntries.Count];
				RemotingConfiguration.wellKnownServiceEntries.Values.CopyTo(array, 0);
				result = array;
			}
			return result;
		}

		/// <summary>Возвращает логическое значение, показывающее, разрешена ли клиентская активация указанного типа <see cref="T:System.Type" />.</summary>
		/// <param name="svrType">Проверяемый объект <see cref="T:System.Type" />.</param>
		/// <returns>
		///   <see langword="true" />, если указанный тип <see cref="T:System.Type" /> может активироваться клиентом; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003631 RID: 13873 RVA: 0x000C2EB0 File Offset: 0x000C10B0
		public static bool IsActivationAllowed(Type svrType)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			bool result;
			lock (obj)
			{
				result = RemotingConfiguration.activatedServiceEntries.ContainsKey(svrType);
			}
			return result;
		}

		/// <summary>Проверяет, зарегистрирован ли тип указанного объекта <see cref="T:System.Type" /> в качестве удаленно активированного типа клиента.</summary>
		/// <param name="svrType">Проверяемый тип объекта.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" />, соответствующая указанному типу объекта.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003632 RID: 13874 RVA: 0x000C2EF8 File Offset: 0x000C10F8
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			ActivatedClientTypeEntry result;
			lock (obj)
			{
				result = (RemotingConfiguration.activatedClientEntries[svrType] as ActivatedClientTypeEntry);
			}
			return result;
		}

		/// <summary>Проверяет, зарегистрирован ли объект, указанный по своему имени и имени сборки, в качестве удаленно активированного типа клиента.</summary>
		/// <param name="typeName">Имя типа проверяемого объекта.</param>
		/// <param name="assemblyName">Имя сборки проверяемого объекта.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" />, соответствующая указанному типу объекта.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003633 RID: 13875 RVA: 0x000C2F44 File Offset: 0x000C1144
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName)
		{
			return RemotingConfiguration.IsRemotelyActivatedClientType(Assembly.Load(assemblyName).GetType(typeName));
		}

		/// <summary>Проверяет, зарегистрирован ли указанный объект <see cref="T:System.Type" /> в качестве хорошо известного типа клиента.</summary>
		/// <param name="svrType">Проверяемый объект <see cref="T:System.Type" />.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" />, соответствующая указанному типу объекта.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003634 RID: 13876 RVA: 0x000C2F58 File Offset: 0x000C1158
		public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			WellKnownClientTypeEntry result;
			lock (obj)
			{
				result = (RemotingConfiguration.wellKnownClientEntries[svrType] as WellKnownClientTypeEntry);
			}
			return result;
		}

		/// <summary>Проверяет, зарегистрирован ли объект, указанный по его имени и имени сборки, в качестве хорошо известного типа клиента.</summary>
		/// <param name="typeName">Имя типа проверяемого объекта.</param>
		/// <param name="assemblyName">Имя сборки проверяемого объекта.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" />, соответствующая указанному типу объекта.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003635 RID: 13877 RVA: 0x000C2FA4 File Offset: 0x000C11A4
		public static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName)
		{
			return RemotingConfiguration.IsWellKnownClientType(Assembly.Load(assemblyName).GetType(typeName));
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" />, записанный в предоставленный <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> на стороне клиента в качестве типа, который может быть активирован сервером.</summary>
		/// <param name="entry">Параметры конфигурации для активированного клиентом типа.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003636 RID: 13878 RVA: 0x000C2FB8 File Offset: 0x000C11B8
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (RemotingConfiguration.wellKnownClientEntries.ContainsKey(entry.ObjectType) || RemotingConfiguration.activatedClientEntries.ContainsKey(entry.ObjectType))
				{
					throw new RemotingException("Attempt to redirect activation of type '" + entry.ObjectType.FullName + "' which is already redirected.");
				}
				RemotingConfiguration.activatedClientEntries[entry.ObjectType] = entry;
				ActivationServices.EnableProxyActivation(entry.ObjectType, true);
			}
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" /> со стороны клиента в качестве типа, который может активироваться сервером, используя данные параметры для инициализации нового экземпляра класса <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />.</param>
		/// <param name="appUrl">URL-адрес приложения, где активируется этот тип.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="typeName" /> или параметра <paramref name="URI" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003637 RID: 13879 RVA: 0x000C3054 File Offset: 0x000C1254
		public static void RegisterActivatedClientType(Type type, string appUrl)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (appUrl == null)
			{
				throw new ArgumentNullException("appUrl");
			}
			RemotingConfiguration.RegisterActivatedClientType(new ActivatedClientTypeEntry(type, appUrl));
		}

		/// <summary>Регистрирует тип объекта в предоставленном со стороны службы <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> в качестве типа, который может активироваться по запросу клиента.</summary>
		/// <param name="entry">Параметры конфигурации для активированного клиентом типа.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003638 RID: 13880 RVA: 0x000C3084 File Offset: 0x000C1284
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				RemotingConfiguration.activatedServiceEntries.Add(entry.ObjectType, entry);
			}
		}

		/// <summary>Регистрирует указанный тип объектов, зарегистрированных со стороны службы, в качестве типа, который может быть активирован по запросу клиента.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> объекта для регистрации.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x06003639 RID: 13881 RVA: 0x000C30D0 File Offset: 0x000C12D0
		public static void RegisterActivatedServiceType(Type type)
		{
			RemotingConfiguration.RegisterActivatedServiceType(new ActivatedServiceTypeEntry(type));
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" /> со стороны клиента в качестве хорошо известного объекта, который может быть активирован на сервере, используя данные параметры для инициализации нового экземпляра класса <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />.</param>
		/// <param name="objectUrl">Адрес URL хорошо известного объекта.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600363A RID: 13882 RVA: 0x000C30DD File Offset: 0x000C12DD
		public static void RegisterWellKnownClientType(Type type, string objectUrl)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (objectUrl == null)
			{
				throw new ArgumentNullException("objectUrl");
			}
			RemotingConfiguration.RegisterWellKnownClientType(new WellKnownClientTypeEntry(type, objectUrl));
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" />, записанный в предоставленный <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> со стороны клиента в качестве хорошо известного типа, который может быть активирован сервером.</summary>
		/// <param name="entry">Параметры конфигурации для хорошо известного типа.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600363B RID: 13883 RVA: 0x000C3110 File Offset: 0x000C1310
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				if (RemotingConfiguration.wellKnownClientEntries.ContainsKey(entry.ObjectType) || RemotingConfiguration.activatedClientEntries.ContainsKey(entry.ObjectType))
				{
					throw new RemotingException("Attempt to redirect activation of type '" + entry.ObjectType.FullName + "' which is already redirected.");
				}
				RemotingConfiguration.wellKnownClientEntries[entry.ObjectType] = entry;
				ActivationServices.EnableProxyActivation(entry.ObjectType, true);
			}
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" /> со стороны клиента в качестве хорошо известного типа, используя параметры, заданные для инициализации нового экземпляра класса <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />.</param>
		/// <param name="objectUri">URI-объект.</param>
		/// <param name="mode">Регистрируется режим активации типа хорошо известного объекта. (См. раздел <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />).</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600363C RID: 13884 RVA: 0x000C31AC File Offset: 0x000C13AC
		public static void RegisterWellKnownServiceType(Type type, string objectUri, WellKnownObjectMode mode)
		{
			RemotingConfiguration.RegisterWellKnownServiceType(new WellKnownServiceTypeEntry(type, objectUri, mode));
		}

		/// <summary>Регистрирует объект <see cref="T:System.Type" />, записанный в предоставленном <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> со стороны службы в качестве хорошо известного типа.</summary>
		/// <param name="entry">Параметры конфигурации для хорошо известного типа.</param>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия.</exception>
		// Token: 0x0600363D RID: 13885 RVA: 0x000C31BC File Offset: 0x000C13BC
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			Hashtable obj = RemotingConfiguration.channelTemplates;
			lock (obj)
			{
				RemotingConfiguration.wellKnownServiceEntries[entry.ObjectUri] = entry;
				RemotingServices.CreateWellKnownServerIdentity(entry.ObjectType, entry.ObjectUri, entry.Mode);
			}
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x000C3220 File Offset: 0x000C1420
		internal static void RegisterChannelTemplate(ChannelData channel)
		{
			RemotingConfiguration.channelTemplates[channel.Id] = channel;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x000C3233 File Offset: 0x000C1433
		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
			RemotingConfiguration.clientProviderTemplates[prov.Id] = prov;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x000C3246 File Offset: 0x000C1446
		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
			RemotingConfiguration.serverProviderTemplates[prov.Id] = prov;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000C325C File Offset: 0x000C145C
		internal static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
			foreach (object obj in channels)
			{
				ChannelData channelData = (ChannelData)obj;
				if ((!onlyDelayed || !(channelData.DelayLoadAsClientChannel != "true")) && (!RemotingConfiguration.defaultDelayedConfigRead || !(channelData.DelayLoadAsClientChannel == "true")))
				{
					if (channelData.Ref != null)
					{
						ChannelData channelData2 = (ChannelData)RemotingConfiguration.channelTemplates[channelData.Ref];
						if (channelData2 == null)
						{
							throw new RemotingException("Channel template '" + channelData.Ref + "' not found");
						}
						channelData.CopyFrom(channelData2);
					}
					foreach (object obj2 in channelData.ServerProviders)
					{
						ProviderData providerData = (ProviderData)obj2;
						if (providerData.Ref != null)
						{
							ProviderData providerData2 = (ProviderData)RemotingConfiguration.serverProviderTemplates[providerData.Ref];
							if (providerData2 == null)
							{
								throw new RemotingException("Provider template '" + providerData.Ref + "' not found");
							}
							providerData.CopyFrom(providerData2);
						}
					}
					foreach (object obj3 in channelData.ClientProviders)
					{
						ProviderData providerData3 = (ProviderData)obj3;
						if (providerData3.Ref != null)
						{
							ProviderData providerData4 = (ProviderData)RemotingConfiguration.clientProviderTemplates[providerData3.Ref];
							if (providerData4 == null)
							{
								throw new RemotingException("Provider template '" + providerData3.Ref + "' not found");
							}
							providerData3.CopyFrom(providerData4);
						}
					}
					ChannelServices.RegisterChannelConfig(channelData);
				}
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x000C3474 File Offset: 0x000C1674
		internal static void RegisterTypes(ArrayList types)
		{
			foreach (object obj in types)
			{
				TypeEntry typeEntry = (TypeEntry)obj;
				if (typeEntry is ActivatedClientTypeEntry)
				{
					RemotingConfiguration.RegisterActivatedClientType((ActivatedClientTypeEntry)typeEntry);
				}
				else if (typeEntry is ActivatedServiceTypeEntry)
				{
					RemotingConfiguration.RegisterActivatedServiceType((ActivatedServiceTypeEntry)typeEntry);
				}
				else if (typeEntry is WellKnownClientTypeEntry)
				{
					RemotingConfiguration.RegisterWellKnownClientType((WellKnownClientTypeEntry)typeEntry);
				}
				else if (typeEntry is WellKnownServiceTypeEntry)
				{
					RemotingConfiguration.RegisterWellKnownServiceType((WellKnownServiceTypeEntry)typeEntry);
				}
			}
		}

		/// <summary>Указывает, возвращают ли каналы сервера в этом домене приложения локальным или удаленным вызывающим объектам фильтрованные или полные сведения об исключениях.</summary>
		/// <param name="isLocalRequest">
		///   <see langword="true" /> чтобы указать локальные вызывающие операторы. <see langword="false" /> чтобы указать удаленные вызывающие операторы.</param>
		/// <returns>
		///   <see langword="true" />, если только фильтрованные сведения об исключениях возвращаются в локальные или удаленные вызывающие, как указано параметром <paramref name="isLocalRequest" />. <see langword="false" />, если возвращаются полные сведения об исключении.</returns>
		// Token: 0x06003643 RID: 13891 RVA: 0x000C3514 File Offset: 0x000C1714
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			return RemotingConfiguration._errorMode != CustomErrorsModes.Off && (RemotingConfiguration._errorMode == CustomErrorsModes.On || !isLocalRequest);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x000C3530 File Offset: 0x000C1730
		internal static void SetCustomErrorsMode(string mode)
		{
			if (mode == null)
			{
				throw new RemotingException("mode attribute is required");
			}
			string text = mode.ToLower();
			if (text != "on" && text != "off" && text != "remoteonly")
			{
				throw new RemotingException("Invalid custom error mode: " + mode);
			}
			RemotingConfiguration._errorMode = (CustomErrorsModes)Enum.Parse(typeof(CustomErrorsModes), text, true);
		}

		// Token: 0x0400252D RID: 9517
		private static string applicationID = null;

		// Token: 0x0400252E RID: 9518
		private static string applicationName = null;

		// Token: 0x0400252F RID: 9519
		private static string processGuid = null;

		// Token: 0x04002530 RID: 9520
		private static bool defaultConfigRead = false;

		// Token: 0x04002531 RID: 9521
		private static bool defaultDelayedConfigRead = false;

		// Token: 0x04002532 RID: 9522
		private static CustomErrorsModes _errorMode = CustomErrorsModes.RemoteOnly;

		// Token: 0x04002533 RID: 9523
		private static Hashtable wellKnownClientEntries = new Hashtable();

		// Token: 0x04002534 RID: 9524
		private static Hashtable activatedClientEntries = new Hashtable();

		// Token: 0x04002535 RID: 9525
		private static Hashtable wellKnownServiceEntries = new Hashtable();

		// Token: 0x04002536 RID: 9526
		private static Hashtable activatedServiceEntries = new Hashtable();

		// Token: 0x04002537 RID: 9527
		private static Hashtable channelTemplates = new Hashtable();

		// Token: 0x04002538 RID: 9528
		private static Hashtable clientProviderTemplates = new Hashtable();

		// Token: 0x04002539 RID: 9529
		private static Hashtable serverProviderTemplates = new Hashtable();
	}
}
