using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый платформой .NET Framework, для инициализации свойств конфигурации.</summary>
	// Token: 0x0200007E RID: 126
	[ComVisible(false)]
	public interface IConfigurationManagerInternal
	{
		/// <summary>Возвращает имя файла конфигурации, связанное с путем приложения.</summary>
		/// <returns>Значение строки, представляющее имя файла конфигурации.</returns>
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600042D RID: 1069
		string ApplicationConfigUri { get; }

		/// <summary>Возвращает локальный каталог конфигурации приложения, основанного на сборке записей.</summary>
		/// <returns>Строка, представляющая локальный каталог конфигурации.</returns>
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600042E RID: 1070
		string ExeLocalConfigDirectory { get; }

		/// <summary>Возвращает путь локальной конфигурации приложения, основанного на сборке записей.</summary>
		/// <returns>Значение строки, представляющее путь перемещаемой конфигурации приложения.</returns>
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600042F RID: 1071
		string ExeLocalConfigPath { get; }

		/// <summary>Возвращает имя продукта приложения, основанного на сборке записей.</summary>
		/// <returns>Значение строки, представляющее имя продукта приложения.</returns>
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000430 RID: 1072
		string ExeProductName { get; }

		/// <summary>Возвращает версию продукта приложения, основанного на сборке записей.</summary>
		/// <returns>Значение строки, представляющее версию продукта приложения.</returns>
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000431 RID: 1073
		string ExeProductVersion { get; }

		/// <summary>Возвращает перемещаемый каталог конфигурации приложения, основанного на сборке записей.</summary>
		/// <returns>Значение строки, представляющее перемещаемый каталог конфигурации приложения.</returns>
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000432 RID: 1074
		string ExeRoamingConfigDirectory { get; }

		/// <summary>Возвращает путь пользовательской перемещаемой конфигурации на основании сборки записей приложения.</summary>
		/// <returns>Значение строки, представляющее путь перемещаемой пользовательской конфигурации.</returns>
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000433 RID: 1075
		string ExeRoamingConfigPath { get; }

		/// <summary>Возвращает путь конфигурации для файла Machine.config.</summary>
		/// <returns>Значение строки, представляющее путь к файлу Machine.config file.</returns>
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000434 RID: 1076
		string MachineConfigPath { get; }

		/// <summary>Возвращает значение. представляющее состояние системы конфигурации.</summary>
		/// <returns>
		///   <see langword="true" /> если система конфигурации в процессе инициализации, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000435 RID: 1077
		bool SetConfigurationSystemInProgress { get; }

		/// <summary>Возвращает значение, определяющее, поддерживаются ли параметры пользовательской конфигурации.</summary>
		/// <returns>
		///   <see langword="true" /> если система конфигурации поддерживает параметры пользовательской конфигурации; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000436 RID: 1078
		bool SupportsUserConfig { get; }

		/// <summary>Возвращает имя файла, используемого для хранения параметров пользовательской конфигурации.</summary>
		/// <returns>Строка, определяющая имя файла, используемого для хранения пользовательской конфигурации.</returns>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000437 RID: 1079
		string UserConfigFilename { get; }
	}
}
