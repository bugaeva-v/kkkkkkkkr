using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Обеспечивает программный доступ к разделу <see langword="&lt;configBuilders&gt;" />. Этот класс не наследуется.</summary>
	// Token: 0x0200008F RID: 143
	public sealed class ConfigurationBuildersSection : ConfigurationSection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationBuildersSection" />.</summary>
		// Token: 0x06000495 RID: 1173 RVA: 0x00003518 File Offset: 0x00001718
		public ConfigurationBuildersSection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает <see cref="T:System.Configuration.ConfigurationBuilderCollection" /> всех объектов <see cref="T:System.Configuration.ConfigurationBuilder" /> во всех участвующих файлах конфигурации.</summary>
		/// <returns>Объекты <see cref="T:System.Configuration.ConfigurationBuilder" /> во всех участвующих файлах конфигурации.</returns>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00003527 File Offset: 0x00001727
		public ProviderSettingsCollection Builders
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.ConfigurationBuilder" /> с предоставленным именем построителя конфигурации.</summary>
		/// <param name="builderName">Имя построителя конфигурации или список имен, разделенных запятыми. Если <paramref name="builderName" /> является разделенным запятыми списком имен <see cref="T:System.Configuration.ConfigurationBuilder" />, возвращается специальный объект вычисления <see cref="T:System.Configuration.ConfigurationBuilder" />, который ссылается на все именованные построители конфигураций и применяет их.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationBuilder" /> с предоставленной конфигурацией <paramref name="builderName" />.</returns>
		/// <exception cref="T:System.Exception">Невозможно создавать экземпляры типа поставщика конфигурации в рамках политики с частичным уровнем доверия (<see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> отсутствует в целевой сборке).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">ConfigurationBuilders.IgnoreLoadFailure отключен по умолчанию. Если развернутый построитель конфигурации не удается найти или создать для одного из разделов, считываемых из файла конфигурации, выполняется перехват <see cref="T:System.IO.FileNotFoundException" /> и отправляется соответствующее сообщение. Чтобы игнорировать сбои при загрузке, включите ConfigurationBuilders.IgnoreLoadFailure.</exception>
		/// <exception cref="T:System.TypeLoadException">ConfigurationBuilders.IgnoreLoadFailure отключен по умолчанию. Если во время загрузки построителя конфигурации возникает <see cref="T:System.TypeLoadException" /> для одного из разделов, считываемых из файла конфигурации, выполняется перехват <see cref="T:System.TypeLoadException" /> и отправляется соответствующее сообщение. Чтобы игнорировать сбои при загрузке, включите ConfigurationBuilders.IgnoreLoadFailure.</exception>
		// Token: 0x06000497 RID: 1175 RVA: 0x00003527 File Offset: 0x00001727
		public ConfigurationBuilder GetBuilderFromName(string builderName)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
