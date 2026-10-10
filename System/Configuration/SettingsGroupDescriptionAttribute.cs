using System;

namespace System.Configuration
{
	/// <summary>Предоставляет строку, которая описывает группу свойств параметров. Этот класс не наследуется.</summary>
	// Token: 0x020001C6 RID: 454
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SettingsGroupDescriptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsGroupDescriptionAttribute" />.</summary>
		/// <param name="description">
		///   <see cref="T:System.String" />, содержащий описательный текст для группы параметров приложения.</param>
		// Token: 0x06000BED RID: 3053 RVA: 0x00031E13 File Offset: 0x00030013
		public SettingsGroupDescriptionAttribute(string description)
		{
			this.desc = description;
		}

		/// <summary>Описательный текст для группы свойств параметров приложения.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий описательный текст для группы параметров приложения.</returns>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00031E22 File Offset: 0x00030022
		public string Description
		{
			get
			{
				return this.desc;
			}
		}

		// Token: 0x04000797 RID: 1943
		private string desc;
	}
}
