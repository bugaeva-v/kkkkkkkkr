using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Представляет текущее время, обычно выраженное как дата и время суток.</summary>
	// Token: 0x0200010C RID: 268
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданным числом тактов.</summary>
		/// <param name="ticks">Дата и время, представленные в виде нескольких 100-наносекундных интервалов, завершившихся с момента 00:00:00.000 1 января 0001 г. по григорианскому календарю.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="ticks" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009A7 RID: 2471 RVA: 0x0002593B File Offset: 0x00023B3B
		public DateTime(long ticks)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			this._dateData = (ulong)ticks;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00025965 File Offset: 0x00023B65
		private DateTime(ulong dateData)
		{
			this._dateData = dateData;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданным числом тактов и временем UTC или местным временем.</summary>
		/// <param name="ticks">Дата и время, представленные в виде нескольких 100-наносекундных интервалов, завершившихся с момента 00:00:00.000 1 января 0001 г. по григорианскому календарю.</param>
		/// <param name="kind">Одно из значений перечисления, указывающее, какое время задает параметр <paramref name="ticks" />: локальное, универсальное глобальное (UTC) или ни то, ни другое.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="ticks" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="kind" /> не является одним из значений <see cref="T:System.DateTimeKind" />.</exception>
		// Token: 0x060009A9 RID: 2473 RVA: 0x00025970 File Offset: 0x00023B70
		public DateTime(long ticks, DateTimeKind kind)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			this._dateData = (ulong)(ticks | (long)kind << 62);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000259C4 File Offset: 0x00023BC4
		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			if (ticks < 0L || ticks > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", "Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
			this._dateData = (ulong)(ticks | (isAmbiguousDst ? -4611686018427387904L : long.MinValue));
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданными значениями года, месяца и дня.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.  
		///
		/// или - 
		/// Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		///
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.</exception>
		// Token: 0x060009AB RID: 2475 RVA: 0x00025A11 File Offset: 0x00023C11
		public DateTime(int year, int month, int day)
		{
			this._dateData = (ulong)DateTime.DateToTicks(year, month, day);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданным годом, месяцем и днем для указанного календаря.</summary>
		/// <param name="year">Год (от 1 до количества лет в <paramref name="calendar" />).</param>
		/// <param name="month">Месяц (от 1 до количества месяцев в <paramref name="calendar" />).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="calendar">Календарь, используемый для анализа параметров <paramref name="year" />, <paramref name="month" /> и <paramref name="day" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="calendar" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> не входит в диапазон, поддерживаемый <paramref name="calendar" />.  
		///
		/// или - 
		/// <paramref name="month" /> меньше 1 или больше числа месяцев в <paramref name="calendar" />.  
		///
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.</exception>
		// Token: 0x060009AC RID: 2476 RVA: 0x00025A21 File Offset: 0x00023C21
		public DateTime(int year, int month, int day, Calendar calendar)
		{
			this = new DateTime(year, month, day, 0, 0, 0, calendar);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданным годом, месяцем, днем, часом, минутой и секундой.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.  
		///
		/// или - 
		/// Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		///
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.</exception>
		// Token: 0x060009AD RID: 2477 RVA: 0x00025A31 File Offset: 0x00023C31
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			this._dateData = (ulong)(DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second));
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданными значениями года, месяца, дня, часа, минуты и секунды, а также временем UTC или местным временем.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="kind">Одно из значений перечисления, указывающее, что задают параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" /> и <paramref name="second" />: локальное время, универсальное глобальное время (UTC), или ни то, ни другое.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.  
		///
		/// или - 
		/// Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		///
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="second" /> имеет значение меньше 0 или больше 59.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="kind" /> не является одним из значений <see cref="T:System.DateTimeKind" />.</exception>
		// Token: 0x060009AE RID: 2478 RVA: 0x00025A50 File Offset: 0x00023C50
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			this._dateData = (ulong)(num | (long)kind << 62);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> указанным годом, месяцем, днем, часом, минутой и секундой для заданного календаря.</summary>
		/// <param name="year">Год (от 1 до количества лет в <paramref name="calendar" />).</param>
		/// <param name="month">Месяц (от 1 до количества месяцев в <paramref name="calendar" />).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="calendar">Календарь, используемый для анализа параметров <paramref name="year" />, <paramref name="month" /> и <paramref name="day" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="calendar" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> не входит в диапазон, поддерживаемый <paramref name="calendar" />.  
		/// -или- 
		///  <paramref name="month" /> меньше 1 или больше числа месяцев в <paramref name="calendar" />.  
		///
		/// или - 
		/// Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		///
		/// -или- 
		///  Параметр <paramref name="hour" /> имеет значение меньше 0 или больше 23. 
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.</exception>
		// Token: 0x060009AF RID: 2479 RVA: 0x00025A9C File Offset: 0x00023C9C
		public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar)
		{
			if (calendar == null)
			{
				throw new ArgumentNullException("calendar");
			}
			this._dateData = (ulong)calendar.ToDateTime(year, month, day, hour, minute, second, 0).Ticks;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданным годом, месяцем, днем, часом, минутой, секундой и миллисекундой.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.  
		/// -или- 
		///  Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		///
		/// или - 
		/// Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		///
		/// -или- 
		///  Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.</exception>
		// Token: 0x060009B0 RID: 2480 RVA: 0x00025AD8 File Offset: 0x00023CD8
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)num;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданными значениями года, месяца, дня, часа, минуты, секунды и миллисекунды, а также временем UTC или местным временем.</summary>
		/// <param name="year">Год (от 1 до 9999).</param>
		/// <param name="month">Месяц (от 1 до 12).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <param name="kind">Одно из значений перечисления, указывающее, что задают параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" /> и <paramref name="millisecond" />: локальное время, универсальное глобальное время (UTC), или ни то, ни другое.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.  
		/// -или- 
		///  Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="kind" /> не является одним из значений <see cref="T:System.DateTimeKind" />.</exception>
		// Token: 0x060009B1 RID: 2481 RVA: 0x00025B60 File Offset: 0x00023D60
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)(num | (long)kind << 62);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> указанным годом, месяцем, днем, часом, минутой, секундой и миллисекундой для заданного календаря.</summary>
		/// <param name="year">Год (от 1 до количества лет в <paramref name="calendar" />).</param>
		/// <param name="month">Месяц (от 1 до количества месяцев в <paramref name="calendar" />).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <param name="calendar">Календарь, используемый для анализа параметров <paramref name="year" />, <paramref name="month" /> и <paramref name="day" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="calendar" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> не входит в диапазон, поддерживаемый <paramref name="calendar" />.  
		///
		/// или - 
		/// <paramref name="month" /> меньше 1 или больше числа месяцев в <paramref name="calendar" />.  
		///
		/// или - 
		/// Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		///
		///
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		/// -или- 
		///  Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.</exception>
		// Token: 0x060009B2 RID: 2482 RVA: 0x00025C08 File Offset: 0x00023E08
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			if (calendar == null)
			{
				throw new ArgumentNullException("calendar");
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			long num = calendar.ToDateTime(year, month, day, hour, minute, second, 0).Ticks;
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)num;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.DateTime" /> заданными значениями года, месяца, дня, часа, минуты, секунды и миллисекунды, а также временем UTC или местным временем для заданного календаря.</summary>
		/// <param name="year">Год (от 1 до количества лет в <paramref name="calendar" />).</param>
		/// <param name="month">Месяц (от 1 до количества месяцев в <paramref name="calendar" />).</param>
		/// <param name="day">День (от 1 до количества дней в <paramref name="month" />).</param>
		/// <param name="hour">Часы (от 0 до 23).</param>
		/// <param name="minute">Минуты (от 0 до 59).</param>
		/// <param name="second">Секунды (от 0 до 59).</param>
		/// <param name="millisecond">Миллисекунды (от 0 до 999).</param>
		/// <param name="calendar">Календарь, используемый для анализа параметров <paramref name="year" />, <paramref name="month" /> и <paramref name="day" />.</param>
		/// <param name="kind">Одно из значений перечисления, указывающее, что задают параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" /> и <paramref name="millisecond" />: локальное время, универсальное глобальное время (UTC), или ни то, ни другое.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="calendar" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> не входит в диапазон, поддерживаемый <paramref name="calendar" />.  
		/// -или- 
		///  <paramref name="month" /> меньше 1 или больше числа месяцев в <paramref name="calendar" />.  
		/// -или- 
		///  Параметр <paramref name="day" /> имеет значение меньше 1 или больше, чем число дней в <paramref name="month" />.  
		/// -или- 
		///  Параметр <paramref name="hour" /> меньше 0 или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше 0 или больше 59.  
		///
		/// -или- 
		///  Параметр <paramref name="second" /> меньше 0 или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="millisecond" /> имеет значение меньше 0 или больше 999.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="kind" /> не является одним из значений <see cref="T:System.DateTimeKind" />.</exception>
		// Token: 0x060009B3 RID: 2483 RVA: 0x00025CA4 File Offset: 0x00023EA4
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind)
		{
			if (calendar == null)
			{
				throw new ArgumentNullException("calendar");
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", SR.Format("Valid values are between {0} and {1}, inclusive.", 0, 999));
			}
			if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
			{
				throw new ArgumentException("Invalid DateTimeKind value.", "kind");
			}
			long num = calendar.ToDateTime(year, month, day, hour, minute, second, 0).Ticks;
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("Combination of arguments to the DateTime constructor is out of the legal range.");
			}
			this._dateData = (ulong)(num | (long)kind << 62);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00025D60 File Offset: 0x00023F60
		private DateTime(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			bool flag = false;
			bool flag2 = false;
			long dateData = 0L;
			ulong dateData2 = 0UL;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (!(name == "ticks"))
				{
					if (name == "dateData")
					{
						dateData2 = Convert.ToUInt64(enumerator.Value, CultureInfo.InvariantCulture);
						flag2 = true;
					}
				}
				else
				{
					dateData = Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
					flag = true;
				}
			}
			if (flag2)
			{
				this._dateData = dateData2;
			}
			else
			{
				if (!flag)
				{
					throw new SerializationException("Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'.");
				}
				this._dateData = (ulong)dateData;
			}
			long internalTicks = this.InternalTicks;
			if (internalTicks < 0L || internalTicks > 3155378975999999999L)
			{
				throw new SerializationException("Invalid serialized DateTime data. Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.");
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00025E32 File Offset: 0x00024032
		internal long InternalTicks
		{
			get
			{
				return (long)(this._dateData & 4611686018427387903UL);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00025E44 File Offset: 0x00024044
		private ulong InternalKind
		{
			get
			{
				return this._dateData & 13835058055282163712UL;
			}
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий значение заданного объекта <see cref="T:System.TimeSpan" /> к значению данного экземпляра.</summary>
		/// <param name="value">Положительный или отрицательный интервал времени.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и интервала времени, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009B7 RID: 2487 RVA: 0x00025E56 File Offset: 0x00024056
		public DateTime Add(TimeSpan value)
		{
			return this.AddTicks(value._ticks);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00025E64 File Offset: 0x00024064
		private DateTime Add(double value, int scale)
		{
			long num = (long)(value * (double)scale + ((value >= 0.0) ? 0.5 : -0.5));
			if (num <= -315537897600000L || num >= 315537897600000L)
			{
				throw new ArgumentOutOfRangeException("value", "Value to add was out of range.");
			}
			return this.AddTicks(num * 10000L);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число дней к значению данного экземпляра.</summary>
		/// <param name="value">Число полных и неполных дней. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества дней, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009B9 RID: 2489 RVA: 0x00025ECE File Offset: 0x000240CE
		public DateTime AddDays(double value)
		{
			return this.Add(value, 86400000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число часов к значению данного экземпляра.</summary>
		/// <param name="value">Число полных и неполных часов. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества часов, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009BA RID: 2490 RVA: 0x00025EDC File Offset: 0x000240DC
		public DateTime AddHours(double value)
		{
			return this.Add(value, 3600000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число миллисекунд к значению данного экземпляра.</summary>
		/// <param name="value">Число полных и неполных миллисекунд. Параметр <paramref name="value" /> может быть положительным или отрицательным. Заметьте, что это значение округляется до ближайшего целого числа.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества миллисекунд, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009BB RID: 2491 RVA: 0x00025EEA File Offset: 0x000240EA
		public DateTime AddMilliseconds(double value)
		{
			return this.Add(value, 1);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число минут к значению данного экземпляра.</summary>
		/// <param name="value">Число полных и неполных минут. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества минут, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009BC RID: 2492 RVA: 0x00025EF4 File Offset: 0x000240F4
		public DateTime AddMinutes(double value)
		{
			return this.Add(value, 60000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число месяцев к значению данного экземпляра.</summary>
		/// <param name="months">Число месяцев. Параметр <paramref name="months" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значением которого является сумма даты и времени, представленных этим экземпляром, и значения, представленного параметром <paramref name="months" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.  
		///
		/// или - 
		/// Параметр <paramref name="months" /> имеет значение меньше –120 000 или больше 120 000.</exception>
		// Token: 0x060009BD RID: 2493 RVA: 0x00025F04 File Offset: 0x00024104
		public DateTime AddMonths(int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", "Months value must be between +/-120000.");
			}
			int num;
			int num2;
			int num3;
			this.GetDatePart(out num, out num2, out num3);
			int num4 = num2 - 1 + months;
			if (num4 >= 0)
			{
				num2 = num4 % 12 + 1;
				num += num4 / 12;
			}
			else
			{
				num2 = 12 + (num4 + 1) % 12;
				num += (num4 - 11) / 12;
			}
			if (num < 1 || num > 9999)
			{
				throw new ArgumentOutOfRangeException("months", "The added or subtracted value results in an un-representable DateTime.");
			}
			int num5 = DateTime.DaysInMonth(num, num2);
			if (num3 > num5)
			{
				num3 = num5;
			}
			return new DateTime((ulong)(DateTime.DateToTicks(num, num2, num3) + this.InternalTicks % 864000000000L | (long)this.InternalKind));
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число секунд к значению данного экземпляра.</summary>
		/// <param name="value">Число полных и неполных секунд. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества секунд, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009BE RID: 2494 RVA: 0x00025FBD File Offset: 0x000241BD
		public DateTime AddSeconds(double value)
		{
			return this.Add(value, 1000);
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число тактов к значению данного экземпляра.</summary>
		/// <param name="value">Число 100-наносекундных тактов. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и времени, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009BF RID: 2495 RVA: 0x00025FCC File Offset: 0x000241CC
		public DateTime AddTicks(long value)
		{
			long internalTicks = this.InternalTicks;
			if (value > 3155378975999999999L - internalTicks || value < 0L - internalTicks)
			{
				throw new ArgumentOutOfRangeException("value", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks + value | (long)this.InternalKind));
		}

		/// <summary>Возвращает новый объект <see cref="T:System.DateTime" />, добавляющий заданное число лет к значению данного экземпляра.</summary>
		/// <param name="value">Число лет. Параметр <paramref name="value" /> может быть положительным или отрицательным.</param>
		/// <returns>Объект, значение которого равно сумме даты и времени, представленных текущим экземпляром, и количества лет, представленного параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="value" /> или итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009C0 RID: 2496 RVA: 0x00026014 File Offset: 0x00024214
		public DateTime AddYears(int value)
		{
			if (value < -10000 || value > 10000)
			{
				throw new ArgumentOutOfRangeException("years", "Years value must be between +/-10000.");
			}
			return this.AddMonths(value * 12);
		}

		/// <summary>Сравнивает два экземпляра объекта <see cref="T:System.DateTime" /> и возвращает целое число, которое показывает, предшествует ли первый экземпляр второму, совпадает или расположен позже.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Число со знаком, обозначающее относительные значения параметров <paramref name="t1" /> и <paramref name="t2" />.  
		///   Тип значения 
		///   Условие 
		///   Меньше нуля 
		///  Момент, указанный в параметре <paramref name="t1" />, наступает раньше, чем момент, указанный в параметре <paramref name="t2" />.  
		///
		///   Нуль 
		///  Параметр <paramref name="t1" /> совпадает с параметром <paramref name="t2" />.  
		///
		///   Больше нуля 
		///  Момент, указанный в параметре <paramref name="t1" />, наступает позже, чем момент, указанный в параметре <paramref name="t2" />.</returns>
		// Token: 0x060009C1 RID: 2497 RVA: 0x00026040 File Offset: 0x00024240
		public static int Compare(DateTime t1, DateTime t2)
		{
			long internalTicks = t1.InternalTicks;
			long internalTicks2 = t2.InternalTicks;
			if (internalTicks > internalTicks2)
			{
				return 1;
			}
			if (internalTicks < internalTicks2)
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает значение данного экземпляра с заданным объектом, содержащим указанное значение <see cref="T:System.DateTime" />, и возвращает целочисленное значение, указывающее, когда наступает момент, заданный в данном экземпляре: раньше, позже или одновременно с моментом, заданным значением <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Сравниваемый упакованный объект или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Значение 
		///   Описание: 
		///   Меньше нуля 
		///   Данный экземпляр раньше <paramref name="value" />.  
		///
		///   Нуль 
		///   Данный экземпляр равен <paramref name="value" />.  
		///
		///   Больше нуля 
		///   Этот экземпляр позже <paramref name="value" />, или параметр <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.DateTime" />.</exception>
		// Token: 0x060009C2 RID: 2498 RVA: 0x0002606A File Offset: 0x0002426A
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is DateTime))
			{
				throw new ArgumentException("Object must be of type DateTime.");
			}
			return DateTime.Compare(this, (DateTime)value);
		}

		/// <summary>Сравнивает значение данного экземпляра с заданным значением <see cref="T:System.DateTime" /> и возвращает целочисленное значение, указывающее, когда наступает момент, заданный в данном экземпляре: раньше, позже или одновременно с моментом, заданным значением <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений этого экземпляра и параметра <paramref name="value" />.  
		///   Значение 
		///   Описание 
		///   Меньше нуля 
		///   Данный экземпляр раньше <paramref name="value" />.  
		///
		///   Нуль 
		///   Данный экземпляр равен <paramref name="value" />.  
		///
		///   Больше нуля 
		///   Этот экземпляр позже <paramref name="value" />.</returns>
		// Token: 0x060009C3 RID: 2499 RVA: 0x00026095 File Offset: 0x00024295
		public int CompareTo(DateTime value)
		{
			return DateTime.Compare(this, value);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000260A4 File Offset: 0x000242A4
		private static long DateToTicks(int year, int month, int day)
		{
			if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
			{
				int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
				if (day >= 1 && day <= array[month] - array[month - 1])
				{
					int num = year - 1;
					return (long)(num * 365 + num / 4 - num / 100 + num / 400 + array[month - 1] + day - 1) * 864000000000L;
				}
			}
			throw new ArgumentOutOfRangeException(null, "Year, Month, and Day parameters describe an un-representable DateTime.");
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00026128 File Offset: 0x00024328
		private static long TimeToTicks(int hour, int minute, int second)
		{
			if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
			{
				return TimeSpan.TimeToTicks(hour, minute, second);
			}
			throw new ArgumentOutOfRangeException(null, "Hour, Minute, and Second parameters describe an un-representable DateTime.");
		}

		/// <summary>Возвращает число дней в указанном месяце указанного года.</summary>
		/// <param name="year">Год.</param>
		/// <param name="month">Месяц (число в диапазоне от 1 до 12).</param>
		/// <returns>Число дней в <paramref name="month" /> для заданного <paramref name="year" />.  
		/// Например, если параметр <paramref name="month" /> равен 2 для февраля, возвращаемым значением является 28 или 29 в зависимости от того, является ли <paramref name="year" /> високосным годом.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="month" /> имеет значение меньше 1 или больше 12.  
		///
		/// или - 
		/// Параметр <paramref name="year" /> меньше 1 или больше 9999.</exception>
		// Token: 0x060009C6 RID: 2502 RVA: 0x0002615C File Offset: 0x0002435C
		public static int DaysInMonth(int year, int month)
		{
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", "Month must be between one and twelve.");
			}
			int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			return array[month] - array[month - 1];
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000261A0 File Offset: 0x000243A0
		internal static long DoubleDateToTicks(double value)
		{
			if (value >= 2958466.0 || value <= -657435.0)
			{
				throw new ArgumentException(" Not a legal OleAut date.");
			}
			long num = (long)(value * 86400000.0 + ((value >= 0.0) ? 0.5 : -0.5));
			if (num < 0L)
			{
				num -= num % 86400000L * 2L;
			}
			num += 59926435200000L;
			if (num < 0L || num >= 315537897600000L)
			{
				throw new ArgumentException("OleAut date did not convert to a DateTime correctly.");
			}
			return num * 10000L;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="value">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> является экземпляром типа <see cref="T:System.DateTime" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060009C8 RID: 2504 RVA: 0x00026244 File Offset: 0x00024444
		public override bool Equals(object value)
		{
			return value is DateTime && this.InternalTicks == ((DateTime)value).InternalTicks;
		}

		/// <summary>Возвращает значение, указывающее, равно ли значение данного экземпляра значению указанного экземпляра <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> равен значению этого экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060009C9 RID: 2505 RVA: 0x00026271 File Offset: 0x00024471
		public bool Equals(DateTime value)
		{
			return this.InternalTicks == value.InternalTicks;
		}

		/// <summary>Возвращает значение, указывающее, содержат ли два экземпляра <see cref="T:System.DateTime" /> одно и то же значение даты и времени.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если два значения равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060009CA RID: 2506 RVA: 0x00026282 File Offset: 0x00024482
		public static bool Equals(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks == t2.InternalTicks;
		}

		/// <summary>Десериализует 64-разрядное значение и воссоздает исходный сериализованный объект <see cref="T:System.DateTime" />.</summary>
		/// <param name="dateData">64-разрядное целое число со знаком, кодирующее свойство <see cref="P:System.DateTime.Kind" /> в 2-разрядное поле и свойство <see cref="P:System.DateTime.Ticks" /> в 62-разрядное поле.</param>
		/// <returns>Объект, который эквивалентен объекту <see cref="T:System.DateTime" />, сериализованному методом <see cref="M:System.DateTime.ToBinary" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="dateData" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009CB RID: 2507 RVA: 0x00026294 File Offset: 0x00024494
		public static DateTime FromBinary(long dateData)
		{
			if ((dateData & -9223372036854775808L) == 0L)
			{
				return DateTime.FromBinaryRaw(dateData);
			}
			long num = dateData & 4611686018427387903L;
			if (num > 4611685154427387904L)
			{
				num -= 4611686018427387904L;
			}
			bool isAmbiguousDst = false;
			long ticks;
			if (num < 0L)
			{
				ticks = TimeZoneInfo.GetLocalUtcOffset(DateTime.MinValue, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
			}
			else if (num > 3155378975999999999L)
			{
				ticks = TimeZoneInfo.GetLocalUtcOffset(DateTime.MaxValue, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
			}
			else
			{
				DateTime time = new DateTime(num, DateTimeKind.Utc);
				bool flag = false;
				ticks = TimeZoneInfo.GetUtcOffsetFromUtc(time, TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
			}
			num += ticks;
			if (num < 0L)
			{
				num += 864000000000L;
			}
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.", "dateData");
			}
			return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0002637C File Offset: 0x0002457C
		internal static DateTime FromBinaryRaw(long dateData)
		{
			long num = dateData & 4611686018427387903L;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentException("The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.", "dateData");
			}
			return new DateTime((ulong)dateData);
		}

		/// <summary>Преобразует заданное время файла Windows в его эквивалент по местному времени.</summary>
		/// <param name="fileTime">Временная характеристика файла Windows, выраженная в тактах.</param>
		/// <returns>Объект, представляющий местное время, эквивалентное дате и времени, которые определяются параметром <paramref name="fileTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="fileTime" /> меньше 0 или представляет время больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009CD RID: 2509 RVA: 0x000263BC File Offset: 0x000245BC
		public static DateTime FromFileTime(long fileTime)
		{
			return DateTime.FromFileTimeUtc(fileTime).ToLocalTime();
		}

		/// <summary>Преобразует заданное время файла Windows в его UTC-эквивалент.</summary>
		/// <param name="fileTime">Временная характеристика файла Windows, выраженная в тактах.</param>
		/// <returns>Объект, представляющий время в формате UTC, эквивалентное дате и времени, которые определяются параметром <paramref name="fileTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="fileTime" /> меньше 0 или представляет время больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009CE RID: 2510 RVA: 0x000263D7 File Offset: 0x000245D7
		public static DateTime FromFileTimeUtc(long fileTime)
		{
			if (fileTime < 0L || fileTime > 2650467743999999999L)
			{
				throw new ArgumentOutOfRangeException("fileTime", "Not a valid Win32 FileTime.");
			}
			return new DateTime(fileTime + 504911232000000000L, DateTimeKind.Utc);
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" />, эквивалентный заданному значению даты OLE-автоматизации.</summary>
		/// <param name="d">Значение даты OLE-автоматизации.</param>
		/// <returns>Объект, представляющий дату и время, которые совпадают с датой и временем, определяемыми параметром <paramref name="d" />.</returns>
		/// <exception cref="T:System.ArgumentException">Дата не является допустимым значением даты OLE-автоматизации.</exception>
		// Token: 0x060009CF RID: 2511 RVA: 0x0002640B File Offset: 0x0002460B
		public static DateTime FromOADate(double d)
		{
			return new DateTime(DateTime.DoubleDateToTicks(d), DateTimeKind.Unspecified);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации текущего объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Целевой объект этой сериализации. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060009D0 RID: 2512 RVA: 0x00026419 File Offset: 0x00024619
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("ticks", this.InternalTicks);
			info.AddValue("dateData", this._dateData);
		}

		/// <summary>Указывает, попадает ли данный экземпляр объекта <see cref="T:System.DateTime" /> в диапазон летнего времени для текущего часового пояса.</summary>
		/// <returns>Значение <see langword="true" />, если значение свойства <see cref="P:System.DateTime.Kind" /> — <see cref="F:System.DateTimeKind.Local" /> или <see cref="F:System.DateTimeKind.Unspecified" /> и значение этого экземпляра <see cref="T:System.DateTime" /> находится в диапазоне летнего времени для локального часового пояса; значение <see langword="false" />, если <see cref="P:System.DateTime.Kind" /> — <see cref="F:System.DateTimeKind.Utc" />.</returns>
		// Token: 0x060009D1 RID: 2513 RVA: 0x0002644B File Offset: 0x0002464B
		public bool IsDaylightSavingTime()
		{
			return this.Kind != DateTimeKind.Utc && TimeZoneInfo.Local.IsDaylightSavingTime(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		/// <summary>Создает объект <see cref="T:System.DateTime" />, имеющий то же количество тактов, что и заданный объект <see cref="T:System.DateTime" />, но предназначенный для использования с местным временем, со стандартом UTC, либо ни с тем, ни с другим, как определено значением <see cref="T:System.DateTimeKind" />.</summary>
		/// <param name="value">Дата и время.</param>
		/// <param name="kind">Одно из значений перечисления, указывающее, что представляет новый объект: локальное время, универсальное глобальное время (UTC), или ни то, ни другое.</param>
		/// <returns>Новый объект, имеющий то же количество тактов, что и объект, представленный параметром <paramref name="value" />, и значение <see cref="T:System.DateTimeKind" />, заданное параметром <paramref name="kind" />.</returns>
		// Token: 0x060009D2 RID: 2514 RVA: 0x00026469 File Offset: 0x00024669
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			return new DateTime(value.InternalTicks, kind);
		}

		/// <summary>Сериализует текущий объект <see cref="T:System.DateTime" /> в 64-разрядное двоичное значение, которое может использоваться в дальнейшем для воссоздания объекта <see cref="T:System.DateTime" />.</summary>
		/// <returns>64-разрядное целое число со знаком, кодирующее свойства <see cref="P:System.DateTime.Kind" /> и <see cref="P:System.DateTime.Ticks" />.</returns>
		// Token: 0x060009D3 RID: 2515 RVA: 0x00026478 File Offset: 0x00024678
		public long ToBinary()
		{
			if (this.Kind == DateTimeKind.Local)
			{
				TimeSpan localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				long num = this.Ticks - localUtcOffset.Ticks;
				if (num < 0L)
				{
					num = 4611686018427387904L + num;
				}
				return num | long.MinValue;
			}
			return (long)this._dateData;
		}

		/// <summary>Возвращает компоненту даты этого экземпляра.</summary>
		/// <returns>Новый объект с такой же датой, как этот экземпляр и значением времени, равным полуночи (00:00:00).</returns>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000264CD File Offset: 0x000246CD
		public DateTime Date
		{
			get
			{
				long internalTicks = this.InternalTicks;
				return new DateTime((ulong)(internalTicks - internalTicks % 864000000000L | (long)this.InternalKind));
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000264F0 File Offset: 0x000246F0
		private int GetDatePart(int part)
		{
			int i = (int)(this.InternalTicks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			if (part == 0)
			{
				return num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			}
			i -= num4 * 365;
			if (part == 1)
			{
				return i + 1;
			}
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			int num5 = (i >> 5) + 1;
			while (i >= array[num5])
			{
				num5++;
			}
			if (part == 2)
			{
				return num5;
			}
			return i - array[num5 - 1] + 1;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000265D8 File Offset: 0x000247D8
		internal void GetDatePart(out int year, out int month, out int day)
		{
			int i = (int)(this.InternalTicks / 864000000000L);
			int num = i / 146097;
			i -= num * 146097;
			int num2 = i / 36524;
			if (num2 == 4)
			{
				num2 = 3;
			}
			i -= num2 * 36524;
			int num3 = i / 1461;
			i -= num3 * 1461;
			int num4 = i / 365;
			if (num4 == 4)
			{
				num4 = 3;
			}
			year = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
			i -= num4 * 365;
			int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			int num5 = (i >> 5) + 1;
			while (i >= array[num5])
			{
				num5++;
			}
			month = num5;
			day = i - array[num5 - 1] + 1;
		}

		/// <summary>Возвращает день месяца, представленный этим экземпляром.</summary>
		/// <returns>Компонент, представляющий день, выраженный как значение от 1 до 31.</returns>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000266B2 File Offset: 0x000248B2
		public int Day
		{
			get
			{
				return this.GetDatePart(3);
			}
		}

		/// <summary>Возвращает день недели, представленный этим экземпляром.</summary>
		/// <returns>Перечислимая константа, которая указывает на день недели для этого значения <see cref="T:System.DateTime" />.</returns>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000266BB File Offset: 0x000248BB
		public DayOfWeek DayOfWeek
		{
			get
			{
				return (DayOfWeek)((this.InternalTicks / 864000000000L + 1L) % 7L);
			}
		}

		/// <summary>Возвращает день года, представленный этим экземпляром.</summary>
		/// <returns>Компонент, представляющий день года, выраженный как значение от 1 до 366.</returns>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000266D4 File Offset: 0x000248D4
		public int DayOfYear
		{
			get
			{
				return this.GetDatePart(1);
			}
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060009DA RID: 2522 RVA: 0x000266E0 File Offset: 0x000248E0
		public override int GetHashCode()
		{
			long internalTicks = this.InternalTicks;
			return (int)internalTicks ^ (int)(internalTicks >> 32);
		}

		/// <summary>Возвращает компонент часа даты, представленной этим экземпляром.</summary>
		/// <returns>Компонент, представляющий час, выраженный как значение от 0 до 23.</returns>
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000266FC File Offset: 0x000248FC
		public int Hour
		{
			get
			{
				return (int)(this.InternalTicks / 36000000000L % 24L);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00026713 File Offset: 0x00024913
		internal bool IsAmbiguousDaylightSavingTime()
		{
			return this.InternalKind == 13835058055282163712UL;
		}

		/// <summary>Возвращает значение, указывающее, на каком времени основано время, представленное этим экземпляром: местном, UTC или ни на том, ни на другом.</summary>
		/// <returns>Одно из значений перечисления, определяющее значение текущего времени. Значение по умолчанию — <see cref="F:System.DateTimeKind.Unspecified" />.</returns>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00026728 File Offset: 0x00024928
		public DateTimeKind Kind
		{
			get
			{
				ulong internalKind = this.InternalKind;
				if (internalKind == 0UL)
				{
					return DateTimeKind.Unspecified;
				}
				if (internalKind != 4611686018427387904UL)
				{
					return DateTimeKind.Local;
				}
				return DateTimeKind.Utc;
			}
		}

		/// <summary>Возвращает компонент миллисекунд для даты, представленной в данном экземпляре.</summary>
		/// <returns>Компонент, представляющий миллисекунды, выраженный как значение от 0 до 999.</returns>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00026752 File Offset: 0x00024952
		public int Millisecond
		{
			get
			{
				return (int)(this.InternalTicks / 10000L % 1000L);
			}
		}

		/// <summary>Возвращает компонент минуты даты, представленной этим экземпляром.</summary>
		/// <returns>Компонент, представляющий минуту, выраженный как значение от 0 до 59.</returns>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00026769 File Offset: 0x00024969
		public int Minute
		{
			get
			{
				return (int)(this.InternalTicks / 600000000L % 60L);
			}
		}

		/// <summary>Возвращает компонент месяца даты, представленной этим экземпляром.</summary>
		/// <returns>Компонент, представляющий месяц, выраженный как значение от 1 до 12.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002677D File Offset: 0x0002497D
		public int Month
		{
			get
			{
				return this.GetDatePart(2);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" />, которому присвоены текущие дата и время данного компьютера, выраженные как местное время.</summary>
		/// <returns>Объект, значение которого является текущим значением местной даты и времени.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00026788 File Offset: 0x00024988
		public static DateTime Now
		{
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				bool isAmbiguousDst = false;
				long ticks = TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(utcNow, out isAmbiguousDst).Ticks;
				long num = utcNow.Ticks + ticks;
				if (num > 3155378975999999999L)
				{
					return new DateTime(3155378975999999999L, DateTimeKind.Local);
				}
				if (num < 0L)
				{
					return new DateTime(0L, DateTimeKind.Local);
				}
				return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
			}
		}

		/// <summary>Возвращает компонент секунды даты, представленной этим экземпляром.</summary>
		/// <returns>Компонент, представляющий секунды, выраженный как значение от 0 до 59.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000267EB File Offset: 0x000249EB
		public int Second
		{
			get
			{
				return (int)(this.InternalTicks / 10000000L % 60L);
			}
		}

		/// <summary>Возвращает число тактов, которое представляет дату и время этого экземпляра.</summary>
		/// <returns>Число тактов, которое представляет дату и время этого экземпляра. Это значение находится в диапазоне от <see langword="DateTime.MinValue.Ticks" /> до <see langword="DateTime.MaxValue.Ticks" />.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000267FF File Offset: 0x000249FF
		public long Ticks
		{
			get
			{
				return this.InternalTicks;
			}
		}

		/// <summary>Возвращает время дня для этого экземпляра.</summary>
		/// <returns>Интервал времени, представляющий часть дня, прошедшую с полуночи.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00026807 File Offset: 0x00024A07
		public TimeSpan TimeOfDay
		{
			get
			{
				return new TimeSpan(this.InternalTicks % 864000000000L);
			}
		}

		/// <summary>Возвращает текущую дату.</summary>
		/// <returns>Объект, которому присвоена сегодняшняя дата, с компонентом времени, равным 00:00:00.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00026820 File Offset: 0x00024A20
		public static DateTime Today
		{
			get
			{
				return DateTime.Now.Date;
			}
		}

		/// <summary>Возвращает компонент года даты, представленной этим экземпляром.</summary>
		/// <returns>Значение года в диапазоне от 1 до 9999.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002683A File Offset: 0x00024A3A
		public int Year
		{
			get
			{
				return this.GetDatePart(0);
			}
		}

		/// <summary>Возвращает сведения о том, является ли указанный год високосным.</summary>
		/// <param name="year">4-значный номер года.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="year" /> является високосным годом; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> меньше 1 или больше 9999.</exception>
		// Token: 0x060009E7 RID: 2535 RVA: 0x00026843 File Offset: 0x00024A43
		public static bool IsLeapYear(int year)
		{
			if (year < 1 || year > 9999)
			{
				throw new ArgumentOutOfRangeException("year", "Year must be between 1 and 9999.");
			}
			return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		}

		/// <summary>Преобразует строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя соглашения для языка и региональных параметров текущего потока.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать. Дополнительные сведения см. в разделе Строка для анализа.</param>
		/// <returns>Объект, эквивалентный дате и времени, содержащимся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не содержит допустимое строковое представление даты и времени.</exception>
		// Token: 0x060009E8 RID: 2536 RVA: 0x0002687A File Offset: 0x00024A7A
		public static DateTime Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None);
		}

		/// <summary>Преобразует строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать. Дополнительные сведения см. в разделе Строка для анализа.</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров.  См. раздел Анализ и соглашения для языка и региональных параметров</param>
		/// <returns>Объект, эквивалентный дате и времени, которые содержатся в параметре <paramref name="s" />, определяемом параметром <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не содержит допустимое строковое представление даты и времени.</exception>
		// Token: 0x060009E9 RID: 2537 RVA: 0x00026897 File Offset: 0x00024A97
		public static DateTime Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), DateTimeStyles.None);
		}

		/// <summary>Преобразует строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя сведения о форматировании, связанные с языком и региональными параметрами, а также стиль форматирования.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать. Дополнительные сведения см. в разделе Строка для анализа.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.  См. раздел Анализ и соглашения для языка и региональных параметров</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, определяющая элементы стиля, которые могут присутствовать в параметре <paramref name="s" /> для того, чтобы операция анализа прошла успешно. Эта комбинация определяет способ интерпретации анализируемых данных с учетом текущего часового пояса или текущей даты. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, которые содержатся в параметре <paramref name="s" />, определяемом параметрами <paramref name="provider" /> и <paramref name="styles" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не содержит допустимое строковое представление даты и времени.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="styles" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" />. Например, значения <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060009EA RID: 2538 RVA: 0x000268B5 File Offset: 0x00024AB5
		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), styles);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000268DE File Offset: 0x00024ADE
		public static DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), styles);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя указанные сведения о форматировании, связанные с языком и региональными параметрами. Формат строкового представления должен полностью соответствовать заданному формату.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Описатель формата, задающий требуемый формат <paramref name="s" />. Дополнительные сведения см. в разделе "Примечания".</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров.</param>
		/// <returns>Объект, эквивалентный дате и времени, которые содержатся в параметре <paramref name="s" />, определяемом параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> или <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> или <paramref name="format" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="s" /> не содержит дату и время, соответствующие шаблону, заданному в <paramref name="format" />.  
		///
		/// или - 
		/// Компонент часов и обозначение AM/PM в <paramref name="s" /> не соответствуют друг другу.</exception>
		// Token: 0x060009EC RID: 2540 RVA: 0x000268F8 File Offset: 0x00024AF8
		public static DateTime ParseExact(string s, string format, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), DateTimeStyles.None);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя заданный формат, указанные сведения о форматировании, связанные с языком и региональными параметрами, а также стиль. Формат строкового представления должен полностью соответствовать заданному формату. В противном случае возникает исключение.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Описатель формата, задающий требуемый формат <paramref name="s" />. Дополнительные сведения см. в разделе "Примечания".</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая предоставляет дополнительную информацию о параметре <paramref name="s" />, об элементах стиля, которые могут присутствовать в параметре <paramref name="s" />, или о преобразовании из параметра <paramref name="s" /> в значение <see cref="T:System.DateTime" />. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, которые содержатся в параметре <paramref name="s" />, определяемом параметрами <paramref name="format" />, <paramref name="provider" /> и <paramref name="style" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> или <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> или <paramref name="format" /> является пустой строкой.  
		/// -или- 
		///  <paramref name="s" /> не содержит дату и время, соответствующие шаблону, заданному в <paramref name="format" />.  
		/// -или- 
		/// Компонент часов и обозначение AM/PM в <paramref name="s" /> не совпадают.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" />. Например, значения <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060009ED RID: 2541 RVA: 0x00026926 File Offset: 0x00024B26
		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002695F File Offset: 0x00024B5F
		public static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя заданный массив форматов, указанные сведения о форматировании, связанные с языком и региональными параметрами, и стиль форматирования. Формат строкового представления должен полностью соответствовать по крайней мере одному из заданных форматов. В противном случае возникает исключение.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formats">Массив разрешенных форматов <paramref name="s" />. Дополнительные сведения см. в разделе "Примечания".</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <returns>Объект, эквивалентный дате и времени, которые содержатся в параметре <paramref name="s" />, определяемом параметрами <paramref name="formats" />, <paramref name="provider" /> и <paramref name="style" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> или <paramref name="formats" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> равен пустой строке.  
		/// -или- 
		/// Элемент <paramref name="formats" /> является пустой строкой.  
		///
		/// или - 
		/// <paramref name="s" /> не содержит дату и время, соответствующие элементу <paramref name="formats" />.  
		///
		/// -или- 
		/// Компонент часов и обозначение AM/PM в <paramref name="s" /> не совпадают.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" />. Например, значения <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		// Token: 0x060009EF RID: 2543 RVA: 0x0002697A File Offset: 0x00024B7A
		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.ParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000269A4 File Offset: 0x00024BA4
		public static DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			return DateTimeParse.ParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style);
		}

		/// <summary>Вычитает из этого экземпляра указанную дату и время.</summary>
		/// <param name="value">Вычитаемые дата и время.</param>
		/// <returns>Интервал времени, равный разнице между датой и временем, представленными этим экземпляром, и датой и временем, представленными параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результат меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009F1 RID: 2545 RVA: 0x000269BF File Offset: 0x00024BBF
		public TimeSpan Subtract(DateTime value)
		{
			return new TimeSpan(this.InternalTicks - value.InternalTicks);
		}

		/// <summary>Вычитает из этого экземпляра указанную длительность.</summary>
		/// <param name="value">Вычитаемый интервал времени.</param>
		/// <returns>Объект, равный разнице между датой и временем, представленными этим экземпляром, и интервалом времени, представленным параметром <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Результат меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x060009F2 RID: 2546 RVA: 0x000269D4 File Offset: 0x00024BD4
		public DateTime Subtract(TimeSpan value)
		{
			long internalTicks = this.InternalTicks;
			long ticks = value._ticks;
			if (internalTicks < ticks || internalTicks - 3155378975999999999L > ticks)
			{
				throw new ArgumentOutOfRangeException("value", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks - ticks | (long)this.InternalKind));
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00026A20 File Offset: 0x00024C20
		private static double TicksToOADate(long value)
		{
			if (value == 0L)
			{
				return 0.0;
			}
			if (value < 864000000000L)
			{
				value += 599264352000000000L;
			}
			if (value < 31241376000000000L)
			{
				throw new OverflowException(" Not a legal OleAut date.");
			}
			long num = (value - 599264352000000000L) / 10000L;
			if (num < 0L)
			{
				long num2 = num % 86400000L;
				if (num2 != 0L)
				{
					num -= (86400000L + num2) * 2L;
				}
			}
			return (double)num / 86400000.0;
		}

		/// <summary>Преобразует числовое значение этого экземпляра в эквивалентное ему значение даты OLE-автоматизации.</summary>
		/// <returns>Число двойной точности с плавающей запятой, содержащее значение даты OLE-автоматизации, эквивалентное значению этого экземпляра.</returns>
		/// <exception cref="T:System.OverflowException">Значение этого экземпляра невозможно представить в виде даты автоматизации OLE.</exception>
		// Token: 0x060009F4 RID: 2548 RVA: 0x00026AA8 File Offset: 0x00024CA8
		public double ToOADate()
		{
			return DateTime.TicksToOADate(this.InternalTicks);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> во временную характеристику файла Windows.</summary>
		/// <returns>Значение текущего объекта <see cref="T:System.DateTime" />, представленное в виде временной характеристики файла Windows.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Получившееся время файла представит дату и время до 0:00 1 января 1601 года нашей эры в формате UTC.</exception>
		// Token: 0x060009F5 RID: 2549 RVA: 0x00026AB8 File Offset: 0x00024CB8
		public long ToFileTime()
		{
			return this.ToUniversalTime().ToFileTimeUtc();
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> во временную характеристику файла Windows.</summary>
		/// <returns>Значение текущего объекта <see cref="T:System.DateTime" />, представленное в виде временной характеристики файла Windows.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Получившееся время файла представит дату и время до 0:00 1 января 1601 года нашей эры в формате UTC.</exception>
		// Token: 0x060009F6 RID: 2550 RVA: 0x00026AD4 File Offset: 0x00024CD4
		public long ToFileTimeUtc()
		{
			long num = (((this.InternalKind & 9223372036854775808UL) != 0UL) ? this.ToUniversalTime().InternalTicks : this.InternalTicks) - 504911232000000000L;
			if (num < 0L)
			{
				throw new ArgumentOutOfRangeException(null, "Not a valid Win32 FileTime.");
			}
			return num;
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в местное время.</summary>
		/// <returns>Объект, свойство <see cref="P:System.DateTime.Kind" /> которого имеет значение <see cref="F:System.DateTimeKind.Local" />, а значение является либо местным временем, эквивалентным значению текущего объекта <see cref="T:System.DateTime" />, либо значением <see cref="F:System.DateTime.MaxValue" />, если преобразованное значение слишком велико для представления объектом <see cref="T:System.DateTime" />, либо значением <see cref="F:System.DateTime.MinValue" />, если преобразованное значение слишком мало для представления объектом <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060009F7 RID: 2551 RVA: 0x00026B24 File Offset: 0x00024D24
		public DateTime ToLocalTime()
		{
			return this.ToLocalTime(false);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00026B30 File Offset: 0x00024D30
		internal DateTime ToLocalTime(bool throwOnOverflow)
		{
			if (this.Kind == DateTimeKind.Local)
			{
				return this;
			}
			bool flag = false;
			bool isAmbiguousDst = false;
			long ticks = TimeZoneInfo.GetUtcOffsetFromUtc(this, TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
			long num = this.Ticks + ticks;
			if (num > 3155378975999999999L)
			{
				if (throwOnOverflow)
				{
					throw new ArgumentException("Specified argument was out of the range of valid values.");
				}
				return new DateTime(3155378975999999999L, DateTimeKind.Local);
			}
			else
			{
				if (num >= 0L)
				{
					return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
				}
				if (throwOnOverflow)
				{
					throw new ArgumentException("Specified argument was out of the range of valid values.");
				}
				return new DateTime(0L, DateTimeKind.Local);
			}
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему длинное строковое представление даты.</summary>
		/// <returns>Строка, содержащая длинное строковое представление даты текущего объекта <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060009F9 RID: 2553 RVA: 0x00026BC6 File Offset: 0x00024DC6
		public string ToLongDateString()
		{
			return DateTimeFormat.Format(this, "D", null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему длинное строковое представление времени.</summary>
		/// <returns>Строка, содержащая длинное строковое представление времени текущего объекта <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060009FA RID: 2554 RVA: 0x00026BD9 File Offset: 0x00024DD9
		public string ToLongTimeString()
		{
			return DateTimeFormat.Format(this, "T", null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему короткое строковое представление даты.</summary>
		/// <returns>Строка, содержащая короткое строковое представление даты текущего объекта <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060009FB RID: 2555 RVA: 0x00026BEC File Offset: 0x00024DEC
		public string ToShortDateString()
		{
			return DateTimeFormat.Format(this, "d", null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему короткое строковое представление времени.</summary>
		/// <returns>Строка, содержащая короткое строковое представление времени текущего объекта <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060009FC RID: 2556 RVA: 0x00026BFF File Offset: 0x00024DFF
		public string ToShortTimeString()
		{
			return DateTimeFormat.Format(this, "t", null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное строковое представление с помощью соглашений о форматировании для текущего языка и региональных параметров.</summary>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, принятым для текущего языка и региональных параметров.</exception>
		// Token: 0x060009FD RID: 2557 RVA: 0x00026C12 File Offset: 0x00024E12
		public override string ToString()
		{
			return DateTimeFormat.Format(this, null, null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное строковое представление с использованием указанного формата и соглашений о форматировании, принятых для текущего языка и региональных параметров.</summary>
		/// <param name="format">Строка стандартного или пользовательского формата даты и времени.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTime" />, заданное параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Длина <paramref name="format" /> равна 1, и он не является одним из символов описателя формата, определенного для <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
		/// -или- 
		///  <paramref name="format" /> не содержит допустимого шаблона пользовательского формата.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, принятым для текущего языка и региональных параметров.</exception>
		// Token: 0x060009FE RID: 2558 RVA: 0x00026C21 File Offset: 0x00024E21
		public string ToString(string format)
		{
			return DateTimeFormat.Format(this, format, null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему строковое представление с использованием указанных сведений о форматировании, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTime" />, заданное параметром <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, который используется у <paramref name="provider" />.</exception>
		// Token: 0x060009FF RID: 2559 RVA: 0x00026C30 File Offset: 0x00024E30
		public string ToString(IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, null, provider);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях формата для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка стандартного или пользовательского формата даты и времени.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.DateTime" />, заданное параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">Длина <paramref name="format" /> равна 1, и он не является одним из символов описателя формата, определенного для <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
		/// -или- 
		///  <paramref name="format" /> не содержит допустимого шаблона пользовательского формата.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Дата и время находятся за пределами диапазона дат, поддерживаемого календарем, который используется у <paramref name="provider" />.</exception>
		// Token: 0x06000A00 RID: 2560 RVA: 0x00026C3F File Offset: 0x00024E3F
		public string ToString(string format, IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, format, provider);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00026C4E File Offset: 0x00024E4E
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return DateTimeFormat.TryFormat(this, destination, out charsWritten, format, provider);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.DateTime" /> во время UTC.</summary>
		/// <returns>Объект, свойство <see cref="P:System.DateTime.Kind" /> которого имеет значение <see cref="F:System.DateTimeKind.Utc" />, а значение является либо временем в формате UTC, эквивалентным значению текущего объекта <see cref="T:System.DateTime" />, либо значением <see cref="F:System.DateTime.MaxValue" />, если преобразованное значение слишком велико для представления объектом <see cref="T:System.DateTime" />, либо значением <see cref="F:System.DateTime.MinValue" />, если преобразованное значение слишком мало для представления объектом <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06000A02 RID: 2562 RVA: 0x00026C60 File Offset: 0x00024E60
		public DateTime ToUniversalTime()
		{
			return TimeZoneInfo.ConvertTimeToUtc(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		/// <summary>Преобразовывает указанное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" /> и возвращает значение, позволяющее определить успешность преобразования.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="result">После возврата из этого метода содержит значение <see cref="T:System.DateTime" />, эквивалентное дате и времени, заданным в параметре <paramref name="s" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTime.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если значение параметра <paramref name="s" /> равно <see langword="null" /> или пустой строке ("") или не содержит допустимого строкового представления даты и времени. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A03 RID: 2563 RVA: 0x00026C6E File Offset: 0x00024E6E
		public static bool TryParse(string s, out DateTime result)
		{
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00026C8E File Offset: 0x00024E8E
		public static bool TryParse(ReadOnlySpan<char> s, out DateTime result)
		{
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя указанную информацию о форматировании, связанную с языком и региональными параметрами, и возвращает значение, которое показывает успешность преобразования.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="styles">Побитовая комбинация значений перечисления, которая определяет, как интерпретировать проанализированную дату по отношению к текущему часовому поясу или текущей дате. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <param name="result">После возврата из этого метода содержит значение <see cref="T:System.DateTime" />, эквивалентное дате и времени, заданным в параметре <paramref name="s" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTime.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если значение параметра <paramref name="s" /> равно <see langword="null" /> или пустой строке ("") или не содержит допустимого строкового представления даты и времени. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="styles" /> не является допустимым значением <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  <paramref name="styles" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" /> (например, и <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" />, и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" /> ).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="provider" /> является нейтральным языком и региональными параметрами и не может использоваться в операции анализа.</exception>
		// Token: 0x06000A05 RID: 2565 RVA: 0x00026C9D File Offset: 0x00024E9D
		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00026CC9 File Offset: 0x00024EC9
		public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(styles, "styles");
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя заданный формат, указанные сведения о форматировании, связанные с языком и региональными параметрами, а также стиль. Формат строкового представления должен полностью соответствовать заданному формату. Метод возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="format">Необходимый формат <paramref name="s" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="style">Побитовая комбинация одного или нескольких значений перечисления, которые указывают на разрешенный формат параметра <paramref name="s" />.</param>
		/// <param name="result">После возврата из этого метода содержит значение <see cref="T:System.DateTime" />, эквивалентное дате и времени, заданным в параметре <paramref name="s" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTime.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если значением параметра <paramref name="s" /> или <paramref name="format" /> является <see langword="null" /> либо пустая строка или не является дата и время, соответствующие шаблону, заданному в параметре <paramref name="format" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="styles" /> не является допустимым значением <see cref="T:System.Globalization.DateTimeStyles" />.  
		///
		/// или - 
		/// <paramref name="styles" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" /> (например, и <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" />, и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" /> ).</exception>
		// Token: 0x06000A07 RID: 2567 RVA: 0x00026CE4 File Offset: 0x00024EE4
		public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null || format == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00026D1B File Offset: 0x00024F1B
		public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		/// <summary>Преобразует заданное строковое представление даты и времени в его эквивалент <see cref="T:System.DateTime" />, используя заданный массив форматов, указанные сведения о форматировании, связанные с языком и региональными параметрами, и стиль форматирования. Формат представления строки должен полностью соответствовать хотя бы одному заданному формату. Метод возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая дату и время, которые нужно преобразовать.</param>
		/// <param name="formats">Массив разрешенных форматов <paramref name="s" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <param name="result">После возврата из этого метода содержит значение <see cref="T:System.DateTime" />, эквивалентное дате и времени, заданным в параметре <paramref name="s" />, если преобразование прошло успешно, или значение <see cref="F:System.DateTime.MinValue" />, если преобразование завершилось неудачей. Преобразование завершается неудачей, если параметр <paramref name="s" /> или <paramref name="formats" /> имеет значение <see langword="null" />, либо если параметр <paramref name="s" /> или элемент <paramref name="formats" /> является пустой строкой, либо если формат параметра <paramref name="s" /> не в точности соответствует заданному хотя бы одним из шаблонов формата в <paramref name="formats" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="styles" /> не является допустимым значением <see cref="T:System.Globalization.DateTimeStyles" />.  
		/// -или- 
		///  <paramref name="styles" /> содержит недопустимое сочетание значений <see cref="T:System.Globalization.DateTimeStyles" /> (например, и <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" />, и <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" /> ).</exception>
		// Token: 0x06000A09 RID: 2569 RVA: 0x00026D38 File Offset: 0x00024F38
		public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00026D67 File Offset: 0x00024F67
		public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, "style");
			return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		/// <summary>Прибавляет указанный временной интервал к заданной дате и времени, возвращая новую дату и время.</summary>
		/// <param name="d">Добавляемое значение даты и времени.</param>
		/// <param name="t">Добавляемый интервал времени.</param>
		/// <returns>Объект, значение которого является суммой значений <paramref name="d" /> и <paramref name="t" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x06000A0B RID: 2571 RVA: 0x00026D84 File Offset: 0x00024F84
		public static DateTime operator +(DateTime d, TimeSpan t)
		{
			long internalTicks = d.InternalTicks;
			long ticks = t._ticks;
			if (ticks > 3155378975999999999L - internalTicks || ticks < 0L - internalTicks)
			{
				throw new ArgumentOutOfRangeException("t", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks + ticks | (long)d.InternalKind));
		}

		/// <summary>Вычитает заданный временной интервал из указанной даты и времени и возвращает новую дату и время.</summary>
		/// <param name="d">Значение даты и времени, из которого производится вычитание.</param>
		/// <param name="t">Вычитаемый интервал времени.</param>
		/// <returns>Объект, значение которого является разностью значений <paramref name="d" /> и <paramref name="t" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Итоговое значение <see cref="T:System.DateTime" /> меньше <see cref="F:System.DateTime.MinValue" /> или больше <see cref="F:System.DateTime.MaxValue" />.</exception>
		// Token: 0x06000A0C RID: 2572 RVA: 0x00026DD8 File Offset: 0x00024FD8
		public static DateTime operator -(DateTime d, TimeSpan t)
		{
			long internalTicks = d.InternalTicks;
			long ticks = t._ticks;
			if (internalTicks < ticks || internalTicks - 3155378975999999999L > ticks)
			{
				throw new ArgumentOutOfRangeException("t", "The added or subtracted value results in an un-representable DateTime.");
			}
			return new DateTime((ulong)(internalTicks - ticks | (long)d.InternalKind));
		}

		/// <summary>Вычитает указанную дату и время из другой указанной даты и времени и возвращает временной интервал.</summary>
		/// <param name="d1">Значение даты и времени, из которого вычитается интервал (уменьшаемое).</param>
		/// <param name="d2">Значение даты и времени, которое вычитается (вычитаемое).</param>
		/// <returns>Временной интервал между значениями <paramref name="d1" /> и <paramref name="d2" />, то есть <paramref name="d1" /> минус <paramref name="d2" />.</returns>
		// Token: 0x06000A0D RID: 2573 RVA: 0x00026E26 File Offset: 0x00025026
		public static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			return new TimeSpan(d1.InternalTicks - d2.InternalTicks);
		}

		/// <summary>Определяет, равны ли два заданных экземпляра класса <see cref="T:System.DateTime" />.</summary>
		/// <param name="d1">Первый из сравниваемых объектов.</param>
		/// <param name="d2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="d1" /> и <paramref name="d2" /> представляют одинаковую дату и время; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A0E RID: 2574 RVA: 0x00026282 File Offset: 0x00024482
		public static bool operator ==(DateTime d1, DateTime d2)
		{
			return d1.InternalTicks == d2.InternalTicks;
		}

		/// <summary>Определяет, являются ли два заданных экземпляра класса <see cref="T:System.DateTime" /> неравными.</summary>
		/// <param name="d1">Первый из сравниваемых объектов.</param>
		/// <param name="d2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="d1" /> и <paramref name="d2" /> не представляют одинаковую дату и время; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A0F RID: 2575 RVA: 0x00026E3C File Offset: 0x0002503C
		public static bool operator !=(DateTime d1, DateTime d2)
		{
			return d1.InternalTicks != d2.InternalTicks;
		}

		/// <summary>Определяет, является ли значение одного заданного объекта <see cref="T:System.DateTime" /> более ранним относительно другого заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> раньше значения <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A10 RID: 2576 RVA: 0x00026E51 File Offset: 0x00025051
		public static bool operator <(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks < t2.InternalTicks;
		}

		/// <summary>Определяет, представляет ли заданный объект <see cref="T:System.DateTime" /> дату и время, которые совпадают со значением другого заданного объекта <see cref="T:System.DateTime" /> или являются более ранними относительно него.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="t1" /> происходит одновременно с <paramref name="t2" /> или раньше; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000A11 RID: 2577 RVA: 0x00026E63 File Offset: 0x00025063
		public static bool operator <=(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks <= t2.InternalTicks;
		}

		/// <summary>Определяет, является ли значение одного заданного объекта <see cref="T:System.DateTime" /> более поздним относительно другого заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="t1" /> позже значения <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A12 RID: 2578 RVA: 0x00026E78 File Offset: 0x00025078
		public static bool operator >(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks > t2.InternalTicks;
		}

		/// <summary>Определяет, представляет ли заданный объект <see cref="T:System.DateTime" /> дату и время, которые совпадают со значением другого заданного объекта <see cref="T:System.DateTime" /> или являются более поздними относительно него.</summary>
		/// <param name="t1">Первый из сравниваемых объектов.</param>
		/// <param name="t2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="t1" /> происходит одновременно или позже <paramref name="t2" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A13 RID: 2579 RVA: 0x00026E8A File Offset: 0x0002508A
		public static bool operator >=(DateTime t1, DateTime t2)
		{
			return t1.InternalTicks >= t2.InternalTicks;
		}

		/// <summary>Преобразует значение этого экземпляра во все строковые представления, поддерживаемые стандартным форматом даты и времени.</summary>
		/// <returns>Массив строк, каждый элемент которого является представлением значения этого экземпляра, отформатированным с использованием одного из стандартных спецификаторов формата даты и времени.</returns>
		// Token: 0x06000A14 RID: 2580 RVA: 0x00026E9F File Offset: 0x0002509F
		public string[] GetDateTimeFormats()
		{
			return this.GetDateTimeFormats(CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение этого экземпляра во все строковые представления, поддерживаемые стандартными спецификаторами формата даты и времени и указанными сведениями о форматировании, связанными с языком и региональными параметрами.</summary>
		/// <param name="provider">Объект, который представляет связанную с языком и региональными параметрами информацию о форматировании этого экземпляра.</param>
		/// <returns>Массив строк, каждый элемент которого является представлением значения этого экземпляра, отформатированным с использованием одного из стандартных спецификаторов формата даты и времени.</returns>
		// Token: 0x06000A15 RID: 2581 RVA: 0x00026EAC File Offset: 0x000250AC
		public string[] GetDateTimeFormats(IFormatProvider provider)
		{
			return DateTimeFormat.GetAllDateTimes(this, DateTimeFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует значение этого экземпляра во все строковые представления, поддерживаемые указанным стандартным спецификатором формата даты и времени.</summary>
		/// <param name="format">Строка стандартного формата даты и времени.</param>
		/// <returns>Массив строк, каждый элемент которого является представлением значения этого экземпляра, отформатированным с использованием стандартного спецификатора формата даты и времени <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым символом стандартного спецификатора формата даты и времени.</exception>
		// Token: 0x06000A16 RID: 2582 RVA: 0x00026EBF File Offset: 0x000250BF
		public string[] GetDateTimeFormats(char format)
		{
			return this.GetDateTimeFormats(format, CultureInfo.CurrentCulture);
		}

		/// <summary>Преобразует значение этого экземпляра во все строковые представления, поддерживаемые указанным стандартным спецификатором формата даты и времени и сведениями о форматировании, связанными с языком и региональными параметрами.</summary>
		/// <param name="format">Строка формата даты и времени.</param>
		/// <param name="provider">Объект, который представляет связанную с языком и региональными параметрами информацию о форматировании этого экземпляра.</param>
		/// <returns>Массив строк, каждый элемент которого является представлением значения этого экземпляра, отформатированным с использованием одного из стандартных спецификаторов формата даты и времени.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> не является допустимым символом стандартного спецификатора формата даты и времени.</exception>
		// Token: 0x06000A17 RID: 2583 RVA: 0x00026ECD File Offset: 0x000250CD
		public string[] GetDateTimeFormats(char format, IFormatProvider provider)
		{
			return DateTimeFormat.GetAllDateTimes(this, format, DateTimeFormatInfo.GetInstance(provider));
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.DateTime" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.DateTime" />.</returns>
		// Token: 0x06000A18 RID: 2584 RVA: 0x00026EE1 File Offset: 0x000250E1
		public TypeCode GetTypeCode()
		{
			return TypeCode.DateTime;
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A19 RID: 2585 RVA: 0x00026EE5 File Offset: 0x000250E5
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Boolean"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1A RID: 2586 RVA: 0x00026F00 File Offset: 0x00025100
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Char"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1B RID: 2587 RVA: 0x00026F1B File Offset: 0x0002511B
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "SByte"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1C RID: 2588 RVA: 0x00026F36 File Offset: 0x00025136
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Byte"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1D RID: 2589 RVA: 0x00026F51 File Offset: 0x00025151
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int16"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1E RID: 2590 RVA: 0x00026F6C File Offset: 0x0002516C
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt16"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A1F RID: 2591 RVA: 0x00026F87 File Offset: 0x00025187
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int32"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A20 RID: 2592 RVA: 0x00026FA2 File Offset: 0x000251A2
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt32"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A21 RID: 2593 RVA: 0x00026FBD File Offset: 0x000251BD
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Int64"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A22 RID: 2594 RVA: 0x00026FD8 File Offset: 0x000251D8
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "UInt64"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A23 RID: 2595 RVA: 0x00026FF3 File Offset: 0x000251F3
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Single"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A24 RID: 2596 RVA: 0x0002700E File Offset: 0x0002520E
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Double"));
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000A25 RID: 2597 RVA: 0x00027029 File Offset: 0x00025229
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "DateTime", "Decimal"));
		}

		/// <summary>Возвращает текущий объект <see cref="T:System.DateTime" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Текущий объект.</returns>
		// Token: 0x06000A26 RID: 2598 RVA: 0x00027044 File Offset: 0x00025244
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Преобразует текущий объект <see cref="T:System.DateTime" /> в объект заданного типа.</summary>
		/// <param name="type">Требуемый тип.</param>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Объект типа, заданного параметром <paramref name="type" />, значение которого эквивалентно значению текущего объекта <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DateTime" />.</exception>
		// Token: 0x06000A27 RID: 2599 RVA: 0x0002704C File Offset: 0x0002524C
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00027060 File Offset: 0x00025260
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			result = DateTime.MinValue;
			if (year < 1 || year > 9999 || month < 1 || month > 12)
			{
				return false;
			}
			int[] array = DateTime.IsLeapYear(year) ? DateTime.s_daysToMonth366 : DateTime.s_daysToMonth365;
			if (day < 1 || day > array[month] - array[month - 1])
			{
				return false;
			}
			if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second >= 60)
			{
				return false;
			}
			if (millisecond < 0 || millisecond >= 1000)
			{
				return false;
			}
			long num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
			num += (long)millisecond * 10000L;
			if (num < 0L || num > 3155378975999999999L)
			{
				return false;
			}
			result = new DateTime(num, DateTimeKind.Unspecified);
			return true;
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" />, которому присвоены текущие дата и время данного компьютера, выраженные в формате UTC.</summary>
		/// <returns>Объект, значение которого является текущим значением даты и времени в формате UTC.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002712B File Offset: 0x0002532B
		public static DateTime UtcNow
		{
			get
			{
				return new DateTime((ulong)(DateTime.GetSystemTimeAsFileTime() + 504911232000000000L | 4611686018427387904L));
			}
		}

		// Token: 0x06000A2A RID: 2602
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern long GetSystemTimeAsFileTime();

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002714B File Offset: 0x0002534B
		internal long ToBinaryRaw()
		{
			return (long)this._dateData;
		}

		// Token: 0x04001093 RID: 4243
		private const long TicksPerMillisecond = 10000L;

		// Token: 0x04001094 RID: 4244
		private const long TicksPerSecond = 10000000L;

		// Token: 0x04001095 RID: 4245
		private const long TicksPerMinute = 600000000L;

		// Token: 0x04001096 RID: 4246
		private const long TicksPerHour = 36000000000L;

		// Token: 0x04001097 RID: 4247
		private const long TicksPerDay = 864000000000L;

		// Token: 0x04001098 RID: 4248
		private const int MillisPerSecond = 1000;

		// Token: 0x04001099 RID: 4249
		private const int MillisPerMinute = 60000;

		// Token: 0x0400109A RID: 4250
		private const int MillisPerHour = 3600000;

		// Token: 0x0400109B RID: 4251
		private const int MillisPerDay = 86400000;

		// Token: 0x0400109C RID: 4252
		private const int DaysPerYear = 365;

		// Token: 0x0400109D RID: 4253
		private const int DaysPer4Years = 1461;

		// Token: 0x0400109E RID: 4254
		private const int DaysPer100Years = 36524;

		// Token: 0x0400109F RID: 4255
		private const int DaysPer400Years = 146097;

		// Token: 0x040010A0 RID: 4256
		private const int DaysTo1601 = 584388;

		// Token: 0x040010A1 RID: 4257
		private const int DaysTo1899 = 693593;

		// Token: 0x040010A2 RID: 4258
		internal const int DaysTo1970 = 719162;

		// Token: 0x040010A3 RID: 4259
		private const int DaysTo10000 = 3652059;

		// Token: 0x040010A4 RID: 4260
		internal const long MinTicks = 0L;

		// Token: 0x040010A5 RID: 4261
		internal const long MaxTicks = 3155378975999999999L;

		// Token: 0x040010A6 RID: 4262
		private const long MaxMillis = 315537897600000L;

		// Token: 0x040010A7 RID: 4263
		internal const long UnixEpochTicks = 621355968000000000L;

		// Token: 0x040010A8 RID: 4264
		private const long FileTimeOffset = 504911232000000000L;

		// Token: 0x040010A9 RID: 4265
		private const long DoubleDateOffset = 599264352000000000L;

		// Token: 0x040010AA RID: 4266
		private const long OADateMinAsTicks = 31241376000000000L;

		// Token: 0x040010AB RID: 4267
		private const double OADateMinAsDouble = -657435.0;

		// Token: 0x040010AC RID: 4268
		private const double OADateMaxAsDouble = 2958466.0;

		// Token: 0x040010AD RID: 4269
		private const int DatePartYear = 0;

		// Token: 0x040010AE RID: 4270
		private const int DatePartDayOfYear = 1;

		// Token: 0x040010AF RID: 4271
		private const int DatePartMonth = 2;

		// Token: 0x040010B0 RID: 4272
		private const int DatePartDay = 3;

		// Token: 0x040010B1 RID: 4273
		private static readonly int[] s_daysToMonth365 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x040010B2 RID: 4274
		private static readonly int[] s_daysToMonth366 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.DateTime" />. Это поле доступно только для чтения.</summary>
		// Token: 0x040010B3 RID: 4275
		public static readonly DateTime MinValue = new DateTime(0L, DateTimeKind.Unspecified);

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.DateTime" />. Это поле доступно только для чтения.</summary>
		// Token: 0x040010B4 RID: 4276
		public static readonly DateTime MaxValue = new DateTime(3155378975999999999L, DateTimeKind.Unspecified);

		// Token: 0x040010B5 RID: 4277
		public static readonly DateTime UnixEpoch = new DateTime(621355968000000000L, DateTimeKind.Utc);

		// Token: 0x040010B6 RID: 4278
		private const ulong TicksMask = 4611686018427387903UL;

		// Token: 0x040010B7 RID: 4279
		private const ulong FlagsMask = 13835058055282163712UL;

		// Token: 0x040010B8 RID: 4280
		private const ulong LocalMask = 9223372036854775808UL;

		// Token: 0x040010B9 RID: 4281
		private const long TicksCeiling = 4611686018427387904L;

		// Token: 0x040010BA RID: 4282
		private const ulong KindUnspecified = 0UL;

		// Token: 0x040010BB RID: 4283
		private const ulong KindUtc = 4611686018427387904UL;

		// Token: 0x040010BC RID: 4284
		private const ulong KindLocal = 9223372036854775808UL;

		// Token: 0x040010BD RID: 4285
		private const ulong KindLocalAmbiguousDst = 13835058055282163712UL;

		// Token: 0x040010BE RID: 4286
		private const int KindShift = 62;

		// Token: 0x040010BF RID: 4287
		private const string TicksField = "ticks";

		// Token: 0x040010C0 RID: 4288
		private const string DateDataField = "dateData";

		// Token: 0x040010C1 RID: 4289
		private readonly ulong _dateData;
	}
}
