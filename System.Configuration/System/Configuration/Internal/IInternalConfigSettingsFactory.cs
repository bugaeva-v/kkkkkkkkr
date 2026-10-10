using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый системой конфигурации для установки класса <see cref="T:System.Configuration.ConfigurationSettings" />.</summary>
	// Token: 0x02000084 RID: 132
	[ComVisible(false)]
	public interface IInternalConfigSettingsFactory
	{
		/// <summary>Указывает, что инициализация системы конфигурации завершена.</summary>
		// Token: 0x0600047C RID: 1148
		void CompleteInit();

		/// <summary>Предоставляет иерархические параметры конфигурации и расширения, определенные для ASP.NET в системе конфигурации.</summary>
		/// <param name="internalConfigSystem">Объект <see cref="T:System.Configuration.Internal.IInternalConfigSystem" />, который используется классом <see cref="T:System.Configuration.ConfigurationSettings" />.</param>
		/// <param name="initComplete">
		///   <see langword="true" /> если процесс инициализации системы конфигурации завершен, в противном случае — <see langword="false" />.</param>
		// Token: 0x0600047D RID: 1149
		void SetConfigurationSystem(IInternalConfigSystem internalConfigSystem, bool initComplete);
	}
}
