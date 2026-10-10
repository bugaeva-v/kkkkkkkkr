using System;

namespace System.Configuration
{
	/// <summary>Задает расположения в иерархии файла конфигурации, которые могут устанавливать или переопределять свойства, содержащиеся в объекте <see cref="T:System.Configuration.ConfigurationSection" />.</summary>
	// Token: 0x02000015 RID: 21
	public enum ConfigurationAllowDefinition
	{
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться только в файле Machine.config.</summary>
		// Token: 0x0400004F RID: 79
		MachineOnly,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться либо в файле Machine.config, либо на машинном уровне в файле Web.config, находящемся в том же каталоге что и Machine.config, но не в файлах Web.config приложения.</summary>
		// Token: 0x04000050 RID: 80
		MachineToWebRoot = 100,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться либо в файле Machine.config, на машинном уровне в файле Web.config, находящемся в той же папке что и Machine.config, либо в файле Web.config приложения более высокого уровня, находящемся в корневом виртуальном каталоге, а не в подкаталогах виртуального корневого каталога.</summary>
		// Token: 0x04000051 RID: 81
		MachineToApplication = 200,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может быть определено везде.</summary>
		// Token: 0x04000052 RID: 82
		Everywhere = 300
	}
}
