using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет группу элементов конфигурации, используемых для настройки поставщиков для раздела конфигурации <see langword="&lt;configBuilders&gt;" />.</summary>
	// Token: 0x0200008E RID: 142
	public class ConfigurationBuilderSettings : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationBuilderSettings" />.</summary>
		// Token: 0x06000493 RID: 1171 RVA: 0x00003518 File Offset: 0x00001718
		public ConfigurationBuilderSettings()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает коллекцию объектов <see cref="T:System.Configuration.ConfigurationBuilderSettings" />, представляющих свойства построителей конфигурации.</summary>
		/// <returns>Объекты <see cref="T:System.Configuration.ConfigurationBuilder" />.</returns>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00003527 File Offset: 0x00001727
		public ProviderSettingsCollection Builders
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
