using System;
using System.Collections;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию пар ключ/значение, используемых для описания объекта конфигурации как объект <see cref="T:System.Configuration.SettingsProperty" />.</summary>
	// Token: 0x020001C2 RID: 450
	[Serializable]
	public class SettingsAttributeDictionary : Hashtable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsAttributeDictionary" />.</summary>
		// Token: 0x06000BD8 RID: 3032 RVA: 0x00031A39 File Offset: 0x0002FC39
		public SettingsAttributeDictionary()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsAttributeDictionary" />.</summary>
		/// <param name="attributes">Коллекция пар "ключ-значение", относящихся к параметрам конфигурации.</param>
		// Token: 0x06000BD9 RID: 3033 RVA: 0x00031A41 File Offset: 0x0002FC41
		public SettingsAttributeDictionary(SettingsAttributeDictionary attributes) : base(attributes)
		{
		}
	}
}
