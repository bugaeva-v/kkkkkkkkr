using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace System.Configuration.Internal
{
	/// <summary>Определяет дополнительный интерфейс для <see cref="T:System.Configuration.Internal.IInternalConfigHost" /> для узлов конфигурации, которые должны поддерживать применение объектов <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
	// Token: 0x0200008C RID: 140
	[ComVisible(false)]
	public interface IInternalConfigurationBuilderHost
	{
		/// <summary>Обрабатывает объект <see cref="T:System.Configuration.ConfigurationSection" />, используя предоставленную коллекцию <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
		/// <param name="configSection">Обрабатываемый тип <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <param name="builder">
		///   <see cref="T:System.Configuration.ConfigurationBuilder" /> для использования в обработке <paramref name="configSection" />.</param>
		/// <returns>Обработанный <see cref="T:System.Configuration.ConfigurationSection" />.</returns>
		// Token: 0x06000490 RID: 1168
		ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection, ConfigurationBuilder builder);

		/// <summary>Обрабатывает разметку раздела конфигурации, используя предоставленную коллекцию <see cref="T:System.Configuration.ConfigurationBuilder" />.</summary>
		/// <param name="rawXml">Обрабатываемый тип <see cref="T:System.Xml.XmlNode" />.</param>
		/// <param name="builder">
		///   <see cref="T:System.Configuration.ConfigurationBuilder" /> для использования в обработке <paramref name="rawXml" />.</param>
		/// <returns>Обработанный <see cref="T:System.Xml.XmlNode" />.</returns>
		// Token: 0x06000491 RID: 1169
		XmlNode ProcessRawXml(XmlNode rawXml, ConfigurationBuilder builder);
	}
}
