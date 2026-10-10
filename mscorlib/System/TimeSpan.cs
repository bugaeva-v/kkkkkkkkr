using System;
using System.Globalization;

namespace System
{
	/// <summary>Представляет интервал времени.</summary>
	// Token: 0x02000192 RID: 402
	[Serializable]
	public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.TimeSpan" /> заданным числом тактов.</summary>
		/// <param name="ticks">Интервал времени, выраженный в единицах измерения, равных 100 нс.</param>
		// Token: 0x06000FCF RID: 4047 RVA: 0x00041A3B File Offset: 0x0003FC3B
		public TimeSpan(long ticks)
		{
			this._ticks = ticks;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.TimeSpan" /> заданным количеством часов, минут и секунд.</summary>
		/// <param name="hours">Количество часов.</param>
		/// <param name="minutes">Количество минут.</param>
		/// <param name="seconds">Количество секунд.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры указывают значение <see cref="T:System.TimeSpan" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00041A44 File Offset: 0x0003FC44
		public TimeSpan(int hours, int minutes, int seconds)
		{
			this._ticks = TimeSpan.TimeToTicks(hours, minutes, seconds);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.TimeSpan" /> заданным количеством дней, часов, минут и секунд.</summary>
		/// <param name="days">Количество дней.</param>
		/// <param name="hours">Количество часов.</param>
		/// <param name="minutes">Количество минут.</param>
		/// <param name="seconds">Количество секунд.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры указывают значение <see cref="T:System.TimeSpan" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06000FD1 RID: 4049 RVA: 0x00041A54 File Offset: 0x0003FC54
		public TimeSpan(int days, int hours, int minutes, int seconds)
		{
			this = new TimeSpan(days, hours, minutes, seconds, 0);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.TimeSpan" /> заданным количеством дней, часов, минут, секунд и миллисекунд.</summary>
		/// <param name="days">Количество дней.</param>
		/// <param name="hours">Количество часов.</param>
		/// <param name="minutes">Количество минут.</param>
		/// <param name="seconds">Количество секунд.</param>
		/// <param name="milliseconds">Количество миллисекунд.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры указывают значение <see cref="T:System.TimeSpan" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00041A64 File Offset: 0x0003FC64
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			long num = ((long)days * 3600L * 24L + (long)hours * 3600L + (long)minutes * 60L + (long)seconds) * 1000L + (long)milliseconds;
			if (num > 922337203685477L || num < -922337203685477L)
			{
				throw new ArgumentOutOfRangeException(null, "TimeSpan overflowed because the duration is too long.");
			}
			this._ticks = num * 10000L;
		}

		/// <summary>Возвращает количество тактов, представляющее значение текущей структуры <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Количество тактов, содержащихся в этом экземпляре.</returns>
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00041AD1 File Offset: 0x0003FCD1
		public long Ticks
		{
			get
			{
				return this._ticks;
			}
		}

		/// <summary>Возвращает компонент дней периода времени, представленного текущей структурой <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Компонент дня данного экземпляра. Возвращаемое значение может быть положительным или отрицательным.</returns>
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00041AD9 File Offset: 0x0003FCD9
		public int Days
		{
			get
			{
				return (int)(this._ticks / 864000000000L);
			}
		}

		/// <summary>Возвращает компонент часов периода времени, представленного текущей структурой <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Компонент текущей структуры <see cref="T:System.TimeSpan" />, представляющий количество часов. Возвращаемое значение лежит в диапазоне от -23 до 23.</returns>
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00041AEC File Offset: 0x0003FCEC
		public int Hours
		{
			get
			{
				return (int)(this._ticks / 36000000000L % 24L);
			}
		}

		/// <summary>Возвращает компонент миллисекунд периода времени, представленного текущей структурой <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Компонент текущей структуры <see cref="T:System.TimeSpan" />, представляющий количество миллисекунд. Возвращаемое значение лежит в диапазоне от -999 до 999.</returns>
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00041B03 File Offset: 0x0003FD03
		public int Milliseconds
		{
			get
			{
				return (int)(this._ticks / 10000L % 1000L);
			}
		}

		/// <summary>Возвращает компонент минут периода времени, представленного текущей структурой <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Компонент текущей структуры <see cref="T:System.TimeSpan" />, представляющий количество минут. Возвращаемое значение лежит в диапазоне от -59 до 59.</returns>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00041B1A File Offset: 0x0003FD1A
		public int Minutes
		{
			get
			{
				return (int)(this._ticks / 600000000L % 60L);
			}
		}

		/// <summary>Возвращает компонент секунд периода времени, представленного текущей структурой <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Компонент текущей структуры <see cref="T:System.TimeSpan" />, представляющий количество секунд. Возвращаемое значение лежит в диапазоне от -59 до 59.</returns>
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00041B2E File Offset: 0x0003FD2E
		public int Seconds
		{
			get
			{
				return (int)(this._ticks / 10000000L % 60L);
			}
		}

		/// <summary>Возвращает значение текущей структуры <see cref="T:System.TimeSpan" />, выраженное как целое и дробное количество дней.</summary>
		/// <returns>Общее количество дней в периоде, представленном этим экземпляром.</returns>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00041B42 File Offset: 0x0003FD42
		public double TotalDays
		{
			get
			{
				return (double)this._ticks * 1.1574074074074074E-12;
			}
		}

		/// <summary>Получает значение текущей структуры <see cref="T:System.TimeSpan" />, выраженное как целое и дробное количество часов.</summary>
		/// <returns>Общее количество часов в периоде, представленном этим экземпляром.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00041B55 File Offset: 0x0003FD55
		public double TotalHours
		{
			get
			{
				return (double)this._ticks * 2.7777777777777777E-11;
			}
		}

		/// <summary>Получает значение текущей структуры <see cref="T:System.TimeSpan" />, выраженное как целое и дробное количество миллисекунд.</summary>
		/// <returns>Общее количество миллисекунд в периоде, представленном этим экземпляром.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00041B68 File Offset: 0x0003FD68
		public double TotalMilliseconds
		{
			get
			{
				double num = (double)this._ticks * 0.0001;
				if (num > 922337203685477.0)
				{
					return 922337203685477.0;
				}
				if (num < -922337203685477.0)
				{
					return -922337203685477.0;
				}
				return num;
			}
		}

		/// <summary>Возвращает значение текущей структуры <see cref="T:System.TimeSpan" />, выраженное как целое и дробное количество минут.</summary>
		/// <returns>Общее количество минут в периоде, представленном этим экземпляром.</returns>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00041BB4 File Offset: 0x0003FDB4
		public double TotalMinutes
		{
			get
			{
				return (double)this._ticks * 1.6666666666666667E-09;
			}
		}

		/// <summary>Возвращает значение текущей структуры <see cref="T:System.TimeSpan" />, выраженное как целое и дробное количество секунд.</summary>
		/// <returns>Общее количество секунд в периоде, представленном этим экземпляром.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00041BC7 File Offset: 0x0003FDC7
		public double TotalSeconds
		{
			get
			{
				return (double)this._ticks * 1E-07;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.TimeSpan" />, значение которого равно сумме указанного объекта <see cref="T:System.TimeSpan" /> и данного экземпляра.</summary>
		/// <param name="ts">Добавляемый интервал времени.</param>
		/// <returns>Новый объект, представляющий сумму значений данного экземпляра и параметра <paramref name="ts" />.</returns>
		/// <exception cref="T:System.OverflowException">Итоговое значение <see cref="T:System.TimeSpan" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06000FDE RID: 4062 RVA: 0x00041BDC File Offset: 0x0003FDDC
		public TimeSpan Add(TimeSpan ts)
		{
			long num = this._ticks + ts._ticks;
			if (this._ticks >> 63 == ts._ticks >> 63 && this._ticks >> 63 != num >> 63)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan(num);
		}

		/// <summary>Сравнивает два значения <see cref="T:System.TimeSpan" /> и возвращает целое значение, которое показывает, является ли первое значение короче, равно или длиннее второго значения.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Одно из следующих значений.  
		///   Значение 
		///   Описание 
		///   -1 
		///  Значение параметра <paramref name="t1" /> короче значения параметра <paramref name="t2" />.  
		///
		///   0 
		///  <paramref name="t1" /> равно <paramref name="t2" />.  
		///
		///   1 
		///  Значение параметра <paramref name="t1" /> длиннее значения параметра <paramref name="t2" />.</returns>
		// Token: 0x06000FDF RID: 4063 RVA: 0x00041C2B File Offset: 0x0003FE2B
		public static int Compare(TimeSpan t1, TimeSpan t2)
		{
			if (t1._ticks > t2._ticks)
			{
				return 1;
			}
			if (t1._ticks < t2._ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом и возвращает целое число, которое показывает, как соотносится данный экземпляр с указанным объектом: короче него, равен ему или длиннее указанного объекта.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Одно из следующих значений.  
		///   Значение 
		///   Описание 
		///   -1 
		///   Этот экземпляр короче параметра <paramref name="value" />.  
		///
		///   0 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   1 
		///   Этот экземпляр длиннее параметра <paramref name="value" />.  
		///
		/// -или- 
		///  <paramref name="value" /> — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.TimeSpan" />.</exception>
		// Token: 0x06000FE0 RID: 4064 RVA: 0x00041C50 File Offset: 0x0003FE50
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is TimeSpan))
			{
				throw new ArgumentException("Object must be of type TimeSpan.");
			}
			long ticks = ((TimeSpan)value)._ticks;
			if (this._ticks > ticks)
			{
				return 1;
			}
			if (this._ticks < ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом <see cref="T:System.TimeSpan" /> и возвращает целое число, которое показывает, как соотносится данный экземпляр с объектом <see cref="T:System.TimeSpan" />: короче него, равен ему или длиннее указанного объекта.</summary>
		/// <param name="value">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Значение 
		///   Описание 
		///   Отрицательное целое число 
		///   Этот экземпляр короче параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Положительное целое число 
		///   Этот экземпляр длиннее параметра <paramref name="value" />.</returns>
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00041C98 File Offset: 0x0003FE98
		public int CompareTo(TimeSpan value)
		{
			long ticks = value._ticks;
			if (this._ticks > ticks)
			{
				return 1;
			}
			if (this._ticks < ticks)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий заданное количество дней, округленное до ближайшей миллисекунды.</summary>
		/// <param name="value">Количество дней, округленное до ближайшей миллисекунды.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.PositiveInfinity" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00041CC3 File Offset: 0x0003FEC3
		public static TimeSpan FromDays(double value)
		{
			return TimeSpan.Interval(value, 86400000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.TimeSpan" />, значением которого является абсолютное значение текущего объекта <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>Новый объект, значением которого является абсолютное значение текущего объекта <see cref="T:System.TimeSpan" />.</returns>
		/// <exception cref="T:System.OverflowException">Этот экземпляр имеет значение <see cref="F:System.TimeSpan.MinValue" />.</exception>
		// Token: 0x06000FE3 RID: 4067 RVA: 0x00041CD0 File Offset: 0x0003FED0
		public TimeSpan Duration()
		{
			if (this.Ticks == TimeSpan.MinValue.Ticks)
			{
				throw new OverflowException("The duration cannot be returned for TimeSpan.MinValue because the absolute value of TimeSpan.MinValue exceeds the value of TimeSpan.MaxValue.");
			}
			return new TimeSpan((this._ticks >= 0L) ? this._ticks : (-this._ticks));
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="value">Объект для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является объектом <see cref="T:System.TimeSpan" /> и представляет тот же интервал времени, что и текущий объект <see cref="T:System.TimeSpan" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000FE4 RID: 4068 RVA: 0x00041D0D File Offset: 0x0003FF0D
		public override bool Equals(object value)
		{
			return value is TimeSpan && this._ticks == ((TimeSpan)value)._ticks;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр заданному объекту <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> представляет то т же интервал времени, что и данный экземпляр; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000FE5 RID: 4069 RVA: 0x00041D2C File Offset: 0x0003FF2C
		public bool Equals(TimeSpan obj)
		{
			return this._ticks == obj._ticks;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два заданных экземпляра <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="t1" /> и <paramref name="t2" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000FE6 RID: 4070 RVA: 0x00041D2C File Offset: 0x0003FF2C
		public static bool Equals(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks == t2._ticks;
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00041D3C File Offset: 0x0003FF3C
		public override int GetHashCode()
		{
			return (int)this._ticks ^ (int)(this._ticks >> 32);
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий указанное количество часов, округленное до ближайшей миллисекунды.</summary>
		/// <param name="value">Количество часов, округленное до ближайшей миллисекунды.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.PositiveInfinity" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000FE8 RID: 4072 RVA: 0x00041D50 File Offset: 0x0003FF50
		public static TimeSpan FromHours(double value)
		{
			return TimeSpan.Interval(value, 3600000);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00041D60 File Offset: 0x0003FF60
		private static TimeSpan Interval(double value, int scale)
		{
			if (double.IsNaN(value))
			{
				throw new ArgumentException("TimeSpan does not accept floating point Not-a-Number values.");
			}
			double num = value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5);
			if (num > 922337203685477.0 || num < -922337203685477.0)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan((long)num * 10000L);
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий указанное количество миллисекунд.</summary>
		/// <param name="value">Количество миллисекунд.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.PositiveInfinity" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000FEA RID: 4074 RVA: 0x00041DD7 File Offset: 0x0003FFD7
		public static TimeSpan FromMilliseconds(double value)
		{
			return TimeSpan.Interval(value, 1);
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий указанное количество минут, округленное до ближайшей миллисекунды.</summary>
		/// <param name="value">Количество минут, округленное до ближайшей миллисекунды.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.PositiveInfinity" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000FEB RID: 4075 RVA: 0x00041DE0 File Offset: 0x0003FFE0
		public static TimeSpan FromMinutes(double value)
		{
			return TimeSpan.Interval(value, 60000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.TimeSpan" />, значение которого равно значению данного экземпляра с противоположным знаком.</summary>
		/// <returns>Новый объект, числовое значение которого совпадает со значением данного экземпляра, но с противоположным знаком.</returns>
		/// <exception cref="T:System.OverflowException">Инвертированное значение этого экземпляра не может быть представлено <see cref="T:System.TimeSpan" />, т. е. этот экземпляр имеет значение <see cref="F:System.TimeSpan.MinValue" />.</exception>
		// Token: 0x06000FEC RID: 4076 RVA: 0x00041DED File Offset: 0x0003FFED
		public TimeSpan Negate()
		{
			if (this.Ticks == TimeSpan.MinValue.Ticks)
			{
				throw new OverflowException("Negating the minimum value of a twos complement number is invalid.");
			}
			return new TimeSpan(-this._ticks);
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий указанное количество секунд, округленное до ближайшей миллисекунды.</summary>
		/// <param name="value">Количество секунд, округленное до ближайшей миллисекунды.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">Значение <paramref name="value" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.PositiveInfinity" />.  
		/// -или- 
		///  <paramref name="value" /> — <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> равно <see cref="F:System.Double.NaN" />.</exception>
		// Token: 0x06000FED RID: 4077 RVA: 0x00041E18 File Offset: 0x00040018
		public static TimeSpan FromSeconds(double value)
		{
			return TimeSpan.Interval(value, 1000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.TimeSpan" />, значение которого равно разности между указанным объектом <see cref="T:System.TimeSpan" /> и данным экземпляром.</summary>
		/// <param name="ts">Интервал времени, который будет вычтен.</param>
		/// <returns>Новый интервал времени, значение которого является результатом вычитания значения параметра <paramref name="ts" /> из данного экземпляра.</returns>
		/// <exception cref="T:System.OverflowException">Возвращаемое значение меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06000FEE RID: 4078 RVA: 0x00041E28 File Offset: 0x00040028
		public TimeSpan Subtract(TimeSpan ts)
		{
			long num = this._ticks - ts._ticks;
			if (this._ticks >> 63 != ts._ticks >> 63 && this._ticks >> 63 != num >> 63)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return new TimeSpan(num);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00041E77 File Offset: 0x00040077
		public TimeSpan Multiply(double factor)
		{
			return this * factor;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00041E85 File Offset: 0x00040085
		public TimeSpan Divide(double divisor)
		{
			return this / divisor;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00041E93 File Offset: 0x00040093
		public double Divide(TimeSpan ts)
		{
			return this / ts;
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" />, представляющий заданное время в тактах.</summary>
		/// <param name="value">Количество тактов, представляющее время.</param>
		/// <returns>Объект, представляющий объект <paramref name="value" />.</returns>
		// Token: 0x06000FF2 RID: 4082 RVA: 0x00041EA1 File Offset: 0x000400A1
		public static TimeSpan FromTicks(long value)
		{
			return new TimeSpan(value);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00041EAC File Offset: 0x000400AC
		internal static long TimeToTicks(int hour, int minute, int second)
		{
			long num = (long)hour * 3600L + (long)minute * 60L + (long)second;
			if (num > 922337203685L || num < -922337203685L)
			{
				throw new ArgumentOutOfRangeException(null, "TimeSpan overflowed because the duration is too long.");
			}
			return num * 10000000L;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00041EF9 File Offset: 0x000400F9
		private static void ValidateStyles(TimeSpanStyles style, string parameterName)
		{
			if (style != TimeSpanStyles.None && style != TimeSpanStyles.AssumeNegative)
			{
				throw new ArgumentException("An undefined TimeSpanStyles value is being used.", parameterName);
			}
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="s">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Как минимум один из компонентов дней, часов, минут или секунд выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00041F0E File Offset: 0x0004010E
		public static TimeSpan Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.Parse(s, null);
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="input" />, в виде, заданном параметром <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="input" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Хотя бы один из компонентов дней, часов, минут или секунд в <paramref name="input" /> выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FF6 RID: 4086 RVA: 0x00041F26 File Offset: 0x00040126
		public static TimeSpan Parse(string input, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.Parse(input, formatProvider);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00041F3E File Offset: 0x0004013E
		public static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider = null)
		{
			return TimeSpanParse.Parse(input, formatProvider);
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные формат и сведения о форматировании, связанные с языком и региональными параметрами. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="format">Стандартная или пользовательская строка формата, которая определяет требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="input" />, в виде, заданном параметрами <paramref name="format" /> и <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="input" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Хотя бы один из компонентов дней, часов, минут или секунд в <paramref name="input" /> выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FF8 RID: 4088 RVA: 0x00041F47 File Offset: 0x00040147
		public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return TimeSpanParse.ParseExact(input, format, formatProvider, TimeSpanStyles.None);
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанный массив строк форматирования и сведения о форматировании, связанные с языком и региональными параметрами. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formats">Массив стандартных или пользовательских строк формата, которые определяют требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="input" />, в виде, заданном параметрами <paramref name="formats" /> и <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="input" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Хотя бы один из компонентов дней, часов, минут или секунд в <paramref name="input" /> выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FF9 RID: 4089 RVA: 0x00041F70 File Offset: 0x00040170
		public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None);
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные формат, сведения о форматировании, связанные с языком и региональными параметрами, и стили. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="format">Стандартная или пользовательская строка формата, которая определяет требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <param name="styles">Побитовое сочетание значений перечисления, определяющее элементы стиля, которые могут присутствовать в параметре <paramref name="input" />.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="input" />, в виде, заданном параметрами <paramref name="format" />, <paramref name="formatProvider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="styles" /> имеет недопустимое значение <see cref="T:System.Globalization.TimeSpanStyles" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="input" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Хотя бы один из компонентов дней, часов, минут или секунд в <paramref name="input" /> выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FFA RID: 4090 RVA: 0x00041F8A File Offset: 0x0004018A
		public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00041FBE File Offset: 0x000401BE
		public static TimeSpan ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
		}

		/// <summary>Преобразует строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные форматы, сведения о форматировании, связанные с языком и региональными параметрами, и стили. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formats">Массив стандартных или пользовательских строк формата, которые определяют требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <param name="styles">Побитовое сочетание значений перечисления, определяющее элементы стиля, которые могут присутствовать в параметре input.</param>
		/// <returns>Интервал времени, соответствующий параметру <paramref name="input" />, в виде, заданном параметрами <paramref name="formats" />, <paramref name="formatProvider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="styles" /> имеет недопустимое значение <see cref="T:System.Globalization.TimeSpanStyles" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="input" /> представляет число меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.  
		/// -или- 
		/// Хотя бы один из компонентов дней, часов, минут или секунд в <paramref name="input" /> выходит за пределы допустимого диапазона.</exception>
		// Token: 0x06000FFC RID: 4092 RVA: 0x00041FD4 File Offset: 0x000401D4
		public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00041FF9 File Offset: 0x000401F9
		public static TimeSpan ParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
		}

		/// <summary>Преобразовывает строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" /> и возвращает значение, позволяющее определить успешность преобразования.</summary>
		/// <param name="s">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="s" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />. Эта операция возвращает значение <see langword="false" />, если параметр <paramref name="s" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />, либо его формат недопустим, либо он представляет интервал времени, меньший <see cref="F:System.TimeSpan.MinValue" /> или больший <see cref="F:System.TimeSpan.MaxValue" />, либо минимум один из его компонентов — количество дней, часов, минут или секунд — находится вне допустимого диапазона.</returns>
		// Token: 0x06000FFE RID: 4094 RVA: 0x0004200F File Offset: 0x0004020F
		public static bool TryParse(string s, out TimeSpan result)
		{
			if (s == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParse(s, null, out result);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004202A File Offset: 0x0004022A
		public static bool TryParse(ReadOnlySpan<char> s, out TimeSpan result)
		{
			return TimeSpanParse.TryParse(s, null, out result);
		}

		/// <summary>Преобразовывает заданное строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанную информацию о форматировании, связанную с языком и региональными параметрами, и возвращает значение, которое показывает успешность преобразования.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="input" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />. Эта операция возвращает значение <see langword="false" />, если параметр <paramref name="input" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />, либо его формат недопустим, либо он представляет интервал времени, меньший <see cref="F:System.TimeSpan.MinValue" /> или больший <see cref="F:System.TimeSpan.MaxValue" />, либо минимум один из его компонентов — количество дней, часов, минут или секунд — находится вне допустимого диапазона.</returns>
		// Token: 0x06001000 RID: 4096 RVA: 0x00042034 File Offset: 0x00040234
		public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParse(input, formatProvider, out result);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004204F File Offset: 0x0004024F
		public static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParse(input, formatProvider, out result);
		}

		/// <summary>Преобразовывает заданное строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанный формат и информацию о форматировании, связанную с языком и региональными параметрами, и возвращает значение, которое показывает успешность преобразования. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="format">Стандартная или пользовательская строка формата, которая определяет требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="input" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001002 RID: 4098 RVA: 0x00042059 File Offset: 0x00040259
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null || format == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004207E File Offset: 0x0004027E
		public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
		}

		/// <summary>Преобразовывает заданное строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные форматы и информацию о форматировании, связанную с языком и региональными параметрами, и возвращает значение, которое показывает успешность преобразования. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formats">Массив стандартных или пользовательских строк формата, которые определяют допустимые форматы параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="input" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001004 RID: 4100 RVA: 0x0004208A File Offset: 0x0004028A
		public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000420A7 File Offset: 0x000402A7
		public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
		}

		/// <summary>Преобразовывает заданное строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанный формат, информацию о форматировании, связанную с языком и региональными параметрами, и стили, и возвращает значение, которое показывает успешность преобразования. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="format">Стандартная или пользовательская строка формата, которая определяет требуемый формат параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании, связанные с языком и региональными параметрами.</param>
		/// <param name="styles">Одно или несколько перечислимых значений, указывающих стиль параметра <paramref name="input" />.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="input" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001006 RID: 4102 RVA: 0x000420B3 File Offset: 0x000402B3
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			if (input == null || format == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000420E5 File Offset: 0x000402E5
		public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
		}

		/// <summary>Преобразовывает заданное строковое представление интервала времени в его эквивалент <see cref="T:System.TimeSpan" />, используя указанные форматы, информацию о форматировании, связанную с языком и региональными параметрами, и стили, и возвращает значение, которое показывает успешность преобразования. Формат строкового представления должен полностью соответствовать одному из заданных форматов.</summary>
		/// <param name="input">Строка, которая указывает преобразуемый интервал времени.</param>
		/// <param name="formats">Массив стандартных или пользовательских строк формата, которые определяют допустимые форматы параметра <paramref name="input" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <param name="styles">Одно или несколько перечислимых значений, указывающих стиль параметра <paramref name="input" />.</param>
		/// <param name="result">После возврата из этого метода содержит объект, представляющий интервал времени, заданный в параметре <paramref name="input" />, или значение <see cref="F:System.TimeSpan.Zero" />, если преобразование завершилось неудачей. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="input" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001008 RID: 4104 RVA: 0x000420FD File Offset: 0x000402FD
		public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00042127 File Offset: 0x00040327
		public static bool TryParseExact(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles, "styles");
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.TimeSpan" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.TimeSpan" />.</returns>
		// Token: 0x0600100A RID: 4106 RVA: 0x0004213F File Offset: 0x0004033F
		public override string ToString()
		{
			return TimeSpanFormat.Format(this, null, null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.TimeSpan" /> в эквивалентное ему строковое представление с использованием заданного формата.</summary>
		/// <param name="format">Стандартная или пользовательская строка формата <see cref="T:System.TimeSpan" />.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.TimeSpan" /> в формате, заданном параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не распознается или не поддерживается.</exception>
		// Token: 0x0600100B RID: 4107 RVA: 0x0004214E File Offset: 0x0004034E
		public string ToString(string format)
		{
			return TimeSpanFormat.Format(this, format, null);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.TimeSpan" /> в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Стандартная или пользовательская строка формата <see cref="T:System.TimeSpan" />.</param>
		/// <param name="formatProvider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего значения <see cref="T:System.TimeSpan" /> в виде, заданном параметрами <paramref name="format" /> и <paramref name="formatProvider" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не распознается или не поддерживается.</exception>
		// Token: 0x0600100C RID: 4108 RVA: 0x0004215D File Offset: 0x0004035D
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return TimeSpanFormat.Format(this, format, formatProvider);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004216C File Offset: 0x0004036C
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
		{
			return TimeSpanFormat.TryFormat(this, destination, out charsWritten, format, formatProvider);
		}

		/// <summary>Возвращает объект <see cref="T:System.TimeSpan" /> со значением, равным значению данного экземпляра с противоположным знаком.</summary>
		/// <param name="t">Интервал времени, у которого будет изменен знак.</param>
		/// <returns>Объект, числовое значение которого совпадает со значением данного экземпляра, но с противоположным знаком.</returns>
		/// <exception cref="T:System.OverflowException">Инвертированное значение этого экземпляра не может быть представлено <see cref="T:System.TimeSpan" />, т. е. этот экземпляр имеет значение <see cref="F:System.TimeSpan.MinValue" />.</exception>
		// Token: 0x0600100E RID: 4110 RVA: 0x0004217E File Offset: 0x0004037E
		public static TimeSpan operator -(TimeSpan t)
		{
			if (t._ticks == TimeSpan.MinValue._ticks)
			{
				throw new OverflowException("Negating the minimum value of a twos complement number is invalid.");
			}
			return new TimeSpan(-t._ticks);
		}

		/// <summary>Вычитает указанный объект <see cref="T:System.TimeSpan" /> из другого указанного объекта <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Уменьшаемое.</param>
		/// <param name="t2">Вычитаемое.</param>
		/// <returns>Объект, значение которого является разностью значений <paramref name="t1" /> и <paramref name="t2" />.</returns>
		/// <exception cref="T:System.OverflowException">Возвращаемое значение меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x0600100F RID: 4111 RVA: 0x000421A9 File Offset: 0x000403A9
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			return t1.Subtract(t2);
		}

		/// <summary>Возвращает указанный экземпляр <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t">Возвращаемый интервал времени.</param>
		/// <returns>Интервал времени, который задается параметром <paramref name="t" />.</returns>
		// Token: 0x06001010 RID: 4112 RVA: 0x0000270D File Offset: 0x0000090D
		public static TimeSpan operator +(TimeSpan t)
		{
			return t;
		}

		/// <summary>Складывает два указанных экземпляра <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из добавляемых интервалов времени.</param>
		/// <param name="t2">Второй из добавляемых интервалов времени.</param>
		/// <returns>Объект, значение которого является суммой значений <paramref name="t1" /> и <paramref name="t2" />.</returns>
		/// <exception cref="T:System.OverflowException">Итоговое значение <see cref="T:System.TimeSpan" /> меньше <see cref="F:System.TimeSpan.MinValue" /> или больше <see cref="F:System.TimeSpan.MaxValue" />.</exception>
		// Token: 0x06001011 RID: 4113 RVA: 0x000421B3 File Offset: 0x000403B3
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			return t1.Add(t2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000421C0 File Offset: 0x000403C0
		public static TimeSpan operator *(TimeSpan timeSpan, double factor)
		{
			if (double.IsNaN(factor))
			{
				throw new ArgumentException("TimeSpan does not accept floating point Not-a-Number values.", "factor");
			}
			double num = Math.Round((double)timeSpan.Ticks * factor);
			if (num > 9.223372036854776E+18 | num < -9.223372036854776E+18)
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return TimeSpan.FromTicks((long)num);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00042222 File Offset: 0x00040422
		public static TimeSpan operator *(double factor, TimeSpan timeSpan)
		{
			return timeSpan * factor;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0004222C File Offset: 0x0004042C
		public static TimeSpan operator /(TimeSpan timeSpan, double divisor)
		{
			if (double.IsNaN(divisor))
			{
				throw new ArgumentException("TimeSpan does not accept floating point Not-a-Number values.", "divisor");
			}
			double num = Math.Round((double)timeSpan.Ticks / divisor);
			if ((num > 9.223372036854776E+18 | num < -9.223372036854776E+18) || double.IsNaN(num))
			{
				throw new OverflowException("TimeSpan overflowed because the duration is too long.");
			}
			return TimeSpan.FromTicks((long)num);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00042296 File Offset: 0x00040496
		public static double operator /(TimeSpan t1, TimeSpan t2)
		{
			return (double)t1.Ticks / (double)t2.Ticks;
		}

		/// <summary>Указывает, равны ли два экземпляра <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="t1" /> и <paramref name="t2" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001016 RID: 4118 RVA: 0x00041D2C File Offset: 0x0003FF2C
		public static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks == t2._ticks;
		}

		/// <summary>Показывает, являются ли два экземпляра <see cref="T:System.TimeSpan" /> неравными.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значения <paramref name="t1" /> и <paramref name="t2" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001017 RID: 4119 RVA: 0x000422A9 File Offset: 0x000404A9
		public static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks != t2._ticks;
		}

		/// <summary>Показывает, является ли заданное значение <see cref="T:System.TimeSpan" /> меньшим, чем другое заданное значение <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> меньше <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001018 RID: 4120 RVA: 0x000422BC File Offset: 0x000404BC
		public static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks < t2._ticks;
		}

		/// <summary>Показывает, является ли заданное значение <see cref="T:System.TimeSpan" /> меньшим или равным другому заданному значению <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> меньше или равно <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001019 RID: 4121 RVA: 0x000422CC File Offset: 0x000404CC
		public static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks <= t2._ticks;
		}

		/// <summary>Показывает, является ли заданное значение <see cref="T:System.TimeSpan" /> большим, чем другое заданное значение <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> больше <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600101A RID: 4122 RVA: 0x000422DF File Offset: 0x000404DF
		public static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks > t2._ticks;
		}

		/// <summary>Показывает, является ли заданное значение <see cref="T:System.TimeSpan" /> большим или равным другому заданному значению <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="t1">Первый из сравниваемых интервалов времени.</param>
		/// <param name="t2">Второй из сравниваемых интервалов времени.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> больше или равно <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600101B RID: 4123 RVA: 0x000422EF File Offset: 0x000404EF
		public static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks >= t2._ticks;
		}

		/// <summary>Возвращает количество тактов в 1 миллисекунде. Это поле является константой.</summary>
		// Token: 0x04001300 RID: 4864
		public const long TicksPerMillisecond = 10000L;

		// Token: 0x04001301 RID: 4865
		private const double MillisecondsPerTick = 0.0001;

		/// <summary>Возвращает количество тактов в 1 секунде.</summary>
		// Token: 0x04001302 RID: 4866
		public const long TicksPerSecond = 10000000L;

		// Token: 0x04001303 RID: 4867
		private const double SecondsPerTick = 1E-07;

		/// <summary>Возвращает количество тактов в 1 минуте. Это поле является константой.</summary>
		// Token: 0x04001304 RID: 4868
		public const long TicksPerMinute = 600000000L;

		// Token: 0x04001305 RID: 4869
		private const double MinutesPerTick = 1.6666666666666667E-09;

		/// <summary>Представляет количество тактов в 1 часе. Это поле является константой.</summary>
		// Token: 0x04001306 RID: 4870
		public const long TicksPerHour = 36000000000L;

		// Token: 0x04001307 RID: 4871
		private const double HoursPerTick = 2.7777777777777777E-11;

		/// <summary>Возвращает количество тактов в 1 сутках. Это поле является константой.</summary>
		// Token: 0x04001308 RID: 4872
		public const long TicksPerDay = 864000000000L;

		// Token: 0x04001309 RID: 4873
		private const double DaysPerTick = 1.1574074074074074E-12;

		// Token: 0x0400130A RID: 4874
		private const int MillisPerSecond = 1000;

		// Token: 0x0400130B RID: 4875
		private const int MillisPerMinute = 60000;

		// Token: 0x0400130C RID: 4876
		private const int MillisPerHour = 3600000;

		// Token: 0x0400130D RID: 4877
		private const int MillisPerDay = 86400000;

		// Token: 0x0400130E RID: 4878
		internal const long MaxSeconds = 922337203685L;

		// Token: 0x0400130F RID: 4879
		internal const long MinSeconds = -922337203685L;

		// Token: 0x04001310 RID: 4880
		internal const long MaxMilliSeconds = 922337203685477L;

		// Token: 0x04001311 RID: 4881
		internal const long MinMilliSeconds = -922337203685477L;

		// Token: 0x04001312 RID: 4882
		internal const long TicksPerTenthSecond = 1000000L;

		/// <summary>Представляет нулевое значение <see cref="T:System.TimeSpan" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04001313 RID: 4883
		public static readonly TimeSpan Zero = new TimeSpan(0L);

		/// <summary>Представляет максимальное значение <see cref="T:System.TimeSpan" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04001314 RID: 4884
		public static readonly TimeSpan MaxValue = new TimeSpan(long.MaxValue);

		/// <summary>Представляет минимальное значение <see cref="T:System.TimeSpan" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04001315 RID: 4885
		public static readonly TimeSpan MinValue = new TimeSpan(long.MinValue);

		// Token: 0x04001316 RID: 4886
		internal readonly long _ticks;
	}
}
