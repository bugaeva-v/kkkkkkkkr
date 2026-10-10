using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Представляет юлианский календарь.</summary>
	// Token: 0x02000991 RID: 2449
	[ComVisible(true)]
	[Serializable]
	public class JulianCalendar : Calendar
	{
		/// <summary>Получает самые ранние дату и время, поддерживаемые классом <see cref="T:System.Globalization.JulianCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые классом <see cref="T:System.Globalization.JulianCalendar" />, что эквивалентно первому мгновению 1 января 0001 года нашей эры по григорианскому календарю.</returns>
		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x0012274E File Offset: 0x0012094E
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return DateTime.MinValue;
			}
		}

		/// <summary>Получает самые последние дату и время, поддерживаемые классом <see cref="T:System.Globalization.JulianCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые классом <see cref="T:System.Globalization.JulianCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x00122755 File Offset: 0x00120955
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return DateTime.MaxValue;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.SolarCalendar" />.</returns>
		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06005744 RID: 22340 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.JulianCalendar" />.</summary>
		// Token: 0x06005745 RID: 22341 RVA: 0x001271EC File Offset: 0x001253EC
		public JulianCalendar()
		{
			this.twoDigitYearMax = 2029;
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06005746 RID: 22342 RVA: 0x0003D1E6 File Offset: 0x0003B3E6
		internal override int ID
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x0012720A File Offset: 0x0012540A
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != JulianCalendar.JulianEra)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0012722C File Offset: 0x0012542C
		internal void CheckYearEraRange(int year, int era)
		{
			JulianCalendar.CheckEraRange(era);
			if (year <= 0 || year > this.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, this.MaxYear));
			}
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0012727C File Offset: 0x0012547C
		internal static void CheckMonthRange(int month)
		{
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0012729C File Offset: 0x0012549C
		internal static void CheckDayRange(int year, int month, int day)
		{
			if (year == 1 && month == 1 && day < 3)
			{
				throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
			}
			int[] array = (year % 4 == 0) ? JulianCalendar.DaysToMonth366 : JulianCalendar.DaysToMonth365;
			int num = array[month] - array[month - 1];
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, num));
			}
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00127318 File Offset: 0x00125518
		internal static int GetDatePart(long ticks, int part)
		{
			int i = (int)((ticks + 1728000000000L) / 864000000000L);
			int num = i / 1461;
			i -= num * 1461;
			int num2 = i / 365;
			if (num2 == 4)
			{
				num2 = 3;
			}
			if (part == 0)
			{
				return num * 4 + num2 + 1;
			}
			i -= num2 * 365;
			if (part == 1)
			{
				return i + 1;
			}
			int[] array = (num2 == 3) ? JulianCalendar.DaysToMonth366 : JulianCalendar.DaysToMonth365;
			int num3 = i >> 6;
			while (i >= array[num3])
			{
				num3++;
			}
			if (part == 2)
			{
				return num3;
			}
			return i - array[num3 - 1] + 1;
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x001273B4 File Offset: 0x001255B4
		internal static long DateToTicks(int year, int month, int day)
		{
			int[] array = (year % 4 == 0) ? JulianCalendar.DaysToMonth366 : JulianCalendar.DaysToMonth365;
			int num = year - 1;
			return (long)(num * 365 + num / 4 + array[month - 1] + day - 1 - 2) * 864000000000L;
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> меньше –120 000.  
		///
		/// или - 
		/// Значение <paramref name="months" /> больше 120 000.</exception>
		// Token: 0x0600574D RID: 22349 RVA: 0x001273FC File Offset: 0x001255FC
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), -120000, 120000));
			}
			int num = JulianCalendar.GetDatePart(time.Ticks, 0);
			int num2 = JulianCalendar.GetDatePart(time.Ticks, 2);
			int num3 = JulianCalendar.GetDatePart(time.Ticks, 3);
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
			int[] array = (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0)) ? JulianCalendar.DaysToMonth366 : JulianCalendar.DaysToMonth365;
			int num5 = array[num2] - array[num2 - 1];
			if (num3 > num5)
			{
				num3 = num5;
			}
			long ticks = JulianCalendar.DateToTicks(num, num2, num3) + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x0600574E RID: 22350 RVA: 0x001223A9 File Offset: 0x001205A9
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в параметре <paramref name="time" />.</returns>
		// Token: 0x0600574F RID: 22351 RVA: 0x0012750C File Offset: 0x0012570C
		public override int GetDayOfMonth(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в <paramref name="time" />.</returns>
		// Token: 0x06005750 RID: 22352 RVA: 0x001223C6 File Offset: 0x001205C6
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в параметре <paramref name="time" />.</returns>
		// Token: 0x06005751 RID: 22353 RVA: 0x0012751B File Offset: 0x0012571B
		public override int GetDayOfYear(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 1);
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005752 RID: 22354 RVA: 0x0012752C File Offset: 0x0012572C
		public override int GetDaysInMonth(int year, int month, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			int[] array = (year % 4 == 0) ? JulianCalendar.DaysToMonth366 : JulianCalendar.DaysToMonth365;
			return array[month] - array[month - 1];
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005753 RID: 22355 RVA: 0x00127562 File Offset: 0x00125762
		public override int GetDaysInYear(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 365;
			}
			return 366;
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в <paramref name="time" />.</returns>
		// Token: 0x06005754 RID: 22356 RVA: 0x00127579 File Offset: 0x00125779
		public override int GetEra(DateTime time)
		{
			return JulianCalendar.JulianEra;
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в параметре <paramref name="time" />.</returns>
		// Token: 0x06005755 RID: 22357 RVA: 0x00127580 File Offset: 0x00125780
		public override int GetMonth(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.JulianCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в классе <see cref="T:System.Globalization.JulianCalendar" />.</returns>
		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x0012758F File Offset: 0x0012578F
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					JulianCalendar.JulianEra
				};
			}
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005757 RID: 22359 RVA: 0x0012759F File Offset: 0x0012579F
		public override int GetMonthsInYear(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return 12;
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в параметре <paramref name="time" />.</returns>
		// Token: 0x06005758 RID: 22360 RVA: 0x001275AB File Offset: 0x001257AB
		public override int GetYear(DateTime time)
		{
			return JulianCalendar.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, обозначающее день.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005759 RID: 22361 RVA: 0x001275BA File Offset: 0x001257BA
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			JulianCalendar.CheckMonthRange(month);
			if (this.IsLeapYear(year, era))
			{
				JulianCalendar.CheckDayRange(year, month, day);
				return month == 2 && day == 29;
			}
			JulianCalendar.CheckDayRange(year, month, day);
			return false;
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Положительное целое число от 1 до 13, указывающее високосный месяц в указанном году указанной эры. Нуль, если этот календарь не поддерживает високосные месяцы, или если в параметрах <paramref name="year" /> и <paramref name="era" /> не указан високосный год.</returns>
		// Token: 0x0600575A RID: 22362 RVA: 0x001275EA File Offset: 0x001257EA
		[ComVisible(false)]
		public override int GetLeapMonth(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return 0;
		}

		/// <summary>Определяет, является ли указанный месяц указанного года указанной эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Этот метод всегда возвращает значение <see langword="false" />, если не переопределен производным классом.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600575B RID: 22363 RVA: 0x001275F5 File Offset: 0x001257F5
		public override bool IsLeapMonth(int year, int month, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			return false;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600575C RID: 22364 RVA: 0x00127606 File Offset: 0x00125806
		public override bool IsLeapYear(int year, int era)
		{
			this.CheckYearEraRange(year, era);
			return year % 4 == 0;
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> с заданными значениями даты и времени в указанной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, обозначающее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="month" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Значение параметра <paramref name="day" /> находится вне диапазона, поддерживаемого календарем.  
		///
		/// или - 
		/// Параметр <paramref name="hour" /> меньше нуля или больше 23.  
		///
		/// или - 
		/// Параметр <paramref name="minute" /> меньше нуля или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="second" /> меньше нуля или больше 59.  
		///
		/// или - 
		/// Параметр <paramref name="millisecond" /> меньше нуля или больше 999.  
		///
		/// или - 
		/// Значение параметра <paramref name="era" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x0600575D RID: 22365 RVA: 0x00127618 File Offset: 0x00125818
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			this.CheckYearEraRange(year, era);
			JulianCalendar.CheckMonthRange(month);
			JulianCalendar.CheckDayRange(year, month, day);
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 0, 999));
			}
			if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
			{
				return new DateTime(JulianCalendar.DateToTicks(year, month, day) + new TimeSpan(0, hour, minute, second, millisecond).Ticks);
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Hour, Minute, and Second parameters describe an un-representable DateTime."));
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции установки, меньше 99.  
		///
		/// или - 
		/// Значение, указанное в операции установки, больше <see langword="MaxSupportedDateTime.Year" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">В операции задания текущий экземпляр доступен только для чтения.</exception>
		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x00122C4C File Offset: 0x00120E4C
		// (set) Token: 0x0600575F RID: 22367 RVA: 0x001276D0 File Offset: 0x001258D0
		public override int TwoDigitYearMax
		{
			get
			{
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.MaxYear)
				{
					throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, this.MaxYear));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.JulianCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> находится вне диапазона, поддерживаемого календарем.</exception>
		// Token: 0x06005760 RID: 22368 RVA: 0x0012772C File Offset: 0x0012592C
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year > this.MaxYear)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument must be between {0} and {1}."), 1, this.MaxYear));
			}
			return base.ToFourDigitYear(year);
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x0400364E RID: 13902
		public static readonly int JulianEra = 1;

		// Token: 0x0400364F RID: 13903
		private const int DatePartYear = 0;

		// Token: 0x04003650 RID: 13904
		private const int DatePartDayOfYear = 1;

		// Token: 0x04003651 RID: 13905
		private const int DatePartMonth = 2;

		// Token: 0x04003652 RID: 13906
		private const int DatePartDay = 3;

		// Token: 0x04003653 RID: 13907
		private const int JulianDaysPerYear = 365;

		// Token: 0x04003654 RID: 13908
		private const int JulianDaysPer4Years = 1461;

		// Token: 0x04003655 RID: 13909
		private static readonly int[] DaysToMonth365 = new int[]
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

		// Token: 0x04003656 RID: 13910
		private static readonly int[] DaysToMonth366 = new int[]
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

		// Token: 0x04003657 RID: 13911
		internal int MaxYear = 9999;
	}
}
