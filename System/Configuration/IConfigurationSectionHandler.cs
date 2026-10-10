using System;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Обрабатывает доступ к конкретным разделам конфигурации.</summary>
	// Token: 0x020001B1 RID: 433
	public interface IConfigurationSectionHandler
	{
		/// <summary>Создает обработчик раздела конфигурации.</summary>
		/// <param name="parent">Родительский объект.</param>
		/// <param name="configContext">Объект контекста конфигурации.</param>
		/// <param name="section">Узел раздела XML.</param>
		/// <returns>Созданный объект обработчика раздела.</returns>
		// Token: 0x06000B7D RID: 2941
		object Create(object parent, object configContext, XmlNode section);
	}
}
