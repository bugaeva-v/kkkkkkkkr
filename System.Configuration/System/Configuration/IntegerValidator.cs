using System;

namespace System.Configuration
{
	/// <summary>Выполняет проверку значения <see cref="T:System.Int32" />.</summary>
	// Token: 0x02000047 RID: 71
	public class IntegerValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.IntegerValidator" />.</summary>
		/// <param name="minValue">Объект <see cref="T:System.Int32" />, указывающий минимальную длину значения целого числа.</param>
		/// <param name="maxValue">Объект <see cref="T:System.Int32" />, указывающий максимальную длину значения целого числа.</param>
		/// <param name="rangeIsExclusive">Значение <see cref="T:System.Boolean" />, указывающее, является ли диапазон проверки эксклюзивным.</param>
		/// <param name="resolution">Объект <see cref="T:System.Int32" />, указывающий значение для соответствия.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="resolution" /> меньше <see langword="0" />.  
		/// -или- 
		///  Значение <paramref name="minValue" /> больше значения <paramref name="maxValue" />.</exception>
		// Token: 0x06000253 RID: 595 RVA: 0x00007B42 File Offset: 0x00005D42
		public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive, int resolution)
		{
			if (minValue != 0)
			{
				this.minValue = minValue;
			}
			if (maxValue != 0)
			{
				this.maxValue = maxValue;
			}
			this.rangeIsExclusive = rangeIsExclusive;
			this.resolution = resolution;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.IntegerValidator" />.</summary>
		/// <param name="minValue">Объект <see cref="T:System.Int32" />, который указывает минимальное значение.</param>
		/// <param name="maxValue">Объект <see cref="T:System.Int32" />, который указывает максимальное значение.</param>
		/// <param name="rangeIsExclusive">Значение <see langword="true" /> указывает, что диапазон проверки является эксклюзивным. Инклюзивность означает, что проверяемое значение должно находиться в указанном диапазоне; эксклюзивность означает, что оно должно быть ниже нижней границы или выше верхней границы.</param>
		// Token: 0x06000254 RID: 596 RVA: 0x00007B78 File Offset: 0x00005D78
		public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive) : this(minValue, maxValue, rangeIsExclusive, 0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.IntegerValidator" />.</summary>
		/// <param name="minValue">Объект <see cref="T:System.Int32" />, который указывает минимальное значение.</param>
		/// <param name="maxValue">Объект <see cref="T:System.Int32" />, который указывает максимальное значение.</param>
		// Token: 0x06000255 RID: 597 RVA: 0x00007B84 File Offset: 0x00005D84
		public IntegerValidator(int minValue, int maxValue) : this(minValue, maxValue, false, 0)
		{
		}

		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="type" /> соответствует значению <see cref="T:System.Int32" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000256 RID: 598 RVA: 0x00007B90 File Offset: 0x00005D90
		public override bool CanValidate(Type type)
		{
			return type == typeof(int);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение, подлежащий проверке.</param>
		// Token: 0x06000257 RID: 599 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public override void Validate(object value)
		{
			int num = (int)value;
			if (!this.rangeIsExclusive)
			{
				if (num < this.minValue || num > this.maxValue)
				{
					throw new ArgumentException("The value must be in the range " + this.minValue.ToString() + " - " + this.maxValue.ToString());
				}
			}
			else if (num >= this.minValue && num <= this.maxValue)
			{
				throw new ArgumentException("The value must not be in the range " + this.minValue.ToString() + " - " + this.maxValue.ToString());
			}
			if (this.resolution != 0 && num % this.resolution != 0)
			{
				throw new ArgumentException("The value must have a resolution of " + this.resolution.ToString());
			}
		}

		// Token: 0x040000ED RID: 237
		private bool rangeIsExclusive;

		// Token: 0x040000EE RID: 238
		private int minValue;

		// Token: 0x040000EF RID: 239
		private int maxValue = int.MaxValue;

		// Token: 0x040000F0 RID: 240
		private int resolution;
	}
}
