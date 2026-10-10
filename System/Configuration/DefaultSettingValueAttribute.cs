using System;

namespace System.Configuration
{
	/// <summary>Определяет значение по умолчанию для свойства параметров приложения.</summary>
	// Token: 0x020001AD RID: 429
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DefaultSettingValueAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Configuration.DefaultSettingValueAttribute" />.</summary>
		/// <param name="value">
		///   <see cref="T:System.String" />, представляющий значение по умолчанию для этого свойства.</param>
		// Token: 0x06000B72 RID: 2930 RVA: 0x000311BE File Offset: 0x0002F3BE
		public DefaultSettingValueAttribute(string value)
		{
			this.value = value;
		}

		/// <summary>Возвращает значение по умолчанию для свойства параметров приложения.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, представляющий значение по умолчанию для этого свойства.</returns>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x000311CD File Offset: 0x0002F3CD
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0400077F RID: 1919
		private string value;
	}
}
