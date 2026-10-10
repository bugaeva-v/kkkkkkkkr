using System;

namespace System.Configuration
{
	/// <summary>Выполняет проверку значения <see cref="T:System.Int64" />.</summary>
	// Token: 0x02000052 RID: 82
	public class LongValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.LongValidator" />.</summary>
		/// <param name="minValue">Значение <see cref="T:System.Int64" />, указывающее минимальную длину значения <see langword="long" />.</param>
		/// <param name="maxValue">Значение <see cref="T:System.Int64" />, указывающее максимальную длину значения <see langword="long" />.</param>
		/// <param name="rangeIsExclusive">Значение <see cref="T:System.Boolean" />, указывающее, является ли диапазон проверки эксклюзивным.</param>
		/// <param name="resolution">Значение <see cref="T:System.Int64" />, указывающее определенное значение для соответствия.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="resolution" /> равно или меньше <see langword="0" />.  
		/// -или- 
		///  Значение <paramref name="maxValue" /> меньше <paramref name="minValue" />.</exception>
		// Token: 0x060002C0 RID: 704 RVA: 0x000084F9 File Offset: 0x000066F9
		public LongValidator(long minValue, long maxValue, bool rangeIsExclusive, long resolution)
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.rangeIsExclusive = rangeIsExclusive;
			this.resolution = resolution;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.LongValidator" />.</summary>
		/// <param name="minValue">Значение <see cref="T:System.Int64" />, указывающее минимальную длину значения <see langword="long" />.</param>
		/// <param name="maxValue">Значение <see cref="T:System.Int64" />, указывающее максимальную длину значения <see langword="long" />.</param>
		/// <param name="rangeIsExclusive">Значение <see cref="T:System.Boolean" />, указывающее, является ли диапазон проверки эксклюзивным.</param>
		// Token: 0x060002C1 RID: 705 RVA: 0x0000851E File Offset: 0x0000671E
		public LongValidator(long minValue, long maxValue, bool rangeIsExclusive) : this(minValue, maxValue, rangeIsExclusive, 0L)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.LongValidator" />.</summary>
		/// <param name="minValue">Значение <see cref="T:System.Int64" />, указывающее минимальную длину значения <see langword="long" />.</param>
		/// <param name="maxValue">Значение <see cref="T:System.Int64" />, указывающее максимальную длину значения <see langword="long" />.</param>
		// Token: 0x060002C2 RID: 706 RVA: 0x0000852B File Offset: 0x0000672B
		public LongValidator(long minValue, long maxValue) : this(minValue, maxValue, false, 0L)
		{
		}

		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="type" /> соответствует значению <see cref="T:System.Int64" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060002C3 RID: 707 RVA: 0x00008538 File Offset: 0x00006738
		public override bool CanValidate(Type type)
		{
			return type == typeof(long);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		// Token: 0x060002C4 RID: 708 RVA: 0x0000854C File Offset: 0x0000674C
		public override void Validate(object value)
		{
			long num = (long)value;
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
			if (this.resolution != 0L && num % this.resolution != 0L)
			{
				throw new ArgumentException("The value must have a resolution of " + this.resolution.ToString());
			}
		}

		// Token: 0x04000103 RID: 259
		private bool rangeIsExclusive;

		// Token: 0x04000104 RID: 260
		private long minValue;

		// Token: 0x04000105 RID: 261
		private long maxValue;

		// Token: 0x04000106 RID: 262
		private long resolution;
	}
}
