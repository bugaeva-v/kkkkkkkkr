using System;
using System.Collections.Specialized;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Предоставляет сведения о парах имя-значение конфигурации из раздела конфигурации.</summary>
	// Token: 0x020001BA RID: 442
	public class NameValueSectionHandler : IConfigurationSectionHandler
	{
		/// <summary>Создает новый обработчик конфигурации и добавляет его к коллекции обработчика раздела на основе указанных параметров.</summary>
		/// <param name="parent">Родительский объект.</param>
		/// <param name="context">Объект контекста конфигурации.</param>
		/// <param name="section">Узел раздела XML.</param>
		/// <returns>Объект конфигурации.</returns>
		// Token: 0x06000BA3 RID: 2979 RVA: 0x000314B4 File Offset: 0x0002F6B4
		public object Create(object parent, object context, XmlNode section)
		{
			return ConfigHelper.GetNameValueCollection(parent as NameValueCollection, section, this.KeyAttributeName, this.ValueAttributeName);
		}

		/// <summary>Возвращает имя атрибута XML для использования ключа в паре ключ-значение.</summary>
		/// <returns>Значение <see cref="T:System.String" /> содержит имя атрибута ключа.</returns>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000311EF File Offset: 0x0002F3EF
		protected virtual string KeyAttributeName
		{
			get
			{
				return "key";
			}
		}

		/// <summary>Возвращает имя атрибута XML для использования в качестве значения в паре ключ-значение.</summary>
		/// <returns>Значение <see cref="T:System.String" /> содержит имя атрибута значения.</returns>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000311F6 File Offset: 0x0002F3F6
		protected virtual string ValueAttributeName
		{
			get
			{
				return "value";
			}
		}
	}
}
