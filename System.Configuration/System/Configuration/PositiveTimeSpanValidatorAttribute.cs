using System;

namespace System.Configuration
{
	/// <summary>Подробно инструктирует платформу .NET Framework как проверять временные показатели свойства конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000057 RID: 87
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class PositiveTimeSpanValidatorAttribute : ConfigurationValidatorAttribute
	{
		/// <summary>Возвращает экземпляр класса <see cref="T:System.Configuration.PositiveTimeSpanValidator" />.</summary>
		/// <returns>Проверяющий экземпляр <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000087DA File Offset: 0x000069DA
		public override ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				if (this.instance == null)
				{
					this.instance = new PositiveTimeSpanValidator();
				}
				return this.instance;
			}
		}

		// Token: 0x0400010F RID: 271
		private ConfigurationValidatorBase instance;
	}
}
