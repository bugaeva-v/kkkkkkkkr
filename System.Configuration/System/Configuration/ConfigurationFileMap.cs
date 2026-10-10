using System;
using System.Runtime.InteropServices;

namespace System.Configuration
{
	/// <summary>Определяет сопоставление файла конфигурации для файла конфигурации компьютера.</summary>
	// Token: 0x02000021 RID: 33
	public class ConfigurationFileMap : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationFileMap" />.</summary>
		// Token: 0x06000124 RID: 292 RVA: 0x00005775 File Offset: 0x00003975
		public ConfigurationFileMap()
		{
			this.machineConfigFilename = RuntimeEnvironment.SystemConfigurationFile;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Configuration.ConfigurationFileMap" /> согласно указанному параметру.</summary>
		/// <param name="machineConfigFilename">Имя файла конфигурации компьютера.</param>
		// Token: 0x06000125 RID: 293 RVA: 0x00005788 File Offset: 0x00003988
		public ConfigurationFileMap(string machineConfigFilename)
		{
			this.machineConfigFilename = machineConfigFilename;
		}

		/// <summary>Получает или задает имя файла конфигурации компьютера.</summary>
		/// <returns>Имя файла конфигурации машины.</returns>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005797 File Offset: 0x00003997
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000579F File Offset: 0x0000399F
		public string MachineConfigFilename
		{
			get
			{
				return this.machineConfigFilename;
			}
			set
			{
				this.machineConfigFilename = value;
			}
		}

		/// <summary>Создает копию существующего объекта <see cref="T:System.Configuration.ConfigurationFileMap" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationFileMap" />.</returns>
		// Token: 0x06000128 RID: 296 RVA: 0x000057A8 File Offset: 0x000039A8
		public virtual object Clone()
		{
			return new ConfigurationFileMap(this.machineConfigFilename);
		}

		// Token: 0x04000088 RID: 136
		private string machineConfigFilename;
	}
}
