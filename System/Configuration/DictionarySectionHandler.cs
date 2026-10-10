using System;
using System.Collections;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Предоставляет сведения о парах ключ-значение конфигурации из раздела конфигурации.</summary>
	// Token: 0x020001AE RID: 430
	public class DictionarySectionHandler : IConfigurationSectionHandler
	{
		/// <summary>Создает новый обработчик конфигурации и добавляет его к коллекции обработчика раздела на основе указанных параметров.</summary>
		/// <param name="parent">Родительский объект.</param>
		/// <param name="context">Объект контекста конфигурации.</param>
		/// <param name="section">Узел раздела XML.</param>
		/// <returns>Объект конфигурации.</returns>
		// Token: 0x06000B74 RID: 2932 RVA: 0x000311D5 File Offset: 0x0002F3D5
		public virtual object Create(object parent, object context, XmlNode section)
		{
			return ConfigHelper.GetDictionary(parent as IDictionary, section, this.KeyAttributeName, this.ValueAttributeName);
		}

		/// <summary>Возвращает имя атрибута XML для использования ключа в паре ключ-значение.</summary>
		/// <returns>Строковое значение, содержащее имя ключевого атрибута.</returns>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x000311EF File Offset: 0x0002F3EF
		protected virtual string KeyAttributeName
		{
			get
			{
				return "key";
			}
		}

		/// <summary>Возвращает имя атрибута XML для использования в качестве значения в паре ключ-значение.</summary>
		/// <returns>Строковое значение, содержащее имя атрибута значения.</returns>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x000311F6 File Offset: 0x0002F3F6
		protected virtual string ValueAttributeName
		{
			get
			{
				return "value";
			}
		}
	}
}
