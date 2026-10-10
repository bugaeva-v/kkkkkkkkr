using System;

namespace System.Configuration
{
	/// <summary>Задает расположения в иерархии файла конфигурации, которые могут устанавливать или переопределять свойства, содержащиеся в объекте <see cref="T:System.Configuration.ConfigurationSection" />.</summary>
	// Token: 0x02000016 RID: 22
	public enum ConfigurationAllowExeDefinition
	{
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться только в файле Machine.config.</summary>
		// Token: 0x04000054 RID: 84
		MachineOnly,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться либо в файле Machine.config, либо в файле Exe.config в каталоге клиентского приложения. Это значение по умолчанию.</summary>
		// Token: 0x04000055 RID: 85
		MachineToApplication = 100,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться в файле Machine.config, в файле Exe.config в каталоге клиентского приложения, в файле User.config в перемещаемом каталоге пользователя или в файле User.config в каталоге локального пользователя.</summary>
		// Token: 0x04000056 RID: 86
		MachineToLocalUser = 300,
		/// <summary>
		///   <see cref="T:System.Configuration.ConfigurationSection" /> может определяться в файле Machine.config, в файле Exe.config в каталоге клиентского приложения или в файле User.config в перемещаемом каталоге пользователя.</summary>
		// Token: 0x04000057 RID: 87
		MachineToRoamingUser = 200
	}
}
