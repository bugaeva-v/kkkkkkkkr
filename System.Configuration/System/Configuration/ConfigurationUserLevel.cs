using System;

namespace System.Configuration
{
	/// <summary>Используется, чтобы уточнить, какой файл конфигурации будет присутствовать в объекте конфигурации.</summary>
	// Token: 0x02000035 RID: 53
	public enum ConfigurationUserLevel
	{
		/// <summary>Получает <see cref="T:System.Configuration.Configuration" />, применимый ко всем пользователям.</summary>
		// Token: 0x040000D2 RID: 210
		None,
		/// <summary>Получает роуминг <see cref="T:System.Configuration.Configuration" />, применимый к текущему пользователю.</summary>
		// Token: 0x040000D3 RID: 211
		PerUserRoaming = 10,
		/// <summary>Получает локальный <see cref="T:System.Configuration.Configuration" />, применимый к текущему пользователю.</summary>
		// Token: 0x040000D4 RID: 212
		PerUserRoamingAndLocal = 20
	}
}
