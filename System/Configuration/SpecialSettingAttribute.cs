using System;

namespace System.Configuration
{
	/// <summary>Указывает на то, что свойство параметров приложения имеет специальное значение. Этот класс не наследуется.</summary>
	// Token: 0x020001DB RID: 475
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SpecialSettingAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SpecialSettingAttribute" />.</summary>
		/// <param name="specialSetting">Значение перечисления <see cref="T:System.Configuration.SpecialSetting" />, определяющее категорию свойства параметров приложения.</param>
		// Token: 0x06000C5A RID: 3162 RVA: 0x000327D9 File Offset: 0x000309D9
		public SpecialSettingAttribute(SpecialSetting specialSetting)
		{
			this.setting = specialSetting;
		}

		/// <summary>Возвращает значение, описывающее специальную категорию параметров приложения.</summary>
		/// <returns>Значение перечисления <see cref="T:System.Configuration.SpecialSetting" />, определяющее категорию свойства параметров приложения.</returns>
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000327E8 File Offset: 0x000309E8
		public SpecialSetting SpecialSetting
		{
			get
			{
				return this.setting;
			}
		}

		// Token: 0x040007BC RID: 1980
		private SpecialSetting setting;
	}
}
