using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет сведения о типе для модуля проверки подлинности. Этот класс не наследуется.</summary>
	// Token: 0x0200075B RID: 1883
	public sealed class AuthenticationModuleElement : ConfigurationElement
	{
		// Token: 0x06003B64 RID: 15204 RVA: 0x000CC37A File Offset: 0x000CA57A
		static AuthenticationModuleElement()
		{
			AuthenticationModuleElement.properties = new ConfigurationPropertyCollection();
			AuthenticationModuleElement.properties.Add(AuthenticationModuleElement.typeProp);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.AuthenticationModuleElement" />.</summary>
		// Token: 0x06003B65 RID: 15205 RVA: 0x00031238 File Offset: 0x0002F438
		public AuthenticationModuleElement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> с указанными сведениями о типе.</summary>
		/// <param name="typeName">Строка, определяющая тип и сборку, которая его содержит.</param>
		// Token: 0x06003B66 RID: 15206 RVA: 0x000CC3B0 File Offset: 0x000CA5B0
		public AuthenticationModuleElement(string typeName)
		{
			this.Type = typeName;
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x000CC3BF File Offset: 0x000CA5BF
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return AuthenticationModuleElement.properties;
			}
		}

		/// <summary>Возвращает или задает сведения о типе и сборке для текущего экземпляра.</summary>
		/// <returns>Строка, определяющая тип, реализующий модуль проверки подлинности, или значение <see langword="null" />, если значение не задано.</returns>
		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x000CC3C6 File Offset: 0x000CA5C6
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x000CC3D8 File Offset: 0x000CA5D8
		[ConfigurationProperty("type", Options = (ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey))]
		public string Type
		{
			get
			{
				return (string)base[AuthenticationModuleElement.typeProp];
			}
			set
			{
				base[AuthenticationModuleElement.typeProp] = value;
			}
		}

		// Token: 0x0400237A RID: 9082
		private static ConfigurationPropertyCollection properties;

		// Token: 0x0400237B RID: 9083
		private static ConfigurationProperty typeProp = new ConfigurationProperty("type", typeof(string), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
	}
}
