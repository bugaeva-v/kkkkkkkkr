using System;
using System.Collections;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Обрабатывает разделы конфигурации, которые представлены единым XML-тегом в файле конфигурации.</summary>
	// Token: 0x020001D9 RID: 473
	public class SingleTagSectionHandler : IConfigurationSectionHandler
	{
		/// <summary>Предназначен для внутреннего использования для создания нового экземпляра данного объекта.</summary>
		/// <param name="parent">Родительский объект этого объекта.</param>
		/// <param name="context">Контекст этого объекта.</param>
		/// <param name="section">Объект <see cref="T:System.Xml.XmlNode" /> в конфигурации.</param>
		/// <returns>Созданный обработчик объекта.</returns>
		// Token: 0x06000C58 RID: 3160 RVA: 0x00032770 File Offset: 0x00030970
		public virtual object Create(object parent, object context, XmlNode section)
		{
			Hashtable hashtable;
			if (parent == null)
			{
				hashtable = new Hashtable();
			}
			else
			{
				hashtable = (Hashtable)parent;
			}
			if (section.HasChildNodes)
			{
				throw new ConfigurationException("Child Nodes not allowed.");
			}
			XmlAttributeCollection attributes = section.Attributes;
			for (int i = 0; i < attributes.Count; i++)
			{
				hashtable.Add(attributes[i].Name, attributes[i].Value);
			}
			return hashtable;
		}
	}
}
