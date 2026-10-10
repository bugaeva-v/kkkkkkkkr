using System;

namespace System.Configuration
{
	/// <summary>Выполняет проверку объекта <see cref="T:System.TimeSpan" />.</summary>
	// Token: 0x02000072 RID: 114
	public class TimeSpanValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.TimeSpanValidator" /> на основе предоставленных параметров.</summary>
		/// <param name="minValue">Объект <see cref="T:System.TimeSpan" />, указывающий минимально допустимое время для прохождения проверки.</param>
		/// <param name="maxValue">Объект <see cref="T:System.TimeSpan" />, указывающий максимально допустимое время для прохождения проверки.</param>
		// Token: 0x060003CB RID: 971 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue) : this(minValue, maxValue, false, 0L)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.TimeSpanValidator" /> на основе предоставленных параметров.</summary>
		/// <param name="minValue">Объект <see cref="T:System.TimeSpan" />, указывающий минимально допустимое время для прохождения проверки.</param>
		/// <param name="maxValue">Объект <see cref="T:System.TimeSpan" />, указывающий максимально допустимое время для прохождения проверки.</param>
		/// <param name="rangeIsExclusive">Значение <see cref="T:System.Boolean" />, указывающее, является ли диапазон проверки эксклюзивным.</param>
		// Token: 0x060003CC RID: 972 RVA: 0x0000ABF2 File Offset: 0x00008DF2
		public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue, bool rangeIsExclusive) : this(minValue, maxValue, rangeIsExclusive, 0L)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.TimeSpanValidator" /> на основе предоставленных параметров.</summary>
		/// <param name="minValue">Объект <see cref="T:System.TimeSpan" />, указывающий минимально допустимое время для прохождения проверки.</param>
		/// <param name="maxValue">Объект <see cref="T:System.TimeSpan" />, указывающий максимально допустимое время для прохождения проверки.</param>
		/// <param name="rangeIsExclusive">Значение <see cref="T:System.Boolean" />, указывающее, является ли диапазон проверки эксклюзивным.</param>
		/// <param name="resolutionInSeconds">Значение <see cref="T:System.Int64" />, указывающее количество секунд.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="resolutionInSeconds" /> меньше <see langword="0" />.  
		/// -или- 
		///  Значение <paramref name="minValue" /> больше значения <paramref name="maxValue" />.</exception>
		// Token: 0x060003CD RID: 973 RVA: 0x0000ABFF File Offset: 0x00008DFF
		public TimeSpanValidator(TimeSpan minValue, TimeSpan maxValue, bool rangeIsExclusive, long resolutionInSeconds)
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.rangeIsExclusive = rangeIsExclusive;
			this.resolutionInSeconds = resolutionInSeconds;
		}

		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="type" /> соответствует значению <see cref="T:System.TimeSpan" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060003CE RID: 974 RVA: 0x000087A7 File Offset: 0x000069A7
		public override bool CanValidate(Type type)
		{
			return type == typeof(TimeSpan);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		// Token: 0x060003CF RID: 975 RVA: 0x0000AC24 File Offset: 0x00008E24
		public override void Validate(object value)
		{
			TimeSpan t = (TimeSpan)value;
			if (!this.rangeIsExclusive)
			{
				if (t < this.minValue || t > this.maxValue)
				{
					throw new ArgumentException("The value must be in the range " + this.minValue.ToString() + " - " + this.maxValue.ToString());
				}
			}
			else if (t >= this.minValue && t <= this.maxValue)
			{
				throw new ArgumentException("The value must not be in the range " + this.minValue.ToString() + " - " + this.maxValue.ToString());
			}
			if (this.resolutionInSeconds != 0L && t.Ticks % (10000000L * this.resolutionInSeconds) != 0L)
			{
				throw new ArgumentException("The value must have a resolution of " + TimeSpan.FromTicks(10000000L * this.resolutionInSeconds).ToString());
			}
		}

		// Token: 0x04000156 RID: 342
		private bool rangeIsExclusive;

		// Token: 0x04000157 RID: 343
		private TimeSpan minValue;

		// Token: 0x04000158 RID: 344
		private TimeSpan maxValue;

		// Token: 0x04000159 RID: 345
		private long resolutionInSeconds;
	}
}
