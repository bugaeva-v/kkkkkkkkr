using System;
using System.Runtime.InteropServices;

namespace System.Configuration
{
	/// <summary>Предоставляет методы стандартной конфигурации.</summary>
	// Token: 0x020001B2 RID: 434
	[ComVisible(false)]
	public interface IConfigurationSystem
	{
		/// <summary>Возвращает указанную конфигурацию.</summary>
		/// <param name="configKey">Ключ конфигурации.</param>
		/// <returns>Объект, представляющий конфигурацию.</returns>
		// Token: 0x06000B7E RID: 2942
		object GetConfig(string configKey);

		/// <summary>Используется для инициализации.</summary>
		// Token: 0x06000B7F RID: 2943
		void Init();
	}
}
