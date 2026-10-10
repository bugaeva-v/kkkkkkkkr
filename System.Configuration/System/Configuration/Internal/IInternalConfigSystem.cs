using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый платформой .NET Framework, для инициализации свойств конфигурации приложения.</summary>
	// Token: 0x02000085 RID: 133
	[ComVisible(false)]
	public interface IInternalConfigSystem
	{
		/// <summary>Возвращает объект конфигурации на основании определенного ключа.</summary>
		/// <param name="configKey">Значение ключа конфигурации.</param>
		/// <returns>Объект конфигурации.</returns>
		// Token: 0x0600047E RID: 1150
		object GetSection(string configKey);

		/// <summary>Обновляет систему конфигурации на основании определенного имени раздела.</summary>
		/// <param name="sectionName">Имя раздела конфигурации.</param>
		// Token: 0x0600047F RID: 1151
		void RefreshConfig(string sectionName);

		/// <summary>Возвращает значение, определяющее, поддерживается ли пользовательская конфигурация.</summary>
		/// <returns>
		///   <see langword="true" />, если пользовательская конфигурация поддерживается; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000480 RID: 1152
		bool SupportsUserConfig { get; }
	}
}
