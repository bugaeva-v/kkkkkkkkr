using System;

namespace System.Configuration
{
	/// <summary>Элемент конфигурации, содержащий имя <see cref="T:System.String" /> и значение <see cref="T:System.String" />. Этот класс не наследуется.</summary>
	// Token: 0x02000055 RID: 85
	public sealed class NameValueConfigurationElement : ConfigurationElement
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x000086DC File Offset: 0x000068DC
		static NameValueConfigurationElement()
		{
			NameValueConfigurationElement._properties.Add(NameValueConfigurationElement._propName);
			NameValueConfigurationElement._properties.Add(NameValueConfigurationElement._propValue);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.NameValueConfigurationElement" /> на основе предоставленных параметров.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</param>
		/// <param name="value">Значение объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</param>
		// Token: 0x060002DA RID: 730 RVA: 0x0000874E File Offset: 0x0000694E
		public NameValueConfigurationElement(string name, string value)
		{
			base[NameValueConfigurationElement._propName] = name;
			base[NameValueConfigurationElement._propValue] = value;
		}

		/// <summary>Возвращает имя объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</summary>
		/// <returns>Имя объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000876E File Offset: 0x0000696E
		[ConfigurationProperty("name", DefaultValue = "", Options = ConfigurationPropertyOptions.IsKey)]
		public string Name
		{
			get
			{
				return (string)base[NameValueConfigurationElement._propName];
			}
		}

		/// <summary>Возвращает или задает значение объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</summary>
		/// <returns>Значение объекта <see cref="T:System.Configuration.NameValueConfigurationElement" />.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00008780 File Offset: 0x00006980
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00008792 File Offset: 0x00006992
		[ConfigurationProperty("value", DefaultValue = "", Options = ConfigurationPropertyOptions.None)]
		public string Value
		{
			get
			{
				return (string)base[NameValueConfigurationElement._propValue];
			}
			set
			{
				base[NameValueConfigurationElement._propValue] = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000087A0 File Offset: 0x000069A0
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return NameValueConfigurationElement._properties;
			}
		}

		// Token: 0x0400010C RID: 268
		private static ConfigurationPropertyCollection _properties = new ConfigurationPropertyCollection();

		// Token: 0x0400010D RID: 269
		private static readonly ConfigurationProperty _propName = new ConfigurationProperty("name", typeof(string), "", ConfigurationPropertyOptions.IsKey);

		// Token: 0x0400010E RID: 270
		private static readonly ConfigurationProperty _propValue = new ConfigurationProperty("value", typeof(string), "");
	}
}
