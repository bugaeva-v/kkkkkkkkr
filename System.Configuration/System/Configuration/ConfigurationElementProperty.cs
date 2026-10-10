using System;

namespace System.Configuration
{
	/// <summary>Указывает свойство элемента конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x0200001F RID: 31
	public sealed class ConfigurationElementProperty
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationElementProperty" />, используя предоставленный параметр.</summary>
		/// <param name="validator">Объект <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="validator" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600010E RID: 270 RVA: 0x00005518 File Offset: 0x00003718
		public ConfigurationElementProperty(ConfigurationValidatorBase validator)
		{
			this.validator = validator;
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.ConfigurationValidatorBase" />, использовавшийся для проверки объекта <see cref="T:System.Configuration.ConfigurationElementProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00005527 File Offset: 0x00003727
		public ConfigurationValidatorBase Validator
		{
			get
			{
				return this.validator;
			}
		}

		// Token: 0x04000085 RID: 133
		private ConfigurationValidatorBase validator;
	}
}
