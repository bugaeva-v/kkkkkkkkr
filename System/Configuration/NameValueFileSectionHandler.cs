using System;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Предоставляет доступ к файлу конфигурации. Этот тип обеспечивает поддержку инфраструктуры платформы .NET Framework и не предназначен для непосредственного использования в коде.</summary>
	// Token: 0x020001B9 RID: 441
	public class NameValueFileSectionHandler : IConfigurationSectionHandler
	{
		/// <summary>Создает новый обработчик конфигурации и добавляет его к коллекции обработчика раздела на основе указанных параметров.</summary>
		/// <param name="parent">Родительский объект.</param>
		/// <param name="configContext">Объект контекста конфигурации.</param>
		/// <param name="section">узел раздела XML.</param>
		/// <returns>Объект конфигурации.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Файл, указанный в атрибуте <see langword="file" /> раздела <paramref name="section" />, существует, но не может быть загружен.  
		/// -или- 
		/// Атрибут <see langword="name" /> раздела <paramref name="section" /> не совпадает с корневым элементом файла, указанным в атрибуте <see langword="file" />.</exception>
		// Token: 0x06000BA1 RID: 2977 RVA: 0x000313E4 File Offset: 0x0002F5E4
		public object Create(object parent, object configContext, XmlNode section)
		{
			XmlNode xmlNode = null;
			if (section.Attributes != null)
			{
				xmlNode = section.Attributes.RemoveNamedItem("file");
			}
			NameValueCollection nameValueCollection = ConfigHelper.GetNameValueCollection(parent as NameValueCollection, section, "key", "value");
			if (xmlNode != null && xmlNode.Value != string.Empty)
			{
				string text = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(((IConfigXmlNode)section).Filename)), xmlNode.Value);
				if (!File.Exists(text))
				{
					return nameValueCollection;
				}
				ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
				configXmlDocument.Load(text);
				if (configXmlDocument.DocumentElement.Name != section.Name)
				{
					throw new ConfigurationException("Invalid root element", configXmlDocument.DocumentElement);
				}
				nameValueCollection = ConfigHelper.GetNameValueCollection(nameValueCollection, configXmlDocument.DocumentElement, "key", "value");
			}
			return nameValueCollection;
		}
	}
}
