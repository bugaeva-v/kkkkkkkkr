using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет сведения о типе для пользовательского модуля <see cref="T:System.Net.IWebProxy" />. Этот класс не наследуется.</summary>
	// Token: 0x0200076D RID: 1901
	public sealed class ModuleElement : ConfigurationElement
	{
		// Token: 0x06003BED RID: 15341 RVA: 0x000CD385 File Offset: 0x000CB585
		static ModuleElement()
		{
			ModuleElement.properties = new ConfigurationPropertyCollection();
			ModuleElement.properties.Add(ModuleElement.typeProp);
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x000CD3BA File Offset: 0x000CB5BA
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ModuleElement.properties;
			}
		}

		/// <summary>Возвращает или задает сведения о типе и сборке для текущего экземпляра.</summary>
		/// <returns>Строка, определяющая тип, реализующий интерфейс <see cref="T:System.Net.IWebProxy" />, или <see langword="null" />, если значение не задано.</returns>
		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x000CD3C1 File Offset: 0x000CB5C1
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x000CD3D3 File Offset: 0x000CB5D3
		[ConfigurationProperty("type")]
		public string Type
		{
			get
			{
				return (string)base[ModuleElement.typeProp];
			}
			set
			{
				base[ModuleElement.typeProp] = value;
			}
		}

		// Token: 0x0400239B RID: 9115
		private static ConfigurationPropertyCollection properties;

		// Token: 0x0400239C RID: 9116
		private static ConfigurationProperty typeProp = new ConfigurationProperty("type", typeof(string), null);
	}
}
