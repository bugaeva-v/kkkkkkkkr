using System;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Дает устаревшее определение обработчика раздела для разделов конфигурации, которые не обрабатываются типами <see cref="N:System.Configuration" />.</summary>
	// Token: 0x020001B6 RID: 438
	public class IgnoreSectionHandler : IConfigurationSectionHandler
	{
		/// <summary>Создает новый обработчик конфигурации и добавляет указанный объект конфигурации в коллекцию обработчиков раздела.</summary>
		/// <param name="parent">Параметры конфигурации в соответствующем родительском разделе конфигурации.</param>
		/// <param name="configContext">Виртуальный путь, для которого обработчик раздела конфигурации вычисляет значения конфигурации. Обычно, этот параметр зарезервирован и хранится как <see langword="null" />.</param>
		/// <param name="section">
		///   <see cref="T:System.Xml.XmlNode" /> с обрабатываемыми сведениями о конфигурации. Предоставляет прямой доступ к XML-содержимому раздела конфигурации.</param>
		/// <returns>Созданный объект обработчика конфигурации.</returns>
		// Token: 0x06000B8F RID: 2959 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			return null;
		}
	}
}
