using System;

namespace System.Configuration
{
	/// <summary>Детально инструктирует платформу .NET Framework проводить проверки длинного целого числа в свойстве конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000053 RID: 83
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class LongValidatorAttribute : ConfigurationValidatorAttribute
	{
		/// <summary>Получает или задает значение, определяющее, включать или исключать целые числа в диапазон, определенный значениями свойств <see cref="P:System.Configuration.LongValidatorAttribute.MinValue" /> и <see cref="P:System.Configuration.LongValidatorAttribute.MaxValue" />.</summary>
		/// <returns>
		///   <see langword="true" />, если значение должно быть исключено; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000860F File Offset: 0x0000680F
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00008617 File Offset: 0x00006817
		public bool ExcludeRange
		{
			get
			{
				return this.excludeRange;
			}
			set
			{
				this.excludeRange = value;
				this.instance = null;
			}
		}

		/// <summary>Возвращает или задает максимальное значение, допустимое для свойства.</summary>
		/// <returns>Длинное целое число, определяющее допустимое максимальное значение.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Выбранное значение меньше <see cref="P:System.Configuration.LongValidatorAttribute.MinValue" />.</exception>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00008627 File Offset: 0x00006827
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000862F File Offset: 0x0000682F
		public long MaxValue
		{
			get
			{
				return this.maxValue;
			}
			set
			{
				this.maxValue = value;
				this.instance = null;
			}
		}

		/// <summary>Возвращает или задает минимальное значение, допустимое для свойства.</summary>
		/// <returns>Целое число, определяющее допустимое минимальное значение.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Выбранное значение больше <see cref="P:System.Configuration.LongValidatorAttribute.MaxValue" />.</exception>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000863F File Offset: 0x0000683F
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00008647 File Offset: 0x00006847
		public long MinValue
		{
			get
			{
				return this.minValue;
			}
			set
			{
				this.minValue = value;
				this.instance = null;
			}
		}

		/// <summary>Возвращает экземпляр класса <see cref="T:System.Configuration.LongValidator" />.</summary>
		/// <returns>Проверяющий экземпляр <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00008657 File Offset: 0x00006857
		public override ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				if (this.instance == null)
				{
					this.instance = new LongValidator(this.minValue, this.maxValue, this.excludeRange);
				}
				return this.instance;
			}
		}

		// Token: 0x04000107 RID: 263
		private bool excludeRange;

		// Token: 0x04000108 RID: 264
		private long maxValue;

		// Token: 0x04000109 RID: 265
		private long minValue;

		// Token: 0x0400010A RID: 266
		private ConfigurationValidatorBase instance;
	}
}
