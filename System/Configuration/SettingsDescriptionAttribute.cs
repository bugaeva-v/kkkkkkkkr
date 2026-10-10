using System;

namespace System.Configuration
{
	/// <summary>Предоставляет строку, описывающую индивидуальное свойство конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x020001C5 RID: 453
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsDescriptionAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Configuration.SettingsDescriptionAttribute" />.</summary>
		/// <param name="description">
		///   <see cref="T:System.String" /> используется в качестве описательного текста.</param>
		// Token: 0x06000BEB RID: 3051 RVA: 0x00031DFC File Offset: 0x0002FFFC
		public SettingsDescriptionAttribute(string description)
		{
			this.desc = description;
		}

		/// <summary>Возвращает описательный текст для связанного свойства конфигурации.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий описательный текст для связанного свойства конфигурации.</returns>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00031E0B File Offset: 0x0003000B
		public string Description
		{
			get
			{
				return this.desc;
			}
		}

		// Token: 0x04000796 RID: 1942
		private string desc;
	}
}
