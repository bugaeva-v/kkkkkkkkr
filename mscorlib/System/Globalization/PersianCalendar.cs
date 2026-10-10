using System;

namespace System.Globalization
{
	/// <summary>Представляет персидский календарь.</summary>
	// Token: 0x02000982 RID: 2434
	[Serializable]
	public class PersianCalendar : Calendar
	{
		/// <summary>Получает самые ранние дату и время, поддерживаемые классом <see cref="T:System.Globalization.PersianCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые классом <see cref="T:System.Globalization.PersianCalendar" />.</returns>
		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x0012202A File Offset: 0x0012022A
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return PersianCalendar.minDate;
			}
		}

		/// <summary>Получает самые последние дату и время, поддерживаемые классом <see cref="T:System.Globalization.PersianCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые классом <see cref="T:System.Globalization.PersianCalendar" />.</returns>
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x00122031 File Offset: 0x00120231
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return PersianCalendar.maxDate;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или солнечно-лунным.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.SolarCalendar" />.</returns>
		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x000040F7 File Offset: 0x000022F7
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x000040F7 File Offset: 0x000022F7
		internal override int BaseCalendarID
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x00122040 File Offset: 0x00120240
		internal override int ID
		{
			get
			{
				return 22;
			}
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00122044 File Offset: 0x00120244
		private long GetAbsoluteDatePersian(int year, int month, int day)
		{
			if (year >= 1 && year <= 9378 && month >= 1 && month <= 12)
			{
				int num = PersianCalendar.DaysInPreviousMonths(month) + day - 1;
				int num2 = (int)(365.242189 * (double)(year - 1));
				return CalendricalCalculationsHelper.PersianNewYearOnOrBefore(PersianCalendar.PersianEpoch + (long)num2 + 180L) + (long)num;
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x001220AC File Offset: 0x001202AC
		internal static void CheckTicksRange(long ticks)
		{
			if (ticks < PersianCalendar.minDate.Ticks || ticks > PersianCalendar.maxDate.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), PersianCalendar.minDate, PersianCalendar.maxDate));
			}
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00122106 File Offset: 0x00120306
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != PersianCalendar.PersianEra)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00122128 File Offset: 0x00120328
		internal static void CheckYearRange(int year, int era)
		{
			PersianCalendar.CheckEraRange(era);
			if (year < 1 || year > 9378)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9378));
			}
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00122178 File Offset: 0x00120378
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378 && month > 10)
			{
				throw new ArgumentOutOfRangeException("month", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 10));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x001221E4 File Offset: 0x001203E4
		private static int MonthFromOrdinalDay(int ordinalDay)
		{
			int num = 0;
			while (ordinalDay > PersianCalendar.DaysToMonth[num])
			{
				num++;
			}
			return num;
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00122204 File Offset: 0x00120404
		private static int DaysInPreviousMonths(int month)
		{
			month--;
			return PersianCalendar.DaysToMonth[month];
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00122214 File Offset: 0x00120414
		internal int GetDatePart(long ticks, int part)
		{
			PersianCalendar.CheckTicksRange(ticks);
			long num = ticks / 864000000000L + 1L;
			int num2 = (int)Math.Floor((double)(CalendricalCalculationsHelper.PersianNewYearOnOrBefore(num) - PersianCalendar.PersianEpoch) / 365.242189 + 0.5) + 1;
			if (part == 0)
			{
				return num2;
			}
			int num3 = (int)(num - CalendricalCalculationsHelper.GetNumberOfDays(this.ToDateTime(num2, 1, 1, 0, 0, 0, 0, 1)));
			if (part == 1)
			{
				return num3;
			}
			int num4 = PersianCalendar.MonthFromOrdinalDay(num3);
			if (part == 2)
			{
				return num4;
			}
			int result = num3 - PersianCalendar.DaysInPreviousMonths(num4);
			if (part == 3)
			{
				return result;
			}
			throw new InvalidOperationException(Environment.GetResourceString("Internal Error in DateTime and Calendar operations."));
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" />, который смещен от указанного объекта <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Положительное или отрицательное число месяцев для добавления.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, представляющий дату, полученную путем добавления числа месяцев, указанных в параметре <paramref name="months" />, к указанной дате в параметре <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="months" /> имеет значение меньше –120 000 или больше 120 000.</exception>
		// Token: 0x060055DD RID: 21981 RVA: 0x001222B0 File Offset: 0x001204B0
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), -120000, 120000));
			}
			int num = this.GetDatePart(time.Ticks, 0);
			int num2 = this.GetDatePart(time.Ticks, 2);
			int num3 = this.GetDatePart(time.Ticks, 3);
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
			int daysInMonth = this.GetDaysInMonth(num, num2);
			if (num3 > daysInMonth)
			{
				num3 = daysInMonth;
			}
			long ticks = this.GetAbsoluteDatePersian(num, num2, num3) * 864000000000L + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" />, который смещен от указанного объекта <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Положительное или отрицательное число лет для добавления.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный в результате добавления указанного числа лет к указанному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="years" /> меньше –10 000 или больше 10 000.</exception>
		// Token: 0x060055DE RID: 21982 RVA: 0x001223A9 File Offset: 0x001205A9
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		/// <summary>Возвращает день месяца в заданном объекте <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в заданном объекте <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> представляет дату, меньшую чем <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> или большую чем <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060055DF RID: 21983 RVA: 0x001223B6 File Offset: 0x001205B6
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Возвращает день недели из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном объекте <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060055E0 RID: 21984 RVA: 0x001223C6 File Offset: 0x001205C6
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Возвращает день года в заданном объекте <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 366, обозначающее день года в заданном объекте <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> представляет дату, меньшую чем <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> или большую чем <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060055E1 RID: 21985 RVA: 0x001223DF File Offset: 0x001205DF
		public override int GetDayOfYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 1);
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="month">Целое число, представляющее код, в диапазоне от 1 до 12, если параметр <paramref name="year" /> не равен 9378, или от 1 до 10, если параметр <paramref name="year" /> равен 9378.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Число дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055E2 RID: 21986 RVA: 0x001223F0 File Offset: 0x001205F0
		public override int GetDaysInMonth(int year, int month, int era)
		{
			PersianCalendar.CheckYearMonthRange(year, month, era);
			if (month == 10 && year == 9378)
			{
				return 13;
			}
			int num = PersianCalendar.DaysToMonth[month] - PersianCalendar.DaysToMonth[month - 1];
			if (month == 12 && !this.IsLeapYear(year))
			{
				num--;
			}
			return num;
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры. Возвращенное число дней равно 365 дням для обычного года или 366 для високосного.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055E3 RID: 21987 RVA: 0x0012243A File Offset: 0x0012063A
		public override int GetDaysInYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378)
			{
				return PersianCalendar.DaysToMonth[9] + 13;
			}
			if (!this.IsLeapYear(year, 0))
			{
				return 365;
			}
			return 366;
		}

		/// <summary>Возвращает значение эры в заданном объекте <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.PersianCalendar.PersianEra" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> представляет дату, меньшую чем <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> или большую чем <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060055E4 RID: 21988 RVA: 0x0012246C File Offset: 0x0012066C
		public override int GetEra(DateTime time)
		{
			PersianCalendar.CheckTicksRange(time.Ticks);
			return PersianCalendar.PersianEra;
		}

		/// <summary>Получает список эр в объекте <see cref="T:System.Globalization.PersianCalendar" />.</summary>
		/// <returns>Массив целых чисел, представляющий эры в объекте <see cref="T:System.Globalization.PersianCalendar" />. Этот массив состоит из одного элемента, значение которого равно <see cref="F:System.Globalization.PersianCalendar.PersianEra" />.</returns>
		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060055E5 RID: 21989 RVA: 0x0012247F File Offset: 0x0012067F
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					PersianCalendar.PersianEra
				};
			}
		}

		/// <summary>Возвращает значение месяца в заданном объекте <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> представляет дату, меньшую чем <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> или большую чем <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060055E6 RID: 21990 RVA: 0x0012248F File Offset: 0x0012068F
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Возвращает 10, если параметр <paramref name="year" /> равен 9378; в противном случае всегда возвращает 12.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055E7 RID: 21991 RVA: 0x0012249F File Offset: 0x0012069F
		public override int GetMonthsInYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378)
			{
				return 10;
			}
			return 12;
		}

		/// <summary>Возвращает значение года в заданном объекте <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 9378, обозначающее год в заданном объекте <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="time" /> представляет дату, меньшую чем <see cref="P:System.Globalization.PersianCalendar.MinSupportedDateTime" /> или большую чем <see cref="P:System.Globalization.PersianCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060055E8 RID: 21992 RVA: 0x001224B5 File Offset: 0x001206B5
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Определяет, является ли указанный день високосным.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="month">Целое число, представляющее код, в диапазоне от 1 до 12, если параметр <paramref name="year" /> не равен 9378, или от 1 до 10, если параметр <paramref name="year" /> равен 9378.</param>
		/// <param name="day">Целое число от 1 до 31, представляющее день.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055E9 RID: 21993 RVA: 0x001224C8 File Offset: 0x001206C8
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Day must be between 1 and {0} for month {1}."), daysInMonth, month));
			}
			return this.IsLeapYear(year, era) && month == 12 && day == 30;
		}

		/// <summary>Возвращает високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год для преобразования.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Возвращаемое значение всегда равно 0.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055EA RID: 21994 RVA: 0x0012252A File Offset: 0x0012072A
		public override int GetLeapMonth(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			return 0;
		}

		/// <summary>Определяет, является ли указанный месяц указанных года и эры високосным месяцем.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="month">Целое число, представляющее код, в диапазоне от 1 до 12, если параметр <paramref name="year" /> не равен 9378, или от 1 до 10, если параметр <paramref name="year" /> равен 9378.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Всегда возвращает <see langword="false" />, потому что класс <see cref="T:System.Globalization.PersianCalendar" /> не поддерживает понятие високосного года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055EB RID: 21995 RVA: 0x00122534 File Offset: 0x00120734
		public override bool IsLeapMonth(int year, int month, int era)
		{
			PersianCalendar.CheckYearMonthRange(year, month, era);
			return false;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055EC RID: 21996 RVA: 0x0012253F File Offset: 0x0012073F
		public override bool IsLeapYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			return year != 9378 && this.GetAbsoluteDatePersian(year + 1, 1, 1) - this.GetAbsoluteDatePersian(year, 1, 1) == 366L;
		}

		/// <summary>Возвращает объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в заданной эре.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, представляющее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, представляющее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число от 0 до 1, представляющее эру.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" />, <paramref name="millisecond" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060055ED RID: 21997 RVA: 0x00122570 File Offset: 0x00120770
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Day must be between 1 and {0} for month {1}."), daysInMonth, month));
			}
			long absoluteDatePersian = this.GetAbsoluteDatePersian(year, month, day);
			if (absoluteDatePersian >= 0L)
			{
				return new DateTime(absoluteDatePersian * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этот календарь доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в наборе операций меньше 100 или больше 9378.</exception>
		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x001225F9 File Offset: 0x001207F9
		// (set) Token: 0x060055EF RID: 21999 RVA: 0x00122620 File Offset: 0x00120820
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 1410);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9378)
				{
					throw new ArgumentOutOfRangeException("value", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, 9378));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует указанный год в четырехзначное представление года.</summary>
		/// <param name="year">Целое число от 1 до 9378, представляющее год для преобразования.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="year" /> имеет значение меньше 0 или больше 9378.</exception>
		// Token: 0x060055F0 RID: 22000 RVA: 0x00122678 File Offset: 0x00120878
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			if (year < 100)
			{
				return base.ToFourDigitYear(year);
			}
			if (year > 9378)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9378));
			}
			return year;
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x04003577 RID: 13687
		public static readonly int PersianEra = 1;

		// Token: 0x04003578 RID: 13688
		internal static long PersianEpoch = new DateTime(622, 3, 22).Ticks / 864000000000L;

		// Token: 0x04003579 RID: 13689
		private const int ApproximateHalfYear = 180;

		// Token: 0x0400357A RID: 13690
		internal const int DatePartYear = 0;

		// Token: 0x0400357B RID: 13691
		internal const int DatePartDayOfYear = 1;

		// Token: 0x0400357C RID: 13692
		internal const int DatePartMonth = 2;

		// Token: 0x0400357D RID: 13693
		internal const int DatePartDay = 3;

		// Token: 0x0400357E RID: 13694
		internal const int MonthsPerYear = 12;

		// Token: 0x0400357F RID: 13695
		internal static int[] DaysToMonth = new int[]
		{
			0,
			31,
			62,
			93,
			124,
			155,
			186,
			216,
			246,
			276,
			306,
			336,
			366
		};

		// Token: 0x04003580 RID: 13696
		internal const int MaxCalendarYear = 9378;

		// Token: 0x04003581 RID: 13697
		internal const int MaxCalendarMonth = 10;

		// Token: 0x04003582 RID: 13698
		internal const int MaxCalendarDay = 13;

		// Token: 0x04003583 RID: 13699
		internal static DateTime minDate = new DateTime(622, 3, 22);

		// Token: 0x04003584 RID: 13700
		internal static DateTime maxDate = DateTime.MaxValue;

		// Token: 0x04003585 RID: 13701
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1410;
	}
}
