using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Представляет календарь, в котором время разбивается по месяцам, дням, годам и эрам, а дни основаны на солнечных и лунных циклах.</summary>
	// Token: 0x02000986 RID: 2438
	[ComVisible(true)]
	[Serializable]
	public abstract class EastAsianLunisolarCalendar : Calendar
	{
		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.LunisolarCalendar" />.</returns>
		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x000221D2 File Offset: 0x000203D2
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunisolarCalendar;
			}
		}

		/// <summary>Рассчитывает год в шестидесятилетнем периоде, соответствующий указанной дате.</summary>
		/// <param name="time">Класс <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Число от 1 до 60 в шестидесятилетнем периоде, соответствующее параметру <paramref name="date" />.</returns>
		// Token: 0x0600564F RID: 22095 RVA: 0x00123980 File Offset: 0x00121B80
		public virtual int GetSexagenaryYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.TimeToLunar(time, ref num, ref num2, ref num3);
			return (num - 4) % 60 + 1;
		}

		/// <summary>Расчет небесного ствола указанного года в шестидесятилетнем периоде.</summary>
		/// <param name="sexagenaryYear">Целое число от 1 до 60, представляющее год в шестидесятилетнем периоде.</param>
		/// <returns>Число в диапазоне от 1 до 10.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="sexagenaryYear" /> имеет значение меньше 1 или больше 60.</exception>
		// Token: 0x06005650 RID: 22096 RVA: 0x001239B8 File Offset: 0x00121BB8
		public int GetCelestialStem(int sexagenaryYear)
		{
			if (sexagenaryYear < 1 || sexagenaryYear > 60)
			{
				throw new ArgumentOutOfRangeException("sexagenaryYear", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					60
				}));
			}
			return (sexagenaryYear - 1) % 10 + 1;
		}

		/// <summary>Расчет земной ветви указанного года в шестидесятилетнем периоде.</summary>
		/// <param name="sexagenaryYear">Целое число от 1 до 60, представляющее год в шестидесятилетнем периоде.</param>
		/// <returns>Целое число в диапазоне от 1 до 12.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="sexagenaryYear" /> имеет значение меньше 1 или больше 60.</exception>
		// Token: 0x06005651 RID: 22097 RVA: 0x00123A04 File Offset: 0x00121C04
		public int GetTerrestrialBranch(int sexagenaryYear)
		{
			if (sexagenaryYear < 1 || sexagenaryYear > 60)
			{
				throw new ArgumentOutOfRangeException("sexagenaryYear", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					1,
					60
				}));
			}
			return (sexagenaryYear - 1) % 12 + 1;
		}

		// Token: 0x06005652 RID: 22098
		internal abstract int GetYearInfo(int LunarYear, int Index);

		// Token: 0x06005653 RID: 22099
		internal abstract int GetYear(int year, DateTime time);

		// Token: 0x06005654 RID: 22100
		internal abstract int GetGregorianYear(int year, int era);

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06005655 RID: 22101
		internal abstract int MinCalendarYear { get; }

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06005656 RID: 22102
		internal abstract int MaxCalendarYear { get; }

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06005657 RID: 22103
		internal abstract EraInfo[] CalEraInfo { get; }

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06005658 RID: 22104
		internal abstract DateTime MinDate { get; }

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06005659 RID: 22105
		internal abstract DateTime MaxDate { get; }

		// Token: 0x0600565A RID: 22106 RVA: 0x00123A50 File Offset: 0x00121C50
		internal int MinEraCalendarYear(int era)
		{
			EraInfo[] calEraInfo = this.CalEraInfo;
			if (calEraInfo == null)
			{
				return this.MinCalendarYear;
			}
			if (era == 0)
			{
				era = this.CurrentEraValue;
			}
			if (era == this.GetEra(this.MinDate))
			{
				return this.GetYear(this.MinCalendarYear, this.MinDate);
			}
			for (int i = 0; i < calEraInfo.Length; i++)
			{
				if (era == calEraInfo[i].era)
				{
					return calEraInfo[i].minEraYear;
				}
			}
			throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00123AD4 File Offset: 0x00121CD4
		internal int MaxEraCalendarYear(int era)
		{
			EraInfo[] calEraInfo = this.CalEraInfo;
			if (calEraInfo == null)
			{
				return this.MaxCalendarYear;
			}
			if (era == 0)
			{
				era = this.CurrentEraValue;
			}
			if (era == this.GetEra(this.MaxDate))
			{
				return this.GetYear(this.MaxCalendarYear, this.MaxDate);
			}
			for (int i = 0; i < calEraInfo.Length; i++)
			{
				if (era == calEraInfo[i].era)
				{
					return calEraInfo[i].maxEraYear;
				}
			}
			throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00122038 File Offset: 0x00120238
		internal EastAsianLunisolarCalendar()
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x00123B58 File Offset: 0x00121D58
		internal void CheckTicksRange(long ticks)
		{
			if (ticks < this.MinSupportedDateTime.Ticks || ticks > this.MaxSupportedDateTime.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), this.MinSupportedDateTime, this.MaxSupportedDateTime));
			}
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x00123BBC File Offset: 0x00121DBC
		internal void CheckEraRange(int era)
		{
			if (era == 0)
			{
				era = this.CurrentEraValue;
			}
			if (era < this.GetEra(this.MinDate) || era > this.GetEra(this.MaxDate))
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x00123BFC File Offset: 0x00121DFC
		internal int CheckYearRange(int year, int era)
		{
			this.CheckEraRange(era);
			year = this.GetGregorianYear(year, era);
			if (year < this.MinCalendarYear || year > this.MaxCalendarYear)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					this.MinEraCalendarYear(era),
					this.MaxEraCalendarYear(era)
				}));
			}
			return year;
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x00123C68 File Offset: 0x00121E68
		internal int CheckYearMonthRange(int year, int month, int era)
		{
			year = this.CheckYearRange(year, era);
			if (month == 13 && this.GetYearInfo(year, 0) == 0)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			if (month < 1 || month > 13)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			return year;
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x00123CC4 File Offset: 0x00121EC4
		internal int InternalGetDaysInMonth(int year, int month)
		{
			int num = 32768;
			num >>= month - 1;
			int result;
			if ((this.GetYearInfo(year, 3) & num) == 0)
			{
				result = 29;
			}
			else
			{
				result = 30;
			}
			return result;
		}

		/// <summary>Рассчитывает количество дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 12 в обычном году или от 1 до 13 в високосном году, представляющее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005662 RID: 22114 RVA: 0x00123CF5 File Offset: 0x00121EF5
		public override int GetDaysInMonth(int year, int month, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			return this.InternalGetDaysInMonth(year, month);
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00123D0A File Offset: 0x00121F0A
		private static int GregorianIsLeapYear(int y)
		{
			if (y % 4 != 0)
			{
				return 0;
			}
			if (y % 100 != 0)
			{
				return 1;
			}
			if (y % 400 == 0)
			{
				return 1;
			}
			return 0;
		}

		/// <summary>Возвращает структуру <see cref="T:System.DateTime" /> с заданными значениями даты, времени и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, представляющее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, представляющее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Возвращает структуру <see cref="T:System.DateTime" /> с заданными значениями даты, времени и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" />, <paramref name="second" />, <paramref name="millisecond" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005664 RID: 22116 RVA: 0x00123D28 File Offset: 0x00121F28
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int num = this.InternalGetDaysInMonth(year, month);
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", Environment.GetResourceString("Day must be between 1 and {0} for month {1}.", new object[]
				{
					num,
					month
				}));
			}
			int year2 = 0;
			int month2 = 0;
			int day2 = 0;
			if (this.LunarToGregorian(year, month, day, ref year2, ref month2, ref day2))
			{
				return new DateTime(year2, month2, day2, hour, minute, second, millisecond);
			}
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Year, Month, and Day parameters describe an un-representable DateTime."));
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00123DB8 File Offset: 0x00121FB8
		internal void GregorianToLunar(int nSYear, int nSMonth, int nSDate, ref int nLYear, ref int nLMonth, ref int nLDate)
		{
			int i = ((EastAsianLunisolarCalendar.GregorianIsLeapYear(nSYear) == 1) ? EastAsianLunisolarCalendar.DaysToMonth366[nSMonth - 1] : EastAsianLunisolarCalendar.DaysToMonth365[nSMonth - 1]) + nSDate;
			nLYear = nSYear;
			int yearInfo;
			int yearInfo2;
			if (nLYear == this.MaxCalendarYear + 1)
			{
				nLYear--;
				i += ((EastAsianLunisolarCalendar.GregorianIsLeapYear(nLYear) == 1) ? 366 : 365);
				yearInfo = this.GetYearInfo(nLYear, 1);
				yearInfo2 = this.GetYearInfo(nLYear, 2);
			}
			else
			{
				yearInfo = this.GetYearInfo(nLYear, 1);
				yearInfo2 = this.GetYearInfo(nLYear, 2);
				if (nSMonth < yearInfo || (nSMonth == yearInfo && nSDate < yearInfo2))
				{
					nLYear--;
					i += ((EastAsianLunisolarCalendar.GregorianIsLeapYear(nLYear) == 1) ? 366 : 365);
					yearInfo = this.GetYearInfo(nLYear, 1);
					yearInfo2 = this.GetYearInfo(nLYear, 2);
				}
			}
			i -= EastAsianLunisolarCalendar.DaysToMonth365[yearInfo - 1];
			i -= yearInfo2 - 1;
			int num = 32768;
			int yearInfo3 = this.GetYearInfo(nLYear, 3);
			int num2 = ((yearInfo3 & num) != 0) ? 30 : 29;
			nLMonth = 1;
			while (i > num2)
			{
				i -= num2;
				nLMonth++;
				num >>= 1;
				num2 = (((yearInfo3 & num) != 0) ? 30 : 29);
			}
			nLDate = i;
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00123EF0 File Offset: 0x001220F0
		internal bool LunarToGregorian(int nLYear, int nLMonth, int nLDate, ref int nSolarYear, ref int nSolarMonth, ref int nSolarDay)
		{
			if (nLDate < 1 || nLDate > 30)
			{
				return false;
			}
			int num = nLDate - 1;
			for (int i = 1; i < nLMonth; i++)
			{
				num += this.InternalGetDaysInMonth(nLYear, i);
			}
			int yearInfo = this.GetYearInfo(nLYear, 1);
			int yearInfo2 = this.GetYearInfo(nLYear, 2);
			int num2 = EastAsianLunisolarCalendar.GregorianIsLeapYear(nLYear);
			int[] array = (num2 == 1) ? EastAsianLunisolarCalendar.DaysToMonth366 : EastAsianLunisolarCalendar.DaysToMonth365;
			nSolarDay = yearInfo2;
			if (yearInfo > 1)
			{
				nSolarDay += array[yearInfo - 1];
			}
			nSolarDay += num;
			if (nSolarDay > num2 + 365)
			{
				nSolarYear = nLYear + 1;
				nSolarDay -= num2 + 365;
			}
			else
			{
				nSolarYear = nLYear;
			}
			nSolarMonth = 1;
			while (nSolarMonth < 12 && array[nSolarMonth] < nSolarDay)
			{
				nSolarMonth++;
			}
			nSolarDay -= array[nSolarMonth - 1];
			return true;
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00123FC8 File Offset: 0x001221C8
		internal DateTime LunarToTime(DateTime time, int year, int month, int day)
		{
			int year2 = 0;
			int month2 = 0;
			int day2 = 0;
			this.LunarToGregorian(year, month, day, ref year2, ref month2, ref day2);
			return GregorianCalendar.GetDefaultInstance().ToDateTime(year2, month2, day2, time.Hour, time.Minute, time.Second, time.Millisecond);
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00124018 File Offset: 0x00122218
		internal void TimeToLunar(DateTime time, ref int year, ref int month, ref int day)
		{
			Calendar defaultInstance = GregorianCalendar.GetDefaultInstance();
			int year2 = defaultInstance.GetYear(time);
			int month2 = defaultInstance.GetMonth(time);
			int dayOfMonth = defaultInstance.GetDayOfMonth(time);
			this.GregorianToLunar(year2, month2, dayOfMonth, ref year, ref month, ref day);
		}

		/// <summary>Рассчитывает дату через определенное количество месяцев от указанной даты.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому следует добавить параметр <paramref name="months" />.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Новый объект <see cref="T:System.DateTime" />, которые является суммой указанного количества месяцев и параметра <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение находится вне допустимого диапазона <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="months" /> меньше –120 000 или больше 120 000.  
		///
		/// или - 
		/// Значение <paramref name="time" /> меньше <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> или больше <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x06005669 RID: 22121 RVA: 0x00124054 File Offset: 0x00122254
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					-120000,
					120000
				}));
			}
			this.CheckTicksRange(time.Ticks);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.TimeToLunar(time, ref num, ref num2, ref num3);
			int i = num2 + months;
			if (i > 0)
			{
				int num4 = this.InternalIsLeapYear(num) ? 13 : 12;
				while (i - num4 > 0)
				{
					i -= num4;
					num++;
					num4 = (this.InternalIsLeapYear(num) ? 13 : 12);
				}
				num2 = i;
			}
			else
			{
				while (i <= 0)
				{
					int num5 = this.InternalIsLeapYear(num - 1) ? 13 : 12;
					i += num5;
					num--;
				}
				num2 = i;
			}
			int num6 = this.InternalGetDaysInMonth(num, num2);
			if (num3 > num6)
			{
				num3 = num6;
			}
			DateTime result = this.LunarToTime(time, num, num2, num3);
			Calendar.CheckAddResult(result.Ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return result;
		}

		/// <summary>Рассчитывает дату через определенное количество лет от указанной даты.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому следует добавить параметр <paramref name="years" />.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Новый объект <see cref="T:System.DateTime" />, которые является суммой указанного количества лет и параметра <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение находится вне допустимого диапазона <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="time" /> меньше <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> или больше <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x0600566A RID: 22122 RVA: 0x00124160 File Offset: 0x00122360
		public override DateTime AddYears(DateTime time, int years)
		{
			this.CheckTicksRange(time.Ticks);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.TimeToLunar(time, ref num, ref num2, ref num3);
			num += years;
			if (num2 == 13 && !this.InternalIsLeapYear(num))
			{
				num2 = 12;
				num3 = this.InternalGetDaysInMonth(num, num2);
			}
			int num4 = this.InternalGetDaysInMonth(num, num2);
			if (num3 > num4)
			{
				num3 = num4;
			}
			DateTime result = this.LunarToTime(time, num, num2, num3);
			Calendar.CheckAddResult(result.Ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return result;
		}

		/// <summary>Рассчитывает день года из заданной даты.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 354 в обычном году или от 1 до 384 в високосном году, представляющее день года в заданном параметре <paramref name="time" />.</returns>
		// Token: 0x0600566B RID: 22123 RVA: 0x001241E0 File Offset: 0x001223E0
		public override int GetDayOfYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int year = 0;
			int num = 0;
			int num2 = 0;
			this.TimeToLunar(time, ref year, ref num, ref num2);
			for (int i = 1; i < num; i++)
			{
				num2 += this.InternalGetDaysInMonth(year, i);
			}
			return num2;
		}

		/// <summary>Рассчитывает день месяца из заданной даты.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 31, обозначающее день месяца в заданном параметре <paramref name="time" />.</returns>
		// Token: 0x0600566C RID: 22124 RVA: 0x00124228 File Offset: 0x00122428
		public override int GetDayOfMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num = 0;
			int num2 = 0;
			int result = 0;
			this.TimeToLunar(time, ref num, ref num2, ref result);
			return result;
		}

		/// <summary>Рассчитывает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x0600566D RID: 22125 RVA: 0x00124258 File Offset: 0x00122458
		public override int GetDaysInYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			int num = 0;
			int num2 = this.InternalIsLeapYear(year) ? 13 : 12;
			while (num2 != 0)
			{
				num += this.InternalGetDaysInMonth(year, num2--);
			}
			return num;
		}

		/// <summary>Возвращает номер месяца из заданной даты.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 13, обозначающее месяц в заданном параметре <paramref name="time" />.</returns>
		// Token: 0x0600566E RID: 22126 RVA: 0x00124298 File Offset: 0x00122498
		public override int GetMonth(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int num = 0;
			int result = 0;
			int num2 = 0;
			this.TimeToLunar(time, ref num, ref result, ref num2);
			return result;
		}

		/// <summary>Возвращает год из заданной даты.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x0600566F RID: 22127 RVA: 0x001242C8 File Offset: 0x001224C8
		public override int GetYear(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			int year = 0;
			int num = 0;
			int num2 = 0;
			this.TimeToLunar(time, ref year, ref num, ref num2);
			return this.GetYear(year, time);
		}

		/// <summary>Рассчитывает день недели из заданной даты.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Одно из значений <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном параметре <paramref name="time" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="time" /> меньше <see cref="P:System.Globalization.Calendar.MinSupportedDateTime" /> или больше <see cref="P:System.Globalization.Calendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x06005670 RID: 22128 RVA: 0x001242FD File Offset: 0x001224FD
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			this.CheckTicksRange(time.Ticks);
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		/// <summary>Рассчитывает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Число месяцев в указанном году указанной эры. Возвращенное значение равно 12 месяцам для обычного года или 13 для високосного.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005671 RID: 22129 RVA: 0x00124323 File Offset: 0x00122523
		public override int GetMonthsInYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			if (!this.InternalIsLeapYear(year))
			{
				return 12;
			}
			return 13;
		}

		/// <summary>Определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, представляющее месяц.</param>
		/// <param name="day">Целое число от 1 до 31, представляющее день.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005672 RID: 22130 RVA: 0x00124340 File Offset: 0x00122540
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int num = this.InternalGetDaysInMonth(year, month);
			if (day < 1 || day > num)
			{
				throw new ArgumentOutOfRangeException("day", Environment.GetResourceString("Day must be between 1 and {0} for month {1}.", new object[]
				{
					num,
					month
				}));
			}
			int yearInfo = this.GetYearInfo(year, 0);
			return yearInfo != 0 && month == yearInfo + 1;
		}

		/// <summary>Определяет, является ли указанный месяц указанных года и эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, представляющее месяц.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если предоставленный параметр <paramref name="month" /> является високосным месяцем; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005673 RID: 22131 RVA: 0x001243AC File Offset: 0x001225AC
		public override bool IsLeapMonth(int year, int month, int era)
		{
			year = this.CheckYearMonthRange(year, month, era);
			int yearInfo = this.GetYearInfo(year, 0);
			return yearInfo != 0 && month == yearInfo + 1;
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Положительное целое число от 1 до 13, указывающее високосный месяц в указанном году указанной эры.  
		///
		/// или - 
		/// Нуль, если этот календарь не поддерживает високосные месяцы, или если в параметрах <paramref name="year" /> и <paramref name="era" /> не указан високосный год.</returns>
		// Token: 0x06005674 RID: 22132 RVA: 0x001243D8 File Offset: 0x001225D8
		public override int GetLeapMonth(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			int yearInfo = this.GetYearInfo(year, 0);
			if (yearInfo > 0)
			{
				return yearInfo + 1;
			}
			return 0;
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00124401 File Offset: 0x00122601
		internal bool InternalIsLeapYear(int year)
		{
			return this.GetYearInfo(year, 0) != 0;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x06005676 RID: 22134 RVA: 0x0012440E File Offset: 0x0012260E
		public override bool IsLeapYear(int year, int era)
		{
			year = this.CheckYearRange(year, era);
			return this.InternalIsLeapYear(year);
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Globalization.EastAsianLunisolarCalendar" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в наборе операций меньше 99 или больше наибольшего поддерживаемого года в текущем календаре.</exception>
		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x00124421 File Offset: 0x00122621
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x00124458 File Offset: 0x00122658
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.BaseCalendarID, this.GetYear(new DateTime(2029, 1, 1)));
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > this.MaxCalendarYear)
				{
					throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
					{
						99,
						this.MaxCalendarYear
					}));
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует указанный год в четырехзначный год.</summary>
		/// <param name="year">Двузначное или четырехзначное целое число, представляющее подлежащий преобразованию год.</param>
		/// <returns>Целое число, представляющее четырехразрядное значение параметра <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> находится за пределами диапазона, поддерживаемого этим календарем.</exception>
		// Token: 0x06005679 RID: 22137 RVA: 0x001244B3 File Offset: 0x001226B3
		public override int ToFourDigitYear(int year)
		{
			if (year < 0)
			{
				throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("Non-negative number required."));
			}
			year = base.ToFourDigitYear(year);
			this.CheckYearRange(year, 0);
			return year;
		}

		// Token: 0x040035D3 RID: 13779
		internal const int LeapMonth = 0;

		// Token: 0x040035D4 RID: 13780
		internal const int Jan1Month = 1;

		// Token: 0x040035D5 RID: 13781
		internal const int Jan1Date = 2;

		// Token: 0x040035D6 RID: 13782
		internal const int nDaysPerMonth = 3;

		// Token: 0x040035D7 RID: 13783
		internal static readonly int[] DaysToMonth365 = new int[]
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
			334
		};

		// Token: 0x040035D8 RID: 13784
		internal static readonly int[] DaysToMonth366 = new int[]
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
			335
		};

		// Token: 0x040035D9 RID: 13785
		internal const int DatePartYear = 0;

		// Token: 0x040035DA RID: 13786
		internal const int DatePartDayOfYear = 1;

		// Token: 0x040035DB RID: 13787
		internal const int DatePartMonth = 2;

		// Token: 0x040035DC RID: 13788
		internal const int DatePartDay = 3;

		// Token: 0x040035DD RID: 13789
		internal const int MaxCalendarMonth = 13;

		// Token: 0x040035DE RID: 13790
		internal const int MaxCalendarDay = 30;

		// Token: 0x040035DF RID: 13791
		private const int DEFAULT_GREGORIAN_TWO_DIGIT_YEAR_MAX = 2029;
	}
}
