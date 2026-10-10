using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Представляет еврейский календарь.</summary>
	// Token: 0x0200098C RID: 2444
	[ComVisible(true)]
	[Serializable]
	public class HebrewCalendar : Calendar
	{
		/// <summary>Возвращает самые ранние дату и время, поддерживаемые типом <see cref="T:System.Globalization.HebrewCalendar" />.</summary>
		/// <returns>Самые ранние дата и время, поддерживаемые типом <see cref="T:System.Globalization.HebrewCalendar" />, что эквивалентно первому мгновению 1 января 1583 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060056C1 RID: 22209 RVA: 0x00125946 File Offset: 0x00123B46
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return HebrewCalendar.calendarMinValue;
			}
		}

		/// <summary>Возвращает самые последние дату и время, поддерживаемые этим типом <see cref="T:System.Globalization.HebrewCalendar" />.</summary>
		/// <returns>Самые последние дата и время, поддерживаемые типом <see cref="T:System.Globalization.HebrewCalendar" />, что эквивалентно последнему мгновению 29 сентября 2239 года нашей эры. по григорианскому календарю.</returns>
		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x0012594D File Offset: 0x00123B4D
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return HebrewCalendar.calendarMaxValue;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли текущий календарь солнечным, лунным или сочетанием и того, и другого.</summary>
		/// <returns>Всегда возвращает значение <see cref="F:System.Globalization.CalendarAlgorithmType.LunisolarCalendar" />.</returns>
		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060056C3 RID: 22211 RVA: 0x000221D2 File Offset: 0x000203D2
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunisolarCalendar;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060056C5 RID: 22213 RVA: 0x00047F71 File Offset: 0x00046171
		internal override int ID
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00125954 File Offset: 0x00123B54
		private static void CheckHebrewYearValue(int y, int era, string varName)
		{
			HebrewCalendar.CheckEraRange(era);
			if (y > 5999 || y < 5343)
			{
				throw new ArgumentOutOfRangeException(varName, string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 5343, 5999));
			}
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x001259A8 File Offset: 0x00123BA8
		private void CheckHebrewMonthValue(int year, int month, int era)
		{
			int monthsInYear = this.GetMonthsInYear(year, era);
			if (month < 1 || month > monthsInYear)
			{
				throw new ArgumentOutOfRangeException("month", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, monthsInYear));
			}
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x001259F4 File Offset: 0x00123BF4
		private void CheckHebrewDayValue(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 1, daysInMonth));
			}
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00125A3F File Offset: 0x00123C3F
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != HebrewCalendar.HebrewEra)
			{
				throw new ArgumentOutOfRangeException("era", Environment.GetResourceString("Era value was not valid."));
			}
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00125A64 File Offset: 0x00123C64
		private static void CheckTicksRange(long ticks)
		{
			if (ticks < HebrewCalendar.calendarMinValue.Ticks || ticks > HebrewCalendar.calendarMaxValue.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive."), HebrewCalendar.calendarMinValue, HebrewCalendar.calendarMaxValue));
			}
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00125ABE File Offset: 0x00123CBE
		internal static int GetResult(HebrewCalendar.__DateBuffer result, int part)
		{
			switch (part)
			{
			case 0:
				return result.year;
			case 2:
				return result.month;
			case 3:
				return result.day;
			}
			throw new InvalidOperationException(Environment.GetResourceString("Internal Error in DateTime and Calendar operations."));
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00125AFC File Offset: 0x00123CFC
		internal static int GetLunarMonthDay(int gregorianYear, HebrewCalendar.__DateBuffer lunarDate)
		{
			int num = gregorianYear - 1583;
			if (num < 0 || num > 656)
			{
				throw new ArgumentOutOfRangeException("gregorianYear");
			}
			num *= 2;
			lunarDate.day = HebrewCalendar.HebrewTable[num];
			int result = HebrewCalendar.HebrewTable[num + 1];
			int day = lunarDate.day;
			if (day != 0)
			{
				switch (day)
				{
				case 30:
					lunarDate.month = 3;
					break;
				case 31:
					lunarDate.month = 5;
					lunarDate.day = 2;
					break;
				case 32:
					lunarDate.month = 5;
					lunarDate.day = 3;
					break;
				case 33:
					lunarDate.month = 3;
					lunarDate.day = 29;
					break;
				default:
					lunarDate.month = 4;
					break;
				}
			}
			else
			{
				lunarDate.month = 5;
				lunarDate.day = 1;
			}
			return result;
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00125BBC File Offset: 0x00123DBC
		internal virtual int GetDatePart(long ticks, int part)
		{
			HebrewCalendar.CheckTicksRange(ticks);
			DateTime dateTime = new DateTime(ticks);
			int year = dateTime.Year;
			int month = dateTime.Month;
			int day = dateTime.Day;
			HebrewCalendar.__DateBuffer _DateBuffer = new HebrewCalendar.__DateBuffer();
			_DateBuffer.year = year + 3760;
			int num = HebrewCalendar.GetLunarMonthDay(year, _DateBuffer);
			HebrewCalendar.__DateBuffer _DateBuffer2 = new HebrewCalendar.__DateBuffer();
			_DateBuffer2.year = _DateBuffer.year;
			_DateBuffer2.month = _DateBuffer.month;
			_DateBuffer2.day = _DateBuffer.day;
			long absoluteDate = GregorianCalendar.GetAbsoluteDate(year, month, day);
			if (month == 1 && day == 1)
			{
				return HebrewCalendar.GetResult(_DateBuffer2, part);
			}
			long num2 = absoluteDate - GregorianCalendar.GetAbsoluteDate(year, 1, 1);
			if (num2 + (long)_DateBuffer.day <= (long)HebrewCalendar.LunarMonthLen[num, _DateBuffer.month])
			{
				_DateBuffer2.day += (int)num2;
				return HebrewCalendar.GetResult(_DateBuffer2, part);
			}
			_DateBuffer2.month++;
			_DateBuffer2.day = 1;
			num2 -= (long)(HebrewCalendar.LunarMonthLen[num, _DateBuffer.month] - _DateBuffer.day);
			if (num2 > 1L)
			{
				while (num2 > (long)HebrewCalendar.LunarMonthLen[num, _DateBuffer2.month])
				{
					long num3 = num2;
					int[,] lunarMonthLen = HebrewCalendar.LunarMonthLen;
					int num4 = num;
					HebrewCalendar.__DateBuffer _DateBuffer3 = _DateBuffer2;
					int month2 = _DateBuffer3.month;
					_DateBuffer3.month = month2 + 1;
					num2 = num3 - (long)lunarMonthLen[num4, month2];
					if (_DateBuffer2.month > 13 || HebrewCalendar.LunarMonthLen[num, _DateBuffer2.month] == 0)
					{
						_DateBuffer2.year++;
						num = HebrewCalendar.HebrewTable[(year + 1 - 1583) * 2 + 1];
						_DateBuffer2.month = 1;
					}
				}
				_DateBuffer2.day += (int)(num2 - 1L);
			}
			return HebrewCalendar.GetResult(_DateBuffer2, part);
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отличающееся от заданного значения типа <see cref="T:System.DateTime" /> на заданное число месяцев.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому следует добавить параметр <paramref name="months" />.</param>
		/// <param name="months">Добавляемое число месяцев.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа месяцев к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="months" /> имеет значение меньше –120 000 или больше 120 000.</exception>
		// Token: 0x060056CE RID: 22222 RVA: 0x00125D88 File Offset: 0x00123F88
		public override DateTime AddMonths(DateTime time, int months)
		{
			DateTime result;
			try
			{
				int num = this.GetDatePart(time.Ticks, 0);
				int datePart = this.GetDatePart(time.Ticks, 2);
				int num2 = this.GetDatePart(time.Ticks, 3);
				int i;
				if (months >= 0)
				{
					int monthsInYear;
					for (i = datePart + months; i > (monthsInYear = this.GetMonthsInYear(num, 0)); i -= monthsInYear)
					{
						num++;
					}
				}
				else if ((i = datePart + months) <= 0)
				{
					months = -months;
					months -= datePart;
					num--;
					int monthsInYear;
					while (months > (monthsInYear = this.GetMonthsInYear(num, 0)))
					{
						num--;
						months -= monthsInYear;
					}
					monthsInYear = this.GetMonthsInYear(num, 0);
					i = monthsInYear - months;
				}
				int daysInMonth = this.GetDaysInMonth(num, i);
				if (num2 > daysInMonth)
				{
					num2 = daysInMonth;
				}
				result = this.ToDateTime(num, i, num2, 0, 0, 0, 0);
				result = new DateTime(result.Ticks + time.Ticks % 864000000000L);
			}
			catch (ArgumentException)
			{
				throw new ArgumentOutOfRangeException("months", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Value to add was out of range."), Array.Empty<object>()));
			}
			return result;
		}

		/// <summary>Возвращает значение типа <see cref="T:System.DateTime" />, отстающее от заданного значения типа <see cref="T:System.DateTime" /> на заданное число лет.</summary>
		/// <param name="time">Объект <see cref="T:System.DateTime" />, к которому следует добавить параметр <paramref name="years" />.</param>
		/// <param name="years">Добавляемое число лет.</param>
		/// <returns>Объект <see cref="T:System.DateTime" />, полученный добавлением заданного числа лет к заданному объекту <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentException">Полученное значение <see cref="T:System.DateTime" /> находится вне допустимого диапазона.</exception>
		// Token: 0x060056CF RID: 22223 RVA: 0x00125EA0 File Offset: 0x001240A0
		public override DateTime AddYears(DateTime time, int years)
		{
			int num = this.GetDatePart(time.Ticks, 0);
			int num2 = this.GetDatePart(time.Ticks, 2);
			int num3 = this.GetDatePart(time.Ticks, 3);
			num += years;
			HebrewCalendar.CheckHebrewYearValue(num, 0, "years");
			int monthsInYear = this.GetMonthsInYear(num, 0);
			if (num2 > monthsInYear)
			{
				num2 = monthsInYear;
			}
			int daysInMonth = this.GetDaysInMonth(num, num2);
			if (num3 > daysInMonth)
			{
				num3 = daysInMonth;
			}
			long ticks = this.ToDateTime(num, num2, num3, 0, 0, 0, 0).Ticks + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		/// <summary>Возвращает день месяца из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 30, обозначающее день месяца в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056D0 RID: 22224 RVA: 0x00125F4A File Offset: 0x0012414A
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		/// <summary>Возвращает день недели из заданной структуры <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Значение <see cref="T:System.DayOfWeek" />, представляющее день недели в заданном <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060056D1 RID: 22225 RVA: 0x001223C6 File Offset: 0x001205C6
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return (DayOfWeek)(time.Ticks / 864000000000L + 1L) % (DayOfWeek)7;
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00125F5A File Offset: 0x0012415A
		internal static int GetHebrewYearType(int year, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			return HebrewCalendar.HebrewTable[(year - 3760 - 1583) * 2 + 1];
		}

		/// <summary>Возвращает день года в заданном параметре <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 385, обозначающее день года в заданном параметре <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Время, указанное в параметре <paramref name="time" />, предшествует 17 сентября 1583 г. по григорианскому календарю или наступает позже значения, определяемого свойством <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060056D3 RID: 22227 RVA: 0x00125F80 File Offset: 0x00124180
		public override int GetDayOfYear(DateTime time)
		{
			int year = this.GetYear(time);
			DateTime dateTime;
			if (year == 5343)
			{
				dateTime = new DateTime(1582, 9, 27);
			}
			else
			{
				dateTime = this.ToDateTime(year, 1, 1, 0, 0, 0, 0, 0);
			}
			return (int)((time.Ticks - dateTime.Ticks) / 864000000000L) + 1;
		}

		/// <summary>Возвращает число дней в указанном месяце указанных года и эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="Calendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Количество дней в указанном месяце указанных года и эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне диапазона, поддерживаемого текущим объектом <see cref="T:System.Globalization.HebrewCalendar" />.</exception>
		// Token: 0x060056D4 RID: 22228 RVA: 0x00125FDC File Offset: 0x001241DC
		public override int GetDaysInMonth(int year, int month, int era)
		{
			HebrewCalendar.CheckEraRange(era);
			int hebrewYearType = HebrewCalendar.GetHebrewYearType(year, era);
			this.CheckHebrewMonthValue(year, month, era);
			int num = HebrewCalendar.LunarMonthLen[hebrewYearType, month];
			if (num == 0)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("Month must be between one and twelve."));
			}
			return num;
		}

		/// <summary>Возвращает число дней в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Число дней в указанном году указанной эры.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> или <paramref name="era" /> находятся вне диапазона, поддерживаемого текущим объектом <see cref="T:System.Globalization.HebrewCalendar" />.</exception>
		// Token: 0x060056D5 RID: 22229 RVA: 0x00126024 File Offset: 0x00124224
		public override int GetDaysInYear(int year, int era)
		{
			HebrewCalendar.CheckEraRange(era);
			int hebrewYearType = HebrewCalendar.GetHebrewYearType(year, era);
			if (hebrewYearType < 4)
			{
				return 352 + hebrewYearType;
			}
			return 382 + (hebrewYearType - 3);
		}

		/// <summary>Возвращает значение эры из заданного объекта <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее эру в заданном <see cref="T:System.DateTime" />. Возвращаемое значение всегда равно <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" />.</returns>
		// Token: 0x060056D6 RID: 22230 RVA: 0x00126054 File Offset: 0x00124254
		public override int GetEra(DateTime time)
		{
			return HebrewCalendar.HebrewEra;
		}

		/// <summary>Возвращает список эр в классе <see cref="T:System.Globalization.HebrewCalendar" />.</summary>
		/// <returns>Массив целых чисел для представления эр в типе <see cref="T:System.Globalization.HebrewCalendar" />. Возвращенное значение всегда является массивом, содержащим один элемент, равный значению <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" />.</returns>
		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060056D7 RID: 22231 RVA: 0x0012605B File Offset: 0x0012425B
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					HebrewCalendar.HebrewEra
				};
			}
		}

		/// <summary>Возвращает месяц в заданном типе <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число от 1 до 13, обозначающее месяц в заданном объекте <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="time" /> меньше <see cref="P:System.Globalization.HebrewCalendar.MinSupportedDateTime" /> или больше <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060056D8 RID: 22232 RVA: 0x0012606B File Offset: 0x0012426B
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		/// <summary>Возвращает число месяцев в указанном году указанной эры.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Число месяцев в указанном году указанной эры. Возвращенное значение равно 12 месяцам для обычного года или 13 для високосного.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> или <paramref name="era" /> находятся вне диапазона, поддерживаемого текущим объектом <see cref="T:System.Globalization.HebrewCalendar" />.</exception>
		// Token: 0x060056D9 RID: 22233 RVA: 0x0012607B File Offset: 0x0012427B
		public override int GetMonthsInYear(int year, int era)
		{
			if (!this.IsLeapYear(year, era))
			{
				return 12;
			}
			return 13;
		}

		/// <summary>Возвращает значение года из заданного значения <see cref="T:System.DateTime" />.</summary>
		/// <param name="time">
		///   <see cref="T:System.DateTime" />, который требуется прочитать.</param>
		/// <returns>Целое число, представляющее год в заданном значении <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="time" /> находится вне диапазона, поддерживаемого текущим объектом <see cref="T:System.Globalization.HebrewCalendar" />.</exception>
		// Token: 0x060056DA RID: 22234 RVA: 0x0012608C File Offset: 0x0012428C
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		/// <summary>Определяет, является ли указанная дата указанной эры високосным днем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 30, обозначающее день.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный день — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060056DB RID: 22235 RVA: 0x0012609C File Offset: 0x0012429C
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			if (this.IsLeapMonth(year, month, era))
			{
				this.CheckHebrewDayValue(year, month, day, era);
				return true;
			}
			if (this.IsLeapYear(year, 0) && month == 6 && day == 30)
			{
				return true;
			}
			this.CheckHebrewDayValue(year, month, day, era);
			return false;
		}

		/// <summary>Вычисляет високосный месяц для заданных года и эры.</summary>
		/// <param name="year">Год.</param>
		/// <param name="era">Эра. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Положительное целое число от 1 до 13, указывающее високосный месяц в указанном году указанной эры. Возвращается значение 7, если параметры <paramref name="year" /> и <paramref name="era" /> указывают високосный год, или 0, если год не является високосным.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойству <paramref name="era" /> задано значение, отличное от <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.  
		///
		/// или - 
		/// <paramref name="year" /> меньше года 5343 или больше года 5999 по еврейскому календарю.</exception>
		// Token: 0x060056DC RID: 22236 RVA: 0x001260D8 File Offset: 0x001242D8
		public override int GetLeapMonth(int year, int era)
		{
			if (this.IsLeapYear(year, era))
			{
				return 7;
			}
			return 0;
		}

		/// <summary>Определяет, является ли указанный месяц указанного года указанной эры високосным месяцем.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, обозначающее месяц.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный месяц — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" /> или <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060056DD RID: 22237 RVA: 0x001260E7 File Offset: 0x001242E7
		public override bool IsLeapMonth(int year, int month, int era)
		{
			bool flag = this.IsLeapYear(year, era);
			this.CheckHebrewMonthValue(year, month, era);
			return flag && month == 7;
		}

		/// <summary>Определяет, является ли указанный год указанной эры високосным годом.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный год — високосный; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" /> и <paramref name="era" /> находятся вне поддерживаемого диапазона значений данного календаря.</exception>
		// Token: 0x060056DE RID: 22238 RVA: 0x00126103 File Offset: 0x00124303
		public override bool IsLeapYear(int year, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			return (7L * (long)year + 1L) % 19L < 7L;
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00126124 File Offset: 0x00124324
		private static int GetDayDifference(int lunarYearType, int month1, int day1, int month2, int day2)
		{
			if (month1 == month2)
			{
				return day1 - day2;
			}
			bool flag = month1 > month2;
			if (flag)
			{
				int num = month1;
				int num2 = day1;
				month1 = month2;
				day1 = day2;
				month2 = num;
				day2 = num2;
			}
			int num3 = HebrewCalendar.LunarMonthLen[lunarYearType, month1] - day1;
			month1++;
			while (month1 < month2)
			{
				num3 += HebrewCalendar.LunarMonthLen[lunarYearType, month1++];
			}
			num3 += day2;
			if (!flag)
			{
				return -num3;
			}
			return num3;
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x0012618C File Offset: 0x0012438C
		private static DateTime HebrewToGregorian(int hebrewYear, int hebrewMonth, int hebrewDay, int hour, int minute, int second, int millisecond)
		{
			int num = hebrewYear - 3760;
			HebrewCalendar.__DateBuffer _DateBuffer = new HebrewCalendar.__DateBuffer();
			int lunarMonthDay = HebrewCalendar.GetLunarMonthDay(num, _DateBuffer);
			if (hebrewMonth == _DateBuffer.month && hebrewDay == _DateBuffer.day)
			{
				return new DateTime(num, 1, 1, hour, minute, second, millisecond);
			}
			int dayDifference = HebrewCalendar.GetDayDifference(lunarMonthDay, hebrewMonth, hebrewDay, _DateBuffer.month, _DateBuffer.day);
			DateTime dateTime = new DateTime(num, 1, 1);
			return new DateTime(dateTime.Ticks + (long)dayDifference * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
		}

		/// <summary>Возвращает <see cref="T:System.DateTime" /> с заданными значениями даты и времени в указанной эре.</summary>
		/// <param name="year">Целое число, представляющее год.</param>
		/// <param name="month">Целое число от 1 до 13, обозначающее месяц.</param>
		/// <param name="day">Целое число от 1 до 30, обозначающее день.</param>
		/// <param name="hour">Целое число от 0 до 23, представляющее час.</param>
		/// <param name="minute">Целое число от 0 до 59, представляющее минуту.</param>
		/// <param name="second">Целое число от 0 до 59, представляющее секунду.</param>
		/// <param name="millisecond">Целое число от 0 до 999, представляющее миллисекунду.</param>
		/// <param name="era">Целое число, представляющее эру. Укажите <see cref="F:System.Globalization.HebrewCalendar.HebrewEra" /> или <see langword="HebrewCalendar.Eras[Calendar.CurrentEra]" />.</param>
		/// <returns>Объект <see cref="T:System.DateTime" /> с заданными значениями даты и времени в текущей эре.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметры <paramref name="year" />, <paramref name="month" />, <paramref name="day" /> или <paramref name="era" /> находятся вне диапазона, поддерживаемого текущим объектом <see cref="T:System.Globalization.HebrewCalendar" />.  
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
		// Token: 0x060056E1 RID: 22241 RVA: 0x00126218 File Offset: 0x00124418
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			HebrewCalendar.CheckHebrewYearValue(year, era, "year");
			this.CheckHebrewMonthValue(year, month, era);
			this.CheckHebrewDayValue(year, month, day, era);
			DateTime result = HebrewCalendar.HebrewToGregorian(year, month, day, hour, minute, second, millisecond);
			HebrewCalendar.CheckTicksRange(result.Ticks);
			return result;
		}

		/// <summary>Возвращает или задает последний год в диапазоне ста лет, для которого существует двузначное представление года.</summary>
		/// <returns>Последний год в диапазоне ста лет, для которого существует двузначное представление года.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Globalization.HebrewCalendar" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение года еврейского календаря в наборе операций меньше 5343, но не равно 99 или больше 5999.</exception>
		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x00126265 File Offset: 0x00124465
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x0012628C File Offset: 0x0012448C
		public override int TwoDigitYearMax
		{
			get
			{
				if (this.twoDigitYearMax == -1)
				{
					this.twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 5790);
				}
				return this.twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value != 99)
				{
					HebrewCalendar.CheckHebrewYearValue(value, HebrewCalendar.HebrewEra, "value");
				}
				this.twoDigitYearMax = value;
			}
		}

		/// <summary>Преобразует заданный год в четырехзначный с использованием свойства <see cref="P:System.Globalization.HebrewCalendar.TwoDigitYearMax" /> для определения века.</summary>
		/// <param name="year">Двухзначный год с 0 по 99 или четырехзначный год еврейского календаря с 5343 по 5999 год.</param>
		/// <returns>Если параметр <paramref name="year" /> является двухзначным годом, возвращается значение соответствующее четырехзначному году. Если параметр <paramref name="year" /> является четырехзначным годом, возвращается значение соответствующее неизмененному параметру <paramref name="year" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="year" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="year" /> меньше <see cref="P:System.Globalization.HebrewCalendar.MinSupportedDateTime" /> или больше <see cref="P:System.Globalization.HebrewCalendar.MaxSupportedDateTime" />.</exception>
		// Token: 0x060056E4 RID: 22244 RVA: 0x001262B0 File Offset: 0x001244B0
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
			if (year > 5999 || year < 5343)
			{
				throw new ArgumentOutOfRangeException("year", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Valid values are between {0} and {1}, inclusive."), 5343, 5999));
			}
			return year;
		}

		/// <summary>Представляет текущую эру. Это поле является константой.</summary>
		// Token: 0x04003616 RID: 13846
		public static readonly int HebrewEra = 1;

		// Token: 0x04003617 RID: 13847
		internal const int DatePartYear = 0;

		// Token: 0x04003618 RID: 13848
		internal const int DatePartDayOfYear = 1;

		// Token: 0x04003619 RID: 13849
		internal const int DatePartMonth = 2;

		// Token: 0x0400361A RID: 13850
		internal const int DatePartDay = 3;

		// Token: 0x0400361B RID: 13851
		internal const int DatePartDayOfWeek = 4;

		// Token: 0x0400361C RID: 13852
		private const int HebrewYearOf1AD = 3760;

		// Token: 0x0400361D RID: 13853
		private const int FirstGregorianTableYear = 1583;

		// Token: 0x0400361E RID: 13854
		private const int LastGregorianTableYear = 2239;

		// Token: 0x0400361F RID: 13855
		private const int TABLESIZE = 656;

		// Token: 0x04003620 RID: 13856
		private const int MinHebrewYear = 5343;

		// Token: 0x04003621 RID: 13857
		private const int MaxHebrewYear = 5999;

		// Token: 0x04003622 RID: 13858
		private static readonly int[] HebrewTable = new int[]
		{
			7,
			3,
			17,
			3,
			0,
			4,
			11,
			2,
			21,
			6,
			1,
			3,
			13,
			2,
			25,
			4,
			5,
			3,
			16,
			2,
			27,
			6,
			9,
			1,
			20,
			2,
			0,
			6,
			11,
			3,
			23,
			4,
			4,
			2,
			14,
			3,
			27,
			4,
			8,
			2,
			18,
			3,
			28,
			6,
			11,
			1,
			22,
			5,
			2,
			3,
			12,
			3,
			25,
			4,
			6,
			2,
			16,
			3,
			26,
			6,
			8,
			2,
			20,
			1,
			0,
			6,
			11,
			2,
			24,
			4,
			4,
			3,
			15,
			2,
			25,
			6,
			8,
			1,
			19,
			2,
			29,
			6,
			9,
			3,
			22,
			4,
			3,
			2,
			13,
			3,
			25,
			4,
			6,
			3,
			17,
			2,
			27,
			6,
			7,
			3,
			19,
			2,
			31,
			4,
			11,
			3,
			23,
			4,
			5,
			2,
			15,
			3,
			25,
			6,
			6,
			2,
			19,
			1,
			29,
			6,
			10,
			2,
			22,
			4,
			3,
			3,
			14,
			2,
			24,
			6,
			6,
			1,
			17,
			3,
			28,
			5,
			8,
			3,
			20,
			1,
			32,
			5,
			12,
			3,
			22,
			6,
			4,
			1,
			16,
			2,
			26,
			6,
			6,
			3,
			17,
			2,
			0,
			4,
			10,
			3,
			22,
			4,
			3,
			2,
			14,
			3,
			24,
			6,
			5,
			2,
			17,
			1,
			28,
			6,
			9,
			2,
			19,
			3,
			31,
			4,
			13,
			2,
			23,
			6,
			3,
			3,
			15,
			1,
			27,
			5,
			7,
			3,
			17,
			3,
			29,
			4,
			11,
			2,
			21,
			6,
			3,
			1,
			14,
			2,
			25,
			6,
			5,
			3,
			16,
			2,
			28,
			4,
			9,
			3,
			20,
			2,
			0,
			6,
			12,
			1,
			23,
			6,
			4,
			2,
			14,
			3,
			26,
			4,
			8,
			2,
			18,
			3,
			0,
			4,
			10,
			3,
			21,
			5,
			1,
			3,
			13,
			1,
			24,
			5,
			5,
			3,
			15,
			3,
			27,
			4,
			8,
			2,
			19,
			3,
			29,
			6,
			10,
			2,
			22,
			4,
			3,
			3,
			14,
			2,
			26,
			4,
			6,
			3,
			18,
			2,
			28,
			6,
			10,
			1,
			20,
			6,
			2,
			2,
			12,
			3,
			24,
			4,
			5,
			2,
			16,
			3,
			28,
			4,
			8,
			3,
			19,
			2,
			0,
			6,
			12,
			1,
			23,
			5,
			3,
			3,
			14,
			3,
			26,
			4,
			7,
			2,
			17,
			3,
			28,
			6,
			9,
			2,
			21,
			4,
			1,
			3,
			13,
			2,
			25,
			4,
			5,
			3,
			16,
			2,
			27,
			6,
			9,
			1,
			19,
			3,
			0,
			5,
			11,
			3,
			23,
			4,
			4,
			2,
			14,
			3,
			25,
			6,
			7,
			1,
			18,
			2,
			28,
			6,
			9,
			3,
			21,
			4,
			2,
			2,
			12,
			3,
			25,
			4,
			6,
			2,
			16,
			3,
			26,
			6,
			8,
			2,
			20,
			1,
			0,
			6,
			11,
			2,
			22,
			6,
			4,
			1,
			15,
			2,
			25,
			6,
			6,
			3,
			18,
			1,
			29,
			5,
			9,
			3,
			22,
			4,
			2,
			3,
			13,
			2,
			23,
			6,
			4,
			3,
			15,
			2,
			27,
			4,
			7,
			3,
			19,
			2,
			31,
			4,
			11,
			3,
			21,
			6,
			3,
			2,
			15,
			1,
			25,
			6,
			6,
			2,
			17,
			3,
			29,
			4,
			10,
			2,
			20,
			6,
			3,
			1,
			13,
			3,
			24,
			5,
			4,
			3,
			16,
			1,
			27,
			5,
			7,
			3,
			17,
			3,
			0,
			4,
			11,
			2,
			21,
			6,
			1,
			3,
			13,
			2,
			25,
			4,
			5,
			3,
			16,
			2,
			29,
			4,
			9,
			3,
			19,
			6,
			30,
			2,
			13,
			1,
			23,
			6,
			4,
			2,
			14,
			3,
			27,
			4,
			8,
			2,
			18,
			3,
			0,
			4,
			11,
			3,
			22,
			5,
			2,
			3,
			14,
			1,
			26,
			5,
			6,
			3,
			16,
			3,
			28,
			4,
			10,
			2,
			20,
			6,
			30,
			3,
			11,
			2,
			24,
			4,
			4,
			3,
			15,
			2,
			25,
			6,
			8,
			1,
			19,
			2,
			29,
			6,
			9,
			3,
			22,
			4,
			3,
			2,
			13,
			3,
			25,
			4,
			7,
			2,
			17,
			3,
			27,
			6,
			9,
			1,
			21,
			5,
			1,
			3,
			11,
			3,
			23,
			4,
			5,
			2,
			15,
			3,
			25,
			6,
			6,
			2,
			19,
			1,
			29,
			6,
			10,
			2,
			22,
			4,
			3,
			3,
			14,
			2,
			24,
			6,
			6,
			1,
			18,
			2,
			28,
			6,
			8,
			3,
			20,
			4,
			2,
			2,
			12,
			3,
			24,
			4,
			4,
			3,
			16,
			2,
			26,
			6,
			6,
			3,
			17,
			2,
			0,
			4,
			10,
			3,
			22,
			4,
			3,
			2,
			14,
			3,
			24,
			6,
			5,
			2,
			17,
			1,
			28,
			6,
			9,
			2,
			21,
			4,
			1,
			3,
			13,
			2,
			23,
			6,
			5,
			1,
			15,
			3,
			27,
			5,
			7,
			3,
			19,
			1,
			0,
			5,
			10,
			3,
			22,
			4,
			2,
			3,
			13,
			2,
			24,
			6,
			4,
			3,
			15,
			2,
			27,
			4,
			8,
			3,
			20,
			4,
			1,
			2,
			11,
			3,
			22,
			6,
			3,
			2,
			15,
			1,
			25,
			6,
			7,
			2,
			17,
			3,
			29,
			4,
			10,
			2,
			21,
			6,
			1,
			3,
			13,
			1,
			24,
			5,
			5,
			3,
			15,
			3,
			27,
			4,
			8,
			2,
			19,
			6,
			1,
			1,
			12,
			2,
			22,
			6,
			3,
			3,
			14,
			2,
			26,
			4,
			6,
			3,
			18,
			2,
			28,
			6,
			10,
			1,
			20,
			6,
			2,
			2,
			12,
			3,
			24,
			4,
			5,
			2,
			16,
			3,
			28,
			4,
			9,
			2,
			19,
			6,
			30,
			3,
			12,
			1,
			23,
			5,
			3,
			3,
			14,
			3,
			26,
			4,
			7,
			2,
			17,
			3,
			28,
			6,
			9,
			2,
			21,
			4,
			1,
			3,
			13,
			2,
			25,
			4,
			5,
			3,
			16,
			2,
			27,
			6,
			9,
			1,
			19,
			6,
			30,
			2,
			11,
			3,
			23,
			4,
			4,
			2,
			14,
			3,
			27,
			4,
			7,
			3,
			18,
			2,
			28,
			6,
			11,
			1,
			22,
			5,
			2,
			3,
			12,
			3,
			25,
			4,
			6,
			2,
			16,
			3,
			26,
			6,
			8,
			2,
			20,
			4,
			30,
			3,
			11,
			2,
			24,
			4,
			4,
			3,
			15,
			2,
			25,
			6,
			8,
			1,
			18,
			3,
			29,
			5,
			9,
			3,
			22,
			4,
			3,
			2,
			13,
			3,
			23,
			6,
			6,
			1,
			17,
			2,
			27,
			6,
			7,
			3,
			20,
			4,
			1,
			2,
			11,
			3,
			23,
			4,
			5,
			2,
			15,
			3,
			25,
			6,
			6,
			2,
			19,
			1,
			29,
			6,
			10,
			2,
			20,
			6,
			3,
			1,
			14,
			2,
			24,
			6,
			4,
			3,
			17,
			1,
			28,
			5,
			8,
			3,
			20,
			4,
			1,
			3,
			12,
			2,
			22,
			6,
			2,
			3,
			14,
			2,
			26,
			4,
			6,
			3,
			17,
			2,
			0,
			4,
			10,
			3,
			20,
			6,
			1,
			2,
			14,
			1,
			24,
			6,
			5,
			2,
			15,
			3,
			28,
			4,
			9,
			2,
			19,
			6,
			1,
			1,
			12,
			3,
			23,
			5,
			3,
			3,
			15,
			1,
			27,
			5,
			7,
			3,
			17,
			3,
			29,
			4,
			11,
			2,
			21,
			6,
			1,
			3,
			12,
			2,
			25,
			4,
			5,
			3,
			16,
			2,
			28,
			4,
			9,
			3,
			19,
			6,
			30,
			2,
			12,
			1,
			23,
			6,
			4,
			2,
			14,
			3,
			26,
			4,
			8,
			2,
			18,
			3,
			0,
			4,
			10,
			3,
			22,
			5,
			2,
			3,
			14,
			1,
			25,
			5,
			6,
			3,
			16,
			3,
			28,
			4,
			9,
			2,
			20,
			6,
			30,
			3,
			11,
			2,
			23,
			4,
			4,
			3,
			15,
			2,
			27,
			4,
			7,
			3,
			19,
			2,
			29,
			6,
			11,
			1,
			21,
			6,
			3,
			2,
			13,
			3,
			25,
			4,
			6,
			2,
			17,
			3,
			27,
			6,
			9,
			1,
			20,
			5,
			30,
			3,
			10,
			3,
			22,
			4,
			3,
			2,
			14,
			3,
			24,
			6,
			5,
			2,
			17,
			1,
			28,
			6,
			9,
			2,
			21,
			4,
			1,
			3,
			13,
			2,
			23,
			6,
			5,
			1,
			16,
			2,
			27,
			6,
			7,
			3,
			19,
			4,
			30,
			2,
			11,
			3,
			23,
			4,
			3,
			3,
			14,
			2,
			25,
			6,
			5,
			3,
			16,
			2,
			28,
			4,
			9,
			3,
			21,
			4,
			2,
			2,
			12,
			3,
			23,
			6,
			4,
			2,
			16,
			1,
			26,
			6,
			8,
			2,
			20,
			4,
			30,
			3,
			11,
			2,
			22,
			6,
			4,
			1,
			14,
			3,
			25,
			5,
			6,
			3,
			18,
			1,
			29,
			5,
			9,
			3,
			22,
			4,
			2,
			3,
			13,
			2,
			23,
			6,
			4,
			3,
			15,
			2,
			27,
			4,
			7,
			3,
			20,
			4,
			1,
			2,
			11,
			3,
			21,
			6,
			3,
			2,
			15,
			1,
			25,
			6,
			6,
			2,
			17,
			3,
			29,
			4,
			10,
			2,
			20,
			6,
			3,
			1,
			13,
			3,
			24,
			5,
			4,
			3,
			17,
			1,
			28,
			5,
			8,
			3,
			18,
			6,
			1,
			1,
			12,
			2,
			22,
			6,
			2,
			3,
			14,
			2,
			26,
			4,
			6,
			3,
			17,
			2,
			28,
			6,
			10,
			1,
			20,
			6,
			1,
			2,
			12,
			3,
			24,
			4,
			5,
			2,
			15,
			3,
			28,
			4,
			9,
			2,
			19,
			6,
			33,
			3,
			12,
			1,
			23,
			5,
			3,
			3,
			13,
			3,
			25,
			4,
			6,
			2,
			16,
			3,
			26,
			6,
			8,
			2,
			20,
			4,
			30,
			3,
			11,
			2,
			24,
			4,
			4,
			3,
			15,
			2,
			25,
			6,
			8,
			1,
			18,
			6,
			33,
			2,
			9,
			3,
			22,
			4,
			3,
			2,
			13,
			3,
			25,
			4,
			6,
			3,
			17,
			2,
			27,
			6,
			9,
			1,
			21,
			5,
			1,
			3,
			11,
			3,
			23,
			4,
			5,
			2,
			15,
			3,
			25,
			6,
			6,
			2,
			19,
			4,
			33,
			3,
			10,
			2,
			22,
			4,
			3,
			3,
			14,
			2,
			24,
			6,
			6,
			1
		};

		// Token: 0x04003623 RID: 13859
		private static readonly int[,] LunarMonthLen = new int[,]
		{
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			},
			{
				0,
				30,
				29,
				29,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				0
			},
			{
				0,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				0
			},
			{
				0,
				30,
				30,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29,
				0
			},
			{
				0,
				30,
				29,
				29,
				29,
				30,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29
			},
			{
				0,
				30,
				29,
				30,
				29,
				30,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29
			},
			{
				0,
				30,
				30,
				30,
				29,
				30,
				30,
				29,
				30,
				29,
				30,
				29,
				30,
				29
			}
		};

		// Token: 0x04003624 RID: 13860
		internal static readonly DateTime calendarMinValue = new DateTime(1583, 1, 1);

		// Token: 0x04003625 RID: 13861
		internal static readonly DateTime calendarMaxValue = new DateTime(new DateTime(2239, 9, 29, 23, 59, 59, 999).Ticks + 9999L);

		// Token: 0x04003626 RID: 13862
		private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 5790;

		// Token: 0x0200098D RID: 2445
		internal class __DateBuffer
		{
			// Token: 0x04003627 RID: 13863
			internal int year;

			// Token: 0x04003628 RID: 13864
			internal int month;

			// Token: 0x04003629 RID: 13865
			internal int day;
		}
	}
}
