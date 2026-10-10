using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Globalization
{
	/// <summary>Представляет исламский календарь.</summary>
	// Token: 0x0200098E RID: 2446
	[ComVisible(true)]
	[Serializable]
	public class HijriCalendar : Calendar
	{
		/// <summary>Получает минимальное значение даты и времени, поддерживаемое этим календарем.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые типом <see cref="T:System.Globalization.HijriCalendar" />, что эквивалентно первому мгновению 18 июля 622 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x001263B0 File Offset: 0x001245B0
		[ComVisible(false)]
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return HijriCalendar.calendarMinValue;
			}
		}

		/// <summary>Возвращает самые последние дату и время, поддерживаемые этим календарем.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые типом <see cref="T:System.Globalization.HijriCalendar" />, что эквивалентно последнему мгновению 31 декабря 9999 года нашей эры по григорианскому календарю.</returns>
		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060056E8 RID: 22248 RVA: 0x001263B7 File Offset: 0x001245B7
		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return HijriCalendar.calendarMaxValue;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.LunarCalendar" />.</returns>
		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x00015831 File Offset: 0x00013A31
		[ComVisible(false)]
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunarCalendar;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x000224A3 File Offset: 0x000206A3
		internal override int ID
		{
			get
			{
				return 6;
			}
		}

		/// <summary>Получает число дней в году, который предшествует году, указанному свойством <see cref="P:System.Globalization.HijriCalendar.MinSupportedDateTime" />.</summary>
		/// <returns>Число дней в году, который предшествует году, указанному с помощью <see cref="P:System.Globalization.HijriCalendar.MinSupportedDateTime" />.</returns>
		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x001263D1 File Offset: 0x001245D1
		protected override int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 354;
			}
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x001263D8 File Offset: 0x001245D8
		private long GetAbsoluteDateHijri(int y, int m, int d)
		{
			return this.DaysUpToHijriYear(y) + (long)HijriCalendar.HijriMonthDays[m - 1] + (long)d - 1L - (long)this.HijriAdjustment;
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x001263FC File Offset: 0x001245FC
		private long DaysUpToHijriYear(int HijriYear)
		{
			int num = (HijriYear - 1) / 30 * 30;
			int i = HijriYear - num - 1;
			long num2 = (long)num * 10631L / 30L + 227013L;
			while (i > 0)
			{
				num2 += (long)(354 + (this.IsLeapYear(i, 0) ? 1 : 0));
				i--;
			}
			return num2;
		}

		/// <summary>Возвращает или задает число дней, добавляемое в календарь или вычитаемое из него, чтобы компенсировать различия в начале и окончании рамазана и разницу в датах между странами и областями.</summary>
		/// <returns>Целое число от -2 до 2, представляющее число дней, добавляемых в календарь или вычитаемых из него.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задается недопустимое значение.</exception>
		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x00126451 File Offset: 0x00124651
		// (set) Token: 0x060056F0 RID: 22256 RVA: 0x00126474 File Offset: 0x00124674
		public int HijriAdjustment
		{
			[SecuritySafeCritical]
			get
			{
				if (this.m_HijriAdvance == -2147483648)
				{
					this.m_HijriAdvance = HijriCalendar.GetAdvanceHijriDate();
				}
				return this.m_HijriAdvance;
			}
			set
			{
				if (value < -2 || value > 2)
				{
					throw new ArgumentOutOfRangeException("HijriAdjustment", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument must be between {0} and {1}."), -2, 2));
				}
				base.VerifyWritable();
				this.m_HijriAdvance = value;
			}
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[SecurityCritical]
		private static int GetAdvanceHijriDate()
		{
			return 0;
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x001264C4 File Offset: 0x001246C4
		internal static void CheckTicksRange(long ticks)
		{
			if (ticks < HijriCalendar.calendarMinValue.Ticks || ticks > HijriCalendar.calendarMaxValue.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), HijriCalendar.calendarMinValue, HijriCalendar.calendarMaxValue));
			}
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x0012651E File Offset: 0x0012471E
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != HijriCalendar.HijriEra)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00126540 File Offset: 0x00124740
		internal static void CheckYearRange(int year, int era)
		{
			HijriCalendar.CheckEraRange(era);
			if (year < 1 || year > 9666)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9666));
			}
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x00126590 File Offset: 0x00124790
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			if (year == 9666 && month > 4)
			{
				throw new ArgumentOutOfRangeException("month", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 4));
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x001265FC File Offset: 0x001247FC
		internal virtual int GetDatePart(long ticks, int part)
		{
			HijriCalendar.CheckTicksRange(ticks);
			long num = ticks / 864000000000L + 1L;
			num += (long)this.HijriAdjustment;
			int num2 = (int)((num - 227013L) * 30L / 10631L) + 1;
			long num3 = this.DaysUpToHijriYear(num2);
			long num4 = (long)this.GetDaysInYear(num2, 0);
			if (num < num3)
			{
				num3 -= num4;
				num2--;
			}
			else if (num == num3)
			{
				num2--;
				num3 -= (long)this.GetDaysInYear(num2, 0);
			}
			else if (num > num3 + num4)
			{
				num3 += num4;
				num2++;
			}
			if (part == 0)
			{
				return num2;
			}
			int num5 = 1;
			num -= num3;
			if (part == 1)
			{
				return (int)num;
			}
			while (num5 <= 12 && num > (long)HijriCalendar.HijriMonthDays[num5 - 1])
			{
				num5++;
			}
			num5--;
			if (part == 2)
			{
				return num5;
			}
			int result = (int)(num - (long)HijriCalendar.HijriMonthDays[num5 - 1]);
			if (part == 3)
			{
				return result;
			}
			throw new InvalidOperationException(Environment.GetResourceString("Internal Error in DateTime and Calendar operations."));
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются месяцы.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующий объект <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="months" /> меньше –120 000.  
		///
		/// или - 
		/// Значение <paramref name="months" /> больше 120 000.</exception>
		// Token: 0x060056F7 RID: 22263 RVA: 0x001266E8 File Offset: 0x001248E8
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
			long ticks = this.GetAbsoluteDateHijri(num, num2, num3) * 864000000000L + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому добавляются годы.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x060056F8 RID: 22264 RVA: 0x001223A9 File Offset: 0x001205A9
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 30, обозначающее день месяца в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056F9 RID: 22265 RVA: 0x001267E1 File Offset: 0x001249E1
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056FA RID: 22266 RVA: 0x001223C6 File Offset: 0x001205C6
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 355, обозначающее день года в заданном параметре <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056FB RID: 22267 RVA: 0x001267F1 File Offset: 0x001249F1
		public override int GetDayOfYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 1);
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="month" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x060056FC RID: 22268 RVA: 0x00126801 File Offset: 0x00124A01
		public override int GetDaysInMonth(int year, int month, int era)
		{
			HijriCalendar.CheckYearMonthRange(year, month, era);
			if (month == 12)
			{
				if (!this.IsLeapYear(year, 0))
				{
					return 29;
				}
				return 30;
			}
			else
			{
				if (month % 2 != 1)
				{
					return 29;
				}
				return 30;
			}
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры. Возвращенное число дней равно 354 месяцам для обычного года или 355 для високосного.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060056FD RID: 22269 RVA: 0x0012682B File Offset: 0x00124A2B
		public override int GetDaysInYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			if (!this.IsLeapYear(year, 0))
			{
				return 354;
			}
			return 355;
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056FE RID: 22270 RVA: 0x00126849 File Offset: 0x00124A49
		public override int GetEra(DateTime time)
		{
			HijriCalendar.CheckTicksRange(time.Ticks);
			return HijriCalendar.HijriEra;
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.HijriCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в классе <see cref="T:System.Globalization.HijriCalendar" />.</returns>
		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x0012685C File Offset: 0x00124A5C
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					HijriCalendar.HijriEra
				};
			}
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 12, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005700 RID: 22272 RVA: 0x0012686C File Offset: 0x00124A6C
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x06005701 RID: 22273 RVA: 0x0012687C File Offset: 0x00124A7C
		public override int GetMonthsInYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return 12;
		}

		/// <summary>Возвращает значение года в заданном <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x06005702 RID: 22274 RVA: 0x00126887 File Offset: 0x00124A87
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Определяет, является ли указанный день високосным.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 30, обозначающее день.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="month" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="day" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x06005703 RID: 22275 RVA: 0x00126898 File Offset: 0x00124A98
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Day must be between 1 and {0} for month {1}."), daysInMonth, month));
			}
			return this.IsLeapYear(year, era) && month == 12 && day == 30;
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра. Следует задать <see cref="F:System.Globalization.Calendar.CurrentEra" /> или <see cref="F:System.Globalization.HijriCalendar.HijriEra" />.</param>
		/// <returns>Всегда 0, так как тип <see cref="T:System.Globalization.HijriCalendar" /> не поддерживает понятие високосного года.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> меньше года 1 или больше года 9666 по исламскому календарю.  
		///
		/// или - 
		/// Свойству <paramref name="era" /> задано значение, отличное от <see cref="F:System.Globalization.Calendar.CurrentEra" /> или <see cref="F:System.Globalization.HijriCalendar.HijriEra" />.</exception>
		// Token: 0x06005704 RID: 22276 RVA: 0x001268FA File Offset: 0x00124AFA
		[ComVisible(false)]
		public override int GetLeapMonth(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return 0;
		}

		/// <summary>Определяет, является ли указанный месяц указанных года и эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Этот метод всегда возвращает значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="month" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x06005705 RID: 22277 RVA: 0x00126904 File Offset: 0x00124B04
		public override bool IsLeapMonth(int year, int month, int era)
		{
			HijriCalendar.CheckYearMonthRange(year, month, era);
			return false;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x06005706 RID: 22278 RVA: 0x0012690F File Offset: 0x00124B0F
		public override bool IsLeapYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return (year * 11 + 14) % 30 < 11;
		}

		/// <summary>Возвращает структуру <see cref="T:System.DateTime" /> с заданными значениями даты, времени и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 30, обозначающее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="month" /> находится за пределами диапазона, поддерживаемого этим календарем.  
		///
		/// или - 
		/// <paramref name="day" /> находится за пределами диапазона, поддерживаемого этим календарем.  
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
		/// Параметр <paramref name="millisecond" /> меньше нуля или больше 999.</exception>
		// Token: 0x06005707 RID: 22279 RVA: 0x00126928 File Offset: 0x00124B28
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Day must be between 1 and {0} for month {1}."), daysInMonth, month));
			}
			long absoluteDateHijri = this.GetAbsoluteDateHijri(year, month, day);
			if (absoluteDateHijri >= 0L)
			{
				return new DateTime(absoluteDateHijri * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этот календарь доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в наборе операций меньше 100 или больше 9666.</exception>
		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x001269B1 File Offset: 0x00124BB1
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x001269D8 File Offset: 0x00124BD8
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 1451);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9666)
				{
					throw new ArgumentOutOfRangeException("value", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 99, 9666));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначное представление с использованием свойства <see cref="P:System.Globalization.HijriCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, содержащее четырехразрядное представление <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x0600570A RID: 22282 RVA: 0x00126A30 File Offset: 0x00124C30
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
			if (year > 9666)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, 9666));
			}
			return year;
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x0400362A RID: 13866
		public static readonly int HijriEra = 1;

		// Token: 0x0400362B RID: 13867
		internal const int DatePartYear = 0;

		// Token: 0x0400362C RID: 13868
		internal const int DatePartDayOfYear = 1;

		// Token: 0x0400362D RID: 13869
		internal const int DatePartMonth = 2;

		// Token: 0x0400362E RID: 13870
		internal const int DatePartDay = 3;

		// Token: 0x0400362F RID: 13871
		internal const int MinAdvancedHijri = -2;

		// Token: 0x04003630 RID: 13872
		internal const int MaxAdvancedHijri = 2;

		// Token: 0x04003631 RID: 13873
		internal static readonly int[] HijriMonthDays = new int[]
		{
			0,
			30,
			59,
			89,
			118,
			148,
			177,
			207,
			236,
			266,
			295,
			325,
			355
		};

		// Token: 0x04003632 RID: 13874
		private const string HijriAdvanceRegKeyEntry = "AddHijriDate";

		// Token: 0x04003633 RID: 13875
		private int m_HijriAdvance = int.MinValue;

		// Token: 0x04003634 RID: 13876
		internal const int MaxCalendarYear = 9666;

		// Token: 0x04003635 RID: 13877
		internal const int MaxCalendarMonth = 4;

		// Token: 0x04003636 RID: 13878
		internal const int MaxCalendarDay = 3;

		// Token: 0x04003637 RID: 13879
		internal static readonly DateTime calendarMinValue = new DateTime(622, 7, 18);

		// Token: 0x04003638 RID: 13880
		internal static readonly DateTime calendarMaxValue = DateTime.MaxValue;

		// Token: 0x04003639 RID: 13881
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1451;
	}
}
